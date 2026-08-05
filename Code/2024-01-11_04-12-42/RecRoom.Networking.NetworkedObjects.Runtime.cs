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
public interface LJLCIOCIIDD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> MIPEKDGMJFN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEBEEGJOJDM(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDCNEPGGIOF(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEMAMJAMMCC(object BDAPLOBBPIE, bool OFPOMEHEGEL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable GJOCFBGPOMB();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BIPAEOKFOJP();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OOJOJFHABDO(StringBuilder DGBGLCLCFMD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BIIEKFOHILO(bool GOIJFHJFPBC, [Out] string BNFACNGELAB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ICDGMBONFII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BMKIOPLIFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	KMGAEGLJBGH EMMFGOJIGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BJCOIFIHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OAOMADFANAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MMNKKKHPGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HMMPEHCEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MCCMMCPIJPD GHINGJFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MKHINJHDKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KMGAEGLJBGH, KMGAEGLJBGH> FIBLFOALNDL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIJIMBDOIOD(HFFMOPCGOHE GABNAIJAADN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GLLAHCOPFIF();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HPONAPFBJLO(string EHJGKEGBPPH, IKHLENIGHHN FDOGGONIABM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void POJGPHKBILJ();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OMKEBDMGMCE(AppSettings OHAPJJOEOEN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMGAEGLJBGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JJLNDEPIAHA EGFMKNFPPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	DDBKFNGNFID PFNCACAKDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HMMPEHCEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool BJCOIFIHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JNCNHAHLDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception BOPEMDDMBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode GGFPKCAIJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HFFMOPCGOHE.ABIHKBFMDLH GGNDFIKBFBJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<JJLNDEPIAHA, JJLNDEPIAHA> HOKCHGIHDLE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ENIAFAJGNKM(object DMFBOAFMPLH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LEPJNHHMNGC(object KFHMCPHEBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void DMMAEIOANOJ(byte EMFBPPDJENJ, int EDBGGPJNMLJ, object KMDMCPBDECK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FDPLJKNOMOI
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HFFMOPCGOHE.ABIHKBFMDLH GGNDFIKBFBJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DMMAEIOANOJ OEEKFCGIDPG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KGFLDODNAKJ(byte EMFBPPDJENJ, Hashtable FOAINHPNLPJ, OCBJOEIDGLH GBDEENEOPNB, SendOptions NFJMCHCCCLD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IEIHHOBKAEK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	ALIAPFOBNEL ODCOGFDDMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int HMMDFIIEOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int FIAFILIMMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KLEPALACFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int GMKEKLFANIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<ALIAPFOBNEL> EKJOFDIOFPK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	ALIAPFOBNEL KPBJPBLKLDA(int JHCPMDFIMFL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CPPMPJGPIEF
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PDLCMCICFLG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLMNBBPLJGI();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DJLKKFCHNFG : ICDGMBONFII, LJLCIOCIIDD, FDPLJKNOMOI, IEIHHOBKAEK, CPPMPJGPIEF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int FCDNEKDJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int MLGMEDFDKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float PLEKLCGIFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float HEIGHCJAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PNDKCKNGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LNKFJOABLGM NJMJIHDJPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action DMIHAPHLPKA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNFODCMOAAE();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJLKEJEIAKP();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LHHFPLMLLMH(string FBLBAMLIIID);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LNKFJOABLGM
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JKNPKFGGFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GPBFHIFKMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<PIGJDHGBGPN> OAOLOEEPOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKEIFHFHBDL(Action DABLOLOMOFD, string POIFFOLJPIC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JOBJBPGPPEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string FHAFCCICDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 LMPBAOBONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion AMNPPNHEHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 NJJFPNKONPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int FCNCNPGJCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> PKNNODIBECM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x602AD80", Offset = "0x6029780", VA = "0x18602AD80")]
	public object[] IPGDPPHMNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JOBJBPGPPEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MFBDDJLPICN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x602AF60", Offset = "0x6029960", VA = "0x18602AF60")]
	public static bool HHNEPMMGBAM(this ICDGMBONFII GMNFFGNGCPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x602AE90", Offset = "0x6029890", VA = "0x18602AE90")]
	public static bool HCDMKBDFIGB(this ICDGMBONFII GMNFFGNGCPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PDEOGMOEAAD : DJLKKFCHNFG, ICDGMBONFII, LJLCIOCIIDD, FDPLJKNOMOI, IEIHHOBKAEK, CPPMPJGPIEF
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class HPJBKDHBKAD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PDEOGMOEAAD KGDEEGJDPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BDLHHIBLMII;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x602A940", Offset = "0x6029340", VA = "0x18602A940")]
		public HPJBKDHBKAD(PDEOGMOEAAD KGDEEGJDPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x602A840", Offset = "0x6029240", VA = "0x18602A840", Slot = "1")]
		~HPJBKDHBKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x602A7B0", Offset = "0x60291B0", VA = "0x18602A7B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x602A8E0", Offset = "0x60292E0", VA = "0x18602A8E0")]
		private void HMNODAOPEAA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object NCDIPKAJKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object HDALEONENOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float MHMNNAGDIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float LCKJFMGNGIM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool MKHINJHDKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float NCCOMJMPKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int FCDNEKDJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int MLGMEDFDKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract ALIAPFOBNEL ODCOGFDDMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HMMDFIIEOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x602B570", Offset = "0x6029F70", VA = "0x18602B570", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int FIAFILIMMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int GMKEKLFANIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool KLEPALACFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x602B000", Offset = "0x6029A00", VA = "0x18602B000", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float PLEKLCGIFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E3010", Offset = "0x7E1A10", VA = "0x1807E3010", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x602B360", Offset = "0x6029D60", VA = "0x18602B360", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float HEIGHCJAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7E3300", Offset = "0x7E1D00", VA = "0x1807E3300", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x602BB70", Offset = "0x602A570", VA = "0x18602BB70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool PNDKCKNGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract LNKFJOABLGM NJMJIHDJPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool BMKIOPLIFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract KMGAEGLJBGH EMMFGOJIGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool BJCOIFIHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool OAOMADFANAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool MMNKKKHPGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool HMMPEHCEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract MCCMMCPIJPD GHINGJFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private NFHAIGOLJDB GCNJBCMMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private NFHAIGOLJDB MLAAMEGFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private CHFHMHFCHNC<Func<float>> OAJDIALKELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool LKLKHPOEEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC4E5A0", Offset = "0xC4CFA0", VA = "0x180C4E5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool DAPJGAFINCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x602BFF0", Offset = "0x602A9F0", VA = "0x18602BFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool CHHEEKOPJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x602B7A0", Offset = "0x602A1A0", VA = "0x18602B7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event HFFMOPCGOHE.ABIHKBFMDLH GGNDFIKBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x602BED0", Offset = "0x602A8D0", VA = "0x18602BED0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x602B5E0", Offset = "0x6029FE0", VA = "0x18602B5E0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event DMMAEIOANOJ OEEKFCGIDPG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<ALIAPFOBNEL> EKJOFDIOFPK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<KMGAEGLJBGH, KMGAEGLJBGH> FIBLFOALNDL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> MIPEKDGMJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x602B7E0", Offset = "0x602A1E0", VA = "0x18602B7E0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x602C310", Offset = "0x602AD10", VA = "0x18602C310", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action DMIHAPHLPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x602B890", Offset = "0x602A290", VA = "0x18602B890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x602BBB0", Offset = "0x602A5B0", VA = "0x18602BBB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action PDLCMCICFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x602C040", Offset = "0x602AA40", VA = "0x18602C040", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x602B700", Offset = "0x602A100", VA = "0x18602B700", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract ALIAPFOBNEL KPBJPBLKLDA(int JHCPMDFIMFL);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool OMKEBDMGMCE(AppSettings OHAPJJOEOEN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void POJGPHKBILJ();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool GLLAHCOPFIF();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void MFBGJIAPFHL();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool KGFLDODNAKJ(byte EMFBPPDJENJ, Hashtable FOAINHPNLPJ, OCBJOEIDGLH GBDEENEOPNB, SendOptions NFJMCHCCCLD);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool HPONAPFBJLO(string EHJGKEGBPPH, IKHLENIGHHN FDOGGONIABM);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void LHHFPLMLLMH(string FBLBAMLIIID);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void CIJIMBDOIOD(HFFMOPCGOHE GABNAIJAADN);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x602C640", Offset = "0x602B040", VA = "0x18602C640")]
	protected PDEOGMOEAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x602BC50", Offset = "0x602A650", VA = "0x18602BC50")]
	public void IAMMEFBKIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x602B9C0", Offset = "0x602A3C0", VA = "0x18602B9C0", Slot = "35")]
	public void GEMAMJAMMCC(object BDAPLOBBPIE, bool OFPOMEHEGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x602B470", Offset = "0x6029E70", VA = "0x18602B470", Slot = "33")]
	public void DEBEEGJOJDM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x602B430", Offset = "0x6029E30", VA = "0x18602B430", Slot = "34")]
	public void DDCNEPGGIOF(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x602BAE0", Offset = "0x602A4E0", VA = "0x18602BAE0", Slot = "36")]
	public IDisposable GJOCFBGPOMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x602B090", Offset = "0x6029A90", VA = "0x18602B090", Slot = "91")]
	public virtual bool BIIEKFOHILO(bool GOIJFHJFPBC, [Out] string BNFACNGELAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x602C0E0", Offset = "0x602AAE0", VA = "0x18602C0E0")]
	private bool MOEAIEFAHNP([Out] string BNFACNGELAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x602C280", Offset = "0x602AC80", VA = "0x18602C280")]
	private bool OCMKGOEECMM([Out] string BNFACNGELAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x602B2B0", Offset = "0x6029CB0", VA = "0x18602B2B0", Slot = "37")]
	public bool BIPAEOKFOJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x602C3C0", Offset = "0x602ADC0", VA = "0x18602C3C0", Slot = "38")]
	public void OOJOJFHABDO(StringBuilder DGBGLCLCFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x602BC70", Offset = "0x602A670", VA = "0x18602BC70")]
	private void JBNKEEHJOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x602B3A0", Offset = "0x6029DA0", VA = "0x18602B3A0")]
	private void DCAAKCKMLCF(Func<float> MKOBFGBNPPM, object BDAPLOBBPIE, int HPLMCDPDBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x602B300", Offset = "0x6029D00", VA = "0x18602B300", Slot = "92")]
	public void COABFEGHGCL(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x602B930", Offset = "0x602A330", VA = "0x18602B930", Slot = "8")]
	public void FNFODCMOAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x602B650", Offset = "0x602A050", VA = "0x18602B650", Slot = "9")]
	public void DJLKEJEIAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x602BE20", Offset = "0x602A820", VA = "0x18602BE20")]
	private void JCHFGFOFCHF(float CEEPHBKGJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E3300", Offset = "0x7E1D00", VA = "0x1807E3300")]
	private float OOAPELIEKMJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E3010", Offset = "0x7E1A10", VA = "0x1807E3010")]
	private float FDBMGHIPDBA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x602BF40", Offset = "0x602A940", VA = "0x18602BF40")]
	private void LIKOOMBBKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x602B6B0", Offset = "0x602A0B0", VA = "0x18602B6B0", Slot = "55")]
	public void DLMNBBPLJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HPBIJLEHDPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string FLOKPEBNHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool FHIGFFFOHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool CPIKHDOLEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int EKCJGOABNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] PNBGEBHGIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte HINPMCEEOAJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random LBBBIPKILJL;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x602A630", Offset = "0x6029030", VA = "0x18602A630", Slot = "5")]
	public virtual bool OGHPOHLKPCL(string FENOLNEIENE, int JCNKMPFHPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x602A560", Offset = "0x6028F60", VA = "0x18602A560", Slot = "6")]
	public virtual bool GMKOJFIFHOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x602A510", Offset = "0x6028F10", VA = "0x18602A510", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x602A5B0", Offset = "0x6028FB0", VA = "0x18602A5B0")]
	protected internal void KKNCHBJCPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x602A700", Offset = "0x6029100", VA = "0x18602A700")]
	protected HPBIJLEHDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AIMNJGDGOHB : HPBIJLEHDPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket PFOMIOHMJJE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x602A0A0", Offset = "0x6028AA0", VA = "0x18602A0A0", Slot = "5")]
	public override bool OGHPOHLKPCL(string FENOLNEIENE, int JCNKMPFHPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6029EB0", Offset = "0x60288B0", VA = "0x186029EB0", Slot = "6")]
	public override bool GMKOJFIFHOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x56B4CE0", Offset = "0x56B36E0", VA = "0x1856B4CE0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x602A340", Offset = "0x6028D40", VA = "0x18602A340")]
	public AIMNJGDGOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JDHPOALKNHN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string GLJLOPONKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string OOGHJEMKFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string CCLMAJBGDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PGNELAOMPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7965A0", Offset = "0x794FA0", VA = "0x1807965A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x796620", Offset = "0x795020", VA = "0x180796620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x602AC60", Offset = "0x6029660", VA = "0x18602AC60")]
	public JDHPOALKNHN(string PMDLHCDCLJN, string HDOEPEJDOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x602AA90", Offset = "0x6029490", VA = "0x18602AA90")]
	private void ONCCLNGFFDO(string CLJBCKEELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x602ABA0", Offset = "0x60295A0", VA = "0x18602ABA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x602A9A0", Offset = "0x60293A0", VA = "0x18602A9A0")]
	public string KHFICMHKNDH(bool PGGHJABGNLP = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PLECBKHBNIE
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int DLFDCAPNHBH;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool MPFALMCEOJN;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int HDLMJBAHDGD;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int IAKGKBLJKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JDHPOALKNHN KELCGPPLJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string FDNMDJFFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int OIALICGEECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int IJGPCMBLHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<JDHPOALKNHN> GLLDJLBIFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HPBIJLEHDPB LPAJMJJDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> JCODJOICCMO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GMKOJFIFHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x87FD70", Offset = "0x87E770", VA = "0x18087FD70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x963850", Offset = "0x962250", VA = "0x180963850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x602D010", Offset = "0x602BA10", VA = "0x18602D010")]
	public PLECBKHBNIE(JDHPOALKNHN KELCGPPLJMD, Action<JDHPOALKNHN> HBCJMPKIACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x602CC20", Offset = "0x602B620", VA = "0x18602CC20")]
	public bool NGCMLJIFGEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x602C7C0", Offset = "0x602B1C0", VA = "0x18602C7C0")]
	public static string ALKEJEFABEG(string BBLECNBIPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x602C940", Offset = "0x602B340", VA = "0x18602C940")]
	protected internal void EDPDBDKJCOP(object AGHGCGMHDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x602C950", Offset = "0x602B350", VA = "0x18602C950")]
	protected internal bool GNELOAKELAL()
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
