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
public interface AHPJNCONHHP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> EDDLMNFMABJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCFKCFBMLJL(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCPHPGPNFNM(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMAACNJHHML(object PDIBILKHEBM, bool HAHCBMKKOPH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable LCLDMDMHAHC();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HCMJOFIFGOI();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NIHNDJEMJJM(StringBuilder NGAHMDPMIKM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NEIAMMILEMD(bool MGFJOMAAPOK, [Out] string KHEFJOIGNAL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AKHGEFLEJLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LFHEJNLBFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	COKJBHCIMAO APLEKKAOEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OOHCJCDCFML
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BJLJHNIAGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DOFIAFJHDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AOOMLDALFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NOIJIJHODEK FNHBDHLKAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HCBMMKMPEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<COKJBHCIMAO, COKJBHCIMAO> LPNNPPONECK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGMNMMOCLJD(CDNICEFMPNI AKHBPPCMFBI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IJDJPBEFDNO();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GNPPHGAMONP(string HEFHEMPACAP, NIHCEBALPIN CGFJCEBMDIK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HBBHEEPBGJF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PPOFACKILDJ(AppSettings BDGLLFIDIGH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface COKJBHCIMAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LNDBMADGBPO BJGHGMCHJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	EHAGJIPMFMJ PLALJBFOANM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AOOMLDALFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OOHCJCDCFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IDLFHLEBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception ENJJCCLFAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode KAEMKJGEMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CDNICEFMPNI.EKOLLBKOOJM GDLGIAPADEC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LNDBMADGBPO, LNDBMADGBPO> MFONFEAGEIE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMMPAHDFLHG(object MNNJBJHGADP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGDJAEHKHKA(object AAKNFKIBICK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KLHNPJFMDOG(byte JIPPKPFPDIK, int LCFOPBENPPI, object MFCMLHEKFHP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NBPCAFMKLOH
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CDNICEFMPNI.EKOLLBKOOJM GDLGIAPADEC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KLHNPJFMDOG MPOMHEPCOGG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GJLFBJDGFOL(byte JIPPKPFPDIK, Hashtable NBPNCBMEKGD, IJFLFDFKCGL OKFDMLIKDID, SendOptions DGFPPPCJEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CPAGEPJPJIM
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HANCNHADEOE GALCGBAAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LBMFDHDBELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int CBNBFABIDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool GJEJAOKPENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int HDOAECNFICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<HANCNHADEOE> CCGHAGLKCDH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	HANCNHADEOE HCEDMBJIKHA(int CLPPFKPDPCI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GBEOMIDHIBK
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JEGOEGOOAHN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKPGMADMIMF();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HDJBGMMJLFC : AKHGEFLEJLJ, AHPJNCONHHP, NBPCAFMKLOH, CPAGEPJPJIM, GBEOMIDHIBK
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int GNGGONMFAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int CKADCPALEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float BKCMGHFMODN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LMDCMCAMALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KJPNOEKPGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	OODKJCJCCJI EGOPKHAMBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action KKMNIOJJMHB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJDMHCHAIBO();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKKPDGCINEL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JJJOANKEPAA(string MALEFJAEALK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OODKJCJCCJI
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HPHMDEMAOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PFIJCPGFMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<MHHOMOIELAC> JPINKEAICCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EDPGLGJOJDN(Action NIBHFGHJBIE, string CKIDPNOOKDN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AACLNBMFKJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string PKEHFOLGNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 PGFEEKJAPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion KDDDCEFLNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 MBJOJLHPKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int OPEOLPNOFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> CHDGKKNGKCL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E46620", Offset = "0x5E45620", VA = "0x185E46620")]
	public object[] AOGDGGEDDCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public AACLNBMFKJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ALDCOIHHLIH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E46730", Offset = "0x5E45730", VA = "0x185E46730")]
	public static bool HDCKDNKOBLJ(this AKHGEFLEJLJ DPHJBIJGINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E467D0", Offset = "0x5E457D0", VA = "0x185E467D0")]
	public static bool ONHPNIJFLOJ(this AKHGEFLEJLJ DPHJBIJGINF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class HHPGPDBJLOO : HDJBGMMJLFC, AKHGEFLEJLJ, AHPJNCONHHP, NBPCAFMKLOH, CPAGEPJPJIM, GBEOMIDHIBK
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class CENMLDGPDMJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HHPGPDBJLOO MCCPDCBMAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BKIGCJKEOGE;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E46FA0", Offset = "0x5E45FA0", VA = "0x185E46FA0")]
		public CENMLDGPDMJ(HHPGPDBJLOO MCCPDCBMAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E46EA0", Offset = "0x5E45EA0", VA = "0x185E46EA0", Slot = "1")]
		~CENMLDGPDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E46E10", Offset = "0x5E45E10", VA = "0x185E46E10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E46F40", Offset = "0x5E45F40", VA = "0x185E46F40")]
		private void GEDALEFEAKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object BNLNJJCMPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object FNEAKLKNGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float DIJGNIKOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float PMNDDOHGEHE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool HCBMMKMPEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float EADOOHGJCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int GNGGONMFAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int CKADCPALEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract HANCNHADEOE GALCGBAAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LBMFDHDBELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E47B60", Offset = "0x5E46B60", VA = "0x185E47B60", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int CBNBFABIDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int HDOAECNFICP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool GJEJAOKPENL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E48990", Offset = "0x5E47990", VA = "0x185E48990", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float BKCMGHFMODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BF290", Offset = "0x7BE290", VA = "0x1807BF290", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E47730", Offset = "0x5E46730", VA = "0x185E47730", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float LMDCMCAMALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6A0", Offset = "0x7BD6A0", VA = "0x1807BE6A0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E48160", Offset = "0x5E47160", VA = "0x185E48160", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool KJPNOEKPGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract OODKJCJCCJI EGOPKHAMBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool LFHEJNLBFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract COKJBHCIMAO APLEKKAOEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool OOHCJCDCFML
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool BJLJHNIAGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool DOFIAFJHDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool AOOMLDALFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract NOIJIJHODEK FNHBDHLKAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private KFKHIDKOEKA AIOKGODOPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private KFKHIDKOEKA MIAEMGGDACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private MPKMDECLIGE<Func<float>> AJMMCENPEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool AAGLBKOKBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xBE8730", Offset = "0xBE7730", VA = "0x180BE8730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool KMJNGEHHHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E48820", Offset = "0x5E47820", VA = "0x185E48820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool OMHGKELJGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E473E0", Offset = "0x5E463E0", VA = "0x185E473E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event CDNICEFMPNI.EKOLLBKOOJM GDLGIAPADEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E47BD0", Offset = "0x5E46BD0", VA = "0x185E47BD0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E479A0", Offset = "0x5E469A0", VA = "0x185E479A0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event KLHNPJFMDOG MPOMHEPCOGG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<HANCNHADEOE> CCGHAGLKCDH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<COKJBHCIMAO, COKJBHCIMAO> LPNNPPONECK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> EDDLMNFMABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E48230", Offset = "0x5E47230", VA = "0x185E48230", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E47C40", Offset = "0x5E46C40", VA = "0x185E47C40", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action KKMNIOJJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E482E0", Offset = "0x5E472E0", VA = "0x185E482E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E47AC0", Offset = "0x5E46AC0", VA = "0x185E47AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action JEGOEGOOAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E47900", Offset = "0x5E46900", VA = "0x185E47900", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E47610", Offset = "0x5E46610", VA = "0x185E47610", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract HANCNHADEOE HCEDMBJIKHA(int CLPPFKPDPCI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool PPOFACKILDJ(AppSettings BDGLLFIDIGH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void HBBHEEPBGJF();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool IJDJPBEFDNO();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void AIHJABCBCFM();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool GJLFBJDGFOL(byte JIPPKPFPDIK, Hashtable NBPNCBMEKGD, IJFLFDFKCGL OKFDMLIKDID, SendOptions DGFPPPCJEAL);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool GNPPHGAMONP(string HEFHEMPACAP, NIHCEBALPIN CGFJCEBMDIK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void JJJOANKEPAA(string MALEFJAEALK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void CGMNMMOCLJD(CDNICEFMPNI AKHBPPCMFBI);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E48A20", Offset = "0x5E47A20", VA = "0x185E48A20")]
	protected HHPGPDBJLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E47710", Offset = "0x5E46710", VA = "0x185E47710")]
	public void EMCBFDNIFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E48870", Offset = "0x5E47870", VA = "0x185E48870", Slot = "35")]
	public void NMAACNJHHML(object PDIBILKHEBM, bool HAHCBMKKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E47770", Offset = "0x5E46770", VA = "0x185E47770", Slot = "33")]
	public void GCFKCFBMLJL(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E474D0", Offset = "0x5E464D0", VA = "0x185E474D0", Slot = "34")]
	public void CCPHPGPNFNM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E47E90", Offset = "0x5E46E90", VA = "0x185E47E90", Slot = "36")]
	public IDisposable LCLDMDMHAHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E48380", Offset = "0x5E47380", VA = "0x185E48380", Slot = "91")]
	public virtual bool NEIAMMILEMD(bool MGFJOMAAPOK, [Out] string KHEFJOIGNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E47CF0", Offset = "0x5E46CF0", VA = "0x185E47CF0")]
	private bool LCCAIDLALKA([Out] string KHEFJOIGNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E47F20", Offset = "0x5E46F20", VA = "0x185E47F20")]
	private bool LJCCEGDPFLE([Out] string KHEFJOIGNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E47A10", Offset = "0x5E46A10", VA = "0x185E47A10", Slot = "37")]
	public bool HCMJOFIFGOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E485A0", Offset = "0x5E475A0", VA = "0x185E485A0", Slot = "38")]
	public void NIHNDJEMJJM(StringBuilder NGAHMDPMIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E47FB0", Offset = "0x5E46FB0", VA = "0x185E47FB0")]
	private void LLEMECNFGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5E481A0", Offset = "0x5E471A0", VA = "0x185E481A0")]
	private void MHKCHNKEEDH(Func<float> OJAOHGDJGKB, object PDIBILKHEBM, int ELAMBHMPGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E476B0", Offset = "0x5E466B0", VA = "0x185E476B0", Slot = "92")]
	public void EIGGDIECJHC(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E47870", Offset = "0x5E46870", VA = "0x185E47870", Slot = "8")]
	public void GJDMHCHAIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5E47A60", Offset = "0x5E46A60", VA = "0x185E47A60", Slot = "9")]
	public void HKKPDGCINEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E47560", Offset = "0x5E46560", VA = "0x185E47560")]
	private void EDNBAOHFHNG(float HMHJOGKKCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6A0", Offset = "0x7BD6A0", VA = "0x1807BE6A0")]
	private float HJMHBLAHJGM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BF290", Offset = "0x7BE290", VA = "0x1807BF290")]
	private float IGPMECHPOCI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E47420", Offset = "0x5E46420", VA = "0x185E47420")]
	private void BJBNMIMGOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E47510", Offset = "0x5E46510", VA = "0x185E47510", Slot = "55")]
	public void CKPGMADMIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class IEOLOJEKKDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string CHOGNIMKOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool MHDGCPNCJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool GBIFKHKACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int AHBPDJOJLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] FEANDCLJIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte NCLKHOLEMJI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random NDDCNAMHILH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E48BA0", Offset = "0x5E47BA0", VA = "0x185E48BA0", Slot = "5")]
	public virtual bool BIPLAIBHCEI(string GFCJGHPDBGP, int KJJGHOHKLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E48CC0", Offset = "0x5E47CC0", VA = "0x185E48CC0", Slot = "6")]
	public virtual bool HENBNPHHBNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E48C70", Offset = "0x5E47C70", VA = "0x185E48C70", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E48BF0", Offset = "0x5E47BF0", VA = "0x185E48BF0")]
	protected internal void CAFOKCFCPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E48D90", Offset = "0x5E47D90", VA = "0x185E48D90")]
	protected IEOLOJEKKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BBPDFKEFNGK : IEOLOJEKKDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket MOLLGBILPKP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E468A0", Offset = "0x5E458A0", VA = "0x185E468A0", Slot = "5")]
	public override bool BIPLAIBHCEI(string GFCJGHPDBGP, int KJJGHOHKLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E46B40", Offset = "0x5E45B40", VA = "0x185E46B40", Slot = "6")]
	public override bool HENBNPHHBNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5536730", Offset = "0x5535730", VA = "0x185536730", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E46D30", Offset = "0x5E45D30", VA = "0x185E46D30")]
	public BBPDFKEFNGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKCAKNPKKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string MFDDLNFEFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string CJHJDHEFOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string JJKEECEJDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ILJMBLJBEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7786E0", Offset = "0x7776E0", VA = "0x1807786E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x777F90", Offset = "0x776F90", VA = "0x180777F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E472C0", Offset = "0x5E462C0", VA = "0x185E472C0")]
	public CKCAKNPKKEM(string JBMNHFKOFIC, string IKKEONFGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E47000", Offset = "0x5E46000", VA = "0x185E47000")]
	private void BGFGCECEPAC(string GPMIGCIDEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E47200", Offset = "0x5E46200", VA = "0x185E47200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E47110", Offset = "0x5E46110", VA = "0x185E47110")]
	public string FJANONDAONI(bool EBLECIIECJL = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PIAJFMLBDGF
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int POGLBBPNLLO;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool IEFGNLIPMGB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int MHHAAKFPHCF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int KFGHFPHECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CKCAKNPKKEM CLLGAHDOGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string FJAFGMDMNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int HLMADDKAOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int LMICMHJEDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<CKCAKNPKKEM> IHGDPNLEICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IEOLOJEKKDG EGOCMDPCJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> FGNAMLGGHFM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HENBNPHHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E0", Offset = "0x81E7E0", VA = "0x18081F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D7190", Offset = "0x8D6190", VA = "0x1808D7190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E49780", Offset = "0x5E48780", VA = "0x185E49780")]
	public PIAJFMLBDGF(CKCAKNPKKEM CLLGAHDOGII, Action<CKCAKNPKKEM> CNGAPAKAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E48F40", Offset = "0x5E47F40", VA = "0x185E48F40")]
	public bool IMBOKILCADD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E492B0", Offset = "0x5E482B0", VA = "0x185E492B0")]
	public static string KDLGEMMIJON(string AOHHOGCAHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E48F30", Offset = "0x5E47F30", VA = "0x185E48F30")]
	protected internal void BFHAMDEIGIC(object ACJODAOHIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E49430", Offset = "0x5E48430", VA = "0x185E49430")]
	protected internal bool KEGCKEPPIGP()
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
