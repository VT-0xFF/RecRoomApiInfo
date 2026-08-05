using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FEEIINJHFHI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void BBOLBIMFIMD<T>(ILFEGODGKII NEGHIHACAHG, T PHPDIJICBJO) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T PNNFNDIPNHF<T>(FLDIJJAECJM EIFCDBMOGEN) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PEEFDIPAMDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct FLDIJJAECJM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate FLDIJJAECJM CJIBINCOEGF(FLDIJJAECJM IONJMGHHBLL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> KNAIEKIJLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly CJIBINCOEGF LANBBDCNGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int DHILFOLEJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int PELEDKMAIPH;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0320", Offset = "0x5DDF120", VA = "0x185DE0320")]
	public FLDIJJAECJM(ReadOnlySpan<byte> KNAIEKIJLBC, int DHILFOLEJIH = 0, int PELEDKMAIPH = 0, [Optional] CJIBINCOEGF LANBBDCNGGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ODAOGNABKCC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x261CA20", Offset = "0x261B820", VA = "0x18261CA20")]
	public static T KIKHHJIJDCP<T>(this FLDIJJAECJM EIFCDBMOGEN) where T : struct, FEEIINJHFHI
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0A60", Offset = "0x5DDF860", VA = "0x185DE0A60")]
	public static bool HMBGONHAGMG(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0E60", Offset = "0x5DDFC60", VA = "0x185DE0E60")]
	public static byte NJBMOJAGGAJ(this FLDIJJAECJM IONJMGHHBLL, byte LPJGCGFHKAB, byte LKJDNNGOMMI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0C50", Offset = "0x5DDFA50", VA = "0x185DE0C50")]
	public static sbyte KKLHHKKPIGM(this FLDIJJAECJM IONJMGHHBLL, sbyte LPJGCGFHKAB, sbyte LKJDNNGOMMI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0950", Offset = "0x5DDF750", VA = "0x185DE0950")]
	public static ushort EPLEFDODKKI(this FLDIJJAECJM IONJMGHHBLL, ushort LPJGCGFHKAB, ushort LKJDNNGOMMI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0860", Offset = "0x5DDF660", VA = "0x185DE0860")]
	public static short BKGIKFHJOKB(this FLDIJJAECJM IONJMGHHBLL, short LPJGCGFHKAB, short LKJDNNGOMMI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B20", Offset = "0x5DDF920", VA = "0x185DE0B20")]
	public static uint IDIJIPHDGAK(this FLDIJJAECJM IONJMGHHBLL, uint LPJGCGFHKAB, uint LKJDNNGOMMI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DE09F0", Offset = "0x5DDF7F0", VA = "0x185DE09F0")]
	public static int GBFILAGDMBB(this FLDIJJAECJM IONJMGHHBLL, int LPJGCGFHKAB, int LKJDNNGOMMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B90", Offset = "0x5DDF990", VA = "0x185DE0B90")]
	public static int KIKGOJPPMLL(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0CF0", Offset = "0x5DDFAF0", VA = "0x185DE0CF0")]
	public static long MBKMNJCIDAH(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0F70", Offset = "0x5DDFD70", VA = "0x185DE0F70")]
	public static uint PKEMJEBOLBP(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0900", Offset = "0x5DDF700", VA = "0x185DE0900")]
	public static ulong DBBJOGCLKIB(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0E50", Offset = "0x5DDFC50", VA = "0x185DE0E50")]
	public static float MJDKCFBGFAP(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0D80", Offset = "0x5DDFB80", VA = "0x185DE0D80")]
	public static double MEMEKNBOLOF(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0F00", Offset = "0x5DDFD00", VA = "0x185DE0F00")]
	public static float3 PIPBHIBPEBB(this FLDIJJAECJM IONJMGHHBLL)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FKBLLFIOCMI
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KJLPEDPJEAG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0420", Offset = "0x5DDF220", VA = "0x185DE0420")]
	public static void MPCLLAGPOOI(this ILFEGODGKII NEGHIHACAHG, uint FPIJPLHKHFP, bool DBBIGGCNAIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE05C0", Offset = "0x5DDF3C0", VA = "0x185DE05C0")]
	public static uint NLJHOKEPEDN(this FLDIJJAECJM EIFCDBMOGEN, bool DBBIGGCNAIF = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OJEDABGKGKP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct HIAEIKIEPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint PJCLLCOAGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint BILHJHIMLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double JMOIEDONKON;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0D80", Offset = "0x5DDFB80", VA = "0x185DE0D80")]
	public static double MEMEKNBOLOF(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0FF0", Offset = "0x5DDFDF0", VA = "0x185DE0FF0")]
	public static void GPMFAGGNIEB(double PHPDIJICBJO, ILFEGODGKII IONJMGHHBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LAFOGLPLAPO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LBKABBIEPHD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LBKABBIEPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2790", Offset = "0x3AA1590", VA = "0x183AA2790")]
		internal void DIIGMMGKAFP(ILFEGODGKII b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AA27C0", Offset = "0x3AA15C0", VA = "0x183AA27C0")]
		internal T NGMEOJOHBIA(FLDIJJAECJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GHHGGKMOIKC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public GHHGGKMOIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x35CC9E0", Offset = "0x35CB7E0", VA = "0x1835CC9E0")]
		internal void DNKKMGDFBNC(ILFEGODGKII b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x35CCA10", Offset = "0x35CB810", VA = "0x1835CCA10")]
		internal T JJLDDGBNAID(FLDIJJAECJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GMAIBACDFMN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public GMAIBACDFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x35EAE40", Offset = "0x35E9C40", VA = "0x1835EAE40")]
		internal void MOFJFABJDJG(ILFEGODGKII b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x35EAE10", Offset = "0x35E9C10", VA = "0x1835EAE10")]
		internal T AOGKLMFNEFH(FLDIJJAECJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BDFBBMOMANP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public BDFBBMOMANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4562860", Offset = "0x4561660", VA = "0x184562860")]
		internal void DMONEMKCGII(ILFEGODGKII b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4562830", Offset = "0x4561630", VA = "0x184562830")]
		internal T BCCEJOAJLGL(FLDIJJAECJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LFIFIFMMHNG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LFIFIFMMHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2E20", Offset = "0x3AB1C20", VA = "0x183AB2E20")]
		internal void KMIBKJHIDOM(ILFEGODGKII b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2E00", Offset = "0x3AB1C00", VA = "0x183AB2E00")]
		internal T ACOKIHLMIEM(FLDIJJAECJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class AJGIHCKJEDK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public AJGIHCKJEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37B3510", Offset = "0x37B2310", VA = "0x1837B3510")]
		internal void NMADLNJMECE(ILFEGODGKII b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37B34F0", Offset = "0x37B22F0", VA = "0x1837B34F0")]
		internal T MIDNOKKAKDF(FLDIJJAECJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x25576F0", Offset = "0x25564F0", VA = "0x1825576F0")]
	public static void DDAJHKNKKDH<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2557A30", Offset = "0x2556830", VA = "0x182557A30")]
	private static void PONJDIBPFOO<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2557A30", Offset = "0x2556830", VA = "0x182557A30")]
	private static void PDANOLNIPNC<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2557900", Offset = "0x2556700", VA = "0x182557900")]
	private static void JMJEAPFKMHH<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2557900", Offset = "0x2556700", VA = "0x182557900")]
	private static void GNPFAMPOOJJ<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25575C0", Offset = "0x25563C0", VA = "0x1825575C0")]
	private static void BHFDANMLCKG<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25575C0", Offset = "0x25563C0", VA = "0x1825575C0")]
	private static void JFHNILHBLCD<T>(T JKEMBJGJJKI, T LLLCDDJJCLJ, [Out] BBOLBIMFIMD<T> OMNLAGNHKDM, [Out] PNNFNDIPNHF<T> MKFGAJPMKJD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NGDHBMGBICO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct LEAIEOELJHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public uint NLIGHBEGJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float LKNJCANFMHK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DE07D0", Offset = "0x5DDF5D0", VA = "0x185DE07D0")]
	public static float MJDKCFBGFAP(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0770", Offset = "0x5DDF570", VA = "0x185DE0770")]
	public static void IPMJIIGAGLI(float PHPDIJICBJO, ILFEGODGKII IONJMGHHBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CFBCNFPPJFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EGCPHGIDNPI
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly int[] NFIEKFNECCD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF620", Offset = "0x5DDE420", VA = "0x185DDF620")]
	public static int IALBBLLHBDJ(uint DNMDMILIMDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF800", Offset = "0x5DDE600", VA = "0x185DDF800")]
	public static uint IPCLBHEKEJF(int KKELDBLPAGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEE10", Offset = "0x5DDDC10", VA = "0x185DDEE10")]
	private static uint EDFIDPAHHNO(int KKELDBLPAGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFC40", Offset = "0x5DDEA40", VA = "0x185DDFC40")]
	public static int KKBAPMFLHNH(int PHPDIJICBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF590", Offset = "0x5DDE390", VA = "0x185DDF590")]
	public static bool HMBGONHAGMG(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0150", Offset = "0x5DDEF50", VA = "0x185DE0150")]
	public static byte NJBMOJAGGAJ(byte LPJGCGFHKAB, byte LKJDNNGOMMI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFC60", Offset = "0x5DDEA60", VA = "0x185DDFC60")]
	public static sbyte KKLHHKKPIGM(sbyte LPJGCGFHKAB, sbyte LKJDNNGOMMI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF220", Offset = "0x5DDE020", VA = "0x185DDF220")]
	public static ushort EPLEFDODKKI(ushort LPJGCGFHKAB, ushort LKJDNNGOMMI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEBB0", Offset = "0x5DDD9B0", VA = "0x185DDEBB0")]
	public static short BKGIKFHJOKB(short LPJGCGFHKAB, short LKJDNNGOMMI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFBB0", Offset = "0x5DDE9B0", VA = "0x185DDFBB0")]
	public static int KIKGOJPPMLL(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFF70", Offset = "0x5DDED70", VA = "0x185DDFF70")]
	public static long MBKMNJCIDAH(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0240", Offset = "0x5DDF040", VA = "0x185DE0240")]
	public static uint PKEMJEBOLBP(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5DDECA0", Offset = "0x5DDDAA0", VA = "0x185DDECA0")]
	public static ulong DBBJOGCLKIB(FLDIJJAECJM IONJMGHHBLL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF6D0", Offset = "0x5DDE4D0", VA = "0x185DDF6D0")]
	public static uint IDIJIPHDGAK(uint LPJGCGFHKAB, uint LKJDNNGOMMI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF480", Offset = "0x5DDE280", VA = "0x185DDF480")]
	public static int GBFILAGDMBB(int LPJGCGFHKAB, int LKJDNNGOMMI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF870", Offset = "0x5DDE670", VA = "0x185DDF870")]
	public static uint JHDLEGFABAJ(int KKELDBLPAGI, FLDIJJAECJM IONJMGHHBLL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF290", Offset = "0x5DDE090", VA = "0x185DDF290")]
	public static uint FIJLGMNGIKD(int KGDOFKOFGFE, FLDIJJAECJM GMIADHJEACD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF130", Offset = "0x5DDDF30", VA = "0x185DDF130")]
	private static void EOFPECFLBEE(FLDIJJAECJM IONJMGHHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF530", Offset = "0x5DDE330", VA = "0x185DDF530")]
	public static void HHONHNLPKOG(bool PHPDIJICBJO, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF780", Offset = "0x5DDE580", VA = "0x185DDF780")]
	public static void IIOFCNPOMEJ(byte PHPDIJICBJO, byte LPJGCGFHKAB, byte LKJDNNGOMMI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFB30", Offset = "0x5DDE930", VA = "0x185DDFB30")]
	public static void JJMFLIBHLMO(sbyte PHPDIJICBJO, sbyte LPJGCGFHKAB, sbyte LKJDNNGOMMI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE01C0", Offset = "0x5DDEFC0", VA = "0x185DE01C0")]
	public static void OOHGIBLEGEE(ushort PHPDIJICBJO, ushort LPJGCGFHKAB, ushort LKJDNNGOMMI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE00D0", Offset = "0x5DDEED0", VA = "0x185DE00D0")]
	public static void MKDHMBCNOMN(short PHPDIJICBJO, short LPJGCGFHKAB, short LKJDNNGOMMI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFA80", Offset = "0x5DDE880", VA = "0x185DDFA80")]
	public static void JJGMNKEPDHK(uint PHPDIJICBJO, uint LPJGCGFHKAB, uint LKJDNNGOMMI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF9C0", Offset = "0x5DDE7C0", VA = "0x185DDF9C0")]
	public static void JJCOJEKJMMM(int PHPDIJICBJO, int LPJGCGFHKAB, int LKJDNNGOMMI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFFD0", Offset = "0x5DDEDD0", VA = "0x185DDFFD0")]
	public static void MCKHBIGEFDE(int PHPDIJICBJO, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEC20", Offset = "0x5DDDA20", VA = "0x185DDEC20")]
	public static void CODJBGGEJKF(long PHPDIJICBJO, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0070", Offset = "0x5DDEE70", VA = "0x185DE0070")]
	public static void MFMCPHEHPFH(uint PHPDIJICBJO, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEE20", Offset = "0x5DDDC20", VA = "0x185DDEE20")]
	public static void EMNCFLOCGCF(ulong PHPDIJICBJO, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFCD0", Offset = "0x5DDEAD0", VA = "0x185DDFCD0")]
	public static void LLHOIEIIOFE(uint PHPDIJICBJO, int KKELDBLPAGI, ILFEGODGKII GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF8D0", Offset = "0x5DDE6D0", VA = "0x185DDF8D0")]
	private static void JHFFPHGIMAG(ILFEGODGKII IONJMGHHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEB10", Offset = "0x5DDD910", VA = "0x185DDEB10")]
	private static ulong AEBNDNKLDAB(ulong PHPDIJICBJO, ILFEGODGKII IONJMGHHBLL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DDED90", Offset = "0x5DDDB90", VA = "0x185DDED90")]
	public static int DFOCNIKLDLO(ILFEGODGKII IONJMGHHBLL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class HADBPPLDOKM
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4F89150", Offset = "0x4F87F50", VA = "0x184F89150")]
	public static int HGNGLFKDHJN(uint EPLBKNNLLBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4F89160", Offset = "0x4F87F60", VA = "0x184F89160")]
	public static long PBFNEKMFDIO(ulong EPLBKNNLLBN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4F95130", Offset = "0x4F93F30", VA = "0x184F95130")]
	public static uint ECKEJCBKHND(int EPLBKNNLLBN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F95140", Offset = "0x4F93F40", VA = "0x184F95140")]
	public static ulong EOMAOAKAHEF(long EPLBKNNLLBN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CNGGIFMNMNL
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HFPONKCLBJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] BNFLLCFHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Stream PCDNEJJECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int DHILFOLEJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int PELEDKMAIPH;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct ILFEGODGKII
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate ILFEGODGKII NAJMDDMMMME(ILFEGODGKII IONJMGHHBLL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly Span<byte> KNAIEKIJLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly NAJMDDMMMME FNLNFPLKBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal int DHILFOLEJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal int PELEDKMAIPH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> EJDKALNMHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0340", Offset = "0x5DDF140", VA = "0x185DE0340")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0400", Offset = "0x5DDF200", VA = "0x185DE0400")]
	public ILFEGODGKII(Span<byte> KNAIEKIJLBC, int DHILFOLEJIH = 0, int PELEDKMAIPH = 0, [Optional] NAJMDDMMMME FNLNFPLKBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CINLOJBBDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23172F0", Offset = "0x23160F0", VA = "0x1823172F0")]
	public static void FDCGHODCMHC<T>(this ILFEGODGKII NEGHIHACAHG, T PHPDIJICBJO) where T : struct, FEEIINJHFHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE360", Offset = "0x5DDD160", VA = "0x185DDE360")]
	public static void HHONHNLPKOG(this ILFEGODGKII IONJMGHHBLL, bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE4F0", Offset = "0x5DDD2F0", VA = "0x185DDE4F0")]
	public static void IIOFCNPOMEJ(this ILFEGODGKII IONJMGHHBLL, byte PHPDIJICBJO, byte LPJGCGFHKAB, byte LKJDNNGOMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE700", Offset = "0x5DDD500", VA = "0x185DDE700")]
	public static void JJMFLIBHLMO(this ILFEGODGKII IONJMGHHBLL, sbyte PHPDIJICBJO, sbyte LPJGCGFHKAB, sbyte LKJDNNGOMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEA60", Offset = "0x5DDD860", VA = "0x185DDEA60")]
	public static void OOHGIBLEGEE(this ILFEGODGKII IONJMGHHBLL, ushort PHPDIJICBJO, ushort LPJGCGFHKAB, ushort LKJDNNGOMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE910", Offset = "0x5DDD710", VA = "0x185DDE910")]
	public static void MKDHMBCNOMN(this ILFEGODGKII IONJMGHHBLL, short PHPDIJICBJO, short LPJGCGFHKAB, short LKJDNNGOMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE680", Offset = "0x5DDD480", VA = "0x185DDE680")]
	public static void JJGMNKEPDHK(this ILFEGODGKII IONJMGHHBLL, uint PHPDIJICBJO, uint LPJGCGFHKAB, uint LKJDNNGOMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE600", Offset = "0x5DDD400", VA = "0x185DDE600")]
	public static void JJCOJEKJMMM(this ILFEGODGKII IONJMGHHBLL, int PHPDIJICBJO, int LPJGCGFHKAB, int LKJDNNGOMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE7B0", Offset = "0x5DDD5B0", VA = "0x185DDE7B0")]
	public static void MCKHBIGEFDE(this ILFEGODGKII IONJMGHHBLL, int PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE1D0", Offset = "0x5DDCFD0", VA = "0x185DDE1D0")]
	public static void CODJBGGEJKF(this ILFEGODGKII IONJMGHHBLL, long PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE880", Offset = "0x5DDD680", VA = "0x185DDE880")]
	public static void MFMCPHEHPFH(this ILFEGODGKII IONJMGHHBLL, uint PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE280", Offset = "0x5DDD080", VA = "0x185DDE280")]
	public static void EMNCFLOCGCF(this ILFEGODGKII IONJMGHHBLL, ulong PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE5A0", Offset = "0x5DDD3A0", VA = "0x185DDE5A0")]
	public static void IPMJIIGAGLI(this ILFEGODGKII IONJMGHHBLL, float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE2E0", Offset = "0x5DDD0E0", VA = "0x185DDE2E0")]
	public static void GPMFAGGNIEB(this ILFEGODGKII IONJMGHHBLL, double PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE3F0", Offset = "0x5DDD1F0", VA = "0x185DDE3F0")]
	public static void HPFNEJLPCBK(this ILFEGODGKII IONJMGHHBLL, [In] float3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE9C0", Offset = "0x5DDD7C0", VA = "0x185DDE9C0")]
	public static int OEMBILNHNNP(this ILFEGODGKII IONJMGHHBLL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
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
}
