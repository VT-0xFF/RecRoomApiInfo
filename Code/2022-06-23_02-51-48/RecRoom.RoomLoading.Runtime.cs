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
public class IALNBJPADFD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3670", Offset = "0x1DE2870", VA = "0x181DE3670")]
	public IALNBJPADFD(string MPHBMEGMJKJ, Exception BBKKANKNBCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface LGJFLAHKIKA : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NJDKNOHEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task EJELKOGOKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOPIFCKEFGB(Task ALCHLJLEFAL, string JAPOFGMKEIC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface PFGFMBAMNLF : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMMHCIJFCCJ> OKLOBCAOJPF(LLILGLIBBAK BCLLMCFINDB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CAPKJAFFALH(CancellationToken MNPKHBAPNDC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface DANPILJGIPC : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ENEGFJHMAMA HJGIHOLFKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGNGDBPBJMP();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHKENHIBBLK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LHPMHGNAPIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface PNJJINBPFKN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TimeSpan FBOGDIGMKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan DCHLLGKJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BJBNCCFDBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JJADIGOEPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JFBDICNOFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CIELIOKLJEI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EBNFCAKGABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long GJNLMJMGMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long PCDLGIEJLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly CIELIOKLJEI DEJAEMDNDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception PJEBPNJECDJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1A0D730", Offset = "0x1A0C930", VA = "0x181A0D730")]
	public EBNFCAKGABN(long GJNLMJMGMBB, long PCDLGIEJLMB, CIELIOKLJEI DEJAEMDNDIC, [CanBeNull] Exception PJEBPNJECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1A0D6E0", Offset = "0x1A0C8E0", VA = "0x181A0D6E0")]
	public static EBNFCAKGABN ACECFAPNHDG(EGAEEHPFEGO PBBBBFDJNKA, CIELIOKLJEI DEJAEMDNDIC, [Optional] Exception PJEBPNJECDJ)
	{
		return default(EBNFCAKGABN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void DPBPJCFMPPO(EBNFCAKGABN LMOJFFGMOAP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface IFPMEFKCGIC : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DPBPJCFMPPO CBPMCLIEOGJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DPBPJCFMPPO EJNACAPKAIN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event DPBPJCFMPPO HKAIMFOOPPK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOAOFENMOLK(EBNFCAKGABN LMOJFFGMOAP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FNMFJACIKJF(EBNFCAKGABN LMOJFFGMOAP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EFGJNLBCILI(EBNFCAKGABN LMOJFFGMOAP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface JBFDOGLEOPK : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PDLPPPONBGE();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJKDDEJGMBK();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPJKCILOBJL();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate Task ONIMKHMBFLI(FJGNCHMKJML PKMAOEIDLKI, CancellationToken OFCAAIDMNPE);
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal interface CAFIPILONKF : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AFAHFKJLLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJHHEDNNDGH(ONIMKHMBFLI KDOOIMIGCCF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface IGMNLNALIOE : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	TaskStatus OCIFLGCLABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FJDGBMEIEHF(EGAEEHPFEGO BEFEGPNCEAC, CancellationToken NDAAKCECFIE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class OGFKJHDFILM
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6BC0", Offset = "0x1FA5DC0", VA = "0x181FA6BC0")]
	public static bool NKCAOEGLCCD(this IGMNLNALIOE FHNEGDIHALI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface JDEEGONKAHJ : PDCFNBGAKLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CancellationToken MKDBMDLBJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FBJAIGGBNJC NBLPCGFOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	ODCOJLILBCP OGHOJDLAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OKCHODFFIAN BHEJJNOKBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BEKLGDOIHFN ENDNNNFFHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	KKKPMHOCHJD IKAPKPMFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EECAHPCGHOC NHHFOPPACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LGJFLAHKIKA ICHOOJBIBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PFGFMBAMNLF DCLLMPPDKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IFPMEFKCGIC PICNIJLHLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	JBFDOGLEOPK DPAOLMAMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IGMNLNALIOE PBCANLGNGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CAFIPILONKF FBACKDFCBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	EONPACEDPDO NCECBDBDOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HAEFNIDEAIG LCOHJDHDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BHDNNJLHBFH NELBCNPDGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HBKLDEGDBCN AHNAAPMNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IEOMEDNPJOP NEDIMEJLMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	INGOFBPGNCL HLAHAFMJFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	DOFMGKHHAMO LJEGDIJFPME
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	JMFJFDNGGLF HPLIHMFCFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DECOINHLINO LJELAEKBPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	PEJONDGKMKB BEFFOFNKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OJHAKCBHDFG IDNBMPDONFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DANPILJGIPC CFCDOBLAINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	PNJJINBPFKN HCKJAIMLHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface EONPACEDPDO : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IKMOMHJCLBA INLOBDHPAIC(Guid GCECPKLIDBO);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MNIDDOJOCKH(Guid GCECPKLIDBO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBPCKGBJECO(Guid GCECPKLIDBO, Task LFJPKOKOGCL);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDGNEALCEDN(Guid GCECPKLIDBO, BMMHCIJFCCJ FGBPMHKHCLF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IPJKCILOBJL(Guid GCECPKLIDBO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(BMMHCIJFCCJ, Task)> PCNJHPACGHC(Guid GCECPKLIDBO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface HAEFNIDEAIG : LHPMHGNAPIB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface BHDNNJLHBFH : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEKMPICMOEK(KHKCMDHCAIC MPHBMEGMJKJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFAMBJNGKMP(KHKCMDHCAIC MPHBMEGMJKJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BPPMEJGJJLO> LDNOMPDAMIC(CancellationToken AHJMCEGBFMB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate BMMHCIJFCCJ BKCDLOAIFNK(BFJNMOMPEEB HDDBJKFKLBM, BPPMEJGJJLO JJMDEGEECOP);
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface HBKLDEGDBCN : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IKMOMHJCLBA JPLDMHNCLCM(KEGADJFLAHK JGDFGLBNGMB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHLAHAALDLB(Guid GCECPKLIDBO, Task LFJPKOKOGCL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface IEOMEDNPJOP : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMMHCIJFCCJ> NEDIMEJLMLF(BFJNMOMPEEB IOFAGLPECPA, BPPMEJGJJLO GMOACGPGCIA, [Optional] HFBMBACFDEJ PHILBAIHAAP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface INGOFBPGNCL : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<POLMFGONIBA> MMAGEJNNBHG(FGDOGDEIJDO LILIKHLPHEJ, EGAEEHPFEGO BEFEGPNCEAC, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POLMFGONIBA BJJPDEKCMHH(EGAEEHPFEGO BEFEGPNCEAC, HFBMBACFDEJ EIJAJDEMGEH, long OCLLLDFCOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface JMFJFDNGGLF : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMMHCIJFCCJ JDHIHHOMBNE(BFJNMOMPEEB HDDBJKFKLBM);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IEGLCEPENII(string ONIMCFGGJHN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface DOFMGKHHAMO : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KHKCMDHCAIC> BOPDHGHGBLH(KHKCMDHCAIC JENMNBIOPFE, HPIMPDEBPJM CFEILPEPHEO, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KHKCMDHCAIC> LPAPHICJGAE(CancellationToken MNPKHBAPNDC, HPIMPDEBPJM CFEILPEPHEO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FBACHMNJFOB AIGDDDEFIFG(BOGCNIBCKJK GLKLKKOKPAE, FGDOGDEIJDO LILIKHLPHEJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FBACHMNJFOB DPPEGJMKBDM(BOGCNIBCKJK GLKLKKOKPAE, FGDOGDEIJDO LILIKHLPHEJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface DECOINHLINO : LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMMHCIJFCCJ CENNIIFFOGJ(BFJNMOMPEEB HDDBJKFKLBM, BPPMEJGJJLO JJMDEGEECOP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMMHCIJFCCJ FIACIMILLHI(BFJNMOMPEEB GGLCGPAJMPC);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMMHCIJFCCJ DBKICJDNGDF(BFJNMOMPEEB GGLCGPAJMPC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PEJONDGKMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGHDAHEMFPM(BOHMICDIIGP EOHGPLNHENI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLJGNOHLAGK(BOHMICDIIGP EOHGPLNHENI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBNCPDLJEKF(BOHMICDIIGP EOHGPLNHENI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPLMLHPBOPA(BOHMICDIIGP EOHGPLNHENI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BOHMICDIIGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly EGAEEHPFEGO MFBMFEKEAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> PHDFAIJPLOF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::MKPPAJLLJAE<string> JGCOGIHHGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B50", Offset = "0x5D3D50", VA = "0x1805D4B50")]
	public BOHMICDIIGP(EGAEEHPFEGO DFPGMDHENON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A08A80", Offset = "0x1A07C80", VA = "0x181A08A80")]
	public BOHMICDIIGP BHPGOMJFGOM(string DHDAEDILENC, string PNLMJAPAHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1A08B60", Offset = "0x1A07D60", VA = "0x181A08B60")]
	public bool DLLHPGFEJNI(out IEnumerable<KeyValuePair<string, string>> HNPIDBNBHPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1A08B40", Offset = "0x1A07D40", VA = "0x181A08B40")]
	public BOHMICDIIGP CMDECHIKAPA(global::MKPPAJLLJAE<string> IDJNPLHMMHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PDCFNBGAKLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NKCAOEGLCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FLCDBOHFKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DPBPJCFMPPO CBPMCLIEOGJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DPBPJCFMPPO EJNACAPKAIN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DPBPJCFMPPO HKAIMFOOPPK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJKDDEJGMBK();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<BMMHCIJFCCJ> MAHOOMGCIJB([Optional][CanBeNull] HFBMBACFDEJ MOIHJBBBEHF);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<BMMHCIJFCCJ> PEGCCLNDDAM(BFJNMOMPEEB NMLIOADCGIL);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<BMMHCIJFCCJ> CKHLJLGGDLE(int DIJKJKNKFBG);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task IEGLCEPENII(string ONIMCFGGJHN);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<BMMHCIJFCCJ> OKLOBCAOJPF(LLILGLIBBAK BCLLMCFINDB = LLILGLIBBAK.Incremental);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task CAPKJAFFALH(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OMNEDABLIJA(long OCLLLDFCOAB);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DMHJLBJHIIE(long OCLLLDFCOAB, out DateTime JBINOKMLBIN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OCJFFCBIIPG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int ABFHCHINMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool BEHFFJAPGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool HCKCEMNPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool OFKLODPKGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool MPONAOLJGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool KNJAOIKBDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BFJNMOMPEEB BJADHGCEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIIBOIFOEML(FBJAIGGBNJC CDGPJIKOKFG);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HJKKELFBEAJ(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OMCPOJMCAFK(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EMPLJBHACBI(HBGFACPFNKO PFAHEGOAJJP, [Optional] CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HMLEEMHPIEO(float PFDDIJEPIIF);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<NAGFPELOHOE> OEGKFJNKMEI();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable OBGHKOAKACB(object JOBPOOEPEBN, NAGFPELOHOE NOCGOILLINF);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KHPEBJHIOKI();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LANHDAOGFLE NFNHAHPNHKB();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IGCFBIGEAOJ(int EJKNMBALACI);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task DOFOLAOLEMD();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LGHJAOKCMNL();

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NBKKNIHMCOP();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task HFFEPCIJGEK(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task JFLKNJCOICB(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> KNNGMLMADJD(DateTime BEBENMECFHB, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> BNBHGNLNCHI(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EHDLGNIIKCH();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DCCPECAHECJ CEKGGJHLEGH(DCCFLOIJBLH LBADHINKFIE, ANCBHLCGJKP LEFGODBBIGA, IEnumerable<PersistenceView> AAJKCAIKAFD, ref KFDNJKBEGGN BJILEKCJFKG);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FFJKMFDCNNG(MKKGOFGHCNA NFBCEPEJLHF, in DCCPECAHECJ CGBOPPEDMPC);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BAOODKEGLHN(ANCBHLCGJKP FMNNHLIFLHO, bool IPGFANIJAGE);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NADAGCALJGD(long FMLOJIDJGBJ, long PCDLGIEJLMB, HFBMBACFDEJ GFOIMLAOIKA, CDEHMDAHGPA MANBJEHGFJA);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KABLPNOHEHI(long FMLOJIDJGBJ, long PCDLGIEJLMB);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HBBBCMKFKCK(PersistenceView LCFPNCHGBPD);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FKDHONHHDML(PersistenceView KHMMEKDHDLG);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool JEMOIHPOINI(MKKGOFGHCNA NFBCEPEJLHF, PGGGEMCDEKK EMJJCPBBPDM, Dictionary<int, int> GFIFDHDPJHE, out OJDJLJMCGJK JAFEBANDEAO);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HLGEDANCFFC();

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void PMBFDKEEGOD();

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable GFDMDADKDFP();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Dictionary<int, int> BCJKFPOGALP(ANCBHLCGJKP FMNNHLIFLHO, PGGGEMCDEKK EMJJCPBBPDM);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> BBFJJILJBIN(ODCOJLILBCP MPNHFLDDJEL, CancellationToken MNPKHBAPNDC, FGDOGDEIJDO LILIKHLPHEJ);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void COPFPJMCNHA(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<HFBMBACFDEJ> AIIADJHLHMG(long FMLOJIDJGBJ, long PCDLGIEJLMB, string LJIBKMGMIAN, string MCNJAGHPAMF, Dictionary<long, int> EIINFCINMHI, int KGBPOBGNANK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<HFBMBACFDEJ> GPBBBNDLJCG(long FMLOJIDJGBJ, bool KIBBKINCDFD, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool KGPDOHEMDCN();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool AHPCJLFLNFN();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "44")]
	GameObject[] NPFDHDGLLIL(KELACFFHONA[] OFCCNELLAEL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void ONOONLANKDO(List<GameObject> KOOKMGOJFAA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float JOIIDFFPGJE();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task IAIKAAHCAMP(string KLKHHNNELKD, LoadSceneMode MMBFHLAGBCA, bool DJBGPPONGOA, FGDOGDEIJDO IDJNPLHMMHL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void HAOKOLCIMEN(EGAEEHPFEGO BMDCNGNJHNB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void EBNFALFEPPA(string GMOACGPGCIA, BFJNMOMPEEB IOFAGLPECPA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task CEAIAKOHOMD(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task EMDILCBKIHM(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void JFJJGCCNKAP();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "53")]
	IDisposable DKOONJPBOPN();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "54")]
	MPMHOAALHNM MOBBOHCOGNL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MPMHOAALHNM
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ABICOFHKKJJ(CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BIPBPOPOCOM(CancellationToken MNPKHBAPNDC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct DCCPECAHECJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> DJJJBOBOMNE;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HEPLBMFCPAI
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EGAEEHPFEGO AOCFLECKHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HFBMBACFDEJ LAFLJFBDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	ALKBFOJPDKK FIGIMEGMMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool PFGLEHPEAII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool MBHDDPMHPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int ABFHCHINMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BOAAMFIIAAJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<int> BNCANFNEBNB;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OLCDLOBENMH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LFJDKBFJIMD> EKMFGKDGMGH();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PBJECNOLBLG();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EGAEEHPFEGO HFAAJHFEDGF();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PIPLJGEOFBE NLJGFMPEFHI();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GFDDPMOCDPD(long PGJGIMLOLEN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OJHAKCBHDFG
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEGFHPDECGK(out IEnumerable<int> BIABOBLFOOH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNGIOCBAEAG(MNFFEBPEFEE OFCAAIDMNPE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJLDNCOPGAI(MNFFEBPEFEE OFCAAIDMNPE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CIIPHOEIEFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MCHEGEJHJFD(BMMHCIJFCCJ FBJOEPDKJAM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class FIHEHJMMBIN : PDCFNBGAKLB, IDisposable, JDEEGONKAHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct CMEMFLDJPEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<BMMHCIJFCCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FIHEHJMMBIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public LLILGLIBBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<BMMHCIJFCCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8830", Offset = "0x1DD7A30", VA = "0x181DD8830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8A10", Offset = "0x1DD7C10", VA = "0x181DD8A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DOKCNAAIEOC : IEnumerable<LHPMHGNAPIB>, IEnumerable, IEnumerator<LHPMHGNAPIB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LHPMHGNAPIB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FIHEHJMMBIN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private LHPMHGNAPIB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public DOKCNAAIEOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9310", Offset = "0x1DD8510", VA = "0x181DD9310", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9750", Offset = "0x1DD8950", VA = "0x181DD9750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD96B0", Offset = "0x1DD88B0", VA = "0x181DD96B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LHPMHGNAPIB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD96B0", Offset = "0x1DD88B0", VA = "0x181DD96B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource OALPHONCBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FBJAIGGBNJC CDGPJIKOKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool NELKGEDACJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HHLMEHIBNFH IICMDGLGFPC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ODCOJLILBCP OGHOJDLAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x59F950", Offset = "0x59EB50", VA = "0x18059F950", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEC0", Offset = "0x5CC0C0", VA = "0x1805CCEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OKCHODFFIAN BHEJJNOKBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x574E60", Offset = "0x574060", VA = "0x180574E60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x59EC90", Offset = "0x59DE90", VA = "0x18059EC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x574E80", Offset = "0x574080", VA = "0x180574E80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x59ED50", Offset = "0x59DF50", VA = "0x18059ED50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public BEKLGDOIHFN ENDNNNFFHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x576EC0", Offset = "0x5760C0", VA = "0x180576EC0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public KKKPMHOCHJD IKAPKPMFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x59EF10", Offset = "0x59E110", VA = "0x18059EF10", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x59EE20", Offset = "0x59E020", VA = "0x18059EE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public EECAHPCGHOC NHHFOPPACGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x59EF00", Offset = "0x59E100", VA = "0x18059EF00", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x59EF20", Offset = "0x59E120", VA = "0x18059EF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LGJFLAHKIKA ICHOOJBIBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB20", Offset = "0x5CBD20", VA = "0x1805CCB20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x619BB0", Offset = "0x618DB0", VA = "0x180619BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PFGFMBAMNLF DCLLMPPDKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CCAB0", Offset = "0x5CBCB0", VA = "0x1805CCAB0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDA0", Offset = "0x5CAFA0", VA = "0x1805CBDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IFPMEFKCGIC PICNIJLHLML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x585A50", Offset = "0x584C50", VA = "0x180585A50", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5A0260", Offset = "0x59F460", VA = "0x1805A0260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JBFDOGLEOPK DPAOLMAMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D7E10", Offset = "0x5D7010", VA = "0x1805D7E10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61AAC0", Offset = "0x619CC0", VA = "0x18061AAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IGMNLNALIOE PBCANLGNGDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x59F840", Offset = "0x59EA40", VA = "0x18059F840", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x59F850", Offset = "0x59EA50", VA = "0x18059F850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CAFIPILONKF FBACKDFCBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x585B90", Offset = "0x584D90", VA = "0x180585B90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB80", Offset = "0x5CBD80", VA = "0x1805CCB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EONPACEDPDO NCECBDBDOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x585B60", Offset = "0x584D60", VA = "0x180585B60", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61E090", Offset = "0x61D290", VA = "0x18061E090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HAEFNIDEAIG LCOHJDHDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x585B70", Offset = "0x584D70", VA = "0x180585B70", Slot = "37")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61D990", Offset = "0x61CB90", VA = "0x18061D990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public BHDNNJLHBFH NELBCNPDGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FF0", Offset = "0x5E01F0", VA = "0x1805E0FF0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5ACBD0", Offset = "0x5ABDD0", VA = "0x1805ACBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HBKLDEGDBCN AHNAAPMNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61DEE0", Offset = "0x61D0E0", VA = "0x18061DEE0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FE0", Offset = "0x5E01E0", VA = "0x1805E0FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEOMEDNPJOP NEDIMEJLMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61F280", Offset = "0x61E480", VA = "0x18061F280", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61EFD0", Offset = "0x61E1D0", VA = "0x18061EFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public INGOFBPGNCL HLAHAFMJFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61F1A0", Offset = "0x61E3A0", VA = "0x18061F1A0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61EFB0", Offset = "0x61E1B0", VA = "0x18061EFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public DOFMGKHHAMO LJEGDIJFPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x686AB0", Offset = "0x685CB0", VA = "0x180686AB0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ACBE0", Offset = "0x5ABDE0", VA = "0x1805ACBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JMFJFDNGGLF HPLIHMFCFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59CAC0", Offset = "0x59BCC0", VA = "0x18059CAC0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x61D980", Offset = "0x61CB80", VA = "0x18061D980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DECOINHLINO LJELAEKBPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61F190", Offset = "0x61E390", VA = "0x18061F190", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61F290", Offset = "0x61E490", VA = "0x18061F290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PEJONDGKMKB BEFFOFNKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7180", Offset = "0x6A6380", VA = "0x1806A7180", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xE76F20", Offset = "0xE76120", VA = "0x180E76F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OJHAKCBHDFG IDNBMPDONFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A71A0", Offset = "0x6A63A0", VA = "0x1806A71A0", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xF194B0", Offset = "0xF186B0", VA = "0x180F194B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DANPILJGIPC CFCDOBLAINA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A7190", Offset = "0x6A6390", VA = "0x1806A7190", Slot = "47")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD480", Offset = "0x9DC680", VA = "0x1809DD480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public PNJJINBPFKN HCKJAIMLHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FF0", Offset = "0x6A61F0", VA = "0x1806A6FF0", Slot = "48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCB15D0", Offset = "0xCB07D0", VA = "0x180CB15D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private bool CKPLFHGOIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC620", Offset = "0x1DDB820", VA = "0x181DDC620", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool DCCHHPIPGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC290", Offset = "0x1DDB490", VA = "0x181DDC290", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private CancellationToken GECFLNEKOHE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC6F0", Offset = "0x1DDB8F0", VA = "0x181DDC6F0", Slot = "22")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private FBJAIGGBNJC OILAOKGAPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	private event DPBPJCFMPPO FDNLLMFJEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC430", Offset = "0x1DDB630", VA = "0x181DDC430", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC710", Offset = "0x1DDB910", VA = "0x181DDC710", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	private event DPBPJCFMPPO OHCDADCAKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBFA0", Offset = "0x1DDB1A0", VA = "0x181DDBFA0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC4F0", Offset = "0x1DDB6F0", VA = "0x181DDC4F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event DPBPJCFMPPO GJBBLMCFEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC490", Offset = "0x1DDB690", VA = "0x181DDC490", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBED0", Offset = "0x1DDB0D0", VA = "0x181DDBED0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC8A0", Offset = "0x1DDBAA0", VA = "0x181DDC8A0")]
	[Preserve]
	internal FIHEHJMMBIN([AFDDHPBBNKH(null)] FBJAIGGBNJC CDGPJIKOKFG, [AFDDHPBBNKH(null)] ODCOJLILBCP MPNHFLDDJEL, [AFDDHPBBNKH(null)] OKCHODFFIAN DHKDKMAFOPC, [AFDDHPBBNKH(null)] OCJFFCBIIPG FJHGBCNEILF, [AFDDHPBBNKH(null)] BEKLGDOIHFN JDAAPLAKLHN, [AFDDHPBBNKH(null)] KKKPMHOCHJD JHNAGAHPCBK, [AFDDHPBBNKH(null)] EECAHPCGHOC GMEHMFPLCIE, [AFDDHPBBNKH(null)] LGJFLAHKIKA GKLCABJKADM, [AFDDHPBBNKH(null)] PFGFMBAMNLF HNHNCGBLEBI, [AFDDHPBBNKH(null)] IFPMEFKCGIC EMMBHGFLIDO, [AFDDHPBBNKH(null)] JBFDOGLEOPK POFLGKDPGAG, [AFDDHPBBNKH(null)] IGMNLNALIOE FHNEGDIHALI, [AFDDHPBBNKH(null)] CAFIPILONKF HMEDAELNPPK, [AFDDHPBBNKH(null)] EONPACEDPDO HILKPFJAEJI, [AFDDHPBBNKH(null)] HAEFNIDEAIG OMLLNDCILPM, [AFDDHPBBNKH(null)] BHDNNJLHBFH HIFPMJIHLDL, [AFDDHPBBNKH(null)] HBKLDEGDBCN KDOPGCFLDNI, [AFDDHPBBNKH(null)] IEOMEDNPJOP PNJJLICKOFE, [AFDDHPBBNKH(null)] INGOFBPGNCL NEJNONMJLGP, [AFDDHPBBNKH(null)] JMFJFDNGGLF OCMHMEOCMLF, [AFDDHPBBNKH(null)] DOFMGKHHAMO BAAKHGCFBNO, [AFDDHPBBNKH(null)] DECOINHLINO OEAJNNKGCAG, [AFDDHPBBNKH(null)] PEJONDGKMKB NFENMKBJGDG, [AFDDHPBBNKH(null)] OJHAKCBHDFG MILKDICFFEN, [AFDDHPBBNKH(null)] PNJJINBPFKN JCGHEHOIPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC360", Offset = "0x1DDB560", VA = "0x181DDC360")]
	private void GDDEOJNJOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC0C0", Offset = "0x1DDB2C0", VA = "0x181DDC0C0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBF50", Offset = "0x1DDB150", VA = "0x181DDBF50", Slot = "12")]
	private void DAODCNKBOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC5C0", Offset = "0x1DDB7C0", VA = "0x181DDC5C0", Slot = "18")]
	private Task IDNGGPDEEIJ(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC770", Offset = "0x1DDB970", VA = "0x181DDC770", Slot = "19")]
	private void NKMBOANIGPI(long OCLLLDFCOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBF30", Offset = "0x1DDB130", VA = "0x181DDBF30", Slot = "20")]
	private bool CIKOADKAAPO(long PCDLGIEJLMB, out DateTime JAEEJCCOPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC630", Offset = "0x1DDB830", VA = "0x181DDC630", Slot = "16")]
	private Task LMCPCENMPDB(string ONIMCFGGJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBE40", Offset = "0x1DDB040", VA = "0x181DDBE40", Slot = "13")]
	private Task<BMMHCIJFCCJ> AHNCAIFAHLD(HFBMBACFDEJ MOIHJBBBEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC220", Offset = "0x1DDB420", VA = "0x181DDC220", Slot = "14")]
	private Task<BMMHCIJFCCJ> ECCAFKCPIAC(BFJNMOMPEEB NMLIOADCGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC000", Offset = "0x1DDB200", VA = "0x181DDC000", Slot = "15")]
	private Task<BMMHCIJFCCJ> DMBBGAGBKPO(int DIJKJKNKFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC780", Offset = "0x1DDB980", VA = "0x181DDC780", Slot = "17")]
	[AsyncStateMachine(typeof(CMEMFLDJPEL))]
	private Task<BMMHCIJFCCJ> PEELJNLICGK(LLILGLIBBAK BCLLMCFINDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC550", Offset = "0x1DDB750", VA = "0x181DDC550")]
	[IteratorStateMachine(typeof(DOKCNAAIEOC))]
	private IEnumerable<LHPMHGNAPIB> IDFFHLEIEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC300", Offset = "0x1DDB500", VA = "0x181DDC300")]
	[CompilerGenerated]
	private void FPGNFDJMIEG(LHPMHGNAPIB FHHNJKNMCDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class CNKIEHFLADF : HCIBCNENKAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct LLAOBEMAHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CNKIEHFLADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1A18080", Offset = "0x1A17280", VA = "0x181A18080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1A18350", Offset = "0x1A17550", VA = "0x181A18350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x617450", Offset = "0x616650", VA = "0x180617450")]
	public CNKIEHFLADF(JDEEGONKAHJ DBHAEMIDIKE, OCJFFCBIIPG FJHGBCNEILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1A0AF20", Offset = "0x1A0A120", VA = "0x181A0AF20", Slot = "4")]
	[AsyncStateMachine(typeof(LLAOBEMAHII))]
	public Task<bool> MOBEEDHOBHE(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1A0AE60", Offset = "0x1A0A060", VA = "0x181A0AE60")]
	[CompilerGenerated]
	private object EDAECLMCMKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class GBAGOFCPNLL : HCIBCNENKAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct CEFKEFNMILA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public GBAGOFCPNLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7F70", Offset = "0x1DD7170", VA = "0x181DD7F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8530", Offset = "0x1DD7730", VA = "0x181DD8530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const float HAAGBOFCMMJ = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1DDDBE0", Offset = "0x1DDCDE0", VA = "0x181DDDBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x617450", Offset = "0x616650", VA = "0x180617450")]
	public GBAGOFCPNLL(JDEEGONKAHJ DBHAEMIDIKE, OCJFFCBIIPG FJHGBCNEILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDD50", Offset = "0x1DDCF50", VA = "0x181DDDD50", Slot = "4")]
	[AsyncStateMachine(typeof(CEFKEFNMILA))]
	public Task<bool> MOBEEDHOBHE(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDC30", Offset = "0x1DDCE30", VA = "0x181DDDC30")]
	[CompilerGenerated]
	private object LIECAPGKEAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class MOJHJBPAFNI : HCIBCNENKAP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NNAOPILJDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public MOJHJBPAFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Matchmaking.LFJDKBFJIMD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EGAEEHPFEGO newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public NNAOPILJDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4AA0", Offset = "0x1FA3CA0", VA = "0x181FA4AA0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4BD0", Offset = "0x1FA3DD0", VA = "0x181FA4BD0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4C30", Offset = "0x1FA3E30", VA = "0x181FA4C30")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct COMEMBALLOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public MOJHJBPAFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private NNAOPILJDDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<Matchmaking.LFJDKBFJIMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1F94500", Offset = "0x1F93700", VA = "0x181F94500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1F94D20", Offset = "0x1F93F20", VA = "0x181F94D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private const float HAAGBOFCMMJ = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2390", Offset = "0x1FA1590", VA = "0x181FA2390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x617450", Offset = "0x616650", VA = "0x180617450")]
	public MOJHJBPAFNI(JDEEGONKAHJ DBHAEMIDIKE, OCJFFCBIIPG FJHGBCNEILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA23E0", Offset = "0x1FA15E0", VA = "0x181FA23E0", Slot = "4")]
	[AsyncStateMachine(typeof(COMEMBALLOH))]
	public Task<bool> MOBEEDHOBHE(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface HCIBCNENKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> MOBEEDHOBHE(CancellationToken MNPKHBAPNDC);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal struct GOLOBDMNAJK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PJFKGAGPCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JDEEGONKAHJ manager;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PJFKGAGPCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1DEED80", Offset = "0x1DEDF80", VA = "0x181DEED80")]
		internal Task <CreateTask>b__0(FJGNCHMKJML data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IGGHMGMDALA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public GOLOBDMNAJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool <restore>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1DE47B0", Offset = "0x1DE39B0", VA = "0x181DE47B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4AA0", Offset = "0x1DE3CA0", VA = "0x181DE4AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NNPODFJNBHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GOLOBDMNAJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE420", Offset = "0x1DED620", VA = "0x181DEE420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CancellationToken MNPKHBAPNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly JDEEGONKAHJ FLPOABMGBFA;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private ODCOJLILBCP OGHOJDLAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1DDEAB0", Offset = "0x1DDDCB0", VA = "0x181DDEAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE3F0", Offset = "0x1DDD5F0", VA = "0x181DDE3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE580", Offset = "0x1DDD780", VA = "0x181DDE580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private PFGFMBAMNLF DCLLMPPDKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE4C0", Offset = "0x1DDD6C0", VA = "0x181DDE4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1DDEB00", Offset = "0x1DDDD00", VA = "0x181DDEB00")]
	public GOLOBDMNAJK(CancellationToken MNPKHBAPNDC, JDEEGONKAHJ FLPOABMGBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE600", Offset = "0x1DDD800", VA = "0x181DDE600")]
	public static ONIMKHMBFLI IEKOEKMNONN(JDEEGONKAHJ FLPOABMGBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE690", Offset = "0x1DDD890", VA = "0x181DDE690")]
	[AsyncStateMachine(typeof(IGGHMGMDALA))]
	public Task<bool> KIALENPBJIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE8A0", Offset = "0x1DDDAA0", VA = "0x181DDE8A0")]
	private bool NMJIEJLEMIK(out FileInfo CPKICHMLKGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE7A0", Offset = "0x1DDD9A0", VA = "0x181DDE7A0")]
	[AsyncStateMachine(typeof(NNPODFJNBHO))]
	private Task NDHIDCOCDAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE990", Offset = "0x1DDDB90", VA = "0x181DDE990")]
	private Task<bool> PCKGKKPKIJN(FileInfo CPKICHMLKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE440", Offset = "0x1DDD640", VA = "0x181DDE440")]
	private Task BBJOJKIADDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE510", Offset = "0x1DDD710", VA = "0x181DDE510")]
	private void GFGLPKPLAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal struct IKMOMHJCLBA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EONPACEDPDO HILKPFJAEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Guid GCECPKLIDBO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task<(BMMHCIJFCCJ, Task)> LBMKINGJCON
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5210", Offset = "0x1DE4410", VA = "0x181DE5210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1DE52E0", Offset = "0x1DE44E0", VA = "0x181DE52E0")]
	public IKMOMHJCLBA(EONPACEDPDO HILKPFJAEJI, Guid GCECPKLIDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1DE50F0", Offset = "0x1DE42F0", VA = "0x181DE50F0")]
	public TaskAwaiter<(BMMHCIJFCCJ, Task)> BHCLPALBOLN()
	{
		return default(TaskAwaiter<(BMMHCIJFCCJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5140", Offset = "0x1DE4340", VA = "0x181DE5140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal struct MGALCAJGDOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly TaskCompletionSource<(BMMHCIJFCCJ, Task)> KEOGOJOLKAM;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<(BMMHCIJFCCJ, Task)> LBMKINGJCON
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9FD70", Offset = "0x1F9EF70", VA = "0x181F9FD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FE80", Offset = "0x1F9F080", VA = "0x181F9FE80")]
	public MGALCAJGDOP(TimeSpan EFGEEIOMDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FDB0", Offset = "0x1F9EFB0", VA = "0x181F9FDB0")]
	public void PCGMIJLFODA(Task LFJPKOKOGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FC60", Offset = "0x1F9EE60", VA = "0x181F9FC60")]
	public void ICGLJNJPDMO(BMMHCIJFCCJ FBJOEPDKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FC10", Offset = "0x1F9EE10", VA = "0x181F9FC10")]
	public void FHGGPLDGIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FCF0", Offset = "0x1F9EEF0", VA = "0x181F9FCF0")]
	internal void LKKNLEBNNBC(string MPHBMEGMJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Preserve]
internal class MNEAPJKJANF : LGJFLAHKIKA, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JFLJCJKHIFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public MNEAPJKJANF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1F99BF0", Offset = "0x1F98DF0", VA = "0x181F99BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MNFFEBPEFEE DJCNCCKFLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private string JHMNGDPNMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private Task ALEGDHKBHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool NJDKNOHEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1FC0", Offset = "0x1FA11C0", VA = "0x181FA1FC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Task EJELKOGOKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1E30", Offset = "0x1FA1030", VA = "0x181FA1E30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1E0", Offset = "0x5CB3E0", VA = "0x1805CC1E0", Slot = "7")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1CB0", Offset = "0x1FA0EB0", VA = "0x181FA1CB0", Slot = "6")]
	public void DOPIFCKEFGB(Task ALCHLJLEFAL, string JAPOFGMKEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1E90", Offset = "0x1FA1090", VA = "0x181FA1E90")]
	[AsyncStateMachine(typeof(JFLJCJKHIFO))]
	private Task LJNAJODJMOI(Task CIKCICKHDOJ, string JAPOFGMKEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1FF0", Offset = "0x1FA11F0", VA = "0x181FA1FF0")]
	public MNEAPJKJANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class EFLODGKMAKP : DANPILJGIPC, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool IEALCMMAMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private ENEGFJHMAMA JALGKNEFENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private PNJJINBPFKN JCGHEHOIPEP;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public ENEGFJHMAMA HJGIHOLFKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E510", Offset = "0x1A0D710", VA = "0x181A0E510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0D5B0", VA = "0x181A0E3B0", Slot = "7")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E230", Offset = "0x1A0D430", VA = "0x181A0E230", Slot = "5")]
	public void BGNGDBPBJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E1F0", Offset = "0x1A0D3F0", VA = "0x181A0E1F0", Slot = "6")]
	public void AHKENHIBBLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E580", Offset = "0x1A0D780", VA = "0x181A0E580")]
	private Task MBMLBHCMACG(BHILMEJIOBP LILBGEPBKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E1F0", Offset = "0x1A0D3F0", VA = "0x181A0E1F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public EFLODGKMAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class PBIBJFBOEMG : PNJJINBPFKN
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class ACCPMBCEKPP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly IDFKFFAGFPC KKNCBCHBLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly string DHDAEDILENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly T IDNAMJJDDGK;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public T AMCKDLHOFMB
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x576360", VA = "0x180577160")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x5C41F0", Offset = "0x5C33F0", VA = "0x1805C41F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x32223D0", Offset = "0x32215D0", VA = "0x1832223D0")]
		public ACCPMBCEKPP(IDFKFFAGFPC KKNCBCHBLAN, string DHDAEDILENC, T IDNAMJJDDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3221DF0", Offset = "0x3220FF0", VA = "0x183221DF0")]
		private void CNNDPIIBINB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly ACCPMBCEKPP<TimeSpan> DBIBFIHLNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly ACCPMBCEKPP<TimeSpan> AIHHJKLACBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly ACCPMBCEKPP<bool> GKGAMKNCLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly ACCPMBCEKPP<bool> EJNPBPJPGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ACCPMBCEKPP<bool> OEIEAEOIOAL;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public TimeSpan FBOGDIGMKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4F14B80", Offset = "0x4F13D80", VA = "0x184F14B80", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public TimeSpan DCHLLGKJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4F14A80", Offset = "0x4F13C80", VA = "0x184F14A80", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool BJBNCCFDBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4F14AC0", Offset = "0x4F13CC0", VA = "0x184F14AC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool JJADIGOEPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4F14B40", Offset = "0x4F13D40", VA = "0x184F14B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool JFBDICNOFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4F14B00", Offset = "0x4F13D00", VA = "0x184F14B00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4F14BC0", Offset = "0x4F13DC0", VA = "0x184F14BC0")]
	[Preserve]
	public PBIBJFBOEMG([AFDDHPBBNKH(null)] IDFKFFAGFPC KKNCBCHBLAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Preserve]
internal class FMHGMHJBJPD : IFPMEFKCGIC, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NJLNBHDMMCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public EBNFCAKGABN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public NJLNBHDMMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE2F0", Offset = "0x1DED4F0", VA = "0x181DEE2F0")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event DPBPJCFMPPO CBPMCLIEOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1DDCCB0", Offset = "0x1DDBEB0", VA = "0x181DDCCB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD210", Offset = "0x1DDC410", VA = "0x181DDD210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event DPBPJCFMPPO EJNACAPKAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1DDCFA0", Offset = "0x1DDC1A0", VA = "0x181DDCFA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD040", Offset = "0x1DDC240", VA = "0x181DDD040", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event DPBPJCFMPPO HKAIMFOOPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1DDCC10", Offset = "0x1DDBE10", VA = "0x181DDCC10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD140", Offset = "0x1DDC340", VA = "0x181DDD140", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "13")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD1E0", Offset = "0x1DDC3E0", VA = "0x181DDD1E0", Slot = "10")]
	public void HOAOFENMOLK(EBNFCAKGABN LMOJFFGMOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD110", Offset = "0x1DDC310", VA = "0x181DDD110", Slot = "11")]
	public void FNMFJACIKJF(EBNFCAKGABN LMOJFFGMOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD0E0", Offset = "0x1DDC2E0", VA = "0x181DDD0E0", Slot = "12")]
	public void EFGJNLBCILI(EBNFCAKGABN LMOJFFGMOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCD50", Offset = "0x1DDBF50", VA = "0x181DDCD50")]
	private void CCNLNBIKCNF(DPBPJCFMPPO NOCGOILLINF, EBNFCAKGABN LMOJFFGMOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FMHGMHJBJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Preserve]
internal class LJLLAOJMNMG : JBFDOGLEOPK, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct JELHFNNNLOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LJLLAOJMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1F99250", Offset = "0x1F98450", VA = "0x181F99250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct NNLDIJKGMBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public LJLLAOJMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4CC0", Offset = "0x1FA3EC0", VA = "0x181FA4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class JOKIJPFDONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JOKIJPFDONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A2D0", Offset = "0x1F994D0", VA = "0x181F9A2D0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CBPFIJMOLGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LJLLAOJMNMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private JOKIJPFDONL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1F93D40", Offset = "0x1F92F40", VA = "0x181F93D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1F94470", Offset = "0x1F93670", VA = "0x181F94470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PJBGHLDHJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PJBGHLDHJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9A20", Offset = "0x1FA8C20", VA = "0x181FA9A20")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private HCIBCNENKAP[] NOFLEPGIEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CancellationTokenSource AFPPKFJFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int GBKMODPHICG;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DDA0", Offset = "0x1F9CFA0", VA = "0x181F9DDA0", Slot = "7")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DD90", Offset = "0x1F9CF90", VA = "0x181F9DD90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E4F0", Offset = "0x1F9D6F0", VA = "0x181F9E4F0", Slot = "6")]
	public void IPJKCILOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DC40", Offset = "0x1F9CE40", VA = "0x181F9DC40", Slot = "5")]
	public void DJKDDEJGMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E9A0", Offset = "0x1F9DBA0", VA = "0x181F9E9A0", Slot = "4")]
	[AsyncStateMachine(typeof(JELHFNNNLOK))]
	public Task PDLPPPONBGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DF50", Offset = "0x1F9D150", VA = "0x181F9DF50")]
	private void HFAJHGPEGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E780", Offset = "0x1F9D980", VA = "0x181F9E780")]
	[AsyncStateMachine(typeof(NNLDIJKGMBB))]
	private Task LJLLONMJKGJ(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DE20", Offset = "0x1F9D020", VA = "0x181F9DE20")]
	[AsyncStateMachine(typeof(CBPFIJMOLGC))]
	private Task<bool> GIKKGIBJHPH(int PPMIPKENDBN, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E660", Offset = "0x1F9D860", VA = "0x181F9E660")]
	private void KEPHGEBMCHE(int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E8A0", Offset = "0x1F9DAA0", VA = "0x181F9E8A0")]
	private void OIHIOMMLJBP(int PPMIPKENDBN, bool CCJACBLKPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E360", Offset = "0x1F9D560", VA = "0x181F9E360")]
	private void IMPDMIINPBK(int PPMIPKENDBN, Exception JCDAGKOMEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E270", Offset = "0x1F9D470", VA = "0x181F9E270")]
	private void HFLGBEMPODI(CancellationToken MNPKHBAPNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public LJLLAOJMNMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Preserve]
internal class IDOHPNCHBJH : CAFIPILONKF, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct EOOBDAMEJDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDOHPNCHBJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FJGNCHMKJML roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA0B0", Offset = "0x1DD92B0", VA = "0x181DDA0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KBFPHEMPMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public IDOHPNCHBJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FJGNCHMKJML roomData;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public KBFPHEMPMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1DE89B0", Offset = "0x1DE7BB0", VA = "0x181DE89B0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct KODFEFKJNDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public ONIMKHMBFLI taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DEA6D0", Offset = "0x1DE98D0", VA = "0x181DEA6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CFIMEPDAKOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public IDOHPNCHBJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8580", Offset = "0x1DD7780", VA = "0x181DD8580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HashSet<ONIMKHMBFLI> JOGDEDAPNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private OKCHODFFIAN DHKDKMAFOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NAGFPELOHOE KDCIPHDKFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private DAFHHGHPDBA EDHGFNAKDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private IDisposable DPFPPPDEIHC;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool AFAHFKJLLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1DE36F0", Offset = "0x1DE28F0", VA = "0x181DE36F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal Task LBMKINGJCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4730", Offset = "0x1DE3930", VA = "0x181DE4730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3AD0", Offset = "0x1DE2CD0", VA = "0x181DE3AD0", Slot = "6")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3940", Offset = "0x1DE2B40", VA = "0x181DE3940", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3D40", Offset = "0x1DE2F40", VA = "0x181DE3D40", Slot = "5")]
	public bool HJHHEDNNDGH(ONIMKHMBFLI KDOOIMIGCCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3700", Offset = "0x1DE2900", VA = "0x181DE3700")]
	private void DNMCNKDGEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE44E0", Offset = "0x1DE36E0", VA = "0x181DE44E0")]
	private void MFDJIDLNFNH(FJGNCHMKJML PKMAOEIDLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE43C0", Offset = "0x1DE35C0", VA = "0x181DE43C0")]
	[AsyncStateMachine(typeof(EOOBDAMEJDI))]
	private Task LKNMCAILHDD(FJGNCHMKJML PKMAOEIDLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4310", Offset = "0x1DE3510", VA = "0x181DE4310")]
	private Func<CancellationToken, List<Task>> LHEBILGNHKM(FJGNCHMKJML PKMAOEIDLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3E70", Offset = "0x1DE3070", VA = "0x181DE3E70")]
	private List<Task> LBMOIMKJLOD(FJGNCHMKJML PKMAOEIDLKI, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1DE39A0", Offset = "0x1DE2BA0", VA = "0x181DE39A0")]
	[AsyncStateMachine(typeof(KODFEFKJNDN))]
	private Task FKDMDMCKMIH(ONIMKHMBFLI PGMBKHKCIEF, FJGNCHMKJML NJOKIDJGNHA, CancellationToken OFCAAIDMNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3840", Offset = "0x1DE2A40", VA = "0x181DE3840")]
	[AsyncStateMachine(typeof(CFIMEPDAKOL))]
	private Task DOHCOOILCMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3DA0", Offset = "0x1DE2FA0", VA = "0x181DE3DA0")]
	private void IPJKCILOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4740", Offset = "0x1DE3940", VA = "0x181DE4740")]
	public IDOHPNCHBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Preserve]
internal class EPIPJPKIOEA : IGMNLNALIOE, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LKLMCLCAOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBC60", Offset = "0x1DEAE60", VA = "0x181DEBC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct LOLCBICCOIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private CancellationTokenSource <timeoutCancellationSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private global::MKPPAJLLJAE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private HPIMPDEBPJM <joinRoomInstancePauseToken>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private BOHMICDIIGP <analyticsData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private CancellationTokenSource <initialRoomLoadCancellationSource>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC290", Offset = "0x1DEB490", VA = "0x181DEC290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class FLFHNMIHLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Task<POLMFGONIBA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public FLFHNMIHLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		internal Task<POLMFGONIBA> <ConnectToRoomAndRunLoadLogic>b__0(FGDOGDEIJDO _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct KMAJMOFIAAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HPIMPDEBPJM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private FLFHNMIHLKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private BONKGPBDJMA <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private FGDOGDEIJDO <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private ODJOGAELAPJ <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter<POLMFGONIBA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9370", Offset = "0x1DE8570", VA = "0x181DE9370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class PAPPPJJLEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public PIPLJGEOFBE presence;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PAPPPJJLEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DEEC50", Offset = "0x1DEDE50", VA = "0x181DEEC50")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct MMAMFBIEBKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private FGDOGDEIJDO <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private FGDOGDEIJDO <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DED3F0", Offset = "0x1DEC5F0", VA = "0x181DED3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HCHHNKAHDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public HPIMPDEBPJM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private FGDOGDEIJDO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<HJBJDPECMIB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0E20", Offset = "0x1DE0020", VA = "0x181DE0E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EEFMIOEOCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EEFMIOEOCMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OALMGGNDNLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public EEFMIOEOCMJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public OALMGGNDNLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE7A0", Offset = "0x1DED9A0", VA = "0x181DEE7A0")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE6B0", Offset = "0x1DED8B0", VA = "0x181DEE6B0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct ECDPEMKKACJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private OALMGGNDNLN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1DD97A0", Offset = "0x1DD89A0", VA = "0x181DD97A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct JGLIGGIJKBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HPIMPDEBPJM joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public POLMFGONIBA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EGAEEHPFEGO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public BONKGPBDJMA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private FGDOGDEIJDO <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6550", Offset = "0x1DE5750", VA = "0x181DE6550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GNJJGBGDEOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private FGDOGDEIJDO <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE080", Offset = "0x1DDD280", VA = "0x181DDE080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct AADIMOKABOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7220", Offset = "0x1DD6420", VA = "0x181DD7220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct FGGBBJHFLII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBBC0", Offset = "0x1DDADC0", VA = "0x181DDBBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct HKMIPMKCKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<BMMHCIJFCCJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DE27F0", Offset = "0x1DE19F0", VA = "0x181DE27F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct LDOKKDONPEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public EPIPJPKIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1DEB9A0", Offset = "0x1DEABA0", VA = "0x181DEB9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class COKGLOAACPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public COKGLOAACPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8A60", Offset = "0x1DD7C60", VA = "0x181DD8A60")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JNDDNCDBKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JNDDNCDBKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8150", Offset = "0x1DE7350", VA = "0x181DE8150")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CMCGKMPDMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CMCGKMPDMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1DD87C0", Offset = "0x1DD79C0", VA = "0x181DD87C0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ALDJHHKNILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ALDJHHKNILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7D60", Offset = "0x1DD6F60", VA = "0x181DD7D60")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly Guid PANDDMMEPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EECAHPCGHOC GMEHMFPLCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private OKCHODFFIAN DHKDKMAFOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private JBFDOGLEOPK POFLGKDPGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private DOFMGKHHAMO BAAKHGCFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private LGJFLAHKIKA GKLCABJKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private IFPMEFKCGIC EMMBHGFLIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private PNJJINBPFKN JCGHEHOIPEP;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public TaskStatus OCIFLGCLABM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x620250", Offset = "0x61F450", VA = "0x180620250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x620260", Offset = "0x61F460", VA = "0x180620260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A11B60", Offset = "0x1A10D60", VA = "0x181A11B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1A11730", Offset = "0x1A10930", VA = "0x181A11730", Slot = "6")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1A11250", Offset = "0x1A10450", VA = "0x181A11250", Slot = "5")]
	[AsyncStateMachine(typeof(LKLMCLCAOCP))]
	public Task FJDGBMEIEHF(EGAEEHPFEGO BEFEGPNCEAC, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1A11C70", Offset = "0x1A10E70", VA = "0x181A11C70")]
	[AsyncStateMachine(typeof(LOLCBICCOIA))]
	private Task IHMGGFBJNGI(EGAEEHPFEGO BEFEGPNCEAC, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A12750", Offset = "0x1A11950", VA = "0x181A12750")]
	private static void MIFFIHGAMDJ(BOHMICDIIGP EFHDIABCGEI, Exception JCDAGKOMEPG, [Optional] List<int> LOCOBBOCHHL, int GBKMODPHICG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A110E0", Offset = "0x1A102E0", VA = "0x181A110E0")]
	[AsyncStateMachine(typeof(KMAJMOFIAAA))]
	private Task FFHBJHNJDCE(FGDOGDEIJDO IDJNPLHMMHL, EGAEEHPFEGO BEFEGPNCEAC, HPIMPDEBPJM FEJJMFHOPHP, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A10D30", Offset = "0x1A0FF30", VA = "0x181A10D30")]
	private void DMMGGJCHICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A13050", Offset = "0x1A12250", VA = "0x181A13050")]
	private PIPLJGEOFBE NLJGFMPEFHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1A114A0", Offset = "0x1A106A0", VA = "0x181A114A0")]
	[AsyncStateMachine(typeof(MMAMFBIEBKE))]
	private Task FMHLDFBJDPM(FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A124C0", Offset = "0x1A116C0", VA = "0x181A124C0")]
	private void MBJBACLDMDO(EGAEEHPFEGO BEFEGPNCEAC, CancellationToken NDAAKCECFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1A101E0", Offset = "0x1A0F3E0", VA = "0x181A101E0")]
	private void ABHIAMNOKNG(EGAEEHPFEGO BEFEGPNCEAC, HPIMPDEBPJM FEJJMFHOPHP, OperationCanceledException DOABMHIGKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1A10A00", Offset = "0x1A0FC00", VA = "0x181A10A00")]
	private void DGBCMFADMME(EGAEEHPFEGO BEFEGPNCEAC, HPIMPDEBPJM FEJJMFHOPHP, Exception JCDAGKOMEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1A12260", Offset = "0x1A11460", VA = "0x181A12260")]
	private void LMDBHCAFMJN(EGAEEHPFEGO BEFEGPNCEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A10CD0", Offset = "0x1A0FED0", VA = "0x181A10CD0")]
	private static EBNFCAKGABN DKKOHFBAKOM(EGAEEHPFEGO BEFEGPNCEAC)
	{
		return default(EBNFCAKGABN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A11DA0", Offset = "0x1A10FA0", VA = "0x181A11DA0")]
	private void IJLKCPOJDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1A11FD0", Offset = "0x1A111D0", VA = "0x181A11FD0")]
	private static HJBJDPECMIB KKHNPGCMLJN(EGAEEHPFEGO BEFEGPNCEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A115D0", Offset = "0x1A107D0", VA = "0x181A115D0")]
	[AsyncStateMachine(typeof(HCHHNKAHDEP))]
	private Task FNBFPEALPJG(EGAEEHPFEGO BEFEGPNCEAC, HPIMPDEBPJM FEJJMFHOPHP, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken CJNBEHPOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A10E50", Offset = "0x1A10050", VA = "0x181A10E50")]
	[AsyncStateMachine(typeof(ECDPEMKKACJ))]
	private Task EIFMAGLLGPJ(EGAEEHPFEGO BEFEGPNCEAC, CancellationTokenSource ENCBGMPHDIG, Task CPBIPDAGGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A10880", Offset = "0x1A0FA80", VA = "0x181A10880")]
	[AsyncStateMachine(typeof(JGLIGGIJKBD))]
	private Task DBEILLIIIBM(POLMFGONIBA EHFGNPCPKOB, BONKGPBDJMA NIDNECLKCED, EGAEEHPFEGO MFLKPJLOAHL, HPIMPDEBPJM HBLNIDBHEPO, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken AMKFIFMJBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1A10680", Offset = "0x1A0F880", VA = "0x181A10680")]
	private HPIMPDEBPJM BNCIGHLIKGK(HPIMPDEBPJM HBLNIDBHEPO, ref CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A12DE0", Offset = "0x1A11FE0", VA = "0x181A12DE0")]
	[AsyncStateMachine(typeof(GNJJGBGDEOF))]
	private Task NDLAKHIIPMF(FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A12F20", Offset = "0x1A12120", VA = "0x181A12F20")]
	[AsyncStateMachine(typeof(AADIMOKABOK))]
	private Task NGMHALHGEAP(FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A11E90", Offset = "0x1A11090", VA = "0x181A11E90")]
	[AsyncStateMachine(typeof(FGGBBJHFLII))]
	private Task KGICNCKHMFH(FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1A12130", Offset = "0x1A11330", VA = "0x181A12130")]
	[AsyncStateMachine(typeof(HKMIPMKCKBE))]
	private Task LDBJACLBNPK(FJGNCHMKJML NJOKIDJGNHA, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1A10FA0", Offset = "0x1A101A0", VA = "0x181A10FA0")]
	[AsyncStateMachine(typeof(LDOKKDONPEI))]
	private Task EMPLJBHACBI(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken CJNBEHPOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1A11380", Offset = "0x1A10580", VA = "0x181A11380")]
	private static void FKMIJFDBNNL(EGAEEHPFEGO BEFEGPNCEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1A13330", Offset = "0x1A12530", VA = "0x181A13330")]
	private static void PKLHJAKGPDP(EGAEEHPFEGO BEFEGPNCEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1A12080", Offset = "0x1A11280", VA = "0x181A12080")]
	private static void KLBDEKKBIEH(EGAEEHPFEGO BEFEGPNCEAC, CancellationToken CJNBEHPOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1A119E0", Offset = "0x1A10BE0", VA = "0x181A119E0")]
	private static void GELLMANONNP(EGAEEHPFEGO BEFEGPNCEAC, Exception JCDAGKOMEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1A104B0", Offset = "0x1A0F6B0", VA = "0x181A104B0")]
	private void ANECFEBCANN(EGAEEHPFEGO BEFEGPNCEAC, Task CPBIPDAGGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A11BB0", Offset = "0x1A10DB0", VA = "0x181A11BB0")]
	private static void HNLGNJKEDAI(Func<string> IECHLGOLKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1A134D0", Offset = "0x1A126D0", VA = "0x181A134D0")]
	public EPIPJPKIOEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Preserve]
internal sealed class BFHDAGHALPK : EONPACEDPDO, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class BBKNGHMDDKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BBKNGHMDDKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1A05760", Offset = "0x1A04960", VA = "0x181A05760")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class EKGFBIEOBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EKGFBIEOBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1A0EB50", Offset = "0x1A0DD50", VA = "0x181A0EB50")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class EMEAAMKAHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EMEAAMKAHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0EBA0", Offset = "0x1A0DDA0", VA = "0x181A0EBA0")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CJEDHPMENED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CJEDHPMENED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0AE10", Offset = "0x1A0A010", VA = "0x181A0AE10")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class CENEAOJJHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CENEAOJJHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A310", Offset = "0x1A09510", VA = "0x181A0A310")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Dictionary<Guid, MGALCAJGDOP> HILKPFJAEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly TimeSpan GKAKBKHPLPI;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "10")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1A062B0", Offset = "0x1A054B0", VA = "0x181A062B0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1A062C0", Offset = "0x1A054C0", VA = "0x181A062C0", Slot = "4")]
	public IKMOMHJCLBA INLOBDHPAIC(Guid GCECPKLIDBO)
	{
		return default(IKMOMHJCLBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1A06AC0", Offset = "0x1A05CC0", VA = "0x181A06AC0", Slot = "5")]
	public bool MNIDDOJOCKH(Guid GCECPKLIDBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1A06550", Offset = "0x1A05750", VA = "0x181A06550", Slot = "8")]
	public bool IPJKCILOBJL(Guid GCECPKLIDBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1A06760", Offset = "0x1A05960", VA = "0x181A06760", Slot = "6")]
	public bool KBPCKGBJECO(Guid GCECPKLIDBO, Task LFJPKOKOGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1A06090", Offset = "0x1A05290", VA = "0x181A06090", Slot = "7")]
	public bool DDGNEALCEDN(Guid GCECPKLIDBO, BMMHCIJFCCJ FBJOEPDKJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1A06D00", Offset = "0x1A05F00", VA = "0x181A06D00", Slot = "9")]
	public Task<(BMMHCIJFCCJ, Task)> PCNJHPACGHC(Guid GCECPKLIDBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x1A05E50", Offset = "0x1A05050", VA = "0x181A05E50")]
	private void AMJAAJHCOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1A06D80", Offset = "0x1A05F80", VA = "0x181A06D80")]
	public BFHDAGHALPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Preserve]
internal class OLPFHHGIBHP : HAEFNIDEAIG, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class IIEGHPGNCNC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly EGAEEHPFEGO BMDCNGNJHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly CancellationTokenSource AFPPKFJFGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public readonly CancellationToken OMFCMHHNOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private bool DGLAMEGAELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool BJOLDLCEHDH;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1F98C60", Offset = "0x1F97E60", VA = "0x181F98C60")]
		public IIEGHPGNCNC(EGAEEHPFEGO BMDCNGNJHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1F98B30", Offset = "0x1F97D30", VA = "0x181F98B30")]
		public void IPJKCILOBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1F98B00", Offset = "0x1F97D00", VA = "0x181F98B00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OFCBFNGMFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public BHILMEJIOBP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public OFCBFNGMFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4F143B0", Offset = "0x4F135B0", VA = "0x184F143B0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct MNFECLPOJOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public BHILMEJIOBP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public OLPFHHGIBHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2060", Offset = "0x1FA1260", VA = "0x181FA2060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class LBCOOFPAKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public LBCOOFPAKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B9E0", Offset = "0x1F9ABE0", VA = "0x181F9B9E0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct BPMOLHLKGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public OLPFHHGIBHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1F93290", Offset = "0x1F92490", VA = "0x181F93290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAFE520", Offset = "0xAFD720", VA = "0x180AFE520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MCGKIOEHILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EGAEEHPFEGO newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MCGKIOEHILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9FB00", Offset = "0x1F9ED00", VA = "0x181F9FB00")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9FB90", Offset = "0x1F9ED90", VA = "0x181F9FB90")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1F9FBD0", Offset = "0x1F9EDD0", VA = "0x181F9FBD0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class PJJHCJMOEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PJJHCJMOEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4F14EE0", Offset = "0x4F140E0", VA = "0x184F14EE0")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct NLAPLONAAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public EGAEEHPFEGO newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public OLPFHHGIBHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private MCGKIOEHILG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA30D0", Offset = "0x1FA22D0", VA = "0x181FA30D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private OKCHODFFIAN DHKDKMAFOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private JBFDOGLEOPK POFLGKDPGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private PNJJINBPFKN JCGHEHOIPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private IGMNLNALIOE FHNEGDIHALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long JCKNHBFKAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private IIEGHPGNCNC KJDGOCOMDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool IGENHICBBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Task NNGOAFCPKON;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8E20", Offset = "0x1FA8020", VA = "0x181FA8E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8BD0", Offset = "0x1FA7DD0", VA = "0x181FA8BD0", Slot = "4")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8A80", Offset = "0x1FA7C80", VA = "0x181FA8A80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9050", Offset = "0x1FA8250", VA = "0x181FA9050")]
	[AsyncStateMachine(typeof(MNFECLPOJOA))]
	private Task IACIDDGAJCD(BHILMEJIOBP BKNDGAIIIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8880", Offset = "0x1FA7A80", VA = "0x181FA8880")]
	private void BOAAMFIIAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8E70", Offset = "0x1FA8070", VA = "0x181FA8E70")]
	private void HKFAGOPEOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9160", Offset = "0x1FA8360", VA = "0x181FA9160")]
	private void IAEHKMNKMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9440", Offset = "0x1FA8640", VA = "0x181FA9440")]
	private bool JAHKMKBKELE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1FA87A0", Offset = "0x1FA79A0", VA = "0x181FA87A0")]
	[AsyncStateMachine(typeof(BPMOLHLKGEH))]
	private void BNCANFNEBNB(int KFHPDJDOGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9640", Offset = "0x1FA8840", VA = "0x181FA9640")]
	private void KMGDKDFIBON(out IDisposable MLCMICGIGKG, out IDisposable IBCONNCBFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA94C0", Offset = "0x1FA86C0", VA = "0x181FA94C0")]
	private bool JCHKCOCDNIH(EGAEEHPFEGO BMDCNGNJHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9330", Offset = "0x1FA8530", VA = "0x181FA9330")]
	[AsyncStateMachine(typeof(NLAPLONAAHD))]
	private Task IHMGGFBJNGI(EGAEEHPFEGO BMDCNGNJHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9930", Offset = "0x1FA8B30", VA = "0x181FA9930")]
	public OLPFHHGIBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Preserve]
internal sealed class NPNFEBJPOGH : BHDNNJLHBFH, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct GLLEIEMGIAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<BPPMEJGJJLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NPNFEBJPOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<BPPMEJGJJLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1F97C40", Offset = "0x1F96E40", VA = "0x181F97C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1F97E10", Offset = "0x1F97010", VA = "0x181F97E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class JALLEHFLEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public KHKCMDHCAIC message;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JALLEHFLEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1F99200", Offset = "0x1F98400", VA = "0x181F99200")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class EPOEBMDDOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public KHKCMDHCAIC messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EPOEBMDDOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1F96730", Offset = "0x1F95930", VA = "0x181F96730")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class BDPKMCNPCNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BDPKMCNPCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1F93240", Offset = "0x1F92440", VA = "0x181F93240")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct NKJCBKLLEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public NPNFEBJPOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<BOGCNIBCKJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2A50", Offset = "0x1FA1C50", VA = "0x181FA2A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class JMFFKIKBDLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public KHKCMDHCAIC operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JMFFKIKBDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A280", Offset = "0x1F99480", VA = "0x181F9A280")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MLJCLKFFFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public KHKCMDHCAIC operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NPNFEBJPOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private HPIMPDEBPJM <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0A90", Offset = "0x1F9FC90", VA = "0x181FA0A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct IILCEFFFLMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<BOGCNIBCKJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NPNFEBJPOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private HPIMPDEBPJM <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1F98D10", Offset = "0x1F97F10", VA = "0x181F98D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1F990E0", Offset = "0x1F982E0", VA = "0x181F990E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OPIDBFNHFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public BOGCNIBCKJK operation;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public OPIDBFNHFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1FA99B0", Offset = "0x1FA8BB0", VA = "0x181FA99B0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct LKIPHLOBGGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public BOGCNIBCKJK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NPNFEBJPOGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private global::MKPPAJLLJAE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EB40", Offset = "0x1F9DD40", VA = "0x181F9EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HCDBEBMFIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HCDBEBMFIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1F98740", Offset = "0x1F97940", VA = "0x181F98740")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class IPDMCMIMEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IPDMCMIMEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1F991B0", Offset = "0x1F983B0", VA = "0x181F991B0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private LGJFLAHKIKA GKLCABJKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private HBKLDEGDBCN KDOPGCFLDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private DOFMGKHHAMO BAAKHGCFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private TaskCompletionSource<BPPMEJGJJLO> DMLECFBCPID;

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5380", Offset = "0x1FA4580", VA = "0x181FA5380", Slot = "7")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5DE0", Offset = "0x1FA4FE0", VA = "0x181FA5DE0", Slot = "6")]
	[AsyncStateMachine(typeof(GLLEIEMGIAJ))]
	public Task<BPPMEJGJJLO> LDNOMPDAMIC(CancellationToken AHJMCEGBFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6250", Offset = "0x1FA5450", VA = "0x181FA6250", Slot = "4")]
	public void PEKMPICMOEK(KHKCMDHCAIC MPHBMEGMJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5A50", Offset = "0x1FA4C50", VA = "0x181FA5A50", Slot = "5")]
	public void IFAMBJNGKMP(KHKCMDHCAIC FBDOPKEMDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6030", Offset = "0x1FA5230", VA = "0x181FA6030")]
	[AsyncStateMachine(typeof(NKJCBKLLEGN))]
	private Task MCAMPKBJIJE(KHKCMDHCAIC JENMNBIOPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6140", Offset = "0x1FA5340", VA = "0x181FA6140")]
	[AsyncStateMachine(typeof(MLJCLKFFFDC))]
	private Task MKDHICACLMC(KHKCMDHCAIC HDKCLAKAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1FA51C0", Offset = "0x1FA43C0", VA = "0x181FA51C0")]
	[AsyncStateMachine(typeof(IILCEFFFLMM))]
	private Task<BOGCNIBCKJK> AOOKLMKBJFL(KHKCMDHCAIC JENMNBIOPFE, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5300", Offset = "0x1FA4500", VA = "0x181FA5300")]
	private HPIMPDEBPJM BEMINKFMLOF(KHKCMDHCAIC JFBLIKGKCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5F00", Offset = "0x1FA5100", VA = "0x181FA5F00")]
	[AsyncStateMachine(typeof(LKIPHLOBGGG))]
	private Task LEIBOMBKIHL(BOGCNIBCKJK BIPINHFPINC, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5800", Offset = "0x1FA4A00", VA = "0x181FA5800")]
	private BOGCNIBCKJK HNJCDEKMEMH(KHKCMDHCAIC JENMNBIOPFE, HPIMPDEBPJM CFEILPEPHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x1947C70", Offset = "0x1946E70", VA = "0x181947C70")]
	private T FCKBNGACCDK<T>(T PNLMJAPAHBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5460", Offset = "0x1FA4660", VA = "0x181FA5460")]
	private BOGCNIBCKJK HFBGDEEDCEH(KHKCMDHCAIC JENMNBIOPFE, HPIMPDEBPJM CFEILPEPHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NPNFEBJPOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5D90", Offset = "0x1FA4F90", VA = "0x181FA5D90")]
	[CompilerGenerated]
	private void JPCMEDDFMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[Preserve]
internal sealed class HCGKDBBLNHJ : HBKLDEGDBCN, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class HHJKLKJPCFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HHJKLKJPCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2540", Offset = "0x1DE1740", VA = "0x181DE2540")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class IABJMLEKJCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IABJMLEKJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3610", Offset = "0x1DE2810", VA = "0x181DE3610")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private DECOINHLINO OEAJNNKGCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private BHDNNJLHBFH HIFPMJIHLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private EONPACEDPDO HILKPFJAEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private OJHAKCBHDFG MILKDICFFEN;

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1DDFF70", Offset = "0x1DDF170", VA = "0x181DDFF70", Slot = "6")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF6E0", Offset = "0x1DDE8E0", VA = "0x181DDF6E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0570", Offset = "0x1DDF770", VA = "0x181DE0570", Slot = "4")]
	public IKMOMHJCLBA JPLDMHNCLCM(KEGADJFLAHK JENMNBIOPFE)
	{
		return default(IKMOMHJCLBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF770", Offset = "0x1DDE970", VA = "0x181DDF770", Slot = "5")]
	public void EHLAHAALDLB(Guid GCECPKLIDBO, Task LFJPKOKOGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0D50", Offset = "0x1DDFF50", VA = "0x181DE0D50")]
	private void MLKFPPLNBLD(byte BFJJPKCBDIC, int PJKMEGCHHIM, object JMMIABKLMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF9C0", Offset = "0x1DDEBC0", VA = "0x181DDF9C0")]
	private void FLPBKIIMFCD(CDGHACHIJBC EAHKPEGNOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF000", Offset = "0x1DDE200", VA = "0x181DDF000")]
	private void DEFDCAAADLD(CDGHACHIJBC EAHKPEGNOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1DDEDA0", Offset = "0x1DDDFA0", VA = "0x181DDEDA0")]
	private void AICDOLEJKLO(CDGHACHIJBC EAHKPEGNOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1DE00C0", Offset = "0x1DDF2C0", VA = "0x181DE00C0")]
	private BMMHCIJFCCJ INGPGOAFJKN(KHKCMDHCAIC JFBLIKGKCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF4B0", Offset = "0x1DDE6B0", VA = "0x181DDF4B0")]
	private void DMINMBGOCJF(KHKCMDHCAIC HDKCLAKAJKN, BMMHCIJFCCJ FBJOEPDKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF290", Offset = "0x1DDE490", VA = "0x181DDF290")]
	private bool DIAGKDPCIFL(KHKCMDHCAIC HDKCLAKAJKN, BMMHCIJFCCJ FBJOEPDKJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0320", Offset = "0x1DDF520", VA = "0x181DE0320")]
	private bool JPLDMHNCLCM(KHKCMDHCAIC EHCKIODEDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0A80", Offset = "0x1DDFC80", VA = "0x181DE0A80")]
	private bool KELMIEPPCEP(byte BFJJPKCBDIC, ExitGames.Client.Photon.Hashtable EAHKPEGNOFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HCGKDBBLNHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Preserve]
internal sealed class DFHGDGBKOOG : IEOMEDNPJOP, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class NDOOPCPHGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public BPPMEJGJJLO operationType;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public NDOOPCPHGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1A18E70", Offset = "0x1A18070", VA = "0x181A18E70")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct HAAAAPLKHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<BMMHCIJFCCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public BPPMEJGJJLO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public DFHGDGBKOOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public BFJNMOMPEEB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public HFBMBACFDEJ detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private TaskAwaiter<BMMHCIJFCCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1A156F0", Offset = "0x1A148F0", VA = "0x181A156F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1A15CC0", Offset = "0x1A14EC0", VA = "0x181A15CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class CALPKFAAGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public BPPMEJGJJLO operationType;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CALPKFAAGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1A09A20", Offset = "0x1A08C20", VA = "0x181A09A20")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class BGCJHBIFCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public BPPMEJGJJLO operationType;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BGCJHBIFCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1A06E20", Offset = "0x1A06020", VA = "0x181A06E20")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1A06E80", Offset = "0x1A06080", VA = "0x181A06E80")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1A06EE0", Offset = "0x1A060E0", VA = "0x181A06EE0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct OPJJIBHJGLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder<BMMHCIJFCCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public BPPMEJGJJLO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public DFHGDGBKOOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public BFJNMOMPEEB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public HFBMBACFDEJ detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private BGCJHBIFCIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private IKMOMHJCLBA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private BMMHCIJFCCJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private TaskAwaiter<(BMMHCIJFCCJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B110", Offset = "0x1A1A310", VA = "0x181A1B110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B750", Offset = "0x1A1A950", VA = "0x181A1B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class CAEJMGGFNLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public BPPMEJGJJLO operationType;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CAEJMGGFNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1A099C0", Offset = "0x1A08BC0", VA = "0x181A099C0")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private INGOFBPGNCL NEJNONMJLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private DECOINHLINO OEAJNNKGCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private HBKLDEGDBCN KDOPGCFLDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B580", Offset = "0x1A0A780", VA = "0x181A0B580", Slot = "5")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1A0BB80", Offset = "0x1A0AD80", VA = "0x181A0BB80", Slot = "4")]
	[AsyncStateMachine(typeof(HAAAAPLKHKF))]
	public Task<BMMHCIJFCCJ> NEDIMEJLMLF(BFJNMOMPEEB IOFAGLPECPA, BPPMEJGJJLO GMOACGPGCIA, [CanBeNull] HFBMBACFDEJ MOIHJBBBEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B350", Offset = "0x1A0A550", VA = "0x181A0B350")]
	private bool AIKGGJNNIMI(BPPMEJGJJLO GMOACGPGCIA, out BMMHCIJFCCJ HPCDOCAJMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0BA30", Offset = "0x1A0AC30", VA = "0x181A0BA30")]
	[AsyncStateMachine(typeof(OPJJIBHJGLK))]
	private Task<BMMHCIJFCCJ> MHAFAHDLNAJ(BFJNMOMPEEB IOFAGLPECPA, BPPMEJGJJLO GMOACGPGCIA, [CanBeNull] HFBMBACFDEJ MOIHJBBBEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B680", Offset = "0x1A0A880", VA = "0x181A0B680")]
	internal KEGADJFLAHK LEONECEMGPJ(BFJNMOMPEEB IOFAGLPECPA, BPPMEJGJJLO GMOACGPGCIA, [CanBeNull] HFBMBACFDEJ MOIHJBBBEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public DFHGDGBKOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[Preserve]
internal sealed class DLDHKHDFGJH : INGOFBPGNCL, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct AMDAEJFEIIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<POLMFGONIBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public DLDHKHDFGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<HFBMBACFDEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1A04280", Offset = "0x1A03480", VA = "0x181A04280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1A046E0", Offset = "0x1A038E0", VA = "0x181A046E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class IFAFHGOEFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IFAFHGOEFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1A161D0", Offset = "0x1A153D0", VA = "0x181A161D0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct NKPCBIKGGMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder<HFBMBACFDEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public DLDHKHDFGJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public EGAEEHPFEGO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private IFAFHGOEFKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<OMENMBHFAPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1A18ED0", Offset = "0x1A180D0", VA = "0x181A18ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1A191F0", Offset = "0x1A183F0", VA = "0x181A191F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class MGIFKEJMOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MGIFKEJMOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x993470", Offset = "0x992670", VA = "0x180993470")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(ALKBFOJPDKK sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static readonly (LEDBOJAOMNI superRoomData, LEDBOJAOMNI subRoomData) BCNENFMFCFG;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C9D0", Offset = "0x1A0BBD0", VA = "0x181A0C9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C960", Offset = "0x1A0BB60", VA = "0x181A0C960", Slot = "6")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x1A0CA20", Offset = "0x1A0BC20", VA = "0x181A0CA20", Slot = "4")]
	[AsyncStateMachine(typeof(AMDAEJFEIIL))]
	public Task<POLMFGONIBA> MMAGEJNNBHG(FGDOGDEIJDO LILIKHLPHEJ, EGAEEHPFEGO BEFEGPNCEAC, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1A0CE70", Offset = "0x1A0C070", VA = "0x181A0CE70")]
	[AsyncStateMachine(typeof(NKPCBIKGGMP))]
	public Task<HFBMBACFDEJ> PMHLFKLABGO(EGAEEHPFEGO BEFEGPNCEAC, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C780", Offset = "0x1A0B980", VA = "0x181A0C780", Slot = "5")]
	public POLMFGONIBA BJJPDEKCMHH(EGAEEHPFEGO BEFEGPNCEAC, HFBMBACFDEJ EIJAJDEMGEH, long OCLLLDFCOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C600", Offset = "0x1A0B800", VA = "0x181A0C600")]
	private static POLMFGONIBA AIMCLCAPCMJ(HFBMBACFDEJ EIJAJDEMGEH, long OCLLLDFCOAB, LEDBOJAOMNI ANJPFHBEFJB, LEDBOJAOMNI PKMAOEIDLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1A0CB80", Offset = "0x1A0BD80", VA = "0x181A0CB80")]
	private (LEDBOJAOMNI, LEDBOJAOMNI) OECHCPIAFJB(EGAEEHPFEGO BEFEGPNCEAC, HFBMBACFDEJ EIJAJDEMGEH, long OCLLLDFCOAB)
	{
		return default((LEDBOJAOMNI, LEDBOJAOMNI));
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public DLDHKHDFGJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class CHAEENJDGAA : DOFMGKHHAMO, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class HDEIIAODEFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HDEIIAODEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1A15D10", Offset = "0x1A14F10", VA = "0x181A15D10")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct NNANEHNBMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public CHAEENJDGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public HPIMPDEBPJM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1A19240", Offset = "0x1A18440", VA = "0x181A19240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1A19700", Offset = "0x1A18900", VA = "0x181A19700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct LNHKHMPOJHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CHAEENJDGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public HPIMPDEBPJM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter<MIJKANCCBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A183A0", Offset = "0x1A175A0", VA = "0x181A183A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1A188A0", Offset = "0x1A17AA0", VA = "0x181A188A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class IOJMOCKMBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IOJMOCKMBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1A16720", Offset = "0x1A15920", VA = "0x181A16720")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct OLDPNLNDCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public KHKCMDHCAIC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public CHAEENJDGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public HPIMPDEBPJM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private EJBCPIODCMB <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private AHHHDKFIEDL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<MIJKANCCBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1A19D30", Offset = "0x1A18F30", VA = "0x181A19D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1A1A610", Offset = "0x1A19810", VA = "0x181A1A610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private DANPILJGIPC AOJECMKCFNB;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private ENEGFJHMAMA HJGIHOLFKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A840", Offset = "0x1A09A40", VA = "0x181A0A840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A650", Offset = "0x1A09850", VA = "0x181A0A650", Slot = "8")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A400", Offset = "0x1A09600", VA = "0x181A0A400", Slot = "4")]
	[AsyncStateMachine(typeof(NNANEHNBMOK))]
	public Task<KHKCMDHCAIC> BOPDHGHGBLH(KHKCMDHCAIC JENMNBIOPFE, HPIMPDEBPJM CFEILPEPHEO, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A8F0", Offset = "0x1A09AF0", VA = "0x181A0A8F0", Slot = "5")]
	[AsyncStateMachine(typeof(LNHKHMPOJHA))]
	public Task<KHKCMDHCAIC> LPAPHICJGAE(CancellationToken MNPKHBAPNDC, HPIMPDEBPJM CFEILPEPHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A360", Offset = "0x1A09560", VA = "0x181A0A360", Slot = "6")]
	public FBACHMNJFOB AIGDDDEFIFG(BOGCNIBCKJK GLKLKKOKPAE, FGDOGDEIJDO LILIKHLPHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A550", Offset = "0x1A09750", VA = "0x181A0A550", Slot = "7")]
	public FBACHMNJFOB DPPEGJMKBDM(BOGCNIBCKJK GLKLKKOKPAE, FGDOGDEIJDO LILIKHLPHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A6E0", Offset = "0x1A098E0", VA = "0x181A0A6E0")]
	[AsyncStateMachine(typeof(OLDPNLNDCOO))]
	private Task<KHKCMDHCAIC> GGFMOICCIPI(KHKCMDHCAIC JENMNBIOPFE, HPIMPDEBPJM CFEILPEPHEO, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A830", Offset = "0x1A09A30", VA = "0x181A0A830")]
	private static byte[] HKAPGIJOJJH(KHKCMDHCAIC MPHBMEGMJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A0AA30", Offset = "0x1A09C30", VA = "0x181A0AA30")]
	private static string NENAHFCCKOO(byte[] OEDMLNBLEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public CHAEENJDGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[Preserve]
internal sealed class HGLEHNBCKAA : DECOINHLINO, LHPMHGNAPIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private BEKLGDOIHFN JDAAPLAKLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private LGJFLAHKIKA GKLCABJKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private JMFJFDNGGLF OCMHMEOCMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private IGMNLNALIOE FHNEGDIHALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private CAFIPILONKF HMEDAELNPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private PNJJINBPFKN JCGHEHOIPEP;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1EB0", Offset = "0x1DE10B0", VA = "0x181DE1EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private static BMMHCIJFCCJ ALGKLDCEAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F00", Offset = "0x1DE1100", VA = "0x181DE1F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1CE0", Offset = "0x1DE0EE0", VA = "0x181DE1CE0", Slot = "7")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1820", Offset = "0x1DE0A20", VA = "0x181DE1820", Slot = "4")]
	public BMMHCIJFCCJ CENNIIFFOGJ(BFJNMOMPEEB HDDBJKFKLBM, BPPMEJGJJLO JJMDEGEECOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1B30", Offset = "0x1DE0D30", VA = "0x181DE1B30", Slot = "5")]
	public BMMHCIJFCCJ FIACIMILLHI(BFJNMOMPEEB GGLCGPAJMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1970", Offset = "0x1DE0B70", VA = "0x181DE1970", Slot = "6")]
	public BMMHCIJFCCJ DBKICJDNGDF(BFJNMOMPEEB GGLCGPAJMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1F10", Offset = "0x1DE1110", VA = "0x181DE1F10")]
	private static BMMHCIJFCCJ MPLAAOOPBHJ(EDICNCKALMM PFAHEGOAJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HGLEHNBCKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class AKJGFMMINHK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A03B70", Offset = "0x1A02D70", VA = "0x181A03B70")]
	public AKJGFMMINHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x917960", Offset = "0x916B60", VA = "0x180917960")]
	public AKJGFMMINHK(string MPHBMEGMJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[Preserve]
internal sealed class JMOMABLBFFF : PFGFMBAMNLF, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct MKMMPDGIGGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<BMMHCIJFCCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JMOMABLBFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public LLILGLIBBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private global::MKPPAJLLJAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private FGDOGDEIJDO <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private FGDOGDEIJDO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private TaskAwaiter<BMMHCIJFCCJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1DECD20", Offset = "0x1DEBF20", VA = "0x181DECD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1DED3A0", Offset = "0x1DEC5A0", VA = "0x181DED3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct NAFGJHJNHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public JMOMABLBFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1DEDCA0", Offset = "0x1DECEA0", VA = "0x181DEDCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct JFPAEHNBLNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public JMOMABLBFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5F70", Offset = "0x1DE5170", VA = "0x181DE5F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct ABJIKKFANDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public JMOMABLBFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7800", Offset = "0x1DD6A00", VA = "0x181DD7800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct KFDLBIANLOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public JMOMABLBFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8C60", Offset = "0x1DE7E60", VA = "0x181DE8C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct FNFIEHJLKBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JMOMABLBFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public LLILGLIBBAK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private global::MKPPAJLLJAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD2B0", Offset = "0x1DDC4B0", VA = "0x181DDD2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly TimeSpan LAGJIIIPENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private ODCOJLILBCP MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private DOFMGKHHAMO BAAKHGCFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private LGJFLAHKIKA GKLCABJKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private CAFIPILONKF HMEDAELNPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private CancellationTokenSource CIMEDILFPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private Task OOMFAPNFONF;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE74C0", Offset = "0x1DE66C0", VA = "0x181DE74C0", Slot = "6")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xD1B7B0", Offset = "0xD1A9B0", VA = "0x180D1B7B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7FD0", Offset = "0x1DE71D0", VA = "0x181DE7FD0", Slot = "4")]
	[AsyncStateMachine(typeof(MKMMPDGIGGA))]
	public Task<BMMHCIJFCCJ> OKLOBCAOJPF(LLILGLIBBAK BCLLMCFINDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE73A0", Offset = "0x1DE65A0", VA = "0x181DE73A0", Slot = "5")]
	[AsyncStateMachine(typeof(NAFGJHJNHLB))]
	public Task CAPKJAFFALH([Optional] CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xD1B7B0", Offset = "0xD1A9B0", VA = "0x180D1B7B0")]
	public void AJCBHPAPJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7E00", Offset = "0x1DE7000", VA = "0x181DE7E00")]
	private ABBJKJNGIGI OIHBCEKEIIM(LLILGLIBBAK BCLLMCFINDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7CE0", Offset = "0x1DE6EE0", VA = "0x181DE7CE0")]
	[AsyncStateMachine(typeof(JFPAEHNBLNK))]
	private Task MHIJEOBKPGB(FJGNCHMKJML LILBGEPBKKD, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7970", Offset = "0x1DE6B70", VA = "0x181DE7970")]
	[AsyncStateMachine(typeof(ABJIKKFANDM))]
	private Task KPDHLLCFBHI([Optional] CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7A80", Offset = "0x1DE6C80", VA = "0x181DE7A80")]
	[AsyncStateMachine(typeof(KFDLBIANLOO))]
	private Task LEKALDJGLDC(TimeSpan ENJCGECIDEA, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DE76C0", Offset = "0x1DE68C0", VA = "0x181DE76C0")]
	private Task IAKDOMLLNCL(LLILGLIBBAK BCLLMCFINDB, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7BB0", Offset = "0x1DE6DB0", VA = "0x181DE7BB0")]
	[AsyncStateMachine(typeof(FNFIEHJLKBO))]
	private Task LPCNHNJNCCM(LLILGLIBBAK BCLLMCFINDB, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DE78D0", Offset = "0x1DE6AD0", VA = "0x181DE78D0")]
	private bool JDHIHHOMBNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public JMOMABLBFFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal class HNMPMCFAHNG : JMFJFDNGGLF, LHPMHGNAPIB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct KAIPEKIDNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public HNMPMCFAHNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private global::MKPPAJLLJAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8630", Offset = "0x1DE7830", VA = "0x181DE8630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private KKKPMHOCHJD JHNAGAHPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private DECOINHLINO OEAJNNKGCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private DOFMGKHHAMO BAAKHGCFBNO;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3130", Offset = "0x1DE2330", VA = "0x181DE3130", Slot = "6")]
	public void GDDEOJNJOEM(JDEEGONKAHJ DBHAEMIDIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3110", Offset = "0x1DE2310", VA = "0x181DE3110", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3390", Offset = "0x1DE2590", VA = "0x181DE3390", Slot = "5")]
	[AsyncStateMachine(typeof(KAIPEKIDNKO))]
	public Task IEGLCEPENII(string ONIMCFGGJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1DE34B0", Offset = "0x1DE26B0", VA = "0x181DE34B0", Slot = "4")]
	public BMMHCIJFCCJ JDHIHHOMBNE(BFJNMOMPEEB HDDBJKFKLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE32B0", Offset = "0x1DE24B0", VA = "0x181DE32B0")]
	private NMDAFIOOBED HBLAIODJCGM(string ONIMCFGGJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HNMPMCFAHNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class CDCGHCKCAPN
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1A09A80", Offset = "0x1A08C80", VA = "0x181A09A80")]
	public static void EJLLKBLKIMI(FBJAIGGBNJC CDGPJIKOKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1A09E80", Offset = "0x1A09080", VA = "0x181A09E80")]
	internal static void LHALEADHLBL(FBJAIGGBNJC CDGPJIKOKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1A09F20", Offset = "0x1A09120", VA = "0x181A09F20")]
	internal static void OHCOOMOKCIC(FBJAIGGBNJC CDGPJIKOKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1A09BC0", Offset = "0x1A08DC0", VA = "0x181A09BC0")]
	internal static void IPJOAKLJACA(FBJAIGGBNJC CDGPJIKOKFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class BBBMEFOPIOE : global::GEOKFLGKPON<KHKCMDHCAIC>
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class JCEHIIFBIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public string op;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public KHKCMDHCAIC message;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JCEHIIFBIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1A168D0", Offset = "0x1A15AD0", VA = "0x181A168D0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly BBBMEFOPIOE JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private const string LMIOGOAJBFN = "pl";

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1A05620", Offset = "0x1A04820", VA = "0x181A05620")]
	public ExitGames.Client.Photon.Hashtable MNIJLJLODBL(KHKCMDHCAIC MPHBMEGMJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1A04FE0", Offset = "0x1A041E0", VA = "0x181A04FE0", Slot = "5")]
	protected override void AHGEJPDIAOO(KHKCMDHCAIC MPHBMEGMJKJ, IDictionary<object, object> NJOKIDJGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1A05330", Offset = "0x1A04530", VA = "0x181A05330", Slot = "6")]
	public override KHKCMDHCAIC HMOLPLGFINA(IDictionary<object, object> NJOKIDJGNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1A054D0", Offset = "0x1A046D0", VA = "0x181A054D0")]
	private static void HNLGNJKEDAI(string BDCEBJAAAJG, KHKCMDHCAIC MPHBMEGMJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1A05720", Offset = "0x1A04920", VA = "0x181A05720")]
	public BBBMEFOPIOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1A050F0", Offset = "0x1A042F0", VA = "0x181A050F0")]
	[CompilerGenerated]
	internal static string EAGKNCFAMLF(POLMFGONIBA IMJFNGNMFKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class MHFGCDEFPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static BMMHCIJFCCJ ALGKLDCEAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0360", Offset = "0x1F9F560", VA = "0x181FA0360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA03C0", Offset = "0x1F9F5C0", VA = "0x181FA03C0")]
	public static bool MGODFDPKBHH(this BMMHCIJFCCJ FBJOEPDKJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA03E0", Offset = "0x1F9F5E0", VA = "0x181FA03E0")]
	public static BMMHCIJFCCJ MPLAAOOPBHJ(EDICNCKALMM MAGLKDNMHEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0440", Offset = "0x1F9F640", VA = "0x181FA0440")]
	public static BMMHCIJFCCJ OLHFCAOEBFK(params BMMHCIJFCCJ[] EECJANCOABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FA01C0", Offset = "0x1F9F3C0", VA = "0x181FA01C0")]
	public static BMMHCIJFCCJ DFCDDEAMBKA(IEnumerable<BMMHCIJFCCJ> EECJANCOABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FFC0", Offset = "0x1F9F1C0", VA = "0x181F9FFC0")]
	public static string DEKLKIGDAHN(this BMMHCIJFCCJ HPCDOCAJMAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public abstract class BKDGMGMCEKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public delegate BMMHCIJFCCJ IAFEFHKJLEI([NotNull] BFJNMOMPEEB ELKHCBMKBCP);

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class JANPGBEMKAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public BFJNMOMPEEB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JANPGBEMKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1A168A0", Offset = "0x1A15AA0", VA = "0x181A168A0")]
		internal BMMHCIJFCCJ <Validate>b__0(IAFEFHKJLEI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	protected readonly HashSet<IAFEFHKJLEI> JFNELLEDKGJ;

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1A080B0", Offset = "0x1A072B0", VA = "0x181A080B0")]
	public void PDCFLEGDBKI(IAFEFHKJLEI IMIJINBFOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1A07EB0", Offset = "0x1A070B0", VA = "0x181A07EB0")]
	public void JNBJPLLKEKO(IAFEFHKJLEI IMIJINBFOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1A07E60", Offset = "0x1A07060", VA = "0x181A07E60", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1A07F10", Offset = "0x1A07110", VA = "0x181A07F10")]
	protected BMMHCIJFCCJ LOEICFCCMGF(BFJNMOMPEEB GGLCGPAJMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1A05A70", Offset = "0x1A04C70", VA = "0x181A05A70")]
	protected BKDGMGMCEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class BEKLGDOIHFN : BKDGMGMCEKA
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class LGIFBCKDCLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public BMMHCIJFCCJ result;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public LGIFBCKDCLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1A18030", Offset = "0x1A17230", VA = "0x181A18030")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1A05A70", Offset = "0x1A04C70", VA = "0x181A05A70")]
	[Preserve]
	public BEKLGDOIHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1A057B0", Offset = "0x1A049B0", VA = "0x181A057B0")]
	public BMMHCIJFCCJ LKGFKMDJIEF(BFJNMOMPEEB GGLCGPAJMPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class KKKPMHOCHJD : BKDGMGMCEKA
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class NJPFLHMPBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public BMMHCIJFCCJ result;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public NJPFLHMPBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE3D0", Offset = "0x1DED5D0", VA = "0x181DEE3D0")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9360", Offset = "0x1DE8560", VA = "0x181DE9360")]
	[Preserve]
	public KKKPMHOCHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9210", Offset = "0x1DE8410", VA = "0x181DE9210")]
	public BMMHCIJFCCJ JDHIHHOMBNE(BFJNMOMPEEB POEEPLGAGME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public enum HBGFACPFNKO
{
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class HCJFHPNJMBB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class CBADKENJMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public global::MKPPAJLLJAE<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CBADKENJMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7EF0", Offset = "0x1DD70F0", VA = "0x181DD7EF0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public const string ONMGNGEDMPE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public const string LMGNOPDNEPP = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1DE14B0", Offset = "0x1DE06B0", VA = "0x181DE14B0")]
	public static global::MKPPAJLLJAE<string> JCFKIEPHKIN([Optional] string MJKBDIDJIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1730", Offset = "0x1DE0930", VA = "0x181DE1730")]
	private static void OMKDHJNCBIG(string DHDAEDILENC, JEPKFGJBKOE IDJNPLHMMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1DE13D0", Offset = "0x1DE05D0", VA = "0x181DE13D0")]
	private static void FFAPAACFOHG(string DHDAEDILENC, JEPKFGJBKOE IDJNPLHMMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1560", Offset = "0x1DE0760", VA = "0x181DE1560")]
	public static void KJMMPOCGDOO(global::MKPPAJLLJAE<string> IDJNPLHMMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1690", Offset = "0x1DE0890", VA = "0x181DE1690")]
	public static string NPFJDPOHANI(KHKCMDHCAIC JFBLIKGKCPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal static class EJBJBEMNNNC
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E710", Offset = "0x1A0D910", VA = "0x181A0E710")]
	public static void NLLJAKJAMEO(this ODCOJLILBCP MPNHFLDDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E700", Offset = "0x1A0D900", VA = "0x181A0E700")]
	public static void GLHEINGMLAP(this ODCOJLILBCP MPNHFLDDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E600", Offset = "0x1A0D800", VA = "0x181A0E600")]
	private static void GHBGOPJBDJM(this ODCOJLILBCP MPNHFLDDJEL, bool GIAFOGMNCHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class NMNINCIOOLL : FOGJDAIMMCO, DDHMBDBKOLO, MAGHPCEIDCJ, CMMOGBELHLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private readonly DDHMBDBKOLO PHMDKOHLMEH;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BFJNMOMPEEB BJADHGCEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1FA40B0", Offset = "0x1FA32B0", VA = "0x181FA40B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int MHJBEJPOCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1FA44D0", Offset = "0x1FA36D0", VA = "0x181FA44D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int FCOENMDMDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4980", Offset = "0x1FA3B80", VA = "0x181FA4980", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool IENIIPJIBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x573BD0", VA = "0x1805749D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event AMFABAGPFGC.HFGPKEDMLGK NHGIDIHMLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA47A0", Offset = "0x1FA39A0", VA = "0x181FA47A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4100", Offset = "0x1FA3300", VA = "0x181FA4100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event BOCPOJFNGDG EFJKAPOOEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4660", Offset = "0x1FA3860", VA = "0x181FA4660", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4520", Offset = "0x1FA3720", VA = "0x181FA4520", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<bool> AAECLOLCFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1FA49D0", Offset = "0x1FA3BD0", VA = "0x181FA49D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1FA45C0", Offset = "0x1FA37C0", VA = "0x181FA45C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BFJNMOMPEEB> HHCPCIPLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1FA41C0", Offset = "0x1FA33C0", VA = "0x181FA41C0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1FA48E0", Offset = "0x1FA3AE0", VA = "0x181FA48E0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action JGKAEEPKOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4700", Offset = "0x1FA3900", VA = "0x181FA4700", Slot = "25")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4840", Offset = "0x1FA3A40", VA = "0x181FA4840", Slot = "26")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4A70", Offset = "0x1FA3C70", VA = "0x181FA4A70")]
	public NMNINCIOOLL(DDHMBDBKOLO PHMDKOHLMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4300", Offset = "0x1FA3500", VA = "0x181FA4300", Slot = "8")]
	public bool FAHDENDOPAM(byte BFJJPKCBDIC, ExitGames.Client.Photon.Hashtable ODLLLIDBCLO, PJBMNMILBPN NDHNHFNMJIG, SendOptions EDLCIPKECIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4260", Offset = "0x1FA3460", VA = "0x181FA4260", Slot = "28")]
	public BFJNMOMPEEB ELEDODAIJKL(int CJPELPFFGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4400", Offset = "0x1FA3600", VA = "0x181FA4400", Slot = "15")]
	public BFJNMOMPEEB GAAINJKHNKB(int DIJKJKNKFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "18")]
	public void GMPHOFOPBEE(object OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "19")]
	public void LMAIPMAPCAP(object OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "20")]
	public void GNPEBMDDPNN(object OFCAAIDMNPE, bool BELIFHMFHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1FA43A0", Offset = "0x1FA35A0", VA = "0x181FA43A0", Slot = "21")]
	public IDisposable FIGLECKBNNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0", Slot = "22")]
	private bool DHHDLNOMDBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "23")]
	public void LFNLCDFLGHH(StringBuilder LJJBBBOIILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1FA41A0", Offset = "0x1FA33A0", VA = "0x181FA41A0", Slot = "24")]
	public bool DIDNKBAFFNB(bool GDMKKMGMKEN, out string GNGKCJGCMBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	public void OFIHOJLPEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xB77150", Offset = "0xB76350", VA = "0x180B77150", Slot = "27")]
	public void FPGJOLBLPGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal struct CDGHACHIJBC
{
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public const string MOEAIKKOLDP = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public const string CADHOCFICJG = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly IDictionary<object, object> EAHKPEGNOFH;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool DIDNAKPDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x15FAFC0", Offset = "0x15FA1C0", VA = "0x1815FAFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40")]
	public CDGHACHIJBC(IDictionary<object, object> EAHKPEGNOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A280", Offset = "0x1A09480", VA = "0x181A0A280")]
	public bool JJLKFLEKJPD(out KHKCMDHCAIC MPHBMEGMJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A1C0", Offset = "0x1A093C0", VA = "0x181A0A1C0")]
	public Guid FIJLNEKGNEK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1A09FC0", Offset = "0x1A091C0", VA = "0x181A09FC0")]
	public BMMHCIJFCCJ CBKJLLGGLKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A0F0", Offset = "0x1A092F0", VA = "0x181A0A0F0")]
	public static ExitGames.Client.Photon.Hashtable EJKEJHFJNHJ(KHKCMDHCAIC MPHBMEGMJKJ, BMMHCIJFCCJ FBJOEPDKJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class EMLNIFNHNHH
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F3F0", Offset = "0x1A0E5F0", VA = "0x181A0F3F0")]
	public static string MMDLLFEGIFH(this EGAEEHPFEGO DFPGMDHENON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F370", Offset = "0x1A0E570", VA = "0x181A0F370")]
	public static bool IJAKIPBEDLE(this EGAEEHPFEGO DFPGMDHENON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct DAFHHGHPDBA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct GNCBAENCOGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public DAFHHGHPDBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1A15560", Offset = "0x1A14760", VA = "0x181A15560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Func<CancellationToken, List<Task>> AKFAKLMILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly CancellationTokenSource AFPPKFJFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private bool NELKGEDACJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private Task ALCHLJLEFAL;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool DIDNAKPDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B020", Offset = "0x1A0A220", VA = "0x181A0B020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	internal Task LBMKINGJCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B1B0", Offset = "0x1A0A3B0", VA = "0x181A0B1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B230", Offset = "0x1A0A430", VA = "0x181A0B230")]
	public DAFHHGHPDBA(Func<CancellationToken, List<Task>> AKFAKLMILKD, CancellationToken MNPKHBAPNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B0A0", Offset = "0x1A0A2A0", VA = "0x181A0B0A0")]
	[AsyncStateMachine(typeof(GNCBAENCOGO))]
	public Task NABLEFPIKJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B050", Offset = "0x1A0A250", VA = "0x181A0B050", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class EECAHPCGHOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly ALMAFDLIPHJ GOPPBKOLJFC;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private const string FAKMOKNDAIP = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private const string MCHANBMEHPI = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private const string FGHMEGBNGIG = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private const string PAHGBIJODCE = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private string OMCOJLPMCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private long? IGNJGJJIMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private long? PABOCBNEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private EIPDJAFCLDD MEOGKCCGCAJ;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public string PLBAGNJNHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public long DHEGIEBHKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DB40", Offset = "0x1A0CD40", VA = "0x181A0DB40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public long BBNNMOPFLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DEC0", Offset = "0x1A0D0C0", VA = "0x181A0DEC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EIPDJAFCLDD BNONGHINCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE030", Offset = "0x5FD230", VA = "0x1805FE030")]
		get
		{
			return default(EIPDJAFCLDD);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DF10", Offset = "0x1A0D110", VA = "0x181A0DF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E150", Offset = "0x1A0D350", VA = "0x181A0E150")]
	[Preserve]
	public EECAHPCGHOC([AFDDHPBBNKH(null)] ALMAFDLIPHJ GOPPBKOLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DFF0", Offset = "0x1A0D1F0", VA = "0x181A0DFF0")]
	private void NHPAOKPANIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DC80", Offset = "0x1A0CE80", VA = "0x181A0DC80")]
	public void FFLAJNDKLND(long FMLOJIDJGBJ, long OCLLLDFCOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DB90", Offset = "0x1A0CD90", VA = "0x181A0DB90")]
	public void EHPICPABCBH(string KMKCKJAHCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1A0D900", Offset = "0x1A0CB00", VA = "0x181A0D900")]
	public void AAENENKPEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class FBACHMNJFOB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct JOEBJJJKCCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public KHKCMDHCAIC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public FBACHMNJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<GPABDIICDPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE8220", Offset = "0x1DE7420", VA = "0x181DE8220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE85E0", Offset = "0x1DE77E0", VA = "0x181DE85E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct PIBFBLNACPC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class MNBBOBBJGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public KHKCMDHCAIC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MNBBOBBJGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1DEDBB0", Offset = "0x1DECDB0", VA = "0x181DEDBB0")]
		internal KHKCMDHCAIC <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct ILLIDHFFHCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<GPABDIICDPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public KHKCMDHCAIC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public FBACHMNJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EJBCPIODCMB <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<GPABDIICDPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5790", Offset = "0x1DE4990", VA = "0x181DE5790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5D70", Offset = "0x1DE4F70", VA = "0x181DE5D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LMOJDKPCHOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public FBACHMNJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC120", Offset = "0x1DEB320", VA = "0x181DEC120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class ILJEEGKJPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ILJEEGKJPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5640", Offset = "0x1DE4840", VA = "0x181DE5640")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class IMLCAPBPFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IMLCAPBPFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5DC0", Offset = "0x1DE4FC0", VA = "0x181DE5DC0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class JLGBBINEKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JLGBBINEKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7340", Offset = "0x1DE6540", VA = "0x181DE7340")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class NJDPBFHPAKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public NJDPBFHPAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE290", Offset = "0x1DED490", VA = "0x181DEE290")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class HJLPOHJDDAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public FBACHMNJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HJLPOHJDDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x1DE25A0", Offset = "0x1DE17A0", VA = "0x181DE25A0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class GONJPBOLEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public FBACHMNJFOB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public GONJPBOLEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1DDEB40", Offset = "0x1DDDD40", VA = "0x181DDEB40")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private static readonly Guid OIJIELMHGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly BOGCNIBCKJK IHEBPKNAMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly ENEGFJHMAMA HMODMNGBEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly MAGHPCEIDCJ MPNHFLDDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private readonly CMMOGBELHLC MMPMIPGDDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private bool CCKKLIDLFHF;

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB9E0", Offset = "0x1DDABE0", VA = "0x181DDB9E0")]
	public FBACHMNJFOB(BOGCNIBCKJK BIPINHFPINC, ENEGFJHMAMA HMODMNGBEAN, MAGHPCEIDCJ MPNHFLDDJEL, CMMOGBELHLC MMPMIPGDDFE, FGDOGDEIJDO LILIKHLPHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA780", Offset = "0x1DD9980", VA = "0x181DDA780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA780", Offset = "0x1DD9980", VA = "0x181DDA780")]
	public void IHGMPPEBDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB850", Offset = "0x1DDAA50", VA = "0x181DDB850")]
	public void OACCGGANGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA900", Offset = "0x1DD9B00", VA = "0x181DDA900")]
	public void FAIEBDLBDPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB500", Offset = "0x1DDA700", VA = "0x181DDB500")]
	[AsyncStateMachine(typeof(JOEBJJJKCCJ))]
	internal Task<KHKCMDHCAIC> KOAEAPMPINN(FGDOGDEIJDO LILIKHLPHEJ, KHKCMDHCAIC JFBLIKGKCPC, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1A0A830", Offset = "0x1A09A30", VA = "0x181A0A830")]
	private static byte[] EGILICCOHMH<T>(T MPHBMEGMJKJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x1939960", Offset = "0x1938B60", VA = "0x181939960")]
	private static T OKKJFGAKKAN<T>(MessageParser<T> FKHGEOJLPLJ, byte[] MPHBMEGMJKJ, T DAFEKCLAOPE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAA30", Offset = "0x1DD9C30", VA = "0x181DDAA30")]
	[AsyncStateMachine(typeof(ILLIDHFFHCF))]
	private Task<GPABDIICDPN> FGMGMECGLNK(KHKCMDHCAIC JFBLIKGKCPC, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x229A8C0", Offset = "0x2299AC0", VA = "0x18229A8C0")]
	[AsyncStateMachine(typeof(GIBENGABDIE))]
	internal Task<T> KADHONLADFD<T>(CancellationToken NDAAKCECFIE, Func<CancellationToken, Task<T>> GONEKILNFCO, int GMJHHPBJOBH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB380", Offset = "0x1DDA580", VA = "0x181DDB380")]
	[AsyncStateMachine(typeof(LMOJDKPCHOO))]
	internal Task KADHONLADFD(CancellationToken NDAAKCECFIE, Func<CancellationToken, Task> GONEKILNFCO, int GMJHHPBJOBH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB750", Offset = "0x1DDA950", VA = "0x181DDB750")]
	public KHKCMDHCAIC MKEIPHBIBGM(EJBCPIODCMB PFNOMLHPLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB7E0", Offset = "0x1DDA9E0", VA = "0x181DDB7E0")]
	public PKJKEDPEIGG NHHAMPAAIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB140", Offset = "0x1DDA340", VA = "0x181DDB140")]
	public LHHCINGHFAK IDLIHBNDKFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB660", Offset = "0x1DDA860", VA = "0x181DDB660")]
	public LAMCCOIKBJN LAPJFMDAHGN([Optional] DNMCGDCBAOD? KEBNCMOJEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA710", Offset = "0x1DD9910", VA = "0x181DDA710")]
	public OJBCDGDFBBH CEGFIOMOBNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB4D0", Offset = "0x1DDA6D0", VA = "0x181DDB4D0")]
	public void KJANEEPCBFP(Func<Guid, bool> PINNCDAIIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAFC0", Offset = "0x1DDA1C0", VA = "0x181DDAFC0")]
	public void IAEJFFMDCDB(Func<Guid, bool> JCMJJNMLPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAB70", Offset = "0x1DD9D70", VA = "0x181DDAB70")]
	public void GCEEHDKPACE(Func<Guid, bool> PINNCDAIIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB1B0", Offset = "0x1DDA3B0", VA = "0x181DDB1B0")]
	public Guid JGLILLHLLLL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA5B0", Offset = "0x1DD97B0", VA = "0x181DDA5B0")]
	public void BIAOBLFANCO(Guid KIICCCAKINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA490", Offset = "0x1DD9690", VA = "0x181DDA490")]
	public void ABKJGOBPGBN(KHKCMDHCAIC MHEOOLPPPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAD20", Offset = "0x1DD9F20", VA = "0x181DDAD20")]
	public void HNLGNJKEDAI(string IAAMJPOLNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAE70", Offset = "0x1DDA070", VA = "0x181DDAE70")]
	public void HNLGNJKEDAI(Func<string> COJCOOBIFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x19398E0", Offset = "0x1938AE0", VA = "0x1819398E0")]
	private T FCKBNGACCDK<T>(T PNLMJAPAHBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDACD0", Offset = "0x1DD9ED0", VA = "0x181DDACD0")]
	public void HFGAIOBJIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x229A630", Offset = "0x2299830", VA = "0x18229A630")]
	[CompilerGenerated]
	internal static string CELIEHCJBOE<T>(byte[] PKBLLNJJAGK, int OLLILCMKBPI, ref PIBFBLNACPC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal sealed class BHHIHBPAOHE : BOGCNIBCKJK
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class PGOIHHOMOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PGOIHHOMOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1A1BD60", Offset = "0x1A1AF60", VA = "0x181A1BD60")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct FOHPJMHBABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public BHHIHBPAOHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private LHHCINGHFAK <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1A14470", Offset = "0x1A13670", VA = "0x181A14470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class JABNMDIGOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public PIPLJGEOFBE presence;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JABNMDIGOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1A16770", Offset = "0x1A15970", VA = "0x181A16770")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private readonly POLMFGONIBA EHFGNPCPKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private readonly EGAEEHPFEGO JHKJFJGMPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private readonly INGOFBPGNCL NEJNONMJLGP;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const bool ADKPEHNJEMK = false;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1A07560", Offset = "0x1A06760", VA = "0x181A07560")]
	public BHHIHBPAOHE(POLMFGONIBA EHFGNPCPKOB, EGAEEHPFEGO JHKJFJGMPHH, Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, HPIMPDEBPJM LPBDLNEBGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1A07160", Offset = "0x1A06360", VA = "0x181A07160", Slot = "8")]
	[AsyncStateMachine(typeof(FOHPJMHBABO))]
	protected override Task INPCKNMIDAH(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1A072B0", Offset = "0x1A064B0", VA = "0x181A072B0")]
	private PIPLJGEOFBE NLJGFMPEFHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1A06F40", Offset = "0x1A06140", VA = "0x181A06F40")]
	private void DBKBCPFHBJP(PIPLJGEOFBE DEKMNLIPHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1A07080", Offset = "0x1A06280", VA = "0x181A07080")]
	private static void FKMIJFDBNNL(EGAEEHPFEGO DFPGMDHENON, [Optional] string MPHBMEGMJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class ABBJKJNGIGI : BOGCNIBCKJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct GHGHLMKACLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public ABBJKJNGIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter<HFBMBACFDEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1A14C70", Offset = "0x1A13E70", VA = "0x181A14C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private readonly int AKKPPBODOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private readonly LLILGLIBBAK BCLLMCFINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public readonly long FMGEAGLKKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public readonly long MPMLAHFDCMM;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x1A01F30", Offset = "0x1A01130", VA = "0x181A01F30")]
	public ABBJKJNGIGI(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, HPIMPDEBPJM LPBDLNEBGJC, int AKKPPBODOML, LLILGLIBBAK BCLLMCFINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x1A01DF0", Offset = "0x1A00FF0", VA = "0x181A01DF0", Slot = "8")]
	[AsyncStateMachine(typeof(GHGHLMKACLI))]
	protected override Task INPCKNMIDAH(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal abstract class HKOFBELAHPL : BOGCNIBCKJK
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class BAMMIBLOOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public HKOFBELAHPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public MPMHOAALHNM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BAMMIBLOOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7E40", Offset = "0x1DD7040", VA = "0x181DD7E40")]
		internal Task <RunAsync>b__0(FGDOGDEIJDO postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7E80", Offset = "0x1DD7080", VA = "0x181DD7E80")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct IJIPCLEOGBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public HKOFBELAHPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private BAMMIBLOOMP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4AF0", Offset = "0x1DE3CF0", VA = "0x181DE4AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct OHLKACMCIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public MPMHOAALHNM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public HKOFBELAHPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1DEE880", Offset = "0x1DEDA80", VA = "0x181DEE880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x1DE30D0", Offset = "0x1DE22D0", VA = "0x181DE30D0")]
	public HKOFBELAHPL(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, HPIMPDEBPJM LPBDLNEBGJC, string HIJJPFHJGPA, bool PHGPPNNEIGC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2F90", Offset = "0x1DE2190", VA = "0x181DE2F90", Slot = "8")]
	[AsyncStateMachine(typeof(IJIPCLEOGBH))]
	protected override Task INPCKNMIDAH(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task DJPLDLNFCBF(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2E30", Offset = "0x1DE2030", VA = "0x181DE2E30")]
	[AsyncStateMachine(typeof(OHLKACMCIMH))]
	private Task DHPIFCMJPNM(IDisposable ADEHPKPCMNP, MPMHOAALHNM JAKBFFBJNBO, FGDOGDEIJDO IDJNPLHMMHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class CIDDMHKLGGA : BOGCNIBCKJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct NOIAGGFLLFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public CIDDMHKLGGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private OJBCDGDFBBH <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<CDEHMDAHGPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1A19750", Offset = "0x1A18950", VA = "0x181A19750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly LLILGLIBBAK BCLLMCFINDB;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A0AD80", Offset = "0x1A09F80", VA = "0x181A0AD80")]
	public CIDDMHKLGGA(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, HPIMPDEBPJM LPBDLNEBGJC, LLILGLIBBAK BCLLMCFINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A0AB70", Offset = "0x1A09D70", VA = "0x181A0AB70", Slot = "7")]
	protected override string DHNBIILFHLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A0AC40", Offset = "0x1A09E40", VA = "0x181A0AC40", Slot = "8")]
	[AsyncStateMachine(typeof(NOIAGGFLLFN))]
	protected override Task INPCKNMIDAH(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal abstract class BOGCNIBCKJK : MPHPFDHGHKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public delegate Task JKEKBIDNLFD(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class DMAACIFBBMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public FGDOGDEIJDO operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public BOGCNIBCKJK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public DMAACIFBBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D090", Offset = "0x1A0C290", VA = "0x181A0D090")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class BNECCFDDEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public DMAACIFBBMM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BNECCFDDEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A08110", Offset = "0x1A07310", VA = "0x181A08110")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A081D0", Offset = "0x1A073D0", VA = "0x181A081D0")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct FCAMPOIGGLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public BOGCNIBCKJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Func<BOGCNIBCKJK, FGDOGDEIJDO, FBACHMNJFOB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private DMAACIFBBMM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private FBACHMNJFOB <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1A134E0", Offset = "0x1A126E0", VA = "0x181A134E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct AINOCKCKAJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public BOGCNIBCKJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A03930", Offset = "0x1A02B30", VA = "0x181A03930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public readonly Guid NDDICBGFDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public readonly ByteString OGKMNCNEIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public readonly HPIMPDEBPJM EOJEBAAGHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	protected readonly string CGBOHNIIGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private readonly bool PHGPPNNEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private bool FHAPNMFCLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public EIPDJAFCLDD PLCMHJOKJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public EIPDJAFCLDD LODKMMHCLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly Queue<JKEKBIDNLFD> KBNHGLEIEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly ODJOGAELAPJ EJODPOBENIN;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JDEEGONKAHJ NELOPCBAGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5730E0", VA = "0x180573EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1A082F0", Offset = "0x1A074F0", VA = "0x181A082F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1A084E0", Offset = "0x1A076E0", VA = "0x181A084E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float NCCMJIGDDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1A084C0", Offset = "0x1A076C0", VA = "0x181A084C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event NHHCJIKBFMB IIEGPOMACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1A08560", Offset = "0x1A07760", VA = "0x181A08560", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1A08580", Offset = "0x1A07780", VA = "0x181A08580", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x1A08960", Offset = "0x1A07B60", VA = "0x181A08960")]
	protected BOGCNIBCKJK(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, HPIMPDEBPJM LPBDLNEBGJC, string HIJJPFHJGPA, bool PHGPPNNEIGC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x1A08340", Offset = "0x1A07540", VA = "0x181A08340", Slot = "7")]
	protected virtual string DHNBIILFHLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A08290", Offset = "0x1A07490", VA = "0x181A08290")]
	public void AHCGJKAEPOD(JKEKBIDNLFD PGMBKHKCIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x1A087F0", Offset = "0x1A079F0", VA = "0x181A087F0")]
	protected void MBJKJBOMIEK(float IEJJEFKGHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1A085A0", Offset = "0x1A077A0", VA = "0x181A085A0")]
	[AsyncStateMachine(typeof(FCAMPOIGGLE))]
	public Task KIALENPBJIJ(CancellationToken MNPKHBAPNDC, FGDOGDEIJDO LILIKHLPHEJ, [Optional] Func<BOGCNIBCKJK, FGDOGDEIJDO, FBACHMNJFOB> CGGPAPCIOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A086E0", Offset = "0x1A078E0", VA = "0x181A086E0")]
	private void LFDEMKHEAGA(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task INPCKNMIDAH(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A08380", Offset = "0x1A07580", VA = "0x181A08380")]
	[AsyncStateMachine(typeof(AINOCKCKAJG))]
	private Task DNCLICOAEHB(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A088E0", Offset = "0x1A07AE0", VA = "0x181A088E0")]
	public KHKCMDHCAIC MKEIPHBIBGM(EJBCPIODCMB PFNOMLHPLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x1A08810", Offset = "0x1A07A10", VA = "0x181A08810")]
	[CompilerGenerated]
	private Task MFIHEEICJMF(CancellationToken ELLGECINNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal sealed class BHNCPNLLMGM : HKOFBELAHPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct NBPLCLHODCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public BHNCPNLLMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private EBNFCAKGABN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private LHHCINGHFAK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1A188F0", Offset = "0x1A17AF0", VA = "0x181A188F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private readonly POLMFGONIBA JMJPODDBOME;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A07890", Offset = "0x1A06A90", VA = "0x181A07890")]
	public BHNCPNLLMGM(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, POLMFGONIBA JMJPODDBOME, HPIMPDEBPJM LPBDLNEBGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1A07750", Offset = "0x1A06950", VA = "0x181A07750", Slot = "9")]
	[AsyncStateMachine(typeof(NBPLCLHODCA))]
	protected override Task DJPLDLNFCBF(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class NMDAFIOOBED : BOGCNIBCKJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GNODNFEDBFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public NMDAFIOOBED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private TaskAwaiter<CDEHMDAHGPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1F97E60", Offset = "0x1F97060", VA = "0x181F97E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private readonly string KPDCODMGEDI;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3D80", Offset = "0x1FA2F80", VA = "0x181FA3D80")]
	public NMDAFIOOBED(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, HPIMPDEBPJM LPBDLNEBGJC, string KPDCODMGEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3C50", Offset = "0x1FA2E50", VA = "0x181FA3C50", Slot = "8")]
	[AsyncStateMachine(typeof(GNODNFEDBFO))]
	protected override Task INPCKNMIDAH(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class MJCPBGNMMKA : HKOFBELAHPL
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class EIOFFLIIBEO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public EIOFFLIIBEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<CDEHMDAHGPA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			private TaskAwaiter<KHKCMDHCAIC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x1FAAFC0", Offset = "0x1FAA1C0", VA = "0x181FAAFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB390", Offset = "0x1FAA590", VA = "0x181FAB390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public MJCPBGNMMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public LAMCCOIKBJN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public PKJKEDPEIGG uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EIOFFLIIBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F96240", Offset = "0x1F95440", VA = "0x181F96240")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KHKCMDHCAIC> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct MMGDFBELDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public MJCPBGNMMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private EIOFFLIIBEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private EBNFCAKGABN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private LHHCINGHFAK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1310", Offset = "0x1FA0510", VA = "0x181FA1310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly int KGBPOBGNANK;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0A00", Offset = "0x1F9FC00", VA = "0x181FA0A00")]
	public MJCPBGNMMKA(Guid GCECPKLIDBO, JDEEGONKAHJ DBHAEMIDIKE, int KGBPOBGNANK, HPIMPDEBPJM LPBDLNEBGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA05E0", Offset = "0x1F9F7E0", VA = "0x181FA05E0", Slot = "9")]
	[AsyncStateMachine(typeof(MMGDFBELDBE))]
	protected override Task DJPLDLNFCBF(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0720", Offset = "0x1F9F920", VA = "0x181FA0720")]
	private void KPNKBMMOAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0820", Offset = "0x1F9FA20", VA = "0x181FA0820")]
	private void LKBBKPBNEDD(FGDOGDEIJDO LILIKHLPHEJ, EBNFCAKGABN LMOJFFGMOAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal abstract class EJHEDDGAKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public readonly BOGCNIBCKJK IHEBPKNAMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public readonly FBACHMNJFOB BDMBNGBOJHD;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E720", Offset = "0x1A0D920", VA = "0x181A0E720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E770", Offset = "0x1A0D970", VA = "0x181A0E770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E840", Offset = "0x1A0DA40", VA = "0x181A0E840")]
	protected EJHEDDGAKBA(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E800", Offset = "0x1A0DA00", VA = "0x181A0E800")]
	protected void HNLGNJKEDAI(string IAAMJPOLNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E820", Offset = "0x1A0DA20", VA = "0x181A0E820")]
	public void HNLGNJKEDAI(Func<string> COJCOOBIFLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal struct NCAAAPLKADP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public Dictionary<Guid, List<APPDHGBJELC>> MOEEPAOAOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public Dictionary<Guid, List<APPDHGBJELC>> JHGCBKJJKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public Dictionary<Guid, List<APPDHGBJELC>> AHJILEGJEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public List<Guid> DGFKKDACFAM;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2510", Offset = "0x1FA1710", VA = "0x181FA2510")]
	public static NCAAAPLKADP DCCAFIHBGKB(OCJFFCBIIPG FJHGBCNEILF, EIPDJAFCLDD KJHGEHLGGOI, FJGNCHMKJML HCNIPBCHCLM)
	{
		return default(NCAAAPLKADP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal struct HEDPGFCLNPD
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0")]
	public static HEDPGFCLNPD EJKEJHFJNHJ()
	{
		return default(HEDPGFCLNPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void DGIOALKDMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PNCBFBJBLCB(FJGNCHMKJML NJOKIDJGNHA, object NFBCEPEJLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void ADLDDKLLGAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct OMENMBHFAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public readonly HFBMBACFDEJ GFOIMLAOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly ALKBFOJPDKK MGDJMOJCPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly HHMGECIMHGB AIEIIGEMIMC;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2360D90", Offset = "0x235FF90", VA = "0x182360D90")]
	public OMENMBHFAPH(HFBMBACFDEJ GFOIMLAOIKA, ALKBFOJPDKK MGDJMOJCPIP, HHMGECIMHGB AIEIIGEMIMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal struct OPKKELOMKAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly FBACHMNJFOB AIPOFLNGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly Guid KIICCCAKINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private bool CCJACBLKPGH;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4F14920", Offset = "0x4F13B20", VA = "0x184F14920")]
	public static OPKKELOMKAE JGLILLHLLLL(FBACHMNJFOB AIPOFLNGDCJ)
	{
		return default(OPKKELOMKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x911BC0", Offset = "0x910DC0", VA = "0x180911BC0")]
	public void NACBGCCHENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x4F148C0", Offset = "0x4F13AC0", VA = "0x184F148C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x4F14A30", Offset = "0x4F13C30", VA = "0x184F14A30")]
	private OPKKELOMKAE(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x4F148C0", Offset = "0x4F13AC0", VA = "0x184F148C0")]
	private void BIAOBLFANCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4F14980", Offset = "0x4F13B80", VA = "0x184F14980")]
	private Func<Guid, bool> OFKJCEPILFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class LHHCINGHFAK : EJHEDDGAKBA, MPHPFDHGHKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public delegate Task<EIPDJAFCLDD> OFHKHJJBEFG(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI KHGFOGACIOF, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct DOMENNKPAKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public POLMFGONIBA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private OPKKELOMKAE <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1F952F0", Offset = "0x1F944F0", VA = "0x181F952F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct KKPIPMBJLEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public POLMFGONIBA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private FGDOGDEIJDO <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B6E0", Offset = "0x1F9A8E0", VA = "0x181F9B6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B990", Offset = "0x1F9AB90", VA = "0x181F9B990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct DDLFPCAHMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public POLMFGONIBA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private FGDOGDEIJDO <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1F94D70", Offset = "0x1F93F70", VA = "0x181F94D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct JPKCBNFGPMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public POLMFGONIBA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private FJGNCHMKJML <phaseArgs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<OMENMBHFAPH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private TaskAwaiter<FJGNCHMKJML> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private IPCKBPHFABI <timedYielder>5__3;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A330", Offset = "0x1F99530", VA = "0x181F9A330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct FNLMMPJBFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1F97070", Offset = "0x1F96270", VA = "0x181F97070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct EGOCEENAGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private FGDOGDEIJDO <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1F959B0", Offset = "0x1F94BB0", VA = "0x181F959B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct PNBJAGCGKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private FGDOGDEIJDO <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private DJMBGPOEJLL.LIDKPFMOAEM <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter<DJMBGPOEJLL.LIDKPFMOAEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9D30", Offset = "0x1FA8F30", VA = "0x181FA9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAA50", Offset = "0x1FA9C50", VA = "0x181FAAA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct MBEHLHEJGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public IPCKBPHFABI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private FGDOGDEIJDO <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9F010", Offset = "0x1F9E210", VA = "0x181F9F010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1F9FAB0", Offset = "0x1F9ECB0", VA = "0x181F9FAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct PJJAPIDGOPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public EIPDJAFCLDD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public FJGNCHMKJML deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9A80", Offset = "0x1FA8C80", VA = "0x181FA9A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9CE0", Offset = "0x1FA8EE0", VA = "0x181FA9CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class COAPFGMMKEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public OFHKHJJBEFG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public IPCKBPHFABI timedYielder;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public COAPFGMMKEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class ECANEDPJLEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public ECANEDPJLEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			private TaskAwaiter<EIPDJAFCLDD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x1FAAAA0", Offset = "0x1FA9CA0", VA = "0x181FAAAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x1FAAF70", Offset = "0x1FAA170", VA = "0x181FAAF70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public EIPDJAFCLDD originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public COAPFGMMKEI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ECANEDPJLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1F95880", Offset = "0x1F94A80", VA = "0x181F95880")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<EIPDJAFCLDD> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct GGMHDHCHAKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public OFHKHJJBEFG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public IPCKBPHFABI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1F977E0", Offset = "0x1F969E0", VA = "0x181F977E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1F97BF0", Offset = "0x1F96DF0", VA = "0x181F97BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct EKHPPAFEICN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private EIPDJAFCLDD <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private IEnumerator<EIPDJAFCLDD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1F963E0", Offset = "0x1F955E0", VA = "0x181F963E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct GENKGFNMDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1F97620", Offset = "0x1F96820", VA = "0x181F97620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct DEBDLGNFMEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public AsyncTaskMethodBuilder<DJMBGPOEJLL.LIDKPFMOAEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public LHHCINGHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private TaskAwaiter<DJMBGPOEJLL.LIDKPFMOAEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1F950B0", Offset = "0x1F942B0", VA = "0x181F950B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1F95240", Offset = "0x1F94440", VA = "0x181F95240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EIBFKDOANOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public HFBMBACFDEJ roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EIBFKDOANOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1F95FD0", Offset = "0x1F951D0", VA = "0x181F95FD0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private static readonly EIPDJAFCLDD[] ECLNIEOFKKG;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private static readonly int ANLKBJNEFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private readonly MNFFEBPEFEE DNKAIHIFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private readonly MNFFEBPEFEE KJMOCPLLCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private readonly EECAHPCGHOC GMEHMFPLCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private readonly BPNIKKCMPJN JOHNAEDJEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private readonly BELMIHKACHO LPOEKIDIMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private readonly ODJOGAELAPJ EJODPOBENIN;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float NCCMJIGDDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1A084C0", Offset = "0x1A076C0", VA = "0x181A084C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private JDEEGONKAHJ NELOPCBAGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C240", Offset = "0x1F9B440", VA = "0x181F9C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event NHHCJIKBFMB IIEGPOMACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1A08560", Offset = "0x1A07760", VA = "0x181A08560", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1A08580", Offset = "0x1A07780", VA = "0x181A08580", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DA10", Offset = "0x1F9CC10", VA = "0x181F9DA10")]
	public LHHCINGHFAK(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CB90", Offset = "0x1F9BD90", VA = "0x181F9CB90")]
	[AsyncStateMachine(typeof(DOMENNKPAKF))]
	public Task EKACKHLKFIA(POLMFGONIBA JENMNBIOPFE, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C8B0", Offset = "0x1F9BAB0", VA = "0x181F9C8B0")]
	[AsyncStateMachine(typeof(KKPIPMBJLEO))]
	private Task<KHKCMDHCAIC> DLNKGCMLLND(POLMFGONIBA JENMNBIOPFE, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C270", Offset = "0x1F9B470", VA = "0x181F9C270")]
	[AsyncStateMachine(typeof(DDLFPCAHMFG))]
	private Task AMICNEDEBKK(POLMFGONIBA JENMNBIOPFE, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CE50", Offset = "0x1F9C050", VA = "0x181F9CE50")]
	[AsyncStateMachine(typeof(JPKCBNFGPMB))]
	private Task HLJLIHFOJKC(POLMFGONIBA JENMNBIOPFE, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C690", Offset = "0x1F9B890", VA = "0x181F9C690")]
	[AsyncStateMachine(typeof(FNLMMPJBFHJ))]
	private Task CEAIAKOHOMD(FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D640", Offset = "0x1F9C840", VA = "0x181F9D640")]
	[AsyncStateMachine(typeof(EGOCEENAGEC))]
	private Task NAPCMKPGLIA(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D250", Offset = "0x1F9C450", VA = "0x181F9D250")]
	[AsyncStateMachine(typeof(PNBJAGCGKBK))]
	private Task<EIPDJAFCLDD> KDLFGFHEGHG(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D7B0", Offset = "0x1F9C9B0", VA = "0x181F9D7B0")]
	[AsyncStateMachine(typeof(MBEHLHEJGOP))]
	private Task<EIPDJAFCLDD> PLOHJJBINNJ(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CA30", Offset = "0x1F9BC30", VA = "0x181F9CA30")]
	[AsyncStateMachine(typeof(PJJAPIDGOPG))]
	private Task<EIPDJAFCLDD> EDMOHKGOEKL(EIPDJAFCLDD KJHGEHLGGOI, FJGNCHMKJML HCNIPBCHCLM, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC, bool HFPALBBPMDJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C7C0", Offset = "0x1F9B9C0", VA = "0x181F9C7C0")]
	private bool CMFHKKKECMC(FJGNCHMKJML HGPGMDBMCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CF90", Offset = "0x1F9C190", VA = "0x181F9CF90")]
	[AsyncStateMachine(typeof(GGMHDHCHAKO))]
	protected Task<EIPDJAFCLDD> IHLPDBPMIKL(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC, OFHKHJJBEFG AKGIFJBBJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D390", Offset = "0x1F9C590", VA = "0x181F9D390")]
	[AsyncStateMachine(typeof(EKHPPAFEICN))]
	private Task KKEIPKOODCE(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D530", Offset = "0x1F9C730", VA = "0x181F9D530")]
	private void LJMJFKGANNH(EIPDJAFCLDD GLKCLCKFBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D4F0", Offset = "0x1F9C6F0", VA = "0x181F9D4F0")]
	private Task<OMENMBHFAPH> LFBKMHEEKKJ(POLMFGONIBA JENMNBIOPFE, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C650", Offset = "0x1F9B850", VA = "0x181F9C650")]
	private Task<FJGNCHMKJML> BOPBFAGBHMI(POLMFGONIBA JENMNBIOPFE, OMENMBHFAPH NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CCD0", Offset = "0x1F9BED0", VA = "0x181F9CCD0")]
	[AsyncStateMachine(typeof(GENKGFNMDOP))]
	private Task FFCHPMJIHBE(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C3C0", Offset = "0x1F9B5C0", VA = "0x181F9C3C0")]
	[AsyncStateMachine(typeof(DEBDLGNFMEI))]
	private Task<DJMBGPOEJLL.LIDKPFMOAEM> BBGELJIIBAN(FJGNCHMKJML NJOKIDJGNHA, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D780", Offset = "0x1F9C980", VA = "0x181F9D780")]
	private Task PCDGILDINMJ(FJGNCHMKJML NJOKIDJGNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C4F0", Offset = "0x1F9B6F0", VA = "0x181F9C4F0")]
	private Task BEOLEAFKGPP(FJGNCHMKJML NJOKIDJGNHA, DJMBGPOEJLL.LIDKPFMOAEM FNKLHBLKOCF, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CA10", Offset = "0x1F9BC10", VA = "0x181F9CA10")]
	private Task ECCDFBGNDIG(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D4D0", Offset = "0x1F9C6D0", VA = "0x181F9D4D0")]
	private Task KNOELDLCOFD(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CE20", Offset = "0x1F9C020", VA = "0x181F9CE20")]
	private static Task GCMGNOJKMBI(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D230", Offset = "0x1F9C430", VA = "0x181F9D230")]
	private Task KBOODFNCFHK(FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CE30", Offset = "0x1F9C030", VA = "0x181F9CE30")]
	private Task GNPNEIOOKMJ(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D610", Offset = "0x1F9C810", VA = "0x181F9D610")]
	private void MPBILAEACII(POLMFGONIBA JENMNBIOPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D100", Offset = "0x1F9C300", VA = "0x181F9D100")]
	private static void IKMFEONJLDF(HFBMBACFDEJ GFOIMLAOIKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal struct DJMBGPOEJLL
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public struct LIDKPFMOAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public readonly Dictionary<int, int> FNABHABJGGK;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40")]
		public LIDKPFMOAEM(Dictionary<int, int> FNABHABJGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private EIPDJAFCLDD GLKCLCKFBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private FJGNCHMKJML NJOKIDJGNHA;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C1E0", Offset = "0x1A0B3E0", VA = "0x181A0C1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C230", Offset = "0x1A0B430", VA = "0x181A0C230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C2B0", Offset = "0x1A0B4B0", VA = "0x181A0C2B0")]
	public static Task<LIDKPFMOAEM> KIALENPBJIJ(JDEEGONKAHJ DBHAEMIDIKE, EIPDJAFCLDD GLKCLCKFBAO, FJGNCHMKJML NJOKIDJGNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C360", Offset = "0x1A0B560", VA = "0x181A0C360")]
	private LIDKPFMOAEM KIALENPBJIJ()
	{
		return default(LIDKPFMOAEM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal struct ADJMEPEABAO
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1A02030", Offset = "0x1A01230", VA = "0x181A02030")]
	public static Task KIALENPBJIJ(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal struct EDOHDHGJOPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct PBMHBJAOIAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private FGDOGDEIJDO <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B7A0", Offset = "0x1A1A9A0", VA = "0x181A1B7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1A0D7C0", Offset = "0x1A0C9C0", VA = "0x181A0D7C0")]
	[AsyncStateMachine(typeof(PBMHBJAOIAI))]
	public static Task KIALENPBJIJ(FBACHMNJFOB AIPOFLNGDCJ, FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal struct OMCFHPEMFHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct BIEPPCHLFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public IPCKBPHFABI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private EIPDJAFCLDD <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private JDEEGONKAHJ <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private OCJFFCBIIPG <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private List<(PersistenceView, MKKGOFGHCNA)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private MKKGOFGHCNA <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x4F12970", Offset = "0x4F11B70", VA = "0x184F12970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4F14450", Offset = "0x4F13650", VA = "0x184F14450")]
	[AsyncStateMachine(typeof(BIEPPCHLFFC))]
	public static Task KIALENPBJIJ(FBACHMNJFOB AIPOFLNGDCJ, FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x4F145C0", Offset = "0x4F137C0", VA = "0x184F145C0")]
	private static void PJOIEHOPFHE(PersistenceView KHMMEKDHDLG, MKKGOFGHCNA NFBCEPEJLHF, FJGNCHMKJML NJOKIDJGNHA, EIPDJAFCLDD KJHGEHLGGOI, bool IPGFANIJAGE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct GEOAHDEHHGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDE80", Offset = "0x1DDD080", VA = "0x181DDDE80")]
	public static Task KIALENPBJIJ(JDEEGONKAHJ DBHAEMIDIKE, FJGNCHMKJML NJOKIDJGNHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct AIADFELKOLO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct JKCKHKFCFAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public JDEEGONKAHJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public EIPDJAFCLDD roomOperationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1A17160", Offset = "0x1A16360", VA = "0x181A17160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct AEIBANIADOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AIADFELKOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1A02120", Offset = "0x1A01320", VA = "0x181A02120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class HJDMCKJAMDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public PGGGEMCDEKK version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HJDMCKJAMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1A160A0", Offset = "0x1A152A0", VA = "0x181A160A0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1A16150", Offset = "0x1A15350", VA = "0x181A16150")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private EIPDJAFCLDD GLKCLCKFBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private FJGNCHMKJML NJOKIDJGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private FBACHMNJFOB AIPOFLNGDCJ;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private static readonly ByteString OJOMMLOBJJC;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1A02F30", Offset = "0x1A02130", VA = "0x181A02F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private HEPLBMFCPAI GAEJCPPICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1A02F80", Offset = "0x1A02180", VA = "0x181A02F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x1A03600", Offset = "0x1A02800", VA = "0x181A03600")]
	[AsyncStateMachine(typeof(JKCKHKFCFAM))]
	public static Task KIALENPBJIJ(JDEEGONKAHJ DBHAEMIDIKE, EIPDJAFCLDD GLKCLCKFBAO, FJGNCHMKJML NJOKIDJGNHA, FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1A03760", Offset = "0x1A02960", VA = "0x181A03760")]
	[AsyncStateMachine(typeof(AEIBANIADOB))]
	private Task KIALENPBJIJ(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1A03030", Offset = "0x1A02230", VA = "0x181A03030")]
	private void KBOBLPMGPBE([NotNull] ANCBHLCGJKP FMNNHLIFLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1A03000", Offset = "0x1A02200", VA = "0x181A03000")]
	private bool JJAOCCOFGLO(PGGGEMCDEKK OJGBBKPGNFB, ANCBHLCGJKP FMNNHLIFLHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct ALFCELMJKJO
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private struct BMIMNMFNMBM<Arg, Parsed> where Parsed : IMessage<Parsed>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private readonly global::IBKLBGGJHMG<Arg> EJCKAOKPKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly global::APHHOCPMJHL<Parsed> FKHGEOJLPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly global::IAIDIDHKGON<Parsed> BDEJNCOAFFF;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x570E10", Offset = "0x570010", VA = "0x180570E10")]
		public BMIMNMFNMBM(global::IBKLBGGJHMG<Arg> EJCKAOKPKMF, global::APHHOCPMJHL<Parsed> FKHGEOJLPLJ, global::IAIDIDHKGON<Parsed> BDEJNCOAFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2ECEF10", Offset = "0x2ECE110", VA = "0x182ECEF10")]
		[AsyncStateMachine(typeof(ENIPKODHBFF))]
		public Task<Parsed> EHNKALDILAA(Arg OEDMLNBLEKI, string OCCIPBFNECI, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2ECFB60", Offset = "0x2ECED60", VA = "0x182ECFB60")]
		[AsyncStateMachine(typeof(EMOPKJFCIHC))]
		private Task<byte[]> JOIEFFFLAJB(Arg OEDMLNBLEKI, CancellationToken MNPKHBAPNDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2ECF6C0", Offset = "0x2ECE8C0", VA = "0x182ECF6C0")]
		private Parsed JFKENGBNECE(byte[] IDHELADFLIP)
		{
			return (Parsed)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct OMBLJOPHKGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder<FJGNCHMKJML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public ALFCELMJKJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private FGDOGDEIJDO <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<(ANCBHLCGJKP, LANHDAOGFLE, ONAOLCFCAGJ)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1A1A660", Offset = "0x1A19860", VA = "0x181A1A660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1A1ACE0", Offset = "0x1A19EE0", VA = "0x181A1ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private BMIMNMFNMBM<LEDBOJAOMNI, ANCBHLCGJKP> MGDJMOJCPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private BMIMNMFNMBM<LEDBOJAOMNI, LANHDAOGFLE> JLBAOCPLGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private BMIMNMFNMBM<long, ONAOLCFCAGJ> HJOAIPJMMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private POLMFGONIBA JENMNBIOPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private HFBMBACFDEJ GFOIMLAOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private ALKBFOJPDKK GOAHPBLIHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private FGDOGDEIJDO IDJNPLHMMHL;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1A04010", Offset = "0x1A03210", VA = "0x181A04010")]
	public static Task<FJGNCHMKJML> KKIMKIBOMLP(JDEEGONKAHJ DBHAEMIDIKE, POLMFGONIBA JENMNBIOPFE, in OMENMBHFAPH NJOKIDJGNHA, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1A03E90", Offset = "0x1A03090", VA = "0x181A03E90")]
	[AsyncStateMachine(typeof(OMBLJOPHKGJ))]
	private Task<FJGNCHMKJML> KIALENPBJIJ(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1A03E50", Offset = "0x1A03050", VA = "0x181A03E50")]
	private LEDBOJAOMNI ACECFAPNHDG(CODJJIKMNKI BDPEDKKCPKB)
	{
		return default(LEDBOJAOMNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct JHHNKFBHLCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct AGHCEAECCKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder<OMENMBHFAPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public JHHNKFBHLCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private FGDOGDEIJDO <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<OMENMBHFAPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7950", Offset = "0x1DD6B50", VA = "0x181DD7950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7D10", Offset = "0x1DD6F10", VA = "0x181DD7D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct IKOFNEKJAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder<OMENMBHFAPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public JHHNKFBHLCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<OMENMBHFAPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5310", Offset = "0x1DE4510", VA = "0x181DE5310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE55F0", Offset = "0x1DE47F0", VA = "0x181DE55F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class FMHOKBNNLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public FMHOKBNNLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x993470", Offset = "0x992670", VA = "0x180993470")]
		internal bool <FetchRoomDetails>b__0(ALKBFOJPDKK sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct DDNAJAAALLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<OMENMBHFAPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public OCJFFCBIIPG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private FMHOKBNNLDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter<HFBMBACFDEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8E80", Offset = "0x1DD8080", VA = "0x181DD8E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD92C0", Offset = "0x1DD84C0", VA = "0x181DD92C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private EECAHPCGHOC GMEHMFPLCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private FGDOGDEIJDO IDJNPLHMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private long FMLOJIDJGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private long OCLLLDFCOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private LEDBOJAOMNI MDOKLLEPHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private LEDBOJAOMNI LKFICAHFHLF;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6CD0", Offset = "0x1DE5ED0", VA = "0x181DE6CD0")]
	public static Task<OMENMBHFAPH> KKIMKIBOMLP(JDEEGONKAHJ DBHAEMIDIKE, POLMFGONIBA JENMNBIOPFE, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6B80", Offset = "0x1DE5D80", VA = "0x181DE6B80")]
	[AsyncStateMachine(typeof(AGHCEAECCKK))]
	private Task<OMENMBHFAPH> KIALENPBJIJ(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7190", Offset = "0x1DE6390", VA = "0x181DE7190")]
	[AsyncStateMachine(typeof(IKOFNEKJAIB))]
	private Task<OMENMBHFAPH> LFBKMHEEKKJ(long FMLOJIDJGBJ, long OCLLLDFCOAB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC, bool GJFGBFCHJBA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7040", Offset = "0x1DE6240", VA = "0x181DE7040")]
	[AsyncStateMachine(typeof(DDNAJAAALLM))]
	public static Task<OMENMBHFAPH> LFBKMHEEKKJ(OCJFFCBIIPG FJHGBCNEILF, long FMLOJIDJGBJ, long OCLLLDFCOAB, CancellationToken MNPKHBAPNDC, FGDOGDEIJDO LILIKHLPHEJ, bool GJFGBFCHJBA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7310", Offset = "0x1DE6510", VA = "0x181DE7310")]
	private void LMHAJHCLFKP(HFBMBACFDEJ GFOIMLAOIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6A40", Offset = "0x1DE5C40", VA = "0x181DE6A40")]
	private bool KGDFCDBJLPK(OMENMBHFAPH NJOKIDJGNHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6EE0", Offset = "0x1DE60E0", VA = "0x181DE6EE0")]
	private void LFBGKBANLKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct AHFPJBDMDKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct HGHLONOBKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public AHFPJBDMDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x1A15D60", Offset = "0x1A14F60", VA = "0x181A15D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private const int KJMDLOCEAOO = 20;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private const float BMHOLMMOPPJ = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private OCJFFCBIIPG FJHGBCNEILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private FJGNCHMKJML NJOKIDJGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private FGDOGDEIJDO IDJNPLHMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	private float LIDFICAHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private float AKNIFEKKJAM;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x1A02D80", Offset = "0x1A01F80", VA = "0x181A02D80")]
	public static Task NJMHAGILHKJ(JDEEGONKAHJ DBHAEMIDIKE, FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1A02C60", Offset = "0x1A01E60", VA = "0x181A02C60")]
	[AsyncStateMachine(typeof(HGHLONOBKMI))]
	public Task KIALENPBJIJ(CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1A02AF0", Offset = "0x1A01CF0", VA = "0x181A02AF0")]
	private static void GBALPINNBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x1A02950", Offset = "0x1A01B50", VA = "0x181A02950")]
	private void ENPIKEJLJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1A02890", Offset = "0x1A01A90", VA = "0x181A02890")]
	private static float ACNCEJNKNKC(OCJFFCBIIPG FJHGBCNEILF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1A02AD0", Offset = "0x1A01CD0", VA = "0x181A02AD0")]
	private static float FFGEMNEDDCE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct LCFJFDFECHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct HAMHDGMOMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public FBACHMNJFOB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public DJMBGPOEJLL.LIDKPFMOAEM mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private BOGCNIBCKJK <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private JDEEGONKAHJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private ENLNHJPFLIH.HLGNJKNBMOM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x1F980D0", Offset = "0x1F972D0", VA = "0x181F980D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct KGAGEDICIGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private AJAEEJMDOEF.EDBJKHPBALA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B470", Offset = "0x1F9A670", VA = "0x181F9B470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C0E0", Offset = "0x1F9B2E0", VA = "0x181F9C0E0")]
	[AsyncStateMachine(typeof(HAMHDGMOMOM))]
	public static Task KIALENPBJIJ(FBACHMNJFOB AIPOFLNGDCJ, FJGNCHMKJML NJOKIDJGNHA, DJMBGPOEJLL.LIDKPFMOAEM FNKLHBLKOCF, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C070", Offset = "0x1F9B270", VA = "0x181F9C070")]
	private static Task<KHKCMDHCAIC> GGCLJNFIKED(FBACHMNJFOB AIPOFLNGDCJ, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BF90", Offset = "0x1F9B190", VA = "0x181F9BF90")]
	[AsyncStateMachine(typeof(KGAGEDICIGA))]
	private static Task ECKAJGAKDJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct EJKKHDIIICI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct GLOKAMNPPGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public EJKKHDIIICI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1A15150", Offset = "0x1A14350", VA = "0x181A15150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class PEHPKFOEDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PEHPKFOEDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1A1BCF0", Offset = "0x1A1AEF0", VA = "0x181A1BCF0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct ILMFHJNPPDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public EJKKHDIIICI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private PDIJMFMFLDN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x1A16270", Offset = "0x1A15470", VA = "0x181A16270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private bool COJBFEAKNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private FGDOGDEIJDO IDJNPLHMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private CancellationToken MNPKHBAPNDC;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E9D0", Offset = "0x1A0DBD0", VA = "0x181A0E9D0")]
	public static Task DMGJEMOFIJA(JDEEGONKAHJ DBHAEMIDIKE, bool COJBFEAKNNF, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken CJNBEHPOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1A0EA50", Offset = "0x1A0DC50", VA = "0x181A0EA50")]
	[AsyncStateMachine(typeof(GLOKAMNPPGD))]
	private Task KIALENPBJIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E8A0", Offset = "0x1A0DAA0", VA = "0x181A0E8A0")]
	[AsyncStateMachine(typeof(ILMFHJNPPDD))]
	private Task AMIIIHKJCMC(bool DJBGPPONGOA, string KLKHHNNELKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x5749E0", VA = "0x1805757E0")]
	private bool PIOFGKCMMID(bool COJBFEAKNNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct NMEHKLAOIDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct ICGIGCKNPEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NMEHKLAOIDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1F98810", Offset = "0x1F97A10", VA = "0x181F98810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class OKGDMAOBNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public OKGDMAOBNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8750", Offset = "0x1FA7950", VA = "0x181FA8750")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct FIFDMPFIAJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NMEHKLAOIDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private PDIJMFMFLDN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1F967C0", Offset = "0x1F959C0", VA = "0x181F967C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private HHMGECIMHGB KNHMHFCHCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private bool COJBFEAKNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private FGDOGDEIJDO IDJNPLHMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3F40", Offset = "0x1FA3140", VA = "0x181FA3F40")]
	public static Task GBNKCAHIKJO(JDEEGONKAHJ DBHAEMIDIKE, HHMGECIMHGB FEPFHEIMKMD, bool COJBFEAKNNF, FGDOGDEIJDO IDJNPLHMMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3FA0", Offset = "0x1FA31A0", VA = "0x181FA3FA0")]
	[AsyncStateMachine(typeof(ICGIGCKNPEP))]
	private Task KIALENPBJIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3E20", Offset = "0x1FA3020", VA = "0x181FA3E20")]
	[AsyncStateMachine(typeof(FIFDMPFIAJE))]
	private Task AMIIIHKJCMC(string KLKHHNNELKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct BELMIHKACHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct EMLEDEAIFJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public BELMIHKACHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public EIPDJAFCLDD nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public FJGNCHMKJML deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private FGDOGDEIJDO <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<EIPDJAFCLDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0EBF0", Offset = "0x1A0DDF0", VA = "0x181A0EBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F320", Offset = "0x1A0E520", VA = "0x181A0F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct OKIJEHJAEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder<EIPDJAFCLDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public BELMIHKACHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public EIPDJAFCLDD state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1A19AC0", Offset = "0x1A18CC0", VA = "0x181A19AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1A19CE0", Offset = "0x1A18EE0", VA = "0x181A19CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private readonly FBACHMNJFOB AIPOFLNGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private readonly EECAHPCGHOC GMEHMFPLCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private readonly BPNIKKCMPJN JOHNAEDJEPM;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private BOGCNIBCKJK IHEBPKNAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6CFB30", Offset = "0x6CED30", VA = "0x1806CFB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x1A05DF0", Offset = "0x1A04FF0", VA = "0x181A05DF0")]
	public BELMIHKACHO(FBACHMNJFOB AIPOFLNGDCJ, EECAHPCGHOC GMEHMFPLCIE, BPNIKKCMPJN JOHNAEDJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x1A05B00", Offset = "0x1A04D00", VA = "0x181A05B00")]
	[AsyncStateMachine(typeof(EMLEDEAIFJK))]
	public Task<EIPDJAFCLDD> KDBEJDOMMDB(EIPDJAFCLDD AMDKNELAIBE, FJGNCHMKJML HCNIPBCHCLM, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC, bool HFPALBBPMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x1A05C70", Offset = "0x1A04E70", VA = "0x181A05C70")]
	[AsyncStateMachine(typeof(OKIJEHJAEFC))]
	private Task<EIPDJAFCLDD> OBENDLIEBID(FGDOGDEIJDO LILIKHLPHEJ, EIPDJAFCLDD JFEOMJEBMNM, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x1A05DC0", Offset = "0x1A04FC0", VA = "0x181A05DC0")]
	private bool OEDGOMCPOGB(EIPDJAFCLDD OJOGHBMEAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1A05AE0", Offset = "0x1A04CE0", VA = "0x181A05AE0")]
	private void HNLGNJKEDAI(string IECHLGOLKCJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct PHMGLFGMDKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct LPDAKKNCLBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public BOGCNIBCKJK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public IPCKBPHFABI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private List<(PersistenceView, MKKGOFGHCNA)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private (PersistenceView, MKKGOFGHCNA) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x4F13EE0", Offset = "0x4F130E0", VA = "0x184F13EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F14D90", Offset = "0x4F13F90", VA = "0x184F14D90")]
	[AsyncStateMachine(typeof(LPDAKKNCLBP))]
	public static Task KIALENPBJIJ(BOGCNIBCKJK BIPINHFPINC, FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct JFAMANIFBAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct HGPEHGCDNPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public BOGCNIBCKJK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public IPCKBPHFABI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private PGGGEMCDEKK <version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private List<(PersistenceView, MKKGOFGHCNA)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private MKKGOFGHCNA <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1120", VA = "0x181DE1F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5E20", Offset = "0x1DE5020", VA = "0x181DE5E20")]
	[AsyncStateMachine(typeof(HGPEHGCDNPA))]
	public static Task KIALENPBJIJ(BOGCNIBCKJK BIPINHFPINC, FJGNCHMKJML NJOKIDJGNHA, IPCKBPHFABI FBPODDKABGB, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct ENLNHJPFLIH
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public struct HLGNJKNBMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public List<OJDJLJMCGJK> OHNPGFOAHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public List<MKKGOFGHCNA> FCADIELFLMO;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5710A0", Offset = "0x5702A0", VA = "0x1805710A0")]
		public HLGNJKNBMOM(List<OJDJLJMCGJK> OHNPGFOAHCL, List<MKKGOFGHCNA> FCADIELFLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class ECDGNBILGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public List<OJDJLJMCGJK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ECDGNBILGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D750", Offset = "0x1A0C950", VA = "0x181A0D750")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private JDEEGONKAHJ DBHAEMIDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private FJGNCHMKJML NJOKIDJGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private DJMBGPOEJLL.LIDKPFMOAEM FNKLHBLKOCF;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private OCJFFCBIIPG GIKPPHGDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F5D0", Offset = "0x1A0E7D0", VA = "0x181A0F5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A10150", Offset = "0x1A0F350", VA = "0x181A10150")]
	public static HLGNJKNBMOM KIALENPBJIJ(JDEEGONKAHJ DBHAEMIDIKE, FJGNCHMKJML NJOKIDJGNHA, DJMBGPOEJLL.LIDKPFMOAEM FNKLHBLKOCF)
	{
		return default(HLGNJKNBMOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FF10", Offset = "0x1A0F110", VA = "0x181A0FF10")]
	private HLGNJKNBMOM KIALENPBJIJ()
	{
		return default(HLGNJKNBMOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FA60", Offset = "0x1A0EC60", VA = "0x181A0FA60")]
	private HLGNJKNBMOM HBOCOANCPLL(ANCBHLCGJKP FMNNHLIFLHO, PGGGEMCDEKK EMJJCPBBPDM, Dictionary<int, int> GFIFDHDPJHE)
	{
		return default(HLGNJKNBMOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F620", Offset = "0x1A0E820", VA = "0x181A0F620")]
	private GameObject[] ELFMKAECNNG(List<OJDJLJMCGJK> OHNPGFOAHCL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal struct LBGCFKHHAAF
{
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class HPHANJHCGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public ENLNHJPFLIH.HLGNJKNBMOM instantiations;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HPHANJHCGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F98790", Offset = "0x1F97990", VA = "0x181F98790")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class ILFNNPIKBLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ILFNNPIKBLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F99130", Offset = "0x1F98330", VA = "0x181F99130")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BA40", Offset = "0x1F9AC40", VA = "0x181F9BA40")]
	public static void KIALENPBJIJ(BOGCNIBCKJK BIPINHFPINC, FJGNCHMKJML NJOKIDJGNHA, ENLNHJPFLIH.HLGNJKNBMOM KCKEEDPMGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class BPNIKKCMPJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct KKAMIKNLDDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public EIPDJAFCLDD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public FJGNCHMKJML deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1A178F0", Offset = "0x1A16AF0", VA = "0x181A178F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class MKEGKPJGPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MKEGKPJGPMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class DMOCFBIGNFO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public DMOCFBIGNFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x1A1BF10", Offset = "0x1A1B110", VA = "0x181A1BF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public FGDOGDEIJDO handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public MKEGKPJGPMH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public DMOCFBIGNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D1E0", Offset = "0x1A0C3E0", VA = "0x181A0D1E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct FDDMCMMPLAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private DMOCFBIGNFO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A14050", Offset = "0x1A13250", VA = "0x181A14050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct OOBFNJMNNCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private Dictionary<Guid, List<APPDHGBJELC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x1A1AD30", Offset = "0x1A19F30", VA = "0x181A1AD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct BAKJDPPMFJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private FGDOGDEIJDO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private Dictionary<Guid, List<APPDHGBJELC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1A04B90", Offset = "0x1A03D90", VA = "0x181A04B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class ALBBLKKGHAB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public APPDHGBJELC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public ALBBLKKGHAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x1A1BDC0", Offset = "0x1A1AFC0", VA = "0x181A1BDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public GKIJCCJFIOK runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public List<APPDHGBJELC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ALBBLKKGHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x1A03BB0", Offset = "0x1A02DB0", VA = "0x181A03BB0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A03D30", Offset = "0x1A02F30", VA = "0x181A03D30")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(APPDHGBJELC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A03C70", Offset = "0x1A02E70", VA = "0x181A03C70")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct APNBJIBKEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public GKIJCCJFIOK runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public List<APPDHGBJELC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private ALBBLKKGHAB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x1A04730", Offset = "0x1A03930", VA = "0x181A04730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct JDFCDOIEBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public FGDOGDEIJDO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A16C00", Offset = "0x1A15E00", VA = "0x181A16C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class FMCOEMBGHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public FMCOEMBGHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1A14410", Offset = "0x1A13610", VA = "0x181A14410")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct GDGEHFGJDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public FJGNCHMKJML data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A148A0", Offset = "0x1A13AA0", VA = "0x181A148A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class GABDELJHLBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public GABDELJHLBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A14840", Offset = "0x1A13A40", VA = "0x181A14840")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct DFNANOMJECE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public BPNIKKCMPJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BCD0", Offset = "0x1A0AED0", VA = "0x181A0BCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class DHJGOCGCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public DHJGOCGCLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C180", Offset = "0x1A0B380", VA = "0x181A0C180")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private readonly FBACHMNJFOB AIPOFLNGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private NCAAAPLKADP JOHNAEDJEPM;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private BOGCNIBCKJK IHEBPKNAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD50", Offset = "0x5CBF50", VA = "0x1805CCD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B50", Offset = "0x5D3D50", VA = "0x1805D4B50")]
	public BPNIKKCMPJN(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1A09630", Offset = "0x1A08830", VA = "0x181A09630")]
	[AsyncStateMachine(typeof(KKAMIKNLDDC))]
	public Task KIALENPBJIJ(EIPDJAFCLDD KJHGEHLGGOI, FJGNCHMKJML HCNIPBCHCLM, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A08FB0", Offset = "0x1A081B0", VA = "0x181A08FB0")]
	[AsyncStateMachine(typeof(FDDMCMMPLAN))]
	private Task DMMMEMDDDFO(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A093B0", Offset = "0x1A085B0", VA = "0x181A093B0")]
	[AsyncStateMachine(typeof(OOBFNJMNNCC))]
	private Task HPBNHBCNEJH(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1A094F0", Offset = "0x1A086F0", VA = "0x181A094F0")]
	[AsyncStateMachine(typeof(BAKJDPPMFJE))]
	private Task KFHOHMAGGGE(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A09880", Offset = "0x1A08A80", VA = "0x181A09880")]
	[AsyncStateMachine(typeof(APNBJIBKEBH))]
	private Task MOBAPBIEPCB(Guid JPBEAIDONAB, List<APPDHGBJELC> KCDCGDJANEF, GKIJCCJFIOK ICFMOCDBHLA, FJGNCHMKJML NJOKIDJGNHA, CancellationToken OFCAAIDMNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A09270", Offset = "0x1A08470", VA = "0x181A09270")]
	[AsyncStateMachine(typeof(JDFCDOIEBEE))]
	private Task GFOJGPDJHFD(FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A08D30", Offset = "0x1A07F30", VA = "0x181A08D30")]
	[AsyncStateMachine(typeof(GDGEHFGJDBB))]
	private Task BIGDGJCCAHL(Guid IIBBBKKPJPE, FJGNCHMKJML NJOKIDJGNHA, FGDOGDEIJDO IDJNPLHMMHL, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1A08BE0", Offset = "0x1A07DE0", VA = "0x181A08BE0")]
	[AsyncStateMachine(typeof(DFNANOMJECE))]
	private Task AGCMMAHDPCE(Guid IIBBBKKPJPE, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A08E60", Offset = "0x1A08060", VA = "0x181A08E60")]
	private void BPEINCLPGOI(Guid IIBBBKKPJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A09790", Offset = "0x1A08990", VA = "0x181A09790")]
	private void MBLDMCKCAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A09100", Offset = "0x1A08300", VA = "0x181A09100")]
	[CompilerGenerated]
	private object DMNCIDFAPMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public struct CDEHMDAHGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public ANCBHLCGJKP EHEDPNNHDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public List<string> IPJDLHCEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<long, int> KECEJPGPHOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal class OJBCDGDFBBH : EJHEDDGAKBA
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class PPPPKOHOFCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public LLILGLIBBAK autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PPPPKOHOFCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class LKIKAIAPIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public PPPPKOHOFCD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public LKIKAIAPIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9EAB0", Offset = "0x1F9DCB0", VA = "0x181F9EAB0")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class ICNOAOKJMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public PPPPKOHOFCD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ICNOAOKJMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F98A90", Offset = "0x1F97C90", VA = "0x181F98A90")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class EJEMMCFNDAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public LLILGLIBBAK autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EJEMMCFNDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F96360", Offset = "0x1F95560", VA = "0x181F96360")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class FHMICDDBGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public FHMICDDBGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1F96780", Offset = "0x1F95980", VA = "0x181F96780")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class HBADEHDJODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public FileSystemInfo file;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public HBADEHDJODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1F986D0", Offset = "0x1F978D0", VA = "0x181F986D0")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class BAAPHGGAOAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BAAPHGGAOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1F931E0", Offset = "0x1F923E0", VA = "0x181F931E0")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private const string IBCDIAOGBCK = "V2";

	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private const int EGDGPCKHAPK = 5;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private const string COGJANOAHGH = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private const string ICHNIAAGCNC = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private const int BABENOPCBAK = 32;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8740", Offset = "0x1FA7940", VA = "0x181FA8740")]
	public OJBCDGDFBBH(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7DE0", Offset = "0x1FA6FE0", VA = "0x181FA7DE0")]
	public bool OOGKCIPOIML(long OCLLLDFCOAB, CDEHMDAHGPA MANBJEHGFJA, LLILGLIBBAK BCLLMCFINDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7950", Offset = "0x1FA6B50", VA = "0x181FA7950")]
	public static bool FPBDIIHAAMM(long OCLLLDFCOAB, LLILGLIBBAK BCLLMCFINDB, out FileInfo MGPNLDDOPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6F90", Offset = "0x1FA6190", VA = "0x181FA6F90")]
	public bool CLCHALMILII(long OCLLLDFCOAB, LLILGLIBBAK BCLLMCFINDB, out CDEHMDAHGPA MANBJEHGFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7470", Offset = "0x1FA6670", VA = "0x181FA7470")]
	private bool DPLPEAGPCPJ(FileInfo MGPNLDDOPCH, out byte[] JLIFMEBPNGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7A10", Offset = "0x1FA6C10", VA = "0x181FA7A10")]
	private static FileInfo FPLMIHIDCDP(long OCLLLDFCOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7B60", Offset = "0x1FA6D60", VA = "0x181FA7B60")]
	private static FileInfo OMEAHFCCLJG(long OCLLLDFCOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7AF0", Offset = "0x1FA6CF0", VA = "0x181FA7AF0")]
	private static DirectoryInfo MHNCHINPNLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6C10", Offset = "0x1FA5E10", VA = "0x181FA6C10")]
	private void AGMPCCGCHJF(FileInfo HJMKKIMPNPE, ANCBHLCGJKP PKMAOEIDLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8250", Offset = "0x1FA7450", VA = "0x181FA8250")]
	private void PLFEBINBMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7C30", Offset = "0x1FA6E30", VA = "0x181FA7C30")]
	public static void OMNEDABLIJA(long OCLLLDFCOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7400", Offset = "0x1FA6600", VA = "0x181FA7400")]
	public static bool DMHJLBJHIIE(long OCLLLDFCOAB, out DateTime JBINOKMLBIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal class LAMCCOIKBJN : EJHEDDGAKBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct FNKMEPNDANM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder<CDEHMDAHGPA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public LAMCCOIKBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public DCCFLOIJBLH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1F96C60", Offset = "0x1F95E60", VA = "0x181F96C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x1F97020", Offset = "0x1F96220", VA = "0x181F97020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class JIBFCLENAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public DCCFLOIJBLH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JIBFCLENAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A160", Offset = "0x1F99360", VA = "0x181F9A160")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class DMFKKCAEOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public JIBFCLENAFC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public DMFKKCAEOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x1F95290", Offset = "0x1F94490", VA = "0x181F95290")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class CFFEAJHMBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public JIBFCLENAFC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CFFEAJHMBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x1F944C0", Offset = "0x1F936C0", VA = "0x181F944C0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct JFCBBLCEKOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public DCCFLOIJBLH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public LAMCCOIKBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private DMFKKCAEOAB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private AJAEEJMDOEF.KPAIBGIJHAE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1F996D0", Offset = "0x1F988D0", VA = "0x181F996D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private readonly DNMCGDCBAOD KEBNCMOJEIH;

	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private static readonly TimeSpan MEDEIFMGFPI;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB8E0", Offset = "0x1DEAAE0", VA = "0x181DEB8E0")]
	public LAMCCOIKBJN(FBACHMNJFOB AIPOFLNGDCJ, [Optional] DNMCGDCBAOD? KEBNCMOJEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB730", Offset = "0x1DEA930", VA = "0x181DEB730")]
	[AsyncStateMachine(typeof(FNKMEPNDANM))]
	public Task<CDEHMDAHGPA> MNIJLJLODBL(long OCLLLDFCOAB, DCCFLOIJBLH LBADHINKFIE, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB010", Offset = "0x1DEA210", VA = "0x181DEB010")]
	[AsyncStateMachine(typeof(JFCBBLCEKOI))]
	private Task JGOAMIJAEMN(DCCFLOIJBLH LBADHINKFIE, IEnumerable<PersistenceView> AAJKCAIKAFD, StringBuilder DNFEIMFEGEO, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1DEABA0", Offset = "0x1DE9DA0", VA = "0x181DEABA0")]
	private CDEHMDAHGPA CNJCLPNBJPO(long OCLLLDFCOAB, DCCFLOIJBLH LBADHINKFIE, IEnumerable<PersistenceView> AAJKCAIKAFD, StringBuilder DNFEIMFEGEO)
	{
		return default(CDEHMDAHGPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB5F0", Offset = "0x1DEA7F0", VA = "0x181DEB5F0")]
	private ANCBHLCGJKP LEADDCBLGMM(long OCLLLDFCOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA9A0", Offset = "0x1DE9BA0", VA = "0x181DEA9A0")]
	private void CCBDPPHIOHA(ANCBHLCGJKP LEFGODBBIGA, StringBuilder DNFEIMFEGEO, IEnumerable<PersistenceView> AAJKCAIKAFD, in DCCPECAHECJ CGBOPPEDMPC, ref KFDNJKBEGGN BJILEKCJFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB160", Offset = "0x1DEA360", VA = "0x181DEB160")]
	private void LABJCCMGOLI(ANCBHLCGJKP LEFGODBBIGA, StringBuilder DNFEIMFEGEO, PersistenceView KHMMEKDHDLG, ref KFDNJKBEGGN BJILEKCJFKG, in DCCPECAHECJ CGBOPPEDMPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class PKJKEDPEIGG : EJHEDDGAKBA
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class AJKCGLGFPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public string roomMetadataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public string roomDataFilename;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public AJKCGLGFPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x4F12630", Offset = "0x4F11830", VA = "0x184F12630")]
		internal object <UploadRoomDataBlob>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x4F126B0", Offset = "0x4F118B0", VA = "0x184F126B0")]
		internal object <UploadRoomDataBlob>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x4F126F0", Offset = "0x4F118F0", VA = "0x184F126F0")]
		internal object <UploadRoomDataBlob>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x4F12760", Offset = "0x4F11960", VA = "0x184F12760")]
		internal object <UploadRoomDataBlob>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct KDJFJDLKJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<HFBMBACFDEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CDEHMDAHGPA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public PKJKEDPEIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private AJKCGLGFPLB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private TaskAwaiter<HFBMBACFDEJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x4F13410", Offset = "0x4F12610", VA = "0x184F13410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x4F13E90", Offset = "0x4F13090", VA = "0x184F13E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class GMLKPKCKPDG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public GMLKPKCKPDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private KHKCMDHCAIC <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private TaskAwaiter<HFBMBACFDEJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			private TaskAwaiter<KHKCMDHCAIC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x4F152C0", Offset = "0x4F144C0", VA = "0x184F152C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x4F15920", Offset = "0x4F14B20", VA = "0x184F15920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public PKJKEDPEIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public CDEHMDAHGPA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public GMLKPKCKPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x4F13060", Offset = "0x4F12260", VA = "0x184F13060")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KHKCMDHCAIC> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct JNFCOJPCLFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public AsyncTaskMethodBuilder<KHKCMDHCAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public PKJKEDPEIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public CDEHMDAHGPA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private TaskAwaiter<KHKCMDHCAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x4F13190", Offset = "0x4F12390", VA = "0x184F13190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x4F133C0", Offset = "0x4F125C0", VA = "0x184F133C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private const float HKECMDKPCCF = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly INGOFBPGNCL NEJNONMJLGP;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private JDEEGONKAHJ NELOPCBAGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C240", Offset = "0x1F9B440", VA = "0x181F9C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x4F15230", Offset = "0x4F14430", VA = "0x184F15230")]
	public PKJKEDPEIGG(FBACHMNJFOB AIPOFLNGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x4F150E0", Offset = "0x4F142E0", VA = "0x184F150E0")]
	[AsyncStateMachine(typeof(KDJFJDLKJCC))]
	public Task<HFBMBACFDEJ> OPBJNBGKGAL(int KGBPOBGNANK, CDEHMDAHGPA MANBJEHGFJA, long FMLOJIDJGBJ, long PCDLGIEJLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x4F14F70", Offset = "0x4F14170", VA = "0x184F14F70")]
	[AsyncStateMachine(typeof(JNFCOJPCLFK))]
	public Task<KHKCMDHCAIC> HKCPHEIFEFN(int KGBPOBGNANK, CDEHMDAHGPA MANBJEHGFJA, long FMLOJIDJGBJ, long PCDLGIEJLMB, FGDOGDEIJDO LILIKHLPHEJ, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
public class KEGADJFLAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly Guid GCECPKLIDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly BPPMEJGJJLO JJMDEGEECOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private POLMFGONIBA IMJFNGNMFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private int? HKOKCEDONAE;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Guid NDDICBGFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6457F0", Offset = "0x6449F0", VA = "0x1806457F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8BC0", Offset = "0x1DE7DC0", VA = "0x181DE8BC0")]
	public KEGADJFLAHK(BPPMEJGJJLO JJMDEGEECOP, [Optional] Guid? GCECPKLIDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8AD0", Offset = "0x1DE7CD0", VA = "0x181DE8AD0")]
	public KEGADJFLAHK BCMJIHIJIMK(POLMFGONIBA IMJFNGNMFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8AF0", Offset = "0x1DE7CF0", VA = "0x181DE8AF0")]
	public KHKCMDHCAIC NJBDGAFEFKA(out Guid LOJKJACHMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x1DE89E0", Offset = "0x1DE7BE0", VA = "0x181DE89E0")]
	public KEGADJFLAHK AGOCAEIGEHB(BFJNMOMPEEB POEEPLGAGME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
public static class JNFCMNCDFHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1DE81E0", Offset = "0x1DE73E0", VA = "0x181DE81E0")]
	public static LEDBOJAOMNI NEICLENAPJK(this CODJJIKMNKI BDPEDKKCPKB)
	{
		return default(LEDBOJAOMNI);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200015A")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public EDICNCKALMM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public EDICNCKALMM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private static EDICNCKALMM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private Dictionary<EDICNCKALMM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x4F15B50", Offset = "0x4F14D50", VA = "0x184F15B50")]
		public bool MPBOBOBADJP(EDICNCKALMM MAGLKDNMHEG, out ResultConfig JCGHEHOIPEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x4F15A60", Offset = "0x4F14C60", VA = "0x184F15A60")]
		public ResultConfig FBONAAKJMPH(EDICNCKALMM PFAHEGOAJJP, [Optional] HashSet<EDICNCKALMM> KNOAKEOJPMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x4F16070", Offset = "0x4F15270", VA = "0x184F16070", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x4F15BC0", Offset = "0x4F14DC0", VA = "0x184F15BC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x86B6D0", Offset = "0x86A8D0", VA = "0x18086B6D0")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD5F0", Offset = "0x1DDC7F0", VA = "0x181DDD5F0")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD6F0", Offset = "0x1DDC8F0", VA = "0x181DDD6F0")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
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
