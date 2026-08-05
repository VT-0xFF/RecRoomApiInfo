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
public class GGHMBBGACDN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD136F0", Offset = "0xD11EF0", VA = "0x180D136F0")]
	public GGHMBBGACDN(string MEKFJFMIPGK, Exception GMIHELLOACL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface KFEFBLHCGKO : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ECCCPKLNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task CAMLHJBBKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGCBFBMNEKL(Task ACDNGKCJBDE, string EDFFBPIKLDI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface MBLEJJLLIOP : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BODOEIOLLNF> GHCNBANBMJN(AIJOAHOCHFA EPGJDCEENKE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EBBAKIHNAEA(CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface EFBHJOECGCD : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DJBLMANHFBO JMAFOPJNLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NINDDGLJGCB();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCHHFKPLJLL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BBCMHMIDCKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface NACEFDIHHFF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TimeSpan NJCHEIJGAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan KCIANDLOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan EDLJFCEBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan NEEENOGLBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EJBHBPFKIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KLHFJIFPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FMMFHLNCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KIFOJDHLMNK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FFNIJHBKDOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long DHPFJDEEBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long ALMHGEFOKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KIFOJDHLMNK BKDBLJPNPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception EJOKOKACHMB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xD10A50", Offset = "0xD0F250", VA = "0x180D10A50")]
	public FFNIJHBKDOK(long DHPFJDEEBED, long ALMHGEFOKBO, KIFOJDHLMNK BKDBLJPNPPJ, [CanBeNull] Exception EJOKOKACHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xD10A00", Offset = "0xD0F200", VA = "0x180D10A00")]
	public static FFNIJHBKDOK ACNIJINECFL(ECKOOCHDGPJ IMBKEKDGMBD, KIFOJDHLMNK BKDBLJPNPPJ, [Optional] Exception EJOKOKACHMB)
	{
		return default(FFNIJHBKDOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void GLMKDHGLDGJ(FFNIJHBKDOK FBCLJBENIBM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal interface DBMLFBPCMDG : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PHEODFNJOHM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GLMKDHGLDGJ FHMACBPEGLE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GLMKDHGLDGJ KAHACACBGLB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GLMKDHGLDGJ BBGMNPAOFFG;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FCCEBBHCAAJ();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NBGNGBDHGFG(FFNIJHBKDOK FBCLJBENIBM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GOEILHEBJOH(FFNIJHBKDOK FBCLJBENIBM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void INGLOKLECJB(FFNIJHBKDOK FBCLJBENIBM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface DKAENNGCLLB : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EFJPDBPIKAJ();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPDEDLGPNLA();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJLPMHDDAHC();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate Task HONPGICEIGE(INGIBJGEAFA MLOBKEMPEJN, CancellationToken HMOHICKINOJ);
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal interface KNKICNGDDJA : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DNHBNNFPFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LJKCNKDACNJ(HONPGICEIGE KOOKNJFEKBC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface CCDKBBLIPAD : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	TaskStatus KHKDJDHEBON
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EDPNPKMAHGP(ECKOOCHDGPJ IEECNFLAKJO, CancellationToken LAOFPANACHA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class HIBHANFPACH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xD153D0", Offset = "0xD13BD0", VA = "0x180D153D0")]
	public static bool NOBFJCPFFEP(this CCDKBBLIPAD JFHFPFFKPNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface JJPABGBHIHE : IJPKIGDAADF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CancellationToken FKGFAIFKCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IDLHNLLMOOO NGFOBAKDFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DEGFMGDGNMF KAIODKBOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IPIPOKJHMDH OHLPMMKPLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BBGMFNGBFGM COLLKCMFALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NALPMPNFLCO FFLJPOCJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DDHLPGNNHOP NKINBLMJMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HIBACKCEBKD NHPKEMIAGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KFEFBLHCGKO BBJPDFMGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MBLEJJLLIOP ABJKLCMOGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DBMLFBPCMDG CIKMDJFINGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DKAENNGCLLB BDOCLEEKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CCDKBBLIPAD BDJGBMKEBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KNKICNGDDJA EANBMMFOJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IAEBJHAKNJP CPGGKOOMJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JLAGMOELFHM KDCDKIPFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IEBNCPHJGMB PMDKBBNPIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JMAIGBPBIDB KAKEIHBAJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	GEJEPBIHACI KDANIMOAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KCFEBLBCKNI KNLNOPKBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LLIKACPEDEN AFMINKHDILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HAAKELIBGMM OMDBEGNPADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	NFFKCCHABON NMJEFCAPDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LEBGDGGBFOJ PMOIEEOJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HFGHCNEEHCO JBLPLLNIDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	EFBHJOECGCD CPGPEOOPDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NACEFDIHHFF DMDMDFLJFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LDBOILHHNBA DAABDJNMJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface IAEBJHAKNJP : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLEIPPGNEIP NLKJJINIDJF(Guid CMBACDFLKJB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHIAFFMKOAF(Guid CMBACDFLKJB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GCOJMMBHAFI(Guid CMBACDFLKJB, Task CEJILLDLOHP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NKGFBGIFFIG(Guid CMBACDFLKJB, BODOEIOLLNF BNIJFEAENPI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PJLPMHDDAHC(Guid CMBACDFLKJB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(BODOEIOLLNF, Task)> NKFPAAAFMOG(Guid CMBACDFLKJB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal interface JLAGMOELFHM : BBCMHMIDCKL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface IEBNCPHJGMB : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNCPKKKEDKA(FLDLNHLOABD MEKFJFMIPGK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJDBKBEHGKB(FLDLNHLOABD MEKFJFMIPGK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IONPKFBCCEM> JDHJNCOHIDA(CancellationToken OIHCHGLNFGB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate BODOEIOLLNF KINGFDKIBEN(PAEDDAMNHLM OIIALCBDFKK, IONPKFBCCEM FOANOEBINNJ);
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface JMAIGBPBIDB : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLEIPPGNEIP OKLJCANDPJI(KIENNHPIEGO OBFMCBDKCNA);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOPPENHFDBN(Guid CMBACDFLKJB, Task CEJILLDLOHP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface GEJEPBIHACI : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BODOEIOLLNF> KDANIMOAPKD(PAEDDAMNHLM LGGPAKMMAEI, IONPKFBCCEM LPDFKDIACDP, [Optional] EMNJGNCCDDA JPPLPDNIJIB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface KCFEBLBCKNI : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ELHGJICLIED> LMPFPIEBGCF(GBCJCBAKIDH LEEHDEOADOO, ECKOOCHDGPJ IEECNFLAKJO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELHGJICLIED BFAMLHCLKAJ(ECKOOCHDGPJ IEECNFLAKJO, EMNJGNCCDDA FECOGEBKDJA, long CIPNHNCCGBL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ELHGJICLIED EIHNIPCFICA(ECKOOCHDGPJ IEECNFLAKJO, MHCAIACOCEC NOGFEHEPEIA, long CIPNHNCCGBL);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ELHGJICLIED CLEGEHHICIA(long DHPFJDEEBED, long CIPNHNCCGBL, string LCMKCBJJJGI, string FONEAOCGOKH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface HAAKELIBGMM : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BODOEIOLLNF LFBPHAAGBLN(PAEDDAMNHLM OIIALCBDFKK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GIDPPPFPIMI(string BGKDPPEDMBJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface LLIKACPEDEN : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FLDLNHLOABD> JDLLKEDFHEP(FLDLNHLOABD GMJOOGMAMPH, ICLKJDCDBDB IGAFIMBDEEE, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FLDLNHLOABD> LMLDDBOFCPL(CancellationToken NFKHAKHIBIO, ICLKJDCDBDB IGAFIMBDEEE);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONHGGFHNMLK GNMILGNPNOP(OGENKHEHHGB PAFEHNAPJBB, GBCJCBAKIDH LEEHDEOADOO);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONHGGFHNMLK LMGOFKNIFIE(OGENKHEHHGB PAFEHNAPJBB, GBCJCBAKIDH LEEHDEOADOO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface NFFKCCHABON : BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BODOEIOLLNF BKGALKOAGMJ(PAEDDAMNHLM OIIALCBDFKK, IONPKFBCCEM FOANOEBINNJ);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BODOEIOLLNF ODFMMGIOHMK(PAEDDAMNHLM APEHHNOOPME);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BODOEIOLLNF BPCGKIJEGAM(PAEDDAMNHLM APEHHNOOPME);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LEBGDGGBFOJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCGLOKJFDJO(KJOFGGPGGFG JOFAPCIDOAN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLGGDLKLNGC(KJOFGGPGGFG JOFAPCIDOAN);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OECPPHHDHPI(KJOFGGPGGFG JOFAPCIDOAN);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFEKEHFFKDJ(KJOFGGPGGFG JOFAPCIDOAN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KJOFGGPGGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly ECKOOCHDGPJ OCIHJCHEFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> BNLBKGKPBJA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public global::FEGLKKODBFL<string> KCLMOJCNDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
	public KJOFGGPGGFG(ECKOOCHDGPJ ONDCGHDIAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD1CE90", Offset = "0xD1B690", VA = "0x180D1CE90")]
	public KJOFGGPGGFG EGPHDMOBLAD(string BAGMDNPKAJL, string CJMMBFLIBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD1CE10", Offset = "0xD1B610", VA = "0x180D1CE10")]
	public bool ECGEFBOOMCC(out IEnumerable<KeyValuePair<string, string>> NPAEDEJKKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xD1CF50", Offset = "0xD1B750", VA = "0x180D1CF50")]
	public KJOFGGPGGFG EHPBDPCHPMF(global::FEGLKKODBFL<string> MGJEIEDBIEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LDBOILHHNBA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JAHOELKEMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string JMIFPKNOOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNAKDKLFOME();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJHBJEKPCOG GEHFGIFKPAH(long EEAAHGCDCPH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::OMHCLBBNMFF<JJEDHNFHCKD, BIFGNLLOLID> LHHOJOEPDEG(long EEAAHGCDCPH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OMHCLBBNMFF<JJEDHNFHCKD, NEJKIEIFAPA> NKMIENGIJDA(long EEAAHGCDCPH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::OMHCLBBNMFF<long, MDFLADPGILH> POMOJNKLGAK();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EGBEENEMAJD(long EEAAHGCDCPH, out string FONEAOCGOKH, out string LCMKCBJJJGI, out JJEDHNFHCKD PPADDBAMGCD, out JJEDHNFHCKD CBMNJJNFDHN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFPCEKLMBDC(ELHGJICLIED GMJOOGMAMPH, long EEAAHGCDCPH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> MDDFOABAAFB(long EEAAHGCDCPH, byte[] PPADDBAMGCD, byte[] CBMNJJNFDHN, CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IJPKIGDAADF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool NOBFJCPFFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool IJJBHHCBDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action PHEODFNJOHM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GLMKDHGLDGJ FHMACBPEGLE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event GLMKDHGLDGJ KAHACACBGLB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GLMKDHGLDGJ BBGMNPAOFFG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CPDEDLGPNLA();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<BODOEIOLLNF> NFLCGOLOBAO([Optional][CanBeNull] EMNJGNCCDDA LHIDLFKFNNH);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BODOEIOLLNF> EFNJEJMCDDE(PAEDDAMNHLM PIEHFMEBFDO);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<BODOEIOLLNF> JEGKKDPNDEF(int DACPNJCKBEI);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task GIDPPPFPIMI(string BGKDPPEDMBJ);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<BODOEIOLLNF> GHCNBANBMJN(AIJOAHOCHFA EPGJDCEENKE = AIJOAHOCHFA.Incremental);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task EBBAKIHNAEA(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JJEFINIANGI(long CIPNHNCCGBL);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FJEOOJGDDEM(long CIPNHNCCGBL, out DateTime PFJMOHOCPNP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BBGMFNGBFGM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string INNNJKBAFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECBDKKJLOAK(Scene FAKBBNJGNIJ);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HPFLFLMBHLC(KOKGFIKFHDA LLMNEANFGDH, CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AGIPDIHMLDH
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int BJKDJICMJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PAGJFDFFCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool COOGEKCHHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool JFGBMOMKACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool BGMLPKIHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool GJLHIFOEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PAEDDAMNHLM PJOHIICJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDLHNLLMOOO EMKHFENIPFD(IDLHNLLMOOO JIKLLMLIOBE);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIPFGJMBAFG(IDLHNLLMOOO IGEIPKGINDO);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DMEKKLOGALM(GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JKIENHOECGK(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task EOADBFJNKIN(BGGFKIPBNHO DCONKHDOODL, [Optional] CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KIJMCJEDOJF(float FGDGAGBGCFJ);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PJJKJOJAGLH(string GEMEDDNALGH);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<MPJMKPKCFKA> EFOGPKIOJNA();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable NLBIPHDAGIG(object ALLCABKLNNG, MPJMKPKCFKA BLPEGFBBEJK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BIFGNLLOLID JAJHJCOKLKM();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IBDILCKFAIF(int CJLJDDIIJIM);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task DBKGEAFHMDC();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GFCOHKIDKHJ();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool NDHOFGKEACC();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LPJPNKHINBB(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task KMMGPEOEHLH(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> FMKENPLIJHL(DateTime CAKFLJPBAPH, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> GMHBLILGKIN(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PGPOACKDKGJ();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HFAIECHMHDF COAEBMEJHKH(LHOKELIACJN PNCPGHDFEJM, NEJKIEIFAPA EFBKEKKINGG, IEnumerable<PersistenceView> OKCCLIMPMPO, ref NNHNABGBPAO KLOJGKNHGCC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OABMMJIHEGO(AHPAJNJOLEG JJHENKMJPFB, in HFAIECHMHDF DEOJEDAGPED);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HDGDJCKFEBJ(NEJKIEIFAPA FKPNHDDKAKH, bool DEBOGAKKGIB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AAAMCLNICAN();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KCFAGMDJMGG(long OGPGAAKNHEG, long ALMHGEFOKBO, EMNJGNCCDDA FAOOOBOGDKB, JMOBGOJPACL ACODGOCBPLH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FLOOINLKPCD(long OGPGAAKNHEG, long ALMHGEFOKBO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void COMAKBGDDNM(PersistenceView ADMMIOFFJMD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool HMIGPNIDLEL(PersistenceView FMAOAOODAPP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool ENOAHKLGBME(AHPAJNJOLEG JJHENKMJPFB, ODMAECGJINE HEGONELKOOO, Dictionary<int, int> JHIJMCPEABF, out LMLIDGAMPBL GMNCDOHEGMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CJOJHGCFMBJ();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BPEMFNKCDEJ();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable KOMEJFBAJHD();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Dictionary<int, int> FFPMJINGOPK(NEJKIEIFAPA FKPNHDDKAKH, ODMAECGJINE HEGONELKOOO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> JCJFPHMMNDD(DEGFMGDGNMF GFGNDDMLFJA, CancellationToken NFKHAKHIBIO, GBCJCBAKIDH LEEHDEOADOO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void DFNPCOBKODP(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<EMNJGNCCDDA> KFHGEBCEGAP(long OGPGAAKNHEG, long ALMHGEFOKBO, string LCMKCBJJJGI, string GEBGNALEDBE, string KELAJACFBEP, Dictionary<long, int> LPJHOBGFHBH, int KIFKOCHNABH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<MHCAIACOCEC> FHOPOLILJGM(string FONEAOCGOKH, long OGPGAAKNHEG, long ALMHGEFOKBO, string LCMKCBJJJGI, OKCKDGMKKMD.PBCOMLEPBND GEBGNALEDBE, OKCKDGMKKMD.PBCOMLEPBND KELAJACFBEP, int KIFKOCHNABH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EMNJGNCCDDA> IOEGMNLCINK(long OGPGAAKNHEG, bool ECKOEHLGBPG, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IFMLMPMADEM();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HFGAFMNBMEB();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	GameObject[] HOLOEOCPPIP(KCJFEENMBCC[] HOKEMKNACIK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void INMBOLLKDIE(List<GameObject> FBEJNGJCKGE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float BCPOHCDHGLN();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> AOILPPNHAAD(string ILCPHDDOLOP, LoadSceneMode FLOPPFNGFON, bool LIBCDHOBLOC, GBCJCBAKIDH MGJEIEDBIEE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JFJCDDLOPNE(ECKOOCHDGPJ PIFNAAGJGDI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void DLMDMFGMPJF(string LPDFKDIACDP, PAEDDAMNHLM LGGPAKMMAEI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task HDACFOEFGOL(GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task NFCGOEOOIEP(GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void BBOEKCBLGAC();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "56")]
	IDisposable KLALCMDMPKB();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "57")]
	KIAFCFFEFIG IAGBGJDCCLD();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KIAFCFFEFIG
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NEHLCPKDJIA(CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FLGBPGMGHJP(CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HFAIECHMHDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> JDKOMPILEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public IDisposable OJEICJCNMNN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xD14A90", Offset = "0xD13290", VA = "0x180D14A90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IHMOADMGNIB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ECKOOCHDGPJ AJNKGKOFBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EMNJGNCCDDA OLGPNPMEMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EPGHEIOKHIJ IPCICOCAGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EKGJCGLJBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool EAAOEDMDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int BJKDJICMJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action HHLICIMMMHG;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<int> JJFNBFNJENB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EAFLMFMIHIE();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.ALONANOJPOJ> KJAACFHGJFI();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DPHNNPKAPLN();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ECKOOCHDGPJ DFFGBPBEHCP();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DEKPEAIDOOF MIEMMMNFDNM();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HDLPGBGJCKK(long EEAAHGCDCPH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HFGHCNEEHCO
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFGIKBIKJHI(out IEnumerable<int> PKPEMLIJGHE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDFLPLNFMJ(MBHEGBJDEAH HMOHICKINOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAMLLIJLGLD(MBHEGBJDEAH HMOHICKINOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KDDMMGGKAHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BEOHHDMCCIL(BODOEIOLLNF BGIHEEBLBFA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface APKDJFGLNPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBDHCACOJJA(IBCJMHIDFOK.JFCICLOIOCC OIOLFNNCNPD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIAAIADGEJG(IBCJMHIDFOK.JFCICLOIOCC OIOLFNNCNPD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NALPMPNFLCO : APKDJFGLNPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BODOEIOLLNF FGNAPDIKGNB(PAEDDAMNHLM APEHHNOOPME);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DDHLPGNNHOP : APKDJFGLNPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BODOEIOLLNF LFBPHAAGBLN(PAEDDAMNHLM FLAAPIGBEEK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BJHBJEKPCOG
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::BLBLJBFHAIG<KOKGFIKFHDA, KCPABLLBBLD>> IOFEIGHIOEF(string LCMKCBJJJGI, long EEAAHGCDCPH, OELINPHFKJM.AHNLAKJHOGK PMAFMFMHMIH, CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OMHCLBBNMFF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::BLBLJBFHAIG<byte[], KCPABLLBBLD>> ECHJOIGHDBO(TGetDataArg OGMKAFPDGJD, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BLBLJBFHAIG<global::GLLICLACNJF<TData>, KCPABLLBBLD> KBAIIDLABBK(byte[] DMDONNOOOJK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class ABHBLCBOELN : JJPABGBHIHE, IJPKIGDAADF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct EELJFGONNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<BODOEIOLLNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ABHBLCBOELN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AIJOAHOCHFA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<BODOEIOLLNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xCFE580", Offset = "0xCFCD80", VA = "0x180CFE580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xCFE830", Offset = "0xCFD030", VA = "0x180CFE830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LHFHDHEPPJF : IEnumerable<BBCMHMIDCKL>, IEnumerable, IEnumerator<BBCMHMIDCKL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BBCMHMIDCKL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public ABHBLCBOELN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private BBCMHMIDCKL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public LHFHDHEPPJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xD02A70", Offset = "0xD01270", VA = "0x180D02A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xD02EB0", Offset = "0xD016B0", VA = "0x180D02EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xD02E10", Offset = "0xD01610", VA = "0x180D02E10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BBCMHMIDCKL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xD02E10", Offset = "0xD01610", VA = "0x180D02E10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationTokenSource OBDHKEDJIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IDLHNLLMOOO IGEIPKGINDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OEPOOHHLFLH IPAPFLDNNMG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DEGFMGDGNMF KAIODKBOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x638B60", Offset = "0x637360", VA = "0x180638B60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x638B80", Offset = "0x637380", VA = "0x180638B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IPIPOKJHMDH OHLPMMKPLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x622180", Offset = "0x620980", VA = "0x180622180", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B3BA0", Offset = "0x6B23A0", VA = "0x1806B3BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68E670", Offset = "0x68CE70", VA = "0x18068E670", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69A480", Offset = "0x698C80", VA = "0x18069A480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BBGMFNGBFGM COLLKCMFALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61B9C0", Offset = "0x61A1C0", VA = "0x18061B9C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x628460", Offset = "0x626C60", VA = "0x180628460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NALPMPNFLCO FFLJPOCJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61B9D0", Offset = "0x61A1D0", VA = "0x18061B9D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D4F00", Offset = "0x6D3700", VA = "0x1806D4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DDHLPGNNHOP NKINBLMJMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68E690", Offset = "0x68CE90", VA = "0x18068E690", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D5680", Offset = "0x6D3E80", VA = "0x1806D5680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public HIBACKCEBKD NHPKEMIAGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68E640", Offset = "0x68CE40", VA = "0x18068E640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x68F510", Offset = "0x68DD10", VA = "0x18068F510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public KFEFBLHCGKO BBJPDFMGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x627660", Offset = "0x625E60", VA = "0x180627660", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x625C90", Offset = "0x624490", VA = "0x180625C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public MBLEJJLLIOP ABJKLCMOGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68E5F0", Offset = "0x68CDF0", VA = "0x18068E5F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69B450", Offset = "0x699C50", VA = "0x18069B450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DBMLFBPCMDG CIKMDJFINGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x606E20", Offset = "0x605620", VA = "0x180606E20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x606E00", Offset = "0x605600", VA = "0x180606E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public DKAENNGCLLB BDOCLEEKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x608630", Offset = "0x606E30", VA = "0x180608630", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6089C0", Offset = "0x6071C0", VA = "0x1806089C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CCDKBBLIPAD BDJGBMKEBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x68E5A0", Offset = "0x68CDA0", VA = "0x18068E5A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D30", Offset = "0x6D8530", VA = "0x1806D9D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KNKICNGDDJA EANBMMFOJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68E5E0", Offset = "0x68CDE0", VA = "0x18068E5E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x871AD0", Offset = "0x8702D0", VA = "0x180871AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public IAEBJHAKNJP CPGGKOOMJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x637C60", Offset = "0x636460", VA = "0x180637C60", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x637D40", Offset = "0x636540", VA = "0x180637D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public JLAGMOELFHM KDCDKIPFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66CFD0", Offset = "0x66B7D0", VA = "0x18066CFD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x67D180", Offset = "0x67B980", VA = "0x18067D180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public IEBNCPHJGMB PMDKBBNPIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68E540", Offset = "0x68CD40", VA = "0x18068E540", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AF0", Offset = "0x6D82F0", VA = "0x1806D9AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public JMAIGBPBIDB KAKEIHBAJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68E530", Offset = "0x68CD30", VA = "0x18068E530", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C40", Offset = "0x6D8440", VA = "0x1806D9C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public GEJEPBIHACI KDANIMOAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6224D0", Offset = "0x620CD0", VA = "0x1806224D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x622220", Offset = "0x620A20", VA = "0x180622220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public KCFEBLBCKNI KNLNOPKBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x677CE0", Offset = "0x6764E0", VA = "0x180677CE0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x677190", Offset = "0x675990", VA = "0x180677190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public LLIKACPEDEN AFMINKHDILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68E4E0", Offset = "0x68CCE0", VA = "0x18068E4E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6E6C70", Offset = "0x6E5470", VA = "0x1806E6C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public HAAKELIBGMM OMDBEGNPADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x66CFC0", Offset = "0x66B7C0", VA = "0x18066CFC0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x73AA50", Offset = "0x739250", VA = "0x18073AA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public NFFKCCHABON NMJEFCAPDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68E4D0", Offset = "0x68CCD0", VA = "0x18068E4D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7D02F0", Offset = "0x7CEAF0", VA = "0x1807D02F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LEBGDGGBFOJ PMOIEEOJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x68E420", Offset = "0x68CC20", VA = "0x18068E420", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B10", Offset = "0x6D8310", VA = "0x1806D9B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public HFGHCNEEHCO JBLPLLNIDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68E630", Offset = "0x68CE30", VA = "0x18068E630", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AE0", Offset = "0x6D82E0", VA = "0x1806D9AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EFBHJOECGCD CPGPEOOPDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x65D940", Offset = "0x65C140", VA = "0x18065D940", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x65DC70", Offset = "0x65C470", VA = "0x18065DC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NACEFDIHHFF DMDMDFLJFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x65D980", Offset = "0x65C180", VA = "0x18065D980", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x65DC80", Offset = "0x65C480", VA = "0x18065DC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public LDBOILHHNBA DAABDJNMJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x65D9C0", Offset = "0x65C1C0", VA = "0x18065D9C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x65DC90", Offset = "0x65C490", VA = "0x18065DC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private bool GGGENLIJILP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xCF4200", Offset = "0xCF2A00", VA = "0x180CF4200", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool IDKKEMAAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xCF4AD0", Offset = "0xCF32D0", VA = "0x180CF4AD0", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private CancellationToken IICHDACNEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xCF4AB0", Offset = "0xCF32B0", VA = "0x180CF4AB0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private IDLHNLLMOOO EFOBBDEHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event Action PFAHDEHDBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xCF4230", Offset = "0xCF2A30", VA = "0x180CF4230", Slot = "33")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xCF4450", Offset = "0xCF2C50", VA = "0x180CF4450", Slot = "34")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	private event GLMKDHGLDGJ MDEOGJEEDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCF4B40", Offset = "0xCF3340", VA = "0x180CF4B40", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xCF46A0", Offset = "0xCF2EA0", VA = "0x180CF46A0", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event GLMKDHGLDGJ OFIKHDHMJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xCF4290", Offset = "0xCF2A90", VA = "0x180CF4290", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xCF3FB0", Offset = "0xCF27B0", VA = "0x180CF3FB0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event GLMKDHGLDGJ KBKOHBAFDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4840", Offset = "0xCF3040", VA = "0x180CF4840", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4750", Offset = "0xCF2F50", VA = "0x180CF4750", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xCF4BB0", Offset = "0xCF33B0", VA = "0x180CF4BB0")]
	[Preserve]
	internal ABHBLCBOELN([EDDGBBNJGJM(null)] IDLHNLLMOOO IGEIPKGINDO, [EDDGBBNJGJM(null)] DEGFMGDGNMF GFGNDDMLFJA, [EDDGBBNJGJM(null)] IPIPOKJHMDH LJODJJMHKGD, [EDDGBBNJGJM(null)] AGIPDIHMLDH AGONKCODOEL, [EDDGBBNJGJM(null)] BBGMFNGBFGM ADEEDKFBIHH, [EDDGBBNJGJM(null)] NALPMPNFLCO FIIADNMGNNA, [EDDGBBNJGJM(null)] DDHLPGNNHOP DNPPDENABMF, [EDDGBBNJGJM(null)] HIBACKCEBKD INJCHFHHOBG, [EDDGBBNJGJM(null)] KFEFBLHCGKO LCJGFKHPBHE, [EDDGBBNJGJM(null)] MBLEJJLLIOP EMADKILDHMK, [EDDGBBNJGJM(null)] DBMLFBPCMDG HKICLIFPELN, [EDDGBBNJGJM(null)] DKAENNGCLLB JKNLEHCGOBH, [EDDGBBNJGJM(null)] CCDKBBLIPAD JFHFPFFKPNG, [EDDGBBNJGJM(null)] KNKICNGDDJA LIGCLNCJDHE, [EDDGBBNJGJM(null)] IAEBJHAKNJP LNOGNAOFMKJ, [EDDGBBNJGJM(null)] JLAGMOELFHM BIOBNPBPFDH, [EDDGBBNJGJM(null)] IEBNCPHJGMB KANHMCIOJBG, [EDDGBBNJGJM(null)] JMAIGBPBIDB DIKKBLPMCPC, [EDDGBBNJGJM(null)] GEJEPBIHACI LBCIGFEBGMB, [EDDGBBNJGJM(null)] KCFEBLBCKNI NNLFGMLLEHC, [EDDGBBNJGJM(null)] HAAKELIBGMM HFMKGJBLIBH, [EDDGBBNJGJM(null)] LLIKACPEDEN GIOGNGLFHEL, [EDDGBBNJGJM(null)] NFFKCCHABON ADMDEPNJPGA, [EDDGBBNJGJM(null)] LEBGDGGBFOJ NHOMEHMLOKJ, [EDDGBBNJGJM(null)] HFGHCNEEHCO AJHPOEOKJEF, [EDDGBBNJGJM(null)] NACEFDIHHFF BNFFLBNLMCC, [EDDGBBNJGJM(null)] LDBOILHHNBA IHNDLCBGGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xCF49E0", Offset = "0xCF31E0", VA = "0x180CF49E0")]
	private void LGHMODLDJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xCF42F0", Offset = "0xCF2AF0", VA = "0x180CF42F0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xCF4700", Offset = "0xCF2F00", VA = "0x180CF4700", Slot = "43")]
	private void IOAKBFCHBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0xCF4570", Offset = "0xCF2D70", VA = "0x180CF4570", Slot = "49")]
	private Task HNPHMCBDDLC(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xCF4BA0", Offset = "0xCF33A0", VA = "0x180CF4BA0", Slot = "50")]
	private void PJJBJLLNPJK(long CIPNHNCCGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xCF4210", Offset = "0xCF2A10", VA = "0x180CF4210", Slot = "51")]
	private bool CJIODELBHOJ(long ALMHGEFOKBO, out DateTime FGCFFHNKLNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xCF44B0", Offset = "0xCF2CB0", VA = "0x180CF44B0", Slot = "47")]
	private Task GOONCDKAJAD(string BGKDPPEDMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xCF47B0", Offset = "0xCF2FB0", VA = "0x180CF47B0", Slot = "44")]
	private Task<BODOEIOLLNF> KDALKOPKNKE(EMNJGNCCDDA LHIDLFKFNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xCF4010", Offset = "0xCF2810", VA = "0x180CF4010", Slot = "45")]
	private Task<BODOEIOLLNF> AFBMPCNHMAH(PAEDDAMNHLM PIEHFMEBFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xCF48A0", Offset = "0xCF30A0", VA = "0x180CF48A0", Slot = "46")]
	private Task<BODOEIOLLNF> LEHAIBPJGDO(int DACPNJCKBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xCF40E0", Offset = "0xCF28E0", VA = "0x180CF40E0", Slot = "48")]
	[AsyncStateMachine(typeof(EELJFGONNAF))]
	private Task<BODOEIOLLNF> BIPGCELABNG(AIJOAHOCHFA EPGJDCEENKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xCF4630", Offset = "0xCF2E30", VA = "0x180CF4630")]
	[IteratorStateMachine(typeof(LHFHDHEPPJF))]
	private IEnumerable<BBCMHMIDCKL> HNPKNBABKHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xCF4080", Offset = "0xCF2880", VA = "0x180CF4080")]
	[CompilerGenerated]
	private void AMJFJCODBGB(BBCMHMIDCKL CFCFGDKOLFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class IGHLAILPFLI : MHFKABNLHGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct ELAHOHLAHME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IGHLAILPFLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xD0E890", Offset = "0xD0D090", VA = "0x180D0E890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xD0EB60", Offset = "0xD0D360", VA = "0x180D0EB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF0", Offset = "0x6FD2F0", VA = "0x1806FEAF0")]
	public IGHLAILPFLI(JJPABGBHIHE MIHALFJEPMA, AGIPDIHMLDH AGONKCODOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xD17E70", Offset = "0xD16670", VA = "0x180D17E70", Slot = "4")]
	[AsyncStateMachine(typeof(ELAHOHLAHME))]
	public Task<bool> PPNLEGLEENC(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xD17D50", Offset = "0xD16550", VA = "0x180D17D50")]
	[CompilerGenerated]
	private object PNKMABHPDLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal class BIGPKGHLFDH : MHFKABNLHGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EGLHPNLKNNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public BIGPKGHLFDH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xCFE880", Offset = "0xCFD080", VA = "0x180CFE880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xCFEEC0", Offset = "0xCFD6C0", VA = "0x180CFEEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float MPNIKFPJDKE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xCF9AE0", Offset = "0xCF82E0", VA = "0x180CF9AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF0", Offset = "0x6FD2F0", VA = "0x1806FEAF0")]
	public BIGPKGHLFDH(JJPABGBHIHE MIHALFJEPMA, AGIPDIHMLDH AGONKCODOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xCF9BF0", Offset = "0xCF83F0", VA = "0x180CF9BF0", Slot = "4")]
	[AsyncStateMachine(typeof(EGLHPNLKNNF))]
	public Task<bool> PPNLEGLEENC(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xCF9B30", Offset = "0xCF8330", VA = "0x180CF9B30")]
	[CompilerGenerated]
	private object JGDMFAKCPNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class BANKGMMMGJD : MHFKABNLHGB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class AHFKPGAOEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BANKGMMMGJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Matchmaking.ALONANOJPOJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ECKOOCHDGPJ newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public AHFKPGAOEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xCF55F0", Offset = "0xCF3DF0", VA = "0x180CF55F0")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xCF56B0", Offset = "0xCF3EB0", VA = "0x180CF56B0")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCF5710", Offset = "0xCF3F10", VA = "0x180CF5710")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct DNBKFAGACAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BANKGMMMGJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private AHFKPGAOEIP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<Matchmaking.ALONANOJPOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xCFD9A0", Offset = "0xCFC1A0", VA = "0x180CFD9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xCFE1C0", Offset = "0xCFC9C0", VA = "0x180CFE1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float MPNIKFPJDKE = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xCF6980", Offset = "0xCF5180", VA = "0x180CF6980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF0", Offset = "0x6FD2F0", VA = "0x1806FEAF0")]
	public BANKGMMMGJD(JJPABGBHIHE MIHALFJEPMA, AGIPDIHMLDH AGONKCODOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xCF69D0", Offset = "0xCF51D0", VA = "0x180CF69D0", Slot = "4")]
	[AsyncStateMachine(typeof(DNBKFAGACAG))]
	public Task<bool> PPNLEGLEENC(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal interface MHFKABNLHGB
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PPNLEGLEENC(CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct KLIFJJAIPIB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BNGOKFNKEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JJPABGBHIHE manager;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BNGOKFNKEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xEE94D0", Offset = "0xEE7CD0", VA = "0x180EE94D0")]
		internal Task <CreateTask>b__0(INGIBJGEAFA data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct ABHFFIDJLIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KLIFJJAIPIB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xD09F80", Offset = "0xD08780", VA = "0x180D09F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xD0A270", Offset = "0xD08A70", VA = "0x180D0A270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct GGHPFPBHLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KLIFJJAIPIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xEECF10", Offset = "0xEEB710", VA = "0x180EECF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationToken NFKHAKHIBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JJPABGBHIHE GGIDAKJKFEH;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private DEGFMGDGNMF KAIODKBOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xD1D5C0", Offset = "0xD1BDC0", VA = "0x180D1D5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD1D570", Offset = "0xD1BD70", VA = "0x180D1D570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xD1D030", Offset = "0xD1B830", VA = "0x180D1D030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private MBLEJJLLIOP ABJKLCMOGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xD1CF70", Offset = "0xD1B770", VA = "0x180D1CF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xD1D700", Offset = "0xD1BF00", VA = "0x180D1D700")]
	public KLIFJJAIPIB(CancellationToken NFKHAKHIBIO, JJPABGBHIHE GGIDAKJKFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xD1D3D0", Offset = "0xD1BBD0", VA = "0x180D1D3D0")]
	public static HONPGICEIGE KIHJJAFDGPG(JJPABGBHIHE GGIDAKJKFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xD1D1D0", Offset = "0xD1B9D0", VA = "0x180D1D1D0")]
	[AsyncStateMachine(typeof(ABHFFIDJLIE))]
	public Task<bool> EOHNKNEAELI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xD1D2E0", Offset = "0xD1BAE0", VA = "0x180D1D2E0")]
	private bool JEEIACPNKFP(out FileInfo FDMIPDDJAJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xD1D470", Offset = "0xD1BC70", VA = "0x180D1D470")]
	[AsyncStateMachine(typeof(GGHPFPBHLCK))]
	private Task LEONLKEOAHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xD1D0B0", Offset = "0xD1B8B0", VA = "0x180D1D0B0")]
	private Task<bool> CFPEAGIPNGA(FileInfo FDMIPDDJAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0xD1D610", Offset = "0xD1BE10", VA = "0x180D1D610")]
	private Task NKJDCCEJMFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xD1CFC0", Offset = "0xD1B7C0", VA = "0x180D1CFC0")]
	private void BLFAKEHELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal struct CLEIPPGNEIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IAEBJHAKNJP LNOGNAOFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Guid CMBACDFLKJB;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private Task<(BODOEIOLLNF, Task)> IMLMJLDKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCFBC80", Offset = "0xCFA480", VA = "0x180CFBC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xCFBD50", Offset = "0xCFA550", VA = "0x180CFBD50")]
	public CLEIPPGNEIP(IAEBJHAKNJP LNOGNAOFMKJ, Guid CMBACDFLKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xCFBC30", Offset = "0xCFA430", VA = "0x180CFBC30")]
	public TaskAwaiter<(BODOEIOLLNF, Task)> ILOJMMMBIIJ()
	{
		return default(TaskAwaiter<(BODOEIOLLNF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xCFBB60", Offset = "0xCFA360", VA = "0x180CFBB60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal struct AABJKLLEJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly TaskCompletionSource<(BODOEIOLLNF, Task)> OHFKAHAPMIL;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Task<(BODOEIOLLNF, Task)> IMLMJLDKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xCF3BF0", Offset = "0xCF23F0", VA = "0x180CF3BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xCF3C30", Offset = "0xCF2430", VA = "0x180CF3C30")]
	public AABJKLLEJMP(TimeSpan GDFNPCLFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xCF3AD0", Offset = "0xCF22D0", VA = "0x180CF3AD0")]
	public void HJBAPOJDKOK(Task CEJILLDLOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xCF39C0", Offset = "0xCF21C0", VA = "0x180CF39C0")]
	public void FPFCHBJFLPH(BODOEIOLLNF BGIHEEBLBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0xCF3BA0", Offset = "0xCF23A0", VA = "0x180CF3BA0")]
	public void LABJJJEBDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xCF3A50", Offset = "0xCF2250", VA = "0x180CF3A50")]
	internal void GLHMHKFCPIJ(string MEKFJFMIPGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Preserve]
internal class IOJLEIIMDMF : KFEFBLHCGKO, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FIPPPNHNFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IOJLEIIMDMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xD114F0", Offset = "0xD0FCF0", VA = "0x180D114F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MBHEGBJDEAH PAOJDOEEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string LBPHDIILOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Task IJOGAJLFKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool ECCCPKLNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xD188C0", Offset = "0xD170C0", VA = "0x180D188C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Task CAMLHJBBKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xD18860", Offset = "0xD17060", VA = "0x180D18860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290", Slot = "7")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xD186E0", Offset = "0xD16EE0", VA = "0x180D186E0", Slot = "6")]
	public void EGCBFBMNEKL(Task ACDNGKCJBDE, string EDFFBPIKLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xD185B0", Offset = "0xD16DB0", VA = "0x180D185B0")]
	[AsyncStateMachine(typeof(FIPPPNHNFNK))]
	private Task DDNLDJHLDKI(Task KKKFLGLILLH, string EDFFBPIKLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xD188F0", Offset = "0xD170F0", VA = "0x180D188F0")]
	public IOJLEIIMDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class JBIEDJABELD : EFBHJOECGCD, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool APBFNMNCLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private DJBLMANHFBO BFALMMIALOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NACEFDIHHFF BNFFLBNLMCC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public DJBLMANHFBO JMAFOPJNLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD18E60", Offset = "0xD17660", VA = "0x180D18E60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xD18B80", Offset = "0xD17380", VA = "0x180D18B80", Slot = "7")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xD18CE0", Offset = "0xD174E0", VA = "0x180D18CE0", Slot = "5")]
	public void NINDDGLJGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xD18B40", Offset = "0xD17340", VA = "0x180D18B40", Slot = "6")]
	public void KCHHFKPLJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xD18ED0", Offset = "0xD176D0", VA = "0x180D18ED0")]
	private Task PKDJOMDBJEO(HAKDCNMIKLP IIFJOCIBPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xD18B40", Offset = "0xD17340", VA = "0x180D18B40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public JBIEDJABELD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class BMEJCIAIOGL : NACEFDIHHFF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class BHLEJJIKCEJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly IFEJAIDAKAC BHMHMFFFCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly string BAGMDNPKAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly T KKLAFEAHDFJ;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public T EJFMLMNCFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6358A0", Offset = "0x6340A0", VA = "0x1806358A0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6866D0", Offset = "0x684ED0", VA = "0x1806866D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5562F70", Offset = "0x5561770", VA = "0x185562F70")]
		public BHLEJJIKCEJ(IFEJAIDAKAC BHMHMFFFCAM, string BAGMDNPKAJL, T KKLAFEAHDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5562C30", Offset = "0x5561430", VA = "0x185562C30")]
		private void FHIKNPGFOLF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly BHLEJJIKCEJ<TimeSpan> MJFCFKPEIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly BHLEJJIKCEJ<TimeSpan> OJBBOFOMHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly BHLEJJIKCEJ<TimeSpan> LOJFJHHHGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly BHLEJJIKCEJ<TimeSpan> PLOEPEBDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly BHLEJJIKCEJ<bool> LGOHMLKJLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BHLEJJIKCEJ<bool> JFIFBHEEBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly BHLEJJIKCEJ<bool> MLCHLEHMLOM;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TimeSpan NJCHEIJGAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCF9DA0", Offset = "0xCF85A0", VA = "0x180CF9DA0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public TimeSpan KCIANDLOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xCF9E60", Offset = "0xCF8660", VA = "0x180CF9E60", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public TimeSpan EDLJFCEBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCF9D20", Offset = "0xCF8520", VA = "0x180CF9D20", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TimeSpan NEEENOGLBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xCF9EA0", Offset = "0xCF86A0", VA = "0x180CF9EA0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool EJBHBPFKIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xCF9D60", Offset = "0xCF8560", VA = "0x180CF9D60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KLHFJIFPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xCF9DE0", Offset = "0xCF85E0", VA = "0x180CF9DE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool FMMFHLNCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xCF9E20", Offset = "0xCF8620", VA = "0x180CF9E20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0xCF9EE0", Offset = "0xCF86E0", VA = "0x180CF9EE0")]
	[Preserve]
	public BMEJCIAIOGL([EDDGBBNJGJM(null)] IFEJAIDAKAC BHMHMFFFCAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Preserve]
internal class DCMEENGJLNF : DBMLFBPCMDG, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JLNHPNKODNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FFNIJHBKDOK roomEvent;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public JLNHPNKODNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xD19D10", Offset = "0xD18510", VA = "0x180D19D10")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action PHEODFNJOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCE00", Offset = "0xCFB600", VA = "0x180CFCE00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xCFC720", Offset = "0xCFAF20", VA = "0x180CFC720", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event GLMKDHGLDGJ FHMACBPEGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xCFCEA0", Offset = "0xCFB6A0", VA = "0x180CFCEA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xCFC7C0", Offset = "0xCFAFC0", VA = "0x180CFC7C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event GLMKDHGLDGJ KAHACACBGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAE0", Offset = "0xCFB2E0", VA = "0x180CFCAE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xCFC5E0", Offset = "0xCFADE0", VA = "0x180CFC5E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event GLMKDHGLDGJ BBGMNPAOFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xCFCF40", Offset = "0xCFB740", VA = "0x180CFCF40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xCFC680", Offset = "0xCFAE80", VA = "0x180CFC680", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "16")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xCFC860", Offset = "0xCFB060", VA = "0x180CFC860", Slot = "12")]
	public void FCCEBBHCAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xCFCFE0", Offset = "0xCFB7E0", VA = "0x180CFCFE0", Slot = "13")]
	public void NBGNGBDHGFG(FFNIJHBKDOK FBCLJBENIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xCFCAB0", Offset = "0xCFB2B0", VA = "0x180CFCAB0", Slot = "14")]
	public void GOEILHEBJOH(FFNIJHBKDOK FBCLJBENIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xCFCDD0", Offset = "0xCFB5D0", VA = "0x180CFCDD0", Slot = "15")]
	public void INGLOKLECJB(FFNIJHBKDOK FBCLJBENIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xCFCB80", Offset = "0xCFB380", VA = "0x180CFCB80")]
	private void HJEIFCIIAIC(GLMKDHGLDGJ BLPEGFBBEJK, FFNIJHBKDOK FBCLJBENIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public DCMEENGJLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Preserve]
internal class NLKBCBKANMN : DKAENNGCLLB, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct COBHPAAEPCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public NLKBCBKANMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xEEB6A0", Offset = "0xEE9EA0", VA = "0x180EEB6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct FKEOOJBOGMA : IAsyncStateMachine
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
		public NLKBCBKANMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xEEC9C0", Offset = "0xEEB1C0", VA = "0x180EEC9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class IPHHKOCJEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IPHHKOCJEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xEEEFE0", Offset = "0xEED7E0", VA = "0x180EEEFE0")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct HDFLFDIKOMF : IAsyncStateMachine
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
		public NLKBCBKANMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IPHHKOCJEPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xEEE0C0", Offset = "0xEEC8C0", VA = "0x180EEE0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xEEE780", Offset = "0xEECF80", VA = "0x180EEE780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class DCFPFLPCEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DCFPFLPCEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xEEBB20", Offset = "0xEEA320", VA = "0x180EEBB20")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private MHFKABNLHGB[] DKOCNPJNKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CancellationTokenSource GKPFEEDCFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private int HCBNABJGNLJ;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0xEFC1D0", Offset = "0xEFA9D0", VA = "0x180EFC1D0", Slot = "7")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xEFBA20", Offset = "0xEFA220", VA = "0x180EFBA20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xEFC5C0", Offset = "0xEFADC0", VA = "0x180EFC5C0", Slot = "6")]
	public void PJLPMHDDAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xEFB8D0", Offset = "0xEFA0D0", VA = "0x180EFB8D0", Slot = "5")]
	public void CPDEDLGPNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xEFBB20", Offset = "0xEFA320", VA = "0x180EFBB20", Slot = "4")]
	[AsyncStateMachine(typeof(COBHPAAEPCE))]
	public Task EFJPDBPIKAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0xEFBEC0", Offset = "0xEFA6C0", VA = "0x180EFBEC0")]
	private void KIBCLECLHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xEFC4A0", Offset = "0xEFACA0", VA = "0x180EFC4A0")]
	[AsyncStateMachine(typeof(FKEOOJBOGMA))]
	private Task NJEPHICJLGH(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xEFC250", Offset = "0xEFAA50", VA = "0x180EFC250")]
	[AsyncStateMachine(typeof(HDFLFDIKOMF))]
	private Task<bool> LJCKLEGOOGE(int AKLHCIJHJKB, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xEFC380", Offset = "0xEFAB80", VA = "0x180EFC380")]
	private void LLPDDLKMGJM(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xEFBDC0", Offset = "0xEFA5C0", VA = "0x180EFBDC0")]
	private void HODAKNCLKIF(int AKLHCIJHJKB, bool HGJKFKODICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xEFBC30", Offset = "0xEFA430", VA = "0x180EFBC30")]
	private void GFKKPLJEAAN(int AKLHCIJHJKB, Exception BMHFAHACLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0xEFBA30", Offset = "0xEFA230", VA = "0x180EFBA30")]
	private void EFGPHOFBKPC(CancellationToken NFKHAKHIBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public NLKBCBKANMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Preserve]
internal class HOIOFPCDCEK : KNKICNGDDJA, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AIKHOAJPJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public HOIOFPCDCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public INGIBJGEAFA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD0A310", Offset = "0xD08B10", VA = "0x180D0A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ALIECLPBKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public HOIOFPCDCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public INGIBJGEAFA roomData;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ALIECLPBKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xD0A790", Offset = "0xD08F90", VA = "0x180D0A790")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct FLGFBJBGDDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public HONPGICEIGE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xD11A60", Offset = "0xD10260", VA = "0x180D11A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct FEEJMCBHHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HOIOFPCDCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xD107C0", Offset = "0xD0EFC0", VA = "0x180D107C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HashSet<HONPGICEIGE> PKINABKFPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private IPIPOKJHMDH LJODJJMHKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private MPJMKPKCFKA NGGDOEJHEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private PNMNNPEMEJC DJNPBDGJDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private IDisposable IMKBHDMABPF;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool DNHBNNFPFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xD16D30", Offset = "0xD15530", VA = "0x180D16D30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	internal Task IMLMJLDKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD17250", Offset = "0xD15A50", VA = "0x180D17250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xD16E80", Offset = "0xD15680", VA = "0x180D16E80", Slot = "6")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xD16CD0", Offset = "0xD154D0", VA = "0x180D16CD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xD170F0", Offset = "0xD158F0", VA = "0x180D170F0", Slot = "5")]
	public bool LJKCNKDACNJ(HONPGICEIGE KOOKNJFEKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xD16D40", Offset = "0xD15540", VA = "0x180D16D40")]
	private void KOBBPAEHOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0xD16960", Offset = "0xD15160", VA = "0x180D16960")]
	private void BLIPNBCHFOJ(INGIBJGEAFA MLOBKEMPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xD16BB0", Offset = "0xD153B0", VA = "0x180D16BB0")]
	[AsyncStateMachine(typeof(AIKHOAJPJOJ))]
	private Task DEGDPCDCLCB(INGIBJGEAFA MLOBKEMPEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xD162E0", Offset = "0xD14AE0", VA = "0x180D162E0")]
	private Func<CancellationToken, List<Task>> AECDIDOFCOP(INGIBJGEAFA MLOBKEMPEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0xD164C0", Offset = "0xD14CC0", VA = "0x180D164C0")]
	private List<Task> AKJKHIIIOOI(INGIBJGEAFA MLOBKEMPEJN, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xD16390", Offset = "0xD14B90", VA = "0x180D16390")]
	[AsyncStateMachine(typeof(FLGFBJBGDDO))]
	private Task AIHPHKIELJJ(HONPGICEIGE ELNELLFNEFO, INGIBJGEAFA DMDONNOOOJK, CancellationToken HMOHICKINOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xD17150", Offset = "0xD15950", VA = "0x180D17150")]
	[AsyncStateMachine(typeof(FEEJMCBHHEB))]
	private Task LPPLHGHICHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xD17260", Offset = "0xD15A60", VA = "0x180D17260")]
	private void PJLPMHDDAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xD17330", Offset = "0xD15B30", VA = "0x180D17330")]
	public HOIOFPCDCEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Preserve]
internal class NNLHPCJENDN : CCDKBBLIPAD, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct JNIJDJBNBMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DA0", Offset = "0xEF05A0", VA = "0x180EF1DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct JMKFMPPHOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private global::FEGLKKODBFL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ICLKJDCDBDB <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private KJOFGGPGGFG <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xEF1480", Offset = "0xEEFC80", VA = "0x180EF1480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class ACGPKGBMKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Task<ELHGJICLIED> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ACGPKGBMKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		internal Task<ELHGJICLIED> <ConnectToRoomAndRunLoadLogic>b__0(GBCJCBAKIDH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JLNOGLJLLCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public ICLKJDCDBDB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private ACGPKGBMKOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private NIJMJBHMJAM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private GBCJCBAKIDH <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private BBGKOPIDFHO <preOperationProgressTracker>5__8;

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
		private TaskAwaiter<ELHGJICLIED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xEEF800", Offset = "0xEEE000", VA = "0x180EEF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct JGFGFMDHKJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private GBCJCBAKIDH <disconnectTimerScope>5__3;

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
		private GBCJCBAKIDH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xEEF040", Offset = "0xEED840", VA = "0x180EEF040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct NEEMIHCJCED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private IDLHNLLMOOO <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xEFAD00", Offset = "0xEF9500", VA = "0x180EFAD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct EAMFAGOKNOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public ICLKJDCDBDB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private GBCJCBAKIDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter<JPGFIFDEBLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xEEBCD0", Offset = "0xEEA4D0", VA = "0x180EEBCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DCJDJFLJOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DCJDJFLJOLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KGFPCJBMPLB
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
		public DCJDJFLJOLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KGFPCJBMPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xEF2700", Offset = "0xEF0F00", VA = "0x180EF2700")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xEF2610", Offset = "0xEF0E10", VA = "0x180EF2610")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct CCFALGJCJPM : IAsyncStateMachine
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
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private KGFPCJBMPLB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0xEEA310", Offset = "0xEE8B10", VA = "0x180EEA310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct IKLNLHGLIKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ICLKJDCDBDB joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public ELHGJICLIED initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public ECKOOCHDGPJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public NIJMJBHMJAM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private GBCJCBAKIDH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xEEE9A0", Offset = "0xEED1A0", VA = "0x180EEE9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct LJEHAMPOCCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private GBCJCBAKIDH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xEF43A0", Offset = "0xEF2BA0", VA = "0x180EF43A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct BNKNALDKOBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xEE9510", Offset = "0xEE7D10", VA = "0x180EE9510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct EJPEDMIDIIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xEEC320", Offset = "0xEEAB20", VA = "0x180EEC320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct NHMCKIKMKGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<BODOEIOLLNF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xEFB0E0", Offset = "0xEF98E0", VA = "0x180EFB0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct HBAIFEFJDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NNLHPCJENDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xEEDE00", Offset = "0xEEC600", VA = "0x180EEDE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class FBELCBFKHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public FBELCBFKHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xEEC5A0", Offset = "0xEEADA0", VA = "0x180EEC5A0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class KGBMJMJGHAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KGBMJMJGHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xEF2580", Offset = "0xEF0D80", VA = "0x180EF2580")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KOJCJDABFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KOJCJDABFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xEF2B40", Offset = "0xEF1340", VA = "0x180EF2B40")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PDKJAPKKKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PDKJAPKKKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xF02DE0", Offset = "0xF015E0", VA = "0x180F02DE0")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly string PKLPFKLMBDM;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly string ODONCFBIHIC;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly string AHOHGCFDJOB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static readonly Guid ONFDMBNPMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private HIBACKCEBKD INJCHFHHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IPIPOKJHMDH LJODJJMHKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private DKAENNGCLLB JKNLEHCGOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private KFEFBLHCGKO LCJGFKHPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private DBMLFBPCMDG HKICLIFPELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NACEFDIHHFF BNFFLBNLMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IDisposable IMKBHDMABPF;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public TaskStatus KHKDJDHEBON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x631150", Offset = "0x62F950", VA = "0x180631150", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B80", Offset = "0x6F7380", VA = "0x1806F8B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xEFCE60", Offset = "0xEFB660", VA = "0x180EFCE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0xEFF160", Offset = "0xEFD960", VA = "0x180EFF160", Slot = "6")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xEFD490", Offset = "0xEFBC90", VA = "0x180EFD490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xEFD4E0", Offset = "0xEFBCE0", VA = "0x180EFD4E0", Slot = "5")]
	[AsyncStateMachine(typeof(JNIJDJBNBMC))]
	public Task EDPNPKMAHGP(ECKOOCHDGPJ IEECNFLAKJO, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0xEFD990", Offset = "0xEFC190", VA = "0x180EFD990")]
	[AsyncStateMachine(typeof(JMKFMPPHOBN))]
	private Task EPGJMENFPOH(ECKOOCHDGPJ IEECNFLAKJO, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xEFEAA0", Offset = "0xEFD2A0", VA = "0x180EFEAA0")]
	private static void HPHJKOKOGCG(ECKOOCHDGPJ IEECNFLAKJO, Exception BMHFAHACLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xEFE410", Offset = "0xEFCC10", VA = "0x180EFE410")]
	private static void HGNGCFDKGDJ(KJOFGGPGGFG FEHGKCJJHAO, Exception BMHFAHACLCM, [Optional] List<int> OJMLPMOKEAK, int HCBNABJGNLJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xEFCCF0", Offset = "0xEFB4F0", VA = "0x180EFCCF0")]
	[AsyncStateMachine(typeof(JLNOGLJLLCP))]
	private Task BLOBOJGCLLD(GBCJCBAKIDH MGJEIEDBIEE, ECKOOCHDGPJ IEECNFLAKJO, ICLKJDCDBDB FFBDCLBEGGK, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0xEFD800", Offset = "0xEFC000", VA = "0x180EFD800")]
	private void EPGIHNIMLLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0xEFD360", Offset = "0xEFBB60", VA = "0x180EFD360")]
	[AsyncStateMachine(typeof(JGFGFMDHKJI))]
	private Task DDCEABNCOPG(GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0xEFDE00", Offset = "0xEFC600", VA = "0x180EFDE00")]
	private void GBBGEPPHBEN(ECKOOCHDGPJ IEECNFLAKJO, CancellationToken LAOFPANACHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0xEFED30", Offset = "0xEFD530", VA = "0x180EFED30")]
	private void JKGMOLMPPOF(ECKOOCHDGPJ IEECNFLAKJO, ICLKJDCDBDB FFBDCLBEGGK, OperationCanceledException INNAEKGEOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xEFCA80", Offset = "0xEFB280", VA = "0x180EFCA80")]
	private void BJCKJHBLNHJ(ECKOOCHDGPJ IEECNFLAKJO, ICLKJDCDBDB FFBDCLBEGGK, Exception BMHFAHACLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xEFE100", Offset = "0xEFC900", VA = "0x180EFE100")]
	private void GFEPOGAELDG(ECKOOCHDGPJ IEECNFLAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xEFFBB0", Offset = "0xEFE3B0", VA = "0x180EFFBB0")]
	private static FFNIJHBKDOK PFHGEEGCBKO(ECKOOCHDGPJ IEECNFLAKJO)
	{
		return default(FFNIJHBKDOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0xEFEC30", Offset = "0xEFD430", VA = "0x180EFEC30")]
	[AsyncStateMachine(typeof(NEEMIHCJCED))]
	private Task JGCPHLMGPHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0xEFD610", Offset = "0xEFBE10", VA = "0x180EFD610")]
	private static JPGFIFDEBLI ENDCBPLGOBH(ECKOOCHDGPJ IEECNFLAKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0xEFF7E0", Offset = "0xEFDFE0", VA = "0x180EFF7E0")]
	[AsyncStateMachine(typeof(EAMFAGOKNOM))]
	private Task MMEAGFFJLIJ(ECKOOCHDGPJ IEECNFLAKJO, ICLKJDCDBDB FFBDCLBEGGK, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken PPOHMFLFOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0xEFF560", Offset = "0xEFDD60", VA = "0x180EFF560")]
	[AsyncStateMachine(typeof(CCFALGJCJPM))]
	private Task LPLHDFAKGAO(ECKOOCHDGPJ IEECNFLAKJO, CancellationTokenSource IFMLLHBJOFJ, Task BLGPDPGJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0xEFD000", Offset = "0xEFB800", VA = "0x180EFD000")]
	[AsyncStateMachine(typeof(IKLNLHGLIKG))]
	private Task CHINPABBMJM(ELHGJICLIED NFIODFLMLJP, NIJMJBHMJAM FBDENPPKMLD, ECKOOCHDGPJ PINAAIPIJOO, ICLKJDCDBDB JCPDJEIOCOB, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken CLAOJINLKLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0xEFDC00", Offset = "0xEFC400", VA = "0x180EFDC00")]
	private ICLKJDCDBDB FLMCHHDNNBF(ICLKJDCDBDB JCPDJEIOCOB, ref CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xEFF020", Offset = "0xEFD820", VA = "0x180EFF020")]
	[AsyncStateMachine(typeof(LJEHAMPOCCK))]
	private Task KDMFKBNCHGB(GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0xEFF940", Offset = "0xEFE140", VA = "0x180EFF940")]
	[AsyncStateMachine(typeof(BNKNALDKOBA))]
	private Task NNOEBILHLOE(GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xEFFA70", Offset = "0xEFE270", VA = "0x180EFFA70")]
	[AsyncStateMachine(typeof(EJPEDMIDIIP))]
	private Task OEHGGNHNPEN(GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0xEFF6B0", Offset = "0xEFDEB0", VA = "0x180EFF6B0")]
	[AsyncStateMachine(typeof(NHMCKIKMKGK))]
	private Task MHIJCOLHJLH(INGIBJGEAFA DMDONNOOOJK, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xEFD6C0", Offset = "0xEFBEC0", VA = "0x180EFD6C0")]
	[AsyncStateMachine(typeof(HBAIFEFJDDB))]
	private Task EOADBFJNKIN(GBCJCBAKIDH LEEHDEOADOO, CancellationToken PPOHMFLFOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0xEFC8B0", Offset = "0xEFB0B0", VA = "0x180EFC8B0")]
	private static void BHMLHLPBBLM(ECKOOCHDGPJ IEECNFLAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xEFD180", Offset = "0xEFB980", VA = "0x180EFD180")]
	private void CNHLENLLDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xEFEFA0", Offset = "0xEFD7A0", VA = "0x180EFEFA0")]
	private void JKHGFGBPHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xEFF3A0", Offset = "0xEFDBA0", VA = "0x180EFF3A0")]
	private void LLLMAOLPDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xEFC820", Offset = "0xEFB020", VA = "0x180EFC820")]
	private void AIDDLMHFKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xEFDAC0", Offset = "0xEFC2C0", VA = "0x180EFDAC0")]
	private static void FLIOBGDGDNO(ECKOOCHDGPJ IEECNFLAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xEFC9D0", Offset = "0xEFB1D0", VA = "0x180EFC9D0")]
	private static void BIJFPOOOICD(ECKOOCHDGPJ IEECNFLAKJO, CancellationToken PPOHMFLFOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xEFCEB0", Offset = "0xEFB6B0", VA = "0x180EFCEB0")]
	private static void CCINBEJNLEA(ECKOOCHDGPJ IEECNFLAKJO, Exception BMHFAHACLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xEFF430", Offset = "0xEFDC30", VA = "0x180EFF430")]
	private void LMBBMBBFOCO(ECKOOCHDGPJ IEECNFLAKJO, Task BLGPDPGJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xEFE350", Offset = "0xEFCB50", VA = "0x180EFE350")]
	private static void GMHBDKJBFAD(Func<string> IGABHJPIBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xEFFCB0", Offset = "0xEFE4B0", VA = "0x180EFFCB0")]
	public NNLHPCJENDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class FALLEKBOGOF : IAEBJHAKNJP, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class CDAILCDMLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public CDAILCDMLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD0BB10", Offset = "0xD0A310", VA = "0x180D0BB10")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class ADIJMGECPJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ADIJMGECPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD0A2C0", Offset = "0xD08AC0", VA = "0x180D0A2C0")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class EBMEIPGFPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EBMEIPGFPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC70", Offset = "0xD0C470", VA = "0x180D0DC70")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class EAIODIBINEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EAIODIBINEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC20", Offset = "0xD0C420", VA = "0x180D0DC20")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JODIJAEGNBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public JODIJAEGNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xD1A400", Offset = "0xD18C00", VA = "0x180D1A400")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Dictionary<Guid, AABJKLLEJMP> LNOGNAOFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly TimeSpan CIHFJOBNJLK;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "10")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xD0F6A0", Offset = "0xD0DEA0", VA = "0x180D0F6A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xD0FEF0", Offset = "0xD0E6F0", VA = "0x180D0FEF0", Slot = "4")]
	public CLEIPPGNEIP NLKJJINIDJF(Guid CMBACDFLKJB)
	{
		return default(CLEIPPGNEIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0xD0FA10", Offset = "0xD0E210", VA = "0x180D0FA10", Slot = "5")]
	public bool NHIAFFMKOAF(Guid CMBACDFLKJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xD103C0", Offset = "0xD0EBC0", VA = "0x180D103C0", Slot = "8")]
	public bool PJLPMHDDAHC(Guid CMBACDFLKJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xD0F6B0", Offset = "0xD0DEB0", VA = "0x180D0F6B0", Slot = "6")]
	public bool GCOJMMBHAFI(Guid CMBACDFLKJB, Task CEJILLDLOHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0E4D0", VA = "0x180D0FCD0", Slot = "7")]
	public bool NKGFBGIFFIG(Guid CMBACDFLKJB, BODOEIOLLNF BGIHEEBLBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xD0FC50", Offset = "0xD0E450", VA = "0x180D0FC50", Slot = "9")]
	public Task<(BODOEIOLLNF, Task)> NKFPAAAFMOG(Guid CMBACDFLKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0xD10180", Offset = "0xD0E980", VA = "0x180D10180")]
	private void OHDLDAKFJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xD105D0", Offset = "0xD0EDD0", VA = "0x180D105D0")]
	public FALLEKBOGOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Preserve]
internal class PBPEDLBEFCG : JLAGMOELFHM, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class FHCMKLOHOLO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly ECKOOCHDGPJ PIFNAAGJGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly CancellationTokenSource GKPFEEDCFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public readonly CancellationToken EHMGKNOMAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private bool JBOEJBBHDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private bool FNFCOIPJPFP;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3A09790", Offset = "0x3A07F90", VA = "0x183A09790")]
		public FHCMKLOHOLO(ECKOOCHDGPJ PIFNAAGJGDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3A09660", Offset = "0x3A07E60", VA = "0x183A09660")]
		public void PJLPMHDDAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3A09630", Offset = "0x3A07E30", VA = "0x183A09630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CKEOKGCNBCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public HAKDCNMIKLP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public CKEOKGCNBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3A07D00", Offset = "0x3A06500", VA = "0x183A07D00")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MJDCIPPCCNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public HAKDCNMIKLP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public PBPEDLBEFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B150", Offset = "0x3A09950", VA = "0x183A0B150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class IEPBOAOIIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IEPBOAOIIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3A09920", Offset = "0x3A08120", VA = "0x183A09920")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct AIEOAHFHGCG : IAsyncStateMachine
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
		public PBPEDLBEFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3A06D80", Offset = "0x3A05580", VA = "0x183A06D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8172D0", Offset = "0x815AD0", VA = "0x1808172D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class NINMMBDMGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public ECKOOCHDGPJ newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NINMMBDMGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BAA0", Offset = "0x3A0A2A0", VA = "0x183A0BAA0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BB30", Offset = "0x3A0A330", VA = "0x183A0BB30")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BB70", Offset = "0x3A0A370", VA = "0x183A0BB70")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class HFFBPFAJCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HFFBPFAJCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3A09840", Offset = "0x3A08040", VA = "0x183A09840")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MIIIGKOEJED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public ECKOOCHDGPJ newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public PBPEDLBEFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private NINMMBDMGOB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x3A0A610", Offset = "0x3A08E10", VA = "0x183A0A610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private IPIPOKJHMDH LJODJJMHKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private DKAENNGCLLB JKNLEHCGOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private NACEFDIHHFF BNFFLBNLMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private CCDKBBLIPAD JFHFPFFKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long FKFDLHKEBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private FHCMKLOHOLO BBIHPNBPCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool MGFONHCKDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private Task NLNCNFCGGKM;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EE70", Offset = "0x3A0D670", VA = "0x183A0EE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool KCOLJEHNFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B20", Offset = "0x5F7320", VA = "0x1805F8B20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3A0FFB0", Offset = "0x3A0E7B0", VA = "0x183A0FFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FBE0", Offset = "0x3A0E3E0", VA = "0x183A0FBE0", Slot = "4")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F090", Offset = "0x3A0D890", VA = "0x183A0F090", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3A10070", Offset = "0x3A0E870", VA = "0x183A10070")]
	[AsyncStateMachine(typeof(MJDCIPPCCNM))]
	private Task NKNGEMOHKJF(HAKDCNMIKLP JGIOCAPOEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F370", Offset = "0x3A0DB70", VA = "0x183A0F370")]
	private void HHLICIMMMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F570", Offset = "0x3A0DD70", VA = "0x183A0F570")]
	private void ILIBBEJBCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EEC0", Offset = "0x3A0D6C0", VA = "0x183A0EEC0")]
	private void DMEJFFIJJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F2F0", Offset = "0x3A0DAF0", VA = "0x183A0F2F0")]
	private bool GDAHFEEMPMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FA40", Offset = "0x3A0E240", VA = "0x183A0FA40")]
	[AsyncStateMachine(typeof(AIEOAHFHGCG))]
	private void JJFNBFNJENB(int PPNGDOLAPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F750", Offset = "0x3A0DF50", VA = "0x183A0F750")]
	private void INPDILDGOOE(out IDisposable PCKOBJOEICM, out IDisposable DIBBGGEHCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FE30", Offset = "0x3A0E630", VA = "0x183A0FE30")]
	private bool LIPIFPFCPGF(ECKOOCHDGPJ PIFNAAGJGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FB20", Offset = "0x3A0E320", VA = "0x183A0FB20")]
	private void LBHNGMFNBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F1E0", Offset = "0x3A0D9E0", VA = "0x183A0F1E0")]
	[AsyncStateMachine(typeof(MIIIGKOEJED))]
	private Task EPGJMENFPOH(ECKOOCHDGPJ PIFNAAGJGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3A10180", Offset = "0x3A0E980", VA = "0x183A10180")]
	public PBPEDLBEFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[Preserve]
internal sealed class NCJACHIHHPF : IEBNCPHJGMB, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct MCDDKNJLAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder<IONPKFBCCEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public NCJACHIHHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<IONPKFBCCEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xEF6BB0", Offset = "0xEF53B0", VA = "0x180EF6BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xEF6D80", Offset = "0xEF5580", VA = "0x180EF6D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class HFJIIJKNCDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public FLDLNHLOABD message;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HFJIIJKNCDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xEEE7D0", Offset = "0xEECFD0", VA = "0x180EEE7D0")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GEICDCBPHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public FLDLNHLOABD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public GEICDCBPHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xEECEC0", Offset = "0xEEB6C0", VA = "0x180EECEC0")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class AOPGJGFHNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public AOPGJGFHNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xEE8D20", Offset = "0xEE7520", VA = "0x180EE8D20")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct MENADLBIIDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NCJACHIHHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<OGENKHEHHGB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xEF6DD0", Offset = "0xEF55D0", VA = "0x180EF6DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class INFGLMIHIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public FLDLNHLOABD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public INFGLMIHIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xEEEF90", Offset = "0xEED790", VA = "0x180EEEF90")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LCJKINHEGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public FLDLNHLOABD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public NCJACHIHHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private ICLKJDCDBDB <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xEF3300", Offset = "0xEF1B00", VA = "0x180EF3300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MFMAPMFEKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AsyncTaskMethodBuilder<OGENKHEHHGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NCJACHIHHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private ICLKJDCDBDB <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xEF8320", Offset = "0xEF6B20", VA = "0x180EF8320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xEF86F0", Offset = "0xEF6EF0", VA = "0x180EF86F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class PNGOHBFHBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public OGENKHEHHGB operation;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PNGOHBFHBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xF02F30", Offset = "0xF01730", VA = "0x180F02F30")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct CHEOCADJHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public OGENKHEHHGB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public NCJACHIHHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private global::FEGLKKODBFL<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xEEB1D0", Offset = "0xEE99D0", VA = "0x180EEB1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NAKPAJOKCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NAKPAJOKCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xEF8CF0", Offset = "0xEF74F0", VA = "0x180EF8CF0")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class HNAPDBJBGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HNAPDBJBGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xEEE880", Offset = "0xEED080", VA = "0x180EEE880")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private KFEFBLHCGKO LCJGFKHPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private JMAIGBPBIDB DIKKBLPMCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private LLIKACPEDEN GIOGNGLFHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private TaskCompletionSource<IONPKFBCCEM> GJFMICDDBKP;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xEFA970", Offset = "0xEF9170", VA = "0x180EFA970", Slot = "7")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0xEFA4E0", Offset = "0xEF8CE0", VA = "0x180EFA4E0", Slot = "6")]
	[AsyncStateMachine(typeof(MCDDKNJLAOO))]
	public Task<IONPKFBCCEM> JDHJNCOHIDA(CancellationToken OIHCHGLNFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xEFA010", Offset = "0xEF8810", VA = "0x180EFA010", Slot = "4")]
	public void FNCPKKKEDKA(FLDLNHLOABD MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xEF9CD0", Offset = "0xEF84D0", VA = "0x180EF9CD0", Slot = "5")]
	public void FJDBKBEHGKB(FLDLNHLOABD KFAIJJAIEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xEFA3D0", Offset = "0xEF8BD0", VA = "0x180EFA3D0")]
	[AsyncStateMachine(typeof(MENADLBIIDC))]
	private Task IJJPGEDNIPI(FLDLNHLOABD GMJOOGMAMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0xEFAB90", Offset = "0xEF9390", VA = "0x180EFAB90")]
	[AsyncStateMachine(typeof(LCJKINHEGBB))]
	private Task MONGADCENCA(FLDLNHLOABD GAIFDHBDKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xEFAA50", Offset = "0xEF9250", VA = "0x180EFAA50")]
	[AsyncStateMachine(typeof(MFMAPMFEKDA))]
	private Task<OGENKHEHHGB> MCNDFGAABMI(FLDLNHLOABD GMJOOGMAMPH, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xEF98D0", Offset = "0xEF80D0", VA = "0x180EF98D0")]
	private ICLKJDCDBDB BOKNEANLLFJ(FLDLNHLOABD JOKEGPNMJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xEF9950", Offset = "0xEF8150", VA = "0x180EF9950")]
	[AsyncStateMachine(typeof(CHEOCADJHII))]
	private Task CAAOKPMJMEE(OGENKHEHHGB ALMLALCCCIC, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8280", VA = "0x180EF9A80")]
	private OGENKHEHHGB ELFLNILKGDM(FLDLNHLOABD GMJOOGMAMPH, ICLKJDCDBDB IGAFIMBDEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0xA87540", Offset = "0xA85D40", VA = "0x180A87540")]
	private T JAMLKDFGDEE<T>(T CJMMBFLIBMO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xEFA600", Offset = "0xEF8E00", VA = "0x180EFA600")]
	private OGENKHEHHGB KCAKDGLJOID(FLDLNHLOABD GMJOOGMAMPH, ICLKJDCDBDB IGAFIMBDEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public NCJACHIHHPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xEFA380", Offset = "0xEF8B80", VA = "0x180EFA380")]
	[CompilerGenerated]
	private void GNBGGEPKAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[Preserve]
internal sealed class LOPPJAHLJAD : JMAIGBPBIDB, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class HKHOMAGFCMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HKHOMAGFCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xEEE820", Offset = "0xEED020", VA = "0x180EEE820")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class NDDILCPICDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NDDILCPICDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xEFACA0", Offset = "0xEF94A0", VA = "0x180EFACA0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NFFKCCHABON ADMDEPNJPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private IEBNCPHJGMB KANHMCIOJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private IAEBJHAKNJP LNOGNAOFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private HFGHCNEEHCO AJHPOEOKJEF;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xEF5590", Offset = "0xEF3D90", VA = "0x180EF5590", Slot = "6")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xEF4DB0", Offset = "0xEF35B0", VA = "0x180EF4DB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xEF6470", Offset = "0xEF4C70", VA = "0x180EF6470", Slot = "4")]
	public CLEIPPGNEIP OKLJCANDPJI(KIENNHPIEGO GMJOOGMAMPH)
	{
		return default(CLEIPPGNEIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xEF5110", Offset = "0xEF3910", VA = "0x180EF5110", Slot = "5")]
	public void GOPPENHFDBN(Guid CMBACDFLKJB, Task CEJILLDLOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xEF47F0", Offset = "0xEF2FF0", VA = "0x180EF47F0")]
	private void DAEDNDHGNBN(byte NFCNJIFDDME, int OBONDCDABKM, object DHCKFDBNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xEF5900", Offset = "0xEF4100", VA = "0x180EF5900")]
	private void NCPLCKCNLOL(OLAKKHFLMFP OLHHGMIKFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xEF48C0", Offset = "0xEF30C0", VA = "0x180EF48C0")]
	private void DLINEAHDPDO(OLAKKHFLMFP OLHHGMIKFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xEF4B50", Offset = "0xEF3350", VA = "0x180EF4B50")]
	private void DPEMBMBFHGF(OLAKKHFLMFP OLHHGMIKFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xEF5EB0", Offset = "0xEF46B0", VA = "0x180EF5EB0")]
	private BODOEIOLLNF OKBGJCCEMBM(FLDLNHLOABD JOKEGPNMJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xEF5360", Offset = "0xEF3B60", VA = "0x180EF5360")]
	private void HMGEACOBFGB(FLDLNHLOABD GAIFDHBDKGK, BODOEIOLLNF BGIHEEBLBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0xEF56E0", Offset = "0xEF3EE0", VA = "0x180EF56E0")]
	private bool LKKLMDOLFBL(FLDLNHLOABD GAIFDHBDKGK, BODOEIOLLNF BGIHEEBLBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0xEF61D0", Offset = "0xEF49D0", VA = "0x180EF61D0")]
	private bool OKLJCANDPJI(FLDLNHLOABD OMHIPEBKNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xEF4E40", Offset = "0xEF3640", VA = "0x180EF4E40")]
	private bool FDJHAKJEKJD(byte NFCNJIFDDME, ExitGames.Client.Photon.Hashtable OLHHGMIKFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LOPPJAHLJAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[Preserve]
internal sealed class PHNKKEJJFEI : GEJEPBIHACI, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class DFJHOPDEDFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public IONPKFBCCEM operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DFJHOPDEDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A07DA0", Offset = "0x3A065A0", VA = "0x183A07DA0")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct MKMHGKOEPEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder<BODOEIOLLNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public IONPKFBCCEM operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public PHNKKEJJFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public PAEDDAMNHLM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public EMNJGNCCDDA detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private TaskAwaiter<BODOEIOLLNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B480", Offset = "0x3A09C80", VA = "0x183A0B480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BA50", Offset = "0x3A0A250", VA = "0x183A0BA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class MDJNCDAEBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public IONPKFBCCEM operationType;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public MDJNCDAEBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A460", Offset = "0x3A08C60", VA = "0x183A0A460")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class JCIPBJBAMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public IONPKFBCCEM operationType;

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public JCIPBJBAMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A099E0", Offset = "0x3A081E0", VA = "0x183A099E0")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A09A40", Offset = "0x3A08240", VA = "0x183A09A40")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A09AA0", Offset = "0x3A082A0", VA = "0x183A09AA0")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct OKPFAMNHNBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<BODOEIOLLNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public IONPKFBCCEM operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public PHNKKEJJFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public PAEDDAMNHLM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public EMNJGNCCDDA detailsToReload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private JCIPBJBAMMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private CLEIPPGNEIP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private BODOEIOLLNF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<(BODOEIOLLNF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C8C0", Offset = "0x3A0B0C0", VA = "0x183A0C8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A0CF00", Offset = "0x3A0B700", VA = "0x183A0CF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class ACODFHPLMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public IONPKFBCCEM operationType;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ACODFHPLMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A06D20", Offset = "0x3A05520", VA = "0x183A06D20")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private KCFEBLBCKNI NNLFGMLLEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NFFKCCHABON ADMDEPNJPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private JMAIGBPBIDB DIKKBLPMCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A110E0", Offset = "0x3A0F8E0", VA = "0x183A110E0", Slot = "5")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A10F90", Offset = "0x3A0F790", VA = "0x183A10F90", Slot = "4")]
	[AsyncStateMachine(typeof(MKMHGKOEPEP))]
	public Task<BODOEIOLLNF> KDANIMOAPKD(PAEDDAMNHLM LGGPAKMMAEI, IONPKFBCCEM LPDFKDIACDP, [CanBeNull] EMNJGNCCDDA LHIDLFKFNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A10CF0", Offset = "0x3A0F4F0", VA = "0x183A10CF0")]
	private bool IDCCIKHABLE(IONPKFBCCEM LPDFKDIACDP, out BODOEIOLLNF FNPLEFBJGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A107F0", Offset = "0x3A0EFF0", VA = "0x183A107F0")]
	[AsyncStateMachine(typeof(OKPFAMNHNBH))]
	private Task<BODOEIOLLNF> DNDAFINNBKD(PAEDDAMNHLM LGGPAKMMAEI, IONPKFBCCEM LPDFKDIACDP, [CanBeNull] EMNJGNCCDDA LHIDLFKFNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A10940", Offset = "0x3A0F140", VA = "0x183A10940")]
	internal KIENNHPIEGO EMKIJDPOLJF(PAEDDAMNHLM LGGPAKMMAEI, IONPKFBCCEM LPDFKDIACDP, [CanBeNull] EMNJGNCCDDA LHIDLFKFNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PHNKKEJJFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[Preserve]
internal sealed class DOOCLGFMAAM : KCFEBLBCKNI, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct LABCHAHKPLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public AsyncTaskMethodBuilder<ELHGJICLIED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public DOOCLGFMAAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter<EMNJGNCCDDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xD1DF70", Offset = "0xD1C770", VA = "0x180D1DF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xD1E230", Offset = "0xD1CA30", VA = "0x180D1E230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LEJOAIFMKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public LEJOAIFMKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xD1E280", Offset = "0xD1CA80", VA = "0x180D1E280")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct KAHKEKHPCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AsyncTaskMethodBuilder<EMNJGNCCDDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public DOOCLGFMAAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public ECKOOCHDGPJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private LEJOAIFMKHI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private TaskAwaiter<CPBHDEJOBKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xD1A900", Offset = "0xD19100", VA = "0x180D1A900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xD1AC20", Offset = "0xD19420", VA = "0x180D1AC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DDBCBGMLFFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DDBCBGMLFFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x80B2D0", Offset = "0x809AD0", VA = "0x18080B2D0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(EPGHEIOKHIJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private LDBOILHHNBA IHNDLCBGGMH;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly (JJEDHNFHCKD superRoomData, string unityAssetId, JJEDHNFHCKD subRoomData) LLCGNPHCKIC;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xD0D0B0", Offset = "0xD0B8B0", VA = "0x180D0D0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xD0D950", Offset = "0xD0C150", VA = "0x180D0D950", Slot = "8")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xD0D9E0", Offset = "0xD0C1E0", VA = "0x180D0D9E0", Slot = "4")]
	[AsyncStateMachine(typeof(LABCHAHKPLO))]
	public Task<ELHGJICLIED> LMPFPIEBGCF(GBCJCBAKIDH LEEHDEOADOO, ECKOOCHDGPJ IEECNFLAKJO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xD0D640", Offset = "0xD0BE40", VA = "0x180D0D640")]
	[AsyncStateMachine(typeof(KAHKEKHPCEP))]
	public Task<EMNJGNCCDDA> IGBEDNLBNHK(ECKOOCHDGPJ IEECNFLAKJO, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xD0CD70", Offset = "0xD0B570", VA = "0x180D0CD70", Slot = "5")]
	public ELHGJICLIED BFAMLHCLKAJ(ECKOOCHDGPJ IEECNFLAKJO, EMNJGNCCDDA FECOGEBKDJA, long CIPNHNCCGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xD0D1F0", Offset = "0xD0B9F0", VA = "0x180D0D1F0", Slot = "6")]
	public ELHGJICLIED EIHNIPCFICA(ECKOOCHDGPJ IEECNFLAKJO, MHCAIACOCEC NOGFEHEPEIA, long CIPNHNCCGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xD0D100", Offset = "0xD0B900", VA = "0x180D0D100", Slot = "7")]
	public ELHGJICLIED CLEGEHHICIA(long DHPFJDEEBED, long CIPNHNCCGBL, string LCMKCBJJJGI, string FONEAOCGOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xD0D7A0", Offset = "0xD0BFA0", VA = "0x180D0D7A0")]
	private static ELHGJICLIED LDLGPHIFNMH(long DHPFJDEEBED, long CIPNHNCCGBL, JJEDHNFHCKD GFNNFDLOINI, string LCMKCBJJJGI, JJEDHNFHCKD MLOBKEMPEJN, string FONEAOCGOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xD0D300", Offset = "0xD0BB00", VA = "0x180D0D300")]
	private (JJEDHNFHCKD, string, JJEDHNFHCKD) GNKMFBACIIP(ECKOOCHDGPJ IEECNFLAKJO, EMNJGNCCDDA FECOGEBKDJA, long CIPNHNCCGBL)
	{
		return default((JJEDHNFHCKD, string, JJEDHNFHCKD));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public DOOCLGFMAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[Preserve]
internal sealed class CMANAFAMGOJ : LLIKACPEDEN, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class DJHKJJDNLGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DJHKJJDNLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xCFD820", Offset = "0xCFC020", VA = "0x180CFD820")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct DDMLDIHLAMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CMANAFAMGOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public ICLKJDCDBDB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xCFD010", Offset = "0xCFB810", VA = "0x180CFD010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFBCD0", VA = "0x180CFD4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct LIEICPNPBMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CMANAFAMGOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public ICLKJDCDBDB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter<HALEFFKAIIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xD03280", Offset = "0xD01A80", VA = "0x180D03280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD03780", Offset = "0xD01F80", VA = "0x180D03780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class LGJACOOOBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public LGJACOOOBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD02A20", Offset = "0xD01220", VA = "0x180D02A20")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct FIGNNEFCCPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public FLDLNHLOABD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public CMANAFAMGOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public ICLKJDCDBDB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private LPPJODCHEDL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private JLIDBHLNGHJ <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<HALEFFKAIIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xCFFDF0", Offset = "0xCFE5F0", VA = "0x180CFFDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xD006D0", Offset = "0xCFEED0", VA = "0x180D006D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private EFBHJOECGCD IBADDOMILAH;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private DJBLMANHFBO JMAFOPJNLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xCFC4E0", Offset = "0xCFACE0", VA = "0x180CFC4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0xCFC0D0", Offset = "0xCFA8D0", VA = "0x180CFC0D0", Slot = "8")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xCFBF70", Offset = "0xCFA770", VA = "0x180CFBF70", Slot = "4")]
	[AsyncStateMachine(typeof(DDMLDIHLAMJ))]
	public Task<FLDLNHLOABD> JDLLKEDFHEP(FLDLNHLOABD GMJOOGMAMPH, ICLKJDCDBDB IGAFIMBDEEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xCFC260", Offset = "0xCFAA60", VA = "0x180CFC260", Slot = "5")]
	[AsyncStateMachine(typeof(LIEICPNPBMO))]
	public Task<FLDLNHLOABD> LMLDDBOFCPL(CancellationToken NFKHAKHIBIO, ICLKJDCDBDB IGAFIMBDEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xCFBED0", Offset = "0xCFA6D0", VA = "0x180CFBED0", Slot = "6")]
	public ONHGGFHNMLK GNMILGNPNOP(OGENKHEHHGB PAFEHNAPJBB, GBCJCBAKIDH LEEHDEOADOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xCFC160", Offset = "0xCFA960", VA = "0x180CFC160", Slot = "7")]
	public ONHGGFHNMLK LMGOFKNIFIE(OGENKHEHHGB PAFEHNAPJBB, GBCJCBAKIDH LEEHDEOADOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xCFBD80", Offset = "0xCFA580", VA = "0x180CFBD80")]
	[AsyncStateMachine(typeof(FIGNNEFCCPL))]
	private Task<FLDLNHLOABD> GMKBBJHHJLP(FLDLNHLOABD GMJOOGMAMPH, ICLKJDCDBDB IGAFIMBDEEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xCFC0C0", Offset = "0xCFA8C0", VA = "0x180CFC0C0")]
	private static byte[] KELOLMLOAFD(FLDLNHLOABD MEKFJFMIPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xCFC3A0", Offset = "0xCFABA0", VA = "0x180CFC3A0")]
	private static string OIENBEPKIHE(byte[] OGMKAFPDGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CMANAFAMGOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Preserve]
internal sealed class CHMPPJJJMNK : NFFKCCHABON, BBCMHMIDCKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private NALPMPNFLCO FIIADNMGNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private KFEFBLHCGKO LCJGFKHPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private HAAKELIBGMM HFMKGJBLIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private CCDKBBLIPAD JFHFPFFKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private KNKICNGDDJA LIGCLNCJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private NACEFDIHHFF BNFFLBNLMCC;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xCFB600", Offset = "0xCF9E00", VA = "0x180CFB600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private static BODOEIOLLNF JOAHMPBOFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xCF5BC0", Offset = "0xCF43C0", VA = "0x180CF5BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xCFB650", Offset = "0xCF9E50", VA = "0x180CFB650", Slot = "7")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xCFB2C0", Offset = "0xCF9AC0", VA = "0x180CFB2C0", Slot = "4")]
	public BODOEIOLLNF BKGALKOAGMJ(PAEDDAMNHLM OIIALCBDFKK, IONPKFBCCEM FOANOEBINNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xCFB7B0", Offset = "0xCF9FB0", VA = "0x180CFB7B0", Slot = "5")]
	public BODOEIOLLNF ODFMMGIOHMK(PAEDDAMNHLM APEHHNOOPME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xCFB420", Offset = "0xCF9C20", VA = "0x180CFB420", Slot = "6")]
	public BODOEIOLLNF BPCGKIJEGAM(PAEDDAMNHLM APEHHNOOPME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xCF5B60", Offset = "0xCF4360", VA = "0x180CF5B60")]
	private static BODOEIOLLNF FHDLEIMNGLB(EJLPIFDACHN DCONKHDOODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CHMPPJJJMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class GCEAFOACAJF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xD12730", Offset = "0xD10F30", VA = "0x180D12730")]
	public GCEAFOACAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC20", Offset = "0x7DA420", VA = "0x1807DBC20")]
	public GCEAFOACAJF(string MEKFJFMIPGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Preserve]
internal sealed class MFKJFOKLEGN : MBLEJJLLIOP, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct GJIPAKFHLKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<BODOEIOLLNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MFKJFOKLEGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public AIJOAHOCHFA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private global::FEGLKKODBFL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private GBCJCBAKIDH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private GBCJCBAKIDH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<BODOEIOLLNF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xEED130", Offset = "0xEEB930", VA = "0x180EED130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xEED7B0", Offset = "0xEEBFB0", VA = "0x180EED7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct CCEFLFHGBDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public MFKJFOKLEGN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xEE9D20", Offset = "0xEE8520", VA = "0x180EE9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct NBDGOAEJHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public MFKJFOKLEGN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xEF8D40", Offset = "0xEF7540", VA = "0x180EF8D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct DMBBHANMNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public MFKJFOKLEGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xEEBB80", Offset = "0xEEA380", VA = "0x180EEBB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct CDFNCKOPJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public MFKJFOKLEGN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xEEAC20", Offset = "0xEE9420", VA = "0x180EEAC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct MHPJOGHDLKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public MFKJFOKLEGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AIJOAHOCHFA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private global::FEGLKKODBFL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xEF8740", Offset = "0xEF6F40", VA = "0x180EF8740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private static readonly TimeSpan MLKICNFBMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private DEGFMGDGNMF GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private LLIKACPEDEN GIOGNGLFHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private KFEFBLHCGKO LCJGFKHPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private KNKICNGDDJA LIGCLNCJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private CancellationTokenSource OEIALICAHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Task KGHHPOJPPHL;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xEF7E40", Offset = "0xEF6640", VA = "0x180EF7E40", Slot = "6")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0xEF7570", Offset = "0xEF5D70", VA = "0x180EF7570", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0xEF76B0", Offset = "0xEF5EB0", VA = "0x180EF76B0", Slot = "4")]
	[AsyncStateMachine(typeof(GJIPAKFHLKP))]
	public Task<BODOEIOLLNF> GHCNBANBMJN(AIJOAHOCHFA EPGJDCEENKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xEF7590", Offset = "0xEF5D90", VA = "0x180EF7590", Slot = "5")]
	[AsyncStateMachine(typeof(CCEFLFHGBDO))]
	public Task EBBAKIHNAEA([Optional] CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xEF7570", Offset = "0xEF5D70", VA = "0x180EF7570")]
	public void BNGDIMMNFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xEF80E0", Offset = "0xEF68E0", VA = "0x180EF80E0")]
	private AAMKLAGKNIH POELFKNLGIJ(AIJOAHOCHFA EPGJDCEENKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xEF7450", Offset = "0xEF5C50", VA = "0x180EF7450")]
	[AsyncStateMachine(typeof(NBDGOAEJHFA))]
	private Task BFDIALFAMOO(INGIBJGEAFA IIFJOCIBPGA, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xEF7FD0", Offset = "0xEF67D0", VA = "0x180EF7FD0")]
	[AsyncStateMachine(typeof(DMBBHANMNLC))]
	private Task PCBJJINAKKJ([Optional] CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xEF7BC0", Offset = "0xEF63C0", VA = "0x180EF7BC0")]
	[AsyncStateMachine(typeof(CDFNCKOPJKH))]
	private Task IKMHMGIBPHC(TimeSpan GNNNMENEPAH, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xEF78F0", Offset = "0xEF60F0", VA = "0x180EF78F0")]
	private Task IGLIMJBPKHD(AIJOAHOCHFA EPGJDCEENKE, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xEF77C0", Offset = "0xEF5FC0", VA = "0x180EF77C0")]
	[AsyncStateMachine(typeof(MHPJOGHDLKK))]
	private Task HBOKIAHIBAO(AIJOAHOCHFA EPGJDCEENKE, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xEF7CF0", Offset = "0xEF64F0", VA = "0x180EF7CF0")]
	private bool LFBPHAAGBLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public MFKJFOKLEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[Preserve]
internal class ELMKHFJAGMC : HAAKELIBGMM, BBCMHMIDCKL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct OIIJFANNLAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ELMKHFJAGMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private global::FEGLKKODBFL<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xD1F9B0", Offset = "0xD1E1B0", VA = "0x180D1F9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private DDHLPGNNHOP DNPPDENABMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private NFFKCCHABON ADMDEPNJPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private LLIKACPEDEN GIOGNGLFHEL;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xD0EE60", Offset = "0xD0D660", VA = "0x180D0EE60", Slot = "6")]
	public void LGHMODLDJCJ(JJPABGBHIHE MIHALFJEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xD0EC90", Offset = "0xD0D490", VA = "0x180D0EC90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xD0ECE0", Offset = "0xD0D4E0", VA = "0x180D0ECE0", Slot = "5")]
	[AsyncStateMachine(typeof(OIIJFANNLAM))]
	public Task GIDPPPFPIMI(string BGKDPPEDMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xD0EE00", Offset = "0xD0D600", VA = "0x180D0EE00", Slot = "4")]
	public BODOEIOLLNF LFBPHAAGBLN(PAEDDAMNHLM OIIALCBDFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xD0EBB0", Offset = "0xD0D3B0", VA = "0x180D0EBB0")]
	private BDPCNNEHEID BNBGEGEDABI(string BGKDPPEDMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ELMKHFJAGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class FGGJBICBPMI
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xD10A70", Offset = "0xD0F270", VA = "0x180D10A70")]
	public static void APCLBGNFBLB(IDLHNLLMOOO IGEIPKGINDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xD10BB0", Offset = "0xD0F3B0", VA = "0x180D10BB0")]
	internal static void CDBOOFGKOBD(IDLHNLLMOOO IGEIPKGINDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0xD10F10", Offset = "0xD0F710", VA = "0x180D10F10")]
	internal static void LHJMFBFHAOP(IDLHNLLMOOO IGEIPKGINDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xD10C50", Offset = "0xD0F450", VA = "0x180D10C50")]
	internal static void HJLMDDNELIF(IDLHNLLMOOO IGEIPKGINDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class LGLBLLGJCPG : global::KGPLAFODKFO<FLDLNHLOABD>
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class KMMCPAIOBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public FLDLNHLOABD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KMMCPAIOBAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xEF27E0", Offset = "0xEF0FE0", VA = "0x180EF27E0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly LGLBLLGJCPG AAMGPJBHPCK;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private const string KINOAEHIPOA = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xEF3B00", Offset = "0xEF2300", VA = "0x180EF3B00")]
	public ExitGames.Client.Photon.Hashtable BAGHAKDDGPK(FLDLNHLOABD MEKFJFMIPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0xEF3EB0", Offset = "0xEF26B0", VA = "0x180EF3EB0", Slot = "5")]
	protected override void MDBECNOKKBH(FLDLNHLOABD MEKFJFMIPGK, IDictionary<object, object> DMDONNOOOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0xEF3CD0", Offset = "0xEF24D0", VA = "0x180EF3CD0", Slot = "6")]
	public override FLDLNHLOABD JDKEMADGCJE(IDictionary<object, object> DMDONNOOOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xEF3B80", Offset = "0xEF2380", VA = "0x180EF3B80")]
	private static void GMHBDKJBFAD(string LJDPEMEGKDC, FLDLNHLOABD MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xEF4360", Offset = "0xEF2B60", VA = "0x180EF4360")]
	public LGLBLLGJCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xEF3FC0", Offset = "0xEF27C0", VA = "0x180EF3FC0")]
	[CompilerGenerated]
	internal static string PAFAHJFOICO(ELHGJICLIED KDGHFFBPFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class AHHKIEFJJMC
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public static BODOEIOLLNF JOAHMPBOFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xCF5BC0", Offset = "0xCF43C0", VA = "0x180CF5BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xCF57A0", Offset = "0xCF3FA0", VA = "0x180CF57A0")]
	public static bool AIMGPCEPJJN(this BODOEIOLLNF BGIHEEBLBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xCF5B60", Offset = "0xCF4360", VA = "0x180CF5B60")]
	public static BODOEIOLLNF FHDLEIMNGLB(EJLPIFDACHN ADEALGGKKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xCF5C20", Offset = "0xCF4420", VA = "0x180CF5C20")]
	public static BODOEIOLLNF OJGCODEKHMB(params BODOEIOLLNF[] MLCCNBGJLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0xCF59C0", Offset = "0xCF41C0", VA = "0x180CF59C0")]
	public static BODOEIOLLNF DIOOLMFAOPE(IEnumerable<BODOEIOLLNF> MLCCNBGJLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xCF57C0", Offset = "0xCF3FC0", VA = "0x180CF57C0")]
	public static string DEJDAEKIGDM(this BODOEIOLLNF FNPLEFBJGJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class IBCJMHIDFOK : APKDJFGLNPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public delegate BODOEIOLLNF JFCICLOIOCC([NotNull] PAEDDAMNHLM CIHPGLOEEKK);

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class AOMPGPPAJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public PAEDDAMNHLM photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public AOMPGPPAJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xD0B110", Offset = "0xD09910", VA = "0x180D0B110")]
		internal BODOEIOLLNF <Validate>b__0(JFCICLOIOCC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	protected readonly HashSet<JFCICLOIOCC> JHCJGGIINFN;

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xD17A90", Offset = "0xD16290", VA = "0x180D17A90", Slot = "4")]
	public void BBDHCACOJJA(JFCICLOIOCC OIOLFNNCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xD17B40", Offset = "0xD16340", VA = "0x180D17B40", Slot = "5")]
	public void EIAAIADGEJG(JFCICLOIOCC OIOLFNNCNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xD17AF0", Offset = "0xD162F0", VA = "0x180D17AF0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xD17BA0", Offset = "0xD163A0", VA = "0x180D17BA0")]
	protected BODOEIOLLNF GNJCPGCEELP(PAEDDAMNHLM APEHHNOOPME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0xD17A20", Offset = "0xD16220", VA = "0x180D17A20")]
	protected IBCJMHIDFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class HPGHFCCCOKA : IBCJMHIDFOK, NALPMPNFLCO, APKDJFGLNPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class BAIEIFGGEDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public BODOEIOLLNF result;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BAIEIFGGEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xD0B140", Offset = "0xD09940", VA = "0x180D0B140")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xD17A20", Offset = "0xD16220", VA = "0x180D17A20")]
	[Preserve]
	public HPGHFCCCOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xD178D0", Offset = "0xD160D0", VA = "0x180D178D0", Slot = "8")]
	public BODOEIOLLNF FGNAPDIKGNB(PAEDDAMNHLM APEHHNOOPME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class JJEJEEFMKJI : IBCJMHIDFOK, DDHLPGNNHOP, APKDJFGLNPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class PIGAACPBJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public BODOEIOLLNF result;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PIGAACPBJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD205B0", Offset = "0xD1EDB0", VA = "0x180D205B0")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xD17A20", Offset = "0xD16220", VA = "0x180D17A20")]
	[Preserve]
	public JJEJEEFMKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xD19B10", Offset = "0xD18310", VA = "0x180D19B10", Slot = "8")]
	public BODOEIOLLNF LFBPHAAGBLN(PAEDDAMNHLM FLAAPIGBEEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum BGGFKIPBNHO
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
internal static class FOOLCCGALIM
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class BEHLNPCGFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public global::FEGLKKODBFL<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BEHLNPCGFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xD0B190", Offset = "0xD09990", VA = "0x180D0B190")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public const string BBFADJEMGFF = "START: ";

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public const string AEIHMDCEFDF = "END: ";

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xD11DD0", Offset = "0xD105D0", VA = "0x180D11DD0")]
	public static global::FEGLKKODBFL<string> BNOEJGFCLCO([Optional] string KCHGMILCNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xD11FB0", Offset = "0xD107B0", VA = "0x180D11FB0")]
	private static void IGPOLDCPPGC(string BAGMDNPKAJL, HBPLIHPAAKF MGJEIEDBIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xD120A0", Offset = "0xD108A0", VA = "0x180D120A0")]
	private static void KOBHAJNHLDF(string BAGMDNPKAJL, HBPLIHPAAKF MGJEIEDBIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xD11E80", Offset = "0xD10680", VA = "0x180D11E80")]
	public static void IGMGGFIBHEK(global::FEGLKKODBFL<string> MGJEIEDBIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xD11D30", Offset = "0xD10530", VA = "0x180D11D30")]
	public static string AOPJHPMGGLP(FLDLNHLOABD JOKEGPNMJNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal static class LBAJGLADJAK
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xEF31E0", Offset = "0xEF19E0", VA = "0x180EF31E0")]
	public static void BCCPCJMHCML(this DEGFMGDGNMF GFGNDDMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xEF32F0", Offset = "0xEF1AF0", VA = "0x180EF32F0")]
	public static void MOKHJCMDJKP(this DEGFMGDGNMF GFGNDDMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xEF31F0", Offset = "0xEF19F0", VA = "0x180EF31F0")]
	private static void JILJDNDMHKM(this DEGFMGDGNMF GFGNDDMLFJA, bool ANOHECLJCEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class KPNCHGCFHEH : BDHGIDIPLCG, FHANKEDBHBD, MOLINOFIHPI, LKPICDJJEKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly FHANKEDBHBD HHEHLODAEJH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public PAEDDAMNHLM PJOHIICJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xEF2DF0", Offset = "0xEF15F0", VA = "0x180EF2DF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int HHDFLCCHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xEF2FA0", Offset = "0xEF17A0", VA = "0x180EF2FA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int LHJLNMCKFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xEF3160", Offset = "0xEF1960", VA = "0x180EF3160", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool LJEGENIPLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int PHJIFIOHGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x606DF0", Offset = "0x6055F0", VA = "0x180606DF0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event JGHLFIIIHAB.PJMNJPAPEPC PEHBDOHCFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event BPIPIKPHANO JFMKINEMLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xEF2FF0", Offset = "0xEF17F0", VA = "0x180EF2FF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xEF2D50", Offset = "0xEF1550", VA = "0x180EF2D50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<bool> MAOHLENJFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<PAEDDAMNHLM> LMIEMPIOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action DINCLLDHCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xEF2EE0", Offset = "0xEF16E0", VA = "0x180EF2EE0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xEF2E40", Offset = "0xEF1640", VA = "0x180EF2E40", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xEF31B0", Offset = "0xEF19B0", VA = "0x180EF31B0")]
	public KPNCHGCFHEH(FHANKEDBHBD HHEHLODAEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xEF2CB0", Offset = "0xEF14B0", VA = "0x180EF2CB0", Slot = "8")]
	public bool FFDNFNBFFMJ(byte NFCNJIFDDME, ExitGames.Client.Photon.Hashtable MGELBFGHLAD, DICHEIDPIBF LGBMEALFEIP, SendOptions EGNODHHDFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0xEF2BB0", Offset = "0xEF13B0", VA = "0x180EF2BB0", Slot = "29")]
	public PAEDDAMNHLM BMOOJIMFEID(int OLELINMEDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xEF3090", Offset = "0xEF1890", VA = "0x180EF3090", Slot = "16")]
	public PAEDDAMNHLM NINHKNJIHIE(int DACPNJCKBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "19")]
	public void KMLPMBEGBEM(object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "20")]
	public void KDEAAOIJNIK(object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "21")]
	public void HKPKBCECGCF(object HMOHICKINOJ, bool JIPKNMJEIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xEF2C50", Offset = "0xEF1450", VA = "0x180EF2C50", Slot = "22")]
	public IDisposable FDDMKFLNFIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "23")]
	private bool ONPBJEAJIFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "24")]
	public void DAPCOIPPELI(StringBuilder KIEIKFMIIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0xEF2F80", Offset = "0xEF1780", VA = "0x180EF2F80", Slot = "25")]
	public bool JOGMKLAHFBJ(bool IKIGMIAIBIN, out string CKOAJFDEIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	public void GNJOFEJLJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2B70", VA = "0x1807D4370", Slot = "28")]
	public void JPIHLNFIGKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct OLAKKHFLMFP
{
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public const string DCIPELFLONJ = "v_result";

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public const string IMEDAFFAFBH = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly IDictionary<object, object> OLHHGMIKFBA;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x607F50", Offset = "0x606750", VA = "0x180607F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
	public OLAKKHFLMFP(IDictionary<object, object> OLHHGMIKFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CF50", Offset = "0x3A0B750", VA = "0x183A0CF50")]
	public bool AMNKILLPPOC(out FLDLNHLOABD MEKFJFMIPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D1E0", Offset = "0x3A0B9E0", VA = "0x183A0D1E0")]
	public Guid ONEGGBAJMEK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D0B0", Offset = "0x3A0B8B0", VA = "0x183A0D0B0")]
	public BODOEIOLLNF KEJIEKLHADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CFE0", Offset = "0x3A0B7E0", VA = "0x183A0CFE0")]
	public static ExitGames.Client.Photon.Hashtable BHNJDAHDLKD(FLDLNHLOABD MEKFJFMIPGK, BODOEIOLLNF BGIHEEBLBFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal static class OGMCFAFBBMN
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C6E0", Offset = "0x3A0AEE0", VA = "0x183A0C6E0")]
	public static string NBJLGHJEHJP(this ECKOOCHDGPJ ONDCGHDIAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C660", Offset = "0x3A0AE60", VA = "0x183A0C660")]
	public static bool MLFCGEGGBKL(this ECKOOCHDGPJ ONDCGHDIAJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct PNMNNPEMEJC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct EIPECMJMPNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public PNMNNPEMEJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x3A08E10", Offset = "0x3A07610", VA = "0x183A08E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly Func<CancellationToken, List<Task>> FOCKGMHDJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly CancellationTokenSource GKPFEEDCFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private Task ACDNGKCJBDE;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3A112F0", Offset = "0x3A0FAF0", VA = "0x183A112F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	internal Task IMLMJLDKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3A11370", Offset = "0x3A0FB70", VA = "0x183A11370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3A113F0", Offset = "0x3A0FBF0", VA = "0x183A113F0")]
	public PNMNNPEMEJC(Func<CancellationToken, List<Task>> FOCKGMHDJOB, CancellationToken NFKHAKHIBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3A111E0", Offset = "0x3A0F9E0", VA = "0x183A111E0")]
	[AsyncStateMachine(typeof(EIPECMJMPNN))]
	public Task BLIDAKABLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3A11320", Offset = "0x3A0FB20", VA = "0x183A11320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public readonly struct FBJFLOBAFCI<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct DLKCDIAAJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder<global::BLBLJBFHAIG<global::GLLICLACNJF<TData>, KCPABLLBBLD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public global::FBJFLOBAFCI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private GBCJCBAKIDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<global::BLBLJBFHAIG<byte[], KCPABLLBBLD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x56333A0", Offset = "0x5631BA0", VA = "0x1856333A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x52E1E70", Offset = "0x52E0670", VA = "0x1852E1E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly global::OMHCLBBNMFF<TGetDataArg, TData> HPGIALJFKFL;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
	internal FBJFLOBAFCI(global::OMHCLBBNMFF<TGetDataArg, TData> GHKOJEPNLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5635C20", Offset = "0x5634420", VA = "0x185635C20")]
	[AsyncStateMachine(typeof(global::FBJFLOBAFCI<, >.DLKCDIAAJIA))]
	public Task<global::BLBLJBFHAIG<global::GLLICLACNJF<TData>, KCPABLLBBLD>> JODPGNAMGND(TGetDataArg OGMKAFPDGJD, string NGNJNMPGJMG, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class FNJGFAJBOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xDA0CE0", Offset = "0xD9F4E0", VA = "0x180DA0CE0")]
	public static global::FBJFLOBAFCI<TGetDataArg, TData> DKPJNJAIMAF<TGetDataArg, TData>(global::OMHCLBBNMFF<TGetDataArg, TData> GHKOJEPNLEK)
	{
		return default(global::FBJFLOBAFCI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class HIBACKCEBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private readonly AODBHOPJCDH JCDAEFBFNKH;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private const string HEPCAFFLCJE = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private const string ILJMDFJMMFO = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private const string GJPJPFCIMIE = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private const string MDPGADJEOFK = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private string FGCJMOHEHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private long? MJFOFEMIOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private long? FPBOKEFOAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private GKODGFHKLNB FDIGCDDAOIC;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string IBBALMGGKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public long KFHKPFPGEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xD14F60", Offset = "0xD13760", VA = "0x180D14F60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public long MAJEMBKGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD13AE0", VA = "0x180D152E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GKODGFHKLNB GIJCPJCCFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x82F600", Offset = "0x82DE00", VA = "0x18082F600")]
		get
		{
			return default(GKODGFHKLNB);
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xD14E80", Offset = "0xD13680", VA = "0x180D14E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xD15330", Offset = "0xD13B30", VA = "0x180D15330")]
	[Preserve]
	public HIBACKCEBKD([EDDGBBNJGJM(null)] AODBHOPJCDH JCDAEFBFNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xD14AE0", Offset = "0xD132E0", VA = "0x180D14AE0")]
	private void AIOIFKINCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xD150A0", Offset = "0xD138A0", VA = "0x180D150A0")]
	public void NPJJFMOCEMO(long OGPGAAKNHEG, long CIPNHNCCGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xD14FB0", Offset = "0xD137B0", VA = "0x180D14FB0")]
	public void NONLDPONHMC(string CHLEFPEEBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xD14C40", Offset = "0xD13440", VA = "0x180D14C40")]
	public void GEKOLAHEGFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class ONHGGFHNMLK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct JMIDLKFOMDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public FLDLNHLOABD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public ONHGGFHNMLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<HJINFOPEKHA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A09B00", Offset = "0x3A08300", VA = "0x183A09B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A09EC0", Offset = "0x3A086C0", VA = "0x183A09EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct LNMKAGIJJIO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class ALGDMLOCECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public FLDLNHLOABD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ALGDMLOCECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A078C0", Offset = "0x3A060C0", VA = "0x183A078C0")]
		internal FLDLNHLOABD <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct FDIGPAMMHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public AsyncTaskMethodBuilder<HJINFOPEKHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public FLDLNHLOABD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public ONHGGFHNMLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private LPPJODCHEDL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter<HJINFOPEKHA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A09000", Offset = "0x3A07800", VA = "0x183A09000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A095E0", Offset = "0x3A07DE0", VA = "0x183A095E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct CENMDHACNBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public ONHGGFHNMLK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3A07B90", Offset = "0x3A06390", VA = "0x183A07B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class MGEONNKECNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public MGEONNKECNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A4C0", Offset = "0x3A08CC0", VA = "0x183A0A4C0")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class BIDBMCFHDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BIDBMCFHDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A079B0", Offset = "0x3A061B0", VA = "0x183A079B0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class EPKJNDIJKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EPKJNDIJKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A08FA0", Offset = "0x3A077A0", VA = "0x183A08FA0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class JAIMGIKMDNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public JAIMGIKMDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A09980", Offset = "0x3A08180", VA = "0x183A09980")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class OOKOIKMJLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public ONHGGFHNMLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public OOKOIKMJLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EC20", Offset = "0x3A0D420", VA = "0x183A0EC20")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class KMGOEHFGJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public ONHGGFHNMLK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KMGOEHFGJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A09F10", Offset = "0x3A08710", VA = "0x183A09F10")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private static readonly Guid IIKJBJMALAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly OGENKHEHHGB PPIANMCPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly DJBLMANHFBO KNLKEAKJLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private readonly MOLINOFIHPI GFGNDDMLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private readonly LKPICDJJEKK BBOGOJAADHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private bool BGFGLOIBDAM;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EA40", Offset = "0x3A0D240", VA = "0x183A0EA40")]
	public ONHGGFHNMLK(OGENKHEHHGB ALMLALCCCIC, DJBLMANHFBO KNLKEAKJLIN, MOLINOFIHPI GFGNDDMLFJA, LKPICDJJEKK BBOGOJAADHB, GBCJCBAKIDH LEEHDEOADOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DD90", Offset = "0x3A0C590", VA = "0x183A0DD90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DA90", Offset = "0x3A0C290", VA = "0x183A0DA90")]
	public void DCEAFOGCJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D960", Offset = "0x3A0C160", VA = "0x183A0D960")]
	public void DAIGJCIPGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D710", Offset = "0x3A0BF10", VA = "0x183A0D710")]
	public void BKCELLBNLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E310", Offset = "0x3A0CB10", VA = "0x183A0E310")]
	[AsyncStateMachine(typeof(JMIDLKFOMDN))]
	internal Task<FLDLNHLOABD> JBACFGOLIHH(GBCJCBAKIDH LEEHDEOADOO, FLDLNHLOABD JOKEGPNMJNF, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0xCFC0C0", Offset = "0xCFA8C0", VA = "0x180CFC0C0")]
	private static byte[] HJGLELIBOBN<T>(T MEKFJFMIPGK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA89A90", Offset = "0xA88290", VA = "0x180A89A90")]
	private static T NCKOEENEEAK<T>(MessageParser<T> IPGAPPINBLO, byte[] MEKFJFMIPGK, T LOJNPGFNJEG) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E8A0", Offset = "0x3A0D0A0", VA = "0x183A0E8A0")]
	[AsyncStateMachine(typeof(FDIGPAMMHPH))]
	private Task<HJINFOPEKHA> PODMBOKAANJ(FLDLNHLOABD JOKEGPNMJNF, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x4F63420", Offset = "0x4F61C20", VA = "0x184F63420")]
	[AsyncStateMachine(typeof(PJOCKDPNDEC))]
	internal Task<T> NLJOPEIDEGA<T>(CancellationToken LAOFPANACHA, Func<CancellationToken, Task<T>> BICOAAOLKFL, int DNBIHEOGKOA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E580", Offset = "0x3A0CD80", VA = "0x183A0E580")]
	[AsyncStateMachine(typeof(CENMDHACNBM))]
	internal Task NLJOPEIDEGA(CancellationToken LAOFPANACHA, Func<CancellationToken, Task> BICOAAOLKFL, int DNBIHEOGKOA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DDF0", Offset = "0x3A0C5F0", VA = "0x183A0DDF0")]
	public FLDLNHLOABD GLNPLBMGGFA(LPPJODCHEDL LOMAJIKEFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E470", Offset = "0x3A0CC70", VA = "0x183A0E470")]
	public AAAHDKKDCOJ KEJKPLGLPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E4E0", Offset = "0x3A0CCE0", VA = "0x183A0E4E0")]
	public BENFDMFLIEJ LJJDNJFLODF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E280", Offset = "0x3A0CA80", VA = "0x183A0E280")]
	public AABFCFIBEHN HIEMCLFHMKP([Optional] HOOPEHCICFL? HLCJGBLMFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E6D0", Offset = "0x3A0CED0", VA = "0x183A0E6D0")]
	public OEBCILAGHDJ NNAKFFMOLLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E550", Offset = "0x3A0CD50", VA = "0x183A0E550")]
	public void NHOFIGPKBCD(Func<Guid, bool> LNGJAMBEIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DC10", Offset = "0x3A0C410", VA = "0x183A0DC10")]
	public void DHKDDGABNBD(Func<Guid, bool> LCKFPGBAACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E120", Offset = "0x3A0C920", VA = "0x183A0E120")]
	public void HHJAAPPMAKD(Func<Guid, bool> LNGJAMBEIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D540", Offset = "0x3A0BD40", VA = "0x183A0D540")]
	public Guid BGFDELMGGBN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E740", Offset = "0x3A0CF40", VA = "0x183A0E740")]
	public void OJNNBJDDHMJ(Guid BCGPNMMPFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D840", Offset = "0x3A0C040", VA = "0x183A0D840")]
	public void BKEAAJKDHKI(FLDLNHLOABD DMOKDBMHGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DE80", Offset = "0x3A0C680", VA = "0x183A0DE80")]
	public void GMHBDKJBFAD(string IPMJKEDJLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DFD0", Offset = "0x3A0C7D0", VA = "0x183A0DFD0")]
	public void GMHBDKJBFAD(Func<string> LFCBEDOAHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xA89A10", Offset = "0xA88210", VA = "0x180A89A10")]
	private T JAMLKDFGDEE<T>(T CJMMBFLIBMO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DDA0", Offset = "0x3A0C5A0", VA = "0x183A0DDA0")]
	public void FMNIHELJPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F63010", Offset = "0x4F61810", VA = "0x184F63010")]
	[CompilerGenerated]
	internal static string GOCHJGINHAH<T>(byte[] FCDIIMLAMIO, int ANBLMAHOAEH, ref LNMKAGIJJIO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal sealed class KIKAHLIANAG : OGENKHEHHGB
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class NKLKCAOPNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NKLKCAOPNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xD1F6C0", Offset = "0xD1DEC0", VA = "0x180D1F6C0")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct NAFMINPOLFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public KIKAHLIANAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private BENFDMFLIEJ <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xD1E8E0", Offset = "0xD1D0E0", VA = "0x180D1E8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class POJOCPOFHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public DEKPEAIDOOF presence;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public POJOCPOFHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xD20CE0", Offset = "0xD1F4E0", VA = "0x180D20CE0")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private readonly ELHGJICLIED NFIODFLMLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private readonly ECKOOCHDGPJ PLPICAMOPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private readonly KCFEBLBCKNI NNLFGMLLEHC;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private const bool OGJEJOJCJCB = false;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xD1C680", Offset = "0xD1AE80", VA = "0x180D1C680")]
	public KIKAHLIANAG(ELHGJICLIED NFIODFLMLJP, ECKOOCHDGPJ PLPICAMOPMC, Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ICLKJDCDBDB HNHFCCLHOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xD1C0E0", Offset = "0xD1A8E0", VA = "0x180D1C0E0", Slot = "8")]
	[AsyncStateMachine(typeof(NAFMINPOLFH))]
	protected override Task BJPGALDELMD(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xD1C360", Offset = "0xD1AB60", VA = "0x180D1C360")]
	private DEKPEAIDOOF MIEMMMNFDNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xD1C220", Offset = "0xD1AA20", VA = "0x180D1C220")]
	private void ENDHMPFCFFG(DEKPEAIDOOF IGBEHLOHMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0xD1C050", Offset = "0xD1A850", VA = "0x180D1C050")]
	private static void BHMLHLPBBLM(ECKOOCHDGPJ ONDCGHDIAJP, [Optional] string MEKFJFMIPGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class AAMKLAGKNIH : OGENKHEHHGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct BAPFIKIKMMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AAMKLAGKNIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<EMNJGNCCDDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6B00", Offset = "0xCF5300", VA = "0x180CF6B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly int JBLNHBNGCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly AIJOAHOCHFA EPGJDCEENKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public readonly long MCEIBEDBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public readonly long PALIHEKPHMC;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xCF3EB0", Offset = "0xCF26B0", VA = "0x180CF3EB0")]
	public AAMKLAGKNIH(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ICLKJDCDBDB HNHFCCLHOBP, int JBLNHBNGCDI, AIJOAHOCHFA EPGJDCEENKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xCF3D70", Offset = "0xCF2570", VA = "0x180CF3D70", Slot = "8")]
	[AsyncStateMachine(typeof(BAPFIKIKMMP))]
	protected override Task BJPGALDELMD(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal abstract class DKKELGHDBDM : OGENKHEHHGB
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private sealed class HKJKEPMJHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public DKKELGHDBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public KIAFCFFEFIG playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HKJKEPMJHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xD157B0", Offset = "0xD13FB0", VA = "0x180D157B0")]
		internal Task <RunAsync>b__0(GBCJCBAKIDH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xD157F0", Offset = "0xD13FF0", VA = "0x180D157F0")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct KEMFDDJIBJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public DKKELGHDBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private HKJKEPMJHIN <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19C20", VA = "0x180D1B420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct ANIADNJBCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public KIAFCFFEFIG playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public DKKELGHDBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xD0AD40", Offset = "0xD09540", VA = "0x180D0AD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xD0C560", Offset = "0xD0AD60", VA = "0x180D0C560")]
	public DKKELGHDBDM(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ICLKJDCDBDB HNHFCCLHOBP, string GLBFJBCOOAO, bool FOOBGLNEDOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xD0C2C0", Offset = "0xD0AAC0", VA = "0x180D0C2C0", Slot = "8")]
	[AsyncStateMachine(typeof(KEMFDDJIBJA))]
	protected override Task BJPGALDELMD(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task OJCPOBHDGAK(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xD0C400", Offset = "0xD0AC00", VA = "0x180D0C400")]
	[AsyncStateMachine(typeof(ANIADNJBCMK))]
	private Task DIAIMENFBPP(IDisposable IFDLCOGOECE, KIAFCFFEFIG HJGOLJKCGGF, GBCJCBAKIDH MGJEIEDBIEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class IODJGPDOJNB : OGENKHEHHGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct ENDKEEEEPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IODJGPDOJNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private OEBCILAGHDJ <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter<JMOBGOJPACL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xD0EFE0", Offset = "0xD0D7E0", VA = "0x180D0EFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly AIJOAHOCHFA EPGJDCEENKE;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xD18520", Offset = "0xD16D20", VA = "0x180D18520")]
	public IODJGPDOJNB(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ICLKJDCDBDB HNHFCCLHOBP, AIJOAHOCHFA EPGJDCEENKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xD18450", Offset = "0xD16C50", VA = "0x180D18450", Slot = "7")]
	protected override string IAEGBNBIIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xD18310", Offset = "0xD16B10", VA = "0x180D18310", Slot = "8")]
	[AsyncStateMachine(typeof(ENDKEEEEPDH))]
	protected override Task BJPGALDELMD(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal abstract class OGENKHEHHGB : KJKGGHJEOPG
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public delegate Task OALMMJCBKDK(GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class OGECHCMJEMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public GBCJCBAKIDH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public OGENKHEHHGB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public OGECHCMJEMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C630", Offset = "0x3A0AE30", VA = "0x183A0C630")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class CDFNCKOJHBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public OGECHCMJEMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public CDFNCKOJHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3A07A10", Offset = "0x3A06210", VA = "0x183A07A10")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3A07AD0", Offset = "0x3A062D0", VA = "0x183A07AD0")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct DFJMJFFGDIN : IAsyncStateMachine
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
		public OGENKHEHHGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<OGENKHEHHGB, GBCJCBAKIDH, ONHGGFHNMLK> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private OGECHCMJEMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private ONHGGFHNMLK <operationContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private TaskAwaiter<FLDLNHLOABD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3A07E00", Offset = "0x3A06600", VA = "0x183A07E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct DILIPKAEKJN : IAsyncStateMachine
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
		public OGENKHEHHGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3A08BD0", Offset = "0x3A073D0", VA = "0x183A08BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public readonly Guid OFJAIPJINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public readonly ByteString KGGNJKHLKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public readonly ICLKJDCDBDB HMPCHMLOKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	protected readonly string IHKOGNMPICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly bool FOOBGLNEDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private bool APJHHBEDKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public GKODGFHKLNB OPOHIBGHHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public GKODGFHKLNB DPIGBPCCJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly Queue<OALMMJCBKDK> JBOODPMMMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly BBGKOPIDFHO KKJNFCGMPIE;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public JJPABGBHIHE BJOECCGPANL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xF02A20", Offset = "0xF01220", VA = "0x180F02A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public BBGMFNGBFGM COLLKCMFALE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xF02710", Offset = "0xF00F10", VA = "0x180F02710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xF02530", Offset = "0xF00D30", VA = "0x180F02530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public float LMHGPJIJACB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xF02800", Offset = "0xF01000", VA = "0x180F02800", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event BNKGINJJLJB IGGAOHPLPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xF027E0", Offset = "0xF00FE0", VA = "0x180F027E0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xF026F0", Offset = "0xF00EF0", VA = "0x180F026F0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xF02C50", Offset = "0xF01450", VA = "0x180F02C50")]
	protected OGENKHEHHGB(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ICLKJDCDBDB HNHFCCLHOBP, string GLBFJBCOOAO, bool FOOBGLNEDOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xF02820", Offset = "0xF01020", VA = "0x180F02820", Slot = "7")]
	protected virtual string IAEGBNBIIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xF029C0", Offset = "0xF011C0", VA = "0x180F029C0")]
	public void LGHAHDLGCAC(OALMMJCBKDK ELNELLFNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xF02860", Offset = "0xF01060", VA = "0x180F02860")]
	protected void JOEFAHJKGCC(float CKNEEGNOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xF025B0", Offset = "0xF00DB0", VA = "0x180F025B0")]
	[AsyncStateMachine(typeof(DFJMJFFGDIN))]
	public Task EOHNKNEAELI(CancellationToken NFKHAKHIBIO, GBCJCBAKIDH LEEHDEOADOO, [Optional] Func<OGENKHEHHGB, GBCJCBAKIDH, ONHGGFHNMLK> MBPIKEFPLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xF02A70", Offset = "0xF01270", VA = "0x180F02A70")]
	private void NLPIILFPNAK(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task BJPGALDELMD(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xF02880", Offset = "0xF01080", VA = "0x180F02880")]
	[AsyncStateMachine(typeof(DILIPKAEKJN))]
	private Task KEKBBCPCPCN(GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xF02760", Offset = "0xF00F60", VA = "0x180F02760")]
	public FLDLNHLOABD GLNPLBMGGFA(LPPJODCHEDL LOMAJIKEFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xF02B80", Offset = "0xF01380", VA = "0x180F02B80")]
	[CompilerGenerated]
	private Task PNDOHJECNFK(CancellationToken JFBIOCFAFEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal sealed class JBGAPGPOPGE : DKKELGHDBDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct ANFHEPOLCMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public JBGAPGPOPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private FFNIJHBKDOK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private BENFDMFLIEJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xD0A7C0", Offset = "0xD08FC0", VA = "0x180D0A7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly ELHGJICLIED BILDCGONMGP;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xD18AA0", Offset = "0xD172A0", VA = "0x180D18AA0")]
	public JBGAPGPOPGE(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ELHGJICLIED BILDCGONMGP, ICLKJDCDBDB HNHFCCLHOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xD18960", Offset = "0xD17160", VA = "0x180D18960", Slot = "9")]
	[AsyncStateMachine(typeof(ANFHEPOLCMB))]
	protected override Task OJCPOBHDGAK(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal class BDPCNNEHEID : OGENKHEHHGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct CHFIMDHPIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public BDPCNNEHEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter<JMOBGOJPACL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xCFB000", Offset = "0xCF9800", VA = "0x180CFB000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly string ENEBEFDCOON;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0xCF80E0", Offset = "0xCF68E0", VA = "0x180CF80E0")]
	public BDPCNNEHEID(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, ICLKJDCDBDB HNHFCCLHOBP, string ENEBEFDCOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xCF7FB0", Offset = "0xCF67B0", VA = "0x180CF7FB0", Slot = "8")]
	[AsyncStateMachine(typeof(CHFIMDHPIHD))]
	protected override Task BJPGALDELMD(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal class BMHEBDODCAC : DKKELGHDBDM
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class LLLNBBKPHAO
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
			public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public LLLNBBKPHAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			private TaskAwaiter<JMOBGOJPACL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			private TaskAwaiter<FLDLNHLOABD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xD085C0", Offset = "0xD06DC0", VA = "0x180D085C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xD08A80", Offset = "0xD07280", VA = "0x180D08A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public BMHEBDODCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AABFCFIBEHN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public AAAHDKKDCOJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public LLLNBBKPHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xD037D0", Offset = "0xD01FD0", VA = "0x180D037D0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FLDLNHLOABD> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct PKKFOECDMHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public BMHEBDODCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private LLLNBBKPHAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private FFNIJHBKDOK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private BENFDMFLIEJ <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xD05A40", Offset = "0xD04240", VA = "0x180D05A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private readonly int KIFKOCHNABH;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xCFA500", Offset = "0xCF8D00", VA = "0x180CFA500")]
	public BMHEBDODCAC(Guid CMBACDFLKJB, JJPABGBHIHE MIHALFJEPMA, int KIFKOCHNABH, ICLKJDCDBDB HNHFCCLHOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xCFA230", Offset = "0xCF8A30", VA = "0x180CFA230", Slot = "9")]
	[AsyncStateMachine(typeof(PKKFOECDMHA))]
	protected override Task OJCPOBHDGAK(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xCFA160", Offset = "0xCF8960", VA = "0x180CFA160")]
	private void EHIOPBFCMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xCFA370", Offset = "0xCF8B70", VA = "0x180CFA370")]
	private void OKABOEDACMK(GBCJCBAKIDH LEEHDEOADOO, FFNIJHBKDOK FBCLJBENIBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal abstract class EFMGOGNFNHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly OGENKHEHHGB PPIANMCPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public readonly ONHGGFHNMLK NJKOAKBOIIH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xD0DD60", Offset = "0xD0C560", VA = "0x180D0DD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xD0DCC0", Offset = "0xD0C4C0", VA = "0x180D0DCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xD0DD80", Offset = "0xD0C580", VA = "0x180D0DD80")]
	protected EFMGOGNFNHO(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xD0DD20", Offset = "0xD0C520", VA = "0x180D0DD20")]
	protected void GMHBDKJBFAD(string IPMJKEDJLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xD0DD40", Offset = "0xD0C540", VA = "0x180D0DD40")]
	public void GMHBDKJBFAD(Func<string> LFCBEDOAHMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal struct FIMMNLFOJAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public Dictionary<Guid, List<KLIBOGFEHGC>> OLJHKNGFGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public Dictionary<Guid, List<KLIBOGFEHGC>> GFFMAHIFIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public Dictionary<Guid, List<KLIBOGFEHGC>> EJAKMPKLCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public List<Guid> HNJLIBMGMOD;

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xD10FB0", Offset = "0xD0F7B0", VA = "0x180D10FB0")]
	public static FIMMNLFOJAN NOBGIOELFLB(AGIPDIHMLDH AGONKCODOEL, GKODGFHKLNB MAJAKDGDAID, INGIBJGEAFA EDFNCIIGFIC)
	{
		return default(FIMMNLFOJAN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal struct KFHMIGGDLEM
{
	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020")]
	public static KFHMIGGDLEM BHNJDAHDLKD()
	{
		return default(KFHMIGGDLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LBMHLHJGPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void BLNBPCLJGHF(INGIBJGEAFA DMDONNOOOJK, object JJHENKMJPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void EGHHPHEMEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct CPBHDEJOBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public readonly EMNJGNCCDDA FAOOOBOGDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public readonly EPGHEIOKHIJ FIKMBCCEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public readonly MIAFMFJHOML KAJJJBBCCND;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xCFC590", Offset = "0xCFAD90", VA = "0x180CFC590")]
	public CPBHDEJOBKM(EMNJGNCCDDA FAOOOBOGDKB, EPGHEIOKHIJ FIKMBCCEGPF, MIAFMFJHOML KAJJJBBCCND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct GGPENMJHDNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly ONHGGFHNMLK JJPHFHBMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly Guid BCGPNMMPFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private bool HGJKFKODICP;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xD13820", Offset = "0xD12020", VA = "0x180D13820")]
	public static GGPENMJHDNN BGFDELMGGBN(ONHGGFHNMLK JJPHFHBMOKI)
	{
		return default(GGPENMJHDNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4B0", Offset = "0x6EACB0", VA = "0x1806EC4B0")]
	public void ANICHKNOLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xD13880", Offset = "0xD12080", VA = "0x180D13880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xD138E0", Offset = "0xD120E0", VA = "0x180D138E0")]
	private GGPENMJHDNN(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xD13880", Offset = "0xD12080", VA = "0x180D13880")]
	private void OJNNBJDDHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xD13770", Offset = "0xD11F70", VA = "0x180D13770")]
	private Func<Guid, bool> ANOFFLFAOJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class BENFDMFLIEJ : EFMGOGNFNHO, KJKGGHJEOPG
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate Task<GKODGFHKLNB> ALFNLBCMAOJ(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM ILJBCACGPGD, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct HBOJGAHHNBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public ELHGJICLIED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private GGPENMJHDNN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xD01610", Offset = "0xCFFE10", VA = "0x180D01610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct DIPCKINIGMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public ELHGJICLIED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private GBCJCBAKIDH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xCFD520", Offset = "0xCFBD20", VA = "0x180CFD520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xCFD7D0", Offset = "0xCFBFD0", VA = "0x180CFD7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct NONFNNMMEMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public ELHGJICLIED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private GBCJCBAKIDH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xD04A70", Offset = "0xD03270", VA = "0x180D04A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class BDMCOGEBECL
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
			public AsyncTaskMethodBuilder<CPBHDEJOBKM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public BDMCOGEBECL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private CPBHDEJOBKM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private TaskAwaiter<GKODGFHKLNB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			private TaskAwaiter<CPBHDEJOBKM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xD06460", Offset = "0xD04C60", VA = "0x180D06460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xD06C50", Offset = "0xD05450", VA = "0x180D06C50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<INGIBJGEAFA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public BDMCOGEBECL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			private INGIBJGEAFA <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			private TaskAwaiter<GKODGFHKLNB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			private TaskAwaiter<INGIBJGEAFA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xD06CA0", Offset = "0xD054A0", VA = "0x180D06CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xD07140", Offset = "0xD05940", VA = "0x180D07140", Slot = "5")]
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
			public BDMCOGEBECL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			private TaskAwaiter<GKODGFHKLNB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			private HBIOIBIAGBM <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD07190", Offset = "0xD05990", VA = "0x180D07190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public ELHGJICLIED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public BBGKOPIDFHO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public BBGKOPIDFHO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public CPBHDEJOBKM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public BBGKOPIDFHO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public INGIBJGEAFA phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public OELINPHFKJM.AHNLAKJHOGK <>9__6;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BDMCOGEBECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xCF7C00", Offset = "0xCF6400", VA = "0x180CF7C00")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task<CPBHDEJOBKM> <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xCF7D20", Offset = "0xCF6520", VA = "0x180CF7D20")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<INGIBJGEAFA> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xCF7F70", Offset = "0xCF6770", VA = "0x180CF7F70")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xCF7E50", Offset = "0xCF6650", VA = "0x180CF7E50")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct MDILFPPJDLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public ELHGJICLIED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private BDMCOGEBECL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private TaskAwaiter<CPBHDEJOBKM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter<INGIBJGEAFA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xD038F0", Offset = "0xD020F0", VA = "0x180D038F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct HKGPNNLKODD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xD01B80", Offset = "0xD00380", VA = "0x180D01B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct MPJMNEIGNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private GBCJCBAKIDH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xD04300", Offset = "0xD02B00", VA = "0x180D04300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct EHOENHFPKIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private GBCJCBAKIDH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private GLDLPIJFECE.EJFCOKHMIDK <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<GLDLPIJFECE.EJFCOKHMIDK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xCFEF10", Offset = "0xCFD710", VA = "0x180CFEF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xCFFB30", Offset = "0xCFE330", VA = "0x180CFFB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct OJIEGPHBCCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public HBIOIBIAGBM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private GBCJCBAKIDH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xD04DB0", Offset = "0xD035B0", VA = "0x180D04DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xD05980", Offset = "0xD04180", VA = "0x180D05980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct AFIDCPDEDIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public GKODGFHKLNB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public INGIBJGEAFA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xCF53C0", Offset = "0xCF3BC0", VA = "0x180CF53C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xCF55A0", Offset = "0xCF3DA0", VA = "0x180CF55A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class CEEEALMNKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public ALFNLBCMAOJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public HBIOIBIAGBM timedYielder;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public CEEEALMNKHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class DLHDCCDKKLP
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
			public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public DLHDCCDKKLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter<GKODGFHKLNB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD08090", Offset = "0xD06890", VA = "0x180D08090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xD08570", Offset = "0xD06D70", VA = "0x180D08570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GKODGFHKLNB originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CEEEALMNKHO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DLHDCCDKKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xCFD870", Offset = "0xCFC070", VA = "0x180CFD870")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GKODGFHKLNB> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct AFFGEBPBIAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public ALFNLBCMAOJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public HBIOIBIAGBM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4F50", Offset = "0xCF3750", VA = "0x180CF4F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xCF5370", Offset = "0xCF3B70", VA = "0x180CF5370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct APNAAGGKGGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public BBGKOPIDFHO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private GKODGFHKLNB <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private IEnumerator<GKODGFHKLNB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xCF65C0", Offset = "0xCF4DC0", VA = "0x180CF65C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct JIEMJKBIPPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xD02860", Offset = "0xD01060", VA = "0x180D02860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct AMGACGMDFKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder<GLDLPIJFECE.EJFCOKHMIDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public BENFDMFLIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private TaskAwaiter<GLDLPIJFECE.EJFCOKHMIDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xCF63E0", Offset = "0xCF4BE0", VA = "0x180CF63E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xCF6570", Offset = "0xCF4D70", VA = "0x180CF6570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class EMOFJGAMPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public EMNJGNCCDDA roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EMOFJGAMPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xCFFB80", Offset = "0xCFE380", VA = "0x180CFFB80")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private readonly MBHEGBJDEAH PDHFLHCHEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly MBHEGBJDEAH MNMFIKIHAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly HIBACKCEBKD INJCHFHHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private readonly GEAAMHBPILK ACCMLKPNAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly HJMHPFFJHJM CJHKKHMLOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly NIJMJBHMJAM KDLJCOABFKB;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float LMHGPJIJACB
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xCF8F30", Offset = "0xCF7730", VA = "0x180CF8F30", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private JJPABGBHIHE BJOECCGPANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xCF2580", Offset = "0xCF0D80", VA = "0x180CF2580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BNKGINJJLJB IGGAOHPLPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xCF8F10", Offset = "0xCF7710", VA = "0x180CF8F10", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xCF8B30", Offset = "0xCF7330", VA = "0x180CF8B30", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xCF98C0", Offset = "0xCF80C0", VA = "0x180CF98C0")]
	public BENFDMFLIEJ(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xCF8480", Offset = "0xCF6C80", VA = "0x180CF8480")]
	[AsyncStateMachine(typeof(HBOJGAHHNBD))]
	public Task DGFMLOKJECH(ELHGJICLIED GMJOOGMAMPH, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xCF9280", Offset = "0xCF7A80", VA = "0x180CF9280")]
	[AsyncStateMachine(typeof(DIPCKINIGMB))]
	private Task<FLDLNHLOABD> MGEEDLOMNNP(ELHGJICLIED GMJOOGMAMPH, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xCF89C0", Offset = "0xCF71C0", VA = "0x180CF89C0")]
	[AsyncStateMachine(typeof(NONFNNMMEMC))]
	private Task EHGHGNMLBJC(ELHGJICLIED GMJOOGMAMPH, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xCF85E0", Offset = "0xCF6DE0", VA = "0x180CF85E0")]
	[AsyncStateMachine(typeof(MDILFPPJDLJ))]
	private Task DPDOEOAMABA(ELHGJICLIED GMJOOGMAMPH, GBCJCBAKIDH LEEHDEOADOO, CancellationToken MPPILNJEBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xCF8DE0", Offset = "0xCF75E0", VA = "0x180CF8DE0")]
	[AsyncStateMachine(typeof(HKGPNNLKODD))]
	private Task HDACFOEFGOL(GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xCF8860", Offset = "0xCF7060", VA = "0x180CF8860")]
	[AsyncStateMachine(typeof(MPJMNEIGNHH))]
	private Task EAIEHKOOHLJ(INGIBJGEAFA DMDONNOOOJK, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xCF8B90", Offset = "0xCF7390", VA = "0x180CF8B90")]
	[AsyncStateMachine(typeof(EHOENHFPKIE))]
	private Task<GKODGFHKLNB> FOPJLGOHHAP(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xCF9550", Offset = "0xCF7D50", VA = "0x180CF9550")]
	[AsyncStateMachine(typeof(OJIEGPHBCCH))]
	private Task<GKODGFHKLNB> NFIACIMNJEL(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xCF93E0", Offset = "0xCF7BE0", VA = "0x180CF93E0")]
	[AsyncStateMachine(typeof(AFIDCPDEDIG))]
	private Task<GKODGFHKLNB> MKFMMMJMDEP(GKODGFHKLNB MAJAKDGDAID, INGIBJGEAFA EDFNCIIGFIC, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO, bool ECCBECPNHCA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xCF8CF0", Offset = "0xCF74F0", VA = "0x180CF8CF0")]
	private bool GHCIOGLEPHM(INGIBJGEAFA IGNJJLGCDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xCF8F50", Offset = "0xCF7750", VA = "0x180CF8F50")]
	[AsyncStateMachine(typeof(AFFGEBPBIAA))]
	protected Task<GKODGFHKLNB> JKPNNMGHFKD(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO, ALFNLBCMAOJ PDAOKFNGCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xCF8180", Offset = "0xCF6980", VA = "0x180CF8180")]
	[AsyncStateMachine(typeof(APNAAGGKGGF))]
	private Task AEOPMHIDBEA(INGIBJGEAFA DMDONNOOOJK, BBGKOPIDFHO FBDENPPKMLD, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xCF9870", Offset = "0xCF8070", VA = "0x180CF9870")]
	private void PNCBNAOHABM(GKODGFHKLNB GBJPMNLBCIC, BBGKOPIDFHO FBDENPPKMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xCF82E0", Offset = "0xCF6AE0", VA = "0x180CF82E0")]
	private void BILJCLHEFKK(GKODGFHKLNB CAKBEMDCGEK, out GKODGFHKLNB DGBLEIBNDMK, out GKODGFHKLNB LDPFCNFLKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xCF8B50", Offset = "0xCF7350", VA = "0x180CF8B50")]
	private Task<CPBHDEJOBKM> FFBPFLGHADM(ELHGJICLIED GMJOOGMAMPH, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0xCF90E0", Offset = "0xCF78E0", VA = "0x180CF90E0")]
	private Task<INGIBJGEAFA> KFJKKIFPPFD(ELHGJICLIED GMJOOGMAMPH, CPBHDEJOBKM DMDONNOOOJK, OELINPHFKJM.AHNLAKJHOGK PMAFMFMHMIH, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xCF9130", Offset = "0xCF7930", VA = "0x180CF9130")]
	[AsyncStateMachine(typeof(JIEMJKBIPPG))]
	private Task MFDBKIPJIIL(INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xCF8330", Offset = "0xCF6B30", VA = "0x180CF8330")]
	[AsyncStateMachine(typeof(AMGACGMDFKB))]
	private Task<GLDLPIJFECE.EJFCOKHMIDK> BLAFBJEMEPN(INGIBJGEAFA DMDONNOOOJK, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xCF96F0", Offset = "0xCF7EF0", VA = "0x180CF96F0")]
	private Task ODKGJHJEKNG(INGIBJGEAFA DMDONNOOOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xCF8460", Offset = "0xCF6C60", VA = "0x180CF8460")]
	private Task CMOMHDMBHHM(INGIBJGEAFA DMDONNOOOJK, GLDLPIJFECE.EJFCOKHMIDK OEDDIOPPMAK, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0xCF8B10", Offset = "0xCF7310", VA = "0x180CF8B10")]
	private Task EIKAELJIDMH(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xCF9720", Offset = "0xCF7F20", VA = "0x180CF9720")]
	private Task PEDHJGJKGGM(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xCF8320", Offset = "0xCF6B20", VA = "0x180CF8320")]
	private static Task BKGAPPLNDLD(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xCF8720", Offset = "0xCF6F20", VA = "0x180CF8720")]
	private Task EAAJLNAGNNO(INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0xCF85C0", Offset = "0xCF6DC0", VA = "0x180CF85C0")]
	private Task DGOKLMLFHMN(INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xCF96C0", Offset = "0xCF7EC0", VA = "0x180CF96C0")]
	private void ODBMCECAAIE(ELHGJICLIED GMJOOGMAMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xCF9740", Offset = "0xCF7F40", VA = "0x180CF9740")]
	private static void PGAHALFCDBL(EMNJGNCCDDA FAOOOBOGDKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal struct GLDLPIJFECE
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public struct EJFCOKHMIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public readonly Dictionary<int, int> DCCLPFKKIEE;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
		public EJFCOKHMIDK(Dictionary<int, int> DCCLPFKKIEE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private GKODGFHKLNB GBJPMNLBCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private INGIBJGEAFA DMDONNOOOJK;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xD13D00", Offset = "0xD12500", VA = "0x180D13D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xD13930", Offset = "0xD12130", VA = "0x180D13930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0xD139B0", Offset = "0xD121B0", VA = "0x180D139B0")]
	public static Task<EJFCOKHMIDK> EOHNKNEAELI(JJPABGBHIHE MIHALFJEPMA, GKODGFHKLNB GBJPMNLBCIC, INGIBJGEAFA DMDONNOOOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0xD13A60", Offset = "0xD12260", VA = "0x180D13A60")]
	private EJFCOKHMIDK EOHNKNEAELI()
	{
		return default(EJFCOKHMIDK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct NMBGMNMOPFO
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFAF30", VA = "0x180EFC730")]
	public static Task EOHNKNEAELI(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal struct JIAACEEOGPP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct PCIJNFMFKMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private GBCJCBAKIDH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xD201C0", Offset = "0xD1E9C0", VA = "0x180D201C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xD199D0", Offset = "0xD181D0", VA = "0x180D199D0")]
	[AsyncStateMachine(typeof(PCIJNFMFKMM))]
	public static Task EOHNKNEAELI(ONHGGFHNMLK JJPHFHBMOKI, INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct INNLDOMMLGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct PKBOMECEKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public HBIOIBIAGBM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private GKODGFHKLNB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private JJPABGBHIHE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private AGIPDIHMLDH <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private List<(PersistenceView, AHPAJNJOLEG)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private AHPAJNJOLEG <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xD20600", Offset = "0xD1EE00", VA = "0x180D20600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0xD17F70", Offset = "0xD16770", VA = "0x180D17F70")]
	[AsyncStateMachine(typeof(PKBOMECEKAJ))]
	public static Task EOHNKNEAELI(ONHGGFHNMLK JJPHFHBMOKI, INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xD180E0", Offset = "0xD168E0", VA = "0x180D180E0")]
	private static void OLGAECBAMEG(PersistenceView FMAOAOODAPP, AHPAJNJOLEG JJHENKMJPFB, INGIBJGEAFA DMDONNOOOJK, GKODGFHKLNB MAJAKDGDAID, bool DEBOGAKKGIB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct NKILIMIENEN
{
	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xEFB6A0", Offset = "0xEF9EA0", VA = "0x180EFB6A0")]
	public static Task EOHNKNEAELI(JJPABGBHIHE MIHALFJEPMA, INGIBJGEAFA DMDONNOOOJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct NOEHLMOHHKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct OCOLCKDCKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public JJPABGBHIHE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xF00730", Offset = "0xEFEF30", VA = "0x180F00730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct BDEPJIAKINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public NOEHLMOHHKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xEE8D70", Offset = "0xEE7570", VA = "0x180EE8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class BOGFJIOOEDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public ODMAECGJINE version;

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
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BOGFJIOOEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xEE9BF0", Offset = "0xEE83F0", VA = "0x180EE9BF0")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xEE9CA0", Offset = "0xEE84A0", VA = "0x180EE9CA0")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private INGIBJGEAFA DMDONNOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private ONHGGFHNMLK JJPHFHBMOKI;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private static readonly ByteString DBLLPPFFDHD;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xF005F0", Offset = "0xEFEDF0", VA = "0x180F005F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private IHMOADMGNIB BPIMBELODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xEFFCC0", Offset = "0xEFE4C0", VA = "0x180EFFCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0xF00460", Offset = "0xEFEC60", VA = "0x180F00460")]
	[AsyncStateMachine(typeof(OCOLCKDCKKJ))]
	public static Task EOHNKNEAELI(JJPABGBHIHE MIHALFJEPMA, GKODGFHKLNB GBJPMNLBCIC, INGIBJGEAFA DMDONNOOOJK, ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0xF00310", Offset = "0xEFEB10", VA = "0x180F00310")]
	[AsyncStateMachine(typeof(BDEPJIAKINK))]
	private Task EOHNKNEAELI(GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0xEFFD40", Offset = "0xEFE540", VA = "0x180EFFD40")]
	private void DPODDLLOOLF([NotNull] NEJKIEIFAPA FKPNHDDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0xF005C0", Offset = "0xEFEDC0", VA = "0x180F005C0")]
	private bool IBGAMHHOCNK(ODMAECGJINE KAGEGNEPBEI, NEJKIEIFAPA FKPNHDDKAKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal struct HOEPLPJGBJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct DNOLALCKHFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder<INGIBJGEAFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public HOEPLPJGBJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public OELINPHFKJM.AHNLAKJHOGK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private GBCJCBAKIDH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<(global::BLBLJBFHAIG<KOKGFIKFHDA, KCPABLLBBLD>, global::BLBLJBFHAIG<global::GLLICLACNJF<NEJKIEIFAPA>, KCPABLLBBLD>, global::BLBLJBFHAIG<global::GLLICLACNJF<BIFGNLLOLID>, KCPABLLBBLD>, global::BLBLJBFHAIG<global::GLLICLACNJF<MDFLADPGILH>, KCPABLLBBLD>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xD0C5A0", Offset = "0xD0ADA0", VA = "0x180D0C5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xD0CD20", Offset = "0xD0B520", VA = "0x180D0CD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct BGECGPMNHFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder<global::BLBLJBFHAIG<KOKGFIKFHDA, KCPABLLBBLD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public GBCJCBAKIDH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public HOEPLPJGBJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public OELINPHFKJM.AHNLAKJHOGK downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private GBCJCBAKIDH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter<global::BLBLJBFHAIG<KOKGFIKFHDA, KCPABLLBBLD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xD0B210", Offset = "0xD09A10", VA = "0x180D0B210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xD0B660", Offset = "0xD09E60", VA = "0x180D0B660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private global::FBJFLOBAFCI<JJEDHNFHCKD, BIFGNLLOLID> JMGGBNANGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private global::FBJFLOBAFCI<JJEDHNFHCKD, NEJKIEIFAPA> FIKMBCCEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private global::FBJFLOBAFCI<long, MDFLADPGILH> NCAPLIAAKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private BJHBJEKPCOG MLAJCONDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private ELHGJICLIED GMJOOGMAMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private EMNJGNCCDDA FAOOOBOGDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EPGHEIOKHIJ GOIAKDPCIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private long EEAAHGCDCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private GBCJCBAKIDH MGJEIEDBIEE;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xD15E90", Offset = "0xD14690", VA = "0x180D15E90")]
	public static Task<INGIBJGEAFA> BOFEIJCMBAA(JJPABGBHIHE MIHALFJEPMA, ELHGJICLIED GMJOOGMAMPH, in CPBHDEJOBKM DMDONNOOOJK, OELINPHFKJM.AHNLAKJHOGK PMAFMFMHMIH, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xD16180", Offset = "0xD14980", VA = "0x180D16180")]
	[AsyncStateMachine(typeof(DNOLALCKHFF))]
	private Task<INGIBJGEAFA> EOHNKNEAELI(OELINPHFKJM.AHNLAKJHOGK PMAFMFMHMIH, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xD15CB0", Offset = "0xD144B0", VA = "0x180D15CB0")]
	private JJEDHNFHCKD ACNIJINECFL(BKEELAJOKFP PAFKHPBFLEL)
	{
		return default(JJEDHNFHCKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0xD15CF0", Offset = "0xD144F0", VA = "0x180D15CF0")]
	[AsyncStateMachine(typeof(BGECGPMNHFK))]
	private Task<global::BLBLJBFHAIG<KOKGFIKFHDA, KCPABLLBBLD>> BJLLFEBFDEG(string LCMKCBJJJGI, long EEAAHGCDCPH, OELINPHFKJM.AHNLAKJHOGK PMAFMFMHMIH, GBCJCBAKIDH KKHJCDIDBLF, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct EHMHECJOPEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct OLDBICMHDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder<CPBHDEJOBKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public EHMHECJOPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private GBCJCBAKIDH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter<CPBHDEJOBKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xD1FDA0", Offset = "0xD1E5A0", VA = "0x180D1FDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xD20170", Offset = "0xD1E970", VA = "0x180D20170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct OFGPKLJMJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<CPBHDEJOBKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public EHMHECJOPEE <>4__this;

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
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter<CPBHDEJOBKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xD1F790", Offset = "0xD1DF90", VA = "0x180D1F790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xD1F960", Offset = "0xD1E160", VA = "0x180D1F960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class HPDCKBOGEHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HPDCKBOGEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x80B2D0", Offset = "0x809AD0", VA = "0x18080B2D0")]
		internal bool <FetchRoomDetails>b__0(EPGHEIOKHIJ sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct GNGIHGJADKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AsyncTaskMethodBuilder<CPBHDEJOBKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AGIPDIHMLDH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private HPDCKBOGEHH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<EMNJGNCCDDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xD14600", Offset = "0xD12E00", VA = "0x180D14600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xD14A40", Offset = "0xD13240", VA = "0x180D14A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private HIBACKCEBKD INJCHFHHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private GBCJCBAKIDH MGJEIEDBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private long OGPGAAKNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private long CIPNHNCCGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private string DOOONLCLGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private JJEDHNFHCKD OLANKJFOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private JJEDHNFHCKD NCEMJJGAKBA;

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0xD0DF40", Offset = "0xD0C740", VA = "0x180D0DF40")]
	public static Task<CPBHDEJOBKM> BOFEIJCMBAA(JJPABGBHIHE MIHALFJEPMA, ELHGJICLIED GMJOOGMAMPH, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0xD0E210", Offset = "0xD0CA10", VA = "0x180D0E210")]
	[AsyncStateMachine(typeof(OLDBICMHDBB))]
	private Task<CPBHDEJOBKM> EOHNKNEAELI(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xD0E4A0", Offset = "0xD0CCA0", VA = "0x180D0E4A0")]
	[AsyncStateMachine(typeof(OFGPKLJMJIO))]
	private Task<CPBHDEJOBKM> FFBPFLGHADM(long OGPGAAKNHEG, long CIPNHNCCGBL, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO, bool IHHKDPGCEOC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xD0E350", Offset = "0xD0CB50", VA = "0x180D0E350")]
	[AsyncStateMachine(typeof(GNGIHGJADKB))]
	public static Task<CPBHDEJOBKM> FFBPFLGHADM(AGIPDIHMLDH AGONKCODOEL, long OGPGAAKNHEG, long CIPNHNCCGBL, CancellationToken NFKHAKHIBIO, GBCJCBAKIDH LEEHDEOADOO, bool IHHKDPGCEOC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0xD0E790", Offset = "0xD0CF90", VA = "0x180D0E790")]
	private void NKBGAPADJNP(EMNJGNCCDDA FAOOOBOGDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xD0E620", Offset = "0xD0CE20", VA = "0x180D0E620")]
	private bool NJJAADMJJJM(CPBHDEJOBKM DMDONNOOOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xD0DDE0", Offset = "0xD0C5E0", VA = "0x180D0DDE0")]
	private void AGKLHFCEIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct KALBIDBFJLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct GCDBKEBBDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public KALBIDBFJLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xD123F0", Offset = "0xD10BF0", VA = "0x180D123F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private const int EFLNKBCLLOB = 20;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private const float KJIGALDJEMG = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private AGIPDIHMLDH AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private INGIBJGEAFA DMDONNOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private GBCJCBAKIDH MGJEIEDBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private float IOJPNPHLOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private float LACMNINCNOM;

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0xD1B160", Offset = "0xD19960", VA = "0x180D1B160")]
	public static Task MGKCNMFKOGC(JJPABGBHIHE MIHALFJEPMA, INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0xD1AEA0", Offset = "0xD196A0", VA = "0x180D1AEA0")]
	[AsyncStateMachine(typeof(GCDBKEBBDMF))]
	public Task EOHNKNEAELI(CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xD1AD30", Offset = "0xD19530", VA = "0x180D1AD30")]
	private static void ENNHOKMCLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0xD1AFE0", Offset = "0xD197E0", VA = "0x180D1AFE0")]
	private void KJFFLBGNKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0xD1AC70", Offset = "0xD19470", VA = "0x180D1AC70")]
	private static float BOGDBMGGKBA(AGIPDIHMLDH AGONKCODOEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xD1AFC0", Offset = "0xD197C0", VA = "0x180D1AFC0")]
	private static float JNCPOJLELKE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal struct MBAPBBMJBLO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct GJOOHJDFEHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public ONHGGFHNMLK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public GLDLPIJFECE.EJFCOKHMIDK mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private OGENKHEHHGB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private JJPABGBHIHE <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private BDHNIFBKCFG.GJHBKPHGNCJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xEED800", Offset = "0xEEC000", VA = "0x180EED800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct MPDHABAEMEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private BJOBBMPOOFA.LPBAIMMIFDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xEF8A80", Offset = "0xEF7280", VA = "0x180EF8A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0xEF6A50", Offset = "0xEF5250", VA = "0x180EF6A50")]
	[AsyncStateMachine(typeof(GJOOHJDFEHG))]
	public static Task EOHNKNEAELI(ONHGGFHNMLK JJPHFHBMOKI, INGIBJGEAFA DMDONNOOOJK, GLDLPIJFECE.EJFCOKHMIDK OEDDIOPPMAK, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xEF69E0", Offset = "0xEF51E0", VA = "0x180EF69E0")]
	private static Task<FLDLNHLOABD> ENDGMMBMFHO(ONHGGFHNMLK JJPHFHBMOKI, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0xEF6900", Offset = "0xEF5100", VA = "0x180EF6900")]
	[AsyncStateMachine(typeof(MPDHABAEMEO))]
	private static Task DAHCGFBOAJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct JDEAKFAJNNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct KPAOCIPEBCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public JDEAKFAJNNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xD1DB60", Offset = "0xD1C360", VA = "0x180D1DB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class NLMCIJGPPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NLMCIJGPPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xD1F720", Offset = "0xD1DF20", VA = "0x180D1F720")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct GMHDCMPGLHN : IAsyncStateMachine
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
		public JDEAKFAJNNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private EHFGLKCIHKF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xD14140", Offset = "0xD12940", VA = "0x180D14140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private bool GPDOGLBHDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private GBCJCBAKIDH MGJEIEDBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private CancellationToken NFKHAKHIBIO;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0xD19180", Offset = "0xD17980", VA = "0x180D19180")]
	public static Task NNJHPPFAGNI(JJPABGBHIHE MIHALFJEPMA, bool GPDOGLBHDIE, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken PPOHMFLFOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xD18F50", Offset = "0xD17750", VA = "0x180D18F50")]
	[AsyncStateMachine(typeof(KPAOCIPEBCK))]
	private Task EOHNKNEAELI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xD19050", Offset = "0xD17850", VA = "0x180D19050")]
	[AsyncStateMachine(typeof(GMHDCMPGLHN))]
	private Task MFEPEJKHALA(bool LIBCDHOBLOC, string ILCPHDDOLOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020")]
	private bool GMOLANIDIBE(bool GPDOGLBHDIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct OLPDCHEPAMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct MBBKLFHBILJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public OLPDCHEPAMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A170", Offset = "0x3A08970", VA = "0x183A0A170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A410", Offset = "0x3A08C10", VA = "0x183A0A410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private sealed class HPHDCBPLDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HPHDCBPLDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A098D0", Offset = "0x3A080D0", VA = "0x183A098D0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct NOIKPKGNAJI : IAsyncStateMachine
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
		public OLPDCHEPAMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private EHFGLKCIHKF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BBB0", Offset = "0x3A0A3B0", VA = "0x183A0BBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C040", Offset = "0x3A0A840", VA = "0x183A0C040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private MIAFMFJHOML LAEHHJAPIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private GBCJCBAKIDH MGJEIEDBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D2A0", Offset = "0x3A0BAA0", VA = "0x183A0D2A0")]
	public static Task<Scene> BDGDMFFAJAI(JJPABGBHIHE MIHALFJEPMA, MIAFMFJHOML JCNCBMBCFNE, GBCJCBAKIDH MGJEIEDBIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D2F0", Offset = "0x3A0BAF0", VA = "0x183A0D2F0")]
	[AsyncStateMachine(typeof(MBBKLFHBILJ))]
	private Task<Scene> EOHNKNEAELI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D410", Offset = "0x3A0BC10", VA = "0x183A0D410")]
	[AsyncStateMachine(typeof(NOIKPKGNAJI))]
	private Task<Scene> MFEPEJKHALA(string ILCPHDDOLOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct HJMHPFFJHJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NBGEEPEDFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public HJMHPFFJHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public GKODGFHKLNB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public INGIBJGEAFA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private GBCJCBAKIDH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<GKODGFHKLNB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xD1EDA0", Offset = "0xD1D5A0", VA = "0x180D1EDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xD1F670", Offset = "0xD1DE70", VA = "0x180D1F670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct FPNJCDKCIJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder<GKODGFHKLNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public HJMHPFFJHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public GKODGFHKLNB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xD12180", Offset = "0xD10980", VA = "0x180D12180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xD123A0", Offset = "0xD10BA0", VA = "0x180D123A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private readonly ONHGGFHNMLK JJPHFHBMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private readonly HIBACKCEBKD INJCHFHHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private readonly GEAAMHBPILK ACCMLKPNAKJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private OGENKHEHHGB PPIANMCPGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xD155C0", Offset = "0xD13DC0", VA = "0x180D155C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0xD15750", Offset = "0xD13F50", VA = "0x180D15750")]
	public HJMHPFFJHJM(ONHGGFHNMLK JJPHFHBMOKI, HIBACKCEBKD INJCHFHHOBG, GEAAMHBPILK ACCMLKPNAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0xD155E0", Offset = "0xD13DE0", VA = "0x180D155E0")]
	[AsyncStateMachine(typeof(NBGEEPEDFCC))]
	public Task<GKODGFHKLNB> LBOPKAICMME(GKODGFHKLNB LNNJOHBPDII, INGIBJGEAFA EDFNCIIGFIC, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO, bool ECCBECPNHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0xD15470", Offset = "0xD13C70", VA = "0x180D15470")]
	[AsyncStateMachine(typeof(FPNJCDKCIJG))]
	private Task<GKODGFHKLNB> HKHBFPLCPJN(GBCJCBAKIDH LEEHDEOADOO, GKODGFHKLNB KCDMBPDEAMJ, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xD15420", Offset = "0xD13C20", VA = "0x180D15420")]
	private bool AOBJFIDJCLG(GKODGFHKLNB LEKOCEFLEPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0xD15450", Offset = "0xD13C50", VA = "0x180D15450")]
	private void GMHBDKJBFAD(string IGABHJPIBIB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct CILOLBLKFGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct JHLGDODPJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public OGENKHEHHGB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public HBIOIBIAGBM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private List<(PersistenceView, AHPAJNJOLEG)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private (PersistenceView, AHPAJNJOLEG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xD023B0", Offset = "0xD00BB0", VA = "0x180D023B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xCFBA10", Offset = "0xCFA210", VA = "0x180CFBA10")]
	[AsyncStateMachine(typeof(JHLGDODPJFH))]
	public static Task EOHNKNEAELI(OGENKHEHHGB ALMLALCCCIC, INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct FEAJOBOODJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct JLPNKKJOMAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public OGENKHEHHGB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public HBIOIBIAGBM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private ODMAECGJINE <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private List<(PersistenceView, AHPAJNJOLEG)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private AHPAJNJOLEG <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xD19DF0", Offset = "0xD185F0", VA = "0x180D19DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0xD10670", Offset = "0xD0EE70", VA = "0x180D10670")]
	[AsyncStateMachine(typeof(JLPNKKJOMAN))]
	public static Task EOHNKNEAELI(OGENKHEHHGB ALMLALCCCIC, INGIBJGEAFA DMDONNOOOJK, HBIOIBIAGBM FCMHHEHIPKF, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct BDHNIFBKCFG
{
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public struct GJHBKPHGNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public List<LMLIDGAMPBL> JDHBDCNDGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public List<AHPAJNJOLEG> MMFOKOLBDHP;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F10", Offset = "0x6C0710", VA = "0x1806C1F10")]
		public GJHBKPHGNCJ(List<LMLIDGAMPBL> JDHBDCNDGCM, List<AHPAJNJOLEG> MMFOKOLBDHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class PAFLKOJLMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public List<LMLIDGAMPBL> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PAFLKOJLMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xD059D0", Offset = "0xD041D0", VA = "0x180D059D0")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private JJPABGBHIHE MIHALFJEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private INGIBJGEAFA DMDONNOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private GLDLPIJFECE.EJFCOKHMIDK OEDDIOPPMAK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private AGIPDIHMLDH FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xCF7770", Offset = "0xCF5F70", VA = "0x180CF7770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xCF7230", Offset = "0xCF5A30", VA = "0x180CF7230")]
	public static GJHBKPHGNCJ EOHNKNEAELI(JJPABGBHIHE MIHALFJEPMA, INGIBJGEAFA DMDONNOOOJK, GLDLPIJFECE.EJFCOKHMIDK OEDDIOPPMAK)
	{
		return default(GJHBKPHGNCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0xCF6FF0", Offset = "0xCF57F0", VA = "0x180CF6FF0")]
	private GJHBKPHGNCJ EOHNKNEAELI()
	{
		return default(GJHBKPHGNCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0xCF72C0", Offset = "0xCF5AC0", VA = "0x180CF72C0")]
	private GJHBKPHGNCJ HBJOJKKJMOG(NEJKIEIFAPA FKPNHDDKAKH, ODMAECGJINE HEGONELKOOO, Dictionary<int, int> JHIJMCPEABF)
	{
		return default(GJHBKPHGNCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0xCF77C0", Offset = "0xCF5FC0", VA = "0x180CF77C0")]
	private GameObject[] MMCPINILALA(List<LMLIDGAMPBL> JDHBDCNDGCM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct NCCDKAFGADM
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class KEGOEMMLOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public BDHNIFBKCFG.GJHBKPHGNCJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KEGOEMMLOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xEF2500", Offset = "0xEF0D00", VA = "0x180EF2500")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class ABIMINOFAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ABIMINOFAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xEE8C20", Offset = "0xEE7420", VA = "0x180EE8C20")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xEF9320", Offset = "0xEF7B20", VA = "0x180EF9320")]
	public static void EOHNKNEAELI(OGENKHEHHGB ALMLALCCCIC, INGIBJGEAFA DMDONNOOOJK, BDHNIFBKCFG.GJHBKPHGNCJ KKEEJGOMPOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class GEAAMHBPILK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct DJIBAKBEGBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public GKODGFHKLNB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public INGIBJGEAFA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xD0BBC0", Offset = "0xD0A3C0", VA = "0x180D0BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class PNPAEOLCAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PNPAEOLCAOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class KDDAOOIGBCO
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
			public KDDAOOIGBCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xD20F60", Offset = "0xD1F760", VA = "0x180D20F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public GBCJCBAKIDH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public PNPAEOLCAOK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KDDAOOIGBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xD1B310", Offset = "0xD19B10", VA = "0x180D1B310")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct KNNOPPKKCON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private KDDAOOIGBCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xD1D740", Offset = "0xD1BF40", VA = "0x180D1D740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct KHDDIOGDCOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private Dictionary<Guid, List<KLIBOGFEHGC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xD1BA60", Offset = "0xD1A260", VA = "0x180D1BA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct HMOIAHIJAGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public GBCJCBAKIDH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private GBCJCBAKIDH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private Dictionary<Guid, List<KLIBOGFEHGC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xD15860", Offset = "0xD14060", VA = "0x180D15860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class EPDCJMJKKIN
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
			public KLIBOGFEHGC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public EPDCJMJKKIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xD20E10", Offset = "0xD1F610", VA = "0x180D20E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CHNBKGFEGDA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public List<KLIBOGFEHGC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EPDCJMJKKIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0DC00", VA = "0x180D0F400")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xD0F580", Offset = "0xD0DD80", VA = "0x180D0F580")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(KLIBOGFEHGC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xD0F4C0", Offset = "0xD0DCC0", VA = "0x180D0F4C0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct BJDFGICODGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CHNBKGFEGDA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public List<KLIBOGFEHGC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EPDCJMJKKIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xD0B6B0", Offset = "0xD09EB0", VA = "0x180D0B6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct LMLKBHGKNPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public GBCJCBAKIDH timer;

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
		[Cpp2IlInjected.Address(RVA = "0xD1E320", Offset = "0xD1CB20", VA = "0x180D1E320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class KOLICBGPFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public KOLICBGPFKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xD1DB00", Offset = "0xD1C300", VA = "0x180D1DB00")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct JGKHAKHILJB : IAsyncStateMachine
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
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public INGIBJGEAFA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xD19600", Offset = "0xD17E00", VA = "0x180D19600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class CLBFDHKADLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public CLBFDHKADLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xD0BB60", Offset = "0xD0A360", VA = "0x180D0BB60")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct JPGMBAPMNGO : IAsyncStateMachine
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
		public GEAAMHBPILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xD1A450", Offset = "0xD18C50", VA = "0x180D1A450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class MPDCGLNBJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public MPDCGLNBJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1D080", VA = "0x180D1E880")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly ONHGGFHNMLK JJPHFHBMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private FIMMNLFOJAN ACCMLKPNAKJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private OGENKHEHHGB PPIANMCPGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xB39990", Offset = "0xB38190", VA = "0x180B39990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
	public GEAAMHBPILK(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0xD12A20", Offset = "0xD11220", VA = "0x180D12A20")]
	[AsyncStateMachine(typeof(DJIBAKBEGBA))]
	public Task EOHNKNEAELI(GKODGFHKLNB MAJAKDGDAID, INGIBJGEAFA EDFNCIIGFIC, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0xD12E00", Offset = "0xD11600", VA = "0x180D12E00")]
	[AsyncStateMachine(typeof(KNNOPPKKCON))]
	private Task HCGHPINGDCN(INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0xD128E0", Offset = "0xD110E0", VA = "0x180D128E0")]
	[AsyncStateMachine(typeof(KHDDIOGDCOG))]
	private Task CDEKIAHLMOI(INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0xD13090", Offset = "0xD11890", VA = "0x180D13090")]
	[AsyncStateMachine(typeof(HMOIAHIJAGK))]
	private Task JOOEGHJIODE(INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xD12F50", Offset = "0xD11750", VA = "0x180D12F50")]
	[AsyncStateMachine(typeof(BJDFGICODGP))]
	private Task JNPHBKPEGHO(Guid EMKAAAJMBLO, List<KLIBOGFEHGC> OIBONPEPNCD, CHNBKGFEGDA DAMICGGEBEH, INGIBJGEAFA DMDONNOOOJK, CancellationToken HMOHICKINOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0xD132C0", Offset = "0xD11AC0", VA = "0x180D132C0")]
	[AsyncStateMachine(typeof(LMLKBHGKNPD))]
	private Task NDFEIJHKHII(INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0xD12B80", Offset = "0xD11380", VA = "0x180D12B80")]
	[AsyncStateMachine(typeof(JGKHAKHILJB))]
	private Task GLLIKHBMINB(Guid ILAGNPKDFHP, INGIBJGEAFA DMDONNOOOJK, GBCJCBAKIDH MGJEIEDBIEE, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0xD135A0", Offset = "0xD11DA0", VA = "0x180D135A0")]
	[AsyncStateMachine(typeof(JPGMBAPMNGO))]
	private Task ODDCDJBIKCO(Guid ILAGNPKDFHP, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0xD12CB0", Offset = "0xD114B0", VA = "0x180D12CB0")]
	private void HBBJKKBEBHA(Guid ILAGNPKDFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0xD131D0", Offset = "0xD119D0", VA = "0x180D131D0")]
	private void MPDLFCALKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0xD13400", Offset = "0xD11C00", VA = "0x180D13400")]
	public Guid NMOEOHNMEPL(GKODGFHKLNB GBJPMNLBCIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0xD12770", Offset = "0xD10F70", VA = "0x180D12770")]
	[CompilerGenerated]
	private object BAIJKHGGKOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public struct JMOBGOJPACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public NEJKIEIFAPA DBCHGPEBOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	public List<string> EFAOKOAKFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public Dictionary<long, int> JODKLCIMALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public string AAMGNIBBGGO;
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class OEBCILAGHDJ : EFMGOGNFNHO
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class JFHHDFPFMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AIJOAHOCHFA autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public JFHHDFPFMOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class IGOLKBCJFNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public JFHHDFPFMOM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public IGOLKBCJFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xEEE910", Offset = "0xEED110", VA = "0x180EEE910")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class PIIPOLKCJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public JFHHDFPFMOM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PIIPOLKCJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xF02EC0", Offset = "0xF016C0", VA = "0x180F02EC0")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class AFLNJLNOPKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AIJOAHOCHFA autosaveType;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public AFLNJLNOPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xEE8CA0", Offset = "0xEE74A0", VA = "0x180EE8CA0")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class PAEBMLHOIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public FileInfo autosaveFile;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PAEBMLHOIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xF02D70", Offset = "0xF01570", VA = "0x180F02D70")]
		internal object <TryReadAutosave>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class HNOEINLINGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HNOEINLINGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xEEE8D0", Offset = "0xEED0D0", VA = "0x180EEE8D0")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class NPJFEHBHOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public FileInfo file;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NPJFEHBHOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xF006C0", Offset = "0xEFEEC0", VA = "0x180F006C0")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class NCCIBALEOAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NCCIBALEOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8070", VA = "0x180EF9870")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private const string LNDLOPFDHLI = "V2";

	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private const int PMLPLBHIDMA = 5;

	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private const string IFGAMPCOKCA = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private const string ODEIIKHLMEN = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private const int PHFJPIHKOEN = 32;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xF02520", Offset = "0xF00D20", VA = "0x180F02520")]
	public OEBCILAGHDJ(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xF01070", Offset = "0xEFF870", VA = "0x180F01070")]
	public bool CCFLMOFMPGP(long CIPNHNCCGBL, JMOBGOJPACL ACODGOCBPLH, AIJOAHOCHFA EPGJDCEENKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xF008A0", Offset = "0xEFF0A0", VA = "0x180F008A0")]
	public static bool AKLNCFDKONA(long CIPNHNCCGBL, AIJOAHOCHFA EPGJDCEENKE, out FileInfo KDJDMODLBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xF00AB0", Offset = "0xEFF2B0", VA = "0x180F00AB0")]
	public bool CAHNBJFMECL(long CIPNHNCCGBL, AIJOAHOCHFA EPGJDCEENKE, out JMOBGOJPACL ACODGOCBPLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0xF01DC0", Offset = "0xF005C0", VA = "0x180F01DC0")]
	private bool JHHCJGFKHLP(FileInfo KDJDMODLBIH, out byte[] FIILGDECLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0xF009D0", Offset = "0xEFF1D0", VA = "0x180F009D0")]
	private static FileInfo BGPJBBPJHGA(long CIPNHNCCGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0xF02450", Offset = "0xF00C50", VA = "0x180F02450")]
	private static FileInfo LCJIKJDHKNG(long CIPNHNCCGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0xF00960", Offset = "0xEFF160", VA = "0x180F00960")]
	private static DirectoryInfo BDDCGJODNEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0xF01A40", Offset = "0xF00240", VA = "0x180F01A40")]
	private void FLFIBJIFLFN(FileInfo AKGNLKJKBFE, NEJKIEIFAPA MLOBKEMPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0xF014E0", Offset = "0xEFFCE0", VA = "0x180F014E0")]
	private void COFGLCKNCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0xF022A0", Offset = "0xF00AA0", VA = "0x180F022A0")]
	public static void JJEFINIANGI(long CIPNHNCCGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0xF019D0", Offset = "0xF001D0", VA = "0x180F019D0")]
	public static bool FJEOOJGDDEM(long CIPNHNCCGBL, out DateTime PFJMOHOCPNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal class AABFCFIBEHN : EFMGOGNFNHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct CEEDLBHCFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AsyncTaskMethodBuilder<JMOBGOJPACL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public AABFCFIBEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public LHOKELIACJN serializeType;

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
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xCFAAB0", Offset = "0xCF92B0", VA = "0x180CFAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xCFAFB0", Offset = "0xCF97B0", VA = "0x180CFAFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class HAEJPEPLOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public LHOKELIACJN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HAEJPEPLOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xD01080", Offset = "0xCFF880", VA = "0x180D01080")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class GMJJKCOGLIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public HAEJPEPLOLI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public GMJJKCOGLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xD00720", Offset = "0xCFEF20", VA = "0x180D00720")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class MKHEGGJGGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public HAEJPEPLOLI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public MKHEGGJGGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xD042C0", Offset = "0xD02AC0", VA = "0x180D042C0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct BPMCNJBGIOP : IAsyncStateMachine
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
		public LHOKELIACJN serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AABFCFIBEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private GMJJKCOGLIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private BJOBBMPOOFA.PDNGDHDLNCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xCFA590", Offset = "0xCF8D90", VA = "0x180CFA590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private readonly HOOPEHCICFL HLCJGBLMFLF;

	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private static readonly TimeSpan MFMNIOONCLN;

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0xCF3900", Offset = "0xCF2100", VA = "0x180CF3900")]
	public AABFCFIBEHN(ONHGGFHNMLK JJPHFHBMOKI, [Optional] HOOPEHCICFL? HLCJGBLMFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0xCF28E0", Offset = "0xCF10E0", VA = "0x180CF28E0")]
	[AsyncStateMachine(typeof(CEEDLBHCFED))]
	public Task<JMOBGOJPACL> BAGHAKDDGPK(long CIPNHNCCGBL, string LCMKCBJJJGI, LHOKELIACJN PNCPGHDFEJM, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0xCF32B0", Offset = "0xCF1AB0", VA = "0x180CF32B0")]
	[AsyncStateMachine(typeof(BPMCNJBGIOP))]
	private Task MPHJKINGJKJ(LHOKELIACJN PNCPGHDFEJM, IEnumerable<PersistenceView> OKCCLIMPMPO, StringBuilder MLICNIHEFAC, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0xCF2D70", Offset = "0xCF1570", VA = "0x180CF2D70")]
	private JMOBGOJPACL MLDINBKMPGL(long CIPNHNCCGBL, string LCMKCBJJJGI, LHOKELIACJN PNCPGHDFEJM, IEnumerable<PersistenceView> OKCCLIMPMPO, StringBuilder MLICNIHEFAC)
	{
		return default(JMOBGOJPACL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0xCF2C30", Offset = "0xCF1430", VA = "0x180CF2C30")]
	private NEJKIEIFAPA FCAGJEHLIIL(long CIPNHNCCGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0xCF2A30", Offset = "0xCF1230", VA = "0x180CF2A30")]
	private void BGHMHEDMJPK(NEJKIEIFAPA EFBKEKKINGG, StringBuilder MLICNIHEFAC, IEnumerable<PersistenceView> OKCCLIMPMPO, in HFAIECHMHDF DEOJEDAGPED, ref NNHNABGBPAO KLOJGKNHGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0xCF3400", Offset = "0xCF1C00", VA = "0x180CF3400")]
	private void NCGAGLFGHHM(NEJKIEIFAPA EFBKEKKINGG, StringBuilder MLICNIHEFAC, PersistenceView FMAOAOODAPP, ref NNHNABGBPAO KLOJGKNHGCC, in HFAIECHMHDF DEOJEDAGPED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class AAAHDKKDCOJ : EFMGOGNFNHO
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class DPOLJICKJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public OKCKDGMKKMD.PBCOMLEPBND roomMetadataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public OKCKDGMKKMD.PBCOMLEPBND roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public DPOLJICKJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xCFE210", Offset = "0xCFCA10", VA = "0x180CFE210")]
		internal object <UploadRoomData>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xCFE290", Offset = "0xCFCA90", VA = "0x180CFE290")]
		internal object <UploadRoomData>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xCFE2E0", Offset = "0xCFCAE0", VA = "0x180CFE2E0")]
		internal object <UploadRoomData>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xCFE350", Offset = "0xCFCB50", VA = "0x180CFE350")]
		internal object <UploadRoomData>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct GOCKNGLNJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder<(OKCKDGMKKMD.PBCOMLEPBND roomMetadataUpload, OKCKDGMKKMD.PBCOMLEPBND roomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public JMOBGOJPACL roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public AAAHDKKDCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private DPOLJICKJKK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private TaskAwaiter<OKCKDGMKKMD.PBCOMLEPBND> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xD00780", Offset = "0xCFEF80", VA = "0x180D00780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xD01030", Offset = "0xCFF830", VA = "0x180D01030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct HBEDOPHCOMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder<EMNJGNCCDDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AAAHDKKDCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public JMOBGOJPACL roomSerializedData;

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
		private TaskAwaiter<(OKCKDGMKKMD.PBCOMLEPBND roomMetadataUpload, OKCKDGMKKMD.PBCOMLEPBND roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter<EMNJGNCCDDA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xD01260", Offset = "0xCFFA60", VA = "0x180D01260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xD015C0", Offset = "0xCFFDC0", VA = "0x180D015C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct LHPAJOAAAHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public AsyncTaskMethodBuilder<MHCAIACOCEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AAAHDKKDCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public JMOBGOJPACL roomSerializedData;

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
		private TaskAwaiter<(OKCKDGMKKMD.PBCOMLEPBND roomMetadataUpload, OKCKDGMKKMD.PBCOMLEPBND roomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter<MHCAIACOCEC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xD02F00", Offset = "0xD01700", VA = "0x180D02F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xD03230", Offset = "0xD01A30", VA = "0x180D03230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class NMNBJNOJFOK
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
			public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public NMNBJNOJFOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			private FLDLNHLOABD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private TaskAwaiter<MHCAIACOCEC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private TaskAwaiter<EMNJGNCCDDA> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private TaskAwaiter<FLDLNHLOABD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0xD08AD0", Offset = "0xD072D0", VA = "0x180D08AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0xD097F0", Offset = "0xD07FF0", VA = "0x180D097F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AAAHDKKDCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public JMOBGOJPACL roomSerializedData;

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
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public NMNBJNOJFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xD04950", Offset = "0xD03150", VA = "0x180D04950")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FLDLNHLOABD> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct IDMEHEBFGFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder<FLDLNHLOABD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AAAHDKKDCOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public JMOBGOJPACL roomSerializedData;

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
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private TaskAwaiter<FLDLNHLOABD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xD02130", Offset = "0xD00930", VA = "0x180D02130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xD02360", Offset = "0xD00B60", VA = "0x180D02360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	private const float DAPPNDILAHJ = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	private readonly KCFEBLBCKNI NNLFGMLLEHC;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private JJPABGBHIHE BJOECCGPANL
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xCF2580", Offset = "0xCF0D80", VA = "0x180CF2580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xCF2850", Offset = "0xCF1050", VA = "0x180CF2850")]
	public AAAHDKKDCOJ(ONHGGFHNMLK JJPHFHBMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xCF25B0", Offset = "0xCF0DB0", VA = "0x180CF25B0")]
	[AsyncStateMachine(typeof(GOCKNGLNJLB))]
	private Task<(OKCKDGMKKMD.PBCOMLEPBND, OKCKDGMKKMD.PBCOMLEPBND)> DKIEBNOCDDG(JMOBGOJPACL ACODGOCBPLH, long OGPGAAKNHEG, long ALMHGEFOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xCF2700", Offset = "0xCF0F00", VA = "0x180CF2700")]
	[AsyncStateMachine(typeof(HBEDOPHCOMH))]
	public Task<EMNJGNCCDDA> JLODAKGIGCA(int KIFKOCHNABH, JMOBGOJPACL ACODGOCBPLH, long OGPGAAKNHEG, long ALMHGEFOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xCF2420", Offset = "0xCF0C20", VA = "0x180CF2420")]
	[AsyncStateMachine(typeof(LHPAJOAAAHG))]
	private Task<MHCAIACOCEC> CKBBCBPPOOA(string FONEAOCGOKH, int KIFKOCHNABH, JMOBGOJPACL ACODGOCBPLH, long OGPGAAKNHEG, long ALMHGEFOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xCF22B0", Offset = "0xCF0AB0", VA = "0x180CF22B0")]
	[AsyncStateMachine(typeof(IDMEHEBFGFM))]
	public Task<FLDLNHLOABD> AHAMKALDHAK(int KIFKOCHNABH, JMOBGOJPACL ACODGOCBPLH, long OGPGAAKNHEG, long ALMHGEFOKBO, GBCJCBAKIDH LEEHDEOADOO, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class KIENNHPIEGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private readonly Guid CMBACDFLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private readonly IONPKFBCCEM FOANOEBINNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private ELHGJICLIED KDGHFFBPFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private int? MKHBEABDIKI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Guid OFJAIPJINJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0xD1BFB0", Offset = "0xD1A7B0", VA = "0x180D1BFB0")]
	public KIENNHPIEGO(IONPKFBCCEM FOANOEBINNJ, [Optional] Guid? CMBACDFLKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0xD1BEC0", Offset = "0xD1A6C0", VA = "0x180D1BEC0")]
	public KIENNHPIEGO HBMNFPKJPKI(ELHGJICLIED KDGHFFBPFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0xD1BEE0", Offset = "0xD1A6E0", VA = "0x180D1BEE0")]
	public FLDLNHLOABD NDLCPNDLJNN(out Guid LHOOKGPAAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0xD1BE40", Offset = "0xD1A640", VA = "0x180D1BE40")]
	public KIENNHPIEGO DMPCCBJLIAK(PAEDDAMNHLM FLAAPIGBEEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public static class JLKIJONADCC
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0xD19C60", Offset = "0xD18460", VA = "0x180D19C60")]
	public static JJEDHNFHCKD BCCDNBGMGKP(this BKEELAJOKFP PAFKHPBFLEL)
	{
		return default(JJEDHNFHCKD);
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
			public EJLPIFDACHN ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public EJLPIFDACHN HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private static EJLPIFDACHN[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private Dictionary<EJLPIFDACHN, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x3A115E0", Offset = "0x3A0FDE0", VA = "0x183A115E0")]
		public bool BOKOFKHEMFK(EJLPIFDACHN ADEALGGKKGL, out ResultConfig BNFFLBNLMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x3A11650", Offset = "0x3A0FE50", VA = "0x183A11650")]
		public ResultConfig GNKFNGLPBAC(EJLPIFDACHN DCONKHDOODL, [Optional] HashSet<EJLPIFDACHN> JANADFCKBOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x3A11BF0", Offset = "0x3A103F0", VA = "0x183A11BF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x3A11740", Offset = "0x3A0FF40", VA = "0x183A11740", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE260", Offset = "0x7BCA60", VA = "0x1807BE260")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200016C")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x3A10200", Offset = "0x3A0EA00", VA = "0x183A10200")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x3A10300", Offset = "0x3A0EB00", VA = "0x183A10300")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
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
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
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
