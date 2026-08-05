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
public interface FFJNDGBCJKJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> FICLFLDINIH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGMAPGDJJJC(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLGFKJEEIPJ(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHNAAFJKBNJ(object KIAKEGJPMAL, bool FMGPAPMCAKG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable IIBDMBHPIEH();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GMGDJPFPLOK();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CKMJOOFKAPL(StringBuilder ICLBMBEPLED);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NBFECOLKNEG(bool FDFNKHKIJFI, [Out] string HLPKEEDLIBL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GDMHDAAKABH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AKDPNBPLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NCPEHMNDMGE OMFBJGACMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NDFLLOOKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CNJFMDCFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AFAPDHIEGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BBGGDANMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MCINOFGOPIN JMJAPBGMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GMLOIJNEKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NCPEHMNDMGE, NCPEHMNDMGE> KEPFIDIOCBC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PNIOAFLHPKJ(NCNPIPEEFLG MEAOIIOHJDC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KPLPHLIGDMG();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LNCHDKAILIL(string IEKFPPBBHHC, FAOJMAKOAPP LIBEOECBKPG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELIKLHPLONE();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FECOBPHGMGJ(AppSettings PLMDHCPMLFA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NCPEHMNDMGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KBGMFEBKJBD EEGGEKKHJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	PGCFLJLDKLM ODHGELPFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BBGGDANMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool NDFLLOOKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GNJOMMOFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception JIGOLPCHKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode IIFGOHOMJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NCNPIPEEFLG.BBGODEDCGEL BALDJAENMIM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<KBGMFEBKJBD, KBGMFEBKJBD> BCGPHKCEOMC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHKBJDNPGGI(object KMJKCJJHEFM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HOFLMLIPINO(object INDOLFKCPBN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MOCIEJGKFFB(byte DFBOOPBNIGI, int NOEJIEGJBEK, object HOCFILEOKMJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OECDCEILJFN
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NCNPIPEEFLG.BBGODEDCGEL BALDJAENMIM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MOCIEJGKFFB HIJOCHCOMMC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJEDOMOCHEH(byte DFBOOPBNIGI, Hashtable BBDAIOEBCKN, ACADAJIBIJM OONIKFINHEG, SendOptions GBEFIOLAGPM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CGBMONMGACN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JLNLBCDKCMG BPCDKOHENOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int FFGLFFIIPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int EHGDIPGJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool NIAEKLOMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int HKAMFIAMFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JLNLBCDKCMG> CPJNHBENIEG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	JLNLBCDKCMG OILMLGEMGCE(int MHCLCCCFPCD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KIPAGPGKHMM
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action CKPKCEGOIHI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBAJJKABAMO();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EMCLNBMIAFK : GDMHDAAKABH, FFJNDGBCJKJ, OECDCEILJFN, CGBMONMGACN, KIPAGPGKHMM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DLEKDMLNNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int PCPMKFPEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float AFGCDAAAHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float MNBOCODCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BBFKFKAPNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	NDOKGPDDKPK BGLJAIBBBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action GFJALLKIACJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJCMBAKFHCP();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMPBLLMPEKI();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CAHFKMGDONN(string MKKJLFIBOJM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NDOKGPDDKPK
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ELPIDDFMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CGLEDMCCDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<LPKCMADNJHA> CGLLCDMGDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BPJGOGMACOH(Action GNGPONJIDAG, string ENJNNGLDCFJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BOMHCHLNMHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string NIOIBGKFGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 PFHBDAPBAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion NJONFLGOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 NBKHJBIAPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KDIKBHCANHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> PGLBKHOJHKF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D990", Offset = "0x5D2C190", VA = "0x185D2D990")]
	public object[] POFDLDNGFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BOMHCHLNMHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AOLHILIMMIB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C130", Offset = "0x5D2A930", VA = "0x185D2C130")]
	public static bool KPDNLNLFBJK(this GDMHDAAKABH FPEKOACGMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C060", Offset = "0x5D2A860", VA = "0x185D2C060")]
	public static bool ALMBADGBPGB(this GDMHDAAKABH FPEKOACGMGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class BDEJIENONBD : EMCLNBMIAFK, GDMHDAAKABH, FFJNDGBCJKJ, OECDCEILJFN, CGBMONMGACN, KIPAGPGKHMM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class AAMBIMHMNGK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BDEJIENONBD OKIKPLGEMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KIMEMKKPGDJ;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C000", Offset = "0x5D2A800", VA = "0x185D2C000")]
		public AAMBIMHMNGK(BDEJIENONBD OKIKPLGEMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BF00", Offset = "0x5D2A700", VA = "0x185D2BF00", Slot = "1")]
		~AAMBIMHMNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BE70", Offset = "0x5D2A670", VA = "0x185D2BE70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BFA0", Offset = "0x5D2A7A0", VA = "0x185D2BFA0")]
		private void JCDFHDNLEBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object MHJMKCFNKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object LBFBLEOEILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float ACFIPLCEADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float ELIFOICOBNA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool GMLOIJNEKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float GFBDDBBGHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int DLEKDMLNNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int PCPMKFPEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract JLNLBCDKCMG BPCDKOHENOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int FFGLFFIIPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C900", Offset = "0x5D2B100", VA = "0x185D2C900", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int EHGDIPGJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int HKAMFIAMFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool NIAEKLOMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CDC0", Offset = "0x5D2B5C0", VA = "0x185D2CDC0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float AFGCDAAAHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B7860", Offset = "0x7B6060", VA = "0x1807B7860", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C8C0", Offset = "0x5D2B0C0", VA = "0x185D2C8C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float MNBOCODCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B40", Offset = "0x7B6340", VA = "0x1807B7B40", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D7D0", Offset = "0x5D2BFD0", VA = "0x185D2D7D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool BBFKFKAPNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract NDOKGPDDKPK BGLJAIBBBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool AKDPNBPLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract NCPEHMNDMGE OMFBJGACMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool NDFLLOOKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool CNJFMDCFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool AFAPDHIEGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool BBGGDANMMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract MCINOFGOPIN JMJAPBGMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private BOKOFNDFGJO OFODNDNDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private BOKOFNDFGJO GCMHGDDGJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BLEEFDHCAOL<Func<float>> HDKJBJNPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool GILKDLMIIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB654E0", Offset = "0xB63CE0", VA = "0x180B654E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool KAGFMDBDMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D780", Offset = "0x5D2BF80", VA = "0x185D2D780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool OJKCIBIAGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CAB0", Offset = "0x5D2B2B0", VA = "0x185D2CAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event NCNPIPEEFLG.BBGODEDCGEL BALDJAENMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CC00", Offset = "0x5D2B400", VA = "0x185D2CC00", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CF40", Offset = "0x5D2B740", VA = "0x185D2CF40", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event MOCIEJGKFFB HIJOCHCOMMC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<JLNLBCDKCMG> CPJNHBENIEG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<NCPEHMNDMGE, NCPEHMNDMGE> KEPFIDIOCBC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> FICLFLDINIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CC70", Offset = "0x5D2B470", VA = "0x185D2CC70", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CB50", Offset = "0x5D2B350", VA = "0x185D2CB50", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action GFJALLKIACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D320", Offset = "0x5D2BB20", VA = "0x185D2D320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D280", Offset = "0x5D2BA80", VA = "0x185D2D280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action CKPKCEGOIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CEA0", Offset = "0x5D2B6A0", VA = "0x185D2CEA0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CD20", Offset = "0x5D2B520", VA = "0x185D2CD20", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract JLNLBCDKCMG OILMLGEMGCE(int MHCLCCCFPCD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool FECOBPHGMGJ(AppSettings PLMDHCPMLFA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void ELIKLHPLONE();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool KPLPHLIGDMG();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void EHADPMMJPLJ();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool IJEDOMOCHEH(byte DFBOOPBNIGI, Hashtable BBDAIOEBCKN, ACADAJIBIJM OONIKFINHEG, SendOptions GBEFIOLAGPM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool LNCHDKAILIL(string IEKFPPBBHHC, FAOJMAKOAPP LIBEOECBKPG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void CAHFKMGDONN(string MKKJLFIBOJM);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void PNIOAFLHPKJ(NCNPIPEEFLG MEAOIIOHJDC);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D810", Offset = "0x5D2C010", VA = "0x185D2D810")]
	protected BDEJIENONBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C970", Offset = "0x5D2B170", VA = "0x185D2C970")]
	public void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D160", Offset = "0x5D2B960", VA = "0x185D2D160", Slot = "35")]
	public void MHNAAFJKBNJ(object KIAKEGJPMAL, bool FMGPAPMCAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D060", Offset = "0x5D2B860", VA = "0x185D2D060", Slot = "33")]
	public void MGMAPGDJJJC(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C9E0", Offset = "0x5D2B1E0", VA = "0x185D2C9E0", Slot = "34")]
	public void HLGFKJEEIPJ(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CA20", Offset = "0x5D2B220", VA = "0x185D2CA20", Slot = "36")]
	public IDisposable IIBDMBHPIEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D420", Offset = "0x5D2BC20", VA = "0x185D2D420", Slot = "91")]
	public virtual bool NBFECOLKNEG(bool FDFNKHKIJFI, [Out] string HLPKEEDLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C720", Offset = "0x5D2AF20", VA = "0x185D2C720")]
	private bool DOKLNJINHKO([Out] string HLPKEEDLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D640", Offset = "0x5D2BE40", VA = "0x185D2D640")]
	private bool NOPOPNPBJDC([Out] string HLPKEEDLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C990", Offset = "0x5D2B190", VA = "0x185D2C990", Slot = "37")]
	public bool GMGDJPFPLOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C1D0", Offset = "0x5D2A9D0", VA = "0x185D2C1D0", Slot = "38")]
	public void CKMJOOFKAPL(StringBuilder ICLBMBEPLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C450", Offset = "0x5D2AC50", VA = "0x185D2C450")]
	private void CNENOECMKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C600", Offset = "0x5D2AE00", VA = "0x185D2C600")]
	private void DCHFGNFHAJK(Func<float> CEELOHPGNMA, object KIAKEGJPMAL, int HHCPPOIJJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CAF0", Offset = "0x5D2B2F0", VA = "0x185D2CAF0", Slot = "92")]
	public void INOHBOKECIB(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C690", Offset = "0x5D2AE90", VA = "0x185D2C690", Slot = "8")]
	public void DJCMBAKFHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D3C0", Offset = "0x5D2BBC0", VA = "0x185D2D3C0", Slot = "9")]
	public void MMPBLLMPEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CFB0", Offset = "0x5D2B7B0", VA = "0x185D2CFB0")]
	private void MGLNGEFPEOF(float EHHDIDGCGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B40", Offset = "0x7B6340", VA = "0x1807B7B40")]
	private float CJFCBAMLJLG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B7860", Offset = "0x7B6060", VA = "0x1807B7860")]
	private float LEAGJOLHBCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D6D0", Offset = "0x5D2BED0", VA = "0x185D2D6D0")]
	private void OIPHCNPOHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CE50", Offset = "0x5D2B650", VA = "0x185D2CE50", Slot = "55")]
	public void LBAJJKABAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KIMBLEKFNBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string HNFBCPAMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool MICMJAIBBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool GIPBIDJFIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int PONOHMODIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] AECKJJBFKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte GPNOKBIADOO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random CEBHECGPHKB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E850", Offset = "0x5D2D050", VA = "0x185D2E850", Slot = "5")]
	public virtual bool JEKFJBHBHAG(string NIKDGEIMAJI, int KNFDIBCGIDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E8A0", Offset = "0x5D2D0A0", VA = "0x185D2E8A0", Slot = "6")]
	public virtual bool OCPAAMPGIAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E780", Offset = "0x5D2CF80", VA = "0x185D2E780", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E7D0", Offset = "0x5D2CFD0", VA = "0x185D2E7D0")]
	protected internal void FCMGAGDDFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E970", Offset = "0x5D2D170", VA = "0x185D2E970")]
	protected KIMBLEKFNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PIBDJFBANCE : KIMBLEKFNBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket DICDHBODBIA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EB10", Offset = "0x5D2D310", VA = "0x185D2EB10", Slot = "5")]
	public override bool JEKFJBHBHAG(string NIKDGEIMAJI, int KNFDIBCGIDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EDB0", Offset = "0x5D2D5B0", VA = "0x185D2EDB0", Slot = "6")]
	public override bool OCPAAMPGIAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x542F870", Offset = "0x542E070", VA = "0x18542F870", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EFA0", Offset = "0x5D2D7A0", VA = "0x185D2EFA0")]
	public PIBDJFBANCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FKIBIIFMBOH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string LHEDMGNEBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string IHBLGBGHGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string IBHMMMKAGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HODJFPAJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x76A230", Offset = "0x768A30", VA = "0x18076A230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E660", Offset = "0x5D2CE60", VA = "0x185D2E660")]
	public FKIBIIFMBOH(string ICNFOOHBEIB, string JHEIHLJAGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E3A0", Offset = "0x5D2CBA0", VA = "0x185D2E3A0")]
	private void CELKMMIEIBC(string JCOJLMHNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E5A0", Offset = "0x5D2CDA0", VA = "0x185D2E5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E4B0", Offset = "0x5D2CCB0", VA = "0x185D2E4B0")]
	public string DLFKHDBPLEJ(bool MGHNLIEJONO = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CCKMAFOGPBM
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int GHKGJMLBGCA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool OLELCIFINOA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int GNPMBIEALHB;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int ICPHHCECIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private FKIBIIFMBOH CCMHBBLECKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string GGOGEHENNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int LFPFABALLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int FJFONHMJKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<FKIBIIFMBOH> HALPEBOPNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KIMBLEKFNBL GLEMMKAEINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> BJOLIPFEFHO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OCPAAMPGIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B0", Offset = "0x86A0B0", VA = "0x18086B8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E2F0", Offset = "0x5D2CAF0", VA = "0x185D2E2F0")]
	public CCKMAFOGPBM(FKIBIIFMBOH CCMHBBLECKK, Action<FKIBIIFMBOH> KCKJFODCDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC20", Offset = "0x5D2C420", VA = "0x185D2DC20")]
	public bool IIKKOHLIEBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DAA0", Offset = "0x5D2C2A0", VA = "0x185D2DAA0")]
	public static string FJDPCDGFJFD(string NDFKGEMHPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E260", Offset = "0x5D2CA60", VA = "0x185D2E260")]
	protected internal void NEOAKEGNDAM(object FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DF90", Offset = "0x5D2C790", VA = "0x185D2DF90")]
	protected internal bool JPGMCLAOFMD()
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
