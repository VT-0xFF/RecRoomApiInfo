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
public interface LFPBGMALGLA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> LLMBGDGDGOM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBKPCPLMDPD(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGBIFJGPIHI(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMNMHJDPMHN(object FLLNLBHFENG, bool PGBODBNFMND);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable HKJIFGJHNKK();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NABDBHOPGNJ();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGMFFNOJNBJ(StringBuilder POJKCMOJLCI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DPFHLHPEHLO(bool HEIPIBIBDKL, [Out] string ENDMINEHNJK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JJGGBNHEIBM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LHMCHGMOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	EHBONCGFHOO KAODIPEBEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LOPEMKADCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GPFPHJNGMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MNPCDNDHPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DIEEPLKNKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FBOHBKFMNCK BOELIPGODKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BLLOMOMLFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EHBONCGFHOO, EHBONCGFHOO> EFJNHOEMOEG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMPFAHEBJLM(GIJMDANJJLD GHAOBMIKKNE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ELFAMGJFLCH();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FFODBJMFKKG(string POLODAGLAGH, BMDNOPNLGKN JMNNPKGAACF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OBAKEPHIELP();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LLMBHBDGIOB(AppSettings NKBIMFAFMHM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EHBONCGFHOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JGPIHEEFEOI BNBEBNCALEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	PHDHAGPLOKM CFGFEEHJAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DIEEPLKNKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LOPEMKADCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HGHFCNHPJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception EECMFAOEHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode IGNDBAEPBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GIJMDANJJLD.DONLMOLJOLL IDJBLIEMLMP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<JGPIHEEFEOI, JGPIHEEFEOI> LNDPMGAIEKO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNFJKKPANGI(object LLMCGMPLMBL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGEENNEGECD(object EOCJHFGHBGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void DJIPEOGFHJA(byte MPCHJCCFIKH, int MPNIFGFJIPM, object GIEOAGIJFBB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NDFDKFMNCOI
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GIJMDANJJLD.DONLMOLJOLL IDJBLIEMLMP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DJIPEOGFHJA NPFBOIGGLFH;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PHELLDCEDPK(byte MPCHJCCFIKH, Hashtable EIHMKDMMCON, JDPGDEJLHAK JHPFNNLCLMJ, SendOptions MLLJNHKPFAI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MEEPNJMHOOA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PDPPFLAPOCL BBCDFEPIACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int PACBCMBLHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int PLPJJKNKAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int GEAAJGJGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<PDPPFLAPOCL> KJEDPAEBLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	PDPPFLAPOCL PBJFHGDMOMO(int DKOHPFNHOFE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KPBGJCJHBMM
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action CAKIOOCNOJA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOLDEPFJNPC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EGBHJBCMIAK : JJGGBNHEIBM, LFPBGMALGLA, NDFDKFMNCOI, MEEPNJMHOOA, KPBGJCJHBMM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int NFDBBMGHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int HAKCIBCFEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float POBONMNBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float FOAAOMLEEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GMDHIOIBGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LGPCAMFCGKG EJDLKHAJJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action HHCJBGAKPIC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLFDDFIBLPI();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIHDFDKFKDL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FECADBEKBAD(string JLPCILFKLEI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LGPCAMFCGKG
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PALLOKJHOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CIMDDPDAION
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<AKLFOLBIMAG> HKIHCBOGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LMMAGGKDPIB(Action DIOOLNHNLCP, string CAJNFEBHEGO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DOEGOLPCMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string NCGKNKLMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 EHFBMINIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion BHOIDFFDPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 CCGIGJECGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int BFFKBOLIGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> FNHBJMNDPJP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C08C30", Offset = "0x6C07230", VA = "0x186C08C30")]
	public object[] PEALNENAOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public DOEGOLPCMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PLMKGFBKDPG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BC90", Offset = "0x6C0A290", VA = "0x186C0BC90")]
	public static bool IJLECGMGAIC(this JJGGBNHEIBM BHEMNKBLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BBC0", Offset = "0x6C0A1C0", VA = "0x186C0BBC0")]
	public static bool GDABHMGKKKA(this JJGGBNHEIBM BHEMNKBLOGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class NHPPHKELKDG : EGBHJBCMIAK, JJGGBNHEIBM, LFPBGMALGLA, NDFDKFMNCOI, MEEPNJMHOOA, KPBGJCJHBMM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class IKINKCKKBEJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NHPPHKELKDG HNCEIAEPLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HFIMBOHAJFI;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C097B0", Offset = "0x6C07DB0", VA = "0x186C097B0")]
		public IKINKCKKBEJ(NHPPHKELKDG HNCEIAEPLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C096B0", Offset = "0x6C07CB0", VA = "0x186C096B0", Slot = "1")]
		~IKINKCKKBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6C09620", Offset = "0x6C07C20", VA = "0x186C09620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C09750", Offset = "0x6C07D50", VA = "0x186C09750")]
		private void JADENJNDAJM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object ENOFBHOAOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object BAGHMBEPKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float OOMAHONMGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float AKOHPOBALMB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool BLLOMOMLFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float MCGOKDGBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int NFDBBMGHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int HAKCIBCFEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract PDPPFLAPOCL BBCDFEPIACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PACBCMBLHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B080", Offset = "0x6C09680", VA = "0x186C0B080", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int PLPJJKNKAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int GEAAJGJGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B0F0", Offset = "0x6C096F0", VA = "0x186C0B0F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float POBONMNBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D50", Offset = "0x9F1350", VA = "0x1809F2D50", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AFA0", Offset = "0x6C095A0", VA = "0x186C0AFA0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float FOAAOMLEEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D10", Offset = "0x9F1310", VA = "0x1809F2D10", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B670", Offset = "0x6C09C70", VA = "0x186C0B670", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool GMDHIOIBGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract LGPCAMFCGKG EJDLKHAJJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool LHMCHGMOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract EHBONCGFHOO KAODIPEBEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool LOPEMKADCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool GPFPHJNGMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool MNPCDNDHPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool DIEEPLKNKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract FBOHBKFMNCK BOELIPGODKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private GLGPGBPNFLE FOJDIJLMKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private GLGPGBPNFLE CKHHGJCCBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private EKKHBMHPFLJ<Func<float>> GAGCLKICPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool APGCHMJFCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1000480", Offset = "0xFFEA80", VA = "0x181000480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool BMJPCBJOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AF50", Offset = "0x6C09550", VA = "0x186C0AF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool GCOHJOAKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B630", Offset = "0x6C09C30", VA = "0x186C0B630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event GIJMDANJJLD.DONLMOLJOLL IDJBLIEMLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A920", Offset = "0x6C08F20", VA = "0x186C0A920", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A400", Offset = "0x6C08A00", VA = "0x186C0A400", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event DJIPEOGFHJA NPFBOIGGLFH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<PDPPFLAPOCL> KJEDPAEBLIJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<EHBONCGFHOO, EHBONCGFHOO> EFJNHOEMOEG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> LLMBGDGDGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A730", Offset = "0x6C08D30", VA = "0x186C0A730", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A7E0", Offset = "0x6C08DE0", VA = "0x186C0A7E0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action HHCJBGAKPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A690", Offset = "0x6C08C90", VA = "0x186C0A690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AFE0", Offset = "0x6C095E0", VA = "0x186C0AFE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action CAKIOOCNOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AD70", Offset = "0x6C09370", VA = "0x186C0AD70", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C0ACD0", Offset = "0x6C092D0", VA = "0x186C0ACD0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract PDPPFLAPOCL PBJFHGDMOMO(int DKOHPFNHOFE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool LLMBHBDGIOB(AppSettings NKBIMFAFMHM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void OBAKEPHIELP();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool ELFAMGJFLCH();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void JEPNIFHJECL();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool PHELLDCEDPK(byte MPCHJCCFIKH, Hashtable EIHMKDMMCON, JDPGDEJLHAK JHPFNNLCLMJ, SendOptions MLLJNHKPFAI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool FFODBJMFKKG(string POLODAGLAGH, BMDNOPNLGKN JMNNPKGAACF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void FECADBEKBAD(string JLPCILFKLEI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void DMPFAHEBJLM(GIJMDANJJLD GHAOBMIKKNE);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BA40", Offset = "0x6C0A040", VA = "0x186C0BA40")]
	protected NHPPHKELKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A520", Offset = "0x6C08B20", VA = "0x186C0A520")]
	public void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A990", Offset = "0x6C08F90", VA = "0x186C0A990", Slot = "35")]
	public void DMNMHJDPMHN(object FLLNLBHFENG, bool PGBODBNFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A590", Offset = "0x6C08B90", VA = "0x186C0A590", Slot = "33")]
	public void BBKPCPLMDPD(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B180", Offset = "0x6C09780", VA = "0x186C0B180", Slot = "34")]
	public void LGBIFJGPIHI(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AEC0", Offset = "0x6C094C0", VA = "0x186C0AEC0", Slot = "36")]
	public IDisposable HKJIFGJHNKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AAB0", Offset = "0x6C090B0", VA = "0x186C0AAB0", Slot = "91")]
	public virtual bool DPFHLHPEHLO(bool HEIPIBIBDKL, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B440", Offset = "0x6C09A40", VA = "0x186C0B440")]
	private bool LIOMFFIEOIK([Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B860", Offset = "0x6C09E60", VA = "0x186C0B860")]
	private bool PEDABPIHPIC([Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B5E0", Offset = "0x6C09BE0", VA = "0x186C0B5E0", Slot = "37")]
	public bool NABDBHOPGNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B1C0", Offset = "0x6C097C0", VA = "0x186C0B1C0", Slot = "38")]
	public void LGMFFNOJNBJ(StringBuilder POJKCMOJLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B6B0", Offset = "0x6C09CB0", VA = "0x186C0B6B0")]
	private void OKPNKLCMJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A890", Offset = "0x6C08E90", VA = "0x186C0A890")]
	private void CPAIPCMHGLF(Func<float> CPBNOBEDLLP, object FLLNLBHFENG, int OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B8F0", Offset = "0x6C09EF0", VA = "0x186C0B8F0", Slot = "92")]
	public void PIFAPPBNKOH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B9B0", Offset = "0x6C09FB0", VA = "0x186C0B9B0", Slot = "8")]
	public void PLFDDFIBLPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B950", Offset = "0x6C09F50", VA = "0x186C0B950", Slot = "9")]
	public void PIHDFDKFKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A470", Offset = "0x6C08A70", VA = "0x186C0A470")]
	private void AGGKIJMKBLC(float PFFHGEAHJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9F2D10", Offset = "0x9F1310", VA = "0x1809F2D10")]
	private float PNGINGACANJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9F2D50", Offset = "0x9F1350", VA = "0x1809F2D50")]
	private float NBGFPOBLLNP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AE10", Offset = "0x6C09410", VA = "0x186C0AE10")]
	private void HAOLHKKOCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A540", Offset = "0x6C08B40", VA = "0x186C0A540", Slot = "55")]
	public void AOLDEPFJNPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KFGFNNNMJLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string HDHIJOFHFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool FJDOALBDLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool MHJAKLDDDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int AODDKKMEPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] IDDDOICBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte MAEANMHLOJI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random IONJPKBAFGC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A1E0", Offset = "0x6C087E0", VA = "0x186C0A1E0", Slot = "5")]
	public virtual bool CJGILICNEOL(string HNBGNGBFBJO, int EHGIOJOEILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A230", Offset = "0x6C08830", VA = "0x186C0A230", Slot = "6")]
	public virtual bool DFFMEBICBNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A280", Offset = "0x6C08880", VA = "0x186C0A280", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A160", Offset = "0x6C08760", VA = "0x186C0A160")]
	protected internal void AMLGEKNOMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A350", Offset = "0x6C08950", VA = "0x186C0A350")]
	protected KFGFNNNMJLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KENAIBGLICP : KFGFNNNMJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket KHHLACLMCDA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C09BF0", Offset = "0x6C081F0", VA = "0x186C09BF0", Slot = "5")]
	public override bool CJGILICNEOL(string HNBGNGBFBJO, int EHGIOJOEILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C09E90", Offset = "0x6C08490", VA = "0x186C09E90", Slot = "6")]
	public override bool DFFMEBICBNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x619E290", Offset = "0x619C890", VA = "0x18619E290", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A080", Offset = "0x6C08680", VA = "0x186C0A080")]
	public KENAIBGLICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KADAJPPOADL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string IHEMAPGJOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string IIDIHLLHELM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string NICPHONGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BONKGLCOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x886FD0", Offset = "0x8855D0", VA = "0x180886FD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x887000", Offset = "0x885600", VA = "0x180887000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C09AD0", Offset = "0x6C080D0", VA = "0x186C09AD0")]
	public KADAJPPOADL(string LPOJEHINHEE, string LKGIJLGOFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C09810", Offset = "0x6C07E10", VA = "0x186C09810")]
	private void IDHJHGJAEOG(string APICNEJDKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C09A10", Offset = "0x6C08010", VA = "0x186C09A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C09920", Offset = "0x6C07F20", VA = "0x186C09920")]
	public string MDLPOLGBHOH(bool ANFFFJNHKME = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FPBAAAKJOCP
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int PEPCAPCONPE;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool BMFOBOFCBAA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int HFMNGPPCGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int JANMHABLJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KADAJPPOADL EFLKPHHNFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string GBHJIJJPKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int ANGLDPJJKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int NHBHLDIOBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<KADAJPPOADL> CHMMPLOLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KFGFNNNMJLK GNENCDICEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> AIKIDNFJNBC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DFFMEBICBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A00", Offset = "0xCE8000", VA = "0x180CE9A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C09570", Offset = "0x6C07B70", VA = "0x186C09570")]
	public FPBAAAKJOCP(KADAJPPOADL EFLKPHHNFHI, Action<KADAJPPOADL> JNHBPEJCNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C09190", Offset = "0x6C07790", VA = "0x186C09190")]
	public bool LHKIFFPBGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C09010", Offset = "0x6C07610", VA = "0x186C09010")]
	public static string GBPAIGMNDLK(string CLFBLMLOENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C08D40", Offset = "0x6C07340", VA = "0x186C08D40")]
	protected internal void BJGEGHJIJDK(object EIGKPCONJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C08D50", Offset = "0x6C07350", VA = "0x186C08D50")]
	protected internal bool GACBKFNMKLK()
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
