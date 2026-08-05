using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct MAFJKJCKFCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct BJEMJNMGGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int HIFKJJBOHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int HNBGPBGAOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int MGOPICGBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int FIJHMOIMBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int CAMEBIIKOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int PNKJNCCMCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 FGFIHHMIMHK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2E30", Offset = "0x6AC1C30", VA = "0x186AC2E30")]
		public BJEMJNMGGMG(int KLLEPCOIJON, int BONGLAFLNCF, int NKMAFPFOFFL, int EBLHKACMDOI, int GGEFCAJMMDF, int AKFGDDFAANJ, float3 DLBJKHMIPFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct FBDLHGCMEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int MJFFCAIHJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int DPBCMCLELOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float FKGCFMEFGMB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x21074A0", Offset = "0x21062A0", VA = "0x1821074A0")]
		public FBDLHGCMEDO(int NDFOGNBCBPD, int EKLPJLEIPME, float EIBINODMDGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct KCNPPHINDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int DPBCMCLELOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int OJPHGFPKCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int BPBMCPHBOME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, BJEMJNMGGMG> AIMEEDGKFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<FBDLHGCMEDO> HOKKIKMBEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> DNHJJBDGIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<KCNPPHINDAC> DOJIOPKGOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> MHEIEEJIDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int NCABLCAHJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int CFMCDLONFGF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6AC53C0", Offset = "0x6AC41C0", VA = "0x186AC53C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4620", Offset = "0x6AC3420", VA = "0x186AC4620")]
	public bool ACJCNKCDONL(in NativeArray<float3> JPHIIPEMKFB, ref NativeList<float3> FMBFEJIJPJM, ref NativeList<int> MBDEKLPMDOP, Allocator MBJMPHBLMBF, CancellationToken NBLKBHANAPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AC79D0", Offset = "0x6AC67D0", VA = "0x186AC79D0")]
	private void PGIHAENGDGO(in NativeArray<float3> JPHIIPEMKFB, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6590", Offset = "0x6AC5390", VA = "0x186AC6590")]
	private void LHHNLAGIMLD(in NativeArray<float3> JPHIIPEMKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5DF0", Offset = "0x6AC4BF0", VA = "0x186AC5DF0")]
	private void IONMPABNDJL(in NativeArray<float3> JPHIIPEMKFB, out int KENKABEJFCD, out int AICPDCNFMEA, out int GBGOCDKMFMI, out int IPALKILBGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5580", Offset = "0x6AC4380", VA = "0x186AC5580")]
	private void FFCENBJAPPL(in NativeArray<float3> JPHIIPEMKFB, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4E70", Offset = "0x6AC3C70", VA = "0x186AC4E70")]
	private void CLOJNMMIMHN(in NativeArray<float3> JPHIIPEMKFB, float3 LOFCJGHDJHE, int DFMIDICHJAD, BJEMJNMGGMG EGHGHLIODFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4A80", Offset = "0x6AC3880", VA = "0x186AC4A80")]
	private void CEIJAKBNEDB(in NativeArray<float3> JPHIIPEMKFB, float3 LOFCJGHDJHE, int OLDCNDAJLFD, int CFMCDLONFGF, BJEMJNMGGMG EGHGHLIODFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5770", Offset = "0x6AC4570", VA = "0x186AC5770")]
	private void HFLBFAFDLKH(in NativeArray<float3> JPHIIPEMKFB, int ALGJEJFAMJG, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4700", Offset = "0x6AC3500", VA = "0x186AC4700")]
	private void AMEKGIIBPNI(in NativeArray<float3> JPHIIPEMKFB, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC61A0", Offset = "0x6AC4FA0", VA = "0x186AC61A0")]
	private void JDFCBMCJMNB(in NativeArray<float3> JPHIIPEMKFB, ref NativeList<float3> FMBFEJIJPJM, ref NativeList<int> MBDEKLPMDOP, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5500", Offset = "0x6AC4300", VA = "0x186AC5500")]
	private float EFGHFKLHJOB(float3 LOFCJGHDJHE, float3 NADEBCLMPJN, BJEMJNMGGMG EGHGHLIODFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2870", Offset = "0x6AC1670", VA = "0x186AC2870")]
	private float3 FGFIHHMIMHK(float3 KLLEPCOIJON, float3 BONGLAFLNCF, float3 NKMAFPFOFFL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x602D270", Offset = "0x602C070", VA = "0x18602D270")]
	private static float HCBCKPIPHMM(float3 GCKGDDMIIDO, float3 EJKHFJILHAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5CF0", Offset = "0x6AC4AF0", VA = "0x186AC5CF0")]
	private static float3 IFBPHMDMGCB(float3 GCKGDDMIIDO, float3 EJKHFJILHAC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5D70", Offset = "0x6AC4B70", VA = "0x186AC5D70")]
	private bool IKHBHPBDDNH(float3 GCKGDDMIIDO, float3 EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2D20", Offset = "0x6AC1B20", VA = "0x186AC2D20")]
	private bool OJOILHNDIOI(float3 GCKGDDMIIDO, float3 EJKHFJILHAC, float3 ICHEJPHGAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7690", Offset = "0x6AC6490", VA = "0x186AC7690")]
	private bool MMEKNGCBPFA(float3 GCKGDDMIIDO, float3 EJKHFJILHAC, float3 ICHEJPHGAEP, float3 EIBINODMDGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KPGEOIGFKJN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DJJGLHAELCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> BMBHLINANCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> GLJMDKAAEGB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MMHEDDDNGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3CF0", Offset = "0x6AC2AF0", VA = "0x186AC3CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IMJIKKEPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AC30E0", Offset = "0x6AC1EE0", VA = "0x186AC30E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3AD0", Offset = "0x6AC28D0", VA = "0x186AC3AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IBGMMHCNJEJ PIDDMAOFIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3730", Offset = "0x6AC2530", VA = "0x186AC3730")]
		get
		{
			return default(IBGMMHCNJEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4570", Offset = "0x6AC3370", VA = "0x186AC4570")]
	public KPGEOIGFKJN(int KJPJGBKDCAN, int CNHEKJEIFEC, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4540", Offset = "0x6AC3340", VA = "0x186AC4540")]
	public KPGEOIGFKJN(IBGMMHCNJEJ MBKMDNDIIGF, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC43A0", Offset = "0x6AC31A0", VA = "0x186AC43A0")]
	public KPGEOIGFKJN(Mesh MGJAECMCOFA, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4140", Offset = "0x6AC2F40", VA = "0x186AC4140")]
	public KPGEOIGFKJN(KPGEOIGFKJN MMJOHADFCHO, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC31C0", Offset = "0x6AC1FC0", VA = "0x186AC31C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3D30", Offset = "0x6AC2B30", VA = "0x186AC3D30")]
	public void OEECIDDHIAM(in KPGEOIGFKJN NFJHHMHDKEL, float4x4 JOGJBGAPMFF, Transform BICKPKDCFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3B10", Offset = "0x6AC2910", VA = "0x186AC3B10")]
	public void NBLHNLINMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3250", Offset = "0x6AC2050", VA = "0x186AC3250")]
	public void EALFICDEFLG(float JOJDHMIFOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AC37E0", Offset = "0x6AC25E0", VA = "0x186AC37E0")]
	public KPGEOIGFKJN KMHECPNEOAG(Allocator MBJMPHBLMBF, CancellationToken NBLKBHANAPP)
	{
		return default(KPGEOIGFKJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2FC0", Offset = "0x6AC1DC0", VA = "0x186AC2FC0")]
	public Mesh BABDGFDJEKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3170", Offset = "0x6AC1F70", VA = "0x186AC3170")]
	private unsafe static float3* CFNAMKOHCEI(NativeArray<float3> PALKODKBAJM)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3120", Offset = "0x6AC1F20", VA = "0x186AC3120")]
	private unsafe static int* CFNAMKOHCEI(NativeArray<int> PALKODKBAJM)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AC37B0", Offset = "0x6AC25B0", VA = "0x186AC37B0")]
	[CompilerGenerated]
	internal static void HJPBIKOAHGP(int LMEGNBHFPNO, int NGGCGLPNFMN, ref DJJGLHAELCH P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IBGMMHCNJEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int MMHEDDDNGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int IMJIKKEPNBH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ADIMCHFHADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2F10", Offset = "0x6AC1D10", VA = "0x186AC2F10")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BAA0", Offset = "0x5E1A8A0", VA = "0x185E1BAA0")]
	public static IBGMMHCNJEJ LDHDNDGLKBP(IBGMMHCNJEJ GCKGDDMIIDO, IBGMMHCNJEJ EJKHFJILHAC)
	{
		return default(IBGMMHCNJEJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2EF0", Offset = "0x6AC1CF0", VA = "0x186AC2EF0")]
	public static IBGMMHCNJEJ NCOLIKOIALE(IBGMMHCNJEJ MIFHCKPPNKL, int BFJFBGNMECP)
	{
		return default(IBGMMHCNJEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2E70", Offset = "0x6AC1C70", VA = "0x186AC2E70", Slot = "0")]
	public override bool Equals(object FDKLJLLHMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2EB0", Offset = "0x6AC1CB0", VA = "0x186AC2EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2F20", Offset = "0x6AC1D20", VA = "0x186AC2F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GEKDDANOAJH
{
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
