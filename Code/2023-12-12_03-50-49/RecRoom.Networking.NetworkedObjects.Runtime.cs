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
public interface NLKMEMNLAFE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> PKMIPFPKOMF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDPDLKDMFPD(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMPMHDEPEJD(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJPOKLGEPDO(object JECMOKMEJED, bool MLFCCKHAIIN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable GJLGLBPEFFK();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NIMDJDGNOOP();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KFPGEEODODF(StringBuilder OAKKIFHHOGH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FACPKIOCMGE(bool DLFCPMFIIJJ, [Out] string MFCNDEMKIPG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GCOFIOMEJDP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BNAFFFCGBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	PEACEHFJGCK JCHENLPFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LLHFPLLNKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OPGIDMDGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AANKNDBNINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KFBBOPLNFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GHEAHNBCLCC MFOHPGBLADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JJPBOMLFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PEACEHFJGCK, PEACEHFJGCK> KCCGCDFKLGE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBMKDEJBPBD(IMEGACCGMEK KIBGBCJBFKO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CBPCGIDPKFD();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CBKAFHKJEPB(string GOCEMKDJICL, EBJJJBNOLDN PPODFDIOILP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NFCDIHLBOOI();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IEMGPFHOBDD(AppSettings JDPCLHIJPEN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PEACEHFJGCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NOINEPPEEGA ILHLKOLIIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	DNGBCBFLFAI JIGFKEHIBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KFBBOPLNFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LLHFPLLNKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool OKGKKMGGLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception IJJNMHGEIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode CPAODDPJAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IMEGACCGMEK.PDHOALKDPPB FAMJOHFDOBD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NOINEPPEEGA, NOINEPPEEGA> DCEAGEGIOMA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHANKCPMNBM(object MAKBFCPADHF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CCDHPMMOJAF(object MAEAKDLONOA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NCICOIIMKIA(byte GKBPPPKCOAB, int MFBGJFAHOLK, object EMCOMEIJNKO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BMONNKBBKKL
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IMEGACCGMEK.PDHOALKDPPB FAMJOHFDOBD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NCICOIIMKIA NFJEBGKOEGK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CMEGJIBLFNP(byte GKBPPPKCOAB, Hashtable PDCCJLNBJPF, EJKNNKHBDKB EIOOCJGFFIA, SendOptions IBKGCFKOBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MNCNKKJLBBN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PDJKNJCPPID BDBPKPKNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int OKEHNCCFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int NFNPLEDFOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EMOEEOPMKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int JDKJBJIGGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<PDJKNJCPPID> MJENFFAEKCM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	PDJKNJCPPID IIGPPKEEPHC(int OBBDABPEFLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MLGLJJAJFDI
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BNMBHCEADBB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFGMBGMMGNH();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FBOMPCMDFLJ : GCOFIOMEJDP, NLKMEMNLAFE, BMONNKBBKKL, MNCNKKJLBBN, MLGLJJAJFDI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int BNPPCLNHHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NMANPKDJOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float IEDDCFLGPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float OIKOONMEIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OFACJJOBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MPGANMCOFOO DCHCILAPDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action DBHALNONFGL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DINDILADLAL();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHILIMCABBM();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OEOCBAPKJMF(string KHNDHKFMPIN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MPGANMCOFOO
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DHMCDEAJJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IHCCOPLILBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<JONBIOOHMKP> DDFFKGGFHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBHJFMDNJMN(Action NEGJEJPPLMF, string MNGFPJPONCO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FAIHBEOPELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string HMNPCIDNNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 HNCNNHBNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion HPENPABNLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 MHKMAHEHDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CJGBKMCKCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> PELPLJNGFCA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E650F0", Offset = "0x5E638F0", VA = "0x185E650F0")]
	public object[] HNIKKAOCAIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public FAIHBEOPELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KHOMPPHOEHP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E65DC0", Offset = "0x5E645C0", VA = "0x185E65DC0")]
	public static bool OMDAFHFIFBK(this GCOFIOMEJDP KELNAIEBNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E65CF0", Offset = "0x5E644F0", VA = "0x185E65CF0")]
	public static bool OAJMDKBMNPH(this GCOFIOMEJDP KELNAIEBNME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class BDOOHKPKEJO : FBOMPCMDFLJ, GCOFIOMEJDP, NLKMEMNLAFE, BMONNKBBKKL, MNCNKKJLBBN, MLGLJJAJFDI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class JLLCDPJNILE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BDOOHKPKEJO CPGPOMHLLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HDNMPGDBKCJ;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E65C90", Offset = "0x5E64490", VA = "0x185E65C90")]
		public JLLCDPJNILE(BDOOHKPKEJO CPGPOMHLLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E65BF0", Offset = "0x5E643F0", VA = "0x185E65BF0", Slot = "1")]
		~JLLCDPJNILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E65B60", Offset = "0x5E64360", VA = "0x185E65B60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E65B00", Offset = "0x5E64300", VA = "0x185E65B00")]
		private void BDICKKDBJFH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object JBJHHDHAIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object PDICGKIGOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float NMEEPCFAIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float MGNHJPDNLFB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool JJPBOMLFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float BNHHDAGEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int BNPPCLNHHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int NMANPKDJOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract PDJKNJCPPID BDBPKPKNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OKEHNCCFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E644A0", Offset = "0x5E62CA0", VA = "0x185E644A0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int NFNPLEDFOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int JDKJBJIGGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool EMOEEOPMKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E63B30", Offset = "0x5E62330", VA = "0x185E63B30", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float IEDDCFLGPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C8210", Offset = "0x7C6A10", VA = "0x1807C8210", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E63C60", Offset = "0x5E62460", VA = "0x185E63C60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float OIKOONMEIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C8AE0", Offset = "0x7C72E0", VA = "0x1807C8AE0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E63BC0", Offset = "0x5E623C0", VA = "0x185E63BC0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool OFACJJOBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract MPGANMCOFOO DCHCILAPDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool BNAFFFCGBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract PEACEHFJGCK JCHENLPFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool LLHFPLLNKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool OPGIDMDGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool AANKNDBNINB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool KFBBOPLNFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract GHEAHNBCLCC MFOHPGBLADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private GOLBCHGOILO CIGBGMAJBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private GOLBCHGOILO JNIMGMCAPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private FLFGEOKLLIE<Func<float>> DFOBFMBMDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool ANFJIHLMCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC21240", Offset = "0xC1FA40", VA = "0x180C21240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool NBFOPACJMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E64330", Offset = "0x5E62B30", VA = "0x185E64330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool LHJMAOFJFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E64510", Offset = "0x5E62D10", VA = "0x185E64510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event IMEGACCGMEK.PDHOALKDPPB FAMJOHFDOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E63920", Offset = "0x5E62120", VA = "0x185E63920", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E63CA0", Offset = "0x5E624A0", VA = "0x185E63CA0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event NCICOIIMKIA NFJEBGKOEGK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<PDJKNJCPPID> MJENFFAEKCM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<PEACEHFJGCK, PEACEHFJGCK> KCCGCDFKLGE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> PKMIPFPKOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E63380", Offset = "0x5E61B80", VA = "0x185E63380", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E63F90", Offset = "0x5E62790", VA = "0x185E63F90", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action DBHALNONFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E64090", Offset = "0x5E62890", VA = "0x185E64090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E63650", Offset = "0x5E61E50", VA = "0x185E63650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action BNMBHCEADBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E636F0", Offset = "0x5E61EF0", VA = "0x185E636F0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E63880", Offset = "0x5E62080", VA = "0x185E63880", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract PDJKNJCPPID IIGPPKEEPHC(int OBBDABPEFLJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool IEMGPFHOBDD(AppSettings JDPCLHIJPEN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void NFCDIHLBOOI();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool CBPCGIDPKFD();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void PJMFOGLKGFK();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool CMEGJIBLFNP(byte GKBPPPKCOAB, Hashtable PDCCJLNBJPF, EJKNNKHBDKB EIOOCJGFFIA, SendOptions IBKGCFKOBDM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool CBKAFHKJEPB(string GOCEMKDJICL, EBJJJBNOLDN PPODFDIOILP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void OEOCBAPKJMF(string KHNDHKFMPIN);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void MBMKDEJBPBD(IMEGACCGMEK KIBGBCJBFKO);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E64620", Offset = "0x5E62E20", VA = "0x185E64620")]
	protected BDOOHKPKEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E63360", Offset = "0x5E61B60", VA = "0x185E63360")]
	public void EBEAKPIECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E64380", Offset = "0x5E62B80", VA = "0x185E64380", Slot = "35")]
	public void OJPOKLGEPDO(object JECMOKMEJED, bool MLFCCKHAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64130", Offset = "0x5E62930", VA = "0x185E64130", Slot = "33")]
	public void NDPDLKDMFPD(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E64550", Offset = "0x5E62D50", VA = "0x185E64550", Slot = "34")]
	public void PMPMHDEPEJD(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E63790", Offset = "0x5E61F90", VA = "0x185E63790", Slot = "36")]
	public IDisposable GJLGLBPEFFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E63430", Offset = "0x5E61C30", VA = "0x185E63430", Slot = "91")]
	public virtual bool FACPKIOCMGE(bool DLFCPMFIIJJ, [Out] string MFCNDEMKIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E63990", Offset = "0x5E62190", VA = "0x185E63990")]
	private bool HKCCJFFNKNP([Out] string MFCNDEMKIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E63240", Offset = "0x5E61A40", VA = "0x185E63240")]
	private bool BHMGMMOIOOP([Out] string MFCNDEMKIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E64230", Offset = "0x5E62A30", VA = "0x185E64230", Slot = "37")]
	public bool NIMDJDGNOOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E63D10", Offset = "0x5E62510", VA = "0x185E63D10", Slot = "38")]
	public void KFPGEEODODF(StringBuilder OAKKIFHHOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E63090", Offset = "0x5E61890", VA = "0x185E63090")]
	private void ANLAIIHMPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5E64590", Offset = "0x5E62D90", VA = "0x185E64590")]
	private void POMADHFLAJM(Func<float> ODAAACMHJBH, object JECMOKMEJED, int LPKKLMEOBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E63820", Offset = "0x5E62020", VA = "0x185E63820", Slot = "92")]
	public void GPLIKLIMINM(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E632D0", Offset = "0x5E61AD0", VA = "0x185E632D0", Slot = "8")]
	public void DINDILADLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5E63C00", Offset = "0x5E62400", VA = "0x185E63C00", Slot = "9")]
	public void IHILIMCABBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E62FE0", Offset = "0x5E617E0", VA = "0x185E62FE0")]
	private void AEDDKNAICAG(float ILOOJEFCFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AE0", Offset = "0x7C72E0", VA = "0x1807C8AE0")]
	private float OLJENIDMMDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C8210", Offset = "0x7C6A10", VA = "0x1807C8210")]
	private float CLLLEDJJBNB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E64280", Offset = "0x5E62A80", VA = "0x185E64280")]
	private void OBNIEBBPHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E64040", Offset = "0x5E62840", VA = "0x185E64040", Slot = "55")]
	public void MFGMBGMMGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KKPPDBDEHBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string DLIPPIECCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool OJKMKLMECBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool HFAFPCGOEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int ADEACPCHNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] CLPBFPHHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte MBNBMBLFJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random MJGECLAPLBJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E65F80", Offset = "0x5E64780", VA = "0x185E65F80", Slot = "5")]
	public virtual bool ENGPBIMEMMK(string INKOMIGJMHG, int DFIMNCLPENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E65F30", Offset = "0x5E64730", VA = "0x185E65F30", Slot = "6")]
	public virtual bool EFBOGCIBLPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E65EE0", Offset = "0x5E646E0", VA = "0x185E65EE0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E65E60", Offset = "0x5E64660", VA = "0x185E65E60")]
	protected internal void DNNHMGCFPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E66050", Offset = "0x5E64850", VA = "0x185E66050")]
	protected KKPPDBDEHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EFPDAOFPJOI : KKPPDBDEHBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket JHMFDGCIEHO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E64D70", Offset = "0x5E63570", VA = "0x185E64D70", Slot = "5")]
	public override bool ENGPBIMEMMK(string INKOMIGJMHG, int DFIMNCLPENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E64B80", Offset = "0x5E63380", VA = "0x185E64B80", Slot = "6")]
	public override bool EFBOGCIBLPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x554C200", Offset = "0x554AA00", VA = "0x18554C200", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E65010", Offset = "0x5E63810", VA = "0x185E65010")]
	public EFPDAOFPJOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CGMBHJJNOLN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string MBFCLMPFMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FAHMJLAGENI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string BDOCNOAPOEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JMGFIOCHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7733B0", Offset = "0x771BB0", VA = "0x1807733B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x773B30", Offset = "0x772330", VA = "0x180773B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E64A60", Offset = "0x5E63260", VA = "0x185E64A60")]
	public CGMBHJJNOLN(string CNEDHPANOLF, string CBDHFBPDECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E64890", Offset = "0x5E63090", VA = "0x185E64890")]
	private void KJHHMOLCLFO(string ELMHPMPBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E649A0", Offset = "0x5E631A0", VA = "0x185E649A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E647A0", Offset = "0x5E62FA0", VA = "0x185E647A0")]
	public string DPNNJPNFPAA(bool HOHKJKPMDLP = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IPANHFLJFDF
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int LHANLOMLLKK;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool EOFMILNGCGA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int NGMGAFGLNEG;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int HMEAPJBJKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CGMBHJJNOLN ACGNJIAONHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string HHCCDFAMGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int OHBFPBLKMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int KCNOHNCPCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<CGMBHJJNOLN> JHOBCLIHMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KKPPDBDEHBL NNNHFHBNGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> CBHHMNHHMEH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EFBOGCIBLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x854330", Offset = "0x852B30", VA = "0x180854330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x90C880", Offset = "0x90B080", VA = "0x18090C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E65A50", Offset = "0x5E64250", VA = "0x185E65A50")]
	public IPANHFLJFDF(CGMBHJJNOLN ACGNJIAONHF, Action<CGMBHJJNOLN> NOCPPCNLKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E65390", Offset = "0x5E63B90", VA = "0x185E65390")]
	public bool KFEANBKPEKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E65200", Offset = "0x5E63A00", VA = "0x185E65200")]
	public static string CCPBEGLGOGE(string NMLMMADHOHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E65380", Offset = "0x5E63B80", VA = "0x185E65380")]
	protected internal void IIMIHPKCJLC(object LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E65700", Offset = "0x5E63F00", VA = "0x185E65700")]
	protected internal bool MMKFFOOHFLP()
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
