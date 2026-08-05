using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class BPLIGGOMJMO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58C480", Offset = "0x58B480", VA = "0x18058C480")]
	public BPLIGGOMJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NIICKBLFAOJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58C480", Offset = "0x58B480", VA = "0x18058C480")]
	public NIICKBLFAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NGKANHOKPDE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58C480", Offset = "0x58B480", VA = "0x18058C480")]
	public NGKANHOKPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CHLPIBNIKMI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58C480", Offset = "0x58B480", VA = "0x18058C480")]
	public CHLPIBNIKMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class OFPILPECJHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F43AE0", Offset = "0x2F42AE0", VA = "0x182F43AE0")]
	public static bool HJFCHEDOBKP(this TypeInfo GOKHKCCNGMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class HFEAOCNKGOF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type EMGCJDKOAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] HDBPBMLFHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7D0", Offset = "0x6CC7D0", VA = "0x1806CD7D0")]
	public HFEAOCNKGOF(Type IKHJBCDMMKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class OFMPBJEADBF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void DEODDHPBEBD<T>(ref LGEMHOFFGMB GLHNDGPACHE, T BMNJAHFFOPC, OLHFHKDPOLA MDFPPPMMOJB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T JJPOJDECOPH<T>(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA MDFPPPMMOJB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BFICKKJBGKE
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IILEDKIHCHA<T> : BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, T BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IKDCOJFJNJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, T BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LFNDDKGMOOG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::IILEDKIHCHA<T> LKIAFFEHELA<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ONNBNPFIKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x228D5B0", Offset = "0x228C5B0", VA = "0x18228D5B0")]
	public static global::IILEDKIHCHA<T> EDHADBMBHEN<T>(this OLHFHKDPOLA MDFPPPMMOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3AD0", Offset = "0x4CD2AD0", VA = "0x184CD3AD0")]
	public static object EINLGONDOFJ(this OLHFHKDPOLA MDFPPPMMOJB, Type GOKHKCCNGMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CPJAICNNKKG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x372C090", Offset = "0x372B090", VA = "0x18372C090")]
	public CPJAICNNKKG(string EOGLFEOLNBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EIPKCMBENFK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CCPCNOBNPLG
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] EHKCNAODFJD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] PEPBOCCKLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x372AAE0", Offset = "0x3729AE0", VA = "0x18372AAE0")]
		public static byte[] DHKIACHMLMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x372AB60", Offset = "0x3729B60", VA = "0x18372AB60")]
		public static char[] GELEBICIMLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> EJBHLDHEBHC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] PIKOJILNAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] KCNDJOGONOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int DCGIMNLMJDB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ANKPBDJCOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x372FA40", Offset = "0x372EA40", VA = "0x18372FA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3732310", Offset = "0x3731310", VA = "0x183732310")]
	public EIPKCMBENFK(byte[] KCNDJOGONOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3732320", Offset = "0x3731320", VA = "0x183732320")]
	public EIPKCMBENFK(byte[] KCNDJOGONOI, int DCGIMNLMJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3730060", Offset = "0x372F060", VA = "0x183730060")]
	private GCNIGBFEAJG FDEGGPMGINB(string KJENACFHFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37314D0", Offset = "0x37304D0", VA = "0x1837314D0")]
	private GCNIGBFEAJG LPLAJDMLNEC(string EOGLFEOLNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AD50", Offset = "0x2F39D50", VA = "0x182F3AD50")]
	public void IAEJBPCMDJK(int DCGIMNLMJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7620E0", Offset = "0x7610E0", VA = "0x1807620E0")]
	public byte[] IFDEGCIILDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84B1B0", Offset = "0x84A1B0", VA = "0x18084B1B0")]
	public int MMKGKMGKFMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37306E0", Offset = "0x372F6E0", VA = "0x1837306E0")]
	public GJFBHIPPKIP HKCBHHIHNMF()
	{
		return default(GJFBHIPPKIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3730500", Offset = "0x372F500", VA = "0x183730500")]
	public void FMDEIOKBPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x372FD40", Offset = "0x372ED40", VA = "0x18372FD40")]
	public bool EKADPMCMNDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3730870", Offset = "0x372F870", VA = "0x183730870")]
	public bool HLBHGICGBKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3731880", Offset = "0x3730880", VA = "0x183731880")]
	public void MNFFOHEIFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3731D30", Offset = "0x3730D30", VA = "0x183731D30")]
	public bool ODCFLAEJCNH(ref int NGOMPCKMIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37308E0", Offset = "0x372F8E0", VA = "0x1837308E0")]
	public bool HNIPHHIDDLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3730640", Offset = "0x372F640", VA = "0x183730640")]
	public void GLABHJCKOJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3730AC0", Offset = "0x372FAC0", VA = "0x183730AC0")]
	public bool JKELJOPOBNN(ref int NGOMPCKMIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3731460", Offset = "0x3730460", VA = "0x183731460")]
	public bool LPKBGNAFBDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x372FAD0", Offset = "0x372EAD0", VA = "0x18372FAD0")]
	public void CHNGPHIIDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3731FA0", Offset = "0x3730FA0", VA = "0x183731FA0")]
	public bool PHJCJKKAHKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37320E0", Offset = "0x37310E0", VA = "0x1837320E0")]
	public void PMACNAEHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3730C10", Offset = "0x372FC10", VA = "0x183730C10")]
	private void LNFNPGPDFMI(out byte[] NMFPOPMCNMN, out int GMLKDOLJCHG, out int BDNMNEACEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x372F8A0", Offset = "0x372E8A0", VA = "0x18372F8A0")]
	private static int ANMKGILCGJE(char JAELLKEBFMM, char PEAHMNEGGIF, char DEJNODGKJKP, char DACHDCHIHLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x372FB70", Offset = "0x372EB70", VA = "0x18372FB70")]
	private static int CKKIKCAPDPJ(char JBEHFGFFAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37309D0", Offset = "0x372F9D0", VA = "0x1837309D0")]
	public ArraySegment<byte> IPDKCJOKLJE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x372FC40", Offset = "0x372EC40", VA = "0x18372FC40")]
	public string CNKMDLMOEAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x372FE60", Offset = "0x372EE60", VA = "0x18372FE60")]
	public string EKHHCJIPNEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3731B80", Offset = "0x3730B80", VA = "0x183731B80")]
	public ArraySegment<byte> NPCMIPLDCAN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3731420", Offset = "0x3730420", VA = "0x183731420")]
	public ArraySegment<byte> LOFHJMIIKCN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3731920", Offset = "0x3730920", VA = "0x183731920")]
	public bool NNDPJLFNBFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3730B50", Offset = "0x372FB50", VA = "0x183730B50")]
	private static bool KMHKCPHOHAO(byte DEJNODGKJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x372FE90", Offset = "0x372EE90", VA = "0x18372FE90")]
	private void EOLCALLNIGF(GJFBHIPPKIP DLNBPAAGBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x372FA60", Offset = "0x372EA60", VA = "0x18372FA60")]
	public void BGLOHANHKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3732010", Offset = "0x3731010", VA = "0x183732010")]
	private void PIAFODKIIJD(int FBCBLHNLOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3732180", Offset = "0x3731180", VA = "0x183732180")]
	public sbyte PMDJBKEBJCO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37321D0", Offset = "0x37311D0", VA = "0x1837321D0")]
	public short POPGGDNNGLM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x372FA70", Offset = "0x372EA70", VA = "0x18372FA70")]
	public int BGNMIELIFMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37313A0", Offset = "0x37303A0", VA = "0x1837313A0")]
	public long LNKAPNINDLF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3731F40", Offset = "0x3730F40", VA = "0x183731F40")]
	public byte PDAMJKGLDIO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x372FCE0", Offset = "0x372ECE0", VA = "0x18372FCE0")]
	public ushort EDPPHCPIMLE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37316F0", Offset = "0x37306F0", VA = "0x1837316F0")]
	public uint MDINACFJAGA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3730950", Offset = "0x372F950", VA = "0x183730950")]
	public ulong IAKAPIPJKHM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37315B0", Offset = "0x37305B0", VA = "0x1837315B0")]
	public float MCALFGJNEOE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3731750", Offset = "0x3730750", VA = "0x183731750")]
	public double MILPLFBEEEL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x372F950", Offset = "0x372E950", VA = "0x18372F950")]
	public ArraySegment<byte> BFCNHCFFFIE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3731DC0", Offset = "0x3730DC0", VA = "0x183731DC0")]
	private static int OOIMFNBEMOK(byte[] KCNDJOGONOI, int DCGIMNLMJDB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GCNIGBFEAJG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference LAKOCLDDJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FNAFHMMNEFB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int JPCNJNOKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x112CF70", Offset = "0x112BF70", VA = "0x18112CF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string FIJIDGDAAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x626E10", Offset = "0x625E10", VA = "0x180626E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3736B10", Offset = "0x3735B10", VA = "0x183736B10")]
	public GCNIGBFEAJG(string EOGLFEOLNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3736A40", Offset = "0x3735A40", VA = "0x183736A40")]
	public GCNIGBFEAJG(string EOGLFEOLNBK, byte[] FNPCBFKIPCF, int DCGIMNLMJDB, int FNAFHMMNEFB, string FLHDNGEKBNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FDGMEGBELHN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ECPCKODKHAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void JEKLODBIPEM(ref LGEMHOFFGMB GLHNDGPACHE, object BMNJAHFFOPC, OLHFHKDPOLA MDFPPPMMOJB);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object GAIFFKIPKLC(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA MDFPPPMMOJB);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class PPEKHBMGMIA
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class LHICFOGHHFE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
				public LHICFOGHHFE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x3738A70", Offset = "0x3737A70", VA = "0x183738A70")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x3738AB0", Offset = "0x3737AB0", VA = "0x183738AB0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, OLHFHKDPOLA, byte[]> AGFKPIHNCJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, OLHFHKDPOLA> OHILOPFPLAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly JEKLODBIPEM HGAPFMNKAKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, OLHFHKDPOLA, ArraySegment<byte>> KAMFNHPIHIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, OLHFHKDPOLA, string> LMEFDDJOMKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, OLHFHKDPOLA, object> LNMOFKHFOGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, OLHFHKDPOLA, object> GBHPGLODEIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, OLHFHKDPOLA, object> NACBKINONDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly GAIFFKIPKLC FGJEACNMBLB;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x373ADE0", Offset = "0x3739DE0", VA = "0x18373ADE0")]
			public PPEKHBMGMIA(Type GOKHKCCNGMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x213DAA0", Offset = "0x213CAA0", VA = "0x18213DAA0")]
			private static T DPLEBGPBEBL<T>(DynamicMethod KAMDAFLHCIN)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x373ABF0", Offset = "0x3739BF0", VA = "0x18373ABF0")]
			private static MethodInfo FEDKCOIGFJB(Type GOKHKCCNGMD, string LDKPDNBIJND, Type[] OGKABLKKMEI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, PPEKHBMGMIA> PGMFBPDNKBE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::FDCMINDICFO<PPEKHBMGMIA> OHJCHICHCPI;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x372F000", Offset = "0x372E000", VA = "0x18372F000")]
		static ECPCKODKHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x372EF80", Offset = "0x372DF80", VA = "0x18372EF80")]
		private static PPEKHBMGMIA KMCEDCMGCFC(Type GOKHKCCNGMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x372ED00", Offset = "0x372DD00", VA = "0x18372ED00")]
		public static void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, object BMNJAHFFOPC, OLHFHKDPOLA MDFPPPMMOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x372EE70", Offset = "0x372DE70", VA = "0x18372EE70")]
		public static void DBCHIDLCGFP(Type GOKHKCCNGMD, ref LGEMHOFFGMB GLHNDGPACHE, object BMNJAHFFOPC, OLHFHKDPOLA MDFPPPMMOJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class EDNHFCPKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] EHKCNAODFJD;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x372F650", Offset = "0x372E650", VA = "0x18372F650")]
		public static byte[] DHKIACHMLMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static OLHFHKDPOLA BLOPKMHEGBD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] INOBMBDFOIA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NDNBAMEGHGO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static OLHFHKDPOLA CMDKENDGOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x37339C0", Offset = "0x37329C0", VA = "0x1837339C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3733960", Offset = "0x3732960", VA = "0x183733960")]
	public static void GEPGGBNPNPC(OLHFHKDPOLA MDFPPPMMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x379E8E0", Offset = "0x379D8E0", VA = "0x18379E8E0")]
	public static string HKBBDDEFFEF<T>(T BMNJAHFFOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x379E780", Offset = "0x379D780", VA = "0x18379E780")]
	public static string HKBBDDEFFEF<T>(T BMNJAHFFOPC, OLHFHKDPOLA MDFPPPMMOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2131D20", Offset = "0x2130D20", VA = "0x182131D20")]
	public static T EKIAPEHGMJJ<T>(string BMOMEMAIOLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2131B00", Offset = "0x2130B00", VA = "0x182131B00")]
	public static T EKIAPEHGMJJ<T>(string BMOMEMAIOLB, OLHFHKDPOLA MDFPPPMMOJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2131DA0", Offset = "0x2130DA0", VA = "0x182131DA0")]
	public static T EKIAPEHGMJJ<T>(byte[] KCNDJOGONOI, OLHFHKDPOLA MDFPPPMMOJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2131BD0", Offset = "0x2130BD0", VA = "0x182131BD0")]
	public static T EKIAPEHGMJJ<T>(byte[] KCNDJOGONOI, int DCGIMNLMJDB, OLHFHKDPOLA MDFPPPMMOJB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GJFBHIPPKIP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BeginObject,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	EndObject,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BeginArray,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	EndArray,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	String,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	False,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Null,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ValueSeparator,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NameSeparator
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LGEMHOFFGMB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] CEFGCIHPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] EHKCNAODFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int DCGIMNLMJDB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PJLGDEBKCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84B1B0", Offset = "0x84A1B0", VA = "0x18084B1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AD50", Offset = "0x2F39D50", VA = "0x182F3AD50")]
	public void IAEJBPCMDJK(int DCGIMNLMJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B730", Offset = "0x2F3A730", VA = "0x182F3B730")]
	public static byte[] MPBLLNBNEOK(string OHBDEAFKOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A7D0", Offset = "0x2F397D0", VA = "0x182F3A7D0")]
	public static byte[] BFJBMMECHGL(string OHBDEAFKOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AD60", Offset = "0x2F39D60", VA = "0x182F3AD60")]
	public static byte[] IEECHDLKENP(string OHBDEAFKOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B120", Offset = "0x2F3A120", VA = "0x182F3B120")]
	public static byte[] JAODEOHODJK(string OHBDEAFKOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD08A90", Offset = "0xD07A90", VA = "0x180D08A90")]
	public LGEMHOFFGMB(byte[] AIJGAAMEHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A970", Offset = "0x2F39970", VA = "0x182F3A970")]
	public ArraySegment<byte> DHKIACHMLMF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2F3ABA0", Offset = "0x2F39BA0", VA = "0x182F3ABA0")]
	public byte[] HHIFGLCPMKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B8B0", Offset = "0x2F3A8B0", VA = "0x182F3B8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AB00", Offset = "0x2F39B00", VA = "0x182F3AB00")]
	public void GOHJEEPCGFA(int GFGGMBHKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A720", Offset = "0x2F39720", VA = "0x182F3A720")]
	public void ANFABMOMFOF(byte[] GKHMGLAHLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AB60", Offset = "0x2F39B60", VA = "0x182F3AB60")]
	public void HHGGPIPJIDP(byte GKHMGLAHLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A920", Offset = "0x2F39920", VA = "0x182F3A920")]
	public void DDALLHFLEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A6D0", Offset = "0x2F396D0", VA = "0x182F3A6D0")]
	public void AHNBKHDNBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A780", Offset = "0x2F39780", VA = "0x182F3A780")]
	public void BBMONCHFHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B6B0", Offset = "0x2F3A6B0", VA = "0x182F3B6B0")]
	public void LCNMLBOIHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A8D0", Offset = "0x2F398D0", VA = "0x182F3A8D0")]
	public void DCHGOJEBDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AB10", Offset = "0x2F39B10", VA = "0x182F3AB10")]
	public void HCNHBBJIODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AA20", Offset = "0x2F39A20", VA = "0x182F3AA20")]
	public void DJCDKDEDNBF(string OHBDEAFKOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AAB0", Offset = "0x2F39AB0", VA = "0x182F3AAB0")]
	public void FLNGKHICPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B7E0", Offset = "0x2F3A7E0", VA = "0x182F3B7E0")]
	public void NCNEHIGHJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AE30", Offset = "0x2F39E30", VA = "0x182F3AE30")]
	public void INJKKKHEAPB(bool BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B0A0", Offset = "0x2F3A0A0", VA = "0x182F3B0A0")]
	public void JAHPOBLPAOP(float BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B020", Offset = "0x2F3A020", VA = "0x182F3B020")]
	public void INOCLKCBMDL(double BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B2B0", Offset = "0x2F3A2B0", VA = "0x182F3B2B0")]
	public void KJKAJIAJNPB(byte BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AA80", Offset = "0x2F39A80", VA = "0x182F3AA80")]
	public void FGMHEPDDEMM(ushort BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B280", Offset = "0x2F3A280", VA = "0x182F3B280")]
	public void JGFDHGNNBFO(uint BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A8A0", Offset = "0x2F398A0", VA = "0x182F3A8A0")]
	public void BPFGPEMAHPK(ulong BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B7B0", Offset = "0x2F3A7B0", VA = "0x182F3B7B0")]
	public void NAJFHJAJPII(sbyte BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2F3ACF0", Offset = "0x2F39CF0", VA = "0x182F3ACF0")]
	public void HLNDDDAMDPA(short BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AD20", Offset = "0x2F39D20", VA = "0x182F3AD20")]
	public void IACBBKFIFAB(int BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B700", Offset = "0x2F3A700", VA = "0x182F3B700")]
	public void MKNLFMCFGGN(long BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B2E0", Offset = "0x2F3A2E0", VA = "0x182F3B2E0")]
	public void KNAEOHMEBJL(string BMNJAHFFOPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IBDKEHLBLBN : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class KNFOKFOEMCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x40AF4C0", Offset = "0x40AE4C0", VA = "0x1840AF4C0")]
		static KNFOKFOEMCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private IBDKEHLBLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class PDIFJMPJMAP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> GEIHLPKPEDP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5C80", Offset = "0x4CD4C80", VA = "0x184CD5C80")]
	static PDIFJMPJMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5720", Offset = "0x4CD4720", VA = "0x184CD5720")]
	internal static object LKIAFFEHELA(Type FNGOFIALAJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CCFHJBPFPKG : global::IILEDKIHCHA<Vector2>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x372A750", Offset = "0x3729750", VA = "0x18372A750")]
	public CCFHJBPFPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x372A3B0", Offset = "0x37293B0", VA = "0x18372A3B0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Vector2 BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x372A460", Offset = "0x3729460", VA = "0x18372A460", Slot = "5")]
	public Vector2 EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DKMKICPKGGF : global::IILEDKIHCHA<Vector3>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x372E7A0", Offset = "0x372D7A0", VA = "0x18372E7A0")]
	public DKMKICPKGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x372E330", Offset = "0x372D330", VA = "0x18372E330", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Vector3 BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x372E450", Offset = "0x372D450", VA = "0x18372E450", Slot = "5")]
	public Vector3 EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CFKHIMFLFPG : global::IILEDKIHCHA<Vector4>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x372B240", Offset = "0x372A240", VA = "0x18372B240")]
	public CFKHIMFLFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x372AD70", Offset = "0x3729D70", VA = "0x18372AD70", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Vector4 BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x372AEC0", Offset = "0x3729EC0", VA = "0x18372AEC0", Slot = "5")]
	public Vector4 EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class HBLHFBPJCMP : global::IILEDKIHCHA<Quaternion>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3738130", Offset = "0x3737130", VA = "0x183738130")]
	public HBLHFBPJCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x372AD70", Offset = "0x3729D70", VA = "0x18372AD70", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Quaternion BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3737DB0", Offset = "0x3736DB0", VA = "0x183737DB0", Slot = "5")]
	public Quaternion EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class HOFLKPEIGCH : global::IILEDKIHCHA<Color>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F351A0", Offset = "0x2F341A0", VA = "0x182F351A0")]
	public HOFLKPEIGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F34D00", Offset = "0x2F33D00", VA = "0x182F34D00", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Color BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F34F70", Offset = "0x2F33F70", VA = "0x182F34F70", Slot = "5")]
	public Color EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class FMFJBODFPNE : global::IILEDKIHCHA<Bounds>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3734A50", Offset = "0x3733A50", VA = "0x183734A50")]
	public FMFJBODFPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37343E0", Offset = "0x37333E0", VA = "0x1837343E0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Bounds BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3734650", Offset = "0x3733650", VA = "0x183734650", Slot = "5")]
	public Bounds EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class LJMBJGACNBI : global::IILEDKIHCHA<Rect>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BEOCGEGGAJK ECJHOKNMBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] JGCFCLEADCJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DFD0", Offset = "0x2F3CFD0", VA = "0x182F3DFD0")]
	public LJMBJGACNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DAE0", Offset = "0x2F3CAE0", VA = "0x182F3DAE0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Rect BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DD70", Offset = "0x2F3CD70", VA = "0x182F3DD70", Slot = "5")]
	public Rect EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EIDKCALOKFJ : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class GEEIPJNDKPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFB60", Offset = "0x3BCEB60", VA = "0x183BCFB60")]
		static GEEIPJNDKPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private EIDKCALOKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JMICIKKDLCN : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class KKBIEHOBECD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x42CAA10", Offset = "0x42C9A10", VA = "0x1842CAA10")]
		static KKBIEHOBECD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class LIGLFJDKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> HBGLAOKHMPP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F3BEB0", Offset = "0x2F3AEB0", VA = "0x182F3BEB0")]
		internal static object LKIAFFEHELA(Type FNGOFIALAJH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private JMICIKKDLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DCPKKMHPJJP : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class HOOADDGGALJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3DCFFA0", Offset = "0x3DCEFA0", VA = "0x183DCFFA0")]
		static HOOADDGGALJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DCPKKMHPJJP LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool JMFMMIPPALC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static BFICKKJBGKE[] HEOJHHBJBBL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static OLHFHKDPOLA[] AIDPKJLDFGC;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private DCPKKMHPJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x372C350", Offset = "0x372B350", VA = "0x18372C350")]
	public static void JLOEBHMLNFC(params OLHFHKDPOLA[] AIDPKJLDFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x372C410", Offset = "0x372B410", VA = "0x18372C410")]
	public static void JLOEBHMLNFC(params BFICKKJBGKE[] HEOJHHBJBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x372C100", Offset = "0x372B100", VA = "0x18372C100")]
	public static void JDIALAFPCFC(BFICKKJBGKE[] HEOJHHBJBBL, OLHFHKDPOLA[] AIDPKJLDFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FLECCHLCEGO : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class HLGINOPDJDA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x216F240", Offset = "0x216E240", VA = "0x18216F240")]
		static HLGINOPDJDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private FLECCHLCEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class POKBOGHKJJP
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly OLHFHKDPOLA LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly OLHFHKDPOLA FPBMHPIAJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly OLHFHKDPOLA LKCCCCPNGNM;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly OLHFHKDPOLA CPLBACKEPOA;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly OLHFHKDPOLA AMKGOLCIKNK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly OLHFHKDPOLA LDKBKPFJLBN;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly OLHFHKDPOLA MPKGHDFPOHC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly OLHFHKDPOLA DKLLEFJHHHB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly OLHFHKDPOLA DJAANDDJOEI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly OLHFHKDPOLA CLHKJONANBD;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly OLHFHKDPOLA PCGKANOCIHP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly OLHFHKDPOLA KPCFNAJOINJ;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LALHHAEIPLF
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly OLHFHKDPOLA LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly OLHFHKDPOLA FIIOIHEPFNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HMDNOMLMAGL
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly OLHFHKDPOLA LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly OLHFHKDPOLA FPBMHPIAJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly OLHFHKDPOLA LKCCCCPNGNM;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly OLHFHKDPOLA CPLBACKEPOA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly OLHFHKDPOLA AMKGOLCIKNK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly OLHFHKDPOLA LDKBKPFJLBN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly OLHFHKDPOLA MPKGHDFPOHC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly OLHFHKDPOLA DKLLEFJHHHB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly OLHFHKDPOLA DJAANDDJOEI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly OLHFHKDPOLA CLHKJONANBD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly OLHFHKDPOLA PCGKANOCIHP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly OLHFHKDPOLA KPCFNAJOINJ;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class PPHHFBOLMFI
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> HBGLAOKHMPP;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8850", Offset = "0x4CD7850", VA = "0x184CD8850")]
	internal static object LKIAFFEHELA(Type FNGOFIALAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8810", Offset = "0x4CD7810", VA = "0x184CD8810")]
	private static object BMEDAILHIGM(Type IHBCGEHICOH, Type[] NMEIINANEFC, params object[] OGKABLKKMEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class ADOAJKEOJFO : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class LBACHOKMICD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8B70", Offset = "0x3EF7B70", VA = "0x183EF8B70")]
		static LBACHOKMICD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly OFFPKIMOBIE BJCEDDJHHLF;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3726380", Offset = "0x3725380", VA = "0x183726380")]
	static ADOAJKEOJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private ADOAJKEOJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MKKPNIADBHF : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class LOPLFKEPAGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2097900", Offset = "0x2096900", VA = "0x182097900")]
		static LOPLFKEPAGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly OFFPKIMOBIE BJCEDDJHHLF;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F402B0", Offset = "0x2F3F2B0", VA = "0x182F402B0")]
	static MKKPNIADBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private MKKPNIADBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class IGBAAGPIFFH : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PHGAPGKEEPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x342F9E0", Offset = "0x342E9E0", VA = "0x18342F9E0")]
		static PHGAPGKEEPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly OFFPKIMOBIE BJCEDDJHHLF;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F358E0", Offset = "0x2F348E0", VA = "0x182F358E0")]
	static IGBAAGPIFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private IGBAAGPIFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class CFJKCHCHKCO : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class AGNKEODBPIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x45A89B0", Offset = "0x45A79B0", VA = "0x1845A89B0")]
		static AGNKEODBPIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly OFFPKIMOBIE BJCEDDJHHLF;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x372AC80", Offset = "0x3729C80", VA = "0x18372AC80")]
	static CFJKCHCHKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private CFJKCHCHKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class HMFDOIOFFPC : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class PBKJGCPGGEI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x40B18A0", Offset = "0x40B08A0", VA = "0x1840B18A0")]
		static PBKJGCPGGEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly OFFPKIMOBIE BJCEDDJHHLF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F349B0", Offset = "0x2F339B0", VA = "0x182F349B0")]
	static HMFDOIOFFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private HMFDOIOFFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class PNOAIBLPAPD : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class LFNLCCDFIIB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x46B8380", Offset = "0x46B7380", VA = "0x1846B8380")]
		static LFNLCCDFIIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly OFFPKIMOBIE BJCEDDJHHLF;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7AB0", Offset = "0x4CD6AB0", VA = "0x184CD7AB0")]
	static PNOAIBLPAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private PNOAIBLPAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class FPHBIOMGLNH : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class ICNJIDHJBJK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x21725D0", Offset = "0x21715D0", VA = "0x1821725D0")]
		static ICNJIDHJBJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FPHBIOMGLNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class MLJBMFHKLHF : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class HACOFGMNIKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x20962A0", Offset = "0x20952A0", VA = "0x1820962A0")]
		static HACOFGMNIKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public MLJBMFHKLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class KBHBEAIJLOL : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class MFDBPDDOJIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x29BCE60", Offset = "0x29BBE60", VA = "0x1829BCE60")]
		static MFDBPDDOJIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public KBHBEAIJLOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class AIMJJOAKCOK : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class AJAFKNMDPNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3672730", Offset = "0x3671730", VA = "0x183672730")]
		static AJAFKNMDPNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public AIMJJOAKCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class FGMJEKFFHCC : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class DHLPCBFDBPN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x21605A0", Offset = "0x215F5A0", VA = "0x1821605A0")]
		static DHLPCBFDBPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FGMJEKFFHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class CJEBIJDBFKP : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class GJJJGJBHNKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x25475A0", Offset = "0x25465A0", VA = "0x1825475A0")]
		static GJJJGJBHNKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> GMNJKBIEMMD;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool DFDLKCODGIL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public CJEBIJDBFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class OHJOBBFGPHB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct PNGKCJJMNDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BKAPEEKNJPC DIGIACOOBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder DIBIOLIMLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder NCJJLMOHDGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class GKHKBMAKOBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class IBDEPAEHJGI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo IEECHDLKENP;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo BFJBMMECHGL;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo JAODEOHODJK;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo MPBLLNBNEOK;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo NCNEHIGHJKC;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo ANFABMOMFOF;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo BBMONCHFHOA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo LCNMLBOIHNP;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo DCHGOJEBDIC;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4CCFCD0", Offset = "0x4CCECD0", VA = "0x184CCFCD0")]
			static IBDEPAEHJGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class CNCBOFAOHOK
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo EKADPMCMNDF;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo GLABHJCKOJO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo JKELJOPOBNN;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo PNEMJAGHPIE;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo BGLOHANHKGO;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo IFDEGCIILDK;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo MMKGKMGKFMF;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4CCD390", Offset = "0x4CCC390", VA = "0x184CCD390")]
			static CNCBOFAOHOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class BKFNCPDMMGA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo EMGCJDKOAFA;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo HDBPBMLFHIA;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo FBDNKEBCONJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo EDHADBMBHEN;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo ELIPLHLNGCO;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo AAIDHDAKNAB;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo DCALPDDDPFA;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo OKNCEGCIDBJ;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo ILNFNBAKAND;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo IFLCFGDBLDA;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LKDCPDBLEON;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo ANJKHDHMNJD;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo AEPHGFHLHBP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo KLLOMDHIOMC;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE2A0", Offset = "0x4CCD2A0", VA = "0x184CCE2A0")]
		public static MethodInfo DBCHIDLCGFP(Type GOKHKCCNGMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE530", Offset = "0x4CCD530", VA = "0x184CCE530")]
		public static MethodInfo EKIAPEHGMJJ(Type GOKHKCCNGMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE760", Offset = "0x4CCD760", VA = "0x184CCE760")]
		public static MethodInfo IJMPLCDCKKH(Type GOKHKCCNGMD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GAJDIGKBGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BKAPEEKNJPC, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public GAJDIGKBGAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class JKDLEIKOAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public GAJDIGKBGAB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public JKDLEIKOAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4CD0D90", Offset = "0x4CCFD90", VA = "0x184CD0D90")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4CD0DD0", Offset = "0x4CCFDD0", VA = "0x184CD0DD0")]
		internal bool <BuildType>b__2(int index, BKAPEEKNJPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PFLBPCOFBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GAJDIGKBGAB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public PFLBPCOFBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4CD6040", Offset = "0x4CD5040", VA = "0x184CD6040")]
		internal bool <BuildType>b__3(int index, BKAPEEKNJPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OJIABLKHJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public OJIABLKHJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4CD3A70", Offset = "0x4CD2A70", VA = "0x184CD3A70")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FMKIODCBAHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public FMKIODCBAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4CCDFC0", Offset = "0x4CCCFC0", VA = "0x184CCDFC0")]
		internal bool <BuildAnonymousFormatter>b__2(BKAPEEKNJPC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FOPJDMMPCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OJIABLKHJGL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public FOPJDMMPCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE020", Offset = "0x4CCD020", VA = "0x184CCE020")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE0A0", Offset = "0x4CCD0A0", VA = "0x184CCE0A0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, BKAPEEKNJPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class INACNOAIDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OJIABLKHJGL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public INACNOAIDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4CD0B90", Offset = "0x4CCFB90", VA = "0x184CD0B90")]
		internal bool <BuildAnonymousFormatter>b__7(int index, BKAPEEKNJPC member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CAELGHIFMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public CAELGHIFMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x594CC0", Offset = "0x593CC0", VA = "0x180594CC0")]
		internal Label <BuildSerialize>b__1(BKAPEEKNJPC _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class EFOBKIOCAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public PNGKCJJMNDN[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BKAPEEKNJPC, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public IJAPKMJGJHB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IJAPKMJGJHB argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public EFOBKIOCAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4CCDE90", Offset = "0x4CCCE90", VA = "0x184CCDE90")]
		internal PNGKCJJMNDN <BuildDeserialize>b__0(BKAPEEKNJPC item)
		{
			return default(PNGKCJJMNDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CGNBNBBJJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EFOBKIOCAAA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public CGNBNBBJJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD010", Offset = "0x4CCC010", VA = "0x184CCD010")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD2F0", Offset = "0x4CCC2F0", VA = "0x184CCD2F0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class BOLIAFJIDFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BKAPEEKNJPC item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public BOLIAFJIDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x158E2A0", Offset = "0x158D2A0", VA = "0x18158E2A0")]
		internal bool <EmitNewObject>b__0(PNGKCJJMNDN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MHOLMDCFHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BKAPEEKNJPC item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public MHOLMDCFHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x158E2A0", Offset = "0x158D2A0", VA = "0x18158E2A0")]
		internal bool <EmitNewObject>b__2(PNGKCJJMNDN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex KKNFPAOKLFC;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int IFNDOCDNEFE;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> HLNPJEAOJGD;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NHFLPOEIKMI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x24AC830", Offset = "0x24AB830", VA = "0x1824AC830")]
	public static object DLAIBFKCNGE<T>(OFFPKIMOBIE BJCEDDJHHLF, OLHFHKDPOLA GCKMBDEGKHM, Func<string, string> GMNJKBIEMMD, bool DFDLKCODGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x37B1320", Offset = "0x37B0320", VA = "0x1837B1320")]
	public static object MFOEABCIOGA<T>(OLHFHKDPOLA GCKMBDEGKHM, Func<string, string> GMNJKBIEMMD, bool DFDLKCODGIL, bool HCKLMIDHNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2F49120", Offset = "0x2F48120", VA = "0x182F49120")]
	private static TypeInfo HNMNEDAIAKL(OFFPKIMOBIE BJCEDDJHHLF, Type GOKHKCCNGMD, Func<string, string> GMNJKBIEMMD, bool DFDLKCODGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A180", Offset = "0x2F49180", VA = "0x182F4A180")]
	public static object MPPBBGMMHEE(Type GOKHKCCNGMD, Func<string, string> GMNJKBIEMMD, bool DFDLKCODGIL, bool HCKLMIDHNLC, bool DCNAKANAHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2F47E60", Offset = "0x2F46E60", VA = "0x182F47E60")]
	private static Dictionary<BKAPEEKNJPC, FieldInfo> FLEEEFAIMCJ(TypeBuilder FEIOGIHNNIM, OOBOJFDFHGJ JIFANPJIKMK, ConstructorInfo ILIBCLKFIMK, FieldBuilder KHNAOCJHHHA, ILGenerator OIFFBJGHGKI, bool DFDLKCODGIL, bool EPMPMFFLJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2F49BC0", Offset = "0x2F48BC0", VA = "0x182F49BC0")]
	private static Dictionary<BKAPEEKNJPC, FieldInfo> MAJLFMGHLJB(TypeBuilder FEIOGIHNNIM, OOBOJFDFHGJ JIFANPJIKMK, ILGenerator OIFFBJGHGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2F45700", Offset = "0x2F44700", VA = "0x182F45700")]
	private static void DFNLIFIMIHK(Type GOKHKCCNGMD, OOBOJFDFHGJ JIFANPJIKMK, ILGenerator OIFFBJGHGKI, Action ANPGNNIJNCF, Func<int, BKAPEEKNJPC, bool> DIIPOAKOOFN, bool DFDLKCODGIL, bool EPMPMFFLJAP, int HKDMIBELLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2F47790", Offset = "0x2F46790", VA = "0x182F47790")]
	private static void EFDEEHDCPJB(TypeInfo GOKHKCCNGMD, BKAPEEKNJPC KIKAACJNKFP, ILGenerator OIFFBJGHGKI, int FBOCJCCNMND, Func<int, BKAPEEKNJPC, bool> DIIPOAKOOFN, IJAPKMJGJHB GLHNDGPACHE, IJAPKMJGJHB DMHALACDLND, IJAPKMJGJHB AKHFJBKDMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2F43F80", Offset = "0x2F42F80", VA = "0x182F43F80")]
	private static void AJDFKGIBNFB(Type GOKHKCCNGMD, OOBOJFDFHGJ JIFANPJIKMK, ILGenerator OIFFBJGHGKI, Func<int, BKAPEEKNJPC, bool> DIIPOAKOOFN, bool KHJNKJEKNHO, int HKDMIBELLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2F45250", Offset = "0x2F44250", VA = "0x182F45250")]
	private static void BEIHOFMJAKC(ILGenerator OIFFBJGHGKI, PNGKCJJMNDN JIFANPJIKMK, int FBOCJCCNMND, Func<int, BKAPEEKNJPC, bool> DIIPOAKOOFN, IJAPKMJGJHB IDEINAMOPJE, IJAPKMJGJHB AKHFJBKDMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2F484B0", Offset = "0x2F474B0", VA = "0x182F484B0")]
	private static LocalBuilder HDCALCFFOKJ(ILGenerator OIFFBJGHGKI, Type GOKHKCCNGMD, OOBOJFDFHGJ JIFANPJIKMK, PNGKCJJMNDN[] LFDPGLIJMPH, bool NNLHPEAFHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2F46F60", Offset = "0x2F45F60", VA = "0x182F46F60")]
	private static bool EDCHFGEAHJI(ConstructorInfo BIFNBLOALKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2F46DC0", Offset = "0x2F45DC0", VA = "0x182F46DC0")]
	private static bool EDBPBFCOFDH(Type GOKHKCCNGMD, out Type MKGKKHFNNFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void ALCOCDGIEPK<T>(byte[][] KHNAOCJHHHA, object[] DCGGJGNPECI, ref LGEMHOFFGMB GLHNDGPACHE, T BMNJAHFFOPC, OLHFHKDPOLA MDFPPPMMOJB);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T PIEECMFHGGB<T>(object[] DCGGJGNPECI, ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA MDFPPPMMOJB);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class NMKNCJBJDLD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class CIIFPPCHIMI : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class OBIOOOHCLHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x45B6920", Offset = "0x45B5920", VA = "0x1845B6920")]
		static OBIOOOHCLHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private CIIFPPCHIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class IIIFOHMEAEJ : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class GEBMFAFAFAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x375A950", Offset = "0x3759950", VA = "0x18375A950")]
		static GEBMFAFAFAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private IIIFOHMEAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class HKBCGOIPLDO
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly OLHFHKDPOLA[] APAHMAJKKFF;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class ABAHOCMIPNB : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class EEMCJPPIGBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4146D10", Offset = "0x4145D10", VA = "0x184146D10")]
		static EEMCJPPIGBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class BNGHHFKLOPM : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class NHCELNDGLGL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x414D2A0", Offset = "0x414C2A0", VA = "0x18414D2A0")]
			static NHCELNDGLGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private BNGHHFKLOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private ABAHOCMIPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class CGFMFAIJMBA : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class EJHGLKIOPLE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x45B3070", Offset = "0x45B2070", VA = "0x1845B3070")]
		static EJHGLKIOPLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class BJLELKKACFJ : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class MEAECOLAHCE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x45B5780", Offset = "0x45B4780", VA = "0x1845B5780")]
			static MEAECOLAHCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private BJLELKKACFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private CGFMFAIJMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class BPGEGKCMMKI : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class DMOOMLMBLIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x475C8C0", Offset = "0x475B8C0", VA = "0x18475C8C0")]
		static DMOOMLMBLIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class LFLLILDKKCA : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class JIHPHNINNON<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x475E9C0", Offset = "0x475D9C0", VA = "0x18475E9C0")]
			static JIHPHNINNON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private LFLLILDKKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private BPGEGKCMMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class LINLDKJHODK : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class JLJPEIOGDFB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3186740", Offset = "0x3185740", VA = "0x183186740")]
		static JLJPEIOGDFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class IDHDPAMNIDM : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class KMPMLOOOJCG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3188C00", Offset = "0x3187C00", VA = "0x183188C00")]
			static KMPMLOOOJCG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private IDHDPAMNIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private LINLDKJHODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class BPGECOLKALD : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AJIOHBLHCEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x474CDD0", Offset = "0x474BDD0", VA = "0x18474CDD0")]
		static AJIOHBLHCEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class NJHDAANHLPB : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class CAGILLNAEOA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4757010", Offset = "0x4756010", VA = "0x184757010")]
			static CAGILLNAEOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private NJHDAANHLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private BPGECOLKALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class IBBDGDLNKJI : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class DGBGDDKBEGE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x409C800", Offset = "0x409B800", VA = "0x18409C800")]
		static DGBGDDKBEGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class LGKKDEFNHBD : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GMEOCPPPNKN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x409E8D0", Offset = "0x409D8D0", VA = "0x18409E8D0")]
			static GMEOCPPPNKN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private LGKKDEFNHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private IBBDGDLNKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class DKJGJGKEIMK : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class BOHFCDKOCKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35176A0", Offset = "0x35166A0", VA = "0x1835176A0")]
		static BOHFCDKOCKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class IEOGLGMLENP : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class IDHHPFOKHFG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3523A50", Offset = "0x3522A50", VA = "0x183523A50")]
			static IDHHPFOKHFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private IEOGLGMLENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private DKJGJGKEIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class OOPLIGHGDCB : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class EKKLAKMGMMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4577B20", Offset = "0x4576B20", VA = "0x184577B20")]
		static EKKLAKMGMMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class ILCOBNINAHD : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class OIOIGMGEFNK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2380030", Offset = "0x237F030", VA = "0x182380030")]
			static OIOIGMGEFNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private ILCOBNINAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private OOPLIGHGDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class MBJCCKMGFAL : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class KCIOEONOHFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x27E5D90", Offset = "0x27E4D90", VA = "0x1827E5D90")]
		static KCIOEONOHFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class HIEFBCCCIIE : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class KCLAAFEHNLL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x27EBB70", Offset = "0x27EAB70", VA = "0x1827EBB70")]
			static KCLAAFEHNLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private HIEFBCCCIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private MBJCCKMGFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class ACNIOPPGIEL : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class JBNMOMPNNKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3C90", Offset = "0x3EF2C90", VA = "0x183EF3C90")]
		static JBNMOMPNNKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class MOKLCKDAKGL : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class GHNKMJKLGNL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3EF0AF0", Offset = "0x3EEFAF0", VA = "0x183EF0AF0")]
			static GHNKMJKLGNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private MOKLCKDAKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private ACNIOPPGIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class KHMKBEJPMAP : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class KFOPHEFPNAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x29B4F40", Offset = "0x29B3F40", VA = "0x1829B4F40")]
		static KFOPHEFPNAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class ENEFLPNMFJF : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NMKCDAJAEJJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x29BFE10", Offset = "0x29BEE10", VA = "0x1829BFE10")]
			static NMKCDAJAEJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private ENEFLPNMFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private KHMKBEJPMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class GHFBCACDNKF : OLHFHKDPOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class NCMILCGOALO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x320A3E0", Offset = "0x32093E0", VA = "0x18320A3E0")]
		static NCMILCGOALO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class CCNKLJIFDIB : OLHFHKDPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class PBEHKJLDMOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::IILEDKIHCHA<T> CCDMPPLKGKF;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3210AD0", Offset = "0x320FAD0", VA = "0x183210AD0")]
			static PBEHKJLDMOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly OLHFHKDPOLA LOBJDNDFAIF;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly OLHFHKDPOLA[] AIDPKJLDFGC;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		private CCNKLJIFDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
		public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly OLHFHKDPOLA LOBJDNDFAIF;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::IILEDKIHCHA<object> JFBBMICCMCG;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	private GHFBCACDNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2284A90", Offset = "0x2283A90", VA = "0x182284A90", Slot = "4")]
	public global::IILEDKIHCHA<T> LKIAFFEHELA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct HMLGNBCIJFG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] CJBECOIBJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int BEKDBNBHEAN;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x40A21A0", Offset = "0x40A11A0", VA = "0x1840A21A0")]
	public HMLGNBCIJFG(int EACLEMJMPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x40A2040", Offset = "0x40A1040", VA = "0x1840A2040")]
	public void NJFAMEHLCGO(T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x40A2110", Offset = "0x40A1110", VA = "0x1840A2110")]
	public T[] PKLFCANAEOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class CIHNJJHPFEI : global::DFGACPJEMOI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly CIHNJJHPFEI LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x372BCB0", Offset = "0x372ACB0", VA = "0x18372BCB0")]
	public CIHNJJHPFEI(int GGGKGBMHNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class DFGACPJEMOI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int GGGKGBMHNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object IKHCPKJLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int FBOCJCCNMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] AEGEDPCGHOI;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B20230", Offset = "0x3B1F230", VA = "0x183B20230")]
	public DFGACPJEMOI(int GGGKGBMHNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F030", Offset = "0x3B1E030", VA = "0x183B1F030")]
	public T[] IHAGMEEOMGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E370", Offset = "0x3B1D370", VA = "0x183B1E370")]
	public void ALKMBACDMAB(T[] PEGJLEIKJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class BEOCGEGGAJK : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class MPGFJCICDNL : IComparable<MPGFJCICDNL>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class MBMLIHLAGFO : IEnumerable<MPGFJCICDNL>, IEnumerable, IEnumerator<MPGFJCICDNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private MPGFJCICDNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public MPGFJCICDNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MPGFJCICDNL System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
			[DebuggerHidden]
			public MBMLIHLAGFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3738CB0", Offset = "0x3737CB0", VA = "0x183738CB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3738DE0", Offset = "0x3737DE0", VA = "0x183738DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3738D40", Offset = "0x3737D40", VA = "0x183738D40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MPGFJCICDNL> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x3738D40", Offset = "0x3737D40", VA = "0x183738D40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class LPIINOHBIDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public LPIINOHBIDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x594CC0", Offset = "0x593CC0", VA = "0x180594CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x594CC0", Offset = "0x593CC0", VA = "0x180594CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly MPGFJCICDNL[] LIPDEOGILLB;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] AMEMBLNLIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong LEAFJIBNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int MHLLNAFLMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CGBLGBOJOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MPGFJCICDNL[] CAKCCKDKNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] OAIJKBNHNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int NGOMPCKMIBL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BFLPONDFHKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xBFA8E0", Offset = "0xBF98E0", VA = "0x180BFA8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x373A250", Offset = "0x3739250", VA = "0x18373A250")]
		public MPGFJCICDNL(ulong DDFHJDPPNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3739FE0", Offset = "0x3738FE0", VA = "0x183739FE0")]
		public MPGFJCICDNL NJFAMEHLCGO(ulong DDFHJDPPNBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3739F90", Offset = "0x3738F90", VA = "0x183739F90")]
		public MPGFJCICDNL NJFAMEHLCGO(ulong DDFHJDPPNBF, int BMNJAHFFOPC, string CGBLGBOJOMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3738FE0", Offset = "0x3737FE0", VA = "0x183738FE0")]
		public MPGFJCICDNL KOBOCIHKDBM(byte[] NMGDGLNDLGK, ref int DCGIMNLMJDB, ref int PMKBIJBMIJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3739190", Offset = "0x3738190", VA = "0x183739190")]
		internal static int LEFNPBGJOKL(ulong[] PEGJLEIKJED, int FBOCJCCNMND, int MBJMKPGFPJP, ulong BMNJAHFFOPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3738FB0", Offset = "0x3737FB0", VA = "0x183738FB0", Slot = "4")]
		public int CompareTo(MPGFJCICDNL INIEAOGGCLC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3739F20", Offset = "0x3738F20", VA = "0x183739F20")]
		[IteratorStateMachine(typeof(MBMLIHLAGFO))]
		public IEnumerable<MPGFJCICDNL> LOPKMELIJKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3739DF0", Offset = "0x3738DF0", VA = "0x183739DF0")]
		public void LJMKEPLPJIG(ILGenerator OIFFBJGHGKI, LocalBuilder NMGDGLNDLGK, LocalBuilder PMKBIJBMIJB, LocalBuilder DDFHJDPPNBF, Action<KeyValuePair<string, int>> NLFOMLLEJHJ, Action EJLOAFIDBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3739210", Offset = "0x3738210", VA = "0x183739210")]
		private static void LFNEAILKGAO(ILGenerator OIFFBJGHGKI, LocalBuilder NMGDGLNDLGK, LocalBuilder PMKBIJBMIJB, LocalBuilder DDFHJDPPNBF, Action<KeyValuePair<string, int>> NLFOMLLEJHJ, Action EJLOAFIDBEO, MPGFJCICDNL[] CAKCCKDKNJN, int NGOMPCKMIBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class OKMDLFKIIAG : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private IEnumerable<MPGFJCICDNL> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<MPGFJCICDNL> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<MPGFJCICDNL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private MPGFJCICDNL <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x58D000", Offset = "0x58C000", VA = "0x18058D000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x373AA00", Offset = "0x3739A00", VA = "0x18373AA00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B54D0", Offset = "0x9B44D0", VA = "0x1809B54D0")]
		[DebuggerHidden]
		public OKMDLFKIIAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x373AA50", Offset = "0x3739A50", VA = "0x18373AA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x373A590", Offset = "0x3739590", VA = "0x18373A590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x373AB50", Offset = "0x3739B50", VA = "0x18373AB50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x373ABA0", Offset = "0x3739BA0", VA = "0x18373ABA0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x373A9B0", Offset = "0x37399B0", VA = "0x18373A9B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x373A910", Offset = "0x3739910", VA = "0x18373A910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x373A910", Offset = "0x3739910", VA = "0x18373A910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly MPGFJCICDNL EIIIPMJKAPH;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3727890", Offset = "0x3726890", VA = "0x183727890")]
	public BEOCGEGGAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3727680", Offset = "0x3726680", VA = "0x183727680")]
	public void NJFAMEHLCGO(byte[] KCNDJOGONOI, int BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3727560", Offset = "0x3726560", VA = "0x183727560")]
	public bool HCJKEECAKFH(ArraySegment<byte> DDFHJDPPNBF, out int BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x37277A0", Offset = "0x37267A0", VA = "0x1837277A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x37271B0", Offset = "0x37261B0", VA = "0x1837271B0")]
	private static void AGEMJKLLOKG(IEnumerable<MPGFJCICDNL> CAKCCKDKNJN, StringBuilder EDBJCLMFFPJ, int EBFLECLDFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3727460", Offset = "0x3726460", VA = "0x183727460", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3727460", Offset = "0x3726460", VA = "0x183727460", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3727610", Offset = "0x3726610", VA = "0x183727610")]
	[IteratorStateMachine(typeof(OKMDLFKIIAG))]
	private static IEnumerable<KeyValuePair<string, int>> IKNAGMEKAJD(IEnumerable<MPGFJCICDNL> CAKCCKDKNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3727430", Offset = "0x3726430", VA = "0x183727430")]
	public void BAAKGABNDJL(ILGenerator OIFFBJGHGKI, LocalBuilder NMGDGLNDLGK, LocalBuilder PMKBIJBMIJB, LocalBuilder DDFHJDPPNBF, Action<KeyValuePair<string, int>> NLFOMLLEJHJ, Action EJLOAFIDBEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class OIPHAENCHML
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo HAOIKDAGPHB;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1630", Offset = "0x4CD0630", VA = "0x184CD1630")]
	public static ulong KADFDAICDHB(byte[] KCNDJOGONOI, ref int DCGIMNLMJDB, ref int PMKBIJBMIJB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class NKNPGFKJBNE
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F41680", Offset = "0x2F40680", VA = "0x182F41680")]
	public static void GOHJEEPCGFA(ref byte[] KCNDJOGONOI, int DCGIMNLMJDB, int GFGGMBHKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F41590", Offset = "0x2F40590", VA = "0x182F41590")]
	public static void BGFNLCGCHME(ref byte[] PEGJLEIKJED, int LIDEIIACKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F417A0", Offset = "0x2F407A0", VA = "0x182F417A0")]
	public static byte[] NEIMBLDONLM(byte[] GIOFAAADDOC, int LIDEIIACKPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class CDCGLFBOELP
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x372ABF0", Offset = "0x3729BF0", VA = "0x18372ABF0")]
	public static bool LBIHKFOCCFJ(byte[] OOFACMOOLPP, int JJGMFKJIFHL, int ODMNCDHANAJ, byte[] MOBDOIECHDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class AKPDJJJNDOE<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct IJJANIKBMFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] LEAFJIBNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T MHLLNAFLMHJ;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A28840", Offset = "0x3A27840", VA = "0x183A28840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NEBBGODDAOM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::AKPDJJJNDOE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private IJJANIKBMFC[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private IJJANIKBMFC[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x10EF7A0", Offset = "0x10EE7A0", VA = "0x1810EF7A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x3A2B170", Offset = "0x3A2A170", VA = "0x183A2B170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E52950", Offset = "0x1E51950", VA = "0x181E52950")]
		[DebuggerHidden]
		public NEBBGODDAOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A0E0", Offset = "0x3A290E0", VA = "0x183A2A0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B030", Offset = "0x3A2A030", VA = "0x183A2B030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly IJJANIKBMFC[][] PDFIOBONKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong ODOANAMPOFB;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8640", Offset = "0x2EC7640", VA = "0x182EC8640")]
	public AKPDJJJNDOE(int EHCFCNDLJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8580", Offset = "0x2EC7580", VA = "0x182EC8580")]
	public AKPDJJJNDOE(int EHCFCNDLJCD, float POGPBHPHJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4185220", Offset = "0x4184220", VA = "0x184185220")]
	public void NJFAMEHLCGO(byte[] DDFHJDPPNBF, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4183150", Offset = "0x4182150", VA = "0x184183150")]
	private bool EMMJAMPLCBF(byte[] DDFHJDPPNBF, T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4185EB0", Offset = "0x4184EB0", VA = "0x184185EB0")]
	public bool NOGIDOCGHEN(ArraySegment<byte> DDFHJDPPNBF, out T BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8360", Offset = "0x2EC7360", VA = "0x182EC8360")]
	private static ulong NJKMFCBDLEE(byte[] JBEHFGFFAPE, int DCGIMNLMJDB, int NGOMPCKMIBL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8260", Offset = "0x2EC7260", VA = "0x182EC8260")]
	private static int INBIGAAGMLK(int NKCDNFPCBBJ, float POGPBHPHJAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2EC81D0", Offset = "0x2EC71D0", VA = "0x182EC81D0", Slot = "4")]
	[IteratorStateMachine(typeof(global::AKPDJJJNDOE<>.NEBBGODDAOM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1EA03C0", Offset = "0x1E9F3C0", VA = "0x181EA03C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class ODHHHCLEMOB : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] KDMICOANHJF;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] JKMFCLNKJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int PMNFBDAMJPC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FHJJCLPGBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2F435D0", Offset = "0x2F425D0", VA = "0x182F435D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2F43620", Offset = "0x2F42620", VA = "0x182F43620")]
	static ODHHHCLEMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2F43870", Offset = "0x2F42870", VA = "0x182F43870")]
	public ODHHHCLEMOB(byte[] DFGLKONJCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2F434C0", Offset = "0x2F424C0", VA = "0x182F434C0")]
	public OpCode FFGGBCCAMFH()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct BFMLDFBDGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid MHLLNAFLMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte LNELGLALNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte FIJIOLCOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte ILNPOKLLGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte ECOJABMNNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte IMPBGNGDFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte DDGABKNJNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte JGGAAJKAAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KIGOCFBDADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte NGOONBJIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte ANOOFAEFHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte EKAIBAINFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte EKMJCBMMIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte IMBFAOILODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte FECGPIGHGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte OEHENKKLJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte NNIANDICAPH;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] LAIKCNDMPJO;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] MLOMGNHGHKL;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3728EC0", Offset = "0x3727EC0", VA = "0x183728EC0")]
	public BFMLDFBDGLE(ref Guid BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3728ED0", Offset = "0x3727ED0", VA = "0x183728ED0")]
	public BFMLDFBDGLE(ref ArraySegment<byte> DEMLBKFOKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3728D50", Offset = "0x3727D50", VA = "0x183728D50")]
	private static byte OOMGFNIMPOP(byte[] KCNDJOGONOI, int KCBLIMJNJCO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3728C40", Offset = "0x3727C40", VA = "0x183728C40")]
	private static byte HCCBIBCFKLF(byte PEAHMNEGGIF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3727900", Offset = "0x3726900", VA = "0x183727900")]
	public void CMLMNKFKJNH(byte[] EHKCNAODFJD, int DCGIMNLMJDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class JLPNBDBMBMN
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2F399D0", Offset = "0x2F389D0", VA = "0x182F399D0")]
	public static bool OAMCKMJIOEN(byte DEJNODGKJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2F37F00", Offset = "0x2F36F00", VA = "0x182F37F00")]
	public static bool BGJJHNFOFKD(byte DEJNODGKJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2F39A50", Offset = "0x2F38A50", VA = "0x182F39A50")]
	public static sbyte PMDJBKEBJCO(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2F39AC0", Offset = "0x2F38AC0", VA = "0x182F39AC0")]
	public static short POPGGDNNGLM(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2F37F70", Offset = "0x2F36F70", VA = "0x182F37F70")]
	public static int BGNMIELIFMB(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2F38930", Offset = "0x2F37930", VA = "0x182F38930")]
	public static long LNKAPNINDLF(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2F399E0", Offset = "0x2F389E0", VA = "0x182F399E0")]
	public static byte PDAMJKGLDIO(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2F387B0", Offset = "0x2F377B0", VA = "0x182F387B0")]
	public static ushort EDPPHCPIMLE(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2F38A50", Offset = "0x2F37A50", VA = "0x182F38A50")]
	public static uint MDINACFJAGA(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2F38820", Offset = "0x2F37820", VA = "0x182F38820")]
	public static ulong IAKAPIPJKHM(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2F389E0", Offset = "0x2F379E0", VA = "0x182F389E0")]
	public static float MCALFGJNEOE(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2F38AD0", Offset = "0x2F37AD0", VA = "0x182F38AD0")]
	public static double MILPLFBEEEL(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2F37FE0", Offset = "0x2F36FE0", VA = "0x182F37FE0")]
	public static int BPFGPEMAHPK(ref byte[] EHKCNAODFJD, int DCGIMNLMJDB, ulong BMNJAHFFOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2F38B40", Offset = "0x2F37B40", VA = "0x182F38B40")]
	public static int MKNLFMCFGGN(ref byte[] EHKCNAODFJD, int DCGIMNLMJDB, long BMNJAHFFOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2F39780", Offset = "0x2F38780", VA = "0x182F39780")]
	public static bool NNDPJLFNBFC(byte[] KCNDJOGONOI, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class PJPGKEKNKOK
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NPIJOMECPMH : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
		[DebuggerHidden]
		public NPIJOMECPMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4CD12D0", Offset = "0x4CD02D0", VA = "0x184CD12D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4CD0E70", Offset = "0x4CCFE70", VA = "0x184CD0E70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4CD13F0", Offset = "0x4CD03F0", VA = "0x184CD13F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4CD1440", Offset = "0x4CD0440", VA = "0x184CD1440")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4CD1280", Offset = "0x4CD0280", VA = "0x184CD1280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4CD11D0", Offset = "0x4CD01D0", VA = "0x184CD11D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4CD11D0", Offset = "0x4CD01D0", VA = "0x184CD11D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class POINEIPFIEK : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
		[DebuggerHidden]
		public POINEIPFIEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4CD8000", Offset = "0x4CD7000", VA = "0x184CD8000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4CD7BA0", Offset = "0x4CD6BA0", VA = "0x184CD7BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4CD8120", Offset = "0x4CD7120", VA = "0x184CD8120")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4CD8170", Offset = "0x4CD7170", VA = "0x184CD8170")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4CD7FB0", Offset = "0x4CD6FB0", VA = "0x184CD7FB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4CD7F00", Offset = "0x4CD6F00", VA = "0x184CD7F00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4CD7F00", Offset = "0x4CD6F00", VA = "0x184CD7F00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6480", Offset = "0x4CD5480", VA = "0x184CD6480")]
	public static bool DDPKOCDHJDI(this TypeInfo GOKHKCCNGMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6590", Offset = "0x4CD5590", VA = "0x184CD6590")]
	public static bool EAEFCFJHKIC(this TypeInfo GOKHKCCNGMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6530", Offset = "0x4CD5530", VA = "0x184CD6530")]
	public static IEnumerable<PropertyInfo> DHHMCHBIMAJ(this Type GOKHKCCNGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6690", Offset = "0x4CD5690", VA = "0x184CD6690")]
	[IteratorStateMachine(typeof(NPIJOMECPMH))]
	private static IEnumerable<PropertyInfo> NIOMOEEIIID(Type GOKHKCCNGMD, HashSet<string> BDHNMOBIPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6720", Offset = "0x4CD5720", VA = "0x184CD6720")]
	public static IEnumerable<FieldInfo> OALEEABHGBN(this Type GOKHKCCNGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6780", Offset = "0x4CD5780", VA = "0x184CD6780")]
	[IteratorStateMachine(typeof(POINEIPFIEK))]
	private static IEnumerable<FieldInfo> OKNHNPGEIIG(Type GOKHKCCNGMD, HashSet<string> BDHNMOBIPGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class OHMNJFJDCEE
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding LNAHPIPBCIM;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class KPHBNBALEME
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x641F60", Offset = "0x640F60", VA = "0x180641F60")]
	public static string PLCIMCNFPEO(string AEKJNMNAGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A130", Offset = "0x2F39130", VA = "0x182F3A130")]
	public static string BJCGFBEPEML(string AEKJNMNAGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A240", Offset = "0x2F39240", VA = "0x182F3A240")]
	public static string EFNNEOBCGJL(string AEKJNMNAGFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class FDCMINDICFO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class MADHJBGEGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type LEAFJIBNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue MHLLNAFLMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int JIBAGCHDFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public MADHJBGEGDF GEIMABBIODL;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4275610", Offset = "0x4274610", VA = "0x184275610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4275590", Offset = "0x4274590", VA = "0x184275590")]
		private int AGNENIFEHDL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public MADHJBGEGDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class ECKFIBCFEPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public ECKFIBCFEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x89D740", Offset = "0x89C740", VA = "0x18089D740")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private MADHJBGEGDF[] PDFIOBONKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int MAAFLBOPOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object EJKEBMJFBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float POGPBHPHJAG;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4274240", Offset = "0x4273240", VA = "0x184274240")]
	public FDCMINDICFO(int EHCFCNDLJCD = 4, float POGPBHPHJAG = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4273FA0", Offset = "0x4272FA0", VA = "0x184273FA0")]
	public bool OIJIJCLDMLM(Type DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x42741C0", Offset = "0x42731C0", VA = "0x1842741C0")]
	public bool OIJIJCLDMLM(Type DDFHJDPPNBF, Func<Type, TValue> LGAPEPJPJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x4273150", Offset = "0x4272150", VA = "0x184273150")]
	private bool EMMJAMPLCBF(Type DDFHJDPPNBF, Func<Type, TValue> LGAPEPJPJPC, out TValue NPIADEONIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x4273840", Offset = "0x4272840", VA = "0x184273840")]
	private bool NOLGFJPPJGH(MADHJBGEGDF[] PDFIOBONKEJ, Type BDGCLIDIIHN, MADHJBGEGDF LLHLMINHBHG, Func<Type, TValue> LGAPEPJPJPC, out TValue NPIADEONIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x42735A0", Offset = "0x42725A0", VA = "0x1842735A0")]
	public bool NOGIDOCGHEN(Type DDFHJDPPNBF, out TValue BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x4273500", Offset = "0x4272500", VA = "0x184273500")]
	public TValue KMCEDCMGCFC(Type DDFHJDPPNBF, Func<Type, TValue> LGAPEPJPJPC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8260", Offset = "0x2EC7260", VA = "0x182EC8260")]
	private static int INBIGAAGMLK(int NKCDNFPCBBJ, float POGPBHPHJAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x4272E20", Offset = "0x4271E20", VA = "0x184272E20")]
	private static void APOGDFJHALB(ref MADHJBGEGDF BLNOKAFILGG, MADHJBGEGDF BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x4272E20", Offset = "0x4271E20", VA = "0x184272E20")]
	private static void APOGDFJHALB(ref MADHJBGEGDF[] BLNOKAFILGG, MADHJBGEGDF[] BMNJAHFFOPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class OFFPKIMOBIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder PPKOFPEDEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder DGLHFJDKAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object IKHCPKJLGCI;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2F438F0", Offset = "0x2F428F0", VA = "0x182F438F0")]
	public TypeBuilder NIOBPODMLOL(string LDKPDNBIJND, TypeAttributes APLPDNNNHPK, Type ACJKMIDAEJL, Type[] BCFPHHIMEJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2F439E0", Offset = "0x2F429E0", VA = "0x182F439E0")]
	public OFFPKIMOBIE(string POLEGKIKFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class CLKAFGEDHGB
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x372BE10", Offset = "0x372AE10", VA = "0x18372BE10")]
	private static MethodInfo LHDOEAANEJO(LambdaExpression AAHDLHOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x379CBA0", Offset = "0x379BBA0", VA = "0x18379CBA0")]
	public static MethodInfo DGJPJNHPABI<T>(Expression<Func<T>> AAHDLHOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x379CBA0", Offset = "0x379BBA0", VA = "0x18379CBA0")]
	public static MethodInfo DGJPJNHPABI<T, TR>(Expression<Func<T, TR>> AAHDLHOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x379CBA0", Offset = "0x379BBA0", VA = "0x18379CBA0")]
	public static MethodInfo DGJPJNHPABI<T>(Expression<Action<T>> AAHDLHOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x379CBA0", Offset = "0x379BBA0", VA = "0x18379CBA0")]
	public static MethodInfo DGJPJNHPABI<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> AAHDLHOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x379CBB0", Offset = "0x379BBB0", VA = "0x18379CBB0")]
	private static MemberInfo FFJAHKBDBNA<T>(Expression<T> AKBGILOFPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x379CC50", Offset = "0x379BC50", VA = "0x18379CC50")]
	public static PropertyInfo HAHFDANENBN<T, TR>(Expression<Func<T, TR>> AAHDLHOAFHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct IJAPKMJGJHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int BHFIJCEBIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool OAPMLJJBFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator OIFFBJGHGKI;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2F35A50", Offset = "0x2F34A50", VA = "0x182F35A50")]
	public IJAPKMJGJHB(ILGenerator OIFFBJGHGKI, int BHFIJCEBIFE, bool OAPMLJJBFAB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2F35A90", Offset = "0x2F34A90", VA = "0x182F35A90")]
	public IJAPKMJGJHB(ILGenerator OIFFBJGHGKI, int BHFIJCEBIFE, Type GOKHKCCNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2F35A30", Offset = "0x2F34A30", VA = "0x182F35A30")]
	public void PFGFJGGELLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class PNJGGNJLNAG
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7270", Offset = "0x4CD6270", VA = "0x184CD7270")]
	public static void KGOOPFFFKJF(this ILGenerator OIFFBJGHGKI, int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7230", Offset = "0x4CD6230", VA = "0x184CD7230")]
	public static void KGOOPFFFKJF(this ILGenerator OIFFBJGHGKI, LocalBuilder HMIEDIEEMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4CD74E0", Offset = "0x4CD64E0", VA = "0x184CD74E0")]
	public static void LKBCLCKMEMC(this ILGenerator OIFFBJGHGKI, int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4CD74A0", Offset = "0x4CD64A0", VA = "0x184CD74A0")]
	public static void LKBCLCKMEMC(this ILGenerator OIFFBJGHGKI, LocalBuilder HMIEDIEEMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4CD77B0", Offset = "0x4CD67B0", VA = "0x184CD77B0")]
	public static void MFIIIMOLHHJ(this ILGenerator OIFFBJGHGKI, int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4CD78A0", Offset = "0x4CD68A0", VA = "0x184CD78A0")]
	public static void MFIIIMOLHHJ(this ILGenerator OIFFBJGHGKI, LocalBuilder HMIEDIEEMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7180", Offset = "0x4CD6180", VA = "0x184CD7180")]
	public static void IJGHPDICHNH(this ILGenerator OIFFBJGHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7710", Offset = "0x4CD6710", VA = "0x184CD7710")]
	public static void MEGELCKDFCI(this ILGenerator OIFFBJGHGKI, bool BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6D30", Offset = "0x4CD5D30", VA = "0x184CD6D30")]
	public static void GIGNOGAJLLK(this ILGenerator OIFFBJGHGKI, int BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6BC0", Offset = "0x4CD5BC0", VA = "0x184CD6BC0")]
	public static void FJEKBHGCIGC(this ILGenerator OIFFBJGHGKI, Type GOKHKCCNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7190", Offset = "0x4CD6190", VA = "0x184CD7190")]
	public static void JCEMBAKFKDP(this ILGenerator OIFFBJGHGKI, Type GOKHKCCNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6990", Offset = "0x4CD5990", VA = "0x184CD6990")]
	public static void COMHLIHKKCH(this ILGenerator OIFFBJGHGKI, int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6CB0", Offset = "0x4CD5CB0", VA = "0x184CD6CB0")]
	public static void GBOEPOCCFCE(this ILGenerator OIFFBJGHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6810", Offset = "0x4CD5810", VA = "0x184CD6810")]
	public static void AEEOLAJOGFH(this ILGenerator OIFFBJGHGKI, int FBOCJCCNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4CD79B0", Offset = "0x4CD69B0", VA = "0x184CD79B0")]
	public static void MKBLEEAPKPD(this ILGenerator OIFFBJGHGKI, MethodInfo JDNKCMIBDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6900", Offset = "0x4CD5900", VA = "0x184CD6900")]
	public static void CLBIFDFAPIP(this ILGenerator OIFFBJGHGKI, FieldInfo HJGFNAEFPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7720", Offset = "0x4CD6720", VA = "0x184CD7720")]
	public static void MELKOMADBHD(this ILGenerator OIFFBJGHGKI, ulong BMNJAHFFOPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class BKAPEEKNJPC
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class NFADPELBEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public NFADPELBEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x373A310", Offset = "0x3739310", VA = "0x18373A310")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo MKNIMJLACMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo PCIGJJGNHOD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BIEMFEFJPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FEPCFEFMIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CKOLCKFCBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x37298E0", Offset = "0x37288E0", VA = "0x1837298E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BMDGPALKMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x58C190", Offset = "0x58B190", VA = "0x18058C190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E80", Offset = "0x6E5E80", VA = "0x1806E6E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JPCBHFFIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x58C1A0", Offset = "0x58B1A0", VA = "0x18058C1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB200", Offset = "0x7AA200", VA = "0x1807AB200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type OKPIHCNCEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCC0", Offset = "0x6AECC0", VA = "0x1806AFCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo JPFFAEDKJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo NNIBCBKLNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x58D010", Offset = "0x58C010", VA = "0x18058D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x58D020", Offset = "0x58C020", VA = "0x18058D020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo AGOIGFCFONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x59FD70", Offset = "0x59ED70", VA = "0x18059FD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x626FC0", Offset = "0x625FC0", VA = "0x180626FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3729C70", Offset = "0x3728C70", VA = "0x183729C70")]
	protected BKAPEEKNJPC(Type GOKHKCCNGMD, string LDKPDNBIJND, string DKDMPILGBDO, bool CNBJDLGJKMA, bool KNOJCMBFPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x37299B0", Offset = "0x37289B0", VA = "0x1837299B0")]
	public BKAPEEKNJPC(FieldInfo JIFANPJIKMK, string LDKPDNBIJND, bool HCKLMIDHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3729AC0", Offset = "0x3728AC0", VA = "0x183729AC0")]
	public BKAPEEKNJPC(PropertyInfo JIFANPJIKMK, string LDKPDNBIJND, bool HCKLMIDHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3729700", Offset = "0x3728700", VA = "0x183729700")]
	private static MethodInfo AMANEGPHEFI(MemberInfo JIFANPJIKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x212CF30", Offset = "0x212BF30", VA = "0x18212CF30")]
	public T CIHCPOBCLNI<T>(bool JFAGHBBAELE) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3729820", Offset = "0x3728820", VA = "0x183729820", Slot = "4")]
	public virtual void EBFMFAOMBBI(ILGenerator OIFFBJGHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x37298F0", Offset = "0x37288F0", VA = "0x1837298F0", Slot = "5")]
	public virtual void FHGDPLEBIBF(ILGenerator OIFFBJGHGKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class HMLDBDLMNKF : BKAPEEKNJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string GOBGDANIBLM;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2F34C50", Offset = "0x2F33C50", VA = "0x182F34C50")]
	public HMLDBDLMNKF(string LDKPDNBIJND, string GOBGDANIBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2F34B40", Offset = "0x2F33B40", VA = "0x182F34B40", Slot = "4")]
	public override void EBFMFAOMBBI(ILGenerator OIFFBJGHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2F34C00", Offset = "0x2F33C00", VA = "0x182F34C00", Slot = "5")]
	public override void FHGDPLEBIBF(ILGenerator OIFFBJGHGKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class LNMKKJFFIEE : BKAPEEKNJPC
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo DJKJCENJDBI;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo PLCOKMCJLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal IJAPKMJGJHB JGKNMFEDIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal IJAPKMJGJHB DMHALACDLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal IJAPKMJGJHB AKHFJBKDMGK;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F7F0", Offset = "0x2F3E7F0", VA = "0x182F3F7F0")]
	public LNMKKJFFIEE(string LDKPDNBIJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F240", Offset = "0x2F3E240", VA = "0x182F3F240", Slot = "4")]
	public override void EBFMFAOMBBI(ILGenerator OIFFBJGHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F300", Offset = "0x2F3E300", VA = "0x182F3F300", Slot = "5")]
	public override void FHGDPLEBIBF(ILGenerator OIFFBJGHGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F100", Offset = "0x2F3E100", VA = "0x182F3F100")]
	public void BHILCMDEIKL(ILGenerator OIFFBJGHGKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class OOBOJFDFHGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type OKPIHCNCEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OKCBOPLBLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC80", Offset = "0x6B9C80", VA = "0x1806BAC80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7609D0", Offset = "0x75F9D0", VA = "0x1807609D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NPBIJHBKLOC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x74FC10", Offset = "0x74EC10", VA = "0x18074FC10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xDD12F0", Offset = "0xDD02F0", VA = "0x180DD12F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo CEDNOEHHPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BKAPEEKNJPC[] NKJKIKLHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCC0", Offset = "0x6AECC0", VA = "0x1806AFCC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BKAPEEKNJPC[] JOHKNCKHIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3CE0", Offset = "0x4CD2CE0", VA = "0x184CD3CE0")]
	public OOBOJFDFHGJ(Type GOKHKCCNGMD, Func<string, string> IKFDJEANAMN, bool HCKLMIDHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3C10", Offset = "0x4CD2C10", VA = "0x184CD3C10")]
	private static bool EHHJPNMPPFM(IEnumerator<ConstructorInfo> CGINPIHIKML, ref ConstructorInfo PAHNOENFLCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct MJAAECDDOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong CKFIOBCMGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int OPNLBLDAFKL;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2447F00", Offset = "0x2446F00", VA = "0x182447F00")]
	public MJAAECDDOGI(ulong JPAICIMKEDD, int FBPHPJCBEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FE60", Offset = "0x2F3EE60", VA = "0x182F3FE60")]
	public void BHIFFHJKHEF(ref MJAAECDDOGI INIEAOGGCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FE70", Offset = "0x2F3EE70", VA = "0x182F3FE70")]
	public static MJAAECDDOGI CLKABLHCNEO(ref MJAAECDDOGI JAELLKEBFMM, ref MJAAECDDOGI PEAHMNEGGIF)
	{
		return default(MJAAECDDOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FEA0", Offset = "0x2F3EEA0", VA = "0x182F3FEA0")]
	public void ELHBHBEHEKB(ref MJAAECDDOGI INIEAOGGCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FD10", Offset = "0x2F3ED10", VA = "0x182F3FD10")]
	public static MJAAECDDOGI ALLGFJKKEKJ(ref MJAAECDDOGI JAELLKEBFMM, ref MJAAECDDOGI PEAHMNEGGIF)
	{
		return default(MJAAECDDOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FE20", Offset = "0x2F3EE20", VA = "0x182F3FE20")]
	public void BCKBFGPCLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FDC0", Offset = "0x2F3EDC0", VA = "0x182F3FDC0")]
	public static MJAAECDDOGI BCKBFGPCLBM(ref MJAAECDDOGI JAELLKEBFMM)
	{
		return default(MJAAECDDOGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct LHHNPLMFNIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] EHKCNAODFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int DCGIMNLMJDB;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x9CD790", Offset = "0x9CC790", VA = "0x1809CD790")]
	public LHHNPLMFNIK(byte[] EHKCNAODFJD, int CAIONMHOLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BB60", Offset = "0x2F3AB60", VA = "0x182F3BB60")]
	public void FJIENDFDJAG(byte GMLEIGNAEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BE10", Offset = "0x2F3AE10", VA = "0x182F3BE10")]
	public void PMDIONPHHOB(byte[] GMLEIGNAEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BBC0", Offset = "0x2F3ABC0", VA = "0x182F3BBC0")]
	public void HBEIGNBOIDK(byte[] GMLEIGNAEGC, int MBJMKPGFPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BC60", Offset = "0x2F3AC60", VA = "0x182F3BC60")]
	public void HBEIGNBOIDK(byte[] GMLEIGNAEGC, int DOAOIAFHHOJ, int MBJMKPGFPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BAE0", Offset = "0x2F3AAE0", VA = "0x182F3BAE0")]
	public void EDABCGHIIIJ(byte DEJNODGKJKP, int NGOMPCKMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BD10", Offset = "0x2F3AD10", VA = "0x182F3BD10")]
	public void MIOBCMNELBO(string GMLEIGNAEGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class ABOAEDLGLBB
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum OFEKJJGGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum JIAFOHIADOA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum KKLEPAENLAD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[ThreadStatic]
	private static byte[] NAJMLLAICEB;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] NJNBGHGOFMA;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] NBGKMEKLFGL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] CBCLFHPPFDM;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly KKLEPAENLAD JPKMPKJJKLL;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char GCHBPMGBONH;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int NBIMJCBHHCF;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int GAMEAPICBCG;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] OGLONPGOJPN;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x3724890", Offset = "0x3723890", VA = "0x183724890")]
	private static byte[] EJGNGKIGEDG(int MAAFLBOPOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x3724A60", Offset = "0x3723A60", VA = "0x183724A60")]
	private static byte[] GNPBKJKCHGL(int MAAFLBOPOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x37244F0", Offset = "0x37234F0", VA = "0x1837244F0")]
	public static int BGGMAOOJONN(ref byte[] EHKCNAODFJD, int DCGIMNLMJDB, float BMNJAHFFOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x37243E0", Offset = "0x37233E0", VA = "0x1837243E0")]
	public static int BGGMAOOJONN(ref byte[] EHKCNAODFJD, int DCGIMNLMJDB, double BMNJAHFFOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3724960", Offset = "0x3723960", VA = "0x183724960")]
	private static bool GJFMMCECJHF(byte[] EHKCNAODFJD, int MBJMKPGFPJP, ulong HAECLLDCNLN, ulong CMHDKMMMCHC, ulong PMKBIJBMIJB, ulong GCEDBMPHCAD, ulong ANNKEBOPMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3724D00", Offset = "0x3723D00", VA = "0x183724D00")]
	private static void KMCDFFPFOHD(uint FNAOLNFIIIG, int DBHKKGMFEPN, out uint NJJIBGNJKOO, out int GDMILJIIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3725AE0", Offset = "0x3724AE0", VA = "0x183725AE0")]
	private static bool PKIOPCCDOAH(MJAAECDDOGI KIJNAJOPAFC, MJAAECDDOGI HNDCAHMOFNF, MJAAECDDOGI EJNLFPIBBIP, byte[] EHKCNAODFJD, out int MBJMKPGFPJP, out int NIBHDFBNKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3724E20", Offset = "0x3723E20", VA = "0x183724E20")]
	private static bool KPEDGIALGLL(double NDCAPABKMLD, OFEKJJGGGMO NLPCHIBFNAI, byte[] EHKCNAODFJD, out int MBJMKPGFPJP, out int NIEPEDEKBJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3724600", Offset = "0x3723600", VA = "0x183724600")]
	private static bool DGACLPLIONN(double NDCAPABKMLD, OFEKJJGGGMO NLPCHIBFNAI, byte[] EHKCNAODFJD, out int MBJMKPGFPJP, out int CBGHENIIIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3724250", Offset = "0x3723250", VA = "0x183724250")]
	private static bool BABPBDLMOHO(double BMNJAHFFOPC, ref LHHNPLMFNIK CMGHJJJGMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x37254B0", Offset = "0x37244B0", VA = "0x1837254B0")]
	private static bool LKHOMIMLMPD(double BMNJAHFFOPC, ref LHHNPLMFNIK CMGHJJJGMKB, JIAFOHIADOA NLPCHIBFNAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3724B40", Offset = "0x3723B40", VA = "0x183724B40")]
	private static void IAMCLNNIMJK(byte[] NJNFGBPHJDP, int MBJMKPGFPJP, int CBGHENIIIOE, int FAOGLBLJJJJ, ref LHHNPLMFNIK CMGHJJJGMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x37251C0", Offset = "0x37241C0", VA = "0x1837251C0")]
	private static void LBACBABHCGI(byte[] NJNFGBPHJDP, int MBJMKPGFPJP, int FBPHPJCBEIK, ref LHHNPLMFNIK CMGHJJJGMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x37246F0", Offset = "0x37236F0", VA = "0x1837246F0")]
	private static bool ECHAGCPEADM(double NDCAPABKMLD, JIAFOHIADOA NLPCHIBFNAI, int DCKBFLJGCEN, byte[] NEHENKMJBFC, out bool BEOHDJLKLDH, out int MBJMKPGFPJP, out int AOEGFIEEENK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct LHODJKEKFGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double DACHDCHIHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong FGEBAFINNIJ;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct IHOIKELJOLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float CKFIOBCMGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint OCNBJKOALBD;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct NFMLFFFNLLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong CBPJHPFCDOM;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F414E0", Offset = "0x2F404E0", VA = "0x182F414E0")]
	public NFMLFFFNLLN(double DACHDCHIHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F414F0", Offset = "0x2F404F0", VA = "0x182F414F0")]
	public NFMLFFFNLLN(MJAAECDDOGI DACHDCHIHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F41450", Offset = "0x2F40450", VA = "0x182F41450")]
	public MJAAECDDOGI NMGPJFNPIHL()
	{
		return default(MJAAECDDOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F413C0", Offset = "0x2F403C0", VA = "0x182F413C0")]
	public MJAAECDDOGI MPBEKIICJGO()
	{
		return default(MJAAECDDOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7620E0", Offset = "0x7610E0", VA = "0x1807620E0")]
	public ulong FHHALGIMIBJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F41280", Offset = "0x2F40280", VA = "0x182F41280")]
	public double GOFOOFHGDIF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F40F40", Offset = "0x2F3FF40", VA = "0x182F40F40")]
	public double AGPOPNJENAN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F41390", Offset = "0x2F40390", VA = "0x182F41390")]
	public int KNBGDMDEKOA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F40FF0", Offset = "0x2F3FFF0", VA = "0x182F40FF0")]
	public ulong CLLCFELPBLC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F40FC0", Offset = "0x2F3FFC0", VA = "0x182F40FC0")]
	public bool BIEIDCGNMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F41020", Offset = "0x2F40020", VA = "0x182F41020")]
	public bool CNHCFPPJHJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F412F0", Offset = "0x2F402F0", VA = "0x182F412F0")]
	public bool HBHFOPENLKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F41230", Offset = "0x2F40230", VA = "0x182F41230")]
	public bool FDPOBNDIIOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F41370", Offset = "0x2F40370", VA = "0x182F41370")]
	public int KKPGOACFPCF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F41040", Offset = "0x2F40040", VA = "0x182F41040")]
	public void EDJKBOOFACN(out MJAAECDDOGI EEJBLKOHFLB, out MJAAECDDOGI GMMBMBDGGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F41320", Offset = "0x2F40320", VA = "0x182F41320")]
	public bool JKGJEJNBADL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F40FE0", Offset = "0x2F3FFE0", VA = "0x182F40FE0")]
	public double BMNJAHFFOPC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2F41260", Offset = "0x2F40260", VA = "0x182F41260")]
	public static int FPOEELGKNCM(int GEPMDHMJIMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F414D0", Offset = "0x2F404D0", VA = "0x182F414D0")]
	public static double ONIDFDGFKOB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F41190", Offset = "0x2F40190", VA = "0x182F41190")]
	public static ulong EEKHELFIHKF(MJAAECDDOGI NLMAHBHIEAO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct OGONCOOFFMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint ELFAGFAOOAK;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D130", Offset = "0x1F6C130", VA = "0x181F6D130")]
	public OGONCOOFFMJ(float CKFIOBCMGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F43CD0", Offset = "0x2F42CD0", VA = "0x182F43CD0")]
	public MJAAECDDOGI NMGPJFNPIHL()
	{
		return default(MJAAECDDOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x84B200", Offset = "0x84A200", VA = "0x18084B200")]
	public uint CLILIAAHFDG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F43CB0", Offset = "0x2F42CB0", VA = "0x182F43CB0")]
	public int KNBGDMDEKOA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F43B20", Offset = "0x2F42B20", VA = "0x182F43B20")]
	public uint CLLCFELPBLC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F43B10", Offset = "0x2F42B10", VA = "0x182F43B10")]
	public bool BIEIDCGNMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F43B40", Offset = "0x2F42B40", VA = "0x182F43B40")]
	public void EDJKBOOFACN(out MJAAECDDOGI EEJBLKOHFLB, out MJAAECDDOGI GMMBMBDGGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F43C70", Offset = "0x2F42C70", VA = "0x182F43C70")]
	public bool JKGJEJNBADL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct FLLPLOAGOFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong JPAICIMKEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short FHDIMGOEGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short NIEPEDEKBJI;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x37343D0", Offset = "0x37333D0", VA = "0x1837343D0")]
	public FLLPLOAGOFJ(ulong JPAICIMKEDD, short FHDIMGOEGFE, short NIEPEDEKBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class DHNHHANIBAK
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly FLLPLOAGOFJ[] JMDGICICPKB;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x372CAD0", Offset = "0x372BAD0", VA = "0x18372CAD0")]
	public static void HBBICMCPNBJ(int PJDFDPELKGK, int BNMBMCNFFCA, out MJAAECDDOGI NJJIBGNJKOO, out int NIEPEDEKBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x372C9D0", Offset = "0x372B9D0", VA = "0x18372C9D0")]
	public static void ELOLCHMIODK(int MNGAEJGJBAM, out MJAAECDDOGI NJJIBGNJKOO, out int AMNODNAOOPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct HMLAOILFIPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] KCNDJOGONOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int DOAOIAFHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int OKLOEALCJIF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte HLNIIBDGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F34AA0", Offset = "0x2F33AA0", VA = "0x182F34AA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x9996E0", Offset = "0x9986E0", VA = "0x1809996E0")]
	public HMLAOILFIPO(byte[] KCNDJOGONOI, int DOAOIAFHHOJ, int MBJMKPGFPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x84B1C0", Offset = "0x84A1C0", VA = "0x18084B1C0")]
	public int MBJMKPGFPJP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F34AE0", Offset = "0x2F33AE0", VA = "0x182F34AE0")]
	public HMLAOILFIPO OPEPKMPHHFH(int IIEIEHBCHDF, int ACHDDKFEDIN)
	{
		return default(HMLAOILFIPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class NPKBBMEACJC
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] PFPHNAHMPFM;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] GBKCIBECMKE;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int ENMNDMDKDBO;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F42710", Offset = "0x2F41710", VA = "0x182F42710")]
	private static byte[] IHPLCFODKIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F427F0", Offset = "0x2F417F0", VA = "0x182F427F0")]
	private static HMLAOILFIPO IKIEJHEDDCP(HMLAOILFIPO EHKCNAODFJD)
	{
		return default(HMLAOILFIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F42100", Offset = "0x2F41100", VA = "0x182F42100")]
	private static HMLAOILFIPO ENHGPICBNEN(HMLAOILFIPO EHKCNAODFJD)
	{
		return default(HMLAOILFIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F41930", Offset = "0x2F40930", VA = "0x182F41930")]
	private static void AAIPGJKJCGH(HMLAOILFIPO EHKCNAODFJD, int FBPHPJCBEIK, byte[] KCMKMGBNLHI, out int FLIDLKKJGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F42EB0", Offset = "0x2F41EB0", VA = "0x182F42EB0")]
	private static void MBNBOLIKLGN(HMLAOILFIPO EHKCNAODFJD, int FBPHPJCBEIK, byte[] NHKINIMHHJE, int IKIMHPDELLG, out HMLAOILFIPO DENIEDNCNAB, out int OONLBBNDECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F431D0", Offset = "0x2F421D0", VA = "0x182F431D0")]
	private static ulong MOBBBFCEFME(HMLAOILFIPO EHKCNAODFJD, out int KKLLBOFPGJB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F425A0", Offset = "0x2F415A0", VA = "0x182F425A0")]
	private static void HOJHFGDPMCO(HMLAOILFIPO EHKCNAODFJD, out MJAAECDDOGI IMDEFJLGKKO, out int FNKOLNFAHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F419E0", Offset = "0x2F409E0", VA = "0x182F419E0")]
	private static bool AKGMPKKBBMJ(HMLAOILFIPO DENIEDNCNAB, int FBPHPJCBEIK, out double IMDEFJLGKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F41F60", Offset = "0x2F40F60", VA = "0x182F41F60")]
	private static MJAAECDDOGI DGNCNCBJALN(int FBPHPJCBEIK)
	{
		return default(MJAAECDDOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F428D0", Offset = "0x2F418D0", VA = "0x182F428D0")]
	private static bool ILAGNLLCPFB(HMLAOILFIPO EHKCNAODFJD, int FBPHPJCBEIK, out double IMDEFJLGKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F42470", Offset = "0x2F41470", VA = "0x182F42470")]
	private static bool GNGHDADKFID(HMLAOILFIPO DENIEDNCNAB, int FBPHPJCBEIK, out double GDHCKHKPMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F41E30", Offset = "0x2F40E30", VA = "0x182F41E30")]
	public static double? COHDFDBKOHI(HMLAOILFIPO EHKCNAODFJD, int FBPHPJCBEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F421E0", Offset = "0x2F411E0", VA = "0x182F421E0")]
	public static float? FCIJDJGFBLH(HMLAOILFIPO EHKCNAODFJD, int FBPHPJCBEIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct FEMLBMJJMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] EHKCNAODFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int DCGIMNLMJDB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3733E50", Offset = "0x3732E50", VA = "0x183733E50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9CD790", Offset = "0x9CC790", VA = "0x1809CD790")]
	public FEMLBMJJMAC(byte[] EHKCNAODFJD, int DCGIMNLMJDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3733D60", Offset = "0x3732D60", VA = "0x183733D60")]
	public static FEMLBMJJMAC DOGACGLPMFK(FEMLBMJJMAC LDOMHDGLEOC)
	{
		return default(FEMLBMJJMAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3733DF0", Offset = "0x3732DF0", VA = "0x183733DF0")]
	public static FEMLBMJJMAC MCAPNMFNAKO(FEMLBMJJMAC LDOMHDGLEOC, int MBJMKPGFPJP)
	{
		return default(FEMLBMJJMAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3733C00", Offset = "0x3732C00", VA = "0x183733C00")]
	public static int BDFKJFNDJGN(FEMLBMJJMAC AFNKBCIFFBF, FEMLBMJJMAC DICKNDOEJLF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x3733D00", Offset = "0x3732D00", VA = "0x183733D00")]
	public static bool DNOCHJMHJKB(FEMLBMJJMAC AFNKBCIFFBF, FEMLBMJJMAC DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x3733C20", Offset = "0x3732C20", VA = "0x183733C20")]
	public static bool CNDCGAMMGJE(FEMLBMJJMAC AFNKBCIFFBF, FEMLBMJJMAC DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3733D20", Offset = "0x3732D20", VA = "0x183733D20")]
	public static bool DNOCHJMHJKB(FEMLBMJJMAC AFNKBCIFFBF, char DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3733C40", Offset = "0x3732C40", VA = "0x183733C40")]
	public static bool CNDCGAMMGJE(FEMLBMJJMAC AFNKBCIFFBF, char DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3733C40", Offset = "0x3732C40", VA = "0x183733C40")]
	public static bool CNDCGAMMGJE(FEMLBMJJMAC AFNKBCIFFBF, byte DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3733C80", Offset = "0x3732C80", VA = "0x183733C80")]
	public static bool DICKGKHDELM(FEMLBMJJMAC AFNKBCIFFBF, char DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3733D70", Offset = "0x3732D70", VA = "0x183733D70")]
	public static bool EDPNKNJDBLH(FEMLBMJJMAC AFNKBCIFFBF, char DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3733CC0", Offset = "0x3732CC0", VA = "0x183733CC0")]
	public static bool DIGGCBOBGPB(FEMLBMJJMAC AFNKBCIFFBF, char DICKNDOEJLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3733DB0", Offset = "0x3732DB0", VA = "0x183733DB0")]
	public static bool HNBDNMGPHIF(FEMLBMJJMAC AFNKBCIFFBF, char DICKNDOEJLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class FNHCCFKMLNB
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CGMFBGGOJDA;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] FHKIAIMHMMB;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] NBGKMEKLFGL;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] CBCLFHPPFDM;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] KNKBBGHCPLP;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int OGIGGEACCCH;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] ACKECBONOGK;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int NONFHICMHIC;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3734C60", Offset = "0x3733C60", VA = "0x183734C60")]
	private static byte[] DHKIACHMLMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x37352F0", Offset = "0x37342F0", VA = "0x1837352F0")]
	private static byte[] ODBNIEMHDNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3734D40", Offset = "0x3733D40", VA = "0x183734D40")]
	public static double HKMHDAKFFNJ(byte[] EHKCNAODFJD, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3734E60", Offset = "0x3733E60", VA = "0x183734E60")]
	public static float IONOHPGIDFM(byte[] EHKCNAODFJD, int DCGIMNLMJDB, out int OOINDEJGPPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3735040", Offset = "0x3734040", VA = "0x183735040")]
	private static bool MELDOHDMMBI(int JBEHFGFFAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x37351C0", Offset = "0x37341C0", VA = "0x1837351C0")]
	private static bool NBAHHOBFDPO(ref FEMLBMJJMAC IHOBEEKOBBP, FEMLBMJJMAC KANEENJPAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3734F20", Offset = "0x3733F20", VA = "0x183734F20")]
	private static bool LONPBIOBPOI(ref FEMLBMJJMAC IHOBEEKOBBP, FEMLBMJJMAC KANEENJPAME, byte[] COJNADKOJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x3734E00", Offset = "0x3733E00", VA = "0x183734E00")]
	private static bool HMIDJJLABEH(ref FEMLBMJJMAC KFEJCLHODGF, byte[] GMLEIGNAEGC, int DCGIMNLMJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xED1A70", Offset = "0xED0A70", VA = "0x180ED1A70")]
	private static double BEMKLDHGLCM(bool BEOHDJLKLDH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x37353D0", Offset = "0x37343D0", VA = "0x1837353D0")]
	private static double OIIIPOPICBK(FEMLBMJJMAC BBOCBNILHJP, int MBJMKPGFPJP, bool HAOHNNOGKNL, out int DEOKLBLFDLL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class PJLALNHAGML<T> : global::IILEDKIHCHA<T[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::DFGACPJEMOI<T> NNFCBHOLBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly LFNDDKGMOOG BNMIAHOCCJO;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x398F9C0", Offset = "0x398E9C0", VA = "0x18398F9C0")]
	public PJLALNHAGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1E52950", Offset = "0x1E51950", VA = "0x181E52950")]
	public PJLALNHAGML(LFNDDKGMOOG BNMIAHOCCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x398CE80", Offset = "0x398BE80", VA = "0x18398CE80", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, T[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x398E3A0", Offset = "0x398D3A0", VA = "0x18398E3A0", Slot = "5")]
	public T[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class HFGALLONPMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::DFGACPJEMOI<T> NNFCBHOLBJK;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class ACNFCOHCLOC<T> : global::IILEDKIHCHA<List<T>>, BFICKKJBGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly LFNDDKGMOOG BNMIAHOCCJO;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x398F9C0", Offset = "0x398E9C0", VA = "0x18398F9C0")]
	public ACNFCOHCLOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1E52950", Offset = "0x1E51950", VA = "0x181E52950")]
	public ACNFCOHCLOC(LFNDDKGMOOG BNMIAHOCCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7DE0", Offset = "0x3EE6DE0", VA = "0x183EE7DE0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, List<T> BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE9230", Offset = "0x3EE8230", VA = "0x183EE9230", Slot = "5")]
	public List<T> EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class JKCLJJPJFIN<TElement, TIntermediate, TEnumerator, TCollection> : global::IILEDKIHCHA<TCollection>, BFICKKJBGKE where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x42B7D50", Offset = "0x42B6D50", VA = "0x1842B7D50", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, TCollection BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x42B9820", Offset = "0x42B8820", VA = "0x1842B9820", Slot = "5")]
	public TCollection EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LAGMBMCGKLD(TCollection AKBGILOFPBF);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GJHMDGALCIL();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NJFAMEHLCGO(ref TIntermediate LBGIENGPHHC, int FBOCJCCNMND, TElement BMNJAHFFOPC);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NAFAAPPDJFF(ref TIntermediate BHOAMBBGDHB);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
	protected JKCLJJPJFIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class EDEJANPMAKM<TElement, TIntermediate, TCollection> : global::JKCLJJPJFIN<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0670", Offset = "0x2ECF670", VA = "0x182ED0670", Slot = "6")]
	protected override IEnumerator<TElement> LAGMBMCGKLD(TCollection AKBGILOFPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1FF40D0", Offset = "0x1FF30D0", VA = "0x181FF40D0")]
	protected EDEJANPMAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class JFBIDGFLAPH<TElement, TCollection> : global::EDEJANPMAKM<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected sealed override TCollection NAFAAPPDJFF(ref TCollection BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class DCNHMOPBHMA<TElement, TCollection> : global::JFBIDGFLAPH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6380", Offset = "0x3DC5380", VA = "0x183DC6380", Slot = "7")]
	protected override TCollection GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3DC63A0", Offset = "0x3DC53A0", VA = "0x183DC63A0", Slot = "8")]
	protected override void NJFAMEHLCGO(ref TCollection LBGIENGPHHC, int FBOCJCCNMND, TElement BMNJAHFFOPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NHFDDLANMND<T> : global::JKCLJJPJFIN<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B80", Offset = "0x2ECFB80", VA = "0x182ED0B80", Slot = "8")]
	protected override void NJFAMEHLCGO(ref LinkedList<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override LinkedList<T> NAFAAPPDJFF(ref LinkedList<T> BHOAMBBGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override LinkedList<T> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3832210", Offset = "0x3831210", VA = "0x183832210", Slot = "6")]
	protected override LinkedList<T>.Enumerator LAGMBMCGKLD(LinkedList<T> AKBGILOFPBF)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class JPKJGDCCPBP<T> : global::JKCLJJPJFIN<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B80", Offset = "0x2ECFB80", VA = "0x182ED0B80", Slot = "8")]
	protected override void NJFAMEHLCGO(ref Queue<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override Queue<T> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B30", Offset = "0x2ECFB30", VA = "0x182ED0B30", Slot = "6")]
	protected override Queue<T>.Enumerator LAGMBMCGKLD(Queue<T> AKBGILOFPBF)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override Queue<T> NAFAAPPDJFF(ref Queue<T> BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class GDHLDLPFCAJ<T> : global::JKCLJJPJFIN<T, global::HMLGNBCIJFG<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2E50A10", Offset = "0x2E4FA10", VA = "0x182E50A10", Slot = "8")]
	protected override void NJFAMEHLCGO(ref global::HMLGNBCIJFG<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2E509A0", Offset = "0x2E4F9A0", VA = "0x182E509A0", Slot = "7")]
	protected override global::HMLGNBCIJFG<T> GJHMDGALCIL()
	{
		return default(global::HMLGNBCIJFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B30", Offset = "0x2ECFB30", VA = "0x182ED0B30", Slot = "6")]
	protected override Stack<T>.Enumerator LAGMBMCGKLD(Stack<T> AKBGILOFPBF)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x369F4F0", Offset = "0x369E4F0", VA = "0x18369F4F0", Slot = "9")]
	protected override Stack<T> NAFAAPPDJFF(ref global::HMLGNBCIJFG<T> BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class BAGBBEHGFEM<T> : global::JKCLJJPJFIN<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B80", Offset = "0x2ECFB80", VA = "0x182ED0B80", Slot = "8")]
	protected override void NJFAMEHLCGO(ref HashSet<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override HashSet<T> NAFAAPPDJFF(ref HashSet<T> BHOAMBBGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override HashSet<T> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B30", Offset = "0x2ECFB30", VA = "0x182ED0B30", Slot = "6")]
	protected override HashSet<T>.Enumerator LAGMBMCGKLD(HashSet<T> AKBGILOFPBF)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OFFLFILOAPH<T> : global::EDEJANPMAKM<T, global::HMLGNBCIJFG<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2E50A10", Offset = "0x2E4FA10", VA = "0x182E50A10", Slot = "8")]
	protected override void NJFAMEHLCGO(ref global::HMLGNBCIJFG<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4A86B00", Offset = "0x4A85B00", VA = "0x184A86B00", Slot = "9")]
	protected override ReadOnlyCollection<T> NAFAAPPDJFF(ref global::HMLGNBCIJFG<T> BHOAMBBGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4A86AB0", Offset = "0x4A85AB0", VA = "0x184A86AB0", Slot = "7")]
	protected override global::HMLGNBCIJFG<T> GJHMDGALCIL()
	{
		return default(global::HMLGNBCIJFG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class IOEIOJONDHK<T> : global::EDEJANPMAKM<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B80", Offset = "0x2ECFB80", VA = "0x182ED0B80", Slot = "8")]
	protected override void NJFAMEHLCGO(ref List<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override List<T> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override IList<T> NAFAAPPDJFF(ref List<T> BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GIHCDGBMEFH<T> : global::EDEJANPMAKM<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B80", Offset = "0x2ECFB80", VA = "0x182ED0B80", Slot = "8")]
	protected override void NJFAMEHLCGO(ref List<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override List<T> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override ICollection<T> NAFAAPPDJFF(ref List<T> BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class AEGLLFIPHJJ<T> : global::EDEJANPMAKM<T, global::HMLGNBCIJFG<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2E50A10", Offset = "0x2E4FA10", VA = "0x182E50A10", Slot = "8")]
	protected override void NJFAMEHLCGO(ref global::HMLGNBCIJFG<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2E509A0", Offset = "0x2E4F9A0", VA = "0x182E509A0", Slot = "7")]
	protected override global::HMLGNBCIJFG<T> GJHMDGALCIL()
	{
		return default(global::HMLGNBCIJFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2E509F0", Offset = "0x2E4F9F0", VA = "0x182E509F0", Slot = "9")]
	protected override IEnumerable<T> NAFAAPPDJFF(ref global::HMLGNBCIJFG<T> BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class LKFHKMOJIPI<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class BGOKKHINFIJ<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class ACPKKHCBDLM<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class DEMKHACHEJL : global::IILEDKIHCHA<IEnumerable>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::IILEDKIHCHA<IEnumerable> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x372C590", Offset = "0x372B590", VA = "0x18372C590", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, IEnumerable BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x372C780", Offset = "0x372B780", VA = "0x18372C780", Slot = "5")]
	public IEnumerable EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public DEMKHACHEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class PBPHPEOCJJD : global::IILEDKIHCHA<ICollection>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::IILEDKIHCHA<ICollection> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5040", Offset = "0x4CD4040", VA = "0x184CD5040", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ICollection BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD52E0", Offset = "0x4CD42E0", VA = "0x184CD52E0", Slot = "5")]
	public ICollection EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public PBPHPEOCJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GGLKMCICPNL : global::IILEDKIHCHA<IList>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::IILEDKIHCHA<IList> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3736DE0", Offset = "0x3735DE0", VA = "0x183736DE0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, IList BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3737080", Offset = "0x3736080", VA = "0x183737080", Slot = "5")]
	public IList EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public GGLKMCICPNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class DBMLGEGABIA<T> : global::EDEJANPMAKM<T, global::HMLGNBCIJFG<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2550", Offset = "0x3DC1550", VA = "0x183DC2550", Slot = "8")]
	protected override void NJFAMEHLCGO(ref global::HMLGNBCIJFG<T> LBGIENGPHHC, int FBOCJCCNMND, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2E509A0", Offset = "0x2E4F9A0", VA = "0x182E509A0", Slot = "7")]
	protected override global::HMLGNBCIJFG<T> GJHMDGALCIL()
	{
		return default(global::HMLGNBCIJFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2510", Offset = "0x3DC1510", VA = "0x183DC2510", Slot = "9")]
	protected override IReadOnlyList<T> NAFAAPPDJFF(ref global::HMLGNBCIJFG<T> BHOAMBBGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B2D0", Offset = "0x1E4A2D0", VA = "0x181E4B2D0")]
	public DBMLGEGABIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class NLPLGDKPAMA
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2F41890", Offset = "0x2F40890", VA = "0x182F41890")]
	public static DateTime FDNMNJDHEIC(DateTime JHBDGNDOCCN)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OJADDPBGHCD : global::IILEDKIHCHA<DateTime>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::IILEDKIHCHA<DateTime> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4CD26C0", Offset = "0x4CD16C0", VA = "0x184CD26C0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, DateTime BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2B10", Offset = "0x4CD1B10", VA = "0x184CD2B10", Slot = "5")]
	public DateTime EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public OJADDPBGHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class JJHBDOOCHHF : global::IILEDKIHCHA<DateTimeOffset>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::IILEDKIHCHA<DateTimeOffset> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2F36200", Offset = "0x2F35200", VA = "0x182F36200", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, DateTimeOffset BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2F36DC0", Offset = "0x2F35DC0", VA = "0x182F36DC0", Slot = "5")]
	public DateTimeOffset EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public JJHBDOOCHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class LLNCNIOADAA : global::IILEDKIHCHA<TimeSpan>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::IILEDKIHCHA<TimeSpan> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] JJDIPDGBGJM;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2F3E2C0", Offset = "0x2F3D2C0", VA = "0x182F3E2C0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, TimeSpan BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2F3E760", Offset = "0x2F3D760", VA = "0x182F3E760", Slot = "5")]
	public TimeSpan EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public LLNCNIOADAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class DCINHCCNCBF<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::IILEDKIHCHA<TDictionary>, BFICKKJBGKE where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3CA0", Offset = "0x3DC2CA0", VA = "0x183DC3CA0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, TDictionary BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6010", Offset = "0x3DC5010", VA = "0x183DC6010", Slot = "5")]
	public TDictionary EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LAGMBMCGKLD(TDictionary AKBGILOFPBF);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GJHMDGALCIL();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NJFAMEHLCGO(ref TIntermediate LBGIENGPHHC, int FBOCJCCNMND, TKey DDFHJDPPNBF, TValue BMNJAHFFOPC);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NAFAAPPDJFF(ref TIntermediate BHOAMBBGDHB);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
	protected DCINHCCNCBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class AOLAHJBGNLE<TKey, TValue, TIntermediate, TDictionary> : global::DCINHCCNCBF<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0670", Offset = "0x2ECF670", VA = "0x182ED0670", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> LAGMBMCGKLD(TDictionary AKBGILOFPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class ICCGOECELMD<TKey, TValue, TDictionary> : global::AOLAHJBGNLE<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override TDictionary NAFAAPPDJFF(ref TDictionary BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class OADBHNHBOBH<TKey, TValue> : global::DCINHCCNCBF<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4A855D0", Offset = "0x4A845D0", VA = "0x184A855D0", Slot = "8")]
	protected override void NJFAMEHLCGO(ref Dictionary<TKey, TValue> LBGIENGPHHC, int FBOCJCCNMND, TKey DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override Dictionary<TKey, TValue> NAFAAPPDJFF(ref Dictionary<TKey, TValue> BHOAMBBGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override Dictionary<TKey, TValue> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x4A85580", Offset = "0x4A84580", VA = "0x184A85580", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator LAGMBMCGKLD(Dictionary<TKey, TValue> AKBGILOFPBF)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F550", Offset = "0x1E4E550", VA = "0x181E4F550")]
	public OADBHNHBOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class IGCACIJDOJC<TKey, TValue, TDictionary> : global::ICCGOECELMD<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3760FB0", Offset = "0x375FFB0", VA = "0x183760FB0", Slot = "8")]
	protected override void NJFAMEHLCGO(ref TDictionary LBGIENGPHHC, int FBOCJCCNMND, TKey DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x29F9C80", Offset = "0x29F8C80", VA = "0x1829F9C80", Slot = "7")]
	protected override TDictionary GJHMDGALCIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class COIBJDMBLJK<TKey, TValue> : global::AOLAHJBGNLE<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x20A10A0", Offset = "0x20A00A0", VA = "0x1820A10A0", Slot = "8")]
	protected override void NJFAMEHLCGO(ref Dictionary<TKey, TValue> LBGIENGPHHC, int FBOCJCCNMND, TKey DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override Dictionary<TKey, TValue> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override IDictionary<TKey, TValue> NAFAAPPDJFF(ref Dictionary<TKey, TValue> BHOAMBBGDHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MFHKPAPCFIB<TKey, TValue> : global::ICCGOECELMD<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x20A10A0", Offset = "0x20A00A0", VA = "0x1820A10A0", Slot = "8")]
	protected override void NJFAMEHLCGO(ref SortedList<TKey, TValue> LBGIENGPHHC, int FBOCJCCNMND, TKey DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override SortedList<TKey, TValue> GJHMDGALCIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class FDNDKMNPAIF<TKey, TValue> : global::DCINHCCNCBF<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x20A10A0", Offset = "0x20A00A0", VA = "0x1820A10A0", Slot = "8")]
	protected override void NJFAMEHLCGO(ref SortedDictionary<TKey, TValue> LBGIENGPHHC, int FBOCJCCNMND, TKey DDFHJDPPNBF, TValue BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xE82400", Offset = "0xE81400", VA = "0x180E82400", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NAFAAPPDJFF(ref SortedDictionary<TKey, TValue> BHOAMBBGDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x20A1040", Offset = "0x20A0040", VA = "0x1820A1040", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GJHMDGALCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x4274420", Offset = "0x4273420", VA = "0x184274420", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator LAGMBMCGKLD(SortedDictionary<TKey, TValue> AKBGILOFPBF)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class KFKEEPDCKJL<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class AHMHEJBEDDE : global::IILEDKIHCHA<IDictionary>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::IILEDKIHCHA<IDictionary> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3726470", Offset = "0x3725470", VA = "0x183726470", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, IDictionary BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x37267F0", Offset = "0x37257F0", VA = "0x1837267F0", Slot = "5")]
	public IDictionary EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public AHMHEJBEDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class HGBGKEBEEIH : global::IILEDKIHCHA<object>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void GANPJLAOLKF(object KNOELFDANOL, ref LGEMHOFFGMB GLHNDGPACHE, object BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::FDCMINDICFO<KeyValuePair<object, GANPJLAOLKF>> BBGJMDBEHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly OLHFHKDPOLA[] BENFOCJGBGI;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2F329B0", Offset = "0x2F319B0", VA = "0x182F329B0")]
	public HGBGKEBEEIH(params OLHFHKDPOLA[] BENFOCJGBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2F32060", Offset = "0x2F31060", VA = "0x182F32060", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, object BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2F328B0", Offset = "0x2F318B0", VA = "0x182F328B0", Slot = "5")]
	public object EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class FCDBICHMMGC
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3733180", Offset = "0x3732180", VA = "0x183733180")]
	public static object JFHDIJKDNNN(Type GOKHKCCNGMD, out bool KDFGFNOONMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x37329A0", Offset = "0x37319A0", VA = "0x1837329A0")]
	public static object GJGCIMIMBCH(Type GOKHKCCNGMD, out bool KDFGFNOONMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class ACBNOLADLPA<T> : global::IILEDKIHCHA<T>, BFICKKJBGKE, global::IKDCOJFJNJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class KHDAFLMNELP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public KHDAFLMNELP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x414B710", Offset = "0x414A710", VA = "0x18414B710")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class DDHPBOKKBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::DEODDHPBEBD<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public DDHPBOKKBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4145720", Offset = "0x4144720", VA = "0x184145720")]
		internal void <.cctor>b__1(ref LGEMHOFFGMB writer, T value, OLHFHKDPOLA _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class NPNLOFOGJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::JJPOJDECOPH<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public NPNLOFOGJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x41509E0", Offset = "0x414F9E0", VA = "0x1841509E0")]
		internal T <.cctor>b__2(ref EIPKCMBENFK reader, OLHFHKDPOLA _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::AKPDJJJNDOE<T> JFEBHCANALD;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> DOMGAGCJPDO;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::DEODDHPBEBD<T> GCCGCIGGPCN;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::JJPOJDECOPH<T> BJBAHJADEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool CDDNEKANKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::DEODDHPBEBD<T> GABDEPDICHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::JJPOJDECOPH<T> ELJFMHPGJJE;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x4142390", Offset = "0x4141390", VA = "0x184142390")]
	static ACBNOLADLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7CB0", Offset = "0x3EE6CB0", VA = "0x183EE7CB0")]
	public ACBNOLADLPA(bool CDDNEKANKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x413D410", Offset = "0x413C410", VA = "0x18413D410", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, T BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x413E8D0", Offset = "0x413D8D0", VA = "0x18413E8D0", Slot = "5")]
	public T EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2CA0", Offset = "0x3EE1CA0", VA = "0x183EE2CA0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, T BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x413F5B0", Offset = "0x413E5B0", VA = "0x18413F5B0", Slot = "7")]
	public T NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class JJHCGNAOBOF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class HFEEBJBENOH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EFOJONFKOJN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class OMNPBFBCNFH<T> : global::IILEDKIHCHA<T?>, BFICKKJBGKE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x458A600", Offset = "0x4589600", VA = "0x18458A600", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, T? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x458A8B0", Offset = "0x45898B0", VA = "0x18458A8B0", Slot = "5")]
	public T? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
	public OMNPBFBCNFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class ECHNNDAEGDL<T> : global::IILEDKIHCHA<T?>, BFICKKJBGKE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::IILEDKIHCHA<T> KCHIFKDLPHK;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x214B810", Offset = "0x214A810", VA = "0x18214B810")]
	public ECHNNDAEGDL(global::IILEDKIHCHA<T> KCHIFKDLPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC37A0", Offset = "0x3BC27A0", VA = "0x183BC37A0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, T? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4770", Offset = "0x3BC3770", VA = "0x183BC4770", Slot = "5")]
	public T? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class PGIOCEOCPLI : global::IILEDKIHCHA<sbyte>, BFICKKJBGKE, global::IKDCOJFJNJJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly PGIOCEOCPLI LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4CD60E0", Offset = "0x4CD50E0", VA = "0x184CD60E0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, sbyte BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6100", Offset = "0x4CD5100", VA = "0x184CD6100", Slot = "5")]
	public sbyte EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6110", Offset = "0x4CD5110", VA = "0x184CD6110", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, sbyte BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6150", Offset = "0x4CD5150", VA = "0x184CD6150", Slot = "7")]
	public sbyte NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public PGIOCEOCPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class GJFBMIADMPG : global::IILEDKIHCHA<sbyte?>, BFICKKJBGKE, global::IKDCOJFJNJJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly GJFBMIADMPG LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3737410", Offset = "0x3736410", VA = "0x183737410", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, sbyte? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3737480", Offset = "0x3736480", VA = "0x183737480", Slot = "5")]
	public sbyte? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3737530", Offset = "0x3736530", VA = "0x183737530", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, sbyte? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x37375B0", Offset = "0x37365B0", VA = "0x1837375B0", Slot = "7")]
	public sbyte? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public GJFBMIADMPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class HAOJBIHEHMG : global::IILEDKIHCHA<sbyte[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly HAOJBIHEHMG LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3737AF0", Offset = "0x3736AF0", VA = "0x183737AF0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, sbyte[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x3737BB0", Offset = "0x3736BB0", VA = "0x183737BB0", Slot = "5")]
	public sbyte[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public HAOJBIHEHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class OILAAAJBPLA : global::IILEDKIHCHA<short>, BFICKKJBGKE, global::IKDCOJFJNJJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly OILAAAJBPLA LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4CD14F0", Offset = "0x4CD04F0", VA = "0x184CD14F0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, short BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1510", Offset = "0x4CD0510", VA = "0x184CD1510", Slot = "5")]
	public short EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1520", Offset = "0x4CD0520", VA = "0x184CD1520", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, short BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1560", Offset = "0x4CD0560", VA = "0x184CD1560", Slot = "7")]
	public short NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public OILAAAJBPLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class GOKIJCMMCHI : global::IILEDKIHCHA<short?>, BFICKKJBGKE, global::IKDCOJFJNJJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly GOKIJCMMCHI LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x37376C0", Offset = "0x37366C0", VA = "0x1837376C0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, short? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3737730", Offset = "0x3736730", VA = "0x183737730", Slot = "5")]
	public short? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x37377E0", Offset = "0x37367E0", VA = "0x1837377E0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, short? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3737860", Offset = "0x3736860", VA = "0x183737860", Slot = "7")]
	public short? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public GOKIJCMMCHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class JGLNDDHJNME : global::IILEDKIHCHA<short[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly JGLNDDHJNME LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F35EC0", Offset = "0x2F34EC0", VA = "0x182F35EC0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, short[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F36060", Offset = "0x2F35060", VA = "0x182F36060", Slot = "5")]
	public short[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public JGLNDDHJNME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LFLLGEFMDHF : global::IILEDKIHCHA<int>, BFICKKJBGKE, global::IKDCOJFJNJJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LFLLGEFMDHF LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A4D0", Offset = "0x2F394D0", VA = "0x182F3A4D0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, int BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A500", Offset = "0x2F39500", VA = "0x182F3A500", Slot = "5")]
	public int EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A510", Offset = "0x2F39510", VA = "0x182F3A510", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, int BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A5D0", Offset = "0x2F395D0", VA = "0x182F3A5D0", Slot = "7")]
	public int NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public LFLLGEFMDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class PDICFPECECE : global::IILEDKIHCHA<int?>, BFICKKJBGKE, global::IKDCOJFJNJJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly PDICFPECECE LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4CD54C0", Offset = "0x4CD44C0", VA = "0x184CD54C0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, int? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5530", Offset = "0x4CD4530", VA = "0x184CD5530", Slot = "5")]
	public int? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4CD55A0", Offset = "0x4CD45A0", VA = "0x184CD55A0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, int? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5620", Offset = "0x4CD4620", VA = "0x184CD5620", Slot = "7")]
	public int? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public PDICFPECECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class MNIICACADON : global::IILEDKIHCHA<int[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MNIICACADON LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F40700", Offset = "0x2F3F700", VA = "0x182F40700", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, int[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F408A0", Offset = "0x2F3F8A0", VA = "0x182F408A0", Slot = "5")]
	public int[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public MNIICACADON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class EOJCMPNCHIH : global::IILEDKIHCHA<long>, BFICKKJBGKE, global::IKDCOJFJNJJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly EOJCMPNCHIH LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x37326D0", Offset = "0x37316D0", VA = "0x1837326D0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, long BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x37326F0", Offset = "0x37316F0", VA = "0x1837326F0", Slot = "5")]
	public long EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3732700", Offset = "0x3731700", VA = "0x183732700", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, long BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3732740", Offset = "0x3731740", VA = "0x183732740", Slot = "7")]
	public long NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EOJCMPNCHIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class FJLCKODGIKA : global::IILEDKIHCHA<long?>, BFICKKJBGKE, global::IKDCOJFJNJJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly FJLCKODGIKA LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x37340D0", Offset = "0x37330D0", VA = "0x1837340D0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, long? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3734140", Offset = "0x3733140", VA = "0x183734140", Slot = "5")]
	public long? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x37341D0", Offset = "0x37331D0", VA = "0x1837341D0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, long? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3734250", Offset = "0x3733250", VA = "0x183734250", Slot = "7")]
	public long? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FJLCKODGIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class EDHDMCDAPKG : global::IILEDKIHCHA<long[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly EDHDMCDAPKG LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x372F390", Offset = "0x372E390", VA = "0x18372F390", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, long[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x372F450", Offset = "0x372E450", VA = "0x18372F450", Slot = "5")]
	public long[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EDHDMCDAPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class FIAIJCPOHIJ : global::IILEDKIHCHA<byte>, BFICKKJBGKE, global::IKDCOJFJNJJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly FIAIJCPOHIJ LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3733F40", Offset = "0x3732F40", VA = "0x183733F40", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, byte BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3733F60", Offset = "0x3732F60", VA = "0x183733F60", Slot = "5")]
	public byte EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3733FC0", Offset = "0x3732FC0", VA = "0x183733FC0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, byte BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3734000", Offset = "0x3733000", VA = "0x183734000", Slot = "7")]
	public byte NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIAIJCPOHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class NBFNMAAAHIN : global::IILEDKIHCHA<byte?>, BFICKKJBGKE, global::IKDCOJFJNJJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly NBFNMAAAHIN LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F40C10", Offset = "0x2F3FC10", VA = "0x182F40C10", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, byte? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F40C90", Offset = "0x2F3FC90", VA = "0x182F40C90", Slot = "5")]
	public byte? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F40D00", Offset = "0x2F3FD00", VA = "0x182F40D00", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, byte? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F40E00", Offset = "0x2F3FE00", VA = "0x182F40E00", Slot = "7")]
	public byte? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public NBFNMAAAHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class EPNGBMLDKNH : global::IILEDKIHCHA<ushort>, BFICKKJBGKE, global::IKDCOJFJNJJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly EPNGBMLDKNH LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3732810", Offset = "0x3731810", VA = "0x183732810", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ushort BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3732830", Offset = "0x3731830", VA = "0x183732830", Slot = "5")]
	public ushort EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3732890", Offset = "0x3731890", VA = "0x183732890", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, ushort BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x37328D0", Offset = "0x37318D0", VA = "0x1837328D0", Slot = "7")]
	public ushort NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EPNGBMLDKNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class PHHHIEOCILM : global::IILEDKIHCHA<ushort?>, BFICKKJBGKE, global::IKDCOJFJNJJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PHHHIEOCILM LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6220", Offset = "0x4CD5220", VA = "0x184CD6220", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ushort? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6290", Offset = "0x4CD5290", VA = "0x184CD6290", Slot = "5")]
	public ushort? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6300", Offset = "0x4CD5300", VA = "0x184CD6300", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, ushort? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4CD6380", Offset = "0x4CD5380", VA = "0x184CD6380", Slot = "7")]
	public ushort? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public PHHHIEOCILM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class BMHPMEOHDDF : global::IILEDKIHCHA<ushort[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly BMHPMEOHDDF LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3729CF0", Offset = "0x3728CF0", VA = "0x183729CF0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ushort[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3729DB0", Offset = "0x3728DB0", VA = "0x183729DB0", Slot = "5")]
	public ushort[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public BMHPMEOHDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JJKCFLLABIM : global::IILEDKIHCHA<uint>, BFICKKJBGKE, global::IKDCOJFJNJJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly JJKCFLLABIM LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F37D00", Offset = "0x2F36D00", VA = "0x182F37D00", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, uint BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F37D30", Offset = "0x2F36D30", VA = "0x182F37D30", Slot = "5")]
	public uint EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2F37D40", Offset = "0x2F36D40", VA = "0x182F37D40", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, uint BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F37E00", Offset = "0x2F36E00", VA = "0x182F37E00", Slot = "7")]
	public uint NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public JJKCFLLABIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class LJHKAKMLMEA : global::IILEDKIHCHA<uint?>, BFICKKJBGKE, global::IKDCOJFJNJJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly LJHKAKMLMEA LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D7B0", Offset = "0x2F3C7B0", VA = "0x182F3D7B0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, uint? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D830", Offset = "0x2F3C830", VA = "0x182F3D830", Slot = "5")]
	public uint? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D8A0", Offset = "0x2F3C8A0", VA = "0x182F3D8A0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, uint? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D9A0", Offset = "0x2F3C9A0", VA = "0x182F3D9A0", Slot = "7")]
	public uint? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public LJHKAKMLMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class MBEIMAKJAPG : global::IILEDKIHCHA<uint[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly MBEIMAKJAPG LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F890", Offset = "0x2F3E890", VA = "0x182F3F890", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, uint[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FA30", Offset = "0x2F3EA30", VA = "0x182F3FA30", Slot = "5")]
	public uint[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public MBEIMAKJAPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class OCADLHPAKJC : global::IILEDKIHCHA<ulong>, BFICKKJBGKE, global::IKDCOJFJNJJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly OCADLHPAKJC LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2F432F0", Offset = "0x2F422F0", VA = "0x182F432F0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ulong BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2F43320", Offset = "0x2F42320", VA = "0x182F43320", Slot = "5")]
	public ulong EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2F43330", Offset = "0x2F42330", VA = "0x182F43330", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, ulong BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2F433F0", Offset = "0x2F423F0", VA = "0x182F433F0", Slot = "7")]
	public ulong NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public OCADLHPAKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class PPCEKLDGBLC : global::IILEDKIHCHA<ulong?>, BFICKKJBGKE, global::IKDCOJFJNJJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PPCEKLDGBLC LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8570", Offset = "0x4CD7570", VA = "0x184CD8570", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ulong? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4CD85E0", Offset = "0x4CD75E0", VA = "0x184CD85E0", Slot = "5")]
	public ulong? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8670", Offset = "0x4CD7670", VA = "0x184CD8670", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, ulong? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4CD86F0", Offset = "0x4CD76F0", VA = "0x184CD86F0", Slot = "7")]
	public ulong? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public PPCEKLDGBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class BAPHGDBNAIM : global::IILEDKIHCHA<ulong[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly BAPHGDBNAIM LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3726C20", Offset = "0x3725C20", VA = "0x183726C20", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ulong[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3726CE0", Offset = "0x3725CE0", VA = "0x183726CE0", Slot = "5")]
	public ulong[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public BAPHGDBNAIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DJGEPFHINEH : global::IILEDKIHCHA<float>, BFICKKJBGKE, global::IKDCOJFJNJJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly DJGEPFHINEH LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x372E0C0", Offset = "0x372D0C0", VA = "0x18372E0C0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, float BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x372E0D0", Offset = "0x372D0D0", VA = "0x18372E0D0", Slot = "5")]
	public float EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x372E0E0", Offset = "0x372D0E0", VA = "0x18372E0E0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, float BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x372E120", Offset = "0x372D120", VA = "0x18372E120", Slot = "7")]
	public float NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public DJGEPFHINEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class GEDLHEIPPFI : global::IILEDKIHCHA<float?>, BFICKKJBGKE, global::IKDCOJFJNJJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly GEDLHEIPPFI LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x3736B80", Offset = "0x3735B80", VA = "0x183736B80", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, float? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x3736BF0", Offset = "0x3735BF0", VA = "0x183736BF0", Slot = "5")]
	public float? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3736C60", Offset = "0x3735C60", VA = "0x183736C60", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, float? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3736CE0", Offset = "0x3735CE0", VA = "0x183736CE0", Slot = "7")]
	public float? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public GEDLHEIPPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class HKGFPDCOPDJ : global::IILEDKIHCHA<float[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly HKGFPDCOPDJ LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2F34280", Offset = "0x2F33280", VA = "0x182F34280", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, float[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2F34460", Offset = "0x2F33460", VA = "0x182F34460", Slot = "5")]
	public float[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public HKGFPDCOPDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class MPHNOABOKNF : global::IILEDKIHCHA<double>, BFICKKJBGKE, global::IKDCOJFJNJJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly MPHNOABOKNF LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2F40A40", Offset = "0x2F3FA40", VA = "0x182F40A40", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, double BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2F40A50", Offset = "0x2F3FA50", VA = "0x182F40A50", Slot = "5")]
	public double EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2F40A60", Offset = "0x2F3FA60", VA = "0x182F40A60", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, double BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2F40B10", Offset = "0x2F3FB10", VA = "0x182F40B10", Slot = "7")]
	public double NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public MPHNOABOKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class EDDFHMHHGEL : global::IILEDKIHCHA<double?>, BFICKKJBGKE, global::IKDCOJFJNJJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly EDDFHMHHGEL LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x372F0F0", Offset = "0x372E0F0", VA = "0x18372F0F0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, double? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x372F160", Offset = "0x372E160", VA = "0x18372F160", Slot = "5")]
	public double? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x372F1F0", Offset = "0x372E1F0", VA = "0x18372F1F0", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, double? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x372F270", Offset = "0x372E270", VA = "0x18372F270", Slot = "7")]
	public double? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EDDFHMHHGEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class EAHDCFCKJMG : global::IILEDKIHCHA<double[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly EAHDCFCKJMG LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x372EA40", Offset = "0x372DA40", VA = "0x18372EA40", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, double[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x372EB00", Offset = "0x372DB00", VA = "0x18372EB00", Slot = "5")]
	public double[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EAHDCFCKJMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class ILFACLHEELE : global::IILEDKIHCHA<bool>, BFICKKJBGKE, global::IKDCOJFJNJJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly ILFACLHEELE LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2F35D10", Offset = "0x2F34D10", VA = "0x182F35D10", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, bool BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2F35D30", Offset = "0x2F34D30", VA = "0x182F35D30", Slot = "5")]
	public bool EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2F35D40", Offset = "0x2F34D40", VA = "0x182F35D40", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, bool BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2F35DF0", Offset = "0x2F34DF0", VA = "0x182F35DF0", Slot = "7")]
	public bool NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public ILFACLHEELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class CGFIGLNHDCL : global::IILEDKIHCHA<bool?>, BFICKKJBGKE, global::IKDCOJFJNJJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly CGFIGLNHDCL LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x372B880", Offset = "0x372A880", VA = "0x18372B880", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, bool? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x372B8F0", Offset = "0x372A8F0", VA = "0x18372B8F0", Slot = "5")]
	public bool? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x372B960", Offset = "0x372A960", VA = "0x18372B960", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, bool? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x372B9E0", Offset = "0x372A9E0", VA = "0x18372B9E0", Slot = "7")]
	public bool? NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public CGFIGLNHDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class BEEGEHJFHLD : global::IILEDKIHCHA<bool[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly BEEGEHJFHLD LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x3726EE0", Offset = "0x3725EE0", VA = "0x183726EE0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, bool[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x3726FB0", Offset = "0x3725FB0", VA = "0x183726FB0", Slot = "5")]
	public bool[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public BEEGEHJFHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class HJKGEJJGKNA : global::IILEDKIHCHA<object>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::IILEDKIHCHA<object> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> MLNDGFLMPJL;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2F33010", Offset = "0x2F32010", VA = "0x182F33010", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, object BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2F339C0", Offset = "0x2F329C0", VA = "0x182F339C0", Slot = "5")]
	public object EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public HJKGEJJGKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EEFAMMKLINE : global::IILEDKIHCHA<byte[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::IILEDKIHCHA<byte[]> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x372F6D0", Offset = "0x372E6D0", VA = "0x18372F6D0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, byte[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x372F760", Offset = "0x372E760", VA = "0x18372F760", Slot = "5")]
	public byte[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EEFAMMKLINE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class EJIOJGEHPDJ : global::IILEDKIHCHA<ArraySegment<byte>>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::IILEDKIHCHA<ArraySegment<byte>> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3732500", Offset = "0x3731500", VA = "0x183732500", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, ArraySegment<byte> BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x37325A0", Offset = "0x37315A0", VA = "0x1837325A0", Slot = "5")]
	public ArraySegment<byte> EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EJIOJGEHPDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class KCJOHJJDDKO : global::IILEDKIHCHA<string>, BFICKKJBGKE, global::IKDCOJFJNJJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::IILEDKIHCHA<string> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2F39C40", Offset = "0x2F38C40", VA = "0x182F39C40", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, string BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2F39C60", Offset = "0x2F38C60", VA = "0x182F39C60", Slot = "5")]
	public string EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2F39C40", Offset = "0x2F38C40", VA = "0x182F39C40", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, string BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2F39C60", Offset = "0x2F38C60", VA = "0x182F39C60", Slot = "7")]
	public string NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public KCJOHJJDDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KGEMMMNKKIF : global::IILEDKIHCHA<string[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly KGEMMMNKKIF LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2F39CD0", Offset = "0x2F38CD0", VA = "0x182F39CD0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, string[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2F39E50", Offset = "0x2F38E50", VA = "0x182F39E50", Slot = "5")]
	public string[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public KGEMMMNKKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class ACCHFIJPPHD : global::IILEDKIHCHA<char>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly ACCHFIJPPHD LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x3726130", Offset = "0x3725130", VA = "0x183726130", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, char BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x37261B0", Offset = "0x37251B0", VA = "0x1837261B0", Slot = "5")]
	public char EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public ACCHFIJPPHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class IKFCOEFPMMH : global::IILEDKIHCHA<char?>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly IKFCOEFPMMH LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2F35B20", Offset = "0x2F34B20", VA = "0x182F35B20", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, char? BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2F35BF0", Offset = "0x2F34BF0", VA = "0x182F35BF0", Slot = "5")]
	public char? EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public IKFCOEFPMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HIIIFDIDBPE : global::IILEDKIHCHA<char[]>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly HIIIFDIDBPE LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2F32BD0", Offset = "0x2F31BD0", VA = "0x182F32BD0", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, char[] BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2F32E10", Offset = "0x2F31E10", VA = "0x182F32E10", Slot = "5")]
	public char[] EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public HIIIFDIDBPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class MMFDBMAAEMG : global::IILEDKIHCHA<Guid>, BFICKKJBGKE, global::IKDCOJFJNJJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::IILEDKIHCHA<Guid> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2F40450", Offset = "0x2F3F450", VA = "0x182F40450", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Guid BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2F40610", Offset = "0x2F3F610", VA = "0x182F40610", Slot = "5")]
	public Guid EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2F40670", Offset = "0x2F3F670", VA = "0x182F40670", Slot = "6")]
	public void KBONFNFBOID(ref LGEMHOFFGMB GLHNDGPACHE, Guid BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2F40610", Offset = "0x2F3F610", VA = "0x182F40610", Slot = "7")]
	public Guid NBAKAJLAMFM(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public MMFDBMAAEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class MKJHGAOJOGL : global::IILEDKIHCHA<decimal>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::IILEDKIHCHA<decimal> LDOCOAFJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool JGPMDMAGKAA;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xB71C40", Offset = "0xB70C40", VA = "0x180B71C40")]
	public MKJHGAOJOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1663BA0", Offset = "0x1662BA0", VA = "0x181663BA0")]
	public MKJHGAOJOGL(bool JGPMDMAGKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2F3FF30", Offset = "0x2F3EF30", VA = "0x182F3FF30", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, decimal BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2F400A0", Offset = "0x2F3F0A0", VA = "0x182F400A0", Slot = "5")]
	public decimal EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CNLCLNPCFFA : global::IILEDKIHCHA<Uri>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::IILEDKIHCHA<Uri> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x372BF00", Offset = "0x372AF00", VA = "0x18372BF00", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Uri BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x372BFB0", Offset = "0x372AFB0", VA = "0x18372BFB0", Slot = "5")]
	public Uri EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public CNLCLNPCFFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class GPKBBHOKKGD : global::IILEDKIHCHA<Version>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::IILEDKIHCHA<Version> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3737960", Offset = "0x3736960", VA = "0x183737960", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Version BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3737A10", Offset = "0x3736A10", VA = "0x183737A10", Slot = "5")]
	public Version EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public GPKBBHOKKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class FFPAIMJGAPE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class IBAAOMCBCHA : global::IILEDKIHCHA<StringBuilder>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::IILEDKIHCHA<StringBuilder> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2F35490", Offset = "0x2F34490", VA = "0x182F35490", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, StringBuilder BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2F354E0", Offset = "0x2F344E0", VA = "0x182F354E0", Slot = "5")]
	public StringBuilder EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public IBAAOMCBCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class OHHKBNAKLFN : global::IILEDKIHCHA<BitArray>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::IILEDKIHCHA<BitArray> LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2F43D20", Offset = "0x2F42D20", VA = "0x182F43D20", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, BitArray BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2F43E20", Offset = "0x2F42E20", VA = "0x182F43E20", Slot = "5")]
	public BitArray EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public OHHKBNAKLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class CGEIFPBJIGH : global::IILEDKIHCHA<Type>, BFICKKJBGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly CGEIFPBJIGH LDOCOAFJGDF;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex KKNFPAOKLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool KPCBBPKCLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool MODKKKAKBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool EDBNEFCNJKM;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x372B860", Offset = "0x372A860", VA = "0x18372B860")]
	public CGEIFPBJIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x372B810", Offset = "0x372A810", VA = "0x18372B810")]
	public CGEIFPBJIGH(bool KPCBBPKCLMA, bool MODKKKAKBMJ, bool EDBNEFCNJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x372B560", Offset = "0x372A560", VA = "0x18372B560", Slot = "4")]
	public void DBCHIDLCGFP(ref LGEMHOFFGMB GLHNDGPACHE, Type BMNJAHFFOPC, OLHFHKDPOLA HABAKBFDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x372B650", Offset = "0x372A650", VA = "0x18372B650", Slot = "5")]
	public Type EKIAPEHGMJJ(ref EIPKCMBENFK IDEINAMOPJE, OLHFHKDPOLA HABAKBFDPDA)
	{
		return null;
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
