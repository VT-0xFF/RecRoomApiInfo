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
public interface ILLANJCFFBD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> JEMBAAOPIKB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODJBPBOKEJG(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGFCDHJEDPM(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDGNHCIOCIO(object DGGGDIFONNG, bool BNFJEOJPMAK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable MFKCENPJFON();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JFCDBFONNCA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KJNOGLCIEOJ(StringBuilder BEFMIMFIJIG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PMMHEEOBNPF(bool LFOMHGMKBFA, [Out] string IHNODDPNJFM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFLKAAABHDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MAICKIEJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BIBDBGFJJEI BCMCIFMALDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JBGOLEIACAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IPCCNKPHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KHMANIKLLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LLMGNGFFFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MJMNFFKKEHK DKJLAGIBOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PKPMDEBOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BIBDBGFJJEI, BIBDBGFJJEI> KPHBGBJJGLH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGBGKPEFHIC(DLEHLCJNFNH BDBODJKDEFI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CIBENGAENMB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OPPIDCAHNCC(string NGKJGDGNKID, JJKGFJNILJN IIPHMBBJJOK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BEFHIONLBGJ();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MGOCBHOENNE(AppSettings AIFBNJACDIC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BIBDBGFJJEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CCAFIFOJGFB JNBLFEEMEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	MLGLNBIJLBF JBNBLODPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LLMGNGFFFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JBGOLEIACAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JBKKAAFGPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception LIBJAINJLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode PPKAOMIJAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event DLEHLCJNFNH.ENAJHJFFANE BCDEPHIEMGF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CCAFIFOJGFB, CCAFIFOJGFB> FJPHLCHCMMA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPLDGNFGIMN(object CGJNNJHBPPG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LOOOHJGENFF(object KMNNAAALLBG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MAPACEJJCNA(byte IJFDGCGMCIN, int ANAIMHELOBD, object KLBPGDIPDDO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BAMJKGJMHHG
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DLEHLCJNFNH.ENAJHJFFANE BCDEPHIEMGF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MAPACEJJCNA GLFMHHMHNEO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HKIKANEFKCH(byte IJFDGCGMCIN, Hashtable MAPKHIFEPKF, HFFDOGAGJJK LGLBJBPNKJD, SendOptions GKDLFHLFLCF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NANIMBGAFBC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JNNGHBDDOHB AJKMKMCLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int APAEDBOFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int LHNNCPGNCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool LPBCKNAKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int CLKGCLLHCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JNNGHBDDOHB> DMAPDNMIHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	JNNGHBDDOHB FKNFAPBLHEM(int ADKBDELMJDI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OEGPKCEJIFK
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action LHLPKEMJLFH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEOJCNCDKDP();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DALGFALCFLA : EFLKAAABHDG, ILLANJCFFBD, BAMJKGJMHHG, NANIMBGAFBC, OEGPKCEJIFK
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int PIKMINHMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int LMNJIDAMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float LONEGKHNBLN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float HDPHMPGINJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LCFJKKEBNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IEBOEINCHHI CBGDBCCHKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action FGEGPOIBKDF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKADIOHCIBN();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FADEFNHDBLL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCJFEFKIEDD(string CACPKKKADGG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IEBOEINCHHI
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PJGNGBMPAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PHCJOLIILNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<GAFPHIPAKPP> NABJIGFBIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FEMKDGJFFOB(Action PFENHFNPELH, string HOKOHKFJPBE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GFAHGIKBLIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string GIJOHDPJIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 FIKECJKJAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion EDMDHCBPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 IPCBBKCLHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CDJJKDDBFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> HDBHLPKCJDD;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D064B0", Offset = "0x6D050B0", VA = "0x186D064B0")]
	public object[] AOAIHFNIAHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public GFAHGIKBLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CKFJJMEGABG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D05CC0", Offset = "0x6D048C0", VA = "0x186D05CC0")]
	public static bool BHMOLIMAIEN(this EFLKAAABHDG AKGPOGINELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D05D60", Offset = "0x6D04960", VA = "0x186D05D60")]
	public static bool FGIPLJJAIPK(this EFLKAAABHDG AKGPOGINELM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KJOCIEGILKG : DALGFALCFLA, EFLKAAABHDG, ILLANJCFFBD, BAMJKGJMHHG, NANIMBGAFBC, OEGPKCEJIFK
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class JCAIOPLOKPP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KJOCIEGILKG OKABEKIIIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HINLMPLCGEB;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D06750", Offset = "0x6D05350", VA = "0x186D06750")]
		public JCAIOPLOKPP(KJOCIEGILKG OKABEKIIIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D06650", Offset = "0x6D05250", VA = "0x186D06650", Slot = "1")]
		~JCAIOPLOKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6D065C0", Offset = "0x6D051C0", VA = "0x186D065C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D066F0", Offset = "0x6D052F0", VA = "0x186D066F0")]
		private void OLBNFLAKAKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object KEOLBBJAJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object GCDGDGJHJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float KHPJKIEPLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float BOIELFBDKLF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool PKPMDEBOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float DFJDDNMKAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int PIKMINHMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int LMNJIDAMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract JNNGHBDDOHB AJKMKMCLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int APAEDBOFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D06A30", Offset = "0x6D05630", VA = "0x186D06A30", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int LHNNCPGNCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int CLKGCLLHCGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LPBCKNAKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D07B40", Offset = "0x6D06740", VA = "0x186D07B40", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float LONEGKHNBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA22470", Offset = "0xA21070", VA = "0x180A22470", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D07920", Offset = "0x6D06520", VA = "0x186D07920", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float HDPHMPGINJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA22430", Offset = "0xA21030", VA = "0x180A22430", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6D07450", Offset = "0x6D06050", VA = "0x186D07450", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool LCFJKKEBNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract IEBOEINCHHI CBGDBCCHKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool MAICKIEJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BIBDBGFJJEI BCMCIFMALDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool JBGOLEIACAE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool IPCCNKPHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool KHMANIKLLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool LLMGNGFFFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract MJMNFFKKEHK DKJLAGIBOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private GFFNOHKJGNM FJPOMPGGCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private GFFNOHKJGNM BEADHCABEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private OPNFBDLFKNK<Func<float>> JCGFOEEABNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool CCJPMOAJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x103CCC0", Offset = "0x103B8C0", VA = "0x18103CCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool DGOLHIJMDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D07180", Offset = "0x6D05D80", VA = "0x186D07180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool FDAPFENPDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6D067B0", Offset = "0x6D053B0", VA = "0x186D067B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event DLEHLCJNFNH.ENAJHJFFANE BCDEPHIEMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D06930", Offset = "0x6D05530", VA = "0x186D06930", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D07540", Offset = "0x6D06140", VA = "0x186D07540", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event MAPACEJJCNA GLFMHHMHNEO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<JNNGHBDDOHB> DMAPDNMIHDJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<BIBDBGFJJEI, BIBDBGFJJEI> KPHBGBJJGLH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> JEMBAAOPIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D07870", Offset = "0x6D06470", VA = "0x186D07870", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D06880", Offset = "0x6D05480", VA = "0x186D06880", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action FGEGPOIBKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D06F90", Offset = "0x6D05B90", VA = "0x186D06F90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D06C30", Offset = "0x6D05830", VA = "0x186D06C30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action LHLPKEMJLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6D07AA0", Offset = "0x6D066A0", VA = "0x186D07AA0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D06AA0", Offset = "0x6D056A0", VA = "0x186D06AA0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract JNNGHBDDOHB FKNFAPBLHEM(int ADKBDELMJDI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool MGOCBHOENNE(AppSettings AIFBNJACDIC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void BEFHIONLBGJ();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool CIBENGAENMB();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void HLJLGGDDPCK();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool HKIKANEFKCH(byte IJFDGCGMCIN, Hashtable MAPKHIFEPKF, HFFDOGAGJJK LGLBJBPNKJD, SendOptions GKDLFHLFLCF);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool OPPIDCAHNCC(string NGKJGDGNKID, JJKGFJNILJN IIPHMBBJJOK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void NCJFEFKIEDD(string CACPKKKADGG);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void JGBGKPEFHIC(DLEHLCJNFNH BDBODJKDEFI);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D07DF0", Offset = "0x6D069F0", VA = "0x186D07DF0")]
	protected KJOCIEGILKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D07490", Offset = "0x6D06090", VA = "0x186D07490")]
	public void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D06CD0", Offset = "0x6D058D0", VA = "0x186D06CD0", Slot = "35")]
	public void GDGNHCIOCIO(object DGGGDIFONNG, bool BNFJEOJPMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D07960", Offset = "0x6D06560", VA = "0x186D07960", Slot = "33")]
	public void ODJBPBOKEJG(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D07A60", Offset = "0x6D06660", VA = "0x186D07A60", Slot = "34")]
	public void OGFCDHJEDPM(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D074B0", Offset = "0x6D060B0", VA = "0x186D074B0", Slot = "36")]
	public IDisposable MFKCENPJFON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D07BD0", Offset = "0x6D067D0", VA = "0x186D07BD0", Slot = "91")]
	public virtual bool PMMHEEOBNPF(bool LFOMHGMKBFA, [Out] string IHNODDPNJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D06DF0", Offset = "0x6D059F0", VA = "0x186D06DF0")]
	private bool HBDLNGBOIDI([Out] string IHNODDPNJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D06BA0", Offset = "0x6D057A0", VA = "0x186D06BA0")]
	private bool FEOOPIFKGLE([Out] string IHNODDPNJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D07130", Offset = "0x6D05D30", VA = "0x186D07130", Slot = "37")]
	public bool JFCDBFONNCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D071D0", Offset = "0x6D05DD0", VA = "0x186D071D0", Slot = "38")]
	public void KJNOGLCIEOJ(StringBuilder BEFMIMFIJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D076C0", Offset = "0x6D062C0", VA = "0x186D076C0")]
	private void NFNMGDIBHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D069A0", Offset = "0x6D055A0", VA = "0x186D069A0")]
	private void DNMPOMGDOGP(Func<float> EIMOHNDJBIA, object DGGGDIFONNG, int LLJMNDBPFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D075B0", Offset = "0x6D061B0", VA = "0x186D075B0", Slot = "92")]
	public void NDBPJJGEFKM(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D067F0", Offset = "0x6D053F0", VA = "0x186D067F0", Slot = "8")]
	public void AKADIOHCIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D06B40", Offset = "0x6D05740", VA = "0x186D06B40", Slot = "9")]
	public void FADEFNHDBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D07030", Offset = "0x6D05C30", VA = "0x186D07030")]
	private void IAIJHIIEEBA(float KNDDOANJCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xA22430", Offset = "0xA21030", VA = "0x180A22430")]
	private float JCAGCGNNGDL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA22470", Offset = "0xA21070", VA = "0x180A22470")]
	private float DFBIMGNAKDC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D07610", Offset = "0x6D06210", VA = "0x186D07610")]
	private void NDKINGJDBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D070E0", Offset = "0x6D05CE0", VA = "0x186D070E0", Slot = "55")]
	public void JEOJCNCDKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class FEGPFFGILFB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string BHLEOPFDPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool IDJFIHIAEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool KLMKDMDNGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int HCHNNFFKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] AKEGPMDCELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte NPIAOKAFOPI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random FDAIBJDJLOB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D06330", Offset = "0x6D04F30", VA = "0x186D06330", Slot = "5")]
	public virtual bool NGOAIPJIOBI(string OKGBEPMMNAH, int APMPPPPEKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D062E0", Offset = "0x6D04EE0", VA = "0x186D062E0", Slot = "6")]
	public virtual bool NCHIJCGLJCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D06290", Offset = "0x6D04E90", VA = "0x186D06290", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D06210", Offset = "0x6D04E10", VA = "0x186D06210")]
	protected internal void CIBOHFMOAPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D06400", Offset = "0x6D05000", VA = "0x186D06400")]
	protected FEGPFFGILFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PIKBGIHHBLI : FEGPFFGILFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket MLLPCEFIJCI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D08B40", Offset = "0x6D07740", VA = "0x186D08B40", Slot = "5")]
	public override bool NGOAIPJIOBI(string OKGBEPMMNAH, int APMPPPPEKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D08950", Offset = "0x6D07550", VA = "0x186D08950", Slot = "6")]
	public override bool NCHIJCGLJCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6225CA0", Offset = "0x62248A0", VA = "0x186225CA0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D08DE0", Offset = "0x6D079E0", VA = "0x186D08DE0")]
	public PIKBGIHHBLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBMOLFMALGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string BGLGEDDNMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string DBMBJMLEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string OBNHFIIOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PPDBDCHFIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x887AC0", Offset = "0x8866C0", VA = "0x180887AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x887B00", Offset = "0x886700", VA = "0x180887B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D060F0", Offset = "0x6D04CF0", VA = "0x186D060F0")]
	public DBMOLFMALGJ(string BEJBEGCOGFB, string CNNFBDLEEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D05F20", Offset = "0x6D04B20", VA = "0x186D05F20")]
	private void BHGODGFJEGD(string IGPLLPNDACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D06030", Offset = "0x6D04C30", VA = "0x186D06030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D05E30", Offset = "0x6D04A30", VA = "0x186D05E30")]
	public string ALHNMHFJLGE(bool NCKANGGHHLA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NOHIPMNFNEH
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int JBGAJCCKGFF;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool CGFOMOBPMAC;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int CMEADBBKMFL;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int FCMHKFEFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private DBMOLFMALGJ JJHOKHDDIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string CABFBBCHKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int FJPCJCPDKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int NCNIBFEOBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<DBMOLFMALGJ> GKGDFCNDGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private FEGPFFGILFB BAFCCGEHBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> KMOAOJLNBAL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NCHIJCGLJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD13460", Offset = "0xD12060", VA = "0x180D13460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D088A0", Offset = "0x6D074A0", VA = "0x186D088A0")]
	public NOHIPMNFNEH(DBMOLFMALGJ JJHOKHDDIOO, Action<DBMOLFMALGJ> NAAOBJBKFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D084C0", Offset = "0x6D070C0", VA = "0x186D084C0")]
	public bool LMFNDHIOLEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D08340", Offset = "0x6D06F40", VA = "0x186D08340")]
	public static string JCGEPJPCMKH(string CGGIPBFLODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D08060", Offset = "0x6D06C60", VA = "0x186D08060")]
	protected internal void AAILHDDJDHL(object PDMONEGPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D08070", Offset = "0x6D06C70", VA = "0x186D08070")]
	protected internal bool GGHJGGEJEAF()
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
