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
	[Cpp2IlInjected.Address(RVA = "0x563C30", Offset = "0x562630", VA = "0x180563C30")]
	public CFNNKBACNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class EHIBKCKPKGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x563C30", Offset = "0x562630", VA = "0x180563C30")]
	public EHIBKCKPKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LNLHNJECPLI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x563C30", Offset = "0x562630", VA = "0x180563C30")]
	public LNLHNJECPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CAPEKLPMJBH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x563C30", Offset = "0x562630", VA = "0x180563C30")]
	public CAPEKLPMJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DFFCGJFPMLH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1057D70", Offset = "0x1056770", VA = "0x181057D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] HHHCLCEOAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7097E0", Offset = "0x7081E0", VA = "0x1807097E0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC202E0", Offset = "0xC1ECE0", VA = "0x180C202E0")]
	public static global::EGNEGNMBKFG<T> GNDAFHGDEDA<T>(this CGDCFJDMLCL CPIBNMPIJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xCEE7A0", Offset = "0xCED1A0", VA = "0x180CEE7A0")]
	public static object HNPFGOHCFGC(this CGDCFJDMLCL CPIBNMPIJNF, Type IEADHAAGEDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DNBHKNMJHFO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x10586A0", Offset = "0x10570A0", VA = "0x1810586A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x173D980", Offset = "0x173C380", VA = "0x18173D980")]
		public static byte[] PIFPHDIALGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x173D8F0", Offset = "0x173C2F0", VA = "0x18173D8F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF3CA0", Offset = "0xCF26A0", VA = "0x180CF3CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xCF5120", Offset = "0xCF3B20", VA = "0x180CF5120")]
	public NHAPBMMNKAC(byte[] MCBNAPIFOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xCF5130", Offset = "0xCF3B30", VA = "0x180CF5130")]
	public NHAPBMMNKAC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xCF3D50", Offset = "0xCF2750", VA = "0x180CF3D50")]
	private MFDAMJHLIPE GNNODGPDPMH(string PNHNCJNEDLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xCF4660", Offset = "0xCF3060", VA = "0x180CF4660")]
	private MFDAMJHLIPE JFGFIIIGBIK(string OLLHPIFFHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xCF4E80", Offset = "0xCF3880", VA = "0x180CF4E80")]
	public void OHNGLJFLPEE(int EFGENLFBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6311D0", Offset = "0x62FBD0", VA = "0x1806311D0")]
	public byte[] KCMLEJNLCJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4F0", Offset = "0x6DDEF0", VA = "0x1806DF4F0")]
	public int GHLEJDFHLNN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1360", VA = "0x180CF2960")]
	public PJNNIPEGDKN AFEJJDOCFEK()
	{
		return default(PJNNIPEGDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xCF49F0", Offset = "0xCF33F0", VA = "0x180CF49F0")]
	public void JMJHHPACGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCF4B30", Offset = "0xCF3530", VA = "0x180CF4B30")]
	public bool LMCGBFGDDKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xCF3BD0", Offset = "0xCF25D0", VA = "0x180CF3BD0")]
	public bool EGANDHKMPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xCF2D50", Offset = "0xCF1750", VA = "0x180CF2D50")]
	public void BBEBODMOCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xCF2DF0", Offset = "0xCF17F0", VA = "0x180CF2DF0")]
	public bool BCNDGALDOEC(ref int LKEJFKMJCND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xCF2F20", Offset = "0xCF1920", VA = "0x180CF2F20")]
	public bool BFIJHODJLEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xCF4E90", Offset = "0xCF3890", VA = "0x180CF4E90")]
	public void ONENKODAEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xCF3CC0", Offset = "0xCF26C0", VA = "0x180CF3CC0")]
	public bool GHFMDCEKLBG(ref int LKEJFKMJCND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xCF44B0", Offset = "0xCF2EB0", VA = "0x180CF44B0")]
	public bool IDELGEHIIHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xCF4C50", Offset = "0xCF3650", VA = "0x180CF4C50")]
	public void MACCAIBNPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xCF42B0", Offset = "0xCF2CB0", VA = "0x180CF42B0")]
	public bool HFOHBKFGBLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xCF4320", Offset = "0xCF2D20", VA = "0x180CF4320")]
	public void HJDKMLDFGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xCF3220", Offset = "0xCF1C20", VA = "0x180CF3220")]
	private void CPDJDGPADLL(out byte[] DNOJFMDMOPB, out int LNOGNDDHAEO, out int MLEIBLBLBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xCF4520", Offset = "0xCF2F20", VA = "0x180CF4520")]
	private static int IFNBHGHDFNF(char MMADIBJKHHM, char ODMIEFIFOGP, char HJNCMGDJMJJ, char GMLDCHLEGOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xCF4920", Offset = "0xCF3320", VA = "0x180CF4920")]
	private static int JMGODGLLALF(char EDIMMNEBDAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xCF3010", Offset = "0xCF1A10", VA = "0x180CF3010")]
	public ArraySegment<byte> CBEAPNDHKBC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xCF2E80", Offset = "0xCF1880", VA = "0x180CF2E80")]
	public string BFGJICGHLHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xCF4630", Offset = "0xCF3030", VA = "0x180CF4630")]
	public string JBOOEKJNMFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xCF39B0", Offset = "0xCF23B0", VA = "0x180CF39B0")]
	public ArraySegment<byte> DILHEDOCCID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xCF5000", Offset = "0xCF3A00", VA = "0x180CF5000")]
	public ArraySegment<byte> PINDOJGEKAF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xCF2AF0", Offset = "0xCF14F0", VA = "0x180CF2AF0")]
	public bool AGHDEKDPCOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF36F0", VA = "0x180CF4CF0")]
	private static bool NALLJGBKNJO(byte HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xCF2790", Offset = "0xCF1190", VA = "0x180CF2790")]
	private void ABCHBKMLNHI(PJNNIPEGDKN LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xCF3B60", Offset = "0xCF2560", VA = "0x180CF3B60")]
	public void DJCOBAFGNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xCF4F30", Offset = "0xCF3930", VA = "0x180CF4F30")]
	private void PBAMDCGLPDO(int LHHHODIIJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF37B0", VA = "0x180CF4DB0")]
	public sbyte OAOEKFCIEHM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xCF31C0", Offset = "0xCF1BC0", VA = "0x180CF31C0")]
	public short COBOLEKNFCO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xCF3C40", Offset = "0xCF2640", VA = "0x180CF3C40")]
	public int ELOKLDKLIOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF3800", VA = "0x180CF4E00")]
	public long OGPILMDFGMC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xCF45D0", Offset = "0xCF2FD0", VA = "0x180CF45D0")]
	public byte IHFFJFHFPEF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xCF48C0", Offset = "0xCF32C0", VA = "0x180CF48C0")]
	public ushort JJOHNOGFNMI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xCF3B70", Offset = "0xCF2570", VA = "0x180CF3B70")]
	public uint DJCPPPJFBFP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xCF2F90", Offset = "0xCF1990", VA = "0x180CF2F90")]
	public ulong BGKLIEFBFBC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xCF41F0", Offset = "0xCF2BF0", VA = "0x180CF41F0")]
	public float HAEFCCCAOLO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xCF3100", Offset = "0xCF1B00", VA = "0x180CF3100")]
	public double CIMKDHCOHKE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
	public ArraySegment<byte> IBOHPKMMJAD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xCF4740", Offset = "0xCF3140", VA = "0x180CF4740")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEF0D0", Offset = "0xCEDAD0", VA = "0x180CEF0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IHCIINJHFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0790", Offset = "0x6AF190", VA = "0x1806B0790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xCEF1B0", Offset = "0xCEDBB0", VA = "0x180CEF1B0")]
	public MFDAMJHLIPE(string OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xCEF0E0", Offset = "0xCEDAE0", VA = "0x180CEF0E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
				public GCEMGCDJCEI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1061300", Offset = "0x105FD00", VA = "0x181061300")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x1061340", Offset = "0x105FD40", VA = "0x181061340")]
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
			[Cpp2IlInjected.Address(RVA = "0x1053FC0", Offset = "0x10529C0", VA = "0x181053FC0")]
			public CGFFFKAPMHB(Type IEADHAAGEDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x29335E0", Offset = "0x2931FE0", VA = "0x1829335E0")]
			private static T NFCAOMFDFEO<T>(DynamicMethod DJKHJBPPHKJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1053DD0", Offset = "0x10527D0", VA = "0x181053DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1062F10", Offset = "0x1061910", VA = "0x181062F10")]
		static JADPOOMEHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1062C10", Offset = "0x1061610", VA = "0x181062C10")]
		private static CGFFFKAPMHB JJBBAKFANLO(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1062C90", Offset = "0x1061690", VA = "0x181062C90")]
		public static void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1062E00", Offset = "0x1061800", VA = "0x181062E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1056E10", Offset = "0x1055810", VA = "0x181056E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1057B30", Offset = "0x1056530", VA = "0x181057B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1057AD0", Offset = "0x10564D0", VA = "0x181057AD0")]
	public static void BMNNLOEIBNK(CGDCFJDMLCL CPIBNMPIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x30718C0", Offset = "0x30702C0", VA = "0x1830718C0")]
	public static string KKHCKKEABHA<T>(T HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3071940", Offset = "0x3070340", VA = "0x183071940")]
	public static string KKHCKKEABHA<T>(T HPIAFNBPEPC, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2934310", Offset = "0x2932D10", VA = "0x182934310")]
	public static T FIPMLAIPHOG<T>(string OJFDPHJFPFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29341C0", Offset = "0x2932BC0", VA = "0x1829341C0")]
	public static T FIPMLAIPHOG<T>(string OJFDPHJFPFH, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2934290", Offset = "0x2932C90", VA = "0x182934290")]
	public static T FIPMLAIPHOG<T>(byte[] MCBNAPIFOAJ, CGDCFJDMLCL CPIBNMPIJNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2934390", Offset = "0x2932D90", VA = "0x182934390")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF4F0", Offset = "0x6DDEF0", VA = "0x1806DF4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xCF4E80", Offset = "0xCF3880", VA = "0x180CF4E80")]
	public void OHNGLJFLPEE(int EFGENLFBGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x105C680", Offset = "0x105B080", VA = "0x18105C680")]
	public static byte[] AEBOHOGHPPN(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x105CE00", Offset = "0x105B800", VA = "0x18105CE00")]
	public static byte[] IGEBHAGHDJL(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x105D4B0", Offset = "0x105BEB0", VA = "0x18105D4B0")]
	public static byte[] PBGJBEMJAIN(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x105C520", Offset = "0x105AF20", VA = "0x18105C520")]
	public static byte[] ACCDHLJAOGG(string EACDICMBPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x105D7F0", Offset = "0x105C1F0", VA = "0x18105D7F0")]
	public FBIFMPDMBBF(byte[] GLNKGIMKFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x105D630", Offset = "0x105C030", VA = "0x18105D630")]
	public ArraySegment<byte> PIFPHDIALGM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x105C920", Offset = "0x105B320", VA = "0x18105C920")]
	public byte[] EIEKHKNCOPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x105D740", Offset = "0x105C140", VA = "0x18105D740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x105D6E0", Offset = "0x105C0E0", VA = "0x18105D6E0")]
	public void PJBHCHFGCIP(int DFINGJIDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x105C860", Offset = "0x105B260", VA = "0x18105C860")]
	public void DDENGIJEDAI(byte[] EIJDBEGLJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x105C9A0", Offset = "0x105B3A0", VA = "0x18105C9A0")]
	public void EILFPAEONEF(byte EIJDBEGLJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x105C790", Offset = "0x105B190", VA = "0x18105C790")]
	public void CCBPNANEJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x105D460", Offset = "0x105BE60", VA = "0x18105D460")]
	public void OOAFKEIKODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x105D300", Offset = "0x105BD00", VA = "0x18105D300")]
	public void KFFHFNKIMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x105D180", Offset = "0x105BB80", VA = "0x18105D180")]
	public void JHKIGKOKOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x105D5E0", Offset = "0x105BFE0", VA = "0x18105D5E0")]
	public void PFKJLAMGPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x105D6F0", Offset = "0x105C0F0", VA = "0x18105D6F0")]
	public void PMDLOFBEICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x105D400", Offset = "0x105BE00", VA = "0x18105D400")]
	public void OKCLAICGEOP(string EACDICMBPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x105CDB0", Offset = "0x105B7B0", VA = "0x18105CDB0")]
	public void IDJHMBAKEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x105D1D0", Offset = "0x105BBD0", VA = "0x18105D1D0")]
	public void JIFAPKNKLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x105CF30", Offset = "0x105B930", VA = "0x18105CF30")]
	public void JBELDKOLGOP(bool HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x105D380", Offset = "0x105BD80", VA = "0x18105D380")]
	public void NNLIBFGLAJL(float HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x105C7E0", Offset = "0x105B1E0", VA = "0x18105C7E0")]
	public void CKGEIFIIBJN(double HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x105D120", Offset = "0x105BB20", VA = "0x18105D120")]
	public void JDJCNNMOOKP(byte HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x105D150", Offset = "0x105BB50", VA = "0x18105D150")]
	public void JGMEFINEGHP(ushort HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x105C8F0", Offset = "0x105B2F0", VA = "0x18105C8F0")]
	public void DOPGIAPHAJB(uint HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x105C8C0", Offset = "0x105B2C0", VA = "0x18105C8C0")]
	public void DOACEEBMFKB(ulong HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x105D2A0", Offset = "0x105BCA0", VA = "0x18105D2A0")]
	public void JPFDPNEHEOF(sbyte HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x105C760", Offset = "0x105B160", VA = "0x18105C760")]
	public void BBLPKOPDPIE(short HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x105D350", Offset = "0x105BD50", VA = "0x18105D350")]
	public void MFDIABDHHJL(int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x105D2D0", Offset = "0x105BCD0", VA = "0x18105D2D0")]
	public void KBKMNMIKIGD(long HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x105C9E0", Offset = "0x105B3E0", VA = "0x18105C9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D631A0", Offset = "0x3D61BA0", VA = "0x183D631A0")]
		static GJJDJNHKMBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private BAOKNACEOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1057710", Offset = "0x1056110", VA = "0x181057710")]
	static COODBCACHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x10571B0", Offset = "0x1055BB0", VA = "0x1810571B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x104F9F0", Offset = "0x104E3F0", VA = "0x18104F9F0")]
	public BEOKIDBJCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x104F880", Offset = "0x104E280", VA = "0x18104F880", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Vector2 HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x104F690", Offset = "0x104E090", VA = "0x18104F690", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1738200", Offset = "0x1736C00", VA = "0x181738200")]
	public NHPGMMFEGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x17380E0", Offset = "0x1736AE0", VA = "0x1817380E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Vector3 HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1737EF0", Offset = "0x17368F0", VA = "0x181737EF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1053AB0", Offset = "0x10524B0", VA = "0x181053AB0")]
	public CGEMKCPIGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1052B20", Offset = "0x1051520", VA = "0x181052B20", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Vector4 HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1053820", Offset = "0x1052220", VA = "0x181053820", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEB950", Offset = "0xCEA350", VA = "0x180CEB950")]
	public JHDGFDELFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCEB800", Offset = "0xCEA200", VA = "0x180CEB800", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Quaternion HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xCEB4C0", Offset = "0xCE9EC0", VA = "0x180CEB4C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1052D90", Offset = "0x1051790", VA = "0x181052D90")]
	public CEMEEAFIKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1052B20", Offset = "0x1051520", VA = "0x181052B20", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Color HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1052890", Offset = "0x1051290", VA = "0x181052890", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x105B5D0", Offset = "0x1059FD0", VA = "0x18105B5D0")]
	public EMGOFAADMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x105B2D0", Offset = "0x1059CD0", VA = "0x18105B2D0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Bounds HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x105AFD0", Offset = "0x10599D0", VA = "0x18105AFD0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x105C200", Offset = "0x105AC00", VA = "0x18105C200")]
	public FAOMKAGKDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x105BF70", Offset = "0x105A970", VA = "0x18105BF70", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Rect HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x105BCC0", Offset = "0x105A6C0", VA = "0x18105BCC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x32BB8F0", Offset = "0x32BA2F0", VA = "0x1832BB8F0")]
		static IOEMCGNEFFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private MKICJDLLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3344850", Offset = "0x3343250", VA = "0x183344850")]
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
		[Cpp2IlInjected.Address(RVA = "0x1058FD0", Offset = "0x10579D0", VA = "0x181058FD0")]
		internal static object DCPBAPPIICK(Type LIKLFJCOLDP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private DMLPCHGFJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A698D0", Offset = "0x3A682D0", VA = "0x183A698D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private HMCLDBOEGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xCEA430", Offset = "0xCE8E30", VA = "0x180CEA430")]
	public static void JECFEENHGII(params CGDCFJDMLCL[] HBJOCMKBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xCEA4F0", Offset = "0xCE8EF0", VA = "0x180CEA4F0")]
	public static void JECFEENHGII(params EGFLKHELIAB[] ANNPMMACDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xCEA1E0", Offset = "0xCE8BE0", VA = "0x180CEA1E0")]
	public static void DAPGBMBBINP(EGFLKHELIAB[] ANNPMMACDCA, CGDCFJDMLCL[] HBJOCMKBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A21E00", Offset = "0x3A20800", VA = "0x183A21E00")]
		static MGBCJEDJNMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private ECHOGCBPNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x173A010", Offset = "0x1738A10", VA = "0x18173A010")]
	internal static object DCPBAPPIICK(Type LIKLFJCOLDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x173B690", Offset = "0x173A090", VA = "0x18173B690")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E043C0", Offset = "0x3E02DC0", VA = "0x183E043C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF26A0", Offset = "0xCF10A0", VA = "0x180CF26A0")]
	static NFNIKHIBGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private NFNIKHIBGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B58B50", Offset = "0x3B57550", VA = "0x183B58B50")]
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
	[Cpp2IlInjected.Address(RVA = "0x104AA70", Offset = "0x1049470", VA = "0x18104AA70")]
	static ABDHMLAMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private ABDHMLAMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32B7610", Offset = "0x32B6010", VA = "0x1832B7610")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEEA70", Offset = "0xCED470", VA = "0x180CEEA70")]
	static LMGJFGAKEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private LMGJFGAKEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x328D1C0", Offset = "0x328BBC0", VA = "0x18328D1C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1055EE0", Offset = "0x10548E0", VA = "0x181055EE0")]
	static CHCOOMFMGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private CHCOOMFMGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CB90A0", Offset = "0x3CB7AA0", VA = "0x183CB90A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1743940", Offset = "0x1742340", VA = "0x181743940")]
	static PHKLHFKMBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private PHKLHFKMBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x40472B0", Offset = "0x4045CB0", VA = "0x1840472B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEE320", Offset = "0xCECD20", VA = "0x180CEE320")]
	static KPGLBHHKMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private KPGLBHHKMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41297D0", Offset = "0x41281D0", VA = "0x1841297D0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		[Cpp2IlInjected.Address(RVA = "0x32BD1F0", Offset = "0x32BBBF0", VA = "0x1832BD1F0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		[Cpp2IlInjected.Address(RVA = "0x41AAC00", Offset = "0x41A9600", VA = "0x1841AAC00")]
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
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE5960", Offset = "0x2CE4360", VA = "0x182CE5960")]
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
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		[Cpp2IlInjected.Address(RVA = "0x4130550", Offset = "0x412EF50", VA = "0x184130550")]
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
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D6B0C0", Offset = "0x3D69AC0", VA = "0x183D6B0C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
	public global::EGNEGNMBKFG<T> DCPBAPPIICK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDF1E0", Offset = "0xCDDBE0", VA = "0x180CDF1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDE560", Offset = "0xCDCF60", VA = "0x180CDE560")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF5660", Offset = "0xCF4060", VA = "0x180CF5660")]
		public static MethodInfo NGLMBPACFDH(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xCF5310", Offset = "0xCF3D10", VA = "0x180CF5310")]
		public static MethodInfo FIPMLAIPHOG(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xCF5540", Offset = "0xCF3F40", VA = "0x180CF5540")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public GFHDGBFFIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xCE07C0", Offset = "0xCDF1C0", VA = "0x180CE07C0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xCE0800", Offset = "0xCDF200", VA = "0x180CE0800")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LNMFNIPMPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xCEEB60", Offset = "0xCED560", VA = "0x180CEEB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JEKINHPCOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xCEB460", Offset = "0xCE9E60", VA = "0x180CEB460")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HPLOCAEGJHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xCEA670", Offset = "0xCE9070", VA = "0x180CEA670")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public OGMCKNDPMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xCF6D40", Offset = "0xCF5740", VA = "0x180CF6D40")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xCF6D50", Offset = "0xCF5750", VA = "0x180CF6D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public KKCKJBGBPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xCECDA0", Offset = "0xCEB7A0", VA = "0x180CECDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HIEIJFMJMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x590950", Offset = "0x58F350", VA = "0x180590950")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HICBNPOAEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xCEA0B0", Offset = "0xCE8AB0", VA = "0x180CEA0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public DIMJBHNOKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xCDFF20", Offset = "0xCDE920", VA = "0x180CDFF20")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xCE01D0", Offset = "0xCDEBD0", VA = "0x180CE01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public IHHMFLNDLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xCE8820", Offset = "0xCE7220", VA = "0x180CE8820")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public HDGEMODCEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xCE8820", Offset = "0xCE7220", VA = "0x180CE8820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3508710", Offset = "0x3507110", VA = "0x183508710")]
	public static object MBNHIFEKJOO<T>(NEMPGDCHPOI HLNGJNJNONI, CGDCFJDMLCL MBHOOFOFNPC, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x307AC10", Offset = "0x3079610", VA = "0x18307AC10")]
	public static object PPGFGKNDLCO<T>(CGDCFJDMLCL MBHOOFOFNPC, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE, bool PNKMJLMLEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xCE4710", Offset = "0xCE3110", VA = "0x180CE4710")]
	private static TypeInfo JIAJADFOFIG(NEMPGDCHPOI HLNGJNJNONI, Type IEADHAAGEDA, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xCE0A40", Offset = "0xCDF440", VA = "0x180CE0A40")]
	public static object APJBJEHMMDN(Type IEADHAAGEDA, Func<string, string> FOBGCCPNDPF, bool KMLIFFKKBHE, bool PNKMJLMLEGI, bool DPPDIBFDLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xCE2790", Offset = "0xCE1190", VA = "0x180CE2790")]
	private static Dictionary<FIIKBGBBFLN, FieldInfo> HKOAFKFFHGG(TypeBuilder LGLAPGDEAJG, PAFFIENPFGC EEHCANMAMAN, ConstructorInfo EKIPPGBDPOM, FieldBuilder DAMNAHKCMGH, ILGenerator BAHIJJBPKKH, bool KMLIFFKKBHE, bool CPHHKKDMBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xCE7380", Offset = "0xCE5D80", VA = "0x180CE7380")]
	private static Dictionary<FIIKBGBBFLN, FieldInfo> MOFBJCCHOAP(TypeBuilder LGLAPGDEAJG, PAFFIENPFGC EEHCANMAMAN, ILGenerator BAHIJJBPKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xCE5E20", Offset = "0xCE4820", VA = "0x180CE5E20")]
	private static void MNIABGGLGOP(Type IEADHAAGEDA, PAFFIENPFGC EEHCANMAMAN, ILGenerator BAHIJJBPKKH, Action BLOJBGAPBEP, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, bool KMLIFFKKBHE, bool CPHHKKDMBAJ, int NGOHPCFAIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xCE7940", Offset = "0xCE6340", VA = "0x180CE7940")]
	private static void OHELBINDOJK(TypeInfo IEADHAAGEDA, FIIKBGBBFLN FMAMJMDMEOL, ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, DGGGCNDMAMN HBKAOCMIABB, DGGGCNDMAMN ILNDLLIPJKB, DGGGCNDMAMN DHGLCIMNDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xCE2DE0", Offset = "0xCE17E0", VA = "0x180CE2DE0")]
	private static void IECOPLDNCKG(Type IEADHAAGEDA, PAFFIENPFGC EEHCANMAMAN, ILGenerator BAHIJJBPKKH, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, bool EMKPMBFBMMH, int NGOHPCFAIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xCE2380", Offset = "0xCE0D80", VA = "0x180CE2380")]
	private static void EPBGGFPACBE(ILGenerator BAHIJJBPKKH, POANPKOBEPP EEHCANMAMAN, int LGBFGOJBLFK, Func<int, FIIKBGBBFLN, bool> NMJGEDIHGMH, DGGGCNDMAMN GFDHAJPOBIG, DGGGCNDMAMN DHGLCIMNDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xCE51B0", Offset = "0xCE3BB0", VA = "0x180CE51B0")]
	private static LocalBuilder MALLEDLGDED(ILGenerator BAHIJJBPKKH, Type IEADHAAGEDA, PAFFIENPFGC EEHCANMAMAN, POANPKOBEPP[] MKCIGDGFNDG, bool PDOEGBEBCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xCE4040", Offset = "0xCE2A40", VA = "0x180CE4040")]
	private static bool JFEADGMLGNN(ConstructorInfo BLHGDOIKEOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xCE08A0", Offset = "0xCDF2A0", VA = "0x180CE08A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D72490", Offset = "0x3D70E90", VA = "0x183D72490")]
		static ONHIBKCENCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private BAFIMNJBGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ACE980", Offset = "0x3ACD380", VA = "0x183ACE980")]
		static PNGGGIGEAAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly CGDCFJDMLCL JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private EHAKGKAOMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x405EAE0", Offset = "0x405D4E0", VA = "0x18405EAE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4057B90", Offset = "0x4056590", VA = "0x184057B90")]
			static LCKOAGCLGHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private CKFDJEAJHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private LAAGHLLPEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4297050", Offset = "0x4295A50", VA = "0x184297050")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CB7150", Offset = "0x3CB5B50", VA = "0x183CB7150")]
			static KBHNKOHFHEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private EGCCKEOOHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private PNHMGABJOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39241C0", Offset = "0x3922BC0", VA = "0x1839241C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x390EB00", Offset = "0x390D500", VA = "0x18390EB00")]
			static EBLCPOKNBCB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private PBJDICCEEMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private FLPDBMPPHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D66CE0", Offset = "0x2D656E0", VA = "0x182D66CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D61E40", Offset = "0x2D60840", VA = "0x182D61E40")]
			static AHDAPDLLLPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private BCCAPCIOJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private JNNAMLBCOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D096F0", Offset = "0x3D080F0", VA = "0x183D096F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D052E0", Offset = "0x3D03CE0", VA = "0x183D052E0")]
			static EPKMKFFJIBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private BOMKELLPLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private OLKFMKNOJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3742400", Offset = "0x3740E00", VA = "0x183742400")]
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
			[Cpp2IlInjected.Address(RVA = "0x373D590", Offset = "0x373BF90", VA = "0x18373D590")]
			static NKHJKJLIOJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private KNKBMJJPBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private JHMKONLFOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x412B6D0", Offset = "0x412A0D0", VA = "0x18412B6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41212B0", Offset = "0x411FCB0", VA = "0x1841212B0")]
			static BJOOINBCKCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private LJIDEMKEHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private NNFGOGCMJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A14720", Offset = "0x3A13120", VA = "0x183A14720")]
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
			[Cpp2IlInjected.Address(RVA = "0x3ACC320", Offset = "0x3ACAD20", VA = "0x183ACC320")]
			static NLOMEIAKNGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private GFMMEDMKDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private EFKLMIKMOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41268C0", Offset = "0x41252C0", VA = "0x1841268C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41334A0", Offset = "0x4131EA0", VA = "0x1841334A0")]
			static NIJCPKMHCMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private KFBLBIDGJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private NPECNKIKMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39CDCC0", Offset = "0x39CC6C0", VA = "0x1839CDCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DA470", Offset = "0x39D8E70", VA = "0x1839DA470")]
			static IOFDPPOJBAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private JANCICNENED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private HENLCCJNEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DF9CB0", Offset = "0x3DF86B0", VA = "0x183DF9CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DFF1A0", Offset = "0x3DFDBA0", VA = "0x183DFF1A0")]
			static JDIOKKGJMLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private BCLAMPOKCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private NJDCMNCAFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3932AB0", Offset = "0x39314B0", VA = "0x183932AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3914170", Offset = "0x3912B70", VA = "0x183914170")]
			static FENIKELFGOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly CGDCFJDMLCL JMMDLCEKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly CGDCFJDMLCL[] HBJOCMKBCJA;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		private JPNJICDNBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	private FFCOGONMILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xC19180", Offset = "0xC17B80", VA = "0x180C19180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DD5BB0", Offset = "0x3DD45B0", VA = "0x183DD5BB0")]
	public MLNAMEPCKNM(int CFPFDMKCPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5970", Offset = "0x3DD4370", VA = "0x183DD5970")]
	public void CEGAKGBDODP(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5B20", Offset = "0x3DD4520", VA = "0x183DD5B20")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEBE00", Offset = "0xCEA800", VA = "0x180CEBE00")]
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
	[Cpp2IlInjected.Address(RVA = "0x32CC6B0", Offset = "0x32CB0B0", VA = "0x1832CC6B0")]
	public MJLBBJKMKCK(int AHEACBAMFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x32CC2F0", Offset = "0x32CACF0", VA = "0x1832CC2F0")]
	public T[] ONKPAIFMGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x32CA970", Offset = "0x32C9370", VA = "0x1832CA970")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
			[DebuggerHidden]
			public IBJIGGFHMEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x10616C0", Offset = "0x10600C0", VA = "0x1810616C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x10617F0", Offset = "0x10601F0", VA = "0x1810617F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1061750", Offset = "0x1060150", VA = "0x181061750", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IEJNMNCLHPP> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1061750", Offset = "0x1060150", VA = "0x181061750", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public APCFFJBPAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x590950", Offset = "0x58F350", VA = "0x180590950")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x590950", Offset = "0x58F350", VA = "0x180590950")]
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
			[Cpp2IlInjected.Address(RVA = "0x1061BA0", Offset = "0x10605A0", VA = "0x181061BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1062B50", Offset = "0x1061550", VA = "0x181062B50")]
		public IEJNMNCLHPP(ulong IPKOPOLJGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1061890", Offset = "0x1060290", VA = "0x181061890")]
		public IEJNMNCLHPP CEGAKGBDODP(ulong IPKOPOLJGIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1061840", Offset = "0x1060240", VA = "0x181061840")]
		public IEJNMNCLHPP CEGAKGBDODP(ulong IPKOPOLJGIA, int HPIAFNBPEPC, string AEMNOGNGCFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1061D00", Offset = "0x1060700", VA = "0x181061D00")]
		public IEJNMNCLHPP NBOHLPGGIDJ(byte[] ONGPCLJCNFH, ref int EFGENLFBGLF, ref int NCLHFGCCBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1061AB0", Offset = "0x10604B0", VA = "0x181061AB0")]
		internal static int DODCKLFFKOI(ulong[] OBKDNKHGCJN, int LGBFGOJBLFK, int HHALJLDHKOL, ulong HPIAFNBPEPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1061A80", Offset = "0x1060480", VA = "0x181061A80", Slot = "4")]
		public int CompareTo(IEJNMNCLHPP KKPJJILPNAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1061B30", Offset = "0x1060530", VA = "0x181061B30")]
		[IteratorStateMachine(typeof(IBJIGGFHMEI))]
		public IEnumerable<IEJNMNCLHPP> ILCKCOEGMGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1061BB0", Offset = "0x10605B0", VA = "0x181061BB0")]
		public void MLFFAINLLKE(ILGenerator BAHIJJBPKKH, LocalBuilder ONGPCLJCNFH, LocalBuilder NCLHFGCCBKN, LocalBuilder IPKOPOLJGIA, Action<KeyValuePair<string, int>> DOFJECGDFNN, Action KHPPBEGJNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1061EB0", Offset = "0x10608B0", VA = "0x181061EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x588CC0", Offset = "0x5876C0", VA = "0x180588CC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x105FAC0", Offset = "0x105E4C0", VA = "0x18105FAC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xB91C50", Offset = "0xB90650", VA = "0x180B91C50")]
		[DebuggerHidden]
		public FMAKBEDEGMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x105FB10", Offset = "0x105E510", VA = "0x18105FB10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x105F650", Offset = "0x105E050", VA = "0x18105F650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x105FC10", Offset = "0x105E610", VA = "0x18105FC10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x105FC60", Offset = "0x105E660", VA = "0x18105FC60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x105FA70", Offset = "0x105E470", VA = "0x18105FA70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x105F9D0", Offset = "0x105E3D0", VA = "0x18105F9D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x105F9D0", Offset = "0x105E3D0", VA = "0x18105F9D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x10566B0", Offset = "0x10550B0", VA = "0x1810566B0")]
	public CIFOBOMBMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1056250", Offset = "0x1054C50", VA = "0x181056250")]
	public void CEGAKGBDODP(byte[] MCBNAPIFOAJ, int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1056510", Offset = "0x1054F10", VA = "0x181056510")]
	public bool KHKHNBPILAC(ArraySegment<byte> IPKOPOLJGIA, out int HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x10565C0", Offset = "0x1054FC0", VA = "0x1810565C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1055FD0", Offset = "0x10549D0", VA = "0x181055FD0")]
	private static void BOKEFEHALPD(IEnumerable<IEJNMNCLHPP> NBGIHLBMDOM, StringBuilder CBPOGHHPGON, int FBHGCDEDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1056410", Offset = "0x1054E10", VA = "0x181056410", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x1056410", Offset = "0x1054E10", VA = "0x181056410", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1056370", Offset = "0x1054D70", VA = "0x181056370")]
	[IteratorStateMachine(typeof(FMAKBEDEGMP))]
	private static IEnumerable<KeyValuePair<string, int>> FBOHFBACHGO(IEnumerable<IEJNMNCLHPP> NBGIHLBMDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x10563E0", Offset = "0x1054DE0", VA = "0x1810563E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x173C040", Offset = "0x173AA40", VA = "0x18173C040")]
	public static ulong NLKGAHHLEIA(byte[] MCBNAPIFOAJ, ref int EFGENLFBGLF, ref int NCLHFGCCBKN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class KEOMJLODKFB
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xCEC880", Offset = "0xCEB280", VA = "0x180CEC880")]
	public static void PJBHCHFGCIP(ref byte[] MCBNAPIFOAJ, int EFGENLFBGLF, int DFINGJIDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xCEC790", Offset = "0xCEB190", VA = "0x180CEC790")]
	public static void MEDEEPKBKGL(ref byte[] OBKDNKHGCJN, int EFBBJJEALLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0xCEC6A0", Offset = "0xCEB0A0", VA = "0x180CEC6A0")]
	public static byte[] HKPACCJHEJG(byte[] MEJEPMBMJMJ, int EFBBJJEALLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class JABIFOLGFEJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0xCEB120", Offset = "0xCE9B20", VA = "0x180CEB120")]
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
		[Cpp2IlInjected.Address(RVA = "0x3231740", Offset = "0x3230140", VA = "0x183231740", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x20442D0", Offset = "0x2042CD0", VA = "0x1820442D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x323B410", Offset = "0x3239E10", VA = "0x18323B410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x274A610", Offset = "0x2749010", VA = "0x18274A610")]
		[DebuggerHidden]
		public NBACKAIHDFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x323A060", Offset = "0x3238A60", VA = "0x18323A060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x323AE70", Offset = "0x3239870", VA = "0x18323AE70", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3240D50", Offset = "0x323F750", VA = "0x183240D50")]
	public PGGILBMECPD(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3240C90", Offset = "0x323F690", VA = "0x183240C90")]
	public PGGILBMECPD(int POIIDIEGIKN, float PMOIAJAIBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x323EA00", Offset = "0x323D400", VA = "0x18323EA00")]
	public void CEGAKGBDODP(byte[] IPKOPOLJGIA, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x323FBD0", Offset = "0x323E5D0", VA = "0x18323FBD0")]
	private bool IONFMHFIPMB(byte[] IPKOPOLJGIA, T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x323F140", Offset = "0x323DB40", VA = "0x18323F140")]
	public bool FIJKPMMFIIC(ArraySegment<byte> IPKOPOLJGIA, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x323F830", Offset = "0x323E230", VA = "0x18323F830")]
	private static ulong HCFPONENFHN(byte[] EDIMMNEBDAA, int EFGENLFBGLF, int LKEJFKMJCND)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3240C60", Offset = "0x323F660", VA = "0x183240C60")]
	private static int PKLPMINACCM(int BPIKIINOKDK, float PMOIAJAIBAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x323F7A0", Offset = "0x323E1A0", VA = "0x18323F7A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::PGGILBMECPD<>.NBACKAIHDFJ))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FA80", Offset = "0x2E3E480", VA = "0x182E3FA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1744CB0", Offset = "0x17436B0", VA = "0x181744CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1744D00", Offset = "0x1743700", VA = "0x181744D00")]
	static PPLNPDMOGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1744F50", Offset = "0x1743950", VA = "0x181744F50")]
	public PPLNPDMOGEG(byte[] JEKNJMFKHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1744BA0", Offset = "0x17435A0", VA = "0x181744BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x104CBD0", Offset = "0x104B5D0", VA = "0x18104CBD0")]
	public AGIIJDMNOGO(ref Guid HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x104C520", Offset = "0x104AF20", VA = "0x18104C520")]
	public AGIIJDMNOGO(ref ArraySegment<byte> NCCLJODPHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x104AF60", Offset = "0x1049960", VA = "0x18104AF60")]
	private static byte CFCDHJAEHGC(byte[] MCBNAPIFOAJ, int JMLCFFBPFCO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x104B020", Offset = "0x1049A20", VA = "0x18104B020")]
	private static byte DACLBICPOHM(byte ODMIEFIFOGP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x104B130", Offset = "0x1049B30", VA = "0x18104B130")]
	public void OAHHKABCHNK(byte[] HKIDJJNOKDE, int EFGENLFBGLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class CDPJGOEEBJJ
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x10519D0", Offset = "0x10503D0", VA = "0x1810519D0")]
	public static bool GBPIBEKDAOL(byte HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x1050EB0", Offset = "0x104F8B0", VA = "0x181050EB0")]
	public static bool AMFAMOPGCHE(byte HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1052770", Offset = "0x1051170", VA = "0x181052770")]
	public static sbyte OAOEKFCIEHM(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x10510A0", Offset = "0x104FAA0", VA = "0x1810510A0")]
	public static short COBOLEKNFCO(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1051960", Offset = "0x1050360", VA = "0x181051960")]
	public static int ELOKLDKLIOE(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x10527E0", Offset = "0x10511E0", VA = "0x1810527E0")]
	public static long OGPILMDFGMC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1051A50", Offset = "0x1050450", VA = "0x181051A50")]
	public static byte IHFFJFHFPEF(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1051AC0", Offset = "0x10504C0", VA = "0x181051AC0")]
	public static ushort JJOHNOGFNMI(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x1051110", Offset = "0x104FB10", VA = "0x181051110")]
	public static uint DJCPPPJFBFP(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1050F20", Offset = "0x104F920", VA = "0x181050F20")]
	public static ulong BGKLIEFBFBC(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x10519E0", Offset = "0x10503E0", VA = "0x1810519E0")]
	public static float HAEFCCCAOLO(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x1051030", Offset = "0x104FA30", VA = "0x181051030")]
	public static double CIMKDHCOHKE(byte[] MCBNAPIFOAJ, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1051190", Offset = "0x104FB90", VA = "0x181051190")]
	public static int DOACEEBMFKB(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, ulong HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x1051B30", Offset = "0x1050530", VA = "0x181051B30")]
	public static int KBKMNMIKIGD(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, long HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1050C60", Offset = "0x104F660", VA = "0x181050C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public KEBMIDDGNNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1737A30", Offset = "0x1736430", VA = "0x181737A30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x17375D0", Offset = "0x1735FD0", VA = "0x1817375D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1737B50", Offset = "0x1736550", VA = "0x181737B50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1737BA0", Offset = "0x17365A0", VA = "0x181737BA0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x17379E0", Offset = "0x17363E0", VA = "0x1817379E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1737930", Offset = "0x1736330", VA = "0x181737930", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1737930", Offset = "0x1736330", VA = "0x181737930", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
		[DebuggerHidden]
		public EIIJKCJHJDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1736EA0", Offset = "0x17358A0", VA = "0x181736EA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1736A40", Offset = "0x1735440", VA = "0x181736A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1736FC0", Offset = "0x17359C0", VA = "0x181736FC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1737010", Offset = "0x1735A10", VA = "0x181737010")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1736E50", Offset = "0x1735850", VA = "0x181736E50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1736DA0", Offset = "0x17357A0", VA = "0x181736DA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1736DA0", Offset = "0x17357A0", VA = "0x181736DA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1744600", Offset = "0x1743000", VA = "0x181744600")]
	public static bool OJBJLPBKPAO(this TypeInfo IEADHAAGEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x17444A0", Offset = "0x1742EA0", VA = "0x1817444A0")]
	public static bool IALCOOAIABM(this TypeInfo IEADHAAGEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x17443B0", Offset = "0x1742DB0", VA = "0x1817443B0")]
	public static IEnumerable<PropertyInfo> CFHMPJBKHPL(this Type IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x17446B0", Offset = "0x17430B0", VA = "0x1817446B0")]
	[IteratorStateMachine(typeof(KEBMIDDGNNO))]
	private static IEnumerable<PropertyInfo> OOGBBPHEPCA(Type IEADHAAGEDA, HashSet<string> OFHIMJGDFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x17445A0", Offset = "0x1742FA0", VA = "0x1817445A0")]
	public static IEnumerable<FieldInfo> KLJDFCMIMPA(this Type IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1744410", Offset = "0x1742E10", VA = "0x181744410")]
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
	[Cpp2IlInjected.Address(RVA = "0x6452E0", Offset = "0x643CE0", VA = "0x1806452E0")]
	public static string MELOHGDMMDB(string GMKEBMDCCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xCE0270", Offset = "0xCDEC70", VA = "0x180CE0270")]
	public static string FDFCHIKOEPC(string GMKEBMDCCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xCE0380", Offset = "0xCDED80", VA = "0x180CE0380")]
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
		[Cpp2IlInjected.Address(RVA = "0x38D14F0", Offset = "0x38CFEF0", VA = "0x1838D14F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x38D1290", Offset = "0x38CFC90", VA = "0x1838D1290")]
		private int HEBEBONJJIP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public GKNPFFKCIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6311E0", Offset = "0x62FBE0", VA = "0x1806311E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x38DAF70", Offset = "0x38D9970", VA = "0x1838DAF70")]
	public IGFADKHPDOF(int POIIDIEGIKN = 4, float PMOIAJAIBAJ = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x38DACD0", Offset = "0x38D96D0", VA = "0x1838DACD0")]
	public bool JPOPBPNIDEA(Type IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x38DAF30", Offset = "0x38D9930", VA = "0x1838DAF30")]
	public bool JPOPBPNIDEA(Type IPKOPOLJGIA, Func<Type, TValue> EMEJAMGGEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x38DA580", Offset = "0x38D8F80", VA = "0x1838DA580")]
	private bool IONFMHFIPMB(Type IPKOPOLJGIA, Func<Type, TValue> EMEJAMGGEHA, out TValue NHHIGOBDELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x38D9EF0", Offset = "0x38D88F0", VA = "0x1838D9EF0")]
	private bool AEEMGMGKFPO(BIENIMEHIDK[] DDPFONOLJEE, Type AIBDINMEHCK, BIENIMEHIDK IJGLKEPNDAK, Func<Type, TValue> EMEJAMGGEHA, out TValue NHHIGOBDELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x38DA2E0", Offset = "0x38D8CE0", VA = "0x1838DA2E0")]
	public bool FIJKPMMFIIC(Type IPKOPOLJGIA, out TValue HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x38DAB80", Offset = "0x38D9580", VA = "0x1838DAB80")]
	public TValue JJBBAKFANLO(Type IPKOPOLJGIA, Func<Type, TValue> EMEJAMGGEHA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3240C60", Offset = "0x323F660", VA = "0x183240C60")]
	private static int PKLPMINACCM(int BPIKIINOKDK, float PMOIAJAIBAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x38DA2B0", Offset = "0x38D8CB0", VA = "0x1838DA2B0")]
	private static void BBPINEIPPEI(ref BIENIMEHIDK EDIICOPIJBG, BIENIMEHIDK HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x38DA2B0", Offset = "0x38D8CB0", VA = "0x1838DA2B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF24B0", Offset = "0xCF0EB0", VA = "0x180CF24B0")]
	public TypeBuilder NCJJMKHIOMC(string JMIBJFINBJD, TypeAttributes LODADOOLOLI, Type MMEAACHMALE, Type[] NFAMNNLJDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xCF25A0", Offset = "0xCF0FA0", VA = "0x180CF25A0")]
	public NEMPGDCHPOI(string LJDMNOMNFNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class JPNCKBFMCFC
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xCEC4F0", Offset = "0xCEAEF0", VA = "0x180CEC4F0")]
	private static MethodInfo KJJEHKDOPKK(LambdaExpression DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x307FB50", Offset = "0x307E550", VA = "0x18307FB50")]
	public static MethodInfo JLMKJKBJGPC<T>(Expression<Func<T>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x307FB50", Offset = "0x307E550", VA = "0x18307FB50")]
	public static MethodInfo JLMKJKBJGPC<T, TR>(Expression<Func<T, TR>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x307FB50", Offset = "0x307E550", VA = "0x18307FB50")]
	public static MethodInfo JLMKJKBJGPC<T>(Expression<Action<T>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x307FB50", Offset = "0x307E550", VA = "0x18307FB50")]
	public static MethodInfo JLMKJKBJGPC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> DMGDMFFGPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x307FAB0", Offset = "0x307E4B0", VA = "0x18307FAB0")]
	private static MemberInfo DKMAEAMNKDO<T>(Expression<T> EKMDJKANAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x307FA50", Offset = "0x307E450", VA = "0x18307FA50")]
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
	[Cpp2IlInjected.Address(RVA = "0x1057EB0", Offset = "0x10568B0", VA = "0x181057EB0")]
	public DGGGCNDMAMN(ILGenerator BAHIJJBPKKH, int PFAINNECIEO, bool GIAACAMJHNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1057EF0", Offset = "0x10568F0", VA = "0x181057EF0")]
	public DGGGCNDMAMN(ILGenerator BAHIJJBPKKH, int PFAINNECIEO, Type IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1057DA0", Offset = "0x10567A0", VA = "0x181057DA0")]
	public void JCCHNMHHKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class FIEIFKMBBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x105E970", Offset = "0x105D370", VA = "0x18105E970")]
	public static void OMKIDDFKOHM(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x105EBA0", Offset = "0x105D5A0", VA = "0x18105EBA0")]
	public static void OMKIDDFKOHM(this ILGenerator BAHIJJBPKKH, LocalBuilder PEKHFKOJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x105E700", Offset = "0x105D100", VA = "0x18105E700")]
	public static void OBEAMHCMHBK(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x105E930", Offset = "0x105D330", VA = "0x18105E930")]
	public static void OBEAMHCMHBK(this ILGenerator BAHIJJBPKKH, LocalBuilder PEKHFKOJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x105DC80", Offset = "0x105C680", VA = "0x18105DC80")]
	public static void ELLKKJHLIED(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x105DD70", Offset = "0x105C770", VA = "0x18105DD70")]
	public static void ELLKKJHLIED(this ILGenerator BAHIJJBPKKH, LocalBuilder PEKHFKOJJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x105E490", Offset = "0x105CE90", VA = "0x18105E490")]
	public static void IFLIDPLDKCE(this ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x105EBE0", Offset = "0x105D5E0", VA = "0x18105EBE0")]
	public static void POHCHCPAADK(this ILGenerator BAHIJJBPKKH, bool HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x105DF10", Offset = "0x105C910", VA = "0x18105DF10")]
	public static void FMAMEBPOOKP(this ILGenerator BAHIJJBPKKH, int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x105E520", Offset = "0x105CF20", VA = "0x18105E520")]
	public static void LNFAFANJBPH(this ILGenerator BAHIJJBPKKH, Type IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x105E360", Offset = "0x105CD60", VA = "0x18105E360")]
	public static void HCNKFKGHDHN(this ILGenerator BAHIJJBPKKH, Type IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x105D950", Offset = "0x105C350", VA = "0x18105D950")]
	public static void BNPKCDJPDON(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x105E4A0", Offset = "0x105CEA0", VA = "0x18105E4A0")]
	public static void JDOLOOFKDCK(this ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x105E610", Offset = "0x105D010", VA = "0x18105E610")]
	public static void MNFNOFOIFEL(this ILGenerator BAHIJJBPKKH, int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x105DB80", Offset = "0x105C580", VA = "0x18105DB80")]
	public static void EKGOBKNBMFM(this ILGenerator BAHIJJBPKKH, MethodInfo GAGLGCGJEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x105DE80", Offset = "0x105C880", VA = "0x18105DE80")]
	public static void FJBDNLLLALE(this ILGenerator BAHIJJBPKKH, FieldInfo EIMPHMLBICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x105E400", Offset = "0x105CE00", VA = "0x18105E400")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public BMFMIOLLDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1050840", Offset = "0x104F240", VA = "0x181050840")]
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
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LENNIPLEDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EAAHBCNKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x105ED70", Offset = "0x105D770", VA = "0x18105ED70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AAAFMDHDGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x587EB0", Offset = "0x5868B0", VA = "0x180587EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6462A0", Offset = "0x644CA0", VA = "0x1806462A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PNCCFKIJDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x587EC0", Offset = "0x5868C0", VA = "0x180587EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x820590", Offset = "0x81EF90", VA = "0x180820590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type KIONGMBJAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x564490", Offset = "0x562E90", VA = "0x180564490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x751CA0", Offset = "0x7506A0", VA = "0x180751CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo CBLHENADNEP
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo BLCCBONHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5644A0", Offset = "0x562EA0", VA = "0x1805644A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x588CD0", Offset = "0x5876D0", VA = "0x180588CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo DJMMHCDKCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x563800", Offset = "0x562200", VA = "0x180563800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x563880", Offset = "0x562280", VA = "0x180563880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x105EEA0", Offset = "0x105D8A0", VA = "0x18105EEA0")]
	protected FIIKBGBBFLN(Type IEADHAAGEDA, string JMIBJFINBJD, string ALMPKGJJFEH, bool HIIEFCCBDLB, bool BLLKGLFPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x105F0D0", Offset = "0x105DAD0", VA = "0x18105F0D0")]
	public FIIKBGBBFLN(FieldInfo EEHCANMAMAN, string JMIBJFINBJD, bool PNKMJLMLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x105EF20", Offset = "0x105D920", VA = "0x18105EF20")]
	public FIIKBGBBFLN(PropertyInfo EEHCANMAMAN, string JMIBJFINBJD, bool PNKMJLMLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x105ED80", Offset = "0x105D780", VA = "0x18105ED80")]
	private static MethodInfo KFJINEHCOKE(MemberInfo EEHCANMAMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2937460", Offset = "0x2935E60", VA = "0x182937460")]
	public T LBALIGHEKAD<T>(bool MMJDIEBIOBG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x105ECB0", Offset = "0x105D6B0", VA = "0x18105ECB0", Slot = "4")]
	public virtual void ALAAMLENAEK(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x105EBF0", Offset = "0x105D5F0", VA = "0x18105EBF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1056830", Offset = "0x1055230", VA = "0x181056830")]
	public CJLANAODLKO(string JMIBJFINBJD, string FPAPAPCFHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1056770", Offset = "0x1055170", VA = "0x181056770", Slot = "4")]
	public override void ALAAMLENAEK(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1056720", Offset = "0x1055120", VA = "0x181056720", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1053770", Offset = "0x1052170", VA = "0x181053770")]
	public CENNODFFIKC(string JMIBJFINBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1053100", Offset = "0x1051B00", VA = "0x181053100", Slot = "4")]
	public override void ALAAMLENAEK(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x10530B0", Offset = "0x1051AB0", VA = "0x1810530B0", Slot = "5")]
	public override void AIOIAOIKILP(ILGenerator BAHIJJBPKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x10531C0", Offset = "0x1051BC0", VA = "0x1810531C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NAHHAEEMONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82D430", Offset = "0x82BE30", VA = "0x18082D430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x927070", Offset = "0x925A70", VA = "0x180927070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IKCJMKEPDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x821BB0", Offset = "0x8205B0", VA = "0x180821BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x927050", Offset = "0x925A50", VA = "0x180927050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo OKMBAOBCLII
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FIIKBGBBFLN[] BLLGDGIMNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x564490", Offset = "0x562E90", VA = "0x180564490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x751CA0", Offset = "0x7506A0", VA = "0x180751CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FIIKBGBBFLN[] BOAJOMNDMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1741340", Offset = "0x173FD40", VA = "0x181741340")]
	public PAFFIENPFGC(Type IEADHAAGEDA, Func<string, string> HAHDGNKINBF, bool PNKMJLMLEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1741270", Offset = "0x173FC70", VA = "0x181741270")]
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
	[Cpp2IlInjected.Address(RVA = "0x17436D0", Offset = "0x17420D0", VA = "0x1817436D0")]
	public PDELLNIGBNO(ulong IGJPHEDHODE, int EIEJBGLMMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1743540", Offset = "0x1741F40", VA = "0x181743540")]
	public void MJEGOMGGHAC(ref PDELLNIGBNO KKPJJILPNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x17435F0", Offset = "0x1741FF0", VA = "0x1817435F0")]
	public static PDELLNIGBNO PBJLMINGJHG(ref PDELLNIGBNO MMADIBJKHHM, ref PDELLNIGBNO ODMIEFIFOGP)
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x17434B0", Offset = "0x1741EB0", VA = "0x1817434B0")]
	public void GNJAGKPJOGG(ref PDELLNIGBNO KKPJJILPNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1743620", Offset = "0x1742020", VA = "0x181743620")]
	public static PDELLNIGBNO PMKMDLCIMMK(ref PDELLNIGBNO MMADIBJKHHM, ref PDELLNIGBNO ODMIEFIFOGP)
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x17435B0", Offset = "0x1741FB0", VA = "0x1817435B0")]
	public void MPPHKPLKJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1743550", Offset = "0x1741F50", VA = "0x181743550")]
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
	[Cpp2IlInjected.Address(RVA = "0xB5DFF0", Offset = "0xB5C9F0", VA = "0x180B5DFF0")]
	public MKKNEHOHAKP(byte[] HKIDJJNOKDE, int BJMMNGJKEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xCEF440", Offset = "0xCEDE40", VA = "0x180CEF440")]
	public void GFMGKCNJEOD(byte CDKMLIMBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xCEF5F0", Offset = "0xCEDFF0", VA = "0x180CEF5F0")]
	public void GKBFGBBGLDP(byte[] CDKMLIMBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xCEF550", Offset = "0xCEDF50", VA = "0x180CEF550")]
	public void GGHHFJGFBGK(byte[] CDKMLIMBHIO, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xCEF4A0", Offset = "0xCEDEA0", VA = "0x180CEF4A0")]
	public void GGHHFJGFBGK(byte[] CDKMLIMBHIO, int FPGEEBEFGEH, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xCEF3C0", Offset = "0xCEDDC0", VA = "0x180CEF3C0")]
	public void COJIDIDIICH(byte HJNCMGDJMJJ, int LKEJFKMJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xCEF690", Offset = "0xCEE090", VA = "0x180CEF690")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF1040", Offset = "0xCEFA40", VA = "0x180CF1040")]
	private static byte[] JPMLDJPJBKE(int OCEBHFCGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xCF0470", Offset = "0xCEEE70", VA = "0x180CF0470")]
	private static byte[] BHBFHAOPNJH(int OCEBHFCGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xCF1110", Offset = "0xCEFB10", VA = "0x180CF1110")]
	public static int KCBMLOAJGNH(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, float HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xCF1220", Offset = "0xCEFC20", VA = "0x180CF1220")]
	public static int KCBMLOAJGNH(ref byte[] HKIDJJNOKDE, int EFGENLFBGLF, double HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xCF0550", Offset = "0xCEEF50", VA = "0x180CF0550")]
	private static bool BMNBBKDGHBJ(byte[] HKIDJJNOKDE, int HHALJLDHKOL, ulong LFCKHJKNONO, ulong ENBCKLAPAHO, ulong NCLHFGCCBKN, ulong GGMOILCLOHI, ulong JHMKONCKHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xCF0C40", Offset = "0xCEF640", VA = "0x180CF0C40")]
	private static void GBBFNAAPMLF(uint LMFEIPAOPBN, int HJLIGOJIOAF, out uint NMEMLBAGIBB, out int EGGBJLHOJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xCF1E60", Offset = "0xCF0860", VA = "0x180CF1E60")]
	private static bool MEOKCEJFLKD(PDELLNIGBNO INIKBPNBJPK, PDELLNIGBNO DECECNMMIBM, PDELLNIGBNO LIFKFDGDDCP, byte[] HKIDJJNOKDE, out int HHALJLDHKOL, out int GGPOFKMMKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xCF14C0", Offset = "0xCEFEC0", VA = "0x180CF14C0")]
	private static bool LDAMLICLNGG(double MEFNHMKKCJN, BOBBOGLKHOG OMMBLABNACO, byte[] HKIDJJNOKDE, out int HHALJLDHKOL, out int DNAHODDGBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xCF1D70", Offset = "0xCF0770", VA = "0x180CF1D70")]
	private static bool LHDKHDOIAMG(double MEFNHMKKCJN, BOBBOGLKHOG OMMBLABNACO, byte[] HKIDJJNOKDE, out int HHALJLDHKOL, out int HAMBPGGOCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xCF1330", Offset = "0xCEFD30", VA = "0x180CF1330")]
	private static bool KDLEMLLIPAB(double HPIAFNBPEPC, ref MKKNEHOHAKP BNCOILEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xCF1740", Offset = "0xCF0140", VA = "0x180CF1740")]
	private static bool LHDEFINAANF(double HPIAFNBPEPC, ref MKKNEHOHAKP BNCOILEGDOK, MNPENBEPDPL OMMBLABNACO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xCF0D60", Offset = "0xCEF760", VA = "0x180CF0D60")]
	private static void IOABGMCEACM(byte[] KKFEDKPEOLE, int HHALJLDHKOL, int HAMBPGGOCGA, int CLPAJJMPMKP, ref MKKNEHOHAKP BNCOILEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xCF0650", Offset = "0xCEF050", VA = "0x180CF0650")]
	private static void EEPIDEGNMHF(byte[] KKFEDKPEOLE, int HHALJLDHKOL, int EIEJBGLMMNK, ref MKKNEHOHAKP BNCOILEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xCF0AA0", Offset = "0xCEF4A0", VA = "0x180CF0AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x105AF20", Offset = "0x1059920", VA = "0x18105AF20")]
	public EKHAOLDGFMG(double GMLDCHLEGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x105AF30", Offset = "0x1059930", VA = "0x18105AF30")]
	public EKHAOLDGFMG(PDELLNIGBNO GMLDCHLEGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x105AEA0", Offset = "0x10598A0", VA = "0x18105AEA0")]
	public PDELLNIGBNO PNGALAAAMKM()
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x105AD50", Offset = "0x1059750", VA = "0x18105AD50")]
	public PDELLNIGBNO NOMLMNNMNPD()
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6311D0", Offset = "0x62FBD0", VA = "0x1806311D0")]
	public ulong EFJGNIPOFIB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x105AB60", Offset = "0x1059560", VA = "0x18105AB60")]
	public double HCMBJABCCCK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x105A930", Offset = "0x1059330", VA = "0x18105A930")]
	public double AKDDKLMMHPK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x105AC50", Offset = "0x1059650", VA = "0x18105AC50")]
	public int JGAFILFMJAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x105AD20", Offset = "0x1059720", VA = "0x18105AD20")]
	public ulong NOJDIOOCKPF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x105A9B0", Offset = "0x10593B0", VA = "0x18105A9B0")]
	public bool ENFJPGLLCNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x105AC80", Offset = "0x1059680", VA = "0x18105AC80")]
	public bool JNJJJAAEPFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x105ACA0", Offset = "0x10596A0", VA = "0x18105ACA0")]
	public bool KNJIOJKPKKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x105ACF0", Offset = "0x10596F0", VA = "0x18105ACF0")]
	public bool NHNGILLLHKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x105ACD0", Offset = "0x10596D0", VA = "0x18105ACD0")]
	public int NDKHHMLMOFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x105A9D0", Offset = "0x10593D0", VA = "0x18105A9D0")]
	public void FMJLABMDJEC(out PDELLNIGBNO JDOIOBAOBGM, out PDELLNIGBNO OOFNKFGBCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x105ABD0", Offset = "0x10595D0", VA = "0x18105ABD0")]
	public bool HEHINCIACFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x105AC20", Offset = "0x1059620", VA = "0x18105AC20")]
	public double HPIAFNBPEPC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x105AC30", Offset = "0x1059630", VA = "0x18105AC30")]
	public static int HPKEJMKBLOC(int ANOGJAHAOAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x105ADF0", Offset = "0x10597F0", VA = "0x18105ADF0")]
	public static double OLOKBNMADCA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x105AE00", Offset = "0x1059800", VA = "0x18105AE00")]
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
	[Cpp2IlInjected.Address(RVA = "0x560480", Offset = "0x55EE80", VA = "0x180560480")]
	public CBIGKKICAIG(float LAHEDMIAMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1050BF0", Offset = "0x104F5F0", VA = "0x181050BF0")]
	public PDELLNIGBNO PNGALAAAMKM()
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210")]
	public uint HHAIMNPCMJP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1050BB0", Offset = "0x104F5B0", VA = "0x181050BB0")]
	public int JGAFILFMJAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1050BD0", Offset = "0x104F5D0", VA = "0x181050BD0")]
	public uint NOJDIOOCKPF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x10509F0", Offset = "0x104F3F0", VA = "0x1810509F0")]
	public bool ENFJPGLLCNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1050A00", Offset = "0x104F400", VA = "0x181050A00")]
	public void FMJLABMDJEC(out PDELLNIGBNO JDOIOBAOBGM, out PDELLNIGBNO OOFNKFGBCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1050B70", Offset = "0x104F570", VA = "0x181050B70")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEC5E0", Offset = "0xCEAFE0", VA = "0x180CEC5E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x173EEA0", Offset = "0x173D8A0", VA = "0x18173EEA0")]
	public static void IEGPJJDOOOP(int GKJLHOONJEB, int FONLDFEMDAB, out PDELLNIGBNO NMEMLBAGIBB, out int DNAHODDGBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x173EDB0", Offset = "0x173D7B0", VA = "0x18173EDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE8340", Offset = "0xCE6D40", VA = "0x180CE8340")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xCE83E0", Offset = "0xCE6DE0", VA = "0x180CE83E0")]
	public GMKKBJHLNJG(byte[] MCBNAPIFOAJ, int FPGEEBEFGEH, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xA9C130", Offset = "0xA9AB30", VA = "0x180A9C130")]
	public int HHALJLDHKOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xCE8380", Offset = "0xCE6D80", VA = "0x180CE8380")]
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
	[Cpp2IlInjected.Address(RVA = "0xCE9090", Offset = "0xCE7A90", VA = "0x180CE9090")]
	private static byte[] CCCLEBFPDJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xCE9170", Offset = "0xCE7B70", VA = "0x180CE9170")]
	private static GMKKBJHLNJG INBAFLHNNLN(GMKKBJHLNJG HKIDJJNOKDE)
	{
		return default(GMKKBJHLNJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xCE9B20", Offset = "0xCE8520", VA = "0x180CE9B20")]
	private static GMKKBJHLNJG MCFCCAFEMJB(GMKKBJHLNJG HKIDJJNOKDE)
	{
		return default(GMKKBJHLNJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xCE9E30", Offset = "0xCE8830", VA = "0x180CE9E30")]
	private static void PDKPLNFEOOC(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK, byte[] IAPNGNHCHFE, out int ANBAIBFIAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xCE8970", Offset = "0xCE7370", VA = "0x180CE8970")]
	private static void BKCDCCKHCFD(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK, byte[] FAFDBIOALGG, int JKHDMBCLDLD, out GMKKBJHLNJG DKBOKHCAIEF, out int LDIADADFOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0xCE9C00", Offset = "0xCE8600", VA = "0x180CE9C00")]
	private static ulong NNNCEFMOIPL(GMKKBJHLNJG HKIDJJNOKDE, out int PKKHGLDFHGE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xCE9C90", Offset = "0xCE8690", VA = "0x180CE9C90")]
	private static void ODCFKEGNMJC(GMKKBJHLNJG HKIDJJNOKDE, out PDELLNIGBNO HEMKPPOPDKI, out int APFALJHBIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xCE9250", Offset = "0xCE7C50", VA = "0x180CE9250")]
	private static bool KHMLPKGFHNE(GMKKBJHLNJG DKBOKHCAIEF, int EIEJBGLMMNK, out double HEMKPPOPDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xCE99C0", Offset = "0xCE83C0", VA = "0x180CE99C0")]
	private static PDELLNIGBNO LMNPELNEAIC(int EIEJBGLMMNK)
	{
		return default(PDELLNIGBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xCE8C90", Offset = "0xCE7690", VA = "0x180CE8C90")]
	private static bool BPOIMHFHPAG(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK, out double HEMKPPOPDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xCE9880", Offset = "0xCE8280", VA = "0x180CE9880")]
	private static bool LELEKIFKIBJ(GMKKBJHLNJG DKBOKHCAIEF, int EIEJBGLMMNK, out double KLEFCPEKLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xCE8840", Offset = "0xCE7240", VA = "0x180CE8840")]
	public static double? ACLIJHCJNEO(GMKKBJHLNJG HKIDJJNOKDE, int EIEJBGLMMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xCE96A0", Offset = "0xCE80A0", VA = "0x180CE96A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10503D0", Offset = "0x104EDD0", VA = "0x1810503D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xB5DFF0", Offset = "0xB5C9F0", VA = "0x180B5DFF0")]
	public BHNMJNEJIGI(byte[] HKIDJJNOKDE, int EFGENLFBGLF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1050490", Offset = "0x104EE90", VA = "0x181050490")]
	public static BHNMJNEJIGI OAONKMPIPOH(BHNMJNEJIGI NPNHPOMDOAL)
	{
		return default(BHNMJNEJIGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x10502F0", Offset = "0x104ECF0", VA = "0x1810502F0")]
	public static BHNMJNEJIGI EKHKEPKDEBI(BHNMJNEJIGI NPNHPOMDOAL, int HHALJLDHKOL)
	{
		return default(BHNMJNEJIGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1050410", Offset = "0x104EE10", VA = "0x181050410")]
	public static int LOLOPLNMBHA(BHNMJNEJIGI JINPLGIOFKM, BHNMJNEJIGI LFEBODKGKDF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1050430", Offset = "0x104EE30", VA = "0x181050430")]
	public static bool NDENBEODPDO(BHNMJNEJIGI JINPLGIOFKM, BHNMJNEJIGI LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1050290", Offset = "0x104EC90", VA = "0x181050290")]
	public static bool BMFMMFJPNNG(BHNMJNEJIGI JINPLGIOFKM, BHNMJNEJIGI LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1050450", Offset = "0x104EE50", VA = "0x181050450")]
	public static bool NDENBEODPDO(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x10502B0", Offset = "0x104ECB0", VA = "0x1810502B0")]
	public static bool BMFMMFJPNNG(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x10502B0", Offset = "0x104ECB0", VA = "0x1810502B0")]
	public static bool BMFMMFJPNNG(BHNMJNEJIGI JINPLGIOFKM, byte LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1050350", Offset = "0x104ED50", VA = "0x181050350")]
	public static bool HCBFEEPKFFF(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x10504A0", Offset = "0x104EEA0", VA = "0x1810504A0")]
	public static bool OKHPEDBCKHF(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x10504E0", Offset = "0x104EEE0", VA = "0x1810504E0")]
	public static bool PIGDEDHIPLA(BHNMJNEJIGI JINPLGIOFKM, char LFEBODKGKDF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1050390", Offset = "0x104ED90", VA = "0x181050390")]
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
	[Cpp2IlInjected.Address(RVA = "0x1739BD0", Offset = "0x17385D0", VA = "0x181739BD0")]
	private static byte[] PIFPHDIALGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1738580", Offset = "0x1736F80", VA = "0x181738580")]
	private static byte[] ECIFNHACLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1739B10", Offset = "0x1738510", VA = "0x181739B10")]
	public static double OMFPFLBJJIJ(byte[] HKIDJJNOKDE, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1739A00", Offset = "0x1738400", VA = "0x181739A00")]
	public static float LPBDFENPPJJ(byte[] HKIDJJNOKDE, int EFGENLFBGLF, out int ALDJEDACGPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1739880", Offset = "0x1738280", VA = "0x181739880")]
	private static bool GMMFHPNIIOK(int EDIMMNEBDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1738460", Offset = "0x1736E60", VA = "0x181738460")]
	private static bool CLOHCKMOGJB(ref BHNMJNEJIGI LPKFHMBJKIB, BHNMJNEJIGI OLBLGDADAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1738660", Offset = "0x1737060", VA = "0x181738660")]
	private static bool EPJNIPHAMKC(ref BHNMJNEJIGI LPKFHMBJKIB, BHNMJNEJIGI OLBLGDADAAO, byte[] GEJOIEMJMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1739AC0", Offset = "0x17384C0", VA = "0x181739AC0")]
	private static bool NINJEIJBLAP(ref BHNMJNEJIGI NKNLKOGACDJ, byte[] CDKMLIMBHIO, int EFGENLFBGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x746D40", Offset = "0x745740", VA = "0x180746D40")]
	private static double IBEEPFHKGIA(bool KCFLNNMBNAP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1738770", Offset = "0x1737170", VA = "0x181738770")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E06220", Offset = "0x2E04C20", VA = "0x182E06220")]
	public LANJKFOKBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x274A610", Offset = "0x2749010", VA = "0x18274A610")]
	public LANJKFOKBHM(GILNJOLHANP BOBPILNLIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3B65C30", Offset = "0x3B64630", VA = "0x183B65C30", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3B640A0", Offset = "0x3B62AA0", VA = "0x183B640A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E06220", Offset = "0x2E04C20", VA = "0x182E06220")]
	public NMEFIJMKHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x274A610", Offset = "0x2749010", VA = "0x18274A610")]
	public NMEFIJMKHGN(GILNJOLHANP BOBPILNLIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2E05560", Offset = "0x2E03F60", VA = "0x182E05560", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, List<T> HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2E05170", Offset = "0x2E03B70", VA = "0x182E05170", Slot = "5")]
	public List<T> FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class KBIJAJBPMCD<TElement, TIntermediate, TEnumerator, TCollection> : global::EGNEGNMBKFG<TCollection>, EGFLKHELIAB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4198150", Offset = "0x4196B50", VA = "0x184198150", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, TCollection HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4197510", Offset = "0x4195F10", VA = "0x184197510", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
	protected KBIJAJBPMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class MIJGBNKLLAH<TElement, TIntermediate, TCollection> : global::KBIJAJBPMCD<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x32C8820", Offset = "0x32C7220", VA = "0x1832C8820", Slot = "6")]
	protected override IEnumerator<TElement> KEDKPBOLKJP(TCollection EKMDJKANAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x274BB00", Offset = "0x274A500", VA = "0x18274BB00")]
	protected MIJGBNKLLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class POONNIOLCOH<TElement, TCollection> : global::MIJGBNKLLAH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected sealed override TCollection DCGILHLCDMK(ref TCollection GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class HIMCPKAGMFE<TElement, TCollection> : global::POONNIOLCOH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3A789A0", Offset = "0x3A773A0", VA = "0x183A789A0", Slot = "7")]
	protected override TCollection AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3A789C0", Offset = "0x3A773C0", VA = "0x183A789C0", Slot = "8")]
	protected override void CEGAKGBDODP(ref TCollection JFAFFHBNMKC, int LGBFGOJBLFK, TElement HPIAFNBPEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GLJIINIIPFA<T> : global::KBIJAJBPMCD<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x38B35D0", Offset = "0x38B1FD0", VA = "0x1838B35D0", Slot = "8")]
	protected override void CEGAKGBDODP(ref LinkedList<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override LinkedList<T> DCGILHLCDMK(ref LinkedList<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override LinkedList<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x38B3610", Offset = "0x38B2010", VA = "0x1838B3610", Slot = "6")]
	protected override LinkedList<T>.Enumerator KEDKPBOLKJP(LinkedList<T> EKMDJKANAME)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class FOBJEGNANOL<T> : global::KBIJAJBPMCD<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x38B35D0", Offset = "0x38B1FD0", VA = "0x1838B35D0", Slot = "8")]
	protected override void CEGAKGBDODP(ref Queue<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override Queue<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x333E410", Offset = "0x333CE10", VA = "0x18333E410", Slot = "6")]
	protected override Queue<T>.Enumerator KEDKPBOLKJP(Queue<T> EKMDJKANAME)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override Queue<T> DCGILHLCDMK(ref Queue<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DMOIFLIPEPC<T> : global::KBIJAJBPMCD<T, global::MLNAMEPCKNM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7C30", Offset = "0x2CE6630", VA = "0x182CE7C30", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7BE0", Offset = "0x2CE65E0", VA = "0x182CE7BE0", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x333E410", Offset = "0x333CE10", VA = "0x18333E410", Slot = "6")]
	protected override Stack<T>.Enumerator KEDKPBOLKJP(Stack<T> EKMDJKANAME)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x333E330", Offset = "0x333CD30", VA = "0x18333E330", Slot = "9")]
	protected override Stack<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NJCGKJMEDOB<T> : global::KBIJAJBPMCD<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x38B35D0", Offset = "0x38B1FD0", VA = "0x1838B35D0", Slot = "8")]
	protected override void CEGAKGBDODP(ref HashSet<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override HashSet<T> DCGILHLCDMK(ref HashSet<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override HashSet<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x333E410", Offset = "0x333CE10", VA = "0x18333E410", Slot = "6")]
	protected override HashSet<T>.Enumerator KEDKPBOLKJP(HashSet<T> EKMDJKANAME)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NHDIEFFNPCN<T> : global::MIJGBNKLLAH<T, global::MLNAMEPCKNM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7C30", Offset = "0x2CE6630", VA = "0x182CE7C30", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3E07DA0", Offset = "0x3E067A0", VA = "0x183E07DA0", Slot = "9")]
	protected override ReadOnlyCollection<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3E07D50", Offset = "0x3E06750", VA = "0x183E07D50", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class KABLJICJJMN<T> : global::MIJGBNKLLAH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x38B35D0", Offset = "0x38B1FD0", VA = "0x1838B35D0", Slot = "8")]
	protected override void CEGAKGBDODP(ref List<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override List<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override IList<T> DCGILHLCDMK(ref List<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class FGFBEBMBDCH<T> : global::MIJGBNKLLAH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x38B35D0", Offset = "0x38B1FD0", VA = "0x1838B35D0", Slot = "8")]
	protected override void CEGAKGBDODP(ref List<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override List<T> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override ICollection<T> DCGILHLCDMK(ref List<T> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class BKKPKEGNCME<T> : global::MIJGBNKLLAH<T, global::MLNAMEPCKNM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7C30", Offset = "0x2CE6630", VA = "0x182CE7C30", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7BE0", Offset = "0x2CE65E0", VA = "0x182CE7BE0", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7C60", Offset = "0x2CE6660", VA = "0x182CE7C60", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x173BC00", Offset = "0x173A600", VA = "0x18173BC00", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, IEnumerable HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x173BA80", Offset = "0x173A480", VA = "0x18173BA80", Slot = "5")]
	public IEnumerable FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1743BB0", Offset = "0x17425B0", VA = "0x181743BB0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ICollection HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1743A30", Offset = "0x1742430", VA = "0x181743A30", Slot = "5")]
	public ICollection FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEA8C0", Offset = "0xCE92C0", VA = "0x180CEA8C0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, IList HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xCEA6D0", Offset = "0xCE90D0", VA = "0x180CEA6D0", Slot = "5")]
	public IList FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public ICIOFOAAFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JGENHBGNADM<T> : global::MIJGBNKLLAH<T, global::MLNAMEPCKNM<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3735C20", Offset = "0x3734620", VA = "0x183735C20", Slot = "8")]
	protected override void CEGAKGBDODP(ref global::MLNAMEPCKNM<T> JFAFFHBNMKC, int LGBFGOJBLFK, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7BE0", Offset = "0x2CE65E0", VA = "0x182CE7BE0", Slot = "7")]
	protected override global::MLNAMEPCKNM<T> AEEGCHIFHAD()
	{
		return default(global::MLNAMEPCKNM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3735C50", Offset = "0x3734650", VA = "0x183735C50", Slot = "9")]
	protected override IReadOnlyList<T> DCGILHLCDMK(ref global::MLNAMEPCKNM<T> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x274BBD0", Offset = "0x274A5D0", VA = "0x18274BBD0")]
	public JGENHBGNADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class EPLKHAJPKKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x105BC20", Offset = "0x105A620", VA = "0x18105BC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x173E900", Offset = "0x173D300", VA = "0x18173E900", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, DateTime HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x173DA00", Offset = "0x173C400", VA = "0x18173DA00", Slot = "5")]
	public DateTime FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x104EA70", Offset = "0x104D470", VA = "0x18104EA70", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, DateTimeOffset HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x104DB90", Offset = "0x104C590", VA = "0x18104DB90", Slot = "5")]
	public DateTimeOffset FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x104D450", Offset = "0x104BE50", VA = "0x18104D450", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, TimeSpan HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x104CBE0", Offset = "0x104B5E0", VA = "0x18104CBE0", Slot = "5")]
	public TimeSpan FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public AIDJBLCJOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class HJHIMNEIOCJ<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::EGNEGNMBKFG<TDictionary>, EGFLKHELIAB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3A7ABE0", Offset = "0x3A795E0", VA = "0x183A7ABE0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, TDictionary HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3A78AA0", Offset = "0x3A774A0", VA = "0x183A78AA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
	protected HJHIMNEIOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class GLGMOKDEAFK<TKey, TValue, TIntermediate, TDictionary> : global::HJHIMNEIOCJ<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x32C8820", Offset = "0x32C7220", VA = "0x1832C8820", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> KEDKPBOLKJP(TDictionary EKMDJKANAME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class JLNOOHMAFBK<TKey, TValue, TDictionary> : global::GLGMOKDEAFK<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override TDictionary DCGILHLCDMK(ref TDictionary GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KLDONNKNJCN<TKey, TValue> : global::HJHIMNEIOCJ<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x40536A0", Offset = "0x40520A0", VA = "0x1840536A0", Slot = "8")]
	protected override void CEGAKGBDODP(ref Dictionary<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override Dictionary<TKey, TValue> DCGILHLCDMK(ref Dictionary<TKey, TValue> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override Dictionary<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x40536E0", Offset = "0x40520E0", VA = "0x1840536E0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator KEDKPBOLKJP(Dictionary<TKey, TValue> EKMDJKANAME)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2752500", Offset = "0x2750F00", VA = "0x182752500")]
	public KLDONNKNJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BIKIIBDDLDJ<TKey, TValue, TDictionary> : global::JLNOOHMAFBK<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7240", Offset = "0x3BF5C40", VA = "0x183BF7240", Slot = "8")]
	protected override void CEGAKGBDODP(ref TDictionary JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x32109F0", Offset = "0x320F3F0", VA = "0x1832109F0", Slot = "7")]
	protected override TDictionary AEEGCHIFHAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JLHDIDHLLNK<TKey, TValue> : global::GLGMOKDEAFK<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2D71AE0", Offset = "0x2D704E0", VA = "0x182D71AE0", Slot = "8")]
	protected override void CEGAKGBDODP(ref Dictionary<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override Dictionary<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override IDictionary<TKey, TValue> DCGILHLCDMK(ref Dictionary<TKey, TValue> GMLLNFMAGKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class PNINKJMJNAE<TKey, TValue> : global::JLNOOHMAFBK<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2D71AE0", Offset = "0x2D704E0", VA = "0x182D71AE0", Slot = "8")]
	protected override void CEGAKGBDODP(ref SortedList<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override SortedList<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class HKAHAEOHGDE<TKey, TValue> : global::HJHIMNEIOCJ<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2D71AE0", Offset = "0x2D704E0", VA = "0x182D71AE0", Slot = "8")]
	protected override void CEGAKGBDODP(ref SortedDictionary<TKey, TValue> JFAFFHBNMKC, int LGBFGOJBLFK, TKey IPKOPOLJGIA, TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2131540", Offset = "0x212FF40", VA = "0x182131540", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DCGILHLCDMK(ref SortedDictionary<TKey, TValue> GMLLNFMAGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2D71A80", Offset = "0x2D70480", VA = "0x182D71A80", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> AEEGCHIFHAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7E3A0", Offset = "0x3A7CDA0", VA = "0x183A7E3A0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x104FDA0", Offset = "0x104E7A0", VA = "0x18104FDA0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, IDictionary HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x104FC00", Offset = "0x104E600", VA = "0x18104FC00", Slot = "5")]
	public IDictionary FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1742F50", Offset = "0x1741950", VA = "0x181742F50")]
	public PBDNPMFBHEK(params CGDCFJDMLCL[] BKCLHMIDGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x1742780", Offset = "0x1741180", VA = "0x181742780", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x17426F0", Offset = "0x17410F0", VA = "0x1817426F0", Slot = "5")]
	public object FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class KMCOKMKPJEE
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xCED9C0", Offset = "0xCEC3C0", VA = "0x180CED9C0")]
	public static object HAMGHKKCLOL(Type IEADHAAGEDA, out bool ADIAPEKEAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xCED1E0", Offset = "0xCEBBE0", VA = "0x180CED1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public KFNCICKAONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x41D63B0", Offset = "0x41D4DB0", VA = "0x1841D63B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public HFDDCPEPOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3E59590", Offset = "0x3E57F90", VA = "0x183E59590")]
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
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public KOFLBHOKNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x41D7340", Offset = "0x41D5D40", VA = "0x1841D7340")]
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
	[Cpp2IlInjected.Address(RVA = "0x41C8700", Offset = "0x41C7100", VA = "0x1841C8700")]
	static CNMECNKAOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x34ED6E0", Offset = "0x34EC0E0", VA = "0x1834ED6E0")]
	public CNMECNKAOIP(bool LPOHOPFLKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x41C22A0", Offset = "0x41C0CA0", VA = "0x1841C22A0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x41BF090", Offset = "0x41BDA90", VA = "0x1841BF090", Slot = "5")]
	public T FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x34DF480", Offset = "0x34DDE80", VA = "0x1834DF480", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, T HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x41BC560", Offset = "0x41BAF60", VA = "0x1841BC560", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DD66B0", Offset = "0x3DD50B0", VA = "0x183DD66B0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6280", Offset = "0x3DD4C80", VA = "0x183DD6280", Slot = "5")]
	public T? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x178A0C0", Offset = "0x1788AC0", VA = "0x18178A0C0")]
	public MPJLMJPBNKI(global::EGNEGNMBKFG<T> HLNJJCAFPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD77E0", Offset = "0x3DD61E0", VA = "0x183DD77E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, T? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7510", Offset = "0x3DD5F10", VA = "0x183DD7510", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1058ED0", Offset = "0x10578D0", VA = "0x181058ED0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, sbyte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1058E00", Offset = "0x1057800", VA = "0x181058E00", Slot = "5")]
	public sbyte FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1058E10", Offset = "0x1057810", VA = "0x181058E10", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, sbyte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1058D60", Offset = "0x1057760", VA = "0x181058D60", Slot = "7")]
	public sbyte DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF0220", Offset = "0xCEEC20", VA = "0x180CF0220", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, sbyte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xCF00F0", Offset = "0xCEEAF0", VA = "0x180CF00F0", Slot = "5")]
	public sbyte? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xCF01A0", Offset = "0xCEEBA0", VA = "0x180CF01A0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, sbyte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xCF0040", Offset = "0xCEEA40", VA = "0x180CF0040", Slot = "7")]
	public sbyte? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1056A40", Offset = "0x1055440", VA = "0x181056A40", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, sbyte[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x1056900", Offset = "0x1055300", VA = "0x181056900", Slot = "5")]
	public sbyte[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEBF60", Offset = "0xCEA960", VA = "0x180CEBF60", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, short HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xCEBEC0", Offset = "0xCEA8C0", VA = "0x180CEBEC0", Slot = "5")]
	public short FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0xCEBF20", Offset = "0xCEA920", VA = "0x180CEBF20", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, short HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0xCEBE50", Offset = "0xCEA850", VA = "0x180CEBE50", Slot = "7")]
	public short DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x10570D0", Offset = "0x1055AD0", VA = "0x1810570D0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, short? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x1056F60", Offset = "0x1055960", VA = "0x181056F60", Slot = "5")]
	public short? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x1056FD0", Offset = "0x10559D0", VA = "0x181056FD0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, short? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x1056E90", Offset = "0x1055890", VA = "0x181056E90", Slot = "7")]
	public short? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1743390", Offset = "0x1741D90", VA = "0x181743390", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, short[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x1743250", Offset = "0x1741C50", VA = "0x181743250", Slot = "5")]
	public short[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF0400", Offset = "0xCEEE00", VA = "0x180CF0400", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, int HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xCF0360", Offset = "0xCEED60", VA = "0x180CF0360", Slot = "5")]
	public int FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xCF03C0", Offset = "0xCEEDC0", VA = "0x180CF03C0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, int HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xCF02F0", Offset = "0xCEECF0", VA = "0x180CF02F0", Slot = "7")]
	public int DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1050760", Offset = "0x104F160", VA = "0x181050760", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, int? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x10505F0", Offset = "0x104EFF0", VA = "0x1810505F0", Slot = "5")]
	public int? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x1050660", Offset = "0x104F060", VA = "0x181050660", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, int? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x1050520", Offset = "0x104EF20", VA = "0x181050520", Slot = "7")]
	public int? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCE8700", Offset = "0xCE7100", VA = "0x180CE8700", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, int[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xCE8560", Offset = "0xCE6F60", VA = "0x180CE8560", Slot = "5")]
	public int[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCE84E0", Offset = "0xCE6EE0", VA = "0x180CE84E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, long HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xCE8490", Offset = "0xCE6E90", VA = "0x180CE8490", Slot = "5")]
	public long FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xCE84A0", Offset = "0xCE6EA0", VA = "0x180CE84A0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, long HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xCE8420", Offset = "0xCE6E20", VA = "0x180CE8420", Slot = "7")]
	public long DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9790", VA = "0x180CEAD90", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, long? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xCEAC80", Offset = "0xCE9680", VA = "0x180CEAC80", Slot = "5")]
	public long? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xCEAD10", Offset = "0xCE9710", VA = "0x180CEAD10", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, long? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xCEABC0", Offset = "0xCE95C0", VA = "0x180CEABC0", Slot = "7")]
	public long? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1743FF0", Offset = "0x17429F0", VA = "0x181743FF0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, long[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x1743EB0", Offset = "0x17428B0", VA = "0x181743EB0", Slot = "5")]
	public long[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEED10", Offset = "0xCED710", VA = "0x180CEED10", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, byte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xCEEC70", Offset = "0xCED670", VA = "0x180CEEC70", Slot = "5")]
	public byte FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xCEECD0", Offset = "0xCED6D0", VA = "0x180CEECD0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, byte HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xCEEC00", Offset = "0xCED600", VA = "0x180CEEC00", Slot = "7")]
	public byte DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x105F430", Offset = "0x105DE30", VA = "0x18105F430", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, byte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x105F2C0", Offset = "0x105DCC0", VA = "0x18105F2C0", Slot = "5")]
	public byte? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x105F330", Offset = "0x105DD30", VA = "0x18105F330", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, byte? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x105F1E0", Offset = "0x105DBE0", VA = "0x18105F1E0", Slot = "7")]
	public byte? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x173D730", Offset = "0x173C130", VA = "0x18173D730", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ushort HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x173D6E0", Offset = "0x173C0E0", VA = "0x18173D6E0", Slot = "5")]
	public ushort FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x173D6F0", Offset = "0x173C0F0", VA = "0x18173D6F0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ushort HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x173D670", Offset = "0x173C070", VA = "0x18173D670", Slot = "7")]
	public ushort DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1743870", Offset = "0x1742270", VA = "0x181743870", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ushort? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1743780", Offset = "0x1742180", VA = "0x181743780", Slot = "5")]
	public ushort? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x17437F0", Offset = "0x17421F0", VA = "0x1817437F0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ushort? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x17436E0", Offset = "0x17420E0", VA = "0x1817436E0", Slot = "7")]
	public ushort? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ushort[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xCEC120", Offset = "0xCEAB20", VA = "0x180CEC120", Slot = "5")]
	public ushort[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x17410D0", Offset = "0x173FAD0", VA = "0x1817410D0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, uint HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x1741080", Offset = "0x173FA80", VA = "0x181741080", Slot = "5")]
	public uint FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x1741090", Offset = "0x173FA90", VA = "0x181741090", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, uint HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x1741010", Offset = "0x173FA10", VA = "0x181741010", Slot = "7")]
	public uint DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCED110", Offset = "0xCEBB10", VA = "0x180CED110", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, uint? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xCECFE0", Offset = "0xCEB9E0", VA = "0x180CECFE0", Slot = "5")]
	public uint? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xCED090", Offset = "0xCEBA90", VA = "0x180CED090", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, uint? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xCECF40", Offset = "0xCEB940", VA = "0x180CECF40", Slot = "7")]
	public uint? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x104A870", Offset = "0x1049270", VA = "0x18104A870", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, uint[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x104A730", Offset = "0x1049130", VA = "0x18104A730", Slot = "5")]
	public uint[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCECA60", Offset = "0xCEB460", VA = "0x180CECA60", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ulong HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0xCECA10", Offset = "0xCEB410", VA = "0x180CECA10", Slot = "5")]
	public ulong FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xCECA20", Offset = "0xCEB420", VA = "0x180CECA20", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ulong HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xCEC9A0", Offset = "0xCEB3A0", VA = "0x180CEC9A0", Slot = "7")]
	public ulong DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x17442E0", Offset = "0x1742CE0", VA = "0x1817442E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ulong? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x17441D0", Offset = "0x1742BD0", VA = "0x1817441D0", Slot = "5")]
	public ulong? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1744260", Offset = "0x1742C60", VA = "0x181744260", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, ulong? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1744110", Offset = "0x1742B10", VA = "0x181744110", Slot = "7")]
	public ulong? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1058B60", Offset = "0x1057560", VA = "0x181058B60", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ulong[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1058A20", Offset = "0x1057420", VA = "0x181058A20", Slot = "5")]
	public ulong[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1056DA0", Offset = "0x10557A0", VA = "0x181056DA0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, float HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1056CE0", Offset = "0x10556E0", VA = "0x181056CE0", Slot = "5")]
	public float FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x1056CF0", Offset = "0x10556F0", VA = "0x181056CF0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, float HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x1056C40", Offset = "0x1055640", VA = "0x181056C40", Slot = "7")]
	public float DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x10581C0", Offset = "0x1056BC0", VA = "0x1810581C0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, float? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1058060", Offset = "0x1056A60", VA = "0x181058060", Slot = "5")]
	public float? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x10580D0", Offset = "0x1056AD0", VA = "0x1810580D0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, float? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1057F80", Offset = "0x1056980", VA = "0x181057F80", Slot = "7")]
	public float? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCECC80", Offset = "0xCEB680", VA = "0x180CECC80", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, float[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xCECAE0", Offset = "0xCEB4E0", VA = "0x180CECAE0", Slot = "5")]
	public float[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEB3F0", Offset = "0xCE9DF0", VA = "0x180CEB3F0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, double HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xCEB3A0", Offset = "0xCE9DA0", VA = "0x180CEB3A0", Slot = "5")]
	public double FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xCEB3B0", Offset = "0xCE9DB0", VA = "0x180CEB3B0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, double HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xCEB330", Offset = "0xCE9D30", VA = "0x180CEB330", Slot = "7")]
	public double DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x10602D0", Offset = "0x105ECD0", VA = "0x1810602D0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, double? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1060140", Offset = "0x105EB40", VA = "0x181060140", Slot = "5")]
	public double? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x10601D0", Offset = "0x105EBD0", VA = "0x1810601D0", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, double? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1060030", Offset = "0x105EA30", VA = "0x181060030", Slot = "7")]
	public double? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEB000", Offset = "0xCE9A00", VA = "0x180CEB000", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, double[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xCEAE60", Offset = "0xCE9860", VA = "0x180CEAE60", Slot = "5")]
	public double[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x105FDE0", Offset = "0x105E7E0", VA = "0x18105FDE0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, bool HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x105FD20", Offset = "0x105E720", VA = "0x18105FD20", Slot = "5")]
	public bool FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x105FD30", Offset = "0x105E730", VA = "0x18105FD30", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, bool HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x105FCB0", Offset = "0x105E6B0", VA = "0x18105FCB0", Slot = "7")]
	public bool DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCE06F0", Offset = "0xCDF0F0", VA = "0x180CE06F0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, bool? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xCE0600", Offset = "0xCDF000", VA = "0x180CE0600", Slot = "5")]
	public bool? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xCE0670", Offset = "0xCDF070", VA = "0x180CE0670", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, bool? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xCE0550", Offset = "0xCDEF50", VA = "0x180CE0550", Slot = "7")]
	public bool? DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEFC80", Offset = "0xCEE680", VA = "0x180CEFC80", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, bool[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xCEFAE0", Offset = "0xCEE4E0", VA = "0x180CEFAE0", Slot = "5")]
	public bool[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1060640", Offset = "0x105F040", VA = "0x181060640", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, object HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x10603A0", Offset = "0x105EDA0", VA = "0x1810603A0", Slot = "5")]
	public object FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x104AE70", Offset = "0x1049870", VA = "0x18104AE70", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, byte[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x104ADF0", Offset = "0x10497F0", VA = "0x18104ADF0", Slot = "5")]
	public byte[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x105FF30", Offset = "0x105E930", VA = "0x18105FF30", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, ArraySegment<byte> HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x105FE60", Offset = "0x105E860", VA = "0x18105FE60", Slot = "5")]
	public ArraySegment<byte> FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEF230", Offset = "0xCEDC30", VA = "0x180CEF230", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, string HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xCEF220", Offset = "0xCEDC20", VA = "0x180CEF220", Slot = "5")]
	public string FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xCEF230", Offset = "0xCEDC30", VA = "0x180CEF230", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, string HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xCEF220", Offset = "0xCEDC20", VA = "0x180CEF220", Slot = "7")]
	public string DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1743130", Offset = "0x1741B30", VA = "0x181743130", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, string[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1742FF0", Offset = "0x17419F0", VA = "0x181742FF0", Slot = "5")]
	public string[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEC410", Offset = "0xCEAE10", VA = "0x180CEC410", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, char HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xCEC3E0", Offset = "0xCEADE0", VA = "0x180CEC3E0", Slot = "5")]
	public char FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEFED0", Offset = "0xCEE8D0", VA = "0x180CEFED0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, char? HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xCEFE10", Offset = "0xCEE810", VA = "0x180CEFE10", Slot = "5")]
	public char? FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x105B980", Offset = "0x105A380", VA = "0x18105B980", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, char[] HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x105B7E0", Offset = "0x105A1E0", VA = "0x18105B7E0", Slot = "5")]
	public char[] FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Guid HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x104ABB0", Offset = "0x10495B0", VA = "0x18104ABB0", Slot = "5")]
	public Guid FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00", Slot = "6")]
	public void GOMFLPCEIHD(ref FBIFMPDMBBF HBKAOCMIABB, Guid HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x104AB60", Offset = "0x1049560", VA = "0x18104AB60", Slot = "7")]
	public Guid DGJILFONCPC(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x80DAC0", Offset = "0x80C4C0", VA = "0x18080DAC0")]
	public MKOCCEIICLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x80DA90", Offset = "0x80C490", VA = "0x18080DA90")]
	public MKOCCEIICLG(bool NNKEPLJPLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xCEF940", Offset = "0xCEE340", VA = "0x180CEF940", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, decimal HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xCEF790", Offset = "0xCEE190", VA = "0x180CEF790", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x17425E0", Offset = "0x1740FE0", VA = "0x1817425E0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Uri HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1742560", Offset = "0x1740F60", VA = "0x181742560", Slot = "5")]
	public Uri FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEE960", Offset = "0xCED360", VA = "0x180CEE960", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Version HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0xCEE8E0", Offset = "0xCED2E0", VA = "0x180CEE8E0", Slot = "5")]
	public Version FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x17411C0", Offset = "0x173FBC0", VA = "0x1817411C0", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, StringBuilder HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1741140", Offset = "0x173FB40", VA = "0x181741140", Slot = "5")]
	public StringBuilder FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEE570", Offset = "0xCECF70", VA = "0x180CEE570", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, BitArray HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xCEE410", Offset = "0xCECE10", VA = "0x180CEE410", Slot = "5")]
	public BitArray FIPMLAIPHOG(ref NHAPBMMNKAC GFDHAJPOBIG, CGDCFJDMLCL JJBMBBFGFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
	[Cpp2IlInjected.Address(RVA = "0x17449F0", Offset = "0x17433F0", VA = "0x1817449F0")]
	public PMLKJLBBIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1744A10", Offset = "0x1743410", VA = "0x181744A10")]
	public PMLKJLBBIFJ(bool ECENLCFHCIB, bool FJFDLOJGLFD, bool FCMLOPJBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x1744860", Offset = "0x1743260", VA = "0x181744860", Slot = "4")]
	public void NGLMBPACFDH(ref FBIFMPDMBBF HBKAOCMIABB, Type HPIAFNBPEPC, CGDCFJDMLCL JJBMBBFGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1744740", Offset = "0x1743140", VA = "0x181744740", Slot = "5")]
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
