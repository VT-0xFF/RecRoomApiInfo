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
public interface KNJEPKLFJIN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> LEILHDGPJDP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEDPAOOCOOK(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHNNJOGDDFM(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJPONMKGNPD(object DJIMHLGHFGI, bool DCCBIOFBKCH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable MBCGNJAMKOP();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBEJPKPLEOC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CIJHBCLCBMN(StringBuilder OEMCDECEAMB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FOBCNKINBCC(bool HHCOAHGNHBC, [Out] string JBBHONJKFOI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EBBAMDIMBPH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BFMKLCGCLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LOAJAEDOCNE AMKOOECMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IFHMFCKCCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CNCEADFAAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JGFIODNLMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NBEEBBDKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ALCGPHOEAMP DJPGLMFONDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HMGOEIFONAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LOAJAEDOCNE, LOAJAEDOCNE> AGAKFCIJMAL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEBBEEKOIIP(OJJCFGIFEDK GOKCLKGFJEB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GLOIGDPLMID();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JLKOPNFDJGB(string CGAPFDNEGKP, ECKGKNLHAMF CAJLLPLPNPC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BDLPHMFFDAD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FDOIPMNGFPP(AppSettings JEINFCPBFHP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LOAJAEDOCNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LBENMMLKEDE HBDMEBKPJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	FDPDNONGKEL FKNIOMFDJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NBEEBBDKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool IFHMFCKCCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ANJKJAOMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception COOPNOHOLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode DMLNPDECPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OJJCFGIFEDK.MDCMIMDHCCE NOFPMNKPHEJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LBENMMLKEDE, LBENMMLKEDE> DMONGKEOKPI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IKDBKEFHPPE(object BIINCLMPDMO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KNPCCBLBGIA(object IODMFFCMOGK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MIACEINFGJO(byte LDDLJBFNIGE, int PHOEBDGADNM, object NBKLKIFNAIH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FOHNPGGGNPG
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OJJCFGIFEDK.MDCMIMDHCCE NOFPMNKPHEJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MIACEINFGJO DKPNFMKEKCB;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMPPBKPPJNM(byte LDDLJBFNIGE, Hashtable HOCNKHEKJDK, FFFPNEALPAM DDDGCKEMPHN, SendOptions PCCKLELNGGA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HBMCHPBEIEL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OEDKOGGDKCO GAJHHPEBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int EIGNFCJBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int CJELGCIOPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int NDKGILILCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<OEDKOGGDKCO> AMOCINDBBJF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	OEDKOGGDKCO BCMHJKKOPKH(int OLKCJJDGMPH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OCOMJIKCDIE
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JBFOMODCIKL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOPEDPEBFGN();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LIMEHMPEEEM : EBBAMDIMBPH, KNJEPKLFJIN, FOHNPGGGNPG, HBMCHPBEIEL, OCOMJIKCDIE
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int PEIBHPGCAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int MEDDHMALMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float MDECEHDBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CNGAIJKECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NCHODANCOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LODDBMFDJNC KBFEGBMCGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action KDEKKNJIGHN;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCPMPNPOMGL();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EENCCNPFPLG();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BINDFANMKMJ(string BNEJADEFINH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LODDBMFDJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HGLNNKEFEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HFOEDPEIPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<FFEKFHMNIMA> BOLEHNPFPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DLOPNMIBFLI(Action JNNELGHFPMP, string IJNCMJJNGOF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JKIMGDGHAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string HPNIKHKGNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 CMIONGHAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion HMMDLPIJNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 NAKLDIOMBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int GOMHGMKMGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> DIMDNCPDKCA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x701B750", Offset = "0x7019F50", VA = "0x18701B750")]
	public object[] LKLEMCPGFIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public JKIMGDGHAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NPABKAAABGA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x701C320", Offset = "0x701AB20", VA = "0x18701C320")]
	public static bool OAHIEAGDKJP(this EBBAMDIMBPH BCOBOABIEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x701C250", Offset = "0x701AA50", VA = "0x18701C250")]
	public static bool MCLMFAEIOAP(this EBBAMDIMBPH BCOBOABIEHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class ALNPAHBCPON : LIMEHMPEEEM, EBBAMDIMBPH, KNJEPKLFJIN, FOHNPGGGNPG, HBMCHPBEIEL, OCOMJIKCDIE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FGFKLHNOHEA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ALNPAHBCPON HPEKLOJHJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BCEDAPNKMCC;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x701B450", Offset = "0x7019C50", VA = "0x18701B450")]
		public FGFKLHNOHEA(ALNPAHBCPON HPEKLOJHJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x701B350", Offset = "0x7019B50", VA = "0x18701B350", Slot = "1")]
		~FGFKLHNOHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x701B2C0", Offset = "0x7019AC0", VA = "0x18701B2C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x701B3F0", Offset = "0x7019BF0", VA = "0x18701B3F0")]
		private void PJEOIAEBKKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object OPEKNKKLBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object DGELDMGKMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float ACFHMEGNHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float AKEECPEDNMB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool HMGOEIFONAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float HAHEKJDJDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int PEIBHPGCAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int MEDDHMALMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract OEDKOGGDKCO GAJHHPEBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EIGNFCJBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x701A3A0", Offset = "0x7018BA0", VA = "0x18701A3A0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int CJELGCIOPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int NDKGILILCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x701A540", Offset = "0x7018D40", VA = "0x18701A540", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float MDECEHDBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC155F0", Offset = "0xC13DF0", VA = "0x180C155F0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x701A0B0", Offset = "0x70188B0", VA = "0x18701A0B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float CNGAIJKECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC155E0", Offset = "0xC13DE0", VA = "0x180C155E0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7019450", Offset = "0x7017C50", VA = "0x187019450", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool NCHODANCOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract LODDBMFDJNC KBFEGBMCGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool BFMKLCGCLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract LOAJAEDOCNE AMKOOECMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool IFHMFCKCCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool CNCEADFAAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool JGFIODNLMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool NBEEBBDKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract ALCGPHOEAMP DJPGLMFONDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private COKMJHAKPPF ABLFKKLOANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private COKMJHAKPPF KNHMKAILBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private LMHDAIHDIFF<Func<float>> GMCDHNIAKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool NCMBDLOOAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x123A6C0", Offset = "0x1238EC0", VA = "0x18123A6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool IDAOLKMLAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x701A5D0", Offset = "0x7018DD0", VA = "0x18701A5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool CHHHGBIILPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7019260", Offset = "0x7017A60", VA = "0x187019260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event OJJCFGIFEDK.MDCMIMDHCCE NOFPMNKPHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7019490", Offset = "0x7017C90", VA = "0x187019490", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x701A2D0", Offset = "0x7018AD0", VA = "0x18701A2D0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event MIACEINFGJO DKPNFMKEKCB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<OEDKOGGDKCO> AMOCINDBBJF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<LOAJAEDOCNE, LOAJAEDOCNE> AGAKFCIJMAL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> LEILHDGPJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x701A000", Offset = "0x7018800", VA = "0x18701A000", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x701A620", Offset = "0x7018E20", VA = "0x18701A620", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action KDEKKNJIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x701A4A0", Offset = "0x7018CA0", VA = "0x18701A4A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7019910", Offset = "0x7018110", VA = "0x187019910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action JBFOMODCIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7019870", Offset = "0x7018070", VA = "0x187019870", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70191C0", Offset = "0x70179C0", VA = "0x1870191C0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract OEDKOGGDKCO BCMHJKKOPKH(int OLKCJJDGMPH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool FDOIPMNGFPP(AppSettings JEINFCPBFHP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void BDLPHMFFDAD();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool GLOIGDPLMID();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void MJKGGECDBNJ();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool BMPPBKPPJNM(byte LDDLJBFNIGE, Hashtable HOCNKHEKJDK, FFFPNEALPAM DDDGCKEMPHN, SendOptions PCCKLELNGGA);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool JLKOPNFDJGB(string CGAPFDNEGKP, ECKGKNLHAMF CAJLLPLPNPC);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void BINDFANMKMJ(string BNEJADEFINH);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void EEBBEEKOIIP(OJJCFGIFEDK GOKCLKGFJEB);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x701A7F0", Offset = "0x7018FF0", VA = "0x18701A7F0")]
	protected ALNPAHBCPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7019A10", Offset = "0x7018210", VA = "0x187019A10")]
	public void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7019DA0", Offset = "0x70185A0", VA = "0x187019DA0", Slot = "35")]
	public void GJPONMKGNPD(object DJIMHLGHFGI, bool DCCBIOFBKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7019770", Offset = "0x7017F70", VA = "0x187019770", Slot = "33")]
	public void DEDPAOOCOOK(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x701A0F0", Offset = "0x70188F0", VA = "0x18701A0F0", Slot = "34")]
	public void JHNNJOGDDFM(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x701A410", Offset = "0x7018C10", VA = "0x18701A410", Slot = "36")]
	public IDisposable MBCGNJAMKOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7019B30", Offset = "0x7018330", VA = "0x187019B30", Slot = "91")]
	public virtual bool FOBCNKINBCC(bool HHCOAHGNHBC, [Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x701A130", Offset = "0x7018930", VA = "0x18701A130")]
	private bool KEDKABGJNGK([Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x701A760", Offset = "0x7018F60", VA = "0x18701A760")]
	private bool PGHAPLGDNLJ([Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7019A30", Offset = "0x7018230", VA = "0x187019A30", Slot = "37")]
	public bool FBEJPKPLEOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7019500", Offset = "0x7017D00", VA = "0x187019500", Slot = "38")]
	public void CIJHBCLCBMN(StringBuilder OEMCDECEAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x70192A0", Offset = "0x7017AA0", VA = "0x1870192A0")]
	private void BHOKHHADJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7019F70", Offset = "0x7018770", VA = "0x187019F70")]
	private void HAMEPMMJKLM(Func<float> GDFJKJGCAHC, object DJIMHLGHFGI, int LAICNCJBINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x701A340", Offset = "0x7018B40", VA = "0x18701A340", Slot = "92")]
	public void LLAALJCHNLN(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x701A6D0", Offset = "0x7018ED0", VA = "0x18701A6D0", Slot = "8")]
	public void PCPMPNPOMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70199B0", Offset = "0x70181B0", VA = "0x1870199B0", Slot = "9")]
	public void EENCCNPFPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7019A80", Offset = "0x7018280", VA = "0x187019A80")]
	private void FHCPKCJFFPA(float DEKMBJOBNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xC155E0", Offset = "0xC13DE0", VA = "0x180C155E0")]
	private float FBMNPBDONOH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xC155F0", Offset = "0xC13DF0", VA = "0x180C155F0")]
	private float CGOOGLINECC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7019EC0", Offset = "0x70186C0", VA = "0x187019EC0")]
	private void GLDFCLGCEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7019D50", Offset = "0x7018550", VA = "0x187019D50", Slot = "55")]
	public void FOPEDPEBFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class IDOECNOFLJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string AEONBBFDBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool LJCKEGHDGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool NKLAKGGKKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int KJBBFKEKHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] AKBFPAMAKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte JHBCCGFCLJK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random MNEPNPHPFCK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x701B550", Offset = "0x7019D50", VA = "0x18701B550", Slot = "5")]
	public virtual bool JDGNBFHOGLO(string INHOFJLHHHP, int NHIJINHMIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x701B4B0", Offset = "0x7019CB0", VA = "0x18701B4B0", Slot = "6")]
	public virtual bool AKFDNGBDHPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x701B500", Offset = "0x7019D00", VA = "0x18701B500", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x701B5A0", Offset = "0x7019DA0", VA = "0x18701B5A0")]
	protected internal void LDJJIOLOFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x701B6A0", Offset = "0x7019EA0", VA = "0x18701B6A0")]
	protected IDOECNOFLJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DLMBFHOEKCL : IDOECNOFLJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket LEIPGLGKKKG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x701AF40", Offset = "0x7019740", VA = "0x18701AF40", Slot = "5")]
	public override bool JDGNBFHOGLO(string INHOFJLHHHP, int NHIJINHMIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x701AD50", Offset = "0x7019550", VA = "0x18701AD50", Slot = "6")]
	public override bool AKFDNGBDHPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64F4270", Offset = "0x64F2A70", VA = "0x1864F4270", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x701B1E0", Offset = "0x70199E0", VA = "0x18701B1E0")]
	public DLMBFHOEKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBAFDMBBKGH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string CBCLICGCOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FNKAPCOAFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string IMEDJPCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HFCPGOALABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B5240", Offset = "0x8B3A40", VA = "0x1808B5240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x701AC30", Offset = "0x7019430", VA = "0x18701AC30")]
	public DBAFDMBBKGH(string KIEPLEFDLFJ, string MDIGHMBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x701A970", Offset = "0x7019170", VA = "0x18701A970")]
	private void GEHMOCGBAPJ(string MNOENFCLILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x701AB70", Offset = "0x7019370", VA = "0x18701AB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x701AA80", Offset = "0x7019280", VA = "0x18701AA80")]
	public string MIGALIJEKAM(bool CAMODODLEDA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NLDDEDFJOCG
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int OMDLKIIFMDB;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool LFEGKELHLFC;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int IJJLOFKBBOB;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int BDNOAHMMNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private DBAFDMBBKGH BJMPCNFHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string MCBICOABHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int AKGALHPEFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int POAJIAKJGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<DBAFDMBBKGH> NNNAEIOLAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IDOECNOFLJJ KKFLHLIJHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> FMFCMPIMLAD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AKFDNGBDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA028C0", Offset = "0xA010C0", VA = "0x180A028C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x701C1A0", Offset = "0x701A9A0", VA = "0x18701C1A0")]
	public NLDDEDFJOCG(DBAFDMBBKGH BJMPCNFHCKB, Action<DBAFDMBBKGH> KAJLLCILGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x701B960", Offset = "0x701A160", VA = "0x18701B960")]
	public bool CIICEFGCNDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x701BFA0", Offset = "0x701A7A0", VA = "0x18701BFA0")]
	public static string LCPDLDIFPGJ(string MGNHDIJJAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x701B950", Offset = "0x701A150", VA = "0x18701B950")]
	protected internal void BKEPLHIMCKK(object IKGPEBFFMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x701BCD0", Offset = "0x701A4D0", VA = "0x18701BCD0")]
	protected internal bool HLDKLHPIJHP()
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
