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
public interface CDBPHCGLHLE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> OLGLFPAEFAO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNOPNOOFEDK(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPDEKPJKEHA(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDJOCAMALHP(object BCOHKLCJCPM, bool DKNDJLELOCP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable LLCFGLIJIKF();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NMJKBFEEDMD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODFCLNJFKOG(StringBuilder OJEPGEHGKAC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NLEGHANDNKL(bool NJEBGFMLALH, [Out] string GILNIHGCEJO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AHPJOCLFKIP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GJMJBLCPJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BEGMDDLDIGJ NBCALOOBIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NMFFODOFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MACBLHOBMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KIOFAJKOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DDAFGHNJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BGODJKNKKPP MOGHIIDHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GCAFNOHGGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BEGMDDLDIGJ, BEGMDDLDIGJ> PNPFNNMOCLK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMELHOGAGGB(KOMJABFENJF MCKMDFNNJAO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool INPDMNHGPPE();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool INHMFGBOAOH(string BIANBBFIDLL, MBOJHINFMMJ GEODFBPMEGO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APAMADKKLCK();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BOIFIKCLNHD(AppSettings FMPNPJBOLNE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BEGMDDLDIGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LOJNJNMNAJC JAAADLOGPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	APJFFHHCIKO FLFANFBALON
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DDAFGHNJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool NMFFODOFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool DCJKFOPBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception PBHFJBNJFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode HJPPMENABJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KOMJABFENJF.AFBMBHBGFGP BMIPLOLEODC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LOJNJNMNAJC, LOJNJNMNAJC> FBADNPBOKDK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FDBOGEMHPDH(object MKMPLOHPJDC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LIJPPFODMDG(object MBBIFIDJAJL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void IEKKBOKFPMC(byte PJPNCJONJKO, int APDDGNGPBHM, object PKEBHPACJJN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface POGCJKDBIKH
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KOMJABFENJF.AFBMBHBGFGP BMIPLOLEODC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event IEKKBOKFPMC JHDCDHPIOEN;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool INHDNGNNGCA(byte PJPNCJONJKO, Hashtable FKGBINBALKL, CDDJOHNBMKA GDLEBELIAJM, SendOptions HDNGIPLBMNP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LLIBCFIKHLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IAGJLFEFIKH NHODNJNBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LHCBPIJCLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int GPHPHBKAMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MMODLFGIEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<IAGJLFEFIKH> EMCHPNFPCDE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	IAGJLFEFIKH ADBFLNGMCIC(int GOLPFJHCONJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HMBFCOMKJMP
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action MAAEFDFGBHO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGLKHBPDKEM();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JMCGIMEIOCB : AHPJOCLFKIP, CDBPHCGLHLE, POGCJKDBIKH, LLIBCFIKHLJ, HMBFCOMKJMP
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int GGJPDMJAIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int CHIIMPIMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float DLBKJMBHNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float KAEODPCLDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KGAABLIFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EEEMGBDNGKJ KFPHJCNDLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MCLNMMHPCGN;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJKOCEHCPAK();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHMEDNAEKND();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BFINDMBMIFC(string FAEBGOKHHIB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EEEMGBDNGKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GJCGMNMBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FADLOEKPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<AGBNAJIJMNE> APLJCFOFAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IDJDJNKKNJJ(Action AFBBAEAINNK, string EIBHBOBMKPH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ABJOFAFMCGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string JLPCAAKOJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 FJKLEJNIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion KONNNOOBJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 LLNDLGHLHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CBGNNGAJKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> BNNMLAHHHFG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72F3D40", Offset = "0x72F2F40", VA = "0x1872F3D40")]
	public object[] ALFLKJHIBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ABJOFAFMCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NNEFJGAFEBG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72F69F0", Offset = "0x72F5BF0", VA = "0x1872F69F0")]
	public static bool MLMMHDMBELH(this AHPJOCLFKIP PJCPNEOGNEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72F6A90", Offset = "0x72F5C90", VA = "0x1872F6A90")]
	public static bool PNDLMLJLNDM(this AHPJOCLFKIP PJCPNEOGNEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class ACJFPAEFJBE : JMCGIMEIOCB, AHPJOCLFKIP, CDBPHCGLHLE, POGCJKDBIKH, LLIBCFIKHLJ, HMBFCOMKJMP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class KKGNOPPOEFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ACJFPAEFJBE KCJGPBGCIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HAOFCOOGPMB;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72F6990", Offset = "0x72F5B90", VA = "0x1872F6990")]
		public KKGNOPPOEFG(ACJFPAEFJBE KCJGPBGCIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72F68F0", Offset = "0x72F5AF0", VA = "0x1872F68F0", Slot = "1")]
		~KKGNOPPOEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72F6860", Offset = "0x72F5A60", VA = "0x1872F6860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x72F6800", Offset = "0x72F5A00", VA = "0x1872F6800")]
		private void BJOENFFMMAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object BAAIAOPODNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object CJGDGOLEFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float DJNJJLBIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float PCCPLOOPDKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool GCAFNOHGGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float CPFPCBCDGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int GGJPDMJAIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int CHIIMPIMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract IAGJLFEFIKH NHODNJNBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LHCBPIJCLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x72F3E50", Offset = "0x72F3050", VA = "0x1872F3E50", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int GPHPHBKAMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int MMODLFGIEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x72F3F60", Offset = "0x72F3160", VA = "0x1872F3F60", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float DLBKJMBHNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE8C840", Offset = "0xE8BA40", VA = "0x180E8C840", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72F4950", Offset = "0x72F3B50", VA = "0x1872F4950", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float KAEODPCLDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE8C830", Offset = "0xE8BA30", VA = "0x180E8C830", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72F5440", Offset = "0x72F4640", VA = "0x1872F5440", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool KGAABLIFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract EEEMGBDNGKJ KFPHJCNDLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool GJMJBLCPJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BEGMDDLDIGJ NBCALOOBIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool NMFFODOFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool MACBLHOBMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool KIOFAJKOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool DDAFGHNJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract BGODJKNKKPP MOGHIIDHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private PNEMCEGHFHA DGAPHIKPJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private PNEMCEGHFHA GBGGLGHAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private JLLOEEHENEE<Func<float>> AMPACHICHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool CJGLHOBHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x14BE4E0", Offset = "0x14BD6E0", VA = "0x1814BE4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool MHGPAHKGANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72F4D30", Offset = "0x72F3F30", VA = "0x1872F4D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool ECEKMMPENNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72F4910", Offset = "0x72F3B10", VA = "0x1872F4910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event KOMJABFENJF.AFBMBHBGFGP BMIPLOLEODC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72F4470", Offset = "0x72F3670", VA = "0x1872F4470", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72F4750", Offset = "0x72F3950", VA = "0x1872F4750", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event IEKKBOKFPMC JHDCDHPIOEN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<IAGJLFEFIKH> EMCHPNFPCDE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<BEGMDDLDIGJ, BEGMDDLDIGJ> PNPFNNMOCLK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> OLGLFPAEFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72F5300", Offset = "0x72F4500", VA = "0x1872F5300", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72F46A0", Offset = "0x72F38A0", VA = "0x1872F46A0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action MCLNMMHPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x72F47C0", Offset = "0x72F39C0", VA = "0x1872F47C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72F3FF0", Offset = "0x72F31F0", VA = "0x1872F3FF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action MAAEFDFGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72F4FF0", Offset = "0x72F41F0", VA = "0x1872F4FF0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72F3EC0", Offset = "0x72F30C0", VA = "0x1872F3EC0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract IAGJLFEFIKH ADBFLNGMCIC(int GOLPFJHCONJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool BOIFIKCLNHD(AppSettings FMPNPJBOLNE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void APAMADKKLCK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool INPDMNHGPPE();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void JLIFJMPMFOG();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool INHDNGNNGCA(byte PJPNCJONJKO, Hashtable FKGBINBALKL, CDDJOHNBMKA GDLEBELIAJM, SendOptions HDNGIPLBMNP);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool INHMFGBOAOH(string BIANBBFIDLL, MBOJHINFMMJ GEODFBPMEGO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void BFINDMBMIFC(string FAEBGOKHHIB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void IMELHOGAGGB(KOMJABFENJF MCKMDFNNJAO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72F5480", Offset = "0x72F4680", VA = "0x1872F5480")]
	protected ACJFPAEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72F4530", Offset = "0x72F3730", VA = "0x1872F4530")]
	public void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72F4C10", Offset = "0x72F3E10", VA = "0x1872F4C10", Slot = "35")]
	public void MDJOCAMALHP(object BCOHKLCJCPM, bool DKNDJLELOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72F4370", Offset = "0x72F3570", VA = "0x1872F4370", Slot = "33")]
	public void DNOPNOOFEDK(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72F4990", Offset = "0x72F3B90", VA = "0x1872F4990", Slot = "34")]
	public void KPDEKPJKEHA(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72F4B80", Offset = "0x72F3D80", VA = "0x1872F4B80", Slot = "36")]
	public IDisposable LLCFGLIJIKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72F4D80", Offset = "0x72F3F80", VA = "0x1872F4D80", Slot = "91")]
	public virtual bool NLEGHANDNKL(bool NJEBGFMLALH, [Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72F41D0", Offset = "0x72F33D0", VA = "0x1872F41D0")]
	private bool DDHNEHFGBNC([Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72F53B0", Offset = "0x72F45B0", VA = "0x1872F53B0")]
	private bool OIBDGGDFCLN([Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72F4FA0", Offset = "0x72F41A0", VA = "0x1872F4FA0", Slot = "37")]
	public bool NMJKBFEEDMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72F5090", Offset = "0x72F4290", VA = "0x1872F5090", Slot = "38")]
	public void ODFCLNJFKOG(StringBuilder OJEPGEHGKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72F49D0", Offset = "0x72F3BD0", VA = "0x1872F49D0")]
	private void LLBFMJCBLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72F4550", Offset = "0x72F3750", VA = "0x1872F4550")]
	private void GKPCKJEFBPA(Func<float> DGMIDNPFMDE, object BCOHKLCJCPM, int ENGJFBPJMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72F45E0", Offset = "0x72F37E0", VA = "0x1872F45E0", Slot = "92")]
	public void GLPJNBHAJCO(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72F4090", Offset = "0x72F3290", VA = "0x1872F4090", Slot = "8")]
	public void CJKOCEHCPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72F4640", Offset = "0x72F3840", VA = "0x1872F4640", Slot = "9")]
	public void HHMEDNAEKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x72F4120", Offset = "0x72F3320", VA = "0x1872F4120")]
	private void CONFIDLIBNK(float HLAGGOKJDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE8C830", Offset = "0xE8BA30", VA = "0x180E8C830")]
	private float AKBGJOBOHHC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xE8C840", Offset = "0xE8BA40", VA = "0x180E8C840")]
	private float OOBNJKEKBHN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72F4860", Offset = "0x72F3A60", VA = "0x1872F4860")]
	private void JMFFPONKOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72F44E0", Offset = "0x72F36E0", VA = "0x1872F44E0", Slot = "55")]
	public void FGLKHBPDKEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class DJOLPDAMHKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string APLDKMPLAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool MDIFKDLINCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool MDLDOHAMHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int NCFJHMOIBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] JIHEOFOPGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte EHBDECHKFPH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random DHMJINPBOPL;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72F6590", Offset = "0x72F5790", VA = "0x1872F6590", Slot = "5")]
	public virtual bool OMMCOLKPIPI(string BGDPBMMEIFE, int JPKKDDIAAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5670", VA = "0x1872F6470", Slot = "6")]
	public virtual bool BPECJMDHHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72F64C0", Offset = "0x72F56C0", VA = "0x1872F64C0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72F6510", Offset = "0x72F5710", VA = "0x1872F6510")]
	protected internal void MDPAGNEJHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72F6660", Offset = "0x72F5860", VA = "0x1872F6660")]
	protected DJOLPDAMHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CEPOLOJIOJD : DJOLPDAMHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket NHDIKJOEGPH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72F60F0", Offset = "0x72F52F0", VA = "0x1872F60F0", Slot = "5")]
	public override bool OMMCOLKPIPI(string BGDPBMMEIFE, int JPKKDDIAAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72F5F00", Offset = "0x72F5100", VA = "0x1872F5F00", Slot = "6")]
	public override bool BPECJMDHHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67BC560", Offset = "0x67BB760", VA = "0x1867BC560", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72F6390", Offset = "0x72F5590", VA = "0x1872F6390")]
	public CEPOLOJIOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OKGLNECGOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string HEAMKNIMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string MDLKLAEFKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string HIINMKMJCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DGKBCIBAHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F5480", Offset = "0x8F4680", VA = "0x1808F5480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x72F6E20", Offset = "0x72F6020", VA = "0x1872F6E20")]
	public OKGLNECGOAI(string PEEENJNCMNA, string IEILKJKDKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72F6C50", Offset = "0x72F5E50", VA = "0x1872F6C50")]
	private void GFJEEGMPIMJ(string NFKMNOGHEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72F6D60", Offset = "0x72F5F60", VA = "0x1872F6D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x72F6B60", Offset = "0x72F5D60", VA = "0x1872F6B60")]
	public string DMMKDCHGBKP(bool DDPHMIKMCLO = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CAFKDHFIAAA
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int KBGELMKHGAD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool IJAFPLEDIBB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int FPCNPCECKON;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int GAFHMIHDGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private OKGLNECGOAI MBMLEOBHOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string GKMLMEDGHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int GLAKPNHDLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int GEFIACPDLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<OKGLNECGOAI> HCPHOFMEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DJOLPDAMHKG KOANPHDHFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> MCGLGOHEEBL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BPECJMDHHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC896C0", Offset = "0xC888C0", VA = "0x180C896C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x72F5E50", Offset = "0x72F5050", VA = "0x1872F5E50")]
	public CAFKDHFIAAA(OKGLNECGOAI MBMLEOBHOHJ, Action<OKGLNECGOAI> KAEGLHEOPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A60", Offset = "0x72F4C60", VA = "0x1872F5A60")]
	public bool HFJDLLOGLKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x72F58E0", Offset = "0x72F4AE0", VA = "0x1872F58E0")]
	public static string FLHLPKGCEGP(string LBKIKFKMAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x72F5600", Offset = "0x72F4800", VA = "0x1872F5600")]
	protected internal void BLLNOJIHHHK(object GCGNIOHLIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x72F5610", Offset = "0x72F4810", VA = "0x1872F5610")]
	protected internal bool DPIIBEJIBNJ()
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
