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
internal static class AOJECBBNGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F900", Offset = "0x4E8E100", VA = "0x184E8F900")]
	public static bool MCDBOFICLHG(this TypeInfo EHPFPOFFCEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class IIFFPLNNCCN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FFCMMCFEGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] MEHIBEBHBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F06F0", Offset = "0x6EEEF0", VA = "0x1806F06F0")]
	public IIFFPLNNCCN(Type FKGGEGPGJDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class HHCKBDIEMIG : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EEINAPODPCL<T>(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T ONMKGINJIFM<T>(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL DDJJCGDLPGH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EBBBNEHKICB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JECENNBIMEI<T> : EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MFAJIMKKIPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MJOIPDAKNEA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JECENNBIMEI<T> OLHPIMCDMLA<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class INOIEMBFFDF
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3701D40", Offset = "0x3700540", VA = "0x183701D40")]
	public static global::JECENNBIMEI<T> CNBFLJDBFKK<T>(this KFGIIMCBFCL DDJJCGDLPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x524C880", Offset = "0x524B080", VA = "0x18524C880")]
	public static object KGDLCOODNHP(this KFGIIMCBFCL DDJJCGDLPGH, Type EHPFPOFFCEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AHLBKABGHGF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F700", Offset = "0x4E8DF00", VA = "0x184E8F700")]
	public AHLBKABGHGF(string EPAIMCEIMPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EILLEGCDDNJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class GELDDDKJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DNLJJNDPNCG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] AINNKIIALKA;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x54FD9C0", Offset = "0x54FC1C0", VA = "0x1854FD9C0")]
		public static byte[] FHIPLPJHAPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x54FD930", Offset = "0x54FC130", VA = "0x1854FD930")]
		public static char[] BHCGJNPPFHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> NOLAAOMODKB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] OKIDIOJOJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EBBNNMNMLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int OBHIANFIDPA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool BPOKFJEDIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D890", Offset = "0x4E9C090", VA = "0x184E9D890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F520", Offset = "0x4E9DD20", VA = "0x184E9F520")]
	public EILLEGCDDNJ(byte[] EBBNNMNMLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F330", Offset = "0x4E9DB30", VA = "0x184E9F330")]
	public EILLEGCDDNJ(byte[] EBBNNMNMLOE, int OBHIANFIDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D8B0", Offset = "0x4E9C0B0", VA = "0x184E9D8B0")]
	private FGNDDNDAFCI JLAJLLOHAOM(string AOKBJAFIAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D420", Offset = "0x4E9BC20", VA = "0x184E9D420")]
	private FGNDDNDAFCI GAHNOHPHJNK(string EPAIMCEIMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EAD0", Offset = "0x4E9D2D0", VA = "0x184E9EAD0")]
	public void MFJOCEGDGMP(int OBHIANFIDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5000", Offset = "0x6D3800", VA = "0x1806D5000")]
	public byte[] LIKGADHKBCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F00", Offset = "0x7F4700", VA = "0x1807F5F00")]
	public int MBHHMCILDAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C8C0", Offset = "0x4E9B0C0", VA = "0x184E9C8C0")]
	public EMDIENOCFNI AMHLABCCOJE()
	{
		return default(EMDIENOCFNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CE60", Offset = "0x4E9B660", VA = "0x184E9CE60")]
	public void DBBIPCIDFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C780", Offset = "0x4E9AF80", VA = "0x184E9C780")]
	public bool ABMNBOPDCDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CCD0", Offset = "0x4E9B4D0", VA = "0x184E9CCD0")]
	public bool CFMOAJAPFBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CFA0", Offset = "0x4E9B7A0", VA = "0x184E9CFA0")]
	public void FAINFNBFMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D7A0", Offset = "0x4E9BFA0", VA = "0x184E9D7A0")]
	public bool HJFNFPJDKJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1C0", Offset = "0x4E9B9C0", VA = "0x184E9D1C0")]
	public bool FJELCOJOOOH(ref int FCKFNIPNJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D560", Offset = "0x4E9BD60", VA = "0x184E9D560")]
	public bool GFDLGGGFLAG(ref int FCKFNIPNJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CC60", Offset = "0x4E9B460", VA = "0x184E9CC60")]
	public bool BPMBMOCLDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DE80", Offset = "0x4E9C680", VA = "0x184E9DE80")]
	public void KFLBBLNMINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E160", Offset = "0x4E9C960", VA = "0x184E9E160")]
	public bool LMKLEKHDGIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EDF0", Offset = "0x4E9D5F0", VA = "0x184E9EDF0")]
	public bool OCJMGKFEBNJ(ref int FCKFNIPNJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D030", Offset = "0x4E9B830", VA = "0x184E9D030")]
	public bool FBANIKKGAKP(ref int FCKFNIPNJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E100", Offset = "0x4E9C900", VA = "0x184E9E100")]
	public bool LIFCBFIEKNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CDD0", Offset = "0x4E9B5D0", VA = "0x184E9CDD0")]
	public void DADONMJPMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F1D0", Offset = "0x4E9D9D0", VA = "0x184E9F1D0")]
	public bool PNDHDKLOCAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F040", Offset = "0x4E9D840", VA = "0x184E9F040")]
	public void PKLGGINPCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E310", Offset = "0x4E9CB10", VA = "0x184E9E310")]
	private void MDEANKJJGFH(out byte[] DDGAICAOJCJ, out int HCBINJOLEPK, out int LBGPMKOKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D6F0", Offset = "0x4E9BEF0", VA = "0x184E9D6F0")]
	private static int HIDMFNIKODI(char HDPOKDCLGGE, char JBKIIGINOKM, char FCOOKAEOJMD, char ECNMDFEDCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D0F0", Offset = "0x4E9B8F0", VA = "0x184E9D0F0")]
	private static int FCIJNDBMFJI(char NGMFABJMIHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F0D0", Offset = "0x4E9D8D0", VA = "0x184E9F0D0")]
	public ArraySegment<byte> PMNJEDPOEJL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CD30", Offset = "0x4E9B530", VA = "0x184E9CD30")]
	public string COELLEIHJLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D860", Offset = "0x4E9C060", VA = "0x184E9D860")]
	public string INJINAONNJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EE70", Offset = "0x4E9D670", VA = "0x184E9EE70")]
	public ArraySegment<byte> PBLJIKEGFDN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C880", Offset = "0x4E9B080", VA = "0x184E9C880")]
	public ArraySegment<byte> AFJKNDABIJG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EBB0", Offset = "0x4E9D3B0", VA = "0x184E9EBB0")]
	public bool NPGJKJMAFLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DDC0", Offset = "0x4E9C5C0", VA = "0x184E9DDC0")]
	private static bool JNNLIKFADOH(byte FCOOKAEOJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D240", Offset = "0x4E9BA40", VA = "0x184E9D240")]
	private void FKFLEBJJLAC(EMDIENOCFNI JPCLKLIDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CCC0", Offset = "0x4E9B4C0", VA = "0x184E9CCC0")]
	public void CDEKODDMDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CA40", Offset = "0x4E9B240", VA = "0x184E9CA40")]
	private void BDOACENMFGP(int NJBGFOANGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EAE0", Offset = "0x4E9D2E0", VA = "0x184E9EAE0")]
	public sbyte MIPHCIHNFBC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C720", Offset = "0x4E9AF20", VA = "0x184E9C720")]
	public short AADONJEPOKD()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D800", Offset = "0x4E9C000", VA = "0x184E9D800")]
	public int IKEJNHAIFFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EB30", Offset = "0x4E9D330", VA = "0x184E9EB30")]
	public long NPCEEMIJACA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D500", Offset = "0x4E9BD00", VA = "0x184E9D500")]
	public byte GEPDPMFNHLN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CC00", Offset = "0x4E9B400", VA = "0x184E9CC00")]
	public ushort BOMDBHCILDN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DF10", Offset = "0x4E9C710", VA = "0x184E9DF10")]
	public uint KMMDAIICKKN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E1C0", Offset = "0x4E9C9C0", VA = "0x184E9E1C0")]
	public ulong MBFEONPIMGJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E240", Offset = "0x4E9CA40", VA = "0x184E9E240")]
	public float MCOOCPKEOHI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D620", Offset = "0x4E9BE20", VA = "0x184E9D620")]
	public double HFIDGPIMPKJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CB10", Offset = "0x4E9B310", VA = "0x184E9CB10")]
	public ArraySegment<byte> BIMJHGIFHDM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DF70", Offset = "0x4E9C770", VA = "0x184E9DF70")]
	private static int KPGOKFDPFLE(byte[] EBBNNMNMLOE, int OBHIANFIDPA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FGNDDNDAFCI : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference LGNOLOBHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int MLHCGNPDAIG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HLAHIPMNHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B5E0", Offset = "0x1E69DE0", VA = "0x181E6B5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string ANDANJOAKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF490", Offset = "0x8DDC90", VA = "0x1808DF490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1200", Offset = "0x4E9FA00", VA = "0x184EA1200")]
	public FGNDDNDAFCI(string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1270", Offset = "0x4E9FA70", VA = "0x184EA1270")]
	public FGNDDNDAFCI(string EPAIMCEIMPA, byte[] FOLFFHIPDCB, int OBHIANFIDPA, int MLHCGNPDAIG, string ONLFHOOJJLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KLHCKBPJKPF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class DHKPMMHMIJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void LKGHFAMHMDP(ref LMANJAHJEKC IJMHHNEJPMM, object NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object NCLJJFDOLPP(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL DDJJCGDLPGH);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class KKNKAJBPNPC
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class CKLFNPFGPML
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
				public CKLFNPFGPML()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x3A6D130", Offset = "0x3A6B930", VA = "0x183A6D130")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x54FBEB0", Offset = "0x54FA6B0", VA = "0x1854FBEB0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, KFGIIMCBFCL, byte[]> BDMEKEDMNHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, KFGIIMCBFCL> OOBPAJLAJBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LKGHFAMHMDP OPDKEOOCJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, KFGIIMCBFCL, ArraySegment<byte>> IGCKEDBJDJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, KFGIIMCBFCL, string> POGIGAKHHBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, KFGIIMCBFCL, object> NHBAOOLLMNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, KFGIIMCBFCL, object> ACNGGEKAKLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, KFGIIMCBFCL, object> JNHGMBOKOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly NCLJJFDOLPP IFCKAJMHDIP;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x55030E0", Offset = "0x55018E0", VA = "0x1855030E0")]
			public KKNKAJBPNPC(Type EHPFPOFFCEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6330A40", Offset = "0x632F240", VA = "0x186330A40")]
			private static T KGLOPFHLODI<T>(DynamicMethod DELMIOMKBNM)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5502E90", Offset = "0x5501690", VA = "0x185502E90")]
			private static MethodInfo PHBEGJDGDPF(Type EHPFPOFFCEJ, string LOIAMCEJAFO, Type[] EBCFPHJHFPI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KKNKAJBPNPC> IOFDDCNDBAO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::HFNFGBMJBLO<KKNKAJBPNPC> APDHBFJIFLA;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x54FC770", Offset = "0x54FAF70", VA = "0x1854FC770")]
		static DHKPMMHMIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x54FC430", Offset = "0x54FAC30", VA = "0x1854FC430")]
		private static KKNKAJBPNPC CJEAEPMIFBE(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x54FC5E0", Offset = "0x54FADE0", VA = "0x1854FC5E0")]
		public static void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, object NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x54FC4C0", Offset = "0x54FACC0", VA = "0x1854FC4C0")]
		public static void ODHIHDMAPDF(Type EHPFPOFFCEJ, ref LMANJAHJEKC IJMHHNEJPMM, object NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class NIPLHMPEGFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] DNLJJNDPNCG;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x550A130", Offset = "0x5508930", VA = "0x18550A130")]
		public static byte[] FHIPLPJHAPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KFGIIMCBFCL ANBHJHOLOPN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] GHCCPDAPGIO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] FKKLKAKDBJL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KFGIIMCBFCL NNGHHAJGMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5253EA0", Offset = "0x52526A0", VA = "0x185253EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MMIMOGPFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5253620", Offset = "0x5251E20", VA = "0x185253620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52535B0", Offset = "0x5251DB0", VA = "0x1852535B0")]
	public static void IGIHAAAKHLB(KFGIIMCBFCL DDJJCGDLPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x14BA530", Offset = "0x14B8D30", VA = "0x1814BA530")]
	public static byte[] ODHIHDMAPDF<T>(T BFHAMCLNCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x14BA840", Offset = "0x14B9040", VA = "0x1814BA840")]
	public static byte[] ODHIHDMAPDF<T>(T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x14BA4A0", Offset = "0x14B8CA0", VA = "0x1814BA4A0")]
	public static void ODHIHDMAPDF<T>(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x14BA5B0", Offset = "0x14B8DB0", VA = "0x1814BA5B0")]
	public static void ODHIHDMAPDF<T>(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x14BA690", Offset = "0x14B8E90", VA = "0x1814BA690")]
	public static void ODHIHDMAPDF<T>(Stream LPIADEMPDKB, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x14BA720", Offset = "0x14B8F20", VA = "0x1814BA720")]
	public static void ODHIHDMAPDF<T>(Stream LPIADEMPDKB, T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x14BA280", Offset = "0x14B8A80", VA = "0x1814BA280")]
	public static ArraySegment<byte> MNFJCOPOMFG<T>(T BFHAMCLNCKB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x14BA320", Offset = "0x14B8B20", VA = "0x1814BA320")]
	public static ArraySegment<byte> MNFJCOPOMFG<T>(T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x14BA0A0", Offset = "0x14B88A0", VA = "0x1814BA0A0")]
	public static string LLCMMMHBOPI<T>(T NPHADDCNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x14BA120", Offset = "0x14B8920", VA = "0x1814BA120")]
	public static string LLCMMMHBOPI<T>(T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x14B95E0", Offset = "0x14B7DE0", VA = "0x1814B95E0")]
	public static T JFCMHHFNDFE<T>(string AOOIJHFKAJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x14B9880", Offset = "0x14B8080", VA = "0x1814B9880")]
	public static T JFCMHHFNDFE<T>(string AOOIJHFKAJG, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x14B9970", Offset = "0x14B8170", VA = "0x1814B9970")]
	public static T JFCMHHFNDFE<T>(byte[] EBBNNMNMLOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x14B9680", Offset = "0x14B7E80", VA = "0x1814B9680")]
	public static T JFCMHHFNDFE<T>(byte[] EBBNNMNMLOE, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x14B9B50", Offset = "0x14B8350", VA = "0x1814B9B50")]
	public static T JFCMHHFNDFE<T>(byte[] EBBNNMNMLOE, int OBHIANFIDPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x14B9720", Offset = "0x14B7F20", VA = "0x1814B9720")]
	public static T JFCMHHFNDFE<T>(byte[] EBBNNMNMLOE, int OBHIANFIDPA, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x14B9BE0", Offset = "0x14B83E0", VA = "0x1814B9BE0")]
	public static T JFCMHHFNDFE<T>(ref EILLEGCDDNJ AODHOCAKPON)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14B9E20", Offset = "0x14B8620", VA = "0x1814B9E20")]
	public static T JFCMHHFNDFE<T>(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EF0", Offset = "0x14B86F0", VA = "0x1814B9EF0")]
	public static T JFCMHHFNDFE<T>(Stream LPIADEMPDKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F70", Offset = "0x14B8770", VA = "0x1814B9F70")]
	public static T JFCMHHFNDFE<T>(Stream LPIADEMPDKB, KFGIIMCBFCL DDJJCGDLPGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5253480", Offset = "0x5251C80", VA = "0x185253480")]
	public static string EIDFMCHPDBP(byte[] AOOIJHFKAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5253270", Offset = "0x5251A70", VA = "0x185253270")]
	public static string EIDFMCHPDBP(byte[] AOOIJHFKAJG, int OBHIANFIDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5253370", Offset = "0x5251B70", VA = "0x185253370")]
	public static string EIDFMCHPDBP(string AOOIJHFKAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5254100", Offset = "0x5252900", VA = "0x185254100")]
	public static byte[] PJOGHMFHFOM(byte[] AOOIJHFKAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5254250", Offset = "0x5252A50", VA = "0x185254250")]
	public static byte[] PJOGHMFHFOM(byte[] AOOIJHFKAJG, int OBHIANFIDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5253FC0", Offset = "0x52527C0", VA = "0x185253FC0")]
	public static byte[] PJOGHMFHFOM(string AOOIJHFKAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5253680", Offset = "0x5251E80", VA = "0x185253680")]
	private static void JMNCPEGMFNO(ref EILLEGCDDNJ AODHOCAKPON, ref LMANJAHJEKC IJMHHNEJPMM, int LJGHFLLENHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52531D0", Offset = "0x52519D0", VA = "0x1852531D0")]
	private static int BANCCAGHJCH(Stream JHPDOGGEPPC, ref byte[] DNLJJNDPNCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EMDIENOCFNI : byte
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
public struct LMANJAHJEKC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] MLMAHAKIFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DNLJJNDPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OBHIANFIDPA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MNGIAGIINHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F00", Offset = "0x7F4700", VA = "0x1807F5F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EAD0", Offset = "0x4E9D2D0", VA = "0x184E9EAD0")]
	public void MFJOCEGDGMP(int OBHIANFIDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5258890", Offset = "0x5257090", VA = "0x185258890")]
	public static byte[] FLPJDEMBCIM(string OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5258040", Offset = "0x5256840", VA = "0x185258040")]
	public static byte[] BKKEIINKNCL(string OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5258620", Offset = "0x5256E20", VA = "0x185258620")]
	public static byte[] FAHHHNKECAB(string OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x52589D0", Offset = "0x52571D0", VA = "0x1852589D0")]
	public static byte[] HNODPKAMNMB(string OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC20F80", Offset = "0xC1F780", VA = "0x180C20F80")]
	public LMANJAHJEKC(byte[] GAEJHIDLALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5258760", Offset = "0x5256F60", VA = "0x185258760")]
	public ArraySegment<byte> FHIPLPJHAPG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5258810", Offset = "0x5257010", VA = "0x185258810")]
	public byte[] FJPENJHIMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x52593E0", Offset = "0x5257BE0", VA = "0x1852593E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5258E10", Offset = "0x5257610", VA = "0x185258E10")]
	public void KHJOJBFPAAN(int PDMEEILANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E99050", Offset = "0x4E97850", VA = "0x184E99050")]
	public void PDMEMPMIFKN(byte NOMBAEBFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x52591E0", Offset = "0x52579E0", VA = "0x1852591E0")]
	public void PDMEMPMIFKN(byte[] NOMBAEBFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x52593A0", Offset = "0x5257BA0", VA = "0x1852593A0")]
	public void PKCNNCKNGJF(byte NOMBAEBFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5257FF0", Offset = "0x52567F0", VA = "0x185257FF0")]
	public void AODNHKJNFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5259060", Offset = "0x5257860", VA = "0x185259060")]
	public void KPAJPMOIJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5259010", Offset = "0x5257810", VA = "0x185259010")]
	public void KOEGHHGBNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5258180", Offset = "0x5256980", VA = "0x185258180")]
	public void BPAHGDIIIEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5258DC0", Offset = "0x52575C0", VA = "0x185258DC0")]
	public void KCNDOMHHEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5258C80", Offset = "0x5257480", VA = "0x185258C80")]
	public void INAPLAFFBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5258CD0", Offset = "0x52574D0", VA = "0x185258CD0")]
	public void JBGPLACNJNI(string OABNINOCHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x52581D0", Offset = "0x52569D0", VA = "0x1852581D0")]
	public void CAJJPGGJOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x52590B0", Offset = "0x52578B0", VA = "0x1852590B0")]
	public void LFDOBHBGIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5258E20", Offset = "0x5257620", VA = "0x185258E20")]
	public void KJACAPNEEMP(bool NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5259240", Offset = "0x5257A40", VA = "0x185259240")]
	public void PHOAHCGLAGL(float NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5258B20", Offset = "0x5257320", VA = "0x185258B20")]
	public void ICCAGLJBLLJ(double NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x52585F0", Offset = "0x5256DF0", VA = "0x1852585F0")]
	public void EECHKPAPAEF(byte NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5258D30", Offset = "0x5257530", VA = "0x185258D30")]
	public void JDOHOOAIHJA(ushort NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x52589A0", Offset = "0x52571A0", VA = "0x1852589A0")]
	public void GJFMAEKBABA(uint NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5258D60", Offset = "0x5257560", VA = "0x185258D60")]
	public void JELPDDNLPKF(ulong NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5258970", Offset = "0x5257170", VA = "0x185258970")]
	public void FOFDFCDGOMB(sbyte NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5258D90", Offset = "0x5257590", VA = "0x185258D90")]
	public void JMPPEDDGNMN(short NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5259180", Offset = "0x5257980", VA = "0x185259180")]
	public void LLNFIMMCKLD(int NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x52591B0", Offset = "0x52579B0", VA = "0x1852591B0")]
	public void MGBJAKJJNAD(long NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5258220", Offset = "0x5256A20", VA = "0x185258220")]
	public void DIPLEGOKEGA(string NPHADDCNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GABBCCMLGPN : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class FNHJIPABLMD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2997500", Offset = "0x2995D00", VA = "0x182997500")]
		static FNHJIPABLMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private GABBCCMLGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class MHFIOPKMFPC
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> MIAAMELKGHB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5508150", Offset = "0x5506950", VA = "0x185508150")]
	static MHFIOPKMFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5507A40", Offset = "0x5506240", VA = "0x185507A40")]
	internal static object OLHPIMCDMLA(Type KFEBAJCAAOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class BHLONOCIJAP : global::JECENNBIMEI<Vector2>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4E92450", Offset = "0x4E90C50", VA = "0x184E92450")]
	public BHLONOCIJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E923A0", Offset = "0x4E90BA0", VA = "0x184E923A0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Vector2 NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E920C0", Offset = "0x4E908C0", VA = "0x184E920C0", Slot = "5")]
	public Vector2 JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class IGGKJOINFFC : global::JECENNBIMEI<Vector3>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x52439D0", Offset = "0x52421D0", VA = "0x1852439D0")]
	public IGGKJOINFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x52437D0", Offset = "0x5241FD0", VA = "0x1852437D0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Vector3 NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5243610", Offset = "0x5241E10", VA = "0x185243610", Slot = "5")]
	public Vector3 JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EAKHDAHJJAH : global::JECENNBIMEI<Vector4>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E9BE80", Offset = "0x4E9A680", VA = "0x184E9BE80")]
	public EAKHDAHJJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4E9BD30", Offset = "0x4E9A530", VA = "0x184E9BD30", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Vector4 NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B9B0", Offset = "0x4E9A1B0", VA = "0x184E9B9B0", Slot = "5")]
	public Vector4 JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HKEBENMFPEJ : global::JECENNBIMEI<Quaternion>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5242B00", Offset = "0x5241300", VA = "0x185242B00")]
	public HKEBENMFPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5242890", Offset = "0x5241090", VA = "0x185242890", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Quaternion NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5242670", Offset = "0x5240E70", VA = "0x185242670", Slot = "5")]
	public Quaternion JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KJIKMAIJMND : global::JECENNBIMEI<Color>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5252420", Offset = "0x5250C20", VA = "0x185252420")]
	public KJIKMAIJMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5242890", Offset = "0x5241090", VA = "0x185242890", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Color NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5252200", Offset = "0x5250A00", VA = "0x185252200", Slot = "5")]
	public Color JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PNCKAPCJFIH : global::JECENNBIMEI<Bounds>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x550F070", Offset = "0x550D870", VA = "0x18550F070")]
	public PNCKAPCJFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x550EED0", Offset = "0x550D6D0", VA = "0x18550EED0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Bounds NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x550EBA0", Offset = "0x550D3A0", VA = "0x18550EBA0", Slot = "5")]
	public Bounds JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DKCBCFENOBP : global::JECENNBIMEI<Rect>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PIPOGPCBCNM BLCOGOIILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] EMDDIBJLGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B350", Offset = "0x4E99B50", VA = "0x184E9B350")]
	public DKCBCFENOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B1E0", Offset = "0x4E999E0", VA = "0x184E9B1E0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Rect NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AE30", Offset = "0x4E99630", VA = "0x184E9AE30", Slot = "5")]
	public Rect JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OIEEIDDADIG : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class JCGINNJHPKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x33EAF00", Offset = "0x33E9700", VA = "0x1833EAF00")]
		static JCGINNJHPKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private OIEEIDDADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GGFAKEJFBHJ : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class JCBFAMHIPFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x33EA160", Offset = "0x33E8960", VA = "0x1833EA160")]
		static JCBFAMHIPFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class MFFODBNNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> CMOGBNMNHHP;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55059C0", Offset = "0x55041C0", VA = "0x1855059C0")]
		internal static object OLHPIMCDMLA(Type KFEBAJCAAOE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private GGFAKEJFBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class MEPDDIOFOBK : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class MDCBGIHLBLF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4320", Offset = "0x2DA2B20", VA = "0x182DA4320")]
		static MDCBGIHLBLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MEPDDIOFOBK PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool KMHBHIKJPCP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static EBBBNEHKICB[] FDDIIBAGJAJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static KFGIIMCBFCL[] FEKGKGJAOJO;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private MEPDDIOFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5505460", Offset = "0x5503C60", VA = "0x185505460")]
	public static void OFCCGGLDJKB(params KFGIIMCBFCL[] FEKGKGJAOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5505540", Offset = "0x5503D40", VA = "0x185505540")]
	public static void OFCCGGLDJKB(params EBBBNEHKICB[] FDDIIBAGJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55051D0", Offset = "0x55039D0", VA = "0x1855051D0")]
	public static void HFDBDJMFFAI(EBBBNEHKICB[] FDDIIBAGJAJ, KFGIIMCBFCL[] FEKGKGJAOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class NHDIBBLLEON : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class DEJAACDIAPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A888C0", Offset = "0x3A870C0", VA = "0x183A888C0")]
		static DEJAACDIAPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private NHDIBBLLEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FCFGPBPJDCK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly KFGIIMCBFCL KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly KFGIIMCBFCL KEBGGDPNHKI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly KFGIIMCBFCL OMGHOBNGAFL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KFGIIMCBFCL FBINJMHDFCK;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly KFGIIMCBFCL PPNDOMDBLDO;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly KFGIIMCBFCL LJICKJDCEJK;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly KFGIIMCBFCL BBDIACJNNLM;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly KFGIIMCBFCL FFKBHEKFPIG;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly KFGIIMCBFCL GGADJLNIGAI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly KFGIIMCBFCL IHDPFMKNKBA;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly KFGIIMCBFCL EOIINEHJCME;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KFGIIMCBFCL KAGKJAJBDDA;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LAGGIOGJFII
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly KFGIIMCBFCL KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KFGIIMCBFCL LJGHIAJEOHP;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ABFGABDLKPJ
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly KFGIIMCBFCL KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly KFGIIMCBFCL KEBGGDPNHKI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly KFGIIMCBFCL OMGHOBNGAFL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KFGIIMCBFCL FBINJMHDFCK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly KFGIIMCBFCL PPNDOMDBLDO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly KFGIIMCBFCL LJICKJDCEJK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly KFGIIMCBFCL BBDIACJNNLM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly KFGIIMCBFCL FFKBHEKFPIG;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KFGIIMCBFCL GGADJLNIGAI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly KFGIIMCBFCL IHDPFMKNKBA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly KFGIIMCBFCL EOIINEHJCME;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly KFGIIMCBFCL KAGKJAJBDDA;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class GAIKAHKOHIH
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> CMOGBNMNHHP;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1D70", Offset = "0x4EA0570", VA = "0x184EA1D70")]
	internal static object OLHPIMCDMLA(Type KFEBAJCAAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1D30", Offset = "0x4EA0530", VA = "0x184EA1D30")]
	private static object CKOMCDAMJAK(Type HDPJNMOOPLF, Type[] KKLDMDKJCAD, params object[] EBCFPHJHFPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LCCEKBPGMMG : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class OHGGGCKDNGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x31F5B30", Offset = "0x31F4330", VA = "0x1831F5B30")]
		static OHGGGCKDNGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly EDMJGLDOHNC MPPCDGONACF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x52545C0", Offset = "0x5252DC0", VA = "0x1852545C0")]
	static LCCEKBPGMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private LCCEKBPGMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class POCAIMNGNPI : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class AHCEMGKKPJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x33AF7F0", Offset = "0x33ADFF0", VA = "0x1833AF7F0")]
		static AHCEMGKKPJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly EDMJGLDOHNC MPPCDGONACF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x550F2B0", Offset = "0x550DAB0", VA = "0x18550F2B0")]
	static POCAIMNGNPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private POCAIMNGNPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class CPCKPENEEFE : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class EBHLCCHEIAJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x26245F0", Offset = "0x2622DF0", VA = "0x1826245F0")]
		static EBHLCCHEIAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly EDMJGLDOHNC MPPCDGONACF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E98C30", Offset = "0x4E97430", VA = "0x184E98C30")]
	static CPCKPENEEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private CPCKPENEEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MLOHLODNMNP : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class KACFKJHIIOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x27FB4C0", Offset = "0x27F9CC0", VA = "0x1827FB4C0")]
		static KACFKJHIIOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly EDMJGLDOHNC MPPCDGONACF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5508D20", Offset = "0x5507520", VA = "0x185508D20")]
	static MLOHLODNMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private MLOHLODNMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class IHNPHLEFAAM : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class MABGDCDFHME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D962F0", Offset = "0x2D94AF0", VA = "0x182D962F0")]
		static MABGDCDFHME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly EDMJGLDOHNC MPPCDGONACF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5243C70", Offset = "0x5242470", VA = "0x185243C70")]
	static IHNPHLEFAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private IHNPHLEFAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class EDHHMICKKKP : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class CEOKBEPLOHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28CD5A0", Offset = "0x28CBDA0", VA = "0x1828CD5A0")]
		static CEOKBEPLOHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly EDMJGLDOHNC MPPCDGONACF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C310", Offset = "0x4E9AB10", VA = "0x184E9C310")]
	static EDHHMICKKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private EDHHMICKKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class BAGCIHMJMKD : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class LNKONFEEBAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA740", Offset = "0x2FE8F40", VA = "0x182FEA740")]
		static LNKONFEEBAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BAGCIHMJMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class CGODLOCOBKB : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class PFGPPDDOLKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E6E0", Offset = "0x2F0CEE0", VA = "0x182F0E6E0")]
		static PFGPPDDOLKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CGODLOCOBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class BFKICMHPHHN : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class FCNEACEFBCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3224840", Offset = "0x3223040", VA = "0x183224840")]
		static FCNEACEFBCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BFKICMHPHHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class DJKJPACGAME : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class DCIFLBOMMGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3924300", Offset = "0x3922B00", VA = "0x183924300")]
		static DCIFLBOMMGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DJKJPACGAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class LIGKAFHKAAB : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class JMJCCGFFFJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x25B1BF0", Offset = "0x25B03F0", VA = "0x1825B1BF0")]
		static JMJCCGFFFJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LIGKAFHKAAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class ILPPKGPNAHI : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class HJONHOOADPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x39EB000", Offset = "0x39E9800", VA = "0x1839EB000")]
		static HJONHOOADPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> HGFPKLGCOKK;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool EKFNMEPHNFN;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public ILPPKGPNAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class ILBPOHBFNAN
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct PNKKMNKPHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BIINFGBLHON AMFONPCLLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder OEOAPEMMIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder MGHNCLLMDIP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class HOFEMCIKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class KEAMILPEFNL
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo FAHHHNKECAB;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo BKKEIINKNCL;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo HNODPKAMNMB;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo FLPJDEMBCIM;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo LFDOBHBGIHG;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo PDMEMPMIFKN;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo KOEGHHGBNCM;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo BPAHGDIIIEN;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo KCNDOMHHEGM;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5501EF0", Offset = "0x55006F0", VA = "0x185501EF0")]
			static KEAMILPEFNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class PFMGEFIDNIL
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo ABMNBOPDCDL;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo KFLBBLNMINF;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo OCJMGKFEBNJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo MCDFDOHKMMP;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo CDEKODDMDEK;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo LIKGADHKBCF;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo MBHHMCILDAO;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x550C700", Offset = "0x550AF00", VA = "0x18550C700")]
			static PFMGEFIDNIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class MJBNLJCNIHI
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FFCMMCFEGBM;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo MEHIBEBHBJI;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo EDAINDIDENA;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo CNBFLJDBFKK;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo ICNOGFDCCMF;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo OFKJPDCKKDE;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo FPHOKMFBJIO;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo CLAKONBMNEH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo IFINMGPIACO;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo MEDLGHLNMPD;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo JNOFMJCNIGL;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo ANDFJJOPNEO;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo BIIBCLLNHIH;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo FILPCODMNLI;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x54FF490", Offset = "0x54FDC90", VA = "0x1854FF490")]
		public static MethodInfo ODHIHDMAPDF(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x54FF220", Offset = "0x54FDA20", VA = "0x1854FF220")]
		public static MethodInfo JFCMHHFNDFE(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x54FF0E0", Offset = "0x54FD8E0", VA = "0x1854FF0E0")]
		public static MethodInfo JAEPBIDEACF(Type EHPFPOFFCEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JIPAOCHCIBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BIINFGBLHON, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JIPAOCHCIBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FDCOGNKPENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public JIPAOCHCIBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public FDCOGNKPENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x54FD260", Offset = "0x54FBA60", VA = "0x1854FD260")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x54FD2A0", Offset = "0x54FBAA0", VA = "0x1854FD2A0")]
		internal bool <BuildType>b__2(int index, BIINFGBLHON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MALALNNHKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JIPAOCHCIBK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MALALNNHKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x55050D0", Offset = "0x55038D0", VA = "0x1855050D0")]
		internal bool <BuildType>b__3(int index, BIINFGBLHON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LBAFGPHNIKH
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LBAFGPHNIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5504DE0", Offset = "0x55035E0", VA = "0x185504DE0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class JCNKJFFIOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JCNKJFFIOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5501630", Offset = "0x54FFE30", VA = "0x185501630")]
		internal bool <BuildAnonymousFormatter>b__2(BIINFGBLHON x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class EHALKIFBFFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LBAFGPHNIKH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EHALKIFBFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x54FCEF0", Offset = "0x54FB6F0", VA = "0x1854FCEF0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x54FCF00", Offset = "0x54FB700", VA = "0x1854FCF00")]
		internal bool <BuildAnonymousFormatter>b__6(int index, BIINFGBLHON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HPAMCDIJNLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LBAFGPHNIKH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public HPAMCDIJNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5500DC0", Offset = "0x54FF5C0", VA = "0x185500DC0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, BIINFGBLHON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CLIIGPOPKCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CLIIGPOPKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFD0", Offset = "0x6FE7D0", VA = "0x1806FFFD0")]
		internal Label <BuildSerialize>b__1(BIINFGBLHON _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OAGKGEGJOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public PNKKMNKPHGG[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BIINFGBLHON, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public FOFHGFJABDE argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FOFHGFJABDE argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public OAGKGEGJOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x550B4A0", Offset = "0x5509CA0", VA = "0x18550B4A0")]
		internal PNKKMNKPHGG <BuildDeserialize>b__0(BIINFGBLHON item)
		{
			return default(PNKKMNKPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IEFABCCPGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public OAGKGEGJOPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IEFABCCPGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5500F60", Offset = "0x54FF760", VA = "0x185500F60")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5501210", Offset = "0x54FFA10", VA = "0x185501210")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OLJMNCKPEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BIINFGBLHON item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public OLJMNCKPEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1009AE0", Offset = "0x10082E0", VA = "0x181009AE0")]
		internal bool <EmitNewObject>b__0(PNKKMNKPHGG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LDIJLEOGKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BIINFGBLHON item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LDIJLEOGKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1009AE0", Offset = "0x10082E0", VA = "0x181009AE0")]
		internal bool <EmitNewObject>b__2(PNKKMNKPHGG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex PCGKEFAGCFH;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int OCJMEIFAJJF;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> BFGLHFKCJHH;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> KBGNBHADBJE;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x36F6EA0", Offset = "0x36F56A0", VA = "0x1836F6EA0")]
	public static object IPJFLOGCIPD<T>(EDMJGLDOHNC MPPCDGONACF, KFGIIMCBFCL GGIJPBNKLEI, Func<string, string> HGFPKLGCOKK, bool EKFNMEPHNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x36EC4E0", Offset = "0x36EACE0", VA = "0x1836EC4E0")]
	public static object HECIJHJEMPC<T>(KFGIIMCBFCL GGIJPBNKLEI, Func<string, string> HGFPKLGCOKK, bool EKFNMEPHNFN, bool EOFLBODEIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5244340", Offset = "0x5242B40", VA = "0x185244340")]
	private static TypeInfo CLINJJHNEOB(EDMJGLDOHNC MPPCDGONACF, Type EHPFPOFFCEJ, Func<string, string> HGFPKLGCOKK, bool EKFNMEPHNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5244DD0", Offset = "0x52435D0", VA = "0x185244DD0")]
	public static object DAEOLDMHCIL(Type EHPFPOFFCEJ, Func<string, string> HGFPKLGCOKK, bool EKFNMEPHNFN, bool EOFLBODEIKA, bool KAJHCEGKJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x52469C0", Offset = "0x52451C0", VA = "0x1852469C0")]
	private static Dictionary<BIINFGBLHON, FieldInfo> GEEGPLKCDLA(TypeBuilder CCFHBCKOBGO, GEKCJNECGMB CDFJHEMMDBB, ConstructorInfo BDEPELOIHDG, FieldBuilder FCPDHMADLEN, ILGenerator PIBDAJMBNKK, bool EKFNMEPHNFN, bool LOPOCJGLPKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x524B310", Offset = "0x5249B10", VA = "0x18524B310")]
	private static Dictionary<BIINFGBLHON, FieldInfo> OCOIOFFOICI(TypeBuilder CCFHBCKOBGO, GEKCJNECGMB CDFJHEMMDBB, ILGenerator PIBDAJMBNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5248380", Offset = "0x5246B80", VA = "0x185248380")]
	private static void IPDKCBOILDO(Type EHPFPOFFCEJ, GEKCJNECGMB CDFJHEMMDBB, ILGenerator PIBDAJMBNKK, Action GLOLCJJMGFL, Func<int, BIINFGBLHON, bool> CAANBKNIPPM, bool EKFNMEPHNFN, bool LOPOCJGLPKD, int COCLILPBAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5247D50", Offset = "0x5246550", VA = "0x185247D50")]
	private static void IHFFKBLGDIH(TypeInfo EHPFPOFFCEJ, BIINFGBLHON NGMDLOKIPFH, ILGenerator PIBDAJMBNKK, int LHHBOCAHDEE, Func<int, BIINFGBLHON, bool> CAANBKNIPPM, FOFHGFJABDE IJMHHNEJPMM, FOFHGFJABDE DDIFFFFENCP, FOFHGFJABDE HAABDECFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5249F10", Offset = "0x5248710", VA = "0x185249F10")]
	private static void NEFCKGGLCJO(Type EHPFPOFFCEJ, GEKCJNECGMB CDFJHEMMDBB, ILGenerator PIBDAJMBNKK, Func<int, BIINFGBLHON, bool> CAANBKNIPPM, bool PNFDPANJBLO, int COCLILPBAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5249A50", Offset = "0x5248250", VA = "0x185249A50")]
	private static void KAADIADMMBC(ILGenerator PIBDAJMBNKK, PNKKMNKPHGG CDFJHEMMDBB, int LHHBOCAHDEE, Func<int, BIINFGBLHON, bool> CAANBKNIPPM, FOFHGFJABDE AODHOCAKPON, FOFHGFJABDE HAABDECFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x52470A0", Offset = "0x52458A0", VA = "0x1852470A0")]
	private static LocalBuilder IENLNMDOEMB(ILGenerator PIBDAJMBNKK, Type EHPFPOFFCEJ, GEKCJNECGMB CDFJHEMMDBB, PNKKMNKPHGG[] FHPGOGCGPDE, bool GCGNCCKIBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x524B990", Offset = "0x524A190", VA = "0x18524B990")]
	private static bool PIAGNIBNMAL(ConstructorInfo HDCDHDOCBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x52498A0", Offset = "0x52480A0", VA = "0x1852498A0")]
	private static bool JCLLMLFMMHM(Type EHPFPOFFCEJ, out Type LANGFKNBCPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void ICBCKCFFKHL<T>(byte[][] FCPDHMADLEN, object[] ALNIADCGBKI, ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL DDJJCGDLPGH);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T HFDBKOHFBHM<T>(object[] ALNIADCGBKI, ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL DDJJCGDLPGH);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HHBBONDIJFK<T> : global::JECENNBIMEI<T>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] FCPDHMADLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] FKBMENLCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] OLGKJIDDCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::ICBCKCFFKHL<T> AAJGLFPMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::HFDBKOHFBHM<T> NDMJEPJMHAN;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F500", Offset = "0x1C5DD00", VA = "0x181C5F500")]
	public HHBBONDIJFK(byte[][] FCPDHMADLEN, object[] FKBMENLCDEL, object[] OLGKJIDDCFN, global::ICBCKCFFKHL<T> AAJGLFPMKFO, global::HFDBKOHFBHM<T> NDMJEPJMHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3654210", Offset = "0x3652A10", VA = "0x183654210", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3654140", Offset = "0x3652940", VA = "0x183654140", Slot = "5")]
	public T JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class BOIGAMOGNCK : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class NECACNFFHCE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2E445D0", Offset = "0x2E42DD0", VA = "0x182E445D0")]
		static NECACNFFHCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private BOIGAMOGNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class MCGNEEBDHBF : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class JCGPBDFDODA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x33FDD20", Offset = "0x33FC520", VA = "0x1833FDD20")]
		static JCGPBDFDODA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private MCGNEEBDHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class IPGNAOCBNMG
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly KFGIIMCBFCL[] GMIENPFHIJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class MLCFDHPECEI : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class PLJBDNLACMM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x370E750", Offset = "0x370CF50", VA = "0x18370E750")]
		static PLJBDNLACMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class EONNIKOKKDK : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class ICJOPAEHBOH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x18097D0", Offset = "0x1807FD0", VA = "0x1818097D0")]
			static ICJOPAEHBOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private EONNIKOKKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private MLCFDHPECEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class LDALIBOIGAM : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class LBLOIOPBHBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1C62CE0", Offset = "0x1C614E0", VA = "0x181C62CE0")]
		static LBLOIOPBHBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class MJOEAIADFLH : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class NFMBKMFDCAK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x34B8370", Offset = "0x34B6B70", VA = "0x1834B8370")]
			static NFMBKMFDCAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private MJOEAIADFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private LDALIBOIGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class LKMNILBNLEB : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class AHEBOGABFEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x33B5040", Offset = "0x33B3840", VA = "0x1833B5040")]
		static AHEBOGABFEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class NFMODOKIGPE : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class KHPBNGAOENF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x260A460", Offset = "0x2608C60", VA = "0x18260A460")]
			static KHPBNGAOENF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private NFMODOKIGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private LKMNILBNLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class MFFHBNCHDEG : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class FLOLEIPODLI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2C83F00", Offset = "0x2C82700", VA = "0x182C83F00")]
		static FLOLEIPODLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class DHCIAEAAFHA : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class JNCKFGLONHL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x25B6310", Offset = "0x25B4B10", VA = "0x1825B6310")]
			static JNCKFGLONHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private DHCIAEAAFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private MFFHBNCHDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class MEPIDDFCIHG : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class CNGHBPNBDIA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x28D8590", Offset = "0x28D6D90", VA = "0x1828D8590")]
		static CNGHBPNBDIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class CBHNAKGPFIK : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class DPEEDHHOHLC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x392D510", Offset = "0x392BD10", VA = "0x18392D510")]
			static DPEEDHHOHLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private CBHNAKGPFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private MEPIDDFCIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class ECPBNIBGIFI : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class NDDHDLBBECH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2E42900", Offset = "0x2E41100", VA = "0x182E42900")]
		static NDDHDLBBECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class IENHIIEBFDK : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class NJNDOJHMCHB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9DC0", Offset = "0x2AE85C0", VA = "0x182AE9DC0")]
			static NJNDOJHMCHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private IENHIIEBFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private ECPBNIBGIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class LFNDLIALNFF : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class LJBDAOGOCAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0A40", Offset = "0x2FDF240", VA = "0x182FE0A40")]
		static LJBDAOGOCAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class HCCNLLKIIEF : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GNPJEBDBGHD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x343E170", Offset = "0x343C970", VA = "0x18343E170")]
			static GNPJEBDBGHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private HCCNLLKIIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private LFNDLIALNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class BEDDEHLNNHH : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class DJBEFDIDPCD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB87F0", Offset = "0x2BB6FF0", VA = "0x182BB87F0")]
		static DJBEFDIDPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class IGFOBMBHLAN : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class FFIPPKBDFOO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x322C500", Offset = "0x322AD00", VA = "0x18322C500")]
			static FFIPPKBDFOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private IGFOBMBHLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private BEDDEHLNNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class DLBJJLGKJLP : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class OPIHDNMJHNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x357BDD0", Offset = "0x357A5D0", VA = "0x18357BDD0")]
		static OPIHDNMJHNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class KJCKDGDDPCH : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class GGDJDBBPMEL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x272B5B0", Offset = "0x2729DB0", VA = "0x18272B5B0")]
			static GGDJDBBPMEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private KJCKDGDDPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private DLBJJLGKJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class LIMALDHKBDC : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class GAPOAGCJMBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3786C10", Offset = "0x3785410", VA = "0x183786C10")]
		static GAPOAGCJMBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class CMDBJPBIMDG : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class BFOILBPGLGF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3D207C0", Offset = "0x3D1EFC0", VA = "0x183D207C0")]
			static BFOILBPGLGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private CMDBJPBIMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private LIMALDHKBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class IAKGGIHJFPJ : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class IMAPNCBEMIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x35F7F00", Offset = "0x35F6700", VA = "0x1835F7F00")]
		static IMAPNCBEMIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class JEHJFAOGIMK : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class OPPFEHAMHCM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x357DBA0", Offset = "0x357C3A0", VA = "0x18357DBA0")]
			static OPPFEHAMHCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private JEHJFAOGIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private IAKGGIHJFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class IOCKGLKKDAH : KFGIIMCBFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class LBNOPNGLAPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1C6B7D0", Offset = "0x1C69FD0", VA = "0x181C6B7D0")]
		static LBNOPNGLAPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class OINHHBJPNOD : KFGIIMCBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class LAMIOAKGFLD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::JECENNBIMEI<T> NFKOKOAEDHI;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1C620F0", Offset = "0x1C608F0", VA = "0x181C620F0")]
			static LAMIOAKGFLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly KFGIIMCBFCL PDCOCJBICGC;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly KFGIIMCBFCL[] FEKGKGJAOJO;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		private OINHHBJPNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
		public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly KFGIIMCBFCL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::JECENNBIMEI<object> PFNDGFBHLOB;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private IOCKGLKKDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x14C3A90", Offset = "0x14C2290", VA = "0x1814C3A90", Slot = "4")]
	public global::JECENNBIMEI<T> OLHPIMCDMLA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct MDFLHGAOMAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] GNBDLPKEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int FNJAAMNIGIL;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2DACB50", Offset = "0x2DAB350", VA = "0x182DACB50")]
	public MDFLHGAOMAC(int FEGAPCINCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC980", Offset = "0x2DAB180", VA = "0x182DAC980")]
	public void LGCDELLOPGJ(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC680", Offset = "0x2DAAE80", VA = "0x182DAC680")]
	public T[] DDHHGNBIMIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class INHNEEECIGH : global::LDGNEIEFCJO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly INHNEEECIGH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x524C830", Offset = "0x524B030", VA = "0x18524C830")]
	public INHNEEECIGH(int KPLHKBDCMEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class LDGNEIEFCJO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int KPLHKBDCMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object PCBODDFBIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int LHHBOCAHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] FBHCNKPFNKC;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4698580", Offset = "0x4696D80", VA = "0x184698580")]
	public LDGNEIEFCJO(int KPLHKBDCMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4697280", Offset = "0x4695A80", VA = "0x184697280")]
	public T[] BICKEFNCIOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4697EF0", Offset = "0x46966F0", VA = "0x184697EF0")]
	public void JDHGEIAINDP(T[] CIMBPHJAHGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class PIPOGPCBCNM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class HDMOCCHAMPE : IComparable<HDMOCCHAMPE>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class PEAGMJFBNGL : IEnumerable<HDMOCCHAMPE>, IEnumerable, IEnumerator<HDMOCCHAMPE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private HDMOCCHAMPE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public HDMOCCHAMPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private HDMOCCHAMPE System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
			[DebuggerHidden]
			public PEAGMJFBNGL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x550C420", Offset = "0x550AC20", VA = "0x18550C420", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x550C550", Offset = "0x550AD50", VA = "0x18550C550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x550C4B0", Offset = "0x550ACB0", VA = "0x18550C4B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HDMOCCHAMPE> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x550C4B0", Offset = "0x550ACB0", VA = "0x18550C4B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class LCDLPBCOJEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public LCDLPBCOJEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6FFFD0", Offset = "0x6FE7D0", VA = "0x1806FFFD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x6FFFD0", Offset = "0x6FE7D0", VA = "0x1806FFFD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly HDMOCCHAMPE[] GENKFOGPHLJ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] MIOJMDJJNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong PPKFCNPJALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int PPNOOBBHMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string LLOAFLJINLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private HDMOCCHAMPE[] MMOKPNBMHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] AJGDIJNDKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int FCKFNIPNJCI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ODNDPPHGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCD8EC0", Offset = "0xCD76C0", VA = "0x180CD8EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x54FF020", Offset = "0x54FD820", VA = "0x1854FF020")]
		public HDMOCCHAMPE(ulong NHBANLNJEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x54FEA70", Offset = "0x54FD270", VA = "0x1854FEA70")]
		public HDMOCCHAMPE LGCDELLOPGJ(ulong NHBANLNJEIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x54FEA20", Offset = "0x54FD220", VA = "0x1854FEA20")]
		public HDMOCCHAMPE LGCDELLOPGJ(ulong NHBANLNJEIH, int NPHADDCNBHE, string LLOAFLJINLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x54FECA0", Offset = "0x54FD4A0", VA = "0x1854FECA0")]
		public HDMOCCHAMPE OAPGFINJKJB(byte[] LPBINJHCNHK, ref int OBHIANFIDPA, ref int HANLMOJOJNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x54FDC40", Offset = "0x54FC440", VA = "0x1854FDC40")]
		internal static int GOCHHNGIOBI(ulong[] CIMBPHJAHGJ, int LHHBOCAHDEE, int EEOHOPIJABN, ulong NPHADDCNBHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x54FDC10", Offset = "0x54FC410", VA = "0x1854FDC10", Slot = "4")]
		public int CompareTo(HDMOCCHAMPE HAKPJJGEGOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x54FDCC0", Offset = "0x54FC4C0", VA = "0x1854FDCC0")]
		[IteratorStateMachine(typeof(PEAGMJFBNGL))]
		public IEnumerable<HDMOCCHAMPE> IFJLNBIGPPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x54FEE50", Offset = "0x54FD650", VA = "0x1854FEE50")]
		public void OBIOMJHHPHA(ILGenerator PIBDAJMBNKK, LocalBuilder LPBINJHCNHK, LocalBuilder HANLMOJOJNB, LocalBuilder NHBANLNJEIH, Action<KeyValuePair<string, int>> FKOFAHINKEJ, Action JDJLFGHBKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x54FDD30", Offset = "0x54FC530", VA = "0x1854FDD30")]
		private static void IHKCOJFDIOI(ILGenerator PIBDAJMBNKK, LocalBuilder LPBINJHCNHK, LocalBuilder HANLMOJOJNB, LocalBuilder NHBANLNJEIH, Action<KeyValuePair<string, int>> FKOFAHINKEJ, Action JDJLFGHBKKK, HDMOCCHAMPE[] MMOKPNBMHBD, int FCKFNIPNJCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class DKFJFIODEOG : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<HDMOCCHAMPE> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<HDMOCCHAMPE> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<HDMOCCHAMPE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private HDMOCCHAMPE <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x54FCD20", Offset = "0x54FB520", VA = "0x1854FCD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x97CE80", Offset = "0x97B680", VA = "0x18097CE80")]
		[DebuggerHidden]
		public DKFJFIODEOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x54FCD70", Offset = "0x54FB570", VA = "0x1854FCD70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x54FC8B0", Offset = "0x54FB0B0", VA = "0x1854FC8B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x54FCE50", Offset = "0x54FB650", VA = "0x1854FCE50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x54FCEA0", Offset = "0x54FB6A0", VA = "0x1854FCEA0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x54FCCE0", Offset = "0x54FB4E0", VA = "0x1854FCCE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x54FCC40", Offset = "0x54FB440", VA = "0x1854FCC40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x54FCC40", Offset = "0x54FB440", VA = "0x1854FCC40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly HDMOCCHAMPE FECENBBKPOP;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x550E950", Offset = "0x550D150", VA = "0x18550E950")]
	public PIPOGPCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x550E740", Offset = "0x550CF40", VA = "0x18550E740")]
	public void LGCDELLOPGJ(byte[] EBBNNMNMLOE, int NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x550E350", Offset = "0x550CB50", VA = "0x18550E350")]
	public bool ALMAIKHKGCN(ArraySegment<byte> NHBANLNJEIH, out int NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x550E8C0", Offset = "0x550D0C0", VA = "0x18550E8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x550E410", Offset = "0x550CC10", VA = "0x18550E410")]
	private static void AMIKLPKCCGF(IEnumerable<HDMOCCHAMPE> MMOKPNBMHBD, StringBuilder GEKGIFCBLAA, int LJGHFLLENHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x550E6B0", Offset = "0x550CEB0", VA = "0x18550E6B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x550E6B0", Offset = "0x550CEB0", VA = "0x18550E6B0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x550E850", Offset = "0x550D050", VA = "0x18550E850")]
	[IteratorStateMachine(typeof(DKFJFIODEOG))]
	private static IEnumerable<KeyValuePair<string, int>> OHHFHILBCJG(IEnumerable<HDMOCCHAMPE> MMOKPNBMHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x550E710", Offset = "0x550CF10", VA = "0x18550E710")]
	public void IFFGLBHLAEG(ILGenerator PIBDAJMBNKK, LocalBuilder LPBINJHCNHK, LocalBuilder HANLMOJOJNB, LocalBuilder NHBANLNJEIH, Action<KeyValuePair<string, int>> FKOFAHINKEJ, Action JDJLFGHBKKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class PIAPCPICEOG
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo NKFFKCCCELH;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x550D2F0", Offset = "0x550BAF0", VA = "0x18550D2F0")]
	public static ulong HBIPADCHJBE(byte[] EBBNNMNMLOE, ref int OBHIANFIDPA, ref int HANLMOJOJNB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class FHBFAANHIOC
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1580", Offset = "0x4E9FD80", VA = "0x184EA1580")]
	public static void KHJOJBFPAAN(ref byte[] EBBNNMNMLOE, int OBHIANFIDPA, int PDMEEILANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1470", Offset = "0x4E9FC70", VA = "0x184EA1470")]
	public static void FJDFENLMCBM(ref byte[] CIMBPHJAHGJ, int LEENEPJNFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1350", Offset = "0x4E9FB50", VA = "0x184EA1350")]
	public static byte[] BAFCOANHEMD(byte[] OEDLDNKMKMJ, int LEENEPJNFPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class DLDLONFFJAI
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B7E0", Offset = "0x4E99FE0", VA = "0x184E9B7E0")]
	public static bool GKAHDDHENKO(byte[] NJKAENDLCIH, int OHCILKBICIH, int DOJACPAGIPN, byte[] AECHOJBMHIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class HMBDJJGPCIK<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct JEEHDKLDDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] PPKFCNPJALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T PPNOOBBHMAN;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3401880", Offset = "0x3400080", VA = "0x183401880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class LHKJKMIIECH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::HMBDJJGPCIK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private JEEHDKLDDGF[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private JEEHDKLDDGF[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D05E00", Offset = "0x2D04600", VA = "0x182D05E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1492A40", Offset = "0x1491240", VA = "0x181492A40")]
		[DebuggerHidden]
		public LHKJKMIIECH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2D04AB0", Offset = "0x2D032B0", VA = "0x182D04AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2D059E0", Offset = "0x2D041E0", VA = "0x182D059E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly JEEHDKLDDGF[][] OAGAHIGDAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong LDHNJMPDFOI;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x32488D0", Offset = "0x32470D0", VA = "0x1832488D0")]
	public HMBDJJGPCIK(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3248900", Offset = "0x3247100", VA = "0x183248900")]
	public HMBDJJGPCIK(int EBGHKBFPDCN, float LGJEHEDPACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x39F6580", Offset = "0x39F4D80", VA = "0x1839F6580")]
	public void LGCDELLOPGJ(byte[] NHBANLNJEIH, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x39F5630", Offset = "0x39F3E30", VA = "0x1839F5630")]
	private bool IHCPDMFOEDK(byte[] NHBANLNJEIH, T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x39F20D0", Offset = "0x39F08D0", VA = "0x1839F20D0")]
	public bool FEEDILOKHNP(ArraySegment<byte> NHBANLNJEIH, out T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3242D40", Offset = "0x3241540", VA = "0x183242D40")]
	private static ulong FFCGLLOHFJI(byte[] NGMFABJMIHP, int OBHIANFIDPA, int FCKFNIPNJCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x32488A0", Offset = "0x32470A0", VA = "0x1832488A0")]
	private static int LHOFIGFGAJB(int PFMGLEEDMPP, float LGJEHEDPACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3242E30", Offset = "0x3241630", VA = "0x183242E30", Slot = "4")]
	[IteratorStateMachine(typeof(global::HMBDJJGPCIK<>.LHKJKMIIECH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1819040", Offset = "0x1817840", VA = "0x181819040", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class NGCHANLMNCJ : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] FHMAKFIDKKD;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] DHEOCJCIGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int COLJIOPIADF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BNCOMJLADCG
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5509880", Offset = "0x5508080", VA = "0x185509880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x55099F0", Offset = "0x55081F0", VA = "0x1855099F0")]
	static NGCHANLMNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5509C70", Offset = "0x5508470", VA = "0x185509C70")]
	public NGCHANLMNCJ(byte[] AKMACNMDDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x55098D0", Offset = "0x55080D0", VA = "0x1855098D0")]
	public OpCode NGEPIFBIIGB()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct CBEHFCKEDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid PPNOOBBHMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte NEOIENMACNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte OPMMOKDHFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte FIDDMMIGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte CBOEJKKPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte AMELDOLOPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte NFEODLAGLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte LDBJNMCDIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte JPINPEDLNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte IFJPHDHJAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte KAHGOEMCOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte AFGOEPCNIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte GAGGLAOJOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte HFKFNBDEKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte HGECJOFMJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte EGDAABICFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte EENHPJCMGDF;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] DPMHEMJABMK;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] ICEFOFJFFLB;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4E95700", Offset = "0x4E93F00", VA = "0x184E95700")]
	public CBEHFCKEDKD(ref Guid NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4E95710", Offset = "0x4E93F10", VA = "0x184E95710")]
	public CBEHFCKEDKD(ref ArraySegment<byte> KPCIIILBFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4E94110", Offset = "0x4E92910", VA = "0x184E94110")]
	private static byte HDFCMBFDGKA(byte[] EBBNNMNMLOE, int FJJHNCABCGN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4E95520", Offset = "0x4E93D20", VA = "0x184E95520")]
	private static byte LGMOCFBPEFJ(byte JBKIIGINOKM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4E941D0", Offset = "0x4E929D0", VA = "0x184E941D0")]
	public void IGHCIFCIEBF(byte[] DNLJJNDPNCG, int OBHIANFIDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class KFDPNIMLGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5250380", Offset = "0x524EB80", VA = "0x185250380")]
	public static bool CAAOAAIDCIC(byte FCOOKAEOJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5250560", Offset = "0x524ED60", VA = "0x185250560")]
	public static bool IKFGFNKCFEK(byte FCOOKAEOJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5251C50", Offset = "0x5250450", VA = "0x185251C50")]
	public static sbyte MIPHCIHNFBC(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x52502A0", Offset = "0x524EAA0", VA = "0x1852502A0")]
	public static short AADONJEPOKD(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x52504F0", Offset = "0x524ECF0", VA = "0x1852504F0")]
	public static int IKEJNHAIFFK(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5251CC0", Offset = "0x52504C0", VA = "0x185251CC0")]
	public static long NPCEEMIJACA(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5250390", Offset = "0x524EB90", VA = "0x185250390")]
	public static byte GEPDPMFNHLN(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5250310", Offset = "0x524EB10", VA = "0x185250310")]
	public static ushort BOMDBHCILDN(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5250DA0", Offset = "0x524F5A0", VA = "0x185250DA0")]
	public static uint KMMDAIICKKN(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5250E20", Offset = "0x524F620", VA = "0x185250E20")]
	public static ulong MBFEONPIMGJ(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5250F30", Offset = "0x524F730", VA = "0x185250F30")]
	public static float MCOOCPKEOHI(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5250400", Offset = "0x524EC00", VA = "0x185250400")]
	public static double HFIDGPIMPKJ(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x52505D0", Offset = "0x524EDD0", VA = "0x1852505D0")]
	public static int JELPDDNLPKF(ref byte[] DNLJJNDPNCG, int OBHIANFIDPA, ulong NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5251020", Offset = "0x524F820", VA = "0x185251020")]
	public static int MGBJAKJJNAD(ref byte[] DNLJJNDPNCG, int OBHIANFIDPA, long NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5251D70", Offset = "0x5250570", VA = "0x185251D70")]
	public static bool NPGJKJMAFLF(byte[] EBBNNMNMLOE, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class NGHHHIPCJAN
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class FPAGIOAJIBG : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public FPAGIOAJIBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x54FD7A0", Offset = "0x54FBFA0", VA = "0x1854FD7A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x54FD340", Offset = "0x54FBB40", VA = "0x1854FD340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x54FD890", Offset = "0x54FC090", VA = "0x1854FD890")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x54FD8E0", Offset = "0x54FC0E0", VA = "0x1854FD8E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x54FD760", Offset = "0x54FBF60", VA = "0x1854FD760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x54FD6B0", Offset = "0x54FBEB0", VA = "0x1854FD6B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x54FD6B0", Offset = "0x54FBEB0", VA = "0x1854FD6B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class JHEFGIFBAAD : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public JHEFGIFBAAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5501CB0", Offset = "0x55004B0", VA = "0x185501CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5501850", Offset = "0x5500050", VA = "0x185501850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5501DA0", Offset = "0x55005A0", VA = "0x185501DA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5501DF0", Offset = "0x55005F0", VA = "0x185501DF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5501C70", Offset = "0x5500470", VA = "0x185501C70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5501BC0", Offset = "0x55003C0", VA = "0x185501BC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5501BC0", Offset = "0x55003C0", VA = "0x185501BC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5509F10", Offset = "0x5508710", VA = "0x185509F10")]
	public static bool KFCBFJIDCBM(this TypeInfo EHPFPOFFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5509DF0", Offset = "0x55085F0", VA = "0x185509DF0")]
	public static bool JBDJJABLEJH(this TypeInfo EHPFPOFFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5509D80", Offset = "0x5508580", VA = "0x185509D80")]
	public static IEnumerable<PropertyInfo> HJCCBFOEPCN(this Type EHPFPOFFCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5509CF0", Offset = "0x55084F0", VA = "0x185509CF0")]
	[IteratorStateMachine(typeof(FPAGIOAJIBG))]
	private static IEnumerable<PropertyInfo> ELGBBLEGAKC(Type EHPFPOFFCEJ, HashSet<string> KDLFKGCMPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5509FD0", Offset = "0x55087D0", VA = "0x185509FD0")]
	public static IEnumerable<FieldInfo> LGPIPNIHEDD(this Type EHPFPOFFCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x550A040", Offset = "0x5508840", VA = "0x18550A040")]
	[IteratorStateMachine(typeof(JHEFGIFBAAD))]
	private static IEnumerable<FieldInfo> NFJOECAGADA(Type EHPFPOFFCEJ, HashSet<string> KDLFKGCMPEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class EMBMDJJMJBF
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding MNCJJLODFIO;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class HDCBHJHKLGE
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20")]
	public static string OOOLHKDNMCA(string GLKCNJGCDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x52406F0", Offset = "0x523EEF0", VA = "0x1852406F0")]
	public static string EPOJPCKJLGG(string GLKCNJGCDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5240500", Offset = "0x523ED00", VA = "0x185240500")]
	public static string BLJMLFIPPOK(string GLKCNJGCDME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class HFNFGBMJBLO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class PHEIGEEDPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type PPKFCNPJALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue PPNOOBBHMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int EHNAIGECHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public PHEIGEEDPCJ MHBDBPNPBIA;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2F13820", Offset = "0x2F12020", VA = "0x182F13820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2F137E0", Offset = "0x2F11FE0", VA = "0x182F137E0")]
		private int EIFLHBHGPLJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public PHEIGEEDPCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class BHNMANCJJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public BHNMANCJJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private PHEIGEEDPCJ[] OAGAHIGDAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int GIGKIGNPJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object AKIDNGEFNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float LGJEHEDPACH;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3651D30", Offset = "0x3650530", VA = "0x183651D30")]
	public HFNFGBMJBLO(int EBGHKBFPDCN = 4, float LGJEHEDPACH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3651BF0", Offset = "0x36503F0", VA = "0x183651BF0")]
	public bool KIPDGIEJLFO(Type NHBANLNJEIH, TValue NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3651BB0", Offset = "0x36503B0", VA = "0x183651BB0")]
	public bool KIPDGIEJLFO(Type NHBANLNJEIH, Func<Type, TValue> NNLJAJHFGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3651790", Offset = "0x364FF90", VA = "0x183651790")]
	private bool IHCPDMFOEDK(Type NHBANLNJEIH, Func<Type, TValue> NNLJAJHFGJD, out TValue FFAGIGNJPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3650AC0", Offset = "0x364F2C0", VA = "0x183650AC0")]
	private bool FANNMGCMAEA(PHEIGEEDPCJ[] OAGAHIGDAOM, Type PEHKEODNOKO, PHEIGEEDPCJ LDACFCCBNGB, Func<Type, TValue> NNLJAJHFGJD, out TValue FFAGIGNJPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3651220", Offset = "0x364FA20", VA = "0x183651220")]
	public bool FEEDILOKHNP(Type NHBANLNJEIH, out TValue NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3650970", Offset = "0x364F170", VA = "0x183650970")]
	public TValue CJEAEPMIFBE(Type NHBANLNJEIH, Func<Type, TValue> NNLJAJHFGJD)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x32488A0", Offset = "0x32470A0", VA = "0x1832488A0")]
	private static int LHOFIGFGAJB(int PFMGLEEDMPP, float LGJEHEDPACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3651D00", Offset = "0x3650500", VA = "0x183651D00")]
	private static void KJFBOHIOAPI(ref PHEIGEEDPCJ BPGGLDOJMMG, PHEIGEEDPCJ NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3651D00", Offset = "0x3650500", VA = "0x183651D00")]
	private static void KJFBOHIOAPI(ref PHEIGEEDPCJ[] BPGGLDOJMMG, PHEIGEEDPCJ[] NPHADDCNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class EDMJGLDOHNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder LFDODELMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder GKBLPGBMGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object PCBODDFBIIE;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C440", Offset = "0x4E9AC40", VA = "0x184E9C440")]
	public TypeBuilder MEAJOJHCMJI(string LOIAMCEJAFO, TypeAttributes DMLKCNDIINM, Type FAAJOMIIHED, Type[] NCIKANJGGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C510", Offset = "0x4E9AD10", VA = "0x184E9C510")]
	public EDMJGLDOHNC(string KNHCIIJKNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class FLBMMMNLEBK
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A10", Offset = "0x4EA0210", VA = "0x184EA1A10")]
	private static MethodInfo PBMKNNDBCKG(LambdaExpression BHDECDAOOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x268CDA0", Offset = "0x268B5A0", VA = "0x18268CDA0")]
	public static MethodInfo DBLNCGHNFHM<T>(Expression<Func<T>> BHDECDAOOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x268CDA0", Offset = "0x268B5A0", VA = "0x18268CDA0")]
	public static MethodInfo DBLNCGHNFHM<T, TR>(Expression<Func<T, TR>> BHDECDAOOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x268CDA0", Offset = "0x268B5A0", VA = "0x18268CDA0")]
	public static MethodInfo DBLNCGHNFHM<T>(Expression<Action<T>> BHDECDAOOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x268CDA0", Offset = "0x268B5A0", VA = "0x18268CDA0")]
	public static MethodInfo DBLNCGHNFHM<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> BHDECDAOOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x268CDB0", Offset = "0x268B5B0", VA = "0x18268CDB0")]
	private static MemberInfo FCOGIEDPNAD<T>(Expression<T> KJFIHMLIKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x268CE60", Offset = "0x268B660", VA = "0x18268CE60")]
	public static PropertyInfo GMGJDEINDGG<T, TR>(Expression<Func<T, TR>> BHDECDAOOKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct FOFHGFJABDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int AOKAFHMCMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool CKIFPCHKDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator PIBDAJMBNKK;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1C90", Offset = "0x4EA0490", VA = "0x184EA1C90")]
	public FOFHGFJABDE(ILGenerator PIBDAJMBNKK, int AOKAFHMCMMJ, bool CKIFPCHKDGE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1C00", Offset = "0x4EA0400", VA = "0x184EA1C00")]
	public FOFHGFJABDE(ILGenerator PIBDAJMBNKK, int AOKAFHMCMMJ, Type EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AE0", Offset = "0x4EA02E0", VA = "0x184EA1AE0")]
	public void NLPFPIKHPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class FCMDFMIMJBH
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0630", Offset = "0x4E9EE30", VA = "0x184EA0630")]
	public static void PFLBEPPABAA(this ILGenerator PIBDAJMBNKK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0860", Offset = "0x4E9F060", VA = "0x184EA0860")]
	public static void PFLBEPPABAA(this ILGenerator PIBDAJMBNKK, LocalBuilder EDFIGALJOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4EA08A0", Offset = "0x4E9F0A0", VA = "0x184EA08A0")]
	public static void PHHLAJHKNJI(this ILGenerator PIBDAJMBNKK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0AD0", Offset = "0x4E9F2D0", VA = "0x184EA0AD0")]
	public static void PHHLAJHKNJI(this ILGenerator PIBDAJMBNKK, LocalBuilder EDFIGALJOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FC30", Offset = "0x4E9E430", VA = "0x184E9FC30")]
	public static void GJPMBELOCEE(this ILGenerator PIBDAJMBNKK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FB20", Offset = "0x4E9E320", VA = "0x184E9FB20")]
	public static void GJPMBELOCEE(this ILGenerator PIBDAJMBNKK, LocalBuilder EDFIGALJOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0360", Offset = "0x4E9EB60", VA = "0x184EA0360")]
	public static void KPEFJNKPEHB(this ILGenerator PIBDAJMBNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FB10", Offset = "0x4E9E310", VA = "0x184E9FB10")]
	public static void EKOOGNINLIN(this ILGenerator PIBDAJMBNKK, bool NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FF10", Offset = "0x4E9E710", VA = "0x184E9FF10")]
	public static void KJMHPLIOCBC(this ILGenerator PIBDAJMBNKK, int NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0490", Offset = "0x4E9EC90", VA = "0x184EA0490")]
	public static void ODFCHPFNODH(this ILGenerator PIBDAJMBNKK, Type EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0580", Offset = "0x4E9ED80", VA = "0x184EA0580")]
	public static void OECBHGCLAGK(this ILGenerator PIBDAJMBNKK, Type EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0B10", Offset = "0x4E9F310", VA = "0x184EA0B10")]
	public static void POLGMHJOLOP(this ILGenerator PIBDAJMBNKK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FA90", Offset = "0x4E9E290", VA = "0x184E9FA90")]
	public static void EBGGMEKAKHG(this ILGenerator PIBDAJMBNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FD20", Offset = "0x4E9E520", VA = "0x184E9FD20")]
	public static void HFKHKOEBAOA(this ILGenerator PIBDAJMBNKK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FE10", Offset = "0x4E9E610", VA = "0x184E9FE10")]
	public static void JNDMLLIEFPP(this ILGenerator PIBDAJMBNKK, MethodInfo DLAKBGGDNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0370", Offset = "0x4E9EB70", VA = "0x184EA0370")]
	public static void MHBACBJADKE(this ILGenerator PIBDAJMBNKK, FieldInfo FJNBLFHIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0400", Offset = "0x4E9EC00", VA = "0x184EA0400")]
	public static void MMFNEIAJMKP(this ILGenerator PIBDAJMBNKK, ulong NPHADDCNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class BIINFGBLHON
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MFHLJKKOACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MFHLJKKOACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5507930", Offset = "0x5506130", VA = "0x185507930")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo HPODNFEOIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo FNDCDCKNFLF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string PFNDHDBPGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OJMAJGOCEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x4E92710", Offset = "0x4E90F10", VA = "0x184E92710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JNIIOCJNKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F03D0", Offset = "0x6EEBD0", VA = "0x1806F03D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801310", VA = "0x180802B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool ALHNKPFLNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F03E0", Offset = "0x6EEBE0", VA = "0x1806F03E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xC642D0", Offset = "0xC62AD0", VA = "0x180C642D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type ECHKLFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x717210", Offset = "0x715A10", VA = "0x180717210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DIGHFBFODMH
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo GHNMMMKKILA
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo HGFKKLDKKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5A0", Offset = "0x6DADA0", VA = "0x1806DC5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4E92C10", Offset = "0x4E91410", VA = "0x184E92C10")]
	protected BIINFGBLHON(Type EHPFPOFFCEJ, string LOIAMCEJAFO, string NKCEBILBNLE, bool OGPBEEMDAMJ, bool NMCKPKANGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4E92950", Offset = "0x4E91150", VA = "0x184E92950")]
	public BIINFGBLHON(FieldInfo CDFJHEMMDBB, string LOIAMCEJAFO, bool EOFLBODEIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4E92A60", Offset = "0x4E91260", VA = "0x184E92A60")]
	public BIINFGBLHON(PropertyInfo CDFJHEMMDBB, string LOIAMCEJAFO, bool EOFLBODEIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4E927E0", Offset = "0x4E90FE0", VA = "0x184E927E0")]
	private static MethodInfo MKLJKLANEMK(MemberInfo CDFJHEMMDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AB50", Offset = "0x1F29350", VA = "0x181F2AB50")]
	public T JCGBKICOACO<T>(bool KKJMBMNFEMD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4E92650", Offset = "0x4E90E50", VA = "0x184E92650", Slot = "4")]
	public virtual void CCJNIMENPGI(ILGenerator PIBDAJMBNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4E92720", Offset = "0x4E90F20", VA = "0x184E92720", Slot = "5")]
	public virtual void MGILBOGBFFM(ILGenerator PIBDAJMBNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class FFDKEOHNNCL : BIINFGBLHON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string AOIBHCCBKOO;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0E40", Offset = "0x4E9F640", VA = "0x184EA0E40")]
	public FFDKEOHNNCL(string LOIAMCEJAFO, string AOIBHCCBKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0D40", Offset = "0x4E9F540", VA = "0x184EA0D40", Slot = "4")]
	public override void CCJNIMENPGI(ILGenerator PIBDAJMBNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0E00", Offset = "0x4E9F600", VA = "0x184EA0E00", Slot = "5")]
	public override void MGILBOGBFFM(ILGenerator PIBDAJMBNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class KJMHMOIDNIJ : BIINFGBLHON
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo FBLPKJBBIGG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo MNPAJJKJJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal FOFHGFJABDE EONMNHENHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal FOFHGFJABDE DDIFFFFENCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal FOFHGFJABDE HAABDECFOJM;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5252ED0", Offset = "0x52516D0", VA = "0x185252ED0")]
	public KJMHMOIDNIJ(string LOIAMCEJAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5252750", Offset = "0x5250F50", VA = "0x185252750", Slot = "4")]
	public override void CCJNIMENPGI(ILGenerator PIBDAJMBNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5252940", Offset = "0x5251140", VA = "0x185252940", Slot = "5")]
	public override void MGILBOGBFFM(ILGenerator PIBDAJMBNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5252820", Offset = "0x5251020", VA = "0x185252820")]
	public void HDJAOKIGKFI(ILGenerator PIBDAJMBNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class GEKCJNECGMB
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type ECHKLFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HAAEKCIBMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x711000", Offset = "0x70F800", VA = "0x180711000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JPAFLLNNGAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xC337A0", Offset = "0xC31FA0", VA = "0x180C337A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xC337C0", Offset = "0xC31FC0", VA = "0x180C337C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NPALFFJAHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BIINFGBLHON[] DHEDNKJDGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x717210", Offset = "0x715A10", VA = "0x180717210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BIINFGBLHON[] ICNOILGCDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5A50", Offset = "0x4EA4250", VA = "0x184EA5A50")]
	public GEKCJNECGMB(Type EHPFPOFFCEJ, Func<string, string> CHAEPJHAEKN, bool EOFLBODEIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5960", Offset = "0x4EA4160", VA = "0x184EA5960")]
	private static bool HBEJNBCBLAM(IEnumerator<ConstructorInfo> HPNODHKJODM, ref ConstructorInfo DDNJJKHFPJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct PLIHFMPLOPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong HPMCNMECMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int ODBOKKABIBK;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1C5CBE0", Offset = "0x1C5B3E0", VA = "0x181C5CBE0")]
	public PLIHFMPLOPB(ulong MJNGKJIPPJH, int IPPODBAKJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x550EAF0", Offset = "0x550D2F0", VA = "0x18550EAF0")]
	public void BHNKOCCFEPJ(ref PLIHFMPLOPB HAKPJJGEGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x550EB90", Offset = "0x550D390", VA = "0x18550EB90")]
	public static PLIHFMPLOPB NLILHNLJNJI(ref PLIHFMPLOPB HDPOKDCLGGE, ref PLIHFMPLOPB JBKIIGINOKM)
	{
		return default(PLIHFMPLOPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x550EB00", Offset = "0x550D300", VA = "0x18550EB00")]
	public void CKLMJOGDJJN(ref PLIHFMPLOPB HAKPJJGEGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x550EA50", Offset = "0x550D250", VA = "0x18550EA50")]
	public static PLIHFMPLOPB BHBFIFMLMFF(ref PLIHFMPLOPB HDPOKDCLGGE, ref PLIHFMPLOPB JBKIIGINOKM)
	{
		return default(PLIHFMPLOPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x550EA10", Offset = "0x550D210", VA = "0x18550EA10")]
	public void BCCGDGEECIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x550E9C0", Offset = "0x550D1C0", VA = "0x18550E9C0")]
	public static PLIHFMPLOPB BCCGDGEECIH(ref PLIHFMPLOPB HDPOKDCLGGE)
	{
		return default(PLIHFMPLOPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct DBMPPOMGJNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] DNLJJNDPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int OBHIANFIDPA;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ED0", Offset = "0x7F46D0", VA = "0x1807F5ED0")]
	public DBMPPOMGJNC(byte[] DNLJJNDPNCG, int LMLCHIPKJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E99050", Offset = "0x4E97850", VA = "0x184E99050")]
	public void JLKEODOEAGC(byte AOEMKAJNLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E98D60", Offset = "0x4E97560", VA = "0x184E98D60")]
	public void HHANIKELCAB(byte[] AOEMKAJNLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E98E00", Offset = "0x4E97600", VA = "0x184E98E00")]
	public void IJODMEDNCFF(byte[] AOEMKAJNLKN, int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E98EA0", Offset = "0x4E976A0", VA = "0x184E98EA0")]
	public void IJODMEDNCFF(byte[] AOEMKAJNLKN, int DAOIPFCHFFJ, int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E990B0", Offset = "0x4E978B0", VA = "0x184E990B0")]
	public void JMECAOGICBL(byte FCOOKAEOJMD, int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E98F50", Offset = "0x4E97750", VA = "0x184E98F50")]
	public void IMGFLCADMLH(string AOEMKAJNLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class KAJFKKHPBPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum ICLOOFNFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum JCCIOLGIPCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum KAAGKEJPFGI
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
	private static byte[] GOCHDFPHPND;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] HCFPFOAKBBH;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] MKHBNKPOAHE;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] HAHPBEFDJHA;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly KAAGKEJPFGI BKDBCILJOOA;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char JJBIEMBAKBG;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int DDHCMIBODPN;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int LLLEJNBJPLA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] BOCBLLJODPI;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x524FC50", Offset = "0x524E450", VA = "0x18524FC50")]
	private static byte[] PHJACKCIIJB(int GIGKIGNPJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x524F200", Offset = "0x524DA00", VA = "0x18524F200")]
	private static byte[] KOEOLELNIPL(int GIGKIGNPJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x524FA10", Offset = "0x524E210", VA = "0x18524FA10")]
	public static int PAKJDJLGFIK(ref byte[] DNLJJNDPNCG, int OBHIANFIDPA, float NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x524FB30", Offset = "0x524E330", VA = "0x18524FB30")]
	public static int PAKJDJLGFIK(ref byte[] DNLJJNDPNCG, int OBHIANFIDPA, double NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x524E8F0", Offset = "0x524D0F0", VA = "0x18524E8F0")]
	private static bool DEIDNIAAPCC(byte[] DNLJJNDPNCG, int EEOHOPIJABN, ulong FLMBPAIAFPF, ulong KMNPMADMCKG, ulong HANLMOJOJNB, ulong MOIHCJHPMHI, ulong PHNMIPKIIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x524E2B0", Offset = "0x524CAB0", VA = "0x18524E2B0")]
	private static void APAOLPMJBBE(uint CJDAMCDIJBM, int EONPAHCCEEL, out uint FEAJGKJPCLH, out int EBIPFAIGCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x524E3D0", Offset = "0x524CBD0", VA = "0x18524E3D0")]
	private static bool CHKPMMHJEGI(PLIHFMPLOPB PKJACMJMJGP, PLIHFMPLOPB CBDPMHLACML, PLIHFMPLOPB OBDGDLNEGOF, byte[] DNLJJNDPNCG, out int EEOHOPIJABN, out int EHOJFOMKKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x524F470", Offset = "0x524DC70", VA = "0x18524F470")]
	private static bool OADELHCGJDP(double BKHPIBPDKLA, ICLOOFNFHGC BCBFMICMNIP, byte[] DNLJJNDPNCG, out int EEOHOPIJABN, out int JFPHJKLMPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x524E1A0", Offset = "0x524C9A0", VA = "0x18524E1A0")]
	private static bool AHELLHMJLHD(double BKHPIBPDKLA, ICLOOFNFHGC BCBFMICMNIP, byte[] DNLJJNDPNCG, out int EEOHOPIJABN, out int GCJFEICCIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x524F2E0", Offset = "0x524DAE0", VA = "0x18524F2E0")]
	private static bool LMDKKHPNLDN(double NPHADDCNBHE, ref DBMPPOMGJNC BGIJJBPKKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x524E9F0", Offset = "0x524D1F0", VA = "0x18524E9F0")]
	private static bool HGPKCBMONEN(double NPHADDCNBHE, ref DBMPPOMGJNC BGIJJBPKKEN, JCCIOLGIPCD BCBFMICMNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x524F830", Offset = "0x524E030", VA = "0x18524F830")]
	private static void OJEJFDDBDLL(byte[] ANLJGMLNJDI, int EEOHOPIJABN, int GCJFEICCIKN, int GLMNJKJJMMJ, ref DBMPPOMGJNC BGIJJBPKKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x524DEA0", Offset = "0x524C6A0", VA = "0x18524DEA0")]
	private static void ABNOLCOKIMB(byte[] ANLJGMLNJDI, int EEOHOPIJABN, int IPPODBAKJAG, ref DBMPPOMGJNC BGIJJBPKKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x524F050", Offset = "0x524D850", VA = "0x18524F050")]
	private static bool IKKLIOOEEKN(double BKHPIBPDKLA, JCCIOLGIPCD BCBFMICMNIP, int MMFDBPBFBPM, byte[] MJDNPIGDEEP, out bool DDKFKHILFLH, out int EEOHOPIJABN, out int JHCOKPMEFAB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct NNAIPDNLJMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double ECNMDFEDCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong AGKIHIOIPEP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct PGIOOFNDAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float HPMCNMECMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint OMJLHJKGFBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct CMCIKOHOCND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong LMGMIBDNCPJ;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4E98B80", Offset = "0x4E97380", VA = "0x184E98B80")]
	public CMCIKOHOCND(double ECNMDFEDCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E98B90", Offset = "0x4E97390", VA = "0x184E98B90")]
	public CMCIKOHOCND(PLIHFMPLOPB ECNMDFEDCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E98870", Offset = "0x4E97070", VA = "0x184E98870")]
	public PLIHFMPLOPB JMFLNIMBHBF()
	{
		return default(PLIHFMPLOPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E987E0", Offset = "0x4E96FE0", VA = "0x184E987E0")]
	public PLIHFMPLOPB IMBIPCNIBDH()
	{
		return default(PLIHFMPLOPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D5000", Offset = "0x6D3800", VA = "0x1806D5000")]
	public ulong EDPLBDJMDAF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E98A70", Offset = "0x4E97270", VA = "0x184E98A70")]
	public double MKBLFLFIJFF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E98590", Offset = "0x4E96D90", VA = "0x184E98590")]
	public double AAAOGBAGLKH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E98680", Offset = "0x4E96E80", VA = "0x184E98680")]
	public int CGIHBADFJLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E98650", Offset = "0x4E96E50", VA = "0x184E98650")]
	public ulong BHJCBCFLBAF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E987C0", Offset = "0x4E96FC0", VA = "0x184E987C0")]
	public bool HHGNMOAILMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E98770", Offset = "0x4E96F70", VA = "0x184E98770")]
	public bool GICBLPAKOGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E98620", Offset = "0x4E96E20", VA = "0x184E98620")]
	public bool ABEMGIFNCGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E98790", Offset = "0x4E96F90", VA = "0x184E98790")]
	public bool HEJHHIIAAFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E98750", Offset = "0x4E96F50", VA = "0x184E98750")]
	public int FEJGKBLODJG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E988F0", Offset = "0x4E970F0", VA = "0x184E988F0")]
	public void KBCNMPKGKMP(out PLIHFMPLOPB DAEOCCIFCMA, out PLIHFMPLOPB EABPPOAEHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E98B30", Offset = "0x4E97330", VA = "0x184E98B30")]
	public bool PCFHAGBOMEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E98B20", Offset = "0x4E97320", VA = "0x184E98B20")]
	public double NPHADDCNBHE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E98B00", Offset = "0x4E97300", VA = "0x184E98B00")]
	public static int NECECKELDHB(int DFFIJEBHEAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E98A60", Offset = "0x4E97260", VA = "0x184E98A60")]
	public static double MDEMOGFHBGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4E986B0", Offset = "0x4E96EB0", VA = "0x184E986B0")]
	public static ulong COHENJMNIMG(PLIHFMPLOPB PKEOGHNLKHA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct GDEDGPBKOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint CDMHGBDHGHH;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F35080", Offset = "0x2F33880", VA = "0x182F35080")]
	public GDEDGPBKOBN(float HPMCNMECMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5490", Offset = "0x4EA3C90", VA = "0x184EA5490")]
	public PLIHFMPLOPB JMFLNIMBHBF()
	{
		return default(PLIHFMPLOPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40")]
	public uint BOFOPKBLCDE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5460", Offset = "0x4EA3C60", VA = "0x184EA5460")]
	public int CGIHBADFJLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5440", Offset = "0x4EA3C40", VA = "0x184EA5440")]
	public uint BHJCBCFLBAF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5480", Offset = "0x4EA3C80", VA = "0x184EA5480")]
	public bool HHGNMOAILMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5500", Offset = "0x4EA3D00", VA = "0x184EA5500")]
	public void KBCNMPKGKMP(out PLIHFMPLOPB DAEOCCIFCMA, out PLIHFMPLOPB EABPPOAEHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5660", Offset = "0x4EA3E60", VA = "0x184EA5660")]
	public bool PCFHAGBOMEG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct CGKCEIKHJNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong MJNGKJIPPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short FCNICHAPEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short JFPHJKLMPPD;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E96B60", Offset = "0x4E95360", VA = "0x184E96B60")]
	public CGKCEIKHJNN(ulong MJNGKJIPPJH, short FCNICHAPEID, short JFPHJKLMPPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class LGHNIOPICNF
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly CGKCEIKHJNN[] MJNHFCIOODO;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5255710", Offset = "0x5253F10", VA = "0x185255710")]
	public static void EOGNFNPHEEL(int EFNOJINIMIC, int EDKLPDAIDNA, out PLIHFMPLOPB FEAJGKJPCLH, out int JFPHJKLMPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5255850", Offset = "0x5254050", VA = "0x185255850")]
	public static void MEHKNECMGHB(int CKAIGELMNLO, out PLIHFMPLOPB FEAJGKJPCLH, out int KNGLBCAJGCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct ENGNIMIGMHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] EBBNNMNMLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int DAOIPFCHFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int JOPMJDCMFHD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F600", Offset = "0x4E9DE00", VA = "0x184E9F600")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xC21E90", Offset = "0xC20690", VA = "0x180C21E90")]
	public ENGNIMIGMHE(byte[] EBBNNMNMLOE, int DAOIPFCHFFJ, int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF360", Offset = "0x7EDB60", VA = "0x1807EF360")]
	public int EEOHOPIJABN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F5A0", Offset = "0x4E9DDA0", VA = "0x184E9F5A0")]
	public ENGNIMIGMHE NEBMKEBBODK(int AOKNACFHLEG, int LNDILOLNLJO)
	{
		return default(ENGNIMIGMHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class BEBOAJPHIAB
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] PELGMCEHOFD;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] INMDIILBPDL;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int PKPFPFJGCCK;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E91B90", Offset = "0x4E90390", VA = "0x184E91B90")]
	private static byte[] OJOGAMJFNFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E90300", Offset = "0x4E8EB00", VA = "0x184E90300")]
	private static ENGNIMIGMHE BLAPNMAHDLB(ENGNIMIGMHE DNLJJNDPNCG)
	{
		return default(ENGNIMIGMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E91150", Offset = "0x4E8F950", VA = "0x184E91150")]
	private static ENGNIMIGMHE HOLNFEPILAO(ENGNIMIGMHE DNLJJNDPNCG)
	{
		return default(ENGNIMIGMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E90C20", Offset = "0x4E8F420", VA = "0x184E90C20")]
	private static void FCGKFOMGLEI(ENGNIMIGMHE DNLJJNDPNCG, int IPPODBAKJAG, byte[] OLGNOPMAKAO, out int JMFDLONDPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E90470", Offset = "0x4E8EC70", VA = "0x184E90470")]
	private static void CFLIGJLBCNO(ENGNIMIGMHE DNLJJNDPNCG, int IPPODBAKJAG, byte[] CIGDEKPMHAB, int HDAKDEPLMJO, out ENGNIMIGMHE JCHLCBLBABA, out int MBNDDNLKOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E903E0", Offset = "0x4E8EBE0", VA = "0x184E903E0")]
	private static ulong BLKMDOLBEEC(ENGNIMIGMHE DNLJJNDPNCG, out int HFOJNIHBKHF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E91490", Offset = "0x4E8FC90", VA = "0x184E91490")]
	private static void LEEHAMGLJHI(ENGNIMIGMHE DNLJJNDPNCG, out PLIHFMPLOPB KGFIMLECODA, out int ANHAMFEEPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E90CD0", Offset = "0x4E8F4D0", VA = "0x184E90CD0")]
	private static bool GLAPJPJEFOF(ENGNIMIGMHE JCHLCBLBABA, int IPPODBAKJAG, out double KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4E90A70", Offset = "0x4E8F270", VA = "0x184E90A70")]
	private static PLIHFMPLOPB DBNAEGEFBLK(int IPPODBAKJAG)
	{
		return default(PLIHFMPLOPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4E91620", Offset = "0x4E8FE20", VA = "0x184E91620")]
	private static bool LEJILHKDLHN(ENGNIMIGMHE DNLJJNDPNCG, int IPPODBAKJAG, out double KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4E91350", Offset = "0x4E8FB50", VA = "0x184E91350")]
	private static bool IKCCCNAKEJL(ENGNIMIGMHE JCHLCBLBABA, int IPPODBAKJAG, out double LFCCBFLHNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4E91230", Offset = "0x4E8FA30", VA = "0x184E91230")]
	public static double? HPNPPIAIEBE(ENGNIMIGMHE DNLJJNDPNCG, int IPPODBAKJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4E90790", Offset = "0x4E8EF90", VA = "0x184E90790")]
	public static float? CNDGINCGDBE(ENGNIMIGMHE DNLJJNDPNCG, int IPPODBAKJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct NEBLJIIAOKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] DNLJJNDPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int OBHIANFIDPA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x55093F0", Offset = "0x5507BF0", VA = "0x1855093F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ED0", Offset = "0x7F46D0", VA = "0x1807F5ED0")]
	public NEBLJIIAOKB(byte[] DNLJJNDPNCG, int OBHIANFIDPA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x55093E0", Offset = "0x5507BE0", VA = "0x1855093E0")]
	public static NEBLJIIAOKB CGALDJMDPFH(NEBLJIIAOKB DCJNPPINKOA)
	{
		return default(NEBLJIIAOKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5509430", Offset = "0x5507C30", VA = "0x185509430")]
	public static NEBLJIIAOKB EEMNIOEABIB(NEBLJIIAOKB DCJNPPINKOA, int EEOHOPIJABN)
	{
		return default(NEBLJIIAOKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5509480", Offset = "0x5507C80", VA = "0x185509480")]
	public static int GIAMMBAMJJM(NEBLJIIAOKB EHDPPFDCEJK, NEBLJIIAOKB NPIMFLIIAHF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x55094F0", Offset = "0x5507CF0", VA = "0x1855094F0")]
	public static bool GLPMECKCBFF(NEBLJIIAOKB EHDPPFDCEJK, NEBLJIIAOKB NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x55096A0", Offset = "0x5507EA0", VA = "0x1855096A0")]
	public static bool PKJGEKBKGNO(NEBLJIIAOKB EHDPPFDCEJK, NEBLJIIAOKB NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x55094A0", Offset = "0x5507CA0", VA = "0x1855094A0")]
	public static bool GLPMECKCBFF(NEBLJIIAOKB EHDPPFDCEJK, char NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5509650", Offset = "0x5507E50", VA = "0x185509650")]
	public static bool PKJGEKBKGNO(NEBLJIIAOKB EHDPPFDCEJK, char NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5509650", Offset = "0x5507E50", VA = "0x185509650")]
	public static bool PKJGEKBKGNO(NEBLJIIAOKB EHDPPFDCEJK, byte NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x55095B0", Offset = "0x5507DB0", VA = "0x1855095B0")]
	public static bool MPGGOFANBML(NEBLJIIAOKB EHDPPFDCEJK, char NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5509560", Offset = "0x5507D60", VA = "0x185509560")]
	public static bool MFMDMJECLCO(NEBLJIIAOKB EHDPPFDCEJK, char NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5509510", Offset = "0x5507D10", VA = "0x185509510")]
	public static bool JHPEJPKJHAP(NEBLJIIAOKB EHDPPFDCEJK, char NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5509600", Offset = "0x5507E00", VA = "0x185509600")]
	public static bool NGNEEDBNCGO(NEBLJIIAOKB EHDPPFDCEJK, char NPIMFLIIAHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class HDNCGJEAKPF
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] FEAADKIOOFD;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] LIMEBOFIHAK;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] MKHBNKPOAHE;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] HAHPBEFDJHA;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] DNDPECBJLCF;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int LJPADPMONGN;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] GDFDHKJKCMP;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int LHOPFBEBAHM;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5240A70", Offset = "0x523F270", VA = "0x185240A70")]
	private static byte[] FHIPLPJHAPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5240980", Offset = "0x523F180", VA = "0x185240980")]
	private static byte[] COJPDNALOJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5240C70", Offset = "0x523F470", VA = "0x185240C70")]
	public static double HGEHLGMGIIL(byte[] DNLJJNDPNCG, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5241E80", Offset = "0x5240680", VA = "0x185241E80")]
	public static float KLHKHLCHFNB(byte[] DNLJJNDPNCG, int OBHIANFIDPA, out int IEGLJGNHFCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5240800", Offset = "0x523F000", VA = "0x185240800")]
	private static bool CJHBCKFEKCO(int NGMFABJMIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5240B60", Offset = "0x523F360", VA = "0x185240B60")]
	private static bool HGBGNAALBMM(ref NEBLJIIAOKB FNOCDBPJMGE, NEBLJIIAOKB FBIOFODCNKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5241F40", Offset = "0x5240740", VA = "0x185241F40")]
	private static bool MMOPGBIFCEP(ref NEBLJIIAOKB FNOCDBPJMGE, NEBLJIIAOKB FBIOFODCNKG, byte[] LJDJDAICIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5242070", Offset = "0x5240870", VA = "0x185242070")]
	private static bool NMLLKEOKIKM(ref NEBLJIIAOKB IKAMEEGCOHF, byte[] AOEMKAJNLKN, int OBHIANFIDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5242050", Offset = "0x5240850", VA = "0x185242050")]
	private static double NHMMMHDKNIP(bool DDKFKHILFLH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5240D20", Offset = "0x523F520", VA = "0x185240D20")]
	private static double KIKMKFNKDEA(NEBLJIIAOKB JHPDOGGEPPC, int EEOHOPIJABN, bool AEJCLHEIJFK, out int KOCEDFJBJIF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class EBBMCABKOPF<T> : global::JECENNBIMEI<T[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::LDGNEIEFCJO<T> NKOIEPCELPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly MJOIPDAKNEA AAJDPKEODOO;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2620E90", Offset = "0x261F690", VA = "0x182620E90")]
	public EBBMCABKOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1492A40", Offset = "0x1491240", VA = "0x181492A40")]
	public EBBMCABKOPF(MJOIPDAKNEA AAJDPKEODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2620520", Offset = "0x261ED20", VA = "0x182620520", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x261EE60", Offset = "0x261D660", VA = "0x18261EE60", Slot = "5")]
	public T[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PGFJAIKAKMJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::LDGNEIEFCJO<T> NKOIEPCELPJ;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class FJECELMEFPL<T> : global::JECENNBIMEI<List<T>>, EBBBNEHKICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly MJOIPDAKNEA AAJDPKEODOO;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2620E90", Offset = "0x261F690", VA = "0x182620E90")]
	public FJECELMEFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1492A40", Offset = "0x1491240", VA = "0x181492A40")]
	public FJECELMEFPL(MJOIPDAKNEA AAJDPKEODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C550", Offset = "0x2C7AD50", VA = "0x182C7C550", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, List<T> NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B7B0", Offset = "0x2C79FB0", VA = "0x182C7B7B0", Slot = "5")]
	public List<T> JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class APKDNAJEFKI<TElement, TIntermediate, TEnumerator, TCollection> : global::JECENNBIMEI<TCollection>, EBBBNEHKICB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2EA60F0", Offset = "0x2EA48F0", VA = "0x182EA60F0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, TCollection NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5D00", Offset = "0x2EA4500", VA = "0x182EA5D00", Slot = "5")]
	public TCollection JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EEDBDLOGJOG(TCollection KJFIHMLIKBG);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OJONNLHFKNA();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void LGCDELLOPGJ(ref TIntermediate MJNFLJIGHLN, int LHHBOCAHDEE, TElement NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection MNPDJHGOCNG(ref TIntermediate IFBPHMPPEEE);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	protected APKDNAJEFKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class OBCCDJLJCAD<TElement, TIntermediate, TCollection> : global::APKDNAJEFKI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x36A6A10", Offset = "0x36A5210", VA = "0x1836A6A10", Slot = "6")]
	protected override IEnumerator<TElement> EEDBDLOGJOG(TCollection KJFIHMLIKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x25B5720", Offset = "0x25B3F20", VA = "0x1825B5720")]
	protected OBCCDJLJCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class CENBAJBOAJP<TElement, TCollection> : global::OBCCDJLJCAD<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected sealed override TCollection MNPDJHGOCNG(ref TCollection IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class NFGIMGHDKLH<TElement, TCollection> : global::CENBAJBOAJP<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x34B7AE0", Offset = "0x34B62E0", VA = "0x1834B7AE0", Slot = "7")]
	protected override TCollection OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x34B7A70", Offset = "0x34B6270", VA = "0x1834B7A70", Slot = "8")]
	protected override void LGCDELLOPGJ(ref TCollection MJNFLJIGHLN, int LHHBOCAHDEE, TElement NPHADDCNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IGBIINLNEKN<T> : global::APKDNAJEFKI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1811770", Offset = "0x180FF70", VA = "0x181811770", Slot = "8")]
	protected override void LGCDELLOPGJ(ref LinkedList<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override LinkedList<T> MNPDJHGOCNG(ref LinkedList<T> IFBPHMPPEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override LinkedList<T> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x1811710", Offset = "0x180FF10", VA = "0x181811710", Slot = "6")]
	protected override LinkedList<T>.Enumerator EEDBDLOGJOG(LinkedList<T> KJFIHMLIKBG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class LPPFFOEKBAE<T> : global::APKDNAJEFKI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1811770", Offset = "0x180FF70", VA = "0x181811770", Slot = "8")]
	protected override void LGCDELLOPGJ(ref Queue<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override Queue<T> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2C80080", Offset = "0x2C7E880", VA = "0x182C80080", Slot = "6")]
	protected override Queue<T>.Enumerator EEDBDLOGJOG(Queue<T> KJFIHMLIKBG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override Queue<T> MNPDJHGOCNG(ref Queue<T> IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class BEAOKGBNNIA<T> : global::APKDNAJEFKI<T, global::MDFLHGAOMAC<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2E307A0", Offset = "0x2E2EFA0", VA = "0x182E307A0", Slot = "8")]
	protected override void LGCDELLOPGJ(ref global::MDFLHGAOMAC<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x364C8B0", Offset = "0x364B0B0", VA = "0x18364C8B0", Slot = "7")]
	protected override global::MDFLHGAOMAC<T> OJONNLHFKNA()
	{
		return default(global::MDFLHGAOMAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2C80080", Offset = "0x2C7E880", VA = "0x182C80080", Slot = "6")]
	protected override Stack<T>.Enumerator EEDBDLOGJOG(Stack<T> KJFIHMLIKBG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C6D0", Offset = "0x3D1AED0", VA = "0x183D1C6D0", Slot = "9")]
	protected override Stack<T> MNPDJHGOCNG(ref global::MDFLHGAOMAC<T> IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class FLACBGLKDCH<T> : global::APKDNAJEFKI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1811770", Offset = "0x180FF70", VA = "0x181811770", Slot = "8")]
	protected override void LGCDELLOPGJ(ref HashSet<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override HashSet<T> MNPDJHGOCNG(ref HashSet<T> IFBPHMPPEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override HashSet<T> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2C80080", Offset = "0x2C7E880", VA = "0x182C80080", Slot = "6")]
	protected override HashSet<T>.Enumerator EEDBDLOGJOG(HashSet<T> KJFIHMLIKBG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NAAHEHKONPK<T> : global::OBCCDJLJCAD<T, global::MDFLHGAOMAC<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2E307A0", Offset = "0x2E2EFA0", VA = "0x182E307A0", Slot = "8")]
	protected override void LGCDELLOPGJ(ref global::MDFLHGAOMAC<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2E307D0", Offset = "0x2E2EFD0", VA = "0x182E307D0", Slot = "9")]
	protected override ReadOnlyCollection<T> MNPDJHGOCNG(ref global::MDFLHGAOMAC<T> IFBPHMPPEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2E30860", Offset = "0x2E2F060", VA = "0x182E30860", Slot = "7")]
	protected override global::MDFLHGAOMAC<T> OJONNLHFKNA()
	{
		return default(global::MDFLHGAOMAC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class EKDILFFELFP<T> : global::OBCCDJLJCAD<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1811770", Offset = "0x180FF70", VA = "0x181811770", Slot = "8")]
	protected override void LGCDELLOPGJ(ref List<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override List<T> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override IList<T> MNPDJHGOCNG(ref List<T> IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class ONBMAEJMGDN<T> : global::OBCCDJLJCAD<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1811770", Offset = "0x180FF70", VA = "0x181811770", Slot = "8")]
	protected override void LGCDELLOPGJ(ref List<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override List<T> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override ICollection<T> MNPDJHGOCNG(ref List<T> IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class PLNBMOEIDNA<T> : global::OBCCDJLJCAD<T, global::MDFLHGAOMAC<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2E307A0", Offset = "0x2E2EFA0", VA = "0x182E307A0", Slot = "8")]
	protected override void LGCDELLOPGJ(ref global::MDFLHGAOMAC<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x364C8B0", Offset = "0x364B0B0", VA = "0x18364C8B0", Slot = "7")]
	protected override global::MDFLHGAOMAC<T> OJONNLHFKNA()
	{
		return default(global::MDFLHGAOMAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3713F00", Offset = "0x3712700", VA = "0x183713F00", Slot = "9")]
	protected override IEnumerable<T> MNPDJHGOCNG(ref global::MDFLHGAOMAC<T> IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class LDHPADGHLEH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class CGKLNOLIIEF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class MHDGNPKOKFC<T> : global::JECENNBIMEI<T>, EBBBNEHKICB where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1F50", Offset = "0x2DB0750", VA = "0x182DB1F50", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1D40", Offset = "0x2DB0540", VA = "0x182DB1D40", Slot = "5")]
	public T JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	public MHDGNPKOKFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class OHBFHLNDHOM : global::JECENNBIMEI<IEnumerable>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::JECENNBIMEI<IEnumerable> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x550BD50", Offset = "0x550A550", VA = "0x18550BD50", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, IEnumerable NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x550BBA0", Offset = "0x550A3A0", VA = "0x18550BBA0", Slot = "5")]
	public IEnumerable JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public OHBFHLNDHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class JBDDMBNPAPL : global::JECENNBIMEI<ICollection>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::JECENNBIMEI<ICollection> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x524D060", Offset = "0x524B860", VA = "0x18524D060", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ICollection NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x524CEB0", Offset = "0x524B6B0", VA = "0x18524CEB0", Slot = "5")]
	public ICollection JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JBDDMBNPAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class CJGCDMHKKHF : global::JECENNBIMEI<IList>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::JECENNBIMEI<IList> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4E96EE0", Offset = "0x4E956E0", VA = "0x184E96EE0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, IList NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x4E96C50", Offset = "0x4E95450", VA = "0x184E96C50", Slot = "5")]
	public IList JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CJGCDMHKKHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class HAIHHEFNHFL<T> : global::OBCCDJLJCAD<T, global::MDFLHGAOMAC<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x364C840", Offset = "0x364B040", VA = "0x18364C840", Slot = "8")]
	protected override void LGCDELLOPGJ(ref global::MDFLHGAOMAC<T> MJNFLJIGHLN, int LHHBOCAHDEE, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x364C8B0", Offset = "0x364B0B0", VA = "0x18364C8B0", Slot = "7")]
	protected override global::MDFLHGAOMAC<T> OJONNLHFKNA()
	{
		return default(global::MDFLHGAOMAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x364C870", Offset = "0x364B070", VA = "0x18364C870", Slot = "9")]
	protected override IReadOnlyList<T> MNPDJHGOCNG(ref global::MDFLHGAOMAC<T> IFBPHMPPEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x259DE50", Offset = "0x259C650", VA = "0x18259DE50")]
	public HAIHHEFNHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class BMLAPGJPJGO
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4E932F0", Offset = "0x4E91AF0", VA = "0x184E932F0")]
	public static DateTime HGNBBIADNGE(DateTime LKANPODHPAF)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class GCILNFMOGGB : global::JECENNBIMEI<DateTime>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::JECENNBIMEI<DateTime> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4C30", Offset = "0x4EA3430", VA = "0x184EA4C30", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, DateTime NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3C40", Offset = "0x4EA2440", VA = "0x184EA3C40", Slot = "5")]
	public DateTime JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GCILNFMOGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class DFFDDEKMIAA : global::JECENNBIMEI<DateTimeOffset>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::JECENNBIMEI<DateTimeOffset> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A210", Offset = "0x4E98A10", VA = "0x184E9A210", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, DateTimeOffset NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4E992D0", Offset = "0x4E97AD0", VA = "0x184E992D0", Slot = "5")]
	public DateTimeOffset JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DFFDDEKMIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class AEEALCMCIDH : global::JECENNBIMEI<TimeSpan>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::JECENNBIMEI<TimeSpan> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] DFNGDFIPFCL;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F2E0", Offset = "0x4E8DAE0", VA = "0x184E8F2E0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, TimeSpan NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E850", Offset = "0x4E8D050", VA = "0x184E8E850", Slot = "5")]
	public TimeSpan JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public AEEALCMCIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class NKIEMBMMLOD<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::JECENNBIMEI<TDictionary>, EBBBNEHKICB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF680", Offset = "0x2AEDE80", VA = "0x182AEF680", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, TDictionary NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE860", Offset = "0x2AED060", VA = "0x182AEE860", Slot = "5")]
	public TDictionary JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EEDBDLOGJOG(TDictionary KJFIHMLIKBG);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OJONNLHFKNA();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void LGCDELLOPGJ(ref TIntermediate MJNFLJIGHLN, int LHHBOCAHDEE, TKey NHBANLNJEIH, TValue NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary MNPDJHGOCNG(ref TIntermediate IFBPHMPPEEE);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	protected NKIEMBMMLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class BBIKEPEAJFP<TKey, TValue, TIntermediate, TDictionary> : global::NKIEMBMMLOD<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3D851C0", Offset = "0x3D839C0", VA = "0x183D851C0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EEDBDLOGJOG(TDictionary KJFIHMLIKBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class HCLMIOKPKKF<TKey, TValue, TDictionary> : global::BBIKEPEAJFP<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override TDictionary MNPDJHGOCNG(ref TDictionary IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class MPDCFBDLJPB<TKey, TValue> : global::NKIEMBMMLOD<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x28E3150", Offset = "0x28E1950", VA = "0x1828E3150", Slot = "8")]
	protected override void LGCDELLOPGJ(ref Dictionary<TKey, TValue> MJNFLJIGHLN, int LHHBOCAHDEE, TKey NHBANLNJEIH, TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override Dictionary<TKey, TValue> MNPDJHGOCNG(ref Dictionary<TKey, TValue> IFBPHMPPEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override Dictionary<TKey, TValue> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x28E3100", Offset = "0x28E1900", VA = "0x1828E3100", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EEDBDLOGJOG(Dictionary<TKey, TValue> KJFIHMLIKBG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x106C130", Offset = "0x106A930", VA = "0x18106C130")]
	public MPDCFBDLJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class CEGAGFENFEF<TKey, TValue, TDictionary> : global::HCLMIOKPKKF<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x28C9C60", Offset = "0x28C8460", VA = "0x1828C9C60", Slot = "8")]
	protected override void LGCDELLOPGJ(ref TDictionary MJNFLJIGHLN, int LHHBOCAHDEE, TKey NHBANLNJEIH, TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1ED79C0", Offset = "0x1ED61C0", VA = "0x181ED79C0", Slot = "7")]
	protected override TDictionary OJONNLHFKNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class PIKJDAGFFIB<TKey, TValue> : global::BBIKEPEAJFP<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x28E3190", Offset = "0x28E1990", VA = "0x1828E3190", Slot = "8")]
	protected override void LGCDELLOPGJ(ref Dictionary<TKey, TValue> MJNFLJIGHLN, int LHHBOCAHDEE, TKey NHBANLNJEIH, TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override Dictionary<TKey, TValue> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override IDictionary<TKey, TValue> MNPDJHGOCNG(ref Dictionary<TKey, TValue> IFBPHMPPEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class MLHHEHEGLFG<TKey, TValue> : global::HCLMIOKPKKF<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x28E3190", Offset = "0x28E1990", VA = "0x1828E3190", Slot = "8")]
	protected override void LGCDELLOPGJ(ref SortedList<TKey, TValue> MJNFLJIGHLN, int LHHBOCAHDEE, TKey NHBANLNJEIH, TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override SortedList<TKey, TValue> OJONNLHFKNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class OAILMFJPFMM<TKey, TValue> : global::NKIEMBMMLOD<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x28E3190", Offset = "0x28E1990", VA = "0x1828E3190", Slot = "8")]
	protected override void LGCDELLOPGJ(ref SortedDictionary<TKey, TValue> MJNFLJIGHLN, int LHHBOCAHDEE, TKey NHBANLNJEIH, TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xF58CD0", Offset = "0xF574D0", VA = "0x180F58CD0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> MNPDJHGOCNG(ref SortedDictionary<TKey, TValue> IFBPHMPPEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x18117B0", Offset = "0x180FFB0", VA = "0x1818117B0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> OJONNLHFKNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x36A69B0", Offset = "0x36A51B0", VA = "0x1836A69B0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EEDBDLOGJOG(SortedDictionary<TKey, TValue> KJFIHMLIKBG)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class COCNBOMIJBN<T> : global::JECENNBIMEI<T>, EBBBNEHKICB where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x30D32E0", Offset = "0x30D1AE0", VA = "0x1830D32E0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x30D30B0", Offset = "0x30D18B0", VA = "0x1830D30B0", Slot = "5")]
	public T JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	public COCNBOMIJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class LFPDINECGBF : global::JECENNBIMEI<IDictionary>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::JECENNBIMEI<IDictionary> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5255200", Offset = "0x5253A00", VA = "0x185255200", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, IDictionary NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5255030", Offset = "0x5253830", VA = "0x185255030", Slot = "5")]
	public IDictionary JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LFPDINECGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class CACOIAOAFFC : global::JECENNBIMEI<object>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void JJPCDFOKMBB(object CAMCIENNNLP, ref LMANJAHJEKC IJMHHNEJPMM, object NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::HFNFGBMJBLO<KeyValuePair<object, JJPCDFOKMBB>> PEBIPAKLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly KFGIIMCBFCL[] OHHDJJADBCC;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x4E94070", Offset = "0x4E92870", VA = "0x184E94070")]
	public CACOIAOAFFC(params KFGIIMCBFCL[] OHHDJJADBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4E93490", Offset = "0x4E91C90", VA = "0x184E93490", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, object NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x4E933F0", Offset = "0x4E91BF0", VA = "0x184E933F0", Slot = "5")]
	public object JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class CKOPAFFNHNA
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4E97B20", Offset = "0x4E96320", VA = "0x184E97B20")]
	public static object FONBEDKCODE(Type EHPFPOFFCEJ, out bool IPLGCLJCJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x4E97200", Offset = "0x4E95A00", VA = "0x184E97200")]
	public static object EDFLLDKNAPO(Type EHPFPOFFCEJ, out bool IPLGCLJCJIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class FMIHCGAPIOJ<T> : global::JECENNBIMEI<T>, EBBBNEHKICB, global::MFAJIMKKIPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class PEOALPDDJKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public PEOALPDDJKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AB60", Offset = "0x2F09360", VA = "0x182F0AB60")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class GCLBFLFFFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::EEINAPODPCL<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public GCLBFLFFFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3790BD0", Offset = "0x378F3D0", VA = "0x183790BD0")]
		internal void <.cctor>b__1(ref LMANJAHJEKC writer, T value, KFGIIMCBFCL _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class OPFMOMFKDAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::ONMKGINJIFM<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public OPFMOMFKDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3576AC0", Offset = "0x35752C0", VA = "0x183576AC0")]
		internal T <.cctor>b__2(ref EILLEGCDDNJ reader, KFGIIMCBFCL _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::HMBDJJGPCIK<T> NGDFAEDIJLC;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> OLNECIMBENK;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::EEINAPODPCL<T> KKCGBDAKPHI;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::ONMKGINJIFM<T> LJMEDLHDFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool BAIAFPPEACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::EEINAPODPCL<T> OGJNPLGLLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::ONMKGINJIFM<T> ELCKPNOCCJK;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F0E0", Offset = "0x2C8D8E0", VA = "0x182C8F0E0")]
	static FMIHCGAPIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C90030", Offset = "0x2C8E830", VA = "0x182C90030")]
	public FMIHCGAPIOJ(bool BAIAFPPEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C8B120", Offset = "0x2C89920", VA = "0x182C8B120", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C8A480", Offset = "0x2C88C80", VA = "0x182C8A480", Slot = "5")]
	public T JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C899C0", Offset = "0x2C881C0", VA = "0x182C899C0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, T NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C89360", Offset = "0x2C87B60", VA = "0x182C89360", Slot = "7")]
	public T BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class PPIFCAEFHPC<T> : global::JECENNBIMEI<T[,]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x310C2B0", Offset = "0x310AAB0", VA = "0x18310C2B0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T[,] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x310BFE0", Offset = "0x310A7E0", VA = "0x18310BFE0", Slot = "5")]
	public T[,] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	public PPIFCAEFHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class KHCNCEMMBAI<T> : global::JECENNBIMEI<T[,,]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x26043B0", Offset = "0x2602BB0", VA = "0x1826043B0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T[,,] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2603FD0", Offset = "0x26027D0", VA = "0x182603FD0", Slot = "5")]
	public T[,,] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	public KHCNCEMMBAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class MKHFIAHMGFA<T> : global::JECENNBIMEI<T[,,,]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4590", Offset = "0x2FB2D90", VA = "0x182FB4590", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T[,,,] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4090", Offset = "0x2FB2890", VA = "0x182FB4090", Slot = "5")]
	public T[,,,] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	public MKHFIAHMGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class HALKIPJDKDN<T> : global::JECENNBIMEI<T?>, EBBBNEHKICB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x364CBC0", Offset = "0x364B3C0", VA = "0x18364CBC0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x364CA70", Offset = "0x364B270", VA = "0x18364CA70", Slot = "5")]
	public T? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	public HALKIPJDKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class LDKCLANDPDB<T> : global::JECENNBIMEI<T?>, EBBBNEHKICB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::JECENNBIMEI<T> PAGKDBDMCOJ;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
	public LDKCLANDPDB(global::JECENNBIMEI<T> PAGKDBDMCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x469ACE0", Offset = "0x46994E0", VA = "0x18469ACE0")]
	public LDKCLANDPDB(Type FKGGEGPGJDL, object[] HMCFBPMKALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x46993B0", Offset = "0x4697BB0", VA = "0x1846993B0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, T? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x4698C50", Offset = "0x4697450", VA = "0x184698C50", Slot = "5")]
	public T? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class JCCCPDKJAAG : global::JECENNBIMEI<sbyte>, EBBBNEHKICB, global::MFAJIMKKIPB<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly JCCCPDKJAAG KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x524D5C0", Offset = "0x524BDC0", VA = "0x18524D5C0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, sbyte NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x524D5B0", Offset = "0x524BDB0", VA = "0x18524D5B0", Slot = "5")]
	public sbyte JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x524D4F0", Offset = "0x524BCF0", VA = "0x18524D4F0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, sbyte NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x524D440", Offset = "0x524BC40", VA = "0x18524D440", Slot = "7")]
	public sbyte BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JCCCPDKJAAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LDFOPBOEBGA : global::JECENNBIMEI<sbyte?>, EBBBNEHKICB, global::MFAJIMKKIPB<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LDFOPBOEBGA KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5254AD0", Offset = "0x52532D0", VA = "0x185254AD0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, sbyte? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5254A60", Offset = "0x5253260", VA = "0x185254A60", Slot = "5")]
	public sbyte? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5254950", Offset = "0x5253150", VA = "0x185254950", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, sbyte? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5254850", Offset = "0x5253050", VA = "0x185254850", Slot = "7")]
	public sbyte? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LDFOPBOEBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PDJAAGAJIBI : global::JECENNBIMEI<sbyte[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly PDJAAGAJIBI KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x550C300", Offset = "0x550AB00", VA = "0x18550C300", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, sbyte[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x550C1C0", Offset = "0x550A9C0", VA = "0x18550C1C0", Slot = "5")]
	public sbyte[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJAAGAJIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class KHAHDBOMNNA : global::JECENNBIMEI<short>, EBBBNEHKICB, global::MFAJIMKKIPB<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly KHAHDBOMNNA KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5252160", Offset = "0x5250960", VA = "0x185252160", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, short NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5252150", Offset = "0x5250950", VA = "0x185252150", Slot = "5")]
	public short JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5252090", Offset = "0x5250890", VA = "0x185252090", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, short NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5251FE0", Offset = "0x52507E0", VA = "0x185251FE0", Slot = "7")]
	public short BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KHAHDBOMNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class DFGEFHCKGLM : global::JECENNBIMEI<short?>, EBBBNEHKICB, global::MFAJIMKKIPB<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly DFGEFHCKGLM KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A840", Offset = "0x4E99040", VA = "0x184E9A840", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, short? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A790", Offset = "0x4E98F90", VA = "0x184E9A790", Slot = "5")]
	public short? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A710", Offset = "0x4E98F10", VA = "0x184E9A710", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, short? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A650", Offset = "0x4E98E50", VA = "0x184E9A650", Slot = "7")]
	public short? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DFGEFHCKGLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HEIEGOFGPMH : global::JECENNBIMEI<short[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly HEIEGOFGPMH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5242470", Offset = "0x5240C70", VA = "0x185242470", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, short[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5242330", Offset = "0x5240B30", VA = "0x185242330", Slot = "5")]
	public short[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HEIEGOFGPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class HAECONGPCAC : global::JECENNBIMEI<int>, EBBBNEHKICB, global::MFAJIMKKIPB<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly HAECONGPCAC KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5240250", Offset = "0x523EA50", VA = "0x185240250", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, int NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5240240", Offset = "0x523EA40", VA = "0x185240240", Slot = "5")]
	public int JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5240180", Offset = "0x523E980", VA = "0x185240180", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, int NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x52400D0", Offset = "0x523E8D0", VA = "0x1852400D0", Slot = "7")]
	public int BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HAECONGPCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GECMMHKECHA : global::JECENNBIMEI<int?>, EBBBNEHKICB, global::MFAJIMKKIPB<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly GECMMHKECHA KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5890", Offset = "0x4EA4090", VA = "0x184EA5890", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, int? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA57E0", Offset = "0x4EA3FE0", VA = "0x184EA57E0", Slot = "5")]
	public int? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5760", Offset = "0x4EA3F60", VA = "0x184EA5760", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, int? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4EA56A0", Offset = "0x4EA3EA0", VA = "0x184EA56A0", Slot = "7")]
	public int? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GECMMHKECHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class GCNOELGJBBB : global::JECENNBIMEI<int[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly GCNOELGJBBB KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5320", Offset = "0x4EA3B20", VA = "0x184EA5320", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, int[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4EA50F0", Offset = "0x4EA38F0", VA = "0x184EA50F0", Slot = "5")]
	public int[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GCNOELGJBBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CLCPJONADEE : global::JECENNBIMEI<long>, EBBBNEHKICB, global::MFAJIMKKIPB<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly CLCPJONADEE KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E98510", Offset = "0x4E96D10", VA = "0x184E98510", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, long NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E98500", Offset = "0x4E96D00", VA = "0x184E98500", Slot = "5")]
	public long JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E984C0", Offset = "0x4E96CC0", VA = "0x184E984C0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, long NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E98440", Offset = "0x4E96C40", VA = "0x184E98440", Slot = "7")]
	public long BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CLCPJONADEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class FFLEJLFGBDH : global::JECENNBIMEI<long?>, EBBBNEHKICB, global::MFAJIMKKIPB<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly FFLEJLFGBDH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1120", Offset = "0x4E9F920", VA = "0x184EA1120", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, long? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1090", Offset = "0x4E9F890", VA = "0x184EA1090", Slot = "5")]
	public long? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1000", Offset = "0x4E9F800", VA = "0x184EA1000", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, long? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0F20", Offset = "0x4E9F720", VA = "0x184EA0F20", Slot = "7")]
	public long? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FFLEJLFGBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class IJKOIIFCLHA : global::JECENNBIMEI<long[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IJKOIIFCLHA KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5243EE0", Offset = "0x52426E0", VA = "0x185243EE0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, long[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5243DA0", Offset = "0x52425A0", VA = "0x185243DA0", Slot = "5")]
	public long[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IJKOIIFCLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class DEOJCCLEENN : global::JECENNBIMEI<byte>, EBBBNEHKICB, global::MFAJIMKKIPB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly DEOJCCLEENN KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4E99250", Offset = "0x4E97A50", VA = "0x184E99250", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, byte NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4E991F0", Offset = "0x4E979F0", VA = "0x184E991F0", Slot = "5")]
	public byte JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x4E991B0", Offset = "0x4E979B0", VA = "0x184E991B0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, byte NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4E99130", Offset = "0x4E97930", VA = "0x184E99130", Slot = "7")]
	public byte BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DEOJCCLEENN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class APEBCFBLHLN : global::JECENNBIMEI<byte?>, EBBBNEHKICB, global::MFAJIMKKIPB<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly APEBCFBLHLN KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FB20", Offset = "0x4E8E320", VA = "0x184E8FB20", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, byte? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FA70", Offset = "0x4E8E270", VA = "0x184E8FA70", Slot = "5")]
	public byte? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F9F0", Offset = "0x4E8E1F0", VA = "0x184E8F9F0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, byte? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F930", Offset = "0x4E8E130", VA = "0x184E8F930", Slot = "7")]
	public byte? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public APEBCFBLHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class JMMAPMDPLFL : global::JECENNBIMEI<ushort>, EBBBNEHKICB, global::MFAJIMKKIPB<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly JMMAPMDPLFL KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x524DE00", Offset = "0x524C600", VA = "0x18524DE00", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ushort NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x524DDF0", Offset = "0x524C5F0", VA = "0x18524DDF0", Slot = "5")]
	public ushort JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x524DD30", Offset = "0x524C530", VA = "0x18524DD30", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, ushort NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x524DC80", Offset = "0x524C480", VA = "0x18524DC80", Slot = "7")]
	public ushort BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JMMAPMDPLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class NCCBHKCFFBO : global::JECENNBIMEI<ushort?>, EBBBNEHKICB, global::MFAJIMKKIPB<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly NCCBHKCFFBO KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5509000", Offset = "0x5507800", VA = "0x185509000", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ushort? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5508F90", Offset = "0x5507790", VA = "0x185508F90", Slot = "5")]
	public ushort? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5508F10", Offset = "0x5507710", VA = "0x185508F10", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, ushort? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5508E50", Offset = "0x5507650", VA = "0x185508E50", Slot = "7")]
	public ushort? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NCCBHKCFFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class KCOLMIIAOBA : global::JECENNBIMEI<ushort[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly KCOLMIIAOBA KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x52500A0", Offset = "0x524E8A0", VA = "0x1852500A0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ushort[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x524FF60", Offset = "0x524E760", VA = "0x18524FF60", Slot = "5")]
	public ushort[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KCOLMIIAOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class NLOEGBAFMDH : global::JECENNBIMEI<uint>, EBBBNEHKICB, global::MFAJIMKKIPB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly NLOEGBAFMDH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x550B430", Offset = "0x5509C30", VA = "0x18550B430", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, uint NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x550B420", Offset = "0x5509C20", VA = "0x18550B420", Slot = "5")]
	public uint JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x550B3E0", Offset = "0x5509BE0", VA = "0x18550B3E0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, uint NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x550B360", Offset = "0x5509B60", VA = "0x18550B360", Slot = "7")]
	public uint BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NLOEGBAFMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class ICAMMIMPOCJ : global::JECENNBIMEI<uint?>, EBBBNEHKICB, global::MFAJIMKKIPB<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly ICAMMIMPOCJ KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5243520", Offset = "0x5241D20", VA = "0x185243520", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, uint? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x52434B0", Offset = "0x5241CB0", VA = "0x1852434B0", Slot = "5")]
	public uint? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x52433A0", Offset = "0x5241BA0", VA = "0x1852433A0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, uint? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x52432B0", Offset = "0x5241AB0", VA = "0x1852432B0", Slot = "7")]
	public uint? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public ICAMMIMPOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class OFCJJAGIDEB : global::JECENNBIMEI<uint[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly OFCJJAGIDEB KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x550BA80", Offset = "0x550A280", VA = "0x18550BA80", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, uint[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x550B940", Offset = "0x550A140", VA = "0x18550B940", Slot = "5")]
	public uint[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public OFCJJAGIDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class BGODCFMOOHD : global::JECENNBIMEI<ulong>, EBBBNEHKICB, global::MFAJIMKKIPB<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly BGODCFMOOHD KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x4E92040", Offset = "0x4E90840", VA = "0x184E92040", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ulong NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4E92030", Offset = "0x4E90830", VA = "0x184E92030", Slot = "5")]
	public ulong JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4E91FF0", Offset = "0x4E907F0", VA = "0x184E91FF0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, ulong NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x4E91F70", Offset = "0x4E90770", VA = "0x184E91F70", Slot = "7")]
	public ulong BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BGODCFMOOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class BKMPHPLGBOL : global::JECENNBIMEI<ulong?>, EBBBNEHKICB, global::MFAJIMKKIPB<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly BKMPHPLGBOL KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4E93210", Offset = "0x4E91A10", VA = "0x184E93210", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ulong? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4E93180", Offset = "0x4E91980", VA = "0x184E93180", Slot = "5")]
	public ulong? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x4E930F0", Offset = "0x4E918F0", VA = "0x184E930F0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, ulong? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x4E93010", Offset = "0x4E91810", VA = "0x184E93010", Slot = "7")]
	public ulong? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BKMPHPLGBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class FICBGDPHMOK : global::JECENNBIMEI<ulong[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FICBGDPHMOK KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4EA18F0", Offset = "0x4EA00F0", VA = "0x184EA18F0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ulong[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4EA16C0", Offset = "0x4E9FEC0", VA = "0x184EA16C0", Slot = "5")]
	public ulong[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FICBGDPHMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class IKAFHGMBIAP : global::JECENNBIMEI<float>, EBBBNEHKICB, global::MFAJIMKKIPB<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly IKAFHGMBIAP KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x52442D0", Offset = "0x5242AD0", VA = "0x1852442D0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, float NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x52442C0", Offset = "0x5242AC0", VA = "0x1852442C0", Slot = "5")]
	public float JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5244210", Offset = "0x5242A10", VA = "0x185244210", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, float NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x52440E0", Offset = "0x52428E0", VA = "0x1852440E0", Slot = "7")]
	public float BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IKAFHGMBIAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class APMNNNFBELE : global::JECENNBIMEI<float?>, EBBBNEHKICB, global::MFAJIMKKIPB<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly APMNNNFBELE KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FDB0", Offset = "0x4E8E5B0", VA = "0x184E8FDB0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, float? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FD40", Offset = "0x4E8E540", VA = "0x184E8FD40", Slot = "5")]
	public float? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FCC0", Offset = "0x4E8E4C0", VA = "0x184E8FCC0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, float? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FC00", Offset = "0x4E8E400", VA = "0x184E8FC00", Slot = "7")]
	public float? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public APMNNNFBELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class JGJPOPJMDFH : global::JECENNBIMEI<float[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly JGJPOPJMDFH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x524DA20", Offset = "0x524C220", VA = "0x18524DA20", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, float[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x524D8E0", Offset = "0x524C0E0", VA = "0x18524D8E0", Slot = "5")]
	public float[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JGJPOPJMDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class DNMHNDBPJMH : global::JECENNBIMEI<double>, EBBBNEHKICB, global::MFAJIMKKIPB<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DNMHNDBPJMH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B940", Offset = "0x4E9A140", VA = "0x184E9B940", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, double NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B930", Offset = "0x4E9A130", VA = "0x184E9B930", Slot = "5")]
	public double JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B8F0", Offset = "0x4E9A0F0", VA = "0x184E9B8F0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, double NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B870", Offset = "0x4E9A070", VA = "0x184E9B870", Slot = "7")]
	public double BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DNMHNDBPJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DINJBPAEHII : global::JECENNBIMEI<double?>, EBBBNEHKICB, global::MFAJIMKKIPB<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly DINJBPAEHII KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AB20", Offset = "0x4E99320", VA = "0x184E9AB20", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, double? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AA90", Offset = "0x4E99290", VA = "0x184E9AA90", Slot = "5")]
	public double? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AA00", Offset = "0x4E99200", VA = "0x184E9AA00", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, double? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A920", Offset = "0x4E99120", VA = "0x184E9A920", Slot = "7")]
	public double? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DINJBPAEHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LDJDKKMHGBN : global::JECENNBIMEI<double[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly LDJDKKMHGBN KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5254D00", Offset = "0x5253500", VA = "0x185254D00", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, double[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5254BC0", Offset = "0x52533C0", VA = "0x185254BC0", Slot = "5")]
	public double[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LDJDKKMHGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class DJNKIIBBFPA : global::JECENNBIMEI<bool>, EBBBNEHKICB, global::MFAJIMKKIPB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly DJNKIIBBFPA KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4E9ADB0", Offset = "0x4E995B0", VA = "0x184E9ADB0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, bool NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4E9ADA0", Offset = "0x4E995A0", VA = "0x184E9ADA0", Slot = "5")]
	public bool JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AD60", Offset = "0x4E99560", VA = "0x184E9AD60", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, bool NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9ACE0", Offset = "0x4E994E0", VA = "0x184E9ACE0", Slot = "7")]
	public bool BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DJNKIIBBFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class GNFJKBIDAII : global::JECENNBIMEI<bool?>, EBBBNEHKICB, global::MFAJIMKKIPB<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly GNFJKBIDAII KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x523FFF0", Offset = "0x523E7F0", VA = "0x18523FFF0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, bool? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x523FF80", Offset = "0x523E780", VA = "0x18523FF80", Slot = "5")]
	public bool? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x523FE80", Offset = "0x523E680", VA = "0x18523FE80", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, bool? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x523FDC0", Offset = "0x523E5C0", VA = "0x18523FDC0", Slot = "7")]
	public bool? BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GNFJKBIDAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HOLJIGFCGIE : global::JECENNBIMEI<bool[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly HOLJIGFCGIE KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5242F70", Offset = "0x5241770", VA = "0x185242F70", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, bool[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5242E30", Offset = "0x5241630", VA = "0x185242E30", Slot = "5")]
	public bool[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HOLJIGFCGIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class NJBKCNNCLLE : global::JECENNBIMEI<object>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::JECENNBIMEI<object> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> LNPKCOFNLOF;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x550A4F0", Offset = "0x5508CF0", VA = "0x18550A4F0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, object NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x550A1C0", Offset = "0x55089C0", VA = "0x18550A1C0", Slot = "5")]
	public object JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NJBKCNNCLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class PFDJLINHBJA : global::JECENNBIMEI<byte[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::JECENNBIMEI<byte[]> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x550C610", Offset = "0x550AE10", VA = "0x18550C610", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, byte[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x550C590", Offset = "0x550AD90", VA = "0x18550C590", Slot = "5")]
	public byte[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PFDJLINHBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class APODDEKKKHG : global::JECENNBIMEI<ArraySegment<byte>>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::JECENNBIMEI<ArraySegment<byte>> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FF70", Offset = "0x4E8E770", VA = "0x184E8FF70", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, ArraySegment<byte> NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FE90", Offset = "0x4E8E690", VA = "0x184E8FE90", Slot = "5")]
	public ArraySegment<byte> JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public APODDEKKKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class JKHICDONDCC : global::JECENNBIMEI<string>, EBBBNEHKICB, global::MFAJIMKKIPB<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::JECENNBIMEI<string> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x524DC00", Offset = "0x524C400", VA = "0x18524DC00", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, string NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x524DBF0", Offset = "0x524C3F0", VA = "0x18524DBF0", Slot = "5")]
	public string JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x524DC00", Offset = "0x524C400", VA = "0x18524DC00", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, string NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x524DBF0", Offset = "0x524C3F0", VA = "0x18524DBF0", Slot = "7")]
	public string BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JKHICDONDCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class BKGBDMJPPNH : global::JECENNBIMEI<string[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly BKGBDMJPPNH KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4E92EF0", Offset = "0x4E916F0", VA = "0x184E92EF0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, string[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4E92C90", Offset = "0x4E91490", VA = "0x184E92C90", Slot = "5")]
	public string[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BKGBDMJPPNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EENEJEJBPCI : global::JECENNBIMEI<char>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly EENEJEJBPCI KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C640", Offset = "0x4E9AE40", VA = "0x184E9C640", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, char NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C610", Offset = "0x4E9AE10", VA = "0x184E9C610", Slot = "5")]
	public char JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EENEJEJBPCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HCIOAKHDCCB : global::JECENNBIMEI<char?>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly HCIOAKHDCCB KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x52403B0", Offset = "0x523EBB0", VA = "0x1852403B0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, char? NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x52402E0", Offset = "0x523EAE0", VA = "0x1852402E0", Slot = "5")]
	public char? JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HCIOAKHDCCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class OAJDCOFEPGG : global::JECENNBIMEI<char[]>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly OAJDCOFEPGG KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x550B760", Offset = "0x5509F60", VA = "0x18550B760", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, char[] NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x550B5C0", Offset = "0x5509DC0", VA = "0x18550B5C0", Slot = "5")]
	public char[] JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public OAJDCOFEPGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KKGHGJFOHIA : global::JECENNBIMEI<Guid>, EBBBNEHKICB, global::MFAJIMKKIPB<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::JECENNBIMEI<Guid> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5252FF0", Offset = "0x52517F0", VA = "0x185252FF0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Guid NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5252F70", Offset = "0x5251770", VA = "0x185252F70", Slot = "5")]
	public Guid JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x5252FC0", Offset = "0x52517C0", VA = "0x185252FC0", Slot = "6")]
	public void IPADFKBCMLC(ref LMANJAHJEKC IJMHHNEJPMM, Guid NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5252F70", Offset = "0x5251770", VA = "0x185252F70", Slot = "7")]
	public Guid BPFKKECDNDD(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KKGHGJFOHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class LJBGNDEOBHM : global::JECENNBIMEI<decimal>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::JECENNBIMEI<decimal> KKHIANFEDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool FHEGJJLBJFK;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8A6F60", Offset = "0x8A5760", VA = "0x1808A6F60")]
	public LJBGNDEOBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x115B1A0", Offset = "0x11599A0", VA = "0x18115B1A0")]
	public LJBGNDEOBHM(bool FHEGJJLBJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5257CB0", Offset = "0x52564B0", VA = "0x185257CB0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, decimal NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5257A80", Offset = "0x5256280", VA = "0x185257A80", Slot = "5")]
	public decimal JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class BBMCKBLMCEL : global::JECENNBIMEI<Uri>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::JECENNBIMEI<Uri> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E901F0", Offset = "0x4E8E9F0", VA = "0x184E901F0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Uri NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4E90170", Offset = "0x4E8E970", VA = "0x184E90170", Slot = "5")]
	public Uri JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BBMCKBLMCEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class ALLNPCAACMI : global::JECENNBIMEI<Version>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::JECENNBIMEI<Version> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F7F0", Offset = "0x4E8DFF0", VA = "0x184E8F7F0", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Version NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F770", Offset = "0x4E8DF70", VA = "0x184E8F770", Slot = "5")]
	public Version JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public ALLNPCAACMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class EIOLNMMCBHE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class LHJLNBACDMD : global::JECENNBIMEI<StringBuilder>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::JECENNBIMEI<StringBuilder> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5257790", Offset = "0x5255F90", VA = "0x185257790", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, StringBuilder NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5257710", Offset = "0x5255F10", VA = "0x185257710", Slot = "5")]
	public StringBuilder JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LHJLNBACDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class JEOPFFGJAJF : global::JECENNBIMEI<BitArray>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::JECENNBIMEI<BitArray> KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x524D780", Offset = "0x524BF80", VA = "0x18524D780", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, BitArray NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x524D660", Offset = "0x524BE60", VA = "0x18524D660", Slot = "5")]
	public BitArray JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JEOPFFGJAJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class ACMNECHDGIB : global::JECENNBIMEI<Type>, EBBBNEHKICB
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly ACMNECHDGIB KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex PCGKEFAGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool OFCNCOIOKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DOCPKJJBEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool FHJBMPKJACD;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E7E0", Offset = "0x4E8CFE0", VA = "0x184E8E7E0")]
	public ACMNECHDGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E800", Offset = "0x4E8D000", VA = "0x184E8E800")]
	public ACMNECHDGIB(bool OFCNCOIOKKN, bool DOCPKJJBEFG, bool FHJBMPKJACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E630", Offset = "0x4E8CE30", VA = "0x184E8E630", Slot = "4")]
	public void ODHIHDMAPDF(ref LMANJAHJEKC IJMHHNEJPMM, Type NPHADDCNBHE, KFGIIMCBFCL EFPFNPHJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E500", Offset = "0x4E8CD00", VA = "0x184E8E500", Slot = "5")]
	public Type JFCMHHFNDFE(ref EILLEGCDDNJ AODHOCAKPON, KFGIIMCBFCL EFPFNPHJGLP)
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
