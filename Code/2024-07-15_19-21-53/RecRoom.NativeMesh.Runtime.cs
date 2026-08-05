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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694A340", Offset = "0x6948B40", VA = "0x18694A340", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDB7B40", Offset = "0xDB6340", VA = "0x180DB7B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDB71C0", Offset = "0xDB59C0", VA = "0x180DB71C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6F5B0", Offset = "0xA6DDB0", VA = "0x180A6F5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB65D0", Offset = "0xDB4DD0", VA = "0x180DB65D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6946300", Offset = "0x6944B00", VA = "0x186946300")]
	public HIMGIDMIPBN(int CKAMNHGFMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6944BF0", Offset = "0x69433F0", VA = "0x186944BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6945DC0", Offset = "0x69445C0", VA = "0x186945DC0")]
	public void EECPCLJADFI(JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69460E0", Offset = "0x69448E0", VA = "0x1869460E0")]
	public void NGBKMPGDDCO(EBIEIMGKHLJ LINJEFIAFHO, OALODHMDGLN HILLMJIKOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6945F90", Offset = "0x6944790", VA = "0x186945F90")]
	public void LDLOEJGPNMP(HGDOAMLPNBP LINJEFIAFHO, NativeArray<BEEODNIICBD> CMIJPDGNFOI, int BHPOFKEKDPM, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6944DB0", Offset = "0x69435B0", VA = "0x186944DB0")]
	public JobHandle EDGJAHCBCOE(NAJBPEBBKNG OPDABIFMIPI, LEFCAAKHOCL OCHMECPEPDN, float3 HMCDIKIEIPP, quaternion CBELOFBFGLG, float KCLKPLDJNJE, bool HJHHNOJHCHH, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69448B0", Offset = "0x69430B0", VA = "0x1869448B0")]
	public static JobHandle DKDCBGBAPGG(KGPNDFHLDEG CGOBGJGGBOO, NAJBPEBBKNG OPDABIFMIPI, EBIEIMGKHLJ LINJEFIAFHO, JobHandle BHOKFONKIGD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6944600", Offset = "0x6942E00", VA = "0x186944600")]
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
		[Cpp2IlInjected.Address(RVA = "0x694B8C0", Offset = "0x694A0C0", VA = "0x18694B8C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x694B9F0", Offset = "0x694A1F0", VA = "0x18694B9F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x694B810", Offset = "0x694A010", VA = "0x18694B810")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x694B600", Offset = "0x6949E00", VA = "0x18694B600")]
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
		[Cpp2IlInjected.Address(RVA = "0x693A960", Offset = "0x6939160", VA = "0x18693A960")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x693AA90", Offset = "0x6939290", VA = "0x18693AA90")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x693A8B0", Offset = "0x69390B0", VA = "0x18693A8B0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x693A620", Offset = "0x6938E20", VA = "0x18693A620")]
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
		[Cpp2IlInjected.Address(RVA = "0x6949D90", Offset = "0x6948590", VA = "0x186949D90")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6949EC0", Offset = "0x69486C0", VA = "0x186949EC0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6949CE0", Offset = "0x69484E0", VA = "0x186949CE0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6949A50", Offset = "0x6948250", VA = "0x186949A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6938C50", Offset = "0x6937450", VA = "0x186938C50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6938D80", Offset = "0x6937580", VA = "0x186938D80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6938BA0", Offset = "0x69373A0", VA = "0x186938BA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6938910", Offset = "0x6937110", VA = "0x186938910")]
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
		[Cpp2IlInjected.Address(RVA = "0x693DCD0", Offset = "0x693C4D0", VA = "0x18693DCD0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x693DE00", Offset = "0x693C600", VA = "0x18693DE00")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x693DC20", Offset = "0x693C420", VA = "0x18693DC20")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x693DA00", Offset = "0x693C200", VA = "0x18693DA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x69418F0", Offset = "0x69400F0", VA = "0x1869418F0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6941A20", Offset = "0x6940220", VA = "0x186941A20")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6941840", Offset = "0x6940040", VA = "0x186941840")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6941650", Offset = "0x693FE50", VA = "0x186941650")]
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
		[Cpp2IlInjected.Address(RVA = "0x6947FD0", Offset = "0x69467D0", VA = "0x186947FD0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6948100", Offset = "0x6946900", VA = "0x186948100")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6947F20", Offset = "0x6946720", VA = "0x186947F20")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6947CD0", Offset = "0x69464D0", VA = "0x186947CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69478B0", Offset = "0x69460B0", VA = "0x1869478B0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69479E0", Offset = "0x69461E0", VA = "0x1869479E0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6947800", Offset = "0x6946000", VA = "0x186947800")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6947610", Offset = "0x6945E10", VA = "0x186947610")]
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
		[Cpp2IlInjected.Address(RVA = "0x69546C0", Offset = "0x6952EC0", VA = "0x1869546C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69547F0", Offset = "0x6952FF0", VA = "0x1869547F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6954610", Offset = "0x6952E10", VA = "0x186954610")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6954350", Offset = "0x6952B50", VA = "0x186954350")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943770", Offset = "0x6941F70", VA = "0x186943770")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69438A0", Offset = "0x69420A0", VA = "0x1869438A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69436C0", Offset = "0x6941EC0", VA = "0x1869436C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6943410", Offset = "0x6941C10", VA = "0x186943410")]
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
		[Cpp2IlInjected.Address(RVA = "0x6941E50", Offset = "0x6940650", VA = "0x186941E50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6941F80", Offset = "0x6940780", VA = "0x186941F80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6941DA0", Offset = "0x69405A0", VA = "0x186941DA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6941B80", Offset = "0x6940380", VA = "0x186941B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x693B780", Offset = "0x6939F80", VA = "0x18693B780")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x693B8B0", Offset = "0x693A0B0", VA = "0x18693B8B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x693B6D0", Offset = "0x6939ED0", VA = "0x18693B6D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x693B490", Offset = "0x6939C90", VA = "0x18693B490")]
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
		[Cpp2IlInjected.Address(RVA = "0x693BD50", Offset = "0x693A550", VA = "0x18693BD50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x693BE80", Offset = "0x693A680", VA = "0x18693BE80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x693BCA0", Offset = "0x693A4A0", VA = "0x18693BCA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x693BA10", Offset = "0x693A210", VA = "0x18693BA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x694A810", Offset = "0x6949010", VA = "0x18694A810")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x694A940", Offset = "0x6949140", VA = "0x18694A940")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x694A760", Offset = "0x6948F60", VA = "0x18694A760")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x694A490", Offset = "0x6948C90", VA = "0x18694A490")]
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
		[Cpp2IlInjected.Address(RVA = "0x694B370", Offset = "0x6949B70", VA = "0x18694B370")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x694B4A0", Offset = "0x6949CA0", VA = "0x18694B4A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x694B2C0", Offset = "0x6949AC0", VA = "0x18694B2C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x694AFF0", Offset = "0x69497F0", VA = "0x18694AFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69413C0", Offset = "0x693FBC0", VA = "0x1869413C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69414F0", Offset = "0x693FCF0", VA = "0x1869414F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6941310", Offset = "0x693FB10", VA = "0x186941310")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6940F60", Offset = "0x693F760", VA = "0x186940F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x693A190", Offset = "0x6938990", VA = "0x18693A190")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x693A2C0", Offset = "0x6938AC0", VA = "0x18693A2C0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x693A0E0", Offset = "0x69388E0", VA = "0x18693A0E0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6939E90", Offset = "0x6938690", VA = "0x186939E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x694AD60", Offset = "0x6949560", VA = "0x18694AD60")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x694AE90", Offset = "0x6949690", VA = "0x18694AE90")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x694ACB0", Offset = "0x69494B0", VA = "0x18694ACB0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x694AAA0", Offset = "0x69492A0", VA = "0x18694AAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6942600", Offset = "0x6940E00", VA = "0x186942600")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6942730", Offset = "0x6940F30", VA = "0x186942730")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6942550", Offset = "0x6940D50", VA = "0x186942550")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6942300", Offset = "0x6940B00", VA = "0x186942300")]
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
		[Cpp2IlInjected.Address(RVA = "0x6944370", Offset = "0x6942B70", VA = "0x186944370")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69444A0", Offset = "0x6942CA0", VA = "0x1869444A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x69442C0", Offset = "0x6942AC0", VA = "0x1869442C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69440D0", Offset = "0x69428D0", VA = "0x1869440D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6940810", Offset = "0x693F010", VA = "0x186940810")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6940940", Offset = "0x693F140", VA = "0x186940940")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6940760", Offset = "0x693EF60", VA = "0x186940760")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69404A0", Offset = "0x693ECA0", VA = "0x1869404A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6938680", Offset = "0x6936E80", VA = "0x186938680")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69387B0", Offset = "0x6936FB0", VA = "0x1869387B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69385D0", Offset = "0x6936DD0", VA = "0x1869385D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6938320", Offset = "0x6936B20", VA = "0x186938320")]
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
		[Cpp2IlInjected.Address(RVA = "0x69540C0", Offset = "0x69528C0", VA = "0x1869540C0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x69541F0", Offset = "0x69529F0", VA = "0x1869541F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6954010", Offset = "0x6952810", VA = "0x186954010")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6953D90", Offset = "0x6952590", VA = "0x186953D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943180", Offset = "0x6941980", VA = "0x186943180")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69432B0", Offset = "0x6941AB0", VA = "0x1869432B0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x69430D0", Offset = "0x69418D0", VA = "0x1869430D0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6942EB0", Offset = "0x69416B0", VA = "0x186942EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6942C20", Offset = "0x6941420", VA = "0x186942C20")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6942D50", Offset = "0x6941550", VA = "0x186942D50")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6942B70", Offset = "0x6941370", VA = "0x186942B70")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6942890", Offset = "0x6941090", VA = "0x186942890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943E40", Offset = "0x6942640", VA = "0x186943E40")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6943F70", Offset = "0x6942770", VA = "0x186943F70")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6943D90", Offset = "0x6942590", VA = "0x186943D90")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6943A00", Offset = "0x6942200", VA = "0x186943A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939A00", Offset = "0x6938200", VA = "0x186939A00")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6939B30", Offset = "0x6938330", VA = "0x186939B30")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6939950", Offset = "0x6938150", VA = "0x186939950")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x69395B0", Offset = "0x6937DB0", VA = "0x1869395B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939320", Offset = "0x6937B20", VA = "0x186939320")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6939450", Offset = "0x6937C50", VA = "0x186939450")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6939270", Offset = "0x6937A70", VA = "0x186939270")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6938EE0", Offset = "0x69376E0", VA = "0x186938EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6946840", Offset = "0x6945040", VA = "0x186946840")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6946970", Offset = "0x6945170", VA = "0x186946970")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6946790", Offset = "0x6944F90", VA = "0x186946790")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6946510", Offset = "0x6944D10", VA = "0x186946510")]
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
		[Cpp2IlInjected.Address(RVA = "0x694CDD0", Offset = "0x694B5D0", VA = "0x18694CDD0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x694CF00", Offset = "0x694B700", VA = "0x18694CF00")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x694CD20", Offset = "0x694B520", VA = "0x18694CD20")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x694CAE0", Offset = "0x694B2E0", VA = "0x18694CAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6953B00", Offset = "0x6952300", VA = "0x186953B00")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6953C30", Offset = "0x6952430", VA = "0x186953C30")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6953A50", Offset = "0x6952250", VA = "0x186953A50")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6953810", Offset = "0x6952010", VA = "0x186953810")]
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
		[Cpp2IlInjected.Address(RVA = "0x693B200", Offset = "0x6939A00", VA = "0x18693B200")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x693B330", Offset = "0x6939B30", VA = "0x18693B330")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x693B150", Offset = "0x6939950", VA = "0x18693B150")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x693ADF0", Offset = "0x69395F0", VA = "0x18693ADF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694C850", Offset = "0x694B050", VA = "0x18694C850")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x694C980", Offset = "0x694B180", VA = "0x18694C980")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x694C7A0", Offset = "0x694AFA0", VA = "0x18694C7A0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x694C5D0", Offset = "0x694ADD0", VA = "0x18694C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69506F0", Offset = "0x694EEF0", VA = "0x1869506F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x694FC50", Offset = "0x694E450", VA = "0x18694FC50")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69511C0", Offset = "0x694F9C0", VA = "0x1869511C0")]
	public static ONMMPCFPEBK JGIIBNEOBDO(Allocator CHDJMCMMMLJ, NAJBPEBBKNG IMCJMBEIOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69513A0", Offset = "0x694FBA0", VA = "0x1869513A0")]
	public static ONMMPCFPEBK JGIIBNEOBDO(Allocator CHDJMCMMMLJ, NativeArray<float3> PACCJLNOCPC, NativeArray<float3> DFCLFIHOBEI, NativeArray<float2> INOODCJHGLL, NativeArray<float4> EOIJCDLBGFH, bool FKBFBHJPNMF, NativeArray<float4> KEGJFGMIBPP, NativeArray<int> MLLIMDHIAHO, int BHPOFKEKDPM, int ICLHALGKOLH, int HOLGDCGDMAL, int CLFPMMMOANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x694DFE0", Offset = "0x694C7E0", VA = "0x18694DFE0")]
	public NAJBPEBBKNG CJEPCENKMKG(Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6950140", Offset = "0x694E940", VA = "0x186950140")]
	public void FOJFIIIODJJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6950490", Offset = "0x694EC90", VA = "0x186950490")]
	private void HCHNJJBGJNP(Mesh DICFBCCFLEI, NativeArray<ushort> FDPKMBMHLAP, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6950C40", Offset = "0x694F440", VA = "0x186950C40")]
	public void JDFIOJFBMJA(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x694F490", Offset = "0x694DC90", VA = "0x18694F490")]
	public void DMMGPNHAEHF(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x694EAF0", Offset = "0x694D2F0", VA = "0x18694EAF0")]
	public void CMECELCEBCJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6952CF0", Offset = "0x69514F0", VA = "0x186952CF0")]
	public void NCJNLCDOODA(Mesh DICFBCCFLEI, NAJBPEBBKNG.KNOOBMCACLL BGOCEECJDJL, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x694DEB0", Offset = "0x694C6B0", VA = "0x18694DEB0")]
	public long CIIGGKDJOEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x694D500", Offset = "0x694BD00", VA = "0x18694D500")]
	public long BNBMCJOBFOE(NAJBPEBBKNG.KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x694D060", Offset = "0x694B860", VA = "0x18694D060")]
	private void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool MCBCAPCHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6951EF0", Offset = "0x69506F0", VA = "0x186951EF0")]
	private void KHDMNGHNIII(NativeArray<float3> EIKCCLGECIE, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6951E70", Offset = "0x6950670", VA = "0x186951E70")]
	[BurstCompile]
	private unsafe static void KHDMNGHNIII([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69530F0", Offset = "0x69518F0", VA = "0x1869530F0")]
	[BurstCompile]
	private unsafe static void OBDMIONIBLO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69520B0", Offset = "0x69508B0", VA = "0x1869520B0")]
	[BurstCompile]
	private unsafe static void LKOMJJBIANK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6953070", Offset = "0x6951870", VA = "0x186953070")]
	[BurstCompile]
	private unsafe static void NOEILGONJAB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69507C0", Offset = "0x694EFC0", VA = "0x1869507C0")]
	private void HHDAINNHBKF(NativeArray<float3> PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6950730", Offset = "0x694EF30", VA = "0x186950730")]
	[BurstCompile]
	private unsafe static void HHDAINNHBKF([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6952350", Offset = "0x6950B50", VA = "0x186952350")]
	private void LLPMNHHGONH(NativeArray<float3> DFCLFIHOBEI, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6952130", Offset = "0x6950930", VA = "0x186952130")]
	[BurstCompile]
	private unsafe static void LLPMNHHGONH([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6950A00", Offset = "0x694F200", VA = "0x186950A00")]
	private void IBEFEMHIKAN(NativeArray<float3> FFCNMPCEIFC, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6950AD0", Offset = "0x694F2D0", VA = "0x186950AD0")]
	[BurstCompile]
	private unsafe static void IBEFEMHIKAN([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6952920", Offset = "0x6951120", VA = "0x186952920")]
	[BurstCompile]
	private unsafe static void MNJFLBBPMMG([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6952B40", Offset = "0x6951340", VA = "0x186952B40")]
	[BurstCompile]
	private unsafe static void MOKOHHJLAKP([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6950240", Offset = "0x694EA40", VA = "0x186950240")]
	[BurstCompile]
	private unsafe static void GCMJLHGOKBH([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6953310", Offset = "0x6951B10", VA = "0x186953310")]
	private void PFHOGCIKNMG(NativeArray<float2> INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69533E0", Offset = "0x6951BE0", VA = "0x1869533E0")]
	[BurstCompile]
	private unsafe static void PFHOGCIKNMG([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6953290", Offset = "0x6951A90", VA = "0x186953290")]
	[BurstCompile]
	private static void OPLKEBLOIAL([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x694F150", Offset = "0x694D950", VA = "0x18694F150")]
	private void DEENGLOFEJO(NativeArray<float2> JHIJPONAINF, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x694F0D0", Offset = "0x694D8D0", VA = "0x18694F0D0")]
	[BurstCompile]
	private unsafe static void DEENGLOFEJO([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x694FDF0", Offset = "0x694E5F0", VA = "0x18694FDF0")]
	[BurstCompile]
	private unsafe static void FCDFBHJJICG([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6950B40", Offset = "0x694F340", VA = "0x186950B40")]
	[BurstCompile]
	private unsafe static void IHLGBNCGGED([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6950BC0", Offset = "0x694F3C0", VA = "0x186950BC0")]
	[BurstCompile]
	private unsafe static void IOOFODNBEBF([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6952410", Offset = "0x6950C10", VA = "0x186952410")]
	private void LOAPMMDGJCO(NativeArray<float4> KEGJFGMIBPP, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6952500", Offset = "0x6950D00", VA = "0x186952500")]
	[BurstCompile]
	private unsafe static void LOAPMMDGJCO([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x694D1F0", Offset = "0x694B9F0", VA = "0x18694D1F0")]
	[BurstCompile]
	private static ushort BEEPKFDIOKE([In] float4 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x694E630", Offset = "0x694CE30", VA = "0x18694E630")]
	private void CKDMEBGIKLF(NativeArray<float4> CBDMHNPJPJL, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x694E5C0", Offset = "0x694CDC0", VA = "0x18694E5C0")]
	[BurstCompile]
	private unsafe static void CKDMEBGIKLF([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6952E50", Offset = "0x6951650", VA = "0x186952E50")]
	[BurstCompile]
	private unsafe static void NKNPOALKOOP([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69518F0", Offset = "0x69500F0", VA = "0x1869518F0")]
	[BurstCompile]
	private unsafe static void JJEDFPGAEPM([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x694D7C0", Offset = "0x694BFC0", VA = "0x18694D7C0")]
	[BurstCompile]
	private unsafe static void CEMPAIHBOJL([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69528C0", Offset = "0x69510C0", VA = "0x1869528C0")]
	[BurstCompile]
	private static void MLFGCOMNPCK([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x694D830", Offset = "0x694C030", VA = "0x18694D830")]
	private void CGBIINEGBJO(Allocator CHDJMCMMMLJ, NativeArray<float4> EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x694DC10", Offset = "0x694C410", VA = "0x18694DC10")]
	[BurstCompile]
	private unsafe static void CGBIINEGBJO([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x694D5F0", Offset = "0x694BDF0", VA = "0x18694D5F0")]
	private static void CBADDDMNEJF(NativeArray<float4> BPPKHLDPGPI, NativeArray<NIOMDIPAKGG> DPJDJKECOOD, NativeArray<byte> MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x694D570", Offset = "0x694BD70", VA = "0x18694D570")]
	[BurstCompile]
	private unsafe static void CBADDDMNEJF([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6953210", Offset = "0x6951A10", VA = "0x186953210")]
	[BurstCompile]
	private unsafe static void OLANFNCIEBJ([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69527A0", Offset = "0x6950FA0", VA = "0x1869527A0")]
	[BurstCompile]
	private unsafe static void MGHPOLAAOAB([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6950050", Offset = "0x694E850", VA = "0x186950050")]
	[BurstCompile]
	private unsafe static void FLHLKHHPDPG([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6951960", Offset = "0x6950160", VA = "0x186951960")]
	private void JKMJGLIKINI(Allocator CHDJMCMMMLJ, NativeArray<int> MLLIMDHIAHO, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x694E770", Offset = "0x694CF70", VA = "0x18694E770")]
	private static NativeArray<byte> CKDNFIPDKPM(Allocator CHDJMCMMMLJ, NativeArray<int> MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x694E700", Offset = "0x694CF00", VA = "0x18694E700")]
	[BurstCompile]
	private unsafe static int CKDNFIPDKPM([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6952C20", Offset = "0x6951420", VA = "0x186952C20")]
	private static void NCABMFCBGFM(NativeArray<int> JGNGHKAEEMO, NativeArray<byte> FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6952BB0", Offset = "0x69513B0", VA = "0x186952BB0")]
	[BurstCompile]
	private unsafe static void NCABMFCBGFM([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69500D0", Offset = "0x694E8D0", VA = "0x1869500D0")]
	[BurstCompile]
	private unsafe static void FOELNMCPCFM([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x694D190", Offset = "0x694B990", VA = "0x18694D190")]
	[BurstCompile]
	private static void ANEBOGOMLPE([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6951C60", Offset = "0x6950460", VA = "0x186951C60")]
	[BurstCompile]
	private static ushort KFHHCFDHBIH([In] float3 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public ONMMPCFPEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6936D80", Offset = "0x6935580", VA = "0x186936D80")]
	[BurstCompile]
	public unsafe static void HPEDGPPGAPP([NoAlias] float3* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x694D700", Offset = "0x694BF00", VA = "0x18694D700")]
	[BurstCompile]
	public unsafe static void CEGEHIGGCCC([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6951FF0", Offset = "0x69507F0", VA = "0x186951FF0")]
	[BurstCompile]
	public unsafe static void KJFEGEJBLLK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x694F250", Offset = "0x694DA50", VA = "0x18694F250")]
	[BurstCompile]
	public unsafe static void DGGHLJPGKHB([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* PACCJLNOCPC, int BHPOFKEKDPM, [In] float3 JJOEFPFCIFE, [In] float3 CKODDPOINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69377A0", Offset = "0x6935FA0", VA = "0x1869377A0")]
	[BurstCompile]
	public unsafe static void JEHHCLMCBKF([NoAlias] ushort* EIKCCLGECIE, [Out] float3 KGEIKGAOIIE, [Out] float3 CKODDPOINAM, [In][NoAlias] float3* PACCJLNOCPC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6937280", Offset = "0x6935A80", VA = "0x186937280")]
	[BurstCompile]
	public unsafe static void IKKIDIMOAOA([NoAlias] ushort* MLIKJPIFHBG, [In][NoAlias] float3* DFCLFIHOBEI, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x694FD50", Offset = "0x694E550", VA = "0x18694FD50")]
	[BurstCompile]
	public unsafe static void FAEKCKBHMBD([NoAlias] float3* FFCNMPCEIFC, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6936980", Offset = "0x6935180", VA = "0x186936980")]
	[BurstCompile]
	public unsafe static void EPODGLMPDOI([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6951A40", Offset = "0x6950240", VA = "0x186951A40")]
	[BurstCompile]
	public unsafe static void JMKHKPEGIEK([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x694D240", Offset = "0x694BA40", VA = "0x18694D240")]
	[BurstCompile]
	public unsafe static void BKEKIOLOFPC([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* DFCLFIHOBEI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69374E0", Offset = "0x6935CE0", VA = "0x1869374E0")]
	[BurstCompile]
	public unsafe static void INIENDBIDHL([NoAlias] ushort* JHIJPONAINF, [Out] float2 PHNAFFAFCAA, [Out] float2 LKLDNMFNIIN, [In][NoAlias] float2* INOODCJHGLL, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x694DE60", Offset = "0x694C660", VA = "0x18694DE60")]
	[BurstCompile]
	public static void CHJOBCJFCEH([Out] float2 FHFOMFJIMNO, ushort ABJHDDOMEPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x694F310", Offset = "0x694DB10", VA = "0x18694F310")]
	[BurstCompile]
	public unsafe static void DJDEPODMKOL([NoAlias] float2* JHIJPONAINF, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x694D410", Offset = "0x694BC10", VA = "0x18694D410")]
	[BurstCompile]
	public unsafe static void BLLMBFHHJLH([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6951B60", Offset = "0x6950360", VA = "0x186951B60")]
	[BurstCompile]
	public unsafe static void JNJGGONAIEE([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x694FA70", Offset = "0x694E270", VA = "0x18694FA70")]
	[BurstCompile]
	public unsafe static void ECDDIMHEJKP([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [NoAlias] ushort* INOODCJHGLL, int BHPOFKEKDPM, [In] float2 PCBAEAHGOJE, [In] float2 LKLDNMFNIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6952820", Offset = "0x6951020", VA = "0x186952820")]
	[BurstCompile]
	public unsafe static void MHBCEHNKKCC([NoAlias] ushort* CBDMHNPJPJL, [In][NoAlias] float4* OLPMHCODJMC, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6951890", Offset = "0x6950090", VA = "0x186951890")]
	[BurstCompile]
	public static ushort JHFHFNFCKPD([In] float4 ECJOGJBBOLH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6953170", Offset = "0x6951970", VA = "0x186953170")]
	[BurstCompile]
	public unsafe static void OGOHBPOGDKG([NoAlias] float4* CBDMHNPJPJL, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6936FD0", Offset = "0x69357D0", VA = "0x186936FD0")]
	[BurstCompile]
	public unsafe static void IEFEPGFNIKL([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6952580", Offset = "0x6950D80", VA = "0x186952580")]
	[BurstCompile]
	public unsafe static void MDCDNBMKKEO([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x694E9E0", Offset = "0x694D1E0", VA = "0x18694E9E0")]
	[BurstCompile]
	public unsafe static void CMDPEGMNMEC([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] ushort* KEGJFGMIBPP, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x694D350", Offset = "0x694BB50", VA = "0x18694D350")]
	[BurstCompile]
	public static void BKMLPBOLKBA([Out] float4 ADPMAHMCGNH, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6936BC0", Offset = "0x69353C0", VA = "0x186936BC0")]
	[BurstCompile]
	public unsafe static void FCPKGDCFHIO([NoAlias] float4* PMIMGANKHKM, [NoAlias] byte* EKMDKKEJKFH, [Out] int KJKCLLAFGEH, [Out] int CBLGEBBHEKA, [NoAlias] float4* EOIJCDLBGFH, int CLFPMMMOANL, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69505B0", Offset = "0x694EDB0", VA = "0x1869505B0")]
	[BurstCompile]
	public unsafe static void HFOBLINEJNM([NoAlias] float4* BPPKHLDPGPI, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x694FE70", Offset = "0x694E670", VA = "0x18694FE70")]
	[BurstCompile]
	public unsafe static void FLFMOMDLOHO([NoAlias] NAJBPEBBKNG.MCOECEHNKNF* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69502B0", Offset = "0x694EAB0", VA = "0x1869502B0")]
	[BurstCompile]
	public unsafe static void GHCHOBBBMAL([NoAlias] NAJBPEBBKNG.BJGADGCOPIL* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6953630", Offset = "0x6951E30", VA = "0x186953630")]
	[BurstCompile]
	public unsafe static void PJOMKMAHDIM([NoAlias] NAJBPEBBKNG.AGOPAGAENOE* EIKCCLGECIE, [In][NoAlias] NIOMDIPAKGG* DPJDJKECOOD, [In][NoAlias] byte* MCCAJCLKBJI, int BHPOFKEKDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69526A0", Offset = "0x6950EA0", VA = "0x1869526A0")]
	[BurstCompile]
	public unsafe static int MFFIDOGCALE([NoAlias] byte* LDBCFFHFJBP, [In][NoAlias] int* MLLIMDHIAHO, int KOJGKDKKLLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x694F3F0", Offset = "0x694DBF0", VA = "0x18694F3F0")]
	[BurstCompile]
	public unsafe static void DLPELCNGBHC([NoAlias] int* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x694DF40", Offset = "0x694C740", VA = "0x18694DF40")]
	[BurstCompile]
	public unsafe static void CIPHDGIIPIN([NoAlias] ushort* JGNGHKAEEMO, [In][NoAlias] byte* FONFLKMPECF, int HOLGDCGDMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69508C0", Offset = "0x694F0C0", VA = "0x1869508C0")]
	[BurstCompile]
	public static void HIBOALAABLL([Out] float3 FHFOMFJIMNO, ushort ABJHDDOMEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6937B80", Offset = "0x6936380", VA = "0x186937B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851080", VA = "0x180852880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x693C120", Offset = "0x693A920", VA = "0x18693C120")]
	public CJKDABCKDLF(int NOLHGPALGBF, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x693BFE0", Offset = "0x693A7E0", VA = "0x18693BFE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x693C040", Offset = "0x693A840", VA = "0x18693C040")]
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
		[Cpp2IlInjected.Address(RVA = "0x693C2D0", Offset = "0x693AAD0", VA = "0x18693C2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<HDBOOPAJBBL> IHALGGEFJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x693C370", Offset = "0x693AB70", VA = "0x18693C370")]
		get
		{
			return default(NativeList<HDBOOPAJBBL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CJKDABCKDLF JBCAHILOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x693CC30", Offset = "0x693B430", VA = "0x18693CC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x693CCD0", Offset = "0x693B4D0", VA = "0x18693CCD0")]
	private static void HNHKHPLKGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x693D850", Offset = "0x693C050", VA = "0x18693D850")]
	public static int NPBDCEDPEDN(bool GMOOOENEPCC, int FBHJLEPEJCC, bool GOLOLCFOBLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x693C350", Offset = "0x693AB50", VA = "0x18693C350")]
	private static int DAKAAFNKEFD(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x693D880", Offset = "0x693C080", VA = "0x18693D880")]
	private static int PEDJEMKCBDN(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x693D5D0", Offset = "0x693BDD0", VA = "0x18693D5D0")]
	public static int KCBEJALBBAP(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x693C450", Offset = "0x693AC50", VA = "0x18693C450")]
	public static int EFLMNMDKKMD(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x693D320", Offset = "0x693BB20", VA = "0x18693D320")]
	public static int HOBFEDCLLGK(int PEAMNBBBMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x693D330", Offset = "0x693BB30", VA = "0x18693D330")]
	private static int ILMGCAALFDA(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x693C410", Offset = "0x693AC10", VA = "0x18693C410")]
	private static int DKALFPDPDNB(int FBHJLEPEJCC, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x693D7E0", Offset = "0x693BFE0", VA = "0x18693D7E0")]
	public static int NKKELEELGAB(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x693D750", Offset = "0x693BF50", VA = "0x18693D750")]
	public static int NKAFBGPJMEC(int JMKELNHPPCF, int FBHJLEPEJCC, int PEAMNBBBMBJ, bool HCAIAIEKILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x693C430", Offset = "0x693AC30", VA = "0x18693C430")]
	public static int EAMPOPBCKNO(int PEAMNBBBMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x693D660", Offset = "0x693BE60", VA = "0x18693D660")]
	public static CJKDABCKDLF NGIIKJDAEMK(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x693D340", Offset = "0x693BB40", VA = "0x18693D340")]
	private static CJKDABCKDLF IOKENIHIOBP(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x693C1E0", Offset = "0x693A9E0", VA = "0x18693C1E0")]
	public static CJKDABCKDLF AHOFHNNBNDG(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x693C8F0", Offset = "0x693B0F0", VA = "0x18693C8F0")]
	private static CJKDABCKDLF GEIANPINPPF(int FBHJLEPEJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x693C4E0", Offset = "0x693ACE0", VA = "0x18693C4E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69421D0", Offset = "0x69409D0", VA = "0x1869421D0")]
	public GEAABJGODDH(NativeArray<BEEODNIICBD> NMAAOPGFHCD, int ECGAAJFODGN = 1, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69420E0", Offset = "0x69408E0", VA = "0x1869420E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x693FEE0", Offset = "0x693E6E0", VA = "0x18693FEE0")]
	public DIKKDOGKKME(HIMGIDMIPBN JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6940170", Offset = "0x693E970", VA = "0x186940170")]
	public DIKKDOGKKME(GEAABJGODDH JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float3 GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x693EA90", Offset = "0x693D290", VA = "0x18693EA90")]
	private float3 DBBOPDDAFKM(float3 KMIECBFKDNO, Matrix4x4 NGKIDPFLBJB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x693DF60", Offset = "0x693C760", VA = "0x18693DF60")]
	private float3x3 BNLDFFKIOBH(float3x3 EICDHCELANI, float3x3 HLBAEJFFCFF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x693FED0", Offset = "0x693E6D0", VA = "0x18693FED0")]
	private float MEIMMLKDHEB(float CDPPGBMBKAI, float EJMIDHCGIBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x693EBC0", Offset = "0x693D3C0", VA = "0x18693EBC0", Slot = "4")]
	public void Execute(int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x693FD60", Offset = "0x693E560", VA = "0x18693FD60")]
	private void GHAIPBICKFC(int ADICGEAPMKC, float3 HGDCPNGLIKJ, float3 NFFLDAHKGKD, float3 AKIMOBCHKEL, float EOGPEOAFBNO, bool FOLLGGKILFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x693DFE0", Offset = "0x693C7E0", VA = "0x18693DFE0")]
	private void CEIODGGNBPK(HGDOAMLPNBP MBNEEJMJPMJ, float3 BCPGICOCGEJ, float3x3 OBKMAHDAHKH, float CDPPGBMBKAI, int GJGIBLAFHHL, int FKCGALHHLKD, int JLPNAEGILAG, float AICJBILPPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x693E440", Offset = "0x693CC40", VA = "0x18693E440")]
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
	[Cpp2IlInjected.Address(RVA = "0x6947BE0", Offset = "0x69463E0", VA = "0x186947BE0")]
	public KGPNDFHLDEG(int ECGAAJFODGN, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6947B40", Offset = "0x6946340", VA = "0x186947B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6949860", Offset = "0x6948060", VA = "0x186949860")]
	public KLEGDAKJIOG(HIMGIDMIPBN JKHAPPHEDEL, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6949670", Offset = "0x6947E70", VA = "0x186949670")]
	public KLEGDAKJIOG(KGPNDFHLDEG LINJEFIAFHO, NAJBPEBBKNG DOENDANGNCL, float3 BIBGKEGNDEF, quaternion AEIMPBAHMDM, float3 GDPHBENDFFE, int OOBFMNLJHPG = 0, int MGIIKHOMNLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6948680", Offset = "0x6946E80", VA = "0x186948680", Slot = "4")]
	public void Execute(int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69482D0", Offset = "0x6946AD0", VA = "0x1869482D0")]
	private void BBLDOADIKME(float4x4 CEKCEFDOFME, int AFLJKADDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6948260", Offset = "0x6946A60", VA = "0x186948260")]
	private IFLHLIHNOHO AHECGCOAHHL(float3 NFFLDAHKGKD)
	{
		return default(IFLHLIHNOHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6949620", Offset = "0x6947E20", VA = "0x186949620")]
	private float4 MBBIAMEAMNN(IFLHLIHNOHO ELMGLGBPLLE, int DHNLEFJCEAH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x69495E0", Offset = "0x6947DE0", VA = "0x1869495E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694BB50", Offset = "0x694A350", VA = "0x18694BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 KNFHACNBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x694C0F0", Offset = "0x694A8F0", VA = "0x18694C0F0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x694C4E0", Offset = "0x694ACE0", VA = "0x18694C4E0")]
	public OALODHMDGLN(float3 HGDCPNGLIKJ, quaternion LCDJINCAHMD, float3 ECGAAJFODGN, CHMPEFEAHOC NCMHJNKFAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x694BEF0", Offset = "0x694A6F0", VA = "0x18694BEF0")]
	public float FMLHFOHCPBE(float3 BCPGICOCGEJ, float EEBNCGOCFGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x694C1D0", Offset = "0x694A9D0", VA = "0x18694C1D0")]
	public bool NNKABFKKNBC(float3 NFFLDAHKGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x694C2C0", Offset = "0x694AAC0", VA = "0x18694C2C0")]
	public void PCHEPJFDHBB(float3 JMDOAKIMNLC, float3x3 MAEHDLJGHCI, float MJNPDCBNHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x694BB60", Offset = "0x694A360", VA = "0x18694BB60")]
	private void BGINIPHNCJH(float3 FNIJIKICPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x694BC60", Offset = "0x694A460", VA = "0x18694BC60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6947570", Offset = "0x6945D70", VA = "0x186947570")]
	public ICABHPNHGDE(NAJBPEBBKNG DICFBCCFLEI, float BKOEIEGNMCI, int JHEGPJBDKAJ, int GJGIBLAFHHL, NativeList<OALODHMDGLN> LINJEFIAFHO, NativeArray<int> PEFLDMODNIF, NativeList<HDBOOPAJBBL> POMECMHLLCI, LEFCAAKHOCL OCHMECPEPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6946B90", Offset = "0x6945390", VA = "0x186946B90", Slot = "4")]
	public void Execute(int EDJMDAGODNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6946AD0", Offset = "0x69452D0", VA = "0x186946AD0")]
	private bool DIIGBFPOACO(OALODHMDGLN MLFGLJKBOIG, OALODHMDGLN GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x69472D0", Offset = "0x6945AD0", VA = "0x1869472D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x694A020", Offset = "0x6948820", VA = "0x18694A020")]
	public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x694A320", Offset = "0x6948B20", VA = "0x18694A320")]
	public static long FDDHMOCCAJC(int NOLHGPALGBF, int HECJMBFPMPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x694A140", Offset = "0x6948940", VA = "0x18694A140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x694A230", Offset = "0x6948A30", VA = "0x18694A230")]
	public void EECPCLJADFI(JobHandle BHOKFONKIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x6940EE0", Offset = "0x693F6E0", VA = "0x186940EE0")]
	public EIJLFHILFBK(NAJBPEBBKNG DICFBCCFLEI, LEFCAAKHOCL OCHMECPEPDN, int MGIIKHOMNLD = 0, int OOBFMNLJHPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6940AA0", Offset = "0x693F2A0", VA = "0x186940AA0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6940E80", Offset = "0x693F680", VA = "0x186940E80")]
	private void GKBANPEJAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DDJFECLMAJL
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2976580", Offset = "0x2974D80", VA = "0x182976580")]
	public static bool FJIFLAMOAMH<T>(NativeArray<T> PFKJAOOHGBN, int ECGAAJFODGN, Allocator CHDJMCMMMLJ, NativeArrayOptions FDGBBGJEJMA = NativeArrayOptions.ClearMemory, int LAPHDBIKPDD = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2976630", Offset = "0x2974E30", VA = "0x182976630")]
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
		[Cpp2IlInjected.Address(RVA = "0x695A5E0", Offset = "0x6958DE0", VA = "0x18695A5E0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x695A710", Offset = "0x6958F10", VA = "0x18695A710")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x695A530", Offset = "0x6958D30", VA = "0x18695A530")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x695A2C0", Offset = "0x6958AC0", VA = "0x18695A2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x695AFC0", Offset = "0x69597C0", VA = "0x18695AFC0")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x695B0F0", Offset = "0x69598F0", VA = "0x18695B0F0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x695AF10", Offset = "0x6959710", VA = "0x18695AF10")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x695ABD0", Offset = "0x69593D0", VA = "0x18695ABD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6955D00", Offset = "0x6954500", VA = "0x186955D00")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6955E30", Offset = "0x6954630", VA = "0x186955E30")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6955C50", Offset = "0x6954450", VA = "0x186955C50")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x69559D0", Offset = "0x69541D0", VA = "0x1869559D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x696AC50", Offset = "0x6969450", VA = "0x18696AC50")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x696AD80", Offset = "0x6969580", VA = "0x18696AD80")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x696ABA0", Offset = "0x69693A0", VA = "0x18696ABA0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x696A960", Offset = "0x6969160", VA = "0x18696A960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6957870", Offset = "0x6956070", VA = "0x186957870")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x69579A0", Offset = "0x69561A0", VA = "0x1869579A0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x69577C0", Offset = "0x6955FC0", VA = "0x1869577C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6957580", Offset = "0x6955D80", VA = "0x186957580")]
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
		[Cpp2IlInjected.Address(RVA = "0x6966360", Offset = "0x6964B60", VA = "0x186966360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6968530", Offset = "0x6966D30", VA = "0x186968530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69684F0", Offset = "0x6966CF0", VA = "0x1869684F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCMJACOCFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69683C0", Offset = "0x6966BC0", VA = "0x1869683C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x69669E0", Offset = "0x69651E0", VA = "0x1869669E0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6964F70", Offset = "0x6963770", VA = "0x186964F70")]
	public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool JEDHHDJJCLE, bool MCBCAPCHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x69688D0", Offset = "0x69670D0", VA = "0x1869688D0")]
	public void JBGLCJDAAKF(int NOLHGPALGBF, int HECJMBFPMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6969910", Offset = "0x6968110", VA = "0x186969910", Slot = "6")]
	public bool PADBHOPLFNI(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6967900", Offset = "0x6966100", VA = "0x186967900")]
	public bool FOJFIIIODJJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6969920", Offset = "0x6968120", VA = "0x186969920")]
	public bool PBOGGAHOFPI(Mesh DICFBCCFLEI, NAJBPEBBKNG PPGDGCIOEJI, bool GDLAEOGBDLK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6968950", Offset = "0x6967150", VA = "0x186968950")]
	public void JDFIOJFBMJA(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6966AF0", Offset = "0x69652F0", VA = "0x186966AF0")]
	public void ELNINBFLLGC(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69684A0", Offset = "0x6966CA0", VA = "0x1869684A0")]
	[BurstCompile]
	public static int HIJOMKPBPFF(float IPBJLCONKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6968400", Offset = "0x6966C00", VA = "0x186968400")]
	[BurstCompile]
	public static uint HIJOMKPBPFF([In] float4 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6968450", Offset = "0x6966C50", VA = "0x186968450")]
	[BurstCompile]
	public static uint HIJOMKPBPFF([In] float3 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69663A0", Offset = "0x6964BA0", VA = "0x1869663A0")]
	public void DMMGPNHAEHF(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6968850", Offset = "0x6967050", VA = "0x186968850")]
	[BurstCompile]
	private unsafe static void ILNEAKLPIED([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69658D0", Offset = "0x69640D0", VA = "0x1869658D0")]
	public void CMECELCEBCJ(Mesh DICFBCCFLEI, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6967CE0", Offset = "0x69664E0", VA = "0x186967CE0")]
	[BurstCompile]
	private unsafe static void GBFPEOJCPIL([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6969820", Offset = "0x6968020", VA = "0x186969820")]
	public void NCJNLCDOODA(Mesh DICFBCCFLEI, KNOOBMCACLL BGOCEECJDJL, bool GDLAEOGBDLK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6969550", Offset = "0x6967D50", VA = "0x186969550")]
	public void LBJDLPDBEDK(NAJBPEBBKNG DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69693A0", Offset = "0x6967BA0", VA = "0x1869693A0")]
	public NAJBPEBBKNG JGFBHDIGANM(Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6965740", Offset = "0x6963F40", VA = "0x186965740")]
	public long CIIGGKDJOEF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6965870", Offset = "0x6964070", VA = "0x186965870")]
	public static long CIIGGKDJOEF(int EMICHICJLGC, int DBIJKCBBANM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69655E0", Offset = "0x6963DE0", VA = "0x1869655E0")]
	public static long BNBMCJOBFOE(int EMICHICJLGC, int DBIJKCBBANM, KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6965680", Offset = "0x6963E80", VA = "0x186965680")]
	public long BNBMCJOBFOE(KNOOBMCACLL BGOCEECJDJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69697C0", Offset = "0x6967FC0", VA = "0x1869697C0")]
	public void MBHMLCKHMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6967570", Offset = "0x6965D70", VA = "0x186967570")]
	public static void FAFHBLFDKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6967D60", Offset = "0x6966560", VA = "0x186967D60")]
	public KNOOBMCACLL GIBCJJAIKFE()
	{
		return default(KNOOBMCACLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6965160", Offset = "0x6963960", VA = "0x186965160")]
	public static (int, int) BCNMJDDPCAO(Mesh DICFBCCFLEI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6964E90", Offset = "0x6963690", VA = "0x186964E90")]
	public static int ACKMLIOFFCH(VertexAttributeDescriptor[] FPADDJONGOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69694E0", Offset = "0x6967CE0", VA = "0x1869694E0")]
	public static long KAAHBFPGHJC(Mesh DICFBCCFLEI, int CICOMOACNJA, int FPBOOOOIJIO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public NAJBPEBBKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x69687B0", Offset = "0x6966FB0", VA = "0x1869687B0")]
	[BurstCompile]
	public static int IJJMIPGGKLC(float IPBJLCONKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6968620", Offset = "0x6966E20", VA = "0x186968620")]
	[BurstCompile]
	public static uint IJJMIPGGKLC([In] float4 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6968570", Offset = "0x6966D70", VA = "0x186968570")]
	[BurstCompile]
	public static uint IJJMIPGGKLC([In] float3 NJJHKDBJDAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6965230", Offset = "0x6963A30", VA = "0x186965230")]
	[BurstCompile]
	public unsafe static void BGKBHBNEADP([NoAlias] BJGADGCOPIL* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6965F10", Offset = "0x6964710", VA = "0x186965F10")]
	[BurstCompile]
	public unsafe static void DCKOKKNEHCI([NoAlias] AGOPAGAENOE* EIKCCLGECIE, int BHPOFKEKDPM, [In][NoAlias] float3* AKBGHODCILL, [In][NoAlias] float3* JDGBACHKNKC, [In][NoAlias] float4* KKMEEHMLFMB, [In][NoAlias] float2* PAGNCNMLBPH, [In][NoAlias] float4* NIDIHFKKIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class EGGCEOBDPNB
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6955F90", Offset = "0x6954790", VA = "0x186955F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x69566C0", Offset = "0x6954EC0", VA = "0x1869566C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6956680", Offset = "0x6954E80", VA = "0x186956680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NEJPEHKDHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6956F80", Offset = "0x6955780", VA = "0x186956F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6956FC0", Offset = "0x69557C0", VA = "0x186956FC0")]
	public EINJEOMMPLD(int NOLHGPALGBF, int HECJMBFPMPO, int LPCJBALPLCK, Allocator CHDJMCMMMLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6957290", Offset = "0x6955A90", VA = "0x186957290")]
	public EINJEOMMPLD(Mesh DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6956570", Offset = "0x6954D70", VA = "0x186956570", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6956C80", Offset = "0x6955480", VA = "0x186956C80")]
	public void LBJDLPDBEDK(EINJEOMMPLD DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69560E0", Offset = "0x69548E0", VA = "0x1869560E0")]
	private void DECMDFKHIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6956700", Offset = "0x6954F00", VA = "0x186956700")]
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
	[Cpp2IlInjected.Address(RVA = "0x13F8D70", Offset = "0x13F7570", VA = "0x1813F8D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C85B0", VA = "0x1808C9DB0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HDBOOPAJBBL>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98C980", VA = "0x18098E180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EINJEOMMPLD HKBKABBDKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x696AFE0", Offset = "0x69697E0", VA = "0x18696AFE0")]
	public PPDAGFFIHDK(IEnumerable<EINJEOMMPLD> KKMCNLCAHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x696AF70", Offset = "0x6969770", VA = "0x18696AF70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x696A510", Offset = "0x6968D10", VA = "0x18696A510")]
	public static void EOJEBCEEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x696A630", Offset = "0x6968E30", VA = "0x18696A630")]
	public static NativeArray<float2> GLIPPCMJADN(NativeArray<float2> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float2> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x696A400", Offset = "0x6968C00", VA = "0x18696A400")]
	public static NativeArray<float3> EAFBIIAODMA(NativeArray<float3> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float3> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x696A850", Offset = "0x6969050", VA = "0x18696A850")]
	public static NativeArray<float4> PPEIFDNKACL(NativeArray<float4> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<float4> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x696A740", Offset = "0x6968F40", VA = "0x18696A740")]
	public static NativeArray<int> PELMBABBONG(NativeArray<int> FKOAJKIMKEM, int ICJDPKMCIGL, NativeArray<int> NOIPAHABMDB, int ODCCPKFDCOK)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB73E0", Offset = "0x2CB5BE0", VA = "0x182CB73E0")]
	private static void HHLCAGAMPEG<T>(NativeArray<T> PFKJAOOHGBN, int GFJHPONFOPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB7300", Offset = "0x2CB5B00", VA = "0x182CB7300")]
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
		[Cpp2IlInjected.Address(RVA = "0x696AF20", Offset = "0x6969720", VA = "0x18696AF20")]
		public PGIJANBONFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x696AEE0", Offset = "0x69696E0", VA = "0x18696AEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer PPPFMKBBPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859CC0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EAJPNEIOGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8BF200", Offset = "0x8BDA00", VA = "0x1808BF200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LNBNKGDDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC358A0", Offset = "0xC340A0", VA = "0x180C358A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x69602C0", Offset = "0x695EAC0", VA = "0x1869602C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<FDAECEGICND> JKBMFKNBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x695D440", Offset = "0x695BC40", VA = "0x18695D440")]
	public void ECNMCPAEMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x695BE30", Offset = "0x695A630", VA = "0x18695BE30")]
	private void CNNCLGPCFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6964BB0", Offset = "0x69633B0", VA = "0x186964BB0")]
	public NAFPBMLMEFB(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x695D450", Offset = "0x695BC50", VA = "0x18695D450")]
	public void EECPCLJADFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6963970", Offset = "0x6962170", VA = "0x186963970")]
	public void NEBLIIAJNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x695D7B0", Offset = "0x695BFB0", VA = "0x18695D7B0")]
	private void GKCJFEGJHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x695EF30", Offset = "0x695D730", VA = "0x18695EF30")]
	public void GNCDIBNJHAL(FDAECEGICND MJLBICKANIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6961490", Offset = "0x695FC90", VA = "0x186961490")]
	public bool KKMKMDPCGKN(FDAECEGICND MJLBICKANIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x695C270", Offset = "0x695AA70", VA = "0x18695C270")]
	public bool DJONJHALGBO(FDAECEGICND MJLBICKANIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6962A30", Offset = "0x6961230", VA = "0x186962A30", Slot = "4")]
	public virtual void LLJNEDJHFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6961530", Offset = "0x695FD30", VA = "0x186961530")]
	public void KNBDEOEBCOJ(Transform BFOKBBAAOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x695D6C0", Offset = "0x695BEC0", VA = "0x18695D6C0")]
	private long GFCDOHMEJEJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6961310", Offset = "0x695FB10", VA = "0x186961310")]
	private long JODDIOJDAOH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69602E0", Offset = "0x695EAE0", VA = "0x1869602E0")]
	public bool JNFECMCCFMG(Transform BFOKBBAAOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x695DCB0", Offset = "0x695C4B0", VA = "0x18695DCB0")]
	public bool GLPNNAIGEEE(bool CJJLFBMNEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x695BAD0", Offset = "0x695A2D0", VA = "0x18695BAD0")]
	public void CMBNHNKAJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6961740", Offset = "0x695FF40", VA = "0x186961740")]
	public bool LCAIOHNCMJC(float4x4 OBNNMAGIJBG, BatchedMeshRenderer CNCAAJKMDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x695DA40", Offset = "0x695C240", VA = "0x18695DA40")]
	public void GLJNPAMGAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6963A60", Offset = "0x6962260", VA = "0x186963A60")]
	public bool OJPDPHEEJEO(bool CJJLFBMNEBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x695D7A0", Offset = "0x695BFA0", VA = "0x18695D7A0")]
	public void GICIDKNNDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x695D570", Offset = "0x695BD70", VA = "0x18695D570")]
	public void FBIPMGLGLFC(NAJBPEBBKNG DICFBCCFLEI, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x695B250", Offset = "0x6959A50", VA = "0x18695B250")]
	public void BJOEIGIFCHN(ONMMPCFPEBK AGJBEJFOBLC, int PFFNBOEIGDL, int MECDCDEDHEP, float LHLPAIPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x695BA60", Offset = "0x695A260", VA = "0x18695BA60")]
	public (long, long, long) CIIGGKDJOEF()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9C0350", Offset = "0x9BEB50", VA = "0x1809C0350")]
	public long FOLIADHNDMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6964610", Offset = "0x6962E10", VA = "0x186964610")]
	private void PJGOPOLJENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x695F100", Offset = "0x695D900", VA = "0x18695F100")]
	public (long, long) GOCOHFDIHDN(float IALCKDAINHG, float4x4 OBNNMAGIJBG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	public void FAMBOFJBLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x695D5A0", Offset = "0x695BDA0", VA = "0x18695D5A0")]
	internal void GDLABJGCJKC(EKOMMFJGBPJ BKOADNCOIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6962E90", Offset = "0x6961690", VA = "0x186962E90")]
	private (float, float, float) NAPBBHLKNDH(float ENIPBABACHE, float4x4 OBNNMAGIJBG)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6962AE0", Offset = "0x69612E0", VA = "0x186962AE0")]
	private (int, int) MHGDCCHAHON(float KNBBDPHGJOH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x695C2D0", Offset = "0x695AAD0", VA = "0x18695C2D0")]
	public void DMIKCDADOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6963A30", Offset = "0x6962230", VA = "0x186963A30")]
	private void OFEOJOPMJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x695BC50", Offset = "0x695A450", VA = "0x18695BC50")]
	private void CMFIALHJLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x695B280", Offset = "0x6959A80", VA = "0x18695B280")]
	public long CCECPDBCAJM(long PNONPAELEBP, int HLCNBNDAHBI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6963D30", Offset = "0x6962530", VA = "0x186963D30")]
	private void OPLNGFMBMOD(NAJBPEBBKNG KFEHDFDFJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x695F4D0", Offset = "0x695DCD0", VA = "0x18695F4D0")]
	private void HKOHOOBGFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x695F770", Offset = "0x695DF70", VA = "0x18695F770")]
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
		[Cpp2IlInjected.Address(RVA = "0x6976240", Offset = "0x6974A40", VA = "0x186976240")]
		public void AFBDCJPJHLL(int NOLHGPALGBF, int HECJMBFPMPO, Allocator CHDJMCMMMLJ, bool MCBCAPCHDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69764E0", Offset = "0x6974CE0", VA = "0x1869764E0")]
		public static ONAFDFMEKCD EIGFFDAOBFL(NAJBPEBBKNG HKKDPGGNNBK)
		{
			return default(ONAFDFMEKCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6976420", Offset = "0x6974C20", VA = "0x186976420")]
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
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	[BurstDiscard]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	[BurstDiscard]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	[BurstDiscard]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6959B20", Offset = "0x6958320", VA = "0x186959B20")]
	public HOHIEFDPLPG([In] List<NAFPBMLMEFB.PGIJANBONFA> JGMNAPDLBMM, [In] NAJBPEBBKNG MJAAPFAPMAE, [In] NAFPBMLMEFB GKMJODLOHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6957BD0", Offset = "0x69563D0", VA = "0x186957BD0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6959300", Offset = "0x6957B00", VA = "0x186959300")]
	public void OCPNPPKMLAH(List<NAFPBMLMEFB.PGIJANBONFA> HKCBDFAMMFB, [In] NAFPBMLMEFB GKMJODLOHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69592E0", Offset = "0x6957AE0", VA = "0x1869592E0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool MEOIILHBCEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6957B00", Offset = "0x6956300", VA = "0x186957B00")]
	private ONMMPCFPEBK DOCENNGHCKO(int FGGLEFPMBBG, Allocator CHDJMCMMMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6957C20", Offset = "0x6956420", VA = "0x186957C20")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GPGMKOLDCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6958F70", Offset = "0x6957770", VA = "0x186958F70")]
	[IgnoreWarning(1371)]
	private BBFBGGLFHEK KAMBONBNBHO([In] BBFBGGLFHEK DFBJHPELBPP, int CPNPIEACKDD, [In] NativeArray<int> NADKEDPNJIG, [In] NativeArray<bool> PECFPILAHFK, NativeArray<int> HDNGOOCDLGG)
	{
		return default(BBFBGGLFHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6959980", Offset = "0x6958180", VA = "0x186959980")]
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
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int NDLPILCJANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6972060", Offset = "0x6970860", VA = "0x186972060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		private static void FFCICGEKPJO(bool BFOAIFCNHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x696EA30", Offset = "0x696D230", VA = "0x18696EA30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x696CEB0", Offset = "0x696B6B0", VA = "0x18696CEB0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x696CC80", Offset = "0x696B480", VA = "0x18696CC80")]
		public NAFPBMLMEFB AddToBatchedMesh(FDAECEGICND LJDGDHFLMGN, Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6971170", Offset = "0x696F970", VA = "0x186971170")]
		public void RemoveFromBatchedMesh(FDAECEGICND DICFBCCFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x696CD80", Offset = "0x696B580", VA = "0x18696CD80")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6971950", Offset = "0x6970150", VA = "0x186971950")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Color KIJNHGNFMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6971510", Offset = "0x696FD10", VA = "0x186971510")]
		public void SetMaterialProperty(int AOOLGPHJJIF, float JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6971730", Offset = "0x696FF30", VA = "0x186971730")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Vector4 BAMLBBOKLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69712B0", Offset = "0x696FAB0", VA = "0x1869712B0")]
		public void SetMaterialProperty(int AOOLGPHJJIF, Matrix4x4 FPPOIAGEIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x696DA60", Offset = "0x696C260", VA = "0x18696DA60")]
		private void JHKMIIOHJMG(Renderer GHBIMLIJLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x696D080", Offset = "0x696B880", VA = "0x18696D080")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x696D070", Offset = "0x696B870", VA = "0x18696D070")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x696C760", Offset = "0x696AF60", VA = "0x18696C760")]
		private void AEJOEMJOBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x696E330", Offset = "0x696CB30", VA = "0x18696E330")]
		private NAFPBMLMEFB MFOEMNMIEEO(FDAECEGICND DICFBCCFLEI, Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x696E050", Offset = "0x696C850", VA = "0x18696E050")]
		private NAFPBMLMEFB KIFKJKHJHCI(Material GIIKGEKINDH, int LLONNBOMNPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x696D660", Offset = "0x696BE60", VA = "0x18696D660")]
		private NAFPBMLMEFB IILIKPJMHAA(Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18CAF40", Offset = "0x18C9740", VA = "0x1818CAF40")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x696E550", Offset = "0x696CD50", VA = "0x18696E550")]
		public void MarkDirty(FDAECEGICND DICFBCCFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x696E6B0", Offset = "0x696CEB0", VA = "0x18696E6B0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float IALCKDAINHG)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6970200", Offset = "0x696EA00", VA = "0x186970200")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x696D120", Offset = "0x696B920", VA = "0x18696D120")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x696ED20", Offset = "0x696D520", VA = "0x18696ED20")]
		public void RebatchOptimally(int LKEFJAFGKPE, int NEDKDECPMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6971DF0", Offset = "0x69705F0", VA = "0x186971DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x91FDB0", Offset = "0x91E5B0", VA = "0x18091FDB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x696C5F0", Offset = "0x696ADF0", VA = "0x18696C5F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA76790", Offset = "0xA74F90", VA = "0x180A76790")]
		[DebuggerHidden]
		public BHKCFCIPBJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x696C640", Offset = "0x696AE40", VA = "0x18696C640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x696B8A0", Offset = "0x696A0A0", VA = "0x18696B8A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x696B800", Offset = "0x696A000", VA = "0x18696B800")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x696B850", Offset = "0x696A050", VA = "0x18696B850")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x696C5A0", Offset = "0x696ADA0", VA = "0x18696C5A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x696C4F0", Offset = "0x696ACF0", VA = "0x18696C4F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x696C4F0", Offset = "0x696ACF0", VA = "0x18696C4F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6972970", Offset = "0x6971170", VA = "0x186972970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void EEMLPPKHNCL(bool BFOAIFCNHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void FFCICGEKPJO(bool BFOAIFCNHJM, string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6972A00", Offset = "0x6971200", VA = "0x186972A00")]
	public static void EEKIDKGBNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6972250", Offset = "0x6970A50", VA = "0x186972250")]
	public static void BOLIKDIKPKL(BatchedMeshRenderer LNEKBFHLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6975E20", Offset = "0x6974620", VA = "0x186975E20")]
	public static void PELMDNDPBGB(BatchedMeshRenderer LNEKBFHLMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69720B0", Offset = "0x69708B0", VA = "0x1869720B0")]
	private static (long, long, long) AKNEANIPLIJ(long GBENNCDCKJK)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6972FC0", Offset = "0x69717C0", VA = "0x186972FC0")]
	public static void LCAIOHNCMJC(long GBENNCDCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69724C0", Offset = "0x6970CC0", VA = "0x1869724C0")]
	public static long CCECPDBCAJM(long PNONPAELEBP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6972860", Offset = "0x6971060", VA = "0x186972860")]
	public static void CPMLOBNGEEG(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6972EC0", Offset = "0x69716C0", VA = "0x186972EC0")]
	public static void JGPPPNBPIMI(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float OFPEDHFNFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x69756A0", Offset = "0x6973EA0", VA = "0x1869756A0")]
	public static void MCPGGPLLLKC(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float OFPEDHFNFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69757B0", Offset = "0x6973FB0", VA = "0x1869757B0")]
	public static void MLJJBMKJNEK(NAFPBMLMEFB NBCAIOIDCBF, BatchedMeshRenderer GCBPACDODGJ, long PKDFMKEJNIK, float CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6975AC0", Offset = "0x69742C0", VA = "0x186975AC0")]
	public static float OKFHKJGHMPG(long LBBCIOCCOIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6972BB0", Offset = "0x69713B0", VA = "0x186972BB0")]
	public static (long, long) GOCOHFDIHDN(float IALCKDAINHG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69721C0", Offset = "0x69709C0", VA = "0x1869721C0")]
	[IteratorStateMachine(typeof(BHKCFCIPBJG))]
	public static IEnumerable<bool> BFMPDPMBNEF(long GLPBPGGDPLE, bool BDHMLIHIGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6975950", Offset = "0x6974150", VA = "0x186975950")]
	public static void OHFPIPPIHFM(long GLPBPGGDPLE, bool BDHMLIHIGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6972D80", Offset = "0x6971580", VA = "0x186972D80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BD9440", Offset = "0x3BD7C40", VA = "0x183BD9440")]
	public FHANHKALJDM(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BD90A0", Offset = "0x3BD78A0", VA = "0x183BD90A0")]
	public void GNCDIBNJHAL(KeyType NDDCLPHCEEO, FDAECEGICND MJLBICKANIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BD9200", Offset = "0x3BD7A00", VA = "0x183BD9200")]
	public bool GOCJLOFAFIF(KeyType NDDCLPHCEEO, FDAECEGICND JHCHLEJPEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8FD0", Offset = "0x3BD77D0", VA = "0x183BD8FD0")]
	public void DCFKEHMOEGL(KeyType NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BD92F0", Offset = "0x3BD7AF0", VA = "0x183BD92F0", Slot = "4")]
	public override void LLJNEDJHFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6976730", Offset = "0x6974F30", VA = "0x186976730")]
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
