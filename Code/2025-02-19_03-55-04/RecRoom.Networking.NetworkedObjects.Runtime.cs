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
public interface GKKFDFILMMC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> PNICNHIGDLO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBBJIOFGKPA(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMDLGLJIDEF(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BOAJFCEDFAA(object IKLHDHMJFFL, bool BLDCPMNMFCH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable MDEDMHAELOC();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CLEBPAHAGPF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKJFPANDMIG(StringBuilder MKOCLFBKMCE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OAJFAJCIACA(bool KMHEHKLABAE, [Out] string AHPAHIHOBBE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CCHDEGCJIJC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CFMEMHDEDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AHEOCDECANP IMDBOAOGEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LIBGJFKOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LIHDKLBPKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BJEIGKHPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CMEFKJJPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FGBJKBOCCCD MDFCEPCAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OLJCHAPBEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AHEOCDECANP, AHEOCDECANP> KGEOMNKDPON;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJKDIEPBCCC(EOAAEPAAGJE DLFCNPDKING);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FJNAINILCLB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FNMAIGJADPG(string HLGBLAOGNHJ, MIDKJFLBGEL PDOKDKGGNDH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GPPHNGGGGEG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MNEFBCKHIDN(AppSettings DIINHJEALHM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AHEOCDECANP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FNJPGNOECDD NOCPNLHJEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	CNOMJDADKEL FBOGIBIIIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CMEFKJJPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LIBGJFKOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FCGHBGGFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception NJHHPHINMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode IFNLPENJOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EOAAEPAAGJE.FOFEJMNAPAB IBKPOFGDFKD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<FNJPGNOECDD, FNJPGNOECDD> LJJFFDDGLAC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DOBIOFJKEDN(object EJGAMJDEIEL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCHEMBCCLEE(object OOFCGPINGEA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PEMPDFCFPLJ(byte DBIADELHCAC, int KEJOCEPAGCK, object MCKCODFDFLP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AEIBJBCHIBE
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EOAAEPAAGJE.FOFEJMNAPAB IBKPOFGDFKD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PEMPDFCFPLJ KIEPAGIKIEI;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NKJHBMLPIMI(byte DBIADELHCAC, object ADBGIDEPMFJ, JJDLPMGEECN BFKAHMLFOLP, SendOptions MNGKBMLKHPG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FNLDFBFCOLB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GDNMNFALBCN DCCCIJHEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JLIKKPBLFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int KMPLAGIKFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int CGKHOIGPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<GDNMNFALBCN> IOLDOLDCCHA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	GDNMNFALBCN KBNHCMPDJOD(int HOGOECIJPMO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OMKDFABMFAN
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action MHHLOKCFJGM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPPFOOJBIGC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CIFPFBINLMO : CCHDEGCJIJC, GKKFDFILMMC, AEIBJBCHIBE, FNLDFBFCOLB, OMKDFABMFAN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int HFHJGMBKABB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int ACBGOOACKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int PBLGNAAIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float HCCOODIGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float LFEIGJCPJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IMKKNJCDNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OGCNCCPCHED EMNLHMGGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action ILCIHDPAPJO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDKIPBAOCPI();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MCIIAJNODHJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEJIAHFFBAI(List<object> DGHHCPPFODF, int PKAJCFBDMNB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DCMODEBFKKA(int MNOCOFLMADB, object MCKCODFDFLP);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EKJHAONNEOL(Hashtable HBMPGPFHEDM, int GMOJJMIJPJF);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BHLGIPNAFIB();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KAPEEKIMLKL();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KIDDMECNGEB(string CBFOLKJFMLL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OGCNCCPCHED
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PIPENHIIEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ECAIBKDMNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<FKNBKFLEBNP> MDINLHNNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool POOJJPCHFOE(Action GHAMOOHMICM, string FFBBBLFGEMI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PHEKHLGEKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string PIKHMCHBOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 JCCKFLFINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion BLLDMMJBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 JKIMKCFOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CFGGCDGNMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public JLHPGPMALFI LDCEMPEJMLC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75898E0", Offset = "0x75884E0", VA = "0x1875898E0")]
	public object[] FFENMIAIFNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public PHEKHLGEKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IKOJNJKDFMI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7588F20", Offset = "0x7587B20", VA = "0x187588F20")]
	public static bool AKEMBBFGDMM(this CCHDEGCJIJC MNMFGFEBDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7588FC0", Offset = "0x7587BC0", VA = "0x187588FC0")]
	public static bool KKNPODIGCCF(this CCHDEGCJIJC MNMFGFEBDCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class AEGPIFBBLNC : CIFPFBINLMO, CCHDEGCJIJC, GKKFDFILMMC, AEIBJBCHIBE, FNLDFBFCOLB, OMKDFABMFAN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class KKKJGKMALIA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AEGPIFBBLNC JGAHEOEPJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool EIHBPFOIIHI;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7589790", Offset = "0x7588390", VA = "0x187589790")]
		public KKKJGKMALIA(AEGPIFBBLNC JGAHEOEPJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7589690", Offset = "0x7588290", VA = "0x187589690", Slot = "1")]
		~KKKJGKMALIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7589600", Offset = "0x7588200", VA = "0x187589600", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7589730", Offset = "0x7588330", VA = "0x187589730")]
		private void LNLKHOHMAPL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object LNKHGEHFEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object KMLDIOMFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float GKDDFHADHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float KABNNGHHIIM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool OLJCHAPBEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float FDGLMNPGNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int HFHJGMBKABB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int ACBGOOACKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract GDNMNFALBCN DCCCIJHEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JLIKKPBLFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75875D0", Offset = "0x75861D0", VA = "0x1875875D0", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int KMPLAGIKFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int CGKHOIGPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AAFFOOJAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7587040", Offset = "0x7585C40", VA = "0x187587040", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int PBLGNAAIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float HCCOODIGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE95D30", Offset = "0xE94930", VA = "0x180E95D30", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7586C60", Offset = "0x7585860", VA = "0x187586C60", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float LFEIGJCPJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE95D20", Offset = "0xE94920", VA = "0x180E95D20", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7587640", Offset = "0x7586240", VA = "0x187587640", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool IMKKNJCDNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract OGCNCCPCHED EMNLHMGGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool CFMEMHDEDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract AHEOCDECANP IMDBOAOGEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool LIBGJFKOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool LIHDKLBPKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool BJEIGKHPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool CMEFKJJPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract FGBJKBOCCCD MDFCEPCAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private MKEMIGJFLFM FOEACNOMEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private MKEMIGJFLFM HCFIKMALKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private GOPCCLCPPEB<Func<float>> DPNPDLEBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool NCJKLDCGEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x14DD6A0", Offset = "0x14DC2A0", VA = "0x1814DD6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool LLFBMINLMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75868C0", Offset = "0x75854C0", VA = "0x1875868C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool HFPMEGLOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7587680", Offset = "0x7586280", VA = "0x187587680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event EOAAEPAAGJE.FOFEJMNAPAB IBKPOFGDFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7587260", Offset = "0x7585E60", VA = "0x187587260", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7586FD0", Offset = "0x7585BD0", VA = "0x187586FD0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event PEMPDFCFPLJ KIEPAGIKIEI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<GDNMNFALBCN> IOLDOLDCCHA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<AHEOCDECANP, AHEOCDECANP> KGEOMNKDPON;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> PNICNHIGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75867F0", Offset = "0x75853F0", VA = "0x1875867F0", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7586CA0", Offset = "0x75858A0", VA = "0x187586CA0", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action ILCIHDPAPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7587760", Offset = "0x7586360", VA = "0x187587760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75876C0", Offset = "0x75862C0", VA = "0x1875876C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action MHHLOKCFJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7586B70", Offset = "0x7585770", VA = "0x187586B70", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7587D90", Offset = "0x7586990", VA = "0x187587D90", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract GDNMNFALBCN KBNHCMPDJOD(int HOGOECIJPMO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool MNEFBCKHIDN(AppSettings DIINHJEALHM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void GPPHNGGGGEG();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool FJNAINILCLB();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void DDKIPBAOCPI();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void MCIIAJNODHJ();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void NEJIAHFFBAI(List<object> DGHHCPPFODF, int PKAJCFBDMNB);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void DCMODEBFKKA(int MNOCOFLMADB, object MCKCODFDFLP);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void EKJHAONNEOL(Hashtable HBMPGPFHEDM, int GMOJJMIJPJF);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool NKJHBMLPIMI(byte DBIADELHCAC, object ADBGIDEPMFJ, JJDLPMGEECN BFKAHMLFOLP, SendOptions MNGKBMLKHPG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool FNMAIGJADPG(string HLGBLAOGNHJ, MIDKJFLBGEL PDOKDKGGNDH);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void KIDDMECNGEB(string CBFOLKJFMLL);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void CJKDIEPBCCC(EOAAEPAAGJE DLFCNPDKING);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7587E30", Offset = "0x7586A30", VA = "0x187587E30")]
	protected AEGPIFBBLNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75868A0", Offset = "0x75854A0", VA = "0x1875868A0")]
	public void AIMKJDEKJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7586A00", Offset = "0x7585600", VA = "0x187586A00", Slot = "41")]
	public void BOAJFCEDFAA(object IKLHDHMJFFL, bool BLDCPMNMFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x75870D0", Offset = "0x7585CD0", VA = "0x1875870D0", Slot = "39")]
	public void JBBJIOFGKPA(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7587530", Offset = "0x7586130", VA = "0x187587530", Slot = "40")]
	public void JMDLGLJIDEF(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7587800", Offset = "0x7586400", VA = "0x187587800", Slot = "42")]
	public IDisposable MDEDMHAELOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7587940", Offset = "0x7586540", VA = "0x187587940", Slot = "102")]
	public virtual bool OAJFAJCIACA(bool KMHEHKLABAE, [Out] string AHPAHIHOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7587BF0", Offset = "0x75867F0", VA = "0x187587BF0")]
	private bool OLIHKGHIABG([Out] string AHPAHIHOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7587B60", Offset = "0x7586760", VA = "0x187587B60")]
	private bool OKNNNLEAKDE([Out] string AHPAHIHOBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7586C10", Offset = "0x7585810", VA = "0x187586C10", Slot = "43")]
	public bool CLEBPAHAGPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7586D50", Offset = "0x7585950", VA = "0x187586D50", Slot = "44")]
	public void HKJFPANDMIG(StringBuilder MKOCLFBKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75872D0", Offset = "0x7585ED0", VA = "0x1875872D0")]
	private void JKMGCOJBNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x75871D0", Offset = "0x7585DD0", VA = "0x1875871D0")]
	private void JEJBNPFBAEI(Func<float> KJJIHLDDFOA, object IKLHDHMJFFL, int NCDDNNAKJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7586910", Offset = "0x7585510", VA = "0x187586910", Slot = "103")]
	public void BFAELNLFAOG(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7586970", Offset = "0x7585570", VA = "0x187586970", Slot = "14")]
	public void BHLGIPNAFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7587570", Offset = "0x7586170", VA = "0x187587570", Slot = "15")]
	public void KAPEEKIMLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7587890", Offset = "0x7586490", VA = "0x187587890")]
	private void NKLPPKBGMGM(float IOGIGKLDIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xE95D20", Offset = "0xE94920", VA = "0x180E95D20")]
	private float DJKLEFGLBGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xE95D30", Offset = "0xE94930", VA = "0x180E95D30")]
	private float ICIOMKMHAKH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7587480", Offset = "0x7586080", VA = "0x187587480")]
	private void JLANJICFOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7586B20", Offset = "0x7585720", VA = "0x187586B20", Slot = "61")]
	public void BPPFOOJBIGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class AKFHKBMBOND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string FJKFIABKKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool NHPJEHKDLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool IOCCHGCEPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int LFNPEADKGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] KNKOLCPMMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte DOKEMACEJPE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random KLGNGBNFPIG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x75880D0", Offset = "0x7586CD0", VA = "0x1875880D0", Slot = "5")]
	public virtual bool ILLIBHLFKGN(string AIOLGAKFHJJ, int JCJFNFCDOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7588000", Offset = "0x7586C00", VA = "0x187588000", Slot = "6")]
	public virtual bool FMAMFKKANPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7587FB0", Offset = "0x7586BB0", VA = "0x187587FB0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7588050", Offset = "0x7586C50", VA = "0x187588050")]
	protected internal void HGFFJCPBDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x75881A0", Offset = "0x7586DA0", VA = "0x1875881A0")]
	protected AKFHKBMBOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JAMKCNEICHM : AKFHKBMBOND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket GFIDDOCABHN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7589280", Offset = "0x7587E80", VA = "0x187589280", Slot = "5")]
	public override bool ILLIBHLFKGN(string AIOLGAKFHJJ, int JCJFNFCDOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7589090", Offset = "0x7587C90", VA = "0x187589090", Slot = "6")]
	public override bool FMAMFKKANPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B260", Offset = "0x6A49E60", VA = "0x186A4B260", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7589520", Offset = "0x7588120", VA = "0x187589520")]
	public JAMKCNEICHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IEPNCIMINFA
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string AHLCEPHNFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string CNKFFKANKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string KANADEEKBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int PPFNLBKJPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x95B850", Offset = "0x95A450", VA = "0x18095B850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7588E00", Offset = "0x7587A00", VA = "0x187588E00")]
	public IEPNCIMINFA(string BODILIPNFGI, string OLHKKFMKCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7588B40", Offset = "0x7587740", VA = "0x187588B40")]
	private void IAJPEJDFDCG(string JCABILHHJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7588D40", Offset = "0x7587940", VA = "0x187588D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7588C50", Offset = "0x7587850", VA = "0x187588C50")]
	public string NJMJILOFEBG(bool NBEMHEIAIMA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HOGNHOKMMOJ
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int LGFJHOHODAB;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool LDAEJPHPKGI;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int MIBMBMALLLO;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int CPGBHALGAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IEPNCIMINFA DCAJIMOGLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string OLEJIEJNCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int PMMHPJKFDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MJFLOOMJNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<IEPNCIMINFA> FHPBDANOAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AKFHKBMBOND MLDKHFLECIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> IOCHBBKIHNB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FMAMFKKANPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7588A90", Offset = "0x7587690", VA = "0x187588A90")]
	public HOGNHOKMMOJ(IEPNCIMINFA DCAJIMOGLHA, Action<IEPNCIMINFA> KKECKHPDMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75886A0", Offset = "0x75872A0", VA = "0x1875886A0")]
	public bool MEKDGOPFPIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7588250", Offset = "0x7586E50", VA = "0x187588250")]
	public static string JHHGPAACACO(string AMCGPDFKCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7588A10", Offset = "0x7587610", VA = "0x187588A10")]
	protected internal void OIDEKDDDDMG(object HJIAOGEIAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x75883D0", Offset = "0x7586FD0", VA = "0x1875883D0")]
	protected internal bool LFBKNGMFGCN()
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
