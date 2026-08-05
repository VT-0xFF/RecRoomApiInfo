using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
internal static class IFJOENKEGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63A8AF0", Offset = "0x63A7EF0", VA = "0x1863A8AF0")]
	public static bool HFJDLBLDJEH(this TypeInfo IJFAMCPOKBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class KAOPGMAKDAO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FDNGDPKBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] CEMIOHIHCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
	public KAOPGMAKDAO(Type ILNJJHMLCEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class FJEBELFPKFN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LGLADCNGEAE<T>(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T KOGAFGLOCED<T>(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP HJGPHCCBOKK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BJHFEJJJBKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ALMAJBDDDKL<T> : BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOAAGFNPBME<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JGJCFEAGLOM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HHNHEJAGDMJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23A8370", Offset = "0x23A7770", VA = "0x1823A8370")]
	public static string MINHCOJEJPE<T>(this ALMAJBDDDKL<T> GFIPKNJGPFF, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALMAJBDDDKL<T> GKKNHIGKACB<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BBCEADADDDE
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x219A450", Offset = "0x2199850", VA = "0x18219A450")]
	public static ALMAJBDDDKL<T> PGHPDAPDCHD<T>(this NGDHCEEFPJP HJGPHCCBOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6393630", Offset = "0x6392A30", VA = "0x186393630")]
	public static object NFHNJOKEOMJ(this NGDHCEEFPJP HJGPHCCBOKK, Type IJFAMCPOKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HJNEOCEOIOO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63A8990", Offset = "0x63A7D90", VA = "0x1863A8990")]
	public HJNEOCEOIOO(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GCKCGBHPHKM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class GPDJKIOJJNG
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] FNCIFBBDALE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CJGGNOMMBBG;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63A8000", Offset = "0x63A7400", VA = "0x1863A8000")]
		public static byte[] MEGHMMOIPCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63A7F60", Offset = "0x63A7360", VA = "0x1863A7F60")]
		public static char[] KMFOCMGIECP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GLDEECOOOFA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] GNNGGCLADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] HPOLMACFBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int APBJNEFOGOC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool EKPFPHMAICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x639C620", Offset = "0x639BA20", VA = "0x18639C620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x639F930", Offset = "0x639ED30", VA = "0x18639F930")]
	public GCKCGBHPHKM(byte[] HPOLMACFBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x639F7D0", Offset = "0x639EBD0", VA = "0x18639F7D0")]
	public GCKCGBHPHKM(byte[] HPOLMACFBHD, int APBJNEFOGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x639CAC0", Offset = "0x639BEC0", VA = "0x18639CAC0")]
	private BAKLKIJKLJP CIOHOBMEPFB(string OCDLGNNMKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x639DF80", Offset = "0x639D380", VA = "0x18639DF80")]
	private BAKLKIJKLJP EKNHMDIHKNH(string NJKPBIBMIJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x639BC90", Offset = "0x639B090", VA = "0x18639BC90")]
	public void KACAOLBMOCL(int APBJNEFOGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public byte[] NNLHJJCCFNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0")]
	public int EONBNHCBEDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x639EE30", Offset = "0x639E230", VA = "0x18639EE30")]
	public KBHFLFLDBKE LCMAKCHKEGO()
	{
		return default(KBHFLFLDBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x639F070", Offset = "0x639E470", VA = "0x18639F070")]
	public void LKLPEKDCPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x639E9A0", Offset = "0x639DDA0", VA = "0x18639E9A0")]
	public bool KFLOJOEIHLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x639C590", Offset = "0x639B990", VA = "0x18639C590")]
	public bool BHBDMIAFFEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x639D400", Offset = "0x639C800", VA = "0x18639D400")]
	public void DKPGEOKFOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x639DCB0", Offset = "0x639D0B0", VA = "0x18639DCB0")]
	public bool EAJNOIBKGLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x639E780", Offset = "0x639DB80", VA = "0x18639E780")]
	public bool IGFAHGEEPPD(int OGEHFGGOGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x639DEB0", Offset = "0x639D2B0", VA = "0x18639DEB0")]
	public bool EHOHCFOLNNL(int OGEHFGGOGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x639EFE0", Offset = "0x639E3E0", VA = "0x18639EFE0")]
	public bool LDPOHHFFCCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x639E1B0", Offset = "0x639D5B0", VA = "0x18639E1B0")]
	public void GGIBECGOHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x639D250", Offset = "0x639C650", VA = "0x18639D250")]
	public bool DGICNDNONAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x639F1A0", Offset = "0x639E5A0", VA = "0x18639F1A0")]
	public bool MBPJOPCGKKP(int OGEHFGGOGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x639EC80", Offset = "0x639E080", VA = "0x18639EC80")]
	public bool KNLGCJIAGDD(int OGEHFGGOGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x639CA30", Offset = "0x639BE30", VA = "0x18639CA30")]
	public bool CDKMDEIPHGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x639F590", Offset = "0x639E990", VA = "0x18639F590")]
	public void PMBAEAMMONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x639C500", Offset = "0x639B900", VA = "0x18639C500")]
	public bool AODNABGNKAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x639E850", Offset = "0x639DC50", VA = "0x18639E850")]
	public void JEGFMJNAOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x639D510", Offset = "0x639C910", VA = "0x18639D510")]
	private void DOMNHNEIMLK([Out] byte[] EBGAEMPLOMJ, [Out] int LNHGFIEOOPK, [Out] int OJOMAOPEADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x639E8F0", Offset = "0x639DCF0", VA = "0x18639E8F0")]
	private static int JKLGOBCNGAO(char IFAOGMEBPFN, char DNPBOPMFFFF, char AGEAOGKCCKA, char EGKDMEOOPIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x639C950", Offset = "0x639BD50", VA = "0x18639C950")]
	private static int CAEIMLHKKGC(char MHJJOHHKIPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x639D2E0", Offset = "0x639C6E0", VA = "0x18639D2E0")]
	public ArraySegment<byte> DHLACLCEEOH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x639ED50", Offset = "0x639E150", VA = "0x18639ED50")]
	public string LBMNODKDLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x639E140", Offset = "0x639D540", VA = "0x18639E140")]
	public string GGFKAAOEFFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x639F370", Offset = "0x639E770", VA = "0x18639F370")]
	public ArraySegment<byte> OPEGDAJJOLN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x639D4A0", Offset = "0x639C8A0", VA = "0x18639D4A0")]
	public ArraySegment<byte> DLHMLIOALDP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x639C640", Offset = "0x639BA40", VA = "0x18639C640")]
	public bool BPIDEBPOLIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x639D090", Offset = "0x639C490", VA = "0x18639D090")]
	private static bool CLJMLCGGBAK(byte AGEAOGKCCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x639E4B0", Offset = "0x639D8B0", VA = "0x18639E4B0")]
	private void HMAAMFOOPAC(KBHFLFLDBKE KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x639E070", Offset = "0x639D470", VA = "0x18639E070")]
	public void EPGNDHDJCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x639E350", Offset = "0x639D750", VA = "0x18639E350")]
	private void HKNPACBLMGL(int PCBIHDPIOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x639E0C0", Offset = "0x639D4C0", VA = "0x18639E0C0")]
	public sbyte FLDGDMJICDB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x639E250", Offset = "0x639D650", VA = "0x18639E250")]
	public short GODEHDEOIFB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x639F630", Offset = "0x639EA30", VA = "0x18639F630")]
	public int POLCAIHMPMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x639C890", Offset = "0x639BC90", VA = "0x18639C890")]
	public long BPPEHHNGDGL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x639E2D0", Offset = "0x639D6D0", VA = "0x18639E2D0")]
	public byte HJHAPDLAEBE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x639D010", Offset = "0x639C410", VA = "0x18639D010")]
	public ushort CKCIADPFPCE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x639E700", Offset = "0x639DB00", VA = "0x18639E700")]
	public uint IFOHAPOFJOM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x639EBC0", Offset = "0x639DFC0", VA = "0x18639EBC0")]
	public ulong KMBOPGLGAMP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x639EAC0", Offset = "0x639DEC0", VA = "0x18639EAC0")]
	public float KKBLBHEGAPF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x639F270", Offset = "0x639E670", VA = "0x18639F270")]
	public double OODHPOCOICC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x639D150", Offset = "0x639C550", VA = "0x18639D150")]
	public ArraySegment<byte> DBHNLEGCILP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x639DD40", Offset = "0x639D140", VA = "0x18639DD40")]
	private static int EGKEPMONJCN(byte[] HPOLMACFBHD, int APBJNEFOGOC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BAKLKIJKLJP : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference DNMLBPOOOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PKLHJKIIMMN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DHODODFJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAE61D0", Offset = "0xAE55D0", VA = "0x180AE61D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IFGEAOPLLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89FD50", Offset = "0x89F150", VA = "0x18089FD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63935D0", Offset = "0x63929D0", VA = "0x1863935D0")]
	public BAKLKIJKLJP(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63934E0", Offset = "0x63928E0", VA = "0x1863934E0")]
	public BAKLKIJKLJP(string NJKPBIBMIJE, byte[] NOEFFOJLKBM, int APBJNEFOGOC, int PKLHJKIIMMN, string MDBFFMIDBKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JOPNNNFEIBO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class JGFGNMECJID
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] FNCIFBBDALE;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63A9300", Offset = "0x63A8700", VA = "0x1863A9300")]
		public static byte[] MEGHMMOIPCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HBKCJJIABOG
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void DBNJEKKHNPP(GBOIADKFEIJ MKIOBJMIBCN, object EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object FOGHHOCBCHD(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP HJGPHCCBOKK);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class OJLBGMJOKFK
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class JMLAAJOJDGN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
				public JMLAAJOJDGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x4AD6AA0", Offset = "0x4AD5EA0", VA = "0x184AD6AA0")]
				internal bool MBPNGCDHHKN(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x63A9C00", Offset = "0x63A9000", VA = "0x1863A9C00")]
				internal bool OJEEPHNGHIH(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, NGDHCEEFPJP, byte[]> PCDLEAPNIIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, NGDHCEEFPJP> OBJHAOKJELF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly DBNJEKKHNPP GMCEBJNJKLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, NGDHCEEFPJP, ArraySegment<byte>> PJAMDCMIAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, NGDHCEEFPJP, string> EFJLFMCGOBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, NGDHCEEFPJP, object> ACEBHNGKANA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, NGDHCEEFPJP, object> PAFDMNPDBKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, NGDHCEEFPJP, object> GAEDDJPLDJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly FOGHHOCBCHD DDPMMKIJJPM;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x63AE700", Offset = "0x63ADB00", VA = "0x1863AE700")]
			public OJLBGMJOKFK(Type IJFAMCPOKBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x299B670", Offset = "0x299AA70", VA = "0x18299B670")]
			private static T NCBBCLEFENO<T>(DynamicMethod BINGGGEEJIO)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x63AE4B0", Offset = "0x63AD8B0", VA = "0x1863AE4B0")]
			private static MethodInfo LNANIBINEEH(Type IJFAMCPOKBO, string LFAIHEECJFK, Type[] KDGOMLIACOO)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, OJLBGMJOKFK> MHLDFPIFNGE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly EKAKOJENCJB<OJLBGMJOKFK> GDGEMAECFFC;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63A83B0", Offset = "0x63A77B0", VA = "0x1863A83B0")]
		static HBKCJJIABOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63A80A0", Offset = "0x63A74A0", VA = "0x1863A80A0")]
		private static OJLBGMJOKFK ANLNKPLCCHM(Type IJFAMCPOKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63A8120", Offset = "0x63A7520", VA = "0x1863A8120")]
		public static void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, object EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63A82A0", Offset = "0x63A76A0", VA = "0x1863A82A0")]
		public static void PJNKBIHCNDA(Type IJFAMCPOKBO, GBOIADKFEIJ MKIOBJMIBCN, object EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static NGDHCEEFPJP IKMHKNGDAAM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] IMAOPBDIBNK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] PKDLNKADLCG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NGDHCEEFPJP KHFFCGFIJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63AAC30", Offset = "0x63AA030", VA = "0x1863AAC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MDIKGCAGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63AA7A0", Offset = "0x63A9BA0", VA = "0x1863AA7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x63A9DC0", Offset = "0x63A91C0", VA = "0x1863A9DC0")]
	public static void CIHGLEAEEBE(NGDHCEEFPJP HJGPHCCBOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2400530", Offset = "0x23FF930", VA = "0x182400530")]
	public static byte[] PJNKBIHCNDA<T>(T BAFDGKKJJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2400690", Offset = "0x23FFA90", VA = "0x182400690")]
	public static byte[] PJNKBIHCNDA<T>(T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24009E0", Offset = "0x23FFDE0", VA = "0x1824009E0")]
	public static void PJNKBIHCNDA<T>(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24005B0", Offset = "0x23FF9B0", VA = "0x1824005B0")]
	public static void PJNKBIHCNDA<T>(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2400950", Offset = "0x23FFD50", VA = "0x182400950")]
	public static void PJNKBIHCNDA<T>(Stream FMJIOIIBMEH, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2400810", Offset = "0x23FFC10", VA = "0x182400810")]
	public static void PJNKBIHCNDA<T>(Stream FMJIOIIBMEH, T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24004A0", Offset = "0x23FF8A0", VA = "0x1824004A0")]
	public static ArraySegment<byte> PDEKOBAKIEC<T>(T BAFDGKKJJJD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2400310", Offset = "0x23FF710", VA = "0x182400310")]
	public static ArraySegment<byte> PDEKOBAKIEC<T>(T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23FEC50", Offset = "0x23FE050", VA = "0x1823FEC50")]
	public static string MINHCOJEJPE<T>(T EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23FECD0", Offset = "0x23FE0D0", VA = "0x1823FECD0")]
	public static string MINHCOJEJPE<T>(T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23FF9A0", Offset = "0x23FEDA0", VA = "0x1823FF9A0")]
	public static T ONLENKPGCBM<T>(string DDBHCMCIDIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23FFAC0", Offset = "0x23FEEC0", VA = "0x1823FFAC0")]
	public static T ONLENKPGCBM<T>(string DDBHCMCIDIL, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2400290", Offset = "0x23FF690", VA = "0x182400290")]
	public static T ONLENKPGCBM<T>(byte[] HPOLMACFBHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23FFA30", Offset = "0x23FEE30", VA = "0x1823FFA30")]
	public static T ONLENKPGCBM<T>(byte[] HPOLMACFBHD, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23FFD80", Offset = "0x23FF180", VA = "0x1823FFD80")]
	public static T ONLENKPGCBM<T>(byte[] HPOLMACFBHD, int APBJNEFOGOC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23FF810", Offset = "0x23FEC10", VA = "0x1823FF810")]
	public static T ONLENKPGCBM<T>(byte[] HPOLMACFBHD, int APBJNEFOGOC, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23FFC80", Offset = "0x23FF080", VA = "0x1823FFC80")]
	public static T ONLENKPGCBM<T>(GCKCGBHPHKM IOJEJAFBOHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23FFBB0", Offset = "0x23FEFB0", VA = "0x1823FFBB0")]
	public static T ONLENKPGCBM<T>(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2400050", Offset = "0x23FF450", VA = "0x182400050")]
	public static T ONLENKPGCBM<T>(Stream FMJIOIIBMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2400150", Offset = "0x23FF550", VA = "0x182400150")]
	public static T ONLENKPGCBM<T>(Stream FMJIOIIBMEH, NGDHCEEFPJP HJGPHCCBOKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x63AAAD0", Offset = "0x63A9ED0", VA = "0x1863AAAD0")]
	public static string JJEMAJBBICD(byte[] DDBHCMCIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x63AA990", Offset = "0x63A9D90", VA = "0x1863AA990")]
	public static string JJEMAJBBICD(byte[] DDBHCMCIDIL, int APBJNEFOGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63AA800", Offset = "0x63A9C00", VA = "0x1863AA800")]
	public static string JJEMAJBBICD(string DDBHCMCIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63AB030", Offset = "0x63AA430", VA = "0x1863AB030")]
	public static byte[] PAACGMBJNCK(byte[] DDBHCMCIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x63AAD30", Offset = "0x63AA130", VA = "0x1863AAD30")]
	public static byte[] PAACGMBJNCK(byte[] DDBHCMCIDIL, int APBJNEFOGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63AAE80", Offset = "0x63AA280", VA = "0x1863AAE80")]
	public static byte[] PAACGMBJNCK(string DDBHCMCIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63A9ED0", Offset = "0x63A92D0", VA = "0x1863A9ED0")]
	private static void FPLKHIHHJFJ(GCKCGBHPHKM IOJEJAFBOHN, GBOIADKFEIJ MKIOBJMIBCN, int MOLHCHBGJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x63A9E30", Offset = "0x63A9230", VA = "0x1863A9E30")]
	private static int DHMFDMAOGKL(Stream CEPHEIEJHPL, byte[] FNCIFBBDALE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum KBHFLFLDBKE : byte
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GBOIADKFEIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] CECPJBNCKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] FNCIFBBDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int APBJNEFOGOC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IMBDMMHEADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x639BC90", Offset = "0x639B090", VA = "0x18639BC90")]
	public void KACAOLBMOCL(int APBJNEFOGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x639B840", Offset = "0x639AC40", VA = "0x18639B840")]
	public static byte[] HFKFCOMKHCB(string IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x639BCA0", Offset = "0x639B0A0", VA = "0x18639BCA0")]
	public static byte[] LNBHKBBDLKA(string IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x639C140", Offset = "0x639B540", VA = "0x18639C140")]
	public static byte[] PICGCNBNNNE(string IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x639C2B0", Offset = "0x639B6B0", VA = "0x18639C2B0")]
	public static byte[] PNDEKPHBLJA(string IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x520CDB0", Offset = "0x520C1B0", VA = "0x18520CDB0")]
	public GBOIADKFEIJ(byte[] KCOCFDAANKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x639BE10", Offset = "0x639B210", VA = "0x18639BE10")]
	public ArraySegment<byte> MEGHMMOIPCA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x639B7A0", Offset = "0x639ABA0", VA = "0x18639B7A0")]
	public byte[] HBLELGBCEFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x639C430", Offset = "0x639B830", VA = "0x18639C430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x639B790", Offset = "0x639AB90", VA = "0x18639B790")]
	public void GLMPNOFHEEJ(int LJBPGAIGCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x639B730", Offset = "0x639AB30", VA = "0x18639B730")]
	public void GKFJBAHGPLI(byte IEKBNKJJJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x639B6D0", Offset = "0x639AAD0", VA = "0x18639B6D0")]
	public void GKFJBAHGPLI(byte[] IEKBNKJJJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x639BA80", Offset = "0x639AE80", VA = "0x18639BA80")]
	public void IINPMOIGEGK(byte IEKBNKJJJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x639BF70", Offset = "0x639B370", VA = "0x18639BF70")]
	public void NLELLODKCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x639B540", Offset = "0x639A940", VA = "0x18639B540")]
	public void FHMGCJKBKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x639BEB0", Offset = "0x639B2B0", VA = "0x18639BEB0")]
	public void MPEOKEHNLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x639B3A0", Offset = "0x639A7A0", VA = "0x18639B3A0")]
	public void DDAOFLPFKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x639B470", Offset = "0x639A870", VA = "0x18639B470")]
	public void ELMMLDABOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x639B4F0", Offset = "0x639A8F0", VA = "0x18639B4F0")]
	public void FGBIKDHDJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x639B970", Offset = "0x639AD70", VA = "0x18639B970")]
	public void HOKNAKNDKDD(string IHPCGCBJCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x639B600", Offset = "0x639AA00", VA = "0x18639B600")]
	public void FLNDLJDMLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x639C0A0", Offset = "0x639B4A0", VA = "0x18639C0A0")]
	public void PFBIDDKDPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x639BB30", Offset = "0x639AF30", VA = "0x18639BB30")]
	public void JPOLEMNJBNA(bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x639B650", Offset = "0x639AA50", VA = "0x18639B650")]
	public void GCOALFPLIMM(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x639B3F0", Offset = "0x639A7F0", VA = "0x18639B3F0")]
	public void EJFOKHLKFBB(double EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x639C030", Offset = "0x639B430", VA = "0x18639C030")]
	public void OHNPJDACAAC(byte EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x639BA10", Offset = "0x639AE10", VA = "0x18639BA10")]
	public void IDGIOCKLAPC(ushort EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x639BF00", Offset = "0x639B300", VA = "0x18639BF00")]
	public void NIGIOKMBCCD(uint EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x639B4C0", Offset = "0x639A8C0", VA = "0x18639B4C0")]
	public void FFLDKOGJEFN(ulong EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x639B590", Offset = "0x639A990", VA = "0x18639B590")]
	public void FIMPBMBKIMN(sbyte EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x639BFC0", Offset = "0x639B3C0", VA = "0x18639BFC0")]
	public void ODFOBCFMPPI(short EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x639BAC0", Offset = "0x639AEC0", VA = "0x18639BAC0")]
	public void IKKAKNKLHJP(int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x639B810", Offset = "0x639AC10", VA = "0x18639B810")]
	public void HCONLAMOBIL(long EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x639B010", Offset = "0x639A410", VA = "0x18639B010")]
	public void AFLPHDCNJKD(string EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EHLANPAGKAC : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class KELBALBHDKD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x38C7660", Offset = "0x38C6A60", VA = "0x1838C7660")]
		static KELBALBHDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private EHLANPAGKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class NEJNLPMALBK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> PMBCLFDNBJF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63ACAD0", Offset = "0x63ABED0", VA = "0x1863ACAD0")]
	static NEJNLPMALBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63AC2E0", Offset = "0x63AB6E0", VA = "0x1863AC2E0")]
	internal static object GKKNHIGKACB(Type PDOICOFDEIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class FLDCGLNNHBG : ALMAJBDDDKL<Vector2>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x639AE30", Offset = "0x639A230", VA = "0x18639AE30")]
	public FLDCGLNNHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x639AC40", Offset = "0x639A040", VA = "0x18639AC40", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Vector2 EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x639A950", Offset = "0x6399D50", VA = "0x18639A950", Slot = "5")]
	public Vector2 ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class JIGPEIHGPDE : ALMAJBDDDKL<Vector3>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x63A9990", Offset = "0x63A8D90", VA = "0x1863A9990")]
	public JIGPEIHGPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x63A96F0", Offset = "0x63A8AF0", VA = "0x1863A96F0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Vector3 EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x63A93A0", Offset = "0x63A87A0", VA = "0x1863A93A0", Slot = "5")]
	public Vector3 ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OENJBNHPKNI : ALMAJBDDDKL<Vector4>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63AE1C0", Offset = "0x63AD5C0", VA = "0x1863AE1C0")]
	public OENJBNHPKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63ADE80", Offset = "0x63AD280", VA = "0x1863ADE80", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Vector4 EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63ADAF0", Offset = "0x63ACEF0", VA = "0x1863ADAF0", Slot = "5")]
	public Vector4 ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KNNAOEJKMLK : ALMAJBDDDKL<Quaternion>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63ABC10", Offset = "0x63AB010", VA = "0x1863ABC10")]
	public KNNAOEJKMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63AB8D0", Offset = "0x63AACD0", VA = "0x1863AB8D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Quaternion EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63AB540", Offset = "0x63AA940", VA = "0x1863AB540", Slot = "5")]
	public Quaternion ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OAJFGIAOILD : ALMAJBDDDKL<Color>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63AD800", Offset = "0x63ACC00", VA = "0x1863AD800")]
	public OAJFGIAOILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x63AD4C0", Offset = "0x63AC8C0", VA = "0x1863AD4C0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Color EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x63AD130", Offset = "0x63AC530", VA = "0x1863AD130", Slot = "5")]
	public Color ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BLCAEENGLPG : ALMAJBDDDKL<Bounds>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6393E90", Offset = "0x6393290", VA = "0x186393E90")]
	public BLCAEENGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6393B70", Offset = "0x6392F70", VA = "0x186393B70", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Bounds EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6393790", Offset = "0x6392B90", VA = "0x186393790", Slot = "5")]
	public Bounds ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class FHJBLCKBCIH : ALMAJBDDDKL<Rect>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly EDNEPDBCKID NLICEEKDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] EFAEILDIHAO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x639A660", Offset = "0x6399A60", VA = "0x18639A660")]
	public FHJBLCKBCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x639A2F0", Offset = "0x63996F0", VA = "0x18639A2F0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Rect EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6399F00", Offset = "0x6399300", VA = "0x186399F00", Slot = "5")]
	public Rect ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class EHDBKOONCME : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class JKLBGNGPGBN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x38524B0", Offset = "0x38518B0", VA = "0x1838524B0")]
		static JKLBGNGPGBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private EHDBKOONCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class GDEIPJKJGLK : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class BDEDLHNKAOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4447140", Offset = "0x4446540", VA = "0x184447140")]
		static BDEDLHNKAOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class DJNCKIMIEDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> EGJDLCJIOEB;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6395CE0", Offset = "0x63950E0", VA = "0x186395CE0")]
		internal static object GKKNHIGKACB(Type PDOICOFDEIB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private GDEIPJKJGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class IJNGKDLBGEE : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class KCFJENOHLGB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x38BAA00", Offset = "0x38B9E00", VA = "0x1838BAA00")]
		static KCFJENOHLGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IJNGKDLBGEE PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool FAHAPPBIDDM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static BJHFEJJJBKA[] GADAKKCHBGF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static NGDHCEEFPJP[] IJLOGAGCNAG;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private IJNGKDLBGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63A8C00", Offset = "0x63A8000", VA = "0x1863A8C00")]
	public static void KIPDOAILNDA(params NGDHCEEFPJP[] IJLOGAGCNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63A8B20", Offset = "0x63A7F20", VA = "0x1863A8B20")]
	public static void KIPDOAILNDA(params BJHFEJJJBKA[] GADAKKCHBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CE0", Offset = "0x63A80E0", VA = "0x1863A8CE0")]
	public static void LHLABIKJJNN(BJHFEJJJBKA[] GADAKKCHBGF, NGDHCEEFPJP[] IJLOGAGCNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BMMIHLDMKEN : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class ILPKDLGIJJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3646AB0", Offset = "0x3645EB0", VA = "0x183646AB0")]
		static ILPKDLGIJJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private BMMIHLDMKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HGLIIPGCHKC
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly NGDHCEEFPJP BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly NGDHCEEFPJP CNBPOMCILOI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NGDHCEEFPJP MKLJAHMFLMF;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly NGDHCEEFPJP PJGIMOKFLDI;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly NGDHCEEFPJP COGAGDKLPFC;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly NGDHCEEFPJP GAOFDNPJNPA;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly NGDHCEEFPJP IPGOJMLJHME;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly NGDHCEEFPJP AOMNCDEKCEB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly NGDHCEEFPJP LMMMANMOFBH;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly NGDHCEEFPJP HEDGKLGJBMK;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly NGDHCEEFPJP NKNAFCFGOKC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly NGDHCEEFPJP ABMOPHOHFIG;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AOFMPEEDKCN
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly NGDHCEEFPJP BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly NGDHCEEFPJP OLCBEOIHKHM;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FCLCMNCFFHM
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly NGDHCEEFPJP BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly NGDHCEEFPJP CNBPOMCILOI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly NGDHCEEFPJP MKLJAHMFLMF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NGDHCEEFPJP PJGIMOKFLDI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly NGDHCEEFPJP COGAGDKLPFC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly NGDHCEEFPJP GAOFDNPJNPA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly NGDHCEEFPJP IPGOJMLJHME;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly NGDHCEEFPJP AOMNCDEKCEB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly NGDHCEEFPJP LMMMANMOFBH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly NGDHCEEFPJP HEDGKLGJBMK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly NGDHCEEFPJP NKNAFCFGOKC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NGDHCEEFPJP ABMOPHOHFIG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class ELEFBGGGKFH
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> EGJDLCJIOEB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6397D80", Offset = "0x6397180", VA = "0x186397D80")]
	internal static object GKKNHIGKACB(Type PDOICOFDEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63994E0", Offset = "0x63988E0", VA = "0x1863994E0")]
	private static object IIOKNEDOCCN(Type NAIBLDHALND, Type[] HDLABBILEDD, params object[] KDGOMLIACOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class IKCOICHHBFB : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class OBODBEHIPIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC950", Offset = "0x3CDBD50", VA = "0x183CDC950")]
		static OBODBEHIPIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly GALOEJFDKEN EDGPAIDKEKG;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x63A9090", Offset = "0x63A8490", VA = "0x1863A9090")]
	static IKCOICHHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private IKCOICHHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LIMEFFELLHE : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class PHPFMLONEMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0350", Offset = "0x3DCF750", VA = "0x183DD0350")]
		static PHPFMLONEMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly GALOEJFDKEN EDGPAIDKEKG;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x63ABF00", Offset = "0x63AB300", VA = "0x1863ABF00")]
	static LIMEFFELLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private LIMEFFELLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class NJBDOJIICDI : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class EAFPECGCPPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x302CF50", Offset = "0x302C350", VA = "0x18302CF50")]
		static EAFPECGCPPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly GALOEJFDKEN EDGPAIDKEKG;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x63ACFC0", Offset = "0x63AC3C0", VA = "0x1863ACFC0")]
	static NJBDOJIICDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private NJBDOJIICDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class MPEGENNGEGG : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class PDHMBDCEDFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD5E0", Offset = "0x3DBC9E0", VA = "0x183DBD5E0")]
		static PDHMBDCEDFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly GALOEJFDKEN EDGPAIDKEKG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x63AC170", Offset = "0x63AB570", VA = "0x1863AC170")]
	static MPEGENNGEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private MPEGENNGEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GOIPCJHAKPD : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class MGOINMPBKME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3B65F90", Offset = "0x3B65390", VA = "0x183B65F90")]
		static MGOINMPBKME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly GALOEJFDKEN EDGPAIDKEKG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x63A7DF0", Offset = "0x63A71F0", VA = "0x1863A7DF0")]
	static GOIPCJHAKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private GOIPCJHAKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EGNKNMHOEHG : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class ILDGKMPGEOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3641B10", Offset = "0x3640F10", VA = "0x183641B10")]
		static ILDGKMPGEOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly GALOEJFDKEN EDGPAIDKEKG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6397B10", Offset = "0x6396F10", VA = "0x186397B10")]
	static EGNKNMHOEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private EGNKNMHOEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class KDMLDNBMBBP : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class HDIKGOBLIML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3537EC0", Offset = "0x35372C0", VA = "0x183537EC0")]
		static HDIKGOBLIML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KDMLDNBMBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class GMBMOAEBJNN : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class FPCGEEFDNOA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x33ECEE0", Offset = "0x33EC2E0", VA = "0x1833ECEE0")]
		static FPCGEEFDNOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GMBMOAEBJNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class KMENFNBEGOC : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class BIJFFBLBNDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4844CB0", Offset = "0x48440B0", VA = "0x184844CB0")]
		static BIJFFBLBNDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KMENFNBEGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class INMHNIHLJDH : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class KIAEOFBOGPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x38D9A60", Offset = "0x38D8E60", VA = "0x1838D9A60")]
		static KIAEOFBOGPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public INMHNIHLJDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class LLJPNNGDLLK : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class ICJECFPEBAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3613530", Offset = "0x3612930", VA = "0x183613530")]
		static ICJECFPEBAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LLJPNNGDLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class ICOLDBCMBCI : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class CCLPFMHLDAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5590", Offset = "0x4AB4990", VA = "0x184AB5590")]
		static CCLPFMHLDAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> OCAEDHIGJGN;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool MJKFKPCJCHN;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ICOLDBCMBCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class GDFBANBBJFI
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct PGBICCPGJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public POBOHNMBLMA AAMEOHJEKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder GINHJOKCNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder EHNEMHNDDLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class DEFJOCFJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class ELDPAKDPIPA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo PICGCNBNNNE;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo LNBHKBBDLKA;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo PNDEKPHBLJA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo HFKFCOMKHCB;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo PFBIDDKDPIP;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo GKFJBAHGPLI;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo MPEOKEHNLKC;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo DDAOFLPFKPB;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo ELMMLDABOBA;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x63B8DC0", Offset = "0x63B81C0", VA = "0x1863B8DC0")]
			static ELDPAKDPIPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class HIJKAMKKBLI
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo KFLOJOEIHLB;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo GGIBECGOHFN;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo MBPJOPCGKKP;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo JCDAIPHKAIE;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo EPGNDHDJCPP;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo NNLHJJCCFNG;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo EONBNHCBEDC;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x63BD040", Offset = "0x63BC440", VA = "0x1863BD040")]
			static HIJKAMKKBLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class BFOLGCJJMFA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FDNGDPKBFAJ;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo CEMIOHIHCBH;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo CNJKKLIMHIJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo PGHPDAPDCHD;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo KACBBNKEOLF;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FKEPOEPALNF;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GINCOBPFGDK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo GDBFCLNAAGF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo DGJLDALHBEL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo FHHNMIODFDI;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LOIPFIAHMHF;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo HNCJCMLLKHN;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo KKMJMAGGBAD;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo LGNCFOJCPAM;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6394460", Offset = "0x6393860", VA = "0x186394460")]
		public static MethodInfo PJNKBIHCNDA(Type IJFAMCPOKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6394220", Offset = "0x6393620", VA = "0x186394220")]
		public static MethodInfo ONLENKPGCBM(Type IJFAMCPOKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63940F0", Offset = "0x63934F0", VA = "0x1863940F0")]
		public static MethodInfo LHCKFIJEOPH(Type IJFAMCPOKBO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GKMFNMDFBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<POBOHNMBLMA, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public GKMFNMDFBLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EKJNLBKKMPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public GKMFNMDFBLP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public EKJNLBKKMPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x63B8B60", Offset = "0x63B7F60", VA = "0x1863B8B60")]
		internal void CEBCIGDIDHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x63B8C60", Offset = "0x63B8060", VA = "0x1863B8C60")]
		internal bool MBCHGHNLIIL(int index, POBOHNMBLMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JCHPFJBABEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GKMFNMDFBLP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public JCHPFJBABEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x63BE1C0", Offset = "0x63BD5C0", VA = "0x1863BE1C0")]
		internal bool AJLBIBMPKNO(int index, POBOHNMBLMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class ABCFHCABKHE
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public ABCFHCABKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x34C6920", Offset = "0x34C5D20", VA = "0x1834C6920")]
		internal string KFIMHNIFGAD(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FEPIAKOENMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FEPIAKOENMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x63B9ED0", Offset = "0x63B92D0", VA = "0x1863B9ED0")]
		internal bool ILGBGLPCONF(POBOHNMBLMA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class MCAPHAOKDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ABCFHCABKHE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public MCAPHAOKDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x63C1860", Offset = "0x63C0C60", VA = "0x1863C1860")]
		internal void NJLJBNICFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x63C1680", Offset = "0x63C0A80", VA = "0x1863C1680")]
		internal bool ICMABNMHPIM(int index, POBOHNMBLMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DDMGLMLNIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public ABCFHCABKHE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public DDMGLMLNIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x63B7CB0", Offset = "0x63B70B0", VA = "0x1863B7CB0")]
		internal bool NDFFJBKBAEH(int index, POBOHNMBLMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IHCHIAMINMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public IHCHIAMINMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x63B23C0", Offset = "0x63B17C0", VA = "0x1863B23C0")]
		internal Label DJPHFFCDINK(POBOHNMBLMA _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JLOCFNAMNJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public PGBICCPGJAF[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, POBOHNMBLMA, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NKNIMIIOBJC argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NKNIMIIOBJC argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public JLOCFNAMNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x63BE670", Offset = "0x63BDA70", VA = "0x1863BE670")]
		internal PGBICCPGJAF OPKBNECLONC(POBOHNMBLMA item)
		{
			return default(PGBICCPGJAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OOPFEIPJKIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public JLOCFNAMNJA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public OOPFEIPJKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x63C7AE0", Offset = "0x63C6EE0", VA = "0x1863C7AE0")]
		internal void DIIDDKLIAFC(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x63C7A40", Offset = "0x63C6E40", VA = "0x1863C7A40")]
		internal void CJOPDKAENPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NMJKLGGEMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public POBOHNMBLMA item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NMJKLGGEMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA760B0", Offset = "0xA754B0", VA = "0x180A760B0")]
		internal bool NCFLEPEJNKO(PGBICCPGJAF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class MMEGGCOCAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public POBOHNMBLMA item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public MMEGGCOCAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA760B0", Offset = "0xA754B0", VA = "0x180A760B0")]
		internal bool EDPOFFCBFDJ(PGBICCPGJAF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex GOMLOBOHPMD;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KPFIDKJMBEB;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> PPLGAHADBBF;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> FFDKLHKPJDC;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x238A410", Offset = "0x2389810", VA = "0x18238A410")]
	public static object KMDDJCHFHMM<T>(GALOEJFDKEN EDGPAIDKEKG, NGDHCEEFPJP KKKBIMFNPEG, Func<string, string> OCAEDHIGJGN, bool MJKFKPCJCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x237F710", Offset = "0x237EB10", VA = "0x18237F710")]
	public static object FHCEJJOJJHM<T>(NGDHCEEFPJP KKKBIMFNPEG, Func<string, string> OCAEDHIGJGN, bool MJKFKPCJCHN, bool DCMILHHHDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x63A5620", Offset = "0x63A4A20", VA = "0x1863A5620")]
	private static TypeInfo NMOEODIBBFI(GALOEJFDKEN EDGPAIDKEKG, Type IJFAMCPOKBO, Func<string, string> OCAEDHIGJGN, bool MJKFKPCJCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x63A3680", Offset = "0x63A2A80", VA = "0x1863A3680")]
	public static object KKLJLOGIMCP(Type IJFAMCPOKBO, Func<string, string> OCAEDHIGJGN, bool MJKFKPCJCHN, bool DCMILHHHDFI, bool OJABKLNKEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x63A2F50", Offset = "0x63A2350", VA = "0x1863A2F50")]
	private static Dictionary<POBOHNMBLMA, FieldInfo> KJCAEAAJPLK(TypeBuilder IBHOGGLAKJA, FIPNPEHOIPM BCOICEBLMNF, ConstructorInfo BKEOAKFHKEK, FieldBuilder NKAOKLKOENA, ILGenerator GONJEFKIKEL, bool MJKFKPCJCHN, bool LNGMNBEFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x63A07A0", Offset = "0x639FBA0", VA = "0x1863A07A0")]
	private static Dictionary<POBOHNMBLMA, FieldInfo> CBEMBLJKDNI(TypeBuilder IBHOGGLAKJA, FIPNPEHOIPM BCOICEBLMNF, ILGenerator GONJEFKIKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x63A6040", Offset = "0x63A5440", VA = "0x1863A6040")]
	private static void OALLJCEONOK(Type IJFAMCPOKBO, FIPNPEHOIPM BCOICEBLMNF, ILGenerator GONJEFKIKEL, Action OBEPDJFANPP, Func<int, POBOHNMBLMA, bool> CAMCNINBGAH, bool MJKFKPCJCHN, bool LNGMNBEFOJM, int JEMMIMNPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x63A2A10", Offset = "0x63A1E10", VA = "0x1863A2A10")]
	private static void HEBMKPCHDFE(TypeInfo IJFAMCPOKBO, POBOHNMBLMA MHFEHNAAMCA, ILGenerator GONJEFKIKEL, int APOENOPNHBG, Func<int, POBOHNMBLMA, bool> CAMCNINBGAH, NKNIMIIOBJC MKIOBJMIBCN, NKNIMIIOBJC OIHNIOLBANH, NKNIMIIOBJC JMKGKGDFKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x63A0E80", Offset = "0x63A0280", VA = "0x1863A0E80")]
	private static void EAFFMICDAFF(Type IJFAMCPOKBO, FIPNPEHOIPM BCOICEBLMNF, ILGenerator GONJEFKIKEL, Func<int, POBOHNMBLMA, bool> CAMCNINBGAH, bool HKCEJKJKCJK, int JEMMIMNPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x63A51B0", Offset = "0x63A45B0", VA = "0x1863A51B0")]
	private static void MDFFEBPAEJA(ILGenerator GONJEFKIKEL, PGBICCPGJAF BCOICEBLMNF, int APOENOPNHBG, Func<int, POBOHNMBLMA, bool> CAMCNINBGAH, NKNIMIIOBJC IOJEJAFBOHN, NKNIMIIOBJC JMKGKGDFKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x639FA10", Offset = "0x639EE10", VA = "0x18639FA10")]
	private static LocalBuilder AODAMODGPHD(ILGenerator GONJEFKIKEL, Type IJFAMCPOKBO, FIPNPEHOIPM BCOICEBLMNF, PGBICCPGJAF[] LFOPKAFFILM, bool MGDAPINGIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x63A21B0", Offset = "0x63A15B0", VA = "0x1863A21B0")]
	private static bool FKDLKKMLFPD(ConstructorInfo HPNMOAIENGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x63A2890", Offset = "0x63A1C90", VA = "0x1863A2890")]
	private static bool FLCHGJMDDME(Type IJFAMCPOKBO, [Out] Type NKLCGMJDAIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void OLPJBEBPCFI<T>(byte[][] NKAOKLKOENA, object[] OKMMGOAHLIP, GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP HJGPHCCBOKK);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T KKKHFIDJCOE<T>(object[] OKMMGOAHLIP, GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP HJGPHCCBOKK);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class OOFDANJAKEJ<T> : ALMAJBDDDKL<T>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] NKAOKLKOENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] AEHBALLCEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] KPINPEAALED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly OLPJBEBPCFI<T> NBOHHOPEGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly KKKHFIDJCOE<T> JMMHJAKHCJP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1C42E20", Offset = "0x1C42220", VA = "0x181C42E20")]
	public OOFDANJAKEJ(byte[][] NKAOKLKOENA, object[] AEHBALLCEPI, object[] KPINPEAALED, OLPJBEBPCFI<T> NBOHHOPEGCF, KKKHFIDJCOE<T> JMMHJAKHCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3D07620", Offset = "0x3D06A20", VA = "0x183D07620", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3D07530", Offset = "0x3D06930", VA = "0x183D07530", Slot = "5")]
	public T ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class DAKJADKGJKA : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class LONINFBOBNP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x39903F0", Offset = "0x398F7F0", VA = "0x1839903F0")]
		static LONINFBOBNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private DAKJADKGJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class GJNBFEKNPJF : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class IPNNNMGNMHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3698250", Offset = "0x3697650", VA = "0x183698250")]
		static IPNNNMGNMHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private GJNBFEKNPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class MABAODKAEID
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly NGDHCEEFPJP[] OEOEPEKIKOD;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class BFBIIGLIEIG : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class HJKEBMMFDHN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x355D740", Offset = "0x355CB40", VA = "0x18355D740")]
		static HJKEBMMFDHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class AOBIOJJDDHI : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class MACHCPNPOMN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3B59850", Offset = "0x3B58C50", VA = "0x183B59850")]
			static MACHCPNPOMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private AOBIOJJDDHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private BFBIIGLIEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class LNDJPBLAEEO : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class GDNPAEOOPFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x34B7060", Offset = "0x34B6460", VA = "0x1834B7060")]
		static GDNPAEOOPFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class DIHJNOGBANP : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class HHBPOGBLNDO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x353F400", Offset = "0x353E800", VA = "0x18353F400")]
			static HHBPOGBLNDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private DIHJNOGBANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private LNDJPBLAEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class JJPLCCNPIGE : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class ECNPOIHMBKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3039800", Offset = "0x3038C00", VA = "0x183039800")]
		static ECNPOIHMBKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class DAELNFJCDOE : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class LACCIPAMHLF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3965BE0", Offset = "0x3964FE0", VA = "0x183965BE0")]
			static LACCIPAMHLF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private DAELNFJCDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private JJPLCCNPIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class KHEIKNPGFLD : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class KIIJECNNPCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x38E1E80", Offset = "0x38E1280", VA = "0x1838E1E80")]
		static KIIJECNNPCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class OMHFICEKDAJ : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class DHNKJGEIIFN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4C90150", Offset = "0x4C8F550", VA = "0x184C90150")]
			static DHNKJGEIIFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private OMHFICEKDAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private KHEIKNPGFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class FDMIBIBPFFD : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class ACNDMNDAAJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x345F6B0", Offset = "0x345EAB0", VA = "0x18345F6B0")]
		static ACNDMNDAAJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class PAFIFLGCDLP : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class OMKOBJCHIJH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3CFCBD0", Offset = "0x3CFBFD0", VA = "0x183CFCBD0")]
			static OMKOBJCHIJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private PAFIFLGCDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private FDMIBIBPFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class EIPFIGDOKNK : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class IEFFCMBOOGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x362C390", Offset = "0x362B790", VA = "0x18362C390")]
		static IEFFCMBOOGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class MEDELLJBEHP : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class PFLHPDEBNGK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3DCDE20", Offset = "0x3DCD220", VA = "0x183DCDE20")]
			static PFLHPDEBNGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private MEDELLJBEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private EIPFIGDOKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class CNMBEFJAAKH : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class GKOIOJLEGIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D2620", VA = "0x1834D3220")]
		static GKOIOJLEGIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class KNNFGJDJBLA : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class LFNIFJKECNJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x397A4B0", Offset = "0x39798B0", VA = "0x18397A4B0")]
			static LFNIFJKECNJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private KNNFGJDJBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private CNMBEFJAAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class HHGKBNGEBOC : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class PLKGDJECFJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E00330", Offset = "0x3DFF730", VA = "0x183E00330")]
		static PLKGDJECFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class JGOAINMJHLN : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class AGMJGACCNFO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x348E500", Offset = "0x348D900", VA = "0x18348E500")]
			static AGMJGACCNFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private JGOAINMJHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private HHGKBNGEBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class LBDEHMLCDBF : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class EGAEJIEPFKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x30465C0", Offset = "0x30459C0", VA = "0x1830465C0")]
		static EGAEJIEPFKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class KIDIFHJPCKC : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class HLJOJMLKPKP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x356A900", Offset = "0x3569D00", VA = "0x18356A900")]
			static HLJOJMLKPKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private KIDIFHJPCKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private LBDEHMLCDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class GIHJCFCAPJE : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class DBGEAFNJJGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4C78340", Offset = "0x4C77740", VA = "0x184C78340")]
		static DBGEAFNJJGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class HCNJNCFELJH : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class AEDMCLADCHD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3483B90", Offset = "0x3482F90", VA = "0x183483B90")]
			static AEDMCLADCHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private HCNJNCFELJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private GIHJCFCAPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class HJLLIKKGNDC : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class MHIFDCFCOGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F5D0", Offset = "0x3B6E9D0", VA = "0x183B6F5D0")]
		static MHIFDCFCOGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class KLGJOLFIINH : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class JPCFNBOLIBM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3862C50", Offset = "0x3862050", VA = "0x183862C50")]
			static JPCFNBOLIBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private KLGJOLFIINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private HJLLIKKGNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class KCNDFJLNHNI : NGDHCEEFPJP
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class NNMKEAJOGFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C31C20", Offset = "0x3C31020", VA = "0x183C31C20")]
		static NNMKEAJOGFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class PEFNCMEKGIP : NGDHCEEFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class DEIPGMCLKKM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly ALMAJBDDDKL<T> GFIPKNJGPFF;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4C86330", Offset = "0x4C85730", VA = "0x184C86330")]
			static DEIPGMCLKKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly NGDHCEEFPJP PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly NGDHCEEFPJP[] IJLOGAGCNAG;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private PEFNCMEKGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
		public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly NGDHCEEFPJP PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ALMAJBDDDKL<object> NGKPPHHOKML;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	private KCNDFJLNHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	public ALMAJBDDDKL<T> GKKNHIGKACB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct FHKIJPJMCKG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] LOGNBGCLNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int LMJBHMFNAOD;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x33D8FC0", Offset = "0x33D83C0", VA = "0x1833D8FC0")]
	public FHKIJPJMCKG(int MAPKJDAIEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x33D8D30", Offset = "0x33D8130", VA = "0x1833D8D30")]
	public void INMJBKGEACO(T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x33D8BD0", Offset = "0x33D7FD0", VA = "0x1833D8BD0")]
	public T[] EOIGLDMNJPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class DDFHOEMCJEC : MIJEJKKHCBG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly DDFHOEMCJEC BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x63B7C60", Offset = "0x63B7060", VA = "0x1863B7C60")]
	public DDFHOEMCJEC(int IDBBILIIKNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class MIJEJKKHCBG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int IDBBILIIKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object LOEPHCANKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int APOENOPNHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] ILOHJIGADOK;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAA80", Offset = "0x3BA9E80", VA = "0x183BAAA80")]
	public MIJEJKKHCBG(int IDBBILIIKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA240", Offset = "0x3BA9640", VA = "0x183BAA240")]
	public T[] LHOBAMHKGAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9DC0", Offset = "0x3BA91C0", VA = "0x183BA9DC0")]
	public void CIJOAFCAJHN(T[] FFAHMFOPGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class EDNEPDBCKID : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class ADCGFPNOMCG : IComparable<ADCGFPNOMCG>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class DOLNIMCHOBL : IEnumerable<ADCGFPNOMCG>, IEnumerable, IEnumerator<ADCGFPNOMCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private ADCGFPNOMCG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public ADCGFPNOMCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private ADCGFPNOMCG System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
			[DebuggerHidden]
			public DOLNIMCHOBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x63B8170", Offset = "0x63B7570", VA = "0x1863B8170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x63B82A0", Offset = "0x63B76A0", VA = "0x1863B82A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x63B81F0", Offset = "0x63B75F0", VA = "0x1863B81F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ADCGFPNOMCG> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x63B81F0", Offset = "0x63B75F0", VA = "0x1863B81F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class APDLJLNGJEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public APDLJLNGJEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x63B23C0", Offset = "0x63B17C0", VA = "0x1863B23C0")]
			internal Label IMKLLFIDJBC(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x63B23C0", Offset = "0x63B17C0", VA = "0x1863B23C0")]
			internal Label AAFOIFGAAJP(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly ADCGFPNOMCG[] PABPDDJGPHJ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] HJNMJJGGEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong KHCAJFNIBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int DFNAILAPHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string OBCJGLBPLML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private ADCGFPNOMCG[] HHMLGPANEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] JAOLICBKNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int OGEHFGGOGMJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool OJNHCCDNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4F3D460", Offset = "0x4F3C860", VA = "0x184F3D460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x63B1EC0", Offset = "0x63B12C0", VA = "0x1863B1EC0")]
		public ADCGFPNOMCG(ulong DGCJCBHPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x63B0E40", Offset = "0x63B0240", VA = "0x1863B0E40")]
		public ADCGFPNOMCG INMJBKGEACO(ulong DGCJCBHPPBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x63B1040", Offset = "0x63B0440", VA = "0x1863B1040")]
		public ADCGFPNOMCG INMJBKGEACO(ulong DGCJCBHPPBD, int EOHMJBFGDPD, string OBCJGLBPLML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x63B0C40", Offset = "0x63B0040", VA = "0x1863B0C40")]
		public ADCGFPNOMCG EIKGOHKCKHK(byte[] DCHCBCCCIIP, int APBJNEFOGOC, int OJGFPGIPHAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x63B1D80", Offset = "0x63B1180", VA = "0x1863B1D80")]
		internal static int PHPDHJHGAIJ(ulong[] FFAHMFOPGLA, int APOENOPNHBG, int KIHHOMBMMEI, ulong EOHMJBFGDPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x63B0C10", Offset = "0x63B0010", VA = "0x1863B0C10", Slot = "4")]
		public int CompareTo(ADCGFPNOMCG LJIBJAOOGGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x63B0DC0", Offset = "0x63B01C0", VA = "0x1863B0DC0")]
		[IteratorStateMachine(typeof(DOLNIMCHOBL))]
		public IEnumerable<ADCGFPNOMCG> FMFMJCMNFEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x63B0890", Offset = "0x63AFC90", VA = "0x1863B0890")]
		public void BPPILEIKOOL(ILGenerator GONJEFKIKEL, LocalBuilder DCHCBCCCIIP, LocalBuilder OJGFPGIPHAO, LocalBuilder DGCJCBHPPBD, Action<KeyValuePair<string, int>> MKOMGANPKCB, Action CKPJJBDLPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x63B10A0", Offset = "0x63B04A0", VA = "0x1863B10A0")]
		private static void OMONCDGKPBC(ILGenerator GONJEFKIKEL, LocalBuilder DCHCBCCCIIP, LocalBuilder OJGFPGIPHAO, LocalBuilder DGCJCBHPPBD, Action<KeyValuePair<string, int>> MKOMGANPKCB, Action CKPJJBDLPLG, ADCGFPNOMCG[] HHMLGPANEDI, int OGEHFGGOGMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FIDANPNGNIC : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<ADCGFPNOMCG> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<ADCGFPNOMCG> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<ADCGFPNOMCG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private ADCGFPNOMCG <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x95E320", Offset = "0x95D720", VA = "0x18095E320", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x63BA530", Offset = "0x63B9930", VA = "0x1863BA530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1B66460", Offset = "0x1B65860", VA = "0x181B66460")]
		[DebuggerHidden]
		public FIDANPNGNIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x63BA580", Offset = "0x63B9980", VA = "0x1863BA580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x63B9FD0", Offset = "0x63B93D0", VA = "0x1863B9FD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x63B9F80", Offset = "0x63B9380", VA = "0x1863B9F80")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x63B9F30", Offset = "0x63B9330", VA = "0x1863B9F30")]
		private void CLLKEDEGMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63BA4E0", Offset = "0x63B98E0", VA = "0x1863BA4E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x63BA430", Offset = "0x63B9830", VA = "0x1863BA430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x63BA430", Offset = "0x63B9830", VA = "0x1863BA430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly ADCGFPNOMCG OGEFIHKILIO;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63B8960", Offset = "0x63B7D60", VA = "0x1863B8960")]
	public EDNEPDBCKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63B84B0", Offset = "0x63B78B0", VA = "0x1863B84B0")]
	public void INMJBKGEACO(byte[] HPOLMACFBHD, int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63B82F0", Offset = "0x63B76F0", VA = "0x1863B82F0")]
	public bool BEOHKBJFJEN(ArraySegment<byte> DGCJCBHPPBD, [Out] int EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63B88D0", Offset = "0x63B7CD0", VA = "0x1863B88D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63B85C0", Offset = "0x63B79C0", VA = "0x1863B85C0")]
	private static void ODHKJPDMCLC(IEnumerable<ADCGFPNOMCG> HHMLGPANEDI, StringBuilder ACCDGCMLOFP, int MOLHCHBGJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x63B83D0", Offset = "0x63B77D0", VA = "0x1863B83D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x63B83D0", Offset = "0x63B77D0", VA = "0x1863B83D0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x63B8430", Offset = "0x63B7830", VA = "0x1863B8430")]
	[IteratorStateMachine(typeof(FIDANPNGNIC))]
	private static IEnumerable<KeyValuePair<string, int>> HNIJHEKPHAO(IEnumerable<ADCGFPNOMCG> HHMLGPANEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63B88A0", Offset = "0x63B7CA0", VA = "0x1863B88A0")]
	public void PBKHPCHHMIM(ILGenerator GONJEFKIKEL, LocalBuilder DCHCBCCCIIP, LocalBuilder OJGFPGIPHAO, LocalBuilder DGCJCBHPPBD, Action<KeyValuePair<string, int>> MKOMGANPKCB, Action CKPJJBDLPLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class JPJAEOLJHDE
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo BJOMMLLCCJN;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63BE790", Offset = "0x63BDB90", VA = "0x1863BE790")]
	public static ulong LNMKPMMKLKI(byte[] HPOLMACFBHD, int APBJNEFOGOC, int OJGFPGIPHAO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class CAMHJFJCDGH
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x63B6E70", Offset = "0x63B6270", VA = "0x1863B6E70")]
	public static void GLMPNOFHEEJ(byte[] HPOLMACFBHD, int APBJNEFOGOC, int LJBPGAIGCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x63B6FB0", Offset = "0x63B63B0", VA = "0x1863B6FB0")]
	public static void IFPBEBONIME(byte[] FFAHMFOPGLA, int CCCBBIIMNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x63B6D40", Offset = "0x63B6140", VA = "0x1863B6D40")]
	public static byte[] CKLFEKBFHJP(byte[] ABNGLIALIJA, int CCCBBIIMNAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class PCBFKENOMME
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x63C7F60", Offset = "0x63C7360", VA = "0x1863C7F60")]
	public static bool NFGELCJMMCN(byte[] PEIPMAJDFDE, int GKADMADNJBD, int DCMNAJEBLNG, byte[] AKGODIBMFGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class ICNABOALJLG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct KCDMPICBJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] KHCAJFNIBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T DFNAILAPHHN;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x38B09C0", Offset = "0x38AFDC0", VA = "0x1838B09C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class MKGFNDKHAPA : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public ICNABOALJLG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private KCDMPICBJON[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private KCDMPICBJON[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x95E320", Offset = "0x95D720", VA = "0x18095E320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x33FE8E0", Offset = "0x33FDCE0", VA = "0x1833FE8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
		[DebuggerHidden]
		public MKGFNDKHAPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1F80", Offset = "0x3BB1380", VA = "0x183BB1F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2310", Offset = "0x3BB1710", VA = "0x183BB2310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly KCDMPICBJON[][] KPMEBFILFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong BOMICKPGDLD;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3616750", Offset = "0x3615B50", VA = "0x183616750")]
	public ICNABOALJLG(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3616770", Offset = "0x3615B70", VA = "0x183616770")]
	public ICNABOALJLG(int OOIJDECJBIB, float JKOLNCCBFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3616670", Offset = "0x3615A70", VA = "0x183616670")]
	public void INMJBKGEACO(byte[] DGCJCBHPPBD, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3616050", Offset = "0x3615450", VA = "0x183616050")]
	private bool BMBLPCJHKDN(byte[] DGCJCBHPPBD, T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3616450", Offset = "0x3615850", VA = "0x183616450")]
	public bool IEDNKFHOGLK(ArraySegment<byte> DGCJCBHPPBD, [Out] T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3616000", Offset = "0x3615400", VA = "0x183616000")]
	private static ulong AJBNNFBBPGH(byte[] MHJJOHHKIPH, int APBJNEFOGOC, int OGEHFGGOGMJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3074DD0", Offset = "0x30741D0", VA = "0x183074DD0")]
	private static int MAGNJPPGHKK(int JKCGKBHICCO, float JKOLNCCBFCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x36163C0", Offset = "0x36157C0", VA = "0x1836163C0", Slot = "4")]
	[IteratorStateMachine(typeof(ICNABOALJLG<>.MKGFNDKHAPA))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x31707F0", Offset = "0x316FBF0", VA = "0x1831707F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class HPJLDLFLKMH : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] IAJONIIDCJC;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] PKOFDJHBOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int LKLBFCAMDCC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AFBNMFICJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x63BDE80", Offset = "0x63BD280", VA = "0x1863BDE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x63BDED0", Offset = "0x63BD2D0", VA = "0x1863BDED0")]
	static HPJLDLFLKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63BE130", Offset = "0x63BD530", VA = "0x1863BE130")]
	public HPJLDLFLKMH(byte[] GGBGNKCAFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x63BDD80", Offset = "0x63BD180", VA = "0x1863BDD80")]
	public OpCode JBBBOKEOLLB()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct OBDMAPPEGLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid DFNAILAPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte EINCPIDMDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte NCDDPCMJKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte MIEPGIHJGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte IIIKHMLDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte GFIDIJMHNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte CLJJMCLCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte DOPODMLHPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte BBBLFAOGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte BPCCMNGNJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GLHGMDOFOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte CLENIGNDIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte EIGIIDJPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte OEKPDIMDICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte JGHLGGDNJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte INGEFGOLANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte PIPLOOHIAPL;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] HNFGNAGKCCG;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] IGFLOCCLBEA;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x63C5CA0", Offset = "0x63C50A0", VA = "0x1863C5CA0")]
	public OBDMAPPEGLK(Guid EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x63C4550", Offset = "0x63C3950", VA = "0x1863C4550")]
	public OBDMAPPEGLK(ArraySegment<byte> LDCGKDEHBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x63C35F0", Offset = "0x63C29F0", VA = "0x1863C35F0")]
	private static byte ENEAALFEAGI(byte[] HPOLMACFBHD, int ACLHPMHOGCF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63C4340", Offset = "0x63C3740", VA = "0x1863C4340")]
	private static byte GPJIMDNNIOF(byte DNPBOPMFFFF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63C3690", Offset = "0x63C2A90", VA = "0x1863C3690")]
	public void EOCHBNCKDPC(byte[] FNCIFBBDALE, int APBJNEFOGOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class OHHMKHMBKMB
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63C7700", Offset = "0x63C6B00", VA = "0x1863C7700")]
	public static bool OCEKKHHBINO(byte AGEAOGKCCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63C5E90", Offset = "0x63C5290", VA = "0x1863C5E90")]
	public static bool BFKPKOCFGOE(byte AGEAOGKCCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63C68F0", Offset = "0x63C5CF0", VA = "0x1863C68F0")]
	public static sbyte FLDGDMJICDB(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63C69D0", Offset = "0x63C5DD0", VA = "0x1863C69D0")]
	public static short GODEHDEOIFB(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63C7780", Offset = "0x63C6B80", VA = "0x1863C7780")]
	public static int POLCAIHMPMF(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63C6130", Offset = "0x63C5530", VA = "0x1863C6130")]
	public static long BPPEHHNGDGL(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x63C7480", Offset = "0x63C6880", VA = "0x1863C7480")]
	public static byte HJHAPDLAEBE(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63C61D0", Offset = "0x63C55D0", VA = "0x1863C61D0")]
	public static ushort CKCIADPFPCE(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63C7500", Offset = "0x63C6900", VA = "0x1863C7500")]
	public static uint IFOHAPOFJOM(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x63C75F0", Offset = "0x63C69F0", VA = "0x1863C75F0")]
	public static ulong KMBOPGLGAMP(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x63C7580", Offset = "0x63C6980", VA = "0x1863C7580")]
	public static float KKBLBHEGAPF(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x63C7710", Offset = "0x63C6B10", VA = "0x1863C7710")]
	public static double OODHPOCOICC(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x63C6250", Offset = "0x63C5650", VA = "0x1863C6250")]
	public static int FFLDKOGJEFN(byte[] FNCIFBBDALE, int APBJNEFOGOC, ulong EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x63C6AC0", Offset = "0x63C5EC0", VA = "0x1863C6AC0")]
	public static int HCONLAMOBIL(byte[] FNCIFBBDALE, int APBJNEFOGOC, long EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x63C5F00", Offset = "0x63C5300", VA = "0x1863C5F00")]
	public static bool BPIDEBPOLIL(byte[] HPOLMACFBHD, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class HGDFFKFGKJA
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class HAGPJFHOLCJ : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
		[DebuggerHidden]
		public HAGPJFHOLCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x63BC790", Offset = "0x63BBB90", VA = "0x1863BC790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63BC250", Offset = "0x63BB650", VA = "0x1863BC250", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x63BC200", Offset = "0x63BB600", VA = "0x1863BC200")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x63BC1B0", Offset = "0x63BB5B0", VA = "0x1863BC1B0")]
		private void CLLKEDEGMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x63BC740", Offset = "0x63BBB40", VA = "0x1863BC740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x63BC680", Offset = "0x63BBA80", VA = "0x1863BC680", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x63BC680", Offset = "0x63BBA80", VA = "0x1863BC680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class COIHFFKJOHI : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
		[DebuggerHidden]
		public COIHFFKJOHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x63B7840", Offset = "0x63B6C40", VA = "0x1863B7840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x63B7300", Offset = "0x63B6700", VA = "0x1863B7300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x63B72B0", Offset = "0x63B66B0", VA = "0x1863B72B0")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x63B7260", Offset = "0x63B6660", VA = "0x1863B7260")]
		private void CLLKEDEGMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x63B77F0", Offset = "0x63B6BF0", VA = "0x1863B77F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x63B7730", Offset = "0x63B6B30", VA = "0x1863B7730", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x63B7730", Offset = "0x63B6B30", VA = "0x1863B7730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x63BCB10", Offset = "0x63BBF10", VA = "0x1863BCB10")]
	public static bool DJMLOLEIMDP(this TypeInfo IJFAMCPOKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x63BCCF0", Offset = "0x63BC0F0", VA = "0x1863BCCF0")]
	public static bool LHMCKGCDHGG(this TypeInfo IJFAMCPOKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63BCC70", Offset = "0x63BC070", VA = "0x1863BCC70")]
	public static IEnumerable<PropertyInfo> HDGHMPKNFAC(this Type IJFAMCPOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x63BCBD0", Offset = "0x63BBFD0", VA = "0x1863BCBD0")]
	[IteratorStateMachine(typeof(HAGPJFHOLCJ))]
	private static IEnumerable<PropertyInfo> GJABHLEMCGM(Type IJFAMCPOKBO, HashSet<string> NCPEEHOBMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x63BCA90", Offset = "0x63BBE90", VA = "0x1863BCA90")]
	public static IEnumerable<FieldInfo> AFHHLHDFFFG(this Type IJFAMCPOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x63BCE20", Offset = "0x63BC220", VA = "0x1863BCE20")]
	[IteratorStateMachine(typeof(COIHFFKJOHI))]
	private static IEnumerable<FieldInfo> NNOCMEEBNFP(Type IJFAMCPOKBO, HashSet<string> NCPEEHOBMFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class FJKKOKJKDNF
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding CLMCIBICEJA;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class AKJMEBCHCEM
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static string NMHBOLEANJD(string HICAJHADMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x63B1F80", Offset = "0x63B1380", VA = "0x1863B1F80")]
	public static string GANGKOFLCHO(string HICAJHADMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x63B2060", Offset = "0x63B1460", VA = "0x1863B2060")]
	public static string KNNJGEBMHMO(string HICAJHADMAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class EKAKOJENCJB<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class PFDOMGAGMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type KHCAJFNIBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue DFNAILAPHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int CJEBEBOFCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public PFDOMGAGMNF IMBJMHKHAAP;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6900", Offset = "0x3DC5D00", VA = "0x183DC6900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3DC67B0", Offset = "0x3DC5BB0", VA = "0x183DC67B0")]
		private int EJNDKIEMIHK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PFDOMGAGMNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class AKNJDDGLEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public AKNJDDGLEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		internal TValue JLMCHDOEADF(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private PFDOMGAGMNF[] KPMEBFILFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int DAIAAPJIJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object MNACAGJKCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float JKOLNCCBFCI;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3074F10", Offset = "0x3074310", VA = "0x183074F10")]
	public EKAKOJENCJB(int OOIJDECJBIB = 4, float JKOLNCCBFCI = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3073910", Offset = "0x3072D10", VA = "0x183073910")]
	public bool AHLOGHJFIBI(Type DGCJCBHPPBD, TValue EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x30738D0", Offset = "0x3072CD0", VA = "0x1830738D0")]
	public bool AHLOGHJFIBI(Type DGCJCBHPPBD, Func<Type, TValue> BEIOAJPKFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3074020", Offset = "0x3073420", VA = "0x183074020")]
	private bool BMBLPCJHKDN(Type DGCJCBHPPBD, Func<Type, TValue> BEIOAJPKFDK, [Out] TValue JDABNIDDPBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3074770", Offset = "0x3073B70", VA = "0x183074770")]
	private bool HGCJOINJIDB(PFDOMGAGMNF[] KPMEBFILFIA, Type IFCMDKBMDJK, PFDOMGAGMNF DHELBDLNJPB, Func<Type, TValue> BEIOAJPKFDK, [Out] TValue JDABNIDDPBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3074B60", Offset = "0x3073F60", VA = "0x183074B60")]
	public bool IEDNKFHOGLK(Type DGCJCBHPPBD, [Out] TValue EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3073B70", Offset = "0x3072F70", VA = "0x183073B70")]
	public TValue ANLNKPLCCHM(Type DGCJCBHPPBD, Func<Type, TValue> BEIOAJPKFDK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3074DD0", Offset = "0x30741D0", VA = "0x183074DD0")]
	private static int MAGNJPPGHKK(int JKCGKBHICCO, float JKOLNCCBFCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3074380", Offset = "0x3073780", VA = "0x183074380")]
	private static void GAGEMGFKJPP(PFDOMGAGMNF OFHGPGHKOPA, PFDOMGAGMNF EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3074380", Offset = "0x3073780", VA = "0x183074380")]
	private static void GAGEMGFKJPP(PFDOMGAGMNF[] OFHGPGHKOPA, PFDOMGAGMNF[] EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class GALOEJFDKEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder KKMHBCKJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder PMBHEHMHCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object LOEPHCANKKD;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x63BBDA0", Offset = "0x63BB1A0", VA = "0x1863BBDA0")]
	public TypeBuilder NHGFNMDGEAN(string LFAIHEECJFK, TypeAttributes HCMNDEEABFK, Type EBFCMPBKGBM, Type[] IKFINBPNCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x63BBEA0", Offset = "0x63BB2A0", VA = "0x1863BBEA0")]
	public GALOEJFDKEN(string MBMAJDKAEII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class PKGLAIICOII
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x63C81A0", Offset = "0x63C75A0", VA = "0x1863C81A0")]
	private static MethodInfo GHOOIFJGLKE(LambdaExpression CENNDBAMLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x250D550", Offset = "0x250C950", VA = "0x18250D550")]
	public static MethodInfo ACIEBLJILEP<T>(Expression<Func<T>> CENNDBAMLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x250D550", Offset = "0x250C950", VA = "0x18250D550")]
	public static MethodInfo ACIEBLJILEP<T, TR>(Expression<Func<T, TR>> CENNDBAMLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x250D550", Offset = "0x250C950", VA = "0x18250D550")]
	public static MethodInfo ACIEBLJILEP<T>(Expression<Action<T>> CENNDBAMLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x250D550", Offset = "0x250C950", VA = "0x18250D550")]
	public static MethodInfo ACIEBLJILEP<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> CENNDBAMLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x250D600", Offset = "0x250CA00", VA = "0x18250D600")]
	private static MemberInfo OMDNHJOANLJ<T>(Expression<T> OAGNBNMPALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x250D560", Offset = "0x250C960", VA = "0x18250D560")]
	public static PropertyInfo LEGKOJJCNMD<T, TR>(Expression<Func<T, TR>> CENNDBAMLKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct NKNIMIIOBJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int KEFLNPGBJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool BNGPBOIPHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator GONJEFKIKEL;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x63C35B0", Offset = "0x63C29B0", VA = "0x1863C35B0")]
	public NKNIMIIOBJC(ILGenerator GONJEFKIKEL, int KEFLNPGBJEJ, bool BNGPBOIPHCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x63C3520", Offset = "0x63C2920", VA = "0x1863C3520")]
	public NKNIMIIOBJC(ILGenerator GONJEFKIKEL, int KEFLNPGBJEJ, Type IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x63C3420", Offset = "0x63C2820", VA = "0x1863C3420")]
	public void LEHEKEIDOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class MPBMCHKFLIP
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x63C2CB0", Offset = "0x63C20B0", VA = "0x1863C2CB0")]
	public static void OLFPKGMKBKI(this ILGenerator GONJEFKIKEL, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x63C2C70", Offset = "0x63C2070", VA = "0x1863C2C70")]
	public static void OLFPKGMKBKI(this ILGenerator GONJEFKIKEL, LocalBuilder KCJADLENEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x63C31F0", Offset = "0x63C25F0", VA = "0x1863C31F0")]
	public static void PNCPINCPKOA(this ILGenerator GONJEFKIKEL, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x63C33E0", Offset = "0x63C27E0", VA = "0x1863C33E0")]
	public static void PNCPINCPKOA(this ILGenerator GONJEFKIKEL, LocalBuilder KCJADLENEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x63C2EA0", Offset = "0x63C22A0", VA = "0x1863C2EA0")]
	public static void PAEBOBCBMIJ(this ILGenerator GONJEFKIKEL, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x63C2F80", Offset = "0x63C2380", VA = "0x1863C2F80")]
	public static void PAEBOBCBMIJ(this ILGenerator GONJEFKIKEL, LocalBuilder KCJADLENEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x63C2520", Offset = "0x63C1920", VA = "0x1863C2520")]
	public static void LIGEFMNODLO(this ILGenerator GONJEFKIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x63C25B0", Offset = "0x63C19B0", VA = "0x1863C25B0")]
	public static void MCKBFIKLEFL(this ILGenerator GONJEFKIKEL, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63C25C0", Offset = "0x63C19C0", VA = "0x1863C25C0")]
	public static void MFIIDNJLIJE(this ILGenerator GONJEFKIKEL, int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x63C29A0", Offset = "0x63C1DA0", VA = "0x1863C29A0")]
	public static void NBNDMBAGAAO(this ILGenerator GONJEFKIKEL, Type IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x63C2480", Offset = "0x63C1880", VA = "0x1863C2480")]
	public static void JFDFLEKCLOL(this ILGenerator GONJEFKIKEL, Type IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x63C2A80", Offset = "0x63C1E80", VA = "0x1863C2A80")]
	public static void OJDOOBPNNNP(this ILGenerator GONJEFKIKEL, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x63C2530", Offset = "0x63C1930", VA = "0x1863C2530")]
	public static void LNBMNJDLCKJ(this ILGenerator GONJEFKIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x63C3080", Offset = "0x63C2480", VA = "0x1863C3080")]
	public static void PFKONEGJGAK(this ILGenerator GONJEFKIKEL, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x63C2390", Offset = "0x63C1790", VA = "0x1863C2390")]
	public static void EOMFGEAJMND(this ILGenerator GONJEFKIKEL, MethodInfo GDNNMEAGABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x63C2300", Offset = "0x63C1700", VA = "0x1863C2300")]
	public static void BHNIDLOEDMK(this ILGenerator GONJEFKIKEL, FieldInfo GJLKPMBPEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x63C3160", Offset = "0x63C2560", VA = "0x1863C3160")]
	public static void PLFACIGHMAJ(this ILGenerator GONJEFKIKEL, ulong EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class POBOHNMBLMA
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class DLCJLPBPGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public DLCJLPBPGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x63B8060", Offset = "0x63B7460", VA = "0x1863B8060")]
		internal bool EDDOOPNEGKH(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo LIOFKBOJDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo PPGALGBMPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string HACKGMPIPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MLFJDDCMOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x63C83F0", Offset = "0x63C77F0", VA = "0x1863C83F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NBFCBOEMNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x75C550", Offset = "0x75B950", VA = "0x18075C550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x75C570", Offset = "0x75B970", VA = "0x18075C570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BPDOAKOGKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB0A0", Offset = "0x7FA4A0", VA = "0x1807FB0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type EANPJBEPKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DLPHMJOLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo BDMIKNCOKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo PAMOLKBHJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x764B70", Offset = "0x763F70", VA = "0x180764B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C0", Offset = "0x75BBC0", VA = "0x18075C7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63C8700", Offset = "0x63C7B00", VA = "0x1863C8700")]
	protected POBOHNMBLMA(Type IJFAMCPOKBO, string LFAIHEECJFK, string OAJCGJIKNIK, bool OGOFGNNGNFG, bool OBIHEIJLBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63C8780", Offset = "0x63C7B80", VA = "0x1863C8780")]
	public POBOHNMBLMA(FieldInfo BCOICEBLMNF, string LFAIHEECJFK, bool DCMILHHHDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63C8890", Offset = "0x63C7C90", VA = "0x1863C8890")]
	public POBOHNMBLMA(PropertyInfo BCOICEBLMNF, string LFAIHEECJFK, bool DCMILHHHDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63C8280", Offset = "0x63C7680", VA = "0x1863C8280")]
	private static MethodInfo BAKKILHBEGA(MemberInfo BCOICEBLMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2512DF0", Offset = "0x25121F0", VA = "0x182512DF0")]
	public T BDCDDIOBFFC<T>(bool CHIOCJLNENO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63C8400", Offset = "0x63C7800", VA = "0x1863C8400", Slot = "4")]
	public virtual void EJCPPEIBFDI(ILGenerator GONJEFKIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63C8580", Offset = "0x63C7980", VA = "0x1863C8580", Slot = "5")]
	public virtual void NOJCKFHDJBJ(ILGenerator GONJEFKIKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class OCBAIJFAFIA : POBOHNMBLMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string EAJBPKHIMMA;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x63C5DB0", Offset = "0x63C51B0", VA = "0x1863C5DB0")]
	public OCBAIJFAFIA(string LFAIHEECJFK, string EAJBPKHIMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x63C5CB0", Offset = "0x63C50B0", VA = "0x1863C5CB0", Slot = "4")]
	public override void EJCPPEIBFDI(ILGenerator GONJEFKIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x63C5D60", Offset = "0x63C5160", VA = "0x1863C5D60", Slot = "5")]
	public override void NOJCKFHDJBJ(ILGenerator GONJEFKIKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class BDAGOPOMAPP : POBOHNMBLMA
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo MMIPPGOLNLJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo ONMNGGGPEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal NKNIMIIOBJC POOLMKGMCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal NKNIMIIOBJC OIHNIOLBANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal NKNIMIIOBJC JMKGKGDFKPM;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x63B4DD0", Offset = "0x63B41D0", VA = "0x1863B4DD0")]
	public BDAGOPOMAPP(string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x63B45F0", Offset = "0x63B39F0", VA = "0x1863B45F0", Slot = "4")]
	public override void EJCPPEIBFDI(ILGenerator GONJEFKIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x63B46B0", Offset = "0x63B3AB0", VA = "0x1863B46B0", Slot = "5")]
	public override void NOJCKFHDJBJ(ILGenerator GONJEFKIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x63B4700", Offset = "0x63B3B00", VA = "0x1863B4700")]
	public void ONAJHMGFOMI(ILGenerator GONJEFKIKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class FIPNPEHOIPM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type EANPJBEPKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FJBCODDFBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x763C70", Offset = "0x763070", VA = "0x180763C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FGHFHJDGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B80", Offset = "0x7F3F80", VA = "0x1807F4B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7F48A0", Offset = "0x7F3CA0", VA = "0x1807F48A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NIPBGINHFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public POBOHNMBLMA[] CIBCNEANKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public POBOHNMBLMA[] GEIEGGEAAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x63BA7B0", Offset = "0x63B9BB0", VA = "0x1863BA7B0")]
	public FIPNPEHOIPM(Type IJFAMCPOKBO, Func<string, string> FEKAFCPGEFI, bool DCMILHHHDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x63BA6D0", Offset = "0x63B9AD0", VA = "0x1863BA6D0")]
	private static bool IDCCLLPMGON(IEnumerator<ConstructorInfo> IMKOPPEDKFD, ConstructorInfo GLMBGDADCDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct EOIKABFCHBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong JKHIFGJJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int LCLIHGHPJEH;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1C7AC30", Offset = "0x1C7A030", VA = "0x181C7AC30")]
	public EOIKABFCHBH(ulong ANNEMGBACPN, int JDADCJHGNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63B9D40", Offset = "0x63B9140", VA = "0x1863B9D40")]
	public void OEOEGGIAKGA(EOIKABFCHBH LJIBJAOOGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x63B9B70", Offset = "0x63B8F70", VA = "0x1863B9B70")]
	public static EOIKABFCHBH AHJOFDIAOOO(EOIKABFCHBH IFAOGMEBPFN, EOIKABFCHBH DNPBOPMFFFF)
	{
		return default(EOIKABFCHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x63B9C20", Offset = "0x63B9020", VA = "0x1863B9C20")]
	public void MGHGHAHFOGE(EOIKABFCHBH LJIBJAOOGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x63B9B80", Offset = "0x63B8F80", VA = "0x1863B9B80")]
	public static EOIKABFCHBH LACJOALHBIM(EOIKABFCHBH IFAOGMEBPFN, EOIKABFCHBH DNPBOPMFFFF)
	{
		return default(EOIKABFCHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63B9D00", Offset = "0x63B9100", VA = "0x1863B9D00")]
	public void NOJMMLGICLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63B9CB0", Offset = "0x63B90B0", VA = "0x1863B9CB0")]
	public static EOIKABFCHBH NOJMMLGICLF(EOIKABFCHBH IFAOGMEBPFN)
	{
		return default(EOIKABFCHBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct LICJFFNNGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] FNCIFBBDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int APBJNEFOGOC;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x168FAE0", Offset = "0x168EEE0", VA = "0x18168FAE0")]
	public LICJFFNNGPM(byte[] FNCIFBBDALE, int LPAPEIIOLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x639B730", Offset = "0x639AB30", VA = "0x18639B730")]
	public void DMENCMJMHPC(byte JPCPLJECFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63C1180", Offset = "0x63C0580", VA = "0x1863C1180")]
	public void OKONIAKKKMI(byte[] JPCPLJECFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63C1060", Offset = "0x63C0460", VA = "0x1863C1060")]
	public void MJCFEPAJDAE(byte[] JPCPLJECFKH, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63C10E0", Offset = "0x63C04E0", VA = "0x1863C10E0")]
	public void MJCFEPAJDAE(byte[] JPCPLJECFKH, int NBBMHNNJHFB, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63C0EE0", Offset = "0x63C02E0", VA = "0x1863C0EE0")]
	public void DLAPJNCDOMK(byte AGEAOGKCCKA, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x63C0F60", Offset = "0x63C0360", VA = "0x1863C0F60")]
	public void EPJAFPFCLGD(string JPCPLJECFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class BAHKONFEJOE
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum HMBDHAPDMEH
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum BHCKNDFAMAI
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum IJJNPIMGMLN
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
	private static byte[] LIKGCIEIAHO;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] BCIDBFDCJJF;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] CGIJOFNPBIK;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] PCCDPLAEFKB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly IJJNPIMGMLN NAJCIHCGFPJ;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char ABGCCMICKLE;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int BOHFFJFKJMI;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int JMGLELHBNDG;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] PCIBOLMGMHM;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x63B3D50", Offset = "0x63B3150", VA = "0x1863B3D50")]
	private static byte[] OMHLIKPNOEG(int DAIAAPJIJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x63B31A0", Offset = "0x63B25A0", VA = "0x1863B31A0")]
	private static byte[] GLGMEHFNKIA(int DAIAAPJIJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x63B2F60", Offset = "0x63B2360", VA = "0x1863B2F60")]
	public static int GJJPBIBCIPK(byte[] FNCIFBBDALE, int APBJNEFOGOC, float EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x63B3080", Offset = "0x63B2480", VA = "0x1863B3080")]
	public static int GJJPBIBCIPK(byte[] FNCIFBBDALE, int APBJNEFOGOC, double EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63B3280", Offset = "0x63B2680", VA = "0x1863B3280")]
	private static bool HOAPJPFIGIB(byte[] FNCIFBBDALE, int KIHHOMBMMEI, ulong ANCHJIENEOA, ulong GIBLMENKHON, ulong OJGFPGIPHAO, ulong PCOBBGAOFOL, ulong DMLJILOBCCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x63B2E70", Offset = "0x63B2270", VA = "0x1863B2E70")]
	private static void FJGMOKLMLIB(uint IHAFLCFFDDD, int EGKKMCNDHNO, [Out] uint IMJFAJBHIAP, [Out] int BJEOLNNBLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x63B3370", Offset = "0x63B2770", VA = "0x1863B3370")]
	private static bool KIECCCIJLGJ(EOIKABFCHBH FBLPNCNECBD, EOIKABFCHBH JMLFIKJGAAF, EOIKABFCHBH DLMOBDCFEML, byte[] FNCIFBBDALE, [Out] int KIHHOMBMMEI, [Out] int FGEIEAFBHLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x63B2820", Offset = "0x63B1C20", VA = "0x1863B2820")]
	private static bool COIFEDKCOME(double DOJLNGFBAAB, HMBDHAPDMEH DGDIMEGBJJP, byte[] FNCIFBBDALE, [Out] int KIHHOMBMMEI, [Out] int CPLIMDLFAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x63B3C40", Offset = "0x63B3040", VA = "0x1863B3C40")]
	private static bool LFFBFGEDMFP(double DOJLNGFBAAB, HMBDHAPDMEH DGDIMEGBJJP, byte[] FNCIFBBDALE, [Out] int KIHHOMBMMEI, [Out] int JOGHHHAGLAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x63B2CA0", Offset = "0x63B20A0", VA = "0x1863B2CA0")]
	private static bool DMKAPGEHMAD(double EOHMJBFGDPD, LICJFFNNGPM OMNANKNOOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x63B3760", Offset = "0x63B2B60", VA = "0x1863B3760")]
	private static bool KLMKDMGCPLO(double EOHMJBFGDPD, LICJFFNNGPM OMNANKNOOLE, BHCKNDFAMAI DGDIMEGBJJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x63B3E20", Offset = "0x63B3220", VA = "0x1863B3E20")]
	private static void PBJBPEDEIMM(byte[] DEDDCIIMNMO, int KIHHOMBMMEI, int JOGHHHAGLAG, int HBHHIOHFGEM, LICJFFNNGPM OMNANKNOOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x63B23F0", Offset = "0x63B17F0", VA = "0x1863B23F0")]
	private static void AHEABLEFJJP(byte[] DEDDCIIMNMO, int KIHHOMBMMEI, int JDADCJHGNME, LICJFFNNGPM OMNANKNOOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x63B41B0", Offset = "0x63B35B0", VA = "0x1863B41B0")]
	private static bool PCFNDDBMMKD(double DOJLNGFBAAB, BHCKNDFAMAI DGDIMEGBJJP, int KODLGJBKODB, byte[] NCJNPFGDEGL, [Out] bool LCNKCNOHEDE, [Out] int KIHHOMBMMEI, [Out] int GKDNLKGKKGN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct CJOIMCGPNKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double EGKDMEOOPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong DAGLDJLGPOO;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct KGLOHIHPHHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float JKHIFGJJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint BNDMANCGPJC;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct MMDNKIPJIKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong NEBGFPNBJHF;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x63C20E0", Offset = "0x63C14E0", VA = "0x1863C20E0")]
	public MMDNKIPJIKM(double EGKDMEOOPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x63C2040", Offset = "0x63C1440", VA = "0x1863C2040")]
	public MMDNKIPJIKM(EOIKABFCHBH EGKDMEOOPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x63C1D50", Offset = "0x63C1150", VA = "0x1863C1D50")]
	public EOIKABFCHBH FEBKHHJPDEO()
	{
		return default(EOIKABFCHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x63C1C30", Offset = "0x63C1030", VA = "0x1863C1C30")]
	public EOIKABFCHBH ENJIHLMDFPJ()
	{
		return default(EOIKABFCHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public ulong LKNLMEGFJKK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x63C1AB0", Offset = "0x63C0EB0", VA = "0x1863C1AB0")]
	public double ABIIEOKOGCK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x63C1CB0", Offset = "0x63C10B0", VA = "0x1863C1CB0")]
	public double FCOOFJEHLJC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x63C1E70", Offset = "0x63C1270", VA = "0x1863C1E70")]
	public int PIJCKOIDAIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x63C1B50", Offset = "0x63C0F50", VA = "0x1863C1B50")]
	public ulong AKCIKNDLMLF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63C1DC0", Offset = "0x63C11C0", VA = "0x1863C1DC0")]
	public bool KIADGPDGIHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x63C1EA0", Offset = "0x63C12A0", VA = "0x1863C1EA0")]
	public bool PMBILPEOHLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x63C2010", Offset = "0x63C1410", VA = "0x1863C2010")]
	public bool PPJICOFLLOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x63C1BF0", Offset = "0x63C0FF0", VA = "0x1863C1BF0")]
	public bool CGDALPOIMMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x63C1BD0", Offset = "0x63C0FD0", VA = "0x1863C1BD0")]
	public int ALFPBNPJAOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x63C1EC0", Offset = "0x63C12C0", VA = "0x1863C1EC0")]
	public void POLMDNNFFGL([Out] EOIKABFCHBH NPKMINPAHAN, [Out] EOIKABFCHBH LGHGMEPLOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x63C1B80", Offset = "0x63C0F80", VA = "0x1863C1B80")]
	public bool AKJIFIMHAFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2978CB0", Offset = "0x29780B0", VA = "0x182978CB0")]
	public double EOHMJBFGDPD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x63C1B30", Offset = "0x63C0F30", VA = "0x1863C1B30")]
	public static int AEKBFNGLKNA(int KKPFCFMEHIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63C1C20", Offset = "0x63C1020", VA = "0x1863C1C20")]
	public static double DGAMGEPCJGE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63C1DE0", Offset = "0x63C11E0", VA = "0x1863C1DE0")]
	public static ulong MECHAHHAOCA(EOIKABFCHBH HNFNBCMCMGN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct MOKPJPNDDOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint LNNODMLGGHG;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F364C0", Offset = "0x1F358C0", VA = "0x181F364C0")]
	public MOKPJPNDDOC(float JKHIFGJJLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63C2150", Offset = "0x63C1550", VA = "0x1863C2150")]
	public EOIKABFCHBH FEBKHHJPDEO()
	{
		return default(EOIKABFCHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
	public uint GKIMIKGOPDP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63C21B0", Offset = "0x63C15B0", VA = "0x1863C21B0")]
	public int PIJCKOIDAIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63C20F0", Offset = "0x63C14F0", VA = "0x1863C20F0")]
	public uint AKCIKNDLMLF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63C21A0", Offset = "0x63C15A0", VA = "0x1863C21A0")]
	public bool KIADGPDGIHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63C21D0", Offset = "0x63C15D0", VA = "0x1863C21D0")]
	public void POLMDNNFFGL([Out] EOIKABFCHBH NPKMINPAHAN, [Out] EOIKABFCHBH LGHGMEPLOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63C2110", Offset = "0x63C1510", VA = "0x1863C2110")]
	public bool AKJIFIMHAFI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct CCILJCHILOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong ANNEMGBACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short HFJFMDHNPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short CPLIMDLFAEF;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x63B70D0", Offset = "0x63B64D0", VA = "0x1863B70D0")]
	public CCILJCHILOP(ulong ANNEMGBACPN, short HFJFMDHNPPJ, short CPLIMDLFAEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class KPNCOJBFBNM
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly CCILJCHILOP[] DBLBPCOILAM;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x63BFCF0", Offset = "0x63BF0F0", VA = "0x1863BFCF0")]
	public static void IKEFPDLNOIJ(int NGBCMIBDOME, int DJGEAFABLNC, [Out] EOIKABFCHBH IMJFAJBHIAP, [Out] int CPLIMDLFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x63BFC20", Offset = "0x63BF020", VA = "0x1863BFC20")]
	public static void BDFPHLGBHMD(int JHLEFOMMHNH, [Out] EOIKABFCHBH IMJFAJBHIAP, [Out] int PKADJHMFIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct FOKDPLEPNND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] HPOLMACFBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int NBBMHNNJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int ALPIIFLHOGE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x63BBD00", Offset = "0x63BB100", VA = "0x1863BBD00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x34CBBF0", Offset = "0x34CAFF0", VA = "0x1834CBBF0")]
	public FOKDPLEPNND(byte[] HPOLMACFBHD, int NBBMHNNJHFB, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F713A0", Offset = "0x1F707A0", VA = "0x181F713A0")]
	public int KIHHOMBMMEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x63BBD40", Offset = "0x63BB140", VA = "0x1863BBD40")]
	public FOKDPLEPNND IKCFPPNHBKB(int IJKBDHBGLAG, int MMKIEIGFJGA)
	{
		return default(FOKDPLEPNND);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class BGEEJKFONHO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] EEJLOODMKBK;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] ENMDIIKHIHK;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int DGEDNNGNGCM;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x63B6430", Offset = "0x63B5830", VA = "0x1863B6430")]
	private static byte[] HBCMIMDHCHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x63B5CC0", Offset = "0x63B50C0", VA = "0x1863B5CC0")]
	private static FOKDPLEPNND EOBHPKIAOAC(FOKDPLEPNND FNCIFBBDALE)
	{
		return default(FOKDPLEPNND);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x63B5A10", Offset = "0x63B4E10", VA = "0x1863B5A10")]
	private static FOKDPLEPNND COFDGBAHOMG(FOKDPLEPNND FNCIFBBDALE)
	{
		return default(FOKDPLEPNND);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63B6920", Offset = "0x63B5D20", VA = "0x1863B6920")]
	private static void KDLLHAHCHKE(FOKDPLEPNND FNCIFBBDALE, int JDADCJHGNME, byte[] LPPBPIOGFGD, [Out] int PBPFICHKJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x63B6510", Offset = "0x63B5910", VA = "0x1863B6510")]
	private static void HGBAJJNLALN(FOKDPLEPNND FNCIFBBDALE, int JDADCJHGNME, byte[] OEOCMEELPKL, int POBCCNHDCKE, [Out] FOKDPLEPNND MFHAFLOBAEC, [Out] int HEAEFMJBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x63B5C30", Offset = "0x63B5030", VA = "0x1863B5C30")]
	private static ulong EKAEHFGHNJC(FOKDPLEPNND FNCIFBBDALE, [Out] int LKKHEDLFJKH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x63B5AF0", Offset = "0x63B4EF0", VA = "0x1863B5AF0")]
	private static void DGBBEKKNJCC(FOKDPLEPNND FNCIFBBDALE, [Out] EOIKABFCHBH KNLODAPAGGH, [Out] int HEMNBPLKMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x63B6060", Offset = "0x63B5460", VA = "0x1863B6060")]
	private static bool GPKPAHECNBB(FOKDPLEPNND MFHAFLOBAEC, int JDADCJHGNME, [Out] double KNLODAPAGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x63B5DA0", Offset = "0x63B51A0", VA = "0x1863B5DA0")]
	private static EOIKABFCHBH FCKLDOLOMJH(int JDADCJHGNME)
	{
		return default(EOIKABFCHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x63B53C0", Offset = "0x63B47C0", VA = "0x1863B53C0")]
	private static bool BKCBJADJIAO(FOKDPLEPNND FNCIFBBDALE, int JDADCJHGNME, [Out] double KNLODAPAGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x63B6800", Offset = "0x63B5C00", VA = "0x1863B6800")]
	private static bool JDIEOBHLHFJ(FOKDPLEPNND MFHAFLOBAEC, int JDADCJHGNME, [Out] double IIEEOAGABHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x63B5F40", Offset = "0x63B5340", VA = "0x1863B5F40")]
	public static double? GKMCNKGNENP(FOKDPLEPNND FNCIFBBDALE, int JDADCJHGNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x63B69B0", Offset = "0x63B5DB0", VA = "0x1863B69B0")]
	public static float? MIKNMBMOGJM(FOKDPLEPNND FNCIFBBDALE, int JDADCJHGNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct HKFOLCPBCEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] FNCIFBBDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int APBJNEFOGOC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte DFNAILAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x63D2250", Offset = "0x63D1650", VA = "0x1863D2250")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x168FAE0", Offset = "0x168EEE0", VA = "0x18168FAE0")]
	public HKFOLCPBCEK(byte[] FNCIFBBDALE, int APBJNEFOGOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x63D23B0", Offset = "0x63D17B0", VA = "0x1863D23B0")]
	public static HKFOLCPBCEK OBMIKKBLEOH(HKFOLCPBCEK LDMHFMNLDHG)
	{
		return default(HKFOLCPBCEK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x63D22F0", Offset = "0x63D16F0", VA = "0x1863D22F0")]
	public static HKFOLCPBCEK GCOIEPKDLBA(HKFOLCPBCEK LDMHFMNLDHG, int KIHHOMBMMEI)
	{
		return default(HKFOLCPBCEK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x63D2280", Offset = "0x63D1680", VA = "0x1863D2280")]
	public static int ENANMENLKEG(HKFOLCPBCEK IBOMHLKOLJB, HKFOLCPBCEK FFDHLLBEMJM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63D2340", Offset = "0x63D1740", VA = "0x1863D2340")]
	public static bool MEMFAJGIIAO(HKFOLCPBCEK IBOMHLKOLJB, HKFOLCPBCEK FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63D23F0", Offset = "0x63D17F0", VA = "0x1863D23F0")]
	public static bool OPPLDLMADNB(HKFOLCPBCEK IBOMHLKOLJB, HKFOLCPBCEK FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x63D2350", Offset = "0x63D1750", VA = "0x1863D2350")]
	public static bool MEMFAJGIIAO(HKFOLCPBCEK IBOMHLKOLJB, char FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x63D23C0", Offset = "0x63D17C0", VA = "0x1863D23C0")]
	public static bool OPPLDLMADNB(HKFOLCPBCEK IBOMHLKOLJB, char FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x63D23C0", Offset = "0x63D17C0", VA = "0x1863D23C0")]
	public static bool OPPLDLMADNB(HKFOLCPBCEK IBOMHLKOLJB, byte FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x63D22C0", Offset = "0x63D16C0", VA = "0x1863D22C0")]
	public static bool FONDMOFOMPL(HKFOLCPBCEK IBOMHLKOLJB, char FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x63D2380", Offset = "0x63D1780", VA = "0x1863D2380")]
	public static bool NKLANPCKALA(HKFOLCPBCEK IBOMHLKOLJB, char FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x63D2290", Offset = "0x63D1690", VA = "0x1863D2290")]
	public static bool ENCDNLKMEAI(HKFOLCPBCEK IBOMHLKOLJB, char FFDHLLBEMJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x63D2220", Offset = "0x63D1620", VA = "0x1863D2220")]
	public static bool CMEODJGKLKN(HKFOLCPBCEK IBOMHLKOLJB, char FFDHLLBEMJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class BIECBEFFJAM
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] IHDJOJLMLFH;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] OANKABFLEEG;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] CGIJOFNPBIK;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] PCCDPLAEFKB;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] JMGGLJAPKEO;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int OKCCOHFFNCG;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] LIEFPAHJJIH;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int PALBCIPGOFO;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x63CBBD0", Offset = "0x63CAFD0", VA = "0x1863CBBD0")]
	private static byte[] MEGHMMOIPCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x63CBA40", Offset = "0x63CAE40", VA = "0x1863CBA40")]
	private static byte[] KJOEHLHJKMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x63CBB20", Offset = "0x63CAF20", VA = "0x1863CBB20")]
	public static double LBEKEIDBPEB(byte[] FNCIFBBDALE, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x63CBCB0", Offset = "0x63CB0B0", VA = "0x1863CBCB0")]
	public static float PACEAJOEBCD(byte[] FNCIFBBDALE, int APBJNEFOGOC, [Out] int OCNBCMFPBAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x63CA890", Offset = "0x63C9C90", VA = "0x1863CA890")]
	private static bool GLCFNPJGDMG(int MHJJOHHKIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x63CA9D0", Offset = "0x63C9DD0", VA = "0x1863CA9D0")]
	private static bool IBCDMONGHIK(HKFOLCPBCEK OJIAHHODKNI, HKFOLCPBCEK ICPDBPOHHIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x63CBD60", Offset = "0x63CB160", VA = "0x1863CBD60")]
	private static bool PLGEPIKAHHN(HKFOLCPBCEK OJIAHHODKNI, HKFOLCPBCEK ICPDBPOHHIC, byte[] FGLPECHBOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x63CA820", Offset = "0x63C9C20", VA = "0x1863CA820")]
	private static bool DIIADBBLENP(HKFOLCPBCEK CNONOHOIFCB, byte[] JPCPLJECFKH, int APBJNEFOGOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x63CA870", Offset = "0x63C9C70", VA = "0x1863CA870")]
	private static double EBDCBJJDFBK(bool LCNKCNOHEDE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x63CABC0", Offset = "0x63C9FC0", VA = "0x1863CABC0")]
	private static double KDBLCECLMPA(HKFOLCPBCEK CEPHEIEJHPL, int KIHHOMBMMEI, bool NPDPEDEBPKC, [Out] int NHHLFHOALEH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class GEGHDIJMNPO<T> : ALMAJBDDDKL<T[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly MIJEJKKHCBG<T> JABCNJJOCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly JGJCFEAGLOM OILDPBKOOKN;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x33EC3C0", Offset = "0x33EB7C0", VA = "0x1833EC3C0")]
	public GEGHDIJMNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
	public GEGHDIJMNPO(JGJCFEAGLOM OILDPBKOOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x34BBA90", Offset = "0x34BAE90", VA = "0x1834BBA90", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x34B9130", Offset = "0x34B8530", VA = "0x1834B9130", Slot = "5")]
	public T[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class ONNNDDKAIBF<T> : ALMAJBDDDKL<ArraySegment<T>>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly MIJEJKKHCBG<T> JABCNJJOCDH;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3D070D0", Offset = "0x3D064D0", VA = "0x183D070D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ArraySegment<T> EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3D06CB0", Offset = "0x3D060B0", VA = "0x183D06CB0", Slot = "5")]
	public ArraySegment<T> ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class OPMHIHIPJKC<T> : ALMAJBDDDKL<List<T>>, BJHFEJJJBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly JGJCFEAGLOM OILDPBKOOKN;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x33EC3C0", Offset = "0x33EB7C0", VA = "0x1833EC3C0")]
	public OPMHIHIPJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
	public OPMHIHIPJKC(JGJCFEAGLOM OILDPBKOOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3D14A90", Offset = "0x3D13E90", VA = "0x183D14A90", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, List<T> EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3D10A40", Offset = "0x3D0FE40", VA = "0x183D10A40", Slot = "5")]
	public List<T> ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class JDDNACMJODC<TElement, TIntermediate, TEnumerator, TCollection> : ALMAJBDDDKL<TCollection>, BJHFEJJJBKA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x38340D0", Offset = "0x38334D0", VA = "0x1838340D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, TCollection EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x38335C0", Offset = "0x38329C0", VA = "0x1838335C0", Slot = "5")]
	public TCollection ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator IONONEFNCAN(TCollection OAGNBNMPALP);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EECJKDKEFDC();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void INMJBKGEACO(TIntermediate EHLLEAGNEMN, int APOENOPNHBG, TElement EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection GPDBOMJNGBN(TIntermediate NDFCEDCIAHO);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected JDDNACMJODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GLEAOEIJDPP<TElement, TIntermediate, TCollection> : JDDNACMJODC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x34D5590", Offset = "0x34D4990", VA = "0x1834D5590", Slot = "6")]
	protected override IEnumerator<TElement> IONONEFNCAN(TCollection OAGNBNMPALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3014610", Offset = "0x3013A10", VA = "0x183014610")]
	protected GLEAOEIJDPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class FCACKHILJMK<TElement, TCollection> : GLEAOEIJDPP<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected sealed override TCollection GPDBOMJNGBN(TCollection NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class AAFJKKCEEJO<TElement, TCollection> : FCACKHILJMK<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3450770", Offset = "0x344FB70", VA = "0x183450770", Slot = "7")]
	protected override TCollection EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x34507A0", Offset = "0x344FBA0", VA = "0x1834507A0", Slot = "8")]
	protected override void INMJBKGEACO(TCollection EHLLEAGNEMN, int APOENOPNHBG, TElement EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class FPFELHPPJLB<T> : JDDNACMJODC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x30834E0", Offset = "0x30828E0", VA = "0x1830834E0", Slot = "8")]
	protected override void INMJBKGEACO(LinkedList<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override LinkedList<T> GPDBOMJNGBN(LinkedList<T> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override LinkedList<T> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x33F1DA0", Offset = "0x33F11A0", VA = "0x1833F1DA0", Slot = "6")]
	protected override LinkedList<T>.Enumerator IONONEFNCAN(LinkedList<T> OAGNBNMPALP)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class ENAKAOACIBG<T> : JDDNACMJODC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x30834E0", Offset = "0x30828E0", VA = "0x1830834E0", Slot = "8")]
	protected override void INMJBKGEACO(Queue<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override Queue<T> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3083520", Offset = "0x3082920", VA = "0x183083520", Slot = "6")]
	protected override Queue<T>.Enumerator IONONEFNCAN(Queue<T> OAGNBNMPALP)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override Queue<T> GPDBOMJNGBN(Queue<T> NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class GIFIOJGCGOJ<T> : JDDNACMJODC<T, FHKIJPJMCKG<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x303D550", Offset = "0x303C950", VA = "0x18303D550", Slot = "8")]
	protected override void INMJBKGEACO(FHKIJPJMCKG<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x303D4F0", Offset = "0x303C8F0", VA = "0x18303D4F0", Slot = "7")]
	protected override FHKIJPJMCKG<T> EECJKDKEFDC()
	{
		return default(FHKIJPJMCKG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x34C52E0", Offset = "0x34C46E0", VA = "0x1834C52E0", Slot = "6")]
	protected override Stack<T>.Enumerator IONONEFNCAN(Stack<T> OAGNBNMPALP)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x34C5200", Offset = "0x34C4600", VA = "0x1834C5200", Slot = "9")]
	protected override Stack<T> GPDBOMJNGBN(FHKIJPJMCKG<T> NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class ENPGLKHJOPC<T> : JDDNACMJODC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x30834E0", Offset = "0x30828E0", VA = "0x1830834E0", Slot = "8")]
	protected override void INMJBKGEACO(HashSet<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override HashSet<T> GPDBOMJNGBN(HashSet<T> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override HashSet<T> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3083520", Offset = "0x3082920", VA = "0x183083520", Slot = "6")]
	protected override HashSet<T>.Enumerator IONONEFNCAN(HashSet<T> OAGNBNMPALP)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CACIPJJOKFH<T> : GLEAOEIJDPP<T, FHKIJPJMCKG<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x303D550", Offset = "0x303C950", VA = "0x18303D550", Slot = "8")]
	protected override void INMJBKGEACO(FHKIJPJMCKG<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4A982F0", Offset = "0x4A976F0", VA = "0x184A982F0", Slot = "9")]
	protected override ReadOnlyCollection<T> GPDBOMJNGBN(FHKIJPJMCKG<T> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4A982B0", Offset = "0x4A976B0", VA = "0x184A982B0", Slot = "7")]
	protected override FHKIJPJMCKG<T> EECJKDKEFDC()
	{
		return default(FHKIJPJMCKG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MLEFPNIPJBL<T> : GLEAOEIJDPP<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x30834E0", Offset = "0x30828E0", VA = "0x1830834E0", Slot = "8")]
	protected override void INMJBKGEACO(List<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override List<T> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override IList<T> GPDBOMJNGBN(List<T> NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class KGAOMHHENJG<T> : GLEAOEIJDPP<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x30834E0", Offset = "0x30828E0", VA = "0x1830834E0", Slot = "8")]
	protected override void INMJBKGEACO(List<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override List<T> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override ICollection<T> GPDBOMJNGBN(List<T> NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class EECOMHGMLCJ<T> : GLEAOEIJDPP<T, FHKIJPJMCKG<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x303D550", Offset = "0x303C950", VA = "0x18303D550", Slot = "8")]
	protected override void INMJBKGEACO(FHKIJPJMCKG<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x303D4F0", Offset = "0x303C8F0", VA = "0x18303D4F0", Slot = "7")]
	protected override FHKIJPJMCKG<T> EECJKDKEFDC()
	{
		return default(FHKIJPJMCKG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x303D530", Offset = "0x303C930", VA = "0x18303D530", Slot = "9")]
	protected override IEnumerable<T> GPDBOMJNGBN(FHKIJPJMCKG<T> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3020900", Offset = "0x301FD00", VA = "0x183020900")]
	public EECOMHGMLCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class OFPGONIOPFN<TKey, TElement> : ALMAJBDDDKL<IGrouping<TKey, TElement>>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3CE61A0", Offset = "0x3CE55A0", VA = "0x183CE61A0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, IGrouping<TKey, TElement> EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5EA0", Offset = "0x3CE52A0", VA = "0x183CE5EA0", Slot = "5")]
	public IGrouping<TKey, TElement> ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class NOGDCOKEINH<TKey, TElement> : ALMAJBDDDKL<ILookup<TKey, TElement>>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3C364D0", Offset = "0x3C358D0", VA = "0x183C364D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ILookup<TKey, TElement> EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3C36180", Offset = "0x3C35580", VA = "0x183C36180", Slot = "5")]
	public ILookup<TKey, TElement> ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class KNDCBIHNIDH<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey DGCJCBHPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> DLBJPBJAFGL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey KHCAJFNIBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x76B3A0", Offset = "0x76A7A0", VA = "0x18076B3A0")]
	public KNDCBIHNIDH(TKey DGCJCBHPPBD, IEnumerable<TElement> DLBJPBJAFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x38FBE00", Offset = "0x38FB200", VA = "0x1838FBE00", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x30D3900", Offset = "0x30D2D00", VA = "0x1830D3900", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class PAEGBCGLKFM<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> MCKMHPGOPBL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x36325A0", Offset = "0x36319A0", VA = "0x1836325A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	public PAEGBCGLKFM(Dictionary<TKey, IGrouping<TKey, TElement>> MCKMHPGOPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DE90", Offset = "0x3D9D290", VA = "0x183D9DE90", Slot = "5")]
	public bool Contains(TKey DGCJCBHPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DED0", Offset = "0x3D9D2D0", VA = "0x183D9DED0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DED0", Offset = "0x3D9D2D0", VA = "0x183D9DED0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class EBJCCGDJFPJ<T> : ALMAJBDDDKL<T>, BJHFEJJJBKA where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x30317F0", Offset = "0x3030BF0", VA = "0x1830317F0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3031570", Offset = "0x3030970", VA = "0x183031570", Slot = "5")]
	public T ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EBJCCGDJFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class KLOGPBKDJMI : ALMAJBDDDKL<IEnumerable>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly ALMAJBDDDKL<IEnumerable> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x63D6A00", Offset = "0x63D5E00", VA = "0x1863D6A00", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, IEnumerable EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x63D67B0", Offset = "0x63D5BB0", VA = "0x1863D67B0", Slot = "5")]
	public IEnumerable ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KLOGPBKDJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class BHINLINHGGB : ALMAJBDDDKL<ICollection>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly ALMAJBDDDKL<ICollection> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63CA400", Offset = "0x63C9800", VA = "0x1863CA400", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ICollection EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x63CA1B0", Offset = "0x63C95B0", VA = "0x1863CA1B0", Slot = "5")]
	public ICollection ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BHINLINHGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class GODAFEOEAIH : ALMAJBDDDKL<IList>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly ALMAJBDDDKL<IList> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x63D12E0", Offset = "0x63D06E0", VA = "0x1863D12E0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, IList EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x63D1090", Offset = "0x63D0490", VA = "0x1863D1090", Slot = "5")]
	public IList ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GODAFEOEAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class JPFPFKBFJKP<T> : GLEAOEIJDPP<T, FHKIJPJMCKG<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x38667D0", Offset = "0x3865BD0", VA = "0x1838667D0", Slot = "8")]
	protected override void INMJBKGEACO(FHKIJPJMCKG<T> EHLLEAGNEMN, int APOENOPNHBG, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x303D4F0", Offset = "0x303C8F0", VA = "0x18303D4F0", Slot = "7")]
	protected override FHKIJPJMCKG<T> EECJKDKEFDC()
	{
		return default(FHKIJPJMCKG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3866750", Offset = "0x3865B50", VA = "0x183866750", Slot = "9")]
	protected override IReadOnlyList<T> GPDBOMJNGBN(FHKIJPJMCKG<T> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3020230", Offset = "0x301F630", VA = "0x183020230")]
	public JPFPFKBFJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class DCFIFBOHCOP
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x63CE920", Offset = "0x63CDD20", VA = "0x1863CE920")]
	public static DateTime KHHKEELPFOL(DateTime PGHAOJLEIBK)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class KPKKEPCNEGO : ALMAJBDDDKL<DateTime>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly ALMAJBDDDKL<DateTime> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x63D7A40", Offset = "0x63D6E40", VA = "0x1863D7A40", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, DateTime EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x63D6D30", Offset = "0x63D6130", VA = "0x1863D6D30", Slot = "5")]
	public DateTime ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KPKKEPCNEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class IBKCDDHMCGF : ALMAJBDDDKL<DateTimeOffset>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly ALMAJBDDDKL<DateTimeOffset> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x63D3360", Offset = "0x63D2760", VA = "0x1863D3360", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, DateTimeOffset EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x63D2740", Offset = "0x63D1B40", VA = "0x1863D2740", Slot = "5")]
	public DateTimeOffset ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IBKCDDHMCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class PIJBNGFCLFA : ALMAJBDDDKL<TimeSpan>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly ALMAJBDDDKL<TimeSpan> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] PCGNLDLNKFI;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x63DB660", Offset = "0x63DAA60", VA = "0x1863DB660", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, TimeSpan EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x63DAD50", Offset = "0x63DA150", VA = "0x1863DAD50", Slot = "5")]
	public TimeSpan ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public PIJBNGFCLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class CIAAOLFKLKK<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : ALMAJBDDDKL<TDictionary>, BJHFEJJJBKA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x4AD94A0", Offset = "0x4AD88A0", VA = "0x184AD94A0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, TDictionary EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x4AD75D0", Offset = "0x4AD69D0", VA = "0x184AD75D0", Slot = "5")]
	public TDictionary ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator IONONEFNCAN(TDictionary OAGNBNMPALP);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EECJKDKEFDC();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void INMJBKGEACO(TIntermediate EHLLEAGNEMN, int APOENOPNHBG, TKey DGCJCBHPPBD, TValue EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary GPDBOMJNGBN(TIntermediate NDFCEDCIAHO);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected CIAAOLFKLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class MIJCJJDHBOD<TKey, TValue, TIntermediate, TDictionary> : CIAAOLFKLKK<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x34D5590", Offset = "0x34D4990", VA = "0x1834D5590", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> IONONEFNCAN(TDictionary OAGNBNMPALP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class OHFOAAJKALP<TKey, TValue, TDictionary> : MIJCJJDHBOD<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override TDictionary GPDBOMJNGBN(TDictionary NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class GBJNKJPMHJL<TKey, TValue> : CIAAOLFKLKK<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x347FCD0", Offset = "0x347F0D0", VA = "0x18347FCD0", Slot = "8")]
	protected override void INMJBKGEACO(Dictionary<TKey, TValue> EHLLEAGNEMN, int APOENOPNHBG, TKey DGCJCBHPPBD, TValue EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override Dictionary<TKey, TValue> GPDBOMJNGBN(Dictionary<TKey, TValue> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override Dictionary<TKey, TValue> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x347FE00", Offset = "0x347F200", VA = "0x18347FE00", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator IONONEFNCAN(Dictionary<TKey, TValue> OAGNBNMPALP)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3013900", Offset = "0x3012D00", VA = "0x183013900")]
	public GBJNKJPMHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class DILFBGFIELC<TKey, TValue, TDictionary> : OHFOAAJKALP<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x4C945B0", Offset = "0x4C939B0", VA = "0x184C945B0", Slot = "8")]
	protected override void INMJBKGEACO(TDictionary EHLLEAGNEMN, int APOENOPNHBG, TKey DGCJCBHPPBD, TValue EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC010", Offset = "0x2EBB410", VA = "0x182EBC010", Slot = "7")]
	protected override TDictionary EECJKDKEFDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class CNENCOBGIJK<TKey, TValue> : MIJCJJDHBOD<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x347FD20", Offset = "0x347F120", VA = "0x18347FD20", Slot = "8")]
	protected override void INMJBKGEACO(Dictionary<TKey, TValue> EHLLEAGNEMN, int APOENOPNHBG, TKey DGCJCBHPPBD, TValue EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override Dictionary<TKey, TValue> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override IDictionary<TKey, TValue> GPDBOMJNGBN(Dictionary<TKey, TValue> NDFCEDCIAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class MHLFKMMOAIB<TKey, TValue> : OHFOAAJKALP<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x347FD20", Offset = "0x347F120", VA = "0x18347FD20", Slot = "8")]
	protected override void INMJBKGEACO(SortedList<TKey, TValue> EHLLEAGNEMN, int APOENOPNHBG, TKey DGCJCBHPPBD, TValue EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override SortedList<TKey, TValue> EECJKDKEFDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KAEBKHCDJCA<TKey, TValue> : CIAAOLFKLKK<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x347FD20", Offset = "0x347F120", VA = "0x18347FD20", Slot = "8")]
	protected override void INMJBKGEACO(SortedDictionary<TKey, TValue> EHLLEAGNEMN, int APOENOPNHBG, TKey DGCJCBHPPBD, TValue EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xC90800", Offset = "0xC8FC00", VA = "0x180C90800", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GPDBOMJNGBN(SortedDictionary<TKey, TValue> NDFCEDCIAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3083470", Offset = "0x3082870", VA = "0x183083470", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> EECJKDKEFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x347FE00", Offset = "0x347F200", VA = "0x18347FE00", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator IONONEFNCAN(SortedDictionary<TKey, TValue> OAGNBNMPALP)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class BHPNMAMBDKK<T> : ALMAJBDDDKL<T>, BJHFEJJJBKA where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x48402A0", Offset = "0x483F6A0", VA = "0x1848402A0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x4840000", Offset = "0x483F400", VA = "0x184840000", Slot = "5")]
	public T ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BHPNMAMBDKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class INPGDNJLNKP : ALMAJBDDDKL<IDictionary>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly ALMAJBDDDKL<IDictionary> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x63D51A0", Offset = "0x63D45A0", VA = "0x1863D51A0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, IDictionary EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x63D4F70", Offset = "0x63D4370", VA = "0x1863D4F70", Slot = "5")]
	public IDictionary ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public INPGDNJLNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class BCMICCHNPAM : ALMAJBDDDKL<object>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void JBOHFALJLLJ(object KINBOMGLADA, GBOIADKFEIJ MKIOBJMIBCN, object EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly EKAKOJENCJB<KeyValuePair<object, JBOHFALJLLJ>> IEGHBKFHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly NGDHCEEFPJP[] JHIGCPKECCK;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63C9D30", Offset = "0x63C9130", VA = "0x1863C9D30")]
	public BCMICCHNPAM(params NGDHCEEFPJP[] JHIGCPKECCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63C9370", Offset = "0x63C8770", VA = "0x1863C9370", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, object EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63C92E0", Offset = "0x63C86E0", VA = "0x1863C92E0", Slot = "5")]
	public object ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class BPNAPJAEMOI
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x63CC0E0", Offset = "0x63CB4E0", VA = "0x1863CC0E0")]
	public static object IJLAIDLJDPM(Type IJFAMCPOKBO, [Out] bool CKBHBEJDPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x63CC9D0", Offset = "0x63CBDD0", VA = "0x1863CC9D0")]
	public static object LIOFEMFDDIK(Type IJFAMCPOKBO, [Out] bool CKBHBEJDPGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class IMBBCGNIEGD<T> : ALMAJBDDDKL<T>, BJHFEJJJBKA, HOAAGFNPBME<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class DFJOHOHCJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public DFJOHOHCJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C88A40", Offset = "0x4C87E40", VA = "0x184C88A40")]
		internal bool OEMHNMHMLAF(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class CHOEHKABFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CHOEHKABFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4AD6AA0", Offset = "0x4AD5EA0", VA = "0x184AD6AA0")]
		internal bool PFBAHIBEMGP(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class NKGOBKMHJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public LGLADCNGEAE<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NKGOBKMHJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C13170", Offset = "0x3C12570", VA = "0x183C13170")]
		internal void LOACMMBFKED(GBOIADKFEIJ writer, T value, NGDHCEEFPJP _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class LHCBAGADECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public KOGAFGLOCED<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public LHCBAGADECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x397CE70", Offset = "0x397C270", VA = "0x18397CE70")]
		internal T BIJDMGEDMFF(GCKCGBHPHKM reader, NGDHCEEFPJP _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly ICNABOALJLG<T> BKCAKOBFKLL;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> DEOBKEPGPCL;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly LGLADCNGEAE<T> DAIIALADMHB;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly KOGAFGLOCED<T> DOIIMJLJDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool NAFCNLHDBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly LGLADCNGEAE<T> GNGGDHFBNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly KOGAFGLOCED<T> NJFKDNKJNBA;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3653E70", Offset = "0x3653270", VA = "0x183653E70")]
	static IMBBCGNIEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x365D160", Offset = "0x365C560", VA = "0x18365D160")]
	public IMBBCGNIEGD(bool NAFCNLHDBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x364E110", Offset = "0x364D510", VA = "0x18364E110", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x364CEB0", Offset = "0x364C2B0", VA = "0x18364CEB0", Slot = "5")]
	public T ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x364A9F0", Offset = "0x3649DF0", VA = "0x18364A9F0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, T EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x36496B0", Offset = "0x3648AB0", VA = "0x1836496B0", Slot = "7")]
	public T BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class FCLAPDONDNG<T> : ALMAJBDDDKL<T[,]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x33C1970", Offset = "0x33C0D70", VA = "0x1833C1970", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T[,] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x33C1640", Offset = "0x33C0A40", VA = "0x1833C1640", Slot = "5")]
	public T[,] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FCLAPDONDNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class LEPHBIBCKHC<T> : ALMAJBDDDKL<T[,,]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3977080", Offset = "0x3976480", VA = "0x183977080", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T[,,] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3976C40", Offset = "0x3976040", VA = "0x183976C40", Slot = "5")]
	public T[,,] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LEPHBIBCKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class AEDODKNBDEM<T> : ALMAJBDDDKL<T[,,,]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3486A90", Offset = "0x3485E90", VA = "0x183486A90", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T[,,,] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3486540", Offset = "0x3485940", VA = "0x183486540", Slot = "5")]
	public T[,,,] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public AEDODKNBDEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class EIOOALGFKGK<T> : ALMAJBDDDKL<T?>, BJHFEJJJBKA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x30726A0", Offset = "0x3071AA0", VA = "0x1830726A0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3072320", Offset = "0x3071720", VA = "0x183072320", Slot = "5")]
	public T? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EIOOALGFKGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class PBPBEBOIJHO<T> : ALMAJBDDDKL<T?>, BJHFEJJJBKA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly ALMAJBDDDKL<T> FIHCKDJICDH;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	public PBPBEBOIJHO(ALMAJBDDDKL<T> FIHCKDJICDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8560", Offset = "0x3DB7960", VA = "0x183DB8560", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, T? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6C40", Offset = "0x3DB6040", VA = "0x183DB6C40", Slot = "5")]
	public T? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class MLFFCEGLLDG : ALMAJBDDDKL<sbyte>, BJHFEJJJBKA, HOAAGFNPBME<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MLFFCEGLLDG BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x63D9FA0", Offset = "0x63D93A0", VA = "0x1863D9FA0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, sbyte EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x63D9F50", Offset = "0x63D9350", VA = "0x1863D9F50", Slot = "5")]
	public sbyte ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x63D9EE0", Offset = "0x63D92E0", VA = "0x1863D9EE0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, sbyte EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x63D9E20", Offset = "0x63D9220", VA = "0x1863D9E20", Slot = "7")]
	public sbyte BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MLFFCEGLLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NPPEJHNJFFI : ALMAJBDDDKL<sbyte?>, BJHFEJJJBKA, HOAAGFNPBME<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly NPPEJHNJFFI BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x63DA4C0", Offset = "0x63D98C0", VA = "0x1863DA4C0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, sbyte? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x63DA410", Offset = "0x63D9810", VA = "0x1863DA410", Slot = "5")]
	public sbyte? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x63DA350", Offset = "0x63D9750", VA = "0x1863DA350", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, sbyte? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x63DA230", Offset = "0x63D9630", VA = "0x1863DA230", Slot = "7")]
	public sbyte? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NPPEJHNJFFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class HDKNPGPBGJB : ALMAJBDDDKL<sbyte[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly HDKNPGPBGJB BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x63D1820", Offset = "0x63D0C20", VA = "0x1863D1820", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, sbyte[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x63D1690", Offset = "0x63D0A90", VA = "0x1863D1690", Slot = "5")]
	public sbyte[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HDKNPGPBGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class MBPDLHNLHHL : ALMAJBDDDKL<short>, BJHFEJJJBKA, HOAAGFNPBME<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly MBPDLHNLHHL BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x63D9790", Offset = "0x63D8B90", VA = "0x1863D9790", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, short EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x63D9740", Offset = "0x63D8B40", VA = "0x1863D9740", Slot = "5")]
	public short ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x63D96D0", Offset = "0x63D8AD0", VA = "0x1863D96D0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, short EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x63D9610", Offset = "0x63D8A10", VA = "0x1863D9610", Slot = "7")]
	public short BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MBPDLHNLHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class OPOCHEDLKHJ : ALMAJBDDDKL<short?>, BJHFEJJJBKA, HOAAGFNPBME<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OPOCHEDLKHJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x63DAC10", Offset = "0x63DA010", VA = "0x1863DAC10", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, short? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x63DAB60", Offset = "0x63D9F60", VA = "0x1863DAB60", Slot = "5")]
	public short? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x63DAAA0", Offset = "0x63D9EA0", VA = "0x1863DAAA0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, short? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x63DA980", Offset = "0x63D9D80", VA = "0x1863DA980", Slot = "7")]
	public short? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OPOCHEDLKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class DLGLJNNOBJJ : ALMAJBDDDKL<short[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly DLGLJNNOBJJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x63CEB70", Offset = "0x63CDF70", VA = "0x1863CEB70", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, short[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x63CE9E0", Offset = "0x63CDDE0", VA = "0x1863CE9E0", Slot = "5")]
	public short[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public DLGLJNNOBJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class FMIGGLMKPPI : ALMAJBDDDKL<int>, BJHFEJJJBKA, HOAAGFNPBME<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly FMIGGLMKPPI BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x63D0120", Offset = "0x63CF520", VA = "0x1863D0120", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, int EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x63D00D0", Offset = "0x63CF4D0", VA = "0x1863D00D0", Slot = "5")]
	public int ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x63D0060", Offset = "0x63CF460", VA = "0x1863D0060", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, int EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x63CFFA0", Offset = "0x63CF3A0", VA = "0x1863CFFA0", Slot = "7")]
	public int BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FMIGGLMKPPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CPOEDOHOAHL : ALMAJBDDDKL<int?>, BJHFEJJJBKA, HOAAGFNPBME<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly CPOEDOHOAHL BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x63CE7E0", Offset = "0x63CDBE0", VA = "0x1863CE7E0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, int? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x63CE730", Offset = "0x63CDB30", VA = "0x1863CE730", Slot = "5")]
	public int? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x63CE670", Offset = "0x63CDA70", VA = "0x1863CE670", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, int? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x63CE550", Offset = "0x63CD950", VA = "0x1863CE550", Slot = "7")]
	public int? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CPOEDOHOAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class JBPLHHADIAB : ALMAJBDDDKL<int[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly JBPLHHADIAB BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x63D5C40", Offset = "0x63D5040", VA = "0x1863D5C40", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, int[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63D5AB0", Offset = "0x63D4EB0", VA = "0x1863D5AB0", Slot = "5")]
	public int[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JBPLHHADIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class KDHHDAMJICM : ALMAJBDDDKL<long>, BJHFEJJJBKA, HOAAGFNPBME<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly KDHHDAMJICM BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x63D64C0", Offset = "0x63D58C0", VA = "0x1863D64C0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, long EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x63D6470", Offset = "0x63D5870", VA = "0x1863D6470", Slot = "5")]
	public long ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x63D6400", Offset = "0x63D5800", VA = "0x1863D6400", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, long EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x63D6340", Offset = "0x63D5740", VA = "0x1863D6340", Slot = "7")]
	public long BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KDHHDAMJICM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class LEGMBABFMGN : ALMAJBDDDKL<long?>, BJHFEJJJBKA, HOAAGFNPBME<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly LEGMBABFMGN BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x63D8530", Offset = "0x63D7930", VA = "0x1863D8530", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, long? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x63D8470", Offset = "0x63D7870", VA = "0x1863D8470", Slot = "5")]
	public long? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x63D83B0", Offset = "0x63D77B0", VA = "0x1863D83B0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, long? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x63D8270", Offset = "0x63D7670", VA = "0x1863D8270", Slot = "7")]
	public long? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LEGMBABFMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class CNMGJKKDGDP : ALMAJBDDDKL<long[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly CNMGJKKDGDP BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x63CE1B0", Offset = "0x63CD5B0", VA = "0x1863CE1B0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, long[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x63CE020", Offset = "0x63CD420", VA = "0x1863CE020", Slot = "5")]
	public long[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CNMGJKKDGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class EOCLCIPDCPH : ALMAJBDDDKL<byte>, BJHFEJJJBKA, HOAAGFNPBME<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly EOCLCIPDCPH BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x63CF630", Offset = "0x63CEA30", VA = "0x1863CF630", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, byte EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x63CF5E0", Offset = "0x63CE9E0", VA = "0x1863CF5E0", Slot = "5")]
	public byte ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x63CF570", Offset = "0x63CE970", VA = "0x1863CF570", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, byte EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x63CF4B0", Offset = "0x63CE8B0", VA = "0x1863CF4B0", Slot = "7")]
	public byte BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EOCLCIPDCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class LKPICLHNPKJ : ALMAJBDDDKL<byte?>, BJHFEJJJBKA, HOAAGFNPBME<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly LKPICLHNPKJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x63D90D0", Offset = "0x63D84D0", VA = "0x1863D90D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, byte? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x63D9020", Offset = "0x63D8420", VA = "0x1863D9020", Slot = "5")]
	public byte? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x63D8F60", Offset = "0x63D8360", VA = "0x1863D8F60", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, byte? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x63D8E40", Offset = "0x63D8240", VA = "0x1863D8E40", Slot = "7")]
	public byte? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LKPICLHNPKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class CFMMHNFLBIJ : ALMAJBDDDKL<ushort>, BJHFEJJJBKA, HOAAGFNPBME<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly CFMMHNFLBIJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x63CDCA0", Offset = "0x63CD0A0", VA = "0x1863CDCA0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ushort EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x63CDC50", Offset = "0x63CD050", VA = "0x1863CDC50", Slot = "5")]
	public ushort ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x63CDBE0", Offset = "0x63CCFE0", VA = "0x1863CDBE0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, ushort EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x63CDB20", Offset = "0x63CCF20", VA = "0x1863CDB20", Slot = "7")]
	public ushort BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CFMMHNFLBIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class MIPAMAKNAMJ : ALMAJBDDDKL<ushort?>, BJHFEJJJBKA, HOAAGFNPBME<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly MIPAMAKNAMJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x63D9CE0", Offset = "0x63D90E0", VA = "0x1863D9CE0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ushort? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x63D9C30", Offset = "0x63D9030", VA = "0x1863D9C30", Slot = "5")]
	public ushort? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x63D9B70", Offset = "0x63D8F70", VA = "0x1863D9B70", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, ushort? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x63D9A50", Offset = "0x63D8E50", VA = "0x1863D9A50", Slot = "7")]
	public ushort? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MIPAMAKNAMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class CCJCNEIFIHB : ALMAJBDDDKL<ushort[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly CCJCNEIFIHB BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x63CD970", Offset = "0x63CCD70", VA = "0x1863CD970", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ushort[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x63CD7E0", Offset = "0x63CCBE0", VA = "0x1863CD7E0", Slot = "5")]
	public ushort[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CCJCNEIFIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class FJLDIOPKBOC : ALMAJBDDDKL<uint>, BJHFEJJJBKA, HOAAGFNPBME<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly FJLDIOPKBOC BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x63CFEC0", Offset = "0x63CF2C0", VA = "0x1863CFEC0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, uint EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x63CFE70", Offset = "0x63CF270", VA = "0x1863CFE70", Slot = "5")]
	public uint ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x63CFE00", Offset = "0x63CF200", VA = "0x1863CFE00", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, uint EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x63CFD40", Offset = "0x63CF140", VA = "0x1863CFD40", Slot = "7")]
	public uint BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FJLDIOPKBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class BDJKILEFEBD : ALMAJBDDDKL<uint?>, BJHFEJJJBKA, HOAAGFNPBME<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly BDJKILEFEBD BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x63CA070", Offset = "0x63C9470", VA = "0x1863CA070", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, uint? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x63C9FC0", Offset = "0x63C93C0", VA = "0x1863C9FC0", Slot = "5")]
	public uint? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x63C9F00", Offset = "0x63C9300", VA = "0x1863C9F00", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, uint? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x63C9DE0", Offset = "0x63C91E0", VA = "0x1863C9DE0", Slot = "7")]
	public uint? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BDJKILEFEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class JCKFPOLFFIJ : ALMAJBDDDKL<uint[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly JCKFPOLFFIJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x63D5F80", Offset = "0x63D5380", VA = "0x1863D5F80", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, uint[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x63D5DF0", Offset = "0x63D51F0", VA = "0x1863D5DF0", Slot = "5")]
	public uint[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JCKFPOLFFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class CCBAOAGCDML : ALMAJBDDDKL<ulong>, BJHFEJJJBKA, HOAAGFNPBME<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly CCBAOAGCDML BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x63CD700", Offset = "0x63CCB00", VA = "0x1863CD700", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ulong EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x63CD6B0", Offset = "0x63CCAB0", VA = "0x1863CD6B0", Slot = "5")]
	public ulong ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x63CD640", Offset = "0x63CCA40", VA = "0x1863CD640", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, ulong EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x63CD580", Offset = "0x63CC980", VA = "0x1863CD580", Slot = "7")]
	public ulong BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CCBAOAGCDML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class PNJGFBJJIGI : ALMAJBDDDKL<ulong?>, BJHFEJJJBKA, HOAAGFNPBME<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly PNJGFBJJIGI BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x63DBE60", Offset = "0x63DB260", VA = "0x1863DBE60", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ulong? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x63DBDA0", Offset = "0x63DB1A0", VA = "0x1863DBDA0", Slot = "5")]
	public ulong? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x63DBCE0", Offset = "0x63DB0E0", VA = "0x1863DBCE0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, ulong? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x63DBBA0", Offset = "0x63DAFA0", VA = "0x1863DBBA0", Slot = "7")]
	public ulong? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public PNJGFBJJIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class HKPCEOEDPKD : ALMAJBDDDKL<ulong[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly HKPCEOEDPKD BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x63D2590", Offset = "0x63D1990", VA = "0x1863D2590", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ulong[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x63D2400", Offset = "0x63D1800", VA = "0x1863D2400", Slot = "5")]
	public ulong[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HKPCEOEDPKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class IOOFAFOLKGA : ALMAJBDDDKL<float>, BJHFEJJJBKA, HOAAGFNPBME<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly IOOFAFOLKGA BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x63D5880", Offset = "0x63D4C80", VA = "0x1863D5880", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, float EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x63D5830", Offset = "0x63D4C30", VA = "0x1863D5830", Slot = "5")]
	public float ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x63D57C0", Offset = "0x63D4BC0", VA = "0x1863D57C0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, float EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x63D5700", Offset = "0x63D4B00", VA = "0x1863D5700", Slot = "7")]
	public float BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IOOFAFOLKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FDDMHABFCDO : ALMAJBDDDKL<float?>, BJHFEJJJBKA, HOAAGFNPBME<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly FDDMHABFCDO BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x63CFC00", Offset = "0x63CF000", VA = "0x1863CFC00", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, float? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x63CFB50", Offset = "0x63CEF50", VA = "0x1863CFB50", Slot = "5")]
	public float? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x63CFA90", Offset = "0x63CEE90", VA = "0x1863CFA90", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, float? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x63CF970", Offset = "0x63CED70", VA = "0x1863CF970", Slot = "7")]
	public float? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FDDMHABFCDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class LINGDHDEHOI : ALMAJBDDDKL<float[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly LINGDHDEHOI BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x63D8C80", Offset = "0x63D8080", VA = "0x1863D8C80", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, float[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x63D8AF0", Offset = "0x63D7EF0", VA = "0x1863D8AF0", Slot = "5")]
	public float[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LINGDHDEHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class FAFCKBAIPLG : ALMAJBDDDKL<double>, BJHFEJJJBKA, HOAAGFNPBME<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly FAFCKBAIPLG BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x63CF890", Offset = "0x63CEC90", VA = "0x1863CF890", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, double EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x63CF840", Offset = "0x63CEC40", VA = "0x1863CF840", Slot = "5")]
	public double ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x63CF7D0", Offset = "0x63CEBD0", VA = "0x1863CF7D0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, double EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x63CF710", Offset = "0x63CEB10", VA = "0x1863CF710", Slot = "7")]
	public double BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FAFCKBAIPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class MAICLDBNEJG : ALMAJBDDDKL<double?>, BJHFEJJJBKA, HOAAGFNPBME<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly MAICLDBNEJG BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x63D94D0", Offset = "0x63D88D0", VA = "0x1863D94D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, double? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x63D9410", Offset = "0x63D8810", VA = "0x1863D9410", Slot = "5")]
	public double? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63D9350", Offset = "0x63D8750", VA = "0x1863D9350", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, double? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x63D9210", Offset = "0x63D8610", VA = "0x1863D9210", Slot = "7")]
	public double? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MAICLDBNEJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class HECBFOFNMGK : ALMAJBDDDKL<double[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly HECBFOFNMGK BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x63D1D40", Offset = "0x63D1140", VA = "0x1863D1D40", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, double[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x63D1BB0", Offset = "0x63D0FB0", VA = "0x1863D1BB0", Slot = "5")]
	public double[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HECBFOFNMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LFJOHIDIGKF : ALMAJBDDDKL<bool>, BJHFEJJJBKA, HOAAGFNPBME<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly LFJOHIDIGKF BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x63D87F0", Offset = "0x63D7BF0", VA = "0x1863D87F0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, bool EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x63D87A0", Offset = "0x63D7BA0", VA = "0x1863D87A0", Slot = "5")]
	public bool ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x63D8730", Offset = "0x63D7B30", VA = "0x1863D8730", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, bool EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x63D8670", Offset = "0x63D7A70", VA = "0x1863D8670", Slot = "7")]
	public bool BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LFJOHIDIGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class GNHCNCDKIFG : ALMAJBDDDKL<bool?>, BJHFEJJJBKA, HOAAGFNPBME<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly GNHCNCDKIFG BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x63D0F50", Offset = "0x63D0350", VA = "0x1863D0F50", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, bool? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x63D0EA0", Offset = "0x63D02A0", VA = "0x1863D0EA0", Slot = "5")]
	public bool? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x63D0DE0", Offset = "0x63D01E0", VA = "0x1863D0DE0", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, bool? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63D0CC0", Offset = "0x63D00C0", VA = "0x1863D0CC0", Slot = "7")]
	public bool? BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GNHCNCDKIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class AOPOECEIACD : ALMAJBDDDKL<bool[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly AOPOECEIACD BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x63C9120", Offset = "0x63C8520", VA = "0x1863C9120", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, bool[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x63C8F90", Offset = "0x63C8390", VA = "0x1863C8F90", Slot = "5")]
	public bool[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public AOPOECEIACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class INEGBBBCKCN : ALMAJBDDDKL<object>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly ALMAJBDDDKL<object> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> DFIDPIKIBAA;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x63D3EC0", Offset = "0x63D32C0", VA = "0x1863D3EC0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, object EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x63D3A80", Offset = "0x63D2E80", VA = "0x1863D3A80", Slot = "5")]
	public object ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public INEGBBBCKCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class COPKDJGOMHI : ALMAJBDDDKL<byte[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly ALMAJBDDDKL<byte[]> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x63CE410", Offset = "0x63CD810", VA = "0x1863CE410", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, byte[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x63CE360", Offset = "0x63CD760", VA = "0x1863CE360", Slot = "5")]
	public byte[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public COPKDJGOMHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class BPPCFLNBGMF : ALMAJBDDDKL<ArraySegment<byte>>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly ALMAJBDDDKL<ArraySegment<byte>> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x63CD3D0", Offset = "0x63CC7D0", VA = "0x1863CD3D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, ArraySegment<byte> EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x63CD2C0", Offset = "0x63CC6C0", VA = "0x1863CD2C0", Slot = "5")]
	public ArraySegment<byte> ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BPPCFLNBGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class HEBHHAANGLA : ALMAJBDDDKL<string>, BJHFEJJJBKA, HOAAGFNPBME<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly ALMAJBDDDKL<string> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x63D1AD0", Offset = "0x63D0ED0", VA = "0x1863D1AD0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, string EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x63D1A80", Offset = "0x63D0E80", VA = "0x1863D1A80", Slot = "5")]
	public string ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x63D1A20", Offset = "0x63D0E20", VA = "0x1863D1A20", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, string EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x63D19D0", Offset = "0x63D0DD0", VA = "0x1863D19D0", Slot = "7")]
	public string BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HEBHHAANGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class ODKDKHNDICP : ALMAJBDDDKL<string[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly ODKDKHNDICP BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63DA7D0", Offset = "0x63D9BD0", VA = "0x1863DA7D0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, string[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63DA600", Offset = "0x63D9A00", VA = "0x1863DA600", Slot = "5")]
	public string[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ODKDKHNDICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class NFFBDDOGKBJ : ALMAJBDDDKL<char>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly NFFBDDOGKBJ BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x63DA0F0", Offset = "0x63D94F0", VA = "0x1863DA0F0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, char EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x63DA080", Offset = "0x63D9480", VA = "0x1863DA080", Slot = "5")]
	public char ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NFFBDDOGKBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class CHEHMEPFJMP : ALMAJBDDDKL<char?>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly CHEHMEPFJMP BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x63CDEA0", Offset = "0x63CD2A0", VA = "0x1863CDEA0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, char? EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x63CDD80", Offset = "0x63CD180", VA = "0x1863CDD80", Slot = "5")]
	public char? ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CHEHMEPFJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class GEGCHPMDKEH : ALMAJBDDDKL<char[]>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly GEGCHPMDKEH BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x63D0890", Offset = "0x63CFC90", VA = "0x1863D0890", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, char[] EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x63D06D0", Offset = "0x63CFAD0", VA = "0x1863D06D0", Slot = "5")]
	public char[] ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GEGCHPMDKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class EIGPFBCINDI : ALMAJBDDDKL<Guid>, BJHFEJJJBKA, HOAAGFNPBME<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly ALMAJBDDDKL<Guid> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x63CF300", Offset = "0x63CE700", VA = "0x1863CF300", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Guid EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x63CF270", Offset = "0x63CE670", VA = "0x1863CF270", Slot = "5")]
	public Guid ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x63CF130", Offset = "0x63CE530", VA = "0x1863CF130", Slot = "6")]
	public void EHEIJMIJDBO(GBOIADKFEIJ MKIOBJMIBCN, Guid EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x63CF090", Offset = "0x63CE490", VA = "0x1863CF090", Slot = "7")]
	public Guid BLPDNJFMFKC(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EIGPFBCINDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class FNMHBJGAODH : ALMAJBDDDKL<decimal>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly ALMAJBDDDKL<decimal> BDJLOIHNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool FGMOCDDLGDL;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EACC90", Offset = "0x4EAC090", VA = "0x184EACC90")]
	public FNMHBJGAODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1611F60", Offset = "0x1611360", VA = "0x181611F60")]
	public FNMHBJGAODH(bool FGMOCDDLGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x63D04A0", Offset = "0x63CF8A0", VA = "0x1863D04A0", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, decimal EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x63D0200", Offset = "0x63CF600", VA = "0x1863D0200", Slot = "5")]
	public decimal ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class LHJCILLOCCN : ALMAJBDDDKL<Uri>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly ALMAJBDDDKL<Uri> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x63D8990", Offset = "0x63D7D90", VA = "0x1863D8990", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Uri EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x63D88D0", Offset = "0x63D7CD0", VA = "0x1863D88D0", Slot = "5")]
	public Uri ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LHJCILLOCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class GHMIMIBHBBG : ALMAJBDDDKL<Version>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly ALMAJBDDDKL<Version> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x63D0B80", Offset = "0x63CFF80", VA = "0x1863D0B80", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Version EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x63D0AC0", Offset = "0x63CFEC0", VA = "0x1863D0AC0", Slot = "5")]
	public Version ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GHMIMIBHBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class CAILNPNCDMN<TKey, TValue> : ALMAJBDDDKL<KeyValuePair<TKey, TValue>>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A98B90", Offset = "0x4A97F90", VA = "0x184A98B90", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, KeyValuePair<TKey, TValue> EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A98860", Offset = "0x4A97C60", VA = "0x184A98860", Slot = "5")]
	public KeyValuePair<TKey, TValue> ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class MGEENNNCBKE : ALMAJBDDDKL<StringBuilder>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly ALMAJBDDDKL<StringBuilder> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x63D9930", Offset = "0x63D8D30", VA = "0x1863D9930", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, StringBuilder EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x63D9870", Offset = "0x63D8C70", VA = "0x1863D9870", Slot = "5")]
	public StringBuilder ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MGEENNNCBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HJGJDMBMHDL : ALMAJBDDDKL<BitArray>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly ALMAJBDDDKL<BitArray> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x63D2080", Offset = "0x63D1480", VA = "0x1863D2080", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, BitArray EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x63D1F00", Offset = "0x63D1300", VA = "0x1863D1F00", Slot = "5")]
	public BitArray ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HJGJDMBMHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class DLLOJKPPAII : ALMAJBDDDKL<Type>, BJHFEJJJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly DLLOJKPPAII BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex GOMLOBOHPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool FNNIAHLKHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool LGLGCGANBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool PJBGNLEPAFP;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x63CF070", Offset = "0x63CE470", VA = "0x1863CF070")]
	public DLLOJKPPAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7370", Offset = "0x5BA6770", VA = "0x185BA7370")]
	public DLLOJKPPAII(bool FNNIAHLKHMN, bool LGLGCGANBMD, bool PJBGNLEPAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x63CEE70", Offset = "0x63CE270", VA = "0x1863CEE70", Slot = "4")]
	public void PJNKBIHCNDA(GBOIADKFEIJ MKIOBJMIBCN, Type EOHMJBFGDPD, NGDHCEEFPJP MEJPHFAEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x63CED20", Offset = "0x63CE120", VA = "0x1863CED20", Slot = "5")]
	public Type ONLENKPGCBM(GCKCGBHPHKM IOJEJAFBOHN, NGDHCEEFPJP MEJPHFAEPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class KLEFKMBLFKK
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] OLMONMAALDA;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly EDNEPDBCKID NDPPMAEDACI;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x63D65A0", Offset = "0x63D59A0", VA = "0x1863D65A0")]
	static KLEFKMBLFKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class JKDADOJNNIC
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] FEFEMNLBBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly EDNEPDBCKID OHDFMEOHCOL;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x63D6130", Offset = "0x63D5530", VA = "0x1863D6130")]
	static JKDADOJNNIC()
	{
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
