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
internal static class NKHJABGPPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50B7EF0", Offset = "0x50B70F0", VA = "0x1850B7EF0")]
	public static bool HIGKPHKCGLN(this TypeInfo DDJDPMGLPAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class NBGEKOJNFMP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FOJKPCKJJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] HLIGJGOJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E26F0", Offset = "0x6E18F0", VA = "0x1806E26F0")]
	public NBGEKOJNFMP(Type DDIMAINKNPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class MOKMFMMAACF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OAMKLMHLDAO<T>(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T GHBJCJPAPDG<T>(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM DJEEIHBJAEH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PKHFALLONLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JJBJICJFEAB<T> : PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HHJPHCMFBDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MJAPBCCONDF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JJBJICJFEAB<T> KBHEOONAKKF<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EODNFNDKFAH
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1120", Offset = "0x1FA0320", VA = "0x181FA1120")]
	public static global::JJBJICJFEAB<T> JKKABMNHFOB<T>(this LMDOKLNJEDM DJEEIHBJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50EF8C0", Offset = "0x50EEAC0", VA = "0x1850EF8C0")]
	public static object IMDMONNEPMJ(this LMDOKLNJEDM DJEEIHBJAEH, Type DDJDPMGLPAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ECKKNAHKKFE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50EDEF0", Offset = "0x50ED0F0", VA = "0x1850EDEF0")]
	public ECKKNAHKKFE(string DENPJAMCNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IIHLGBHCEFK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class HKGKDCNDHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] IEGPGBKLAIF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] NJDJFFPDPOJ;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50ADD40", Offset = "0x50ACF40", VA = "0x1850ADD40")]
		public static byte[] KEFCAMGPPIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x50ADDD0", Offset = "0x50ACFD0", VA = "0x1850ADDD0")]
		public static char[] MPCNFDHMFHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> NPKDIIACGGF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] JAMODGFIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] NPNCGJAPKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int ELOEOOGBENM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HGJAJEDKLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x50F7330", Offset = "0x50F6530", VA = "0x1850F7330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50FA050", Offset = "0x50F9250", VA = "0x1850FA050")]
	public IIHLGBHCEFK(byte[] NPNCGJAPKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50F9E60", Offset = "0x50F9060", VA = "0x1850F9E60")]
	public IIHLGBHCEFK(byte[] NPNCGJAPKIL, int ELOEOOGBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x50F7F30", Offset = "0x50F7130", VA = "0x1850F7F30")]
	private DDDHLGJGIPK EHDHNEPKGBD(string FLGDGHMLIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x50F7250", Offset = "0x50F6450", VA = "0x1850F7250")]
	private DDDHLGJGIPK AADMHDLOAIM(string DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50F98F0", Offset = "0x50F8AF0", VA = "0x1850F98F0")]
	public void OMBGEHEAHCE(int ELOEOOGBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7000", Offset = "0x6C6200", VA = "0x1806C7000")]
	public byte[] KLPLGLNNPPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EE0", Offset = "0x7E70E0", VA = "0x1807E7EE0")]
	public int MEBEJPMCNCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50F8C90", Offset = "0x50F7E90", VA = "0x1850F8C90")]
	public EABIEKKHOKH IOKLJOILONI()
	{
		return default(EABIEKKHOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50F9770", Offset = "0x50F8970", VA = "0x1850F9770")]
	public void OFFDGEIHBPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50F9670", Offset = "0x50F8870", VA = "0x1850F9670")]
	public bool OENNKEHNOHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50F7CE0", Offset = "0x50F6EE0", VA = "0x1850F7CE0")]
	public bool APPHCLBMDLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50F8FC0", Offset = "0x50F81C0", VA = "0x1850F8FC0")]
	public void JOLBCKGMDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50F9B10", Offset = "0x50F8D10", VA = "0x1850F9B10")]
	public bool PLLMKBHLFHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50F7D40", Offset = "0x50F6F40", VA = "0x1850F7D40")]
	public bool BHNNJJCFJOK(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50F8940", Offset = "0x50F7B40", VA = "0x1850F8940")]
	public bool IFBKOJHKEBO(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50F94D0", Offset = "0x50F86D0", VA = "0x1850F94D0")]
	public bool NODBDAJNMDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x50F8850", Offset = "0x50F7A50", VA = "0x1850F8850")]
	public void IAMCIJEPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x50F87F0", Offset = "0x50F79F0", VA = "0x1850F87F0")]
	public bool HNGBAMMKCHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x50F7EB0", Offset = "0x50F70B0", VA = "0x1850F7EB0")]
	public bool DAOGMJHNMME(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x50F9530", Offset = "0x50F8730", VA = "0x1850F9530")]
	public bool OABCFHPEOOP(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x50F9470", Offset = "0x50F8670", VA = "0x1850F9470")]
	public bool NCHPDJIFNOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x50F93E0", Offset = "0x50F85E0", VA = "0x1850F93E0")]
	public void NCHILOPHPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x50F88E0", Offset = "0x50F7AE0", VA = "0x1850F88E0")]
	public bool IBMMJKCLFJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x50F7DC0", Offset = "0x50F6FC0", VA = "0x1850F7DC0")]
	public void BMJMBDKCHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x50F7350", Offset = "0x50F6550", VA = "0x1850F7350")]
	private void AALJCCDKEBE(out byte[] DMECDOCBFOA, out int MJJPMFFLOAP, out int BKDGLKKIHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x50F8BE0", Offset = "0x50F7DE0", VA = "0x1850F8BE0")]
	private static int IMCCCAEKBFB(char FAMKPEGNHFC, char GPHMIGDKMEO, char ECKJDAFJMBK, char ABLKMJLKIKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x50F9960", Offset = "0x50F8B60", VA = "0x1850F9960")]
	private static int PBIJKHHJMOF(char BIAIPPDLOMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x50F9050", Offset = "0x50F8250", VA = "0x1850F9050")]
	public ArraySegment<byte> KKGEDMAMDPJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50F9280", Offset = "0x50F8480", VA = "0x1850F9280")]
	public string MFNACELPBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x50F8580", Offset = "0x50F7780", VA = "0x1850F8580")]
	public string GEGGDNGDHHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x50F7B10", Offset = "0x50F6D10", VA = "0x1850F7B10")]
	public ArraySegment<byte> AGBJCEPHKML()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x50F98B0", Offset = "0x50F8AB0", VA = "0x1850F98B0")]
	public ArraySegment<byte> OILIJOBAPPD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x50F85B0", Offset = "0x50F77B0", VA = "0x1850F85B0")]
	public bool GMOMCJKEIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x50F9320", Offset = "0x50F8520", VA = "0x1850F9320")]
	private static bool MOEAHFHHDPC(byte ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x50F8A00", Offset = "0x50F7C00", VA = "0x1850F8A00")]
	private void IJEPLKIGILM(EABIEKKHOKH AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x50F9A30", Offset = "0x50F8C30", VA = "0x1850F9A30")]
	public void PGBKNAGAPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x50F9A40", Offset = "0x50F8C40", VA = "0x1850F9A40")]
	private void PKOJAEHNCKN(int NJODGODMJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50F8440", Offset = "0x50F7640", VA = "0x1850F8440")]
	public sbyte FIPNAOJLBAE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50F9D00", Offset = "0x50F8F00", VA = "0x1850F9D00")]
	public short PPNOBAEHOGF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x50F8F60", Offset = "0x50F8160", VA = "0x1850F8F60")]
	public int JOEICHNIDGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50F95F0", Offset = "0x50F87F0", VA = "0x1850F95F0")]
	public long OBFBHKKJEIH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x50F9900", Offset = "0x50F8B00", VA = "0x1850F9900")]
	public byte ONKDCBDEKBB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x50F9150", Offset = "0x50F8350", VA = "0x1850F9150")]
	public ushort KPFMCNLJDOG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x50F7E50", Offset = "0x50F7050", VA = "0x1850F7E50")]
	public uint CCNDEEDCGBF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x50F8EE0", Offset = "0x50F80E0", VA = "0x1850F8EE0")]
	public ulong JGECLHMFKKD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x50F91B0", Offset = "0x50F83B0", VA = "0x1850F91B0")]
	public float MEOBEEKJDLP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x50F8E10", Offset = "0x50F8010", VA = "0x1850F8E10")]
	public double JAJFEMDKJEL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50F8490", Offset = "0x50F7690", VA = "0x1850F8490")]
	public ArraySegment<byte> FMLPEJMBEMC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x50F9B70", Offset = "0x50F8D70", VA = "0x1850F9B70")]
	private static int PPIOAPNJNLK(byte[] NPNCGJAPKIL, int ELOEOOGBENM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DDDHLGJGIPK : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference JNGHNGAMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int CNLNDOIJPGP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OHFGBAEJNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x10891B0", Offset = "0x10883B0", VA = "0x1810891B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string BJEFLEFGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D1530", Offset = "0x8D0730", VA = "0x1808D1530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50ED1D0", Offset = "0x50EC3D0", VA = "0x1850ED1D0")]
	public DDDHLGJGIPK(string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50ED240", Offset = "0x50EC440", VA = "0x1850ED240")]
	public DDDHLGJGIPK(string DENPJAMCNLD, byte[] LGDILDGDFHJ, int ELOEOOGBENM, int CNLNDOIJPGP, string LFFIDKNALCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PDJDGHMCEGM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class IDNBDILLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void OOBKDLIAGKF(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object EDBBPEHKGAJ(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM DJEEIHBJAEH);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class LEAONMPIBHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class PMHJLONLEFL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
				public PMHJLONLEFL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x38CECF0", Offset = "0x38CDEF0", VA = "0x1838CECF0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x50BF750", Offset = "0x50BE950", VA = "0x1850BF750")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, LMDOKLNJEDM, byte[]> MBGCPEIKAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, LMDOKLNJEDM> AJGMNNLBEEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly OOBKDLIAGKF PCOEDAMOCEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, LMDOKLNJEDM, ArraySegment<byte>> KBEGLJHLAJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, LMDOKLNJEDM, string> MIONHJHGHMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, LMDOKLNJEDM, object> PMDINIFEIDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, LMDOKLNJEDM, object> IHMDDAKOBGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, LMDOKLNJEDM, object> HEBKLEBNKAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly EDBBPEHKGAJ CBCGAPECKMK;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x50B09C0", Offset = "0x50AFBC0", VA = "0x1850B09C0")]
			public LEAONMPIBHM(Type DDJDPMGLPAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4DCD170", Offset = "0x4DCC370", VA = "0x184DCD170")]
			private static T CBGAIIHMAKM<T>(DynamicMethod KPAOPOLLNLJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x50B0770", Offset = "0x50AF970", VA = "0x1850B0770")]
			private static MethodInfo NAIDJNEIALI(Type DDJDPMGLPAE, string IGHJIHNAPBA, Type[] KELIOEGMIDH)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, LEAONMPIBHM> OGAOFDJMING;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::MEEGMHDFAGF<LEAONMPIBHM> EDPCIMAGBKE;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50AE8B0", Offset = "0x50ADAB0", VA = "0x1850AE8B0")]
		static IDNBDILLPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50AE820", Offset = "0x50ADA20", VA = "0x1850AE820")]
		private static LEAONMPIBHM MGNJLCPLAEP(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50AE690", Offset = "0x50AD890", VA = "0x1850AE690")]
		public static void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x50AE570", Offset = "0x50AD770", VA = "0x1850AE570")]
		public static void LMGAKHPBOLH(Type DDJDPMGLPAE, ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PCJJAINMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] IEGPGBKLAIF;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x50BC830", Offset = "0x50BBA30", VA = "0x1850BC830")]
		public static byte[] KEFCAMGPPIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LMDOKLNJEDM CDOAOOOLENC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] OCLDCFMHHBO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] CJFLJCJNHNA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LMDOKLNJEDM CMDIKFICKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50BCB20", Offset = "0x50BBD20", VA = "0x1850BCB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EIOIMMEOHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x50BCC40", Offset = "0x50BBE40", VA = "0x1850BCC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x50BD190", Offset = "0x50BC390", VA = "0x1850BD190")]
	public static void LHKNFGOEGMB(LMDOKLNJEDM DJEEIHBJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29B4690", Offset = "0x29B3890", VA = "0x1829B4690")]
	public static byte[] LMGAKHPBOLH<T>(T ADHHHFDPAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29B47A0", Offset = "0x29B39A0", VA = "0x1829B47A0")]
	public static byte[] LMGAKHPBOLH<T>(T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29B4710", Offset = "0x29B3910", VA = "0x1829B4710")]
	public static void LMGAKHPBOLH<T>(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29B4520", Offset = "0x29B3720", VA = "0x1829B4520")]
	public static void LMGAKHPBOLH<T>(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29B4600", Offset = "0x29B3800", VA = "0x1829B4600")]
	public static void LMGAKHPBOLH<T>(Stream DMEDBCCHBBH, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29B4900", Offset = "0x29B3B00", VA = "0x1829B4900")]
	public static void LMGAKHPBOLH<T>(Stream DMEDBCCHBBH, T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29B42A0", Offset = "0x29B34A0", VA = "0x1829B42A0")]
	public static ArraySegment<byte> ADKFONHNOJE<T>(T ADHHHFDPAPI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29B4120", Offset = "0x29B3320", VA = "0x1829B4120")]
	public static ArraySegment<byte> ADKFONHNOJE<T>(T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29B44A0", Offset = "0x29B36A0", VA = "0x1829B44A0")]
	public static string JDNBDBAHEAJ<T>(T JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29B4340", Offset = "0x29B3540", VA = "0x1829B4340")]
	public static string JDNBDBAHEAJ<T>(T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29B5380", Offset = "0x29B4580", VA = "0x1829B5380")]
	public static T LPJEJNEGJFP<T>(string DPDEOLBHJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29B5620", Offset = "0x29B4820", VA = "0x1829B5620")]
	public static T LPJEJNEGJFP<T>(string DPDEOLBHJMF, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29B5DC0", Offset = "0x29B4FC0", VA = "0x1829B5DC0")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29B5420", Offset = "0x29B4620", VA = "0x1829B5420")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29B5CB0", Offset = "0x29B4EB0", VA = "0x1829B5CB0")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL, int ELOEOOGBENM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29B54C0", Offset = "0x29B46C0", VA = "0x1829B54C0")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL, int ELOEOOGBENM, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29B5710", Offset = "0x29B4910", VA = "0x1829B5710")]
	public static T LPJEJNEGJFP<T>(ref IIHLGBHCEFK OJMODHIKFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29B5A00", Offset = "0x29B4C00", VA = "0x1829B5A00")]
	public static T LPJEJNEGJFP<T>(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29B5D40", Offset = "0x29B4F40", VA = "0x1829B5D40")]
	public static T LPJEJNEGJFP<T>(Stream DMEDBCCHBBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29B58D0", Offset = "0x29B4AD0", VA = "0x1829B58D0")]
	public static T LPJEJNEGJFP<T>(Stream DMEDBCCHBBH, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x50BC970", Offset = "0x50BBB70", VA = "0x1850BC970")]
	public static string FJEFJHBAMFH(byte[] DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x50BC8C0", Offset = "0x50BBAC0", VA = "0x1850BC8C0")]
	public static string FJEFJHBAMFH(byte[] DPDEOLBHJMF, int ELOEOOGBENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x50BCA50", Offset = "0x50BBC50", VA = "0x1850BCA50")]
	public static string FJEFJHBAMFH(string DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x50BD380", Offset = "0x50BC580", VA = "0x1850BD380")]
	public static byte[] MPAFANNNBKE(byte[] DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x50BD2D0", Offset = "0x50BC4D0", VA = "0x1850BD2D0")]
	public static byte[] MPAFANNNBKE(byte[] DPDEOLBHJMF, int ELOEOOGBENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x50BD200", Offset = "0x50BC400", VA = "0x1850BD200")]
	public static byte[] MPAFANNNBKE(string DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x50BCCA0", Offset = "0x50BBEA0", VA = "0x1850BCCA0")]
	private static void KLBIDFFMBIG(ref IIHLGBHCEFK OJMODHIKFDB, ref AOONEBAFBIP ABIHDCBCABG, int ELMCLGINMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50BD460", Offset = "0x50BC660", VA = "0x1850BD460")]
	private static int NHJOIEEHGEF(Stream ADKJIBICKCJ, ref byte[] IEGPGBKLAIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EABIEKKHOKH : byte
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
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AOONEBAFBIP
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] OAKBPHBEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] IEGPGBKLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int ELOEOOGBENM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DBLHLMGCOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E7EE0", Offset = "0x7E70E0", VA = "0x1807E7EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50F98F0", Offset = "0x50F8AF0", VA = "0x1850F98F0")]
	public void OMBGEHEAHCE(int ELOEOOGBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53C9730", Offset = "0x53C8930", VA = "0x1853C9730")]
	public static byte[] CILKCABILHO(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53C9FF0", Offset = "0x53C91F0", VA = "0x1853C9FF0")]
	public static byte[] GEHFMKHEJKD(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53CA7A0", Offset = "0x53C99A0", VA = "0x1853CA7A0")]
	public static byte[] OLKEDCLKGMA(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53C95E0", Offset = "0x53C87E0", VA = "0x1853C95E0")]
	public static byte[] CHIEKEPLGIF(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC13020", Offset = "0xC12220", VA = "0x180C13020")]
	public AOONEBAFBIP(byte[] DMCBJMIIPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53CA530", Offset = "0x53C9730", VA = "0x1853CA530")]
	public ArraySegment<byte> KEFCAMGPPIP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53C9E70", Offset = "0x53C9070", VA = "0x1853C9E70")]
	public byte[] FMPEIHMNPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53CA870", Offset = "0x53C9A70", VA = "0x1853CA870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53C95D0", Offset = "0x53C87D0", VA = "0x1853C95D0")]
	public void CDEPEGAJOEL(int FOFPICKAACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x50F2210", Offset = "0x50F1410", VA = "0x1850F2210")]
	public void MEEBNDLECPG(byte EMFLPIECMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x53CA650", Offset = "0x53C9850", VA = "0x1853CA650")]
	public void MEEBNDLECPG(byte[] EMFLPIECMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x53CA5E0", Offset = "0x53C97E0", VA = "0x1853CA5E0")]
	public void KNMFHJPAGGJ(byte EMFLPIECMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x53CA6B0", Offset = "0x53C98B0", VA = "0x1853CA6B0")]
	public void MLBMNAECGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x53CA700", Offset = "0x53C9900", VA = "0x1853CA700")]
	public void OAOALKIDMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x53CA0C0", Offset = "0x53C92C0", VA = "0x1853CA0C0")]
	public void GKOKBMLMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53CA460", Offset = "0x53C9660", VA = "0x1853CA460")]
	public void HJJIMCFBGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53CA4E0", Offset = "0x53C96E0", VA = "0x1853CA4E0")]
	public void IEJFPCEEBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x53CA750", Offset = "0x53C9950", VA = "0x1853CA750")]
	public void OBOHBNMOPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x53C9510", Offset = "0x53C8710", VA = "0x1853C9510")]
	public void BGAOMDMDFBF(string CGCMEEFENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x53C94C0", Offset = "0x53C86C0", VA = "0x1853C94C0")]
	public void APGDJKLJEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x53C9B80", Offset = "0x53C8D80", VA = "0x1853C9B80")]
	public void DDBFLPANBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x53CA110", Offset = "0x53C9310", VA = "0x1853CA110")]
	public void HCGDOHHCAGB(bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x53C9C50", Offset = "0x53C8E50", VA = "0x1853C9C50")]
	public void EAHOCMPJEFK(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53CA300", Offset = "0x53C9500", VA = "0x1853CA300")]
	public void HFKADKJMAIP(double JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x53C9E10", Offset = "0x53C9010", VA = "0x1853C9E10")]
	public void ENAMEOIMMOC(byte JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x53CA4B0", Offset = "0x53C96B0", VA = "0x1853CA4B0")]
	public void HONMCHEHIBJ(ushort JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x53CA620", Offset = "0x53C9820", VA = "0x1853CA620")]
	public void LGABPNGKMIB(uint JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x53C9E40", Offset = "0x53C9040", VA = "0x1853C9E40")]
	public void EOACNFMILOI(ulong JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x53C9DE0", Offset = "0x53C8FE0", VA = "0x1853C9DE0")]
	public void EIHMEBDFIBI(sbyte JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x53C95A0", Offset = "0x53C87A0", VA = "0x1853C95A0")]
	public void BNLEDADNHMF(short JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53C9DB0", Offset = "0x53C8FB0", VA = "0x1853C9DB0")]
	public void EEGBMNFDCNO(int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x53C9570", Offset = "0x53C8770", VA = "0x1853C9570")]
	public void BMDFCIEFFAP(long JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x53C97B0", Offset = "0x53C89B0", VA = "0x1853C97B0")]
	public void CKAOPLADLCD(string JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HNDDKADFLOP : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class ONCJFEJCONL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2652350", Offset = "0x2651550", VA = "0x182652350")]
		static ONCJFEJCONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private HNDDKADFLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class ALBALIHJIPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> FDJOGCMPPMN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x53C6E90", Offset = "0x53C6090", VA = "0x1853C6E90")]
	static ALBALIHJIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x53C6780", Offset = "0x53C5980", VA = "0x1853C6780")]
	internal static object KBHEOONAKKF(Type EHIBGNPGILO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HLKGIDMKGPI : global::JJBJICJFEAB<Vector2>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x50F6280", Offset = "0x50F5480", VA = "0x1850F6280")]
	public HLKGIDMKGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x50F5EF0", Offset = "0x50F50F0", VA = "0x1850F5EF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Vector2 JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x50F5FA0", Offset = "0x50F51A0", VA = "0x1850F5FA0", Slot = "5")]
	public Vector2 LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GLLBOMONOPJ : global::JJBJICJFEAB<Vector3>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x50F39E0", Offset = "0x50F2BE0", VA = "0x1850F39E0")]
	public GLLBOMONOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x50F35A0", Offset = "0x50F27A0", VA = "0x1850F35A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Vector3 JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x50F36C0", Offset = "0x50F28C0", VA = "0x1850F36C0", Slot = "5")]
	public Vector3 LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MOFEGGKPOMM : global::JJBJICJFEAB<Vector4>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x50B5B40", Offset = "0x50B4D40", VA = "0x1850B5B40")]
	public MOFEGGKPOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x50B57D0", Offset = "0x50B49D0", VA = "0x1850B57D0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Vector4 JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x50B5920", Offset = "0x50B4B20", VA = "0x1850B5920", Slot = "5")]
	public Vector4 LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class GAJFIABHHFO : global::JJBJICJFEAB<Quaternion>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x50F2790", Offset = "0x50F1990", VA = "0x1850F2790")]
	public GAJFIABHHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x50B57D0", Offset = "0x50B49D0", VA = "0x1850B57D0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Quaternion JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x50F2410", Offset = "0x50F1610", VA = "0x1850F2410", Slot = "5")]
	public Quaternion LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CPDKALIDKNO : global::JJBJICJFEAB<Color>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x53DDC50", Offset = "0x53DCE50", VA = "0x1853DDC50")]
	public CPDKALIDKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53DD750", Offset = "0x53DC950", VA = "0x1853DD750", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Color JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53DD9C0", Offset = "0x53DCBC0", VA = "0x1853DD9C0", Slot = "5")]
	public Color LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class KALJOACFPIC : global::JJBJICJFEAB<Bounds>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x50FF6D0", Offset = "0x50FE8D0", VA = "0x1850FF6D0")]
	public KALJOACFPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x50FF110", Offset = "0x50FE310", VA = "0x1850FF110", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Bounds JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x50FF2B0", Offset = "0x50FE4B0", VA = "0x1850FF2B0", Slot = "5")]
	public Bounds LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EOKMHGDAPKA : global::JJBJICJFEAB<Rect>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CNJAGIAHCJK NAEOBDPCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] KIHGJODFNAN;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x50EFF50", Offset = "0x50EF150", VA = "0x1850EFF50")]
	public EOKMHGDAPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50EFA30", Offset = "0x50EEC30", VA = "0x1850EFA30", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Rect JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50EFBA0", Offset = "0x50EEDA0", VA = "0x1850EFBA0", Slot = "5")]
	public Rect LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GCPLKGGAAIG : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class JEEPPJJAFAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x30D44F0", Offset = "0x30D36F0", VA = "0x1830D44F0")]
		static JEEPPJJAFAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private GCPLKGGAAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class POIGPLFBPJP : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class MNCCGNJBNBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E71B40", Offset = "0x2E70D40", VA = "0x182E71B40")]
		static MNCCGNJBNBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class PJDFALFIHNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> AAMNBFLJDMM;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x50BD680", Offset = "0x50BC880", VA = "0x1850BD680")]
		internal static object KBHEOONAKKF(Type EHIBGNPGILO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private POIGPLFBPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class KEPJHCFABAH : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class JPOMJNDILIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8190", Offset = "0x2DA7390", VA = "0x182DA8190")]
		static JPOMJNDILIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KEPJHCFABAH HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool OHAIEKPMKIM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static PKHFALLONLG[] OBHMMLKHJPD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static LMDOKLNJEDM[] OAIPJKBMKPC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private KEPJHCFABAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5100190", Offset = "0x50FF390", VA = "0x185100190")]
	public static void KJDPCLCGNLB(params LMDOKLNJEDM[] OAIPJKBMKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x51000B0", Offset = "0x50FF2B0", VA = "0x1851000B0")]
	public static void KJDPCLCGNLB(params PKHFALLONLG[] OBHMMLKHJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x50FFE20", Offset = "0x50FF020", VA = "0x1850FFE20")]
	public static void HBLIGLACKKF(PKHFALLONLG[] OBHMMLKHJPD, LMDOKLNJEDM[] OAIPJKBMKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class NCLJFPPOPGJ : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class HBOEEOAHEMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDC80", Offset = "0x3BFCE80", VA = "0x183BFDC80")]
		static HBOEEOAHEMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private NCLJFPPOPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KOENJCKHCDM
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LMDOKLNJEDM HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly LMDOKLNJEDM KMFEEJNCHIO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly LMDOKLNJEDM DMELPNPAEEP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LMDOKLNJEDM BMLMHGLBOEB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly LMDOKLNJEDM BPFIELCLLIH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly LMDOKLNJEDM DFJPHOHLDFD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly LMDOKLNJEDM GNOLFNBOMAI;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly LMDOKLNJEDM GBNELLBNLAF;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly LMDOKLNJEDM PFOEKJPKCHE;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly LMDOKLNJEDM LIKHIGBJEIE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly LMDOKLNJEDM LDMHGLGNGKK;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly LMDOKLNJEDM GKFLNFAOMGH;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EGKEIHPGOCC
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly LMDOKLNJEDM HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LMDOKLNJEDM FCIFMMHFACE;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ELMAHAFNAFE
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly LMDOKLNJEDM HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly LMDOKLNJEDM KMFEEJNCHIO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LMDOKLNJEDM DMELPNPAEEP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly LMDOKLNJEDM BMLMHGLBOEB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly LMDOKLNJEDM BPFIELCLLIH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly LMDOKLNJEDM DFJPHOHLDFD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly LMDOKLNJEDM GNOLFNBOMAI;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly LMDOKLNJEDM GBNELLBNLAF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly LMDOKLNJEDM PFOEKJPKCHE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly LMDOKLNJEDM LIKHIGBJEIE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly LMDOKLNJEDM LDMHGLGNGKK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly LMDOKLNJEDM GKFLNFAOMGH;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class OMOJKPKAKJA
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> AAMNBFLJDMM;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x50B9CE0", Offset = "0x50B8EE0", VA = "0x1850B9CE0")]
	internal static object KBHEOONAKKF(Type EHIBGNPGILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x50B9CA0", Offset = "0x50B8EA0", VA = "0x1850B9CA0")]
	private static object GMHLJDAKGDI(Type IDEHHLECMGB, Type[] LDKIIFAOFPL, params object[] KELIOEGMIDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MBADNGFAKOC : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class GABMODEENGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4550", Offset = "0x3CF3750", VA = "0x183CF4550")]
		static GABMODEENGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly DDELIMNFFNE LEMGPPEGBPI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5103A10", Offset = "0x5102C10", VA = "0x185103A10")]
	static MBADNGFAKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private MBADNGFAKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KCOKIMNAGBO : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class LNMLFLICDBN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC820", Offset = "0x3CBBA20", VA = "0x183CBC820")]
		static LNMLFLICDBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly DDELIMNFFNE LEMGPPEGBPI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x50FF8D0", Offset = "0x50FEAD0", VA = "0x1850FF8D0")]
	static KCOKIMNAGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private KCOKIMNAGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class ABCDLMKCLKA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class AANALNBEONP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x33E62A0", Offset = "0x33E54A0", VA = "0x1833E62A0")]
		static AANALNBEONP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly DDELIMNFFNE LEMGPPEGBPI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x53C6250", Offset = "0x53C5450", VA = "0x1853C6250")]
	static ABCDLMKCLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private ABCDLMKCLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CEPMDPJNBLA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class OGGBMKFCCDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3821E50", Offset = "0x3821050", VA = "0x183821E50")]
		static OGGBMKFCCDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly DDELIMNFFNE LEMGPPEGBPI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x53DA030", Offset = "0x53D9230", VA = "0x1853DA030")]
	static CEPMDPJNBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private CEPMDPJNBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class CPHBLFFEGAF : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class MNOOKLBALGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E743B0", Offset = "0x2E735B0", VA = "0x182E743B0")]
		static MNOOKLBALGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly DDELIMNFFNE LEMGPPEGBPI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x50ED0A0", Offset = "0x50EC2A0", VA = "0x1850ED0A0")]
	static CPHBLFFEGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private CPHBLFFEGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JLEIMCHDBML : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class LDJFALCIMAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x35E9BE0", Offset = "0x35E8DE0", VA = "0x1835E9BE0")]
		static LDJFALCIMAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly DDELIMNFFNE LEMGPPEGBPI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x50FC590", Offset = "0x50FB790", VA = "0x1850FC590")]
	static JLEIMCHDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private JLEIMCHDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class HDHLKKOIMFP : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class NBFDLOFOKFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B170", Offset = "0x2B5A370", VA = "0x182B5B170")]
		static NBFDLOFOKFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HDHLKKOIMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class PPKCEOCLKFD : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class FGADMFKLILO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x23A2500", Offset = "0x23A1700", VA = "0x1823A2500")]
		static FGADMFKLILO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public PPKCEOCLKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MNKGIJPDBFI : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class OEHCNLFNIIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3817810", Offset = "0x3816A10", VA = "0x183817810")]
		static OEHCNLFNIIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MNKGIJPDBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class ANIBOOGCBBL : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class CJCAPHAAKDB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B00A50", Offset = "0x2AFFC50", VA = "0x182B00A50")]
		static CJCAPHAAKDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ANIBOOGCBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class CCBJBHFJKEN : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class PFACGPGADMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3295C60", Offset = "0x3294E60", VA = "0x183295C60")]
		static PFACGPGADMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CCBJBHFJKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class JAMEBPCDLHA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class AIOFOEPPKOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DC00", Offset = "0x2A3CE00", VA = "0x182A3DC00")]
		static AIOFOEPPKOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> DFDPGCBCJMD;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool LELPBDCIGFG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JAMEBPCDLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class BKODNKEOIDJ
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct DIEBJMOGHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BJHIALAFHDM ECIFDNILPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder IGNENLOBENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PNEPIABLBJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class LHNNNGFLCPL
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class KMFGIPKMBPM
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo OLKEDCLKGMA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo GEHFMKHEJKD;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo CHIEKEPLGIF;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo CILKCABILHO;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo DDBFLPANBPI;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo MEEBNDLECPG;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo GKOKBMLMJGM;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo HJJIMCFBGDJ;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo IEJFPCEEBAL;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x50AF560", Offset = "0x50AE760", VA = "0x1850AF560")]
			static KMFGIPKMBPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class MNJLLCFCCDP
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo OENNKEHNOHE;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo IAMCIJEPHIO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo DAOGMJHNMME;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo BAICNNBCKJJ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo PGBKNAGAPFM;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo KLPLGLNNPPG;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo MEBEJPMCNCJ;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x50B4B00", Offset = "0x50B3D00", VA = "0x1850B4B00")]
			static MNJLLCFCCDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class JLPJGCDBGNK
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FOJKPCKJJLA;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo HLIGJGOJJCO;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo PAECIOLHNEB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo JKKABMNHFOB;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo GIGKCODGDDH;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo BFKDLBLBHCF;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo EHLLKNOBGFN;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo PFDDNJMHABF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo PCOMKIGBIHC;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo LKEBBABGKPE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo IHBPDICFCPH;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo JBLFLEDPBKD;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo KGGFHOBNMKF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo BFDBKKFFFED;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50B2800", Offset = "0x50B1A00", VA = "0x1850B2800")]
		public static MethodInfo LMGAKHPBOLH(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x50B2AD0", Offset = "0x50B1CD0", VA = "0x1850B2AD0")]
		public static MethodInfo LPJEJNEGJFP(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x50B26C0", Offset = "0x50B18C0", VA = "0x1850B26C0")]
		public static MethodInfo HKCBGBKJMFL(Type DDJDPMGLPAE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class OAHAPADGODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BJHIALAFHDM, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public OAHAPADGODM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KOJNCFBKKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public OAHAPADGODM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public KOJNCFBKKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x50B0340", Offset = "0x50AF540", VA = "0x1850B0340")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x50B0380", Offset = "0x50AF580", VA = "0x1850B0380")]
		internal bool <BuildType>b__2(int index, BJHIALAFHDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FGJBFGBMMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public OAHAPADGODM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public FGJBFGBMMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x50ABE80", Offset = "0x50AB080", VA = "0x1850ABE80")]
		internal bool <BuildType>b__3(int index, BJHIALAFHDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class MJACGDLAHMB
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

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MJACGDLAHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x50B44B0", Offset = "0x50B36B0", VA = "0x1850B44B0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class GEPPCKONPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public GEPPCKONPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x50AC0E0", Offset = "0x50AB2E0", VA = "0x1850AC0E0")]
		internal bool <BuildAnonymousFormatter>b__2(BJHIALAFHDM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GMKNJDNKDBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MJACGDLAHMB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public GMKNJDNKDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x50AD6A0", Offset = "0x50AC8A0", VA = "0x1850AD6A0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x50AD6B0", Offset = "0x50AC8B0", VA = "0x1850AD6B0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, BJHIALAFHDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class BFHDICDJFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MJACGDLAHMB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public BFHDICDJFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x50AB000", Offset = "0x50AA200", VA = "0x1850AB000")]
		internal bool <BuildAnonymousFormatter>b__7(int index, BJHIALAFHDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NCBNKCLFOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public NCBNKCLFOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FD0", Offset = "0x6F11D0", VA = "0x1806F1FD0")]
		internal Label <BuildSerialize>b__1(BJHIALAFHDM _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class DFIDNLFEOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DIEBJMOGHLH[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BJHIALAFHDM, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DFAJAOEBAOO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DFAJAOEBAOO argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public DFIDNLFEOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x50AB8A0", Offset = "0x50AAAA0", VA = "0x1850AB8A0")]
		internal DIEBJMOGHLH <BuildDeserialize>b__0(BJHIALAFHDM item)
		{
			return default(DIEBJMOGHLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KPFKKAFBGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DFIDNLFEOFM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public KPFKKAFBGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x50B0420", Offset = "0x50AF620", VA = "0x1850B0420")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x50B06D0", Offset = "0x50AF8D0", VA = "0x1850B06D0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HDEIIHAPLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BJHIALAFHDM item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public HDEIIHAPLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1154B20", Offset = "0x1153D20", VA = "0x181154B20")]
		internal bool <EmitNewObject>b__0(DIEBJMOGHLH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class POCEOFAINMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BJHIALAFHDM item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public POCEOFAINMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1154B20", Offset = "0x1153D20", VA = "0x181154B20")]
		internal bool <EmitNewObject>b__2(DIEBJMOGHLH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex JKENDBDNEOD;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int DMHJLFHBOPA;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> GFANLDIEBOI;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> AEMHEGDLHPO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x291D470", Offset = "0x291C670", VA = "0x18291D470")]
	public static object JKJDABFFOHL<T>(DDELIMNFFNE LEMGPPEGBPI, LMDOKLNJEDM MMHPNNGOPOO, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29288B0", Offset = "0x2927AB0", VA = "0x1829288B0")]
	public static object KCDOCPKEGKO<T>(LMDOKLNJEDM MMHPNNGOPOO, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG, bool NHNFPKPPJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x53D55B0", Offset = "0x53D47B0", VA = "0x1853D55B0")]
	private static TypeInfo HNINPLKBNBE(DDELIMNFFNE LEMGPPEGBPI, Type DDJDPMGLPAE, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x53D7430", Offset = "0x53D6630", VA = "0x1853D7430")]
	public static object PMKMJIJKOKN(Type DDJDPMGLPAE, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG, bool NHNFPKPPJAJ, bool AMNIBKMKCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x53D2DD0", Offset = "0x53D1FD0", VA = "0x1853D2DD0")]
	private static Dictionary<BJHIALAFHDM, FieldInfo> FJIMJHPPJBI(TypeBuilder DHNNJHMDCOE, NOEPBKCLECE HHCANBNBHNP, ConstructorInfo MFCNHFGGLMJ, FieldBuilder IIKEIOMBOOE, ILGenerator KHLPOCHIMCH, bool LELPBDCIGFG, bool GPALHHOAMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x53D61F0", Offset = "0x53D53F0", VA = "0x1853D61F0")]
	private static Dictionary<BJHIALAFHDM, FieldInfo> JKDFPNDMGAH(TypeBuilder DHNNJHMDCOE, NOEPBKCLECE HHCANBNBHNP, ILGenerator KHLPOCHIMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x53D1360", Offset = "0x53D0560", VA = "0x1853D1360")]
	private static void AMHJOIGKFGC(Type DDJDPMGLPAE, NOEPBKCLECE HHCANBNBHNP, ILGenerator KHLPOCHIMCH, Action MPICDKCMMEM, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, bool LELPBDCIGFG, bool GPALHHOAMFN, int NGHEOGCLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x53D2880", Offset = "0x53D1A80", VA = "0x1853D2880")]
	private static void CPGJJMEHBFN(TypeInfo DDJDPMGLPAE, BJHIALAFHDM AFBJNAEHGAL, ILGenerator KHLPOCHIMCH, int BELCAJFDAHD, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, DFAJAOEBAOO ABIHDCBCABG, DFAJAOEBAOO HCOGACKJDLJ, DFAJAOEBAOO DIGPLAFFJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x53D34B0", Offset = "0x53D26B0", VA = "0x1853D34B0")]
	private static void GJPPBOGMCJI(Type DDJDPMGLPAE, NOEPBKCLECE HHCANBNBHNP, ILGenerator KHLPOCHIMCH, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, bool OBEBDJIIBHJ, int NGHEOGCLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x53D6F70", Offset = "0x53D6170", VA = "0x1853D6F70")]
	private static void OCINAJIDKGD(ILGenerator KHLPOCHIMCH, DIEBJMOGHLH HHCANBNBHNP, int BELCAJFDAHD, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, DFAJAOEBAOO OJMODHIKFDB, DFAJAOEBAOO DIGPLAFFJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x53D4900", Offset = "0x53D3B00", VA = "0x1853D4900")]
	private static LocalBuilder GOGHDNPALBJ(ILGenerator KHLPOCHIMCH, Type DDJDPMGLPAE, NOEPBKCLECE HHCANBNBHNP, DIEBJMOGHLH[] FPPPEFDLKGC, bool CKKLPHPAKIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x53D6870", Offset = "0x53D5A70", VA = "0x1853D6870")]
	private static bool MLKLNPDGIBK(ConstructorInfo DLBIBFHKNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x53D6040", Offset = "0x53D5240", VA = "0x1853D6040")]
	private static bool IKBCPCHKHPF(Type DDJDPMGLPAE, out Type FFAAHCEJNBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void LEKOMFOGBME<T>(byte[][] IIKEIOMBOOE, object[] BICJLPFKGFF, ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T HAJEHMDDNIL<T>(object[] BICJLPFKGFF, ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM DJEEIHBJAEH);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class GJBAFCPPDOO<T> : global::JJBJICJFEAB<T>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] IIKEIOMBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] HEIAOMODGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] NKPKIHOMAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::LEKOMFOGBME<T> DINCDDJBCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::HAJEHMDDNIL<T> CPFAGJHAJGF;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C9C0", Offset = "0x2E6BBC0", VA = "0x182E6C9C0")]
	public GJBAFCPPDOO(byte[][] IIKEIOMBOOE, object[] HEIAOMODGEH, object[] NKPKIHOMAKN, global::LEKOMFOGBME<T> DINCDDJBCLK, global::HAJEHMDDNIL<T> CPFAGJHAJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x35C0E40", Offset = "0x35C0040", VA = "0x1835C0E40", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x35C0F20", Offset = "0x35C0120", VA = "0x1835C0F20", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class HPFNPOKKHGN : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class EAKOJHLAHCH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B2C0", Offset = "0x3D7A4C0", VA = "0x183D7B2C0")]
		static EAKOJHLAHCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private HPFNPOKKHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class AMEKMBBGCNO : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class ACOGHFDJIMB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2A97810", Offset = "0x2A96A10", VA = "0x182A97810")]
		static ACOGHFDJIMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private AMEKMBBGCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class CHDCHIHAMJB
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly LMDOKLNJEDM[] KKGFINAFAOH;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class FDOFHGEBCBH : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class LKFBGJPELNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x37E9BA0", Offset = "0x37E8DA0", VA = "0x1837E9BA0")]
		static LKFBGJPELNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class FJGJNEJJLKG : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class APFMOAIFHEB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x33907C0", Offset = "0x338F9C0", VA = "0x1833907C0")]
			static APFMOAIFHEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private FJGJNEJJLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private FDOFHGEBCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class FAIJPBPLKOA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class IMPKHPPLMHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x27E3D80", Offset = "0x27E2F80", VA = "0x1827E3D80")]
		static IMPKHPPLMHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class ANHAAFFNMJO : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class ILGAHLGALKB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x27DFF00", Offset = "0x27DF100", VA = "0x1827DFF00")]
			static ILGAHLGALKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private ANHAAFFNMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private FAIJPBPLKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class JEJPDHKKLDA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class LNBNJEJGNMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x37F4930", Offset = "0x37F3B30", VA = "0x1837F4930")]
		static LNBNJEJGNMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class HGAKPEDMLLK : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class COPLJIJCHGE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2F18A70", Offset = "0x2F17C70", VA = "0x182F18A70")]
			static COPLJIJCHGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private HGAKPEDMLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private JEJPDHKKLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class KKLAIBACLJE : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class BNMDEMHIAFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2294800", Offset = "0x2293A00", VA = "0x182294800")]
		static BNMDEMHIAFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class CBBLIFFCELE : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class DOMEJOICEOO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x376F030", Offset = "0x376E230", VA = "0x18376F030")]
			static DOMEJOICEOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private CBBLIFFCELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private KKLAIBACLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class CFOFNLEPIEA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class NFLDMBFHGMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C470", Offset = "0x2B6B670", VA = "0x182B6C470")]
		static NFLDMBFHGMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class CKLJFFKHJGL : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class JMMLHEMCCBI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3B22F10", Offset = "0x3B22110", VA = "0x183B22F10")]
			static JMMLHEMCCBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private CKLJFFKHJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private CFOFNLEPIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class OONJGCBOADG : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class FKNGKLLKEMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x23B4690", Offset = "0x23B3890", VA = "0x1823B4690")]
		static FKNGKLLKEMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class KKGCNFLPFAJ : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class NCPJGBDIKOK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2B5EE70", Offset = "0x2B5E070", VA = "0x182B5EE70")]
			static NCPJGBDIKOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private KKGCNFLPFAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private OONJGCBOADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class MAKCPJDNNBB : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class EBMPFCJJGIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F4D0A0", Offset = "0x2F4C2A0", VA = "0x182F4D0A0")]
		static EBMPFCJJGIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class ONMGGBNGCKA : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class JGAODKJAANM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3644F90", Offset = "0x3644190", VA = "0x183644F90")]
			static JGAODKJAANM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private ONMGGBNGCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private MAKCPJDNNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class PMBFKOCKPAF : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class FOALGFHKOIO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3046700", Offset = "0x3045900", VA = "0x183046700")]
		static FOALGFHKOIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class GOMCLJMJPIJ : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class DELMDDBDKAI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3A12610", Offset = "0x3A11810", VA = "0x183A12610")]
			static DELMDDBDKAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private GOMCLJMJPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private PMBFKOCKPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class HLOPJBDDPOM : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class ALBFNPONGJA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x33831C0", Offset = "0x33823C0", VA = "0x1833831C0")]
		static ALBFNPONGJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class CNCDKHFMONP : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NFDNAPBIEPH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B69BC0", Offset = "0x2B68DC0", VA = "0x182B69BC0")]
			static NFDNAPBIEPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private CNCDKHFMONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private HLOPJBDDPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class KKDFCIGJKKA : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class LNNOALMHNFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC31D0", Offset = "0x3CC23D0", VA = "0x183CC31D0")]
		static LNNOALMHNFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class ANEOIBPAEAM : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class PNLOPCLNIHN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x454BF50", Offset = "0x454B150", VA = "0x18454BF50")]
			static PNLOPCLNIHN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private ANEOIBPAEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private KKDFCIGJKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class BILPCINALKO : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class CFNGNKCEJAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4EB0", Offset = "0x2AF40B0", VA = "0x182AF4EB0")]
		static CFNGNKCEJAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class BNMCEJKBMBO : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class AHKKBILNLLN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B750", Offset = "0x2A3A950", VA = "0x182A3B750")]
			static AHKKBILNLLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private BNMCEJKBMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private BILPCINALKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class FEFOGKDFNNM : LMDOKLNJEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class FHKJGMKCLBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x23AAFE0", Offset = "0x23AA1E0", VA = "0x1823AAFE0")]
		static FHKJGMKCLBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class DHKJGJHIOCC : LMDOKLNJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class EBPFBGDLHGL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::JJBJICJFEAB<T> GFFCEOEEHGD;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2F50E80", Offset = "0x2F50080", VA = "0x182F50E80")]
			static EBPFBGDLHGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		private DHKJGJHIOCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
		public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::JJBJICJFEAB<object> ONMFGPLCOFD;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	private FEFOGKDFNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1705AC0", Offset = "0x1704CC0", VA = "0x181705AC0", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct LFCMPLINDCF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] HFMHMFPNNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int FAANOCEKAPG;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x35EDC00", Offset = "0x35ECE00", VA = "0x1835EDC00")]
	public LFCMPLINDCF(int KHFADEKJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x35ED8D0", Offset = "0x35ECAD0", VA = "0x1835ED8D0")]
	public void AOHLLDNPMGN(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x35EDB70", Offset = "0x35ECD70", VA = "0x1835EDB70")]
	public T[] LHBPEMIBDMO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class MAKKIDJOGLP : global::NNLGPMNIGEN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly MAKKIDJOGLP HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x51039C0", Offset = "0x5102BC0", VA = "0x1851039C0")]
	public MAKKIDJOGLP(int PIIEHIOHJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class NNLGPMNIGEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int PIIEHIOHJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object IPJAJHJCGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int BELCAJFDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] HEBFPEMHNHE;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3121180", Offset = "0x3120380", VA = "0x183121180")]
	public NNLGPMNIGEN(int PIIEHIOHJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3120B10", Offset = "0x311FD10", VA = "0x183120B10")]
	public T[] LADDEPODNIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x31205D0", Offset = "0x311F7D0", VA = "0x1831205D0")]
	public void DKLKNFOECDE(T[] PFCDNINKMFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class CNJAGIAHCJK : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class GICCFFEKJMD : IComparable<GICCFFEKJMD>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class HGOIJGAFODJ : IEnumerable<GICCFFEKJMD>, IEnumerable, IEnumerator<GICCFFEKJMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private GICCFFEKJMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public GICCFFEKJMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private GICCFFEKJMD System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
			[DebuggerHidden]
			public HGOIJGAFODJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x50ADBD0", Offset = "0x50ACDD0", VA = "0x1850ADBD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x50ADD00", Offset = "0x50ACF00", VA = "0x1850ADD00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x50ADC60", Offset = "0x50ACE60", VA = "0x1850ADC60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GICCFFEKJMD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x50ADC60", Offset = "0x50ACE60", VA = "0x1850ADC60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class JAMFJJIKBEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public JAMFJJIKBEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6F1FD0", Offset = "0x6F11D0", VA = "0x1806F1FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x6F1FD0", Offset = "0x6F11D0", VA = "0x1806F1FD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly GICCFFEKJMD[] DAEHEPDFDDF;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] EOIKJHABMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong EGNKEKCMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int ALAOEPGGPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string PMPFNNLGIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private GICCFFEKJMD[] NGLNBKKEJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] JPAHMPABDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int OCCKKIPCFBH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PAFFNNFJAPI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCCAF60", Offset = "0xCCA160", VA = "0x180CCAF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x50AD5E0", Offset = "0x50AC7E0", VA = "0x1850AD5E0")]
		public GICCFFEKJMD(ulong EBOEHIFNNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x50AC280", Offset = "0x50AB480", VA = "0x1850AC280")]
		public GICCFFEKJMD AOHLLDNPMGN(ulong EBOEHIFNNLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x50AC540", Offset = "0x50AB740", VA = "0x1850AC540")]
		public GICCFFEKJMD AOHLLDNPMGN(ulong EBOEHIFNNLM, int JFBPNBNBHOE, string PMPFNNLGIFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x50AC590", Offset = "0x50AB790", VA = "0x1850AC590")]
		public GICCFFEKJMD BEDPOPEKOFK(byte[] KHNOBAAPEAO, ref int ELOEOOGBENM, ref int IFCGFMEPAHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x50AC7E0", Offset = "0x50AB9E0", VA = "0x1850AC7E0")]
		internal static int GIOGKPLCGFD(ulong[] PFCDNINKMFA, int BELCAJFDAHD, int ONCBCCLEFOH, ulong JFBPNBNBHOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x50AC7B0", Offset = "0x50AB9B0", VA = "0x1850AC7B0", Slot = "4")]
		public int CompareTo(GICCFFEKJMD IHIJPIJNLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x50AC740", Offset = "0x50AB940", VA = "0x1850AC740")]
		[IteratorStateMachine(typeof(HGOIJGAFODJ))]
		public IEnumerable<GICCFFEKJMD> BFKFPEELIBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x50AC140", Offset = "0x50AB340", VA = "0x1850AC140")]
		public void ADPJACKFNHL(ILGenerator KHLPOCHIMCH, LocalBuilder KHNOBAAPEAO, LocalBuilder IFCGFMEPAHB, LocalBuilder EBOEHIFNNLM, Action<KeyValuePair<string, int>> IBJDOKNOKAA, Action DGNBPNMEBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x50AC860", Offset = "0x50ABA60", VA = "0x1850AC860")]
		private static void LLCONGGDFKC(ILGenerator KHLPOCHIMCH, LocalBuilder KHNOBAAPEAO, LocalBuilder IFCGFMEPAHB, LocalBuilder EBOEHIFNNLM, Action<KeyValuePair<string, int>> IBJDOKNOKAA, Action DGNBPNMEBGI, GICCFFEKJMD[] NGLNBKKEJKJ, int OCCKKIPCFBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class HLCEHJFLDDB : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IEnumerable<GICCFFEKJMD> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<GICCFFEKJMD> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<GICCFFEKJMD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private GICCFFEKJMD <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x50AE3A0", Offset = "0x50AD5A0", VA = "0x1850AE3A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96E120", VA = "0x18096EF20")]
		[DebuggerHidden]
		public HLCEHJFLDDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x50AE3F0", Offset = "0x50AD5F0", VA = "0x1850AE3F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x50ADE60", Offset = "0x50AD060", VA = "0x1850ADE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x50AE4D0", Offset = "0x50AD6D0", VA = "0x1850AE4D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x50AE520", Offset = "0x50AD720", VA = "0x1850AE520")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x50AE360", Offset = "0x50AD560", VA = "0x1850AE360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x50AE2C0", Offset = "0x50AD4C0", VA = "0x1850AE2C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x50AE2C0", Offset = "0x50AD4C0", VA = "0x1850AE2C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly GICCFFEKJMD LBGMPPHBAAC;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x53DD370", Offset = "0x53DC570", VA = "0x1853DD370")]
	public CNJAGIAHCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x53DCD10", Offset = "0x53DBF10", VA = "0x1853DCD10")]
	public void AOHLLDNPMGN(byte[] NPNCGJAPKIL, int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x53DCE30", Offset = "0x53DC030", VA = "0x1853DCE30")]
	public bool BAGFKPIACCN(ArraySegment<byte> EBOEHIFNNLM, out int JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x53DD2E0", Offset = "0x53DC4E0", VA = "0x1853DD2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x53DCFD0", Offset = "0x53DC1D0", VA = "0x1853DCFD0")]
	private static void IKMAMJJEKMJ(IEnumerable<GICCFFEKJMD> NGLNBKKEJKJ, StringBuilder LMKNLEBCBAL, int ELMCLGINMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x53DCF20", Offset = "0x53DC120", VA = "0x1853DCF20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x53DCF20", Offset = "0x53DC120", VA = "0x1853DCF20", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x53DD270", Offset = "0x53DC470", VA = "0x1853DD270")]
	[IteratorStateMachine(typeof(HLCEHJFLDDB))]
	private static IEnumerable<KeyValuePair<string, int>> OAOKGDCGADJ(IEnumerable<GICCFFEKJMD> NGLNBKKEJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x53DCEF0", Offset = "0x53DC0F0", VA = "0x1853DCEF0")]
	public void EEMGPDAJNBH(ILGenerator KHLPOCHIMCH, LocalBuilder KHNOBAAPEAO, LocalBuilder IFCGFMEPAHB, LocalBuilder EBOEHIFNNLM, Action<KeyValuePair<string, int>> IBJDOKNOKAA, Action DGNBPNMEBGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class IMMFLJAPKEP
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo MCGCLMMHAEH;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x50FA540", Offset = "0x50F9740", VA = "0x1850FA540")]
	public static ulong OLMCPIGCKDJ(byte[] NPNCGJAPKIL, ref int ELOEOOGBENM, ref int IFCGFMEPAHB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class COOKHFPBHNA
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x53DD3E0", Offset = "0x53DC5E0", VA = "0x1853DD3E0")]
	public static void CDEPEGAJOEL(ref byte[] NPNCGJAPKIL, int ELOEOOGBENM, int FOFPICKAACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x53DD520", Offset = "0x53DC720", VA = "0x1853DD520")]
	public static void OLEKLNHJKIJ(ref byte[] PFCDNINKMFA, int HBBFBJDJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x53DD630", Offset = "0x53DC830", VA = "0x1853DD630")]
	public static byte[] PHLGDIOFHPP(byte[] NKOMPJIJHJB, int HBBFBJDJKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class BCNHOFPALFA
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x53D05B0", Offset = "0x53CF7B0", VA = "0x1853D05B0")]
	public static bool MHAKOGLEHCF(byte[] BCLCEMPLFEO, int HJEPJCIFDOH, int ALOBDCNMJLD, byte[] CCOMIGIMNAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class LFOALGNFDPH<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct POJGAHJKBNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] EGNKEKCMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T ALAOEPGGPNI;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E7C0", Offset = "0x3F5D9C0", VA = "0x183F5E7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class DFBOLIJOCJP : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::LFOALGNFDPH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private POJGAHJKBNO[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private POJGAHJKBNO[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2A14260", Offset = "0x2A13460", VA = "0x182A14260", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1DA40C0", Offset = "0x1DA32C0", VA = "0x181DA40C0")]
		[DebuggerHidden]
		public DFBOLIJOCJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2A12AC0", Offset = "0x2A11CC0", VA = "0x182A12AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2A13A60", Offset = "0x2A12C60", VA = "0x182A13A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly POJGAHJKBNO[][] BIKGHKHICDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong PEBJMDEDLBD;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x35F9480", Offset = "0x35F8680", VA = "0x1835F9480")]
	public LFOALGNFDPH(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x35F93C0", Offset = "0x35F85C0", VA = "0x1835F93C0")]
	public LFOALGNFDPH(int DOMGBHGFPFL, float CGFBCPMAEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x35EFB50", Offset = "0x35EED50", VA = "0x1835EFB50")]
	public void AOHLLDNPMGN(byte[] EBOEHIFNNLM, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x35F4040", Offset = "0x35F3240", VA = "0x1835F4040")]
	private bool GLNKOOBMPIL(byte[] EBOEHIFNNLM, T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x35F27E0", Offset = "0x35F19E0", VA = "0x1835F27E0")]
	public bool CPKINNFJFHF(ArraySegment<byte> EBOEHIFNNLM, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x35F9330", Offset = "0x35F8530", VA = "0x1835F9330")]
	private static ulong JEGMKCDKIEG(byte[] BIAIPPDLOMD, int ELOEOOGBENM, int OCCKKIPCFBH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x35F9390", Offset = "0x35F8590", VA = "0x1835F9390")]
	private static int KIAGJECCKCG(int LMLDMGPNIBA, float CGFBCPMAEFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x35F90F0", Offset = "0x35F82F0", VA = "0x1835F90F0", Slot = "4")]
	[IteratorStateMachine(typeof(global::LFOALGNFDPH<>.DFBOLIJOCJP))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x23A2B10", Offset = "0x23A1D10", VA = "0x1823A2B10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class OPHAAIPGCLK : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] OJMCAOBEACN;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] CAGMJEGNADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int NMIKPGNKGHB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool CLHJJKGCHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x50BC4E0", Offset = "0x50BB6E0", VA = "0x1850BC4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x50BC530", Offset = "0x50BB730", VA = "0x1850BC530")]
	static OPHAAIPGCLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x50BC7B0", Offset = "0x50BB9B0", VA = "0x1850BC7B0")]
	public OPHAAIPGCLK(byte[] GMDEMDDCHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x50BC3C0", Offset = "0x50BB5C0", VA = "0x1850BC3C0")]
	public OpCode JPDGMJAFKOG()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct KAGENBBFNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid ALAOEPGGPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte MAEHNAMHCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte CFCHNAIHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte ANFJFFBFADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte AOCHIJEHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte HHIKFJLHCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte APNCPJNOMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte KOLJPGPCKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte KMGEINCGJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte CMHCMHBAAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte MHNCKKGJFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte JPBDPMADBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte CHFMEBLNALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte JHMJGKABOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte NFENBHBGGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte DHIBHDMOGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte LOAPAJIEOEL;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] FMALFCNHBDP;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] CKIOGDJOABH;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x50FF100", Offset = "0x50FE300", VA = "0x1850FF100")]
	public KAGENBBFNJE(ref Guid JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x50FDCB0", Offset = "0x50FCEB0", VA = "0x1850FDCB0")]
	public KAGENBBFNJE(ref ArraySegment<byte> PIMPDLEILKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x50FC6C0", Offset = "0x50FB8C0", VA = "0x1850FC6C0")]
	private static byte DFKLAKNNIDE(byte[] NPNCGJAPKIL, int KCDLOPCGIHA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x50FDAD0", Offset = "0x50FCCD0", VA = "0x1850FDAD0")]
	private static byte IAOCKCNJCLO(byte GPHMIGDKMEO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x50FC780", Offset = "0x50FB980", VA = "0x1850FC780")]
	public void EFLAGMJPJKC(byte[] IEGPGBKLAIF, int ELOEOOGBENM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class APLBHDALFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x53CC100", Offset = "0x53CB300", VA = "0x1853CC100")]
	public static bool HLFBPIJCJDE(byte ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x53CBDB0", Offset = "0x53CAFB0", VA = "0x1853CBDB0")]
	public static bool FBBJEHONPIM(byte ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x53CBE20", Offset = "0x53CB020", VA = "0x1853CBE20")]
	public static sbyte FIPNAOJLBAE(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x53CC600", Offset = "0x53CB800", VA = "0x1853CC600")]
	public static short PPNOBAEHOGF(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x53CC310", Offset = "0x53CB510", VA = "0x1853CC310")]
	public static int JOEICHNIDGO(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x53CC4E0", Offset = "0x53CB6E0", VA = "0x1853CC4E0")]
	public static long OBFBHKKJEIH(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x53CC590", Offset = "0x53CB790", VA = "0x1853CC590")]
	public static byte ONKDCBDEKBB(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x53CC380", Offset = "0x53CB580", VA = "0x1853CC380")]
	public static ushort KPFMCNLJDOG(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x53CB560", Offset = "0x53CA760", VA = "0x1853CB560")]
	public static uint CCNDEEDCGBF(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x53CC200", Offset = "0x53CB400", VA = "0x1853CC200")]
	public static ulong JGECLHMFKKD(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x53CC3F0", Offset = "0x53CB5F0", VA = "0x1853CC3F0")]
	public static float MEOBEEKJDLP(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x53CC110", Offset = "0x53CB310", VA = "0x1853CC110")]
	public static double JAJFEMDKJEL(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x53CB5E0", Offset = "0x53CA7E0", VA = "0x1853CB5E0")]
	public static int EOACNFMILOI(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, ulong JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x53CA930", Offset = "0x53C9B30", VA = "0x1853CA930")]
	public static int BMDFCIEFFAP(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, long JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x53CBE90", Offset = "0x53CB090", VA = "0x1853CBE90")]
	public static bool GMOMCJKEIPE(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class MHAMGFLEHOA
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class MNHFECMPKCF : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public MNHFECMPKCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x50B4970", Offset = "0x50B3B70", VA = "0x1850B4970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x50B4510", Offset = "0x50B3710", VA = "0x1850B4510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x50B4A60", Offset = "0x50B3C60", VA = "0x1850B4A60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x50B4AB0", Offset = "0x50B3CB0", VA = "0x1850B4AB0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x50B4930", Offset = "0x50B3B30", VA = "0x1850B4930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x50B4880", Offset = "0x50B3A80", VA = "0x1850B4880", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x50B4880", Offset = "0x50B3A80", VA = "0x1850B4880", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class JJLPJDIHKJB : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public JJLPJDIHKJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x50AEE50", Offset = "0x50AE050", VA = "0x1850AEE50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x50AE9F0", Offset = "0x50ADBF0", VA = "0x1850AE9F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x50AEF40", Offset = "0x50AE140", VA = "0x1850AEF40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x50AEF90", Offset = "0x50AE190", VA = "0x1850AEF90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x50AEE10", Offset = "0x50AE010", VA = "0x1850AEE10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x50AED60", Offset = "0x50ADF60", VA = "0x1850AED60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x50AED60", Offset = "0x50ADF60", VA = "0x1850AED60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5104380", Offset = "0x5103580", VA = "0x185104380")]
	public static bool NFEFJLHLNCD(this TypeInfo DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5104030", Offset = "0x5103230", VA = "0x185104030")]
	public static bool EFCJBEOIOIL(this TypeInfo DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x51042B0", Offset = "0x51034B0", VA = "0x1851042B0")]
	public static IEnumerable<PropertyInfo> MACAEDLEMDI(this Type DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5104150", Offset = "0x5103350", VA = "0x185104150")]
	[IteratorStateMachine(typeof(MNHFECMPKCF))]
	private static IEnumerable<PropertyInfo> EPDAJBDIILN(Type DDJDPMGLPAE, HashSet<string> LMONEMBKGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x51041E0", Offset = "0x51033E0", VA = "0x1851041E0")]
	public static IEnumerable<FieldInfo> KPHOLGGFPAE(this Type DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5103FA0", Offset = "0x51031A0", VA = "0x185103FA0")]
	[IteratorStateMachine(typeof(JJLPJDIHKJB))]
	private static IEnumerable<FieldInfo> BJAJHEMLIEJ(Type DDJDPMGLPAE, HashSet<string> LMONEMBKGOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class OCCFKFOPFOH
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding LMPBPDDIAMO;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class BJCJBIKHPJC
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00")]
	public static string GMNJDPICPAF(string CKNAFFDCOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x53D0C10", Offset = "0x53CFE10", VA = "0x1853D0C10")]
	public static string PEOPDDFOKHH(string CKNAFFDCOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x53D0A20", Offset = "0x53CFC20", VA = "0x1853D0A20")]
	public static string DBAIPNHNHMN(string CKNAFFDCOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class MEEGMHDFAGF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class HBOAPKNLPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type EGNKEKCMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue ALAOEPGGPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int FCHMMCGJKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public HBOAPKNLPGH IAKIEBOOHPD;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAD00", Offset = "0x3BF9F00", VA = "0x183BFAD00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAC80", Offset = "0x3BF9E80", VA = "0x183BFAC80")]
		private int HGPJFHAOHMD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public HBOAPKNLPGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class GKFDKODJJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public GKFDKODJJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private HBOAPKNLPGH[] BIKGHKHICDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int PCAHMJECHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object EBEDBDGKDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float CGFBCPMAEFH;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE950", Offset = "0x3AEDB50", VA = "0x183AEE950")]
	public MEEGMHDFAGF(int DOMGBHGFPFL = 4, float CGFBCPMAEFH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE6D0", Offset = "0x3AED8D0", VA = "0x183AEE6D0")]
	public bool PJJKMDOPJFF(Type EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE7E0", Offset = "0x3AED9E0", VA = "0x183AEE7E0")]
	public bool PJJKMDOPJFF(Type EBOEHIFNNLM, Func<Type, TValue> IFANJKMGAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDA40", Offset = "0x3AECC40", VA = "0x183AEDA40")]
	private bool GLNKOOBMPIL(Type EBOEHIFNNLM, Func<Type, TValue> IFANJKMGAHF, out TValue PLFJIEEKHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE0B0", Offset = "0x3AED2B0", VA = "0x183AEE0B0")]
	private bool LEPALKLIEMC(HBOAPKNLPGH[] BIKGHKHICDJ, Type AFJLFMBHLPF, HBOAPKNLPGH CFCMJPHPLHP, Func<Type, TValue> IFANJKMGAHF, out TValue PLFJIEEKHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3AED4A0", Offset = "0x3AEC6A0", VA = "0x183AED4A0")]
	public bool CPKINNFJFHF(Type EBOEHIFNNLM, out TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE510", Offset = "0x3AED710", VA = "0x183AEE510")]
	public TValue MGNJLCPLAEP(Type EBOEHIFNNLM, Func<Type, TValue> IFANJKMGAHF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x35F9390", Offset = "0x35F8590", VA = "0x1835F9390")]
	private static int KIAGJECCKCG(int LMLDMGPNIBA, float CGFBCPMAEFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3AED740", Offset = "0x3AEC940", VA = "0x183AED740")]
	private static void EBPOMHOCDHP(ref HBOAPKNLPGH HCEAGEMIOND, HBOAPKNLPGH JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3AED740", Offset = "0x3AEC940", VA = "0x183AED740")]
	private static void EBPOMHOCDHP(ref HBOAPKNLPGH[] HCEAGEMIOND, HBOAPKNLPGH[] JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class DDELIMNFFNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder FAMLLHPACDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder BMPNCDLONJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object IPJAJHJCGGB;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x50ED320", Offset = "0x50EC520", VA = "0x1850ED320")]
	public TypeBuilder NLAFCGAAOGO(string IGHJIHNAPBA, TypeAttributes PKPEBMBGKAA, Type GPFONCECPBK, Type[] BHABKHHGPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x50ED3F0", Offset = "0x50EC5F0", VA = "0x1850ED3F0")]
	public DDELIMNFFNE(string DCFLKNPNLJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class GAOIBLABNGB
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x50F2AC0", Offset = "0x50F1CC0", VA = "0x1850F2AC0")]
	private static MethodInfo MDHOJHDPNJE(LambdaExpression ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1AD0", Offset = "0x2EB0CD0", VA = "0x182EB1AD0")]
	public static MethodInfo IGLNAJDMJOC<T>(Expression<Func<T>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1AD0", Offset = "0x2EB0CD0", VA = "0x182EB1AD0")]
	public static MethodInfo IGLNAJDMJOC<T, TR>(Expression<Func<T, TR>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1AD0", Offset = "0x2EB0CD0", VA = "0x182EB1AD0")]
	public static MethodInfo IGLNAJDMJOC<T>(Expression<Action<T>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1AD0", Offset = "0x2EB0CD0", VA = "0x182EB1AD0")]
	public static MethodInfo IGLNAJDMJOC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1AE0", Offset = "0x2EB0CE0", VA = "0x182EB1AE0")]
	private static MemberInfo OOGFLOGOHLH<T>(Expression<T> GEMNKBDIDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1A70", Offset = "0x2EB0C70", VA = "0x182EB1A70")]
	public static PropertyInfo HIGDIMEBCPK<T, TR>(Expression<Func<T, TR>> ECMKNJHJFAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct DFAJAOEBAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int BHOLCDOGKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool PIDPOAKILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator KHLPOCHIMCH;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x50EDA00", Offset = "0x50ECC00", VA = "0x1850EDA00")]
	public DFAJAOEBAOO(ILGenerator KHLPOCHIMCH, int BHOLCDOGKAG, bool PIDPOAKILGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x50ED970", Offset = "0x50ECB70", VA = "0x1850ED970")]
	public DFAJAOEBAOO(ILGenerator KHLPOCHIMCH, int BHOLCDOGKAG, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x50ED850", Offset = "0x50ECA50", VA = "0x1850ED850")]
	public void BFHMNPNMBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class LJDAJGMPFKC
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5102600", Offset = "0x5101800", VA = "0x185102600")]
	public static void ALLHMCCMNJA(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x51025C0", Offset = "0x51017C0", VA = "0x1851025C0")]
	public static void ALLHMCCMNJA(this ILGenerator KHLPOCHIMCH, LocalBuilder OPMPONOLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x51033A0", Offset = "0x51025A0", VA = "0x1851033A0")]
	public static void LBLKGDGLCAN(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5103360", Offset = "0x5102560", VA = "0x185103360")]
	public static void LBLKGDGLCAN(this ILGenerator KHLPOCHIMCH, LocalBuilder OPMPONOLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x51036E0", Offset = "0x51028E0", VA = "0x1851036E0")]
	public static void MOHBJGGMIJF(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x51035D0", Offset = "0x51027D0", VA = "0x1851035D0")]
	public static void MOHBJGGMIJF(this ILGenerator KHLPOCHIMCH, LocalBuilder OPMPONOLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x51037D0", Offset = "0x51029D0", VA = "0x1851037D0")]
	public static void PMOFEMFDHAA(this ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x51029D0", Offset = "0x5101BD0", VA = "0x1851029D0")]
	public static void EGEKAANNPJF(this ILGenerator KHLPOCHIMCH, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5102BF0", Offset = "0x5101DF0", VA = "0x185102BF0")]
	public static void ICGCBMAJPML(this ILGenerator KHLPOCHIMCH, int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5103040", Offset = "0x5102240", VA = "0x185103040")]
	public static void IKIIBDJDECF(this ILGenerator KHLPOCHIMCH, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5102830", Offset = "0x5101A30", VA = "0x185102830")]
	public static void CIAECLHHPOH(this ILGenerator KHLPOCHIMCH, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5103130", Offset = "0x5102330", VA = "0x185103130")]
	public static void KHMOIIBIFOA(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x51029E0", Offset = "0x5101BE0", VA = "0x1851029E0")]
	public static void GALNOOBCGGC(this ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x51028E0", Offset = "0x5101AE0", VA = "0x1851028E0")]
	public static void DCIFBNIGAJN(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5102A60", Offset = "0x5101C60", VA = "0x185102A60")]
	public static void GKLBDPECOPD(this ILGenerator KHLPOCHIMCH, MethodInfo DJMIEBAMKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5102B60", Offset = "0x5101D60", VA = "0x185102B60")]
	public static void HMNGEBLDONO(this ILGenerator KHLPOCHIMCH, FieldInfo BLFOEOAOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5102530", Offset = "0x5101730", VA = "0x185102530")]
	public static void ACLFLKGPOLE(this ILGenerator KHLPOCHIMCH, ulong JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class BJHIALAFHDM
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MGHHEFPJCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MGHHEFPJCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x50B43A0", Offset = "0x50B35A0", VA = "0x1850B43A0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo ONABGFBLLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo GBANGHKBGBF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GNBJKCFFJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LNONEMEBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x53D0D20", Offset = "0x53CFF20", VA = "0x1853D0D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PJEGGJEIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6E23D0", Offset = "0x6E15D0", VA = "0x1806E23D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AF0", Offset = "0x7F3CF0", VA = "0x1807F4AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PIKDHBBGGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6E23E0", Offset = "0x6E15E0", VA = "0x1806E23E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xC56370", Offset = "0xC55570", VA = "0x180C56370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7091C0", Offset = "0x7083C0", VA = "0x1807091C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo JAOFAKPEFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo BGKGAFNMNND
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6CE590", Offset = "0x6CD790", VA = "0x1806CE590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo FNIAMHKLAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6CE580", Offset = "0x6CD780", VA = "0x1806CE580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6CE5A0", Offset = "0x6CD7A0", VA = "0x1806CE5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x53D1020", Offset = "0x53D0220", VA = "0x1853D1020")]
	protected BJHIALAFHDM(Type DDJDPMGLPAE, string IGHJIHNAPBA, string KIKOLEGOJKD, bool NCNFCBCNCMF, bool LOLGAHFDDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x53D1250", Offset = "0x53D0450", VA = "0x1853D1250")]
	public BJHIALAFHDM(FieldInfo HHCANBNBHNP, string IGHJIHNAPBA, bool NHNFPKPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x53D10A0", Offset = "0x53D02A0", VA = "0x1853D10A0")]
	public BJHIALAFHDM(PropertyInfo HHCANBNBHNP, string IGHJIHNAPBA, bool NHNFPKPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x53D0EB0", Offset = "0x53D00B0", VA = "0x1853D0EB0")]
	private static MethodInfo OKJIMJONKJM(MemberInfo HHCANBNBHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2918350", Offset = "0x2917550", VA = "0x182918350")]
	public T BJADLDDDMOP<T>(bool CIHAJCFGKFL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x53D0D30", Offset = "0x53CFF30", VA = "0x1853D0D30", Slot = "4")]
	public virtual void JHLFJGIOLDM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x53D0DF0", Offset = "0x53CFFF0", VA = "0x1853D0DF0", Slot = "5")]
	public virtual void MOPANCFIDJM(ILGenerator KHLPOCHIMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class AJNBIGAKHEN : BJHIALAFHDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string HJNPIGFAIID;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x53C66A0", Offset = "0x53C58A0", VA = "0x1853C66A0")]
	public AJNBIGAKHEN(string IGHJIHNAPBA, string HJNPIGFAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x53C65A0", Offset = "0x53C57A0", VA = "0x1853C65A0", Slot = "4")]
	public override void JHLFJGIOLDM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x53C6660", Offset = "0x53C5860", VA = "0x1853C6660", Slot = "5")]
	public override void MOPANCFIDJM(ILGenerator KHLPOCHIMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class NGCDBJCNHGF : BJHIALAFHDM
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo MCMDACIIDNM;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo DJPJOFKJHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal DFAJAOEBAOO IDGPEDKACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal DFAJAOEBAOO HCOGACKJDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal DFAJAOEBAOO DIGPLAFFJGB;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x50B7770", Offset = "0x50B6970", VA = "0x1850B7770")]
	public NGCDBJCNHGF(string IGHJIHNAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x50B6FF0", Offset = "0x50B61F0", VA = "0x1850B6FF0", Slot = "4")]
	public override void JHLFJGIOLDM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x50B70C0", Offset = "0x50B62C0", VA = "0x1850B70C0", Slot = "5")]
	public override void MOPANCFIDJM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x50B7100", Offset = "0x50B6300", VA = "0x1850B7100")]
	public void PLBPHNABFNK(ILGenerator KHLPOCHIMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class NOEPBKCLECE
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OBBJBCDBKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x703000", Offset = "0x702200", VA = "0x180703000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OLKPHOMDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xC25840", Offset = "0xC24A40", VA = "0x180C25840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xC25860", Offset = "0xC24A60", VA = "0x180C25860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo IPJCOGPCKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BJHIALAFHDM[] IAHGOBHIGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7091C0", Offset = "0x7083C0", VA = "0x1807091C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BJHIALAFHDM[] FNPAPKLCIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x50B8270", Offset = "0x50B7470", VA = "0x1850B8270")]
	public NOEPBKCLECE(Type DDJDPMGLPAE, Func<string, string> JLJALPPAEGA, bool NHNFPKPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x50B8180", Offset = "0x50B7380", VA = "0x1850B8180")]
	private static bool LKBBODKPEDG(IEnumerator<ConstructorInfo> HJLNJIHHJDM, ref ConstructorInfo OMMHHBOLCCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct IFFICNKKECF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong JBOJGNNLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int LBPJAILMLKD;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CD58F0", Offset = "0x1CD4AF0", VA = "0x181CD58F0")]
	public IFFICNKKECF(ulong PAOJMJOOEAH, int DFCACCOGAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x50F7100", Offset = "0x50F6300", VA = "0x1850F7100")]
	public void ENDMOOABFFG(ref IFFICNKKECF IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x50F71B0", Offset = "0x50F63B0", VA = "0x1850F71B0")]
	public static IFFICNKKECF JLHKNLFAFLI(ref IFFICNKKECF FAMKPEGNHFC, ref IFFICNKKECF GPHMIGDKMEO)
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x50F71C0", Offset = "0x50F63C0", VA = "0x1850F71C0")]
	public void OHNILAFCBHP(ref IFFICNKKECF IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x50F7110", Offset = "0x50F6310", VA = "0x1850F7110")]
	public static IFFICNKKECF JKNEPOEMDMJ(ref IFFICNKKECF FAMKPEGNHFC, ref IFFICNKKECF GPHMIGDKMEO)
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x50F7070", Offset = "0x50F6270", VA = "0x1850F7070")]
	public void BOFNDPHBABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x50F70B0", Offset = "0x50F62B0", VA = "0x1850F70B0")]
	public static IFFICNKKECF BOFNDPHBABH(ref IFFICNKKECF FAMKPEGNHFC)
	{
		return default(IFFICNKKECF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct FMMNMNJCIMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] IEGPGBKLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int ELOEOOGBENM;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EB0", Offset = "0x7E70B0", VA = "0x1807E7EB0")]
	public FMMNMNJCIMG(byte[] IEGPGBKLAIF, int DACBJNCMNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x50F2210", Offset = "0x50F1410", VA = "0x1850F2210")]
	public void ECHDFHMGOPJ(byte IGMDKJEALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x50F2270", Offset = "0x50F1470", VA = "0x1850F2270")]
	public void EDJIMIEPDOC(byte[] IGMDKJEALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x50F20C0", Offset = "0x50F12C0", VA = "0x1850F20C0")]
	public void COOKAACODFG(byte[] IGMDKJEALIM, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x50F2160", Offset = "0x50F1360", VA = "0x1850F2160")]
	public void COOKAACODFG(byte[] IGMDKJEALIM, int IDCHKLCNMBN, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x50F2040", Offset = "0x50F1240", VA = "0x1850F2040")]
	public void AHEGGOJALOG(byte ECKJDAFJMBK, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x50F2310", Offset = "0x50F1510", VA = "0x1850F2310")]
	public void NHJBGFOFPGL(string IGMDKJEALIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class BABMEFKJJGE
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum DEGGIMDEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum FEBOLLMMNND
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum DGAKJPHLAEI
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[ThreadStatic]
	private static byte[] GJMHBNIIJIE;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] MCCIHOIPHMA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] JCOCGFANJBA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] AAPEBMCCIAM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly DGAKJPHLAEI CCMIOPPAIGH;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char AMJBEOPLPML;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int KGCFKCILJAH;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int PECFOFILKMO;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] KJGDHLMIEEG;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x53CEA50", Offset = "0x53CDC50", VA = "0x1853CEA50")]
	private static byte[] ICLJJPJEEHI(int PCAHMJECHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x53CED10", Offset = "0x53CDF10", VA = "0x1853CED10")]
	private static byte[] JDHEKAECCGI(int PCAHMJECHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x53CFF20", Offset = "0x53CF120", VA = "0x1853CFF20")]
	public static int PFAAGCBPJKK(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, float JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x53D0040", Offset = "0x53CF240", VA = "0x1853D0040")]
	public static int PFAAGCBPJKK(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, double JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x53CF7C0", Offset = "0x53CE9C0", VA = "0x1853CF7C0")]
	private static bool OLGKMDJCLGP(byte[] IEGPGBKLAIF, int ONCBCCLEFOH, ulong DEDOLDAEKHO, ulong LFLENDCEJMA, ulong IFCGFMEPAHB, ulong OLBMNELBGFG, ulong LMIAMGJLLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x53CE930", Offset = "0x53CDB30", VA = "0x1853CE930")]
	private static void HLFKHHJGPCE(uint NDBINFPGNDL, int NBJPPKNPFOO, out uint LEDBDMFAIOB, out int HLOJLNFDHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x53CEFA0", Offset = "0x53CE1A0", VA = "0x1853CEFA0")]
	private static bool NNHJMAKJJOE(IFFICNKKECF BNFCMIKMLPJ, IFFICNKKECF ONCKMLEEMNO, IFFICNKKECF MPIAPABHKNL, byte[] IEGPGBKLAIF, out int ONCBCCLEFOH, out int EJNNKONGFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x53CE3E0", Offset = "0x53CD5E0", VA = "0x1853CE3E0")]
	private static bool DKCOCGAHBHP(double AEOKKHKBMBB, DEGGIMDEBLJ PDGDINPCGGH, byte[] IEGPGBKLAIF, out int ONCBCCLEFOH, out int PKFFIDPHBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x53CE2D0", Offset = "0x53CD4D0", VA = "0x1853CE2D0")]
	private static bool AGBLMNFIMDG(double AEOKKHKBMBB, DEGGIMDEBLJ PDGDINPCGGH, byte[] IEGPGBKLAIF, out int ONCBCCLEFOH, out int DHKHFCMFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x53CE7A0", Offset = "0x53CD9A0", VA = "0x1853CE7A0")]
	private static bool GFOCFOPMAMI(double JFBPNBNBHOE, ref FMMNMNJCIMG NKKJANEOHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x53CF8C0", Offset = "0x53CEAC0", VA = "0x1853CF8C0")]
	private static bool OMMOHENEPPC(double JFBPNBNBHOE, ref FMMNMNJCIMG NKKJANEOHPD, FEBOLLMMNND PDGDINPCGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x53CEB30", Offset = "0x53CDD30", VA = "0x1853CEB30")]
	private static void IONBCFFLLFO(byte[] JAJABKENINL, int ONCBCCLEFOH, int DHKHFCMFLPL, int CHHNBIIJKKL, ref FMMNMNJCIMG NKKJANEOHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x53CF4C0", Offset = "0x53CE6C0", VA = "0x1853CF4C0")]
	private static void OKHIKMNFONE(byte[] JAJABKENINL, int ONCBCCLEFOH, int DFCACCOGAIG, ref FMMNMNJCIMG NKKJANEOHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x53CEDF0", Offset = "0x53CDFF0", VA = "0x1853CEDF0")]
	private static bool LKEFNOGPMHA(double AEOKKHKBMBB, FEBOLLMMNND PDGDINPCGGH, int PJNCBCAJKKO, byte[] DMNJDFAECAO, out bool BKGHGGNEJHB, out int ONCBCCLEFOH, out int CKJEELMDBEC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct HAHGIMHBCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double ABLKMJLKIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong NIFIKHJOJHD;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct IEIALHNGGBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float JBOJGNNLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint DDHHDCKADLG;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct HPAEIGJIFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong HPANBAGLKBN;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x50F7000", Offset = "0x50F6200", VA = "0x1850F7000")]
	public HPAEIGJIFFG(double ABLKMJLKIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x50F6F60", Offset = "0x50F6160", VA = "0x1850F6F60")]
	public HPAEIGJIFFG(IFFICNKKECF ABLKMJLKIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x50F6B70", Offset = "0x50F5D70", VA = "0x1850F6B70")]
	public IFFICNKKECF GNHMFFCAAFJ()
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x50F6D20", Offset = "0x50F5F20", VA = "0x1850F6D20")]
	public IFFICNKKECF KDJEEFNMDIE()
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C7000", Offset = "0x6C6200", VA = "0x1806C7000")]
	public ulong NDPCECIENEN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x50F6AE0", Offset = "0x50F5CE0", VA = "0x1850F6AE0")]
	public double FGCBKDFDKNG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x50F6A00", Offset = "0x50F5C00", VA = "0x1850F6A00")]
	public double BPNKDAOCHFK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x50F6C20", Offset = "0x50F5E20", VA = "0x1850F6C20")]
	public int IEAKIKBIAGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x50F6BF0", Offset = "0x50F5DF0", VA = "0x1850F6BF0")]
	public ulong HKGBIIADNOH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x50F6990", Offset = "0x50F5B90", VA = "0x1850F6990")]
	public bool AJLHINPFOAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x50F6A90", Offset = "0x50F5C90", VA = "0x1850F6A90")]
	public bool DPFPKNKADKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x50F6AB0", Offset = "0x50F5CB0", VA = "0x1850F6AB0")]
	public bool EBKEOCIIMMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x50F6DB0", Offset = "0x50F5FB0", VA = "0x1850F6DB0")]
	public bool KECHOOHNMEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x50F6D00", Offset = "0x50F5F00", VA = "0x1850F6D00")]
	public int JGPOFHGOHGL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x50F6DF0", Offset = "0x50F5FF0", VA = "0x1850F6DF0")]
	public void NHLBFKCCGPI(out IFFICNKKECF KAFCEMMEAGI, out IFFICNKKECF AKPEJPKNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x50F69B0", Offset = "0x50F5BB0", VA = "0x1850F69B0")]
	public bool BGGNLNHHKNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x50F6CF0", Offset = "0x50F5EF0", VA = "0x1850F6CF0")]
	public double JFBPNBNBHOE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x50F6F40", Offset = "0x50F6140", VA = "0x1850F6F40")]
	public static int PHDDPGNIPAM(int FGLCLGEEKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x50F6DE0", Offset = "0x50F5FE0", VA = "0x1850F6DE0")]
	public static double KJKIFNCLCDF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x50F6C50", Offset = "0x50F5E50", VA = "0x1850F6C50")]
	public static ulong IJEMOJNMJHH(IFFICNKKECF KLODAIBHOHF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct DFKJDJBIOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint ECEHJEDBBCF;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E31D20", Offset = "0x2E30F20", VA = "0x182E31D20")]
	public DFKJDJBIOHB(float JBOJGNNLCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x50EDA90", Offset = "0x50ECC90", VA = "0x1850EDA90")]
	public IFFICNKKECF GNHMFFCAAFJ()
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20")]
	public uint BJIBDIKELGB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x50EDB10", Offset = "0x50ECD10", VA = "0x1850EDB10")]
	public int IEAKIKBIAGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x50EDAF0", Offset = "0x50ECCF0", VA = "0x1850EDAF0")]
	public uint HKGBIIADNOH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x50EDA40", Offset = "0x50ECC40", VA = "0x1850EDA40")]
	public bool AJLHINPFOAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x50EDB30", Offset = "0x50ECD30", VA = "0x1850EDB30")]
	public void NHLBFKCCGPI(out IFFICNKKECF KAFCEMMEAGI, out IFFICNKKECF AKPEJPKNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x50EDA50", Offset = "0x50ECC50", VA = "0x1850EDA50")]
	public bool BGGNLNHHKNC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct POPGMPLOGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong PAOJMJOOEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short OCMKCDEKMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short PKFFIDPHBCG;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x50BF9B0", Offset = "0x50BEBB0", VA = "0x1850BF9B0")]
	public POPGMPLOGGE(ulong PAOJMJOOEAH, short OCMKCDEKMMP, short PKFFIDPHBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class CLGMBDOOOCA
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly POPGMPLOGGE[] HBJCHMDEDNM;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x53DAE10", Offset = "0x53DA010", VA = "0x1853DAE10")]
	public static void FKCJHAIIBOO(int AHDDPKKJFPC, int OOAJFPDEAHL, out IFFICNKKECF LEDBDMFAIOB, out int PKFFIDPHBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x53DAD10", Offset = "0x53D9F10", VA = "0x1853DAD10")]
	public static void AFKHNHGGGIK(int PLJGAPHDDEP, out IFFICNKKECF LEDBDMFAIOB, out int CPIIEKGCJAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct FJGEJJLKKFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] NPNCGJAPKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int IDCHKLCNMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NFPLKPKGBMD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x50F2000", Offset = "0x50F1200", VA = "0x1850F2000")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xC13F30", Offset = "0xC13130", VA = "0x180C13F30")]
	public FJGEJJLKKFI(byte[] NPNCGJAPKIL, int IDCHKLCNMBN, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E1340", Offset = "0x7E0540", VA = "0x1807E1340")]
	public int ONCBCCLEFOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x50F1FA0", Offset = "0x50F11A0", VA = "0x1850F1FA0")]
	public FJGEJJLKKFI DMOOGLMOIEA(int JFKLAOAGCCB, int BMJHAAKDFMA)
	{
		return default(FJGEJJLKKFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class ALOEFOBICAN
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CDMHEKOHFFN;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] MHECDFBECBO;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int BAPFGCGFDHC;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x53C7380", Offset = "0x53C6580", VA = "0x1853C7380")]
	private static byte[] BCEMCIHNCLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x53C89B0", Offset = "0x53C7BB0", VA = "0x1853C89B0")]
	private static FJGEJJLKKFI OOPEAFNFFAM(FJGEJJLKKFI IEGPGBKLAIF)
	{
		return default(FJGEJJLKKFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x53C84B0", Offset = "0x53C76B0", VA = "0x1853C84B0")]
	private static FJGEJJLKKFI LOMGAHDADLN(FJGEJJLKKFI IEGPGBKLAIF)
	{
		return default(FJGEJJLKKFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x53C7470", Offset = "0x53C6670", VA = "0x1853C7470")]
	private static void DBLBIFOFDDB(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG, byte[] DEGLJFFDMOE, out int CAFIGJGIBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x53C8210", Offset = "0x53C7410", VA = "0x1853C8210")]
	private static void LLDPMPPDCEF(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG, byte[] CKDGANBCOHE, int LGOEFNMFLFL, out FJGEJJLKKFI INCEHDPPNMI, out int IEHOENNHIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x53C8180", Offset = "0x53C7380", VA = "0x1853C8180")]
	private static ulong LKLGNDDGAAA(FJGEJJLKKFI IEGPGBKLAIF, out int KDOEKCNBALF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x53C8860", Offset = "0x53C7A60", VA = "0x1853C8860")]
	private static void MAMFHMGOOKC(FJGEJJLKKFI IEGPGBKLAIF, out IFFICNKKECF APCBFLNDMMJ, out int PIJGMNHLHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x53C7530", Offset = "0x53C6730", VA = "0x1853C7530")]
	private static bool DECDCEOCEMA(FJGEJJLKKFI INCEHDPPNMI, int DFCACCOGAIG, out double APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x53C7FD0", Offset = "0x53C71D0", VA = "0x1853C7FD0")]
	private static IFFICNKKECF ILBJMCDEABC(int DFCACCOGAIG)
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x53C7920", Offset = "0x53C6B20", VA = "0x1853C7920")]
	private static bool DKDAMIHEJHF(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG, out double APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x53C7E90", Offset = "0x53C7090", VA = "0x1853C7E90")]
	private static bool HLIGKPOHKFP(FJGEJJLKKFI INCEHDPPNMI, int DFCACCOGAIG, out double DBHOJLOENNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x53C8560", Offset = "0x53C7760", VA = "0x1853C8560")]
	public static double? LPECKKMDMOK(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x53C8680", Offset = "0x53C7880", VA = "0x1853C8680")]
	public static float? MAAKDOAGJIM(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct NICOJCFNMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] IEGPGBKLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int ELOEOOGBENM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x50B7D40", Offset = "0x50B6F40", VA = "0x1850B7D40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EB0", Offset = "0x7E70B0", VA = "0x1807E7EB0")]
	public NICOJCFNMJB(byte[] IEGPGBKLAIF, int ELOEOOGBENM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x50B7CE0", Offset = "0x50B6EE0", VA = "0x1850B7CE0")]
	public static NICOJCFNMJB HHJHJGJNLCE(NICOJCFNMJB PKCJMFFNILJ)
	{
		return default(NICOJCFNMJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x50B7C20", Offset = "0x50B6E20", VA = "0x1850B7C20")]
	public static NICOJCFNMJB FOACHAMOMCH(NICOJCFNMJB PKCJMFFNILJ, int ONCBCCLEFOH)
	{
		return default(NICOJCFNMJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x50B7DD0", Offset = "0x50B6FD0", VA = "0x1850B7DD0")]
	public static int ONNNIIHIBPF(NICOJCFNMJB KPCLHBOMAKO, NICOJCFNMJB NFBNADMIDIB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x50B7C70", Offset = "0x50B6E70", VA = "0x1850B7C70")]
	public static bool GJOJIEKGOHO(NICOJCFNMJB KPCLHBOMAKO, NICOJCFNMJB NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x50B7BB0", Offset = "0x50B6DB0", VA = "0x1850B7BB0")]
	public static bool ALCENKEOHOJ(NICOJCFNMJB KPCLHBOMAKO, NICOJCFNMJB NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x50B7C90", Offset = "0x50B6E90", VA = "0x1850B7C90")]
	public static bool GJOJIEKGOHO(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x50B7B60", Offset = "0x50B6D60", VA = "0x1850B7B60")]
	public static bool ALCENKEOHOJ(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x50B7B60", Offset = "0x50B6D60", VA = "0x1850B7B60")]
	public static bool ALCENKEOHOJ(NICOJCFNMJB KPCLHBOMAKO, byte NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x50B7D80", Offset = "0x50B6F80", VA = "0x1850B7D80")]
	public static bool NKKNDMACBNB(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x50B7CF0", Offset = "0x50B6EF0", VA = "0x1850B7CF0")]
	public static bool HLFPCDHPGHG(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x50B7BD0", Offset = "0x50B6DD0", VA = "0x1850B7BD0")]
	public static bool ALFHADPLCNH(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x50B7DF0", Offset = "0x50B6FF0", VA = "0x1850B7DF0")]
	public static bool PIBDJFGGKII(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class BAAMHDAFCIG
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] IGOOBKLHPDM;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] BMOOJGNFGPC;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] JCOCGFANJBA;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] AAPEBMCCIAM;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] OKLDONDEHJB;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int GNOIJADPPJP;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] HIDLLGHIFHM;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int CFPCOAKNPNM;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x53CDBC0", Offset = "0x53CCDC0", VA = "0x1853CDBC0")]
	private static byte[] KEFCAMGPPIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x53CD900", Offset = "0x53CCB00", VA = "0x1853CD900")]
	private static byte[] EPNPKABABKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x53CDFB0", Offset = "0x53CD1B0", VA = "0x1853CDFB0")]
	public static double POCFKJIMFJH(byte[] IEGPGBKLAIF, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x53CD9F0", Offset = "0x53CCBF0", VA = "0x1853CD9F0")]
	public static float GILDFGADNCD(byte[] IEGPGBKLAIF, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x53CDCB0", Offset = "0x53CCEB0", VA = "0x1853CDCB0")]
	private static bool KNIOAIPHAFN(int BIAIPPDLOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x53CDE50", Offset = "0x53CD050", VA = "0x1853CDE50")]
	private static bool MKPMKPJDABE(ref NICOJCFNMJB BEKIFNKENPL, NICOJCFNMJB HEGLMOCOEGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x53CDAB0", Offset = "0x53CCCB0", VA = "0x1853CDAB0")]
	private static bool JJBMAMCPKEF(ref NICOJCFNMJB BEKIFNKENPL, NICOJCFNMJB HEGLMOCOEGO, byte[] JDFFPGPNNEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x53CDF60", Offset = "0x53CD160", VA = "0x1853CDF60")]
	private static bool OFGBKAOJJLL(ref NICOJCFNMJB HCCDBMBFABP, byte[] IGMDKJEALIM, int ELOEOOGBENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x53CDE30", Offset = "0x53CD030", VA = "0x1853CDE30")]
	private static double LPKLFJLEAID(bool BKGHGGNEJHB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x53CC670", Offset = "0x53CB870", VA = "0x1853CC670")]
	private static double CNNLELHPIJI(NICOJCFNMJB ADKJIBICKCJ, int ONCBCCLEFOH, bool LAMHECKOLOE, out int NFOLGCAOKPP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class AAHPCJIICFB<T> : global::JJBJICJFEAB<T[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::NNLGPMNIGEN<T> HBFNMECGFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly MJAPBCCONDF GKCAAFCMMMA;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x33E3F70", Offset = "0x33E3170", VA = "0x1833E3F70")]
	public AAHPCJIICFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1DA40C0", Offset = "0x1DA32C0", VA = "0x181DA40C0")]
	public AAHPCJIICFB(MJAPBCCONDF GKCAAFCMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x33E1900", Offset = "0x33E0B00", VA = "0x1833E1900", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x33E29C0", Offset = "0x33E1BC0", VA = "0x1833E29C0", Slot = "5")]
	public T[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class ANKDIADPEFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::NNLGPMNIGEN<T> HBFNMECGFLJ;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class MBEFPKKDJJN<T> : global::JJBJICJFEAB<List<T>>, PKHFALLONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly MJAPBCCONDF GKCAAFCMMMA;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x33E3F70", Offset = "0x33E3170", VA = "0x1833E3F70")]
	public MBEFPKKDJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1DA40C0", Offset = "0x1DA32C0", VA = "0x181DA40C0")]
	public MBEFPKKDJJN(MJAPBCCONDF GKCAAFCMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6140", Offset = "0x3AE5340", VA = "0x183AE6140", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, List<T> JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6F50", Offset = "0x3AE6150", VA = "0x183AE6F50", Slot = "5")]
	public List<T> LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class JMFHMGPBKCL<TElement, TIntermediate, TEnumerator, TCollection> : global::JJBJICJFEAB<TCollection>, PKHFALLONLG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3B1FF90", Offset = "0x3B1F190", VA = "0x183B1FF90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, TCollection JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3B20AF0", Offset = "0x3B1FCF0", VA = "0x183B20AF0", Slot = "5")]
	public TCollection LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator AAODCIKMEEL(TCollection GEMNKBDIDNJ);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate BFPHDDBHNEE();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AOHLLDNPMGN(ref TIntermediate HGLAIHECBOI, int BELCAJFDAHD, TElement JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection HPPHODAOIFC(ref TIntermediate CALGKPKIHAM);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	protected JMFHMGPBKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class JDGNDGNOJGO<TElement, TIntermediate, TCollection> : global::JMFHMGPBKCL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x269A700", Offset = "0x2699900", VA = "0x18269A700", Slot = "6")]
	protected override IEnumerator<TElement> AAODCIKMEEL(TCollection GEMNKBDIDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x246D140", Offset = "0x246C340", VA = "0x18246D140")]
	protected JDGNDGNOJGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class ANLIKJFOFCM<TElement, TCollection> : global::JDGNDGNOJGO<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected sealed override TCollection HPPHODAOIFC(ref TCollection CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class AIHKBGPLHDO<TElement, TCollection> : global::ANLIKJFOFCM<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BC50", Offset = "0x2A3AE50", VA = "0x182A3BC50", Slot = "7")]
	protected override TCollection BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BB70", Offset = "0x2A3AD70", VA = "0x182A3BB70", Slot = "8")]
	protected override void AOHLLDNPMGN(ref TCollection HGLAIHECBOI, int BELCAJFDAHD, TElement JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class ONCEMGKJJIN<T> : global::JMFHMGPBKCL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x234ADB0", Offset = "0x2349FB0", VA = "0x18234ADB0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref LinkedList<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override LinkedList<T> HPPHODAOIFC(ref LinkedList<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override LinkedList<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x26501E0", Offset = "0x264F3E0", VA = "0x1826501E0", Slot = "6")]
	protected override LinkedList<T>.Enumerator AAODCIKMEEL(LinkedList<T> GEMNKBDIDNJ)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class KIACIEOEJKO<T> : global::JMFHMGPBKCL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x234ADB0", Offset = "0x2349FB0", VA = "0x18234ADB0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref Queue<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override Queue<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x234AD60", Offset = "0x2349F60", VA = "0x18234AD60", Slot = "6")]
	protected override Queue<T>.Enumerator AAODCIKMEEL(Queue<T> GEMNKBDIDNJ)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override Queue<T> HPPHODAOIFC(ref Queue<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class AJPEKGAKJCO<T> : global::JMFHMGPBKCL<T, global::LFCMPLINDCF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2699510", Offset = "0x2698710", VA = "0x182699510", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2699540", Offset = "0x2698740", VA = "0x182699540", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x234AD60", Offset = "0x2349F60", VA = "0x18234AD60", Slot = "6")]
	protected override Stack<T>.Enumerator AAODCIKMEEL(Stack<T> GEMNKBDIDNJ)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2A44850", Offset = "0x2A43A50", VA = "0x182A44850", Slot = "9")]
	protected override Stack<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class OHJGJMELKKN<T> : global::JMFHMGPBKCL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x234ADB0", Offset = "0x2349FB0", VA = "0x18234ADB0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref HashSet<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override HashSet<T> HPPHODAOIFC(ref HashSet<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override HashSet<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x234AD60", Offset = "0x2349F60", VA = "0x18234AD60", Slot = "6")]
	protected override HashSet<T>.Enumerator AAODCIKMEEL(HashSet<T> GEMNKBDIDNJ)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class IAEKEMBMNAB<T> : global::JDGNDGNOJGO<T, global::LFCMPLINDCF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2699510", Offset = "0x2698710", VA = "0x182699510", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3431C20", Offset = "0x3430E20", VA = "0x183431C20", Slot = "9")]
	protected override ReadOnlyCollection<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3431BE0", Offset = "0x3430DE0", VA = "0x183431BE0", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class DNKBHKCPFGM<T> : global::JDGNDGNOJGO<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x234ADB0", Offset = "0x2349FB0", VA = "0x18234ADB0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref List<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override List<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override IList<T> HPPHODAOIFC(ref List<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BECJIJBADOF<T> : global::JDGNDGNOJGO<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x234ADB0", Offset = "0x2349FB0", VA = "0x18234ADB0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref List<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override List<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override ICollection<T> HPPHODAOIFC(ref List<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class PCMMFEDDNFM<T> : global::JDGNDGNOJGO<T, global::LFCMPLINDCF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2699510", Offset = "0x2698710", VA = "0x182699510", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2699540", Offset = "0x2698740", VA = "0x182699540", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2699580", Offset = "0x2698780", VA = "0x182699580", Slot = "9")]
	protected override IEnumerable<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class IEOGJNGDPDO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class KCCONJCLCBB<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class NEKBJPIPIOO<T> : global::JJBJICJFEAB<T>, PKHFALLONLG where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2B66AB0", Offset = "0x2B65CB0", VA = "0x182B66AB0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2B66D70", Offset = "0x2B65F70", VA = "0x182B66D70", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	public NEKBJPIPIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class BMJJCMENCGE : global::JJBJICJFEAB<IEnumerable>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::JJBJICJFEAB<IEnumerable> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x53D9690", Offset = "0x53D8890", VA = "0x1853D9690", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, IEnumerable JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x53D9900", Offset = "0x53D8B00", VA = "0x1853D9900", Slot = "5")]
	public IEnumerable LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public BMJJCMENCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class JCCCLMFNAEL : global::JJBJICJFEAB<ICollection>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::JJBJICJFEAB<ICollection> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x50FBA00", Offset = "0x50FAC00", VA = "0x1850FBA00", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ICollection JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x50FBCC0", Offset = "0x50FAEC0", VA = "0x1850FBCC0", Slot = "5")]
	public ICollection LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JCCCLMFNAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class HJJMFMBAICH : global::JJBJICJFEAB<IList>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::JJBJICJFEAB<IList> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x50F57A0", Offset = "0x50F49A0", VA = "0x1850F57A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, IList JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x50F5A60", Offset = "0x50F4C60", VA = "0x1850F5A60", Slot = "5")]
	public IList LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HJJMFMBAICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DAJGOGMGLNN<T> : global::JDGNDGNOJGO<T, global::LFCMPLINDCF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2959B50", Offset = "0x2958D50", VA = "0x182959B50", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2699540", Offset = "0x2698740", VA = "0x182699540", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2959B80", Offset = "0x2958D80", VA = "0x182959B80", Slot = "9")]
	protected override IReadOnlyList<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x229BF40", Offset = "0x229B140", VA = "0x18229BF40")]
	public DAJGOGMGLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class EOANOHNJFKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x50EF820", Offset = "0x50EEA20", VA = "0x1850EF820")]
	public static DateTime JFKACEOKBAK(DateTime GOMAJLJDCFP)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class EPGLJBJGLFD : global::JJBJICJFEAB<DateTime>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::JJBJICJFEAB<DateTime> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x50F0280", Offset = "0x50EF480", VA = "0x1850F0280", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, DateTime JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x50F06E0", Offset = "0x50EF8E0", VA = "0x1850F06E0", Slot = "5")]
	public DateTime LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EPGLJBJGLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GNDFHMNKPFG : global::JJBJICJFEAB<DateTimeOffset>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::JJBJICJFEAB<DateTimeOffset> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x50F3C80", Offset = "0x50F2E80", VA = "0x1850F3C80", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, DateTimeOffset JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x50F4060", Offset = "0x50F3260", VA = "0x1850F4060", Slot = "5")]
	public DateTimeOffset LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GNDFHMNKPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class EJNPBDKFNLC : global::JJBJICJFEAB<TimeSpan>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::JJBJICJFEAB<TimeSpan> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] CAANGHPOCPG;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x50EE380", Offset = "0x50ED580", VA = "0x1850EE380", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, TimeSpan JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x50EE650", Offset = "0x50ED850", VA = "0x1850EE650", Slot = "5")]
	public TimeSpan LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EJNPBDKFNLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class HCIEGCIOLLJ<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::JJBJICJFEAB<TDictionary>, PKHFALLONLG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3C00730", Offset = "0x3BFF930", VA = "0x183C00730", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, TDictionary JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3C018B0", Offset = "0x3C00AB0", VA = "0x183C018B0", Slot = "5")]
	public TDictionary LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator AAODCIKMEEL(TDictionary GEMNKBDIDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate BFPHDDBHNEE();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AOHLLDNPMGN(ref TIntermediate HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary HPPHODAOIFC(ref TIntermediate CALGKPKIHAM);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	protected HCIEGCIOLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class PDJIADNPMKO<TKey, TValue, TIntermediate, TDictionary> : global::HCIEGCIOLLJ<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x269A700", Offset = "0x2699900", VA = "0x18269A700", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> AAODCIKMEEL(TDictionary GEMNKBDIDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class ALJCAHPCHPH<TKey, TValue, TDictionary> : global::PDJIADNPMKO<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override TDictionary HPPHODAOIFC(ref TDictionary CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HKIHDFEHKON<TKey, TValue> : global::HCIEGCIOLLJ<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x361D7F0", Offset = "0x361C9F0", VA = "0x18361D7F0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref Dictionary<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override Dictionary<TKey, TValue> HPPHODAOIFC(ref Dictionary<TKey, TValue> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override Dictionary<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x361D7A0", Offset = "0x361C9A0", VA = "0x18361D7A0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator AAODCIKMEEL(Dictionary<TKey, TValue> GEMNKBDIDNJ)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2355820", Offset = "0x2354A20", VA = "0x182355820")]
	public HKIHDFEHKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class CEJJPLOPGEH<TKey, TValue, TDictionary> : global::ALJCAHPCHPH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE490", Offset = "0x2AED690", VA = "0x182AEE490", Slot = "8")]
	protected override void AOHLLDNPMGN(ref TDictionary HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9F90", Offset = "0x1DA9190", VA = "0x181DA9F90", Slot = "7")]
	protected override TDictionary BFPHDDBHNEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class NKPONDLLIPL<TKey, TValue> : global::PDJIADNPMKO<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x239B4D0", Offset = "0x239A6D0", VA = "0x18239B4D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref Dictionary<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override Dictionary<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override IDictionary<TKey, TValue> HPPHODAOIFC(ref Dictionary<TKey, TValue> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class AACLIJIGMAF<TKey, TValue> : global::ALJCAHPCHPH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x239B4D0", Offset = "0x239A6D0", VA = "0x18239B4D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref SortedList<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override SortedList<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class FFCCPOCJPNK<TKey, TValue> : global::HCIEGCIOLLJ<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x239B4D0", Offset = "0x239A6D0", VA = "0x18239B4D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref SortedDictionary<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xFDA1B0", Offset = "0xFD93B0", VA = "0x180FDA1B0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> HPPHODAOIFC(ref SortedDictionary<TKey, TValue> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x234ADF0", Offset = "0x2349FF0", VA = "0x18234ADF0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x239B470", Offset = "0x239A670", VA = "0x18239B470", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator AAODCIKMEEL(SortedDictionary<TKey, TValue> GEMNKBDIDNJ)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LJGGOOJGDJM<T> : global::JJBJICJFEAB<T>, PKHFALLONLG where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x37E7CD0", Offset = "0x37E6ED0", VA = "0x1837E7CD0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x37E8080", Offset = "0x37E7280", VA = "0x1837E8080", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	public LJGGOOJGDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class OCJKNMAMKKJ : global::JJBJICJFEAB<IDictionary>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::JJBJICJFEAB<IDictionary> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x50B96C0", Offset = "0x50B88C0", VA = "0x1850B96C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, IDictionary JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x50B9A70", Offset = "0x50B8C70", VA = "0x1850B9A70", Slot = "5")]
	public IDictionary LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public OCJKNMAMKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MOGJNJLCKNC : global::JJBJICJFEAB<object>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void NKBGAHFJNNF(object NDPIKDFKMJF, ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::MEEGMHDFAGF<KeyValuePair<object, NKBGAHFJNNF>> ANLABGKNJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly LMDOKLNJEDM[] JFFCCJJMICB;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x50B68F0", Offset = "0x50B5AF0", VA = "0x1850B68F0")]
	public MOGJNJLCKNC(params LMDOKLNJEDM[] JFFCCJJMICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x50B5E70", Offset = "0x50B5070", VA = "0x1850B5E70", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x50B6850", Offset = "0x50B5A50", VA = "0x1850B6850", Slot = "5")]
	public object LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class KGHEEMNCMFE
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5100350", Offset = "0x50FF550", VA = "0x185100350")]
	public static object DOBINCCPGJK(Type DDJDPMGLPAE, out bool PNMCAHONCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5100C70", Offset = "0x50FFE70", VA = "0x185100C70")]
	public static object IIBKIFLGFJO(Type DDJDPMGLPAE, out bool PNMCAHONCKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class POLOIOBDGKE<T> : global::JJBJICJFEAB<T>, PKHFALLONLG, global::HHJPHCMFBDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class DOILGANOICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public DOILGANOICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A24900", Offset = "0x2A23B00", VA = "0x182A24900")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class FPHKNIIHHAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::OAMKLMHLDAO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public FPHKNIIHHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x304B250", Offset = "0x304A450", VA = "0x18304B250")]
		internal void <.cctor>b__1(ref AOONEBAFBIP writer, T value, LMDOKLNJEDM _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class IABHGOHLCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::GHBJCJPAPDG<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public IABHGOHLCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x342DDF0", Offset = "0x342CFF0", VA = "0x18342DDF0")]
		internal T <.cctor>b__2(ref IIHLGBHCEFK reader, LMDOKLNJEDM _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::LFOALGNFDPH<T> PMHMPGINLLN;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> PDPBCGDHGNA;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::OAMKLMHLDAO<T> IFKOKPBPPON;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::GHBJCJPAPDG<T> BILJKEDCDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool EFIBJDBIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::OAMKLMHLDAO<T> AJALAGJLLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::GHBJCJPAPDG<T> AEMBJLIDJHL;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F77580", Offset = "0x3F76780", VA = "0x183F77580")]
	static POLOIOBDGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x28C79F0", Offset = "0x28C6BF0", VA = "0x1828C79F0")]
	public POLOIOBDGKE(bool EFIBJDBIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F65050", Offset = "0x3F64250", VA = "0x183F65050", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F68720", Offset = "0x3F67920", VA = "0x183F68720", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F633E0", Offset = "0x3F625E0", VA = "0x183F633E0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F6BB70", Offset = "0x3F6AD70", VA = "0x183F6BB70", Slot = "7")]
	public T OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class NNGKCNHJECN<T> : global::JJBJICJFEAB<T[,]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x311C940", Offset = "0x311BB40", VA = "0x18311C940", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[,] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x311CAF0", Offset = "0x311BCF0", VA = "0x18311CAF0", Slot = "5")]
	public T[,] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	public NNGKCNHJECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class FOLOHLPEMBA<T> : global::JJBJICJFEAB<T[,,]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x30489F0", Offset = "0x3047BF0", VA = "0x1830489F0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[,,] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3048C00", Offset = "0x3047E00", VA = "0x183048C00", Slot = "5")]
	public T[,,] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	public FOLOHLPEMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class ODACLIFGJBO<T> : global::JJBJICJFEAB<T[,,,]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3814610", Offset = "0x3813810", VA = "0x183814610", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[,,,] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x38148B0", Offset = "0x3813AB0", VA = "0x1838148B0", Slot = "5")]
	public T[,,,] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	public ODACLIFGJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class PBFCEHCAEMD<T> : global::JJBJICJFEAB<T?>, PKHFALLONLG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2694E50", Offset = "0x2694050", VA = "0x182694E50", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2695260", Offset = "0x2694460", VA = "0x182695260", Slot = "5")]
	public T? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	public PBFCEHCAEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class PNBFANOOKGP<T> : global::JJBJICJFEAB<T?>, PKHFALLONLG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::JJBJICJFEAB<T> CGFFLAMBJBI;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CD01B0", Offset = "0x1CCF3B0", VA = "0x181CD01B0")]
	public PNBFANOOKGP(global::JJBJICJFEAB<T> CGFFLAMBJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4549D80", Offset = "0x4548F80", VA = "0x184549D80")]
	public PNBFANOOKGP(Type DDIMAINKNPP, object[] OGKJLCLAGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4548B90", Offset = "0x4547D90", VA = "0x184548B90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x45490C0", Offset = "0x45482C0", VA = "0x1845490C0", Slot = "5")]
	public T? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class IIIPKHOGHBG : global::JJBJICJFEAB<sbyte>, PKHFALLONLG, global::HHJPHCMFBDC<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly IIIPKHOGHBG HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x50FA0A0", Offset = "0x50F92A0", VA = "0x1850FA0A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, sbyte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x50FA0C0", Offset = "0x50F92C0", VA = "0x1850FA0C0", Slot = "5")]
	public sbyte LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x50FA060", Offset = "0x50F9260", VA = "0x1850FA060", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, sbyte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x50FA110", Offset = "0x50F9310", VA = "0x1850FA110", Slot = "7")]
	public sbyte OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IIIPKHOGHBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class KEOHCIKKGMC : global::JJBJICJFEAB<sbyte?>, PKHFALLONLG, global::HHJPHCMFBDC<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly KEOHCIKKGMC HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x50FFBD0", Offset = "0x50FEDD0", VA = "0x1850FFBD0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, sbyte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x50FFC50", Offset = "0x50FEE50", VA = "0x1850FFC50", Slot = "5")]
	public sbyte? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x50FFB50", Offset = "0x50FED50", VA = "0x1850FFB50", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, sbyte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x50FFD00", Offset = "0x50FEF00", VA = "0x1850FFD00", Slot = "7")]
	public sbyte? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KEOHCIKKGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class NEJCIFLAHGP : global::JJBJICJFEAB<sbyte[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly NEJCIFLAHGP HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x50B6D90", Offset = "0x50B5F90", VA = "0x1850B6D90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, sbyte[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x50B6E50", Offset = "0x50B6050", VA = "0x1850B6E50", Slot = "5")]
	public sbyte[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NEJCIFLAHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class HKEHHPCPIHM : global::JJBJICJFEAB<short>, PKHFALLONLG, global::HHJPHCMFBDC<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly HKEHHPCPIHM HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x50F5D90", Offset = "0x50F4F90", VA = "0x1850F5D90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, short JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x50F5DB0", Offset = "0x50F4FB0", VA = "0x1850F5DB0", Slot = "5")]
	public short LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x50F5D50", Offset = "0x50F4F50", VA = "0x1850F5D50", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, short JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x50F5E10", Offset = "0x50F5010", VA = "0x1850F5E10", Slot = "7")]
	public short OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HKEHHPCPIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KIMKFCOGBFF : global::JJBJICJFEAB<short?>, PKHFALLONLG, global::HHJPHCMFBDC<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly KIMKFCOGBFF HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5101610", Offset = "0x5100810", VA = "0x185101610", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, short? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5101690", Offset = "0x5100890", VA = "0x185101690", Slot = "5")]
	public short? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5101590", Offset = "0x5100790", VA = "0x185101590", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, short? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5101740", Offset = "0x5100940", VA = "0x185101740", Slot = "7")]
	public short? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KIMKFCOGBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class ONNKEIBCILF : global::JJBJICJFEAB<short[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly ONNKEIBCILF HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x50BBD70", Offset = "0x50BAF70", VA = "0x1850BBD70", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, short[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x50BBE30", Offset = "0x50BB030", VA = "0x1850BBE30", Slot = "5")]
	public short[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ONNKEIBCILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class KPLFOJDJJBA : global::JJBJICJFEAB<int>, PKHFALLONLG, global::HHJPHCMFBDC<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly KPLFOJDJJBA HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x51023E0", Offset = "0x51015E0", VA = "0x1851023E0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, int JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x51023F0", Offset = "0x51015F0", VA = "0x1851023F0", Slot = "5")]
	public int LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x51023A0", Offset = "0x51015A0", VA = "0x1851023A0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, int JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5102450", Offset = "0x5101650", VA = "0x185102450", Slot = "7")]
	public int OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KPLFOJDJJBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GHIHPMCLGPF : global::JJBJICJFEAB<int?>, PKHFALLONLG, global::HHJPHCMFBDC<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly GHIHPMCLGPF HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x50F2F20", Offset = "0x50F2120", VA = "0x1850F2F20", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, int? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x50F2F90", Offset = "0x50F2190", VA = "0x1850F2F90", Slot = "5")]
	public int? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x50F2EA0", Offset = "0x50F20A0", VA = "0x1850F2EA0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, int? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x50F3040", Offset = "0x50F2240", VA = "0x1850F3040", Slot = "7")]
	public int? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GHIHPMCLGPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NDNBGHMOMKD : global::JJBJICJFEAB<int[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly NDNBGHMOMKD HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x50B69F0", Offset = "0x50B5BF0", VA = "0x1850B69F0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, int[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x50B6AB0", Offset = "0x50B5CB0", VA = "0x1850B6AB0", Slot = "5")]
	public int[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NDNBGHMOMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class KINNPFCJDFI : global::JJBJICJFEAB<long>, PKHFALLONLG, global::HHJPHCMFBDC<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly KINNPFCJDFI HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x51018A0", Offset = "0x5100AA0", VA = "0x1851018A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, long JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x51018C0", Offset = "0x5100AC0", VA = "0x1851018C0", Slot = "5")]
	public long LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5101860", Offset = "0x5100A60", VA = "0x185101860", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, long JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x51018D0", Offset = "0x5100AD0", VA = "0x1851018D0", Slot = "7")]
	public long OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KINNPFCJDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class CFKCALKCBBP : global::JJBJICJFEAB<long?>, PKHFALLONLG, global::HHJPHCMFBDC<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly CFKCALKCBBP HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x53DA270", Offset = "0x53D9470", VA = "0x1853DA270", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, long? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x53DA300", Offset = "0x53D9500", VA = "0x1853DA300", Slot = "5")]
	public long? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x53DA160", Offset = "0x53D9360", VA = "0x1853DA160", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, long? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x53DA390", Offset = "0x53D9590", VA = "0x1853DA390", Slot = "7")]
	public long? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CFKCALKCBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JGEJDGCEOFH : global::JJBJICJFEAB<long[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly JGEJDGCEOFH HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x50FC110", Offset = "0x50FB310", VA = "0x1850FC110", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, long[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x50FC1D0", Offset = "0x50FB3D0", VA = "0x1850FC1D0", Slot = "5")]
	public long[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JGEJDGCEOFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class ABKMNLGNALD : global::JJBJICJFEAB<byte>, PKHFALLONLG, global::HHJPHCMFBDC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly ABKMNLGNALD HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x53C6440", Offset = "0x53C5640", VA = "0x1853C6440", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, byte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x53C6480", Offset = "0x53C5680", VA = "0x1853C6480", Slot = "5")]
	public byte LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x53C6380", Offset = "0x53C5580", VA = "0x1853C6380", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, byte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x53C6490", Offset = "0x53C5690", VA = "0x1853C6490", Slot = "7")]
	public byte OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ABKMNLGNALD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class MKHBCIPHAKH : global::JJBJICJFEAB<byte?>, PKHFALLONLG, global::HHJPHCMFBDC<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly MKHBCIPHAKH HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x51044C0", Offset = "0x51036C0", VA = "0x1851044C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, byte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5104540", Offset = "0x5103740", VA = "0x185104540", Slot = "5")]
	public byte? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5104440", Offset = "0x5103640", VA = "0x185104440", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, byte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x51045F0", Offset = "0x51037F0", VA = "0x1851045F0", Slot = "7")]
	public byte? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MKHBCIPHAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class BCMMKABDFJO : global::JJBJICJFEAB<ushort>, PKHFALLONLG, global::HHJPHCMFBDC<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly BCMMKABDFJO HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x53D0450", Offset = "0x53CF650", VA = "0x1853D0450", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ushort JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x53D0490", Offset = "0x53CF690", VA = "0x1853D0490", Slot = "5")]
	public ushort LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x53D0390", Offset = "0x53CF590", VA = "0x1853D0390", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ushort JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x53D04A0", Offset = "0x53CF6A0", VA = "0x1853D04A0", Slot = "7")]
	public ushort OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public BCMMKABDFJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class GKIBOFINFNM : global::JJBJICJFEAB<ushort?>, PKHFALLONLG, global::HHJPHCMFBDC<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly GKIBOFINFNM HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x50F3350", Offset = "0x50F2550", VA = "0x1850F3350", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ushort? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x50F33D0", Offset = "0x50F25D0", VA = "0x1850F33D0", Slot = "5")]
	public ushort? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x50F32D0", Offset = "0x50F24D0", VA = "0x1850F32D0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ushort? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x50F3480", Offset = "0x50F2680", VA = "0x1850F3480", Slot = "7")]
	public ushort? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GKIBOFINFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class EGGOHKIEBMP : global::JJBJICJFEAB<ushort[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly EGGOHKIEBMP HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x50EDF60", Offset = "0x50ED160", VA = "0x1850EDF60", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ushort[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x50EE020", Offset = "0x50ED220", VA = "0x1850EE020", Slot = "5")]
	public ushort[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGGOHKIEBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class FGMHEGBOEBF : global::JJBJICJFEAB<uint>, PKHFALLONLG, global::HHJPHCMFBDC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly FGMHEGBOEBF HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x50F1E50", Offset = "0x50F1050", VA = "0x1850F1E50", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, uint JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x50F1E60", Offset = "0x50F1060", VA = "0x1850F1E60", Slot = "5")]
	public uint LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x50F1E10", Offset = "0x50F1010", VA = "0x1850F1E10", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, uint JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x50F1EC0", Offset = "0x50F10C0", VA = "0x1850F1EC0", Slot = "7")]
	public uint OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public FGMHEGBOEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class FANFHLDLECE : global::JJBJICJFEAB<uint?>, PKHFALLONLG, global::HHJPHCMFBDC<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly FANFHLDLECE HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x50F1910", Offset = "0x50F0B10", VA = "0x1850F1910", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, uint? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x50F1980", Offset = "0x50F0B80", VA = "0x1850F1980", Slot = "5")]
	public uint? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x50F1890", Offset = "0x50F0A90", VA = "0x1850F1890", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, uint? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x50F1A30", Offset = "0x50F0C30", VA = "0x1850F1A30", Slot = "7")]
	public uint? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public FANFHLDLECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class HOINJDOOPGL : global::JJBJICJFEAB<uint[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly HOINJDOOPGL HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x50F6640", Offset = "0x50F5840", VA = "0x1850F6640", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, uint[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x50F6700", Offset = "0x50F5900", VA = "0x1850F6700", Slot = "5")]
	public uint[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HOINJDOOPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class HDGCDFFDBJP : global::JJBJICJFEAB<ulong>, PKHFALLONLG, global::HHJPHCMFBDC<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly HDGCDFFDBJP HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x50F5420", Offset = "0x50F4620", VA = "0x1850F5420", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ulong JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x50F5440", Offset = "0x50F4640", VA = "0x1850F5440", Slot = "5")]
	public ulong LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x50F53E0", Offset = "0x50F45E0", VA = "0x1850F53E0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ulong JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x50F5450", Offset = "0x50F4650", VA = "0x1850F5450", Slot = "7")]
	public ulong OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HDGCDFFDBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class KJBCGLEDOHK : global::JJBJICJFEAB<ulong?>, PKHFALLONLG, global::HHJPHCMFBDC<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly KJBCGLEDOHK HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5101A40", Offset = "0x5100C40", VA = "0x185101A40", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ulong? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5101AC0", Offset = "0x5100CC0", VA = "0x185101AC0", Slot = "5")]
	public ulong? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x51019B0", Offset = "0x5100BB0", VA = "0x1851019B0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ulong? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5101B50", Offset = "0x5100D50", VA = "0x185101B50", Slot = "7")]
	public ulong? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KJBCGLEDOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class MELEMDMBLHE : global::JJBJICJFEAB<ulong[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly MELEMDMBLHE HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5103C50", Offset = "0x5102E50", VA = "0x185103C50", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ulong[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5103D10", Offset = "0x5102F10", VA = "0x185103D10", Slot = "5")]
	public ulong[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MELEMDMBLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class ANOKKPDLAOM : global::JJBJICJFEAB<float>, PKHFALLONLG, global::HHJPHCMFBDC<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly ANOKKPDLAOM HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x53C9310", Offset = "0x53C8510", VA = "0x1853C9310", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, float JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x53C9320", Offset = "0x53C8520", VA = "0x1853C9320", Slot = "5")]
	public float LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x53C9260", Offset = "0x53C8460", VA = "0x1853C9260", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, float JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x53C9330", Offset = "0x53C8530", VA = "0x1853C9330", Slot = "7")]
	public float OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ANOKKPDLAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class DHHNJFBKCMG : global::JJBJICJFEAB<float?>, PKHFALLONLG, global::HHJPHCMFBDC<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly DHHNJFBKCMG HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x50EDCE0", Offset = "0x50ECEE0", VA = "0x1850EDCE0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, float? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x50EDD60", Offset = "0x50ECF60", VA = "0x1850EDD60", Slot = "5")]
	public float? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x50EDC60", Offset = "0x50ECE60", VA = "0x1850EDC60", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, float? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x50EDDD0", Offset = "0x50ECFD0", VA = "0x1850EDDD0", Slot = "7")]
	public float? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public DHHNJFBKCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class NNJOILEAOBC : global::JJBJICJFEAB<float[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NNJOILEAOBC HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x50B7F20", Offset = "0x50B7120", VA = "0x1850B7F20", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, float[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x50B7FE0", Offset = "0x50B71E0", VA = "0x1850B7FE0", Slot = "5")]
	public float[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NNJOILEAOBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class NEHPJELDBEK : global::JJBJICJFEAB<double>, PKHFALLONLG, global::HHJPHCMFBDC<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly NEHPJELDBEK HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x50B6C90", Offset = "0x50B5E90", VA = "0x1850B6C90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, double JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x50B6CA0", Offset = "0x50B5EA0", VA = "0x1850B6CA0", Slot = "5")]
	public double LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x50B6C50", Offset = "0x50B5E50", VA = "0x1850B6C50", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, double JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x50B6CB0", Offset = "0x50B5EB0", VA = "0x1850B6CB0", Slot = "7")]
	public double OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NEHPJELDBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class ANEBKOJHNBI : global::JJBJICJFEAB<double?>, PKHFALLONLG, global::HHJPHCMFBDC<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly ANEBKOJHNBI HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x53C8C80", Offset = "0x53C7E80", VA = "0x1853C8C80", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, double? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x53C8D00", Offset = "0x53C7F00", VA = "0x1853C8D00", Slot = "5")]
	public double? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x53C8B70", Offset = "0x53C7D70", VA = "0x1853C8B70", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, double? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x53C8D90", Offset = "0x53C7F90", VA = "0x1853C8D90", Slot = "7")]
	public double? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ANEBKOJHNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class IMDLHEPFKGG : global::JJBJICJFEAB<double[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IMDLHEPFKGG HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x50FA1F0", Offset = "0x50F93F0", VA = "0x1850FA1F0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, double[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x50FA2B0", Offset = "0x50F94B0", VA = "0x1850FA2B0", Slot = "5")]
	public double[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IMDLHEPFKGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class KDOOLKPNCJE : global::JJBJICJFEAB<bool>, PKHFALLONLG, global::HHJPHCMFBDC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly KDOOLKPNCJE HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x50FFA40", Offset = "0x50FEC40", VA = "0x1850FFA40", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, bool JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x50FFA60", Offset = "0x50FEC60", VA = "0x1850FFA60", Slot = "5")]
	public bool LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x50FFA00", Offset = "0x50FEC00", VA = "0x1850FFA00", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, bool JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x50FFA70", Offset = "0x50FEC70", VA = "0x1850FFA70", Slot = "7")]
	public bool OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KDOOLKPNCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class CGKABLENNPO : global::JJBJICJFEAB<bool?>, PKHFALLONLG, global::HHJPHCMFBDC<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly CGKABLENNPO HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x53DA7A0", Offset = "0x53D99A0", VA = "0x1853DA7A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, bool? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x53DA820", Offset = "0x53D9A20", VA = "0x1853DA820", Slot = "5")]
	public bool? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x53DA6A0", Offset = "0x53D98A0", VA = "0x1853DA6A0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, bool? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x53DA890", Offset = "0x53D9A90", VA = "0x1853DA890", Slot = "7")]
	public bool? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CGKABLENNPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class DENHAKHDHAF : global::JJBJICJFEAB<bool[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly DENHAKHDHAF HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x50ED4F0", Offset = "0x50EC6F0", VA = "0x1850ED4F0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, bool[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x50ED5C0", Offset = "0x50EC7C0", VA = "0x1850ED5C0", Slot = "5")]
	public bool[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public DENHAKHDHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class MKJAEMEGNJP : global::JJBJICJFEAB<object>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::JJBJICJFEAB<object> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> BKANCHHGIAD;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5104710", Offset = "0x5103910", VA = "0x185104710", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5105190", Offset = "0x5104390", VA = "0x185105190", Slot = "5")]
	public object LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MKJAEMEGNJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class GJBAFIDGDMJ : global::JJBJICJFEAB<byte[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::JJBJICJFEAB<byte[]> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x50F3160", Offset = "0x50F2360", VA = "0x1850F3160", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, byte[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x50F31F0", Offset = "0x50F23F0", VA = "0x1850F31F0", Slot = "5")]
	public byte[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GJBAFIDGDMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class ANOIHJDFLGG : global::JJBJICJFEAB<ArraySegment<byte>>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::JJBJICJFEAB<ArraySegment<byte>> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x53C9060", Offset = "0x53C8260", VA = "0x1853C9060", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ArraySegment<byte> JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x53C9120", Offset = "0x53C8320", VA = "0x1853C9120", Slot = "5")]
	public ArraySegment<byte> LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ANOIHJDFLGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class GGENMJCPDAG : global::JJBJICJFEAB<string>, PKHFALLONLG, global::HHJPHCMFBDC<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::JJBJICJFEAB<string> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x50F2BF0", Offset = "0x50F1DF0", VA = "0x1850F2BF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, string JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x50F2C10", Offset = "0x50F1E10", VA = "0x1850F2C10", Slot = "5")]
	public string LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x50F2BF0", Offset = "0x50F1DF0", VA = "0x1850F2BF0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, string JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x50F2C10", Offset = "0x50F1E10", VA = "0x1850F2C10", Slot = "7")]
	public string OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GGENMJCPDAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class JBOIPFLCHAB : global::JJBJICJFEAB<string[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly JBOIPFLCHAB HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x50FB680", Offset = "0x50FA880", VA = "0x1850FB680", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, string[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x50FB740", Offset = "0x50FA940", VA = "0x1850FB740", Slot = "5")]
	public string[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JBOIPFLCHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class MBIECAKAGIG : global::JJBJICJFEAB<char>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly MBIECAKAGIG HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5103B40", Offset = "0x5102D40", VA = "0x185103B40", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, char JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5103BC0", Offset = "0x5102DC0", VA = "0x185103BC0", Slot = "5")]
	public char LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MBIECAKAGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class GHDDEFAMGFC : global::JJBJICJFEAB<char?>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly GHDDEFAMGFC HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x50F2C80", Offset = "0x50F1E80", VA = "0x1850F2C80", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, char? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x50F2D70", Offset = "0x50F1F70", VA = "0x1850F2D70", Slot = "5")]
	public char? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GHDDEFAMGFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class CBHDNMNPIGL : global::JJBJICJFEAB<char[]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly CBHDNMNPIGL HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x53D9B10", Offset = "0x53D8D10", VA = "0x1853D9B10", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, char[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x53D9D50", Offset = "0x53D8F50", VA = "0x1853D9D50", Slot = "5")]
	public char[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CBHDNMNPIGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class EKMAEPLLDIK : global::JJBJICJFEAB<Guid>, PKHFALLONLG, global::HHJPHCMFBDC<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::JJBJICJFEAB<Guid> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x50EF230", Offset = "0x50EE430", VA = "0x1850EF230", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Guid JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x50EF2D0", Offset = "0x50EE4D0", VA = "0x1850EF2D0", Slot = "5")]
	public Guid LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x50EF230", Offset = "0x50EE430", VA = "0x1850EF230", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, Guid JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x50EF320", Offset = "0x50EE520", VA = "0x1850EF320", Slot = "7")]
	public Guid OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EKMAEPLLDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class HAOPGAIPDFE : global::JJBJICJFEAB<decimal>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::JJBJICJFEAB<decimal> HMBHBEDALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool IMCKBDAONCF;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x898FA0", Offset = "0x8981A0", VA = "0x180898FA0")]
	public HAOPGAIPDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x106A580", Offset = "0x1069780", VA = "0x18106A580")]
	public HAOPGAIPDFE(bool IMCKBDAONCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x50F5000", Offset = "0x50F4200", VA = "0x1850F5000", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, decimal JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x50F5150", Offset = "0x50F4350", VA = "0x1850F5150", Slot = "5")]
	public decimal LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class AABPCAAMIJK : global::JJBJICJFEAB<Uri>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::JJBJICJFEAB<Uri> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x53C60C0", Offset = "0x53C52C0", VA = "0x1853C60C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Uri JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x53C6170", Offset = "0x53C5370", VA = "0x1853C6170", Slot = "5")]
	public Uri LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public AABPCAAMIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HDKPCFLCCDN : global::JJBJICJFEAB<Version>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::JJBJICJFEAB<Version> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x50F5610", Offset = "0x50F4810", VA = "0x1850F5610", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Version JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x50F56C0", Offset = "0x50F48C0", VA = "0x1850F56C0", Slot = "5")]
	public Version LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HDKPCFLCCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class CPIGBBPOGHN<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class JJIJOHCDGKB : global::JJBJICJFEAB<StringBuilder>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::JJBJICJFEAB<StringBuilder> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x50FC460", Offset = "0x50FB660", VA = "0x1850FC460", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, StringBuilder JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x50FC4B0", Offset = "0x50FB6B0", VA = "0x1850FC4B0", Slot = "5")]
	public StringBuilder LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JJIJOHCDGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class BDEBBMIEEND : global::JJBJICJFEAB<BitArray>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::JJBJICJFEAB<BitArray> HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x53D0640", Offset = "0x53CF840", VA = "0x1853D0640", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, BitArray JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x53D0740", Offset = "0x53CF940", VA = "0x1853D0740", Slot = "5")]
	public BitArray LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public BDEBBMIEEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class NHODOGAGCPO : global::JJBJICJFEAB<Type>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly NHODOGAGCPO HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex JKENDBDNEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool LJFBCLJPCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DCMPLDLODFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool KDHIBIPHALC;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x50B7AF0", Offset = "0x50B6CF0", VA = "0x1850B7AF0")]
	public NHODOGAGCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x50B7B10", Offset = "0x50B6D10", VA = "0x1850B7B10")]
	public NHODOGAGCPO(bool LJFBCLJPCFB, bool DCMPLDLODFD, bool KDHIBIPHALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x50B7810", Offset = "0x50B6A10", VA = "0x1850B7810", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Type JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x50B7900", Offset = "0x50B6B00", VA = "0x1850B7900", Slot = "5")]
	public Type LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
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
