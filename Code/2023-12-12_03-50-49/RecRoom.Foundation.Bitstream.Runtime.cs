using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OHCAPAOIPLG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void NONMIMEAOJI<T>(PFFIILDLBFJ MDONNIFBLDI, T DOLICEBFIPF) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T DNJKHCBCOJO<T>(MMGHFMPGADP EINLOJPKPLI) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ENLHIBPLNCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct MMGHFMPGADP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate MMGHFMPGADP LNAALENPCMB(MMGHFMPGADP GLCCGOBFPBA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> FCHBDAMJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly LNAALENPCMB DFFEACFMBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int CJLPIOLPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int IGKKHNDKEFF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E03460", Offset = "0x5E01C60", VA = "0x185E03460")]
	public MMGHFMPGADP(ReadOnlySpan<byte> FCHBDAMJEHN, int CJLPIOLPKMF = 0, int IGKKHNDKEFF = 0, [Optional] LNAALENPCMB DFFEACFMBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OGJHGOBMAML
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x264B580", Offset = "0x2649D80", VA = "0x18264B580")]
	public static T OHNEPJEMAEP<T>(this MMGHFMPGADP EINLOJPKPLI) where T : struct, OHCAPAOIPLG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E04170", Offset = "0x5E02970", VA = "0x185E04170")]
	public static bool GBPFPOCLJEF(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E03EB0", Offset = "0x5E026B0", VA = "0x185E03EB0")]
	public static byte CHIDBIHCHEC(this MMGHFMPGADP GLCCGOBFPBA, byte NIJJMMEOIDJ, byte HBJHLIEIPFF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04340", Offset = "0x5E02B40", VA = "0x185E04340")]
	public static sbyte NHLKKIANHJO(this MMGHFMPGADP GLCCGOBFPBA, sbyte NIJJMMEOIDJ, sbyte HBJHLIEIPFF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E043E0", Offset = "0x5E02BE0", VA = "0x185E043E0")]
	public static ushort PEGACPKGBIM(this MMGHFMPGADP GLCCGOBFPBA, ushort NIJJMMEOIDJ, ushort HBJHLIEIPFF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E03FC0", Offset = "0x5E027C0", VA = "0x185E03FC0")]
	public static short DAOLKCKPPID(this MMGHFMPGADP GLCCGOBFPBA, short NIJJMMEOIDJ, short HBJHLIEIPFF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5E04240", Offset = "0x5E02A40", VA = "0x185E04240")]
	public static uint GPIEADOAKGJ(this MMGHFMPGADP GLCCGOBFPBA, uint NIJJMMEOIDJ, uint HBJHLIEIPFF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E03F50", Offset = "0x5E02750", VA = "0x185E03F50")]
	public static int CMKJBAGMAIP(this MMGHFMPGADP GLCCGOBFPBA, int NIJJMMEOIDJ, int HBJHLIEIPFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E040B0", Offset = "0x5E028B0", VA = "0x185E040B0")]
	public static int FCCAGMPLKDF(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E042B0", Offset = "0x5E02AB0", VA = "0x185E042B0")]
	public static long MNNKGOGLHFN(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E03E30", Offset = "0x5E02630", VA = "0x185E03E30")]
	public static uint BLOAGKKLACP(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E04060", Offset = "0x5E02860", VA = "0x185E04060")]
	public static ulong EFAFFBEEEPG(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E04230", Offset = "0x5E02A30", VA = "0x185E04230")]
	public static float GHCKIMEJKAE(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E01740", Offset = "0x5DFFF40", VA = "0x185E01740")]
	public static double JKMCIDINNEP(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E03DC0", Offset = "0x5E025C0", VA = "0x185E03DC0")]
	public static float3 AEFLKGIFIHI(this MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DANFGMHMBBC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JCPDJHPNNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E031D0", Offset = "0x5E019D0", VA = "0x185E031D0")]
	public static void IKIEPKPJAIF(this PFFIILDLBFJ MDONNIFBLDI, uint PLFHFLICDJI, bool PHEEGOFIHNE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03020", Offset = "0x5E01820", VA = "0x185E03020")]
	public static uint EPFCNHIMPOJ(this MMGHFMPGADP EINLOJPKPLI, bool PHEEGOFIHNE = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AMEKKBEOLGP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct FDHICBFLFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint DAFPJDFCLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint KADFDNKIEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double FDGPIHAJJGH;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E01740", Offset = "0x5DFFF40", VA = "0x185E01740")]
	public static double JKMCIDINNEP(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E016C0", Offset = "0x5DFFEC0", VA = "0x185E016C0")]
	public static void DIPGDFMBCBI(double DOLICEBFIPF, PFFIILDLBFJ GLCCGOBFPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ILNLPMEPBLA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KBEEOKGLHBB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public KBEEOKGLHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38E18D0", Offset = "0x38E00D0", VA = "0x1838E18D0")]
		internal void DLHEKKKPNLB(PFFIILDLBFJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38E1900", Offset = "0x38E0100", VA = "0x1838E1900")]
		internal T NODCPJCHNKO(MMGHFMPGADP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class CFFJEPPNLDM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CFFJEPPNLDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x48F46A0", Offset = "0x48F2EA0", VA = "0x1848F46A0")]
		internal void NKHNLGFNKBI(PFFIILDLBFJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x48F4670", Offset = "0x48F2E70", VA = "0x1848F4670")]
		internal T GFPBFPPMPCI(MMGHFMPGADP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GIOBINALCKN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GIOBINALCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x351D3F0", Offset = "0x351BBF0", VA = "0x18351D3F0")]
		internal void DFKAHHGHAPH(PFFIILDLBFJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x351D420", Offset = "0x351BC20", VA = "0x18351D420")]
		internal T ILOHPFACEJB(MMGHFMPGADP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IABJHBGMBOL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IABJHBGMBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3684E90", Offset = "0x3683690", VA = "0x183684E90")]
		internal void EBNKFLGLMHB(PFFIILDLBFJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3684E60", Offset = "0x3683660", VA = "0x183684E60")]
		internal T AMDPAENFAHE(MMGHFMPGADP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JKPBHJNOHJC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JKPBHJNOHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x38A55C0", Offset = "0x38A3DC0", VA = "0x1838A55C0")]
		internal void FFFEGGJOBHK(PFFIILDLBFJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38A55A0", Offset = "0x38A3DA0", VA = "0x1838A55A0")]
		internal T CIEKGHGKIPD(MMGHFMPGADP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class BIHACPKKCOH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BIHACPKKCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46007A0", Offset = "0x45FEFA0", VA = "0x1846007A0")]
		internal void FMOGKGEGNOE(PFFIILDLBFJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4600780", Offset = "0x45FEF80", VA = "0x184600780")]
		internal T CDCMGBKLIND(MMGHFMPGADP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x250B870", Offset = "0x250A070", VA = "0x18250B870")]
	public static void GANIFPBENEO<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x250B4E0", Offset = "0x2509CE0", VA = "0x18250B4E0")]
	private static void DBDPDEJLDKP<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x250B4E0", Offset = "0x2509CE0", VA = "0x18250B4E0")]
	private static void CLADFACCGHC<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x250B740", Offset = "0x2509F40", VA = "0x18250B740")]
	private static void EJAFAEMHLNE<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x250B740", Offset = "0x2509F40", VA = "0x18250B740")]
	private static void MAFICNHLONP<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x250B610", Offset = "0x2509E10", VA = "0x18250B610")]
	private static void JCABLIKDLAH<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x250B610", Offset = "0x2509E10", VA = "0x18250B610")]
	private static void ECCMFMMFLMA<T>(T LNKNIJLOFGE, T ECDEJDOACEB, [Out] NONMIMEAOJI<T> JIAEBJGBHKL, [Out] DNJKHCBCOJO<T> IMEBNNHGFIH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MHNBLMKENPF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KHAGNPBALAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public uint IDIOELKIAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float CIAPLCLOLBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E033D0", Offset = "0x5E01BD0", VA = "0x185E033D0")]
	public static float GHCKIMEJKAE(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E03370", Offset = "0x5E01B70", VA = "0x185E03370")]
	public static void EAPHKJOPKKB(float DOLICEBFIPF, PFFIILDLBFJ GLCCGOBFPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MMJPOPLJEHI
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IFADKCOJPJF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly int[] DAGCHDCLDOO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E020B0", Offset = "0x5E008B0", VA = "0x185E020B0")]
	public static int GAKLLFHJBJD(uint AFCMABIGIJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E02890", Offset = "0x5E01090", VA = "0x185E02890")]
	public static uint MGDGDOLAOFO(int IENOIEJCKFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E01DB0", Offset = "0x5E005B0", VA = "0x185E01DB0")]
	private static uint DNIEFAIOPLC(int IENOIEJCKFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E01AB0", Offset = "0x5E002B0", VA = "0x185E01AB0")]
	public static int AJFAGJAIILN(int DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E02160", Offset = "0x5E00960", VA = "0x185E02160")]
	public static bool GBPFPOCLJEF(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E01B20", Offset = "0x5E00320", VA = "0x185E01B20")]
	public static byte CHIDBIHCHEC(byte NIJJMMEOIDJ, byte HBJHLIEIPFF, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E02AA0", Offset = "0x5E012A0", VA = "0x185E02AA0")]
	public static sbyte NHLKKIANHJO(sbyte NIJJMMEOIDJ, sbyte HBJHLIEIPFF, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E02F20", Offset = "0x5E01720", VA = "0x185E02F20")]
	public static ushort PEGACPKGBIM(ushort NIJJMMEOIDJ, ushort HBJHLIEIPFF, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E01D40", Offset = "0x5E00540", VA = "0x185E01D40")]
	public static short DAOLKCKPPID(short NIJJMMEOIDJ, short HBJHLIEIPFF, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E02020", Offset = "0x5E00820", VA = "0x185E02020")]
	public static int FCCAGMPLKDF(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E02A40", Offset = "0x5E01240", VA = "0x185E02A40")]
	public static long MNNKGOGLHFN(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E01AD0", Offset = "0x5E002D0", VA = "0x185E01AD0")]
	public static uint BLOAGKKLACP(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E01DC0", Offset = "0x5E005C0", VA = "0x185E01DC0")]
	public static ulong EFAFFBEEEPG(MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5E023E0", Offset = "0x5E00BE0", VA = "0x185E023E0")]
	public static uint GPIEADOAKGJ(uint NIJJMMEOIDJ, uint HBJHLIEIPFF, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E01C90", Offset = "0x5E00490", VA = "0x185E01C90")]
	public static int CMKJBAGMAIP(int NIJJMMEOIDJ, int HBJHLIEIPFF, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E025E0", Offset = "0x5E00DE0", VA = "0x185E025E0")]
	public static uint JLJMPMBFMEB(int IENOIEJCKFH, MMGHFMPGADP GLCCGOBFPBA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E021F0", Offset = "0x5E009F0", VA = "0x185E021F0")]
	public static uint GMCCPMJIMOJ(int DCMDEAGPGNF, MMGHFMPGADP LFDLOIPEDMO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E01EB0", Offset = "0x5E006B0", VA = "0x185E01EB0")]
	private static void EKEBEINKEMB(MMGHFMPGADP GLCCGOBFPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02830", Offset = "0x5E01030", VA = "0x185E02830")]
	public static void MAOIAFCIIOB(bool DOLICEBFIPF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E02E20", Offset = "0x5E01620", VA = "0x185E02E20")]
	public static void OGKINOANAPO(byte DOLICEBFIPF, byte NIJJMMEOIDJ, byte HBJHLIEIPFF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E01C10", Offset = "0x5E00410", VA = "0x185E01C10")]
	public static void CLELBDFOJFN(sbyte DOLICEBFIPF, sbyte NIJJMMEOIDJ, sbyte HBJHLIEIPFF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E01B90", Offset = "0x5E00390", VA = "0x185E01B90")]
	public static void CLEKEPNKIOM(ushort DOLICEBFIPF, ushort NIJJMMEOIDJ, ushort HBJHLIEIPFF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E01FA0", Offset = "0x5E007A0", VA = "0x185E01FA0")]
	public static void EOEIBPFNAMJ(short DOLICEBFIPF, short NIJJMMEOIDJ, short HBJHLIEIPFF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E02530", Offset = "0x5E00D30", VA = "0x185E02530")]
	public static void IGKJAMJLKAI(uint DOLICEBFIPF, uint NIJJMMEOIDJ, uint HBJHLIEIPFF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E02980", Offset = "0x5E01180", VA = "0x185E02980")]
	public static void MMPJKMJGKBK(int DOLICEBFIPF, int NIJJMMEOIDJ, int HBJHLIEIPFF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E02490", Offset = "0x5E00C90", VA = "0x185E02490")]
	public static void GPKHOIBFCIP(int DOLICEBFIPF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E02900", Offset = "0x5E01100", VA = "0x185E02900")]
	public static void MKIABDKOKEG(long DOLICEBFIPF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E026E0", Offset = "0x5E00EE0", VA = "0x185E026E0")]
	public static void KLFCEHCIDJG(uint DOLICEBFIPF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E02B10", Offset = "0x5E01310", VA = "0x185E02B10")]
	public static void NJHDDCIJLFJ(ulong DOLICEBFIPF, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E01810", Offset = "0x5E00010", VA = "0x185E01810")]
	public static void AFFKLFINGIK(uint DOLICEBFIPF, int IENOIEJCKFH, PFFIILDLBFJ LFDLOIPEDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E02740", Offset = "0x5E00F40", VA = "0x185E02740")]
	private static void LDABFJCNDBE(PFFIILDLBFJ GLCCGOBFPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E02640", Offset = "0x5E00E40", VA = "0x185E02640")]
	private static ulong KGIPOEDFLFP(ulong DOLICEBFIPF, PFFIILDLBFJ GLCCGOBFPBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E02EA0", Offset = "0x5E016A0", VA = "0x185E02EA0")]
	public static int OMFNKNBKJKO(PFFIILDLBFJ GLCCGOBFPBA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class JECIKHOBEKF
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA69F0", Offset = "0x4FA51F0", VA = "0x184FA69F0")]
	public static int NGCDOMJINMH(uint FIGFPNIEGIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6A00", Offset = "0x4FA5200", VA = "0x184FA6A00")]
	public static long EOFOFLHBMIO(ulong FIGFPNIEGIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4FB29D0", Offset = "0x4FB11D0", VA = "0x184FB29D0")]
	public static uint EHNOGJPHBJE(int FIGFPNIEGIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4FB29E0", Offset = "0x4FB11E0", VA = "0x184FB29E0")]
	public static ulong BOFHFDLDOOD(long FIGFPNIEGIA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KDGDPOPEOLH
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct APHCCGIABLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] IJPAPFCFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Stream HLAKDKDHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int CJLPIOLPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int IGKKHNDKEFF;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct PFFIILDLBFJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate PFFIILDLBFJ EECAHEBECNO(PFFIILDLBFJ GLCCGOBFPBA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly Span<byte> FCHBDAMJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly EECAHEBECNO DEDHNBLNINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal int CJLPIOLPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal int IGKKHNDKEFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> IGCILALIHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E04480", Offset = "0x5E02C80", VA = "0x185E04480")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E04540", Offset = "0x5E02D40", VA = "0x185E04540")]
	public PFFIILDLBFJ(Span<byte> FCHBDAMJEHN, int CJLPIOLPKMF = 0, int IGKKHNDKEFF = 0, [Optional] EECAHEBECNO DEDHNBLNINE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NKBMJECGCJA
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x262D1A0", Offset = "0x262B9A0", VA = "0x18262D1A0")]
	public static void AFHOGBCJPKC<T>(this PFFIILDLBFJ MDONNIFBLDI, T DOLICEBFIPF) where T : struct, OHCAPAOIPLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5E03AF0", Offset = "0x5E022F0", VA = "0x185E03AF0")]
	public static void MAOIAFCIIOB(this PFFIILDLBFJ GLCCGOBFPBA, bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E03D10", Offset = "0x5E02510", VA = "0x185E03D10")]
	public static void OGKINOANAPO(this PFFIILDLBFJ GLCCGOBFPBA, byte DOLICEBFIPF, byte NIJJMMEOIDJ, byte HBJHLIEIPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E036D0", Offset = "0x5E01ED0", VA = "0x185E036D0")]
	public static void CLELBDFOJFN(this PFFIILDLBFJ GLCCGOBFPBA, sbyte DOLICEBFIPF, sbyte NIJJMMEOIDJ, sbyte HBJHLIEIPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E03620", Offset = "0x5E01E20", VA = "0x185E03620")]
	public static void CLEKEPNKIOM(this PFFIILDLBFJ GLCCGOBFPBA, ushort DOLICEBFIPF, ushort NIJJMMEOIDJ, ushort HBJHLIEIPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E03860", Offset = "0x5E02060", VA = "0x185E03860")]
	public static void EOEIBPFNAMJ(this PFFIILDLBFJ GLCCGOBFPBA, short DOLICEBFIPF, short NIJJMMEOIDJ, short HBJHLIEIPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E039E0", Offset = "0x5E021E0", VA = "0x185E039E0")]
	public static void IGKJAMJLKAI(this PFFIILDLBFJ GLCCGOBFPBA, uint DOLICEBFIPF, uint NIJJMMEOIDJ, uint HBJHLIEIPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E03C30", Offset = "0x5E02430", VA = "0x185E03C30")]
	public static void MMPJKMJGKBK(this PFFIILDLBFJ GLCCGOBFPBA, int DOLICEBFIPF, int NIJJMMEOIDJ, int HBJHLIEIPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03910", Offset = "0x5E02110", VA = "0x185E03910")]
	public static void GPKHOIBFCIP(this PFFIILDLBFJ GLCCGOBFPBA, int DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E03B80", Offset = "0x5E02380", VA = "0x185E03B80")]
	public static void MKIABDKOKEG(this PFFIILDLBFJ GLCCGOBFPBA, long DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E03A60", Offset = "0x5E02260", VA = "0x185E03A60")]
	public static void KLFCEHCIDJG(this PFFIILDLBFJ GLCCGOBFPBA, uint DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E03CB0", Offset = "0x5E024B0", VA = "0x185E03CB0")]
	public static void NJHDDCIJLFJ(this PFFIILDLBFJ GLCCGOBFPBA, ulong DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E03800", Offset = "0x5E02000", VA = "0x185E03800")]
	public static void EAPHKJOPKKB(this PFFIILDLBFJ GLCCGOBFPBA, float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E03780", Offset = "0x5E01F80", VA = "0x185E03780")]
	public static void DIPGDFMBCBI(this PFFIILDLBFJ GLCCGOBFPBA, double DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E03520", Offset = "0x5E01D20", VA = "0x185E03520")]
	public static void AOBDAFGJNFL(this PFFIILDLBFJ GLCCGOBFPBA, [In] float3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E03480", Offset = "0x5E01C80", VA = "0x185E03480")]
	public static int ANOKLKKALKE(this PFFIILDLBFJ GLCCGOBFPBA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ADJKIDCLGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ADJKIDCLGDK()
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
