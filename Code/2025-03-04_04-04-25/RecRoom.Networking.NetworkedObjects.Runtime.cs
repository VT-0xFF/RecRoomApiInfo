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
public interface KOCGNCDMOPN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> PGBACEBCHGK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJPHDIPLHBD(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INFNFEODANG(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHFIKMLHMPE(object LAAJFAFNFCN, bool LGLLAKCPHMM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable PIHIMIFAALK();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EONJFMBMPAJ();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDLIHPFLNBL(StringBuilder IICLAANMIAP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HEJANPGJFCG(bool NJNGBOFHOIL, [Out] string IFMHONGNKHP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AOOPFEBNBFO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IMBLNELAJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MNOJLNCNIKI CBFIHGDDLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KGHHAHDFBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ECHDLCKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LHLFDFFIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EOAAGEDNJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PAKKKDBJIMM MCCKEDDEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KAKDDMCGDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MNOJLNCNIKI, MNOJLNCNIKI> AAIEIAAPGAI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKPGPPAHKEM(BMBNGCGJOIM ONLGAKFGMFI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AAAMFPCKJLJ();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HAKKJJJJKNP(string DBJAKAOOCBJ, LPAAIPJPHJP HAJGIEPHJLA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NDBONFMDEOD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NOFGMBEGHIE(AppSettings NAIEKKIPEID);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MNOJLNCNIKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BALIGFBMHEF LOJMKJKLJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	FOFOJPBEFKG NHBFPNDGGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EOAAGEDNJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KGHHAHDFBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BDEHAKJIHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception JLLFNKHMMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode DBAPEPCJGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BMBNGCGJOIM.OFOPFDAOBOK BAGHFLOBLEJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<BALIGFBMHEF, BALIGFBMHEF> FIAIEOEJIHE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LDHIGBEEBDA(object MOCLCNOAHKF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LHFJDKJKNJE(object LCOHLJKDHDO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FJMKBAPIJAM(byte BEHNKEPLHBF, int GNEBHLDFAOJ, object NBGBHBICCPM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ECOCBFMFIOC
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BMBNGCGJOIM.OFOPFDAOBOK BAGHFLOBLEJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FJMKBAPIJAM LHFOAEPBCEG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LABMAAMFCPG(byte BEHNKEPLHBF, object FNCHNJICPAH, APIINIHDAID HBPNGGLDACB, SendOptions DAEFANOOJBO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LIIDEAJGIMB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OPHKANJGPPK CKOIGGKJGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int AKNODCDPMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int NKBFAKMAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int KMDCADAAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<OPHKANJGPPK> KPAOCMPFANM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	OPHKANJGPPK IAOPBEKPMAP(int NJNOPMJJKAE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EDKLJOILFEA
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action HPIDINHPCCE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMIFDHJFLHH();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JFIOHCKEEIP : AOOPFEBNBFO, KOCGNCDMOPN, ECOCBFMFIOC, LIIDEAJGIMB, EDKLJOILFEA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DFGKANENCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int LKMJMIOEDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int BMOPGIPBFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float KCLCLEEOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float IDCHLJMHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LLEPHMKPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ILKLOEOBIHF JGMMKDFIFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action IPJEBMOMAEL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKONDPLMKKO();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKKJANCNFJN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAKLIFDIFLD(List<object> BHMKCPLLJPF, int EKDINNHMJFC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIKPOMBHBDH(int OLOJBBBJBOB, object NBGBHBICCPM);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MCADLJEGOJK(Hashtable GHLDAFCMHAC, int KHELFHBHLMG);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNKLEHJKBMN();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GBKDBGKIECN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JLPFDABLPAA(string MJEEBLNLIGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ILKLOEOBIHF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EOEKCJONFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MCBPABBLCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<MCPJALBDCCF> LNFLADGIHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NFNHAHCFDPM(Action BDFMJBIOFFJ, string FNFKLBGHLBI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BAKCGJBIBFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string DFGACDCNALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 NAMOIOBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion KGCMOGJCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 PKJENICKIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int HEBBCPJOFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public DPGADNNJFDK DOHJHCOIBKP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75E3EF0", Offset = "0x75E24F0", VA = "0x1875E3EF0")]
	public object[] PNECHNOFIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public BAKCGJBIBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OHFONFEGPBO
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75E6A30", Offset = "0x75E5030", VA = "0x1875E6A30")]
	public static bool DFDMKIPFBCF(this AOOPFEBNBFO NKPKLAMADJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75E6AD0", Offset = "0x75E50D0", VA = "0x1875E6AD0")]
	public static bool DHPBLPCGOKN(this AOOPFEBNBFO NKPKLAMADJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class EKOFILGFBMB : JFIOHCKEEIP, AOOPFEBNBFO, KOCGNCDMOPN, ECOCBFMFIOC, LIIDEAJGIMB, EDKLJOILFEA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class JNFJDDCJAND : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EKOFILGFBMB DMANBHAOCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool NLNPPHMOFNH;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75E60D0", Offset = "0x75E46D0", VA = "0x1875E60D0")]
		public JNFJDDCJAND(EKOFILGFBMB DMANBHAOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75E6030", Offset = "0x75E4630", VA = "0x1875E6030", Slot = "1")]
		~JNFJDDCJAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75E5FA0", Offset = "0x75E45A0", VA = "0x1875E5FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75E5F40", Offset = "0x75E4540", VA = "0x1875E5F40")]
		private void CEOCCAPEHKN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object PADMIBMEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object JMFIKEKPCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float DNGNPLBFNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float JDPCDBFJGGI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool KAKDDMCGDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float BEKOGEFOGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int DFGKANENCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int LKMJMIOEDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract OPHKANJGPPK CKOIGGKJGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int AKNODCDPMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75E56B0", Offset = "0x75E3CB0", VA = "0x1875E56B0", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int NKBFAKMAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int KMDCADAAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x75E5720", Offset = "0x75E3D20", VA = "0x1875E5720", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int BMOPGIPBFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float KCLCLEEOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xEA5F50", Offset = "0xEA4550", VA = "0x180EA5F50", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x75E4BC0", Offset = "0x75E31C0", VA = "0x1875E4BC0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float IDCHLJMHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xEA5F40", Offset = "0xEA4540", VA = "0x180EA5F40", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75E5130", Offset = "0x75E3730", VA = "0x1875E5130", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool LLEPHMKPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract ILKLOEOBIHF JGMMKDFIFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool IMBLNELAJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract MNOJLNCNIKI CBFIHGDDLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool KGHHAHDFBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool ECHDLCKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool LHLFDFFIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool EOAAGEDNJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract PAKKKDBJIMM MCCKEDDEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IFFCOANOBGF PLLPOMDBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private IFFCOANOBGF IOMEIHMNEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private GJKLJJDNPDD<Func<float>> HOOIALNJGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool NNFNAAOELLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x14F0D40", Offset = "0x14EF340", VA = "0x1814F0D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool EBAJJAPABED
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75E50A0", Offset = "0x75E36A0", VA = "0x1875E50A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool KEMLFFJJCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75E4350", Offset = "0x75E2950", VA = "0x1875E4350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event BMBNGCGJOIM.OFOPFDAOBOK BAGHFLOBLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75E5170", Offset = "0x75E3770", VA = "0x1875E5170", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75E5420", Offset = "0x75E3A20", VA = "0x1875E5420", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event FJMKBAPIJAM LHFOAEPBCEG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<OPHKANJGPPK> KPAOCMPFANM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<MNOJLNCNIKI, MNOJLNCNIKI> AAIEIAAPGAI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> PGBACEBCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75E4C00", Offset = "0x75E3200", VA = "0x1875E4C00", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75E5840", Offset = "0x75E3E40", VA = "0x1875E5840", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action IPJEBMOMAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x75E4910", Offset = "0x75E2F10", VA = "0x1875E4910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75E51E0", Offset = "0x75E37E0", VA = "0x1875E51E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action HPIDINHPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75E42B0", Offset = "0x75E28B0", VA = "0x1875E42B0", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75E4ED0", Offset = "0x75E34D0", VA = "0x1875E4ED0", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract OPHKANJGPPK IAOPBEKPMAP(int NJNOPMJJKAE);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool NOFGMBEGHIE(AppSettings NAIEKKIPEID);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void NDBONFMDEOD();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool AAAMFPCKJLJ();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void CKONDPLMKKO();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void KKKJANCNFJN();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void IAKLIFDIFLD(List<object> BHMKCPLLJPF, int EKDINNHMJFC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void LIKPOMBHBDH(int OLOJBBBJBOB, object NBGBHBICCPM);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void MCADLJEGOJK(Hashtable GHLDAFCMHAC, int KHELFHBHLMG);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool LABMAAMFCPG(byte BEHNKEPLHBF, object FNCHNJICPAH, APIINIHDAID HBPNGGLDACB, SendOptions DAEFANOOJBO);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool HAKKJJJJKNP(string DBJAKAOOCBJ, LPAAIPJPHJP HAJGIEPHJLA);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void JLPFDABLPAA(string MJEEBLNLIGJ);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void DKPGPPAHKEM(BMBNGCGJOIM ONLGAKFGMFI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75E58F0", Offset = "0x75E3EF0", VA = "0x1875E58F0")]
	protected EKOFILGFBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75E5080", Offset = "0x75E3680", VA = "0x1875E5080")]
	public void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75E47A0", Offset = "0x75E2DA0", VA = "0x1875E47A0", Slot = "41")]
	public void DHFIKMLHMPE(object LAAJFAFNFCN, bool LGLLAKCPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x75E4610", Offset = "0x75E2C10", VA = "0x1875E4610", Slot = "39")]
	public void BJPHDIPLHBD(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x75E50F0", Offset = "0x75E36F0", VA = "0x1875E50F0", Slot = "40")]
	public void INFNFEODANG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x75E57B0", Offset = "0x75E3DB0", VA = "0x1875E57B0", Slot = "42")]
	public IDisposable PIHIMIFAALK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x75E4CB0", Offset = "0x75E32B0", VA = "0x1875E4CB0", Slot = "102")]
	public virtual bool HEJANPGJFCG(bool NJNGBOFHOIL, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5280", Offset = "0x75E3880", VA = "0x1875E5280")]
	private bool KBJHCPGNBBI([Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x75E4710", Offset = "0x75E2D10", VA = "0x1875E4710")]
	private bool DGMGEEEGKNK([Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x75E48C0", Offset = "0x75E2EC0", VA = "0x1875E48C0", Slot = "43")]
	public bool EONJFMBMPAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x75E4390", Offset = "0x75E2990", VA = "0x1875E4390", Slot = "44")]
	public void BDLIHPFLNBL(StringBuilder IICLAANMIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75E4A10", Offset = "0x75E3010", VA = "0x1875E4A10")]
	private void GHOAOBEIJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x75E5520", Offset = "0x75E3B20", VA = "0x1875E5520")]
	private void LOICMAPDBCI(Func<float> OECEAKANNGI, object LAAJFAFNFCN, int DKBNIPNLNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x75E4F70", Offset = "0x75E3570", VA = "0x1875E4F70", Slot = "103")]
	public void HGHKELAFCOL(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x75E5490", Offset = "0x75E3A90", VA = "0x1875E5490", Slot = "14")]
	public void LNKLEHJKBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75E49B0", Offset = "0x75E2FB0", VA = "0x1875E49B0", Slot = "15")]
	public void GBKDBGKIECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x75E4FD0", Offset = "0x75E35D0", VA = "0x1875E4FD0")]
	private void HJNPBNMHEBN(float GAOGFDNIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xEA5F40", Offset = "0xEA4540", VA = "0x180EA5F40")]
	private float AOOAHPNBBPF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xEA5F50", Offset = "0xEA4550", VA = "0x180EA5F50")]
	private float LDINFCLOFPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75E55B0", Offset = "0x75E3BB0", VA = "0x1875E55B0")]
	private void MBHLADHFADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75E5660", Offset = "0x75E3C60", VA = "0x1875E5660", Slot = "61")]
	public void NMIFDHJFLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class DGLKJIONHKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string AMKGIDMHMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool OPALCBLINIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool JOKAAHEIEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int PPJGKNCJMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] CBDAIPMDGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte LMPJLBACAMA;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random BDBMPEBPOGN;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x75E4010", Offset = "0x75E2610", VA = "0x1875E4010", Slot = "5")]
	public virtual bool CDCLJHACGIN(string LHAPKCHPPNL, int GMEMHACONIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x75E4130", Offset = "0x75E2730", VA = "0x1875E4130", Slot = "6")]
	public virtual bool JBIPNINEMEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75E40E0", Offset = "0x75E26E0", VA = "0x1875E40E0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75E4060", Offset = "0x75E2660", VA = "0x1875E4060")]
	protected internal void CIDIOEOELJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x75E4200", Offset = "0x75E2800", VA = "0x1875E4200")]
	protected DGLKJIONHKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OMIDKGEKNCL : DGLKJIONHKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket KJBFICICLEP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x75E6BA0", Offset = "0x75E51A0", VA = "0x1875E6BA0", Slot = "5")]
	public override bool CDCLJHACGIN(string LHAPKCHPPNL, int GMEMHACONIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x75E6E40", Offset = "0x75E5440", VA = "0x1875E6E40", Slot = "6")]
	public override bool JBIPNINEMEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A38960", Offset = "0x6A36F60", VA = "0x186A38960", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x75E7030", Offset = "0x75E5630", VA = "0x1875E7030")]
	public OMIDKGEKNCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HPGHIPCFAII
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string PJKJMMANGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string BINCKFAMFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string BCNDPDDDCIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int NFCIBEGFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x954460", Offset = "0x952A60", VA = "0x180954460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x954BD0", Offset = "0x9531D0", VA = "0x180954BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x75E5E20", Offset = "0x75E4420", VA = "0x1875E5E20")]
	public HPGHIPCFAII(string FOBKIBNHAIN, string JMCLCDMOBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C50", Offset = "0x75E4250", VA = "0x1875E5C50")]
	private void PAJAPMGAPDG(string LICKIJEDJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x75E5D60", Offset = "0x75E4360", VA = "0x1875E5D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B60", Offset = "0x75E4160", VA = "0x1875E5B60")]
	public string NKNKMPDJKMB(bool KGEHAIIDPFH = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KFLDOFEBIFG
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int IMLEHBCCMLP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool CLLIEBJJCAG;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int OMPCACCANNP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int NAOGCHBJBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private HPGHIPCFAII NCLGHKILECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string FHIPDKDJJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int HMOLDIAIPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int JOFPMCMKAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<HPGHIPCFAII> KADGGONKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DGLKJIONHKD DOCBBHEHELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> CODPKKJNKAC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JBIPNINEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC9DCD0", Offset = "0xC9C2D0", VA = "0x180C9DCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x75E6980", Offset = "0x75E4F80", VA = "0x1875E6980")]
	public KFLDOFEBIFG(HPGHIPCFAII NCLGHKILECI, Action<HPGHIPCFAII> MADOIJJBCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75E6400", Offset = "0x75E4A00", VA = "0x1875E6400")]
	public bool EKFPEOGCKKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75E6780", Offset = "0x75E4D80", VA = "0x1875E6780")]
	public static string PJMENJKLKCG(string HJLMHMJONGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x75E6770", Offset = "0x75E4D70", VA = "0x1875E6770")]
	protected internal void HIKILABAKPP(object BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x75E6130", Offset = "0x75E4730", VA = "0x1875E6130")]
	protected internal bool BINGDNACEEK()
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
