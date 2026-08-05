using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GJJMNANPJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EDPNOIGGJDF<T>(BMMCFOKNLEA OKFNJFEOHFM, T LPCGJALKADL) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T NDBFJOJPCAL<T>(FGNCKLJOJDM FCCGPHFBEFP) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NHGPOGDLKBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct FGNCKLJOJDM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate FGNCKLJOJDM AMHDHLLDJOG(FGNCKLJOJDM JHHKBGNPJPD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly AMHDHLLDJOG ALHNPFMDEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int MKDJBHJPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int GEHFBIDJODI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7DE0", Offset = "0x5CC71E0", VA = "0x185CC7DE0")]
	public FGNCKLJOJDM(ReadOnlySpan<byte> OOIBMCBCEPD, int MKDJBHJPEEK = 0, int GEHFBIDJODI = 0, [Optional] AMHDHLLDJOG ALHNPFMDEKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FNOKHFCIPKM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23BBB10", Offset = "0x23BAF10", VA = "0x1823BBB10")]
	public static T JOJALNAGPCM<T>(this FGNCKLJOJDM FCCGPHFBEFP) where T : struct, GJJMNANPJKP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8000", Offset = "0x5CC7400", VA = "0x185CC8000")]
	public static bool GJFDJAOAEIJ(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC80D0", Offset = "0x5CC74D0", VA = "0x185CC80D0")]
	public static byte ILMDCDEKPKI(this FGNCKLJOJDM JHHKBGNPJPD, byte PEEGOPLLJMP, byte PKPCPGJEDCE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7F60", Offset = "0x5CC7360", VA = "0x185CC7F60")]
	public static sbyte FGKJDDAHBNI(this FGNCKLJOJDM JHHKBGNPJPD, sbyte PEEGOPLLJMP, sbyte PKPCPGJEDCE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7EC0", Offset = "0x5CC72C0", VA = "0x185CC7EC0")]
	public static ushort CJNOIELNLEJ(this FGNCKLJOJDM JHHKBGNPJPD, ushort PEEGOPLLJMP, ushort PKPCPGJEDCE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8390", Offset = "0x5CC7790", VA = "0x185CC8390")]
	public static short MMCGKGCMGNJ(this FGNCKLJOJDM JHHKBGNPJPD, short PEEGOPLLJMP, short PKPCPGJEDCE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8170", Offset = "0x5CC7570", VA = "0x185CC8170")]
	public static uint JBBGAAFKLFM(this FGNCKLJOJDM JHHKBGNPJPD, uint PEEGOPLLJMP, uint PKPCPGJEDCE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8250", Offset = "0x5CC7650", VA = "0x185CC8250")]
	public static int KIDIGHJGJMC(this FGNCKLJOJDM JHHKBGNPJPD, int PEEGOPLLJMP, int PKPCPGJEDCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7E00", Offset = "0x5CC7200", VA = "0x185CC7E00")]
	public static int AGNGMJBDOCG(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8430", Offset = "0x5CC7830", VA = "0x185CC8430")]
	public static long OKIIEBHBKAN(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8310", Offset = "0x5CC7710", VA = "0x185CC8310")]
	public static uint MHAKFFMBBAI(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CC82C0", Offset = "0x5CC76C0", VA = "0x185CC82C0")]
	public static ulong LGKEBEJBIHI(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CC80C0", Offset = "0x5CC74C0", VA = "0x185CC80C0")]
	public static float HCHGNJKLHKK(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7BB0", Offset = "0x5CC6FB0", VA = "0x185CC7BB0")]
	public static double FGHHNGCHFIF(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CC81E0", Offset = "0x5CC75E0", VA = "0x185CC81E0")]
	public static float3 JJDLECDIFPM(this FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LKMBODIBKAN
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HANDCMOIMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8670", Offset = "0x5CC7A70", VA = "0x185CC8670")]
	public static void FMONEEKGGIO(this BMMCFOKNLEA OKFNJFEOHFM, uint GBJDDENOKHP, bool PKGOIKKBBJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC84C0", Offset = "0x5CC78C0", VA = "0x185CC84C0")]
	public static uint DHHADBFNMBH(this FGNCKLJOJDM FCCGPHFBEFP, bool PKGOIKKBBJI = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AKOMBGLJBIC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct BGLDKAKEFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint GDLBNFNFMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint DKFMBCEJOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double JMDDABAELLA;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7BB0", Offset = "0x5CC6FB0", VA = "0x185CC7BB0")]
	public static double FGHHNGCHFIF(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7C80", Offset = "0x5CC7080", VA = "0x185CC7C80")]
	public static void LMEJGODJHND(double LPCGJALKADL, BMMCFOKNLEA JHHKBGNPJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HDEEECJJEON
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MDBBPKEJHLE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MDBBPKEJHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF760", Offset = "0x3AEEB60", VA = "0x183AEF760")]
		internal void HIDDPIOPBML(BMMCFOKNLEA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF730", Offset = "0x3AEEB30", VA = "0x183AEF730")]
		internal T CCFDFHIJGGI(FGNCKLJOJDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KBAPIEBCPGJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KBAPIEBCPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37DF740", Offset = "0x37DEB40", VA = "0x1837DF740")]
		internal void KFCKOMDLGPJ(BMMCFOKNLEA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x37DF710", Offset = "0x37DEB10", VA = "0x1837DF710")]
		internal T BPPAHHBNBBA(FGNCKLJOJDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PEFGJFHDBHO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PEFGJFHDBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3E239D0", Offset = "0x3E22DD0", VA = "0x183E239D0")]
		internal void BBDFFKCAANN(BMMCFOKNLEA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3E23A00", Offset = "0x3E22E00", VA = "0x183E23A00")]
		internal T NEGMCAJMJPH(FGNCKLJOJDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HBCGMEHIMKM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HBCGMEHIMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x34FEE00", Offset = "0x34FE200", VA = "0x1834FEE00")]
		internal void FJJKGJMFMAJ(BMMCFOKNLEA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x34FEDD0", Offset = "0x34FE1D0", VA = "0x1834FEDD0")]
		internal T DIBJDIDCBLO(FGNCKLJOJDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BJBOCOCGEPB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BJBOCOCGEPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x44A5B10", Offset = "0x44A4F10", VA = "0x1844A5B10")]
		internal void EEFEFBKNOBN(BMMCFOKNLEA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x44A5AF0", Offset = "0x44A4EF0", VA = "0x1844A5AF0")]
		internal T BNAFMPIFGMI(FGNCKLJOJDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JPAOOOFLAEH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JPAOOOFLAEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37B4540", Offset = "0x37B3940", VA = "0x1837B4540")]
		internal void EKEAFJDBMLL(BMMCFOKNLEA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37B4570", Offset = "0x37B3970", VA = "0x1837B4570")]
		internal T ILFCOCBCAGE(FGNCKLJOJDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23D53F0", Offset = "0x23D47F0", VA = "0x1823D53F0")]
	public static void MEHLCPDBDMO<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x23D5060", Offset = "0x23D4460", VA = "0x1823D5060")]
	private static void BFKFANBECJH<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x23D5060", Offset = "0x23D4460", VA = "0x1823D5060")]
	private static void DOEKLIIDEHF<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23D5190", Offset = "0x23D4590", VA = "0x1823D5190")]
	private static void IMOGDOADCMG<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23D5190", Offset = "0x23D4590", VA = "0x1823D5190")]
	private static void NBJPFHLBABG<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23D52C0", Offset = "0x23D46C0", VA = "0x1823D52C0")]
	private static void KLCCBCEBOOC<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23D52C0", Offset = "0x23D46C0", VA = "0x1823D52C0")]
	private static void OPOBFEGMDHK<T>(T MAKCHOBJLOO, T NFJOIFHGCKE, [Out] EDPNOIGGJDF<T> CPNMAJBLDPA, [Out] NDBFJOJPCAL<T> HDDNPIPALHP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KJNFIMLPFJE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct HNBLCNDFPNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public uint OGIJJNAHBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float DLDLEEGFNPL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8870", Offset = "0x5CC7C70", VA = "0x185CC8870")]
	public static float HCHGNJKLHKK(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8810", Offset = "0x5CC7C10", VA = "0x185CC8810")]
	public static void GCMKKMDIEPK(float LPCGJALKADL, BMMCFOKNLEA JHHKBGNPJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KDDMAHAGENP
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AJPPIHBGJJG
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly int[] KGIPEABFJCC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CC78A0", Offset = "0x5CC6CA0", VA = "0x185CC78A0")]
	public static int OGOAADLGDGP(uint BENIIGDMCOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7340", Offset = "0x5CC6740", VA = "0x185CC7340")]
	public static uint IOEDAOADCMF(int NFFLCAOLBIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC66D0", Offset = "0x5CC5AD0", VA = "0x185CC66D0")]
	private static uint ANHHJFJMNBB(int NFFLCAOLBIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC75F0", Offset = "0x5CC69F0", VA = "0x185CC75F0")]
	public static int LEHABOJGHBD(int LPCGJALKADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7000", Offset = "0x5CC6400", VA = "0x185CC7000")]
	public static bool GJFDJAOAEIJ(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7230", Offset = "0x5CC6630", VA = "0x185CC7230")]
	public static byte ILMDCDEKPKI(byte PEEGOPLLJMP, byte PKPCPGJEDCE, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F90", Offset = "0x5CC6390", VA = "0x185CC6F90")]
	public static sbyte FGKJDDAHBNI(sbyte PEEGOPLLJMP, sbyte PKPCPGJEDCE, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6C60", Offset = "0x5CC6060", VA = "0x185CC6C60")]
	public static ushort CJNOIELNLEJ(ushort PEEGOPLLJMP, ushort PKPCPGJEDCE, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CC77B0", Offset = "0x5CC6BB0", VA = "0x185CC77B0")]
	public static short MMCGKGCMGNJ(short PEEGOPLLJMP, short PKPCPGJEDCE, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CC63A0", Offset = "0x5CC57A0", VA = "0x185CC63A0")]
	public static int AGNGMJBDOCG(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7950", Offset = "0x5CC6D50", VA = "0x185CC7950")]
	public static long OKIIEBHBKAN(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7760", Offset = "0x5CC6B60", VA = "0x185CC7760")]
	public static uint MHAKFFMBBAI(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7610", Offset = "0x5CC6A10", VA = "0x185CC7610")]
	public static ulong LGKEBEJBIHI(FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CC73B0", Offset = "0x5CC67B0", VA = "0x185CC73B0")]
	public static uint JBBGAAFKLFM(uint PEEGOPLLJMP, uint PKPCPGJEDCE, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7540", Offset = "0x5CC6940", VA = "0x185CC7540")]
	public static int KIDIGHJGJMC(int PEEGOPLLJMP, int PKPCPGJEDCE, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F30", Offset = "0x5CC6330", VA = "0x185CC6F30")]
	public static uint FBKKNMFNEDA(int NFFLCAOLBIM, FGNCKLJOJDM JHHKBGNPJPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6A70", Offset = "0x5CC5E70", VA = "0x185CC6A70")]
	public static uint CHMCDBFGFLO(int LEBLDJINKEC, FGNCKLJOJDM CNKGFJIJGPA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7A30", Offset = "0x5CC6E30", VA = "0x185CC7A30")]
	private static void PPDPDAEOANJ(FGNCKLJOJDM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7700", Offset = "0x5CC6B00", VA = "0x185CC7700")]
	public static void LPOAFKFGNEC(bool LPCGJALKADL, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7820", Offset = "0x5CC6C20", VA = "0x185CC7820")]
	public static void NJHNDMAMPHI(byte LPCGJALKADL, byte PEEGOPLLJMP, byte PKPCPGJEDCE, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC79B0", Offset = "0x5CC6DB0", VA = "0x185CC79B0")]
	public static void OMDHOOCKEFB(sbyte LPCGJALKADL, sbyte PEEGOPLLJMP, sbyte PKPCPGJEDCE, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7090", Offset = "0x5CC6490", VA = "0x185CC7090")]
	public static void HIMOJALFPAM(ushort LPCGJALKADL, ushort PEEGOPLLJMP, ushort PKPCPGJEDCE, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC69F0", Offset = "0x5CC5DF0", VA = "0x185CC69F0")]
	public static void BLINNACKOIL(short LPCGJALKADL, short PEEGOPLLJMP, short PKPCPGJEDCE, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6E80", Offset = "0x5CC6280", VA = "0x185CC6E80")]
	public static void ECLLMACIBCE(uint LPCGJALKADL, uint PEEGOPLLJMP, uint PKPCPGJEDCE, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6CD0", Offset = "0x5CC60D0", VA = "0x185CC6CD0")]
	public static void COGDBCCCHOC(int LPCGJALKADL, int PEEGOPLLJMP, int PKPCPGJEDCE, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7110", Offset = "0x5CC6510", VA = "0x185CC7110")]
	public static void IDGCFGNFMPC(int LPCGJALKADL, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CC74C0", Offset = "0x5CC68C0", VA = "0x185CC74C0")]
	public static void JNNPGBJHMOJ(long LPCGJALKADL, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7460", Offset = "0x5CC6860", VA = "0x185CC7460")]
	public static void JEICBICMEJH(uint LPCGJALKADL, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CC66E0", Offset = "0x5CC5AE0", VA = "0x185CC66E0")]
	public static void BEAMJOLGENB(ulong LPCGJALKADL, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6430", Offset = "0x5CC5830", VA = "0x185CC6430")]
	public static void AHENIAOGACI(uint LPCGJALKADL, int NFFLCAOLBIM, BMMCFOKNLEA CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6D90", Offset = "0x5CC6190", VA = "0x185CC6D90")]
	private static void DMKBBFJOEEF(BMMCFOKNLEA JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CC72A0", Offset = "0x5CC66A0", VA = "0x185CC72A0")]
	private static ulong IMEPAEPDFDO(ulong LPCGJALKADL, BMMCFOKNLEA JHHKBGNPJPD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CC71B0", Offset = "0x5CC65B0", VA = "0x185CC71B0")]
	public static int IGAMBIMOMAL(BMMCFOKNLEA JHHKBGNPJPD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class ELCEPKJNEIC
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0060", Offset = "0x4EAF460", VA = "0x184EB0060")]
	public static int CINDOGCPMBE(uint AJKNMOMPICG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0070", Offset = "0x4EAF470", VA = "0x184EB0070")]
	public static long POIABBPGMDC(ulong AJKNMOMPICG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBF50", Offset = "0x4EBB350", VA = "0x184EBBF50")]
	public static uint JBADLFGJLBI(int AJKNMOMPICG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBF60", Offset = "0x4EBB360", VA = "0x184EBBF60")]
	public static ulong CDCCDCKOJDI(long AJKNMOMPICG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EAPCBGGCFHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LCEJBDPPIJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] DOGIBAMCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Stream BKMMHPCMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int MKDJBHJPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int GEHFBIDJODI;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct BMMCFOKNLEA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate BMMCFOKNLEA APDOKMGJBBI(BMMCFOKNLEA JHHKBGNPJPD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly Span<byte> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly APDOKMGJBBI GHHPOPBHCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal int MKDJBHJPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal int GEHFBIDJODI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> KNNBKOMJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7D00", Offset = "0x5CC7100", VA = "0x185CC7D00")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7DC0", Offset = "0x5CC71C0", VA = "0x185CC7DC0")]
	public BMMCFOKNLEA(Span<byte> OOIBMCBCEPD, int MKDJBHJPEEK = 0, int GEHFBIDJODI = 0, [Optional] APDOKMGJBBI GHHPOPBHCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KPOMCBBPIAE
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2444270", Offset = "0x2443670", VA = "0x182444270")]
	public static void OJKOCGEKNOC<T>(this BMMCFOKNLEA OKFNJFEOHFM, T LPCGJALKADL) where T : struct, GJJMNANPJKP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9050", Offset = "0x5CC8450", VA = "0x185CC9050")]
	public static void LPOAFKFGNEC(this BMMCFOKNLEA JHHKBGNPJPD, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CC90E0", Offset = "0x5CC84E0", VA = "0x185CC90E0")]
	public static void NJHNDMAMPHI(this BMMCFOKNLEA JHHKBGNPJPD, byte LPCGJALKADL, byte PEEGOPLLJMP, byte PKPCPGJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9190", Offset = "0x5CC8590", VA = "0x185CC9190")]
	public static void OMDHOOCKEFB(this BMMCFOKNLEA JHHKBGNPJPD, sbyte LPCGJALKADL, sbyte PEEGOPLLJMP, sbyte PKPCPGJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8C10", Offset = "0x5CC8010", VA = "0x185CC8C10")]
	public static void HIMOJALFPAM(this BMMCFOKNLEA JHHKBGNPJPD, ushort LPCGJALKADL, ushort PEEGOPLLJMP, ushort PKPCPGJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8A00", Offset = "0x5CC7E00", VA = "0x185CC8A00")]
	public static void BLINNACKOIL(this BMMCFOKNLEA JHHKBGNPJPD, short LPCGJALKADL, short PEEGOPLLJMP, short PKPCPGJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8B30", Offset = "0x5CC7F30", VA = "0x185CC8B30")]
	public static void ECLLMACIBCE(this BMMCFOKNLEA JHHKBGNPJPD, uint LPCGJALKADL, uint PEEGOPLLJMP, uint PKPCPGJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8AB0", Offset = "0x5CC7EB0", VA = "0x185CC8AB0")]
	public static void COGDBCCCHOC(this BMMCFOKNLEA JHHKBGNPJPD, int LPCGJALKADL, int PEEGOPLLJMP, int PKPCPGJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8CC0", Offset = "0x5CC80C0", VA = "0x185CC8CC0")]
	public static void IDGCFGNFMPC(this BMMCFOKNLEA JHHKBGNPJPD, int LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8F20", Offset = "0x5CC8320", VA = "0x185CC8F20")]
	public static void JNNPGBJHMOJ(this BMMCFOKNLEA JHHKBGNPJPD, long LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8E90", Offset = "0x5CC8290", VA = "0x185CC8E90")]
	public static void JEICBICMEJH(this BMMCFOKNLEA JHHKBGNPJPD, uint LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC89A0", Offset = "0x5CC7DA0", VA = "0x185CC89A0")]
	public static void BEAMJOLGENB(this BMMCFOKNLEA JHHKBGNPJPD, ulong LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8BB0", Offset = "0x5CC7FB0", VA = "0x185CC8BB0")]
	public static void GCMKKMDIEPK(this BMMCFOKNLEA JHHKBGNPJPD, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8FD0", Offset = "0x5CC83D0", VA = "0x185CC8FD0")]
	public static void LMEJGODJHND(this BMMCFOKNLEA JHHKBGNPJPD, double LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8D90", Offset = "0x5CC8190", VA = "0x185CC8D90")]
	public static void IHNPFJLHLFJ(this BMMCFOKNLEA JHHKBGNPJPD, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8900", Offset = "0x5CC7D00", VA = "0x185CC8900")]
	public static int AKADBFDIKDB(this BMMCFOKNLEA JHHKBGNPJPD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
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
