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
public interface CFDLLANNPBA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> PJKIMIIHOFC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COPIMBJEEJK(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLGCNILIHPL(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAFJEGGFDMF(object BNAJMHPOOCG, bool MNOEKFANECC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable GBKEIIMIJOA();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CNGHHGBNCEC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCAOBLKOFHC(StringBuilder GCPAONBCOGE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AABMBODEBFN(bool DFHCNHIDDHE, [Out] string JCNMJFGAPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BHJPCEDDLEA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DCJFBOECKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	JLDAELDHMLC EHOPLJOJEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HFBAIELOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NJJLBMAJDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BLJILKPKKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PGGFJANNDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DPPNCKENHPG FMEOMKPAOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EKIAFABCMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JLDAELDHMLC, JLDAELDHMLC> CEAELOIPMFG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALOIKKBBEKD(JDOGCGJKPPE NCLLFHKGFME);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LHCEGAGJOBH();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool ELBAKLDIJDF(string CLOFHJALNMG, OCOOCEGCFJD FCHNAIEBLNI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KNHBIBMHGAE();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LHOCHFJLNOL(AppSettings NKOPLEOINFC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JLDAELDHMLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EKPOAMHKLDB FKDBIGDEJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	KPFKDMPPPML CKBAFFIIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PGGFJANNDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HFBAIELOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AAFOIFKDCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception CNNMCAHGNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode PAIBAGPBMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JDOGCGJKPPE.AILJBBGDANA IBGMGNMAMAE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<EKPOAMHKLDB, EKPOAMHKLDB> PBOEACBCNMM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBABGIKLEFO(object EOCODFIAJEL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PCEBMBBMFEA(object BPICAHPLHGA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GHJGIGMODCE(byte JPLPGOOKPHK, int NHAAIOIBMGP, object PKOMIDKDHPE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LINMJCGLEJB
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JDOGCGJKPPE.AILJBBGDANA IBGMGNMAMAE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GHJGIGMODCE BLKLNEIBMJA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ECIOKAHOPIH(byte JPLPGOOKPHK, Hashtable BMOLLMAIDAL, BCCMHBGLICA OAOADNLCPPE, SendOptions DPLLIFDKBDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NDONFBLHPKA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MFDHGPCGOEK HGEDMCEEIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int GNIHCHGLDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int CKBCJCDLEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JJHCCHFCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int JLACIOPPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MFDHGPCGOEK> NPJPPEOLFFB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	MFDHGPCGOEK OGDINMJILHH(int DKIOMDOEGKN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LHKMBBMMNLG
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PDNHOKMPJHP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPLJMDIECFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EBILFIDBOCO : BHJPCEDDLEA, CFDLLANNPBA, LINMJCGLEJB, NDONFBLHPKA, LHKMBBMMNLG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int BMEAEECFILE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int BAKCNFCGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float HMEOMODDHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float PDDHIPANCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DOPHANAECIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FAGPHGLMCMB FMOKHGJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action HKBMMGHPAEL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILLICONECGH();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKFAHALICPB();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KHPFFFLHMDA(string FNJJHADPIDI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FAGPHGLMCMB
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NDLGHCJEKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BPNKAIKAMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<FEDEAINJLFP> PJNELHLAMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BPLODKOJGKP(Action KOCFPIMAJIN, string IOEPNLDEDBC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CILHIBEBALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string BJEABCDCCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 AEKKFHEKCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion INCJBNNECEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 JLELPEMFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int JMMIJJOMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> ANENFDCFAHL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6158620", Offset = "0x6157420", VA = "0x186158620")]
	public object[] PCPOOHANJDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public CILHIBEBALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AGOENEKGCGB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61564C0", Offset = "0x61552C0", VA = "0x1861564C0")]
	public static bool NFPGLDKKFAA(this BHJPCEDDLEA IMEDDJCIHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61563F0", Offset = "0x61551F0", VA = "0x1861563F0")]
	public static bool AICOCOLHIFB(this BHJPCEDDLEA IMEDDJCIHGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class CHIDJIICIID : EBILFIDBOCO, BHJPCEDDLEA, CFDLLANNPBA, LINMJCGLEJB, NDONFBLHPKA, LHKMBBMMNLG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GALOLMPJGEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CHIDJIICIID DOGFJHOPKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool OFJKLDDBIOI;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61588C0", Offset = "0x61576C0", VA = "0x1861588C0")]
		public GALOLMPJGEO(CHIDJIICIID DOGFJHOPKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61587C0", Offset = "0x61575C0", VA = "0x1861587C0", Slot = "1")]
		~GALOLMPJGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6158730", Offset = "0x6157530", VA = "0x186158730", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6158860", Offset = "0x6157660", VA = "0x186158860")]
		private void NFFNMDGBIEN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object EMPLPLJCILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object HBGNGLKKNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float CKDFBLAJBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float FDHGGHAKJEO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool EKIAFABCMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float BGGKGLGDFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int BMEAEECFILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int BAKCNFCGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract MFDHGPCGOEK HGEDMCEEIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GNIHCHGLDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6157460", Offset = "0x6156260", VA = "0x186157460", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int CKBCJCDLEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int JLACIOPPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JJHCCHFCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6157BC0", Offset = "0x61569C0", VA = "0x186157BC0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float HMEOMODDHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x97E690", Offset = "0x97D490", VA = "0x18097E690", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61576D0", Offset = "0x61564D0", VA = "0x1861576D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float PDDHIPANCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8DB630", Offset = "0x8DA430", VA = "0x1808DB630", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6157E00", Offset = "0x6156C00", VA = "0x186157E00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool DOPHANAECIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract FAGPHGLMCMB FMOKHGJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool DCJFBOECKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract JLDAELDHMLC EHOPLJOJEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool HFBAIELOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool NJJLBMAJDJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool BLJILKPKKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool PGGFJANNDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract DPPNCKENHPG FMEOMKPAOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private IGJOIAOJFFC EPOJCMNIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private IGJOIAOJFFC MFHNPHCBCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private ENJDMNBAMCK<Func<float>> IBNCLINHKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool FOMONLLAHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCC7510", Offset = "0xCC6310", VA = "0x180CC7510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool KOHECMGLECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6157370", Offset = "0x6156170", VA = "0x186157370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool ANBDIHIMLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6158460", Offset = "0x6157260", VA = "0x186158460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event JDOGCGJKPPE.AILJBBGDANA IBGMGNMAMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6158300", Offset = "0x6157100", VA = "0x186158300", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6157C50", Offset = "0x6156A50", VA = "0x186157C50", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event GHJGIGMODCE BLKLNEIBMJA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<MFDHGPCGOEK> NPJPPEOLFFB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<JLDAELDHMLC, JLDAELDHMLC> CEAELOIPMFG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> PJKIMIIHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6157A60", Offset = "0x6156860", VA = "0x186157A60", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6158180", Offset = "0x6156F80", VA = "0x186158180", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action HKBMMGHPAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6157120", Offset = "0x6155F20", VA = "0x186157120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6157E60", Offset = "0x6156C60", VA = "0x186157E60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action PDNHOKMPJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61573C0", Offset = "0x61561C0", VA = "0x1861573C0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6157080", Offset = "0x6155E80", VA = "0x186157080", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract MFDHGPCGOEK OGDINMJILHH(int DKIOMDOEGKN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool LHOCHFJLNOL(AppSettings NKOPLEOINFC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void KNHBIBMHGAE();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool LHCEGAGJOBH();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void KNDJMBOLOIC();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool ECIOKAHOPIH(byte JPLPGOOKPHK, Hashtable BMOLLMAIDAL, BCCMHBGLICA OAOADNLCPPE, SendOptions DPLLIFDKBDJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool ELBAKLDIJDF(string CLOFHJALNMG, OCOOCEGCFJD FCHNAIEBLNI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void KHPFFFLHMDA(string FNJJHADPIDI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void ALOIKKBBEKD(JDOGCGJKPPE NCLLFHKGFME);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61584A0", Offset = "0x61572A0", VA = "0x1861584A0")]
	protected CHIDJIICIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6157E40", Offset = "0x6156C40", VA = "0x186157E40")]
	public void KCJBJGBIMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61578B0", Offset = "0x61566B0", VA = "0x1861578B0", Slot = "35")]
	public void GAFJEGGFDMF(object BNAJMHPOOCG, bool MNOEKFANECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61575D0", Offset = "0x61563D0", VA = "0x1861575D0", Slot = "33")]
	public void COPIMBJEEJK(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6158230", Offset = "0x6157030", VA = "0x186158230", Slot = "34")]
	public void MLGCNILIHPL(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61579D0", Offset = "0x61567D0", VA = "0x1861579D0", Slot = "36")]
	public IDisposable GBKEIIMIJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6156E60", Offset = "0x6155C60", VA = "0x186156E60", Slot = "91")]
	public virtual bool AABMBODEBFN(bool DFHCNHIDDHE, [Out] string JCNMJFGAPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6157710", Offset = "0x6156510", VA = "0x186157710")]
	private bool EMMDLNDGAMP([Out] string JCNMJFGAPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6158270", Offset = "0x6157070", VA = "0x186158270")]
	private bool MNBEGBFIIAD([Out] string JCNMJFGAPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6157580", Offset = "0x6156380", VA = "0x186157580", Slot = "37")]
	public bool CNGHHGBNCEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6157F00", Offset = "0x6156D00", VA = "0x186157F00", Slot = "38")]
	public void LCAOBLKOFHC(StringBuilder GCPAONBCOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61571C0", Offset = "0x6155FC0", VA = "0x1861571C0")]
	private void AJLGEKAODIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6158370", Offset = "0x6157170", VA = "0x186158370")]
	private void NKEKNFAEEKM(Func<float> BBEOBJAMNEH, object BNAJMHPOOCG, int IAOKDNOLMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6158400", Offset = "0x6157200", VA = "0x186158400", Slot = "92")]
	public void OKODPNJDBEI(object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6157CC0", Offset = "0x6156AC0", VA = "0x186157CC0", Slot = "8")]
	public void ILLICONECGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6157520", Offset = "0x6156320", VA = "0x186157520", Slot = "9")]
	public void CKFAHALICPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6157D50", Offset = "0x6156B50", VA = "0x186157D50")]
	private void JHCBFBHPKIC(float BPIIOFNDDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8DB630", Offset = "0x8DA430", VA = "0x1808DB630")]
	private float GIGOHCHNCIF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x97E690", Offset = "0x97D490", VA = "0x18097E690")]
	private float EGAFCEJPNHH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6157B10", Offset = "0x6156910", VA = "0x186157B10")]
	private void GLAAPIEJHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61574D0", Offset = "0x61562D0", VA = "0x1861574D0", Slot = "55")]
	public void BPLJMDIECFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class KOLPKHLBOEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string CAMIHJAIJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool NBFPIGKPLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool KDINKEEBPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int BECHIIKLAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] EHDMFJAEEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte JEMFBPFMCOC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random KEEECNLIEGO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6158A90", Offset = "0x6157890", VA = "0x186158A90", Slot = "5")]
	public virtual bool DONDFHCINKO(string MFLOIGPFOJO, int IDELFPEFHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6158B30", Offset = "0x6157930", VA = "0x186158B30", Slot = "6")]
	public virtual bool NLJMOCMKKGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6158AE0", Offset = "0x61578E0", VA = "0x186158AE0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6158A10", Offset = "0x6157810", VA = "0x186158A10")]
	protected internal void AAEOMMPCBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6158C00", Offset = "0x6157A00", VA = "0x186158C00")]
	protected KOLPKHLBOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AFDNLADHPOE : KOLPKHLBOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket JBEPBGNJMMO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6155E80", Offset = "0x6154C80", VA = "0x186155E80", Slot = "5")]
	public override bool DONDFHCINKO(string MFLOIGPFOJO, int IDELFPEFHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6156120", Offset = "0x6154F20", VA = "0x186156120", Slot = "6")]
	public override bool NLJMOCMKKGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x579E240", Offset = "0x579D040", VA = "0x18579E240", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6156310", Offset = "0x6155110", VA = "0x186156310")]
	public AFDNLADHPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGBCNCLCOFO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string LBCBJOIFHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string PKFIGPGELNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EHJAABFDPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DKMGINNEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B0", Offset = "0x7C12B0", VA = "0x1807C24B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C24D0", Offset = "0x7C12D0", VA = "0x1807C24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6158F70", Offset = "0x6157D70", VA = "0x186158F70")]
	public LGBCNCLCOFO(string HHFLPJPBCOF, string AFNGGLCNEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6158CB0", Offset = "0x6157AB0", VA = "0x186158CB0")]
	private void BLAGLNLLCEA(string KBGJMFLFIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6158EB0", Offset = "0x6157CB0", VA = "0x186158EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6158DC0", Offset = "0x6157BC0", VA = "0x186158DC0")]
	public string NPHNFELPIKB(bool HAPOACJAKNJ = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BAOPKKLAHNG
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int MOMKMOFFFBD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool DOLANMDJKPO;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int JCLBCIBBNEE;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int HKKFCJKCEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private LGBCNCLCOFO OCNJMAPNFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string ILIIKMAGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int NENNHNIGMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int OKGGPPHOJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<LGBCNCLCOFO> CEMCCIMDAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KOLPKHLBOEF NJENLBAOFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> JABGLNCFMGB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NLJMOCMKKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F00", Offset = "0x8DFD00", VA = "0x1808E0F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B9090", Offset = "0x9B7E90", VA = "0x1809B9090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6156DB0", Offset = "0x6155BB0", VA = "0x186156DB0")]
	public BAOPKKLAHNG(LGBCNCLCOFO OCNJMAPNFFO, Action<LGBCNCLCOFO> ADJADHNPJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6156840", Offset = "0x6155640", VA = "0x186156840")]
	public bool FPLLGBFFFEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6156BB0", Offset = "0x61559B0", VA = "0x186156BB0")]
	public static string IFOKCALIELA(string KDDJHOEHGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6156560", Offset = "0x6155360", VA = "0x186156560")]
	protected internal void CPPHCLCIKPE(object KMABAKEMFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6156570", Offset = "0x6155370", VA = "0x186156570")]
	protected internal bool FCKAAMLDEEM()
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
