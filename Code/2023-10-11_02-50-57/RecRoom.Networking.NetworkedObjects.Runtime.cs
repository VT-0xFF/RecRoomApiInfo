using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Photon.Realtime;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JMDAMOBEHID
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> KMDAFAKJCDI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHIEEAFDEJE(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPIKLCEODHH(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKLLCCIDMFN(object PFKLELGAJPH, bool DDKNJMGKMPM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable NFMKBKOKHKD();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ACPAFJJMEHE();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DNMKAONGKLJ(StringBuilder LPFHFPGIEGO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FIPALBKICAG(bool MKKCDFIJKDO, [Out] string OGJCCLJIEPL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BEIEMBCBEFA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BKJCFCJMMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BBFAKJLEKHA BACMKAPADAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ILOPJHKLGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AGCHICFABOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EBEKFFKJDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EECGDDFPLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FCCGMLGHBNE MCFFHOFEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IBKPKGECCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BBFAKJLEKHA, BBFAKJLEKHA> MJNFGKFIMNF;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDLGECMAFLB(EOPPKIODIMF FEFGEMMIDHA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NICDCCNGODC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JKOMBJODBIH(string MHJFEEAGOHI, CDLGMHJFBBB CFGGKBMLKPO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPOEFNEJNLC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DJMJOMMIFJM(AppSettings EKMELDDDCKA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BBFAKJLEKHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ACLLFEONKJF OGFMEBBJKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	DELCINEMJGG EFGIHOJLDJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EECGDDFPLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ILOPJHKLGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool LKLFFJGHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception LPLKCBBFLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode AAFOGAKOOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EOPPKIODIMF.FCAKINKLHOM JJBENDJDPML;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ACLLFEONKJF, ACLLFEONKJF> PJFLPCNBJDL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ACBBHNPFCMH(object CJKEIGLKDDB);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IMPMHGJHKAA(object KIKOJBNCNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GCAPAOHNDMB(byte OPIMKOAPDOI, int NPLAPBCLCFM, object EMJLGCDONIE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GHCFFFCCPAE
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EOPPKIODIMF.FCAKINKLHOM JJBENDJDPML;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GCAPAOHNDMB KFIPJGHALGD;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDFFCGCNEDP(byte OPIMKOAPDOI, Hashtable FFOIGEOGBJH, BDONCGAFLKA EBIOMDMHKBK, SendOptions HMBMMIMDAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BLELPEGOKKC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GHMIEPPMENM ICKPDINPLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int BDCAOOMOBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int DCHGMEPNAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool NKIKMACLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int FONCDJKLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<GHMIEPPMENM> KBINCECGFOB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	GHMIEPPMENM CPCECHHEDNN(int COFHGJDOHCE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BMHKDAKICGN
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action ECLPOEBMDLL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOIHKDCHMKO();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HEJEKJPNGFL : BEIEMBCBEFA, JMDAMOBEHID, GHCFFFCCPAE, BLELPEGOKKC, BMHKDAKICGN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int BHIMKOCFLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int GDGGMDFCJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float ALLNEDJBKFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float ONICEHNFJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BNIADIENMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EMIJCANOCAJ DNAGJNNACDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action LJJNGGIPOEI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEFDMEBACNL();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECNCEGEGDFL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FBHELFAKGND(string PGNPLNEAIOE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EMIJCANOCAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool KBFGAHKAFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EMLGKBLKNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<JKELGGJFJDE> EPOJCIHBKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OEJNJLBGDBO(Action MCHFLDODOFI, string BPFIPENDNHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EDEFDKFJHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string BHEJALKFKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 BADBABAFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion HBLKKLKOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 LCMNAFCGPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KGDAHHKFCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> CMADPEOJIMF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CDE0", Offset = "0x5D2BBE0", VA = "0x185D2CDE0")]
	public object[] ILILBLLOPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EDEFDKFJHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BMIOFKKOCNA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C0D0", Offset = "0x5D2AED0", VA = "0x185D2C0D0")]
	public static bool EGBBONGJOIC(this BEIEMBCBEFA DEPFOGEAMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C170", Offset = "0x5D2AF70", VA = "0x185D2C170")]
	public static bool HKLOEIDPPKK(this BEIEMBCBEFA DEPFOGEAMGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class ILLOPELHBIH : HEJEKJPNGFL, BEIEMBCBEFA, JMDAMOBEHID, GHCFFFCCPAE, BLELPEGOKKC, BMHKDAKICGN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class BEOMFGMGBAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ILLOPELHBIH DHKDGJKANME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool GIDFIEECIAK;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C070", Offset = "0x5D2AE70", VA = "0x185D2C070")]
		public BEOMFGMGBAH(ILLOPELHBIH DHKDGJKANME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BFD0", Offset = "0x5D2ADD0", VA = "0x185D2BFD0", Slot = "1")]
		~BEOMFGMGBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BEE0", Offset = "0x5D2ACE0", VA = "0x185D2BEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BF70", Offset = "0x5D2AD70", VA = "0x185D2BF70")]
		private void EGDCDGMNLGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object AOPLCNIPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object EECGCIFMMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float HAGJFFJOHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float AJOCICADEJA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool IBKPKGECCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float FLALOIPIJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int BHIMKOCFLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int GDGGMDFCJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract GHMIEPPMENM ICKPDINPLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BDCAOOMOBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E020", Offset = "0x5D2CE20", VA = "0x185D2E020", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int DCHGMEPNAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int FONCDJKLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool NKIKMACLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D740", Offset = "0x5D2C540", VA = "0x185D2D740", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float ALLNEDJBKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AF0", Offset = "0x7AF8F0", VA = "0x1807B0AF0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D7D0", Offset = "0x5D2C5D0", VA = "0x185D2D7D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float ONICEHNFJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B0400", Offset = "0x7AF200", VA = "0x1807B0400", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E400", Offset = "0x5D2D200", VA = "0x185D2E400", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool BNIADIENMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract EMIJCANOCAJ DNAGJNNACDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool BKJCFCJMMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BBFAKJLEKHA BACMKAPADAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool ILOPJHKLGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool AGCHICFABOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool EBEKFFKJDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool EECGDDFPLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract FCCGMLGHBNE MCFFHOFEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private IBKPFCNCMON BLGFJOMOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private IBKPFCNCMON LACKDIEOLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private LDDBEDPPGDC<Func<float>> AHCFHNEEINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool CNPEMGGMKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB60DD0", Offset = "0xB5FBD0", VA = "0x180B60DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool JGGFIMEGOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E5E0", Offset = "0x5D2D3E0", VA = "0x185D2E5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool FIOLDCOBMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DFE0", Offset = "0x5D2CDE0", VA = "0x185D2DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event EOPPKIODIMF.FCAKINKLHOM JJBENDJDPML
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2EB20", Offset = "0x5D2D920", VA = "0x185D2EB20", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DED0", Offset = "0x5D2CCD0", VA = "0x185D2DED0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event GCAPAOHNDMB KFIPJGHALGD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<GHMIEPPMENM> KBINCECGFOB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<BBFAKJLEKHA, BBFAKJLEKHA> MJNFGKFIMNF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> KMDAFAKJCDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E480", Offset = "0x5D2D280", VA = "0x185D2E480", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E530", Offset = "0x5D2D330", VA = "0x185D2E530", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action LJJNGGIPOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D810", Offset = "0x5D2C610", VA = "0x185D2D810", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E1B0", Offset = "0x5D2CFB0", VA = "0x185D2E1B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action ECLPOEBMDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D5A0", Offset = "0x5D2C3A0", VA = "0x185D2D5A0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DF40", Offset = "0x5D2CD40", VA = "0x185D2DF40", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract GHMIEPPMENM CPCECHHEDNN(int COFHGJDOHCE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool DJMJOMMIFJM(AppSettings EKMELDDDCKA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void JPOEFNEJNLC();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool NICDCCNGODC();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void CJDHCJCIEGP();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool GDFFCGCNEDP(byte OPIMKOAPDOI, Hashtable FFOIGEOGBJH, BDONCGAFLKA EBIOMDMHKBK, SendOptions HMBMMIMDAKG);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool JKOMBJODBIH(string MHJFEEAGOHI, CDLGMHJFBBB CFGGKBMLKPO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void FBHELFAKGND(string PGNPLNEAIOE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void DDLGECMAFLB(EOPPKIODIMF FEFGEMMIDHA);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EB90", Offset = "0x5D2D990", VA = "0x185D2EB90")]
	protected ILLOPELHBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E880", Offset = "0x5D2D680", VA = "0x185D2E880")]
	public void OOCIGOIJKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DDB0", Offset = "0x5D2CBB0", VA = "0x185D2DDB0", Slot = "35")]
	public void GKLLCCIDMFN(object PFKLELGAJPH, bool DDKNJMGKMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D640", Offset = "0x5D2C440", VA = "0x185D2D640", Slot = "33")]
	public void BHIEEAFDEJE(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E440", Offset = "0x5D2D240", VA = "0x185D2E440", Slot = "34")]
	public void LPIKLCEODHH(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E690", Offset = "0x5D2D490", VA = "0x185D2E690", Slot = "36")]
	public IDisposable NFMKBKOKHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DB90", Offset = "0x5D2C990", VA = "0x185D2DB90", Slot = "91")]
	public virtual bool FIPALBKICAG(bool MKKCDFIJKDO, [Out] string OGJCCLJIEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E8F0", Offset = "0x5D2D6F0", VA = "0x185D2E8F0")]
	private bool PAHMFFCAJGL([Out] string OGJCCLJIEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E120", Offset = "0x5D2CF20", VA = "0x185D2E120")]
	private bool INFOLDJNJFA([Out] string OGJCCLJIEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D550", Offset = "0x5D2C350", VA = "0x185D2D550", Slot = "37")]
	public bool ACPAFJJMEHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D8B0", Offset = "0x5D2C6B0", VA = "0x185D2D8B0", Slot = "38")]
	public void DNMKAONGKLJ(StringBuilder LPFHFPGIEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E250", Offset = "0x5D2D050", VA = "0x185D2E250")]
	private void KLECFJFMBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E090", Offset = "0x5D2CE90", VA = "0x185D2E090")]
	private void IFDJBOIGMLO(Func<float> JFIGGPLNGHM, object PFKLELGAJPH, int HNKBNELEHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E630", Offset = "0x5D2D430", VA = "0x185D2E630", Slot = "92")]
	public void MOBBCEAPDCK(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EA90", Offset = "0x5D2D890", VA = "0x185D2EA90", Slot = "8")]
	public void PEFDMEBACNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DB30", Offset = "0x5D2C930", VA = "0x185D2DB30", Slot = "9")]
	public void ECNCEGEGDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E7D0", Offset = "0x5D2D5D0", VA = "0x185D2E7D0")]
	private void NNELKONEJCH(float FFFIPJLIDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B0400", Offset = "0x7AF200", VA = "0x1807B0400")]
	private float GMLFFFJOEEK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B0AF0", Offset = "0x7AF8F0", VA = "0x1807B0AF0")]
	private float IKNJBPEBCPA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E720", Offset = "0x5D2D520", VA = "0x185D2E720")]
	private void NHJLAOCIHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E8A0", Offset = "0x5D2D6A0", VA = "0x185D2E8A0", Slot = "55")]
	public void OOIHKDCHMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class CIOIAOCBPBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string AEEDACHIINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool JNHDEMNCDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool KNAHBPNDBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int CFMFPPKAOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] BPFAJMDMMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte AKLHHOHHIHN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random ILFCDJBALEK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C290", Offset = "0x5D2B090", VA = "0x185D2C290", Slot = "5")]
	public virtual bool DIDLJGPLFBE(string CJPLAMAPEGA, int KGKODGAMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C240", Offset = "0x5D2B040", VA = "0x185D2C240", Slot = "6")]
	public virtual bool BJEGLCAODJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C2E0", Offset = "0x5D2B0E0", VA = "0x185D2C2E0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C330", Offset = "0x5D2B130", VA = "0x185D2C330")]
	protected internal void PCPNMJLBOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C430", Offset = "0x5D2B230", VA = "0x185D2C430")]
	protected CIOIAOCBPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ELLMBLFOEPP : CIOIAOCBPBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket HMIAMBJCBPB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D0E0", Offset = "0x5D2BEE0", VA = "0x185D2D0E0", Slot = "5")]
	public override bool DIDLJGPLFBE(string CJPLAMAPEGA, int KGKODGAMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CEF0", Offset = "0x5D2BCF0", VA = "0x185D2CEF0", Slot = "6")]
	public override bool BJEGLCAODJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x54412E0", Offset = "0x54400E0", VA = "0x1854412E0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D380", Offset = "0x5D2C180", VA = "0x185D2D380")]
	public ELLMBLFOEPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AANNBFLKEPB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string BILDFDPJPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FIBHOBMNNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string BHHGCBHPMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DNNFPHKOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x761620", Offset = "0x760420", VA = "0x180761620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x761690", Offset = "0x760490", VA = "0x180761690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BDC0", Offset = "0x5D2ABC0", VA = "0x185D2BDC0")]
	public AANNBFLKEPB(string BNPNMCOOHLL, string PFMIOMCOICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BB00", Offset = "0x5D2A900", VA = "0x185D2BB00")]
	private void BJCKKEINAAJ(string EKEOJHNLBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BD00", Offset = "0x5D2AB00", VA = "0x185D2BD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BC10", Offset = "0x5D2AA10", VA = "0x185D2BC10")]
	public string LGDKNCIGGNO(bool KCPEBEJHPKH = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EBBMNMFMECH
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int CEAILKJCBPB;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool IECLHGJDLBJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int EDEONGFDIMK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int PNCCKOLCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private AANNBFLKEPB EMCPAKDKIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string LDBHCGDPPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int AAHPHDAAAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int FHODGICLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<AANNBFLKEPB> AOMFDEHNHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private CIOIAOCBPBO KCLNGHFEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> HHFPIOCODPD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BJEGLCAODJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FBB80", VA = "0x1807FCD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x869AB0", Offset = "0x8688B0", VA = "0x180869AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CD30", Offset = "0x5D2BB30", VA = "0x185D2CD30")]
	public EBBMNMFMECH(AANNBFLKEPB EMCPAKDKIFL, Action<AANNBFLKEPB> KAELNLCLPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C7C0", Offset = "0x5D2B5C0", VA = "0x185D2C7C0")]
	public bool JPHPMPIIOOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CB30", Offset = "0x5D2B930", VA = "0x185D2CB30")]
	public static string OJELHFIJBEO(string KIKADDBOFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C7B0", Offset = "0x5D2B5B0", VA = "0x185D2C7B0")]
	protected internal void COBOMGFNMAJ(object GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C4E0", Offset = "0x5D2B2E0", VA = "0x185D2C4E0")]
	protected internal bool ANJFPJGFDMC()
	{
		return default(bool);
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
