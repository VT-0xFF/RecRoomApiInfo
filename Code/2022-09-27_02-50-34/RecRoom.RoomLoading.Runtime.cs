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
public class OOBJKNLHPGE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20E5FE0", Offset = "0x20E51E0", VA = "0x1820E5FE0")]
	public OOBJKNLHPGE(string HGHEMBBLDIC, Exception JFPPAOGPCNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface EBHEMCKGNHE : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FIHIHAMOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task CJPFIKGKEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDGFBBGIDPC(Task HAJJIJILELD, string DKPALGBAMPO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface PJIPLBGGCID : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HOFMLDPLIAG> APACGDAIPBB(GHLNAHICKHI OKLBJDMNAMD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EBCNGBECEIO(CancellationToken GENHLOEKMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface JELHGHCAFII : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IAOOBAIGPGE IINDNBICOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCCOMBNMNDL();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAPCGBOICGI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CDKMFDLCHBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface EJMPHAMHIAI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TimeSpan OODIHHINMME
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan FCJOKGLDELD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan ILHJBENDEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan DMKFOHCJAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NLBPEPNEHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CCPCAJNMIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DMBDDAMPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NJNOHLKAMBN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MIPEDOLMHFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long OBKLHPGIOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long BAHLJDONCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly NJNOHLKAMBN BGMCKNGNOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception GMFGMAPMALB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8D8140", Offset = "0x8D7340", VA = "0x1808D8140")]
	public MIPEDOLMHFF(long OBKLHPGIOLN, long BAHLJDONCPF, NJNOHLKAMBN BGMCKNGNOJI, [CanBeNull] Exception GMFGMAPMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8D80F0", Offset = "0x8D72F0", VA = "0x1808D80F0")]
	public static MIPEDOLMHFF EPFIPEGMDAC(AAPOAKFHPCO EIJIKEIPNIF, NJNOHLKAMBN BGMCKNGNOJI, [Optional] Exception GMFGMAPMALB)
	{
		return default(MIPEDOLMHFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void ILICLCICENK(MIPEDOLMHFF PENHLMIDEOE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface LADOLAEPIKK : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GFJGPAMPAGB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event ILICLCICENK OBANBANNLBA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ILICLCICENK OFGFDFBNHPB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ILICLCICENK EJCDIOBMKGC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGBLFFPMACD();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BMAEELBPFBN(MIPEDOLMHFF PENHLMIDEOE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CPBKHPOKMFF(MIPEDOLMHFF PENHLMIDEOE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FEDGECBKLFM(MIPEDOLMHFF PENHLMIDEOE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface BFFAALFBPJG : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HEJEBAGLDNA();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJJHJONICLG();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHLJMIHNBPN();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate Task AKPLMNLHDHF(MOPOKHJCMLO FCLGFPAONJE, CancellationToken HCPCDENCJBA);
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal interface CKEDNNDPMCB : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ELFGBLKEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMIPBPPKLPM(AKPLMNLHDHF HJPBFNCLHFN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface AAALOJNNBAO : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	TaskStatus MALMDEHEPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LDMHJPGEAJF(AAPOAKFHPCO LCKJIJGJFOH, CancellationToken HJBBMMLLNMM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class DCILPCNNNDC
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xC396B0", Offset = "0xC388B0", VA = "0x180C396B0")]
	public static bool HCIEIDKBKDB(this AAALOJNNBAO HFIAPJOJCOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface BNHHCILIEOE : JCDNGJMOLNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CancellationToken DKKKIOMNDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EIFHKIDJKKE HOMAHBAKPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PKOOEACNMEF GLIPAFNENJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GJCIAICHFLK MNEBLLEIONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ODPBOGGBOGH JNGOBBNCCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CMHBPLAIECK DFFLIJOCGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FLNCIFOOELD PJNHFDHBEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BEIMJCANIFD LHCNDBPEAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EBHEMCKGNHE CPMLNLCNODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PJIPLBGGCID OFPJCGGPBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LADOLAEPIKK NDPEKCLGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BFFAALFBPJG LLJLFKDOJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AAALOJNNBAO DGFEHIBDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CKEDNNDPMCB CDCAGCNBPID
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EPEKOCBMPEC LHFLCCJODOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	KIHKLLHPBDA OMPOGGLIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FDOHHACFEDF GDEBAOBIGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KKNMEFGEPHM OKOIGNAHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DKPMPECPDDD AFEFABILKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BBCDJNJMCJI FGIMALMAECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	AELADMHNCJJ LLMNODIMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KBGFDKHAKPJ DDJGLCOLIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	HCKNJILHBPC KMEFNKMCJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	HHOJOCKFCMF CPIFLJGCKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	PCHMLFAONLB OOEEGJHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	JELHGHCAFII AFMAJDKLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EJMPHAMHIAI HLPDOCHEGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HJPCCELBDGI FFCPBOHMELM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface EPEKOCBMPEC : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOFNOFIIIAA KAGEPJABGKM(Guid BPIHMIEIAOA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CEDMIKNCMLN(Guid BPIHMIEIAOA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBPOEOCDLAO(Guid BPIHMIEIAOA, Task CDBOLHIHKMP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool COLPDMELILI(Guid BPIHMIEIAOA, HOFMLDPLIAG DCFFNMGBDPE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OHLJMIHNBPN(Guid BPIHMIEIAOA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(HOFMLDPLIAG, Task)> MGBCAGCLBLD(Guid BPIHMIEIAOA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface KIHKLLHPBDA : CDKMFDLCHBK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface FDOHHACFEDF : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOANNODPDOJ(HOMLJGGAMHI HGHEMBBLDIC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJNBGMNNNNH(HOMLJGGAMHI HGHEMBBLDIC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CPOLDIKGNEC> JAGKKHDFMMF(CancellationToken JBFDKHCAJIC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate HOFMLDPLIAG ECEAPNHCMJA(FLLPHMIGOPF MCGGHPBODKF, CPOLDIKGNEC ABMLOKNKPDJ);
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface KKNMEFGEPHM : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOFNOFIIIAA HFPFDMDLLGK(DKAKIPPIIFI BAKLMCJMIOD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCIOFONFNF(Guid BPIHMIEIAOA, Task CDBOLHIHKMP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface DKPMPECPDDD : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HOFMLDPLIAG> AFEFABILKDL(FLLPHMIGOPF DGFKMAMLEOJ, CPOLDIKGNEC FHNMKOAPIBA, [Optional] FNJGHNELDIC NKOEMEKCBIB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface BBCDJNJMCJI : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FLLOKKAPGEA> JPLGGKEBENG(CIHEPFKAKNH EFJKGFIDBLG, AAPOAKFHPCO LCKJIJGJFOH, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FLLOKKAPGEA PIEAMEIGENN(AAPOAKFHPCO LCKJIJGJFOH, FNJGHNELDIC PCHICKCNMDC, long NCGNHGHNMLN);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FLLOKKAPGEA HOGAFFLPLHP(AAPOAKFHPCO LCKJIJGJFOH, NMDBGAAGKEB GGMFNEEJGOP, long NCGNHGHNMLN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FLLOKKAPGEA AEFFGDKCPFO(long OBKLHPGIOLN, long NCGNHGHNMLN, string AOLBKHGPCCM, string DBLOGHCOFKG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface KBGFDKHAKPJ : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOFMLDPLIAG EHODMNENIFC(FLLPHMIGOPF MCGGHPBODKF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ADPFJAPCOLH(string DLBDGCGKOKN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface AELADMHNCJJ : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HOMLJGGAMHI> GFFFPPPEEED(HOMLJGGAMHI KPOBLGGEAFB, DPBKAPJPKAG HDJPKODHJNN, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HOMLJGGAMHI> KJAAINOPKAB(CancellationToken GENHLOEKMNL, DPBKAPJPKAG HDJPKODHJNN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BJHEGHJPHON FAKNEGKLBGF(HOKANCNHCCE KBMMKNOMJGM, CIHEPFKAKNH EFJKGFIDBLG);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJHEGHJPHON GKIFHHBJALA(HOKANCNHCCE KBMMKNOMJGM, CIHEPFKAKNH EFJKGFIDBLG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface HCKNJILHBPC : CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOFMLDPLIAG EEBBHGHKFGO(FLLPHMIGOPF MCGGHPBODKF, CPOLDIKGNEC ABMLOKNKPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOFMLDPLIAG JDPGFNBMDID(FLLPHMIGOPF HGINGOKKANE);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOFMLDPLIAG OCPFLPDJLHK(FLLPHMIGOPF HGINGOKKANE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HHOJOCKFCMF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEALJCHKFEO(HFFHIBGKKJD EAPCMECNDHD);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGFKKNEIDBB(HFFHIBGKKJD EAPCMECNDHD);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDFOHFCCOLD(HFFHIBGKKJD EAPCMECNDHD);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONFJJNAACNO(HFFHIBGKKJD EAPCMECNDHD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HFFHIBGKKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly AAPOAKFHPCO MBGIHILIEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> HJOPIBKIMOB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public global::AHNHODFKKCG<string> HJNMGGFGILH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	public HFFHIBGKKJD(AAPOAKFHPCO PHDMDMHLDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x9C46E0", Offset = "0x9C38E0", VA = "0x1809C46E0")]
	public HFFHIBGKKJD FEIIJFHJMAA(string JCNAPFOCJDI, string ADBNEBBHMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9C4660", Offset = "0x9C3860", VA = "0x1809C4660")]
	public bool DIJMIBJPFCM(out IEnumerable<KeyValuePair<string, string>> EKCHGEFDFKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9C47A0", Offset = "0x9C39A0", VA = "0x1809C47A0")]
	public HFFHIBGKKJD LCHPMENBGHF(global::AHNHODFKKCG<string> NDCCOMJDOFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HJPCCELBDGI
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool KAACFDEOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string CDILGNBGOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCLCLPDAAFC();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLJLDBPJICF ILACPJHCDDH(long EEOJGJPIKOH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::BCIHMNJOENF<CBCEEBNMKHL, BHBOEJLJKEA> JJICNMEIOCN(long EEOJGJPIKOH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::BCIHMNJOENF<CBCEEBNMKHL, FODENONHEJC> NDNDFGOHGAF(long EEOJGJPIKOH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::BCIHMNJOENF<long, NCNKAGACMPF> GICOIEHINFF();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FLJLPKANOBO(long EEOJGJPIKOH, out string DBLOGHCOFKG, out string AOLBKHGPCCM, out CBCEEBNMKHL KFLFPPJGGLE, out CBCEEBNMKHL CLMKEDMMOAE);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BLPMFNDOLBJ(FLLOKKAPGEA KPOBLGGEAFB, long EEOJGJPIKOH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> EEMAJLLJFDO(long EEOJGJPIKOH, byte[] KFLFPPJGGLE, byte[] CLMKEDMMOAE, CancellationToken GENHLOEKMNL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JCDNGJMOLNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HCIEIDKBKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool IHGPNEJCHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action GFJGPAMPAGB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ILICLCICENK OBANBANNLBA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ILICLCICENK OFGFDFBNHPB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ILICLCICENK EJCDIOBMKGC;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CJJHJONICLG();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<HOFMLDPLIAG> CDIAMCOMNDO([Optional][CanBeNull] FNJGHNELDIC OGNLMBODDHP);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<HOFMLDPLIAG> MADCKLKPMNK(FLLPHMIGOPF KOOENNCPJGK);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<HOFMLDPLIAG> EJCPLOOOOHD(int LIGLKPEMMBL);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ADPFJAPCOLH(string DLBDGCGKOKN);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<HOFMLDPLIAG> APACGDAIPBB(GHLNAHICKHI OKLBJDMNAMD = GHLNAHICKHI.Incremental);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task EBCNGBECEIO(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OHOKLONADDF(long NCGNHGHNMLN);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MJGJKENNCFF(long NCGNHGHNMLN, out DateTime PDOFMLFLGHN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ODPBOGGBOGH
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string FCPIBLLCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNLPKFNAHND(Scene DJFMHAJJBJC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FLCALGKPCNM(ECEIBLDGNAE DAGCGALNKOM, CancellationToken GENHLOEKMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JGACAEEBELJ
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int FNONGHDDGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool JPPNIBPGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool BGIDAMOKCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool AIAIHBFGIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool JHIBGJAIMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool GEEHIDIPBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FLLPHMIGOPF BGBLIKAGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EIFHKIDJKKE JFNLBNPCNNG(EIFHKIDJKKE NGFIHKMEPJH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBGBAGNHOIF(EIFHKIDJKKE APJAHLFEOEM);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GCPLBLCNLLO(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task MNHBNGBNNFE(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task CKLBDMKAJJP(DDNAAFIOLBK GMKBLCEOJEB, [Optional] CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DDMLFPBLDKH(float KNCEFPKIICO);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void INJJMCPIJKK(string HDMGIBELFDJ);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<MMPKOLCIOMJ> POJCBFOLALE();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable CHMBJKOKJLI(object JAEDJGBMHAP, MMPKOLCIOMJ AHOPBMACHGE);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BHBOEJLJKEA PIDGEJOIBFD();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MKJKPHIMBLG(int EDLFKKIKHEO);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task MOJGAIGNBBM();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AHAIICPLBIF();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool MKLIGOONJEL();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task AEPKIDHHDHB(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task EHMAJMNNDOI(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> PDMBAKNFDLH(DateTime FNGJIDLGHJG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> BFBPCEFKMDB(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GOJCKFCFHOD();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HJFCEOBMKFM IHAIFNJLFEK(KCCPHNKJAFO IPLHOAGGIFB, FODENONHEJC CFFGDDCGBOC, IEnumerable<PersistenceView> BODHEKDOOBJ, ref KMNJHBHPKCC DOKLDCAALJC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LOAHFEJEJEI(APKLKLKEDEA PHABFFFGDNC, in HJFCEOBMKFM HBNKOANCKDB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IJJKHLAMOHK(FODENONHEJC EFMGFKIIAIF, bool JBPPGJJGCAA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LJGEOAEEOFD();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HHFNCBPJFDI(long AHCJAABMBLP, long BAHLJDONCPF, FNJGHNELDIC GMHAPMPIHMC, KOPDLHJILKH BAGCJGEGOAG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OKKGCKKDAGN(long AHCJAABMBLP, long BAHLJDONCPF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JGINHKDCEMD(PersistenceView BEMEGOMAHHI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DPIJINHOOPN(PersistenceView KPPLLFPIALK);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool BIKFGEJNLKB(APKLKLKEDEA PHABFFFGDNC, GKPCFNJDGEA BBDGMBBBJLF, Dictionary<int, int> CGLGJIFBNGG, out KNJLDHIHLDI AGKEADMKJJO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CBLLGGEPJMP();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BPLKFBOBLMF();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable DLOOOHFFCAA();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Dictionary<int, int> NNFHKANGFNI(FODENONHEJC EFMGFKIIAIF, GKPCFNJDGEA BBDGMBBBJLF);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> IAGCKGKAIPL(PKOOEACNMEF ELPBHABCDMF, CancellationToken GENHLOEKMNL, CIHEPFKAKNH EFJKGFIDBLG);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KDLAOAJHAMI(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<FNJGHNELDIC> KPBFNGHLPLP(long AHCJAABMBLP, long BAHLJDONCPF, string AOLBKHGPCCM, string MOJCEDNGKIH, string EKIJEBKIFEJ, Dictionary<long, int> POCIKJKCIML, int LNPAPJKCEPH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<NMDBGAAGKEB> IPLLNDPBNAC(string DBLOGHCOFKG, long AHCJAABMBLP, long BAHLJDONCPF, string AOLBKHGPCCM, NNPLJODHNML.DGIBLHGAFAG MOJCEDNGKIH, NNPLJODHNML.DGIBLHGAFAG EKIJEBKIFEJ, int LNPAPJKCEPH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FNJGHNELDIC> PFBNCCHIEDB(long AHCJAABMBLP, bool JIOJMKIIBMM, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool DDCABPAJDOJ();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool CEJNNENNIHH();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GameObject[] FOOFMFIHMBN(NFAMCPJAHMJ[] OJCPFPCKLLC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void HGGEOKCBAPF(List<GameObject> CBNOBEBCIMK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float NFFCNDODBBG();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> KKHANBLMMLL(string KKBNOPPEJCL, LoadSceneMode OKGIGLNDHHJ, bool JLINIOELJKI, CIHEPFKAKNH NDCCOMJDOFK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void GDHIENNODDE(AAPOAKFHPCO BKHKFCEGGGC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void EAHKPLCKNFM(string FHNMKOAPIBA, FLLPHMIGOPF DGFKMAMLEOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task IOALJLDODHD(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task IDGIBCEFAPH(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void KGJGHOLFPCB();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "56")]
	IDisposable APJHMCLOCGG();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "57")]
	KFIDLBOKONC NICEEBDFLFO();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KFIDLBOKONC
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PDOANOEDCHO(CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ENGNKILAHAI(CancellationToken GENHLOEKMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HJFCEOBMKFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> IFBBNCNKDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public IDisposable BFHCNGNEHAE;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x9C47C0", Offset = "0x9C39C0", VA = "0x1809C47C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HIKJLEMACCL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AAPOAKFHPCO COENBDDMNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FNJGHNELDIC PKKFOKPPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DEJNIAFBCPN AALGDMMKBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JBPBKLKFAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool GJFPDLNMGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int FNONGHDDGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action FEFOHCOEKJM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<int> DKBKEMDKBIH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BALMMHLPKNH();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FGCDMIPDEMD> NGFMIIENCDG();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task HENNEDGOBNL();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AAPOAKFHPCO MOPCHDCKJCI();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JOFPAEBELBI IFKLPFKNKMH();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BJHJEICMLGE(long EEOJGJPIKOH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PCHMLFAONLB
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFABAHFCOAB(out IEnumerable<int> DKJPEKMEDKD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFOGCGGKJPJ(KHMNKHEBLDL HCPCDENCJBA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPCGPKIIKCP(KHMNKHEBLDL HCPCDENCJBA);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FOFHKOGDGPP
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DMPINLJAPPD(HOFMLDPLIAG EPDJCIBDHHM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NDOGFOCGPGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICPAPLOFIAL(LFFNFJGBNCP.PEOIBHGCECH JFJNHBCKAFF);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCKAFIMFLJK(LFFNFJGBNCP.PEOIBHGCECH JFJNHBCKAFF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CMHBPLAIECK : NDOGFOCGPGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOFMLDPLIAG DJIMNJKLEDF(FLLPHMIGOPF HGINGOKKANE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FLNCIFOOELD : NDOGFOCGPGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOFMLDPLIAG EHODMNENIFC(FLLPHMIGOPF BLMOODAHPDL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NLJLDBPJICF
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EABJJOPDGLM<ECEIBLDGNAE, JMNFFALHFMO>> LHIMHDDKPFD(string AOLBKHGPCCM, long EEOJGJPIKOH, IPLKHEPDMLK.GFEFCIMGDFF KLLPEBGDOMN, CancellationToken GENHLOEKMNL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BCIHMNJOENF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::EABJJOPDGLM<byte[], JMNFFALHFMO>> LHHGNDEEHAE(TGetDataArg ACHMMDGBDID, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EABJJOPDGLM<global::KKFMAOPDNGH<TData>, JMNFFALHFMO> BHJGAFOPLPL(byte[] ADIGGFBANFM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class HOHHKCGCJEL : BNHHCILIEOE, JCDNGJMOLNB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MJFIDJODLPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<HOFMLDPLIAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HOHHKCGCJEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public GHLNAHICKHI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<HOFMLDPLIAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8D82B0", Offset = "0x8D74B0", VA = "0x1808D82B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8D84F0", Offset = "0x8D76F0", VA = "0x1808D84F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CIIJCBHNBFF : IEnumerable<CDKMFDLCHBK>, IEnumerable, IEnumerator<CDKMFDLCHBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private CDKMFDLCHBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public HOHHKCGCJEL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private CDKMFDLCHBK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
		[DebuggerHidden]
		public CIIJCBHNBFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8C5840", Offset = "0x8C4A40", VA = "0x1808C5840", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C80", Offset = "0x8C4E80", VA = "0x1808C5C80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BE0", Offset = "0x8C4DE0", VA = "0x1808C5BE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CDKMFDLCHBK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BE0", Offset = "0x8C4DE0", VA = "0x1808C5BE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationTokenSource LMGBOHFNNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EIFHKIDJKKE APJAHLFEOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GAJAMNIHBHB AHFEINMDFFE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PKOOEACNMEF GLIPAFNENJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F8940", Offset = "0x5F7B40", VA = "0x1805F8940", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B80", Offset = "0x5F7D80", VA = "0x1805F8B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GJCIAICHFLK MNEBLLEIONG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6163F0", Offset = "0x6155F0", VA = "0x1806163F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D5FA0", Offset = "0x7D51A0", VA = "0x1807D5FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A12A0", Offset = "0x6A04A0", VA = "0x1806A12A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBB10", VA = "0x1807DC910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ODPBOGGBOGH JNGOBBNCCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D20C0", Offset = "0x6D12C0", VA = "0x1806D20C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF9D0", Offset = "0x5FEBD0", VA = "0x1805FF9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CMHBPLAIECK DFFLIJOCGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x698F60", Offset = "0x698160", VA = "0x180698F60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD120", Offset = "0x6FC320", VA = "0x1806FD120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FLNCIFOOELD PJNHFDHBEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x605680", Offset = "0x604880", VA = "0x180605680", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x604180", Offset = "0x603380", VA = "0x180604180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public BEIMJCANIFD LHCNDBPEAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6055A0", Offset = "0x6047A0", VA = "0x1806055A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D42F0", Offset = "0x6D34F0", VA = "0x1806D42F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EBHEMCKGNHE CPMLNLCNODO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x699010", Offset = "0x698210", VA = "0x180699010", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEA0", Offset = "0x7DE0A0", VA = "0x1807DEEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public PJIPLBGGCID OFPJCGGPBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x698F70", Offset = "0x698170", VA = "0x180698F70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DE100", Offset = "0x7DD300", VA = "0x1807DE100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LADOLAEPIKK NDPEKCLGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x699000", Offset = "0x698200", VA = "0x180699000", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBA0", Offset = "0x7DEDA0", VA = "0x1807DFBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BFFAALFBPJG LLJLFKDOJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x698FE0", Offset = "0x6981E0", VA = "0x180698FE0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0E0", Offset = "0x7DD2E0", VA = "0x1807DE0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public AAALOJNNBAO DGFEHIBDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x698FD0", Offset = "0x6981D0", VA = "0x180698FD0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA60", Offset = "0x7DEC60", VA = "0x1807DFA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public CKEDNNDPMCB CDCAGCNBPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x698FB0", Offset = "0x6981B0", VA = "0x180698FB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7DC940", Offset = "0x7DBB40", VA = "0x1807DC940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public EPEKOCBMPEC LHFLCCJODOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5FAA00", Offset = "0x5F9C00", VA = "0x1805FAA00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x616EA0", Offset = "0x6160A0", VA = "0x180616EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public KIHKLLHPBDA OMPOGGLIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61A100", Offset = "0x619300", VA = "0x18061A100", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7340E0", Offset = "0x7332E0", VA = "0x1807340E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public FDOHHACFEDF GDEBAOBIGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x616A40", Offset = "0x615C40", VA = "0x180616A40", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7340F0", Offset = "0x7332F0", VA = "0x1807340F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public KKNMEFGEPHM OKOIGNAHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x698FF0", Offset = "0x6981F0", VA = "0x180698FF0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC20", Offset = "0x7DEE20", VA = "0x1807DFC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DKPMPECPDDD AFEFABILKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x698FC0", Offset = "0x6981C0", VA = "0x180698FC0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x69FA20", Offset = "0x69EC20", VA = "0x18069FA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public BBCDJNJMCJI FGIMALMAECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5FF210", Offset = "0x5FE410", VA = "0x1805FF210", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5FF220", Offset = "0x5FE420", VA = "0x1805FF220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public AELADMHNCJJ LLMNODIMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x698FA0", Offset = "0x6981A0", VA = "0x180698FA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7572C0", Offset = "0x7564C0", VA = "0x1807572C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public KBGFDKHAKPJ DDJGLCOLIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x698F90", Offset = "0x698190", VA = "0x180698F90", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7E4580", Offset = "0x7E3780", VA = "0x1807E4580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public HCKNJILHBPC KMEFNKMCJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x698F50", Offset = "0x698150", VA = "0x180698F50", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E4600", Offset = "0x7E3800", VA = "0x1807E4600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public HHOJOCKFCMF CPIFLJGCKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x736010", Offset = "0x735210", VA = "0x180736010", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x736490", Offset = "0x735690", VA = "0x180736490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public PCHMLFAONLB OOEEGJHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA10", Offset = "0x6BDC10", VA = "0x1806BEA10", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA70", Offset = "0x6BDC70", VA = "0x1806BEA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public JELHGHCAFII AFMAJDKLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x606380", Offset = "0x605580", VA = "0x180606380", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6063A0", Offset = "0x6055A0", VA = "0x1806063A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EJMPHAMHIAI HLPDOCHEGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x606390", Offset = "0x605590", VA = "0x180606390", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6063B0", Offset = "0x6055B0", VA = "0x1806063B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public HJPCCELBDGI FFCPBOHMELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6BF230", Offset = "0x6BE430", VA = "0x1806BF230", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6BF240", Offset = "0x6BE440", VA = "0x1806BF240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private bool PJBIOMKLMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA6C0", Offset = "0x8C98C0", VA = "0x1808CA6C0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool FIAMIHPAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8CAB10", Offset = "0x8C9D10", VA = "0x1808CAB10", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private CancellationToken JCDHDPNNCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8CA580", Offset = "0x8C9780", VA = "0x1808CA580", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private EIFHKIDJKKE AIEJCKPKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event Action FHCMGCFALPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8CA8A0", Offset = "0x8C9AA0", VA = "0x1808CA8A0", Slot = "33")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8CA970", Offset = "0x8C9B70", VA = "0x1808CA970", Slot = "34")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event ILICLCICENK ENHOCDCCIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF30", Offset = "0x8CA130", VA = "0x1808CAF30", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8CA910", Offset = "0x8C9B10", VA = "0x1808CA910", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event ILICLCICENK DCPODHGBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8CAFE0", Offset = "0x8CA1E0", VA = "0x1808CAFE0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAAB0", Offset = "0x8C9CB0", VA = "0x1808CAAB0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event ILICLCICENK JFFNAKGGBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8CAED0", Offset = "0x8CA0D0", VA = "0x1808CAED0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA520", Offset = "0x8C9720", VA = "0x1808CA520", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA240", VA = "0x1808CB040")]
	[Preserve]
	internal HOHHKCGCJEL([AHKDIAMPNOO(null)] EIFHKIDJKKE APJAHLFEOEM, [AHKDIAMPNOO(null)] PKOOEACNMEF ELPBHABCDMF, [AHKDIAMPNOO(null)] GJCIAICHFLK EAILCDOGGPJ, [AHKDIAMPNOO(null)] JGACAEEBELJ FEPEKJBDLDA, [AHKDIAMPNOO(null)] ODPBOGGBOGH AMKOKLDEMBK, [AHKDIAMPNOO(null)] CMHBPLAIECK CLJDGAMDPLA, [AHKDIAMPNOO(null)] FLNCIFOOELD KLGIFKEDGGN, [AHKDIAMPNOO(null)] BEIMJCANIFD BMHIOKOOOGJ, [AHKDIAMPNOO(null)] EBHEMCKGNHE IDMKGALFHGB, [AHKDIAMPNOO(null)] PJIPLBGGCID FPIFPLNAHCM, [AHKDIAMPNOO(null)] LADOLAEPIKK NJJAOFJGDIP, [AHKDIAMPNOO(null)] BFFAALFBPJG NLNNLJKBADC, [AHKDIAMPNOO(null)] AAALOJNNBAO HFIAPJOJCOJ, [AHKDIAMPNOO(null)] CKEDNNDPMCB AHGFPJLHMIA, [AHKDIAMPNOO(null)] EPEKOCBMPEC DLPMKPILMNP, [AHKDIAMPNOO(null)] KIHKLLHPBDA GDPLFIFFHJM, [AHKDIAMPNOO(null)] FDOHHACFEDF EJOOEIBLHOH, [AHKDIAMPNOO(null)] KKNMEFGEPHM NODAPLCIICA, [AHKDIAMPNOO(null)] DKPMPECPDDD CJCMMJGBGLD, [AHKDIAMPNOO(null)] BBCDJNJMCJI BBDOBDACGDE, [AHKDIAMPNOO(null)] KBGFDKHAKPJ HONNLFNIDIO, [AHKDIAMPNOO(null)] AELADMHNCJJ PCIHFCDBBMF, [AHKDIAMPNOO(null)] HCKNJILHBPC IMLMCDFEGGC, [AHKDIAMPNOO(null)] HHOJOCKFCMF PBKMBHJLGIE, [AHKDIAMPNOO(null)] PCHMLFAONLB BDHPDBMKMAP, [AHKDIAMPNOO(null)] EJMPHAMHIAI PAFAFHKFCBA, [AHKDIAMPNOO(null)] HJPCCELBDGI PKPPAFMEDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8CACE0", Offset = "0x8C9EE0", VA = "0x1808CACE0")]
	private void MGEPLKAAEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8CA740", Offset = "0x8C9940", VA = "0x1808CA740", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8CAF90", Offset = "0x8CA190", VA = "0x1808CAF90", Slot = "43")]
	private void PEPOCGOMGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC10", Offset = "0x8C9E10", VA = "0x1808CAC10", Slot = "49")]
	private Task LDMOFIBDOEA(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8CA900", Offset = "0x8C9B00", VA = "0x1808CA900", Slot = "50")]
	private void FOHMFNBHIGK(long NCGNHGHNMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8CA9D0", Offset = "0x8C9BD0", VA = "0x1808CA9D0", Slot = "51")]
	private bool GIENDJOHCKL(long BAHLJDONCPF, out DateTime KOCKNCLKFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8CA9F0", Offset = "0x8C9BF0", VA = "0x1808CA9F0", Slot = "47")]
	private Task HFOLEDLAFBI(string DLBDGCGKOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8CAB80", Offset = "0x8C9D80", VA = "0x1808CAB80", Slot = "44")]
	private Task<HOFMLDPLIAG> KDKGOJAENHM(FNJGHNELDIC OGNLMBODDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8CA6D0", Offset = "0x8C98D0", VA = "0x1808CA6D0", Slot = "45")]
	private Task<HOFMLDPLIAG> DFHJLILKLKE(FLLPHMIGOPF KOOENNCPJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8CAE10", Offset = "0x8CA010", VA = "0x1808CAE10", Slot = "46")]
	private Task<HOFMLDPLIAG> NKMJCMLAGDN(int LIGLKPEMMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8CA5A0", Offset = "0x8C97A0", VA = "0x1808CA5A0", Slot = "48")]
	[AsyncStateMachine(typeof(MJFIDJODLPO))]
	private Task<HOFMLDPLIAG> CGKNBPAJAFP(GHLNAHICKHI OKLBJDMNAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC70", Offset = "0x8C9E70", VA = "0x1808CAC70")]
	[IteratorStateMachine(typeof(CIIJCBHNBFF))]
	private IEnumerable<CDKMFDLCHBK> LFBEIJHHDIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8CADB0", Offset = "0x8C9FB0", VA = "0x1808CADB0")]
	[CompilerGenerated]
	private void MOLJKDENPOB(CDKMFDLCHBK OFADDADJKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class FKALEPDEFDE : JCBFIJIPLCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct JBKCJALIHJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public FKALEPDEFDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9C6210", Offset = "0x9C5410", VA = "0x1809C6210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9C64E0", Offset = "0x9C56E0", VA = "0x1809C64E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7FC900", Offset = "0x7FBB00", VA = "0x1807FC900")]
	public FKALEPDEFDE(BNHHCILIEOE LLLBIFNKIPP, JGACAEEBELJ FEPEKJBDLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9BF490", Offset = "0x9BE690", VA = "0x1809BF490", Slot = "4")]
	[AsyncStateMachine(typeof(JBKCJALIHJK))]
	public Task<bool> GEEKKNFPFOG(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x9BF3D0", Offset = "0x9BE5D0", VA = "0x1809BF3D0")]
	[CompilerGenerated]
	private object BDBHAFIOBMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal class CKNOLLGCGBE : JCBFIJIPLCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PJHHKFPAOAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CKNOLLGCGBE <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xC42D40", Offset = "0xC41F40", VA = "0x180C42D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xC43300", Offset = "0xC42500", VA = "0x180C43300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float PABECLHGMLL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xC36D00", Offset = "0xC35F00", VA = "0x180C36D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7FC900", Offset = "0x7FBB00", VA = "0x1807FC900")]
	public CKNOLLGCGBE(BNHHCILIEOE LLLBIFNKIPP, JGACAEEBELJ FEPEKJBDLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xC36BD0", Offset = "0xC35DD0", VA = "0x180C36BD0", Slot = "4")]
	[AsyncStateMachine(typeof(PJHHKFPAOAE))]
	public Task<bool> GEEKKNFPFOG(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xC36AB0", Offset = "0xC35CB0", VA = "0x180C36AB0")]
	[CompilerGenerated]
	private object DPJAJLAHODC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class JLFPMHFMHMD : JCBFIJIPLCM
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JCPBLECPNCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JLFPMHFMHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Matchmaking.FGCDMIPDEMD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AAPOAKFHPCO newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JCPBLECPNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8D0A20", Offset = "0x8CFC20", VA = "0x1808D0A20")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B50", Offset = "0x8CFD50", VA = "0x1808D0B50")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8D0BB0", Offset = "0x8CFDB0", VA = "0x1808D0BB0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LBKCBMDPIIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JLFPMHFMHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JCPBLECPNCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<Matchmaking.FGCDMIPDEMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5040", Offset = "0x8D4240", VA = "0x1808D5040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5860", Offset = "0x8D4A60", VA = "0x1808D5860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float PABECLHGMLL = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8D1160", Offset = "0x8D0360", VA = "0x1808D1160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7FC900", Offset = "0x7FBB00", VA = "0x1807FC900")]
	public JLFPMHFMHMD(BNHHCILIEOE LLLBIFNKIPP, JGACAEEBELJ FEPEKJBDLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8D1030", Offset = "0x8D0230", VA = "0x1808D1030", Slot = "4")]
	[AsyncStateMachine(typeof(LBKCBMDPIIA))]
	public Task<bool> GEEKKNFPFOG(CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal interface JCBFIJIPLCM
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GEEKKNFPFOG(CancellationToken GENHLOEKMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct HDAPEDOFFLH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class AOHJICFIHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BNHHCILIEOE manager;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public AOHJICFIHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9B3B90", Offset = "0x9B2D90", VA = "0x1809B3B90")]
		internal Task <CreateTask>b__0(MOPOKHJCMLO data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct AAPOODOPCFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HDAPEDOFFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <restore>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2410", Offset = "0x9B1610", VA = "0x1809B2410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9B2700", Offset = "0x9B1900", VA = "0x1809B2700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FOKEOJLKIIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HDAPEDOFFLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9BF590", Offset = "0x9BE790", VA = "0x1809BF590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationToken GENHLOEKMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BNHHCILIEOE PEKPJMOPJFC;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private PKOOEACNMEF GLIPAFNENJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9C3730", Offset = "0x9C2930", VA = "0x1809C3730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B50", Offset = "0x9C2D50", VA = "0x1809C3B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9C3870", Offset = "0x9C2A70", VA = "0x1809C3870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private PJIPLBGGCID OFPJCGGPBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9C3A00", Offset = "0x9C2C00", VA = "0x1809C3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x9C3BA0", Offset = "0x9C2DA0", VA = "0x1809C3BA0")]
	public HDAPEDOFFLH(CancellationToken GENHLOEKMNL, BNHHCILIEOE PEKPJMOPJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x9C3420", Offset = "0x9C2620", VA = "0x1809C3420")]
	public static AKPLMNLHDHF BCJDFKAMLLA(BNHHCILIEOE PEKPJMOPJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x9C38F0", Offset = "0x9C2AF0", VA = "0x1809C38F0")]
	[AsyncStateMachine(typeof(AAPOODOPCFH))]
	public Task<bool> JMOHDGKJGBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x9C3780", Offset = "0x9C2980", VA = "0x1809C3780")]
	private bool GGGLILKMAFB(out FileInfo OOCOKLLBALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x9C3A50", Offset = "0x9C2C50", VA = "0x1809C3A50")]
	[AsyncStateMachine(typeof(FOKEOJLKIIA))]
	private Task MMCNLKKHLJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x9C35A0", Offset = "0x9C27A0", VA = "0x1809C35A0")]
	private Task<bool> EEHCKDIABPD(FileInfo OOCOKLLBALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x9C34B0", Offset = "0x9C26B0", VA = "0x1809C34B0")]
	private Task DIPONBPBOHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x9C36C0", Offset = "0x9C28C0", VA = "0x1809C36C0")]
	private void EGLNBBLMBHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct NOFNOFIIIAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EPEKOCBMPEC DLPMKPILMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Guid BPIHMIEIAOA;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private Task<(HOFMLDPLIAG, Task)> OOJODKAMGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x20E0A00", Offset = "0x20DFC00", VA = "0x1820E0A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x877920", Offset = "0x876B20", VA = "0x180877920")]
	public NOFNOFIIIAA(EPEKOCBMPEC DLPMKPILMNP, Guid BPIHMIEIAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x20E09B0", Offset = "0x20DFBB0", VA = "0x1820E09B0")]
	public TaskAwaiter<(HOFMLDPLIAG, Task)> ICLDHCMEEFH()
	{
		return default(TaskAwaiter<(HOFMLDPLIAG, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x20E08E0", Offset = "0x20DFAE0", VA = "0x1820E08E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal struct IHINOMAKNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly TaskCompletionSource<(HOFMLDPLIAG, Task)> CLKHGEMHBBI;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Task<(HOFMLDPLIAG, Task)> OOJODKAMGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8CC220", Offset = "0x8CB420", VA = "0x1808CC220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8CC260", Offset = "0x8CB460", VA = "0x1808CC260")]
	public IHINOMAKNED(TimeSpan DKDELEMGGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8CC100", Offset = "0x8CB300", VA = "0x1808CC100")]
	public void JBLPIMIJDGA(Task CDBOLHIHKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8CC190", Offset = "0x8CB390", VA = "0x1808CC190")]
	public void LONMFPMONAF(HOFMLDPLIAG EPDJCIBDHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0B0", Offset = "0x8CB2B0", VA = "0x1808CC0B0")]
	public void CIFAPIKKPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8CC030", Offset = "0x8CB230", VA = "0x1808CC030")]
	internal void BJLLMILMICA(string HGHEMBBLDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Preserve]
internal class EGBALGCDPNG : EBHEMCKGNHE, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct ACEDDFHOBCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EGBALGCDPNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9B2750", Offset = "0x9B1950", VA = "0x1809B2750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KHMNKHEBLDL MBPCBHMPACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string PAABFDHBANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Task OBAEGAFHLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool FIHIHAMOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8CE0", Offset = "0x9B7EE0", VA = "0x1809B8CE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Task CJPFIKGKEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8FC0", Offset = "0x9B81C0", VA = "0x1809B8FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450", Slot = "7")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x9B8E40", Offset = "0x9B8040", VA = "0x1809B8E40", Slot = "6")]
	public void MDGFBBGIDPC(Task HAJJIJILELD, string DKPALGBAMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x9B8D10", Offset = "0x9B7F10", VA = "0x1809B8D10")]
	[AsyncStateMachine(typeof(ACEDDFHOBCP))]
	private Task EFBAGENPCDK(Task MFLHJJCCJMJ, string DKPALGBAMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9B9020", Offset = "0x9B8220", VA = "0x1809B9020")]
	public EGBALGCDPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class DKPCILJKCKJ : JELHGHCAFII, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool PHEBPDJJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IAOOBAIGPGE HFGOAPBEBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private EJMPHAMHIAI PAFAFHKFCBA;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public IAOOBAIGPGE IINDNBICOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C40", Offset = "0x9B5E40", VA = "0x1809B6C40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9B6D30", Offset = "0x9B5F30", VA = "0x1809B6D30", Slot = "7")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x9B6AC0", Offset = "0x9B5CC0", VA = "0x1809B6AC0", Slot = "5")]
	public void DCCOMBNMNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x9B6A80", Offset = "0x9B5C80", VA = "0x1809B6A80", Slot = "6")]
	public void CAPCGBOICGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x9B6CB0", Offset = "0x9B5EB0", VA = "0x1809B6CB0")]
	private Task FEBDFMFMFEL(GBJKDDAHPNN ILPNDFPPNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x9B6A80", Offset = "0x9B5C80", VA = "0x1809B6A80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public DKPCILJKCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class OKHLLPPDAAG : EJMPHAMHIAI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class ECIGAMJCGAI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly EFGECEDCFOH PJGJJPKPHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly string JCNAPFOCJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly T LJCMBCOMOJI;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public T MDDADGNJOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7CC130", Offset = "0x7CB330", VA = "0x1807CC130")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7CC200", Offset = "0x7CB400", VA = "0x1807CC200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF8B0", Offset = "0x3EBEAB0", VA = "0x183EBF8B0")]
		public ECIGAMJCGAI(EFGECEDCFOH PJGJJPKPHEA, string JCNAPFOCJDI, T LJCMBCOMOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF4C0", Offset = "0x3EBE6C0", VA = "0x183EBF4C0")]
		private void PPEGFBPOJBJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly ECIGAMJCGAI<TimeSpan> JHDINJFMCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ECIGAMJCGAI<TimeSpan> EDHHHDKHPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ECIGAMJCGAI<TimeSpan> OFEFKDOHJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly ECIGAMJCGAI<TimeSpan> MDPFEILPCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly ECIGAMJCGAI<bool> AHNMDNAHEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ECIGAMJCGAI<bool> POALHMNMMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly ECIGAMJCGAI<bool> BFJCBCHEKFK;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TimeSpan OODIHHINMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x20E4B60", Offset = "0x20E3D60", VA = "0x1820E4B60", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public TimeSpan FCJOKGLDELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x20E4BE0", Offset = "0x20E3DE0", VA = "0x1820E4BE0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public TimeSpan ILHJBENDEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x20E4BA0", Offset = "0x20E3DA0", VA = "0x1820E4BA0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TimeSpan DMKFOHCJAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x20E4B20", Offset = "0x20E3D20", VA = "0x1820E4B20", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool NLBPEPNEHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x20E4AE0", Offset = "0x20E3CE0", VA = "0x1820E4AE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool CCPCAJNMIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x20E4AA0", Offset = "0x20E3CA0", VA = "0x1820E4AA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool DMBDDAMPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x20E4C20", Offset = "0x20E3E20", VA = "0x1820E4C20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x20E4C60", Offset = "0x20E3E60", VA = "0x1820E4C60")]
	[Preserve]
	public OKHLLPPDAAG([AHKDIAMPNOO(null)] EFGECEDCFOH PJGJJPKPHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Preserve]
internal class KIENODGMGEB : LADOLAEPIKK, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FJCFAFBBKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MIPEDOLMHFF roomEvent;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FJCFAFBBKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C9260", Offset = "0x8C8460", VA = "0x1808C9260")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action GFJGPAMPAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4240", Offset = "0x8D3440", VA = "0x1808D4240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4380", Offset = "0x8D3580", VA = "0x1808D4380", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event ILICLCICENK OBANBANNLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4600", Offset = "0x8D3800", VA = "0x1808D4600", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4420", Offset = "0x8D3620", VA = "0x1808D4420", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event ILICLCICENK OFGFDFBNHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D42E0", Offset = "0x8D34E0", VA = "0x1808D42E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D44C0", Offset = "0x8D36C0", VA = "0x1808D44C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event ILICLCICENK EJCDIOBMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D4560", Offset = "0x8D3760", VA = "0x1808D4560", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4170", Offset = "0x8D3370", VA = "0x1808D4170", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "16")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F20", Offset = "0x8D3120", VA = "0x1808D3F20", Slot = "12")]
	public void DGBLFFPMACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8D3EC0", Offset = "0x8D30C0", VA = "0x1808D3EC0", Slot = "13")]
	public void BMAEELBPFBN(MIPEDOLMHFF PENHLMIDEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8D3EF0", Offset = "0x8D30F0", VA = "0x1808D3EF0", Slot = "14")]
	public void CPBKHPOKMFF(MIPEDOLMHFF PENHLMIDEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8D4210", Offset = "0x8D3410", VA = "0x1808D4210", Slot = "15")]
	public void FEDGECBKLFM(MIPEDOLMHFF PENHLMIDEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8D46A0", Offset = "0x8D38A0", VA = "0x1808D46A0")]
	private void PJMIDIIBLNP(ILICLCICENK AHOPBMACHGE, MIPEDOLMHFF PENHLMIDEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public KIENODGMGEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Preserve]
internal class GHJPPNHOFCO : BFFAALFBPJG, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct ALBEHCDEMPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public GHJPPNHOFCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B3710", Offset = "0x9B2910", VA = "0x1809B3710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GLICCOHINMB : IAsyncStateMachine
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
		public GHJPPNHOFCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C2E00", Offset = "0x9C2000", VA = "0x1809C2E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class KONGDLEFALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public KONGDLEFALE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9C7560", Offset = "0x9C6760", VA = "0x1809C7560")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct CHLHINJDLHJ : IAsyncStateMachine
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
		public GHJPPNHOFCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private KONGDLEFALE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B4A50", Offset = "0x9B3C50", VA = "0x1809B4A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B5110", Offset = "0x9B4310", VA = "0x1809B5110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class ONLLFLOIEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ONLLFLOIEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9CB170", Offset = "0x9CA370", VA = "0x1809CB170")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private JCBFIJIPLCM[] KCBIFOMDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CancellationTokenSource OEEOLLPACLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private int AMHNEFLOJNB;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x9C1F40", Offset = "0x9C1140", VA = "0x1809C1F40", Slot = "7")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x9C1B60", Offset = "0x9C0D60", VA = "0x1809C1B60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FC0", Offset = "0x9C11C0", VA = "0x1809C1FC0", Slot = "6")]
	public void OHLJMIHNBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x9C18F0", Offset = "0x9C0AF0", VA = "0x1809C18F0", Slot = "5")]
	public void CJJHJONICLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x9C1E30", Offset = "0x9C1030", VA = "0x1809C1E30", Slot = "4")]
	[AsyncStateMachine(typeof(ALBEHCDEMPJ))]
	public Task HEJEBAGLDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x9C15D0", Offset = "0x9C07D0", VA = "0x1809C15D0")]
	private void ADFJKKFDDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x9C1A40", Offset = "0x9C0C40", VA = "0x1809C1A40")]
	[AsyncStateMachine(typeof(GLICCOHINMB))]
	private Task DGOMHNDEKCB(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x9C1D00", Offset = "0x9C0F00", VA = "0x1809C1D00")]
	[AsyncStateMachine(typeof(CHLHINJDLHJ))]
	private Task<bool> GJNHIPPIODP(int MJNAIOAAGCG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x9C2320", Offset = "0x9C1520", VA = "0x1809C2320")]
	private void PIJEHENGBEA(int MJNAIOAAGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x9C2130", Offset = "0x9C1330", VA = "0x1809C2130")]
	private void OJHJEBJLIFK(int MJNAIOAAGCG, bool ELONJFDADAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x9C1B70", Offset = "0x9C0D70", VA = "0x1809C1B70")]
	private void GGAECDACOJP(int MJNAIOAAGCG, Exception LGPNHAIJKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x9C2230", Offset = "0x9C1430", VA = "0x1809C2230")]
	private void ONLIADEOEDG(CancellationToken GENHLOEKMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public GHJPPNHOFCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Preserve]
internal class ADKCIOFGMDA : CKEDNNDPMCB, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LOOAEADLOFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public ADKCIOFGMDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public MOPOKHJCMLO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xC41460", Offset = "0xC40660", VA = "0x180C41460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class JMLDJDGAJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ADKCIOFGMDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public MOPOKHJCMLO roomData;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JMLDJDGAJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xC3F5E0", Offset = "0xC3E7E0", VA = "0x180C3F5E0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct CBKFEHNKGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AKPLMNLHDHF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xC346B0", Offset = "0xC338B0", VA = "0x180C346B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct CDHHNGKJKBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public ADKCIOFGMDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xC349A0", Offset = "0xC33BA0", VA = "0x180C349A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HashSet<AKPLMNLHDHF> IJDPFJIJGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private GJCIAICHFLK EAILCDOGGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private MMPKOLCIOMJ AOJFELAELIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private BDANEGNLGIH ONAEJMMHMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private IDisposable BFOFLKCJMDH;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool ELFGBLKEPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xC2EA70", Offset = "0xC2DC70", VA = "0x180C2EA70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	internal Task OOJODKAMGMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xC2ED40", Offset = "0xC2DF40", VA = "0x180C2ED40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xC2EAA0", Offset = "0xC2DCA0", VA = "0x180C2EAA0", Slot = "6")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xC2E670", Offset = "0xC2D870", VA = "0x180C2E670", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xC2EA10", Offset = "0xC2DC10", VA = "0x180C2EA10", Slot = "5")]
	public bool GMIPBPPKLPM(AKPLMNLHDHF HJPBFNCLHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xC2E820", Offset = "0xC2DA20", VA = "0x180C2E820")]
	private void FOACLJIFDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0xC2EE50", Offset = "0xC2E050", VA = "0x180C2EE50")]
	private void PJDAJCONKMC(MOPOKHJCMLO FCLGFPAONJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xC2E550", Offset = "0xC2D750", VA = "0x180C2E550")]
	[AsyncStateMachine(typeof(LOOAEADLOFD))]
	private Task DPAKAHPBHGL(MOPOKHJCMLO FCLGFPAONJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xC2E960", Offset = "0xC2DB60", VA = "0x180C2E960")]
	private Func<CancellationToken, List<Task>> GABHCBLKNJH(MOPOKHJCMLO FCLGFPAONJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0xC2E0B0", Offset = "0xC2D2B0", VA = "0x180C2E0B0")]
	private List<Task> CPLKBHHJICC(MOPOKHJCMLO FCLGFPAONJE, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xC2E6F0", Offset = "0xC2D8F0", VA = "0x180C2E6F0")]
	[AsyncStateMachine(typeof(CBKFEHNKGMA))]
	private Task EMHFPKJAJCO(AKPLMNLHDHF KAHGHEBEBLP, MOPOKHJCMLO ADIGGFBANFM, CancellationToken HCPCDENCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xC2DFB0", Offset = "0xC2D1B0", VA = "0x180C2DFB0")]
	[AsyncStateMachine(typeof(CDHHNGKJKBP))]
	private Task CJKHECGKDBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xC2ED50", Offset = "0xC2DF50", VA = "0x180C2ED50")]
	private void OHLJMIHNBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xC2F0A0", Offset = "0xC2E2A0", VA = "0x180C2F0A0")]
	public ADKCIOFGMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Preserve]
internal class EPMJBMEJFOB : AAALOJNNBAO, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct EFILOOKJHKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9B8500", Offset = "0x9B7700", VA = "0x1809B8500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct NICCIHLMIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private global::AHNHODFKKCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private DPBKAPJPKAG <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private HFFHIBGKKJD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9C91C0", Offset = "0x9C83C0", VA = "0x1809C91C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class HKPEDNDEELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Task<FLLOKKAPGEA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HKPEDNDEELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		internal Task<FLLOKKAPGEA> <ConnectToRoomAndRunLoadLogic>b__0(CIHEPFKAKNH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GBDCDBKJINA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public DPBKAPJPKAG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private HKPEDNDEELI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private KBPNBEMIOLG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private CIHEPFKAKNH <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private MOPMEHDPIJM <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<FLLOKKAPGEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9BF940", Offset = "0x9BEB40", VA = "0x1809BF940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct KNJDAMODJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private CIHEPFKAKNH <disconnectTimerScope>5__3;

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
		private CIHEPFKAKNH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x9C6DA0", Offset = "0x9C5FA0", VA = "0x1809C6DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct FJGMEOPJGPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private EIFHKIDJKKE <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9BEFF0", Offset = "0x9BE1F0", VA = "0x1809BEFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct FBBKBDJPBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public DPBKAPJPKAG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private CIHEPFKAKNH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<LFHKFJCCDDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9BD450", Offset = "0x9BC650", VA = "0x1809BD450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HOIMPGBCLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HOIMPGBCLPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CEMIIPFGHOP
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
		public HOIMPGBCLPJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CEMIIPFGHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9B4100", Offset = "0x9B3300", VA = "0x1809B4100")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4010", Offset = "0x9B3210", VA = "0x1809B4010")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct CJILBBNOGJI : IAsyncStateMachine
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
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private CEMIIPFGHOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5160", Offset = "0x9B4360", VA = "0x1809B5160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct EPAHLGDAEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public DPBKAPJPKAG joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public FLLOKKAPGEA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AAPOAKFHPCO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public KBPNBEMIOLG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private CIHEPFKAKNH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x9B9860", Offset = "0x9B8A60", VA = "0x1809B9860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct DKKLOIAOBLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private CIHEPFKAKNH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9B6630", Offset = "0x9B5830", VA = "0x1809B6630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct NIIBJPOHHGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9C9B00", Offset = "0x9C8D00", VA = "0x1809C9B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct ADPKKFJJMFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CC0", Offset = "0x9B1EC0", VA = "0x1809B2CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct PECMJGIPKFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<HOFMLDPLIAG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9CB590", Offset = "0x9CA790", VA = "0x1809CB590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct GLBCFPDDEOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public EPMJBMEJFOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B40", Offset = "0x9C1D40", VA = "0x1809C2B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class NINECEPALHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public NINECEPALHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9CA1E0", Offset = "0x9C93E0", VA = "0x1809CA1E0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class EOEACLBNDND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EOEACLBNDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9B97D0", Offset = "0x9B89D0", VA = "0x1809B97D0")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MPPKGMHJHIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MPPKGMHJHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9C8200", Offset = "0x9C7400", VA = "0x1809C8200")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class MADOAADPNJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MADOAADPNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9C7CD0", Offset = "0x9C6ED0", VA = "0x1809C7CD0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly string DGGOAPLIGOL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly string JKHHHIDMIAF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly string FADGDDOOLCG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static readonly Guid OECPKIDGBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private BEIMJCANIFD BMHIOKOOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GJCIAICHFLK EAILCDOGGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private BFFAALFBPJG NLNNLJKBADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private EBHEMCKGNHE IDMKGALFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private LADOLAEPIKK NJJAOFJGDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private EJMPHAMHIAI PAFAFHKFCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IDisposable BFOFLKCJMDH;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public TaskStatus MALMDEHEPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x961C10", Offset = "0x960E10", VA = "0x180961C10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x961BE0", Offset = "0x960DE0", VA = "0x180961BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9BB540", Offset = "0x9BA740", VA = "0x1809BB540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x9BC4B0", Offset = "0x9BB6B0", VA = "0x1809BC4B0", Slot = "6")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9BAFC0", Offset = "0x9BA1C0", VA = "0x1809BAFC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x9BC1C0", Offset = "0x9BB3C0", VA = "0x1809BC1C0", Slot = "5")]
	[AsyncStateMachine(typeof(EFILOOKJHKE))]
	public Task LDMHJPGEAJF(AAPOAKFHPCO LCKJIJGJFOH, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x9BC380", Offset = "0x9BB580", VA = "0x1809BC380")]
	[AsyncStateMachine(typeof(NICCIHLMIEE))]
	private Task MCICMCAFAPI(AAPOAKFHPCO LCKJIJGJFOH, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8B0", Offset = "0x9BBAB0", VA = "0x1809BC8B0")]
	private static void NCNBNNHMHBB(AAPOAKFHPCO LCKJIJGJFOH, Exception LGPNHAIJKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x9BA250", Offset = "0x9B9450", VA = "0x1809BA250")]
	private static void CCBGOPIOMDK(HFFHIBGKKJD CCOMKHLHDOL, Exception LGPNHAIJKII, [Optional] List<int> PIDCPAKBLFB, int AMHNEFLOJNB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x9BCA40", Offset = "0x9BBC40", VA = "0x1809BCA40")]
	[AsyncStateMachine(typeof(GBDCDBKJINA))]
	private Task NDALLGOACBP(CIHEPFKAKNH NDCCOMJDOFK, AAPOAKFHPCO LCKJIJGJFOH, DPBKAPJPKAG LGLPKJOAIPG, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x9BCE20", Offset = "0x9BC020", VA = "0x1809BCE20")]
	private void OCJDLIJEOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x9BAB90", Offset = "0x9B9D90", VA = "0x1809BAB90")]
	[AsyncStateMachine(typeof(KNJDAMODJNF))]
	private Task DAJILPODKOH(CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x9BACC0", Offset = "0x9B9EC0", VA = "0x1809BACC0")]
	private void DBOKLNMDLKI(AAPOAKFHPCO LCKJIJGJFOH, CancellationToken HJBBMMLLNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x9BCBB0", Offset = "0x9BBDB0", VA = "0x1809BCBB0")]
	private void NMFJDBLLKEP(AAPOAKFHPCO LCKJIJGJFOH, DPBKAPJPKAG LGLPKJOAIPG, OperationCanceledException DOFPFBINLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x9BB0D0", Offset = "0x9BA2D0", VA = "0x1809BB0D0")]
	private void GKONCJKPFDL(AAPOAKFHPCO LCKJIJGJFOH, DPBKAPJPKAG LGLPKJOAIPG, Exception LGPNHAIJKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9BBF70", Offset = "0x9BB170", VA = "0x1809BBF70")]
	private void KILHLHJCMID(AAPOAKFHPCO LCKJIJGJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x9BA8E0", Offset = "0x9B9AE0", VA = "0x1809BA8E0")]
	private static MIPEDOLMHFF CJNADPEAIIB(AAPOAKFHPCO LCKJIJGJFOH)
	{
		return default(MIPEDOLMHFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x9BBCA0", Offset = "0x9BAEA0", VA = "0x1809BBCA0")]
	[AsyncStateMachine(typeof(FJGMEOPJGPD))]
	private Task JNFBLNBMIBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA9F0", VA = "0x1809BB7F0")]
	private static LFHKFJCCDDJ IJKCFKIOPLK(AAPOAKFHPCO LCKJIJGJFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x9BC750", Offset = "0x9BB950", VA = "0x1809BC750")]
	[AsyncStateMachine(typeof(FBBKBDJPBAJ))]
	private Task MMKMLHADDKB(AAPOAKFHPCO LCKJIJGJFOH, DPBKAPJPKAG LGLPKJOAIPG, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken HCJIEFGHELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x9B9FC0", Offset = "0x9B91C0", VA = "0x1809B9FC0")]
	[AsyncStateMachine(typeof(CJILBBNOGJI))]
	private Task AGMPKNAJOMK(AAPOAKFHPCO LCKJIJGJFOH, CancellationTokenSource BOJOPKIPGEM, Task GDGGEJEBKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9BBB20", Offset = "0x9BAD20", VA = "0x1809BBB20")]
	[AsyncStateMachine(typeof(EPAHLGDAEJP))]
	private Task JHGNOGMGAEP(FLLOKKAPGEA MKCELNICJFG, KBPNBEMIOLG HPBFEAPJMBG, AAPOAKFHPCO EAKNOJJGLHB, DPBKAPJPKAG NDMKIKPADDD, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken EDLOBBDGPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x9BB340", Offset = "0x9BA540", VA = "0x1809BB340")]
	private DPBKAPJPKAG GLLPFBFIABC(DPBKAPJPKAG NDMKIKPADDD, ref CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x9BB8A0", Offset = "0x9BAAA0", VA = "0x1809BB8A0")]
	[AsyncStateMachine(typeof(DKKLOIAOBLL))]
	private Task JBCAEAANEJB(CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x9BAA60", Offset = "0x9B9C60", VA = "0x1809BAA60")]
	[AsyncStateMachine(typeof(NIIBJPOHHGI))]
	private Task CMJCIKJJNBJ(CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9E0", Offset = "0x9BABE0", VA = "0x1809BB9E0")]
	[AsyncStateMachine(typeof(ADPKKFJJMFJ))]
	private Task JELEMDIOCJG(CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x9BB6C0", Offset = "0x9BA8C0", VA = "0x1809BB6C0")]
	[AsyncStateMachine(typeof(PECMJGIPKFF))]
	private Task IEAGFIKMMEP(MOPOKHJCMLO ADIGGFBANFM, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x9BA920", Offset = "0x9B9B20", VA = "0x1809BA920")]
	[AsyncStateMachine(typeof(GLBCFPDDEOE))]
	private Task CKLBDMKAJJP(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken HCJIEFGHELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x9BD080", Offset = "0x9BC280", VA = "0x1809BD080")]
	private static void OJGONIGGCNP(AAPOAKFHPCO LCKJIJGJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x9BD1A0", Offset = "0x9BC3A0", VA = "0x1809BD1A0")]
	private void OOLCOLFCDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x9BBEF0", Offset = "0x9BB0F0", VA = "0x1809BBEF0")]
	private void KFDKCNHAJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9BA1C0", Offset = "0x9B93C0", VA = "0x1809BA1C0")]
	private void BLHOGCECCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x9BC2F0", Offset = "0x9BB4F0", VA = "0x1809BC2F0")]
	private void MBIOCOPMLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9BCF40", Offset = "0x9BC140", VA = "0x1809BCF40")]
	private static void OEEOFBNFPPG(AAPOAKFHPCO LCKJIJGJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x9BA110", Offset = "0x9B9310", VA = "0x1809BA110")]
	private static void AOODBCDEMGF(AAPOAKFHPCO LCKJIJGJFOH, CancellationToken HCJIEFGHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x9BBDA0", Offset = "0x9BAFA0", VA = "0x1809BBDA0")]
	private static void KFAFMLHBJCO(AAPOAKFHPCO LCKJIJGJFOH, Exception LGPNHAIJKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9BB590", Offset = "0x9BA790", VA = "0x1809BB590")]
	private void IBEFKMLCACD(AAPOAKFHPCO LCKJIJGJFOH, Task GDGGEJEBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x9BB010", Offset = "0x9BA210", VA = "0x1809BB010")]
	private static void ELLDIMGOPPA(Func<string> GKALFAMOPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x9BD440", Offset = "0x9BC640", VA = "0x1809BD440")]
	public EPMJBMEJFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class MKAKBCGDGJD : EPEKOCBMPEC, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PPLLMMBKJNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PPLLMMBKJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB150", Offset = "0x8DA350", VA = "0x1808DB150")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PFIGKCONHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PFIGKCONHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB100", Offset = "0x8DA300", VA = "0x1808DB100")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JHJKMPBAMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JHJKMPBAMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8D0FE0", Offset = "0x8D01E0", VA = "0x1808D0FE0")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class CJHDOLEOIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CJHDOLEOIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8C5CD0", Offset = "0x8C4ED0", VA = "0x1808C5CD0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class KAJBNPKABCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public KAJBNPKABCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8D28D0", Offset = "0x8D1AD0", VA = "0x1808D28D0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Dictionary<Guid, IHINOMAKNED> DLPMKPILMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly TimeSpan BIGDFHBCAPO;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "10")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8D8A10", Offset = "0x8D7C10", VA = "0x1808D8A10", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x8D8A20", Offset = "0x8D7C20", VA = "0x1808D8A20", Slot = "4")]
	public NOFNOFIIIAA KAGEPJABGKM(Guid BPIHMIEIAOA)
	{
		return default(NOFNOFIIIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x8D8540", Offset = "0x8D7740", VA = "0x1808D8540", Slot = "5")]
	public bool CEDMIKNCMLN(Guid BPIHMIEIAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x8D90A0", Offset = "0x8D82A0", VA = "0x1808D90A0", Slot = "8")]
	public bool OHLJMIHNBPN(Guid BPIHMIEIAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x8D8CB0", Offset = "0x8D7EB0", VA = "0x1808D8CB0", Slot = "6")]
	public bool KBPOEOCDLAO(Guid BPIHMIEIAOA, Task CDBOLHIHKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8D87A0", Offset = "0x8D79A0", VA = "0x1808D87A0", Slot = "7")]
	public bool COLPDMELILI(Guid BPIHMIEIAOA, HOFMLDPLIAG EPDJCIBDHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8D9010", Offset = "0x8D8210", VA = "0x1808D9010", Slot = "9")]
	public Task<(HOFMLDPLIAG, Task)> MGBCAGCLBLD(Guid BPIHMIEIAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8D92E0", Offset = "0x8D84E0", VA = "0x1808D92E0")]
	private void ONIFAAJAPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8D9550", Offset = "0x8D8750", VA = "0x1808D9550")]
	public MKAKBCGDGJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Preserve]
internal class CMACJIIGJMN : KIHKLLHPBDA, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class CPNHHJMKGML : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly AAPOAKFHPCO BKHKFCEGGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly CancellationTokenSource OEEOLLPACLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public readonly CancellationToken PGIMJANEKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private bool DDOBIEDELMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private bool ODHDMLLLNOE;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xC39600", Offset = "0xC38800", VA = "0x180C39600")]
		public CPNHHJMKGML(AAPOAKFHPCO BKHKFCEGGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xC394D0", Offset = "0xC386D0", VA = "0x180C394D0")]
		public void OHLJMIHNBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xC394A0", Offset = "0xC386A0", VA = "0x180C394A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class OOJILFFBDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public GBJKDDAHPNN disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OOJILFFBDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xC42860", Offset = "0xC41A60", VA = "0x180C42860")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct IEIBCAJHBKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public GBJKDDAHPNN disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CMACJIIGJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xC3E000", Offset = "0xC3D200", VA = "0x180C3E000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class OFACEHDGPFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OFACEHDGPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xC424C0", Offset = "0xC416C0", VA = "0x180C424C0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct JEAHDDFNIKP : IAsyncStateMachine
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
		public CMACJIIGJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xC3E9E0", Offset = "0xC3DBE0", VA = "0x180C3E9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xC3F460", Offset = "0xC3E660", VA = "0x180C3F460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class KGFAOLLNKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AAPOAKFHPCO newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public KGFAOLLNKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xC40B20", Offset = "0xC3FD20", VA = "0x180C40B20")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xC40BB0", Offset = "0xC3FDB0", VA = "0x180C40BB0")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xC40BF0", Offset = "0xC3FDF0", VA = "0x180C40BF0")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class PGAGKIIACAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PGAGKIIACAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xC42CB0", Offset = "0xC41EB0", VA = "0x180C42CB0")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct JNEJBKOMHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AAPOAKFHPCO newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CMACJIIGJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private KGFAOLLNKIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xC3F610", Offset = "0xC3E810", VA = "0x180C3F610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private GJCIAICHFLK EAILCDOGGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private BFFAALFBPJG NLNNLJKBADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private EJMPHAMHIAI PAFAFHKFCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private AAALOJNNBAO HFIAPJOJCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long KPDCLFNNHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private CPNHHJMKGML IDDBBNNHBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool NEGJGDKAAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private Task OCEFELPHBAC;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xC382D0", Offset = "0xC374D0", VA = "0x180C382D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool AEGAACHIAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x92AC30", Offset = "0x929E30", VA = "0x18092AC30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xC38AE0", Offset = "0xC37CE0", VA = "0x180C38AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xC38890", Offset = "0xC37A90", VA = "0x180C38890", Slot = "4")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xC37DA0", Offset = "0xC36FA0", VA = "0x180C37DA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xC384A0", Offset = "0xC376A0", VA = "0x180C384A0")]
	[AsyncStateMachine(typeof(IEIBCAJHBKF))]
	private Task JDHDJGMFJPL(GBJKDDAHPNN CGJBKJCHHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xC37EF0", Offset = "0xC370F0", VA = "0x180C37EF0")]
	private void FEFOHCOEKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0xC380F0", Offset = "0xC372F0", VA = "0x180C380F0")]
	private void GLJLGJNBPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xC385B0", Offset = "0xC377B0", VA = "0x180C385B0")]
	private void LMPBAMHKPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xC38BA0", Offset = "0xC37DA0", VA = "0x180C38BA0")]
	private bool NPJHLHFEONB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xC37CC0", Offset = "0xC36EC0", VA = "0x180C37CC0")]
	[AsyncStateMachine(typeof(JEAHDDFNIKP))]
	private void DKBKEMDKBIH(int JNIHCAGKOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xC38C20", Offset = "0xC37E20", VA = "0x180C38C20")]
	private void NPPDHIGFLKE(out IDisposable PKBEMLJCMBN, out IDisposable MMBPGBDFGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xC38320", Offset = "0xC37520", VA = "0x180C38320")]
	private bool HLLCKCGLMND(AAPOAKFHPCO BKHKFCEGGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xC37C00", Offset = "0xC36E00", VA = "0x180C37C00")]
	private void BGFIICAMGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xC38780", Offset = "0xC37980", VA = "0x180C38780")]
	[AsyncStateMachine(typeof(JNEJBKOMHDF))]
	private Task MCICMCAFAPI(AAPOAKFHPCO BKHKFCEGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xC38F10", Offset = "0xC38110", VA = "0x180C38F10")]
	public CMACJIIGJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[Preserve]
internal sealed class LHHKFHMJGCJ : FDOHHACFEDF, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct DNGANMLCIKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder<CPOLDIKGNEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public LHHKFHMJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<CPOLDIKGNEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8C7760", Offset = "0x8C6960", VA = "0x1808C7760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8C7930", Offset = "0x8C6B30", VA = "0x1808C7930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LOGACHAABPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public HOMLJGGAMHI message;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LOGACHAABPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D7A90", Offset = "0x8D6C90", VA = "0x1808D7A90")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class FHINHHMHJOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public HOMLJGGAMHI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FHINHHMHJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DD0", Offset = "0x8C7FD0", VA = "0x1808C8DD0")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class MEECLJNBFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MEECLJNBFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B50", Offset = "0x8D6D50", VA = "0x1808D7B50")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct IOAOEEEHKPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public LHHKFHMJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<HOKANCNHCCE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8CDFE0", Offset = "0x8CD1E0", VA = "0x1808CDFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class EHAAMHIFBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public HOMLJGGAMHI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EHAAMHIFBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8C7BC0", Offset = "0x8C6DC0", VA = "0x1808C7BC0")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct IIFAICFKPMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public HOMLJGGAMHI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public LHHKFHMJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private DPBKAPJPKAG <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3A0", Offset = "0x8CB5A0", VA = "0x1808CC3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct DGEJBEEHOKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AsyncTaskMethodBuilder<HOKANCNHCCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public LHHKFHMJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private DPBKAPJPKAG <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8C72F0", Offset = "0x8C64F0", VA = "0x1808C72F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8C76C0", Offset = "0x8C68C0", VA = "0x1808C76C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class IPNAFKGOJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public HOKANCNHCCE operation;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IPNAFKGOJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9B0", Offset = "0x8CDBB0", VA = "0x1808CE9B0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct HJGHHAIDFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public HOKANCNHCCE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public LHHKFHMJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private global::AHNHODFKKCG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F50", Offset = "0x8C9150", VA = "0x1808C9F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class KNJGNHJNKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public KNJGNHJNKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8D48F0", Offset = "0x8D3AF0", VA = "0x1808D48F0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class LAHAIFGADDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LAHAIFGADDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FF0", Offset = "0x8D41F0", VA = "0x1808D4FF0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private EBHEMCKGNHE IDMKGALFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private KKNMEFGEPHM NODAPLCIICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private AELADMHNCJJ PCIHFCDBBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private TaskCompletionSource<CPOLDIKGNEC> BFLHCBKHNAF;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F0", Offset = "0x8D62F0", VA = "0x1808D70F0", Slot = "7")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C70", Offset = "0x8D5E70", VA = "0x1808D6C70", Slot = "6")]
	[AsyncStateMachine(typeof(DNGANMLCIKC))]
	public Task<CPOLDIKGNEC> JAGKKHDFMMF(CancellationToken JBFDKHCAJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8D6900", Offset = "0x8D5B00", VA = "0x1808D6900", Slot = "4")]
	public void IOANNODPDOJ(HOMLJGGAMHI HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6490", Offset = "0x8D5690", VA = "0x1808D6490", Slot = "5")]
	public void DJNBGMNNNNH(HOMLJGGAMHI GGGIKLKDNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8D76D0", Offset = "0x8D68D0", VA = "0x1808D76D0")]
	[AsyncStateMachine(typeof(IOAOEEEHKPP))]
	private Task PDPHFKHGMPF(HOMLJGGAMHI KPOBLGGEAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D90", Offset = "0x8D5F90", VA = "0x1808D6D90")]
	[AsyncStateMachine(typeof(IIFAICFKPMF))]
	private Task JHALLGGMHHB(HOMLJGGAMHI DMALLIJBNAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8D71D0", Offset = "0x8D63D0", VA = "0x1808D71D0")]
	[AsyncStateMachine(typeof(DGEJBEEHOKG))]
	private Task<HOKANCNHCCE> MHPNFLBFDAB(HOMLJGGAMHI KPOBLGGEAFB, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D5610", VA = "0x1808D6410")]
	private DPBKAPJPKAG BIOMEHLLCAL(HOMLJGGAMHI HHFOEOOEPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x8D67D0", Offset = "0x8D59D0", VA = "0x1808D67D0")]
	[AsyncStateMachine(typeof(HJGHHAIDFEN))]
	private Task DKJLFHLNADL(HOKANCNHCCE BLAIMAGHBBE, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EA0", Offset = "0x8D60A0", VA = "0x1808D6EA0")]
	private HOKANCNHCCE LNNKMCBILJB(HOMLJGGAMHI KPOBLGGEAFB, DPBKAPJPKAG HDJPKODHJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3881B40", Offset = "0x3880D40", VA = "0x183881B40")]
	private T NBOOJOBPMEM<T>(T ADBNEBBHMOP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8D7310", Offset = "0x8D6510", VA = "0x1808D7310")]
	private HOKANCNHCCE MMOGBEOICCK(HOMLJGGAMHI KPOBLGGEAFB, DPBKAPJPKAG HDJPKODHJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public LHHKFHMJGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x8D7680", Offset = "0x8D6880", VA = "0x1808D7680")]
	[CompilerGenerated]
	private void OPKIFDFBJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[Preserve]
internal sealed class JABDKJCJPIN : KKNMEFGEPHM, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class FKELAOADHOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FKELAOADHOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C9340", Offset = "0x8C8540", VA = "0x1808C9340")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class PDOMKIGBLPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PDOMKIGBLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DACA0", Offset = "0x8D9EA0", VA = "0x1808DACA0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private HCKNJILHBPC IMLMCDFEGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private FDOHHACFEDF EJOOEIBLHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private EPEKOCBMPEC DLPMKPILMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PCHMLFAONLB BDHPDBMKMAP;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8D0320", Offset = "0x8CF520", VA = "0x1808D0320", Slot = "6")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8CEEA0", Offset = "0x8CE0A0", VA = "0x1808CEEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8CF660", Offset = "0x8CE860", VA = "0x1808CF660", Slot = "4")]
	public NOFNOFIIIAA HFPFDMDLLGK(DKAKIPPIIFI KPOBLGGEAFB)
	{
		return default(NOFNOFIIIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8CEF30", Offset = "0x8CE130", VA = "0x1808CEF30", Slot = "5")]
	public void FKCIOFONFNF(Guid BPIHMIEIAOA, Task CDBOLHIHKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8CFD20", Offset = "0x8CEF20", VA = "0x1808CFD20")]
	private void JMCLDCMDICF(byte MADGAIOEDCO, int FOIFOHEODKO, object KFLLFLKGPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8D0470", Offset = "0x8CF670", VA = "0x1808D0470")]
	private void NCLJGOCDION(OEFCNEAMBCD JGHBFLJAGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8CF180", Offset = "0x8CE380", VA = "0x1808CF180")]
	private void FOPJBCNMBCJ(OEFCNEAMBCD JGHBFLJAGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8CEC40", Offset = "0x8CDE40", VA = "0x1808CEC40")]
	private void CFONIHHBMAE(OEFCNEAMBCD JGHBFLJAGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8D00C0", Offset = "0x8CF2C0", VA = "0x1808D00C0")]
	private HOFMLDPLIAG MFGBGLHJFJL(HOMLJGGAMHI HHFOEOOEPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8CFAF0", Offset = "0x8CECF0", VA = "0x1808CFAF0")]
	private void HMOILCNKDHC(HOMLJGGAMHI DMALLIJBNAD, HOFMLDPLIAG EPDJCIBDHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8CEA20", Offset = "0x8CDC20", VA = "0x1808CEA20")]
	private bool CAGAOKNGKFH(HOMLJGGAMHI DMALLIJBNAD, HOFMLDPLIAG EPDJCIBDHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8CF410", Offset = "0x8CE610", VA = "0x1808CF410")]
	private bool HFPFDMDLLGK(HOMLJGGAMHI ACOBCOHJMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x8CFDF0", Offset = "0x8CEFF0", VA = "0x1808CFDF0")]
	private bool LMDIJGBIKBB(byte MADGAIOEDCO, ExitGames.Client.Photon.Hashtable JGHBFLJAGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JABDKJCJPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[Preserve]
internal sealed class HFENDICDMCJ : DKPMPECPDDD, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class BKAIIAIKEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public CPOLDIKGNEC operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BKAIIAIKEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B3FB0", Offset = "0x9B31B0", VA = "0x1809B3FB0")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct OLAHOMGLFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder<HOFMLDPLIAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public CPOLDIKGNEC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public HFENDICDMCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public FLLPHMIGOPF player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public FNJGHNELDIC detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private TaskAwaiter<HOFMLDPLIAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9CAB50", Offset = "0x9C9D50", VA = "0x1809CAB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9CB120", Offset = "0x9CA320", VA = "0x1809CB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class OIENKIHIELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public CPOLDIKGNEC operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OIENKIHIELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9CAAF0", Offset = "0x9C9CF0", VA = "0x1809CAAF0")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FPCCJEFIJPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public CPOLDIKGNEC operationType;

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FPCCJEFIJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9BF820", Offset = "0x9BEA20", VA = "0x1809BF820")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9BF880", Offset = "0x9BEA80", VA = "0x1809BF880")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9BF8E0", Offset = "0x9BEAE0", VA = "0x1809BF8E0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct LLAGINKJAHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<HOFMLDPLIAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public CPOLDIKGNEC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public HFENDICDMCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public FLLPHMIGOPF player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public FNJGHNELDIC detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private FPCCJEFIJPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private NOFNOFIIIAA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private HOFMLDPLIAG <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<(HOFMLDPLIAG validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C75C0", Offset = "0x9C67C0", VA = "0x1809C75C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C7C00", Offset = "0x9C6E00", VA = "0x1809C7C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class DMOLKJBNHCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public CPOLDIKGNEC operationType;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DMOLKJBNHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B76B0", Offset = "0x9B68B0", VA = "0x1809B76B0")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private BBCDJNJMCJI BBDOBDACGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private HCKNJILHBPC IMLMCDFEGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private KKNMEFGEPHM NODAPLCIICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x9C4560", Offset = "0x9C3760", VA = "0x1809C4560", Slot = "5")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x9C3BE0", Offset = "0x9C2DE0", VA = "0x1809C3BE0", Slot = "4")]
	[AsyncStateMachine(typeof(OLAHOMGLFGO))]
	public Task<HOFMLDPLIAG> AFEFABILKDL(FLLPHMIGOPF DGFKMAMLEOJ, CPOLDIKGNEC FHNMKOAPIBA, [CanBeNull] FNJGHNELDIC OGNLMBODDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x9C3D30", Offset = "0x9C2F30", VA = "0x1809C3D30")]
	private bool BDNAONIBPEK(CPOLDIKGNEC FHNMKOAPIBA, out HOFMLDPLIAG LHPJBAGJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x9C3F70", Offset = "0x9C3170", VA = "0x1809C3F70")]
	[AsyncStateMachine(typeof(LLAGINKJAHF))]
	private Task<HOFMLDPLIAG> BJMEONIHMNM(FLLPHMIGOPF DGFKMAMLEOJ, CPOLDIKGNEC FHNMKOAPIBA, [CanBeNull] FNJGHNELDIC OGNLMBODDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x9C40C0", Offset = "0x9C32C0", VA = "0x1809C40C0")]
	internal DKAKIPPIIFI FPBMAOFEDBL(FLLPHMIGOPF DGFKMAMLEOJ, CPOLDIKGNEC FHNMKOAPIBA, [CanBeNull] FNJGHNELDIC OGNLMBODDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public HFENDICDMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[Preserve]
internal sealed class CLFKHACGDGI : BBCDJNJMCJI, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct PLNGKHADAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder<FLLOKKAPGEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public CLFKHACGDGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter<FNJGHNELDIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xC43350", Offset = "0xC42550", VA = "0x180C43350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xC43610", Offset = "0xC42810", VA = "0x180C43610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class FPDIKAOAGGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FPDIKAOAGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xC3CAE0", Offset = "0xC3BCE0", VA = "0x180C3CAE0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct ECMGIDBAKFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder<FNJGHNELDIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public CLFKHACGDGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public AAPOAKFHPCO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private FPDIKAOAGGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<DEACGBHBBNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xC3BCF0", Offset = "0xC3AEF0", VA = "0x180C3BCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xC3C010", Offset = "0xC3B210", VA = "0x180C3C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class CDAGHCAFKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CDAGHCAFKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xC34980", Offset = "0xC33B80", VA = "0x180C34980")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(DEJNIAFBCPN sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private HJPCCELBDGI PKPPAFMEDAO;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly (CBCEEBNMKHL superRoomData, string unityAssetId, CBCEEBNMKHL subRoomData) MICOBFBENGH;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xC36FA0", Offset = "0xC361A0", VA = "0x180C36FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xC375A0", Offset = "0xC367A0", VA = "0x180C375A0", Slot = "8")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xC37100", Offset = "0xC36300", VA = "0x180C37100", Slot = "4")]
	[AsyncStateMachine(typeof(PLNGKHADAHP))]
	public Task<FLLOKKAPGEA> JPLGGKEBENG(CIHEPFKAKNH EFJKGFIDBLG, AAPOAKFHPCO LCKJIJGJFOH, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xC36E40", Offset = "0xC36040", VA = "0x180C36E40")]
	[AsyncStateMachine(typeof(ECMGIDBAKFM))]
	public Task<FNJGHNELDIC> DNCEKKGNDAA(AAPOAKFHPCO LCKJIJGJFOH, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xC377E0", Offset = "0xC369E0", VA = "0x180C377E0", Slot = "5")]
	public FLLOKKAPGEA PIEAMEIGENN(AAPOAKFHPCO LCKJIJGJFOH, FNJGHNELDIC PCHICKCNMDC, long NCGNHGHNMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xC36FF0", Offset = "0xC361F0", VA = "0x180C36FF0", Slot = "6")]
	public FLLOKKAPGEA HOGAFFLPLHP(AAPOAKFHPCO LCKJIJGJFOH, NMDBGAAGKEB GGMFNEEJGOP, long NCGNHGHNMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xC36D50", Offset = "0xC35F50", VA = "0x180C36D50", Slot = "7")]
	public FLLOKKAPGEA AEFFGDKCPFO(long OBKLHPGIOLN, long NCGNHGHNMLN, string AOLBKHGPCCM, string DBLOGHCOFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xC37630", Offset = "0xC36830", VA = "0x180C37630")]
	private static FLLOKKAPGEA NAAHAKFANDI(long OBKLHPGIOLN, long NCGNHGHNMLN, CBCEEBNMKHL IJGKAGDLIKN, string AOLBKHGPCCM, CBCEEBNMKHL FCLGFPAONJE, string DBLOGHCOFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xC37260", Offset = "0xC36460", VA = "0x180C37260")]
	private (CBCEEBNMKHL, string, CBCEEBNMKHL) MFLFMJMHGMO(AAPOAKFHPCO LCKJIJGJFOH, FNJGHNELDIC PCHICKCNMDC, long NCGNHGHNMLN)
	{
		return default((CBCEEBNMKHL, string, CBCEEBNMKHL));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public CLFKHACGDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[Preserve]
internal sealed class PPAMKHDIJMA : AELADMHNCJJ, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class FFEPGNNDADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FFEPGNNDADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x20DE250", Offset = "0x20DD450", VA = "0x1820DE250")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct GBDMIIGNDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public PPAMKHDIJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public DPBKAPJPKAG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x20DE600", Offset = "0x20DD800", VA = "0x1820DE600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x20DEAC0", Offset = "0x20DDCC0", VA = "0x1820DEAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct OCNDGIPECMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public PPAMKHDIJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public DPBKAPJPKAG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter<HBBEKBJCEAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x20E1450", Offset = "0x20E0650", VA = "0x1820E1450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x20E1950", Offset = "0x20E0B50", VA = "0x1820E1950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class IDIDDMEOPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IDIDDMEOPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x20DEB50", Offset = "0x20DDD50", VA = "0x1820DEB50")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct NGILLBDGIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public HOMLJGGAMHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public PPAMKHDIJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public DPBKAPJPKAG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private FIMDMCMMKJH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private JIKDKJKBOON <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<HBBEKBJCEAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x20DFF70", Offset = "0x20DF170", VA = "0x1820DFF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x20E0850", Offset = "0x20DFA50", VA = "0x1820E0850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private JELHGHCAFII CNNLLGHJKME;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private IAOOBAIGPGE IINDNBICOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x20E6F80", Offset = "0x20E6180", VA = "0x1820E6F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x20E7650", Offset = "0x20E6850", VA = "0x1820E7650", Slot = "8")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x20E7030", Offset = "0x20E6230", VA = "0x1820E7030", Slot = "4")]
	[AsyncStateMachine(typeof(GBDMIIGNDCF))]
	public Task<HOMLJGGAMHI> GFFFPPPEEED(HOMLJGGAMHI KPOBLGGEAFB, DPBKAPJPKAG HDJPKODHJNN, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x20E73C0", Offset = "0x20E65C0", VA = "0x1820E73C0", Slot = "5")]
	[AsyncStateMachine(typeof(OCNDGIPECMH))]
	public Task<HOMLJGGAMHI> KJAAINOPKAB(CancellationToken GENHLOEKMNL, DPBKAPJPKAG HDJPKODHJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x20E6EE0", Offset = "0x20E60E0", VA = "0x1820E6EE0", Slot = "6")]
	public BJHEGHJPHON FAKNEGKLBGF(HOKANCNHCCE KBMMKNOMJGM, CIHEPFKAKNH EFJKGFIDBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x20E72C0", Offset = "0x20E64C0", VA = "0x1820E72C0", Slot = "7")]
	public BJHEGHJPHON GKIFHHBJALA(HOKANCNHCCE KBMMKNOMJGM, CIHEPFKAKNH EFJKGFIDBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x20E7500", Offset = "0x20E6700", VA = "0x1820E7500")]
	[AsyncStateMachine(typeof(NGILLBDGIMM))]
	private Task<HOMLJGGAMHI> MABMKEIANNK(HOMLJGGAMHI KPOBLGGEAFB, DPBKAPJPKAG HDJPKODHJNN, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x192F7B0", Offset = "0x192E9B0", VA = "0x18192F7B0")]
	private static byte[] ACAJCAAHDJE(HOMLJGGAMHI HGHEMBBLDIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x20E7180", Offset = "0x20E6380", VA = "0x1820E7180")]
	private static string GFLNHLHHIMH(byte[] ACHMMDGBDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public PPAMKHDIJMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Preserve]
internal sealed class JLMAOFJMEMB : HCKNJILHBPC, CDKMFDLCHBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private CMHBPLAIECK CLJDGAMDPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private EBHEMCKGNHE IDMKGALFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private KBGFDKHAKPJ HONNLFNIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private AAALOJNNBAO HFIAPJOJCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private CKEDNNDPMCB AHGFPJLHMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private EJMPHAMHIAI PAFAFHKFCBA;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D1320", Offset = "0x8D0520", VA = "0x1808D1320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private static HOFMLDPLIAG GGLIEPDNCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D15A0", Offset = "0x8D07A0", VA = "0x1808D15A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8D15B0", Offset = "0x8D07B0", VA = "0x1808D15B0", Slot = "7")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8D11C0", Offset = "0x8D03C0", VA = "0x1808D11C0", Slot = "4")]
	public HOFMLDPLIAG EEBBHGHKFGO(FLLPHMIGOPF MCGGHPBODKF, CPOLDIKGNEC ABMLOKNKPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8D1370", Offset = "0x8D0570", VA = "0x1808D1370", Slot = "5")]
	public HOFMLDPLIAG JDPGFNBMDID(FLLPHMIGOPF HGINGOKKANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x8D1710", Offset = "0x8D0910", VA = "0x1808D1710", Slot = "6")]
	public HOFMLDPLIAG OCPFLPDJLHK(FLLPHMIGOPF HGINGOKKANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8D11B0", Offset = "0x8D03B0", VA = "0x1808D11B0")]
	private static HOFMLDPLIAG DDDAGFFCIGE(MIDLCCMFPFK GMKBLCEOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public JLMAOFJMEMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class NLOJMKKNJMG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x20E08A0", Offset = "0x20DFAA0", VA = "0x1820E08A0")]
	public NLOJMKKNJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0xE70560", Offset = "0xE6F760", VA = "0x180E70560")]
	public NLOJMKKNJMG(string HGHEMBBLDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class BGCJOCAJOAO : PJIPLBGGCID, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct MJOKAPDFABD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<HOFMLDPLIAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public BGCJOCAJOAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public GHLNAHICKHI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private global::AHNHODFKKCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private CIHEPFKAKNH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private CIHEPFKAKNH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<HOFMLDPLIAG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xC41A40", Offset = "0xC40C40", VA = "0x180C41A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xC420C0", Offset = "0xC412C0", VA = "0x180C420C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct GFMOIPPADED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public BGCJOCAJOAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xC3CEC0", Offset = "0xC3C0C0", VA = "0x180C3CEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct HGBNACBNAMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public BGCJOCAJOAO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xC3DA20", Offset = "0xC3CC20", VA = "0x180C3DA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct HBODGJAECCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public BGCJOCAJOAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xC3D8D0", Offset = "0xC3CAD0", VA = "0x180C3D8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct CHPPJFEBPOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public BGCJOCAJOAO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xC356C0", Offset = "0xC348C0", VA = "0x180C356C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct AGFFECJDDBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public BGCJOCAJOAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public GHLNAHICKHI autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private global::AHNHODFKKCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xC2F580", Offset = "0xC2E780", VA = "0x180C2F580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private static readonly TimeSpan KJNMHPDCHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private PKOOEACNMEF ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private AELADMHNCJJ PCIHFCDBBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private EBHEMCKGNHE IDMKGALFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private CKEDNNDPMCB AHGFPJLHMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private CancellationTokenSource CMIGINIEJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Task PKCPLJMPLCM;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xC325A0", Offset = "0xC317A0", VA = "0x180C325A0", Slot = "6")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0xC32130", Offset = "0xC31330", VA = "0x180C32130", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0xC32020", Offset = "0xC31220", VA = "0x180C32020", Slot = "4")]
	[AsyncStateMachine(typeof(MJOKAPDFABD))]
	public Task<HOFMLDPLIAG> APACGDAIPBB(GHLNAHICKHI OKLBJDMNAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xC32150", Offset = "0xC31350", VA = "0x180C32150", Slot = "5")]
	[AsyncStateMachine(typeof(GFMOIPPADED))]
	public Task EBCNGBECEIO([Optional] CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xC32130", Offset = "0xC31330", VA = "0x180C32130")]
	public void MPLELHIJMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xC32740", Offset = "0xC31940", VA = "0x180C32740")]
	private DIBDAGIJGOH MHDCAONDCBI(GHLNAHICKHI OKLBJDMNAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xC32350", Offset = "0xC31550", VA = "0x180C32350")]
	[AsyncStateMachine(typeof(HGBNACBNAMP))]
	private Task HEGINNEKIBP(MOPOKHJCMLO ILPNDFPPNDK, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xC32B60", Offset = "0xC31D60", VA = "0x180C32B60")]
	[AsyncStateMachine(typeof(HBODGJAECCL))]
	private Task ONGBAJFLCCE([Optional] CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xC32470", Offset = "0xC31670", VA = "0x180C32470")]
	[AsyncStateMachine(typeof(CHPPJFEBPOA))]
	private Task MFDMNOPOIJK(TimeSpan JIDKAKHIEHC, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xC32910", Offset = "0xC31B10", VA = "0x180C32910")]
	private Task OCCKOKMHJBG(GHLNAHICKHI OKLBJDMNAMD, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xC31EF0", Offset = "0xC310F0", VA = "0x180C31EF0")]
	[AsyncStateMachine(typeof(AGFFECJDDBC))]
	private Task AOKIEPFHCFC(GHLNAHICKHI OKLBJDMNAMD, CancellationToken HJBBMMLLNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xC32270", Offset = "0xC31470", VA = "0x180C32270")]
	private bool EHODMNENIFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public BGCJOCAJOAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[Preserve]
internal class ADMFFNDIMEI : KBGFDKHAKPJ, CDKMFDLCHBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct CNBKFDMFMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ADMFFNDIMEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private global::AHNHODFKKCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xC38F90", Offset = "0xC38190", VA = "0x180C38F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private FLNCIFOOELD KLGIFKEDGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private HCKNJILHBPC IMLMCDFEGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private AELADMHNCJJ PCIHFCDBBMF;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xC2F400", Offset = "0xC2E600", VA = "0x180C2F400", Slot = "6")]
	public void MGEPLKAAEGI(BNHHCILIEOE LLLBIFNKIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xC2F230", Offset = "0xC2E430", VA = "0x180C2F230", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xC2F110", Offset = "0xC2E310", VA = "0x180C2F110", Slot = "5")]
	[AsyncStateMachine(typeof(CNBKFDMFMGM))]
	public Task ADPFJAPCOLH(string DLBDGCGKOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xC2F280", Offset = "0xC2E480", VA = "0x180C2F280", Slot = "4")]
	public HOFMLDPLIAG EHODMNENIFC(FLLPHMIGOPF MCGGHPBODKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xC2F2E0", Offset = "0xC2E4E0", VA = "0x180C2F2E0")]
	private CIDELAGKHFB JMDGMDKFCDF(string DLBDGCGKOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public ADMFFNDIMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class OGMJFPHNMCB
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x20E3BD0", Offset = "0x20E2DD0", VA = "0x1820E3BD0")]
	public static void GNEJLGBAJJL(EIFHKIDJKKE APJAHLFEOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x20E4070", Offset = "0x20E3270", VA = "0x1820E4070")]
	internal static void KGFNLHIMKMA(EIFHKIDJKKE APJAHLFEOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x20E3D10", Offset = "0x20E2F10", VA = "0x1820E3D10")]
	internal static void IBAMEJPODJE(EIFHKIDJKKE APJAHLFEOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x20E3DB0", Offset = "0x20E2FB0", VA = "0x1820E3DB0")]
	internal static void IIKNAOLFDMK(EIFHKIDJKKE APJAHLFEOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class OBAMDDKGKGL : global::JGKEOILPKGC<HOMLJGGAMHI>
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GAFLIHKDDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public HOMLJGGAMHI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GAFLIHKDDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x20DE2A0", Offset = "0x20DD4A0", VA = "0x1820DE2A0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly OBAMDDKGKGL HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private const string IKANAFOEOHG = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x20E1310", Offset = "0x20E0510", VA = "0x1820E1310")]
	public ExitGames.Client.Photon.Hashtable LIOPAMDCNLD(HOMLJGGAMHI HGHEMBBLDIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x20E1060", Offset = "0x20E0260", VA = "0x1820E1060", Slot = "5")]
	protected override void FHJIAKGCMEM(HOMLJGGAMHI HGHEMBBLDIC, IDictionary<object, object> ADIGGFBANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x20E1170", Offset = "0x20E0370", VA = "0x1820E1170", Slot = "6")]
	public override HOMLJGGAMHI LGPKACCHBHO(IDictionary<object, object> ADIGGFBANFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x20E0F10", Offset = "0x20E0110", VA = "0x1820E0F10")]
	private static void ELLDIMGOPPA(string OMFMLBAFFFK, HOMLJGGAMHI HGHEMBBLDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x20E1410", Offset = "0x20E0610", VA = "0x1820E1410")]
	public OBAMDDKGKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x20E0BF0", Offset = "0x20DFDF0", VA = "0x1820E0BF0")]
	[CompilerGenerated]
	internal static string AFLPHHFMPLK(FLLOKKAPGEA FDBJMNOLEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class DOLKBAMBFCG
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public static HOFMLDPLIAG GGLIEPDNCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CD0", Offset = "0x9B6ED0", VA = "0x1809B7CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x9B7CB0", Offset = "0x9B6EB0", VA = "0x1809B7CB0")]
	public static bool KMGJMIFEINO(this HOFMLDPLIAG EPDJCIBDHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x9B7710", Offset = "0x9B6910", VA = "0x1809B7710")]
	public static HOFMLDPLIAG DDDAGFFCIGE(MIDLCCMFPFK DAOEENJHLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x9B7910", Offset = "0x9B6B10", VA = "0x1809B7910")]
	public static HOFMLDPLIAG GMFHEJJHGFM(params HOFMLDPLIAG[] OBGJNJOEPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x9B7770", Offset = "0x9B6970", VA = "0x1809B7770")]
	public static HOFMLDPLIAG FEDCKHFCHIF(IEnumerable<HOFMLDPLIAG> OBGJNJOEPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x9B7AB0", Offset = "0x9B6CB0", VA = "0x1809B7AB0")]
	public static string JHIKAMJAJOC(this HOFMLDPLIAG LHPJBAGJLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class LFFNFJGBNCP : NDOGFOCGPGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public delegate HOFMLDPLIAG PEOIBHGCECH([NotNull] FLLPHMIGOPF NJGCBCMDLFC);

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class IDFDFCEDNCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public FLLPHMIGOPF photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IDFDFCEDNCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8CBC20", Offset = "0x8CAE20", VA = "0x1808CBC20")]
		internal HOFMLDPLIAG <Validate>b__0(PEOIBHGCECH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	protected readonly HashSet<PEOIBHGCECH> GADJJIIKJOH;

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8D5F00", Offset = "0x8D5100", VA = "0x1808D5F00", Slot = "4")]
	public void ICPAPLOFIAL(PEOIBHGCECH JFJNHBCKAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8D5F60", Offset = "0x8D5160", VA = "0x1808D5F60", Slot = "5")]
	public void JCKAFIMFLJK(PEOIBHGCECH JFJNHBCKAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8D5EB0", Offset = "0x8D50B0", VA = "0x1808D5EB0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8D5FC0", Offset = "0x8D51C0", VA = "0x1808D5FC0")]
	protected HOFMLDPLIAG KKABIKKAMIG(FLLPHMIGOPF HGINGOKKANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8CE940", Offset = "0x8CDB40", VA = "0x1808CE940")]
	protected LFFNFJGBNCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class IOKEMPCDLNJ : LFFNFJGBNCP, CMHBPLAIECK, NDOGFOCGPGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class EPHENHAJICF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public HOFMLDPLIAG result;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public EPHENHAJICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8C80C0", Offset = "0x8C72C0", VA = "0x1808C80C0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x8CE940", Offset = "0x8CDB40", VA = "0x1808CE940")]
	[Preserve]
	public IOKEMPCDLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x8CE660", Offset = "0x8CD860", VA = "0x1808CE660", Slot = "8")]
	public HOFMLDPLIAG DJIMNJKLEDF(FLLPHMIGOPF HGINGOKKANE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class CPLFAPEACEN : LFFNFJGBNCP, FLNCIFOOELD, NDOGFOCGPGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class LINHILPDGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public HOFMLDPLIAG result;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LINHILPDGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xC40E60", Offset = "0xC40060", VA = "0x180C40E60")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xC39490", Offset = "0xC38690", VA = "0x180C39490")]
	[Preserve]
	public CPLFAPEACEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xC39340", Offset = "0xC38540", VA = "0x180C39340", Slot = "8")]
	public HOFMLDPLIAG EHODMNENIFC(FLLPHMIGOPF BLMOODAHPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum DDNAAFIOLBK
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
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class OPGANCPDJCB
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class NBPIOEIHOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public global::AHNHODFKKCG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public NBPIOEIHOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x20DFEF0", Offset = "0x20DF0F0", VA = "0x1820DFEF0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public const string IELLFHCBPOI = "START: ";

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public const string CCLGEAEHLAM = "END: ";

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x20E6060", Offset = "0x20E5260", VA = "0x1820E6060")]
	public static global::AHNHODFKKCG<string> AHJLHJIECDM([Optional] string GNMFAGMKIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x20E63C0", Offset = "0x20E55C0", VA = "0x1820E63C0")]
	private static void PBEAKLEJNDJ(string JCNAPFOCJDI, ABKLLNIOANH NDCCOMJDOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x20E6110", Offset = "0x20E5310", VA = "0x1820E6110")]
	private static void GDDDAAAFJEK(string JCNAPFOCJDI, ABKLLNIOANH NDCCOMJDOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x20E61F0", Offset = "0x20E53F0", VA = "0x1820E61F0")]
	public static void GJPPJLJMCCA(global::AHNHODFKKCG<string> NDCCOMJDOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x20E6320", Offset = "0x20E5520", VA = "0x1820E6320")]
	public static string OEPFPDGCOPH(HOMLJGGAMHI HHFOEOOEPEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal static class GMFDPKCHOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x9C3300", Offset = "0x9C2500", VA = "0x1809C3300")]
	public static void AADBFIBEBME(this PKOOEACNMEF ELPBHABCDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x9C3410", Offset = "0x9C2610", VA = "0x1809C3410")]
	public static void OJAAAPLAGKC(this PKOOEACNMEF ELPBHABCDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x9C3310", Offset = "0x9C2510", VA = "0x1809C3310")]
	private static void LJMGBDNGAPN(this PKOOEACNMEF ELPBHABCDMF, bool ADHBNCNOLJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class JOKIEADMCFP : MCHDFABIOOM, LIJNDJHFMJO, CMGCODDFPPE, JFGGLHBJBEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly LIJNDJHFMJO OOPAJHAOGEE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FLLPHMIGOPF BGBLIKAGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F90", Offset = "0x8D1190", VA = "0x1808D1F90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int BADKNPMJBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FE0", Offset = "0x8D11E0", VA = "0x1808D1FE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int EIDEOBILBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F20", Offset = "0x8D1120", VA = "0x1808D1F20", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool PMODEHEILDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int HOOPCCFADMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x5F7190", Offset = "0x5F6390", VA = "0x1805F7190", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event HFKNDJPGMMK.KMJLFBPFJNN CGAKPGGEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event JJANGDMLGJP MFGGOAOALFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C50", Offset = "0x8D0E50", VA = "0x1808D1C50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2030", Offset = "0x8D1230", VA = "0x1808D2030", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<bool> JNOJBKKAGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FLLPHMIGOPF> CHOJCNKDJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action DPMJOKGJOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8D1CF0", Offset = "0x8D0EF0", VA = "0x1808D1CF0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8D2170", Offset = "0x8D1370", VA = "0x1808D2170", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8D2270", Offset = "0x8D1470", VA = "0x1808D2270")]
	public JOKIEADMCFP(LIJNDJHFMJO OOPAJHAOGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8D1D90", Offset = "0x8D0F90", VA = "0x1808D1D90", Slot = "8")]
	public bool CFJCNKGCKLF(byte MADGAIOEDCO, ExitGames.Client.Photon.Hashtable BLGBEPHCMEC, FJFANJPNCGN ODLLAKLOIOB, SendOptions FBBFDKCANPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8D20D0", Offset = "0x8D12D0", VA = "0x1808D20D0", Slot = "29")]
	public FLLPHMIGOPF ONJNDNABIDC(int GABAIPNNDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8D1E50", Offset = "0x8D1050", VA = "0x1808D1E50", Slot = "16")]
	public FLLPHMIGOPF FCCLDLGPBPE(int LIGLKPEMMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "19")]
	public void FKBGPJMKOGI(object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "20")]
	public void MLPLENKFJFJ(object HCPCDENCJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "21")]
	public void NOHCDLBEJNJ(object HCPCDENCJBA, bool AAIEOMLBPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2210", Offset = "0x8D1410", VA = "0x1808D2210", Slot = "22")]
	public IDisposable PPNNLFOHIPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "23")]
	private bool IALFEEFLHBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "24")]
	public void HCKOFGCLGEB(StringBuilder CGBPLHFCCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x8D1F70", Offset = "0x8D1170", VA = "0x1808D1F70", Slot = "25")]
	public bool GBEMMPDPFFO(bool IDJGMFIJBDP, out string IEPGAFBBMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	public void JBHEKIOKHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8D1E30", Offset = "0x8D1030", VA = "0x1808D1E30", Slot = "28")]
	public void DIFMCHLDBAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct OEFCNEAMBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public const string CJNJKKAGIGH = "v_result";

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public const string GIMOHNECDDO = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly IDictionary<object, object> JGHBFLJAGLI;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xB514B0", Offset = "0xB506B0", VA = "0x180B514B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
	public OEFCNEAMBCD(IDictionary<object, object> JGHBFLJAGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x20E38E0", Offset = "0x20E2AE0", VA = "0x1820E38E0")]
	public bool JLNLBDEPCKF(out HOMLJGGAMHI HGHEMBBLDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x20E3820", Offset = "0x20E2A20", VA = "0x1820E3820")]
	public Guid DJJLEKGNNDM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x20E3620", Offset = "0x20E2820", VA = "0x1820E3620")]
	public HOFMLDPLIAG BOLDHOIJNHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x20E3750", Offset = "0x20E2950", VA = "0x1820E3750")]
	public static ExitGames.Client.Photon.Hashtable CNOGLGNGFED(HOMLJGGAMHI HGHEMBBLDIC, HOFMLDPLIAG EPDJCIBDHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal static class OFKLALCOHPL
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x20E39F0", Offset = "0x20E2BF0", VA = "0x1820E39F0")]
	public static string KENIGGOBMFF(this AAPOAKFHPCO PHDMDMHLDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x20E3970", Offset = "0x20E2B70", VA = "0x1820E3970")]
	public static bool GJPIFFKOBOA(this AAPOAKFHPCO PHDMDMHLDCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct BDANEGNLGIH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct EHMHGGGNEDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public BDANEGNLGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xC3C4D0", Offset = "0xC3B6D0", VA = "0x180C3C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly Func<CancellationToken, List<Task>> NGIBAJGHPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly CancellationTokenSource OEEOLLPACLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private Task HAJJIJILELD;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool MJFCPIFHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xC30F40", Offset = "0xC30140", VA = "0x180C30F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	internal Task OOJODKAMGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xC30EC0", Offset = "0xC300C0", VA = "0x180C30EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0xC30F70", Offset = "0xC30170", VA = "0x180C30F70")]
	public BDANEGNLGIH(Func<CancellationToken, List<Task>> NGIBAJGHPNI, CancellationToken GENHLOEKMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xC30DB0", Offset = "0xC2FFB0", VA = "0x180C30DB0")]
	[AsyncStateMachine(typeof(EHMHGGGNEDB))]
	public Task KIHOBEDPEDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xC30D60", Offset = "0xC2FF60", VA = "0x180C30D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public readonly struct LOFLAHOJKJG<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct AEBAPLBPKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder<global::EABJJOPDGLM<global::KKFMAOPDNGH<TData>, JMNFFALHFMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public global::LOFLAHOJKJG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private CIHEPFKAKNH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<global::EABJJOPDGLM<byte[], JMNFFALHFMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1CB1280", Offset = "0x1CB0480", VA = "0x181CB1280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xF30650", Offset = "0xF2F850", VA = "0x180F30650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly global::BCIHMNJOENF<TGetDataArg, TData> BAPDCJKANBN;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
	internal LOFLAHOJKJG(global::BCIHMNJOENF<TGetDataArg, TData> BINNMIIOOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x1CC48C0", Offset = "0x1CC3AC0", VA = "0x181CC48C0")]
	[AsyncStateMachine(typeof(global::LOFLAHOJKJG<, >.AEBAPLBPKNK))]
	public Task<global::EABJJOPDGLM<global::KKFMAOPDNGH<TData>, JMNFFALHFMO>> EDGHOGGMPID(TGetDataArg ACHMMDGBDID, string EGKBJNIEGAL, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class HCABFPDCDBO
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3993A00", Offset = "0x3992C00", VA = "0x183993A00")]
	public static global::LOFLAHOJKJG<TGetDataArg, TData> HCEINCHCOLK<TGetDataArg, TData>(global::BCIHMNJOENF<TGetDataArg, TData> BINNMIIOOPN)
	{
		return default(global::LOFLAHOJKJG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class BEIMJCANIFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private readonly MBMFAHOKKPI GLENFEKBGPM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private const string LOODKIFEDOF = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private const string ALELAOIFHDJ = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private const string AOIGAHMBFAK = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private const string BDKNLOKNJME = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private string GIABGBFAKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private long? OOHHKNGEEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private long? ELMGPJODLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private LPLBPIGKKLD BMCKDOFFBMO;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string PPFJJNCOPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public long OMPCNMAAABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xC31650", Offset = "0xC30850", VA = "0x180C31650")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public long BCIPBILFDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xC31090", Offset = "0xC30290", VA = "0x180C31090")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public LPLBPIGKKLD KOFGPMEEHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x92AC20", Offset = "0x929E20", VA = "0x18092AC20")]
		get
		{
			return default(LPLBPIGKKLD);
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xC31240", Offset = "0xC30440", VA = "0x180C31240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xC318E0", Offset = "0xC30AE0", VA = "0x180C318E0")]
	[Preserve]
	public BEIMJCANIFD([AHKDIAMPNOO(null)] MBMFAHOKKPI GLENFEKBGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xC310E0", Offset = "0xC302E0", VA = "0x180C310E0")]
	private void GEAGOFOJDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xC31320", Offset = "0xC30520", VA = "0x180C31320")]
	public void LNIPKAIPDGD(long AHCJAABMBLP, long NCGNHGHNMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xC31560", Offset = "0xC30760", VA = "0x180C31560")]
	public void MJKFNAPEBGH(string NICMOPBOEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xC316A0", Offset = "0xC308A0", VA = "0x180C316A0")]
	public void OOLJNGIEHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class BJHEGHJPHON : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct DMCEPDLCAEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public HOMLJGGAMHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public BJHEGHJPHON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<KONFJFIPOOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xC3B720", Offset = "0xC3A920", VA = "0x180C3B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xC3BAE0", Offset = "0xC3ACE0", VA = "0x180C3BAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct PIBJPEHKHDI<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class ENAMOCNJJIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public HOMLJGGAMHI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ENAMOCNJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xC3C8D0", Offset = "0xC3BAD0", VA = "0x180C3C8D0")]
		internal HOMLJGGAMHI <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct AJCOKFPIEKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public AsyncTaskMethodBuilder<KONFJFIPOOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public HOMLJGGAMHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public BJHEGHJPHON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private FIMDMCMMKJH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter<KONFJFIPOOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xC2FAF0", Offset = "0xC2ECF0", VA = "0x180C2FAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xC300D0", Offset = "0xC2F2D0", VA = "0x180C300D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct JLGKGIAIJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public BJHEGHJPHON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xC3F470", Offset = "0xC3E670", VA = "0x180C3F470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class PENOKEMGOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PENOKEMGOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xC42B60", Offset = "0xC41D60", VA = "0x180C42B60")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class CDHKBLOHLIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CDHKBLOHLIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xC34BE0", Offset = "0xC33DE0", VA = "0x180C34BE0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class JAPMMIHIHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JAPMMIHIHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xC3E980", Offset = "0xC3DB80", VA = "0x180C3E980")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class NGDEKFNNJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public NGDEKFNNJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xC42460", Offset = "0xC41660", VA = "0x180C42460")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class DIFIMABKDNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public BJHEGHJPHON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DIFIMABKDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xC3B2F0", Offset = "0xC3A4F0", VA = "0x180C3B2F0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class PCBIIKJMIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public BJHEGHJPHON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PCBIIKJMIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xC42900", Offset = "0xC41B00", VA = "0x180C42900")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private static readonly Guid OBFMFOAGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly HOKANCNHCCE FJDLDJAGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly IAOOBAIGPGE JJOJAOGBEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private readonly CMGCODDFPPE ELPBHABCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private readonly JFGGLHBJBEG KAPNDPEAPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private bool FIGCKHCJINL;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0xC344D0", Offset = "0xC336D0", VA = "0x180C344D0")]
	public BJHEGHJPHON(HOKANCNHCCE BLAIMAGHBBE, IAOOBAIGPGE JJOJAOGBEED, CMGCODDFPPE ELPBHABCDMF, JFGGLHBJBEG KAPNDPEAPAK, CIHEPFKAKNH EFJKGFIDBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0xC32FE0", Offset = "0xC321E0", VA = "0x180C32FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0xC32FE0", Offset = "0xC321E0", VA = "0x180C32FE0")]
	public void APMJACLJDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0xC331F0", Offset = "0xC323F0", VA = "0x180C331F0")]
	public void BMMKGLPPLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0xC33FD0", Offset = "0xC331D0", VA = "0x180C33FD0")]
	public void NFGKIJEEEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xC33680", Offset = "0xC32880", VA = "0x180C33680")]
	[AsyncStateMachine(typeof(DMCEPDLCAEA))]
	internal Task<HOMLJGGAMHI> FMJHHEAHHAG(CIHEPFKAKNH EFJKGFIDBLG, HOMLJGGAMHI HHFOEOOEPEA, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x192F7B0", Offset = "0x192E9B0", VA = "0x18192F7B0")]
	private static byte[] LIHKDPJHPMK<T>(T HGHEMBBLDIC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x38453E0", Offset = "0x38445E0", VA = "0x1838453E0")]
	private static T DMLEKLGMMOF<T>(MessageParser<T> GHLNCCOAACL, byte[] HGHEMBBLDIC, T KIGCNHOGKLA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xC33B40", Offset = "0xC32D40", VA = "0x180C33B40")]
	[AsyncStateMachine(typeof(AJCOKFPIEKF))]
	private Task<KONFJFIPOOK> IBHHDLDBGJN(HOMLJGGAMHI HHFOEOOEPEA, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x385A600", Offset = "0x3859800", VA = "0x18385A600")]
	[AsyncStateMachine(typeof(BECLJHKGBDL))]
	internal Task<T> OLMJNECPFIP<T>(CancellationToken HJBBMMLLNMM, Func<CancellationToken, Task<T>> PCLMPEHMHNL, int OKCPLCDKAED = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xC34290", Offset = "0xC33490", VA = "0x180C34290")]
	[AsyncStateMachine(typeof(JLGKGIAIJAF))]
	internal Task OLMJNECPFIP(CancellationToken HJBBMMLLNMM, Func<CancellationToken, Task> PCLMPEHMHNL, int OKCPLCDKAED = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xC343E0", Offset = "0xC335E0", VA = "0x180C343E0")]
	public HOMLJGGAMHI PJBFCGNPPIO(FIMDMCMMKJH MCLJOFGLJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0xC33C80", Offset = "0xC32E80", VA = "0x180C33C80")]
	public NLAKCCNIKCI KMAFOPBBIPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0xC33610", Offset = "0xC32810", VA = "0x180C33610")]
	public DEEPDEAMNNA FDIPGIBNAGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0xC33160", Offset = "0xC32360", VA = "0x180C33160")]
	public OKOEBEOHBAH BMLGBAEDEHO([Optional] ANMMMPJFIHD? HLINENEAIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xC33AD0", Offset = "0xC32CD0", VA = "0x180C33AD0")]
	public OEEDHBPOJCC HKMHCCHGBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xC34100", Offset = "0xC33300", VA = "0x180C34100")]
	public void OBBMDIAOPBG(Func<Guid, bool> ECNMDGCPMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xC33CF0", Offset = "0xC32EF0", VA = "0x180C33CF0")]
	public void LPFCKBIPDGF(Func<Guid, bool> JPNOHKHBMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xC33E70", Offset = "0xC33070", VA = "0x180C33E70")]
	public void NFBEFHFCKEO(Func<Guid, bool> ECNMDGCPMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xC33900", Offset = "0xC32B00", VA = "0x180C33900")]
	public Guid HIPKPODGLGN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0xC34130", Offset = "0xC33330", VA = "0x180C34130")]
	public void OBDOOELIKAF(Guid NEPPMHBKFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0xC337E0", Offset = "0xC329E0", VA = "0x180C337E0")]
	public void HGGJBMLLPGH(HOMLJGGAMHI OHCJAHGPLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xC33370", Offset = "0xC32570", VA = "0x180C33370")]
	public void ELLDIMGOPPA(string CKNFEFABJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xC334C0", Offset = "0xC326C0", VA = "0x180C334C0")]
	public void ELLDIMGOPPA(Func<string> BOGFNNBPECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3845530", Offset = "0x3844730", VA = "0x183845530")]
	private T NBOOJOBPMEM<T>(T ADBNEBBHMOP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xC33320", Offset = "0xC32520", VA = "0x180C33320")]
	public void BONMBEFGJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x385A1F0", Offset = "0x38593F0", VA = "0x18385A1F0")]
	[CompilerGenerated]
	internal static string OGPCIOFFNAJ<T>(byte[] FAOJAOEJLMO, int HIMCCKHCOLE, ref PIBJPEHKHDI<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal sealed class DMECLOAILGA : HOKANCNHCCE
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class KCJBMEMEJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public KCJBMEMEJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9C6CE0", Offset = "0x9C5EE0", VA = "0x1809C6CE0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct HPEJJNANMIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public DMECLOAILGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private DEEPDEAMNNA <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CD0", Offset = "0x9C4ED0", VA = "0x1809C5CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class BAMMBECDFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public JOFPAEBELBI presence;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BAMMBECDFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E80", Offset = "0x9B3080", VA = "0x1809B3E80")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly FLLOKKAPGEA MKCELNICJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private readonly AAPOAKFHPCO DKLMLFOAODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private readonly BBCDJNJMCJI BBDOBDACGDE;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private const bool CKDOOGMGOII = false;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x9B74C0", Offset = "0x9B66C0", VA = "0x1809B74C0")]
	public DMECLOAILGA(FLLOKKAPGEA MKCELNICJFG, AAPOAKFHPCO DKLMLFOAODO, Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, DPBKAPJPKAG MBFHOFKPOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x9B7380", Offset = "0x9B6580", VA = "0x1809B7380", Slot = "8")]
	[AsyncStateMachine(typeof(HPEJJNANMIM))]
	protected override Task PNCOHHAOPBL(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x9B6FD0", Offset = "0x9B61D0", VA = "0x1809B6FD0")]
	private JOFPAEBELBI IFKLPFKNKMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x9B6E90", Offset = "0x9B6090", VA = "0x1809B6E90")]
	private void BDADCHFFKDN(JOFPAEBELBI LHCFKLDJHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x9B72F0", Offset = "0x9B64F0", VA = "0x1809B72F0")]
	private static void OJGONIGGCNP(AAPOAKFHPCO PHDMDMHLDCB, [Optional] string HGHEMBBLDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class DIBDAGIJGOH : HOKANCNHCCE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OEHEBPMKIKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public DIBDAGIJGOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<FNJGHNELDIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9CA600", Offset = "0x9C9800", VA = "0x1809CA600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly int LGKOPDEIAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly GHLNAHICKHI OKLBJDMNAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public readonly long HLMDFMMGGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public readonly long AFHCHOIOAJK;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x9B61A0", Offset = "0x9B53A0", VA = "0x1809B61A0")]
	public DIBDAGIJGOH(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, DPBKAPJPKAG MBFHOFKPOAM, int LGKOPDEIAAI, GHLNAHICKHI OKLBJDMNAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x9B6060", Offset = "0x9B5260", VA = "0x1809B6060", Slot = "8")]
	[AsyncStateMachine(typeof(OEHEBPMKIKH))]
	protected override Task PNCOHHAOPBL(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal abstract class KNNLIPNLPFF : HOKANCNHCCE
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private sealed class BLPBLCGEOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public KNNLIPNLPFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public KFIDLBOKONC playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BLPBLCGEOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5510", Offset = "0x8C4710", VA = "0x1808C5510")]
		internal Task <RunAsync>b__0(CIHEPFKAKNH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4750", VA = "0x1808C5550")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct OMGDEFEBJPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public KNNLIPNLPFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private BLPBLCGEOEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA620", Offset = "0x8D9820", VA = "0x1808DA620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct MIOBIHHFBBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public KFIDLBOKONC playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public KNNLIPNLPFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D20", Offset = "0x8D6F20", VA = "0x1808D7D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x8CBB00", Offset = "0x8CAD00", VA = "0x1808CBB00")]
	public KNNLIPNLPFF(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, DPBKAPJPKAG MBFHOFKPOAM, string GMCDONBOIEN, bool EOHMDMNIAEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x8D4AA0", Offset = "0x8D3CA0", VA = "0x1808D4AA0", Slot = "8")]
	[AsyncStateMachine(typeof(OMGDEFEBJPB))]
	protected override Task PNCOHHAOPBL(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task IJHMLKCCCHF(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x8D4940", Offset = "0x8D3B40", VA = "0x1808D4940")]
	[AsyncStateMachine(typeof(MIOBIHHFBBK))]
	private Task OIKFFAMHGPB(IDisposable EEODJPLGBMJ, KFIDLBOKONC POFCFPLNMGF, CIHEPFKAKNH NDCCOMJDOFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class EDAHBELHFDC : HOKANCNHCCE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct DAICGJKANNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public EDAHBELHFDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private OEEDHBPOJCC <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter<KOPDLHJILKH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B5A70", Offset = "0x9B4C70", VA = "0x1809B5A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly GHLNAHICKHI OKLBJDMNAMD;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x9B8470", Offset = "0x9B7670", VA = "0x1809B8470")]
	public EDAHBELHFDC(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, DPBKAPJPKAG MBFHOFKPOAM, GHLNAHICKHI OKLBJDMNAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x9B8260", Offset = "0x9B7460", VA = "0x1809B8260", Slot = "7")]
	protected override string ELPJMLHLNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x9B8330", Offset = "0x9B7530", VA = "0x1809B8330", Slot = "8")]
	[AsyncStateMachine(typeof(DAICGJKANNE))]
	protected override Task PNCOHHAOPBL(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal abstract class HOKANCNHCCE : DGILGBLHKKK
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public delegate Task HGGBOHCOOKN(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class CNAANDJJLFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CIHEPFKAKNH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public HOKANCNHCCE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CNAANDJJLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C6830", Offset = "0x8C5A30", VA = "0x1808C6830")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class MHMGJDDJACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public CNAANDJJLFB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MHMGJDDJACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BA0", Offset = "0x8D6DA0", VA = "0x1808D7BA0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C60", Offset = "0x8D6E60", VA = "0x1808D7C60")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct CMKPEFPKOGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public HOKANCNHCCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<HOKANCNHCCE, CIHEPFKAKNH, BJHEGHJPHON> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private CNAANDJJLFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private BJHEGHJPHON <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D20", Offset = "0x8C4F20", VA = "0x1808C5D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct EALGAADBBIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public HOKANCNHCCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6B80", VA = "0x1808C7980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public readonly Guid NFDKNIOEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public readonly ByteString FADEDNHJJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public readonly DPBKAPJPKAG HPHKKOFKGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	protected readonly string IIIPLAMHKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly bool EOHMDMNIAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private bool GFHMMFBLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public LPLBPIGKKLD HNBAKLAJGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public LPLBPIGKKLD HBIPJINIDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly Queue<HGGBOHCOOKN> AGPNBOLLCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly MOPMEHDPIJM NBJNGNFFHHE;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BNHHCILIEOE JICDEINMNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8CB8D0", Offset = "0x8CAAD0", VA = "0x1808CB8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public ODPBOGGBOGH JNGOBBNCCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8CB600", Offset = "0x8CA800", VA = "0x1808CB600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8CB710", Offset = "0x8CA910", VA = "0x1808CB710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public float DHDAOMCPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x8CB920", Offset = "0x8CAB20", VA = "0x1808CB920", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event JEOFJMEBFME BHJJOLGJFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8CB690", Offset = "0x8CA890", VA = "0x1808CB690", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3E0", Offset = "0x8CA5E0", VA = "0x1808CB3E0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8CBB00", Offset = "0x8CAD00", VA = "0x1808CBB00")]
	protected HOKANCNHCCE(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, DPBKAPJPKAG MBFHOFKPOAM, string GMCDONBOIEN, bool EOHMDMNIAEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8CB650", Offset = "0x8CA850", VA = "0x1808CB650", Slot = "7")]
	protected virtual string ELPJMLHLNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8CB6B0", Offset = "0x8CA8B0", VA = "0x1808CB6B0")]
	public void GOGEMCIFMMK(HGGBOHCOOKN KAHGHEBEBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8CB5E0", Offset = "0x8CA7E0", VA = "0x1808CB5E0")]
	protected void CGHLLMEBAAO(float DNNNMCEHJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8CB790", Offset = "0x8CA990", VA = "0x1808CB790")]
	[AsyncStateMachine(typeof(CMKPEFPKOGP))]
	public Task JMOHDGKJGBJ(CancellationToken GENHLOEKMNL, CIHEPFKAKNH EFJKGFIDBLG, [Optional] Func<HOKANCNHCCE, CIHEPFKAKNH, BJHEGHJPHON> NOBJJODPALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8CB4D0", Offset = "0x8CA6D0", VA = "0x1808CB4D0")]
	private void BOAPDDJBKCP(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task PNCOHHAOPBL(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8CB9C0", Offset = "0x8CABC0", VA = "0x1808CB9C0")]
	[AsyncStateMachine(typeof(EALGAADBBIB))]
	private Task PMIBHPANDAH(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x8CB940", Offset = "0x8CAB40", VA = "0x1808CB940")]
	public HOMLJGGAMHI PJBFCGNPPIO(FIMDMCMMKJH MCLJOFGLJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8CB400", Offset = "0x8CA600", VA = "0x1808CB400")]
	[CompilerGenerated]
	private Task APNGGMMPFGC(CancellationToken FOLCGJFJJMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class ELIGBMIOFOP : KNNLIPNLPFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct FENKMNLFICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public ELIGBMIOFOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private MIPEDOLMHFF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private DEEPDEAMNNA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9BDB00", Offset = "0x9BCD00", VA = "0x1809BDB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly FLLOKKAPGEA HFLLFECCECN;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x9B9730", Offset = "0x9B8930", VA = "0x1809B9730")]
	public ELIGBMIOFOP(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, FLLOKKAPGEA HFLLFECCECN, DPBKAPJPKAG MBFHOFKPOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x9B95F0", Offset = "0x9B87F0", VA = "0x1809B95F0", Slot = "9")]
	[AsyncStateMachine(typeof(FENKMNLFICC))]
	protected override Task IJHMLKCCCHF(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal class CIDELAGKHFB : HOKANCNHCCE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct BIBEJNEKAJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CIDELAGKHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter<KOPDLHJILKH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xC32CE0", Offset = "0xC31EE0", VA = "0x180C32CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly string CINMLDGILIE;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0xC35DA0", Offset = "0xC34FA0", VA = "0x180C35DA0")]
	public CIDELAGKHFB(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, DPBKAPJPKAG MBFHOFKPOAM, string CINMLDGILIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xC35C70", Offset = "0xC34E70", VA = "0x180C35C70", Slot = "8")]
	[AsyncStateMachine(typeof(BIBEJNEKAJJ))]
	protected override Task PNCOHHAOPBL(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal class CHHJCGGLJKF : KNNLIPNLPFF
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class FBGNLAPHPAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public FBGNLAPHPAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			private TaskAwaiter<KOPDLHJILKH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			private TaskAwaiter<HOMLJGGAMHI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xC462A0", Offset = "0xC454A0", VA = "0x180C462A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xC46670", Offset = "0xC45870", VA = "0x180C46670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CHHJCGGLJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public OKOEBEOHBAH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public NLAKCCNIKCI uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FBGNLAPHPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xC3C9C0", Offset = "0xC3BBC0", VA = "0x180C3C9C0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<HOMLJGGAMHI> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct PMMDHPPEKNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public CHHJCGGLJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private FBGNLAPHPAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private MIPEDOLMHFF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private DEEPDEAMNNA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xC43660", Offset = "0xC42860", VA = "0x180C43660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private readonly int LNPAPJKCEPH;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xC35630", Offset = "0xC34830", VA = "0x180C35630")]
	public CHHJCGGLJKF(Guid BPIHMIEIAOA, BNHHCILIEOE LLLBIFNKIPP, int LNPAPJKCEPH, DPBKAPJPKAG MBFHOFKPOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xC35360", Offset = "0xC34560", VA = "0x180C35360", Slot = "9")]
	[AsyncStateMachine(typeof(PMMDHPPEKNH))]
	protected override Task IJHMLKCCCHF(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xC35260", Offset = "0xC34460", VA = "0x180C35260")]
	private void DBJFOJNMJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xC354A0", Offset = "0xC346A0", VA = "0x180C354A0")]
	private void KCMBMCIOONG(CIHEPFKAKNH EFJKGFIDBLG, MIPEDOLMHFF PENHLMIDEOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class NOPPKJDJCNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly HOKANCNHCCE FJDLDJAGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public readonly BJHEGHJPHON EDAHDLACGEJ;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x20E0B70", Offset = "0x20DFD70", VA = "0x1820E0B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x20E0B10", Offset = "0x20DFD10", VA = "0x1820E0B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x20E0B90", Offset = "0x20DFD90", VA = "0x1820E0B90")]
	protected NOPPKJDJCNP(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x20E0AD0", Offset = "0x20DFCD0", VA = "0x1820E0AD0")]
	protected void ELLDIMGOPPA(string CKNFEFABJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x20E0AF0", Offset = "0x20DFCF0", VA = "0x1820E0AF0")]
	public void ELLDIMGOPPA(Func<string> BOGFNNBPECP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal struct IJAJJLPKNOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public Dictionary<Guid, List<NDOHDGJACNE>> DGNIHDLENPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public Dictionary<Guid, List<NDOHDGJACNE>> OIFPBKMLIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public Dictionary<Guid, List<NDOHDGJACNE>> LDJEPFBOJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public List<Guid> EPHHGJHBGMA;

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8CCBA0", Offset = "0x8CBDA0", VA = "0x1808CCBA0")]
	public static IJAJJLPKNOP FCLOOBPJBAH(JGACAEEBELJ FEPEKJBDLDA, LPLBPIGKKLD HEDGOPFCKAM, MOPOKHJCMLO LPMBKJNEDFL)
	{
		return default(IJAJJLPKNOP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal struct EKJDMBONHIF
{
	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270")]
	public static EKJDMBONHIF CNOGLGNGFED()
	{
		return default(EKJDMBONHIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void FPOJALEBHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void FBLCHMFEFFI(MOPOKHJCMLO ADIGGFBANFM, object PHABFFFGDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void FACIJLJKLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct DEACGBHBBNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public readonly FNJGHNELDIC GMHAPMPIHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public readonly DEJNIAFBCPN KKIFEMKLNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public readonly HNBLGAFLIBA MOAFHKBBDOA;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xB6A250", Offset = "0xB69450", VA = "0x180B6A250")]
	public DEACGBHBBNM(FNJGHNELDIC GMHAPMPIHMC, DEJNIAFBCPN KKIFEMKLNND, HNBLGAFLIBA MOAFHKBBDOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct DFABDLDJJGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly BJHEGHJPHON KFGGLKHDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly Guid NEPPMHBKFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private bool ELONJFDADAO;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x9B5F00", Offset = "0x9B5100", VA = "0x1809B5F00")]
	public static DFABDLDJJGK HIPKPODGLGN(BJHEGHJPHON KFGGLKHDAEF)
	{
		return default(DFABDLDJJGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x9B5EF0", Offset = "0x9B50F0", VA = "0x1809B5EF0")]
	public void FOAFMOPNHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x9B5E90", Offset = "0x9B5090", VA = "0x1809B5E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x9B6010", Offset = "0x9B5210", VA = "0x1809B6010")]
	private DFABDLDJJGK(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x9B5E90", Offset = "0x9B5090", VA = "0x1809B5E90")]
	private void OBDOOELIKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x9B5F60", Offset = "0x9B5160", VA = "0x1809B5F60")]
	private Func<Guid, bool> NFDFCLPOHED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class DEEPDEAMNNA : NOPPKJDJCNP, DGILGBLHKKK
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task<LPLBPIGKKLD> CEAKEKKDOPJ(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF DHHEGEHMMIJ, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct BFAOKCOEHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public FLLOKKAPGEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private DFABDLDJJGK <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xC31980", Offset = "0xC30B80", VA = "0x180C31980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct GLACBJMMPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public FLLOKKAPGEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private CIHEPFKAKNH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xC3D4B0", Offset = "0xC3C6B0", VA = "0x180C3D4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xC3D880", Offset = "0xC3CA80", VA = "0x180C3D880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct GBMDLICNKKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public FLLOKKAPGEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private CIHEPFKAKNH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xC3CB80", Offset = "0xC3BD80", VA = "0x180C3CB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class DHGLGFBDDIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public AsyncTaskMethodBuilder<DEACGBHBBNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public DHGLGFBDDIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private DEACGBHBBNM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private TaskAwaiter<LPLBPIGKKLD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			private TaskAwaiter<DEACGBHBBNM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xC44140", Offset = "0xC43340", VA = "0x180C44140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xC44930", Offset = "0xC43B30", VA = "0x180C44930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public AsyncTaskMethodBuilder<MOPOKHJCMLO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public DHGLGFBDDIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			private MOPOKHJCMLO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			private TaskAwaiter<LPLBPIGKKLD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			private TaskAwaiter<MOPOKHJCMLO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xC44980", Offset = "0xC43B80", VA = "0x180C44980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xC44E20", Offset = "0xC44020", VA = "0x180C44E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public DHGLGFBDDIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			private TaskAwaiter<LPLBPIGKKLD> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			private HMJCIDPMMMF <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xC44E70", Offset = "0xC44070", VA = "0x180C44E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public FLLOKKAPGEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public MOPMEHDPIJM preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public MOPMEHDPIJM downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public DEACGBHBBNM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public MOPMEHDPIJM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public MOPOKHJCMLO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public IPLKHEPDMLK.GFEFCIMGDFF <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DHGLGFBDDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xC3AF40", Offset = "0xC3A140", VA = "0x180C3AF40")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task<DEACGBHBBNM> <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xC3B060", Offset = "0xC3A260", VA = "0x180C3B060")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<MOPOKHJCMLO> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xC3B2B0", Offset = "0xC3A4B0", VA = "0x180C3B2B0")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xC3B190", Offset = "0xC3A390", VA = "0x180C3B190")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct KCHFCIMEEMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public FLLOKKAPGEA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private DHGLGFBDDIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter<DEACGBHBBNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter<MOPOKHJCMLO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xC40150", Offset = "0xC3F350", VA = "0x180C40150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct LLFNCMLJBMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xC40EB0", Offset = "0xC400B0", VA = "0x180C40EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct IHMAHLMKNCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private CIHEPFKAKNH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xC3E330", Offset = "0xC3D530", VA = "0x180C3E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct CJHABDHNKHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private CIHEPFKAKNH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private PFFJENBPDDG.GMFIECPAHCK <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<PFFJENBPDDG.GMFIECPAHCK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xC35E40", Offset = "0xC35040", VA = "0x180C35E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xC36A60", Offset = "0xC35C60", VA = "0x180C36A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct NFJNFLHHMPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public HMJCIDPMMMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private CIHEPFKAKNH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x9C86D0", Offset = "0x9C78D0", VA = "0x1809C86D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9C9170", Offset = "0x9C8370", VA = "0x1809C9170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct KIPPCGHMCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public LPLBPIGKKLD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public MOPOKHJCMLO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xC40C30", Offset = "0xC3FE30", VA = "0x180C40C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xC40E10", Offset = "0xC40010", VA = "0x180C40E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class GMCJMLOFHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CEAKEKKDOPJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public HMJCIDPMMMF timedYielder;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GMCJMLOFHIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class MHFJPIPLGHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public MHFJPIPLGHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<LPLBPIGKKLD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xC45D70", Offset = "0xC44F70", VA = "0x180C45D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xC46250", Offset = "0xC45450", VA = "0x180C46250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public LPLBPIGKKLD originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public GMCJMLOFHIK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MHFJPIPLGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xC41910", Offset = "0xC40B10", VA = "0x180C41910")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<LPLBPIGKKLD> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct EEHMPDFIKIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public CEAKEKKDOPJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public HMJCIDPMMMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xC3C060", Offset = "0xC3B260", VA = "0x180C3C060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xC3C480", Offset = "0xC3B680", VA = "0x180C3C480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct NBGFILKKAEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public MOPMEHDPIJM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private LPLBPIGKKLD <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private IEnumerator<LPLBPIGKKLD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xC42110", Offset = "0xC41310", VA = "0x180C42110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct DPHNBGEJDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xC3BB30", Offset = "0xC3AD30", VA = "0x180C3BB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct DKINBGDLIOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder<PFFJENBPDDG.GMFIECPAHCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public DEEPDEAMNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private TaskAwaiter<PFFJENBPDDG.GMFIECPAHCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xC3B540", Offset = "0xC3A740", VA = "0x180C3B540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xC3B6D0", Offset = "0xC3A8D0", VA = "0x180C3B6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class ELNPGHNHNOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public FNJGHNELDIC roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ELNPGHNHNOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xC3C660", Offset = "0xC3B860", VA = "0x180C3C660")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly KHMNKHEBLDL PBPJACOBCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly KHMNKHEBLDL HJNMLGFKIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly BEIMJCANIFD BMHIOKOOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly FHFHNIHCCGP KDFMLCNHHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly HLBOJLKHIIA EBBCDLDJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly KBPNBEMIOLG JKMIFDDNGCD;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float DHDAOMCPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xC3A810", Offset = "0xC39A10", VA = "0x180C3A810", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private BNHHCILIEOE JICDEINMNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x8DA560", Offset = "0x8D9760", VA = "0x1808DA560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JEOFJMEBFME BHJJOLGJFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xC39A80", Offset = "0xC38C80", VA = "0x180C39A80", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xC39750", Offset = "0xC38950", VA = "0x180C39750", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xC3AD20", Offset = "0xC39F20", VA = "0x180C3AD20")]
	public DEEPDEAMNNA(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xC39D00", Offset = "0xC38F00", VA = "0x180C39D00")]
	[AsyncStateMachine(typeof(BFAOKCOEHNM))]
	public Task IIDEIFFMLEC(FLLOKKAPGEA KPOBLGGEAFB, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xC3A6B0", Offset = "0xC398B0", VA = "0x180C3A6B0")]
	[AsyncStateMachine(typeof(GLACBJMMPCD))]
	private Task<HOMLJGGAMHI> NKIEOHOCKAA(FLLOKKAPGEA KPOBLGGEAFB, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xC39770", Offset = "0xC38970", VA = "0x180C39770")]
	[AsyncStateMachine(typeof(GBMDLICNKKD))]
	private Task AONNGCLJDAC(FLLOKKAPGEA KPOBLGGEAFB, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xC39AD0", Offset = "0xC38CD0", VA = "0x180C39AD0")]
	[AsyncStateMachine(typeof(KCHFCIMEEMB))]
	private Task HFOFJONONKD(FLLOKKAPGEA KPOBLGGEAFB, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken LKJFHGMEBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xC39E40", Offset = "0xC39040", VA = "0x180C39E40")]
	[AsyncStateMachine(typeof(LLFNCMLJBMO))]
	private Task IOALJLDODHD(CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xC398E0", Offset = "0xC38AE0", VA = "0x180C398E0")]
	[AsyncStateMachine(typeof(IHMAHLMKNCK))]
	private Task EFKPAABOCAI(MOPOKHJCMLO ADIGGFBANFM, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xC3A4D0", Offset = "0xC396D0", VA = "0x180C3A4D0")]
	[AsyncStateMachine(typeof(CJHABDHNKHL))]
	private Task<LPLBPIGKKLD> KMCIDGPBHNO(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xC3AA00", Offset = "0xC39C00", VA = "0x180C3AA00")]
	[AsyncStateMachine(typeof(NFJNFLHHMPB))]
	private Task<LPLBPIGKKLD> PCGAMEAFMCH(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xC3ABB0", Offset = "0xC39DB0", VA = "0x180C3ABB0")]
	[AsyncStateMachine(typeof(KIPPCGHMCFD))]
	private Task<LPLBPIGKKLD> PPIBLCEDCEK(LPLBPIGKKLD HEDGOPFCKAM, MOPOKHJCMLO LPMBKJNEDFL, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL, bool HPBIMECLGDL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xC39C10", Offset = "0xC38E10", VA = "0x180C39C10")]
	private bool IAOIHGJHFOM(MOPOKHJCMLO DCJMLNDNMJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xC3A870", Offset = "0xC39A70", VA = "0x180C3A870")]
	[AsyncStateMachine(typeof(EEHMPDFIKIF))]
	protected Task<LPLBPIGKKLD> PALAJGCAIJH(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL, CEAKEKKDOPJ FLPJIPCOANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xC3A210", Offset = "0xC39410", VA = "0x180C3A210")]
	[AsyncStateMachine(typeof(NBGFILKKAEP))]
	private Task JIMEHFDKGIB(MOPOKHJCMLO ADIGGFBANFM, MOPMEHDPIJM HPBFEAPJMBG, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xC39700", Offset = "0xC38900", VA = "0x180C39700")]
	private void AEOBONFENGJ(LPLBPIGKKLD HANJFHJMFPP, MOPMEHDPIJM HPBFEAPJMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xC3AB70", Offset = "0xC39D70", VA = "0x180C3AB70")]
	private void PLCOPMOKDLK(LPLBPIGKKLD GDEOEJOBLIP, out LPLBPIGKKLD HDKLIDMEAFL, out LPLBPIGKKLD MCELDLHGGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xC3A830", Offset = "0xC39A30", VA = "0x180C3A830")]
	private Task<DEACGBHBBNM> OIPINDBLEPJ(FLLOKKAPGEA KPOBLGGEAFB, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0xC3A660", Offset = "0xC39860", VA = "0x180C3A660")]
	private Task<MOPOKHJCMLO> NGBLNAKMBPP(FLLOKKAPGEA KPOBLGGEAFB, DEACGBHBBNM ADIGGFBANFM, IPLKHEPDMLK.GFEFCIMGDFF KLLPEBGDOMN, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xC3A0C0", Offset = "0xC392C0", VA = "0x180C3A0C0")]
	[AsyncStateMachine(typeof(DPHNBGEJDPH))]
	private Task JIAPGMHHACP(MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xC3A3A0", Offset = "0xC395A0", VA = "0x180C3A3A0")]
	[AsyncStateMachine(typeof(DKINBGDLIOO))]
	private Task<PFFJENBPDDG.GMFIECPAHCK> KHJFBAOADJA(MOPOKHJCMLO ADIGGFBANFM, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xC3A370", Offset = "0xC39570", VA = "0x180C3A370")]
	private Task JLFHHPLFPKO(MOPOKHJCMLO ADIGGFBANFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xC39A40", Offset = "0xC38C40", VA = "0x180C39A40")]
	private Task EOFFMDDFHFH(MOPOKHJCMLO ADIGGFBANFM, PFFJENBPDDG.GMFIECPAHCK IHLKFMLNGDC, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0xC398C0", Offset = "0xC38AC0", VA = "0x180C398C0")]
	private Task BBHFICGGBHF(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xC3A630", Offset = "0xC39830", VA = "0x180C3A630")]
	private Task MECNHNGONLP(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xC3A650", Offset = "0xC39850", VA = "0x180C3A650")]
	private static Task NEIDAJLPFMA(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xC39A60", Offset = "0xC38C60", VA = "0x180C39A60")]
	private Task GGNBHFEJDDA(MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0xC3A0A0", Offset = "0xC392A0", VA = "0x180C3A0A0")]
	private Task JBLGDELIFPE(MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xC39AA0", Offset = "0xC38CA0", VA = "0x180C39AA0")]
	private void GOECGJIPBNG(FLLOKKAPGEA KPOBLGGEAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xC39F70", Offset = "0xC39170", VA = "0x180C39F70")]
	private static void JBFNCMDDEDM(FNJGHNELDIC GMHAPMPIHMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct PFFJENBPDDG
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public struct GMFIECPAHCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public readonly Dictionary<int, int> GNHCMADNHKF;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
		public GMFIECPAHCK(Dictionary<int, int> GNHCMADNHKF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private LPLBPIGKKLD HANJFHJMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private MOPOKHJCMLO ADIGGFBANFM;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x20E68F0", Offset = "0x20E5AF0", VA = "0x1820E68F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x20E6520", Offset = "0x20E5720", VA = "0x1820E6520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x20E6840", Offset = "0x20E5A40", VA = "0x1820E6840")]
	public static Task<GMFIECPAHCK> JMOHDGKJGBJ(BNHHCILIEOE LLLBIFNKIPP, LPLBPIGKKLD HANJFHJMFPP, MOPOKHJCMLO ADIGGFBANFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x20E65A0", Offset = "0x20E57A0", VA = "0x1820E65A0")]
	private GMFIECPAHCK JMOHDGKJGBJ()
	{
		return default(GMFIECPAHCK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct IGLFNGKGHCP
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF40", Offset = "0x8CB140", VA = "0x1808CBF40")]
	public static Task JMOHDGKJGBJ(CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct PMECNMLBCOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct JLLEDGBDMHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private CIHEPFKAKNH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x20DEC00", Offset = "0x20DDE00", VA = "0x1820DEC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x20E6A60", Offset = "0x20E5C60", VA = "0x1820E6A60")]
	[AsyncStateMachine(typeof(JLLEDGBDMHD))]
	public static Task JMOHDGKJGBJ(BJHEGHJPHON KFGGLKHDAEF, MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct JEJLLJHLNOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct FAOHPBBEKJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public HMJCIDPMMMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private LPLBPIGKKLD <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private BNHHCILIEOE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private JGACAEEBELJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private List<(PersistenceView, APKLKLKEDEA)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private APKLKLKEDEA <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8C8110", Offset = "0x8C7310", VA = "0x1808C8110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8D0C40", Offset = "0x8CFE40", VA = "0x1808D0C40")]
	[AsyncStateMachine(typeof(FAOHPBBEKJI))]
	public static Task JMOHDGKJGBJ(BJHEGHJPHON KFGGLKHDAEF, MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8D0DB0", Offset = "0x8CFFB0", VA = "0x1808D0DB0")]
	private static void PFNBGMNLLEC(PersistenceView KPPLLFPIALK, APKLKLKEDEA PHABFFFGDNC, MOPOKHJCMLO ADIGGFBANFM, LPLBPIGKKLD HEDGOPFCKAM, bool JBPPGJJGCAA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct AGJPOFIHDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xC2F8C0", Offset = "0xC2EAC0", VA = "0x180C2F8C0")]
	public static Task JMOHDGKJGBJ(BNHHCILIEOE LLLBIFNKIPP, MOPOKHJCMLO ADIGGFBANFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct MPIJFGJKJAM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct FBDLDGPEIAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public BNHHCILIEOE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8800", Offset = "0x8C7A00", VA = "0x1808C8800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct KBEPNBDNOMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public MPIJFGJKJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2920", Offset = "0x8D1B20", VA = "0x1808D2920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class BJEMDHJKKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public GKPCFNJDGEA version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BJEMDHJKKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C53E0", Offset = "0x8C45E0", VA = "0x1808C53E0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5490", Offset = "0x8C4690", VA = "0x1808C5490")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private MOPOKHJCMLO ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private BJHEGHJPHON KFGGLKHDAEF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private static readonly ByteString JJBOBFHOPHC;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F20", Offset = "0x8D9120", VA = "0x1808D9F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private HIKJLEMACCL GBHICMPNCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8D9620", Offset = "0x8D8820", VA = "0x1808D9620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8D9DC0", Offset = "0x8D8FC0", VA = "0x1808D9DC0")]
	[AsyncStateMachine(typeof(FBDLDGPEIAA))]
	public static Task JMOHDGKJGBJ(BNHHCILIEOE LLLBIFNKIPP, LPLBPIGKKLD HANJFHJMFPP, MOPOKHJCMLO ADIGGFBANFM, BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8D9C70", Offset = "0x8D8E70", VA = "0x1808D9C70")]
	[AsyncStateMachine(typeof(KBEPNBDNOMJ))]
	private Task JMOHDGKJGBJ(CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8D96A0", Offset = "0x8D88A0", VA = "0x1808D96A0")]
	private void JDJDMNBNGLM([NotNull] FODENONHEJC EFMGFKIIAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8D95F0", Offset = "0x8D87F0", VA = "0x1808D95F0")]
	private bool ELOEPLPPMOP(GKPCFNJDGEA BCHFMCCIDMH, FODENONHEJC EFMGFKIIAIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal struct KACBKIMJJMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct KFFEHDPFOMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder<MOPOKHJCMLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public KACBKIMJJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public IPLKHEPDMLK.GFEFCIMGDFF downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private CIHEPFKAKNH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<(global::EABJJOPDGLM<ECEIBLDGNAE, JMNFFALHFMO>, global::EABJJOPDGLM<global::KKFMAOPDNGH<FODENONHEJC>, JMNFFALHFMO>, global::EABJJOPDGLM<global::KKFMAOPDNGH<BHBOEJLJKEA>, JMNFFALHFMO>, global::EABJJOPDGLM<global::KKFMAOPDNGH<NCNKAGACMPF>, JMNFFALHFMO>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D32F0", Offset = "0x8D24F0", VA = "0x1808D32F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A70", Offset = "0x8D2C70", VA = "0x1808D3A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct INFLPEELBBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder<global::EABJJOPDGLM<ECEIBLDGNAE, JMNFFALHFMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CIHEPFKAKNH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public KACBKIMJJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public IPLKHEPDMLK.GFEFCIMGDFF downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private CIHEPFKAKNH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter<global::EABJJOPDGLM<ECEIBLDGNAE, JMNFFALHFMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB40", Offset = "0x8CCD40", VA = "0x1808CDB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x8CDF90", Offset = "0x8CD190", VA = "0x1808CDF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private global::LOFLAHOJKJG<CBCEEBNMKHL, BHBOEJLJKEA> BEKONLPIBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private global::LOFLAHOJKJG<CBCEEBNMKHL, FODENONHEJC> KKIFEMKLNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private global::LOFLAHOJKJG<long, NCNKAGACMPF> MINEOKAHEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private NLJLDBPJICF IAJMAFJPCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private FLLOKKAPGEA KPOBLGGEAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private FNJGHNELDIC GMHAPMPIHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private DEJNIAFBCPN PGLNAADHFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private long EEOJGJPIKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private CIHEPFKAKNH NDCCOMJDOFK;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D2480", Offset = "0x8D1680", VA = "0x1808D2480")]
	public static Task<MOPOKHJCMLO> JHKHBMPABDA(BNHHCILIEOE LLLBIFNKIPP, FLLOKKAPGEA KPOBLGGEAFB, in DEACGBHBBNM ADIGGFBANFM, IPLKHEPDMLK.GFEFCIMGDFF KLLPEBGDOMN, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D2770", Offset = "0x8D1970", VA = "0x1808D2770")]
	[AsyncStateMachine(typeof(KFFEHDPFOMJ))]
	private Task<MOPOKHJCMLO> JMOHDGKJGBJ(IPLKHEPDMLK.GFEFCIMGDFF KLLPEBGDOMN, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x8D22A0", Offset = "0x8D14A0", VA = "0x1808D22A0")]
	private CBCEEBNMKHL EPFIPEGMDAC(JPNCDNELCPE PBNDNGFJJCP)
	{
		return default(CBCEEBNMKHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x8D22E0", Offset = "0x8D14E0", VA = "0x1808D22E0")]
	[AsyncStateMachine(typeof(INFLPEELBBL))]
	private Task<global::EABJJOPDGLM<ECEIBLDGNAE, JMNFFALHFMO>> JELEPCGJEDF(string AOLBKHGPCCM, long EEOJGJPIKOH, IPLKHEPDMLK.GFEFCIMGDFF KLLPEBGDOMN, CIHEPFKAKNH FJMIOEGIPAL, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct OKCLOONFIIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct KJOOFODNHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder<DEACGBHBBNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public OKCLOONFIIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private CIHEPFKAKNH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter<DEACGBHBBNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x20DEFF0", Offset = "0x20DE1F0", VA = "0x1820DEFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x20DF3C0", Offset = "0x20DE5C0", VA = "0x1820DF3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct PMJNIPKMNAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<DEACGBHBBNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public OKCLOONFIIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter<DEACGBHBBNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x20E6BA0", Offset = "0x20E5DA0", VA = "0x1820E6BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x20E6E90", Offset = "0x20E6090", VA = "0x1820E6E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class HOCOFNLPCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HOCOFNLPCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xC34980", Offset = "0xC33B80", VA = "0x180C34980")]
		internal bool <FetchRoomDetails>b__0(DEJNIAFBCPN sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct EBCPNJBDIEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AsyncTaskMethodBuilder<DEACGBHBBNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public JGACAEEBELJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private HOCOFNLPCFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<FNJGHNELDIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x20DDDC0", Offset = "0x20DCFC0", VA = "0x1820DDDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x20DE200", Offset = "0x20DD400", VA = "0x1820DE200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private BEIMJCANIFD BMHIOKOOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private CIHEPFKAKNH NDCCOMJDOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private long AHCJAABMBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private long NCGNHGHNMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private string FEIOFOAJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private CBCEEBNMKHL JCJBBDAKKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private CBCEEBNMKHL OBLMGMDFCHE;

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x20E4310", Offset = "0x20E3510", VA = "0x1820E4310")]
	public static Task<DEACGBHBBNM> JHKHBMPABDA(BNHHCILIEOE LLLBIFNKIPP, FLLOKKAPGEA KPOBLGGEAFB, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x20E4500", Offset = "0x20E3700", VA = "0x1820E4500")]
	[AsyncStateMachine(typeof(KJOOFODNHHD))]
	private Task<DEACGBHBBNM> JMOHDGKJGBJ(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x20E4920", Offset = "0x20E3B20", VA = "0x1820E4920")]
	[AsyncStateMachine(typeof(PMJNIPKMNAG))]
	private Task<DEACGBHBBNM> OIPINDBLEPJ(long AHCJAABMBLP, long NCGNHGHNMLN, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL, bool JJGOIOOIAKD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x20E47D0", Offset = "0x20E39D0", VA = "0x1820E47D0")]
	[AsyncStateMachine(typeof(EBCPNJBDIEI))]
	public static Task<DEACGBHBBNM> OIPINDBLEPJ(JGACAEEBELJ FEPEKJBDLDA, long AHCJAABMBLP, long NCGNHGHNMLN, CancellationToken GENHLOEKMNL, CIHEPFKAKNH EFJKGFIDBLG, bool JJGOIOOIAKD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x20E4640", Offset = "0x20E3840", VA = "0x1820E4640")]
	private void KAEKBJOIKKM(FNJGHNELDIC GMHAPMPIHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x20E41A0", Offset = "0x20E33A0", VA = "0x1820E41A0")]
	private bool DFEEHPLLKKI(DEACGBHBBNM ADIGGFBANFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x20E4670", Offset = "0x20E3870", VA = "0x1820E4670")]
	private void NDBBBBKALJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct AKEPNPPONHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct OFNMJJLHABM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AKEPNPPONHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xC42520", Offset = "0xC41720", VA = "0x180C42520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private const int FLIDELBGGKH = 20;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private const float JHHKBBNFOOD = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private JGACAEEBELJ FEPEKJBDLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private MOPOKHJCMLO ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private CIHEPFKAKNH NDCCOMJDOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private float HNKCEGKCMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private float DBELFCMBLNO;

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0xC30320", Offset = "0xC2F520", VA = "0x180C30320")]
	public static Task LNICOJLLJOM(BNHHCILIEOE LLLBIFNKIPP, MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0xC30200", Offset = "0xC2F400", VA = "0x180C30200")]
	[AsyncStateMachine(typeof(OFNMJJLHABM))]
	public Task JMOHDGKJGBJ(CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xC304D0", Offset = "0xC2F6D0", VA = "0x180C304D0")]
	private static void PDNGCAFJAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0xC30640", Offset = "0xC2F840", VA = "0x180C30640")]
	private void PEGOAGHCNND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0xC30140", Offset = "0xC2F340", VA = "0x180C30140")]
	private static float GFGPKOGCAAB(JGACAEEBELJ FEPEKJBDLDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xC30120", Offset = "0xC2F320", VA = "0x180C30120")]
	private static float EJNCNBDPFDC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct KGILDCHLBJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct LEPEGAELBID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public BJHEGHJPHON operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public PFFJENBPDDG.GMFIECPAHCK mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private HOKANCNHCCE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private BNHHCILIEOE <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private HMENMHDMOFG.BDAHFKBJGDH <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D58B0", Offset = "0x8D4AB0", VA = "0x1808D58B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct KFAMFKBHPHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private BHBLIAOJPIH.GHDNMCNHEHE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3080", Offset = "0x8D2280", VA = "0x1808D3080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D60", Offset = "0x8D2F60", VA = "0x1808D3D60")]
	[AsyncStateMachine(typeof(LEPEGAELBID))]
	public static Task JMOHDGKJGBJ(BJHEGHJPHON KFGGLKHDAEF, MOPOKHJCMLO ADIGGFBANFM, PFFJENBPDDG.GMFIECPAHCK IHLKFMLNGDC, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C10", Offset = "0x8D2E10", VA = "0x1808D3C10")]
	private static Task<HOMLJGGAMHI> GBJLOIIGKLG(BJHEGHJPHON KFGGLKHDAEF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C80", Offset = "0x8D2E80", VA = "0x1808D3C80")]
	[AsyncStateMachine(typeof(KFAMFKBHPHN))]
	private static Task JIOHLHJBAGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct LLLHGICFLJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct KPDKEKMBBAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public LLLHGICFLJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BE0", Offset = "0x8D3DE0", VA = "0x1808D4BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class MAOIDDCNPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public MAOIDDCNPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D7AE0", Offset = "0x8D6CE0", VA = "0x1808D7AE0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct FHPCKLFIINM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public LLLHGICFLJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private MNNEECKMIGD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E20", Offset = "0x8C8020", VA = "0x1808C8E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private bool LBBKBILLEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private CIHEPFKAKNH NDCCOMJDOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private CancellationToken GENHLOEKMNL;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8D7910", Offset = "0x8D6B10", VA = "0x1808D7910")]
	public static Task APHKHCNEOOA(BNHHCILIEOE LLLBIFNKIPP, bool LBBKBILLEAL, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken HCJIEFGHELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8D7990", Offset = "0x8D6B90", VA = "0x1808D7990")]
	[AsyncStateMachine(typeof(KPDKEKMBBAG))]
	private Task JMOHDGKJGBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x8D77E0", Offset = "0x8D69E0", VA = "0x1808D77E0")]
	[AsyncStateMachine(typeof(FHPCKLFIINM))]
	private Task ACNMIANOGEB(bool JLINIOELJKI, string KKBNOPPEJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270")]
	private bool EKECKEJIEAC(bool LBBKBILLEAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct LGHKCPCHNGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct IFIMEBFCNCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public LGHKCPCHNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8CBC50", Offset = "0x8CAE50", VA = "0x1808CBC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEF0", Offset = "0x8CB0F0", VA = "0x1808CBEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class DMCOOKCDBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DMCOOKCDBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C7710", Offset = "0x8C6910", VA = "0x1808C7710")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct FEBFJJOOPEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public LGHKCPCHNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private MNNEECKMIGD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C8970", Offset = "0x8C7B70", VA = "0x1808C8970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D80", Offset = "0x8C7F80", VA = "0x1808C8D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private HNBLGAFLIBA IIICBBAJLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private CIHEPFKAKNH NDCCOMJDOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x8D6170", Offset = "0x8D5370", VA = "0x1808D6170")]
	public static Task<Scene> AALDPIKABJD(BNHHCILIEOE LLLBIFNKIPP, HNBLGAFLIBA JKINMNELIEJ, CIHEPFKAKNH NDCCOMJDOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8D62F0", Offset = "0x8D54F0", VA = "0x1808D62F0")]
	[AsyncStateMachine(typeof(IFIMEBFCNCC))]
	private Task<Scene> JMOHDGKJGBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8D61C0", Offset = "0x8D53C0", VA = "0x1808D61C0")]
	[AsyncStateMachine(typeof(FEBFJJOOPEK))]
	private Task<Scene> ACNMIANOGEB(string KKBNOPPEJCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct HLBOJLKHIIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct CHHHAEENADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public HLBOJLKHIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public LPLBPIGKKLD nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public MOPOKHJCMLO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private CIHEPFKAKNH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<LPLBPIGKKLD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B41E0", Offset = "0x9B33E0", VA = "0x1809B41E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B4A00", Offset = "0x9B3C00", VA = "0x1809B4A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct AJCCLLCEPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder<LPLBPIGKKLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public HLBOJLKHIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public LPLBPIGKKLD state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B2F40", Offset = "0x9B2140", VA = "0x1809B2F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B3160", Offset = "0x9B2360", VA = "0x1809B3160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private readonly BJHEGHJPHON KFGGLKHDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private readonly BEIMJCANIFD BMHIOKOOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private readonly FHFHNIHCCGP KDFMLCNHHMF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private HOKANCNHCCE FJDLDJAGCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9C4AF0", Offset = "0x9C3CF0", VA = "0x1809C4AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x9C4B40", Offset = "0x9C3D40", VA = "0x1809C4B40")]
	public HLBOJLKHIIA(BJHEGHJPHON KFGGLKHDAEF, BEIMJCANIFD BMHIOKOOOGJ, FHFHNIHCCGP KDFMLCNHHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x9C4830", Offset = "0x9C3A30", VA = "0x1809C4830")]
	[AsyncStateMachine(typeof(CHHHAEENADL))]
	public Task<LPLBPIGKKLD> EMNCIHFDDIH(LPLBPIGKKLD ICDFPMOGPOH, MOPOKHJCMLO LPMBKJNEDFL, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL, bool HPBIMECLGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x9C49A0", Offset = "0x9C3BA0", VA = "0x1809C49A0")]
	[AsyncStateMachine(typeof(AJCCLLCEPMO))]
	private Task<LPLBPIGKKLD> HMNJHEFKDEK(CIHEPFKAKNH EFJKGFIDBLG, LPLBPIGKKLD IBBEGDPIJBO, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9C4B10", Offset = "0x9C3D10", VA = "0x1809C4B10")]
	private bool POMBDGHEOCO(LPLBPIGKKLD NKNLHFHMJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x9C4810", Offset = "0x9C3A10", VA = "0x1809C4810")]
	private void ELLDIMGOPPA(string GKALFAMOPHN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct KGBCLFOCJKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct EKFOPLOAIGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public HOKANCNHCCE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public HMJCIDPMMMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private List<(PersistenceView, APKLKLKEDEA)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private (PersistenceView, APKLKLKEDEA) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x8C7C10", Offset = "0x8C6E10", VA = "0x1808C7C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AC0", Offset = "0x8D2CC0", VA = "0x1808D3AC0")]
	[AsyncStateMachine(typeof(EKFOPLOAIGH))]
	public static Task JMOHDGKJGBJ(HOKANCNHCCE BLAIMAGHBBE, MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct MIPMMEBOFMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct GCHGGKEPGPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public HOKANCNHCCE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public HMJCIDPMMMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private GKPCFNJDGEA <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private List<(PersistenceView, APKLKLKEDEA)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private APKLKLKEDEA <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C9410", Offset = "0x8C8610", VA = "0x1808C9410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x8D8160", Offset = "0x8D7360", VA = "0x1808D8160")]
	[AsyncStateMachine(typeof(GCHGGKEPGPC))]
	public static Task JMOHDGKJGBJ(HOKANCNHCCE BLAIMAGHBBE, MOPOKHJCMLO ADIGGFBANFM, HMJCIDPMMMF GBBAMNKLEJA, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct HMENMHDMOFG
{
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public struct BDAHFKBJGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public List<KNJLDHIHLDI> CNAIKGGBPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public List<APKLKLKEDEA> HJKPBAJBMCJ;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x826220", Offset = "0x825420", VA = "0x180826220")]
		public BDAHFKBJGDH(List<KNJLDHIHLDI> CNAIKGGBPLD, List<APKLKLKEDEA> HJKPBAJBMCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class GABFJMPECCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public List<KNJLDHIHLDI> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GABFJMPECCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C93A0", Offset = "0x8C85A0", VA = "0x1808C93A0")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private BNHHCILIEOE LLLBIFNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private MOPOKHJCMLO ADIGGFBANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private PFFJENBPDDG.GMFIECPAHCK IHLKFMLNGDC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private JGACAEEBELJ JMGKCHFPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C80", Offset = "0x9C4E80", VA = "0x1809C5C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x9C5BF0", Offset = "0x9C4DF0", VA = "0x1809C5BF0")]
	public static BDAHFKBJGDH JMOHDGKJGBJ(BNHHCILIEOE LLLBIFNKIPP, MOPOKHJCMLO ADIGGFBANFM, PFFJENBPDDG.GMFIECPAHCK IHLKFMLNGDC)
	{
		return default(BDAHFKBJGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x9C59B0", Offset = "0x9C4BB0", VA = "0x1809C59B0")]
	private BDAHFKBJGDH JMOHDGKJGBJ()
	{
		return default(BDAHFKBJGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x9C5530", Offset = "0x9C4730", VA = "0x1809C5530")]
	private BDAHFKBJGDH IEEJODBPNEP(FODENONHEJC EFMGFKIIAIF, GKPCFNJDGEA BBDGMBBBJLF, Dictionary<int, int> CGLGJIFBNGG)
	{
		return default(BDAHFKBJGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x9C50F0", Offset = "0x9C42F0", VA = "0x1809C50F0")]
	private GameObject[] DLMPMAOANIE(List<KNJLDHIHLDI> CNAIKGGBPLD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct HLCKAJKIIDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class JBAOEKIGPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public HMENMHDMOFG.BDAHFKBJGDH instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JBAOEKIGPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x9C6190", Offset = "0x9C5390", VA = "0x1809C6190")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class LOMEMHCNFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LOMEMHCNFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x9C7C50", Offset = "0x9C6E50", VA = "0x1809C7C50")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x9C4BA0", Offset = "0x9C3DA0", VA = "0x1809C4BA0")]
	public static void JMOHDGKJGBJ(HOKANCNHCCE BLAIMAGHBBE, MOPOKHJCMLO ADIGGFBANFM, HMENMHDMOFG.BDAHFKBJGDH AFKGDLNIICA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class FHFHNIHCCGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct GJCIPALANNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public LPLBPIGKKLD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public MOPOKHJCMLO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9C2440", Offset = "0x9C1640", VA = "0x1809C2440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class LNNEGFJMGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LNNEGFJMGNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class DIGEEFNBPKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			public DIGEEFNBPKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x9CBD00", Offset = "0x9CAF00", VA = "0x1809CBD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CIHEPFKAKNH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public LNNEGFJMGNO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DIGEEFNBPKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x9B62A0", Offset = "0x9B54A0", VA = "0x1809B62A0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct PCOGNFKDPAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private DIGEEFNBPKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x9CB1D0", Offset = "0x9CA3D0", VA = "0x1809CB1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct JKKCGKHCPIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private Dictionary<Guid, List<NDOHDGJACNE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6530", Offset = "0x9C5730", VA = "0x1809C6530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct MPDENHFAKEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private CIHEPFKAKNH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private Dictionary<Guid, List<NDOHDGJACNE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9C7DB0", Offset = "0x9C6FB0", VA = "0x1809C7DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class APJIHAKOLPO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			public NDOHDGJACNE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public APJIHAKOLPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x9CBBB0", Offset = "0x9CADB0", VA = "0x1809CBBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public JGGNOCIMGIA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public List<NDOHDGJACNE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public APJIHAKOLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x9B3BE0", Offset = "0x9B2DE0", VA = "0x1809B3BE0")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x9B3D60", Offset = "0x9B2F60", VA = "0x1809B3D60")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(NDOHDGJACNE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x9B3CA0", Offset = "0x9B2EA0", VA = "0x1809B3CA0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct NDJMCPIFPFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public JGGNOCIMGIA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public List<NDOHDGJACNE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private APJIHAKOLPO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x9C8270", Offset = "0x9C7470", VA = "0x1809C8270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct AJNJLIANHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CIHEPFKAKNH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x9B31B0", Offset = "0x9B23B0", VA = "0x1809B31B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class PIALEKOPBAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PIALEKOPBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB50", Offset = "0x9CAD50", VA = "0x1809CBB50")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct KCIEICBCLAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public MOPOKHJCMLO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6910", Offset = "0x9C5B10", VA = "0x1809C6910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class KMDGCDMCEFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public KMDGCDMCEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x9C6D40", Offset = "0x9C5F40", VA = "0x1809C6D40")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct EKFCLKJDMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public FHFHNIHCCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x9B9140", Offset = "0x9B8340", VA = "0x1809B9140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class FDDEHICDMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public FDDEHICDMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x9BDAA0", Offset = "0x9BCCA0", VA = "0x1809BDAA0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly BJHEGHJPHON KFGGLKHDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private IJAJJLPKNOP KDFMLCNHHMF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private HOKANCNHCCE FJDLDJAGCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC60", Offset = "0x7FBE60", VA = "0x1807FCC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6270A0", Offset = "0x6262A0", VA = "0x1806270A0")]
	public FHFHNIHCCGP(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x9BEA80", Offset = "0x9BDC80", VA = "0x1809BEA80")]
	[AsyncStateMachine(typeof(GJCIPALANNH))]
	public Task JMOHDGKJGBJ(LPLBPIGKKLD HEDGOPFCKAM, MOPOKHJCMLO LPMBKJNEDFL, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x9BED30", Offset = "0x9BDF30", VA = "0x1809BED30")]
	[AsyncStateMachine(typeof(PCOGNFKDPAL))]
	private Task NFJIMCPFFIG(MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x9BE070", Offset = "0x9BD270", VA = "0x1809BE070")]
	[AsyncStateMachine(typeof(JKKCGKHCPIB))]
	private Task ACBBJKCLLJM(MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x9BE2F0", Offset = "0x9BD4F0", VA = "0x1809BE2F0")]
	[AsyncStateMachine(typeof(MPDENHFAKEI))]
	private Task BFKHINCPIID(MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1B0", Offset = "0x9BD3B0", VA = "0x1809BE1B0")]
	[AsyncStateMachine(typeof(NDJMCPIFPFI))]
	private Task AKPFHNCJKIH(Guid ANAGGIMPNLJ, List<NDOHDGJACNE> ABGDEDIEIII, JGGNOCIMGIA EOLDLAEPCID, MOPOKHJCMLO ADIGGFBANFM, CancellationToken HCPCDENCJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x9BE7F0", Offset = "0x9BD9F0", VA = "0x1809BE7F0")]
	[AsyncStateMachine(typeof(AJNJLIANHHG))]
	private Task FKFCFOPEAEF(MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x9BE520", Offset = "0x9BD720", VA = "0x1809BE520")]
	[AsyncStateMachine(typeof(KCIEICBCLAL))]
	private Task CMFHBLLNMIB(Guid HJMALFPJPEB, MOPOKHJCMLO ADIGGFBANFM, CIHEPFKAKNH NDCCOMJDOFK, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x9BEBE0", Offset = "0x9BDDE0", VA = "0x1809BEBE0")]
	[AsyncStateMachine(typeof(EKFCLKJDMMA))]
	private Task LBDHOPGIHIM(Guid HJMALFPJPEB, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x9BE930", Offset = "0x9BDB30", VA = "0x1809BE930")]
	private void GMELHJANLPI(Guid HJMALFPJPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x9BE430", Offset = "0x9BD630", VA = "0x1809BE430")]
	private void BPIPBODBHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x9BE650", Offset = "0x9BD850", VA = "0x1809BE650")]
	public Guid DIEGGHBMEAA(LPLBPIGKKLD HANJFHJMFPP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x9BEE80", Offset = "0x9BE080", VA = "0x1809BEE80")]
	[CompilerGenerated]
	private object PCPMBFICDHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public struct KOPDLHJILKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public FODENONHEJC NGILCJIBGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	public List<string> BFBNKFPFMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public Dictionary<long, int> MHDIKGDHFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public string EPBBLOICGNP;
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class OEEDHBPOJCC : NOPPKJDJCNP
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class JAEADDAIJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public GHLNAHICKHI autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public JAEADDAIJCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class OINOJNFADPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public JAEADDAIJCE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OINOJNFADPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x20E4110", Offset = "0x20E3310", VA = "0x1820E4110")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class CEPPAMJLCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public JAEADDAIJCE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CEPPAMJLCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x20DDAB0", Offset = "0x20DCCB0", VA = "0x1820DDAB0")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class DPBNFIOINEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public GHLNAHICKHI autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DPBNFIOINEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x20DDD40", Offset = "0x20DCF40", VA = "0x1820DDD40")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class LAAJNMMDELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public FileInfo autosaveFile;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LAAJNMMDELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x20DF410", Offset = "0x20DE610", VA = "0x1820DF410")]
		internal object <TryReadAutosave>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class DHBGHJDOHGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DHBGHJDOHGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x20DDD00", Offset = "0x20DCF00", VA = "0x1820DDD00")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class PBJPDFDEOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public FileInfo file;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PBJPDFDEOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x20E64B0", Offset = "0x20E56B0", VA = "0x1820E64B0")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class IIHKBCLHOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public IIHKBCLHOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x20DEBA0", Offset = "0x20DDDA0", VA = "0x1820DEBA0")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private const string HPPGCBKHABN = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private const int CANDDIDDHIN = 5;

	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private const string NIBHNKJFPLK = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private const string NCAENKPKPJI = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private const int JIEBPKJOBKN = 32;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x20E0B90", Offset = "0x20DFD90", VA = "0x1820E0B90")]
	public OEEDHBPOJCC(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x20E2BA0", Offset = "0x20E1DA0", VA = "0x1820E2BA0")]
	public bool GNLBCKEBCHH(long NCGNHGHNMLN, KOPDLHJILKH BAGCJGEGOAG, GHLNAHICKHI OKLBJDMNAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x20E1E80", Offset = "0x20E1080", VA = "0x1820E1E80")]
	public static bool CEPLCBNMJNG(long NCGNHGHNMLN, GHLNAHICKHI OKLBJDMNAMD, out FileInfo NBMIHJCBKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x20E1F40", Offset = "0x20E1140", VA = "0x1820E1F40")]
	public bool CLMICKCFGHE(long NCGNHGHNMLN, GHLNAHICKHI OKLBJDMNAMD, out KOPDLHJILKH BAGCJGEGOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x20E19A0", Offset = "0x20E0BA0", VA = "0x1820E19A0")]
	private bool ABHAPDBFCLE(FileInfo NBMIHJCBKHL, out byte[] DMKMKPAGABN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x20E29F0", Offset = "0x20E1BF0", VA = "0x1820E29F0")]
	private static FileInfo GIIGLLFODGF(long NCGNHGHNMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x20E2AD0", Offset = "0x20E1CD0", VA = "0x1820E2AD0")]
	private static FileInfo GNFLFJELOGK(long NCGNHGHNMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x20E3010", Offset = "0x20E2210", VA = "0x1820E3010")]
	private static DirectoryInfo JPPMJCABNHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x20E3080", Offset = "0x20E2280", VA = "0x1820E3080")]
	private void LEILAPIJFFC(FileInfo GNCCFEOKHMF, FODENONHEJC FCLGFPAONJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x20E2500", Offset = "0x20E1700", VA = "0x1820E2500")]
	private void DEOAFCABFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x20E3470", Offset = "0x20E2670", VA = "0x1820E3470")]
	public static void OHOKLONADDF(long NCGNHGHNMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x20E3400", Offset = "0x20E2600", VA = "0x1820E3400")]
	public static bool MJGJKENNCFF(long NCGNHGHNMLN, out DateTime PDOFMLFLGHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal class OKOEBEOHBAH : NOPPKJDJCNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct LMPMODMKDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AsyncTaskMethodBuilder<KOPDLHJILKH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public OKOEBEOHBAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public KCCPHNKJAFO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x20DF480", Offset = "0x20DE680", VA = "0x1820DF480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x20DF980", Offset = "0x20DEB80", VA = "0x1820DF980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class DADOOMPBHNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public KCCPHNKJAFO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DADOOMPBHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x20DDB20", Offset = "0x20DCD20", VA = "0x1820DDB20")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class OMKOLJCIBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public DADOOMPBHNJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public OMKOLJCIBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x20E5F80", Offset = "0x20E5180", VA = "0x1820E5F80")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class HLGBAOHELFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public DADOOMPBHNJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HLGBAOHELFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x20DEB10", Offset = "0x20DDD10", VA = "0x1820DEB10")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct LNPNMPDDGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public KCCPHNKJAFO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public OKOEBEOHBAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private OMKOLJCIBEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private BHBLIAOJPIH.MPFNHPJDDAI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x20DF9D0", Offset = "0x20DEBD0", VA = "0x1820DF9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private readonly ANMMMPJFIHD HLINENEAIIN;

	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private static readonly TimeSpan FHGFPJKIIFH;

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x20E5EA0", Offset = "0x20E50A0", VA = "0x1820E5EA0")]
	public OKOEBEOHBAH(BJHEGHJPHON KFGGLKHDAEF, [Optional] ANMMMPJFIHD? HLINENEAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x20E5670", Offset = "0x20E4870", VA = "0x1820E5670")]
	[AsyncStateMachine(typeof(LMPMODMKDCF))]
	public Task<KOPDLHJILKH> LIOPAMDCNLD(long NCGNHGHNMLN, string AOLBKHGPCCM, KCCPHNKJAFO IPLHOAGGIFB, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x20E4EE0", Offset = "0x20E40E0", VA = "0x1820E4EE0")]
	[AsyncStateMachine(typeof(LNPNMPDDGMG))]
	private Task AJIDIDABCHP(KCCPHNKJAFO IPLHOAGGIFB, IEnumerable<PersistenceView> BODHEKDOOBJ, StringBuilder NJNBHKFCIOC, CancellationToken GENHLOEKMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x20E5230", Offset = "0x20E4430", VA = "0x1820E5230")]
	private KOPDLHJILKH EMPEBKKOEBC(long NCGNHGHNMLN, string AOLBKHGPCCM, KCCPHNKJAFO IPLHOAGGIFB, IEnumerable<PersistenceView> BODHEKDOOBJ, StringBuilder NJNBHKFCIOC)
	{
		return default(KOPDLHJILKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x20E57C0", Offset = "0x20E49C0", VA = "0x1820E57C0")]
	private FODENONHEJC NJNIHIJKNMA(long NCGNHGHNMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x20E5030", Offset = "0x20E4230", VA = "0x1820E5030")]
	private void APMFABGLPEG(FODENONHEJC CFFGDDCGBOC, StringBuilder NJNBHKFCIOC, IEnumerable<PersistenceView> BODHEKDOOBJ, in HJFCEOBMKFM HBNKOANCKDB, ref KMNJHBHPKCC DOKLDCAALJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x20E59A0", Offset = "0x20E4BA0", VA = "0x1820E59A0")]
	private void OAADOBGHAOP(FODENONHEJC CFFGDDCGBOC, StringBuilder NJNBHKFCIOC, PersistenceView KPPLLFPIALK, ref KMNJHBHPKCC DOKLDCAALJC, in HJFCEOBMKFM HBNKOANCKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class NLAKCCNIKCI : NOPPKJDJCNP
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class BALIMJAHAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public NNPLJODHNML.DGIBLHGAFAG roomMetadataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public NNPLJODHNML.DGIBLHGAFAG roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BALIMJAHAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x8C5070", Offset = "0x8C4270", VA = "0x1808C5070")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x8C50F0", Offset = "0x8C42F0", VA = "0x1808C50F0")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x8C5140", Offset = "0x8C4340", VA = "0x1808C5140")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x8C51B0", Offset = "0x8C43B0", VA = "0x1808C51B0")]
		internal object <UploadRoomData>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct DAPOJEHDDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder<(NNPLJODHNML.DGIBLHGAFAG roomMetadataUpload, NNPLJODHNML.DGIBLHGAFAG roomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public KOPDLHJILKH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public NLAKCCNIKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private BALIMJAHAHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private TaskAwaiter<NNPLJODHNML.DGIBLHGAFAG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8C6980", Offset = "0x8C5B80", VA = "0x1808C6980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8C72A0", Offset = "0x8C64A0", VA = "0x1808C72A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct AFLEJMPJBLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder<FNJGHNELDIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public NLAKCCNIKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public KOPDLHJILKH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private TaskAwaiter<(NNPLJODHNML.DGIBLHGAFAG roomMetadataUpload, NNPLJODHNML.DGIBLHGAFAG roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter<FNJGHNELDIC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CC0", Offset = "0x8C3EC0", VA = "0x1808C4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5020", Offset = "0x8C4220", VA = "0x1808C5020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct JNBNCNFKMHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public AsyncTaskMethodBuilder<NMDBGAAGKEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public NLAKCCNIKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public KOPDLHJILKH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private TaskAwaiter<(NNPLJODHNML.DGIBLHGAFAG roomMetadataUpload, NNPLJODHNML.DGIBLHGAFAG roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter<NMDBGAAGKEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8D18D0", Offset = "0x8D0AD0", VA = "0x1808D18D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C00", Offset = "0x8D0E00", VA = "0x1808D1C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class PIKKDHDALMI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public PIKKDHDALMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			private HOMLJGGAMHI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private TaskAwaiter<NMDBGAAGKEB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private TaskAwaiter<FNJGHNELDIC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private TaskAwaiter<HOMLJGGAMHI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x20E76E0", Offset = "0x20E68E0", VA = "0x1820E76E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x20E82F0", Offset = "0x20E74F0", VA = "0x1820E82F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public NLAKCCNIKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public KOPDLHJILKH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public PIKKDHDALMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x20E6940", Offset = "0x20E5B40", VA = "0x1820E6940")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<HOMLJGGAMHI> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct CENMLJIFMPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder<HOMLJGGAMHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public NLAKCCNIKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public KOPDLHJILKH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CIHEPFKAKNH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private TaskAwaiter<HOMLJGGAMHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8C55C0", Offset = "0x8C47C0", VA = "0x1808C55C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8C57F0", Offset = "0x8C49F0", VA = "0x1808C57F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	private const float CLEDFPKJGGG = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	private readonly BBCDJNJMCJI BBDOBDACGDE;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private BNHHCILIEOE JICDEINMNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA560", Offset = "0x8D9760", VA = "0x1808DA560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x8DA590", Offset = "0x8D9790", VA = "0x1808DA590")]
	public NLAKCCNIKCI(BJHEGHJPHON KFGGLKHDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x8DA2C0", Offset = "0x8D94C0", VA = "0x1808DA2C0")]
	[AsyncStateMachine(typeof(DAPOJEHDDGL))]
	private Task<(NNPLJODHNML.DGIBLHGAFAG, NNPLJODHNML.DGIBLHGAFAG)> FIPCHNMOGCN(KOPDLHJILKH BAGCJGEGOAG, long AHCJAABMBLP, long BAHLJDONCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8DA410", Offset = "0x8D9610", VA = "0x1808DA410")]
	[AsyncStateMachine(typeof(AFLEJMPJBLJ))]
	public Task<FNJGHNELDIC> JDLONEEALAI(int LNPAPJKCEPH, KOPDLHJILKH BAGCJGEGOAG, long AHCJAABMBLP, long BAHLJDONCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x8D9FF0", Offset = "0x8D91F0", VA = "0x1808D9FF0")]
	[AsyncStateMachine(typeof(JNBNCNFKMHE))]
	private Task<NMDBGAAGKEB> CGMECKNGPCD(string DBLOGHCOFKG, int LNPAPJKCEPH, KOPDLHJILKH BAGCJGEGOAG, long AHCJAABMBLP, long BAHLJDONCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8DA150", Offset = "0x8D9350", VA = "0x1808DA150")]
	[AsyncStateMachine(typeof(CENMLJIFMPB))]
	public Task<HOMLJGGAMHI> CNCKKEOINPI(int LNPAPJKCEPH, KOPDLHJILKH BAGCJGEGOAG, long AHCJAABMBLP, long BAHLJDONCPF, CIHEPFKAKNH EFJKGFIDBLG, CancellationToken GENHLOEKMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class DKAKIPPIIFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private readonly Guid BPIHMIEIAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private readonly CPOLDIKGNEC ABMLOKNKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private FLLOKKAPGEA FDBJMNOLEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private int? BLFNDBCPENE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Guid NFDKNIOEGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x9B6590", Offset = "0x9B5790", VA = "0x1809B6590")]
	public DKAKIPPIIFI(CPOLDIKGNEC ABMLOKNKPDJ, [Optional] Guid? BPIHMIEIAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x9B63B0", Offset = "0x9B55B0", VA = "0x1809B63B0")]
	public DKAKIPPIIFI AMCNLFCGIPL(FLLOKKAPGEA FDBJMNOLEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x9B64C0", Offset = "0x9B56C0", VA = "0x1809B64C0")]
	public HOMLJGGAMHI MAJOENCGFNG(out Guid NBOGKNCLFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x9B63D0", Offset = "0x9B55D0", VA = "0x1809B63D0")]
	public DKAKIPPIIFI HIBLDCBBBPF(FLLPHMIGOPF BLMOODAHPDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public static class EJDKJKGFEND
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x9B9090", Offset = "0x9B8290", VA = "0x1809B9090")]
	public static CBCEEBNMKHL NMOJCNHIBOC(this JPNCDNELCPE PBNDNGFJJCP)
	{
		return default(CBCEEBNMKHL);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			public MIDLCCMFPFK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public MIDLCCMFPFK HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private static MIDLCCMFPFK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private Dictionary<MIDLCCMFPFK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x20E87D0", Offset = "0x20E79D0", VA = "0x1820E87D0")]
		public bool INALEOMHPMH(MIDLCCMFPFK DAOEENJHLJD, out ResultConfig PAFAFHKFCBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x20E86E0", Offset = "0x20E78E0", VA = "0x1820E86E0")]
		public ResultConfig EOIACMPJCDA(MIDLCCMFPFK GMKBLCEOJEB, [Optional] HashSet<MIDLCCMFPFK> CJDNFLFJCND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x20E8CF0", Offset = "0x20E7EF0", VA = "0x1820E8CF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x20E8840", Offset = "0x20E7A40", VA = "0x1820E8840", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5230", Offset = "0x6A4430", VA = "0x1806A5230")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200016C")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8CD880", Offset = "0x8CCA80", VA = "0x1808CD880")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x8CD550", Offset = "0x8CC750", VA = "0x1808CD550")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
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
