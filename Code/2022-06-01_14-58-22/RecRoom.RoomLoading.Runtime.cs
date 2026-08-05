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
public class HEEAANIDINM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD620", Offset = "0x2BAC020", VA = "0x182BAD620")]
	public HEEAANIDINM(string OLLHPIFFHKE, Exception PPCNBKCPFIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface HOOKBPHHIKC : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EGCKGKGHDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task IDGNJOIFACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLAIBIPILGA(Task MLPEOOKMEFP, string IIMPNEACEPL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface CEPOOFBIBMM : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JDGNNAPEBEJ(NJHEDNCKIJM APIOJDDPFOL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HGCPMOIJMFK(CancellationToken PKFOPLIPJOL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface DPKOEPIJBOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JLKNDHAHCNN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FDMOMPKDGBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long HGIPPLDKCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long JIKIOPCFGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly JLKNDHAHCNN IEADHAAGEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception JPEFEHGGDOG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3330", Offset = "0x2DF1D30", VA = "0x182DF3330")]
	public FDMOMPKDGBE(long HGIPPLDKCNK, long JIKIOPCFGON, JLKNDHAHCNN IEADHAAGEDA, [CanBeNull] Exception JPEFEHGGDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2DF32E0", Offset = "0x2DF1CE0", VA = "0x182DF32E0")]
	public static FDMOMPKDGBE LOLOAKHPFFF(EIEGHKKPADG KAIPHDLCEKB, JLKNDHAHCNN IEADHAAGEDA, [Optional] Exception JPEFEHGGDOG)
	{
		return default(FDMOMPKDGBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void EPPHPLBOEJC(FDMOMPKDGBE FPEKAOBNGCK);
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface NIABJPKJCMD : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EPPHPLBOEJC KJLJIPKHPAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EPPHPLBOEJC FPBPKJNECOB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EPPHPLBOEJC BDGJCAFGKLA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GAOKLCNPDGN(FDMOMPKDGBE FPEKAOBNGCK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EBGNKMDNMCC(FDMOMPKDGBE FPEKAOBNGCK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGPMPLMKPIA(FDMOMPKDGBE FPEKAOBNGCK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface OMKGECBJNEK : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AENGCFPNOMJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDOHDPHFLJH();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLAMBKCHHCD();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate Task AHPHAIOFEGO(HDNBAJBNCBH HEOCEKKLPPE, CancellationToken LBAGELALLHA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface JFAAGEHHCFD : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EOMIMCCNBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIBGNNBICBN(AHPHAIOFEGO HMPMNDLAMDI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface JDEPENEFOAM : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TaskStatus JNGIMNOJDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NEMJOOANPBK(EIEGHKKPADG JKIPODEFHOD, CancellationToken ADDHBCOAOKN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class CHLILNDPOON
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2DE94B0", Offset = "0x2DE7EB0", VA = "0x182DE94B0")]
	public static bool OFAEDHPNPLG(this JDEPENEFOAM ELOADBKILOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface GAMFAADDNHJ : JHJHNDKMFBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CancellationToken AOPDEPCCOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CJNCHJOFGJN DDOIJKPHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KEFEPKNHJHI APAFAKPNNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EAKLELMEGDF BBGLKNGHAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BAIGNLCNAMC IKLAEDAILJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BMJHIJGIHGM KJMBEAEOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MNECIJJBOAL IKMDCFJBPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HOOKBPHHIKC GDKMMHJIOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CEPOOFBIBMM DOHIPGMINCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NIABJPKJCMD CJLEBMMOPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OMKGECBJNEK MNPKBOIHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	JDEPENEFOAM COGIEBGOIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JFAAGEHHCFD EGDHBGFBIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BPPDNANDNDB FHBEHPNHNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IBEPLKOCALD DDMELHLGJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GJJOAPPDBKN DCCAMHDMBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FIHHLCBDMCC DLKLCLANANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GBKNPMBJKLA NCPJJBOMGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NGOICDDIJMO JPCEHABIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	HLBFLCJFNGM KGNPEDFDMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LKPEOKGLEIP LHJALKFPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ALHFDBOHJIN IMJOMNBOFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DFHDFBNFFBP BLMLOOLKCLD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OIHJGGELKGL EJIOOOLBGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal interface BPPDNANDNDB : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FPMDPHKGJII CEGAKGBDODP(Guid BJDJCGIBLIK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFDJPGANONL(Guid BJDJCGIBLIK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFACJPEHBKE(Guid BJDJCGIBLIK, Task ANPGFIHKBFF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAFABMKBGDH(Guid BJDJCGIBLIK, DHCFGHIPPFB EAPFGLOBCJJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KLAMBKCHHCD(Guid BJDJCGIBLIK);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(DHCFGHIPPFB, Task)> DNNGOONDEEP(Guid BJDJCGIBLIK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface IBEPLKOCALD : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AENGCFPNOMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface GJJOAPPDBKN : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECKOOHMJIHG(IBNMHBIHLHI OLLHPIFFHKE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIOBOBADHBG(IBNMHBIHLHI OLLHPIFFHKE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MIPGNLMFNJL> OMDBMKJJNDC(CancellationToken PNEFOCIGKAG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate DHCFGHIPPFB PLCOBMNIMKM(AOLOIKMEGKC ODBLFFPEOCH, MIPGNLMFNJL ILPIAGJEDOB);
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface FIHHLCBDMCC : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FPMDPHKGJII DGEIJMLCKCK(LEGMEMBDHLK NGKDCPJACLB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNDCBHBIAJB(Guid BJDJCGIBLIK, Task ANPGFIHKBFF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface GBKNPMBJKLA : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DHCFGHIPPFB> NCPJJBOMGAJ(AOLOIKMEGKC LIIIKAIOJCL, MIPGNLMFNJL FMMHCELCDCN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface NGOICDDIJMO : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKPNDOLIOLF> AOFECJFNCOB(FLDAJIIDCOG FENCPFKHOGO, EIEGHKKPADG JKIPODEFHOD, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKPNDOLIOLF AFOAKOIPNIL(CKEPHPBIHBC IIBONGAMCMF, long BMNHGDIENAL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface LKPEOKGLEIP : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHCFGHIPPFB HCBCEBADJEP(AOLOIKMEGKC ODBLFFPEOCH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MOHMALNHKDO(string JAFIMCJAMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface HLBFLCJFNGM : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEEGCHIFHAD();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEPELHGAALN();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IBNMHBIHLHI> GPKNMGLBHCO(IBNMHBIHLHI LKGBFLLCPJC, KKFCNNLFPAP EELJAPPDPDP, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<IBNMHBIHLHI> BJNLLLEFHDK(CancellationToken PKFOPLIPJOL, KKFCNNLFPAP EELJAPPDPDP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FLDAJIIDCOG GLBNPABFJMC(KHCJOIGIKIA HAGONGAFGEL, BDMELKPFPFB BCIAJNNCADP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FLDAJIIDCOG EBMHDBDGPPA(KHCJOIGIKIA HAGONGAFGEL, BDMELKPFPFB BCIAJNNCADP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface ALHFDBOHJIN : DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHCFGHIPPFB JFJKBNCCKDG(AOLOIKMEGKC ODBLFFPEOCH, MIPGNLMFNJL ILPIAGJEDOB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DHCFGHIPPFB JOOLELFOOPG(AOLOIKMEGKC KKEEDEKJPEA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DHCFGHIPPFB GHMGCGGADFI(AOLOIKMEGKC KKEEDEKJPEA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DFHDFBNFFBP
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKGDLNCBEBA(MFNNMCJOCHN CIMBDOLFNLJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNKEKDGAHCN(MFNNMCJOCHN CIMBDOLFNLJ);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMAMPOGALDL(MFNNMCJOCHN CIMBDOLFNLJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANPOHNNIMLH(MFNNMCJOCHN CIMBDOLFNLJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MFNNMCJOCHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly EIEGHKKPADG NNBMIMAOAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> PDKGFCKEAIL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BDMELKPFPFB MLFMKCDNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
	public MFNNMCJOCHN(EIEGHKKPADG KHFJEPJKLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD890", Offset = "0x2EBC290", VA = "0x182EBD890")]
	public MFNNMCJOCHN HNPODDNCAEG(string IPKOPOLJGIA, string HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD810", Offset = "0x2EBC210", VA = "0x182EBD810")]
	public bool GLOBICCHCNE(out IEnumerable<KeyValuePair<string, string>> NIIEJDANKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA35600", Offset = "0xA34000", VA = "0x180A35600")]
	public MFNNMCJOCHN GAHPHNHOFOI(BDMELKPFPFB IHHDBHELEOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JHJHNDKMFBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OFAEDHPNPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HFJEPLHPCMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EPPHPLBOEJC KJLJIPKHPAE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EPPHPLBOEJC FPBPKJNECOB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event EPPHPLBOEJC BDGJCAFGKLA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MDOHDPHFLJH();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<DHCFGHIPPFB> IGGMJJMCPCH();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<DHCFGHIPPFB> EDPLLKEABBD(AOLOIKMEGKC OOPABNNBEGO);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<DHCFGHIPPFB> DFKMPLBCJBJ(int LCAHHDBJIIE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task MOHMALNHKDO(string JAFIMCJAMAD);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task JDGNNAPEBEJ(NJHEDNCKIJM APIOJDDPFOL = NJHEDNCKIJM.Incremental);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HGCPMOIJMFK(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AFKMBADMBCN(long BMNHGDIENAL);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LELFIJGPFLF(long BMNHGDIENAL, out DateTime CJKCHPDBFLM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EFFFPKFCLCK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	int OHDODBPHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BPKEANBAFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NICJGJDEPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OGNAKBLICIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BDDGCJAGNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DKEAFMFMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PNGCBNKAHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MGDCOMKHJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HFJIGJBPAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AOLOIKMEGKC CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIHGPEMCMMO(CJNCHJOFGJN EIBONOODANC);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task DNEEFMFPMFG(BDMELKPFPFB BCIAJNNCADP, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task JKEJFKFBLFG(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task OJHLBKPCIAE(FGHAEGNIFPP DJKMPMKHOMN, [Optional] CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<HHGMDBAJPNF> CAOPFFKOHIL();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable NAAIIIAMKAE(object PHFLFPJELLC, HHGMDBAJPNF DGLEBIDEHNN);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ABOLFMDIBBK();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BOEMNJMLBAI KDCLABOGPCF();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IFEMJJOILDH(int KBMDCHONHBO);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task GJODDKEILFI();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CGBKCFMNAEH();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool IOKNOFNEHLC();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task IAJKMIOLGFG(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task PBDMDOAKEJN(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> DHHMAMOBGBD(DateTime JDHBHIOHNNJ, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<bool> JPJIPGOJILM(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CEFFIOHCMEK();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AOHCNBFBMEE EJEIPGIKNMO(MNMBCBCHLOJ NJMDDMONPLI, CHOOKADKDAN IKAHABFIMGO, IEnumerable<PersistenceView> BJAKNFDMBDH, ref JMNPLECCMGL ONALLFHBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PJHOAIFOGBH(CLMIJCBDJCL HAJNGGOKBGL, in AOHCNBFBMEE ALGFBOLCGGP);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NDHKIIGKPMH(CHOOKADKDAN ECIMCDMIDOH, bool ECHPMPAIHFN);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CKDOOMEEBJE(long GJMALLKLAFM, long JIKIOPCFGON, CKEPHPBIHBC DPJGGPJKICA, DLFFBEKDBKJ JGNEEDFLDJO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EFHABMKCDNC(long GJMALLKLAFM, long JIKIOPCFGON);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IDEKIPILCON(PersistenceView MNLMPJACBHD);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool ALNAKCCONJC(PersistenceView DBBJEPNCCKL);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool IJODCBJNBIM(CLMIJCBDJCL HAJNGGOKBGL, FCKLLFFBIPN CAOCAFFDJFH, Dictionary<int, int> POHFDJPLHHK, out HEAHFCDCNLA OLJLCILMJLC);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GDKMKMOODCJ();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DLFDOAPDLLD();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable AEMCBGDHMDB();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Dictionary<int, int> HJCBFKPFPOI(CHOOKADKDAN ECIMCDMIDOH, FCKLLFFBIPN CAOCAFFDJFH);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task FEJBAELIHOP(KEFEPKNHJHI PLCGLJPJKBH, CancellationToken PKFOPLIPJOL, BDMELKPFPFB BCIAJNNCADP);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void AJHDPKCCINP(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<CKEPHPBIHBC> ALEPBELMCGK(long GJMALLKLAFM, long JIKIOPCFGON, string BJDGKPHFIPK, string HDCBOHIJGAK, Dictionary<long, int> MKGDFJGEOKO, int HLHIANOGMJF);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<CKEPHPBIHBC> GHGBIPFFKHK(long GJMALLKLAFM, bool HCJPPIFFDPC, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool DJHNLMLKKIH();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool HDOPCHLKFGO();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "46")]
	GameObject[] PINIDPNBEBN(NAMOPKHHODN[] IIEJDOKEKKC);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void FKPBBOAMHBG(List<GameObject> PEBJLDBNMGG);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float COJBDNPDOIB();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task GDGJOKEICCO(string JEOEEAOHALB, LoadSceneMode HLMBMDEJHAE, bool LHMAJLKAIIL, BDMELKPFPFB IHHDBHELEOM);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void BCPOKAGBBMA(EIEGHKKPADG OIDHBEAPDPM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void ILKMHPAJMAF(string FMMHCELCDCN, AOLOIKMEGKC LIIIKAIOJCL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task KJIMMBBCEAK(BDMELKPFPFB BCIAJNNCADP, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task ELPAFLMPEHB(BDMELKPFPFB BCIAJNNCADP, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void ANENOCJECCN();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "55")]
	IDisposable GEEPGEOKENF();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "56")]
	OMEGIBOKOOC NBCLPMPPCOE();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OMEGIBOKOOC
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DAFFAOKEPNA(CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EONDLJNNMGE(CancellationToken PKFOPLIPJOL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AOHCNBFBMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> OKEDEJMAAOO;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HILJJCHPOOA
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EIEGHKKPADG DNBEDDCPFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CKEPHPBIHBC BJPIDNMIODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ALDJHDJCCBC OOCEGCAECAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool IHHINDEMKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool NFODFEDHMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int OHDODBPHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action MPPDCEIFADC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<int> MALCBNGHKFC;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNGCPIOIJCO();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.DJABNCIFOJD> LNHOLLHKKKJ();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FMBMPIKHCLJ();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EIEGHKKPADG KBAOKOIICMB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CGDIABNKEOO OCKNOHBJDAG();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BFNAPPCAKOC(long CDHBDGDIGPK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OIHJGGELKGL
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABPLPFMAJLJ(out IEnumerable<int> HMEBFKJCPBA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGGELEMCAAH(EHMHBECLOPG LBAGELALLHA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBABJKNHFOA(EHMHBECLOPG LBAGELALLHA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CHLGLGDLKCC
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HLEHLNCAKOF(DHCFGHIPPFB ADGIOGKBNDL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal sealed class HPPOBILMAAK : JHJHNDKMFBM, IDisposable, GAMFAADDNHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DCBECMCKLPI : IEnumerable<DPKOEPIJBOG>, IEnumerable, IEnumerator<DPKOEPIJBOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private DPKOEPIJBOG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public HPPOBILMAAK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private DPKOEPIJBOG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public DCBECMCKLPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8360", Offset = "0x2BA6D60", VA = "0x182BA8360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8770", Offset = "0x2BA7170", VA = "0x182BA8770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2BA86D0", Offset = "0x2BA70D0", VA = "0x182BA86D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DPKOEPIJBOG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2BA86D0", Offset = "0x2BA70D0", VA = "0x182BA86D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource DLMIKHKIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CJNCHJOFGJN EIBONOODANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool KIHCNAMPEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private EFCLJCNLCBG CGHLPLLLCHB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KEFEPKNHJHI APAFAKPNNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x61EF90", Offset = "0x61D990", VA = "0x18061EF90", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A3390", Offset = "0x6A1D90", VA = "0x1806A3390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EAKLELMEGDF BBGLKNGHAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5AC380", Offset = "0x5AAD80", VA = "0x1805AC380", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x63C800", Offset = "0x63B200", VA = "0x18063C800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x599EB0", Offset = "0x5988B0", VA = "0x180599EB0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1A0", Offset = "0x5EDBA0", VA = "0x1805EF1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BAIGNLCNAMC IKLAEDAILJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x58E2C0", Offset = "0x58CCC0", VA = "0x18058E2C0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x567520", Offset = "0x565F20", VA = "0x180567520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BMJHIJGIHGM KJMBEAEOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x58E2B0", Offset = "0x58CCB0", VA = "0x18058E2B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A3510", Offset = "0x6A1F10", VA = "0x1806A3510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MNECIJJBOAL IKMDCFJBPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2C0", Offset = "0x5AACC0", VA = "0x1805AC2C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x58E2D0", Offset = "0x58CCD0", VA = "0x18058E2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HOOKBPHHIKC GDKMMHJIOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2D0", Offset = "0x5AACD0", VA = "0x1805AC2D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x599EE0", Offset = "0x5988E0", VA = "0x180599EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CEPOOFBIBMM DOHIPGMINCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x59BB10", Offset = "0x59A510", VA = "0x18059BB10", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x599EC0", Offset = "0x5988C0", VA = "0x180599EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NIABJPKJCMD CJLEBMMOPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C1C90", Offset = "0x5C0690", VA = "0x1805C1C90", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6B1140", Offset = "0x6AFB40", VA = "0x1806B1140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public OMKGECBJNEK MNPKBOIHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6363A0", Offset = "0x634DA0", VA = "0x1806363A0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x85FB80", Offset = "0x85E580", VA = "0x18085FB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JDEPENEFOAM COGIEBGOIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6363E0", Offset = "0x634DE0", VA = "0x1806363E0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0790", Offset = "0x6AF190", VA = "0x1806B0790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public JFAAGEHHCFD EGDHBGFBIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5AC340", Offset = "0x5AAD40", VA = "0x1805AC340", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x599ED0", Offset = "0x5988D0", VA = "0x180599ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public BPPDNANDNDB FHBEHPNHNIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5AC350", Offset = "0x5AAD50", VA = "0x1805AC350", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B20", Offset = "0x7F3520", VA = "0x1807F4B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IBEPLKOCALD DDMELHLGJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C1DA0", Offset = "0x5C07A0", VA = "0x1805C1DA0", Slot = "37")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x563860", Offset = "0x562260", VA = "0x180563860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GJJOAPPDBKN DCCAMHDMBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5AC360", Offset = "0x5AAD60", VA = "0x1805AC360", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x563850", Offset = "0x562250", VA = "0x180563850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FIHHLCBDMCC DLKLCLANANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5637F0", Offset = "0x5621F0", VA = "0x1805637F0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x563870", Offset = "0x562270", VA = "0x180563870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GBKNPMBJKLA NCPJJBOMGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A1500", Offset = "0x69FF00", VA = "0x1806A1500", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BE0", Offset = "0x6A05E0", VA = "0x1806A1BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NGOICDDIJMO JPCEHABIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x565850", Offset = "0x564250", VA = "0x180565850", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x565CF0", Offset = "0x5646F0", VA = "0x180565CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HLBFLCJFNGM KGNPEDFDMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x565A90", Offset = "0x564490", VA = "0x180565A90", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x565E50", Offset = "0x564850", VA = "0x180565E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public LKPEOKGLEIP LHJALKFPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x585250", Offset = "0x583C50", VA = "0x180585250", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x586BD0", Offset = "0x5855D0", VA = "0x180586BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ALHFDBOHJIN IMJOMNBOFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x564BA0", Offset = "0x5635A0", VA = "0x180564BA0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A2520", Offset = "0x6A0F20", VA = "0x1806A2520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DFHDFBNFFBP BLMLOOLKCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x565830", Offset = "0x564230", VA = "0x180565830", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A2510", Offset = "0x6A0F10", VA = "0x1806A2510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public OIHJGGELKGL EJIOOOLBGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x565840", Offset = "0x564240", VA = "0x180565840", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x565CE0", Offset = "0x5646E0", VA = "0x180565CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private bool FMIAHANCIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1520", Offset = "0x2BAFF20", VA = "0x182BB1520", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private bool HPKBKCHGMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB14B0", Offset = "0x2BAFEB0", VA = "0x182BB14B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private CancellationToken HGFPPNHMPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1CE0", Offset = "0x2BB06E0", VA = "0x182BB1CE0", Slot = "22")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private CJNCHJOFGJN KBJFMFJFLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	private event EPPHPLBOEJC NBKJKHDFJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1580", Offset = "0x2BAFF80", VA = "0x182BB1580", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1C80", Offset = "0x2BB0680", VA = "0x182BB1C80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	private event EPPHPLBOEJC OALIKDDLMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BB19C0", Offset = "0x2BB03C0", VA = "0x182BB19C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1AF0", Offset = "0x2BB04F0", VA = "0x182BB1AF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event EPPHPLBOEJC DHFKNPCAACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1A20", Offset = "0x2BB0420", VA = "0x182BB1A20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1D80", Offset = "0x2BB0780", VA = "0x182BB1D80", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1DE0", Offset = "0x2BB07E0", VA = "0x182BB1DE0")]
	[Preserve]
	internal HPPOBILMAAK([GEKAHLKFDNK(null)] CJNCHJOFGJN EIBONOODANC, [GEKAHLKFDNK(null)] KEFEPKNHJHI PLCGLJPJKBH, [GEKAHLKFDNK(null)] EAKLELMEGDF OEBBMCFFNAO, [GEKAHLKFDNK(null)] EFFFPKFCLCK LNJKINMJMME, [GEKAHLKFDNK(null)] BAIGNLCNAMC DMBNABBACFM, [GEKAHLKFDNK(null)] BMJHIJGIHGM ECNEHOPLIKM, [GEKAHLKFDNK(null)] MNECIJJBOAL DCKFOICAOEN, [GEKAHLKFDNK(null)] HOOKBPHHIKC IGCMBEMFIBA, [GEKAHLKFDNK(null)] CEPOOFBIBMM CMIPDCCPHAA, [GEKAHLKFDNK(null)] NIABJPKJCMD ILOKCLLCFMA, [GEKAHLKFDNK(null)] OMKGECBJNEK LDHDCOPHAKB, [GEKAHLKFDNK(null)] JDEPENEFOAM ELOADBKILOC, [GEKAHLKFDNK(null)] JFAAGEHHCFD GJMNFBGPOLA, [GEKAHLKFDNK(null)] BPPDNANDNDB IIEEFGOCHKJ, [GEKAHLKFDNK(null)] IBEPLKOCALD IOFIEINFMIO, [GEKAHLKFDNK(null)] GJJOAPPDBKN PLNPIBEBPGM, [GEKAHLKFDNK(null)] FIHHLCBDMCC IIMNHODPMLD, [GEKAHLKFDNK(null)] GBKNPMBJKLA GCFMEHBBOLB, [GEKAHLKFDNK(null)] NGOICDDIJMO IABNOHPMMNP, [GEKAHLKFDNK(null)] LKPEOKGLEIP GGJDNGKJAJG, [GEKAHLKFDNK(null)] HLBFLCJFNGM HONEOMEIAHJ, [GEKAHLKFDNK(null)] ALHFDBOHJIN IMGAGGGPKGH, [GEKAHLKFDNK(null)] DFHDFBNFFBP JKMOOPNFHND, [GEKAHLKFDNK(null)] OIHJGGELKGL PNHJEKLCNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1BB0", Offset = "0x2BB05B0", VA = "0x182BB1BB0")]
	private void LPDEJFLNIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1340", Offset = "0x2BAFD40", VA = "0x182BB1340", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1530", Offset = "0x2BAFF30", VA = "0x182BB1530", Slot = "12")]
	private void GHLIPFFELJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1B50", Offset = "0x2BB0550", VA = "0x182BB1B50", Slot = "18")]
	private Task LMGEKLLJAOK(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB14A0", Offset = "0x2BAFEA0", VA = "0x182BB14A0", Slot = "19")]
	private void EGLCDJBCPJC(long BMNHGDIENAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2BB12D0", Offset = "0x2BAFCD0", VA = "0x182BB12D0", Slot = "20")]
	private bool BICKKHANEDO(long JIKIOPCFGON, out DateTime NKEFDOBBECL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2BB15E0", Offset = "0x2BAFFE0", VA = "0x182BB15E0", Slot = "16")]
	private Task IHJBBENGJOD(string JAFIMCJAMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1D00", Offset = "0x2BB0700", VA = "0x182BB1D00", Slot = "13")]
	private Task<DHCFGHIPPFB> NLPIJFIPNKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2BB16A0", Offset = "0x2BB00A0", VA = "0x182BB16A0", Slot = "14")]
	private Task<DHCFGHIPPFB> IIKLLMAJFLH(AOLOIKMEGKC OOPABNNBEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1710", Offset = "0x2BB0110", VA = "0x182BB1710", Slot = "15")]
	private Task<DHCFGHIPPFB> JEDKGOCLFHA(int LCAHHDBJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1830", Offset = "0x2BB0230", VA = "0x182BB1830", Slot = "17")]
	private Task KIPJJHFIBEF(NJHEDNCKIJM APIOJDDPFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1A80", Offset = "0x2BB0480", VA = "0x182BB1A80")]
	[IteratorStateMachine(typeof(DCBECMCKLPI))]
	private IEnumerable<DPKOEPIJBOG> LFKONCDHKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1270", Offset = "0x2BAFC70", VA = "0x182BB1270")]
	[CompilerGenerated]
	private void ABEMACCFBIP(DPKOEPIJBOG ENHKEICGIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class KGEJHKKMOLI : GOAINLGFOLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct GHJAOJIAEPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KGEJHKKMOLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2EB18B0", Offset = "0x2EB02B0", VA = "0x182EB18B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1B80", Offset = "0x2EB0580", VA = "0x182EB1B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x59B610", Offset = "0x59A010", VA = "0x18059B610")]
	public KGEJHKKMOLI(GAMFAADDNHJ CEMCPIENNAH, EFFFPKFCLCK LNJKINMJMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5CA0", Offset = "0x2EB46A0", VA = "0x182EB5CA0", Slot = "4")]
	[AsyncStateMachine(typeof(GHJAOJIAEPP))]
	public Task<bool> BLLJDDCMDDJ(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5DA0", Offset = "0x2EB47A0", VA = "0x182EB5DA0")]
	[CompilerGenerated]
	private object HDPOGIMCIID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class IGLDOMMIFDC : GOAINLGFOLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EJDHCJJNLLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public IGLDOMMIFDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9540", Offset = "0x2BA7F40", VA = "0x182BA9540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9BD0", Offset = "0x2BA85D0", VA = "0x182BA9BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private const float GOOFGMNBJJM = 45f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2930", Offset = "0x2BB1330", VA = "0x182BB2930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x59B610", Offset = "0x59A010", VA = "0x18059B610")]
	public IGLDOMMIFDC(GAMFAADDNHJ CEMCPIENNAH, EFFFPKFCLCK LNJKINMJMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2980", Offset = "0x2BB1380", VA = "0x182BB2980", Slot = "4")]
	[AsyncStateMachine(typeof(EJDHCJJNLLN))]
	public Task<bool> BLLJDDCMDDJ(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2AB0", Offset = "0x2BB14B0", VA = "0x182BB2AB0")]
	[CompilerGenerated]
	private object DOOPPBGPEJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class CJKIIIKJCOO : GOAINLGFOLM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class ILEPHPCBELF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CJKIIIKJCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Matchmaking.DJABNCIFOJD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public EIEGHKKPADG newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ILEPHPCBELF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2DF78E0", Offset = "0x2DF62E0", VA = "0x182DF78E0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2DF79A0", Offset = "0x2DF63A0", VA = "0x182DF79A0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7A00", Offset = "0x2DF6400", VA = "0x182DF7A00")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct CPAJNNPKDNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CJKIIIKJCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ILEPHPCBELF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter<Matchmaking.DJABNCIFOJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA700", Offset = "0x2DE9100", VA = "0x182DEA700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2DEAF20", Offset = "0x2DE9920", VA = "0x182DEAF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private const float GOOFGMNBJJM = 45f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9500", Offset = "0x2DE7F00", VA = "0x182DE9500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x59B610", Offset = "0x59A010", VA = "0x18059B610")]
	public CJKIIIKJCOO(GAMFAADDNHJ CEMCPIENNAH, EFFFPKFCLCK LNJKINMJMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9550", Offset = "0x2DE7F50", VA = "0x182DE9550", Slot = "4")]
	[AsyncStateMachine(typeof(CPAJNNPKDNI))]
	public Task<bool> BLLJDDCMDDJ(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GOAINLGFOLM
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BLLJDDCMDDJ(CancellationToken PKFOPLIPJOL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct HCHJCCIIDGJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HJLGLFJJBGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public GAMFAADDNHJ manager;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HJLGLFJJBGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0A10", Offset = "0x2BAF410", VA = "0x182BB0A10")]
		internal Task <CreateTask>b__0(HDNBAJBNCBH data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct FCIOFEMOOOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public HCHJCCIIDGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool <restore>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAD00", Offset = "0x2BA9700", VA = "0x182BAAD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAFF0", Offset = "0x2BA99F0", VA = "0x182BAAFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PGMDHEDCMCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public HCHJCCIIDGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB190", Offset = "0x2BB9B90", VA = "0x182BBB190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CancellationToken PKFOPLIPJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GAMFAADDNHJ CINEJONGELJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private KEFEPKNHJHI APAFAKPNNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD510", Offset = "0x2BABF10", VA = "0x182BAD510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD120", Offset = "0x2BABB20", VA = "0x182BAD120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2BACFE0", Offset = "0x2BAB9E0", VA = "0x182BACFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private CEPOOFBIBMM DOHIPGMINCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD0D0", Offset = "0x2BABAD0", VA = "0x182BAD0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD5E0", Offset = "0x2BABFE0", VA = "0x182BAD5E0")]
	public HCHJCCIIDGJ(CancellationToken PKFOPLIPJOL, GAMFAADDNHJ CINEJONGELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD380", Offset = "0x2BABD80", VA = "0x182BAD380")]
	public static AHPHAIOFEGO MMCJBKCJLJK(GAMFAADDNHJ CINEJONGELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2BACED0", Offset = "0x2BAB8D0", VA = "0x182BACED0")]
	[AsyncStateMachine(typeof(FCIOFEMOOOB))]
	public Task<bool> ADLAMHIBLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD170", Offset = "0x2BABB70", VA = "0x182BAD170")]
	private bool GCIJHMLCNIO(out FileInfo PIBAFNMFDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD410", Offset = "0x2BABE10", VA = "0x182BAD410")]
	[AsyncStateMachine(typeof(PGMDHEDCMCC))]
	private Task NGFEPOAGBAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD260", Offset = "0x2BABC60", VA = "0x182BAD260")]
	private Task<bool> KMPGFBFAAEG(FileInfo PIBAFNMFDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD560", Offset = "0x2BABF60", VA = "0x182BAD560")]
	private Task PPDGCGKFLEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD060", Offset = "0x2BABA60", VA = "0x182BAD060")]
	private void CABBOJPDDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal struct FPMDPHKGJII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly BPPDNANDNDB IIEEFGOCHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Guid BJDJCGIBLIK;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private Task<(DHCFGHIPPFB, Task)> ALDIDLIEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC050", Offset = "0x2BAAA50", VA = "0x182BAC050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1503F60", Offset = "0x1502960", VA = "0x181503F60")]
	public FPMDPHKGJII(BPPDNANDNDB IIEEFGOCHKJ, Guid BJDJCGIBLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2BABF30", Offset = "0x2BAA930", VA = "0x182BABF30")]
	public TaskAwaiter<(DHCFGHIPPFB, Task)> AHCALHJOPKE()
	{
		return default(TaskAwaiter<(DHCFGHIPPFB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2BABF80", Offset = "0x2BAA980", VA = "0x182BABF80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal struct GLOGEJFGABJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly TaskCompletionSource<(DHCFGHIPPFB, Task)> NFAEGPHJFDG;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Task<(DHCFGHIPPFB, Task)> ALDIDLIEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC550", Offset = "0x2BAAF50", VA = "0x182BAC550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC590", Offset = "0x2BAAF90", VA = "0x182BAC590")]
	public GLOGEJFGABJ(TimeSpan BMNHOPLJPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC3A0", Offset = "0x2BAADA0", VA = "0x182BAC3A0")]
	public void AJCALKKFEMB(Task ANPGFIHKBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC4C0", Offset = "0x2BAAEC0", VA = "0x182BAC4C0")]
	public void ILFLFPLKHOP(DHCFGHIPPFB ADGIOGKBNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC470", Offset = "0x2BAAE70", VA = "0x182BAC470")]
	public void DODBOPENJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC320", Offset = "0x2BAAD20", VA = "0x182BAC320")]
	internal void AHGIEADGFIP(string OLLHPIFFHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Preserve]
internal class KBDPMMPFLCG : HOOKBPHHIKC, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IBGGBNEJPNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KBDPMMPFLCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2110", Offset = "0x2BB0B10", VA = "0x182BB2110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EHMHBECLOPG AGICNMBPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private string JBKAMGNCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private Task FALKHBNIFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool EGCKGKGHDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8000", Offset = "0x2BB6A00", VA = "0x182BB8000", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Task IDGNJOIFACO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7CF0", Offset = "0x2BB66F0", VA = "0x182BB7CF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x751CA0", Offset = "0x7506A0", VA = "0x180751CA0", Slot = "7")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7E80", Offset = "0x2BB6880", VA = "0x182BB7E80", Slot = "6")]
	public void JLAIBIPILGA(Task MLPEOOKMEFP, string IIMPNEACEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7D50", Offset = "0x2BB6750", VA = "0x182BB7D50")]
	[AsyncStateMachine(typeof(IBGGBNEJPNE))]
	private Task JEADJIKLOOK(Task MNAJJFFNLAC, string IIMPNEACEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8030", Offset = "0x2BB6A30", VA = "0x182BB8030")]
	public KBDPMMPFLCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Preserve]
internal class NAKMFKPDAFA : NIABJPKJCMD, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class CHMKGEFMKKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public FDMOMPKDGBE roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public CHMKGEFMKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2EAFB70", Offset = "0x2EAE570", VA = "0x182EAFB70")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event EPPHPLBOEJC KJLJIPKHPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF120", Offset = "0x2EBDB20", VA = "0x182EBF120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEE40", Offset = "0x2EBD840", VA = "0x182EBEE40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event EPPHPLBOEJC FPBPKJNECOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEFE0", Offset = "0x2EBD9E0", VA = "0x182EBEFE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF080", Offset = "0x2EBDA80", VA = "0x182EBF080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event EPPHPLBOEJC BDGJCAFGKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEB50", Offset = "0x2EBD550", VA = "0x182EBEB50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEF10", Offset = "0x2EBD910", VA = "0x182EBEF10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "13")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2EBEFB0", Offset = "0x2EBD9B0", VA = "0x182EBEFB0", Slot = "10")]
	public void GAOKLCNPDGN(FDMOMPKDGBE FPEKAOBNGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBEEE0", Offset = "0x2EBD8E0", VA = "0x182EBEEE0", Slot = "11")]
	public void EBGNKMDNMCC(FDMOMPKDGBE FPEKAOBNGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EBF1C0", Offset = "0x2EBDBC0", VA = "0x182EBF1C0", Slot = "12")]
	public void OGPMPLMKPIA(FDMOMPKDGBE FPEKAOBNGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2EBEBF0", Offset = "0x2EBD5F0", VA = "0x182EBEBF0")]
	private void DAJKIBHPPOA(EPPHPLBOEJC DGLEBIDEHNN, FDMOMPKDGBE FPEKAOBNGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public NAKMFKPDAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Preserve]
internal class DCNGFHNDIOO : OMKGECBJNEK, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OEGLCIENEFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DCNGFHNDIOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA1D0", Offset = "0x2DF8BD0", VA = "0x182DFA1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct CPHBHMLOMNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DCNGFHNDIOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2DEAF70", Offset = "0x2DE9970", VA = "0x182DEAF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DJLAAMGOICH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DJLAAMGOICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0BD0", Offset = "0x2DEF5D0", VA = "0x182DF0BD0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JELFECFLGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DCNGFHNDIOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private DJLAAMGOICH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7A90", Offset = "0x2DF6490", VA = "0x182DF7A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8150", Offset = "0x2DF6B50", VA = "0x182DF8150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HICHMDDDPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HICHMDDDPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5EC0", Offset = "0x2DF48C0", VA = "0x182DF5EC0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private GOAINLGFOLM[] PNOEMPBEBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private CancellationTokenSource LNHBGENCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int GPDKOEPKEOK;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC940", Offset = "0x2DEB340", VA = "0x182DEC940", Slot = "7")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC320", Offset = "0x2DEAD20", VA = "0x182DEC320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC6D0", Offset = "0x2DEB0D0", VA = "0x182DEC6D0", Slot = "6")]
	public void KLAMBKCHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC9C0", Offset = "0x2DEB3C0", VA = "0x182DEC9C0", Slot = "5")]
	public void MDOHDPHFLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBEF0", Offset = "0x2DEA8F0", VA = "0x182DEBEF0", Slot = "4")]
	[AsyncStateMachine(typeof(OEGLCIENEFP))]
	public Task AENGCFPNOMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC000", Offset = "0x2DEAA00", VA = "0x182DEC000")]
	private void DPGHPOGFGEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC4C0", Offset = "0x2DEAEC0", VA = "0x182DEC4C0")]
	[AsyncStateMachine(typeof(CPHBHMLOMNC))]
	private Task IGABAJPDFLM(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2DECB10", Offset = "0x2DEB510", VA = "0x182DECB10")]
	[AsyncStateMachine(typeof(JELFECFLGMA))]
	private Task<bool> NEFLHMAKBLG(int LGBFGOJBLFK, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBDD0", Offset = "0x2DEA7D0", VA = "0x182DEBDD0")]
	private void AANFAIAGFPN(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC840", Offset = "0x2DEB240", VA = "0x182DEC840")]
	private void LOCHAMBHHPD(int LGBFGOJBLFK, bool BJALHGCPBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC330", Offset = "0x2DEAD30", VA = "0x182DEC330")]
	private void GDEPNHDMHIL(int LGBFGOJBLFK, Exception KILOBDNKPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2DEC5E0", Offset = "0x2DEAFE0", VA = "0x182DEC5E0")]
	private void ILPIHEHLNJF(CancellationToken PKFOPLIPJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public DCNGFHNDIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Preserve]
internal class OAKIKDPOMEI : JFAAGEHHCFD, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KDEHFGBOKGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OAKIKDPOMEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public HDNBAJBNCBH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2EB55C0", Offset = "0x2EB3FC0", VA = "0x182EB55C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BPCOLJPPOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public OAKIKDPOMEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HDNBAJBNCBH roomData;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BPCOLJPPOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2EAFB00", Offset = "0x2EAE500", VA = "0x182EAFB00")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct LCPELGMBOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AHPHAIOFEGO taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB88E0", Offset = "0x2EB72E0", VA = "0x182EB88E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CKNOCONJGIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OAKIKDPOMEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2EAFC50", Offset = "0x2EAE650", VA = "0x182EAFC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HashSet<AHPHAIOFEGO> DAAHEAPCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private EAKLELMEGDF OEBBMCFFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private HHGMDBAJPNF MDAOBDFEGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ADCOBFHDEHP CIJLINMKMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IDisposable LJFMPAPCEGM;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool EOMIMCCNBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC22E0", Offset = "0x2EC0CE0", VA = "0x182EC22E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	internal Task ALDIDLIEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC22F0", Offset = "0x2EC0CF0", VA = "0x182EC22F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1F50", Offset = "0x2EC0950", VA = "0x182EC1F50", Slot = "6")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2EC19B0", Offset = "0x2EC03B0", VA = "0x182EC19B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1BC0", Offset = "0x2EC05C0", VA = "0x182EC1BC0", Slot = "5")]
	public bool HIBGNNBICBN(AHPHAIOFEGO HMPMNDLAMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1C20", Offset = "0x2EC0620", VA = "0x182EC1C20")]
	private void IMAJEJALNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2EC12C0", Offset = "0x2EBFCC0", VA = "0x182EC12C0")]
	private void CINCJNIOMCG(HDNBAJBNCBH HEOCEKKLPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1D60", Offset = "0x2EC0760", VA = "0x182EC1D60")]
	[AsyncStateMachine(typeof(KDEHFGBOKGC))]
	private Task INJLFGAGOHG(HDNBAJBNCBH HEOCEKKLPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1A10", Offset = "0x2EC0410", VA = "0x182EC1A10")]
	private Func<CancellationToken, List<Task>> EHCDPHKMMBA(HDNBAJBNCBH HEOCEKKLPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1510", Offset = "0x2EBFF10", VA = "0x182EC1510")]
	private List<Task> DGOOIBNLDAA(HDNBAJBNCBH HEOCEKKLPPE, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2EC21B0", Offset = "0x2EC0BB0", VA = "0x182EC21B0")]
	[AsyncStateMachine(typeof(LCPELGMBOBD))]
	private Task NJLIIOEBIFI(AHPHAIOFEGO FOGDOPGHCLC, HDNBAJBNCBH CIBAGEDPOOH, CancellationToken LBAGELALLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1AC0", Offset = "0x2EC04C0", VA = "0x182EC1AC0")]
	[AsyncStateMachine(typeof(CKNOCONJGIO))]
	private Task FGEACIOAGDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1E80", Offset = "0x2EC0880", VA = "0x182EC1E80")]
	private void KLAMBKCHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2300", Offset = "0x2EC0D00", VA = "0x182EC2300")]
	public OAKIKDPOMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Preserve]
internal class DEJJAOPEKEG : JDEPENEFOAM, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct IFCBBHBIFIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6BC0", Offset = "0x2DF55C0", VA = "0x182DF6BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct AJDKKDOIKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private BDMELKPFPFB <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private KKFCNNLFPAP <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private MFNNMCJOCHN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2DE48D0", Offset = "0x2DE32D0", VA = "0x182DE48D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ADJCILBNFAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KKFCNNLFPAP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private CancellationTokenSource <roomTokenSource>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private CancellationToken <roomCancellationToken>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Task <roomLoadTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2E10", Offset = "0x2DE1810", VA = "0x182DE2E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct GKKGNIBICHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DF57D0", Offset = "0x2DF41D0", VA = "0x182DF57D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DGEJGMANOCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public KKFCNNLFPAP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter<HIMGLJILILM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFF40", Offset = "0x2DEE940", VA = "0x182DEFF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class LGFAMCDCDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LGFAMCDCDMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class APCADMIMNEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public LGFAMCDCDMD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public APCADMIMNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5550", Offset = "0x2DE3F50", VA = "0x182DE5550")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DDIMHGHIHGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private APCADMIMNEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DECC40", Offset = "0x2DEB640", VA = "0x182DECC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct FINCOLDMGEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KKFCNNLFPAP joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EIEGHKKPADG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DF33A0", Offset = "0x2DF1DA0", VA = "0x182DF33A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct ABEANIEFHPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1F60", Offset = "0x2DE0960", VA = "0x182DE1F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NAEIHACIJGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9A10", Offset = "0x2DF8410", VA = "0x182DF9A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct GLNPLOPNLKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5BB0", Offset = "0x2DF45B0", VA = "0x182DF5BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct PJIAPIKCFPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TaskAwaiter<DHCFGHIPPFB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA780", Offset = "0x2DF9180", VA = "0x182DFA780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class GMOAJKJKPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public PPDODAGAAED disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GMOAJKJKPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5E20", Offset = "0x2DF4820", VA = "0x182DF5E20")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct JIHBNPDDHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public PPDODAGAAED disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DF86C0", Offset = "0x2DF70C0", VA = "0x182DF86C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct MJBCAOILOGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public DEJJAOPEKEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9760", Offset = "0x2DF8160", VA = "0x182DF9760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JNFMAGMJAHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JNFMAGMJAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9020", Offset = "0x2DF7A20", VA = "0x182DF9020")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class OFHOPFPEPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public OFHOPFPEPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA650", Offset = "0x2DF9050", VA = "0x182DFA650")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OCGOIDOGOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public OCGOIDOGOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA160", Offset = "0x2DF8B60", VA = "0x182DFA160")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class IIDHABHFMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IIDHABHFMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7400", Offset = "0x2DF5E00", VA = "0x182DF7400")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly Guid FPGBAPHNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private MNECIJJBOAL DCKFOICAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private EAKLELMEGDF OEBBMCFFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private OMKGECBJNEK LDHDCOPHAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private HLBFLCJFNGM HONEOMEIAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HOOKBPHHIKC IGCMBEMFIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private NIABJPKJCMD ILOKCLLCFMA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public TaskStatus JNGIMNOJDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F80", Offset = "0x6AF980", VA = "0x1806B0F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6B1130", Offset = "0x6AFB30", VA = "0x1806B1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2DED5E0", Offset = "0x2DEBFE0", VA = "0x182DED5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2DEF140", Offset = "0x2DEDB40", VA = "0x182DEF140", Slot = "6")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2DEF8B0", Offset = "0x2DEE2B0", VA = "0x182DEF8B0", Slot = "5")]
	[AsyncStateMachine(typeof(IFCBBHBIFIM))]
	public Task NEMJOOANPBK(EIEGHKKPADG JKIPODEFHOD, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDDB0", Offset = "0x2DEC7B0", VA = "0x182DEDDB0")]
	[AsyncStateMachine(typeof(AJDKKDOIKJA))]
	private Task EMAHCAHKKPH(EIEGHKKPADG JKIPODEFHOD, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2DEF9E0", Offset = "0x2DEE3E0", VA = "0x182DEF9E0")]
	[AsyncStateMachine(typeof(ADJCILBNFAG))]
	private Task NPJLPMNGLBE(BDMELKPFPFB IHHDBHELEOM, EIEGHKKPADG JKIPODEFHOD, KKFCNNLFPAP GINCDMPHFHE, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2DEFB40", Offset = "0x2DEE540", VA = "0x182DEFB40")]
	private void OACGELPIGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEF780", Offset = "0x2DEE180", VA = "0x182DEF780")]
	[AsyncStateMachine(typeof(GKKGNIBICHA))]
	private Task MKEPHLLBLOC(BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2DED630", Offset = "0x2DEC030", VA = "0x182DED630")]
	private void APNBKGHABGK(EIEGHKKPADG JKIPODEFHOD, CancellationToken ADDHBCOAOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEF4B0", Offset = "0x2DEDEB0", VA = "0x182DEF4B0")]
	private void MGLDOOMHMIP(EIEGHKKPADG JKIPODEFHOD, KKFCNNLFPAP GINCDMPHFHE, OperationCanceledException OKJBNEOKMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEE70", Offset = "0x2DED870", VA = "0x182DEEE70")]
	private void LGAGFCLFEJL(EIEGHKKPADG JKIPODEFHOD, KKFCNNLFPAP GINCDMPHFHE, Exception KILOBDNKPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE5F0", Offset = "0x2DECFF0", VA = "0x182DEE5F0")]
	private void IJCPGALNNAF(EIEGHKKPADG JKIPODEFHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE370", Offset = "0x2DECD70", VA = "0x182DEE370")]
	private static FDMOMPKDGBE HECOJLKGELK(EIEGHKKPADG JKIPODEFHOD)
	{
		return default(FDMOMPKDGBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DED8E0", Offset = "0x2DEC2E0", VA = "0x182DED8E0")]
	private void BBLFEABOLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DED530", Offset = "0x2DEBF30", VA = "0x182DED530")]
	private static HIMGLJILILM ALHDICNOAJD(EIEGHKKPADG JKIPODEFHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE490", Offset = "0x2DECE90", VA = "0x182DEE490")]
	[AsyncStateMachine(typeof(DGEJGMANOCI))]
	private Task ICIHGHMKAHF(EIEGHKKPADG JKIPODEFHOD, KKFCNNLFPAP GINCDMPHFHE, BDMELKPFPFB IHHDBHELEOM, CancellationToken GMDEBNGLPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEA50", Offset = "0x2DED450", VA = "0x182DEEA50")]
	[AsyncStateMachine(typeof(DDIMHGHIHGE))]
	private Task JOFJOMJFKAN(EIEGHKKPADG JKIPODEFHOD, CancellationTokenSource AIOIANELFKF, Task NICIBKGEMJE, CancellationToken GMDEBNGLPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE0D0", Offset = "0x2DECAD0", VA = "0x182DEE0D0")]
	[AsyncStateMachine(typeof(FINCOLDMGEI))]
	private Task FFMEMOHDBOA(EIEGHKKPADG ABLLHGDJONP, KKFCNNLFPAP FKNOMKDKLCK, BDMELKPFPFB IHHDBHELEOM, CancellationToken LLALFNPBGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE850", Offset = "0x2DED250", VA = "0x182DEE850")]
	private KKFCNNLFPAP JCKEEBENOGP(KKFCNNLFPAP FKNOMKDKLCK, ref CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE230", Offset = "0x2DECC30", VA = "0x182DEE230")]
	[AsyncStateMachine(typeof(ABEANIEFHPO))]
	private Task FKDFHGHADIE(BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DEED40", Offset = "0x2DED740", VA = "0x182DEED40")]
	[AsyncStateMachine(typeof(NAEIHACIJGH))]
	private Task LDFKCAHOKEE(BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDEE0", Offset = "0x2DEC8E0", VA = "0x182DEDEE0")]
	[AsyncStateMachine(typeof(GLNPLOPNLKB))]
	private Task FCJPACHAFJF(BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DED400", Offset = "0x2DEBE00", VA = "0x182DED400")]
	[AsyncStateMachine(typeof(PJIAPIKCFPO))]
	private Task ALCLHIOCOCE(HDNBAJBNCBH CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDB80", Offset = "0x2DEC580", VA = "0x182DEDB80")]
	[AsyncStateMachine(typeof(JIHBNPDDHHD))]
	private Task CFMOOMDNGNC(PPDODAGAAED FNCPBMAEOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DEFC60", Offset = "0x2DEE660", VA = "0x182DEFC60")]
	[AsyncStateMachine(typeof(MJBCAOILOGB))]
	private Task OJHLBKPCIAE(BDMELKPFPFB BCIAJNNCADP, CancellationToken GMDEBNGLPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDC90", Offset = "0x2DEC690", VA = "0x182DEDC90")]
	private static void DFOMOJNILFB(EIEGHKKPADG JKIPODEFHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDA40", Offset = "0x2DEC440", VA = "0x182DEDA40")]
	private static void BNEPAJMGGBA(EIEGHKKPADG JKIPODEFHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE020", Offset = "0x2DECA20", VA = "0x182DEE020")]
	private static void FDAJOMOJBEB(EIEGHKKPADG JKIPODEFHOD, CancellationToken GMDEBNGLPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEBB0", Offset = "0x2DED5B0", VA = "0x182DEEBB0")]
	private static void JPLHKBADCAB(EIEGHKKPADG JKIPODEFHOD, Exception KILOBDNKPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DEFDA0", Offset = "0x2DEE7A0", VA = "0x182DEFDA0")]
	private void OPKPALNLAME(EIEGHKKPADG JKIPODEFHOD, Task NICIBKGEMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE3D0", Offset = "0x2DECDD0", VA = "0x182DEE3D0")]
	private static void HPBOCPHBLIF(Func<string> CDCAEKJLACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2DEFF30", Offset = "0x2DEE930", VA = "0x182DEFF30")]
	public DEJJAOPEKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[Preserve]
internal sealed class CABNFNBBABP : BPPDNANDNDB, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BDGDMOFACLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BDGDMOFACLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DE61B0", Offset = "0x2DE4BB0", VA = "0x182DE61B0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FGOMMPOKECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FGOMMPOKECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3350", Offset = "0x2DF1D50", VA = "0x182DF3350")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BJDCIHIFMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BJDCIHIFMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6390", Offset = "0x2DE4D90", VA = "0x182DE6390")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JLKEGHPBOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JLKEGHPBOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8FD0", Offset = "0x2DF79D0", VA = "0x182DF8FD0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OFLHFINKKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public OFLHFINKKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA6E0", Offset = "0x2DF90E0", VA = "0x182DFA6E0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<Guid, GLOGEJFGABJ> IIEEFGOCHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly TimeSpan HNJJMGBFNOP;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "10")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7D90", Offset = "0x2DE6790", VA = "0x182DE7D90", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7620", Offset = "0x2DE6020", VA = "0x182DE7620", Slot = "4")]
	public FPMDPHKGJII CEGAKGBDODP(Guid BJDJCGIBLIK)
	{
		return default(FPMDPHKGJII);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7AD0", Offset = "0x2DE64D0", VA = "0x182DE7AD0", Slot = "5")]
	public bool DFDJPGANONL(Guid BJDJCGIBLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7DA0", Offset = "0x2DE67A0", VA = "0x182DE7DA0", Slot = "8")]
	public bool KLAMBKCHHCD(Guid BJDJCGIBLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2DE72C0", Offset = "0x2DE5CC0", VA = "0x182DE72C0", Slot = "6")]
	public bool BFACJPEHBKE(Guid BJDJCGIBLIK, Task ANPGFIHKBFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DE78B0", Offset = "0x2DE62B0", VA = "0x182DE78B0", Slot = "7")]
	public bool DAFABMKBGDH(Guid BJDJCGIBLIK, DHCFGHIPPFB ADGIOGKBNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7D10", Offset = "0x2DE6710", VA = "0x182DE7D10", Slot = "9")]
	public Task<(DHCFGHIPPFB, Task)> DNNGOONDEEP(Guid BJDJCGIBLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7FB0", Offset = "0x2DE69B0", VA = "0x182DE7FB0")]
	private void KOPIAOIIIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE81F0", Offset = "0x2DE6BF0", VA = "0x182DE81F0")]
	public CABNFNBBABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Preserve]
internal class HJHPIIPFLFG : IBEPLKOCALD, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class JOGNFIMHHJK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly EIEGHKKPADG OIDHBEAPDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly CancellationTokenSource LNHBGENCLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public readonly CancellationToken AJKCGNJJGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool MBLLACEHLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool NPBJPMMAPDK;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BB57A0", Offset = "0x2BB41A0", VA = "0x182BB57A0")]
		public JOGNFIMHHJK(EIEGHKKPADG OIDHBEAPDPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5670", Offset = "0x2BB4070", VA = "0x182BB5670")]
		public void KLAMBKCHHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5640", Offset = "0x2BB4040", VA = "0x182BB5640", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class IDJHKIGINIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IDJHKIGINIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2680", Offset = "0x2BB1080", VA = "0x182BB2680")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MJNCFMMFMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public EIEGHKKPADG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public MJNCFMMFMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAF20", Offset = "0x2BB9920", VA = "0x182BBAF20")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class AENHOCBLBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public AENHOCBLBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6480", Offset = "0x2BA4E80", VA = "0x182BA6480")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct LBELNEOAJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EIEGHKKPADG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public HJHPIIPFLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private MJNCFMMFMJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9D80", Offset = "0x2BB8780", VA = "0x182BB9D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private EAKLELMEGDF OEBBMCFFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private OMKGECBJNEK LDHDCOPHAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private JDEPENEFOAM ELOADBKILOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long APANMOBDANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private JOGNFIMHHJK AHPBFMEFJCN;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF550", Offset = "0x2BADF50", VA = "0x182BAF550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFDB0", Offset = "0x2BAE7B0", VA = "0x182BAFDB0", Slot = "5")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF7F0", Offset = "0x2BAE1F0", VA = "0x182BAF7F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF4D0", Offset = "0x2BADED0", VA = "0x182BAF4D0", Slot = "4")]
	public void AENGCFPNOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0790", Offset = "0x2BAF190", VA = "0x182BB0790")]
	private void MPPDCEIFADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFBD0", Offset = "0x2BAE5D0", VA = "0x182BAFBD0")]
	private void FNAGNAJBLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF5A0", Offset = "0x2BADFA0", VA = "0x182BAF5A0")]
	private void BFKIEOODILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF770", Offset = "0x2BAE170", VA = "0x182BAF770")]
	private bool CKDAACJKLHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFF20", Offset = "0x2BAE920", VA = "0x182BAFF20")]
	private void MALCBNGHKFC(int PCBNLNEHADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFA50", Offset = "0x2BAE450", VA = "0x182BAFA50")]
	private bool ENCGFENBHLF(EIEGHKKPADG OIDHBEAPDPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF940", Offset = "0x2BAE340", VA = "0x182BAF940")]
	[AsyncStateMachine(typeof(LBELNEOAJHH))]
	private Task EMAHCAHKKPH(EIEGHKKPADG OIDHBEAPDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0990", Offset = "0x2BAF390", VA = "0x182BB0990")]
	public HJHPIIPFLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class KNHNIFCGMON : GJJOAPPDBKN, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct KAOFBPDBALI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AsyncTaskMethodBuilder<MIPGNLMFNJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public KNHNIFCGMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<MIPGNLMFNJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2EB53A0", Offset = "0x2EB3DA0", VA = "0x182EB53A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5570", Offset = "0x2EB3F70", VA = "0x182EB5570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FEJBHFCBEOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public IBNMHBIHLHI message;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FEJBHFCBEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2EB0900", Offset = "0x2EAF300", VA = "0x182EB0900")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OGBIMJCEBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IBNMHBIHLHI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public OGBIMJCEBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3470", Offset = "0x2EC1E70", VA = "0x182EC3470")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KDJOMAOHDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KDJOMAOHDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5A20", Offset = "0x2EB4420", VA = "0x182EB5A20")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HNOOEDCGMNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public KNHNIFCGMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<KHCJOIGIKIA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB2F90", Offset = "0x2EB1990", VA = "0x182EB2F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class ACICEHAOPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public IBNMHBIHLHI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ACICEHAOPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2EAEF20", Offset = "0x2EAD920", VA = "0x182EAEF20")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct OHKCIJPHDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public IBNMHBIHLHI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public KNHNIFCGMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private KKFCNNLFPAP <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2EC34C0", Offset = "0x2EC1EC0", VA = "0x182EC34C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct MHGNGENCPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<KHCJOIGIKIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public KNHNIFCGMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private KKFCNNLFPAP <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD950", Offset = "0x2EBC350", VA = "0x182EBD950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDD20", Offset = "0x2EBC720", VA = "0x182EBDD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class IAJLPAFKAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public KHCJOIGIKIA operation;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IAJLPAFKAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2EB36D0", Offset = "0x2EB20D0", VA = "0x182EB36D0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct GPJCGFJCADD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public KHCJOIGIKIA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public KNHNIFCGMON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private BDMELKPFPFB <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2EB26B0", Offset = "0x2EB10B0", VA = "0x182EB26B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class IOBMPDBLOPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IOBMPDBLOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB42B0", Offset = "0x2EB2CB0", VA = "0x182EB42B0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class HPJDBBHNGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HPJDBBHNGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB3680", Offset = "0x2EB2080", VA = "0x182EB3680")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private HOOKBPHHIKC IGCMBEMFIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private FIHHLCBDMCC IIMNHODPMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private HLBFLCJFNGM HONEOMEIAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private TaskCompletionSource<MIPGNLMFNJL> OAJBMEEBAAN;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7950", Offset = "0x2EB6350", VA = "0x182EB7950", Slot = "7")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7A30", Offset = "0x2EB6430", VA = "0x182EB7A30", Slot = "6")]
	[AsyncStateMachine(typeof(KAOFBPDBALI))]
	public Task<MIPGNLMFNJL> OMDBMKJJNDC(CancellationToken PNEFOCIGKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6EC0", Offset = "0x2EB58C0", VA = "0x182EB6EC0", Slot = "4")]
	public void ECKOOHMJIHG(IBNMHBIHLHI OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7B50", Offset = "0x2EB6550", VA = "0x182EB7B50", Slot = "5")]
	public void PIOBOBADHBG(IBNMHBIHLHI GCLJEOCKFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6C80", Offset = "0x2EB5680", VA = "0x182EB6C80")]
	[AsyncStateMachine(typeof(HNOOEDCGMNE))]
	private Task CJAJDNMJCPE(IBNMHBIHLHI LKGBFLLCPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6A30", Offset = "0x2EB5430", VA = "0x182EB6A30")]
	[AsyncStateMachine(typeof(OHKCIJPHDMF))]
	private Task BNINPIHMGED(IBNMHBIHLHI AAHLKFOLDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6B40", Offset = "0x2EB5540", VA = "0x182EB6B40")]
	[AsyncStateMachine(typeof(MHGNGENCPPN))]
	private Task<KHCJOIGIKIA> CCOEBGNHLAK(IBNMHBIHLHI LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7630", Offset = "0x2EB6030", VA = "0x182EB7630")]
	private KKFCNNLFPAP HIFBMPGHALC(IBNMHBIHLHI LCIIFCAADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6D90", Offset = "0x2EB5790", VA = "0x182EB6D90")]
	[AsyncStateMachine(typeof(GPJCGFJCADD))]
	private Task DFIFGGCPFLO(KHCJOIGIKIA BIENEBJDHDJ, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2EB76B0", Offset = "0x2EB60B0", VA = "0x182EB76B0")]
	private KHCJOIGIKIA HLKMAHHBCKA(IBNMHBIHLHI LKGBFLLCPJC, KKFCNNLFPAP EELJAPPDPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x293E9F0", Offset = "0x293D3F0", VA = "0x18293E9F0")]
	private T GMAIGJFDDEF<T>(T HPIAFNBPEPC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7250", Offset = "0x2EB5C50", VA = "0x182EB7250")]
	private KHCJOIGIKIA EIICFKKFHAA(IBNMHBIHLHI LKGBFLLCPJC, KKFCNNLFPAP EELJAPPDPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public KNHNIFCGMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7900", Offset = "0x2EB6300", VA = "0x182EB7900")]
	[CompilerGenerated]
	private void LANGCLMOEKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Preserve]
internal sealed class MCCCLHFEABE : FIHHLCBDMCC, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class MIHEFAGOGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public MIHEFAGOGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDD70", Offset = "0x2EBC770", VA = "0x182EBDD70")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class EIEADOOAOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public EIEADOOAOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2EB0410", Offset = "0x2EAEE10", VA = "0x182EB0410")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private ALHFDBOHJIN IMGAGGGPKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private GJJOAPPDBKN PLNPIBEBPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private BPPDNANDNDB IIEEFGOCHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private OIHJGGELKGL PNHJEKLCNNF;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD0A0", Offset = "0x2EBBAA0", VA = "0x182EBD0A0", Slot = "6")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC0E0", Offset = "0x2EBAAE0", VA = "0x182EBC0E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2EBBBD0", Offset = "0x2EBA5D0", VA = "0x182EBBBD0", Slot = "4")]
	public FPMDPHKGJII DGEIJMLCKCK(LEGMEMBDHLK LKGBFLLCPJC)
	{
		return default(FPMDPHKGJII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD4D0", Offset = "0x2EBBED0", VA = "0x182EBD4D0", Slot = "5")]
	public void PNDCBHBIAJB(Guid BJDJCGIBLIK, Task ANPGFIHKBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD1E0", Offset = "0x2EBBBE0", VA = "0x182EBD1E0")]
	private void MOLIDBOJFHK(byte IKCPPMJMAML, int GIECOBENCKK, object DIHNIJDPILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC170", Offset = "0x2EBAB70", VA = "0x182EBC170")]
	private void EJDGLGPAHJG(JJAJPPLOCBB FEHBGLJINON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCB40", Offset = "0x2EBB540", VA = "0x182EBCB40")]
	private void IGKFNLHKIFP(JJAJPPLOCBB FEHBGLJINON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB6D0", Offset = "0x2EBA0D0", VA = "0x182EBB6D0")]
	private void DAGCCIGPECH(JJAJPPLOCBB FEHBGLJINON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC5F0", Offset = "0x2EBAFF0", VA = "0x182EBC5F0")]
	private DHCFGHIPPFB HPIEIAJNDOE(IBNMHBIHLHI LCIIFCAADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC910", Offset = "0x2EBB310", VA = "0x182EBC910")]
	private void IDANDHJMBEP(IBNMHBIHLHI AAHLKFOLDEE, DHCFGHIPPFB ADGIOGKBNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD2B0", Offset = "0x2EBBCB0", VA = "0x182EBD2B0")]
	private bool PEKAIIEELEC(IBNMHBIHLHI AAHLKFOLDEE, DHCFGHIPPFB ADGIOGKBNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB930", Offset = "0x2EBA330", VA = "0x182EBB930")]
	private bool DGEIJMLCKCK(IBNMHBIHLHI CEPMKAOMJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCDD0", Offset = "0x2EBB7D0", VA = "0x182EBCDD0")]
	private bool KCJGNDJCGFH(byte IKCPPMJMAML, ExitGames.Client.Photon.Hashtable FEHBGLJINON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public MCCCLHFEABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[Preserve]
internal sealed class DOANEFEJLFG : GBKNPMBJKLA, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DLJNEMHJHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public MIPGNLMFNJL operationType;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DLJNEMHJHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0C30", Offset = "0x2DEF630", VA = "0x182DF0C30")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct JJPHHPGEFFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public AsyncTaskMethodBuilder<DHCFGHIPPFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public MIPGNLMFNJL operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public DOANEFEJLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AOLOIKMEGKC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter<DHCFGHIPPFB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2DF89D0", Offset = "0x2DF73D0", VA = "0x182DF89D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8F80", Offset = "0x2DF7980", VA = "0x182DF8F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class EINKDJFDDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public MIPGNLMFNJL operationType;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public EINKDJFDDCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1BF0", Offset = "0x2DF05F0", VA = "0x182DF1BF0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class NIPAGMPCKEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public MIPGNLMFNJL operationType;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NIPAGMPCKEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9FF0", Offset = "0x2DF89F0", VA = "0x182DF9FF0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA050", Offset = "0x2DF8A50", VA = "0x182DFA050")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA0B0", Offset = "0x2DF8AB0", VA = "0x182DFA0B0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct POIGLLBOAPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder<DHCFGHIPPFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MIPGNLMFNJL operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public DOANEFEJLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AOLOIKMEGKC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private NIPAGMPCKEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private FPMDPHKGJII <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private DHCFGHIPPFB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<(DHCFGHIPPFB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB150", Offset = "0x2DF9B50", VA = "0x182DFB150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB770", Offset = "0x2DFA170", VA = "0x182DFB770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class BDDOLNNLGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public MIPGNLMFNJL operationType;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BDDOLNNLGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6150", Offset = "0x2DE4B50", VA = "0x182DE6150")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NGOICDDIJMO IABNOHPMMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private ALHFDBOHJIN IMGAGGGPKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private FIHHLCBDMCC IIMNHODPMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1290", Offset = "0x2DEFC90", VA = "0x182DF1290", Slot = "5")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF14C0", Offset = "0x2DEFEC0", VA = "0x182DF14C0", Slot = "4")]
	[AsyncStateMachine(typeof(JJPHHPGEFFI))]
	public Task<DHCFGHIPPFB> NCPJJBOMGAJ(AOLOIKMEGKC LIIIKAIOJCL, MIPGNLMFNJL FMMHCELCDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0FF0", Offset = "0x2DEF9F0", VA = "0x182DF0FF0")]
	private bool HMJIOIBELBB(MIPGNLMFNJL FMMHCELCDCN, out DHCFGHIPPFB HEMKPPOPDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1390", Offset = "0x2DEFD90", VA = "0x182DF1390")]
	[AsyncStateMachine(typeof(POIGLLBOAPK))]
	private Task<DHCFGHIPPFB> MJIJGBMDKIE(AOLOIKMEGKC LIIIKAIOJCL, MIPGNLMFNJL FMMHCELCDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0C90", Offset = "0x2DEF690", VA = "0x182DF0C90")]
	internal LEGMEMBDHLK GNEELDHNHPD(AOLOIKMEGKC LIIIKAIOJCL, MIPGNLMFNJL FMMHCELCDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public DOANEFEJLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Preserve]
internal sealed class HFAHFBHFPGK : NGOICDDIJMO, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct MAEEPEIGPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder<JKPNDOLIOLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public HFAHFBHFPGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter<CKEPHPBIHBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAA80", Offset = "0x2BB9480", VA = "0x182BBAA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAED0", Offset = "0x2BB98D0", VA = "0x182BBAED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct HBCIGBMMIMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder<CKEPHPBIHBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public HFAHFBHFPGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter<CKEPHPBIHBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2BACAB0", Offset = "0x2BAB4B0", VA = "0x182BACAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2BACE80", Offset = "0x2BAB880", VA = "0x182BACE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class FDAGIJPHBJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FDAGIJPHBJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1A01E20", Offset = "0x1A00820", VA = "0x181A01E20")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(ALDJHDJCCBC sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class NIKNNAGHIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NIKNNAGHIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB100", Offset = "0x2BB9B00", VA = "0x182BBB100")]
		internal object <GetRoomDetails>b__0(in long rid)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct CGKOBFJAAMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder<CKEPHPBIHBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public EIEGHKKPADG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public HFAHFBHFPGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public bool forceCacheRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter<CKEPHPBIHBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7950", Offset = "0x2BA6350", VA = "0x182BA7950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7C80", Offset = "0x2BA6680", VA = "0x182BA7C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly (FOIOFCKPMAJ superRoomData, FOIOFCKPMAJ subRoomData) HNPPFICIHPE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD870", Offset = "0x2BAC270", VA = "0x182BAD870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE060", Offset = "0x2BACA60", VA = "0x182BAE060", Slot = "6")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD8C0", Offset = "0x2BAC2C0", VA = "0x182BAD8C0", Slot = "4")]
	[AsyncStateMachine(typeof(MAEEPEIGPLJ))]
	public Task<JKPNDOLIOLF> AOFECJFNCOB(FLDAJIIDCOG FENCPFKHOGO, EIEGHKKPADG JKIPODEFHOD, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2BADA20", Offset = "0x2BAC420", VA = "0x182BADA20")]
	[AsyncStateMachine(typeof(HBCIGBMMIMK))]
	public Task<CKEPHPBIHBC> JNCIPIMKLFG(FLDAJIIDCOG FENCPFKHOGO, EIEGHKKPADG JKIPODEFHOD, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD6A0", Offset = "0x2BAC0A0", VA = "0x182BAD6A0", Slot = "5")]
	public JKPNDOLIOLF AFOAKOIPNIL(CKEPHPBIHBC IIBONGAMCMF, long BMNHGDIENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE0D0", Offset = "0x2BACAD0", VA = "0x182BAE0D0")]
	private static JKPNDOLIOLF LPPHHGMBAKN(CKEPHPBIHBC IIBONGAMCMF, long BMNHGDIENAL, FOIOFCKPMAJ GEBMDOIGHFJ, FOIOFCKPMAJ HEOCEKKLPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2BADCD0", Offset = "0x2BAC6D0", VA = "0x182BADCD0")]
	private (FOIOFCKPMAJ, FOIOFCKPMAJ) KBKBNPPGAHB(CKEPHPBIHBC IIBONGAMCMF, long BMNHGDIENAL)
	{
		return default((FOIOFCKPMAJ, FOIOFCKPMAJ));
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE250", Offset = "0x2BACC50", VA = "0x182BAE250")]
	private IDisposable MGGBCMBMJJF(FLDAJIIDCOG FENCPFKHOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2BADB80", Offset = "0x2BAC580", VA = "0x182BADB80")]
	[AsyncStateMachine(typeof(CGKOBFJAAMK))]
	private Task<CKEPHPBIHBC> JNCIPIMKLFG(EIEGHKKPADG JKIPODEFHOD, bool HCJPPIFFDPC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public HFAHFBHFPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal sealed class HKGFPKABIKK : HLBFLCJFNGM, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class KLBIECEPMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KLBIECEPMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9D30", Offset = "0x2BB8730", VA = "0x182BB9D30")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct CPPMEPNDFBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public HKGFPKABIKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public KKFCNNLFPAP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E50", Offset = "0x2BA6850", VA = "0x182BA7E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8310", Offset = "0x2BA6D10", VA = "0x182BA8310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct FLCMMPKFELG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public HKGFPKABIKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public KKFCNNLFPAP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter<FFFCPGMKGFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB520", Offset = "0x2BA9F20", VA = "0x182BAB520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA30", Offset = "0x2BAA430", VA = "0x182BABA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class CPBDOOPCOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public CPBDOOPCOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E00", Offset = "0x2BA6800", VA = "0x182BA7E00")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct APJFOHICIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public IBNMHBIHLHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public HKGFPKABIKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public KKFCNNLFPAP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private HBDFKEIEKDK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private LCPNDJJAJIP.CBKOFGOOJHE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter<FFFCPGMKGFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6AA0", Offset = "0x2BA54A0", VA = "0x182BA6AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7360", Offset = "0x2BA5D60", VA = "0x182BA7360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private LCPNDJJAJIP LOFBICGMDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2BB10C0", Offset = "0x2BAFAC0", VA = "0x182BB10C0", Slot = "10")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0C60", Offset = "0x2BAF660", VA = "0x182BB0C60", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0C60", Offset = "0x2BAF660", VA = "0x182BB0C60", Slot = "5")]
	public void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0A60", Offset = "0x2BAF460", VA = "0x182BB0A60", Slot = "4")]
	public void AEEGCHIFHAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0E20", Offset = "0x2BAF820", VA = "0x182BB0E20", Slot = "6")]
	[AsyncStateMachine(typeof(CPPMEPNDFBJ))]
	public Task<IBNMHBIHLHI> GPKNMGLBHCO(IBNMHBIHLHI LKGBFLLCPJC, KKFCNNLFPAP EELJAPPDPDP, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0B10", Offset = "0x2BAF510", VA = "0x182BB0B10", Slot = "7")]
	[AsyncStateMachine(typeof(FLCMMPKFELG))]
	public Task<IBNMHBIHLHI> BJNLLLEFHDK(CancellationToken PKFOPLIPJOL, KKFCNNLFPAP EELJAPPDPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0D80", Offset = "0x2BAF780", VA = "0x182BB0D80", Slot = "8")]
	public FLDAJIIDCOG GLBNPABFJMC(KHCJOIGIKIA HAGONGAFGEL, BDMELKPFPFB BCIAJNNCADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0C90", Offset = "0x2BAF690", VA = "0x182BB0C90", Slot = "9")]
	public FLDAJIIDCOG EBMHDBDGPPA(KHCJOIGIKIA HAGONGAFGEL, BDMELKPFPFB BCIAJNNCADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0F70", Offset = "0x2BAF970", VA = "0x182BB0F70")]
	[AsyncStateMachine(typeof(APJFOHICIFN))]
	private Task<IBNMHBIHLHI> IAHBKCKENGE(IBNMHBIHLHI LKGBFLLCPJC, KKFCNNLFPAP EELJAPPDPDP, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0C50", Offset = "0x2BAF650", VA = "0x182BB0C50")]
	private static byte[] CJDFGAKGJGE(IBNMHBIHLHI OLLHPIFFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1130", Offset = "0x2BAFB30", VA = "0x182BB1130")]
	private static string PJGEFPMIBFL(byte[] MANGGNPAMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public HKGFPKABIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Preserve]
internal sealed class JMIAKEIBPIH : ALHFDBOHJIN, DPKOEPIJBOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private BAIGNLCNAMC DMBNABBACFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private HOOKBPHHIKC IGCMBEMFIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private LKPEOKGLEIP GGJDNGKJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private JDEPENEFOAM ELOADBKILOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private JFAAGEHHCFD GJMNFBGPOLA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4F30", Offset = "0x2BB3930", VA = "0x182BB4F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private static DHCFGHIPPFB NOJCCHCPKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4990", Offset = "0x2BB3390", VA = "0x182BB4990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5490", Offset = "0x2BB3E90", VA = "0x182BB5490", Slot = "7")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5160", Offset = "0x2BB3B60", VA = "0x182BB5160", Slot = "4")]
	public DHCFGHIPPFB JFJKBNCCKDG(AOLOIKMEGKC ODBLFFPEOCH, MIPGNLMFNJL ILPIAGJEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2BB52B0", Offset = "0x2BB3CB0", VA = "0x182BB52B0", Slot = "5")]
	public DHCFGHIPPFB JOOLELFOOPG(AOLOIKMEGKC KKEEDEKJPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4F80", Offset = "0x2BB3980", VA = "0x182BB4F80", Slot = "6")]
	public DHCFGHIPPFB GHMGCGGADFI(AOLOIKMEGKC KKEEDEKJPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2BB49F0", Offset = "0x2BB33F0", VA = "0x182BB49F0")]
	private static DHCFGHIPPFB BFNFGPAALIJ(CLFFODICHGN DJKMPMKHOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public JMIAKEIBPIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class MMDBMBPPADN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2EBDE80", Offset = "0x2EBC880", VA = "0x182EBDE80")]
	public MMDBMBPPADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xC57FD0", Offset = "0xC569D0", VA = "0x180C57FD0")]
	public MMDBMBPPADN(string OLLHPIFFHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class HFIKGBKOAFL : CEPOOFBIBMM, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct POHKCHNAGNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public HFIKGBKOAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public NJHEDNCKIJM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private BDMELKPFPFB <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter<DHCFGHIPPFB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBDD0", Offset = "0x2BBA7D0", VA = "0x182BBBDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct FMFODDBAPOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public HFIKGBKOAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA80", Offset = "0x2BAA480", VA = "0x182BABA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct POKKCKIDMFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public HFIKGBKOAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC430", Offset = "0x2BBAE30", VA = "0x182BBC430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct CAMKFLAEKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public HFIKGBKOAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA73B0", Offset = "0x2BA5DB0", VA = "0x182BA73B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct FDFMFHCPIPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public HFIKGBKOAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB040", Offset = "0x2BA9A40", VA = "0x182BAB040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct LBKGFIEBPLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public HFIKGBKOAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public NJHEDNCKIJM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private BDMELKPFPFB <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA6F0", Offset = "0x2BB90F0", VA = "0x182BBA6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly TimeSpan MDGMPNOEPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private KEFEPKNHJHI PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private HLBFLCJFNGM HONEOMEIAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private HOOKBPHHIKC IGCMBEMFIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private JFAAGEHHCFD GJMNFBGPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private CancellationTokenSource NPBJFEFFAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private Task CJDMDOAJMAM;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEBD0", Offset = "0x2BAD5D0", VA = "0x182BAEBD0", Slot = "6")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1C12870", Offset = "0x1C11270", VA = "0x181C12870", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE990", Offset = "0x2BAD390", VA = "0x182BAE990", Slot = "4")]
	[AsyncStateMachine(typeof(POHKCHNAGNN))]
	public Task JDGNNAPEBEJ(NJHEDNCKIJM APIOJDDPFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE760", Offset = "0x2BAD160", VA = "0x182BAE760", Slot = "5")]
	[AsyncStateMachine(typeof(FMFODDBAPOP))]
	public Task HGCPMOIJMFK([Optional] CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1C12870", Offset = "0x1C11270", VA = "0x181C12870")]
	public void NBDNOCEDKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEDD0", Offset = "0x2BAD7D0", VA = "0x182BAEDD0")]
	private CONMGAOEIKI ONFKCOOGDOC(NJHEDNCKIJM APIOJDDPFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEFA0", Offset = "0x2BAD9A0", VA = "0x182BAEFA0")]
	[AsyncStateMachine(typeof(POKKCKIDMFI))]
	private Task PHFHGEGNDCL(HDNBAJBNCBH HHCBHHNLICO, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE880", Offset = "0x2BAD280", VA = "0x182BAE880")]
	[AsyncStateMachine(typeof(CAMKFLAEKCH))]
	private Task HLDOMCFANHI([Optional] CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEAA0", Offset = "0x2BAD4A0", VA = "0x182BAEAA0")]
	[AsyncStateMachine(typeof(FDFMFHCPIPM))]
	private Task JJNIHHFCKJH(TimeSpan ALLKKCAHMNM, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE4B0", Offset = "0x2BACEB0", VA = "0x182BAE4B0")]
	private Task GFJCILEFBPJ(NJHEDNCKIJM APIOJDDPFOL, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE380", Offset = "0x2BACD80", VA = "0x182BAE380")]
	[AsyncStateMachine(typeof(LBKGFIEBPLF))]
	private Task CJOPDEIDIDN(NJHEDNCKIJM APIOJDDPFOL, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE6C0", Offset = "0x2BAD0C0", VA = "0x182BAE6C0")]
	private bool HCBCEBADJEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public HFIKGBKOAFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[Preserve]
internal class KPHOEGLNIEK : LKPEOKGLEIP, DPKOEPIJBOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct POIDANJLMEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public KPHOEGLNIEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private BDMELKPFPFB <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC53A0", Offset = "0x2EC3DA0", VA = "0x182EC53A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private BMJHIJGIHGM ECNEHOPLIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private ALHFDBOHJIN IMGAGGGPKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private HLBFLCJFNGM HONEOMEIAHJ;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7F00", Offset = "0x2EB6900", VA = "0x182EB7F00", Slot = "6")]
	public void LPDEJFLNIEO(GAMFAADDNHJ CEMCPIENNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7EC0", Offset = "0x2EB68C0", VA = "0x182EB7EC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8080", Offset = "0x2EB6A80", VA = "0x182EB8080", Slot = "5")]
	[AsyncStateMachine(typeof(POIDANJLMEE))]
	public Task MOHMALNHKDO(string JAFIMCJAMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7EE0", Offset = "0x2EB68E0", VA = "0x182EB7EE0", Slot = "4")]
	public DHCFGHIPPFB HCBCEBADJEP(AOLOIKMEGKC ODBLFFPEOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2EB81A0", Offset = "0x2EB6BA0", VA = "0x182EB81A0")]
	private NHDCIJFCCBI PKGHFJMHDPM(string JAFIMCJAMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public KPHOEGLNIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class BLLNKDIMMEH
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6890", Offset = "0x2DE5290", VA = "0x182DE6890")]
	public static void HNJAJNDGIGA(CJNCHJOFGJN EIBONOODANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE67F0", Offset = "0x2DE51F0", VA = "0x182DE67F0")]
	internal static void DODIJDIAJKM(CJNCHJOFGJN EIBONOODANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE69D0", Offset = "0x2DE53D0", VA = "0x182DE69D0")]
	internal static void MBIIAECMJFL(CJNCHJOFGJN EIBONOODANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6A70", Offset = "0x2DE5470", VA = "0x182DE6A70")]
	internal static void NPFFKDLOHBF(CJNCHJOFGJN EIBONOODANC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal class LIHPFCHJGHG : global::OACMAPKGOGI<IBNMHBIHLHI>
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class CLFNCBLGPEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public string op;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public IBNMHBIHLHI message;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public CLFNCBLGPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2EAFE90", Offset = "0x2EAE890", VA = "0x182EAFE90")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly LIHPFCHJGHG JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private const string MFOGBGAGKHG = "pl";

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA180", Offset = "0x2EB8B80", VA = "0x182EBA180")]
	public ExitGames.Client.Photon.Hashtable NGLMBPACFDH(IBNMHBIHLHI OLLHPIFFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA070", Offset = "0x2EB8A70", VA = "0x182EBA070", Slot = "5")]
	protected override void KNJJECHGHEG(IBNMHBIHLHI OLLHPIFFHKE, IDictionary<object, object> CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2EB9D40", Offset = "0x2EB8740", VA = "0x182EB9D40", Slot = "6")]
	public override IBNMHBIHLHI FIPMLAIPHOG(IDictionary<object, object> CIBAGEDPOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2EB9F20", Offset = "0x2EB8920", VA = "0x182EB9F20")]
	private static void HPBOCPHBLIF(string EPJAAGHACCD, IBNMHBIHLHI OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA280", Offset = "0x2EB8C80", VA = "0x182EBA280")]
	public LIHPFCHJGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class JILGNDMOBHP
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static DHCFGHIPPFB NOJCCHCPKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4990", Offset = "0x2BB3390", VA = "0x182BB4990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4A50", Offset = "0x2BB3450", VA = "0x182BB4A50")]
	public static bool BMKIGCOPDEC(this DHCFGHIPPFB ADGIOGKBNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB49F0", Offset = "0x2BB33F0", VA = "0x182BB49F0")]
	public static DHCFGHIPPFB BFNFGPAALIJ(CLFFODICHGN BBPHPCBFNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4A70", Offset = "0x2BB3470", VA = "0x182BB4A70")]
	public static DHCFGHIPPFB NFJFJNNCPCK(params DHCFGHIPPFB[] JGGONGGBMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4A70", Offset = "0x2BB3470", VA = "0x182BB4A70")]
	public static DHCFGHIPPFB NFJFJNNCPCK(IEnumerable<DHCFGHIPPFB> JGGONGGBMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4900", Offset = "0x2BB3300", VA = "0x182BB4900")]
	public static string AJDCIIPEFIA(this DHCFGHIPPFB HEMKPPOPDKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class EJLANMOBOLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public delegate DHCFGHIPPFB DPOMHIEBCGE([NotNull] AOLOIKMEGKC OGIAALPENNK);

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class DBHEPINEDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AOLOIKMEGKC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DBHEPINEDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBDA0", Offset = "0x2DEA7A0", VA = "0x182DEBDA0")]
		internal DHCFGHIPPFB <Validate>b__0(DPOMHIEBCGE v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	protected readonly HashSet<DPOMHIEBCGE> OIKCEHGOGPG;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1D00", Offset = "0x2DF0700", VA = "0x182DF1D00")]
	public void LKNLNNCPJMG(DPOMHIEBCGE HJKOJHICPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1CA0", Offset = "0x2DF06A0", VA = "0x182DF1CA0")]
	public void HMADMPICOGL(DPOMHIEBCGE HJKOJHICPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1C50", Offset = "0x2DF0650", VA = "0x182DF1C50", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1D60", Offset = "0x2DF0760", VA = "0x182DF1D60")]
	protected DHCFGHIPPFB OFEMLHBEALA(AOLOIKMEGKC KKEEDEKJPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5790", Offset = "0x2DE4190", VA = "0x182DE5790")]
	protected EJLANMOBOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class BAIGNLCNAMC : EJLANMOBOLL
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class PHOLMICMBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public DHCFGHIPPFB result;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public PHOLMICMBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA730", Offset = "0x2DF9130", VA = "0x182DFA730")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5790", Offset = "0x2DE4190", VA = "0x182DE5790")]
	[Preserve]
	public BAIGNLCNAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5640", Offset = "0x2DE4040", VA = "0x182DE5640")]
	public DHCFGHIPPFB LEFAGBPAMCL(AOLOIKMEGKC KKEEDEKJPEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class BMJHIJGIHGM : EJLANMOBOLL
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NPKJMAIEENO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public DHCFGHIPPFB result;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NPKJMAIEENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA110", Offset = "0x2DF8B10", VA = "0x182DFA110")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5790", Offset = "0x2DE4190", VA = "0x182DE5790")]
	[Preserve]
	public BMJHIJGIHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6D10", Offset = "0x2DE5710", VA = "0x182DE6D10")]
	public DHCFGHIPPFB HCBCEBADJEP(AOLOIKMEGKC LCGDILHCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum FGHAEGNIFPP
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class KMPANBKPEIK
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class KDHELNLEPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KDHELNLEPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2EB59A0", Offset = "0x2EB43A0", VA = "0x182EB59A0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public const string MJGKDEMBOFG = "START: ";

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public const string FBLPMHKHJOB = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6870", Offset = "0x2EB5270", VA = "0x182EB6870")]
	public static BDMELKPFPFB IBNIADIONDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6600", Offset = "0x2EB5000", VA = "0x182EB6600")]
	private static void AKAAJFIDDKI(string IPKOPOLJGIA, KMPLHNMKPLC IHHDBHELEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2EB66F0", Offset = "0x2EB50F0", VA = "0x182EB66F0")]
	private static void FBBNHPNENGM(string IPKOPOLJGIA, KMPLHNMKPLC IHHDBHELEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6900", Offset = "0x2EB5300", VA = "0x182EB6900")]
	public static void KIAMOKJMMKF(BDMELKPFPFB IHHDBHELEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2EB67D0", Offset = "0x2EB51D0", VA = "0x182EB67D0")]
	public static string FJPIDGGBGJF(IBNMHBIHLHI LCIIFCAADFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal static class ACAMMLMLELD
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2DE23A0", Offset = "0x2DE0DA0", VA = "0x182DE23A0")]
	public static void ALFGDEJNAEN(this KEFEPKNHJHI PLCGLJPJKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE23B0", Offset = "0x2DE0DB0", VA = "0x182DE23B0")]
	public static void BJBEPOFMPBL(this KEFEPKNHJHI PLCGLJPJKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE23C0", Offset = "0x2DE0DC0", VA = "0x182DE23C0")]
	private static void HHPNFPHMGIE(this KEFEPKNHJHI PLCGLJPJKBH, bool GLMMOHLBAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class EKEDJEKFHIB : FPFJDCLOBAL, CCFEEODIKGE, MDAIOIDMGBH, FALEPMCOKGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly CCFEEODIKGE PAGDOOLJHFE;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public AOLOIKMEGKC CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2550", Offset = "0x2DF0F50", VA = "0x182DF2550", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int NMAFKKLCGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2DF22D0", Offset = "0x2DF0CD0", VA = "0x182DF22D0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int AMGBEHFFOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF23C0", Offset = "0x2DF0DC0", VA = "0x182DF23C0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool DFHLPIBAKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event FGMKGNLMHPM CCOJPCCCNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2870", Offset = "0x2DF1270", VA = "0x182DF2870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2320", Offset = "0x2DF0D20", VA = "0x182DF2320", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<AOLOIKMEGKC> MCBCCBLNANM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2970", Offset = "0x2DF1370", VA = "0x182DF2970", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2410", Offset = "0x2DF0E10", VA = "0x182DF2410", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action DIHIPDPJPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2DF24B0", Offset = "0x2DF0EB0", VA = "0x182DF24B0", Slot = "21")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2DF25A0", Offset = "0x2DF0FA0", VA = "0x182DF25A0", Slot = "22")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8000B0", Offset = "0x7FEAB0", VA = "0x1808000B0")]
	public EKEDJEKFHIB(CCFEEODIKGE PAGDOOLJHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2640", Offset = "0x2DF1040", VA = "0x182DF2640", Slot = "6")]
	public bool LELLBIMCKNI(byte IKCPPMJMAML, ExitGames.Client.Photon.Hashtable GFHPBGABJFE, FCJNKFJKFGK APLJDGLHPNJ, SendOptions NCHANPECAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2DF27B0", Offset = "0x2DF11B0", VA = "0x182DF27B0", Slot = "24")]
	public AOLOIKMEGKC MKLGKKIOBHO(int NGPIEMKDAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DF26E0", Offset = "0x2DF10E0", VA = "0x182DF26E0", Slot = "13")]
	public AOLOIKMEGKC LPCLJNCAIAA(int LCAHHDBJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "14")]
	public void MKAPGDPEDLE(object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "15")]
	public void BBBBHLKOBAM(object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "16")]
	public void FIMFGNINPOB(object LBAGELALLHA, bool PBGCOGCBHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2910", Offset = "0x2DF1310", VA = "0x182DF2910", Slot = "17")]
	public IDisposable PFIIKOPBCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90", Slot = "18")]
	private bool GDNIFGGOAKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "19")]
	public void JHEAAMFCOJB(StringBuilder FDAFEJDPGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2850", Offset = "0x2DF1250", VA = "0x182DF2850", Slot = "20")]
	public bool OADKADCNJNF(bool BPDIAADHPHD, out string EPHLCEKHMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	public void OLKKNEPNOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1A7F3D0", Offset = "0x1A7DDD0", VA = "0x181A7F3D0", Slot = "23")]
	public void IFGKAKBFAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct JJAJPPLOCBB
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public const string IACFKMJAKOP = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public const string CNDALDBNLME = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private readonly IDictionary<object, object> FEHBGLJINON;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool PINGKOBKAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x7724A0", VA = "0x180773AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x709280", Offset = "0x707C80", VA = "0x180709280")]
	public JJAJPPLOCBB(IDictionary<object, object> FEHBGLJINON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4D70", Offset = "0x2BB3770", VA = "0x182BB4D70")]
	public bool IMDKBNDKMGL(out IBNMHBIHLHI OLLHPIFFHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4CB0", Offset = "0x2BB36B0", VA = "0x182BB4CB0")]
	public Guid AIAIPNMEICA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4E00", Offset = "0x2BB3800", VA = "0x182BB4E00")]
	public DHCFGHIPPFB JPANGGLMEFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4BE0", Offset = "0x2BB35E0", VA = "0x182BB4BE0")]
	public static ExitGames.Client.Photon.Hashtable AEEGCHIFHAD(IBNMHBIHLHI OLLHPIFFHKE, DHCFGHIPPFB ADGIOGKBNDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal static class ENPLCLFCNGK
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2BC0", Offset = "0x2DF15C0", VA = "0x182DF2BC0")]
	public static string POBLKKHGHGL(this EIEGHKKPADG KHFJEPJKLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2B40", Offset = "0x2DF1540", VA = "0x182DF2B40")]
	public static bool JILGJLADMDO(this EIEGHKKPADG KHFJEPJKLIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct ADCOBFHDEHP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct BIFNCNDGLLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public ADCOBFHDEHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6200", Offset = "0x2DE4C00", VA = "0x182DE6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private readonly Func<CancellationToken, List<Task>> FNJOBCNNJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private readonly CancellationTokenSource LNHBGENCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool KIHCNAMPEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Task MLPEOOKMEFP;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool PINGKOBKAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2C40", Offset = "0x2DE1640", VA = "0x182DE2C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal Task ALDIDLIEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2C70", Offset = "0x2DE1670", VA = "0x182DE2C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2CF0", Offset = "0x2DE16F0", VA = "0x182DE2CF0")]
	public ADCOBFHDEHP(Func<CancellationToken, List<Task>> FNJOBCNNJFI, CancellationToken PKFOPLIPJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2AE0", Offset = "0x2DE14E0", VA = "0x182DE2AE0")]
	[AsyncStateMachine(typeof(BIFNCNDGLLB))]
	public Task DIKDBJNCIPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2BF0", Offset = "0x2DE15F0", VA = "0x182DE2BF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class MNECIJJBOAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly KHLILJNNBNI JMIBBPGIFBJ;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private const string KHFGBDDHGNC = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private const string FLGCMMHCEAC = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private const string APNKKNKJMPB = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private const string CADHKMJPFJH = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private string BBHDIBAFBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private long? MPOCDAPMEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private long? ANJAOHBOGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private BNENILNLBIM CEKFBAFMKIC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string KLPENCJIAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public long HFDFDPAJOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE100", Offset = "0x2EBCB00", VA = "0x182EBE100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public long LEBFPLAPNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE390", Offset = "0x2EBCD90", VA = "0x182EBE390")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public BNENILNLBIM LJCNMGLIGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x61EFA0", Offset = "0x61D9A0", VA = "0x18061EFA0")]
		get
		{
			return default(BNENILNLBIM);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE630", Offset = "0x2EBD030", VA = "0x182EBE630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE710", Offset = "0x2EBD110", VA = "0x182EBE710")]
	[Preserve]
	public MNECIJJBOAL([GEKAHLKFDNK(null)] KHLILJNNBNI JMIBBPGIFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE3E0", Offset = "0x2EBCDE0", VA = "0x182EBE3E0")]
	private void KKHOJPBIKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE150", Offset = "0x2EBCB50", VA = "0x182EBE150")]
	public void CMJOBKBOGFN(long GJMALLKLAFM, long BMNHGDIENAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE540", Offset = "0x2EBCF40", VA = "0x182EBE540")]
	public void LBOJJOPFMFC(string FMDDGEJOJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2EBDEC0", Offset = "0x2EBC8C0", VA = "0x182EBDEC0")]
	public void AOPKGFNLKFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class FLDAJIIDCOG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct CEJLFGBAJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public FLDAJIIDCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public IBNMHBIHLHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter<FOIDBCHNNCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8290", Offset = "0x2DE6C90", VA = "0x182DE8290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8660", Offset = "0x2DE7060", VA = "0x182DE8660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct HHKELFGODAD<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class EFJOCMLJKIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public IBNMHBIHLHI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public EFJOCMLJKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9450", Offset = "0x2BA7E50", VA = "0x182BA9450")]
		internal IBNMHBIHLHI <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct ACBIHPLDDDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder<FOIDBCHNNCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public IBNMHBIHLHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public FLDAJIIDCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private HBDFKEIEKDK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<FOIDBCHNNCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2DE24C0", Offset = "0x2DE0EC0", VA = "0x182DE24C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2DE2A90", Offset = "0x2DE1490", VA = "0x182DE2A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct BJDILKOGPGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public FLDAJIIDCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2DE63E0", Offset = "0x2DE4DE0", VA = "0x182DE63E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class KDACHEDPACE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KDACHEDPACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9980", Offset = "0x2BB8380", VA = "0x182BB9980")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class NGNDNBNOGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NGNDNBNOGBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAFB0", Offset = "0x2BB99B0", VA = "0x182BBAFB0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class FHCDJIGOLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FHCDJIGOLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB4C0", Offset = "0x2BA9EC0", VA = "0x182BAB4C0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class LKOABJLOJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LKOABJLOJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAA20", Offset = "0x2BB9420", VA = "0x182BBAA20")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class IFPLNFHBHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public FLDAJIIDCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IFPLNFHBHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2BB26E0", Offset = "0x2BB10E0", VA = "0x182BB26E0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class KKOBGGOJIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public FLDAJIIDCOG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KKOBGGOJIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9AD0", Offset = "0x2BB84D0", VA = "0x182BB9AD0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly Guid OIHFCNHEDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	[NotNull]
	public readonly BDMELKPFPFB EGCLKIHOBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public readonly KHCJOIGIKIA EJBAGIBKIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly LCPNDJJAJIP LOFBICGMDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private readonly MDAIOIDMGBH PLCGLJPJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private readonly FALEPMCOKGH EBOMCILGIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool AGPDPOIJKKN;

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4F50", Offset = "0x2DF3950", VA = "0x182DF4F50")]
	public FLDAJIIDCOG(KHCJOIGIKIA BIENEBJDHDJ, LCPNDJJAJIP LOFBICGMDCJ, MDAIOIDMGBH PLCGLJPJKBH, FALEPMCOKGH EBOMCILGIEA, BDMELKPFPFB BCIAJNNCADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3DB0", Offset = "0x2DF27B0", VA = "0x182DF3DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3DB0", Offset = "0x2DF27B0", VA = "0x182DF3DB0")]
	public void BHEHNNEINOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4210", Offset = "0x2DF2C10", VA = "0x182DF4210")]
	public void EKLOCJNAPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4330", Offset = "0x2DF2D30", VA = "0x182DF4330")]
	public void HALGNFOHAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3AA0", Offset = "0x2DF24A0", VA = "0x182DF3AA0")]
	[AsyncStateMachine(typeof(CEJLFGBAJIO))]
	internal Task<IBNMHBIHLHI> AHHDIBAMEPN(IBNMHBIHLHI LCIIFCAADFG, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0C50", Offset = "0x2BAF650", VA = "0x182BB0C50")]
	private static byte[] BJMOAMBEODH<T>(T OLLHPIFFHKE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2937580", Offset = "0x2935F80", VA = "0x182937580")]
	private static T PDEBJOJILNF<T>(MessageParser<T> FEBIJDPLIGG, byte[] OLLHPIFFHKE, T PNHNCJNEDLK) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4800", Offset = "0x2DF3200", VA = "0x182DF4800")]
	[AsyncStateMachine(typeof(ACBIHPLDDDH))]
	private Task<FOIDBCHNNCK> JJFHJJFFAGI(IBNMHBIHLHI LCIIFCAADFG, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x30723B0", Offset = "0x3070DB0", VA = "0x1830723B0")]
	[AsyncStateMachine(typeof(NHLBAHKOLCE))]
	internal Task<T> ANPMEOMNKNM<T>(CancellationToken ADDHBCOAOKN, Func<CancellationToken, Task<T>> HJLODIICIGH, int FILNCCKMPFC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3C10", Offset = "0x2DF2610", VA = "0x182DF3C10")]
	[AsyncStateMachine(typeof(BJDILKOGPGE))]
	internal Task ANPMEOMNKNM(CancellationToken ADDHBCOAOKN, Func<CancellationToken, Task> HJLODIICIGH, int FILNCCKMPFC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4460", Offset = "0x2DF2E60", VA = "0x182DF4460")]
	public IBNMHBIHLHI HGOICLCLCJG(HBDFKEIEKDK GCCPLFKOBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4B30", Offset = "0x2DF3530", VA = "0x182DF4B30")]
	public HFOHACGHJPI NDGDCDKHLEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4E80", Offset = "0x2DF3880", VA = "0x182DF4E80")]
	public KCDIHKIEJBK PAAPLKKLJHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4AA0", Offset = "0x2DF34A0", VA = "0x182DF4AA0")]
	public LPENCIOEGGE MOFPBHIGNHB([Optional] PCFOFLNNLFB? AMFGPAKCLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4790", Offset = "0x2DF3190", VA = "0x182DF4790")]
	public KACAMBEBNDD JBDCECPEPMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3BE0", Offset = "0x2DF25E0", VA = "0x182DF3BE0")]
	public void AIPNCHJLGPH(Func<Guid, bool> IEGOIPJCKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4090", Offset = "0x2DF2A90", VA = "0x182DF4090")]
	public void DOPOLLMEEFP(Func<Guid, bool> OJDCILJCJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4940", Offset = "0x2DF3340", VA = "0x182DF4940")]
	public void JPOAEFDBEHI(Func<Guid, bool> IEGOIPJCKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4BA0", Offset = "0x2DF35A0", VA = "0x182DF4BA0")]
	public Guid NNBPOEJLMAA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3F30", Offset = "0x2DF2930", VA = "0x182DF3F30")]
	public void CDFJAAIMDPD(Guid FEMFELHFPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4D70", Offset = "0x2DF3770", VA = "0x182DF4D70")]
	public void OJOGAELBBGI(IBNMHBIHLHI JJDKJFDBMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4640", Offset = "0x2DF3040", VA = "0x182DF4640")]
	public void HPBOCPHBLIF(string GFEBABOPDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2DF44F0", Offset = "0x2DF2EF0", VA = "0x182DF44F0")]
	public void HPBOCPHBLIF(Func<string> JIMNOEAHJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2937500", Offset = "0x2935F00", VA = "0x182937500")]
	private T GMAIGJFDDEF<T>(T HPIAFNBPEPC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3D60", Offset = "0x2DF2760", VA = "0x182DF3D60")]
	public void BFIHKGNBKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x30726B0", Offset = "0x30710B0", VA = "0x1830726B0")]
	[CompilerGenerated]
	internal static string LJLJOICKNCN<T>(byte[] MCBNAPIFOAJ, int GBNJNMPGGHO, ref HHKELFGODAD<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal sealed class CPKJPDIGAHE : KHCJOIGIKIA
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class AIHEJPANOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public AIHEJPANOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2DE4870", Offset = "0x2DE3270", VA = "0x182DE4870")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CLJIFMLBJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CPKJPDIGAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private CGDIABNKEOO <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private JKPNDOLIOLF <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private KCDIHKIEJBK <loadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<JKPNDOLIOLF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9680", Offset = "0x2DE8080", VA = "0x182DE9680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class EMDGIDJAHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public CGDIABNKEOO presence;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public EMDGIDJAHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2A10", Offset = "0x2DF1410", VA = "0x182DF2A10")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly EIEGHKKPADG CDIPDDJCGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly NGOICDDIJMO IABNOHPMMNP;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private const bool OJPAJMEDCLE = false;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBBD0", Offset = "0x2DEA5D0", VA = "0x182DEBBD0")]
	public CPKJPDIGAHE(EIEGHKKPADG CDIPDDJCGBO, Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, KKFCNNLFPAP FFFOIDAKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB690", Offset = "0x2DEA090", VA = "0x182DEB690", Slot = "5")]
	[AsyncStateMachine(typeof(CLJIFMLBJON))]
	protected override Task LFAOPOELHPG(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2DEBAE0", Offset = "0x2DEA4E0", VA = "0x182DEBAE0")]
	private Task<JKPNDOLIOLF> PDAOBNLFACL(FLDAJIIDCOG FENCPFKHOGO, CGDIABNKEOO PAIPAEMBGBC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB7C0", Offset = "0x2DEA1C0", VA = "0x182DEB7C0")]
	private CGDIABNKEOO OCKNOHBJDAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB470", Offset = "0x2DE9E70", VA = "0x182DEB470")]
	private void BOICGBMFLDD(CGDIABNKEOO IGIDEMBALMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2DEB5B0", Offset = "0x2DE9FB0", VA = "0x182DEB5B0")]
	private static void DFOMOJNILFB(EIEGHKKPADG KHFJEPJKLIN, [Optional] string OLLHPIFFHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal class CONMGAOEIKI : KHCJOIGIKIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct IDLGFCADAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CONMGAOEIKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<CKEPHPBIHBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6860", Offset = "0x2DF5260", VA = "0x182DF6860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly int CPLNEMMFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly NJHEDNCKIJM APIOJDDPFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly long OIMDNHDFGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly long IGAFIOJCOGD;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA600", Offset = "0x2DE9000", VA = "0x182DEA600")]
	public CONMGAOEIKI(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, KKFCNNLFPAP FFFOIDAKNNM, int CPLNEMMFBEL, NJHEDNCKIJM APIOJDDPFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA4E0", Offset = "0x2DE8EE0", VA = "0x182DEA4E0", Slot = "5")]
	[AsyncStateMachine(typeof(IDLGFCADAIG))]
	protected override Task LFAOPOELHPG(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal abstract class NCOMBECFKON : KHCJOIGIKIA
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class MIPOPCKDNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public NCOMBECFKON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public OMEGIBOKOOC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public MIPOPCKDNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDDD0", Offset = "0x2EBC7D0", VA = "0x182EBDDD0")]
		internal Task <RunAsync>b__0(BDMELKPFPFB postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDE10", Offset = "0x2EBC810", VA = "0x182EBDE10")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct PBJBAKHGBDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public NCOMBECFKON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private MIPOPCKDNFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2EC43A0", Offset = "0x2EC2DA0", VA = "0x182EC43A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct OCODCCKHKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public OMEGIBOKOOC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public NCOMBECFKON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2370", Offset = "0x2EC0D70", VA = "0x182EC2370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2EBF6D0", Offset = "0x2EBE0D0", VA = "0x182EBF6D0")]
	public NCOMBECFKON(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, KKFCNNLFPAP FFFOIDAKNNM, string BKJFDALPNCC, bool BNNLOMIOBJB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBF5A0", Offset = "0x2EBDFA0", VA = "0x182EBF5A0", Slot = "5")]
	[AsyncStateMachine(typeof(PBJBAKHGBDF))]
	protected override Task LFAOPOELHPG(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task GPBFNHAPHPN(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2EBF460", Offset = "0x2EBDE60", VA = "0x182EBF460")]
	[AsyncStateMachine(typeof(OCODCCKHKGE))]
	private Task JIGBBLCDNNC(IDisposable PJGAGOENBEP, OMEGIBOKOOC LAHKHOENILE, BDMELKPFPFB IHHDBHELEOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal class BKHLMNHPBJF : KHCJOIGIKIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct ILBJEDKBFJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public BKHLMNHPBJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private KACAMBEBNDD <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<DLFFBEKDBKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2DF74E0", Offset = "0x2DF5EE0", VA = "0x182DF74E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private readonly NJHEDNCKIJM APIOJDDPFOL;

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6760", Offset = "0x2DE5160", VA = "0x182DE6760")]
	public BKHLMNHPBJF(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, KKFCNNLFPAP FFFOIDAKNNM, NJHEDNCKIJM APIOJDDPFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6550", Offset = "0x2DE4F50", VA = "0x182DE6550", Slot = "4")]
	protected override string AHPGFJBBNDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6620", Offset = "0x2DE5020", VA = "0x182DE6620", Slot = "5")]
	[AsyncStateMachine(typeof(ILBJEDKBFJN))]
	protected override Task LFAOPOELHPG(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal abstract class KHCJOIGIKIA
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public delegate Task GLPKKNMLELK(BDMELKPFPFB BCIAJNNCADP, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class GGLHDDIHFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public KHCJOIGIKIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GGLHDDIHFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1670", Offset = "0x2EB0070", VA = "0x182EB1670")]
		internal Task <Run>b__0(CancellationToken t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1760", Offset = "0x2EB0160", VA = "0x182EB1760")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class GIDPJGILCHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public GGLHDDIHFLC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GIDPJGILCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1BD0", Offset = "0x2EB05D0", VA = "0x182EB1BD0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1C90", Offset = "0x2EB0690", VA = "0x182EB1C90")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct ICAIPHGILGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public KHCJOIGIKIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Func<KHCJOIGIKIA, BDMELKPFPFB, FLDAJIIDCOG> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private GGLHDDIHFLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private FLDAJIIDCOG <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB3740", Offset = "0x2EB2140", VA = "0x182EB3740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct GOAHEEEGBAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public KHCJOIGIKIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB2470", Offset = "0x2EB0E70", VA = "0x182EB2470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public readonly Guid ILMFDDGNHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public readonly ByteString CCBBONJGKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public readonly KKFCNNLFPAP EHBGLDAJINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	protected readonly string COPBDKFKJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private readonly GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private readonly bool BNNLOMIOBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private bool NEPDPCEIMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public BNENILNLBIM MGMIBIDNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public BNENILNLBIM OOOFFNEBJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private readonly Queue<GLPKKNMLELK> OPNGFJKGMAP;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public GAMFAADDNHJ KDJICPHBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5644A0", Offset = "0x562EA0", VA = "0x1805644A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6200", Offset = "0x2EB4C00", VA = "0x182EB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6040", Offset = "0x2EB4A40", VA = "0x182EB6040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6330", Offset = "0x2EB4D30", VA = "0x182EB6330")]
	protected KHCJOIGIKIA(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, KKFCNNLFPAP FFFOIDAKNNM, string BKJFDALPNCC, bool BNNLOMIOBJB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6000", Offset = "0x2EB4A00", VA = "0x182EB6000", Slot = "4")]
	protected virtual string AHPGFJBBNDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2EB62D0", Offset = "0x2EB4CD0", VA = "0x182EB62D0")]
	public void NIEJOLBHBAC(GLPKKNMLELK FOGDOPGHCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5EC0", Offset = "0x2EB48C0", VA = "0x182EB5EC0")]
	[AsyncStateMachine(typeof(ICAIPHGILGH))]
	public Task ADLAMHIBLDH(CancellationToken PKFOPLIPJOL, BDMELKPFPFB BCIAJNNCADP, [Optional] Func<KHCJOIGIKIA, BDMELKPFPFB, FLDAJIIDCOG> DAECNBDGINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract Task LFAOPOELHPG(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2EB60C0", Offset = "0x2EB4AC0", VA = "0x182EB60C0")]
	[AsyncStateMachine(typeof(GOAHEEEGBAF))]
	private Task CPLBNDHKJHL(BDMELKPFPFB BCIAJNNCADP, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6250", Offset = "0x2EB4C50", VA = "0x182EB6250")]
	public IBNMHBIHLHI HGOICLCLCJG(HBDFKEIEKDK GCCPLFKOBBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal sealed class KKCMNCOBBFK : NCOMBECFKON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct FEHEKKGBOMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public KKCMNCOBBFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private FDMOMPKDGBE <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2EB04D0", Offset = "0x2EAEED0", VA = "0x182EB04D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private readonly JKPNDOLIOLF DGEMIAJPJHB;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6560", Offset = "0x2EB4F60", VA = "0x182EB6560")]
	public KKCMNCOBBFK(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, JKPNDOLIOLF DGEMIAJPJHB, KKFCNNLFPAP FFFOIDAKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6430", Offset = "0x2EB4E30", VA = "0x182EB6430", Slot = "6")]
	[AsyncStateMachine(typeof(FEHEKKGBOMI))]
	protected override Task GPBFNHAPHPN(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class NHDCIJFCCBI : KHCJOIGIKIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct NCFDLCPINAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public NHDCIJFCCBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TaskAwaiter<DLFFBEKDBKJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF1F0", Offset = "0x2EBDBF0", VA = "0x182EBF1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private readonly string JCDPLEAFLPC;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2EBFAB0", Offset = "0x2EBE4B0", VA = "0x182EBFAB0")]
	public NHDCIJFCCBI(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, KKFCNNLFPAP FFFOIDAKNNM, string JCDPLEAFLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2EBF980", Offset = "0x2EBE380", VA = "0x182EBF980", Slot = "5")]
	[AsyncStateMachine(typeof(NCFDLCPINAI))]
	protected override Task LFAOPOELHPG(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class LEHPKHOABPG : NCOMBECFKON
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class MOOGBPPBKKJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public MOOGBPPBKKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			private TaskAwaiter<DLFFBEKDBKJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			private TaskAwaiter<IBNMHBIHLHI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5730", Offset = "0x2EC4130", VA = "0x182EC5730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5AB0", Offset = "0x2EC44B0", VA = "0x182EC5AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public LEHPKHOABPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public LPENCIOEGGE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public HFOHACGHJPI uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public long superRoomId;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public MOOGBPPBKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEA30", Offset = "0x2EBD430", VA = "0x182EBEA30")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<IBNMHBIHLHI> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct PCFLLMJFDGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public LEHPKHOABPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private MOOGBPPBKKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private FDMOMPKDGBE <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private KCDIHKIEJBK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4A20", Offset = "0x2EC3420", VA = "0x182EC4A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private readonly int HLHIANOGMJF;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2EB91F0", Offset = "0x2EB7BF0", VA = "0x182EB91F0")]
	public LEHPKHOABPG(Guid BJDJCGIBLIK, GAMFAADDNHJ CEMCPIENNAH, int HLHIANOGMJF, KKFCNNLFPAP FFFOIDAKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB90C0", Offset = "0x2EB7AC0", VA = "0x182EB90C0", Slot = "6")]
	[AsyncStateMachine(typeof(PCFLLMJFDGO))]
	protected override Task GPBFNHAPHPN(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8E10", Offset = "0x2EB7810", VA = "0x182EB8E10")]
	private void BDGOHDAAJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8EE0", Offset = "0x2EB78E0", VA = "0x182EB8EE0")]
	private void GJBGDKLFJDH(FLDAJIIDCOG FENCPFKHOGO, FDMOMPKDGBE FPEKAOBNGCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal abstract class JDDLJNBJPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public readonly KHCJOIGIKIA EJBAGIBKIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public readonly FLDAJIIDCOG KIJIMLOJDEN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3D80", Offset = "0x2BB2780", VA = "0x182BB3D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3D20", Offset = "0x2BB2720", VA = "0x182BB3D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3DE0", Offset = "0x2BB27E0", VA = "0x182BB3DE0")]
	protected JDDLJNBJPEB(FLDAJIIDCOG FENCPFKHOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3DA0", Offset = "0x2BB27A0", VA = "0x182BB3DA0")]
	protected void HPBOCPHBLIF(string GFEBABOPDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3DC0", Offset = "0x2BB27C0", VA = "0x182BB3DC0")]
	public void HPBOCPHBLIF(Func<string> JIMNOEAHJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct JIHLAGDHAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public Dictionary<Guid, List<MGODOBFMFAB>> GNNLDOEMNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public Dictionary<Guid, List<MGODOBFMFAB>> LKKHACAFMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public Dictionary<Guid, List<MGODOBFMFAB>> DHAILHDPDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public List<Guid> KHOLBEBCMJP;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB43C0", Offset = "0x2BB2DC0", VA = "0x182BB43C0")]
	public static JIHLAGDHAKL POIAOKDLGFC(EFFFPKFCLCK LNJKINMJMME, BNENILNLBIM FOMIDNMLOFM)
	{
		return default(JIHLAGDHAKL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct CHCNLDHEGJC
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90")]
	public static CHCNLDHEGJC AEEGCHIFHAD()
	{
		return default(CHCNLDHEGJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JIFEEBDGAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void ODDKCLAJJKI(HDNBAJBNCBH CIBAGEDPOOH, object HAJNGGOKBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JPIDKLHEOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct NACAEKFJEOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly CKEPHPBIHBC DPJGGPJKICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly ALDJHDJCCBC KEMPIGAHNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly MKPNOOIFNAE EDIICOPIJBG;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xC04120", Offset = "0xC02B20", VA = "0x180C04120")]
	public NACAEKFJEOK(CKEPHPBIHBC DPJGGPJKICA, ALDJHDJCCBC KEMPIGAHNHE, MKPNOOIFNAE EDIICOPIJBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal struct JDKMEJKMDHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly FLDAJIIDCOG FENCPFKHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly Guid FEMFELHFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private bool BJALHGCPBHG;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3F50", Offset = "0x2BB2950", VA = "0x182BB3F50")]
	public static JDKMEJKMDHF NNBPOEJLMAA(FLDAJIIDCOG FENCPFKHOGO)
	{
		return default(JDKMEJKMDHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x9A1510", Offset = "0x99FF10", VA = "0x1809A1510")]
	public void BKIGCPAIEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3E40", Offset = "0x2BB2840", VA = "0x182BB3E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3FB0", Offset = "0x2BB29B0", VA = "0x182BB3FB0")]
	private JDKMEJKMDHF(FLDAJIIDCOG FENCPFKHOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3E40", Offset = "0x2BB2840", VA = "0x182BB3E40")]
	private void CDFJAAIMDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3EA0", Offset = "0x2BB28A0", VA = "0x182BB3EA0")]
	private Func<Guid, bool> FKDCIECMOPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class KCDIHKIEJBK : JDDLJNBJPEB
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public delegate Task<BNENILNLBIM> IHHNDIKHJOB(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI DADIIBHBJEI, CancellationToken PKFOPLIPJOL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct ANGEPHEEMGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public JKPNDOLIOLF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private JDKMEJKMDHF <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6510", Offset = "0x2BA4F10", VA = "0x182BA6510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct OHPBABDEIMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public JKPNDOLIOLF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3BA0", Offset = "0x2EC25A0", VA = "0x182EC3BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3E60", Offset = "0x2EC2860", VA = "0x182EC3E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct PAINJNOOJGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public JKPNDOLIOLF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4160", Offset = "0x2EC2B60", VA = "0x182EC4160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct ODFLKDEKDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public JKPNDOLIOLF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private HDNBAJBNCBH <phaseArgs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private TaskAwaiter<NACAEKFJEOK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<HDNBAJBNCBH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private LDCJEGGGBBI <timedYielder>5__3;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2710", Offset = "0x2EC1110", VA = "0x182EC2710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct FAPEPKFFBMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public BDMELKPFPFB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA750", Offset = "0x2BA9150", VA = "0x182BAA750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct LHDNMODPMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9870", Offset = "0x2EB8270", VA = "0x182EB9870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct JNBEHADHNEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private KAKNEGAPNEF.LJDLBLHBPEO <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<KAKNEGAPNEF.LJDLBLHBPEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4300", Offset = "0x2EB2D00", VA = "0x182EB4300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4CD0", Offset = "0x2EB36D0", VA = "0x182EB4CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct NHIDDMJKPEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public LDCJEGGGBBI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFB50", Offset = "0x2EBE550", VA = "0x182EBFB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC05D0", Offset = "0x2EBEFD0", VA = "0x182EC05D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct LCEEJOCMBEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public BNENILNLBIM operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2EB82C0", Offset = "0x2EB6CC0", VA = "0x182EB82C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8490", Offset = "0x2EB6E90", VA = "0x182EB8490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct EFEHOMENBAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public BNENILNLBIM operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9280", Offset = "0x2BA7C80", VA = "0x182BA9280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9400", Offset = "0x2BA7E00", VA = "0x182BA9400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class JPFPKOKDLJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public IHHNDIKHJOB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public LDCJEGGGBBI timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JPFPKOKDLJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class CNBFBJNHGCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public CNBFBJNHGCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private TaskAwaiter<BNENILNLBIM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x2BBCA10", Offset = "0x2BBB410", VA = "0x182BBCA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x2BBCFD0", Offset = "0x2BBB9D0", VA = "0x182BBCFD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public BNENILNLBIM originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JPFPKOKDLJB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public CNBFBJNHGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7CD0", Offset = "0x2BA66D0", VA = "0x182BA7CD0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<BNENILNLBIM> <MasterLockedPhaseChangeBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CCKFAMHHIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public IHHNDIKHJOB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public LDCJEGGGBBI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7500", Offset = "0x2BA5F00", VA = "0x182BA7500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7900", Offset = "0x2BA6300", VA = "0x182BA7900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct JIGGGHJHAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private BNENILNLBIM <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private IEnumerator<BNENILNLBIM> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4080", Offset = "0x2BB2A80", VA = "0x182BB4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct KFHLKPMKAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5A70", Offset = "0x2EB4470", VA = "0x182EB5A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct JNIAFEBGPHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4D20", Offset = "0x2EB3720", VA = "0x182EB4D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct DLNAOJBMLKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public AsyncTaskMethodBuilder<KAKNEGAPNEF.LJDLBLHBPEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public KCDIHKIEJBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private TaskAwaiter<KAKNEGAPNEF.LJDLBLHBPEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D70", Offset = "0x2BA7770", VA = "0x182BA8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8F80", Offset = "0x2BA7980", VA = "0x182BA8F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class DGJBABAIIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CKEPHPBIHBC roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DGJBABAIIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B00", Offset = "0x2BA7500", VA = "0x182BA8B00")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly EHMHBECLOPG HLBKDDEPGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly EHMHBECLOPG EMBBEOMOBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly MNECIJJBOAL DCKFOICAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly CFAENIIKOFF MGDBNDLGKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private readonly LPAIBGBFGDO BDEFNALLBHG;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private BDMELKPFPFB MLFMKCDNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5F0720", Offset = "0x5EF120", VA = "0x1805F0720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private GAMFAADDNHJ KDJICPHBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF130", Offset = "0x2BADB30", VA = "0x182BAF130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB97D0", Offset = "0x2BB81D0", VA = "0x182BB97D0")]
	public KCDIHKIEJBK(FLDAJIIDCOG FENCPFKHOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96A0", Offset = "0x2BB80A0", VA = "0x182BB96A0")]
	[AsyncStateMachine(typeof(ANGEPHEEMGK))]
	public Task PJGAFFOIMBA(JKPNDOLIOLF LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB93A0", Offset = "0x2BB7DA0", VA = "0x182BB93A0")]
	[AsyncStateMachine(typeof(OHPBABDEIMO))]
	private Task<IBNMHBIHLHI> MNKHPPJGAMP(JKPNDOLIOLF LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9560", Offset = "0x2BB7F60", VA = "0x182BB9560")]
	[AsyncStateMachine(typeof(PAINJNOOJGF))]
	private Task PBJEDECDOBG(JKPNDOLIOLF LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8BB0", Offset = "0x2BB75B0", VA = "0x182BB8BB0")]
	[AsyncStateMachine(typeof(ODFLKDEKDMI))]
	private Task FJCKCHCKIAL(JKPNDOLIOLF LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8EA0", Offset = "0x2BB78A0", VA = "0x182BB8EA0")]
	[AsyncStateMachine(typeof(FAPEPKFFBMH))]
	private Task KJIMMBBCEAK(BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB86A0", Offset = "0x2BB70A0", VA = "0x182BB86A0")]
	[AsyncStateMachine(typeof(LHDNMODPMBC))]
	private Task CNDIIBPGDGO(HDNBAJBNCBH CIBAGEDPOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8D00", Offset = "0x2BB7700", VA = "0x182BB8D00")]
	[AsyncStateMachine(typeof(JNBEHADHNEM))]
	private Task<BNENILNLBIM> IMPHHAJGBCJ(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8300", Offset = "0x2BB6D00", VA = "0x182BB8300")]
	[AsyncStateMachine(typeof(NHIDDMJKPEL))]
	private Task<BNENILNLBIM> BFMPANMAKPP(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8920", Offset = "0x2BB7320", VA = "0x182BB8920")]
	[AsyncStateMachine(typeof(LCEEJOCMBEN))]
	private Task<BNENILNLBIM> EHKLBLPCPPP(BNENILNLBIM FOMIDNMLOFM, bool MNGHABHFIDN, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8A60", Offset = "0x2BB7460", VA = "0x182BB8A60")]
	[AsyncStateMachine(typeof(EFEHOMENBAK))]
	private Task<BNENILNLBIM> EHKLBLPCPPP(BNENILNLBIM FOMIDNMLOFM, bool MNGHABHFIDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8470", Offset = "0x2BB6E70", VA = "0x182BB8470")]
	private bool CHJLICFCOON(HDNBAJBNCBH ELFILLMKBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB87C0", Offset = "0x2BB71C0", VA = "0x182BB87C0")]
	[AsyncStateMachine(typeof(CCKFAMHHIDK))]
	protected Task<BNENILNLBIM> DPAELMHKKJH(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL, IHHNDIKHJOB ONKIJGINMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB92A0", Offset = "0x2BB7CA0", VA = "0x182BB92A0")]
	[AsyncStateMachine(typeof(JIGGGHJHAGE))]
	private Task MCOLEIEADAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB85A0", Offset = "0x2BB6FA0", VA = "0x182BB85A0")]
	[AsyncStateMachine(typeof(KFHLKPMKAIL))]
	private Task CNAKIDNADMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9110", Offset = "0x2BB7B10", VA = "0x182BB9110")]
	private Task<NACAEKFJEOK> LPJFFIEMJFD(JKPNDOLIOLF LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB94E0", Offset = "0x2BB7EE0", VA = "0x182BB94E0")]
	private Task<HDNBAJBNCBH> NADGNNJCPOH(JKPNDOLIOLF LKGBFLLCPJC, NACAEKFJEOK CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB81D0", Offset = "0x2BB6BD0", VA = "0x182BB81D0")]
	[AsyncStateMachine(typeof(JNIAFEBGPHC))]
	private Task AGKHLAOECIB(HDNBAJBNCBH CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB80A0", Offset = "0x2BB6AA0", VA = "0x182BB80A0")]
	[AsyncStateMachine(typeof(DLNAOJBMLKI))]
	private Task<KAKNEGAPNEF.LJDLBLHBPEO> ADFJLEJGIHL(HDNBAJBNCBH CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8E70", Offset = "0x2BB7870", VA = "0x182BB8E70")]
	private Task KCHHOILOHPF(HDNBAJBNCBH CIBAGEDPOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8CE0", Offset = "0x2BB76E0", VA = "0x182BB8CE0")]
	private Task IFPEMJCEAFE(HDNBAJBNCBH CIBAGEDPOOH, KAKNEGAPNEF.LJDLBLHBPEO FJOAEMOHNAN, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8450", Offset = "0x2BB6E50", VA = "0x182BB8450")]
	private Task BPGBDOJHNMJ(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9530", Offset = "0x2BB7F30", VA = "0x182BB9530")]
	private Task OMCNBNIKEEL(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8FD0", Offset = "0x2BB79D0", VA = "0x182BB8FD0")]
	private static Task LLMNGEOMMMC(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8B90", Offset = "0x2BB7590", VA = "0x182BB8B90")]
	private Task ENFFEMJFEKM(HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9550", Offset = "0x2BB7F50", VA = "0x182BB9550")]
	private Task ONHKILMDNEK(HDNBAJBNCBH CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8E40", Offset = "0x2BB7840", VA = "0x182BB8E40")]
	private void KBOOPDIDHHM(JKPNDOLIOLF LKGBFLLCPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8FE0", Offset = "0x2BB79E0", VA = "0x182BB8FE0")]
	private static void LNDKAABODMB(CKEPHPBIHBC DPJGGPJKICA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct KAKNEGAPNEF
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public struct LJDLBLHBPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public readonly Dictionary<int, int> HMGCELHALEA;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x709280", Offset = "0x707C80", VA = "0x180709280")]
		public LJDLBLHBPEO(Dictionary<int, int> HMGCELHALEA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400038F")]
	private BNENILNLBIM KPDNBGODPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private HDNBAJBNCBH CIBAGEDPOOH;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7CA0", Offset = "0x2BB66A0", VA = "0x182BB7CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7C20", Offset = "0x2BB6620", VA = "0x182BB7C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2BB78D0", Offset = "0x2BB62D0", VA = "0x182BB78D0")]
	public static Task<LJDLBLHBPEO> ADLAMHIBLDH(GAMFAADDNHJ CEMCPIENNAH, BNENILNLBIM KPDNBGODPEK, HDNBAJBNCBH CIBAGEDPOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7980", Offset = "0x2BB6380", VA = "0x182BB7980")]
	private LJDLBLHBPEO ADLAMHIBLDH()
	{
		return default(LJDLBLHBPEO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct MDNPGJPLDOK
{
	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD720", Offset = "0x2EBC120", VA = "0x182EBD720")]
	public static Task ADLAMHIBLDH(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal struct CHABOBKBGPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct COGCACKPJHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2DEA1D0", Offset = "0x2DE8BD0", VA = "0x182DEA1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9380", Offset = "0x2DE7D80", VA = "0x182DE9380")]
	[AsyncStateMachine(typeof(COGCACKPJHA))]
	public static Task ADLAMHIBLDH(FLDAJIIDCOG FENCPFKHOGO, HDNBAJBNCBH CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal struct EJPAIPLHFBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct CLLGBKJEPFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public LDCJEGGGBBI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private BNENILNLBIM <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private GAMFAADDNHJ <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private EFFFPKFCLCK <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private List<(PersistenceView, CLMIJCBDJCL)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CLMIJCBDJCL <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9AF0", Offset = "0x2DE84F0", VA = "0x182DE9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1F00", Offset = "0x2DF0900", VA = "0x182DF1F00")]
	[AsyncStateMachine(typeof(CLLGBKJEPFJ))]
	public static Task ADLAMHIBLDH(FLDAJIIDCOG FENCPFKHOGO, HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF2060", Offset = "0x2DF0A60", VA = "0x182DF2060")]
	private static void HKNLFBNDGFA(PersistenceView DBBJEPNCCKL, CLMIJCBDJCL HAJNGGOKBGL, HDNBAJBNCBH CIBAGEDPOOH, BNENILNLBIM FOMIDNMLOFM, bool ECHPMPAIHFN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal struct EBJAJAOIEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2DF15F0", Offset = "0x2DEFFF0", VA = "0x182DF15F0")]
	public static Task ADLAMHIBLDH(GAMFAADDNHJ CEMCPIENNAH, HDNBAJBNCBH CIBAGEDPOOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal struct PLHOOFLKKCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct FKHJINHPKGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public GAMFAADDNHJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public BNENILNLBIM roomOperationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C8D0", Offset = "0x4E6B2D0", VA = "0x184E6C8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct JCLLABBMGGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public PLHOOFLKKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x4E6CA50", Offset = "0x4E6B450", VA = "0x184E6CA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class BLJDHFNBJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public FCKLLFFBIPN version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BLJDHFNBJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C7A0", Offset = "0x4E6B1A0", VA = "0x184E6C7A0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C850", Offset = "0x4E6B250", VA = "0x184E6C850")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private BNENILNLBIM KPDNBGODPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private HDNBAJBNCBH CIBAGEDPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private FLDAJIIDCOG FENCPFKHOGO;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private static readonly ByteString FIPICOGOKJH;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D610", Offset = "0x4E6C010", VA = "0x184E6D610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private HILJJCHPOOA HMPKLEGKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D560", Offset = "0x4E6BF60", VA = "0x184E6D560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D2D0", Offset = "0x4E6BCD0", VA = "0x184E6D2D0")]
	[AsyncStateMachine(typeof(FKHJINHPKGK))]
	public static Task ADLAMHIBLDH(GAMFAADDNHJ CEMCPIENNAH, BNENILNLBIM KPDNBGODPEK, HDNBAJBNCBH CIBAGEDPOOH, FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D430", Offset = "0x4E6BE30", VA = "0x184E6D430")]
	[AsyncStateMachine(typeof(JCLLABBMGGP))]
	private Task ADLAMHIBLDH(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D660", Offset = "0x4E6C060", VA = "0x184E6D660")]
	private void IPFAFDJBKFH([NotNull] CHOOKADKDAN ECIMCDMIDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4E6D5E0", Offset = "0x4E6BFE0", VA = "0x184E6D5E0")]
	private bool CICJMHJBNDH(FCKLLFFBIPN NAGACMCOIBH, CHOOKADKDAN ECIMCDMIDOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal struct GOKKALKHAPL
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private struct DAONBONCJPB<Arg, Parsed> where Parsed : IMessage<Parsed>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly global::NFJKDLKHDFK<Arg> EGAAHCJGGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly global::HJPCJECNEBB<Parsed> FEBIJDPLIGG;

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x5AD410", Offset = "0x5ABE10", VA = "0x1805AD410")]
		public DAONBONCJPB(global::NFJKDLKHDFK<Arg> EGAAHCJGGAM, global::HJPCJECNEBB<Parsed> FEBIJDPLIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x38BAA10", Offset = "0x38B9410", VA = "0x1838BAA10")]
		[AsyncStateMachine(typeof(LEOOHNOOMKK))]
		public Task<Parsed> HJKLPMPOJDN(Arg MANGGNPAMDP, BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x38BAC30", Offset = "0x38B9630", VA = "0x1838BAC30")]
		[AsyncStateMachine(typeof(MLHEGGOOEJP))]
		private Task<byte[]> KADFOGCNOEE(Arg MANGGNPAMDP, CancellationToken PKFOPLIPJOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x38BA310", Offset = "0x38B8D10", VA = "0x1838BA310")]
		private Parsed CFCDHJAEHGC(byte[] BMEMKIPLPBO)
		{
			return (Parsed)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct PKOOOODFHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<HDNBAJBNCBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public GOKKALKHAPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter<(CHOOKADKDAN, BOEMNJMLBAI, HOLNDENGJON)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB420", Offset = "0x2BB9E20", VA = "0x182BBB420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB920", Offset = "0x2BBA320", VA = "0x182BBB920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private DAONBONCJPB<FOIOFCKPMAJ, CHOOKADKDAN> KEMPIGAHNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private DAONBONCJPB<FOIOFCKPMAJ, BOEMNJMLBAI> JOIPIFOAOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private DAONBONCJPB<long, HOLNDENGJON> IPOMANCELGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private JKPNDOLIOLF LKGBFLLCPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private CKEPHPBIHBC DPJGGPJKICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private ALDJHDJCCBC IKLCHJANJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private BDMELKPFPFB IHHDBHELEOM;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC850", Offset = "0x2BAB250", VA = "0x182BAC850")]
	public static Task<HDNBAJBNCBH> PCELGKPFIJE(GAMFAADDNHJ CEMCPIENNAH, JKPNDOLIOLF LKGBFLLCPJC, in NACAEKFJEOK CIBAGEDPOOH, BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC6D0", Offset = "0x2BAB0D0", VA = "0x182BAC6D0")]
	[AsyncStateMachine(typeof(PKOOOODFHIH))]
	private Task<HDNBAJBNCBH> ADLAMHIBLDH(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC810", Offset = "0x2BAB210", VA = "0x182BAC810")]
	private FOIOFCKPMAJ LOLOAKHPFFF(EBCAKELGLGO BIDDBIBMJAJ)
	{
		return default(FOIOFCKPMAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct JBNJMNCADHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct IMHBFJIIKNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public AsyncTaskMethodBuilder<NACAEKFJEOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public JBNJMNCADHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private TaskAwaiter<NACAEKFJEOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2BB31A0", Offset = "0x2BB1BA0", VA = "0x182BB31A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3560", Offset = "0x2BB1F60", VA = "0x182BB3560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class CGIECFLBAEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public CGIECFLBAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1A01E20", Offset = "0x1A00820", VA = "0x181A01E20")]
		internal bool <FetchRoomDetails>b__0(ALDJHDJCCBC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct PLNDLNCCONE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public AsyncTaskMethodBuilder<NACAEKFJEOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public JBNJMNCADHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private CGIECFLBAEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter<CKEPHPBIHBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB970", Offset = "0x2BBA370", VA = "0x182BBB970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBD80", Offset = "0x2BBA780", VA = "0x182BBBD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private MNECIJJBOAL DCKFOICAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private BDMELKPFPFB IHHDBHELEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private long GJMALLKLAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private long BMNHGDIENAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private FOIOFCKPMAJ FHFLIHGDOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private FOIOFCKPMAJ LEBOBBOMPAP;

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3BC0", Offset = "0x2BB25C0", VA = "0x182BB3BC0")]
	public static Task<NACAEKFJEOK> PCELGKPFIJE(GAMFAADDNHJ CEMCPIENNAH, JKPNDOLIOLF LKGBFLLCPJC, BDMELKPFPFB IHHDBHELEOM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3640", Offset = "0x2BB2040", VA = "0x182BB3640")]
	[AsyncStateMachine(typeof(IMHBFJIIKNE))]
	private Task<NACAEKFJEOK> ADLAMHIBLDH(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3A50", Offset = "0x2BB2450", VA = "0x182BB3A50")]
	[AsyncStateMachine(typeof(PLNDLNCCONE))]
	private Task<NACAEKFJEOK> LPJFFIEMJFD(long GJMALLKLAFM, long BMNHGDIENAL, CancellationToken PKFOPLIPJOL, bool AIPKHNBDEIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3780", Offset = "0x2BB2180", VA = "0x182BB3780")]
	private void BJHOGLIEBBB(CKEPHPBIHBC DPJGGPJKICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2BB37B0", Offset = "0x2BB21B0", VA = "0x182BB37B0")]
	private bool DILCLHLBING(NACAEKFJEOK CIBAGEDPOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2BB38F0", Offset = "0x2BB22F0", VA = "0x182BB38F0")]
	private void LDFJAHAEFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct BBCHODANJIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct MCGKNDIEJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public BBCHODANJIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9440", Offset = "0x2DF7E40", VA = "0x182DF9440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private const int NHGILNOBNCE = 20;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private const float KDGGHHKBFIH = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private EFFFPKFCLCK LNJKINMJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private HDNBAJBNCBH CIBAGEDPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private BDMELKPFPFB IHHDBHELEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private float NHLFIDBNJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private float IHFMPNEBFHF;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE59E0", Offset = "0x2DE43E0", VA = "0x182DE59E0")]
	public static Task IMEBDCKFCGL(GAMFAADDNHJ CEMCPIENNAH, FLDAJIIDCOG FENCPFKHOGO, HDNBAJBNCBH CIBAGEDPOOH, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5800", Offset = "0x2DE4200", VA = "0x182DE5800")]
	[AsyncStateMachine(typeof(MCGKNDIEJME))]
	public Task ADLAMHIBLDH(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5D20", Offset = "0x2DE4720", VA = "0x182DE5D20")]
	private static void OBKNIMPEPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5BA0", Offset = "0x2DE45A0", VA = "0x182DE5BA0")]
	private void JPMLFFENILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5920", Offset = "0x2DE4320", VA = "0x182DE5920")]
	private static float AKLHLGJJADI(EFFFPKFCLCK LNJKINMJMME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5E90", Offset = "0x2DE4890", VA = "0x182DE5E90")]
	private static float OIKBHJBIBJM()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct MNLNJBDHGNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct FHOHCOFNPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public FLDAJIIDCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public KAKNEGAPNEF.LJDLBLHBPEO mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private KHCJOIGIKIA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private GAMFAADDNHJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private NMAJBELNJGK.MMCELFPKCLG <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB09C0", Offset = "0x2EAF3C0", VA = "0x182EB09C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct DHKBFDLBMOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private GCIFPGJFDDN.ODNJLBOPICH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x2EB01A0", Offset = "0x2EAEBA0", VA = "0x182EB01A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE7B0", Offset = "0x2EBD1B0", VA = "0x182EBE7B0")]
	[AsyncStateMachine(typeof(FHOHCOFNPFG))]
	public static Task ADLAMHIBLDH(FLDAJIIDCOG FENCPFKHOGO, HDNBAJBNCBH CIBAGEDPOOH, KAKNEGAPNEF.LJDLBLHBPEO FJOAEMOHNAN, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE9E0", Offset = "0x2EBD3E0", VA = "0x182EBE9E0")]
	private static Task<IBNMHBIHLHI> HEBFKFOLEKA(FLDAJIIDCOG FENCPFKHOGO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE900", Offset = "0x2EBD300", VA = "0x182EBE900")]
	[AsyncStateMachine(typeof(DHKBFDLBMOG))]
	private static Task DGAGADLLDDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal struct OKAEOKBACJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct LCLIDIJPKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public OKAEOKBACJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2EB84E0", Offset = "0x2EB6EE0", VA = "0x182EB84E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class HODJINGHKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HODJINGHKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2EB3610", Offset = "0x2EB2010", VA = "0x182EB3610")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct FIIJLLHFKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public OKAEOKBACJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private FHPNNJDDLAE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2EB0FD0", Offset = "0x2EAF9D0", VA = "0x182EB0FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private bool PINACNIMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private BDMELKPFPFB IHHDBHELEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private CancellationToken PKFOPLIPJOL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2EC3FB0", Offset = "0x2EC29B0", VA = "0x182EC3FB0")]
	public static Task EIHAILANHLH(GAMFAADDNHJ CEMCPIENNAH, bool PINACNIMDKP, BDMELKPFPFB IHHDBHELEOM, CancellationToken GMDEBNGLPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2EC3EB0", Offset = "0x2EC28B0", VA = "0x182EC3EB0")]
	[AsyncStateMachine(typeof(LCLIDIJPKLO))]
	private Task ADLAMHIBLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2EC4030", Offset = "0x2EC2A30", VA = "0x182EC4030")]
	[AsyncStateMachine(typeof(FIIJLLHFKBC))]
	private Task LPCPIGAKHDG(bool LHMAJLKAIIL, string JEOEEAOHALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90")]
	private bool FJONBMPMILK(bool PINACNIMDKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal struct PKDAKMEACDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct NEEHAOMILBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public PKDAKMEACDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF710", Offset = "0x2EBE110", VA = "0x182EBF710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class GJNGEFLGIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GJNGEFLGIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2EB2270", Offset = "0x2EB0C70", VA = "0x182EB2270")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct HCJOHANIJHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public PKDAKMEACDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private FHPNNJDDLAE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2EB2B70", Offset = "0x2EB1570", VA = "0x182EB2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private MKPNOOIFNAE FBHNIKEEJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private bool PINACNIMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private BDMELKPFPFB IHHDBHELEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5220", Offset = "0x2EC3C20", VA = "0x182EC5220")]
	public static Task EIFGIMPEAHL(GAMFAADDNHJ CEMCPIENNAH, MKPNOOIFNAE IMLKHOKAJOP, bool PINACNIMDKP, BDMELKPFPFB IHHDBHELEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5110", Offset = "0x2EC3B10", VA = "0x182EC5110")]
	[AsyncStateMachine(typeof(NEEHAOMILBO))]
	private Task ADLAMHIBLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5280", Offset = "0x2EC3C80", VA = "0x182EC5280")]
	[AsyncStateMachine(typeof(HCJOHANIJHC))]
	private Task LPCPIGAKHDG(string JEOEEAOHALB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct LPAIBGBFGDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct BOJMBINJNAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public LPAIBGBFGDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public BNENILNLBIM nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private TaskAwaiter<BNENILNLBIM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF4C0", Offset = "0x2EADEC0", VA = "0x182EAF4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2EAFAB0", Offset = "0x2EAE4B0", VA = "0x182EAFAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct FNCAOFHKHEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<BNENILNLBIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public LPAIBGBFGDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public BNENILNLBIM state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1400", Offset = "0x2EAFE00", VA = "0x182EB1400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1620", Offset = "0x2EB0020", VA = "0x182EB1620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly FLDAJIIDCOG FENCPFKHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly MNECIJJBOAL DCKFOICAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly CFAENIIKOFF MGDBNDLGKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private CancellationToken PKFOPLIPJOL;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private KHCJOIGIKIA EJBAGIBKIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xED27A0", Offset = "0xED11A0", VA = "0x180ED27A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA670", Offset = "0x2EB9070", VA = "0x182EBA670")]
	public LPAIBGBFGDO(FLDAJIIDCOG FENCPFKHOGO, MNECIJJBOAL DCKFOICAOEN, CFAENIIKOFF MGDBNDLGKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA620", Offset = "0x2EB9020", VA = "0x182EBA620")]
	public void POBNPLBNCEO(CancellationToken PKFOPLIPJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA450", Offset = "0x2EB8E50", VA = "0x182EBA450")]
	public void JOAPAPLFCLJ(HDNBAJBNCBH CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA5B0", Offset = "0x2EB8FB0", VA = "0x182EBA5B0")]
	public Task<BNENILNLBIM> OLEPLDFAHNB(BNENILNLBIM PFJDLLMDJLE, bool MNGHABHFIDN, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA480", Offset = "0x2EB8E80", VA = "0x182EBA480")]
	[AsyncStateMachine(typeof(BOJMBINJNAB))]
	public Task<BNENILNLBIM> OLEPLDFAHNB(BNENILNLBIM PFJDLLMDJLE, bool MNGHABHFIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA310", Offset = "0x2EB8D10", VA = "0x182EBA310")]
	[AsyncStateMachine(typeof(FNCAOFHKHEG))]
	private Task<BNENILNLBIM> JAFIJGAOPHC(BNENILNLBIM BEGCHMBIIJM, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA2C0", Offset = "0x2EB8CC0", VA = "0x182EBA2C0")]
	private bool CGANOLOAKNA(BNENILNLBIM NCKENHHEJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA2F0", Offset = "0x2EB8CF0", VA = "0x182EBA2F0")]
	private void HPBOCPHBLIF(string CDCAEKJLACF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct NOJINDEGBMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct JPBJMKMFDAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public KHCJOIGIKIA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public LDCJEGGGBBI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private List<(PersistenceView, CLMIJCBDJCL)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private (PersistenceView, CLMIJCBDJCL) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4ED0", Offset = "0x2EB38D0", VA = "0x182EB4ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1170", Offset = "0x2EBFB70", VA = "0x182EC1170")]
	[AsyncStateMachine(typeof(JPBJMKMFDAL))]
	public static Task ADLAMHIBLDH(KHCJOIGIKIA BIENEBJDHDJ, HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct FAALMBLIPCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct DHLPHJKFIGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public KHCJOIGIKIA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public HDNBAJBNCBH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public LDCJEGGGBBI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private FCKLLFFBIPN <version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private List<(PersistenceView, CLMIJCBDJCL)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private CLMIJCBDJCL <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0550", Offset = "0x2DEEF50", VA = "0x182DF0550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3190", Offset = "0x2DF1B90", VA = "0x182DF3190")]
	[AsyncStateMachine(typeof(DHLPHJKFIGC))]
	public static Task ADLAMHIBLDH(KHCJOIGIKIA BIENEBJDHDJ, HDNBAJBNCBH CIBAGEDPOOH, LDCJEGGGBBI JGCMCDAJOGI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct NMAJBELNJGK
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public struct MMCELFPKCLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public List<HEAHFCDCNLA> ALILEAJLHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public List<CLMIJCBDJCL> EMAMIKGLMNP;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD410", Offset = "0x5ABE10", VA = "0x1805AD410")]
		public MMCELFPKCLG(List<HEAHFCDCNLA> ALILEAJLHOC, List<CLMIJCBDJCL> EMAMIKGLMNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class FGGDOAAHIKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public List<HEAHFCDCNLA> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FGGDOAAHIKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB0950", Offset = "0x2EAF350", VA = "0x182EB0950")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private GAMFAADDNHJ CEMCPIENNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private HDNBAJBNCBH CIBAGEDPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private KAKNEGAPNEF.LJDLBLHBPEO FJOAEMOHNAN;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private EFFFPKFCLCK MDKMCKDNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2EC08F0", Offset = "0x2EBF2F0", VA = "0x182EC08F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2EC0860", Offset = "0x2EBF260", VA = "0x182EC0860")]
	public static MMCELFPKCLG ADLAMHIBLDH(GAMFAADDNHJ CEMCPIENNAH, HDNBAJBNCBH CIBAGEDPOOH, KAKNEGAPNEF.LJDLBLHBPEO FJOAEMOHNAN)
	{
		return default(MMCELFPKCLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2EC0620", Offset = "0x2EBF020", VA = "0x182EC0620")]
	private MMCELFPKCLG ADLAMHIBLDH()
	{
		return default(MMCELFPKCLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2EC0CC0", Offset = "0x2EBF6C0", VA = "0x182EC0CC0")]
	private MMCELFPKCLG KBGBJOMIBLH(CHOOKADKDAN ECIMCDMIDOH, FCKLLFFBIPN CAOCAFFDJFH, Dictionary<int, int> POHFDJPLHHK)
	{
		return default(MMCELFPKCLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2EC0940", Offset = "0x2EBF340", VA = "0x182EC0940")]
	private GameObject[] HOJCGNMIMPE(List<HEAHFCDCNLA> ALILEAJLHOC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct KAKKECILDJC
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class JGONAGLDHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public NMAJBELNJGK.MMCELFPKCLG instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JGONAGLDHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4000", Offset = "0x2BB2A00", VA = "0x182BB4000")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private sealed class IJDMGCGCODP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IJDMGCGCODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3120", Offset = "0x2BB1B20", VA = "0x182BB3120")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7380", Offset = "0x2BB5D80", VA = "0x182BB7380")]
	public static void ADLAMHIBLDH(KHCJOIGIKIA BIENEBJDHDJ, HDNBAJBNCBH CIBAGEDPOOH, NMAJBELNJGK.MMCELFPKCLG DGLEKCAAIOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal class CFAENIIKOFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct GIPMCDCLBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public BNENILNLBIM operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5170", Offset = "0x2DF3B70", VA = "0x182DF5170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct EHGNKHJJFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1830", Offset = "0x2DF0230", VA = "0x182DF1830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct ICGMCAFAIHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private Dictionary<Guid, List<MGODOBFMFAB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF64D0", Offset = "0x2DF4ED0", VA = "0x182DF64D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct POFKOKEEGMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private Dictionary<Guid, List<MGODOBFMFAB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFAD40", Offset = "0x2DF9740", VA = "0x182DFAD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class BCFCPBHBOHH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public MGODOBFMFAB handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public BCFCPBHBOHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB7C0", Offset = "0x2DFA1C0", VA = "0x182DFB7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public BPFDGHCJFBO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public List<MGODOBFMFAB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BCFCPBHBOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5EB0", Offset = "0x2DE48B0", VA = "0x182DE5EB0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6030", Offset = "0x2DE4A30", VA = "0x182DE6030")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(MGODOBFMFAB handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5F70", Offset = "0x2DE4970", VA = "0x182DE5F70")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct BOOCKCKBFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public BPFDGHCJFBO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public List<MGODOBFMFAB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private BCFCPBHBOHH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6E60", Offset = "0x2DE5860", VA = "0x182DE6E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct JIFDGHMMALF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF81A0", Offset = "0x2DF6BA0", VA = "0x182DF81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private sealed class DHPFGJMPOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DHPFGJMPOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0B70", Offset = "0x2DEF570", VA = "0x182DF0B70")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct AMIJMEHLPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5180", Offset = "0x2DE3B80", VA = "0x182DE5180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class IIALJPBAPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IIALJPBAPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DF73A0", Offset = "0x2DF5DA0", VA = "0x182DF73A0")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct IAEIMMKKEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public CFAENIIKOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5F20", Offset = "0x2DF4920", VA = "0x182DF5F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class GLIDGCGCNGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GLIDGCGCNGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5B50", Offset = "0x2DF4550", VA = "0x182DF5B50")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private readonly FLDAJIIDCOG FENCPFKHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private HDNBAJBNCBH CIBAGEDPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private CancellationToken PKFOPLIPJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private JIHLAGDHAKL MGDBNDLGKHJ;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private KHCJOIGIKIA EJBAGIBKIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x815870", Offset = "0x814270", VA = "0x180815870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private BDMELKPFPFB MLFMKCDNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x59B970", Offset = "0x59A370", VA = "0x18059B970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
	public CFAENIIKOFF(FLDAJIIDCOG FENCPFKHOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9370", Offset = "0x2DE7D70", VA = "0x182DE9370")]
	public void POBNPLBNCEO(CancellationToken PKFOPLIPJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
	public void JOAPAPLFCLJ(HDNBAJBNCBH CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE86B0", Offset = "0x2DE70B0", VA = "0x182DE86B0")]
	[AsyncStateMachine(typeof(GIPMCDCLBPB))]
	public Task ADLAMHIBLDH(BNENILNLBIM FOMIDNMLOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE87C0", Offset = "0x2DE71C0", VA = "0x182DE87C0")]
	[AsyncStateMachine(typeof(EHGNKHJJFHC))]
	private Task ANNAJEDLMJE(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8A10", Offset = "0x2DE7410", VA = "0x182DE8A10")]
	[AsyncStateMachine(typeof(ICGMCAFAIHP))]
	private Task HDKNKMAPPPH(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8B20", Offset = "0x2DE7520", VA = "0x182DE8B20")]
	[AsyncStateMachine(typeof(POFKOKEEGMK))]
	private Task JMOOOCDDKLF(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8EA0", Offset = "0x2DE78A0", VA = "0x182DE8EA0")]
	[AsyncStateMachine(typeof(BOOCKCKBFLL))]
	private Task KMJJGDOFKDL(Guid CIIMCKAGDBO, List<MGODOBFMFAB> LOOGGEFCMPM, BPFDGHCJFBO EKLPHKAKMDB, CancellationToken LBAGELALLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8C30", Offset = "0x2DE7630", VA = "0x182DE8C30")]
	[AsyncStateMachine(typeof(JIFDGHMMALF))]
	private Task JNJEOHLBNBD(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2DE88E0", Offset = "0x2DE72E0", VA = "0x182DE88E0")]
	[AsyncStateMachine(typeof(AMIJMEHLPEA))]
	private Task FMANANKFLKG(Guid IJPKEPJAPPO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9240", Offset = "0x2DE7C40", VA = "0x182DE9240")]
	[AsyncStateMachine(typeof(IAEIMMKKEAC))]
	private Task OHGFJAAMCCG(Guid IJPKEPJAPPO, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8D50", Offset = "0x2DE7750", VA = "0x182DE8D50")]
	private void KKNBHJHLAAH(Guid IJPKEPJAPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8FE0", Offset = "0x2DE79E0", VA = "0x182DE8FE0")]
	private void LLOFFOMLEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2DE90D0", Offset = "0x2DE7AD0", VA = "0x182DE90D0")]
	[CompilerGenerated]
	private object OAIFBPDLPKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public struct DLFFBEKDBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public CHOOKADKDAN ELOFFBABMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public List<string> FMOFAFKLKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public Dictionary<long, int> CGBMJMKGKID;
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class KACAMBEBNDD : JDDLJNBJPEB
{
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class PODDJLIOBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public NJHEDNCKIJM autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public PODDJLIOBBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class IPNIFBCKGJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public PODDJLIOBBL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IPNIFBCKGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BB35B0", Offset = "0x2BB1FB0", VA = "0x182BB35B0")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class GLCAFMEHCMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public PODDJLIOBBL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GLCAFMEHCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC2B0", Offset = "0x2BAACB0", VA = "0x182BAC2B0")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class NHMJHFMOPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public NJHEDNCKIJM autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NHMJHFMOPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB010", Offset = "0x2BB9A10", VA = "0x182BBB010")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class DOCILNCEPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DOCILNCEPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8FD0", Offset = "0x2BA79D0", VA = "0x182BA8FD0")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class NHNOHAIBFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public FileSystemInfo file;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NHNOHAIBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB090", Offset = "0x2BB9A90", VA = "0x182BBB090")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class GFENMKCBNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GFENMKCBNLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC120", Offset = "0x2BAAB20", VA = "0x182BAC120")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	private const string IFPLCMMAFOM = "V2";

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private const int BLPDOHNBFAD = 5;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private const string KAHBGHMCCNM = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private const string HIOGAMLOCGE = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private const int HJAICEPAJKI = 32;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3DE0", Offset = "0x2BB27E0", VA = "0x182BB3DE0")]
	public KACAMBEBNDD(FLDAJIIDCOG FENCPFKHOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5EB0", Offset = "0x2BB48B0", VA = "0x182BB5EB0")]
	public bool EMKEIDADBHL(long BMNHGDIENAL, DLFFBEKDBKJ JGNEEDFLDJO, NJHEDNCKIJM APIOJDDPFOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5A70", Offset = "0x2BB4470", VA = "0x182BB5A70")]
	public static bool COKPDOMDHEJ(long BMNHGDIENAL, NJHEDNCKIJM APIOJDDPFOL, out FileInfo LKDBDJLOJPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB68E0", Offset = "0x2BB52E0", VA = "0x182BB68E0")]
	public bool KJLFAEOPDBN(long BMNHGDIENAL, NJHEDNCKIJM APIOJDDPFOL, out DLFFBEKDBKJ JGNEEDFLDJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6320", Offset = "0x2BB4D20", VA = "0x182BB6320")]
	private bool HIDNHGNAEKH(FileInfo LKDBDJLOJPJ, out byte[] GFBFBDMBBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6800", Offset = "0x2BB5200", VA = "0x182BB6800")]
	private static FileInfo IDKNGGAGKOB(long BMNHGDIENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB72B0", Offset = "0x2BB5CB0", VA = "0x182BB72B0")]
	private static FileInfo MOIHMJLKAFG(long BMNHGDIENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5850", Offset = "0x2BB4250", VA = "0x182BB5850")]
	private static DirectoryInfo AFBNLIHPKMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5B30", Offset = "0x2BB4530", VA = "0x182BB5B30")]
	private void EHJBKJAAKML(FileInfo FODKGHIDLGD, CHOOKADKDAN HEOCEKKLPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6DC0", Offset = "0x2BB57C0", VA = "0x182BB6DC0")]
	private void LODBCAEEENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB58C0", Offset = "0x2BB42C0", VA = "0x182BB58C0")]
	public static void AFKMBADMBCN(long BMNHGDIENAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6D50", Offset = "0x2BB5750", VA = "0x182BB6D50")]
	public static bool LELFIJGPFLF(long BMNHGDIENAL, out DateTime CJKCHPDBFLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal class LPENCIOEGGE : JDDLJNBJPEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct ANOLJOAEMOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<DLFFBEKDBKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public LPENCIOEGGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public MNMBCBCHLOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x2EAEF70", Offset = "0x2EAD970", VA = "0x182EAEF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x2EAF470", Offset = "0x2EADE70", VA = "0x182EAF470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class GLAICKCBHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public MNMBCBCHLOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GLAICKCBHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2EB22C0", Offset = "0x2EB0CC0", VA = "0x182EB22C0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class EOPMPMFGEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public GLAICKCBHNA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public EOPMPMFGEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x2EB0470", Offset = "0x2EAEE70", VA = "0x182EB0470")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class BPEKEPNBLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public GLAICKCBHNA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BPEKEPNBLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2EAFB30", Offset = "0x2EAE530", VA = "0x182EAFB30")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct GJDCFBPNKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public MNMBCBCHLOJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public LPENCIOEGGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private EOPMPMFGEIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private GCIFPGJFDDN.JGMJBALALFG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1D50", Offset = "0x2EB0750", VA = "0x182EB1D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private readonly PCFOFLNNLFB AMFGPAKCLFB;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private static readonly TimeSpan IHIGGJBKMOA;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB610", Offset = "0x2EBA010", VA = "0x182EBB610")]
	public LPENCIOEGGE(FLDAJIIDCOG FENCPFKHOGO, [Optional] PCFOFLNNLFB? AMFGPAKCLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAFF0", Offset = "0x2EB99F0", VA = "0x182EBAFF0")]
	[AsyncStateMachine(typeof(ANOLJOAEMOP))]
	public Task<DLFFBEKDBKJ> NGLMBPACFDH(long BMNHGDIENAL, MNMBCBCHLOJ NJMDDMONPLI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAEA0", Offset = "0x2EB98A0", VA = "0x182EBAEA0")]
	[AsyncStateMachine(typeof(GJDCFBPNKNI))]
	private Task NCLEGCDNBEP(MNMBCBCHLOJ NJMDDMONPLI, IEnumerable<PersistenceView> BJAKNFDMBDH, StringBuilder DFGLFNMHNJP, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB130", Offset = "0x2EB9B30", VA = "0x182EBB130")]
	private DLFFBEKDBKJ NGMMKLPDAMJ(long BMNHGDIENAL, MNMBCBCHLOJ NJMDDMONPLI, IEnumerable<PersistenceView> BJAKNFDMBDH, StringBuilder DFGLFNMHNJP)
	{
		return default(DLFFBEKDBKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA8D0", Offset = "0x2EB92D0", VA = "0x182EBA8D0")]
	private CHOOKADKDAN FCMFGNEKCBE(long BMNHGDIENAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA6D0", Offset = "0x2EB90D0", VA = "0x182EBA6D0")]
	private void AGGBKKDNPBO(CHOOKADKDAN IKAHABFIMGO, StringBuilder DFGLFNMHNJP, IEnumerable<PersistenceView> BJAKNFDMBDH, in AOHCNBFBMEE ALGFBOLCGGP, ref JMNPLECCMGL ONALLFHBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAA10", Offset = "0x2EB9410", VA = "0x182EBAA10")]
	private void IAHDJLEFFAH(CHOOKADKDAN IKAHABFIMGO, StringBuilder DFGLFNMHNJP, PersistenceView DBBJEPNCCKL, ref JMNPLECCMGL ONALLFHBAPK, in AOHCNBFBMEE ALGFBOLCGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
internal class HFOHACGHJPI : JDDLJNBJPEB
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class DDDPEDONLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public string roomMetadataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public string roomDataFilename;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DDDPEDONLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BA87C0", Offset = "0x2BA71C0", VA = "0x182BA87C0")]
		internal object <UploadRoomDataBlob>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8840", Offset = "0x2BA7240", VA = "0x182BA8840")]
		internal object <UploadRoomDataBlob>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8880", Offset = "0x2BA7280", VA = "0x182BA8880")]
		internal object <UploadRoomDataBlob>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA88F0", Offset = "0x2BA72F0", VA = "0x182BA88F0")]
		internal object <UploadRoomDataBlob>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct FAJFHNBJIIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder<CKEPHPBIHBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public DLFFBEKDBKJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public HFOHACGHJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private DDDPEDONLJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter<CKEPHPBIHBC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9C20", Offset = "0x2BA8620", VA = "0x182BA9C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA700", Offset = "0x2BA9100", VA = "0x182BAA700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class GKIECBKBNHE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000149")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public GKIECBKBNHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			private IBNMHBIHLHI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			private TaskAwaiter<CKEPHPBIHBC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private TaskAwaiter<IBNMHBIHLHI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD020", Offset = "0x2BBBA20", VA = "0x182BBD020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BBD650", Offset = "0x2BBC050", VA = "0x182BBD650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public HFOHACGHJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public DLFFBEKDBKJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GKIECBKBNHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC180", Offset = "0x2BAAB80", VA = "0x182BAC180")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<IBNMHBIHLHI> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct DPENCNDACLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public AsyncTaskMethodBuilder<IBNMHBIHLHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public HFOHACGHJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public DLFFBEKDBKJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter<IBNMHBIHLHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9010", Offset = "0x2BA7A10", VA = "0x182BA9010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9230", Offset = "0x2BA7C30", VA = "0x182BA9230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private const float PNHONKDLNBP = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly NGOICDDIJMO IABNOHPMMNP;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GAMFAADDNHJ KDJICPHBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF130", Offset = "0x2BADB30", VA = "0x182BAF130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF410", Offset = "0x2BADE10", VA = "0x182BAF410")]
	public HFOHACGHJPI(FLDAJIIDCOG FENCPFKHOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF2C0", Offset = "0x2BADCC0", VA = "0x182BAF2C0")]
	[AsyncStateMachine(typeof(FAJFHNBJIIC))]
	public Task<CKEPHPBIHBC> LFIDMNCKKIN(int HLHIANOGMJF, DLFFBEKDBKJ JGNEEDFLDJO, long GJMALLKLAFM, long JIKIOPCFGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BAF160", Offset = "0x2BADB60", VA = "0x182BAF160")]
	[AsyncStateMachine(typeof(DPENCNDACLP))]
	public Task<IBNMHBIHLHI> DPGGNNENABJ(int HLHIANOGMJF, DLFFBEKDBKJ JGNEEDFLDJO, long GJMALLKLAFM, long JIKIOPCFGON, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public class LEGMEMBDHLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private readonly Guid BJDJCGIBLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private readonly MIPGNLMFNJL ILPIAGJEDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private JKPNDOLIOLF KJNOHPBJPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private int? JHHOMAHAFIH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Guid ILMFDDGNHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6311E0", Offset = "0x62FBE0", VA = "0x1806311E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8D70", Offset = "0x2EB7770", VA = "0x182EB8D70")]
	public LEGMEMBDHLK(MIPGNLMFNJL ILPIAGJEDOB, [Optional] Guid? BJDJCGIBLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xAD76A0", Offset = "0xAD60A0", VA = "0x180AD76A0")]
	public LEGMEMBDHLK ACODLCHNJBC(JKPNDOLIOLF KJNOHPBJPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8CA0", Offset = "0x2EB76A0", VA = "0x182EB8CA0")]
	public IBNMHBIHLHI JEMMJIEOPPO(out Guid LCIIFMPNHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8BB0", Offset = "0x2EB75B0", VA = "0x182EB8BB0")]
	public LEGMEMBDHLK GMIILMLLBCJ(AOLOIKMEGKC LCGDILHCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public static class EGJFOAFLMPA
{
	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DF17F0", Offset = "0x2DF01F0", VA = "0x182DF17F0")]
	public static FOIOFCKPMAJ NMMAECJIOBG(this EBCAKELGLGO BIDDBIBMJAJ)
	{
		return default(FOIOFCKPMAJ);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public CLFFODICHGN ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public CLFFODICHGN HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private static CLFFODICHGN[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private Dictionary<CLFFODICHGN, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x4E6DE00", Offset = "0x4E6C800", VA = "0x184E6DE00")]
		public bool JLPLJAMCCMI(CLFFODICHGN BBPHPCBFNDN, out ResultConfig DPAHJCPCBGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x4E6DD10", Offset = "0x4E6C710", VA = "0x184E6DD10")]
		public ResultConfig BFFLOLOKLNA(CLFFODICHGN DJKMPMKHOMN, [Optional] HashSet<CLFFODICHGN> CCHEKCJGOAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x4E6E320", Offset = "0x4E6CD20", VA = "0x184E6E320", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x4E6DE70", Offset = "0x4E6C870", VA = "0x184E6DE70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6447C0", Offset = "0x6431C0", VA = "0x1806447C0")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000150")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2EB95B0", Offset = "0x2EB7FB0", VA = "0x182EB95B0")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB9280", Offset = "0x2EB7C80", VA = "0x182EB9280")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000534")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
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
