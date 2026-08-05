using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AHHAJJLHJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JFDEEFLJAHK<T>(BNNEIIHKPAC MCLDKNNIMFL, T FKKGMPDEPMA) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T FPGDACDEBDO<T>(HMLBDOBHPJH OGNANCFBCDL) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNFOALNCLHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct HMLBDOBHPJH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate HMLBDOBHPJH JJHKOGMDGNE(HMLBDOBHPJH GLLIFKANKFD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly JJHKOGMDGNE JNAFHFCAHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int JKCCNNDJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int OPJNKGCKBDD;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC940", Offset = "0x5CCB140", VA = "0x185CCC940")]
	public HMLBDOBHPJH(ReadOnlySpan<byte> AELCABDCBDD, int JKCCNNDJHGD = 0, int OPJNKGCKBDD = 0, [Optional] JJHKOGMDGNE JNAFHFCAHLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JCOJHAKANOL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23BE7E0", Offset = "0x23BCFE0", VA = "0x1823BE7E0")]
	public static T DIAEPIFFLJA<T>(this HMLBDOBHPJH OGNANCFBCDL) where T : struct, AHHAJJLHJMC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE460", Offset = "0x5CCCC60", VA = "0x185CCE460")]
	public static bool GENHIEBBHCM(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE5E0", Offset = "0x5CCCDE0", VA = "0x185CCE5E0")]
	public static byte IADJMNDEDNB(this HMLBDOBHPJH GLLIFKANKFD, byte NBBLPCEJNGK, byte CGCJNJNINBI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE310", Offset = "0x5CCCB10", VA = "0x185CCE310")]
	public static sbyte FDGGGFMCDJJ(this HMLBDOBHPJH GLLIFKANKFD, sbyte NBBLPCEJNGK, sbyte CGCJNJNINBI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE170", Offset = "0x5CCC970", VA = "0x185CCE170")]
	public static ushort AMCOFBMANCO(this HMLBDOBHPJH GLLIFKANKFD, ushort NBBLPCEJNGK, ushort CGCJNJNINBI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE3C0", Offset = "0x5CCCBC0", VA = "0x185CCE3C0")]
	public static short GAMHGKMIOKG(this HMLBDOBHPJH GLLIFKANKFD, short NBBLPCEJNGK, short CGCJNJNINBI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE7C0", Offset = "0x5CCCFC0", VA = "0x185CCE7C0")]
	public static uint OHBBOOGGJAM(this HMLBDOBHPJH GLLIFKANKFD, uint NBBLPCEJNGK, uint CGCJNJNINBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE680", Offset = "0x5CCCE80", VA = "0x185CCE680")]
	public static int JDBMCOMMEBI(this HMLBDOBHPJH GLLIFKANKFD, int NBBLPCEJNGK, int CGCJNJNINBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE520", Offset = "0x5CCCD20", VA = "0x185CCE520")]
	public static int HOHOGCNACLP(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE210", Offset = "0x5CCCA10", VA = "0x185CCE210")]
	public static long CBBPEGPBAKG(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE740", Offset = "0x5CCCF40", VA = "0x185CCE740")]
	public static uint NPAGHBKJFKE(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE6F0", Offset = "0x5CCCEF0", VA = "0x185CCE6F0")]
	public static ulong NDGLKOCKLHI(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE3B0", Offset = "0x5CCCBB0", VA = "0x185CCE3B0")]
	public static float FKBFHKPOEDC(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC350", Offset = "0x5CCAB50", VA = "0x185CCC350")]
	public static double MGLJNFHEBOG(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE2A0", Offset = "0x5CCCAA0", VA = "0x185CCE2A0")]
	public static float3 EPFCLDOIFPG(this HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FPHCHGOOEHM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EJBBPGFILKP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC6B0", Offset = "0x5CCAEB0", VA = "0x185CCC6B0")]
	public static void ODLHMCGLOBE(this BNNEIIHKPAC MCLDKNNIMFL, uint LLCOJHJMAGO, bool KHMPMBBIPMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC500", Offset = "0x5CCAD00", VA = "0x185CCC500")]
	public static uint FGPMBPPENED(this HMLBDOBHPJH OGNANCFBCDL, bool KHMPMBBIPMF = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ABEJPPLONKC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct AOAFNNLFHCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint IFCOOAKFBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint MGFLEBNNINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double GJMEDECMHKI;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC350", Offset = "0x5CCAB50", VA = "0x185CCC350")]
	public static double MGLJNFHEBOG(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC2D0", Offset = "0x5CCAAD0", VA = "0x185CCC2D0")]
	public static void HKJKALEJCHC(double FKKGMPDEPMA, BNNEIIHKPAC GLLIFKANKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GMLHOGHDGJE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MKFOOMHFCHG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MKFOOMHFCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B26F90", Offset = "0x3B25790", VA = "0x183B26F90")]
		internal void OLAIGFDMNFF(BNNEIIHKPAC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B26F60", Offset = "0x3B25760", VA = "0x183B26F60")]
		internal T AMFONGHOHGC(HMLBDOBHPJH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GDHGGGMDFBI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GDHGGGMDFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x34D2720", Offset = "0x34D0F20", VA = "0x1834D2720")]
		internal void LIJAHPBKOBB(BNNEIIHKPAC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x34D2750", Offset = "0x34D0F50", VA = "0x1834D2750")]
		internal T NDDAKKKMGFC(HMLBDOBHPJH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GCGKPAAFGFF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GCGKPAAFGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x34CDD00", Offset = "0x34CC500", VA = "0x1834CDD00")]
		internal void MPPMOAICIHL(BNNEIIHKPAC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x34CDCD0", Offset = "0x34CC4D0", VA = "0x1834CDCD0")]
		internal T IPGAMMKAIMM(HMLBDOBHPJH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PGGOGPAEJOD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PGGOGPAEJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3DA75E0", Offset = "0x3DA5DE0", VA = "0x183DA75E0")]
		internal void AKCKLDFNODN(BNNEIIHKPAC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7610", Offset = "0x3DA5E10", VA = "0x183DA7610")]
		internal T PBBCLMACIEC(HMLBDOBHPJH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class IPKKMNMDNEB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IPKKMNMDNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3669430", Offset = "0x3667C30", VA = "0x183669430")]
		internal void PKCFAEHAFEO(BNNEIIHKPAC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3669410", Offset = "0x3667C10", VA = "0x183669410")]
		internal T FLJBPNAMDIP(HMLBDOBHPJH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class INHFJJEDLKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public INHFJJEDLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x365DC20", Offset = "0x365C420", VA = "0x18365DC20")]
		internal void LHNOBJCDMFJ(BNNEIIHKPAC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x365DC50", Offset = "0x365C450", VA = "0x18365DC50")]
		internal T OFEBBMCBGAM(HMLBDOBHPJH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2365610", Offset = "0x2363E10", VA = "0x182365610")]
	public static void JMEHMCLFHOB<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2365280", Offset = "0x2363A80", VA = "0x182365280")]
	private static void BAHHABFDNCO<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2365280", Offset = "0x2363A80", VA = "0x182365280")]
	private static void HEMDENOBPBB<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23653B0", Offset = "0x2363BB0", VA = "0x1823653B0")]
	private static void BIKPHHJHIED<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23653B0", Offset = "0x2363BB0", VA = "0x1823653B0")]
	private static void CEHKJJOEHCN<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23654E0", Offset = "0x2363CE0", VA = "0x1823654E0")]
	private static void GMBAFIGOGNE<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23654E0", Offset = "0x2363CE0", VA = "0x1823654E0")]
	private static void HIPLGLOFOOB<T>(T NBPDHCAMINO, T JEGKJPODFLL, [Out] JFDEEFLJAHK<T> PGKEDKBJHIE, [Out] FPGDACDEBDO<T> BIJNGIPEEHO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FGIBOKNDPIJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct ANNJJEMAOOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public uint AHKPIJIKFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float LJEFLIDDEOK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC850", Offset = "0x5CCB050", VA = "0x185CCC850")]
	public static float FKBFHKPOEDC(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC8E0", Offset = "0x5CCB0E0", VA = "0x185CCC8E0")]
	public static void PMCJLNLBKKM(float FKKGMPDEPMA, BNNEIIHKPAC GLLIFKANKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KACAIBBLLFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JBHEOEEHBEP
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly int[] DDJEJFLALBI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD220", Offset = "0x5CCBA20", VA = "0x185CCD220")]
	public static int GHOIFBIEDKA(uint MALBOGIHBLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDBA0", Offset = "0x5CCC3A0", VA = "0x185CCDBA0")]
	public static uint NLCPLMKOEOH(int FGKKIKCJAKJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD370", Offset = "0x5CCBB70", VA = "0x185CCD370")]
	private static uint GOJEOMEDNCI(int FGKKIKCJAKJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCD70", Offset = "0x5CCB570", VA = "0x185CCCD70")]
	public static int ELAKDHPPMLO(int FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD190", Offset = "0x5CCB990", VA = "0x185CCD190")]
	public static bool GENHIEBBHCM(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD550", Offset = "0x5CCBD50", VA = "0x185CCD550")]
	public static byte IADJMNDEDNB(byte NBBLPCEJNGK, byte CGCJNJNINBI, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD030", Offset = "0x5CCB830", VA = "0x185CCD030")]
	public static sbyte FDGGGFMCDJJ(sbyte NBBLPCEJNGK, sbyte CGCJNJNINBI, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCAD0", Offset = "0x5CCB2D0", VA = "0x185CCCAD0")]
	public static ushort AMCOFBMANCO(ushort NBBLPCEJNGK, ushort CGCJNJNINBI, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD120", Offset = "0x5CCB920", VA = "0x185CCD120")]
	public static short GAMHGKMIOKG(short NBBLPCEJNGK, short CGCJNJNINBI, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD4C0", Offset = "0x5CCBCC0", VA = "0x185CCD4C0")]
	public static int HOHOGCNACLP(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCB40", Offset = "0x5CCB340", VA = "0x185CCCB40")]
	public static long CBBPEGPBAKG(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDF20", Offset = "0x5CCC720", VA = "0x185CCDF20")]
	public static uint NPAGHBKJFKE(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDAB0", Offset = "0x5CCC2B0", VA = "0x185CCDAB0")]
	public static ulong NDGLKOCKLHI(HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDFD0", Offset = "0x5CCC7D0", VA = "0x185CCDFD0")]
	public static uint OHBBOOGGJAM(uint NBBLPCEJNGK, uint CGCJNJNINBI, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD640", Offset = "0x5CCBE40", VA = "0x185CCD640")]
	public static int JDBMCOMMEBI(int NBBLPCEJNGK, int CGCJNJNINBI, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE080", Offset = "0x5CCC880", VA = "0x185CCE080")]
	public static uint PCGHFLFHGHI(int FGKKIKCJAKJ, HMLBDOBHPJH GLLIFKANKFD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD7D0", Offset = "0x5CCBFD0", VA = "0x185CCD7D0")]
	public static uint MHCFAEPBLBH(int HHLONDGKOHJ, HMLBDOBHPJH FJNGJOFLBMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC9E0", Offset = "0x5CCB1E0", VA = "0x185CCC9E0")]
	private static void AHMPEENJBGF(HMLBDOBHPJH GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDF70", Offset = "0x5CCC770", VA = "0x185CCDF70")]
	public static void OBDMGCBOKAA(bool FKKGMPDEPMA, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD0A0", Offset = "0x5CCB8A0", VA = "0x185CCD0A0")]
	public static void FFCJHJDPDEM(byte FKKGMPDEPMA, byte NBBLPCEJNGK, byte CGCJNJNINBI, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD440", Offset = "0x5CCBC40", VA = "0x185CCD440")]
	public static void HJOLFNBPDNC(sbyte FKKGMPDEPMA, sbyte NBBLPCEJNGK, sbyte CGCJNJNINBI, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD5C0", Offset = "0x5CCBDC0", VA = "0x185CCD5C0")]
	public static void IKGDNGEFFNO(ushort FKKGMPDEPMA, ushort NBBLPCEJNGK, ushort CGCJNJNINBI, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCC40", Offset = "0x5CCB440", VA = "0x185CCCC40")]
	public static void DFDLAKBBLDO(short FKKGMPDEPMA, short NBBLPCEJNGK, short CGCJNJNINBI, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCCC0", Offset = "0x5CCB4C0", VA = "0x185CCCCC0")]
	public static void EKPNBAIGFKM(uint FKKGMPDEPMA, uint NBBLPCEJNGK, uint CGCJNJNINBI, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD380", Offset = "0x5CCBB80", VA = "0x185CCD380")]
	public static void HBPGPCMNEJC(int FKKGMPDEPMA, int NBBLPCEJNGK, int CGCJNJNINBI, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCBA0", Offset = "0x5CCB3A0", VA = "0x185CCCBA0")]
	public static void CLINJEAJOCJ(int FKKGMPDEPMA, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD750", Offset = "0x5CCBF50", VA = "0x185CCD750")]
	public static void MBDBPKKDCCE(long FKKGMPDEPMA, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD6F0", Offset = "0x5CCBEF0", VA = "0x185CCD6F0")]
	public static void LOAOADFJDME(uint FKKGMPDEPMA, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDC10", Offset = "0x5CCC410", VA = "0x185CCDC10")]
	public static void NNMMHMHBLCD(ulong FKKGMPDEPMA, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCD90", Offset = "0x5CCB590", VA = "0x185CCCD90")]
	public static void ELHHOPBNDBJ(uint FKKGMPDEPMA, int FGKKIKCJAKJ, BNNEIIHKPAC FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD9C0", Offset = "0x5CCC1C0", VA = "0x185CCD9C0")]
	private static void MILGLEFHOIM(BNNEIIHKPAC GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD2D0", Offset = "0x5CCBAD0", VA = "0x185CCD2D0")]
	private static ulong GLDIEBGKNOK(ulong FKKGMPDEPMA, BNNEIIHKPAC GLLIFKANKFD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC960", Offset = "0x5CCB160", VA = "0x185CCC960")]
	public static int AFGBFKAHBGJ(BNNEIIHKPAC GLLIFKANKFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class CKHCFKPAMLA
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B980", Offset = "0x4E8A180", VA = "0x184E8B980")]
	public static int CJDKJEGGHIG(uint IOOIAIKIEIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B990", Offset = "0x4E8A190", VA = "0x184E8B990")]
	public static long HMGKMKNOJME(ulong IOOIAIKIEIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E97870", Offset = "0x4E96070", VA = "0x184E97870")]
	public static uint OJPINONDJCN(int IOOIAIKIEIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4E97880", Offset = "0x4E96080", VA = "0x184E97880")]
	public static ulong KHJHMDBIOPN(long IOOIAIKIEIJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MOCHFAODCJM
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct PGPJFHDGNGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] NEJFCHMJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Stream NFDLBBEFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int JKCCNNDJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int OPJNKGCKBDD;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct BNNEIIHKPAC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate BNNEIIHKPAC DNOPBCPNGLB(BNNEIIHKPAC GLLIFKANKFD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly Span<byte> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly DNOPBCPNGLB HIDMPPDOBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal int JKCCNNDJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal int OPJNKGCKBDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> ALIPNBFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCC420", Offset = "0x5CCAC20", VA = "0x185CCC420")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC4E0", Offset = "0x5CCACE0", VA = "0x185CCC4E0")]
	public BNNEIIHKPAC(Span<byte> AELCABDCBDD, int JKCCNNDJHGD = 0, int OPJNKGCKBDD = 0, [Optional] DNOPBCPNGLB HIDMPPDOBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JIHIPNLBFJF
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23C6840", Offset = "0x23C5040", VA = "0x1823C6840")]
	public static void ILHFNKGBFAM<T>(this BNNEIIHKPAC MCLDKNNIMFL, T FKKGMPDEPMA) where T : struct, AHHAJJLHJMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF080", Offset = "0x5CCD880", VA = "0x185CCF080")]
	public static void OBDMGCBOKAA(this BNNEIIHKPAC GLLIFKANKFD, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEAD0", Offset = "0x5CCD2D0", VA = "0x185CCEAD0")]
	public static void FFCJHJDPDEM(this BNNEIIHKPAC GLLIFKANKFD, byte FKKGMPDEPMA, byte NBBLPCEJNGK, byte CGCJNJNINBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEC00", Offset = "0x5CCD400", VA = "0x185CCEC00")]
	public static void HJOLFNBPDNC(this BNNEIIHKPAC GLLIFKANKFD, sbyte FKKGMPDEPMA, sbyte NBBLPCEJNGK, sbyte CGCJNJNINBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CCED30", Offset = "0x5CCD530", VA = "0x185CCED30")]
	public static void IKGDNGEFFNO(this BNNEIIHKPAC GLLIFKANKFD, ushort FKKGMPDEPMA, ushort NBBLPCEJNGK, ushort CGCJNJNINBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE900", Offset = "0x5CCD100", VA = "0x185CCE900")]
	public static void DFDLAKBBLDO(this BNNEIIHKPAC GLLIFKANKFD, short FKKGMPDEPMA, short NBBLPCEJNGK, short CGCJNJNINBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEA50", Offset = "0x5CCD250", VA = "0x185CCEA50")]
	public static void EKPNBAIGFKM(this BNNEIIHKPAC GLLIFKANKFD, uint FKKGMPDEPMA, uint NBBLPCEJNGK, uint CGCJNJNINBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEB80", Offset = "0x5CCD380", VA = "0x185CCEB80")]
	public static void HBPGPCMNEJC(this BNNEIIHKPAC GLLIFKANKFD, int FKKGMPDEPMA, int NBBLPCEJNGK, int CGCJNJNINBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE830", Offset = "0x5CCD030", VA = "0x185CCE830")]
	public static void CLINJEAJOCJ(this BNNEIIHKPAC GLLIFKANKFD, int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEE70", Offset = "0x5CCD670", VA = "0x185CCEE70")]
	public static void MBDBPKKDCCE(this BNNEIIHKPAC GLLIFKANKFD, long FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEDE0", Offset = "0x5CCD5E0", VA = "0x185CCEDE0")]
	public static void LOAOADFJDME(this BNNEIIHKPAC GLLIFKANKFD, uint FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF020", Offset = "0x5CCD820", VA = "0x185CCF020")]
	public static void NNMMHMHBLCD(this BNNEIIHKPAC GLLIFKANKFD, ulong FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF110", Offset = "0x5CCD910", VA = "0x185CCF110")]
	public static void PMCJLNLBKKM(this BNNEIIHKPAC GLLIFKANKFD, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCECB0", Offset = "0x5CCD4B0", VA = "0x185CCECB0")]
	public static void HKJKALEJCHC(this BNNEIIHKPAC GLLIFKANKFD, double FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEF20", Offset = "0x5CCD720", VA = "0x185CCEF20")]
	public static void NKFOBJOMIHO(this BNNEIIHKPAC GLLIFKANKFD, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE9B0", Offset = "0x5CCD1B0", VA = "0x185CCE9B0")]
	public static int ECEPMNOIEFB(this BNNEIIHKPAC GLLIFKANKFD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CAANBFNPALO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CAANBFNPALO()
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
