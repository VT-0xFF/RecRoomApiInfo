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
public interface JKHEKLEPELB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> KMADFAEFNDC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIICGLPILMF(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIJGJIJKHCK(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HENDBJHNHCA(object HEJFDMJNIGB, bool CIHAFFHCONE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable MJJKLDMILCD();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LDHBKEBPHBB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGJGNIDPICD(StringBuilder BCMHGPKCLBF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MMMMACLLHHP(bool HIIEDCJKLKM, [Out] string DFEFGBECJNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KDNJKCIEDPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CAAFBJIAKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HLECGPEMNHL EAHGCGNMEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool INLNNKELBAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BKNMLJLGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CGMOLDPJJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LFEDAMHMEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LKBNJKEELAP NLPKMMFFHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CEKOBMPOEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HLECGPEMNHL, HLECGPEMNHL> BJFKPIKODHB;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KBLCEKMJCGO(MAIANHJHJIN ECFGOPEGNEO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GMHAFOLEIIA();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EPMEIJBBLDJ(string EJHIHMBPNLK, MAMDIGNPLLC HDKODEHBIGM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MCDOIJBEAJC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool POGMHDKJDKH(AppSettings FFAONGPAKBF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HLECGPEMNHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MCBNKEFICEG OCIJIOOAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	CGNKDMABJPH DEEJHDKJPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LFEDAMHMEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool INLNNKELBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KDLMKIEJKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception HFFOCEAILCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode AEOODHJHAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MAIANHJHJIN.LCDNNJPLNIB KILMMNBHLHP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<MCBNKEFICEG, MCBNKEFICEG> OIDCIEBIKJI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PHOMDJGIOPL(object JMBMDICGCNK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMPDKNPIAFE(object DAKAIIDCHBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HCJIKDBFMJB(byte MKLGKNFOABE, int LEKKPMMKFMI, object JNDPCNNCNMB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KEPLMPBBEJG
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MAIANHJHJIN.LCDNNJPLNIB KILMMNBHLHP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HCJIKDBFMJB LMGGKNPJBOI;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GNKJGNKHLAP(byte MKLGKNFOABE, object OEEFLECLMKF, JIJKACACFPP DBADGOIDFPK, SendOptions DOLDBLADPOL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FMNHDKPLIDD
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FEIKLGLBIHI FHNCGKJHDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LLAJKJBBKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int LLCPEGDKKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool GJFIDCOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int FBCKEBCLNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<FEIKLGLBIHI> NPBMHCLOOPL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	FEIKLGLBIHI ONCADMNALOJ(int OJKFBILBJGP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DHNKAEFGHHC
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action NCILNKJKIJO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHCNPDLEJOG();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OAHJJJNDMGJ : KDNJKCIEDPB, JKHEKLEPELB, KEPLMPBBEJG, FMNHDKPLIDD, DHNKAEFGHHC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int ICGGGJMKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NHBMNEDLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int JJCOPEFBFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LIBPBNMIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float KJPCGFHIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JEHCIGFPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FCFPJDOMMMN KELLLGMHOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action FBLLOJEBOHO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLHOKKDLKPP();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLJCAPHKMPJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HIINLMMADKF(List<object> JMHKEMEJOPH, int FOGJBEMBBDP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDDACFNLOKA(int NBJEDOIFFEH, object JNDPCNNCNMB);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FLONEMCKPNO(Hashtable JAIBFAIMPCH, int EJFMLPKGCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BFGFEJKLHFJ();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPFAFMNIBNN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FBJMDKOMOJD(string PGFNDMHAKPA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FCFPJDOMMMN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BLNBALAFGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MCGFOAMIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<BKBGILGDDEB> GAOAKOFDIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IFOELFBBFIE(Action OCKCJLFJOGC, string ENOINLJBBCO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MPAALDFCOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string HDABNGAACCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 CPGAKMJDLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion DBFFJKGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 OIHEBFGIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int HABEPCBBEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public GPMAMEJIKCA LIKPCAHKFFO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x78FB900", Offset = "0x78FAD00", VA = "0x1878FB900")]
	public object[] LDHNMBIJJGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MPAALDFCOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DINBEDKDACI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x78F9080", Offset = "0x78F8480", VA = "0x1878F9080")]
	public static bool CDAEBMALCJE(this KDNJKCIEDPB FGPPCBNLGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78F9120", Offset = "0x78F8520", VA = "0x1878F9120")]
	public static bool JHLHKCIAMOC(this KDNJKCIEDPB FGPPCBNLGHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class DNCKEODIAGD : OAHJJJNDMGJ, KDNJKCIEDPB, JKHEKLEPELB, KEPLMPBBEJG, FMNHDKPLIDD, DHNKAEFGHHC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class BGNMFPOAEDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DNCKEODIAGD AKKFAAHOHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MIGDMPFDAHI;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x78F9020", Offset = "0x78F8420", VA = "0x1878F9020")]
		public BGNMFPOAEDH(DNCKEODIAGD AKKFAAHOHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x78F8F80", Offset = "0x78F8380", VA = "0x1878F8F80", Slot = "1")]
		~BGNMFPOAEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x78F8E90", Offset = "0x78F8290", VA = "0x1878F8E90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x78F8F20", Offset = "0x78F8320", VA = "0x1878F8F20")]
		private void EFENFPIIDGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object ENAECGLNFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object AGJOBPHAEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float PGKIKNJMNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float FACDMHEIEHB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool CEKOBMPOEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float BONOEIPPMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int ICGGGJMKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int NHBMNEDLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract FEIKLGLBIHI FHNCGKJHDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int LLAJKJBBKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78F9CF0", Offset = "0x78F90F0", VA = "0x1878F9CF0", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int LLCPEGDKKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int FBCKEBCLNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GJFIDCOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x78F96B0", Offset = "0x78F8AB0", VA = "0x1878F96B0", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int JJCOPEFBFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float LIBPBNMIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE35BB0", Offset = "0xE34FB0", VA = "0x180E35BB0", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78F9CB0", Offset = "0x78F90B0", VA = "0x1878F9CB0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float KJPCGFHIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xF63150", Offset = "0xF62550", VA = "0x180F63150", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78F9AE0", Offset = "0x78F8EE0", VA = "0x1878F9AE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool JEHCIGFPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract FCFPJDOMMMN KELLLGMHOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool CAAFBJIAKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract HLECGPEMNHL EAHGCGNMEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool INLNNKELBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool BKNMLJLGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool CGMOLDPJJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool LFEDAMHMEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract LKBNJKEELAP NLPKMMFFHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private OFGINBALPIL IGFBPBEHAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private OFGINBALPIL HLLCHHKPKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private APCFHKHDALJ<Func<float>> AIOPGJHKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool IPDHPEBBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x15CCBC0", Offset = "0x15CBFC0", VA = "0x1815CCBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool IKHCLCMIFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x78F9D60", Offset = "0x78F9160", VA = "0x1878F9D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool DNECCPKJOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78FA750", Offset = "0x78F9B50", VA = "0x1878FA750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event MAIANHJHJIN.LCDNNJPLNIB KILMMNBHLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x78F9960", Offset = "0x78F8D60", VA = "0x1878F9960", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x78F9A70", Offset = "0x78F8E70", VA = "0x1878F9A70", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event HCJIKDBFMJB LMGGKNPJBOI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<FEIKLGLBIHI> NPBMHCLOOPL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<HLECGPEMNHL, HLECGPEMNHL> BJFKPIKODHB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> KMADFAEFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x78F9BB0", Offset = "0x78F8FB0", VA = "0x1878F9BB0", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x78F9EE0", Offset = "0x78F92E0", VA = "0x1878F9EE0", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action FBLLOJEBOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x78FA790", Offset = "0x78F9B90", VA = "0x1878FA790", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78F99D0", Offset = "0x78F8DD0", VA = "0x1878F99D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action NCILNKJKIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x78F9F90", Offset = "0x78F9390", VA = "0x1878F9F90", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x78F9330", Offset = "0x78F8730", VA = "0x1878F9330", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract FEIKLGLBIHI ONCADMNALOJ(int OJKFBILBJGP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool POGMHDKJDKH(AppSettings FFAONGPAKBF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void MCDOIJBEAJC();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool GMHAFOLEIIA();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void GLHOKKDLKPP();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void JLJCAPHKMPJ();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void HIINLMMADKF(List<object> JMHKEMEJOPH, int FOGJBEMBBDP);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void BDDACFNLOKA(int NBJEDOIFFEH, object JNDPCNNCNMB);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void FLONEMCKPNO(Hashtable JAIBFAIMPCH, int EJFMLPKGCPJ);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool GNKJGNKHLAP(byte MKLGKNFOABE, object OEEFLECLMKF, JIJKACACFPP DBADGOIDFPK, SendOptions DOLDBLADPOL);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool EPMEIJBBLDJ(string EJHIHMBPNLK, MAMDIGNPLLC HDKODEHBIGM);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void FBJMDKOMOJD(string PGFNDMHAKPA);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void KBLCEKMJCGO(MAIANHJHJIN ECFGOPEGNEO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x78FA830", Offset = "0x78F9C30", VA = "0x1878FA830")]
	protected DNCKEODIAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x78F9EC0", Offset = "0x78F92C0", VA = "0x1878F9EC0")]
	public void MBHBIOMKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x78F9840", Offset = "0x78F8C40", VA = "0x1878F9840", Slot = "41")]
	public void HENDBJHNHCA(object HEJFDMJNIGB, bool CIHAFFHCONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x78F9740", Offset = "0x78F8B40", VA = "0x1878F9740", Slot = "39")]
	public void GIICGLPILMF(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x78FA710", Offset = "0x78F9B10", VA = "0x1878FA710", Slot = "40")]
	public void OIJGJIJKHCK(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x78FA030", Offset = "0x78F9430", VA = "0x1878FA030", Slot = "42")]
	public IDisposable MJJKLDMILCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x78FA0C0", Offset = "0x78F94C0", VA = "0x1878FA0C0", Slot = "102")]
	public virtual bool MMMMACLLHHP(bool HIIEDCJKLKM, [Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x78F93D0", Offset = "0x78F87D0", VA = "0x1878F93D0")]
	private bool CPJFFCNMFGD([Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x78F9570", Offset = "0x78F8970", VA = "0x1878F9570")]
	private bool DLKKJAIBDBD([Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x78F9C60", Offset = "0x78F9060", VA = "0x1878F9C60", Slot = "43")]
	public bool LDHBKEBPHBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x78FA490", Offset = "0x78F9890", VA = "0x1878FA490", Slot = "44")]
	public void OGJGNIDPICD(StringBuilder BCMHGPKCLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x78FA2E0", Offset = "0x78F96E0", VA = "0x1878FA2E0")]
	private void OAKOBDNDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x78F9B20", Offset = "0x78F8F20", VA = "0x1878F9B20")]
	private void IBAMMCGAFEC(Func<float> CEDAGGCHHKJ, object HEJFDMJNIGB, int CCLELJLNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x78F92D0", Offset = "0x78F86D0", VA = "0x1878F92D0", Slot = "103")]
	public void BPKMFKADHCN(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x78F91F0", Offset = "0x78F85F0", VA = "0x1878F91F0", Slot = "14")]
	public void BFGFEJKLHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x78F9E60", Offset = "0x78F9260", VA = "0x1878F9E60", Slot = "15")]
	public void LPFAFMNIBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x78F9600", Offset = "0x78F8A00", VA = "0x1878F9600")]
	private void FCKKLDMAJPJ(float DHENFBPIIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xF63150", Offset = "0xF62550", VA = "0x180F63150")]
	private float FPFMODAFFBJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xE35BB0", Offset = "0xE34FB0", VA = "0x180E35BB0")]
	private float BDFNJLFKFBP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x78F9DB0", Offset = "0x78F91B0", VA = "0x1878F9DB0")]
	private void LMJGPNEACBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x78F9280", Offset = "0x78F8680", VA = "0x1878F9280", Slot = "61")]
	public void BHCNPDLEJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class OMCNAGLOAMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string FJNAFHPHGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool AHDNPJGKKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool DIEHIANOMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int CFMMKDCLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] FIAJIDHAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte AFLBOCAHOLE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random EGKECGBNFOF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x78FBF40", Offset = "0x78FB340", VA = "0x1878FBF40", Slot = "5")]
	public virtual bool NCIJICENENH(string BBMFHHPODEA, int MDPDGBLOFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x78FBEF0", Offset = "0x78FB2F0", VA = "0x1878FBEF0", Slot = "6")]
	public virtual bool LMOFNDFLHGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x78FBEA0", Offset = "0x78FB2A0", VA = "0x1878FBEA0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x78FBE20", Offset = "0x78FB220", VA = "0x1878FBE20")]
	protected internal void AEJOPFDILPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x78FC010", Offset = "0x78FB410", VA = "0x1878FC010")]
	protected OMCNAGLOAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JBMKOLCMAHF : OMCNAGLOAMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket DIPJKFFJPJB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x78FB580", Offset = "0x78FA980", VA = "0x1878FB580", Slot = "5")]
	public override bool NCIJICENENH(string BBMFHHPODEA, int MDPDGBLOFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x78FB390", Offset = "0x78FA790", VA = "0x1878FB390", Slot = "6")]
	public override bool LMOFNDFLHGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6980", Offset = "0x6CF5D80", VA = "0x186CF6980", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x78FB820", Offset = "0x78FAC20", VA = "0x1878FB820")]
	public JBMKOLCMAHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKBLIILCMEE
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string AJHCHHGOILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string PLIMCDBJGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string BJFPGIIBIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BIABHGLHAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x992560", Offset = "0x991960", VA = "0x180992560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x991DD0", Offset = "0x9911D0", VA = "0x180991DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x78FBD00", Offset = "0x78FB100", VA = "0x1878FBD00")]
	public NKBLIILCMEE(string JMDODKHGNOP, string ENIHAJKAFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x78FBB30", Offset = "0x78FAF30", VA = "0x1878FBB30")]
	private void GJJOGCNFLDN(string FMAOMBFLIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x78FBC40", Offset = "0x78FB040", VA = "0x1878FBC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x78FBA40", Offset = "0x78FAE40", VA = "0x1878FBA40")]
	public string FLAILMPNDND(bool AEJOGMOEHII = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FNKKJICKCBO
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int MDKOLINPNEN;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool GHOKGKCGHCH;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int JOCDBMMFJBI;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int BKNLLLOMFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NKBLIILCMEE COHDEOIJAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string HOALDFGAOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int HPENIPHFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int BFEKMJFAMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<NKBLIILCMEE> HCPGNMDMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OMCNAGLOAMN ICIEILDOONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> DJEHGGDDKCA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool LMOFNDFLHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD13190", Offset = "0xD12590", VA = "0x180D13190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9FD930", Offset = "0x9FCD30", VA = "0x1809FD930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x78FB1F0", Offset = "0x78FA5F0", VA = "0x1878FB1F0")]
	public FNKKJICKCBO(NKBLIILCMEE COHDEOIJAPC, Action<NKBLIILCMEE> OJCOHBIBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x78FAE10", Offset = "0x78FA210", VA = "0x1878FAE10")]
	public bool OJDEIJAKKMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x78FAC90", Offset = "0x78FA090", VA = "0x1878FAC90")]
	public static string ODCEALIINAH(string NIDDOAJAKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x78FAC80", Offset = "0x78FA080", VA = "0x1878FAC80")]
	protected internal void HGBLBJHLGNO(object PFPNPMCGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x78FA9B0", Offset = "0x78F9DB0", VA = "0x1878FA9B0")]
	protected internal bool DICNBHJHIOO()
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
