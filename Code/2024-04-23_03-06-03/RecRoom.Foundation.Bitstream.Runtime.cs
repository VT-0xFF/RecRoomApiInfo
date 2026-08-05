using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FLDLAIGHMID
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LDLGGPDKJGF<T>(GJMGCHHKJOF BPEIDAMPHFE, T LDGMLLMKHLF) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T FHGBKFBBDNO<T>(NGKBLPHGNPG AMMJOMFBDDI) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MIADNCDCACC
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct NGKBLPHGNPG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate NGKBLPHGNPG ODIMPHIKBCE(NGKBLPHGNPG PNMNIPGGMGH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> GPKMLHOONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly ODIMPHIKBCE MHNNEBCGCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int MFAKLKNGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int HJCDANGGLPA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62A7FF0", Offset = "0x62A6FF0", VA = "0x1862A7FF0")]
	public NGKBLPHGNPG(ReadOnlySpan<byte> GPKMLHOONCL, int MFAKLKNGMPH = 0, int HJCDANGGLPA = 0, [Optional] ODIMPHIKBCE MHNNEBCGCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CCNFGMPFLMF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27146B0", Offset = "0x27136B0", VA = "0x1827146B0")]
	public static T CDGJENMFNJM<T>(this NGKBLPHGNPG AMMJOMFBDDI) where T : struct, FLDLAIGHMID
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62A6CC0", Offset = "0x62A5CC0", VA = "0x1862A6CC0")]
	public static bool CMDKHOAOCGB(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62A6A00", Offset = "0x62A5A00", VA = "0x1862A6A00")]
	public static byte AFCMEJDMMFA(this NGKBLPHGNPG PNMNIPGGMGH, byte HOABPAFIAPI, byte NIFHLPCOLNF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62A6DD0", Offset = "0x62A5DD0", VA = "0x1862A6DD0")]
	public static sbyte ELNFJFKMNCL(this NGKBLPHGNPG PNMNIPGGMGH, sbyte HOABPAFIAPI, sbyte NIFHLPCOLNF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62A6B20", Offset = "0x62A5B20", VA = "0x1862A6B20")]
	public static ushort AIPPDJFCAAI(this NGKBLPHGNPG PNMNIPGGMGH, ushort HOABPAFIAPI, ushort NIFHLPCOLNF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62A6E70", Offset = "0x62A5E70", VA = "0x1862A6E70")]
	public static short EMCIIDNADDN(this NGKBLPHGNPG PNMNIPGGMGH, short HOABPAFIAPI, short NIFHLPCOLNF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62A6F20", Offset = "0x62A5F20", VA = "0x1862A6F20")]
	public static uint FFIHHCGDGLH(this NGKBLPHGNPG PNMNIPGGMGH, uint HOABPAFIAPI, uint NIFHLPCOLNF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62A7120", Offset = "0x62A6120", VA = "0x1862A7120")]
	public static int NABBGEFHEGN(this NGKBLPHGNPG PNMNIPGGMGH, int HOABPAFIAPI, int NIFHLPCOLNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62A6F90", Offset = "0x62A5F90", VA = "0x1862A6F90")]
	public static int GLFMFFCHAEA(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62A6C30", Offset = "0x62A5C30", VA = "0x1862A6C30")]
	public static long CKMEOPNEMNO(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62A6AA0", Offset = "0x62A5AA0", VA = "0x1862A6AA0")]
	public static uint AFNAOKAKKEM(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62A6D80", Offset = "0x62A5D80", VA = "0x1862A6D80")]
	public static ulong EBFJOCFPALL(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62A6F10", Offset = "0x62A5F10", VA = "0x1862A6F10")]
	public static float EOCBJAKHOIH(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62A7050", Offset = "0x62A6050", VA = "0x1862A7050")]
	public static double HKDEHDICJJI(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62A6BC0", Offset = "0x62A5BC0", VA = "0x1862A6BC0")]
	public static float3 CBCJIPKIDBO(this NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DIGGOBNCICE
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EPIIMOJCHPK
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62A7430", Offset = "0x62A6430", VA = "0x1862A7430")]
	public static void OKECGOKAMCH(this GJMGCHHKJOF BPEIDAMPHFE, uint LHFDLFGKHLN, bool GNCOFGDAHCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62A7280", Offset = "0x62A6280", VA = "0x1862A7280")]
	public static uint DAMFHHOOIEJ(this NGKBLPHGNPG AMMJOMFBDDI, bool GNCOFGDAHCH = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OGMIDGFJLJO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct BOHONBHJPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint GFAOPJLEPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint IFLGGIJDBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double LHBDBGMPJLK;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62A7050", Offset = "0x62A6050", VA = "0x1862A7050")]
	public static double HKDEHDICJJI(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62A8030", Offset = "0x62A7030", VA = "0x1862A8030")]
	public static void EBPCABOIBBP(double LDGMLLMKHLF, GJMGCHHKJOF PNMNIPGGMGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OICOJCFCIEA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GFKGBGIEPID<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		public GFKGBGIEPID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JFFOIINEMJP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		public JFFOIINEMJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FJHCNLOCBPC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		public FJHCNLOCBPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JBGACLDOGJC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		public JBGACLDOGJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CCKNCEJJEKA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		public CCKNCEJJEKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class EHCMCPNDGCH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		public EHCMCPNDGCH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EAOEEGCEMHJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KMCPAOBBDAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint OLDGIKMNFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float CKPADJPHOLA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x62A7190", Offset = "0x62A6190", VA = "0x1862A7190")]
	public static float EOCBJAKHOIH(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62A7220", Offset = "0x62A6220", VA = "0x1862A7220")]
	public static void JCOBMMJIOEH(float LDGMLLMKHLF, GJMGCHHKJOF PNMNIPGGMGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AEBADFJMLHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BMJLNBMNMLO
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly int[] CGEHGPOGJDA;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62A53A0", Offset = "0x62A43A0", VA = "0x1862A53A0")]
	public static int BNOOPOPDALL(uint ALGANNKILKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62A5450", Offset = "0x62A4450", VA = "0x1862A5450")]
	public static uint CANNJFJPBOH(int HGOMNOGOPHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62A63C0", Offset = "0x62A53C0", VA = "0x1862A63C0")]
	private static uint LCFAANECFEE(int HGOMNOGOPHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62A64F0", Offset = "0x62A54F0", VA = "0x1862A64F0")]
	public static int MHHGMHKGDCL(int LDGMLLMKHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62A55A0", Offset = "0x62A45A0", VA = "0x1862A55A0")]
	public static bool CMDKHOAOCGB(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62A51F0", Offset = "0x62A41F0", VA = "0x1862A51F0")]
	public static byte AFCMEJDMMFA(byte HOABPAFIAPI, byte NIFHLPCOLNF, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62A57C0", Offset = "0x62A47C0", VA = "0x1862A57C0")]
	public static sbyte ELNFJFKMNCL(sbyte HOABPAFIAPI, sbyte NIFHLPCOLNF, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62A5330", Offset = "0x62A4330", VA = "0x1862A5330")]
	public static ushort AIPPDJFCAAI(ushort HOABPAFIAPI, ushort NIFHLPCOLNF, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62A5830", Offset = "0x62A4830", VA = "0x1862A5830")]
	public static short EMCIIDNADDN(short HOABPAFIAPI, short NIFHLPCOLNF, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62A5CD0", Offset = "0x62A4CD0", VA = "0x1862A5CD0")]
	public static int GLFMFFCHAEA(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62A5540", Offset = "0x62A4540", VA = "0x1862A5540")]
	public static long CKMEOPNEMNO(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62A52E0", Offset = "0x62A42E0", VA = "0x1862A52E0")]
	public static uint AFNAOKAKKEM(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62A56D0", Offset = "0x62A46D0", VA = "0x1862A56D0")]
	public static ulong EBFJOCFPALL(NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62A5900", Offset = "0x62A4900", VA = "0x1862A5900")]
	public static uint FFIHHCGDGLH(uint HOABPAFIAPI, uint NIFHLPCOLNF, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62A6510", Offset = "0x62A5510", VA = "0x1862A6510")]
	public static int NABBGEFHEGN(int HOABPAFIAPI, int NIFHLPCOLNF, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62A58A0", Offset = "0x62A48A0", VA = "0x1862A58A0")]
	public static uint EPKPBHDBBLA(int HGOMNOGOPHE, NGKBLPHGNPG PNMNIPGGMGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62A6150", Offset = "0x62A5150", VA = "0x1862A6150")]
	public static uint KCMNADPJNFH(int GANCAAFECFA, NGKBLPHGNPG DFKOHNJAKHM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62A6670", Offset = "0x62A5670", VA = "0x1862A6670")]
	private static void OAODNPIAKLC(NGKBLPHGNPG PNMNIPGGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62A60F0", Offset = "0x62A50F0", VA = "0x1862A60F0")]
	public static void JIJCEPAFCGA(bool LDGMLLMKHLF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62A54C0", Offset = "0x62A44C0", VA = "0x1862A54C0")]
	public static void CKEPHIALLHL(byte LDGMLLMKHLF, byte HOABPAFIAPI, byte NIFHLPCOLNF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62A6340", Offset = "0x62A5340", VA = "0x1862A6340")]
	public static void KGOCGGJHFAB(sbyte LDGMLLMKHLF, sbyte HOABPAFIAPI, sbyte NIFHLPCOLNF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62A5260", Offset = "0x62A4260", VA = "0x1862A5260")]
	public static void AFKLMGKJBHF(ushort LDGMLLMKHLF, ushort HOABPAFIAPI, ushort NIFHLPCOLNF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62A5C50", Offset = "0x62A4C50", VA = "0x1862A5C50")]
	public static void GGPKCOJGEJG(short LDGMLLMKHLF, short HOABPAFIAPI, short NIFHLPCOLNF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62A65C0", Offset = "0x62A55C0", VA = "0x1862A65C0")]
	public static void NOCDONGELLK(uint LDGMLLMKHLF, uint HOABPAFIAPI, uint NIFHLPCOLNF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62A63D0", Offset = "0x62A53D0", VA = "0x1862A63D0")]
	public static void MCKHKECGNMM(int LDGMLLMKHLF, int HOABPAFIAPI, int NIFHLPCOLNF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62A67E0", Offset = "0x62A57E0", VA = "0x1862A67E0")]
	public static void PBDDMFCGCEB(int LDGMLLMKHLF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62A6760", Offset = "0x62A5760", VA = "0x1862A6760")]
	public static void OOHKBFFOFCP(long LDGMLLMKHLF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62A6490", Offset = "0x62A5490", VA = "0x1862A6490")]
	public static void MDDKIOJDKII(uint LDGMLLMKHLF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62A5DE0", Offset = "0x62A4DE0", VA = "0x1862A5DE0")]
	public static void IDKADNNFMPA(ulong LDGMLLMKHLF, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62A59B0", Offset = "0x62A49B0", VA = "0x1862A59B0")]
	public static void GGGIELPCFLP(uint LDGMLLMKHLF, int HGOMNOGOPHE, GJMGCHHKJOF DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62A6880", Offset = "0x62A5880", VA = "0x1862A6880")]
	private static void PIACAJBEFOJ(GJMGCHHKJOF PNMNIPGGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62A5630", Offset = "0x62A4630", VA = "0x1862A5630")]
	private static ulong CONCMNEKAFE(ulong LDGMLLMKHLF, GJMGCHHKJOF PNMNIPGGMGH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62A5D60", Offset = "0x62A4D60", VA = "0x1862A5D60")]
	public static int HBHPCAAJHHH(GJMGCHHKJOF PNMNIPGGMGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class NGNKLIMGNME
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5380230", Offset = "0x537F230", VA = "0x185380230")]
	public static int ICLJOMHNJJD(uint MBGPCNKOEPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62A8020", Offset = "0x62A7020", VA = "0x1862A8020")]
	public static long OPGBHEGBKAO(ulong MBGPCNKOEPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5388E50", Offset = "0x5387E50", VA = "0x185388E50")]
	public static uint OKHHJDKPCIG(int MBGPCNKOEPO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62A8010", Offset = "0x62A7010", VA = "0x1862A8010")]
	public static ulong BNOCFNMNEJC(long MBGPCNKOEPO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MPFFGLDBPMI
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct CGDOCKNJOIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] IDAJCEMIFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stream FEMBCGGKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int MFAKLKNGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int HJCDANGGLPA;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct GJMGCHHKJOF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate GJMGCHHKJOF DNGHFHKGDJD(GJMGCHHKJOF PNMNIPGGMGH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Span<byte> GPKMLHOONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly DNGHFHKGDJD OAGGKOOHPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal int MFAKLKNGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal int HJCDANGGLPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> EDBLHICKAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62A75D0", Offset = "0x62A65D0", VA = "0x1862A75D0")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62A7690", Offset = "0x62A6690", VA = "0x1862A7690")]
	public GJMGCHHKJOF(Span<byte> GPKMLHOONCL, int MFAKLKNGMPH = 0, int HJCDANGGLPA = 0, [Optional] DNGHFHKGDJD OAGGKOOHPJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IEPEJAHEDNK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x28FE7C0", Offset = "0x28FD7C0", VA = "0x1828FE7C0")]
	public static void JBODEMHGHEN<T>(this GJMGCHHKJOF BPEIDAMPHFE, T LDGMLLMKHLF) where T : struct, FLDLAIGHMID
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62A7B00", Offset = "0x62A6B00", VA = "0x1862A7B00")]
	public static void JIJCEPAFCGA(this GJMGCHHKJOF PNMNIPGGMGH, bool LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62A7860", Offset = "0x62A6860", VA = "0x1862A7860")]
	public static void CKEPHIALLHL(this GJMGCHHKJOF PNMNIPGGMGH, byte LDGMLLMKHLF, byte HOABPAFIAPI, byte NIFHLPCOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62A7B90", Offset = "0x62A6B90", VA = "0x1862A7B90")]
	public static void KGOCGGJHFAB(this GJMGCHHKJOF PNMNIPGGMGH, sbyte LDGMLLMKHLF, sbyte HOABPAFIAPI, sbyte NIFHLPCOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62A76B0", Offset = "0x62A66B0", VA = "0x1862A76B0")]
	public static void AFKLMGKJBHF(this GJMGCHHKJOF PNMNIPGGMGH, ushort LDGMLLMKHLF, ushort HOABPAFIAPI, ushort NIFHLPCOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62A7990", Offset = "0x62A6990", VA = "0x1862A7990")]
	public static void GGPKCOJGEJG(this GJMGCHHKJOF PNMNIPGGMGH, short LDGMLLMKHLF, short HOABPAFIAPI, short NIFHLPCOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62A7D50", Offset = "0x62A6D50", VA = "0x1862A7D50")]
	public static void NOCDONGELLK(this GJMGCHHKJOF PNMNIPGGMGH, uint LDGMLLMKHLF, uint HOABPAFIAPI, uint NIFHLPCOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62A7C40", Offset = "0x62A6C40", VA = "0x1862A7C40")]
	public static void MCKHKECGNMM(this GJMGCHHKJOF PNMNIPGGMGH, int LDGMLLMKHLF, int HOABPAFIAPI, int NIFHLPCOLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x62A7E80", Offset = "0x62A6E80", VA = "0x1862A7E80")]
	public static void PBDDMFCGCEB(this GJMGCHHKJOF PNMNIPGGMGH, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62A7DD0", Offset = "0x62A6DD0", VA = "0x1862A7DD0")]
	public static void OOHKBFFOFCP(this GJMGCHHKJOF PNMNIPGGMGH, long LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62A7CC0", Offset = "0x62A6CC0", VA = "0x1862A7CC0")]
	public static void MDDKIOJDKII(this GJMGCHHKJOF PNMNIPGGMGH, uint LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62A7A40", Offset = "0x62A6A40", VA = "0x1862A7A40")]
	public static void IDKADNNFMPA(this GJMGCHHKJOF PNMNIPGGMGH, ulong LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62A7AA0", Offset = "0x62A6AA0", VA = "0x1862A7AA0")]
	public static void JCOBMMJIOEH(this GJMGCHHKJOF PNMNIPGGMGH, float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62A7910", Offset = "0x62A6910", VA = "0x1862A7910")]
	public static void EBPCABOIBBP(this GJMGCHHKJOF PNMNIPGGMGH, double LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62A7760", Offset = "0x62A6760", VA = "0x1862A7760")]
	public static void BDNNFILBJHL(this GJMGCHHKJOF PNMNIPGGMGH, [In] float3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62A7F50", Offset = "0x62A6F50", VA = "0x1862A7F50")]
	public static int PMFELLMMKJF(this GJMGCHHKJOF PNMNIPGGMGH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CKEHPJAMLMC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CKEHPJAMLMC()
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
