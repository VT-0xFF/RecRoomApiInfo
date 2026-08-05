using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6965330", Offset = "0x6964530", VA = "0x186965330", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EBIEIMGKHLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int LKCNGBKCKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 EDONIHELBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion AHOGEDELABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 KICMOIFFJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KHHANACNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int GMOFENMBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int CBCMDKGALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float KFJEHKPDOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 IOBKMFFMDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool AGNGGCKFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public EJHKOLMCNPF BMNEKJLFHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 DINEKBBJFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float JPPJKMJJAAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HIMGIDMIPBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static PPDAGFFIHDK OLEMGABILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<EBIEIMGKHLJ> IEBGHEFNAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<HDBOOPAJBBL> HDKBGAGMPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<HGDOAMLPNBP> GNFMCHBMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<BEEODNIICBD> NNNKBJMJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<HDBOOPAJBBL> NPIJGJPKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<MNNGJMLJGGM> JMIPFGONGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<BEEODNIICBD>> NIKJGLFAHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<OALODHMDGLN> AJHCJGABJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> PEFLDMODNIF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDB93F0", Offset = "0xDB85F0", VA = "0x180DB93F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDB8A70", Offset = "0xDB7C70", VA = "0x180DB8A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA70590", Offset = "0xA6F790", VA = "0x180A70590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB7E80", Offset = "0xDB7080", VA = "0x180DB7E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69612F0", Offset = "0x69604F0", VA = "0x1869612F0")]
	public HIMGIDMIPBN(int CKAMNHGFMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x695FBE0", Offset = "0x695EDE0", VA = "0x18695FBE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6960DB0", Offset = "0x695FFB0", VA = "0x186960DB0")]
	public void EECPCLJADFI(JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69610D0", Offset = "0x69602D0", VA = "0x1869610D0")]
	public void NGBKMPGDDCO(EBIEIMGKHLJ LINJEFIAFHO, OALODHMDGLN HILLMJIKOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6960F80", Offset = "0x6960180", VA = "0x186960F80")]
	public void LDLOEJGPNMP(HGDOAMLPNBP LINJEFIAFHO, NativeArray<BEEODNIICBD> CMIJPDGNFOI, int BHPOFKEKDPM, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x695FDA0", Offset = "0x695EFA0", VA = "0x18695FDA0")]
	public JobHandle EDGJAHCBCOE(NAJBPEBBKNG OPDABIFMIPI, LEFCAAKHOCL OCHMECPEPDN, float3 HMCDIKIEIPP, quaternion CBELOFBFGLG, float KCLKPLDJNJE, bool HJHHNOJHCHH, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x695F8A0", Offset = "0x695EAA0", VA = "0x18695F8A0")]
	public static JobHandle DKDCBGBAPGG(KGPNDFHLDEG CGOBGJGGBOO, NAJBPEBBKNG OPDABIFMIPI, EBIEIMGKHLJ LINJEFIAFHO, JobHandle BHOKFONKIGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x695F5F0", Offset = "0x695E7F0", VA = "0x18695F5F0")]
	public static JobHandle BGMGEKDFLHH(GEAABJGODDH CGOBGJGGBOO, NAJBPEBBKNG OPDABIFMIPI, HGDOAMLPNBP LINJEFIAFHO, NativeArray<BEEODNIICBD> CMIJPDGNFOI, int BHPOFKEKDPM, int HOLGDCGDMAL, JobHandle BHOKFONKIGD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class ONMMPCFPEBK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NIOMDIPAKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half JDLGFPFCPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort EJAHNGGCDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte JMDNHKONCLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void GNMFOFLEPKG([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class NNAEKCOKOBD
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69668B0", Offset = "0x6965AB0", VA = "0x1869668B0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69669E0", Offset = "0x6965BE0", VA = "0x1869669E0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6966800", Offset = "0x6965A00", VA = "0x186966800")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69665F0", Offset = "0x69657F0", VA = "0x1869665F0")]
		public unsafe static void APPOJKGPLJE([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void KPEFBHIFJIN([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class BLCFLLIOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6955950", Offset = "0x6954B50", VA = "0x186955950")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6955A80", Offset = "0x6954C80", VA = "0x186955A80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69558A0", Offset = "0x6954AA0", VA = "0x1869558A0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6955610", Offset = "0x6954810", VA = "0x186955610")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void FLFGBOKEKGI([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class LBDMMPDIFHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6964D80", Offset = "0x6963F80", VA = "0x186964D80")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6964EB0", Offset = "0x69640B0", VA = "0x186964EB0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6964CD0", Offset = "0x6963ED0", VA = "0x186964CD0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6964A40", Offset = "0x6963C40", VA = "0x186964A40")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void AMGDMIFFDGK([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class ADAGFKLPDID
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6953C40", Offset = "0x6952E40", VA = "0x186953C40")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6953D70", Offset = "0x6952F70", VA = "0x186953D70")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6953B90", Offset = "0x6952D90", VA = "0x186953B90")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6953900", Offset = "0x6952B00", VA = "0x186953900")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void CBINOMBDLCB([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class DBCGAANEPLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6958CC0", Offset = "0x6957EC0", VA = "0x186958CC0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6958DF0", Offset = "0x6957FF0", VA = "0x186958DF0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6958C10", Offset = "0x6957E10", VA = "0x186958C10")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69589F0", Offset = "0x6957BF0", VA = "0x1869589F0")]
		public unsafe static void APPOJKGPLJE([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void IPMKILBKMMC([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class FMELBOHOBPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x695C8E0", Offset = "0x695BAE0", VA = "0x18695C8E0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x695CA10", Offset = "0x695BC10", VA = "0x18695CA10")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x695C830", Offset = "0x695BA30", VA = "0x18695C830")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x695C640", Offset = "0x695B840", VA = "0x18695C640")]
		public unsafe static void APPOJKGPLJE([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void ANALANCFIAP([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class KKOJJLGJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6962FC0", Offset = "0x69621C0", VA = "0x186962FC0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69630F0", Offset = "0x69622F0", VA = "0x1869630F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6962F10", Offset = "0x6962110", VA = "0x186962F10")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6962CC0", Offset = "0x6961EC0", VA = "0x186962CC0")]
		public unsafe static void APPOJKGPLJE([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void CDDKKBENKFJ([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class KBFJFLCINJL
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69628A0", Offset = "0x6961AA0", VA = "0x1869628A0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69629D0", Offset = "0x6961BD0", VA = "0x1869629D0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69627F0", Offset = "0x69619F0", VA = "0x1869627F0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6962600", Offset = "0x6961800", VA = "0x186962600")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void HLCBEBOOICP([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class PHHFJMADFLP
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x696F6B0", Offset = "0x696E8B0", VA = "0x18696F6B0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x696F7E0", Offset = "0x696E9E0", VA = "0x18696F7E0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x696F600", Offset = "0x696E800", VA = "0x18696F600")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x696F340", Offset = "0x696E540", VA = "0x18696F340")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void OJKMMCMEGAI([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class HAJHKBEEDHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x695E760", Offset = "0x695D960", VA = "0x18695E760")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x695E890", Offset = "0x695DA90", VA = "0x18695E890")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x695E6B0", Offset = "0x695D8B0", VA = "0x18695E6B0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x695E400", Offset = "0x695D600", VA = "0x18695E400")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void JODMIHANILK([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class GDGLJIENGLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x695CE40", Offset = "0x695C040", VA = "0x18695CE40")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x695CF70", Offset = "0x695C170", VA = "0x18695CF70")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x695CD90", Offset = "0x695BF90", VA = "0x18695CD90")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x695CB70", Offset = "0x695BD70", VA = "0x18695CB70")]
		public unsafe static void APPOJKGPLJE([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void CDGHJBGHBEL([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class CHNHPGOECKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6956770", Offset = "0x6955970", VA = "0x186956770")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x69568A0", Offset = "0x6955AA0", VA = "0x1869568A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69566C0", Offset = "0x69558C0", VA = "0x1869566C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6956480", Offset = "0x6955680", VA = "0x186956480")]
		public static void APPOJKGPLJE([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void PGCDOAPFOPG([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class CIJCJPDACNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6956D40", Offset = "0x6955F40", VA = "0x186956D40")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6956E70", Offset = "0x6956070", VA = "0x186956E70")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6956C90", Offset = "0x6955E90", VA = "0x186956C90")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6956A00", Offset = "0x6955C00", VA = "0x186956A00")]
		public unsafe static void APPOJKGPLJE([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void GCEMAGKJKPA([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class MCJGNCEKONH
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6965800", Offset = "0x6964A00", VA = "0x186965800")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6965930", Offset = "0x6964B30", VA = "0x186965930")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6965750", Offset = "0x6964950", VA = "0x186965750")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6965480", Offset = "0x6964680", VA = "0x186965480")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void DFENGHFBNEG([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class NMCGDKABAMF
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6966360", Offset = "0x6965560", VA = "0x186966360")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6966490", Offset = "0x6965690", VA = "0x186966490")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69662B0", Offset = "0x69654B0", VA = "0x1869662B0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6965FE0", Offset = "0x69651E0", VA = "0x186965FE0")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void HBLNEDLEDHO([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class EOJBPBCLJMH
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x695C3B0", Offset = "0x695B5B0", VA = "0x18695C3B0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x695C4E0", Offset = "0x695B6E0", VA = "0x18695C4E0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x695C300", Offset = "0x695B500", VA = "0x18695C300")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x695BF50", Offset = "0x695B150", VA = "0x18695BF50")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void BKIGFDHCPED([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class APKNKHHBEGM
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6955180", Offset = "0x6954380", VA = "0x186955180")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69552B0", Offset = "0x69544B0", VA = "0x1869552B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69550D0", Offset = "0x69542D0", VA = "0x1869550D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6954E80", Offset = "0x6954080", VA = "0x186954E80")]
		public unsafe static void APPOJKGPLJE([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort OOIEDEPHJAJ([In] float4 ECJOGJBBOLH);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class NBLHCJOPDDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6965D50", Offset = "0x6964F50", VA = "0x186965D50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6965E80", Offset = "0x6965080", VA = "0x186965E80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6965CA0", Offset = "0x6964EA0", VA = "0x186965CA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6965A90", Offset = "0x6964C90", VA = "0x186965A90")]
		public static ushort APPOJKGPLJE([In] float4 ECJOGJBBOLH)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void MNHDHLJLCJO([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class GLKHAIJEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x695D5F0", Offset = "0x695C7F0", VA = "0x18695D5F0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x695D720", Offset = "0x695C920", VA = "0x18695D720")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x695D540", Offset = "0x695C740", VA = "0x18695D540")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x695D2F0", Offset = "0x695C4F0", VA = "0x18695D2F0")]
		public unsafe static void APPOJKGPLJE([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void EKNCFNJLMFO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class HGDBPJFNLGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x695F360", Offset = "0x695E560", VA = "0x18695F360")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x695F490", Offset = "0x695E690", VA = "0x18695F490")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x695F2B0", Offset = "0x695E4B0", VA = "0x18695F2B0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x695F0C0", Offset = "0x695E2C0", VA = "0x18695F0C0")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void PAOFMFPHJIA([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class DPENMHKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x695B800", Offset = "0x695AA00", VA = "0x18695B800")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x695B930", Offset = "0x695AB30", VA = "0x18695B930")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x695B750", Offset = "0x695A950", VA = "0x18695B750")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x695B490", Offset = "0x695A690", VA = "0x18695B490")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void MACGLMKFBAB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class AAMHILJHMBA
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6953670", Offset = "0x6952870", VA = "0x186953670")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69537A0", Offset = "0x69529A0", VA = "0x1869537A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69535C0", Offset = "0x69527C0", VA = "0x1869535C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6953310", Offset = "0x6952510", VA = "0x186953310")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void AGLFHBAMKMI([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class PGFEGMKEIDN
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x696F0B0", Offset = "0x696E2B0", VA = "0x18696F0B0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x696F1E0", Offset = "0x696E3E0", VA = "0x18696F1E0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x696F000", Offset = "0x696E200", VA = "0x18696F000")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x696ED80", Offset = "0x696DF80", VA = "0x18696ED80")]
		public static void APPOJKGPLJE([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void BCHHOHPBFFG([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class GOHMDKCIBKN
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x695E170", Offset = "0x695D370", VA = "0x18695E170")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x695E2A0", Offset = "0x695D4A0", VA = "0x18695E2A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x695E0C0", Offset = "0x695D2C0", VA = "0x18695E0C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x695DEA0", Offset = "0x695D0A0", VA = "0x18695DEA0")]
		public unsafe static void APPOJKGPLJE([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void OEFHPAGGNNM([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class GLMBKLOCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x695DC10", Offset = "0x695CE10", VA = "0x18695DC10")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x695DD40", Offset = "0x695CF40", VA = "0x18695DD40")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x695DB60", Offset = "0x695CD60", VA = "0x18695DB60")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x695D880", Offset = "0x695CA80", VA = "0x18695D880")]
		public unsafe static void APPOJKGPLJE([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void KMKLKKGMMGE([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class HDOCHKDELOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x695EE30", Offset = "0x695E030", VA = "0x18695EE30")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x695EF60", Offset = "0x695E160", VA = "0x18695EF60")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x695ED80", Offset = "0x695DF80", VA = "0x18695ED80")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x695E9F0", Offset = "0x695DBF0", VA = "0x18695E9F0")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void PAKHJBCAPEA([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class AFABDDLCFFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x69549F0", Offset = "0x6953BF0", VA = "0x1869549F0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6954B20", Offset = "0x6953D20", VA = "0x186954B20")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6954940", Offset = "0x6953B40", VA = "0x186954940")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69545A0", Offset = "0x69537A0", VA = "0x1869545A0")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void OMKNCJKLGEE([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class AEKJIPDAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6954310", Offset = "0x6953510", VA = "0x186954310")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6954440", Offset = "0x6953640", VA = "0x186954440")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6954260", Offset = "0x6953460", VA = "0x186954260")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6953ED0", Offset = "0x69530D0", VA = "0x186953ED0")]
		public unsafe static void APPOJKGPLJE([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int DKKLPHNKALC([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class HKGGIHODNJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6961830", Offset = "0x6960A30", VA = "0x186961830")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6961960", Offset = "0x6960B60", VA = "0x186961960")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6961780", Offset = "0x6960980", VA = "0x186961780")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6961500", Offset = "0x6960700", VA = "0x186961500")]
		public unsafe static int APPOJKGPLJE([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void AMPDEAFCFOG([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class OMBEJAELCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6967DC0", Offset = "0x6966FC0", VA = "0x186967DC0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6967EF0", Offset = "0x69670F0", VA = "0x186967EF0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6967D10", Offset = "0x6966F10", VA = "0x186967D10")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6967AD0", Offset = "0x6966CD0", VA = "0x186967AD0")]
		public unsafe static void APPOJKGPLJE([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void MDKJAAPHPHD([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class PDPAPNACOBP
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x696EAF0", Offset = "0x696DCF0", VA = "0x18696EAF0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x696EC20", Offset = "0x696DE20", VA = "0x18696EC20")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x696EA40", Offset = "0x696DC40", VA = "0x18696EA40")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x696E800", Offset = "0x696DA00", VA = "0x18696E800")]
		public unsafe static void APPOJKGPLJE([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void ALMAILBHLNH([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class CGJCGLBMLJD
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x69561F0", Offset = "0x69553F0", VA = "0x1869561F0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6956320", Offset = "0x6955520", VA = "0x186956320")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6956140", Offset = "0x6955340", VA = "0x186956140")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6955DE0", Offset = "0x6954FE0", VA = "0x186955DE0")]
		public static void APPOJKGPLJE([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort OJGEPHOJGNP([In] float3 ECJOGJBBOLH);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class OINAHILNAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6967840", Offset = "0x6966A40", VA = "0x186967840")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6967970", Offset = "0x6966B70", VA = "0x186967970")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6967790", Offset = "0x6966990", VA = "0x186967790")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69675C0", Offset = "0x69667C0", VA = "0x1869675C0")]
		public static ushort APPOJKGPLJE([In] float3 ECJOGJBBOLH)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int BHPOFKEKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int HOLGDCGDMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> LGEIFAFCFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> JDGBACHKNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> KKMEEHMLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> PAGNCNMLBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<NIOMDIPAKGG> NIDIHFKKIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> NEDBFBLIAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> NADKEDPNJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 JJOEFPFCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 CKODDPOINAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 PCBAEAHGOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 LKLDNMFNIIN;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long DBAEBKKMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long OGEKNGIDLMD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float JEFIPFOIKHL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool KDGLBODMDPK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MCMJACOCFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x696B6E0", Offset = "0x696A8E0", VA = "0x18696B6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x696AC40", Offset = "0x6969E40", VA = "0x18696AC40")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x696C1B0", Offset = "0x696B3B0", VA = "0x18696C1B0")]
	public static ONMMPCFPEBK JGIIBNEOBDO(Allocator CHDJMCMMMLJ, NAJBPEBBKNG IMCJMBEIOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x696C390", Offset = "0x696B590", VA = "0x18696C390")]
	public static ONMMPCFPEBK JGIIBNEOBDO(Allocator CHDJMCMMMLJ, NativeArray<float3> PACCJLNOCPC, NativeArray<float3> DFCLFIHOBEI, NativeArray<float2> INOODCJHGLL, NativeArray<float4> EOIJCDLBGFH, bool FKBFBHJPNMF, NativeArray<float4> KEGJFGMIBPP, NativeArray<int> MLLIMDHIAHO, int BHPOFKEKDPM, int ICLHALGKOLH, int HOLGDCGDMAL, int CLFPMMMOANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6968FD0", Offset = "0x69681D0", VA = "0x186968FD0")]
	public NAJBPEBBKNG CJEPCENKMKG(Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x696B130", Offset = "0x696A330", VA = "0x18696B130")]
	public void FOJFIIIODJJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x696B480", Offset = "0x696A680", VA = "0x18696B480")]
	private void HCHNJJBGJNP(Mesh DICFBCCFLEI, NativeArray<ushort> FDPKMBMHLAP, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x696BC30", Offset = "0x696AE30", VA = "0x18696BC30")]
	public void JDFIOJFBMJA(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x696A480", Offset = "0x6969680", VA = "0x18696A480")]
	public void DMMGPNHAEHF(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6969AE0", Offset = "0x6968CE0", VA = "0x186969AE0")]
	public void CMECELCEBCJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x696DCE0", Offset = "0x696CEE0", VA = "0x18696DCE0")]
	public void NCJNLCDOODA(Mesh DICFBCCFLEI, NAJBPEBBKNG.KNOOBMCACLL BGOCEECJDJL, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6968EA0", Offset = "0x69680A0", VA = "0x186968EA0")]
	public long CIIGGKDJOEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69684F0", Offset = "0x69676F0", VA = "0x1869684F0")]
	public long BNBMCJOBFOE(NAJBPEBBKNG.KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6968050", Offset = "0x6967250", VA = "0x186968050")]
	private void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool MCBCAPCHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x696CEE0", Offset = "0x696C0E0", VA = "0x18696CEE0")]
	private void KHDMNGHNIII(NativeArray<float3> EIKCCLGECIE, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x696CE60", Offset = "0x696C060", VA = "0x18696CE60")]
	[BurstCompile]
	private unsafe static void KHDMNGHNIII([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x696E0E0", Offset = "0x696D2E0", VA = "0x18696E0E0")]
	[BurstCompile]
	private unsafe static void OBDMIONIBLO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x696D0A0", Offset = "0x696C2A0", VA = "0x18696D0A0")]
	[BurstCompile]
	private unsafe static void LKOMJJBIANK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x696E060", Offset = "0x696D260", VA = "0x18696E060")]
	[BurstCompile]
	private unsafe static void NOEILGONJAB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x696B7B0", Offset = "0x696A9B0", VA = "0x18696B7B0")]
	private void HHDAINNHBKF(NativeArray<float3> PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x696B720", Offset = "0x696A920", VA = "0x18696B720")]
	[BurstCompile]
	private unsafe static void HHDAINNHBKF([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x696D340", Offset = "0x696C540", VA = "0x18696D340")]
	private void LLPMNHHGONH(NativeArray<float3> DFCLFIHOBEI, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x696D120", Offset = "0x696C320", VA = "0x18696D120")]
	[BurstCompile]
	private unsafe static void LLPMNHHGONH([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x696B9F0", Offset = "0x696ABF0", VA = "0x18696B9F0")]
	private void IBEFEMHIKAN(NativeArray<float3> FFCNMPCEIFC, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x696BAC0", Offset = "0x696ACC0", VA = "0x18696BAC0")]
	[BurstCompile]
	private unsafe static void IBEFEMHIKAN([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x696D910", Offset = "0x696CB10", VA = "0x18696D910")]
	[BurstCompile]
	private unsafe static void MNJFLBBPMMG([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x696DB30", Offset = "0x696CD30", VA = "0x18696DB30")]
	[BurstCompile]
	private unsafe static void MOKOHHJLAKP([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x696B230", Offset = "0x696A430", VA = "0x18696B230")]
	[BurstCompile]
	private unsafe static void GCMJLHGOKBH([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x696E300", Offset = "0x696D500", VA = "0x18696E300")]
	private void PFHOGCIKNMG(NativeArray<float2> INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x696E3D0", Offset = "0x696D5D0", VA = "0x18696E3D0")]
	[BurstCompile]
	private unsafe static void PFHOGCIKNMG([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x696E280", Offset = "0x696D480", VA = "0x18696E280")]
	[BurstCompile]
	private static void OPLKEBLOIAL([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x696A140", Offset = "0x6969340", VA = "0x18696A140")]
	private void DEENGLOFEJO(NativeArray<float2> JHIJPONAINF, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x696A0C0", Offset = "0x69692C0", VA = "0x18696A0C0")]
	[BurstCompile]
	private unsafe static void DEENGLOFEJO([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x696ADE0", Offset = "0x6969FE0", VA = "0x18696ADE0")]
	[BurstCompile]
	private unsafe static void FCDFBHJJICG([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x696BB30", Offset = "0x696AD30", VA = "0x18696BB30")]
	[BurstCompile]
	private unsafe static void IHLGBNCGGED([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x696BBB0", Offset = "0x696ADB0", VA = "0x18696BBB0")]
	[BurstCompile]
	private unsafe static void IOOFODNBEBF([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x696D400", Offset = "0x696C600", VA = "0x18696D400")]
	private void LOAPMMDGJCO(NativeArray<float4> KEGJFGMIBPP, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x696D4F0", Offset = "0x696C6F0", VA = "0x18696D4F0")]
	[BurstCompile]
	private unsafe static void LOAPMMDGJCO([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69681E0", Offset = "0x69673E0", VA = "0x1869681E0")]
	[BurstCompile]
	private static ushort BEEPKFDIOKE([In] float4 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6969620", Offset = "0x6968820", VA = "0x186969620")]
	private void CKDMEBGIKLF(NativeArray<float4> CBDMHNPJPJL, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69695B0", Offset = "0x69687B0", VA = "0x1869695B0")]
	[BurstCompile]
	private unsafe static void CKDMEBGIKLF([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x696DE40", Offset = "0x696D040", VA = "0x18696DE40")]
	[BurstCompile]
	private unsafe static void NKNPOALKOOP([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x696C8E0", Offset = "0x696BAE0", VA = "0x18696C8E0")]
	[BurstCompile]
	private unsafe static void JJEDFPGAEPM([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69687B0", Offset = "0x69679B0", VA = "0x1869687B0")]
	[BurstCompile]
	private unsafe static void CEMPAIHBOJL([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x696D8B0", Offset = "0x696CAB0", VA = "0x18696D8B0")]
	[BurstCompile]
	private static void MLFGCOMNPCK([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6968820", Offset = "0x6967A20", VA = "0x186968820")]
	private void CGBIINEGBJO(Allocator CHDJMCMMMLJ, NativeArray<float4> EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6968C00", Offset = "0x6967E00", VA = "0x186968C00")]
	[BurstCompile]
	private unsafe static void CGBIINEGBJO([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69685E0", Offset = "0x69677E0", VA = "0x1869685E0")]
	private static void CBADDDMNEJF(NativeArray<float4> BPPKHLDPGPI, NativeArray<NIOMDIPAKGG> DPJDJKECOOD, NativeArray<byte> MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6968560", Offset = "0x6967760", VA = "0x186968560")]
	[BurstCompile]
	private unsafe static void CBADDDMNEJF([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x696E200", Offset = "0x696D400", VA = "0x18696E200")]
	[BurstCompile]
	private unsafe static void OLANFNCIEBJ([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x696D790", Offset = "0x696C990", VA = "0x18696D790")]
	[BurstCompile]
	private unsafe static void MGHPOLAAOAB([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x696B040", Offset = "0x696A240", VA = "0x18696B040")]
	[BurstCompile]
	private unsafe static void FLHLKHHPDPG([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x696C950", Offset = "0x696BB50", VA = "0x18696C950")]
	private void JKMJGLIKINI(Allocator CHDJMCMMMLJ, NativeArray<int> MLLIMDHIAHO, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6969760", Offset = "0x6968960", VA = "0x186969760")]
	private static NativeArray<byte> CKDNFIPDKPM(Allocator CHDJMCMMMLJ, NativeArray<int> MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69696F0", Offset = "0x69688F0", VA = "0x1869696F0")]
	[BurstCompile]
	private unsafe static int CKDNFIPDKPM([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x696DC10", Offset = "0x696CE10", VA = "0x18696DC10")]
	private static void NCABMFCBGFM(NativeArray<int> JGNGHKAEEMO, NativeArray<byte> FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x696DBA0", Offset = "0x696CDA0", VA = "0x18696DBA0")]
	[BurstCompile]
	private unsafe static void NCABMFCBGFM([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x696B0C0", Offset = "0x696A2C0", VA = "0x18696B0C0")]
	[BurstCompile]
	private unsafe static void FOELNMCPCFM([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6968180", Offset = "0x6967380", VA = "0x186968180")]
	[BurstCompile]
	private static void ANEBOGOMLPE([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x696CC50", Offset = "0x696BE50", VA = "0x18696CC50")]
	[BurstCompile]
	private static ushort KFHHCFDHBIH([In] float3 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public ONMMPCFPEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6951D70", Offset = "0x6950F70", VA = "0x186951D70")]
	[BurstCompile]
	public unsafe static void HPEDGPPGAPP([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69686F0", Offset = "0x69678F0", VA = "0x1869686F0")]
	[BurstCompile]
	public unsafe static void CEGEHIGGCCC([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x696CFE0", Offset = "0x696C1E0", VA = "0x18696CFE0")]
	[BurstCompile]
	public unsafe static void KJFEGEJBLLK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x696A240", Offset = "0x6969440", VA = "0x18696A240")]
	[BurstCompile]
	public unsafe static void DGGHLJPGKHB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6952790", Offset = "0x6951990", VA = "0x186952790")]
	[BurstCompile]
	public unsafe static void JEHHCLMCBKF([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6952270", Offset = "0x6951470", VA = "0x186952270")]
	[BurstCompile]
	public unsafe static void IKKIDIMOAOA([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x696AD40", Offset = "0x6969F40", VA = "0x18696AD40")]
	[BurstCompile]
	public unsafe static void FAEKCKBHMBD([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6951970", Offset = "0x6950B70", VA = "0x186951970")]
	[BurstCompile]
	public unsafe static void EPODGLMPDOI([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x696CA30", Offset = "0x696BC30", VA = "0x18696CA30")]
	[BurstCompile]
	public unsafe static void JMKHKPEGIEK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6968230", Offset = "0x6967430", VA = "0x186968230")]
	[BurstCompile]
	public unsafe static void BKEKIOLOFPC([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69524D0", Offset = "0x69516D0", VA = "0x1869524D0")]
	[BurstCompile]
	public unsafe static void INIENDBIDHL([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6968E50", Offset = "0x6968050", VA = "0x186968E50")]
	[BurstCompile]
	public static void CHJOBCJFCEH([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x696A300", Offset = "0x6969500", VA = "0x18696A300")]
	[BurstCompile]
	public unsafe static void DJDEPODMKOL([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6968400", Offset = "0x6967600", VA = "0x186968400")]
	[BurstCompile]
	public unsafe static void BLLMBFHHJLH([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x696CB50", Offset = "0x696BD50", VA = "0x18696CB50")]
	[BurstCompile]
	public unsafe static void JNJGGONAIEE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x696AA60", Offset = "0x6969C60", VA = "0x18696AA60")]
	[BurstCompile]
	public unsafe static void ECDDIMHEJKP([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x696D810", Offset = "0x696CA10", VA = "0x18696D810")]
	[BurstCompile]
	public unsafe static void MHBCEHNKKCC([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x696C880", Offset = "0x696BA80", VA = "0x18696C880")]
	[BurstCompile]
	public static ushort JHFHFNFCKPD([In] float4 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x696E160", Offset = "0x696D360", VA = "0x18696E160")]
	[BurstCompile]
	public unsafe static void OGOHBPOGDKG([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6951FC0", Offset = "0x69511C0", VA = "0x186951FC0")]
	[BurstCompile]
	public unsafe static void IEFEPGFNIKL([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x696D570", Offset = "0x696C770", VA = "0x18696D570")]
	[BurstCompile]
	public unsafe static void MDCDNBMKKEO([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69699D0", Offset = "0x6968BD0", VA = "0x1869699D0")]
	[BurstCompile]
	public unsafe static void CMDPEGMNMEC([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6968340", Offset = "0x6967540", VA = "0x186968340")]
	[BurstCompile]
	public static void BKMLPBOLKBA([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6951BB0", Offset = "0x6950DB0", VA = "0x186951BB0")]
	[BurstCompile]
	public unsafe static void FCPKGDCFHIO([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x696B5A0", Offset = "0x696A7A0", VA = "0x18696B5A0")]
	[BurstCompile]
	public unsafe static void HFOBLINEJNM([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x696AE60", Offset = "0x696A060", VA = "0x18696AE60")]
	[BurstCompile]
	public unsafe static void FLFMOMDLOHO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x696B2A0", Offset = "0x696A4A0", VA = "0x18696B2A0")]
	[BurstCompile]
	public unsafe static void GHCHOBBBMAL([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x696E620", Offset = "0x696D820", VA = "0x18696E620")]
	[BurstCompile]
	public unsafe static void PJOMKMAHDIM([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x696D690", Offset = "0x696C890", VA = "0x18696D690")]
	[BurstCompile]
	public unsafe static int MFFIDOGCALE([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x696A3E0", Offset = "0x69695E0", VA = "0x18696A3E0")]
	[BurstCompile]
	public unsafe static void DLPELCNGBHC([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6968F30", Offset = "0x6968130", VA = "0x186968F30")]
	[BurstCompile]
	public unsafe static void CIPHDGIIPIN([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x696B8B0", Offset = "0x696AAB0", VA = "0x18696B8B0")]
	[BurstCompile]
	public static void HIBOALAABLL([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6952B70", Offset = "0x6951D70", VA = "0x186952B70")]
	[BurstCompile]
	public static ushort KELGNEIILMA([In] float3 ECJOGJBBOLH)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IPKKLAFBLBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 FGGMJJKKBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 HIKGGMOMAFA;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CJKDABCKDLF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<IPKKLAFBLBL> EAFMKJOPOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> AJGHAIKIKCC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851A80", VA = "0x180852880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6957110", Offset = "0x6956310", VA = "0x186957110")]
	public CJKDABCKDLF(int NOLHGPALGBF, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6956FD0", Offset = "0x69561D0", VA = "0x186956FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6957030", Offset = "0x6956230", VA = "0x186957030")]
	public void LBJDLPDBEDK(CJKDABCKDLF PHEPMLONJPG, int DLFNOPADJLL, int JHEGPJBDKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DAJPLFDONCC
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static CJKDABCKDLF KFBOADOBOIC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<HDBOOPAJBBL> HPFDJNAKEDI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] HOILMEOLCLL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool ODFHEEEDCPP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, CJKDABCKDLF> LPGFDDGOEDP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, CJKDABCKDLF> HPAFIMPCJBB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool HJABDKEENBG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x69572C0", Offset = "0x69564C0", VA = "0x1869572C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<HDBOOPAJBBL> IHALGGEFJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6957360", Offset = "0x6956560", VA = "0x186957360")]
		get
		{
			return default(NativeList<HDBOOPAJBBL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CJKDABCKDLF JBCAHILOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6957C20", Offset = "0x6956E20", VA = "0x186957C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6957CC0", Offset = "0x6956EC0", VA = "0x186957CC0")]
	private static void HNHKHPLKGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6958840", Offset = "0x6957A40", VA = "0x186958840")]
	public static int NPBDCEDPEDN(bool GMOOOENEPCC, int FBHJLEPEJCC, bool GOLOLCFOBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6957340", Offset = "0x6956540", VA = "0x186957340")]
	private static int DAKAAFNKEFD(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6958870", Offset = "0x6957A70", VA = "0x186958870")]
	private static int PEDJEMKCBDN(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x69585C0", Offset = "0x69577C0", VA = "0x1869585C0")]
	public static int KCBEJALBBAP(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6957440", Offset = "0x6956640", VA = "0x186957440")]
	public static int EFLMNMDKKMD(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6958310", Offset = "0x6957510", VA = "0x186958310")]
	public static int HOBFEDCLLGK(int PEAMNBBBMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6958320", Offset = "0x6957520", VA = "0x186958320")]
	private static int ILMGCAALFDA(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6957400", Offset = "0x6956600", VA = "0x186957400")]
	private static int DKALFPDPDNB(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x69587D0", Offset = "0x69579D0", VA = "0x1869587D0")]
	public static int NKKELEELGAB(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6958740", Offset = "0x6957940", VA = "0x186958740")]
	public static int NKAFBGPJMEC(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6957420", Offset = "0x6956620", VA = "0x186957420")]
	public static int EAMPOPBCKNO(int PEAMNBBBMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6958650", Offset = "0x6957850", VA = "0x186958650")]
	public static CJKDABCKDLF NGIIKJDAEMK(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6958330", Offset = "0x6957530", VA = "0x186958330")]
	private static CJKDABCKDLF IOKENIHIOBP(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x69571D0", Offset = "0x69563D0", VA = "0x1869571D0")]
	public static CJKDABCKDLF AHOFHNNBNDG(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x69578E0", Offset = "0x6956AE0", VA = "0x1869578E0")]
	private static CJKDABCKDLF GEIANPINPPF(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x69574D0", Offset = "0x69566D0", VA = "0x1869574D0")]
	public static void EOJEBCEEEFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HGDOAMLPNBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int IEOKKAPKFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 EDONIHELBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion AHOGEDELABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float KICMOIFFJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float MMJPOKIENHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int KHHANACNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int GMOFENMBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int CBCMDKGALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool LDANDIKGPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool MIJBNEDOLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float KFJEHKPDOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 IOBKMFFMDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool OAAPGFLGLML;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MNNGJMLJGGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int KNDEIJFCGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int OLHDGNGEBFH;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct GEAABJGODDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<HGDOAMLPNBP> NCFEBMPNGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<BEEODNIICBD> NMAAOPGFHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<HDBOOPAJBBL> KKGFKOAPDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<MNNGJMLJGGM> BKEBLCIBOLB;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x695D1C0", Offset = "0x695C3C0", VA = "0x18695D1C0")]
	public GEAABJGODDH(NativeArray<BEEODNIICBD> NMAAOPGFHCD, int ECGAAJFODGN = 1, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x695D0D0", Offset = "0x695C2D0", VA = "0x18695D0D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct DIKKDOGKKME : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<IPKKLAFBLBL> ELFHFDEFNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> PKAALPHPPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<HDBOOPAJBBL> OEMACOHEMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<HGDOAMLPNBP> NCFEBMPNGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<BEEODNIICBD> NMAAOPGFHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<HDBOOPAJBBL> KKGFKOAPDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<MNNGJMLJGGM> BKEBLCIBOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int PFOGLCGMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int FDHHFMLBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 ECBGCKAODOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion OIMJCDIDJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 HOHCKCGNBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LJNMHHCEJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NHINADOAIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GGMNAANEOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KENLNHHFMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> PJKFGCADMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IIBIKAFBAOL;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x695AED0", Offset = "0x695A0D0", VA = "0x18695AED0")]
	public DIKKDOGKKME(HIMGIDMIPBN JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x695B160", Offset = "0x695A360", VA = "0x18695B160")]
	public DIKKDOGKKME(GEAABJGODDH JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float3 GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6959A80", Offset = "0x6958C80", VA = "0x186959A80")]
	private float3 DBBOPDDAFKM(float3 KMIECBFKDNO, Matrix4x4 NGKIDPFLBJB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6958F50", Offset = "0x6958150", VA = "0x186958F50")]
	private float3x3 BNLDFFKIOBH(float3x3 EICDHCELANI, float3x3 HLBAEJFFCFF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x695AEC0", Offset = "0x695A0C0", VA = "0x18695AEC0")]
	private float MEIMMLKDHEB(float CDPPGBMBKAI, float EJMIDHCGIBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6959BB0", Offset = "0x6958DB0", VA = "0x186959BB0", Slot = "4")]
	public void Execute(int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x695AD50", Offset = "0x6959F50", VA = "0x18695AD50")]
	private void GHAIPBICKFC(int ADICGEAPMKC, float3 HGDCPNGLIKJ, float3 NFFLDAHKGKD, float3 AKIMOBCHKEL, float EOGPEOAFBNO, bool FOLLGGKILFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6958FD0", Offset = "0x69581D0", VA = "0x186958FD0")]
	private void CEIODGGNBPK(HGDOAMLPNBP MBNEEJMJPMJ, float3 BCPGICOCGEJ, float3x3 OBKMAHDAHKH, float CDPPGBMBKAI, int GJGIBLAFHHL, int FKCGALHHLKD, int JLPNAEGILAG, float AICJBILPPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6959430", Offset = "0x6958630", VA = "0x186959430")]
	private void DAOIMJFKPJF(int ADICGEAPMKC, int JDPAJJEEEGP, HGDOAMLPNBP MBNEEJMJPMJ, float3 BCPGICOCGEJ, float3x3 OBKMAHDAHKH, bool NJDHPFGBFKI, float CDPPGBMBKAI, int KFKFBHOJAEL, int IOPHKNBDFGH, int JLPNAEGILAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct KGPNDFHLDEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<EBIEIMGKHLJ> LLKHNMMILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<HDBOOPAJBBL> POMECMHLLCI;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6962BD0", Offset = "0x6961DD0", VA = "0x186962BD0")]
	public KGPNDFHLDEG(int ECGAAJFODGN, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6962B30", Offset = "0x6961D30", VA = "0x186962B30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct KLEGDAKJIOG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum IFLHLIHNOHO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<float3> ODDAELIFHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> PJDEGNKDGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> JKMEIIOLDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> KHDOCPFIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> MINGALFAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> MNHMLOOFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> BNFIDKEKHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> DPDDBPPLBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<HDBOOPAJBBL> ABEKLLPMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<EBIEIMGKHLJ> LLKHNMMILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<HDBOOPAJBBL> POMECMHLLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int PFOGLCGMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int FDHHFMLBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LJNMHHCEJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NHINADOAIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GGMNAANEOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KENLNHHFMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> PJKFGCADMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IIBIKAFBAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 HOHCKCGNBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion OIMJCDIDJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 ECBGCKAODOL;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6964850", Offset = "0x6963A50", VA = "0x186964850")]
	public KLEGDAKJIOG(HIMGIDMIPBN JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6964660", Offset = "0x6963860", VA = "0x186964660")]
	public KLEGDAKJIOG(KGPNDFHLDEG LINJEFIAFHO, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float3 GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6963670", Offset = "0x6962870", VA = "0x186963670", Slot = "4")]
	public void Execute(int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69632C0", Offset = "0x69624C0", VA = "0x1869632C0")]
	private void BBLDOADIKME(float4x4 CEKCEFDOFME, int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6963250", Offset = "0x6962450", VA = "0x186963250")]
	private IFLHLIHNOHO AHECGCOAHHL(float3 NFFLDAHKGKD)
	{
		return default(IFLHLIHNOHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6964610", Offset = "0x6963810", VA = "0x186964610")]
	private float4 MBBIAMEAMNN(IFLHLIHNOHO ELMGLGBPLLE, int DHNLEFJCEAH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69645D0", Offset = "0x69637D0", VA = "0x1869645D0")]
	private float2 IPBABBJFGGN(IFLHLIHNOHO ELMGLGBPLLE, float3 HGDCPNGLIKJ)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct OALODHMDGLN
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum CHMPEFEAHOC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static OALODHMDGLN ENKECPBOOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 PHJFFHJCDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 OILJGEIJHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 LIFKLMGEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public CHMPEFEAHOC EPCABOEGHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 DNBGDHBHHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 OBGENIGLBNP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6966B40", Offset = "0x6965D40", VA = "0x186966B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 KNFHACNBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x69670E0", Offset = "0x69662E0", VA = "0x1869670E0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x69674D0", Offset = "0x69666D0", VA = "0x1869674D0")]
	public OALODHMDGLN(float3 HGDCPNGLIKJ, quaternion LCDJINCAHMD, float3 ECGAAJFODGN, CHMPEFEAHOC NCMHJNKFAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6966EE0", Offset = "0x69660E0", VA = "0x186966EE0")]
	public float FMLHFOHCPBE(float3 BCPGICOCGEJ, float EEBNCGOCFGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x69671C0", Offset = "0x69663C0", VA = "0x1869671C0")]
	public bool NNKABFKKNBC(float3 NFFLDAHKGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x69672B0", Offset = "0x69664B0", VA = "0x1869672B0")]
	public void PCHEPJFDHBB(float3 JMDOAKIMNLC, float3x3 MAEHDLJGHCI, float MJNPDCBNHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6966B50", Offset = "0x6965D50", VA = "0x186966B50")]
	private void BGINIPHNCJH(float3 FNIJIKICPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6966C50", Offset = "0x6965E50", VA = "0x186966C50")]
	public void CEAJCNEDIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct ICABHPNHGDE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<OALODHMDGLN> LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> LGEIFAFCFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> NADKEDPNJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PEFLDMODNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<HDBOOPAJBBL> POMECMHLLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int CCFBFGPFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int KKIJGBFLOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float EEBNCGOCFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float KMBGNAGEEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NAHCIINIFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> PECFPILAHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> IBNOPPILEGF;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6962560", Offset = "0x6961760", VA = "0x186962560")]
	public ICABHPNHGDE(NAJBPEBBKNG DICFBCCFLEI, float BKOEIEGNMCI, int JHEGPJBDKAJ, int GJGIBLAFHHL, NativeList<OALODHMDGLN> LINJEFIAFHO, NativeArray<int> PEFLDMODNIF, NativeList<HDBOOPAJBBL> POMECMHLLCI, LEFCAAKHOCL OCHMECPEPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6961B80", Offset = "0x6960D80", VA = "0x186961B80", Slot = "4")]
	public void Execute(int EDJMDAGODNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6961AC0", Offset = "0x6960CC0", VA = "0x186961AC0")]
	private bool DIIGBFPOACO(OALODHMDGLN MLFGLJKBOIG, OALODHMDGLN GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x69622C0", Offset = "0x69614C0", VA = "0x1869622C0")]
	private bool LGMDBJHGFCK(OALODHMDGLN OPAEMCPDAKM, int DEHLFLDKKMC, int PIEBKMMOBDM, int PPCBIALNNMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LEFCAAKHOCL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> HEPBNIHOCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> IIHPAIFPANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> HLNLJJHJBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> OJEAEIBDMAD;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6965010", Offset = "0x6964210", VA = "0x186965010")]
	public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6965310", Offset = "0x6964510", VA = "0x186965310")]
	public static long FDDHMOCCAJC(int NOLHGPALGBF, int HECJMBFPMPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6965130", Offset = "0x6964330", VA = "0x186965130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6965220", Offset = "0x6964420", VA = "0x186965220")]
	public void EECPCLJADFI(JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public LEFCAAKHOCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct EIJLFHILFBK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> LGEIFAFCFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> JDGBACHKNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> NIDIHFKKIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> PAGNCNMLBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> NADKEDPNJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KKMEEHMLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> FAPNJJOJKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> NAHCIINIFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> PECFPILAHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int OOBFMNLJHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int MGIIKHOMNLD;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x695BED0", Offset = "0x695B0D0", VA = "0x18695BED0")]
	public EIJLFHILFBK(NAJBPEBBKNG DICFBCCFLEI, LEFCAAKHOCL OCHMECPEPDN, int MGIIKHOMNLD = 0, int OOBFMNLJHPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x695BA90", Offset = "0x695AC90", VA = "0x18695BA90", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x695BE70", Offset = "0x695B070", VA = "0x18695BE70")]
	private void GKBANPEJAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DDJFECLMAJL
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2984870", Offset = "0x2983A70", VA = "0x182984870")]
	public static bool FJIFLAMOAMH<T>(NativeArray<T> PFKJAOOHGBN, int ECGAAJFODGN, Allocator CHDJMCMMMLJ, NativeArrayOptions FDGBBGJEJMA = NativeArrayOptions.ClearMemory, int LAPHDBIKPDD = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2984920", Offset = "0x2983B20", VA = "0x182984920")]
	public static bool FJIFLAMOAMH<T>(NativeList<T> CGIFJALMJMI, int ECGAAJFODGN, Allocator CHDJMCMMMLJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BBLLHGFLJJK
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface FDAECEGICND
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OOKGPGABLCE(BBLLHGFLJJK JMKELNHPPCF);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KANONAFMLEE(BBLLHGFLJJK JMKELNHPPCF);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FJDKBNDMKNL();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float AMMOEONGLDB();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDPNIKOOIOA(BBLLHGFLJJK JMKELNHPPCF, HIMGIDMIPBN AGAFMCPLFNH, int PEMEMAJKFMB = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class NAJBPEBBKNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum KNOOBMCACLL
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct GLGIHFBPLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KNOOBMCACLL BGOCEECJDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool GFPNECEHBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int AGOAODEANDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] IAFCGOHLNDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct ICONONHFNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 HGDCPNGLIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 NFFLDAHKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 AKIMOBCHKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 DOMOKEFBNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 NIDIHFKKIHI;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] IAFCGOHLNDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct MCOECEHNKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 HGDCPNGLIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 NFFLDAHKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 AKIMOBCHKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 DOMOKEFBNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 NIDIHFKKIHI;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] IAFCGOHLNDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct JPJAJCJLDCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 HGDCPNGLIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 NFFLDAHKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 AKIMOBCHKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 DOMOKEFBNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint NIDIHFKKIHI;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] IAFCGOHLNDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct BJGADGCOPIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 HGDCPNGLIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint NFFLDAHKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint AKIMOBCHKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 DOMOKEFBNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 NIDIHFKKIHI;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] IAFCGOHLNDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct AGOPAGAENOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 HGDCPNGLIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint NFFLDAHKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint AKIMOBCHKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 DOMOKEFBNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 NIDIHFKKIHI;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] IAFCGOHLNDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int PBBELKEDEPO(float IPBJLCONKPC);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class JBIBMHNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x69755D0", Offset = "0x69747D0", VA = "0x1869755D0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6975700", Offset = "0x6974900", VA = "0x186975700")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6975520", Offset = "0x6974720", VA = "0x186975520")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69752B0", Offset = "0x69744B0", VA = "0x1869752B0")]
		public static int APPOJKGPLJE(float IPBJLCONKPC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint POCODJODECG([In] float4 NJJHKDBJDAC);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class MEGJPDKIELC
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6975FB0", Offset = "0x69751B0", VA = "0x186975FB0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x69760E0", Offset = "0x69752E0", VA = "0x1869760E0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6975F00", Offset = "0x6975100", VA = "0x186975F00")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6975BC0", Offset = "0x6974DC0", VA = "0x186975BC0")]
		public static uint APPOJKGPLJE([In] float4 NJJHKDBJDAC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint CNBOPLLLJMN([In] float3 NJJHKDBJDAC);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class DNHNONOGEBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6970CF0", Offset = "0x696FEF0", VA = "0x186970CF0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6970E20", Offset = "0x6970020", VA = "0x186970E20")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6970C40", Offset = "0x696FE40", VA = "0x186970C40")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x69709C0", Offset = "0x696FBC0", VA = "0x1869709C0")]
		public static uint APPOJKGPLJE([In] float3 NJJHKDBJDAC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void NPJKJMBHLMH([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class OMCFDGIOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6985C40", Offset = "0x6984E40", VA = "0x186985C40")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6985D70", Offset = "0x6984F70", VA = "0x186985D70")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6985B90", Offset = "0x6984D90", VA = "0x186985B90")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6985950", Offset = "0x6984B50", VA = "0x186985950")]
		public unsafe static void APPOJKGPLJE([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void NCNIJLINMFO([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class FAFGDMCFLPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6972860", Offset = "0x6971A60", VA = "0x186972860")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6972990", Offset = "0x6971B90", VA = "0x186972990")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x69727B0", Offset = "0x69719B0", VA = "0x1869727B0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6972570", Offset = "0x6971770", VA = "0x186972570")]
		public unsafe static void APPOJKGPLJE([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int BNADDOKLBJO = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> LEAHAPIOODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> KGAEPJOOKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> GHMJCGAJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> BDAOJAKKOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> LBOBCMJEFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> PJJPFCOKHHC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] BGCIIFFCMOC;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool FKDNOALOPGO;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static GLGIHFBPLDK[] MNPCHAOFBHO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6981350", Offset = "0x6980550", VA = "0x186981350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6983520", Offset = "0x6982720", VA = "0x186983520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69834E0", Offset = "0x69826E0", VA = "0x1869834E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCMJACOCFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69833B0", Offset = "0x69825B0", VA = "0x1869833B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x69819D0", Offset = "0x6980BD0", VA = "0x1869819D0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x697FF60", Offset = "0x697F160", VA = "0x18697FF60")]
	public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool JEDHHDJJCLE, bool MCBCAPCHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x69838C0", Offset = "0x6982AC0", VA = "0x1869838C0")]
	public void JBGLCJDAAKF(int NOLHGPALGBF, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6984900", Offset = "0x6983B00", VA = "0x186984900", Slot = "6")]
	public bool PADBHOPLFNI(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x69828F0", Offset = "0x6981AF0", VA = "0x1869828F0")]
	public bool FOJFIIIODJJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6984910", Offset = "0x6983B10", VA = "0x186984910")]
	public bool PBOGGAHOFPI(Mesh DICFBCCFLEI, NAJBPEBBKNG PPGDGCIOEJI, bool GDLAEOGBDLK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6983940", Offset = "0x6982B40", VA = "0x186983940")]
	public void JDFIOJFBMJA(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6981AE0", Offset = "0x6980CE0", VA = "0x186981AE0")]
	public void ELNINBFLLGC(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6983490", Offset = "0x6982690", VA = "0x186983490")]
	[BurstCompile]
	public static int HIJOMKPBPFF(float IPBJLCONKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x69833F0", Offset = "0x69825F0", VA = "0x1869833F0")]
	[BurstCompile]
	public static uint HIJOMKPBPFF([In] float4 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6983440", Offset = "0x6982640", VA = "0x186983440")]
	[BurstCompile]
	public static uint HIJOMKPBPFF([In] float3 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6981390", Offset = "0x6980590", VA = "0x186981390")]
	public void DMMGPNHAEHF(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6983840", Offset = "0x6982A40", VA = "0x186983840")]
	[BurstCompile]
	private unsafe static void ILNEAKLPIED([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69808C0", Offset = "0x697FAC0", VA = "0x1869808C0")]
	public void CMECELCEBCJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6982CD0", Offset = "0x6981ED0", VA = "0x186982CD0")]
	[BurstCompile]
	private unsafe static void GBFPEOJCPIL([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6984810", Offset = "0x6983A10", VA = "0x186984810")]
	public void NCJNLCDOODA(Mesh DICFBCCFLEI, KNOOBMCACLL BGOCEECJDJL, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6984540", Offset = "0x6983740", VA = "0x186984540")]
	public void LBJDLPDBEDK(NAJBPEBBKNG DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6984390", Offset = "0x6983590", VA = "0x186984390")]
	public NAJBPEBBKNG JGFBHDIGANM(Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6980730", Offset = "0x697F930", VA = "0x186980730")]
	public long CIIGGKDJOEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6980860", Offset = "0x697FA60", VA = "0x186980860")]
	public static long CIIGGKDJOEF(int EMICHICJLGC, int DBIJKCBBANM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69805D0", Offset = "0x697F7D0", VA = "0x1869805D0")]
	public static long BNBMCJOBFOE(int EMICHICJLGC, int DBIJKCBBANM, KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6980670", Offset = "0x697F870", VA = "0x186980670")]
	public long BNBMCJOBFOE(KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69847B0", Offset = "0x69839B0", VA = "0x1869847B0")]
	public void MBHMLCKHMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6982560", Offset = "0x6981760", VA = "0x186982560")]
	public static void FAFHBLFDKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6982D50", Offset = "0x6981F50", VA = "0x186982D50")]
	public KNOOBMCACLL GIBCJJAIKFE()
	{
		return default(KNOOBMCACLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6980150", Offset = "0x697F350", VA = "0x186980150")]
	public static (int, int) BCNMJDDPCAO(Mesh DICFBCCFLEI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x697FE80", Offset = "0x697F080", VA = "0x18697FE80")]
	public static int ACKMLIOFFCH(VertexAttributeDescriptor[] FPADDJONGOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69844D0", Offset = "0x69836D0", VA = "0x1869844D0")]
	public static long KAAHBFPGHJC(Mesh DICFBCCFLEI, int CICOMOACNJA, int FPBOOOOIJIO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public NAJBPEBBKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69837A0", Offset = "0x69829A0", VA = "0x1869837A0")]
	[BurstCompile]
	public static int IJJMIPGGKLC(float IPBJLCONKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6983610", Offset = "0x6982810", VA = "0x186983610")]
	[BurstCompile]
	public static uint IJJMIPGGKLC([In] float4 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6983560", Offset = "0x6982760", VA = "0x186983560")]
	[BurstCompile]
	public static uint IJJMIPGGKLC([In] float3 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6980220", Offset = "0x697F420", VA = "0x186980220")]
	[BurstCompile]
	public unsafe static void BGKBHBNEADP([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6980F00", Offset = "0x6980100", VA = "0x186980F00")]
	[BurstCompile]
	public unsafe static void DCKOKKNEHCI([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class EGGCEOBDPNB
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6970F80", Offset = "0x6970180", VA = "0x186970F80")]
	public static void EOJEBCEEEFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class EINJEOMMPLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> LEAHAPIOODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> KGAEPJOOKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> DIFPDBMHBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> NMGGFDPBDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> GCADKAABFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> CFEKBBDFFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> HINBEOKCFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> PJJPFCOKHHC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x69716B0", Offset = "0x69708B0", VA = "0x1869716B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6971670", Offset = "0x6970870", VA = "0x186971670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NEJPEHKDHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6971F70", Offset = "0x6971170", VA = "0x186971F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6971FB0", Offset = "0x69711B0", VA = "0x186971FB0")]
	public EINJEOMMPLD(int NOLHGPALGBF, int HECJMBFPMPO, int LPCJBALPLCK, Allocator CHDJMCMMMLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6972280", Offset = "0x6971480", VA = "0x186972280")]
	public EINJEOMMPLD(Mesh DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6971560", Offset = "0x6970760", VA = "0x186971560", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6971C70", Offset = "0x6970E70", VA = "0x186971C70")]
	public void LBJDLPDBEDK(EINJEOMMPLD DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69710D0", Offset = "0x69702D0", VA = "0x1869710D0")]
	private void DECMDFKHIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x69716F0", Offset = "0x69708F0", VA = "0x1869716F0")]
	private void KJOAMPPOLJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HDBOOPAJBBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int NFFHPNFLDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int GOHGHPNIKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int LGEOOACFGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int JGHJDPGMBEK;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x13F10D0", Offset = "0x13F02D0", VA = "0x1813F10D0")]
	public HDBOOPAJBBL(int GJGIBLAFHHL, int BHPOFKEKDPM, int JHEGPJBDKAJ, int HOLGDCGDMAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class PPDAGFFIHDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<HDBOOPAJBBL> IPKELMNGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8C9BF0", Offset = "0x8C8DF0", VA = "0x1808C9BF0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HDBOOPAJBBL>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x98EF30", Offset = "0x98E130", VA = "0x18098EF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EINJEOMMPLD HKBKABBDKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851A70", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6985FD0", Offset = "0x69851D0", VA = "0x186985FD0")]
	public PPDAGFFIHDK(IEnumerable<EINJEOMMPLD> KKMCNLCAHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6985F60", Offset = "0x6985160", VA = "0x186985F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum EJHKOLMCNPF
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class OJPNMIKMHHC
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> LINDLHOBOPP;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> GIOAIKLHNAP;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> DODDMAEDJOP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> COKPBNNCMHH;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6985500", Offset = "0x6984700", VA = "0x186985500")]
	public static void EOJEBCEEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6985620", Offset = "0x6984820", VA = "0x186985620")]
	public static NativeArray<float2> GLIPPCMJADN(NativeArray<float2> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float2> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x69853F0", Offset = "0x69845F0", VA = "0x1869853F0")]
	public static NativeArray<float3> EAFBIIAODMA(NativeArray<float3> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float3> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6985840", Offset = "0x6984A40", VA = "0x186985840")]
	public static NativeArray<float4> PPEIFDNKACL(NativeArray<float4> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float4> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6985730", Offset = "0x6984930", VA = "0x186985730")]
	public static NativeArray<int> PELMBABBONG(NativeArray<int> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<int> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5EF0", Offset = "0x2CC50F0", VA = "0x182CC5EF0")]
	private static void HHLCAGAMPEG<T>(NativeArray<T> PFKJAOOHGBN, int GFJHPONFOPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5E10", Offset = "0x2CC5010", VA = "0x182CC5E10")]
	private static void BGANLMLHKMD<T>(NativeArray<T> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<T> NOIPAHABMDB, int ODCCPKFDCOK, NativeArray<T> PBHFICHIHHI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class NAFPBMLMEFB
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum EKOMMFJGBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class PGIJANBONFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public ONMMPCFPEBK DICFBCCFLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int KGPLAAPDOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int ILJJAJBDHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long OBBCOIECEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long CMHLCNLODHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float PJCNEENCBJN;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6985F10", Offset = "0x6985110", VA = "0x186985F10")]
		public PGIJANBONFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6985ED0", Offset = "0x69850D0", VA = "0x186985ED0")]
		public void EECPCLJADFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string LBMPEFBEIGL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string OAILIMCCDHP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker KFPKICEBCKF;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker MGMHKMOPCMD;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker LKPKICCHCIN;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker DFAOIMAIGNH;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker KEOKKGCAAEB;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker FNLKAABJOAB;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker LFLDCJJAJDC;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker MOBGGDKJHCK;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker PJFKHNBGHDD;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker EJONBIGEANE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker BBFPGLANEIN;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker LBKGODOCFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<FDAECEGICND> GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly AHNPDBJIDJD EDNKDPACDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int BHPOFKEKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HOLGDCGDMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool HLJCMIIHDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool CBEPOBMCBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal EKOMMFJGBPJ DMDDBNBIFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool ILJPBAOOIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 PBLGLENLKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 MAAHCAJAEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float CHDCCAOHKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float ODOHGCAFABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int FOBGJOGPPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int HDLIDHAAOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int CFGKBOAHEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int PDBJLFGFKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float MKBCBOAPJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float FPDMGOMLIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int OAONDHKKHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long MGPMMOAEAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long EHLDCEMLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long EGBOAGEOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int JAHNMHDJLHE;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int JEFFOJANDFM = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] PLGLOHIGNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] OLEAMABMMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] HHABJHPBFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private NAJBPEBBKNG MJMJCPJNBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long AMFDOMJLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long ENNBGFBEBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int BACBFFJKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<PGIJANBONFA> GOKKHJCOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float KLIDCAFFDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal NAJBPEBBKNG.KNOOBMCACLL IMPGKLNMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool LNLOIDCNBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private HOHIEFDPLPG HHOIGDCILLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle PMFNNGDOOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> LPOKMHDKKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool DKGAKOCHJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle APCJOKBKJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NAJBPEBBKNG HFFALCHFILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform HGBAIGPNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private BBLLHGFLJJK AEFAJKCCLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long BKCPMNIHEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long MLAPDEGADAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long HNEIJPGAIJN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HKBKABBDKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8581C0", VA = "0x180858FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer PPPFMKBBPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x85A6C0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EAJPNEIOGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8BF040", Offset = "0x8BE240", VA = "0x1808BF040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LNBNKGDDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC36B30", Offset = "0xC35D30", VA = "0x180C36B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x697B2B0", Offset = "0x697A4B0", VA = "0x18697B2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<FDAECEGICND> JKBMFKNBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6978430", Offset = "0x6977630", VA = "0x186978430")]
	public void ECNMCPAEMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6976E20", Offset = "0x6976020", VA = "0x186976E20")]
	private void CNNCLGPCFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x697FBA0", Offset = "0x697EDA0", VA = "0x18697FBA0")]
	public NAFPBMLMEFB(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6978440", Offset = "0x6977640", VA = "0x186978440")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x697E960", Offset = "0x697DB60", VA = "0x18697E960")]
	public void NEBLIIAJNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69787A0", Offset = "0x69779A0", VA = "0x1869787A0")]
	private void GKCJFEGJHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6979F20", Offset = "0x6979120", VA = "0x186979F20")]
	public void GNCDIBNJHAL(FDAECEGICND MJLBICKANIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x697C480", Offset = "0x697B680", VA = "0x18697C480")]
	public bool KKMKMDPCGKN(FDAECEGICND MJLBICKANIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6977260", Offset = "0x6976460", VA = "0x186977260")]
	public bool DJONJHALGBO(FDAECEGICND MJLBICKANIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x697DA20", Offset = "0x697CC20", VA = "0x18697DA20", Slot = "4")]
	public virtual void LLJNEDJHFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x697C520", Offset = "0x697B720", VA = "0x18697C520")]
	public void KNBDEOEBCOJ(Transform BFOKBBAAOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69786B0", Offset = "0x69778B0", VA = "0x1869786B0")]
	private long GFCDOHMEJEJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x697C300", Offset = "0x697B500", VA = "0x18697C300")]
	private long JODDIOJDAOH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x697B2D0", Offset = "0x697A4D0", VA = "0x18697B2D0")]
	public bool JNFECMCCFMG(Transform BFOKBBAAOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6978CA0", Offset = "0x6977EA0", VA = "0x186978CA0")]
	public bool GLPNNAIGEEE(bool CJJLFBMNEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6976AC0", Offset = "0x6975CC0", VA = "0x186976AC0")]
	public void CMBNHNKAJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x697C730", Offset = "0x697B930", VA = "0x18697C730")]
	public bool LCAIOHNCMJC(float4x4 OBNNMAGIJBG, BatchedMeshRenderer CNCAAJKMDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6978A30", Offset = "0x6977C30", VA = "0x186978A30")]
	public void GLJNPAMGAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x697EA50", Offset = "0x697DC50", VA = "0x18697EA50")]
	public bool OJPDPHEEJEO(bool CJJLFBMNEBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6978790", Offset = "0x6977990", VA = "0x186978790")]
	public void GICIDKNNDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6978560", Offset = "0x6977760", VA = "0x186978560")]
	public void FBIPMGLGLFC(NAJBPEBBKNG DICFBCCFLEI, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6976240", Offset = "0x6975440", VA = "0x186976240")]
	public void BJOEIGIFCHN(ONMMPCFPEBK AGJBEJFOBLC, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6976A50", Offset = "0x6975C50", VA = "0x186976A50")]
	public (long, long, long) CIIGGKDJOEF()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9C1100", Offset = "0x9C0300", VA = "0x1809C1100")]
	public long FOLIADHNDMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x697F600", Offset = "0x697E800", VA = "0x18697F600")]
	private void PJGOPOLJENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x697A0F0", Offset = "0x69792F0", VA = "0x18697A0F0")]
	public (long, long) GOCOHFDIHDN(float IALCKDAINHG, float4x4 OBNNMAGIJBG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	public void FAMBOFJBLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6978590", Offset = "0x6977790", VA = "0x186978590")]
	internal void GDLABJGCJKC(EKOMMFJGBPJ BKOADNCOIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x697DE80", Offset = "0x697D080", VA = "0x18697DE80")]
	private (float, float, float) NAPBBHLKNDH(float ENIPBABACHE, float4x4 OBNNMAGIJBG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x697DAD0", Offset = "0x697CCD0", VA = "0x18697DAD0")]
	private (int, int) MHGDCCHAHON(float KNBBDPHGJOH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69772C0", Offset = "0x69764C0", VA = "0x1869772C0")]
	public void DMIKCDADOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x697EA20", Offset = "0x697DC20", VA = "0x18697EA20")]
	private void OFEOJOPMJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6976C40", Offset = "0x6975E40", VA = "0x186976C40")]
	private void CMFIALHJLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6976270", Offset = "0x6975470", VA = "0x186976270")]
	public long CCECPDBCAJM(long PNONPAELEBP, int HLCNBNDAHBI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x697ED20", Offset = "0x697DF20", VA = "0x18697ED20")]
	private void OPLNGFMBMOD(NAJBPEBBKNG KFEHDFDFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x697A4C0", Offset = "0x69796C0", VA = "0x18697A4C0")]
	private void HKOHOOBGFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x697A760", Offset = "0x6979960", VA = "0x18697A760")]
	private void IBMBPHLPKJI(NAJBPEBBKNG DICFBCCFLEI, ONMMPCFPEBK AGJBEJFOBLC, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct HOHIEFDPLPG : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct BBFBGGLFHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int CGAFFJNGCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int OPKALPEJAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int LONCBHAGKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int NGNBILJGBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int HKIALFFMAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int JLMOKAPPPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int KGPLAAPDOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int ILJJAJBDHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float PJCNEENCBJN;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct CHHGADCNOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public BECNFBKAHBJ.JCBPOMFHMED CGPFADAICCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float FNGPHGPDFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float PGPFNNBMGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float FHHPGPGDAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float DIMMDIFMOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float CCMAAAAMDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float JEAJHHMFPNA;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct ONAFDFMEKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> LEAHAPIOODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> KGAEPJOOKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> GHMJCGAJAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> BDAOJAKKOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> LBOBCMJEFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> PJJPFCOKHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool FKBFBHJPNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int GOHGHPNIKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int JGHJDPGMBEK;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6991230", Offset = "0x6990430", VA = "0x186991230")]
		public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool MCBCAPCHDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69914D0", Offset = "0x69906D0", VA = "0x1869914D0")]
		public static ONAFDFMEKCD EIGFFDAOBFL(NAJBPEBBKNG HKKDPGGNNBK)
		{
			return default(ONAFDFMEKCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6991410", Offset = "0x6990610", VA = "0x186991410")]
		public void EECPCLJADFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker AHEGCEOMKHC;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker MJABMBFNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<BBFBGGLFHEK> GLOIHCEBEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private ONAFDFMEKCD BALLEJKGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private ONAFDFMEKCD KFEHDFDFJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 FJIPOELGOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 BDBFFGNCBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private CHHGADCNOHK PGCMDLHAPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* FFBOHLDPENI;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	[BurstDiscard]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	[BurstDiscard]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	[BurstDiscard]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6974B10", Offset = "0x6973D10", VA = "0x186974B10")]
	public HOHIEFDPLPG([In] List<NAFPBMLMEFB.PGIJANBONFA> JGMNAPDLBMM, [In] NAJBPEBBKNG MJAAPFAPMAE, [In] NAFPBMLMEFB GKMJODLOHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6972BC0", Offset = "0x6971DC0", VA = "0x186972BC0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x69742F0", Offset = "0x69734F0", VA = "0x1869742F0")]
	public void OCPNPPKMLAH(List<NAFPBMLMEFB.PGIJANBONFA> HKCBDFAMMFB, [In] NAFPBMLMEFB GKMJODLOHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69742D0", Offset = "0x69734D0", VA = "0x1869742D0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool MEOIILHBCEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6972AF0", Offset = "0x6971CF0", VA = "0x186972AF0")]
	private ONMMPCFPEBK DOCENNGHCKO(int FGGLEFPMBBG, Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6972C10", Offset = "0x6971E10", VA = "0x186972C10")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GPGMKOLDCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6973F60", Offset = "0x6973160", VA = "0x186973F60")]
	[IgnoreWarning(1371)]
	private BBFBGGLFHEK KAMBONBNBHO([In] BBFBGGLFHEK DFBJHPELBPP, int CPNPIEACKDD, [In] NativeArray<int> NADKEDPNJIG, [In] NativeArray<bool> PECFPILAHFK, NativeArray<int> HDNGOOCDLGG)
	{
		return default(BBFBGGLFHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6974970", Offset = "0x6973B70", VA = "0x186974970")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int OLPOLECHNBB(NativeArray<int> NADKEDPNJIG, int NAEEKGNHJGL, int PGKKFOBNHMH, int CALNIFKBHPB)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker MALFIBHCOKC;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker NNDPHAHJEEC;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker DNOLICBOBPE;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker NMEIADHMPCE;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker OKMMICNOPID;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker KEOKKGCAAEB;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker CABCIIDENNN;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int IBOCMANLAIO = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Dictionary<Material, List<NAFPBMLMEFB>> FHOLCBFDBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<NAFPBMLMEFB> GBJLEIBNCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> GEEABGHCACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool ELLBPJAODOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool OJKAPNNDNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int HNKIHPHAJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> PPDOHKKNFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> NHMEMGDNCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> JMOOIFILADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> KBOMJGALOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private NAFPBMLMEFB HNGLGDIGCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material MHLDMAOGKFL;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int FGPDPAMOAHM = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, FDAECEGICND)> JHOMCJHKCLD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> BMGFCHDIOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int NDLPILCJANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x698D050", Offset = "0x698C250", VA = "0x18698D050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		private static void FFCICGEKPJO(bool BFOAIFCNHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6989A20", Offset = "0x6988C20", VA = "0x186989A20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6987EA0", Offset = "0x69870A0", VA = "0x186987EA0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6987C70", Offset = "0x6986E70", VA = "0x186987C70")]
		public NAFPBMLMEFB AddToBatchedMesh(FDAECEGICND LJDGDHFLMGN, Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x698C160", Offset = "0x698B360", VA = "0x18698C160")]
		public void RemoveFromBatchedMesh(FDAECEGICND DICFBCCFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6987D70", Offset = "0x6986F70", VA = "0x186987D70")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x698C940", Offset = "0x698BB40", VA = "0x18698C940")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Color KIJNHGNFMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x698C500", Offset = "0x698B700", VA = "0x18698C500")]
		public void SetMaterialProperty(int AOOLGPHJJIF, float JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x698C720", Offset = "0x698B920", VA = "0x18698C720")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Vector4 BAMLBBOKLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x698C2A0", Offset = "0x698B4A0", VA = "0x18698C2A0")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Matrix4x4 FPPOIAGEIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6988A50", Offset = "0x6987C50", VA = "0x186988A50")]
		private void JHKMIIOHJMG(Renderer GHBIMLIJLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6988070", Offset = "0x6987270", VA = "0x186988070")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6988060", Offset = "0x6987260", VA = "0x186988060")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6987750", Offset = "0x6986950", VA = "0x186987750")]
		private void AEJOEMJOBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6989320", Offset = "0x6988520", VA = "0x186989320")]
		private NAFPBMLMEFB MFOEMNMIEEO(FDAECEGICND DICFBCCFLEI, Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6989040", Offset = "0x6988240", VA = "0x186989040")]
		private NAFPBMLMEFB KIFKJKHJHCI(Material GIIKGEKINDH, int LLONNBOMNPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6988650", Offset = "0x6987850", VA = "0x186988650")]
		private NAFPBMLMEFB IILIKPJMHAA(Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18D4020", Offset = "0x18D3220", VA = "0x1818D4020")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6989540", Offset = "0x6988740", VA = "0x186989540")]
		public void MarkDirty(FDAECEGICND DICFBCCFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x69896A0", Offset = "0x69888A0", VA = "0x1869896A0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float IALCKDAINHG)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x698B1F0", Offset = "0x698A3F0", VA = "0x18698B1F0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6988110", Offset = "0x6987310", VA = "0x186988110")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6989D10", Offset = "0x6988F10", VA = "0x186989D10")]
		public void RebatchOptimally(int LKEFJAFGKPE, int NEDKDECPMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x698CDE0", Offset = "0x698BFE0", VA = "0x18698CDE0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class EHHLIJHOEKJ
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct CBLGFIGMJFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float CBHPEKJLLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer GCBPACDODGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public NAFPBMLMEFB NBCAIOIDCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long PKDFMKEJNIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class BHKCFCIPBJG : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x920B60", Offset = "0x91FD60", VA = "0x180920B60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x69875E0", Offset = "0x69867E0", VA = "0x1869875E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA77770", Offset = "0xA76970", VA = "0x180A77770")]
		[DebuggerHidden]
		public BHKCFCIPBJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6987630", Offset = "0x6986830", VA = "0x186987630", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6986890", Offset = "0x6985A90", VA = "0x186986890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x69867F0", Offset = "0x69859F0", VA = "0x1869867F0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6986840", Offset = "0x6985A40", VA = "0x186986840")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6987590", Offset = "0x6986790", VA = "0x186987590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x69874E0", Offset = "0x69866E0", VA = "0x1869874E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x69874E0", Offset = "0x69866E0", VA = "0x1869874E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker KEOKKGCAAEB;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker HPJOHKELBFH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker JNIODAKOKCK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker NCFOALHOIAJ;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 ECKJHALECKG;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int KAKDBBAAGKA;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int FIGMOMBHGNA;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int IIHOAFIIOJJ;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int HFIACMMPHLA;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int ICNIIFGFGOJ;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int DHLNBNOPNLP;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int FPPFHPMBCBI;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int LHBKLLOBPGF;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int EFCIPHEKOLK;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int HHLGNMEPHBC;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int KKGACPEBIDL;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int EJCGPFJMKJK;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int ICPAGOPKBDE;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int KANMPOCOKEJ;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long PKBMJLNMCAN;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long MCGLHIPINFM;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int GHMEBCAPFEJ;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int AKOGFAMJFMA;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int AHFANACJLKD;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long BMKHIFCHOCD;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool FPPMAMGOLKC;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> FLFJBOCDLDC;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<CBLGFIGMJFD> FFPPGAOJHFL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool IEEBCLBGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x698D960", Offset = "0x698CB60", VA = "0x18698D960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x698D9F0", Offset = "0x698CBF0", VA = "0x18698D9F0")]
	public static void EEKIDKGBNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x698D240", Offset = "0x698C440", VA = "0x18698D240")]
	public static void BOLIKDIKPKL(BatchedMeshRenderer LNEKBFHLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6990E10", Offset = "0x6990010", VA = "0x186990E10")]
	public static void PELMDNDPBGB(BatchedMeshRenderer LNEKBFHLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x698D0A0", Offset = "0x698C2A0", VA = "0x18698D0A0")]
	private static (long, long, long) AKNEANIPLIJ(long GBENNCDCKJK)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x698DFB0", Offset = "0x698D1B0", VA = "0x18698DFB0")]
	public static void LCAIOHNCMJC(long GBENNCDCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x698D4B0", Offset = "0x698C6B0", VA = "0x18698D4B0")]
	public static long CCECPDBCAJM(long PNONPAELEBP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x698D850", Offset = "0x698CA50", VA = "0x18698D850")]
	public static void CPMLOBNGEEG(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x698DEB0", Offset = "0x698D0B0", VA = "0x18698DEB0")]
	public static void JGPPPNBPIMI(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float OFPEDHFNFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6990690", Offset = "0x698F890", VA = "0x186990690")]
	public static void MCPGGPLLLKC(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float OFPEDHFNFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69907A0", Offset = "0x698F9A0", VA = "0x1869907A0")]
	public static void MLJJBMKJNEK(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6990AB0", Offset = "0x698FCB0", VA = "0x186990AB0")]
	public static float OKFHKJGHMPG(long LBBCIOCCOIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x698DBA0", Offset = "0x698CDA0", VA = "0x18698DBA0")]
	public static (long, long) GOCOHFDIHDN(float IALCKDAINHG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x698D1B0", Offset = "0x698C3B0", VA = "0x18698D1B0")]
	[IteratorStateMachine(typeof(BHKCFCIPBJG))]
	public static IEnumerable<bool> BFMPDPMBNEF(long GLPBPGGDPLE, bool BDHMLIHIGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6990940", Offset = "0x698FB40", VA = "0x186990940")]
	public static void OHFPIPPIHFM(long GLPBPGGDPLE, bool BDHMLIHIGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x698DD70", Offset = "0x698CF70", VA = "0x18698DD70")]
	public static int JBAMKABMKOE()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class FHANHKALJDM<KeyType> : NAFPBMLMEFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, FDAECEGICND> MDGDDDCLJMB;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDBF0", Offset = "0x3BECDF0", VA = "0x183BEDBF0")]
	public FHANHKALJDM(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BED850", Offset = "0x3BECA50", VA = "0x183BED850")]
	public void GNCDIBNJHAL(KeyType NDDCLPHCEEO, FDAECEGICND MJLBICKANIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BED9B0", Offset = "0x3BECBB0", VA = "0x183BED9B0")]
	public bool GOCJLOFAFIF(KeyType NDDCLPHCEEO, FDAECEGICND JHCHLEJPEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BED780", Offset = "0x3BEC980", VA = "0x183BED780")]
	public void DCFKEHMOEGL(KeyType NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDAA0", Offset = "0x3BECCA0", VA = "0x183BEDAA0", Slot = "4")]
	public override void LLJNEDJHFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6991720", Offset = "0x6990920", VA = "0x186991720")]
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
