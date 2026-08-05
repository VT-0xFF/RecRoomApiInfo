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
public struct LEFMEJNCENO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct HNPALADOOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int AJJIHJLNEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int AIBANMFBBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int HKLHBCCIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int GLJENHAMCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int FNEHHFNMKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int FAEFJNNGJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 NIACMFOKBJO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60FAEA0", Offset = "0x60FA0A0", VA = "0x1860FAEA0")]
		public HNPALADOOBH(int PIKLDPADEMD, int EMMGLCEIELI, int MBKFKLKGBAG, int HCFMJFBBFNN, int AKDHFKJGJFN, int FNLIIBCIPJA, float3 KBHLNPNINOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct JIKNAFNNNIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int NKIMCEBDCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int EHOEMFAJAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float EOAHKAFNKGF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1033B00", Offset = "0x1032D00", VA = "0x181033B00")]
		public JIKNAFNNNIO(int HIFBGLLPLPJ, int LKBCFKGJILB, float PCLNGBGMCCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LMGAIKLDMJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int EHOEMFAJAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int CIMEEECKOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int IBPJMCNJBKJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, HNPALADOOBH> AEMEHGMLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<JIKNAFNNNIO> OMIEGGMAHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> GNEGNBOHIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<LMGAIKLDMJN> MGIFFIHOOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> LLAMMJICDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OAJAHBELILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int AOGNKIELPFF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60FBC10", Offset = "0x60FAE10", VA = "0x1860FBC10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60FBD50", Offset = "0x60FAF50", VA = "0x1860FBD50")]
	public bool EEHEIAOAAIM([In] NativeArray<float3> PNKJFDONBML, NativeList<float3> LMIGOBAHFCB, NativeList<int> BNKNLGCDENF, Allocator HOJMCOLANAB, CancellationToken IOOGCHJMBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60FE3E0", Offset = "0x60FD5E0", VA = "0x1860FE3E0")]
	private void MEJEOBIHPJE([In] NativeArray<float3> PNKJFDONBML, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60FC1D0", Offset = "0x60FB3D0", VA = "0x1860FC1D0")]
	private void IKIHDBGFFMB([In] NativeArray<float3> PNKJFDONBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60FAFB0", Offset = "0x60FA1B0", VA = "0x1860FAFB0")]
	private void APBPHODKCLE([In] NativeArray<float3> PNKJFDONBML, [Out] int NMFHCGKCPKI, [Out] int IABLJGIGCFI, [Out] int MAHMKPAHCME, [Out] int CDDJHAPIJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60FD640", Offset = "0x60FC840", VA = "0x1860FD640")]
	private void KGIFNPBAFIL([In] NativeArray<float3> PNKJFDONBML, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60FD1E0", Offset = "0x60FC3E0", VA = "0x1860FD1E0")]
	private void JLAGILKGJCL([In] NativeArray<float3> PNKJFDONBML, float3 EBFLKLNOENC, int BOEAIEFKNOA, HNPALADOOBH HNNNMBMNCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60FB470", Offset = "0x60FA670", VA = "0x1860FB470")]
	private void CHGANMIPKFA([In] NativeArray<float3> PNKJFDONBML, float3 EBFLKLNOENC, int OJBBDCKBDJO, int AOGNKIELPFF, HNPALADOOBH HNNNMBMNCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60FDD70", Offset = "0x60FCF70", VA = "0x1860FDD70")]
	private void MDAPCLGAPKL([In] NativeArray<float3> PNKJFDONBML, int PIOOLJDAMAH, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60FB840", Offset = "0x60FAA40", VA = "0x1860FB840")]
	private void CJDJBEKCJEL([In] NativeArray<float3> PNKJFDONBML, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60FD8A0", Offset = "0x60FCAA0", VA = "0x1860FD8A0")]
	private void LOGBANDJIMA([In] NativeArray<float3> PNKJFDONBML, NativeList<float3> LMIGOBAHFCB, NativeList<int> BNKNLGCDENF, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60FD840", Offset = "0x60FCA40", VA = "0x1860FD840")]
	private float LLIIKBFPBKI(float3 EBFLKLNOENC, float3 JHPHCBEIJBJ, HNPALADOOBH HNNNMBMNCJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60FE5C0", Offset = "0x60FD7C0", VA = "0x1860FE5C0")]
	private float3 NIACMFOKBJO(float3 PIKLDPADEMD, float3 EMMGLCEIELI, float3 MBKFKLKGBAG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60FE6D0", Offset = "0x60FD8D0", VA = "0x1860FE6D0")]
	private static float PMIBFGNKCHD(float3 LLLCBODKBAN, float3 HIOEJKGFIKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60FBBB0", Offset = "0x60FADB0", VA = "0x1860FBBB0")]
	private static float3 DMEHLOOLAKC(float3 LLLCBODKBAN, float3 HIOEJKGFIKI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60FBE90", Offset = "0x60FB090", VA = "0x1860FBE90")]
	private bool FPOAFAPHLAC(float3 LLLCBODKBAN, float3 HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60FAEE0", Offset = "0x60FA0E0", VA = "0x1860FAEE0")]
	private bool AJELBKHAPLG(float3 LLLCBODKBAN, float3 HIOEJKGFIKI, float3 PHDOOEGGBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60FBEF0", Offset = "0x60FB0F0", VA = "0x1860FBEF0")]
	private bool ICJEBMLBGCL(float3 LLLCBODKBAN, float3 HIOEJKGFIKI, float3 PHDOOEGGBGI, float3 PCLNGBGMCCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OMDJEHLECEN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AJIKJBIPHAA
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
	private NativeList<float3> POKCPHLOGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> EJCPEPCKONM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60FEFC0", Offset = "0x60FE1C0", VA = "0x1860FEFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CBALPFENPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60FF4F0", Offset = "0x60FE6F0", VA = "0x1860FF4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AKDOKGLOPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60FEF80", Offset = "0x60FE180", VA = "0x1860FEF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GDKLLCPBIAL BGIFIEDPFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60FE900", Offset = "0x60FDB00", VA = "0x1860FE900")]
		get
		{
			return default(GDKLLCPBIAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60FFB70", Offset = "0x60FED70", VA = "0x1860FFB70")]
	public OMDJEHLECEN(int INONAEKBBIE, int AFGBMDOGPBF, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60FF9D0", Offset = "0x60FEBD0", VA = "0x1860FF9D0")]
	public OMDJEHLECEN(GDKLLCPBIAL FNLBHFJFBFL, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60FFA00", Offset = "0x60FEC00", VA = "0x1860FFA00")]
	public OMDJEHLECEN(Mesh PLFOEDLJILP, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60FF680", Offset = "0x60FE880", VA = "0x1860FF680")]
	public OMDJEHLECEN(OMDJEHLECEN MJGHOBDIDHD, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60FE980", Offset = "0x60FDB80", VA = "0x1860FE980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60FEAB0", Offset = "0x60FDCB0", VA = "0x1860FEAB0")]
	public void GHBEENLPKLN([In] OMDJEHLECEN HEEIDJMADFG, float4x4 MFMCJLFMNOP, Transform NLGNBPIPJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60FEE30", Offset = "0x60FE030", VA = "0x1860FEE30")]
	public void INAJPDBDJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60FF000", Offset = "0x60FE200", VA = "0x1860FF000")]
	public void MGMNMKMFDEH(float NHMHEGFGMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60FE700", Offset = "0x60FD900", VA = "0x1860FE700")]
	public OMDJEHLECEN CLFAEEFOKNL(Allocator HOJMCOLANAB, CancellationToken IOOGCHJMBIE)
	{
		return default(OMDJEHLECEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60FF560", Offset = "0x60FE760", VA = "0x1860FF560")]
	public Mesh OCCMBBDNIJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60FEA60", Offset = "0x60FDC60", VA = "0x1860FEA60")]
	private unsafe static float3* EJMKGGCOPOM(NativeArray<float3> BLGDAGLONDD)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60FEA10", Offset = "0x60FDC10", VA = "0x1860FEA10")]
	private unsafe static int* EJMKGGCOPOM(NativeArray<int> BLGDAGLONDD)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60FF530", Offset = "0x60FE730", VA = "0x1860FF530")]
	[CompilerGenerated]
	internal static void NOAAKPLGNHP(int PBGPEEEODIJ, int GFNEJJNJDKF, AJIKJBIPHAA P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GDKLLCPBIAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int OLOLPMMJCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int CBALPFENPIC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HIIIHFKHGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60FADF0", Offset = "0x60F9FF0", VA = "0x1860FADF0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CC90", Offset = "0x1D1BE90", VA = "0x181D1CC90")]
	public static GDKLLCPBIAL OLHFJEIKJLB(GDKLLCPBIAL LLLCBODKBAN, GDKLLCPBIAL HIOEJKGFIKI)
	{
		return default(GDKLLCPBIAL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60FADD0", Offset = "0x60F9FD0", VA = "0x1860FADD0")]
	public static GDKLLCPBIAL HINPPMNPAMJ(GDKLLCPBIAL JDEBKHJKFON, int OMICJFCLNPB)
	{
		return default(GDKLLCPBIAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60FAD30", Offset = "0x60F9F30", VA = "0x1860FAD30", Slot = "0")]
	public override bool Equals(object CPKHGFABFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60FAD80", Offset = "0x60F9F80", VA = "0x1860FAD80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60FAE00", Offset = "0x60FA000", VA = "0x1860FAE00", Slot = "3")]
	public override string ToString()
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
