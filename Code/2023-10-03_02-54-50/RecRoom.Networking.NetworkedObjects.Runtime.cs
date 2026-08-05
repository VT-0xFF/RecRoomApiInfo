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
public interface OFIPPLFNAEJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> EMCIGAOMIID;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEIAKMHPGAB(object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OANNLIPJJMJ(object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDGDKPBLEDN(object PIPCHJCEPPJ, bool BDKPNCADKBE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable IHJAHNOBICD();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DLJPIMECKFC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FFBCHKOEOMH(StringBuilder NNPFGGEOJGB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BOIIMHLMOEN(bool IBHGEFDLAIL, [Out] string OBDAEGBLILG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PJOEIOKKAEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MGHLHHMMECL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	OOLIJKINMFB EPGHEEHMCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AHJBILGGDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNDKJAHGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CCMCFDDDLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EKBDANALPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HKOKIAKKDMP LLKJCGMDCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OIEAIOCCILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OOLIJKINMFB, OOLIJKINMFB> MDJDNDPNAMO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGEEBKBDPBM(OKMNAIBCJOF FCEDLNJHNBH);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JJDFBNOILJK();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CGNKDEIBLFP(string EOEEFGFCPMN, IECFFJIGDLB IKFJMLEFIOG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BDGKOIFGDLP();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KLFLHGMJCIF(AppSettings GNKKOIPAPKM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OOLIJKINMFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BPFLOGMOJGL AHLPKDJKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	GDKPPEKNGDM HICBJBBJHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EKBDANALPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool AHJBILGGDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KNIBJIGJHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception EDLPAGFNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode DONBPBMCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OKMNAIBCJOF.FJFBNBINGHJ NBDACNFKHHF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<BPFLOGMOJGL, BPFLOGMOJGL> OFPPPELEDMO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HKOEJJHDOJP(object HBMBMELELPF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBNMHDDCGLG(object MBJNJPJDELK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ABNEEAKGGAG(byte KNOONNJMOFL, int ANKECHDDAPB, object NFMBDICKDOG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AADGEKIMFMI
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OKMNAIBCJOF.FJFBNBINGHJ NBDACNFKHHF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ABNEEAKGGAG NKPNFLBDEAF;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HECGMEJODPK(byte KNOONNJMOFL, Hashtable HJBFBCEMIAG, IEGKPBKKIBG LBHNCOBHHAA, SendOptions CIPBKAEKPGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DLBFKHCIPPN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OGIKDEMJHKP DICECHIKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JFIBOPJMCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int JNALEFNCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JAIPJDBIFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MOJCNKNOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<OGIKDEMJHKP> GMDLHNBCIEI;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	OGIKDEMJHKP OCLPEGJCHAF(int BNIMHBPGHDC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DBMKFFLALCA
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action ALDFOHHNCJI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIPCNJBMAFF();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FEHJFMFNJLD : PJOEIOKKAEH, OFIPPLFNAEJ, AADGEKIMFMI, DLBFKHCIPPN, DBMKFFLALCA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int ECCPJABBICM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int PDJPCBFAAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float DMPOIFPLFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CMBDDIADIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LNANIAGIFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FPJJKFGKMHA GCKHOIFHKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action OHHKIOCGJMB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFOGCCMAOPJ();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGIENNFOHCN();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DAMGNJHKPIN(string FMDDKIACAFB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FPJJKFGKMHA
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OKHEMHMKJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GLOBDDMFPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<DOEHCDGADBE> GFLKLCIIHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLFGLMLMBHB(Action OPACDEMMCIC, string HJBCDEJOKIB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MOMPDCLGGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string DGJAIOJLIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 MGPEIGPKABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion DCHJEDLFMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 DOOPEIKEAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int NEMILBAABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> AJCLCHEGOKE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4D70", Offset = "0x5CF3570", VA = "0x185CF4D70")]
	public object[] PGFJGMMGLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public MOMPDCLGGDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HLOJGDALOPA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4130", Offset = "0x5CF2930", VA = "0x185CF4130")]
	public static bool FIMGHHBMAKB(this PJOEIOKKAEH IJDHAHKDKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4060", Offset = "0x5CF2860", VA = "0x185CF4060")]
	public static bool FEGCMIBINFE(this PJOEIOKKAEH IJDHAHKDKKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class OIFKKNAGJBC : FEHJFMFNJLD, PJOEIOKKAEH, OFIPPLFNAEJ, AADGEKIMFMI, DLBFKHCIPPN, DBMKFFLALCA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FAKMBHGDDGE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OIFKKNAGJBC EMMKPMHGGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool CFJBGEMDAGC;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3C20", Offset = "0x5CF2420", VA = "0x185CF3C20")]
		public FAKMBHGDDGE(OIFKKNAGJBC EMMKPMHGGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3B20", Offset = "0x5CF2320", VA = "0x185CF3B20", Slot = "1")]
		~FAKMBHGDDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3A90", Offset = "0x5CF2290", VA = "0x185CF3A90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3BC0", Offset = "0x5CF23C0", VA = "0x185CF3BC0")]
		private void MJHLINCFMBH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object CIOAFNNOJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object KAKGOJGPAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float ODICDNFJDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float PNIOIAGFGIB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool OIEAIOCCILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float JLPGLBLIIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int ECCPJABBICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int PDJPCBFAAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract OGIKDEMJHKP DICECHIKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JFIBOPJMCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6450", Offset = "0x5CF4C50", VA = "0x185CF6450", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int JNALEFNCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int MOJCNKNOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JAIPJDBIFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4E80", Offset = "0x5CF3680", VA = "0x185CF4E80", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float DMPOIFPLFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B68B0", Offset = "0x7B50B0", VA = "0x1807B68B0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6020", Offset = "0x5CF4820", VA = "0x185CF6020", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float CMBDDIADIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B4800", VA = "0x1807B6000", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6240", Offset = "0x5CF4A40", VA = "0x185CF6240", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool LNANIAGIFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract FPJJKFGKMHA GCKHOIFHKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool MGHLHHMMECL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract OOLIJKINMFB EPGHEEHMCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool AHJBILGGDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool LNDKJAHGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool CCMCFDDDLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool EKBDANALPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract HKOKIAKKDMP LLKJCGMDCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private EHNBFHMIMBB CFKDKGBEPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private EHNBFHMIMBB EENIJJLJOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BDJMOPPMNBO<Func<float>> EHHHCALDHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool NCKCALGMCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB587A0", Offset = "0xB56FA0", VA = "0x180B587A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool PHNEBOCLOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5FD0", Offset = "0x5CF47D0", VA = "0x185CF5FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool EBOKDFKIHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5550", Offset = "0x5CF3D50", VA = "0x185CF5550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event OKMNAIBCJOF.FJFBNBINGHJ NBDACNFKHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF62C0", Offset = "0x5CF4AC0", VA = "0x185CF62C0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF63E0", Offset = "0x5CF4BE0", VA = "0x185CF63E0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event ABNEEAKGGAG NKPNFLBDEAF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<OGIKDEMJHKP> GMDLHNBCIEI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<OOLIJKINMFB, OOLIJKINMFB> MDJDNDPNAMO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> EMCIGAOMIID
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF52D0", Offset = "0x5CF3AD0", VA = "0x185CF52D0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6330", Offset = "0x5CF4B30", VA = "0x185CF6330", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action OHHKIOCGJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF61A0", Offset = "0x5CF49A0", VA = "0x185CF61A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5B80", Offset = "0x5CF4380", VA = "0x185CF5B80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action ALDFOHHNCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CF53D0", Offset = "0x5CF3BD0", VA = "0x185CF53D0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5230", Offset = "0x5CF3A30", VA = "0x185CF5230", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract OGIKDEMJHKP OCLPEGJCHAF(int BNIMHBPGHDC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool KLFLHGMJCIF(AppSettings GNKKOIPAPKM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void BDGKOIFGDLP();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool JJDFBNOILJK();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void JJMEGDBEPID();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool HECGMEJODPK(byte KNOONNJMOFL, Hashtable HJBFBCEMIAG, IEGKPBKKIBG LBHNCOBHHAA, SendOptions CIPBKAEKPGJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool CGNKDEIBLFP(string EOEEFGFCPMN, IECFFJIGDLB IKFJMLEFIOG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void DAMGNJHKPIN(string FMDDKIACAFB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void AGEEBKBDPBM(OKMNAIBCJOF FCEDLNJHNBH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CF64C0", Offset = "0x5CF4CC0", VA = "0x185CF64C0")]
	protected OIFKKNAGJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6180", Offset = "0x5CF4980", VA = "0x185CF6180")]
	public void MJKJMKCCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5920", Offset = "0x5CF4120", VA = "0x185CF5920", Slot = "35")]
	public void HDGDKPBLEDN(object PIPCHJCEPPJ, bool BDKPNCADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5130", Offset = "0x5CF3930", VA = "0x185CF5130", Slot = "33")]
	public void CEIAKMHPGAB(object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6280", Offset = "0x5CF4A80", VA = "0x185CF6280", Slot = "34")]
	public void OANNLIPJJMJ(object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5AF0", Offset = "0x5CF42F0", VA = "0x185CF5AF0", Slot = "36")]
	public IDisposable IHJAHNOBICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4F10", Offset = "0x5CF3710", VA = "0x185CF4F10", Slot = "91")]
	public virtual bool BOIIMHLMOEN(bool IBHGEFDLAIL, [Out] string OBDAEGBLILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5C20", Offset = "0x5CF4420", VA = "0x185CF5C20")]
	private bool JAMIOGMJOPN([Out] string OBDAEGBLILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6060", Offset = "0x5CF4860", VA = "0x185CF6060")]
	private bool LKKGLOIBODD([Out] string OBDAEGBLILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5470", Offset = "0x5CF3C70", VA = "0x185CF5470", Slot = "37")]
	public bool DLJPIMECKFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5640", Offset = "0x5CF3E40", VA = "0x185CF5640", Slot = "38")]
	public void FFBCHKOEOMH(StringBuilder NNPFGGEOJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5DC0", Offset = "0x5CF45C0", VA = "0x185CF5DC0")]
	private void JMPCHHJAOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF54C0", Offset = "0x5CF3CC0", VA = "0x185CF54C0")]
	private void ENHGDOACPDB(Func<float> FEIKKJAOPCH, object PIPCHJCEPPJ, int NKCBPBOPHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5F70", Offset = "0x5CF4770", VA = "0x185CF5F70", Slot = "92")]
	public void KDHHJGPDBLP(object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF60F0", Offset = "0x5CF48F0", VA = "0x185CF60F0", Slot = "8")]
	public void MFOGCCMAOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF58C0", Offset = "0x5CF40C0", VA = "0x185CF58C0", Slot = "9")]
	public void FGIENNFOHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5590", Offset = "0x5CF3D90", VA = "0x185CF5590")]
	private void FELMEKDAFNG(float EMAKFGFOEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B4800", VA = "0x1807B6000")]
	private float FMKBJMGCJCN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B68B0", Offset = "0x7B50B0", VA = "0x1807B68B0")]
	private float JGCEBLMBGIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5A40", Offset = "0x5CF4240", VA = "0x185CF5A40")]
	private void IFGILLHGPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5380", Offset = "0x5CF3B80", VA = "0x185CF5380", Slot = "55")]
	public void CIPCNJBMAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KMBEHJHEEHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string GJNIBJFPOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool LBKJINGNABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool LAGEOEJAGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int BPBHKHDJGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] HMKBAOCJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte NFBGCLAEAJH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random GPCLGACKDMH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4B20", Offset = "0x5CF3320", VA = "0x185CF4B20", Slot = "5")]
	public virtual bool CMOPJMNIEHO(string OJFBEFOBOGD, int PMKFLOKOEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4AD0", Offset = "0x5CF32D0", VA = "0x185CF4AD0", Slot = "6")]
	public virtual bool BEONFDMGOAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4B70", Offset = "0x5CF3370", VA = "0x185CF4B70", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4BC0", Offset = "0x5CF33C0", VA = "0x185CF4BC0")]
	protected internal void LIDOAMKDODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4CC0", Offset = "0x5CF34C0", VA = "0x185CF4CC0")]
	protected KMBEHJHEEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PPDFNIIJMPK : KMBEHJHEEHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket ENBMAEPIGFI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6830", Offset = "0x5CF5030", VA = "0x185CF6830", Slot = "5")]
	public override bool CMOPJMNIEHO(string OJFBEFOBOGD, int PMKFLOKOEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6640", Offset = "0x5CF4E40", VA = "0x185CF6640", Slot = "6")]
	public override bool BEONFDMGOAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5427730", Offset = "0x5425F30", VA = "0x185427730", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6AD0", Offset = "0x5CF52D0", VA = "0x185CF6AD0")]
	public PPDFNIIJMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GDKNIMLODFH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string KPOIBBJEBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string BGLPGMFOGON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string LCOKKLOHJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PLNAEPKEMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76A350", Offset = "0x768B50", VA = "0x18076A350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x76A390", Offset = "0x768B90", VA = "0x18076A390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3F40", Offset = "0x5CF2740", VA = "0x185CF3F40")]
	public GDKNIMLODFH(string NODGLOENINC, string NKJJDJLNBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3D70", Offset = "0x5CF2570", VA = "0x185CF3D70")]
	private void ILLNJEFCFFP(string KIAOFIJHGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3E80", Offset = "0x5CF2680", VA = "0x185CF3E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3C80", Offset = "0x5CF2480", VA = "0x185CF3C80")]
	public string CPNFFEBMKPI(bool POJEEIIIFMJ = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KFDICJAILBF
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int ABEDNLFDNJD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool MMBNFFDAGLG;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int BCEFKENDEGG;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int JOPMIBPPBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GDKNIMLODFH ICHOPCFOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string BBEPDEDKCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int MBANNMFOOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int GAIHDDIOAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<GDKNIMLODFH> NFMJKKBDOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KMBEHJHEEHH MAJCNONDLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> JHAEMJLJDLI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BEONFDMGOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x867C80", Offset = "0x866480", VA = "0x180867C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4A20", Offset = "0x5CF3220", VA = "0x185CF4A20")]
	public KFDICJAILBF(GDKNIMLODFH ICHOPCFOCPB, Action<GDKNIMLODFH> BHOBJDLKCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CF44B0", Offset = "0x5CF2CB0", VA = "0x185CF44B0")]
	public bool KCFNLKKNBID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4820", Offset = "0x5CF3020", VA = "0x185CF4820")]
	public static string LBECJKMADBK(string GHENEFHOLNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF44A0", Offset = "0x5CF2CA0", VA = "0x185CF44A0")]
	protected internal void CPEILMFCENJ(object LIODJEBJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CF41D0", Offset = "0x5CF29D0", VA = "0x185CF41D0")]
	protected internal bool CFDJLKOPJKB()
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
