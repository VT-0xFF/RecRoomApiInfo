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
public interface IMBHBFAOMKP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> ININFIEAKFB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIAACMKKKHD(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKKOJJLDKBA(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMMGCMJDEAC(object GMMJMENGHCD, bool EMHHNGKPBOK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable PGHNBCOJLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DEBMILCFDEL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HINBEBKHBBN(StringBuilder IICIOHHAHCC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GLGKOBHNKBP(bool EPJEKABJIIC, [Out] string AABEEDLKHEA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FKPGMCCBHEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IFPJIAJPOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MHIPDAEMNBH AGKICPBEGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IBILJGJAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BFEMGDPJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LADPCKJMNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IDCKNKFNHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HMLFCBBKKJD DCMDHJMPEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GOMIHAJCAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MHIPDAEMNBH, MHIPDAEMNBH> EFHEBDDJAPL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EPIGJLMPJDD(JCINNBNHABC OMHJAKBKALO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GNANFIAGICI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IJGOBGGCOEM(string MBGBMMMJPOM, MGEHNLLNIBO NDKGDPFOEHB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OCMMDAAPODC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OHPIOPMEIHI(AppSettings KDIOBMNPFGL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MHIPDAEMNBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LFGHJPIGJGK GBIGKICPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	OBCDMKKNGEC EACEHFIGIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool IDCKNKFNHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool IBILJGJAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BNAJMMHKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception EJGCJFACJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode CBEDEGOJOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JCINNBNHABC.LPPEFDLNKGP JBLBJGLBGJK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LFGHJPIGJGK, LFGHJPIGJGK> EPLMPJCKGCH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NPAMCMLMLGC(object JGFCAMDGBLE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HIPDHGKMKAE(object NEBKMJJOLHE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ENEEMLLAJIB(byte OIFHIABMKDP, int CHODFAOIHKC, object NEMGAFJFCML);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JOANOJKMLFN
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JCINNBNHABC.LPPEFDLNKGP JBLBJGLBGJK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ENEEMLLAJIB CFFFFMLGPHD;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MIMCLEKOGEP(byte OIFHIABMKDP, Hashtable KCHJMALCIKA, NKEHDJPOPMO BDFHANCBMEF, SendOptions NKAEHEFFAHL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JICEJCHHHMD
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HIKDHAMGKKP HGNBJNACNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int EKCEPLGHGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int FKCKNNMPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool MPGNAPCPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int PELPLNPIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<HIKDHAMGKKP> PIKCPCPFHJI;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	HIKDHAMGKKP CEGFDIKEJIN(int MKHPFDAPOFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AMABJGMFAKL
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action HCEDKBLNGOI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODHALPKJFMG();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AANLLLINLOG : FKPGMCCBHEO, IMBHBFAOMKP, JOANOJKMLFN, JICEJCHHHMD, AMABJGMFAKL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int BBJCCMOEEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int FEGMHHNLDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float LGODALMJGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float AEPGOMMAOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LPICNCLABLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FHGLNBECKIN JLGLAHGGHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action EHNENKMIJAA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEDBOHCHADF();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNBBIFFNGON();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKJCCLALEKE(string NJOHMCKIBNK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FHGLNBECKIN
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PKCKIIPENIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FMOKFPLHILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<HLPDDKKDCGO> NBMMHHDKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HONIIGOPLCN(Action KGFBKGDBOOL, string MFJNKCNMDMK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LPPGCCDNGDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string POJHMCDGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 BKEJMFAHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion ONICOCGNJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 GBDCCKDKPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int HLOHJAOFCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> ENBEMGKCGAM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61BABC0", Offset = "0x61B9DC0", VA = "0x1861BABC0")]
	public object[] KNFBCKMNHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LPPGCCDNGDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PPOEFDHPFBN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61BAEC0", Offset = "0x61BA0C0", VA = "0x1861BAEC0")]
	public static bool GKLAKFDKOPE(this FKPGMCCBHEO LLHBBNAGKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61BAF60", Offset = "0x61BA160", VA = "0x1861BAF60")]
	public static bool PLHPOHLFHIG(this FKPGMCCBHEO LLHBBNAGKGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class EJJJCJKJNFP : AANLLLINLOG, FKPGMCCBHEO, IMBHBFAOMKP, JOANOJKMLFN, JICEJCHHHMD, AMABJGMFAKL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class PIHCPGBNOJC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EJJJCJKJNFP KBJNCJEBICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KABNGLCHEKD;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61BAE60", Offset = "0x61BA060", VA = "0x1861BAE60")]
		public PIHCPGBNOJC(EJJJCJKJNFP KBJNCJEBICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61BAD60", Offset = "0x61B9F60", VA = "0x1861BAD60", Slot = "1")]
		~PIHCPGBNOJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61BACD0", Offset = "0x61B9ED0", VA = "0x1861BACD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61BAE00", Offset = "0x61BA000", VA = "0x1861BAE00")]
		private void IFIGADPPBBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object LLPJODDGCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object IANCJPHJHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float JLGLGAJFJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float FADFGGGIDLM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool GOMIHAJCAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float LEOFMIMCCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int BBJCCMOEEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int FEGMHHNLDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract HIKDHAMGKKP HGNBJNACNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EKCEPLGHGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x61B9D40", Offset = "0x61B8F40", VA = "0x1861B9D40", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int FKCKNNMPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int PELPLNPIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool MPGNAPCPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x61B9F80", Offset = "0x61B9180", VA = "0x1861B9F80", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LGODALMJGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9722C0", Offset = "0x9714C0", VA = "0x1809722C0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61B9BF0", Offset = "0x61B8DF0", VA = "0x1861B9BF0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float AEPGOMMAOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F4780", Offset = "0x8F3980", VA = "0x1808F4780", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x61BA160", Offset = "0x61B9360", VA = "0x1861BA160", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool LPICNCLABLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract FHGLNBECKIN JLGLAHGGHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool IFPJIAJPOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract MHIPDAEMNBH AGKICPBEGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool IBILJGJAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool BFEMGDPJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool LADPCKJMNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool IDCKNKFNHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract HMLFCBBKKJD DCMDHJMPEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private AHHBNJJODED KMELPALONFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private AHHBNJJODED FFEMNKDJJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private PHJHNNIPFDE<Func<float>> NKKIJJJJDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool LHCBFILDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCD75E0", Offset = "0xCD67E0", VA = "0x180CD75E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool CKGOKDOIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61B91A0", Offset = "0x61B83A0", VA = "0x1861B91A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool IIBANDCFMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61B9060", Offset = "0x61B8260", VA = "0x1861B9060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event JCINNBNHABC.LPPEFDLNKGP JBLBJGLBGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61B9CD0", Offset = "0x61B8ED0", VA = "0x1861B9CD0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x61B90F0", Offset = "0x61B82F0", VA = "0x1861B90F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event ENEEMLLAJIB CFFFFMLGPHD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<HIKDHAMGKKP> PIKCPCPFHJI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<MHIPDAEMNBH, MHIPDAEMNBH> EFHEBDDJAPL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> ININFIEAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61BA0B0", Offset = "0x61B92B0", VA = "0x1861BA0B0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61BA1A0", Offset = "0x61B93A0", VA = "0x1861BA1A0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action EHNENKMIJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61BA4D0", Offset = "0x61B96D0", VA = "0x1861BA4D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61B9AF0", Offset = "0x61B8CF0", VA = "0x1861B9AF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action HCEDKBLNGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61B9C30", Offset = "0x61B8E30", VA = "0x1861B9C30", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61BA010", Offset = "0x61B9210", VA = "0x1861BA010", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract HIKDHAMGKKP CEGFDIKEJIN(int MKHPFDAPOFJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool OHPIOPMEIHI(AppSettings KDIOBMNPFGL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void OCMMDAAPODC();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool GNANFIAGICI();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void AEHEFJMCEGJ();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool MIMCLEKOGEP(byte OIFHIABMKDP, Hashtable KCHJMALCIKA, NKEHDJPOPMO BDFHANCBMEF, SendOptions NKAEHEFFAHL);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool IJGOBGGCOEM(string MBGBMMMJPOM, MGEHNLLNIBO NDKGDPFOEHB);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void JKJCCLALEKE(string NJOHMCKIBNK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void EPIGJLMPJDD(JCINNBNHABC OMHJAKBKALO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61BA570", Offset = "0x61B9770", VA = "0x1861BA570")]
	protected EJJJCJKJNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61B9F60", Offset = "0x61B9160", VA = "0x1861B9F60")]
	public void MEJEOBIHPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61B8F40", Offset = "0x61B8140", VA = "0x1861B8F40", Slot = "35")]
	public void AMMGCMJDEAC(object GMMJMENGHCD, bool EMHHNGKPBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61B9870", Offset = "0x61B8A70", VA = "0x1861B9870", Slot = "33")]
	public void IIAACMKKKHD(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61B9160", Offset = "0x61B8360", VA = "0x1861B9160", Slot = "34")]
	public void EKKOJJLDKBA(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61BA440", Offset = "0x61B9640", VA = "0x1861BA440", Slot = "36")]
	public IDisposable PGHNBCOJLBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61B93E0", Offset = "0x61B85E0", VA = "0x1861B93E0", Slot = "91")]
	public virtual bool GLGKOBHNKBP(bool EPJEKABJIIC, [Out] string AABEEDLKHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61BA2A0", Offset = "0x61B94A0", VA = "0x1861BA2A0")]
	private bool OECOLECMAGJ([Out] string AABEEDLKHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61B9A60", Offset = "0x61B8C60", VA = "0x1861B9A60")]
	private bool KILCOCJHBCB([Out] string AABEEDLKHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61B90A0", Offset = "0x61B82A0", VA = "0x1861B90A0", Slot = "37")]
	public bool DEBMILCFDEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61B9600", Offset = "0x61B8800", VA = "0x1861B9600", Slot = "38")]
	public void HINBEBKHBBN(StringBuilder IICIOHHAHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61B9DB0", Offset = "0x61B8FB0", VA = "0x1861B9DB0")]
	private void MCJIODGAGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61B91F0", Offset = "0x61B83F0", VA = "0x1861B91F0")]
	private void FIFFNFCFKOI(Func<float> MEOFJNMAPJP, object GMMJMENGHCD, int CJCOBDOEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x61B9A00", Offset = "0x61B8C00", VA = "0x1861B9A00", Slot = "92")]
	public void JMPBOHIJGFO(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61B9970", Offset = "0x61B8B70", VA = "0x1861B9970", Slot = "8")]
	public void JEDBOHCHADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61B9B90", Offset = "0x61B8D90", VA = "0x1861B9B90", Slot = "9")]
	public void KNBBIFFNGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61B9280", Offset = "0x61B8480", VA = "0x1861B9280")]
	private void GBLBFKAGFGO(float FJBGLIDGKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8F4780", Offset = "0x8F3980", VA = "0x1808F4780")]
	private float CBPGHLAAKAN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9722C0", Offset = "0x9714C0", VA = "0x1809722C0")]
	private float DPBMNPEOLCI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61B9330", Offset = "0x61B8530", VA = "0x1861B9330")]
	private void GCAEDDLKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61BA250", Offset = "0x61B9450", VA = "0x1861BA250", Slot = "55")]
	public void ODHALPKJFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class CBBEOLIHKJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string ODPFKLIJKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool AHFCOMNENGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool PNGDABIGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int GGEPODAANEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] HBKGHHPLBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte KKEFPEHNODE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random HGFEOAIIIPN;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61B7F70", Offset = "0x61B7170", VA = "0x1861B7F70", Slot = "5")]
	public virtual bool HKOLPBEJPCI(string ICAHIMEHNEF, int PFKMNBCMKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61B7E50", Offset = "0x61B7050", VA = "0x1861B7E50", Slot = "6")]
	public virtual bool BIMGJCICHCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61B7EA0", Offset = "0x61B70A0", VA = "0x1861B7EA0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61B7EF0", Offset = "0x61B70F0", VA = "0x1861B7EF0")]
	protected internal void GNCDFEHEFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61B8040", Offset = "0x61B7240", VA = "0x1861B8040")]
	protected CBBEOLIHKJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DDNIOFKGHDI : CBBEOLIHKJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket HNCPKJBGJCN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61B8BC0", Offset = "0x61B7DC0", VA = "0x1861B8BC0", Slot = "5")]
	public override bool HKOLPBEJPCI(string ICAHIMEHNEF, int PFKMNBCMKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61B89D0", Offset = "0x61B7BD0", VA = "0x1861B89D0", Slot = "6")]
	public override bool BIMGJCICHCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x57E2BB0", Offset = "0x57E1DB0", VA = "0x1857E2BB0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61B8E60", Offset = "0x61B8060", VA = "0x1861B8E60")]
	public DDNIOFKGHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HCGCKIOCLGG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string FCFDGKOGKOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string AFIEEJKDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string LEIPHDJDGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PFBBELJLGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B8130", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8860", VA = "0x1807B9660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x61BAAA0", Offset = "0x61B9CA0", VA = "0x1861BAAA0")]
	public HCGCKIOCLGG(string HBBBJJEHKLF, string PCLIJINNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x61BA8D0", Offset = "0x61B9AD0", VA = "0x1861BA8D0")]
	private void PIMMGOFLAIM(string GHNFPNGAFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61BA9E0", Offset = "0x61B9BE0", VA = "0x1861BA9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61BA7E0", Offset = "0x61B99E0", VA = "0x1861BA7E0")]
	public string GNKFIPIKFJD(bool JAHNKPKDOJB = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CKHADJOKNHP
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int IJEGBCEJIDB;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool GCFNNPIOJAN;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int JCFICHCKAHM;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int GDELANBKLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private HCGCKIOCLGG GGCOMEIIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string BFHGBHAJNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int LKILPFPHOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int NHIFFJGIPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<HCGCKIOCLGG> NOLIOKBGPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private CBBEOLIHKJK DFMDCBAJJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> GFPMBMGPGBB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BIMGJCICHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EA2D0", Offset = "0x9E94D0", VA = "0x1809EA2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61B8920", Offset = "0x61B7B20", VA = "0x1861B8920")]
	public CKHADJOKNHP(HCGCKIOCLGG GGCOMEIIOFD, Action<HCGCKIOCLGG> DNCCHFEBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61B83B0", Offset = "0x61B75B0", VA = "0x1861B83B0")]
	public bool EOFOFFHJEOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61B8720", Offset = "0x61B7920", VA = "0x1861B8720")]
	public static string JJPKEFCFDHB(string FIAHKJGHEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61B88A0", Offset = "0x61B7AA0", VA = "0x1861B88A0")]
	protected internal void MPMHBEDBKPE(object DPGBKIGAHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61B80F0", Offset = "0x61B72F0", VA = "0x1861B80F0")]
	protected internal bool CLDJDLEJIAI()
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
