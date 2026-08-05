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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MJJOFJFBEEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int CGHBHIHEILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 OOGNGINKOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion AIKOBLNMHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 DPPPGIBABCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int MHCLJLHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int HMNOCMLJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HOHEEMOOPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float PJDALPELFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 JKDMJBBPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool CFDCIEKHFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public OFEMPLFHBFE JEJBHDCDGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 FPNGNLPGLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float OOKDGJIJHPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DOFILONOFKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static MOFPICGIMGL KIBGDBLAJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<MJJOFJFBEEO> IAHNNJOPHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<MCJJEAPKCBK> POKINKOKBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<CKBNFODBNJC> EDFPLEJEADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<PLANDAMNNMP> NODNGJCFLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<MCJJEAPKCBK> HCOJPOENIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<GOJNOBAFNLP> GFPKBGJJNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<PLANDAMNNMP>> KGIPEBCECKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<HCDLLDKEFIP> ANBPACHCGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> CGCMJAGJGNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MKAIINJDMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC63630", Offset = "0xC62430", VA = "0x180C63630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC630F0", Offset = "0xC61EF0", VA = "0x180C630F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OKICDHGLENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC63640", Offset = "0xC62440", VA = "0x180C63640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC62200", Offset = "0xC61000", VA = "0x180C62200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6278590", Offset = "0x6277390", VA = "0x186278590")]
	public DOFILONOFKK(int GCELJNDEDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6276C60", Offset = "0x6275A60", VA = "0x186276C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6277100", Offset = "0x6275F00", VA = "0x186277100")]
	public void KGELIFGGPDE(JobHandle BNBGJBKKKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6276A40", Offset = "0x6275840", VA = "0x186276A40")]
	public void DFEABNEIOJK(MJJOFJFBEEO LHODDAGAJKC, HCDLLDKEFIP LDEOIEONMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6276FC0", Offset = "0x6275DC0", VA = "0x186276FC0")]
	public void GNCNOLBLLAF(CKBNFODBNJC LHODDAGAJKC, NativeArray<PLANDAMNNMP> ALBGGEGLGAF, int JOFPJDBJGBF, int DBNJBEFKFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62772D0", Offset = "0x62760D0", VA = "0x1862772D0")]
	public JobHandle KJCKELDOFIN(GHBOPEHKLOP LMDDLOEPKIJ, PFLBJFEMLHD BDFOGIIFBEP, float3 KDKKHOALPBF, quaternion GMJMGOMFDIO, float NMJEKIGEEDL, bool PDPBJACBBFD, int APNPKJEFNAH = 0, int EJNLEBBBKLD = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6276C80", Offset = "0x6275A80", VA = "0x186276C80")]
	public static JobHandle FPHCPAPNFNL(LFCLOFJIENK FAKDPAHNNFM, GHBOPEHKLOP LMDDLOEPKIJ, MJJOFJFBEEO LHODDAGAJKC, JobHandle BNBGJBKKKMM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62782E0", Offset = "0x62770E0", VA = "0x1862782E0")]
	public static JobHandle MGBNEFOOMFN(GKOMBKBPAMH FAKDPAHNNFM, GHBOPEHKLOP LMDDLOEPKIJ, CKBNFODBNJC LHODDAGAJKC, NativeArray<PLANDAMNNMP> ALBGGEGLGAF, int JOFPJDBJGBF, int DBNJBEFKFNH, JobHandle BNBGJBKKKMM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class BFNHPMJKBMI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct KJDEGCNEKCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half DKKKDPCMJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort DBKEAMHPHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte BBJPAOPBAEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public unsafe delegate void ADFOCDHFPHD(float3* MLCAHAPFEGI, [In] ushort* DBAFLGEJMHC, int JOFPJDBJGBF, [In] float3 FFOFECGLAGO, [In] float3 KHPPMHLJOAK);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class EEBKFHHPIMI
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6278A40", Offset = "0x6277840", VA = "0x186278A40")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6278B60", Offset = "0x6277960", VA = "0x186278B60")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62787A0", Offset = "0x62775A0", VA = "0x1862787A0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6278840", Offset = "0x6277640", VA = "0x186278840")]
		public unsafe static void HEPNPPEJLJB(float3* MLCAHAPFEGI, [In] ushort* DBAFLGEJMHC, int JOFPJDBJGBF, [In] float3 FFOFECGLAGO, [In] float3 KHPPMHLJOAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void ADFDHHPLHFN(ushort* MLCAHAPFEGI, [Out] float3 HDJJLCALMJE, [Out] float3 KHPPMHLJOAK, [In] float3* DBAFLGEJMHC, int LPDLGBABNCP, int KFPKHOCPJLD);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class HNADHDEKAHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6287890", Offset = "0x6286690", VA = "0x186287890")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62879B0", Offset = "0x62867B0", VA = "0x1862879B0")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x62875E0", Offset = "0x62863E0", VA = "0x1862875E0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6287680", Offset = "0x6286480", VA = "0x186287680")]
		public unsafe static void HEPNPPEJLJB(ushort* MLCAHAPFEGI, [Out] float3 HDJJLCALMJE, [Out] float3 KHPPMHLJOAK, [In] float3* DBAFLGEJMHC, int LPDLGBABNCP, int KFPKHOCPJLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public unsafe delegate void BOHMDFKAGKA(ushort* IKIBIPOMPNC, [In] float3* GAPAPOKBGAN, int KFPKHOCPJLD);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class PIMDEOONIAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x628CE60", Offset = "0x628BC60", VA = "0x18628CE60")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x628CF80", Offset = "0x628BD80", VA = "0x18628CF80")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x628CBE0", Offset = "0x628B9E0", VA = "0x18628CBE0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x628CC80", Offset = "0x628BA80", VA = "0x18628CC80")]
		public unsafe static void HEPNPPEJLJB(ushort* IKIBIPOMPNC, [In] float3* GAPAPOKBGAN, int KFPKHOCPJLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public unsafe delegate void ENNHDGENNJO(float3* FBOCECFDGHE, [In] ushort* GAPAPOKBGAN, int JOFPJDBJGBF);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class AOPJAEPMLMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6271CE0", Offset = "0x6270AE0", VA = "0x186271CE0")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6271E00", Offset = "0x6270C00", VA = "0x186271E00")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6271A00", Offset = "0x6270800", VA = "0x186271A00")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6271AA0", Offset = "0x62708A0", VA = "0x186271AA0")]
		public unsafe static void HEPNPPEJLJB(float3* FBOCECFDGHE, [In] ushort* GAPAPOKBGAN, int JOFPJDBJGBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public unsafe delegate void LIBFBEOIAFA(ushort* PHJOLNDCABN, [Out] float2 FIIAJNIABJN, [Out] float2 MDGKNLINNEF, [In] float2* CIHJDFJKAOP, int LPDLGBABNCP, int KFPKHOCPJLD);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class DMKLBFKNDPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6276290", Offset = "0x6275090", VA = "0x186276290")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62763B0", Offset = "0x62751B0", VA = "0x1862763B0")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6275FE0", Offset = "0x6274DE0", VA = "0x186275FE0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6276080", Offset = "0x6274E80", VA = "0x186276080")]
		public unsafe static void HEPNPPEJLJB(ushort* PHJOLNDCABN, [Out] float2 FIIAJNIABJN, [Out] float2 MDGKNLINNEF, [In] float2* CIHJDFJKAOP, int LPDLGBABNCP, int KFPKHOCPJLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void DFHLILPENCA([Out] float2 AGLPHKFMFGN, ushort NPMLHGHMHPE, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class DOBMIEPBFMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62767D0", Offset = "0x62755D0", VA = "0x1862767D0")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62768F0", Offset = "0x62756F0", VA = "0x1862768F0")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6276500", Offset = "0x6275300", VA = "0x186276500")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62765A0", Offset = "0x62753A0", VA = "0x1862765A0")]
		public static void HEPNPPEJLJB([Out] float2 AGLPHKFMFGN, ushort NPMLHGHMHPE, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public unsafe delegate void JKDFNDDEEIO(float2* PHJOLNDCABN, ushort* CIHJDFJKAOP, int JOFPJDBJGBF, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class JEBPEBMKFBH
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6288E90", Offset = "0x6287C90", VA = "0x186288E90")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6288FB0", Offset = "0x6287DB0", VA = "0x186288FB0")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6288B70", Offset = "0x6287970", VA = "0x186288B70")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6288C10", Offset = "0x6287A10", VA = "0x186288C10")]
		public unsafe static void HEPNPPEJLJB(float2* PHJOLNDCABN, ushort* CIHJDFJKAOP, int JOFPJDBJGBF, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public unsafe delegate void PJLJFBOFFNK(ushort* JINJLOGBAIF, [In] float4* PEPHNAMNADK, int LPDLGBABNCP, int KFPKHOCPJLD);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class LBMJEBJJAHG
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6289960", Offset = "0x6288760", VA = "0x186289960")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6289A80", Offset = "0x6288880", VA = "0x186289A80")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6289680", Offset = "0x6288480", VA = "0x186289680")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6289720", Offset = "0x6288520", VA = "0x186289720")]
		public unsafe static void HEPNPPEJLJB(ushort* JINJLOGBAIF, [In] float4* PEPHNAMNADK, int LPDLGBABNCP, int KFPKHOCPJLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate ushort ANIJHADIHCK([In] float4 FMJNBAGBGNH);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class ICFEHPKIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62882F0", Offset = "0x62870F0", VA = "0x1862882F0")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6288410", Offset = "0x6287210", VA = "0x186288410")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6288050", Offset = "0x6286E50", VA = "0x186288050")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62880F0", Offset = "0x6286EF0", VA = "0x1862880F0")]
		public static ushort HEPNPPEJLJB([In] float4 FMJNBAGBGNH)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public unsafe delegate void FCBMNAMMONO(float4* JINJLOGBAIF, [In] ushort* IAPNADIIHJM, int JOFPJDBJGBF);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class GBEMDKOMHKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6280810", Offset = "0x627F610", VA = "0x186280810")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6280930", Offset = "0x627F730", VA = "0x186280930")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6280530", Offset = "0x627F330", VA = "0x186280530")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62805D0", Offset = "0x627F3D0", VA = "0x1862805D0")]
		public unsafe static void HEPNPPEJLJB(float4* JINJLOGBAIF, [In] ushort* IAPNADIIHJM, int JOFPJDBJGBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void DNPCLNFCAKL([Out] float4 FJMMLPMLLGC, ushort NPMLHGHMHPE);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class KGELIGCNOHH
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6289410", Offset = "0x6288210", VA = "0x186289410")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6289530", Offset = "0x6288330", VA = "0x186289530")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6289100", Offset = "0x6287F00", VA = "0x186289100")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62891A0", Offset = "0x6287FA0", VA = "0x1862891A0")]
		public static void HEPNPPEJLJB([Out] float4 FJMMLPMLLGC, ushort NPMLHGHMHPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public unsafe delegate void LCPGILECKOH(float4* LMJGMGAAHLH, byte* JOILAIGEMCL, [Out] int JHGGAHJKJNL, [Out] int OGKIJIODEBJ, float4* BJIGGGOCICK, int LPDLGBABNCP, int KFPKHOCPJLD);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class HCBCLHJJEBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6285D10", Offset = "0x6284B10", VA = "0x186285D10")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6285E30", Offset = "0x6284C30", VA = "0x186285E30")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6285A60", Offset = "0x6284860", VA = "0x186285A60")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6285B00", Offset = "0x6284900", VA = "0x186285B00")]
		public unsafe static void HEPNPPEJLJB(float4* LMJGMGAAHLH, byte* JOILAIGEMCL, [Out] int JHGGAHJKJNL, [Out] int OGKIJIODEBJ, float4* BJIGGGOCICK, int LPDLGBABNCP, int KFPKHOCPJLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public unsafe delegate void DJICFKCIDJL(float4* GHCHIJNOBMF, [In] KJDEGCNEKCG* FHNNJDCHHBI, [In] byte* KKFNIGMIOOG, int JOFPJDBJGBF);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class PPDMLFLODFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x628DA20", Offset = "0x628C820", VA = "0x18628DA20")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x628DB40", Offset = "0x628C940", VA = "0x18628DB40")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x628D6A0", Offset = "0x628C4A0", VA = "0x18628D6A0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x628D740", Offset = "0x628C540", VA = "0x18628D740")]
		public unsafe static void HEPNPPEJLJB(float4* GHCHIJNOBMF, [In] KJDEGCNEKCG* FHNNJDCHHBI, [In] byte* KKFNIGMIOOG, int JOFPJDBJGBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public unsafe delegate int IDJBMKDMDEN(byte* OCJNIIGGGHL, [In] int* LKHHFIKMPGC, int AFAIDFBCHGG);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class HEAILGMCGMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6287370", Offset = "0x6286170", VA = "0x186287370")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6287490", Offset = "0x6286290", VA = "0x186287490")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6287050", Offset = "0x6285E50", VA = "0x186287050")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62870F0", Offset = "0x6285EF0", VA = "0x1862870F0")]
		public unsafe static int HEPNPPEJLJB(byte* OCJNIIGGGHL, [In] int* LKHHFIKMPGC, int AFAIDFBCHGG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public unsafe delegate void IKBFHPHLKGM(int* HHHEJOOKAAN, [In] byte* KKJCFBBOFCL, int DBNJBEFKFNH);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class HPPELFMKHAN
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6287DE0", Offset = "0x6286BE0", VA = "0x186287DE0")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6287F00", Offset = "0x6286D00", VA = "0x186287F00")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6287B00", Offset = "0x6286900", VA = "0x186287B00")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6287BA0", Offset = "0x62869A0", VA = "0x186287BA0")]
		public unsafe static void HEPNPPEJLJB(int* HHHEJOOKAAN, [In] byte* KKJCFBBOFCL, int DBNJBEFKFNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void PBNEBDLCNCL([Out] float3 AGLPHKFMFGN, ushort NPMLHGHMHPE);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class HDPCONOOCFF
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6286DE0", Offset = "0x6285BE0", VA = "0x186286DE0")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6286F00", Offset = "0x6285D00", VA = "0x186286F00")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x62869F0", Offset = "0x62857F0", VA = "0x1862869F0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6286A90", Offset = "0x6285890", VA = "0x186286A90")]
		public static void HEPNPPEJLJB([Out] float3 AGLPHKFMFGN, ushort NPMLHGHMHPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate ushort JCEFKOMNHAL([In] float3 FMJNBAGBGNH);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class PKPJFBBHAIH
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr HNIBANLCFPK;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr NOOGOPAJGNA;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x628D430", Offset = "0x628C230", VA = "0x18628D430")]
		[BurstDiscard]
		private static void HLMHHGLIEDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x628D550", Offset = "0x628C350", VA = "0x18628D550")]
		private static IntPtr JPEOAAFBMCB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x628D1D0", Offset = "0x628BFD0", VA = "0x18628D1D0")]
		public static void GHEDHNFLDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public static void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x628D270", Offset = "0x628C070", VA = "0x18628D270")]
		public static ushort HEPNPPEJLJB([In] float3 FMJNBAGBGNH)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JOFPJDBJGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int DBNJBEFKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> JCCAAPOCODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> PPGENHJPCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> MEGLEIOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MOMPDIJLKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<KJDEGCNEKCG> ECCLAHFCBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> OGCKFAAFOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> JPLJAMNFPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 FFOFECGLAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 KHPPMHLJOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 FPBPJKDDPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 MDGKNLINNEF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long POFEAKFHFEA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long DANOBBJAJKC;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float OGCFGBKPPPJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool OHJHJFAAEDB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CMNOMCINFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6273730", Offset = "0x6272530", VA = "0x186273730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6274440", Offset = "0x6273240", VA = "0x186274440")]
	public void KGELIFGGPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6272130", Offset = "0x6270F30", VA = "0x186272130")]
	public static BFNHPMJKBMI ANGJMEBBFOG(Allocator ACBNCIGINAO, GHBOPEHKLOP CAMLLGILIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6272370", Offset = "0x6271170", VA = "0x186272370")]
	public static BFNHPMJKBMI ANGJMEBBFOG(Allocator ACBNCIGINAO, NativeArray<float3> DBAFLGEJMHC, NativeArray<float3> GAPAPOKBGAN, NativeArray<float2> CIHJDFJKAOP, NativeArray<float4> BJIGGGOCICK, bool IEDEAAJLEBL, NativeArray<float4> IAPNADIIHJM, NativeArray<int> LKHHFIKMPGC, int JOFPJDBJGBF, int PPIBPFNGMJO, int DBNJBEFKFNH, int LPDLGBABNCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6274540", Offset = "0x6273340", VA = "0x186274540")]
	public GHBOPEHKLOP KGIHMINAFLF(Allocator ACBNCIGINAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6272840", Offset = "0x6271640", VA = "0x186272840")]
	public void BAOHPKEOGBN(Mesh ANKNNGGBGOG, bool LFEMOJCJNIP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62753B0", Offset = "0x62741B0", VA = "0x1862753B0")]
	public long MGBJMBACNDJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6273CC0", Offset = "0x6272AC0", VA = "0x186273CC0")]
	public static long GOFDIEENDNO(int BJOHGIEAADN, int LEOLNDEBACO, bool ELIPPMLEMOP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6273D10", Offset = "0x6272B10", VA = "0x186273D10")]
	public long GOFDIEENDNO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6274FD0", Offset = "0x6273DD0", VA = "0x186274FD0")]
	private void LIIGHDEMLFJ(int CCIFMHHICGF, int KFPKHOCPJLD, Allocator ACBNCIGINAO, bool MDPHAOBICBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6271FB0", Offset = "0x6270DB0", VA = "0x186271FB0")]
	private void AKAPMMDHJCP(NativeArray<float3> MLCAHAPFEGI, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62720B0", Offset = "0x6270EB0", VA = "0x1862720B0")]
	[BurstCompile]
	private unsafe static void AKAPMMDHJCP(float3* MLCAHAPFEGI, [In] ushort* DBAFLGEJMHC, int JOFPJDBJGBF, [In] float3 FFOFECGLAGO, [In] float3 KHPPMHLJOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6274CC0", Offset = "0x6273AC0", VA = "0x186274CC0")]
	private void KPPPBPOOGOK(NativeArray<float3> DBAFLGEJMHC, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6274DC0", Offset = "0x6273BC0", VA = "0x186274DC0")]
	[BurstCompile]
	private unsafe static void KPPPBPOOGOK(ushort* MLCAHAPFEGI, [Out] float3 HDJJLCALMJE, [Out] float3 KHPPMHLJOAK, [In] float3* DBAFLGEJMHC, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62752F0", Offset = "0x62740F0", VA = "0x1862752F0")]
	private void LOCPECINBOP(NativeArray<float3> GAPAPOKBGAN, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62750E0", Offset = "0x6273EE0", VA = "0x1862750E0")]
	[BurstCompile]
	private unsafe static void LOCPECINBOP(ushort* IKIBIPOMPNC, [In] float3* GAPAPOKBGAN, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6273770", Offset = "0x6272570", VA = "0x186273770")]
	private void GJAJLAGDKOC(NativeArray<float3> FBOCECFDGHE, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6273840", Offset = "0x6272640", VA = "0x186273840")]
	[BurstCompile]
	private unsafe static void GJAJLAGDKOC(float3* FBOCECFDGHE, [In] ushort* GAPAPOKBGAN, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6273BF0", Offset = "0x62729F0", VA = "0x186273BF0")]
	private void GNFODJJHKND(NativeArray<float2> CIHJDFJKAOP, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62739B0", Offset = "0x62727B0", VA = "0x1862739B0")]
	[BurstCompile]
	private unsafe static void GNFODJJHKND(ushort* PHJOLNDCABN, [Out] float2 FIIAJNIABJN, [Out] float2 MDGKNLINNEF, [In] float2* CIHJDFJKAOP, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6274080", Offset = "0x6272E80", VA = "0x186274080")]
	[BurstCompile]
	private static void IJOJHNLBAAP([Out] float2 AGLPHKFMFGN, ushort NPMLHGHMHPE, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6275440", Offset = "0x6274240", VA = "0x186275440")]
	private void NCLADNBJIJI(NativeArray<float2> PHJOLNDCABN, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6275540", Offset = "0x6274340", VA = "0x186275540")]
	[BurstCompile]
	private unsafe static void NCLADNBJIJI(float2* PHJOLNDCABN, ushort* CIHJDFJKAOP, int JOFPJDBJGBF, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6275660", Offset = "0x6274460", VA = "0x186275660")]
	private void OOCPDOFMFCK(NativeArray<float4> IAPNADIIHJM, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6275750", Offset = "0x6274550", VA = "0x186275750")]
	[BurstCompile]
	private unsafe static void OOCPDOFMFCK(ushort* JINJLOGBAIF, [In] float4* PEPHNAMNADK, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62729D0", Offset = "0x62717D0", VA = "0x1862729D0")]
	[BurstCompile]
	private static ushort DBHEFDMOHON([In] float4 FMJNBAGBGNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6274300", Offset = "0x6273100", VA = "0x186274300")]
	private void JBLNBPJJMEL(NativeArray<float4> JINJLOGBAIF, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62743D0", Offset = "0x62731D0", VA = "0x1862743D0")]
	[BurstCompile]
	private unsafe static void JBLNBPJJMEL(float4* JINJLOGBAIF, [In] ushort* IAPNADIIHJM, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6272920", Offset = "0x6271720", VA = "0x186272920")]
	[BurstCompile]
	private static void BJEMELJOLKG([Out] float4 FJMMLPMLLGC, ushort NPMLHGHMHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6272F30", Offset = "0x6271D30", VA = "0x186272F30")]
	private void FCONEGGEPKK(Allocator ACBNCIGINAO, NativeArray<float4> BJIGGGOCICK, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6273310", Offset = "0x6272110", VA = "0x186273310")]
	[BurstCompile]
	private unsafe static void FCONEGGEPKK(float4* LMJGMGAAHLH, byte* JOILAIGEMCL, [Out] int JHGGAHJKJNL, [Out] int OGKIJIODEBJ, float4* BJIGGGOCICK, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6272AA0", Offset = "0x62718A0", VA = "0x186272AA0")]
	private static void DECEPCNGPCC(NativeArray<float4> GHCHIJNOBMF, NativeArray<KJDEGCNEKCG> FHNNJDCHHBI, NativeArray<byte> KKFNIGMIOOG, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6272A20", Offset = "0x6271820", VA = "0x186272A20")]
	[BurstCompile]
	private unsafe static void DECEPCNGPCC(float4* GHCHIJNOBMF, [In] KJDEGCNEKCG* FHNNJDCHHBI, [In] byte* KKFNIGMIOOG, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6274E50", Offset = "0x6273C50", VA = "0x186274E50")]
	private void LBALCGBLIHI(Allocator ACBNCIGINAO, NativeArray<int> LKHHFIKMPGC, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6273DA0", Offset = "0x6272BA0", VA = "0x186273DA0")]
	private static NativeArray<byte> HEGPHAHBFPN(Allocator ACBNCIGINAO, NativeArray<int> LKHHFIKMPGC, int AFAIDFBCHGG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6274010", Offset = "0x6272E10", VA = "0x186274010")]
	[BurstCompile]
	private unsafe static int HEGPHAHBFPN(byte* OCJNIIGGGHL, [In] int* LKHHFIKMPGC, int AFAIDFBCHGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6274B20", Offset = "0x6273920", VA = "0x186274B20")]
	private static void KGNDAFOAHFP(NativeArray<int> HHHEJOOKAAN, NativeArray<byte> KKJCFBBOFCL, int DBNJBEFKFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6274BF0", Offset = "0x62739F0", VA = "0x186274BF0")]
	[BurstCompile]
	private unsafe static void KGNDAFOAHFP(int* HHHEJOOKAAN, [In] byte* KKJCFBBOFCL, int DBNJBEFKFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6274C60", Offset = "0x6273A60", VA = "0x186274C60")]
	[BurstCompile]
	private static void KJMICEACMNC([Out] float3 AGLPHKFMFGN, ushort NPMLHGHMHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6274100", Offset = "0x6272F00", VA = "0x186274100")]
	[BurstCompile]
	private static ushort JBLCEPDGAKP([In] float3 FMJNBAGBGNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BFNHPMJKBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x626F6C0", Offset = "0x626E4C0", VA = "0x18626F6C0")]
	[BurstCompile]
	public unsafe static void KOLODBICJMH(float3* MLCAHAPFEGI, [In] ushort* DBAFLGEJMHC, int JOFPJDBJGBF, [In] float3 FFOFECGLAGO, [In] float3 KHPPMHLJOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x626F090", Offset = "0x626DE90", VA = "0x18626F090")]
	[BurstCompile]
	public unsafe static void BPEONCMJNON(ushort* MLCAHAPFEGI, [Out] float3 HDJJLCALMJE, [Out] float3 KHPPMHLJOAK, [In] float3* DBAFLGEJMHC, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x626F470", Offset = "0x626E270", VA = "0x18626F470")]
	[BurstCompile]
	public unsafe static void FEJEBICCLNK(ushort* IKIBIPOMPNC, [In] float3* GAPAPOKBGAN, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62755C0", Offset = "0x62743C0", VA = "0x1862755C0")]
	[BurstCompile]
	public unsafe static void NPCPBPOPMAM(float3* FBOCECFDGHE, [In] ushort* GAPAPOKBGAN, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x626F910", Offset = "0x626E710", VA = "0x18626F910")]
	[BurstCompile]
	public unsafe static void NCKBAJFAFML(ushort* PHJOLNDCABN, [Out] float2 FIIAJNIABJN, [Out] float2 MDGKNLINNEF, [In] float2* CIHJDFJKAOP, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6272980", Offset = "0x6271780", VA = "0x186272980")]
	[BurstCompile]
	public static void CLIKNONNMNI([Out] float2 AGLPHKFMFGN, ushort NPMLHGHMHPE, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6272D90", Offset = "0x6271B90", VA = "0x186272D90")]
	[BurstCompile]
	public unsafe static void EHMCBENPNFF(float2* PHJOLNDCABN, ushort* CIHJDFJKAOP, int JOFPJDBJGBF, [In] float2 FPBPJKDDPPP, [In] float2 MDGKNLINNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6273550", Offset = "0x6272350", VA = "0x186273550")]
	[BurstCompile]
	public unsafe static void FJIDCAMELGL(ushort* JINJLOGBAIF, [In] float4* PEPHNAMNADK, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6271F50", Offset = "0x6270D50", VA = "0x186271F50")]
	[BurstCompile]
	public static ushort AELFBJGJMMB([In] float4 FMJNBAGBGNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6274F30", Offset = "0x6273D30", VA = "0x186274F30")]
	[BurstCompile]
	public unsafe static void LFLFFDFLDFN(float4* JINJLOGBAIF, [In] ushort* IAPNADIIHJM, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6272E70", Offset = "0x6271C70", VA = "0x186272E70")]
	[BurstCompile]
	public static void EMNDJGLMEEK([Out] float4 FJMMLPMLLGC, ushort NPMLHGHMHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x626FBD0", Offset = "0x626E9D0", VA = "0x18626FBD0")]
	[BurstCompile]
	public unsafe static void NFJCENBHCAN(float4* LMJGMGAAHLH, byte* JOILAIGEMCL, [Out] int JHGGAHJKJNL, [Out] int OGKIJIODEBJ, float4* BJIGGGOCICK, int LPDLGBABNCP, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6272C50", Offset = "0x6271A50", VA = "0x186272C50")]
	[BurstCompile]
	public unsafe static void DOKFLEMJDBF(float4* GHCHIJNOBMF, [In] KJDEGCNEKCG* FHNNJDCHHBI, [In] byte* KKFNIGMIOOG, int JOFPJDBJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62738B0", Offset = "0x62726B0", VA = "0x1862738B0")]
	[BurstCompile]
	public unsafe static int GLKCJLCCBLG(byte* OCJNIIGGGHL, [In] int* LKHHFIKMPGC, int AFAIDFBCHGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6272BB0", Offset = "0x62719B0", VA = "0x186272BB0")]
	[BurstCompile]
	public unsafe static void DJCJBGKKLBP(int* HHHEJOOKAAN, [In] byte* KKJCFBBOFCL, int DBNJBEFKFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62735F0", Offset = "0x62723F0", VA = "0x1862735F0")]
	[BurstCompile]
	public static void FMKPHBACDPC([Out] float3 AGLPHKFMFGN, ushort NPMLHGHMHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x626EED0", Offset = "0x626DCD0", VA = "0x18626EED0")]
	[BurstCompile]
	public static ushort AOOJOLGBCHK([In] float3 FMJNBAGBGNH)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KFKBCMFJIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float2 AKOMBCBOHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float2 MICEBJPJMGL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NHCHKKLNAGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<KFKBCMFJIBD> KKBIINAIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<int> HONFJLNGGPF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MKAIINJDMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OKICDHGLENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5040", Offset = "0x7B3E40", VA = "0x1807B5040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x628A5B0", Offset = "0x62893B0", VA = "0x18628A5B0")]
	public NHCHKKLNAGB(int CCIFMHHICGF, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x628A470", Offset = "0x6289270", VA = "0x18628A470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x628A4D0", Offset = "0x62892D0", VA = "0x18628A4D0")]
	public void HFCJNOLAJIF(NHCHKKLNAGB IKIHMKDEDKB, int MGCLLOKHONB, int DLJHEFPEFCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PAFCPNMDPOE
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static NHCHKKLNAGB DLNFKEJCNLN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static NativeList<MCJJEAPKCBK> GHEMHIKMAIA;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static int[] JPGMAIOKIFG;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static bool KFPODEGIHKH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, NHCHKKLNAGB> JCDKFBPLBBB;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, NHCHKKLNAGB> EHOJONBLLBM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool EFPHNBGICGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x628B940", Offset = "0x628A740", VA = "0x18628B940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<MCJJEAPKCBK> OGNOAAHFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x628B800", Offset = "0x628A600", VA = "0x18628B800")]
		get
		{
			return default(NativeList<MCJJEAPKCBK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static NHCHKKLNAGB ONJLMEHFMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x628B240", Offset = "0x628A040", VA = "0x18628B240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x628A9F0", Offset = "0x62897F0", VA = "0x18628A9F0")]
	private static void EKKPKLJMDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x628B2D0", Offset = "0x628A0D0", VA = "0x18628B2D0")]
	public static int HHDPGJJAHLL(bool EJGNNCPLHEA, int DBILLPPAHGE, bool PBFHDOKKGCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x628BD20", Offset = "0x628AB20", VA = "0x18628BD20")]
	private static int POJHALLGHHF(int DBILLPPAHGE, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x628B230", Offset = "0x628A030", VA = "0x18628B230")]
	private static int HECHOAPOBNN(int DBILLPPAHGE, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x628B120", Offset = "0x6289F20", VA = "0x18628B120")]
	public static int FFLJKEOIJMD(int AKDDGFBBJPG, int DBILLPPAHGE, int NLDGMLBHIIP, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x628B8B0", Offset = "0x628A6B0", VA = "0x18628B8B0")]
	public static int MDLOFAEKOKD(int AKDDGFBBJPG, int DBILLPPAHGE, int NLDGMLBHIIP, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x628B7F0", Offset = "0x628A5F0", VA = "0x18628B7F0")]
	public static int LHNGJMDOKJJ(int NLDGMLBHIIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x628B220", Offset = "0x628A020", VA = "0x18628B220")]
	private static int GONGBHOIFBD(int DBILLPPAHGE, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x628B9C0", Offset = "0x628A7C0", VA = "0x18628B9C0")]
	private static int NEOFCOAHPEB(int DBILLPPAHGE, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x628B1B0", Offset = "0x6289FB0", VA = "0x18628B1B0")]
	public static int FMACPPHBHPG(int AKDDGFBBJPG, int DBILLPPAHGE, int NLDGMLBHIIP, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x628B090", Offset = "0x6289E90", VA = "0x18628B090")]
	public static int ENCPHIDBPCC(int AKDDGFBBJPG, int DBILLPPAHGE, int NLDGMLBHIIP, bool KDHBBDKABGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x628B890", Offset = "0x628A690", VA = "0x18628B890")]
	public static int MBBHDEOIEPC(int NLDGMLBHIIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x628B300", Offset = "0x628A100", VA = "0x18628B300")]
	public static NHCHKKLNAGB JLGOGHGNHAP(int DBILLPPAHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x628A670", Offset = "0x6289470", VA = "0x18628A670")]
	private static NHCHKKLNAGB AMEGAJJNCFC(int DBILLPPAHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x628A900", Offset = "0x6289700", VA = "0x18628A900")]
	public static NHCHKKLNAGB BJOEPHGCJHJ(int DBILLPPAHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x628B9E0", Offset = "0x628A7E0", VA = "0x18628B9E0")]
	private static NHCHKKLNAGB PEMHDBDAKJL(int DBILLPPAHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x628B3F0", Offset = "0x628A1F0", VA = "0x18628B3F0")]
	public static void LEOGAJDGJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct CKBNFODBNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int GNNLPJEKOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 OOGNGINKOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion AIKOBLNMHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float DPPPGIBABCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float ONOKEEGODHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int MHCLJLHGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int HMNOCMLJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HOHEEMOOPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool AMMPEJFHMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool PGGABCNKPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float PJDALPELFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 JKDMJBBPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool HLGMAIKHLPK;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct GOJNOBAFNLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int GMFOFMHNLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int OJDGLFBOJLC;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct GKOMBKBPAMH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeList<CKBNFODBNJC> KFGIIALIAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeArray<PLANDAMNNMP> NMPNNCEMKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<MCJJEAPKCBK> LCOEHOIEKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<GOJNOBAFNLP> FNFEIKIMBLL;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6282110", Offset = "0x6280F10", VA = "0x186282110")]
	public GKOMBKBPAMH(NativeArray<PLANDAMNNMP> NMPNNCEMKOM, int CGDBKIJPKOF = 1, Allocator ACBNCIGINAO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6282020", Offset = "0x6280E20", VA = "0x186282020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
public struct HBAHKDJOCHK : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<KFKBCMFJIBD> OINLOLPMMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<int> ECMGMPFEENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeList<MCJJEAPKCBK> LAPELIOBDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<CKBNFODBNJC> KFGIIALIAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<PLANDAMNNMP> NMPNNCEMKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<MCJJEAPKCBK> LCOEHOIEKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<GOJNOBAFNLP> FNFEIKIMBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private int OMBJFKFBIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int DAFMPPCLNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float3 KGFLBIMDHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private quaternion PJDEDKIMKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 IMEEGCPMOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BLFFJNBEMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DPFECLKOCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FFAOLEICNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LHAHIAKKHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> GELBOOMHJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DDMHEPIDHMI;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x62855B0", Offset = "0x62843B0", VA = "0x1862855B0")]
	public HBAHKDJOCHK(DOFILONOFKK HPFPAIJONBP, GHBOPEHKLOP CIEGDHPDPNB, float3 BBMBPANLBLJ, quaternion KMNOIAOOFPL, float IHONBLJAHPP, int APNPKJEFNAH = 0, int EJNLEBBBKLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6285830", Offset = "0x6284630", VA = "0x186285830")]
	public HBAHKDJOCHK(GKOMBKBPAMH HPFPAIJONBP, GHBOPEHKLOP CIEGDHPDPNB, float3 BBMBPANLBLJ, quaternion KMNOIAOOFPL, float3 IHONBLJAHPP, int APNPKJEFNAH = 0, int EJNLEBBBKLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6285300", Offset = "0x6284100", VA = "0x186285300")]
	private float3 LMEGJFCEMPL(float3 LMCAJMDPIKL, Matrix4x4 JGFPJAKIIKK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6284C30", Offset = "0x6283A30", VA = "0x186284C30")]
	private float3x3 GHCNGEBHJNM(float3x3 MCICFPFJBLG, float3x3 IJKIHMHLJII)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6285430", Offset = "0x6284230", VA = "0x186285430")]
	private float LMICCPMHDIG(float HDBPIAOAHOC, float HENCKKENLIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6283A90", Offset = "0x6282890", VA = "0x186283A90", Slot = "4")]
	public void Execute(int OMMBGLAGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6285440", Offset = "0x6284240", VA = "0x186285440")]
	private void PKIMAMNIOFM(int CLEHINNDBFI, float3 JPLKOMKCHGP, float3 ELKFIDDLEIG, float3 CKPPHJKDBDN, float KOHJDCIMHLK, bool CPPMHOMLCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6283630", Offset = "0x6282430", VA = "0x186283630")]
	private void CMGOCHOCDIG(CKBNFODBNJC EINBCAIENOB, float3 KNKOADKCJLL, float3x3 PJAOGCBLNOI, float HDBPIAOAHOC, int JPAHIEPOJCA, int HEDDPLAGGNM, int PCAFGLBNOMP, float KNNPGKCNJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6284CB0", Offset = "0x6283AB0", VA = "0x186284CB0")]
	private void GJBFNGFFJKF(int CLEHINNDBFI, int EHKFLAMEJEG, CKBNFODBNJC EINBCAIENOB, float3 KNKOADKCJLL, float3x3 PJAOGCBLNOI, bool CEOMHHEIJNH, float HDBPIAOAHOC, int NGPGKCBDNEN, int DAGAOAOPFEF, int PCAFGLBNOMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct LFCLOFJIENK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeList<MJJOFJFBEEO> LAONDAJIGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeList<MCJJEAPKCBK> ELHNEAELLAA;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6289D70", Offset = "0x6288B70", VA = "0x186289D70")]
	public LFCLOFJIENK(int CGDBKIJPKOF, Allocator ACBNCIGINAO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6289CD0", Offset = "0x6288AD0", VA = "0x186289CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
public struct AKJOBKLCMKD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private enum BEEGDKNIPBH
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
	private NativeList<float3> GGAJHJDDJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float3> GGHAONKGCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeList<int> FKCKBMOBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeArray<int> FJHKFHLJELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeArray<float4> OGNEHEFJFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeArray<float4> AIGKILFNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<float4> FLFAMMFGEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<float3> KCBKMNADNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private NativeList<MCJJEAPKCBK> OPIMDDGNODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private NativeList<MJJOFJFBEEO> LAONDAJIGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private NativeList<MCJJEAPKCBK> ELHNEAELLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private int OMBJFKFBIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private int DAFMPPCLNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BLFFJNBEMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DPFECLKOCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FFAOLEICNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LHAHIAKKHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> GELBOOMHJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DDMHEPIDHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private float3 IMEEGCPMOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private quaternion PJDEDKIMKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 KGFLBIMDHJO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6271810", Offset = "0x6270610", VA = "0x186271810")]
	public AKJOBKLCMKD(DOFILONOFKK HPFPAIJONBP, GHBOPEHKLOP CIEGDHPDPNB, float3 BBMBPANLBLJ, quaternion KMNOIAOOFPL, float IHONBLJAHPP, int APNPKJEFNAH = 0, int EJNLEBBBKLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6271630", Offset = "0x6270430", VA = "0x186271630")]
	public AKJOBKLCMKD(LFCLOFJIENK LHODDAGAJKC, GHBOPEHKLOP CIEGDHPDPNB, float3 BBMBPANLBLJ, quaternion KMNOIAOOFPL, float3 IHONBLJAHPP, int APNPKJEFNAH = 0, int EJNLEBBBKLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6270220", Offset = "0x626F020", VA = "0x186270220", Slot = "4")]
	public void Execute(int OMMBGLAGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6271180", Offset = "0x626FF80", VA = "0x186271180")]
	private void IIBNNMNIFKL(float4x4 DFJLFDCKFCO, int OMMBGLAGAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6271570", Offset = "0x6270370", VA = "0x186271570")]
	private BEEGDKNIPBH LAJODBCALBG(float3 ELKFIDDLEIG)
	{
		return default(BEEGDKNIPBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x62715E0", Offset = "0x62703E0", VA = "0x1862715E0")]
	private float4 LDOKIMBEOHE(BEEGDKNIPBH JMILFLAPGGO, int AELAKOMEEDP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6271530", Offset = "0x6270330", VA = "0x186271530")]
	private float2 JNENLIKJPAI(BEEGDKNIPBH JMILFLAPGGO, float3 JPLKOMKCHGP)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct HCDLLDKEFIP
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum PPPJMCEGADP
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static HCDLLDKEFIP CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float3 LDNPGPEOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3x3 FCDMNAEMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 EDOPLBKMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public PPPJMCEGADP LNPLBOHLOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 JFIMMCPAEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 EPMDOIMOJPH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6286270", Offset = "0x6285070", VA = "0x186286270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 INGOJFMNOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6286430", Offset = "0x6285230", VA = "0x186286430")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6286900", Offset = "0x6285700", VA = "0x186286900")]
	public HCDLLDKEFIP(float3 JPLKOMKCHGP, quaternion IHHAEIJMAPE, float3 CGDBKIJPKOF, PPPJMCEGADP DDEINLAGLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6286070", Offset = "0x6284E70", VA = "0x186286070")]
	public float KPOIOIMMIII(float3 KNKOADKCJLL, float PBOIONGJPLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6285F80", Offset = "0x6284D80", VA = "0x186285F80")]
	public bool GIKFCPHFALM(float3 ELKFIDDLEIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6286280", Offset = "0x6285080", VA = "0x186286280")]
	public void LNAOHKHGFJO(float3 MBGBGADPBCL, float3x3 KOFFKGJJAGP, float BEOJOJBFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6286510", Offset = "0x6285310", VA = "0x186286510")]
	private void MGLMALLKDNA(float3 NJLPKKMGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6286610", Offset = "0x6285410", VA = "0x186286610")]
	public void PCPJKMCBCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
public struct PHIKFKHPJKK : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeList<HCDLLDKEFIP> LHODDAGAJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeList<float3> JCCAAPOCODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<int> JPLJAMNFPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CGCMJAGJGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<MCJJEAPKCBK> ELHNEAELLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private int DIKCPIHLGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int HDMKFAJIBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private float PBOIONGJPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private float PBBDMJGJOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> HLMCAJKEKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NMPHCMGIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> OFOLDMPABKG;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x628CB40", Offset = "0x628B940", VA = "0x18628CB40")]
	public PHIKFKHPJKK(GHBOPEHKLOP ANKNNGGBGOG, float FEPNNJOHMAI, int DLJHEFPEFCO, int JPAHIEPOJCA, NativeList<HCDLLDKEFIP> LHODDAGAJKC, NativeArray<int> CGCMJAGJGNF, NativeList<MCJJEAPKCBK> ELHNEAELLAA, PFLBJFEMLHD BDFOGIIFBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x628C0A0", Offset = "0x628AEA0", VA = "0x18628C0A0", Slot = "4")]
	public void Execute(int HCLPABHBCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x628C7E0", Offset = "0x628B5E0", VA = "0x18628C7E0")]
	private bool GJGBMMILBMO(HCDLLDKEFIP CGAHKNIFIAB, HCDLLDKEFIP CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x628C8A0", Offset = "0x628B6A0", VA = "0x18628C8A0")]
	private bool OOBPFJDDEDM(HCDLLDKEFIP OIDDJANNCDJ, int DGFPMLHKCGK, int FCHCCCIMKIL, int OAFBFNECHJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class PFLBJFEMLHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<bool> BANMHKLMAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<int> PIANLOMKPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<bool> DIIPDHCCLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float> DPFDPMMKIOK;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x628BFA0", Offset = "0x628ADA0", VA = "0x18628BFA0")]
	public void LIIGHDEMLFJ(int CCIFMHHICGF, int KFPKHOCPJLD, Allocator ACBNCIGINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x628BE90", Offset = "0x628AC90", VA = "0x18628BE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x628BEB0", Offset = "0x628ACB0", VA = "0x18628BEB0")]
	public void KGELIFGGPDE(JobHandle BNBGJBKKKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PFLBJFEMLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
public struct DIJGKFEIJJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NativeList<float3> JCCAAPOCODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NativeArray<float3> PPGENHJPCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NativeArray<float4> ECCLAHFCBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeArray<float2> MOMPDIJLKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NativeList<int> JPLJAMNFPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MEGLEIOIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<int> CHIKCGLEEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeArray<bool> HLMCAJKEKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<bool> NMPHCMGIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private int APNPKJEFNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private int EJNLEBBBKLD;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6275E60", Offset = "0x6274C60", VA = "0x186275E60")]
	public DIJGKFEIJJL(GHBOPEHKLOP ANKNNGGBGOG, PFLBJFEMLHD BDFOGIIFBEP, int EJNLEBBBKLD = 0, int APNPKJEFNAH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6275A20", Offset = "0x6274820", VA = "0x186275A20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6275E00", Offset = "0x6274C00", VA = "0x186275E00")]
	private void JMBGGLJGACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GBMHPBICCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x28C2E00", Offset = "0x28C1C00", VA = "0x1828C2E00")]
	public static bool LGGEDFALGPH<T>(NativeArray<T> OKLABKDOFAF, int CGDBKIJPKOF, Allocator ACBNCIGINAO, NativeArrayOptions KDIJMIPPONN = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x28C2F40", Offset = "0x28C1D40", VA = "0x1828C2F40")]
	public static bool LGGEDFALGPH<T>(NativeList<T> GIJBOOPKLBM, int CGDBKIJPKOF, Allocator ACBNCIGINAO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum LPHPHIJIINB
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
public interface HMNEJIAIMBE
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KBBPECFMJCA(LPHPHIJIINB AKDDGFBBJPG);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EHJJOKNLEFA(LPHPHIJIINB AKDDGFBBJPG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds DBLPDGMNFKH();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float AJDGHMPDCKB();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCKDPGPANHF(LPHPHIJIINB AKDDGFBBJPG, DOFILONOFKK KFCONNDEJPP, int LMEBKOAIGKF = -1);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GHBOPEHKLOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int AGJBDMNNLMB = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeList<float3> OANHOIJAGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NativeArray<float3> DJHFAGIBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NativeArray<float4> FHEHKKFGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeArray<float4> NJMKHPFPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeArray<float2> JHLBKPOLAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<int> JOOFJPGKGCO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JODNNLIOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6280A80", Offset = "0x627F880", VA = "0x186280A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MKAIINJDMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6280AC0", Offset = "0x627F8C0", VA = "0x186280AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OKICDHGLENM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6280CD0", Offset = "0x627FAD0", VA = "0x186280CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CMNOMCINFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6280C90", Offset = "0x627FA90", VA = "0x186280C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6280B80", Offset = "0x627F980", VA = "0x186280B80", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6281CB0", Offset = "0x6280AB0", VA = "0x186281CB0")]
	public void LIIGHDEMLFJ(int CCIFMHHICGF, int KFPKHOCPJLD, Allocator ACBNCIGINAO, bool IIODOJGLMCP, bool MDPHAOBICBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6280B00", Offset = "0x627F900", VA = "0x186280B00")]
	public void DOJEOIAIPFE(int CCIFMHHICGF, int KFPKHOCPJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6280F80", Offset = "0x627FD80", VA = "0x186280F80", Slot = "6")]
	public bool IHDPGMJKAAN(Mesh ANKNNGGBGOG, bool LFEMOJCJNIP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x62814A0", Offset = "0x62802A0", VA = "0x1862814A0")]
	public bool LIBIBDNNDEA(Mesh ANKNNGGBGOG, GHBOPEHKLOP OMJANABAKNP, bool LFEMOJCJNIP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6280D10", Offset = "0x627FB10", VA = "0x186280D10")]
	public void HFCJNOLAJIF(GHBOPEHKLOP ANKNNGGBGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6281360", Offset = "0x6280160", VA = "0x186281360")]
	public GHBOPEHKLOP KKGLAFBLIAH(Allocator ACBNCIGINAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6281E80", Offset = "0x6280C80", VA = "0x186281E80")]
	public long MGBJMBACNDJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6281FC0", Offset = "0x6280DC0", VA = "0x186281FC0")]
	public void OMJBIHEAJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GHBOPEHKLOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CBCEIAJCDAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x62757D0", Offset = "0x62745D0", VA = "0x1862757D0")]
	public static void LEOGAJDGJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GLDLOCHMJJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<float3> OANHOIJAGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<float3> DJHFAGIBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<int> PPILGHKKNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<float4> MBNOOPLEGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<float4> MJEOFKOJADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float4> IPCPBJAHBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public NativeList<float3> DMDGDLHMLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public NativeList<int> JOOFJPGKGCO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MKAIINJDMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6282240", Offset = "0x6281040", VA = "0x186282240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OKICDHGLENM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6282820", Offset = "0x6281620", VA = "0x186282820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FNBCEMNHMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x62830E0", Offset = "0x6281EE0", VA = "0x1862830E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6283120", Offset = "0x6281F20", VA = "0x186283120")]
	public GLDLOCHMJJM(int CCIFMHHICGF, int KFPKHOCPJLD, int GHKOPBOPHKG, Allocator ACBNCIGINAO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6283340", Offset = "0x6282140", VA = "0x186283340")]
	public GLDLOCHMJJM(Mesh ANKNNGGBGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6282710", Offset = "0x6281510", VA = "0x186282710", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6282860", Offset = "0x6281660", VA = "0x186282860")]
	public void HFCJNOLAJIF(GLDLOCHMJJM ANKNNGGBGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6282280", Offset = "0x6281080", VA = "0x186282280")]
	private void CMJFDKJKICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6282B60", Offset = "0x6281960", VA = "0x186282B60")]
	private void JJOGLPBAMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct MCJJEAPKCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public int BPHJAHCJNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int MKAIINJDMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int OCMJBKFKAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public int OKICDHGLENM;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x126BC30", Offset = "0x126AA30", VA = "0x18126BC30")]
	public MCJJEAPKCBK(int JPAHIEPOJCA, int JOFPJDBJGBF, int DLJHEFPEFCO, int DBNJBEFKFNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class MOFPICGIMGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<MCJJEAPKCBK> MPKGIPKDDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<MCJJEAPKCBK>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x83F150", Offset = "0x83DF50", VA = "0x18083F150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GLDLOCHMJJM JLPGLGHJJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6289ED0", Offset = "0x6288CD0", VA = "0x186289ED0")]
	public MOFPICGIMGL(IEnumerable<GLDLOCHMJJM> LOJEPNOBGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6289E60", Offset = "0x6288C60", VA = "0x186289E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum OFEMPLFHBFE
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ILANLMEFBHI
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static NativeArray<float2> GEONNCEEDFI;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NativeArray<float3> DMDKCKCEMIH;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static NativeArray<float4> AOKLFNDDPLN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeArray<int> GACPKHAFBCG;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6288960", Offset = "0x6287760", VA = "0x186288960")]
	public static void LEOGAJDGJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6288A70", Offset = "0x6287870", VA = "0x186288A70")]
	public static NativeArray<float2> NPDCINCFLFJ(NativeArray<float2> GPNDFNEDONE, int AFAPDGKPICG, NativeArray<float2> GFLFAENGNGP, int AHDENPOPNMD)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6288760", Offset = "0x6287560", VA = "0x186288760")]
	public static NativeArray<float3> AHFLIJFEOGJ(NativeArray<float3> GPNDFNEDONE, int AFAPDGKPICG, NativeArray<float3> GFLFAENGNGP, int AHDENPOPNMD)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6288860", Offset = "0x6287660", VA = "0x186288860")]
	public static NativeArray<float4> FHAMMADODDP(NativeArray<float4> GPNDFNEDONE, int AFAPDGKPICG, NativeArray<float4> GFLFAENGNGP, int AHDENPOPNMD)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6288660", Offset = "0x6287460", VA = "0x186288660")]
	public static NativeArray<int> AGOKIEFCJNP(NativeArray<int> GPNDFNEDONE, int AFAPDGKPICG, NativeArray<int> GFLFAENGNGP, int AHDENPOPNMD)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x29081C0", Offset = "0x2906FC0", VA = "0x1829081C0")]
	private static void IKFGCLGHNAL<T>(NativeArray<T> OKLABKDOFAF, int BLNGKDHIINF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x29083C0", Offset = "0x29071C0", VA = "0x1829083C0")]
	private static void MOFKLJPNMBK<T>(NativeArray<T> GPNDFNEDONE, int AFAPDGKPICG, NativeArray<T> GFLFAENGNGP, int AHDENPOPNMD, NativeArray<T> NHLEALMEMOC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DebuggerStepThrough]
public static class PKPGNLIDNIG
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public static void JJAOKHNBOOP(bool KDBMKOJJIJP, string ECCIPALNFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public static void JJAOKHNBOOP(bool KDBMKOJJIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EJALGENPLHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal enum OOCBIEOFGFO
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
	public class GEKNHEMGBCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BFNHPMJKBMI ANKNNGGBGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int EHOGCEHDLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int HEPNECHMKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long JDJNDLDFGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public long EJFNLJMFMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float GPKAKKBHPBE;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6297630", Offset = "0x6296430", VA = "0x186297630")]
		public GEKNHEMGBCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x62975F0", Offset = "0x62963F0", VA = "0x1862975F0")]
		public void KGELIFGGPDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly string OEJLGHNECDE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly string AKCCJGHGPHG;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker CDDMBJDMMNO;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker JHCFEOELHCO;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker MOPLNBMDJIB;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker PJKPDOOCLJP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker ONCACJBKCMA;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker GANEFAFLEEC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker ODOBDLGGMCB;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker CHEMLFCLEBF;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker GPAFFDMNOKP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker EBKHEAKGFFP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker CKECBOBFAPC;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker BNKPFCBFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<HMNEJIAIMBE> AEBHMCHAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly OFLIHLAMOOO DHCEDHLCMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int JOFPJDBJGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int DBNJBEFKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool DNAJNHJLBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	internal bool NOBEMHIHMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	internal OOCBIEOFGFO DEPIDMABJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	internal bool OJDIEOCNGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal float3 AKNMNKOGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal float3 IPFDLMGKKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal float FLBPIMEEBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	internal float DEMHDFIIAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	internal int IHJNGEGIAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	internal int ICLHNBLPJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int OJKJGCLEEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float HADKPKOHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float OECFPGKLJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int JBJFFDMPJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long HAPGFFKGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long OKFMBAIDGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private long NKNBGGLOLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int JMMCHHFDOGH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int JOPMPADMIEA = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float[] IKKGKIEMNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int[] BJGAHOHKPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private long[] DGKGNDKOABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private GHBOPEHKLOP GAJJBJDAMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private long HMJHJIBKNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private long HIOHFJMDFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int LOENCHLCMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private List<GEKNHEMGBCD> IBLGDNGMPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	internal float BCDDMHBBAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool IBIEMFPECMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private LFDPAAFLBND KCCAKAMGIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JobHandle AIJOLJFOABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal NativeArray<long> ILLHHDHLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool LFDOMNOKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private JobHandle JHHPCBJLGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private GHBOPEHKLOP LAHHKICKBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Transform CJHAFHAKMAD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh JLPGLGHJJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer OPPELFFOFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int APMFCJHIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DF0", Offset = "0xAD4BF0", VA = "0x180AD5DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int HJPINICDDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F60", Offset = "0x7D5D60", VA = "0x1807D6F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MKAIINJDMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x627AF50", Offset = "0x6279D50", VA = "0x18627AF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<HMNEJIAIMBE> OECPMPIGCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x627FF00", Offset = "0x627ED00", VA = "0x18627FF00")]
	public void NCDCNEMLOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6278E10", Offset = "0x6277C10", VA = "0x186278E10")]
	private void BJMLEFDABBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6280280", Offset = "0x627F080", VA = "0x186280280")]
	public EJALGENPLHJ(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x627E8B0", Offset = "0x627D6B0", VA = "0x18627E8B0")]
	public void KGELIFGGPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6278CB0", Offset = "0x6277AB0", VA = "0x186278CB0")]
	public void ALGODHHGHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x627C490", Offset = "0x627B290", VA = "0x18627C490")]
	private void EPCJKGBIHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x627F3C0", Offset = "0x627E1C0", VA = "0x18627F3C0")]
	public void MAJPOCGNALJ(HMNEJIAIMBE ABCEEMENENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x627B7E0", Offset = "0x627A5E0", VA = "0x18627B7E0")]
	public bool ECLOGEMDECM(HMNEJIAIMBE ABCEEMENENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x627D340", Offset = "0x627C140", VA = "0x18627D340")]
	public bool FLKCGLEENDL(HMNEJIAIMBE ABCEEMENENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x627C980", Offset = "0x627B780", VA = "0x18627C980", Slot = "4")]
	public virtual void FDMJFMNGPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x627D710", Offset = "0x627C510", VA = "0x18627D710")]
	public void IOCKCAOGFNI(Transform DMOFAIGEHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x627B880", Offset = "0x627A680", VA = "0x18627B880")]
	public bool EMLKCGGKBIL(Transform DMOFAIGEHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x627D890", Offset = "0x627C690", VA = "0x18627D890")]
	public bool JAAEBOBGPKK(bool KJJOPLNNAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x627AF70", Offset = "0x6279D70", VA = "0x18627AF70")]
	public void CGHBOEACLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6278FF0", Offset = "0x6277DF0", VA = "0x186278FF0")]
	public bool CALJCLLILJM(float4x4 IPDNDKBJMMA, BatchedMeshRenderer ACDBNABCHIJ, bool DMBFKMMGIFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6278D40", Offset = "0x6277B40", VA = "0x186278D40")]
	public void BDPLDFIDBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x627B160", Offset = "0x6279F60", VA = "0x18627B160")]
	public bool DCOOGNCBNDB(bool KJJOPLNNAJE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x627F240", Offset = "0x627E040", VA = "0x18627F240")]
	public void KLHPPCHJEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x627D6E0", Offset = "0x627C4E0", VA = "0x18627D6E0")]
	public void IKPNJGDGKDP(GHBOPEHKLOP ANKNNGGBGOG, int BPMIGAFACCM, float LHEBKFELKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x627B440", Offset = "0x627A240", VA = "0x18627B440")]
	public void DGFPBMHIIBA(BFNHPMJKBMI NPLKFFCCFPP, int BPMIGAFACCM, float LHEBKFELKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x627F520", Offset = "0x627E320", VA = "0x18627F520")]
	public long MGBJMBACNDJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE680", Offset = "0x7AD480", VA = "0x1807AE680")]
	public long HDJNMFKDKFO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x627F250", Offset = "0x627E050", VA = "0x18627F250")]
	private void KOGLFCICKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x627B470", Offset = "0x627A270", VA = "0x18627B470")]
	public (long, long) DHDGDMLELNP(float KCFJNIJKJPK, float4x4 IPDNDKBJMMA)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xA7B2A0", Offset = "0xA7A0A0", VA = "0x180A7B2A0")]
	internal void EGPGKPAJEKD(OOCBIEOFGFO HHOFGBEPAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x627E9C0", Offset = "0x627D7C0", VA = "0x18627E9C0")]
	private (float, float, float) KJEOMDALJIE(float BBNHIPPPMAH, float4x4 IPDNDKBJMMA)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x627C700", Offset = "0x627B500", VA = "0x18627C700")]
	private (int, int) FDLNOKIHMOJ(float FFFBOMJLJEN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6279E60", Offset = "0x6278C60", VA = "0x186279E60")]
	public void CEAPHKLHLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x627D3A0", Offset = "0x627C1A0", VA = "0x18627D3A0")]
	private void GLINHAPONJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x627E6F0", Offset = "0x627D4F0", VA = "0x18627E6F0")]
	private void KDOPNPENDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x627CA30", Offset = "0x627B830", VA = "0x18627CA30")]
	private void FGKKDPPCFCI(GHBOPEHKLOP PFBKCOILDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x627D3D0", Offset = "0x627C1D0", VA = "0x18627D3D0")]
	private void HPCAGFKHGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x627F530", Offset = "0x627E330", VA = "0x18627F530")]
	private void MPNCEEOCEBF(GHBOPEHKLOP ANKNNGGBGOG, BFNHPMJKBMI NPLKFFCCFPP, int BPMIGAFACCM, float LHEBKFELKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[BurstCompile]
internal struct LFDPAAFLBND : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct OJPBIIFAMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int JBHJCODDHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int KLEOLDFFMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int ANBPCGMLNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int CGGMFILHGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int DAKLBBNFANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int LAOPDFENACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int EHOGCEHDLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int HEPNECHMKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float GPKAKKBHPBE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct ALIBCIPNJIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public EGHACKPEHAD.MEFPDNOLPCN HIJACOLMDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float LGDCMGLELED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float PJHGEJGIABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float HPBFBFPOEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float LDEOOJIBJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float DKIDFEJGPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float PJPDCOANJDL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct LPOAHBGFAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NativeArray<float3> OANHOIJAGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NativeArray<float3> DJHFAGIBHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NativeArray<float4> FHEHKKFGJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NativeArray<float4> NJMKHPFPALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NativeArray<float2> JHLBKPOLAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NativeArray<int> JOOFJPGKGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool IEDEAAJLEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int MKAIINJDMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int OKICDHGLENM;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x629A230", Offset = "0x6299030", VA = "0x18629A230")]
		public void LIIGHDEMLFJ(int CCIFMHHICGF, int KFPKHOCPJLD, Allocator ACBNCIGINAO, bool MDPHAOBICBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6299F20", Offset = "0x6298D20", VA = "0x186299F20")]
		public static LPOAHBGFAIN EGNCANIPFMA(GHBOPEHKLOP EKLFCLOPJMB)
		{
			return default(LPOAHBGFAIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x629A170", Offset = "0x6298F70", VA = "0x18629A170")]
		public void KGELIFGGPDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker LJCJICGPNCF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker NBFKGJCBJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private NativeArray<OJPBIIFAMNC> BKHKMEHAHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private LPOAHBGFAIN GBFJADHOAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private LPOAHBGFAIN PFBKCOILDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float3 HKJJLECANNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private float3 JJPDFOJJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private ALIBCIPNJIJ NJHANHKDGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* OIHNECBIIMI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x62998F0", Offset = "0x62986F0", VA = "0x1862998F0")]
	public LFDPAAFLBND([In] List<EJALGENPLHJ.GEKNHEMGBCD> DCODPANFHFC, [In] GHBOPEHKLOP AIFFAFMFJEC, [In] EJALGENPLHJ FCEIMHAKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6298170", Offset = "0x6296F70", VA = "0x186298170", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6297680", Offset = "0x6296480", VA = "0x186297680")]
	public void CCHBFAFFKGO(List<EJALGENPLHJ.GEKNHEMGBCD> POMPFJFLHOP, [In] EJALGENPLHJ FCEIMHAKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6299840", Offset = "0x6298640", VA = "0x186299840")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool OHDEMOHNFHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x62981C0", Offset = "0x6296FC0", VA = "0x1862981C0")]
	private BFNHPMJKBMI LLMGHILBDNC(int OFCCPMFIIFH, Allocator ACBNCIGINAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6298290", Offset = "0x6297090", VA = "0x186298290")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void MBINGLMOEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6297D30", Offset = "0x6296B30", VA = "0x186297D30")]
	[IgnoreWarning(1371)]
	private OJPBIIFAMNC CIDDHAFHPCH([In] OJPBIIFAMNC NGLOOLIFNFE, int CDOMNFBAIBG, [In] NativeArray<int> JPLJAMNFPJG, [In] NativeArray<bool> NMPHCMGIDOK, NativeArray<int> CJCGJNGEAHC)
	{
		return default(OJPBIIFAMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6299740", Offset = "0x6298540", VA = "0x186299740")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int MOGKMBFLAHA(NativeArray<int> JPLJAMNFPJG, int CHIEKPJFLIK, int IMNOMCGECNA, int JAIJIHHAADB)
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
		private static readonly ProfilerMarker EOKIDOFPPLL;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly ProfilerMarker HCJJONFAAEM;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly ProfilerMarker PKMFBGLMJGF;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly ProfilerMarker LICPJDGMOFF;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly ProfilerMarker ONCACJBKCMA;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly ProfilerMarker MCNEFMKLDJI;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly ProfilerMarker EFCKHCNIBNL;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal const int BHMABPNFKCC = 65000;

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
		private Dictionary<Material, List<EJALGENPLHJ>> NKBJPOGFGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal List<EJALGENPLHJ> KGHKHOEGCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private List<MeshRenderer> FHJKHOHFGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool CCCDGDCMNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool DBILELKKFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int CHPLGIAPFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Dictionary<int, float> NGLPEEPPMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Dictionary<int, Color> IPBGGJFEIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Dictionary<int, Vector4> HNNMBKDFNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, Matrix4x4> JEHGDIPGDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private EJALGENPLHJ AABEGCBIGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Material IIHGPKLKOLN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> EGJBPDGIJKG
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int EPJINDEKMDC
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x6293780", Offset = "0x6292580", VA = "0x186293780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6290300", Offset = "0x628F100", VA = "0x186290300")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x628E2E0", Offset = "0x628D0E0", VA = "0x18628E2E0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x628DE20", Offset = "0x628CC20", VA = "0x18628DE20")]
		public EJALGENPLHJ AddToBatchedMesh(HMNEJIAIMBE MIGDLKCIFEO, Material LKFHNDFBKCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6292980", Offset = "0x6291780", VA = "0x186292980")]
		public void RemoveFromBatchedMesh(HMNEJIAIMBE ANKNNGGBGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x628E1B0", Offset = "0x628CFB0", VA = "0x18628E1B0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6292AC0", Offset = "0x62918C0", VA = "0x186292AC0")]
		public void SetMaterialProperty(int POKGHOJNGNN, Color BGJPICBMDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6292F40", Offset = "0x6291D40", VA = "0x186292F40")]
		public void SetMaterialProperty(int POKGHOJNGNN, float DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6293150", Offset = "0x6291F50", VA = "0x186293150")]
		public void SetMaterialProperty(int POKGHOJNGNN, Vector4 BIODAAJEIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6292CE0", Offset = "0x6291AE0", VA = "0x186292CE0")]
		public void SetMaterialProperty(int POKGHOJNGNN, Matrix4x4 JNNFCLPMJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x628FB10", Offset = "0x628E910", VA = "0x18628FB10")]
		private void NDKPKGKNCBO(Renderer INJBJDLKFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x628EA20", Offset = "0x628D820", VA = "0x18628EA20")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x628EA10", Offset = "0x628D810", VA = "0x18628EA10")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x628E4A0", Offset = "0x628D2A0", VA = "0x18628E4A0")]
		private void FDMOAAJFGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x628DF20", Offset = "0x628CD20", VA = "0x18628DF20")]
		private EJALGENPLHJ BNPEFDHJOBK(HMNEJIAIMBE ANKNNGGBGOG, Material LKFHNDFBKCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6290100", Offset = "0x628EF00", VA = "0x186290100")]
		private EJALGENPLHJ OOELCOBKDJE(Material LKFHNDFBKCD, int AMOFDNNJBFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x628F080", Offset = "0x628DE80", VA = "0x18628F080")]
		private EJALGENPLHJ KPBIMDPAMHP(Material LKFHNDFBKCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1758C10", Offset = "0x1757A10", VA = "0x181758C10")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x628F5F0", Offset = "0x628E3F0", VA = "0x18628F5F0")]
		public void MarkDirty(HMNEJIAIMBE ANKNNGGBGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x628F750", Offset = "0x628E550", VA = "0x18628F750")]
		public (long, long) MemorySizeInBytesForChosenDetail(float KCFJNIJKJPK)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6291AD0", Offset = "0x62908D0", VA = "0x186291AD0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x628EAC0", Offset = "0x628D8C0", VA = "0x18628EAC0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x62905F0", Offset = "0x628F3F0", VA = "0x1862905F0")]
		public void RebatchOptimally(int FNFCJOFDKEN, int FKFJHPPLHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6293510", Offset = "0x6292310", VA = "0x186293510")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class EBJHLDKDDHM
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct CJMHLMCKEEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public float BLHNHPBIGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BatchedMeshRenderer GLMJNHBHOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public EJALGENPLHJ MPAIHMBHNNO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly ProfilerMarker ONCACJBKCMA;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ProfilerMarker CBPJNMLHGCG;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly ProfilerMarker AOIFBKEHIFB;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ProfilerMarker AKAEKJEJEGG;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public static float3 MKJAGGFMPKH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public static int GKMHOJBNLLH;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static int GHDEBDBDIBO;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static int KCGHANANHLO;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public static int LBPJMKNAMFH;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public static int MBIGJHIJOJL;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static int CCLBJAECEKN;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static int NBDFGIMOJIC;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static int IPDPOKEPHIJ;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static int EDGIMNBAHJH;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static int MOPFPDJIPOB;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public static int JLAPDCDNPFI;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public static int GFKIFIGHOPN;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public static int KDEHFHJEPCL;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public static int JAFPPOBDJKC;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static int ECOMNLGLLMF;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public static int BFDPEAIPHHO;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public static long DOPDBBJGPCA;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public static bool IAHDMKMCGPN;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<BatchedMeshRenderer> EABKFKLJCNG;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static List<CJMHLMCKEEA> BHBNFCKOCDI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool EJBNLFCFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6296E90", Offset = "0x6295C90", VA = "0x186296E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6296CC0", Offset = "0x6295AC0", VA = "0x186296CC0")]
	public static void LMFMKFLHHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6296ED0", Offset = "0x6295CD0", VA = "0x186296ED0")]
	public static void MOOJGMOBKME(BatchedMeshRenderer HKDJPOFABPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6296760", Offset = "0x6295560", VA = "0x186296760")]
	public static void FALJFOJDEDH(BatchedMeshRenderer HKDJPOFABPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6296A80", Offset = "0x6295880", VA = "0x186296A80")]
	private static void JONJJDPEGCK([Out] long IGGFBPGICOA, [Out] long KMDDLMEKJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6293A60", Offset = "0x6292860", VA = "0x186293A60")]
	public static void CALJCLLILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6296C20", Offset = "0x6295A20", VA = "0x186296C20")]
	public static void LHAJMAIJEOE(EJALGENPLHJ MPAIHMBHNNO, BatchedMeshRenderer GLMJNHBHOMA, float BLHNHPBIGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6296170", Offset = "0x6294F70", VA = "0x186296170")]
	public static void DDGBDALJPEL(EJALGENPLHJ MPAIHMBHNNO, BatchedMeshRenderer GLMJNHBHOMA, float OPIBLOAMEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x62937D0", Offset = "0x62925D0", VA = "0x1862937D0")]
	public static void AIJDKPFAIAL(EJALGENPLHJ MPAIHMBHNNO, BatchedMeshRenderer GLMJNHBHOMA, float OPIBLOAMEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6296920", Offset = "0x6295720", VA = "0x186296920")]
	public static void JHLGFKHMJEB(EJALGENPLHJ MPAIHMBHNNO, BatchedMeshRenderer GLMJNHBHOMA, float BLHNHPBIGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x62971B0", Offset = "0x6295FB0", VA = "0x1862971B0")]
	public static void OMACOLKILEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6293870", Offset = "0x6292670", VA = "0x186293870")]
	public static void BJLKOAPEDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x62963E0", Offset = "0x62951E0", VA = "0x1862963E0")]
	public static float EDMPECIGLGL(long DOFJGBABKJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6296210", Offset = "0x6295010", VA = "0x186296210")]
	public static (long, long) DHDGDMLELNP(float KCFJNIJKJPK)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6295680", Offset = "0x6294480", VA = "0x186295680")]
	public static void CIICIENCPAK(bool GKBMENMKBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6296800", Offset = "0x6295600", VA = "0x186296800")]
	public static int JDHBOKOPHJP()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MPJCCMKNGFJ<KeyType> : EJALGENPLHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<KeyType, HMNEJIAIMBE> OEGOJINNIJM;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE0C0", Offset = "0x3FBCEC0", VA = "0x183FBE0C0")]
	public MPJCCMKNGFJ(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3FBDED0", Offset = "0x3FBCCD0", VA = "0x183FBDED0")]
	public void MAJPOCGNALJ(KeyType OBPLDLNDJLE, HMNEJIAIMBE ABCEEMENENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3FBDF20", Offset = "0x3FBCD20", VA = "0x183FBDF20")]
	public bool MPMGHFEPKNK(KeyType OBPLDLNDJLE, HMNEJIAIMBE GHHLILJCPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3FBDE30", Offset = "0x3FBCC30", VA = "0x183FBDE30")]
	public void LFPPFJHHLAA(KeyType OBPLDLNDJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FBDD50", Offset = "0x3FBCB50", VA = "0x183FBDD50", Slot = "4")]
	public override void FDMJFMNGPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x629A380", Offset = "0x6299180", VA = "0x18629A380")]
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
