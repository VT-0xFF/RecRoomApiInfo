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
public interface FKJLHCKAPAI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> ICLLIAIDHIM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNOHOKJIFIL(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFEKBJOCBHC(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGGGNGEEGPH(object CFGHNHCDKCN, bool FNMNDADODKG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable FOAIKMNIEIK();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EEEKEPKLNFB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DOEEHLFBOGD(StringBuilder NIACPCOHJHA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BBLCIJJLCLB(bool GENJKGCINHB, [Out] string IBDGAGPHJHE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DFBBMDHADDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GPKGAIACNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LMKPNHLCHKE IBNLPNNFOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HGIMFPECHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EEPMPPEMFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IKNFNBAGMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LMIBHNEOEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HODJCGGAMAM JJGDBFOJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FCLLPGIFIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LMKPNHLCHKE, LMKPNHLCHKE> NILHPOPFGJM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFDKIDOOAHM(LDBAOCBHDEH EFLFHDNJFEB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NFMPDPHJOFG();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HJEDBMKCOMI(string MEKDLFAONDM, IMODLKDLEHD LPOHGPLEDKA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BOIODEBLDDK();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KLHMDOJPALM(AppSettings OBGEMBPDAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LMKPNHLCHKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CAGGGKALJII EONEFPNEPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	IKNGAIFMOKI OPDGLPFDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LMIBHNEOEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HGIMFPECHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool EBEILABBKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception LNCDDIKGHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode JHBOAIEFPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LDBAOCBHDEH.NKPBHDICLNI FOCFKKJCPPN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CAGGGKALJII, CAGGGKALJII> DKKNNECDLLP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKLNCENLBBK(object KLACLBHAHNL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EMEOKPFKKCH(object GGDIBEKKBPI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OBBEKBPHAPB(byte BPCOAKEJJOF, int DOJPOBHEMAE, object KKIOOCHBIJO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AIDKMJHBCMO
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LDBAOCBHDEH.NKPBHDICLNI FOCFKKJCPPN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OBBEKBPHAPB HEMNMEMICHJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NAACKBJDPPO(byte BPCOAKEJJOF, Hashtable PJDKJFDHFHN, MEGKCNPNFCN FPBJNEJALIP, SendOptions OMAPPLIIEHI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HCHLAJNMDMC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EDHEFFCJEMG CJCCCJMHOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JPFMMJOHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int JKEHECLOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PAFNEFHJKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int EEBCGJPCCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<EDHEFFCJEMG> BPFEIFIOOIB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	EDHEFFCJEMG OHCCIOILKLE(int HNGJMJOMBCE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OOKFLKKAAPC
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action CAGHFOCLCJM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBFJMAHONHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MMJFCIBDCMM : DFBBMDHADDB, FKJLHCKAPAI, AIDKMJHBCMO, HCHLAJNMDMC, OOKFLKKAAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CDKAEGILDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int DMKJLGLANDM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float AHBABFPMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CPFFKOMKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MPCMBJIKEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AJCCMKEJPGE HELAIGDKIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MPJFNLFEKDH;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJMNJEEFCBL();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODPOJJEOIJG();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHNILOKINGJ(string APMNJDGFHEG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJCCMKEJPGE
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OFLMILDEEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LMCMLDHKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<JMKGPCNMHIB> ODBCGLBOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LGLHBHJIIDG(Action FGNLBLONEJI, string POOAEDKBIAM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KJACEEEAGJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string FHKFIGDGHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 NOBECIHIBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion KCACHGKLDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 OBNLFLIHJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int JGKOCNJOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> AFAPIEBIMCE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7AF0", Offset = "0x6DF6EF0", VA = "0x186DF7AF0")]
	public object[] DFCIBFMGBDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public KJACEEEAGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ODONHIGENDL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8890", Offset = "0x6DF7C90", VA = "0x186DF8890")]
	public static bool NEIEGKOHBOG(this DFBBMDHADDB OPKHCPADCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8930", Offset = "0x6DF7D30", VA = "0x186DF8930")]
	public static bool PGKHPMIHAJF(this DFBBMDHADDB OPKHCPADCPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class COCMCNFHNBC : MMJFCIBDCMM, DFBBMDHADDB, FKJLHCKAPAI, AIDKMJHBCMO, HCHLAJNMDMC, OOKFLKKAAPC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class PPBGCGOCKFF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly COCMCNFHNBC LJKCLIPAMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool AAFPLDAFGFB;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9100", Offset = "0x6DF8500", VA = "0x186DF9100")]
		public PPBGCGOCKFF(COCMCNFHNBC LJKCLIPAMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9060", Offset = "0x6DF8460", VA = "0x186DF9060", Slot = "1")]
		~PPBGCGOCKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8FD0", Offset = "0x6DF83D0", VA = "0x186DF8FD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8F70", Offset = "0x6DF8370", VA = "0x186DF8F70")]
		private void ANKBABELNKK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object HFFMKGFHGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object DFLINLKFKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float GKDNHMFNAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float NMJENNHCFPC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool FCLLPGIFIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float ALMCNJCGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int CDKAEGILDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int DMKJLGLANDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract EDHEFFCJEMG CJCCCJMHOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JPFMMJOHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6540", Offset = "0x6DF5940", VA = "0x186DF6540", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int JKEHECLOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int EEBCGJPCCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool PAFNEFHJKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6CA0", Offset = "0x6DF60A0", VA = "0x186DF6CA0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float AHBABFPMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB923C0", Offset = "0xB917C0", VA = "0x180B923C0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6DF69C0", Offset = "0x6DF5DC0", VA = "0x186DF69C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float CPFFKOMKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB92380", Offset = "0xB91780", VA = "0x180B92380", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6DC0", Offset = "0x6DF61C0", VA = "0x186DF6DC0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool MPCMBJIKEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract AJCCMKEJPGE HELAIGDKIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool GPKGAIACNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract LMKPNHLCHKE IBNLPNNFOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool HGIMFPECHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool EEPMPPEMFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool IKNFNBAGMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool LMIBHNEOEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract HODJCGGAMAM JJGDBFOJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private JLCPCMNKJOG OGJHIEEJDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private JLCPCMNKJOG CHGJMDBLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private ACJDPNIFKFC<Func<float>> JFBJKHNOINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool FNIMOHPOCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x11A9A10", Offset = "0x11A8E10", VA = "0x1811A9A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool HECIFBPKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6DF7270", Offset = "0x6DF6670", VA = "0x186DF7270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool AOLBKMAPOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6F50", Offset = "0x6DF6350", VA = "0x186DF6F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event LDBAOCBHDEH.NKPBHDICLNI FOCFKKJCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6440", Offset = "0x6DF5840", VA = "0x186DF6440", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6A50", Offset = "0x6DF5E50", VA = "0x186DF6A50", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event OBBEKBPHAPB HEMNMEMICHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<EDHEFFCJEMG> BPFEIFIOOIB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<LMKPNHLCHKE, LMKPNHLCHKE> NILHPOPFGJM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> ICLLIAIDHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6180", Offset = "0x6DF5580", VA = "0x186DF6180", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF7020", Offset = "0x6DF6420", VA = "0x186DF7020", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action MPJFNLFEKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6AC0", Offset = "0x6DF5EC0", VA = "0x186DF6AC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6EB0", Offset = "0x6DF62B0", VA = "0x186DF6EB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action CAGHFOCLCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6350", Offset = "0x6DF5750", VA = "0x186DF6350", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6DF70D0", Offset = "0x6DF64D0", VA = "0x186DF70D0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract EDHEFFCJEMG OHCCIOILKLE(int HNGJMJOMBCE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool KLHMDOJPALM(AppSettings OBGEMBPDAGE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void BOIODEBLDDK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool NFMPDPHJOFG();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void FNBGKKBONFH();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool NAACKBJDPPO(byte BPCOAKEJJOF, Hashtable PJDKJFDHFHN, MEGKCNPNFCN FPBJNEJALIP, SendOptions OMAPPLIIEHI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool HJEDBMKCOMI(string MEKDLFAONDM, IMODLKDLEHD LPOHGPLEDKA);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void AHNILOKINGJ(string APMNJDGFHEG);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void HFDKIDOOAHM(LDBAOCBHDEH EFLFHDNJFEB);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7590", Offset = "0x6DF6990", VA = "0x186DF7590")]
	protected COCMCNFHNBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7320", Offset = "0x6DF6720", VA = "0x186DF7320")]
	public void NOCOEJHJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6230", Offset = "0x6DF5630", VA = "0x186DF6230", Slot = "35")]
	public void CGGGNGEEGPH(object CFGHNHCDKCN, bool FNMNDADODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7170", Offset = "0x6DF6570", VA = "0x186DF7170", Slot = "33")]
	public void KNOHOKJIFIL(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7550", Offset = "0x6DF6950", VA = "0x186DF7550", Slot = "34")]
	public void PFEKBJOCBHC(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6C10", Offset = "0x6DF6010", VA = "0x186DF6C10", Slot = "36")]
	public IDisposable FOAIKMNIEIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5F60", Offset = "0x6DF5360", VA = "0x186DF5F60", Slot = "91")]
	public virtual bool BBLCIJJLCLB(bool GENJKGCINHB, [Out] string IBDGAGPHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6820", Offset = "0x6DF5C20", VA = "0x186DF6820")]
	private bool DOPGMLDDIII([Out] string IBDGAGPHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6D30", Offset = "0x6DF6130", VA = "0x186DF6D30")]
	private bool GGPCDEGBIPM([Out] string IBDGAGPHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6A00", Offset = "0x6DF5E00", VA = "0x186DF6A00", Slot = "37")]
	public bool EEEKEPKLNFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6DF65B0", Offset = "0x6DF59B0", VA = "0x186DF65B0", Slot = "38")]
	public void DOEEHLFBOGD(StringBuilder NIACPCOHJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF73A0", Offset = "0x6DF67A0", VA = "0x186DF73A0")]
	private void OONMEENHLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6F90", Offset = "0x6DF6390", VA = "0x186DF6F90")]
	private void JDHABLHFKCM(Func<float> ILOFGCFHDBG, object CFGHNHCDKCN, int IABPFIADDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF72C0", Offset = "0x6DF66C0", VA = "0x186DF72C0", Slot = "92")]
	public void LFFNCANPFEO(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF64B0", Offset = "0x6DF58B0", VA = "0x186DF64B0", Slot = "8")]
	public void DJMNJEEFCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7340", Offset = "0x6DF6740", VA = "0x186DF7340", Slot = "9")]
	public void ODPOJJEOIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6B60", Offset = "0x6DF5F60", VA = "0x186DF6B60")]
	private void FEKNFEHNGBL(float CGABKENFOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xB92380", Offset = "0xB91780", VA = "0x180B92380")]
	private float GDKBMJIMOOE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xB923C0", Offset = "0xB917C0", VA = "0x180B923C0")]
	private float PILAGKIMKOB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6E00", Offset = "0x6DF6200", VA = "0x186DF6E00")]
	private void GLAHHNMODFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6DF63F0", Offset = "0x6DF57F0", VA = "0x186DF63F0", Slot = "55")]
	public void DBFJMAHONHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class LNCNILMKAKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string LBAHKDIDPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool KKCCNOAKLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool NBFNDBGHNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int BICIFCKFBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] INCGMJECKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte FCLEIIHDFFL;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random KIIOOBKENFK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8620", Offset = "0x6DF7A20", VA = "0x186DF8620", Slot = "5")]
	public virtual bool PFAIECPCPAA(string FKKFJEEMLBG, int MDMPLCCOJAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF85D0", Offset = "0x6DF79D0", VA = "0x186DF85D0", Slot = "6")]
	public virtual bool OGHPJFGHFOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8500", Offset = "0x6DF7900", VA = "0x186DF8500", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8550", Offset = "0x6DF7950", VA = "0x186DF8550")]
	protected internal void MABFCCPGADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF86F0", Offset = "0x6DF7AF0", VA = "0x186DF86F0")]
	protected LNCNILMKAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PIONHOKIIKL : LNCNILMKAKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket GCMDLPDMDBO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8BF0", Offset = "0x6DF7FF0", VA = "0x186DF8BF0", Slot = "5")]
	public override bool PFAIECPCPAA(string FKKFJEEMLBG, int MDMPLCCOJAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8A00", Offset = "0x6DF7E00", VA = "0x186DF8A00", Slot = "6")]
	public override bool OGHPJFGHFOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63460F0", Offset = "0x63454F0", VA = "0x1863460F0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8E90", Offset = "0x6DF8290", VA = "0x186DF8E90")]
	public PIONHOKIIKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HGNLGNGAOFB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string KLKKAIENHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string DPBIKNJOKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string FAPBIADHPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BMCOPEGPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A6050", Offset = "0x8A5450", VA = "0x1808A6050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6DF79D0", Offset = "0x6DF6DD0", VA = "0x186DF79D0")]
	public HGNLGNGAOFB(string DKGOGPLFELC, string HMGPCAGLHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7800", Offset = "0x6DF6C00", VA = "0x186DF7800")]
	private void LKMDOFLKEKP(string GNFNCNDGKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7910", Offset = "0x6DF6D10", VA = "0x186DF7910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7710", Offset = "0x6DF6B10", VA = "0x186DF7710")]
	public string JGJPFDJDMAP(bool ONJHCLDDNJP = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LLIBDAEGOMJ
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int EMPFPJOICGP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool FFKOHDFMLEB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int OECBECPILPP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int MGOJJINFAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private HGNLGNGAOFB ECBMIENEKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string PDGGECCFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int NBMIDMMNPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int HMAILAODJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<HGNLGNGAOFB> BNLGGJOHCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LNCNILMKAKF POBKKDPLLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> ODGFNAHFGAA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OGHPJFGHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x983FC0", Offset = "0x9833C0", VA = "0x180983FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x983EB0", Offset = "0x9832B0", VA = "0x180983EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8450", Offset = "0x6DF7850", VA = "0x186DF8450")]
	public LLIBDAEGOMJ(HGNLGNGAOFB ECBMIENEKMI, Action<HGNLGNGAOFB> CPMDLEFPCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8060", Offset = "0x6DF7460", VA = "0x186DF8060")]
	public bool HEDCOPEMPIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7C00", Offset = "0x6DF7000", VA = "0x186DF7C00")]
	public static string AGEDGOHLFLF(string IIALBNBNCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7D80", Offset = "0x6DF7180", VA = "0x186DF7D80")]
	protected internal void BJEAJLDHIPE(object EPLPPJHJIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7D90", Offset = "0x6DF7190", VA = "0x186DF7D90")]
	protected internal bool DKKJPNHADMI()
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
