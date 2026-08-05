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
public class CFNNKBACNPH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551630", VA = "0x180552C30")]
	public CFNNKBACNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class EHIBKCKPKGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551630", VA = "0x180552C30")]
	public EHIBKCKPKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LNLHNJECPLI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551630", VA = "0x180552C30")]
	public LNLHNJECPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CAPEKLPMJBH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551630", VA = "0x180552C30")]
	public CAPEKLPMJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DFFCGJFPMLH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x36AB550", Offset = "0x36A9F50", VA = "0x1836AB550")]
	public static bool FBNHCNEBOFC(this TypeInfo IEADHAAGEDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class LHDEPGNDEIJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DCEGEKLMCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] HHHCLCEOAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DD0", Offset = "0x7C77D0", VA = "0x1807C8DD0")]
	public LHDEPGNDEIJ(Type BOPBIFKFJEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class LGPLMIINBPJ : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LLFEIEDIHFE<T>(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T HANEIHONNAN<T>(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL CPIBNMPIJNF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EGFLKHELIAB
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EGNEGNMBKFG<T> : EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DEACOEJPGKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GILNJOLHANP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EGNEGNMBKFG<T> DCPBAPPIICK<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LFOOHLHKCEN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3271B90", Offset = "0x3270590", VA = "0x183271B90")]
	public static global::EGNEGNMBKFG<T> GNDAFHGDEDA<T>(this CGDCFJDMLCL CPIBNMPIJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x33AAF90", Offset = "0x33A9990", VA = "0x1833AAF90")]
	public static object HNPFGOHCFGC(this CGDCFJDMLCL CPIBNMPIJNF, Type IEADHAAGEDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DNBHKNMJHFO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36ABE80", Offset = "0x36AA880", VA = "0x1836ABE80")]
	public DNBHKNMJHFO(string OLLHPIFFHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NHAPBMMNKAC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class OLLGJLDEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] HKIDJJNOKDE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] FOGHAFJPHFL;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4773DD0", Offset = "0x47727D0", VA = "0x184773DD0")]
		public static byte[] PIFPHDIALGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4773D40", Offset = "0x4772740", VA = "0x184773D40")]
		public static char[] MHOGOKOBCFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LFGMPGDPAIC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] IHPGAFPCPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] MCBNAPIFOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int EFGENLFBGLF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GDDIOJKNPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x33B0480", Offset = "0x33AEE80", VA = "0x1833B0480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33B1900", Offset = "0x33B0300", VA = "0x1833B1900")]
	public NHAPBMMNKAC(byte[] MCBNAPIFOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33B1910", Offset = "0x33B0310", VA = "0x1833B1910")]
	public NHAPBMMNKAC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33B0530", Offset = "0x33AEF30", VA = "0x1833B0530")]
	private MFDAMJHLIPE GNNODGPDPMH(string PNHNCJNEDLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33B0E40", Offset = "0x33AF840", VA = "0x1833B0E40")]
	private MFDAMJHLIPE JFGFIIIGBIK(string OLLHPIFFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33B1660", Offset = "0x33B0060", VA = "0x1833B1660")]
	public void OHNGLJFLPEE(int EFGENLFBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6043B0", Offset = "0x602DB0", VA = "0x1806043B0")]
	public byte[] KCMLEJNLCJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB40", Offset = "0x6AC540", VA = "0x1806ADB40")]
	public int GHLEJDFHLNN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x33AF140", Offset = "0x33ADB40", VA = "0x1833AF140")]
	public PJNNIPEGDKN AFEJJDOCFEK()
	{
		return default(PJNNIPEGDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33B11D0", Offset = "0x33AFBD0", VA = "0x1833B11D0")]
	public void JMJHHPACGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x33B1310", Offset = "0x33AFD10", VA = "0x1833B1310")]
	public bool LMCGBFGDDKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x33B03B0", Offset = "0x33AEDB0", VA = "0x1833B03B0")]
	public bool EGANDHKMPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x33AF530", Offset = "0x33ADF30", VA = "0x1833AF530")]
	public void BBEBODMOCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x33AF5D0", Offset = "0x33ADFD0", VA = "0x1833AF5D0")]
	public bool BCNDGALDOEC(ref int LKEJFKMJCND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33AF700", Offset = "0x33AE100", VA = "0x1833AF700")]
	public bool BFIJHODJLEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x33B1670", Offset = "0x33B0070", VA = "0x1833B1670")]
	public void ONENKODAEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x33B04A0", Offset = "0x33AEEA0", VA = "0x1833B04A0")]
	public bool GHFMDCEKLBG(ref int LKEJFKMJCND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x33B0C90", Offset = "0x33AF690", VA = "0x1833B0C90")]
	public bool IDELGEHIIHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x33B1430", Offset = "0x33AFE30", VA = "0x1833B1430")]
	public void MACCAIBNPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33B0A90", Offset = "0x33AF490", VA = "0x1833B0A90")]
	public bool HFOHBKFGBLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x33B0B00", Offset = "0x33AF500", VA = "0x1833B0B00")]
	public void HJDKMLDFGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x33AFA00", Offset = "0x33AE400", VA = "0x1833AFA00")]
	private void CPDJDGPADLL(out byte[] DNOJFMDMOPB, out int LNOGNDDHAEO, out int MLEIBLBLBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x33B0D00", Offset = "0x33AF700", VA = "0x1833B0D00")]
	private static int IFNBHGHDFNF(char MMADIBJKHHM, char ODMIEFIFOGP, char HJNCMGDJMJJ, char GMLDCHLEGOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x33B1100", Offset = "0x33AFB00", VA = "0x1833B1100")]
	private static int JMGODGLLALF(char EDIMMNEBDAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x33AF7F0", Offset = "0x33AE1F0", VA = "0x1833AF7F0")]
	public ArraySegment<byte> CBEAPNDHKBC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x33AF660", Offset = "0x33AE060", VA = "0x1833AF660")]
	public string BFGJICGHLHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x33B0E10", Offset = "0x33AF810", VA = "0x1833B0E10")]
	public string JBOOEKJNMFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x33B0190", Offset = "0x33AEB90", VA = "0x1833B0190")]
	public ArraySegment<byte> DILHEDOCCID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x33B17E0", Offset = "0x33B01E0", VA = "0x1833B17E0")]
	public ArraySegment<byte> PINDOJGEKAF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x33AF2D0", Offset = "0x33ADCD0", VA = "0x1833AF2D0")]
	public bool AGHDEKDPCOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x33B14D0", Offset = "0x33AFED0", VA = "0x1833B14D0")]
	private static bool NALLJGBKNJO(byte HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33AEF70", Offset = "0x33AD970", VA = "0x1833AEF70")]
	private void ABCHBKMLNHI(PJNNIPEGDKN LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33B0340", Offset = "0x33AED40", VA = "0x1833B0340")]
	public void DJCOBAFGNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x33B1710", Offset = "0x33B0110", VA = "0x1833B1710")]
	private void PBAMDCGLPDO(int LHHHODIIJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33B1590", Offset = "0x33AFF90", VA = "0x1833B1590")]
	public sbyte OAOEKFCIEHM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33AF9A0", Offset = "0x33AE3A0", VA = "0x1833AF9A0")]
	public short COBOLEKNFCO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33B0420", Offset = "0x33AEE20", VA = "0x1833B0420")]
	public int ELOKLDKLIOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33B15E0", Offset = "0x33AFFE0", VA = "0x1833B15E0")]
	public long OGPILMDFGMC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33B0DB0", Offset = "0x33AF7B0", VA = "0x1833B0DB0")]
	public byte IHFFJFHFPEF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33B10A0", Offset = "0x33AFAA0", VA = "0x1833B10A0")]
	public ushort JJOHNOGFNMI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33B0350", Offset = "0x33AED50", VA = "0x1833B0350")]
	public uint DJCPPPJFBFP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33AF770", Offset = "0x33AE170", VA = "0x1833AF770")]
	public ulong BGKLIEFBFBC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x33B09D0", Offset = "0x33AF3D0", VA = "0x1833B09D0")]
	public float HAEFCCCAOLO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x33AF8E0", Offset = "0x33AE2E0", VA = "0x1833AF8E0")]
	public double CIMKDHCOHKE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33B0BA0", Offset = "0x33AF5A0", VA = "0x1833B0BA0")]
	public ArraySegment<byte> IBOHPKMMJAD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x33B0F20", Offset = "0x33AF920", VA = "0x1833B0F20")]
	private static int JICNNOLHLPA(byte[] MCBNAPIFOAJ, int EFGENLFBGLF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MFDAMJHLIPE : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference MIOLLBFNJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int IDICDJODIJA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int PIDPFCKFJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xC5D3A0", Offset = "0xC5BDA0", VA = "0x180C5D3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IHCIINJHFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67EE20", Offset = "0x67D820", VA = "0x18067EE20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33AB990", Offset = "0x33AA390", VA = "0x1833AB990")]
	public MFDAMJHLIPE(string OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x33AB8C0", Offset = "0x33AA2C0", VA = "0x1833AB8C0")]
	public MFDAMJHLIPE(string OLLHPIFFHKE, byte[] GMOGODPGMOA, int EFGENLFBGLF, int IDICDJODIJA, string LKLDAKGKPEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DBHFDALGNEK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class JADPOOMEHDE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void NLMLEMGEDFE(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object NBJLOGELBBK(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL CPIBNMPIJNF);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class CGFFFKAPMHB
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class GCEMGCDJCEI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
				public GCEMGCDJCEI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x127CAE0", Offset = "0x127B4E0", VA = "0x18127CAE0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x36B4AB0", Offset = "0x36B34B0", VA = "0x1836B4AB0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, CGDCFJDMLCL, byte[]> OKKDNAGDEDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, CGDCFJDMLCL> FAAIAIDHHLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly NLMLEMGEDFE APJHHNNOMKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, CGDCFJDMLCL, ArraySegment<byte>> DEIMGFMNFAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CGDCFJDMLCL, string> PMNACNDOJAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, CGDCFJDMLCL, object> IGMANHDLEBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, CGDCFJDMLCL, object> FBHIJFENECC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, CGDCFJDMLCL, object> JFICAPIACGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly NBJLOGELBBK ECIDDGPCIGK;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x36A77A0", Offset = "0x36A61A0", VA = "0x1836A77A0")]
			public CGFFFKAPMHB(Type IEADHAAGEDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x275B1D0", Offset = "0x2759BD0", VA = "0x18275B1D0")]
			private static T NFCAOMFDFEO<T>(DynamicMethod DJKHJBPPHKJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x36A75B0", Offset = "0x36A5FB0", VA = "0x1836A75B0")]
			private static MethodInfo HILBKMJAOHB(Type IEADHAAGEDA, string JMIBJFINBJD, Type[] EAOJOFJOHHA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, CGFFFKAPMHB> DHCHPIOIAHO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::IGFADKHPDOF<CGFFFKAPMHB> FFIBFFEGCHO;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x36B6670", Offset = "0x36B5070", VA = "0x1836B6670")]
		static JADPOOMEHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x36B6370", Offset = "0x36B4D70", VA = "0x1836B6370")]
		private static CGFFFKAPMHB JJBBAKFANLO(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x36B63F0", Offset = "0x36B4DF0", VA = "0x1836B63F0")]
		public static void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x36B6560", Offset = "0x36B4F60", VA = "0x1836B6560")]
		public static void NGLMBPACFDH(Type IEADHAAGEDA, ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class CLDNFPOJJFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] HKIDJJNOKDE;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x36AA5F0", Offset = "0x36A8FF0", VA = "0x1836AA5F0")]
		public static byte[] PIFPHDIALGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CGDCFJDMLCL KAPJIHGPBOE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] CDNPHMCBJCP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] AGNPOLDHHMF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CGDCFJDMLCL IPDHHNPBJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x36AB310", Offset = "0x36A9D10", VA = "0x1836AB310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x36AB2B0", Offset = "0x36A9CB0", VA = "0x1836AB2B0")]
	public static void BMNNLOEIBNK(CGDCFJDMLCL CPIBNMPIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29F8070", Offset = "0x29F6A70", VA = "0x1829F8070")]
	public static string KKHCKKEABHA<T>(T HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29F80F0", Offset = "0x29F6AF0", VA = "0x1829F80F0")]
	public static string KKHCKKEABHA<T>(T HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x275BE10", Offset = "0x275A810", VA = "0x18275BE10")]
	public static T FIPMLAIPHOG<T>(string OJFDPHJFPFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x275BCC0", Offset = "0x275A6C0", VA = "0x18275BCC0")]
	public static T FIPMLAIPHOG<T>(string OJFDPHJFPFH, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x275BD90", Offset = "0x275A790", VA = "0x18275BD90")]
	public static T FIPMLAIPHOG<T>(byte[] MCBNAPIFOAJ, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x275BE90", Offset = "0x275A890", VA = "0x18275BE90")]
	public static T FIPMLAIPHOG<T>(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PJNNIPEGDKN : byte
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
public struct FBIFMPDMBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] EKKHFIKIAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] HKIDJJNOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int EFGENLFBGLF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GHLABFJANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB40", Offset = "0x6AC540", VA = "0x1806ADB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x33B1660", Offset = "0x33B0060", VA = "0x1833B1660")]
	public void OHNGLJFLPEE(int EFGENLFBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x36AFE50", Offset = "0x36AE850", VA = "0x1836AFE50")]
	public static byte[] AEBOHOGHPPN(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x36B05D0", Offset = "0x36AEFD0", VA = "0x1836B05D0")]
	public static byte[] IGEBHAGHDJL(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x36B0C80", Offset = "0x36AF680", VA = "0x1836B0C80")]
	public static byte[] PBGJBEMJAIN(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x36AFCF0", Offset = "0x36AE6F0", VA = "0x1836AFCF0")]
	public static byte[] ACCDHLJAOGG(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x12702A0", Offset = "0x126ECA0", VA = "0x1812702A0")]
	public FBIFMPDMBBF(byte[] GLNKGIMKFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x36B0E00", Offset = "0x36AF800", VA = "0x1836B0E00")]
	public ArraySegment<byte> PIFPHDIALGM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x36B00F0", Offset = "0x36AEAF0", VA = "0x1836B00F0")]
	public byte[] EIEKHKNCOPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x36B0F10", Offset = "0x36AF910", VA = "0x1836B0F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x36B0EB0", Offset = "0x36AF8B0", VA = "0x1836B0EB0")]
	public void PJBHCHFGCIP(int DFINGJIDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x36B0030", Offset = "0x36AEA30", VA = "0x1836B0030")]
	public void DDENGIJEDAI(byte[] EIJDBEGLJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x36B0170", Offset = "0x36AEB70", VA = "0x1836B0170")]
	public void EILFPAEONEF(byte EIJDBEGLJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36AFF60", Offset = "0x36AE960", VA = "0x1836AFF60")]
	public void CCBPNANEJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36B0C30", Offset = "0x36AF630", VA = "0x1836B0C30")]
	public void OOAFKEIKODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36B0AD0", Offset = "0x36AF4D0", VA = "0x1836B0AD0")]
	public void KFFHFNKIMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36B0950", Offset = "0x36AF350", VA = "0x1836B0950")]
	public void JHKIGKOKOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x36B0DB0", Offset = "0x36AF7B0", VA = "0x1836B0DB0")]
	public void PFKJLAMGPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x36B0EC0", Offset = "0x36AF8C0", VA = "0x1836B0EC0")]
	public void PMDLOFBEICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36B0BD0", Offset = "0x36AF5D0", VA = "0x1836B0BD0")]
	public void OKCLAICGEOP(string EACDICMBPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36B0580", Offset = "0x36AEF80", VA = "0x1836B0580")]
	public void IDJHMBAKEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x36B09A0", Offset = "0x36AF3A0", VA = "0x1836B09A0")]
	public void JIFAPKNKLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36B0700", Offset = "0x36AF100", VA = "0x1836B0700")]
	public void JBELDKOLGOP(bool HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36B0B50", Offset = "0x36AF550", VA = "0x1836B0B50")]
	public void NNLIBFGLAJL(float HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36AFFB0", Offset = "0x36AE9B0", VA = "0x1836AFFB0")]
	public void CKGEIFIIBJN(double HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36B08F0", Offset = "0x36AF2F0", VA = "0x1836B08F0")]
	public void JDJCNNMOOKP(byte HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x36B0920", Offset = "0x36AF320", VA = "0x1836B0920")]
	public void JGMEFINEGHP(ushort HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36B00C0", Offset = "0x36AEAC0", VA = "0x1836B00C0")]
	public void DOPGIAPHAJB(uint HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36B0090", Offset = "0x36AEA90", VA = "0x1836B0090")]
	public void DOACEEBMFKB(ulong HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x36B0A70", Offset = "0x36AF470", VA = "0x1836B0A70")]
	public void JPFDPNEHEOF(sbyte HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x36AFF30", Offset = "0x36AE930", VA = "0x1836AFF30")]
	public void BBLPKOPDPIE(short HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36B0B20", Offset = "0x36AF520", VA = "0x1836B0B20")]
	public void MFDIABDHHJL(int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x36B0AA0", Offset = "0x36AF4A0", VA = "0x1836B0AA0")]
	public void KBKMNMIKIGD(long HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36B01B0", Offset = "0x36AEBB0", VA = "0x1836B01B0")]
	public void HJBIDCPPJLK(string HPIAFNBPEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BAOKNACEOHD : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class GJJDJNHKMBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x39607D0", Offset = "0x395F1D0", VA = "0x1839607D0")]
		static GJJDJNHKMBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private BAOKNACEOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class COODBCACHIF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BEADCGMBJJA;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x36AAEF0", Offset = "0x36A98F0", VA = "0x1836AAEF0")]
	static COODBCACHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36AA990", Offset = "0x36A9390", VA = "0x1836AA990")]
	internal static object DCPBAPPIICK(Type LIKLFJCOLDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BEOKIDBJCMF : global::EGNEGNMBKFG<Vector2>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x36A31D0", Offset = "0x36A1BD0", VA = "0x1836A31D0")]
	public BEOKIDBJCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x36A3060", Offset = "0x36A1A60", VA = "0x1836A3060", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Vector2 HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x36A2E70", Offset = "0x36A1870", VA = "0x1836A2E70", Slot = "5")]
	public Vector2 FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NHPGMMFEGEO : global::EGNEGNMBKFG<Vector3>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x476E650", Offset = "0x476D050", VA = "0x18476E650")]
	public NHPGMMFEGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x476E530", Offset = "0x476CF30", VA = "0x18476E530", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Vector3 HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x476E340", Offset = "0x476CD40", VA = "0x18476E340", Slot = "5")]
	public Vector3 FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CGEMKCPIGNJ : global::EGNEGNMBKFG<Vector4>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x36A7290", Offset = "0x36A5C90", VA = "0x1836A7290")]
	public CGEMKCPIGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x36A6300", Offset = "0x36A4D00", VA = "0x1836A6300", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Vector4 HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x36A7000", Offset = "0x36A5A00", VA = "0x1836A7000", Slot = "5")]
	public Vector4 FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JHDGFDELFPA : global::EGNEGNMBKFG<Quaternion>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x33A8140", Offset = "0x33A6B40", VA = "0x1833A8140")]
	public JHDGFDELFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x33A7FF0", Offset = "0x33A69F0", VA = "0x1833A7FF0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Quaternion HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x33A7CB0", Offset = "0x33A66B0", VA = "0x1833A7CB0", Slot = "5")]
	public Quaternion FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class CEMEEAFIKOB : global::EGNEGNMBKFG<Color>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x36A6570", Offset = "0x36A4F70", VA = "0x1836A6570")]
	public CEMEEAFIKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x36A6300", Offset = "0x36A4D00", VA = "0x1836A6300", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Color HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x36A6070", Offset = "0x36A4A70", VA = "0x1836A6070", Slot = "5")]
	public Color FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EMGOFAADMPB : global::EGNEGNMBKFG<Bounds>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x36AEDA0", Offset = "0x36AD7A0", VA = "0x1836AEDA0")]
	public EMGOFAADMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x36AEAA0", Offset = "0x36AD4A0", VA = "0x1836AEAA0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Bounds HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x36AE7A0", Offset = "0x36AD1A0", VA = "0x1836AE7A0", Slot = "5")]
	public Bounds FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FAOMKAGKDBB : global::EGNEGNMBKFG<Rect>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CIFOBOMBMDE JFBKNOIFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] DEDAKJPOJGG;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36AF9D0", Offset = "0x36AE3D0", VA = "0x1836AF9D0")]
	public FAOMKAGKDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x36AF740", Offset = "0x36AE140", VA = "0x1836AF740", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Rect HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x36AF490", Offset = "0x36ADE90", VA = "0x1836AF490", Slot = "5")]
	public Rect FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MKICJDLLHCC : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class IOEMCGNEFFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B830", Offset = "0x2D1A230", VA = "0x182D1B830")]
		static IOEMCGNEFFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private MKICJDLLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class DMLPCHGFJLI : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class LFGCIONCCBO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2E78510", Offset = "0x2E76F10", VA = "0x182E78510")]
		static LFGCIONCCBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class EDMMIAHIOJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> COLKEMJNBAD;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x36AC7B0", Offset = "0x36AB1B0", VA = "0x1836AC7B0")]
		internal static object DCPBAPPIICK(Type LIKLFJCOLDP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private DMLPCHGFJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class HMCLDBOEGEH : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class ALECNHFCFFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x35F4AC0", Offset = "0x35F34C0", VA = "0x1835F4AC0")]
		static ALECNHFCFFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly HMCLDBOEGEH JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool PJFKNIDEDKA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static EGFLKHELIAB[] ANNPMMACDCA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static CGDCFJDMLCL[] HBJOCMKBCJA;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private HMCLDBOEGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33A6C20", Offset = "0x33A5620", VA = "0x1833A6C20")]
	public static void JECFEENHGII(params CGDCFJDMLCL[] HBJOCMKBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33A6CE0", Offset = "0x33A56E0", VA = "0x1833A6CE0")]
	public static void JECFEENHGII(params EGFLKHELIAB[] ANNPMMACDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x33A69D0", Offset = "0x33A53D0", VA = "0x1833A69D0")]
	public static void DAPGBMBBINP(EGFLKHELIAB[] ANNPMMACDCA, CGDCFJDMLCL[] HBJOCMKBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class ECHOGCBPNPH : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class MGBCJEDJNMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x36C7C80", Offset = "0x36C6680", VA = "0x1836C7C80")]
		static MGBCJEDJNMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private ECHOGCBPNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DMAMKBJIOCB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CGDCFJDMLCL GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CGDCFJDMLCL DLHNDFJIAEI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CGDCFJDMLCL ONKLIOIPONJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CGDCFJDMLCL MDAOOMADCPC;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CGDCFJDMLCL LJLEBNACGCG;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CGDCFJDMLCL CJKMFMIFKJF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CGDCFJDMLCL DOHDCNHEAOM;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CGDCFJDMLCL DLIOBFJOCOB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CGDCFJDMLCL LCJHCCFOIOA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CGDCFJDMLCL AGFOKFICJEJ;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CGDCFJDMLCL LKHEMBHFFAM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CGDCFJDMLCL CIELHFKJGAO;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OOPMGOIIMEF
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CGDCFJDMLCL GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CGDCFJDMLCL CAHPCDNLCEE;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OCDPMDEHAIF
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CGDCFJDMLCL GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CGDCFJDMLCL DLHNDFJIAEI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CGDCFJDMLCL ONKLIOIPONJ;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CGDCFJDMLCL MDAOOMADCPC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CGDCFJDMLCL LJLEBNACGCG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CGDCFJDMLCL CJKMFMIFKJF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CGDCFJDMLCL DOHDCNHEAOM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CGDCFJDMLCL DLIOBFJOCOB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CGDCFJDMLCL LCJHCCFOIOA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CGDCFJDMLCL AGFOKFICJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CGDCFJDMLCL LKHEMBHFFAM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CGDCFJDMLCL CIELHFKJGAO;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class NMJKIKINAKN
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> COLKEMJNBAD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4770460", Offset = "0x476EE60", VA = "0x184770460")]
	internal static object DCPBAPPIICK(Type LIKLFJCOLDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4771AE0", Offset = "0x47704E0", VA = "0x184771AE0")]
	private static object JICFMAOBAHA(Type DKPMPBPCFNN, Type[] CDAPDONKCFN, params object[] EAOJOFJOHHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class NFNIKHIBGGN : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class JPIDENNGKIL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EAC0", Offset = "0x3E1D4C0", VA = "0x183E1EAC0")]
		static JPIDENNGKIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly NEMPGDCHPOI HLNGJNJNONI;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x33AEE80", Offset = "0x33AD880", VA = "0x1833AEE80")]
	static NFNIKHIBGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private NFNIKHIBGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class ABDHMLAMFHF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class NJCKPMENNLH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4230630", Offset = "0x422F030", VA = "0x184230630")]
		static NJCKPMENNLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly NEMPGDCHPOI HLNGJNJNONI;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x369E250", Offset = "0x369CC50", VA = "0x18369E250")]
	static ABDHMLAMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private ABDHMLAMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class LMGJFGAKEGI : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class FFGPBPJHNPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D19C10", Offset = "0x2D18610", VA = "0x182D19C10")]
		static FFGPBPJHNPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly NEMPGDCHPOI HLNGJNJNONI;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x33AB260", Offset = "0x33A9C60", VA = "0x1833AB260")]
	static LMGJFGAKEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private LMGJFGAKEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class CHCOOMFMGOA : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class MPBDELJCBPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3473FF0", Offset = "0x34729F0", VA = "0x183473FF0")]
		static MPBDELJCBPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly NEMPGDCHPOI HLNGJNJNONI;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x36A96C0", Offset = "0x36A80C0", VA = "0x1836A96C0")]
	static CHCOOMFMGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private CHCOOMFMGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class PHKLHFKMBOC : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class MEEKJELKKIO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x391E770", Offset = "0x391D170", VA = "0x18391E770")]
		static MEEKJELKKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly NEMPGDCHPOI HLNGJNJNONI;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4779D80", Offset = "0x4778780", VA = "0x184779D80")]
	static PHKLHFKMBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private PHKLHFKMBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class KPGLBHHKMDH : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class BNLCFPPMCFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0D00", Offset = "0x3DBF700", VA = "0x183DC0D00")]
		static BNLCFPPMCFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly NEMPGDCHPOI HLNGJNJNONI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x33AAB10", Offset = "0x33A9510", VA = "0x1833AAB10")]
	static KPGLBHHKMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private KPGLBHHKMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class NPLIGJLEONF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class INJEDOMNIIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x420AD30", Offset = "0x4209730", VA = "0x18420AD30")]
		static INJEDOMNIIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NPLIGJLEONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class MILKKIKPKIA : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class KFAOMENMMCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D130", Offset = "0x2D1BB30", VA = "0x182D1D130")]
		static KFAOMENMMCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public MILKKIKPKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class KBMHGLFKGEF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class MLALCANBEHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x40D2B60", Offset = "0x40D1560", VA = "0x1840D2B60")]
		static MLALCANBEHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public KBMHGLFKGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class BPLIDFGLODF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class BGPBPIOLKAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x28E12C0", Offset = "0x28DFCC0", VA = "0x1828E12C0")]
		static BGPBPIOLKAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public BPLIDFGLODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class NNLALOHNCEN : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KKDLFMKNBIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7C10", Offset = "0x3BA6610", VA = "0x183BA7C10")]
		static KKDLFMKNBIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NNLALOHNCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class BAPKBEPKCBP : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class JFHBBCFJGHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3963E50", Offset = "0x3962850", VA = "0x183963E50")]
		static JFHBBCFJGHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> FOBGCCPNDPF;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool KMLIFFKKBHE;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public BAPKBEPKCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class GLJEEEKOCFK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct POANPKOBEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FIIKBGBBFLN MCPFEGKDHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder OFNNJJMLBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder LKONJHPBMNO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class OCIMOHCDPEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class DEAILFHLKOE
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo PBGJBEMJAIN;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo IGEBHAGHDJL;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo ACCDHLJAOGG;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo AEBOHOGHPPN;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo JIFAPKNKLLH;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo DDENGIJEDAI;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo KFFHFNKIMEJ;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo JHKIGKOKOOH;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo PFKJLAMGPNE;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x339BA30", Offset = "0x339A430", VA = "0x18339BA30")]
			static DEAILFHLKOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class BPGIGNONIAA
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo LMCGBFGDDKA;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo ONENKODAEMA;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo GHFMDCEKLBG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo LHCMBIBPDJJ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo DJCOBAFGNKH;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo KCMLEJNLCJI;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo GHLEJDFHLNN;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x339ADB0", Offset = "0x33997B0", VA = "0x18339ADB0")]
			static BPGIGNONIAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class MEEENCEPIPL
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo DCEGEKLMCII;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo HHHCLCEOAHF;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MBBMJNJOKEJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo GNDAFHGDEDA;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo BLLGDNDABBO;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FKNMDFANHIL;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GOLMAPJMBFD;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo MHMHDLIILMF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo GEIKOBNEGKE;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo FPMGMEHMDOI;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo IIPJNANBFFC;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo BOHNCPJGBNL;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo EAMCPDHABAB;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo MOBBKKCFEAO;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x33B1E40", Offset = "0x33B0840", VA = "0x1833B1E40")]
		public static MethodInfo NGLMBPACFDH(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x33B1AF0", Offset = "0x33B04F0", VA = "0x1833B1AF0")]
		public static MethodInfo FIPMLAIPHOG(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x33B1D20", Offset = "0x33B0720", VA = "0x1833B1D20")]
		public static MethodInfo JEFOKKAADLO(Type IEADHAAGEDA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LKLJJCMJIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<FIIKBGBBFLN, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public LKLJJCMJIFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GFHDGBFFIAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public LKLJJCMJIFK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public GFHDGBFFIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x339D010", Offset = "0x339BA10", VA = "0x18339D010")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x339D050", Offset = "0x339BA50", VA = "0x18339D050")]
		internal bool <BuildType>b__2(int index, FIIKBGBBFLN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class LNMFNIPMPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LKLJJCMJIFK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public LNMFNIPMPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x33AB350", Offset = "0x33A9D50", VA = "0x1833AB350")]
		internal bool <BuildType>b__3(int index, FIIKBGBBFLN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JEKINHPCOHC
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public JEKINHPCOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x33A7C50", Offset = "0x33A6650", VA = "0x1833A7C50")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HPLOCAEGJHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public HPLOCAEGJHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x33A6E60", Offset = "0x33A5860", VA = "0x1833A6E60")]
		internal bool <BuildAnonymousFormatter>b__2(FIIKBGBBFLN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OGMCKNDPMEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public JEKINHPCOHC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public OGMCKNDPMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x33B3520", Offset = "0x33B1F20", VA = "0x1833B3520")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x33B3530", Offset = "0x33B1F30", VA = "0x1833B3530")]
		internal bool <BuildAnonymousFormatter>b__6(int index, FIIKBGBBFLN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KKCKJBGBPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JEKINHPCOHC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public KKCKJBGBPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x33A9590", Offset = "0x33A7F90", VA = "0x1833A9590")]
		internal bool <BuildAnonymousFormatter>b__7(int index, FIIKBGBBFLN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HIEIJFMJMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public HIEIJFMJMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x57F950", Offset = "0x57E350", VA = "0x18057F950")]
		internal Label <BuildSerialize>b__1(FIIKBGBBFLN _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class HICBNPOAEIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public POANPKOBEPP[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, FIIKBGBBFLN, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DGGGCNDMAMN argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DGGGCNDMAMN argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public HICBNPOAEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x33A68A0", Offset = "0x33A52A0", VA = "0x1833A68A0")]
		internal POANPKOBEPP <BuildDeserialize>b__0(FIIKBGBBFLN item)
		{
			return default(POANPKOBEPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class DIMJBHNOKMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HICBNPOAEIJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public DIMJBHNOKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x339C770", Offset = "0x339B170", VA = "0x18339C770")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x339CA20", Offset = "0x339B420", VA = "0x18339CA20")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class IHHMFLNDLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public FIIKBGBBFLN item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public IHHMFLNDLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1C24FB0", Offset = "0x1C239B0", VA = "0x181C24FB0")]
		internal bool <EmitNewObject>b__0(POANPKOBEPP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HDGEMODCEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FIIKBGBBFLN item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public HDGEMODCEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1C24FB0", Offset = "0x1C239B0", VA = "0x181C24FB0")]
		internal bool <EmitNewObject>b__2(POANPKOBEPP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex BPKJGCLNEJI;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int FHGAAKPMIHG;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> EBKBIOIBOCG;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> FDAKOKMNJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x324B110", Offset = "0x3249B10", VA = "0x18324B110")]
	public static object MBNHIFEKJOO<T>(NEMPGDCHPOI HLNGJNJNONI, CGDCFJDMLCL MBHOOFOFNPC, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x29FE570", Offset = "0x29FCF70", VA = "0x1829FE570")]
	public static object PPGFGKNDLCO<T>(CGDCFJDMLCL MBHOOFOFNPC, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE, bool PNKMJLMLEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33A0F60", Offset = "0x339F960", VA = "0x1833A0F60")]
	private static TypeInfo JIAJADFOFIG(NEMPGDCHPOI HLNGJNJNONI, Type IEADHAAGEDA, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x339D290", Offset = "0x339BC90", VA = "0x18339D290")]
	public static object APJBJEHMMDN(Type IEADHAAGEDA, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE, bool PNKMJLMLEGI, bool DPPDIBFDLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x339EFE0", Offset = "0x339D9E0", VA = "0x18339EFE0")]
	private static Dictionary<FIIKBGBBFLN, FieldInfo> HKOAFKFFHGG(TypeBuilder LGLAPGDEAJG, PAFFIENPFGC EEHCANMAMAN, ConstructorInfo EKIPPGBDPOM, FieldBuilder DAMNAHKCMGH, ILGenerator BAHIJJBPKKH, bool KMLIFFKKBHE, bool CPHHKKDMBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x33A3BD0", Offset = "0x33A25D0", VA = "0x1833A3BD0")]
	private static Dictionary<FIIKBGBBFLN, FieldInfo> MOFBJCCHOAP(TypeBuilder LGLAPGDEAJG, PAFFIENPFGC EEHCANMAMAN, ILGenerator BAHIJJBPKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x33A2670", Offset = "0x33A1070", VA = "0x1833A2670")]
	private static void MNIABGGLGOP(Type IEADHAAGEDA, PAFFIENPFGC EEHCANMAMAN, ILGenerator BAHIJJBPKKH, Action BLOJBGAPBEP, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, bool KMLIFFKKBHE, bool CPHHKKDMBAJ, int NGOHPCFAIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x33A4190", Offset = "0x33A2B90", VA = "0x1833A4190")]
	private static void OHELBINDOJK(TypeInfo IEADHAAGEDA, FIIKBGBBFLN FMAMJMDMEOL, ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, DGGGCNDMAMN HBKAOCMIABB, DGGGCNDMAMN ILNDLLIPJKB, DGGGCNDMAMN DHGLCIMNDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x339F630", Offset = "0x339E030", VA = "0x18339F630")]
	private static void IECOPLDNCKG(Type IEADHAAGEDA, PAFFIENPFGC EEHCANMAMAN, ILGenerator BAHIJJBPKKH, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, bool EMKPMBFBMMH, int NGOHPCFAIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x339EBD0", Offset = "0x339D5D0", VA = "0x18339EBD0")]
	private static void EPBGGFPACBE(ILGenerator BAHIJJBPKKH, POANPKOBEPP EEHCANMAMAN, int LGBFGOJBLFK, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, DGGGCNDMAMN GFDHAJPOBIG, DGGGCNDMAMN DHGLCIMNDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x33A1A00", Offset = "0x33A0400", VA = "0x1833A1A00")]
	private static LocalBuilder MALLEDLGDED(ILGenerator BAHIJJBPKKH, Type IEADHAAGEDA, PAFFIENPFGC EEHCANMAMAN, POANPKOBEPP[] MKCIGDGFNDG, bool PDOEGBEBCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x33A0890", Offset = "0x339F290", VA = "0x1833A0890")]
	private static bool JFEADGMLGNN(ConstructorInfo BLHGDOIKEOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x339D0F0", Offset = "0x339BAF0", VA = "0x18339D0F0")]
	private static bool ABJKPMBJJJA(Type IEADHAAGEDA, out Type LGNPAAGMGEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void PJMOKNCNLOF<T>(byte[][] DAMNAHKCMGH, object[] HBCPLKNGEED, ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T OOMLNNJPPFJ<T>(object[] HBCPLKNGEED, ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL CPIBNMPIJNF);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class AMPIJJCPHOF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class BAFIMNJBGGP : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class ONHIBKCENCA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3969A80", Offset = "0x3968480", VA = "0x183969A80")]
		static ONHIBKCENCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private BAFIMNJBGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class EHAKGKAOMLJ : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class PNGGGIGEAAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x37E7840", Offset = "0x37E6240", VA = "0x1837E7840")]
		static PNGGGIGEAAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private EHAKGKAOMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class EAKJPKAJFHF
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly CGDCFJDMLCL[] HPBBIMAMMKF;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class LAAGHLLPEHE : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class NGACMCKJBDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3F271D0", Offset = "0x3F25BD0", VA = "0x183F271D0")]
		static NGACMCKJBDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class CKFDJEAJHJF : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class LCKOAGCLGHC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3F1BDD0", Offset = "0x3F1A7D0", VA = "0x183F1BDD0")]
			static LCKOAGCLGHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private CKFDJEAJHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private LAAGHLLPEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class PNHMGABJOMP : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class IIGPDPNGBEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x41339D0", Offset = "0x41323D0", VA = "0x1841339D0")]
		static IIGPDPNGBEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class EGCCKEOOHGC : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class KBHNKOHFHEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4138F80", Offset = "0x4137980", VA = "0x184138F80")]
			static KBHNKOHFHEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private EGCCKEOOHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private PNHMGABJOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class FLPDBMPPHCC : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class MKGMFHDGFMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x36E9CA0", Offset = "0x36E86A0", VA = "0x1836E9CA0")]
		static MKGMFHDGFMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class PBJDICCEEMH : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class EBLCPOKNBCB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x36D09B0", Offset = "0x36CF3B0", VA = "0x1836D09B0")]
			static EBLCPOKNBCB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private PBJDICCEEMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private FLPDBMPPHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class JNNAMLBCOBO : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class BOOAJCMCGAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x25CE990", Offset = "0x25CD390", VA = "0x1825CE990")]
		static BOOAJCMCGAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class BCCAPCIOJBG : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class AHDAPDLLLPM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x25CA010", Offset = "0x25C8A10", VA = "0x1825CA010")]
			static AHDAPDLLLPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private BCCAPCIOJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private JNNAMLBCOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class OLKFMKNOJOP : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class GFKHNEJKGNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2680980", Offset = "0x267F380", VA = "0x182680980")]
		static GFKHNEJKGNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class BOMKELLPLNB : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class EPKMKFFJIBL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x267C570", Offset = "0x267AF70", VA = "0x18267C570")]
			static EPKMKFFJIBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private BOMKELLPLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private OLKFMKNOJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class JHMKONLFOOF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class NPIHGHOEHPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x29DCE40", Offset = "0x29DB840", VA = "0x1829DCE40")]
		static NPIHGHOEHPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class KNKBMJJPBGB : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class NKHJKJLIOJL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x29D7FD0", Offset = "0x29D69D0", VA = "0x1829D7FD0")]
			static NKHJKJLIOJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private KNKBMJJPBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private JHMKONLFOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class NNFGOGCMJAK : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class JBDEBEEPHCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2D90", Offset = "0x3BA1790", VA = "0x183BA2D90")]
		static JBDEBEEPHCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class LJIDEMKEHOJ : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class BJOOINBCKCI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3B9AB90", Offset = "0x3B99590", VA = "0x183B9AB90")]
			static BJOOINBCKCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private LJIDEMKEHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private NNFGOGCMJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class EFKLMIKMOIN : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class APKFDDFAFHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36BA910", Offset = "0x36B9310", VA = "0x1836BA910")]
		static APKFDDFAFHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class GFMMEDMKDEI : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NLOMEIAKNGO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x36CA670", Offset = "0x36C9070", VA = "0x1836CA670")]
			static NLOMEIAKNGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private GFMMEDMKDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private EFKLMIKMOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class NPECNKIKMLF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class DAPJNFKMGIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3BA01A0", Offset = "0x3B9EBA0", VA = "0x183BA01A0")]
		static DAPJNFKMGIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class KFBLBIDGJNL : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class NIJCPKMHCMH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3BA9CF0", Offset = "0x3BA86F0", VA = "0x183BA9CF0")]
			static NIJCPKMHCMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private KFBLBIDGJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private NPECNKIKMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class HENLCCJNEBG : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class FMGIBHNPJNP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x35CA4E0", Offset = "0x35C8EE0", VA = "0x1835CA4E0")]
		static FMGIBHNPJNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class JANCICNENED : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class IOFDPPOJBAE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x360C1C0", Offset = "0x360ABC0", VA = "0x18360C1C0")]
			static IOFDPPOJBAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private JANCICNENED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private HENLCCJNEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class NJDCMNCAFEF : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class AMMIGJMBGHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E141B0", Offset = "0x3E12BB0", VA = "0x183E141B0")]
		static AMMIGJMBGHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class BCLAMPOKCLK : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class JDIOKKGJMLA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3E19C90", Offset = "0x3E18690", VA = "0x183E19C90")]
			static JDIOKKGJMLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private BCLAMPOKCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private NJDCMNCAFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class FFCOGONMILH : CGDCFJDMLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class GCOFLMPDNBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x36E33F0", Offset = "0x36E1DF0", VA = "0x1836E33F0")]
		static GCOFLMPDNBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class JPNJICDNBNC : CGDCFJDMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class FENIKELFGOL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::EGNEGNMBKFG<T> OICFHIMGFMH;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x36DA1A0", Offset = "0x36D8BA0", VA = "0x1836DA1A0")]
			static FENIKELFGOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private JPNJICDNBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
		public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::EGNEGNMBKFG<object> ILAEGOJEJLM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	private FFCOGONMILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22AD4B0", Offset = "0x22ABEB0", VA = "0x1822AD4B0", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct MLNAMEPCKNM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] IFGMDACLNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int PFFOPFIKBNG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6ED0", Offset = "0x3EC58D0", VA = "0x183EC6ED0")]
	public MLNAMEPCKNM(int CFPFDMKCPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6C90", Offset = "0x3EC5690", VA = "0x183EC6C90")]
	public void CEGAKGBDODP(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6E40", Offset = "0x3EC5840", VA = "0x183EC6E40")]
	public T[] JKAPMNMJCMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class JKBPPDBBDKG : global::MJLBBJKMKCK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly JKBPPDBBDKG GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x33A85F0", Offset = "0x33A6FF0", VA = "0x1833A85F0")]
	public JKBPPDBBDKG(int AHEACBAMFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class MJLBBJKMKCK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int AHEACBAMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object GJOJILMPMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int LGBFGOJBLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] HDJEHJOLNCF;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E680", Offset = "0x2D2D080", VA = "0x182D2E680")]
	public MJLBBJKMKCK(int AHEACBAMFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E2C0", Offset = "0x2D2CCC0", VA = "0x182D2E2C0")]
	public T[] ONKPAIFMGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C940", Offset = "0x2D2B340", VA = "0x182D2C940")]
	public void CHDFFKAECIP(T[] OBKDNKHGCJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class CIFOBOMBMDE : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class IEJNMNCLHPP : IComparable<IEJNMNCLHPP>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class IBJIGGFHMEI : IEnumerable<IEJNMNCLHPP>, IEnumerable, IEnumerator<IEJNMNCLHPP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private IEJNMNCLHPP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public IEJNMNCLHPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private IEJNMNCLHPP System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
			[DebuggerHidden]
			public IBJIGGFHMEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x36B4E30", Offset = "0x36B3830", VA = "0x1836B4E30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x36B4F60", Offset = "0x36B3960", VA = "0x1836B4F60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x36B4EC0", Offset = "0x36B38C0", VA = "0x1836B4EC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IEJNMNCLHPP> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x36B4EC0", Offset = "0x36B38C0", VA = "0x1836B4EC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class APCFFJBPAFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
			public APCFFJBPAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x57F950", Offset = "0x57E350", VA = "0x18057F950")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x57F950", Offset = "0x57E350", VA = "0x18057F950")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly IEJNMNCLHPP[] BJHKCOKCAEE;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] FAFKFAKKFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong OBDCJIABNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int CKLNJLLILCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string AEMNOGNGCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private IEJNMNCLHPP[] NBGIHLBMDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] DDACECCODFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int LKEJFKMJCND;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KDGMJEIMAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xE3C9D0", Offset = "0xE3B3D0", VA = "0x180E3C9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36B62B0", Offset = "0x36B4CB0", VA = "0x1836B62B0")]
		public IEJNMNCLHPP(ulong IPKOPOLJGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x36B5000", Offset = "0x36B3A00", VA = "0x1836B5000")]
		public IEJNMNCLHPP CEGAKGBDODP(ulong IPKOPOLJGIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x36B4FB0", Offset = "0x36B39B0", VA = "0x1836B4FB0")]
		public IEJNMNCLHPP CEGAKGBDODP(ulong IPKOPOLJGIA, int HPIAFNBPEPC, string AEMNOGNGCFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x36B5460", Offset = "0x36B3E60", VA = "0x1836B5460")]
		public IEJNMNCLHPP NBOHLPGGIDJ(byte[] ONGPCLJCNFH, ref int EFGENLFBGLF, ref int NCLHFGCCBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x36B5220", Offset = "0x36B3C20", VA = "0x1836B5220")]
		internal static int DODCKLFFKOI(ulong[] OBKDNKHGCJN, int LGBFGOJBLFK, int HHALJLDHKOL, ulong HPIAFNBPEPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x36B51F0", Offset = "0x36B3BF0", VA = "0x1836B51F0", Slot = "4")]
		public int CompareTo(IEJNMNCLHPP KKPJJILPNAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x36B52A0", Offset = "0x36B3CA0", VA = "0x1836B52A0")]
		[IteratorStateMachine(typeof(IBJIGGFHMEI))]
		public IEnumerable<IEJNMNCLHPP> ILCKCOEGMGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x36B5310", Offset = "0x36B3D10", VA = "0x1836B5310")]
		public void MLFFAINLLKE(ILGenerator BAHIJJBPKKH, LocalBuilder ONGPCLJCNFH, LocalBuilder NCLHFGCCBKN, LocalBuilder IPKOPOLJGIA, Action<KeyValuePair<string, int>> DOFJECGDFNN, Action KHPPBEGJNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x36B5610", Offset = "0x36B4010", VA = "0x1836B5610")]
		private static void POBCICFCNOD(ILGenerator BAHIJJBPKKH, LocalBuilder ONGPCLJCNFH, LocalBuilder NCLHFGCCBKN, LocalBuilder IPKOPOLJGIA, Action<KeyValuePair<string, int>> DOFJECGDFNN, Action KHPPBEGJNGI, IEJNMNCLHPP[] NBGIHLBMDOM, int LKEJFKMJCND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FMAKBEDEGMP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<IEJNMNCLHPP> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<IEJNMNCLHPP> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<IEJNMNCLHPP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private IEJNMNCLHPP <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x577CC0", Offset = "0x5766C0", VA = "0x180577CC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x36B3270", Offset = "0x36B1C70", VA = "0x1836B3270", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3C850", Offset = "0xA3B250", VA = "0x180A3C850")]
		[DebuggerHidden]
		public FMAKBEDEGMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x36B32C0", Offset = "0x36B1CC0", VA = "0x1836B32C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x36B2E00", Offset = "0x36B1800", VA = "0x1836B2E00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x36B33C0", Offset = "0x36B1DC0", VA = "0x1836B33C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x36B3410", Offset = "0x36B1E10", VA = "0x1836B3410")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x36B3220", Offset = "0x36B1C20", VA = "0x1836B3220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x36B3180", Offset = "0x36B1B80", VA = "0x1836B3180", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x36B3180", Offset = "0x36B1B80", VA = "0x1836B3180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly IEJNMNCLHPP DDLLFFEEEME;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x36A9E90", Offset = "0x36A8890", VA = "0x1836A9E90")]
	public CIFOBOMBMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x36A9A30", Offset = "0x36A8430", VA = "0x1836A9A30")]
	public void CEGAKGBDODP(byte[] MCBNAPIFOAJ, int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x36A9CF0", Offset = "0x36A86F0", VA = "0x1836A9CF0")]
	public bool KHKHNBPILAC(ArraySegment<byte> IPKOPOLJGIA, out int HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x36A9DA0", Offset = "0x36A87A0", VA = "0x1836A9DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x36A97B0", Offset = "0x36A81B0", VA = "0x1836A97B0")]
	private static void BOKEFEHALPD(IEnumerable<IEJNMNCLHPP> NBGIHLBMDOM, StringBuilder CBPOGHHPGON, int FBHGCDEDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x36A9BF0", Offset = "0x36A85F0", VA = "0x1836A9BF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x36A9BF0", Offset = "0x36A85F0", VA = "0x1836A9BF0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x36A9B50", Offset = "0x36A8550", VA = "0x1836A9B50")]
	[IteratorStateMachine(typeof(FMAKBEDEGMP))]
	private static IEnumerable<KeyValuePair<string, int>> FBOHFBACHGO(IEnumerable<IEJNMNCLHPP> NBGIHLBMDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x36A9BC0", Offset = "0x36A85C0", VA = "0x1836A9BC0")]
	public void GEEOJEIMHAP(ILGenerator BAHIJJBPKKH, LocalBuilder ONGPCLJCNFH, LocalBuilder NCLHFGCCBKN, LocalBuilder IPKOPOLJGIA, Action<KeyValuePair<string, int>> DOFJECGDFNN, Action KHPPBEGJNGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class NODKLHBMCGI
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo MLCCCFPIHEF;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4772490", Offset = "0x4770E90", VA = "0x184772490")]
	public static ulong NLKGAHHLEIA(byte[] MCBNAPIFOAJ, ref int EFGENLFBGLF, ref int NCLHFGCCBKN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class KEOMJLODKFB
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x33A9070", Offset = "0x33A7A70", VA = "0x1833A9070")]
	public static void PJBHCHFGCIP(ref byte[] MCBNAPIFOAJ, int EFGENLFBGLF, int DFINGJIDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x33A8F80", Offset = "0x33A7980", VA = "0x1833A8F80")]
	public static void MEDEEPKBKGL(ref byte[] OBKDNKHGCJN, int EFBBJJEALLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x33A8E90", Offset = "0x33A7890", VA = "0x1833A8E90")]
	public static byte[] HKPACCJHEJG(byte[] MEJEPMBMJMJ, int EFBBJJEALLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class JABIFOLGFEJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x33A7910", Offset = "0x33A6310", VA = "0x1833A7910")]
	public static bool IAMAEONCFGH(byte[] IPBHLKFBFNC, int DOABBHFKDIO, int DBHNDJAJOFN, byte[] MJILJADKGOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class PGGILBMECPD<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct BHGJKKJPAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] OBDCJIABNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T CKLNJLLILCL;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2EDBF80", Offset = "0x2EDA980", VA = "0x182EDBF80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NBACKAIHDFJ : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::PGGILBMECPD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private BHGJKKJPAJK[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private BHGJKKJPAJK[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D7B0", Offset = "0x1A8C1B0", VA = "0x181A8D7B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EE4D90", Offset = "0x2EE3790", VA = "0x182EE4D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x120DCF0", Offset = "0x120C6F0", VA = "0x18120DCF0")]
		[DebuggerHidden]
		public NBACKAIHDFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2EE39E0", Offset = "0x2EE23E0", VA = "0x182EE39E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2EE47F0", Offset = "0x2EE31F0", VA = "0x182EE47F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly BHGJKKJPAJK[][] DDPFONOLJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong JNOLCDNKBEE;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA310", Offset = "0x2EE8D10", VA = "0x182EEA310")]
	public PGGILBMECPD(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA250", Offset = "0x2EE8C50", VA = "0x182EEA250")]
	public PGGILBMECPD(int POIIDIEGIKN, float PMOIAJAIBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8FE0", Offset = "0x2EE79E0", VA = "0x182EE8FE0")]
	public void CEGAKGBDODP(byte[] IPKOPOLJGIA, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9810", Offset = "0x2EE8210", VA = "0x182EE9810")]
	private bool IONFMHFIPMB(byte[] IPKOPOLJGIA, T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9260", Offset = "0x2EE7C60", VA = "0x182EE9260")]
	public bool FIJKPMMFIIC(ArraySegment<byte> IPKOPOLJGIA, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2EE97B0", Offset = "0x2EE81B0", VA = "0x182EE97B0")]
	private static ulong HCFPONENFHN(byte[] EDIMMNEBDAA, int EFGENLFBGLF, int LKEJFKMJCND)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA220", Offset = "0x2EE8C20", VA = "0x182EEA220")]
	private static int PKLPMINACCM(int BPIKIINOKDK, float PMOIAJAIBAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9690", Offset = "0x2EE8090", VA = "0x182EE9690", Slot = "4")]
	[IteratorStateMachine(typeof(global::PGGILBMECPD<>.NBACKAIHDFJ))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x26F1970", Offset = "0x26F0370", VA = "0x1826F1970", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class PPLNPDMOGEG : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] KJOJNDNGCFA;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] GPNGGILGKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int LLPKDBDGAGP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NGNGJMENNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x477B0F0", Offset = "0x4779AF0", VA = "0x18477B0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x477B140", Offset = "0x4779B40", VA = "0x18477B140")]
	static PPLNPDMOGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x477B390", Offset = "0x4779D90", VA = "0x18477B390")]
	public PPLNPDMOGEG(byte[] JEKNJMFKHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x477AFE0", Offset = "0x47799E0", VA = "0x18477AFE0")]
	public OpCode BCOBKMDAOGH()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct AGIIJDMNOGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid CKLNJLLILCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte GKBCBDALMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte GOCIOOKDEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte LPAJLBFGMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte FCNDHGFJOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte OMAKKMANOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JALGBJCMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte BJPLFADMOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte DMFODFCAEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte HGCKKPKANFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte HOLGDNOGFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte EICBLEAINIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte BGLIECBELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte GECGOBNBIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte IJOGBEILENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GOLAMMCIEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte OHHFBLNKEGK;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] AGMIBGENLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] JFHDIAPBCNG;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x36A03B0", Offset = "0x369EDB0", VA = "0x1836A03B0")]
	public AGIIJDMNOGO(ref Guid HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x369FD00", Offset = "0x369E700", VA = "0x18369FD00")]
	public AGIIJDMNOGO(ref ArraySegment<byte> NCCLJODPHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x369E740", Offset = "0x369D140", VA = "0x18369E740")]
	private static byte CFCDHJAEHGC(byte[] MCBNAPIFOAJ, int JMLCFFBPFCO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x369E800", Offset = "0x369D200", VA = "0x18369E800")]
	private static byte DACLBICPOHM(byte ODMIEFIFOGP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x369E910", Offset = "0x369D310", VA = "0x18369E910")]
	public void OAHHKABCHNK(byte[] HKIDJJNOKDE, int EFGENLFBGLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class CDPJGOEEBJJ
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x36A51B0", Offset = "0x36A3BB0", VA = "0x1836A51B0")]
	public static bool GBPIBEKDAOL(byte HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x36A4690", Offset = "0x36A3090", VA = "0x1836A4690")]
	public static bool AMFAMOPGCHE(byte HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x36A5F50", Offset = "0x36A4950", VA = "0x1836A5F50")]
	public static sbyte OAOEKFCIEHM(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x36A4880", Offset = "0x36A3280", VA = "0x1836A4880")]
	public static short COBOLEKNFCO(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x36A5140", Offset = "0x36A3B40", VA = "0x1836A5140")]
	public static int ELOKLDKLIOE(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x36A5FC0", Offset = "0x36A49C0", VA = "0x1836A5FC0")]
	public static long OGPILMDFGMC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x36A5230", Offset = "0x36A3C30", VA = "0x1836A5230")]
	public static byte IHFFJFHFPEF(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x36A52A0", Offset = "0x36A3CA0", VA = "0x1836A52A0")]
	public static ushort JJOHNOGFNMI(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x36A48F0", Offset = "0x36A32F0", VA = "0x1836A48F0")]
	public static uint DJCPPPJFBFP(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x36A4700", Offset = "0x36A3100", VA = "0x1836A4700")]
	public static ulong BGKLIEFBFBC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x36A51C0", Offset = "0x36A3BC0", VA = "0x1836A51C0")]
	public static float HAEFCCCAOLO(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x36A4810", Offset = "0x36A3210", VA = "0x1836A4810")]
	public static double CIMKDHCOHKE(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x36A4970", Offset = "0x36A3370", VA = "0x1836A4970")]
	public static int DOACEEBMFKB(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, ulong HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x36A5310", Offset = "0x36A3D10", VA = "0x1836A5310")]
	public static int KBKMNMIKIGD(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, long HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static bool AGHDEKDPCOC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class PLMGLHOLPFB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class KEBMIDDGNNO : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
		[DebuggerHidden]
		public KEBMIDDGNNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x476DE80", Offset = "0x476C880", VA = "0x18476DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x476DA20", Offset = "0x476C420", VA = "0x18476DA20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x476DFA0", Offset = "0x476C9A0", VA = "0x18476DFA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x476DFF0", Offset = "0x476C9F0", VA = "0x18476DFF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x476DE30", Offset = "0x476C830", VA = "0x18476DE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x476DD80", Offset = "0x476C780", VA = "0x18476DD80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x476DD80", Offset = "0x476C780", VA = "0x18476DD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class EIIJKCJHJDM : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
		[DebuggerHidden]
		public EIIJKCJHJDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x476D2F0", Offset = "0x476BCF0", VA = "0x18476D2F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x476CE90", Offset = "0x476B890", VA = "0x18476CE90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x476D410", Offset = "0x476BE10", VA = "0x18476D410")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x476D460", Offset = "0x476BE60", VA = "0x18476D460")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x476D2A0", Offset = "0x476BCA0", VA = "0x18476D2A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x476D1F0", Offset = "0x476BBF0", VA = "0x18476D1F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x476D1F0", Offset = "0x476BBF0", VA = "0x18476D1F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x477AA40", Offset = "0x4779440", VA = "0x18477AA40")]
	public static bool OJBJLPBKPAO(this TypeInfo IEADHAAGEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x477A8E0", Offset = "0x47792E0", VA = "0x18477A8E0")]
	public static bool IALCOOAIABM(this TypeInfo IEADHAAGEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x477A7F0", Offset = "0x47791F0", VA = "0x18477A7F0")]
	public static IEnumerable<PropertyInfo> CFHMPJBKHPL(this Type IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x477AAF0", Offset = "0x47794F0", VA = "0x18477AAF0")]
	[IteratorStateMachine(typeof(KEBMIDDGNNO))]
	private static IEnumerable<PropertyInfo> OOGBBPHEPCA(Type IEADHAAGEDA, HashSet<string> OFHIMJGDFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x477A9E0", Offset = "0x47793E0", VA = "0x18477A9E0")]
	public static IEnumerable<FieldInfo> KLJDFCMIMPA(this Type IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x477A850", Offset = "0x4779250", VA = "0x18477A850")]
	[IteratorStateMachine(typeof(EIIJKCJHJDM))]
	private static IEnumerable<FieldInfo> EOBFBJNBMHH(Type IEADHAAGEDA, HashSet<string> OFHIMJGDFDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class MNNJMCOCMMG
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding MHCJDOPCHOF;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class GDJBLGPNPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6184F0", Offset = "0x616EF0", VA = "0x1806184F0")]
	public static string MELOHGDMMDB(string GMKEBMDCCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x339CAC0", Offset = "0x339B4C0", VA = "0x18339CAC0")]
	public static string FDFCHIKOEPC(string GMKEBMDCCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x339CBD0", Offset = "0x339B5D0", VA = "0x18339CBD0")]
	public static string LDLIELGLBBO(string GMKEBMDCCCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class IGFADKHPDOF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BIENIMEHIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type OBDCJIABNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue CKLNJLLILCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int GDOKOIIODIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public BIENIMEHIDK GOMEMKPKNPB;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x36EBEC0", Offset = "0x36EA8C0", VA = "0x1836EBEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x36EBC60", Offset = "0x36EA660", VA = "0x1836EBC60")]
		private int HEBEBONJJIP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public BIENIMEHIDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class GKNPFFKCIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public GKNPFFKCIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6043C0", Offset = "0x602DC0", VA = "0x1806043C0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private BIENIMEHIDK[] DDPFONOLJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int OCEBHFCGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object MBPEMFEINDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float PMOIAJAIBAJ;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x36F5580", Offset = "0x36F3F80", VA = "0x1836F5580")]
	public IGFADKHPDOF(int POIIDIEGIKN = 4, float PMOIAJAIBAJ = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x36F52E0", Offset = "0x36F3CE0", VA = "0x1836F52E0")]
	public bool JPOPBPNIDEA(Type IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x36F5540", Offset = "0x36F3F40", VA = "0x1836F5540")]
	public bool JPOPBPNIDEA(Type IPKOPOLJGIA, Func<Type, TValue> EMEJAMGGEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x36F4B90", Offset = "0x36F3590", VA = "0x1836F4B90")]
	private bool IONFMHFIPMB(Type IPKOPOLJGIA, Func<Type, TValue> EMEJAMGGEHA, out TValue NHHIGOBDELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x36F4500", Offset = "0x36F2F00", VA = "0x1836F4500")]
	private bool AEEMGMGKFPO(BIENIMEHIDK[] DDPFONOLJEE, Type AIBDINMEHCK, BIENIMEHIDK IJGLKEPNDAK, Func<Type, TValue> EMEJAMGGEHA, out TValue NHHIGOBDELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x36F48F0", Offset = "0x36F32F0", VA = "0x1836F48F0")]
	public bool FIJKPMMFIIC(Type IPKOPOLJGIA, out TValue HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x36F5190", Offset = "0x36F3B90", VA = "0x1836F5190")]
	public TValue JJBBAKFANLO(Type IPKOPOLJGIA, Func<Type, TValue> EMEJAMGGEHA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA220", Offset = "0x2EE8C20", VA = "0x182EEA220")]
	private static int PKLPMINACCM(int BPIKIINOKDK, float PMOIAJAIBAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x36F48C0", Offset = "0x36F32C0", VA = "0x1836F48C0")]
	private static void BBPINEIPPEI(ref BIENIMEHIDK EDIICOPIJBG, BIENIMEHIDK HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x36F48C0", Offset = "0x36F32C0", VA = "0x1836F48C0")]
	private static void BBPINEIPPEI(ref BIENIMEHIDK[] EDIICOPIJBG, BIENIMEHIDK[] HPIAFNBPEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class NEMPGDCHPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder JEOOMLLIPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder KGINIEGLJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object GJOJILMPMCE;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x33AEC90", Offset = "0x33AD690", VA = "0x1833AEC90")]
	public TypeBuilder NCJJMKHIOMC(string JMIBJFINBJD, TypeAttributes LODADOOLOLI, Type MMEAACHMALE, Type[] NFAMNNLJDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x33AED80", Offset = "0x33AD780", VA = "0x1833AED80")]
	public NEMPGDCHPOI(string LJDMNOMNFNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class JPNCKBFMCFC
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x33A8CE0", Offset = "0x33A76E0", VA = "0x1833A8CE0")]
	private static MethodInfo KJJEHKDOPKK(LambdaExpression DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A037B0", Offset = "0x2A021B0", VA = "0x182A037B0")]
	public static MethodInfo JLMKJKBJGPC<T>(Expression<Func<T>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A037B0", Offset = "0x2A021B0", VA = "0x182A037B0")]
	public static MethodInfo JLMKJKBJGPC<T, TR>(Expression<Func<T, TR>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A037B0", Offset = "0x2A021B0", VA = "0x182A037B0")]
	public static MethodInfo JLMKJKBJGPC<T>(Expression<Action<T>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A037B0", Offset = "0x2A021B0", VA = "0x182A037B0")]
	public static MethodInfo JLMKJKBJGPC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2A03710", Offset = "0x2A02110", VA = "0x182A03710")]
	private static MemberInfo DKMAEAMNKDO<T>(Expression<T> EKMDJKANAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2A036B0", Offset = "0x2A020B0", VA = "0x182A036B0")]
	public static PropertyInfo BLJIOKKOFJL<T, TR>(Expression<Func<T, TR>> DMGDMFFGPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct DGGGCNDMAMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int PFAINNECIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool GIAACAMJHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator BAHIJJBPKKH;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x36AB690", Offset = "0x36AA090", VA = "0x1836AB690")]
	public DGGGCNDMAMN(ILGenerator BAHIJJBPKKH, int PFAINNECIEO, bool GIAACAMJHNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x36AB6D0", Offset = "0x36AA0D0", VA = "0x1836AB6D0")]
	public DGGGCNDMAMN(ILGenerator BAHIJJBPKKH, int PFAINNECIEO, Type IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x36AB580", Offset = "0x36A9F80", VA = "0x1836AB580")]
	public void JCCHNMHHKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class FIEIFKMBBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x36B2120", Offset = "0x36B0B20", VA = "0x1836B2120")]
	public static void OMKIDDFKOHM(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x36B2350", Offset = "0x36B0D50", VA = "0x1836B2350")]
	public static void OMKIDDFKOHM(this ILGenerator BAHIJJBPKKH, LocalBuilder PEKHFKOJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x36B1EB0", Offset = "0x36B08B0", VA = "0x1836B1EB0")]
	public static void OBEAMHCMHBK(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x36B20E0", Offset = "0x36B0AE0", VA = "0x1836B20E0")]
	public static void OBEAMHCMHBK(this ILGenerator BAHIJJBPKKH, LocalBuilder PEKHFKOJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x36B1430", Offset = "0x36AFE30", VA = "0x1836B1430")]
	public static void ELLKKJHLIED(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x36B1520", Offset = "0x36AFF20", VA = "0x1836B1520")]
	public static void ELLKKJHLIED(this ILGenerator BAHIJJBPKKH, LocalBuilder PEKHFKOJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x36B1C40", Offset = "0x36B0640", VA = "0x1836B1C40")]
	public static void IFLIDPLDKCE(this ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x36B2390", Offset = "0x36B0D90", VA = "0x1836B2390")]
	public static void POHCHCPAADK(this ILGenerator BAHIJJBPKKH, bool HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x36B16C0", Offset = "0x36B00C0", VA = "0x1836B16C0")]
	public static void FMAMEBPOOKP(this ILGenerator BAHIJJBPKKH, int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x36B1CD0", Offset = "0x36B06D0", VA = "0x1836B1CD0")]
	public static void LNFAFANJBPH(this ILGenerator BAHIJJBPKKH, Type IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x36B1B10", Offset = "0x36B0510", VA = "0x1836B1B10")]
	public static void HCNKFKGHDHN(this ILGenerator BAHIJJBPKKH, Type IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x36B1100", Offset = "0x36AFB00", VA = "0x1836B1100")]
	public static void BNPKCDJPDON(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x36B1C50", Offset = "0x36B0650", VA = "0x1836B1C50")]
	public static void JDOLOOFKDCK(this ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x36B1DC0", Offset = "0x36B07C0", VA = "0x1836B1DC0")]
	public static void MNFNOFOIFEL(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x36B1330", Offset = "0x36AFD30", VA = "0x1836B1330")]
	public static void EKGOBKNBMFM(this ILGenerator BAHIJJBPKKH, MethodInfo GAGLGCGJEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x36B1630", Offset = "0x36B0030", VA = "0x1836B1630")]
	public static void FJBDNLLLALE(this ILGenerator BAHIJJBPKKH, FieldInfo EIMPHMLBICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x36B1BB0", Offset = "0x36B05B0", VA = "0x1836B1BB0")]
	public static void IECHMIFBLAP(this ILGenerator BAHIJJBPKKH, ulong HPIAFNBPEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class FIIKBGBBFLN
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class BMFMIOLLDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public BMFMIOLLDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x36A4020", Offset = "0x36A2A20", VA = "0x1836A4020")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo LMKDFDPDLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo OLNDOBJNBPI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LENNIPLEDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EAAHBCNKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x36B2520", Offset = "0x36B0F20", VA = "0x1836B2520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AAAFMDHDGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x576EB0", Offset = "0x5758B0", VA = "0x180576EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6194B0", Offset = "0x617EB0", VA = "0x1806194B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PNCCFKIJDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x576EC0", Offset = "0x5758C0", VA = "0x180576EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x798B10", Offset = "0x797510", VA = "0x180798B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type KIONGMBJAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x551E90", VA = "0x180553490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x66D3A0", Offset = "0x66BDA0", VA = "0x18066D3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo CBLHENADNEP
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo BLCCBONHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x551EA0", VA = "0x1805534A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5766D0", VA = "0x180577CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo DJMMHCDKCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x552800", Offset = "0x551200", VA = "0x180552800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x552880", Offset = "0x551280", VA = "0x180552880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x36B2650", Offset = "0x36B1050", VA = "0x1836B2650")]
	protected FIIKBGBBFLN(Type IEADHAAGEDA, string JMIBJFINBJD, string ALMPKGJJFEH, bool HIIEFCCBDLB, bool BLLKGLFPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x36B2880", Offset = "0x36B1280", VA = "0x1836B2880")]
	public FIIKBGBBFLN(FieldInfo EEHCANMAMAN, string JMIBJFINBJD, bool PNKMJLMLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x36B26D0", Offset = "0x36B10D0", VA = "0x1836B26D0")]
	public FIIKBGBBFLN(PropertyInfo EEHCANMAMAN, string JMIBJFINBJD, bool PNKMJLMLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x36B2530", Offset = "0x36B0F30", VA = "0x1836B2530")]
	private static MethodInfo KFJINEHCOKE(MemberInfo EEHCANMAMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x275F460", Offset = "0x275DE60", VA = "0x18275F460")]
	public T LBALIGHEKAD<T>(bool MMJDIEBIOBG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x36B2460", Offset = "0x36B0E60", VA = "0x1836B2460", Slot = "4")]
	public virtual void ALAAMLENAEK(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x36B23A0", Offset = "0x36B0DA0", VA = "0x1836B23A0", Slot = "5")]
	public virtual void AIOIAOIKILP(ILGenerator BAHIJJBPKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class CJLANAODLKO : FIIKBGBBFLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string FPAPAPCFHOK;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x36AA010", Offset = "0x36A8A10", VA = "0x1836AA010")]
	public CJLANAODLKO(string JMIBJFINBJD, string FPAPAPCFHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x36A9F50", Offset = "0x36A8950", VA = "0x1836A9F50", Slot = "4")]
	public override void ALAAMLENAEK(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x36A9F00", Offset = "0x36A8900", VA = "0x1836A9F00", Slot = "5")]
	public override void AIOIAOIKILP(ILGenerator BAHIJJBPKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class CENNODFFIKC : FIIKBGBBFLN
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo DGKEGMJIEKM;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo DBJMIJHEKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal DGGGCNDMAMN NMDDPDPOALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal DGGGCNDMAMN ILNDLLIPJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal DGGGCNDMAMN DHGLCIMNDPD;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x36A6F50", Offset = "0x36A5950", VA = "0x1836A6F50")]
	public CENNODFFIKC(string JMIBJFINBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x36A68E0", Offset = "0x36A52E0", VA = "0x1836A68E0", Slot = "4")]
	public override void ALAAMLENAEK(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x36A6890", Offset = "0x36A5290", VA = "0x1836A6890", Slot = "5")]
	public override void AIOIAOIKILP(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x36A69A0", Offset = "0x36A53A0", VA = "0x1836A69A0")]
	public void DKOKHIBBPDF(ILGenerator BAHIJJBPKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class PAFFIENPFGC
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type KIONGMBJAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NAHHAEEMONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x789B40", Offset = "0x788540", VA = "0x180789B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x834490", Offset = "0x832E90", VA = "0x180834490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IKCJMKEPDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x79A130", Offset = "0x798B30", VA = "0x18079A130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8960D0", Offset = "0x894AD0", VA = "0x1808960D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo OKMBAOBCLII
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FIIKBGBBFLN[] BLLGDGIMNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x551E90", VA = "0x180553490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x66D3A0", Offset = "0x66BDA0", VA = "0x18066D3A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FIIKBGBBFLN[] BOAJOMNDMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4777790", Offset = "0x4776190", VA = "0x184777790")]
	public PAFFIENPFGC(Type IEADHAAGEDA, Func<string, string> HAHDGNKINBF, bool PNKMJLMLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x47776C0", Offset = "0x47760C0", VA = "0x1847776C0")]
	private static bool BGDAKKKOBCF(IEnumerator<ConstructorInfo> KICEBCPNPHN, ref ConstructorInfo GKAJNNPDMGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct PDELLNIGBNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong LAHEDMIAMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int OIFFLJDLBAO;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x284D910", Offset = "0x284C310", VA = "0x18284D910")]
	public PDELLNIGBNO(ulong IGJPHEDHODE, int EIEJBGLMMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4779990", Offset = "0x4778390", VA = "0x184779990")]
	public void MJEGOMGGHAC(ref PDELLNIGBNO KKPJJILPNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4779A40", Offset = "0x4778440", VA = "0x184779A40")]
	public static PDELLNIGBNO PBJLMINGJHG(ref PDELLNIGBNO MMADIBJKHHM, ref PDELLNIGBNO ODMIEFIFOGP)
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4779900", Offset = "0x4778300", VA = "0x184779900")]
	public void GNJAGKPJOGG(ref PDELLNIGBNO KKPJJILPNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4779A70", Offset = "0x4778470", VA = "0x184779A70")]
	public static PDELLNIGBNO PMKMDLCIMMK(ref PDELLNIGBNO MMADIBJKHHM, ref PDELLNIGBNO ODMIEFIFOGP)
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4779A00", Offset = "0x4778400", VA = "0x184779A00")]
	public void MPPHKPLKJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x47799A0", Offset = "0x47783A0", VA = "0x1847799A0")]
	public static PDELLNIGBNO MPPHKPLKJLB(ref PDELLNIGBNO MMADIBJKHHM)
	{
		return default(PDELLNIGBNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MKKNEHOHAKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] HKIDJJNOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int EFGENLFBGLF;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x9E9840", Offset = "0x9E8240", VA = "0x1809E9840")]
	public MKKNEHOHAKP(byte[] HKIDJJNOKDE, int BJMMNGJKEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x33ABC20", Offset = "0x33AA620", VA = "0x1833ABC20")]
	public void GFMGKCNJEOD(byte CDKMLIMBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x33ABDD0", Offset = "0x33AA7D0", VA = "0x1833ABDD0")]
	public void GKBFGBBGLDP(byte[] CDKMLIMBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x33ABD30", Offset = "0x33AA730", VA = "0x1833ABD30")]
	public void GGHHFJGFBGK(byte[] CDKMLIMBHIO, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x33ABC80", Offset = "0x33AA680", VA = "0x1833ABC80")]
	public void GGHHFJGFBGK(byte[] CDKMLIMBHIO, int FPGEEBEFGEH, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x33ABBA0", Offset = "0x33AA5A0", VA = "0x1833ABBA0")]
	public void COJIDIDIICH(byte HJNCMGDJMJJ, int LKEJFKMJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x33ABE70", Offset = "0x33AA870", VA = "0x1833ABE70")]
	public void HAEJLEFNLJM(string CDKMLIMBHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class NEBJOMAELLB
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum BOBBOGLKHOG
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum MNPENBEPDPL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum IHALKLDOHEL
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
	private static byte[] GCOBEEIJPIB;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] MJHOAIKMKGP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] IMDMALCBHOL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] PBPOHPHBDEM;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly IHALKLDOHEL IMFEHFHGLPF;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char EHCAJPBBGHL;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int HIFJEOHEKPD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int GKDHBDPJCGB;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] KLIHCEBAHLG;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x33AD820", Offset = "0x33AC220", VA = "0x1833AD820")]
	private static byte[] JPMLDJPJBKE(int OCEBHFCGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x33ACC50", Offset = "0x33AB650", VA = "0x1833ACC50")]
	private static byte[] BHBFHAOPNJH(int OCEBHFCGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x33AD8F0", Offset = "0x33AC2F0", VA = "0x1833AD8F0")]
	public static int KCBMLOAJGNH(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, float HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x33ADA00", Offset = "0x33AC400", VA = "0x1833ADA00")]
	public static int KCBMLOAJGNH(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, double HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x33ACD30", Offset = "0x33AB730", VA = "0x1833ACD30")]
	private static bool BMNBBKDGHBJ(byte[] HKIDJJNOKDE, int HHALJLDHKOL, ulong LFCKHJKNONO, ulong ENBCKLAPAHO, ulong NCLHFGCCBKN, ulong GGMOILCLOHI, ulong JHMKONCKHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x33AD420", Offset = "0x33ABE20", VA = "0x1833AD420")]
	private static void GBBFNAAPMLF(uint LMFEIPAOPBN, int HJLIGOJIOAF, out uint NMEMLBAGIBB, out int EGGBJLHOJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x33AE640", Offset = "0x33AD040", VA = "0x1833AE640")]
	private static bool MEOKCEJFLKD(PDELLNIGBNO INIKBPNBJPK, PDELLNIGBNO DECECNMMIBM, PDELLNIGBNO LIFKFDGDDCP, byte[] HKIDJJNOKDE, out int HHALJLDHKOL, out int GGPOFKMMKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x33ADCA0", Offset = "0x33AC6A0", VA = "0x1833ADCA0")]
	private static bool LDAMLICLNGG(double MEFNHMKKCJN, BOBBOGLKHOG OMMBLABNACO, byte[] HKIDJJNOKDE, out int HHALJLDHKOL, out int DNAHODDGBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x33AE550", Offset = "0x33ACF50", VA = "0x1833AE550")]
	private static bool LHDKHDOIAMG(double MEFNHMKKCJN, BOBBOGLKHOG OMMBLABNACO, byte[] HKIDJJNOKDE, out int HHALJLDHKOL, out int HAMBPGGOCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x33ADB10", Offset = "0x33AC510", VA = "0x1833ADB10")]
	private static bool KDLEMLLIPAB(double HPIAFNBPEPC, ref MKKNEHOHAKP BNCOILEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x33ADF20", Offset = "0x33AC920", VA = "0x1833ADF20")]
	private static bool LHDEFINAANF(double HPIAFNBPEPC, ref MKKNEHOHAKP BNCOILEGDOK, MNPENBEPDPL OMMBLABNACO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x33AD540", Offset = "0x33ABF40", VA = "0x1833AD540")]
	private static void IOABGMCEACM(byte[] KKFEDKPEOLE, int HHALJLDHKOL, int HAMBPGGOCGA, int CLPAJJMPMKP, ref MKKNEHOHAKP BNCOILEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x33ACE30", Offset = "0x33AB830", VA = "0x1833ACE30")]
	private static void EEPIDEGNMHF(byte[] KKFEDKPEOLE, int HHALJLDHKOL, int EIEJBGLMMNK, ref MKKNEHOHAKP BNCOILEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x33AD280", Offset = "0x33ABC80", VA = "0x1833AD280")]
	private static bool FJGLAELHOHD(double MEFNHMKKCJN, MNPENBEPDPL OMMBLABNACO, int JMHPHOGKJNO, byte[] OLHNBMEJPKP, out bool KCFLNNMBNAP, out int HHALJLDHKOL, out int BAMBIPKOPOH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct GOLHFDMGFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double GMLDCHLEGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong KMKBBEEOAKM;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct ICLNIENPJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float LAHEDMIAMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint IAPLFONKADL;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct EKHAOLDGFMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong NNBJAEAIFHP;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1261BE0", Offset = "0x12605E0", VA = "0x181261BE0")]
	public EKHAOLDGFMG(double GMLDCHLEGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x36AE700", Offset = "0x36AD100", VA = "0x1836AE700")]
	public EKHAOLDGFMG(PDELLNIGBNO GMLDCHLEGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x36AE680", Offset = "0x36AD080", VA = "0x1836AE680")]
	public PDELLNIGBNO PNGALAAAMKM()
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x36AE530", Offset = "0x36ACF30", VA = "0x1836AE530")]
	public PDELLNIGBNO NOMLMNNMNPD()
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6043B0", Offset = "0x602DB0", VA = "0x1806043B0")]
	public ulong EFJGNIPOFIB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x36AE340", Offset = "0x36ACD40", VA = "0x1836AE340")]
	public double HCMBJABCCCK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x36AE110", Offset = "0x36ACB10", VA = "0x1836AE110")]
	public double AKDDKLMMHPK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x36AE430", Offset = "0x36ACE30", VA = "0x1836AE430")]
	public int JGAFILFMJAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x36AE500", Offset = "0x36ACF00", VA = "0x1836AE500")]
	public ulong NOJDIOOCKPF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x36AE190", Offset = "0x36ACB90", VA = "0x1836AE190")]
	public bool ENFJPGLLCNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x36AE460", Offset = "0x36ACE60", VA = "0x1836AE460")]
	public bool JNJJJAAEPFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x36AE480", Offset = "0x36ACE80", VA = "0x1836AE480")]
	public bool KNJIOJKPKKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x36AE4D0", Offset = "0x36ACED0", VA = "0x1836AE4D0")]
	public bool NHNGILLLHKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x36AE4B0", Offset = "0x36ACEB0", VA = "0x1836AE4B0")]
	public int NDKHHMLMOFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x36AE1B0", Offset = "0x36ACBB0", VA = "0x1836AE1B0")]
	public void FMJLABMDJEC(out PDELLNIGBNO JDOIOBAOBGM, out PDELLNIGBNO OOFNKFGBCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x36AE3B0", Offset = "0x36ACDB0", VA = "0x1836AE3B0")]
	public bool HEHINCIACFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x36AE400", Offset = "0x36ACE00", VA = "0x1836AE400")]
	public double HPIAFNBPEPC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x36AE410", Offset = "0x36ACE10", VA = "0x1836AE410")]
	public static int HPKEJMKBLOC(int ANOGJAHAOAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x36AE5D0", Offset = "0x36ACFD0", VA = "0x1836AE5D0")]
	public static double OLOKBNMADCA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x36AE5E0", Offset = "0x36ACFE0", VA = "0x1836AE5E0")]
	public static ulong PEBCGCCKPIB(PDELLNIGBNO JKOFFBDDCEO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct CBIGKKICAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint IEIAFODKJFH;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x54F480", Offset = "0x54DE80", VA = "0x18054F480")]
	public CBIGKKICAIG(float LAHEDMIAMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x36A43D0", Offset = "0x36A2DD0", VA = "0x1836A43D0")]
	public PDELLNIGBNO PNGALAAAMKM()
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0")]
	public uint HHAIMNPCMJP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x36A4390", Offset = "0x36A2D90", VA = "0x1836A4390")]
	public int JGAFILFMJAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x36A43B0", Offset = "0x36A2DB0", VA = "0x1836A43B0")]
	public uint NOJDIOOCKPF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x36A41D0", Offset = "0x36A2BD0", VA = "0x1836A41D0")]
	public bool ENFJPGLLCNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x36A41E0", Offset = "0x36A2BE0", VA = "0x1836A41E0")]
	public void FMJLABMDJEC(out PDELLNIGBNO JDOIOBAOBGM, out PDELLNIGBNO OOFNKFGBCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x36A4350", Offset = "0x36A2D50", VA = "0x1836A4350")]
	public bool HEHINCIACFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct KAHCHIELCFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong IGJPHEDHODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short NEKAHHNFNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short DNAHODDGBLF;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x33A8DD0", Offset = "0x33A77D0", VA = "0x1833A8DD0")]
	public KAHCHIELCFM(ulong IGJPHEDHODE, short NEKAHHNFNNI, short DNAHODDGBLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class OOEMCALFECA
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly KAHCHIELCFM[] OIDDHDIJJPE;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x47752F0", Offset = "0x4773CF0", VA = "0x1847752F0")]
	public static void IEGPJJDOOOP(int GKJLHOONJEB, int FONLDFEMDAB, out PDELLNIGBNO NMEMLBAGIBB, out int DNAHODDGBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4775200", Offset = "0x4773C00", VA = "0x184775200")]
	public static void CHICLMDPHGI(int IGMFFBDLCGI, out PDELLNIGBNO NMEMLBAGIBB, out int AAINNDBLLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct GMKKBJHLNJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] MCBNAPIFOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int FPGEEBEFGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int ACBHBBFMNMK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x33A4B90", Offset = "0x33A3590", VA = "0x1833A4B90")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xC883D0", Offset = "0xC86DD0", VA = "0x180C883D0")]
	public GMKKBJHLNJG(byte[] MCBNAPIFOAJ, int FPGEEBEFGEH, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x960AC0", Offset = "0x95F4C0", VA = "0x180960AC0")]
	public int HHALJLDHKOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x33A4BD0", Offset = "0x33A35D0", VA = "0x1833A4BD0")]
	public GMKKBJHLNJG MHGDACELJBG(int KHDGLMKELFO, int HAIKPKKKLMD)
	{
		return default(GMKKBJHLNJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class HEBKGPGLNKP
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] BPJECGKJAHP;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] PFKDKPOAEKN;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int OCDLINCNKLB;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x33A5880", Offset = "0x33A4280", VA = "0x1833A5880")]
	private static byte[] CCCLEBFPDJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x33A5960", Offset = "0x33A4360", VA = "0x1833A5960")]
	private static GMKKBJHLNJG INBAFLHNNLN(GMKKBJHLNJG HKIDJJNOKDE)
	{
		return default(GMKKBJHLNJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x33A6310", Offset = "0x33A4D10", VA = "0x1833A6310")]
	private static GMKKBJHLNJG MCFCCAFEMJB(GMKKBJHLNJG HKIDJJNOKDE)
	{
		return default(GMKKBJHLNJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x33A6620", Offset = "0x33A5020", VA = "0x1833A6620")]
	private static void PDKPLNFEOOC(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK, byte[] IAPNGNHCHFE, out int ANBAIBFIAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x33A5160", Offset = "0x33A3B60", VA = "0x1833A5160")]
	private static void BKCDCCKHCFD(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK, byte[] FAFDBIOALGG, int JKHDMBCLDLD, out GMKKBJHLNJG DKBOKHCAIEF, out int LDIADADFOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x33A63F0", Offset = "0x33A4DF0", VA = "0x1833A63F0")]
	private static ulong NNNCEFMOIPL(GMKKBJHLNJG HKIDJJNOKDE, out int PKKHGLDFHGE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x33A6480", Offset = "0x33A4E80", VA = "0x1833A6480")]
	private static void ODCFKEGNMJC(GMKKBJHLNJG HKIDJJNOKDE, out PDELLNIGBNO HEMKPPOPDKI, out int APFALJHBIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x33A5A40", Offset = "0x33A4440", VA = "0x1833A5A40")]
	private static bool KHMLPKGFHNE(GMKKBJHLNJG DKBOKHCAIEF, int EIEJBGLMMNK, out double HEMKPPOPDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x33A61B0", Offset = "0x33A4BB0", VA = "0x1833A61B0")]
	private static PDELLNIGBNO LMNPELNEAIC(int EIEJBGLMMNK)
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x33A5480", Offset = "0x33A3E80", VA = "0x1833A5480")]
	private static bool BPOIMHFHPAG(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK, out double HEMKPPOPDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x33A6070", Offset = "0x33A4A70", VA = "0x1833A6070")]
	private static bool LELEKIFKIBJ(GMKKBJHLNJG DKBOKHCAIEF, int EIEJBGLMMNK, out double KLEFCPEKLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x33A5030", Offset = "0x33A3A30", VA = "0x1833A5030")]
	public static double? ACLIJHCJNEO(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x33A5E90", Offset = "0x33A4890", VA = "0x1833A5E90")]
	public static float? LEFDJEPLDOH(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct BHNMJNEJIGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] HKIDJJNOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int EFGENLFBGLF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x36A3BB0", Offset = "0x36A25B0", VA = "0x1836A3BB0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9E9840", Offset = "0x9E8240", VA = "0x1809E9840")]
	public BHNMJNEJIGI(byte[] HKIDJJNOKDE, int EFGENLFBGLF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x36A3C70", Offset = "0x36A2670", VA = "0x1836A3C70")]
	public static BHNMJNEJIGI OAONKMPIPOH(BHNMJNEJIGI NPNHPOMDOAL)
	{
		return default(BHNMJNEJIGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x36A3AD0", Offset = "0x36A24D0", VA = "0x1836A3AD0")]
	public static BHNMJNEJIGI EKHKEPKDEBI(BHNMJNEJIGI NPNHPOMDOAL, int HHALJLDHKOL)
	{
		return default(BHNMJNEJIGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x36A3BF0", Offset = "0x36A25F0", VA = "0x1836A3BF0")]
	public static int LOLOPLNMBHA(BHNMJNEJIGI JINPLGIOFKM, BHNMJNEJIGI LFEBODKGKDF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x36A3C10", Offset = "0x36A2610", VA = "0x1836A3C10")]
	public static bool NDENBEODPDO(BHNMJNEJIGI JINPLGIOFKM, BHNMJNEJIGI LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x36A3A70", Offset = "0x36A2470", VA = "0x1836A3A70")]
	public static bool BMFMMFJPNNG(BHNMJNEJIGI JINPLGIOFKM, BHNMJNEJIGI LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x36A3C30", Offset = "0x36A2630", VA = "0x1836A3C30")]
	public static bool NDENBEODPDO(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x36A3A90", Offset = "0x36A2490", VA = "0x1836A3A90")]
	public static bool BMFMMFJPNNG(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x36A3A90", Offset = "0x36A2490", VA = "0x1836A3A90")]
	public static bool BMFMMFJPNNG(BHNMJNEJIGI JINPLGIOFKM, byte LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x36A3B30", Offset = "0x36A2530", VA = "0x1836A3B30")]
	public static bool HCBFEEPKFFF(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x36A3C80", Offset = "0x36A2680", VA = "0x1836A3C80")]
	public static bool OKHPEDBCKHF(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x36A3CC0", Offset = "0x36A26C0", VA = "0x1836A3CC0")]
	public static bool PIGDEDHIPLA(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x36A3B70", Offset = "0x36A2570", VA = "0x1836A3B70")]
	public static bool IJILNAIPBJP(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class NIMNLBAELOH
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] ELEDFDNKDON;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] EADIJBLOJFP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] IMDMALCBHOL;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] PBPOHPHBDEM;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] OEEFLDAMPIL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int MHMKJLOIDHL;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] LFEBHBACEED;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int JKKKDPBBEBI;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4770020", Offset = "0x476EA20", VA = "0x184770020")]
	private static byte[] PIFPHDIALGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x476E9D0", Offset = "0x476D3D0", VA = "0x18476E9D0")]
	private static byte[] ECIFNHACLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x476FF60", Offset = "0x476E960", VA = "0x18476FF60")]
	public static double OMFPFLBJJIJ(byte[] HKIDJJNOKDE, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x476FE50", Offset = "0x476E850", VA = "0x18476FE50")]
	public static float LPBDFENPPJJ(byte[] HKIDJJNOKDE, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x476FCD0", Offset = "0x476E6D0", VA = "0x18476FCD0")]
	private static bool GMMFHPNIIOK(int EDIMMNEBDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x476E8B0", Offset = "0x476D2B0", VA = "0x18476E8B0")]
	private static bool CLOHCKMOGJB(ref BHNMJNEJIGI LPKFHMBJKIB, BHNMJNEJIGI OLBLGDADAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x476EAB0", Offset = "0x476D4B0", VA = "0x18476EAB0")]
	private static bool EPJNIPHAMKC(ref BHNMJNEJIGI LPKFHMBJKIB, BHNMJNEJIGI OLBLGDADAAO, byte[] GEJOIEMJMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x476FF10", Offset = "0x476E910", VA = "0x18476FF10")]
	private static bool NINJEIJBLAP(ref BHNMJNEJIGI NKNLKOGACDJ, byte[] CDKMLIMBHIO, int EFGENLFBGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC90", Offset = "0x6F9690", VA = "0x1806FAC90")]
	private static double IBEEPFHKGIA(bool KCFLNNMBNAP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x476EBC0", Offset = "0x476D5C0", VA = "0x18476EBC0")]
	private static double GMLJGAJDLFC(BHNMJNEJIGI COLAPMIPADC, int HHALJLDHKOL, bool PNDGOPGGBFB, out int GCNDLFMCGKO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class LANJKFOKBHM<T> : global::EGNEGNMBKFG<T[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::MJLBBJKMKCK<T> HDKELCEMPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly GILNJOLHANP BOBPILNLIOM;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x28D3A80", Offset = "0x28D2480", VA = "0x1828D3A80")]
	public LANJKFOKBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x120DCF0", Offset = "0x120C6F0", VA = "0x18120DCF0")]
	public LANJKFOKBHM(GILNJOLHANP BOBPILNLIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3F151B0", Offset = "0x3F13BB0", VA = "0x183F151B0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3F13620", Offset = "0x3F12020", VA = "0x183F13620", Slot = "5")]
	public T[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class FICCMDGEHHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::MJLBBJKMKCK<T> HDKELCEMPME;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class NMEFIJMKHGN<T> : global::EGNEGNMBKFG<List<T>>, EGFLKHELIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly GILNJOLHANP BOBPILNLIOM;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x28D3A80", Offset = "0x28D2480", VA = "0x1828D3A80")]
	public NMEFIJMKHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x120DCF0", Offset = "0x120C6F0", VA = "0x18120DCF0")]
	public NMEFIJMKHGN(GILNJOLHANP BOBPILNLIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x28D2DC0", Offset = "0x28D17C0", VA = "0x1828D2DC0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, List<T> HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x28D29D0", Offset = "0x28D13D0", VA = "0x1828D29D0", Slot = "5")]
	public List<T> FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class KBIJAJBPMCD<TElement, TIntermediate, TEnumerator, TCollection> : global::EGNEGNMBKFG<TCollection>, EGFLKHELIAB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x40C4BC0", Offset = "0x40C35C0", VA = "0x1840C4BC0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, TCollection HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x40C3F80", Offset = "0x40C2980", VA = "0x1840C3F80", Slot = "5")]
	public TCollection FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KEDKPBOLKJP(TCollection EKMDJKANAME);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate AEEGCHIFHAD();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CEGAKGBDODP(ref TIntermediate JFAFFHBNMKC, int LGBFGOJBLFK, TElement HPIAFNBPEPC);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection DCGILHLCDMK(ref TIntermediate GMLLNFMAGKG);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
	protected KBIJAJBPMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class MIJGBNKLLAH<TElement, TIntermediate, TCollection> : global::KBIJAJBPMCD<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A7F0", Offset = "0x2D291F0", VA = "0x182D2A7F0", Slot = "6")]
	protected override IEnumerator<TElement> KEDKPBOLKJP(TCollection EKMDJKANAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x218F580", Offset = "0x218DF80", VA = "0x18218F580")]
	protected MIJGBNKLLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class POONNIOLCOH<TElement, TCollection> : global::MIJGBNKLLAH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected sealed override TCollection DCGILHLCDMK(ref TCollection GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class HIMCPKAGMFE<TElement, TCollection> : global::POONNIOLCOH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3602EA0", Offset = "0x36018A0", VA = "0x183602EA0", Slot = "7")]
	protected override TCollection AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3602EC0", Offset = "0x36018C0", VA = "0x183602EC0", Slot = "8")]
	protected override void CEGAKGBDODP(ref TCollection JFAFFHBNMKC, int LGBFGOJBLFK, TElement HPIAFNBPEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GLJIINIIPFA<T> : global::KBIJAJBPMCD<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x333E1E0", Offset = "0x333CBE0", VA = "0x18333E1E0", Slot = "8")]
	protected override void CEGAKGBDODP(ref LinkedList<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override LinkedList<T> DCGILHLCDMK(ref LinkedList<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override LinkedList<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x333E220", Offset = "0x333CC20", VA = "0x18333E220", Slot = "6")]
	protected override LinkedList<T>.Enumerator KEDKPBOLKJP(LinkedList<T> EKMDJKANAME)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class FOBJEGNANOL<T> : global::KBIJAJBPMCD<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x333E1E0", Offset = "0x333CBE0", VA = "0x18333E1E0", Slot = "8")]
	protected override void CEGAKGBDODP(ref Queue<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override Queue<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2E712C0", Offset = "0x2E6FCC0", VA = "0x182E712C0", Slot = "6")]
	protected override Queue<T>.Enumerator KEDKPBOLKJP(Queue<T> EKMDJKANAME)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override Queue<T> DCGILHLCDMK(ref Queue<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DMOIFLIPEPC<T> : global::KBIJAJBPMCD<T, global::MLNAMEPCKNM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x28E38C0", Offset = "0x28E22C0", VA = "0x1828E38C0", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x28E3870", Offset = "0x28E2270", VA = "0x1828E3870", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2E712C0", Offset = "0x2E6FCC0", VA = "0x182E712C0", Slot = "6")]
	protected override Stack<T>.Enumerator KEDKPBOLKJP(Stack<T> EKMDJKANAME)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2E711E0", Offset = "0x2E6FBE0", VA = "0x182E711E0", Slot = "9")]
	protected override Stack<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NJCGKJMEDOB<T> : global::KBIJAJBPMCD<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x333E1E0", Offset = "0x333CBE0", VA = "0x18333E1E0", Slot = "8")]
	protected override void CEGAKGBDODP(ref HashSet<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override HashSet<T> DCGILHLCDMK(ref HashSet<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override HashSet<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2E712C0", Offset = "0x2E6FCC0", VA = "0x182E712C0", Slot = "6")]
	protected override HashSet<T>.Enumerator KEDKPBOLKJP(HashSet<T> EKMDJKANAME)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NHDIEFFNPCN<T> : global::MIJGBNKLLAH<T, global::MLNAMEPCKNM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x28E38C0", Offset = "0x28E22C0", VA = "0x1828E38C0", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3E23050", Offset = "0x3E21A50", VA = "0x183E23050", Slot = "9")]
	protected override ReadOnlyCollection<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3E23000", Offset = "0x3E21A00", VA = "0x183E23000", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class KABLJICJJMN<T> : global::MIJGBNKLLAH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x333E1E0", Offset = "0x333CBE0", VA = "0x18333E1E0", Slot = "8")]
	protected override void CEGAKGBDODP(ref List<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override List<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override IList<T> DCGILHLCDMK(ref List<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class FGFBEBMBDCH<T> : global::MIJGBNKLLAH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x333E1E0", Offset = "0x333CBE0", VA = "0x18333E1E0", Slot = "8")]
	protected override void CEGAKGBDODP(ref List<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override List<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override ICollection<T> DCGILHLCDMK(ref List<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class BKKPKEGNCME<T> : global::MIJGBNKLLAH<T, global::MLNAMEPCKNM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x28E38C0", Offset = "0x28E22C0", VA = "0x1828E38C0", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x28E3870", Offset = "0x28E2270", VA = "0x1828E3870", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28E38F0", Offset = "0x28E22F0", VA = "0x1828E38F0", Slot = "9")]
	protected override IEnumerable<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class ONCJDOBNHIG<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class DHLAGIADEFO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class LKCKNLPOJLG<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class NMPDECOAPBN : global::EGNEGNMBKFG<IEnumerable>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::EGNEGNMBKFG<IEnumerable> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4772050", Offset = "0x4770A50", VA = "0x184772050", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, IEnumerable HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4771ED0", Offset = "0x47708D0", VA = "0x184771ED0", Slot = "5")]
	public IEnumerable FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NMPDECOAPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class PJDDGKCGEPK : global::EGNEGNMBKFG<ICollection>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::EGNEGNMBKFG<ICollection> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4779FF0", Offset = "0x47789F0", VA = "0x184779FF0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ICollection HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4779E70", Offset = "0x4778870", VA = "0x184779E70", Slot = "5")]
	public ICollection FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PJDDGKCGEPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class ICIOFOAAFIB : global::EGNEGNMBKFG<IList>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::EGNEGNMBKFG<IList> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x33A70B0", Offset = "0x33A5AB0", VA = "0x1833A70B0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, IList HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x33A6EC0", Offset = "0x33A58C0", VA = "0x1833A6EC0", Slot = "5")]
	public IList FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public ICIOFOAAFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JGENHBGNADM<T> : global::MIJGBNKLLAH<T, global::MLNAMEPCKNM<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x29D46D0", Offset = "0x29D30D0", VA = "0x1829D46D0", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x28E3870", Offset = "0x28E2270", VA = "0x1828E3870", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x29D4700", Offset = "0x29D3100", VA = "0x1829D4700", Slot = "9")]
	protected override IReadOnlyList<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2190460", Offset = "0x218EE60", VA = "0x182190460")]
	public JGENHBGNADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class EPLKHAJPKKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x36AF3F0", Offset = "0x36ADDF0", VA = "0x1836AF3F0")]
	public static DateTime CMIAHIAIAJB(DateTime BEAIOFOLPGN)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class ONBGMADEJCI : global::EGNEGNMBKFG<DateTime>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::EGNEGNMBKFG<DateTime> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4774D50", Offset = "0x4773750", VA = "0x184774D50", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, DateTime HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4773E50", Offset = "0x4772850", VA = "0x184773E50", Slot = "5")]
	public DateTime FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public ONBGMADEJCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class BBGNNMOKHEI : global::EGNEGNMBKFG<DateTimeOffset>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::EGNEGNMBKFG<DateTimeOffset> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x36A2250", Offset = "0x36A0C50", VA = "0x1836A2250", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, DateTimeOffset HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x36A1370", Offset = "0x369FD70", VA = "0x1836A1370", Slot = "5")]
	public DateTimeOffset FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public BBGNNMOKHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class AIDJBLCJOHD : global::EGNEGNMBKFG<TimeSpan>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::EGNEGNMBKFG<TimeSpan> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] OINBADDHKBD;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x36A0C30", Offset = "0x369F630", VA = "0x1836A0C30", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, TimeSpan HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x36A03C0", Offset = "0x369EDC0", VA = "0x1836A03C0", Slot = "5")]
	public TimeSpan FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public AIDJBLCJOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class HJHIMNEIOCJ<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::EGNEGNMBKFG<TDictionary>, EGFLKHELIAB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x36050E0", Offset = "0x3603AE0", VA = "0x1836050E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, TDictionary HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3602FA0", Offset = "0x36019A0", VA = "0x183602FA0", Slot = "5")]
	public TDictionary FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KEDKPBOLKJP(TDictionary EKMDJKANAME);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate AEEGCHIFHAD();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CEGAKGBDODP(ref TIntermediate JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary DCGILHLCDMK(ref TIntermediate GMLLNFMAGKG);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
	protected HJHIMNEIOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class GLGMOKDEAFK<TKey, TValue, TIntermediate, TDictionary> : global::HJHIMNEIOCJ<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A7F0", Offset = "0x2D291F0", VA = "0x182D2A7F0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> KEDKPBOLKJP(TDictionary EKMDJKANAME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class JLNOOHMAFBK<TKey, TValue, TDictionary> : global::GLGMOKDEAFK<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override TDictionary DCGILHLCDMK(ref TDictionary GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KLDONNKNJCN<TKey, TValue> : global::HJHIMNEIOCJ<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDBB0", Offset = "0x3DCC5B0", VA = "0x183DCDBB0", Slot = "8")]
	protected override void CEGAKGBDODP(ref Dictionary<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override Dictionary<TKey, TValue> DCGILHLCDMK(ref Dictionary<TKey, TValue> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override Dictionary<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDBF0", Offset = "0x3DCC5F0", VA = "0x183DCDBF0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator KEDKPBOLKJP(Dictionary<TKey, TValue> EKMDJKANAME)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2196D30", Offset = "0x2195730", VA = "0x182196D30")]
	public KLDONNKNJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BIKIIBDDLDJ<TKey, TValue, TDictionary> : global::JLNOOHMAFBK<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x28E25C0", Offset = "0x28E0FC0", VA = "0x1828E25C0", Slot = "8")]
	protected override void CEGAKGBDODP(ref TDictionary JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x28E25A0", Offset = "0x28E0FA0", VA = "0x1828E25A0", Slot = "7")]
	protected override TDictionary AEEGCHIFHAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JLHDIDHLLNK<TKey, TValue> : global::GLGMOKDEAFK<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x25DBBB0", Offset = "0x25DA5B0", VA = "0x1825DBBB0", Slot = "8")]
	protected override void CEGAKGBDODP(ref Dictionary<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override Dictionary<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override IDictionary<TKey, TValue> DCGILHLCDMK(ref Dictionary<TKey, TValue> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class PNINKJMJNAE<TKey, TValue> : global::JLNOOHMAFBK<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x25DBBB0", Offset = "0x25DA5B0", VA = "0x1825DBBB0", Slot = "8")]
	protected override void CEGAKGBDODP(ref SortedList<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override SortedList<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class HKAHAEOHGDE<TKey, TValue> : global::HJHIMNEIOCJ<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x25DBBB0", Offset = "0x25DA5B0", VA = "0x1825DBBB0", Slot = "8")]
	protected override void CEGAKGBDODP(ref SortedDictionary<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x14D63D0", Offset = "0x14D4DD0", VA = "0x1814D63D0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DCGILHLCDMK(ref SortedDictionary<TKey, TValue> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x25DBB50", Offset = "0x25DA550", VA = "0x1825DBB50", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x36088A0", Offset = "0x36072A0", VA = "0x1836088A0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator KEDKPBOLKJP(SortedDictionary<TKey, TValue> EKMDJKANAME)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class EBCNCKAGLFE<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class BFBDEAEAMJF : global::EGNEGNMBKFG<IDictionary>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::EGNEGNMBKFG<IDictionary> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x36A3580", Offset = "0x36A1F80", VA = "0x1836A3580", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, IDictionary HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x36A33E0", Offset = "0x36A1DE0", VA = "0x1836A33E0", Slot = "5")]
	public IDictionary FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public BFBDEAEAMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class PBDNPMFBHEK : global::EGNEGNMBKFG<object>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void GOIAMKPMMLL(object IANJBMFCJFP, ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::IGFADKHPDOF<KeyValuePair<object, GOIAMKPMMLL>> HDKNFJFJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly CGDCFJDMLCL[] BKCLHMIDGNL;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x47793A0", Offset = "0x4777DA0", VA = "0x1847793A0")]
	public PBDNPMFBHEK(params CGDCFJDMLCL[] BKCLHMIDGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4778BD0", Offset = "0x47775D0", VA = "0x184778BD0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4778B40", Offset = "0x4777540", VA = "0x184778B40", Slot = "5")]
	public object FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class KMCOKMKPJEE
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x33AA1B0", Offset = "0x33A8BB0", VA = "0x1833AA1B0")]
	public static object HAMGHKKCLOL(Type IEADHAAGEDA, out bool ADIAPEKEAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x33A99D0", Offset = "0x33A83D0", VA = "0x1833A99D0")]
	public static object DCKCOPLOPBP(Type IEADHAAGEDA, out bool ADIAPEKEAMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class CNMECNKAOIP<T> : global::EGNEGNMBKFG<T>, EGFLKHELIAB, global::DEACOEJPGKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class KFNCICKAONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public KFNCICKAONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3F86C60", Offset = "0x3F85660", VA = "0x183F86C60")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class HFDDCPEPOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::LLFEIEDIHFE<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public HFDDCPEPOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3470240", Offset = "0x346EC40", VA = "0x183470240")]
		internal void <.cctor>b__1(ref FBIFMPDMBBF writer, T value, CGDCFJDMLCL _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class KOFLBHOKNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::HANEIHONNAN<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public KOFLBHOKNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3F87BF0", Offset = "0x3F865F0", VA = "0x183F87BF0")]
		internal T <.cctor>b__2(ref NHAPBMMNKAC reader, CGDCFJDMLCL _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::PGGILBMECPD<T> DIPBCKOOGFJ;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> KDNMEDDOPPB;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::LLFEIEDIHFE<T> OMBNECKOABM;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::HANEIHONNAN<T> KEJOPEIBHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool LPOHOPFLKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::LLFEIEDIHFE<T> KIBEIEIFBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::HANEIHONNAN<T> AEAOOJCPKBG;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3F79040", Offset = "0x3F77A40", VA = "0x183F79040")]
	static CNMECNKAOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD800", Offset = "0x2DAC200", VA = "0x182DAD800")]
	public CNMECNKAOIP(bool LPOHOPFLKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3F72DE0", Offset = "0x3F717E0", VA = "0x183F72DE0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3F6FED0", Offset = "0x3F6E8D0", VA = "0x183F6FED0", Slot = "5")]
	public T FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E580", Offset = "0x2D9CF80", VA = "0x182D9E580", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3F6D4E0", Offset = "0x3F6BEE0", VA = "0x183F6D4E0", Slot = "7")]
	public T DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class MOFLJBIGKDM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MIHAAPEKPMG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class OCAMLINHPFG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class MMCKFFCGFND<T> : global::EGNEGNMBKFG<T?>, EGFLKHELIAB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC79D0", Offset = "0x3EC63D0", VA = "0x183EC79D0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC75A0", Offset = "0x3EC5FA0", VA = "0x183EC75A0", Slot = "5")]
	public T? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
	public MMCKFFCGFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class MPJLMJPBNKI<T> : global::EGNEGNMBKFG<T?>, EGFLKHELIAB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::EGNEGNMBKFG<T> HLNJJCAFPOF;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1202180", Offset = "0x1200B80", VA = "0x181202180")]
	public MPJLMJPBNKI(global::EGNEGNMBKFG<T> HLNJJCAFPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8B00", Offset = "0x3EC7500", VA = "0x183EC8B00", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8830", Offset = "0x3EC7230", VA = "0x183EC8830", Slot = "5")]
	public T? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class ECALPLEKJEL : global::EGNEGNMBKFG<sbyte>, EGFLKHELIAB, global::DEACOEJPGKF<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly ECALPLEKJEL GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x36AC6B0", Offset = "0x36AB0B0", VA = "0x1836AC6B0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, sbyte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x36AC5E0", Offset = "0x36AAFE0", VA = "0x1836AC5E0", Slot = "5")]
	public sbyte FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x36AC5F0", Offset = "0x36AAFF0", VA = "0x1836AC5F0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, sbyte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x36AC540", Offset = "0x36AAF40", VA = "0x1836AC540", Slot = "7")]
	public sbyte DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public ECALPLEKJEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NCGCFLOEHKN : global::EGNEGNMBKFG<sbyte?>, EGFLKHELIAB, global::DEACOEJPGKF<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly NCGCFLOEHKN GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x33ACA00", Offset = "0x33AB400", VA = "0x1833ACA00", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, sbyte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x33AC8D0", Offset = "0x33AB2D0", VA = "0x1833AC8D0", Slot = "5")]
	public sbyte? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x33AC980", Offset = "0x33AB380", VA = "0x1833AC980", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, sbyte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x33AC820", Offset = "0x33AB220", VA = "0x1833AC820", Slot = "7")]
	public sbyte? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NCGCFLOEHKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class CKCKKLBPFAO : global::EGNEGNMBKFG<sbyte[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly CKCKKLBPFAO GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x36AA220", Offset = "0x36A8C20", VA = "0x1836AA220", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, sbyte[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x36AA0E0", Offset = "0x36A8AE0", VA = "0x1836AA0E0", Slot = "5")]
	public sbyte[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public CKCKKLBPFAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JLGOIGAOHAH : global::EGNEGNMBKFG<short>, EGFLKHELIAB, global::DEACOEJPGKF<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly JLGOIGAOHAH GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x33A8750", Offset = "0x33A7150", VA = "0x1833A8750", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, short HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x33A86B0", Offset = "0x33A70B0", VA = "0x1833A86B0", Slot = "5")]
	public short FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x33A8710", Offset = "0x33A7110", VA = "0x1833A8710", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, short HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x33A8640", Offset = "0x33A7040", VA = "0x1833A8640", Slot = "7")]
	public short DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public JLGOIGAOHAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class CMBPLFPDHIL : global::EGNEGNMBKFG<short?>, EGFLKHELIAB, global::DEACOEJPGKF<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly CMBPLFPDHIL GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x36AA8B0", Offset = "0x36A92B0", VA = "0x1836AA8B0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, short? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x36AA740", Offset = "0x36A9140", VA = "0x1836AA740", Slot = "5")]
	public short? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x36AA7B0", Offset = "0x36A91B0", VA = "0x1836AA7B0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, short? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x36AA670", Offset = "0x36A9070", VA = "0x1836AA670", Slot = "7")]
	public short? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public CMBPLFPDHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class PDBNAOHLOAA : global::EGNEGNMBKFG<short[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly PDBNAOHLOAA GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x47797E0", Offset = "0x47781E0", VA = "0x1847797E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, short[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x47796A0", Offset = "0x47780A0", VA = "0x1847796A0", Slot = "5")]
	public short[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PDBNAOHLOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class NEAPIIIPGFM : global::EGNEGNMBKFG<int>, EGFLKHELIAB, global::DEACOEJPGKF<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NEAPIIIPGFM GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x33ACBE0", Offset = "0x33AB5E0", VA = "0x1833ACBE0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, int HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x33ACB40", Offset = "0x33AB540", VA = "0x1833ACB40", Slot = "5")]
	public int FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x33ACBA0", Offset = "0x33AB5A0", VA = "0x1833ACBA0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, int HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x33ACAD0", Offset = "0x33AB4D0", VA = "0x1833ACAD0", Slot = "7")]
	public int DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NEAPIIIPGFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class BLLDJGMHFME : global::EGNEGNMBKFG<int?>, EGFLKHELIAB, global::DEACOEJPGKF<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly BLLDJGMHFME GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x36A3F40", Offset = "0x36A2940", VA = "0x1836A3F40", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, int? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x36A3DD0", Offset = "0x36A27D0", VA = "0x1836A3DD0", Slot = "5")]
	public int? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x36A3E40", Offset = "0x36A2840", VA = "0x1836A3E40", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, int? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x36A3D00", Offset = "0x36A2700", VA = "0x1836A3D00", Slot = "7")]
	public int? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public BLLDJGMHFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class GOKLBHEOFHH : global::EGNEGNMBKFG<int[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly GOKLBHEOFHH GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x33A4F10", Offset = "0x33A3910", VA = "0x1833A4F10", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, int[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x33A4D70", Offset = "0x33A3770", VA = "0x1833A4D70", Slot = "5")]
	public int[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public GOKLBHEOFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class GNFEKFDMGGE : global::EGNEGNMBKFG<long>, EGFLKHELIAB, global::DEACOEJPGKF<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly GNFEKFDMGGE GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x33A4CF0", Offset = "0x33A36F0", VA = "0x1833A4CF0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, long HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x33A4CA0", Offset = "0x33A36A0", VA = "0x1833A4CA0", Slot = "5")]
	public long FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x33A4CB0", Offset = "0x33A36B0", VA = "0x1833A4CB0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, long HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x33A4C30", Offset = "0x33A3630", VA = "0x1833A4C30", Slot = "7")]
	public long DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public GNFEKFDMGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class INBOAELKGLO : global::EGNEGNMBKFG<long?>, EGFLKHELIAB, global::DEACOEJPGKF<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly INBOAELKGLO GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x33A7580", Offset = "0x33A5F80", VA = "0x1833A7580", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, long? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x33A7470", Offset = "0x33A5E70", VA = "0x1833A7470", Slot = "5")]
	public long? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x33A7500", Offset = "0x33A5F00", VA = "0x1833A7500", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, long? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x33A73B0", Offset = "0x33A5DB0", VA = "0x1833A73B0", Slot = "7")]
	public long? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public INBOAELKGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class PKKJFKJFDLO : global::EGNEGNMBKFG<long[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly PKKJFKJFDLO GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x477A430", Offset = "0x4778E30", VA = "0x18477A430", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, long[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x477A2F0", Offset = "0x4778CF0", VA = "0x18477A2F0", Slot = "5")]
	public long[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PKKJFKJFDLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class MCGOMPIOINH : global::EGNEGNMBKFG<byte>, EGFLKHELIAB, global::DEACOEJPGKF<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly MCGOMPIOINH GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x33AB500", Offset = "0x33A9F00", VA = "0x1833AB500", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, byte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x33AB460", Offset = "0x33A9E60", VA = "0x1833AB460", Slot = "5")]
	public byte FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x33AB4C0", Offset = "0x33A9EC0", VA = "0x1833AB4C0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, byte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x33AB3F0", Offset = "0x33A9DF0", VA = "0x1833AB3F0", Slot = "7")]
	public byte DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public MCGOMPIOINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class FLKHKGEMJPO : global::EGNEGNMBKFG<byte?>, EGFLKHELIAB, global::DEACOEJPGKF<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly FLKHKGEMJPO GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x36B2BE0", Offset = "0x36B15E0", VA = "0x1836B2BE0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, byte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x36B2A70", Offset = "0x36B1470", VA = "0x1836B2A70", Slot = "5")]
	public byte? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x36B2AE0", Offset = "0x36B14E0", VA = "0x1836B2AE0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, byte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x36B2990", Offset = "0x36B1390", VA = "0x1836B2990", Slot = "7")]
	public byte? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public FLKHKGEMJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class OIHAKAIMPCM : global::EGNEGNMBKFG<ushort>, EGFLKHELIAB, global::DEACOEJPGKF<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly OIHAKAIMPCM GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4773B80", Offset = "0x4772580", VA = "0x184773B80", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ushort HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x4773B30", Offset = "0x4772530", VA = "0x184773B30", Slot = "5")]
	public ushort FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x4773B40", Offset = "0x4772540", VA = "0x184773B40", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ushort HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4773AC0", Offset = "0x47724C0", VA = "0x184773AC0", Slot = "7")]
	public ushort DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public OIHAKAIMPCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class PGABDANGBFA : global::EGNEGNMBKFG<ushort?>, EGFLKHELIAB, global::DEACOEJPGKF<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PGABDANGBFA GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4779CB0", Offset = "0x47786B0", VA = "0x184779CB0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ushort? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4779BC0", Offset = "0x47785C0", VA = "0x184779BC0", Slot = "5")]
	public ushort? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4779C30", Offset = "0x4778630", VA = "0x184779C30", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ushort? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4779B20", Offset = "0x4778520", VA = "0x184779B20", Slot = "7")]
	public ushort? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PGABDANGBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class JONICNMCGJG : global::EGNEGNMBKFG<ushort[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly JONICNMCGJG GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x33A8AB0", Offset = "0x33A74B0", VA = "0x1833A8AB0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ushort[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x33A8910", Offset = "0x33A7310", VA = "0x1833A8910", Slot = "5")]
	public ushort[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public JONICNMCGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class OPBHEELJDBG : global::EGNEGNMBKFG<uint>, EGFLKHELIAB, global::DEACOEJPGKF<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly OPBHEELJDBG GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4777520", Offset = "0x4775F20", VA = "0x184777520", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, uint HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x47774D0", Offset = "0x4775ED0", VA = "0x1847774D0", Slot = "5")]
	public uint FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x47774E0", Offset = "0x4775EE0", VA = "0x1847774E0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, uint HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4777460", Offset = "0x4775E60", VA = "0x184777460", Slot = "7")]
	public uint DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public OPBHEELJDBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KKPCDJCGINB : global::EGNEGNMBKFG<uint?>, EGFLKHELIAB, global::DEACOEJPGKF<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KKPCDJCGINB GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x33A9900", Offset = "0x33A8300", VA = "0x1833A9900", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, uint? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x33A97D0", Offset = "0x33A81D0", VA = "0x1833A97D0", Slot = "5")]
	public uint? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x33A9880", Offset = "0x33A8280", VA = "0x1833A9880", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, uint? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x33A9730", Offset = "0x33A8130", VA = "0x1833A9730", Slot = "7")]
	public uint? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public KKPCDJCGINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class AAPONPPHPHG : global::EGNEGNMBKFG<uint[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly AAPONPPHPHG GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x369E050", Offset = "0x369CA50", VA = "0x18369E050", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, uint[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x369DF10", Offset = "0x369C910", VA = "0x18369DF10", Slot = "5")]
	public uint[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public AAPONPPHPHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class KHMDOBFGPDC : global::EGNEGNMBKFG<ulong>, EGFLKHELIAB, global::DEACOEJPGKF<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KHMDOBFGPDC GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x33A9250", Offset = "0x33A7C50", VA = "0x1833A9250", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ulong HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x33A9200", Offset = "0x33A7C00", VA = "0x1833A9200", Slot = "5")]
	public ulong FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x33A9210", Offset = "0x33A7C10", VA = "0x1833A9210", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ulong HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x33A9190", Offset = "0x33A7B90", VA = "0x1833A9190", Slot = "7")]
	public ulong DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public KHMDOBFGPDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class PLLPIIFOPCF : global::EGNEGNMBKFG<ulong?>, EGFLKHELIAB, global::DEACOEJPGKF<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PLLPIIFOPCF GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x477A720", Offset = "0x4779120", VA = "0x18477A720", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ulong? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x477A610", Offset = "0x4779010", VA = "0x18477A610", Slot = "5")]
	public ulong? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x477A6A0", Offset = "0x47790A0", VA = "0x18477A6A0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ulong? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x477A550", Offset = "0x4778F50", VA = "0x18477A550", Slot = "7")]
	public ulong? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PLLPIIFOPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class EBILKPEEOGE : global::EGNEGNMBKFG<ulong[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EBILKPEEOGE GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x36AC340", Offset = "0x36AAD40", VA = "0x1836AC340", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ulong[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x36AC200", Offset = "0x36AAC00", VA = "0x1836AC200", Slot = "5")]
	public ulong[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public EBILKPEEOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CLBELEMHNCB : global::EGNEGNMBKFG<float>, EGFLKHELIAB, global::DEACOEJPGKF<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly CLBELEMHNCB GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x36AA580", Offset = "0x36A8F80", VA = "0x1836AA580", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, float HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x36AA4C0", Offset = "0x36A8EC0", VA = "0x1836AA4C0", Slot = "5")]
	public float FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x36AA4D0", Offset = "0x36A8ED0", VA = "0x1836AA4D0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, float HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x36AA420", Offset = "0x36A8E20", VA = "0x1836AA420", Slot = "7")]
	public float DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public CLBELEMHNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class DHGAKNDNMFO : global::EGNEGNMBKFG<float?>, EGFLKHELIAB, global::DEACOEJPGKF<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly DHGAKNDNMFO GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x36AB9A0", Offset = "0x36AA3A0", VA = "0x1836AB9A0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, float? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x36AB840", Offset = "0x36AA240", VA = "0x1836AB840", Slot = "5")]
	public float? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x36AB8B0", Offset = "0x36AA2B0", VA = "0x1836AB8B0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, float? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x36AB760", Offset = "0x36AA160", VA = "0x1836AB760", Slot = "7")]
	public float? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public DHGAKNDNMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class KHOKPCCPBKP : global::EGNEGNMBKFG<float[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly KHOKPCCPBKP GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x33A9470", Offset = "0x33A7E70", VA = "0x1833A9470", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, float[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x33A92D0", Offset = "0x33A7CD0", VA = "0x1833A92D0", Slot = "5")]
	public float[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public KHOKPCCPBKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class JEFFJHJPMOO : global::EGNEGNMBKFG<double>, EGFLKHELIAB, global::DEACOEJPGKF<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly JEFFJHJPMOO GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x33A7BE0", Offset = "0x33A65E0", VA = "0x1833A7BE0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, double HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x33A7B90", Offset = "0x33A6590", VA = "0x1833A7B90", Slot = "5")]
	public double FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x33A7BA0", Offset = "0x33A65A0", VA = "0x1833A7BA0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, double HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x33A7B20", Offset = "0x33A6520", VA = "0x1833A7B20", Slot = "7")]
	public double DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public JEFFJHJPMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class FPDFEBJMLNK : global::EGNEGNMBKFG<double?>, EGFLKHELIAB, global::DEACOEJPGKF<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FPDFEBJMLNK GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x36B3A80", Offset = "0x36B2480", VA = "0x1836B3A80", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, double? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x36B38F0", Offset = "0x36B22F0", VA = "0x1836B38F0", Slot = "5")]
	public double? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x36B3980", Offset = "0x36B2380", VA = "0x1836B3980", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, double? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x36B37E0", Offset = "0x36B21E0", VA = "0x1836B37E0", Slot = "7")]
	public double? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public FPDFEBJMLNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class IPGEMKNPNAH : global::EGNEGNMBKFG<double[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly IPGEMKNPNAH GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x33A77F0", Offset = "0x33A61F0", VA = "0x1833A77F0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, double[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x33A7650", Offset = "0x33A6050", VA = "0x1833A7650", Slot = "5")]
	public double[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public IPGEMKNPNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FNIGFMMBAEN : global::EGNEGNMBKFG<bool>, EGFLKHELIAB, global::DEACOEJPGKF<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly FNIGFMMBAEN GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x36B3590", Offset = "0x36B1F90", VA = "0x1836B3590", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, bool HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x36B34D0", Offset = "0x36B1ED0", VA = "0x1836B34D0", Slot = "5")]
	public bool FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x36B34E0", Offset = "0x36B1EE0", VA = "0x1836B34E0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, bool HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x36B3460", Offset = "0x36B1E60", VA = "0x1836B3460", Slot = "7")]
	public bool DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public FNIGFMMBAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class GFDCLNKHFGN : global::EGNEGNMBKFG<bool?>, EGFLKHELIAB, global::DEACOEJPGKF<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly GFDCLNKHFGN GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x339CF40", Offset = "0x339B940", VA = "0x18339CF40", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, bool? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x339CE50", Offset = "0x339B850", VA = "0x18339CE50", Slot = "5")]
	public bool? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x339CEC0", Offset = "0x339B8C0", VA = "0x18339CEC0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, bool? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x339CDA0", Offset = "0x339B7A0", VA = "0x18339CDA0", Slot = "7")]
	public bool? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public GFDCLNKHFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class MLPIKNPIAHE : global::EGNEGNMBKFG<bool[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly MLPIKNPIAHE GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x33AC460", Offset = "0x33AAE60", VA = "0x1833AC460", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, bool[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x33AC2C0", Offset = "0x33AACC0", VA = "0x1833AC2C0", Slot = "5")]
	public bool[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public MLPIKNPIAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class FPPPJFCNPEI : global::EGNEGNMBKFG<object>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::EGNEGNMBKFG<object> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> PFILDMPCAPN;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x36B3DF0", Offset = "0x36B27F0", VA = "0x1836B3DF0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x36B3B50", Offset = "0x36B2550", VA = "0x1836B3B50", Slot = "5")]
	public object FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public FPPPJFCNPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class AFMKNKLJIKB : global::EGNEGNMBKFG<byte[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::EGNEGNMBKFG<byte[]> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x369E650", Offset = "0x369D050", VA = "0x18369E650", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, byte[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x369E5D0", Offset = "0x369CFD0", VA = "0x18369E5D0", Slot = "5")]
	public byte[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public AFMKNKLJIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class FPAKEJLKIBC : global::EGNEGNMBKFG<ArraySegment<byte>>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::EGNEGNMBKFG<ArraySegment<byte>> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x36B36E0", Offset = "0x36B20E0", VA = "0x1836B36E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ArraySegment<byte> HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x36B3610", Offset = "0x36B2010", VA = "0x1836B3610", Slot = "5")]
	public ArraySegment<byte> FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public FPAKEJLKIBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MFJNCDKLEIK : global::EGNEGNMBKFG<string>, EGFLKHELIAB, global::DEACOEJPGKF<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::EGNEGNMBKFG<string> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA10", Offset = "0x33AA410", VA = "0x1833ABA10", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, string HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA00", Offset = "0x33AA400", VA = "0x1833ABA00", Slot = "5")]
	public string FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA10", Offset = "0x33AA410", VA = "0x1833ABA10", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, string HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA00", Offset = "0x33AA400", VA = "0x1833ABA00", Slot = "7")]
	public string DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public MFJNCDKLEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class PCIFBEMICBI : global::EGNEGNMBKFG<string[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly PCIFBEMICBI GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4779580", Offset = "0x4777F80", VA = "0x184779580", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, string[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4779440", Offset = "0x4777E40", VA = "0x184779440", Slot = "5")]
	public string[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PCIFBEMICBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class JPCEHKIBDHP : global::EGNEGNMBKFG<char>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly JPCEHKIBDHP GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x33A8C00", Offset = "0x33A7600", VA = "0x1833A8C00", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, char HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x33A8BD0", Offset = "0x33A75D0", VA = "0x1833A8BD0", Slot = "5")]
	public char FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public JPCEHKIBDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class NBIBDDDANAJ : global::EGNEGNMBKFG<char?>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly NBIBDDDANAJ GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x33AC6B0", Offset = "0x33AB0B0", VA = "0x1833AC6B0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, char? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x33AC5F0", Offset = "0x33AAFF0", VA = "0x1833AC5F0", Slot = "5")]
	public char? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NBIBDDDANAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class ENMOFOGBCNB : global::EGNEGNMBKFG<char[]>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly ENMOFOGBCNB GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x36AF150", Offset = "0x36ADB50", VA = "0x1836AF150", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, char[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x36AEFB0", Offset = "0x36AD9B0", VA = "0x1836AEFB0", Slot = "5")]
	public char[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public ENMOFOGBCNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class AEHFLIPHPMH : global::EGNEGNMBKFG<Guid>, EGFLKHELIAB, global::DEACOEJPGKF<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::EGNEGNMBKFG<Guid> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x369E3E0", Offset = "0x369CDE0", VA = "0x18369E3E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Guid HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x369E390", Offset = "0x369CD90", VA = "0x18369E390", Slot = "5")]
	public Guid FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x369E3E0", Offset = "0x369CDE0", VA = "0x18369E3E0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, Guid HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x369E340", Offset = "0x369CD40", VA = "0x18369E340", Slot = "7")]
	public Guid DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public AEHFLIPHPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class MKOCCEIICLG : global::EGNEGNMBKFG<decimal>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::EGNEGNMBKFG<decimal> GMBIDLIPEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool NNKEPLJPLMK;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xF6E1B0", Offset = "0xF6CBB0", VA = "0x180F6E1B0")]
	public MKOCCEIICLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xC28E80", Offset = "0xC27880", VA = "0x180C28E80")]
	public MKOCCEIICLG(bool NNKEPLJPLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x33AC120", Offset = "0x33AAB20", VA = "0x1833AC120", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, decimal HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x33ABF70", Offset = "0x33AA970", VA = "0x1833ABF70", Slot = "5")]
	public decimal FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class PBCCDDFKGOL : global::EGNEGNMBKFG<Uri>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::EGNEGNMBKFG<Uri> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4778A30", Offset = "0x4777430", VA = "0x184778A30", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Uri HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x47789B0", Offset = "0x47773B0", VA = "0x1847789B0", Slot = "5")]
	public Uri FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public PBCCDDFKGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class LLKPEHDDNDE : global::EGNEGNMBKFG<Version>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::EGNEGNMBKFG<Version> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x33AB150", Offset = "0x33A9B50", VA = "0x1833AB150", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Version HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x33AB0D0", Offset = "0x33A9AD0", VA = "0x1833AB0D0", Slot = "5")]
	public Version FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LLKPEHDDNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class FJEPGJLBBHK<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class OPFAACPCPJC : global::EGNEGNMBKFG<StringBuilder>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::EGNEGNMBKFG<StringBuilder> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4777610", Offset = "0x4776010", VA = "0x184777610", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, StringBuilder HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4777590", Offset = "0x4775F90", VA = "0x184777590", Slot = "5")]
	public StringBuilder FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public OPFAACPCPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class KPNKLMMLNKH : global::EGNEGNMBKFG<BitArray>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::EGNEGNMBKFG<BitArray> GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x33AAD60", Offset = "0x33A9760", VA = "0x1833AAD60", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, BitArray HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x33AAC00", Offset = "0x33A9600", VA = "0x1833AAC00", Slot = "5")]
	public BitArray FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public KPNKLMMLNKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class PMLKJLBBIFJ : global::EGNEGNMBKFG<Type>, EGFLKHELIAB
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly PMLKJLBBIFJ GMBIDLIPEPB;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex BPKJGCLNEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool ECENLCFHCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool FJFDLOJGLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool FCMLOPJBFPH;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x477AE30", Offset = "0x4779830", VA = "0x18477AE30")]
	public PMLKJLBBIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x477AE50", Offset = "0x4779850", VA = "0x18477AE50")]
	public PMLKJLBBIFJ(bool ECENLCFHCIB, bool FJFDLOJGLFD, bool FCMLOPJBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x477ACA0", Offset = "0x47796A0", VA = "0x18477ACA0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Type HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x477AB80", Offset = "0x4779580", VA = "0x18477AB80", Slot = "5")]
	public Type FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
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
