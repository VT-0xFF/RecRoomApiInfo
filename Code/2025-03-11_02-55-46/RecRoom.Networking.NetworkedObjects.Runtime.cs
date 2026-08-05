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
public interface JFPFNIIKLHH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> GBCJBPEGKBL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIIKJNIPCNI(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPJOMMBCHOG(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HECMPBBIEPD(object OCDOGNMJENC, bool NDIDHEFBMLH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable EBOIDAHIEHL();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NBEPLFGIKKO();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AONEDAJENDB(StringBuilder DLLCCCGNFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MIJMOEJOMGB(bool CLBKPMJPKNL, [Out] string JPAKKPAOGDF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PMNBALJNCLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JGAELCECHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LFEACEIIGIP LPNMIDBBHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OFPKJLBOFED
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IPACANPILBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OOJJIOPGOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PMODLBBPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OLHJAOFJCBE KHHKPDFEFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MMMBDCCEBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LFEACEIIGIP, LFEACEIIGIP> BABEIEPFPPL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKOFEDKFCLM(MLGDFMMLEEK FDMNIIJFCMI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HOHBOBJDFCI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IDKHBINNKDP(string IIGPIBCBPBN, HALEDFDONHC EDFAOOAOPPP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HMKDLEAGODN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DANMKALNJML(AppSettings LFAFCDKECKC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LFEACEIIGIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CMNLLCOHDAE DCNLODMJAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	DIFNPEGAKCP NKGHABGLODF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PMODLBBPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OFPKJLBOFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HHIGLBFGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception ONEFFMIMECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode HHGGEKCICFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MLGDFMMLEEK.NBAMDIBPKGG FLADBGFPBAG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CMNLLCOHDAE, CMNLLCOHDAE> BBCMIDEBEAK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KEHKGFJMMDB(object GACPILKGIFM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIJPEHNEDPA(object JFGKJHHIOGO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OGMCAIHMFDP(byte FPINDDDPMFJ, int DODLNPKMBHK, object CDDCIHICHEA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EAFJFGJJKEN
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MLGDFMMLEEK.NBAMDIBPKGG FLADBGFPBAG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OGMCAIHMFDP OMHDLPLIHOH;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLLDMBBNDDJ(byte FPINDDDPMFJ, object NPIOCJAOMHB, EIJLNMDGOPA MLCJBGOJGOH, SendOptions GMONLKDMFDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MBMJLKCABGK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NOFCMGEHFOO MMFHALPOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int CJJBPDBCBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int KJHCOHFGINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EJIKBACHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int NMFLDDHDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<NOFCMGEHFOO> HBOHENDGLFP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	NOFCMGEHFOO GBLKFOCIKND(int CFMOAKJJMGO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BJIJFEABGPL
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action DIIAPBINIMP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBGPKJLDCII();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HHMOMAGJIPE : PMNBALJNCLP, JFPFNIIKLHH, EAFJFGJJKEN, MBMJLKCABGK, BJIJFEABGPL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int GODCBOLFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int CKPALCIGMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int IJGINMEOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float IHMPAANILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float DGJNKHFMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IOKNEFLFIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PLGCBPNKBGN ADIFGFEMDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action OELEPHLANOE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOEAHLLAAJG();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJNNIJAMBLO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PACJJJPLHBP(List<object> DBJKHFJBKPC, int PFCFNJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JECBKLONMCJ(int PBBBOCDLDBJ, object CDDCIHICHEA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMLCGDLJMJC(Hashtable HLDJDBBCDFE, int FDLLGPFCFLD);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DBGEOIBOJMK();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFDPHDFGLDF();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BEGBCAOKJHG(string CCGGAFIIKBG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PLGCBPNKBGN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FMAGMOOAPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IPDEPOCOBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<FKPGEAGOMPH> JMLONLAHLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NPCJJANPKFP(Action LCFPOHOOOCD, string AHLGFBMDJGL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NBFMPKGMPHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string PFOFAKHJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 LLLAMAJMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion ANFMFACGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 OJKGCKCDMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int FMJIPJJHLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public ANCOAIADDGI GKPANAMHEDK;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76CD230", Offset = "0x76CC630", VA = "0x1876CD230")]
	public object[] IMEINKMLAEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NBFMPKGMPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BOJEAAHFBKC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76CAF00", Offset = "0x76CA300", VA = "0x1876CAF00")]
	public static bool NJNNCCKCKKP(this PMNBALJNCLP DHCKIJNDDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76CAE30", Offset = "0x76CA230", VA = "0x1876CAE30")]
	public static bool DIJHHECGKMD(this PMNBALJNCLP DHCKIJNDDCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FKOBMBNJCJA : HHMOMAGJIPE, PMNBALJNCLP, JFPFNIIKLHH, EAFJFGJJKEN, MBMJLKCABGK, BJIJFEABGPL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class LIJHMPEOBBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FKOBMBNJCJA ECMHCEGPJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MPODDHPAEGG;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x76CD1D0", Offset = "0x76CC5D0", VA = "0x1876CD1D0")]
		public LIJHMPEOBBE(FKOBMBNJCJA ECMHCEGPJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x76CD0D0", Offset = "0x76CC4D0", VA = "0x1876CD0D0", Slot = "1")]
		~LIJHMPEOBBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x76CD040", Offset = "0x76CC440", VA = "0x1876CD040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x76CD170", Offset = "0x76CC570", VA = "0x1876CD170")]
		private void NPAMLHJHPLL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object LONPKGEDILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object AMFCMONLDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float BFIKHIJKOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float BKCAACDDJCM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool MMMBDCCEBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float JJKJBADACGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int GODCBOLFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int CKPALCIGMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract NOFCMGEHFOO MMFHALPOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CJJBPDBCBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76CC310", Offset = "0x76CB710", VA = "0x1876CC310", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int KJHCOHFGINN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int NMFLDDHDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool EJIKBACHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x76CBB60", Offset = "0x76CAF60", VA = "0x1876CBB60", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int IJGINMEOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float IHMPAANILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xEFF3E0", Offset = "0xEFE7E0", VA = "0x180EFF3E0", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76CC060", Offset = "0x76CB460", VA = "0x1876CC060", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float DGJNKHFMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xEFF3D0", Offset = "0xEFE7D0", VA = "0x180EFF3D0", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x76CB7A0", Offset = "0x76CABA0", VA = "0x1876CB7A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool IOKNEFLFIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract PLGCBPNKBGN ADIFGFEMDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool JGAELCECHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract LFEACEIIGIP LPNMIDBBHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool OFPKJLBOFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool IPACANPILBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool OOJJIOPGOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool PMODLBBPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract OLHJAOFJCBE KHHKPDFEFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private MBJBJPKHIHP LBCEOOIMBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private MBJBJPKHIHP PLNAGIKECFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private ILMOGPFFNGM<Func<float>> MLBOCGINIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool KLGCIAFHHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1550740", Offset = "0x154FB40", VA = "0x181550740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool BNALEFBALOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76CC010", Offset = "0x76CB410", VA = "0x1876CC010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool OOCIFEPCKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x76CB8D0", Offset = "0x76CACD0", VA = "0x1876CB8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event MLGDFMMLEEK.NBAMDIBPKGG FLADBGFPBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x76CB6A0", Offset = "0x76CAAA0", VA = "0x1876CB6A0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x76CB270", Offset = "0x76CA670", VA = "0x1876CB270", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event OGMCAIHMFDP OMHDLPLIHOH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<NOFCMGEHFOO> HBOHENDGLFP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<LFEACEIIGIP, LFEACEIIGIP> BABEIEPFPPL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> GBCJBPEGKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x76CB510", Offset = "0x76CA910", VA = "0x1876CB510", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76CB910", Offset = "0x76CAD10", VA = "0x1876CB910", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action OELEPHLANOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76CBDC0", Offset = "0x76CB1C0", VA = "0x1876CBDC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76CB2E0", Offset = "0x76CA6E0", VA = "0x1876CB2E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action DIIAPBINIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x76CC3A0", Offset = "0x76CB7A0", VA = "0x1876CC3A0", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x76CB380", Offset = "0x76CA780", VA = "0x1876CB380", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract NOFCMGEHFOO GBLKFOCIKND(int CFMOAKJJMGO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool DANMKALNJML(AppSettings LFAFCDKECKC);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void HMKDLEAGODN();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool HOHBOBJDFCI();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void LOEAHLLAAJG();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void FJNNIJAMBLO();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void PACJJJPLHBP(List<object> DBJKHFJBKPC, int PFCFNJKDJBK);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void JECBKLONMCJ(int PBBBOCDLDBJ, object CDDCIHICHEA);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void MMLCGDLJMJC(Hashtable HLDJDBBCDFE, int FDLLGPFCFLD);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool MLLDMBBNDDJ(byte FPINDDDPMFJ, object NPIOCJAOMHB, EIJLNMDGOPA MLCJBGOJGOH, SendOptions GMONLKDMFDJ);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool IDKHBINNKDP(string IIGPIBCBPBN, HALEDFDONHC EDFAOOAOPPP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void BEGBCAOKJHG(string CCGGAFIIKBG);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void FKOFEDKFCLM(MLGDFMMLEEK FDMNIIJFCMI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76CC5D0", Offset = "0x76CB9D0", VA = "0x1876CC5D0")]
	protected FKOBMBNJCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76CC380", Offset = "0x76CB780", VA = "0x1876CC380")]
	public void OBBALIPJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76CBCA0", Offset = "0x76CB0A0", VA = "0x1876CBCA0", Slot = "41")]
	public void HECMPBBIEPD(object OCDOGNMJENC, bool NDIDHEFBMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76CC440", Offset = "0x76CB840", VA = "0x1876CC440", Slot = "39")]
	public void OIIKJNIPCNI(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76CB7E0", Offset = "0x76CABE0", VA = "0x1876CB7E0", Slot = "40")]
	public void FPJOMMBCHOG(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76CB610", Offset = "0x76CAA10", VA = "0x1876CB610", Slot = "42")]
	public IDisposable EBOIDAHIEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76CC0A0", Offset = "0x76CB4A0", VA = "0x1876CC0A0", Slot = "102")]
	public virtual bool MIJMOEJOMGB(bool CLBKPMJPKNL, [Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76CB9C0", Offset = "0x76CADC0", VA = "0x1876CB9C0")]
	private bool GODCPEIPBFD([Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76CC540", Offset = "0x76CB940", VA = "0x1876CC540")]
	private bool PJFGELLPFEH([Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x76CC2C0", Offset = "0x76CB6C0", VA = "0x1876CC2C0", Slot = "43")]
	public bool NBEPLFGIKKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76CAFA0", Offset = "0x76CA3A0", VA = "0x1876CAFA0", Slot = "44")]
	public void AONEDAJENDB(StringBuilder DLLCCCGNFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x76CBE60", Offset = "0x76CB260", VA = "0x1876CBE60")]
	private void IJFFJODKDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76CB710", Offset = "0x76CAB10", VA = "0x1876CB710")]
	private void FGKFEOHBBEK(Func<float> PFBPFGAFHMI, object OCDOGNMJENC, int LDKOMOHFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x76CB420", Offset = "0x76CA820", VA = "0x1876CB420", Slot = "103")]
	public void CKHCIHJEFAN(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76CB480", Offset = "0x76CA880", VA = "0x1876CB480", Slot = "14")]
	public void DBGEOIBOJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76CB210", Offset = "0x76CA610", VA = "0x1876CB210", Slot = "15")]
	public void BFDPHDFGLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x76CBBF0", Offset = "0x76CAFF0", VA = "0x1876CBBF0")]
	private void HDAAIMKBONJ(float OFCJJHCKIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xEFF3D0", Offset = "0xEFE7D0", VA = "0x180EFF3D0")]
	private float IJGNAPGHOFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xEFF3E0", Offset = "0xEFE7E0", VA = "0x180EFF3E0")]
	private float NAAKLIGHALF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76CB820", Offset = "0x76CAC20", VA = "0x1876CB820")]
	private void GILMCBPAMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76CB5C0", Offset = "0x76CA9C0", VA = "0x1876CB5C0", Slot = "61")]
	public void EBGPKJLDCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class NLJLKEGHKBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string HGFAGBLNCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool CGGPFJAEJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool JJBHGGEOHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int DNHIENMHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] FELPOFFKIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte CPBNCJHLEMG;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random LEBIGIPMNFC;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76CD3E0", Offset = "0x76CC7E0", VA = "0x1876CD3E0", Slot = "5")]
	public virtual bool FGAEDHEJHAG(string FFENMDJFKKE, int NFLKFIGLIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76CD340", Offset = "0x76CC740", VA = "0x1876CD340", Slot = "6")]
	public virtual bool AHEHCDIPDPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76CD390", Offset = "0x76CC790", VA = "0x1876CD390", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76CD430", Offset = "0x76CC830", VA = "0x1876CD430")]
	protected internal void MEKFCHHLHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76CD530", Offset = "0x76CC930", VA = "0x1876CD530")]
	protected NLJLKEGHKBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OAPCPAMIKBC : NLJLKEGHKBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket HOGJGPGHKII;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76CD7D0", Offset = "0x76CCBD0", VA = "0x1876CD7D0", Slot = "5")]
	public override bool FGAEDHEJHAG(string FFENMDJFKKE, int NFLKFIGLIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76CD5E0", Offset = "0x76CC9E0", VA = "0x1876CD5E0", Slot = "6")]
	public override bool AHEHCDIPDPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EF80", Offset = "0x6B0E380", VA = "0x186B0EF80", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76CDA70", Offset = "0x76CCE70", VA = "0x1876CDA70")]
	public OAPCPAMIKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BBHJMFCOOCN
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string HKFLKNBGMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string IADCDMIOCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string BLIHBBMDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int DIKKIBHJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x968340", Offset = "0x967740", VA = "0x180968340")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x968370", Offset = "0x967770", VA = "0x180968370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76CAD10", Offset = "0x76CA110", VA = "0x1876CAD10")]
	public BBHJMFCOOCN(string LNEEKMIFMOP, string LABPDJANKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76CAA50", Offset = "0x76C9E50", VA = "0x1876CAA50")]
	private void BPLIFHOLLLN(string BMAFKDJEKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76CAC50", Offset = "0x76CA050", VA = "0x1876CAC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76CAB60", Offset = "0x76C9F60", VA = "0x1876CAB60")]
	public string IBFKOLEEOAK(bool ALALJMMNGED = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDPOPCLCNDK
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int KPCPFNNLIPA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool FAKALACPDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int EAFOOCCFPNH;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int FCLACLANOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BBHJMFCOOCN FLILIIAHBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string PECKABIBLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int KOOLMBKMIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int CMCIGFHHGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<BBHJMFCOOCN> PLJPFMDPKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NLJLKEGHKBG MJMMONCDADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> HOMOBFDFFLE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AHEHCDIPDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCEB250", Offset = "0xCEA650", VA = "0x180CEB250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x76CCF90", Offset = "0x76CC390", VA = "0x1876CCF90")]
	public HDPOPCLCNDK(BBHJMFCOOCN FLILIIAHBJO, Action<BBHJMFCOOCN> LLPHOPECPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x76CCA30", Offset = "0x76CBE30", VA = "0x1876CCA30")]
	public bool EDANEBCOOOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76CCDA0", Offset = "0x76CC1A0", VA = "0x1876CCDA0")]
	public static string INLLGELIFDI(string NFJELANMGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76CCA20", Offset = "0x76CBE20", VA = "0x1876CCA20")]
	protected internal void COEFKKEOGLO(object MEBLJIBNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76CC750", Offset = "0x76CBB50", VA = "0x1876CC750")]
	protected internal bool ACBHAEGEIKH()
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
