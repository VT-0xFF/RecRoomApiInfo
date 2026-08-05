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
public interface NFKMAPENCHO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> HGBKINMIAHL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEAMHCEBFOD(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPGOBIPNGHB(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOADNFGAJMG(object HACFGBHNOCC, bool FKNLOMIJIDB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable IGEOGGJAIDD();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LAICFCCOOCP();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CLOBGHOIKCP(StringBuilder MBLHMIPFEED);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JNCCEDINFDA(bool HNPNFFGCLDF, [Out] string LKNDCPLLKMB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EGLACKENGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DLNBFAMDBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	PLGLJNLJNPL JEEDMOPKOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool INKOHKEHJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GCNIMFJKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FACDAFFECDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PEOIFLHKNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LBMPOMDLIJF BOOAJALADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JNFMKNHPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PLGLJNLJNPL, PLGLJNLJNPL> EINEAGKGKLK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFKPCBHNHJG(NLCGHLOHGFI NJKIHEOCFHI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AIOKGDFFMHP();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OEIEIAKFJON(string CCEHOKJHFGK, OMIMNLPFEBN ELDLDGLFLME);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ILOJKOIIEKJ();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AGFHCGFOFEK(AppSettings IDLJPIEJIHO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PLGLJNLJNPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GPOGBFGNHMG OOICNFKCBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	FAMMIJNOIBJ NNNEAEFBODI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PEOIFLHKNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool INKOHKEHJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NNCLGJKIMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception EOJELHEIJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode KJIAGHMNLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NLCGHLOHGFI.MHKLANLDIFM MCGKEAGBOCO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<GPOGBFGNHMG, GPOGBFGNHMG> JKCDOJODDNO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CCGMIKHAJED(object OBIPBFFAILK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void POFDCIIMJEA(object LNOEIODPMFO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CMBGPHLIBJD(byte MEEKNBJKNCI, int MHOPLONLNME, object NEPCFFIOLCP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EDBBGKIFBCP
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NLCGHLOHGFI.MHKLANLDIFM MCGKEAGBOCO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CMBGPHLIBJD NACIKADHIPJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KONLLGNJJDK(byte MEEKNBJKNCI, Hashtable EGFOPBIAGPP, FMNMLIKOHDM CDFMBEECIMO, SendOptions AOEKNNILKFO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BGKAAKEFMJD
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NJGJGBGCLGP ODOCIEIBPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MBABJMLFFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int NOBIPACHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int ACGCAKLNIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<NJGJGBGCLGP> JOICHOMAGLA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	NJGJGBGCLGP HOKBACFMOEN(int JFPAEBMEBNC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BEFKALFKEOD
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action GHECFJOFHON;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBHMKPEJFLI();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JPDCMPIABBH : EGLACKENGIA, NFKMAPENCHO, EDBBGKIFBCP, BGKAAKEFMJD, BEFKALFKEOD
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DEBGLJHMPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int FGOEFEMPJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float GEMLPHNLCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float DNDGFEKADGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CPAEBHBGJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IHPCALANMAA GHBOJCOFEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action NLPAGECEJKA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBNDHHOGAML();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPFPNCEABBH();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FMKIHCKFNDO(string PKNBEJMOAKK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IHPCALANMAA
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MDPEJIDEGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HGFAOJGFKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<KAMCADAEIMP> IPCNCOHDHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PJDDCHDBOFI(Action PGMMJJKKLGH, string LCBHCPECHEM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JEKIGNOIGBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string EEDBDNGPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 FJDJKDCINHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion FJBLNCDHDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 LFPGJKNHFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int NNNBJLNLDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> OPPOIMPDICM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73537F0", Offset = "0x73525F0", VA = "0x1873537F0")]
	public object[] MJNCAABHFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public JEKIGNOIGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FBLJFFFHLJP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7352E50", Offset = "0x7351C50", VA = "0x187352E50")]
	public static bool DLPHGMKCHJO(this EGLACKENGIA EBCAFFDNAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7352D80", Offset = "0x7351B80", VA = "0x187352D80")]
	public static bool CKLHGPLPDPP(this EGLACKENGIA EBCAFFDNAON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class ODNMPFBHBFN : JPDCMPIABBH, EGLACKENGIA, NFKMAPENCHO, EDBBGKIFBCP, BGKAAKEFMJD, BEFKALFKEOD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class PMEGDNOFGKD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ODNMPFBHBFN PBKGJGGGDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BBDDFKFCEGM;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7355BA0", Offset = "0x73549A0", VA = "0x187355BA0")]
		public PMEGDNOFGKD(ODNMPFBHBFN PBKGJGGGDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7355B00", Offset = "0x7354900", VA = "0x187355B00", Slot = "1")]
		~PMEGDNOFGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7355A70", Offset = "0x7354870", VA = "0x187355A70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7355A10", Offset = "0x7354810", VA = "0x187355A10")]
		private void ABPPFDDPANJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object DKHHIJJMIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object ADHEGPDJNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float COAMAAIECBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float IDJODGELHEK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool JNFMKNHPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float PDDICGEEGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int DEBGLJHMPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int FGOEFEMPJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract NJGJGBGCLGP ODOCIEIBPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MBABJMLFFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73552D0", Offset = "0x73540D0", VA = "0x1873552D0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int NOBIPACHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int ACGCAKLNIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7354A60", Offset = "0x7353860", VA = "0x187354A60", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float GEMLPHNLCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xEB2C30", Offset = "0xEB1A30", VA = "0x180EB2C30", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7354150", Offset = "0x7352F50", VA = "0x187354150", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float DNDGFEKADGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xEB2C20", Offset = "0xEB1A20", VA = "0x180EB2C20", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7354810", Offset = "0x7353610", VA = "0x187354810", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool CPAEBHBGJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract IHPCALANMAA GHBOJCOFEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool DLNBFAMDBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract PLGLJNLJNPL JEEDMOPKOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool INKOHKEHJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool GCNIMFJKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool FACDAFFECDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool PEOIFLHKNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract LBMPOMDLIJF BOOAJALADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private LKPBNFNIBPJ LJHDDJMKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private LKPBNFNIBPJ ANHCCLGHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private DICKEMDLJAF<Func<float>> DMGNJOENCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool HOJGEJCAABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x14E4100", Offset = "0x14E2F00", VA = "0x1814E4100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool LOFEHJBDKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7354190", Offset = "0x7352F90", VA = "0x187354190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool BLFIPBLFAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7355340", Offset = "0x7354140", VA = "0x187355340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event NLCGHLOHGFI.MHKLANLDIFM MCGKEAGBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7355260", Offset = "0x7354060", VA = "0x187355260", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7354600", Offset = "0x7353400", VA = "0x187354600", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event CMBGPHLIBJD NACIKADHIPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<NJGJGBGCLGP> JOICHOMAGLA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<PLGLJNLJNPL, PLGLJNLJNPL> EINEAGKGKLK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> HGBKINMIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7354760", Offset = "0x7353560", VA = "0x187354760", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7353F80", Offset = "0x7352D80", VA = "0x187353F80", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action NLPAGECEJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x73549C0", Offset = "0x73537C0", VA = "0x1873549C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7354D00", Offset = "0x7353B00", VA = "0x187354D00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action GHECFJOFHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7354BE0", Offset = "0x73539E0", VA = "0x187354BE0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7355410", Offset = "0x7354210", VA = "0x187355410", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract NJGJGBGCLGP HOKBACFMOEN(int JFPAEBMEBNC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool AGFHCGFOFEK(AppSettings IDLJPIEJIHO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void ILOJKOIIEKJ();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool AIOKGDFFMHP();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void OAAJMMNPGNO();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool KONLLGNJJDK(byte MEEKNBJKNCI, Hashtable EGFOPBIAGPP, FMNMLIKOHDM CDFMBEECIMO, SendOptions AOEKNNILKFO);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool OEIEIAKFJON(string CCEHOKJHFGK, OMIMNLPFEBN ELDLDGLFLME);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void FMKIHCKFNDO(string PKNBEJMOAKK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void PFKPCBHNHJG(NLCGHLOHGFI NJKIHEOCFHI);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73554B0", Offset = "0x73542B0", VA = "0x1873554B0")]
	protected ODNMPFBHBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7354CE0", Offset = "0x7353AE0", VA = "0x187354CE0")]
	public void JEELJGCJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x73548A0", Offset = "0x73536A0", VA = "0x1873548A0", Slot = "35")]
	public void GOADNFGAJMG(object HACFGBHNOCC, bool FKNLOMIJIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7353E80", Offset = "0x7352C80", VA = "0x187353E80", Slot = "33")]
	public void AEAMHCEBFOD(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7354720", Offset = "0x7353520", VA = "0x187354720", Slot = "34")]
	public void DPGOBIPNGHB(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7354AF0", Offset = "0x73538F0", VA = "0x187354AF0", Slot = "36")]
	public IDisposable IGEOGGJAIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7354DA0", Offset = "0x7353BA0", VA = "0x187354DA0", Slot = "91")]
	public virtual bool JNCCEDINFDA(bool HNPNFFGCLDF, [Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7354FC0", Offset = "0x7353DC0", VA = "0x187354FC0")]
	private bool KALEIGOGILF([Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7354030", Offset = "0x7352E30", VA = "0x187354030")]
	private bool AOGPMNFKADB([Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7355160", Offset = "0x7353F60", VA = "0x187355160", Slot = "37")]
	public bool LAICFCCOOCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73541E0", Offset = "0x7352FE0", VA = "0x1873541E0", Slot = "38")]
	public void CLOBGHOIKCP(StringBuilder MBLHMIPFEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7354450", Offset = "0x7353250", VA = "0x187354450")]
	private void CMIIBHFLILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73540C0", Offset = "0x7352EC0", VA = "0x1873540C0")]
	private void BIKLHKMJMCE(Func<float> FKICBHPPNHM, object HACFGBHNOCC, int JHPBGABBKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7354B80", Offset = "0x7353980", VA = "0x187354B80", Slot = "92")]
	public void IKHGFNJECHP(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7355380", Offset = "0x7354180", VA = "0x187355380", Slot = "8")]
	public void PBNDHHOGAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7354C80", Offset = "0x7353A80", VA = "0x187354C80", Slot = "9")]
	public void IPFPNCEABBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x73551B0", Offset = "0x7353FB0", VA = "0x1873551B0")]
	private void LKLEJGLCDKP(float BHBDEJJKCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xEB2C20", Offset = "0xEB1A20", VA = "0x180EB2C20")]
	private float EHNDONMKPMC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xEB2C30", Offset = "0xEB1A30", VA = "0x180EB2C30")]
	private float AGLJCLCDABC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7354670", Offset = "0x7353470", VA = "0x187354670")]
	private void DKHPHFCANEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7354850", Offset = "0x7353650", VA = "0x187354850", Slot = "55")]
	public void FBHMKPEJFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class EMBFGDADOIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string KDALJJKPBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool KFKMFJKKGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool CFNFGJOOOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int PJPKPHDDEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] NEHBMCNCNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte GJMGHAFAGKE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random LGJDIMDJCID;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7352AE0", Offset = "0x73518E0", VA = "0x187352AE0", Slot = "5")]
	public virtual bool BFLCJBHICIH(string JKCKPLLPLGJ, int BDPAHNFLHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7352C00", Offset = "0x7351A00", VA = "0x187352C00", Slot = "6")]
	public virtual bool LLANLDALKCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7352B30", Offset = "0x7351930", VA = "0x187352B30", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7352B80", Offset = "0x7351980", VA = "0x187352B80")]
	protected internal void EODJIAICOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7352CD0", Offset = "0x7351AD0", VA = "0x187352CD0")]
	protected EMBFGDADOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LADCBBBIFCP : EMBFGDADOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket OJKOJFJEIAI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7353910", Offset = "0x7352710", VA = "0x187353910", Slot = "5")]
	public override bool BFLCJBHICIH(string JKCKPLLPLGJ, int BDPAHNFLHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7353BB0", Offset = "0x73529B0", VA = "0x187353BB0", Slot = "6")]
	public override bool LLANLDALKCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68174C0", Offset = "0x68162C0", VA = "0x1868174C0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7353DA0", Offset = "0x7352BA0", VA = "0x187353DA0")]
	public LADCBBBIFCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ODODCENHNGB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string JNFIGJDPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LJPKMFMNGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string LGHIEFHNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JNDLDJPAEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F00", Offset = "0x8F7D00", VA = "0x1808F8F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x73558F0", Offset = "0x73546F0", VA = "0x1873558F0")]
	public ODODCENHNGB(string KAKBGJICBGD, string FPFPCKOIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7355630", Offset = "0x7354430", VA = "0x187355630")]
	private void AGFLEDFEBPM(string FPDKDBAJAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7355830", Offset = "0x7354630", VA = "0x187355830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7355740", Offset = "0x7354540", VA = "0x187355740")]
	public string INKKNBGKIKF(bool JPNBAIJMBEK = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HFBHHFHNLIG
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int KLBDIDFOKBC;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool JEMBJFJADMF;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int NEACGMGOKFG;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int KJJALPMHBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ODODCENHNGB BAMKNBDAFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string LFPLJDALJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int BLIHJHOHKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int EIJPKKBDLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<ODODCENHNGB> BLFHHNDIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EMBFGDADOIH HNECKCJDJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> DJDEPMDMHCA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LLANLDALKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCA1EC0", Offset = "0xCA0CC0", VA = "0x180CA1EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7353740", Offset = "0x7352540", VA = "0x187353740")]
	public HFBHHFHNLIG(ODODCENHNGB BAMKNBDAFCP, Action<ODODCENHNGB> OMKHLKLHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7353350", Offset = "0x7352150", VA = "0x187353350")]
	public bool ODCOABNFDHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x73531D0", Offset = "0x7351FD0", VA = "0x1873531D0")]
	public static string KFJJBLLBBDN(string LFBCECDNJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7352EF0", Offset = "0x7351CF0", VA = "0x187352EF0")]
	protected internal void FFABHJAOEFD(object MOBMLKIIAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7352F00", Offset = "0x7351D00", VA = "0x187352F00")]
	protected internal bool GMMGNEPKOGI()
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
