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
public class KHFAGJAKEEO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2416140", Offset = "0x2415140", VA = "0x182416140")]
	public KHFAGJAKEEO(string LPDLECBMBMG, Exception CPKECAHHDHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface INOGGKBAIAF : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HJEFHMBMCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task POEBNIBPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHKLCDPOAAD(Task DOGDKDCOCKJ, string JDPHCNNGGBF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface JIGAFPHNEIC : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EHPFIBKEFJP> EIECLOCJPLE(AJIPHKLOIPJ GAPFHPGFEME);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HBBFBJGFOAF(CancellationToken JNDOKGNDNMO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface EMHLBNCJIKK : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OHNBBLGLCIB PKIIFFJAGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMDKAKBCADI();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNBIHIPGLFO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KLPKDCGKPJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface EHLJNBAFCMO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TimeSpan OAIPAAGJBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan EPMBNKCDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan GCCHIJEIJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan GFNIAHCCALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EIKFLJAHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CNCKCJOBOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HGCMMOAILAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ABNJLDDNNDE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KBAEFPENIMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long LNGEKBICNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long MICLPPPFMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly ABNJLDDNNDE GLKKDGLKBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception KJMNOKPJCFD;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2415A30", Offset = "0x2414A30", VA = "0x182415A30")]
	public KBAEFPENIMP(long LNGEKBICNNH, long MICLPPPFMCH, ABNJLDDNNDE GLKKDGLKBMK, [CanBeNull] Exception KJMNOKPJCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24159E0", Offset = "0x24149E0", VA = "0x1824159E0")]
	public static KBAEFPENIMP BFHBCOPOEIO(BKIGCFACDJG HODLHJHPHGF, ABNJLDDNNDE GLKKDGLKBMK, [Optional] Exception KJMNOKPJCFD)
	{
		return default(KBAEFPENIMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void LKKFLDDFDFK(KBAEFPENIMP AEBCAGCGMFB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface IOHBBLGCNFG : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DBFMEJHHDLP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LKKFLDDFDFK CJGLLNKHCIN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LKKFLDDFDFK DFLACIEDNAC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LKKFLDDFDFK CFJMACPOKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CLCALLMJBFE();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LGCFDODAAMG(KBAEFPENIMP AEBCAGCGMFB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKOMMJIHPJH(KBAEFPENIMP AEBCAGCGMFB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GLJIMGCBJDM(KBAEFPENIMP AEBCAGCGMFB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface CMLELKIMIHI : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JEMCOJBFKJK();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAMIEANIPEP();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLFNCPGCIAG();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate Task GFPDFBPNOCJ(LJDIAMGONCO AJPJOCFLBAF, CancellationToken KGJPBGICHFN);
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal interface DGOAPDDEOMG : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GNGCKBAEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGBCCGDBLON(GFPDFBPNOCJ FMOFBFAHMAG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface AOCHAFDEFCB : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	TaskStatus OEPJODBOIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KPDEDEPFHNM(BKIGCFACDJG DBIDPHNGCDH, CancellationToken GADEANLIDCE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class MJHAOMNDGED
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x241BDF0", Offset = "0x241ADF0", VA = "0x18241BDF0")]
	public static bool KBBCIHDEJCD(this AOCHAFDEFCB ILNPJGMEIDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface MLNEICIMMPF : IEDMJEJLENE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CancellationToken AOHIGMPBINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LKDGJLJGLMB OMPHCPJEGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GEOOHGPBHKK NBDKCEOHLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CPEBOHOONIO LAKKCLKBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HLAKFCIILIA AOGELCEANMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JPEAFFCOLAB OIHDMECEAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GACFPALNPCN JBKPEMIFPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MIGAHPHAEFH DAMLPKAKPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	INOGGKBAIAF KONODCFCHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JIGAFPHNEIC PCKGHABJHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IOHBBLGCNFG CIBOBHAHKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CMLELKIMIHI LGLLJGIJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AOCHAFDEFCB ODADLBJDMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DGOAPDDEOMG CBOKAPOMBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PPOJGGALBGL LFEDLKFBJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	LKPPCAFCADB HJFLFAFJAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KOAMBPJGMEC AHIFALIBMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	BCFHBFJIFGK ONODHABFLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	GKNIJLAECFE LPGBPJBAGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AJAOKOGIDKE BDJHKGEPALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	KMAJEKLECLK MCPHEPKMJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FIEGDDAFLBG EDEPKGCIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	EAMDLHMICCB OONFHMJEGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LCAFBKKPGDI GPMBELAAPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	NDNINLHOKEJ CGHIFDLIGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	EMHLBNCJIKK GBCGFKEGPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EHLJNBAFCMO BBNIFMFHGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LNJNHKIAJFM JBOIEJICGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface PPOJGGALBGL : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGLKFOFCGGC PPCBFHPPBHE(Guid AHPODJGLLEM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKCILJPFPEA(Guid AHPODJGLLEM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GCBAOMOJMNK(Guid AHPODJGLLEM, Task FAMNCEJLICN);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BMAMMEJCMOE(Guid AHPODJGLLEM, EHPFIBKEFJP OBEKMGPNDPO);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LLFNCPGCIAG(Guid AHPODJGLLEM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(EHPFIBKEFJP, Task)> AGPKODMGEEB(Guid AHPODJGLLEM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface LKPPCAFCADB : KLPKDCGKPJE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface KOAMBPJGMEC : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACFBKCJDIGA(ILPEFNEFIAF LPDLECBMBMG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDAPNDNPMON(ILPEFNEFIAF LPDLECBMBMG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NGDEDPLJJJF> OCKFLHBCECF(CancellationToken JKCIAKLPGNB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate EHPFIBKEFJP DPKJAEEPEFK(CFKJNANNAIG DNHDFJGPIFD, NGDEDPLJJJF OFOICKDPAGI);
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface BCFHBFJIFGK : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGLKFOFCGGC BPLGFFDEKPK(IIKMCKNMJKE BPDILINENLG);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPOHGMAOHMF(Guid AHPODJGLLEM, Task FAMNCEJLICN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface GKNIJLAECFE : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EHPFIBKEFJP> LPGBPJBAGNP(CFKJNANNAIG MOAPJIIBEJL, NGDEDPLJJJF EPEHCHIHIPG, [Optional] NCMHNNOIOOH MIPAELKCCCF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface AJAOKOGIDKE : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KPHIGKDHNKJ> IDGIJNBOMLL(MLACCLOKFHB HDALINEEMFB, BKIGCFACDJG DBIDPHNGCDH, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPHIGKDHNKJ HHLHEDDFCKL(BKIGCFACDJG DBIDPHNGCDH, NCMHNNOIOOH CHPLONOINCJ, long MPOPHDGDFPN);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KPHIGKDHNKJ IEAILLGLFIL(BKIGCFACDJG DBIDPHNGCDH, NCAFGBCAKDF ENPHFCNNPIF, long MPOPHDGDFPN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KPHIGKDHNKJ JOKDAIBGBKO(long LNGEKBICNNH, long MPOPHDGDFPN, string FJBIEPGMBAJ, string KIJAAMLEMEA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FIEGDDAFLBG : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHPFIBKEFJP LKDNPLHCBKP(CFKJNANNAIG DNHDFJGPIFD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JLBDAEMHBKA(string LLBPEMIKGCJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface KMAJEKLECLK : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ILPEFNEFIAF> DLLPPBMFJNF(ILPEFNEFIAF PDHKNAGOONJ, CHFLJCNHJAL JDCGDNIEJCK, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ILPEFNEFIAF> BMGJOCAOOMP(CancellationToken JNDOKGNDNMO, CHFLJCNHJAL JDCGDNIEJCK);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKKMCLEIKNA GNCDENOMENC(NHNDDFDJKOJ PCLCIJOCHGA, MLACCLOKFHB HDALINEEMFB);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JKKMCLEIKNA AIHLGANDGCL(NHNDDFDJKOJ PCLCIJOCHGA, MLACCLOKFHB HDALINEEMFB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface EAMDLHMICCB : KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHPFIBKEFJP PIALCICEDCF(CFKJNANNAIG DNHDFJGPIFD, NGDEDPLJJJF OFOICKDPAGI);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHPFIBKEFJP NGDNLNJLFOP(CFKJNANNAIG EDHLMAKDBJM);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHPFIBKEFJP FAEILFBONMK(CFKJNANNAIG EDHLMAKDBJM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LCAFBKKPGDI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEEOKDMOBLL(MBNKJBAMKPD KOIAIFBGMMH);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJHDLNKJMOC(MBNKJBAMKPD KOIAIFBGMMH);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEBABBCAKNF(MBNKJBAMKPD KOIAIFBGMMH);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFPFEGPJCNO(MBNKJBAMKPD KOIAIFBGMMH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MBNKJBAMKPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly BKIGCFACDJG EEEMIOEFFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> NFDKLLEJIHM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public global::JKOIANHLHOA<string> PFNEAGOOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
	public MBNKJBAMKPD(BKIGCFACDJG GHMHOEGJKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x241B030", Offset = "0x241A030", VA = "0x18241B030")]
	public MBNKJBAMKPD CHJECOJKMPD(string GGLJFLNJABJ, string JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x241AFB0", Offset = "0x2419FB0", VA = "0x18241AFB0")]
	public bool BCCAKAFGLGH(out IEnumerable<KeyValuePair<string, string>> DIPBJEGCMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x241B0F0", Offset = "0x241A0F0", VA = "0x18241B0F0")]
	public MBNKJBAMKPD OMLDPOBCBBH(global::JKOIANHLHOA<string> BCAFPIOPGIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LNJNHKIAJFM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HIKHGBNNBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string LBNOHKOGMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBGCDIFKPHN();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKGNOMGKEBM(long LNDOIEFBHBK, out EDLFNNMNIKE MCCIMHFBBHA);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HLMLINCGMPP(long LNDOIEFBHBK, out global::PAHPPLAGAKI<CONELIFOGEN> MCCIMHFBBHA);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GAJFDFNFFCK(long LNDOIEFBHBK, out global::PAHPPLAGAKI<CONELIFOGEN> MCCIMHFBBHA);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MPDIHNKALBD(long LNDOIEFBHBK, out string KIJAAMLEMEA, out string FJBIEPGMBAJ, out CONELIFOGEN INLCCMKNPIP, out CONELIFOGEN DHIBJLJHCLK);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ADEAEPEKLOE(KPHIGKDHNKJ PDHKNAGOONJ, long LNDOIEFBHBK);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<bool> EILCBCMLJJJ(long LNDOIEFBHBK, byte[] INLCCMKNPIP, byte[] DHIBJLJHCLK, CancellationToken JNDOKGNDNMO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IEDMJEJLENE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool KBBCIHDEJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool KNNNDLPNMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action DBFMEJHHDLP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LKKFLDDFDFK CJGLLNKHCIN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LKKFLDDFDFK DFLACIEDNAC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LKKFLDDFDFK CFJMACPOKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAMIEANIPEP();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<EHPFIBKEFJP> HFLPFAKADNO([Optional][CanBeNull] NCMHNNOIOOH EHOBLCBOHIH);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<EHPFIBKEFJP> GJDLHCCJJBN(CFKJNANNAIG JDPNHHFBFBF);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<EHPFIBKEFJP> IMPACHOIJPN(int EGJOEKGOPPK);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task JLBDAEMHBKA(string LLBPEMIKGCJ);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<EHPFIBKEFJP> EIECLOCJPLE(AJIPHKLOIPJ GAPFHPGFEME = AJIPHKLOIPJ.Incremental);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HBBFBJGFOAF(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AINLPINDCBP(long MPOPHDGDFPN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MJNFOKLPAIP(long MPOPHDGDFPN, out DateTime MFBPGCMPPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HLAKFCIILIA
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string CCLMLJDKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECCKIEKIEPA(Scene PGPLHCJPLKJ);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BDFJHJABNNG(ABIOOPODBAJ DEMAIDGCHAF, CancellationToken JNDOKGNDNMO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DDHLPGJACDN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int DFACMFJBKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool GCFMNNBEABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool AGPDOOIFOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool CLFKLCFEKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool IJDEPNGLPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KBGDFKAGKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CFKJNANNAIG EFBEJOEACEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAIAHAKKKBA(LKDGJLJGLMB KIKNDHMFIHG);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task MMOPBKMKKLL(MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IFMGGLHGKOK(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task GMEDFBBHCFC(PFNKBMDEMBM JICBGDLCEAH, [Optional] CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MCEOJCPFIMN(float IJLDALNLODE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JNEJACIFNIK(string BEKLAGAICMG);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<PMMHGJOPMBK> JEBJFPOGJFJ();

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IDisposable JAIFDFBJGCD(object GENOAILOCON, PMMHGJOPMBK PMMNCIJKIJF);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DODIDIBCHDG();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	APBKLCEDLJC LGPKDJNLKKN();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MMDOODCBNEF(int BDCEIEFPGMB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task OKEOKIGGPAM();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PBCJBLGAEND();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool KPOBNKKDMOL();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IKCFJKBJCMK(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task MHDFBAEIFLG(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> AOJGJPDPKGN(DateTime BLDHLHALAHJ, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> MHCGOFOCEMO(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CCBOPOFGJKF();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	PNKKMJOJLKJ GHBDDOLOFGI(EOLDEMFEKPN AAPMOLKDNJL, FDBKGNMGHFG PKEIFHKLKCE, IEnumerable<PersistenceView> KHOGBAOKODB, ref NLGONFANMHG JNOFNGIHIBH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NGHPEGJPNKG(FIBICDDGGPE EFEJHDCOLHM, in PNKKMJOJLKJ ONBOLLJEEDG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HHFMHJOMCMN(FDBKGNMGHFG CAFKBNEPNOP, bool IJJOICLCJJH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FFBCKHBAGJE();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MHIOMDDMLDM(long PBLGEAPLLBL, long MICLPPPFMCH, NCMHNNOIOOH AHLHJEPOCEB, LPBFELBNLDJ LPMPLMCCCLK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HGFKCODDOHJ(long PBLGEAPLLBL, long MICLPPPFMCH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ODPOCLHGFAC(PersistenceView FEJBBPKABEH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool OEEHJKMFGHM(PersistenceView NHKKBKKOJJM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MPDMDODOKKH(FIBICDDGGPE EFEJHDCOLHM, MAJIONMLDGH OOLFNNIOIOK, Dictionary<int, int> POKLONJGAGG, out CEGOGGDAACF DIOKPGBFHKK);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ALALOENLBNJ();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void ADDBNJMDNNI();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable PBOMPOIOIEO();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Dictionary<int, int> PDBGIACENDD(FDBKGNMGHFG CAFKBNEPNOP, MAJIONMLDGH OOLFNNIOIOK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> ILMNEBAHABM(GEOOHGPBHKK LGPIIFOCLPE, CancellationToken JNDOKGNDNMO, MLACCLOKFHB HDALINEEMFB);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void AAOALHBEPNF(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<NCMHNNOIOOH> FMHEMDFKKHK(long PBLGEAPLLBL, long MICLPPPFMCH, string FJBIEPGMBAJ, string HJPKJNKFABP, string EHLOBGHNHPJ, Dictionary<long, int> IJMGHOHHOOK, int HAGCHBJIOKN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<NCAFGBCAKDF> FBCEMOLKFKK(string KIJAAMLEMEA, long PBLGEAPLLBL, long MICLPPPFMCH, string FJBIEPGMBAJ, DBLFDALAINL.HELOPCPOCBM HJPKJNKFABP, DBLFDALAINL.HELOPCPOCBM EHLOBGHNHPJ, int HAGCHBJIOKN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NCMHNNOIOOH> LEGOGJNGMKL(long PBLGEAPLLBL, bool ILIKBMECDFD, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool APDJHPPHDJG();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool NIJPKLEIFHA();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GameObject[] OCPNBGLFBBB(KDKNOMHFGMB[] FBIDPDDMHIH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JJEOEMLMKGE(List<GameObject> PMJCEDLIECO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float KAHFHBMEFJE();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> GFEOFBGDFBJ(string IGMKHADPKBG, LoadSceneMode PAAGGOKHIEK, bool BOKKDBPPLDH, MLACCLOKFHB BCAFPIOPGIA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void FBJOONENODN(BKIGCFACDJG DMBEHEBAJNC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void HBJJDJINGAG(string EPEHCHIHIPG, CFKJNANNAIG MOAPJIIBEJL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task ECHIAEPABFC(MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task EOECHKLDFNH(MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LAGFICLFNLJ();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "56")]
	IDisposable NKDCKCHGOAD();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "57")]
	CMIDHIHPFMF KPEOJLOJLOC();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CMIDHIHPFMF
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DCOMDOOBHEP(CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HADDCJALEMC(CancellationToken JNDOKGNDNMO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PNKKMJOJLKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> ONFHFOFFALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public IDisposable BDCOAHADJJH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x48740D0", Offset = "0x48730D0", VA = "0x1848740D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DMHCGJJHBOG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BKIGCFACDJG NHKMNNBGABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NCMHNNOIOOH ONKMHDBFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PGBMNMFNBLN NLBICLCEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BDMJPAHGBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool ABOAJINGBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int DFACMFJBKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action CDBHIOADEIA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<int> AMFBDCAJGCD;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMPBJFNHODI();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.AEMJKEDODEH> JNBJEHDFNCF();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OLGMFDAMJKK();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BKIGCFACDJG IDFJIADFBNF();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CBAFHLIDCCO ADFAJFDPOKK();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MKOHCKIPBEO(long LNDOIEFBHBK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NDNINLHOKEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMCHJGEIGPN(out IEnumerable<int> LEENANHGPOK);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLJHNBMOFBG(JNGMFIANMOG KGJPBGICHFN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIAPONLBCDH(JNGMFIANMOG KGJPBGICHFN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NGIJJGIEKNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AFPGJBPPHBM(EHPFIBKEFJP EOPMMJHAAKK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class APAFJKFKJIA : IEDMJEJLENE, IDisposable, MLNEICIMMPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IFBCEDGNDDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<EHPFIBKEFJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public APAFJKFKJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AJIPHKLOIPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<EHPFIBKEFJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x25D5400", Offset = "0x25D4400", VA = "0x1825D5400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x25D5640", Offset = "0x25D4640", VA = "0x1825D5640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LNHOGLBCIJB : IEnumerable<KLPKDCGKPJE>, IEnumerable, IEnumerator<KLPKDCGKPJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private KLPKDCGKPJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public APAFJKFKJIA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private KLPKDCGKPJE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public LNHOGLBCIJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x25DA510", Offset = "0x25D9510", VA = "0x1825DA510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x25DA950", Offset = "0x25D9950", VA = "0x1825DA950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x25DA8B0", Offset = "0x25D98B0", VA = "0x1825DA8B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KLPKDCGKPJE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x25DA8B0", Offset = "0x25D98B0", VA = "0x1825DA8B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationTokenSource LOJALCDGFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LKDGJLJGLMB KIKNDHMFIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JGPHLDNKFFJ FHLAEHPPIEN;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GEOOHGPBHKK NBDKCEOHLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x638130", Offset = "0x637130", VA = "0x180638130", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6729F0", Offset = "0x6719F0", VA = "0x1806729F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CPEBOHOONIO LAKKCLKBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x609720", Offset = "0x608720", VA = "0x180609720", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x672920", Offset = "0x671920", VA = "0x180672920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F7220", Offset = "0x5F6220", VA = "0x1805F7220", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x67F370", Offset = "0x67E370", VA = "0x18067F370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public HLAKFCIILIA AOGELCEANMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5EB630", Offset = "0x5EA630", VA = "0x1805EB630", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EE0", Offset = "0x5F7EE0", VA = "0x1805F8EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JPEAFFCOLAB OIHDMECEAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EB620", Offset = "0x5EA620", VA = "0x1805EB620", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x672B80", Offset = "0x671B80", VA = "0x180672B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GACFPALNPCN JBKPEMIFPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x609660", Offset = "0x608660", VA = "0x180609660", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5EB640", Offset = "0x5EA640", VA = "0x1805EB640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MIGAHPHAEFH DAMLPKAKPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x609670", Offset = "0x608670", VA = "0x180609670", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F7250", Offset = "0x5F6250", VA = "0x1805F7250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public INOGGKBAIAF KONODCFCHBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EA0", Offset = "0x5F7EA0", VA = "0x1805F8EA0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F7230", Offset = "0x5F6230", VA = "0x1805F7230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public JIGAFPHNEIC PCKGHABJHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61F080", Offset = "0x61E080", VA = "0x18061F080", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6807E0", Offset = "0x67F7E0", VA = "0x1806807E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IOHBBLGCNFG CIBOBHAHKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x638140", Offset = "0x637140", VA = "0x180638140", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BF0", Offset = "0x7C4BF0", VA = "0x1807C5BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public CMLELKIMIHI LGLLJGIJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x66EC40", Offset = "0x66DC40", VA = "0x18066EC40", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x67FE10", Offset = "0x67EE10", VA = "0x18067FE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public AOCHAFDEFCB ODADLBJDMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6096E0", Offset = "0x6086E0", VA = "0x1806096E0", Slot = "37")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5F7240", Offset = "0x5F6240", VA = "0x1805F7240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DGOAPDDEOMG CBOKAPOMBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6096F0", Offset = "0x6086F0", VA = "0x1806096F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6FA080", Offset = "0x6F9080", VA = "0x1806FA080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public PPOJGGALBGL LFEDLKFBJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61F190", Offset = "0x61E190", VA = "0x18061F190", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x672B60", Offset = "0x671B60", VA = "0x180672B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public LKPPCAFCADB HJFLFAFJAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x609700", Offset = "0x608700", VA = "0x180609700", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F7260", Offset = "0x5F6260", VA = "0x1805F7260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public KOAMBPJGMEC AHIFALIBMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x66E8F0", Offset = "0x66D8F0", VA = "0x18066E8F0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x670C50", Offset = "0x66FC50", VA = "0x180670C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public BCFHBFJIFGK ONODHABFLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6711C0", Offset = "0x6701C0", VA = "0x1806711C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public GKNIJLAECFE LPGBPJBAGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x670AB0", Offset = "0x66FAB0", VA = "0x180670AB0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x672980", Offset = "0x671980", VA = "0x180672980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public AJAOKOGIDKE BDJHKGEPALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x670B50", Offset = "0x66FB50", VA = "0x180670B50", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x670C70", Offset = "0x66FC70", VA = "0x180670C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public KMAJEKLECLK MCPHEPKMJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6360B0", Offset = "0x6350B0", VA = "0x1806360B0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A50", Offset = "0x7C7A50", VA = "0x1807C8A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public FIEGDDAFLBG EDEPKGCIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6718B0", Offset = "0x6708B0", VA = "0x1806718B0", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x671B50", Offset = "0x670B50", VA = "0x180671B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public EAMDLHMICCB OONFHMJEGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x671890", Offset = "0x670890", VA = "0x180671890", Slot = "47")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x671B30", Offset = "0x670B30", VA = "0x180671B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LCAFBKKPGDI GPMBELAAPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6718A0", Offset = "0x6708A0", VA = "0x1806718A0", Slot = "48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x671B40", Offset = "0x670B40", VA = "0x180671B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public NDNINLHOKEJ CGHIFDLIGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98D790", Offset = "0x98C790", VA = "0x18098D790", Slot = "49")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xEF04C0", Offset = "0xEEF4C0", VA = "0x180EF04C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EMHLBNCJIKK GBCGFKEGPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x66E9B0", Offset = "0x66D9B0", VA = "0x18066E9B0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x671C90", Offset = "0x670C90", VA = "0x180671C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EHLJNBAFCMO BBNIFMFHGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61F4D0", Offset = "0x61E4D0", VA = "0x18061F4D0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x670C80", Offset = "0x66FC80", VA = "0x180670C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public LNJNHKIAJFM JBOIEJICGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x732EF0", Offset = "0x731EF0", VA = "0x180732EF0", Slot = "52")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7325E0", Offset = "0x7315E0", VA = "0x1807325E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private bool DPHBJGGABGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x25C5B90", Offset = "0x25C4B90", VA = "0x1825C5B90", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool MJCDOPLDNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x25C6530", Offset = "0x25C5530", VA = "0x1825C6530", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private CancellationToken BJOEBNGJDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x25C6500", Offset = "0x25C5500", VA = "0x1825C6500", Slot = "24")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private LKDGJLJGLMB DFFJFHALMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event Action DKLDIAOIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x25C64A0", Offset = "0x25C54A0", VA = "0x1825C64A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x25C63D0", Offset = "0x25C53D0", VA = "0x1825C63D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event LKKFLDDFDFK GENFOLCADOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x25C65A0", Offset = "0x25C55A0", VA = "0x1825C65A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x25C6600", Offset = "0x25C5600", VA = "0x1825C6600", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event LKKFLDDFDFK MGCBDMJOJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x25C6720", Offset = "0x25C5720", VA = "0x1825C6720", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x25C6660", Offset = "0x25C5660", VA = "0x1825C6660", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event LKKFLDDFDFK FGNHNBADHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x25C5C70", Offset = "0x25C4C70", VA = "0x1825C5C70", Slot = "10")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x25C66C0", Offset = "0x25C56C0", VA = "0x1825C66C0", Slot = "11")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x25C6780", Offset = "0x25C5780", VA = "0x1825C6780")]
	[Preserve]
	internal APAFJKFKJIA([MOLIPDINIIE(null)] LKDGJLJGLMB KIKNDHMFIHG, [MOLIPDINIIE(null)] GEOOHGPBHKK LGPIIFOCLPE, [MOLIPDINIIE(null)] CPEBOHOONIO HONPPICLGIE, [MOLIPDINIIE(null)] DDHLPGJACDN BILODKHEIGN, [MOLIPDINIIE(null)] HLAKFCIILIA MJKKEBOEGAL, [MOLIPDINIIE(null)] JPEAFFCOLAB DJAPOFFJDAP, [MOLIPDINIIE(null)] GACFPALNPCN NGPGKMMAKBB, [MOLIPDINIIE(null)] MIGAHPHAEFH IHLDCCBLBJB, [MOLIPDINIIE(null)] INOGGKBAIAF DJDHPCAIJJN, [MOLIPDINIIE(null)] JIGAFPHNEIC DEHDIKFMEDP, [MOLIPDINIIE(null)] IOHBBLGCNFG FDDDLALLBHL, [MOLIPDINIIE(null)] CMLELKIMIHI CCFHAPBFNNP, [MOLIPDINIIE(null)] AOCHAFDEFCB ILNPJGMEIDN, [MOLIPDINIIE(null)] DGOAPDDEOMG KFGHPGNHIMD, [MOLIPDINIIE(null)] PPOJGGALBGL FCDJJFNIDHC, [MOLIPDINIIE(null)] LKPPCAFCADB GGHPDEHCABL, [MOLIPDINIIE(null)] KOAMBPJGMEC GPDINKAAPAL, [MOLIPDINIIE(null)] BCFHBFJIFGK PLNMDKJHBMF, [MOLIPDINIIE(null)] GKNIJLAECFE AMMLDPIAKFD, [MOLIPDINIIE(null)] AJAOKOGIDKE OMNCBMGFKDM, [MOLIPDINIIE(null)] FIEGDDAFLBG HIJEMNOFDCE, [MOLIPDINIIE(null)] KMAJEKLECLK LGDJJNGODMF, [MOLIPDINIIE(null)] EAMDLHMICCB JCNBDFEDDLE, [MOLIPDINIIE(null)] LCAFBKKPGDI GKANABDINPN, [MOLIPDINIIE(null)] NDNINLHOKEJ GBMKKOHDNJJ, [MOLIPDINIIE(null)] EHLJNBAFCMO BIEIOBCMFMD, [MOLIPDINIIE(null)] LNJNHKIAJFM LMJGELNMEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25C5BA0", Offset = "0x25C4BA0", VA = "0x1825C5BA0")]
	private void AICHPOAHICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x25C5E00", Offset = "0x25C4E00", VA = "0x1825C5E00", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x25C62C0", Offset = "0x25C52C0", VA = "0x1825C62C0", Slot = "14")]
	private void HKODAPGDENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x25C5CD0", Offset = "0x25C4CD0", VA = "0x1825C5CD0", Slot = "20")]
	private Task BJNFBNELOCN(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x25C6520", Offset = "0x25C5520", VA = "0x1825C6520", Slot = "21")]
	private void JHMMCDFMLOO(long MPOPHDGDFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x25C5D30", Offset = "0x25C4D30", VA = "0x1825C5D30", Slot = "22")]
	private bool CGPAMMALPML(long MICLPPPFMCH, out DateTime AKGPDJKALGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x25C6310", Offset = "0x25C5310", VA = "0x1825C6310", Slot = "18")]
	private Task HMBIBFJMNHM(string LLBPEMIKGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x25C5FD0", Offset = "0x25C4FD0", VA = "0x1825C5FD0", Slot = "15")]
	private Task<EHPFIBKEFJP> GHFBANGEHHO(NCMHNNOIOOH EHOBLCBOHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x25C6430", Offset = "0x25C5430", VA = "0x1825C6430", Slot = "16")]
	private Task<EHPFIBKEFJP> IILCKIDDIIN(CFKJNANNAIG JDPNHHFBFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x25C6060", Offset = "0x25C5060", VA = "0x1825C6060", Slot = "17")]
	private Task<EHPFIBKEFJP> HIGKINNANNO(int EGJOEKGOPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x25C61A0", Offset = "0x25C51A0", VA = "0x1825C61A0", Slot = "19")]
	[AsyncStateMachine(typeof(IFBCEDGNDDF))]
	private Task<EHPFIBKEFJP> HJLGPPONFMP(AJIPHKLOIPJ GAPFHPGFEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x25C5F60", Offset = "0x25C4F60", VA = "0x1825C5F60")]
	[IteratorStateMachine(typeof(LNHOGLBCIJB))]
	private IEnumerable<KLPKDCGKPJE> EFEIHDEKCFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x25C5DA0", Offset = "0x25C4DA0", VA = "0x1825C5DA0")]
	[CompilerGenerated]
	private void DGLELCHICPH(KLPKDCGKPJE LIHCFPMBOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class CJIBBEADFMK : POBKPJOPFJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct LNDIDEMNAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CJIBBEADFMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x25DA1F0", Offset = "0x25D91F0", VA = "0x1825DA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x25DA4C0", Offset = "0x25D94C0", VA = "0x1825DA4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5F8990", Offset = "0x5F7990", VA = "0x1805F8990")]
	public CJIBBEADFMK(MLNEICIMMPF JHHEABBOJHF, DDHLPGJACDN BILODKHEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x25CC300", Offset = "0x25CB300", VA = "0x1825CC300", Slot = "4")]
	[AsyncStateMachine(typeof(LNDIDEMNAPI))]
	public Task<bool> LKPBNGPJNGB(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x25CC240", Offset = "0x25CB240", VA = "0x1825CC240")]
	[CompilerGenerated]
	private object ALFMAGIIBAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class ILKFHNLMNFG : POBKPJOPFJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FPOAEPLIPJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ILKFHNLMNFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x240C9E0", Offset = "0x240B9E0", VA = "0x18240C9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x240CFA0", Offset = "0x240BFA0", VA = "0x18240CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float OOLAIIFEOMK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x240F430", Offset = "0x240E430", VA = "0x18240F430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5F8990", Offset = "0x5F7990", VA = "0x1805F8990")]
	public ILKFHNLMNFG(MLNEICIMMPF JHHEABBOJHF, DDHLPGJACDN BILODKHEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x240F480", Offset = "0x240E480", VA = "0x18240F480", Slot = "4")]
	[AsyncStateMachine(typeof(FPOAEPLIPJG))]
	public Task<bool> LKPBNGPJNGB(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x240F370", Offset = "0x240E370", VA = "0x18240F370")]
	[CompilerGenerated]
	private object IDMKJGIHPAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class JHMFPJDMGMP : POBKPJOPFJG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class KGACBNCMDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JHMFPJDMGMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Matchmaking.AEMJKEDODEH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BKIGCFACDJG newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KGACBNCMDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2415F90", Offset = "0x2414F90", VA = "0x182415F90")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2416050", Offset = "0x2415050", VA = "0x182416050")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x24160B0", Offset = "0x24150B0", VA = "0x1824160B0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BPOFCGIDKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JHMFPJDMGMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private KGACBNCMDDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<Matchmaking.AEMJKEDODEH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2409A90", Offset = "0x2408A90", VA = "0x182409A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x240A2B0", Offset = "0x24092B0", VA = "0x18240A2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float OOLAIIFEOMK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2412C80", Offset = "0x2411C80", VA = "0x182412C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8990", Offset = "0x5F7990", VA = "0x1805F8990")]
	public JHMFPJDMGMP(MLNEICIMMPF JHHEABBOJHF, DDHLPGJACDN BILODKHEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2412CD0", Offset = "0x2411CD0", VA = "0x182412CD0", Slot = "4")]
	[AsyncStateMachine(typeof(BPOFCGIDKLF))]
	public Task<bool> LKPBNGPJNGB(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface POBKPJOPFJG
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LKPBNGPJNGB(CancellationToken JNDOKGNDNMO);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal struct GDNPNANFOAE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class KCGOFIIJDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MLNEICIMMPF manager;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KCGOFIIJDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x24A74B0", Offset = "0x24A64B0", VA = "0x1824A74B0")]
		internal Task <CreateTask>b__0(LJDIAMGONCO data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HHNKMHDGABF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GDNPNANFOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <restore>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x24A1AD0", Offset = "0x24A0AD0", VA = "0x1824A1AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x24A1DC0", Offset = "0x24A0DC0", VA = "0x1824A1DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KEPFJGJGICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GDNPNANFOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x24A7ED0", Offset = "0x24A6ED0", VA = "0x1824A7ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationToken JNDOKGNDNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MLNEICIMMPF ADHLHDNNJBD;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private GEOOHGPBHKK NBDKCEOHLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x249CB80", Offset = "0x249BB80", VA = "0x18249CB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x249C900", Offset = "0x249B900", VA = "0x18249C900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x249CA40", Offset = "0x249BA40", VA = "0x18249CA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private JIGAFPHNEIC PCKGHABJHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x249CAC0", Offset = "0x249BAC0", VA = "0x18249CAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x249CBD0", Offset = "0x249BBD0", VA = "0x18249CBD0")]
	public GDNPNANFOAE(CancellationToken JNDOKGNDNMO, MLNEICIMMPF ADHLHDNNJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x249C770", Offset = "0x249B770", VA = "0x18249C770")]
	public static GFPDFBPNOCJ GJMJNIOONIK(MLNEICIMMPF ADHLHDNNJBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x249C440", Offset = "0x249B440", VA = "0x18249C440")]
	[AsyncStateMachine(typeof(HHNKMHDGABF))]
	public Task<bool> AEOMJAPKJGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x249C810", Offset = "0x249B810", VA = "0x18249C810")]
	private bool KBEGJEMFMHH(out FileInfo IKIHIDDCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x249C550", Offset = "0x249B550", VA = "0x18249C550")]
	[AsyncStateMachine(typeof(KEPFJGJGICC))]
	private Task BGPHNJNCGHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x249C650", Offset = "0x249B650", VA = "0x18249C650")]
	private Task<bool> FGPAJDEIKON(FileInfo IKIHIDDCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x249C950", Offset = "0x249B950", VA = "0x18249C950")]
	private Task LEBJBAPEHCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x249CB10", Offset = "0x249BB10", VA = "0x18249CB10")]
	private void LICMABKFKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal struct PGLKFOFCGGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PPOJGGALBGL FCDJJFNIDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Guid AHPODJGLLEM;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private Task<(EHPFIBKEFJP, Task)> KMILDAIBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4873140", Offset = "0x4872140", VA = "0x184873140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x245BED0", Offset = "0x245AED0", VA = "0x18245BED0")]
	public PGLKFOFCGGC(PPOJGGALBGL FCDJJFNIDHC, Guid AHPODJGLLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4873020", Offset = "0x4872020", VA = "0x184873020")]
	public TaskAwaiter<(EHPFIBKEFJP, Task)> DHGJJLHBAJP()
	{
		return default(TaskAwaiter<(EHPFIBKEFJP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4873070", Offset = "0x4872070", VA = "0x184873070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct GBGIOHGLKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly TaskCompletionSource<(EHPFIBKEFJP, Task)> IJHFFEJMDKG;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Task<(EHPFIBKEFJP, Task)> KMILDAIBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x249C1B0", Offset = "0x249B1B0", VA = "0x18249C1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x249C300", Offset = "0x249B300", VA = "0x18249C300")]
	public GBGIOHGLKJA(TimeSpan HPLFELDFDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x249C1F0", Offset = "0x249B1F0", VA = "0x18249C1F0")]
	public void MKAMCBHKNIH(Task FAMNCEJLICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x249C120", Offset = "0x249B120", VA = "0x18249C120")]
	public void HCBFCJBEDAA(EHPFIBKEFJP EOPMMJHAAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x249C0D0", Offset = "0x249B0D0", VA = "0x18249C0D0")]
	public void FMKJLCJDKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x249C280", Offset = "0x249B280", VA = "0x18249C280")]
	internal void OBHFHADJGGN(string LPDLECBMBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Preserve]
internal class BPCDJKJOFCB : INOGGKBAIAF, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JKDMFDLLFMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BPCDJKJOFCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x25D73E0", Offset = "0x25D63E0", VA = "0x1825D73E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JNGMFIANMOG GOKOPBDIDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string KOHAIIAADPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Task BHAELFGFLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool HJEFHMBMCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x25CAE50", Offset = "0x25C9E50", VA = "0x1825CAE50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Task POEBNIBPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x25CB000", Offset = "0x25CA000", VA = "0x1825CB000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440", Slot = "7")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x25CAE80", Offset = "0x25C9E80", VA = "0x1825CAE80", Slot = "6")]
	public void BHKLCDPOAAD(Task DOGDKDCOCKJ, string JDPHCNNGGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x25CB060", Offset = "0x25CA060", VA = "0x1825CB060")]
	[AsyncStateMachine(typeof(JKDMFDLLFMN))]
	private Task JJOOAGPENEJ(Task GBHKMKCAGLG, string JDPHCNNGGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x25CB190", Offset = "0x25CA190", VA = "0x1825CB190")]
	public BPCDJKJOFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal class CCIFPHBBBDI : EMHLBNCJIKK, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool KANHDDBLNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private OHNBBLGLCIB KECDGBHNAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private EHLJNBAFCMO BIEIOBCMFMD;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public OHNBBLGLCIB PKIIFFJAGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x25CB3E0", Offset = "0x25CA3E0", VA = "0x1825CB3E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x25CB2F0", Offset = "0x25CA2F0", VA = "0x1825CB2F0", Slot = "7")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x25CB510", Offset = "0x25CA510", VA = "0x1825CB510", Slot = "5")]
	public void PMDKAKBCADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x25CB450", Offset = "0x25CA450", VA = "0x1825CB450", Slot = "6")]
	public void DNBIHIPGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x25CB490", Offset = "0x25CA490", VA = "0x1825CB490")]
	private Task OLABEOHHNCF(LLMLOHKAOHN EDHFNBOOHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x25CB450", Offset = "0x25CA450", VA = "0x1825CB450", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public CCIFPHBBBDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class KMGEHDNCOMP : EHLJNBAFCMO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OIHAMGPIDNF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly OGJAEJOGNHO MDGACEJGPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly string GGLJFLNJABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly T NIPAKKKNCAD;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public T GFNFCEIHNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6107B0", Offset = "0x60F7B0", VA = "0x1806107B0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6678C0", Offset = "0x6668C0", VA = "0x1806678C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E05ED0", Offset = "0x3E04ED0", VA = "0x183E05ED0")]
		public OIHAMGPIDNF(OGJAEJOGNHO MDGACEJGPEG, string GGLJFLNJABJ, T NIPAKKKNCAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E05A40", Offset = "0x3E04A40", VA = "0x183E05A40")]
		private void PJOEHIPBGAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly OIHAMGPIDNF<TimeSpan> BFONHNPNKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly OIHAMGPIDNF<TimeSpan> HPPJMOMDJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly OIHAMGPIDNF<TimeSpan> FEGBDLFKJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly OIHAMGPIDNF<TimeSpan> GIGKGLFEKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly OIHAMGPIDNF<bool> CFLLFKHPGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly OIHAMGPIDNF<bool> LOOHKJCHKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly OIHAMGPIDNF<bool> KCLCPCOKJOB;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TimeSpan OAIPAAGJBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2416C60", Offset = "0x2415C60", VA = "0x182416C60", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public TimeSpan EPMBNKCDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2416D60", Offset = "0x2415D60", VA = "0x182416D60", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public TimeSpan GCCHIJEIJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2416C20", Offset = "0x2415C20", VA = "0x182416C20", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TimeSpan GFNIAHCCALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2416CE0", Offset = "0x2415CE0", VA = "0x182416CE0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool EIKFLJAHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2416CA0", Offset = "0x2415CA0", VA = "0x182416CA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool CNCKCJOBOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2416BE0", Offset = "0x2415BE0", VA = "0x182416BE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool HGCMMOAILAE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2416D20", Offset = "0x2415D20", VA = "0x182416D20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2416DA0", Offset = "0x2415DA0", VA = "0x182416DA0")]
	[Preserve]
	public KMGEHDNCOMP([MOLIPDINIIE(null)] OGJAEJOGNHO MDGACEJGPEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Preserve]
internal class JICOMODBFLA : IOHBBLGCNFG, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LNNAJCMOLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KBAEFPENIMP roomEvent;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LNNAJCMOLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2419F00", Offset = "0x2418F00", VA = "0x182419F00")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action DBFMEJHHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2413440", Offset = "0x2412440", VA = "0x182413440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2413300", Offset = "0x2412300", VA = "0x182413300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event LKKFLDDFDFK CJGLLNKHCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2413760", Offset = "0x2412760", VA = "0x182413760", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2413230", Offset = "0x2412230", VA = "0x182413230", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event LKKFLDDFDFK DFLACIEDNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2413190", Offset = "0x2412190", VA = "0x182413190", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2412E00", Offset = "0x2411E00", VA = "0x182412E00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event LKKFLDDFDFK CFJMACPOKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2412EA0", Offset = "0x2411EA0", VA = "0x182412EA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x24133A0", Offset = "0x24123A0", VA = "0x1824133A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "16")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2412F40", Offset = "0x2411F40", VA = "0x182412F40", Slot = "12")]
	public void CLCALLMJBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2413730", Offset = "0x2412730", VA = "0x182413730", Slot = "13")]
	public void LGCFDODAAMG(KBAEFPENIMP AEBCAGCGMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2413800", Offset = "0x2412800", VA = "0x182413800", Slot = "14")]
	public void PKOMMJIHPJH(KBAEFPENIMP AEBCAGCGMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x24132D0", Offset = "0x24122D0", VA = "0x1824132D0", Slot = "15")]
	public void GLJIMGCBJDM(KBAEFPENIMP AEBCAGCGMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x24134E0", Offset = "0x24124E0", VA = "0x1824134E0")]
	private void JONEFOPHFLN(LKKFLDDFDFK PMMNCIJKIJF, KBAEFPENIMP AEBCAGCGMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JICOMODBFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Preserve]
internal class PJEIOCHNIGD : CMLELKIMIHI, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct JEAGIMPPKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PJEIOCHNIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x486D130", Offset = "0x486C130", VA = "0x18486D130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EJCBPBIEPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PJEIOCHNIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x486B440", Offset = "0x486A440", VA = "0x18486B440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PMFJLCLLHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PMFJLCLLHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4874070", Offset = "0x4873070", VA = "0x184874070")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MNBKMLEMAHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PJEIOCHNIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private PMFJLCLLHGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x486DB30", Offset = "0x486CB30", VA = "0x18486DB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x486E260", Offset = "0x486D260", VA = "0x18486E260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KJFODOJLIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KJFODOJLIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x486D610", Offset = "0x486C610", VA = "0x18486D610")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private POBKPJOPFJG[] HFIGNAHFPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CancellationTokenSource LBBCAKAHNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private int BBPHKPKPKGG;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4873210", Offset = "0x4872210", VA = "0x184873210", Slot = "7")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x48734D0", Offset = "0x48724D0", VA = "0x1848734D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x48736E0", Offset = "0x48726E0", VA = "0x1848736E0", Slot = "6")]
	public void LLFNCPGCIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4873F20", Offset = "0x4872F20", VA = "0x184873F20", Slot = "5")]
	public void PAMIEANIPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x48735D0", Offset = "0x48725D0", VA = "0x1848735D0", Slot = "4")]
	[AsyncStateMachine(typeof(JEAGIMPPKLF))]
	public Task JEMCOJBFKJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4873C10", Offset = "0x4872C10", VA = "0x184873C10")]
	private void NNEKCBPEFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x48733B0", Offset = "0x48723B0", VA = "0x1848733B0")]
	[AsyncStateMachine(typeof(EJCBPBIEPKJ))]
	private Task DOGDOJMKIHF(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4873AE0", Offset = "0x4872AE0", VA = "0x184873AE0")]
	[AsyncStateMachine(typeof(MNBKMLEMAHJ))]
	private Task<bool> NNAEOHBIPFJ(int IIHEDPBOLFE, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4873290", Offset = "0x4872290", VA = "0x184873290")]
	private void CPEPLLFEMLE(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x48739E0", Offset = "0x48729E0", VA = "0x1848739E0")]
	private void NLDNJDPEAGG(int IIHEDPBOLFE, bool HKGHLMIMEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4873850", Offset = "0x4872850", VA = "0x184873850")]
	private void MEKFLLAPOGL(int IIHEDPBOLFE, Exception IEBKBOEFGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x48734E0", Offset = "0x48724E0", VA = "0x1848734E0")]
	private void GCCPAONDLHO(CancellationToken JNDOKGNDNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public PJEIOCHNIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Preserve]
internal class EFPJGLGAGPO : DGOAPDDEOMG, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OENACKFDICE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public EFPJGLGAGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public LJDIAMGONCO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x25DBF80", Offset = "0x25DAF80", VA = "0x1825DBF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class GMFHCCNHODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public EFPJGLGAGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public LJDIAMGONCO roomData;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GMFHCCNHODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x25D4CB0", Offset = "0x25D3CB0", VA = "0x1825D4CB0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct BEBPMCIIIGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GFPDFBPNOCJ taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x25CA2C0", Offset = "0x25C92C0", VA = "0x1825CA2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct EMEGPJPLKHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public EFPJGLGAGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x25D0480", Offset = "0x25CF480", VA = "0x1825D0480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HashSet<GFPDFBPNOCJ> PLPCFCKPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private CPEBOHOONIO HONPPICLGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private PMMHGJOPMBK DCIKKPHIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private IMGJFFKIOIK EFJDJJJHPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private IDisposable GMACJNLDMCB;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool GNGCKBAEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x25CEF80", Offset = "0x25CDF80", VA = "0x1825CEF80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	internal Task KMILDAIBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x25CF920", Offset = "0x25CE920", VA = "0x1825CF920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x25CED00", Offset = "0x25CDD00", VA = "0x1825CED00", Slot = "6")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x25CF530", Offset = "0x25CE530", VA = "0x1825CF530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x25CEF20", Offset = "0x25CDF20", VA = "0x1825CEF20", Slot = "5")]
	public bool CGBCCGDBLON(GFPDFBPNOCJ FMOFBFAHMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x25CF590", Offset = "0x25CE590", VA = "0x1825CF590")]
	private void ELBFKPMPCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x25CF6D0", Offset = "0x25CE6D0", VA = "0x1825CF6D0")]
	private void EOGJJPNKNKB(LJDIAMGONCO AJPJOCFLBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x25CFA00", Offset = "0x25CEA00", VA = "0x1825CFA00")]
	[AsyncStateMachine(typeof(OENACKFDICE))]
	private Task NBDAOHONPGI(LJDIAMGONCO AJPJOCFLBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x25CFC50", Offset = "0x25CEC50", VA = "0x1825CFC50")]
	private Func<CancellationToken, List<Task>> PNKNFPILFCK(LJDIAMGONCO AJPJOCFLBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x25CEF90", Offset = "0x25CDF90", VA = "0x1825CEF90")]
	private List<Task> DLBPKJOMIKJ(LJDIAMGONCO AJPJOCFLBAF, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x25CFB20", Offset = "0x25CEB20", VA = "0x1825CFB20")]
	[AsyncStateMachine(typeof(BEBPMCIIIGD))]
	private Task NMPIIHLOJIP(GFPDFBPNOCJ PCHBOBOPEPN, LJDIAMGONCO JEJGBICCBLN, CancellationToken KGJPBGICHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x25CF430", Offset = "0x25CE430", VA = "0x1825CF430")]
	[AsyncStateMachine(typeof(EMEGPJPLKHN))]
	private Task DNOKAPPKMJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x25CF930", Offset = "0x25CE930", VA = "0x1825CF930")]
	private void LLFNCPGCIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x25CFD00", Offset = "0x25CED00", VA = "0x1825CFD00")]
	public EFPJGLGAGPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Preserve]
internal class APBMCDIMDLB : AOCHAFDEFCB, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct MOKFDLFHFMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x25DA9A0", Offset = "0x25D99A0", VA = "0x1825DA9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NILKBKALKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private global::JKOIANHLHOA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private CHFLJCNHJAL <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private MBNKJBAMKPD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x25DB0F0", Offset = "0x25DA0F0", VA = "0x1825DB0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JCAKFCEEKJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Task<KPHIGKDHNKJ> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JCAKFCEEKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		internal Task<KPHIGKDHNKJ> <ConnectToRoomAndRunLoadLogic>b__0(MLACCLOKFHB _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KHLHLDMLIKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public CHFLJCNHJAL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private JCAKFCEEKJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DPAOFPLLJNG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private MLACCLOKFHB <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private PBJPIDBLDLH <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<KPHIGKDHNKJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x25D7BD0", Offset = "0x25D6BD0", VA = "0x1825D7BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FEKBOKFJKOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CBAFHLIDCCO presence;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FEKBOKFJKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x25D06C0", Offset = "0x25CF6C0", VA = "0x1825D06C0")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct KIHCOHBMIGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private MLACCLOKFHB <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private MLACCLOKFHB <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x25D98A0", Offset = "0x25D88A0", VA = "0x1825D98A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct GDFJHEDKIGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CHFLJCNHJAL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private MLACCLOKFHB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<DMDELMBOJIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x25D45C0", Offset = "0x25D35C0", VA = "0x1825D45C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class PJNLBDHALAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PJNLBDHALAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class HLNMKPCJKCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public PJNLBDHALAL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HLNMKPCJKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x25D5050", Offset = "0x25D4050", VA = "0x1825D5050")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x25D4F60", Offset = "0x25D3F60", VA = "0x1825D4F60")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct OLBHEIBJCMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private HLNMKPCJKCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x25DC390", Offset = "0x25DB390", VA = "0x1825DC390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct ODBHHEODJDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public CHFLJCNHJAL joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public KPHIGKDHNKJ initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public BKIGCFACDJG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public DPAOFPLLJNG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private MLACCLOKFHB <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x25DB990", Offset = "0x25DA990", VA = "0x1825DB990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct CHPIFCCDDKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private MLACCLOKFHB <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x25CBDF0", Offset = "0x25CADF0", VA = "0x1825CBDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct DNAGPFOJLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x25CCE60", Offset = "0x25CBE60", VA = "0x1825CCE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct HELAELOMEDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x25D4CE0", Offset = "0x25D3CE0", VA = "0x1825D4CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct IPOBCBOOFHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<EHPFIBKEFJP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x25D63B0", Offset = "0x25D53B0", VA = "0x1825D63B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct BNIHPGMAOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public APBMCDIMDLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x25CA590", Offset = "0x25C9590", VA = "0x1825CA590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PIONBAFJIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PIONBAFJIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x25DCCA0", Offset = "0x25DBCA0", VA = "0x1825DCCA0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GBCLAONGPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GBCLAONGPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x25D4170", Offset = "0x25D3170", VA = "0x1825D4170")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class AKMPEKPMMAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public AKMPEKPMMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x25C5B20", Offset = "0x25C4B20", VA = "0x1825C5B20")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DHCLIKBKCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public DHCLIKBKCJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x25CC540", Offset = "0x25CB540", VA = "0x1825CC540")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly string KHLDOIEOGKL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly string ICENDEFGLOA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly string HKBLLHNMFNM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static readonly Guid OHKDMFLCPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private MIGAHPHAEFH IHLDCCBLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CPEBOHOONIO HONPPICLGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private CMLELKIMIHI CCFHAPBFNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private KMAJEKLECLK LGDJJNGODMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private INOGGKBAIAF DJDHPCAIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IOHBBLGCNFG FDDDLALLBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private EHLJNBAFCMO BIEIOBCMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IDisposable GMACJNLDMCB;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public TaskStatus OEPJODBOIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F8CD0", Offset = "0x5F7CD0", VA = "0x1805F8CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EF0", Offset = "0x5F7EF0", VA = "0x1805F8EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x25C9650", Offset = "0x25C8650", VA = "0x1825C9650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x25C6D50", Offset = "0x25C5D50", VA = "0x1825C6D50", Slot = "6")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x25C7BD0", Offset = "0x25C6BD0", VA = "0x1825C7BD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x25C9520", Offset = "0x25C8520", VA = "0x1825C9520", Slot = "5")]
	[AsyncStateMachine(typeof(MOKFDLFHFMN))]
	public Task KPDEDEPFHNM(BKIGCFACDJG DBIDPHNGCDH, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x25C74A0", Offset = "0x25C64A0", VA = "0x1825C74A0")]
	[AsyncStateMachine(typeof(NILKBKALKKJ))]
	private Task CLEAAMJMAPH(BKIGCFACDJG DBIDPHNGCDH, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x25C8070", Offset = "0x25C7070", VA = "0x1825C8070")]
	private static void EMADOJEAEBE(MBNKJBAMKPD CFMOGGIEOCF, Exception IEBKBOEFGFK, [Optional] List<int> AOKBLFPEJNF, int BBPHKPKPKGG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x25C7210", Offset = "0x25C6210", VA = "0x1825C7210")]
	[AsyncStateMachine(typeof(KHLHLDMLIKJ))]
	private Task CHELNMPNDJF(MLACCLOKFHB BCAFPIOPGIA, BKIGCFACDJG DBIDPHNGCDH, CHFLJCNHJAL JOHOLFCEEPG, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x25C7380", Offset = "0x25C6380", VA = "0x1825C7380")]
	private void CKEFJGKNMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x25C6B20", Offset = "0x25C5B20", VA = "0x1825C6B20")]
	private CBAFHLIDCCO ADFAJFDPOKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x25C8E60", Offset = "0x25C7E60", VA = "0x1825C8E60")]
	[AsyncStateMachine(typeof(KIHCOHBMIGD))]
	private Task IIILPGHDBIO(MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x25C91A0", Offset = "0x25C81A0", VA = "0x1825C91A0")]
	private void JKJFEMBBEOH(BKIGCFACDJG DBIDPHNGCDH, CancellationToken GADEANLIDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x25C8820", Offset = "0x25C7820", VA = "0x1825C8820")]
	private void FKOFGBAGHIG(BKIGCFACDJG DBIDPHNGCDH, CHFLJCNHJAL JOHOLFCEEPG, OperationCanceledException BDHMOHJBGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x25C7910", Offset = "0x25C6910", VA = "0x1825C7910")]
	private void DHMHGKAKKJE(BKIGCFACDJG DBIDPHNGCDH, CHFLJCNHJAL JOHOLFCEEPG, Exception IEBKBOEFGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x25C7C20", Offset = "0x25C6C20", VA = "0x1825C7C20")]
	private void EDMHAOBAAHA(BKIGCFACDJG DBIDPHNGCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x25C78D0", Offset = "0x25C68D0", VA = "0x1825C78D0")]
	private static KBAEFPENIMP DHJEKBLFEIO(BKIGCFACDJG DBIDPHNGCDH)
	{
		return default(KBAEFPENIMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x25C9D70", Offset = "0x25C8D70", VA = "0x1825C9D70")]
	private void OPOBIADOEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x25C9ED0", Offset = "0x25C8ED0", VA = "0x1825C9ED0")]
	private static DMDELMBOJIK PBEIIOJBGFH(BKIGCFACDJG DBIDPHNGCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x25C9040", Offset = "0x25C8040", VA = "0x1825C9040")]
	[AsyncStateMachine(typeof(GDFJHEDKIGK))]
	private Task JCANJJLMKKP(BKIGCFACDJG DBIDPHNGCDH, CHFLJCNHJAL JOHOLFCEEPG, MLACCLOKFHB BCAFPIOPGIA, CancellationToken GPDBAMKAMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x25C9970", Offset = "0x25C8970", VA = "0x1825C9970")]
	[AsyncStateMachine(typeof(OLBHEIBJCMH))]
	private Task NFIPMJLDJOE(BKIGCFACDJG DBIDPHNGCDH, CancellationTokenSource ELJBMBGAIEI, Task HGEHLFNJPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x25C8AE0", Offset = "0x25C7AE0", VA = "0x1825C8AE0")]
	[AsyncStateMachine(typeof(ODBHHEODJDN))]
	private Task FPPJLEGLEKM(KPHIGKDHNKJ HMMPBCIIHKG, DPAOFPLLJNG MFBDCMAOLPA, BKIGCFACDJG DIPBNOBGKDE, CHFLJCNHJAL MFEGAJEJHGJ, MLACCLOKFHB BCAFPIOPGIA, CancellationToken FCKHGLGMHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x25C7E70", Offset = "0x25C6E70", VA = "0x1825C7E70")]
	private CHFLJCNHJAL EIPALBOBBHA(CHFLJCNHJAL MFEGAJEJHGJ, ref CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x25C7790", Offset = "0x25C6790", VA = "0x1825C7790")]
	[AsyncStateMachine(typeof(CHPIFCCDDKH))]
	private Task DFMJAGEPFDK(MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x25C75D0", Offset = "0x25C65D0", VA = "0x1825C75D0")]
	[AsyncStateMachine(typeof(DNAGPFOJLNB))]
	private Task CMEEDIFEICL(MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x25CA0B0", Offset = "0x25C90B0", VA = "0x1825CA0B0")]
	[AsyncStateMachine(typeof(HELAELOMEDF))]
	private Task PNMCAPAPCPB(MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x25C9AC0", Offset = "0x25C8AC0", VA = "0x1825C9AC0")]
	[AsyncStateMachine(typeof(IPOBCBOOFHK))]
	private Task OAOHONFBCFF(LJDIAMGONCO JEJGBICCBLN, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x25C8C60", Offset = "0x25C7C60", VA = "0x1825C8C60")]
	[AsyncStateMachine(typeof(BNIHPGMAOND))]
	private Task GMEDFBBHCFC(MLACCLOKFHB HDALINEEMFB, CancellationToken GPDBAMKAMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x25C8700", Offset = "0x25C7700", VA = "0x1825C8700")]
	private static void FABJNABLGEP(BKIGCFACDJG DBIDPHNGCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x25C97E0", Offset = "0x25C87E0", VA = "0x1825C97E0")]
	private void MNEMGMIMKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x25C94A0", Offset = "0x25C84A0", VA = "0x1825C94A0")]
	private void KMFMEAIBDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x25C7180", Offset = "0x25C6180", VA = "0x1825C7180")]
	private void BKOCGIONAIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x25C7700", Offset = "0x25C6700", VA = "0x1825C7700")]
	private void DDPKBNCLODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x25C96A0", Offset = "0x25C86A0", VA = "0x1825C96A0")]
	private static void LGILKFIMIPL(BKIGCFACDJG DBIDPHNGCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x25C8F90", Offset = "0x25C7F90", VA = "0x1825C8F90")]
	private static void IKBKFDEPPNJ(BKIGCFACDJG DBIDPHNGCDH, CancellationToken GPDBAMKAMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x25C9BF0", Offset = "0x25C8BF0", VA = "0x1825C9BF0")]
	private static void OKKIEMCBBOO(BKIGCFACDJG DBIDPHNGCDH, Exception IEBKBOEFGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x25C9F80", Offset = "0x25C8F80", VA = "0x1825C9F80")]
	private void PJOEEKAMMAL(BKIGCFACDJG DBIDPHNGCDH, Task HGEHLFNJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x25C8DA0", Offset = "0x25C7DA0", VA = "0x1825C8DA0")]
	private static void IDHLPDPOOPA(Func<string> PLNPNPKDGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x25CA2B0", Offset = "0x25C92B0", VA = "0x1825CA2B0")]
	public APBMCDIMDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal sealed class MODHEMJLCAJ : PPOJGGALBGL, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class DEIKPBLGDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public DEIKPBLGDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x240B3A0", Offset = "0x240A3A0", VA = "0x18240B3A0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class PAKMMMDKIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PAKMMMDKIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x24201E0", Offset = "0x241F1E0", VA = "0x1824201E0")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IGPKLKHFCLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IGPKLKHFCLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x240F0C0", Offset = "0x240E0C0", VA = "0x18240F0C0")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class IIMPMBKNJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IIMPMBKNJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x240F320", Offset = "0x240E320", VA = "0x18240F320")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class HFNMDMPHAKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HFNMDMPHAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x240ED70", Offset = "0x240DD70", VA = "0x18240ED70")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly Dictionary<Guid, GBGIOHGLKJA> FCDJJFNIDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private readonly TimeSpan JPDHPLIACJG;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "10")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x241CD20", Offset = "0x241BD20", VA = "0x18241CD20", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x241D4E0", Offset = "0x241C4E0", VA = "0x18241D4E0", Slot = "4")]
	public PGLKFOFCGGC PPCBFHPPBHE(Guid AHPODJGLLEM)
	{
		return default(PGLKFOFCGGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x241CAE0", Offset = "0x241BAE0", VA = "0x18241CAE0", Slot = "5")]
	public bool DKCILJPFPEA(Guid AHPODJGLLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x241D090", Offset = "0x241C090", VA = "0x18241D090", Slot = "8")]
	public bool LLFNCPGCIAG(Guid AHPODJGLLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x241CD30", Offset = "0x241BD30", VA = "0x18241CD30", Slot = "6")]
	public bool GCBAOMOJMNK(Guid AHPODJGLLEM, Task FAMNCEJLICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x241C8C0", Offset = "0x241B8C0", VA = "0x18241C8C0", Slot = "7")]
	public bool BMAMMEJCMOE(Guid AHPODJGLLEM, EHPFIBKEFJP EOPMMJHAAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x241C840", Offset = "0x241B840", VA = "0x18241C840", Slot = "9")]
	public Task<(EHPFIBKEFJP, Task)> AGPKODMGEEB(Guid AHPODJGLLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x241D2A0", Offset = "0x241C2A0", VA = "0x18241D2A0")]
	private void OOHPECOEOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x241D770", Offset = "0x241C770", VA = "0x18241D770")]
	public MODHEMJLCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[Preserve]
internal class FKPKJFIBEAL : LKPPCAFCADB, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class AAOBCBGFKKP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private readonly BKIGCFACDJG DMBEHEBAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private readonly CancellationTokenSource LBBCAKAHNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public readonly CancellationToken MJOJJBGFAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool PAGKCCNOFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool JBNHMJHHOJI;

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x25C4C50", Offset = "0x25C3C50", VA = "0x1825C4C50")]
		public AAOBCBGFKKP(BKIGCFACDJG DMBEHEBAJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x25C4B20", Offset = "0x25C3B20", VA = "0x1825C4B20")]
		public void LLFNCPGCIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x25C4AF0", Offset = "0x25C3AF0", VA = "0x1825C4AF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class HLBABHHLFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public LLMLOHKAOHN disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HLBABHHLFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x24A1FD0", Offset = "0x24A0FD0", VA = "0x1824A1FD0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct LBLNLEGKHCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public LLMLOHKAOHN disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public FKPKJFIBEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x24A88C0", Offset = "0x24A78C0", VA = "0x1824A88C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class NDCPCIGEOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NDCPCIGEOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x24AA2E0", Offset = "0x24A92E0", VA = "0x1824AA2E0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct AGPMDIBMJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public FKPKJFIBEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x25C5070", Offset = "0x25C4070", VA = "0x1825C5070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xFAC830", Offset = "0xFAB830", VA = "0x180FAC830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IMMBEDALEEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public BKIGCFACDJG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IMMBEDALEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x24A67C0", Offset = "0x24A57C0", VA = "0x1824A67C0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x24A6850", Offset = "0x24A5850", VA = "0x1824A6850")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x24A6890", Offset = "0x24A5890", VA = "0x1824A6890")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class EIEHDLLIEMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EIEHDLLIEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x249B230", Offset = "0x249A230", VA = "0x18249B230")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct BPJEAANCDEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public BKIGCFACDJG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public FKPKJFIBEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private IMMBEDALEEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x24967B0", Offset = "0x24957B0", VA = "0x1824967B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private CPEBOHOONIO HONPPICLGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private CMLELKIMIHI CCFHAPBFNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private EHLJNBAFCMO BIEIOBCMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private AOCHAFDEFCB ILNPJGMEIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private long NFFLPGMMFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private AAOBCBGFKKP BGOEJOMOMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private bool LNNAEIHJPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Task AIDKJBECDFI;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x25D3DB0", Offset = "0x25D2DB0", VA = "0x1825D3DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x25D30E0", Offset = "0x25D20E0", VA = "0x1825D30E0", Slot = "4")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x25D36B0", Offset = "0x25D26B0", VA = "0x1825D36B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x25D2FD0", Offset = "0x25D1FD0", VA = "0x1825D2FD0")]
	[AsyncStateMachine(typeof(LBLNLEGKHCI))]
	private Task ACNHBFMBMPM(LLMLOHKAOHN DJPPBDFJMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x25D33A0", Offset = "0x25D23A0", VA = "0x1825D33A0")]
	private void CDBHIOADEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x25D3B50", Offset = "0x25D2B50", VA = "0x1825D3B50")]
	private void JNGNKCINDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x25D3800", Offset = "0x25D2800", VA = "0x1825D3800")]
	private void EJLBBJMJMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x25D3D30", Offset = "0x25D2D30", VA = "0x1825D3D30")]
	private bool KGADNAMDPPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x25D32C0", Offset = "0x25D22C0", VA = "0x1825D32C0")]
	[AsyncStateMachine(typeof(AGPMDIBMJEF))]
	private void AMFBDCAJGCD(int PKMKIJMDLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x25D3E00", Offset = "0x25D2E00", VA = "0x1825D3E00")]
	private void LMBACDIONKI(out IDisposable LOGKDMDEBIG, out IDisposable OHOPACFEAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x25D39D0", Offset = "0x25D29D0", VA = "0x1825D39D0")]
	private bool FEMCDABKFKO(BKIGCFACDJG DMBEHEBAJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x25D35A0", Offset = "0x25D25A0", VA = "0x1825D35A0")]
	[AsyncStateMachine(typeof(BPJEAANCDEB))]
	private Task CLEAAMJMAPH(BKIGCFACDJG DMBEHEBAJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x25D40F0", Offset = "0x25D30F0", VA = "0x1825D40F0")]
	public FKPKJFIBEAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Preserve]
internal sealed class LCJCOBMECBP : KOAMBPJGMEC, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct AEAFKKGNGHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder<NGDEDPLJJJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public LCJCOBMECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<NGDEDPLJJJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2408AB0", Offset = "0x2407AB0", VA = "0x182408AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2408C80", Offset = "0x2407C80", VA = "0x182408C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class HGDMMLJKNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public ILPEFNEFIAF message;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HGDMMLJKNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x240EDC0", Offset = "0x240DDC0", VA = "0x18240EDC0")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class JEFJCIHDHCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public ILPEFNEFIAF messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JEFJCIHDHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2412200", Offset = "0x2411200", VA = "0x182412200")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class IFBOLIGDECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IFBOLIGDECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x240F070", Offset = "0x240E070", VA = "0x18240F070")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct MANAMGDNEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public LCJCOBMECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<NHNDDFDJKOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x241A110", Offset = "0x2419110", VA = "0x18241A110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class HDDLEAJKPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public ILPEFNEFIAF operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HDDLEAJKPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x240EBD0", Offset = "0x240DBD0", VA = "0x18240EBD0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct NLMEOLEJCGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public ILPEFNEFIAF operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LCJCOBMECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private CHFLJCNHJAL <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x241F4F0", Offset = "0x241E4F0", VA = "0x18241F4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct JGHENKLEPAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder<NHNDDFDJKOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public LCJCOBMECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private CHFLJCNHJAL <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2412490", Offset = "0x2411490", VA = "0x182412490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2412860", Offset = "0x2411860", VA = "0x182412860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class JELMADKPOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NHNDDFDJKOJ operation;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JELMADKPOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2412250", Offset = "0x2411250", VA = "0x182412250")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct BKBIFOPLBNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public NHNDDFDJKOJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public LCJCOBMECBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private global::JKOIANHLHOA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2408F40", Offset = "0x2407F40", VA = "0x182408F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class OILEIDNBHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OILEIDNBHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2420190", Offset = "0x241F190", VA = "0x182420190")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class PKIEPENECAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PKIEPENECAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x24202E0", Offset = "0x241F2E0", VA = "0x1824202E0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private INOGGKBAIAF DJDHPCAIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private BCFHBFJIFGK PLNMDKJHBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private KMAJEKLECLK LGDJJNGODMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private TaskCompletionSource<NGDEDPLJJJF> OCIINBNLOPF;

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2417D60", Offset = "0x2416D60", VA = "0x182417D60", Slot = "7")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2418930", Offset = "0x2417930", VA = "0x182418930", Slot = "6")]
	[AsyncStateMachine(typeof(AEAFKKGNGHI))]
	public Task<NGDEDPLJJJF> OCKFLHBCECF(CancellationToken JKCIAKLPGNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x24179F0", Offset = "0x24169F0", VA = "0x1824179F0", Slot = "4")]
	public void ACFBKCJDIGA(ILPEFNEFIAF LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2418570", Offset = "0x2417570", VA = "0x182418570", Slot = "5")]
	public void LDAPNDNPMON(ILPEFNEFIAF BEDIPMLGLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2417E40", Offset = "0x2416E40", VA = "0x182417E40")]
	[AsyncStateMachine(typeof(MANAMGDNEKN))]
	private Task ANFJBHPAIAG(ILPEFNEFIAF PDHKNAGOONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x24181C0", Offset = "0x24171C0", VA = "0x1824181C0")]
	[AsyncStateMachine(typeof(NLMEOLEJCGO))]
	private Task FNOAMOABNHN(ILPEFNEFIAF NIJFBBGHLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2417F50", Offset = "0x2416F50", VA = "0x182417F50")]
	[AsyncStateMachine(typeof(JGHENKLEPAF))]
	private Task<NHNDDFDJKOJ> CBAAAGJPJAB(ILPEFNEFIAF PDHKNAGOONJ, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x24188B0", Offset = "0x24178B0", VA = "0x1824188B0")]
	private CHFLJCNHJAL LOBBBEMMPMO(ILPEFNEFIAF LDGDAOIGAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2418090", Offset = "0x2417090", VA = "0x182418090")]
	[AsyncStateMachine(typeof(BKBIFOPLBNI))]
	private Task CDNCBBNNIHD(NHNDDFDJKOJ OLGIOFDHJLO, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x24182D0", Offset = "0x24172D0", VA = "0x1824182D0")]
	private NHNDDFDJKOJ IGCKDAPLOGG(ILPEFNEFIAF PDHKNAGOONJ, CHFLJCNHJAL JDCGDNIEJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x20C02A0", Offset = "0x20BF2A0", VA = "0x1820C02A0")]
	private T OBNJHFMMGIM<T>(T JNLOLNFALGF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2418A50", Offset = "0x2417A50", VA = "0x182418A50")]
	private NHNDDFDJKOJ PGAAFOKJLND(ILPEFNEFIAF PDHKNAGOONJ, CHFLJCNHJAL JDCGDNIEJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LCJCOBMECBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2418520", Offset = "0x2417520", VA = "0x182418520")]
	[CompilerGenerated]
	private void IPECGOJCBPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[Preserve]
internal sealed class PGDOCAAPACA : BCFHBFJIFGK, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class NNDFNFHEFCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NNDFNFHEFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x486E5C0", Offset = "0x486D5C0", VA = "0x18486E5C0")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NFGPLPEDDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NFGPLPEDDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x486E320", Offset = "0x486D320", VA = "0x18486E320")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private EAMDLHMICCB JCNBDFEDDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private KOAMBPJGMEC GPDINKAAPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private PPOJGGALBGL FCDJJFNIDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NDNINLHOKEJ GBMKKOHDNJJ;

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x4870F60", Offset = "0x486FF60", VA = "0x184870F60", Slot = "6")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x48722C0", Offset = "0x48712C0", VA = "0x1848722C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x4871300", Offset = "0x4870300", VA = "0x184871300", Slot = "4")]
	public PGLKFOFCGGC BPLGFFDEKPK(IIKMCKNMJKE PDHKNAGOONJ)
	{
		return default(PGLKFOFCGGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x4872DD0", Offset = "0x4871DD0", VA = "0x184872DD0", Slot = "5")]
	public void OPOHGMAOHMF(Guid AHPODJGLLEM, Task FAMNCEJLICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4872A30", Offset = "0x4871A30", VA = "0x184872A30")]
	private void IFPIFKHOPPL(byte FELCGHNENKD, int OMJDBKGFLEH, object ODMIIMBGOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x48719F0", Offset = "0x48709F0", VA = "0x1848719F0")]
	private void DFBPOOBKGOA(MBJJIHHBPFI KOEDNDNAKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x4872570", Offset = "0x4871570", VA = "0x184872570")]
	private void GDGILIDGOLJ(MBJJIHHBPFI KOEDNDNAKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x4871790", Offset = "0x4870790", VA = "0x184871790")]
	private void CJKPBGAINPE(MBJJIHHBPFI KOEDNDNAKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x4871FA0", Offset = "0x4870FA0", VA = "0x184871FA0")]
	private EHPFIBKEFJP DPAJMICHCPB(ILPEFNEFIAF LDGDAOIGAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x4872800", Offset = "0x4871800", VA = "0x184872800")]
	private void IDFAHDODOAB(ILPEFNEFIAF NIJFBBGHLLP, EHPFIBKEFJP EOPMMJHAAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4872350", Offset = "0x4871350", VA = "0x184872350")]
	private bool FEJCBBNAIEK(ILPEFNEFIAF NIJFBBGHLLP, EHPFIBKEFJP EOPMMJHAAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x48710B0", Offset = "0x48700B0", VA = "0x1848710B0")]
	private bool BPLGFFDEKPK(ILPEFNEFIAF LBIINAHFNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4872B00", Offset = "0x4871B00", VA = "0x184872B00")]
	private bool NNMBHJDODAH(byte FELCGHNENKD, ExitGames.Client.Photon.Hashtable KOEDNDNAKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public PGDOCAAPACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal sealed class JANGNEMHFJI : GKNIJLAECFE, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class DHHGCENHOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public NGDEDPLJJJF operationType;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public DHHGCENHOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x240B470", Offset = "0x240A470", VA = "0x18240B470")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct FNBPBAHCMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder<EHPFIBKEFJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public NGDEDPLJJJF operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public JANGNEMHFJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public CFKJNANNAIG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public NCMHNNOIOOH detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter<EHPFIBKEFJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x240C3C0", Offset = "0x240B3C0", VA = "0x18240C3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x240C990", Offset = "0x240B990", VA = "0x18240C990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class DLJFGNPBDFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public NGDEDPLJJJF operationType;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public DLJFGNPBDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x240BDE0", Offset = "0x240ADE0", VA = "0x18240BDE0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class EMIJHAOMANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public NGDEDPLJJJF operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EMIJHAOMANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x240C250", Offset = "0x240B250", VA = "0x18240C250")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x240C2B0", Offset = "0x240B2B0", VA = "0x18240C2B0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x240C310", Offset = "0x240B310", VA = "0x18240C310")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct KBABLMEABLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<EHPFIBKEFJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public NGDEDPLJJJF operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public JANGNEMHFJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public CFKJNANNAIG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public NCMHNNOIOOH detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private EMIJHAOMANJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private PGLKFOFCGGC <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private EHPFIBKEFJP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<(EHPFIBKEFJP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2415350", Offset = "0x2414350", VA = "0x182415350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2415990", Offset = "0x2414990", VA = "0x182415990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MOFAJCJIHIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public NGDEDPLJJJF operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public MOFAJCJIHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x241D810", Offset = "0x241C810", VA = "0x18241D810")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private AJAOKOGIDKE OMNCBMGFKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private EAMDLHMICCB JCNBDFEDDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private BCFHBFJIFGK PLNMDKJHBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2410E60", Offset = "0x240FE60", VA = "0x182410E60", Slot = "5")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2411790", Offset = "0x2410790", VA = "0x182411790", Slot = "4")]
	[AsyncStateMachine(typeof(FNBPBAHCMGM))]
	public Task<EHPFIBKEFJP> LPGBPJBAGNP(CFKJNANNAIG MOAPJIIBEJL, NGDEDPLJJJF EPEHCHIHIPG, [CanBeNull] NCMHNNOIOOH EHOBLCBOHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x24114F0", Offset = "0x24104F0", VA = "0x1824114F0")]
	private bool KMKPADLBBJG(NGDEDPLJJJF EPEHCHIHIPG, out EHPFIBKEFJP HCBFPGACPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x24113A0", Offset = "0x24103A0", VA = "0x1824113A0")]
	[AsyncStateMachine(typeof(KBABLMEABLE))]
	private Task<EHPFIBKEFJP> IEOGFLHCPFK(CFKJNANNAIG MOAPJIIBEJL, NGDEDPLJJJF EPEHCHIHIPG, [CanBeNull] NCMHNNOIOOH EHOBLCBOHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2410F60", Offset = "0x240FF60", VA = "0x182410F60")]
	internal IIKMCKNMJKE DNIJDAFGHLH(CFKJNANNAIG MOAPJIIBEJL, NGDEDPLJJJF EPEHCHIHIPG, [CanBeNull] NCMHNNOIOOH EHOBLCBOHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JANGNEMHFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Preserve]
internal sealed class IOCHDNAAGEF : AJAOKOGIDKE, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct KMLOCFMMPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder<KPHIGKDHNKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public IOCHDNAAGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<NCMHNNOIOOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2417020", Offset = "0x2416020", VA = "0x182417020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x24172E0", Offset = "0x24162E0", VA = "0x1824172E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class MOLDKBLKACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public MOLDKBLKACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x241D870", Offset = "0x241C870", VA = "0x18241D870")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct INPGFPPNEGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AsyncTaskMethodBuilder<NCMHNNOIOOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public IOCHDNAAGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public BKIGCFACDJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private MOLDKBLKACG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<MCOECFIFMLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x240FD10", Offset = "0x240ED10", VA = "0x18240FD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2410030", Offset = "0x240F030", VA = "0x182410030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class FGPPEDHIMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FGPPEDHIMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1035F10", Offset = "0x1034F10", VA = "0x181035F10")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(PGBMNMFNBLN sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private LNJNHKIAJFM LMJGELNMEKA;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly (CONELIFOGEN superRoomData, string unityAssetId, CONELIFOGEN subRoomData) MHPENNDEKAF;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2410BD0", Offset = "0x240FBD0", VA = "0x182410BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2410080", Offset = "0x240F080", VA = "0x182410080", Slot = "8")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x24106C0", Offset = "0x240F6C0", VA = "0x1824106C0", Slot = "4")]
	[AsyncStateMachine(typeof(KMLOCFMMPEG))]
	public Task<KPHIGKDHNKJ> IDGIJNBOMLL(MLACCLOKFHB HDALINEEMFB, BKIGCFACDJG DBIDPHNGCDH, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2410C20", Offset = "0x240FC20", VA = "0x182410C20")]
	[AsyncStateMachine(typeof(INPGFPPNEGH))]
	public Task<NCMHNNOIOOH> LPBBLGHIHPN(BKIGCFACDJG DBIDPHNGCDH, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2410450", Offset = "0x240F450", VA = "0x182410450", Slot = "5")]
	public KPHIGKDHNKJ HHLHEDDFCKL(BKIGCFACDJG DBIDPHNGCDH, NCMHNNOIOOH CHPLONOINCJ, long MPOPHDGDFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2410820", Offset = "0x240F820", VA = "0x182410820", Slot = "6")]
	public KPHIGKDHNKJ IEAILLGLFIL(BKIGCFACDJG DBIDPHNGCDH, NCAFGBCAKDF ENPHFCNNPIF, long MPOPHDGDFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2410930", Offset = "0x240F930", VA = "0x182410930", Slot = "7")]
	public KPHIGKDHNKJ JOKDAIBGBKO(long LNGEKBICNNH, long MPOPHDGDFPN, string FJBIEPGMBAJ, string KIJAAMLEMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2410A20", Offset = "0x240FA20", VA = "0x182410A20")]
	private static KPHIGKDHNKJ KJEEMNDEFMK(long LNGEKBICNNH, long MPOPHDGDFPN, CONELIFOGEN LOBEAGCCMKJ, string FJBIEPGMBAJ, CONELIFOGEN AJPJOCFLBAF, string KIJAAMLEMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2410110", Offset = "0x240F110", VA = "0x182410110")]
	private (CONELIFOGEN, string, CONELIFOGEN) DIGEPOHHDCF(BKIGCFACDJG DBIDPHNGCDH, NCMHNNOIOOH CHPLONOINCJ, long MPOPHDGDFPN)
	{
		return default((CONELIFOGEN, string, CONELIFOGEN));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public IOCHDNAAGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[Preserve]
internal sealed class HBCLIMNDGDL : KMAJEKLECLK, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class OIMMAFKHAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OIMMAFKHAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x24AA440", Offset = "0x24A9440", VA = "0x1824AA440")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct NAKLNKAMJLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public HBCLIMNDGDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public CHFLJCNHJAL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x24A9DD0", Offset = "0x24A8DD0", VA = "0x1824A9DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x24AA290", Offset = "0x24A9290", VA = "0x1824AA290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct CKNLPBOGDFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public HBCLIMNDGDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CHFLJCNHJAL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<IHOKGNKGKNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2499850", Offset = "0x2498850", VA = "0x182499850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2499D50", Offset = "0x2498D50", VA = "0x182499D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class AENLAFFAKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public AENLAFFAKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2495C70", Offset = "0x2494C70", VA = "0x182495C70")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct CACGBHEANIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public ILPEFNEFIAF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public HBCLIMNDGDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public CHFLJCNHJAL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private DGFHDABFOAG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private OLKNGAGOLDF <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<IHOKGNKGKNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2497280", Offset = "0x2496280", VA = "0x182497280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2497B60", Offset = "0x2496B60", VA = "0x182497B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private EMHLBNCJIKK HGFPECNMLGG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private OHNBBLGLCIB PKIIFFJAGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x24A0F00", Offset = "0x249FF00", VA = "0x1824A0F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x24A0D60", Offset = "0x249FD60", VA = "0x1824A0D60", Slot = "8")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x24A10F0", Offset = "0x24A00F0", VA = "0x1824A10F0", Slot = "4")]
	[AsyncStateMachine(typeof(NAKLNKAMJLH))]
	public Task<ILPEFNEFIAF> DLLPPBMFJNF(ILPEFNEFIAF PDHKNAGOONJ, CHFLJCNHJAL JDCGDNIEJCK, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x24A0FB0", Offset = "0x249FFB0", VA = "0x1824A0FB0", Slot = "5")]
	[AsyncStateMachine(typeof(CKNLPBOGDFB))]
	public Task<ILPEFNEFIAF> BMGJOCAOOMP(CancellationToken JNDOKGNDNMO, CHFLJCNHJAL JDCGDNIEJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x24A1240", Offset = "0x24A0240", VA = "0x1824A1240", Slot = "6")]
	public JKKMCLEIKNA GNCDENOMENC(NHNDDFDJKOJ PCLCIJOCHGA, MLACCLOKFHB HDALINEEMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x24A0DF0", Offset = "0x249FDF0", VA = "0x1824A0DF0", Slot = "7")]
	public JKKMCLEIKNA AIHLGANDGCL(NHNDDFDJKOJ PCLCIJOCHGA, MLACCLOKFHB HDALINEEMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x24A12E0", Offset = "0x24A02E0", VA = "0x1824A12E0")]
	[AsyncStateMachine(typeof(CACGBHEANIM))]
	private Task<ILPEFNEFIAF> HCGKFPCCFOM(ILPEFNEFIAF PDHKNAGOONJ, CHFLJCNHJAL JDCGDNIEJCK, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x24A0EF0", Offset = "0x249FEF0", VA = "0x1824A0EF0")]
	private static byte[] BFPPMGOHPEH(ILPEFNEFIAF LPDLECBMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x24A1430", Offset = "0x24A0430", VA = "0x1824A1430")]
	private static string ILMGLBLPLLJ(byte[] JHMMPAIEPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HBCLIMNDGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[Preserve]
internal sealed class DOOPCAMNODI : EAMDLHMICCB, KLPKDCGKPJE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private JPEAFFCOLAB DJAPOFFJDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private INOGGKBAIAF DJDHPCAIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private FIEGDDAFLBG HIJEMNOFDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private AOCHAFDEFCB ILNPJGMEIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private DGOAPDDEOMG KFGHPGNHIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private EHLJNBAFCMO BIEIOBCMFMD;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x25CDD40", Offset = "0x25CCD40", VA = "0x1825CDD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private static EHPFIBKEFJP MNIONKFGFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x25CD8D0", Offset = "0x25CC8D0", VA = "0x1825CD8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x25CD930", Offset = "0x25CC930", VA = "0x1825CD930", Slot = "7")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x25CDFF0", Offset = "0x25CCFF0", VA = "0x1825CDFF0", Slot = "4")]
	public EHPFIBKEFJP PIALCICEDCF(CFKJNANNAIG DNHDFJGPIFD, NGDEDPLJJJF OFOICKDPAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x25CDD90", Offset = "0x25CCD90", VA = "0x1825CDD90", Slot = "5")]
	public EHPFIBKEFJP NGDNLNJLFOP(CFKJNANNAIG EDHLMAKDBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x25CDB00", Offset = "0x25CCB00", VA = "0x1825CDB00", Slot = "6")]
	public EHPFIBKEFJP FAEILFBONMK(CFKJNANNAIG EDHLMAKDBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x25CDCE0", Offset = "0x25CCCE0", VA = "0x1825CDCE0")]
	private static EHPFIBKEFJP JAIEMNPECPD(MDCFDMMAAKA JICBGDLCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DOOPCAMNODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class GLMPDHADHHP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x249E2E0", Offset = "0x249D2E0", VA = "0x18249E2E0")]
	public GLMPDHADHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x971500", Offset = "0x970500", VA = "0x180971500")]
	public GLMPDHADHHP(string LPDLECBMBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Preserve]
internal sealed class NFDCLFFGCGC : JIGAFPHNEIC, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct DLCCFALBEOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<EHPFIBKEFJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public NFDCLFFGCGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AJIPHKLOIPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private global::JKOIANHLHOA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private MLACCLOKFHB <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private MLACCLOKFHB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<EHPFIBKEFJP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x240B710", Offset = "0x240A710", VA = "0x18240B710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x240BD90", Offset = "0x240AD90", VA = "0x18240BD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct ACEMGEOEBMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public NFDCLFFGCGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x24084C0", Offset = "0x24074C0", VA = "0x1824084C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct GMNHNDEOIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public NFDCLFFGCGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x240D9B0", Offset = "0x240C9B0", VA = "0x18240D9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct NDMJHBHEONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public NFDCLFFGCGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x241D910", Offset = "0x241C910", VA = "0x18241D910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct DCDMKHHKJBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NFDCLFFGCGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x240ADF0", Offset = "0x2409DF0", VA = "0x18240ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct GHPFLAKJPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public NFDCLFFGCGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AJIPHKLOIPJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private global::JKOIANHLHOA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x240D670", Offset = "0x240C670", VA = "0x18240D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private static readonly TimeSpan LCHMFGBIIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private GEOOHGPBHKK LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private KMAJEKLECLK LGDJJNGODMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private INOGGKBAIAF DJDHPCAIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private DGOAPDDEOMG KFGHPGNHIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private CancellationTokenSource OIAEMBLBOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private Task PCDFGIHMGAA;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x241DA60", Offset = "0x241CA60", VA = "0x18241DA60", Slot = "6")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x10CC320", Offset = "0x10CB320", VA = "0x1810CC320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x241DDC0", Offset = "0x241CDC0", VA = "0x18241DDC0", Slot = "4")]
	[AsyncStateMachine(typeof(DLCCFALBEOE))]
	public Task<EHPFIBKEFJP> EIECLOCJPLE(AJIPHKLOIPJ GAPFHPGFEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x241E110", Offset = "0x241D110", VA = "0x18241E110", Slot = "5")]
	[AsyncStateMachine(typeof(ACEMGEOEBMD))]
	public Task HBBFBJGFOAF([Optional] CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x10CC320", Offset = "0x10CB320", VA = "0x1810CC320")]
	public void LBBLEEOIBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x241DBF0", Offset = "0x241CBF0", VA = "0x18241DBF0")]
	private NJMCANBMBDI DKFHFEMOOMJ(AJIPHKLOIPJ GAPFHPGFEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x241E650", Offset = "0x241D650", VA = "0x18241E650")]
	[AsyncStateMachine(typeof(GMNHNDEOIOI))]
	private Task PDOJLIFMLPN(LJDIAMGONCO EDHFNBOOHPA, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x241E000", Offset = "0x241D000", VA = "0x18241E000")]
	[AsyncStateMachine(typeof(NDMJHBHEONM))]
	private Task HAENOICLIAO([Optional] CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x241DED0", Offset = "0x241CED0", VA = "0x18241DED0")]
	[AsyncStateMachine(typeof(DCDMKHHKJBK))]
	private Task GLJEGHABLLK(TimeSpan CGMBJLEBNPG, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x241E230", Offset = "0x241D230", VA = "0x18241E230")]
	private Task LCAPAKABDHG(AJIPHKLOIPJ GAPFHPGFEME, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x241E770", Offset = "0x241D770", VA = "0x18241E770")]
	[AsyncStateMachine(typeof(GHPFLAKJPFF))]
	private Task PPJNJBKHAFC(AJIPHKLOIPJ GAPFHPGFEME, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x241E500", Offset = "0x241D500", VA = "0x18241E500")]
	private bool LKDNPLHCBKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NFDCLFFGCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[Preserve]
internal class LIDOHJALIIO : FIEGDDAFLBG, KLPKDCGKPJE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct OGBCJCCNLMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public LIDOHJALIIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private global::JKOIANHLHOA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x241FDE0", Offset = "0x241EDE0", VA = "0x18241FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private GACFPALNPCN NGPGKMMAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private EAMDLHMICCB JCNBDFEDDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private KMAJEKLECLK LGDJJNGODMF;

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2419690", Offset = "0x2418690", VA = "0x182419690", Slot = "6")]
	public void AICHPOAHICB(MLNEICIMMPF JHHEABBOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2419810", Offset = "0x2418810", VA = "0x182419810", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2419830", Offset = "0x2418830", VA = "0x182419830", Slot = "5")]
	[AsyncStateMachine(typeof(OGBCJCCNLMJ))]
	public Task JLBDAEMHBKA(string LLBPEMIKGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2419950", Offset = "0x2418950", VA = "0x182419950", Slot = "4")]
	public EHPFIBKEFJP LKDNPLHCBKP(CFKJNANNAIG DNHDFJGPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2419970", Offset = "0x2418970", VA = "0x182419970")]
	private JGCCEGAGECJ PANIKKILMMF(string LLBPEMIKGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LIDOHJALIIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class HAMBPLMOONN
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x24A0960", Offset = "0x249F960", VA = "0x1824A0960")]
	public static void IFJMGIACNMF(LKDGJLJGLMB KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x24A08C0", Offset = "0x249F8C0", VA = "0x1824A08C0")]
	internal static void FCACFBABLHC(LKDGJLJGLMB KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x24A0820", Offset = "0x249F820", VA = "0x1824A0820")]
	internal static void DHKNPKHFGGA(LKDGJLJGLMB KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x24A0560", Offset = "0x249F560", VA = "0x1824A0560")]
	internal static void BCIFHMEMOFG(LKDGJLJGLMB KIKNDHMFIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class GIFNGIHIGEA : global::IGKKAHEDLOC<ILPEFNEFIAF>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class CEGDGBPLHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public ILPEFNEFIAF message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public CEGDGBPLHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2498890", Offset = "0x2497890", VA = "0x182498890")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly GIFNGIHIGEA CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private const string PEADEBMHKPG = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x249DB00", Offset = "0x249CB00", VA = "0x18249DB00")]
	public ExitGames.Client.Photon.Hashtable NJADPKHDAEC(ILPEFNEFIAF LPDLECBMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x249D3E0", Offset = "0x249C3E0", VA = "0x18249D3E0", Slot = "5")]
	protected override void DNKFHLIGJND(ILPEFNEFIAF LPDLECBMBMG, IDictionary<object, object> JEJGBICCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x249D4F0", Offset = "0x249C4F0", VA = "0x18249D4F0", Slot = "6")]
	public override ILPEFNEFIAF HIDKAFCIGIB(IDictionary<object, object> JEJGBICCBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x249D690", Offset = "0x249C690", VA = "0x18249D690")]
	private static void IDHLPDPOOPA(string DDDOJNJDILM, ILPEFNEFIAF LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x249DC00", Offset = "0x249CC00", VA = "0x18249DC00")]
	public GIFNGIHIGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x249D7E0", Offset = "0x249C7E0", VA = "0x18249D7E0")]
	[CompilerGenerated]
	internal static string JPAKPCMEFJC(KPHIGKDHNKJ PHHFPJMDJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class FFCFIJNDBFA
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public static EHPFIBKEFJP MNIONKFGFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x25CD8D0", Offset = "0x25CC8D0", VA = "0x1825CD8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x25D0B90", Offset = "0x25CFB90", VA = "0x1825D0B90")]
	public static bool KHEEEKIKCHO(this EHPFIBKEFJP EOPMMJHAAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x25CDCE0", Offset = "0x25CCCE0", VA = "0x1825CDCE0")]
	public static EHPFIBKEFJP JAIEMNPECPD(MDCFDMMAAKA OPPLIFBBKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x25D0BB0", Offset = "0x25CFBB0", VA = "0x1825D0BB0")]
	public static EHPFIBKEFJP MODNDEFACFN(params EHPFIBKEFJP[] LCCIMDOCMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x25D09F0", Offset = "0x25CF9F0", VA = "0x1825D09F0")]
	public static EHPFIBKEFJP IBNKIKOGPII(IEnumerable<EHPFIBKEFJP> LCCIMDOCMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x25D07F0", Offset = "0x25CF7F0", VA = "0x1825D07F0")]
	public static string FHGMBOEHGMJ(this EHPFIBKEFJP HCBFPGACPND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class HBCCONIMGMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public delegate EHPFIBKEFJP CLMODCLCGCJ([NotNull] CFKJNANNAIG EMLBJOGPBLL);

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GPBOHCHGBDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CFKJNANNAIG photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GPBOHCHGBDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x249F5B0", Offset = "0x249E5B0", VA = "0x18249F5B0")]
		internal EHPFIBKEFJP <Validate>b__0(CLMODCLCGCJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	protected readonly HashSet<CLMODCLCGCJ> BJKIANKMHJB;

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x24A0D00", Offset = "0x249FD00", VA = "0x1824A0D00")]
	public void LIOGNPHBPOC(CLMODCLCGCJ BPBBPBMNJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x24A0CA0", Offset = "0x249FCA0", VA = "0x1824A0CA0")]
	public void JIDOFLNANLM(CLMODCLCGCJ BPBBPBMNJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x24A0AA0", Offset = "0x249FAA0", VA = "0x1824A0AA0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x24A0AF0", Offset = "0x249FAF0", VA = "0x1824A0AF0")]
	protected EHPFIBKEFJP IGJJMLKCLEC(CFKJNANNAIG EDHLMAKDBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x249C060", Offset = "0x249B060", VA = "0x18249C060")]
	protected HBCCONIMGMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class JPEAFFCOLAB : HBCCONIMGMJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class FKHLDMOBMJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public EHPFIBKEFJP result;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FKHLDMOBMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x240C370", Offset = "0x240B370", VA = "0x18240C370")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2415340", Offset = "0x2414340", VA = "0x182415340")]
	[Preserve]
	public JPEAFFCOLAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x24151F0", Offset = "0x24141F0", VA = "0x1824151F0")]
	public EHPFIBKEFJP LPAELAFDGMO(CFKJNANNAIG EDHLMAKDBJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class GACFPALNPCN : HBCCONIMGMJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NGMJHDGOINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EHPFIBKEFJP result;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NGMJHDGOINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x24AA340", Offset = "0x24A9340", VA = "0x1824AA340")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x249C060", Offset = "0x249B060", VA = "0x18249C060")]
	[Preserve]
	public GACFPALNPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x249BD80", Offset = "0x249AD80", VA = "0x18249BD80")]
	public EHPFIBKEFJP LKDNPLHCBKP(CFKJNANNAIG DCDMNFHAAFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum PFNKBMDEMBM
{
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class OODGKADHHON
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class FNCBCEFJNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public global::JKOIANHLHOA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FNCBCEFJNOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x486BDD0", Offset = "0x486ADD0", VA = "0x18486BDD0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public const string OPJDJCAHAKP = "START: ";

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public const string PBDBKBIPJLN = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4870130", Offset = "0x486F130", VA = "0x184870130")]
	public static global::JKOIANHLHOA<string> IKOLICLIIGM([Optional] string ABDGHCLPBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x486FF60", Offset = "0x486EF60", VA = "0x18486FF60")]
	private static void AHKJPAOHBMM(string GGLJFLNJABJ, PNDIPJAIIED BCAFPIOPGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4870050", Offset = "0x486F050", VA = "0x184870050")]
	private static void CLNAHOHPACE(string GGLJFLNJABJ, PNDIPJAIIED BCAFPIOPGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x4870280", Offset = "0x486F280", VA = "0x184870280")]
	public static void LMKFMNKJDFB(global::JKOIANHLHOA<string> BCAFPIOPGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x48701E0", Offset = "0x486F1E0", VA = "0x1848701E0")]
	public static string JFAHFIDMINM(ILPEFNEFIAF LDGDAOIGAND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class LCMBCNEOEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x24194F0", Offset = "0x24184F0", VA = "0x1824194F0")]
	public static void HGMANKFECHK(this GEOOHGPBHKK LGPIIFOCLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2419500", Offset = "0x2418500", VA = "0x182419500")]
	public static void KFKDIICILBC(this GEOOHGPBHKK LGPIIFOCLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x24193F0", Offset = "0x24183F0", VA = "0x1824193F0")]
	private static void DEAACBJGFGJ(this GEOOHGPBHKK LGPIIFOCLPE, bool CCHJGBFIDIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class BPBHDFENMJB : GDEGAOBMPOI, KOMPOJLHJFL, DMAPDFIAACO, FKADKJJNFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly KOMPOJLHJFL JHHOECDDEIM;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public CFKJNANNAIG EFBEJOEACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x25CABA0", Offset = "0x25C9BA0", VA = "0x1825CABA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int OHONKHKEPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x25CA990", Offset = "0x25C9990", VA = "0x1825CA990", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int NAGHLDJLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x25CAE00", Offset = "0x25C9E00", VA = "0x1825CAE00", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool COMHPAJFCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int EDDAFOANDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6B0390", Offset = "0x6AF390", VA = "0x1806B0390", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event BFEBPFNDEKA.KCOFEKGKPHC KPPFPLFIAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event NDAMNGFMAPI ENBPBANMDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x25CAC90", Offset = "0x25C9C90", VA = "0x1825CAC90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x25CAB00", Offset = "0x25C9B00", VA = "0x1825CAB00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<bool> MGODAMMJEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<CFKJNANNAIG> POEDIHNPACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action BJBBIHPJDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x25CABF0", Offset = "0x25C9BF0", VA = "0x1825CABF0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x25CA850", Offset = "0x25C9850", VA = "0x1825CA850", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8FCC50", Offset = "0x8FBC50", VA = "0x1808FCC50")]
	public BPBHDFENMJB(KOMPOJLHJFL JHHOECDDEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x25CA8F0", Offset = "0x25C98F0", VA = "0x1825CA8F0", Slot = "8")]
	public bool BBCJPJKADHC(byte FELCGHNENKD, ExitGames.Client.Photon.Hashtable NNFEAHNHHFE, KGDLICEAKGA BILICHEJBEO, SendOptions GMMEEODLJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x25CAA60", Offset = "0x25C9A60", VA = "0x1825CAA60", Slot = "29")]
	public CFKJNANNAIG FEOCIEJKCKL(int NOPLNNJNKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x25CAD30", Offset = "0x25C9D30", VA = "0x1825CAD30", Slot = "16")]
	public CFKJNANNAIG JAOPMLOKICC(int EGJOEKGOPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "19")]
	public void FIELHHNDKFN(object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "20")]
	public void JPFCNLGCCJO(object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "21")]
	public void FEHMNDPIALP(object KGJPBGICHFN, bool DIJGFPFOLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x25CA9E0", Offset = "0x25C99E0", VA = "0x1825CA9E0", Slot = "22")]
	public IDisposable CCELGHFDDFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "23")]
	private bool OHINHLALBKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "24")]
	public void KHMGOAMDPEF(StringBuilder CKGCEKLFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x25CAA40", Offset = "0x25C9A40", VA = "0x1825CAA40", Slot = "25")]
	public bool DJNHCLMGPNP(bool IDMBDHFEDAA, out string PGKDPDHANLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	public void DHBEFBANJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xF41B30", Offset = "0xF40B30", VA = "0x180F41B30", Slot = "28")]
	public void OKHHEDFNGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct MBJJIHHBPFI
{
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public const string NMDCGPGMAPG = "v_result";

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public const string IAFFEPBNCHO = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly IDictionary<object, object> KOEDNDNAKBH;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xBBA190", Offset = "0xBB9190", VA = "0x180BBA190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
	public MBJJIHHBPFI(IDictionary<object, object> KOEDNDNAKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x241A990", Offset = "0x2419990", VA = "0x18241A990")]
	public bool FKBANCANCEF(out ILPEFNEFIAF LPDLECBMBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x241AA20", Offset = "0x2419A20", VA = "0x18241AA20")]
	public Guid HABNIDFLMDE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x241A790", Offset = "0x2419790", VA = "0x18241A790")]
	public EHPFIBKEFJP EEAFGLDIDAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x241A8C0", Offset = "0x24198C0", VA = "0x18241A8C0")]
	public static ExitGames.Client.Photon.Hashtable FBMLCAAKPML(ILPEFNEFIAF LPDLECBMBMG, EHPFIBKEFJP EOPMMJHAAKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class HDLACLGBPCG
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x24A18F0", Offset = "0x24A08F0", VA = "0x1824A18F0")]
	public static string KKHBAMJCMEK(this BKIGCFACDJG GHMHOEGJKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x24A1870", Offset = "0x24A0870", VA = "0x1824A1870")]
	public static bool BOMPANGHNEP(this BKIGCFACDJG GHMHOEGJKJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal struct IMGJFFKIOIK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct CKLKDOJLCKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public IMGJFFKIOIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x240A4F0", Offset = "0x24094F0", VA = "0x18240A4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly Func<CancellationToken, List<Task>> JJGFFALIAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly CancellationTokenSource LBBCAKAHNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Task DOGDKDCOCKJ;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x240F720", Offset = "0x240E720", VA = "0x18240F720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	internal Task KMILDAIBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x240F7A0", Offset = "0x240E7A0", VA = "0x18240F7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x240F820", Offset = "0x240E820", VA = "0x18240F820")]
	public IMGJFFKIOIK(Func<CancellationToken, List<Task>> JJGFFALIAIK, CancellationToken JNDOKGNDNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x240F610", Offset = "0x240E610", VA = "0x18240F610")]
	[AsyncStateMachine(typeof(CKLKDOJLCKP))]
	public Task BFINPLJKCMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x240F750", Offset = "0x240E750", VA = "0x18240F750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class MIGAHPHAEFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly DKPHKDPJJDM GPGMMMGDBAB;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private const string FAAAFHEKJMG = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private const string BIGOBGOONAG = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private const string PDGJGAGPBMF = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private const string EKFGIHCIHFE = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private string IFCGABENJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private long? MMELANPJEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private long? GGFOPNCKKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private KIEBILFOMFH PDEDIDMMIKM;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string ILCHOHAFBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public long DKMMOCFDFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x241B4F0", Offset = "0x241A4F0", VA = "0x18241B4F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public long AOBBDMJAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x241B9C0", Offset = "0x241A9C0", VA = "0x18241B9C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KIEBILFOMFH IPDAFGONJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x71D850", Offset = "0x71C850", VA = "0x18071D850")]
		get
		{
			return default(KIEBILFOMFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x241B6A0", Offset = "0x241A6A0", VA = "0x18241B6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x241BA10", Offset = "0x241AA10", VA = "0x18241BA10")]
	[Preserve]
	public MIGAHPHAEFH([MOLIPDINIIE(null)] DKPHKDPJJDM GPGMMMGDBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x241B540", Offset = "0x241A540", VA = "0x18241B540")]
	private void JOPLOBCIONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x241B780", Offset = "0x241A780", VA = "0x18241B780")]
	public void MDCIHFLILGI(long PBLGEAPLLBL, long MPOPHDGDFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x241B1C0", Offset = "0x241A1C0", VA = "0x18241B1C0")]
	public void APFDEBFNFME(string PFLLDGNIBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x241B2B0", Offset = "0x241A2B0", VA = "0x18241B2B0")]
	public void BLBIJPELHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class JKKMCLEIKNA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct EHMMJEHOMEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public ILPEFNEFIAF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public JKKMCLEIKNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private TaskAwaiter<ELKFHENBDHA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x240BE40", Offset = "0x240AE40", VA = "0x18240BE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x240C200", Offset = "0x240B200", VA = "0x18240C200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct KIFONMAFHJP<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class OFECEAOBJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public ILPEFNEFIAF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OFECEAOBJCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x241FCF0", Offset = "0x241ECF0", VA = "0x18241FCF0")]
		internal ILPEFNEFIAF <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct LCKNFJHALCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<ELKFHENBDHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public ILPEFNEFIAF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public JKKMCLEIKNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private DGFHDABFOAG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<ELKFHENBDHA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2418DC0", Offset = "0x2417DC0", VA = "0x182418DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x24193A0", Offset = "0x24183A0", VA = "0x1824193A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct KPHDOBDKAJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public JKKMCLEIKNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x2417880", Offset = "0x2416880", VA = "0x182417880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class BNPMHDMEKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public BNPMHDMEKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2409940", Offset = "0x2408940", VA = "0x182409940")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class CCONBMLALFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public CCONBMLALFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x240A300", Offset = "0x2409300", VA = "0x18240A300")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class NGJKAENIHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NGJKAENIHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x241E910", Offset = "0x241D910", VA = "0x18241E910")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class MGIBJCMLKDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public MGIBJCMLKDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x241B160", Offset = "0x241A160", VA = "0x18241B160")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class NJKKICNMEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public JKKMCLEIKNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NJKKICNMEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x241F2A0", Offset = "0x241E2A0", VA = "0x18241F2A0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class ICNLOFGFMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public JKKMCLEIKNA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ICNLOFGFMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x240EE10", Offset = "0x240DE10", VA = "0x18240EE10")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private static readonly Guid BAJMGOAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly NHNDDFDJKOJ EPDMLBONCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly OHNBBLGLCIB BAOFBJHOMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private readonly DMAPDFIAACO LGPIIFOCLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private readonly FKADKJJNFNI PPAFHHJNKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private bool DCGNBBONJFJ;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2415010", Offset = "0x2414010", VA = "0x182415010")]
	public JKKMCLEIKNA(NHNDDFDJKOJ OLGIOFDHJLO, OHNBBLGLCIB BAOFBJHOMGK, DMAPDFIAACO LGPIIFOCLPE, FKADKJJNFNI PPAFHHJNKLK, MLACCLOKFHB HDALINEEMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2414190", Offset = "0x2413190", VA = "0x182414190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2414230", Offset = "0x2413230", VA = "0x182414230")]
	public void EKEBINGJAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2413E70", Offset = "0x2412E70", VA = "0x182413E70")]
	public void CLPIEMNPAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x24143B0", Offset = "0x24133B0", VA = "0x1824143B0")]
	public void FEKNHBOEABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2414E50", Offset = "0x2413E50", VA = "0x182414E50")]
	[AsyncStateMachine(typeof(EHMMJEHOMEF))]
	internal Task<ILPEFNEFIAF> PPHOJMIGBAL(MLACCLOKFHB HDALINEEMFB, ILPEFNEFIAF LDGDAOIGAND, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x24A0EF0", Offset = "0x249FEF0", VA = "0x1824A0EF0")]
	private static byte[] GABEHKPKNGO<T>(T LPDLECBMBMG) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x20B6860", Offset = "0x20B5860", VA = "0x1820B6860")]
	private static T DHLNLFJBFAL<T>(MessageParser<T> NCGEJDBGGAB, byte[] LPDLECBMBMG, T CGNOHBLIFGE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2413B10", Offset = "0x2412B10", VA = "0x182413B10")]
	[AsyncStateMachine(typeof(LCKNFJHALCH))]
	private Task<ELKFHENBDHA> AAMKAKNFFFE(ILPEFNEFIAF LDGDAOIGAND, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x22871D0", Offset = "0x22861D0", VA = "0x1822871D0")]
	[AsyncStateMachine(typeof(EBNHIDBPIFI))]
	internal Task<T> OAJLIOLLGPF<T>(CancellationToken GADEANLIDCE, Func<CancellationToken, Task<T>> FMJJMMKFEPK, int FGKMPHGDGNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2414B80", Offset = "0x2413B80", VA = "0x182414B80")]
	[AsyncStateMachine(typeof(KPHDOBDKAJE))]
	internal Task OAJLIOLLGPF(CancellationToken GADEANLIDCE, Func<CancellationToken, Task> FMJJMMKFEPK, int FGKMPHGDGNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2414100", Offset = "0x2413100", VA = "0x182414100")]
	public ILPEFNEFIAF DPHIGGOCGAH(DGFHDABFOAG HFEIPBIAAHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2414510", Offset = "0x2413510", VA = "0x182414510")]
	public EDPOAKCFMHA ICDNOFBBMPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2414B10", Offset = "0x2413B10", VA = "0x182414B10")]
	public IHBJJKLCMDK NPKGJJOBAON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x24141A0", Offset = "0x24131A0", VA = "0x1824141A0")]
	public GMNHCACGPFH EAMNDJMDPFJ([Optional] HNBGEDIDMCE? CODPMPJAOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2413DB0", Offset = "0x2412DB0", VA = "0x182413DB0")]
	public FGOAEAFHLCE BCOGFIKANJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x24144E0", Offset = "0x24134E0", VA = "0x1824144E0")]
	public void GKONCPJEDGN(Func<Guid, bool> OFFJFENHOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2414CD0", Offset = "0x2413CD0", VA = "0x182414CD0")]
	public void PIFPCGOKELP(Func<Guid, bool> DJOIOCBCMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2413C50", Offset = "0x2412C50", VA = "0x182413C50")]
	public void BBOLAJEHLBI(Func<Guid, bool> OFFJFENHOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2414940", Offset = "0x2413940", VA = "0x182414940")]
	public Guid MLPGMFLDCOE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2413FA0", Offset = "0x2412FA0", VA = "0x182413FA0")]
	public void DJMEOJLHNAE(Guid AJGFNANMPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2414820", Offset = "0x2413820", VA = "0x182414820")]
	public void LMFLAJJANCF(ILPEFNEFIAF ONDECJBNJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2414580", Offset = "0x2413580", VA = "0x182414580")]
	public void IDHLPDPOOPA(string JBEDKPGLDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x24146D0", Offset = "0x24136D0", VA = "0x1824146D0")]
	public void IDHLPDPOOPA(Func<string> HGIBMPFFGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x20B69B0", Offset = "0x20B59B0", VA = "0x1820B69B0")]
	private T OBNJHFMMGIM<T>(T JNLOLNFALGF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2413E20", Offset = "0x2412E20", VA = "0x182413E20")]
	public void BEFNADDGDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x215E830", Offset = "0x215D830", VA = "0x18215E830")]
	[CompilerGenerated]
	internal static string DGPLMGNGEIG<T>(byte[] FCLFFFPNPCK, int JKCIDBAKCCM, ref KIFONMAFHJP<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal sealed class IDAEGDEMLIC : NHNDDFDJKOJ
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class OJNMDBMKDNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OJNMDBMKDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x24AA490", Offset = "0x24A9490", VA = "0x1824AA490")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct BDBFPJMNJPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IDAEGDEMLIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private IHBJJKLCMDK <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2495E50", Offset = "0x2494E50", VA = "0x182495E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class HOAIOHMAFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CBAFHLIDCCO presence;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HOAIOHMAFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x24A2430", Offset = "0x24A1430", VA = "0x1824A2430")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private readonly KPHIGKDHNKJ HMMPBCIIHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly BKIGCFACDJG CJJBHAGNHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private readonly AJAOKOGIDKE OMNCBMGFKDM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private const bool NBGLGNBBIGP = false;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x24A3850", Offset = "0x24A2850", VA = "0x1824A3850")]
	public IDAEGDEMLIC(KPHIGKDHNKJ HMMPBCIIHKG, BKIGCFACDJG CJJBHAGNHOA, Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, CHFLJCNHJAL DNDPCMBLHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x24A35D0", Offset = "0x24A25D0", VA = "0x1824A35D0", Slot = "8")]
	[AsyncStateMachine(typeof(BDBFPJMNJPC))]
	protected override Task JIGGAOEDCLC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x24A31D0", Offset = "0x24A21D0", VA = "0x1824A31D0")]
	private CBAFHLIDCCO ADFAJFDPOKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x24A3710", Offset = "0x24A2710", VA = "0x1824A3710")]
	private void NECFKPAPMLB(CBAFHLIDCCO KGCPNPNPLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x24A34F0", Offset = "0x24A24F0", VA = "0x1824A34F0")]
	private static void FABJNABLGEP(BKIGCFACDJG GHMHOEGJKJI, [Optional] string LPDLECBMBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class NJMCANBMBDI : NHNDDFDJKOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct DBCPBIDGPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public NJMCANBMBDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<NCMHNNOIOOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x486AF50", Offset = "0x4869F50", VA = "0x18486AF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private readonly int PCJPDAOLPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private readonly AJIPHKLOIPJ GAPFHPGFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public readonly long EAFHDALHLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public readonly long HHPPFDEAMGM;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x486E4C0", Offset = "0x486D4C0", VA = "0x18486E4C0")]
	public NJMCANBMBDI(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, CHFLJCNHJAL DNDPCMBLHKP, int PCJPDAOLPJO, AJIPHKLOIPJ GAPFHPGFEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x486E380", Offset = "0x486D380", VA = "0x18486E380", Slot = "8")]
	[AsyncStateMachine(typeof(DBCPBIDGPHE))]
	protected override Task JIGGAOEDCLC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal abstract class JKJEEGCBBFC : NHNDDFDJKOJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class PKDIKOIKDCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public JKJEEGCBBFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public CMIDHIHPFMF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PKDIKOIKDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2420230", Offset = "0x241F230", VA = "0x182420230")]
		internal Task <RunAsync>b__0(MLACCLOKFHB postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2420270", Offset = "0x241F270", VA = "0x182420270")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct GCBDHEIFGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public JKJEEGCBBFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private PKDIKOIKDCM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x240CFF0", Offset = "0x240BFF0", VA = "0x18240CFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct IMIHINOOJEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public CMIDHIHPFMF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public JKJEEGCBBFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x240F940", Offset = "0x240E940", VA = "0x18240F940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2413AD0", Offset = "0x2412AD0", VA = "0x182413AD0")]
	public JKJEEGCBBFC(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, CHFLJCNHJAL DNDPCMBLHKP, string AHIHNOGGPOG, bool ADKGGMCPHJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2413990", Offset = "0x2412990", VA = "0x182413990", Slot = "8")]
	[AsyncStateMachine(typeof(GCBDHEIFGIG))]
	protected override Task JIGGAOEDCLC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task BBJLBOJKDHJ(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2413830", Offset = "0x2412830", VA = "0x182413830")]
	[AsyncStateMachine(typeof(IMIHINOOJEE))]
	private Task ANFEFJNLGOA(IDisposable KEBKMMGHOOH, CMIDHIHPFMF DODPLKMNNHE, MLACCLOKFHB BCAFPIOPGIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class DJGDKHGOBNN : NHNDDFDJKOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct IJPCGNDCCBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public DJGDKHGOBNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private FGOAEAFHLCE <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<LPBFELBNLDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x25D5690", Offset = "0x25D4690", VA = "0x1825D5690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly AJIPHKLOIPJ GAPFHPGFEME;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x25CC830", Offset = "0x25CB830", VA = "0x1825CC830")]
	public DJGDKHGOBNN(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, CHFLJCNHJAL DNDPCMBLHKP, AJIPHKLOIPJ GAPFHPGFEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x25CC760", Offset = "0x25CB760", VA = "0x1825CC760", Slot = "7")]
	protected override string JJKANBBLGCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x25CC620", Offset = "0x25CB620", VA = "0x1825CC620", Slot = "8")]
	[AsyncStateMachine(typeof(IJPCGNDCCBJ))]
	protected override Task JIGGAOEDCLC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal abstract class NHNDDFDJKOJ : EPDNPFNIAMK
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public delegate Task BLOGCCLGBGG(MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class HFLFIGKFNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public MLACCLOKFHB operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public NHNDDFDJKOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HFLFIGKFNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x240EC20", Offset = "0x240DC20", VA = "0x18240EC20")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private sealed class LGJIIGDODPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public HFLFIGKFNHL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LGJIIGDODPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2419510", Offset = "0x2418510", VA = "0x182419510")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x24195D0", Offset = "0x24185D0", VA = "0x1824195D0")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct GNJAGGFPEAE : IAsyncStateMachine
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
		public NHNDDFDJKOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public Func<NHNDDFDJKOJ, MLACCLOKFHB, JKKMCLEIKNA> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private HFLFIGKFNHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private JKKMCLEIKNA <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x240DF90", Offset = "0x240CF90", VA = "0x18240DF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct DKDAOKFKIHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NHNDDFDJKOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x240B4D0", Offset = "0x240A4D0", VA = "0x18240B4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public readonly Guid MKPFCKAPFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public readonly ByteString LAHEJCDDCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public readonly CHFLJCNHJAL ONLDCEDLBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	protected readonly string GNOHFHGCEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly bool ADKGGMCPHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private bool NELDFEGCKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public KIEBILFOMFH AJPKBODEGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public KIEBILFOMFH PPENKNJOCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly Queue<BLOGCCLGBGG> LJNLDHLGOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly PBJPIDBLDLH JBKHKMBBADK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MLNEICIMMPF CKIFPONFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x241EE90", Offset = "0x241DE90", VA = "0x18241EE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public HLAKFCIILIA AOGELCEANMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x241EAB0", Offset = "0x241DAB0", VA = "0x18241EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x241EEE0", Offset = "0x241DEE0", VA = "0x18241EEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public float IPFNAIGCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x241ECF0", Offset = "0x241DCF0", VA = "0x18241ECF0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MDJDGEJJGLJ NAJMPEHFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x241EF60", Offset = "0x241DF60", VA = "0x18241EF60", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x241ECD0", Offset = "0x241DCD0", VA = "0x18241ECD0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x241F180", Offset = "0x241E180", VA = "0x18241F180")]
	protected NHNDDFDJKOJ(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, CHFLJCNHJAL DNDPCMBLHKP, string AHIHNOGGPOG, bool ADKGGMCPHJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x241EE50", Offset = "0x241DE50", VA = "0x18241EE50", Slot = "7")]
	protected virtual string JJKANBBLGCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x241EC50", Offset = "0x241DC50", VA = "0x18241EC50")]
	public void ELJJGJPDNAA(BLOGCCLGBGG PCHBOBOPEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x241ECB0", Offset = "0x241DCB0", VA = "0x18241ECB0")]
	protected void GJIPNINFLPO(float BKLFBAMHBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x241E970", Offset = "0x241D970", VA = "0x18241E970")]
	[AsyncStateMachine(typeof(GNJAGGFPEAE))]
	public Task AEOMJAPKJGO(CancellationToken JNDOKGNDNMO, MLACCLOKFHB HDALINEEMFB, [Optional] Func<NHNDDFDJKOJ, MLACCLOKFHB, JKKMCLEIKNA> DGJCFDAHKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x241EF80", Offset = "0x241DF80", VA = "0x18241EF80")]
	private void MLCBCNPANBB(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JIGGAOEDCLC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x241ED10", Offset = "0x241DD10", VA = "0x18241ED10")]
	[AsyncStateMachine(typeof(DKDAOKFKIHA))]
	private Task HOOPIOBHEFD(MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x241EBD0", Offset = "0x241DBD0", VA = "0x18241EBD0")]
	public ILPEFNEFIAF DPHIGGOCGAH(DGFHDABFOAG HFEIPBIAAHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x241EB00", Offset = "0x241DB00", VA = "0x18241EB00")]
	[CompilerGenerated]
	private Task DGHNCFNANAL(CancellationToken JBJIMKKMMPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal sealed class GENOPKJLFBL : JKJEEGCBBFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct KIJPDBDMNLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public GENOPKJLFBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private KBAEFPENIMP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private IHBJJKLCMDK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x24A8160", Offset = "0x24A7160", VA = "0x1824A8160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private readonly KPHIGKDHNKJ DHBFBGIAPBN;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x249CD50", Offset = "0x249BD50", VA = "0x18249CD50")]
	public GENOPKJLFBL(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, KPHIGKDHNKJ DHBFBGIAPBN, CHFLJCNHJAL DNDPCMBLHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x249CC10", Offset = "0x249BC10", VA = "0x18249CC10", Slot = "9")]
	[AsyncStateMachine(typeof(KIJPDBDMNLI))]
	protected override Task BBJLBOJKDHJ(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class JGCCEGAGECJ : NHNDDFDJKOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct JGMCEILPDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public JGCCEGAGECJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<LPBFELBNLDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x24128B0", Offset = "0x24118B0", VA = "0x1824128B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private readonly string AOPOPCAIAKH;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x24123F0", Offset = "0x24113F0", VA = "0x1824123F0")]
	public JGCCEGAGECJ(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, CHFLJCNHJAL DNDPCMBLHKP, string AOPOPCAIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x24122C0", Offset = "0x24112C0", VA = "0x1824122C0", Slot = "8")]
	[AsyncStateMachine(typeof(JGMCEILPDPA))]
	protected override Task JIGGAOEDCLC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class DJMNJLCIMNA : JKJEEGCBBFC
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class KPCCLHAHMME
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public KPCCLHAHMME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<LPBFELBNLDJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			private TaskAwaiter<ILPEFNEFIAF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x25DD0C0", Offset = "0x25DC0C0", VA = "0x1825DD0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x25DD580", Offset = "0x25DC580", VA = "0x1825DD580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public DJMNJLCIMNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public GMNHCACGPFH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public EDPOAKCFMHA uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KPCCLHAHMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x25DA0D0", Offset = "0x25D90D0", VA = "0x1825DA0D0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<ILPEFNEFIAF> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct IPFJKCNENMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public DJMNJLCIMNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private KPCCLHAHMME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private KBAEFPENIMP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private IHBJJKLCMDK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x25D5AD0", Offset = "0x25D4AD0", VA = "0x1825D5AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly int HAGCHBJIOKN;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x25CCCB0", Offset = "0x25CBCB0", VA = "0x1825CCCB0")]
	public DJMNJLCIMNA(Guid AHPODJGLLEM, MLNEICIMMPF JHHEABBOJHF, int HAGCHBJIOKN, CHFLJCNHJAL DNDPCMBLHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x25CC8C0", Offset = "0x25CB8C0", VA = "0x1825CC8C0", Slot = "9")]
	[AsyncStateMachine(typeof(IPFJKCNENMA))]
	protected override Task BBJLBOJKDHJ(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x25CCBE0", Offset = "0x25CBBE0", VA = "0x1825CCBE0")]
	private void LLBGKPKFNBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x25CCA00", Offset = "0x25CBA00", VA = "0x1825CCA00")]
	private void DEAHFABCJKK(MLACCLOKFHB HDALINEEMFB, KBAEFPENIMP AEBCAGCGMFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal abstract class EJCGEIHPNLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly NHNDDFDJKOJ EPDMLBONCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly JKKMCLEIKNA DCLOOOJBOHJ;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x25CFDB0", Offset = "0x25CEDB0", VA = "0x1825CFDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x25CFDD0", Offset = "0x25CEDD0", VA = "0x1825CFDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x25CFE30", Offset = "0x25CEE30", VA = "0x1825CFE30")]
	protected EJCGEIHPNLC(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x25CFD70", Offset = "0x25CED70", VA = "0x1825CFD70")]
	protected void IDHLPDPOOPA(string JBEDKPGLDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x25CFD90", Offset = "0x25CED90", VA = "0x1825CFD90")]
	public void IDHLPDPOOPA(Func<string> HGIBMPFFGIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct KCNPCMHNLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public Dictionary<Guid, List<PEDMBIGFGLD>> NPAAICPJPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public Dictionary<Guid, List<PEDMBIGFGLD>> JLKILODFPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public Dictionary<Guid, List<PEDMBIGFGLD>> GLPHKAIBMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public List<Guid> JKANKFLOGOF;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2415A50", Offset = "0x2414A50", VA = "0x182415A50")]
	public static KCNPCMHNLDE FGPHONIFMEK(DDHLPGJACDN BILODKHEIGN, KIEBILFOMFH NHJGKPKLDHM, LJDIAMGONCO BPHHJPGAPKI)
	{
		return default(KCNPCMHNLDE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal struct DJEAMIIDNGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0")]
	public static DJEAMIIDNGJ FBMLCAAKPML()
	{
		return default(DJEAMIIDNGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void IOEHNKHDGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void ALLLDLADPAJ(LJDIAMGONCO JEJGBICCBLN, object EFEJHDCOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void OJIOKNEFCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal struct MCOECFIFMLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public readonly NCMHNNOIOOH AHLHJEPOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public readonly PGBMNMFNBLN JJGFMBLNFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly ECMIALJFMDG CNIFFDPABKP;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x241B110", Offset = "0x241A110", VA = "0x18241B110")]
	public MCOECFIFMLF(NCMHNNOIOOH AHLHJEPOCEB, PGBMNMFNBLN JJGFMBLNFCB, ECMIALJFMDG CNIFFDPABKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal struct GNMECGFLILE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly JKKMCLEIKNA GAGLCIMNBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly Guid AJGFNANMPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private bool HKGHLMIMEBN;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x249F500", Offset = "0x249E500", VA = "0x18249F500")]
	public static GNMECGFLILE MLPGMFLDCOE(JKKMCLEIKNA GAGLCIMNBBB)
	{
		return default(GNMECGFLILE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x101CC40", Offset = "0x101BC40", VA = "0x18101CC40")]
	public void JPCDJDBNGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x249F3F0", Offset = "0x249E3F0", VA = "0x18249F3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x249F560", Offset = "0x249E560", VA = "0x18249F560")]
	private GNMECGFLILE(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x249F3F0", Offset = "0x249E3F0", VA = "0x18249F3F0")]
	private void DJMEOJLHNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x249F450", Offset = "0x249E450", VA = "0x18249F450")]
	private Func<Guid, bool> IKKLAMEOALF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class IHBJJKLCMDK : EJCGEIHPNLC, EPDNPFNIAMK
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public delegate Task<KIEBILFOMFH> ECNDPDCCEFK(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE ICBJONALAFC, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct CCBOGNKKFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public KPHIGKDHNKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private GNMECGFLILE <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x24982B0", Offset = "0x24972B0", VA = "0x1824982B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct HBIPFLGCAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public KPHIGKDHNKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private MLACCLOKFHB <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x24A1570", Offset = "0x24A0570", VA = "0x1824A1570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x24A1820", Offset = "0x24A0820", VA = "0x1824A1820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct ELAOONECNFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public KPHIGKDHNKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private MLACCLOKFHB <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x249B690", Offset = "0x249A690", VA = "0x18249B690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class OKMGBCHCLKB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public AsyncTaskMethodBuilder<MCOECFIFMLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public OKMGBCHCLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private MCOECFIFMLF <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter<KIEBILFOMFH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			private TaskAwaiter<MCOECFIFMLF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x24AAEA0", Offset = "0x24A9EA0", VA = "0x1824AAEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x24AB690", Offset = "0x24AA690", VA = "0x1824AB690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public AsyncTaskMethodBuilder<LJDIAMGONCO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public OKMGBCHCLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			private LJDIAMGONCO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			private TaskAwaiter<KIEBILFOMFH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			private TaskAwaiter<LJDIAMGONCO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x24AB6E0", Offset = "0x24AA6E0", VA = "0x1824AB6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x24ABB80", Offset = "0x24AAB80", VA = "0x1824ABB80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public OKMGBCHCLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private TaskAwaiter<KIEBILFOMFH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			private OMBFGEHJBPE <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x24ABBD0", Offset = "0x24AABD0", VA = "0x1824ABBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public KPHIGKDHNKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public PBJPIDBLDLH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public PBJPIDBLDLH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public MCOECFIFMLF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public PBJPIDBLDLH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public LJDIAMGONCO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public NOCMKCPFMHI.CKCHJCOFJKO <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OKMGBCHCLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x24AA4F0", Offset = "0x24A94F0", VA = "0x1824AA4F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task<MCOECFIFMLF> <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x24AA610", Offset = "0x24A9610", VA = "0x1824AA610")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<LJDIAMGONCO> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x24AA860", Offset = "0x24A9860", VA = "0x1824AA860")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x24AA740", Offset = "0x24A9740", VA = "0x1824AA740")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct KDKPEPNHIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public KPHIGKDHNKJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private OKMGBCHCLKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<MCOECFIFMLF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private TaskAwaiter<LJDIAMGONCO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x24A7500", Offset = "0x24A6500", VA = "0x1824A7500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct EBIKKOPIBGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x249A280", Offset = "0x2499280", VA = "0x18249A280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct ICLPKLBLPAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private MLACCLOKFHB <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x24A2B80", Offset = "0x24A1B80", VA = "0x1824A2B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct IGMHIBMDGLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private MLACCLOKFHB <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private GJFPJPMMCFD.JMPIDPAFEBG <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<GJFPJPMMCFD.JMPIDPAFEBG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x24A3CE0", Offset = "0x24A2CE0", VA = "0x1824A3CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x24A4900", Offset = "0x24A3900", VA = "0x1824A4900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct CJHMMELGNMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public OMBFGEHJBPE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private MLACCLOKFHB <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2498BF0", Offset = "0x2497BF0", VA = "0x182498BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x24997C0", Offset = "0x24987C0", VA = "0x1824997C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct IJDGAHPJEPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public KIEBILFOMFH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public LJDIAMGONCO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x24A62F0", Offset = "0x24A52F0", VA = "0x1824A62F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x24A64D0", Offset = "0x24A54D0", VA = "0x1824A64D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class FPICJCLOFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public ECNDPDCCEFK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public OMBFGEHJBPE timedYielder;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FPICJCLOFJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class APAHCJPJDLF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public APAHCJPJDLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			private TaskAwaiter<KIEBILFOMFH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x24ACAD0", Offset = "0x24ABAD0", VA = "0x1824ACAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x24ACFB0", Offset = "0x24ABFB0", VA = "0x1824ACFB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public KIEBILFOMFH originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public FPICJCLOFJE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public APAHCJPJDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2495CC0", Offset = "0x2494CC0", VA = "0x182495CC0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<KIEBILFOMFH> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct LDGNIDMLFIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public ECNDPDCCEFK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public OMBFGEHJBPE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x24A8BF0", Offset = "0x24A7BF0", VA = "0x1824A8BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x24A9010", Offset = "0x24A8010", VA = "0x1824A9010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct MDAPFOBPBKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public PBJPIDBLDLH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private KIEBILFOMFH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private IEnumerator<KIEBILFOMFH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x24A96C0", Offset = "0x24A86C0", VA = "0x1824A96C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct HICPAOJJNBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x24A1E10", Offset = "0x24A0E10", VA = "0x1824A1E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct FNODEJJNLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public AsyncTaskMethodBuilder<GJFPJPMMCFD.JMPIDPAFEBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public IHBJJKLCMDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter<GJFPJPMMCFD.JMPIDPAFEBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x249B9D0", Offset = "0x249A9D0", VA = "0x18249B9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x249BBE0", Offset = "0x249ABE0", VA = "0x18249BBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class JCKGHCBOLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public NCMHNNOIOOH roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JCKGHCBOLMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x24A6DF0", Offset = "0x24A5DF0", VA = "0x1824A6DF0")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly JNGMFIANMOG KDOCEFCHBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly JNGMFIANMOG CKEMDEKIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly MIGAHPHAEFH IHLDCCBLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private readonly HAIFOKIHEGI JHHFKCEOBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly CDMGNIBDIEG NOBNABIAIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly DPAOFPLLJNG HDENBPODNNK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public float IPFNAIGCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x24A50C0", Offset = "0x24A40C0", VA = "0x1824A50C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private MLNEICIMMPF CKIFPONFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x24A5A00", Offset = "0x24A4A00", VA = "0x1824A5A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MDJDGEJJGLJ NAJMPEHFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x24A5A30", Offset = "0x24A4A30", VA = "0x1824A5A30", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x24A5080", Offset = "0x24A4080", VA = "0x1824A5080", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x24A60C0", Offset = "0x24A50C0", VA = "0x1824A60C0")]
	public IHBJJKLCMDK(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x24A5370", Offset = "0x24A4370", VA = "0x1824A5370")]
	[AsyncStateMachine(typeof(CCBOGNKKFGO))]
	public Task JIKOOIAPJBM(KPHIGKDHNKJ PDHKNAGOONJ, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x24A5D30", Offset = "0x24A4D30", VA = "0x1824A5D30")]
	[AsyncStateMachine(typeof(HBIPFLGCAIE))]
	private Task<ILPEFNEFIAF> NHAILKOMCIJ(KPHIGKDHNKJ PDHKNAGOONJ, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x24A5BC0", Offset = "0x24A4BC0", VA = "0x1824A5BC0")]
	[AsyncStateMachine(typeof(ELAOONECNFH))]
	private Task MPGHNEALPDD(KPHIGKDHNKJ PDHKNAGOONJ, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x24A4DE0", Offset = "0x24A3DE0", VA = "0x1824A4DE0")]
	[AsyncStateMachine(typeof(KDKPEPNHIBB))]
	private Task GCLKNJEPEFB(KPHIGKDHNKJ PDHKNAGOONJ, MLACCLOKFHB HDALINEEMFB, CancellationToken GEPJKAGLAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x24A4C50", Offset = "0x24A3C50", VA = "0x1824A4C50")]
	[AsyncStateMachine(typeof(EBIKKOPIBGM))]
	private Task ECHIAEPABFC(MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x24A50E0", Offset = "0x24A40E0", VA = "0x1824A50E0")]
	[AsyncStateMachine(typeof(ICLPKLBLPAP))]
	private Task IGGBGIFEJFJ(LJDIAMGONCO JEJGBICCBLN, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x24A4F20", Offset = "0x24A3F20", VA = "0x1824A4F20")]
	[AsyncStateMachine(typeof(IGMHIBMDGLD))]
	private Task<KIEBILFOMFH> GLKADJOEONC(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x24A5A50", Offset = "0x24A4A50", VA = "0x1824A5A50")]
	[AsyncStateMachine(typeof(CJHMMELGNMD))]
	private Task<KIEBILFOMFH> MNPNMEFGEKO(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x24A4AE0", Offset = "0x24A3AE0", VA = "0x1824A4AE0")]
	[AsyncStateMachine(typeof(IJDGAHPJEPO))]
	private Task<KIEBILFOMFH> BIJBDNEHFBN(KIEBILFOMFH NHJGKPKLDHM, LJDIAMGONCO BPHHJPGAPKI, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO, bool IDPFLJNINMB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x24A5640", Offset = "0x24A4640", VA = "0x1824A5640")]
	private bool LMNAGGNFFOI(LJDIAMGONCO ENHGJNCKGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x24A4950", Offset = "0x24A3950", VA = "0x1824A4950")]
	[AsyncStateMachine(typeof(LDGNIDMLFIH))]
	protected Task<KIEBILFOMFH> BEHJGEEKHNO(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO, ECNDPDCCEFK BJFNPEGEAIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x24A54D0", Offset = "0x24A44D0", VA = "0x1824A54D0")]
	[AsyncStateMachine(typeof(MDAPFOBPBKJ))]
	private Task KJOLMLILFMI(LJDIAMGONCO JEJGBICCBLN, PBJPIDBLDLH MFBDCMAOLPA, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x24A5EF0", Offset = "0x24A4EF0", VA = "0x1824A5EF0")]
	private void PDGBNAHLNIA(KIEBILFOMFH BIHDJIJBHIE, PBJPIDBLDLH MFBDCMAOLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x24A5EB0", Offset = "0x24A4EB0", VA = "0x1824A5EB0")]
	private void ONNKDLFCMPA(KIEBILFOMFH KDPDJMCHIMB, out KIEBILFOMFH IFKNCBHHCFE, out KIEBILFOMFH IHCNOAHGFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x24A5880", Offset = "0x24A4880", VA = "0x1824A5880")]
	private Task<MCOECFIFMLF> MEEOLCJGAOC(KPHIGKDHNKJ PDHKNAGOONJ, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x24A5F40", Offset = "0x24A4F40", VA = "0x1824A5F40")]
	private Task<LJDIAMGONCO> PILFMOKKFCF(KPHIGKDHNKJ PDHKNAGOONJ, MCOECFIFMLF JEJGBICCBLN, NOCMKCPFMHI.CKCHJCOFJKO DPNFKDPMLLG, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x24A5730", Offset = "0x24A4730", VA = "0x1824A5730")]
	[AsyncStateMachine(typeof(HICPAOJJNBP))]
	private Task MCOMHNMOOIH(LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x24A5F90", Offset = "0x24A4F90", VA = "0x1824A5F90")]
	[AsyncStateMachine(typeof(FNODEJJNLJC))]
	private Task<GJFPJPMMCFD.JMPIDPAFEBG> POKHBBGFAKM(LJDIAMGONCO JEJGBICCBLN, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x24A4D80", Offset = "0x24A3D80", VA = "0x1824A4D80")]
	private Task FACFGOLJGDB(LJDIAMGONCO JEJGBICCBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x24A5E90", Offset = "0x24A4E90", VA = "0x1824A5E90")]
	private Task OHJBGIPLMCP(LJDIAMGONCO JEJGBICCBLN, GJFPJPMMCFD.JMPIDPAFEBG BJDHDPKKBEL, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x24A58C0", Offset = "0x24A48C0", VA = "0x1824A58C0")]
	private Task MEPOHJBLPIC(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x24A54B0", Offset = "0x24A44B0", VA = "0x1824A54B0")]
	private Task KAPKEDDEEAI(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x24A5630", Offset = "0x24A4630", VA = "0x1824A5630")]
	private static Task LHALCDPNGBF(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x24A5D10", Offset = "0x24A4D10", VA = "0x1824A5D10")]
	private Task NBHLKKJGBDD(LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x24A50A0", Offset = "0x24A40A0", VA = "0x1824A50A0")]
	private Task HLIAAAPAAEH(LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x24A4DB0", Offset = "0x24A3DB0", VA = "0x1824A4DB0")]
	private void GBNFHIKKMIM(KPHIGKDHNKJ PDHKNAGOONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x24A5240", Offset = "0x24A4240", VA = "0x1824A5240")]
	private static void JHMJIFCPHND(NCMHNNOIOOH AHLHJEPOCEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal struct GJFPJPMMCFD
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public struct JMPIDPAFEBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public readonly Dictionary<int, int> CEMJIEAMMNE;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
		public JMPIDPAFEBG(Dictionary<int, int> CEMJIEAMMNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private KIEBILFOMFH BIHDJIJBHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private LJDIAMGONCO JEJGBICCBLN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x249DF90", Offset = "0x249CF90", VA = "0x18249DF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x249DFE0", Offset = "0x249CFE0", VA = "0x18249DFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x249DEE0", Offset = "0x249CEE0", VA = "0x18249DEE0")]
	public static Task<JMPIDPAFEBG> AEOMJAPKJGO(MLNEICIMMPF JHHEABBOJHF, KIEBILFOMFH BIHDJIJBHIE, LJDIAMGONCO JEJGBICCBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x249DC40", Offset = "0x249CC40", VA = "0x18249DC40")]
	private JMPIDPAFEBG AEOMJAPKJGO()
	{
		return default(JMPIDPAFEBG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct CBNNODIDBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x25CB200", Offset = "0x25CA200", VA = "0x1825CB200")]
	public static Task AEOMJAPKJGO(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct CNIGPMNIHPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct CGJGFHGANIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private MLACCLOKFHB <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x25CBA00", Offset = "0x25CAA00", VA = "0x1825CBA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x25CC400", Offset = "0x25CB400", VA = "0x1825CC400")]
	[AsyncStateMachine(typeof(CGJGFHGANIE))]
	public static Task AEOMJAPKJGO(JKKMCLEIKNA GAGLCIMNBBB, LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal struct OCEADFBANGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct HPAOEFGGPPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public OMBFGEHJBPE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private KIEBILFOMFH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private MLNEICIMMPF <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private DDHLPGJACDN <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private List<(PersistenceView, FIBICDDGGPE)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private FIBICDDGGPE <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x486CA40", Offset = "0x486BA40", VA = "0x18486CA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x486E690", Offset = "0x486D690", VA = "0x18486E690")]
	[AsyncStateMachine(typeof(HPAOEFGGPPL))]
	public static Task AEOMJAPKJGO(JKKMCLEIKNA GAGLCIMNBBB, LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x486E800", Offset = "0x486D800", VA = "0x18486E800")]
	private static void CFAJNGHJDFH(PersistenceView NHKKBKKOJJM, FIBICDDGGPE EFEJHDCOLHM, LJDIAMGONCO JEJGBICCBLN, KIEBILFOMFH NHJGKPKLDHM, bool IJJOICLCJJH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct GLDBNHBCGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x249E060", Offset = "0x249D060", VA = "0x18249E060")]
	public static Task AEOMJAPKJGO(MLNEICIMMPF JHHEABBOJHF, LJDIAMGONCO JEJGBICCBLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal struct MKIJFKADNGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct CJKADMBCHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public MLNEICIMMPF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public KIEBILFOMFH roomOperationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x240A360", Offset = "0x2409360", VA = "0x18240A360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct CMBBNKHHBLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public MKIJFKADNGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x240A680", Offset = "0x2409680", VA = "0x18240A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class MAJLCOAHNIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public MAJIONMLDGH version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public MAJLCOAHNIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2419FE0", Offset = "0x2418FE0", VA = "0x182419FE0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x241A090", Offset = "0x2419090", VA = "0x18241A090")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private KIEBILFOMFH BIHDJIJBHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private LJDIAMGONCO JEJGBICCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private JKKMCLEIKNA GAGLCIMNBBB;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private static readonly ByteString DDCMJIIDILE;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x241C120", Offset = "0x241B120", VA = "0x18241C120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private DMHCGJJHBOG MBINKGDKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x241C170", Offset = "0x241B170", VA = "0x18241C170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x241BE40", Offset = "0x241AE40", VA = "0x18241BE40")]
	[AsyncStateMachine(typeof(CJKADMBCHLD))]
	public static Task AEOMJAPKJGO(MLNEICIMMPF JHHEABBOJHF, KIEBILFOMFH BIHDJIJBHIE, LJDIAMGONCO JEJGBICCBLN, JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x241BFA0", Offset = "0x241AFA0", VA = "0x18241BFA0")]
	[AsyncStateMachine(typeof(CMBBNKHHBLO))]
	private Task AEOMJAPKJGO(MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x241C1F0", Offset = "0x241B1F0", VA = "0x18241C1F0")]
	private void NHGIEAADBBC([NotNull] FDBKGNMGHFG CAFKBNEPNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x241C0F0", Offset = "0x241B0F0", VA = "0x18241C0F0")]
	private bool DHCEJJPBKCB(MAJIONMLDGH GDLEDDNCPGJ, FDBKGNMGHFG CAFKBNEPNOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct OIGNDCPOHHI
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private struct LBEJNDOPDBD<Arg, Parsed> where Parsed : IMessage<Parsed>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private readonly global::PAHPPLAGAKI<Arg> CDHEBKCDEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private readonly global::IGCHNPLACIG<Parsed> NCGEJDBGGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private readonly global::LNNGMAFLDAK<Parsed> KAKHONCGIOH;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x60A540", Offset = "0x609540", VA = "0x18060A540")]
		public LBEJNDOPDBD(global::PAHPPLAGAKI<Arg> CDHEBKCDEFN, global::IGCHNPLACIG<Parsed> NCGEJDBGGAB, global::LNNGMAFLDAK<Parsed> KAKHONCGIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x26CA7F0", Offset = "0x26C97F0", VA = "0x1826CA7F0")]
		[AsyncStateMachine(typeof(KOICHFLHCFK))]
		public Task<Parsed> MPKKAEDGIMH(Arg JHMMPAIEPKF, string INPIDCACCIG, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x26C9DD0", Offset = "0x26C8DD0", VA = "0x1826C9DD0")]
		[AsyncStateMachine(typeof(OGNBPHGLIBH))]
		private Task<byte[]> DCNJPDIEOGC(Arg JHMMPAIEPKF, CancellationToken JNDOKGNDNMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x26CA190", Offset = "0x26C9190", VA = "0x1826CA190")]
		private Parsed GOCEPGNGHCC(byte[] CECLCMIOBDM)
		{
			return (Parsed)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct FPBNJPIMAHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder<LJDIAMGONCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public OIGNDCPOHHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public NOCMKCPFMHI.CKCHJCOFJKO downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private MLACCLOKFHB <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private TaskAwaiter<(ABIOOPODBAJ, FDBKGNMGHFG, APBKLCEDLJC, NBJMJICHLFO)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x486BE50", Offset = "0x486AE50", VA = "0x18486BE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x486C560", Offset = "0x486B560", VA = "0x18486C560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct FBEOKHGKNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public AsyncTaskMethodBuilder<ABIOOPODBAJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public MLACCLOKFHB downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public OIGNDCPOHHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public NOCMKCPFMHI.CKCHJCOFJKO downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private MLACCLOKFHB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter<ABIOOPODBAJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x486B940", Offset = "0x486A940", VA = "0x18486B940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x486BD80", Offset = "0x486AD80", VA = "0x18486BD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private EDLFNNMNIKE IMLLEACFBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private LBEJNDOPDBD<CONELIFOGEN, FDBKGNMGHFG> JJGFMBLNFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private LBEJNDOPDBD<CONELIFOGEN, APBKLCEDLJC> HIECONFGNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private LBEJNDOPDBD<long, NBJMJICHLFO> GMALKLICDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private KPHIGKDHNKJ PDHKNAGOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private NCMHNNOIOOH AHLHJEPOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private PGBMNMFNBLN GPGDOOOPEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private long LNDOIEFBHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private MLACCLOKFHB BCAFPIOPGIA;

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x486EA70", Offset = "0x486DA70", VA = "0x18486EA70")]
	public static Task<LJDIAMGONCO> AAPPABBGIOK(MLNEICIMMPF JHHEABBOJHF, KPHIGKDHNKJ PDHKNAGOONJ, in MCOECFIFMLF JEJGBICCBLN, NOCMKCPFMHI.CKCHJCOFJKO DPNFKDPMLLG, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x486EFB0", Offset = "0x486DFB0", VA = "0x18486EFB0")]
	[AsyncStateMachine(typeof(FPBNJPIMAHN))]
	private Task<LJDIAMGONCO> AEOMJAPKJGO(NOCMKCPFMHI.CKCHJCOFJKO DPNFKDPMLLG, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x486F150", Offset = "0x486E150", VA = "0x18486F150")]
	private CONELIFOGEN BFHBCOPOEIO(CAIIELGNCNK NCBLBABBJFN)
	{
		return default(CONELIFOGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x486F190", Offset = "0x486E190", VA = "0x18486F190")]
	[AsyncStateMachine(typeof(FBEOKHGKNBC))]
	private Task<ABIOOPODBAJ> CKLEMAEAHMI(string FJBIEPGMBAJ, long LNDOIEFBHBK, NOCMKCPFMHI.CKCHJCOFJKO DPNFKDPMLLG, MLACCLOKFHB CLEKMAEFGKH, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal struct PDIHNBPINLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct CEHFKLGPDGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder<MCOECFIFMLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public PDIHNBPINLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private MLACCLOKFHB <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<MCOECFIFMLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x486A7F0", Offset = "0x48697F0", VA = "0x18486A7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x486ABC0", Offset = "0x4869BC0", VA = "0x18486ABC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct DBBEMLFMDKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder<MCOECFIFMLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public PDIHNBPINLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<MCOECFIFMLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x486AC10", Offset = "0x4869C10", VA = "0x18486AC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x486AF00", Offset = "0x4869F00", VA = "0x18486AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class LIJIGBLEKCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LIJIGBLEKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1035F10", Offset = "0x1034F10", VA = "0x181035F10")]
		internal bool <FetchRoomDetails>b__0(PGBMNMFNBLN sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct GNMABKFJIHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder<MCOECFIFMLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public DDHLPGJACDN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private LIJIGBLEKCP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private TaskAwaiter<NCMHNNOIOOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x486C5B0", Offset = "0x486B5B0", VA = "0x18486C5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x486C9F0", Offset = "0x486B9F0", VA = "0x18486C9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private MIGAHPHAEFH IHLDCCBLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private MLACCLOKFHB BCAFPIOPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private long PBLGEAPLLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private long MPOPHDGDFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private string NEBKNDIAMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private CONELIFOGEN GLFAMKHBDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private CONELIFOGEN EKLBBJABHGK;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4870660", Offset = "0x486F660", VA = "0x184870660")]
	public static Task<MCOECFIFMLF> AAPPABBGIOK(MLNEICIMMPF JHHEABBOJHF, KPHIGKDHNKJ PDHKNAGOONJ, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x4870850", Offset = "0x486F850", VA = "0x184870850")]
	[AsyncStateMachine(typeof(CEHFKLGPDGF))]
	private Task<MCOECFIFMLF> AEOMJAPKJGO(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4870DE0", Offset = "0x486FDE0", VA = "0x184870DE0")]
	[AsyncStateMachine(typeof(DBBEMLFMDKP))]
	private Task<MCOECFIFMLF> MEEOLCJGAOC(long PBLGEAPLLBL, long MPOPHDGDFPN, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO, bool CAKOKPIFLOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x4870C90", Offset = "0x486FC90", VA = "0x184870C90")]
	[AsyncStateMachine(typeof(GNMABKFJIHN))]
	public static Task<MCOECFIFMLF> MEEOLCJGAOC(DDHLPGJACDN BILODKHEIGN, long PBLGEAPLLBL, long MPOPHDGDFPN, CancellationToken JNDOKGNDNMO, MLACCLOKFHB HDALINEEMFB, bool CAKOKPIFLOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x4870B00", Offset = "0x486FB00", VA = "0x184870B00")]
	private void INJOIEJMJJP(NCMHNNOIOOH AHLHJEPOCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4870990", Offset = "0x486F990", VA = "0x184870990")]
	private bool HMOJDELABOI(MCOECFIFMLF JEJGBICCBLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4870B30", Offset = "0x486FB30", VA = "0x184870B30")]
	private void LPGDFENLIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct JCGOFNCFMCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct MILOIMJBNDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public JCGOFNCFMCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x241BAB0", Offset = "0x241AAB0", VA = "0x18241BAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private const int CPFBKMIJIKL = 20;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private const float MDKGOOIKCFI = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private DDHLPGJACDN BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private LJDIAMGONCO JEJGBICCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private MLACCLOKFHB BCAFPIOPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private float BGFLEHMLJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private float IAHJPNLKKCN;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2411AB0", Offset = "0x2410AB0", VA = "0x182411AB0")]
	public static Task BEEFNHCNBCG(MLNEICIMMPF JHHEABBOJHF, LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2411990", Offset = "0x2410990", VA = "0x182411990")]
	[AsyncStateMachine(typeof(MILOIMJBNDH))]
	public Task AEOMJAPKJGO(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2411EC0", Offset = "0x2410EC0", VA = "0x182411EC0")]
	private static void MFHNLEOCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2411D40", Offset = "0x2410D40", VA = "0x182411D40")]
	private void IFFBPPGLBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2411C60", Offset = "0x2410C60", VA = "0x182411C60")]
	private static float FLDCHCBKCGN(DDHLPGJACDN BILODKHEIGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2411D20", Offset = "0x2410D20", VA = "0x182411D20")]
	private static float IFAOBDONIOI()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct KMBCJBLNJIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct KHMFPOBFLPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public JKKMCLEIKNA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GJFPJPMMCFD.JMPIDPAFEBG mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private NHNDDFDJKOJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private MLNEICIMMPF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private OJMOILLNOBK.JAKJFFFMHJN <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x24161C0", Offset = "0x24151C0", VA = "0x1824161C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct BAHOPHFBIDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private MOKCCBBOACE.MDFIOKELNOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x2408CD0", Offset = "0x2407CD0", VA = "0x182408CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2416930", Offset = "0x2415930", VA = "0x182416930")]
	[AsyncStateMachine(typeof(KHMFPOBFLPK))]
	public static Task AEOMJAPKJGO(JKKMCLEIKNA GAGLCIMNBBB, LJDIAMGONCO JEJGBICCBLN, GJFPJPMMCFD.JMPIDPAFEBG BJDHDPKKBEL, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2416B70", Offset = "0x2415B70", VA = "0x182416B70")]
	private static Task<ILPEFNEFIAF> KIKIBIOKBOC(JKKMCLEIKNA GAGLCIMNBBB, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2416A90", Offset = "0x2415A90", VA = "0x182416A90")]
	[AsyncStateMachine(typeof(BAHOPHFBIDN))]
	private static Task BFKDDIFHFOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct PADLNIFHDBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct AANLJLOPACH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public PADLNIFHDBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x486A3E0", Offset = "0x48693E0", VA = "0x18486A3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class OBIOJGEGNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OBIOJGEGNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x486E620", Offset = "0x486D620", VA = "0x18486E620")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KLKABOAHAJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public PADLNIFHDBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private DHNCDPHJPAM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x486D670", Offset = "0x486C670", VA = "0x18486D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private bool AAIKAGGMKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private MLACCLOKFHB BCAFPIOPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private CancellationToken JNDOKGNDNMO;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x48705E0", Offset = "0x486F5E0", VA = "0x1848705E0")]
	public static Task KALMAIDDCCE(MLNEICIMMPF JHHEABBOJHF, bool AAIKAGGMKDC, MLACCLOKFHB BCAFPIOPGIA, CancellationToken GPDBAMKAMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x48703B0", Offset = "0x486F3B0", VA = "0x1848703B0")]
	[AsyncStateMachine(typeof(AANLJLOPACH))]
	private Task AEOMJAPKJGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x48704B0", Offset = "0x486F4B0", VA = "0x1848704B0")]
	[AsyncStateMachine(typeof(KLKABOAHAJO))]
	private Task EIIMALBGPCO(bool BOKKDBPPLDH, string IGMKHADPKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0")]
	private bool PCAPNHIEPFF(bool AAIKAGGMKDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct IFPPJPCBOPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct MICNKBNPGPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public IFPPJPCBOPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x24A9A80", Offset = "0x24A8A80", VA = "0x1824A9A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x24A9D20", Offset = "0x24A8D20", VA = "0x1824A9D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class OEOJACBFHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OEOJACBFHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x24AA3F0", Offset = "0x24A93F0", VA = "0x1824AA3F0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct DBLDCJMPFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public IFPPJPCBOPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private DHNCDPHJPAM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2499DA0", Offset = "0x2498DA0", VA = "0x182499DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x249A230", Offset = "0x2499230", VA = "0x18249A230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private ECMIALJFMDG PGNNLANDEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private MLACCLOKFHB BCAFPIOPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x24A3B60", Offset = "0x24A2B60", VA = "0x1824A3B60")]
	public static Task<Scene> CJNDPGLJNBI(MLNEICIMMPF JHHEABBOJHF, ECMIALJFMDG HAOLGHJHJFJ, MLACCLOKFHB BCAFPIOPGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x24A3A40", Offset = "0x24A2A40", VA = "0x1824A3A40")]
	[AsyncStateMachine(typeof(MICNKBNPGPL))]
	private Task<Scene> AEOMJAPKJGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x24A3BB0", Offset = "0x24A2BB0", VA = "0x1824A3BB0")]
	[AsyncStateMachine(typeof(DBLDCJMPFHO))]
	private Task<Scene> EIIMALBGPCO(string IGMKHADPKBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct CDMGNIBDIEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct FGFOIBIDGNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CDMGNIBDIEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public KIEBILFOMFH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public LJDIAMGONCO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private MLACCLOKFHB <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private TaskAwaiter<KIEBILFOMFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x25D0D50", Offset = "0x25CFD50", VA = "0x1825D0D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x25D1300", Offset = "0x25D0300", VA = "0x1825D1300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HPMFJBOIKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder<KIEBILFOMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CDMGNIBDIEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public KIEBILFOMFH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x25D5130", Offset = "0x25D4130", VA = "0x1825D5130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x25D5350", Offset = "0x25D4350", VA = "0x1825D5350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private readonly JKKMCLEIKNA GAGLCIMNBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private readonly MIGAHPHAEFH IHLDCCBLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private readonly HAIFOKIHEGI JHHFKCEOBOD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private NHNDDFDJKOJ EPDMLBONCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA26CE0", Offset = "0xA25CE0", VA = "0x180A26CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x25CB9A0", Offset = "0x25CA9A0", VA = "0x1825CB9A0")]
	public CDMGNIBDIEG(JKKMCLEIKNA GAGLCIMNBBB, MIGAHPHAEFH IHLDCCBLBJB, HAIFOKIHEGI JHHFKCEOBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x25CB810", Offset = "0x25CA810", VA = "0x1825CB810")]
	[AsyncStateMachine(typeof(FGFOIBIDGNE))]
	public Task<KIEBILFOMFH> GFKNLPJNNJP(KIEBILFOMFH CNNPNJANJGE, LJDIAMGONCO BPHHJPGAPKI, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO, bool IDPFLJNINMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x25CB6C0", Offset = "0x25CA6C0", VA = "0x1825CB6C0")]
	[AsyncStateMachine(typeof(HPMFJBOIKEA))]
	private Task<KIEBILFOMFH> COMOFKNEAEL(MLACCLOKFHB HDALINEEMFB, KIEBILFOMFH LKOJKOJNBBK, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x25CB690", Offset = "0x25CA690", VA = "0x1825CB690")]
	private bool BKBEFHAJFEN(KIEBILFOMFH BEBHAEDOJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x25CB980", Offset = "0x25CA980", VA = "0x1825CB980")]
	private void IDHLPDPOOPA(string PLNPNPKDGBA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal struct JDBGBBIODNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct MBMAJEBJCEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public NHNDDFDJKOJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public OMBFGEHJBPE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private List<(PersistenceView, FIBICDDGGPE)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private (PersistenceView, FIBICDDGGPE) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x241AAE0", Offset = "0x2419AE0", VA = "0x18241AAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2412030", Offset = "0x2411030", VA = "0x182412030")]
	[AsyncStateMachine(typeof(MBMAJEBJCEO))]
	public static Task AEOMJAPKJGO(NHNDDFDJKOJ OLGIOFDHJLO, LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct FPGBLFGMAOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct ICENHELCJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public NHNDDFDJKOJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public OMBFGEHJBPE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private MAJIONMLDGH <version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private List<(PersistenceView, FIBICDDGGPE)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private FIBICDDGGPE <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x24A2560", Offset = "0x24A1560", VA = "0x1824A2560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x249BC30", Offset = "0x249AC30", VA = "0x18249BC30")]
	[AsyncStateMachine(typeof(ICENHELCJAH))]
	public static Task AEOMJAPKJGO(NHNDDFDJKOJ OLGIOFDHJLO, LJDIAMGONCO JEJGBICCBLN, OMBFGEHJBPE HJAFDBNOIKO, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct OJMOILLNOBK
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public struct JAKJFFFMHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public List<CEGOGGDAACF> CBFHNKHNPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public List<FIBICDDGGPE> BLICAABCNIM;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x60A7B0", Offset = "0x6097B0", VA = "0x18060A7B0")]
		public JAKJFFFMHJN(List<CEGOGGDAACF> CBFHNKHNPKO, List<FIBICDDGGPE> BLICAABCNIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class NDEMOBMPHJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public List<CEGOGGDAACF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NDEMOBMPHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x486E2B0", Offset = "0x486D2B0", VA = "0x18486E2B0")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private MLNEICIMMPF JHHEABBOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private LJDIAMGONCO JEJGBICCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private GJFPJPMMCFD.JMPIDPAFEBG BJDHDPKKBEL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private DDHLPGJACDN FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x486F620", Offset = "0x486E620", VA = "0x18486F620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x486F350", Offset = "0x486E350", VA = "0x18486F350")]
	public static JAKJFFFMHJN AEOMJAPKJGO(MLNEICIMMPF JHHEABBOJHF, LJDIAMGONCO JEJGBICCBLN, GJFPJPMMCFD.JMPIDPAFEBG BJDHDPKKBEL)
	{
		return default(JAKJFFFMHJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x486F3E0", Offset = "0x486E3E0", VA = "0x18486F3E0")]
	private JAKJFFFMHJN AEOMJAPKJGO()
	{
		return default(JAKJFFFMHJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x486F670", Offset = "0x486E670", VA = "0x18486F670")]
	private JAKJFFFMHJN LDDBKHINDPK(FDBKGNMGHFG CAFKBNEPNOP, MAJIONMLDGH OOLFNNIOIOK, Dictionary<int, int> POKLONJGAGG)
	{
		return default(JAKJFFFMHJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x486FB20", Offset = "0x486EB20", VA = "0x18486FB20")]
	private GameObject[] OPAABLFCGGI(List<CEGOGGDAACF> CBFHNKHNPKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct KOOFAAJMHJN
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class JDGDOGECOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public OJMOILLNOBK.JAKJFFFMHJN instantiations;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JDGDOGECOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x2412180", Offset = "0x2411180", VA = "0x182412180")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class DGJKNMPNCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public DGJKNMPNCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x240B3F0", Offset = "0x240A3F0", VA = "0x18240B3F0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2417330", Offset = "0x2416330", VA = "0x182417330")]
	public static void AEOMJAPKJGO(NHNDDFDJKOJ OLGIOFDHJLO, LJDIAMGONCO JEJGBICCBLN, OJMOILLNOBK.JAKJFFFMHJN DDIMJFIKINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class HAIFOKIHEGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct CAKJLEJDENC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public KIEBILFOMFH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public LJDIAMGONCO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x2497BB0", Offset = "0x2496BB0", VA = "0x182497BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class EGCNJCGHMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EGCNJCGHMFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class LLMPCGGLMJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public LLMPCGGLMJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x24AD000", Offset = "0x24AC000", VA = "0x1824AD000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public MLACCLOKFHB handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public EGCNJCGHMFL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LLMPCGGLMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x24A9060", Offset = "0x24A8060", VA = "0x1824A9060")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct HNLKPILLNBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private LLMPCGGLMJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x24A2070", Offset = "0x24A1070", VA = "0x1824A2070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct EFIFHPMPNAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private Dictionary<Guid, List<PEDMBIGFGLD>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x249AE50", Offset = "0x2499E50", VA = "0x18249AE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct KBAKEJBGDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private MLACCLOKFHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private Dictionary<Guid, List<PEDMBIGFGLD>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x24A7060", Offset = "0x24A6060", VA = "0x1824A7060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class IKAIANJPABA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public PEDMBIGFGLD handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public IKAIANJPABA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x24AAD50", Offset = "0x24A9D50", VA = "0x1824AAD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public EFKFHBDMADD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public List<PEDMBIGFGLD> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IKAIANJPABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x24A6520", Offset = "0x24A5520", VA = "0x1824A6520")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x24A66A0", Offset = "0x24A56A0", VA = "0x1824A66A0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(PEDMBIGFGLD handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x24A65E0", Offset = "0x24A55E0", VA = "0x1824A65E0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct BNPMDLPAGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public EFKFHBDMADD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public List<PEDMBIGFGLD> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private IKAIANJPABA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x2496350", Offset = "0x2495350", VA = "0x182496350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct GFGOBLPDJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public MLACCLOKFHB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x249CDF0", Offset = "0x249BDF0", VA = "0x18249CDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class BCKDPLENDMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public BCKDPLENDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2495DF0", Offset = "0x2494DF0", VA = "0x182495DF0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct EJFCKIOLJMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public LJDIAMGONCO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x249B2C0", Offset = "0x249A2C0", VA = "0x18249B2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class NAKIDJDKKJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NAKIDJDKKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x24A9D70", Offset = "0x24A8D70", VA = "0x1824A9D70")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct PBMLDNEFOAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public HAIFOKIHEGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x24AA8A0", Offset = "0x24A98A0", VA = "0x1824AA8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class NOJAHMBFOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NOJAHMBFOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x24AA390", Offset = "0x24A9390", VA = "0x1824AA390")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private readonly JKKMCLEIKNA GAGLCIMNBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private KCNPCMHNLDE JHHFKCEOBOD;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private NHNDDFDJKOJ EPDMLBONCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x5F8CF0", Offset = "0x5F7CF0", VA = "0x1805F8CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
	public HAIFOKIHEGI(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x249F5E0", Offset = "0x249E5E0", VA = "0x18249F5E0")]
	[AsyncStateMachine(typeof(CAKJLEJDENC))]
	public Task AEOMJAPKJGO(KIEBILFOMFH NHJGKPKLDHM, LJDIAMGONCO BPHHJPGAPKI, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x249FC70", Offset = "0x249EC70", VA = "0x18249FC70")]
	[AsyncStateMachine(typeof(HNLKPILLNBM))]
	private Task INGOPHKLAID(LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x249F9F0", Offset = "0x249E9F0", VA = "0x18249F9F0")]
	[AsyncStateMachine(typeof(EFIFHPMPNAK))]
	private Task FHJDIIOGDJH(LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x249FF10", Offset = "0x249EF10", VA = "0x18249FF10")]
	[AsyncStateMachine(typeof(KBAKEJBGDJC))]
	private Task KFFAOCLCCDF(LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x249FB30", Offset = "0x249EB30", VA = "0x18249FB30")]
	[AsyncStateMachine(typeof(BNPMDLPAGEC))]
	private Task GMJLDPHDGGO(Guid EIJMEIMBEKF, List<PEDMBIGFGLD> NAIGOPAFAAK, EFKFHBDMADD GAGHCAJOIFO, LJDIAMGONCO JEJGBICCBLN, CancellationToken KGJPBGICHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x249F740", Offset = "0x249E740", VA = "0x18249F740")]
	[AsyncStateMachine(typeof(GFGOBLPDJGG))]
	private Task AOANBOPCEHN(LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x24A02E0", Offset = "0x249F2E0", VA = "0x1824A02E0")]
	[AsyncStateMachine(typeof(EJFCKIOLJMD))]
	private Task ODELBNLPEBB(Guid KFFCGKPKLHK, LJDIAMGONCO JEJGBICCBLN, MLACCLOKFHB BCAFPIOPGIA, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x24A0410", Offset = "0x249F410", VA = "0x1824A0410")]
	[AsyncStateMachine(typeof(PBMLDNEFOAH))]
	private Task OLAJKMLFECK(Guid KFFCGKPKLHK, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x249FDC0", Offset = "0x249EDC0", VA = "0x18249FDC0")]
	private void KALCJHMOMEC(Guid KFFCGKPKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x24A0050", Offset = "0x249F050", VA = "0x1824A0050")]
	private void LIHJANEIMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x24A0140", Offset = "0x249F140", VA = "0x1824A0140")]
	public Guid LMLEEIAJBNE(KIEBILFOMFH BIHDJIJBHIE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x249F880", Offset = "0x249E880", VA = "0x18249F880")]
	[CompilerGenerated]
	private object EIBKIMOMFPH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct LPBFELBNLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public FDBKGNMGHFG PJMOIGPAIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public List<string> JCGOLBOGHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public Dictionary<long, int> KEOEBINAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public string AOGLFEPPKPB;
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal class FGOAEAFHLCE : EJCGEIHPNLC
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class CNIFMKLHCKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public AJIPHKLOIPJ autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public CNIFMKLHCKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class JCJAMANCPGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public CNIFMKLHCKD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JCJAMANCPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x25D7350", Offset = "0x25D6350", VA = "0x1825D7350")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class GJFGFFABCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public CNIFMKLHCKD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GJFGFFABCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x25D4C40", Offset = "0x25D3C40", VA = "0x1825D4C40")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class IMHOFJGPHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public AJIPHKLOIPJ autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IMHOFJGPHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x25D5A50", Offset = "0x25D4A50", VA = "0x1825D5A50")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class NFDDHMOAHPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public FileInfo autosaveFile;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public NFDDHMOAHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x25DB080", Offset = "0x25DA080", VA = "0x1825DB080")]
		internal object <TryReadAutosave>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class GHGMGGACCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GHGMGGACCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x25D4C00", Offset = "0x25D3C00", VA = "0x1825D4C00")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class KLNGPFBAAJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public FileInfo file;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KLNGPFBAAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x25DA060", Offset = "0x25D9060", VA = "0x1825DA060")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class IBNEEPBEJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IBNEEPBEJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x25D53A0", Offset = "0x25D43A0", VA = "0x1825D53A0")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private const string IELNIAKKPMP = "V2";

	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private const int DCJIMIPGNKF = 5;

	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private const string LLEBMDMIEOO = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private const string ACAGJDGHBLE = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private const int HCMDNJLIGHL = 32;

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x25CFE30", Offset = "0x25CEE30", VA = "0x1825CFE30")]
	public FGOAEAFHLCE(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x25D1AC0", Offset = "0x25D0AC0", VA = "0x1825D1AC0")]
	public bool CFPGEKMKNHI(long MPOPHDGDFPN, LPBFELBNLDJ LPMPLMCCCLK, AJIPHKLOIPJ GAPFHPGFEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x25D28E0", Offset = "0x25D18E0", VA = "0x1825D28E0")]
	public static bool JPNFLDAAPPG(long MPOPHDGDFPN, AJIPHKLOIPJ GAPFHPGFEME, out FileInfo OJDPGPEIMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x25D29A0", Offset = "0x25D19A0", VA = "0x1825D29A0")]
	public bool LADADKOHHDM(long MPOPHDGDFPN, AJIPHKLOIPJ GAPFHPGFEME, out LPBFELBNLDJ LPMPLMCCCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x25D15E0", Offset = "0x25D05E0", VA = "0x1825D15E0")]
	private bool BHDNPCDHAGC(FileInfo OJDPGPEIMLD, out byte[] CJIOMBDMILP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x25D1500", Offset = "0x25D0500", VA = "0x1825D1500")]
	private static FileInfo BFDNHIPNHIP(long MPOPHDGDFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x25D2320", Offset = "0x25D1320", VA = "0x1825D2320")]
	private static FileInfo HIBFEKCHAMC(long MPOPHDGDFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x25D1F30", Offset = "0x25D0F30", VA = "0x1825D1F30")]
	private static DirectoryInfo DJMGLLELKAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x25D1FA0", Offset = "0x25D0FA0", VA = "0x1825D1FA0")]
	private void EHNGNPCGGAP(FileInfo BKIAGNAFBBL, FDBKGNMGHFG AJPJOCFLBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x25D23F0", Offset = "0x25D13F0", VA = "0x1825D23F0")]
	private void JLHIMCCPDDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x25D1350", Offset = "0x25D0350", VA = "0x1825D1350")]
	public static void AINLPINDCBP(long MPOPHDGDFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x25D2F60", Offset = "0x25D1F60", VA = "0x1825D2F60")]
	public static bool MJNFOKLPAIP(long MPOPHDGDFPN, out DateTime MFBPGCMPPPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal class GMNHCACGPFH : EJCGEIHPNLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct LOMCJEHGBEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder<LPBFELBNLDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public GMNHCACGPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public EOLDEMFEKPN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x24A9170", Offset = "0x24A8170", VA = "0x1824A9170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x24A9670", Offset = "0x24A8670", VA = "0x1824A9670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class KPHLLGIAIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public EOLDEMFEKPN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KPHLLGIAIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x24A86E0", Offset = "0x24A76E0", VA = "0x1824A86E0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class GLHENGFKADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public KPHLLGIAIAG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GLHENGFKADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x249E280", Offset = "0x249D280", VA = "0x18249E280")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class CKCBEEFDFML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public KPHLLGIAIAG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public CKCBEEFDFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x2499810", Offset = "0x2498810", VA = "0x182499810")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct IOGBFCMJKDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public EOLDEMFEKPN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public GMNHCACGPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private GLHENGFKADG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private MOKCCBBOACE.FEPKAEINKEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x24A68D0", Offset = "0x24A58D0", VA = "0x1824A68D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private readonly HNBGEDIDMCE CODPMPJAOIO;

	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private static readonly TimeSpan HPOABIDFAAI;

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x249F330", Offset = "0x249E330", VA = "0x18249F330")]
	public GMNHCACGPFH(JKKMCLEIKNA GAGLCIMNBBB, [Optional] HNBGEDIDMCE? CODPMPJAOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x249F170", Offset = "0x249E170", VA = "0x18249F170")]
	[AsyncStateMachine(typeof(LOMCJEHGBEH))]
	public Task<LPBFELBNLDJ> NJADPKHDAEC(long MPOPHDGDFPN, string FJBIEPGMBAJ, EOLDEMFEKPN AAPMOLKDNJL, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x249E320", Offset = "0x249D320", VA = "0x18249E320")]
	[AsyncStateMachine(typeof(IOGBFCMJKDH))]
	private Task AOKHFEKINJK(EOLDEMFEKPN AAPMOLKDNJL, IEnumerable<PersistenceView> KHOGBAOKODB, StringBuilder FDHNHDFLAJI, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x249E5B0", Offset = "0x249D5B0", VA = "0x18249E5B0")]
	private LPBFELBNLDJ GHGLIGHDLOO(long MPOPHDGDFPN, string FJBIEPGMBAJ, EOLDEMFEKPN AAPMOLKDNJL, IEnumerable<PersistenceView> KHOGBAOKODB, StringBuilder FDHNHDFLAJI)
	{
		return default(LPBFELBNLDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x249E470", Offset = "0x249D470", VA = "0x18249E470")]
	private FDBKGNMGHFG CGLLGGOEEIM(long MPOPHDGDFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x249EF70", Offset = "0x249DF70", VA = "0x18249EF70")]
	private void MMDOKGFMDBL(FDBKGNMGHFG PKEIFHKLKCE, StringBuilder FDHNHDFLAJI, IEnumerable<PersistenceView> KHOGBAOKODB, in PNKKMJOJLKJ ONBOLLJEEDG, ref NLGONFANMHG JNOFNGIHIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x249EAE0", Offset = "0x249DAE0", VA = "0x18249EAE0")]
	private void KOONFLEPJHO(FDBKGNMGHFG PKEIFHKLKCE, StringBuilder FDHNHDFLAJI, PersistenceView NHKKBKKOJJM, ref NLGONFANMHG JNOFNGIHIBH, in PNKKMJOJLKJ ONBOLLJEEDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal class EDPOAKCFMHA : EJCGEIHPNLC
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class AEJJHEOCBJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public DBLFDALAINL.HELOPCPOCBM roomMetadataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public DBLFDALAINL.HELOPCPOCBM roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public AEJJHEOCBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x25C4D00", Offset = "0x25C3D00", VA = "0x1825C4D00")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x25C4D80", Offset = "0x25C3D80", VA = "0x1825C4D80")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x25C4DD0", Offset = "0x25C3DD0", VA = "0x1825C4DD0")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x25C4E40", Offset = "0x25C3E40", VA = "0x1825C4E40")]
		internal object <UploadRoomData>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct JAONCKNFDMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public AsyncTaskMethodBuilder<(DBLFDALAINL.HELOPCPOCBM roomMetadataUpload, DBLFDALAINL.HELOPCPOCBM roomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public LPBFELBNLDJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public EDPOAKCFMHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private AEJJHEOCBJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<DBLFDALAINL.HELOPCPOCBM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x25D69F0", Offset = "0x25D59F0", VA = "0x1825D69F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x25D7300", Offset = "0x25D6300", VA = "0x1825D7300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct GDBEIOCAMIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder<NCMHNNOIOOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public EDPOAKCFMHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public LPBFELBNLDJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private TaskAwaiter<(DBLFDALAINL.HELOPCPOCBM roomMetadataUpload, DBLFDALAINL.HELOPCPOCBM roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<NCMHNNOIOOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x25D4200", Offset = "0x25D3200", VA = "0x1825D4200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x25D4570", Offset = "0x25D3570", VA = "0x1825D4570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct DNKODOGJAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<NCAFGBCAKDF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public EDPOAKCFMHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public LPBFELBNLDJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter<(DBLFDALAINL.HELOPCPOCBM roomMetadataUpload, DBLFDALAINL.HELOPCPOCBM roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private TaskAwaiter<NCAFGBCAKDF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x25CD540", Offset = "0x25CC540", VA = "0x1825CD540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x25CD880", Offset = "0x25CC880", VA = "0x1825CD880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class DLGHONJAPLN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public DLGHONJAPLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			private ILPEFNEFIAF <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			private TaskAwaiter<NCAFGBCAKDF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			private TaskAwaiter<NCMHNNOIOOH> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private TaskAwaiter<ILPEFNEFIAF> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x25DD5D0", Offset = "0x25DC5D0", VA = "0x1825DD5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x25DE3F0", Offset = "0x25DD3F0", VA = "0x1825DE3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public EDPOAKCFMHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public LPBFELBNLDJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public DLGHONJAPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x25CCD40", Offset = "0x25CBD40", VA = "0x1825CCD40")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<ILPEFNEFIAF> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct JNGKMIINOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder<ILPEFNEFIAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public EDPOAKCFMHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public LPBFELBNLDJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private TaskAwaiter<ILPEFNEFIAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x25D7950", Offset = "0x25D6950", VA = "0x1825D7950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x25D7B80", Offset = "0x25D6B80", VA = "0x1825D7B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private const float JAJGPHLBGIM = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private readonly AJAOKOGIDKE OMNCBMGFKDM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private MLNEICIMMPF CKIFPONFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x24A5A00", Offset = "0x24A4A00", VA = "0x1824A5A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x25CEC40", Offset = "0x25CDC40", VA = "0x1825CEC40")]
	public EDPOAKCFMHA(JKKMCLEIKNA GAGLCIMNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x25CE990", Offset = "0x25CD990", VA = "0x1825CE990")]
	[AsyncStateMachine(typeof(JAONCKNFDMN))]
	private Task<(DBLFDALAINL.HELOPCPOCBM, DBLFDALAINL.HELOPCPOCBM)> ICNNKKAODJN(LPBFELBNLDJ LPMPLMCCCLK, long PBLGEAPLLBL, long MICLPPPFMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x25CE840", Offset = "0x25CD840", VA = "0x1825CE840")]
	[AsyncStateMachine(typeof(GDBEIOCAMIK))]
	public Task<NCMHNNOIOOH> BHFKDNAEAKP(int HAGCHBJIOKN, LPBFELBNLDJ LPMPLMCCCLK, long PBLGEAPLLBL, long MICLPPPFMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x25CEAE0", Offset = "0x25CDAE0", VA = "0x1825CEAE0")]
	[AsyncStateMachine(typeof(DNKODOGJAIE))]
	private Task<NCAFGBCAKDF> KNANBDPGLKK(string KIJAAMLEMEA, int HAGCHBJIOKN, LPBFELBNLDJ LPMPLMCCCLK, long PBLGEAPLLBL, long MICLPPPFMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x25CE6D0", Offset = "0x25CD6D0", VA = "0x1825CE6D0")]
	[AsyncStateMachine(typeof(JNGKMIINOCG))]
	public Task<ILPEFNEFIAF> AOBKKOJFNIF(int HAGCHBJIOKN, LPBFELBNLDJ LPMPLMCCCLK, long PBLGEAPLLBL, long MICLPPPFMCH, MLACCLOKFHB HDALINEEMFB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public class IIKMCKNMJKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private readonly Guid AHPODJGLLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private readonly NGDEDPLJJJF OFOICKDPAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private KPHIGKDHNKJ PHHFPJMDJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private int? PFAJHPPEGPP;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Guid MKPFCKAPFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A40", Offset = "0x8F5A40", VA = "0x1808F6A40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x240F280", Offset = "0x240E280", VA = "0x18240F280")]
	public IIKMCKNMJKE(NGDEDPLJJJF OFOICKDPAGI, [Optional] Guid? AHPODJGLLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x240F110", Offset = "0x240E110", VA = "0x18240F110")]
	public IIKMCKNMJKE AAILJMPNHCD(KPHIGKDHNKJ PHHFPJMDJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x240F1B0", Offset = "0x240E1B0", VA = "0x18240F1B0")]
	public ILPEFNEFIAF NPDNKOFCFFD(out Guid FHBKEMAPJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x240F130", Offset = "0x240E130", VA = "0x18240F130")]
	public IIKMCKNMJKE EFKKKFKKPFG(CFKJNANNAIG DCDMNFHAAFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
public static class JBMMBJPKPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x24118E0", Offset = "0x24108E0", VA = "0x1824118E0")]
	public static CONELIFOGEN ICFAMFJHCDI(this CAIIELGNCNK NCBLBABBJFN)
	{
		return default(CONELIFOGEN);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public MDCFDMMAAKA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public MDCFDMMAAKA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private static MDCFDMMAAKA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private Dictionary<MDCFDMMAAKA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x4874610", Offset = "0x4873610", VA = "0x184874610")]
		public bool EBOGOCPLBPF(MDCFDMMAAKA OPPLIFBBKKJ, out ResultConfig BIEIOBCMFMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x4874CD0", Offset = "0x4873CD0", VA = "0x184874CD0")]
		public ResultConfig PHKFEFJLNLC(MDCFDMMAAKA JICBGDLCEAH, [Optional] HashSet<MDCFDMMAAKA> HNEBOFLMNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x4874B30", Offset = "0x4873B30", VA = "0x184874B30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x4874680", Offset = "0x4873680", VA = "0x184874680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xDD5560", Offset = "0xDD4560", VA = "0x180DD5560")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x40005FD")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x25CFE90", Offset = "0x25CEE90", VA = "0x1825CFE90")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x25CFF90", Offset = "0x25CEF90", VA = "0x1825CFF90")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000601")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
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
