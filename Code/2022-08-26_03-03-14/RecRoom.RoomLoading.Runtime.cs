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
public class NMHIGBCOEOG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x230E790", Offset = "0x230D390", VA = "0x18230E790")]
	public NMHIGBCOEOG(string CIJKLAFFGJI, Exception BDDOPJHNKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface EOIIFJCKLBI : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CNJENDMABEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task BGBLKOHCEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOEGMDIALPI(Task FFAHJNHCBKN, string BIEGCHFHHIM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface BLMDICKEGNE : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DIBCECFGDBP> GABOLLHAEOM(CGDLLLKAEDP AIAPLHMBPNG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DHBKCIPNBKK(CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface MBHIJCAOJIK : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PGOAKEJNCDN OGFDCDKDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJLBKLBELKB();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBJCPJLNHJD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface AKKAPAFENLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface AAJJMCHENDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TimeSpan ACOINFLFFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan PMGJHCFAFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan KBHILKOIPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan EBHLOMKILIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CHIHMKJEJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MEKCJADHIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KIBIJAHJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MPPPHMPHNJE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KLACFLIEBFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long AJJICPNHKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long DILPJIBNJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MPPPHMPHNJE LIJLAEFJGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception CCHPFANHBEK;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x23075D0", Offset = "0x23061D0", VA = "0x1823075D0")]
	public KLACFLIEBFG(long AJJICPNHKCG, long DILPJIBNJHM, MPPPHMPHNJE LIJLAEFJGCI, [CanBeNull] Exception CCHPFANHBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2307580", Offset = "0x2306180", VA = "0x182307580")]
	public static KLACFLIEBFG OIJCCGOAGBB(LOJEIMKKAPH NICJBMKKLBD, MPPPHMPHNJE LIJLAEFJGCI, [Optional] Exception CCHPFANHBEK)
	{
		return default(KLACFLIEBFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void OIPGHFKJLNG(KLACFLIEBFG KOBNNJMHNGD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface JGIDNAPMEEA : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LINKHNDCNGA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OIPGHFKJLNG LPEJIINNLNF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OIPGHFKJLNG DLBPCIGMHMI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OIPGHFKJLNG BKBFFDJFDEI;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDEFLACDEIP();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ACBALAJNJGD(KLACFLIEBFG KOBNNJMHNGD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LOPHMJIDCBE(KLACFLIEBFG KOBNNJMHNGD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CAHAFMEKCPE(KLACFLIEBFG KOBNNJMHNGD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface DGANKCHANBB : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ALFMNMEHIJD();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPEHAMFJKJG();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GECCFIHNAEH();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate Task NPHDOCIAJCD(GDCLCKJPEAM OMJKBNBHODM, CancellationToken KJKNLGILOFJ);
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal interface FGIJLGCOLAD : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OMBNICDGOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPOAOIMCOJM(NPHDOCIAJCD IHDEHOGBMMI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface OMPCNBNNPKI : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	TaskStatus CJPBIOKHIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ABLEDGJDMPN(LOJEIMKKAPH DIPBFGCEGHE, CancellationToken EOJPFFNCEBK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class OJLECLCOJCK
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49FEBD0", Offset = "0x49FD7D0", VA = "0x1849FEBD0")]
	public static bool IJJEECKPPCH(this OMPCNBNNPKI PIEDOHJPJKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface PPNMJFAJPOL : FFOKLGKFINF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CancellationToken OJGJMKKJJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EAFDIMGMAFM JDJMLCKEJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OBFGBCOCHIP DDHLOIAPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OGHLOEKIGPE BLDPPFCAENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AEGNJANDAKH IHIAGKKCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IHOENKGPFEJ LFIIJMGGNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FIJENAMILEO AMNFICHGNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AAJPJGLAHJA NNNMIHMCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EOIIFJCKLBI PDMLEJLMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BLMDICKEGNE BFALHCCOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JGIDNAPMEEA JAGENIDDEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DGANKCHANBB KGGCLBIMGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	OMPCNBNNPKI KLPDBILIHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FGIJLGCOLAD EFCDGBBHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MCHLNCCOLAO HNMCGLJCCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	KPFCMEICLCB IMGGAPKHIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MGAKGFEBBIF OEKLBPIPPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HFBMNLMFKID LIBJJFGNDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ILMKANMNIPM ODKCFMCEPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AMIOAAFAKIM DIDDJGPIIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HIDJNCNCGIE EIOHEEEKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CPHKMPMDHCN CPOJDJNCNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	PLBABDGAJEK ODIPLGMJCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BBDCJKHPJHN HOALECALPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GBFOMELCHAH FFNPHOCFBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MBHIJCAOJIK PAGLJAIHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AAJJMCHENDJ IPANDPMEEHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ODGJFLGBAHF PKCEMOLIJML
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface MCHLNCCOLAO : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKDGNJOIAF LFMPFEAFMAL(Guid EEBPFACBCBO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNIHJKFEBJI(Guid EEBPFACBCBO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHCLLKLODIM(Guid EEBPFACBCBO, Task POAKHPIOFEM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFDAECHHIHL(Guid EEBPFACBCBO, DIBCECFGDBP KEOGBLPGJKN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GECCFIHNAEH(Guid EEBPFACBCBO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(DIBCECFGDBP, Task)> BLDPHJALBJK(Guid EEBPFACBCBO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface KPFCMEICLCB : AKKAPAFENLF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface MGAKGFEBBIF : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPLECJNMDKI(OIOFODEOKJJ CIJKLAFFGJI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLMJEIFFNDN(OIOFODEOKJJ CIJKLAFFGJI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MAKHFKKGMGG> MJJOFMJOFGC(CancellationToken INNAJGEKEDO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate DIBCECFGDBP OBHLMNGLELL(JOLEIFGGDHD EDPOAPEADPN, MAKHFKKGMGG KJJAPFFOIFE);
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface HFBMNLMFKID : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNKDGNJOIAF JMNNGIJKPPP(EBFBPENADOI DBOENCKFMJG);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDMPKADBEFN(Guid EEBPFACBCBO, Task POAKHPIOFEM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface ILMKANMNIPM : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DIBCECFGDBP> ODKCFMCEPAC(JOLEIFGGDHD KJNJAMHHIEJ, MAKHFKKGMGG JCGBPHCGKDK, [Optional] BLFDLDDAGOG BNOBPPNHMOC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface AMIOAAFAKIM : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BGANJHOLFGD> CBJDBDJKLCG(JBHAGEIOKBE JDIFJAIAPMA, LOJEIMKKAPH DIPBFGCEGHE, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGANJHOLFGD GFMAEJIIEGM(LOJEIMKKAPH DIPBFGCEGHE, BLFDLDDAGOG JNOJAEMLJFC, long JBPDPGIHJEE);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGANJHOLFGD LLGPBCGHBCC(LOJEIMKKAPH DIPBFGCEGHE, FANOGDNCLMC PGNNAMIGKKM, long JBPDPGIHJEE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BGANJHOLFGD HPBIMDEPNAJ(long AJJICPNHKCG, long JBPDPGIHJEE, string BDBHIODHJDL, string BHLKJEANMPN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface CPHKMPMDHCN : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DIBCECFGDBP NPKPLPALPHD(JOLEIFGGDHD EDPOAPEADPN);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LABDFEEMBDF(string ABEDOAAIHDK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface HIDJNCNCGIE : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OIOFODEOKJJ> GAJMILPKADN(OIOFODEOKJJ IMIDEOCLBEC, BNJCICCOPAC DIBKODPNCMF, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OIOFODEOKJJ> CDEGGFGAENN(CancellationToken DHCIMDILIGO, BNJCICCOPAC DIBKODPNCMF);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDKMFBPHFLH KMEKNKCOOBH(CALJFKKNFDC KDFNAACPHEI, JBHAGEIOKBE JDIFJAIAPMA);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDKMFBPHFLH IGLAPKJHLDD(CALJFKKNFDC KDFNAACPHEI, JBHAGEIOKBE JDIFJAIAPMA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface PLBABDGAJEK : AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DIBCECFGDBP DNMJPFCEGOF(JOLEIFGGDHD EDPOAPEADPN, MAKHFKKGMGG KJJAPFFOIFE);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DIBCECFGDBP FOINKPHHFLL(JOLEIFGGDHD ABMFCAMBJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DIBCECFGDBP KPEHMDHIEEI(JOLEIFGGDHD ABMFCAMBJDJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BBDCJKHPJHN
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIMLAKGKHDF(LFPLFCFJIFN HJCLJNOIFNA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHIJOCFGMHG(LFPLFCFJIFN HJCLJNOIFNA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMLBOBDOLDM(LFPLFCFJIFN HJCLJNOIFNA);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFDABDEDNJH(LFPLFCFJIFN HJCLJNOIFNA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LFPLFCFJIFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly LOJEIMKKAPH PBKKGEEGBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> KLLGGKGBIAB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public global::ECGIJGGMGEF<string> LPGKIPPGDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
	public LFPLFCFJIFN(LOJEIMKKAPH MPCEJMHEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2307960", Offset = "0x2306560", VA = "0x182307960")]
	public LFPLFCFJIFN BCCACAIIDPH(string KKDEFIFHPNN, string KGJOJGIPNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2307A20", Offset = "0x2306620", VA = "0x182307A20")]
	public bool OEMPEOLPDGG(out IEnumerable<KeyValuePair<string, string>> DDFJCMDGAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2307AA0", Offset = "0x23066A0", VA = "0x182307AA0")]
	public LFPLFCFJIFN PNPAGGEMHFA(global::ECGIJGGMGEF<string> HHBOJHHPENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ODGJFLGBAHF
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MPIIIIBCIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string DENKNACGMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMOMPONOBOH();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNECPPGNHDP(long LEKONKDGCIB, out DIFANGKMMOP FIIOAIABIMO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHBHAAEBHAE(long LEKONKDGCIB, out global::EKHPIODOJLB<EKDIEFBMMGH> FIIOAIABIMO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHDMJFJEONE(long LEKONKDGCIB, out global::EKHPIODOJLB<EKDIEFBMMGH> FIIOAIABIMO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BHHCNAJPBJH(long LEKONKDGCIB, out string BHLKJEANMPN, out string BDBHIODHJDL, out EKDIEFBMMGH DGPDAECBFBN, out EKDIEFBMMGH ILAFKFEEJEJ);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void APPMHCKFHFB(BGANJHOLFGD IMIDEOCLBEC, long LEKONKDGCIB);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<bool> OGBMEFLFBIJ(long LEKONKDGCIB, byte[] DGPDAECBFBN, byte[] ILAFKFEEJEJ, CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FFOKLGKFINF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool IJJEECKPPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool DOKEKMFCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action LINKHNDCNGA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OIPGHFKJLNG LPEJIINNLNF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OIPGHFKJLNG DLBPCIGMHMI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OIPGHFKJLNG BKBFFDJFDEI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CPEHAMFJKJG();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<DIBCECFGDBP> FBPMILPBBKM([Optional][CanBeNull] BLFDLDDAGOG IHFIBPGMKLF);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<DIBCECFGDBP> FADBPOFKIJL(JOLEIFGGDHD LPDKCLKDCEP);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<DIBCECFGDBP> NEBCDICCDIB(int IGCOMPFHBCP);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LABDFEEMBDF(string ABEDOAAIHDK);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<DIBCECFGDBP> GABOLLHAEOM(CGDLLLKAEDP AIAPLHMBPNG = CGDLLLKAEDP.Incremental);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task DHBKCIPNBKK(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AJIPCGBLBIF(long JBPDPGIHJEE);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NNOGDFJKIDM(long JBPDPGIHJEE, out DateTime MHAMDNOFANP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AEGNJANDAKH
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string DIMDEPKLCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALOLCNMAAMM(Scene NONAEIENPPI);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CBPNFPGNDAI(MLOEENCGLIC FCBIGNKNOJN, CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface COFMANBGLKC
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int KMICFHLFOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool BJHDMPGHPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool EHFMNFIDPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool LLKHLDFGLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool DDPNHAHHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool OKONJNLIEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JOLEIFGGDHD MGJJDKIJJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EAFDIMGMAFM IIOGCMHPPAA(EAFDIMGMAFM JDCLFPLKEOA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJLBNDBDLCH(EAFDIMGMAFM NBELCHPBKDK);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MHPGMPIPJAP(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DMDHFFECJHG(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task AAIOGHBLKMC(HEKPGMALPIG NLMJDJOMNEN, [Optional] CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCHKJOCLLEA(float HFAAFEANOLI);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OKKJEHLLMOH(string POFMMPFMHDI);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<HEGKFMDAJAH> LJKNOMFPKIN();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable OHEJFODFJGI(object NAEOEJMOBMH, HEGKFMDAJAH JKOAPIHICPD);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CNHLEBKEOPK NAEGKJGKIFL();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GGHDFNAMDKI(int BOBJJKHCLJF);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task HJFBNBELGHO();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HAEGHMDOLCD();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool GOABLJGDAOE();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task EDMJDHCLCDH(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task NMBNOKPMILJ(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> BHIIMBBMGHB(DateTime HGDFDPGKPAM, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> MOFIJMMGJKM(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HDEENHCBKDJ();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IHFJHNBJCMP CBKAEALJNLG(OMGBOIABDEP FDCEGDNBCHM, IMCGHCNINDK INCMCAOFHMH, IEnumerable<PersistenceView> JLHIFNCOABM, ref IKJLLPLFBPP BHKLFJPKBGC);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DGFNLCKOPPE(INMIAOPIAHL NELKABEIKEE, in IHFJHNBJCMP ELFLHAPPPBO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MDKANDLPKFB(IMCGHCNINDK GHAFIGHOENJ, bool OMEAPEBGJEK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MDFJIHGICMN();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KKGDBEMOBJO(long FKPMOLLCILH, long DILPJIBNJHM, BLFDLDDAGOG CLAODPJJBNJ, KCNIOKLNAOF DGKGHBNEJJL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CPNGEINFKHN(long FKPMOLLCILH, long DILPJIBNJHM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JMHLAOEGBGP(PersistenceView DCPGOEOHKAI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool FMBFBGEMFMA(PersistenceView FJAGFNGNGHD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool AGNIKAFPDOI(INMIAOPIAHL NELKABEIKEE, IBEKIDLIIJK OPBDCNDMHOD, Dictionary<int, int> KFDCODNGNAH, out DCGNKLFPIBC KECHAJAHMLP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KNDHNHNLLCP();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KKCMMEHHNLF();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable OPMPAECJECO();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Dictionary<int, int> ECBOMKLBMPP(IMCGHCNINDK GHAFIGHOENJ, IBEKIDLIIJK OPBDCNDMHOD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> IJCBLPLLHGE(OBFGBCOCHIP JCCFEHGPDHB, CancellationToken DHCIMDILIGO, JBHAGEIOKBE JDIFJAIAPMA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void LKIEMNACPBF(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<BLFDLDDAGOG> LCJMCPDLMGE(long FKPMOLLCILH, long DILPJIBNJHM, string BDBHIODHJDL, string HBBJJHCMMJG, string MHJGKCJMLOI, Dictionary<long, int> NLFFJGFGPKN, int EFCLJOKJOGE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<FANOGDNCLMC> KDPFOPHNGEF(string BHLKJEANMPN, long FKPMOLLCILH, long DILPJIBNJHM, string BDBHIODHJDL, LDEMFLHNMIH.LMOFMOKGGHE HBBJJHCMMJG, LDEMFLHNMIH.LMOFMOKGGHE MHJGKCJMLOI, int EFCLJOKJOGE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<BLFDLDDAGOG> GIFCMCDGFNL(long FKPMOLLCILH, bool LIGCEKHGDFJ, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GGJLKHKNPCO();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LBMHBNIKGAE();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GameObject[] OJFMJLONIBD(KOFMCJLLJHF[] DDCCDINEJDD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OICKALEKGEK(List<GameObject> GDDABEPHDFK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float PHGJPNKKJCG();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> JKDCACLEFJN(string LNDJJHKPJBH, LoadSceneMode EOIGLNMICNO, bool GNDDOCBJFAF, JBHAGEIOKBE HHBOJHHPENA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KIJJBOLFNNK(LOJEIMKKAPH OCJHODGDOAC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void KKANAAKDCJD(string JCGBPHCGKDK, JOLEIFGGDHD KJNJAMHHIEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task JJBNMIFHMPI(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task OOJOKPCFPEK(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void EHAAGADCDHL();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "56")]
	IDisposable CAEIOFMLINI();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "57")]
	JAHJPJKANIE DJMAKPOLEEH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JAHJPJKANIE
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EMHDOFJEALD(CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OJBBKMOALGL(CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct IHFJHNBJCMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> GKJFAOBNBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public IDisposable ONOLDGOODLD;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x24CB900", Offset = "0x24CA500", VA = "0x1824CB900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HOHBAPJJNFL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LOJEIMKKAPH PKIGCOPAJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BLFDLDDAGOG IGCPAFACPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JOPMHEMNFAA IOFLIIFJENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EEIKOMHCHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool GMFIMAGGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int KMICFHLFOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action KEBAEPCOKBN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<int> OIELPAHKOKJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKANACPADNE();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.EGLGGAIBFAD> FEEEPLLFOLO();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JONCNDFENFK();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LOJEIMKKAPH HHJOONGIHPJ();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NJJLNGIHBAJ KAALDHENEHE();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HALDCJCILOH(long LEKONKDGCIB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GBFOMELCHAH
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILCNEGJHJDA(out IEnumerable<int> NEDEFFNCCIB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBODBCFMLCA(ODJMLBBJHBE KJKNLGILOFJ);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAODDINHJME(ODJMLBBJHBE KJKNLGILOFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FCNKODHAAIM
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NLJOKEODEMD(DIBCECFGDBP DFHIPOMCLBG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class CJLCPFANOAE : FFOKLGKFINF, IDisposable, PPNMJFAJPOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EDAHLNEMFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<DIBCECFGDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CJLCPFANOAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CGDLLLKAEDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<DIBCECFGDBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x256A650", Offset = "0x2569250", VA = "0x18256A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x256A890", Offset = "0x2569490", VA = "0x18256A890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DNEENKGMDKG : IEnumerable<AKKAPAFENLF>, IEnumerable, IEnumerator<AKKAPAFENLF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private AKKAPAFENLF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public CJLCPFANOAE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private AKKAPAFENLF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
		[DebuggerHidden]
		public DNEENKGMDKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2569B50", Offset = "0x2568750", VA = "0x182569B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2569F90", Offset = "0x2568B90", VA = "0x182569F90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2569EF0", Offset = "0x2568AF0", VA = "0x182569EF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AKKAPAFENLF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2569EF0", Offset = "0x2568AF0", VA = "0x182569EF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationTokenSource GHMEELMBCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EAFDIMGMAFM NBELCHPBKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HGEIIIIEAOI PFEDIDKDCDI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OBFGBCOCHIP DDHLOIAPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x63F130", Offset = "0x63DD30", VA = "0x18063F130", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6799F0", Offset = "0x6785F0", VA = "0x1806799F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OGHLOEKIGPE BLDPPFCAENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x610720", Offset = "0x60F320", VA = "0x180610720", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x679920", Offset = "0x678520", VA = "0x180679920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FE220", Offset = "0x5FCE20", VA = "0x1805FE220", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x686370", Offset = "0x684F70", VA = "0x180686370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AEGNJANDAKH IHIAGKKCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5F2630", Offset = "0x5F1230", VA = "0x1805F2630", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FFEE0", Offset = "0x5FEAE0", VA = "0x1805FFEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IHOENKGPFEJ LFIIJMGGNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F2620", Offset = "0x5F1220", VA = "0x1805F2620", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x679B80", Offset = "0x678780", VA = "0x180679B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FIJENAMILEO AMNFICHGNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x610660", Offset = "0x60F260", VA = "0x180610660", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5F2640", Offset = "0x5F1240", VA = "0x1805F2640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AAJPJGLAHJA NNNMIHMCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x610670", Offset = "0x60F270", VA = "0x180610670", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5FE250", Offset = "0x5FCE50", VA = "0x1805FE250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EOIIFJCKLBI PDMLEJLMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5FFEA0", Offset = "0x5FEAA0", VA = "0x1805FFEA0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5FE230", Offset = "0x5FCE30", VA = "0x1805FE230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BLMDICKEGNE BFALHCCOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x626080", Offset = "0x624C80", VA = "0x180626080", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6877E0", Offset = "0x6863E0", VA = "0x1806877E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public JGIDNAPMEEA JAGENIDDEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x63F140", Offset = "0x63DD40", VA = "0x18063F140", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CCBF0", Offset = "0x7CB7F0", VA = "0x1807CCBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public DGANKCHANBB KGGCLBIMGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x675C40", Offset = "0x674840", VA = "0x180675C40", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x686E10", Offset = "0x685A10", VA = "0x180686E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OMPCNBNNPKI KLPDBILIHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6106E0", Offset = "0x60F2E0", VA = "0x1806106E0", Slot = "37")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5FE240", Offset = "0x5FCE40", VA = "0x1805FE240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FGIJLGCOLAD EFCDGBBHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6106F0", Offset = "0x60F2F0", VA = "0x1806106F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFC80", VA = "0x180701080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public MCHLNCCOLAO HNMCGLJCCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x626190", Offset = "0x624D90", VA = "0x180626190", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x679B60", Offset = "0x678760", VA = "0x180679B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public KPFCMEICLCB IMGGAPKHIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x610700", Offset = "0x60F300", VA = "0x180610700", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5FE260", Offset = "0x5FCE60", VA = "0x1805FE260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public MGAKGFEBBIF OEKLBPIPPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6758F0", Offset = "0x6744F0", VA = "0x1806758F0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x677C50", Offset = "0x676850", VA = "0x180677C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public HFBMNLMFKID LIBJJFGNDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x677AA0", Offset = "0x6766A0", VA = "0x180677AA0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6781C0", Offset = "0x676DC0", VA = "0x1806781C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public ILMKANMNIPM ODKCFMCEPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x677AB0", Offset = "0x6766B0", VA = "0x180677AB0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x679980", Offset = "0x678580", VA = "0x180679980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public AMIOAAFAKIM DIDDJGPIIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x677B50", Offset = "0x676750", VA = "0x180677B50", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x677C70", Offset = "0x676870", VA = "0x180677C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public HIDJNCNCGIE EIOHEEEKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x63D0B0", Offset = "0x63BCB0", VA = "0x18063D0B0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA50", Offset = "0x7CE650", VA = "0x1807CFA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public CPHKMPMDHCN CPOJDJNCNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6788B0", Offset = "0x6774B0", VA = "0x1806788B0", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x678B50", Offset = "0x677750", VA = "0x180678B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public PLBABDGAJEK ODIPLGMJCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x678890", Offset = "0x677490", VA = "0x180678890", Slot = "47")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public BBDCJKHPJHN HOALECALPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6774A0", VA = "0x1806788A0", Slot = "48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public GBFOMELCHAH FFNPHOCFBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x994790", Offset = "0x993390", VA = "0x180994790", Slot = "49")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xEBDC00", Offset = "0xEBC800", VA = "0x180EBDC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public MBHIJCAOJIK PAGLJAIHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6759B0", Offset = "0x6745B0", VA = "0x1806759B0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x678C90", Offset = "0x677890", VA = "0x180678C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public AAJJMCHENDJ IPANDPMEEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6264D0", Offset = "0x6250D0", VA = "0x1806264D0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x677C80", Offset = "0x676880", VA = "0x180677C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ODGJFLGBAHF PKCEMOLIJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x739EF0", Offset = "0x738AF0", VA = "0x180739EF0", Slot = "52")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7395E0", Offset = "0x7381E0", VA = "0x1807395E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private bool BCFAGDEDIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2562B50", Offset = "0x2561750", VA = "0x182562B50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool FLLHAIABFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2563230", Offset = "0x2561E30", VA = "0x182563230", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private CancellationToken OKGLIFKIBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2563300", Offset = "0x2561F00", VA = "0x182563300", Slot = "24")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private EAFDIMGMAFM CGLLHANFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event Action EKCHMKNJBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2562D20", Offset = "0x2561920", VA = "0x182562D20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x25632A0", Offset = "0x2561EA0", VA = "0x1825632A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event OIPGHFKJLNG CJGIEJAFABL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2562EA0", Offset = "0x2561AA0", VA = "0x182562EA0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x25634C0", Offset = "0x25620C0", VA = "0x1825634C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event OIPGHFKJLNG OOEODDJENFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2562A30", Offset = "0x2561630", VA = "0x182562A30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2563320", Offset = "0x2561F20", VA = "0x182563320", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event OIPGHFKJLNG OMDIHLNAAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2562F00", Offset = "0x2561B00", VA = "0x182562F00", Slot = "10")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2562FC0", Offset = "0x2561BC0", VA = "0x182562FC0", Slot = "11")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2563590", Offset = "0x2562190", VA = "0x182563590")]
	[Preserve]
	internal CJLCPFANOAE([CEABMBGCAIH(null)] EAFDIMGMAFM NBELCHPBKDK, [CEABMBGCAIH(null)] OBFGBCOCHIP JCCFEHGPDHB, [CEABMBGCAIH(null)] OGHLOEKIGPE BJPFKKMILOK, [CEABMBGCAIH(null)] COFMANBGLKC NOMIILNDOJF, [CEABMBGCAIH(null)] AEGNJANDAKH ILHIAJJLCPG, [CEABMBGCAIH(null)] IHOENKGPFEJ EEKGKEFLHPD, [CEABMBGCAIH(null)] FIJENAMILEO IBLFNDOAEBI, [CEABMBGCAIH(null)] AAJPJGLAHJA NDMOJPMMAKM, [CEABMBGCAIH(null)] EOIIFJCKLBI LLPHIJFKGJN, [CEABMBGCAIH(null)] BLMDICKEGNE CNELENIBEBJ, [CEABMBGCAIH(null)] JGIDNAPMEEA IHOIPNEDJNI, [CEABMBGCAIH(null)] DGANKCHANBB IHHNOLCJKLI, [CEABMBGCAIH(null)] OMPCNBNNPKI PIEDOHJPJKP, [CEABMBGCAIH(null)] FGIJLGCOLAD BPJAGKJOAJO, [CEABMBGCAIH(null)] MCHLNCCOLAO GLOBPFGPFCF, [CEABMBGCAIH(null)] KPFCMEICLCB GNIDEGCNKDG, [CEABMBGCAIH(null)] MGAKGFEBBIF NLFBPJHPHJJ, [CEABMBGCAIH(null)] HFBMNLMFKID HMLOHIIEECJ, [CEABMBGCAIH(null)] ILMKANMNIPM CODFAELPJDB, [CEABMBGCAIH(null)] AMIOAAFAKIM PGAKOLNKNDB, [CEABMBGCAIH(null)] CPHKMPMDHCN CEOMPJKKFGF, [CEABMBGCAIH(null)] HIDJNCNCGIE DKLAODPCECD, [CEABMBGCAIH(null)] PLBABDGAJEK JCHCJAAAPLE, [CEABMBGCAIH(null)] BBDCJKHPJHN AAMEKOBHKJD, [CEABMBGCAIH(null)] GBFOMELCHAH NOKDOMEMPNM, [CEABMBGCAIH(null)] AAJJMCHENDJ MJJPCIEJCOI, [CEABMBGCAIH(null)] ODGJFLGBAHF JCCKMOIIHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25633F0", Offset = "0x2561FF0", VA = "0x1825633F0")]
	private void NEDKCOBOAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2562BC0", Offset = "0x25617C0", VA = "0x182562BC0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x25631E0", Offset = "0x2561DE0", VA = "0x1825631E0", Slot = "14")]
	private void JDAECMLKCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2562B60", Offset = "0x2561760", VA = "0x182562B60", Slot = "20")]
	private Task DMEFHHHKDHC(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2562A20", Offset = "0x2561620", VA = "0x182562A20", Slot = "21")]
	private void AEHJAIEFNJG(long JBPDPGIHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2563520", Offset = "0x2562120", VA = "0x182563520", Slot = "22")]
	private bool PAEBJBPGHIP(long DILPJIBNJHM, out DateTime JLKLHPBHBFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2562A90", Offset = "0x2561690", VA = "0x182562A90", Slot = "18")]
	private Task BJGKAPPFNHK(string ABEDOAAIHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2563020", Offset = "0x2561C20", VA = "0x182563020", Slot = "15")]
	private Task<DIBCECFGDBP> IDNPEJAMIIL(BLFDLDDAGOG IHFIBPGMKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2563380", Offset = "0x2561F80", VA = "0x182563380", Slot = "16")]
	private Task<DIBCECFGDBP> LNBNJHHEOIF(JOLEIFGGDHD LPDKCLKDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2563120", Offset = "0x2561D20", VA = "0x182563120", Slot = "17")]
	private Task<DIBCECFGDBP> IIMGDDBBENL(int IGCOMPFHBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2562D80", Offset = "0x2561980", VA = "0x182562D80", Slot = "19")]
	[AsyncStateMachine(typeof(EDAHLNEMFAA))]
	private Task<DIBCECFGDBP> EFEBGNBLJAL(CGDLLLKAEDP AIAPLHMBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x25630B0", Offset = "0x2561CB0", VA = "0x1825630B0")]
	[IteratorStateMachine(typeof(DNEENKGMDKG))]
	private IEnumerable<AKKAPAFENLF> IEHBCNNPIHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2562F60", Offset = "0x2561B60", VA = "0x182562F60")]
	[CompilerGenerated]
	private void GDDANCEECIF(AKKAPAFENLF DGHFPMGLNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class LPBACDLPHBP : DBFLLFCCGGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct EAJDGOHCEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LPBACDLPHBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x22FE0B0", Offset = "0x22FCCB0", VA = "0x1822FE0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x22FE380", Offset = "0x22FCF80", VA = "0x1822FE380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5FF990", Offset = "0x5FE590", VA = "0x1805FF990")]
	public LPBACDLPHBP(PPNMJFAJPOL NFAAFLGBLEA, COFMANBGLKC NOMIILNDOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2308B20", Offset = "0x2307720", VA = "0x182308B20", Slot = "4")]
	[AsyncStateMachine(typeof(EAJDGOHCEJP))]
	public Task<bool> HLFGOJIGFGA(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2308A00", Offset = "0x2307600", VA = "0x182308A00")]
	[CompilerGenerated]
	private object AJNPLCKFFBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class EMGHGHFONBG : DBFLLFCCGGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KINBOLCDEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EMGHGHFONBG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x24CDBE0", Offset = "0x24CC7E0", VA = "0x1824CDBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x24CE1A0", Offset = "0x24CCDA0", VA = "0x1824CE1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float DIJGNCFLMGK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x24C0570", Offset = "0x24BF170", VA = "0x1824C0570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5FF990", Offset = "0x5FE590", VA = "0x1805FF990")]
	public EMGHGHFONBG(PPNMJFAJPOL NFAAFLGBLEA, COFMANBGLKC NOMIILNDOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x24C0380", Offset = "0x24BEF80", VA = "0x1824C0380", Slot = "4")]
	[AsyncStateMachine(typeof(KINBOLCDEAC))]
	public Task<bool> HLFGOJIGFGA(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x24C04B0", Offset = "0x24BF0B0", VA = "0x1824C04B0")]
	[CompilerGenerated]
	private object JDCFNGPHPOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class OIOEKMMCLCB : DBFLLFCCGGB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NEJLNNCBJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OIOEKMMCLCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Matchmaking.EGLGGAIBFAD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LOJEIMKKAPH newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NEJLNNCBJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x49FD4F0", Offset = "0x49FC0F0", VA = "0x1849FD4F0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x49FD620", Offset = "0x49FC220", VA = "0x1849FD620")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x49FD680", Offset = "0x49FC280", VA = "0x1849FD680")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct OCALKIMFOHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OIOEKMMCLCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private NEJLNNCBJIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<Matchmaking.EGLGGAIBFAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x49FE150", Offset = "0x49FCD50", VA = "0x1849FE150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x49FE970", Offset = "0x49FD570", VA = "0x1849FE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float DIJGNCFLMGK = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x49FEAF0", Offset = "0x49FD6F0", VA = "0x1849FEAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF990", Offset = "0x5FE590", VA = "0x1805FF990")]
	public OIOEKMMCLCB(PPNMJFAJPOL NFAAFLGBLEA, COFMANBGLKC NOMIILNDOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x49FE9C0", Offset = "0x49FD5C0", VA = "0x1849FE9C0", Slot = "4")]
	[AsyncStateMachine(typeof(OCALKIMFOHL))]
	public Task<bool> HLFGOJIGFGA(CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface DBFLLFCCGGB
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HLFGOJIGFGA(CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal struct OKKOAOOFHLE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class DIBBOOGNHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PPNMJFAJPOL manager;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DIBBOOGNHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x49FA5D0", Offset = "0x49F91D0", VA = "0x1849FA5D0")]
		internal Task <CreateTask>b__0(GDCLCKJPEAM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HNOKCBMPKPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OKKOAOOFHLE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x49FB700", Offset = "0x49FA300", VA = "0x1849FB700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x49FB9F0", Offset = "0x49FA5F0", VA = "0x1849FB9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FOJBDMAMHJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public OKKOAOOFHLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x49FB0C0", Offset = "0x49F9CC0", VA = "0x1849FB0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationToken DHCIMDILIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PPNMJFAJPOL AOINJCPCJGF;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private OBFGBCOCHIP DDHLOIAPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x49FEC20", Offset = "0x49FD820", VA = "0x1849FEC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x49FF1D0", Offset = "0x49FDDD0", VA = "0x1849FF1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x49FF320", Offset = "0x49FDF20", VA = "0x1849FF320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private BLMDICKEGNE BFALHCCOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x49FF180", Offset = "0x49FDD80", VA = "0x1849FF180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x49FF3A0", Offset = "0x49FDFA0", VA = "0x1849FF3A0")]
	public OKKOAOOFHLE(CancellationToken DHCIMDILIGO, PPNMJFAJPOL AOINJCPCJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x49FEEF0", Offset = "0x49FDAF0", VA = "0x1849FEEF0")]
	public static NPHDOCIAJCD FMBJEGCDIAE(PPNMJFAJPOL AOINJCPCJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x49FEF80", Offset = "0x49FDB80", VA = "0x1849FEF80")]
	[AsyncStateMachine(typeof(HNOKCBMPKPA))]
	public Task<bool> GGEBMKLJJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x49FEC70", Offset = "0x49FD870", VA = "0x1849FEC70")]
	private bool EIHJHOAHOME(out FileInfo KJILBOFIBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x49FF220", Offset = "0x49FDE20", VA = "0x1849FF220")]
	[AsyncStateMachine(typeof(FOJBDMAMHJE))]
	private Task LNPEPCPNOBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x49FEDD0", Offset = "0x49FD9D0", VA = "0x1849FEDD0")]
	private Task<bool> FCPOJDNBAIC(FileInfo KJILBOFIBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x49FF090", Offset = "0x49FDC90", VA = "0x1849FF090")]
	private Task IPLGJNIPJDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x49FED60", Offset = "0x49FD960", VA = "0x1849FED60")]
	private void EJIPALDPJDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal struct HNKDGNJOIAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MCHLNCCOLAO GLOBPFGPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Guid EEBPFACBCBO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private Task<(DIBCECFGDBP, Task)> JCLPKHNCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x24C9300", Offset = "0x24C7F00", VA = "0x1824C9300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x24C94F0", Offset = "0x24C80F0", VA = "0x1824C94F0")]
	public HNKDGNJOIAF(MCHLNCCOLAO GLOBPFGPFCF, Guid EEBPFACBCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x24C94A0", Offset = "0x24C80A0", VA = "0x1824C94A0")]
	public TaskAwaiter<(DIBCECFGDBP, Task)> FIOMALNPOFH()
	{
		return default(TaskAwaiter<(DIBCECFGDBP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x24C93D0", Offset = "0x24C7FD0", VA = "0x1824C93D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct BGDAJHBKIJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly TaskCompletionSource<(DIBCECFGDBP, Task)> JJHJNJFBLEA;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Task<(DIBCECFGDBP, Task)> JCLPKHNCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2560FE0", Offset = "0x255FBE0", VA = "0x182560FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x25611D0", Offset = "0x255FDD0", VA = "0x1825611D0")]
	public BGDAJHBKIJE(TimeSpan JFIGOGADDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2561070", Offset = "0x255FC70", VA = "0x182561070")]
	public void EMBHMIGHOPM(Task POAKHPIOFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2561140", Offset = "0x255FD40", VA = "0x182561140")]
	public void IAMDNHLDJFK(DIBCECFGDBP DFHIPOMCLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2561020", Offset = "0x255FC20", VA = "0x182561020")]
	public void ELDPIEAMPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2560F60", Offset = "0x255FB60", VA = "0x182560F60")]
	internal void DENGADDPMDP(string CIJKLAFFGJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Preserve]
internal class JGBEANNICNH : EOIIFJCKLBI, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MGGCDELFBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JGBEANNICNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x230AC10", Offset = "0x2309810", VA = "0x18230AC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly ODJMLBBJHBE JMPEGOMEJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string JBJKHIHJBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Task KPCNGJJMAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool CNJENDMABEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2302AC0", Offset = "0x23016C0", VA = "0x182302AC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Task BGBLKOHCEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2302AF0", Offset = "0x23016F0", VA = "0x182302AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440", Slot = "7")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2302B50", Offset = "0x2301750", VA = "0x182302B50", Slot = "6")]
	public void GOEGMDIALPI(Task FFAHJNHCBKN, string BIEGCHFHHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2302CD0", Offset = "0x23018D0", VA = "0x182302CD0")]
	[AsyncStateMachine(typeof(MGGCDELFBGP))]
	private Task PMDMFKLMDFP(Task KIBNBCJDAHH, string BIEGCHFHHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2302E00", Offset = "0x2301A00", VA = "0x182302E00")]
	public JGBEANNICNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal class ANINLACPKHK : MBHIJCAOJIK, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool NJLDKFOBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private PGOAKEJNCDN PMHAIGMMAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private AAJJMCHENDJ MJJPCIEJCOI;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PGOAKEJNCDN OGFDCDKDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x255EDC0", Offset = "0x255D9C0", VA = "0x18255EDC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x255EFB0", Offset = "0x255DBB0", VA = "0x18255EFB0", Slot = "7")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x255EE30", Offset = "0x255DA30", VA = "0x18255EE30", Slot = "5")]
	public void IJLBKLBELKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x255ED80", Offset = "0x255D980", VA = "0x18255ED80", Slot = "6")]
	public void HBJCPJLNHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x255F110", Offset = "0x255DD10", VA = "0x18255F110")]
	private Task PJCPPLGIAIG(EBDNMLPHEPO ELDEGBGONOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x255ED80", Offset = "0x255D980", VA = "0x18255ED80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public ANINLACPKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class NNAJICAIDAD : AAJJMCHENDJ
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class LKDOOBIEAPC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly PIEKGNMEIIN KDPFOMEMHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly string KKDEFIFHPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly T OGKBGGEDIAG;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public T ONGHMHAEIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6177B0", Offset = "0x6163B0", VA = "0x1806177B0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x66E8C0", Offset = "0x66D4C0", VA = "0x18066E8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3382B90", Offset = "0x3381790", VA = "0x183382B90")]
		public LKDOOBIEAPC(PIEKGNMEIIN KDPFOMEMHBP, string KKDEFIFHPNN, T OGKBGGEDIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3382850", Offset = "0x3381450", VA = "0x183382850")]
		private void ANDAAJEDIKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly LKDOOBIEAPC<TimeSpan> HAPIMIOEGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly LKDOOBIEAPC<TimeSpan> BCCFIONJNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly LKDOOBIEAPC<TimeSpan> DNOJHONIDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly LKDOOBIEAPC<TimeSpan> NKHEPDCLHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly LKDOOBIEAPC<bool> DIICMOGGIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly LKDOOBIEAPC<bool> OPEAPMGAIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly LKDOOBIEAPC<bool> LIJLEAIJGPP;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TimeSpan ACOINFLFFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x230E990", Offset = "0x230D590", VA = "0x18230E990", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public TimeSpan PMGJHCFAFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x230E950", Offset = "0x230D550", VA = "0x18230E950", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public TimeSpan KBHILKOIPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x230E810", Offset = "0x230D410", VA = "0x18230E810", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TimeSpan EBHLOMKILIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x230E850", Offset = "0x230D450", VA = "0x18230E850", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool CHIHMKJEJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x230E910", Offset = "0x230D510", VA = "0x18230E910", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool MEKCJADHIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x230E890", Offset = "0x230D490", VA = "0x18230E890", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool KIBIJAHJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x230E8D0", Offset = "0x230D4D0", VA = "0x18230E8D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x230E9D0", Offset = "0x230D5D0", VA = "0x18230E9D0")]
	[Preserve]
	public NNAJICAIDAD([CEABMBGCAIH(null)] PIEKGNMEIIN KDPFOMEMHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Preserve]
internal class HJMPJEMGHDJ : JGIDNAPMEEA, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LNJBMOAJNID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KLACFLIEBFG roomEvent;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LNJBMOAJNID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x24CF980", Offset = "0x24CE580", VA = "0x1824CF980")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action LINKHNDCNGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x24C87B0", Offset = "0x24C73B0", VA = "0x1824C87B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x24C8420", Offset = "0x24C7020", VA = "0x1824C8420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event OIPGHFKJLNG LPEJIINNLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x24C8850", Offset = "0x24C7450", VA = "0x1824C8850", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x24C89C0", Offset = "0x24C75C0", VA = "0x1824C89C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event OIPGHFKJLNG DLBPCIGMHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x24C8710", Offset = "0x24C7310", VA = "0x1824C8710", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x24C8380", Offset = "0x24C6F80", VA = "0x1824C8380", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event OIPGHFKJLNG BKBFFDJFDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x24C8920", Offset = "0x24C7520", VA = "0x1824C8920", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x24C82E0", Offset = "0x24C6EE0", VA = "0x1824C82E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "16")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x24C84C0", Offset = "0x24C70C0", VA = "0x1824C84C0", Slot = "12")]
	public void FDEFLACDEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x24C8030", Offset = "0x24C6C30", VA = "0x1824C8030", Slot = "13")]
	public void ACBALAJNJGD(KLACFLIEBFG KOBNNJMHNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x24C88F0", Offset = "0x24C74F0", VA = "0x1824C88F0", Slot = "14")]
	public void LOPHMJIDCBE(KLACFLIEBFG KOBNNJMHNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x24C82B0", Offset = "0x24C6EB0", VA = "0x1824C82B0", Slot = "15")]
	public void CAHAFMEKCPE(KLACFLIEBFG KOBNNJMHNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x24C8060", Offset = "0x24C6C60", VA = "0x1824C8060")]
	private void BEBMDLKMKEA(OIPGHFKJLNG JKOAPIHICPD, KLACFLIEBFG KOBNNJMHNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public HJMPJEMGHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Preserve]
internal class KBGOKFHKIOG : DGANKCHANBB, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct PCGOIHILHJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public KBGOKFHKIOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x23135E0", Offset = "0x23121E0", VA = "0x1823135E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KDACPLECEHI : IAsyncStateMachine
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
		public KBGOKFHKIOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2306800", Offset = "0x2305400", VA = "0x182306800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class KOCFEOJGAPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public KOCFEOJGAPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x23078B0", Offset = "0x23064B0", VA = "0x1823078B0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JNHCAAIFMEF : IAsyncStateMachine
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
		public KBGOKFHKIOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private KOCFEOJGAPJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x23036E0", Offset = "0x23022E0", VA = "0x1823036E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2303E10", Offset = "0x2302A10", VA = "0x182303E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KMLLNGMCDMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public KMLLNGMCDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x23075F0", Offset = "0x23061F0", VA = "0x1823075F0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private DBFLLFCCGGB[] LCHKFHMGDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CancellationTokenSource LHFNCMCPHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private int DIFNPFBMBGA;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x23060D0", Offset = "0x2304CD0", VA = "0x1823060D0", Slot = "7")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2305980", Offset = "0x2304580", VA = "0x182305980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2305CB0", Offset = "0x23048B0", VA = "0x182305CB0", Slot = "6")]
	public void GECCFIHNAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2305830", Offset = "0x2304430", VA = "0x182305830", Slot = "5")]
	public void CPEHAMFJKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2305720", Offset = "0x2304320", VA = "0x182305720", Slot = "4")]
	[AsyncStateMachine(typeof(PCGOIHILHJL))]
	public Task ALFMNMEHIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2305990", Offset = "0x2304590", VA = "0x182305990")]
	private void FBPCIJGMKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2306150", Offset = "0x2304D50", VA = "0x182306150")]
	[AsyncStateMachine(typeof(KDACPLECEHI))]
	private Task OGFCHHPHDMB(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x23055F0", Offset = "0x23041F0", VA = "0x1823055F0")]
	[AsyncStateMachine(typeof(JNHCAAIFMEF))]
	private Task<bool> AKLOKJALKIL(int HIANDEDCLIF, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2305E20", Offset = "0x2304A20", VA = "0x182305E20")]
	private void GNJALINCIHH(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2306270", Offset = "0x2304E70", VA = "0x182306270")]
	private void PHJPGAMBKFM(int HIANDEDCLIF, bool FCBAHJOHDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2305F40", Offset = "0x2304B40", VA = "0x182305F40")]
	private void LCMCDFDJEMJ(int HIANDEDCLIF, Exception BJEAAGJFDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2305500", Offset = "0x2304100", VA = "0x182305500")]
	private void ABGOCIAJHEM(CancellationToken DHCIMDILIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public KBGOKFHKIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Preserve]
internal class JNMKILAMEKG : FGIJLGCOLAD, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct AFMOCCNECMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public JNMKILAMEKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GDCLCKJPEAM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x22FBD90", Offset = "0x22FA990", VA = "0x1822FBD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NHILJFFMCKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public JNMKILAMEKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public GDCLCKJPEAM roomData;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NHILJFFMCKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x230E3C0", Offset = "0x230CFC0", VA = "0x18230E3C0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct IPHLCAHIANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NPHDOCIAJCD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2302380", Offset = "0x2300F80", VA = "0x182302380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DOPPOMGHEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JNMKILAMEKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x22FDE70", Offset = "0x22FCA70", VA = "0x1822FDE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HashSet<NPHDOCIAJCD> AOBGNLDDCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private OGHLOEKIGPE BJPFKKMILOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private HEGKFMDAJAH GDPPDFMJGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private IDIKIKONGIB CBEIKJHADOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private IDisposable IILLBBDCCAJ;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool OMBNICDGOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x23048C0", Offset = "0x23034C0", VA = "0x1823048C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	internal Task JCLPKHNCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x23040B0", Offset = "0x2302CB0", VA = "0x1823040B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2304BE0", Offset = "0x23037E0", VA = "0x182304BE0", Slot = "6")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x23040C0", Offset = "0x2302CC0", VA = "0x1823040C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2304E50", Offset = "0x2303A50", VA = "0x182304E50", Slot = "5")]
	public bool OPOAOIMCOJM(NPHDOCIAJCD IHDEHOGBMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x23049F0", Offset = "0x23035F0", VA = "0x1823049F0")]
	private void MMGICMBPDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2303E60", Offset = "0x2302A60", VA = "0x182303E60")]
	private void AAKCLNEPDBA(GDCLCKJPEAM OMJKBNBHODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x23048D0", Offset = "0x23034D0", VA = "0x1823048D0")]
	[AsyncStateMachine(typeof(AFMOCCNECMF))]
	private Task MAMAFNOEOAG(GDCLCKJPEAM OMJKBNBHODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2304B30", Offset = "0x2303730", VA = "0x182304B30")]
	private Func<CancellationToken, List<Task>> NDCKCLFBGNG(GDCLCKJPEAM OMJKBNBHODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2304120", Offset = "0x2302D20", VA = "0x182304120")]
	private List<Task> EFAMIDBDFMJ(GDCLCKJPEAM OMJKBNBHODM, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2304790", Offset = "0x2303390", VA = "0x182304790")]
	[AsyncStateMachine(typeof(IPHLCAHIANC))]
	private Task KDKIMNMFDIA(NPHDOCIAJCD IJKPBPCDCCK, GDCLCKJPEAM OAGMKJFIKKL, CancellationToken KJKNLGILOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x23045C0", Offset = "0x23031C0", VA = "0x1823045C0")]
	[AsyncStateMachine(typeof(DOPPOMGHEOK))]
	private Task FBLLGCIINNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x23046C0", Offset = "0x23032C0", VA = "0x1823046C0")]
	private void GECCFIHNAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2304EB0", Offset = "0x2303AB0", VA = "0x182304EB0")]
	public JNMKILAMEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Preserve]
internal class EKMFEMDJKOA : OMPCNBNNPKI, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct FHGHGEBFILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x24C1200", Offset = "0x24BFE00", VA = "0x1824C1200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PEIOKPBLMHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private global::ECGIJGGMGEF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private BNJCICCOPAC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private LFPLFCFJIFN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x24D1670", Offset = "0x24D0270", VA = "0x1824D1670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AAAJPDNAIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Task<BGANJHOLFGD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public AAAJPDNAIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		internal Task<BGANJHOLFGD> <ConnectToRoomAndRunLoadLogic>b__0(JBHAGEIOKBE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GPAICLKLNBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BNJCICCOPAC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private AAAJPDNAIHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private CJLNBKFABKE <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private JBHAGEIOKBE <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private AAIEOKMHKNK <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<BGANJHOLFGD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x24C4B90", Offset = "0x24C3790", VA = "0x1824C4B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct ONOAGODCMCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private JBHAGEIOKBE <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private JBHAGEIOKBE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x24D0EB0", Offset = "0x24CFAB0", VA = "0x1824D0EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct DGBEMKNLNGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private EAFDIMGMAFM <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x24BB4A0", Offset = "0x24BA0A0", VA = "0x1824BB4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct KOJAEJKPOEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public BNJCICCOPAC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private JBHAGEIOKBE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<KIJCKNLMCHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x24CE1F0", Offset = "0x24CCDF0", VA = "0x1824CE1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class MPIPDEKMKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MPIPDEKMKDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CCFNDLMHKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public MPIPDEKMKDP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CCFNDLMHKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x24BA240", Offset = "0x24B8E40", VA = "0x1824BA240")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x24BA150", Offset = "0x24B8D50", VA = "0x1824BA150")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct AGDFJBFFENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private CCFNDLMHKNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x24B93F0", Offset = "0x24B7FF0", VA = "0x1824B93F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct LHBLFJPGEOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public BNJCICCOPAC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public BGANJHOLFGD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public LOJEIMKKAPH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CJLNBKFABKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private JBHAGEIOKBE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x24CED20", Offset = "0x24CD920", VA = "0x1824CED20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct AGKKPKFIPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private JBHAGEIOKBE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x24B9D00", Offset = "0x24B8900", VA = "0x1824B9D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct CPOAKPJKHCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x24BAC30", Offset = "0x24B9830", VA = "0x1824BAC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct HECKNMDAFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x24C6BA0", Offset = "0x24C57A0", VA = "0x1824C6BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct AFIEKFELECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<DIBCECFGDBP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x24B8DB0", Offset = "0x24B79B0", VA = "0x1824B8DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct PGDJDHGFOON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public EKMFEMDJKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x24D1F10", Offset = "0x24D0B10", VA = "0x1824D1F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LHDGBPMJCOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LHDGBPMJCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x24CF310", Offset = "0x24CDF10", VA = "0x1824CF310")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CPIGLEGPJDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CPIGLEGPJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x24BABA0", Offset = "0x24B97A0", VA = "0x1824BABA0")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HFNOMEFPCJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HFNOMEFPCJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x24C6E20", Offset = "0x24C5A20", VA = "0x1824C6E20")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class CHIDONFOFCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CHIDONFOFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x24BA9B0", Offset = "0x24B95B0", VA = "0x1824BA9B0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly string BANANPAAALI;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly string PPPDEHKIJNI;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly string KBKIPECBFGP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static readonly Guid DJEOIHFEJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AAJPJGLAHJA NDMOJPMMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OGHLOEKIGPE BJPFKKMILOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private DGANKCHANBB IHHNOLCJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private EOIIFJCKLBI LLPHIJFKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private JGIDNAPMEEA IHOIPNEDJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AAJJMCHENDJ MJJPCIEJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IDisposable IILLBBDCCAJ;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public TaskStatus CJPBIOKHIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x788800", Offset = "0x787400", VA = "0x180788800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x787E90", Offset = "0x786A90", VA = "0x180787E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x24BF6F0", Offset = "0x24BE2F0", VA = "0x1824BF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x24BF4B0", Offset = "0x24BE0B0", VA = "0x1824BF4B0", Slot = "6")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x24BD500", Offset = "0x24BC100", VA = "0x1824BD500", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x24BCE60", Offset = "0x24BBA60", VA = "0x1824BCE60", Slot = "5")]
	[AsyncStateMachine(typeof(FHGHGEBFILG))]
	public Task ABLEDGJDMPN(LOJEIMKKAPH DIPBFGCEGHE, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x24BDC10", Offset = "0x24BC810", VA = "0x1824BDC10")]
	[AsyncStateMachine(typeof(PEIOKPBLMHG))]
	private Task FDGKCACGLGA(LOJEIMKKAPH DIPBFGCEGHE, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x24BEA50", Offset = "0x24BD650", VA = "0x1824BEA50")]
	private static void MICDKBJOABH(LFPLFCFJIFN JMKIAOJCHMO, Exception BJEAAGJFDCJ, [Optional] List<int> ABBCFOEDGBE, int DIFNPFBMBGA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x24BE670", Offset = "0x24BD270", VA = "0x1824BE670")]
	[AsyncStateMachine(typeof(GPAICLKLNBA))]
	private Task JGOMMPHBHLC(JBHAGEIOKBE HHBOJHHPENA, LOJEIMKKAPH DIPBFGCEGHE, BNJCICCOPAC FBEFOEAMABC, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x24BE490", Offset = "0x24BD090", VA = "0x1824BE490")]
	private void HLENMILBCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x24BFAF0", Offset = "0x24BE6F0", VA = "0x1824BFAF0")]
	[AsyncStateMachine(typeof(ONOAGODCMCH))]
	private Task ONJAMDAFAPF(JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x24BD910", Offset = "0x24BC510", VA = "0x1824BD910")]
	private void EOAGHKAPONK(LOJEIMKKAPH DIPBFGCEGHE, CancellationToken EOJPFFNCEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x24BD040", Offset = "0x24BBC40", VA = "0x1824BD040")]
	private void CIKGAJKCJGM(LOJEIMKKAPH DIPBFGCEGHE, BNJCICCOPAC FBEFOEAMABC, OperationCanceledException DFOOLPNPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x24BDE80", Offset = "0x24BCA80", VA = "0x1824BDE80")]
	private void FIOCHNCICGC(LOJEIMKKAPH DIPBFGCEGHE, BNJCICCOPAC FBEFOEAMABC, Exception BJEAAGJFDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x24BF0E0", Offset = "0x24BDCE0", VA = "0x1824BF0E0")]
	private void MNHMLECNEFM(LOJEIMKKAPH DIPBFGCEGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x24BD340", Offset = "0x24BBF40", VA = "0x1824BD340")]
	private static KLACFLIEBFG DAKJKNLMKKF(LOJEIMKKAPH DIPBFGCEGHE)
	{
		return default(KLACFLIEBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x24BE0F0", Offset = "0x24BCCF0", VA = "0x1824BE0F0")]
	[AsyncStateMachine(typeof(DGBEMKNLNGC))]
	private Task FNGNIJDDABJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x24BD710", Offset = "0x24BC310", VA = "0x1824BD710")]
	private static KIJCKNLMCHH EKEJPMJMAIC(LOJEIMKKAPH DIPBFGCEGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x24BE330", Offset = "0x24BCF30", VA = "0x1824BE330")]
	[AsyncStateMachine(typeof(KOJAEJKPOEL))]
	private Task HAILEAPCGON(LOJEIMKKAPH DIPBFGCEGHE, BNJCICCOPAC FBEFOEAMABC, JBHAGEIOKBE HHBOJHHPENA, CancellationToken JDLIIJLKELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x24BD7C0", Offset = "0x24BC3C0", VA = "0x1824BD7C0")]
	[AsyncStateMachine(typeof(AGDFJBFFENM))]
	private Task ELDPDFEJMEA(LOJEIMKKAPH DIPBFGCEGHE, CancellationTokenSource JDBLAJAPBGJ, Task OEPLIHJHNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x24BD380", Offset = "0x24BBF80", VA = "0x1824BD380")]
	[AsyncStateMachine(typeof(LHBLFJPGEOH))]
	private Task DDEDIABMPGE(BGANJHOLFGD IKMLHKBAFME, CJLNBKFABKE IMPMDIGKPAC, LOJEIMKKAPH LIDPFPEBLCE, BNJCICCOPAC MANMODJFBAN, JBHAGEIOKBE HHBOJHHPENA, CancellationToken AJAGOCPBFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x24BF870", Offset = "0x24BE470", VA = "0x1824BF870")]
	private BNJCICCOPAC NLOKJKBAEHG(BNJCICCOPAC MANMODJFBAN, ref CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x24BE7E0", Offset = "0x24BD3E0", VA = "0x1824BE7E0")]
	[AsyncStateMachine(typeof(AGKKPKFIPBC))]
	private Task LDDKAACJEAL(JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x24BD550", Offset = "0x24BC150", VA = "0x1824BD550")]
	[AsyncStateMachine(typeof(CPOAKPJKHCP))]
	private Task EAAMGEKHPJH(JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x24BDD40", Offset = "0x24BC940", VA = "0x1824BDD40")]
	[AsyncStateMachine(typeof(HECKNMDAFHC))]
	private Task FDLKLBMAJAN(JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x24BF740", Offset = "0x24BE340", VA = "0x1824BF740")]
	[AsyncStateMachine(typeof(AFIEKFELECF))]
	private Task NIHFACKAKGK(GDCLCKJPEAM OAGMKJFIKKL, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x24BCD20", Offset = "0x24BB920", VA = "0x1824BCD20")]
	[AsyncStateMachine(typeof(PGDJDHGFOON))]
	private Task AAIOGHBLKMC(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken JDLIIJLKELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x24BFE00", Offset = "0x24BEA00", VA = "0x1824BFE00")]
	private static void PKLOOFELDPC(LOJEIMKKAPH DIPBFGCEGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x24BFC20", Offset = "0x24BE820", VA = "0x1824BFC20")]
	private void PFIDDBMPAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x24BFA70", Offset = "0x24BE670", VA = "0x1824BFA70")]
	private void OHHBEGHEOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x24BD680", Offset = "0x24BC280", VA = "0x1824BD680")]
	private void EGMELNJMNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x24BD2B0", Offset = "0x24BBEB0", VA = "0x1824BD2B0")]
	private void CKIKBLLHNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x24BE1F0", Offset = "0x24BCDF0", VA = "0x1824BE1F0")]
	private static void GIJEKKHGEJC(LOJEIMKKAPH DIPBFGCEGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x24BCF90", Offset = "0x24BBB90", VA = "0x1824BCF90")]
	private static void BOGLBGLDINP(LOJEIMKKAPH DIPBFGCEGHE, CancellationToken JDLIIJLKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x24BF330", Offset = "0x24BDF30", VA = "0x1824BF330")]
	private static void NCDLCCOEAJJ(LOJEIMKKAPH DIPBFGCEGHE, Exception BJEAAGJFDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x24BE920", Offset = "0x24BD520", VA = "0x1824BE920")]
	private void LHNKOAOELBH(LOJEIMKKAPH DIPBFGCEGHE, Task OEPLIHJHNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24BE5B0", Offset = "0x24BD1B0", VA = "0x1824BE5B0")]
	private static void IIAAMKEFCEN(Func<string> LBDLHIHDENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x24BFFE0", Offset = "0x24BEBE0", VA = "0x1824BFFE0")]
	public EKMFEMDJKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Preserve]
internal sealed class BELMOMOHJKO : MCHLNCCOLAO, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class OHCDLCAAEKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OHCDLCAAEKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2571BD0", Offset = "0x25707D0", VA = "0x182571BD0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class BINBDDGCHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public BINBDDGCHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2561310", Offset = "0x255FF10", VA = "0x182561310")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HGODEMLCJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HGODEMLCJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x256DCE0", Offset = "0x256C8E0", VA = "0x18256DCE0")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GNODHAENDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public GNODHAENDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x256DC90", Offset = "0x256C890", VA = "0x18256DC90")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class DCLFKMBBAPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DCLFKMBBAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2563ED0", Offset = "0x2562AD0", VA = "0x182563ED0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Dictionary<Guid, BGDAJHBKIJE> GLOBPFGPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly TimeSpan HKNAOGFPGGI;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "10")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x255FF40", Offset = "0x255EB40", VA = "0x18255FF40", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2560660", Offset = "0x255F260", VA = "0x182560660", Slot = "4")]
	public HNKDGNJOIAF LFMPFEAFMAL(Guid EEBPFACBCBO)
	{
		return default(HNKDGNJOIAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2560190", Offset = "0x255ED90", VA = "0x182560190", Slot = "5")]
	public bool JNIHJKFEBJI(Guid EEBPFACBCBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x255FF50", Offset = "0x255EB50", VA = "0x18255FF50", Slot = "8")]
	public bool GECCFIHNAEH(Guid EEBPFACBCBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x25608F0", Offset = "0x255F4F0", VA = "0x1825608F0", Slot = "6")]
	public bool MHCLLKLODIM(Guid EEBPFACBCBO, Task POAKHPIOFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x25603F0", Offset = "0x255EFF0", VA = "0x1825603F0", Slot = "7")]
	public bool KFDAECHHIHL(Guid EEBPFACBCBO, DIBCECFGDBP DFHIPOMCLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x255FEB0", Offset = "0x255EAB0", VA = "0x18255FEB0", Slot = "9")]
	public Task<(DIBCECFGDBP, Task)> BLDPHJALBJK(Guid EEBPFACBCBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2560C50", Offset = "0x255F850", VA = "0x182560C50")]
	private void NIEDKLOONNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2560EC0", Offset = "0x255FAC0", VA = "0x182560EC0")]
	public BELMOMOHJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[Preserve]
internal class IMLOGOCHHIL : KPFCMEICLCB, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MLBLFGNAKBJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly LOJEIMKKAPH OCJHODGDOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly CancellationTokenSource LHFNCMCPHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public readonly CancellationToken PEGLCONNKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private bool OINGCIOLMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private bool KNBPMOOFAFL;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x230C0E0", Offset = "0x230ACE0", VA = "0x18230C0E0")]
		public MLBLFGNAKBJ(LOJEIMKKAPH OCJHODGDOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x230BFB0", Offset = "0x230ABB0", VA = "0x18230BFB0")]
		public void GECCFIHNAEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x230BF80", Offset = "0x230AB80", VA = "0x18230BF80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LGBCGAFDOBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public EBDNMLPHEPO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LGBCGAFDOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2307AC0", Offset = "0x23066C0", VA = "0x182307AC0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct HPBKKCNINEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EBDNMLPHEPO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public IMLOGOCHHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x23013E0", Offset = "0x22FFFE0", VA = "0x1823013E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class HNKAONEEHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HNKAONEEHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2301380", Offset = "0x22FFF80", VA = "0x182301380")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct GHHJHDLILEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IMLOGOCHHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x24C30F0", Offset = "0x24C1CF0", VA = "0x1824C30F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6D0", Offset = "0xEFE2D0", VA = "0x180EFF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CNINJIDNACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public LOJEIMKKAPH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CNINJIDNACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x24BAA90", Offset = "0x24B9690", VA = "0x1824BAA90")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x24BAB20", Offset = "0x24B9720", VA = "0x1824BAB20")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x24BAB60", Offset = "0x24B9760", VA = "0x1824BAB60")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class KEEBGBMNPEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public KEEBGBMNPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2306FB0", Offset = "0x2305BB0", VA = "0x182306FB0")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct GJLJDOALIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public LOJEIMKKAPH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public IMLOGOCHHIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private CNINJIDNACO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x24C3BE0", Offset = "0x24C27E0", VA = "0x1824C3BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private OGHLOEKIGPE BJPFKKMILOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private DGANKCHANBB IHHNOLCJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private AAJJMCHENDJ MJJPCIEJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private OMPCNBNNPKI PIEDOHJPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long HJOIGFHMMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private MLBLFGNAKBJ AEMCADPFGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool PLMLNEJCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private Task LNDLMMDFEJL;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x24CD4E0", Offset = "0x24CC0E0", VA = "0x1824CD4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x24CD290", Offset = "0x24CBE90", VA = "0x1824CD290", Slot = "4")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x24CC840", Offset = "0x24CB440", VA = "0x1824CC840", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x24CCE90", Offset = "0x24CBA90", VA = "0x1824CCE90")]
	[AsyncStateMachine(typeof(HPBKKCNINEO))]
	private Task LKMKHAHLJIH(EBDNMLPHEPO IHOLNOHKICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x24CCC90", Offset = "0x24CB890", VA = "0x1824CCC90")]
	private void KEBAEPCOKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x24CC490", Offset = "0x24CB090", VA = "0x1824CC490")]
	private void ALFFOJADAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x24CC670", Offset = "0x24CB270", VA = "0x1824CC670")]
	private void DIDBGIPIGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x24CCA90", Offset = "0x24CB690", VA = "0x1824CCA90")]
	private bool GHEFODIGLON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x24CD530", Offset = "0x24CC130", VA = "0x1824CD530")]
	[AsyncStateMachine(typeof(GHHJHDLILEH))]
	private void OIELPAHKOKJ(int OFMNEHOBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x24CCFA0", Offset = "0x24CBBA0", VA = "0x1824CCFA0")]
	private void MLIPKLOLFPO(out IDisposable DHHGDBNKCKK, out IDisposable GGFGCGCCDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x24CCB10", Offset = "0x24CB710", VA = "0x1824CCB10")]
	private bool JJNACDHLOLG(LOJEIMKKAPH OCJHODGDOAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x24CC980", Offset = "0x24CB580", VA = "0x1824CC980")]
	[AsyncStateMachine(typeof(GJLJDOALIIO))]
	private Task FDGKCACGLGA(LOJEIMKKAPH OCJHODGDOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x24CD610", Offset = "0x24CC210", VA = "0x1824CD610")]
	public IMLOGOCHHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Preserve]
internal sealed class MPBEOLMFKKM : MGAKGFEBBIF, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct LJDBIBCHCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder<MAKHFKKGMGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public MPBEOLMFKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<MAKHFKKGMGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2308110", Offset = "0x2306D10", VA = "0x182308110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x23082E0", Offset = "0x2306EE0", VA = "0x1823082E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class BDLGPOMLMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public OIOFODEOKJJ message;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public BDLGPOMLMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x22FC210", Offset = "0x22FAE10", VA = "0x1822FC210")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class LEKOELADGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public OIOFODEOKJJ messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LEKOELADGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2307910", Offset = "0x2306510", VA = "0x182307910")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class ELAPKFBEBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ELAPKFBEBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x22FEA50", Offset = "0x22FD650", VA = "0x1822FEA50")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct EIHOHMKGDBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public MPBEOLMFKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<CALJFKKNFDC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x22FE3D0", Offset = "0x22FCFD0", VA = "0x1822FE3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OOKHKOBBPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public OIOFODEOKJJ operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OOKHKOBBPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x23130C0", Offset = "0x2311CC0", VA = "0x1823130C0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct JGPPIODFDAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public OIOFODEOKJJ operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public MPBEOLMFKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private BNJCICCOPAC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2302E70", Offset = "0x2301A70", VA = "0x182302E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct GLHNKFCANEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AsyncTaskMethodBuilder<CALJFKKNFDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public MPBEOLMFKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private BNJCICCOPAC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2300EE0", Offset = "0x22FFAE0", VA = "0x182300EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x23012B0", Offset = "0x22FFEB0", VA = "0x1823012B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class AOPAALGONNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CALJFKKNFDC operation;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public AOPAALGONNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x22FC1A0", Offset = "0x22FADA0", VA = "0x1822FC1A0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct OPHLLOLGIAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public CALJFKKNFDC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public MPBEOLMFKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private global::ECGIJGGMGEF<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2313110", Offset = "0x2311D10", VA = "0x182313110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class NAIGCDPGGNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NAIGCDPGGNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x230DCA0", Offset = "0x230C8A0", VA = "0x18230DCA0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class OBHIBGGKLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OBHIBGGKLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x230F9F0", Offset = "0x230E5F0", VA = "0x18230F9F0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private EOIIFJCKLBI LLPHIJFKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private HFBMNLMFKID HMLOHIIEECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private HIDJNCNCGIE DKLAODPCECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private TaskCompletionSource<MAKHFKKGMGG> KAONJHLAHDO;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x230D100", Offset = "0x230BD00", VA = "0x18230D100", Slot = "7")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x230CB60", Offset = "0x230B760", VA = "0x18230CB60", Slot = "6")]
	[AsyncStateMachine(typeof(LJDBIBCHCOC))]
	public Task<MAKHFKKGMGG> MJJOFMJOFGC(CancellationToken INNAJGEKEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x230CC80", Offset = "0x230B880", VA = "0x18230CC80", Slot = "4")]
	public void MPLECJNMDKI(OIOFODEOKJJ CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x230C820", Offset = "0x230B420", VA = "0x18230C820", Slot = "5")]
	public void KLMJEIFFNDN(OIOFODEOKJJ IHLDPOMCNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x230CFF0", Offset = "0x230BBF0", VA = "0x18230CFF0")]
	[AsyncStateMachine(typeof(EIHOHMKGDBO))]
	private Task NBDIKIHBBJF(OIOFODEOKJJ IMIDEOCLBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x230D1E0", Offset = "0x230BDE0", VA = "0x18230D1E0")]
	[AsyncStateMachine(typeof(JGPPIODFDAO))]
	private Task NLDFNGNNOPI(OIOFODEOKJJ BKHCACPAGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x230C410", Offset = "0x230B010", VA = "0x18230C410")]
	[AsyncStateMachine(typeof(GLHNKFCANEE))]
	private Task<CALJFKKNFDC> DMKAMHKKPCM(OIOFODEOKJJ IMIDEOCLBEC, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x230C7A0", Offset = "0x230B3A0", VA = "0x18230C7A0")]
	private BNJCICCOPAC IOBOOHECMME(OIOFODEOKJJ DAIDKKBHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x230C2E0", Offset = "0x230AEE0", VA = "0x18230C2E0")]
	[AsyncStateMachine(typeof(OPHLLOLGIAN))]
	private Task DKLFHIIFEPC(CALJFKKNFDC DKGDIKDMBMJ, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x230C550", Offset = "0x230B150", VA = "0x18230C550")]
	private CALJFKKNFDC EOADEMFIACO(OIOFODEOKJJ IMIDEOCLBEC, BNJCICCOPAC DIBKODPNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x20286F0", Offset = "0x20272F0", VA = "0x1820286F0")]
	private T HKABBBKEMFK<T>(T KGJOJGIPNPH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x230D340", Offset = "0x230BF40", VA = "0x18230D340")]
	private CALJFKKNFDC POAIADINKGK(OIOFODEOKJJ IMIDEOCLBEC, BNJCICCOPAC DIBKODPNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public MPBEOLMFKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x230D2F0", Offset = "0x230BEF0", VA = "0x18230D2F0")]
	[CompilerGenerated]
	private void NLOGKACDBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[Preserve]
internal sealed class DGNIFDDPFDD : HFBMNLMFKID, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JMLDNIAHKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JMLDNIAHKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x256FA80", Offset = "0x256E680", VA = "0x18256FA80")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class ELGIALHDGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ELGIALHDGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x256C860", Offset = "0x256B460", VA = "0x18256C860")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private PLBABDGAJEK JCHCJAAAPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private MGAKGFEBBIF NLFBPJHPHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private MCHLNCCOLAO GLOBPFGPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private GBFOMELCHAH NOKDOMEMPNM;

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x25662C0", Offset = "0x2564EC0", VA = "0x1825662C0", Slot = "6")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2564FD0", Offset = "0x2563BD0", VA = "0x182564FD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x25658A0", Offset = "0x25644A0", VA = "0x1825658A0", Slot = "4")]
	public HNKDGNJOIAF JMNNGIJKPPP(EBFBPENADOI IMIDEOCLBEC)
	{
		return default(HNKDGNJOIAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2565060", Offset = "0x2563C60", VA = "0x182565060", Slot = "5")]
	public void EDMPKADBEFN(Guid EEBPFACBCBO, Task POAKHPIOFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2566410", Offset = "0x2565010", VA = "0x182566410")]
	private void OMGMOJJGDDK(byte LAAEMPBFKLH, int NDMDCCJKPHO, object LMHCNCKJIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x25646D0", Offset = "0x25632D0", VA = "0x1825646D0")]
	private void APCLPKHDNJI(DMHMKJOBBHG HBJAADBDAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2565570", Offset = "0x2564170", VA = "0x182565570")]
	private void GJDNKGGGFPP(DMHMKJOBBHG HBJAADBDAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x25652B0", Offset = "0x2563EB0", VA = "0x1825652B0")]
	private void GHKFOBDILFG(DMHMKJOBBHG HBJAADBDAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x25664E0", Offset = "0x25650E0", VA = "0x1825664E0")]
	private DIBCECFGDBP OPHBNNFEBFL(OIOFODEOKJJ DAIDKKBHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x25644A0", Offset = "0x25630A0", VA = "0x1825644A0")]
	private void AMBMDFEFIHA(OIOFODEOKJJ BKHCACPAGFI, DIBCECFGDBP DFHIPOMCLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2566000", Offset = "0x2564C00", VA = "0x182566000")]
	private bool MOMHKOPJPKN(OIOFODEOKJJ BKHCACPAGFI, DIBCECFGDBP DFHIPOMCLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2565DB0", Offset = "0x25649B0", VA = "0x182565DB0")]
	private bool JMNNGIJKPPP(OIOFODEOKJJ JAPLOHGBJPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2564D00", Offset = "0x2563900", VA = "0x182564D00")]
	private bool BNOIJLPEIAF(byte LAAEMPBFKLH, ExitGames.Client.Photon.Hashtable HBJAADBDAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public DGNIFDDPFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[Preserve]
internal sealed class IJDGJNCLGEP : ILMKANMNIPM, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class HDIGEILDEOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public MAKHFKKGMGG operationType;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HDIGEILDEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x24C6B40", Offset = "0x24C5740", VA = "0x1824C6B40")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct DHDCPHDJIGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder<DIBCECFGDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public MAKHFKKGMGG operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public IJDGJNCLGEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public JOLEIFGGDHD player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public BLFDLDDAGOG detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private TaskAwaiter<DIBCECFGDBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x24BB880", Offset = "0x24BA480", VA = "0x1824BB880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x24BBE50", Offset = "0x24BAA50", VA = "0x1824BBE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LBJALNGFGKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public MAKHFKKGMGG operationType;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LBJALNGFGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x24CECC0", Offset = "0x24CD8C0", VA = "0x1824CECC0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class GJLKJJPHPDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public MAKHFKKGMGG operationType;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public GJLKJJPHPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x24C4660", Offset = "0x24C3260", VA = "0x1824C4660")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x24C46C0", Offset = "0x24C32C0", VA = "0x1824C46C0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x24C4720", Offset = "0x24C3320", VA = "0x1824C4720")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FFOLDMDEIHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<DIBCECFGDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public MAKHFKKGMGG operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public IJDGJNCLGEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public JOLEIFGGDHD player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public BLFDLDDAGOG detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private GJLKJJPHPDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private HNKDGNJOIAF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private DIBCECFGDBP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<(DIBCECFGDBP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x24C0B40", Offset = "0x24BF740", VA = "0x1824C0B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x24C11B0", Offset = "0x24BFDB0", VA = "0x1824C11B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class NIDOHGAAAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public MAKHFKKGMGG operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NIDOHGAAAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x24D0070", Offset = "0x24CEC70", VA = "0x1824D0070")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private AMIOAAFAKIM PGAKOLNKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private PLBABDGAJEK JCHCJAAAPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private HFBMNLMFKID HMLOHIIEECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x24CC240", Offset = "0x24CAE40", VA = "0x1824CC240", Slot = "5")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x24CC340", Offset = "0x24CAF40", VA = "0x1824CC340", Slot = "4")]
	[AsyncStateMachine(typeof(DHDCPHDJIGJ))]
	public Task<DIBCECFGDBP> ODKCFMCEPAC(JOLEIFGGDHD KJNJAMHHIEJ, MAKHFKKGMGG JCGBPHCGKDK, [CanBeNull] BLFDLDDAGOG IHFIBPGMKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x24CBBF0", Offset = "0x24CA7F0", VA = "0x1824CBBF0")]
	private bool FOGDMDNLLGA(MAKHFKKGMGG JCGBPHCGKDK, out DIBCECFGDBP MIILAJKCKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x24CBAA0", Offset = "0x24CA6A0", VA = "0x1824CBAA0")]
	[AsyncStateMachine(typeof(FFOLDMDEIHA))]
	private Task<DIBCECFGDBP> CAJFIJLFMBJ(JOLEIFGGDHD KJNJAMHHIEJ, MAKHFKKGMGG JCGBPHCGKDK, [CanBeNull] BLFDLDDAGOG IHFIBPGMKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x24CBE90", Offset = "0x24CAA90", VA = "0x1824CBE90")]
	internal EBFBPENADOI KACGIBINCCP(JOLEIFGGDHD KJNJAMHHIEJ, MAKHFKKGMGG JCGBPHCGKDK, [CanBeNull] BLFDLDDAGOG IHFIBPGMKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public IJDGJNCLGEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Preserve]
internal sealed class OPPHKIBMPAK : AMIOAAFAKIM, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct FMIKIKJJLMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder<BGANJHOLFGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public OPPHKIBMPAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter<BLFDLDDAGOG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x49FADB0", Offset = "0x49F99B0", VA = "0x1849FADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x49FB070", Offset = "0x49F9C70", VA = "0x1849FB070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class DNMGDIHDNGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DNMGDIHDNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x49FA620", Offset = "0x49F9220", VA = "0x1849FA620")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct FKEJBABHMLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder<BLFDLDDAGOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public OPPHKIBMPAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public LOJEIMKKAPH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private DNMGDIHDNGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<NAFAOGMLMFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x49FAA40", Offset = "0x49F9640", VA = "0x1849FAA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x49FAD60", Offset = "0x49F9960", VA = "0x1849FAD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class FPLIBFEFJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public FPLIBFEFJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xF01980", Offset = "0xF00580", VA = "0x180F01980")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(JOPMHEMNFAA sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private ODGJFLGBAHF JCCKMOIIHDC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly (EKDIEFBMMGH superRoomData, string unityAssetId, EKDIEFBMMGH subRoomData) PMKKBKGLADF;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x4A00270", Offset = "0x49FEE70", VA = "0x184A00270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A001E0", Offset = "0x49FEDE0", VA = "0x184A001E0", Slot = "8")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x49FF720", Offset = "0x49FE320", VA = "0x1849FF720", Slot = "4")]
	[AsyncStateMachine(typeof(FMIKIKJJLMA))]
	public Task<BGANJHOLFGD> CBJDBDJKLCG(JBHAGEIOKBE JDIFJAIAPMA, LOJEIMKKAPH DIPBFGCEGHE, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A002C0", Offset = "0x49FEEC0", VA = "0x184A002C0")]
	[AsyncStateMachine(typeof(FKEJBABHMLJ))]
	public Task<BLFDLDDAGOG> NNFHHLAHFFH(LOJEIMKKAPH DIPBFGCEGHE, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x49FFD70", Offset = "0x49FE970", VA = "0x1849FFD70", Slot = "5")]
	public BGANJHOLFGD GFMAEJIIEGM(LOJEIMKKAPH DIPBFGCEGHE, BLFDLDDAGOG JNOJAEMLJFC, long JBPDPGIHJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4A000D0", Offset = "0x49FECD0", VA = "0x184A000D0", Slot = "6")]
	public BGANJHOLFGD LLGPBCGHBCC(LOJEIMKKAPH DIPBFGCEGHE, FANOGDNCLMC PGNNAMIGKKM, long JBPDPGIHJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x49FFFE0", Offset = "0x49FEBE0", VA = "0x1849FFFE0", Slot = "7")]
	public BGANJHOLFGD HPBIMDEPNAJ(long AJJICPNHKCG, long JBPDPGIHJEE, string BDBHIODHJDL, string BHLKJEANMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x49FFBC0", Offset = "0x49FE7C0", VA = "0x1849FFBC0")]
	private static BGANJHOLFGD DGBGGNPDEEI(long AJJICPNHKCG, long JBPDPGIHJEE, EKDIEFBMMGH IELCLDABHJL, string BDBHIODHJDL, EKDIEFBMMGH OMJKBNBHODM, string BHLKJEANMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x49FF880", Offset = "0x49FE480", VA = "0x1849FF880")]
	private (EKDIEFBMMGH, string, EKDIEFBMMGH) DAOAEBMBGEA(LOJEIMKKAPH DIPBFGCEGHE, BLFDLDDAGOG JNOJAEMLJFC, long JBPDPGIHJEE)
	{
		return default((EKDIEFBMMGH, string, EKDIEFBMMGH));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public OPPHKIBMPAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[Preserve]
internal sealed class DMOLGOEIEJD : HIDJNCNCGIE, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class JPBBPAFHEAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JPBBPAFHEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2570640", Offset = "0x256F240", VA = "0x182570640")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct IOCDGCOPMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public DMOLGOEIEJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public BNJCICCOPAC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x256EA60", Offset = "0x256D660", VA = "0x18256EA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x256EF20", Offset = "0x256DB20", VA = "0x18256EF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct JCFCPNOEJJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public DMOLGOEIEJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public BNJCICCOPAC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter<PGIFKEEINMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x256EF70", Offset = "0x256DB70", VA = "0x18256EF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x256F470", Offset = "0x256E070", VA = "0x18256F470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class AMNJDBMBMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public AMNJDBMBMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x255ED30", Offset = "0x255D930", VA = "0x18255ED30")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct AFPGCIMJKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public OIOFODEOKJJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public DMOLGOEIEJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public BNJCICCOPAC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private FEFDHDAHEKL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private LLILICEPJBC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<PGIFKEEINMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x255D800", Offset = "0x255C400", VA = "0x18255D800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x255E0E0", Offset = "0x255CCE0", VA = "0x18255E0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private MBHIJCAOJIK IPMGLMHOGEC;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private PGOAKEJNCDN OGFDCDKDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2569490", Offset = "0x2568090", VA = "0x182569490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2569AC0", Offset = "0x25686C0", VA = "0x182569AC0", Slot = "8")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2569540", Offset = "0x2568140", VA = "0x182569540", Slot = "4")]
	[AsyncStateMachine(typeof(IOCDGCOPMPD))]
	public Task<OIOFODEOKJJ> GAJMILPKADN(OIOFODEOKJJ IMIDEOCLBEC, BNJCICCOPAC DIBKODPNCMF, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2569350", Offset = "0x2567F50", VA = "0x182569350", Slot = "5")]
	[AsyncStateMachine(typeof(JCFCPNOEJJG))]
	public Task<OIOFODEOKJJ> CDEGGFGAENN(CancellationToken DHCIMDILIGO, BNJCICCOPAC DIBKODPNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2569A20", Offset = "0x2568620", VA = "0x182569A20", Slot = "6")]
	public IDKMFBPHFLH KMEKNKCOOBH(CALJFKKNFDC KDFNAACPHEI, JBHAGEIOKBE JDIFJAIAPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2569690", Offset = "0x2568290", VA = "0x182569690", Slot = "7")]
	public IDKMFBPHFLH IGLAPKJHLDD(CALJFKKNFDC KDFNAACPHEI, JBHAGEIOKBE JDIFJAIAPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x25698D0", Offset = "0x25684D0", VA = "0x1825698D0")]
	[AsyncStateMachine(typeof(AFPGCIMJKOK))]
	private Task<OIOFODEOKJJ> JIGKOAEBPAG(OIOFODEOKJJ IMIDEOCLBEC, BNJCICCOPAC DIBKODPNCMF, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x23E7650", Offset = "0x23E6250", VA = "0x1823E7650")]
	private static byte[] KJMFJEJKNNC(OIOFODEOKJJ CIJKLAFFGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2569790", Offset = "0x2568390", VA = "0x182569790")]
	private static string JDEIOMOELOJ(byte[] NFEIKMHMJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public DMOLGOEIEJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[Preserve]
internal sealed class IFGIEFPHBKB : PLBABDGAJEK, AKKAPAFENLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private IHOENKGPFEJ EEKGKEFLHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private EOIIFJCKLBI LLPHIJFKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private CPHKMPMDHCN CEOMPJKKFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private OMPCNBNNPKI PIEDOHJPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private FGIJLGCOLAD BPJAGKJOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private AAJJMCHENDJ MJJPCIEJCOI;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x24CB8A0", Offset = "0x24CA4A0", VA = "0x1824CB8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private static DIBCECFGDBP LCAJCPIEEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x24CB500", Offset = "0x24CA100", VA = "0x1824CB500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x24CB6D0", Offset = "0x24CA2D0", VA = "0x1824CB6D0", Slot = "7")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x24CB060", Offset = "0x24C9C60", VA = "0x1824CB060", Slot = "4")]
	public DIBCECFGDBP DNMJPFCEGOF(JOLEIFGGDHD EDPOAPEADPN, MAKHFKKGMGG KJJAPFFOIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x24CB2D0", Offset = "0x24C9ED0", VA = "0x1824CB2D0", Slot = "5")]
	public DIBCECFGDBP FOINKPHHFLL(JOLEIFGGDHD ABMFCAMBJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x24CB510", Offset = "0x24CA110", VA = "0x1824CB510", Slot = "6")]
	public DIBCECFGDBP KPEHMDHIEEI(JOLEIFGGDHD ABMFCAMBJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x24CB8F0", Offset = "0x24CA4F0", VA = "0x1824CB8F0")]
	private static DIBCECFGDBP PCBGLDJEAJE(MHKHNOOKFLJ NLMJDJOMNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public IFGIEFPHBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class DDPBNBACHPC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2563F20", Offset = "0x2562B20", VA = "0x182563F20")]
	public DDPBNBACHPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x978500", Offset = "0x977100", VA = "0x180978500")]
	public DDPBNBACHPC(string CIJKLAFFGJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Preserve]
internal sealed class MDCKBGBNJHE : BLMDICKEGNE, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct NENIFGLEMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<DIBCECFGDBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MDCKBGBNJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public CGDLLLKAEDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private global::ECGIJGGMGEF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private JBHAGEIOKBE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private JBHAGEIOKBE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<DIBCECFGDBP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x230DCF0", Offset = "0x230C8F0", VA = "0x18230DCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x230E370", Offset = "0x230CF70", VA = "0x18230E370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct FLFGHNGHPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public MDCKBGBNJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x22FF030", Offset = "0x22FDC30", VA = "0x1822FF030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct KAECKMDFMIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public MDCKBGBNJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x2304F20", Offset = "0x2303B20", VA = "0x182304F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct MNHFHLJEHJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public MDCKBGBNJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x230C190", Offset = "0x230AD90", VA = "0x18230C190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct LJBGMEPFGBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public MDCKBGBNJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2307B60", Offset = "0x2306760", VA = "0x182307B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct MACOFCMHPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public MDCKBGBNJHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public CGDLLLKAEDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private global::ECGIJGGMGEF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2308C20", Offset = "0x2307820", VA = "0x182308C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private static readonly TimeSpan AEFNLKHMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private OBFGBCOCHIP JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private HIDJNCNCGIE DKLAODPCECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private EOIIFJCKLBI LLPHIJFKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private FGIJLGCOLAD BPJAGKJOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private CancellationTokenSource NFLDHGPJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Task LIHHJMAPJPG;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2309FD0", Offset = "0x2308BD0", VA = "0x182309FD0", Slot = "6")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xFFC6D0", Offset = "0xFFB2D0", VA = "0x180FFC6D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x23097D0", Offset = "0x23083D0", VA = "0x1823097D0", Slot = "4")]
	[AsyncStateMachine(typeof(NENIFGLEMKA))]
	public Task<DIBCECFGDBP> GABOLLHAEOM(CGDLLLKAEDP AIAPLHMBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x23096B0", Offset = "0x23082B0", VA = "0x1823096B0", Slot = "5")]
	[AsyncStateMachine(typeof(FLFGHNGHPOD))]
	public Task DHBKCIPNBKK([Optional] CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xFFC6D0", Offset = "0xFFB2D0", VA = "0x180FFC6D0")]
	public void LELBKEHJNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2309E00", Offset = "0x2308A00", VA = "0x182309E00")]
	private EKPOLADIPIL MBKFAHGFIHG(CGDLLLKAEDP AIAPLHMBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x23098E0", Offset = "0x23084E0", VA = "0x1823098E0")]
	[AsyncStateMachine(typeof(KAECKMDFMIL))]
	private Task KDMMGLEMCOO(GDCLCKJPEAM ELDEGBGONOE, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2309470", Offset = "0x2308070", VA = "0x182309470")]
	[AsyncStateMachine(typeof(MNHFHLJEHJI))]
	private Task AGCBLHPMIBL([Optional] CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2309580", Offset = "0x2308180", VA = "0x182309580")]
	[AsyncStateMachine(typeof(LJBGMEPFGBD))]
	private Task AMLCLMNOBAG(TimeSpan AMPEIINIEIJ, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2309A00", Offset = "0x2308600", VA = "0x182309A00")]
	private Task KHFGIKKOANC(CGDLLLKAEDP AIAPLHMBPNG, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2309CD0", Offset = "0x23088D0", VA = "0x182309CD0")]
	[AsyncStateMachine(typeof(MACOFCMHPFO))]
	private Task LCBKDDLCJPM(CGDLLLKAEDP AIAPLHMBPNG, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x230A170", Offset = "0x2308D70", VA = "0x18230A170")]
	private bool NPKPLPALPHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public MDCKBGBNJHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[Preserve]
internal class PIHMOJKMNJJ : CPHKMPMDHCN, AKKAPAFENLF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct EENMJIHENBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public PIHMOJKMNJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private global::ECGIJGGMGEF<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x49FA6C0", Offset = "0x49F92C0", VA = "0x1849FA6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private FIJENAMILEO IBLFNDOAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private PLBABDGAJEK JCHCJAAAPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private HIDJNCNCGIE DKLAODPCECD;

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4A009C0", Offset = "0x49FF5C0", VA = "0x184A009C0", Slot = "6")]
	public void NEDKCOBOAHP(PPNMJFAJPOL NFAAFLGBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4A007A0", Offset = "0x49FF3A0", VA = "0x184A007A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4A008A0", Offset = "0x49FF4A0", VA = "0x184A008A0", Slot = "5")]
	[AsyncStateMachine(typeof(EENMJIHENBP))]
	public Task LABDFEEMBDF(string ABEDOAAIHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4A00B40", Offset = "0x49FF740", VA = "0x184A00B40", Slot = "4")]
	public DIBCECFGDBP NPKPLPALPHD(JOLEIFGGDHD EDPOAPEADPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4A007C0", Offset = "0x49FF3C0", VA = "0x184A007C0")]
	private GALNAOBABFB EPIOFGEENGM(string ABEDOAAIHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public PIHMOJKMNJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class AEFDKFHEKKH
{
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x255D6C0", Offset = "0x255C2C0", VA = "0x18255D6C0")]
	public static void PPMOPBPLHFH(EAFDIMGMAFM NBELCHPBKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x255D620", Offset = "0x255C220", VA = "0x18255D620")]
	internal static void KCFJBIKENIA(EAFDIMGMAFM NBELCHPBKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x255D2C0", Offset = "0x255BEC0", VA = "0x18255D2C0")]
	internal static void JIMNHMCBPCK(EAFDIMGMAFM NBELCHPBKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x255D360", Offset = "0x255BF60", VA = "0x18255D360")]
	internal static void JNNIHNHCPIG(EAFDIMGMAFM NBELCHPBKDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class FJPGLJCGION : global::BKLFIDPCHLG<OIOFODEOKJJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class KCPNDLJGEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public OIOFODEOKJJ message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public KCPNDLJGEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x24CD820", Offset = "0x24CC420", VA = "0x1824CD820")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly FJPGLJCGION DBFNMCLAAPC;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private const string BIDAILFKEPO = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x24C1FA0", Offset = "0x24C0BA0", VA = "0x1824C1FA0")]
	public ExitGames.Client.Photon.Hashtable CGMPPIJDMHM(OIOFODEOKJJ CIJKLAFFGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x24C2630", Offset = "0x24C1230", VA = "0x1824C2630", Slot = "5")]
	protected override void MCPHAJCNOJE(OIOFODEOKJJ CIJKLAFFGJI, IDictionary<object, object> OAGMKJFIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x24C2020", Offset = "0x24C0C20", VA = "0x1824C2020", Slot = "6")]
	public override OIOFODEOKJJ EFBLDOLKNNC(IDictionary<object, object> OAGMKJFIKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x24C24E0", Offset = "0x24C10E0", VA = "0x1824C24E0")]
	private static void IIAAMKEFCEN(string JKKBPPBNGGI, OIOFODEOKJJ CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x24C27C0", Offset = "0x24C13C0", VA = "0x1824C27C0")]
	public FJPGLJCGION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x24C21C0", Offset = "0x24C0DC0", VA = "0x1824C21C0")]
	[CompilerGenerated]
	internal static string EPKDKAKJADG(BGANJHOLFGD LEPAGINGHFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class DMIAEEAGKOC
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public static DIBCECFGDBP LCAJCPIEEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2568ED0", Offset = "0x2567AD0", VA = "0x182568ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x25692D0", Offset = "0x2567ED0", VA = "0x1825692D0")]
	public static bool MFDJGMMONGJ(this DIBCECFGDBP DFHIPOMCLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x25692F0", Offset = "0x2567EF0", VA = "0x1825692F0")]
	public static DIBCECFGDBP PCBGLDJEAJE(MHKHNOOKFLJ LCPLECGFOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2568D30", Offset = "0x2567930", VA = "0x182568D30")]
	public static DIBCECFGDBP CJIGLMOLNFG(params DIBCECFGDBP[] JKGDFMHBAJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2568F30", Offset = "0x2567B30", VA = "0x182568F30")]
	public static DIBCECFGDBP KFLGOBGNOBM(IEnumerable<DIBCECFGDBP> JKGDFMHBAJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x25690D0", Offset = "0x2567CD0", VA = "0x1825690D0")]
	public static string LDDOEGKMKHB(this DIBCECFGDBP MIILAJKCKHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class HCONBACIEBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public delegate DIBCECFGDBP FJOLHDJDLIK([NotNull] JOLEIFGGDHD ALFGKJHHCCM);

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MBEFKLEKJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public JOLEIFGGDHD photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MBEFKLEKJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x24CFA60", Offset = "0x24CE660", VA = "0x1824CFA60")]
		internal DIBCECFGDBP <Validate>b__0(FJOLHDJDLIK v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	protected readonly HashSet<FJOLHDJDLIK> DEMAGNIABGK;

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x24C6AE0", Offset = "0x24C56E0", VA = "0x1824C6AE0")]
	public void JDPJFOFAPAK(FJOLHDJDLIK GMFCLGBDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x24C68D0", Offset = "0x24C54D0", VA = "0x1824C68D0")]
	public void ECIEDAIFAKK(FJOLHDJDLIK GMFCLGBDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x24C6880", Offset = "0x24C5480", VA = "0x1824C6880", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x24C6930", Offset = "0x24C5530", VA = "0x1824C6930")]
	protected DIBCECFGDBP EPFOANOGOND(JOLEIFGGDHD ABMFCAMBJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x24C1B30", Offset = "0x24C0730", VA = "0x1824C1B30")]
	protected HCONBACIEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class IHOENKGPFEJ : HCONBACIEBN
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class DIHFHJNCGHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DIBCECFGDBP result;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DIHFHJNCGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x24BBEA0", Offset = "0x24BAAA0", VA = "0x1824BBEA0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x24C1B30", Offset = "0x24C0730", VA = "0x1824C1B30")]
	[Preserve]
	public IHOENKGPFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x24CB950", Offset = "0x24CA550", VA = "0x1824CB950")]
	public DIBCECFGDBP LCPLNCCPCFN(JOLEIFGGDHD ABMFCAMBJDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class FIJENAMILEO : HCONBACIEBN
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class HPKJNPEOMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public DIBCECFGDBP result;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HPKJNPEOMHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x24C9520", Offset = "0x24C8120", VA = "0x1824C9520")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x24C1B30", Offset = "0x24C0730", VA = "0x1824C1B30")]
	[Preserve]
	public FIJENAMILEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x24C19E0", Offset = "0x24C05E0", VA = "0x1824C19E0")]
	public DIBCECFGDBP NPKPLPALPHD(JOLEIFGGDHD IOBIGAFBIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum HEKPGMALPIG
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class DIPENCMFLMJ
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class CLHOJIHJDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public global::ECGIJGGMGEF<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CLHOJIHJDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2563930", Offset = "0x2562530", VA = "0x182563930")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public const string FLPFOIHEMKD = "START: ";

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public const string HGPEGBFEFPB = "END: ";

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2568550", Offset = "0x2567150", VA = "0x182568550")]
	public static global::ECGIJGGMGEF<string> JCNABIGHMCG([Optional] string KLPEGNFCKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2568600", Offset = "0x2567200", VA = "0x182568600")]
	private static void LAAFFCFONPB(string KKDEFIFHPNN, PPPLBHFHEDO HHBOJHHPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x25683D0", Offset = "0x2566FD0", VA = "0x1825683D0")]
	private static void AMAJOANFOHG(string KKDEFIFHPNN, PPPLBHFHEDO HHBOJHHPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x25686F0", Offset = "0x25672F0", VA = "0x1825686F0")]
	public static void MAPDLNPEBHM(global::ECGIJGGMGEF<string> HHBOJHHPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x25684B0", Offset = "0x25670B0", VA = "0x1825684B0")]
	public static string FGHBHJMJAGK(OIOFODEOKJJ DAIDKKBHAFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class KGACMDMNDBN
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2307050", Offset = "0x2305C50", VA = "0x182307050")]
	public static void JFNBFKMBJFB(this OBFGBCOCHIP JCCFEHGPDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2307040", Offset = "0x2305C40", VA = "0x182307040")]
	public static void JCIHOKGMABK(this OBFGBCOCHIP JCCFEHGPDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2307060", Offset = "0x2305C60", VA = "0x182307060")]
	private static void LKGFHNIJKEM(this OBFGBCOCHIP JCCFEHGPDHB, bool CBDNKBLBLPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class OGIEIDMLDGC : NILOMKPGNEC, KBMEIJJPDEK, EELPMFGAGPC, BFOEODNPHIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly KBMEIJJPDEK FLNGNIFKCAI;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JOLEIFGGDHD MGJJDKIJJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2310650", Offset = "0x230F250", VA = "0x182310650", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int BMAMGANGKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x23102F0", Offset = "0x230EEF0", VA = "0x1823102F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int MHIFKMMMOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x23102A0", Offset = "0x230EEA0", VA = "0x1823102A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool IIGIKJCGFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int GCIHJCCJHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6B7390", Offset = "0x6B5F90", VA = "0x1806B7390", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event EDEJDAJBION.EAAFDDNJILI ONIJBFCFMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event GALBHAKACJN BDHJKDAJOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2310200", Offset = "0x230EE00", VA = "0x182310200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2310740", Offset = "0x230F340", VA = "0x182310740", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<bool> KNAMOHFHDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<JOLEIFGGDHD> HJBCBDODHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action PBGHKHFLKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x23103E0", Offset = "0x230EFE0", VA = "0x1823103E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x23106A0", Offset = "0x230F2A0", VA = "0x1823106A0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x903C50", Offset = "0x902850", VA = "0x180903C50")]
	public OGIEIDMLDGC(KBMEIJJPDEK FLNGNIFKCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2310340", Offset = "0x230EF40", VA = "0x182310340", Slot = "8")]
	public bool GKAOOHNAALK(byte LAAEMPBFKLH, ExitGames.Client.Photon.Hashtable HBPGEALHKOF, JCOGOKFFNLN DKNDOCDFGLM, SendOptions LMKKDNMFNPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2310480", Offset = "0x230F080", VA = "0x182310480", Slot = "29")]
	public JOLEIFGGDHD ICDHPHMPFLJ(int EDLPNLMBJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2310520", Offset = "0x230F120", VA = "0x182310520", Slot = "16")]
	public JOLEIFGGDHD IGAOIKPFOLE(int IGCOMPFHBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "19")]
	public void MOLCIHDJJGI(object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "20")]
	public void EFOCDIHMONC(object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "21")]
	public void JLDOEHGBKFG(object KJKNLGILOFJ, bool DJKLPNFDCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x23105F0", Offset = "0x230F1F0", VA = "0x1823105F0", Slot = "22")]
	public IDisposable JCCGLKELKDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "23")]
	private bool ECJJIADIENC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "24")]
	public void BHDADJHEGOM(StringBuilder KALKCBPBMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x23107E0", Offset = "0x230F3E0", VA = "0x1823107E0", Slot = "25")]
	public bool OCLMALBKPNB(bool DAHLOEPABNI, out string FJDEDBEGBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	public void OELOCHNPBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x101C1D0", Offset = "0x101ADD0", VA = "0x18101C1D0", Slot = "28")]
	public void OIJABFPNFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct DMHMKJOBBHG
{
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public const string CBJBPCMOLJD = "v_result";

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public const string OPFMLIFFEPO = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly IDictionary<object, object> HBJAADBDAEN;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xBC1190", Offset = "0xBBFD90", VA = "0x180BC1190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
	public DMHMKJOBBHG(IDictionary<object, object> HBJAADBDAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x25689E0", Offset = "0x25675E0", VA = "0x1825689E0")]
	public bool CDMEEELFMPN(out OIOFODEOKJJ CIJKLAFFGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2568C70", Offset = "0x2567870", VA = "0x182568C70")]
	public Guid PACKFKOKLNL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2568B40", Offset = "0x2567740", VA = "0x182568B40")]
	public DIBCECFGDBP GCGDFEGOJML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2568A70", Offset = "0x2567670", VA = "0x182568A70")]
	public static ExitGames.Client.Photon.Hashtable DPFIJBHMAAN(OIOFODEOKJJ CIJKLAFFGJI, DIBCECFGDBP DFHIPOMCLBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class KMNIAICJAPE
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x23076D0", Offset = "0x23062D0", VA = "0x1823076D0")]
	public static string JCFEIGIOALI(this LOJEIMKKAPH MPCEJMHEGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2307650", Offset = "0x2306250", VA = "0x182307650")]
	public static bool ENEICGJPJIG(this LOJEIMKKAPH MPCEJMHEGFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal struct IDIKIKONGIB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct DADGOOMODPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public IDIKIKONGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x24BB310", Offset = "0x24B9F10", VA = "0x1824BB310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly Func<CancellationToken, List<Task>> MOAAOFIELMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly CancellationTokenSource LHFNCMCPHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private Task FFAHJNHCBKN;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x24C97B0", Offset = "0x24C83B0", VA = "0x1824C97B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	internal Task JCLPKHNCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x24C96E0", Offset = "0x24C82E0", VA = "0x1824C96E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x24C97E0", Offset = "0x24C83E0", VA = "0x1824C97E0")]
	public IDIKIKONGIB(Func<CancellationToken, List<Task>> MOAAOFIELMO, CancellationToken DHCIMDILIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x24C95D0", Offset = "0x24C81D0", VA = "0x1824C95D0")]
	[AsyncStateMachine(typeof(DADGOOMODPF))]
	public Task CAPBFJMBABM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x24C9760", Offset = "0x24C8360", VA = "0x1824C9760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class AAJPJGLAHJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly PFOLKOLNBCN KHAEADCEKMF;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private const string OCGJDLFKIFN = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private const string FINDBNGFCFJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private const string BCKEIKDGHDK = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private const string GECKIKLKCNB = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private string KLJJKCALGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private long? BFCNBDAELFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private long? JDPBNCGGLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private MPPELJANMEJ AIADLIEMMLO;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string JJGHKMKHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public long JKFOBHABNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x255C7B0", Offset = "0x255B3B0", VA = "0x18255C7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public long EJFPKIGJDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x255C8F0", Offset = "0x255B4F0", VA = "0x18255C8F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public MPPELJANMEJ BIKPDKDPFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x724850", Offset = "0x723450", VA = "0x180724850")]
		get
		{
			return default(MPPELJANMEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x255C490", Offset = "0x255B090", VA = "0x18255C490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x255CB80", Offset = "0x255B780", VA = "0x18255CB80")]
	[Preserve]
	public AAJPJGLAHJA([CEABMBGCAIH(null)] PFOLKOLNBCN KHAEADCEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x255C330", Offset = "0x255AF30", VA = "0x18255C330")]
	private void CPMCAKHNIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x255C570", Offset = "0x255B170", VA = "0x18255C570")]
	public void HELDAABMMNJ(long FKPMOLLCILH, long JBPDPGIHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x255C800", Offset = "0x255B400", VA = "0x18255C800")]
	public void HPLFHGLMOCJ(string BLNCDBCPKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x255C940", Offset = "0x255B540", VA = "0x18255C940")]
	public void NPGEJLDCLLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class IDKMFBPHFLH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct GKEBIBLNDKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public OIOFODEOKJJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public IDKMFBPHFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<KKACAIKDAEL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x24C4780", Offset = "0x24C3380", VA = "0x1824C4780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x24C4B40", Offset = "0x24C3740", VA = "0x1824C4B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct EHIHJJCEAJM<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class DPMJELPIHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public OIOFODEOKJJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DPMJELPIHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x24BBEF0", Offset = "0x24BAAF0", VA = "0x1824BBEF0")]
		internal OIOFODEOKJJ <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct CHDMFAPNOHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder<KKACAIKDAEL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public OIOFODEOKJJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public IDKMFBPHFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private FEFDHDAHEKL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<KKACAIKDAEL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x24BA380", Offset = "0x24B8F80", VA = "0x1824BA380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x24BA960", Offset = "0x24B9560", VA = "0x1824BA960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct NOCDKNFFCJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public IDKMFBPHFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x24D00D0", Offset = "0x24CECD0", VA = "0x1824D00D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class EKPCIONNCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EKPCIONNCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x24BFFF0", Offset = "0x24BEBF0", VA = "0x1824BFFF0")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class KHCMDAJDIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public KHCMDAJDIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x24CDB80", Offset = "0x24CC780", VA = "0x1824CDB80")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class CFOCOKNDHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CFOCOKNDHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x24BA320", Offset = "0x24B8F20", VA = "0x1824BA320")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class MOHEPFEBFOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MOHEPFEBFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x24D0010", Offset = "0x24CEC10", VA = "0x1824D0010")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class LJLJMKCPOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IDKMFBPHFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LJLJMKCPOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x24CF730", Offset = "0x24CE330", VA = "0x1824CF730")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class NOLIEMMJMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public IDKMFBPHFLH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NOLIEMMJMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x24D0240", Offset = "0x24CEE40", VA = "0x1824D0240")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private static readonly Guid NGNCAOLOGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly CALJFKKNFDC GHGMFFGBFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private readonly PGOAKEJNCDN IHEJFDBKFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private readonly EELPMFGAGPC JCCFEHGPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private readonly BFOEODNPHIO FAHGMDGCJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private bool PFGDLNNBOGD;

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x24CAE80", Offset = "0x24C9A80", VA = "0x1824CAE80")]
	public IDKMFBPHFLH(CALJFKKNFDC DKGDIKDMBMJ, PGOAKEJNCDN IHEJFDBKFDK, EELPMFGAGPC JCCFEHGPDHB, BFOEODNPHIO FAHGMDGCJOE, JBHAGEIOKBE JDIFJAIAPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x24C9C50", Offset = "0x24C8850", VA = "0x1824C9C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x24C9C50", Offset = "0x24C8850", VA = "0x1824C9C50")]
	public void FOPAAIHCMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x24CA8B0", Offset = "0x24C94B0", VA = "0x1824CA8B0")]
	public void LLNMMHHBHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x24CABD0", Offset = "0x24C97D0", VA = "0x1824CABD0")]
	public void PEKDEAGFACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x24CA6E0", Offset = "0x24C92E0", VA = "0x1824CA6E0")]
	[AsyncStateMachine(typeof(GKEBIBLNDKO))]
	internal Task<OIOFODEOKJJ> KNEPLIAPDEN(JBHAGEIOKBE JDIFJAIAPMA, OIOFODEOKJJ DAIDKKBHAFE, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x23E7650", Offset = "0x23E6250", VA = "0x1823E7650")]
	private static byte[] JKNPFBLBDIO<T>(T CIJKLAFFGJI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x201E930", Offset = "0x201D530", VA = "0x18201E930")]
	private static T JDGMICJOLGF<T>(MessageParser<T> BMCNDAEKLCJ, byte[] CIJKLAFFGJI, T LMIGICJAKEF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x24C9E00", Offset = "0x24C8A00", VA = "0x1824C9E00")]
	[AsyncStateMachine(typeof(CHDMFAPNOHD))]
	private Task<KKACAIKDAEL> GILLNAMALFM(OIOFODEOKJJ DAIDKKBHAFE, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC490", Offset = "0x1FAB090", VA = "0x181FAC490")]
	[AsyncStateMachine(typeof(FDDNPPKKPNK))]
	internal Task<T> HLECMNIDGBI<T>(CancellationToken EOJPFFNCEBK, Func<CancellationToken, Task<T>> OADDPANMHHI, int NKDLDPMNBNB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x24C9FB0", Offset = "0x24C8BB0", VA = "0x1824C9FB0")]
	[AsyncStateMachine(typeof(NOCDKNFFCJB))]
	internal Task HLECMNIDGBI(CancellationToken EOJPFFNCEBK, Func<CancellationToken, Task> OADDPANMHHI, int NKDLDPMNBNB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x24CAB40", Offset = "0x24C9740", VA = "0x1824CAB40")]
	public OIOFODEOKJJ NFPEHNKADJC(FEFDHDAHEKL OMJKEHIKJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x24C9BE0", Offset = "0x24C87E0", VA = "0x1824C9BE0")]
	public EHIKAKHANHB BIBMLKIPHGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x24CA840", Offset = "0x24C9440", VA = "0x1824CA840")]
	public OIDFPNEEKNI LCHJJBBBGIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x24CAD00", Offset = "0x24C9900", VA = "0x1824CAD00")]
	public HGLHMPLAEEL PMLKCJEFONM([Optional] IIJAKJLBHOF? INNOMIHIENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x24C9F40", Offset = "0x24C8B40", VA = "0x1824C9F40")]
	public DIKKDKBHEHL GOFOPENGAMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x24C9DD0", Offset = "0x24C89D0", VA = "0x1824C9DD0")]
	public void GHAKFNCNOEN(Func<Guid, bool> APPBMIEBDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x24C9900", Offset = "0x24C8500", VA = "0x1824C9900")]
	public void AGEJBPFGJEN(Func<Guid, bool> FOKJBFMHAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x24CA9E0", Offset = "0x24C95E0", VA = "0x1824CA9E0")]
	public void MEEAJMHOGAJ(Func<Guid, bool> APPBMIEBDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x24CA150", Offset = "0x24C8D50", VA = "0x1824CA150")]
	public Guid IGJFFDFIMPC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x24C9A80", Offset = "0x24C8680", VA = "0x1824C9A80")]
	public void BGFGLJDOKAA(Guid MIJJBKFBNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x24CA5C0", Offset = "0x24C91C0", VA = "0x1824CA5C0")]
	public void JLAFNCFGJPO(OIOFODEOKJJ MLAEKDIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x24CA320", Offset = "0x24C8F20", VA = "0x1824CA320")]
	public void IIAAMKEFCEN(string CCBFGMDEEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x24CA470", Offset = "0x24C9070", VA = "0x1824CA470")]
	public void IIAAMKEFCEN(Func<string> JNFAOAMBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x201E8B0", Offset = "0x201D4B0", VA = "0x18201E8B0")]
	private T HKABBBKEMFK<T>(T KGJOJGIPNPH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x24CA100", Offset = "0x24C8D00", VA = "0x1824CA100")]
	public void IFGDENPBHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2140050", Offset = "0x213EC50", VA = "0x182140050")]
	[CompilerGenerated]
	internal static string KEHDMEOFCGP<T>(byte[] IAIFCDOPKGE, int HHGHKEHOHIF, ref EHIHJJCEAJM<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal sealed class OBCHDDGOEHK : CALJFKKNFDC
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class JCFPPHMJEOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JCFPPHMJEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2302A60", Offset = "0x2301660", VA = "0x182302A60")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct GCKIAJIAHBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public OBCHDDGOEHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private OIDFPNEEKNI <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2300790", Offset = "0x22FF390", VA = "0x182300790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class BOHCOKKMICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public NJJLNGIHBAJ presence;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public BOHCOKKMICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x22FC260", Offset = "0x22FAE60", VA = "0x1822FC260")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private readonly BGANJHOLFGD IKMLHKBAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private readonly LOJEIMKKAPH LOKIINPHGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private readonly AMIOAAFAKIM PGAKOLNKNDB;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private const bool DIHINDBKBJD = false;

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x230F800", Offset = "0x230E400", VA = "0x18230F800")]
	public OBCHDDGOEHK(BGANJHOLFGD IKMLHKBAFME, LOJEIMKKAPH LOKIINPHGDB, Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BNJCICCOPAC OIDFOPMEPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x230F2C0", Offset = "0x230DEC0", VA = "0x18230F2C0", Slot = "8")]
	[AsyncStateMachine(typeof(GCKIAJIAHBJ))]
	protected override Task JPELJDOKJKH(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x230F400", Offset = "0x230E000", VA = "0x18230F400")]
	private NJJLNGIHBAJ KAALDHENEHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x230F180", Offset = "0x230DD80", VA = "0x18230F180")]
	private void FHGFFMDHKBO(NJJLNGIHBAJ DABOPOMBLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x230F720", Offset = "0x230E320", VA = "0x18230F720")]
	private static void PKLOOFELDPC(LOJEIMKKAPH MPCEJMHEGFJ, [Optional] string CIJKLAFFGJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class EKPOLADIPIL : CALJFKKNFDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct MKDHHDANDCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public EKPOLADIPIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<BLFDLDDAGOG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x24CFA90", Offset = "0x24CE690", VA = "0x1824CFA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private readonly int CBHOHNDBPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly CGDLLLKAEDP AIAPLHMBPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public readonly long JMDFDFIKHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public readonly long KBBBBLJHFIH;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x24C0280", Offset = "0x24BEE80", VA = "0x1824C0280")]
	public EKPOLADIPIL(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BNJCICCOPAC OIDFOPMEPDJ, int CBHOHNDBPNN, CGDLLLKAEDP AIAPLHMBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x24C0140", Offset = "0x24BED40", VA = "0x1824C0140", Slot = "8")]
	[AsyncStateMachine(typeof(MKDHHDANDCN))]
	protected override Task JPELJDOKJKH(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal abstract class LOGGENHJPDM : CALJFKKNFDC
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class MIKDIEKJGMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public LOGGENHJPDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public JAHJPJKANIE playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MIKDIEKJGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x230B180", Offset = "0x2309D80", VA = "0x18230B180")]
		internal Task <RunAsync>b__0(JBHAGEIOKBE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x230B1C0", Offset = "0x2309DC0", VA = "0x18230B1C0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct IGILKHNGEIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public LOGGENHJPDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private MIKDIEKJGMI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2301710", Offset = "0x2300310", VA = "0x182301710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct FNKCCGIJLPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public JAHJPJKANIE playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public LOGGENHJPDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x23003C0", Offset = "0x22FEFC0", VA = "0x1823003C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x23089C0", Offset = "0x23075C0", VA = "0x1823089C0")]
	public LOGGENHJPDM(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BNJCICCOPAC OIDFOPMEPDJ, string IPJEMLIFAEI, bool MGCINHFIGJL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2308720", Offset = "0x2307320", VA = "0x182308720", Slot = "8")]
	[AsyncStateMachine(typeof(IGILKHNGEIM))]
	protected override Task JPELJDOKJKH(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task GAEPONMGNMA(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2308860", Offset = "0x2307460", VA = "0x182308860")]
	[AsyncStateMachine(typeof(FNKCCGIJLPN))]
	private Task PEKGKCMCDBD(IDisposable EDANKPBNHFE, JAHJPJKANIE KPOPLFEIPMI, JBHAGEIOKBE HHBOJHHPENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class PGGKMFCFLJM : CALJFKKNFDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct NHPFPKICFML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public PGGKMFCFLJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private DIKKDKBHEHL <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<KCNIOKLNAOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x49FD710", Offset = "0x49FC310", VA = "0x1849FD710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly CGDLLLKAEDP AIAPLHMBPNG;

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4A00710", Offset = "0x49FF310", VA = "0x184A00710")]
	public PGGKMFCFLJM(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BNJCICCOPAC OIDFOPMEPDJ, CGDLLLKAEDP AIAPLHMBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x4A00500", Offset = "0x49FF100", VA = "0x184A00500", Slot = "7")]
	protected override string BEPMJMFHELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4A005D0", Offset = "0x49FF1D0", VA = "0x184A005D0", Slot = "8")]
	[AsyncStateMachine(typeof(NHPFPKICFML))]
	protected override Task JPELJDOKJKH(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal abstract class CALJFKKNFDC : OADNCHGAGFG
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public delegate Task AJPHFNBCGAD(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class CCDGEPKEKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public JBHAGEIOKBE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CALJFKKNFDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CCDGEPKEKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2562630", Offset = "0x2561230", VA = "0x182562630")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private sealed class EIMNLOCONCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public CCDGEPKEKND CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EIMNLOCONCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x256C210", Offset = "0x256AE10", VA = "0x18256C210")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x256C2D0", Offset = "0x256AED0", VA = "0x18256C2D0")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct EODFAJAJKLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CALJFKKNFDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Func<CALJFKKNFDC, JBHAGEIOKBE, IDKMFBPHFLH> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private CCDGEPKEKND <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private IDKMFBPHFLH <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x256C8C0", Offset = "0x256B4C0", VA = "0x18256C8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct JNJPIPACEDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public CALJFKKNFDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x256FAE0", Offset = "0x256E6E0", VA = "0x18256FAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public readonly Guid PMHJABAHEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public readonly ByteString HDICEEMHPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public readonly BNJCICCOPAC HBLKDBMBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	protected readonly string FDGLMLDILHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly bool MGCINHFIGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private bool GPBCPPHKALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public MPPELJANMEJ LMCBECAJAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public MPPELJANMEJ GAKJOHCMGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly Queue<AJPHFNBCGAD> MBPEAEMNFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly AAIEOKMHKNK NOPOINEBGAP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public PPNMJFAJPOL ICGGAJEOGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2561F90", Offset = "0x2560B90", VA = "0x182561F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AEGNJANDAKH IHIAGKKCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2562100", Offset = "0x2560D00", VA = "0x182562100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2562080", Offset = "0x2560C80", VA = "0x182562080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public float AGGEFHFFNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2561B40", Offset = "0x2560740", VA = "0x182561B40", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event OOJMIDCJEKE GLJGLONHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2561F70", Offset = "0x2560B70", VA = "0x182561F70", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2561FE0", Offset = "0x2560BE0", VA = "0x182561FE0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2562150", Offset = "0x2560D50", VA = "0x182562150")]
	protected CALJFKKNFDC(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BNJCICCOPAC OIDFOPMEPDJ, string IPJEMLIFAEI, bool MGCINHFIGJL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2561B00", Offset = "0x2560700", VA = "0x182561B00", Slot = "7")]
	protected virtual string BEPMJMFHELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2561B60", Offset = "0x2560760", VA = "0x182561B60")]
	public void CNCABODMKMJ(AJPHFNBCGAD IJKPBPCDCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2561E10", Offset = "0x2560A10", VA = "0x182561E10")]
	protected void FMJLFLDDHMC(float JJMMEHEHCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2561E30", Offset = "0x2560A30", VA = "0x182561E30")]
	[AsyncStateMachine(typeof(EODFAJAJKLM))]
	public Task GGEBMKLJJKB(CancellationToken DHCIMDILIGO, JBHAGEIOKBE JDIFJAIAPMA, [Optional] Func<CALJFKKNFDC, JBHAGEIOKBE, IDKMFBPHFLH> LMJGFIMFFOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2561BC0", Offset = "0x25607C0", VA = "0x182561BC0")]
	private void FFMKIAFMOAO(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JPELJDOKJKH(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2561CD0", Offset = "0x25608D0", VA = "0x182561CD0")]
	[AsyncStateMachine(typeof(JNJPIPACEDC))]
	private Task FHHAOCEADAM(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2562000", Offset = "0x2560C00", VA = "0x182562000")]
	public OIOFODEOKJJ NFPEHNKADJC(FEFDHDAHEKL OMJKEHIKJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2561A30", Offset = "0x2560630", VA = "0x182561A30")]
	[CompilerGenerated]
	private Task ALNIBHFKDOF(CancellationToken LDKDBEMBOCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal sealed class MAFFBFIMKKF : LOGGENHJPDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct FKHFPNJAJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public MAFFBFIMKKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private KLACFLIEBFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private OIDFPNEEKNI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x22FEAA0", Offset = "0x22FD6A0", VA = "0x1822FEAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly BGANJHOLFGD LGDCHBJMNME;

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x23090A0", Offset = "0x2307CA0", VA = "0x1823090A0")]
	public MAFFBFIMKKF(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BGANJHOLFGD LGDCHBJMNME, BNJCICCOPAC OIDFOPMEPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2308F60", Offset = "0x2307B60", VA = "0x182308F60", Slot = "9")]
	[AsyncStateMachine(typeof(FKHFPNJAJIA))]
	protected override Task GAEPONMGNMA(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class GALNAOBABFB : CALJFKKNFDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct ADECPNOPEDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public GALNAOBABFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private TaskAwaiter<KCNIOKLNAOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x24B88E0", Offset = "0x24B74E0", VA = "0x1824B88E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly string HAKAHKLFCFO;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x24C2A60", Offset = "0x24C1660", VA = "0x1824C2A60")]
	public GALNAOBABFB(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, BNJCICCOPAC OIDFOPMEPDJ, string HAKAHKLFCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x24C2930", Offset = "0x24C1530", VA = "0x1824C2930", Slot = "8")]
	[AsyncStateMachine(typeof(ADECPNOPEDF))]
	protected override Task JPELJDOKJKH(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class AMHONBGLNPE : LOGGENHJPDM
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class IMOLINDJGEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public IMOLINDJGEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private TaskAwaiter<KCNIOKLNAOF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			private TaskAwaiter<OIOFODEOKJJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x2572460", Offset = "0x2571060", VA = "0x182572460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x2572920", Offset = "0x2571520", VA = "0x182572920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AMHONBGLNPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public HGLHMPLAEEL serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public EHIKAKHANHB uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public IMOLINDJGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x256E8E0", Offset = "0x256D4E0", VA = "0x18256E8E0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<OIOFODEOKJJ> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct ANNGMDLLDCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public AMHONBGLNPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private IMOLINDJGEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private KLACFLIEBFG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private OIDFPNEEKNI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x255F190", Offset = "0x255DD90", VA = "0x18255F190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly int EFCLJOKJOGE;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x255ECA0", Offset = "0x255D8A0", VA = "0x18255ECA0")]
	public AMHONBGLNPE(Guid EEBPFACBCBO, PPNMJFAJPOL NFAAFLGBLEA, int EFCLJOKJOGE, BNJCICCOPAC OIDFOPMEPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x255EB60", Offset = "0x255D760", VA = "0x18255EB60", Slot = "9")]
	[AsyncStateMachine(typeof(ANNGMDLLDCD))]
	protected override Task GAEPONMGNMA(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x255E900", Offset = "0x255D500", VA = "0x18255E900")]
	private void BHJADMHJAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x255E9D0", Offset = "0x255D5D0", VA = "0x18255E9D0")]
	private void CJNPPIPGIKG(JBHAGEIOKBE JDIFJAIAPMA, KLACFLIEBFG KOBNNJMHNGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal abstract class FEKKPEDDMLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public readonly CALJFKKNFDC GHGMFFGBFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public readonly IDKMFBPHFLH LDJAGPJBAKJ;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x24C0A60", Offset = "0x24BF660", VA = "0x1824C0A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x24C0A80", Offset = "0x24BF680", VA = "0x1824C0A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x24C0AE0", Offset = "0x24BF6E0", VA = "0x1824C0AE0")]
	protected FEKKPEDDMLJ(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x24C0900", Offset = "0x24BF500", VA = "0x1824C0900")]
	protected void IIAAMKEFCEN(string CCBFGMDEEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x24C07A0", Offset = "0x24BF3A0", VA = "0x1824C07A0")]
	public void IIAAMKEFCEN(Func<string> JNFAOAMBEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct DGIJGOEIFKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public Dictionary<Guid, List<OPHBAEFNEGC>> IABJNEIACPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public Dictionary<Guid, List<OPHBAEFNEGC>> JAMCCLMKMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public Dictionary<Guid, List<OPHBAEFNEGC>> MGLJJLNJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public List<Guid> KAPHFALLNGF;

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2563F60", Offset = "0x2562B60", VA = "0x182563F60")]
	public static DGIJGOEIFKD JHLAPKAGPFG(COFMANBGLKC NOMIILNDOJF, MPPELJANMEJ ANKALEOMKHF, GDCLCKJPEAM BHAGNAIKFEP)
	{
		return default(DGIJGOEIFKD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal struct GEFGCNKKJAA
{
	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0")]
	public static GEFGCNKKJAA DPFIJBHMAAN()
	{
		return default(GEFGCNKKJAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void MEHKGIPHABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NECMKKHFILN(GDCLCKJPEAM OAGMKJFIKKL, object NELKABEIKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LMFANLMDIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal struct NAFAOGMLMFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly BLFDLDDAGOG CLAODPJJBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly JOPMHEMNFAA FIDMHAHALHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly CNAIFAOMEIB LLEHCPJKACI;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x1F87190", Offset = "0x1F85D90", VA = "0x181F87190")]
	public NAFAOGMLMFN(BLFDLDDAGOG CLAODPJJBNJ, JOPMHEMNFAA FIDMHAHALHE, CNAIFAOMEIB LLEHCPJKACI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal struct PNCOGKAHBFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly IDKMFBPHFLH BCMCOHHOGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly Guid MIJJBKFBNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool FCBAHJOHDHB;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4A01280", Offset = "0x49FFE80", VA = "0x184A01280")]
	public static PNCOGKAHBFC IGJFFDFIMPC(IDKMFBPHFLH BCMCOHHOGGA)
	{
		return default(PNCOGKAHBFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x120CA50", Offset = "0x120B650", VA = "0x18120CA50")]
	public void BPDHDFOPJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x4A01170", Offset = "0x49FFD70", VA = "0x184A01170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x4A012E0", Offset = "0x49FFEE0", VA = "0x184A012E0")]
	private PNCOGKAHBFC(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x4A01170", Offset = "0x49FFD70", VA = "0x184A01170")]
	private void BGFGLJDOKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4A011D0", Offset = "0x49FFDD0", VA = "0x184A011D0")]
	private Func<Guid, bool> ICENJEGHOBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class OIDFPNEEKNI : FEKKPEDDMLJ, OADNCHGAGFG
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public delegate Task<MPPELJANMEJ> OAMNNJJFPBM(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM DCIHAKIGOAM, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct GONEPJJCDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public BGANJHOLFGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private PNCOGKAHBFC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x49FB350", Offset = "0x49F9F50", VA = "0x1849FB350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CLFCAMOMEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public BGANJHOLFGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private JBHAGEIOKBE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x22FC390", Offset = "0x22FAF90", VA = "0x1822FC390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x22FC640", Offset = "0x22FB240", VA = "0x1822FC640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct KNIKBAFMBML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public BGANJHOLFGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private JBHAGEIOKBE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x49FBD30", Offset = "0x49FA930", VA = "0x1849FBD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class NDBIJJIKJPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public AsyncTaskMethodBuilder<NAFAOGMLMFN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public NDBIJJIKJPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			private NAFAOGMLMFN <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			private TaskAwaiter<MPPELJANMEJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			private TaskAwaiter<NAFAOGMLMFN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x4A01330", Offset = "0x49FFF30", VA = "0x184A01330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x4A019B0", Offset = "0x4A005B0", VA = "0x184A019B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public AsyncTaskMethodBuilder<GDCLCKJPEAM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public NDBIJJIKJPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			private GDCLCKJPEAM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private TaskAwaiter<MPPELJANMEJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			private TaskAwaiter<GDCLCKJPEAM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x4A01A00", Offset = "0x4A00600", VA = "0x184A01A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x4A01E80", Offset = "0x4A00A80", VA = "0x184A01E80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public NDBIJJIKJPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			private TaskAwaiter<MPPELJANMEJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private MKJIIPEGDMM <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x4A01ED0", Offset = "0x4A00AD0", VA = "0x184A01ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public BGANJHOLFGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AAIEOKMHKNK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public AAIEOKMHKNK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public NAFAOGMLMFN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public AAIEOKMHKNK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public GDCLCKJPEAM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public HJOPDMNBNCH.POHFIKBKBLB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NDBIJJIKJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x49FD140", Offset = "0x49FBD40", VA = "0x1849FD140")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task<NAFAOGMLMFN> <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x49FD260", Offset = "0x49FBE60", VA = "0x1849FD260")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<GDCLCKJPEAM> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x49FD4B0", Offset = "0x49FC0B0", VA = "0x1849FD4B0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x49FD390", Offset = "0x49FBF90", VA = "0x1849FD390")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct ACGOKBIHBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public BGANJHOLFGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private NDBIJJIKJPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<NAFAOGMLMFN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private TaskAwaiter<GDCLCKJPEAM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x22FB200", Offset = "0x22F9E00", VA = "0x1822FB200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct NAPFNLFHJPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x49FC900", Offset = "0x49FB500", VA = "0x1849FC900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct MKAIAHLDEAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private JBHAGEIOKBE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x49FC3E0", Offset = "0x49FAFE0", VA = "0x1849FC3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct FLMDGKKJKNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private JBHAGEIOKBE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private KJDLCGNMOGL.HPBPPBFHINB <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter<KJDLCGNMOGL.HPBPPBFHINB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x22FF620", Offset = "0x22FE220", VA = "0x1822FF620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2300370", Offset = "0x22FEF70", VA = "0x182300370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct CLOKJPBNELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public MKJIIPEGDMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private JBHAGEIOKBE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x22FC900", Offset = "0x22FB500", VA = "0x1822FC900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x22FD6C0", Offset = "0x22FC2C0", VA = "0x1822FD6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct ONEBHBAMHEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public MPPELJANMEJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public GDCLCKJPEAM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x49FF3E0", Offset = "0x49FDFE0", VA = "0x1849FF3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x49FF580", Offset = "0x49FE180", VA = "0x1849FF580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class CDFJMDMAOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public OAMNNJJFPBM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public MKJIIPEGDMM timedYielder;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CDFJMDMAOGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class IBNKPCGMGGE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public IBNKPCGMGGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter<MPPELJANMEJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x4A02C10", Offset = "0x4A01810", VA = "0x184A02C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x4A030F0", Offset = "0x4A01CF0", VA = "0x184A030F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public MPPELJANMEJ originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CDFJMDMAOGP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public IBNKPCGMGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x49FBA40", Offset = "0x49FA640", VA = "0x1849FBA40")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MPPELJANMEJ> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct KPPHJKAJIIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public OAMNNJJFPBM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public MKJIIPEGDMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x49FBF70", Offset = "0x49FAB70", VA = "0x1849FBF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x49FC390", Offset = "0x49FAF90", VA = "0x1849FC390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct NCBEGHMKKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AAIEOKMHKNK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private MPPELJANMEJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private IEnumerator<MPPELJANMEJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x49FCDF0", Offset = "0x49FB9F0", VA = "0x1849FCDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct AEHHGKKLKAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x22FBBD0", Offset = "0x22FA7D0", VA = "0x1822FBBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct JFFIKALPFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public AsyncTaskMethodBuilder<KJDLCGNMOGL.HPBPPBFHINB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public OIDFPNEEKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter<KJDLCGNMOGL.HPBPPBFHINB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x49FBB70", Offset = "0x49FA770", VA = "0x1849FBB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x49FBCE0", Offset = "0x49FA8E0", VA = "0x1849FBCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class CLOFKHGMLGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public BLFDLDDAGOG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CLOFKHGMLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x22FC690", Offset = "0x22FB290", VA = "0x1822FC690")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private readonly ODJMLBBJHBE BFJEHKMGBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly ODJMLBBJHBE IDEGAPHLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly AAJPJGLAHJA NDMOJPMMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private readonly EGEHGHCFMEH FGPJHJGFADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private readonly CBLJGAJHHBL DCKEOEELMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly CJLNBKFABKE EJOJGICAHEK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public float AGGEFHFFNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2310D50", Offset = "0x230F950", VA = "0x182310D50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private PPNMJFAJPOL ICGGAJEOGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x23114D0", Offset = "0x23100D0", VA = "0x1823114D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OOJMIDCJEKE GLJGLONHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2311500", Offset = "0x2310100", VA = "0x182311500", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x23125C0", Offset = "0x23111C0", VA = "0x1823125C0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2312740", Offset = "0x2311340", VA = "0x182312740")]
	public OIDFPNEEKNI(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x23125E0", Offset = "0x23111E0", VA = "0x1823125E0")]
	[AsyncStateMachine(typeof(GONEPJJCDJA))]
	public Task OAKIOJMIPEA(BGANJHOLFGD IMIDEOCLBEC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2311920", Offset = "0x2310520", VA = "0x182311920")]
	[AsyncStateMachine(typeof(CLFCAMOMEKD))]
	private Task<OIOFODEOKJJ> IFIICFLFIFE(BGANJHOLFGD IMIDEOCLBEC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2312020", Offset = "0x2310C20", VA = "0x182312020")]
	[AsyncStateMachine(typeof(KNIKBAFMBML))]
	private Task KHCOIKLLEGJ(BGANJHOLFGD IMIDEOCLBEC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x23110B0", Offset = "0x230FCB0", VA = "0x1823110B0")]
	[AsyncStateMachine(typeof(ACGOKBIHBJF))]
	private Task EGENBGPPPID(BGANJHOLFGD IMIDEOCLBEC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken GMLHAILOPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2311D90", Offset = "0x2310990", VA = "0x182311D90")]
	[AsyncStateMachine(typeof(NAPFNLFHJPM))]
	private Task JJBNMIFHMPI(JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2311EC0", Offset = "0x2310AC0", VA = "0x182311EC0")]
	[AsyncStateMachine(typeof(MKAIAHLDEAB))]
	private Task JKCPOOFDAKP(GDCLCKJPEAM OAGMKJFIKKL, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2312330", Offset = "0x2310F30", VA = "0x182312330")]
	[AsyncStateMachine(typeof(FLMDGKKJKNO))]
	private Task<MPPELJANMEJ> MKCEMJMGFFG(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2311A80", Offset = "0x2310680", VA = "0x182311A80")]
	[AsyncStateMachine(typeof(CLOKJPBNELM))]
	private Task<MPPELJANMEJ> IOOKPOILEAE(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2310E00", Offset = "0x230FA00", VA = "0x182310E00")]
	[AsyncStateMachine(typeof(ONEBHBAMHEA))]
	private Task<MPPELJANMEJ> ECMAEONAFDC(MPPELJANMEJ ANKALEOMKHF, GDCLCKJPEAM BHAGNAIKFEP, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO, bool NKJNLDMGBBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x23113E0", Offset = "0x230FFE0", VA = "0x1823113E0")]
	private bool FKEHGFILFNL(GDCLCKJPEAM PMBLJOJMPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2312170", Offset = "0x2310D70", VA = "0x182312170")]
	[AsyncStateMachine(typeof(KPPHJKAJIIH))]
	protected Task<MPPELJANMEJ> LFDGEKGABEB(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO, OAMNNJJFPBM IBBDPOIPENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x23117C0", Offset = "0x23103C0", VA = "0x1823117C0")]
	[AsyncStateMachine(typeof(NCBEGHMKKHO))]
	private Task HKAJPKMCDGD(GDCLCKJPEAM OAGMKJFIKKL, AAIEOKMHKNK IMPMDIGKPAC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2310D70", Offset = "0x230F970", VA = "0x182310D70")]
	private void DIEABCEFLFM(MPPELJANMEJ DCPFOJINCLO, AAIEOKMHKNK IMPMDIGKPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2310DC0", Offset = "0x230F9C0", VA = "0x182310DC0")]
	private void DLMLCICLJDL(MPPELJANMEJ NPLLGALPAFN, out MPPELJANMEJ PIDBDMJEPKL, out MPPELJANMEJ FFONPEOEPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2311D50", Offset = "0x2310950", VA = "0x182311D50")]
	private Task<NAFAOGMLMFN> JHAMBIIMOGH(BGANJHOLFGD IMIDEOCLBEC, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2311390", Offset = "0x230FF90", VA = "0x182311390")]
	private Task<GDCLCKJPEAM> FJDMALPLIGA(BGANJHOLFGD IMIDEOCLBEC, NAFAOGMLMFN OAGMKJFIKKL, HJOPDMNBNCH.POHFIKBKBLB PGEOAJLHBCG, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2311520", Offset = "0x2310120", VA = "0x182311520")]
	[AsyncStateMachine(typeof(AEHHGKKLKAB))]
	private Task HFGBGLEFMAG(GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2312490", Offset = "0x2311090", VA = "0x182312490")]
	[AsyncStateMachine(typeof(JFFIKALPFOA))]
	private Task<KJDLCGNMOGL.HPBPPBFHINB> MNKOHAEALIO(GDCLCKJPEAM OAGMKJFIKKL, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2312300", Offset = "0x2310F00", VA = "0x182312300")]
	private Task LJHKKFBAEIM(GDCLCKJPEAM OAGMKJFIKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2311BF0", Offset = "0x23107F0", VA = "0x182311BF0")]
	private Task JBLKFEFJIPL(GDCLCKJPEAM OAGMKJFIKKL, KJDLCGNMOGL.HPBPPBFHINB KAAPKPMMFOI, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x23117A0", Offset = "0x23103A0", VA = "0x1823117A0")]
	private Task HJFEAKIEKMN(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x23111F0", Offset = "0x230FDF0", VA = "0x1823111F0")]
	private Task ELAMDEDDHPD(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230C2F0", VA = "0x18230D6F0")]
	private static Task IMNKCHLAOLL(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2312720", Offset = "0x2311320", VA = "0x182312720")]
	private Task PLLGNOIGMPC(GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2310F70", Offset = "0x230FB70", VA = "0x182310F70")]
	private Task ECNEKGFJEMC(GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2311360", Offset = "0x230FF60", VA = "0x182311360")]
	private void FBAKKLBJCBC(BGANJHOLFGD IMIDEOCLBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2311670", Offset = "0x2310270", VA = "0x182311670")]
	private static void HGNBCGEPDAG(BLFDLDDAGOG CLAODPJJBNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal struct KJDLCGNMOGL
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public struct HPBPPBFHINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public readonly Dictionary<int, int> JDIJFMIGJPI;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x72D470", Offset = "0x72C070", VA = "0x18072D470")]
		public HPBPPBFHINB(Dictionary<int, int> JDIJFMIGJPI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private MPPELJANMEJ DCPFOJINCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private GDCLCKJPEAM OAGMKJFIKKL;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x23074B0", Offset = "0x23060B0", VA = "0x1823074B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2307500", Offset = "0x2306100", VA = "0x182307500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2307160", Offset = "0x2305D60", VA = "0x182307160")]
	public static Task<HPBPPBFHINB> GGEBMKLJJKB(PPNMJFAJPOL NFAAFLGBLEA, MPPELJANMEJ DCPFOJINCLO, GDCLCKJPEAM OAGMKJFIKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2307210", Offset = "0x2305E10", VA = "0x182307210")]
	private HPBPPBFHINB GGEBMKLJJKB()
	{
		return default(HPBPPBFHINB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct MPDMCKHLJPH
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x230D6F0", Offset = "0x230C2F0", VA = "0x18230D6F0")]
	public static Task GGEBMKLJJKB(CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal struct MJLHCHBKEHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct LKIHBKINHPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private JBHAGEIOKBE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2308330", Offset = "0x2306F30", VA = "0x182308330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x230B230", Offset = "0x2309E30", VA = "0x18230B230")]
	[AsyncStateMachine(typeof(LKIHBKINHPC))]
	public static Task GGEBMKLJJKB(IDKMFBPHFLH BCMCOHHOGGA, GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal struct NJAMPLHNFDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct OOCOOCFOGFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public MKJIIPEGDMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private MPPELJANMEJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private PPNMJFAJPOL <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private COFMANBGLKC <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private List<(PersistenceView, INMIAOPIAHL)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private INMIAOPIAHL <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x23129D0", Offset = "0x23115D0", VA = "0x1823129D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x230E620", Offset = "0x230D220", VA = "0x18230E620")]
	[AsyncStateMachine(typeof(OOCOOCFOGFG))]
	public static Task GGEBMKLJJKB(IDKMFBPHFLH BCMCOHHOGGA, GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x230E3F0", Offset = "0x230CFF0", VA = "0x18230E3F0")]
	private static void CCHFLMJIDJM(PersistenceView FJAGFNGNGHD, INMIAOPIAHL NELKABEIKEE, GDCLCKJPEAM OAGMKJFIKKL, MPPELJANMEJ ANKALEOMKHF, bool OMEAPEBGJEK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct OEOBENCDKAD
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x230FFE0", Offset = "0x230EBE0", VA = "0x18230FFE0")]
	public static Task GGEBMKLJJKB(PPNMJFAJPOL NFAAFLGBLEA, GDCLCKJPEAM OAGMKJFIKKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal struct EHLCPPDFAMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct JNFMDAJJJBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public PPNMJFAJPOL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public MPPELJANMEJ roomOperationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x24CD690", Offset = "0x24CC290", VA = "0x1824CD690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct ACAINMJJDBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public EHLCPPDFAMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x24B8040", Offset = "0x24B6C40", VA = "0x1824B8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class FOAFAHCIOJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public IBEKIDLIIJK version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public FOAFAHCIOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x24C2800", Offset = "0x24C1400", VA = "0x1824C2800")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x24C28B0", Offset = "0x24C14B0", VA = "0x1824C28B0")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private MPPELJANMEJ DCPFOJINCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private GDCLCKJPEAM OAGMKJFIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private IDKMFBPHFLH BCMCOHHOGGA;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private static readonly ByteString HMIPDNCLHLA;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x24BC600", Offset = "0x24BB200", VA = "0x1824BC600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private HOHBAPJJNFL IDHEMLDILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x24BC650", Offset = "0x24BB250", VA = "0x1824BC650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x24BC470", Offset = "0x24BB070", VA = "0x1824BC470")]
	[AsyncStateMachine(typeof(JNFMDAJJJBM))]
	public static Task GGEBMKLJJKB(PPNMJFAJPOL NFAAFLGBLEA, MPPELJANMEJ DCPFOJINCLO, GDCLCKJPEAM OAGMKJFIKKL, IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x24BC320", Offset = "0x24BAF20", VA = "0x1824BC320")]
	[AsyncStateMachine(typeof(ACAINMJJDBJ))]
	private Task GGEBMKLJJKB(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x24BC6D0", Offset = "0x24BB2D0", VA = "0x1824BC6D0")]
	private void PNMOPLPEEGJ([NotNull] IMCGHCNINDK GHAFIGHOENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x24BC5D0", Offset = "0x24BB1D0", VA = "0x1824BC5D0")]
	private bool IELMGGKLFHI(IBEKIDLIIJK MAAFFLODELA, IMCGHCNINDK GHAFIGHOENJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct MEGENBMIAOL
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private struct EHEDAGNGLAA<Arg, Parsed> where Parsed : IMessage<Parsed>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private readonly global::EKHPIODOJLB<Arg> JPOFOCLBBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private readonly global::OKFPODNJLBF<Parsed> BMCNDAEKLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private readonly global::NBOFLKFDDDB<Parsed> KKMAFGKDPPL;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x611540", Offset = "0x610140", VA = "0x180611540")]
		public EHEDAGNGLAA(global::EKHPIODOJLB<Arg> JPOFOCLBBPG, global::OKFPODNJLBF<Parsed> BMCNDAEKLCJ, global::NBOFLKFDDDB<Parsed> KKMAFGKDPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x42FB520", Offset = "0x42FA120", VA = "0x1842FB520")]
		[AsyncStateMachine(typeof(PALDKMLHHPL))]
		public Task<Parsed> FJPCFGFBIOG(Arg NFEIKMHMJPL, string GJHJPMMKEBL, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x42FBBE0", Offset = "0x42FA7E0", VA = "0x1842FBBE0")]
		[AsyncStateMachine(typeof(EHBCNGBIHPN))]
		private Task<byte[]> JPNKNMCBHCI(Arg NFEIKMHMJPL, CancellationToken DHCIMDILIGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x42FC100", Offset = "0x42FAD00", VA = "0x1842FC100")]
		private Parsed LCDAHADIGII(byte[] BIAGPIMODMH)
		{
			return (Parsed)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct DIHOLHFFFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder<GDCLCKJPEAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public MEGENBMIAOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public HJOPDMNBNCH.POHFIKBKBLB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private JBHAGEIOKBE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter<(MLOEENCGLIC, IMCGHCNINDK, CNHLEBKEOPK, NCBCDBMIEPK)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x22FD710", Offset = "0x22FC310", VA = "0x1822FD710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x22FDE20", Offset = "0x22FCA20", VA = "0x1822FDE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct KBLGLBJKCLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder<MLOEENCGLIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public JBHAGEIOKBE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public MEGENBMIAOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public HJOPDMNBNCH.POHFIKBKBLB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private JBHAGEIOKBE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<MLOEENCGLIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2306370", Offset = "0x2304F70", VA = "0x182306370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x23067B0", Offset = "0x23053B0", VA = "0x1823067B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private DIFANGKMMOP OFGMNMEGPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private EHEDAGNGLAA<EKDIEFBMMGH, IMCGHCNINDK> FIDMHAHALHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private EHEDAGNGLAA<EKDIEFBMMGH, CNHLEBKEOPK> DIADFNBNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private EHEDAGNGLAA<long, NCBCDBMIEPK> OPOFLJEDMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private BGANJHOLFGD IMIDEOCLBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private BLFDLDDAGOG CLAODPJJBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private JOPMHEMNFAA NOCNPDBIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private long LEKONKDGCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private JBHAGEIOKBE HHBOJHHPENA;

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x230A6D0", Offset = "0x23092D0", VA = "0x18230A6D0")]
	public static Task<GDCLCKJPEAM> OLOEOJPDIKH(PPNMJFAJPOL NFAAFLGBLEA, BGANJHOLFGD IMIDEOCLBEC, in NAFAOGMLMFN OAGMKJFIKKL, HJOPDMNBNCH.POHFIKBKBLB PGEOAJLHBCG, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x230A330", Offset = "0x2308F30", VA = "0x18230A330")]
	[AsyncStateMachine(typeof(DIHOLHFFFNL))]
	private Task<GDCLCKJPEAM> GGEBMKLJJKB(HJOPDMNBNCH.POHFIKBKBLB PGEOAJLHBCG, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x230A690", Offset = "0x2309290", VA = "0x18230A690")]
	private EKDIEFBMMGH OIJCCGOAGBB(IPKJAJKKGFP EHPCBBBCICC)
	{
		return default(EKDIEFBMMGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x230A4D0", Offset = "0x23090D0", VA = "0x18230A4D0")]
	[AsyncStateMachine(typeof(KBLGLBJKCLG))]
	private Task<MLOEENCGLIC> HOIMIMAABED(string BDBHIODHJDL, long LEKONKDGCIB, HJOPDMNBNCH.POHFIKBKBLB PGEOAJLHBCG, JBHAGEIOKBE HAPLABCJHOJ, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal struct HKDFJOCBAOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct NPGOCACJOKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public AsyncTaskMethodBuilder<NAFAOGMLMFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public HKDFJOCBAOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private JBHAGEIOKBE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<NAFAOGMLMFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x24D04A0", Offset = "0x24CF0A0", VA = "0x1824D04A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x24D0870", Offset = "0x24CF470", VA = "0x1824D0870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct EBFEFOEADMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AsyncTaskMethodBuilder<NAFAOGMLMFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public HKDFJOCBAOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter<NAFAOGMLMFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x24BBFE0", Offset = "0x24BABE0", VA = "0x1824BBFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x24BC2D0", Offset = "0x24BAED0", VA = "0x1824BC2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class FNPIKCOCODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public FNPIKCOCODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xF01980", Offset = "0xF00580", VA = "0x180F01980")]
		internal bool <FetchRoomDetails>b__0(JOPMHEMNFAA sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct LBIKFGAEEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public AsyncTaskMethodBuilder<NAFAOGMLMFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public COFMANBGLKC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private FNPIKCOCODH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter<BLFDLDDAGOG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x24CE830", Offset = "0x24CD430", VA = "0x1824CE830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x24CEC70", Offset = "0x24CD870", VA = "0x1824CEC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private AAJPJGLAHJA NDMOJPMMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private JBHAGEIOKBE HHBOJHHPENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private long FKPMOLLCILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private long JBPDPGIHJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private string OKACHMABJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private EKDIEFBMMGH NAPJICMMLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private EKDIEFBMMGH NAMJMBJALJH;

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x24C9170", Offset = "0x24C7D70", VA = "0x1824C9170")]
	public static Task<NAFAOGMLMFN> OLOEOJPDIKH(PPNMJFAJPOL NFAAFLGBLEA, BGANJHOLFGD IMIDEOCLBEC, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x24C8D30", Offset = "0x24C7930", VA = "0x1824C8D30")]
	[AsyncStateMachine(typeof(NPGOCACJOKI))]
	private Task<NAFAOGMLMFN> GGEBMKLJJKB(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x24C8E70", Offset = "0x24C7A70", VA = "0x1824C8E70")]
	[AsyncStateMachine(typeof(EBFEFOEADMP))]
	private Task<NAFAOGMLMFN> JHAMBIIMOGH(long FKPMOLLCILH, long JBPDPGIHJEE, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO, bool CDKPHDLFHEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x24C8FF0", Offset = "0x24C7BF0", VA = "0x1824C8FF0")]
	[AsyncStateMachine(typeof(LBIKFGAEEBK))]
	public static Task<NAFAOGMLMFN> JHAMBIIMOGH(COFMANBGLKC NOMIILNDOJF, long FKPMOLLCILH, long JBPDPGIHJEE, CancellationToken DHCIMDILIGO, JBHAGEIOKBE JDIFJAIAPMA, bool CDKPHDLFHEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x24C9140", Offset = "0x24C7D40", VA = "0x1824C9140")]
	private void NCCALEIFBBK(BLFDLDDAGOG CLAODPJJBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x24C8BC0", Offset = "0x24C77C0", VA = "0x1824C8BC0")]
	private bool DAJLMGBFIJG(NAFAOGMLMFN OAGMKJFIKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x24C8A60", Offset = "0x24C7660", VA = "0x1824C8A60")]
	private void ADMHHFGGJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct ABODDONLPPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct MEPOOHLAOPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public ABODDONLPPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x25710A0", Offset = "0x256FCA0", VA = "0x1825710A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private const int EKAJHJGIPGB = 20;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private const float AJNBHAFDPDL = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private COFMANBGLKC NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private GDCLCKJPEAM OAGMKJFIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private JBHAGEIOKBE HHBOJHHPENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private float JNEELOPCEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private float IAKFLHDIEIE;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x255D0F0", Offset = "0x255BCF0", VA = "0x18255D0F0")]
	public static Task NIFCNDJHHOB(PPNMJFAJPOL NFAAFLGBLEA, GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x255CFD0", Offset = "0x255BBD0", VA = "0x18255CFD0")]
	[AsyncStateMachine(typeof(MEPOOHLAOPA))]
	public Task GGEBMKLJJKB(CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x255CE60", Offset = "0x255BA60", VA = "0x18255CE60")]
	private static void EJGLOPKFFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x255CCE0", Offset = "0x255B8E0", VA = "0x18255CCE0")]
	private void ECHNFNMPCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x255CC20", Offset = "0x255B820", VA = "0x18255CC20")]
	private static float DKHKIDKOANF(COFMANBGLKC NOMIILNDOJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x255D2A0", Offset = "0x255BEA0", VA = "0x18255D2A0")]
	private static float NJKOONHLNBC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct MAJLDOMHIGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct IMADGNJILAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public IDKMFBPHFLH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public KJDLCGNMOGL.HPBPPBFHINB mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private CALJFKKNFDC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private PPNMJFAJPOL <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private MKFMFFICEEI.JIPHNEGKDGO <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2301D50", Offset = "0x2300950", VA = "0x182301D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct GFALGKICAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private LBNBOIDEHJA.FEDFLKDJCGF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x2300C70", Offset = "0x22FF870", VA = "0x182300C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2309140", Offset = "0x2307D40", VA = "0x182309140")]
	[AsyncStateMachine(typeof(IMADGNJILAI))]
	public static Task GGEBMKLJJKB(IDKMFBPHFLH BCMCOHHOGGA, GDCLCKJPEAM OAGMKJFIKKL, KJDLCGNMOGL.HPBPPBFHINB KAAPKPMMFOI, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2309380", Offset = "0x2307F80", VA = "0x182309380")]
	private static Task<OIOFODEOKJJ> PCNPLGPLGEC(IDKMFBPHFLH BCMCOHHOGGA, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x23092A0", Offset = "0x2307EA0", VA = "0x1823092A0")]
	[AsyncStateMachine(typeof(GFALGKICAIG))]
	private static Task NKHMAMLADFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct KDICJNOCILC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct JAMNPDHPPFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public KDICJNOCILC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x2302650", Offset = "0x2301250", VA = "0x182302650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class JKBOPBEJIPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JKBOPBEJIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x2303670", Offset = "0x2302270", VA = "0x182303670")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct MPLLHMDAPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public KDICJNOCILC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private OBEAAGHBMLA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x230D7E0", Offset = "0x230C3E0", VA = "0x18230D7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private bool LFFCBKIHNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private JBHAGEIOKBE HHBOJHHPENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private CancellationToken DHCIMDILIGO;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2306F30", Offset = "0x2305B30", VA = "0x182306F30")]
	public static Task JBBAMGCHGLA(PPNMJFAJPOL NFAAFLGBLEA, bool LFFCBKIHNHH, JBHAGEIOKBE HHBOJHHPENA, CancellationToken JDLIIJLKELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2306E30", Offset = "0x2305A30", VA = "0x182306E30")]
	[AsyncStateMachine(typeof(JAMNPDHPPFL))]
	private Task GGEBMKLJJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2306D00", Offset = "0x2305900", VA = "0x182306D00")]
	[AsyncStateMachine(typeof(MPLLHMDAPHI))]
	private Task CNIODDIOMCI(bool GNDDOCBJFAF, string LNDJJHKPJBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0")]
	private bool INHPDAGFIJC(bool LFFCBKIHNHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal struct CIMGNNINHIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct BJOPOFPBPNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CIMGNNINHIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x2561360", Offset = "0x255FF60", VA = "0x182561360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x2561600", Offset = "0x2560200", VA = "0x182561600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class CBICAEDBAKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CBICAEDBAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x2562270", Offset = "0x2560E70", VA = "0x182562270")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct KAMIHCNNDEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public CIMGNNINHIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private OBEAAGHBMLA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2570690", Offset = "0x256F290", VA = "0x182570690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2570B20", Offset = "0x256F720", VA = "0x182570B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private CNAIFAOMEIB AHHHHANHIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private JBHAGEIOKBE HHBOJHHPENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x25628B0", Offset = "0x25614B0", VA = "0x1825628B0")]
	public static Task<Scene> FBDAJNDLBGL(PPNMJFAJPOL NFAAFLGBLEA, CNAIFAOMEIB NCJKGOPMNPM, JBHAGEIOKBE HHBOJHHPENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2562900", Offset = "0x2561500", VA = "0x182562900")]
	[AsyncStateMachine(typeof(BJOPOFPBPNB))]
	private Task<Scene> GGEBMKLJJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2562780", Offset = "0x2561380", VA = "0x182562780")]
	[AsyncStateMachine(typeof(KAMIHCNNDEN))]
	private Task<Scene> CNIODDIOMCI(string LNDJJHKPJBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct CBLJGAJHHBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JOKNPOMNAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CBLJGAJHHBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public MPPELJANMEJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public GDCLCKJPEAM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private JBHAGEIOKBE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter<MPPELJANMEJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x256FD20", Offset = "0x256E920", VA = "0x18256FD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x25705F0", Offset = "0x256F1F0", VA = "0x1825705F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HOJKDPEONGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder<MPPELJANMEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CBLJGAJHHBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public MPPELJANMEJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x256E630", Offset = "0x256D230", VA = "0x18256E630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x256E850", Offset = "0x256D450", VA = "0x18256E850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private readonly IDKMFBPHFLH BCMCOHHOGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private readonly AAJPJGLAHJA NDMOJPMMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly EGEHGHCFMEH FGPJHJGFADI;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CALJFKKNFDC GHGMFFGBFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA2DCE0", Offset = "0xA2C8E0", VA = "0x180A2DCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x25625D0", Offset = "0x25611D0", VA = "0x1825625D0")]
	public CBLJGAJHHBL(IDKMFBPHFLH BCMCOHHOGGA, AAJPJGLAHJA NDMOJPMMAKM, EGEHGHCFMEH FGPJHJGFADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2562410", Offset = "0x2561010", VA = "0x182562410")]
	[AsyncStateMachine(typeof(JOKNPOMNAKB))]
	public Task<MPPELJANMEJ> IHEGHCEBOGA(MPPELJANMEJ HKOOIGENHPB, GDCLCKJPEAM BHAGNAIKFEP, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO, bool NKJNLDMGBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x25622C0", Offset = "0x2560EC0", VA = "0x1825622C0")]
	[AsyncStateMachine(typeof(HOJKDPEONGP))]
	private Task<MPPELJANMEJ> BPLALBLAGLE(JBHAGEIOKBE JDIFJAIAPMA, MPPELJANMEJ IADJLOGDJJD, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x25625A0", Offset = "0x25611A0", VA = "0x1825625A0")]
	private bool OPMILNEPBID(MPPELJANMEJ MDMJHPMJIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2562580", Offset = "0x2561180", VA = "0x182562580")]
	private void IIAAMKEFCEN(string LBDLHIHDENB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal struct EADNMKDKIIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct KFIHFDNINBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CALJFKKNFDC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public MKJIIPEGDMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private List<(PersistenceView, INMIAOPIAHL)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private (PersistenceView, INMIAOPIAHL) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x2570B70", Offset = "0x256F770", VA = "0x182570B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2569FE0", Offset = "0x2568BE0", VA = "0x182569FE0")]
	[AsyncStateMachine(typeof(KFIHFDNINBF))]
	public static Task GGEBMKLJJKB(CALJFKKNFDC DKGDIKDMBMJ, GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct ONOGNENJMND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct PKFLCAACNBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CALJFKKNFDC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public MKJIIPEGDMM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private IBEKIDLIIJK <version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private List<(PersistenceView, INMIAOPIAHL)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private INMIAOPIAHL <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x4A00B60", Offset = "0x49FF760", VA = "0x184A00B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x49FF5D0", Offset = "0x49FE1D0", VA = "0x1849FF5D0")]
	[AsyncStateMachine(typeof(PKFLCAACNBD))]
	public static Task GGEBMKLJJKB(CALJFKKNFDC DKGDIKDMBMJ, GDCLCKJPEAM OAGMKJFIKKL, MKJIIPEGDMM ELODCIHBFII, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct MKFMFFICEEI
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public struct JIPHNEGKDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public List<DCGNKLFPIBC> PENCGJKHMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public List<INMIAOPIAHL> DGODIODCHPB;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6117B0", Offset = "0x6103B0", VA = "0x1806117B0")]
		public JIPHNEGKDGO(List<DCGNKLFPIBC> PENCGJKHMLG, List<INMIAOPIAHL> DGODIODCHPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class ONMALGJGAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public List<DCGNKLFPIBC> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ONMALGJGAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2312960", Offset = "0x2311560", VA = "0x182312960")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private PPNMJFAJPOL NFAAFLGBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private GDCLCKJPEAM OAGMKJFIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private KJDLCGNMOGL.HPBPPBFHINB KAAPKPMMFOI;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private COFMANBGLKC OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x230BA80", Offset = "0x230A680", VA = "0x18230BA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x230B370", Offset = "0x2309F70", VA = "0x18230B370")]
	public static JIPHNEGKDGO GGEBMKLJJKB(PPNMJFAJPOL NFAAFLGBLEA, GDCLCKJPEAM OAGMKJFIKKL, KJDLCGNMOGL.HPBPPBFHINB KAAPKPMMFOI)
	{
		return default(JIPHNEGKDGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x230B400", Offset = "0x230A000", VA = "0x18230B400")]
	private JIPHNEGKDGO GGEBMKLJJKB()
	{
		return default(JIPHNEGKDGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x230BAD0", Offset = "0x230A6D0", VA = "0x18230BAD0")]
	private JIPHNEGKDGO OBKCBLIFHCM(IMCGHCNINDK GHAFIGHOENJ, IBEKIDLIIJK OPBDCNDMHOD, Dictionary<int, int> KFDCODNGNAH)
	{
		return default(JIPHNEGKDGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x230B640", Offset = "0x230A240", VA = "0x18230B640")]
	private GameObject[] KNPFEDGDCAK(List<DCGNKLFPIBC> PENCGJKHMLG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct OGLACKEDJBC
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class HJALMLBLPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public MKFMFFICEEI.JIPHNEGKDGO instantiations;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HJALMLBLPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2301300", Offset = "0x22FFF00", VA = "0x182301300")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class MAMNGEOFPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MAMNGEOFPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x23093F0", Offset = "0x2307FF0", VA = "0x1823093F0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2310800", Offset = "0x230F400", VA = "0x182310800")]
	public static void GGEBMKLJJKB(CALJFKKNFDC DKGDIKDMBMJ, GDCLCKJPEAM OAGMKJFIKKL, MKFMFFICEEI.JIPHNEGKDGO PLKECONHNDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class EGEHGHCFMEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct ALBGHDEAEHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public MPPELJANMEJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public GDCLCKJPEAM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x255E1C0", Offset = "0x255CDC0", VA = "0x18255E1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class JLPMLLAHHOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JLPMLLAHHOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class DKDHJMPKIFF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			public DKDHJMPKIFF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x25721E0", Offset = "0x2570DE0", VA = "0x1825721E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public JBHAGEIOKBE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public JLPMLLAHHOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DKDHJMPKIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x25688D0", Offset = "0x25674D0", VA = "0x1825688D0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct OEKMJKEEHJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private DKDHJMPKIFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2571810", Offset = "0x2570410", VA = "0x182571810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct BLMABKJBNIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private Dictionary<Guid, List<OPHBAEFNEGC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x2561650", Offset = "0x2560250", VA = "0x182561650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct FNIKEKIGGII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private JBHAGEIOKBE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private Dictionary<Guid, List<OPHBAEFNEGC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x256D4A0", Offset = "0x256C0A0", VA = "0x18256D4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class EBEFABJNIFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public OPHBAEFNEGC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public EBEFABJNIFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x2572090", Offset = "0x2570C90", VA = "0x182572090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public NPIKHBAANPE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public List<OPHBAEFNEGC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EBEFABJNIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x256A130", Offset = "0x2568D30", VA = "0x18256A130")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x256A2B0", Offset = "0x2568EB0", VA = "0x18256A2B0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(OPHBAEFNEGC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x256A1F0", Offset = "0x2568DF0", VA = "0x18256A1F0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct EIPOKIOHENG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public NPIKHBAANPE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public List<OPHBAEFNEGC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private EBEFABJNIFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x256C390", Offset = "0x256AF90", VA = "0x18256C390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct JEGNDDEBBFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public JBHAGEIOKBE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x256F4C0", Offset = "0x256E0C0", VA = "0x18256F4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class INBBJEAMINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public INBBJEAMINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x256EA00", Offset = "0x256D600", VA = "0x18256EA00")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct MNNDFOLHADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public GDCLCKJPEAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x25713E0", Offset = "0x256FFE0", VA = "0x1825713E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class OCHDKFEDNLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OCHDKFEDNLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x25717B0", Offset = "0x25703B0", VA = "0x1825717B0")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct CNOBHEBHMIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public EGEHGHCFMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x25639B0", Offset = "0x25625B0", VA = "0x1825639B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class JJBGMOLMPON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JJBGMOLMPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x256FA20", Offset = "0x256E620", VA = "0x18256FA20")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly IDKMFBPHFLH BCMCOHHOGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private DGIJGOEIFKD FGPJHJGFADI;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private CALJFKKNFDC GHGMFFGBFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5FFCF0", Offset = "0x5FE8F0", VA = "0x1805FFCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
	public EGEHGHCFMEH(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x256AE30", Offset = "0x2569A30", VA = "0x18256AE30")]
	[AsyncStateMachine(typeof(ALBGHDEAEHP))]
	public Task GGEBMKLJJKB(MPPELJANMEJ ANKALEOMKHF, GDCLCKJPEAM BHAGNAIKFEP, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x256B130", Offset = "0x2569D30", VA = "0x18256B130")]
	[AsyncStateMachine(typeof(OEKMJKEEHJI))]
	private Task LOPHMECAMEL(GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x256B3B0", Offset = "0x2569FB0", VA = "0x18256B3B0")]
	[AsyncStateMachine(typeof(BLMABKJBNIF))]
	private Task MMDCAJLKCMF(GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x256B630", Offset = "0x256A230", VA = "0x18256B630")]
	[AsyncStateMachine(typeof(FNIKEKIGGII))]
	private Task OJOLCMIILAJ(GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x256B4F0", Offset = "0x256A0F0", VA = "0x18256B4F0")]
	[AsyncStateMachine(typeof(EIPOKIOHENG))]
	private Task MNGGJFGBEON(Guid EFINHADAMBP, List<OPHBAEFNEGC> APFINKOEBHP, NPIKHBAANPE LPOONCPGDOJ, GDCLCKJPEAM OAGMKJFIKKL, CancellationToken KJKNLGILOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x256AA50", Offset = "0x2569650", VA = "0x18256AA50")]
	[AsyncStateMachine(typeof(JEGNDDEBBFI))]
	private Task CPBOGIBIKIN(GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x256B280", Offset = "0x2569E80", VA = "0x18256B280")]
	[AsyncStateMachine(typeof(MNNDFOLHADI))]
	private Task MCCODBNLHHN(Guid HDHGLCHPFFF, GDCLCKJPEAM OAGMKJFIKKL, JBHAGEIOKBE HHBOJHHPENA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x256AB90", Offset = "0x2569790", VA = "0x18256AB90")]
	[AsyncStateMachine(typeof(CNOBHEBHMIB))]
	private Task DDDDLLFGLML(Guid HDHGLCHPFFF, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x256ACE0", Offset = "0x25698E0", VA = "0x18256ACE0")]
	private void EHBLCIDJGGJ(Guid HDHGLCHPFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x256B770", Offset = "0x256A370", VA = "0x18256B770")]
	private void PODOEOIDJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x256AF90", Offset = "0x2569B90", VA = "0x18256AF90")]
	public Guid IOOGFFFKNCA(MPPELJANMEJ DCPFOJINCLO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x256A8E0", Offset = "0x25694E0", VA = "0x18256A8E0")]
	[CompilerGenerated]
	private object ADOLKEFJEDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct KCNIOKLNAOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public IMCGHCNINDK ICDKMNPBIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	public List<string> EPBOLPABMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	public Dictionary<long, int> PHKGIOBDPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	public string LBNCIEOAJDE;
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal class DIKKDKBHEHL : FEKKPEDDMLJ
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class GHIJIPFCDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public CGDLLLKAEDP autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public GHIJIPFCDNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class OLABECIFAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public GHIJIPFCDNP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OLABECIFAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2571C20", Offset = "0x2570820", VA = "0x182571C20")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class ELGCNKKFPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public GHIJIPFCDNP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ELGCNKKFPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x256C7F0", Offset = "0x256B3F0", VA = "0x18256C7F0")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class LDPDIFPFMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CGDLLLKAEDP autosaveType;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LDPDIFPFMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2571020", Offset = "0x256FC20", VA = "0x182571020")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class CPPNNICAGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public FileInfo autosaveFile;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CPPNNICAGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2563E60", Offset = "0x2562A60", VA = "0x182563E60")]
		internal object <TryReadAutosave>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class IKJLLLEOCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public IKJLLLEOCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x256E8A0", Offset = "0x256D4A0", VA = "0x18256E8A0")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class FBBBIBMGMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public FileInfo file;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public FBBBIBMGMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x256D430", Offset = "0x256C030", VA = "0x18256D430")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class PMHKIMHMEBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PMHKIMHMEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2571CB0", Offset = "0x25708B0", VA = "0x182571CB0")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private const string OPHKPMGPNEC = "V2";

	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private const int IDNCBJPMJNP = 5;

	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private const string JFJJIAKKOCA = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private const string BDPJOKLHHFH = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private const int KIGICNOIHIB = 32;

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x25683C0", Offset = "0x2566FC0", VA = "0x1825683C0")]
	public DIKKDKBHEHL(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2567470", Offset = "0x2566070", VA = "0x182567470")]
	public bool GCOLDEMLGJM(long JBPDPGIHJEE, KCNIOKLNAOF DGKGHBNEJJL, CGDLLLKAEDP AIAPLHMBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2567F10", Offset = "0x2566B10", VA = "0x182567F10")]
	public static bool MBHDLKDEMNI(long JBPDPGIHJEE, CGDLLLKAEDP AIAPLHMBPNG, out FileInfo KKMKNNJIILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2566DD0", Offset = "0x25659D0", VA = "0x182566DD0")]
	public bool EEFOEKOKMHM(long JBPDPGIHJEE, CGDLLLKAEDP AIAPLHMBPNG, out KCNIOKLNAOF DGKGHBNEJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x25668F0", Offset = "0x25654F0", VA = "0x1825668F0")]
	private bool DGAHCPPDDAD(FileInfo KKMKNNJIILI, out byte[] AKDPHCIFLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2567390", Offset = "0x2565F90", VA = "0x182567390")]
	private static FileInfo FOLGAEDNLPA(long JBPDPGIHJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2567E40", Offset = "0x2566A40", VA = "0x182567E40")]
	private static FileInfo KKGDOOEGODP(long JBPDPGIHJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x25678E0", Offset = "0x25664E0", VA = "0x1825678E0")]
	private static DirectoryInfo IOOEMMKKBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2567FD0", Offset = "0x2566BD0", VA = "0x182567FD0")]
	private void MENGKCPKPLC(FileInfo OCMHBCOJEKA, IMCGHCNINDK OMJKBNBHODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x2567950", Offset = "0x2566550", VA = "0x182567950")]
	private void KANKDHHPAGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2566740", Offset = "0x2565340", VA = "0x182566740")]
	public static void AJIPCGBLBIF(long JBPDPGIHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2568350", Offset = "0x2566F50", VA = "0x182568350")]
	public static bool NNOGDFJKIDM(long JBPDPGIHJEE, out DateTime MHAMDNOFANP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal class HGLHMPLAEEL : FEKKPEDDMLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct NPLFCKPDKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder<KCNIOKLNAOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public HGLHMPLAEEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public OMGBOIABDEP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x24D08C0", Offset = "0x24CF4C0", VA = "0x1824D08C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x24D0DC0", Offset = "0x24CF9C0", VA = "0x1824D0DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class FCPNIGEJNPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public OMGBOIABDEP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public FCPNIGEJNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x24C05C0", Offset = "0x24BF1C0", VA = "0x1824C05C0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class IDBOMDDMIGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public FCPNIGEJNPF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public IDBOMDDMIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x24C9570", Offset = "0x24C8170", VA = "0x1824C9570")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class OEBGCBADEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public FCPNIGEJNPF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OEBGCBADEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x24D0E10", Offset = "0x24CFA10", VA = "0x1824D0E10")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct PNLKJGOILCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public OMGBOIABDEP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public HGLHMPLAEEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private IDBOMDDMIGB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private LBNBOIDEHJA.ENACBFMPHEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x24D21D0", Offset = "0x24D0DD0", VA = "0x1824D21D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private readonly IIJAKJLBHOF INNOMIHIENJ;

	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private static readonly TimeSpan NFDOIINBHKK;

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x24C7F50", Offset = "0x24C6B50", VA = "0x1824C7F50")]
	public HGLHMPLAEEL(IDKMFBPHFLH BCMCOHHOGGA, [Optional] IIJAKJLBHOF? INNOMIHIENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x24C6E90", Offset = "0x24C5A90", VA = "0x1824C6E90")]
	[AsyncStateMachine(typeof(NPLFCKPDKPP))]
	public Task<KCNIOKLNAOF> CGMPPIJDMHM(long JBPDPGIHJEE, string BDBHIODHJDL, OMGBOIABDEP FDCEGDNBCHM, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x24C77F0", Offset = "0x24C63F0", VA = "0x1824C77F0")]
	[AsyncStateMachine(typeof(PNLKJGOILCM))]
	private Task NEFIFBIDHBN(OMGBOIABDEP FDCEGDNBCHM, IEnumerable<PersistenceView> JLHIFNCOABM, StringBuilder IMLNCPBPBIN, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x24C7940", Offset = "0x24C6540", VA = "0x1824C7940")]
	private KCNIOKLNAOF OBNOMMJBHEP(long JBPDPGIHJEE, string BDBHIODHJDL, OMGBOIABDEP FDCEGDNBCHM, IEnumerable<PersistenceView> JLHIFNCOABM, StringBuilder IMLNCPBPBIN)
	{
		return default(KCNIOKLNAOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x24C6FE0", Offset = "0x24C5BE0", VA = "0x1824C6FE0")]
	private IMCGHCNINDK CPMCHOLGOOI(long JBPDPGIHJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x24C7160", Offset = "0x24C5D60", VA = "0x1824C7160")]
	private void GMNABDGJAGF(IMCGHCNINDK INCMCAOFHMH, StringBuilder IMLNCPBPBIN, IEnumerable<PersistenceView> JLHIFNCOABM, in IHFJHNBJCMP ELFLHAPPPBO, ref IKJLLPLFBPP BHKLFJPKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x24C7360", Offset = "0x24C5F60", VA = "0x1824C7360")]
	private void KGFBJFPHIOM(IMCGHCNINDK INCMCAOFHMH, StringBuilder IMLNCPBPBIN, PersistenceView FJAGFNGNGHD, ref IKJLLPLFBPP BHKLFJPKBGC, in IHFJHNBJCMP ELFLHAPPPBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal class EHIKAKHANHB : FEKKPEDDMLJ
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class BDGLFDGOCNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public LDEMFLHNMIH.LMOFMOKGGHE roomMetadataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public LDEMFLHNMIH.LMOFMOKGGHE roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public BDGLFDGOCNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x255FB40", Offset = "0x255E740", VA = "0x18255FB40")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x255FBC0", Offset = "0x255E7C0", VA = "0x18255FBC0")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x255FC10", Offset = "0x255E810", VA = "0x18255FC10")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x255FC80", Offset = "0x255E880", VA = "0x18255FC80")]
		internal object <UploadRoomData>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct HNMAMOJJLEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder<(LDEMFLHNMIH.LMOFMOKGGHE roomMetadataUpload, LDEMFLHNMIH.LMOFMOKGGHE roomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public KCNIOKLNAOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public EHIKAKHANHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private BDGLFDGOCNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter<LDEMFLHNMIH.LMOFMOKGGHE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x256DD30", Offset = "0x256C930", VA = "0x18256DD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x256E5E0", Offset = "0x256D1E0", VA = "0x18256E5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct EGMNCDLMLND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder<BLFDLDDAGOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public EHIKAKHANHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public KCNIOKLNAOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private TaskAwaiter<(LDEMFLHNMIH.LMOFMOKGGHE roomMetadataUpload, LDEMFLHNMIH.LMOFMOKGGHE roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter<BLFDLDDAGOG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x256B860", Offset = "0x256A460", VA = "0x18256B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x256BBC0", Offset = "0x256A7C0", VA = "0x18256BBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct PPEIPNOAONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder<FANOGDNCLMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public EHIKAKHANHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public KCNIOKLNAOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<(LDEMFLHNMIH.LMOFMOKGGHE roomMetadataUpload, LDEMFLHNMIH.LMOFMOKGGHE roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private TaskAwaiter<FANOGDNCLMC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2571D10", Offset = "0x2570910", VA = "0x182571D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2572040", Offset = "0x2570C40", VA = "0x182572040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class GEGBDOKGIHA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public GEGBDOKGIHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			private OIOFODEOKJJ <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			private TaskAwaiter<FANOGDNCLMC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005E2")]
			private TaskAwaiter<BLFDLDDAGOG> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005E3")]
			private TaskAwaiter<OIOFODEOKJJ> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x2572970", Offset = "0x2571570", VA = "0x182572970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x2573780", Offset = "0x2572380", VA = "0x182573780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public EHIKAKHANHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public KCNIOKLNAOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public GEGBDOKGIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x256D8F0", Offset = "0x256C4F0", VA = "0x18256D8F0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<OIOFODEOKJJ> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct GFCCNNOOEII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder<OIOFODEOKJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public EHIKAKHANHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public KCNIOKLNAOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter<OIOFODEOKJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x256DA10", Offset = "0x256C610", VA = "0x18256DA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x256DC40", Offset = "0x256C840", VA = "0x18256DC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private const float EMHKAMCGLKF = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private readonly AMIOAAFAKIM PGAKOLNKNDB;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private PPNMJFAJPOL ICGGAJEOGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x23114D0", Offset = "0x23100D0", VA = "0x1823114D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x256C180", Offset = "0x256AD80", VA = "0x18256C180")]
	public EHIKAKHANHB(IDKMFBPHFLH BCMCOHHOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x256BC10", Offset = "0x256A810", VA = "0x18256BC10")]
	[AsyncStateMachine(typeof(HNMAMOJJLEL))]
	private Task<(LDEMFLHNMIH.LMOFMOKGGHE, LDEMFLHNMIH.LMOFMOKGGHE)> CJJDPEBPKBD(KCNIOKLNAOF DGKGHBNEJJL, long FKPMOLLCILH, long DILPJIBNJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x256BEC0", Offset = "0x256AAC0", VA = "0x18256BEC0")]
	[AsyncStateMachine(typeof(EGMNCDLMLND))]
	public Task<BLFDLDDAGOG> OBCIDMLELOA(int EFCLJOKJOGE, KCNIOKLNAOF DGKGHBNEJJL, long FKPMOLLCILH, long DILPJIBNJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x256BD60", Offset = "0x256A960", VA = "0x18256BD60")]
	[AsyncStateMachine(typeof(PPEIPNOAONB))]
	private Task<FANOGDNCLMC> HFCHFMNKJBD(string BHLKJEANMPN, int EFCLJOKJOGE, KCNIOKLNAOF DGKGHBNEJJL, long FKPMOLLCILH, long DILPJIBNJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x256C010", Offset = "0x256AC10", VA = "0x18256C010")]
	[AsyncStateMachine(typeof(GFCCNNOOEII))]
	public Task<OIOFODEOKJJ> OMBEGFCPNNE(int EFCLJOKJOGE, KCNIOKLNAOF DGKGHBNEJJL, long FKPMOLLCILH, long DILPJIBNJHM, JBHAGEIOKBE JDIFJAIAPMA, CancellationToken DHCIMDILIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public class EBFBPENADOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private readonly Guid EEBPFACBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private readonly MAKHFKKGMGG KJJAPFFOIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private BGANJHOLFGD LEPAGINGHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private int? IBJBOJHLMLK;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Guid PMHJABAHEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x256A5B0", Offset = "0x25691B0", VA = "0x18256A5B0")]
	public EBFBPENADOI(MAKHFKKGMGG KJJAPFFOIFE, [Optional] Guid? EEBPFACBCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x256A3D0", Offset = "0x2568FD0", VA = "0x18256A3D0")]
	public EBFBPENADOI GALAHKPPJBO(BGANJHOLFGD LEPAGINGHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x256A4E0", Offset = "0x25690E0", VA = "0x18256A4E0")]
	public OIOFODEOKJJ OGIHGBFPDNB(out Guid BJIEEAFJHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x256A3F0", Offset = "0x2568FF0", VA = "0x18256A3F0")]
	public EBFBPENADOI JOLHPFHKIJO(JOLEIFGGDHD IOBIGAFBIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
public static class DJLLIACOGFC
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2568820", Offset = "0x2567420", VA = "0x182568820")]
	public static EKDIEFBMMGH EKLFFMOONEH(this IPKJAJKKGFP EHPCBBBCICC)
	{
		return default(EKDIEFBMMGH);
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
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public MHKHNOOKFLJ ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			public MHKHNOOKFLJ HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private static MHKHNOOKFLJ[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private Dictionary<MHKHNOOKFLJ, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x4A031A0", Offset = "0x4A01DA0", VA = "0x184A031A0")]
		public bool ALNCHAKDNEF(MHKHNOOKFLJ LCPLECGFOBE, out ResultConfig MJJPCIEJCOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x4A03210", Offset = "0x4A01E10", VA = "0x184A03210")]
		public ResultConfig HEDODBBFCCM(MHKHNOOKFLJ NLMJDJOMNEN, [Optional] HashSet<MHKHNOOKFLJ> LMGEFLIDOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x4A037B0", Offset = "0x4A023B0", VA = "0x184A037B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x4A03300", Offset = "0x4A01F00", VA = "0x184A03300", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xDDC560", Offset = "0xDDB160", VA = "0x180DDC560")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x24C2E30", Offset = "0x24C1A30", VA = "0x1824C2E30")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x24C2B00", Offset = "0x24C1700", VA = "0x1824C2B00")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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

		[Cpp2IlInjected.Token(Token = "0x4000604")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
