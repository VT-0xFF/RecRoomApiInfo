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
	[Cpp2IlInjected.Address(RVA = "0x529B200", Offset = "0x529A600", VA = "0x18529B200")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] HLIGJGOJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72ABD0", Offset = "0x729FD0", VA = "0x18072ABD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x27CDAE0", Offset = "0x27CCEE0", VA = "0x1827CDAE0")]
	public static global::JJBJICJFEAB<T> JKKABMNHFOB<T>(this LMDOKLNJEDM DJEEIHBJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5305D80", Offset = "0x5305180", VA = "0x185305D80")]
	public static object IMDMONNEPMJ(this LMDOKLNJEDM DJEEIHBJAEH, Type DDJDPMGLPAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ECKKNAHKKFE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x53043B0", Offset = "0x53037B0", VA = "0x1853043B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5291050", Offset = "0x5290450", VA = "0x185291050")]
		public static byte[] KEFCAMGPPIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x52910E0", Offset = "0x52904E0", VA = "0x1852910E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x530D7E0", Offset = "0x530CBE0", VA = "0x18530D7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5310500", Offset = "0x530F900", VA = "0x185310500")]
	public IIHLGBHCEFK(byte[] NPNCGJAPKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5310310", Offset = "0x530F710", VA = "0x185310310")]
	public IIHLGBHCEFK(byte[] NPNCGJAPKIL, int ELOEOOGBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x530E3E0", Offset = "0x530D7E0", VA = "0x18530E3E0")]
	private DDDHLGJGIPK EHDHNEPKGBD(string FLGDGHMLIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x530D700", Offset = "0x530CB00", VA = "0x18530D700")]
	private DDDHLGJGIPK AADMHDLOAIM(string DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x530FDA0", Offset = "0x530F1A0", VA = "0x18530FDA0")]
	public void OMBGEHEAHCE(int ELOEOOGBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E30", Offset = "0x6E1230", VA = "0x1806E1E30")]
	public byte[] KLPLGLNNPPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x766020", Offset = "0x765420", VA = "0x180766020")]
	public int MEBEJPMCNCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x530F140", Offset = "0x530E540", VA = "0x18530F140")]
	public EABIEKKHOKH IOKLJOILONI()
	{
		return default(EABIEKKHOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x530FC20", Offset = "0x530F020", VA = "0x18530FC20")]
	public void OFFDGEIHBPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x530FB20", Offset = "0x530EF20", VA = "0x18530FB20")]
	public bool OENNKEHNOHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x530E190", Offset = "0x530D590", VA = "0x18530E190")]
	public bool APPHCLBMDLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x530F470", Offset = "0x530E870", VA = "0x18530F470")]
	public void JOLBCKGMDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x530FFC0", Offset = "0x530F3C0", VA = "0x18530FFC0")]
	public bool PLLMKBHLFHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x530E1F0", Offset = "0x530D5F0", VA = "0x18530E1F0")]
	public bool BHNNJJCFJOK(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x530EDF0", Offset = "0x530E1F0", VA = "0x18530EDF0")]
	public bool IFBKOJHKEBO(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x530F980", Offset = "0x530ED80", VA = "0x18530F980")]
	public bool NODBDAJNMDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x530ED00", Offset = "0x530E100", VA = "0x18530ED00")]
	public void IAMCIJEPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x530ECA0", Offset = "0x530E0A0", VA = "0x18530ECA0")]
	public bool HNGBAMMKCHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x530E360", Offset = "0x530D760", VA = "0x18530E360")]
	public bool DAOGMJHNMME(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x530F9E0", Offset = "0x530EDE0", VA = "0x18530F9E0")]
	public bool OABCFHPEOOP(ref int OCCKKIPCFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x530F920", Offset = "0x530ED20", VA = "0x18530F920")]
	public bool NCHPDJIFNOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x530F890", Offset = "0x530EC90", VA = "0x18530F890")]
	public void NCHILOPHPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x530ED90", Offset = "0x530E190", VA = "0x18530ED90")]
	public bool IBMMJKCLFJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x530E270", Offset = "0x530D670", VA = "0x18530E270")]
	public void BMJMBDKCHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x530D800", Offset = "0x530CC00", VA = "0x18530D800")]
	private void AALJCCDKEBE(out byte[] DMECDOCBFOA, out int MJJPMFFLOAP, out int BKDGLKKIHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x530F090", Offset = "0x530E490", VA = "0x18530F090")]
	private static int IMCCCAEKBFB(char FAMKPEGNHFC, char GPHMIGDKMEO, char ECKJDAFJMBK, char ABLKMJLKIKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x530FE10", Offset = "0x530F210", VA = "0x18530FE10")]
	private static int PBIJKHHJMOF(char BIAIPPDLOMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x530F500", Offset = "0x530E900", VA = "0x18530F500")]
	public ArraySegment<byte> KKGEDMAMDPJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x530F730", Offset = "0x530EB30", VA = "0x18530F730")]
	public string MFNACELPBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x530EA30", Offset = "0x530DE30", VA = "0x18530EA30")]
	public string GEGGDNGDHHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x530DFC0", Offset = "0x530D3C0", VA = "0x18530DFC0")]
	public ArraySegment<byte> AGBJCEPHKML()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x530FD60", Offset = "0x530F160", VA = "0x18530FD60")]
	public ArraySegment<byte> OILIJOBAPPD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x530EA60", Offset = "0x530DE60", VA = "0x18530EA60")]
	public bool GMOMCJKEIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x530F7D0", Offset = "0x530EBD0", VA = "0x18530F7D0")]
	private static bool MOEAHFHHDPC(byte ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x530EEB0", Offset = "0x530E2B0", VA = "0x18530EEB0")]
	private void IJEPLKIGILM(EABIEKKHOKH AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x530FEE0", Offset = "0x530F2E0", VA = "0x18530FEE0")]
	public void PGBKNAGAPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x530FEF0", Offset = "0x530F2F0", VA = "0x18530FEF0")]
	private void PKOJAEHNCKN(int NJODGODMJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x530E8F0", Offset = "0x530DCF0", VA = "0x18530E8F0")]
	public sbyte FIPNAOJLBAE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x53101B0", Offset = "0x530F5B0", VA = "0x1853101B0")]
	public short PPNOBAEHOGF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x530F410", Offset = "0x530E810", VA = "0x18530F410")]
	public int JOEICHNIDGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x530FAA0", Offset = "0x530EEA0", VA = "0x18530FAA0")]
	public long OBFBHKKJEIH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x530FDB0", Offset = "0x530F1B0", VA = "0x18530FDB0")]
	public byte ONKDCBDEKBB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x530F600", Offset = "0x530EA00", VA = "0x18530F600")]
	public ushort KPFMCNLJDOG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x530E300", Offset = "0x530D700", VA = "0x18530E300")]
	public uint CCNDEEDCGBF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x530F390", Offset = "0x530E790", VA = "0x18530F390")]
	public ulong JGECLHMFKKD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x530F660", Offset = "0x530EA60", VA = "0x18530F660")]
	public float MEOBEEKJDLP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x530F2C0", Offset = "0x530E6C0", VA = "0x18530F2C0")]
	public double JAJFEMDKJEL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x530E940", Offset = "0x530DD40", VA = "0x18530E940")]
	public ArraySegment<byte> FMLPEJMBEMC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5310020", Offset = "0x530F420", VA = "0x185310020")]
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
		[Cpp2IlInjected.Address(RVA = "0x752F60", Offset = "0x752360", VA = "0x180752F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string BJEFLEFGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7270", Offset = "0x6F6670", VA = "0x1806F7270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5303690", Offset = "0x5302A90", VA = "0x185303690")]
	public DDDHLGJGIPK(string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5303700", Offset = "0x5302B00", VA = "0x185303700")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public PMHJLONLEFL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x9BF0B0", Offset = "0x9BE4B0", VA = "0x1809BF0B0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x52A2A60", Offset = "0x52A1E60", VA = "0x1852A2A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x5293CD0", Offset = "0x52930D0", VA = "0x185293CD0")]
			public LEAONMPIBHM(Type DDJDPMGLPAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3C10", Offset = "0x5AD3010", VA = "0x185AD3C10")]
			private static T CBGAIIHMAKM<T>(DynamicMethod KPAOPOLLNLJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5293A80", Offset = "0x5292E80", VA = "0x185293A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5291BC0", Offset = "0x5290FC0", VA = "0x185291BC0")]
		static IDNBDILLPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5291B30", Offset = "0x5290F30", VA = "0x185291B30")]
		private static LEAONMPIBHM MGNJLCPLAEP(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x52919A0", Offset = "0x5290DA0", VA = "0x1852919A0")]
		public static void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5291880", Offset = "0x5290C80", VA = "0x185291880")]
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
		[Cpp2IlInjected.Address(RVA = "0x529FB40", Offset = "0x529EF40", VA = "0x18529FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x529FE30", Offset = "0x529F230", VA = "0x18529FE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EIOIMMEOHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x529FF50", Offset = "0x529F350", VA = "0x18529FF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52A04A0", Offset = "0x529F8A0", VA = "0x1852A04A0")]
	public static void LHKNFGOEGMB(LMDOKLNJEDM DJEEIHBJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x327E410", Offset = "0x327D810", VA = "0x18327E410")]
	public static byte[] LMGAKHPBOLH<T>(T ADHHHFDPAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x327E520", Offset = "0x327D920", VA = "0x18327E520")]
	public static byte[] LMGAKHPBOLH<T>(T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x327E490", Offset = "0x327D890", VA = "0x18327E490")]
	public static void LMGAKHPBOLH<T>(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x327E2A0", Offset = "0x327D6A0", VA = "0x18327E2A0")]
	public static void LMGAKHPBOLH<T>(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x327E380", Offset = "0x327D780", VA = "0x18327E380")]
	public static void LMGAKHPBOLH<T>(Stream DMEDBCCHBBH, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x327E680", Offset = "0x327DA80", VA = "0x18327E680")]
	public static void LMGAKHPBOLH<T>(Stream DMEDBCCHBBH, T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x327E020", Offset = "0x327D420", VA = "0x18327E020")]
	public static ArraySegment<byte> ADKFONHNOJE<T>(T ADHHHFDPAPI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x327DEA0", Offset = "0x327D2A0", VA = "0x18327DEA0")]
	public static ArraySegment<byte> ADKFONHNOJE<T>(T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x327E220", Offset = "0x327D620", VA = "0x18327E220")]
	public static string JDNBDBAHEAJ<T>(T JFBPNBNBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x327E0C0", Offset = "0x327D4C0", VA = "0x18327E0C0")]
	public static string JDNBDBAHEAJ<T>(T JFBPNBNBHOE, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x327F100", Offset = "0x327E500", VA = "0x18327F100")]
	public static T LPJEJNEGJFP<T>(string DPDEOLBHJMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x327F3A0", Offset = "0x327E7A0", VA = "0x18327F3A0")]
	public static T LPJEJNEGJFP<T>(string DPDEOLBHJMF, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x327FB40", Offset = "0x327EF40", VA = "0x18327FB40")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x327F1A0", Offset = "0x327E5A0", VA = "0x18327F1A0")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x327FA30", Offset = "0x327EE30", VA = "0x18327FA30")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL, int ELOEOOGBENM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x327F240", Offset = "0x327E640", VA = "0x18327F240")]
	public static T LPJEJNEGJFP<T>(byte[] NPNCGJAPKIL, int ELOEOOGBENM, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x327F490", Offset = "0x327E890", VA = "0x18327F490")]
	public static T LPJEJNEGJFP<T>(ref IIHLGBHCEFK OJMODHIKFDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x327F780", Offset = "0x327EB80", VA = "0x18327F780")]
	public static T LPJEJNEGJFP<T>(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x327FAC0", Offset = "0x327EEC0", VA = "0x18327FAC0")]
	public static T LPJEJNEGJFP<T>(Stream DMEDBCCHBBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x327F650", Offset = "0x327EA50", VA = "0x18327F650")]
	public static T LPJEJNEGJFP<T>(Stream DMEDBCCHBBH, LMDOKLNJEDM DJEEIHBJAEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x529FC80", Offset = "0x529F080", VA = "0x18529FC80")]
	public static string FJEFJHBAMFH(byte[] DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x529FBD0", Offset = "0x529EFD0", VA = "0x18529FBD0")]
	public static string FJEFJHBAMFH(byte[] DPDEOLBHJMF, int ELOEOOGBENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x529FD60", Offset = "0x529F160", VA = "0x18529FD60")]
	public static string FJEFJHBAMFH(string DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x52A0690", Offset = "0x529FA90", VA = "0x1852A0690")]
	public static byte[] MPAFANNNBKE(byte[] DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x52A05E0", Offset = "0x529F9E0", VA = "0x1852A05E0")]
	public static byte[] MPAFANNNBKE(byte[] DPDEOLBHJMF, int ELOEOOGBENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x52A0510", Offset = "0x529F910", VA = "0x1852A0510")]
	public static byte[] MPAFANNNBKE(string DPDEOLBHJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x529FFB0", Offset = "0x529F3B0", VA = "0x18529FFB0")]
	private static void KLBIDFFMBIG(ref IIHLGBHCEFK OJMODHIKFDB, ref AOONEBAFBIP ABIHDCBCABG, int ELMCLGINMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52A0770", Offset = "0x529FB70", VA = "0x1852A0770")]
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
		[Cpp2IlInjected.Address(RVA = "0x766020", Offset = "0x765420", VA = "0x180766020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x530FDA0", Offset = "0x530F1A0", VA = "0x18530FDA0")]
	public void OMBGEHEAHCE(int ELOEOOGBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55483B0", Offset = "0x55477B0", VA = "0x1855483B0")]
	public static byte[] CILKCABILHO(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5548C70", Offset = "0x5548070", VA = "0x185548C70")]
	public static byte[] GEHFMKHEJKD(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5549420", Offset = "0x5548820", VA = "0x185549420")]
	public static byte[] OLKEDCLKGMA(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5548260", Offset = "0x5547660", VA = "0x185548260")]
	public static byte[] CHIEKEPLGIF(string CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1472830", Offset = "0x1471C30", VA = "0x181472830")]
	public AOONEBAFBIP(byte[] DMCBJMIIPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55491B0", Offset = "0x55485B0", VA = "0x1855491B0")]
	public ArraySegment<byte> KEFCAMGPPIP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5548AF0", Offset = "0x5547EF0", VA = "0x185548AF0")]
	public byte[] FMPEIHMNPFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55494F0", Offset = "0x55488F0", VA = "0x1855494F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5548250", Offset = "0x5547650", VA = "0x185548250")]
	public void CDEPEGAJOEL(int FOFPICKAACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x53086D0", Offset = "0x5307AD0", VA = "0x1853086D0")]
	public void MEEBNDLECPG(byte EMFLPIECMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x55492D0", Offset = "0x55486D0", VA = "0x1855492D0")]
	public void MEEBNDLECPG(byte[] EMFLPIECMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5549260", Offset = "0x5548660", VA = "0x185549260")]
	public void KNMFHJPAGGJ(byte EMFLPIECMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5549330", Offset = "0x5548730", VA = "0x185549330")]
	public void MLBMNAECGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5549380", Offset = "0x5548780", VA = "0x185549380")]
	public void OAOALKIDMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5548D40", Offset = "0x5548140", VA = "0x185548D40")]
	public void GKOKBMLMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55490E0", Offset = "0x55484E0", VA = "0x1855490E0")]
	public void HJJIMCFBGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5549160", Offset = "0x5548560", VA = "0x185549160")]
	public void IEJFPCEEBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x55493D0", Offset = "0x55487D0", VA = "0x1855493D0")]
	public void OBOHBNMOPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5548190", Offset = "0x5547590", VA = "0x185548190")]
	public void BGAOMDMDFBF(string CGCMEEFENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5548140", Offset = "0x5547540", VA = "0x185548140")]
	public void APGDJKLJEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5548800", Offset = "0x5547C00", VA = "0x185548800")]
	public void DDBFLPANBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5548D90", Offset = "0x5548190", VA = "0x185548D90")]
	public void HCGDOHHCAGB(bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x55488D0", Offset = "0x5547CD0", VA = "0x1855488D0")]
	public void EAHOCMPJEFK(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5548F80", Offset = "0x5548380", VA = "0x185548F80")]
	public void HFKADKJMAIP(double JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5548A90", Offset = "0x5547E90", VA = "0x185548A90")]
	public void ENAMEOIMMOC(byte JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5549130", Offset = "0x5548530", VA = "0x185549130")]
	public void HONMCHEHIBJ(ushort JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x55492A0", Offset = "0x55486A0", VA = "0x1855492A0")]
	public void LGABPNGKMIB(uint JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5548AC0", Offset = "0x5547EC0", VA = "0x185548AC0")]
	public void EOACNFMILOI(ulong JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5548A60", Offset = "0x5547E60", VA = "0x185548A60")]
	public void EIHMEBDFIBI(sbyte JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5548220", Offset = "0x5547620", VA = "0x185548220")]
	public void BNLEDADNHMF(short JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5548A30", Offset = "0x5547E30", VA = "0x185548A30")]
	public void EEGBMNFDCNO(int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x55481F0", Offset = "0x55475F0", VA = "0x1855481F0")]
	public void BMDFCIEFFAP(long JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5548430", Offset = "0x5547830", VA = "0x185548430")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DFE500", Offset = "0x2DFD900", VA = "0x182DFE500")]
		static ONCJFEJCONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private HNDDKADFLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5545B10", Offset = "0x5544F10", VA = "0x185545B10")]
	static ALBALIHJIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5545400", Offset = "0x5544800", VA = "0x185545400")]
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
	[Cpp2IlInjected.Address(RVA = "0x530C740", Offset = "0x530BB40", VA = "0x18530C740")]
	public HLKGIDMKGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x530C3B0", Offset = "0x530B7B0", VA = "0x18530C3B0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Vector2 JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x530C460", Offset = "0x530B860", VA = "0x18530C460", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5309EA0", Offset = "0x53092A0", VA = "0x185309EA0")]
	public GLLBOMONOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5309A60", Offset = "0x5308E60", VA = "0x185309A60", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Vector3 JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5309B80", Offset = "0x5308F80", VA = "0x185309B80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5298E50", Offset = "0x5298250", VA = "0x185298E50")]
	public MOFEGGKPOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5298AE0", Offset = "0x5297EE0", VA = "0x185298AE0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Vector4 JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5298C30", Offset = "0x5298030", VA = "0x185298C30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5308C50", Offset = "0x5308050", VA = "0x185308C50")]
	public GAJFIABHHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5298AE0", Offset = "0x5297EE0", VA = "0x185298AE0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Quaternion JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x53088D0", Offset = "0x5307CD0", VA = "0x1853088D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x555C8D0", Offset = "0x555BCD0", VA = "0x18555C8D0")]
	public CPDKALIDKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x555C3D0", Offset = "0x555B7D0", VA = "0x18555C3D0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Color JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x555C640", Offset = "0x555BA40", VA = "0x18555C640", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5315B80", Offset = "0x5314F80", VA = "0x185315B80")]
	public KALJOACFPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x53155C0", Offset = "0x53149C0", VA = "0x1853155C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Bounds JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5315760", Offset = "0x5314B60", VA = "0x185315760", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5306410", Offset = "0x5305810", VA = "0x185306410")]
	public EOKMHGDAPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5305EF0", Offset = "0x53052F0", VA = "0x185305EF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Rect JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5306060", Offset = "0x5305460", VA = "0x185306060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AB5870", Offset = "0x3AB4C70", VA = "0x183AB5870")]
		static JEEPPJJAFAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private GCPLKGGAAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FC0510", Offset = "0x3FBF910", VA = "0x183FC0510")]
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
		[Cpp2IlInjected.Address(RVA = "0x52A0990", Offset = "0x529FD90", VA = "0x1852A0990")]
		internal static object KBHEOONAKKF(Type EHIBGNPGILO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private POIGPLFBPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x48DA5D0", Offset = "0x48D99D0", VA = "0x1848DA5D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private KEPJHCFABAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5316640", Offset = "0x5315A40", VA = "0x185316640")]
	public static void KJDPCLCGNLB(params LMDOKLNJEDM[] OAIPJKBMKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5316560", Offset = "0x5315960", VA = "0x185316560")]
	public static void KJDPCLCGNLB(params PKHFALLONLG[] OBHMMLKHJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x53162D0", Offset = "0x53156D0", VA = "0x1853162D0")]
	public static void HBLIGLACKKF(PKHFALLONLG[] OBHMMLKHJPD, LMDOKLNJEDM[] OAIPJKBMKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x438F560", Offset = "0x438E960", VA = "0x18438F560")]
		static HBOEEOAHEMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private NCLJFPPOPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x529CFF0", Offset = "0x529C3F0", VA = "0x18529CFF0")]
	internal static object KBHEOONAKKF(Type EHIBGNPGILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x529CFB0", Offset = "0x529C3B0", VA = "0x18529CFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x41F84C0", Offset = "0x41F78C0", VA = "0x1841F84C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5319EC0", Offset = "0x53192C0", VA = "0x185319EC0")]
	static MBADNGFAKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private MBADNGFAKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C05330", Offset = "0x3C04730", VA = "0x183C05330")]
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
	[Cpp2IlInjected.Address(RVA = "0x5315D80", Offset = "0x5315180", VA = "0x185315D80")]
	static KCOKIMNAGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private KCOKIMNAGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C65C20", Offset = "0x3C65020", VA = "0x183C65C20")]
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
	[Cpp2IlInjected.Address(RVA = "0x5544ED0", Offset = "0x55442D0", VA = "0x185544ED0")]
	static ABCDLMKCLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private ABCDLMKCLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41690A0", Offset = "0x41684A0", VA = "0x1841690A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5558CB0", Offset = "0x55580B0", VA = "0x185558CB0")]
	static CEPMDPJNBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private CEPMDPJNBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FC4060", Offset = "0x3FC3460", VA = "0x183FC4060")]
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
	[Cpp2IlInjected.Address(RVA = "0x5303560", Offset = "0x5302960", VA = "0x185303560")]
	static CPHBLFFEGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private CPHBLFFEGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D9A520", Offset = "0x2D99920", VA = "0x182D9A520")]
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
	[Cpp2IlInjected.Address(RVA = "0x5312A40", Offset = "0x5311E40", VA = "0x185312A40")]
	static JLEIMCHDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private JLEIMCHDBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x354E190", Offset = "0x354D590", VA = "0x18354E190")]
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
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FED3F0", Offset = "0x2FEC7F0", VA = "0x182FED3F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x415DF90", Offset = "0x415D390", VA = "0x18415DF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33803E0", Offset = "0x337F7E0", VA = "0x1833803E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3395360", Offset = "0x3394760", VA = "0x183395360")]
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
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x343F160", Offset = "0x343E560", VA = "0x18343F160")]
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
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
	public global::JJBJICJFEAB<T> KBHEOONAKKF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5292870", Offset = "0x5291C70", VA = "0x185292870")]
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
			[Cpp2IlInjected.Address(RVA = "0x5297E10", Offset = "0x5297210", VA = "0x185297E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5295B10", Offset = "0x5294F10", VA = "0x185295B10")]
		public static MethodInfo LMGAKHPBOLH(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5295DE0", Offset = "0x52951E0", VA = "0x185295DE0")]
		public static MethodInfo LPJEJNEGJFP(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x52959D0", Offset = "0x5294DD0", VA = "0x1852959D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KOJNCFBKKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5293650", Offset = "0x5292A50", VA = "0x185293650")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5293690", Offset = "0x5292A90", VA = "0x185293690")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FGJBFGBMMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x528F190", Offset = "0x528E590", VA = "0x18528F190")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MJACGDLAHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x52977C0", Offset = "0x5296BC0", VA = "0x1852977C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GEPPCKONPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x528F3F0", Offset = "0x528E7F0", VA = "0x18528F3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GMKNJDNKDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x52909B0", Offset = "0x528FDB0", VA = "0x1852909B0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x52909C0", Offset = "0x528FDC0", VA = "0x1852909C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public BFHDICDJFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x528E310", Offset = "0x528D710", VA = "0x18528E310")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public NCBNKCLFOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7E3900", Offset = "0x7E2D00", VA = "0x1807E3900")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DFIDNLFEOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x528EBB0", Offset = "0x528DFB0", VA = "0x18528EBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KPFKKAFBGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5293730", Offset = "0x5292B30", VA = "0x185293730")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x52939E0", Offset = "0x5292DE0", VA = "0x1852939E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HDEIIHAPLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1AD30A0", Offset = "0x1AD24A0", VA = "0x181AD30A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public POCEOFAINMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1AD30A0", Offset = "0x1AD24A0", VA = "0x181AD30A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C1EEA0", Offset = "0x3C1E2A0", VA = "0x183C1EEA0")]
	public static object JKJDABFFOHL<T>(DDELIMNFFNE LEMGPPEGBPI, LMDOKLNJEDM MMHPNNGOPOO, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A2E0", Offset = "0x3C296E0", VA = "0x183C2A2E0")]
	public static object KCDOCPKEGKO<T>(LMDOKLNJEDM MMHPNNGOPOO, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG, bool NHNFPKPPJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5554230", Offset = "0x5553630", VA = "0x185554230")]
	private static TypeInfo HNINPLKBNBE(DDELIMNFFNE LEMGPPEGBPI, Type DDJDPMGLPAE, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x55560B0", Offset = "0x55554B0", VA = "0x1855560B0")]
	public static object PMKMJIJKOKN(Type DDJDPMGLPAE, Func<string, string> DFDPGCBCJMD, bool LELPBDCIGFG, bool NHNFPKPPJAJ, bool AMNIBKMKCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5551A50", Offset = "0x5550E50", VA = "0x185551A50")]
	private static Dictionary<BJHIALAFHDM, FieldInfo> FJIMJHPPJBI(TypeBuilder DHNNJHMDCOE, NOEPBKCLECE HHCANBNBHNP, ConstructorInfo MFCNHFGGLMJ, FieldBuilder IIKEIOMBOOE, ILGenerator KHLPOCHIMCH, bool LELPBDCIGFG, bool GPALHHOAMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5554E70", Offset = "0x5554270", VA = "0x185554E70")]
	private static Dictionary<BJHIALAFHDM, FieldInfo> JKDFPNDMGAH(TypeBuilder DHNNJHMDCOE, NOEPBKCLECE HHCANBNBHNP, ILGenerator KHLPOCHIMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x554FFE0", Offset = "0x554F3E0", VA = "0x18554FFE0")]
	private static void AMHJOIGKFGC(Type DDJDPMGLPAE, NOEPBKCLECE HHCANBNBHNP, ILGenerator KHLPOCHIMCH, Action MPICDKCMMEM, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, bool LELPBDCIGFG, bool GPALHHOAMFN, int NGHEOGCLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5551500", Offset = "0x5550900", VA = "0x185551500")]
	private static void CPGJJMEHBFN(TypeInfo DDJDPMGLPAE, BJHIALAFHDM AFBJNAEHGAL, ILGenerator KHLPOCHIMCH, int BELCAJFDAHD, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, DFAJAOEBAOO ABIHDCBCABG, DFAJAOEBAOO HCOGACKJDLJ, DFAJAOEBAOO DIGPLAFFJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5552130", Offset = "0x5551530", VA = "0x185552130")]
	private static void GJPPBOGMCJI(Type DDJDPMGLPAE, NOEPBKCLECE HHCANBNBHNP, ILGenerator KHLPOCHIMCH, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, bool OBEBDJIIBHJ, int NGHEOGCLIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5555BF0", Offset = "0x5554FF0", VA = "0x185555BF0")]
	private static void OCINAJIDKGD(ILGenerator KHLPOCHIMCH, DIEBJMOGHLH HHCANBNBHNP, int BELCAJFDAHD, Func<int, BJHIALAFHDM, bool> JJHLAJLCFIG, DFAJAOEBAOO OJMODHIKFDB, DFAJAOEBAOO DIGPLAFFJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5553580", Offset = "0x5552980", VA = "0x185553580")]
	private static LocalBuilder GOGHDNPALBJ(ILGenerator KHLPOCHIMCH, Type DDJDPMGLPAE, NOEPBKCLECE HHCANBNBHNP, DIEBJMOGHLH[] FPPPEFDLKGC, bool CKKLPHPAKIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x55554F0", Offset = "0x55548F0", VA = "0x1855554F0")]
	private static bool MLKLNPDGIBK(ConstructorInfo DLBIBFHKNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5554CC0", Offset = "0x55540C0", VA = "0x185554CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3AA5AA0", Offset = "0x3AA4EA0", VA = "0x183AA5AA0")]
	public GJBAFCPPDOO(byte[][] IIKEIOMBOOE, object[] HEIAOMODGEH, object[] NKPKIHOMAKN, global::LEKOMFOGBME<T> DINCDDJBCLK, global::HAJEHMDDNIL<T> CPFAGJHAJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B9C0", Offset = "0x3D7ADC0", VA = "0x183D7B9C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BAA0", Offset = "0x3D7AEA0", VA = "0x183D7BAA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B7B4D0", Offset = "0x3B7A8D0", VA = "0x183B7B4D0")]
		static EAKOJHLAHCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private HPFNPOKKHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x33CB970", Offset = "0x33CAD70", VA = "0x1833CB970")]
		static ACOGHFDJIMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly LMDOKLNJEDM HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private AMEKMBBGCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BF4240", Offset = "0x3BF3640", VA = "0x183BF4240")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D90090", Offset = "0x3D8F490", VA = "0x183D90090")]
			static APFMOAIFHEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private FJGJNEJJLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private FDOFHGEBCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8F360", Offset = "0x2B8E760", VA = "0x182B8F360")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8B450", Offset = "0x2B8A850", VA = "0x182B8B450")]
			static ILGAHLGALKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private ANHAAFFNMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private FAIJPBPLKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BFF240", Offset = "0x3BFE640", VA = "0x183BFF240")]
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
			[Cpp2IlInjected.Address(RVA = "0x39F9150", Offset = "0x39F8550", VA = "0x1839F9150")]
			static COPLJIJCHGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private HGAKPEDMLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private JEJPDHKKLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C1A00", Offset = "0x29C0E00", VA = "0x1829C1A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EE80D0", Offset = "0x3EE74D0", VA = "0x183EE80D0")]
			static DOMEJOICEOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private CBBLIFFCELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private KKLAIBACLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x355E290", Offset = "0x355D690", VA = "0x18355E290")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EB61C0", Offset = "0x3EB55C0", VA = "0x183EB61C0")]
			static JMMLHEMCCBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private CKLJFFKHJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private CFOFNLEPIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FFF550", Offset = "0x2FFE950", VA = "0x182FFF550")]
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
			[Cpp2IlInjected.Address(RVA = "0x3551E90", Offset = "0x3551290", VA = "0x183551E90")]
			static NCPJGBDIKOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private KKGCNFLPFAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private OONJGCBOADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C4F030", Offset = "0x3C4E430", VA = "0x183C4F030")]
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
			[Cpp2IlInjected.Address(RVA = "0x3ABD9D0", Offset = "0x3ABCDD0", VA = "0x183ABD9D0")]
			static JGAODKJAANM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private ONMGGBNGCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private MAKCPJDNNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CD4820", Offset = "0x3CD3C20", VA = "0x183CD4820")]
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
			[Cpp2IlInjected.Address(RVA = "0x32E5B10", Offset = "0x32E4F10", VA = "0x1832E5B10")]
			static DELMDDBDKAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private GOMCLJMJPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private PMBFKOCKPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x344EF70", Offset = "0x344E370", VA = "0x18344EF70")]
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
			[Cpp2IlInjected.Address(RVA = "0x355B9E0", Offset = "0x355ADE0", VA = "0x18355B9E0")]
			static NFDNAPBIEPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private CNCDKHFMONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private HLOPJBDDPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C0BCE0", Offset = "0x3C0B0E0", VA = "0x183C0BCE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C56C00", Offset = "0x4C56000", VA = "0x184C56C00")]
			static PNLOPCLNIHN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private ANEOIBPAEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private KKDFCIGJKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3374F00", Offset = "0x3374300", VA = "0x183374F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x343CF90", Offset = "0x343C390", VA = "0x18343CF90")]
			static AHKKBILNLLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private BNMCEJKBMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private BILPCINALKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FF5EA0", Offset = "0x2FF52A0", VA = "0x182FF5EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C52E10", Offset = "0x3C52210", VA = "0x183C52E10")]
			static EBPFBGDLHGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LMDOKLNJEDM HNEIEBONIJN;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly LMDOKLNJEDM[] OAIPJKBMKPC;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		private DHKJGJHIOCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	private FEFOGKDFNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x213C840", Offset = "0x213BC40", VA = "0x18213C840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9E640", Offset = "0x2D9DA40", VA = "0x182D9E640")]
	public LFCMPLINDCF(int KHFADEKJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E310", Offset = "0x2D9D710", VA = "0x182D9E310")]
	public void AOHLLDNPMGN(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E5B0", Offset = "0x2D9D9B0", VA = "0x182D9E5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5319E70", Offset = "0x5319270", VA = "0x185319E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B3DBF0", Offset = "0x3B3CFF0", VA = "0x183B3DBF0")]
	public NNLGPMNIGEN(int PIIEHIOHJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B3D580", Offset = "0x3B3C980", VA = "0x183B3D580")]
	public T[] LADDEPODNIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B3D040", Offset = "0x3B3C440", VA = "0x183B3D040")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
			[DebuggerHidden]
			public HGOIJGAFODJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x5290EE0", Offset = "0x52902E0", VA = "0x185290EE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x5291010", Offset = "0x5290410", VA = "0x185291010", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x5290F70", Offset = "0x5290370", VA = "0x185290F70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GICCFFEKJMD> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x5290F70", Offset = "0x5290370", VA = "0x185290F70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public JAMFJJIKBEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x7E3900", Offset = "0x7E2D00", VA = "0x1807E3900")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x7E3900", Offset = "0x7E2D00", VA = "0x1807E3900")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D6FD0", Offset = "0x15D63D0", VA = "0x1815D6FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x52908F0", Offset = "0x528FCF0", VA = "0x1852908F0")]
		public GICCFFEKJMD(ulong EBOEHIFNNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x528F590", Offset = "0x528E990", VA = "0x18528F590")]
		public GICCFFEKJMD AOHLLDNPMGN(ulong EBOEHIFNNLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x528F850", Offset = "0x528EC50", VA = "0x18528F850")]
		public GICCFFEKJMD AOHLLDNPMGN(ulong EBOEHIFNNLM, int JFBPNBNBHOE, string PMPFNNLGIFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x528F8A0", Offset = "0x528ECA0", VA = "0x18528F8A0")]
		public GICCFFEKJMD BEDPOPEKOFK(byte[] KHNOBAAPEAO, ref int ELOEOOGBENM, ref int IFCGFMEPAHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x528FAF0", Offset = "0x528EEF0", VA = "0x18528FAF0")]
		internal static int GIOGKPLCGFD(ulong[] PFCDNINKMFA, int BELCAJFDAHD, int ONCBCCLEFOH, ulong JFBPNBNBHOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x528FAC0", Offset = "0x528EEC0", VA = "0x18528FAC0", Slot = "4")]
		public int CompareTo(GICCFFEKJMD IHIJPIJNLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x528FA50", Offset = "0x528EE50", VA = "0x18528FA50")]
		[IteratorStateMachine(typeof(HGOIJGAFODJ))]
		public IEnumerable<GICCFFEKJMD> BFKFPEELIBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x528F450", Offset = "0x528E850", VA = "0x18528F450")]
		public void ADPJACKFNHL(ILGenerator KHLPOCHIMCH, LocalBuilder KHNOBAAPEAO, LocalBuilder IFCGFMEPAHB, LocalBuilder EBOEHIFNNLM, Action<KeyValuePair<string, int>> IBJDOKNOKAA, Action DGNBPNMEBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x528FB70", Offset = "0x528EF70", VA = "0x18528FB70")]
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
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x52916B0", Offset = "0x5290AB0", VA = "0x1852916B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x760D30", Offset = "0x760130", VA = "0x180760D30")]
		[DebuggerHidden]
		public HLCEHJFLDDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5291700", Offset = "0x5290B00", VA = "0x185291700", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5291170", Offset = "0x5290570", VA = "0x185291170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x52917E0", Offset = "0x5290BE0", VA = "0x1852917E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5291830", Offset = "0x5290C30", VA = "0x185291830")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5291670", Offset = "0x5290A70", VA = "0x185291670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x52915D0", Offset = "0x52909D0", VA = "0x1852915D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x52915D0", Offset = "0x52909D0", VA = "0x1852915D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x555BFF0", Offset = "0x555B3F0", VA = "0x18555BFF0")]
	public CNJAGIAHCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x555B990", Offset = "0x555AD90", VA = "0x18555B990")]
	public void AOHLLDNPMGN(byte[] NPNCGJAPKIL, int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x555BAB0", Offset = "0x555AEB0", VA = "0x18555BAB0")]
	public bool BAGFKPIACCN(ArraySegment<byte> EBOEHIFNNLM, out int JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x555BF60", Offset = "0x555B360", VA = "0x18555BF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x555BC50", Offset = "0x555B050", VA = "0x18555BC50")]
	private static void IKMAMJJEKMJ(IEnumerable<GICCFFEKJMD> NGLNBKKEJKJ, StringBuilder LMKNLEBCBAL, int ELMCLGINMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x555BBA0", Offset = "0x555AFA0", VA = "0x18555BBA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x555BBA0", Offset = "0x555AFA0", VA = "0x18555BBA0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x555BEF0", Offset = "0x555B2F0", VA = "0x18555BEF0")]
	[IteratorStateMachine(typeof(HLCEHJFLDDB))]
	private static IEnumerable<KeyValuePair<string, int>> OAOKGDCGADJ(IEnumerable<GICCFFEKJMD> NGLNBKKEJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x555BB70", Offset = "0x555AF70", VA = "0x18555BB70")]
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
	[Cpp2IlInjected.Address(RVA = "0x53109F0", Offset = "0x530FDF0", VA = "0x1853109F0")]
	public static ulong OLMCPIGCKDJ(byte[] NPNCGJAPKIL, ref int ELOEOOGBENM, ref int IFCGFMEPAHB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class COOKHFPBHNA
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x555C060", Offset = "0x555B460", VA = "0x18555C060")]
	public static void CDEPEGAJOEL(ref byte[] NPNCGJAPKIL, int ELOEOOGBENM, int FOFPICKAACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x555C1A0", Offset = "0x555B5A0", VA = "0x18555C1A0")]
	public static void OLEKLNHJKIJ(ref byte[] PFCDNINKMFA, int HBBFBJDJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x555C2B0", Offset = "0x555B6B0", VA = "0x18555C2B0")]
	public static byte[] PHLGDIOFHPP(byte[] NKOMPJIJHJB, int HBBFBJDJKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class BCNHOFPALFA
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x554F230", Offset = "0x554E630", VA = "0x18554F230")]
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
		[Cpp2IlInjected.Address(RVA = "0x44B1630", Offset = "0x44B0A30", VA = "0x1844B1630", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32EA2A0", Offset = "0x32E96A0", VA = "0x1832EA2A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x27E0CC0", Offset = "0x27E00C0", VA = "0x1827E0CC0")]
		[DebuggerHidden]
		public DFBOLIJOCJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x32E8B00", Offset = "0x32E7F00", VA = "0x1832E8B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x32E9AA0", Offset = "0x32E8EA0", VA = "0x1832E9AA0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DA1DD0", Offset = "0x2DA11D0", VA = "0x182DA1DD0")]
	public LFOALGNFDPH(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1E00", Offset = "0x2DA1200", VA = "0x182DA1E00")]
	public LFOALGNFDPH(int DOMGBHGFPFL, float CGFBCPMAEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0310", Offset = "0x2D9F710", VA = "0x182DA0310")]
	public void AOHLLDNPMGN(byte[] EBOEHIFNNLM, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0DE0", Offset = "0x2DA01E0", VA = "0x182DA0DE0")]
	private bool GLNKOOBMPIL(byte[] EBOEHIFNNLM, T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0A30", Offset = "0x2D9FE30", VA = "0x182DA0A30")]
	public bool CPKINNFJFHF(ArraySegment<byte> EBOEHIFNNLM, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1D10", Offset = "0x2DA1110", VA = "0x182DA1D10")]
	private static ulong JEGMKCDKIEG(byte[] BIAIPPDLOMD, int ELOEOOGBENM, int OCCKKIPCFBH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1D70", Offset = "0x2DA1170", VA = "0x182DA1D70")]
	private static int KIAGJECCKCG(int LMLDMGPNIBA, float CGFBCPMAEFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1B60", Offset = "0x2DA0F60", VA = "0x182DA1B60", Slot = "4")]
	[IteratorStateMachine(typeof(global::LFOALGNFDPH<>.DFBOLIJOCJP))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1DA0", Offset = "0x2DA11A0", VA = "0x182DA1DA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x529F7F0", Offset = "0x529EBF0", VA = "0x18529F7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x529F840", Offset = "0x529EC40", VA = "0x18529F840")]
	static OPHAAIPGCLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x529FAC0", Offset = "0x529EEC0", VA = "0x18529FAC0")]
	public OPHAAIPGCLK(byte[] GMDEMDDCHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x529F6D0", Offset = "0x529EAD0", VA = "0x18529F6D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53155B0", Offset = "0x53149B0", VA = "0x1853155B0")]
	public KAGENBBFNJE(ref Guid JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5314160", Offset = "0x5313560", VA = "0x185314160")]
	public KAGENBBFNJE(ref ArraySegment<byte> PIMPDLEILKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5312B70", Offset = "0x5311F70", VA = "0x185312B70")]
	private static byte DFKLAKNNIDE(byte[] NPNCGJAPKIL, int KCDLOPCGIHA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5313F80", Offset = "0x5313380", VA = "0x185313F80")]
	private static byte IAOCKCNJCLO(byte GPHMIGDKMEO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5312C30", Offset = "0x5312030", VA = "0x185312C30")]
	public void EFLAGMJPJKC(byte[] IEGPGBKLAIF, int ELOEOOGBENM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class APLBHDALFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x554AD80", Offset = "0x554A180", VA = "0x18554AD80")]
	public static bool HLFBPIJCJDE(byte ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x554AA30", Offset = "0x5549E30", VA = "0x18554AA30")]
	public static bool FBBJEHONPIM(byte ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x554AAA0", Offset = "0x5549EA0", VA = "0x18554AAA0")]
	public static sbyte FIPNAOJLBAE(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x554B280", Offset = "0x554A680", VA = "0x18554B280")]
	public static short PPNOBAEHOGF(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x554AF90", Offset = "0x554A390", VA = "0x18554AF90")]
	public static int JOEICHNIDGO(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x554B160", Offset = "0x554A560", VA = "0x18554B160")]
	public static long OBFBHKKJEIH(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x554B210", Offset = "0x554A610", VA = "0x18554B210")]
	public static byte ONKDCBDEKBB(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x554B000", Offset = "0x554A400", VA = "0x18554B000")]
	public static ushort KPFMCNLJDOG(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x554A1E0", Offset = "0x55495E0", VA = "0x18554A1E0")]
	public static uint CCNDEEDCGBF(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x554AE80", Offset = "0x554A280", VA = "0x18554AE80")]
	public static ulong JGECLHMFKKD(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x554B070", Offset = "0x554A470", VA = "0x18554B070")]
	public static float MEOBEEKJDLP(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x554AD90", Offset = "0x554A190", VA = "0x18554AD90")]
	public static double JAJFEMDKJEL(byte[] NPNCGJAPKIL, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x554A260", Offset = "0x5549660", VA = "0x18554A260")]
	public static int EOACNFMILOI(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, ulong JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x55495B0", Offset = "0x55489B0", VA = "0x1855495B0")]
	public static int BMDFCIEFFAP(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, long JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x554AB10", Offset = "0x5549F10", VA = "0x18554AB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
		[DebuggerHidden]
		public MNHFECMPKCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5297C80", Offset = "0x5297080", VA = "0x185297C80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5297820", Offset = "0x5296C20", VA = "0x185297820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5297D70", Offset = "0x5297170", VA = "0x185297D70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5297DC0", Offset = "0x52971C0", VA = "0x185297DC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5297C40", Offset = "0x5297040", VA = "0x185297C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5297B90", Offset = "0x5296F90", VA = "0x185297B90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5297B90", Offset = "0x5296F90", VA = "0x185297B90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
		[DebuggerHidden]
		public JJLPJDIHKJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5292160", Offset = "0x5291560", VA = "0x185292160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5291D00", Offset = "0x5291100", VA = "0x185291D00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5292250", Offset = "0x5291650", VA = "0x185292250")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x52922A0", Offset = "0x52916A0", VA = "0x1852922A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5292120", Offset = "0x5291520", VA = "0x185292120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5292070", Offset = "0x5291470", VA = "0x185292070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5292070", Offset = "0x5291470", VA = "0x185292070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x531A830", Offset = "0x5319C30", VA = "0x18531A830")]
	public static bool NFEFJLHLNCD(this TypeInfo DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x531A4E0", Offset = "0x53198E0", VA = "0x18531A4E0")]
	public static bool EFCJBEOIOIL(this TypeInfo DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x531A760", Offset = "0x5319B60", VA = "0x18531A760")]
	public static IEnumerable<PropertyInfo> MACAEDLEMDI(this Type DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x531A600", Offset = "0x5319A00", VA = "0x18531A600")]
	[IteratorStateMachine(typeof(MNHFECMPKCF))]
	private static IEnumerable<PropertyInfo> EPDAJBDIILN(Type DDJDPMGLPAE, HashSet<string> LMONEMBKGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x531A690", Offset = "0x5319A90", VA = "0x18531A690")]
	public static IEnumerable<FieldInfo> KPHOLGGFPAE(this Type DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x531A450", Offset = "0x5319850", VA = "0x18531A450")]
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
	[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0")]
	public static string GMNJDPICPAF(string CKNAFFDCOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x554F890", Offset = "0x554EC90", VA = "0x18554F890")]
	public static string PEOPDDFOKHH(string CKNAFFDCOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x554F6A0", Offset = "0x554EAA0", VA = "0x18554F6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x438C5E0", Offset = "0x438B9E0", VA = "0x18438C5E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x438C560", Offset = "0x438B960", VA = "0x18438C560")]
		private int HGPJFHAOHMD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public GKFDKODJJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
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
	[Cpp2IlInjected.Address(RVA = "0x40E7A70", Offset = "0x40E6E70", VA = "0x1840E7A70")]
	public MEEGMHDFAGF(int DOMGBHGFPFL = 4, float CGFBCPMAEFH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x40E77F0", Offset = "0x40E6BF0", VA = "0x1840E77F0")]
	public bool PJJKMDOPJFF(Type EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x40E7900", Offset = "0x40E6D00", VA = "0x1840E7900")]
	public bool PJJKMDOPJFF(Type EBOEHIFNNLM, Func<Type, TValue> IFANJKMGAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x40E6B60", Offset = "0x40E5F60", VA = "0x1840E6B60")]
	private bool GLNKOOBMPIL(Type EBOEHIFNNLM, Func<Type, TValue> IFANJKMGAHF, out TValue PLFJIEEKHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x40E71D0", Offset = "0x40E65D0", VA = "0x1840E71D0")]
	private bool LEPALKLIEMC(HBOAPKNLPGH[] BIKGHKHICDJ, Type AFJLFMBHLPF, HBOAPKNLPGH CFCMJPHPLHP, Func<Type, TValue> IFANJKMGAHF, out TValue PLFJIEEKHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x40E65C0", Offset = "0x40E59C0", VA = "0x1840E65C0")]
	public bool CPKINNFJFHF(Type EBOEHIFNNLM, out TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x40E7630", Offset = "0x40E6A30", VA = "0x1840E7630")]
	public TValue MGNJLCPLAEP(Type EBOEHIFNNLM, Func<Type, TValue> IFANJKMGAHF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1D70", Offset = "0x2DA1170", VA = "0x182DA1D70")]
	private static int KIAGJECCKCG(int LMLDMGPNIBA, float CGFBCPMAEFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x40E6860", Offset = "0x40E5C60", VA = "0x1840E6860")]
	private static void EBPOMHOCDHP(ref HBOAPKNLPGH HCEAGEMIOND, HBOAPKNLPGH JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x40E6860", Offset = "0x40E5C60", VA = "0x1840E6860")]
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
	[Cpp2IlInjected.Address(RVA = "0x53037E0", Offset = "0x5302BE0", VA = "0x1853037E0")]
	public TypeBuilder NLAFCGAAOGO(string IGHJIHNAPBA, TypeAttributes PKPEBMBGKAA, Type GPFONCECPBK, Type[] BHABKHHGPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x53038B0", Offset = "0x5302CB0", VA = "0x1853038B0")]
	public DDELIMNFFNE(string DCFLKNPNLJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class GAOIBLABNGB
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5308F80", Offset = "0x5308380", VA = "0x185308F80")]
	private static MethodInfo MDHOJHDPNJE(LambdaExpression ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3776A00", Offset = "0x3775E00", VA = "0x183776A00")]
	public static MethodInfo IGLNAJDMJOC<T>(Expression<Func<T>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3776A00", Offset = "0x3775E00", VA = "0x183776A00")]
	public static MethodInfo IGLNAJDMJOC<T, TR>(Expression<Func<T, TR>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3776A00", Offset = "0x3775E00", VA = "0x183776A00")]
	public static MethodInfo IGLNAJDMJOC<T>(Expression<Action<T>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3776A00", Offset = "0x3775E00", VA = "0x183776A00")]
	public static MethodInfo IGLNAJDMJOC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> ECMKNJHJFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3776A10", Offset = "0x3775E10", VA = "0x183776A10")]
	private static MemberInfo OOGFLOGOHLH<T>(Expression<T> GEMNKBDIDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x37769A0", Offset = "0x3775DA0", VA = "0x1837769A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5303EC0", Offset = "0x53032C0", VA = "0x185303EC0")]
	public DFAJAOEBAOO(ILGenerator KHLPOCHIMCH, int BHOLCDOGKAG, bool PIDPOAKILGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5303E30", Offset = "0x5303230", VA = "0x185303E30")]
	public DFAJAOEBAOO(ILGenerator KHLPOCHIMCH, int BHOLCDOGKAG, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5303D10", Offset = "0x5303110", VA = "0x185303D10")]
	public void BFHMNPNMBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class LJDAJGMPFKC
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5318AB0", Offset = "0x5317EB0", VA = "0x185318AB0")]
	public static void ALLHMCCMNJA(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5318A70", Offset = "0x5317E70", VA = "0x185318A70")]
	public static void ALLHMCCMNJA(this ILGenerator KHLPOCHIMCH, LocalBuilder OPMPONOLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5319850", Offset = "0x5318C50", VA = "0x185319850")]
	public static void LBLKGDGLCAN(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5319810", Offset = "0x5318C10", VA = "0x185319810")]
	public static void LBLKGDGLCAN(this ILGenerator KHLPOCHIMCH, LocalBuilder OPMPONOLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5319B90", Offset = "0x5318F90", VA = "0x185319B90")]
	public static void MOHBJGGMIJF(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5319A80", Offset = "0x5318E80", VA = "0x185319A80")]
	public static void MOHBJGGMIJF(this ILGenerator KHLPOCHIMCH, LocalBuilder OPMPONOLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5319C80", Offset = "0x5319080", VA = "0x185319C80")]
	public static void PMOFEMFDHAA(this ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5318E80", Offset = "0x5318280", VA = "0x185318E80")]
	public static void EGEKAANNPJF(this ILGenerator KHLPOCHIMCH, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x53190A0", Offset = "0x53184A0", VA = "0x1853190A0")]
	public static void ICGCBMAJPML(this ILGenerator KHLPOCHIMCH, int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x53194F0", Offset = "0x53188F0", VA = "0x1853194F0")]
	public static void IKIIBDJDECF(this ILGenerator KHLPOCHIMCH, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5318CE0", Offset = "0x53180E0", VA = "0x185318CE0")]
	public static void CIAECLHHPOH(this ILGenerator KHLPOCHIMCH, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x53195E0", Offset = "0x53189E0", VA = "0x1853195E0")]
	public static void KHMOIIBIFOA(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x5318E90", Offset = "0x5318290", VA = "0x185318E90")]
	public static void GALNOOBCGGC(this ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5318D90", Offset = "0x5318190", VA = "0x185318D90")]
	public static void DCIFBNIGAJN(this ILGenerator KHLPOCHIMCH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5318F10", Offset = "0x5318310", VA = "0x185318F10")]
	public static void GKLBDPECOPD(this ILGenerator KHLPOCHIMCH, MethodInfo DJMIEBAMKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5319010", Offset = "0x5318410", VA = "0x185319010")]
	public static void HMNGEBLDONO(this ILGenerator KHLPOCHIMCH, FieldInfo BLFOEOAOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x53189E0", Offset = "0x5317DE0", VA = "0x1853189E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MGHHEFPJCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x52976B0", Offset = "0x5296AB0", VA = "0x1852976B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GNBJKCFFJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LNONEMEBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x554F9A0", Offset = "0x554EDA0", VA = "0x18554F9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PJEGGJEIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DD0", Offset = "0x7D31D0", VA = "0x1807D3DD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x87FA70", Offset = "0x87EE70", VA = "0x18087FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PIKDHBBGGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DE0", Offset = "0x7D31E0", VA = "0x1807D3DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA30E00", Offset = "0xA30200", VA = "0x180A30E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo JAOFAKPEFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo BGKGAFNMNND
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x1806E1830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo FNIAMHKLAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6E43E0", Offset = "0x6E37E0", VA = "0x1806E43E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x554FCA0", Offset = "0x554F0A0", VA = "0x18554FCA0")]
	protected BJHIALAFHDM(Type DDJDPMGLPAE, string IGHJIHNAPBA, string KIKOLEGOJKD, bool NCNFCBCNCMF, bool LOLGAHFDDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x554FED0", Offset = "0x554F2D0", VA = "0x18554FED0")]
	public BJHIALAFHDM(FieldInfo HHCANBNBHNP, string IGHJIHNAPBA, bool NHNFPKPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x554FD20", Offset = "0x554F120", VA = "0x18554FD20")]
	public BJHIALAFHDM(PropertyInfo HHCANBNBHNP, string IGHJIHNAPBA, bool NHNFPKPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x554FB30", Offset = "0x554EF30", VA = "0x18554FB30")]
	private static MethodInfo OKJIMJONKJM(MemberInfo HHCANBNBHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x3C19D80", Offset = "0x3C19180", VA = "0x183C19D80")]
	public T BJADLDDDMOP<T>(bool CIHAJCFGKFL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x554F9B0", Offset = "0x554EDB0", VA = "0x18554F9B0", Slot = "4")]
	public virtual void JHLFJGIOLDM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x554FA70", Offset = "0x554EE70", VA = "0x18554FA70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5545320", Offset = "0x5544720", VA = "0x185545320")]
	public AJNBIGAKHEN(string IGHJIHNAPBA, string HJNPIGFAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5545220", Offset = "0x5544620", VA = "0x185545220", Slot = "4")]
	public override void JHLFJGIOLDM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x55452E0", Offset = "0x55446E0", VA = "0x1855452E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x529AA80", Offset = "0x5299E80", VA = "0x18529AA80")]
	public NGCDBJCNHGF(string IGHJIHNAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x529A300", Offset = "0x5299700", VA = "0x18529A300", Slot = "4")]
	public override void JHLFJGIOLDM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x529A3D0", Offset = "0x52997D0", VA = "0x18529A3D0", Slot = "5")]
	public override void MOPANCFIDJM(ILGenerator KHLPOCHIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x529A410", Offset = "0x5299810", VA = "0x18529A410")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OBBJBCDBKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8180E0", Offset = "0x8174E0", VA = "0x1808180E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OLKPHOMDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A5570", Offset = "0x8A4970", VA = "0x1808A5570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5580", Offset = "0x8A4980", VA = "0x1808A5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo IPJCOGPCKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BJHIALAFHDM[] IAHGOBHIGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BJHIALAFHDM[] FNPAPKLCIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x529B580", Offset = "0x529A980", VA = "0x18529B580")]
	public NOEPBKCLECE(Type DDJDPMGLPAE, Func<string, string> JLJALPPAEGA, bool NHNFPKPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x529B490", Offset = "0x529A890", VA = "0x18529B490")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D8F410", Offset = "0x2D8E810", VA = "0x182D8F410")]
	public IFFICNKKECF(ulong PAOJMJOOEAH, int DFCACCOGAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x530D5B0", Offset = "0x530C9B0", VA = "0x18530D5B0")]
	public void ENDMOOABFFG(ref IFFICNKKECF IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x530D660", Offset = "0x530CA60", VA = "0x18530D660")]
	public static IFFICNKKECF JLHKNLFAFLI(ref IFFICNKKECF FAMKPEGNHFC, ref IFFICNKKECF GPHMIGDKMEO)
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x530D670", Offset = "0x530CA70", VA = "0x18530D670")]
	public void OHNILAFCBHP(ref IFFICNKKECF IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x530D5C0", Offset = "0x530C9C0", VA = "0x18530D5C0")]
	public static IFFICNKKECF JKNEPOEMDMJ(ref IFFICNKKECF FAMKPEGNHFC, ref IFFICNKKECF GPHMIGDKMEO)
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x530D520", Offset = "0x530C920", VA = "0x18530D520")]
	public void BOFNDPHBABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x530D560", Offset = "0x530C960", VA = "0x18530D560")]
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
	[Cpp2IlInjected.Address(RVA = "0xB33730", Offset = "0xB32B30", VA = "0x180B33730")]
	public FMMNMNJCIMG(byte[] IEGPGBKLAIF, int DACBJNCMNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x53086D0", Offset = "0x5307AD0", VA = "0x1853086D0")]
	public void ECHDFHMGOPJ(byte IGMDKJEALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5308730", Offset = "0x5307B30", VA = "0x185308730")]
	public void EDJIMIEPDOC(byte[] IGMDKJEALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5308580", Offset = "0x5307980", VA = "0x185308580")]
	public void COOKAACODFG(byte[] IGMDKJEALIM, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5308620", Offset = "0x5307A20", VA = "0x185308620")]
	public void COOKAACODFG(byte[] IGMDKJEALIM, int IDCHKLCNMBN, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5308500", Offset = "0x5307900", VA = "0x185308500")]
	public void AHEGGOJALOG(byte ECKJDAFJMBK, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x53087D0", Offset = "0x5307BD0", VA = "0x1853087D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x554D6D0", Offset = "0x554CAD0", VA = "0x18554D6D0")]
	private static byte[] ICLJJPJEEHI(int PCAHMJECHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x554D990", Offset = "0x554CD90", VA = "0x18554D990")]
	private static byte[] JDHEKAECCGI(int PCAHMJECHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x554EBA0", Offset = "0x554DFA0", VA = "0x18554EBA0")]
	public static int PFAAGCBPJKK(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, float JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x554ECC0", Offset = "0x554E0C0", VA = "0x18554ECC0")]
	public static int PFAAGCBPJKK(ref byte[] IEGPGBKLAIF, int ELOEOOGBENM, double JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x554E440", Offset = "0x554D840", VA = "0x18554E440")]
	private static bool OLGKMDJCLGP(byte[] IEGPGBKLAIF, int ONCBCCLEFOH, ulong DEDOLDAEKHO, ulong LFLENDCEJMA, ulong IFCGFMEPAHB, ulong OLBMNELBGFG, ulong LMIAMGJLLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x554D5B0", Offset = "0x554C9B0", VA = "0x18554D5B0")]
	private static void HLFKHHJGPCE(uint NDBINFPGNDL, int NBJPPKNPFOO, out uint LEDBDMFAIOB, out int HLOJLNFDHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x554DC20", Offset = "0x554D020", VA = "0x18554DC20")]
	private static bool NNHJMAKJJOE(IFFICNKKECF BNFCMIKMLPJ, IFFICNKKECF ONCKMLEEMNO, IFFICNKKECF MPIAPABHKNL, byte[] IEGPGBKLAIF, out int ONCBCCLEFOH, out int EJNNKONGFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x554D060", Offset = "0x554C460", VA = "0x18554D060")]
	private static bool DKCOCGAHBHP(double AEOKKHKBMBB, DEGGIMDEBLJ PDGDINPCGGH, byte[] IEGPGBKLAIF, out int ONCBCCLEFOH, out int PKFFIDPHBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x554CF50", Offset = "0x554C350", VA = "0x18554CF50")]
	private static bool AGBLMNFIMDG(double AEOKKHKBMBB, DEGGIMDEBLJ PDGDINPCGGH, byte[] IEGPGBKLAIF, out int ONCBCCLEFOH, out int DHKHFCMFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x554D420", Offset = "0x554C820", VA = "0x18554D420")]
	private static bool GFOCFOPMAMI(double JFBPNBNBHOE, ref FMMNMNJCIMG NKKJANEOHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x554E540", Offset = "0x554D940", VA = "0x18554E540")]
	private static bool OMMOHENEPPC(double JFBPNBNBHOE, ref FMMNMNJCIMG NKKJANEOHPD, FEBOLLMMNND PDGDINPCGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x554D7B0", Offset = "0x554CBB0", VA = "0x18554D7B0")]
	private static void IONBCFFLLFO(byte[] JAJABKENINL, int ONCBCCLEFOH, int DHKHFCMFLPL, int CHHNBIIJKKL, ref FMMNMNJCIMG NKKJANEOHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x554E140", Offset = "0x554D540", VA = "0x18554E140")]
	private static void OKHIKMNFONE(byte[] JAJABKENINL, int ONCBCCLEFOH, int DFCACCOGAIG, ref FMMNMNJCIMG NKKJANEOHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x554DA70", Offset = "0x554CE70", VA = "0x18554DA70")]
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
	[Cpp2IlInjected.Address(RVA = "0x172FCE0", Offset = "0x172F0E0", VA = "0x18172FCE0")]
	public HPAEIGJIFFG(double ABLKMJLKIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x530D420", Offset = "0x530C820", VA = "0x18530D420")]
	public HPAEIGJIFFG(IFFICNKKECF ABLKMJLKIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x530D030", Offset = "0x530C430", VA = "0x18530D030")]
	public IFFICNKKECF GNHMFFCAAFJ()
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x530D1E0", Offset = "0x530C5E0", VA = "0x18530D1E0")]
	public IFFICNKKECF KDJEEFNMDIE()
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E30", Offset = "0x6E1230", VA = "0x1806E1E30")]
	public ulong NDPCECIENEN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x530CFA0", Offset = "0x530C3A0", VA = "0x18530CFA0")]
	public double FGCBKDFDKNG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x530CEC0", Offset = "0x530C2C0", VA = "0x18530CEC0")]
	public double BPNKDAOCHFK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x530D0E0", Offset = "0x530C4E0", VA = "0x18530D0E0")]
	public int IEAKIKBIAGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x530D0B0", Offset = "0x530C4B0", VA = "0x18530D0B0")]
	public ulong HKGBIIADNOH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x530CE50", Offset = "0x530C250", VA = "0x18530CE50")]
	public bool AJLHINPFOAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x530CF50", Offset = "0x530C350", VA = "0x18530CF50")]
	public bool DPFPKNKADKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x530CF70", Offset = "0x530C370", VA = "0x18530CF70")]
	public bool EBKEOCIIMMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x530D270", Offset = "0x530C670", VA = "0x18530D270")]
	public bool KECHOOHNMEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x530D1C0", Offset = "0x530C5C0", VA = "0x18530D1C0")]
	public int JGPOFHGOHGL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x530D2B0", Offset = "0x530C6B0", VA = "0x18530D2B0")]
	public void NHLBFKCCGPI(out IFFICNKKECF KAFCEMMEAGI, out IFFICNKKECF AKPEJPKNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x530CE70", Offset = "0x530C270", VA = "0x18530CE70")]
	public bool BGGNLNHHKNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x530D1B0", Offset = "0x530C5B0", VA = "0x18530D1B0")]
	public double JFBPNBNBHOE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x530D400", Offset = "0x530C800", VA = "0x18530D400")]
	public static int PHDDPGNIPAM(int FGLCLGEEKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x530D2A0", Offset = "0x530C6A0", VA = "0x18530D2A0")]
	public static double KJKIFNCLCDF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x530D110", Offset = "0x530C510", VA = "0x18530D110")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FE930", Offset = "0x6FDD30", VA = "0x1806FE930")]
	public DFKJDJBIOHB(float JBOJGNNLCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5303F50", Offset = "0x5303350", VA = "0x185303F50")]
	public IFFICNKKECF GNHMFFCAAFJ()
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7250B0", VA = "0x180725CB0")]
	public uint BJIBDIKELGB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5303FD0", Offset = "0x53033D0", VA = "0x185303FD0")]
	public int IEAKIKBIAGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5303FB0", Offset = "0x53033B0", VA = "0x185303FB0")]
	public uint HKGBIIADNOH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5303F00", Offset = "0x5303300", VA = "0x185303F00")]
	public bool AJLHINPFOAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5303FF0", Offset = "0x53033F0", VA = "0x185303FF0")]
	public void NHLBFKCCGPI(out IFFICNKKECF KAFCEMMEAGI, out IFFICNKKECF AKPEJPKNONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5303F10", Offset = "0x5303310", VA = "0x185303F10")]
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
	[Cpp2IlInjected.Address(RVA = "0x52A2CC0", Offset = "0x52A20C0", VA = "0x1852A2CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5559A90", Offset = "0x5558E90", VA = "0x185559A90")]
	public static void FKCJHAIIBOO(int AHDDPKKJFPC, int OOAJFPDEAHL, out IFFICNKKECF LEDBDMFAIOB, out int PKFFIDPHBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5559990", Offset = "0x5558D90", VA = "0x185559990")]
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
		[Cpp2IlInjected.Address(RVA = "0x53084C0", Offset = "0x53078C0", VA = "0x1853084C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xA93A00", Offset = "0xA92E00", VA = "0x180A93A00")]
	public FJGEJJLKKFI(byte[] NPNCGJAPKIL, int IDCHKLCNMBN, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x725CC0", Offset = "0x7250C0", VA = "0x180725CC0")]
	public int ONCBCCLEFOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5308460", Offset = "0x5307860", VA = "0x185308460")]
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
	[Cpp2IlInjected.Address(RVA = "0x5546000", Offset = "0x5545400", VA = "0x185546000")]
	private static byte[] BCEMCIHNCLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5547630", Offset = "0x5546A30", VA = "0x185547630")]
	private static FJGEJJLKKFI OOPEAFNFFAM(FJGEJJLKKFI IEGPGBKLAIF)
	{
		return default(FJGEJJLKKFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5547130", Offset = "0x5546530", VA = "0x185547130")]
	private static FJGEJJLKKFI LOMGAHDADLN(FJGEJJLKKFI IEGPGBKLAIF)
	{
		return default(FJGEJJLKKFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x55460F0", Offset = "0x55454F0", VA = "0x1855460F0")]
	private static void DBLBIFOFDDB(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG, byte[] DEGLJFFDMOE, out int CAFIGJGIBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5546E90", Offset = "0x5546290", VA = "0x185546E90")]
	private static void LLDPMPPDCEF(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG, byte[] CKDGANBCOHE, int LGOEFNMFLFL, out FJGEJJLKKFI INCEHDPPNMI, out int IEHOENNHIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5546E00", Offset = "0x5546200", VA = "0x185546E00")]
	private static ulong LKLGNDDGAAA(FJGEJJLKKFI IEGPGBKLAIF, out int KDOEKCNBALF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x55474E0", Offset = "0x55468E0", VA = "0x1855474E0")]
	private static void MAMFHMGOOKC(FJGEJJLKKFI IEGPGBKLAIF, out IFFICNKKECF APCBFLNDMMJ, out int PIJGMNHLHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x55461B0", Offset = "0x55455B0", VA = "0x1855461B0")]
	private static bool DECDCEOCEMA(FJGEJJLKKFI INCEHDPPNMI, int DFCACCOGAIG, out double APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5546C50", Offset = "0x5546050", VA = "0x185546C50")]
	private static IFFICNKKECF ILBJMCDEABC(int DFCACCOGAIG)
	{
		return default(IFFICNKKECF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x55465A0", Offset = "0x55459A0", VA = "0x1855465A0")]
	private static bool DKDAMIHEJHF(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG, out double APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5546B10", Offset = "0x5545F10", VA = "0x185546B10")]
	private static bool HLIGKPOHKFP(FJGEJJLKKFI INCEHDPPNMI, int DFCACCOGAIG, out double DBHOJLOENNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x55471E0", Offset = "0x55465E0", VA = "0x1855471E0")]
	public static double? LPECKKMDMOK(FJGEJJLKKFI IEGPGBKLAIF, int DFCACCOGAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5547300", Offset = "0x5546700", VA = "0x185547300")]
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
		[Cpp2IlInjected.Address(RVA = "0x529B050", Offset = "0x529A450", VA = "0x18529B050")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xB33730", Offset = "0xB32B30", VA = "0x180B33730")]
	public NICOJCFNMJB(byte[] IEGPGBKLAIF, int ELOEOOGBENM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x529AFF0", Offset = "0x529A3F0", VA = "0x18529AFF0")]
	public static NICOJCFNMJB HHJHJGJNLCE(NICOJCFNMJB PKCJMFFNILJ)
	{
		return default(NICOJCFNMJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x529AF30", Offset = "0x529A330", VA = "0x18529AF30")]
	public static NICOJCFNMJB FOACHAMOMCH(NICOJCFNMJB PKCJMFFNILJ, int ONCBCCLEFOH)
	{
		return default(NICOJCFNMJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x529B0E0", Offset = "0x529A4E0", VA = "0x18529B0E0")]
	public static int ONNNIIHIBPF(NICOJCFNMJB KPCLHBOMAKO, NICOJCFNMJB NFBNADMIDIB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x529AF80", Offset = "0x529A380", VA = "0x18529AF80")]
	public static bool GJOJIEKGOHO(NICOJCFNMJB KPCLHBOMAKO, NICOJCFNMJB NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x529AEC0", Offset = "0x529A2C0", VA = "0x18529AEC0")]
	public static bool ALCENKEOHOJ(NICOJCFNMJB KPCLHBOMAKO, NICOJCFNMJB NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x529AFA0", Offset = "0x529A3A0", VA = "0x18529AFA0")]
	public static bool GJOJIEKGOHO(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x529AE70", Offset = "0x529A270", VA = "0x18529AE70")]
	public static bool ALCENKEOHOJ(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x529AE70", Offset = "0x529A270", VA = "0x18529AE70")]
	public static bool ALCENKEOHOJ(NICOJCFNMJB KPCLHBOMAKO, byte NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x529B090", Offset = "0x529A490", VA = "0x18529B090")]
	public static bool NKKNDMACBNB(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x529B000", Offset = "0x529A400", VA = "0x18529B000")]
	public static bool HLFPCDHPGHG(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x529AEE0", Offset = "0x529A2E0", VA = "0x18529AEE0")]
	public static bool ALFHADPLCNH(NICOJCFNMJB KPCLHBOMAKO, char NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x529B100", Offset = "0x529A500", VA = "0x18529B100")]
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
	[Cpp2IlInjected.Address(RVA = "0x554C840", Offset = "0x554BC40", VA = "0x18554C840")]
	private static byte[] KEFCAMGPPIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x554C580", Offset = "0x554B980", VA = "0x18554C580")]
	private static byte[] EPNPKABABKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x554CC30", Offset = "0x554C030", VA = "0x18554CC30")]
	public static double POCFKJIMFJH(byte[] IEGPGBKLAIF, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x554C670", Offset = "0x554BA70", VA = "0x18554C670")]
	public static float GILDFGADNCD(byte[] IEGPGBKLAIF, int ELOEOOGBENM, out int BFMGPMGPKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x554C930", Offset = "0x554BD30", VA = "0x18554C930")]
	private static bool KNIOAIPHAFN(int BIAIPPDLOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x554CAD0", Offset = "0x554BED0", VA = "0x18554CAD0")]
	private static bool MKPMKPJDABE(ref NICOJCFNMJB BEKIFNKENPL, NICOJCFNMJB HEGLMOCOEGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x554C730", Offset = "0x554BB30", VA = "0x18554C730")]
	private static bool JJBMAMCPKEF(ref NICOJCFNMJB BEKIFNKENPL, NICOJCFNMJB HEGLMOCOEGO, byte[] JDFFPGPNNEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x554CBE0", Offset = "0x554BFE0", VA = "0x18554CBE0")]
	private static bool OFGBKAOJJLL(ref NICOJCFNMJB HCCDBMBFABP, byte[] IGMDKJEALIM, int ELOEOOGBENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x554CAB0", Offset = "0x554BEB0", VA = "0x18554CAB0")]
	private static double LPKLFJLEAID(bool BKGHGGNEJHB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x554B2F0", Offset = "0x554A6F0", VA = "0x18554B2F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C638F0", Offset = "0x3C62CF0", VA = "0x183C638F0")]
	public AAHPCJIICFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x27E0CC0", Offset = "0x27E00C0", VA = "0x1827E0CC0")]
	public AAHPCJIICFB(MJAPBCCONDF GKCAAFCMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3C61280", Offset = "0x3C60680", VA = "0x183C61280", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3C62340", Offset = "0x3C61740", VA = "0x183C62340", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C638F0", Offset = "0x3C62CF0", VA = "0x183C638F0")]
	public MBEFPKKDJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x27E0CC0", Offset = "0x27E00C0", VA = "0x1827E0CC0")]
	public MBEFPKKDJJN(MJAPBCCONDF GKCAAFCMMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x40DF190", Offset = "0x40DE590", VA = "0x1840DF190", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, List<T> JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x40DFFA0", Offset = "0x40DF3A0", VA = "0x1840DFFA0", Slot = "5")]
	public List<T> LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class JMFHMGPBKCL<TElement, TIntermediate, TEnumerator, TCollection> : global::JJBJICJFEAB<TCollection>, PKHFALLONLG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3240", Offset = "0x3EB2640", VA = "0x183EB3240", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, TCollection JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3DA0", Offset = "0x3EB31A0", VA = "0x183EB3DA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	protected JMFHMGPBKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class JDGNDGNOJGO<TElement, TIntermediate, TCollection> : global::JMFHMGPBKCL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3386170", Offset = "0x3385570", VA = "0x183386170", Slot = "6")]
	protected override IEnumerator<TElement> AAODCIKMEEL(TCollection GEMNKBDIDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1E2EC50", Offset = "0x1E2E050", VA = "0x181E2EC50")]
	protected JDGNDGNOJGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class ANLIKJFOFCM<TElement, TCollection> : global::JDGNDGNOJGO<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected sealed override TCollection HPPHODAOIFC(ref TCollection CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class AIHKBGPLHDO<TElement, TCollection> : global::ANLIKJFOFCM<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x343D490", Offset = "0x343C890", VA = "0x18343D490", Slot = "7")]
	protected override TCollection BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x343D3B0", Offset = "0x343C7B0", VA = "0x18343D3B0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref TCollection HGLAIHECBOI, int BELCAJFDAHD, TElement JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class ONCEMGKJJIN<T> : global::JMFHMGPBKCL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x29B4E90", Offset = "0x29B4290", VA = "0x1829B4E90", Slot = "8")]
	protected override void AOHLLDNPMGN(ref LinkedList<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override LinkedList<T> HPPHODAOIFC(ref LinkedList<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override LinkedList<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC390", Offset = "0x2DFB790", VA = "0x182DFC390", Slot = "6")]
	protected override LinkedList<T>.Enumerator AAODCIKMEEL(LinkedList<T> GEMNKBDIDNJ)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class KIACIEOEJKO<T> : global::JMFHMGPBKCL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x29B4E90", Offset = "0x29B4290", VA = "0x1829B4E90", Slot = "8")]
	protected override void AOHLLDNPMGN(ref Queue<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override Queue<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x30DAFF0", Offset = "0x30DA3F0", VA = "0x1830DAFF0", Slot = "6")]
	protected override Queue<T>.Enumerator AAODCIKMEEL(Queue<T> GEMNKBDIDNJ)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override Queue<T> HPPHODAOIFC(ref Queue<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class AJPEKGAKJCO<T> : global::JMFHMGPBKCL<T, global::LFCMPLINDCF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x27AC700", Offset = "0x27ABB00", VA = "0x1827AC700", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x30B5530", Offset = "0x30B4930", VA = "0x1830B5530", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x30DAFF0", Offset = "0x30DA3F0", VA = "0x1830DAFF0", Slot = "6")]
	protected override Stack<T>.Enumerator AAODCIKMEEL(Stack<T> GEMNKBDIDNJ)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3445DB0", Offset = "0x34451B0", VA = "0x183445DB0", Slot = "9")]
	protected override Stack<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class OHJGJMELKKN<T> : global::JMFHMGPBKCL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x29B4E90", Offset = "0x29B4290", VA = "0x1829B4E90", Slot = "8")]
	protected override void AOHLLDNPMGN(ref HashSet<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override HashSet<T> HPPHODAOIFC(ref HashSet<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override HashSet<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x30DAFF0", Offset = "0x30DA3F0", VA = "0x1830DAFF0", Slot = "6")]
	protected override HashSet<T>.Enumerator AAODCIKMEEL(HashSet<T> GEMNKBDIDNJ)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class IAEKEMBMNAB<T> : global::JDGNDGNOJGO<T, global::LFCMPLINDCF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x27AC700", Offset = "0x27ABB00", VA = "0x1827AC700", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x27AC770", Offset = "0x27ABB70", VA = "0x1827AC770", Slot = "9")]
	protected override ReadOnlyCollection<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x27AC730", Offset = "0x27ABB30", VA = "0x1827AC730", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class DNKBHKCPFGM<T> : global::JDGNDGNOJGO<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x29B4E90", Offset = "0x29B4290", VA = "0x1829B4E90", Slot = "8")]
	protected override void AOHLLDNPMGN(ref List<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override List<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override IList<T> HPPHODAOIFC(ref List<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BECJIJBADOF<T> : global::JDGNDGNOJGO<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x29B4E90", Offset = "0x29B4290", VA = "0x1829B4E90", Slot = "8")]
	protected override void AOHLLDNPMGN(ref List<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override List<T> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override ICollection<T> HPPHODAOIFC(ref List<T> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class PCMMFEDDNFM<T> : global::JDGNDGNOJGO<T, global::LFCMPLINDCF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x27AC700", Offset = "0x27ABB00", VA = "0x1827AC700", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x30B5530", Offset = "0x30B4930", VA = "0x1830B5530", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3385100", Offset = "0x3384500", VA = "0x183385100", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x35588D0", Offset = "0x3557CD0", VA = "0x1835588D0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3558B90", Offset = "0x3557F90", VA = "0x183558B90", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
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
	[Cpp2IlInjected.Address(RVA = "0x5558310", Offset = "0x5557710", VA = "0x185558310", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, IEnumerable JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5558580", Offset = "0x5557980", VA = "0x185558580", Slot = "5")]
	public IEnumerable LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5311EB0", Offset = "0x53112B0", VA = "0x185311EB0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ICollection JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5312170", Offset = "0x5311570", VA = "0x185312170", Slot = "5")]
	public ICollection LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x530BC60", Offset = "0x530B060", VA = "0x18530BC60", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, IList JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x530BF20", Offset = "0x530B320", VA = "0x18530BF20", Slot = "5")]
	public IList LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public HJJMFMBAICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DAJGOGMGLNN<T> : global::JDGNDGNOJGO<T, global::LFCMPLINDCF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x30B5500", Offset = "0x30B4900", VA = "0x1830B5500", Slot = "8")]
	protected override void AOHLLDNPMGN(ref global::LFCMPLINDCF<T> HGLAIHECBOI, int BELCAJFDAHD, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x30B5530", Offset = "0x30B4930", VA = "0x1830B5530", Slot = "7")]
	protected override global::LFCMPLINDCF<T> BFPHDDBHNEE()
	{
		return default(global::LFCMPLINDCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x30B5570", Offset = "0x30B4970", VA = "0x1830B5570", Slot = "9")]
	protected override IReadOnlyList<T> HPPHODAOIFC(ref global::LFCMPLINDCF<T> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x27ADFD0", Offset = "0x27AD3D0", VA = "0x1827ADFD0")]
	public DAJGOGMGLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class EOANOHNJFKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5305CE0", Offset = "0x53050E0", VA = "0x185305CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5306740", Offset = "0x5305B40", VA = "0x185306740", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, DateTime JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5306BA0", Offset = "0x5305FA0", VA = "0x185306BA0", Slot = "5")]
	public DateTime LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x530A140", Offset = "0x5309540", VA = "0x18530A140", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, DateTimeOffset JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x530A520", Offset = "0x5309920", VA = "0x18530A520", Slot = "5")]
	public DateTimeOffset LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5304840", Offset = "0x5303C40", VA = "0x185304840", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, TimeSpan JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5304B10", Offset = "0x5303F10", VA = "0x185304B10", Slot = "5")]
	public TimeSpan LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EJNPBDKFNLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class HCIEGCIOLLJ<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::JJBJICJFEAB<TDictionary>, PKHFALLONLG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4391490", Offset = "0x4390890", VA = "0x184391490", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, TDictionary JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4392610", Offset = "0x4391A10", VA = "0x184392610", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	protected HCIEGCIOLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class PDJIADNPMKO<TKey, TValue, TIntermediate, TDictionary> : global::HCIEGCIOLLJ<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3386170", Offset = "0x3385570", VA = "0x183386170", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> AAODCIKMEEL(TDictionary GEMNKBDIDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class ALJCAHPCHPH<TKey, TValue, TDictionary> : global::PDJIADNPMKO<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override TDictionary HPPHODAOIFC(ref TDictionary CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HKIHDFEHKON<TKey, TValue> : global::HCIEGCIOLLJ<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x31C9990", Offset = "0x31C8D90", VA = "0x1831C9990", Slot = "8")]
	protected override void AOHLLDNPMGN(ref Dictionary<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override Dictionary<TKey, TValue> HPPHODAOIFC(ref Dictionary<TKey, TValue> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override Dictionary<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x31C9940", Offset = "0x31C8D40", VA = "0x1831C9940", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator AAODCIKMEEL(Dictionary<TKey, TValue> GEMNKBDIDNJ)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F140", Offset = "0x1E1E540", VA = "0x181E1F140")]
	public HKIHDFEHKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class CEJJPLOPGEH<TKey, TValue, TDictionary> : global::ALJCAHPCHPH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x336E0D0", Offset = "0x336D4D0", VA = "0x18336E0D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref TDictionary HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x27E6780", Offset = "0x27E5B80", VA = "0x1827E6780", Slot = "7")]
	protected override TDictionary BFPHDDBHNEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class NKPONDLLIPL<TKey, TValue> : global::PDJIADNPMKO<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2FE64D0", Offset = "0x2FE58D0", VA = "0x182FE64D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref Dictionary<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override Dictionary<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override IDictionary<TKey, TValue> HPPHODAOIFC(ref Dictionary<TKey, TValue> CALGKPKIHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class AACLIJIGMAF<TKey, TValue> : global::ALJCAHPCHPH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2FE64D0", Offset = "0x2FE58D0", VA = "0x182FE64D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref SortedList<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override SortedList<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class FFCCPOCJPNK<TKey, TValue> : global::HCIEGCIOLLJ<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2FE64D0", Offset = "0x2FE58D0", VA = "0x182FE64D0", Slot = "8")]
	protected override void AOHLLDNPMGN(ref SortedDictionary<TKey, TValue> HGLAIHECBOI, int BELCAJFDAHD, TKey EBOEHIFNNLM, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x19E0470", Offset = "0x19DF870", VA = "0x1819E0470", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> HPPHODAOIFC(ref SortedDictionary<TKey, TValue> CALGKPKIHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x29B4ED0", Offset = "0x29B42D0", VA = "0x1829B4ED0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> BFPHDDBHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6470", Offset = "0x2FE5870", VA = "0x182FE6470", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator AAODCIKMEEL(SortedDictionary<TKey, TValue> GEMNKBDIDNJ)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class LJGGOOJGDJM<T> : global::JJBJICJFEAB<T>, PKHFALLONLG where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2360", Offset = "0x3BF1760", VA = "0x183BF2360", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2710", Offset = "0x3BF1B10", VA = "0x183BF2710", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
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
	[Cpp2IlInjected.Address(RVA = "0x529C9D0", Offset = "0x529BDD0", VA = "0x18529C9D0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, IDictionary JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x529CD80", Offset = "0x529C180", VA = "0x18529CD80", Slot = "5")]
	public IDictionary LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5299C00", Offset = "0x5299000", VA = "0x185299C00")]
	public MOGJNJLCKNC(params LMDOKLNJEDM[] JFFCCJJMICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5299180", Offset = "0x5298580", VA = "0x185299180", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5299B60", Offset = "0x5298F60", VA = "0x185299B60", Slot = "5")]
	public object LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class KGHEEMNCMFE
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5316800", Offset = "0x5315C00", VA = "0x185316800")]
	public static object DOBINCCPGJK(Type DDJDPMGLPAE, out bool PNMCAHONCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5317120", Offset = "0x5316520", VA = "0x185317120")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public DOILGANOICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EE65A0", Offset = "0x3EE59A0", VA = "0x183EE65A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public FPHKNIIHHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9370", Offset = "0x3CD8770", VA = "0x183CD9370")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public IABHGOHLCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5B6EEC0", Offset = "0x5B6E2C0", VA = "0x185B6EEC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x44CA3F0", Offset = "0x44C97F0", VA = "0x1844CA3F0")]
	static POLOIOBDGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x31EC0B0", Offset = "0x31EB4B0", VA = "0x1831EC0B0")]
	public POLOIOBDGKE(bool EFIBJDBIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x44B7EC0", Offset = "0x44B72C0", VA = "0x1844B7EC0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x44BB590", Offset = "0x44BA990", VA = "0x1844BB590", Slot = "5")]
	public T LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x44B6250", Offset = "0x44B5650", VA = "0x1844B6250", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, T JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x44BE9E0", Offset = "0x44BDDE0", VA = "0x1844BE9E0", Slot = "7")]
	public T OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class NNGKCNHJECN<T> : global::JJBJICJFEAB<T[,]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B393B0", Offset = "0x3B387B0", VA = "0x183B393B0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[,] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B39560", Offset = "0x3B38960", VA = "0x183B39560", Slot = "5")]
	public T[,] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	public NNGKCNHJECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class FOLOHLPEMBA<T> : global::JJBJICJFEAB<T[,,]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6B10", Offset = "0x3CD5F10", VA = "0x183CD6B10", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[,,] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6D20", Offset = "0x3CD6120", VA = "0x183CD6D20", Slot = "5")]
	public T[,,] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	public FOLOHLPEMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class ODACLIFGJBO<T> : global::JJBJICJFEAB<T[,,,]>, PKHFALLONLG
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x415AD90", Offset = "0x415A190", VA = "0x18415AD90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T[,,,] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x415B030", Offset = "0x415A430", VA = "0x18415B030", Slot = "5")]
	public T[,,,] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	public ODACLIFGJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class PBFCEHCAEMD<T> : global::JJBJICJFEAB<T?>, PKHFALLONLG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x335D5A0", Offset = "0x335C9A0", VA = "0x18335D5A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x335D9B0", Offset = "0x335CDB0", VA = "0x18335D9B0", Slot = "5")]
	public T? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E850", VA = "0x182B7F450")]
	public PNBFANOOKGP(global::JJBJICJFEAB<T> CGFFLAMBJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C550C0", Offset = "0x4C544C0", VA = "0x184C550C0")]
	public PNBFANOOKGP(Type DDIMAINKNPP, object[] OGKJLCLAGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C53ED0", Offset = "0x4C532D0", VA = "0x184C53ED0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, T? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C54400", Offset = "0x4C53800", VA = "0x184C54400", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5310550", Offset = "0x530F950", VA = "0x185310550", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, sbyte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5310570", Offset = "0x530F970", VA = "0x185310570", Slot = "5")]
	public sbyte LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5310510", Offset = "0x530F910", VA = "0x185310510", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, sbyte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x53105C0", Offset = "0x530F9C0", VA = "0x1853105C0", Slot = "7")]
	public sbyte OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5316080", Offset = "0x5315480", VA = "0x185316080", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, sbyte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5316100", Offset = "0x5315500", VA = "0x185316100", Slot = "5")]
	public sbyte? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5316000", Offset = "0x5315400", VA = "0x185316000", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, sbyte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x53161B0", Offset = "0x53155B0", VA = "0x1853161B0", Slot = "7")]
	public sbyte? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x529A0A0", Offset = "0x52994A0", VA = "0x18529A0A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, sbyte[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x529A160", Offset = "0x5299560", VA = "0x18529A160", Slot = "5")]
	public sbyte[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x530C250", Offset = "0x530B650", VA = "0x18530C250", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, short JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x530C270", Offset = "0x530B670", VA = "0x18530C270", Slot = "5")]
	public short LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x530C210", Offset = "0x530B610", VA = "0x18530C210", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, short JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x530C2D0", Offset = "0x530B6D0", VA = "0x18530C2D0", Slot = "7")]
	public short OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5317AC0", Offset = "0x5316EC0", VA = "0x185317AC0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, short? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5317B40", Offset = "0x5316F40", VA = "0x185317B40", Slot = "5")]
	public short? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5317A40", Offset = "0x5316E40", VA = "0x185317A40", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, short? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5317BF0", Offset = "0x5316FF0", VA = "0x185317BF0", Slot = "7")]
	public short? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x529F080", Offset = "0x529E480", VA = "0x18529F080", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, short[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x529F140", Offset = "0x529E540", VA = "0x18529F140", Slot = "5")]
	public short[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5318890", Offset = "0x5317C90", VA = "0x185318890", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, int JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x53188A0", Offset = "0x5317CA0", VA = "0x1853188A0", Slot = "5")]
	public int LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5318850", Offset = "0x5317C50", VA = "0x185318850", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, int JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5318900", Offset = "0x5317D00", VA = "0x185318900", Slot = "7")]
	public int OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53093E0", Offset = "0x53087E0", VA = "0x1853093E0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, int? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5309450", Offset = "0x5308850", VA = "0x185309450", Slot = "5")]
	public int? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5309360", Offset = "0x5308760", VA = "0x185309360", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, int? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5309500", Offset = "0x5308900", VA = "0x185309500", Slot = "7")]
	public int? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5299D00", Offset = "0x5299100", VA = "0x185299D00", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, int[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5299DC0", Offset = "0x52991C0", VA = "0x185299DC0", Slot = "5")]
	public int[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5317D50", Offset = "0x5317150", VA = "0x185317D50", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, long JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5317D70", Offset = "0x5317170", VA = "0x185317D70", Slot = "5")]
	public long LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5317D10", Offset = "0x5317110", VA = "0x185317D10", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, long JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5317D80", Offset = "0x5317180", VA = "0x185317D80", Slot = "7")]
	public long OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5558EF0", Offset = "0x55582F0", VA = "0x185558EF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, long? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5558F80", Offset = "0x5558380", VA = "0x185558F80", Slot = "5")]
	public long? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5558DE0", Offset = "0x55581E0", VA = "0x185558DE0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, long? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5559010", Offset = "0x5558410", VA = "0x185559010", Slot = "7")]
	public long? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53125C0", Offset = "0x53119C0", VA = "0x1853125C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, long[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5312680", Offset = "0x5311A80", VA = "0x185312680", Slot = "5")]
	public long[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x55450C0", Offset = "0x55444C0", VA = "0x1855450C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, byte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5545100", Offset = "0x5544500", VA = "0x185545100", Slot = "5")]
	public byte LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5545000", Offset = "0x5544400", VA = "0x185545000", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, byte JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5545110", Offset = "0x5544510", VA = "0x185545110", Slot = "7")]
	public byte OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x531A970", Offset = "0x5319D70", VA = "0x18531A970", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, byte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x531A9F0", Offset = "0x5319DF0", VA = "0x18531A9F0", Slot = "5")]
	public byte? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x531A8F0", Offset = "0x5319CF0", VA = "0x18531A8F0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, byte? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x531AAA0", Offset = "0x5319EA0", VA = "0x18531AAA0", Slot = "7")]
	public byte? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x554F0D0", Offset = "0x554E4D0", VA = "0x18554F0D0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ushort JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x554F110", Offset = "0x554E510", VA = "0x18554F110", Slot = "5")]
	public ushort LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x554F010", Offset = "0x554E410", VA = "0x18554F010", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ushort JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x554F120", Offset = "0x554E520", VA = "0x18554F120", Slot = "7")]
	public ushort OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5309810", Offset = "0x5308C10", VA = "0x185309810", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ushort? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5309890", Offset = "0x5308C90", VA = "0x185309890", Slot = "5")]
	public ushort? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5309790", Offset = "0x5308B90", VA = "0x185309790", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ushort? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5309940", Offset = "0x5308D40", VA = "0x185309940", Slot = "7")]
	public ushort? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5304420", Offset = "0x5303820", VA = "0x185304420", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ushort[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x53044E0", Offset = "0x53038E0", VA = "0x1853044E0", Slot = "5")]
	public ushort[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5308310", Offset = "0x5307710", VA = "0x185308310", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, uint JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5308320", Offset = "0x5307720", VA = "0x185308320", Slot = "5")]
	public uint LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x53082D0", Offset = "0x53076D0", VA = "0x1853082D0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, uint JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5308380", Offset = "0x5307780", VA = "0x185308380", Slot = "7")]
	public uint OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5307DD0", Offset = "0x53071D0", VA = "0x185307DD0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, uint? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5307E40", Offset = "0x5307240", VA = "0x185307E40", Slot = "5")]
	public uint? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5307D50", Offset = "0x5307150", VA = "0x185307D50", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, uint? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5307EF0", Offset = "0x53072F0", VA = "0x185307EF0", Slot = "7")]
	public uint? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x530CB00", Offset = "0x530BF00", VA = "0x18530CB00", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, uint[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x530CBC0", Offset = "0x530BFC0", VA = "0x18530CBC0", Slot = "5")]
	public uint[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x530B8E0", Offset = "0x530ACE0", VA = "0x18530B8E0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ulong JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x530B900", Offset = "0x530AD00", VA = "0x18530B900", Slot = "5")]
	public ulong LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x530B8A0", Offset = "0x530ACA0", VA = "0x18530B8A0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ulong JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x530B910", Offset = "0x530AD10", VA = "0x18530B910", Slot = "7")]
	public ulong OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5317EF0", Offset = "0x53172F0", VA = "0x185317EF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ulong? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5317F70", Offset = "0x5317370", VA = "0x185317F70", Slot = "5")]
	public ulong? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5317E60", Offset = "0x5317260", VA = "0x185317E60", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, ulong? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5318000", Offset = "0x5317400", VA = "0x185318000", Slot = "7")]
	public ulong? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x531A100", Offset = "0x5319500", VA = "0x18531A100", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ulong[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x531A1C0", Offset = "0x53195C0", VA = "0x18531A1C0", Slot = "5")]
	public ulong[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5547F90", Offset = "0x5547390", VA = "0x185547F90", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, float JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5547FA0", Offset = "0x55473A0", VA = "0x185547FA0", Slot = "5")]
	public float LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5547EE0", Offset = "0x55472E0", VA = "0x185547EE0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, float JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5547FB0", Offset = "0x55473B0", VA = "0x185547FB0", Slot = "7")]
	public float OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53041A0", Offset = "0x53035A0", VA = "0x1853041A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, float? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5304220", Offset = "0x5303620", VA = "0x185304220", Slot = "5")]
	public float? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5304120", Offset = "0x5303520", VA = "0x185304120", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, float? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5304290", Offset = "0x5303690", VA = "0x185304290", Slot = "7")]
	public float? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x529B230", Offset = "0x529A630", VA = "0x18529B230", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, float[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x529B2F0", Offset = "0x529A6F0", VA = "0x18529B2F0", Slot = "5")]
	public float[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5299FA0", Offset = "0x52993A0", VA = "0x185299FA0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, double JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5299FB0", Offset = "0x52993B0", VA = "0x185299FB0", Slot = "5")]
	public double LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5299F60", Offset = "0x5299360", VA = "0x185299F60", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, double JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5299FC0", Offset = "0x52993C0", VA = "0x185299FC0", Slot = "7")]
	public double OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5547900", Offset = "0x5546D00", VA = "0x185547900", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, double? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5547980", Offset = "0x5546D80", VA = "0x185547980", Slot = "5")]
	public double? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x55477F0", Offset = "0x5546BF0", VA = "0x1855477F0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, double? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5547A10", Offset = "0x5546E10", VA = "0x185547A10", Slot = "7")]
	public double? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53106A0", Offset = "0x530FAA0", VA = "0x1853106A0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, double[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5310760", Offset = "0x530FB60", VA = "0x185310760", Slot = "5")]
	public double[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5315EF0", Offset = "0x53152F0", VA = "0x185315EF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, bool JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5315F10", Offset = "0x5315310", VA = "0x185315F10", Slot = "5")]
	public bool LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5315EB0", Offset = "0x53152B0", VA = "0x185315EB0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, bool JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5315F20", Offset = "0x5315320", VA = "0x185315F20", Slot = "7")]
	public bool OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5559420", Offset = "0x5558820", VA = "0x185559420", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, bool? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x55594A0", Offset = "0x55588A0", VA = "0x1855594A0", Slot = "5")]
	public bool? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5559320", Offset = "0x5558720", VA = "0x185559320", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, bool? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5559510", Offset = "0x5558910", VA = "0x185559510", Slot = "7")]
	public bool? OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53039B0", Offset = "0x5302DB0", VA = "0x1853039B0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, bool[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5303A80", Offset = "0x5302E80", VA = "0x185303A80", Slot = "5")]
	public bool[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x531ABC0", Offset = "0x5319FC0", VA = "0x18531ABC0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, object JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x531B640", Offset = "0x531AA40", VA = "0x18531B640", Slot = "5")]
	public object LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5309620", Offset = "0x5308A20", VA = "0x185309620", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, byte[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x53096B0", Offset = "0x5308AB0", VA = "0x1853096B0", Slot = "5")]
	public byte[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5547CE0", Offset = "0x55470E0", VA = "0x185547CE0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, ArraySegment<byte> JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5547DA0", Offset = "0x55471A0", VA = "0x185547DA0", Slot = "5")]
	public ArraySegment<byte> LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53090B0", Offset = "0x53084B0", VA = "0x1853090B0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, string JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x53090D0", Offset = "0x53084D0", VA = "0x1853090D0", Slot = "5")]
	public string LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x53090B0", Offset = "0x53084B0", VA = "0x1853090B0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, string JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x53090D0", Offset = "0x53084D0", VA = "0x1853090D0", Slot = "7")]
	public string OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5311B30", Offset = "0x5310F30", VA = "0x185311B30", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, string[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5311BF0", Offset = "0x5310FF0", VA = "0x185311BF0", Slot = "5")]
	public string[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5319FF0", Offset = "0x53193F0", VA = "0x185319FF0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, char JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x531A070", Offset = "0x5319470", VA = "0x18531A070", Slot = "5")]
	public char LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5309140", Offset = "0x5308540", VA = "0x185309140", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, char? JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5309230", Offset = "0x5308630", VA = "0x185309230", Slot = "5")]
	public char? LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5558790", Offset = "0x5557B90", VA = "0x185558790", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, char[] JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x55589D0", Offset = "0x5557DD0", VA = "0x1855589D0", Slot = "5")]
	public char[] LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53056F0", Offset = "0x5304AF0", VA = "0x1853056F0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Guid JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5305790", Offset = "0x5304B90", VA = "0x185305790", Slot = "5")]
	public Guid LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x53056F0", Offset = "0x5304AF0", VA = "0x1853056F0", Slot = "6")]
	public void AAFMNJLGOHF(ref AOONEBAFBIP ABIHDCBCABG, Guid JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x53057E0", Offset = "0x5304BE0", VA = "0x1853057E0", Slot = "7")]
	public Guid OJAGIIHKONG(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC398E0", Offset = "0xC38CE0", VA = "0x180C398E0")]
	public HAOPGAIPDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x9AA560", Offset = "0x9A9960", VA = "0x1809AA560")]
	public HAOPGAIPDFE(bool IMCKBDAONCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x530B4C0", Offset = "0x530A8C0", VA = "0x18530B4C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, decimal JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x530B610", Offset = "0x530AA10", VA = "0x18530B610", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5544D40", Offset = "0x5544140", VA = "0x185544D40", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Uri JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5544DF0", Offset = "0x55441F0", VA = "0x185544DF0", Slot = "5")]
	public Uri LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x530BAD0", Offset = "0x530AED0", VA = "0x18530BAD0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Version JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x530BB80", Offset = "0x530AF80", VA = "0x18530BB80", Slot = "5")]
	public Version LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5312910", Offset = "0x5311D10", VA = "0x185312910", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, StringBuilder JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5312960", Offset = "0x5311D60", VA = "0x185312960", Slot = "5")]
	public StringBuilder LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x554F2C0", Offset = "0x554E6C0", VA = "0x18554F2C0", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, BitArray JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x554F3C0", Offset = "0x554E7C0", VA = "0x18554F3C0", Slot = "5")]
	public BitArray LPJEJNEGJFP(ref IIHLGBHCEFK OJMODHIKFDB, LMDOKLNJEDM JOEHDDNFHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x529AE00", Offset = "0x529A200", VA = "0x18529AE00")]
	public NHODOGAGCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x529AE20", Offset = "0x529A220", VA = "0x18529AE20")]
	public NHODOGAGCPO(bool LJFBCLJPCFB, bool DCMPLDLODFD, bool KDHIBIPHALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x529AB20", Offset = "0x5299F20", VA = "0x18529AB20", Slot = "4")]
	public void LMGAKHPBOLH(ref AOONEBAFBIP ABIHDCBCABG, Type JFBPNBNBHOE, LMDOKLNJEDM JOEHDDNFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x529AC10", Offset = "0x529A010", VA = "0x18529AC10", Slot = "5")]
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
