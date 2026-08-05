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
public interface DAILNJMEEOC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> CAIBMMIBKEP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNHNGOEJCFO(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAMBFDIKABP(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCLKPIEMGPG(object CMNJCPJBHGE, bool DGOLCPKLMFP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable HLAHIEGBJBL();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NFAPAPPDLBF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IFOIDFOOADP(StringBuilder DIOODJKKPOH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IJDACAIOMIE(bool MHPKBGBNFGL, [Out] string PLAICKAFAFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NGFLNNOMKLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IECJGGIBNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	COEKKCHLDDP BHIAMLBDELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MJBKGCMNHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AMNCMFACPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EPJMIBDABKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OOPHKJJKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PDIOEHHDNBA BLJNKJODEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BNOOFGDKAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<COEKKCHLDDP, COEKKCHLDDP> JIHLFJCOPJE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMFJPCDBMNM(GPHOFIKEMIO LGKJMLLHKCN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OIHLHAMAKNM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MKFEMNPFING(string LCGJGCMCLCG, JLDFPOGEHGB BOKCJBKLOMD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JOPAEBIHEFK();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LNGFKOMKOHO(AppSettings LLFCJPHNAHP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface COEKKCHLDDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AHFDNNLELFB LDLGBKKBHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	PCLEPELOEOH BBEFDNHJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OOPHKJJKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MJBKGCMNHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GHAEDLJMEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception IHIODGEPMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode BPCNBNALAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GPHOFIKEMIO.MLPKLCKEMKK EAAMBDJOKAK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<AHFDNNLELFB, AHFDNNLELFB> FKFAOAJHNIC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HNDDMIKBHKC(object MGPMAFDHMLC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HLAGECJFPFO(object BGJBEIJGGFK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JOIEKMOCIMD(byte PIAEBCPLIBI, int OAAKGEPPNGN, object IAAPABJLNAL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IPELBJBIFJI
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GPHOFIKEMIO.MLPKLCKEMKK EAAMBDJOKAK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JOIEKMOCIMD HKDKLDGBPEG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FIJHKFHLJKI(byte PIAEBCPLIBI, Hashtable AJFEAOELDAH, ENLDIOIDELJ EJAAFLFEGGC, SendOptions HGCPIIPPEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FHDKBEFMFDM
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GHBEGPNJJCK DMLKJKHJLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LADHCIAOIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int OHFOJNENAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MCFODFJCLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<GHBEGPNJJCK> FJJECOMGFJN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	GHBEGPNJJCK GECKLKHADGN(int HKJDGEGEECN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AGAJMHLEFKP
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action OOONPFFPPMN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIMOEKIEDEA();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HCMOGHGOBGB : NGFLNNOMKLP, DAILNJMEEOC, IPELBJBIFJI, FHDKBEFMFDM, AGAJMHLEFKP
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int LHECJNANPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int CMBOPEMLNND
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float MPDHGPDOBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float DFGHCAJPHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MMHDJJDHOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IFLLAPOFJKH NIBCEADENIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action DMINKIDOBMK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEHCNIPANOG();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEFFCHGIOIF();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BLJNGKDEEHN(string MAOMLHOPHAM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IFLLAPOFJKH
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PCCBEGJGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DIEPBIJCJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<HKCJHADADME> LCPBLGNIMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HFGFONEBKND(Action FFOJKIJLMCC, string IMHBJGIHMEL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MNCPAKHAFIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string PKJEGEIKDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 FGALHLKMLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion IKGAHCGJKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 DPCBCCMILLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int NOBJJKAHNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> GAAGDKNHNCI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70C2B90", Offset = "0x70C1F90", VA = "0x1870C2B90")]
	public object[] BIKDLGGJDJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MNCPAKHAFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EBPDIDCFGAE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70C2190", Offset = "0x70C1590", VA = "0x1870C2190")]
	public static bool NDCNPLELLAD(this NGFLNNOMKLP OPDDGHDADDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70C20C0", Offset = "0x70C14C0", VA = "0x1870C20C0")]
	public static bool CANHNOGOJNK(this NGFLNNOMKLP OPDDGHDADDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PNABDLNFCEP : HCMOGHGOBGB, NGFLNNOMKLP, DAILNJMEEOC, IPELBJBIFJI, FHDKBEFMFDM, AGAJMHLEFKP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class LNMOCBOBJMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PNABDLNFCEP FNGEHNFHDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool IOFECLNHDIM;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x70C2750", Offset = "0x70C1B50", VA = "0x1870C2750")]
		public LNMOCBOBJMN(PNABDLNFCEP FNGEHNFHDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x70C2650", Offset = "0x70C1A50", VA = "0x1870C2650", Slot = "1")]
		~LNMOCBOBJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x70C25C0", Offset = "0x70C19C0", VA = "0x1870C25C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x70C26F0", Offset = "0x70C1AF0", VA = "0x1870C26F0")]
		private void POBABOIPLGO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object JBCCLAHHAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object OJKIAPOHOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float FAHPMJMGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float IKOFOBMDMFP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool BNOOFGDKAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float IMIHHAKKBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int LHECJNANPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int CMBOPEMLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract GHBEGPNJJCK DMLKJKHJLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LADHCIAOIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x70C37C0", Offset = "0x70C2BC0", VA = "0x1870C37C0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int OHFOJNENAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int MCFODFJCLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FIJHLCJHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70C3970", Offset = "0x70C2D70", VA = "0x1870C3970", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float MPDHGPDOBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC1C800", Offset = "0xC1BC00", VA = "0x180C1C800", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70C36E0", Offset = "0x70C2AE0", VA = "0x1870C36E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float DFGHCAJPHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC1C7F0", Offset = "0xC1BBF0", VA = "0x180C1C7F0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x70C3A40", Offset = "0x70C2E40", VA = "0x1870C3A40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool MMHDJJDHOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract IFLLAPOFJKH NIBCEADENIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool IECJGGIBNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract COEKKCHLDDP BHIAMLBDELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool MJBKGCMNHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool AMNCMFACPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool EPJMIBDABKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool OOPHKJJKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract PDIOEHHDNBA BLJNKJODEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private MFGPGCPLCOD HNKNOPKLHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MFGPGCPLCOD KBEDCKKHGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private PMGDGCHNEPM<Func<float>> KLJBFGCAOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool NDIJKILIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1241280", Offset = "0x1240680", VA = "0x181241280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool JLHEFHGPFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x70C3770", Offset = "0x70C2B70", VA = "0x1870C3770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool AMOHLGBOPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x70C4440", Offset = "0x70C3840", VA = "0x1870C4440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event GPHOFIKEMIO.MLPKLCKEMKK EAAMBDJOKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70C3B10", Offset = "0x70C2F10", VA = "0x1870C3B10", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x70C4650", Offset = "0x70C3A50", VA = "0x1870C4650", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event JOIEKMOCIMD HKDKLDGBPEG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<GHBEGPNJJCK> FJJECOMGFJN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<COEKKCHLDDP, COEKKCHLDDP> JIHLFJCOPJE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> CAIBMMIBKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x70C3590", Offset = "0x70C2990", VA = "0x1870C3590", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x70C4190", Offset = "0x70C3590", VA = "0x1870C4190", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action DMINKIDOBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x70C3640", Offset = "0x70C2A40", VA = "0x1870C3640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x70C42F0", Offset = "0x70C36F0", VA = "0x1870C42F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action OOONPFFPPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x70C38D0", Offset = "0x70C2CD0", VA = "0x1870C38D0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70C3830", Offset = "0x70C2C30", VA = "0x1870C3830", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract GHBEGPNJJCK GECKLKHADGN(int HKJDGEGEECN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool LNGFKOMKOHO(AppSettings LLFCJPHNAHP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void JOPAEBIHEFK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool OIHLHAMAKNM();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void CNAHEIPADPE();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool FIJHKFHLJKI(byte PIAEBCPLIBI, Hashtable AJFEAOELDAH, ENLDIOIDELJ EJAAFLFEGGC, SendOptions HGCPIIPPEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool MKFEMNPFING(string LCGJGCMCLCG, JLDFPOGEHGB BOKCJBKLOMD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void BLJNGKDEEHN(string MAOMLHOPHAM);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void KMFJPCDBMNM(GPHOFIKEMIO LGKJMLLHKCN);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70C4BC0", Offset = "0x70C3FC0", VA = "0x1870C4BC0")]
	protected PNABDLNFCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70C4850", Offset = "0x70C3C50", VA = "0x1870C4850")]
	public void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x70C4480", Offset = "0x70C3880", VA = "0x1870C4480", Slot = "35")]
	public void MCLKPIEMGPG(object CMNJCPJBHGE, bool DGOLCPKLMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x70C46C0", Offset = "0x70C3AC0", VA = "0x1870C46C0", Slot = "33")]
	public void NNHNGOEJCFO(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x70C3A00", Offset = "0x70C2E00", VA = "0x1870C3A00", Slot = "34")]
	public void HAMBFDIKABP(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x70C3A80", Offset = "0x70C2E80", VA = "0x1870C3A80", Slot = "36")]
	public IDisposable HLAHIEGBJBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x70C3F10", Offset = "0x70C3310", VA = "0x1870C3F10", Slot = "91")]
	public virtual bool IJDACAIOMIE(bool MHPKBGBNFGL, [Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x70C4A20", Offset = "0x70C3E20", VA = "0x1870C4A20")]
	private bool PPFCCJDDMKP([Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x70C47C0", Offset = "0x70C3BC0", VA = "0x1870C47C0")]
	private bool NOPHLBHHEDK([Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x70C4600", Offset = "0x70C3A00", VA = "0x1870C4600", Slot = "37")]
	public bool NFAPAPPDLBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70C3C10", Offset = "0x70C3010", VA = "0x1870C3C10", Slot = "38")]
	public void IFOIDFOOADP(StringBuilder DIOODJKKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x70C4870", Offset = "0x70C3C70", VA = "0x1870C4870")]
	private void PMEAPMMKLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x70C3E80", Offset = "0x70C3280", VA = "0x1870C3E80")]
	private void IGAHDIJDMDN(Func<float> PJDLGHLEMCB, object CMNJCPJBHGE, int HPFPPNDKBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x70C4130", Offset = "0x70C3530", VA = "0x1870C4130", Slot = "92")]
	public void IJEFMJJGLHA(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x70C3B80", Offset = "0x70C2F80", VA = "0x1870C3B80", Slot = "8")]
	public void IEHCNIPANOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70C45A0", Offset = "0x70C39A0", VA = "0x1870C45A0", Slot = "9")]
	public void MEFFCHGIOIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70C4390", Offset = "0x70C3790", VA = "0x1870C4390")]
	private void KDGGCINMNCC(float NIFKBJPBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xC1C7F0", Offset = "0xC1BBF0", VA = "0x180C1C7F0")]
	private float NAHNKCKEEGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xC1C800", Offset = "0xC1BC00", VA = "0x180C1C800")]
	private float NJDOMDCPOLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x70C4240", Offset = "0x70C3640", VA = "0x1870C4240")]
	private void IPNPKNEECFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x70C3720", Offset = "0x70C2B20", VA = "0x1870C3720", Slot = "55")]
	public void CIMOEKIEDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class LKPJLIPAJFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string OAJAONIPLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool IPFDBILOKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool CNPFHBGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int LBMENALOACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] FGOLIJHLNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte FCBELHJDOAP;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random DKKNBEFLGLM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x70C2370", Offset = "0x70C1770", VA = "0x1870C2370", Slot = "5")]
	public virtual bool FNOKMLMPIMI(string CCNDDMAADOI, int KFFGLKDIHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x70C23C0", Offset = "0x70C17C0", VA = "0x1870C23C0", Slot = "6")]
	public virtual bool GJDCFDNIBNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x70C2320", Offset = "0x70C1720", VA = "0x1870C2320", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x70C2410", Offset = "0x70C1810", VA = "0x1870C2410")]
	protected internal void LKOIGPCFEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x70C2510", Offset = "0x70C1910", VA = "0x1870C2510")]
	protected LKPJLIPAJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AKABPDHGJHA : LKPJLIPAJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket JEMCFLPCIFO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70C1B50", Offset = "0x70C0F50", VA = "0x1870C1B50", Slot = "5")]
	public override bool FNOKMLMPIMI(string CCNDDMAADOI, int KFFGLKDIHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70C1DF0", Offset = "0x70C11F0", VA = "0x1870C1DF0", Slot = "6")]
	public override bool GJDCFDNIBNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65A6600", Offset = "0x65A5A00", VA = "0x1865A6600", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70C1FE0", Offset = "0x70C13E0", VA = "0x1870C1FE0")]
	public AKABPDHGJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MDCIHLDCLND
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string HDJNINPDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string PLCPHCNMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string GDNDNDDBNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LMMJMPLEPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C50", Offset = "0x8C8050", VA = "0x1808C8C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C93B0", Offset = "0x8C87B0", VA = "0x1808C93B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x70C2A70", Offset = "0x70C1E70", VA = "0x1870C2A70")]
	public MDCIHLDCLND(string CFOOJJGCIPD, string FIKHCKAHJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x70C27B0", Offset = "0x70C1BB0", VA = "0x1870C27B0")]
	private void ADGAEHHGIBN(string DNMOBGLHGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x70C29B0", Offset = "0x70C1DB0", VA = "0x1870C29B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x70C28C0", Offset = "0x70C1CC0", VA = "0x1870C28C0")]
	public string KPOMOCPCFCD(bool FEFLCJILHHB = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NEDCKHEOLDH
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int GEIJJHDHNPN;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool GPAGCCIHOOA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int DAKHJEOGIEK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int JFGIIFJIKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MDCIHLDCLND OLECAHIGEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string PJPPFNPKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int CBAGNNFFKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int CEEAPPPHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<MDCIHLDCLND> FBCLMLEACED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LKPJLIPAJFH COEIOJIONLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> HHNPDGFIGJH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GJDCFDNIBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA02880", Offset = "0xA01C80", VA = "0x180A02880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA02750", Offset = "0xA01B50", VA = "0x180A02750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x70C34E0", Offset = "0x70C28E0", VA = "0x1870C34E0")]
	public NEDCKHEOLDH(MDCIHLDCLND OLECAHIGEIK, Action<MDCIHLDCLND> MFFFJMNOLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x70C3100", Offset = "0x70C2500", VA = "0x1870C3100")]
	public bool INEAJMHODFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x70C2CA0", Offset = "0x70C20A0", VA = "0x1870C2CA0")]
	public static string BMJHPDHEBEN(string PBJNEAPNOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x70C30F0", Offset = "0x70C24F0", VA = "0x1870C30F0")]
	protected internal void HGIPJIJGEJB(object NOIHGGNEIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x70C2E20", Offset = "0x70C2220", VA = "0x1870C2E20")]
	protected internal bool DBNBCINPLMH()
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
