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
public class NDECMJEDHEC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27B91A0", Offset = "0x27B79A0", VA = "0x1827B91A0")]
	public NDECMJEDHEC(string BOBNBIKICDK, Exception CPJFNIFMLAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface PPCBAHEPGPG : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GIBAEDGAJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task FKFLBELDNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLMGNJNEIMM(Task IIJNLEIHGNA, string JKKALDKDOGD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface NMFNMIBLNOE : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNKIHMBJEKG> NHOFGFAGGKD(GPHANIMPAPP FLBPMDDEMNL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ADCMAMNMLMA(CancellationToken OFMMACGDFGM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface PHONKPJMLDC : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IFJGNAONOGK HFGBACAGECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCAFLKBAFBD();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFJLDMELFOB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GFCHHGMICCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface DALMODJHJCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TimeSpan BCOEOLKLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan FIKPMILNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LCODBHCPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BHDIBPHGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FAHGHEACIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BFJGGCFIEPO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct COPJBADKNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long BJJCJOONKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long ICKOGPENBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly BFJGGCFIEPO LIBGCFIILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception FJNEKJBMLHE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26E4C70", Offset = "0x26E3470", VA = "0x1826E4C70")]
	public COPJBADKNJB(long BJJCJOONKLJ, long ICKOGPENBMF, BFJGGCFIEPO LIBGCFIILKM, [CanBeNull] Exception FJNEKJBMLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26E4C20", Offset = "0x26E3420", VA = "0x1826E4C20")]
	public static COPJBADKNJB BFCKDGNJCLO(GEKAFNAJGCN GBGEFBBJIAE, BFJGGCFIEPO LIBGCFIILKM, [Optional] Exception FJNEKJBMLHE)
	{
		return default(COPJBADKNJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void GLNOLJJJPFD(COPJBADKNJB PKKMHBCJEKF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface DDGMLKAFHGA : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GLNOLJJJPFD ALLFBAEIHBG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GLNOLJJJPFD AGEEOHJDPEK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GLNOLJJJPFD BKILNEOJJFC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLHCCNJFPEC(COPJBADKNJB PKKMHBCJEKF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPNHHJLHGEL(COPJBADKNJB PKKMHBCJEKF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MAHCINNBHOD(COPJBADKNJB PKKMHBCJEKF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface OAMFICOADFA : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MHJLEEGLFOF();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKANLBHADBD();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKJLLIEKCHM();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate Task DIDLAODPDJO(CJKDIAAFKFC IEJDKFIDFDN, CancellationToken FIGDHHNIEAN);
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal interface CGOHDDPHBOC : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MINIIIGOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool COHIMJAABPF(DIDLAODPDJO EINAEHCHCPM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface CNPEEDHHHPH : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	TaskStatus KOFKHBAAPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DJOPAFDEFBF(GEKAFNAJGCN JMMCFJGICAI, CancellationToken NDBJLLGGEAE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class FGNCOICGNEE
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26E8E60", Offset = "0x26E7660", VA = "0x1826E8E60")]
	public static bool IKAEDFNICKL(this CNPEEDHHHPH JLGKEHHFLDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface FJNKKCMAFBG : ODMLFBLKNFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CancellationToken CNDEAKJOHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GNOPFDNGIAF GBHCEJCJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HKFLFDIMHEL ENDIIHKDJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OLKABGPMCIJ BNGGKPIPDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	LMKKAOMIHFI KECIDMCPFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DJDKCOFKPMP FEABPMGFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BNNJOEEFPFO KGMJDCOELKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PPCBAHEPGPG BDECHOCALBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NMFNMIBLNOE OHHLHLGFEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DDGMLKAFHGA ENMEPKPMDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OAMFICOADFA FEEACMMDGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CNPEEDHHHPH LILDNIKADFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CGOHDDPHBOC EMICLDLFFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CGCKKGNHDKL CDIBGILJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AIDCOMOOPOF DKBGAPGJADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DANGLEHNHOD FFNBGJELGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OAEAFLKLDPP AKAPLCCAPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	DGIEHCDPIAI HPMCDJGDPND
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JEIAGLKFBJG MDJLECHGGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	FIIMENIBFOC HIJHKGBDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KPNJGMINFEH LPKGACGKKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HPIDOGHEOPF HPBMPIPCMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	NJDPLMINEPJ LLGDJMJJKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FIGNBOGHOKG LNEEBOGFOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	PHONKPJMLDC MMFHFHCHIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	DALMODJHJCJ NKDFADFBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface CGCKKGNHDKL : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPFGLLILJHB DEOBKNOOHMB(Guid ANNDHKOFOGN);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IIDOOJBFPNM(Guid ANNDHKOFOGN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NCHIOMCEMKO(Guid ANNDHKOFOGN, Task HHMEAMCNMCO);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LMEDKODMPIC(Guid ANNDHKOFOGN, HNKIHMBJEKG CNBPLCMAPDF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FKJLLIEKCHM(Guid ANNDHKOFOGN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(HNKIHMBJEKG, Task)> DCCEGBHNNCJ(Guid ANNDHKOFOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface AIDCOMOOPOF : GFCHHGMICCN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface DANGLEHNHOD : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCIKCBIPMLL(LOEGOPFMLGJ BOBNBIKICDK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALBNMPAPLLM(LOEGOPFMLGJ BOBNBIKICDK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KLCJDPMOLOK> PIDFDIKMFBM(CancellationToken MNNFKHNGNMA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate HNKIHMBJEKG KLIKFNMBGJG(EHBOOFFPCFP LECKHHIHCHB, KLCJDPMOLOK FKPACCLDCDD);
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface OAEAFLKLDPP : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPFGLLILJHB BJOFPBGCIPP(OAECIAKCDIH GPODEECKOHE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCBHANMNKL(Guid ANNDHKOFOGN, Task HHMEAMCNMCO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface DGIEHCDPIAI : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNKIHMBJEKG> HPMCDJGDPND(EHBOOFFPCFP MODGOKLKJPE, KLCJDPMOLOK CKELMMDFFKM, [Optional] GCOPJEEKJNO JFOIJAOANGL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface JEIAGLKFBJG : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NPDKPEMMJOC> JGICOACKHOO(MEEOFKIMDJG LDCFAICNFND, GEKAFNAJGCN JMMCFJGICAI, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPDKPEMMJOC LODLLOLDAGB(GEKAFNAJGCN JMMCFJGICAI, GCOPJEEKJNO NKMDCKHHJIC, long JKNBPJJDKBB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface KPNJGMINFEH : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKIHMBJEKG DPMKLGPMDPD(EHBOOFFPCFP LECKHHIHCHB);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BALLKFOHNJN(string DBNJCAPPLBF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface FIIMENIBFOC : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LOEGOPFMLGJ> LLMGJGPCLAG(LOEGOPFMLGJ EPNHPDGPFKK, LBJKCPGAKPO KKCCEMHCBCG, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LOEGOPFMLGJ> BDOHNECDJIJ(CancellationToken OFMMACGDFGM, LBJKCPGAKPO KKCCEMHCBCG);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLELFDCFPHN HOMLCAFADKP(CDMMNLEEPDE MBECPLEPHOF, MEEOFKIMDJG LDCFAICNFND);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLELFDCFPHN NLNMDPBNOCL(CDMMNLEEPDE MBECPLEPHOF, MEEOFKIMDJG LDCFAICNFND);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface HPIDOGHEOPF : GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKIHMBJEKG GMMIGDHPJHI(EHBOOFFPCFP LECKHHIHCHB, KLCJDPMOLOK FKPACCLDCDD);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNKIHMBJEKG OBMFJHFGCKP(EHBOOFFPCFP LIPMJJNGBIE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNKIHMBJEKG GONLGOAGGHJ(EHBOOFFPCFP LIPMJJNGBIE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NJDPLMINEPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKLMOHCOMJM(LJGHKAOJINJ PEMOFHADMKI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LILDLONLLJM(LJGHKAOJINJ PEMOFHADMKI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODAPEIFPBLL(LJGHKAOJINJ PEMOFHADMKI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FONHNPLHCPG(LJGHKAOJINJ PEMOFHADMKI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LJGHKAOJINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly GEKAFNAJGCN CELOECGMBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> NEHCDAGAAEL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::OHFIIPLOOFJ<string> CJADAOFLHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x573670", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x574F10", VA = "0x180576710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x668D60", Offset = "0x667560", VA = "0x180668D60")]
	public LJGHKAOJINJ(GEKAFNAJGCN CGBILKONHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27B4830", Offset = "0x27B3030", VA = "0x1827B4830")]
	public LJGHKAOJINJ ABBHGKLMILG(string HJCJKDOGPGK, string HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27B48F0", Offset = "0x27B30F0", VA = "0x1827B48F0")]
	public bool BFPAEDOMIBD(out IEnumerable<KeyValuePair<string, string>> MKOODOFNMIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3720", Offset = "0x8F1F20", VA = "0x1808F3720")]
	public LJGHKAOJINJ CLGDALGCDFJ(global::OHFIIPLOOFJ<string> JABEDHNBEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ODMLFBLKNFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IKAEDFNICKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AGFLIHEBFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GLNOLJJJPFD ALLFBAEIHBG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GLNOLJJJPFD AGEEOHJDPEK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GLNOLJJJPFD BKILNEOJJFC;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKANLBHADBD();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<HNKIHMBJEKG> GOKGCLHHPJI([Optional][CanBeNull] GCOPJEEKJNO HJKLLOHPLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<HNKIHMBJEKG> FLDOMOOIADG(EHBOOFFPCFP MJPLPAPDFIM);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<HNKIHMBJEKG> KAAJJANIDAF(int JNGECMMJHBF);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BALLKFOHNJN(string DBNJCAPPLBF);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<HNKIHMBJEKG> NHOFGFAGGKD(GPHANIMPAPP FLBPMDDEMNL = GPHANIMPAPP.Incremental);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ADCMAMNMLMA(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NCPCLOMOOFE(long JKNBPJJDKBB);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DKLIAELONPD(long JKNBPJJDKBB, out DateTime EOOINLMJCPA);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BDFGPLEIHNL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int NIHHBIMILAK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ELOFEMILIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IKJIPHJJHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool GOMBAJHJIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool MCDKEACGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool MCLJJNMPIII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EHBOOFFPCFP AICMAPEFKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKBLMBHGOJH(GNOPFDNGIAF FIFAINCOMCI);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task CFOAAKAAODK(MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LNIMDIFPMPC(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FEINIBDOFPG(PFNEOBAIKHP MGFFDECBOEF, [Optional] CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MJBDNCMBJFH(float HGPDOMHKMGI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IReadOnlyList<EILPGJINMOF> HKIMJLDKCKM();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDisposable POLCMNMKCDC(object JPCKENBNJIJ, EILPGJINMOF HGELDADCCEN);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ELHGFHAOIFP();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GIGGKGPFNLC LAJLBNBMJOC();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AHACEGCHOCG(int FHNMNGBIJAM);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task OPBBFCBJIMC();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MLLHFLBCGAL();

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AOINEHBFIBM();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LFCJPNHMJKM(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task CFDIGCIPNEH(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> MKLLMHHEECH(DateTime OKLLAPBJHLL, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> BIPAMPFJFBJ(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CCGDIBOGPIH();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LJNMLAJBMIP ECNDPAFNLIH(HGMCMEJEPLL LFCNHGMNLIO, EBEEBEHBHPB NEIFCDILOOO, IEnumerable<PersistenceView> HGMAHGAHKDO, ref MDLIBHGEJHP DCNCDDDMLLI);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BIEPDGEKHPJ(BFCODEDDDPM BOJHDPJNBCO, in LJNMLAJBMIP PNALBHAKAAD);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OPNDKEKJDPN(EBEEBEHBHPB DMLBGCKPNNG, bool CLJDBGJIJDP);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DHGHGGIKBHM(long KAJFPAFLIDI, long ICKOGPENBMF, GCOPJEEKJNO CCJDEKJHJKC, CLBOCFKIALB FKGIOADIPBH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OAPEFLNNNBA(long KAJFPAFLIDI, long ICKOGPENBMF);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BDFPBBPPHON(PersistenceView CENBAECLCEJ);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool BILGECGHELF(PersistenceView IOBPGNIOIGA);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool NHPDBNJNEJE(BFCODEDDDPM BOJHDPJNBCO, CEFBCOJIEHB FHHEDFNBHJO, Dictionary<int, int> AODDIJFJLFG, out EHHLGCFOCAG HOMNGCPKCBB);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MHGPCMGKGLJ();

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IHMGBBPMBCJ();

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable BBBJEKDBDNI();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Dictionary<int, int> FFMLNPLFLCF(EBEEBEHBHPB DMLBGCKPNNG, CEFBCOJIEHB FHHEDFNBHJO);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> DIMCDHCBJHO(HKFLFDIMHEL MGEBIGNOAKH, CancellationToken OFMMACGDFGM, MEEOFKIMDJG LDCFAICNFND);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LNCKGMJKADB(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<GCOPJEEKJNO> KMDHPAONFBI(long KAJFPAFLIDI, long ICKOGPENBMF, string GOAPBICOKAP, string CIOJBAGKPBM, Dictionary<long, int> GDGPFNFLPFA, int DPJCEOJFFFH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<GCOPJEEKJNO> HEABLENDLDB(long KAJFPAFLIDI, bool EFNJBCLFGIK, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool CLABKMEAKHG();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool NKCKCIDBDFN();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "44")]
	GameObject[] IABNAOODIHD(CIKENDIBGBO[] LMJOINOBEFN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void PNCLANFMACL(List<GameObject> PBJAJOIOGIE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float FNEDOMCFCDA();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task AHHEMENMFNO(string EKLDDEMFLJG, LoadSceneMode AEMPPJPDAAC, bool GEKGOFDHOMP, MEEOFKIMDJG JABEDHNBEFJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JNAFAAGDBHI(GEKAFNAJGCN NPEFKCPLDBD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void KACFOCKEMMN(string CKELMMDFFKM, EHBOOFFPCFP MODGOKLKJPE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task ABEHMLBJOPC(MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task GFDHGPNGALB(MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void GJKGHIBJKBH();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "53")]
	IDisposable PDLEIGIKFBI();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "54")]
	OAPLNDEGFOH LHMNBEJDFNH();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OAPLNDEGFOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MADDLPIIDMG(CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LNBAPELGHHM(CancellationToken OFMMACGDFGM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LJNMLAJBMIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> HMEGNNGLGHG;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IEGKCNHAEKM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GEKAFNAJGCN CPPDKDBJDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GCOPJEEKJNO PIPAGKNBDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PHHLPNBKNCF HCKEPJPNLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool OPFJNJFCEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LBOMCHFPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int NIHHBIMILAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action EBFBCJNKGOM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<int> IJJCHFKIOBG;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void INODEAKJHMK();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HKAIPAHGBEN> OKIPCENIJJO();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CNGKGKGPMMJ();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GEKAFNAJGCN GAJOEBPAMDA();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GNPBKMICIEC GBBKDOKAAPB();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KKKEDPLCAMB(long JJFOCOBGJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FIGNBOGHOKG
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKKEOLNFDMK(out IEnumerable<int> NGHIKHKLAGO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEKENBJCNPF(MHJKMEIIICB FIGDHHNIEAN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODMCKOOCOPO(MHJKMEIIICB FIGDHHNIEAN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LMNDCLONPGH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JMINAGEIJJH(HNKIHMBJEKG MNEKAKJNIIM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class MPHGKELJLIB : ODMLFBLKNFE, IDisposable, FJNKKCMAFBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct OLJAKPKFJGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<HNKIHMBJEKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public MPHGKELJLIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GPHANIMPAPP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<HNKIHMBJEKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x27BF170", Offset = "0x27BD970", VA = "0x1827BF170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x27BF3B0", Offset = "0x27BDBB0", VA = "0x1827BF3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OCNBIKPEDLC : IEnumerable<GFCHHGMICCN>, IEnumerable, IEnumerator<GFCHHGMICCN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GFCHHGMICCN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MPHGKELJLIB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private GFCHHGMICCN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public OCNBIKPEDLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x27BD170", Offset = "0x27BB970", VA = "0x1827BD170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x27BD5B0", Offset = "0x27BBDB0", VA = "0x1827BD5B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x27BD510", Offset = "0x27BBD10", VA = "0x1827BD510", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GFCHHGMICCN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x27BD510", Offset = "0x27BBD10", VA = "0x1827BD510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource KKMJHAABNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GNOPFDNGIAF FIFAINCOMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool BKEPAEJLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CMJFDKANAJL DABJBKANAAM;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HKFLFDIMHEL ENDIIHKDJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAB0", Offset = "0x5FA2B0", VA = "0x1805FBAB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x695290", Offset = "0x693A90", VA = "0x180695290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OLKABGPMCIJ BNGGKPIPDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x574E60", Offset = "0x573660", VA = "0x180574E60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6193C0", Offset = "0x617BC0", VA = "0x1806193C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x574E80", Offset = "0x573680", VA = "0x180574E80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x61EBB0", Offset = "0x61D3B0", VA = "0x18061EBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LMKKAOMIHFI KECIDMCPFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x576EC0", Offset = "0x5756C0", VA = "0x180576EC0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D5100", Offset = "0x5D3900", VA = "0x1805D5100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DJDKCOFKPMP FEABPMGFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x612F80", Offset = "0x611780", VA = "0x180612F80", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A63D0", Offset = "0x6A4BD0", VA = "0x1806A63D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BNNJOEEFPFO KGMJDCOELKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x612F70", Offset = "0x611770", VA = "0x180612F70", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61EB50", Offset = "0x61D350", VA = "0x18061EB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public PPCBAHEPGPG BDECHOCALBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x60DD60", Offset = "0x60C560", VA = "0x18060DD60", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x739940", Offset = "0x738140", VA = "0x180739940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NMFNMIBLNOE OHHLHLGFEBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x612F20", Offset = "0x611720", VA = "0x180612F20", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x739840", Offset = "0x738040", VA = "0x180739840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DDGMLKAFHGA ENMEPKPMDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x585A50", Offset = "0x584250", VA = "0x180585A50", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A7790", Offset = "0x6A5F90", VA = "0x1806A7790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OAMFICOADFA FEEACMMDGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x612F40", Offset = "0x611740", VA = "0x180612F40", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x739720", Offset = "0x737F20", VA = "0x180739720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CNPEEDHHHPH LILDNIKADFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x612FA0", Offset = "0x6117A0", VA = "0x180612FA0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DB0", Offset = "0x6A55B0", VA = "0x1806A6DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CGOHDDPHBOC EMICLDLFFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x585B90", Offset = "0x584390", VA = "0x180585B90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7817E0", Offset = "0x77FFE0", VA = "0x1807817E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public CGCKKGNHDKL CDIBGILJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x585B60", Offset = "0x584360", VA = "0x180585B60", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x71FBE0", Offset = "0x71E3E0", VA = "0x18071FBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AIDCOMOOPOF DKBGAPGJADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x585B70", Offset = "0x584370", VA = "0x180585B70", Slot = "37")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x71FBF0", Offset = "0x71E3F0", VA = "0x18071FBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public DANGLEHNHOD FFNBGJELGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x71F930", Offset = "0x71E130", VA = "0x18071F930", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B40F0", Offset = "0x6B28F0", VA = "0x1806B40F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public OAEAFLKLDPP AKAPLCCAPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CD420", Offset = "0x7CBC20", VA = "0x1807CD420", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x793E70", VA = "0x180795670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DGIEHCDPIAI HPMCDJGDPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x71B2E0", Offset = "0x719AE0", VA = "0x18071B2E0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x71B500", Offset = "0x719D00", VA = "0x18071B500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public JEIAGLKFBJG MDJLECHGGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x71B2D0", Offset = "0x719AD0", VA = "0x18071B2D0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x71B4F0", Offset = "0x719CF0", VA = "0x18071B4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FIIMENIBFOC HIJHKGBDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC50", Offset = "0x7CA450", VA = "0x1807CBC50", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6B4100", Offset = "0x6B2900", VA = "0x1806B4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KPNJGMINFEH LPKGACGKKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59CAC0", Offset = "0x59B2C0", VA = "0x18059CAC0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x739730", Offset = "0x737F30", VA = "0x180739730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public HPIDOGHEOPF HPBMPIPCMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x71B260", Offset = "0x719A60", VA = "0x18071B260", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x739740", Offset = "0x737F40", VA = "0x180739740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NJDPLMINEPJ LLGDJMJJKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x739260", Offset = "0x737A60", VA = "0x180739260", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x739750", Offset = "0x737F50", VA = "0x180739750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public FIGNBOGHOKG LNEEBOGFOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CD410", Offset = "0x7CBC10", VA = "0x1807CD410", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84C530", Offset = "0x84AD30", VA = "0x18084C530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public PHONKPJMLDC MMFHFHCHIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3C0", Offset = "0x7CBBC0", VA = "0x1807CD3C0", Slot = "47")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x842050", Offset = "0x840850", VA = "0x180842050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DALMODJHJCJ NKDFADFBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x842000", Offset = "0x840800", VA = "0x180842000", Slot = "48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x842020", Offset = "0x840820", VA = "0x180842020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private bool KADBDEDGKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x27B8800", Offset = "0x27B7000", VA = "0x1827B8800", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool BOLGLABOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27B8210", Offset = "0x27B6A10", VA = "0x1827B8210", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private CancellationToken CFAPGBNAAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x27B8670", Offset = "0x27B6E70", VA = "0x1827B8670", Slot = "22")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private GNOPFDNGIAF DHCJOGEOCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	private event GLNOLJJJPFD OEKNFIEFJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x27B87A0", Offset = "0x27B6FA0", VA = "0x1827B87A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x27B8580", Offset = "0x27B6D80", VA = "0x1827B8580", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	private event GLNOLJJJPFD CBJFCFOHNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x27B8B20", Offset = "0x27B7320", VA = "0x1827B8B20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x27B8520", Offset = "0x27B6D20", VA = "0x1827B8520", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event GLNOLJJJPFD JLKLDPCBPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x27B8930", Offset = "0x27B7130", VA = "0x1827B8930", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x27B8AC0", Offset = "0x27B72C0", VA = "0x1827B8AC0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x27B8CC0", Offset = "0x27B74C0", VA = "0x1827B8CC0")]
	[Preserve]
	internal MPHGKELJLIB([APDFHCGIDJC(null)] GNOPFDNGIAF FIFAINCOMCI, [APDFHCGIDJC(null)] HKFLFDIMHEL MGEBIGNOAKH, [APDFHCGIDJC(null)] OLKABGPMCIJ PLBEIBOHGNF, [APDFHCGIDJC(null)] BDFGPLEIHNL JMODMMLPIOO, [APDFHCGIDJC(null)] LMKKAOMIHFI BCNLHNPFBLB, [APDFHCGIDJC(null)] DJDKCOFKPMP LDGANCJEPOO, [APDFHCGIDJC(null)] BNNJOEEFPFO POOLKBEICGE, [APDFHCGIDJC(null)] PPCBAHEPGPG HDCLBDJNFLE, [APDFHCGIDJC(null)] NMFNMIBLNOE COHFIJIIKIB, [APDFHCGIDJC(null)] DDGMLKAFHGA NEOJNAGABOD, [APDFHCGIDJC(null)] OAMFICOADFA GNAHGIMKBBD, [APDFHCGIDJC(null)] CNPEEDHHHPH JLGKEHHFLDK, [APDFHCGIDJC(null)] CGOHDDPHBOC OFKHAFKGCKC, [APDFHCGIDJC(null)] CGCKKGNHDKL KMOKKBIPBPK, [APDFHCGIDJC(null)] AIDCOMOOPOF GJJHBCDCHLC, [APDFHCGIDJC(null)] DANGLEHNHOD GEDCEEJIAAB, [APDFHCGIDJC(null)] OAEAFLKLDPP DCOOGBOGIND, [APDFHCGIDJC(null)] DGIEHCDPIAI CHAJKKIGBHA, [APDFHCGIDJC(null)] JEIAGLKFBJG NJELGJOOLLF, [APDFHCGIDJC(null)] KPNJGMINFEH KIPIFEIBIFF, [APDFHCGIDJC(null)] FIIMENIBFOC ECNDJADOKIJ, [APDFHCGIDJC(null)] HPIDOGHEOPF GKDIPDGHGHG, [APDFHCGIDJC(null)] NJDPLMINEPJ GKFCCPPPDOH, [APDFHCGIDJC(null)] FIGNBOGHOKG DFIMIGCKEFE, [APDFHCGIDJC(null)] DALMODJHJCJ JAAANOFOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x27B8280", Offset = "0x27B6A80", VA = "0x1827B8280")]
	private void CDGCMJJMEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x27B8350", Offset = "0x27B6B50", VA = "0x1827B8350", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27B8750", Offset = "0x27B6F50", VA = "0x1827B8750", Slot = "12")]
	private void GLMJOCOCPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27B8690", Offset = "0x27B6E90", VA = "0x1827B8690", Slot = "18")]
	private Task GDNGFIGKDGC(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27B8AB0", Offset = "0x27B72B0", VA = "0x1827B8AB0", Slot = "19")]
	private void NKHGEFPFDAG(long JKNBPJJDKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27B81F0", Offset = "0x27B69F0", VA = "0x1827B81F0", Slot = "20")]
	private bool AHHAOPHAAAB(long ICKOGPENBMF, out DateTime ELCPNBMMKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27B8870", Offset = "0x27B7070", VA = "0x1827B8870", Slot = "16")]
	private Task LFOEPOODNBD(string DBNJCAPPLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27B85E0", Offset = "0x27B6DE0", VA = "0x1827B85E0", Slot = "13")]
	private Task<HNKIHMBJEKG> FIPIOOCPABN(GCOPJEEKJNO HJKLLOHPLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27B8180", Offset = "0x27B6980", VA = "0x1827B8180", Slot = "14")]
	private Task<HNKIHMBJEKG> AEHNPMGHGAC(EHBOOFFPCFP MJPLPAPDFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x27B8B80", Offset = "0x27B7380", VA = "0x1827B8B80", Slot = "15")]
	private Task<HNKIHMBJEKG> PDIOHDDJKGA(int JNGECMMJHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x27B8990", Offset = "0x27B7190", VA = "0x1827B8990", Slot = "17")]
	[AsyncStateMachine(typeof(OLJAKPKFJGO))]
	private Task<HNKIHMBJEKG> NGJHGHLNLNE(GPHANIMPAPP FLBPMDDEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x27B84B0", Offset = "0x27B6CB0", VA = "0x1827B84B0")]
	[IteratorStateMachine(typeof(OCNBIKPEDLC))]
	private IEnumerable<GFCHHGMICCN> EKFKAJMNIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x27B8810", Offset = "0x27B7010", VA = "0x1827B8810")]
	[CompilerGenerated]
	private void KFKNLAAHCMN(GFCHHGMICCN BCKOJIOPJJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class JEKKMKHKCNJ : MPGMPPJMNBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct AAMFEMJFOAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public JEKKMKHKCNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x265AEE0", Offset = "0x26596E0", VA = "0x18265AEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x265B1B0", Offset = "0x26599B0", VA = "0x18265B1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F80", Offset = "0x6DF780", VA = "0x1806E0F80")]
	public JEKKMKHKCNJ(FJNKKCMAFBG FLLINPNBDAE, BDFGPLEIHNL JMODMMLPIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x266DEF0", Offset = "0x266C6F0", VA = "0x18266DEF0", Slot = "4")]
	[AsyncStateMachine(typeof(AAMFEMJFOAB))]
	public Task<bool> COCMFFAPHJE(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x266DE30", Offset = "0x266C630", VA = "0x18266DE30")]
	[CompilerGenerated]
	private object CDAONCJCLFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class FELHPALLFDI : MPGMPPJMNBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct AJOGHLOGLGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public FELHPALLFDI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x26DC990", Offset = "0x26DB190", VA = "0x1826DC990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x26DCF50", Offset = "0x26DB750", VA = "0x1826DCF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const float LHJOKILBBHM = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x26E8D50", Offset = "0x26E7550", VA = "0x1826E8D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F80", Offset = "0x6DF780", VA = "0x1806E0F80")]
	public FELHPALLFDI(FJNKKCMAFBG FLLINPNBDAE, BDFGPLEIHNL JMODMMLPIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x26E8C20", Offset = "0x26E7420", VA = "0x1826E8C20", Slot = "4")]
	[AsyncStateMachine(typeof(AJOGHLOGLGF))]
	public Task<bool> COCMFFAPHJE(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26E8DA0", Offset = "0x26E75A0", VA = "0x1826E8DA0")]
	[CompilerGenerated]
	private object IPICNJKJDEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class BKJIOPLEODJ : MPGMPPJMNBL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ANHHLCBMNFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BKJIOPLEODJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Matchmaking.HKAIPAHGBEN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GEKAFNAJGCN newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ANHHLCBMNFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x26DD6E0", Offset = "0x26DBEE0", VA = "0x1826DD6E0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x26DD7A0", Offset = "0x26DBFA0", VA = "0x1826DD7A0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x26DD800", Offset = "0x26DC000", VA = "0x1826DD800")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct AFACAKOPJEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BKJIOPLEODJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ANHHLCBMNFM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<Matchmaking.HKAIPAHGBEN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x26DB230", Offset = "0x26D9A30", VA = "0x1826DB230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x26DBA50", Offset = "0x26DA250", VA = "0x1826DBA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private const float LHJOKILBBHM = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x26DEF60", Offset = "0x26DD760", VA = "0x1826DEF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F80", Offset = "0x6DF780", VA = "0x1806E0F80")]
	public BKJIOPLEODJ(FJNKKCMAFBG FLLINPNBDAE, BDFGPLEIHNL JMODMMLPIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x26DEE30", Offset = "0x26DD630", VA = "0x1826DEE30", Slot = "4")]
	[AsyncStateMachine(typeof(AFACAKOPJEC))]
	public Task<bool> COCMFFAPHJE(CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface MPGMPPJMNBL
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> COCMFFAPHJE(CancellationToken OFMMACGDFGM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal struct CNIHEOIHFIG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PLNBAIEDHDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FJNKKCMAFBG manager;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PLNBAIEDHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x26F02D0", Offset = "0x26EEAD0", VA = "0x1826F02D0")]
		internal Task <CreateTask>b__0(CJKDIAAFKFC data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PPFHAKPLDFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CNIHEOIHFIG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x26F0B50", Offset = "0x26EF350", VA = "0x1826F0B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x26F0E40", Offset = "0x26EF640", VA = "0x1826F0E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NEEMJGONKJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CNIHEOIHFIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x26EEC00", Offset = "0x26ED400", VA = "0x1826EEC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CancellationToken OFMMACGDFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FJNKKCMAFBG NNKGLHNFFGN;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private HKFLFDIMHEL ENDIIHKDJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x26E41C0", Offset = "0x26E29C0", VA = "0x1826E41C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x26E4170", Offset = "0x26E2970", VA = "0x1826E4170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x26E4500", Offset = "0x26E2D00", VA = "0x1826E4500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private NMFNMIBLNOE OHHLHLGFEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x26E4210", Offset = "0x26E2A10", VA = "0x1826E4210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x26E4900", Offset = "0x26E3100", VA = "0x1826E4900")]
	public CNIHEOIHFIG(CancellationToken OFMMACGDFGM, FJNKKCMAFBG NNKGLHNFFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x26E4260", Offset = "0x26E2A60", VA = "0x1826E4260")]
	public static DIDLAODPDJO DIKMKNOCEEC(FJNKKCMAFBG NNKGLHNFFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x26E4300", Offset = "0x26E2B00", VA = "0x1826E4300")]
	[AsyncStateMachine(typeof(PPFHAKPLDFK))]
	public Task<bool> DINOIOCBAJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x26E46A0", Offset = "0x26E2EA0", VA = "0x1826E46A0")]
	private bool JPCCIDKINMJ(out FileInfo CCBNLFOJKOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x26E4800", Offset = "0x26E3000", VA = "0x1826E4800")]
	[AsyncStateMachine(typeof(NEEMJGONKJB))]
	private Task PLMMPOCPMCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x26E4580", Offset = "0x26E2D80", VA = "0x1826E4580")]
	private Task<bool> JCHNMOEAHBJ(FileInfo CCBNLFOJKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x26E4410", Offset = "0x26E2C10", VA = "0x1826E4410")]
	private Task GHBGJPPAFNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x26E4790", Offset = "0x26E2F90", VA = "0x1826E4790")]
	private void NOPLAGKHOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal struct PPFGLLILJHB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CGCKKGNHDKL KMOKKBIPBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Guid ANNDHKOFOGN;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Task<(HNKIHMBJEKG, Task)> FMGIFNPILEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4F82ED0", Offset = "0x4F816D0", VA = "0x184F82ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2984300", Offset = "0x2982B00", VA = "0x182984300")]
	public PPFGLLILJHB(CGCKKGNHDKL KMOKKBIPBPK, Guid ANNDHKOFOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4F82E80", Offset = "0x4F81680", VA = "0x184F82E80")]
	public TaskAwaiter<(HNKIHMBJEKG, Task)> FJAFNIDBAOP()
	{
		return default(TaskAwaiter<(HNKIHMBJEKG, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4F82DB0", Offset = "0x4F815B0", VA = "0x184F82DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal struct GPHFHPELFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly TaskCompletionSource<(HNKIHMBJEKG, Task)> ABEMCEKOCNH;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<(HNKIHMBJEKG, Task)> FMGIFNPILEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2665A20", Offset = "0x2664220", VA = "0x182665A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2665B70", Offset = "0x2664370", VA = "0x182665B70")]
	public GPHFHPELFNM(TimeSpan FBPIGFIGOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2665A60", Offset = "0x2664260", VA = "0x182665A60")]
	public void KFMKOFDABKJ(Task HHMEAMCNMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2665940", Offset = "0x2664140", VA = "0x182665940")]
	public void DJMIJLBKBFF(HNKIHMBJEKG MNEKAKJNIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x26659D0", Offset = "0x26641D0", VA = "0x1826659D0")]
	public void EKDOPOOEEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2665AF0", Offset = "0x26642F0", VA = "0x182665AF0")]
	internal void KLKJDEIMJAE(string BOBNBIKICDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Preserve]
internal class FPHPAFLLDBO : PPCBAHEPGPG, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MHIODHOACFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FPHPAFLLDBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x26EDA40", Offset = "0x26EC240", VA = "0x1826EDA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MHJKMEIIICB KFNDNFPANNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private string IHOBJAOPOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private Task NNLMPHPAEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool GIBAEDGAJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x26E9D60", Offset = "0x26E8560", VA = "0x1826E9D60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Task FKFLBELDNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x26E9D00", Offset = "0x26E8500", VA = "0x1826E9D00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D51A0", Offset = "0x5D39A0", VA = "0x1805D51A0", Slot = "7")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x26E9EC0", Offset = "0x26E86C0", VA = "0x1826E9EC0", Slot = "6")]
	public void LLMGNJNEIMM(Task IIJNLEIHGNA, string JKKALDKDOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D90", Offset = "0x26E8590", VA = "0x1826E9D90")]
	[AsyncStateMachine(typeof(MHIODHOACFM))]
	private Task JEIHDKHFFDL(Task CDHDGKJPKKB, string JKKALDKDOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x26EA040", Offset = "0x26E8840", VA = "0x1826EA040")]
	public FPHPAFLLDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class FACFBPMPBON : PHONKPJMLDC, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool HBDLAMFCDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private IFJGNAONOGK DDHJBECPLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private DALMODJHJCJ JAAANOFOFDG;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public IFJGNAONOGK HFGBACAGECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x26E8070", Offset = "0x26E6870", VA = "0x1826E8070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x26E7E50", Offset = "0x26E6650", VA = "0x1826E7E50", Slot = "7")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x26E80E0", Offset = "0x26E68E0", VA = "0x1826E80E0", Slot = "5")]
	public void LCAFLKBAFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FB0", Offset = "0x26E67B0", VA = "0x1826E7FB0", Slot = "6")]
	public void IFJLDMELFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E67F0", VA = "0x1826E7FF0")]
	private Task HADHONOGIPA(HLDPOJPBHNP BGMIBHOKFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FB0", Offset = "0x26E67B0", VA = "0x1826E7FB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public FACFBPMPBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class HNLGOOLNGNP : DALMODJHJCJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class GKPIPJLLLPC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly KCICGIEKHPH OONHHBCJBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly string HJCJKDOGPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly T MNPAPGJJFGJ;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public T MKOCEBDLMLE
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x575960", VA = "0x180577160")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x5DDA50", Offset = "0x5DC250", VA = "0x1805DDA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3D92B90", Offset = "0x3D91390", VA = "0x183D92B90")]
		public GKPIPJLLLPC(KCICGIEKHPH OONHHBCJBNA, string HJCJKDOGPGK, T MNPAPGJJFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3D92850", Offset = "0x3D91050", VA = "0x183D92850")]
		private void DALJCAGEFNM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly GKPIPJLLLPC<TimeSpan> OADHIPADHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly GKPIPJLLLPC<TimeSpan> CMCKKMDFNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly GKPIPJLLLPC<bool> CFGLMLFCHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly GKPIPJLLLPC<bool> EIBIJOAOAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly GKPIPJLLLPC<bool> BPJDAFFIONH;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public TimeSpan BCOEOLKLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x266B0C0", Offset = "0x26698C0", VA = "0x18266B0C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public TimeSpan FIKPMILNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x266B140", Offset = "0x2669940", VA = "0x18266B140", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool LCODBHCPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x266B080", Offset = "0x2669880", VA = "0x18266B080", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool BHDIBPHGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x266B100", Offset = "0x2669900", VA = "0x18266B100", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool FAHGHEACIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x266B040", Offset = "0x2669840", VA = "0x18266B040", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x266B180", Offset = "0x2669980", VA = "0x18266B180")]
	[Preserve]
	public HNLGOOLNGNP([APDFHCGIDJC(null)] KCICGIEKHPH OONHHBCJBNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Preserve]
internal class MBLNOKGGKAP : DDGMLKAFHGA, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NOLMIMGPIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public COPJBADKNJB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NOLMIMGPIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x27BBAB0", Offset = "0x27BA2B0", VA = "0x1827BBAB0")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event GLNOLJJJPFD ALLFBAEIHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x27B63F0", Offset = "0x27B4BF0", VA = "0x1827B63F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x27B6280", Offset = "0x27B4A80", VA = "0x1827B6280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event GLNOLJJJPFD AGEEOHJDPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x27B6740", Offset = "0x27B4F40", VA = "0x1827B6740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x27B61E0", Offset = "0x27B49E0", VA = "0x1827B61E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event GLNOLJJJPFD BKILNEOJJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x27B6320", Offset = "0x27B4B20", VA = "0x1827B6320", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x27B6140", Offset = "0x27B4940", VA = "0x1827B6140", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "13")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x27B6490", Offset = "0x27B4C90", VA = "0x1827B6490", Slot = "10")]
	public void LLHCCNJFPEC(COPJBADKNJB PKKMHBCJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x27B63C0", Offset = "0x27B4BC0", VA = "0x1827B63C0", Slot = "11")]
	public void IPNHHJLHGEL(COPJBADKNJB PKKMHBCJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x27B64C0", Offset = "0x27B4CC0", VA = "0x1827B64C0", Slot = "12")]
	public void MAHCINNBHOD(COPJBADKNJB PKKMHBCJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x27B64F0", Offset = "0x27B4CF0", VA = "0x1827B64F0")]
	private void OPLNNDBDGBH(GLNOLJJJPFD HGELDADCCEN, COPJBADKNJB PKKMHBCJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public MBLNOKGGKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Preserve]
internal class IJHDOEPOFBN : OAMFICOADFA, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PFFAIIIBILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IJHDOEPOFBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2674160", Offset = "0x2672960", VA = "0x182674160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JAAPBBBMMIL : IAsyncStateMachine
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
		public IJHDOEPOFBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x266CD20", Offset = "0x266B520", VA = "0x18266CD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EJPIJGIDKKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public EJPIJGIDKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x265E280", Offset = "0x265CA80", VA = "0x18265E280")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MOBFLPBNLIM : IAsyncStateMachine
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
		public IJHDOEPOFBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private EJPIJGIDKKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2673210", Offset = "0x2671A10", VA = "0x182673210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x26738D0", Offset = "0x26720D0", VA = "0x1826738D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EBHJDCBCAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public EBHJDCBCAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x265DB50", Offset = "0x265C350", VA = "0x18265DB50")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private MPGMPPJMNBL[] LKMLPKEDMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CancellationTokenSource LCJMCFAEJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int PCDLODDBIJA;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x266BEB0", Offset = "0x266A6B0", VA = "0x18266BEB0", Slot = "7")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x266BF30", Offset = "0x266A730", VA = "0x18266BF30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x266C1F0", Offset = "0x266A9F0", VA = "0x18266C1F0", Slot = "6")]
	public void FKJLLIEKCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x266C8B0", Offset = "0x266B0B0", VA = "0x18266C8B0", Slot = "5")]
	public void OKANLBHADBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x266C680", Offset = "0x266AE80", VA = "0x18266C680", Slot = "4")]
	[AsyncStateMachine(typeof(PFFAIIIBILC))]
	public Task MHJLEEGLFOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x266BB90", Offset = "0x266A390", VA = "0x18266BB90")]
	private void BBEDHGAGJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x266C0D0", Offset = "0x266A8D0", VA = "0x18266C0D0")]
	[AsyncStateMachine(typeof(JAAPBBBMMIL))]
	private Task FKAHMLFMPHH(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x266C550", Offset = "0x266AD50", VA = "0x18266C550")]
	[AsyncStateMachine(typeof(MOBFLPBNLIM))]
	private Task<bool> MGMDIOLBFLE(int EDBBKGCLEJF, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x266C790", Offset = "0x266AF90", VA = "0x18266C790")]
	private void NDILNAEADIP(int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x266C360", Offset = "0x266AB60", VA = "0x18266C360")]
	private void JBLOHMDPOGN(int EDBBKGCLEJF, bool OFPOIOGNNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x266BF40", Offset = "0x266A740", VA = "0x18266BF40")]
	private void ELMNDBKNFOK(int EDBBKGCLEJF, Exception JLOJDMEEFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x266C460", Offset = "0x266AC60", VA = "0x18266C460")]
	private void KHHFLNLHKPP(CancellationToken OFMMACGDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public IJHDOEPOFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Preserve]
internal class CJOOLHPFKIJ : CGOHDDPHBOC, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct FIELGHBJHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CJOOLHPFKIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CJKDIAAFKFC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x26E9880", Offset = "0x26E8080", VA = "0x1826E9880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DLJLCNFAAEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CJOOLHPFKIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CJKDIAAFKFC roomData;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public DLJLCNFAAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x26E6450", Offset = "0x26E4C50", VA = "0x1826E6450")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct CLIHINPFEBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DIDLAODPDJO taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x26E3EA0", Offset = "0x26E26A0", VA = "0x1826E3EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OLEALCHBICE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CJOOLHPFKIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x26EF720", Offset = "0x26EDF20", VA = "0x1826EF720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HashSet<DIDLAODPDJO> IGBBGEEGILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private OLKABGPMCIJ PLBEIBOHGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private EILPGJINMOF EFCGNACKEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private BOKNACHLMDP NGCMFIGJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private IDisposable NOAIFMIBPKD;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool MINIIIGOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x26E2AE0", Offset = "0x26E12E0", VA = "0x1826E2AE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal Task FMGIFNPILEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x26E2B10", Offset = "0x26E1310", VA = "0x1826E2B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x26E1E40", Offset = "0x26E0640", VA = "0x1826E1E40", Slot = "6")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x26E2390", Offset = "0x26E0B90", VA = "0x1826E2390", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x26E20E0", Offset = "0x26E08E0", VA = "0x1826E20E0", Slot = "5")]
	public bool COHIMJAABPF(DIDLAODPDJO EINAEHCHCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x26E2CF0", Offset = "0x26E14F0", VA = "0x1826E2CF0")]
	private void PEGFJJKCNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x26E2140", Offset = "0x26E0940", VA = "0x1826E2140")]
	private void DPLPLIFDJGI(CJKDIAAFKFC IEJDKFIDFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26E2B20", Offset = "0x26E1320", VA = "0x1826E2B20")]
	[AsyncStateMachine(typeof(FIELGHBJHKF))]
	private Task NJCNOPBMGPF(CJKDIAAFKFC IEJDKFIDFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x26E2C40", Offset = "0x26E1440", VA = "0x1826E2C40")]
	private Func<CancellationToken, List<Task>> PAODBPBDFOM(CJKDIAAFKFC IEJDKFIDFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x26E2410", Offset = "0x26E0C10", VA = "0x1826E2410")]
	private List<Task> FAGEBMKHFPF(CJKDIAAFKFC IEJDKFIDFDN, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x26E29B0", Offset = "0x26E11B0", VA = "0x1826E29B0")]
	[AsyncStateMachine(typeof(CLIHINPFEBC))]
	private Task IBLEOFDKBCG(DIDLAODPDJO LNKKBJGJPFD, CJKDIAAFKFC BPPCNFHJMAA, CancellationToken FIGDHHNIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x26E1D40", Offset = "0x26E0540", VA = "0x1826E1D40")]
	[AsyncStateMachine(typeof(OLEALCHBICE))]
	private Task ADPBHDCNFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x26E28B0", Offset = "0x26E10B0", VA = "0x1826E28B0")]
	private void FKJLLIEKCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x26E2E30", Offset = "0x26E1630", VA = "0x1826E2E30")]
	public CJOOLHPFKIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Preserve]
internal class HEGKFFHNMNM : CNPEEDHHHPH, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct CAIAOCBMNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x265BAC0", Offset = "0x265A2C0", VA = "0x18265BAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct GGBNJEDFHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private CancellationTokenSource <timeoutCancellationSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private global::OHFIIPLOOFJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private LBJKCPGAKPO <joinRoomInstancePauseToken>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private LJGHKAOJINJ <analyticsData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private CancellationTokenSource <initialRoomLoadCancellationSource>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2661FE0", Offset = "0x26607E0", VA = "0x182661FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EBMPFBPHDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Task<NPDKPEMMJOC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public EBMPFBPHDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		internal Task<NPDKPEMMJOC> <ConnectToRoomAndRunLoadLogic>b__0(MEEOFKIMDJG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct FFCAENMOBDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public LBJKCPGAKPO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private EBMPFBPHDEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private NHLHCIPCLFM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private MEEOFKIMDJG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private BNKIBKJLBKC <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<NPDKPEMMJOC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x265E720", Offset = "0x265CF20", VA = "0x18265E720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OEJJFINGJNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GNPBKMICIEC presence;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public OEJJFINGJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2673A80", Offset = "0x2672280", VA = "0x182673A80")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct JCPECMPCGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private MEEOFKIMDJG <disconnectTimerScope>5__3;

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
		private MEEOFKIMDJG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x266D670", Offset = "0x266BE70", VA = "0x18266D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GDAJHKMAONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public LBJKCPGAKPO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private MEEOFKIMDJG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<PMCLDPMEPNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x26619A0", Offset = "0x26601A0", VA = "0x1826619A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GJFPIOAGPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GJFPIOAGPBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class COGJCPOBCNM
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
		public GJFPIOAGPBL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public COGJCPOBCNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x265C500", Offset = "0x265AD00", VA = "0x18265C500")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x265C410", Offset = "0x265AC10", VA = "0x18265C410")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct DLGFMBCDOGM : IAsyncStateMachine
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
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private COGJCPOBCNM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x265C710", Offset = "0x265AF10", VA = "0x18265C710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct HMLCFKELOGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LBJKCPGAKPO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NPDKPEMMJOC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GEKAFNAJGCN targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NHLHCIPCLFM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private MEEOFKIMDJG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x266AA50", Offset = "0x2669250", VA = "0x18266AA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JBONLINAMAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private MEEOFKIMDJG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x266D220", Offset = "0x266BA20", VA = "0x18266D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct FMIHEGBKOOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x26608C0", Offset = "0x265F0C0", VA = "0x1826608C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct MMHDGGNEBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2672F90", Offset = "0x2671790", VA = "0x182672F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct HDLDLMJNNND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<HNKIHMBJEKG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2665CB0", Offset = "0x26644B0", VA = "0x182665CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct BJABCKDHNHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HEGKFFHNMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x265B200", Offset = "0x2659A00", VA = "0x18265B200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FPNKNOIJNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FPNKNOIJNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2660FA0", Offset = "0x265F7A0", VA = "0x182660FA0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NJOBPIDLMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NJOBPIDLMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2673920", Offset = "0x2672120", VA = "0x182673920")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class INJDFBALKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public INJDFBALKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x266CCB0", Offset = "0x266B4B0", VA = "0x18266CCB0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LKOEBMHFDJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public LKOEBMHFDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2671E70", Offset = "0x2670670", VA = "0x182671E70")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly Guid HICIPJOIGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private BNNJOEEFPFO POOLKBEICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private OLKABGPMCIJ PLBEIBOHGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private OAMFICOADFA GNAHGIMKBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private FIIMENIBFOC ECNDJADOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private PPCBAHEPGPG HDCLBDJNFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DDGMLKAFHGA NEOJNAGABOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private DALMODJHJCJ JAAANOFOFDG;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public TaskStatus KOFKHBAAPED
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F30E0", Offset = "0x7F18E0", VA = "0x1807F30E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x88CF30", Offset = "0x88B730", VA = "0x18088CF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2668780", Offset = "0x2666F80", VA = "0x182668780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2666D60", Offset = "0x2665560", VA = "0x182666D60", Slot = "6")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2667620", Offset = "0x2665E20", VA = "0x182667620", Slot = "5")]
	[AsyncStateMachine(typeof(CAIAOCBMNGI))]
	public Task DJOPAFDEFBF(GEKAFNAJGCN JMMCFJGICAI, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2669100", Offset = "0x2667900", VA = "0x182669100")]
	[AsyncStateMachine(typeof(GGBNJEDFHIH))]
	private Task JBFIKMMINJI(GEKAFNAJGCN JMMCFJGICAI, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2667870", Offset = "0x2666070", VA = "0x182667870")]
	private static void ECMOGLBICPD(LJGHKAOJINJ MFOHPBGFEDL, Exception JLOJDMEEFHO, [Optional] List<int> BLIMFIICJHO, int PCDLODDBIJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2667370", Offset = "0x2665B70", VA = "0x182667370")]
	[AsyncStateMachine(typeof(FFCAENMOBDI))]
	private Task DCGFOCDGMMI(MEEOFKIMDJG JABEDHNBEFJ, GEKAFNAJGCN JMMCFJGICAI, LBJKCPGAKPO FNMKPENIHCJ, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2667750", Offset = "0x2665F50", VA = "0x182667750")]
	private void EAOABPDLEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x26682B0", Offset = "0x2666AB0", VA = "0x1826682B0")]
	private GNPBKMICIEC GBBKDOKAAPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2669750", Offset = "0x2667F50", VA = "0x182669750")]
	[AsyncStateMachine(typeof(JCPECMPCGKE))]
	private Task NNGMBDLHKJF(MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x26670F0", Offset = "0x26658F0", VA = "0x1826670F0")]
	private void CNPKMEIDOLL(GEKAFNAJGCN JMMCFJGICAI, CancellationToken NDBJLLGGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2666A60", Offset = "0x2665260", VA = "0x182666A60")]
	private void BGIFKGLAMOL(GEKAFNAJGCN JMMCFJGICAI, LBJKCPGAKPO FNMKPENIHCJ, OperationCanceledException LFCFKELHLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x26687D0", Offset = "0x2666FD0", VA = "0x1826687D0")]
	private void HNADODBNENJ(GEKAFNAJGCN JMMCFJGICAI, LBJKCPGAKPO FNMKPENIHCJ, Exception JLOJDMEEFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2668EB0", Offset = "0x26676B0", VA = "0x182668EB0")]
	private void IMNEMCGPEMB(GEKAFNAJGCN JMMCFJGICAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2666D20", Offset = "0x2665520", VA = "0x182666D20")]
	private static COPJBADKNJB CBDHCCPMEFG(GEKAFNAJGCN JMMCFJGICAI)
	{
		return default(COPJBADKNJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2668DC0", Offset = "0x26675C0", VA = "0x182668DC0")]
	private void IMIEIMBPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2669520", Offset = "0x2667D20", VA = "0x182669520")]
	private static PMCLDPMEPNO LNNKJENEGNC(GEKAFNAJGCN JMMCFJGICAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2668620", Offset = "0x2666E20", VA = "0x182668620")]
	[AsyncStateMachine(typeof(GDAJHKMAONH))]
	private Task GMIDBBPLJKC(GEKAFNAJGCN JMMCFJGICAI, LBJKCPGAKPO FNMKPENIHCJ, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken CMDDKEGDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2669880", Offset = "0x2668080", VA = "0x182669880")]
	[AsyncStateMachine(typeof(DLGFMBCDOGM))]
	private Task PBLJJEJNGJA(GEKAFNAJGCN JMMCFJGICAI, CancellationTokenSource DEBILCGKIDC, Task GLMMMCCGLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x26695D0", Offset = "0x2667DD0", VA = "0x1826695D0")]
	[AsyncStateMachine(typeof(HMLCFKELOGL))]
	private Task MDIBBKAKIND(NPDKPEMMJOC IKFANGMNOOP, NHLHCIPCLFM FBHNJOGFDPJ, GEKAFNAJGCN HOLAIOIMDHA, LBJKCPGAKPO GEJFOFGBMFB, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken FLDIJEMMCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2668A90", Offset = "0x2667290", VA = "0x182668A90")]
	private LBJKCPGAKPO IJMGJHOHJKF(LBJKCPGAKPO GEJFOFGBMFB, ref CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x26674E0", Offset = "0x2665CE0", VA = "0x1826674E0")]
	[AsyncStateMachine(typeof(JBONLINAMAF))]
	private Task DIICEBLNGMM(MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2667F00", Offset = "0x2666700", VA = "0x182667F00")]
	[AsyncStateMachine(typeof(FMIHEGBKOOI))]
	private Task EELDDICFPLB(MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x26684E0", Offset = "0x2666CE0", VA = "0x1826684E0")]
	[AsyncStateMachine(typeof(MMHDGGNEBNG))]
	private Task GJPKBBEBOOL(MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2666FC0", Offset = "0x26657C0", VA = "0x182666FC0")]
	[AsyncStateMachine(typeof(HDLDLMJNNND))]
	private Task CHGGNHDABFH(CJKDIAAFKFC BPPCNFHJMAA, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2668030", Offset = "0x2666830", VA = "0x182668030")]
	[AsyncStateMachine(typeof(BJABCKDHNHB))]
	private Task FEINIBDOFPG(MEEOFKIMDJG LDCFAICNFND, CancellationToken CMDDKEGDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2666940", Offset = "0x2665140", VA = "0x182666940")]
	private static void AKPDKOLFLOH(GEKAFNAJGCN JMMCFJGICAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2668170", Offset = "0x2666970", VA = "0x182668170")]
	private static void FLBJHPOBKCL(GEKAFNAJGCN JMMCFJGICAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x26692F0", Offset = "0x2667AF0", VA = "0x1826692F0")]
	private static void KGGNPIPBPDO(GEKAFNAJGCN JMMCFJGICAI, CancellationToken CMDDKEGDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x26693A0", Offset = "0x2667BA0", VA = "0x1826693A0")]
	private static void LDJMFIDDCPL(GEKAFNAJGCN JMMCFJGICAI, Exception JLOJDMEEFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2668C90", Offset = "0x2667490", VA = "0x182668C90")]
	private void ILIEOFANDDE(GEKAFNAJGCN JMMCFJGICAI, Task GLMMMCCGLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2669230", Offset = "0x2667A30", VA = "0x182669230")]
	private static void JLNHLIMCGLP(Func<string> NMDACIGKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2669A30", Offset = "0x2668230", VA = "0x182669A30")]
	public HEGKFFHNMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Preserve]
internal sealed class OANBHMKCPPM : CGCKKGNHDKL, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class MIFMHEIIJPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MIFMHEIIJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x27B6970", Offset = "0x27B5170", VA = "0x1827B6970")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class FFHFPJPIGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FFHFPJPIGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x27AB350", Offset = "0x27A9B50", VA = "0x1827AB350")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class MIDIIKCCFGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MIDIIKCCFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x27B6920", Offset = "0x27B5120", VA = "0x1827B6920")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class KPHHDEFKFLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KPHHDEFKFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x27B2350", Offset = "0x27B0B50", VA = "0x1827B2350")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class PALPELKGHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PALPELKGHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x27BF400", Offset = "0x27BDC00", VA = "0x1827BF400")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Dictionary<Guid, GPHFHPELFNM> KMOKKBIPBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly TimeSpan ODMBMOJABAO;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "10")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x27BC090", Offset = "0x27BA890", VA = "0x1827BC090", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x27BBE00", Offset = "0x27BA600", VA = "0x1827BBE00", Slot = "4")]
	public PPFGLLILJHB DEOBKNOOHMB(Guid ANNDHKOFOGN)
	{
		return default(PPFGLLILJHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x27BC4F0", Offset = "0x27BACF0", VA = "0x1827BC4F0", Slot = "5")]
	public bool IIDOOJBFPNM(Guid ANNDHKOFOGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x27BC2E0", Offset = "0x27BAAE0", VA = "0x1827BC2E0", Slot = "8")]
	public bool FKJLLIEKCHM(Guid ANNDHKOFOGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x27BC950", Offset = "0x27BB150", VA = "0x1827BC950", Slot = "6")]
	public bool NCHIOMCEMKO(Guid ANNDHKOFOGN, Task HHMEAMCNMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x27BC730", Offset = "0x27BAF30", VA = "0x1827BC730", Slot = "7")]
	public bool LMEDKODMPIC(Guid ANNDHKOFOGN, HNKIHMBJEKG MNEKAKJNIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x27BBD80", Offset = "0x27BA580", VA = "0x1827BBD80", Slot = "9")]
	public Task<(HNKIHMBJEKG, Task)> DCCEGBHNNCJ(Guid ANNDHKOFOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x27BC0A0", Offset = "0x27BA8A0", VA = "0x1827BC0A0")]
	private void EJHLDEMHMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x27BCCB0", Offset = "0x27BB4B0", VA = "0x1827BCCB0")]
	public OANBHMKCPPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Preserve]
internal class KNBOGICDHHJ : AIDCOMOOPOF, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class GLBPPNHLBFB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly GEKAFNAJGCN NPEFKCPLDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private readonly CancellationTokenSource LCJMCFAEJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public readonly CancellationToken IDPKHOEFMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private bool HCEBPICKHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool BPDPEACPAAN;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x27AC730", Offset = "0x27AAF30", VA = "0x1827AC730")]
		public GLBPPNHLBFB(GEKAFNAJGCN NPEFKCPLDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x27AC600", Offset = "0x27AAE00", VA = "0x1827AC600")]
		public void FKJLLIEKCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x27AC5D0", Offset = "0x27AADD0", VA = "0x1827AC5D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CIJLJMNCEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public HLDPOJPBHNP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public CIJLJMNCEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x27A97F0", Offset = "0x27A7FF0", VA = "0x1827A97F0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FPGHOCLEIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public HLDPOJPBHNP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public KNBOGICDHHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x27AB850", Offset = "0x27AA050", VA = "0x1827AB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GEEEJDIMFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GEEEJDIMFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x27AC570", Offset = "0x27AAD70", VA = "0x1827AC570")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct BCEIEHDOLAA : IAsyncStateMachine
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
		public KNBOGICDHHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x27A7F00", Offset = "0x27A6700", VA = "0x1827A7F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x18B6300", Offset = "0x18B4B00", VA = "0x1818B6300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class HNCGOAEFBCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public GEKAFNAJGCN newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HNCGOAEFBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x27AE100", Offset = "0x27AC900", VA = "0x1827AE100")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x27AE190", Offset = "0x27AC990", VA = "0x1827AE190")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x27AE1D0", Offset = "0x27AC9D0", VA = "0x1827AE1D0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class ANOHMICKBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ANOHMICKBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x27A7E70", Offset = "0x27A6670", VA = "0x1827A7E70")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct DBMKDJKNMLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public GEKAFNAJGCN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public KNBOGICDHHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private HNCGOAEFBCE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x27A9890", Offset = "0x27A8090", VA = "0x1827A9890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private OLKABGPMCIJ PLBEIBOHGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private OAMFICOADFA GNAHGIMKBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private DALMODJHJCJ JAAANOFOFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private CNPEEDHHHPH JLGKEHHFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long INPNIGODDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private GLBPPNHLBFB OJBMBHIFGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool FFDILHCIHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Task IILCACKPFND;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x27B1890", Offset = "0x27B0090", VA = "0x1827B1890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x27B1270", Offset = "0x27AFA70", VA = "0x1827B1270", Slot = "4")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x27B1540", Offset = "0x27AFD40", VA = "0x1827B1540", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x27B18E0", Offset = "0x27B00E0", VA = "0x1827B18E0")]
	[AsyncStateMachine(typeof(FPGHOCLEIIG))]
	private Task HDGOEKDLNJE(HLDPOJPBHNP CJIOMBDJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x27B1690", Offset = "0x27AFE90", VA = "0x1827B1690")]
	private void EBFBCJNKGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x27B1D60", Offset = "0x27B0560", VA = "0x1827B1D60")]
	private void MBOLNCBCHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x27B1F40", Offset = "0x27B0740", VA = "0x1827B1F40")]
	private void OBHIKPLOILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x27B14C0", Offset = "0x27AFCC0", VA = "0x1827B14C0")]
	private bool DHHJJJFHJHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x27B19F0", Offset = "0x27B01F0", VA = "0x1827B19F0")]
	[AsyncStateMachine(typeof(BCEIEHDOLAA))]
	private void IJJCHFKIOBG(int EJCGNDMDIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x27B0F80", Offset = "0x27AF780", VA = "0x1827B0F80")]
	private void ANOLEECLFKH(out IDisposable HKAFLCFDDHL, out IDisposable AFBHHNDGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x27B1BE0", Offset = "0x27B03E0", VA = "0x1827B1BE0")]
	private bool MAPMOPLJNOP(GEKAFNAJGCN NPEFKCPLDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x27B1AD0", Offset = "0x27B02D0", VA = "0x1827B1AD0")]
	[AsyncStateMachine(typeof(DBMKDJKNMLJ))]
	private Task JBFIKMMINJI(GEKAFNAJGCN NPEFKCPLDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x27B2110", Offset = "0x27B0910", VA = "0x1827B2110")]
	public KNBOGICDHHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Preserve]
internal sealed class NMBFDBPHHOP : DANGLEHNHOD, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ACIMCACJCOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<KLCJDPMOLOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NMBFDBPHHOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<KLCJDPMOLOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x27A7BF0", Offset = "0x27A63F0", VA = "0x1827A7BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x27A7DC0", Offset = "0x27A65C0", VA = "0x1827A7DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class NFFHECOJNBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public LOEGOPFMLGJ message;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NFFHECOJNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x27B9670", Offset = "0x27B7E70", VA = "0x1827B9670")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class ELJDBJDFEGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public LOEGOPFMLGJ messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ELJDBJDFEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x27AB300", Offset = "0x27A9B00", VA = "0x1827AB300")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class KEMFBBOALOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KEMFBBOALOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x27B0840", Offset = "0x27AF040", VA = "0x1827B0840")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct LBKFELMNGPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public NMBFDBPHHOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<CDMMNLEEPDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x27B3220", Offset = "0x27B1A20", VA = "0x1827B3220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class JCNMJBEJNCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public LOEGOPFMLGJ operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public JCNMJBEJNCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x27AEE40", Offset = "0x27AD640", VA = "0x1827AEE40")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct DPDEEBEPNDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public LOEGOPFMLGJ operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NMBFDBPHHOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private LBJKCPGAKPO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x27AA830", Offset = "0x27A9030", VA = "0x1827AA830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct BGPHDCABKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<CDMMNLEEPDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NMBFDBPHHOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private LBJKCPGAKPO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x27A89B0", Offset = "0x27A71B0", VA = "0x1827A89B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x27A8D80", Offset = "0x27A7580", VA = "0x1827A8D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class KFELCPABKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CDMMNLEEPDE operation;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KFELCPABKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x27B0890", Offset = "0x27AF090", VA = "0x1827B0890")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct GAPDDKEFAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CDMMNLEEPDE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NMBFDBPHHOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private global::OHFIIPLOOFJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x27ABB80", Offset = "0x27AA380", VA = "0x1827ABB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class AANKHIOKFKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public AANKHIOKFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x27A7BA0", Offset = "0x27A63A0", VA = "0x1827A7BA0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class FLDBLHAEJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FLDBLHAEJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x27AB800", Offset = "0x27AA000", VA = "0x1827AB800")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private PPCBAHEPGPG HDCLBDJNFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private OAEAFLKLDPP DCOOGBOGIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private FIIMENIBFOC ECNDJADOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private TaskCompletionSource<KLCJDPMOLOK> BFBKNIIBHFC;

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x27BA2A0", Offset = "0x27B8AA0", VA = "0x1827BA2A0", Slot = "7")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x27BB210", Offset = "0x27B9A10", VA = "0x1827BB210", Slot = "6")]
	[AsyncStateMachine(typeof(ACIMCACJCOK))]
	public Task<KLCJDPMOLOK> PIDFDIKMFBM(CancellationToken MNNFKHNGNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x27BA3D0", Offset = "0x27B8BD0", VA = "0x1827BA3D0", Slot = "4")]
	public void DCIKCBIPMLL(LOEGOPFMLGJ BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x27B9F60", Offset = "0x27B8760", VA = "0x1827B9F60", Slot = "5")]
	public void ALBNMPAPLLM(LOEGOPFMLGJ GHPMPKGEGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x27BA740", Offset = "0x27B8F40", VA = "0x1827BA740")]
	[AsyncStateMachine(typeof(LBKFELMNGPO))]
	private Task FKAHCIEBHFK(LOEGOPFMLGJ EPNHPDGPFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x27BB100", Offset = "0x27B9900", VA = "0x1827BB100")]
	[AsyncStateMachine(typeof(DPDEEBEPNDP))]
	private Task PDNJBCMBHCM(LOEGOPFMLGJ PFKPKGHFPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x27BA8D0", Offset = "0x27B90D0", VA = "0x1827BA8D0")]
	[AsyncStateMachine(typeof(BGPHDCABKMI))]
	private Task<CDMMNLEEPDE> KAFEKOKFPIN(LOEGOPFMLGJ EPNHPDGPFKK, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x27BA850", Offset = "0x27B9050", VA = "0x1827BA850")]
	private LBJKCPGAKPO IKLHJGKGOEI(LOEGOPFMLGJ NNKLEGFOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x27BAA10", Offset = "0x27B9210", VA = "0x1827BAA10")]
	[AsyncStateMachine(typeof(GAPDDKEFAAH))]
	private Task KGIPFEIEACM(CDMMNLEEPDE DMEDCBKJHHF, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x27BAEB0", Offset = "0x27B96B0", VA = "0x1827BAEB0")]
	private CDMMNLEEPDE OPFLGENPNDJ(LOEGOPFMLGJ EPNHPDGPFKK, LBJKCPGAKPO KKCCEMHCBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x239F670", Offset = "0x239DE70", VA = "0x18239F670")]
	private T CACPPEPDDGB<T>(T HKJMLEKHILN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x27BAB40", Offset = "0x27B9340", VA = "0x1827BAB40")]
	private CDMMNLEEPDE MLCOFBBKLPJ(LOEGOPFMLGJ EPNHPDGPFKK, LBJKCPGAKPO KKCCEMHCBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public NMBFDBPHHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x27BA380", Offset = "0x27B8B80", VA = "0x1827BA380")]
	[CompilerGenerated]
	private void CNKEHEBBFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[Preserve]
internal sealed class JOCFDIKNIAL : OAEAFLKLDPP, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class AFGKFCOHPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public AFGKFCOHPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x27A7E10", Offset = "0x27A6610", VA = "0x1827A7E10")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class LMGONMBAEFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public LMGONMBAEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x27B56C0", Offset = "0x27B3EC0", VA = "0x1827B56C0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private HPIDOGHEOPF GKDIPDGHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private DANGLEHNHOD GEDCEEJIAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private CGCKKGNHDKL KMOKKBIPBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private FIGNBOGHOKG DFIMIGCKEFE;

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2670230", Offset = "0x266EA30", VA = "0x182670230", Slot = "6")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2670610", Offset = "0x266EE10", VA = "0x182670610", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x266FDA0", Offset = "0x266E5A0", VA = "0x18266FDA0", Slot = "4")]
	public PPFGLLILJHB BJOFPBGCIPP(OAECIAKCDIH EPNHPDGPFKK)
	{
		return default(PPFGLLILJHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x266F680", Offset = "0x266DE80", VA = "0x18266F680", Slot = "5")]
	public void AJCBHANMNKL(Guid ANNDHKOFOGN, Task HHMEAMCNMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x26714A0", Offset = "0x266FCA0", VA = "0x1826714A0")]
	private void OEGHEHFKGLF(byte HKJMAFJKNHI, int CNFJMMOGCDN, object FIDHBEOFCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2670C20", Offset = "0x266F420", VA = "0x182670C20")]
	private void IEMPIGOFLEM(LKLJDBFGANA NOFJGCGFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2670380", Offset = "0x266EB80", VA = "0x182670380")]
	private void DMONGDOIOCC(LKLJDBFGANA NOFJGCGFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x26706A0", Offset = "0x266EEA0", VA = "0x1826706A0")]
	private void FFGOEBHNLDO(LKLJDBFGANA NOFJGCGFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2670900", Offset = "0x266F100", VA = "0x182670900")]
	private HNKIHMBJEKG GLGCALACBFK(LOEGOPFMLGJ NNKLEGFOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x266F8D0", Offset = "0x266E0D0", VA = "0x18266F8D0")]
	private void APKFGIAFLDF(LOEGOPFMLGJ PFKPKGHFPBK, HNKIHMBJEKG MNEKAKJNIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2671570", Offset = "0x266FD70", VA = "0x182671570")]
	private bool PGBDAEBEFLP(LOEGOPFMLGJ PFKPKGHFPBK, HNKIHMBJEKG MNEKAKJNIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x266FB00", Offset = "0x266E300", VA = "0x18266FB00")]
	private bool BJOFPBGCIPP(LOEGOPFMLGJ ANHBMLELMIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x26711D0", Offset = "0x266F9D0", VA = "0x1826711D0")]
	private bool MHGOOGJCPOK(byte HKJMAFJKNHI, ExitGames.Client.Photon.Hashtable NOFJGCGFBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOCFDIKNIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Preserve]
internal sealed class PEKPMICLFBB : DGIEHCDPIAI, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class CODHMCHJNBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public KLCJDPMOLOK operationType;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public CODHMCHJNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DCE0", Offset = "0x4F7C4E0", VA = "0x184F7DCE0")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct IPMMDPPACGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<HNKIHMBJEKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public KLCJDPMOLOK operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public PEKPMICLFBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public EHBOOFFPCFP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public GCOPJEEKJNO detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private TaskAwaiter<HNKIHMBJEKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x4F7F7E0", Offset = "0x4F7DFE0", VA = "0x184F7F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4F7FDB0", Offset = "0x4F7E5B0", VA = "0x184F7FDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class NHGOPACMDLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public KLCJDPMOLOK operationType;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NHGOPACMDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x4F803B0", Offset = "0x4F7EBB0", VA = "0x184F803B0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NJBLHKEEHHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public KLCJDPMOLOK operationType;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NJBLHKEEHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x4F80410", Offset = "0x4F7EC10", VA = "0x184F80410")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x4F80470", Offset = "0x4F7EC70", VA = "0x184F80470")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x4F804D0", Offset = "0x4F7ECD0", VA = "0x184F804D0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct HFELHJIEPKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder<HNKIHMBJEKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public KLCJDPMOLOK operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public PEKPMICLFBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public EHBOOFFPCFP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public GCOPJEEKJNO detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private NJBLHKEEHHI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private PPFGLLILJHB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private HNKIHMBJEKG <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private TaskAwaiter<(HNKIHMBJEKG validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4F7F120", Offset = "0x4F7D920", VA = "0x184F7F120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x4F7F790", Offset = "0x4F7DF90", VA = "0x184F7F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class MJCDIJBDLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public KLCJDPMOLOK operationType;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MJCDIJBDLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x4F80350", Offset = "0x4F7EB50", VA = "0x184F80350")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private JEIAGLKFBJG NJELGJOOLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private HPIDOGHEOPF GKDIPDGHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private OAEAFLKLDPP DCOOGBOGIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4F81980", Offset = "0x4F80180", VA = "0x184F81980", Slot = "5")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4F81E30", Offset = "0x4F80630", VA = "0x184F81E30", Slot = "4")]
	[AsyncStateMachine(typeof(IPMMDPPACGK))]
	public Task<HNKIHMBJEKG> HPMCDJGDPND(EHBOOFFPCFP MODGOKLKJPE, KLCJDPMOLOK CKELMMDFFKM, [CanBeNull] GCOPJEEKJNO HJKLLOHPLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4F81F80", Offset = "0x4F80780", VA = "0x184F81F80")]
	private bool MCFHFGAGFGA(KLCJDPMOLOK CKELMMDFFKM, out HNKIHMBJEKG JOPBNPIPIOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4F81830", Offset = "0x4F80030", VA = "0x184F81830")]
	[AsyncStateMachine(typeof(HFELHJIEPKF))]
	private Task<HNKIHMBJEKG> BFOAHLDLGOM(EHBOOFFPCFP MODGOKLKJPE, KLCJDPMOLOK CKELMMDFFKM, [CanBeNull] GCOPJEEKJNO HJKLLOHPLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4F81A80", Offset = "0x4F80280", VA = "0x184F81A80")]
	internal OAECIAKCDIH DDGLJOCJJCP(EHBOOFFPCFP MODGOKLKJPE, KLCJDPMOLOK CKELMMDFFKM, [CanBeNull] GCOPJEEKJNO HJKLLOHPLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PEKPMICLFBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[Preserve]
internal sealed class AGIGFGEOICJ : JEIAGLKFBJG, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FDBCIKAFNAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder<NPDKPEMMJOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AGIGFGEOICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<GCOPJEEKJNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x26E83A0", Offset = "0x26E6BA0", VA = "0x1826E83A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x26E8800", Offset = "0x26E7000", VA = "0x1826E8800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class CBLLLPHEGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public CBLLLPHEGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x26E0EB0", Offset = "0x26DF6B0", VA = "0x1826E0EB0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct DGNJDNDFGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AsyncTaskMethodBuilder<GCOPJEEKJNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AGIGFGEOICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public GEKAFNAJGCN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private CBLLLPHEGFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<BHHJNHKDOLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x26E5670", Offset = "0x26E3E70", VA = "0x1826E5670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x26E5990", Offset = "0x26E4190", VA = "0x1826E5990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class LFHDGLPOLFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public LFHDGLPOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xB09390", Offset = "0xB07B90", VA = "0x180B09390")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(PHHLPNBKNCF sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static readonly (JGADFMOHFPD superRoomData, JGADFMOHFPD subRoomData) HFMMAHMOGAN;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x26DC3E0", Offset = "0x26DABE0", VA = "0x1826DC3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x26DBF00", Offset = "0x26DA700", VA = "0x1826DBF00", Slot = "6")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x26DC590", Offset = "0x26DAD90", VA = "0x1826DC590", Slot = "4")]
	[AsyncStateMachine(typeof(FDBCIKAFNAK))]
	public Task<NPDKPEMMJOC> JGICOACKHOO(MEEOFKIMDJG LDCFAICNFND, GEKAFNAJGCN JMMCFJGICAI, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x26DC430", Offset = "0x26DAC30", VA = "0x1826DC430")]
	[AsyncStateMachine(typeof(DGNJDNDFGHB))]
	public Task<GCOPJEEKJNO> JFACKPIFLJM(GEKAFNAJGCN JMMCFJGICAI, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x26DC6F0", Offset = "0x26DAEF0", VA = "0x1826DC6F0", Slot = "5")]
	public NPDKPEMMJOC LODLLOLDAGB(GEKAFNAJGCN JMMCFJGICAI, GCOPJEEKJNO NKMDCKHHJIC, long JKNBPJJDKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x26DC260", Offset = "0x26DAA60", VA = "0x1826DC260")]
	private static NPDKPEMMJOC CINEFLNPEMH(GCOPJEEKJNO NKMDCKHHJIC, long JKNBPJJDKBB, JGADFMOHFPD DBGFHFLJOCD, JGADFMOHFPD IEJDKFIDFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x26DBF70", Offset = "0x26DA770", VA = "0x1826DBF70")]
	private (JGADFMOHFPD, JGADFMOHFPD) CEGCFMOPLKK(GEKAFNAJGCN JMMCFJGICAI, GCOPJEEKJNO NKMDCKHHJIC, long JKNBPJJDKBB)
	{
		return default((JGADFMOHFPD, JGADFMOHFPD));
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public AGIGFGEOICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[Preserve]
internal sealed class OMAEJAFBMAC : FIIMENIBFOC, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class NPIBLBAGHKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NPIBLBAGHKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x4F80A40", Offset = "0x4F7F240", VA = "0x184F80A40")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct NLKLKKIFFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public OMAEJAFBMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public LBJKCPGAKPO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4F80530", Offset = "0x4F7ED30", VA = "0x184F80530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F809F0", Offset = "0x4F7F1F0", VA = "0x184F809F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct LALMEEHDMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public OMAEJAFBMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public LBJKCPGAKPO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter<ELKJHLECFEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F7FE00", Offset = "0x4F7E600", VA = "0x184F7FE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F80300", Offset = "0x4F7EB00", VA = "0x184F80300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class AMNBGLOMILP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public AMNBGLOMILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DC90", Offset = "0x4F7C490", VA = "0x184F7DC90")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct FPBHKCMNMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public LOEGOPFMLGJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public OMAEJAFBMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public LBJKCPGAKPO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private EAHKAFHEENN <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private JIILJBNMPMG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<ELKJHLECFEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F7E570", Offset = "0x4F7CD70", VA = "0x184F7E570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F7EE50", Offset = "0x4F7D650", VA = "0x184F7EE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private PHONKPJMLDC LBKLLEDJNAC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private IFJGNAONOGK HFGBACAGECE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x4F80E40", Offset = "0x4F7F640", VA = "0x184F80E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4F80BD0", Offset = "0x4F7F3D0", VA = "0x184F80BD0", Slot = "8")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F80EF0", Offset = "0x4F7F6F0", VA = "0x184F80EF0", Slot = "4")]
	[AsyncStateMachine(typeof(NLKLKKIFFEA))]
	public Task<LOEGOPFMLGJ> LLMGJGPCLAG(LOEGOPFMLGJ EPNHPDGPFKK, LBJKCPGAKPO KKCCEMHCBCG, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F80A90", Offset = "0x4F7F290", VA = "0x184F80A90", Slot = "5")]
	[AsyncStateMachine(typeof(LALMEEHDMKA))]
	public Task<LOEGOPFMLGJ> BDOHNECDJIJ(CancellationToken OFMMACGDFGM, LBJKCPGAKPO KKCCEMHCBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4F80DA0", Offset = "0x4F7F5A0", VA = "0x184F80DA0", Slot = "6")]
	public MLELFDCFPHN HOMLCAFADKP(CDMMNLEEPDE MBECPLEPHOF, MEEOFKIMDJG LDCFAICNFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F81040", Offset = "0x4F7F840", VA = "0x184F81040", Slot = "7")]
	public MLELFDCFPHN NLNMDPBNOCL(CDMMNLEEPDE MBECPLEPHOF, MEEOFKIMDJG LDCFAICNFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4F81140", Offset = "0x4F7F940", VA = "0x184F81140")]
	[AsyncStateMachine(typeof(FPBHKCMNMFN))]
	private Task<LOEGOPFMLGJ> PDCNKCMNPGI(LOEGOPFMLGJ EPNHPDGPFKK, LBJKCPGAKPO KKCCEMHCBCG, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2852030", Offset = "0x2850830", VA = "0x182852030")]
	private static byte[] BPLBMNGANEK(LOEGOPFMLGJ BOBNBIKICDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F80C60", Offset = "0x4F7F460", VA = "0x184F80C60")]
	private static string GMACPNCNLKB(byte[] NJMKOLAAABP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public OMAEJAFBMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[Preserve]
internal sealed class HEHMMKOLBPG : HPIDOGHEOPF, GFCHHGMICCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private LMKKAOMIHFI BCNLHNPFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private PPCBAHEPGPG HDCLBDJNFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private KPNJGMINFEH KIPIFEIBIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private CNPEEDHHHPH JLGKEHHFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private CGOHDDPHBOC OFKHAFKGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private DALMODJHJCJ JAAANOFOFDG;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2669F40", Offset = "0x2668740", VA = "0x182669F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private static HNKIHMBJEKG EJAEEENONLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2669A50", Offset = "0x2668250", VA = "0x182669A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2669A60", Offset = "0x2668260", VA = "0x182669A60", Slot = "7")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2669C30", Offset = "0x2668430", VA = "0x182669C30", Slot = "4")]
	public HNKIHMBJEKG GMMIGDHPJHI(EHBOOFFPCFP LECKHHIHCHB, KLCJDPMOLOK FKPACCLDCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2669F90", Offset = "0x2668790", VA = "0x182669F90", Slot = "5")]
	public HNKIHMBJEKG OBMFJHFGCKP(EHBOOFFPCFP LIPMJJNGBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2669D80", Offset = "0x2668580", VA = "0x182669D80", Slot = "6")]
	public HNKIHMBJEKG GONLGOAGGHJ(EHBOOFFPCFP LIPMJJNGBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2669A40", Offset = "0x2668240", VA = "0x182669A40")]
	private static HNKIHMBJEKG BDFMAPFCJND(COCNJNDKFHM MGFFDECBOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HEHMMKOLBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class PKDLDFLHOCH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F828C0", Offset = "0x4F810C0", VA = "0x184F828C0")]
	public PKDLDFLHOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xD0E690", Offset = "0xD0CE90", VA = "0x180D0E690")]
	public PKDLDFLHOCH(string BOBNBIKICDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[Preserve]
internal sealed class JHIIHEDKMAN : NMFNMIBLNOE, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct ECMHFJJAFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<HNKIHMBJEKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JHIIHEDKMAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public GPHANIMPAPP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private global::OHFIIPLOOFJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private MEEOFKIMDJG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private MEEOFKIMDJG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private TaskAwaiter<HNKIHMBJEKG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x265DBB0", Offset = "0x265C3B0", VA = "0x18265DBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x265E230", Offset = "0x265CA30", VA = "0x18265E230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct MEKJGNLGDPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public JHIIHEDKMAN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x2671F50", Offset = "0x2670750", VA = "0x182671F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct KJHCJBEFBOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public JHIIHEDKMAN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x2671810", Offset = "0x2670010", VA = "0x182671810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct JNAFABOHCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public JHIIHEDKMAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x266F530", Offset = "0x266DD30", VA = "0x18266F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct OFDFMHEHAFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public JHIIHEDKMAN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x2673BB0", Offset = "0x26723B0", VA = "0x182673BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct HLCENMNKAAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JHIIHEDKMAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public GPHANIMPAPP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private global::OHFIIPLOOFJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x266A690", Offset = "0x2668E90", VA = "0x18266A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly TimeSpan KMCEILNNGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private HKFLFDIMHEL MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private FIIMENIBFOC ECNDJADOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private PPCBAHEPGPG HDCLBDJNFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private CGOHDDPHBOC OFKHAFKGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private CancellationTokenSource DJKLJMPHHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private Task ECOGBNDPMMI;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x266E8A0", Offset = "0x266D0A0", VA = "0x18266E8A0", Slot = "6")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x16C39B0", Offset = "0x16C21B0", VA = "0x1816C39B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x266F170", Offset = "0x266D970", VA = "0x18266F170", Slot = "4")]
	[AsyncStateMachine(typeof(ECMHFJJAFCP))]
	public Task<HNKIHMBJEKG> NHOFGFAGGKD(GPHANIMPAPP FLBPMDDEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x266E780", Offset = "0x266CF80", VA = "0x18266E780", Slot = "5")]
	[AsyncStateMachine(typeof(MEKJGNLGDPE))]
	public Task ADCMAMNMLMA([Optional] CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x16C39B0", Offset = "0x16C21B0", VA = "0x1816C39B0")]
	public void FMPOJBENNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x266F280", Offset = "0x266DA80", VA = "0x18266F280")]
	private LBFMFCPFGMC PMGEEDPAGJG(GPHANIMPAPP FLBPMDDEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x266EE40", Offset = "0x266D640", VA = "0x18266EE40")]
	[AsyncStateMachine(typeof(KJHCJBEFBOM))]
	private Task LOMEOJNBONE(CJKDIAAFKFC BGMIBHOKFOA, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x266EC00", Offset = "0x266D400", VA = "0x18266EC00")]
	[AsyncStateMachine(typeof(JNAFABOHCLA))]
	private Task EPJFKDIPKGF([Optional] CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x266EAD0", Offset = "0x266D2D0", VA = "0x18266EAD0")]
	[AsyncStateMachine(typeof(OFDFMHEHAFD))]
	private Task EOODFGFOENP(TimeSpan CKAKHIACKAK, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x266EF60", Offset = "0x266D760", VA = "0x18266EF60")]
	private Task MDILGOICCLP(GPHANIMPAPP FLBPMDDEMNL, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x266ED10", Offset = "0x266D510", VA = "0x18266ED10")]
	[AsyncStateMachine(typeof(HLCENMNKAAH))]
	private Task GOIKAPBLLIL(GPHANIMPAPP FLBPMDDEMNL, CancellationToken NDBJLLGGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x266EA30", Offset = "0x266D230", VA = "0x18266EA30")]
	private bool DPMKLGPMDPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JHIIHEDKMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal class BLOHPEPAFLA : KPNJGMINFEH, GFCHHGMICCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct DIPPOPCEJLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public BLOHPEPAFLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private global::OHFIIPLOOFJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x26E5E80", Offset = "0x26E4680", VA = "0x1826E5E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private DJDKCOFKPMP LDGANCJEPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private HPIDOGHEOPF GKDIPDGHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private FIIMENIBFOC ECNDJADOKIJ;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x26DF0D0", Offset = "0x26DD8D0", VA = "0x1826DF0D0", Slot = "6")]
	public void CDGCMJJMEMA(FJNKKCMAFBG FLLINPNBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x26DF3B0", Offset = "0x26DDBB0", VA = "0x1826DF3B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x26DEFB0", Offset = "0x26DD7B0", VA = "0x1826DEFB0", Slot = "5")]
	[AsyncStateMachine(typeof(DIPPOPCEJLO))]
	public Task BALLKFOHNJN(string DBNJCAPPLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x26DF250", Offset = "0x26DDA50", VA = "0x1826DF250", Slot = "4")]
	public HNKIHMBJEKG DPMKLGPMDPD(EHBOOFFPCFP LECKHHIHCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x26DF3D0", Offset = "0x26DDBD0", VA = "0x1826DF3D0")]
	private OGFKHKGBOGB HCOFOAFGDHN(string DBNJCAPPLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BLOHPEPAFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class KDIMLLJBDBB
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x27B04A0", Offset = "0x27AECA0", VA = "0x1827B04A0")]
	public static void JHMFONCBEPL(GNOPFDNGIAF FIFAINCOMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x27B0400", Offset = "0x27AEC00", VA = "0x1827B0400")]
	internal static void HKCOJOGCLNE(GNOPFDNGIAF FIFAINCOMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x27B00A0", Offset = "0x27AE8A0", VA = "0x1827B00A0")]
	internal static void BBHJMFBDBEP(GNOPFDNGIAF FIFAINCOMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x27B0140", Offset = "0x27AE940", VA = "0x1827B0140")]
	internal static void HHNLIPCODMI(GNOPFDNGIAF FIFAINCOMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class GILENOKNNNA : global::MPAEMHOLHII<LOEGOPFMLGJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class MJDLDDPAOGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public LOEGOPFMLGJ message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MJDLDDPAOGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2672C30", Offset = "0x2671430", VA = "0x182672C30")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly GILENOKNNNA JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private const string IEMEMDPOCHL = "pl";

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2663360", Offset = "0x2661B60", VA = "0x182663360")]
	public ExitGames.Client.Photon.Hashtable IICNIKFAIFP(LOEGOPFMLGJ BOBNBIKICDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2663250", Offset = "0x2661A50", VA = "0x182663250", Slot = "5")]
	protected override void EAPCOPFIOLD(LOEGOPFMLGJ BOBNBIKICDK, IDictionary<object, object> BPPCNFHJMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2663070", Offset = "0x2661870", VA = "0x182663070", Slot = "6")]
	public override LOEGOPFMLGJ DMAKMKNNBAJ(IDictionary<object, object> BPPCNFHJMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x26633E0", Offset = "0x2661BE0", VA = "0x1826633E0")]
	private static void JLNHLIMCGLP(string GADPLBNJMEH, LOEGOPFMLGJ BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x26635B0", Offset = "0x2661DB0", VA = "0x1826635B0")]
	public GILENOKNNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2662E10", Offset = "0x2661610", VA = "0x182662E10")]
	[CompilerGenerated]
	internal static string BFPKMPNNCKB(NPDKPEMMJOC MDKOIJJHDKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class EFKLICEGDBE
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static HNKIHMBJEKG EJAEEENONLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x26E7230", Offset = "0x26E5A30", VA = "0x1826E7230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x26E71B0", Offset = "0x26E59B0", VA = "0x1826E71B0")]
	public static bool BBNJKHOPCIJ(this HNKIHMBJEKG MNEKAKJNIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x26E71D0", Offset = "0x26E59D0", VA = "0x1826E71D0")]
	public static HNKIHMBJEKG BDFMAPFCJND(COCNJNDKFHM CANICIBDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x26E7290", Offset = "0x26E5A90", VA = "0x1826E7290")]
	public static HNKIHMBJEKG LABENLOKJFA(params HNKIHMBJEKG[] CDEAMJPGBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x26E7630", Offset = "0x26E5E30", VA = "0x1826E7630")]
	public static HNKIHMBJEKG PMGPAJMKNEO(IEnumerable<HNKIHMBJEKG> CDEAMJPGBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x26E7430", Offset = "0x26E5C30", VA = "0x1826E7430")]
	public static string MKNLCGKKNCA(this HNKIHMBJEKG JOPBNPIPIOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public abstract class IGCCJABCALE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public delegate HNKIHMBJEKG FCEFBKBJEJH([NotNull] EHBOOFFPCFP EGELIMHHMDH);

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class HPEELIONJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public EHBOOFFPCFP photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HPEELIONJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x266B350", Offset = "0x2669B50", VA = "0x18266B350")]
		internal HNKIHMBJEKG <Validate>b__0(FCEFBKBJEJH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	protected readonly HashSet<FCEFBKBJEJH> BIMGCIPMNAH;

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x266B690", Offset = "0x2669E90", VA = "0x18266B690")]
	public void PLBBOIPLMIC(FCEFBKBJEJH IDDDGKIPNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x266B630", Offset = "0x2669E30", VA = "0x18266B630")]
	public void OPINCPMPEAM(FCEFBKBJEJH IDDDGKIPNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x266B5E0", Offset = "0x2669DE0", VA = "0x18266B5E0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x266B440", Offset = "0x2669C40", VA = "0x18266B440")]
	protected HNKIHMBJEKG DHNLINDCOPG(EHBOOFFPCFP LIPMJJNGBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x266B6F0", Offset = "0x2669EF0", VA = "0x18266B6F0")]
	protected IGCCJABCALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class LMKKAOMIHFI : IGCCJABCALE
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MDNCFNLMPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public HNKIHMBJEKG result;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MDNCFNLMPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x27B68D0", Offset = "0x27B50D0", VA = "0x1827B68D0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6440", Offset = "0x26E4C40", VA = "0x1826E6440")]
	[Preserve]
	public LMKKAOMIHFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x27B5720", Offset = "0x27B3F20", VA = "0x1827B5720")]
	public HNKIHMBJEKG LACDLMHCDFA(EHBOOFFPCFP LIPMJJNGBIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class DJDKCOFKPMP : IGCCJABCALE
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class HNCEDODDJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public HNKIHMBJEKG result;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HNCEDODDJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x26EBA70", Offset = "0x26EA270", VA = "0x1826EBA70")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x26E6440", Offset = "0x26E4C40", VA = "0x1826E6440")]
	[Preserve]
	public DJDKCOFKPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x26E62F0", Offset = "0x26E4AF0", VA = "0x1826E62F0")]
	public HNKIHMBJEKG DPMKLGPMDPD(EHBOOFFPCFP PGEPDGCFKON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public enum PFNEOBAIKHP
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
internal static class NDLPJEBPPDG
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NGKPGICHNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public global::OHFIIPLOOFJ<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NGKPGICHNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x27B96C0", Offset = "0x27B7EC0", VA = "0x1827B96C0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public const string GGEDIHHAEJL = "START: ";

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public const string JDGJMPBMFHH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x27B94E0", Offset = "0x27B7CE0", VA = "0x1827B94E0")]
	public static global::OHFIIPLOOFJ<string> NJMDPBNNJLI([Optional] string NNGGAIDPLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x27B9220", Offset = "0x27B7A20", VA = "0x1827B9220")]
	private static void ANBNMIPPIDD(string HJCJKDOGPGK, DGELBEAGFKE JABEDHNBEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x27B9590", Offset = "0x27B7D90", VA = "0x1827B9590")]
	private static void OMCHIJOHMJP(string HJCJKDOGPGK, DGELBEAGFKE JABEDHNBEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x27B93B0", Offset = "0x27B7BB0", VA = "0x1827B93B0")]
	public static void NJJDBMBKEJD(global::OHFIIPLOOFJ<string> JABEDHNBEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x27B9310", Offset = "0x27B7B10", VA = "0x1827B9310")]
	public static string IPJILBNCOMK(LOEGOPFMLGJ NNKLEGFOJND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal static class ECIABMNFHFO
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x26E6490", Offset = "0x26E4C90", VA = "0x1826E6490")]
	public static void FAILDEGNNDN(this HKFLFDIMHEL MGEBIGNOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6480", Offset = "0x26E4C80", VA = "0x1826E6480")]
	public static void CFDAJPHDKAF(this HKFLFDIMHEL MGEBIGNOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x26E64A0", Offset = "0x26E4CA0", VA = "0x1826E64A0")]
	private static void MBALMCHOGCL(this HKFLFDIMHEL MGEBIGNOAKH, bool GEDMLMEKLME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class BGMGMFDPCPP : EEAKFJJMMKK, OBPCLFCCOCL, BMHBGDCHDAO, BGMOBNHBDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private readonly OBPCLFCCOCL AMKHAGBJAIB;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public EHBOOFFPCFP AICMAPEFKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x26DDFC0", Offset = "0x26DC7C0", VA = "0x1826DDFC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int IGLJGFLPCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x26DDB60", Offset = "0x26DC360", VA = "0x1826DDB60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int KNCLHLMPADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x26DDD90", Offset = "0x26DC590", VA = "0x1826DDD90", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool EDNECMLHGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x5731D0", VA = "0x1805749D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event HLPKOKDLKCE.IFIFNIDKBMP HGKOFDICFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x26DE0B0", Offset = "0x26DC8B0", VA = "0x1826DE0B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x26DE150", Offset = "0x26DC950", VA = "0x1826DE150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event JJMFMAHMOAF KHIEOPNMBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x26DDA00", Offset = "0x26DC200", VA = "0x1826DDA00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x26DDCF0", Offset = "0x26DC4F0", VA = "0x1826DDCF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<bool> LKNBFEANKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x26DDBB0", Offset = "0x26DC3B0", VA = "0x1826DDBB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x26DDDE0", Offset = "0x26DC5E0", VA = "0x1826DDDE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EHBOOFFPCFP> IHFKLDFMBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x26DDAC0", Offset = "0x26DC2C0", VA = "0x1826DDAC0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x26DE010", Offset = "0x26DC810", VA = "0x1826DE010", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action GMPIECDADFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x26DDF20", Offset = "0x26DC720", VA = "0x1826DDF20", Slot = "25")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x26DD890", Offset = "0x26DC090", VA = "0x1826DD890", Slot = "26")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x26DE250", Offset = "0x26DCA50", VA = "0x1826DE250")]
	public BGMGMFDPCPP(OBPCLFCCOCL AMKHAGBJAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x26DDE80", Offset = "0x26DC680", VA = "0x1826DDE80", Slot = "8")]
	public bool ILBMCNIEMOE(byte HKJMAFJKNHI, ExitGames.Client.Photon.Hashtable EEJMCJLOPIB, HFKDEFDCJGM EAAECJHOAPB, SendOptions FEGCOLIODNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x26DDC50", Offset = "0x26DC450", VA = "0x1826DDC50", Slot = "28")]
	public EHBOOFFPCFP EEFJDFFHAEL(int GFIHPHEPCFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x26DD930", Offset = "0x26DC130", VA = "0x1826DD930", Slot = "15")]
	public EHBOOFFPCFP APGJAJHOIIJ(int JNGECMMJHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "18")]
	public void IPPOAJLFDLM(object FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "19")]
	public void ECBLAOMEKOM(object FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "20")]
	public void DMJIHFKEFIH(object FIGDHHNIEAN, bool LINLPJANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x26DE1F0", Offset = "0x26DC9F0", VA = "0x1826DE1F0", Slot = "21")]
	public IDisposable NOPNOKAEEDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0", Slot = "22")]
	private bool BDMCGEFCMPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "23")]
	public void IKMKABGNKGI(StringBuilder BANAOJIILEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x26DDAA0", Offset = "0x26DC2A0", VA = "0x1826DDAA0", Slot = "24")]
	public bool CAOCDLFJMHD(bool BJHEFENDIIH, out string NCDAHJANGKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910")]
	public void LHAOAOOPAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x152E930", Offset = "0x152D130", VA = "0x18152E930", Slot = "27")]
	public void KDNNKHALIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal struct LKLJDBFGANA
{
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public const string FMLBJAEDOMM = "v_result";

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public const string MIAODPNPOLE = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly IDictionary<object, object> NOFJGCGFBPI;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool CFOOMENBKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1635290", Offset = "0x1633A90", VA = "0x181635290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x719100", Offset = "0x717900", VA = "0x180719100")]
	public LKLJDBFGANA(IDictionary<object, object> NOFJGCGFBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x27B5230", Offset = "0x27B3A30", VA = "0x1827B5230")]
	public bool PEFENBPHHEH(out LOEGOPFMLGJ BOBNBIKICDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x27B5170", Offset = "0x27B3970", VA = "0x1827B5170")]
	public Guid EJBIIGBOGOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x27B4F70", Offset = "0x27B3770", VA = "0x1827B4F70")]
	public HNKIHMBJEKG BLBLHIGJPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x27B50A0", Offset = "0x27B38A0", VA = "0x1827B50A0")]
	public static ExitGames.Client.Photon.Hashtable DIFMOOHBFDA(LOEGOPFMLGJ BOBNBIKICDK, HNKIHMBJEKG MNEKAKJNIIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class JPINFPFEMBL
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x27AF910", Offset = "0x27AE110", VA = "0x1827AF910")]
	public static string CAMCPKMIHAI(this GEKAFNAJGCN CGBILKONHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x27AF890", Offset = "0x27AE090", VA = "0x1827AF890")]
	public static bool BJEEHEFEIHI(this GEKAFNAJGCN CGBILKONHNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct BOKNACHLMDP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct PJGJFMJKEAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public BOKNACHLMDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x26EFD70", Offset = "0x26EE570", VA = "0x1826EFD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Func<CancellationToken, List<Task>> FAFPMHGLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly CancellationTokenSource LCJMCFAEJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private bool BKEPAEJLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private Task IIJNLEIHGNA;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool CFOOMENBKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x26E0BD0", Offset = "0x26DF3D0", VA = "0x1826E0BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	internal Task FMGIFNPILEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x26E0C00", Offset = "0x26DF400", VA = "0x1826E0C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x26E0D90", Offset = "0x26DF590", VA = "0x1826E0D90")]
	public BOKNACHLMDP(Func<CancellationToken, List<Task>> FAFPMHGLLJF, CancellationToken OFMMACGDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x26E0C80", Offset = "0x26DF480", VA = "0x1826E0C80")]
	[AsyncStateMachine(typeof(PJGJFMJKEAD))]
	public Task PIJHDGMCNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x26E0B80", Offset = "0x26DF380", VA = "0x1826E0B80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class BNNJOEEFPFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly CKFDJHNMMLG NDFHIMKDCBP;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private const string MFFGKCGOBHN = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private const string EGELFOCMAGG = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private const string OONGPNNPIBN = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private const string PGONMPGMJJD = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private string ENOCFMDAPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private long? PHKLAFGKCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private long? KJDEHBEHGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private PPEIDJHDBJL PECDJNDIJEN;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public string OGKLAEPNHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public long IPIMEFBKPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x26E02E0", Offset = "0x26DEAE0", VA = "0x1826E02E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public long JLJDHNCBLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x26E0290", Offset = "0x26DEA90", VA = "0x1826E0290")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PPEIDJHDBJL INMBBFDOFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAC0", Offset = "0x5FA2C0", VA = "0x1805FBAC0")]
		get
		{
			return default(PPEIDJHDBJL);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x26E0660", Offset = "0x26DEE60", VA = "0x1826E0660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x26E0AE0", Offset = "0x26DF2E0", VA = "0x1826E0AE0")]
	[Preserve]
	public BNNJOEEFPFO([APDFHCGIDJC(null)] CKFDJHNMMLG NDFHIMKDCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x26E0740", Offset = "0x26DEF40", VA = "0x1826E0740")]
	private void MMJFBCFBNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x26E08A0", Offset = "0x26DF0A0", VA = "0x1826E08A0")]
	public void NCIPGMDDDAD(long KAJFPAFLIDI, long JKNBPJJDKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x26E0570", Offset = "0x26DED70", VA = "0x1826E0570")]
	public void ICAFPHNNOPD(string LBLPLIJKHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x26E0330", Offset = "0x26DEB30", VA = "0x1826E0330")]
	public void GOJDCFLAEJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class MLELFDCFPHN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct CGFDPHHNICE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public LOEGOPFMLGJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public MLELFDCFPHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<OPMCGNCNGDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x27A93E0", Offset = "0x27A7BE0", VA = "0x1827A93E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x27A97A0", Offset = "0x27A7FA0", VA = "0x1827A97A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct JJBGLLJLKBH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class MCLCAPFECOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public LOEGOPFMLGJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MCLCAPFECOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x27B67E0", Offset = "0x27B4FE0", VA = "0x1827B67E0")]
		internal LOEGOPFMLGJ <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct NMDJDCNBMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<OPMCGNCNGDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public LOEGOPFMLGJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public MLELFDCFPHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EAHKAFHEENN <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<OPMCGNCNGDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x27BB330", Offset = "0x27B9B30", VA = "0x1827BB330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x27BB910", Offset = "0x27BA110", VA = "0x1827BB910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NBJLEJFMGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MLELFDCFPHN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x27B9030", Offset = "0x27B7830", VA = "0x1827B9030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class NNOMCKJEMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NNOMCKJEMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x27BB960", Offset = "0x27BA160", VA = "0x1827BB960")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class IHDGIHPLIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public IHDGIHPLIFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x27AE830", Offset = "0x27AD030", VA = "0x1827AE830")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class PNELBABNFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PNELBABNFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x27BF450", Offset = "0x27BDC50", VA = "0x1827BF450")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class BKABLOHDHOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public BKABLOHDHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x27A8DD0", Offset = "0x27A75D0", VA = "0x1827A8DD0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class EKEDBLHEDOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public MLELFDCFPHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public EKEDBLHEDOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x27AB0B0", Offset = "0x27A98B0", VA = "0x1827AB0B0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class KEMBEEODIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public MLELFDCFPHN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KEMBEEODIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x27B05E0", Offset = "0x27AEDE0", VA = "0x1827B05E0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private static readonly Guid EDCGGBOGOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly CDMMNLEEPDE KANHHANHNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly IFJGNAONOGK PNFEBHCAHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly BMHBGDCHDAO MGEBIGNOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private readonly BGMOBNHBDIK HKIBNBOINHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private bool GPHMHLCJHBP;

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x27B7EB0", Offset = "0x27B66B0", VA = "0x1827B7EB0")]
	public MLELFDCFPHN(CDMMNLEEPDE DMEDCBKJHHF, IFJGNAONOGK PNFEBHCAHJO, BMHBGDCHDAO MGEBIGNOAKH, BGMOBNHBDIK HKIBNBOINHE, MEEOFKIMDJG LDCFAICNFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x27B71B0", Offset = "0x27B59B0", VA = "0x1827B71B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x27B71B0", Offset = "0x27B59B0", VA = "0x1827B71B0")]
	public void OIPJOHPEMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x27B6FF0", Offset = "0x27B57F0", VA = "0x1827B6FF0")]
	public void DLKHMJBDPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x27B7510", Offset = "0x27B5D10", VA = "0x1827B7510")]
	public void HHLLGOOANMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x27B7720", Offset = "0x27B5F20", VA = "0x1827B7720")]
	[AsyncStateMachine(typeof(CGFDPHHNICE))]
	internal Task<LOEGOPFMLGJ> JKEDNKNJPIN(MEEOFKIMDJG LDCFAICNFND, LOEGOPFMLGJ NNKLEGFOJND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2852030", Offset = "0x2850830", VA = "0x182852030")]
	private static byte[] KDOFJGNLJBM<T>(T BOBNBIKICDK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x239E480", Offset = "0x239CC80", VA = "0x18239E480")]
	private static T IAFFBMDCGOF<T>(MessageParser<T> IMPIEJALFND, byte[] BOBNBIKICDK, T MLCOPFDJOOJ) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x27B7D10", Offset = "0x27B6510", VA = "0x1827B7D10")]
	[AsyncStateMachine(typeof(NMDJDCNBMJO))]
	private Task<OPMCGNCNGDN> PMJGNOCEJBB(LOEGOPFMLGJ NNKLEGFOJND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6EE0", Offset = "0x2BC56E0", VA = "0x182BC6EE0")]
	[AsyncStateMachine(typeof(BJPDLCDKAHN))]
	internal Task<T> AFPBCLKJPHD<T>(CancellationToken NDBJLLGGEAE, Func<CancellationToken, Task<T>> BIDHOIFPMMO, int DJKOHKACKHC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x27B69C0", Offset = "0x27B51C0", VA = "0x1827B69C0")]
	[AsyncStateMachine(typeof(NBJLEJFMGHB))]
	internal Task AFPBCLKJPHD(CancellationToken NDBJLLGGEAE, Func<CancellationToken, Task> BIDHOIFPMMO, int DJKOHKACKHC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x27B7120", Offset = "0x27B5920", VA = "0x1827B7120")]
	public LOEGOPFMLGJ DPLNJAFAIKI(EAHKAFHEENN ALDBAOCMLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x27B76B0", Offset = "0x27B5EB0", VA = "0x1827B76B0")]
	public JHDCAFGGIKL JBEOIOFCPMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x27B7640", Offset = "0x27B5E40", VA = "0x1827B7640")]
	public OJKCOKDOBCH IHNOCBFMBGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x27B6B10", Offset = "0x27B5310", VA = "0x1827B6B10")]
	public CKAMCIJJEGK AGFAADOEBJK([Optional] ABFKLCKDGIN? CMDCMNAPIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x27B7CA0", Offset = "0x27B64A0", VA = "0x1827B7CA0")]
	public GJICMEJNIHJ MNIELGOHFII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x27B7380", Offset = "0x27B5B80", VA = "0x1827B7380")]
	public void EHGGCFLBIOB(Func<Guid, bool> EPKLCBJAHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x27B7B20", Offset = "0x27B6320", VA = "0x1827B7B20")]
	public void JLONEPNGHPL(Func<Guid, bool> MLLGEPHFGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x27B6D70", Offset = "0x27B5570", VA = "0x1827B6D70")]
	public void BJLPKGJHKGM(Func<Guid, bool> EPKLCBJAHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x27B6BA0", Offset = "0x27B53A0", VA = "0x1827B6BA0")]
	public Guid BFNPBKBKKCA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x27B73B0", Offset = "0x27B5BB0", VA = "0x1827B73B0")]
	public void GKJIBENJIIL(Guid LABJHJNAAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x27B6ED0", Offset = "0x27B56D0", VA = "0x1827B6ED0")]
	public void BKGCMFGDCFA(LOEGOPFMLGJ ILNEFLPNECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x27B79D0", Offset = "0x27B61D0", VA = "0x1827B79D0")]
	public void JLNHLIMCGLP(string NHJFMHMCGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x27B7880", Offset = "0x27B6080", VA = "0x1827B7880")]
	public void JLNHLIMCGLP(Func<string> NEEGDGBDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x239E400", Offset = "0x239CC00", VA = "0x18239E400")]
	private T CACPPEPDDGB<T>(T HKJMLEKHILN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x27B7330", Offset = "0x27B5B30", VA = "0x1827B7330")]
	public void EFNBEABLAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7060", Offset = "0x2BC5860", VA = "0x182BC7060")]
	[CompilerGenerated]
	internal static string DMKKBKKLPHM<T>(byte[] IFAOIOLKGMC, int DDMJJEGIIGO, ref JJBGLLJLKBH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal sealed class BHJGHIEGFOH : CDMMNLEEPDE
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class DBHCHGMDHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public DBHCHGMDHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x26E4E10", Offset = "0x26E3610", VA = "0x1826E4E10")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct PLFKLBBMPHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public BHJGHIEGFOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private OJKCOKDOBCH <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x26EFF00", Offset = "0x26EE700", VA = "0x1826EFF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class BHLBLEAGANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public GNPBKMICIEC presence;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public BHLBLEAGANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x26DEB00", Offset = "0x26DD300", VA = "0x1826DEB00")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private readonly NPDKPEMMJOC IKFANGMNOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private readonly GEKAFNAJGCN ONHGPHADMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private readonly JEIAGLKFBJG NJELGJOOLLF;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private const bool ELABPLLNLDE = false;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x26DE910", Offset = "0x26DD110", VA = "0x1826DE910")]
	public BHJGHIEGFOH(NPDKPEMMJOC IKFANGMNOOP, GEKAFNAJGCN ONHGPHADMFD, Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, LBJKCPGAKPO HGPOMDBODEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x26DE7C0", Offset = "0x26DCFC0", VA = "0x1826DE7C0", Slot = "8")]
	[AsyncStateMachine(typeof(PLFKLBBMPHC))]
	protected override Task JEBJJJMOHFA(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x26DE360", Offset = "0x26DCB60", VA = "0x1826DE360")]
	private GNPBKMICIEC GBBKDOKAAPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x26DE680", Offset = "0x26DCE80", VA = "0x1826DE680")]
	private void GFEIFFJDIPE(GNPBKMICIEC LEFNIPJKGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x26DE2D0", Offset = "0x26DCAD0", VA = "0x1826DE2D0")]
	private static void AKPDKOLFLOH(GEKAFNAJGCN CGBILKONHNN, [Optional] string BOBNBIKICDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class LBFMFCPFGMC : CDMMNLEEPDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct GMIMDNBBIDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public LBFMFCPFGMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter<GCOPJEEKJNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x27ACA90", Offset = "0x27AB290", VA = "0x1827ACA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private readonly int BOAPMOPGAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private readonly GPHANIMPAPP FLBPMDDEMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public readonly long DNNPDBMNFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public readonly long AMEAGLCPNMP;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x27B3120", Offset = "0x27B1920", VA = "0x1827B3120")]
	public LBFMFCPFGMC(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, LBJKCPGAKPO HGPOMDBODEK, int BOAPMOPGAID, GPHANIMPAPP FLBPMDDEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x27B2FE0", Offset = "0x27B17E0", VA = "0x1827B2FE0", Slot = "8")]
	[AsyncStateMachine(typeof(GMIMDNBBIDJ))]
	protected override Task JEBJJJMOHFA(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal abstract class DEAEJIFKOND : CDMMNLEEPDE
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class HKNOEHMKKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public DEAEJIFKOND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public OAPLNDEGFOH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HKNOEHMKKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x26EB800", Offset = "0x26EA000", VA = "0x1826EB800")]
		internal Task <RunAsync>b__0(MEEOFKIMDJG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x26EB840", Offset = "0x26EA040", VA = "0x1826EB840")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct EPJHLDCIFKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public DEAEJIFKOND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private HKNOEHMKKNO <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x26E77D0", Offset = "0x26E5FD0", VA = "0x1826E77D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct OMNPLJCEOAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public OAPLNDEGFOH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public DEAEJIFKOND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x26EF960", Offset = "0x26EE160", VA = "0x1826EF960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x26E5110", Offset = "0x26E3910", VA = "0x1826E5110")]
	public DEAEJIFKOND(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, LBJKCPGAKPO HGPOMDBODEK, string KGPANIINCKI, bool GHJGPKGPAKN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x26E4FD0", Offset = "0x26E37D0", VA = "0x1826E4FD0", Slot = "8")]
	[AsyncStateMachine(typeof(EPJHLDCIFKD))]
	protected override Task JEBJJJMOHFA(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task EOMNGPMENAN(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x26E4E70", Offset = "0x26E3670", VA = "0x1826E4E70")]
	[AsyncStateMachine(typeof(OMNPLJCEOAO))]
	private Task EPCECCAMAPF(IDisposable GBKLNDGAOPJ, OAPLNDEGFOH EFOGFKGOIAD, MEEOFKIMDJG JABEDHNBEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class NHEHBKOJILN : CDMMNLEEPDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct LLKCKCCFFJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public NHEHBKOJILN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private GJICMEJNIHJ <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<CLBOCFKIALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x27B52C0", Offset = "0x27B3AC0", VA = "0x1827B52C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly GPHANIMPAPP FLBPMDDEMNL;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x27B9950", Offset = "0x27B8150", VA = "0x1827B9950")]
	public NHEHBKOJILN(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, LBJKCPGAKPO HGPOMDBODEK, GPHANIMPAPP FLBPMDDEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x27B9880", Offset = "0x27B8080", VA = "0x1827B9880", Slot = "7")]
	protected override string MIGBAPCLILK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x27B9740", Offset = "0x27B7F40", VA = "0x1827B9740", Slot = "8")]
	[AsyncStateMachine(typeof(LLKCKCCFFJN))]
	protected override Task JEBJJJMOHFA(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal abstract class CDMMNLEEPDE : HBOCEOFFBMC
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public delegate Task HLIIBJAEFCL(MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class GCHBJCJPJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public MEEOFKIMDJG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CDMMNLEEPDE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GCHBJCJPJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x26EA470", Offset = "0x26E8C70", VA = "0x1826EA470")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class DAOAIADACMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public GCHBJCJPJAD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public DAOAIADACMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x26E4C90", Offset = "0x26E3490", VA = "0x1826E4C90")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x26E4D50", Offset = "0x26E3550", VA = "0x1826E4D50")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct MGAILMAMMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CDMMNLEEPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Func<CDMMNLEEPDE, MEEOFKIMDJG, MLELFDCFPHN> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private GCHBJCJPJAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private MLELFDCFPHN <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x26ECF30", Offset = "0x26EB730", VA = "0x1826ECF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct COOHAJKHABP : IAsyncStateMachine
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
		public CDMMNLEEPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x26E49E0", Offset = "0x26E31E0", VA = "0x1826E49E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public readonly Guid ABMDNDNLBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public readonly ByteString OPCLJMBIKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public readonly LBJKCPGAKPO AIOFOCBAPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	protected readonly string CMDMNGMCAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private readonly bool GHJGPKGPAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private bool LPGPKKNNHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public PPEIDJHDBJL LDLBDKHBODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public PPEIDJHDBJL LIFOAMMMMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly Queue<HLIIBJAEFCL> CBGDAAHBION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly BNKIBKJLBKC MEIBMMNBOKH;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FJNKKCMAFBG NCKGJOIPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5726E0", VA = "0x180573EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x26E10B0", Offset = "0x26DF8B0", VA = "0x1826E10B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x26E12C0", Offset = "0x26DFAC0", VA = "0x1826E12C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float KGMODKBKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x26E1340", Offset = "0x26DFB40", VA = "0x1826E1340", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event GGPHJFNMMNN GMPKCKAOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x26E1560", Offset = "0x26DFD60", VA = "0x1826E1560", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x26E1090", Offset = "0x26DF890", VA = "0x1826E1090", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x26E1620", Offset = "0x26DFE20", VA = "0x1826E1620")]
	protected CDMMNLEEPDE(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, LBJKCPGAKPO HGPOMDBODEK, string KGPANIINCKI, bool GHJGPKGPAKN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x26E1580", Offset = "0x26DFD80", VA = "0x1826E1580", Slot = "7")]
	protected virtual string MIGBAPCLILK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x26E15C0", Offset = "0x26DFDC0", VA = "0x1826E15C0")]
	public void PHFNKAKLADB(HLIIBJAEFCL LNKKBJGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x26E1360", Offset = "0x26DFB60", VA = "0x1826E1360")]
	protected void HKGGPFHJEBF(float BNLGOIPIEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x26E1100", Offset = "0x26DF900", VA = "0x1826E1100")]
	[AsyncStateMachine(typeof(MGAILMAMMOK))]
	public Task DINOIOCBAJK(CancellationToken OFMMACGDFGM, MEEOFKIMDJG LDCFAICNFND, [Optional] Func<CDMMNLEEPDE, MEEOFKIMDJG, MLELFDCFPHN> KOKGPFAAEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x26E1380", Offset = "0x26DFB80", VA = "0x1826E1380")]
	private void HMEFAJFNLJJ(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JEBJJJMOHFA(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x26E0F50", Offset = "0x26DF750", VA = "0x1826E0F50")]
	[AsyncStateMachine(typeof(COOHAJKHABP))]
	private Task BAKLAOMKNJE(MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x26E1240", Offset = "0x26DFA40", VA = "0x1826E1240")]
	public LOEGOPFMLGJ DPLNJAFAIKI(EAHKAFHEENN ALDBAOCMLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x26E1490", Offset = "0x26DFC90", VA = "0x1826E1490")]
	[CompilerGenerated]
	private Task LBHNCHEPCDG(CancellationToken AELOFOBLNEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal sealed class OMLLCIAEPID : DEAEJIFKOND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct AGPDDMGCPNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public OMLLCIAEPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private COPJBADKNJB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private OJKCOKDOBCH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D6B0", Offset = "0x4F7BEB0", VA = "0x184F7D6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private readonly NPDKPEMMJOC IJABGIIHCED;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F813D0", Offset = "0x4F7FBD0", VA = "0x184F813D0")]
	public OMLLCIAEPID(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, NPDKPEMMJOC IJABGIIHCED, LBJKCPGAKPO HGPOMDBODEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F81290", Offset = "0x4F7FA90", VA = "0x184F81290", Slot = "9")]
	[AsyncStateMachine(typeof(AGPDDMGCPNN))]
	protected override Task EOMNGPMENAN(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class OGFKHKGBOGB : CDMMNLEEPDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct LPPFEPPAIMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public OGFKHKGBOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private TaskAwaiter<CLBOCFKIALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x27B5E90", Offset = "0x27B4690", VA = "0x1827B5E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private readonly string NBPFKJBAGFJ;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x27BD730", Offset = "0x27BBF30", VA = "0x1827BD730")]
	public OGFKHKGBOGB(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, LBJKCPGAKPO HGPOMDBODEK, string NBPFKJBAGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x27BD600", Offset = "0x27BBE00", VA = "0x1827BD600", Slot = "8")]
	[AsyncStateMachine(typeof(LPPFEPPAIMC))]
	protected override Task JEBJJJMOHFA(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class CGAPIDADJBN : DEAEJIFKOND
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class IEHPDPCDMGK
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
			public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public IEHPDPCDMGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private TaskAwaiter<CLBOCFKIALB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			private TaskAwaiter<LOEGOPFMLGJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x26F1260", Offset = "0x26EFA60", VA = "0x1826F1260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x26F1700", Offset = "0x26EFF00", VA = "0x1826F1700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public CGAPIDADJBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public CKAMCIJJEGK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public JHDCAFGGIKL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public IEHPDPCDMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x26EBAC0", Offset = "0x26EA2C0", VA = "0x1826EBAC0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<LOEGOPFMLGJ> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct KLMCCANPIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public CGAPIDADJBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private IEHPDPCDMGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private COPJBADKNJB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private OJKCOKDOBCH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x26EC630", Offset = "0x26EAE30", VA = "0x1826EC630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly int DPJCEOJFFFH;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x26E1B60", Offset = "0x26E0360", VA = "0x1826E1B60")]
	public CGAPIDADJBN(Guid ANNDHKOFOGN, FJNKKCMAFBG FLLINPNBDAE, int DPJCEOJFFFH, LBJKCPGAKPO HGPOMDBODEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x26E1740", Offset = "0x26DFF40", VA = "0x1826E1740", Slot = "9")]
	[AsyncStateMachine(typeof(KLMCCANPIBO))]
	protected override Task EOMNGPMENAN(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x26E1A60", Offset = "0x26E0260", VA = "0x1826E1A60")]
	private void MAIGBFKCIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x26E1880", Offset = "0x26E0080", VA = "0x1826E1880")]
	private void LHAAKKOEGBJ(MEEOFKIMDJG LDCFAICNFND, COPJBADKNJB PKKMHBCJEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal abstract class IBIMOBPDEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public readonly CDMMNLEEPDE KANHHANHNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public readonly MLELFDCFPHN GGAIMDGKOAL;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x266B380", Offset = "0x2669B80", VA = "0x18266B380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x266B3A0", Offset = "0x2669BA0", VA = "0x18266B3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2665460", Offset = "0x2663C60", VA = "0x182665460")]
	protected IBIMOBPDEIM(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x266B400", Offset = "0x2669C00", VA = "0x18266B400")]
	protected void JLNHLIMCGLP(string NHJFMHMCGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x266B420", Offset = "0x2669C20", VA = "0x18266B420")]
	public void JLNHLIMCGLP(Func<string> NEEGDGBDEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal struct ABDMMFPOEIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public Dictionary<Guid, List<IHFNBAMFLDO>> HMEBPOJAJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public Dictionary<Guid, List<IHFNBAMFLDO>> NNFBDMLIOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public Dictionary<Guid, List<IHFNBAMFLDO>> FJOCHLJAPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public List<Guid> JMANBGBEEDP;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC80", Offset = "0x26D9480", VA = "0x1826DAC80")]
	public static ABDMMFPOEIB NMFOBHDGKIK(BDFGPLEIHNL JMODMMLPIOO, PPEIDJHDBJL EOJKBNHIBFL, CJKDIAAFKFC DGMFPGGMIFB)
	{
		return default(ABDMMFPOEIB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal struct OJACPAIOGBK
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0")]
	public static OJACPAIOGBK DIFMOOHBFDA()
	{
		return default(OJACPAIOGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void EGJFLJDOCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KAHFLHPGJCI(CJKDIAAFKFC BPPCNFHJMAA, object BOJHDPJNBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void PPDDDDNJOHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct BHHJNHKDOLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public readonly GCOPJEEKJNO CCJDEKJHJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly PHHLPNBKNCF JDFBEAMOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly BCCEKCGBIPG EFJFBLCPDFF;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x26DE280", Offset = "0x26DCA80", VA = "0x1826DE280")]
	public BHHJNHKDOLG(GCOPJEEKJNO CCJDEKJHJKC, PHHLPNBKNCF JDFBEAMOHNE, BCCEKCGBIPG EFJFBLCPDFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal struct KBHHEPOIGMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly MLELFDCFPHN LAFDKHLHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly Guid LABJHJNAAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private bool OFPOIOGNNHO;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x27AFAF0", Offset = "0x27AE2F0", VA = "0x1827AFAF0")]
	public static KBHHEPOIGMC BFNPBKBKKCA(MLELFDCFPHN LAFDKHLHOAJ)
	{
		return default(KBHHEPOIGMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x85B220", Offset = "0x859A20", VA = "0x18085B220")]
	public void KDOCHDEBLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x27AFB20", Offset = "0x27AE320", VA = "0x1827AFB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x27AFEB0", Offset = "0x27AE6B0", VA = "0x1827AFEB0")]
	private KBHHEPOIGMC(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x27AFB30", Offset = "0x27AE330", VA = "0x1827AFB30")]
	private void GKJIBENJIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x27AFE00", Offset = "0x27AE600", VA = "0x1827AFE00")]
	private Func<Guid, bool> MMGJBDIPELJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class OJKCOKDOBCH : IBIMOBPDEIM, HBOCEOFFBMC
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public delegate Task<PPEIDJHDBJL> LKKFOPAEAFN(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN DLIIJFKABMD, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct NHKPANADNJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public NPDKPEMMJOC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private KBHHEPOIGMC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x27B99E0", Offset = "0x27B81E0", VA = "0x1827B99E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct DFFMLOIGJDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public NPDKPEMMJOC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private MEEOFKIMDJG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x27AA410", Offset = "0x27A8C10", VA = "0x1827AA410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x27AA7E0", Offset = "0x27A8FE0", VA = "0x1827AA7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct PLEBFPHPIAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public NPDKPEMMJOC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private MEEOFKIMDJG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4F82900", Offset = "0x4F81100", VA = "0x184F82900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct HDKOBPBJOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public NPDKPEMMJOC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private CJKDIAAFKFC <phaseArgs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<BHHJNHKDOLG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private TaskAwaiter<CJKDIAAFKFC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private PPMHGNMDONN <timedYielder>5__3;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x27ACFC0", Offset = "0x27AB7C0", VA = "0x1827ACFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct IJIGIMMIKLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x27AE890", Offset = "0x27AD090", VA = "0x1827AE890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct HOOKMAGJILA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private MEEOFKIMDJG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x27AE210", Offset = "0x27ACA10", VA = "0x1827AE210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct LAFOGJKGLOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private MEEOFKIMDJG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private OAOGIHICBJB.CGOICGENDIF <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter<OAOGIHICBJB.CGOICGENDIF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x27B23A0", Offset = "0x27B0BA0", VA = "0x1827B23A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x27B2F90", Offset = "0x27B1790", VA = "0x1827B2F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct LJALEJFJADJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public PPMHGNMDONN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private MEEOFKIMDJG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x27B3B50", Offset = "0x27B2350", VA = "0x1827B3B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x27B47E0", Offset = "0x27B2FE0", VA = "0x1827B47E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct GLMHHGAJBME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public PPEIDJHDBJL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public CJKDIAAFKFC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x27AC7E0", Offset = "0x27AAFE0", VA = "0x1827AC7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x27ACA40", Offset = "0x27AB240", VA = "0x1827ACA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class DOIFNJBFLBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public LKKFOPAEAFN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public PPMHGNMDONN timedYielder;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public DOIFNJBFLBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class OPAMEANMBAN
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
			public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public OPAMEANMBAN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			private TaskAwaiter<PPEIDJHDBJL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x4F82FA0", Offset = "0x4F817A0", VA = "0x184F82FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x4F83470", Offset = "0x4F81C70", VA = "0x184F83470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public PPEIDJHDBJL originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public DOIFNJBFLBE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public OPAMEANMBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x4F81470", Offset = "0x4F7FC70", VA = "0x184F81470")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<PPEIDJHDBJL> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct FJPLDJNMLKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public LKKFOPAEAFN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public PPMHGNMDONN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x27AB3A0", Offset = "0x27A9BA0", VA = "0x1827AB3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x27AB7B0", Offset = "0x27A9FB0", VA = "0x1827AB7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct CEPKJAOMACE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private PPEIDJHDBJL <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private IEnumerator<PPEIDJHDBJL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x27A9090", Offset = "0x27A7890", VA = "0x1827A9090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct KOHMHADBMEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x27B2190", Offset = "0x27B0990", VA = "0x1827B2190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct BOHGPDMOHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public AsyncTaskMethodBuilder<OAOGIHICBJB.CGOICGENDIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public OJKCOKDOBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private TaskAwaiter<OAOGIHICBJB.CGOICGENDIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x27A8E30", Offset = "0x27A7630", VA = "0x1827A8E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x27A9040", Offset = "0x27A7840", VA = "0x1827A9040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class PMFLDPOPDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public GCOPJEEKJNO roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PMFLDPOPDKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x4F82B40", Offset = "0x4F81340", VA = "0x184F82B40")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private static readonly PPEIDJHDBJL[] DFPFEAJMDGI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private static readonly int AAMALEPAKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private readonly MHJKMEIIICB FBEGDELPEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private readonly MHJKMEIIICB BOFDAHHODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private readonly BNNJOEEFPFO POOLKBEICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private readonly BMLEJEFEGAH LCDNHHLGBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private readonly GAGLEACPIII BELECFPAKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private readonly BNKIBKJLBKC MEIBMMNBOKH;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float KGMODKBKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x26E1340", Offset = "0x26DFB40", VA = "0x1826E1340", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private FJNKKCMAFBG NCKGJOIPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x266E3D0", Offset = "0x266CBD0", VA = "0x18266E3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GGPHJFNMMNN GMPKCKAOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x26E1560", Offset = "0x26DFD60", VA = "0x1826E1560", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x26E1090", Offset = "0x26DF890", VA = "0x1826E1090", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x27BEF40", Offset = "0x27BD740", VA = "0x1827BEF40")]
	public OJKCOKDOBCH(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x27BE2E0", Offset = "0x27BCAE0", VA = "0x1827BE2E0")]
	[AsyncStateMachine(typeof(NHKPANADNJM))]
	public Task HKDLJCJPKLH(NPDKPEMMJOC EPNHPDGPFKK, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x27BEA60", Offset = "0x27BD260", VA = "0x1827BEA60")]
	[AsyncStateMachine(typeof(DFFMLOIGJDL))]
	private Task<LOEGOPFMLGJ> MHBOIAIKPHN(NPDKPEMMJOC EPNHPDGPFKK, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x27BDBC0", Offset = "0x27BC3C0", VA = "0x1827BDBC0")]
	[AsyncStateMachine(typeof(PLEBFPHPIAJ))]
	private Task BKCLPHDKDIG(NPDKPEMMJOC EPNHPDGPFKK, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x27BE920", Offset = "0x27BD120", VA = "0x1827BE920")]
	[AsyncStateMachine(typeof(HDKOBPBJOPH))]
	private Task LHPLCJIKHIJ(NPDKPEMMJOC EPNHPDGPFKK, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x27BD7D0", Offset = "0x27BBFD0", VA = "0x1827BD7D0")]
	[AsyncStateMachine(typeof(IJIGIMMIKLD))]
	private Task ABEHMLBJOPC(MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x27BE440", Offset = "0x27BCC40", VA = "0x1827BE440")]
	[AsyncStateMachine(typeof(HOOKMAGJILA))]
	private Task IOEMLNMKFDL(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x27BDA80", Offset = "0x27BC280", VA = "0x1827BDA80")]
	[AsyncStateMachine(typeof(LAFOGJKGLOH))]
	private Task<PPEIDJHDBJL> BIIECLKCBML(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x27BD920", Offset = "0x27BC120", VA = "0x1827BD920")]
	[AsyncStateMachine(typeof(LJALEJFJADJ))]
	private Task<PPEIDJHDBJL> ALHNNIGOIMH(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x27BE030", Offset = "0x27BC830", VA = "0x1827BE030")]
	[AsyncStateMachine(typeof(GLMHHGAJBME))]
	private Task<PPEIDJHDBJL> GPAMPIBEEPJ(PPEIDJHDBJL EOJKBNHIBFL, CJKDIAAFKFC DGMFPGGMIFB, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM, bool EDFLDFIKBFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x27BDF40", Offset = "0x27BC740", VA = "0x1827BDF40")]
	private bool GEACGGOHHGC(CJKDIAAFKFC BCGDBDFBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x27BE5E0", Offset = "0x27BCDE0", VA = "0x1827BE5E0")]
	[AsyncStateMachine(typeof(FJPLDJNMLKL))]
	protected Task<PPEIDJHDBJL> JKFKHCJOPLK(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM, LKKFOPAEAFN MDMBICJELIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x27BED00", Offset = "0x27BD500", VA = "0x1827BED00")]
	[AsyncStateMachine(typeof(CEPKJAOMACE))]
	private Task OEJLFPAMPNO(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x27BDD10", Offset = "0x27BC510", VA = "0x1827BDD10")]
	private void BKOKFMIDLED(PPEIDJHDBJL PKFPJLOOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x27BE750", Offset = "0x27BCF50", VA = "0x1827BE750")]
	private Task<BHHJNHKDOLG> KADFJAKELJO(NPDKPEMMJOC EPNHPDGPFKK, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x27BE580", Offset = "0x27BCD80", VA = "0x1827BE580")]
	private Task<CJKDIAAFKFC> JAAEBKPJDIF(NPDKPEMMJOC EPNHPDGPFKK, BHHJNHKDOLG BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x27BE190", Offset = "0x27BC990", VA = "0x1827BE190")]
	[AsyncStateMachine(typeof(KOHMHADBMEF))]
	private Task HHIFDPNMLPF(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x27BDDF0", Offset = "0x27BC5F0", VA = "0x1827BDDF0")]
	[AsyncStateMachine(typeof(BOHGPDMOHOA))]
	private Task<OAOGIHICBJB.CGOICGENDIF> FBEMIDKPEMP(CJKDIAAFKFC BPPCNFHJMAA, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x27BE8C0", Offset = "0x27BD0C0", VA = "0x1827BE8C0")]
	private Task KMFPPFGNEHL(CJKDIAAFKFC BPPCNFHJMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x27BE420", Offset = "0x27BCC20", VA = "0x1827BE420")]
	private Task HLBHIOKOAMK(CJKDIAAFKFC BPPCNFHJMAA, OAOGIHICBJB.CGOICGENDIF PHABLJMKIEE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x27BEBC0", Offset = "0x27BD3C0", VA = "0x1827BEBC0")]
	private Task MNDPLHEDCAC(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x27BDF20", Offset = "0x27BC720", VA = "0x1827BDF20")]
	private Task FJBEGDJACIN(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x27B8090", Offset = "0x27B6890", VA = "0x1827B8090")]
	private static Task NKHIJDIBGNN(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x27BD900", Offset = "0x27BC100", VA = "0x1827BD900")]
	private Task AEHELDEOEEJ(CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x27BE5C0", Offset = "0x27BCDC0", VA = "0x1827BE5C0")]
	private Task JGNAOOAKKHC(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x27BE8F0", Offset = "0x27BD0F0", VA = "0x1827BE8F0")]
	private void LHEBFKMIEJB(NPDKPEMMJOC EPNHPDGPFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x27BE790", Offset = "0x27BCF90", VA = "0x1827BE790")]
	private static void KCLPDONBHAP(GCOPJEEKJNO CCJDEKJHJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal struct OAOGIHICBJB
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public struct CGOICGENDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public readonly Dictionary<int, int> BAMNOLNFPOP;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x719100", Offset = "0x717900", VA = "0x180719100")]
		public CGOICGENDIF(Dictionary<int, int> BAMNOLNFPOP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private PPEIDJHDBJL PKFPJLOOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private CJKDIAAFKFC BPPCNFHJMAA;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x27BCD50", Offset = "0x27BB550", VA = "0x1827BCD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x27BD0F0", Offset = "0x27BB8F0", VA = "0x1827BD0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x27BD040", Offset = "0x27BB840", VA = "0x1827BD040")]
	public static Task<CGOICGENDIF> DINOIOCBAJK(FJNKKCMAFBG FLLINPNBDAE, PPEIDJHDBJL PKFPJLOOPID, CJKDIAAFKFC BPPCNFHJMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x27BCDA0", Offset = "0x27BB5A0", VA = "0x1827BCDA0")]
	private CGOICGENDIF DINOIOCBAJK()
	{
		return default(CGOICGENDIF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal struct MPBIFLHCNAF
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x27B8090", Offset = "0x27B6890", VA = "0x1827B8090")]
	public static Task DINOIOCBAJK(CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal struct FBKPLFBJENN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct PNIBEDEPGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private MEEOFKIMDJG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x26F0700", Offset = "0x26EEF00", VA = "0x1826F0700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x26E8260", Offset = "0x26E6A60", VA = "0x1826E8260")]
	[AsyncStateMachine(typeof(PNIBEDEPGDL))]
	public static Task DINOIOCBAJK(MLELFDCFPHN LAFDKHLHOAJ, CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal struct JFGEHIGOBEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct MGLGACDLGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public PPMHGNMDONN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private PPEIDJHDBJL <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private FJNKKCMAFBG <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private BDFGPLEIHNL <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private List<(PersistenceView, BFCODEDDDPM)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private BFCODEDDDPM <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2672540", Offset = "0x2670D40", VA = "0x182672540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x266E260", Offset = "0x266CA60", VA = "0x18266E260")]
	[AsyncStateMachine(typeof(MGLGACDLGEJ))]
	public static Task DINOIOCBAJK(MLELFDCFPHN LAFDKHLHOAJ, CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x266DFF0", Offset = "0x266C7F0", VA = "0x18266DFF0")]
	private static void AAAPHPJKEEN(PersistenceView IOBPGNIOIGA, BFCODEDDDPM BOJHDPJNBCO, CJKDIAAFKFC BPPCNFHJMAA, PPEIDJHDBJL EOJKBNHIBFL, bool CLJDBGJIJDP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal struct BINDOOCKABF
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x26DEC30", Offset = "0x26DD430", VA = "0x1826DEC30")]
	public static Task DINOIOCBAJK(FJNKKCMAFBG FLLINPNBDAE, CJKDIAAFKFC BPPCNFHJMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct AAPCFCHJJNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct KJHOKIAOFKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public FJNKKCMAFBG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public PPEIDJHDBJL roomOperationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x26EC4A0", Offset = "0x26EACA0", VA = "0x1826EC4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct NMIHHHHBNAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AAPCFCHJJNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x26EEFB0", Offset = "0x26ED7B0", VA = "0x1826EEFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class HMEAOLAOOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CEFBCOJIEHB version;

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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HMEAOLAOOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x26EB940", Offset = "0x26EA140", VA = "0x1826EB940")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x26EB9F0", Offset = "0x26EA1F0", VA = "0x1826EB9F0")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private PPEIDJHDBJL PKFPJLOOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private CJKDIAAFKFC BPPCNFHJMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private MLELFDCFPHN LAFDKHLHOAJ;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private static readonly ByteString ICKDBFPOCIB;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x26DA280", Offset = "0x26D8A80", VA = "0x1826DA280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private IEGKCNHAEKM AONEAFOMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x26DAB80", Offset = "0x26D9380", VA = "0x1826DAB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x26DA2D0", Offset = "0x26D8AD0", VA = "0x1826DA2D0")]
	[AsyncStateMachine(typeof(KJHOKIAOFKO))]
	public static Task DINOIOCBAJK(FJNKKCMAFBG FLLINPNBDAE, PPEIDJHDBJL PKFPJLOOPID, CJKDIAAFKFC BPPCNFHJMAA, MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x26DA430", Offset = "0x26D8C30", VA = "0x1826DA430")]
	[AsyncStateMachine(typeof(NMIHHHHBNAE))]
	private Task DINOIOCBAJK(MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x26DA580", Offset = "0x26D8D80", VA = "0x1826DA580")]
	private void EFHPFENIMNI([NotNull] EBEEBEHBHPB DMLBGCKPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x26DAB50", Offset = "0x26D9350", VA = "0x1826DAB50")]
	private bool EGMCKJCGFBM(CEFBCOJIEHB CDHIMBPFFEA, EBEEBEHBHPB DMLBGCKPNNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct IIGADAAMKFO
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private struct MPBGANFKLOE<Arg, Parsed> where Parsed : IMessage<Parsed>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private readonly global::GMOODAOILIL<Arg> GOFBGEAILKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly global::HFDBOONCCIB<Parsed> IMPIEJALFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly global::EBBOCJLNNIE<Parsed> FDELJFKNMFG;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x570E10", Offset = "0x56F610", VA = "0x180570E10")]
		public MPBGANFKLOE(global::GMOODAOILIL<Arg> GOFBGEAILKL, global::HFDBOONCCIB<Parsed> IMPIEJALFND, global::EBBOCJLNNIE<Parsed> FDELJFKNMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2A46650", Offset = "0x2A44E50", VA = "0x182A46650")]
		[AsyncStateMachine(typeof(MOLOPOBBBBP))]
		public Task<Parsed> KMKJFIAMOEP(Arg NJMKOLAAABP, string MIAJDFJMHLI, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2A45F50", Offset = "0x2A44750", VA = "0x182A45F50")]
		[AsyncStateMachine(typeof(NGHMMCGKIBC))]
		private Task<byte[]> DICAIGGNJHP(Arg NJMKOLAAABP, CancellationToken OFMMACGDFGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2A46470", Offset = "0x2A44C70", VA = "0x182A46470")]
		private Parsed HFLCMJDELKE(byte[] ELNOMEEHLMM)
		{
			return (Parsed)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct HDLMFGKLOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder<CJKDIAAFKFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IIGADAAMKFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private MEEOFKIMDJG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<(EBEEBEHBHPB, GIGGKGPFNLC, FIBMEMNOJEJ)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2666270", Offset = "0x2664A70", VA = "0x182666270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x26668F0", Offset = "0x26650F0", VA = "0x1826668F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private MPBGANFKLOE<JGADFMOHFPD, EBEEBEHBHPB> JDFBEAMOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private MPBGANFKLOE<JGADFMOHFPD, GIGGKGPFNLC> KGOEBODJCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private MPBGANFKLOE<long, FIBMEMNOJEJ> HFJKOBHPMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private NPDKPEMMJOC EPNHPDGPFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private GCOPJEEKJNO CCJDEKJHJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private PHHLPNBKNCF BBFNLLFBOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private MEEOFKIMDJG JABEDHNBEFJ;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x266B920", Offset = "0x266A120", VA = "0x18266B920")]
	public static Task<CJKDIAAFKFC> FMMGCOPPECP(FJNKKCMAFBG FLLINPNBDAE, NPDKPEMMJOC EPNHPDGPFKK, in BHHJNHKDOLG BPPCNFHJMAA, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x266B7A0", Offset = "0x2669FA0", VA = "0x18266B7A0")]
	[AsyncStateMachine(typeof(HDLMFGKLOBN))]
	private Task<CJKDIAAFKFC> DINOIOCBAJK(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x266B760", Offset = "0x2669F60", VA = "0x18266B760")]
	private JGADFMOHFPD BFCKDGNJCLO(LDICDFOPAHO LDNCIEBMBCJ)
	{
		return default(JGADFMOHFPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct FHBPBHKABIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct JALOABNKAMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder<BHHJNHKDOLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public FHBPBHKABIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private MEEOFKIMDJG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<BHHJNHKDOLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x26EBBE0", Offset = "0x26EA3E0", VA = "0x1826EBBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x26EBFA0", Offset = "0x26EA7A0", VA = "0x1826EBFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct GIFOFCCNPOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder<BHHJNHKDOLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public FHBPBHKABIE <>4__this;

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
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<BHHJNHKDOLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x26EA5C0", Offset = "0x26E8DC0", VA = "0x1826EA5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x26EA790", Offset = "0x26E8F90", VA = "0x1826EA790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class PNMBBHPKDKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PNMBBHPKDKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xB09390", Offset = "0xB07B90", VA = "0x180B09390")]
		internal bool <FetchRoomDetails>b__0(PHHLPNBKNCF sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct HAHAEGHCGLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<BHHJNHKDOLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public BDFGPLEIHNL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private PNMBBHPKDKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter<GCOPJEEKJNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x26EB370", Offset = "0x26E9B70", VA = "0x1826EB370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x26EB7B0", Offset = "0x26E9FB0", VA = "0x1826EB7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private BNNJOEEFPFO POOLKBEICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private MEEOFKIMDJG JABEDHNBEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private long KAJFPAFLIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private long JKNBPJJDKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private JGADFMOHFPD LOALCNDKHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private JGADFMOHFPD GMOLFGHCDKE;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x26E9100", Offset = "0x26E7900", VA = "0x1826E9100")]
	public static Task<BHHJNHKDOLG> FMMGCOPPECP(FJNKKCMAFBG FLLINPNBDAE, NPDKPEMMJOC EPNHPDGPFKK, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x26E8EB0", Offset = "0x26E76B0", VA = "0x1826E8EB0")]
	[AsyncStateMachine(typeof(JALOABNKAMH))]
	private Task<BHHJNHKDOLG> DINOIOCBAJK(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x26E9310", Offset = "0x26E7B10", VA = "0x1826E9310")]
	[AsyncStateMachine(typeof(GIFOFCCNPOH))]
	private Task<BHHJNHKDOLG> KADFJAKELJO(long KAJFPAFLIDI, long JKNBPJJDKBB, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM, bool MFFLNBMLGLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x26E9490", Offset = "0x26E7C90", VA = "0x1826E9490")]
	[AsyncStateMachine(typeof(HAHAEGHCGLD))]
	public static Task<BHHJNHKDOLG> KADFJAKELJO(BDFGPLEIHNL JMODMMLPIOO, long KAJFPAFLIDI, long JKNBPJJDKBB, CancellationToken OFMMACGDFGM, MEEOFKIMDJG LDCFAICNFND, bool MFFLNBMLGLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x26E9000", Offset = "0x26E7800", VA = "0x1826E9000")]
	private void EJPJEHDHJFE(GCOPJEEKJNO CCJDEKJHJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x26E9740", Offset = "0x26E7F40", VA = "0x1826E9740")]
	private bool MOBMOINGJLO(BHHJNHKDOLG BPPCNFHJMAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x26E95E0", Offset = "0x26E7DE0", VA = "0x1826E95E0")]
	private void LMKPCBHDCGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct PJLLMCFHBMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct EPDONMHBAPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public PJLLMCFHBMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DD40", Offset = "0x4F7C540", VA = "0x184F7DD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private const int AEFFDLIKEID = 20;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private const float IKMHEDHIJLE = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private BDFGPLEIHNL JMODMMLPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private CJKDIAAFKFC BPPCNFHJMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private MEEOFKIMDJG JABEDHNBEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	private float DKBOKGGCDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private float MDGOLDMIIHM;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4F824B0", Offset = "0x4F80CB0", VA = "0x184F824B0")]
	public static Task DOEMBAOJCCB(FJNKKCMAFBG FLLINPNBDAE, CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4F82390", Offset = "0x4F80B90", VA = "0x184F82390")]
	[AsyncStateMachine(typeof(EPDONMHBAPJ))]
	public Task DINOIOCBAJK(CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4F82220", Offset = "0x4F80A20", VA = "0x184F82220")]
	private static void COFJPMEMDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4F82680", Offset = "0x4F80E80", VA = "0x184F82680")]
	private void IIHAKMEELLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4F82800", Offset = "0x4F81000", VA = "0x184F82800")]
	private static float MJMBGEBOAPO(BDFGPLEIHNL JMODMMLPIOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4F82660", Offset = "0x4F80E60", VA = "0x184F82660")]
	private static float HEEJPCFFEPF()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct ILGBMLEMBKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct BPOEPNKFKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public MLELFDCFPHN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public OAOGIHICBJB.CGOICGENDIF mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private CDMMNLEEPDE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private FJNKKCMAFBG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EENOABIJFIN.GMELKLIGAOH <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x265B4C0", Offset = "0x2659CC0", VA = "0x18265B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct CCOBOOOMDOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private FEPDDONAFDI.NECJIHGFNOD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x265C1A0", Offset = "0x265A9A0", VA = "0x18265C1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x266CA00", Offset = "0x266B200", VA = "0x18266CA00")]
	[AsyncStateMachine(typeof(BPOEPNKFKGH))]
	public static Task DINOIOCBAJK(MLELFDCFPHN LAFDKHLHOAJ, CJKDIAAFKFC BPPCNFHJMAA, OAOGIHICBJB.CGOICGENDIF PHABLJMKIEE, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x266CB60", Offset = "0x266B360", VA = "0x18266CB60")]
	private static Task<LOEGOPFMLGJ> KJCKJOPDKFO(MLELFDCFPHN LAFDKHLHOAJ, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x266CBD0", Offset = "0x266B3D0", VA = "0x18266CBD0")]
	[AsyncStateMachine(typeof(CCOBOOOMDOI))]
	private static Task LIGOEPHGIAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct LGIHMJAABGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct JMKLAMAIENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public LGIHMJAABGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x27AEE90", Offset = "0x27AD690", VA = "0x1827AEE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class AAJEBLLLKBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public AAJEBLLLKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x27A7B30", Offset = "0x27A6330", VA = "0x1827A7B30")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GEDPLAKNAEA : IAsyncStateMachine
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
		public LGIHMJAABGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private PBDNLCGMMLB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x27AC0C0", Offset = "0x27AA8C0", VA = "0x1827AC0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private bool JHOLODOACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private MEEOFKIMDJG JABEDHNBEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private CancellationToken OFMMACGDFGM;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x27B3AD0", Offset = "0x27B22D0", VA = "0x1827B3AD0")]
	public static Task PBPBHNMOGAK(FJNKKCMAFBG FLLINPNBDAE, bool JHOLODOACNN, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken CMDDKEGDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x27B39D0", Offset = "0x27B21D0", VA = "0x1827B39D0")]
	[AsyncStateMachine(typeof(JMKLAMAIENP))]
	private Task DINOIOCBAJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x27B38A0", Offset = "0x27B20A0", VA = "0x1827B38A0")]
	[AsyncStateMachine(typeof(GEDPLAKNAEA))]
	private Task CHHACIPKPGD(bool GEKGOFDHOMP, string EKLDDEMFLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5757E0", Offset = "0x573FE0", VA = "0x1805757E0")]
	private bool MCDHDICFBFM(bool JHOLODOACNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct PAEJMNNIFDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct HBBCFDMANMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public PAEJMNNIFDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x4F7EEA0", Offset = "0x4F7D6A0", VA = "0x184F7EEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class FOJHABKHMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FOJHABKHMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x4F7E520", Offset = "0x4F7CD20", VA = "0x184F7E520")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct FAHCMDOOBDO : IAsyncStateMachine
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
		public PAEJMNNIFDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private PBDNLCGMMLB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x4F7E080", Offset = "0x4F7C880", VA = "0x184F7E080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private BCCEKCGBIPG IJHGGCIPPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private bool JHOLODOACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private MEEOFKIMDJG JABEDHNBEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x4F815A0", Offset = "0x4F7FDA0", VA = "0x184F815A0")]
	public static Task AGNIDMLCIGD(FJNKKCMAFBG FLLINPNBDAE, BCCEKCGBIPG CDLGLENGCKN, bool JHOLODOACNN, MEEOFKIMDJG JABEDHNBEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4F81720", Offset = "0x4F7FF20", VA = "0x184F81720")]
	[AsyncStateMachine(typeof(HBBCFDMANMG))]
	private Task DINOIOCBAJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4F81600", Offset = "0x4F7FE00", VA = "0x184F81600")]
	[AsyncStateMachine(typeof(FAHCMDOOBDO))]
	private Task CHHACIPKPGD(string EKLDDEMFLJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct GAGLEACPIII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct FLAILEANNNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public GAGLEACPIII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public PPEIDJHDBJL nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CJKDIAAFKFC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private MEEOFKIMDJG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<PPEIDJHDBJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2660320", Offset = "0x265EB20", VA = "0x182660320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2660870", Offset = "0x265F070", VA = "0x182660870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct GCFDMCMKLJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder<PPEIDJHDBJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GAGLEACPIII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public PPEIDJHDBJL state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2661730", Offset = "0x265FF30", VA = "0x182661730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2661950", Offset = "0x2660150", VA = "0x182661950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private readonly MLELFDCFPHN LAFDKHLHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private readonly BNNJOEEFPFO POOLKBEICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private readonly BMLEJEFEGAH LCDNHHLGBFC;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CDMMNLEEPDE KANHHANHNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x84FE10", Offset = "0x84E610", VA = "0x18084FE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x26616D0", Offset = "0x265FED0", VA = "0x1826616D0")]
	public GAGLEACPIII(MLELFDCFPHN LAFDKHLHOAJ, BNNJOEEFPFO POOLKBEICGE, BMLEJEFEGAH LCDNHHLGBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2661560", Offset = "0x265FD60", VA = "0x182661560")]
	[AsyncStateMachine(typeof(FLAILEANNNM))]
	public Task<PPEIDJHDBJL> PJEBBBOKAJI(PPEIDJHDBJL KNLPBDPOMLG, CJKDIAAFKFC DGMFPGGMIFB, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM, bool EDFLDFIKBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2661410", Offset = "0x265FC10", VA = "0x182661410")]
	[AsyncStateMachine(typeof(GCFDMCMKLJJ))]
	private Task<PPEIDJHDBJL> ONIHEFNFLEE(MEEOFKIMDJG LDCFAICNFND, PPEIDJHDBJL KIKBBCLABKM, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x26613C0", Offset = "0x265FBC0", VA = "0x1826613C0")]
	private bool EAAEENFLOPL(PPEIDJHDBJL KMBIEPELEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x26613F0", Offset = "0x265FBF0", VA = "0x1826613F0")]
	private void JLNHLIMCGLP(string NMDACIGKAOB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct CJEDBBNLINK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct GNHIDNCPFOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public CDMMNLEEPDE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public PPMHGNMDONN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private List<(PersistenceView, BFCODEDDDPM)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private (PersistenceView, BFCODEDDDPM) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x26EAE40", Offset = "0x26E9640", VA = "0x1826EAE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x26E1BF0", Offset = "0x26E03F0", VA = "0x1826E1BF0")]
	[AsyncStateMachine(typeof(GNHIDNCPFOC))]
	public static Task DINOIOCBAJK(CDMMNLEEPDE DMEDCBKJHHF, CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct KKIEBCPEBOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct LNHIJKIIKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CDMMNLEEPDE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public PPMHGNMDONN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private CEFBCOJIEHB <version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private List<(PersistenceView, BFCODEDDDPM)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private BFCODEDDDPM <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x27B5870", Offset = "0x27B4070", VA = "0x1827B5870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x27B0900", Offset = "0x27AF100", VA = "0x1827B0900")]
	[AsyncStateMachine(typeof(LNHIJKIIKLK))]
	public static Task DINOIOCBAJK(CDMMNLEEPDE DMEDCBKJHHF, CJKDIAAFKFC BPPCNFHJMAA, PPMHGNMDONN IPILLDOMDIE, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal struct EENOABIJFIN
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public struct GMELKLIGAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public List<EHHLGCFOCAG> BLEMCNBJPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public List<BFCODEDDDPM> OOPMLFFJABO;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5710A0", Offset = "0x56F8A0", VA = "0x1805710A0")]
		public GMELKLIGAOH(List<EHHLGCFOCAG> BLEMCNBJPAK, List<BFCODEDDDPM> OOPMLFFJABO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class ABEONJGABFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public List<EHHLGCFOCAG> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ABEONJGABFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x26DB1C0", Offset = "0x26D99C0", VA = "0x1826DB1C0")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private FJNKKCMAFBG FLLINPNBDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private CJKDIAAFKFC BPPCNFHJMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private OAOGIHICBJB.CGOICGENDIF PHABLJMKIEE;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private BDFGPLEIHNL PFKPFEBHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x26E6A50", Offset = "0x26E5250", VA = "0x1826E6A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x26E6AA0", Offset = "0x26E52A0", VA = "0x1826E6AA0")]
	public static GMELKLIGAOH DINOIOCBAJK(FJNKKCMAFBG FLLINPNBDAE, CJKDIAAFKFC BPPCNFHJMAA, OAOGIHICBJB.CGOICGENDIF PHABLJMKIEE)
	{
		return default(GMELKLIGAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x26E6B30", Offset = "0x26E5330", VA = "0x1826E6B30")]
	private GMELKLIGAOH DINOIOCBAJK()
	{
		return default(GMELKLIGAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x26E65A0", Offset = "0x26E4DA0", VA = "0x1826E65A0")]
	private GMELKLIGAOH CNHHGADLJEP(EBEEBEHBHPB DMLBGCKPNNG, CEFBCOJIEHB FHHEDFNBHJO, Dictionary<int, int> AODDIJFJLFG)
	{
		return default(GMELKLIGAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x26E6D70", Offset = "0x26E5570", VA = "0x1826E6D70")]
	private GameObject[] KDJOHPEJOKH(List<EHHLGCFOCAG> BLEMCNBJPAK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal struct HHMLMLLDLCI
{
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class KAGEMPBMKJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public EENOABIJFIN.GMELKLIGAOH instantiations;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KAGEMPBMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x2671790", Offset = "0x266FF90", VA = "0x182671790")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class KKINFCIEEPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KKINFCIEEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2671DF0", Offset = "0x26705F0", VA = "0x182671DF0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x266A140", Offset = "0x2668940", VA = "0x18266A140")]
	public static void DINOIOCBAJK(CDMMNLEEPDE DMEDCBKJHHF, CJKDIAAFKFC BPPCNFHJMAA, EENOABIJFIN.GMELKLIGAOH OEBDBGCELBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class BMLEJEFEGAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct AKODBGEKDLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public PPEIDJHDBJL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CJKDIAAFKFC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x26DCFA0", Offset = "0x26DB7A0", VA = "0x1826DCFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class GAKGIOFBJNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GAKGIOFBJNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class GJPCECCMDGI
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
			public GJPCECCMDGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x26F0FE0", Offset = "0x26EF7E0", VA = "0x1826F0FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public MEEOFKIMDJG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public GAKGIOFBJNH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GJPCECCMDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x26EA7E0", Offset = "0x26E8FE0", VA = "0x1826EA7E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct GBEDBCFBHJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private GJPCECCMDGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x26EA0B0", Offset = "0x26E88B0", VA = "0x1826EA0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct PNEGACDNEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private Dictionary<Guid, List<IHFNBAMFLDO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x26F0320", Offset = "0x26EEB20", VA = "0x1826F0320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct MJAJLABHEPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public MEEOFKIMDJG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private MEEOFKIMDJG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private Dictionary<Guid, List<IHFNBAMFLDO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x26EDFB0", Offset = "0x26EC7B0", VA = "0x1826EDFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class MMLODJHCFED
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
			public IHFNBAMFLDO handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public MMLODJHCFED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x26F0E90", Offset = "0x26EF690", VA = "0x1826F0E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public EMKMDIKBOEC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public List<IHFNBAMFLDO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public MMLODJHCFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x26EE960", Offset = "0x26ED160", VA = "0x1826EE960")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x26EEAE0", Offset = "0x26ED2E0", VA = "0x1826EEAE0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(IHFNBAMFLDO handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x26EEA20", Offset = "0x26ED220", VA = "0x1826EEA20")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct AFDBPGALCHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public EMKMDIKBOEC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public List<IHFNBAMFLDO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private MMLODJHCFED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x26DBAA0", Offset = "0x26DA2A0", VA = "0x1826DBAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct MMEILOGGPKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public MEEOFKIMDJG timer;

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
		[Cpp2IlInjected.Address(RVA = "0x26EE400", Offset = "0x26ECC00", VA = "0x1826EE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class PNIMCBACAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PNIMCBACAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x26F0AF0", Offset = "0x26EF2F0", VA = "0x1826F0AF0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct FDPCAOHCFHA : IAsyncStateMachine
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
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public CJKDIAAFKFC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x26E8850", Offset = "0x26E7050", VA = "0x1826E8850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class CNJJBLHGOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public CNJJBLHGOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x26E4940", Offset = "0x26E3140", VA = "0x1826E4940")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct KCHJAFGGEID : IAsyncStateMachine
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
		public BMLEJEFEGAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x26EBFF0", Offset = "0x26EA7F0", VA = "0x1826EBFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class GOLNGKBDDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GOLNGKBDDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x26EB310", Offset = "0x26E9B10", VA = "0x1826EB310")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private readonly MLELFDCFPHN LAFDKHLHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private ABDMMFPOEIB LCDNHHLGBFC;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private CDMMNLEEPDE KANHHANHNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x781980", Offset = "0x780180", VA = "0x180781980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x668D60", Offset = "0x667560", VA = "0x180668D60")]
	public BMLEJEFEGAH(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x26DF740", Offset = "0x26DDF40", VA = "0x1826DF740")]
	[AsyncStateMachine(typeof(AKODBGEKDLL))]
	public Task DINOIOCBAJK(PPEIDJHDBJL EOJKBNHIBFL, CJKDIAAFKFC DGMFPGGMIFB, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x26DFEB0", Offset = "0x26DE6B0", VA = "0x1826DFEB0")]
	[AsyncStateMachine(typeof(GBEDBCFBHJE))]
	private Task LHDBMDOHGNN(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x26E0000", Offset = "0x26DE800", VA = "0x1826E0000")]
	[AsyncStateMachine(typeof(PNEGACDNEEG))]
	private Task LLGOMIPIHIN(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x26DFD70", Offset = "0x26DE570", VA = "0x1826DFD70")]
	[AsyncStateMachine(typeof(MJAJLABHEPA))]
	private Task LBDEDKCCLKP(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x26DF600", Offset = "0x26DDE00", VA = "0x1826DF600")]
	[AsyncStateMachine(typeof(AFDBPGALCHA))]
	private Task CDHKNKBOMAO(Guid LCPCKEMKCNF, List<IHFNBAMFLDO> DGAGACKJLKN, EMKMDIKBOEC MPCKBGACGCA, CJKDIAAFKFC BPPCNFHJMAA, CancellationToken FIGDHHNIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x26DFB00", Offset = "0x26DE300", VA = "0x1826DFB00")]
	[AsyncStateMachine(typeof(MMEILOGGPKA))]
	private Task EJIDEJHOFFK(CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x26DFC40", Offset = "0x26DE440", VA = "0x1826DFC40")]
	[AsyncStateMachine(typeof(FDPCAOHCFHA))]
	private Task IJKABJHIJGN(Guid HIGAJBLNIHD, CJKDIAAFKFC BPPCNFHJMAA, MEEOFKIMDJG JABEDHNBEFJ, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x26DF4B0", Offset = "0x26DDCB0", VA = "0x1826DF4B0")]
	[AsyncStateMachine(typeof(KCHJAFGGEID))]
	private Task BEIBKEEOFKM(Guid HIGAJBLNIHD, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x26E0140", Offset = "0x26DE940", VA = "0x1826E0140")]
	private void PLNLKKNLPIL(Guid HIGAJBLNIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x26DF8A0", Offset = "0x26DE0A0", VA = "0x1826DF8A0")]
	private void DJNGEHDCKMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x26DF990", Offset = "0x26DE190", VA = "0x1826DF990")]
	[CompilerGenerated]
	private object EHKHBMKMGNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public struct CLBOCFKIALB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public EBEEBEHBHPB GOHBAOONCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public List<string> EJCIEIBNIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<long, int> CEPCGONFBNA;
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal class GJICMEJNIHJ : IBIMOBPDEIM
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class DIAENCDNPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public GPHANIMPAPP autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public DIAENCDNPNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class GPDEJOMIPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public DIAENCDNPNO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GPDEJOMIPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x26658B0", Offset = "0x26640B0", VA = "0x1826658B0")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class JJJEIHBDOMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public DIAENCDNPNO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public JJJEIHBDOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x266F4C0", Offset = "0x266DCC0", VA = "0x18266F4C0")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class HMINHJCDFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public GPHANIMPAPP autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HMINHJCDFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x266A9D0", Offset = "0x26691D0", VA = "0x18266A9D0")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class FELGDDCEKLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FELGDDCEKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x265E6E0", Offset = "0x265CEE0", VA = "0x18265E6E0")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class NLHGCHEJFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public FileSystemInfo file;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NLHGCHEJFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x26739B0", Offset = "0x26721B0", VA = "0x1826739B0")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class OEEFNGKJMCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public OEEFNGKJMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2673A20", Offset = "0x2672220", VA = "0x182673A20")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private const string CAOEFPAKEKL = "V2";

	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private const int BELFFJODHGD = 5;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private const string BNALHIFAFJB = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private const string EIFAKHCAJAJ = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private const int AFKFNAGMLFO = 32;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2665460", Offset = "0x2663C60", VA = "0x182665460")]
	public GJICMEJNIHJ(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2664960", Offset = "0x2663160", VA = "0x182664960")]
	public bool LPPGIPACGNO(long JKNBPJJDKBB, CLBOCFKIALB FKGIOADIPBH, GPHANIMPAPP FLBPMDDEMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2663E00", Offset = "0x2662600", VA = "0x182663E00")]
	public static bool FANFAOHKKAP(long JKNBPJJDKBB, GPHANIMPAPP FLBPMDDEMNL, out FileInfo OCHAGNKBNHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2663EC0", Offset = "0x26626C0", VA = "0x182663EC0")]
	public bool JDHDCIDEOGL(long JKNBPJJDKBB, GPHANIMPAPP FLBPMDDEMNL, out CLBOCFKIALB FKGIOADIPBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2664F80", Offset = "0x2663780", VA = "0x182664F80")]
	private bool OFKLPGOBHCO(FileInfo OCHAGNKBNHH, out byte[] JMIHNNDJMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2663930", Offset = "0x2662130", VA = "0x182663930")]
	private static FileInfo BKPBCBILCMN(long JKNBPJJDKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x26643A0", Offset = "0x2662BA0", VA = "0x1826643A0")]
	private static FileInfo KLDLOHKBCCJ(long JKNBPJJDKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2664330", Offset = "0x2662B30", VA = "0x182664330")]
	private static DirectoryInfo KFMBIAFBJNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2663A80", Offset = "0x2662280", VA = "0x182663A80")]
	private void EMPOJJCPOIP(FileInfo JFAFOKMNBAC, EBEEBEHBHPB IEJDKFIDFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2664470", Offset = "0x2662C70", VA = "0x182664470")]
	private void KOGMDGBEBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2664DD0", Offset = "0x26635D0", VA = "0x182664DD0")]
	public static void NCPCLOMOOFE(long JKNBPJJDKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2663A10", Offset = "0x2662210", VA = "0x182663A10")]
	public static bool DKLIAELONPD(long JKNBPJJDKBB, out DateTime EOOINLMJCPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal class CKAMCIJJEGK : IBIMOBPDEIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct GLOAEMPONKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder<CLBOCFKIALB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CKAMCIJJEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public HGMCMEJEPLL serializeType;

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
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x26EA8F0", Offset = "0x26E90F0", VA = "0x1826EA8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x26EADF0", Offset = "0x26E95F0", VA = "0x1826EADF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class NFENHKDDMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public HGMCMEJEPLL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NFENHKDDMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x26EEE90", Offset = "0x26ED690", VA = "0x1826EEE90")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class KNDOCBFNBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public NFENHKDDMBB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KNDOCBFNBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x26ECED0", Offset = "0x26EB6D0", VA = "0x1826ECED0")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class PGNHPMADGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public NFENHKDDMBB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PGNHPMADGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x26EFD30", Offset = "0x26EE530", VA = "0x1826EFD30")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct DEFPKLODAMC : IAsyncStateMachine
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
		public HGMCMEJEPLL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CKAMCIJJEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private KNDOCBFNBLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private FEPDDONAFDI.MCGAGIONOLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x26E5150", Offset = "0x26E3950", VA = "0x1826E5150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private readonly ABFKLCKDGIN CMDCMNAPIBG;

	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private static readonly TimeSpan MDCFBKJAPAL;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x26E3DE0", Offset = "0x26E25E0", VA = "0x1826E3DE0")]
	public CKAMCIJJEGK(MLELFDCFPHN LAFDKHLHOAJ, [Optional] ABFKLCKDGIN? CMDCMNAPIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x26E3130", Offset = "0x26E1930", VA = "0x1826E3130")]
	[AsyncStateMachine(typeof(GLOAEMPONKD))]
	public Task<CLBOCFKIALB> IICNIKFAIFP(long JKNBPJJDKBB, HGMCMEJEPLL LFCNHGMNLIO, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26E2FE0", Offset = "0x26E17E0", VA = "0x1826E2FE0")]
	[AsyncStateMachine(typeof(DEFPKLODAMC))]
	private Task EJCLAAMIEHB(HGMCMEJEPLL LFCNHGMNLIO, IEnumerable<PersistenceView> HGMAHGAHKDO, StringBuilder PEGCIJPBKJK, CancellationToken OFMMACGDFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26E3470", Offset = "0x26E1C70", VA = "0x1826E3470")]
	private CLBOCFKIALB KIDBCMMDFPD(long JKNBPJJDKBB, HGMCMEJEPLL LFCNHGMNLIO, IEnumerable<PersistenceView> HGMAHGAHKDO, StringBuilder PEGCIJPBKJK)
	{
		return default(CLBOCFKIALB);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26E2EA0", Offset = "0x26E16A0", VA = "0x1826E2EA0")]
	private EBEEBEHBHPB CEDKEFBIGGI(long JKNBPJJDKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x26E3270", Offset = "0x26E1A70", VA = "0x1826E3270")]
	private void KEBNBEJIMEA(EBEEBEHBHPB NEIFCDILOOO, StringBuilder PEGCIJPBKJK, IEnumerable<PersistenceView> HGMAHGAHKDO, in LJNMLAJBMIP PNALBHAKAAD, ref MDLIBHGEJHP DCNCDDDMLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26E38E0", Offset = "0x26E20E0", VA = "0x1826E38E0")]
	private void PAMIJDJAFCL(EBEEBEHBHPB NEIFCDILOOO, StringBuilder PEGCIJPBKJK, PersistenceView IOBPGNIOIGA, ref MDLIBHGEJHP DCNCDDDMLLI, in LJNMLAJBMIP PNALBHAKAAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class JHDCAFGGIKL : IBIMOBPDEIM
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class GILGMHBBGEE
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GILGMHBBGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x26635F0", Offset = "0x2661DF0", VA = "0x1826635F0")]
		internal object <UploadRoomDataBlob>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2663670", Offset = "0x2661E70", VA = "0x182663670")]
		internal object <UploadRoomDataBlob>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x26636B0", Offset = "0x2661EB0", VA = "0x1826636B0")]
		internal object <UploadRoomDataBlob>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2663720", Offset = "0x2661F20", VA = "0x182663720")]
		internal object <UploadRoomDataBlob>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct EBANBMEFMMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<GCOPJEEKJNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CLBOCFKIALB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public JHDCAFGGIKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private GILGMHBBGEE <>8__1;

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
		private TaskAwaiter<GCOPJEEKJNO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x265D020", Offset = "0x265B820", VA = "0x18265D020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x265DB00", Offset = "0x265C300", VA = "0x18265DB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class DIHOOLPIOBP
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
			public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public DIHOOLPIOBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private LOEGOPFMLGJ <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private TaskAwaiter<GCOPJEEKJNO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			private TaskAwaiter<LOEGOPFMLGJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x26745E0", Offset = "0x2672DE0", VA = "0x1826745E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x2674C60", Offset = "0x2673460", VA = "0x182674C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public JHDCAFGGIKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public CLBOCFKIALB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public DIHOOLPIOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x265C5E0", Offset = "0x265ADE0", VA = "0x18265C5E0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<LOEGOPFMLGJ> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct GIDFBOCCBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public AsyncTaskMethodBuilder<LOEGOPFMLGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public JHDCAFGGIKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public CLBOCFKIALB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public MEEOFKIMDJG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private TaskAwaiter<LOEGOPFMLGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2662B90", Offset = "0x2661390", VA = "0x182662B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2662DC0", Offset = "0x26615C0", VA = "0x182662DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private const float HOLCKJPLFFF = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly JEIAGLKFBJG NJELGJOOLLF;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FJNKKCMAFBG NCKGJOIPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x266E3D0", Offset = "0x266CBD0", VA = "0x18266E3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x266E6C0", Offset = "0x266CEC0", VA = "0x18266E6C0")]
	public JHDCAFGGIKL(MLELFDCFPHN LAFDKHLHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x266E570", Offset = "0x266CD70", VA = "0x18266E570")]
	[AsyncStateMachine(typeof(EBANBMEFMMB))]
	public Task<GCOPJEEKJNO> GLCPJIFKFHL(int DPJCEOJFFFH, CLBOCFKIALB FKGIOADIPBH, long KAJFPAFLIDI, long ICKOGPENBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x266E400", Offset = "0x266CC00", VA = "0x18266E400")]
	[AsyncStateMachine(typeof(GIDFBOCCBGK))]
	public Task<LOEGOPFMLGJ> FOGOELCDCOL(int DPJCEOJFFFH, CLBOCFKIALB FKGIOADIPBH, long KAJFPAFLIDI, long ICKOGPENBMF, MEEOFKIMDJG LDCFAICNFND, CancellationToken OFMMACGDFGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
public class OAECIAKCDIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly Guid ANNDHKOFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly KLCJDPMOLOK FKPACCLDCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private NPDKPEMMJOC MDKOIJJHDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private int? KJAGGPGCIME;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Guid ABMDNDNLBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x60DD70", Offset = "0x60C570", VA = "0x18060DD70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x27BBCE0", Offset = "0x27BA4E0", VA = "0x1827BBCE0")]
	public OAECIAKCDIH(KLCJDPMOLOK FKPACCLDCDD, [Optional] Guid? ANNDHKOFOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x92ED40", Offset = "0x92D540", VA = "0x18092ED40")]
	public OAECIAKCDIH FPIGJLIKHAL(NPDKPEMMJOC MDKOIJJHDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x27BBC10", Offset = "0x27BA410", VA = "0x1827BBC10")]
	public LOEGOPFMLGJ MLDNCBMICGA(out Guid BOIGEPHAADD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x27BBB90", Offset = "0x27BA390", VA = "0x1827BBB90")]
	public OAECIAKCDIH JHOEBDCBIOM(EHBOOFFPCFP PGEPDGCFKON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
public static class COGDHDBPLLF
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x26E49A0", Offset = "0x26E31A0", VA = "0x1826E49A0")]
	public static JGADFMOHFPD HMHBFENGAMF(this LDICDFOPAHO LDNCIEBMBCJ)
	{
		return default(JGADFMOHFPD);
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
			public COCNJNDKFHM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public COCNJNDKFHM HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private static COCNJNDKFHM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private Dictionary<COCNJNDKFHM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x4F83730", Offset = "0x4F81F30", VA = "0x184F83730")]
		public bool GIHEEJOFHGH(COCNJNDKFHM CANICIBDBNB, out ResultConfig JAAANOFOFDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x4F83DF0", Offset = "0x4F825F0", VA = "0x184F83DF0")]
		public ResultConfig PFCOKBIBNJG(COCNJNDKFHM MGFFDECBOEF, [Optional] HashSet<COCNJNDKFHM> HKBCHHFPDGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x4F83C50", Offset = "0x4F82450", VA = "0x184F83C50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x4F837A0", Offset = "0x4F81FA0", VA = "0x184F837A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6213B0", Offset = "0x61FBB0", VA = "0x1806213B0")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x27AF2A0", Offset = "0x27ADAA0", VA = "0x1827AF2A0")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3A0", Offset = "0x27ADBA0", VA = "0x1827AF3A0")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
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
