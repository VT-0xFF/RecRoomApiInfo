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
public struct PFHEKENPLCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct NLNBDCHCLPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int CJHAFNMKOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int FAPIDOKKPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int ALMNNGLDGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PDBNLEEENNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int DEPLAMIKBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int FNHIJOLFBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 PBKLLMHCKDD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84A9700", Offset = "0x84A8100", VA = "0x1884A9700")]
		public NLNBDCHCLPH(int FNOCLJOJOPH, int KIEBAHDGBCK, int FBJGDHOGOCB, int PADKAONACEG, int NPDLJPFAPFF, int CMLCMHJHHDN, float3 BJGHDDIMDNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct IOEDCNJGJGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int DHOCNKDECGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int DJNGDAHHEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float FAOKMDDLEGL;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE5D5A0", Offset = "0xE5BFA0", VA = "0x180E5D5A0")]
		public IOEDCNJGJGM(int BNAMGIMJGIC, int AJIBLHFEALL, float JHDCFCMBFOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LILPJEDLMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int DJNGDAHHEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int KFLEFOFGOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int PJHGELOJNGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, NLNBDCHCLPH> KIFICILOPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<IOEDCNJGJGM> ICOGHGPMPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> EFEMGCBHLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<LILPJEDLMDD> HEEHNALAGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> BMGFJKHCIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int KCKPCNEAFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int DGDCONDCBPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84A9B90", Offset = "0x84A8590", VA = "0x1884A9B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x84ABE60", Offset = "0x84AA860", VA = "0x1884ABE60")]
	public bool LBJOEFPLBBA([In] NativeArray<float3> FFLDBOMJFAE, NativeList<float3> KHNGGHMDDHP, NativeList<int> KOOPKPLDCDJ, Allocator EIOOMONCLID, CancellationToken AHOMALKMHKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84AB420", Offset = "0x84A9E20", VA = "0x1884AB420")]
	private void GFALNPPLGKO([In] NativeArray<float3> FFLDBOMJFAE, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84A9CD0", Offset = "0x84A86D0", VA = "0x1884A9CD0")]
	private void FEMDCEMOJOL([In] NativeArray<float3> FFLDBOMJFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84AC670", Offset = "0x84AB070", VA = "0x1884AC670")]
	private void NFFMBPENKDP([In] NativeArray<float3> FFLDBOMJFAE, [Out] int GIHEGIDBDIL, [Out] int LCFOPAEKIKA, [Out] int DKEHLMLILOC, [Out] int JNLPNEMFOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84ABFA0", Offset = "0x84AA9A0", VA = "0x1884ABFA0")]
	private void MAHBBDIODJJ([In] NativeArray<float3> FFLDBOMJFAE, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84AB920", Offset = "0x84AA320", VA = "0x1884AB920")]
	private void IIKFBEEHEIE([In] NativeArray<float3> FFLDBOMJFAE, float3 DPIEBKDJHFN, int CBAJJMLGNDK, NLNBDCHCLPH CFPLMCAEDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84A9740", Offset = "0x84A8140", VA = "0x1884A9740")]
	private void AEKDGNBCKOF([In] NativeArray<float3> FFLDBOMJFAE, float3 DPIEBKDJHFN, int EHDMFBDBLKE, int DGDCONDCBPP, NLNBDCHCLPH CFPLMCAEDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84AACF0", Offset = "0x84A96F0", VA = "0x1884AACF0")]
	private void FEMPJAAFLFH([In] NativeArray<float3> FFLDBOMJFAE, int LEBHAEDMIFP, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84ACC70", Offset = "0x84AB670", VA = "0x1884ACC70")]
	private void PNEFNFMILPN([In] NativeArray<float3> FFLDBOMJFAE, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84AC1A0", Offset = "0x84AABA0", VA = "0x1884AC1A0")]
	private void MEPKGKLMCHD([In] NativeArray<float3> FFLDBOMJFAE, NativeList<float3> KHNGGHMDDHP, NativeList<int> KOOPKPLDCDJ, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84A9B30", Offset = "0x84A8530", VA = "0x1884A9B30")]
	private float BNDHGIEIDIB(float3 DPIEBKDJHFN, float3 PINJILHDOJE, NLNBDCHCLPH CFPLMCAEDMH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84ACB60", Offset = "0x84AB560", VA = "0x1884ACB60")]
	private float3 PBKLLMHCKDD(float3 FNOCLJOJOPH, float3 KIEBAHDGBCK, float3 FBJGDHOGOCB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84ACB30", Offset = "0x84AB530", VA = "0x1884ACB30")]
	private static float OJKAHDGJADN(float3 EICJFDNFOCB, float3 MIBIEOGGIAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84ABE00", Offset = "0x84AA800", VA = "0x1884ABE00")]
	private static float3 KLIIJOFBFJH(float3 EICJFDNFOCB, float3 MIBIEOGGIAP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84AB3C0", Offset = "0x84A9DC0", VA = "0x1884AB3C0")]
	private bool GDDGDMCEBJP(float3 EICJFDNFOCB, float3 MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84AB2F0", Offset = "0x84A9CF0", VA = "0x1884AB2F0")]
	private bool FJCPHNCPNJD(float3 EICJFDNFOCB, float3 MIBIEOGGIAP, float3 DMCCCPMAFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84AB600", Offset = "0x84AA000", VA = "0x1884AB600")]
	private bool HACFDCDLJLB(float3 EICJFDNFOCB, float3 MIBIEOGGIAP, float3 DMCCCPMAFCP, float3 JHDCFCMBFOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LPFIIENAPDL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct ALPIFCHALAF
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
	private NativeList<float3> OPBDAPLIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> JCLKFHPHCBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F70", Offset = "0x84A7970", VA = "0x1884A8F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EANIOFGDILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84A8FB0", Offset = "0x84A79B0", VA = "0x1884A8FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PNGIKAIMAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84A8A90", Offset = "0x84A7490", VA = "0x1884A8A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GNNOIOLCMKD PNINJGBIFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84A8EF0", Offset = "0x84A78F0", VA = "0x1884A8EF0")]
		get
		{
			return default(GNNOIOLCMKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84A9610", Offset = "0x84A8010", VA = "0x1884A9610")]
	public LPFIIENAPDL(int FIFGJMDPIIE, int DCDHCGLFMIN, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84A96D0", Offset = "0x84A80D0", VA = "0x1884A96D0")]
	public LPFIIENAPDL(GNNOIOLCMKD AFNKPGHGKGF, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84A9140", Offset = "0x84A7B40", VA = "0x1884A9140")]
	public LPFIIENAPDL(Mesh KGGOMLADPBD, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84A92B0", Offset = "0x84A7CB0", VA = "0x1884A92B0")]
	public LPFIIENAPDL(LPFIIENAPDL BLPDDGCLNPE, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84A8A00", Offset = "0x84A7400", VA = "0x1884A8A00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84A8B70", Offset = "0x84A7570", VA = "0x1884A8B70")]
	public void HMDNMGBNKIA([In] LPFIIENAPDL PBOCDEMNFLD, float4x4 GHDIHCHPDGJ, Transform HODJCPBCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84A8FF0", Offset = "0x84A79F0", VA = "0x1884A8FF0")]
	public void OFFPBNFPDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84A8510", Offset = "0x84A6F10", VA = "0x1884A8510")]
	public void DGDHJAMFPCN(float EFLCGLGNONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84A82E0", Offset = "0x84A6CE0", VA = "0x1884A82E0")]
	public LPFIIENAPDL DBKMKHKMCHN(Allocator EIOOMONCLID, CancellationToken AHOMALKMHKK)
	{
		return default(LPFIIENAPDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84A81C0", Offset = "0x84A6BC0", VA = "0x1884A81C0")]
	public Mesh CGBJLGFAJJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84A8AD0", Offset = "0x84A74D0", VA = "0x1884A8AD0")]
	private unsafe static float3* GPFKFGILNAN(NativeArray<float3> BHEONMJLANC)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84A8B20", Offset = "0x84A7520", VA = "0x1884A8B20")]
	private unsafe static int* GPFKFGILNAN(NativeArray<int> BHEONMJLANC)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84A84E0", Offset = "0x84A6EE0", VA = "0x1884A84E0")]
	[CompilerGenerated]
	internal static void DEDMGAOJBLH(int KOANAGDFOOK, int KPFDPLBPEPB, ALPIFCHALAF P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GNNOIOLCMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int BHPFPDOJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int EANIOFGDILK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DNIGNHLKDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84A8110", Offset = "0x84A6B10", VA = "0x1884A8110")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29EE410", Offset = "0x29ECE10", VA = "0x1829EE410")]
	public static GNNOIOLCMKD LGPEJBKKIPP(GNNOIOLCMKD EICJFDNFOCB, GNNOIOLCMKD MIBIEOGGIAP)
	{
		return default(GNNOIOLCMKD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84A80A0", Offset = "0x84A6AA0", VA = "0x1884A80A0")]
	public static GNNOIOLCMKD GNJPMKJPHKO(GNNOIOLCMKD CNMGFEMFMLI, int AFDFHFKFCKE)
	{
		return default(GNNOIOLCMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84A8050", Offset = "0x84A6A50", VA = "0x1884A8050", Slot = "0")]
	public override bool Equals(object OPJMLMKDONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84A80C0", Offset = "0x84A6AC0", VA = "0x1884A80C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84A8120", Offset = "0x84A6B20", VA = "0x1884A8120", Slot = "3")]
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
