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
public interface BGIOCIOCADB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> OFCEJMOFHFF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPIODHEIBKI(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELGDMGMCKPN(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNGMKLOJJHK(object KJCAGLABEME, bool ICDAOHGNDMF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable LKOJIGIDBEE();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NNDDDCANJMN();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIIMAEKKOHE(StringBuilder COMKMCNLPDA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IAJOCIDEMNP(bool JPBGPOKLJDG, [Out] string GNLAGDDNMDN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OKFOKGPABIB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FBBBKCAAKGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HHIFPDBOHIH OPIOEPPDJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BHGOIGFPCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IIOGJBHDELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PCJLFJCPLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JOLCBNAPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HJOHLDGIDBL MBIEOJAAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IBGDKMLKLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HHIFPDBOHIH, HHIFPDBOHIH> MEEJLHGKBGM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGOHBIHLIOH(GFGOKJGFKNB ONMDLMOBIJP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FOACKALFCMF();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IOBCLGEABCI(string OBOHBOPNAFA, GNMCJCLJONI FGJHGAGHLFG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EKILCNCBKEG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JDOOGAEBKBK(AppSettings HEBDLEEMKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HHIFPDBOHIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CNMBPIENGKM EMOPGBKNPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	HGMEBKKACIC OIEPAAABEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JOLCBNAPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool BHGOIGFPCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CDOGNDOJMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception JPDEJJJKKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode MNAAMIIHFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GFGOKJGFKNB.LBAPCKNAEGH BKJPJOHFAMG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CNMBPIENGKM, CNMBPIENGKM> LCNPLNBODIA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FIDEAEHBPID(object JIGKIEPHJOJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKGIBBMIFML(object LKLBJIOPHEP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KBAOIMPCIPA(byte LBOCMPDCIBH, int JLOFEEBANCN, object DCCNFPKPNFP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IKLBHHDIJPA
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GFGOKJGFKNB.LBAPCKNAEGH BKJPJOHFAMG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KBAOIMPCIPA KJFNDAOFJEG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EMFEDFPNOBH(byte LBOCMPDCIBH, Hashtable EGNAICHPCMN, DCLDNGHLDHI KFFEMCCNCIP, SendOptions OIAPLJECJII);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EOLKEFJPLPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	ILLMBLKEFFI DDNMCBMEAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int AMMEBMOLJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int IEJCFIJFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool BDGMFONPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int HNIDGGFFACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<ILLMBLKEFFI> NIMMCHDBEMC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	ILLMBLKEFFI DJEPCGOENFF(int GJONMFDAEHM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AIILOBJJNNM
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action KIFDHELMKKK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NEBHAHMAHJH();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PHGHPEAICAJ : OKFOKGPABIB, BGIOCIOCADB, IKLBHHDIJPA, EOLKEFJPLPJ, AIILOBJJNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int HAPBKFFMNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int DEMHKKIGPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float AGPMEGEAEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float GBONBCNIHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MGICCPGNPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AAKJJLECHAN KCBMNJODNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action LGJCCOCAJLI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PICIHHBHIMI();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EONIFCAMHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHGAELEKDHO(string NFLMJELFHEH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AAKJJLECHAN
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NKDDIPBADEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IFMCIEPAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<DHKJBOACOCM> PBMCHFDGFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OCGCOOHIIBN(Action EBBHAHEDPLE, string IECKCNFFGCB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FNMKCLFJBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string CMNBKPOHHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 GAFNFHBABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion GAAKDKFPAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 EPPEKKPEMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KHJFJGODOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> NBEHEDEFPCM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E67190", Offset = "0x5E65D90", VA = "0x185E67190")]
	public object[] NIIBCHOKEFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FNMKCLFJBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FFJEEJEKAOD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E67020", Offset = "0x5E65C20", VA = "0x185E67020")]
	public static bool BCCJIBKENKC(this OKFOKGPABIB AAFPEHIIGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E670C0", Offset = "0x5E65CC0", VA = "0x185E670C0")]
	public static bool NFNLPBIGCIL(this OKFOKGPABIB AAFPEHIIGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class DDDHLMDGFFP : PHGHPEAICAJ, OKFOKGPABIB, BGIOCIOCADB, IKLBHHDIJPA, EOLKEFJPLPJ, AIILOBJJNNM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class NFFJILOLIPP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DDDHLMDGFFP EMFAPIONMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MFJFBBMDDII;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E67D30", Offset = "0x5E66930", VA = "0x185E67D30")]
		public NFFJILOLIPP(DDDHLMDGFFP EMFAPIONMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E67C30", Offset = "0x5E66830", VA = "0x185E67C30", Slot = "1")]
		~NFFJILOLIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E67BA0", Offset = "0x5E667A0", VA = "0x185E67BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E67CD0", Offset = "0x5E668D0", VA = "0x185E67CD0")]
		private void PDCOOONDEGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object HACCJPAGBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object AMIDJMEOMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float KFCKLPDPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float MONCKDLKEFO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool IBGDKMLKLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float IOBKDEDANFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int HAPBKFFMNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int DEMHKKIGPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract ILLMBLKEFFI DDNMCBMEAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AMMEBMOLJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E65550", Offset = "0x5E64150", VA = "0x185E65550", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int IEJCFIJFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int HNIDGGFFACC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool BDGMFONPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E65790", Offset = "0x5E64390", VA = "0x185E65790", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float AGPMEGEAEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C7250", Offset = "0x7C5E50", VA = "0x1807C7250", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E65EC0", Offset = "0x5E64AC0", VA = "0x185E65EC0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float GBONBCNIHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C7500", Offset = "0x7C6100", VA = "0x1807C7500", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E66510", Offset = "0x5E65110", VA = "0x185E66510", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool MGICCPGNPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract AAKJJLECHAN KCBMNJODNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool FBBBKCAAKGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract HHIFPDBOHIH OPIOEPPDJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool BHGOIGFPCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool IIOGJBHDELP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool PCJLFJCPLOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool JOLCBNAPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract HJOHLDGIDBL MBIEOJAAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private FBHLHHEDNEC PBPEGPMPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private FBHLHHEDNEC HGMMFPBKEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private AJNADBDECBH<Func<float>> HDKLEGDMKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool DPPINMPDDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC2D750", Offset = "0xC2C350", VA = "0x180C2D750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool MJGLLGIMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E66930", Offset = "0x5E65530", VA = "0x185E66930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool OBPIKNBOKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E66840", Offset = "0x5E65440", VA = "0x185E66840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event GFGOKJGFKNB.LBAPCKNAEGH BKJPJOHFAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E65FA0", Offset = "0x5E64BA0", VA = "0x185E65FA0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E654E0", Offset = "0x5E640E0", VA = "0x185E654E0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event KBAOIMPCIPA KJFNDAOFJEG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<ILLMBLKEFFI> NIMMCHDBEMC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<HHIFPDBOHIH, HHIFPDBOHIH> MEEJLHGKBGM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> OFCEJMOFHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E665A0", Offset = "0x5E651A0", VA = "0x185E665A0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E65AD0", Offset = "0x5E646D0", VA = "0x185E65AD0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action LGJCCOCAJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E663E0", Offset = "0x5E64FE0", VA = "0x185E663E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E655C0", Offset = "0x5E641C0", VA = "0x185E655C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action KIFDHELMKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E65F00", Offset = "0x5E64B00", VA = "0x185E65F00", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E66030", Offset = "0x5E64C30", VA = "0x185E66030", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract ILLMBLKEFFI DJEPCGOENFF(int GJONMFDAEHM);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool JDOOGAEBKBK(AppSettings HEBDLEEMKKO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void EKILCNCBKEG();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool FOACKALFCMF();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void FJOAICIHMFP();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool EMFEDFPNOBH(byte LBOCMPDCIBH, Hashtable EGNAICHPCMN, DCLDNGHLDHI KFFEMCCNCIP, SendOptions OIAPLJECJII);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool IOBCLGEABCI(string OBOHBOPNAFA, GNMCJCLJONI FGJHGAGHLFG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void AHGAELEKDHO(string NFLMJELFHEH);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void EGOHBIHLIOH(GFGOKJGFKNB ONMDLMOBIJP);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E66AC0", Offset = "0x5E656C0", VA = "0x185E66AC0")]
	protected DDDHLMDGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E66010", Offset = "0x5E64C10", VA = "0x185E66010")]
	public void JMCKLNABHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E65B80", Offset = "0x5E64780", VA = "0x185E65B80", Slot = "35")]
	public void HNGMKLOJJHK(object KJCAGLABEME, bool ICDAOHGNDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E659D0", Offset = "0x5E645D0", VA = "0x185E659D0", Slot = "33")]
	public void FPIODHEIBKI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E656F0", Offset = "0x5E642F0", VA = "0x185E656F0", Slot = "34")]
	public void ELGDMGMCKPN(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E66480", Offset = "0x5E65080", VA = "0x185E66480", Slot = "36")]
	public IDisposable LKOJIGIDBEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E65CA0", Offset = "0x5E648A0", VA = "0x185E65CA0", Slot = "91")]
	public virtual bool IAJOCIDEMNP(bool JPBGPOKLJDG, [Out] string GNLAGDDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E66650", Offset = "0x5E65250", VA = "0x185E66650")]
	private bool NLCCKEPPKAF([Out] string GNLAGDDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E65660", Offset = "0x5E64260", VA = "0x185E65660")]
	private bool CBMHCBPJAGD([Out] string GNLAGDDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E667F0", Offset = "0x5E653F0", VA = "0x185E667F0", Slot = "37")]
	public bool NNDDDCANJMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E66160", Offset = "0x5E64D60", VA = "0x185E66160", Slot = "38")]
	public void KIIMAEKKOHE(StringBuilder COMKMCNLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E65820", Offset = "0x5E64420", VA = "0x185E65820")]
	private void FHGMNAPBPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5E660D0", Offset = "0x5E64CD0", VA = "0x185E660D0")]
	private void KHPFOBDNLFI(Func<float> MHPDBPNAABA, object KJCAGLABEME, int PKHBGBBFHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E65480", Offset = "0x5E64080", VA = "0x185E65480", Slot = "92")]
	public void AMOFOOAAPBJ(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E66A30", Offset = "0x5E65630", VA = "0x185E66A30", Slot = "8")]
	public void PICIHHBHIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5E65730", Offset = "0x5E64330", VA = "0x185E65730", Slot = "9")]
	public void EONIFCAMHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E66980", Offset = "0x5E65580", VA = "0x185E66980")]
	private void PAMLOKNPCFH(float BENLPNBGENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C7500", Offset = "0x7C6100", VA = "0x1807C7500")]
	private float IPIFNFAGPGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C7250", Offset = "0x7C5E50", VA = "0x1807C7250")]
	private float MCKBEBLOMOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E66880", Offset = "0x5E65480", VA = "0x185E66880")]
	private void OHNPNJJKFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E66550", Offset = "0x5E65150", VA = "0x185E66550", Slot = "55")]
	public void NEBHAHMAHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class JIAEANNDEHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string MPHKFGGFABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool BLJBMAPBELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool LGPGIAIIJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int AHDNFPHJFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] AOGANFILGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte PKLLCCPIPDM;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random BAAKGLJAGFA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E67320", Offset = "0x5E65F20", VA = "0x185E67320", Slot = "5")]
	public virtual bool DNLHPPINJKP(string DGEFBIHIIIK, int FJMLIBPECDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E673C0", Offset = "0x5E65FC0", VA = "0x185E673C0", Slot = "6")]
	public virtual bool LOLMIBPOFMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E67370", Offset = "0x5E65F70", VA = "0x185E67370", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E672A0", Offset = "0x5E65EA0", VA = "0x185E672A0")]
	protected internal void BGGKBEMAPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E67490", Offset = "0x5E66090", VA = "0x185E67490")]
	protected JIAEANNDEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KHLLCKPFAMI : JIAEANNDEHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket GCBCEHPMNEL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E67630", Offset = "0x5E66230", VA = "0x185E67630", Slot = "5")]
	public override bool DNLHPPINJKP(string DGEFBIHIIIK, int FJMLIBPECDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E678D0", Offset = "0x5E664D0", VA = "0x185E678D0", Slot = "6")]
	public override bool LOLMIBPOFMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5563C60", Offset = "0x5562860", VA = "0x185563C60", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E67AC0", Offset = "0x5E666C0", VA = "0x185E67AC0")]
	public KHLLCKPFAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FBLJEKDOBFG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string OHAMAJJBOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GEAIMHFPFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string CFOCIALPAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int OBNNPFJIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x77DAF0", Offset = "0x77C6F0", VA = "0x18077DAF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x77E230", Offset = "0x77CE30", VA = "0x18077E230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E66F00", Offset = "0x5E65B00", VA = "0x185E66F00")]
	public FBLJEKDOBFG(string KCDGADOLLBP, string NNKFDPENBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E66D30", Offset = "0x5E65930", VA = "0x185E66D30")]
	private void PPMICLOFNEI(string KGJIALEEHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E66E40", Offset = "0x5E65A40", VA = "0x185E66E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C40", Offset = "0x5E65840", VA = "0x185E66C40")]
	public string AOHHCOGEHLD(bool DCNPCKAGGMM = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AKFGOKDAINK
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int KPFGLLPPJLL;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool CPPFNHIFMAI;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int IACDBIIHIME;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int EAEGKMCBBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private FBLJEKDOBFG KFJHDJJNEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string IICJLFPAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int DKPDLBKIEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int LCKJCNBPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<FBLJEKDOBFG> MLNAGAGHMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JIAEANNDEHO BHEBALEONOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> IDJEGMMBBAA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LOLMIBPOFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x853290", Offset = "0x851E90", VA = "0x180853290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x90A8D0", Offset = "0x9094D0", VA = "0x18090A8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E653D0", Offset = "0x5E63FD0", VA = "0x185E653D0")]
	public AKFGOKDAINK(FBLJEKDOBFG KFJHDJJNEML, Action<FBLJEKDOBFG> FNDGLAINDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E64E60", Offset = "0x5E63A60", VA = "0x185E64E60")]
	public bool LLDDGFIBKDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E651D0", Offset = "0x5E63DD0", VA = "0x185E651D0")]
	public static string PJIKEFOJCDA(string FLFCCGFBILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E64B80", Offset = "0x5E63780", VA = "0x185E64B80")]
	protected internal void JLEAPDLPAJA(object BFDLBONPDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E64B90", Offset = "0x5E63790", VA = "0x185E64B90")]
	protected internal bool KHBMFNHGFDO()
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
