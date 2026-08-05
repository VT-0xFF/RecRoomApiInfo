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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694A440", Offset = "0x6948E40", VA = "0x18694A440", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDB7B40", Offset = "0xDB6540", VA = "0x180DB7B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDB71C0", Offset = "0xDB5BC0", VA = "0x180DB71C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6F5B0", Offset = "0xA6DFB0", VA = "0x180A6F5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB65D0", Offset = "0xDB4FD0", VA = "0x180DB65D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6946400", Offset = "0x6944E00", VA = "0x186946400")]
	public HIMGIDMIPBN(int CKAMNHGFMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6944CF0", Offset = "0x69436F0", VA = "0x186944CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6945EC0", Offset = "0x69448C0", VA = "0x186945EC0")]
	public void EECPCLJADFI(JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69461E0", Offset = "0x6944BE0", VA = "0x1869461E0")]
	public void NGBKMPGDDCO(EBIEIMGKHLJ LINJEFIAFHO, OALODHMDGLN HILLMJIKOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6946090", Offset = "0x6944A90", VA = "0x186946090")]
	public void LDLOEJGPNMP(HGDOAMLPNBP LINJEFIAFHO, NativeArray<BEEODNIICBD> CMIJPDGNFOI, int BHPOFKEKDPM, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6944EB0", Offset = "0x69438B0", VA = "0x186944EB0")]
	public JobHandle EDGJAHCBCOE(NAJBPEBBKNG OPDABIFMIPI, LEFCAAKHOCL OCHMECPEPDN, float3 HMCDIKIEIPP, quaternion CBELOFBFGLG, float KCLKPLDJNJE, bool HJHHNOJHCHH, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69449B0", Offset = "0x69433B0", VA = "0x1869449B0")]
	public static JobHandle DKDCBGBAPGG(KGPNDFHLDEG CGOBGJGGBOO, NAJBPEBBKNG OPDABIFMIPI, EBIEIMGKHLJ LINJEFIAFHO, JobHandle BHOKFONKIGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6944700", Offset = "0x6943100", VA = "0x186944700")]
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
		[Cpp2IlInjected.Address(RVA = "0x694B9C0", Offset = "0x694A3C0", VA = "0x18694B9C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x694BAF0", Offset = "0x694A4F0", VA = "0x18694BAF0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x694B910", Offset = "0x694A310", VA = "0x18694B910")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x694B700", Offset = "0x694A100", VA = "0x18694B700")]
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
		[Cpp2IlInjected.Address(RVA = "0x693AA60", Offset = "0x6939460", VA = "0x18693AA60")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x693AB90", Offset = "0x6939590", VA = "0x18693AB90")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x693A9B0", Offset = "0x69393B0", VA = "0x18693A9B0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x693A720", Offset = "0x6939120", VA = "0x18693A720")]
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
		[Cpp2IlInjected.Address(RVA = "0x6949E90", Offset = "0x6948890", VA = "0x186949E90")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6949FC0", Offset = "0x69489C0", VA = "0x186949FC0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6949DE0", Offset = "0x69487E0", VA = "0x186949DE0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6949B50", Offset = "0x6948550", VA = "0x186949B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6938D50", Offset = "0x6937750", VA = "0x186938D50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6938E80", Offset = "0x6937880", VA = "0x186938E80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6938CA0", Offset = "0x69376A0", VA = "0x186938CA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6938A10", Offset = "0x6937410", VA = "0x186938A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x693DDD0", Offset = "0x693C7D0", VA = "0x18693DDD0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x693DF00", Offset = "0x693C900", VA = "0x18693DF00")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x693DD20", Offset = "0x693C720", VA = "0x18693DD20")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x693DB00", Offset = "0x693C500", VA = "0x18693DB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x69419F0", Offset = "0x69403F0", VA = "0x1869419F0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6941B20", Offset = "0x6940520", VA = "0x186941B20")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6941940", Offset = "0x6940340", VA = "0x186941940")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6941750", Offset = "0x6940150", VA = "0x186941750")]
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
		[Cpp2IlInjected.Address(RVA = "0x69480D0", Offset = "0x6946AD0", VA = "0x1869480D0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6948200", Offset = "0x6946C00", VA = "0x186948200")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6948020", Offset = "0x6946A20", VA = "0x186948020")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6947DD0", Offset = "0x69467D0", VA = "0x186947DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69479B0", Offset = "0x69463B0", VA = "0x1869479B0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6947AE0", Offset = "0x69464E0", VA = "0x186947AE0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6947900", Offset = "0x6946300", VA = "0x186947900")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6947710", Offset = "0x6946110", VA = "0x186947710")]
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
		[Cpp2IlInjected.Address(RVA = "0x69547C0", Offset = "0x69531C0", VA = "0x1869547C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69548F0", Offset = "0x69532F0", VA = "0x1869548F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6954710", Offset = "0x6953110", VA = "0x186954710")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6954450", Offset = "0x6952E50", VA = "0x186954450")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943870", Offset = "0x6942270", VA = "0x186943870")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69439A0", Offset = "0x69423A0", VA = "0x1869439A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69437C0", Offset = "0x69421C0", VA = "0x1869437C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6943510", Offset = "0x6941F10", VA = "0x186943510")]
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
		[Cpp2IlInjected.Address(RVA = "0x6941F50", Offset = "0x6940950", VA = "0x186941F50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6942080", Offset = "0x6940A80", VA = "0x186942080")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6941EA0", Offset = "0x69408A0", VA = "0x186941EA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6941C80", Offset = "0x6940680", VA = "0x186941C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x693B880", Offset = "0x693A280", VA = "0x18693B880")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x693B9B0", Offset = "0x693A3B0", VA = "0x18693B9B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x693B7D0", Offset = "0x693A1D0", VA = "0x18693B7D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x693B590", Offset = "0x6939F90", VA = "0x18693B590")]
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
		[Cpp2IlInjected.Address(RVA = "0x693BE50", Offset = "0x693A850", VA = "0x18693BE50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x693BF80", Offset = "0x693A980", VA = "0x18693BF80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x693BDA0", Offset = "0x693A7A0", VA = "0x18693BDA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x693BB10", Offset = "0x693A510", VA = "0x18693BB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x694A910", Offset = "0x6949310", VA = "0x18694A910")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x694AA40", Offset = "0x6949440", VA = "0x18694AA40")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x694A860", Offset = "0x6949260", VA = "0x18694A860")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x694A590", Offset = "0x6948F90", VA = "0x18694A590")]
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
		[Cpp2IlInjected.Address(RVA = "0x694B470", Offset = "0x6949E70", VA = "0x18694B470")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x694B5A0", Offset = "0x6949FA0", VA = "0x18694B5A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x694B3C0", Offset = "0x6949DC0", VA = "0x18694B3C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x694B0F0", Offset = "0x6949AF0", VA = "0x18694B0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69414C0", Offset = "0x693FEC0", VA = "0x1869414C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69415F0", Offset = "0x693FFF0", VA = "0x1869415F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6941410", Offset = "0x693FE10", VA = "0x186941410")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6941060", Offset = "0x693FA60", VA = "0x186941060")]
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
		[Cpp2IlInjected.Address(RVA = "0x693A290", Offset = "0x6938C90", VA = "0x18693A290")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x693A3C0", Offset = "0x6938DC0", VA = "0x18693A3C0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x693A1E0", Offset = "0x6938BE0", VA = "0x18693A1E0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6939F90", Offset = "0x6938990", VA = "0x186939F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x694AE60", Offset = "0x6949860", VA = "0x18694AE60")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x694AF90", Offset = "0x6949990", VA = "0x18694AF90")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x694ADB0", Offset = "0x69497B0", VA = "0x18694ADB0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x694ABA0", Offset = "0x69495A0", VA = "0x18694ABA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6942700", Offset = "0x6941100", VA = "0x186942700")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6942830", Offset = "0x6941230", VA = "0x186942830")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6942650", Offset = "0x6941050", VA = "0x186942650")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6942400", Offset = "0x6940E00", VA = "0x186942400")]
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
		[Cpp2IlInjected.Address(RVA = "0x6944470", Offset = "0x6942E70", VA = "0x186944470")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69445A0", Offset = "0x6942FA0", VA = "0x1869445A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69443C0", Offset = "0x6942DC0", VA = "0x1869443C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69441D0", Offset = "0x6942BD0", VA = "0x1869441D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6940910", Offset = "0x693F310", VA = "0x186940910")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6940A40", Offset = "0x693F440", VA = "0x186940A40")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6940860", Offset = "0x693F260", VA = "0x186940860")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69405A0", Offset = "0x693EFA0", VA = "0x1869405A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6938780", Offset = "0x6937180", VA = "0x186938780")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69388B0", Offset = "0x69372B0", VA = "0x1869388B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69386D0", Offset = "0x69370D0", VA = "0x1869386D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6938420", Offset = "0x6936E20", VA = "0x186938420")]
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
		[Cpp2IlInjected.Address(RVA = "0x69541C0", Offset = "0x6952BC0", VA = "0x1869541C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x69542F0", Offset = "0x6952CF0", VA = "0x1869542F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6954110", Offset = "0x6952B10", VA = "0x186954110")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6953E90", Offset = "0x6952890", VA = "0x186953E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943280", Offset = "0x6941C80", VA = "0x186943280")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x6941DB0", VA = "0x1869433B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x69431D0", Offset = "0x6941BD0", VA = "0x1869431D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6942FB0", Offset = "0x69419B0", VA = "0x186942FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6942D20", Offset = "0x6941720", VA = "0x186942D20")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6942E50", Offset = "0x6941850", VA = "0x186942E50")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6942C70", Offset = "0x6941670", VA = "0x186942C70")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6942990", Offset = "0x6941390", VA = "0x186942990")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943F40", Offset = "0x6942940", VA = "0x186943F40")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6944070", Offset = "0x6942A70", VA = "0x186944070")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6943E90", Offset = "0x6942890", VA = "0x186943E90")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6943B00", Offset = "0x6942500", VA = "0x186943B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939B00", Offset = "0x6938500", VA = "0x186939B00")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6939C30", Offset = "0x6938630", VA = "0x186939C30")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6939A50", Offset = "0x6938450", VA = "0x186939A50")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69396B0", Offset = "0x69380B0", VA = "0x1869396B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939420", Offset = "0x6937E20", VA = "0x186939420")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6939550", Offset = "0x6937F50", VA = "0x186939550")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6939370", Offset = "0x6937D70", VA = "0x186939370")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6938FE0", Offset = "0x69379E0", VA = "0x186938FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6946940", Offset = "0x6945340", VA = "0x186946940")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6946A70", Offset = "0x6945470", VA = "0x186946A70")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6946890", Offset = "0x6945290", VA = "0x186946890")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6946610", Offset = "0x6945010", VA = "0x186946610")]
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
		[Cpp2IlInjected.Address(RVA = "0x694CED0", Offset = "0x694B8D0", VA = "0x18694CED0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x694D000", Offset = "0x694BA00", VA = "0x18694D000")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x694CE20", Offset = "0x694B820", VA = "0x18694CE20")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x694CBE0", Offset = "0x694B5E0", VA = "0x18694CBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6953C00", Offset = "0x6952600", VA = "0x186953C00")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6953D30", Offset = "0x6952730", VA = "0x186953D30")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6953B50", Offset = "0x6952550", VA = "0x186953B50")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6953910", Offset = "0x6952310", VA = "0x186953910")]
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
		[Cpp2IlInjected.Address(RVA = "0x693B300", Offset = "0x6939D00", VA = "0x18693B300")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x693B430", Offset = "0x6939E30", VA = "0x18693B430")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x693B250", Offset = "0x6939C50", VA = "0x18693B250")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x693AEF0", Offset = "0x69398F0", VA = "0x18693AEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694C950", Offset = "0x694B350", VA = "0x18694C950")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x694CA80", Offset = "0x694B480", VA = "0x18694CA80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x694C8A0", Offset = "0x694B2A0", VA = "0x18694C8A0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x694C6D0", Offset = "0x694B0D0", VA = "0x18694C6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69507F0", Offset = "0x694F1F0", VA = "0x1869507F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x694FD50", Offset = "0x694E750", VA = "0x18694FD50")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69512C0", Offset = "0x694FCC0", VA = "0x1869512C0")]
	public static ONMMPCFPEBK JGIIBNEOBDO(Allocator CHDJMCMMMLJ, NAJBPEBBKNG IMCJMBEIOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69514A0", Offset = "0x694FEA0", VA = "0x1869514A0")]
	public static ONMMPCFPEBK JGIIBNEOBDO(Allocator CHDJMCMMMLJ, NativeArray<float3> PACCJLNOCPC, NativeArray<float3> DFCLFIHOBEI, NativeArray<float2> INOODCJHGLL, NativeArray<float4> EOIJCDLBGFH, bool FKBFBHJPNMF, NativeArray<float4> KEGJFGMIBPP, NativeArray<int> MLLIMDHIAHO, int BHPOFKEKDPM, int ICLHALGKOLH, int HOLGDCGDMAL, int CLFPMMMOANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x694E0E0", Offset = "0x694CAE0", VA = "0x18694E0E0")]
	public NAJBPEBBKNG CJEPCENKMKG(Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6950240", Offset = "0x694EC40", VA = "0x186950240")]
	public void FOJFIIIODJJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6950590", Offset = "0x694EF90", VA = "0x186950590")]
	private void HCHNJJBGJNP(Mesh DICFBCCFLEI, NativeArray<ushort> FDPKMBMHLAP, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6950D40", Offset = "0x694F740", VA = "0x186950D40")]
	public void JDFIOJFBMJA(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x694F590", Offset = "0x694DF90", VA = "0x18694F590")]
	public void DMMGPNHAEHF(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x694EBF0", Offset = "0x694D5F0", VA = "0x18694EBF0")]
	public void CMECELCEBCJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6952DF0", Offset = "0x69517F0", VA = "0x186952DF0")]
	public void NCJNLCDOODA(Mesh DICFBCCFLEI, NAJBPEBBKNG.KNOOBMCACLL BGOCEECJDJL, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x694DFB0", Offset = "0x694C9B0", VA = "0x18694DFB0")]
	public long CIIGGKDJOEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x694D600", Offset = "0x694C000", VA = "0x18694D600")]
	public long BNBMCJOBFOE(NAJBPEBBKNG.KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x694D160", Offset = "0x694BB60", VA = "0x18694D160")]
	private void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool MCBCAPCHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6951FF0", Offset = "0x69509F0", VA = "0x186951FF0")]
	private void KHDMNGHNIII(NativeArray<float3> EIKCCLGECIE, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6951F70", Offset = "0x6950970", VA = "0x186951F70")]
	[BurstCompile]
	private unsafe static void KHDMNGHNIII([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69531F0", Offset = "0x6951BF0", VA = "0x1869531F0")]
	[BurstCompile]
	private unsafe static void OBDMIONIBLO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69521B0", Offset = "0x6950BB0", VA = "0x1869521B0")]
	[BurstCompile]
	private unsafe static void LKOMJJBIANK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6953170", Offset = "0x6951B70", VA = "0x186953170")]
	[BurstCompile]
	private unsafe static void NOEILGONJAB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69508C0", Offset = "0x694F2C0", VA = "0x1869508C0")]
	private void HHDAINNHBKF(NativeArray<float3> PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6950830", Offset = "0x694F230", VA = "0x186950830")]
	[BurstCompile]
	private unsafe static void HHDAINNHBKF([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6952450", Offset = "0x6950E50", VA = "0x186952450")]
	private void LLPMNHHGONH(NativeArray<float3> DFCLFIHOBEI, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6952230", Offset = "0x6950C30", VA = "0x186952230")]
	[BurstCompile]
	private unsafe static void LLPMNHHGONH([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6950B00", Offset = "0x694F500", VA = "0x186950B00")]
	private void IBEFEMHIKAN(NativeArray<float3> FFCNMPCEIFC, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6950BD0", Offset = "0x694F5D0", VA = "0x186950BD0")]
	[BurstCompile]
	private unsafe static void IBEFEMHIKAN([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6952A20", Offset = "0x6951420", VA = "0x186952A20")]
	[BurstCompile]
	private unsafe static void MNJFLBBPMMG([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6952C40", Offset = "0x6951640", VA = "0x186952C40")]
	[BurstCompile]
	private unsafe static void MOKOHHJLAKP([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6950340", Offset = "0x694ED40", VA = "0x186950340")]
	[BurstCompile]
	private unsafe static void GCMJLHGOKBH([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6953410", Offset = "0x6951E10", VA = "0x186953410")]
	private void PFHOGCIKNMG(NativeArray<float2> INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69534E0", Offset = "0x6951EE0", VA = "0x1869534E0")]
	[BurstCompile]
	private unsafe static void PFHOGCIKNMG([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6953390", Offset = "0x6951D90", VA = "0x186953390")]
	[BurstCompile]
	private static void OPLKEBLOIAL([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x694F250", Offset = "0x694DC50", VA = "0x18694F250")]
	private void DEENGLOFEJO(NativeArray<float2> JHIJPONAINF, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x694F1D0", Offset = "0x694DBD0", VA = "0x18694F1D0")]
	[BurstCompile]
	private unsafe static void DEENGLOFEJO([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x694FEF0", Offset = "0x694E8F0", VA = "0x18694FEF0")]
	[BurstCompile]
	private unsafe static void FCDFBHJJICG([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6950C40", Offset = "0x694F640", VA = "0x186950C40")]
	[BurstCompile]
	private unsafe static void IHLGBNCGGED([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6950CC0", Offset = "0x694F6C0", VA = "0x186950CC0")]
	[BurstCompile]
	private unsafe static void IOOFODNBEBF([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6952510", Offset = "0x6950F10", VA = "0x186952510")]
	private void LOAPMMDGJCO(NativeArray<float4> KEGJFGMIBPP, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6952600", Offset = "0x6951000", VA = "0x186952600")]
	[BurstCompile]
	private unsafe static void LOAPMMDGJCO([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x694D2F0", Offset = "0x694BCF0", VA = "0x18694D2F0")]
	[BurstCompile]
	private static ushort BEEPKFDIOKE([In] float4 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x694E730", Offset = "0x694D130", VA = "0x18694E730")]
	private void CKDMEBGIKLF(NativeArray<float4> CBDMHNPJPJL, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x694E6C0", Offset = "0x694D0C0", VA = "0x18694E6C0")]
	[BurstCompile]
	private unsafe static void CKDMEBGIKLF([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6952F50", Offset = "0x6951950", VA = "0x186952F50")]
	[BurstCompile]
	private unsafe static void NKNPOALKOOP([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69519F0", Offset = "0x69503F0", VA = "0x1869519F0")]
	[BurstCompile]
	private unsafe static void JJEDFPGAEPM([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x694D8C0", Offset = "0x694C2C0", VA = "0x18694D8C0")]
	[BurstCompile]
	private unsafe static void CEMPAIHBOJL([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69529C0", Offset = "0x69513C0", VA = "0x1869529C0")]
	[BurstCompile]
	private static void MLFGCOMNPCK([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x694D930", Offset = "0x694C330", VA = "0x18694D930")]
	private void CGBIINEGBJO(Allocator CHDJMCMMMLJ, NativeArray<float4> EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x694DD10", Offset = "0x694C710", VA = "0x18694DD10")]
	[BurstCompile]
	private unsafe static void CGBIINEGBJO([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x694D6F0", Offset = "0x694C0F0", VA = "0x18694D6F0")]
	private static void CBADDDMNEJF(NativeArray<float4> BPPKHLDPGPI, NativeArray<NIOMDIPAKGG> DPJDJKECOOD, NativeArray<byte> MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x694D670", Offset = "0x694C070", VA = "0x18694D670")]
	[BurstCompile]
	private unsafe static void CBADDDMNEJF([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6953310", Offset = "0x6951D10", VA = "0x186953310")]
	[BurstCompile]
	private unsafe static void OLANFNCIEBJ([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69528A0", Offset = "0x69512A0", VA = "0x1869528A0")]
	[BurstCompile]
	private unsafe static void MGHPOLAAOAB([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6950150", Offset = "0x694EB50", VA = "0x186950150")]
	[BurstCompile]
	private unsafe static void FLHLKHHPDPG([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6951A60", Offset = "0x6950460", VA = "0x186951A60")]
	private void JKMJGLIKINI(Allocator CHDJMCMMMLJ, NativeArray<int> MLLIMDHIAHO, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x694E870", Offset = "0x694D270", VA = "0x18694E870")]
	private static NativeArray<byte> CKDNFIPDKPM(Allocator CHDJMCMMMLJ, NativeArray<int> MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x694E800", Offset = "0x694D200", VA = "0x18694E800")]
	[BurstCompile]
	private unsafe static int CKDNFIPDKPM([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6952D20", Offset = "0x6951720", VA = "0x186952D20")]
	private static void NCABMFCBGFM(NativeArray<int> JGNGHKAEEMO, NativeArray<byte> FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6952CB0", Offset = "0x69516B0", VA = "0x186952CB0")]
	[BurstCompile]
	private unsafe static void NCABMFCBGFM([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69501D0", Offset = "0x694EBD0", VA = "0x1869501D0")]
	[BurstCompile]
	private unsafe static void FOELNMCPCFM([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x694D290", Offset = "0x694BC90", VA = "0x18694D290")]
	[BurstCompile]
	private static void ANEBOGOMLPE([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6951D60", Offset = "0x6950760", VA = "0x186951D60")]
	[BurstCompile]
	private static ushort KFHHCFDHBIH([In] float3 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public ONMMPCFPEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6936E80", Offset = "0x6935880", VA = "0x186936E80")]
	[BurstCompile]
	public unsafe static void HPEDGPPGAPP([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x694D800", Offset = "0x694C200", VA = "0x18694D800")]
	[BurstCompile]
	public unsafe static void CEGEHIGGCCC([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69520F0", Offset = "0x6950AF0", VA = "0x1869520F0")]
	[BurstCompile]
	public unsafe static void KJFEGEJBLLK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x694F350", Offset = "0x694DD50", VA = "0x18694F350")]
	[BurstCompile]
	public unsafe static void DGGHLJPGKHB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69378A0", Offset = "0x69362A0", VA = "0x1869378A0")]
	[BurstCompile]
	public unsafe static void JEHHCLMCBKF([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6937380", Offset = "0x6935D80", VA = "0x186937380")]
	[BurstCompile]
	public unsafe static void IKKIDIMOAOA([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x694FE50", Offset = "0x694E850", VA = "0x18694FE50")]
	[BurstCompile]
	public unsafe static void FAEKCKBHMBD([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6936A80", Offset = "0x6935480", VA = "0x186936A80")]
	[BurstCompile]
	public unsafe static void EPODGLMPDOI([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6951B40", Offset = "0x6950540", VA = "0x186951B40")]
	[BurstCompile]
	public unsafe static void JMKHKPEGIEK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x694D340", Offset = "0x694BD40", VA = "0x18694D340")]
	[BurstCompile]
	public unsafe static void BKEKIOLOFPC([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69375E0", Offset = "0x6935FE0", VA = "0x1869375E0")]
	[BurstCompile]
	public unsafe static void INIENDBIDHL([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x694DF60", Offset = "0x694C960", VA = "0x18694DF60")]
	[BurstCompile]
	public static void CHJOBCJFCEH([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x694F410", Offset = "0x694DE10", VA = "0x18694F410")]
	[BurstCompile]
	public unsafe static void DJDEPODMKOL([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x694D510", Offset = "0x694BF10", VA = "0x18694D510")]
	[BurstCompile]
	public unsafe static void BLLMBFHHJLH([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6951C60", Offset = "0x6950660", VA = "0x186951C60")]
	[BurstCompile]
	public unsafe static void JNJGGONAIEE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x694FB70", Offset = "0x694E570", VA = "0x18694FB70")]
	[BurstCompile]
	public unsafe static void ECDDIMHEJKP([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6952920", Offset = "0x6951320", VA = "0x186952920")]
	[BurstCompile]
	public unsafe static void MHBCEHNKKCC([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6951990", Offset = "0x6950390", VA = "0x186951990")]
	[BurstCompile]
	public static ushort JHFHFNFCKPD([In] float4 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6953270", Offset = "0x6951C70", VA = "0x186953270")]
	[BurstCompile]
	public unsafe static void OGOHBPOGDKG([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69370D0", Offset = "0x6935AD0", VA = "0x1869370D0")]
	[BurstCompile]
	public unsafe static void IEFEPGFNIKL([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6952680", Offset = "0x6951080", VA = "0x186952680")]
	[BurstCompile]
	public unsafe static void MDCDNBMKKEO([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x694EAE0", Offset = "0x694D4E0", VA = "0x18694EAE0")]
	[BurstCompile]
	public unsafe static void CMDPEGMNMEC([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x694D450", Offset = "0x694BE50", VA = "0x18694D450")]
	[BurstCompile]
	public static void BKMLPBOLKBA([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6936CC0", Offset = "0x69356C0", VA = "0x186936CC0")]
	[BurstCompile]
	public unsafe static void FCPKGDCFHIO([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69506B0", Offset = "0x694F0B0", VA = "0x1869506B0")]
	[BurstCompile]
	public unsafe static void HFOBLINEJNM([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x694FF70", Offset = "0x694E970", VA = "0x18694FF70")]
	[BurstCompile]
	public unsafe static void FLFMOMDLOHO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69503B0", Offset = "0x694EDB0", VA = "0x1869503B0")]
	[BurstCompile]
	public unsafe static void GHCHOBBBMAL([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6953730", Offset = "0x6952130", VA = "0x186953730")]
	[BurstCompile]
	public unsafe static void PJOMKMAHDIM([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69527A0", Offset = "0x69511A0", VA = "0x1869527A0")]
	[BurstCompile]
	public unsafe static int MFFIDOGCALE([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x694F4F0", Offset = "0x694DEF0", VA = "0x18694F4F0")]
	[BurstCompile]
	public unsafe static void DLPELCNGBHC([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x694E040", Offset = "0x694CA40", VA = "0x18694E040")]
	[BurstCompile]
	public unsafe static void CIPHDGIIPIN([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69509C0", Offset = "0x694F3C0", VA = "0x1869509C0")]
	[BurstCompile]
	public static void HIBOALAABLL([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6937C80", Offset = "0x6936680", VA = "0x186937C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x693C220", Offset = "0x693AC20", VA = "0x18693C220")]
	public CJKDABCKDLF(int NOLHGPALGBF, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x693C0E0", Offset = "0x693AAE0", VA = "0x18693C0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x693C140", Offset = "0x693AB40", VA = "0x18693C140")]
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
		[Cpp2IlInjected.Address(RVA = "0x693C3D0", Offset = "0x693ADD0", VA = "0x18693C3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<HDBOOPAJBBL> IHALGGEFJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x693C470", Offset = "0x693AE70", VA = "0x18693C470")]
		get
		{
			return default(NativeList<HDBOOPAJBBL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CJKDABCKDLF JBCAHILOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x693CD30", Offset = "0x693B730", VA = "0x18693CD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x693CDD0", Offset = "0x693B7D0", VA = "0x18693CDD0")]
	private static void HNHKHPLKGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x693D950", Offset = "0x693C350", VA = "0x18693D950")]
	public static int NPBDCEDPEDN(bool GMOOOENEPCC, int FBHJLEPEJCC, bool GOLOLCFOBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x693C450", Offset = "0x693AE50", VA = "0x18693C450")]
	private static int DAKAAFNKEFD(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x693D980", Offset = "0x693C380", VA = "0x18693D980")]
	private static int PEDJEMKCBDN(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x693D6D0", Offset = "0x693C0D0", VA = "0x18693D6D0")]
	public static int KCBEJALBBAP(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x693C550", Offset = "0x693AF50", VA = "0x18693C550")]
	public static int EFLMNMDKKMD(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x693D420", Offset = "0x693BE20", VA = "0x18693D420")]
	public static int HOBFEDCLLGK(int PEAMNBBBMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x693D430", Offset = "0x693BE30", VA = "0x18693D430")]
	private static int ILMGCAALFDA(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x693C510", Offset = "0x693AF10", VA = "0x18693C510")]
	private static int DKALFPDPDNB(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x693D8E0", Offset = "0x693C2E0", VA = "0x18693D8E0")]
	public static int NKKELEELGAB(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x693D850", Offset = "0x693C250", VA = "0x18693D850")]
	public static int NKAFBGPJMEC(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x693C530", Offset = "0x693AF30", VA = "0x18693C530")]
	public static int EAMPOPBCKNO(int PEAMNBBBMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x693D760", Offset = "0x693C160", VA = "0x18693D760")]
	public static CJKDABCKDLF NGIIKJDAEMK(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x693D440", Offset = "0x693BE40", VA = "0x18693D440")]
	private static CJKDABCKDLF IOKENIHIOBP(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x693C2E0", Offset = "0x693ACE0", VA = "0x18693C2E0")]
	public static CJKDABCKDLF AHOFHNNBNDG(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x693C9F0", Offset = "0x693B3F0", VA = "0x18693C9F0")]
	private static CJKDABCKDLF GEIANPINPPF(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x693C5E0", Offset = "0x693AFE0", VA = "0x18693C5E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69422D0", Offset = "0x6940CD0", VA = "0x1869422D0")]
	public GEAABJGODDH(NativeArray<BEEODNIICBD> NMAAOPGFHCD, int ECGAAJFODGN = 1, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69421E0", Offset = "0x6940BE0", VA = "0x1869421E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x693FFE0", Offset = "0x693E9E0", VA = "0x18693FFE0")]
	public DIKKDOGKKME(HIMGIDMIPBN JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6940270", Offset = "0x693EC70", VA = "0x186940270")]
	public DIKKDOGKKME(GEAABJGODDH JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float3 GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x693EB90", Offset = "0x693D590", VA = "0x18693EB90")]
	private float3 DBBOPDDAFKM(float3 KMIECBFKDNO, Matrix4x4 NGKIDPFLBJB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x693E060", Offset = "0x693CA60", VA = "0x18693E060")]
	private float3x3 BNLDFFKIOBH(float3x3 EICDHCELANI, float3x3 HLBAEJFFCFF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x693FFD0", Offset = "0x693E9D0", VA = "0x18693FFD0")]
	private float MEIMMLKDHEB(float CDPPGBMBKAI, float EJMIDHCGIBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x693ECC0", Offset = "0x693D6C0", VA = "0x18693ECC0", Slot = "4")]
	public void Execute(int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x693FE60", Offset = "0x693E860", VA = "0x18693FE60")]
	private void GHAIPBICKFC(int ADICGEAPMKC, float3 HGDCPNGLIKJ, float3 NFFLDAHKGKD, float3 AKIMOBCHKEL, float EOGPEOAFBNO, bool FOLLGGKILFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x693E0E0", Offset = "0x693CAE0", VA = "0x18693E0E0")]
	private void CEIODGGNBPK(HGDOAMLPNBP MBNEEJMJPMJ, float3 BCPGICOCGEJ, float3x3 OBKMAHDAHKH, float CDPPGBMBKAI, int GJGIBLAFHHL, int FKCGALHHLKD, int JLPNAEGILAG, float AICJBILPPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x693E540", Offset = "0x693CF40", VA = "0x18693E540")]
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
	[Cpp2IlInjected.Address(RVA = "0x6947CE0", Offset = "0x69466E0", VA = "0x186947CE0")]
	public KGPNDFHLDEG(int ECGAAJFODGN, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6947C40", Offset = "0x6946640", VA = "0x186947C40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6949960", Offset = "0x6948360", VA = "0x186949960")]
	public KLEGDAKJIOG(HIMGIDMIPBN JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6949770", Offset = "0x6948170", VA = "0x186949770")]
	public KLEGDAKJIOG(KGPNDFHLDEG LINJEFIAFHO, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float3 GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6948780", Offset = "0x6947180", VA = "0x186948780", Slot = "4")]
	public void Execute(int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69483D0", Offset = "0x6946DD0", VA = "0x1869483D0")]
	private void BBLDOADIKME(float4x4 CEKCEFDOFME, int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6948360", Offset = "0x6946D60", VA = "0x186948360")]
	private IFLHLIHNOHO AHECGCOAHHL(float3 NFFLDAHKGKD)
	{
		return default(IFLHLIHNOHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6949720", Offset = "0x6948120", VA = "0x186949720")]
	private float4 MBBIAMEAMNN(IFLHLIHNOHO ELMGLGBPLLE, int DHNLEFJCEAH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69496E0", Offset = "0x69480E0", VA = "0x1869496E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694BC50", Offset = "0x694A650", VA = "0x18694BC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 KNFHACNBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x694C1F0", Offset = "0x694ABF0", VA = "0x18694C1F0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x694C5E0", Offset = "0x694AFE0", VA = "0x18694C5E0")]
	public OALODHMDGLN(float3 HGDCPNGLIKJ, quaternion LCDJINCAHMD, float3 ECGAAJFODGN, CHMPEFEAHOC NCMHJNKFAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x694BFF0", Offset = "0x694A9F0", VA = "0x18694BFF0")]
	public float FMLHFOHCPBE(float3 BCPGICOCGEJ, float EEBNCGOCFGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x694C2D0", Offset = "0x694ACD0", VA = "0x18694C2D0")]
	public bool NNKABFKKNBC(float3 NFFLDAHKGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x694C3C0", Offset = "0x694ADC0", VA = "0x18694C3C0")]
	public void PCHEPJFDHBB(float3 JMDOAKIMNLC, float3x3 MAEHDLJGHCI, float MJNPDCBNHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x694BC60", Offset = "0x694A660", VA = "0x18694BC60")]
	private void BGINIPHNCJH(float3 FNIJIKICPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x694BD60", Offset = "0x694A760", VA = "0x18694BD60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6947670", Offset = "0x6946070", VA = "0x186947670")]
	public ICABHPNHGDE(NAJBPEBBKNG DICFBCCFLEI, float BKOEIEGNMCI, int JHEGPJBDKAJ, int GJGIBLAFHHL, NativeList<OALODHMDGLN> LINJEFIAFHO, NativeArray<int> PEFLDMODNIF, NativeList<HDBOOPAJBBL> POMECMHLLCI, LEFCAAKHOCL OCHMECPEPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6946C90", Offset = "0x6945690", VA = "0x186946C90", Slot = "4")]
	public void Execute(int EDJMDAGODNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6946BD0", Offset = "0x69455D0", VA = "0x186946BD0")]
	private bool DIIGBFPOACO(OALODHMDGLN MLFGLJKBOIG, OALODHMDGLN GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x69473D0", Offset = "0x6945DD0", VA = "0x1869473D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x694A120", Offset = "0x6948B20", VA = "0x18694A120")]
	public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x694A420", Offset = "0x6948E20", VA = "0x18694A420")]
	public static long FDDHMOCCAJC(int NOLHGPALGBF, int HECJMBFPMPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x694A240", Offset = "0x6948C40", VA = "0x18694A240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x694A330", Offset = "0x6948D30", VA = "0x18694A330")]
	public void EECPCLJADFI(JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x6940FE0", Offset = "0x693F9E0", VA = "0x186940FE0")]
	public EIJLFHILFBK(NAJBPEBBKNG DICFBCCFLEI, LEFCAAKHOCL OCHMECPEPDN, int MGIIKHOMNLD = 0, int OOBFMNLJHPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6940BA0", Offset = "0x693F5A0", VA = "0x186940BA0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6940F80", Offset = "0x693F980", VA = "0x186940F80")]
	private void GKBANPEJAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DDJFECLMAJL
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2976280", Offset = "0x2974C80", VA = "0x182976280")]
	public static bool FJIFLAMOAMH<T>(NativeArray<T> PFKJAOOHGBN, int ECGAAJFODGN, Allocator CHDJMCMMMLJ, NativeArrayOptions FDGBBGJEJMA = NativeArrayOptions.ClearMemory, int LAPHDBIKPDD = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2976330", Offset = "0x2974D30", VA = "0x182976330")]
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
		[Cpp2IlInjected.Address(RVA = "0x695A6E0", Offset = "0x69590E0", VA = "0x18695A6E0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x695A810", Offset = "0x6959210", VA = "0x18695A810")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x695A630", Offset = "0x6959030", VA = "0x18695A630")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x695A3C0", Offset = "0x6958DC0", VA = "0x18695A3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x695B0C0", Offset = "0x6959AC0", VA = "0x18695B0C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x695B1F0", Offset = "0x6959BF0", VA = "0x18695B1F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x695B010", Offset = "0x6959A10", VA = "0x18695B010")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x695ACD0", Offset = "0x69596D0", VA = "0x18695ACD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6955E00", Offset = "0x6954800", VA = "0x186955E00")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6955F30", Offset = "0x6954930", VA = "0x186955F30")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6955D50", Offset = "0x6954750", VA = "0x186955D50")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6955AD0", Offset = "0x69544D0", VA = "0x186955AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x696AD50", Offset = "0x6969750", VA = "0x18696AD50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x696AE80", Offset = "0x6969880", VA = "0x18696AE80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x696ACA0", Offset = "0x69696A0", VA = "0x18696ACA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x696AA60", Offset = "0x6969460", VA = "0x18696AA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x6957970", Offset = "0x6956370", VA = "0x186957970")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6957AA0", Offset = "0x69564A0", VA = "0x186957AA0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x69578C0", Offset = "0x69562C0", VA = "0x1869578C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6957680", Offset = "0x6956080", VA = "0x186957680")]
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
		[Cpp2IlInjected.Address(RVA = "0x6966460", Offset = "0x6964E60", VA = "0x186966460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6968630", Offset = "0x6967030", VA = "0x186968630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69685F0", Offset = "0x6966FF0", VA = "0x1869685F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCMJACOCFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69684C0", Offset = "0x6966EC0", VA = "0x1869684C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6966AE0", Offset = "0x69654E0", VA = "0x186966AE0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6965070", Offset = "0x6963A70", VA = "0x186965070")]
	public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool JEDHHDJJCLE, bool MCBCAPCHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x69689D0", Offset = "0x69673D0", VA = "0x1869689D0")]
	public void JBGLCJDAAKF(int NOLHGPALGBF, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6969A10", Offset = "0x6968410", VA = "0x186969A10", Slot = "6")]
	public bool PADBHOPLFNI(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6967A00", Offset = "0x6966400", VA = "0x186967A00")]
	public bool FOJFIIIODJJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6969A20", Offset = "0x6968420", VA = "0x186969A20")]
	public bool PBOGGAHOFPI(Mesh DICFBCCFLEI, NAJBPEBBKNG PPGDGCIOEJI, bool GDLAEOGBDLK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6968A50", Offset = "0x6967450", VA = "0x186968A50")]
	public void JDFIOJFBMJA(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6966BF0", Offset = "0x69655F0", VA = "0x186966BF0")]
	public void ELNINBFLLGC(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69685A0", Offset = "0x6966FA0", VA = "0x1869685A0")]
	[BurstCompile]
	public static int HIJOMKPBPFF(float IPBJLCONKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6968500", Offset = "0x6966F00", VA = "0x186968500")]
	[BurstCompile]
	public static uint HIJOMKPBPFF([In] float4 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6968550", Offset = "0x6966F50", VA = "0x186968550")]
	[BurstCompile]
	public static uint HIJOMKPBPFF([In] float3 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69664A0", Offset = "0x6964EA0", VA = "0x1869664A0")]
	public void DMMGPNHAEHF(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6968950", Offset = "0x6967350", VA = "0x186968950")]
	[BurstCompile]
	private unsafe static void ILNEAKLPIED([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69659D0", Offset = "0x69643D0", VA = "0x1869659D0")]
	public void CMECELCEBCJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6967DE0", Offset = "0x69667E0", VA = "0x186967DE0")]
	[BurstCompile]
	private unsafe static void GBFPEOJCPIL([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6969920", Offset = "0x6968320", VA = "0x186969920")]
	public void NCJNLCDOODA(Mesh DICFBCCFLEI, KNOOBMCACLL BGOCEECJDJL, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6969650", Offset = "0x6968050", VA = "0x186969650")]
	public void LBJDLPDBEDK(NAJBPEBBKNG DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69694A0", Offset = "0x6967EA0", VA = "0x1869694A0")]
	public NAJBPEBBKNG JGFBHDIGANM(Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6965840", Offset = "0x6964240", VA = "0x186965840")]
	public long CIIGGKDJOEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6965970", Offset = "0x6964370", VA = "0x186965970")]
	public static long CIIGGKDJOEF(int EMICHICJLGC, int DBIJKCBBANM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69656E0", Offset = "0x69640E0", VA = "0x1869656E0")]
	public static long BNBMCJOBFOE(int EMICHICJLGC, int DBIJKCBBANM, KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6965780", Offset = "0x6964180", VA = "0x186965780")]
	public long BNBMCJOBFOE(KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69698C0", Offset = "0x69682C0", VA = "0x1869698C0")]
	public void MBHMLCKHMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6967670", Offset = "0x6966070", VA = "0x186967670")]
	public static void FAFHBLFDKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6967E60", Offset = "0x6966860", VA = "0x186967E60")]
	public KNOOBMCACLL GIBCJJAIKFE()
	{
		return default(KNOOBMCACLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6965260", Offset = "0x6963C60", VA = "0x186965260")]
	public static (int, int) BCNMJDDPCAO(Mesh DICFBCCFLEI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6964F90", Offset = "0x6963990", VA = "0x186964F90")]
	public static int ACKMLIOFFCH(VertexAttributeDescriptor[] FPADDJONGOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69695E0", Offset = "0x6967FE0", VA = "0x1869695E0")]
	public static long KAAHBFPGHJC(Mesh DICFBCCFLEI, int CICOMOACNJA, int FPBOOOOIJIO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public NAJBPEBBKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69688B0", Offset = "0x69672B0", VA = "0x1869688B0")]
	[BurstCompile]
	public static int IJJMIPGGKLC(float IPBJLCONKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6968720", Offset = "0x6967120", VA = "0x186968720")]
	[BurstCompile]
	public static uint IJJMIPGGKLC([In] float4 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6968670", Offset = "0x6967070", VA = "0x186968670")]
	[BurstCompile]
	public static uint IJJMIPGGKLC([In] float3 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6965330", Offset = "0x6963D30", VA = "0x186965330")]
	[BurstCompile]
	public unsafe static void BGKBHBNEADP([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6966010", Offset = "0x6964A10", VA = "0x186966010")]
	[BurstCompile]
	public unsafe static void DCKOKKNEHCI([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class EGGCEOBDPNB
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6956090", Offset = "0x6954A90", VA = "0x186956090")]
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
		[Cpp2IlInjected.Address(RVA = "0x69567C0", Offset = "0x69551C0", VA = "0x1869567C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6956780", Offset = "0x6955180", VA = "0x186956780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NEJPEHKDHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6957080", Offset = "0x6955A80", VA = "0x186957080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69570C0", Offset = "0x6955AC0", VA = "0x1869570C0")]
	public EINJEOMMPLD(int NOLHGPALGBF, int HECJMBFPMPO, int LPCJBALPLCK, Allocator CHDJMCMMMLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6957390", Offset = "0x6955D90", VA = "0x186957390")]
	public EINJEOMMPLD(Mesh DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6956670", Offset = "0x6955070", VA = "0x186956670", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6956D80", Offset = "0x6955780", VA = "0x186956D80")]
	public void LBJDLPDBEDK(EINJEOMMPLD DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69561E0", Offset = "0x6954BE0", VA = "0x1869561E0")]
	private void DECMDFKHIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6956800", Offset = "0x6955200", VA = "0x186956800")]
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
	[Cpp2IlInjected.Address(RVA = "0x13F8D70", Offset = "0x13F7770", VA = "0x1813F8D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HDBOOPAJBBL>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98CB80", VA = "0x18098E180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EINJEOMMPLD HKBKABBDKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x696B0E0", Offset = "0x6969AE0", VA = "0x18696B0E0")]
	public PPDAGFFIHDK(IEnumerable<EINJEOMMPLD> KKMCNLCAHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x696B070", Offset = "0x6969A70", VA = "0x18696B070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x696A610", Offset = "0x6969010", VA = "0x18696A610")]
	public static void EOJEBCEEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x696A730", Offset = "0x6969130", VA = "0x18696A730")]
	public static NativeArray<float2> GLIPPCMJADN(NativeArray<float2> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float2> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x696A500", Offset = "0x6968F00", VA = "0x18696A500")]
	public static NativeArray<float3> EAFBIIAODMA(NativeArray<float3> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float3> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x696A950", Offset = "0x6969350", VA = "0x18696A950")]
	public static NativeArray<float4> PPEIFDNKACL(NativeArray<float4> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float4> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x696A840", Offset = "0x6969240", VA = "0x18696A840")]
	public static NativeArray<int> PELMBABBONG(NativeArray<int> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<int> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB74E0", Offset = "0x2CB5EE0", VA = "0x182CB74E0")]
	private static void HHLCAGAMPEG<T>(NativeArray<T> PFKJAOOHGBN, int GFJHPONFOPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7400", Offset = "0x2CB5E00", VA = "0x182CB7400")]
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
		[Cpp2IlInjected.Address(RVA = "0x696B020", Offset = "0x6969A20", VA = "0x18696B020")]
		public PGIJANBONFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x696AFE0", Offset = "0x69699E0", VA = "0x18696AFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8579C0", VA = "0x180858FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer PPPFMKBBPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859EC0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EAJPNEIOGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8BF200", Offset = "0x8BDC00", VA = "0x1808BF200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LNBNKGDDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC358A0", Offset = "0xC342A0", VA = "0x180C358A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x69603C0", Offset = "0x695EDC0", VA = "0x1869603C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<FDAECEGICND> JKBMFKNBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x695D540", Offset = "0x695BF40", VA = "0x18695D540")]
	public void ECNMCPAEMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x695BF30", Offset = "0x695A930", VA = "0x18695BF30")]
	private void CNNCLGPCFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6964CB0", Offset = "0x69636B0", VA = "0x186964CB0")]
	public NAFPBMLMEFB(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x695D550", Offset = "0x695BF50", VA = "0x18695D550")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6963A70", Offset = "0x6962470", VA = "0x186963A70")]
	public void NEBLIIAJNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x695D8B0", Offset = "0x695C2B0", VA = "0x18695D8B0")]
	private void GKCJFEGJHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x695F030", Offset = "0x695DA30", VA = "0x18695F030")]
	public void GNCDIBNJHAL(FDAECEGICND MJLBICKANIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6961590", Offset = "0x695FF90", VA = "0x186961590")]
	public bool KKMKMDPCGKN(FDAECEGICND MJLBICKANIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x695C370", Offset = "0x695AD70", VA = "0x18695C370")]
	public bool DJONJHALGBO(FDAECEGICND MJLBICKANIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6962B30", Offset = "0x6961530", VA = "0x186962B30", Slot = "4")]
	public virtual void LLJNEDJHFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6961630", Offset = "0x6960030", VA = "0x186961630")]
	public void KNBDEOEBCOJ(Transform BFOKBBAAOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x695D7C0", Offset = "0x695C1C0", VA = "0x18695D7C0")]
	private long GFCDOHMEJEJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6961410", Offset = "0x695FE10", VA = "0x186961410")]
	private long JODDIOJDAOH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69603E0", Offset = "0x695EDE0", VA = "0x1869603E0")]
	public bool JNFECMCCFMG(Transform BFOKBBAAOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x695DDB0", Offset = "0x695C7B0", VA = "0x18695DDB0")]
	public bool GLPNNAIGEEE(bool CJJLFBMNEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x695BBD0", Offset = "0x695A5D0", VA = "0x18695BBD0")]
	public void CMBNHNKAJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6961840", Offset = "0x6960240", VA = "0x186961840")]
	public bool LCAIOHNCMJC(float4x4 OBNNMAGIJBG, BatchedMeshRenderer CNCAAJKMDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x695DB40", Offset = "0x695C540", VA = "0x18695DB40")]
	public void GLJNPAMGAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6963B60", Offset = "0x6962560", VA = "0x186963B60")]
	public bool OJPDPHEEJEO(bool CJJLFBMNEBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x695D8A0", Offset = "0x695C2A0", VA = "0x18695D8A0")]
	public void GICIDKNNDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x695D670", Offset = "0x695C070", VA = "0x18695D670")]
	public void FBIPMGLGLFC(NAJBPEBBKNG DICFBCCFLEI, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x695B350", Offset = "0x6959D50", VA = "0x18695B350")]
	public void BJOEIGIFCHN(ONMMPCFPEBK AGJBEJFOBLC, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x695BB60", Offset = "0x695A560", VA = "0x18695BB60")]
	public (long, long, long) CIIGGKDJOEF()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9C0350", Offset = "0x9BED50", VA = "0x1809C0350")]
	public long FOLIADHNDMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6964710", Offset = "0x6963110", VA = "0x186964710")]
	private void PJGOPOLJENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x695F200", Offset = "0x695DC00", VA = "0x18695F200")]
	public (long, long) GOCOHFDIHDN(float IALCKDAINHG, float4x4 OBNNMAGIJBG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	public void FAMBOFJBLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x695D6A0", Offset = "0x695C0A0", VA = "0x18695D6A0")]
	internal void GDLABJGCJKC(EKOMMFJGBPJ BKOADNCOIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6962F90", Offset = "0x6961990", VA = "0x186962F90")]
	private (float, float, float) NAPBBHLKNDH(float ENIPBABACHE, float4x4 OBNNMAGIJBG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6962BE0", Offset = "0x69615E0", VA = "0x186962BE0")]
	private (int, int) MHGDCCHAHON(float KNBBDPHGJOH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x695C3D0", Offset = "0x695ADD0", VA = "0x18695C3D0")]
	public void DMIKCDADOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6963B30", Offset = "0x6962530", VA = "0x186963B30")]
	private void OFEOJOPMJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x695BD50", Offset = "0x695A750", VA = "0x18695BD50")]
	private void CMFIALHJLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x695B380", Offset = "0x6959D80", VA = "0x18695B380")]
	public long CCECPDBCAJM(long PNONPAELEBP, int HLCNBNDAHBI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6963E30", Offset = "0x6962830", VA = "0x186963E30")]
	private void OPLNGFMBMOD(NAJBPEBBKNG KFEHDFDFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x695F5D0", Offset = "0x695DFD0", VA = "0x18695F5D0")]
	private void HKOHOOBGFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x695F870", Offset = "0x695E270", VA = "0x18695F870")]
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
		[Cpp2IlInjected.Address(RVA = "0x6976340", Offset = "0x6974D40", VA = "0x186976340")]
		public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool MCBCAPCHDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69765E0", Offset = "0x6974FE0", VA = "0x1869765E0")]
		public static ONAFDFMEKCD EIGFFDAOBFL(NAJBPEBBKNG HKKDPGGNNBK)
		{
			return default(ONAFDFMEKCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6976520", Offset = "0x6974F20", VA = "0x186976520")]
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
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	[BurstDiscard]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	[BurstDiscard]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	[BurstDiscard]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6959C20", Offset = "0x6958620", VA = "0x186959C20")]
	public HOHIEFDPLPG([In] List<NAFPBMLMEFB.PGIJANBONFA> JGMNAPDLBMM, [In] NAJBPEBBKNG MJAAPFAPMAE, [In] NAFPBMLMEFB GKMJODLOHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6957CD0", Offset = "0x69566D0", VA = "0x186957CD0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6959400", Offset = "0x6957E00", VA = "0x186959400")]
	public void OCPNPPKMLAH(List<NAFPBMLMEFB.PGIJANBONFA> HKCBDFAMMFB, [In] NAFPBMLMEFB GKMJODLOHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69593E0", Offset = "0x6957DE0", VA = "0x1869593E0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool MEOIILHBCEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6957C00", Offset = "0x6956600", VA = "0x186957C00")]
	private ONMMPCFPEBK DOCENNGHCKO(int FGGLEFPMBBG, Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6957D20", Offset = "0x6956720", VA = "0x186957D20")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GPGMKOLDCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6959070", Offset = "0x6957A70", VA = "0x186959070")]
	[IgnoreWarning(1371)]
	private BBFBGGLFHEK KAMBONBNBHO([In] BBFBGGLFHEK DFBJHPELBPP, int CPNPIEACKDD, [In] NativeArray<int> NADKEDPNJIG, [In] NativeArray<bool> PECFPILAHFK, NativeArray<int> HDNGOOCDLGG)
	{
		return default(BBFBGGLFHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6959A80", Offset = "0x6958480", VA = "0x186959A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int NDLPILCJANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6972160", Offset = "0x6970B60", VA = "0x186972160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		private static void FFCICGEKPJO(bool BFOAIFCNHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x696EB30", Offset = "0x696D530", VA = "0x18696EB30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x696CFB0", Offset = "0x696B9B0", VA = "0x18696CFB0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x696CD80", Offset = "0x696B780", VA = "0x18696CD80")]
		public NAFPBMLMEFB AddToBatchedMesh(FDAECEGICND LJDGDHFLMGN, Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6971270", Offset = "0x696FC70", VA = "0x186971270")]
		public void RemoveFromBatchedMesh(FDAECEGICND DICFBCCFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x696CE80", Offset = "0x696B880", VA = "0x18696CE80")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6971A50", Offset = "0x6970450", VA = "0x186971A50")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Color KIJNHGNFMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6971610", Offset = "0x6970010", VA = "0x186971610")]
		public void SetMaterialProperty(int AOOLGPHJJIF, float JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6971830", Offset = "0x6970230", VA = "0x186971830")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Vector4 BAMLBBOKLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69713B0", Offset = "0x696FDB0", VA = "0x1869713B0")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Matrix4x4 FPPOIAGEIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x696DB60", Offset = "0x696C560", VA = "0x18696DB60")]
		private void JHKMIIOHJMG(Renderer GHBIMLIJLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x696D180", Offset = "0x696BB80", VA = "0x18696D180")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x696D170", Offset = "0x696BB70", VA = "0x18696D170")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x696C860", Offset = "0x696B260", VA = "0x18696C860")]
		private void AEJOEMJOBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x696E430", Offset = "0x696CE30", VA = "0x18696E430")]
		private NAFPBMLMEFB MFOEMNMIEEO(FDAECEGICND DICFBCCFLEI, Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x696E150", Offset = "0x696CB50", VA = "0x18696E150")]
		private NAFPBMLMEFB KIFKJKHJHCI(Material GIIKGEKINDH, int LLONNBOMNPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x696D760", Offset = "0x696C160", VA = "0x18696D760")]
		private NAFPBMLMEFB IILIKPJMHAA(Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18CAF40", Offset = "0x18C9940", VA = "0x1818CAF40")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x696E650", Offset = "0x696D050", VA = "0x18696E650")]
		public void MarkDirty(FDAECEGICND DICFBCCFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x696E7B0", Offset = "0x696D1B0", VA = "0x18696E7B0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float IALCKDAINHG)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6970300", Offset = "0x696ED00", VA = "0x186970300")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x696D220", Offset = "0x696BC20", VA = "0x18696D220")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x696EE20", Offset = "0x696D820", VA = "0x18696EE20")]
		public void RebatchOptimally(int LKEFJAFGKPE, int NEDKDECPMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6971EF0", Offset = "0x69708F0", VA = "0x186971EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x91FDB0", Offset = "0x91E7B0", VA = "0x18091FDB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x696C6F0", Offset = "0x696B0F0", VA = "0x18696C6F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA76790", Offset = "0xA75190", VA = "0x180A76790")]
		[DebuggerHidden]
		public BHKCFCIPBJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x696C740", Offset = "0x696B140", VA = "0x18696C740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x696B9A0", Offset = "0x696A3A0", VA = "0x18696B9A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x696B900", Offset = "0x696A300", VA = "0x18696B900")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x696B950", Offset = "0x696A350", VA = "0x18696B950")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x696C6A0", Offset = "0x696B0A0", VA = "0x18696C6A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x696C5F0", Offset = "0x696AFF0", VA = "0x18696C5F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x696C5F0", Offset = "0x696AFF0", VA = "0x18696C5F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6972A70", Offset = "0x6971470", VA = "0x186972A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6972B00", Offset = "0x6971500", VA = "0x186972B00")]
	public static void EEKIDKGBNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6972350", Offset = "0x6970D50", VA = "0x186972350")]
	public static void BOLIKDIKPKL(BatchedMeshRenderer LNEKBFHLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6975F20", Offset = "0x6974920", VA = "0x186975F20")]
	public static void PELMDNDPBGB(BatchedMeshRenderer LNEKBFHLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69721B0", Offset = "0x6970BB0", VA = "0x1869721B0")]
	private static (long, long, long) AKNEANIPLIJ(long GBENNCDCKJK)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x69730C0", Offset = "0x6971AC0", VA = "0x1869730C0")]
	public static void LCAIOHNCMJC(long GBENNCDCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69725C0", Offset = "0x6970FC0", VA = "0x1869725C0")]
	public static long CCECPDBCAJM(long PNONPAELEBP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6972960", Offset = "0x6971360", VA = "0x186972960")]
	public static void CPMLOBNGEEG(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6972FC0", Offset = "0x69719C0", VA = "0x186972FC0")]
	public static void JGPPPNBPIMI(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float OFPEDHFNFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x69757A0", Offset = "0x69741A0", VA = "0x1869757A0")]
	public static void MCPGGPLLLKC(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float OFPEDHFNFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69758B0", Offset = "0x69742B0", VA = "0x1869758B0")]
	public static void MLJJBMKJNEK(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6975BC0", Offset = "0x69745C0", VA = "0x186975BC0")]
	public static float OKFHKJGHMPG(long LBBCIOCCOIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6972CB0", Offset = "0x69716B0", VA = "0x186972CB0")]
	public static (long, long) GOCOHFDIHDN(float IALCKDAINHG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69722C0", Offset = "0x6970CC0", VA = "0x1869722C0")]
	[IteratorStateMachine(typeof(BHKCFCIPBJG))]
	public static IEnumerable<bool> BFMPDPMBNEF(long GLPBPGGDPLE, bool BDHMLIHIGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6975A50", Offset = "0x6974450", VA = "0x186975A50")]
	public static void OHFPIPPIHFM(long GLPBPGGDPLE, bool BDHMLIHIGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6972E80", Offset = "0x6971880", VA = "0x186972E80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BD9540", Offset = "0x3BD7F40", VA = "0x183BD9540")]
	public FHANHKALJDM(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BD91A0", Offset = "0x3BD7BA0", VA = "0x183BD91A0")]
	public void GNCDIBNJHAL(KeyType NDDCLPHCEEO, FDAECEGICND MJLBICKANIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9300", Offset = "0x3BD7D00", VA = "0x183BD9300")]
	public bool GOCJLOFAFIF(KeyType NDDCLPHCEEO, FDAECEGICND JHCHLEJPEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BD90D0", Offset = "0x3BD7AD0", VA = "0x183BD90D0")]
	public void DCFKEHMOEGL(KeyType NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BD93F0", Offset = "0x3BD7DF0", VA = "0x183BD93F0", Slot = "4")]
	public override void LLJNEDJHFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6976830", Offset = "0x6975230", VA = "0x186976830")]
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
