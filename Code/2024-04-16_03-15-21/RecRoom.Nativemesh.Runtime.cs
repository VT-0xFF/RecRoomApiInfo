using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EJEFEPKENJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MLHECJPOJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 IDHOFGGKGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion DHCNLGDCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 NLPJGNHLKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int IEABADFPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int BGOBLBNPHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NLOEKDCAGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float NHJPGMFGAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 GMHNAFECOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool EIANAOBLEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GBGANMJNOPB JCOAOPBNOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 PCFGBFJCMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float JOOECEBOENH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NGABOLFNHJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static CAIAAPKPAMM FNNDMDMFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<EJEFEPKENJI> OLNEMNCBPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<OHDABLHBPGG> DJJGNLBCLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<GGAJHJJODKI> JAMLFGBPKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<CBKEPECMHFD> FHJDPBKBAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<OHDABLHBPGG> OBOPCAIMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<AOFIMGEEFPK> BKFKLLNCHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<CBKEPECMHFD>> MKBJBIMOAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<KDKAKNKHEHB> MOCEHMDCADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> AKAGINAEEKJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC63720", Offset = "0xC62920", VA = "0x180C63720")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC63090", Offset = "0xC62290", VA = "0x180C63090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CBALPFENPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC63730", Offset = "0xC62930", VA = "0x180C63730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC61EB0", Offset = "0xC610B0", VA = "0x180C61EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61A1CB0", Offset = "0x61A0EB0", VA = "0x1861A1CB0")]
	public NGABOLFNHJB(int IJGPBHEILGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61A0380", Offset = "0x619F580", VA = "0x1861A0380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61A03A0", Offset = "0x619F5A0", VA = "0x1861A03A0")]
	public void FMINDOPCMII(JobHandle IFPDAOGJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61A0160", Offset = "0x619F360", VA = "0x1861A0160")]
	public void CDJDIHGCFIP(EJEFEPKENJI MJGHOBDIDHD, KDKAKNKHEHB BJAAOJFDJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61A1B70", Offset = "0x61A0D70", VA = "0x1861A1B70")]
	public void OCEDHBDOAGM(GGAJHJJODKI MJGHOBDIDHD, NativeArray<CBKEPECMHFD> BHNFPBMKNFK, int INONAEKBBIE, int AFGBMDOGPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61A0570", Offset = "0x619F770", VA = "0x1861A0570")]
	public JobHandle GMPDEFBGEOE(FEEDCIOJNFD NCLHKCJNGOG, COOHIMBGANP AENCEGPBOMO, float3 DDBLCEKHOHN, quaternion IECJOBDGNFA, float MDDBNFACKFP, bool EIDELBICDON, int GPNDLMFKHNJ = 0, int NPEIHPGNOKA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61A1830", Offset = "0x61A0A30", VA = "0x1861A1830")]
	public static JobHandle MOJCEKIMGII(HGMBDHNLOFE BPLNOJOJPOF, FEEDCIOJNFD NCLHKCJNGOG, EJEFEPKENJI MJGHOBDIDHD, JobHandle IFPDAOGJICE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61A1580", Offset = "0x61A0780", VA = "0x1861A1580")]
	public static JobHandle KKNHOEHDLIC(JINFJHEEKBB BPLNOJOJPOF, FEEDCIOJNFD NCLHKCJNGOG, GGAJHJJODKI MJGHOBDIDHD, NativeArray<CBKEPECMHFD> BHNFPBMKNFK, int INONAEKBBIE, int AFGBMDOGPBF, JobHandle IFPDAOGJICE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class HEDKJDOOPAG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct PKBDMMLAGHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half FNPBHEKHHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort OEHKBFDCAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte OGFHGAIPFPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public unsafe delegate void DHPNNBFJAJN(float3* MPOHHIPKDGO, [In] ushort* NOKFLPCBMGM, int INONAEKBBIE, [In] float3 GEEDDDPKGAE, [In] float3 GFIFJMBMIFO);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class CCOBPPFNLNH
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x618E980", Offset = "0x618DB80", VA = "0x18618E980")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x618EAA0", Offset = "0x618DCA0", VA = "0x18618EAA0")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x618E8E0", Offset = "0x618DAE0", VA = "0x18618E8E0")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x618EBF0", Offset = "0x618DDF0", VA = "0x18618EBF0")]
		public unsafe static void LKEHCEHOLJP(float3* MPOHHIPKDGO, [In] ushort* NOKFLPCBMGM, int INONAEKBBIE, [In] float3 GEEDDDPKGAE, [In] float3 GFIFJMBMIFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void ENGIMIOGLOO(ushort* MPOHHIPKDGO, [Out] float3 ONKHDJLKJDH, [Out] float3 GFIFJMBMIFO, [In] float3* NOKFLPCBMGM, int AKDFCJMBNGO, int JAPDIMAHDHK);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class GEHBAMNKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6196010", Offset = "0x6195210", VA = "0x186196010")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6196130", Offset = "0x6195330", VA = "0x186196130")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6195F70", Offset = "0x6195170", VA = "0x186195F70")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6196280", Offset = "0x6195480", VA = "0x186196280")]
		public unsafe static void LKEHCEHOLJP(ushort* MPOHHIPKDGO, [Out] float3 ONKHDJLKJDH, [Out] float3 GFIFJMBMIFO, [In] float3* NOKFLPCBMGM, int AKDFCJMBNGO, int JAPDIMAHDHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public unsafe delegate void BEGJFMOJHNE(ushort* FCEHFJAGNGF, [In] float3* LCINJFKKHAC, int JAPDIMAHDHK);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class FCKKMBKKLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6193E00", Offset = "0x6193000", VA = "0x186193E00")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6193F20", Offset = "0x6193120", VA = "0x186193F20")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6193D60", Offset = "0x6192F60", VA = "0x186193D60")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6194070", Offset = "0x6193270", VA = "0x186194070")]
		public unsafe static void LKEHCEHOLJP(ushort* FCEHFJAGNGF, [In] float3* LCINJFKKHAC, int JAPDIMAHDHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public unsafe delegate void OHDPHDMJOLC(float3* BPOHCFBBECB, [In] ushort* LCINJFKKHAC, int INONAEKBBIE);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class BKCPLEMJDML
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x618D8C0", Offset = "0x618CAC0", VA = "0x18618D8C0")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x618D9E0", Offset = "0x618CBE0", VA = "0x18618D9E0")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x618D820", Offset = "0x618CA20", VA = "0x18618D820")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x618DB30", Offset = "0x618CD30", VA = "0x18618DB30")]
		public unsafe static void LKEHCEHOLJP(float3* BPOHCFBBECB, [In] ushort* LCINJFKKHAC, int INONAEKBBIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public unsafe delegate void IGNEIKHLAHG(ushort* BNOLNHJFJNB, [Out] float2 CLMDLEEBILI, [Out] float2 AMICNHPLMAJ, [In] float2* KGPOIHICALH, int AKDFCJMBNGO, int JAPDIMAHDHK);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class GPDJBFIGOOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x61976C0", Offset = "0x61968C0", VA = "0x1861976C0")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61977E0", Offset = "0x61969E0", VA = "0x1861977E0")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6197620", Offset = "0x6196820", VA = "0x186197620")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6197930", Offset = "0x6196B30", VA = "0x186197930")]
		public unsafe static void LKEHCEHOLJP(ushort* BNOLNHJFJNB, [Out] float2 CLMDLEEBILI, [Out] float2 AMICNHPLMAJ, [In] float2* KGPOIHICALH, int AKDFCJMBNGO, int JAPDIMAHDHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void OIJMDMEMPKL([Out] float2 ACGJBBIKDIG, ushort KMCMPCDFIMN, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class DNAPBOALOHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6191FE0", Offset = "0x61911E0", VA = "0x186191FE0")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6192100", Offset = "0x6191300", VA = "0x186192100")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6191F40", Offset = "0x6191140", VA = "0x186191F40")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6192250", Offset = "0x6191450", VA = "0x186192250")]
		public static void LKEHCEHOLJP([Out] float2 ACGJBBIKDIG, ushort KMCMPCDFIMN, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public unsafe delegate void KEHDNECELLM(float2* BNOLNHJFJNB, ushort* KGPOIHICALH, int INONAEKBBIE, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class OLAGKOMANIH
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61A2570", Offset = "0x61A1770", VA = "0x1861A2570")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61A2690", Offset = "0x61A1890", VA = "0x1861A2690")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61A24D0", Offset = "0x61A16D0", VA = "0x1861A24D0")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61A27E0", Offset = "0x61A19E0", VA = "0x1861A27E0")]
		public unsafe static void LKEHCEHOLJP(float2* BNOLNHJFJNB, ushort* KGPOIHICALH, int INONAEKBBIE, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public unsafe delegate void FFPLENEKGAN(ushort* JCLNFNGNCJE, [In] float4* NNENEKMCKIL, int AKDFCJMBNGO, int JAPDIMAHDHK);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class GGLBOENKNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6196630", Offset = "0x6195830", VA = "0x186196630")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6196750", Offset = "0x6195950", VA = "0x186196750")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6196590", Offset = "0x6195790", VA = "0x186196590")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61968A0", Offset = "0x6195AA0", VA = "0x1861968A0")]
		public unsafe static void LKEHCEHOLJP(ushort* JCLNFNGNCJE, [In] float4* NNENEKMCKIL, int AKDFCJMBNGO, int JAPDIMAHDHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate ushort AJCGJCGALCM([In] float4 PEEODOGNIEM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class OHKNDCPHOGE
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61A1F60", Offset = "0x61A1160", VA = "0x1861A1F60")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61A2080", Offset = "0x61A1280", VA = "0x1861A2080")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61A1EC0", Offset = "0x61A10C0", VA = "0x1861A1EC0")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61A21D0", Offset = "0x61A13D0", VA = "0x1861A21D0")]
		public static ushort LKEHCEHOLJP([In] float4 PEEODOGNIEM)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public unsafe delegate void DBDDKHBNBBN(float4* JCLNFNGNCJE, [In] ushort* KEMJKFPBMFB, int INONAEKBBIE);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class DHNFOIFFFAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x618F560", Offset = "0x618E760", VA = "0x18618F560")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x618F680", Offset = "0x618E880", VA = "0x18618F680")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x618F4C0", Offset = "0x618E6C0", VA = "0x18618F4C0")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x618F7D0", Offset = "0x618E9D0", VA = "0x18618F7D0")]
		public unsafe static void LKEHCEHOLJP(float4* JCLNFNGNCJE, [In] ushort* KEMJKFPBMFB, int INONAEKBBIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void PGIPKNKLEBN([Out] float4 IFJGEIAONPI, ushort KMCMPCDFIMN);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class FCKPLEDOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61942F0", Offset = "0x61934F0", VA = "0x1861942F0")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6194410", Offset = "0x6193610", VA = "0x186194410")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6194250", Offset = "0x6193450", VA = "0x186194250")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6194560", Offset = "0x6193760", VA = "0x186194560")]
		public static void LKEHCEHOLJP([Out] float4 IFJGEIAONPI, ushort KMCMPCDFIMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public unsafe delegate void GFMALCNPMDK(float4* CCPEOEIBOAH, byte* NOJDOOBKPKG, [Out] int MGBLFKEGCJC, [Out] int NCJGMCDGPGD, float4* DJCIIGMJMDM, int AKDFCJMBNGO, int JAPDIMAHDHK);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class KGEOGDLDMAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x619E2C0", Offset = "0x619D4C0", VA = "0x18619E2C0")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x619E3E0", Offset = "0x619D5E0", VA = "0x18619E3E0")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x619E220", Offset = "0x619D420", VA = "0x18619E220")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x619E530", Offset = "0x619D730", VA = "0x18619E530")]
		public unsafe static void LKEHCEHOLJP(float4* CCPEOEIBOAH, byte* NOJDOOBKPKG, [Out] int MGBLFKEGCJC, [Out] int NCJGMCDGPGD, float4* DJCIIGMJMDM, int AKDFCJMBNGO, int JAPDIMAHDHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public unsafe delegate void PPNPAAPDOFD(float4* AJFEEKJPHMD, [In] PKBDMMLAGHE* DHMHIDFJNBK, [In] byte* AADHMALPLND, int INONAEKBBIE);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class JOEILNGIBON
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x619D260", Offset = "0x619C460", VA = "0x18619D260")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x619D380", Offset = "0x619C580", VA = "0x18619D380")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x619D1C0", Offset = "0x619C3C0", VA = "0x18619D1C0")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x619D4D0", Offset = "0x619C6D0", VA = "0x18619D4D0")]
		public unsafe static void LKEHCEHOLJP(float4* AJFEEKJPHMD, [In] PKBDMMLAGHE* DHMHIDFJNBK, [In] byte* AADHMALPLND, int INONAEKBBIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public unsafe delegate int FJBGHMGLHOC(byte* KFBLLKKDPAP, [In] int* EHMCGHMHBMH, int NEMOBGEMIHD);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class AIEMKOPAFIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x618CE60", Offset = "0x618C060", VA = "0x18618CE60")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x618CF80", Offset = "0x618C180", VA = "0x18618CF80")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x618CDC0", Offset = "0x618BFC0", VA = "0x18618CDC0")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x618D0D0", Offset = "0x618C2D0", VA = "0x18618D0D0")]
		public unsafe static int LKEHCEHOLJP(byte* KFBLLKKDPAP, [In] int* EHMCGHMHBMH, int NEMOBGEMIHD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public unsafe delegate void OCPOGMOCAHB(int* GDHLAMJJGCH, [In] byte* JODGGALHEJB, int AFGBMDOGPBF);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class CCMGDIBNMPD
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x618E430", Offset = "0x618D630", VA = "0x18618E430")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x618E550", Offset = "0x618D750", VA = "0x18618E550")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x618E390", Offset = "0x618D590", VA = "0x18618E390")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x618E6A0", Offset = "0x618D8A0", VA = "0x18618E6A0")]
		public unsafe static void LKEHCEHOLJP(int* GDHLAMJJGCH, [In] byte* JODGGALHEJB, int AFGBMDOGPBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void JAGBAGEOKEA([Out] float3 ACGJBBIKDIG, ushort KMCMPCDFIMN);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class PEBGHGJOCMN
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61A2B00", Offset = "0x61A1D00", VA = "0x1861A2B00")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x61A2C20", Offset = "0x61A1E20", VA = "0x1861A2C20")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x61A2A60", Offset = "0x61A1C60", VA = "0x1861A2A60")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x61A2D70", Offset = "0x61A1F70", VA = "0x1861A2D70")]
		public static void LKEHCEHOLJP([Out] float3 ACGJBBIKDIG, ushort KMCMPCDFIMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate ushort CEGHOEGHENJ([In] float3 PEEODOGNIEM);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class AOPNLILGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr LFACDNDEMNO;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr GBDMMHPCGNP;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x618D3F0", Offset = "0x618C5F0", VA = "0x18618D3F0")]
		[BurstDiscard]
		private static void JOJKPBIMGKJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x618D510", Offset = "0x618C710", VA = "0x18618D510")]
		private static IntPtr KFJLOHKAFDB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x618D350", Offset = "0x618C550", VA = "0x18618D350")]
		public static void HFLABFMOLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public static void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x618D660", Offset = "0x618C860", VA = "0x18618D660")]
		public static ushort LKEHCEHOLJP([In] float3 PEEODOGNIEM)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int INONAEKBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int AFGBMDOGPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> DAGKFGFLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> NOBIMAGCFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> PINPIGPKCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> AOMMNBMEMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<PKBDMMLAGHE> NOMFPHPFOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> EPELDPFIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> BNKNLGCDENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 GEEDDDPKGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 GFIFJMBMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 LBDCFDDMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 AMICNHPLMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long FNAHGEDFPKH;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long GFPLKIOLIED;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float MKCOJMMJMGJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool IOJHBFLKNBE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLCBGHLOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x619A6E0", Offset = "0x61998E0", VA = "0x18619A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6199810", Offset = "0x6198A10", VA = "0x186199810")]
	public void FMINDOPCMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61992A0", Offset = "0x61984A0", VA = "0x1861992A0")]
	public static HEDKJDOOPAG DMOLILFLBFL(Allocator HOJMCOLANAB, FEEDCIOJNFD DJBPOLBPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6198DD0", Offset = "0x6197FD0", VA = "0x186198DD0")]
	public static HEDKJDOOPAG DMOLILFLBFL(Allocator HOJMCOLANAB, NativeArray<float3> NOKFLPCBMGM, NativeArray<float3> LCINJFKKHAC, NativeArray<float2> KGPOIHICALH, NativeArray<float4> DJCIIGMJMDM, bool NJODMPDLNCE, NativeArray<float4> KEMJKFPBMFB, NativeArray<int> EHMCGHMHBMH, int INONAEKBBIE, int LDDCJMMPADJ, int AFGBMDOGPBF, int AKDFCJMBNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6198270", Offset = "0x6197470", VA = "0x186198270")]
	public FEEDCIOJNFD BPFBCOFCNND(Allocator HOJMCOLANAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6199A20", Offset = "0x6198C20", VA = "0x186199A20")]
	public void GBHIMKKAKNM(Mesh PLFOEDLJILP, bool HECHKDCLKAD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6198050", Offset = "0x6197250", VA = "0x186198050")]
	public long BFBCPMJNIFA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x619AFC0", Offset = "0x619A1C0", VA = "0x18619AFC0")]
	public static long PJCECOMCIFE(int DFHCPHOPCKI, int KGJFBJADNBJ, bool LIJNOKIMLMJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x619B010", Offset = "0x619A210", VA = "0x18619B010")]
	public long PJCECOMCIFE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6199910", Offset = "0x6198B10", VA = "0x186199910")]
	private void FMLFPKNNCMC(int FBKLIOFGODI, int JAPDIMAHDHK, Allocator HOJMCOLANAB, bool MDDCHJLLLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6197D30", Offset = "0x6196F30", VA = "0x186197D30")]
	private void AEGCPFGEMKJ(NativeArray<float3> MPOHHIPKDGO, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6197E30", Offset = "0x6197030", VA = "0x186197E30")]
	[BurstCompile]
	private unsafe static void AEGCPFGEMKJ(float3* MPOHHIPKDGO, [In] ushort* NOKFLPCBMGM, int INONAEKBBIE, [In] float3 GEEDDDPKGAE, [In] float3 GFIFJMBMIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6199540", Offset = "0x6198740", VA = "0x186199540")]
	private void EHDPDGENNGJ(NativeArray<float3> NOKFLPCBMGM, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6199640", Offset = "0x6198840", VA = "0x186199640")]
	[BurstCompile]
	private unsafe static void EHDPDGENNGJ(ushort* MPOHHIPKDGO, [Out] float3 ONKHDJLKJDH, [Out] float3 GFIFJMBMIFO, [In] float3* NOKFLPCBMGM, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x619B450", Offset = "0x619A650", VA = "0x18619B450")]
	private void PMLBPCPLFCJ(NativeArray<float3> LCINJFKKHAC, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x619B240", Offset = "0x619A440", VA = "0x18619B240")]
	[BurstCompile]
	private unsafe static void PMLBPCPLFCJ(ushort* FCEHFJAGNGF, [In] float3* LCINJFKKHAC, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x619AB00", Offset = "0x6199D00", VA = "0x18619AB00")]
	private void NIDFIMAMPAD(NativeArray<float3> BPOHCFBBECB, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x619ABD0", Offset = "0x6199DD0", VA = "0x18619ABD0")]
	[BurstCompile]
	private unsafe static void NIDFIMAMPAD(float3* BPOHCFBBECB, [In] ushort* LCINJFKKHAC, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x619A120", Offset = "0x6199320", VA = "0x18619A120")]
	private void GMBFNDEEPDK(NativeArray<float2> KGPOIHICALH, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x619A1F0", Offset = "0x61993F0", VA = "0x18619A1F0")]
	[BurstCompile]
	private unsafe static void GMBFNDEEPDK(ushort* BNOLNHJFJNB, [Out] float2 CLMDLEEBILI, [Out] float2 AMICNHPLMAJ, [In] float2* KGPOIHICALH, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x619A9E0", Offset = "0x6199BE0", VA = "0x18619A9E0")]
	[BurstCompile]
	private static void MMEEAPCDLDB([Out] float2 ACGJBBIKDIG, ushort KMCMPCDFIMN, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x619AC40", Offset = "0x6199E40", VA = "0x18619AC40")]
	private void NJOJEBHKAEF(NativeArray<float2> BNOLNHJFJNB, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x619AD40", Offset = "0x6199F40", VA = "0x18619AD40")]
	[BurstCompile]
	private unsafe static void NJOJEBHKAEF(float2* BNOLNHJFJNB, ushort* KGPOIHICALH, int INONAEKBBIE, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x619A4B0", Offset = "0x61996B0", VA = "0x18619A4B0")]
	private void GPEIFHNKKCG(NativeArray<float4> KEMJKFPBMFB, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x619A430", Offset = "0x6199630", VA = "0x18619A430")]
	[BurstCompile]
	private unsafe static void GPEIFHNKKCG(ushort* JCLNFNGNCJE, [In] float4* NNENEKMCKIL, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61980E0", Offset = "0x61972E0", VA = "0x1861980E0")]
	[BurstCompile]
	private static ushort BIDAJPKNGLE([In] float4 PEEODOGNIEM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x619A720", Offset = "0x6199920", VA = "0x18619A720")]
	private void IKEBPBMOFCG(NativeArray<float4> JCLNFNGNCJE, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x619A7F0", Offset = "0x61999F0", VA = "0x18619A7F0")]
	[BurstCompile]
	private unsafe static void IKEBPBMOFCG(float4* JCLNFNGNCJE, [In] ushort* KEMJKFPBMFB, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6197EB0", Offset = "0x61970B0", VA = "0x186197EB0")]
	[BurstCompile]
	private static void AGDBGAEFOLM([Out] float4 IFJGEIAONPI, ushort KMCMPCDFIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6199B00", Offset = "0x6198D00", VA = "0x186199B00")]
	private void GHGDFMIBMKI(Allocator HOJMCOLANAB, NativeArray<float4> DJCIIGMJMDM, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6199EE0", Offset = "0x61990E0", VA = "0x186199EE0")]
	[BurstCompile]
	private unsafe static void GHGDFMIBMKI(float4* CCPEOEIBOAH, byte* NOJDOOBKPKG, [Out] int MGBLFKEGCJC, [Out] int NCJGMCDGPGD, float4* DJCIIGMJMDM, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6198C40", Offset = "0x6197E40", VA = "0x186198C40")]
	private static void DFNKODKINHE(NativeArray<float4> AJFEEKJPHMD, NativeArray<PKBDMMLAGHE> DHMHIDFJNBK, NativeArray<byte> AADHMALPLND, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6198D50", Offset = "0x6197F50", VA = "0x186198D50")]
	[BurstCompile]
	private unsafe static void DFNKODKINHE(float4* AJFEEKJPHMD, [In] PKBDMMLAGHE* DHMHIDFJNBK, [In] byte* AADHMALPLND, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x619A5A0", Offset = "0x61997A0", VA = "0x18619A5A0")]
	private void HEDKLALFPJN(Allocator HOJMCOLANAB, NativeArray<int> EHMCGHMHBMH, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61988C0", Offset = "0x6197AC0", VA = "0x1861988C0")]
	private static NativeArray<byte> BPNPNOJDIBG(Allocator HOJMCOLANAB, NativeArray<int> EHMCGHMHBMH, int NEMOBGEMIHD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6198850", Offset = "0x6197A50", VA = "0x186198850")]
	[BurstCompile]
	private unsafe static int BPNPNOJDIBG(byte* KFBLLKKDPAP, [In] int* EHMCGHMHBMH, int NEMOBGEMIHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6197F80", Offset = "0x6197180", VA = "0x186197F80")]
	private static void AKIKDFOFBGE(NativeArray<int> GDHLAMJJGCH, NativeArray<byte> JODGGALHEJB, int AFGBMDOGPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6197F10", Offset = "0x6197110", VA = "0x186197F10")]
	[BurstCompile]
	private unsafe static void AKIKDFOFBGE(int* GDHLAMJJGCH, [In] byte* JODGGALHEJB, int AFGBMDOGPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61994E0", Offset = "0x61986E0", VA = "0x1861994E0")]
	[BurstCompile]
	private static void EBAKLOLGBCN([Out] float3 ACGJBBIKDIG, ushort KMCMPCDFIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x619ADC0", Offset = "0x6199FC0", VA = "0x18619ADC0")]
	[BurstCompile]
	private static ushort OJAANOLMDPC([In] float3 PEEODOGNIEM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HEDKJDOOPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x618C690", Offset = "0x618B890", VA = "0x18618C690")]
	[BurstCompile]
	public unsafe static void HINDMBHOCEB(float3* MPOHHIPKDGO, [In] ushort* NOKFLPCBMGM, int INONAEKBBIE, [In] float3 GEEDDDPKGAE, [In] float3 GFIFJMBMIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x618BC70", Offset = "0x618AE70", VA = "0x18618BC70")]
	[BurstCompile]
	public unsafe static void ACIANDMOCPG(ushort* MPOHHIPKDGO, [Out] float3 ONKHDJLKJDH, [Out] float3 GFIFJMBMIFO, [In] float3* NOKFLPCBMGM, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x618C8E0", Offset = "0x618BAE0", VA = "0x18618C8E0")]
	[BurstCompile]
	public unsafe static void MACNDNBIIEF(ushort* FCEHFJAGNGF, [In] float3* LCINJFKKHAC, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x619A860", Offset = "0x6199A60", VA = "0x18619A860")]
	[BurstCompile]
	public unsafe static void IKKEFGCGJPN(float3* BPOHCFBBECB, [In] ushort* LCINJFKKHAC, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x618C210", Offset = "0x618B410", VA = "0x18618C210")]
	[BurstCompile]
	public unsafe static void DKPGCPDGGBC(ushort* BNOLNHJFJNB, [Out] float2 CLMDLEEBILI, [Out] float2 AMICNHPLMAJ, [In] float2* KGPOIHICALH, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6198B30", Offset = "0x6197D30", VA = "0x186198B30")]
	[BurstCompile]
	public static void CEPJPDLKHOD([Out] float2 ACGJBBIKDIG, ushort KMCMPCDFIMN, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x619A900", Offset = "0x6199B00", VA = "0x18619A900")]
	[BurstCompile]
	public unsafe static void JLBFIEHLAKG(float2* BNOLNHJFJNB, ushort* KGPOIHICALH, int INONAEKBBIE, [In] float2 LBDCFDDMJNE, [In] float2 AMICNHPLMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6197C90", Offset = "0x6196E90", VA = "0x186197C90")]
	[BurstCompile]
	public unsafe static void ABLNEHIKGII(ushort* JCLNFNGNCJE, [In] float4* NNENEKMCKIL, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x619A680", Offset = "0x6199880", VA = "0x18619A680")]
	[BurstCompile]
	public static ushort IAGBIEJNEME([In] float4 PEEODOGNIEM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x619AA60", Offset = "0x6199C60", VA = "0x18619AA60")]
	[BurstCompile]
	public unsafe static void NEBNCKIHCAI(float4* JCLNFNGNCJE, [In] ushort* KEMJKFPBMFB, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6198B80", Offset = "0x6197D80", VA = "0x186198B80")]
	[BurstCompile]
	public static void DDMDMGHINBM([Out] float4 IFJGEIAONPI, ushort KMCMPCDFIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x618C050", Offset = "0x618B250", VA = "0x18618C050")]
	[BurstCompile]
	public unsafe static void BPIDEPAPGIL(float4* CCPEOEIBOAH, byte* NOJDOOBKPKG, [Out] int MGBLFKEGCJC, [Out] int NCJGMCDGPGD, float4* DJCIIGMJMDM, int AKDFCJMBNGO, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6198130", Offset = "0x6197330", VA = "0x186198130")]
	[BurstCompile]
	public unsafe static void BMLCDCLFFJC(float4* AJFEEKJPHMD, [In] PKBDMMLAGHE* DHMHIDFJNBK, [In] byte* AADHMALPLND, int INONAEKBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x619B140", Offset = "0x619A340", VA = "0x18619B140")]
	[BurstCompile]
	public unsafe static int PMJAPINEIOL(byte* KFBLLKKDPAP, [In] int* EHMCGHMHBMH, int NEMOBGEMIHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x619B0A0", Offset = "0x619A2A0", VA = "0x18619B0A0")]
	[BurstCompile]
	public unsafe static void PLECOABFOLA(int* GDHLAMJJGCH, [In] byte* JODGGALHEJB, int AFGBMDOGPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61996D0", Offset = "0x61988D0", VA = "0x1861996D0")]
	[BurstCompile]
	public static void EPFPKGGPDKP([Out] float3 ACGJBBIKDIG, ushort KMCMPCDFIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x618C4D0", Offset = "0x618B6D0", VA = "0x18618C4D0")]
	[BurstCompile]
	public static ushort GHHLJIBDGNG([In] float3 PEEODOGNIEM)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GBJEEBDMFLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float2 IPHPHPNFFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float2 NIACMFOKBJO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LAKODABMKML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<GBJEEBDMFLJ> LEILNADDFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<int> BPAPGPAFBPL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CBALPFENPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B8130", VA = "0x1807B8F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x61A00A0", Offset = "0x619F2A0", VA = "0x1861A00A0")]
	public LAKODABMKML(int FBKLIOFGODI, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x619FF60", Offset = "0x619F160", VA = "0x18619FF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x619FFC0", Offset = "0x619F1C0", VA = "0x18619FFC0")]
	public void HOMLNECJADA(LAKODABMKML FNENOICLMDD, int IAALEGFCLFG, int BHOMKDDOKFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KLNMHDDDHBF
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static LAKODABMKML GGNOLMGHFPL;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static NativeList<OHDABLHBPGG> DOPOLAHOPLE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static int[] CLCDOBENJEG;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static bool DKLIJGEHDOG;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, LAKODABMKML> NFIHKHACADE;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, LAKODABMKML> KHDOOEBEBFA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool AONLHGKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x619FCF0", Offset = "0x619EEF0", VA = "0x18619FCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<OHDABLHBPGG> IHNCFBNOJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x619FC60", Offset = "0x619EE60", VA = "0x18619FC60")]
		get
		{
			return default(NativeList<OHDABLHBPGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static LAKODABMKML BIIDDGFBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x619F8B0", Offset = "0x619EAB0", VA = "0x18619F8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x619E7B0", Offset = "0x619D9B0", VA = "0x18619E7B0")]
	private static void ABCILDCMGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x619F7D0", Offset = "0x619E9D0", VA = "0x18619F7D0")]
	public static int MIGHGCFIKEE(bool OCOAJEOCIIO, int KPJACANACFJ, bool MCOMCHHPLAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x619F5A0", Offset = "0x619E7A0", VA = "0x18619F5A0")]
	private static int FAPLBAIGDOB(int KPJACANACFJ, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x619F6D0", Offset = "0x619E8D0", VA = "0x18619F6D0")]
	private static int JMCJHAFOBFH(int KPJACANACFJ, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x619FD70", Offset = "0x619EF70", VA = "0x18619FD70")]
	public static int POIJCMHBKIA(int MCCIEIKDMFF, int KPJACANACFJ, int BLHKHJJHMML, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x619F820", Offset = "0x619EA20", VA = "0x18619F820")]
	public static int MMGGMHFDGHI(int MCCIEIKDMFF, int KPJACANACFJ, int BLHKHJJHMML, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x619FE00", Offset = "0x619F000", VA = "0x18619FE00")]
	public static int POMJPJBLMFK(int BLHKHJJHMML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x619EE50", Offset = "0x619E050", VA = "0x18619EE50")]
	private static int ALMHHKEGCNJ(int KPJACANACFJ, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x619F800", Offset = "0x619EA00", VA = "0x18619F800")]
	private static int MJICIAGAAOG(int KPJACANACFJ, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x619E740", Offset = "0x619D940", VA = "0x18619E740")]
	public static int AAOMHCOMPOI(int MCCIEIKDMFF, int KPJACANACFJ, int BLHKHJJHMML, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x619FBD0", Offset = "0x619EDD0", VA = "0x18619FBD0")]
	public static int NGOEGOIELAC(int MCCIEIKDMFF, int KPJACANACFJ, int BLHKHJJHMML, bool LOFLAENIGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x619F6B0", Offset = "0x619E8B0", VA = "0x18619F6B0")]
	public static int JJELEFDLPBP(int BLHKHJJHMML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x619F6E0", Offset = "0x619E8E0", VA = "0x18619F6E0")]
	public static LAKODABMKML KKPKCJEKHHH(int KPJACANACFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x619F940", Offset = "0x619EB40", VA = "0x18619F940")]
	private static LAKODABMKML NDKIFDOOLPC(int KPJACANACFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x619F5C0", Offset = "0x619E7C0", VA = "0x18619F5C0")]
	public static LAKODABMKML HPLEFPMPNNF(int KPJACANACFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x619EE60", Offset = "0x619E060", VA = "0x18619EE60")]
	private static LAKODABMKML CBBKPKKFDKO(int KPJACANACFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x619F1A0", Offset = "0x619E3A0", VA = "0x18619F1A0")]
	public static void DMHKAFHHLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct GGAJHJJODKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int FCNAKKKIFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 IDHOFGGKGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion DHCNLGDCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float NLPJGNHLKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float IKFGGEDLHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int IEABADFPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BGOBLBNPHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int NLOEKDCAGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool NHDNKPGEOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool LHLFGBCGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float NHJPGMFGAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 GMHNAFECOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool HCNKPANNDLJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct AOFIMGEEFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int MMKJGNBMCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int GPPOJJMEFLG;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JINFJHEEKBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeList<GGAJHJJODKI> KNICNIJGAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeArray<CBKEPECMHFD> KKJDKCCAEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<OHDABLHBPGG> JADJCIBIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<AOFIMGEEFPK> OBPIMHDNDLB;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x619BCA0", Offset = "0x619AEA0", VA = "0x18619BCA0")]
	public JINFJHEEKBB(NativeArray<CBKEPECMHFD> KKJDKCCAEBL, int ANCJPCFOHBG = 1, Allocator HOJMCOLANAB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x619BBB0", Offset = "0x619ADB0", VA = "0x18619BBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
public struct DMGPEDOENNG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<GBJEEBDMFLJ> NJBAFIIKBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<int> ANBCAFFDLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeList<OHDABLHBPGG> MNINEBMOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<GGAJHJJODKI> KNICNIJGAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<CBKEPECMHFD> KKJDKCCAEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<OHDABLHBPGG> JADJCIBIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<AOFIMGEEFPK> OBPIMHDNDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private int IAIHPOPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int EEAHJPOCBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float3 HKOHEOPLCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private quaternion HIHOMPMIIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 IMOEMBKNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PFENPNMHDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FKDJHDIDCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> ONEJIGMODGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GDOLIBHDLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JOENPFFLHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KELNCDDCMPP;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6191A90", Offset = "0x6190C90", VA = "0x186191A90")]
	public DMGPEDOENNG(NGABOLFNHJB LCBABNMHLON, FEEDCIOJNFD IKGBNPLPOHD, float3 IFAEALOIJHD, quaternion CCFBHLDEJNB, float EPKJFLPAADJ, int GPNDLMFKHNJ = 0, int NPEIHPGNOKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6191D10", Offset = "0x6190F10", VA = "0x186191D10")]
	public DMGPEDOENNG(JINFJHEEKBB LCBABNMHLON, FEEDCIOJNFD IKGBNPLPOHD, float3 IFAEALOIJHD, quaternion CCFBHLDEJNB, float3 EPKJFLPAADJ, int GPNDLMFKHNJ = 0, int NPEIHPGNOKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x618FBA0", Offset = "0x618EDA0", VA = "0x18618FBA0")]
	private float3 DMIFHEPGHOB(float3 GDLJHJMMPGN, Matrix4x4 GJJAGNDKBPG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x618FB20", Offset = "0x618ED20", VA = "0x18618FB20")]
	private float3x3 BOFOFFKKIOD(float3x3 JJICHOBIFEF, float3x3 MEHDABHGOEH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x618FB10", Offset = "0x618ED10", VA = "0x18618FB10")]
	private float AINEMDGBMPC(float OFBFBKPELML, float EEKOKGMBJFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x618FCD0", Offset = "0x618EED0", VA = "0x18618FCD0", Slot = "4")]
	public void Execute(int NMHNBICEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61912D0", Offset = "0x61904D0", VA = "0x1861912D0")]
	private void KFNNCDPILAK(int PGAKDFGKJHM, float3 JCMPCLFLJHD, float3 KBHLNPNINOC, float3 MLJMDLGBAJI, float MBFEDEOEGOE, bool OGNMNBNJHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6190E70", Offset = "0x6190070", VA = "0x186190E70")]
	private void GAPMMKECNCP(GGAJHJJODKI MGLCFLCOPDC, float3 CCDONDNKELE, float3x3 CHNFMIDIJDA, float OFBFBKPELML, int HNPBIHKGNNF, int KLAMKMCGNBC, int FAGNFINKDDH, float HKBEGEFJFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6191440", Offset = "0x6190640", VA = "0x186191440")]
	private void PDEEPGODALO(int PGAKDFGKJHM, int IAJAGKNGOOK, GGAJHJJODKI MGLCFLCOPDC, float3 CCDONDNKELE, float3x3 CHNFMIDIJDA, bool CAJIODCLCFC, float OFBFBKPELML, int ENLMGFOGFJJ, int KDLGFOLPKEG, int FAGNFINKDDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HGMBDHNLOFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeList<EJEFEPKENJI> PNMPPDFJLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeList<OHDABLHBPGG> KANJCCEIGEB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x619B5B0", Offset = "0x619A7B0", VA = "0x18619B5B0")]
	public HGMBDHNLOFE(int ANCJPCFOHBG, Allocator HOJMCOLANAB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x619B510", Offset = "0x619A710", VA = "0x18619B510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
public struct EPGCNDFDHNE : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private enum CHBCFBPPKBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private NativeList<float3> NDPAIPIMOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float3> HCDEBLKEBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeList<int> EAOOBBDJMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeArray<int> MLNOBOPLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeArray<float4> GDCKNMBOFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeArray<float4> JAAEAMNOMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<float4> CFIILOIDDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<float3> GIHAHJBKGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private NativeList<OHDABLHBPGG> LHOFIHLJNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private NativeList<EJEFEPKENJI> PNMPPDFJLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private NativeList<OHDABLHBPGG> KANJCCEIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private int IAIHPOPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private int EEAHJPOCBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PFENPNMHDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FKDJHDIDCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> ONEJIGMODGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GDOLIBHDLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JOENPFFLHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KELNCDDCMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private float3 IMOEMBKNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private quaternion HIHOMPMIIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 HKOHEOPLCPD;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6193990", Offset = "0x6192B90", VA = "0x186193990")]
	public EPGCNDFDHNE(NGABOLFNHJB LCBABNMHLON, FEEDCIOJNFD IKGBNPLPOHD, float3 IFAEALOIJHD, quaternion CCFBHLDEJNB, float EPKJFLPAADJ, int GPNDLMFKHNJ = 0, int NPEIHPGNOKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6193B80", Offset = "0x6192D80", VA = "0x186193B80")]
	public EPGCNDFDHNE(HGMBDHNLOFE MJGHOBDIDHD, FEEDCIOJNFD IKGBNPLPOHD, float3 IFAEALOIJHD, quaternion CCFBHLDEJNB, float3 EPKJFLPAADJ, int GPNDLMFKHNJ = 0, int NPEIHPGNOKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6192980", Offset = "0x6191B80", VA = "0x186192980", Slot = "4")]
	public void Execute(int NMHNBICEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x61925D0", Offset = "0x61917D0", VA = "0x1861925D0")]
	private void BPCCCGKAPBB(float4x4 LHFOONILKJH, int NMHNBICEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61938E0", Offset = "0x6192AE0", VA = "0x1861938E0")]
	private CHBCFBPPKBL KDJDPBCHJCO(float3 KBHLNPNINOC)
	{
		return default(CHBCFBPPKBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6192580", Offset = "0x6191780", VA = "0x186192580")]
	private float4 BGGLCPIHGFJ(CHBCFBPPKBL AALLFFOPPMB, int MBGANDEDPDN)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6193950", Offset = "0x6192B50", VA = "0x186193950")]
	private float2 KJLPJFAKABC(CHBCFBPPKBL AALLFFOPPMB, float3 JCMPCLFLJHD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KDKAKNKHEHB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum KPLLPMNJFED
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static KDKAKNKHEHB NONABGLHMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float3 BKEJMFAHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3x3 ONICOCGNJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 ODOBGAEOPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public KPLLPMNJFED MEBDELDBDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 OGBJMIOIJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 BJBDOEEANAM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DJHIIBCIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x619DE30", Offset = "0x619D030", VA = "0x18619DE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 GDCJHLILNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x619DE40", Offset = "0x619D040", VA = "0x18619DE40")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x619E130", Offset = "0x619D330", VA = "0x18619E130")]
	public KDKAKNKHEHB(float3 JCMPCLFLJHD, quaternion ECLCOOPOABI, float3 ANCJPCFOHBG, KPLLPMNJFED MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x619DA40", Offset = "0x619CC40", VA = "0x18619DA40")]
	public float HKBNJNJBPIM(float3 CCDONDNKELE, float LMCCLDCPJPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x619DD40", Offset = "0x619CF40", VA = "0x18619DD40")]
	public bool LGBDBFHMEKN(float3 KBHLNPNINOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x619DF20", Offset = "0x619D120", VA = "0x18619DF20")]
	public void PNAIOKLJPEF(float3 KOCMENLAEGG, float3x3 FBJDCOOBLML, float GLLMIHFLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x619DC40", Offset = "0x619CE40", VA = "0x18619DC40")]
	private void JLCEJIAMLCA(float3 EBFLKLNOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x619D7B0", Offset = "0x619C9B0", VA = "0x18619D7B0")]
	public void HHPGHMCPOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
public struct GJKLCDEHDHP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeList<KDKAKNKHEHB> MJGHOBDIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeList<float3> DAGKFGFLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<int> BNKNLGCDENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> AKAGINAEEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<OHDABLHBPGG> KANJCCEIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private int PFALMDEHHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int MDAJHGAECFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private float LMCCLDCPJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private float LIMOODGEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OPOFKPLJKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ACNBLELJDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NJPIKKKLPLK;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6197580", Offset = "0x6196780", VA = "0x186197580")]
	public GJKLCDEHDHP(FEEDCIOJNFD PLFOEDLJILP, float GIOMFHMBANG, int BHOMKDDOKFH, int HNPBIHKGNNF, NativeList<KDKAKNKHEHB> MJGHOBDIDHD, NativeArray<int> AKAGINAEEKJ, NativeList<OHDABLHBPGG> KANJCCEIGEB, COOHIMBGANP AENCEGPBOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6196AE0", Offset = "0x6195CE0", VA = "0x186196AE0", Slot = "4")]
	public void Execute(int HNJJINCPHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6197220", Offset = "0x6196420", VA = "0x186197220")]
	private bool ILMKPNMHFOP(KDKAKNKHEHB LLLCBODKBAN, KDKAKNKHEHB HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61972E0", Offset = "0x61964E0", VA = "0x1861972E0")]
	private bool KCLBDDLDFGC(KDKAKNKHEHB PCLNGBGMCCA, int ELGELCLDGHA, int DPEPDDHBCBK, int BADPNFKPJLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class COOHIMBGANP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<bool> PAJEEGBEBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<int> MKDCAHMDAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<bool> FKBHKFCJFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float> EOAHKAFNKGF;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x618EF00", Offset = "0x618E100", VA = "0x18618EF00")]
	public void FMLFPKNNCMC(int FBKLIOFGODI, int JAPDIMAHDHK, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x618EDF0", Offset = "0x618DFF0", VA = "0x18618EDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x618EE10", Offset = "0x618E010", VA = "0x18618EE10")]
	public void FMINDOPCMII(JobHandle IFPDAOGJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public COOHIMBGANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
public struct DFLFLBOKBKB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NativeList<float3> DAGKFGFLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NativeArray<float3> NOBIMAGCFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NativeArray<float4> NOMFPHPFOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeArray<float2> AOMMNBMEMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NativeList<int> BNKNLGCDENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PINPIGPKCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<int> OPBPAKBNLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeArray<bool> OPOFKPLJKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<bool> ACNBLELJDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private int GPNDLMFKHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private int NPEIHPGNOKA;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x618F440", Offset = "0x618E640", VA = "0x18618F440")]
	public DFLFLBOKBKB(FEEDCIOJNFD PLFOEDLJILP, COOHIMBGANP AENCEGPBOMO, int NPEIHPGNOKA = 0, int GPNDLMFKHNJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x618F060", Offset = "0x618E260", VA = "0x18618F060", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x618F000", Offset = "0x618E200", VA = "0x18618F000")]
	private void EGDBFPHJPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GJMFCCAMIGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x288D110", Offset = "0x288C310", VA = "0x18288D110")]
	public static bool DMECMAGAENG<T>(NativeArray<T> BLGDAGLONDD, int ANCJPCFOHBG, Allocator HOJMCOLANAB, NativeArrayOptions JNAMIDLEDED = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x288D1B0", Offset = "0x288C3B0", VA = "0x18288D1B0")]
	public static bool DMECMAGAENG<T>(NativeList<T> LBDHFFKKBHH, int ANCJPCFOHBG, Allocator HOJMCOLANAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum LJPLHCMPBCM
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MKMNAFELPND
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OCJCNDLHDAF(LJPLHCMPBCM MCCIEIKDMFF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GFKKECLIPBB(LJPLHCMPBCM MCCIEIKDMFF);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds LFGCOBIKCAP();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float ADGMCALGGAJ();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CABLHPEMLMA(LJPLHCMPBCM MCCIEIKDMFF, NGABOLFNHJB BAAPAGBCKHO, int FFEAEKCELAG = -1);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FEEDCIOJNFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int PGNLOFOJFIL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeList<float3> LNNLFPBKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NativeArray<float3> ADLBKGEENDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NativeArray<float4> NFGHLMLLIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeArray<float4> KLJHGFAJNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeArray<float2> LAPGLOFCIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<int> EJCPEPCKONM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OBLLEJJIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6194910", Offset = "0x6193B10", VA = "0x186194910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6195BB0", Offset = "0x6194DB0", VA = "0x186195BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CBALPFENPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6195BF0", Offset = "0x6194DF0", VA = "0x186195BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CLCBGHLOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6195B10", Offset = "0x6194D10", VA = "0x186195B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6194950", Offset = "0x6193B50", VA = "0x186194950", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6194EC0", Offset = "0x61940C0", VA = "0x186194EC0")]
	public void FMLFPKNNCMC(int FBKLIOFGODI, int JAPDIMAHDHK, Allocator HOJMCOLANAB, bool PKEJJJMLEOG, bool MDDCHJLLLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6194E40", Offset = "0x6194040", VA = "0x186194E40")]
	public void FLIIICBAJCB(int FBKLIOFGODI, int JAPDIMAHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6194A60", Offset = "0x6193C60", VA = "0x186194A60", Slot = "6")]
	public bool ELDDFBFAGNL(Mesh PLFOEDLJILP, bool HECHKDCLKAD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6195090", Offset = "0x6194290", VA = "0x186195090")]
	public bool FNNEABGHLII(Mesh PLFOEDLJILP, FEEDCIOJNFD JMNBIBMCCDN, bool HECHKDCLKAD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61958A0", Offset = "0x6194AA0", VA = "0x1861958A0")]
	public void HOMLNECJADA(FEEDCIOJNFD PLFOEDLJILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6195C30", Offset = "0x6194E30", VA = "0x186195C30")]
	public FEEDCIOJNFD OGEBIAEMLFN(Allocator HOJMCOLANAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61947D0", Offset = "0x61939D0", VA = "0x1861947D0")]
	public long BFBCPMJNIFA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6195B50", Offset = "0x6194D50", VA = "0x186195B50")]
	public void LCGHECOBCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public FEEDCIOJNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HBOCBNKOIGM
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6197B40", Offset = "0x6196D40", VA = "0x186197B40")]
	public static void DMHKAFHHLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JLLJPCCFDKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<float3> LNNLFPBKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<float3> ADLBKGEENDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<int> ALLJPHBLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<float4> LLMLMFPAKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<float4> BKGGBEIMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float4> OHDCFMEELNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public NativeList<float3> DIFDIJHHLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public NativeList<int> EJCPEPCKONM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x619C7A0", Offset = "0x619B9A0", VA = "0x18619C7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CBALPFENPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x619C7E0", Offset = "0x619B9E0", VA = "0x18619C7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BBDKOLGHOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x619C760", Offset = "0x619B960", VA = "0x18619C760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x619CCB0", Offset = "0x619BEB0", VA = "0x18619CCB0")]
	public JLLJPCCFDKK(int FBKLIOFGODI, int JAPDIMAHDHK, int GCKEMBBIECH, Allocator HOJMCOLANAB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x619CED0", Offset = "0x619C0D0", VA = "0x18619CED0")]
	public JLLJPCCFDKK(Mesh PLFOEDLJILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x619C350", Offset = "0x619B550", VA = "0x18619C350", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x619C460", Offset = "0x619B660", VA = "0x18619C460")]
	public void HOMLNECJADA(JLLJPCCFDKK PLFOEDLJILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x619C820", Offset = "0x619BA20", VA = "0x18619C820")]
	private void NHNOPNMFJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x619BDD0", Offset = "0x619AFD0", VA = "0x18619BDD0")]
	private void CJDKNHLIGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OHDABLHBPGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public int ELAENCHDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int OLOLPMMJCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int KJAGEKKOCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public int CBALPFENPIC;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x126A550", Offset = "0x1269750", VA = "0x18126A550")]
	public OHDABLHBPGG(int HNPBIHKGNNF, int INONAEKBBIE, int BHOMKDDOKFH, int AFGBMDOGPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class CAIAAPKPAMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<OHDABLHBPGG> LMBOJKEEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<OHDABLHBPGG>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x854310", Offset = "0x853510", VA = "0x180854310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JLLJPCCFDKK ADAAJOKAAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x618DDE0", Offset = "0x618CFE0", VA = "0x18618DDE0")]
	public CAIAAPKPAMM(IEnumerable<JLLJPCCFDKK> PHDIIJOJFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x618DD70", Offset = "0x618CF70", VA = "0x18618DD70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum GBGANMJNOPB
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JFJMEPPMMKD
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static NativeArray<float2> KOJOONKLPID;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NativeArray<float3> PKHDOJBPMNK;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static NativeArray<float4> EMJLLLHCDJP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeArray<int> CHOABDMGENM;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x619B6A0", Offset = "0x619A8A0", VA = "0x18619B6A0")]
	public static void DMHKAFHHLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x619B7B0", Offset = "0x619A9B0", VA = "0x18619B7B0")]
	public static NativeArray<float2> GGEBGAKACHH(NativeArray<float2> GHHOHIMOJID, int JCJNEFFHFPN, NativeArray<float2> HGBLNPFOBKD, int KPNPFOBOBNM)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x619BAB0", Offset = "0x619ACB0", VA = "0x18619BAB0")]
	public static NativeArray<float3> ONBJICOCMDB(NativeArray<float3> GHHOHIMOJID, int JCJNEFFHFPN, NativeArray<float3> HGBLNPFOBKD, int KPNPFOBOBNM)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x619B8B0", Offset = "0x619AAB0", VA = "0x18619B8B0")]
	public static NativeArray<float4> IBDJMKBECEO(NativeArray<float4> GHHOHIMOJID, int JCJNEFFHFPN, NativeArray<float4> HGBLNPFOBKD, int KPNPFOBOBNM)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x619B9B0", Offset = "0x619ABB0", VA = "0x18619B9B0")]
	public static NativeArray<int> JAFFFHAMGMG(NativeArray<int> GHHOHIMOJID, int JCJNEFFHFPN, NativeArray<int> HGBLNPFOBKD, int KPNPFOBOBNM)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x28D8A20", Offset = "0x28D7C20", VA = "0x1828D8A20")]
	private static void GACNILGCHKB<T>(NativeArray<T> BLGDAGLONDD, int LKPEHPABCJH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x28D8970", Offset = "0x28D7B70", VA = "0x1828D8970")]
	private static void BPDEOPPGCDN<T>(NativeArray<T> GHHOHIMOJID, int JCJNEFFHFPN, NativeArray<T> HGBLNPFOBKD, int KPNPFOBOBNM, NativeArray<T> GIPFNNDCCBO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DebuggerStepThrough]
public static class OIDMDBOHEDB
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	public static void INECLFIHDJK(bool KCEAHMBEPHE, string OKEPBHIMFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	public static void INECLFIHDJK(bool KCEAHMBEPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PGPINMDKKIN
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal enum FJHJKOPBGJC
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class GECOKLJIAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HEDKJDOOPAG PLFOEDLJILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int BFNLMKHDJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int JOCPHNBDGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long OAEAPHCKKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public long HGICAAGOAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float EONIANEBHIN;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x61B2E60", Offset = "0x61B2060", VA = "0x1861B2E60")]
		public GECOKLJIAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x61B2E20", Offset = "0x61B2020", VA = "0x1861B2E20")]
		public void FMINDOPCMII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly string BJGNCJLLHDL;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly string MNALKFBDDKA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker MOPLGPKODLP;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker LKPFJJPDBPE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker EJKGHACBAEO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker KDJFMNIJCIL;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker KEBFDLMOHNK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker HIHJOLOODCI;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker JDCLKFJNJDI;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker MLIEEAHEEPB;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker ECFLDCMNPIG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker BPGKNMLMHFA;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker OMIEJMEBKNN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker BKAOPBNFMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<MKMNAFELPND> HHOIGACGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly IGCMLGNPGHK LBMEIMOMBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int INONAEKBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int AFGBMDOGPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool DKAEPFKAKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	internal bool CJDGPJKKNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	internal FJHJKOPBGJC GAEMKAANAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	internal bool DONHKOBJGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal float3 HIBCAFPOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal float3 HPOMJPBJGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal float GEKJCHNLIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	internal float IFLIANJBDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	internal int GHIODNFGFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	internal int MKNECCFLFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int FLJGHNECEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float JGDFJPDOLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float DBFPMKLIMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int BFDMHDNKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long PPGAOJDKNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long EOANACBEFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private long LFHMAIAHHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int BGBPJJLJPLB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int LLFIDOMKLKE = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float[] CKIGGJJOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int[] BCDCJJBAOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private long[] PFAFDCKENKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private FEEDCIOJNFD BCPGCPBIEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private long KCDHMBICBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private long HEILPEKJMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int AKIHABICHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private List<GECOKLJIAFE> INFGKIEFKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	internal float CMCFEBMAGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool PCAPCFKMMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private AAAGIKMHLIE FGPAMMEEMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JobHandle CPHNNGFGCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal NativeArray<long> LGFFOHOFAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool KHFCHIBBDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private JobHandle BLFLJOALPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FEEDCIOJNFD CODMHEKAEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Transform HJNLMKIHMPM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh ADAAJOKAAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer ODLPJOBJCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ENEEILOJNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x87F720", Offset = "0x87E920", VA = "0x18087F720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EHJKNAMFGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7DC010", Offset = "0x7DB210", VA = "0x1807DC010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x61A7810", Offset = "0x61A6A10", VA = "0x1861A7810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<MKMNAFELPND> MNCEGBIGKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x61A3230", Offset = "0x61A2430", VA = "0x1861A3230")]
	public void BBLJKCJJEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x61A78F0", Offset = "0x61A6AF0", VA = "0x1861A78F0")]
	private void MNNHFIDHOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x61AA690", Offset = "0x61A9890", VA = "0x1861AA690")]
	public PGPINMDKKIN(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x61A45A0", Offset = "0x61A37A0", VA = "0x1861A45A0")]
	public void FMINDOPCMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x61A7860", Offset = "0x61A6A60", VA = "0x1861A7860")]
	public void MMKMMJDBNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x61A4330", Offset = "0x61A3530", VA = "0x1861A4330")]
	private void FJADHACMHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x61A51C0", Offset = "0x61A43C0", VA = "0x1861A51C0")]
	public void IFJCKNLACBP(MKMNAFELPND LNFHIGKHEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x61A6190", Offset = "0x61A5390", VA = "0x1861A6190")]
	public bool KFMKEDPDHLG(MKMNAFELPND LNFHIGKHEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x61A42D0", Offset = "0x61A34D0", VA = "0x1861A42D0")]
	public bool FFANKOOFEPM(MKMNAFELPND LNFHIGKHEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x61A87B0", Offset = "0x61A79B0", VA = "0x1861A87B0", Slot = "4")]
	public virtual void OEGHGOMLBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x61A7690", Offset = "0x61A6890", VA = "0x1861A7690")]
	public void LCLCMGBKPNC(Transform NLGNBPIPJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61A8C10", Offset = "0x61A7E10", VA = "0x1861A8C10")]
	public bool PCEFEEFKADK(Transform NLGNBPIPJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x61A3250", Offset = "0x61A2450", VA = "0x1861A3250")]
	public bool BGNDCCDNFCC(bool NFHKGCBGHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x61A9820", Offset = "0x61A8A20", VA = "0x1861A9820")]
	public void PMNLHKLDNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x61A5320", Offset = "0x61A4520", VA = "0x1861A5320")]
	public bool JIEBPEFBFCL(float4x4 JDAELFCGPCD, BatchedMeshRenderer EAHLBNIBDMD, bool EHGCLLJMBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x61A8860", Offset = "0x61A7A60", VA = "0x1861A8860")]
	public void OIMFNKBJOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61A8930", Offset = "0x61A7B30", VA = "0x1861A8930")]
	public bool PBEDDKINLBF(bool NFHKGCBGHGE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x61A46B0", Offset = "0x61A38B0", VA = "0x1861A46B0")]
	public void GGBCPBPFGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61A7830", Offset = "0x61A6A30", VA = "0x1861A7830")]
	public void MKFILBPNHHA(FEEDCIOJNFD PLFOEDLJILP, int BDIAKFJJBEC, float DKJKGGBPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x61A40E0", Offset = "0x61A32E0", VA = "0x1861A40E0")]
	public void CKNJCNABMFM(HEDKJDOOPAG NFDPHLONPFN, int BDIAKFJJBEC, float DKJKGGBPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61A3240", Offset = "0x61A2440", VA = "0x1861A3240")]
	public long BFBCPMJNIFA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD410", Offset = "0x7BC610", VA = "0x1807BD410")]
	public long HAKLFFCJLLL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x61A30C0", Offset = "0x61A22C0", VA = "0x1861A30C0")]
	private void AFOMMIKAFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x61A6230", Offset = "0x61A5430", VA = "0x1861A6230")]
	public (long, long) KFPNIIBCNFL(float HECHFGDKGGM, float4x4 JDAELFCGPCD)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xA7D530", Offset = "0xA7C730", VA = "0x180A7D530")]
	internal void ELEILONJFJK(FJHJKOPBGJC CPBPPMJPALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x61A4940", Offset = "0x61A3B40", VA = "0x1861A4940")]
	private (float, float, float) HNOEKIBMPHH(float IJAHGGFAHJI, float4x4 JDAELFCGPCD)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x61A46C0", Offset = "0x61A38C0", VA = "0x1861A46C0")]
	private (int, int) HGIOLIPNANJ(float GJNBOHIBENL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x61A65A0", Offset = "0x61A57A0", VA = "0x1861A65A0")]
	public void LBPEBGHKBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x61A40B0", Offset = "0x61A32B0", VA = "0x1861A40B0")]
	private void CJIINKAEHEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x61A4110", Offset = "0x61A3310", VA = "0x1861A4110")]
	private void DINDPHOJMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x61A9A10", Offset = "0x61A8C10", VA = "0x1861A9A10")]
	private void POPMGGELCHB(FEEDCIOJNFD NJOBPECEAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x61A84A0", Offset = "0x61A76A0", VA = "0x1861A84A0")]
	private void OAHPBBFPKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x61A7AD0", Offset = "0x61A6CD0", VA = "0x1861A7AD0")]
	private void NBBMMFICDJD(FEEDCIOJNFD PLFOEDLJILP, HEDKJDOOPAG NFDPHLONPFN, int BDIAKFJJBEC, float DKJKGGBPKBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[BurstCompile]
internal struct AAAGIKMHLIE : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct HOEIGHAGEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int AGALJPFDDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int JKHMBPFDPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int IPDOMNMADHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int JDOCDJOIIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int CBMLAMFJDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int AIPHHLFMJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int BFNLMKHDJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int JOCPHNBDGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float EONIANEBHIN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct FBNEKMMDIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public NEMOOMPCAHD.MHOMKBGFBHL KHJLKPBIGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float PHFDNOIEHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float FODOOELKKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float FENMEJIEJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float GOAFNKHHPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float LADCMHNHDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float ICJCNOKAPAP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct PJNBCDLDKNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NativeArray<float3> LNNLFPBKMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NativeArray<float3> ADLBKGEENDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NativeArray<float4> NFGHLMLLIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NativeArray<float4> KLJHGFAJNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NativeArray<float2> LAPGLOFCIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NativeArray<int> EJCPEPCKONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool NJODMPDLNCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int OLOLPMMJCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int CBALPFENPIC;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x61B6FE0", Offset = "0x61B61E0", VA = "0x1861B6FE0")]
		public void FMLFPKNNCMC(int FBKLIOFGODI, int JAPDIMAHDHK, Allocator HOJMCOLANAB, bool MDDCHJLLLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x61B6CD0", Offset = "0x61B5ED0", VA = "0x1861B6CD0")]
		public static PJNBCDLDKNP FGHDHDDHKMC(FEEDCIOJNFD NGGIHAOFJPD)
		{
			return default(PJNBCDLDKNP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x61B6F20", Offset = "0x61B6120", VA = "0x1861B6F20")]
		public void FMINDOPCMII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker AJIHAKCPCLB;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker PCAOCMLJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private NativeArray<HOEIGHAGEMK> FONDIDPNHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private PJNBCDLDKNP ELDOBBFHEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private PJNBCDLDKNP NJOBPECEAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float3 DNLHGCDMFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private float3 JNKKFAGLPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private FBNEKMMDIAK JDONAGDHNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* GANLJKCPJHO;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61ACE40", Offset = "0x61AC040", VA = "0x1861ACE40")]
	public AAAGIKMHLIE([In] List<PGPINMDKKIN.GECOKLJIAFE> AKMABOKDPJI, [In] FEEDCIOJNFD EDMHHPJKKGK, [In] PGPINMDKKIN NPDOIKLBONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x61AC080", Offset = "0x61AB280", VA = "0x1861AC080", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x61AC530", Offset = "0x61AB730", VA = "0x1861AC530")]
	public void IJFKHDLILCL(List<PGPINMDKKIN.GECOKLJIAFE> CFIEPPLHHFG, [In] PGPINMDKKIN NPDOIKLBONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x61AC510", Offset = "0x61AB710", VA = "0x1861AC510")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool IFINGODJMNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x61ACBE0", Offset = "0x61ABDE0", VA = "0x1861ACBE0")]
	private HEDKJDOOPAG LIMHANGHICN(int DPNOIBBFCDG, Allocator HOJMCOLANAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x61AABD0", Offset = "0x61A9DD0", VA = "0x1861AABD0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void DOCGGNFFLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x61AC0D0", Offset = "0x61AB2D0", VA = "0x1861AC0D0")]
	[IgnoreWarning(1371)]
	private HOEIGHAGEMK GJHNOOKODON([In] HOEIGHAGEMK FNLKKIJBNPD, int FGFJNPLANOI, [In] NativeArray<int> BNKNLGCDENF, [In] NativeArray<bool> ACNBLELJDDP, NativeArray<int> KKHLEHDNFDB)
	{
		return default(HOEIGHAGEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x61ACCB0", Offset = "0x61ABEB0", VA = "0x1861ACCB0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int OHLIJLGJJOB(NativeArray<int> BNKNLGCDENF, int DLFMNIIDBKF, int DLMMBNCOBFM, int NHCILDEOLLB)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly ProfilerMarker ACPBDICBHHC;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly ProfilerMarker AKOJFNOBMDK;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly ProfilerMarker AFNNBPKADOB;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly ProfilerMarker PEPMIDFDLDN;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly ProfilerMarker KEBFDLMOHNK;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly ProfilerMarker NPLJPLKOCCK;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly ProfilerMarker ADFLKKPKOCI;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal const int EOEFAHFJMHG = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Dictionary<Material, List<PGPINMDKKIN>> NDMDMPNMHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal List<PGPINMDKKIN> FCKEPNAPBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private List<MeshRenderer> OJEECJAGHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool GCPICGOMBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool IBLJEIHPILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int GAHNIFOELEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Dictionary<int, float> NLJOOKMOGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Dictionary<int, Color> EEIIMICHNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Dictionary<int, Vector4> FIGEFPPEBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, Matrix4x4> DHGBMFINHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private PGPINMDKKIN ICFNEBHBPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Material HGAILBLBOPH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> BJDHFKLLGIB
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int HFBGAMFEBEI
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x61B2DD0", Offset = "0x61B1FD0", VA = "0x1861B2DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x61AF750", Offset = "0x61AE950", VA = "0x1861AF750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x61AE200", Offset = "0x61AD400", VA = "0x1861AE200")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x61AD470", Offset = "0x61AC670", VA = "0x1861AD470")]
		public PGPINMDKKIN AddToBatchedMesh(MKMNAFELPND MMKLENHEJJO, Material ODNKEDBIBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x61B1FD0", Offset = "0x61B11D0", VA = "0x1861B1FD0")]
		public void RemoveFromBatchedMesh(MKMNAFELPND PLFOEDLJILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x61AE0D0", Offset = "0x61AD2D0", VA = "0x1861AE0D0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x61B2110", Offset = "0x61B1310", VA = "0x1861B2110")]
		public void SetMaterialProperty(int KCCIKABICGA, Color CMIODFEAKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x61B2590", Offset = "0x61B1790", VA = "0x1861B2590")]
		public void SetMaterialProperty(int KCCIKABICGA, float EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x61B27A0", Offset = "0x61B19A0", VA = "0x1861B27A0")]
		public void SetMaterialProperty(int KCCIKABICGA, Vector4 KGKIOAJBCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x61B2330", Offset = "0x61B1530", VA = "0x1861B2330")]
		public void SetMaterialProperty(int KCCIKABICGA, Matrix4x4 FGELHCMJPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x61AD570", Offset = "0x61AC770", VA = "0x1861AD570")]
		private void CEOCCCEMCDJ(Renderer FBFNLOOEGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x61AE3D0", Offset = "0x61AD5D0", VA = "0x1861AE3D0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x61AE3C0", Offset = "0x61AD5C0", VA = "0x1861AE3C0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x61AF1E0", Offset = "0x61AE3E0", VA = "0x1861AF1E0")]
		private void ODLPDIOLIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x61AE470", Offset = "0x61AD670", VA = "0x1861AE470")]
		private PGPINMDKKIN GIMOHLPHLJG(MKMNAFELPND PLFOEDLJILP, Material ODNKEDBIBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x61AFA40", Offset = "0x61AEC40", VA = "0x1861AFA40")]
		private PGPINMDKKIN PNEDOGNOMCL(Material ODNKEDBIBDH, int CEAMKBHCFNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x61ADB60", Offset = "0x61ACD60", VA = "0x1861ADB60")]
		private PGPINMDKKIN CEPPMLGAMAN(Material ODNKEDBIBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1743B40", Offset = "0x1742D40", VA = "0x181743B40")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x61AECC0", Offset = "0x61ADEC0", VA = "0x1861AECC0")]
		public void MarkDirty(MKMNAFELPND PLFOEDLJILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x61AEE20", Offset = "0x61AE020", VA = "0x1861AEE20")]
		public (long, long) MemorySizeInBytesForChosenDetail(float HECHFGDKGGM)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x61B1120", Offset = "0x61B0320", VA = "0x1861B1120")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x61AE700", Offset = "0x61AD900", VA = "0x1861AE700")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x61AFC40", Offset = "0x61AEE40", VA = "0x1861AFC40")]
		public void RebatchOptimally(int JHPLCHFEBMB, int OJKFMFCCAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x61B2B60", Offset = "0x61B1D60", VA = "0x1861B2B60")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LMLHNKBPHGH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct JCAGNFAJLPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public float CJCOBDOEDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BatchedMeshRenderer IDIPHOCDHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public PGPINMDKKIN IBIHAKEJEOD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly ProfilerMarker KEBFDLMOHNK;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ProfilerMarker GLFMOPNLGNB;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly ProfilerMarker LHPLPEHBNMF;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ProfilerMarker EEGCKMNCGCF;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public static float3 LMAPODHAIGB;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public static int AILGNEHANCO;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static int OGNAPHOALJH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static int BJLBFKGIHDM;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public static int AFFAKJPHOHN;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public static int AELPOJFKLIB;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static int JIMMJNHPCMF;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static int BGGEPFDBMNO;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static int BKHEMLGJNLL;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static int HJKHKNDEJOE;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static int DGIBAEBECHE;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public static int EOAFLDLNHMN;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public static int FDHIMDNJBBP;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public static int BKDJLKKLINO;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public static int KIAOMEAABAM;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static int GHOCGIFFPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public static int JLCIAMMOOLA;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public static long LKFMLENJCFI;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public static bool CFFCEEALDKG;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<BatchedMeshRenderer> LFPHACFCBEA;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static List<JCAGNFAJLPK> GOIHJHDGHEH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool HKAKPJHPEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x61B6A20", Offset = "0x61B5C20", VA = "0x1861B6A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x61B38E0", Offset = "0x61B2AE0", VA = "0x1861B38E0")]
	public static void GNCDFEHEFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x61B3600", Offset = "0x61B2800", VA = "0x1861B3600")]
	public static void FOAGNDJBHKN(BatchedMeshRenderer AIJIFJBHFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x61B3440", Offset = "0x61B2640", VA = "0x1861B3440")]
	public static void EECIHGNJABC(BatchedMeshRenderer AIJIFJBHFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x61B32A0", Offset = "0x61B24A0", VA = "0x1861B32A0")]
	private static void DHIABFBJEBC([Out] long OMHGPCILIPI, [Out] long NNPOPEJAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x61B3B50", Offset = "0x61B2D50", VA = "0x1861B3B50")]
	public static void JIEBPEFBFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x61B3AB0", Offset = "0x61B2CB0", VA = "0x1861B3AB0")]
	public static void ILMCCKNBHKP(PGPINMDKKIN IBIHAKEJEOD, BatchedMeshRenderer IDIPHOCDHNI, float CJCOBDOEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x61B5770", Offset = "0x61B4970", VA = "0x1861B5770")]
	public static void KDFOFDKODJP(PGPINMDKKIN IBIHAKEJEOD, BatchedMeshRenderer IDIPHOCDHNI, float NFECMCMJHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x61B2EB0", Offset = "0x61B20B0", VA = "0x1861B2EB0")]
	public static void BAPBLMFFLHP(PGPINMDKKIN IBIHAKEJEOD, BatchedMeshRenderer IDIPHOCDHNI, float NFECMCMJHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x61B2F50", Offset = "0x61B2150", VA = "0x1861B2F50")]
	public static void CDPFECPHIHE(PGPINMDKKIN IBIHAKEJEOD, BatchedMeshRenderer IDIPHOCDHNI, float CJCOBDOEDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x61B6850", Offset = "0x61B5A50", VA = "0x1861B6850")]
	public static void PCMDMKLDDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x61B30B0", Offset = "0x61B22B0", VA = "0x1861B30B0")]
	public static void CGBIBIODMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x61B64D0", Offset = "0x61B56D0", VA = "0x1861B64D0")]
	public static float OONCILCAFMO(long MDOPKGMGMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x61B5810", Offset = "0x61B4A10", VA = "0x1861B5810")]
	public static (long, long) KFPNIIBCNFL(float HECHFGDKGGM)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x61B59E0", Offset = "0x61B4BE0", VA = "0x1861B59E0")]
	public static void OOLEPBFOODJ(bool ONCGKJEENFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x61B34E0", Offset = "0x61B26E0", VA = "0x1861B34E0")]
	public static int FBJCBIOHLFF()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class DHIENJMEOAM<KeyType> : PGPINMDKKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<KeyType, MKMNAFELPND> GADHAOJHDKF;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5099670", Offset = "0x5098870", VA = "0x185099670")]
	public DHIENJMEOAM(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5099440", Offset = "0x5098640", VA = "0x185099440")]
	public void IFJCKNLACBP(KeyType GHBNLDGJPCB, MKMNAFELPND LNFHIGKHEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5099490", Offset = "0x5098690", VA = "0x185099490")]
	public bool KOLIELNHDKP(KeyType GHBNLDGJPCB, MKMNAFELPND IFNCEMGBHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5099300", Offset = "0x5098500", VA = "0x185099300")]
	public void EGLBJEHPGEO(KeyType GHBNLDGJPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5099630", Offset = "0x5098830", VA = "0x185099630", Slot = "4")]
	public override void OEGHGOMLBJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x61B7130", Offset = "0x61B6330", VA = "0x1861B7130")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
