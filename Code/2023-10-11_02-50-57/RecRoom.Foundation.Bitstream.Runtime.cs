using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MGELDCPHNEL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JKCINGAAMFK<T>(HOFPAEMDILJ LCMOFCIALJC, T GNLEHBFFNFG) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T OGFJDDPEKCB<T>(KEBCPOHPOJM POOKDLGIHHA) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class APCPCHJLOCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct KEBCPOHPOJM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate KEBCPOHPOJM BOAIPFAMNCJ(KEBCPOHPOJM DLAHENGMLBI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly BOAIPFAMNCJ FJJMOLGGGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int ALDIBIGGFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int FFBLNEDEMIE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEC70", Offset = "0x5CCDA70", VA = "0x185CCEC70")]
	public KEBCPOHPOJM(ReadOnlySpan<byte> PFDMLBFKIAP, int ALDIBIGGFGN = 0, int FFBLNEDEMIE = 0, [Optional] BOAIPFAMNCJ FJJMOLGGGEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DLPBKOIHLIK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x21FA120", Offset = "0x21F8F20", VA = "0x1821FA120")]
	public static T FHIAKNHJLHO<T>(this KEBCPOHPOJM POOKDLGIHHA) where T : struct, MGELDCPHNEL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC340", Offset = "0x5CCB140", VA = "0x185CCC340")]
	public static bool GBLFHDLCPIP(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC230", Offset = "0x5CCB030", VA = "0x185CCC230")]
	public static byte EMJADNLPCKD(this KEBCPOHPOJM DLAHENGMLBI, byte PHFJDMPFCAP, byte KMJHDBPNDLC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC400", Offset = "0x5CCB200", VA = "0x185CCC400")]
	public static sbyte IEJFEPNMPFD(this KEBCPOHPOJM DLAHENGMLBI, sbyte PHFJDMPFCAP, sbyte KMJHDBPNDLC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC110", Offset = "0x5CCAF10", VA = "0x185CCC110")]
	public static ushort DHNFDMDNGGE(this KEBCPOHPOJM DLAHENGMLBI, ushort PHFJDMPFCAP, ushort KMJHDBPNDLC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC5E0", Offset = "0x5CCB3E0", VA = "0x185CCC5E0")]
	public static short NFEIAMHDEPH(this KEBCPOHPOJM DLAHENGMLBI, short PHFJDMPFCAP, short KMJHDBPNDLC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC2D0", Offset = "0x5CCB0D0", VA = "0x185CCC2D0")]
	public static uint FELOKBGAGOH(this KEBCPOHPOJM DLAHENGMLBI, uint PHFJDMPFCAP, uint KMJHDBPNDLC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC680", Offset = "0x5CCB480", VA = "0x185CCC680")]
	public static int PMEGHJLLIOI(this KEBCPOHPOJM DLAHENGMLBI, int PHFJDMPFCAP, int KMJHDBPNDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC4A0", Offset = "0x5CCB2A0", VA = "0x185CCC4A0")]
	public static int JKLJHFPMLCM(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC080", Offset = "0x5CCAE80", VA = "0x185CCC080")]
	public static long CMOABEEIHNN(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC560", Offset = "0x5CCB360", VA = "0x185CCC560")]
	public static uint KHCDINNDFMP(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBF60", Offset = "0x5CCAD60", VA = "0x185CCBF60")]
	public static ulong ACDIGCNGIJN(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC1B0", Offset = "0x5CCAFB0", VA = "0x185CCC1B0")]
	public static float DKNAGGLPMJL(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBFB0", Offset = "0x5CCADB0", VA = "0x185CCBFB0")]
	public static double CAABEKPFLCD(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC1C0", Offset = "0x5CCAFC0", VA = "0x185CCC1C0")]
	public static float3 EHHFHIDJEEM(this KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AFGFILBIICB
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FGPIEEBGOGG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC6F0", Offset = "0x5CCB4F0", VA = "0x185CCC6F0")]
	public static void CCBINJDHJJP(this HOFPAEMDILJ LCMOFCIALJC, uint LBCJHLPCPBA, bool EILGHDCHHCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC890", Offset = "0x5CCB690", VA = "0x185CCC890")]
	public static uint ELFKFGMLHDN(this KEBCPOHPOJM POOKDLGIHHA, bool EILGHDCHHCK = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KOPDCHFDHGK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct CHCPBPIHCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint KFPDFFONHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint LMAOFPGAIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double CNFFHBLAIFO;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBFB0", Offset = "0x5CCADB0", VA = "0x185CCBFB0")]
	public static double CAABEKPFLCD(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEC90", Offset = "0x5CCDA90", VA = "0x185CCEC90")]
	public static void LOIJELAFEPK(double GNLEHBFFNFG, HOFPAEMDILJ DLAHENGMLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JBCPCLMABBL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HHHKPPAGLKP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public HHHKPPAGLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x357BF10", Offset = "0x357AD10", VA = "0x18357BF10")]
		internal void OHNPDGOGNCM(HOFPAEMDILJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x357BEE0", Offset = "0x357ACE0", VA = "0x18357BEE0")]
		internal T NAHELPILHEK(KEBCPOHPOJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OFMCGFKFPIB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OFMCGFKFPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D16850", Offset = "0x3D15650", VA = "0x183D16850")]
		internal void CAACNJHPNNL(HOFPAEMDILJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D16880", Offset = "0x3D15680", VA = "0x183D16880")]
		internal T GFCNNKPOJPB(KEBCPOHPOJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LOCONKCHFGF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LOCONKCHFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3960950", Offset = "0x395F750", VA = "0x183960950")]
		internal void EMGNBGBMEEA(HOFPAEMDILJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3960920", Offset = "0x395F720", VA = "0x183960920")]
		internal T BDJJKBIKOHO(KEBCPOHPOJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class AKKOOIIANLA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public AKKOOIIANLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3517B00", Offset = "0x3516900", VA = "0x183517B00")]
		internal void LMNCGKNNGOG(HOFPAEMDILJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3517AD0", Offset = "0x35168D0", VA = "0x183517AD0")]
		internal T AOAPADLOFGG(KEBCPOHPOJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BILLLPAHINP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BILLLPAHINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4442AA0", Offset = "0x44418A0", VA = "0x184442AA0")]
		internal void AKJEHPMHEJN(HOFPAEMDILJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4442AD0", Offset = "0x44418D0", VA = "0x184442AD0")]
		internal T AONMJOMLIGC(KEBCPOHPOJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LOHLJONEBHI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LOHLJONEBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3960AE0", Offset = "0x395F8E0", VA = "0x183960AE0")]
		internal void NNCJODHEEFH(HOFPAEMDILJ b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3960AC0", Offset = "0x395F8C0", VA = "0x183960AC0")]
		internal T ENMALFFDCPD(KEBCPOHPOJM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23BC4F0", Offset = "0x23BB2F0", VA = "0x1823BC4F0")]
	public static void MLOOAGHCMJP<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x23BC290", Offset = "0x23BB090", VA = "0x1823BC290")]
	private static void JBDOLINJDNO<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x23BC290", Offset = "0x23BB090", VA = "0x1823BC290")]
	private static void CEAJGMLJIGA<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23BC160", Offset = "0x23BAF60", VA = "0x1823BC160")]
	private static void BMJJKHHICEM<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23BC160", Offset = "0x23BAF60", VA = "0x1823BC160")]
	private static void CNGDDAGGPHM<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23BC3C0", Offset = "0x23BB1C0", VA = "0x1823BC3C0")]
	private static void KHFKKIKMHEN<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23BC3C0", Offset = "0x23BB1C0", VA = "0x1823BC3C0")]
	private static void JKFEKALBIMI<T>(T GBOBLEMPFME, T COGFLCBHIIG, [Out] JKCINGAAMFK<T> CIFMEBJAHIP, [Out] OGFJDDPEKCB<T> HIKPMMIMEPJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MNENFFEOKHE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct HCDOCLKNNGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public uint HLKKLIEDKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float BCHFKAAJDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CCED10", Offset = "0x5CCDB10", VA = "0x185CCED10")]
	public static float DKNAGGLPMJL(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEDA0", Offset = "0x5CCDBA0", VA = "0x185CCEDA0")]
	public static void LAALMKNAMME(float GNLEHBFFNFG, HOFPAEMDILJ DLAHENGMLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OMPEDFLAEPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GACJHGIJOLG
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly int[] GOFKAHKMOCP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE750", Offset = "0x5CCD550", VA = "0x185CCE750")]
	public static int MOKDGKCBJCK(uint EGAGMPJAPPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE6E0", Offset = "0x5CCD4E0", VA = "0x185CCE6E0")]
	public static uint MIHLLBICMPA(int PPCAPPENFHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDAC0", Offset = "0x5CCC8C0", VA = "0x185CCDAC0")]
	private static uint DECLFBCBKLG(int PPCAPPENFHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDB40", Offset = "0x5CCC940", VA = "0x185CCDB40")]
	public static int DHOLKCPMEIH(int GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDD00", Offset = "0x5CCCB00", VA = "0x185CCDD00")]
	public static bool GBLFHDLCPIP(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDBE0", Offset = "0x5CCC9E0", VA = "0x185CCDBE0")]
	public static byte EMJADNLPCKD(byte PHFJDMPFCAP, byte KMJHDBPNDLC, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE0F0", Offset = "0x5CCCEF0", VA = "0x185CCE0F0")]
	public static sbyte IEJFEPNMPFD(sbyte PHFJDMPFCAP, sbyte KMJHDBPNDLC, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDAD0", Offset = "0x5CCC8D0", VA = "0x185CCDAD0")]
	public static ushort DHNFDMDNGGE(ushort PHFJDMPFCAP, ushort KMJHDBPNDLC, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE800", Offset = "0x5CCD600", VA = "0x185CCE800")]
	public static short NFEIAMHDEPH(short PHFJDMPFCAP, short KMJHDBPNDLC, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE160", Offset = "0x5CCCF60", VA = "0x185CCE160")]
	public static int JKLJHFPMLCM(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD970", Offset = "0x5CCC770", VA = "0x185CCD970")]
	public static long CMOABEEIHNN(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE460", Offset = "0x5CCD260", VA = "0x185CCE460")]
	public static uint KHCDINNDFMP(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD380", Offset = "0x5CCC180", VA = "0x185CCD380")]
	public static ulong ACDIGCNGIJN(KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDC50", Offset = "0x5CCCA50", VA = "0x185CCDC50")]
	public static uint FELOKBGAGOH(uint PHFJDMPFCAP, uint KMJHDBPNDLC, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEA50", Offset = "0x5CCD850", VA = "0x185CCEA50")]
	public static int PMEGHJLLIOI(int PHFJDMPFCAP, int KMJHDBPNDLC, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDD90", Offset = "0x5CCCB90", VA = "0x185CCDD90")]
	public static uint GGKNJJPKLCC(int PPCAPPENFHK, KEBCPOHPOJM DLAHENGMLBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE270", Offset = "0x5CCD070", VA = "0x185CCE270")]
	public static uint KFPALAAFJOK(int ILKHNNBENCC, KEBCPOHPOJM GMNCNEPJHHN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD9D0", Offset = "0x5CCC7D0", VA = "0x185CCD9D0")]
	private static void DCOGLHCDGLI(KEBCPOHPOJM DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDDF0", Offset = "0x5CCCBF0", VA = "0x185CCDDF0")]
	public static void GLDFODEFAKN(bool GNLEHBFFNFG, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDB60", Offset = "0x5CCC960", VA = "0x185CCDB60")]
	public static void DPKEDJEPFIH(byte GNLEHBFFNFG, byte PHFJDMPFCAP, byte KMJHDBPNDLC, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD470", Offset = "0x5CCC270", VA = "0x185CCD470")]
	public static void AHDDBIILIOJ(sbyte GNLEHBFFNFG, sbyte PHFJDMPFCAP, sbyte KMJHDBPNDLC, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD4F0", Offset = "0x5CCC2F0", VA = "0x185CCD4F0")]
	public static void AHHHBJGPPCH(ushort GNLEHBFFNFG, ushort PHFJDMPFCAP, ushort KMJHDBPNDLC, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE910", Offset = "0x5CCD710", VA = "0x185CCE910")]
	public static void PCHCOILIFFB(short GNLEHBFFNFG, short PHFJDMPFCAP, short KMJHDBPNDLC, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE630", Offset = "0x5CCD430", VA = "0x185CCE630")]
	public static void MAKJLMNJNGM(uint GNLEHBFFNFG, uint PHFJDMPFCAP, uint KMJHDBPNDLC, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE990", Offset = "0x5CCD790", VA = "0x185CCE990")]
	public static void PIIAFNFMKPB(int GNLEHBFFNFG, int PHFJDMPFCAP, int KMJHDBPNDLC, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE510", Offset = "0x5CCD310", VA = "0x185CCE510")]
	public static void LBJEMEDPMFK(int GNLEHBFFNFG, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE5B0", Offset = "0x5CCD3B0", VA = "0x185CCE5B0")]
	public static void LNDOAPGICBA(long GNLEHBFFNFG, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE4B0", Offset = "0x5CCD2B0", VA = "0x185CCE4B0")]
	public static void KKGIBDIEJEF(uint GNLEHBFFNFG, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD660", Offset = "0x5CCC460", VA = "0x185CCD660")]
	public static void CINNKMCEFKP(ulong GNLEHBFFNFG, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDE50", Offset = "0x5CCCC50", VA = "0x185CCDE50")]
	public static void HLEPJCFCEGL(uint GNLEHBFFNFG, int PPCAPPENFHK, HOFPAEMDILJ GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD570", Offset = "0x5CCC370", VA = "0x185CCD570")]
	private static void BLFPLHKDGMJ(HOFPAEMDILJ DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE870", Offset = "0x5CCD670", VA = "0x185CCE870")]
	private static ulong OPEAGFDJCGH(ulong GNLEHBFFNFG, HOFPAEMDILJ DLAHENGMLBI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE1F0", Offset = "0x5CCCFF0", VA = "0x185CCE1F0")]
	public static int KCIILFIGDCJ(HOFPAEMDILJ DLAHENGMLBI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class NBCAOIJLHGI
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B610", Offset = "0x4E8A410", VA = "0x184E8B610")]
	public static int BIJEGBIPDJA(uint EJIPIDNGAFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B620", Offset = "0x4E8A420", VA = "0x184E8B620")]
	public static long OEPFMEILPII(ulong EJIPIDNGAFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E97500", Offset = "0x4E96300", VA = "0x184E97500")]
	public static uint LNFBLDBDHBN(int EJIPIDNGAFP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4E97510", Offset = "0x4E96310", VA = "0x184E97510")]
	public static ulong GDLJNEMCEIA(long EJIPIDNGAFP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IOAJDHECICD
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BDGBFDDLDBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] BKOBMCKFFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Stream MMGOENDACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int ALDIBIGGFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int FFBLNEDEMIE;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct HOFPAEMDILJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate HOFPAEMDILJ FBBAOKLMFFK(HOFPAEMDILJ DLAHENGMLBI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly Span<byte> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly FBBAOKLMFFK LCEGLFAMJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal int ALDIBIGGFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal int FFBLNEDEMIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> CGGCCNMIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEB90", Offset = "0x5CCD990", VA = "0x185CCEB90")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEC50", Offset = "0x5CCDA50", VA = "0x185CCEC50")]
	public HOFPAEMDILJ(Span<byte> PFDMLBFKIAP, int ALDIBIGGFGN = 0, int FFBLNEDEMIE = 0, [Optional] FBBAOKLMFFK LCEGLFAMJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FMIPBJCACMD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2343A10", Offset = "0x2342810", VA = "0x182343A10")]
	public static void PNMCNOGLFIO<T>(this HOFPAEMDILJ LCMOFCIALJC, T GNLEHBFFNFG) where T : struct, MGELDCPHNEL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCE50", Offset = "0x5CCBC50", VA = "0x185CCCE50")]
	public static void GLDFODEFAKN(this HOFPAEMDILJ DLAHENGMLBI, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCCA0", Offset = "0x5CCBAA0", VA = "0x185CCCCA0")]
	public static void DPKEDJEPFIH(this HOFPAEMDILJ DLAHENGMLBI, byte GNLEHBFFNFG, byte PHFJDMPFCAP, byte KMJHDBPNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCA40", Offset = "0x5CCB840", VA = "0x185CCCA40")]
	public static void AHDDBIILIOJ(this HOFPAEMDILJ DLAHENGMLBI, sbyte GNLEHBFFNFG, sbyte PHFJDMPFCAP, sbyte KMJHDBPNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCAF0", Offset = "0x5CCB8F0", VA = "0x185CCCAF0")]
	public static void AHHHBJGPPCH(this HOFPAEMDILJ DLAHENGMLBI, ushort GNLEHBFFNFG, ushort PHFJDMPFCAP, ushort KMJHDBPNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD250", Offset = "0x5CCC050", VA = "0x185CCD250")]
	public static void PCHCOILIFFB(this HOFPAEMDILJ DLAHENGMLBI, short GNLEHBFFNFG, short PHFJDMPFCAP, short KMJHDBPNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD1D0", Offset = "0x5CCBFD0", VA = "0x185CCD1D0")]
	public static void MAKJLMNJNGM(this HOFPAEMDILJ DLAHENGMLBI, uint GNLEHBFFNFG, uint PHFJDMPFCAP, uint KMJHDBPNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD300", Offset = "0x5CCC100", VA = "0x185CCD300")]
	public static void PIIAFNFMKPB(this HOFPAEMDILJ DLAHENGMLBI, int GNLEHBFFNFG, int PHFJDMPFCAP, int KMJHDBPNDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCFD0", Offset = "0x5CCBDD0", VA = "0x185CCCFD0")]
	public static void LBJEMEDPMFK(this HOFPAEMDILJ DLAHENGMLBI, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD0A0", Offset = "0x5CCBEA0", VA = "0x185CCD0A0")]
	public static void LNDOAPGICBA(this HOFPAEMDILJ DLAHENGMLBI, long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCEE0", Offset = "0x5CCBCE0", VA = "0x185CCCEE0")]
	public static void KKGIBDIEJEF(this HOFPAEMDILJ DLAHENGMLBI, uint GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCBA0", Offset = "0x5CCB9A0", VA = "0x185CCCBA0")]
	public static void CINNKMCEFKP(this HOFPAEMDILJ DLAHENGMLBI, ulong GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCF70", Offset = "0x5CCBD70", VA = "0x185CCCF70")]
	public static void LAALMKNAMME(this HOFPAEMDILJ DLAHENGMLBI, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD150", Offset = "0x5CCBF50", VA = "0x185CCD150")]
	public static void LOIJELAFEPK(this HOFPAEMDILJ DLAHENGMLBI, double GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCD50", Offset = "0x5CCBB50", VA = "0x185CCCD50")]
	public static void GEEPNKJGLCO(this HOFPAEMDILJ DLAHENGMLBI, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCC00", Offset = "0x5CCBA00", VA = "0x185CCCC00")]
	public static int DHHLOOJNKBI(this HOFPAEMDILJ DLAHENGMLBI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IKMPJPADFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKMPJPADFGH()
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
