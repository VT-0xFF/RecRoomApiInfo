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
public interface KMOHBMIJHLP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> PDCLLDKOGAO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDDPEGBPHFP(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDONALOINPI(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEPNGDGMDGF(object JILOCOLKOMJ, bool PACEJFCJBID);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable KODAEFCMOLF();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DEFJHNILGCG();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDGMLPNFIEG(StringBuilder ONNNBFKHFAN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MMFIDCFBKIA(bool MLDIOLLNCGP, [Out] string LKNKJJBHDKO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface APCFJENLJAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PEOHHHNKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NBDDHBKCIDJ EIDICMKAPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PPFMBHMNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FJEEEBCNAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NMFPHEHEJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KPFDLINPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GFHBHKEPDBC NOEBPJMGHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JOAGFPFOLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NBDDHBKCIDJ, NBDDHBKCIDJ> BGHBHEBNCID;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPIBBNGDJCL(OODAEKHKKNF INPEHJECAGO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ODEHPHIGBPI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KGLFKBKCBDM(string JDJFJHGNCGP, OIFIKEDPHOI FKBACFDCGPK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GOCJGLJFFGK();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OFFMKGPBLIP(AppSettings NFDBBNJIEJM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NBDDHBKCIDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PKIBOEECFAC BIDLFNHLKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	GHLGOIABOPB OHPOCLGJNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KPFDLINPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PPFMBHMNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GGFMPEBHNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception KFJNADOIHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode OJMPHKOMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OODAEKHKKNF.FIGPOPJHGGF IJKMEICIABJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<PKIBOEECFAC, PKIBOEECFAC> BNOPIDMHFLB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJMPHCAMHNB(object ALLFIKNKLHM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CGJKAIIHFIJ(object BILPFDGEHCF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FAJLDFMGMGK(byte JPNHFMOKNOK, int EEPMLGNKEHB, object BKLKAFKNCOH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KFHAELEHMGM
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OODAEKHKKNF.FIGPOPJHGGF IJKMEICIABJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FAJLDFMGMGK JCNLOMNMNNE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HDNGAMFOHND(byte JPNHFMOKNOK, object PJHLMONHMFJ, MEBJAELMEMP GONNDGNNCBE, SendOptions ALFGGMACGOP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CHAFJNOMFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GFEBJDBBDID MIFHJIFKLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int PPMDNNIJEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int CNKHHFMFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int OPHONDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<GFEBJDBBDID> CHBCPHDBKNH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	GFEBJDBBDID KFCAMPLBAKJ(int DCILOEIKONN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LICGECJPOEG
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PKCDLDELFOH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIHKCEFGPFN();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FOAMNLJKJEK : APCFJENLJAH, KMOHBMIJHLP, KFHAELEHMGM, CHAFJNOMFLF, LICGECJPOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int MLLDMMKIFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int PDPENGOILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int MKLGMCLKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float AHEPJFLDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float PNNLFGJEPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KPFOJMNLBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IEGCDOOOIGL KPLHGIEKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action FBKDBOGJIML;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOMCGJBDENH();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNPOGFCCJEC();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCJNMMIPFIC(List<object> GIPAMJGJGNH, int IFOFOJHAFEG);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPPGHCEHKCI(int HAGACLBAONE, object BKLKAFKNCOH);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LEEMKFIJCCB(Hashtable OMHBAAPJDOL, int OJPIEODNKAI);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LCFGHJJGKPM();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NPCONMGOGEI();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EFAIKAOOKNL(string IPMIPIBDECB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IEGCDOOOIGL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NBACFCFFLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LHKMBHBNJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<AOBKJHKLOJO> JDHAIMIFNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKKLJBDGLKK(Action LOPGNPLEIDA, string KLDGDLBPNPF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KCGCNCJIDFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string PIPBPMNKLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 COFBFGOOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion PHMBAJJGPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 BDDFJFCLMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int MGKJPCMBANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public FIGGFBFOHNG DLOCGMBIMEI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C157E0", Offset = "0x7C13FE0", VA = "0x187C157E0")]
	public object[] PNLMCIMHLJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KCGCNCJIDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DCDLICAPHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C13230", Offset = "0x7C11A30", VA = "0x187C13230")]
	public static bool AKAMLGDPHCK(this APCFJENLJAH COMHOLNDGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C132D0", Offset = "0x7C11AD0", VA = "0x187C132D0")]
	public static bool FEIDDGOJBFG(this APCFJENLJAH COMHOLNDGKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GPEGOPCFJPO : FOAMNLJKJEK, APCFJENLJAH, KMOHBMIJHLP, KFHAELEHMGM, CHAFJNOMFLF, LICGECJPOEG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class NLNFOMGPDBG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GPEGOPCFJPO ALCIPFBKGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool IHDAJILAEEC;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C15E90", Offset = "0x7C14690", VA = "0x187C15E90")]
		public NLNFOMGPDBG(GPEGOPCFJPO ALCIPFBKGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C15D90", Offset = "0x7C14590", VA = "0x187C15D90", Slot = "1")]
		~NLNFOMGPDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C15D00", Offset = "0x7C14500", VA = "0x187C15D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C15E30", Offset = "0x7C14630", VA = "0x187C15E30")]
		private void PBICMHAMJEG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object EGPEJDOKPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object CNLAAODFFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float LGMOBJFCCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float CNFEKEEIOLN;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool JOAGFPFOLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float GMFBNOFPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int MLLDMMKIFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int PDPENGOILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract GFEBJDBBDID MIFHJIFKLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int PPMDNNIJEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C15560", Offset = "0x7C13D60", VA = "0x187C15560", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int CNKHHFMFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int OPHONDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ADAEIDAFINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C155D0", Offset = "0x7C13DD0", VA = "0x187C155D0", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int MKLGMCLKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float AHEPJFLDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xEB9D60", Offset = "0xEB8560", VA = "0x180EB9D60", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C142E0", Offset = "0x7C12AE0", VA = "0x187C142E0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float PNNLFGJEPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1048690", Offset = "0x1046E90", VA = "0x181048690", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C14A80", Offset = "0x7C13280", VA = "0x187C14A80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool KPFOJMNLBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract IEGCDOOOIGL KPLHGIEKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool PEOHHHNKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract NBDDHBKCIDJ EIDICMKAPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool PPFMBHMNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool FJEEEBCNAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool NMFPHEHEJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool KPFDLINPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract GFHBHKEPDBC NOEBPJMGHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private FLJKJAPOKJM CLFMHHCCODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private FLJKJAPOKJM DBMPENBBDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private KPIDBFOJEAM<Func<float>> AHEPMPOECFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool OAIDLIJILOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x16CD450", Offset = "0x16CBC50", VA = "0x1816CD450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool NBFCCDOOILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C14E20", Offset = "0x7C13620", VA = "0x187C14E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool BOBEHDECEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C15180", Offset = "0x7C13980", VA = "0x187C15180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event OODAEKHKKNF.FIGPOPJHGGF IJKMEICIABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C14BA0", Offset = "0x7C133A0", VA = "0x187C14BA0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C140D0", Offset = "0x7C128D0", VA = "0x187C140D0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event FAJLDFMGMGK JCNLOMNMNNE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<GFEBJDBBDID> CHBCPHDBKNH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<NBDDHBKCIDJ, NBDDHBKCIDJ> BGHBHEBNCID;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> PDCLLDKOGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C14E70", Offset = "0x7C13670", VA = "0x187C14E70", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C150D0", Offset = "0x7C138D0", VA = "0x187C150D0", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action FBKDBOGJIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C154C0", Offset = "0x7C13CC0", VA = "0x187C154C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C14520", Offset = "0x7C12D20", VA = "0x187C14520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action PKCDLDELFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C14240", Offset = "0x7C12A40", VA = "0x187C14240", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C145C0", Offset = "0x7C12DC0", VA = "0x187C145C0", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract GFEBJDBBDID KFCAMPLBAKJ(int DCILOEIKONN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool OFFMKGPBLIP(AppSettings NFDBBNJIEJM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void GOCJGLJFFGK();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool ODEHPHIGBPI();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void KOMCGJBDENH();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void BNPOGFCCJEC();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void NCJNMMIPFIC(List<object> GIPAMJGJGNH, int IFOFOJHAFEG);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void IPPGHCEHKCI(int HAGACLBAONE, object BKLKAFKNCOH);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void LEEMKFIJCCB(Hashtable OMHBAAPJDOL, int OJPIEODNKAI);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool HDNGAMFOHND(byte JPNHFMOKNOK, object PJHLMONHMFJ, MEBJAELMEMP GONNDGNNCBE, SendOptions ALFGGMACGOP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool KGLFKBKCBDM(string JDJFJHGNCGP, OIFIKEDPHOI FKBACFDCGPK);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void EFAIKAOOKNL(string IPMIPIBDECB);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void MPIBBNGDJCL(OODAEKHKKNF INPEHJECAGO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C15660", Offset = "0x7C13E60", VA = "0x187C15660")]
	protected GPEGOPCFJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C154A0", Offset = "0x7C13CA0", VA = "0x187C154A0")]
	public void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C14D00", Offset = "0x7C13500", VA = "0x187C14D00", Slot = "41")]
	public void IEPNGDGMDGF(object JILOCOLKOMJ, bool PACEJFCJBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C14140", Offset = "0x7C12940", VA = "0x187C14140", Slot = "39")]
	public void BDDPEGBPHFP(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C14CC0", Offset = "0x7C134C0", VA = "0x187C14CC0", Slot = "40")]
	public void IDONALOINPI(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C14FB0", Offset = "0x7C137B0", VA = "0x187C14FB0", Slot = "42")]
	public IDisposable KODAEFCMOLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C151C0", Offset = "0x7C139C0", VA = "0x187C151C0", Slot = "102")]
	public virtual bool MMFIDCFBKIA(bool MLDIOLLNCGP, [Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C148E0", Offset = "0x7C130E0", VA = "0x187C148E0")]
	private bool EENIKJENDFO([Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C14F20", Offset = "0x7C13720", VA = "0x187C14F20")]
	private bool KBFKFLEBCJE([Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C144D0", Offset = "0x7C12CD0", VA = "0x187C144D0", Slot = "43")]
	public bool DEFJHNILGCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C14660", Offset = "0x7C12E60", VA = "0x187C14660", Slot = "44")]
	public void EDGMLPNFIEG(StringBuilder ONNNBFKHFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C14320", Offset = "0x7C12B20", VA = "0x187C14320")]
	private void DCDIMPJPMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C14B10", Offset = "0x7C13310", VA = "0x187C14B10")]
	private void FDAAOCLPHFL(Func<float> ENJIEMMBKNB, object JILOCOLKOMJ, int IEAGNNNDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C153E0", Offset = "0x7C13BE0", VA = "0x187C153E0", Slot = "103")]
	public void NFEOJPLJBGP(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C15040", Offset = "0x7C13840", VA = "0x187C15040", Slot = "14")]
	public void LCFGHJJGKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C15440", Offset = "0x7C13C40", VA = "0x187C15440", Slot = "15")]
	public void NPCONMGOGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C14C10", Offset = "0x7C13410", VA = "0x187C14C10")]
	private void HLEKAIHMCCI(float GCGADGABLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1048690", Offset = "0x1046E90", VA = "0x181048690")]
	private float KIBCHHLCMOD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xEB9D60", Offset = "0xEB8560", VA = "0x180EB9D60")]
	private float BCPNAJPOKCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C14020", Offset = "0x7C12820", VA = "0x187C14020")]
	private void ADNAEBPGMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C14AC0", Offset = "0x7C132C0", VA = "0x187C14AC0", Slot = "61")]
	public void EIHKCEFGPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class DNDOCHFCIIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string MKGCBOHJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool MFDOIJHEKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool BEEONKHIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int CIDILHDMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] KDOPMCPDBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte DHFOEPGEFPK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random JHFGILFGLNN;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C13DB0", Offset = "0x7C125B0", VA = "0x187C13DB0", Slot = "5")]
	public virtual bool IOODKBIEACK(string NAMLHOKODCO, int IFDAMJHJJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C13CE0", Offset = "0x7C124E0", VA = "0x187C13CE0", Slot = "6")]
	public virtual bool HFJMIBFCFAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C13C90", Offset = "0x7C12490", VA = "0x187C13C90", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C13D30", Offset = "0x7C12530", VA = "0x187C13D30")]
	protected internal void ILJHHMHPGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C13E80", Offset = "0x7C12680", VA = "0x187C13E80")]
	protected DNDOCHFCIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ABDDGDOFLND : DNDOCHFCIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket JHHDKMNPMMN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C12EB0", Offset = "0x7C116B0", VA = "0x187C12EB0", Slot = "5")]
	public override bool IOODKBIEACK(string NAMLHOKODCO, int IFDAMJHJJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C12CC0", Offset = "0x7C114C0", VA = "0x187C12CC0", Slot = "6")]
	public override bool HFJMIBFCFAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4EC0", Offset = "0x6FB36C0", VA = "0x186FB4EC0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C13150", Offset = "0x7C11950", VA = "0x187C13150")]
	public ABDDGDOFLND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MDHJJKKOKBO
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string GBDGOENPFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string OFAKHHONCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string NKGNJMHMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int NFDCECFJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C15BE0", Offset = "0x7C143E0", VA = "0x187C15BE0")]
	public MDHJJKKOKBO(string HLGPGMAFMLJ, string LEHJJMPDHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C15A10", Offset = "0x7C14210", VA = "0x187C15A10")]
	private void KDDAEEDDOIE(string AGLNBDANANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C15B20", Offset = "0x7C14320", VA = "0x187C15B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C15920", Offset = "0x7C14120", VA = "0x187C15920")]
	public string FJFJOAJOLEG(bool KFLAEKCEBLB = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DEOPEHCIMMF
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int IMLJJHJADEL;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool HCLDHFLIEFG;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int HGGHENKNODK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int JIFCPHEMEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MDHJJKKOKBO NIJKLFAJHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string IFGAMKBNAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int KCBPIJCBCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int AEPLBBFIJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<MDHJJKKOKBO> HDOINLCBIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DNDOCHFCIIJ OKJNIAOJLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> GEKCPLNIFFO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HFJMIBFCFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C13BE0", Offset = "0x7C123E0", VA = "0x187C13BE0")]
	public DEOPEHCIMMF(MDHJJKKOKBO NIJKLFAJHNL, Action<MDHJJKKOKBO> HMBCFGAACKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C133A0", Offset = "0x7C11BA0", VA = "0x187C133A0")]
	public bool GIABKOFDCIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C139F0", Offset = "0x7C121F0", VA = "0x187C139F0")]
	public static string PIEOEODFEGK(string DIOOJLCGPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C13710", Offset = "0x7C11F10", VA = "0x187C13710")]
	protected internal void JCJKBIDPIDF(object KLNHOILIBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C13720", Offset = "0x7C11F20", VA = "0x187C13720")]
	protected internal bool OGAAEKGEKGC()
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
