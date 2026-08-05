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
public interface FKANHHPELCA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> KFCHMCNIACF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGIEFGIHFPA(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKLJOGOMAGG(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKNMHPKJFEA(object GNAAILLDOKI, bool CDHBPJNHGDD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable LBJDCELLCAC();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PICOCJACFFO();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OCILEDDAMIF(StringBuilder PNLFMPPBIIJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EHBMJKNOPOP(bool MDJJGNLKMPD, [Out] string LPNLOGECJBM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LNMBDGHHODP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BHACNGLEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	JIOAEMAHFJJ ILHOCPAIJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PIEEBMPILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PJCCLFCIFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ADDFINPCOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NNPKJOOJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EHDILMBOIBA FMKDGLKKJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JFFCBDLBIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JIOAEMAHFJJ, JIOAEMAHFJJ> LCHJBBCBAJI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAMLMIGNHPL(LFJFFJEONDM CILBHANMLOM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DCNADLIFAJN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DIGCMKDIPJG(string GEOBPCDINGD, HKACHFMJLGE ILGEEBIAPLJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PLGGHNDMJDE();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ICPCFOFENHD(AppSettings AMMKLNMHKHE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JIOAEMAHFJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FJPPHHLLEPP HNOAGMCCMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	FACMNPCPIKK KGODCKFJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NNPKJOOJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PIEEBMPILCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CDKFGJHAFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception NEBIBIBCKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode GDKOGDJHDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LFJFFJEONDM.PGFICMOCNFC LFBBOEDHLOK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<FJPPHHLLEPP, FJPPHHLLEPP> MGNJHHEDGON;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KHGANIEHJPO(object HIKBDNMPFJK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIGHJHJFEID(object EFDFABDCCIP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CCODHHMFNOL(byte OPGMLCDKFBP, int LLAJFFDLBMG, object GLECKDJIKIL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GIKDCCHIJJM
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LFJFFJEONDM.PGFICMOCNFC LFBBOEDHLOK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CCODHHMFNOL OLPNDDDJCNE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MDBCCFEEAIL(byte OPGMLCDKFBP, object MAKLFEFHFBK, IJDHNGPEKCN JHFELOMPNJC, SendOptions LMINHEJGLPD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EKHGOOMLMGL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BKBJMNKBOED EJGLDLJPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int ENKBCNDMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int POCLDFPDIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int CNHHKFIEHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<BKBJMNKBOED> MKPFIJIGANH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	BKBJMNKBOED CNNLHJBHMCL(int IHGDIMPKJAD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PJBHFBKGGMG
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action DNJLIIKPNPK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNDLFOMDIJK();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MFOOBEAIMGO : LNMBDGHHODP, FKANHHPELCA, GIKDCCHIJJM, EKHGOOMLMGL, PJBHFBKGGMG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int LPPLIBAPGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int LCOKHPOCBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int HFJONAKLBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LMCOHEKHFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float KKBFHDFDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GCBJMJCKICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AOLIDKMBKKJ BHCJLEMJIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action EKAKGIJMECC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBLFKBKIOFG();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMLDGNDAJMF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBKMJCGDJOI(List<object> FMFEHIEKOMI, int FNEPEEDFAPL);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCIOMOIAKNH(int DLLOIHPCEBC, object GLECKDJIKIL);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AONJENIAAHA(Hashtable FPBCGBJHAKH, int LNFLFPBOJOG);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMOKEPBPHNG();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HFDOEBIKMHL();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFKIJGIIJEM(string GMKLHEKBMGI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AOLIDKMBKKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KBAKPFFDHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OPPMKHJHPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IReadOnlyList<IPJCKPLNAJJ> AHHOCOKOMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OABCPOHEDNH(Action FPECJJILKHI, string PCBJDFPKAAF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EDACMJGCKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string OCPBMADBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 NHAANPHMDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion JHFELMOKPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 MOGENFAMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int HDKBMGOIMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public PDJBLPFEHEB EJMFFCIGCPC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79F11A0", Offset = "0x79EFBA0", VA = "0x1879F11A0")]
	public object[] POMKDMAMLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EDACMJGCKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KGDHEJKCFMF
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79F34B0", Offset = "0x79F1EB0", VA = "0x1879F34B0")]
	public static bool NEMJAAIMGGP(this LNMBDGHHODP HLPKEABAHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79F33E0", Offset = "0x79F1DE0", VA = "0x1879F33E0")]
	public static bool AAHFOHIKGAK(this LNMBDGHHODP HLPKEABAHKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GAHHJKOHPDN : MFOOBEAIMGO, LNMBDGHHODP, FKANHHPELCA, GIKDCCHIJJM, EKHGOOMLMGL, PJBHFBKGGMG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class EADGAPEGFBI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GAHHJKOHPDN INFPMHMILLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool FIMHNIKAAJI;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x79F1140", Offset = "0x79EFB40", VA = "0x1879F1140")]
		public EADGAPEGFBI(GAHHJKOHPDN INFPMHMILLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x79F1040", Offset = "0x79EFA40", VA = "0x1879F1040", Slot = "1")]
		~EADGAPEGFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x79F0FB0", Offset = "0x79EF9B0", VA = "0x1879F0FB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x79F10E0", Offset = "0x79EFAE0", VA = "0x1879F10E0")]
		private void NBLLKAIHJEP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object HFADFOGFDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object CPBDEAIHJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float MPFLCIJNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float EKPCFPGCAFI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract bool JFFCBDLBIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract float CKEOJJHFFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int LPPLIBAPGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract int LCOKHPOCBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract BKBJMNKBOED EJGLDLJPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int ENKBCNDMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79F27F0", Offset = "0x79F11F0", VA = "0x1879F27F0", Slot = "54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int POCLDFPDIFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract int CNHHKFIEHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x79F2370", Offset = "0x79F0D70", VA = "0x1879F2370", Slot = "56")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int HFJONAKLBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float LMCOHEKHFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE68BF0", Offset = "0xE675F0", VA = "0x180E68BF0", Slot = "85")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79F2860", Offset = "0x79F1260", VA = "0x1879F2860", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float KKBFHDFDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xF8EF60", Offset = "0xF8D960", VA = "0x180F8EF60", Slot = "86")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x79F18B0", Offset = "0x79F02B0", VA = "0x1879F18B0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool GCBJMJCKICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract AOLIDKMBKKJ BHCJLEMJIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool BHACNGLEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "91")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract JIOAEMAHFJJ ILHOCPAIJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "92")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool PIEEBMPILCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "93")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool PJCCLFCIFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "94")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "95")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool ADDFINPCOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "96")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool NNPKJOOJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "97")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract EHDILMBOIBA FMKDGLKKJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "98")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private OPHEEGEKGGC NDLIKMBEGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private OPHEEGEKGGC ELFIDPMCBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private JCIFFMNMFIG<Func<float>> DCMJBOJNAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool PCMOFCKGHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1626670", Offset = "0x1625070", VA = "0x181626670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool DNNECPKKOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x79F28A0", Offset = "0x79F12A0", VA = "0x1879F28A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool FMCGNNJKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79F2E40", Offset = "0x79F1840", VA = "0x1879F2E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event LFJFFJEONDM.PGFICMOCNFC LFBBOEDHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x79F1CD0", Offset = "0x79F06D0", VA = "0x1879F1CD0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x79F2A20", Offset = "0x79F1420", VA = "0x1879F2A20", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x6000054")]
	[method: Cpp2IlInjected.Address(Slot = "62")]
	public abstract event CCODHHMFNOL OLPNDDDJCNE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000056")]
	[method: Cpp2IlInjected.Address(Slot = "64")]
	public abstract event Action<BKBJMNKBOED> MKPFIJIGANH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000073")]
	[method: Cpp2IlInjected.Address(Slot = "89")]
	public abstract event Action<JIOAEMAHFJJ, JIOAEMAHFJJ> LCHJBBCBAJI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> KFCHMCNIACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x79F1980", Offset = "0x79F0380", VA = "0x1879F1980", Slot = "37")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x79F2590", Offset = "0x79F0F90", VA = "0x1879F2590", Slot = "38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action EKAKGIJMECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x79F2220", Offset = "0x79F0C20", VA = "0x1879F2220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x79F28F0", Offset = "0x79F12F0", VA = "0x1879F28F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action DNJLIIKPNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x79F24F0", Offset = "0x79F0EF0", VA = "0x1879F24F0", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x79F2D50", Offset = "0x79F1750", VA = "0x1879F2D50", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "74")]
	public abstract BKBJMNKBOED CNNLHJBHMCL(int IHGDIMPKJAD);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "75")]
	public abstract bool ICPCFOFENHD(AppSettings AMMKLNMHKHE);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "76")]
	public abstract void PLGGHNDMJDE();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "77")]
	public abstract bool DCNADLIFAJN();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "78")]
	public abstract void HBLFKBKIOFG();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "79")]
	public abstract void FMLDGNDAJMF();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "80")]
	public abstract void LBKMJCGDJOI(List<object> FMFEHIEKOMI, int FNEPEEDFAPL);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "81")]
	public abstract void MCIOMOIAKNH(int DLLOIHPCEBC, object GLECKDJIKIL);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "82")]
	public abstract void AONJENIAAHA(Hashtable FPBCGBJHAKH, int LNFLFPBOJOG);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "84")]
	public abstract bool MDBCCFEEAIL(byte OPGMLCDKFBP, object MAKLFEFHFBK, IJDHNGPEKCN JHFELOMPNJC, SendOptions LMINHEJGLPD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	public abstract bool DIGCMKDIPJG(string GEOBPCDINGD, HKACHFMJLGE ILGEEBIAPLJ);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	public abstract void LFKIJGIIJEM(string GMKLHEKBMGI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	public abstract void PAMLMIGNHPL(LFJFFJEONDM CILBHANMLOM);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79F2E80", Offset = "0x79F1880", VA = "0x1879F2E80")]
	protected GAHHJKOHPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79F2060", Offset = "0x79F0A60", VA = "0x1879F2060")]
	public void ELAEPFFNBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x79F2640", Offset = "0x79F1040", VA = "0x1879F2640", Slot = "41")]
	public void IKNMHPKJFEA(object GNAAILLDOKI, bool CDHBPJNHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x79F1D40", Offset = "0x79F0740", VA = "0x1879F1D40", Slot = "39")]
	public void EGIEFGIHFPA(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x79F1BE0", Offset = "0x79F05E0", VA = "0x1879F1BE0", Slot = "40")]
	public void CKLJOGOMAGG(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x79F2990", Offset = "0x79F1390", VA = "0x1879F2990", Slot = "42")]
	public IDisposable LBJDCELLCAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x79F1E40", Offset = "0x79F0840", VA = "0x1879F1E40", Slot = "102")]
	public virtual bool EHBMJKNOPOP(bool MDJJGNLKMPD, [Out] string LPNLOGECJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x79F2080", Offset = "0x79F0A80", VA = "0x1879F2080")]
	private bool FLNBHCBIKML([Out] string LPNLOGECJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x79F2760", Offset = "0x79F1160", VA = "0x1879F2760")]
	private bool IOPNBEMDKKL([Out] string LPNLOGECJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x79F2DF0", Offset = "0x79F17F0", VA = "0x1879F2DF0", Slot = "43")]
	public bool PICOCJACFFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x79F2AE0", Offset = "0x79F14E0", VA = "0x1879F2AE0", Slot = "44")]
	public void OCILEDDAMIF(StringBuilder PNLFMPPBIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x79F1A30", Offset = "0x79F0430", VA = "0x1879F1A30")]
	private void CABLEGFJACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x79F18F0", Offset = "0x79F02F0", VA = "0x1879F18F0")]
	private void AKMNFAFDCAJ(Func<float> EJLCNMOEGLA, object GNAAILLDOKI, int KLEICHAFCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x79F1850", Offset = "0x79F0250", VA = "0x1879F1850", Slot = "103")]
	public void AGOJPIHKCJP(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79F2400", Offset = "0x79F0E00", VA = "0x1879F2400", Slot = "14")]
	public void GMOKEPBPHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x79F2490", Offset = "0x79F0E90", VA = "0x1879F2490", Slot = "15")]
	public void HFDOEBIKMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x79F1C20", Offset = "0x79F0620", VA = "0x1879F1C20")]
	private void COCJEGBJMPD(float PNIMMCCMCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xF8EF60", Offset = "0xF8D960", VA = "0x180F8EF60")]
	private float NNHKNJIDEOI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xE68BF0", Offset = "0xE675F0", VA = "0x180E68BF0")]
	private float MAGEAPJEPPF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x79F22C0", Offset = "0x79F0CC0", VA = "0x1879F22C0")]
	private void GBDPFMNMJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x79F2A90", Offset = "0x79F1490", VA = "0x1879F2A90", Slot = "61")]
	public void MNDLFOMDIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class PGHDMBJLFNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string PBIBDFGLJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool FAICPGLBMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool IGDOBDHFAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int NMEDJDBLNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] POIIJBJKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte FEHAELJCODI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random BKGHKBKKJHO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79F3E40", Offset = "0x79F2840", VA = "0x1879F3E40", Slot = "5")]
	public virtual bool BILKCDNJPOB(string DOHJIIKMFDO, int NCJFFOCEFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x79F3EE0", Offset = "0x79F28E0", VA = "0x1879F3EE0", Slot = "6")]
	public virtual bool JBPEJLNFKPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x79F3E90", Offset = "0x79F2890", VA = "0x1879F3E90", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x79F3F30", Offset = "0x79F2930", VA = "0x1879F3F30")]
	protected internal void JCFABLNPBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79F4030", Offset = "0x79F2A30", VA = "0x1879F4030")]
	protected PGHDMBJLFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EHCKJBJPHCF : PGHDMBJLFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket DBGFONLNPAM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x79F12E0", Offset = "0x79EFCE0", VA = "0x1879F12E0", Slot = "5")]
	public override bool BILKCDNJPOB(string DOHJIIKMFDO, int NCJFFOCEFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79F1580", Offset = "0x79EFF80", VA = "0x1879F1580", Slot = "6")]
	public override bool JBPEJLNFKPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7C60", Offset = "0x6DC6660", VA = "0x186DC7C60", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x79F1770", Offset = "0x79F0170", VA = "0x1879F1770")]
	public EHCKJBJPHCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GMDDHOCODHP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string APCCBPPAMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string GCAPDLCHLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string LPMBOAKOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int FNKKMCBGACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CA0", Offset = "0x9B46A0", VA = "0x1809B5CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x79F32C0", Offset = "0x79F1CC0", VA = "0x1879F32C0")]
	public GMDDHOCODHP(string ICDLGGKHDLD, string MJMDMDPCBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x79F30F0", Offset = "0x79F1AF0", VA = "0x1879F30F0")]
	private void OAJLOKEMBBF(string IOJACPGKCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x79F3200", Offset = "0x79F1C00", VA = "0x1879F3200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79F3000", Offset = "0x79F1A00", VA = "0x1879F3000")]
	public string DBKIGAGJGPC(bool BFDAKGGNCEA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KGGEGABMMED
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int MNKEJPLOKPH;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool OEPFMPEFEFI;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int FHKAKEMLGAK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int GGPMCPMLNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GMDDHOCODHP HJEJJJDGGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string AAILLDIJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int OPGFKLIBMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int FHCDEIDODCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<GMDDHOCODHP> AAICDDHEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PGHDMBJLFNO OODMPNFAMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> BMFAFNEIPKD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JBPEJLNFKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA31440", Offset = "0xA2FE40", VA = "0x180A31440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x79F3D90", Offset = "0x79F2790", VA = "0x1879F3D90")]
	public KGGEGABMMED(GMDDHOCODHP HJEJJJDGGGA, Action<GMDDHOCODHP> PAHAFDJIOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x79F3830", Offset = "0x79F2230", VA = "0x1879F3830")]
	public bool MBHBHBLMGNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x79F3BA0", Offset = "0x79F25A0", VA = "0x1879F3BA0")]
	public static string ONPDNPEICDE(string HADPAFBFAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x79F3550", Offset = "0x79F1F50", VA = "0x1879F3550")]
	protected internal void GJOHPGJKIMI(object OJFCDDMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x79F3560", Offset = "0x79F1F60", VA = "0x1879F3560")]
	protected internal bool HCCFENHBIJM()
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
