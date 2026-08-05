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
public interface HKNLHLGNMIC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> DHOJMAMGKBP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEAIMFDCHHB(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBFCFEOGFMI(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDLPBODEAEF(object GIIKHLJPAKH, bool PPPFFGDDNGD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable CKDAHHLHNAL();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MJDBHDCNFHN();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FFOCFFBDILO(StringBuilder INAHACHGGIK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ABMOIMKFILJ(bool BDGAFKJDIND, [Out] string HHOJHACJLGI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KADFIOFMPDL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OEDMBHKFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	CEMHGIGGGAE PMHEEJBPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PCAPHMAILMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GOOJPLKEBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LMHICHLHKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HOGIIBGIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EMJJIEGKKCL BEMJJNOKGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PIMJIGBNMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CEMHGIGGGAE, CEMHGIGGGAE> ANGMNABOAPB;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLNJLOKCPAD(GJGCDFFEPNH EEHMDOMHILM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JDHEKAPIIMB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NPBHNBBBNLG(string NPIMPJGKNLP, OGKNFDPOEBC OKCBKGGHGII);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GAHOAGNCMOF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BMMIGBGHMCB(AppSettings DBOPOCFCKMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CEMHGIGGGAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MDJAKFEEPBJ GHAOIDPGDML
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	BNJFHFALKMN HCBMFNPLBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HOGIIBGIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PCAPHMAILMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FGJGPMPEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception CPJABEAGOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode FCGPNKBCPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GJGCDFFEPNH.JFBGFLJNBKD FFAAHPGIMJP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<MDJAKFEEPBJ, MDJAKFEEPBJ> MHOCBMKBLGA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LIDFECOGAMP(object CGKPJBPKLPJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAHPOKCJFDN(object BFCIBGGOFKL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KDCCIIAHBJI(byte BHACABOKOII, int KPBNGNEIDLH, object ELLEMLBGHOH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AKLAOMBEFFF
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GJGCDFFEPNH.JFBGFLJNBKD FFAAHPGIMJP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KDCCIIAHBJI GJCLICCEPEL;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EKAACJEFJEO(byte BHACABOKOII, object ACGGGKHNIDL, HCBDIFBPMFO PBMCEFOCHAO, SendOptions FHHPBJNDMGB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AJKKBOPPAOC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GJGNFGDHFCI HGFGBJPFNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int DLKFEOFPFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int LPKKIPCPONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int EOEIEBOKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<GJGNFGDHFCI> DEOFBNCJHAJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	GJGNFGDHFCI HCNKBOPOIKB(int GMGPDOAAFEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CNLDJBNEPAF
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action FABDANMOEGA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJBLODBELBP();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface APCKJEBLMJJ : KADFIOFMPDL, HKNLHLGNMIC, AKLAOMBEFFF, AJKKBOPPAOC, CNLDJBNEPAF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int GMOJGNKLGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int CHGFMCHAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int JHNBIIDGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float AOPAAMOMFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float LGPEPNCDLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KAHOCBAFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LKICOCCDECL JKAKDMDDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action GKCCEPJPPPJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNICENJDKNE();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDJAKENDEAI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJGPPEGFPGD(List<object> KBPAKCCMOCP, int JMHJAFCGEDO);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNDBEICEIEP(int IJFDPELMKHC, object ELLEMLBGHOH);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPGMLODAEHF(Hashtable PBKGIMHJLME, int ADIMAPFNMNK);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JBBEHFMIMMH();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ONIAIJKCIEG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LMBOGKJCHHF(string HHBNILECLGG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LKICOCCDECL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MNJBFIFNIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LLGEONGKJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<GDEOMLOPIMA> LBDAKHIACPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGEBEHJGNOF(Action HMALPBPJFOE, string MFMPKMADDBL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FEEMFPCJHHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string NEOFMDEACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 LAHGFMKGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion NEDOKMKIJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 KEDFJDMFMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int HBALPGKEEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public BNLAMAEAGEL PJOABBHDLNC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76DBE20", Offset = "0x76DB020", VA = "0x1876DBE20")]
	public object[] AFEDHNPIJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FEEMFPCJHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JJAEICPNMHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76DC900", Offset = "0x76DBB00", VA = "0x1876DC900")]
	public static bool PGPNDNABLCA(this KADFIOFMPDL MIMIPMGDCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76DC830", Offset = "0x76DBA30", VA = "0x1876DC830")]
	public static bool EIMHKFMCIEE(this KADFIOFMPDL MIMIPMGDCIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JLKAPKLBKLJ : APCKJEBLMJJ, KADFIOFMPDL, HKNLHLGNMIC, AKLAOMBEFFF, AJKKBOPPAOC, CNLDJBNEPAF
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class EIPFOJLAPAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JLKAPKLBKLJ DFONNBCGCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JPJEOEDAIGH;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x76DBDC0", Offset = "0x76DAFC0", VA = "0x1876DBDC0")]
		public EIPFOJLAPAF(JLKAPKLBKLJ DFONNBCGCJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x76DBCC0", Offset = "0x76DAEC0", VA = "0x1876DBCC0", Slot = "1")]
		~EIPFOJLAPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x76DBC30", Offset = "0x76DAE30", VA = "0x1876DBC30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x76DBD60", Offset = "0x76DAF60", VA = "0x1876DBD60")]
		private void HKHHMMAGINH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object EJAENNFJPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object OJFPMKPMGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float JLMFDEOKPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float FLAPLNANKEA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool PIMJIGBNMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float HFFEEFHCCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int GMOJGNKLGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int CHGFMCHAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract GJGNFGDHFCI HGFGBJPFNNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int DLKFEOFPFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD5C0", Offset = "0x76DC7C0", VA = "0x1876DD5C0", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int LPKKIPCPONM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int EOEIEBOKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x76DD8D0", Offset = "0x76DCAD0", VA = "0x1876DD8D0", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int JHNBIIDGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float AOPAAMOMFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xEFE650", Offset = "0xEFD850", VA = "0x180EFE650", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76DCF40", Offset = "0x76DC140", VA = "0x1876DCF40", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float LGPEPNCDLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xEFE640", Offset = "0xEFD840", VA = "0x180EFE640", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x76DDD10", Offset = "0x76DCF10", VA = "0x1876DDD10", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool KAHOCBAFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract LKICOCCDECL JKAKDMDDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool OEDMBHKFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract CEMHGIGGGAE PMHEEJBPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool PCAPHMAILMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool GOOJPLKEBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool LMHICHLHKAI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool HOGIIBGIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract EMJJIEGKKCL BEMJJNOKGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private JIKBJNLDAIP DEHAGNIDCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private JIKBJNLDAIP MEBBCJEFAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private GODAFHEHLEH<Func<float>> KNILGFHEODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool FHDMLNANBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x154CED0", Offset = "0x154C0D0", VA = "0x18154CED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool BEAALPPFLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76DD880", Offset = "0x76DCA80", VA = "0x1876DD880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool FLEHAEDPPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x76DD840", Offset = "0x76DCA40", VA = "0x1876DD840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event GJGCDFFEPNH.JFBGFLJNBKD FFAAHPGIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x76DCF80", Offset = "0x76DC180", VA = "0x1876DCF80", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x76DD770", Offset = "0x76DC970", VA = "0x1876DD770", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event KDCCIIAHBJI GJCLICCEPEL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<GJGNFGDHFCI> DEOFBNCJHAJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<CEMHGIGGGAE, CEMHGIGGGAE> ANGMNABOAPB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> DHOJMAMGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x76DDAB0", Offset = "0x76DCCB0", VA = "0x1876DDAB0", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76DDBB0", Offset = "0x76DCDB0", VA = "0x1876DDBB0", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action GKCCEPJPPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76DCBC0", Offset = "0x76DBDC0", VA = "0x1876DCBC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76DCC60", Offset = "0x76DBE60", VA = "0x1876DCC60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action FABDANMOEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x76DD520", Offset = "0x76DC720", VA = "0x1876DD520", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD960", Offset = "0x76DCB60", VA = "0x1876DD960", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract GJGNFGDHFCI HCNKBOPOIKB(int GMGPDOAAFEJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool BMMIGBGHMCB(AppSettings DBOPOCFCKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void GAHOAGNCMOF();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool JDHEKAPIIMB();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void HNICENJDKNE();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void NDJAKENDEAI();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void GJGPPEGFPGD(List<object> KBPAKCCMOCP, int JMHJAFCGEDO);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void MNDBEICEIEP(int IJFDPELMKHC, object ELLEMLBGHOH);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void KPGMLODAEHF(Hashtable PBKGIMHJLME, int ADIMAPFNMNK);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool EKAACJEFJEO(byte BHACABOKOII, object ACGGGKHNIDL, HCBDIFBPMFO PBMCEFOCHAO, SendOptions FHHPBJNDMGB);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool NPBHNBBBNLG(string NPIMPJGKNLP, OGKNFDPOEBC OKCBKGGHGII);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void LMBOGKJCHHF(string HHBNILECLGG);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void GLNJLOKCPAD(GJGCDFFEPNH EEHMDOMHILM);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76DDFE0", Offset = "0x76DD1E0", VA = "0x1876DDFE0")]
	protected JLKAPKLBKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76DDD90", Offset = "0x76DCF90", VA = "0x1876DDD90")]
	public void PDAIGIIELDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76DCFF0", Offset = "0x76DC1F0", VA = "0x1876DCFF0", Slot = "41")]
	public void FDLPBODEAEF(object GIIKHLJPAKH, bool PPPFFGDDNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD110", Offset = "0x76DC310", VA = "0x1876DD110", Slot = "39")]
	public void FEAIMFDCHHB(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76DDD50", Offset = "0x76DCF50", VA = "0x1876DDD50", Slot = "40")]
	public void PBFCFEOGFMI(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76DCEB0", Offset = "0x76DC0B0", VA = "0x1876DCEB0", Slot = "42")]
	public IDisposable CKDAHHLHNAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76DC9A0", Offset = "0x76DBBA0", VA = "0x1876DC9A0", Slot = "102")]
	public virtual bool ABMOIMKFILJ(bool BDGAFKJDIND, [Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76DDE40", Offset = "0x76DD040", VA = "0x1876DDE40")]
	private bool PPEJMGLBKEL([Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76DDDB0", Offset = "0x76DCFB0", VA = "0x1876DDDB0")]
	private bool PJGBBDHJDBA([Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x76DDB60", Offset = "0x76DCD60", VA = "0x1876DDB60", Slot = "43")]
	public bool MJDBHDCNFHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76DD210", Offset = "0x76DC410", VA = "0x1876DD210", Slot = "44")]
	public void FFOCFFBDILO(StringBuilder INAHACHGGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x76DCD00", Offset = "0x76DBF00", VA = "0x1876DCD00")]
	private void CIJLLIBCKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76DD490", Offset = "0x76DC690", VA = "0x1876DD490")]
	private void GAJOBMEKBPG(Func<float> JKAIMFCDOPO, object GIIKHLJPAKH, int JHJIKIHJMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x76DD7E0", Offset = "0x76DC9E0", VA = "0x1876DD7E0", Slot = "103")]
	public void KGNNGEODCIO(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76DD630", Offset = "0x76DC830", VA = "0x1876DD630", Slot = "14")]
	public void JBBEHFMIMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76DDCB0", Offset = "0x76DCEB0", VA = "0x1876DDCB0", Slot = "15")]
	public void ONIAIJKCIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x76DDA00", Offset = "0x76DCC00", VA = "0x1876DDA00")]
	private void LKCPPJOGGIG(float KLKCOGKAFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xEFE640", Offset = "0xEFD840", VA = "0x180EFE640")]
	private float GPJHCFDAFNI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xEFE650", Offset = "0xEFD850", VA = "0x180EFE650")]
	private float GIBJGKCOENM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD6C0", Offset = "0x76DC8C0", VA = "0x1876DD6C0")]
	private void JBHIKIIDMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76DDC60", Offset = "0x76DCE60", VA = "0x1876DDC60", Slot = "61")]
	public void NJBLODBELBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class DPFIAMHDKOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string LKCNBFGAPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool HJCJNDBACIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool EHOGDJOBJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int MDLLDGGLKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] CPFMADHKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte LGNPLFEBCJM;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random EOCHKFKMNJF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76DBA60", Offset = "0x76DAC60", VA = "0x1876DBA60", Slot = "5")]
	public virtual bool FMMBNAFFPFM(string LDGBFLJHIEE, int EEHIBEJLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76DBAB0", Offset = "0x76DACB0", VA = "0x1876DBAB0", Slot = "6")]
	public virtual bool IIKPFBHCAII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76DB990", Offset = "0x76DAB90", VA = "0x1876DB990", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76DB9E0", Offset = "0x76DABE0", VA = "0x1876DB9E0")]
	protected internal void EMBIHAFPMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76DBB80", Offset = "0x76DAD80", VA = "0x1876DBB80")]
	protected DPFIAMHDKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DILEOPECIPL : DPFIAMHDKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket CNPEKGHNINO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76DB420", Offset = "0x76DA620", VA = "0x1876DB420", Slot = "5")]
	public override bool FMMBNAFFPFM(string LDGBFLJHIEE, int EEHIBEJLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76DB6C0", Offset = "0x76DA8C0", VA = "0x1876DB6C0", Slot = "6")]
	public override bool IIKPFBHCAII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1EBE0", Offset = "0x6B1DDE0", VA = "0x186B1EBE0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76DB8B0", Offset = "0x76DAAB0", VA = "0x1876DB8B0")]
	public DILEOPECIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KDLEFAKBPLB
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string OPBMIJGNKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string KOHGIGHIAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string GIJNPHDKCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int OJNHNNCFPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x96C070", Offset = "0x96B270", VA = "0x18096C070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76DE510", Offset = "0x76DD710", VA = "0x1876DE510")]
	public KDLEFAKBPLB(string GEDIIGIDHKB, string PPFHNJCIAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76DE250", Offset = "0x76DD450", VA = "0x1876DE250")]
	private void BFLHNLKCGDL(string MAHAMCNKHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76DE450", Offset = "0x76DD650", VA = "0x1876DE450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76DE360", Offset = "0x76DD560", VA = "0x1876DE360")]
	public string PFJEDFKPNFB(bool OCCMPDEAAIO = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IDFNJCLBIFK
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int FAMCLBCGDGP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool GCCJGPKJHPB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int OKBJIGBPOJN;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int MIFKELPIJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KDLEFAKBPLB PAAADBJENPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string DBBLCIHAOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int FOCICPPNMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int EOADDGDCLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<KDLEFAKBPLB> GNEHIPLNKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DPFIAMHDKOO JLLLLIEBKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> MFGGOBMNAPK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IIKPFBHCAII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCE50A0", Offset = "0xCE42A0", VA = "0x180CE50A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x76DC780", Offset = "0x76DB980", VA = "0x1876DC780")]
	public IDFNJCLBIFK(KDLEFAKBPLB PAAADBJENPA, Action<KDLEFAKBPLB> LPCBDKCHCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x76DC3A0", Offset = "0x76DB5A0", VA = "0x1876DC3A0")]
	public bool CHDCILGNCOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76DC210", Offset = "0x76DB410", VA = "0x1876DC210")]
	public static string BELFJFBPKOP(string GIKFFCPGNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76DC390", Offset = "0x76DB590", VA = "0x1876DC390")]
	protected internal void BIGHDLKEJIK(object IBLIOEFMDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76DBF40", Offset = "0x76DB140", VA = "0x1876DBF40")]
	protected internal bool AKACHNGNADI()
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
