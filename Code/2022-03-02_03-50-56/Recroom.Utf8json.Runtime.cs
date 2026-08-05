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
public class KELCJODKNHI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x510C00", Offset = "0x50FC00", VA = "0x180510C00")]
	public KELCJODKNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class IKDCIGJEPLN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x510C00", Offset = "0x50FC00", VA = "0x180510C00")]
	public IKDCIGJEPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FKNJOBHHGAI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x510C00", Offset = "0x50FC00", VA = "0x180510C00")]
	public FKNJOBHHGAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class GCAIMGBPJEC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x510C00", Offset = "0x50FC00", VA = "0x180510C00")]
	public GCAIMGBPJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NGNFBCEIJPM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x48E4580", Offset = "0x48E3580", VA = "0x1848E4580")]
	public static bool MMKKNKBGBFD(this TypeInfo CIMKNKPILIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class PODCFNMFBKD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type BHFNMJCBGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] KIBFCOEJNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x759230", Offset = "0x758230", VA = "0x180759230")]
	public PODCFNMFBKD(Type PLNIABJBIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class JGCDKMMIFFK : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ILIIDJGDKHO<T>(ref PJHNLAIFAEP DJLDOCIGJKE, T DDDOLDGEMNC, ENKIFIDJGCB IMFLLANEHFA);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T PLJCPGEJMGC<T>(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB IMFLLANEHFA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EMHLBACENGL
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EMIGBNLKFFH<T> : EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, T DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CGIHMAABHKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, T DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FPIANENKGOK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EMIGBNLKFFH<T> AAADLODDLOB<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MMBIBEFKDBB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29B5340", Offset = "0x29B4340", VA = "0x1829B5340")]
	public static global::EMIGBNLKFFH<T> JGIAJBPEOJJ<T>(this ENKIFIDJGCB IMFLLANEHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3204010", Offset = "0x3203010", VA = "0x183204010")]
	public static object CKMJAOOCIDD(this ENKIFIDJGCB IMFLLANEHFA, Type CIMKNKPILIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NMBJKNLNPCC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x48E4740", Offset = "0x48E3740", VA = "0x1848E4740")]
	public NMBJKNLNPCC(string HBPJACFNCPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PGEJMHBNANP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class DLKKAMLNGDB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] CGBPEHFCGMK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] OGHPOAHIGOB;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x48E4500", Offset = "0x48E3500", VA = "0x1848E4500")]
		public static byte[] OKIEKLHFIAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x48E4470", Offset = "0x48E3470", VA = "0x1848E4470")]
		public static char[] LNFGHDLPDEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GHNPDGMLFJE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] AICOPMKKLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] CPFFKFOFBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int GDBLDPHBNNG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ICACIPJLKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48EB9E0", Offset = "0x48EA9E0", VA = "0x1848EB9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x48EE2E0", Offset = "0x48ED2E0", VA = "0x1848EE2E0")]
	public PGEJMHBNANP(byte[] CPFFKFOFBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48EE100", Offset = "0x48ED100", VA = "0x1848EE100")]
	public PGEJMHBNANP(byte[] CPFFKFOFBAE, int GDBLDPHBNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x48ED2A0", Offset = "0x48EC2A0", VA = "0x1848ED2A0")]
	private CBAIMJLJGFH KPKKMCFHFLL(string NMFBMOJEGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48EC440", Offset = "0x48EB440", VA = "0x1848EC440")]
	private CBAIMJLJGFH GGCHOFEAEMM(string HBPJACFNCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x48EDCB0", Offset = "0x48ECCB0", VA = "0x1848EDCB0")]
	public void OIDAHMEPBHA(int GDBLDPHBNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C1B60", Offset = "0x5C0B60", VA = "0x1805C1B60")]
	public byte[] OIAFGBEFKOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x712910", Offset = "0x711910", VA = "0x180712910")]
	public int DMJKIBEEMHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x48ECDF0", Offset = "0x48EBDF0", VA = "0x1848ECDF0")]
	public BJHIFCOPBHH JGAHFPLAIAC()
	{
		return default(BJHIFCOPBHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x48EDB70", Offset = "0x48ECB70", VA = "0x1848EDB70")]
	public void OCIIFMOMJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x48EC830", Offset = "0x48EB830", VA = "0x1848EC830")]
	public bool IJKJMAECCFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48ECF80", Offset = "0x48EBF80", VA = "0x1848ECF80")]
	public bool JPKPKINICDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x48EBA00", Offset = "0x48EAA00", VA = "0x1848EBA00")]
	public void EEHKOJDKKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48EDAE0", Offset = "0x48ECAE0", VA = "0x1848EDAE0")]
	public bool OBGJNDHDFCE(ref int MODLAKNNNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48EC2D0", Offset = "0x48EB2D0", VA = "0x1848EC2D0")]
	public bool FAJNGDLINEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x48EC790", Offset = "0x48EB790", VA = "0x1848EC790")]
	public void IIPFNGAFDOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48EC340", Offset = "0x48EB340", VA = "0x1848EC340")]
	public bool FMHCGPJJFKA(ref int MODLAKNNNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48EC3D0", Offset = "0x48EB3D0", VA = "0x1848EC3D0")]
	public bool GEOFMAMOMJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x48ECAB0", Offset = "0x48EBAB0", VA = "0x1848ECAB0")]
	public void JCDBNOGNHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x48ED740", Offset = "0x48EC740", VA = "0x1848ED740")]
	public bool LBJOHJAFGLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x48EDCC0", Offset = "0x48ECCC0", VA = "0x1848EDCC0")]
	public void OJGEINNAKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48EBB40", Offset = "0x48EAB40", VA = "0x1848EBB40")]
	private void FAGDCODAENC(out byte[] PIFMPFENEOM, out int MIKJOHFBHNE, out int JLKPJABACKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x48ED040", Offset = "0x48EC040", VA = "0x1848ED040")]
	private static int KNCIFMNKEKH(char MGMKOCNNKKD, char FFKAJGPOGIJ, char LEBLBLLCPPD, char LODPNNEBBBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48ECB50", Offset = "0x48EBB50", VA = "0x1848ECB50")]
	private static int JCJLFAGHHMI(char LLFMGCPPNJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48EC520", Offset = "0x48EB520", VA = "0x1848EC520")]
	public ArraySegment<byte> ICCEADBKMIM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48EB880", Offset = "0x48EA880", VA = "0x1848EB880")]
	public string CKFPPKNAANG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x48ECA80", Offset = "0x48EBA80", VA = "0x1848ECA80")]
	public string IPEPJOCCMAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48ED0F0", Offset = "0x48EC0F0", VA = "0x1848ED0F0")]
	public ArraySegment<byte> KNHDPCLPPBG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x48EBAA0", Offset = "0x48EAAA0", VA = "0x1848EBAA0")]
	public ArraySegment<byte> EJBDKPPCMBG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48EDDC0", Offset = "0x48ECDC0", VA = "0x1848EDDC0")]
	public bool PGKACOMPOMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48EB920", Offset = "0x48EA920", VA = "0x1848EB920")]
	private static bool DHGOMAOFIKJ(byte LEBLBLLCPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48ECC20", Offset = "0x48EBC20", VA = "0x1848ECC20")]
	private void JDNMMOKEMEG(BJHIFCOPBHH NCEHCDHJMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48EB680", Offset = "0x48EA680", VA = "0x1848EB680")]
	public void BFANOLKAJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48EDA10", Offset = "0x48ECA10", VA = "0x1848EDA10")]
	private void NDLLMPHJFFO(int CJLGKKFHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x48ECFF0", Offset = "0x48EBFF0", VA = "0x1848ECFF0")]
	public sbyte KGACMCOIADF()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x48EB690", Offset = "0x48EA690", VA = "0x1848EB690")]
	public short BHCECPMKIMC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x48EB5C0", Offset = "0x48EA5C0", VA = "0x1848EB5C0")]
	public int ACFOCLEIDHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x48EB770", Offset = "0x48EA770", VA = "0x1848EB770")]
	public long CKCEDOIKLFO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x48EDD60", Offset = "0x48ECD60", VA = "0x1848EDD60")]
	public byte PGIGDODNLID()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x48EBAE0", Offset = "0x48EAAE0", VA = "0x1848EBAE0")]
	public ushort EPIEEBJFPCP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x48EB620", Offset = "0x48EA620", VA = "0x1848EB620")]
	public uint BDCLAMJLNEL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x48EB6F0", Offset = "0x48EA6F0", VA = "0x1848EB6F0")]
	public ulong BJJCMCBJIOB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x48ED8D0", Offset = "0x48EC8D0", VA = "0x1848ED8D0")]
	public float LNJPLFBBMJC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x48EC950", Offset = "0x48EB950", VA = "0x1848EC950")]
	public double IKIJLHFLNLH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x48ED7B0", Offset = "0x48EC7B0", VA = "0x1848ED7B0")]
	public ArraySegment<byte> LEFOBEAGDIG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x48EC610", Offset = "0x48EB610", VA = "0x1848EC610")]
	private static int IGCFDODFDGG(byte[] CPFFKFOFBAE, int GDBLDPHBNNG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CBAIMJLJGFH : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference MGHHCMEFCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int AHLIBDBKIIC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DLMDFHKGNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xC1AF60", Offset = "0xC19F60", VA = "0x180C1AF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string FPBFBEBIBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63C5E0", Offset = "0x63B5E0", VA = "0x18063C5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x30FCD30", Offset = "0x30FBD30", VA = "0x1830FCD30")]
	public CBAIMJLJGFH(string HBPJACFNCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x30FCDA0", Offset = "0x30FBDA0", VA = "0x1830FCDA0")]
	public CBAIMJLJGFH(string HBPJACFNCPP, byte[] BDGNJMLKNCC, int GDBLDPHBNNG, int AHLIBDBKIIC, string NLDJHEBPFIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IPBMCNDGGIL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MALLHCKENEH
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void FFEKPOLFKPL(ref PJHNLAIFAEP DJLDOCIGJKE, object DDDOLDGEMNC, ENKIFIDJGCB IMFLLANEHFA);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object PJJOEBMGDKC(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB IMFLLANEHFA);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KHNFPHMDGAM
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class PMEIJOPGJLE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
				public PMEIJOPGJLE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x1218C90", Offset = "0x1217C90", VA = "0x181218C90")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x32070F0", Offset = "0x32060F0", VA = "0x1832070F0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, ENKIFIDJGCB, byte[]> LICBJMJHAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, ENKIFIDJGCB> JEIMFBPCLGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly FFEKPOLFKPL NFPNDALNFFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, ENKIFIDJGCB, ArraySegment<byte>> HCJAAJAGHLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, ENKIFIDJGCB, string> AMHDCNIPABE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, ENKIFIDJGCB, object> GIIDGAHDEOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, ENKIFIDJGCB, object> HOHNMFCKNFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, ENKIFIDJGCB, object> OBBDMINFBPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly PJJOEBMGDKC ALDABEMIIBG;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x31FAC70", Offset = "0x31F9C70", VA = "0x1831FAC70")]
			public KHNFPHMDGAM(Type CIMKNKPILIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x263CAF0", Offset = "0x263BAF0", VA = "0x18263CAF0")]
			private static T LILJMOFFHGG<T>(DynamicMethod PKIKDBDBCNN)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x31FAA80", Offset = "0x31F9A80", VA = "0x1831FAA80")]
			private static MethodInfo FNFJKNJBKHH(Type CIMKNKPILIM, string GDCCAEJAPNJ, Type[] EDICCHOGPIC)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KHNFPHMDGAM> KPBMOAHLGPD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::KKKLMDJJKMB<KHNFPHMDGAM> LOMLOKCCLPN;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3203040", Offset = "0x3202040", VA = "0x183203040")]
		static MALLHCKENEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3202D40", Offset = "0x3201D40", VA = "0x183202D40")]
		private static KHNFPHMDGAM JJFCIDPKKBG(Type CIMKNKPILIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3202DC0", Offset = "0x3201DC0", VA = "0x183202DC0")]
		public static void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, object DDDOLDGEMNC, ENKIFIDJGCB IMFLLANEHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3202F30", Offset = "0x3201F30", VA = "0x183202F30")]
		public static void PKICNBNNKCI(Type CIMKNKPILIM, ref PJHNLAIFAEP DJLDOCIGJKE, object DDDOLDGEMNC, ENKIFIDJGCB IMFLLANEHFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class FDFEOPOKFKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] CGBPEHFCGMK;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x31F08D0", Offset = "0x31EF8D0", VA = "0x1831F08D0")]
		public static byte[] OKIEKLHFIAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ENKIFIDJGCB PBFFPGPOOAE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] CKLGNJLEDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] ALEFGOKOBML;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static ENKIFIDJGCB EFAGAINLLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x31F5BB0", Offset = "0x31F4BB0", VA = "0x1831F5BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28C1700", Offset = "0x28C0700", VA = "0x1828C1700")]
	public static string MMHAPDAAPED<T>(T DDDOLDGEMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28C15A0", Offset = "0x28C05A0", VA = "0x1828C15A0")]
	public static string MMHAPDAAPED<T>(T DDDOLDGEMNC, ENKIFIDJGCB IMFLLANEHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x263A470", Offset = "0x2639470", VA = "0x18263A470")]
	public static T GJAEFJLDMHL<T>(string PBGCFKCBIFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x263A640", Offset = "0x2639640", VA = "0x18263A640")]
	public static T GJAEFJLDMHL<T>(string PBGCFKCBIFH, ENKIFIDJGCB IMFLLANEHFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x263A3F0", Offset = "0x26393F0", VA = "0x18263A3F0")]
	public static T GJAEFJLDMHL<T>(byte[] CPFFKFOFBAE, ENKIFIDJGCB IMFLLANEHFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x263A4F0", Offset = "0x26394F0", VA = "0x18263A4F0")]
	public static T GJAEFJLDMHL<T>(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, ENKIFIDJGCB IMFLLANEHFA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BJHIFCOPBHH : byte
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
public struct PJHNLAIFAEP
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] PJEGCNJNNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] CGBPEHFCGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int GDBLDPHBNNG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MPKOICNIGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x712910", Offset = "0x711910", VA = "0x180712910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x48EDCB0", Offset = "0x48ECCB0", VA = "0x1848EDCB0")]
	public void OIDAHMEPBHA(int GDBLDPHBNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x48EFFF0", Offset = "0x48EEFF0", VA = "0x1848EFFF0")]
	public static byte[] KJMMIGLHPEE(string OMJLHJCLCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x48EF450", Offset = "0x48EE450", VA = "0x1848EF450")]
	public static byte[] ADHHJEMGANL(string OMJLHJCLCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x48EF5F0", Offset = "0x48EE5F0", VA = "0x1848EF5F0")]
	public static byte[] BBCICGHPOKA(string OMJLHJCLCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x48F00D0", Offset = "0x48EF0D0", VA = "0x1848F00D0")]
	public static byte[] LLNNIABHFIF(string OMJLHJCLCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x12A4150", Offset = "0x12A3150", VA = "0x1812A4150")]
	public PJHNLAIFAEP(byte[] OMKHPFLNFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x48F04C0", Offset = "0x48EF4C0", VA = "0x1848F04C0")]
	public ArraySegment<byte> OKIEKLHFIAN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x48F0440", Offset = "0x48EF440", VA = "0x1848F0440")]
	public byte[] OFFGCBFPNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x48F0620", Offset = "0x48EF620", VA = "0x1848F0620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x48EF580", Offset = "0x48EE580", VA = "0x1848EF580")]
	public void AECNNDDCJKK(int GCCELFOCHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x48EFD50", Offset = "0x48EED50", VA = "0x1848EFD50")]
	public void JIMCGDCKCLI(byte[] BOOHDOCLJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x48F0280", Offset = "0x48EF280", VA = "0x1848F0280")]
	public void NDEEJDKLHOA(byte BOOHDOCLJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x48EFDB0", Offset = "0x48EEDB0", VA = "0x1848EFDB0")]
	public void JMIIIIFAOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x48EFB20", Offset = "0x48EEB20", VA = "0x1848EFB20")]
	public void EBLLBHALMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x48EFC20", Offset = "0x48EEC20", VA = "0x1848EFC20")]
	public void GCEIBKOGBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x48EF400", Offset = "0x48EE400", VA = "0x1848EF400")]
	public void ACKJEOKMKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x48F0230", Offset = "0x48EF230", VA = "0x1848F0230")]
	public void MPIICNMNPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x48F0390", Offset = "0x48EF390", VA = "0x1848F0390")]
	public void NOLGKCPANCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x48EFCF0", Offset = "0x48EECF0", VA = "0x1848EFCF0")]
	public void HEEALJPGDFI(string OMJLHJCLCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x48EFC70", Offset = "0x48EEC70", VA = "0x1848EFC70")]
	public void GDBPOMDHADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x48F02C0", Offset = "0x48EF2C0", VA = "0x1848F02C0")]
	public void NFLPAKDEMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x48EFE00", Offset = "0x48EEE00", VA = "0x1848EFE00")]
	public void JNKFPKLELIH(bool DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48F0570", Offset = "0x48EF570", VA = "0x1848F0570")]
	public void PBEAENEBLNC(float DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x48EFB70", Offset = "0x48EEB70", VA = "0x1848EFB70")]
	public void EJBJCABMGEN(double DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x48EFBF0", Offset = "0x48EEBF0", VA = "0x1848EFBF0")]
	public void FBEAFLJIBJK(byte DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48F03E0", Offset = "0x48EF3E0", VA = "0x1848F03E0")]
	public void NPMEKHPGGOF(ushort DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48EFCC0", Offset = "0x48EECC0", VA = "0x1848EFCC0")]
	public void GFINOBFDJGC(uint DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x48EF5C0", Offset = "0x48EE5C0", VA = "0x1848EF5C0")]
	public void AGHNELAGMPM(ulong DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x48F05F0", Offset = "0x48EF5F0", VA = "0x1848F05F0")]
	public void PDDLMBMHPAN(sbyte DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48EF590", Offset = "0x48EE590", VA = "0x1848EF590")]
	public void AFDMBHOHDLI(short DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x48F0410", Offset = "0x48EF410", VA = "0x1848F0410")]
	public void OBJOMCFLNCB(int DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x48EFAF0", Offset = "0x48EEAF0", VA = "0x1848EFAF0")]
	public void DDNLIBLEAOE(long DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x48EF720", Offset = "0x48EE720", VA = "0x1848EF720")]
	public void BFGJNKLCJFB(string DDDOLDGEMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ENJBPAJFNBH : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class ABIHCNNIABB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x25A04F0", Offset = "0x259F4F0", VA = "0x1825A04F0")]
		static ABIHCNNIABB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private ENJBPAJFNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class NDJDIDDCHIF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> ABJONNDNOOL;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3204EB0", Offset = "0x3203EB0", VA = "0x183204EB0")]
	static NDJDIDDCHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3204950", Offset = "0x3203950", VA = "0x183204950")]
	internal static object AAADLODDLOB(Type ALPPOEENOGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JJMGDBLAJIH : global::EMIGBNLKFFH<Vector2>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31F8360", Offset = "0x31F7360", VA = "0x1831F8360")]
	public JJMGDBLAJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31F82B0", Offset = "0x31F72B0", VA = "0x1831F82B0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Vector2 DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x31F8130", Offset = "0x31F7130", VA = "0x1831F8130", Slot = "5")]
	public Vector2 GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PBPDDFHLGKB : global::EMIGBNLKFFH<Vector3>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x48EA8C0", Offset = "0x48E98C0", VA = "0x1848EA8C0")]
	public PBPDDFHLGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x48EA6B0", Offset = "0x48E96B0", VA = "0x1848EA6B0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Vector3 DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x48EA3B0", Offset = "0x48E93B0", VA = "0x1848EA3B0", Slot = "5")]
	public Vector3 GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EAFPLOLMAMG : global::EMIGBNLKFFH<Vector4>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x31075C0", Offset = "0x31065C0", VA = "0x1831075C0")]
	public EAFPLOLMAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3107470", Offset = "0x3106470", VA = "0x183107470", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Vector4 DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x31071E0", Offset = "0x31061E0", VA = "0x1831071E0", Slot = "5")]
	public Vector4 GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class LNPABJKAONC : global::EMIGBNLKFFH<Quaternion>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3202A50", Offset = "0x3201A50", VA = "0x183202A50")]
	public LNPABJKAONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3107470", Offset = "0x3106470", VA = "0x183107470", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Quaternion DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3202820", Offset = "0x3201820", VA = "0x183202820", Slot = "5")]
	public Quaternion GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class INGFAIIIMPD : global::EMIGBNLKFFH<Color>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x31F58C0", Offset = "0x31F48C0", VA = "0x1831F58C0")]
	public INGFAIIIMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3107470", Offset = "0x3106470", VA = "0x183107470", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Color DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x31F5690", Offset = "0x31F4690", VA = "0x1831F5690", Slot = "5")]
	public Color GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EDHPEGAENKC : global::EMIGBNLKFFH<Bounds>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3107F90", Offset = "0x3106F90", VA = "0x183107F90")]
	public EDHPEGAENKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3107D20", Offset = "0x3106D20", VA = "0x183107D20", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Bounds DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3107A20", Offset = "0x3106A20", VA = "0x183107A20", Slot = "5")]
	public Bounds GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class MOOAEHBOLDB : global::EMIGBNLKFFH<Rect>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FNEGPNFNIEC EIDNPLCBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] PAJBNOMBAEM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3204660", Offset = "0x3203660", VA = "0x183204660")]
	public MOOAEHBOLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x32044F0", Offset = "0x32034F0", VA = "0x1832044F0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Rect DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3204290", Offset = "0x3203290", VA = "0x183204290", Slot = "5")]
	public Rect GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class NLKDEIMEBDG : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class NHOIMJFPKMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E2C0", Offset = "0x3F6D2C0", VA = "0x183F6E2C0")]
		static NHOIMJFPKMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private NLKDEIMEBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JNNKPBHKMMK : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class CKEOIJLGCGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x24F5610", Offset = "0x24F4610", VA = "0x1824F5610")]
		static CKEOIJLGCGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class LDAMNJHIMAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> CANGABJGMCB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x31FE630", Offset = "0x31FD630", VA = "0x1831FE630")]
		internal static object AAADLODDLOB(Type ALPPOEENOGM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private JNNKPBHKMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ADMDGECBMGD : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class AEOIJLJJMDD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E3FD30", Offset = "0x2E3ED30", VA = "0x182E3FD30")]
		static AEOIJLJJMDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private ADMDGECBMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DKMMJMNNCPA
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly ENKIFIDJGCB CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly ENKIFIDJGCB FFHIOAKMFPF;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly ENKIFIDJGCB NMGGKKLELPB;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly ENKIFIDJGCB NPCKDACJBHF;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly ENKIFIDJGCB GJMIIDJLMDE;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly ENKIFIDJGCB LKOPANAHCFE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly ENKIFIDJGCB NCMDCDJMJLA;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly ENKIFIDJGCB MDMDODFJNAN;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly ENKIFIDJGCB GOJBKMNEIFA;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly ENKIFIDJGCB ODGDFJIHGMF;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly ENKIFIDJGCB GOAAGMKFLLI;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly ENKIFIDJGCB CBADMLNMNEP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GJNDJANNAJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly ENKIFIDJGCB CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly ENKIFIDJGCB PKBIMNMGJAF;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IKONDCABGDM
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly ENKIFIDJGCB CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly ENKIFIDJGCB FFHIOAKMFPF;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly ENKIFIDJGCB NMGGKKLELPB;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly ENKIFIDJGCB NPCKDACJBHF;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly ENKIFIDJGCB GJMIIDJLMDE;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly ENKIFIDJGCB LKOPANAHCFE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly ENKIFIDJGCB NCMDCDJMJLA;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly ENKIFIDJGCB MDMDODFJNAN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly ENKIFIDJGCB GOJBKMNEIFA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly ENKIFIDJGCB ODGDFJIHGMF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly ENKIFIDJGCB GOAAGMKFLLI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly ENKIFIDJGCB CBADMLNMNEP;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class NEAICDEOAHF
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly Dictionary<Type, Type> CANGABJGMCB;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3205270", Offset = "0x3204270", VA = "0x183205270")]
	internal static object AAADLODDLOB(Type ALPPOEENOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3206860", Offset = "0x3205860", VA = "0x183206860")]
	private static object BGELIPCJHHN(Type MDNDKLJICLC, Type[] BGLIKKJOAAK, params object[] EDICCHOGPIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class PIEJLIEBFLH : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class LFDMJLMIHPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C85DF0", Offset = "0x3C84DF0", VA = "0x183C85DF0")]
		static LFDMJLMIHPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly GHACEPIJCPP ILEMLMLMFCM;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x48EF310", Offset = "0x48EE310", VA = "0x1848EF310")]
	static PIEJLIEBFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private PIEJLIEBFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class APGMJIODMHM : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class HKFOABKHNCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3B77C90", Offset = "0x3B76C90", VA = "0x183B77C90")]
		static HKFOABKHNCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly GHACEPIJCPP ILEMLMLMFCM;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x30F8900", Offset = "0x30F7900", VA = "0x1830F8900")]
	static APGMJIODMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private APGMJIODMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class JKDHFBCABMA : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class GBFFEFOCPNG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x24FC2A0", Offset = "0x24FB2A0", VA = "0x1824FC2A0")]
		static GBFFEFOCPNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly GHACEPIJCPP ILEMLMLMFCM;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31F8530", Offset = "0x31F7530", VA = "0x1831F8530")]
	static JKDHFBCABMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private JKDHFBCABMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class CNOEPJKLMGK : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class BNFEAEKPKNG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A72C60", Offset = "0x2A71C60", VA = "0x182A72C60")]
		static BNFEAEKPKNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly GHACEPIJCPP ILEMLMLMFCM;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x30FDC10", Offset = "0x30FCC10", VA = "0x1830FDC10")]
	static CNOEPJKLMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private CNOEPJKLMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JJCMPDLMDFL : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class DJOFCPBJCKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x24F8E50", Offset = "0x24F7E50", VA = "0x1824F8E50")]
		static DJOFCPBJCKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly GHACEPIJCPP ILEMLMLMFCM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x31F8040", Offset = "0x31F7040", VA = "0x1831F8040")]
	static JJCMPDLMDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private JJCMPDLMDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class GKMLIJAAIHG : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class NPEENIODBPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CF10", Offset = "0x3C3BF10", VA = "0x183C3CF10")]
		static NPEENIODBPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly GHACEPIJCPP ILEMLMLMFCM;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x31F0F90", Offset = "0x31EFF90", VA = "0x1831F0F90")]
	static GKMLIJAAIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private GKMLIJAAIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class FNNMGKGAAAH : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class KAGBOMDLELH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A770", Offset = "0x3C39770", VA = "0x183C3A770")]
		static KAGBOMDLELH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public FNNMGKGAAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class AHFIAOFANIC : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class LHCOPDOPNFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2353AB0", Offset = "0x2352AB0", VA = "0x182353AB0")]
		static LHCOPDOPNFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public AHFIAOFANIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LGFEPPILODF : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class JNPFMFGPBIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3838D40", Offset = "0x3837D40", VA = "0x183838D40")]
		static JNPFMFGPBIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public LGFEPPILODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JLDKBPNOJHP : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class ALPFODHIIKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24F3290", Offset = "0x24F2290", VA = "0x1824F3290")]
		static ALPFODHIIKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JLDKBPNOJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class LDIHKFMJGBA : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class FGKIHLMJDIP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x38320F0", Offset = "0x38310F0", VA = "0x1838320F0")]
		static FGKIHLMJDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public LDIHKFMJGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class FADDCJGHDHJ : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class PHMLDLLFMBJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDA80", Offset = "0x3BFCA80", VA = "0x183BFDA80")]
		static PHMLDLLFMBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static readonly Func<string, string> BDKPOLJGDBP;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly bool CGDNIIKAFKN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public FADDCJGHDHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class DGCPBLLKCEO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OAIIFABNFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DNCFKPNLFII LGHLAIEHABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LocalBuilder PGJIPIAFJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LocalBuilder LPCMMNNELDB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class ABNFHDHEAGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class EFLICILOPIE
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo BBCICGHPOKA;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo ADHHJEMGANL;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo LLNNIABHFIF;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo KJMMIGLHPEE;

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly MethodInfo NFLPAKDEMLI;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo JIMCGDCKCLI;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo GCEIBKOGBPN;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo ACKJEOKMKOI;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo MPIICNMNPEH;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x31084A0", Offset = "0x31074A0", VA = "0x1831084A0")]
			static EFLICILOPIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class LAOBDJJJDML
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo IJKJMAECCFB;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo IIPFNGAFDOM;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo FMHCGPJJFKA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo KPPMJHDJJPO;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo BFANOLKAJLF;

			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo OIAFGBEFKOE;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo DMJKIBEEMHI;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x310BAE0", Offset = "0x310AAE0", VA = "0x18310BAE0")]
			static LAOBDJJJDML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class GHEJNPIKDJG
		{
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			internal static readonly MethodInfo BHFNMJCBGID;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			internal static readonly MethodInfo KIBFCOEJNDP;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly ConstructorInfo EHFBKFEOCOO;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly MethodInfo JGIAJBPEOJJ;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly ConstructorInfo MEGICDCIDDI;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly MethodInfo KLKKEGLCEOM;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly MethodInfo CCIPOEPLGHM;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly MethodInfo GFGMJJGOBCL;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo KNPBBCFAHFB;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly MethodInfo NNEADHMLKEH;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo PBANIFDKGBA;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo DHNFKBICMOD;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo CBIDOAPIHFD;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo PIDAOADLCPG;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x30F6790", Offset = "0x30F5790", VA = "0x1830F6790")]
		public static MethodInfo PKICNBNNKCI(Type CIMKNKPILIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x30F6560", Offset = "0x30F5560", VA = "0x1830F6560")]
		public static MethodInfo GJAEFJLDMHL(Type CIMKNKPILIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x30F6440", Offset = "0x30F5440", VA = "0x1830F6440")]
		public static MethodInfo ALMHMCDNIGO(Type CIMKNKPILIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JAJJBHPIFFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Dictionary<DNCFKPNLFII, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public JAJJBHPIFFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DBKAGGGDKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public JAJJBHPIFFE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public DBKAGGGDKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x30FE220", Offset = "0x30FD220", VA = "0x1830FE220")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x30FE260", Offset = "0x30FD260", VA = "0x1830FE260")]
		internal bool <BuildType>b__2(int index, DNCFKPNLFII member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DOKBCGKODJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public JAJJBHPIFFE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public DOKBCGKODJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3107140", Offset = "0x3106140", VA = "0x183107140")]
		internal bool <BuildType>b__3(int index, DNCFKPNLFII member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class OPNJAJDGKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public OPNJAJDGKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x310CEB0", Offset = "0x310BEB0", VA = "0x18310CEB0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HGNJHCBIJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public HGNJHCBIJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x310B280", Offset = "0x310A280", VA = "0x18310B280")]
		internal bool <BuildAnonymousFormatter>b__2(DNCFKPNLFII x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CGFFJLIBJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public OPNJAJDGKKE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public CGFFJLIBJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x30FD390", Offset = "0x30FC390", VA = "0x1830FD390")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x30FD410", Offset = "0x30FC410", VA = "0x1830FD410")]
		internal bool <BuildAnonymousFormatter>b__6(int index, DNCFKPNLFII member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JKABEHBOGFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public OPNJAJDGKKE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public JKABEHBOGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x310B5E0", Offset = "0x310A5E0", VA = "0x18310B5E0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, DNCFKPNLFII member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class DPJPHDNAJBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public DPJPHDNAJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x53D660", Offset = "0x53C660", VA = "0x18053D660")]
		internal Label <BuildSerialize>b__1(DNCFKPNLFII _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NAEJKGLDKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public OAIIFABNFOL[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Func<int, DNCFKPNLFII, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AJFGLIJBKHJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AJFGLIJBKHJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public NAEJKGLDKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x310CD80", Offset = "0x310BD80", VA = "0x18310CD80")]
		internal OAIIFABNFOL <BuildDeserialize>b__0(DNCFKPNLFII item)
		{
			return default(OAIIFABNFOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DMMIHAIFDMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public NAEJKGLDKCM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public DMMIHAIFDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x31067D0", Offset = "0x31057D0", VA = "0x1831067D0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3106AB0", Offset = "0x3105AB0", VA = "0x183106AB0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class EFOKNJGLECB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DNCFKPNLFII item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public EFOKNJGLECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F650", Offset = "0x1B9E650", VA = "0x181B9F650")]
		internal bool <EmitNewObject>b__0(OAIIFABNFOL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class AFBDPONLIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public DNCFKPNLFII item;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public AFBDPONLIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F650", Offset = "0x1B9E650", VA = "0x181B9F650")]
		internal bool <EmitNewObject>b__2(OAIIFABNFOL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly Regex DLAJDCFDHPE;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int GJOJICGLFLH;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static HashSet<Type> PNPMGONBNLJ;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static HashSet<Type> GCEACJPGMDD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x39BD2F0", Offset = "0x39BC2F0", VA = "0x1839BD2F0")]
	public static object FAHMFMIEIGK<T>(GHACEPIJCPP ILEMLMLMFCM, ENKIFIDJGCB PDFJMPDMAHH, Func<string, string> BDKPOLJGDBP, bool CGDNIIKAFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x39B27E0", Offset = "0x39B17E0", VA = "0x1839B27E0")]
	public static object CAMPGOLBHKK<T>(ENKIFIDJGCB PDFJMPDMAHH, Func<string, string> BDKPOLJGDBP, bool CGDNIIKAFKN, bool GBKOMNCCLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3103440", Offset = "0x3102440", VA = "0x183103440")]
	private static TypeInfo MOGLKEEHAOH(GHACEPIJCPP ILEMLMLMFCM, Type CIMKNKPILIM, Func<string, string> BDKPOLJGDBP, bool CGDNIIKAFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3101610", Offset = "0x3100610", VA = "0x183101610")]
	public static object GAJADJKKDIC(Type CIMKNKPILIM, Func<string, string> BDKPOLJGDBP, bool CGDNIIKAFKN, bool GBKOMNCCLND, bool LNDEDMJLGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3103EE0", Offset = "0x3102EE0", VA = "0x183103EE0")]
	private static Dictionary<DNCFKPNLFII, FieldInfo> OBMPLHMDFIH(TypeBuilder DHIBNOPGOJM, JNEPBIOBLCD IAPOEGMMNBD, ConstructorInfo PCBNHJBHPCJ, FieldBuilder MNPPJPPKIFC, ILGenerator AKDHBNNIOJN, bool CGDNIIKAFKN, bool NDCENFHKPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x30FF870", Offset = "0x30FE870", VA = "0x1830FF870")]
	private static Dictionary<DNCFKPNLFII, FieldInfo> CPKBONFFMIC(TypeBuilder DHIBNOPGOJM, JNEPBIOBLCD IAPOEGMMNBD, ILGenerator AKDHBNNIOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x31045E0", Offset = "0x31035E0", VA = "0x1831045E0")]
	private static void OMPMPDPODKE(Type CIMKNKPILIM, JNEPBIOBLCD IAPOEGMMNBD, ILGenerator AKDHBNNIOJN, Action KNNNHEMLLEP, Func<int, DNCFKPNLFII, bool> FNGIKMCBBOK, bool CGDNIIKAFKN, bool NDCENFHKPKF, int LNILDCLFIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3102F50", Offset = "0x3101F50", VA = "0x183102F50")]
	private static void IMBMNCLHMFK(TypeInfo CIMKNKPILIM, DNCFKPNLFII JPBNJHKKKHP, ILGenerator AKDHBNNIOJN, int IDCLMAKCIEP, Func<int, DNCFKPNLFII, bool> FNGIKMCBBOK, AJFGLIJBKHJ DJLDOCIGJKE, AJFGLIJBKHJ CJPIEHAJBDG, AJFGLIJBKHJ DOKNBPEPPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x30FE4A0", Offset = "0x30FD4A0", VA = "0x1830FE4A0")]
	private static void BBNEBHAFGHK(Type CIMKNKPILIM, JNEPBIOBLCD IAPOEGMMNBD, ILGenerator AKDHBNNIOJN, Func<int, DNCFKPNLFII, bool> FNGIKMCBBOK, bool NCPNCAMGDHL, int LNILDCLFIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x31011F0", Offset = "0x31001F0", VA = "0x1831011F0")]
	private static void FOHBLKHPJNE(ILGenerator AKDHBNNIOJN, OAIIFABNFOL IAPOEGMMNBD, int IDCLMAKCIEP, Func<int, DNCFKPNLFII, bool> FNGIKMCBBOK, AJFGLIJBKHJ ACDBGHLODNH, AJFGLIJBKHJ DOKNBPEPPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x30FFE40", Offset = "0x30FEE40", VA = "0x1830FFE40")]
	private static LocalBuilder DGFNJKAHBND(ILGenerator AKDHBNNIOJN, Type CIMKNKPILIM, JNEPBIOBLCD IAPOEGMMNBD, OAIIFABNFOL[] GBLNLIPBJBB, bool KCDEOHEBGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3100B20", Offset = "0x30FFB20", VA = "0x183100B20")]
	private static bool ELFKDBEJNJH(ConstructorInfo EBMKJFGMIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x30FE300", Offset = "0x30FD300", VA = "0x1830FE300")]
	private static bool AHCGOJJLNJF(Type CIMKNKPILIM, out Type CNCCPPCIMAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate void KADIIBCCCAP<T>(byte[][] MNPPJPPKIFC, object[] IBGBICCLCMB, ref PJHNLAIFAEP DJLDOCIGJKE, T DDDOLDGEMNC, ENKIFIDJGCB IMFLLANEHFA);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal delegate T PDDLAGEBLMN<T>(object[] IBGBICCLCMB, ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB IMFLLANEHFA);
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class AOLNMENLPBO<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class CFCOLONABJI : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class FOEMJLCCIIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x35A1D00", Offset = "0x35A0D00", VA = "0x1835A1D00")]
		static FOEMJLCCIIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private CFCOLONABJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class BIANDNAPHJN : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class EFEBCKOGHNP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x25FD3B0", Offset = "0x25FC3B0", VA = "0x1825FD3B0")]
		static EFEBCKOGHNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private BIANDNAPHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal static class FAABCONBLAJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal static readonly ENKIFIDJGCB[] GOOFJHLHHJE;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class LCFOLFLLHLB : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private static class IAIGENLOOON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3E011C0", Offset = "0x3E001C0", VA = "0x183E011C0")]
		static IAIGENLOOON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private sealed class EHPHEJHJOKL : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private static class CLDEDNJKFOJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3DFBBC0", Offset = "0x3DFABC0", VA = "0x183DFBBC0")]
			static CLDEDNJKFOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private EHPHEJHJOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private LCFOLFLLHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal sealed class AKFGBJFEFNC : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private static class IAEKENFBHCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3B799A0", Offset = "0x3B789A0", VA = "0x183B799A0")]
		static IAEKENFBHCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private sealed class HPNMBIMFNOO : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private static class NADIKBNFCCA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3B82740", Offset = "0x3B81740", VA = "0x183B82740")]
			static NADIKBNFCCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private HPNMBIMFNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private AKFGBJFEFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal sealed class MOENGGLMJLN : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private static class EMLEIEBLJAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9660", Offset = "0x2DF8660", VA = "0x182DF9660")]
		static EMLEIEBLJAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class JHCPPDNEPIB : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private static class GFBDODNHEDI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB650", Offset = "0x2DFA650", VA = "0x182DFB650")]
			static GFBDODNHEDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private JHCPPDNEPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private MOENGGLMJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class LABOHMDJEGD : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private static class NKJHNOHEMEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E12EC0", Offset = "0x3E11EC0", VA = "0x183E12EC0")]
		static NKJHNOHEMEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class DLOEFBCJLCP : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		private static class FJOLACADAEE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDF30", Offset = "0x3DFCF30", VA = "0x183DFDF30")]
			static FJOLACADAEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private DLOEFBCJLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private LABOHMDJEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class BLMCNBJGOGK : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private static class EODCLBKMEGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x260A8F0", Offset = "0x26098F0", VA = "0x18260A8F0")]
		static EODCLBKMEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class JIGCNFFAKKC : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		private static class EKKCJDDGMBA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2607550", Offset = "0x2606550", VA = "0x182607550")]
			static EKKCJDDGMBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private JIGCNFFAKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private BLMCNBJGOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class KCNLDFDPLKM : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private static class OJELCFBPFND<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3472460", Offset = "0x3471460", VA = "0x183472460")]
		static OJELCFBPFND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private sealed class EJNLLCBEMKC : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private static class LGLDKAPCPJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x346E7B0", Offset = "0x346D7B0", VA = "0x18346E7B0")]
			static LGLDKAPCPJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private EJNLLCBEMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private KCNLDFDPLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal sealed class DAOPLILIPIB : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private static class EGCGMFNLBJI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x38C37F0", Offset = "0x38C27F0", VA = "0x1838C37F0")]
		static EGCGMFNLBJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private sealed class KKFHGJIIBID : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		private static class NNOLKPCHMCO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x38CDE20", Offset = "0x38CCE20", VA = "0x1838CDE20")]
			static NNOLKPCHMCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private KKFHGJIIBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private DAOPLILIPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
internal sealed class ECMDMIAECIH : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private static class HPBNNLEGDOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37EDC80", Offset = "0x37ECC80", VA = "0x1837EDC80")]
		static HPBNNLEGDOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private sealed class MGIEHLONPKO : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private static class FNBBKEKMIEN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x37EB900", Offset = "0x37EA900", VA = "0x1837EB900")]
			static FNBBKEKMIEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private MGIEHLONPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private ECMDMIAECIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal sealed class CFANPCEGKAG : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private static class IOBMKGNNBON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x35AE010", Offset = "0x35AD010", VA = "0x1835AE010")]
		static IOBMKGNNBON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private sealed class KDDDEKHGODC : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private static class DLMFNMCDNCB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x359E270", Offset = "0x359D270", VA = "0x18359E270")]
			static DLMFNMCDNCB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private KDDDEKHGODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private CFANPCEGKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal sealed class LIMDLIAPJJL : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private static class MAKLADNCAFC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3D88140", Offset = "0x3D87140", VA = "0x183D88140")]
		static MAKLADNCAFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private sealed class OPOHHKJMOAB : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		private static class PKGDNPGKAKM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3D8D8A0", Offset = "0x3D8C8A0", VA = "0x183D8D8A0")]
			static PKGDNPGKAKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private OPOHHKJMOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private LIMDLIAPJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal sealed class LEKBGLEEDFG : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private static class MCHGDOGDDIB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3845F20", Offset = "0x3844F20", VA = "0x183845F20")]
		static MCHGDOGDDIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class FLKPHHDNFGN : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private static class GBMPIHLNJNL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3836FB0", Offset = "0x3835FB0", VA = "0x183836FB0")]
			static GBMPIHLNJNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private FLKPHHDNFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private LEKBGLEEDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal sealed class COPEMIGMHJK : ENKIFIDJGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private static class NJLGJHJIKMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A834C0", Offset = "0x2A824C0", VA = "0x182A834C0")]
		static NJLGJHJIKMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class DMCPOBBNAAA : ENKIFIDJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private static class OOOCAEODKGA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly global::EMIGBNLKFFH<T> GFMOJKDJHKD;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A93E00", Offset = "0x2A92E00", VA = "0x182A93E00")]
			static OOOCAEODKGA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ENKIFIDJGCB BBILGMKNANF;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static readonly ENKIFIDJGCB[] HAHKBOONPMD;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		private DMCPOBBNAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
		public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static readonly ENKIFIDJGCB BBILGMKNANF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly global::EMIGBNLKFFH<object> IENEKEMFBHE;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	private COPEMIGMHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x294C0B0", Offset = "0x294B0B0", VA = "0x18294C0B0", Slot = "4")]
	public global::EMIGBNLKFFH<T> AAADLODDLOB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct HCDPEECIPLN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public T[] JLJCCAHOEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public int LABKDOAMNAE;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D47810", Offset = "0x2D46810", VA = "0x182D47810")]
	public HCDPEECIPLN(int CMENBCBOANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D47590", Offset = "0x2D46590", VA = "0x182D47590")]
	public void ONGBLFOLDCH(T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D47420", Offset = "0x2D46420", VA = "0x182D47420")]
	public T[] BKKHKMDGMEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal sealed class GALJHIBLLLF : global::MGNCLHEBDOI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly GALJHIBLLLF CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x310AB10", Offset = "0x3109B10", VA = "0x18310AB10")]
	public GALJHIBLLLF(int CODCABKBIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class MGNCLHEBDOI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly int CODCABKBIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly object NCAICAEBPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int IDCLMAKCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T[][] GIPIGLKECCN;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x244BFE0", Offset = "0x244AFE0", VA = "0x18244BFE0")]
	public MGNCLHEBDOI(int CODCABKBIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x244B0E0", Offset = "0x244A0E0", VA = "0x18244B0E0")]
	public T[] GIMHLINDNIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2449820", Offset = "0x2448820", VA = "0x182449820")]
	public void CAEIDBMJIBJ(T[] ABDMDAMADHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class FNEGPNFNIEC : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class POOBOIPKDLB : IComparable<POOBOIPKDLB>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class ANFGKAJNKEG : IEnumerable<POOBOIPKDLB>, IEnumerable, IEnumerator<POOBOIPKDLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private POOBOIPKDLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public POOBOIPKDLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private POOBOIPKDLB System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
			[DebuggerHidden]
			public ANFGKAJNKEG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x30F8780", Offset = "0x30F7780", VA = "0x1830F8780", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x30F88B0", Offset = "0x30F78B0", VA = "0x1830F88B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x30F8810", Offset = "0x30F7810", VA = "0x1830F8810", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<POOBOIPKDLB> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x30F8810", Offset = "0x30F7810", VA = "0x1830F8810", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class PAAAABEIDFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public PAAAABEIDFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x53D660", Offset = "0x53C660", VA = "0x18053D660")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x53D660", Offset = "0x53C660", VA = "0x18053D660")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly POOBOIPKDLB[] LMMAMIGAKMD;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly ulong[] GLNOPLIJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public ulong ABFANLOKOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int DPFBMCEIHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public string HCEOGNJKDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private POOBOIPKDLB[] OAEKBMAJLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ulong[] KMNLBCMGNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int MODLAKNNNAK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FHFLADGOMNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xDFABF0", Offset = "0xDF9BF0", VA = "0x180DFABF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x310E870", Offset = "0x310D870", VA = "0x18310E870")]
		public POOBOIPKDLB(ulong MNGGKJHHPNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x310E460", Offset = "0x310D460", VA = "0x18310E460")]
		public POOBOIPKDLB ONGBLFOLDCH(ulong MNGGKJHHPNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x310E650", Offset = "0x310D650", VA = "0x18310E650")]
		public POOBOIPKDLB ONGBLFOLDCH(ulong MNGGKJHHPNI, int DDDOLDGEMNC, string HCEOGNJKDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x310D570", Offset = "0x310C570", VA = "0x18310D570")]
		public POOBOIPKDLB ALPEMKLBFBK(byte[] MDNHLBDMHCF, ref int GDBLDPHBNNG, ref int EBAKDFLNKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x310E370", Offset = "0x310D370", VA = "0x18310E370")]
		internal static int JPBNAEAMBCJ(ulong[] ABDMDAMADHK, int IDCLMAKCIEP, int BODBKIOPHHK, ulong DDDOLDGEMNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x310D720", Offset = "0x310C720", VA = "0x18310D720", Slot = "4")]
		public int CompareTo(POOBOIPKDLB AGELLNNPMJB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x310E3F0", Offset = "0x310D3F0", VA = "0x18310E3F0")]
		[IteratorStateMachine(typeof(ANFGKAJNKEG))]
		public IEnumerable<POOBOIPKDLB> NGKAFJELJEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x310E6A0", Offset = "0x310D6A0", VA = "0x18310E6A0")]
		public void PKLILCPHDDA(ILGenerator AKDHBNNIOJN, LocalBuilder MDNHLBDMHCF, LocalBuilder EBAKDFLNKCK, LocalBuilder MNGGKJHHPNI, Action<KeyValuePair<string, int>> NMJEFCNALGD, Action PPFJDCHMEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x310D750", Offset = "0x310C750", VA = "0x18310D750")]
		private static void DMHEPDCJGLO(ILGenerator AKDHBNNIOJN, LocalBuilder MDNHLBDMHCF, LocalBuilder EBAKDFLNKCK, LocalBuilder MNGGKJHHPNI, Action<KeyValuePair<string, int>> NMJEFCNALGD, Action PPFJDCHMEEF, POOBOIPKDLB[] OAEKBMAJLKN, int MODLAKNNNAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class PFKPADEDLHH : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private IEnumerable<POOBOIPKDLB> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IEnumerable<POOBOIPKDLB> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private IEnumerator<POOBOIPKDLB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private POOBOIPKDLB <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x5359D0", Offset = "0x5349D0", VA = "0x1805359D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x310D380", Offset = "0x310C380", VA = "0x18310D380", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9E3950", Offset = "0x9E2950", VA = "0x1809E3950")]
		[DebuggerHidden]
		public PFKPADEDLHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x310D3D0", Offset = "0x310C3D0", VA = "0x18310D3D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x310CF10", Offset = "0x310BF10", VA = "0x18310CF10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x310D4D0", Offset = "0x310C4D0", VA = "0x18310D4D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x310D520", Offset = "0x310C520", VA = "0x18310D520")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x310D330", Offset = "0x310C330", VA = "0x18310D330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x310D290", Offset = "0x310C290", VA = "0x18310D290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x310D290", Offset = "0x310C290", VA = "0x18310D290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly POOBOIPKDLB COCNNHFBEEP;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x310A970", Offset = "0x3109970", VA = "0x18310A970")]
	public FNEGPNFNIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x310A730", Offset = "0x3109730", VA = "0x18310A730")]
	public void ONGBLFOLDCH(byte[] CPFFKFOFBAE, int DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x310A300", Offset = "0x3109300", VA = "0x18310A300")]
	public bool FLJLOFHGPCA(ArraySegment<byte> MNGGKJHHPNI, out int DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x310A880", Offset = "0x3109880", VA = "0x18310A880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x310A4B0", Offset = "0x31094B0", VA = "0x18310A4B0")]
	private static void KJJCNGOONFM(IEnumerable<POOBOIPKDLB> OAEKBMAJLKN, StringBuilder AIJEPGICEJA, int EIIGHGIDAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x310A3B0", Offset = "0x31093B0", VA = "0x18310A3B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x310A3B0", Offset = "0x31093B0", VA = "0x18310A3B0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x310A290", Offset = "0x3109290", VA = "0x18310A290")]
	[IteratorStateMachine(typeof(PFKPADEDLHH))]
	private static IEnumerable<KeyValuePair<string, int>> AMGGFMEHJNG(IEnumerable<POOBOIPKDLB> OAEKBMAJLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x310A850", Offset = "0x3109850", VA = "0x18310A850")]
	public void PKGMBGHBJHF(ILGenerator AKDHBNNIOJN, LocalBuilder MDNHLBDMHCF, LocalBuilder EBAKDFLNKCK, LocalBuilder MNGGKJHHPNI, Action<KeyValuePair<string, int>> NMJEFCNALGD, Action PPFJDCHMEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class ONEFBPJGJJH
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static readonly MethodInfo FFBAKHNAKLM;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x48E5A70", Offset = "0x48E4A70", VA = "0x1848E5A70")]
	public static ulong PLFMNJKLIDB(byte[] CPFFKFOFBAE, ref int GDBLDPHBNNG, ref int EBAKDFLNKCK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class EEJLNOKNNEK
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x31081A0", Offset = "0x31071A0", VA = "0x1831081A0")]
	public static void AECNNDDCJKK(ref byte[] CPFFKFOFBAE, int GDBLDPHBNNG, int GCCELFOCHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x31082C0", Offset = "0x31072C0", VA = "0x1831082C0")]
	public static void BGLEJAJGCNJ(ref byte[] ABDMDAMADHK, int EMBLGPGFDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x31083B0", Offset = "0x31073B0", VA = "0x1831083B0")]
	public static byte[] GIPKIECKCDK(byte[] CEHHAHEMFNJ, int EMBLGPGFDLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class KCJDCENOGKG
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x31FA1C0", Offset = "0x31F91C0", VA = "0x1831FA1C0")]
	public static bool GOHNAOFJIKF(byte[] KALHEHCPBKI, int LMKBOPKNAPA, int OIPGMINGLIF, byte[] APPJJHHJLNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class NHAKACDFENC<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private struct FJHAPJBLLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public byte[] ABFANLOKOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T DPFBMCEIHFE;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x303A9B0", Offset = "0x30399B0", VA = "0x18303A9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class CCIFEFBCLKG : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public global::NHAKACDFENC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private FJHAPJBLLNI[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private FJHAPJBLLNI[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x14CD640", Offset = "0x14CC640", VA = "0x1814CD640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x3035C50", Offset = "0x3034C50", VA = "0x183035C50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x224D7F0", Offset = "0x224C7F0", VA = "0x18224D7F0")]
		[DebuggerHidden]
		public CCIFEFBCLKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3034280", Offset = "0x3033280", VA = "0x183034280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3035B10", Offset = "0x3034B10", VA = "0x183035B10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly FJHAPJBLLNI[][] NEMGOMFCLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly ulong KCOAABIENDA;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x30453D0", Offset = "0x30443D0", VA = "0x1830453D0")]
	public NHAKACDFENC(int NBDFKNGGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3045400", Offset = "0x3044400", VA = "0x183045400")]
	public NHAKACDFENC(int NBDFKNGGAPC, float HOCJOEIAMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3044C10", Offset = "0x3043C10", VA = "0x183044C10")]
	public void ONGBLFOLDCH(byte[] MNGGKJHHPNI, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3042610", Offset = "0x3041610", VA = "0x183042610")]
	private bool ODCHHCGNDHN(byte[] MNGGKJHHPNI, T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3041890", Offset = "0x3040890", VA = "0x183041890")]
	public bool MMEDHLOPCHO(ArraySegment<byte> MNGGKJHHPNI, out T DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3040C60", Offset = "0x303FC60", VA = "0x183040C60")]
	private static ulong AEFBNDNPEFJ(byte[] LLFMGCPPNJC, int GDBLDPHBNNG, int MODLAKNNNAK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3040CC0", Offset = "0x303FCC0", VA = "0x183040CC0")]
	private static int DHHPALDJPJN(int EDIJEGKICOL, float HOCJOEIAMOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3040D80", Offset = "0x303FD80", VA = "0x183040D80", Slot = "4")]
	[IteratorStateMachine(typeof(global::NHAKACDFENC<>.CCIFEFBCLKG))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x22A8810", Offset = "0x22A7810", VA = "0x1822A8810", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class IMHALBDNMNI : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly OpCode[] CAAHPADHIBA;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly OpCode[] AGGCKOHICAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int AMECOBCCLCL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MILBNLGPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x31F5260", Offset = "0x31F4260", VA = "0x1831F5260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x31F53C0", Offset = "0x31F43C0", VA = "0x1831F53C0")]
	static IMHALBDNMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x31F5610", Offset = "0x31F4610", VA = "0x1831F5610")]
	public IMHALBDNMNI(byte[] DOIKKFAINNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x31F52B0", Offset = "0x31F42B0", VA = "0x1831F52B0")]
	public OpCode KMBAMPBBKCA()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct OPKJJOLGEEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly Guid DPFBMCEIHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte IGPCFHDPCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte LJGNCOCKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte FOGHNGHNKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte MIGINBPEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte PALLKKJAPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte KCEMOGBBEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte KBHEGJKJJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte JJNMKEJIBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte LCKKMOOIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte BNDEOMCMIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte CFDDPKKCGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte NMJBDLBIBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte AAGBDDBMDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte PHNHLFKLOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte GIONHDLBNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte AFLJHCNBMIK;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static byte[] PHKPCNCBNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static byte[] LAFJEPAPJKL;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x48E80C0", Offset = "0x48E70C0", VA = "0x1848E80C0")]
	public OPKJJOLGEEH(ref Guid DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x48E80D0", Offset = "0x48E70D0", VA = "0x1848E80D0")]
	public OPKJJOLGEEH(ref ArraySegment<byte> IAAMIBHJDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x48E6B00", Offset = "0x48E5B00", VA = "0x1848E6B00")]
	private static byte CIJGHHAEBBI(byte[] CPFFKFOFBAE, int FJDPAEMNKLN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x48E7F00", Offset = "0x48E6F00", VA = "0x1848E7F00")]
	private static byte NHIPGIPEJCL(byte FFKAJGPOGIJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x48E6BC0", Offset = "0x48E5BC0", VA = "0x1848E6BC0")]
	public void INILAIGCPHM(byte[] CGBPEHFCGMK, int GDBLDPHBNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class PAMMEIIACHE
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x48E9F90", Offset = "0x48E8F90", VA = "0x1848E9F90")]
	public static bool JKAOPGMDJIH(byte LEBLBLLCPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x48EA080", Offset = "0x48E9080", VA = "0x1848EA080")]
	public static bool PENGIMKHOGG(byte LEBLBLLCPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x48E9FA0", Offset = "0x48E8FA0", VA = "0x1848E9FA0")]
	public static sbyte KGACMCOIADF(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x48E9040", Offset = "0x48E8040", VA = "0x1848E9040")]
	public static short BHCECPMKIMC(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x48E8780", Offset = "0x48E7780", VA = "0x1848E8780")]
	public static int ACFOCLEIDHF(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x48E91C0", Offset = "0x48E81C0", VA = "0x1848E91C0")]
	public static long CKCEDOIKLFO(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x48EA0F0", Offset = "0x48E90F0", VA = "0x1848EA0F0")]
	public static byte PGIGDODNLID(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x48E9EB0", Offset = "0x48E8EB0", VA = "0x1848E9EB0")]
	public static ushort EPIEEBJFPCP(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x48E8FC0", Offset = "0x48E7FC0", VA = "0x1848E8FC0")]
	public static uint BDCLAMJLNEL(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x48E90B0", Offset = "0x48E80B0", VA = "0x1848E90B0")]
	public static ulong BJJCMCBJIOB(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x48EA010", Offset = "0x48E9010", VA = "0x1848EA010")]
	public static float LNJPLFBBMJC(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x48E9F20", Offset = "0x48E8F20", VA = "0x1848E9F20")]
	public static double IKIJLHFLNLH(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x48E87F0", Offset = "0x48E77F0", VA = "0x1848E87F0")]
	public static int AGHNELAGMPM(ref byte[] CGBPEHFCGMK, int GDBLDPHBNNG, ulong DDDOLDGEMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x48E9270", Offset = "0x48E8270", VA = "0x1848E9270")]
	public static int DDNLIBLEAOE(ref byte[] CGBPEHFCGMK, int GDBLDPHBNNG, long DDDOLDGEMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x48EA160", Offset = "0x48E9160", VA = "0x1848EA160")]
	public static bool PGKACOMPOMI(byte[] CPFFKFOFBAE, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class BLEAFJHCEDK
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class BBIEIAEMGKI : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
		[DebuggerHidden]
		public BBIEIAEMGKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x30F9220", Offset = "0x30F8220", VA = "0x1830F9220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x30F8DC0", Offset = "0x30F7DC0", VA = "0x1830F8DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x30F9340", Offset = "0x30F8340", VA = "0x1830F9340")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x30F9390", Offset = "0x30F8390", VA = "0x1830F9390")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x30F91D0", Offset = "0x30F81D0", VA = "0x1830F91D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x30F9120", Offset = "0x30F8120", VA = "0x1830F9120", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x30F9120", Offset = "0x30F8120", VA = "0x1830F9120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class MACJGAPIADD : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
		[DebuggerHidden]
		public MACJGAPIADD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x310CA40", Offset = "0x310BA40", VA = "0x18310CA40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x310C5E0", Offset = "0x310B5E0", VA = "0x18310C5E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x310CB60", Offset = "0x310BB60", VA = "0x18310CB60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x310CBB0", Offset = "0x310BBB0", VA = "0x18310CBB0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x310C9F0", Offset = "0x310B9F0", VA = "0x18310C9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x310C940", Offset = "0x310B940", VA = "0x18310C940", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x310C940", Offset = "0x310B940", VA = "0x18310C940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x30FC7E0", Offset = "0x30FB7E0", VA = "0x1830FC7E0")]
	public static bool HKNHGIALIPE(this TypeInfo CIMKNKPILIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x30FC6E0", Offset = "0x30FB6E0", VA = "0x1830FC6E0")]
	public static bool GDBFDGFKDON(this TypeInfo CIMKNKPILIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x30FC920", Offset = "0x30FB920", VA = "0x1830FC920")]
	public static IEnumerable<PropertyInfo> PGABPIAHJOG(this Type CIMKNKPILIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x30FC890", Offset = "0x30FB890", VA = "0x1830FC890")]
	[IteratorStateMachine(typeof(BBIEIAEMGKI))]
	private static IEnumerable<PropertyInfo> LFHBGMAKOBJ(Type CIMKNKPILIM, HashSet<string> NOOJKJMNIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x30FC680", Offset = "0x30FB680", VA = "0x1830FC680")]
	public static IEnumerable<FieldInfo> CFFODLMNMMI(this Type CIMKNKPILIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x30FC5F0", Offset = "0x30FB5F0", VA = "0x1830FC5F0")]
	[IteratorStateMachine(typeof(MACJGAPIADD))]
	private static IEnumerable<FieldInfo> BKFOEEGGBNF(Type CIMKNKPILIM, HashSet<string> NOOJKJMNIEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class PDAKAODPGOL
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly Encoding PHEPJPKAHBB;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal static class FHBICOCEEOJ
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CB0", Offset = "0x5D4CB0", VA = "0x1805D5CB0")]
	public static string MIKADPMJDEL(string JEOKDIGJIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x310A180", Offset = "0x3109180", VA = "0x18310A180")]
	public static string NOKBONGCIPN(string JEOKDIGJIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3109FB0", Offset = "0x3108FB0", VA = "0x183109FB0")]
	public static string EGGMMHEJNHJ(string JEOKDIGJIBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class KKKLMDJJKMB<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class GJDLLJKEPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Type ABFANLOKOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public TValue DPFBMCEIHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int MKIHKGKPBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public GJDLLJKEPFC GDGIBHOEICN;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEF70", Offset = "0x3DFDF70", VA = "0x183DFEF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEEF0", Offset = "0x3DFDEF0", VA = "0x183DFEEF0")]
		private int LPNJCDLGCHF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public GJDLLJKEPFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class DKCFEPELKMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public DKCFEPELKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5C1B70", Offset = "0x5C0B70", VA = "0x1805C1B70")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private GJDLLJKEPFC[] NEMGOMFCLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int ACFAACNMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly object BAEDNNKJMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly float HOCJOEIAMOO;

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3E04640", Offset = "0x3E03640", VA = "0x183E04640")]
	public KKKLMDJJKMB(int NBDFKNGGAPC = 4, float HOCJOEIAMOO = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3E03F30", Offset = "0x3E02F30", VA = "0x183E03F30")]
	public bool NGHONFINKGC(Type MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3E03EB0", Offset = "0x3E02EB0", VA = "0x183E03EB0")]
	public bool NGHONFINKGC(Type MNGGKJHHPNI, Func<Type, TValue> MGJMILOBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3E04340", Offset = "0x3E03340", VA = "0x183E04340")]
	private bool ODCHHCGNDHN(Type MNGGKJHHPNI, Func<Type, TValue> MGJMILOBBIL, out TValue AIMDMJBIODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3E03220", Offset = "0x3E02220", VA = "0x183E03220")]
	private bool BGHLNJLOPDM(GJDLLJKEPFC[] NEMGOMFCLDD, Type PBCOHLLCIJF, GJDLLJKEPFC GHHLOPEFDML, Func<Type, TValue> MGJMILOBBIL, out TValue AIMDMJBIODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3E03C50", Offset = "0x3E02C50", VA = "0x183E03C50")]
	public bool MMEDHLOPCHO(Type MNGGKJHHPNI, out TValue DDDOLDGEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3E03A60", Offset = "0x3E02A60", VA = "0x183E03A60")]
	public TValue JJFCIDPKKBG(Type MNGGKJHHPNI, Func<Type, TValue> MGJMILOBBIL)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3040CC0", Offset = "0x303FCC0", VA = "0x183040CC0")]
	private static int DHHPALDJPJN(int EDIJEGKICOL, float HOCJOEIAMOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3E03980", Offset = "0x3E02980", VA = "0x183E03980")]
	private static void IPECPEBBNLH(ref GJDLLJKEPFC EENPABEMKMA, GJDLLJKEPFC DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3E03980", Offset = "0x3E02980", VA = "0x183E03980")]
	private static void IPECPEBBNLH(ref GJDLLJKEPFC[] EENPABEMKMA, GJDLLJKEPFC[] DDDOLDGEMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class GHACEPIJCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly AssemblyBuilder GFMFNAOHFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly ModuleBuilder HENGGNADJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly object NCAICAEBPIO;

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x310AB60", Offset = "0x3109B60", VA = "0x18310AB60")]
	public TypeBuilder AGIBMOMILAH(string GDCCAEJAPNJ, TypeAttributes NLGMPGMBLEK, Type OACJHOOKBCN, Type[] JHOKEJJNMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x310AC50", Offset = "0x3109C50", VA = "0x18310AC50")]
	public GHACEPIJCPP(string NNKNDHPLEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class OKMMFOOBDGN
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x48E5980", Offset = "0x48E4980", VA = "0x1848E5980")]
	private static MethodInfo FFEICPFAOKO(LambdaExpression IKPGDOGEGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x28C3450", Offset = "0x28C2450", VA = "0x1828C3450")]
	public static MethodInfo DABHJPIHEHC<T>(Expression<Func<T>> IKPGDOGEGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x28C3450", Offset = "0x28C2450", VA = "0x1828C3450")]
	public static MethodInfo DABHJPIHEHC<T, TR>(Expression<Func<T, TR>> IKPGDOGEGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x28C3450", Offset = "0x28C2450", VA = "0x1828C3450")]
	public static MethodInfo DABHJPIHEHC<T>(Expression<Action<T>> IKPGDOGEGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x28C3450", Offset = "0x28C2450", VA = "0x1828C3450")]
	public static MethodInfo DABHJPIHEHC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> IKPGDOGEGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x28C34C0", Offset = "0x28C24C0", VA = "0x1828C34C0")]
	private static MemberInfo PBAMEJKMLBA<T>(Expression<T> NELCGJMDLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x28C3460", Offset = "0x28C2460", VA = "0x1828C3460")]
	public static PropertyInfo HGAIHNDFGEB<T, TR>(Expression<Func<T, TR>> IKPGDOGEGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal struct AJFGLIJBKHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int JBBLPPAEOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly bool KNMLKNCCFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly ILGenerator AKDHBNNIOJN;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x30F8120", Offset = "0x30F7120", VA = "0x1830F8120")]
	public AJFGLIJBKHJ(ILGenerator AKDHBNNIOJN, int JBBLPPAEOAH, bool KNMLKNCCFHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x30F8090", Offset = "0x30F7090", VA = "0x1830F8090")]
	public AJFGLIJBKHJ(ILGenerator AKDHBNNIOJN, int JBBLPPAEOAH, Type CIMKNKPILIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x30F7F80", Offset = "0x30F6F80", VA = "0x1830F7F80")]
	public void GNOCGLILDLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class BKNNPLDLNHC
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x30FC100", Offset = "0x30FB100", VA = "0x1830FC100")]
	public static void LACDLPHEJLJ(this ILGenerator AKDHBNNIOJN, int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x30FC330", Offset = "0x30FB330", VA = "0x1830FC330")]
	public static void LACDLPHEJLJ(this ILGenerator AKDHBNNIOJN, LocalBuilder HOHODAMKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x30FBD80", Offset = "0x30FAD80", VA = "0x1830FBD80")]
	public static void HNPALCPNNLO(this ILGenerator AKDHBNNIOJN, int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x30FBFB0", Offset = "0x30FAFB0", VA = "0x1830FBFB0")]
	public static void HNPALCPNNLO(this ILGenerator AKDHBNNIOJN, LocalBuilder HOHODAMKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x30FBB80", Offset = "0x30FAB80", VA = "0x1830FBB80")]
	public static void FJJCCHAJIPG(this ILGenerator AKDHBNNIOJN, int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x30FBC70", Offset = "0x30FAC70", VA = "0x1830FBC70")]
	public static void FJJCCHAJIPG(this ILGenerator AKDHBNNIOJN, LocalBuilder HOHODAMKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x30FBB70", Offset = "0x30FAB70", VA = "0x1830FBB70")]
	public static void EMDLOADMHOD(this ILGenerator AKDHBNNIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x30FBFF0", Offset = "0x30FAFF0", VA = "0x1830FBFF0")]
	public static void JJNBBDLGDOE(this ILGenerator AKDHBNNIOJN, bool DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x30FB500", Offset = "0x30FA500", VA = "0x1830FB500")]
	public static void EDOBLHLEKPH(this ILGenerator AKDHBNNIOJN, int DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x30FB9F0", Offset = "0x30FA9F0", VA = "0x1830FB9F0")]
	public static void EJEJPOPMNCJ(this ILGenerator AKDHBNNIOJN, Type CIMKNKPILIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x30FB950", Offset = "0x30FA950", VA = "0x1830FB950")]
	public static void EGBEKNEPGJK(this ILGenerator AKDHBNNIOJN, Type CIMKNKPILIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x30FB250", Offset = "0x30FA250", VA = "0x1830FB250")]
	public static void BHADGNILBEL(this ILGenerator AKDHBNNIOJN, int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x30FB480", Offset = "0x30FA480", VA = "0x1830FB480")]
	public static void DJMOPMJHPGL(this ILGenerator AKDHBNNIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x30FC370", Offset = "0x30FB370", VA = "0x1830FC370")]
	public static void LCEOGJPNKEN(this ILGenerator AKDHBNNIOJN, int IDCLMAKCIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x30FC000", Offset = "0x30FB000", VA = "0x1830FC000")]
	public static void KNCGMEKMDDG(this ILGenerator AKDHBNNIOJN, MethodInfo LDKHIDEGMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x30FBAE0", Offset = "0x30FAAE0", VA = "0x1830FBAE0")]
	public static void ELFKCIGKFNL(this ILGenerator AKDHBNNIOJN, FieldInfo JEPMIHDFJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x30FC460", Offset = "0x30FB460", VA = "0x1830FC460")]
	public static void NDNLDBKGJMP(this ILGenerator AKDHBNNIOJN, ulong DDDOLDGEMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class DNCFKPNLFII
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class BLAAILHNAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public BLAAILHNAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x30FC4F0", Offset = "0x30FB4F0", VA = "0x1830FC4F0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private MethodInfo MIPLGMBBALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private MethodInfo KBCKEHAIFOL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BILCIOOICBK
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string PPJINNMCFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x514430", Offset = "0x513430", VA = "0x180514430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JHIJIDLCHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3106B50", Offset = "0x3105B50", VA = "0x183106B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MFFAOIAJCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x534BC0", Offset = "0x533BC0", VA = "0x180534BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C70", Offset = "0x5D5C70", VA = "0x1805D6C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NMDLHPKEHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x534BD0", Offset = "0x533BD0", VA = "0x180534BD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x891AC0", Offset = "0x890AC0", VA = "0x180891AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type NPFBJFCOOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x511460", Offset = "0x510460", VA = "0x180511460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x62AB60", Offset = "0x629B60", VA = "0x18062AB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo PJHIHOJHNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo JMBLLCBFNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x511470", Offset = "0x510470", VA = "0x180511470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5359E0", Offset = "0x5349E0", VA = "0x1805359E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo DGKPLCELBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5107D0", Offset = "0x50F7D0", VA = "0x1805107D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x510850", Offset = "0x50F850", VA = "0x180510850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3106F10", Offset = "0x3105F10", VA = "0x183106F10")]
	protected DNCFKPNLFII(Type CIMKNKPILIM, string GDCCAEJAPNJ, string BCABPMGDDCN, bool BCKLBPBPNHI, bool FBMENPBJLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3106E00", Offset = "0x3105E00", VA = "0x183106E00")]
	public DNCFKPNLFII(FieldInfo IAPOEGMMNBD, string GDCCAEJAPNJ, bool GBKOMNCCLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3106F90", Offset = "0x3105F90", VA = "0x183106F90")]
	public DNCFKPNLFII(PropertyInfo IAPOEGMMNBD, string GDCCAEJAPNJ, bool GBKOMNCCLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3106C20", Offset = "0x3105C20", VA = "0x183106C20")]
	private static MethodInfo HBPGJNKMPDE(MemberInfo IAPOEGMMNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2633C10", Offset = "0x2632C10", VA = "0x182633C10")]
	public T NJFGEGOMFKJ<T>(bool CAOILEBONPP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3106B60", Offset = "0x3105B60", VA = "0x183106B60", Slot = "4")]
	public virtual void FIBLAFMMMJH(ILGenerator AKDHBNNIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3106D40", Offset = "0x3105D40", VA = "0x183106D40", Slot = "5")]
	public virtual void NHHFPOKOHNE(ILGenerator AKDHBNNIOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class JLGHBGLGLOG : DNCFKPNLFII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly string LOFDHFHCLPF;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x31F87E0", Offset = "0x31F77E0", VA = "0x1831F87E0")]
	public JLGHBGLGLOG(string GDCCAEJAPNJ, string LOFDHFHCLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x31F86D0", Offset = "0x31F76D0", VA = "0x1831F86D0", Slot = "4")]
	public override void FIBLAFMMMJH(ILGenerator AKDHBNNIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x31F8790", Offset = "0x31F7790", VA = "0x1831F8790", Slot = "5")]
	public override void NHHFPOKOHNE(ILGenerator AKDHBNNIOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class PNHALGKAKKM : DNCFKPNLFII
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly MethodInfo ALCNNNHKGDK;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly MethodInfo PLMDHIDLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	internal AJFGLIJBKHJ FFCPGKHPMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	internal AJFGLIJBKHJ CJPIEHAJBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	internal AJFGLIJBKHJ DOKNBPEPPJB;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x48F10C0", Offset = "0x48F00C0", VA = "0x1848F10C0")]
	public PNHALGKAKKM(string GDCCAEJAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x48F0B10", Offset = "0x48EFB10", VA = "0x1848F0B10", Slot = "4")]
	public override void FIBLAFMMMJH(ILGenerator AKDHBNNIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x48F0BD0", Offset = "0x48EFBD0", VA = "0x1848F0BD0", Slot = "5")]
	public override void NHHFPOKOHNE(ILGenerator AKDHBNNIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x48F0A00", Offset = "0x48EFA00", VA = "0x1848F0A00")]
	public void EDLLHCIEJCM(ILGenerator AKDHBNNIOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class JNEPBIOBLCD
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type NPFBJFCOOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AKJGNJCNJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7466B0", Offset = "0x7456B0", VA = "0x1807466B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7A9010", Offset = "0x7A8010", VA = "0x1807A9010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GKKNKEKOAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7A29F0", Offset = "0x7A19F0", VA = "0x1807A29F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7A9000", Offset = "0x7A8000", VA = "0x1807A9000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo JCOEPOJMNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DNCFKPNLFII[] AAHIMGNBGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x511460", Offset = "0x510460", VA = "0x180511460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x62AB60", Offset = "0x629B60", VA = "0x18062AB60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public DNCFKPNLFII[] PLIPHBMOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x31F8960", Offset = "0x31F7960", VA = "0x1831F8960")]
	public JNEPBIOBLCD(Type CIMKNKPILIM, Func<string, string> FILNJLLPGAP, bool GBKOMNCCLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x31F8890", Offset = "0x31F7890", VA = "0x1831F8890")]
	private static bool JHHHFBOBHCL(IEnumerator<ConstructorInfo> MEHAIHHEGCK, ref ConstructorInfo JBICOFLAPCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct JDFAKILMCCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public ulong BPJOKOPIHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public int KFHJIBPHHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x262B3B0", Offset = "0x262A3B0", VA = "0x18262B3B0")]
	public JDFAKILMCCG(ulong ICALFOKMFKA, int NPDKGFCGPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x31F7630", Offset = "0x31F6630", VA = "0x1831F7630")]
	public void OLFHMDOCKJO(ref JDFAKILMCCG AGELLNNPMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x31F74C0", Offset = "0x31F64C0", VA = "0x1831F74C0")]
	public static JDFAKILMCCG EFAMGGHOPMO(ref JDFAKILMCCG MGMKOCNNKKD, ref JDFAKILMCCG FFKAJGPOGIJ)
	{
		return default(JDFAKILMCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x31F74F0", Offset = "0x31F64F0", VA = "0x1831F74F0")]
	public void IAGLNCBFJAP(ref JDFAKILMCCG AGELLNNPMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x31F7580", Offset = "0x31F6580", VA = "0x1831F7580")]
	public static JDFAKILMCCG IOBKBHBKHBP(ref JDFAKILMCCG MGMKOCNNKKD, ref JDFAKILMCCG FFKAJGPOGIJ)
	{
		return default(JDFAKILMCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x31F7420", Offset = "0x31F6420", VA = "0x1831F7420")]
	public void BFCNJLEBIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x31F7460", Offset = "0x31F6460", VA = "0x1831F7460")]
	public static JDFAKILMCCG BFCNJLEBIGH(ref JDFAKILMCCG MGMKOCNNKKD)
	{
		return default(JDFAKILMCCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct LJICJNFNKEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public byte[] CGBPEHFCGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public int GDBLDPHBNNG;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x9A5AC0", Offset = "0x9A4AC0", VA = "0x1809A5AC0")]
	public LJICJNFNKEC(byte[] CGBPEHFCGMK, int BENEFKIJBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3202570", Offset = "0x3201570", VA = "0x183202570")]
	public void GOBPKEGLDEH(byte GKPLHBJICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x32023D0", Offset = "0x32013D0", VA = "0x1832023D0")]
	public void DAEMAEJLMKK(byte[] GKPLHBJICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3202330", Offset = "0x3201330", VA = "0x183202330")]
	public void COKIDLLODJF(byte[] GKPLHBJICIA, int BODBKIOPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3202280", Offset = "0x3201280", VA = "0x183202280")]
	public void COKIDLLODJF(byte[] GKPLHBJICIA, int ICBNMBILIBM, int BODBKIOPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x32025D0", Offset = "0x32015D0", VA = "0x1832025D0")]
	public void OMDPHMCMPCC(byte LEBLBLLCPPD, int MODLAKNNNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3202470", Offset = "0x3201470", VA = "0x183202470")]
	public void ELPOOFILLGF(string GKPLHBJICIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class BHCIHIFDINK
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum OBMOLGNIEPA
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum NJKLICONKKE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum NBKMINCMOKB
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	[ThreadStatic]
	private static byte[] FPEPPCGDIBM;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	[ThreadStatic]
	private static byte[] LDBAMNBAIEM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly byte[] FOJNFJLAOEF;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly byte[] ODNCECBILFI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly NBKMINCMOKB BALIFBEAFBI;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly char IACLCMGIGJA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly int AGIAHOHDHND;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly int AKFIIPPLMEF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly uint[] GKJDBMFEOPA;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x30F9C50", Offset = "0x30F8C50", VA = "0x1830F9C50")]
	private static byte[] IJJKBLKANNE(int ACFAACNMEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x30FAD90", Offset = "0x30F9D90", VA = "0x1830FAD90")]
	private static byte[] OBKKHJAHPFK(int ACFAACNMEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x30F9880", Offset = "0x30F8880", VA = "0x1830F9880")]
	public static int EPEPLCGBEBF(ref byte[] CGBPEHFCGMK, int GDBLDPHBNNG, float DDDOLDGEMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x30F9770", Offset = "0x30F8770", VA = "0x1830F9770")]
	public static int EPEPLCGBEBF(ref byte[] CGBPEHFCGMK, int GDBLDPHBNNG, double DDDOLDGEMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x30FA080", Offset = "0x30F9080", VA = "0x1830FA080")]
	private static bool MBLOICACONI(byte[] CGBPEHFCGMK, int BODBKIOPHHK, ulong FEOCNAENFHB, ulong KNPBHHIKHBD, ulong EBAKDFLNKCK, ulong KLCIIMCBKNJ, ulong NFPIBJEHGLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x30F9B30", Offset = "0x30F8B30", VA = "0x1830F9B30")]
	private static void FJPMFPNNIHB(uint KNBPHGEPPEH, int IBHGANIGMDO, out uint NGOCJMLHGEB, out int PNMJJHPAPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x30FA940", Offset = "0x30F9940", VA = "0x1830FA940")]
	private static bool MJOLFENFOME(JDFAKILMCCG BHGOPKOHCGL, JDFAKILMCCG IBKHPENJJPF, JDFAKILMCCG NMIAKLIBGOC, byte[] CGBPEHFCGMK, out int BODBKIOPHHK, out int GMBBPFIMKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x30F9E10", Offset = "0x30F8E10", VA = "0x1830F9E10")]
	private static bool LJEHLCPFLEP(double DPPCIFMDPOI, OBMOLGNIEPA MKIOPHCNOFJ, byte[] CGBPEHFCGMK, out int BODBKIOPHHK, out int OGEAIGHCBLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x30F9D20", Offset = "0x30F8D20", VA = "0x1830F9D20")]
	private static bool LABEFGACGCM(double DPPCIFMDPOI, OBMOLGNIEPA MKIOPHCNOFJ, byte[] CGBPEHFCGMK, out int BODBKIOPHHK, out int FKOGIFJDDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x30FA180", Offset = "0x30F9180", VA = "0x1830FA180")]
	private static bool MDMBEDIHDLA(double DDDOLDGEMNC, ref LJICJNFNKEC AIMNMCNAAKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x30FA310", Offset = "0x30F9310", VA = "0x1830FA310")]
	private static bool MHFAEBABCOO(double DDDOLDGEMNC, ref LJICJNFNKEC AIMNMCNAAKF, NJKLICONKKE MKIOPHCNOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x30FAE70", Offset = "0x30F9E70", VA = "0x1830FAE70")]
	private static void PEJLNANIEEE(byte[] LIBKBNJFMLM, int BODBKIOPHHK, int FKOGIFJDDCM, int GPMNNOIOJJI, ref LJICJNFNKEC AIMNMCNAAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x30F9480", Offset = "0x30F8480", VA = "0x1830F9480")]
	private static void DCINHNLAMJK(byte[] LIBKBNJFMLM, int BODBKIOPHHK, int NPDKGFCGPJL, ref LJICJNFNKEC AIMNMCNAAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x30F9990", Offset = "0x30F8990", VA = "0x1830F9990")]
	private static bool FEJLDDLBMBM(double DPPCIFMDPOI, NJKLICONKKE MKIOPHCNOFJ, int FLLHEGBGAHE, byte[] PCGPACFDHLI, out bool AKINLPMEIED, out int BODBKIOPHHK, out int AFJNCPHDIHA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct AMDMLPMMMCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public double LODPNNEBBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public ulong JAPCJPOJKEI;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct IIJMNMJNPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float BPJOKOPIHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public uint PHNIPLFIBCC;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct IGMJJPEPBDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private ulong OKMGCEOIAGO;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x120DC10", Offset = "0x120CC10", VA = "0x18120DC10")]
	public IGMJJPEPBDF(double LODPNNEBBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x31F4A70", Offset = "0x31F3A70", VA = "0x1831F4A70")]
	public IGMJJPEPBDF(JDFAKILMCCG LODPNNEBBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x31F44F0", Offset = "0x31F34F0", VA = "0x1831F44F0")]
	public JDFAKILMCCG CCMLDADGOOG()
	{
		return default(JDFAKILMCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x31F4950", Offset = "0x31F3950", VA = "0x1831F4950")]
	public JDFAKILMCCG MICPAAFJEDO()
	{
		return default(JDFAKILMCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5C1B60", Offset = "0x5C0B60", VA = "0x1805C1B60")]
	public ulong AFAGCEFBFFH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x31F4690", Offset = "0x31F3690", VA = "0x1831F4690")]
	public double FDLEIAHHCBA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x31F49E0", Offset = "0x31F39E0", VA = "0x1831F49E0")]
	public double MOFELNMGOBK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x31F4700", Offset = "0x31F3700", VA = "0x1831F4700")]
	public int FLFNCBLIMGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x31F4660", Offset = "0x31F3660", VA = "0x1831F4660")]
	public ulong FDDCOFJOGIC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x31F44D0", Offset = "0x31F34D0", VA = "0x1831F44D0")]
	public bool BLCPFBNNADM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x31F4590", Offset = "0x31F3590", VA = "0x1831F4590")]
	public bool CJLKOCBPEIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x31F45B0", Offset = "0x31F35B0", VA = "0x1831F45B0")]
	public bool DAHBGMCDDMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x31F4880", Offset = "0x31F3880", VA = "0x1831F4880")]
	public bool LGBMFMHBEDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x31F4570", Offset = "0x31F3570", VA = "0x1831F4570")]
	public int CDJJACCLOBK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x31F4730", Offset = "0x31F3730", VA = "0x1831F4730")]
	public void IBMIKADKGAG(out JDFAKILMCCG LDIJBIOPGIE, out JDFAKILMCCG MOGLMKJCCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x31F45F0", Offset = "0x31F35F0", VA = "0x1831F45F0")]
	public bool DKOFEBAPIJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x31F45E0", Offset = "0x31F35E0", VA = "0x1831F45E0")]
	public double DDDOLDGEMNC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x31F4640", Offset = "0x31F3640", VA = "0x1831F4640")]
	public static int EKCALBGGLNC(int MEIFKDOCNCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x31F4A60", Offset = "0x31F3A60", VA = "0x1831F4A60")]
	public static double NFKPGEGCHGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x31F48B0", Offset = "0x31F38B0", VA = "0x1831F48B0")]
	public static ulong LOLEJDCKHPF(JDFAKILMCCG FFOEAIAJJOC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct CAAFJDMACJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private uint CEFHPDOIIDH;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x50D480", Offset = "0x50C480", VA = "0x18050D480")]
	public CAAFJDMACJJ(float BPJOKOPIHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x30FCAD0", Offset = "0x30FBAD0", VA = "0x1830FCAD0")]
	public JDFAKILMCCG CCMLDADGOOG()
	{
		return default(JDFAKILMCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5C1BA0", Offset = "0x5C0BA0", VA = "0x1805C1BA0")]
	public uint PNEBKKCMOPC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x30FCBA0", Offset = "0x30FBBA0", VA = "0x1830FCBA0")]
	public int FLFNCBLIMGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x30FCB80", Offset = "0x30FBB80", VA = "0x1830FCB80")]
	public uint FDDCOFJOGIC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x30FCAC0", Offset = "0x30FBAC0", VA = "0x1830FCAC0")]
	public bool BLCPFBNNADM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x30FCBC0", Offset = "0x30FBBC0", VA = "0x1830FCBC0")]
	public void IBMIKADKGAG(out JDFAKILMCCG LDIJBIOPGIE, out JDFAKILMCCG MOGLMKJCCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x30FCB40", Offset = "0x30FBB40", VA = "0x1830FCB40")]
	public bool DKOFEBAPIJF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct LABGOOFFDNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly ulong ICALFOKMFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly short CFOHFKNFJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly short OGEAIGHCBLA;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x31FE3A0", Offset = "0x31FD3A0", VA = "0x1831FE3A0")]
	public LABGOOFFDNP(ulong ICALFOKMFKA, short CFOHFKNFJDO, short OGEAIGHCBLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class GPDDNEENPHA
{
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly LABGOOFFDNP[] OENPAJPEOEH;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x31F1200", Offset = "0x31F0200", VA = "0x1831F1200")]
	public static void PPLCODLFGLF(int JMLFKIHLFJM, int MBOFBPLJFID, out JDFAKILMCCG NGOCJMLHGEB, out int OGEAIGHCBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x31F1110", Offset = "0x31F0110", VA = "0x1831F1110")]
	public static void CLFIFABEICA(int LIGNLJOFHCN, out JDFAKILMCCG NGOCJMLHGEB, out int GIKBAHFNJNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DefaultMember("Item")]
internal struct BCOHMNKNNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public readonly byte[] CPFFKFOFBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly int ICBNMBILIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly int CBDEPMDBLDL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte LJBCNKJDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x30F93E0", Offset = "0x30F83E0", VA = "0x1830F93E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xC45F90", Offset = "0xC44F90", VA = "0x180C45F90")]
	public BCOHMNKNNNC(byte[] CPFFKFOFBAE, int ICBNMBILIBM, int BODBKIOPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x934300", Offset = "0x933300", VA = "0x180934300")]
	public int BODBKIOPHHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x30F9420", Offset = "0x30F8420", VA = "0x1830F9420")]
	public BCOHMNKNNNC CJJDKEHDLFL(int CPEMLOKBGKJ, int DBGINKFMOHH)
	{
		return default(BCOHMNKNNNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class LIJMECMIACE
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[ThreadStatic]
	private static byte[] LEFPJMFKMIN;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly double[] OPBFFFDJPAO;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly int LGPIEJBMEAJ;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3201FD0", Offset = "0x3200FD0", VA = "0x183201FD0")]
	private static byte[] PKFIEBPHGAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3201480", Offset = "0x3200480", VA = "0x183201480")]
	private static BCOHMNKNNNC KOMFCOGCGCM(BCOHMNKNNNC CGBPEHFCGMK)
	{
		return default(BCOHMNKNNNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3200D00", Offset = "0x31FFD00", VA = "0x183200D00")]
	private static BCOHMNKNNNC EJKCAMANDOP(BCOHMNKNNNC CGBPEHFCGMK)
	{
		return default(BCOHMNKNNNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x32013C0", Offset = "0x32003C0", VA = "0x1832013C0")]
	private static void JFHOAODMECO(BCOHMNKNNNC CGBPEHFCGMK, int NPDKGFCGPJL, byte[] FDFBGGLJBHC, out int ALGLHJBMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3201B80", Offset = "0x3200B80", VA = "0x183201B80")]
	private static void MKGCGDPAHMF(BCOHMNKNNNC CGBPEHFCGMK, int NPDKGFCGPJL, byte[] PFIMHNODPMP, int EPKJLODMDDJ, out BCOHMNKNNNC HCKJNAEPPAM, out int EKPBPJDLBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x32009E0", Offset = "0x31FF9E0", VA = "0x1832009E0")]
	private static ulong BOAHIILCMDL(BCOHMNKNNNC CGBPEHFCGMK, out int CFKOJPHIONO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3201290", Offset = "0x3200290", VA = "0x183201290")]
	private static void GICAEPHEJHL(BCOHMNKNNNC CGBPEHFCGMK, out JDFAKILMCCG EJBMJHIBKHH, out int DKFMMKMGLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3200EE0", Offset = "0x31FFEE0", VA = "0x183200EE0")]
	private static bool GCMILCHPMAE(BCOHMNKNNNC HCKJNAEPPAM, int NPDKGFCGPJL, out double EJBMJHIBKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3201E30", Offset = "0x3200E30", VA = "0x183201E30")]
	private static JDFAKILMCCG ONOLFPOJBDP(int NPDKGFCGPJL)
	{
		return default(JDFAKILMCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3201530", Offset = "0x3200530", VA = "0x183201530")]
	private static bool LEICJOPCELL(BCOHMNKNNNC CGBPEHFCGMK, int NPDKGFCGPJL, out double EJBMJHIBKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x32008B0", Offset = "0x31FF8B0", VA = "0x1832008B0")]
	private static bool BEFJNJBJLEK(BCOHMNKNNNC HCKJNAEPPAM, int NPDKGFCGPJL, out double NNDENFFJLIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3200DB0", Offset = "0x31FFDB0", VA = "0x183200DB0")]
	public static double? FBJPCKFFKCC(BCOHMNKNNNC CGBPEHFCGMK, int NPDKGFCGPJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3200A70", Offset = "0x31FFA70", VA = "0x183200A70")]
	public static float? DDJFHJPAIOB(BCOHMNKNNNC CGBPEHFCGMK, int NPDKGFCGPJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal struct FCCDAPLPDFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private byte[] CGBPEHFCGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int GDBLDPHBNNG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte DPFBMCEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3109B80", Offset = "0x3108B80", VA = "0x183109B80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x9A5AC0", Offset = "0x9A4AC0", VA = "0x1809A5AC0")]
	public FCCDAPLPDFP(byte[] CGBPEHFCGMK, int GDBLDPHBNNG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3109C40", Offset = "0x3108C40", VA = "0x183109C40")]
	public static FCCDAPLPDFP HBKIJKOLFGG(FCCDAPLPDFP ANALFBKHBBJ)
	{
		return default(FCCDAPLPDFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3109CF0", Offset = "0x3108CF0", VA = "0x183109CF0")]
	public static FCCDAPLPDFP PIFOIFMPBGG(FCCDAPLPDFP ANALFBKHBBJ, int BODBKIOPHHK)
	{
		return default(FCCDAPLPDFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3109C20", Offset = "0x3108C20", VA = "0x183109C20")]
	public static int GAPFHKLBLBE(FCCDAPLPDFP PAGIOBKBEJN, FCCDAPLPDFP CNMNKJHPLKO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3109C90", Offset = "0x3108C90", VA = "0x183109C90")]
	public static bool NCMLJHOADIP(FCCDAPLPDFP PAGIOBKBEJN, FCCDAPLPDFP CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3109BC0", Offset = "0x3108BC0", VA = "0x183109BC0")]
	public static bool EHGLIMAJFAD(FCCDAPLPDFP PAGIOBKBEJN, FCCDAPLPDFP CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x3109CB0", Offset = "0x3108CB0", VA = "0x183109CB0")]
	public static bool NCMLJHOADIP(FCCDAPLPDFP PAGIOBKBEJN, char CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x3109BE0", Offset = "0x3108BE0", VA = "0x183109BE0")]
	public static bool EHGLIMAJFAD(FCCDAPLPDFP PAGIOBKBEJN, char CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x3109BE0", Offset = "0x3108BE0", VA = "0x183109BE0")]
	public static bool EHGLIMAJFAD(FCCDAPLPDFP PAGIOBKBEJN, byte CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3109C50", Offset = "0x3108C50", VA = "0x183109C50")]
	public static bool KMPIEAGEMEP(FCCDAPLPDFP PAGIOBKBEJN, char CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3109B40", Offset = "0x3108B40", VA = "0x183109B40")]
	public static bool DFOMMFIJJEI(FCCDAPLPDFP PAGIOBKBEJN, char CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3109B00", Offset = "0x3108B00", VA = "0x183109B00")]
	public static bool AILIJCJEEFJ(FCCDAPLPDFP PAGIOBKBEJN, char CNMNKJHPLKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x3109AC0", Offset = "0x3108AC0", VA = "0x183109AC0")]
	public static bool AFMBAKGENKF(FCCDAPLPDFP PAGIOBKBEJN, char CNMNKJHPLKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class POJJHDKGHPF
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] CLFBAJECLJN;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[ThreadStatic]
	private static byte[] NFLHOFDKDPO;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly byte[] FOJNFJLAOEF;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly byte[] ODNCECBILFI;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly byte[] KGCBOGJHJOK;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly int GBINHNJANCL;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ushort[] AOKFFFMAGFL;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int FCDNPLOEFHH;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x48F2860", Offset = "0x48F1860", VA = "0x1848F2860")]
	private static byte[] OKIEKLHFIAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x48F1270", Offset = "0x48F0270", VA = "0x1848F1270")]
	private static byte[] BHHIGDEEHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x48F2680", Offset = "0x48F1680", VA = "0x1848F2680")]
	public static double JOJBDEJHGKI(byte[] CGBPEHFCGMK, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x48F2570", Offset = "0x48F1570", VA = "0x1848F2570")]
	public static float EGHCHKAGMLP(byte[] CGBPEHFCGMK, int GDBLDPHBNNG, out int BBAANCHALDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x48F1350", Offset = "0x48F0350", VA = "0x1848F1350")]
	private static bool BPCABIMEOPM(int LLFMGCPPNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x48F2740", Offset = "0x48F1740", VA = "0x1848F2740")]
	private static bool NMCCEBEHKHJ(ref FCCDAPLPDFP LLOCKBJAIDL, FCCDAPLPDFP MBPMMGMNCKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x48F1160", Offset = "0x48F0160", VA = "0x1848F1160")]
	private static bool APFELKKEOFB(ref FCCDAPLPDFP LLOCKBJAIDL, FCCDAPLPDFP MBPMMGMNCKG, byte[] MNBNIAGALOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x48F2630", Offset = "0x48F1630", VA = "0x1848F2630")]
	private static bool JCHBEDKMNEJ(ref FCCDAPLPDFP FGCNIMDIJKN, byte[] GKPLHBJICIA, int GDBLDPHBNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x695B80", Offset = "0x694B80", VA = "0x180695B80")]
	private static double MKCNHGIJNAJ(bool AKINLPMEIED)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x48F14D0", Offset = "0x48F04D0", VA = "0x1848F14D0")]
	private static double DJNFNIBCNFL(FCCDAPLPDFP LIJNLLHNKOK, int BODBKIOPHHK, bool BMALGKEHMKP, out int FMGDBHDLHFP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class BIPBNILHJPC<T> : global::EMIGBNLKFFH<T[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly global::MGNCLHEBDOI<T> BIBAIBAJLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly FPIANENKGOK OCNKMOJFPIH;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x23516F0", Offset = "0x23506F0", VA = "0x1823516F0")]
	public BIPBNILHJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x224D7F0", Offset = "0x224C7F0", VA = "0x18224D7F0")]
	public BIPBNILHJPC(FPIANENKGOK OCNKMOJFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x25F6100", Offset = "0x25F5100", VA = "0x1825F6100", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, T[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x25F3AD0", Offset = "0x25F2AD0", VA = "0x1825F3AD0", Slot = "5")]
	public T[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class DAPMCPIMNLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly global::MGNCLHEBDOI<T> BIBAIBAJLDG;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class AILIPPILJMI<T> : global::EMIGBNLKFFH<List<T>>, EMHLBACENGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly FPIANENKGOK OCNKMOJFPIH;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x23516F0", Offset = "0x23506F0", VA = "0x1823516F0")]
	public AILIPPILJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x224D7F0", Offset = "0x224C7F0", VA = "0x18224D7F0")]
	public AILIPPILJMI(FPIANENKGOK OCNKMOJFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2350A30", Offset = "0x234FA30", VA = "0x182350A30", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, List<T> DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2350860", Offset = "0x234F860", VA = "0x182350860", Slot = "5")]
	public List<T> GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class IGDCBCKLGAL<TElement, TIntermediate, TEnumerator, TCollection> : global::EMIGBNLKFFH<TCollection>, EMHLBACENGL where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3830", Offset = "0x3CD2830", VA = "0x183CD3830", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, TCollection DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2F70", Offset = "0x3CD1F70", VA = "0x183CD2F70", Slot = "5")]
	public TCollection GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EFPHONCBLPD(TCollection NELCGJMDLMG);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DMLCAMHGJAD();

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ONGBLFOLDCH(ref TIntermediate HFLPEDDONFH, int IDCLMAKCIEP, TElement DDDOLDGEMNC);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection FAMKCJJIIKA(ref TIntermediate EDOOOJHDBCF);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
	protected IGDCBCKLGAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class HNFMNIJNENB<TElement, TIntermediate, TCollection> : global::IGDCBCKLGAL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF720", Offset = "0x2DFE720", VA = "0x182DFF720", Slot = "6")]
	protected override IEnumerator<TElement> EFPHONCBLPD(TCollection NELCGJMDLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x23CA990", Offset = "0x23C9990", VA = "0x1823CA990")]
	protected HNFMNIJNENB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class LPGBHAMPCAP<TElement, TCollection> : global::HNFMNIJNENB<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected sealed override TCollection FAMKCJJIIKA(ref TCollection EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class MOPCDEFJPKC<TElement, TCollection> : global::LPGBHAMPCAP<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF850", Offset = "0x2DFE850", VA = "0x182DFF850", Slot = "7")]
	protected override TCollection DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF870", Offset = "0x2DFE870", VA = "0x182DFF870", Slot = "8")]
	protected override void ONGBLFOLDCH(ref TCollection HFLPEDDONFH, int IDCLMAKCIEP, TElement DDDOLDGEMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class FIIJMHLAHED<T> : global::IGDCBCKLGAL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2440850", Offset = "0x243F850", VA = "0x182440850", Slot = "8")]
	protected override void ONGBLFOLDCH(ref LinkedList<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override LinkedList<T> FAMKCJJIIKA(ref LinkedList<T> EDOOOJHDBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override LinkedList<T> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x364ECB0", Offset = "0x364DCB0", VA = "0x18364ECB0", Slot = "6")]
	protected override LinkedList<T>.Enumerator EFPHONCBLPD(LinkedList<T> NELCGJMDLMG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MDEBPOMFDNB<T> : global::IGDCBCKLGAL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2440850", Offset = "0x243F850", VA = "0x182440850", Slot = "8")]
	protected override void ONGBLFOLDCH(ref Queue<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override Queue<T> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2440800", Offset = "0x243F800", VA = "0x182440800", Slot = "6")]
	protected override Queue<T>.Enumerator EFPHONCBLPD(Queue<T> NELCGJMDLMG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override Queue<T> FAMKCJJIIKA(ref Queue<T> EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class ELFEDDDIEEI<T> : global::IGDCBCKLGAL<T, global::HCDPEECIPLN<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x25A51F0", Offset = "0x25A41F0", VA = "0x1825A51F0", Slot = "8")]
	protected override void ONGBLFOLDCH(ref global::HCDPEECIPLN<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x25A50C0", Offset = "0x25A40C0", VA = "0x1825A50C0", Slot = "7")]
	protected override global::HCDPEECIPLN<T> DMLCAMHGJAD()
	{
		return default(global::HCDPEECIPLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2440800", Offset = "0x243F800", VA = "0x182440800", Slot = "6")]
	protected override Stack<T>.Enumerator EFPHONCBLPD(Stack<T> NELCGJMDLMG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x25A5110", Offset = "0x25A4110", VA = "0x1825A5110", Slot = "9")]
	protected override Stack<T> FAMKCJJIIKA(ref global::HCDPEECIPLN<T> EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class NCLGIKCIBKH<T> : global::IGDCBCKLGAL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2440850", Offset = "0x243F850", VA = "0x182440850", Slot = "8")]
	protected override void ONGBLFOLDCH(ref HashSet<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override HashSet<T> FAMKCJJIIKA(ref HashSet<T> EDOOOJHDBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override HashSet<T> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2440800", Offset = "0x243F800", VA = "0x182440800", Slot = "6")]
	protected override HashSet<T>.Enumerator EFPHONCBLPD(HashSet<T> NELCGJMDLMG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MONDFJNLFBM<T> : global::HNFMNIJNENB<T, global::HCDPEECIPLN<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x25A51F0", Offset = "0x25A41F0", VA = "0x1825A51F0", Slot = "8")]
	protected override void ONGBLFOLDCH(ref global::HCDPEECIPLN<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF7C0", Offset = "0x2DFE7C0", VA = "0x182DFF7C0", Slot = "9")]
	protected override ReadOnlyCollection<T> FAMKCJJIIKA(ref global::HCDPEECIPLN<T> EDOOOJHDBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF770", Offset = "0x2DFE770", VA = "0x182DFF770", Slot = "7")]
	protected override global::HCDPEECIPLN<T> DMLCAMHGJAD()
	{
		return default(global::HCDPEECIPLN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class ENNINGPDMPM<T> : global::HNFMNIJNENB<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2440850", Offset = "0x243F850", VA = "0x182440850", Slot = "8")]
	protected override void ONGBLFOLDCH(ref List<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override List<T> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override IList<T> FAMKCJJIIKA(ref List<T> EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class KJJHFCELBPB<T> : global::HNFMNIJNENB<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2440850", Offset = "0x243F850", VA = "0x182440850", Slot = "8")]
	protected override void ONGBLFOLDCH(ref List<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override List<T> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override ICollection<T> FAMKCJJIIKA(ref List<T> EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class LOFFIKOCPKB<T> : global::HNFMNIJNENB<T, global::HCDPEECIPLN<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x25A51F0", Offset = "0x25A41F0", VA = "0x1825A51F0", Slot = "8")]
	protected override void ONGBLFOLDCH(ref global::HCDPEECIPLN<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x25A50C0", Offset = "0x25A40C0", VA = "0x1825A50C0", Slot = "7")]
	protected override global::HCDPEECIPLN<T> DMLCAMHGJAD()
	{
		return default(global::HCDPEECIPLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3D85070", Offset = "0x3D84070", VA = "0x183D85070", Slot = "9")]
	protected override IEnumerable<T> FAMKCJJIIKA(ref global::HCDPEECIPLN<T> EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class HNMKDJBNHIP<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class KFIAGKGPONJ<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class NMJCFCPNBBK<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class APJKEJOLPCL : global::EMIGBNLKFFH<IEnumerable>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly global::EMIGBNLKFFH<IEnumerable> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x30F8B70", Offset = "0x30F7B70", VA = "0x1830F8B70", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, IEnumerable DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x30F89F0", Offset = "0x30F79F0", VA = "0x1830F89F0", Slot = "5")]
	public IEnumerable GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public APJKEJOLPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class LDPBGNACLJH : global::EMIGBNLKFFH<ICollection>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly global::EMIGBNLKFFH<ICollection> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3200020", Offset = "0x31FF020", VA = "0x183200020", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ICollection DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x31FFEA0", Offset = "0x31FEEA0", VA = "0x1831FFEA0", Slot = "5")]
	public ICollection GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public LDPBGNACLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KFGJNEIKMBD : global::EMIGBNLKFFH<IList>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public static readonly global::EMIGBNLKFFH<IList> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x31FA510", Offset = "0x31F9510", VA = "0x1831FA510", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, IList DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x31FA390", Offset = "0x31F9390", VA = "0x1831FA390", Slot = "5")]
	public IList GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public KFGJNEIKMBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OOOJFBLIADA<T> : global::HNFMNIJNENB<T, global::HCDPEECIPLN<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x366F560", Offset = "0x366E560", VA = "0x18366F560", Slot = "8")]
	protected override void ONGBLFOLDCH(ref global::HCDPEECIPLN<T> HFLPEDDONFH, int IDCLMAKCIEP, T DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x25A50C0", Offset = "0x25A40C0", VA = "0x1825A50C0", Slot = "7")]
	protected override global::HCDPEECIPLN<T> DMLCAMHGJAD()
	{
		return default(global::HCDPEECIPLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x366F520", Offset = "0x366E520", VA = "0x18366F520", Slot = "9")]
	protected override IReadOnlyList<T> FAMKCJJIIKA(ref global::HCDPEECIPLN<T> EDOOOJHDBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2252CE0", Offset = "0x2251CE0", VA = "0x182252CE0")]
	public OOOJFBLIADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class DHMOMGBDCDP
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x31060D0", Offset = "0x31050D0", VA = "0x1831060D0")]
	public static DateTime MPFPEFINALK(DateTime CGINKCNPEHD)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KHPJABDNEEB : global::EMIGBNLKFFH<DateTime>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly global::EMIGBNLKFFH<DateTime> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x31FD700", Offset = "0x31FC700", VA = "0x1831FD700", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, DateTime DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x31FC800", Offset = "0x31FB800", VA = "0x1831FC800", Slot = "5")]
	public DateTime GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public KHPJABDNEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class JAMNDJNCINH : global::EMIGBNLKFFH<DateTimeOffset>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly global::EMIGBNLKFFH<DateTimeOffset> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x31F6D90", Offset = "0x31F5D90", VA = "0x1831F6D90", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, DateTimeOffset DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x31F5DF0", Offset = "0x31F4DF0", VA = "0x1831F5DF0", Slot = "5")]
	public DateTimeOffset GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JAMNDJNCINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OBMAGMGFIEC : global::EMIGBNLKFFH<TimeSpan>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::EMIGBNLKFFH<TimeSpan> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static byte[] BNJFBLAJIPF;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x48E5050", Offset = "0x48E4050", VA = "0x1848E5050", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, TimeSpan DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x48E47B0", Offset = "0x48E37B0", VA = "0x1848E47B0", Slot = "5")]
	public TimeSpan GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public OBMAGMGFIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class NNBOBHHNECB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::EMIGBNLKFFH<TDictionary>, EMHLBACENGL where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x32D3FC0", Offset = "0x32D2FC0", VA = "0x1832D3FC0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, TDictionary DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x32D3620", Offset = "0x32D2620", VA = "0x1832D3620", Slot = "5")]
	public TDictionary GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EFPHONCBLPD(TDictionary NELCGJMDLMG);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DMLCAMHGJAD();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ONGBLFOLDCH(ref TIntermediate HFLPEDDONFH, int IDCLMAKCIEP, TKey MNGGKJHHPNI, TValue DDDOLDGEMNC);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary FAMKCJJIIKA(ref TIntermediate EDOOOJHDBCF);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
	protected NNBOBHHNECB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class MOLJFMNLAML<TKey, TValue, TIntermediate, TDictionary> : global::NNBOBHHNECB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF720", Offset = "0x2DFE720", VA = "0x182DFF720", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EFPHONCBLPD(TDictionary NELCGJMDLMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class OHAMOIHPKDM<TKey, TValue, TDictionary> : global::MOLJFMNLAML<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override TDictionary FAMKCJJIIKA(ref TDictionary EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class CBGBKHLIANG<TKey, TValue> : global::NNBOBHHNECB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x364ED10", Offset = "0x364DD10", VA = "0x18364ED10", Slot = "8")]
	protected override void ONGBLFOLDCH(ref Dictionary<TKey, TValue> HFLPEDDONFH, int IDCLMAKCIEP, TKey MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override Dictionary<TKey, TValue> FAMKCJJIIKA(ref Dictionary<TKey, TValue> EDOOOJHDBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x364EC60", Offset = "0x364DC60", VA = "0x18364EC60", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EFPHONCBLPD(Dictionary<TKey, TValue> NELCGJMDLMG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2255DA0", Offset = "0x2254DA0", VA = "0x182255DA0")]
	public CBGBKHLIANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class NEALHIGAJFB<TKey, TValue, TDictionary> : global::OHAMOIHPKDM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x3040390", Offset = "0x303F390", VA = "0x183040390", Slot = "8")]
	protected override void ONGBLFOLDCH(ref TDictionary HFLPEDDONFH, int IDCLMAKCIEP, TKey MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3040370", Offset = "0x303F370", VA = "0x183040370", Slot = "7")]
	protected override TDictionary DMLCAMHGJAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class AODJNKJCLNM<TKey, TValue> : global::MOLJFMNLAML<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2508B50", Offset = "0x2507B50", VA = "0x182508B50", Slot = "8")]
	protected override void ONGBLFOLDCH(ref Dictionary<TKey, TValue> HFLPEDDONFH, int IDCLMAKCIEP, TKey MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override IDictionary<TKey, TValue> FAMKCJJIIKA(ref Dictionary<TKey, TValue> EDOOOJHDBCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class DEGAEJIBMEN<TKey, TValue> : global::OHAMOIHPKDM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2508B50", Offset = "0x2507B50", VA = "0x182508B50", Slot = "8")]
	protected override void ONGBLFOLDCH(ref SortedList<TKey, TValue> HFLPEDDONFH, int IDCLMAKCIEP, TKey MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override SortedList<TKey, TValue> DMLCAMHGJAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JKCFHPFBNFH<TKey, TValue> : global::NNBOBHHNECB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2508B50", Offset = "0x2507B50", VA = "0x182508B50", Slot = "8")]
	protected override void ONGBLFOLDCH(ref SortedDictionary<TKey, TValue> HFLPEDDONFH, int IDCLMAKCIEP, TKey MNGGKJHHPNI, TValue DDDOLDGEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x13A4E00", Offset = "0x13A3E00", VA = "0x1813A4E00", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> FAMKCJJIIKA(ref SortedDictionary<TKey, TValue> EDOOOJHDBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x24407A0", Offset = "0x243F7A0", VA = "0x1824407A0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DMLCAMHGJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2508AF0", Offset = "0x2507AF0", VA = "0x182508AF0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EFPHONCBLPD(SortedDictionary<TKey, TValue> NELCGJMDLMG)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class JPLIBJOJCAM<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class HJPJHLNFBDJ : global::EMIGBNLKFFH<IDictionary>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::EMIGBNLKFFH<IDictionary> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x31F3FC0", Offset = "0x31F2FC0", VA = "0x1831F3FC0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, IDictionary DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x31F3E20", Offset = "0x31F2E20", VA = "0x1831F3E20", Slot = "5")]
	public IDictionary GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public HJPJHLNFBDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class MKKEEDMAPNF : global::EMIGBNLKFFH<object>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private delegate void JNFMEFKHIJK(object NMJJNAMBCEP, ref PJHNLAIFAEP DJLDOCIGJKE, object DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly global::KKKLMDJJKMB<KeyValuePair<object, JNFMEFKHIJK>> OANCAOLDKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly ENKIFIDJGCB[] ALAGBGGACKK;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3203F70", Offset = "0x3202F70", VA = "0x183203F70")]
	public MKKEEDMAPNF(params ENKIFIDJGCB[] ALAGBGGACKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x3203680", Offset = "0x3202680", VA = "0x183203680", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, object DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x32035F0", Offset = "0x32025F0", VA = "0x1832035F0", Slot = "5")]
	public object GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class HDLBDMKNPNI
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x31F3230", Offset = "0x31F2230", VA = "0x1831F3230")]
	public static object NIGGIHBPONN(Type CIMKNKPILIM, out bool IDDNPHLDGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x31F2A50", Offset = "0x31F1A50", VA = "0x1831F2A50")]
	public static object IPFJMNFBFDF(Type CIMKNKPILIM, out bool IDDNPHLDGLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class BOLHMACGOKN<T> : global::EMIGBNLKFFH<T>, EMHLBACENGL, global::CGIHMAABHKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class EHBABIPKCAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public EHBABIPKCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x388ABC0", Offset = "0x3889BC0", VA = "0x18388ABC0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class CDGBMBNIPJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public global::ILIIDJGDKHO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public CDGBMBNIPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3886E50", Offset = "0x3885E50", VA = "0x183886E50")]
		internal void <.cctor>b__1(ref PJHNLAIFAEP writer, T value, ENKIFIDJGCB _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class EDELIHCGEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public global::PLJCPGEJMGC<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public EDELIHCGEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3889F70", Offset = "0x3888F70", VA = "0x183889F70")]
		internal T <.cctor>b__2(ref PGEJMHBNANP reader, ENKIFIDJGCB _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly global::NHAKACDFENC<T> GDCIKFOPBPB;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly Dictionary<T, string> IPKPAGFGACD;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly global::ILIIDJGDKHO<T> BGLNDAPLEAA;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly global::PLJCPGEJMGC<T> NKCHCIFJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private readonly bool KIGEPHNCKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly global::ILIIDJGDKHO<T> EMAINMOJHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly global::PLJCPGEJMGC<T> CKNJOCAHJMO;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x387A170", Offset = "0x3879170", VA = "0x18387A170")]
	static BOLHMACGOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2B4FF70", Offset = "0x2B4EF70", VA = "0x182B4FF70")]
	public BOLHMACGOKN(bool KIGEPHNCKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3878560", Offset = "0x3877560", VA = "0x183878560", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, T DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3877000", Offset = "0x3876000", VA = "0x183877000", Slot = "5")]
	public T GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2B3BF30", Offset = "0x2B3AF30", VA = "0x182B3BF30", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, T DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3874460", Offset = "0x3873460", VA = "0x183874460", Slot = "7")]
	public T CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class PCHJGMHINNC<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class HHNGFHBFKPA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class PAJKKHPHICG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class GLILEIBDPAE<T> : global::EMIGBNLKFFH<T?>, EMHLBACENGL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x32AFBE0", Offset = "0x32AEBE0", VA = "0x1832AFBE0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, T? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x32AF7B0", Offset = "0x32AE7B0", VA = "0x1832AF7B0", Slot = "5")]
	public T? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
	public GLILEIBDPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class CNFIPOOJOPB<T> : global::EMIGBNLKFFH<T?>, EMHLBACENGL where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::EMIGBNLKFFH<T> PJOMFMLEFJN;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x234AEB0", Offset = "0x2349EB0", VA = "0x18234AEB0")]
	public CNFIPOOJOPB(global::EMIGBNLKFFH<T> PJOMFMLEFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2A75A80", Offset = "0x2A74A80", VA = "0x182A75A80", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, T? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2A74810", Offset = "0x2A73810", VA = "0x182A74810", Slot = "5")]
	public T? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PPFDGFJCJIM : global::EMIGBNLKFFH<sbyte>, EMHLBACENGL, global::CGIHMAABHKC<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly PPFDGFJCJIM CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x48F2CE0", Offset = "0x48F1CE0", VA = "0x1848F2CE0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, sbyte DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x48F2BD0", Offset = "0x48F1BD0", VA = "0x1848F2BD0", Slot = "5")]
	public sbyte GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x48F2C20", Offset = "0x48F1C20", VA = "0x1848F2C20", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, sbyte DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x48F2B30", Offset = "0x48F1B30", VA = "0x1848F2B30", Slot = "7")]
	public sbyte CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public PPFDGFJCJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class KJKALBHCHIK : global::EMIGBNLKFFH<sbyte?>, EMHLBACENGL, global::CGIHMAABHKC<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly KJKALBHCHIK CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x31FE070", Offset = "0x31FD070", VA = "0x1831FE070", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, sbyte? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x31FDF80", Offset = "0x31FCF80", VA = "0x1831FDF80", Slot = "5")]
	public sbyte? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x31FDFF0", Offset = "0x31FCFF0", VA = "0x1831FDFF0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, sbyte? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x31FDED0", Offset = "0x31FCED0", VA = "0x1831FDED0", Slot = "7")]
	public sbyte? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public KJKALBHCHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class AKENJFLEBJC : global::EMIGBNLKFFH<sbyte[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly AKENJFLEBJC CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x30F82A0", Offset = "0x30F72A0", VA = "0x1830F82A0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, sbyte[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x30F8160", Offset = "0x30F7160", VA = "0x1830F8160", Slot = "5")]
	public sbyte[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public AKENJFLEBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HJOALAAOHPO : global::EMIGBNLKFFH<short>, EMHLBACENGL, global::CGIHMAABHKC<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly HJOALAAOHPO CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x31F3DA0", Offset = "0x31F2DA0", VA = "0x1831F3DA0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, short DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x31F3D50", Offset = "0x31F2D50", VA = "0x1831F3D50", Slot = "5")]
	public short GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x31F3D60", Offset = "0x31F2D60", VA = "0x1831F3D60", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, short DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x31F3CE0", Offset = "0x31F2CE0", VA = "0x1831F3CE0", Slot = "7")]
	public short CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public HJOALAAOHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class JGHNDNOOFMJ : global::EMIGBNLKFFH<short?>, EMHLBACENGL, global::CGIHMAABHKC<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly JGHNDNOOFMJ CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x31F78E0", Offset = "0x31F68E0", VA = "0x1831F78E0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, short? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x31F77F0", Offset = "0x31F67F0", VA = "0x1831F77F0", Slot = "5")]
	public short? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x31F7860", Offset = "0x31F6860", VA = "0x1831F7860", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, short? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x31F7750", Offset = "0x31F6750", VA = "0x1831F7750", Slot = "7")]
	public short? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JGHNDNOOFMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GPKANAENLHA : global::EMIGBNLKFFH<short[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GPKANAENLHA CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x31F2930", Offset = "0x31F1930", VA = "0x1831F2930", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, short[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x31F27F0", Offset = "0x31F17F0", VA = "0x1831F27F0", Slot = "5")]
	public short[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public GPKANAENLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HNPMNAADADA : global::EMIGBNLKFFH<int>, EMHLBACENGL, global::CGIHMAABHKC<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly HNPMNAADADA CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x31F4460", Offset = "0x31F3460", VA = "0x1831F4460", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, int DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x31F4410", Offset = "0x31F3410", VA = "0x1831F4410", Slot = "5")]
	public int GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x31F4420", Offset = "0x31F3420", VA = "0x1831F4420", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, int DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x31F43A0", Offset = "0x31F33A0", VA = "0x1831F43A0", Slot = "7")]
	public int CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public HNPMNAADADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CIKIOOIMNPF : global::EMIGBNLKFFH<int?>, EMHLBACENGL, global::CGIHMAABHKC<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly CIKIOOIMNPF CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x30FDA00", Offset = "0x30FCA00", VA = "0x1830FDA00", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, int? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x30FD910", Offset = "0x30FC910", VA = "0x1830FD910", Slot = "5")]
	public int? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x30FD980", Offset = "0x30FC980", VA = "0x1830FD980", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, int? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x30FD870", Offset = "0x30FC870", VA = "0x1830FD870", Slot = "7")]
	public int? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public CIKIOOIMNPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class EFNLCNDFGNC : global::EMIGBNLKFFH<int[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly EFNLCNDFGNC CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3109320", Offset = "0x3108320", VA = "0x183109320", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, int[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x31091E0", Offset = "0x31081E0", VA = "0x1831091E0", Slot = "5")]
	public int[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public EFNLCNDFGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CKJACCKKDDG : global::EMIGBNLKFFH<long>, EMHLBACENGL, global::CGIHMAABHKC<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly CKJACCKKDDG CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x30FDB90", Offset = "0x30FCB90", VA = "0x1830FDB90", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, long DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x30FDB40", Offset = "0x30FCB40", VA = "0x1830FDB40", Slot = "5")]
	public long GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x30FDB50", Offset = "0x30FCB50", VA = "0x1830FDB50", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, long DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x30FDAD0", Offset = "0x30FCAD0", VA = "0x1830FDAD0", Slot = "7")]
	public long CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public CKJACCKKDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class COFODOPCDEA : global::EMIGBNLKFFH<long?>, EMHLBACENGL, global::CGIHMAABHKC<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly COFODOPCDEA CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x30FDED0", Offset = "0x30FCED0", VA = "0x1830FDED0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, long? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x30FDDC0", Offset = "0x30FCDC0", VA = "0x1830FDDC0", Slot = "5")]
	public long? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x30FDE50", Offset = "0x30FCE50", VA = "0x1830FDE50", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, long? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x30FDD00", Offset = "0x30FCD00", VA = "0x1830FDD00", Slot = "7")]
	public long? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public COFODOPCDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class KNFNKMNAIFO : global::EMIGBNLKFFH<long[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly KNFNKMNAIFO CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x31FE280", Offset = "0x31FD280", VA = "0x1831FE280", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, long[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x31FE140", Offset = "0x31FD140", VA = "0x1831FE140", Slot = "5")]
	public long[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public KNFNKMNAIFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class IKPBMACFCCH : global::EMIGBNLKFFH<byte>, EMHLBACENGL, global::CGIHMAABHKC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly IKPBMACFCCH CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x31F51E0", Offset = "0x31F41E0", VA = "0x1831F51E0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, byte DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x31F5190", Offset = "0x31F4190", VA = "0x1831F5190", Slot = "5")]
	public byte GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x31F51A0", Offset = "0x31F41A0", VA = "0x1831F51A0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, byte DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x31F5120", Offset = "0x31F4120", VA = "0x1831F5120", Slot = "7")]
	public byte CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public IKPBMACFCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class KHFJOBMGKEN : global::EMIGBNLKFFH<byte?>, EMHLBACENGL, global::CGIHMAABHKC<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly KHFJOBMGKEN CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x31FA9B0", Offset = "0x31F99B0", VA = "0x1831FA9B0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, byte? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x31FA8C0", Offset = "0x31F98C0", VA = "0x1831FA8C0", Slot = "5")]
	public byte? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x31FA930", Offset = "0x31F9930", VA = "0x1831FA930", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, byte? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x31FA810", Offset = "0x31F9810", VA = "0x1831FA810", Slot = "7")]
	public byte? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public KHFJOBMGKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class HIEAJCEOPCI : global::EMIGBNLKFFH<ushort>, EMHLBACENGL, global::CGIHMAABHKC<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly HIEAJCEOPCI CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x31F3C60", Offset = "0x31F2C60", VA = "0x1831F3C60", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ushort DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x31F3C10", Offset = "0x31F2C10", VA = "0x1831F3C10", Slot = "5")]
	public ushort GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x31F3C20", Offset = "0x31F2C20", VA = "0x1831F3C20", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, ushort DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x31F3BA0", Offset = "0x31F2BA0", VA = "0x1831F3BA0", Slot = "7")]
	public ushort CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public HIEAJCEOPCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class LHDPAOFEGDN : global::EMIGBNLKFFH<ushort?>, EMHLBACENGL, global::CGIHMAABHKC<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly LHDPAOFEGDN CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x32006A0", Offset = "0x31FF6A0", VA = "0x1832006A0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ushort? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x32005B0", Offset = "0x31FF5B0", VA = "0x1832005B0", Slot = "5")]
	public ushort? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3200620", Offset = "0x31FF620", VA = "0x183200620", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, ushort? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3200510", Offset = "0x31FF510", VA = "0x183200510", Slot = "7")]
	public ushort? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public LHDPAOFEGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class MGDLJJKFNFF : global::EMIGBNLKFFH<ushort[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly MGDLJJKFNFF CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x3203270", Offset = "0x3202270", VA = "0x183203270", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ushort[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3203130", Offset = "0x3202130", VA = "0x183203130", Slot = "5")]
	public ushort[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public MGDLJJKFNFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class DLMGIOJFCFL : global::EMIGBNLKFFH<uint>, EMHLBACENGL, global::CGIHMAABHKC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly DLMGIOJFCFL CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x31065E0", Offset = "0x31055E0", VA = "0x1831065E0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, uint DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3106590", Offset = "0x3105590", VA = "0x183106590", Slot = "5")]
	public uint GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x31065A0", Offset = "0x31055A0", VA = "0x1831065A0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, uint DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3106520", Offset = "0x3105520", VA = "0x183106520", Slot = "7")]
	public uint CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLMGIOJFCFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class JCJDIIIHHLH : global::EMIGBNLKFFH<uint?>, EMHLBACENGL, global::CGIHMAABHKC<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly JCJDIIIHHLH CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x31F7350", Offset = "0x31F6350", VA = "0x1831F7350", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, uint? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x31F7260", Offset = "0x31F6260", VA = "0x1831F7260", Slot = "5")]
	public uint? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x31F72D0", Offset = "0x31F62D0", VA = "0x1831F72D0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, uint? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x31F71C0", Offset = "0x31F61C0", VA = "0x1831F71C0", Slot = "7")]
	public uint? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JCJDIIIHHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class EKFFLLDPPGH : global::EMIGBNLKFFH<uint[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly EKFFLLDPPGH CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x3109580", Offset = "0x3108580", VA = "0x183109580", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, uint[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3109440", Offset = "0x3108440", VA = "0x183109440", Slot = "5")]
	public uint[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public EKFFLLDPPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class JPAHFHKMEEJ : global::EMIGBNLKFFH<ulong>, EMHLBACENGL, global::CGIHMAABHKC<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly JPAHFHKMEEJ CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x31F9DB0", Offset = "0x31F8DB0", VA = "0x1831F9DB0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ulong DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x31F9D60", Offset = "0x31F8D60", VA = "0x1831F9D60", Slot = "5")]
	public ulong GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x31F9D70", Offset = "0x31F8D70", VA = "0x1831F9D70", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, ulong DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x31F9CF0", Offset = "0x31F8CF0", VA = "0x1831F9CF0", Slot = "7")]
	public ulong CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JPAHFHKMEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class PMKPJPBEICH : global::EMIGBNLKFFH<ulong?>, EMHLBACENGL, global::CGIHMAABHKC<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly PMKPJPBEICH CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x48F0920", Offset = "0x48EF920", VA = "0x1848F0920", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ulong? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x48F0790", Offset = "0x48EF790", VA = "0x1848F0790", Slot = "5")]
	public ulong? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x48F0820", Offset = "0x48EF820", VA = "0x1848F0820", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, ulong? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x48F06D0", Offset = "0x48EF6D0", VA = "0x1848F06D0", Slot = "7")]
	public ulong? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public PMKPJPBEICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class IIOHACBELFG : global::EMIGBNLKFFH<ulong[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IIOHACBELFG CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x31F4C50", Offset = "0x31F3C50", VA = "0x1831F4C50", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ulong[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x31F4B10", Offset = "0x31F3B10", VA = "0x1831F4B10", Slot = "5")]
	public ulong[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public IIOHACBELFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class JPDLFFPHAHD : global::EMIGBNLKFFH<float>, EMHLBACENGL, global::CGIHMAABHKC<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JPDLFFPHAHD CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x31F9EF0", Offset = "0x31F8EF0", VA = "0x1831F9EF0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, float DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x31F9EA0", Offset = "0x31F8EA0", VA = "0x1831F9EA0", Slot = "5")]
	public float GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x31F9EB0", Offset = "0x31F8EB0", VA = "0x1831F9EB0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, float DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x31F9E30", Offset = "0x31F8E30", VA = "0x1831F9E30", Slot = "7")]
	public float CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JPDLFFPHAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class FFBLBNBPEIL : global::EMIGBNLKFFH<float?>, EMHLBACENGL, global::CGIHMAABHKC<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FFBLBNBPEIL CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3109EE0", Offset = "0x3108EE0", VA = "0x183109EE0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, float? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3109DF0", Offset = "0x3108DF0", VA = "0x183109DF0", Slot = "5")]
	public float? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3109E60", Offset = "0x3108E60", VA = "0x183109E60", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, float? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3109D50", Offset = "0x3108D50", VA = "0x183109D50", Slot = "7")]
	public float? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public FFBLBNBPEIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CHOFNDGCOAF : global::EMIGBNLKFFH<float[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly CHOFNDGCOAF CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x30FD750", Offset = "0x30FC750", VA = "0x1830FD750", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, float[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x30FD610", Offset = "0x30FC610", VA = "0x1830FD610", Slot = "5")]
	public float[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public CHOFNDGCOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class OEHBFPMHIFP : global::EMIGBNLKFFH<double>, EMHLBACENGL, global::CGIHMAABHKC<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly OEHBFPMHIFP CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x48E5780", Offset = "0x48E4780", VA = "0x1848E5780", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, double DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x48E56C0", Offset = "0x48E46C0", VA = "0x1848E56C0", Slot = "5")]
	public double GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x48E56D0", Offset = "0x48E46D0", VA = "0x1848E56D0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, double DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x48E5620", Offset = "0x48E4620", VA = "0x1848E5620", Slot = "7")]
	public double CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public OEHBFPMHIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class JGHONJDAGKG : global::EMIGBNLKFFH<double?>, EMHLBACENGL, global::CGIHMAABHKC<double?>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly JGHONJDAGKG CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x31F7B80", Offset = "0x31F6B80", VA = "0x1831F7B80", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, double? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x31F7A70", Offset = "0x31F6A70", VA = "0x1831F7A70", Slot = "5")]
	public double? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x31F7B00", Offset = "0x31F6B00", VA = "0x1831F7B00", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, double? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x31F79B0", Offset = "0x31F69B0", VA = "0x1831F79B0", Slot = "7")]
	public double? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JGHONJDAGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class MKBEPEGMGGH : global::EMIGBNLKFFH<double[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly MKBEPEGMGGH CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x32034D0", Offset = "0x32024D0", VA = "0x1832034D0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, double[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3203390", Offset = "0x3202390", VA = "0x183203390", Slot = "5")]
	public double[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public MKBEPEGMGGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class LHEDKPHOCPJ : global::EMIGBNLKFFH<bool>, EMHLBACENGL, global::CGIHMAABHKC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly LHEDKPHOCPJ CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3200830", Offset = "0x31FF830", VA = "0x183200830", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, bool DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x32007E0", Offset = "0x31FF7E0", VA = "0x1832007E0", Slot = "5")]
	public bool GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x32007F0", Offset = "0x31FF7F0", VA = "0x1832007F0", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, bool DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x3200770", Offset = "0x31FF770", VA = "0x183200770", Slot = "7")]
	public bool CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public LHEDKPHOCPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class PDKLIMGHGEA : global::EMIGBNLKFFH<bool?>, EMHLBACENGL, global::CGIHMAABHKC<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly PDKLIMGHGEA CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x48EB4F0", Offset = "0x48EA4F0", VA = "0x1848EB4F0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, bool? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x48EB390", Offset = "0x48EA390", VA = "0x1848EB390", Slot = "5")]
	public bool? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x48EB400", Offset = "0x48EA400", VA = "0x1848EB400", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, bool? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x48EB2E0", Offset = "0x48EA2E0", VA = "0x1848EB2E0", Slot = "7")]
	public bool? CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public PDKLIMGHGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class JHJBEINGFNC : global::EMIGBNLKFFH<bool[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly JHJBEINGFNC CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x31F7F10", Offset = "0x31F6F10", VA = "0x1831F7F10", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, bool[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x31F7DD0", Offset = "0x31F6DD0", VA = "0x1831F7DD0", Slot = "5")]
	public bool[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JHJBEINGFNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class PHMBCLNCGDJ : global::EMIGBNLKFFH<object>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly global::EMIGBNLKFFH<object> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly Dictionary<Type, int> MPPHHFBOOGH;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x48EE650", Offset = "0x48ED650", VA = "0x1848EE650", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, object DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x48EE2F0", Offset = "0x48ED2F0", VA = "0x1848EE2F0", Slot = "5")]
	public object GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public PHMBCLNCGDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class GKALEJICAHC : global::EMIGBNLKFFH<byte[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly global::EMIGBNLKFFH<byte[]> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x31F0EA0", Offset = "0x31EFEA0", VA = "0x1831F0EA0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, byte[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x31F0E20", Offset = "0x31EFE20", VA = "0x1831F0E20", Slot = "5")]
	public byte[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public GKALEJICAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class LNEJKNFMDFO : global::EMIGBNLKFFH<ArraySegment<byte>>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly global::EMIGBNLKFFH<ArraySegment<byte>> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3202720", Offset = "0x3201720", VA = "0x183202720", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, ArraySegment<byte> DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3202650", Offset = "0x3201650", VA = "0x183202650", Slot = "5")]
	public ArraySegment<byte> GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public LNEJKNFMDFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class GLMIGBCNNAJ : global::EMIGBNLKFFH<string>, EMHLBACENGL, global::CGIHMAABHKC<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly global::EMIGBNLKFFH<string> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x31F1090", Offset = "0x31F0090", VA = "0x1831F1090", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, string DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x31F1080", Offset = "0x31F0080", VA = "0x1831F1080", Slot = "5")]
	public string GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x31F1090", Offset = "0x31F0090", VA = "0x1831F1090", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, string DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x31F1080", Offset = "0x31F0080", VA = "0x1831F1080", Slot = "7")]
	public string CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public GLMIGBCNNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class JPNMCMPIAOD : global::EMIGBNLKFFH<string[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly JPNMCMPIAOD CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x31FA0A0", Offset = "0x31F90A0", VA = "0x1831FA0A0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, string[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x31F9F60", Offset = "0x31F8F60", VA = "0x1831F9F60", Slot = "5")]
	public string[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JPNMCMPIAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class JEKCAOPMNIE : global::EMIGBNLKFFH<char>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly JEKCAOPMNIE CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x31F7670", Offset = "0x31F6670", VA = "0x1831F7670", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, char DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x31F7640", Offset = "0x31F6640", VA = "0x1831F7640", Slot = "5")]
	public char GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public JEKCAOPMNIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class GHNGIADJCKH : global::EMIGBNLKFFH<char?>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly GHNGIADJCKH CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x310B150", Offset = "0x310A150", VA = "0x18310B150", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, char? DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x310B090", Offset = "0x310A090", VA = "0x18310B090", Slot = "5")]
	public char? GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public GHNGIADJCKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class CBKPEIOKBIL : global::EMIGBNLKFFH<char[]>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly CBKPEIOKBIL CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x30FD010", Offset = "0x30FC010", VA = "0x1830FD010", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, char[] DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x30FCE70", Offset = "0x30FBE70", VA = "0x1830FCE70", Slot = "5")]
	public char[] GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public CBKPEIOKBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class ALAFIPMIMMG : global::EMIGBNLKFFH<Guid>, EMHLBACENGL, global::CGIHMAABHKC<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::EMIGBNLKFFH<Guid> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x30F8640", Offset = "0x30F7640", VA = "0x1830F8640", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Guid DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x30F8500", Offset = "0x30F7500", VA = "0x1830F8500", Slot = "5")]
	public Guid GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x30F8560", Offset = "0x30F7560", VA = "0x1830F8560", Slot = "6")]
	public void JDMPOOIBMIM(ref PJHNLAIFAEP DJLDOCIGJKE, Guid DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x30F8500", Offset = "0x30F7500", VA = "0x1830F8500", Slot = "7")]
	public Guid CHNKNAJPNGD(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public ALAFIPMIMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class PBPIJGKAJIN : global::EMIGBNLKFFH<decimal>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::EMIGBNLKFFH<decimal> CJPEENBFOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly bool JCJHDNEMPFH;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xF28C30", Offset = "0xF27C30", VA = "0x180F28C30")]
	public PBPIJGKAJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xBD0DD0", Offset = "0xBCFDD0", VA = "0x180BD0DD0")]
	public PBPIJGKAJIN(bool JCJHDNEMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x48EADF0", Offset = "0x48E9DF0", VA = "0x1848EADF0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, decimal DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x48EAC40", Offset = "0x48E9C40", VA = "0x1848EAC40", Slot = "5")]
	public decimal GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class HGOKOOALFAJ : global::EMIGBNLKFFH<Uri>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::EMIGBNLKFFH<Uri> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x31F3A90", Offset = "0x31F2A90", VA = "0x1831F3A90", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Uri DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x31F3A10", Offset = "0x31F2A10", VA = "0x1831F3A10", Slot = "5")]
	public Uri GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public HGOKOOALFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class OKMBOEAMGPH : global::EMIGBNLKFFH<Version>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::EMIGBNLKFFH<Version> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x48E5870", Offset = "0x48E4870", VA = "0x1848E5870", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Version DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x48E57F0", Offset = "0x48E47F0", VA = "0x1848E57F0", Slot = "5")]
	public Version GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public OKMBOEAMGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CIAAFIENOFP<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class NHJBPOOGCIL : global::EMIGBNLKFFH<StringBuilder>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::EMIGBNLKFFH<StringBuilder> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x48E4630", Offset = "0x48E3630", VA = "0x1848E4630", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, StringBuilder DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x48E45B0", Offset = "0x48E35B0", VA = "0x1848E45B0", Slot = "5")]
	public StringBuilder GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public NHJBPOOGCIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class PDFGJPOPCCB : global::EMIGBNLKFFH<BitArray>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::EMIGBNLKFFH<BitArray> CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x48EB180", Offset = "0x48EA180", VA = "0x1848EB180", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, BitArray DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x48EB020", Offset = "0x48EA020", VA = "0x1848EB020", Slot = "5")]
	public BitArray GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public PDFGJPOPCCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class KJCKBKGHFCL : global::EMIGBNLKFFH<Type>, EMHLBACENGL
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly KJCKBKGHFCL CJPEENBFOMB;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly Regex DLAJDCFDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private bool IBLFHPCGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private bool KBPJJIEOOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private bool BMPAEMPNKAN;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x31FDE60", Offset = "0x31FCE60", VA = "0x1831FDE60")]
	public KJCKBKGHFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x31FDE80", Offset = "0x31FCE80", VA = "0x1831FDE80")]
	public KJCKBKGHFCL(bool IBLFHPCGCHC, bool KBPJJIEOOHF, bool BMPAEMPNKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x31FDCD0", Offset = "0x31FCCD0", VA = "0x1831FDCD0", Slot = "4")]
	public void PKICNBNNKCI(ref PJHNLAIFAEP DJLDOCIGJKE, Type DDDOLDGEMNC, ENKIFIDJGCB BOCFNFPOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x31FDBB0", Offset = "0x31FCBB0", VA = "0x1831FDBB0", Slot = "5")]
	public Type GJAEFJLDMHL(ref PGEJMHBNANP ACDBGHLODNH, ENKIFIDJGCB BOCFNFPOMFH)
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
