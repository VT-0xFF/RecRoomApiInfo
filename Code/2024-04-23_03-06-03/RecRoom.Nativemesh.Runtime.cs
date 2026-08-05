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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KHJELJCLKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int LOLIIAFNOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 IPGHPIGCODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion EJMOEECNDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 LFBBLFJLFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CEALGPHFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int FBIBJOLBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KFLJOFFLDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float BMDLHMKDBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 GAEPBAOBIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool ODOEDNLCDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public BOFFGGAFNHB DCLPACCOFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 DBODIAKHPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float INAJOALNMNM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BHBGCKFONGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static CAEOOHCCFFL COILGKJEKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<KHJELJCLKIP> EPJBFHPEJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<DBMLFEEMNMK> MHCFFIBMNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<JMKLODJOJJL> PHACPAGLEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<CCLJNANFHKL> AJACKGGJBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<DBMLFEEMNMK> IJBBKCIEPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<CKDPDHMFPFI> EJJHKNPEIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<CCLJNANFHKL>> JILGDPMDOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<EMBIBKIMIMH> DLELPCOKKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> LMJPLEIFJLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MBGNDOMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC74980", Offset = "0xC73980", VA = "0x180C74980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC74480", Offset = "0xC73480", VA = "0x180C74480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBHPFBFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC74990", Offset = "0xC73990", VA = "0x180C74990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC73E40", Offset = "0xC72E40", VA = "0x180C73E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6316B70", Offset = "0x6315B70", VA = "0x186316B70")]
	public BHBGCKFONGN(int LLAALPEBBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63154A0", Offset = "0x63144A0", VA = "0x1863154A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6315020", Offset = "0x6314020", VA = "0x186315020")]
	public void BPEPGBDJLCI(JobHandle NFHOJLAMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63154C0", Offset = "0x63144C0", VA = "0x1863154C0")]
	public void JCHNADOPNMA(KHJELJCLKIP GPKMLHOONCL, EMBIBKIMIMH FFEHCLBADNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6316A30", Offset = "0x6315A30", VA = "0x186316A30")]
	public void OKJHMKLHBMF(JMKLODJOJJL GPKMLHOONCL, NativeArray<CCLJNANFHKL> FMONCJICCDP, int HCEIPJNIFCF, int GCMPHABKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63156E0", Offset = "0x63146E0", VA = "0x1863156E0")]
	public JobHandle KCKIDOCFOFA(DGFJOPHFDKD OLJPNPAAGIH, MMHMMEEICPE OJJOCHIHNFK, float3 MNDCDAPPEPL, quaternion FPDBPEOCPBB, float INLHCNOHNOH, bool LDFBMDGDIGA, int AMCDNACOBFM = 0, int PJDGEIPHOPG = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63166F0", Offset = "0x63156F0", VA = "0x1863166F0")]
	public static JobHandle NNLGDMFPAPI(IFINPEJLMPD EPAMHFIOIJO, DGFJOPHFDKD OLJPNPAAGIH, KHJELJCLKIP GPKMLHOONCL, JobHandle NFHOJLAMIPA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63151F0", Offset = "0x63141F0", VA = "0x1863151F0")]
	public static JobHandle DDOFOLKCGPE(ODAPPGGCAHC EPAMHFIOIJO, DGFJOPHFDKD OLJPNPAAGIH, JMKLODJOJJL GPKMLHOONCL, NativeArray<CCLJNANFHKL> FMONCJICCDP, int HCEIPJNIFCF, int GCMPHABKKFN, JobHandle NFHOJLAMIPA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class BJOHFBLIEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct ALCKMHDKPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half BAJCNONGJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort LJHCLOOENAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte GJOFEOGALEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public unsafe delegate void CLDIPNBNEDN(float3* HJPNJEADEPH, [In] ushort* IKHDBECAPJG, int HCEIPJNIFCF, [In] float3 MBAIPJNOJDN, [In] float3 HKIPLGGBHEE);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class OKEPCCNAMJP
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6328A90", Offset = "0x6327A90", VA = "0x186328A90")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6328720", Offset = "0x6327720", VA = "0x186328720")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6328BC0", Offset = "0x6327BC0", VA = "0x186328BC0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6328880", Offset = "0x6327880", VA = "0x186328880")]
		public unsafe static void HEGHDPNDHOB(float3* HJPNJEADEPH, [In] ushort* IKHDBECAPJG, int HCEIPJNIFCF, [In] float3 MBAIPJNOJDN, [In] float3 HKIPLGGBHEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void OEGLFOCJBAH(ushort* HJPNJEADEPH, [Out] float3 EIMNNJGDGBP, [Out] float3 HKIPLGGBHEE, [In] float3* IKHDBECAPJG, int EAKEOBCAPOE, int AALFLLNNAPO);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class ILGJCLLLKDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6322A00", Offset = "0x6321A00", VA = "0x186322A00")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6322680", Offset = "0x6321680", VA = "0x186322680")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6322B30", Offset = "0x6321B30", VA = "0x186322B30")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63227E0", Offset = "0x63217E0", VA = "0x1863227E0")]
		public unsafe static void HEGHDPNDHOB(ushort* HJPNJEADEPH, [Out] float3 EIMNNJGDGBP, [Out] float3 HKIPLGGBHEE, [In] float3* IKHDBECAPJG, int EAKEOBCAPOE, int AALFLLNNAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public unsafe delegate void EOIGIINBKAG(ushort* OOJDNBGBMAF, [In] float3* IEPGMPENFMI, int AALFLLNNAPO);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class NGLBMLOJHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6328320", Offset = "0x6327320", VA = "0x186328320")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6327FD0", Offset = "0x6326FD0", VA = "0x186327FD0")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6328450", Offset = "0x6327450", VA = "0x186328450")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6328130", Offset = "0x6327130", VA = "0x186328130")]
		public unsafe static void HEGHDPNDHOB(ushort* OOJDNBGBMAF, [In] float3* IEPGMPENFMI, int AALFLLNNAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public unsafe delegate void OCPCPHGOIKH(float3* HBGHEFMMLDM, [In] ushort* IEPGMPENFMI, int HCEIPJNIFCF);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class ENMFHBMEGBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x631D5C0", Offset = "0x631C5C0", VA = "0x18631D5C0")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x631D210", Offset = "0x631C210", VA = "0x18631D210")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x631D6F0", Offset = "0x631C6F0", VA = "0x18631D6F0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x631D370", Offset = "0x631C370", VA = "0x18631D370")]
		public unsafe static void HEGHDPNDHOB(float3* HBGHEFMMLDM, [In] ushort* IEPGMPENFMI, int HCEIPJNIFCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public unsafe delegate void GMPAJBIEDCC(ushort* MFABCKLMLNE, [Out] float2 MFFBJAEPGCG, [Out] float2 LAPDMPAFKJD, [In] float2* BPOJMFODFOB, int EAKEOBCAPOE, int AALFLLNNAPO);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class HGNELKLJLIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x631FE90", Offset = "0x631EE90", VA = "0x18631FE90")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x631FB10", Offset = "0x631EB10", VA = "0x18631FB10")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x631FFC0", Offset = "0x631EFC0", VA = "0x18631FFC0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x631FC70", Offset = "0x631EC70", VA = "0x18631FC70")]
		public unsafe static void HEGHDPNDHOB(ushort* MFABCKLMLNE, [Out] float2 MFFBJAEPGCG, [Out] float2 LAPDMPAFKJD, [In] float2* BPOJMFODFOB, int EAKEOBCAPOE, int AALFLLNNAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void DAHFPCJACEM([Out] float2 LMKLFONCAPK, ushort GAPFDNNCMEB, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class KLAPIHKFLJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6326460", Offset = "0x6325460", VA = "0x186326460")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63260C0", Offset = "0x63250C0", VA = "0x1863260C0")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6326590", Offset = "0x6325590", VA = "0x186326590")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6326220", Offset = "0x6325220", VA = "0x186326220")]
		public static void HEGHDPNDHOB([Out] float2 LMKLFONCAPK, ushort GAPFDNNCMEB, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public unsafe delegate void CJCBIOAKPOH(float2* MFABCKLMLNE, ushort* BPOJMFODFOB, int HCEIPJNIFCF, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class IHEODBGPMNO
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63224A0", Offset = "0x63214A0", VA = "0x1863224A0")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63220B0", Offset = "0x63210B0", VA = "0x1863220B0")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63225D0", Offset = "0x63215D0", VA = "0x1863225D0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6322210", Offset = "0x6321210", VA = "0x186322210")]
		public unsafe static void HEGHDPNDHOB(float2* MFABCKLMLNE, ushort* BPOJMFODFOB, int HCEIPJNIFCF, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public unsafe delegate void HKPADNCJFCL(ushort* PNJALANPADM, [In] float4* BJIBIOEBABD, int EAKEOBCAPOE, int AALFLLNNAPO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class LKJJINIOAMO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6326F70", Offset = "0x6325F70", VA = "0x186326F70")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6326BC0", Offset = "0x6325BC0", VA = "0x186326BC0")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63270A0", Offset = "0x63260A0", VA = "0x1863270A0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6326D20", Offset = "0x6325D20", VA = "0x186326D20")]
		public unsafe static void HEGHDPNDHOB(ushort* PNJALANPADM, [In] float4* BJIBIOEBABD, int EAKEOBCAPOE, int AALFLLNNAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate ushort MDAFBBNDLGP([In] float4 KDJMADAHCJG);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class MMAIFBDIGNA
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6327BE0", Offset = "0x6326BE0", VA = "0x186327BE0")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6327870", Offset = "0x6326870", VA = "0x186327870")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6327D10", Offset = "0x6326D10", VA = "0x186327D10")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63279D0", Offset = "0x63269D0", VA = "0x1863279D0")]
		public static ushort HEGHDPNDHOB([In] float4 KDJMADAHCJG)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public unsafe delegate void GGBBOIEMJPJ(float4* PNJALANPADM, [In] ushort* CCCGLOAKIDL, int HCEIPJNIFCF);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class HBOGELCFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x631F7E0", Offset = "0x631E7E0", VA = "0x18631F7E0")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x631F430", Offset = "0x631E430", VA = "0x18631F430")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x631F910", Offset = "0x631E910", VA = "0x18631F910")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x631F590", Offset = "0x631E590", VA = "0x18631F590")]
		public unsafe static void HEGHDPNDHOB(float4* PNJALANPADM, [In] ushort* CCCGLOAKIDL, int HCEIPJNIFCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void JDKLOLEGLIK([Out] float4 NIKEINPNLMA, ushort GAPFDNNCMEB);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class ICNCGEBMGNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6321D40", Offset = "0x6320D40", VA = "0x186321D40")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6321960", Offset = "0x6320960", VA = "0x186321960")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6321E70", Offset = "0x6320E70", VA = "0x186321E70")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6321AC0", Offset = "0x6320AC0", VA = "0x186321AC0")]
		public static void HEGHDPNDHOB([Out] float4 NIKEINPNLMA, ushort GAPFDNNCMEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public unsafe delegate void MJLLCDCFJHL(float4* EMEDCAMLLFE, byte* JNJHOMLKCKL, [Out] int CGOMFKHONNG, [Out] int OHLFGIEOKED, float4* BGCENDIDOKG, int EAKEOBCAPOE, int AALFLLNNAPO);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class JHLDMCGCKEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6322F60", Offset = "0x6321F60", VA = "0x186322F60")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6322BE0", Offset = "0x6321BE0", VA = "0x186322BE0")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6323090", Offset = "0x6322090", VA = "0x186323090")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6322D40", Offset = "0x6321D40", VA = "0x186322D40")]
		public unsafe static void HEGHDPNDHOB(float4* EMEDCAMLLFE, byte* JNJHOMLKCKL, [Out] int CGOMFKHONNG, [Out] int OHLFGIEOKED, float4* BGCENDIDOKG, int EAKEOBCAPOE, int AALFLLNNAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public unsafe delegate void AJKMEICCNEP(float4* NAOOJIDNKFP, [In] ALCKMHDKPGJ* BFMIAAGKDCA, [In] byte* INLNJGPKCMH, int HCEIPJNIFCF);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class MENPFBKPPCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6327590", Offset = "0x6326590", VA = "0x186327590")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6327150", Offset = "0x6326150", VA = "0x186327150")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63276C0", Offset = "0x63266C0", VA = "0x1863276C0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x63272B0", Offset = "0x63262B0", VA = "0x1863272B0")]
		public unsafe static void HEGHDPNDHOB(float4* NAOOJIDNKFP, [In] ALCKMHDKPGJ* BFMIAAGKDCA, [In] byte* INLNJGPKCMH, int HCEIPJNIFCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public unsafe delegate int GCNCAHMFDNK(byte* NGLGALFCPHE, [In] int* JECIIFGGLIC, int KNHNKGBPJOJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class PGNGDAPLEII
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6329050", Offset = "0x6328050", VA = "0x186329050")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6328C70", Offset = "0x6327C70", VA = "0x186328C70")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6329180", Offset = "0x6328180", VA = "0x186329180")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6328DD0", Offset = "0x6327DD0", VA = "0x186328DD0")]
		public unsafe static int HEGHDPNDHOB(byte* NGLGALFCPHE, [In] int* JECIIFGGLIC, int KNHNKGBPJOJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public unsafe delegate void CFCDMBEKNAM(int* LBOGAHCBDGP, [In] byte* BENOEGPBNMH, int GCMPHABKKFN);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class KNOGLNIGJGG
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x63269E0", Offset = "0x63259E0", VA = "0x1863269E0")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6326640", Offset = "0x6325640", VA = "0x186326640")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6326B10", Offset = "0x6325B10", VA = "0x186326B10")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x63267A0", Offset = "0x63257A0", VA = "0x1863267A0")]
		public unsafe static void HEGHDPNDHOB(int* LBOGAHCBDGP, [In] byte* BENOEGPBNMH, int GCMPHABKKFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void HFOOEKIKIKJ([Out] float3 LMKLFONCAPK, ushort GAPFDNNCMEB);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class HAHAOEAAOGL
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x631F250", Offset = "0x631E250", VA = "0x18631F250")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x631ED90", Offset = "0x631DD90", VA = "0x18631ED90")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x631F380", Offset = "0x631E380", VA = "0x18631F380")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x631EEF0", Offset = "0x631DEF0", VA = "0x18631EEF0")]
		public static void HEGHDPNDHOB([Out] float3 LMKLFONCAPK, ushort GAPFDNNCMEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate ushort AFMMOMFEOKH([In] float3 KDJMADAHCJG);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class BCOAAHPALNI
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr BNEFDAPPAAK;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr MAAMPHNKFLM;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x630DB70", Offset = "0x630CB70", VA = "0x18630DB70")]
		[BurstDiscard]
		private static void JDAEMMLPNCF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x630D840", Offset = "0x630C840", VA = "0x18630D840")]
		private static IntPtr HAMBGLFINKC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x630DCA0", Offset = "0x630CCA0", VA = "0x18630DCA0")]
		public static void PCAEMPHAMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public static void CJMKLAKCCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x630D9A0", Offset = "0x630C9A0", VA = "0x18630D9A0")]
		public static ushort HEGHDPNDHOB([In] float3 KDJMADAHCJG)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HCEIPJNIFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int GCMPHABKKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> BFLKELODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> BHLPJPCBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> MIMPMODPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MMPFNDBFCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<ALCKMHDKPGJ> IAAJPIGMMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> DGGNDKIKNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> IAJKHAFODFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 MBAIPJNOJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 HKIPLGGBHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 CBHMCPOPAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 LAPDMPAFKJD;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long HHDIBKJKOHK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long MHIJCEKKIMP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float OJFJJJEJNNG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool ECOHPJJMIHO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IKBGFLFIDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6316D80", Offset = "0x6315D80", VA = "0x186316D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6317220", Offset = "0x6316220", VA = "0x186317220")]
	public void BPEPGBDJLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6317F10", Offset = "0x6316F10", VA = "0x186317F10")]
	public static BJOHFBLIEOJ EOFBBDOECDH(Allocator NFBFCGHLHAF, DGFJOPHFDKD NDAEGKCECGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6317A40", Offset = "0x6316A40", VA = "0x186317A40")]
	public static BJOHFBLIEOJ EOFBBDOECDH(Allocator NFBFCGHLHAF, NativeArray<float3> IKHDBECAPJG, NativeArray<float3> IEPGMPENFMI, NativeArray<float2> BPOJMFODFOB, NativeArray<float4> BGCENDIDOKG, bool KEKLKFIFHKO, NativeArray<float4> CCCGLOAKIDL, NativeArray<int> JECIIFGGLIC, int HCEIPJNIFCF, int MKCHPONFCAK, int GCMPHABKKFN, int EAKEOBCAPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6319070", Offset = "0x6318070", VA = "0x186319070")]
	public DGFJOPHFDKD KNMNCPCDPGD(Allocator NFBFCGHLHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6318DF0", Offset = "0x6317DF0", VA = "0x186318DF0")]
	public void JNBFFIICPHN(Mesh GCFMCPMBPPI, bool KCBHHOAEAPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x631A510", Offset = "0x6319510", VA = "0x18631A510")]
	public long NLHKNLFBANJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6318B80", Offset = "0x6317B80", VA = "0x186318B80")]
	public static long JBLIGINPIMK(int MDKNALJOBHA, int JOMJLLLDKGP, bool NKJMEAJOCML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6318AF0", Offset = "0x6317AF0", VA = "0x186318AF0")]
	public long JBLIGINPIMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63177A0", Offset = "0x63167A0", VA = "0x1863177A0")]
	private void ECGMOLAFJIH(int MCEBDAHGEAA, int AALFLLNNAPO, Allocator NFBFCGHLHAF, bool CPLGHLCHKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6318CF0", Offset = "0x6317CF0", VA = "0x186318CF0")]
	private void JMIBODKMLIJ(NativeArray<float3> HJPNJEADEPH, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6318C70", Offset = "0x6317C70", VA = "0x186318C70")]
	[BurstCompile]
	private unsafe static void JMIBODKMLIJ(float3* HJPNJEADEPH, [In] ushort* IKHDBECAPJG, int HCEIPJNIFCF, [In] float3 MBAIPJNOJDN, [In] float3 HKIPLGGBHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6317440", Offset = "0x6316440", VA = "0x186317440")]
	private void DIAKHMJONMA(NativeArray<float3> IKHDBECAPJG, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6317540", Offset = "0x6316540", VA = "0x186317540")]
	[BurstCompile]
	private unsafe static void DIAKHMJONMA(ushort* HJPNJEADEPH, [Out] float3 EIMNNJGDGBP, [Out] float3 HKIPLGGBHEE, [In] float3* IKHDBECAPJG, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6318420", Offset = "0x6317420", VA = "0x186318420")]
	private void GHOGPLKCLKD(NativeArray<float3> IEPGMPENFMI, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63184E0", Offset = "0x63174E0", VA = "0x1863184E0")]
	[BurstCompile]
	private unsafe static void GHOGPLKCLKD(ushort* OOJDNBGBMAF, [In] float3* IEPGMPENFMI, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63170E0", Offset = "0x63160E0", VA = "0x1863170E0")]
	private void BDBHIEFKHNH(NativeArray<float3> HBGHEFMMLDM, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63171B0", Offset = "0x63161B0", VA = "0x1863171B0")]
	[BurstCompile]
	private unsafe static void BDBHIEFKHNH(float3* HBGHEFMMLDM, [In] ushort* IEPGMPENFMI, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6316DC0", Offset = "0x6315DC0", VA = "0x186316DC0")]
	private void BAGOCCOGDBD(NativeArray<float2> BPOJMFODFOB, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6316E90", Offset = "0x6315E90", VA = "0x186316E90")]
	[BurstCompile]
	private unsafe static void BAGOCCOGDBD(ushort* MFABCKLMLNE, [Out] float2 MFFBJAEPGCG, [Out] float2 LAPDMPAFKJD, [In] float2* BPOJMFODFOB, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6317320", Offset = "0x6316320", VA = "0x186317320")]
	[BurstCompile]
	private static void CFIJJPPFOPH([Out] float2 LMKLFONCAPK, ushort GAPFDNNCMEB, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6317620", Offset = "0x6316620", VA = "0x186317620")]
	private void DLGDNPNDJFK(NativeArray<float2> MFABCKLMLNE, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6317720", Offset = "0x6316720", VA = "0x186317720")]
	[BurstCompile]
	private unsafe static void DLGDNPNDJFK(float2* MFABCKLMLNE, ushort* BPOJMFODFOB, int HCEIPJNIFCF, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6319850", Offset = "0x6318850", VA = "0x186319850")]
	private void LJGGENLCMLP(NativeArray<float4> CCCGLOAKIDL, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6319940", Offset = "0x6318940", VA = "0x186319940")]
	[BurstCompile]
	private unsafe static void LJGGENLCMLP(ushort* PNJALANPADM, [In] float4* BJIBIOEBABD, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6318290", Offset = "0x6317290", VA = "0x186318290")]
	[BurstCompile]
	private static ushort FMFNOBPCKEN([In] float4 KDJMADAHCJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6318150", Offset = "0x6317150", VA = "0x186318150")]
	private void FAPIGEHBPOF(NativeArray<float4> PNJALANPADM, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6318220", Offset = "0x6317220", VA = "0x186318220")]
	[BurstCompile]
	private unsafe static void FAPIGEHBPOF(float4* PNJALANPADM, [In] ushort* CCCGLOAKIDL, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x631A4B0", Offset = "0x63194B0", VA = "0x18631A4B0")]
	[BurstCompile]
	private static void NDEAHLPBPOC([Out] float4 NIKEINPNLMA, ushort GAPFDNNCMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x631A0D0", Offset = "0x63190D0", VA = "0x18631A0D0")]
	private void MLPELAANMMH(Allocator NFBFCGHLHAF, NativeArray<float4> BGCENDIDOKG, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6319E80", Offset = "0x6318E80", VA = "0x186319E80")]
	[BurstCompile]
	private unsafe static void MLPELAANMMH(float4* EMEDCAMLLFE, byte* JNJHOMLKCKL, [Out] int CGOMFKHONNG, [Out] int OHLFGIEOKED, float4* BGCENDIDOKG, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6317930", Offset = "0x6316930", VA = "0x186317930")]
	private static void EGAGPFLMDPF(NativeArray<float4> NAOOJIDNKFP, NativeArray<ALCKMHDKPGJ> BFMIAAGKDCA, NativeArray<byte> INLNJGPKCMH, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63178B0", Offset = "0x63168B0", VA = "0x1863178B0")]
	[BurstCompile]
	private unsafe static void EGAGPFLMDPF(float4* NAOOJIDNKFP, [In] ALCKMHDKPGJ* BFMIAAGKDCA, [In] byte* INLNJGPKCMH, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6318F90", Offset = "0x6317F90", VA = "0x186318F90")]
	private void KDIHNIOCHII(Allocator NFBFCGHLHAF, NativeArray<int> JECIIFGGLIC, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63199C0", Offset = "0x63189C0", VA = "0x1863199C0")]
	private static NativeArray<byte> LKDOAKMLAJN(Allocator NFBFCGHLHAF, NativeArray<int> JECIIFGGLIC, int KNHNKGBPJOJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6319C30", Offset = "0x6318C30", VA = "0x186319C30")]
	[BurstCompile]
	private unsafe static int LKDOAKMLAJN(byte* NGLGALFCPHE, [In] int* JECIIFGGLIC, int KNHNKGBPJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6319650", Offset = "0x6318650", VA = "0x186319650")]
	private static void LAPBNHLJEJF(NativeArray<int> LBOGAHCBDGP, NativeArray<byte> BENOEGPBNMH, int GCMPHABKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6319720", Offset = "0x6318720", VA = "0x186319720")]
	[BurstCompile]
	private unsafe static void LAPBNHLJEJF(int* LBOGAHCBDGP, [In] byte* BENOEGPBNMH, int GCMPHABKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6318ED0", Offset = "0x6317ED0", VA = "0x186318ED0")]
	[BurstCompile]
	private static void JODGMDMABJN([Out] float3 LMKLFONCAPK, ushort GAPFDNNCMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6318700", Offset = "0x6317700", VA = "0x186318700")]
	[BurstCompile]
	private static ushort GMEOLAGFAAD([In] float3 KDJMADAHCJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public BJOHFBLIEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x630B9D0", Offset = "0x630A9D0", VA = "0x18630B9D0")]
	[BurstCompile]
	public unsafe static void PAKEGBOPMME(float3* HJPNJEADEPH, [In] ushort* IKHDBECAPJG, int HCEIPJNIFCF, [In] float3 MBAIPJNOJDN, [In] float3 HKIPLGGBHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x630AFB0", Offset = "0x6309FB0", VA = "0x18630AFB0")]
	[BurstCompile]
	public unsafe static void FJBBNFHKCOE(ushort* HJPNJEADEPH, [Out] float3 EIMNNJGDGBP, [Out] float3 HKIPLGGBHEE, [In] float3* IKHDBECAPJG, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x630AD50", Offset = "0x6309D50", VA = "0x18630AD50")]
	[BurstCompile]
	public unsafe static void BMFGMFLAEPH(ushort* OOJDNBGBMAF, [In] float3* IEPGMPENFMI, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6318A50", Offset = "0x6317A50", VA = "0x186318A50")]
	[BurstCompile]
	public unsafe static void IPBPDFCMMHP(float3* HBGHEFMMLDM, [In] ushort* IEPGMPENFMI, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x630B550", Offset = "0x630A550", VA = "0x18630B550")]
	[BurstCompile]
	public unsafe static void MCFGBCEOFAP(ushort* MFABCKLMLNE, [Out] float2 MFFBJAEPGCG, [Out] float2 LAPDMPAFKJD, [In] float2* BPOJMFODFOB, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63175D0", Offset = "0x63165D0", VA = "0x1863175D0")]
	[BurstCompile]
	public static void DLFMPOOPDON([Out] float2 LMKLFONCAPK, ushort GAPFDNNCMEB, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6319DA0", Offset = "0x6318DA0", VA = "0x186319DA0")]
	[BurstCompile]
	public unsafe static void MJBNIDJILIO(float2* MFABCKLMLNE, ushort* BPOJMFODFOB, int HCEIPJNIFCF, [In] float2 CBHMCPOPAOO, [In] float2 LAPDMPAFKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6318BD0", Offset = "0x6317BD0", VA = "0x186318BD0")]
	[BurstCompile]
	public unsafe static void JFLKPGOLPDE(ushort* PNJALANPADM, [In] float4* BJIBIOEBABD, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6318F30", Offset = "0x6317F30", VA = "0x186318F30")]
	[BurstCompile]
	public static ushort KADENOPMACD([In] float4 KDJMADAHCJG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63173A0", Offset = "0x63163A0", VA = "0x1863173A0")]
	[BurstCompile]
	public unsafe static void CKNEBLGPMFP(float4* PNJALANPADM, [In] ushort* CCCGLOAKIDL, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6319790", Offset = "0x6318790", VA = "0x186319790")]
	[BurstCompile]
	public static void LFLKBMNLBOI([Out] float4 NIKEINPNLMA, ushort GAPFDNNCMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x630B390", Offset = "0x630A390", VA = "0x18630B390")]
	[BurstCompile]
	public unsafe static void LDGOBENADBH(float4* EMEDCAMLLFE, byte* JNJHOMLKCKL, [Out] int CGOMFKHONNG, [Out] int OHLFGIEOKED, float4* BGCENDIDOKG, int EAKEOBCAPOE, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63182E0", Offset = "0x63172E0", VA = "0x1863182E0")]
	[BurstCompile]
	public unsafe static void GHNBNJFLENM(float4* NAOOJIDNKFP, [In] ALCKMHDKPGJ* BFMIAAGKDCA, [In] byte* INLNJGPKCMH, int HCEIPJNIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6319CA0", Offset = "0x6318CA0", VA = "0x186319CA0")]
	[BurstCompile]
	public unsafe static int MGDFHPKJFAC(byte* NGLGALFCPHE, [In] int* JECIIFGGLIC, int KNHNKGBPJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x631A5A0", Offset = "0x63195A0", VA = "0x18631A5A0")]
	[BurstCompile]
	public unsafe static void NNOJCHMJCGM(int* LBOGAHCBDGP, [In] byte* BENOEGPBNMH, int GCMPHABKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6318910", Offset = "0x6317910", VA = "0x186318910")]
	[BurstCompile]
	public static void IMPFDFEFOGI([Out] float3 LMKLFONCAPK, ushort GAPFDNNCMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x630B810", Offset = "0x630A810", VA = "0x18630B810")]
	[BurstCompile]
	public static ushort OOPKHOCCMMF([In] float3 KDJMADAHCJG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JMGJDKJFAIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float2 KDFBEAEDFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float2 DDDAMLFHNGO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PJEAOINBMBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<JMGJDKJFAIM> GMDBCDMJDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<int> GJFLOPGAEAK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MBGNDOMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JBHPFBFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D80", Offset = "0x7C1D80", VA = "0x1807C2D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6329370", Offset = "0x6328370", VA = "0x186329370")]
	public PJEAOINBMBN(int MCEBDAHGEAA, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6329230", Offset = "0x6328230", VA = "0x186329230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6329290", Offset = "0x6328290", VA = "0x186329290")]
	public void GAKNFFKFOCL(PJEAOINBMBN GEKDBODGFEN, int PPDNOOAOCHM, int GOABEOHPNBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AEKGPNLLIEE
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static PJEAOINBMBN NMGIGLPBMCD;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static NativeList<DBMLFEEMNMK> MJIHBPPDFNG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static int[] OFANDFLABCI;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static bool BKIMNIOLPIC;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, PJEAOINBMBN> CKBMIKIEKBL;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, PJEAOINBMBN> AHJDHELIDLA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool ADEHALOHEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x630CBC0", Offset = "0x630BBC0", VA = "0x18630CBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<DBMLFEEMNMK> HGBAIKJNONL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x630D030", Offset = "0x630C030", VA = "0x18630D030")]
		get
		{
			return default(NativeList<DBMLFEEMNMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static PJEAOINBMBN BCNKMKJCDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x630CAE0", Offset = "0x630BAE0", VA = "0x18630CAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x630C170", Offset = "0x630B170", VA = "0x18630C170")]
	private static void GMJOBFPBJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x630CB90", Offset = "0x630BB90", VA = "0x18630CB90")]
	public static int KPIKKOEHGHI(bool EIPAENCBFNL, int OJDGNDANPAF, bool KKBPFODGLIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x630CC40", Offset = "0x630BC40", VA = "0x18630CC40")]
	private static int LHNNMJCDIOO(int OJDGNDANPAF, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x630CB80", Offset = "0x630BB80", VA = "0x18630CB80")]
	private static int KJEAMHEJANM(int OJDGNDANPAF, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x630CA30", Offset = "0x630BA30", VA = "0x18630CA30")]
	public static int IJFIIPIOJEA(int ODIANCNJLNI, int OJDGNDANPAF, int ADHPFNMNIAL, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x630BF60", Offset = "0x630AF60", VA = "0x18630BF60")]
	public static int CCCIPNJNBOL(int ODIANCNJLNI, int OJDGNDANPAF, int ADHPFNMNIAL, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x630C0E0", Offset = "0x630B0E0", VA = "0x18630C0E0")]
	public static int EOCOBBLFLEK(int ADHPFNMNIAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x630C160", Offset = "0x630B160", VA = "0x18630C160")]
	private static int GCPIJBEHNBO(int OJDGNDANPAF, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x630CA10", Offset = "0x630BA10", VA = "0x18630CA10")]
	private static int HBLNNGPOLGK(int OJDGNDANPAF, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x630C0F0", Offset = "0x630B0F0", VA = "0x18630C0F0")]
	public static int EPEILFHDKEH(int ODIANCNJLNI, int OJDGNDANPAF, int ADHPFNMNIAL, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x630CFA0", Offset = "0x630BFA0", VA = "0x18630CFA0")]
	public static int NEHKOAAALKJ(int ODIANCNJLNI, int OJDGNDANPAF, int ADHPFNMNIAL, bool GGKNOMONEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x630CAC0", Offset = "0x630BAC0", VA = "0x18630CAC0")]
	public static int IOMHHGILPPH(int ADHPFNMNIAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x630BFF0", Offset = "0x630AFF0", VA = "0x18630BFF0")]
	public static PJEAOINBMBN CLMDCGPHLHO(int OJDGNDANPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x630C780", Offset = "0x630B780", VA = "0x18630C780")]
	private static PJEAOINBMBN GMPONLOHHPF(int OJDGNDANPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x630D0D0", Offset = "0x630C0D0", VA = "0x18630D0D0")]
	public static PJEAOINBMBN OBKBDOLAKDC(int OJDGNDANPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x630CC60", Offset = "0x630BC60", VA = "0x18630CC60")]
	private static PJEAOINBMBN NCDLDGFPKJH(int OJDGNDANPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x630D1C0", Offset = "0x630C1C0", VA = "0x18630D1C0")]
	public static void PPDGMOAGCLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JMKLODJOJJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int DKIAHLEIHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 IPGHPIGCODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion EJMOEECNDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float LFBBLFJLFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float NLPPMNGEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int CEALGPHFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int FBIBJOLBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int KFLJOFFLDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool LAKNOMAMJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool GEJKACIINPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float BMDLHMKDBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 GAEPBAOBIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool HMAMCHJNHJB;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CKDPDHMFPFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int OBNJDHEEKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int FAFEOPHPEPH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ODAPPGGCAHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeList<JMKLODJOJJL> MNMELJKENDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeArray<CCLJNANFHKL> HLCMOBLCLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<DBMLFEEMNMK> DKBCPHHOIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<CKDPDHMFPFI> CMOGKMLAJGG;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x63285F0", Offset = "0x63275F0", VA = "0x1863285F0")]
	public ODAPPGGCAHC(NativeArray<CCLJNANFHKL> HLCMOBLCLHL, int GFFAGBDKDAI = 1, Allocator NFBFCGHLHAF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6328500", Offset = "0x6327500", VA = "0x186328500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
public struct JJEOLLMCIEE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<JMGJDKJFAIM> JHNLBPGBJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<int> ILMLFLPJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeList<DBMLFEEMNMK> DCOJHKKLPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<JMKLODJOJJL> MNMELJKENDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<CCLJNANFHKL> HLCMOBLCLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<DBMLFEEMNMK> DKBCPHHOIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<CKDPDHMFPFI> CMOGKMLAJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private int INDLLKDFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int MBFCIAHMBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float3 CLAEHADDGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private quaternion ILEELMFAEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 ELEEJCMGLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LAKOPDBGNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CLALMMGLGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DNEFDCEFFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BFHOMOCIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> HCMJBIJIFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> GFHBBNJLGMI;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x63250C0", Offset = "0x63240C0", VA = "0x1863250C0")]
	public JJEOLLMCIEE(BHBGCKFONGN GBPOHELEJGN, DGFJOPHFDKD GEFIBDBCOMG, float3 AHDBMOJDHEI, quaternion KJKNCAGADGI, float IPODDIHIMKJ, int AMCDNACOBFM = 0, int PJDGEIPHOPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6325350", Offset = "0x6324350", VA = "0x186325350")]
	public JJEOLLMCIEE(ODAPPGGCAHC GBPOHELEJGN, DGFJOPHFDKD GEFIBDBCOMG, float3 AHDBMOJDHEI, quaternion KJKNCAGADGI, float3 IPODDIHIMKJ, int AMCDNACOBFM = 0, int PJDGEIPHOPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6324F90", Offset = "0x6323F90", VA = "0x186324F90")]
	private float3 MDLGHCKOFJK(float3 GMBCFMGIFKM, Matrix4x4 DEDEIEFLLGA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x63232B0", Offset = "0x63222B0", VA = "0x1863232B0")]
	private float3x3 EPCECNHDKEC(float3x3 FBJILLJPMDH, float3x3 PJIBFJAJONB)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x63244D0", Offset = "0x63234D0", VA = "0x1863244D0")]
	private float FNOFOMCNPDK(float GJBNAOHDFNK, float NCLGAIHJNCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6323330", Offset = "0x6322330", VA = "0x186323330", Slot = "4")]
	public void Execute(int MNONMOOEFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6323140", Offset = "0x6322140", VA = "0x186323140")]
	private void DKNPMJPILOE(int EIGACJLHFLF, float3 BJIKBOECFPB, float3 KMBEHGBELJC, float3 JIANBIILENJ, float LIIEEBDEIFN, bool AKGLCHIJIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x63244E0", Offset = "0x63234E0", VA = "0x1863244E0")]
	private void HIFINCIIPIF(JMKLODJOJJL GIKCNLEJMFL, float3 PDJLKPJAKEO, float3x3 DGBIMPLNOFD, float GJBNAOHDFNK, int KBDCBNIENPE, int NKMLCPDMLHA, int BDAFOGODOCA, float NOECACKDCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6324940", Offset = "0x6323940", VA = "0x186324940")]
	private void JIJOPBFHMKI(int EIGACJLHFLF, int FGIJLDPEIDM, JMKLODJOJJL GIKCNLEJMFL, float3 PDJLKPJAKEO, float3x3 DGBIMPLNOFD, bool ONCHGLNEFJC, float GJBNAOHDFNK, int GJLNLKFGGPA, int JEMFIBKCGJL, int BDAFOGODOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IFINPEJLMPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeList<KHJELJCLKIP> NKNECEEAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeList<DBMLFEEMNMK> PAGEJDGLDIK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6321FC0", Offset = "0x6320FC0", VA = "0x186321FC0")]
	public IFINPEJLMPD(int GFFAGBDKDAI, Allocator NFBFCGHLHAF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6321F20", Offset = "0x6320F20", VA = "0x186321F20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
public struct HKKODBDHMKC : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private enum NENPELPCOHN
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
	private NativeList<float3> LCJBJPFPBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float3> GKFPEKAPJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeList<int> DGJMANOPKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeArray<int> IKIHGAJGJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeArray<float4> DFGAKKPIPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeArray<float4> PFCGLEFMEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<float4> KECNKOJLOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<float3> CNAJDEBODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private NativeList<DBMLFEEMNMK> MOELHJIOAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private NativeList<KHJELJCLKIP> NKNECEEAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private NativeList<DBMLFEEMNMK> PAGEJDGLDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private int INDLLKDFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private int MBFCIAHMBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LAKOPDBGNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CLALMMGLGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DNEFDCEFFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BFHOMOCIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> HCMJBIJIFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> GFHBBNJLGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private float3 ELEEJCMGLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private quaternion ILEELMFAEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 CLAEHADDGLF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6321670", Offset = "0x6320670", VA = "0x186321670")]
	public HKKODBDHMKC(BHBGCKFONGN GBPOHELEJGN, DGFJOPHFDKD GEFIBDBCOMG, float3 AHDBMOJDHEI, quaternion KJKNCAGADGI, float IPODDIHIMKJ, int AMCDNACOBFM = 0, int PJDGEIPHOPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6321480", Offset = "0x6320480", VA = "0x186321480")]
	public HKKODBDHMKC(IFINPEJLMPD GPKMLHOONCL, DGFJOPHFDKD GEFIBDBCOMG, float3 AHDBMOJDHEI, quaternion KJKNCAGADGI, float3 IPODDIHIMKJ, int AMCDNACOBFM = 0, int PJDGEIPHOPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6320070", Offset = "0x631F070", VA = "0x186320070", Slot = "4")]
	public void Execute(int MNONMOOEFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x63210D0", Offset = "0x63200D0", VA = "0x1863210D0")]
	private void OONDMBKKLOI(float4x4 GDACFBIFECH, int MNONMOOEFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6320FD0", Offset = "0x631FFD0", VA = "0x186320FD0")]
	private NENPELPCOHN LEFLNBKIGIN(float3 KMBEHGBELJC)
	{
		return default(NENPELPCOHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6321040", Offset = "0x6320040", VA = "0x186321040")]
	private float4 LLENGPBGAFN(NENPELPCOHN NLDGLLBFPKI, int GPEHCABDGEJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6321090", Offset = "0x6320090", VA = "0x186321090")]
	private float2 ODJAGHCIPKF(NENPELPCOHN NLDGLLBFPKI, float3 BJIKBOECFPB)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EMBIBKIMIMH
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum AJMICPCCBOO
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static EMBIBKIMIMH LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float3 IGEPLDPOGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3x3 FOPINBOOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 BMODBHJLIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public AJMICPCCBOO PFOKGBDCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 AIPPDGOLMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 EEJMFHAIHMJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x631CFC0", Offset = "0x631BFC0", VA = "0x18631CFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 MMJFEJFPKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x631CFD0", Offset = "0x631BFD0", VA = "0x18631CFD0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x631D120", Offset = "0x631C120", VA = "0x18631D120")]
	public EMBIBKIMIMH(float3 BJIKBOECFPB, quaternion CKCOAEGKOKA, float3 GFFAGBDKDAI, AJMICPCCBOO KBCNAJKPHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x631CB20", Offset = "0x631BB20", VA = "0x18631CB20")]
	public float HNBKKAHDEGO(float3 PDJLKPJAKEO, float ACJNIEJFGGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x631CD20", Offset = "0x631BD20", VA = "0x18631CD20")]
	public bool JPLBNLFHONH(float3 KMBEHGBELJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x631CE10", Offset = "0x631BE10", VA = "0x18631CE10")]
	public void MJCGAFJEAPN(float3 HOALFGNCMMM, float3x3 EFMLENILEMH, float ICPONPGJNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x631C790", Offset = "0x631B790", VA = "0x18631C790")]
	private void BCEBDIMIEJA(float3 FCJBPODALAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x631C890", Offset = "0x631B890", VA = "0x18631C890")]
	public void BPHHLIMCBAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
public struct KHMOPHDALGP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeList<EMBIBKIMIMH> GPKMLHOONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeList<float3> BFLKELODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<int> IAJKHAFODFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LMJPLEIFJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<DBMLFEEMNMK> PAGEJDGLDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private int LKJGLMOGGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int PGJLCEAHDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private float ACJNIEJFGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private float EMDKEHILCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GHLFDMHPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JEKMAFAEIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> ANHCLLGGJPM;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6326020", Offset = "0x6325020", VA = "0x186326020")]
	public KHMOPHDALGP(DGFJOPHFDKD GCFMCPMBPPI, float HPECDJFKJBC, int GOABEOHPNBP, int KBDCBNIENPE, NativeList<EMBIBKIMIMH> GPKMLHOONCL, NativeArray<int> LMJPLEIFJLB, NativeList<DBMLFEEMNMK> PAGEJDGLDIK, MMHMMEEICPE OJJOCHIHNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6325580", Offset = "0x6324580", VA = "0x186325580", Slot = "4")]
	public void Execute(int BLCIDPMBHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6325F60", Offset = "0x6324F60", VA = "0x186325F60")]
	private bool ILIBLILEOHD(EMBIBKIMIMH AAOIMEIMECG, EMBIBKIMIMH ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6325CC0", Offset = "0x6324CC0", VA = "0x186325CC0")]
	private bool HKFAGBAHAAK(EMBIBKIMIMH GEJPKFDIMAP, int PBDOPGNIGKJ, int ANDADCJJEAI, int OJBKMGGBDBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MMHMMEEICPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<bool> AHPBKNICJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<int> CGILLBGPIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<bool> JBMHJAPDHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float> KCBFFHKLMJC;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6327ED0", Offset = "0x6326ED0", VA = "0x186327ED0")]
	public void ECGMOLAFJIH(int MCEBDAHGEAA, int AALFLLNNAPO, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6327EB0", Offset = "0x6326EB0", VA = "0x186327EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6327DC0", Offset = "0x6326DC0", VA = "0x186327DC0")]
	public void BPEPGBDJLCI(JobHandle NFHOJLAMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public MMHMMEEICPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
public struct BFMMAEOIMAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NativeList<float3> BFLKELODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NativeArray<float3> BHLPJPCBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NativeArray<float4> IAAJPIGMMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeArray<float2> MMPFNDBFCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NativeList<int> IAJKHAFODFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MIMPMODPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<int> LEILEOMCGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeArray<bool> GHLFDMHPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<bool> JEKMAFAEIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private int AMCDNACOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private int PJDGEIPHOPG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6314FA0", Offset = "0x6313FA0", VA = "0x186314FA0")]
	public BFMMAEOIMAP(DGFJOPHFDKD GCFMCPMBPPI, MMHMMEEICPE OJJOCHIHNFK, int PJDGEIPHOPG = 0, int AMCDNACOBFM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6314BC0", Offset = "0x6313BC0", VA = "0x186314BC0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6314B60", Offset = "0x6313B60", VA = "0x186314B60")]
	private void BEAAIKLKEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class LLIBPEPIKPA
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2963F70", Offset = "0x2962F70", VA = "0x182963F70")]
	public static bool JHIGLKHJFPA<T>(NativeArray<T> PAFIMPMPKHD, int GFFAGBDKDAI, Allocator NFBFCGHLHAF, NativeArrayOptions CACELMJJEFC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2964010", Offset = "0x2963010", VA = "0x182964010")]
	public static bool JHIGLKHJFPA<T>(NativeList<T> FKIBLLNGEAG, int GFFAGBDKDAI, Allocator NFBFCGHLHAF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum MCIGCFAGBDP
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
public interface FAFAOJKPOLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PMCAHLHIGFI(MCIGCFAGBDP ODIANCNJLNI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IINCIJPHNJG(MCIGCFAGBDP ODIANCNJLNI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds IBGKEKPFGMA();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float MEDGMDGIGDJ();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILFKHDFMLLB(MCIGCFAGBDP ODIANCNJLNI, BHBGCKFONGN LKAHBEGEPCB, int KJCEELACJMM = -1);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DGFJOPHFDKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int COGGJABMOKH = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeList<float3> LEEMFAAGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NativeArray<float3> IOMGNNLNGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NativeArray<float4> BHMDEBPLKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeArray<float4> NOBILJEOBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeArray<float2> KAAGLCNLAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<int> DCKDPCFLICC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JEAENFCBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x631C1B0", Offset = "0x631B1B0", VA = "0x18631C1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MBGNDOMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x631B2F0", Offset = "0x631A2F0", VA = "0x18631B2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JBHPFBFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x631C1F0", Offset = "0x631B1F0", VA = "0x18631C1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IKBGFLFIDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x631AE70", Offset = "0x6319E70", VA = "0x18631AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x631B330", Offset = "0x631A330", VA = "0x18631B330", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x631B440", Offset = "0x631A440", VA = "0x18631B440")]
	public void ECGMOLAFJIH(int MCEBDAHGEAA, int AALFLLNNAPO, Allocator NFBFCGHLHAF, bool ENJFCLLKDEF, bool CPLGHLCHKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x631C130", Offset = "0x631B130", VA = "0x18631C130")]
	public void ONKMBHPGGIH(int MCEBDAHGEAA, int AALFLLNNAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x631AEB0", Offset = "0x6319EB0", VA = "0x18631AEB0", Slot = "6")]
	public bool AMBALANDBOI(Mesh GCFMCPMBPPI, bool KCBHHOAEAPL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x631B9C0", Offset = "0x631A9C0", VA = "0x18631B9C0")]
	public bool LHPMHFLNDFE(Mesh GCFMCPMBPPI, DGFJOPHFDKD EMIGMNGBNJG, bool KCBHHOAEAPL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x631B750", Offset = "0x631A750", VA = "0x18631B750")]
	public void GAKNFFKFOCL(DGFJOPHFDKD GCFMCPMBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x631B610", Offset = "0x631A610", VA = "0x18631B610")]
	public DGFJOPHFDKD FIOFIJAFHNC(Allocator NFBFCGHLHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x631BFF0", Offset = "0x631AFF0", VA = "0x18631BFF0")]
	public long NLHKNLFBANJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x631B290", Offset = "0x631A290", VA = "0x18631B290")]
	public void CBOABKKICKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DGFJOPHFDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HCCBOHAJPBG
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x631F9C0", Offset = "0x631E9C0", VA = "0x18631F9C0")]
	public static void PPDGMOAGCLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GNLPEFDMFKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<float3> LEEMFAAGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<float3> IOMGNNLNGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<int> ACIKFJPBGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<float4> GEOLNIGKAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<float4> NPMKEFAGCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float4> ENGAHKMJHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public NativeList<float3> AMOMGIKGCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public NativeList<int> DCKDPCFLICC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MBGNDOMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x631D9A0", Offset = "0x631C9A0", VA = "0x18631D9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JBHPFBFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x631E840", Offset = "0x631D840", VA = "0x18631E840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OEFENILBEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x631E370", Offset = "0x631D370", VA = "0x18631E370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x631EB70", Offset = "0x631DB70", VA = "0x18631EB70")]
	public GNLPEFDMFKE(int MCEBDAHGEAA, int AALFLLNNAPO, int DKNCGJOMIGP, Allocator NFBFCGHLHAF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x631E880", Offset = "0x631D880", VA = "0x18631E880")]
	public GNLPEFDMFKE(Mesh GCFMCPMBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x631D9E0", Offset = "0x631C9E0", VA = "0x18631D9E0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x631DAF0", Offset = "0x631CAF0", VA = "0x18631DAF0")]
	public void GAKNFFKFOCL(GNLPEFDMFKE GCFMCPMBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x631E3B0", Offset = "0x631D3B0", VA = "0x18631E3B0")]
	private void OOCJMMCGKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x631DDF0", Offset = "0x631CDF0", VA = "0x18631DDF0")]
	private void KDOOHFBPIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DBMLFEEMNMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public int AGELAHBENGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int MBGNDOMDJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int JAJBJEAOOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public int JBHPFBFMILD;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1275010", Offset = "0x1274010", VA = "0x181275010")]
	public DBMLFEEMNMK(int KBDCBNIENPE, int HCEIPJNIFCF, int GOABEOHPNBP, int GCMPHABKKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class CAEOOHCCFFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<DBMLFEEMNMK> IKOBIDDMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<DBMLFEEMNMK>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85AF30", Offset = "0x859F30", VA = "0x18085AF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GNLPEFDMFKE GFCDINIDGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x631A6B0", Offset = "0x63196B0", VA = "0x18631A6B0")]
	public CAEOOHCCFFL(IEnumerable<GNLPEFDMFKE> NAKPPOFFNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x631A640", Offset = "0x6319640", VA = "0x18631A640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum BOFFGGAFNHB
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DLKEOMPMFEA
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static NativeArray<float2> BIFOLCAFBHH;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NativeArray<float3> FJPMPJEOKIF;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static NativeArray<float4> FIJMAPGNGEO;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeArray<int> DHHKDIGJHBA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x631C670", Offset = "0x631B670", VA = "0x18631C670")]
	public static void PPDGMOAGCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x631C230", Offset = "0x631B230", VA = "0x18631C230")]
	public static NativeArray<float2> BFDDPKHGDED(NativeArray<float2> JHHNIOICPBD, int JNCOBMCCKJI, NativeArray<float2> BMHIJGLIMCF, int JMOECFOPKMH)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x631C560", Offset = "0x631B560", VA = "0x18631C560")]
	public static NativeArray<float3> LBNLAFILGGG(NativeArray<float3> JHHNIOICPBD, int JNCOBMCCKJI, NativeArray<float3> BMHIJGLIMCF, int JMOECFOPKMH)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x631C450", Offset = "0x631B450", VA = "0x18631C450")]
	public static NativeArray<float4> JKKCDFFAADI(NativeArray<float4> JHHNIOICPBD, int JNCOBMCCKJI, NativeArray<float4> BMHIJGLIMCF, int JMOECFOPKMH)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x631C340", Offset = "0x631B340", VA = "0x18631C340")]
	public static NativeArray<int> FIIPKNDEKJN(NativeArray<int> JHHNIOICPBD, int JNCOBMCCKJI, NativeArray<int> BMHIJGLIMCF, int JMOECFOPKMH)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2746560", Offset = "0x2745560", VA = "0x182746560")]
	private static void GOGADAEKCMB<T>(NativeArray<T> PAFIMPMPKHD, int GHOAMPJHMAA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2746760", Offset = "0x2745760", VA = "0x182746760")]
	private static void HBGPDHJIMAE<T>(NativeArray<T> JHHNIOICPBD, int JNCOBMCCKJI, NativeArray<T> BMHIJGLIMCF, int JMOECFOPKMH, NativeArray<T> DMHHIHBBCEO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DebuggerStepThrough]
public static class DJCDHNCBBBH
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public static void NAIIGBDNBCH(bool GEJMEMCGHEN, string NEBLPOPPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public static void NAIIGBDNBCH(bool GEJMEMCGHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BECFIKBKHON
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal enum OPGLMLPIAGG
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
	public class FBGMOLGBNAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BJOHFBLIEOJ GCFMCPMBPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int KOAKBPLHPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int ANHLJLCOOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long ALHEPLNHKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public long GNNHOCCJCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float ACDDOAOAPAL;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x632ED40", Offset = "0x632DD40", VA = "0x18632ED40")]
		public FBGMOLGBNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x632ED00", Offset = "0x632DD00", VA = "0x18632ED00")]
		public void BPEPGBDJLCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly string FJMLFBLOOEN;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly string BJLIMDICMOF;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker MNBADECMPCB;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker GEBHCBNJCEM;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker PHOKNIDJFIO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker LMFAKDHJKLG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker NLLHONOOCGM;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker OBNKOKBCNDB;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker OHEOBKNLKLD;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker KHIILOCCEHC;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker OIMPADOEEFG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker HBDFNMFIHKL;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker JJCAPCNKJCN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker LBCMNEKCENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<FAFAOJKPOLJ> APMPJCBODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly LGMKGIJNBAN KLNPHAMLGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int HCEIPJNIFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int GCMPHABKKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool CCIJCOIGNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	internal bool DKJAENLHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	internal OPGLMLPIAGG DKOKOEEPCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	internal bool KIDKIKKLBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal float3 EOCGOMGKOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal float3 EKPIHIGFKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal float IEJMJBPNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	internal float DFKIFBEKMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	internal int GNMHBEBBJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	internal int NJBFFODHCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int JDEGJMEKPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float BNAJEPADIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float MLNEALAEFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int HBGKDIHAKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long ELJCBDDCAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long OMDMJDEBCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private long JFGGFMCAMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int MDGIIGBJLKO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int FBFLGDFOCLC = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float[] KCJEFOGGBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int[] AKHMAFOFFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private long[] IBHHGIAPABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private DGFJOPHFDKD DPADJGMPGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private long MJHLCEPHPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private long MJFJAKMOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int FALDKNJBIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private List<FBGMOLGBNAM> GBGCHEJNPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	internal float HKALOILPGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool NKNLEPANBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private FKABAKGGACF DDGMGJFHBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JobHandle OEPNIPOOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal NativeArray<long> GIFGFPILPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool KJOEIDFMJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private JobHandle KNAOFMHBJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DGFJOPHFDKD JOLKFLDKEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Transform PMBMIPFINME;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GFCDINIDGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer LMNACMEADOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ELGBHBLOEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAE6B10", Offset = "0xAE5B10", VA = "0x180AE6B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MMMKBEJJFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7E7C50", Offset = "0x7E6C50", VA = "0x1807E7C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MBGNDOMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x630E2D0", Offset = "0x630D2D0", VA = "0x18630E2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<FAFAOJKPOLJ> MCIMAHIDPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6310710", Offset = "0x630F710", VA = "0x186310710")]
	public void GJDPJMFACKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6310D30", Offset = "0x630FD30", VA = "0x186310D30")]
	private void JDOEEMDBJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x63148A0", Offset = "0x63138A0", VA = "0x1863148A0")]
	public BECFIKBKHON(string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x630E1C0", Offset = "0x630D1C0", VA = "0x18630E1C0")]
	public void BPEPGBDJLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x63137F0", Offset = "0x63127F0", VA = "0x1863137F0")]
	public void OLIDAJJOKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x630F150", Offset = "0x630E150", VA = "0x18630F150")]
	private void DFNHBAPENGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6313880", Offset = "0x6312880", VA = "0x186313880")]
	public void OPJPFOEPONM(FAFAOJKPOLJ MMOCDCIIANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x630E2F0", Offset = "0x630D2F0", VA = "0x18630E2F0")]
	public bool CJKMPAHGMHO(FAFAOJKPOLJ MMOCDCIIANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6311700", Offset = "0x6310700", VA = "0x186311700")]
	public bool LFLBPCGHIFM(FAFAOJKPOLJ MMOCDCIIANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x630DFD0", Offset = "0x630CFD0", VA = "0x18630DFD0", Slot = "4")]
	public virtual void AIBPELBLHJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x630E080", Offset = "0x630D080", VA = "0x18630E080")]
	public void APHEMFMEPFK(Transform OCKHJMEPNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x63118D0", Offset = "0x63108D0", VA = "0x1863118D0")]
	public bool NCJFPGDKHKG(Transform OCKHJMEPNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x630E390", Offset = "0x630D390", VA = "0x18630E390")]
	public bool CLCPKNHCLPA(bool NJKONHDCLDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6313450", Offset = "0x6312450", VA = "0x186313450")]
	public void OBBJANDNDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6313990", Offset = "0x6312990", VA = "0x186313990")]
	public bool PANEJAADMBI(float4x4 IODAAENEAHL, BatchedMeshRenderer AEOBJBCAKAC, bool EINGGEDIPGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6310640", Offset = "0x630F640", VA = "0x186310640")]
	public void FMEACKHOLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x63135C0", Offset = "0x63125C0", VA = "0x1863135C0")]
	public bool OCBMKOKAIHG(bool NJKONHDCLDM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6313980", Offset = "0x6312980", VA = "0x186313980")]
	public void PALLHBBECMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x630F580", Offset = "0x630E580", VA = "0x18630F580")]
	public void EHCLEOFLJIP(DGFJOPHFDKD GCFMCPMBPPI, int JOJDNHHNLBM, float FMHHGBFNNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x63116D0", Offset = "0x63106D0", VA = "0x1863116D0")]
	public void KKOKOGLFADP(BJOHFBLIEOJ IFPEEBGNOEO, int JOJDNHHNLBM, float FMHHGBFNNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x63123E0", Offset = "0x63113E0", VA = "0x1863123E0")]
	public long NLHKNLFBANJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7B0", Offset = "0x7CA7B0", VA = "0x1807CB7B0")]
	public long PJEILADHANE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6311760", Offset = "0x6310760", VA = "0x186311760")]
	private void LFNJJPCJDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6310720", Offset = "0x630F720", VA = "0x186310720")]
	public (long, long) HIGNNEHLHOP(float NFEKEKNEFOJ, float4x4 IODAAENEAHL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xA8B980", Offset = "0xA8A980", VA = "0x180A8B980")]
	internal void MBPGJFDCKFJ(OPGLMLPIAGG OMCLCHALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6310F40", Offset = "0x630FF40", VA = "0x186310F40")]
	private (float, float, float) KFPGMNNPDFC(float PADPFAEJKJI, float4x4 IODAAENEAHL)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x630DD50", Offset = "0x630CD50", VA = "0x18630DD50")]
	private (int, int) AGCLPEAGIMJ(float LPEONKLOEDP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x63123F0", Offset = "0x63113F0", VA = "0x1863123F0")]
	public void OAEPFKJCKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6310F10", Offset = "0x630FF10", VA = "0x186310F10")]
	private void JONAIPHDPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x630F3C0", Offset = "0x630E3C0", VA = "0x18630F3C0")]
	private void EAIPDDGFDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x630F5B0", Offset = "0x630E5B0", VA = "0x18630F5B0")]
	private void EMINGIBPIIO(DGFJOPHFDKD CIBFKDLEDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6310AA0", Offset = "0x630FAA0", VA = "0x186310AA0")]
	private void IMFCCBOGGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x630FD40", Offset = "0x630ED40", VA = "0x18630FD40")]
	private void FKPDEEEENEH(DGFJOPHFDKD GCFMCPMBPPI, BJOHFBLIEOJ IFPEEBGNOEO, int JOJDNHHNLBM, float FMHHGBFNNDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[BurstCompile]
internal struct FKABAKGGACF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct EOFNBAJMHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int FELCAOEKOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int PLCOEPBJPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int BGANCPCLKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int EHBNKAIMOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int IFAFLPOCKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int FKFMMBAJGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int KOAKBPLHPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int ANHLJLCOOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float ACDDOAOAPAL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct CNHINHDBHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public DFLMAAFEIJP.AGMKDJKCKIK NNIDNEKJKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float FOONLMOCPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float DNHGHHDOFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float PPBOJGGIDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float ABOHFANNKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float BDDNPFPGHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float KLLPMEMHIOM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct LOFEFGBEPND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NativeArray<float3> LEEMFAAGKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NativeArray<float3> IOMGNNLNGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NativeArray<float4> BHMDEBPLKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NativeArray<float4> NOBILJEOBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NativeArray<float2> KAAGLCNLAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NativeArray<int> DCKDPCFLICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool KEKLKFIFHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int MBGNDOMDJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int JBHPFBFMILD;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6335560", Offset = "0x6334560", VA = "0x186335560")]
		public void ECGMOLAFJIH(int MCEBDAHGEAA, int AALFLLNNAPO, Allocator NFBFCGHLHAF, bool CPLGHLCHKJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x63356B0", Offset = "0x63346B0", VA = "0x1863356B0")]
		public static LOFEFGBEPND LPPNNBEGNLN(DGFJOPHFDKD KFMGLDNFPAF)
		{
			return default(LOFEFGBEPND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x63354A0", Offset = "0x63344A0", VA = "0x1863354A0")]
		public void BPEPGBDJLCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker PAFJOBGMPLF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker LIOADMEJPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private NativeArray<EOFNBAJMHDJ> NHKCNMPIHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private LOFEFGBEPND ONBMMIDOBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private LOFEFGBEPND CIBFKDLEDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float3 ELPJANGCKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private float3 LJCJJNHEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private CNHINHDBHHA NIBAOAKDKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* OBIBEANIMOE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6330FD0", Offset = "0x632FFD0", VA = "0x186330FD0")]
	public FKABAKGGACF([In] List<BECFIKBKHON.FBGMOLGBNAM> MCCFMCLLNEE, [In] DGFJOPHFDKD OIHLHKDEICA, [In] BECFIKBKHON HEPILBJPACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x632F840", Offset = "0x632E840", VA = "0x18632F840", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x632F1D0", Offset = "0x632E1D0", VA = "0x18632F1D0")]
	public void DKIEGCKGIBI(List<BECFIKBKHON.FBGMOLGBNAM> OFFHOHOLOGD, [In] BECFIKBKHON HEPILBJPACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x632F960", Offset = "0x632E960", VA = "0x18632F960")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool LBKOMBAEFIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x632F890", Offset = "0x632E890", VA = "0x18632F890")]
	private BJOHFBLIEOJ JNICOMENGBH(int IBEGCKKAKOJ, Allocator NFBFCGHLHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x632FA80", Offset = "0x632EA80", VA = "0x18632FA80")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void PGGGDCDADEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x632ED90", Offset = "0x632DD90", VA = "0x18632ED90")]
	[IgnoreWarning(1371)]
	private EOFNBAJMHDJ BHCODAIPBDH([In] EOFNBAJMHDJ LNJIOANOELN, int CPLJLODNLIL, [In] NativeArray<int> IAJKHAFODFG, [In] NativeArray<bool> JEKMAFAEIJC, NativeArray<int> MLBCJHHCOEI)
	{
		return default(EOFNBAJMHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x632F980", Offset = "0x632E980", VA = "0x18632F980")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int NIDBHIEAMCL(NativeArray<int> IAJKHAFODFG, int MHDJCLJBJPF, int BDEJAPBNDIK, int ECLHMIJNGOF)
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
		private static readonly ProfilerMarker KJPMIDEJKHL;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly ProfilerMarker GOFHHKCNDHN;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly ProfilerMarker AEDMGFMGCEJ;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly ProfilerMarker IKBBIABFDNN;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly ProfilerMarker NLLHONOOCGM;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly ProfilerMarker PIJAMACLLIP;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly ProfilerMarker CJHBENKKGHH;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal const int LCLFELIAJNH = 65000;

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
		private Dictionary<Material, List<BECFIKBKHON>> PLOMBJJBOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal List<BECFIKBKHON> HOCLFALHIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private List<MeshRenderer> GKECKFKAJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool IBCNGGENIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool PLOOAGFHDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int IBFFJBLLCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Dictionary<int, float> ABMAMCHGOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Dictionary<int, Color> MNKDNJEDEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Dictionary<int, Vector4> POKGBIJAJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, Matrix4x4> HNKGEOBPDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private BECFIKBKHON IBKLIKHGKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Material OEHLNLNAKGJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> BFOJPEIPHNB
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int CBHLGHPAPPL
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x632ECB0", Offset = "0x632DCB0", VA = "0x18632ECB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x632B800", Offset = "0x632A800", VA = "0x18632B800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x63299F0", Offset = "0x63289F0", VA = "0x1863299F0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x63295C0", Offset = "0x63285C0", VA = "0x1863295C0")]
		public BECFIKBKHON AddToBatchedMesh(FAFAOJKPOLJ GIENFDPNFCH, Material JANOPPPMNPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x632DE60", Offset = "0x632CE60", VA = "0x18632DE60")]
		public void RemoveFromBatchedMesh(FAFAOJKPOLJ GCFMCPMBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x63298C0", Offset = "0x63288C0", VA = "0x1863298C0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x632DFA0", Offset = "0x632CFA0", VA = "0x18632DFA0")]
		public void SetMaterialProperty(int NCCEHAHLBDA, Color IODHIPGGADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x632E430", Offset = "0x632D430", VA = "0x18632E430")]
		public void SetMaterialProperty(int NCCEHAHLBDA, float LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x632E650", Offset = "0x632D650", VA = "0x18632E650")]
		public void SetMaterialProperty(int NCCEHAHLBDA, Vector4 BEKELJLCGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x632E1D0", Offset = "0x632D1D0", VA = "0x18632E1D0")]
		public void SetMaterialProperty(int NCCEHAHLBDA, Matrix4x4 HBFLPOLMCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x632A7F0", Offset = "0x63297F0", VA = "0x18632A7F0")]
		private void IADJEPEIMBH(Renderer GHMFIGHJGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x632A1D0", Offset = "0x63291D0", VA = "0x18632A1D0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x632A1C0", Offset = "0x63291C0", VA = "0x18632A1C0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x632ADE0", Offset = "0x6329DE0", VA = "0x18632ADE0")]
		private void KDFDBNPHJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6329FB0", Offset = "0x6328FB0", VA = "0x186329FB0")]
		private BECFIKBKHON FAJAFJPNBBO(FAFAOJKPOLJ GCFMCPMBPPI, Material JANOPPPMNPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x63296C0", Offset = "0x63286C0", VA = "0x1863296C0")]
		private BECFIKBKHON BAIHOMMAGBG(Material JANOPPPMNPE, int DICDPNPBAAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6329BB0", Offset = "0x6328BB0", VA = "0x186329BB0")]
		private BECFIKBKHON EHKFAFOCFKA(Material JANOPPPMNPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x176B940", Offset = "0x176A940", VA = "0x18176B940")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x632B320", Offset = "0x632A320", VA = "0x18632B320")]
		public void MarkDirty(FAFAOJKPOLJ GCFMCPMBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x632B480", Offset = "0x632A480", VA = "0x18632B480")]
		public (long, long) MemorySizeInBytesForChosenDetail(float NFEKEKNEFOJ)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x632CFA0", Offset = "0x632BFA0", VA = "0x18632CFA0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x632A270", Offset = "0x6329270", VA = "0x18632A270")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x632BAF0", Offset = "0x632AAF0", VA = "0x18632BAF0")]
		public void RebatchOptimally(int NLPDHABFDJM, int IMDPOLPAPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x632EA40", Offset = "0x632DA40", VA = "0x18632EA40")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GFDAOEGCKNP
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct FHLLJLNMEFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public float NPHBPMHKILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BatchedMeshRenderer ADDLEHBJNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public BECFIKBKHON FBGHGJDHKJC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly ProfilerMarker NLLHONOOCGM;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ProfilerMarker IMBKNKDMFJC;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly ProfilerMarker DBDCHPODHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ProfilerMarker KGKFGGPMODA;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public static float3 BLJJLPIHKOA;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public static int PBKLJFDIMNL;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static int CDIHCGGHPAG;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static int FNONKLEJBNM;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public static int PGJOJELCCPB;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public static int NMEKBKOPLEA;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static int BHIBKELKMCJ;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static int EEOKBAJKDCI;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static int GFDPEPDMJED;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static int LNGNCNPNHPL;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static int KEKHCJGMGAF;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public static int CDEIOCKLFOL;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public static int AGHMFLIODKJ;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public static int IGDJGDNOKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public static int DJOPELMANBN;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static int FOCGMDPGBKH;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public static int GJKLBBHJMIL;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public static long FLGPGCCLHAB;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public static bool LKBCMIKCGOI;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<BatchedMeshRenderer> LDCELEFLHGD;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static List<FHLLJLNMEFD> IAFBGMNIANK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool KEJPEFIJMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6331980", Offset = "0x6330980", VA = "0x186331980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x63319C0", Offset = "0x63309C0", VA = "0x1863319C0")]
	public static void CPHLHCOPMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6331FD0", Offset = "0x6330FD0", VA = "0x186331FD0")]
	public static void KDFHEJHFMGA(BatchedMeshRenderer FPKFPPABBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6333280", Offset = "0x6332280", VA = "0x186333280")]
	public static void NKFAAMPBCEP(BatchedMeshRenderer FPKFPPABBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x63317D0", Offset = "0x63307D0", VA = "0x1863317D0")]
	private static void AODFHIMLLOL([Out] long DGPMDIDMPAG, [Out] long BJPLCPGAPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x63334D0", Offset = "0x63324D0", VA = "0x1863334D0")]
	public static void PANEJAADMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6331F30", Offset = "0x6330F30", VA = "0x186331F30")]
	public static void JNDMDFLCLNM(BECFIKBKHON FBGHGJDHKJC, BatchedMeshRenderer ADDLEHBJNHG, float NPHBPMHKILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6332560", Offset = "0x6331560", VA = "0x186332560")]
	public static void LAHOKCGBILA(BECFIKBKHON FBGHGJDHKJC, BatchedMeshRenderer ADDLEHBJNHG, float CHBOHGEDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6331BA0", Offset = "0x6330BA0", VA = "0x186331BA0")]
	public static void ENFNBNCONEF(BECFIKBKHON FBGHGJDHKJC, BatchedMeshRenderer ADDLEHBJNHG, float CHBOHGEDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6332600", Offset = "0x6331600", VA = "0x186332600")]
	public static void LCIHGJEEKGK(BECFIKBKHON FBGHGJDHKJC, BatchedMeshRenderer ADDLEHBJNHG, float NPHBPMHKILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6333330", Offset = "0x6332330", VA = "0x186333330")]
	public static void NPMEMMNNCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6331610", Offset = "0x6330610", VA = "0x186331610")]
	public static void AAMNPEIKKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6332260", Offset = "0x6331260", VA = "0x186332260")]
	public static float KILFJGEHPJL(long BGLDGANKBNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6331C40", Offset = "0x6330C40", VA = "0x186331C40")]
	public static (long, long) HIGNNEHLHOP(float NFEKEKNEFOJ)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6332770", Offset = "0x6331770", VA = "0x186332770")]
	public static void LDKCOENJADB(bool KNKGGIBFJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6331E10", Offset = "0x6330E10", VA = "0x186331E10")]
	public static int IJNNEJJMHPP()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GALGPLKDGNE<KeyType> : BECFIKBKHON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<KeyType, FAFAOJKPOLJ> HEPANILFAOL;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3994900", Offset = "0x3993900", VA = "0x183994900")]
	public GALGPLKDGNE(string ONGJKHHOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x39947D0", Offset = "0x39937D0", VA = "0x1839947D0")]
	public void OPJPFOEPONM(KeyType OHNEPKBBADL, FAFAOJKPOLJ MMOCDCIIANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x39946F0", Offset = "0x39936F0", VA = "0x1839946F0")]
	public bool HHFEPBJENAL(KeyType OHNEPKBBADL, FAFAOJKPOLJ HGJMOGKLCLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x39944B0", Offset = "0x39934B0", VA = "0x1839944B0")]
	public void GJABKFHCKFO(KeyType OHNEPKBBADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3994470", Offset = "0x3993470", VA = "0x183994470", Slot = "4")]
	public override void AIBPELBLHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6335900", Offset = "0x6334900", VA = "0x186335900")]
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
