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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68C4140", Offset = "0x68C2940", VA = "0x1868C4140", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JKKNDHBCGEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int OBGBGFPCANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 KFFAGNAAELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion MCPJKILLJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 GFDBFDLGHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int OIIHCFBIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int BJDFJONKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int EHBKOJIGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float FEALADHOJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 ODJPPLLKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool LKFLKPJCMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NOOMKDNGADN GILJJMHBPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 DNAKHIHLHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float GLAFMCKLFPE;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IJMEDKLNFLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static FINCPPIDEDD AJMDLCGMFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<JKKNDHBCGEN> CMGBIJMJOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<IGHELALFNHK> JGADDLGAMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<KIBIPDNODLO> IFHDNNEMJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<MABNINNFJON> ILFJJMOKKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<IGHELALFNHK> NPNEGDAEMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NDJDHKAFLKK> BCNBBNMHEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<MABNINNFJON>> MOMNGPKKDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<AHDDEHAGNCN> GHMFNECIJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> LDJGOANABJH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CNNODONBCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD85FB0", Offset = "0xD847B0", VA = "0x180D85FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD85A60", Offset = "0xD84260", VA = "0x180D85A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GHCEOODJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD85FC0", Offset = "0xD847C0", VA = "0x180D85FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD85A70", Offset = "0xD84270", VA = "0x180D85A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68BF220", Offset = "0x68BDA20", VA = "0x1868BF220")]
	public IJMEDKLNFLB(int PMMCFIDHJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68BE520", Offset = "0x68BCD20", VA = "0x1868BE520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68BEEF0", Offset = "0x68BD6F0", VA = "0x1868BEEF0")]
	public void LDBBLMGLBBG(JobHandle IKOGPNHIMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68BECD0", Offset = "0x68BD4D0", VA = "0x1868BECD0")]
	public void IOFHMLOACMJ(JKKNDHBCGEN MLKNGAFFKGE, AHDDEHAGNCN BNDEEELNKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68BF0C0", Offset = "0x68BD8C0", VA = "0x1868BF0C0")]
	public void LNCCANKLKGJ(KIBIPDNODLO MLKNGAFFKGE, NativeArray<MABNINNFJON> NGJPLCMMFCJ, int NMHMJGBBGAD, int MPDAAIPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68BD510", Offset = "0x68BBD10", VA = "0x1868BD510")]
	public JobHandle ABLHBBEOECA(ACMLDDOGEBP DGENMODLNHE, IGKHGOAJCAJ IDOLOKEINHL, float3 IMCEGNHHCCE, quaternion DBKHFPLMHPI, float HAKMGJCOINN, bool FDAPPCHGEKG, int CJLHOFCKPLG = 0, int BBCAPHFBEFL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68BE6E0", Offset = "0x68BCEE0", VA = "0x1868BE6E0")]
	public static JobHandle EKEHGCFFLKL(EFDFEDOKEIP KAKOLKEHEPF, ACMLDDOGEBP DGENMODLNHE, JKKNDHBCGEN MLKNGAFFKGE, JobHandle IKOGPNHIMCJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68BEA20", Offset = "0x68BD220", VA = "0x1868BEA20")]
	public static JobHandle IMPOIBFAGKF(DPFAIAKNLOK KAKOLKEHEPF, ACMLDDOGEBP DGENMODLNHE, KIBIPDNODLO MLKNGAFFKGE, NativeArray<MABNINNFJON> NGJPLCMMFCJ, int NMHMJGBBGAD, int MPDAAIPLJHK, JobHandle IKOGPNHIMCJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class PEIPAMFJHOL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KAMJLCPKFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half PKNEKFJDLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort LEBMJKFDPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte DDOECOBPPPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void FLJKBBBBMFF([NoAlias] float3* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class HPHHMIEHNIO
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68BC9B0", Offset = "0x68BB1B0", VA = "0x1868BC9B0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68BC7C0", Offset = "0x68BAFC0", VA = "0x1868BC7C0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68BC910", Offset = "0x68BB110", VA = "0x1868BC910")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68BCAD0", Offset = "0x68BB2D0", VA = "0x1868BCAD0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] float3* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void MGLADFILICC([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class MCOFLPEALCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68C49D0", Offset = "0x68C31D0", VA = "0x1868C49D0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68C47E0", Offset = "0x68C2FE0", VA = "0x1868C47E0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68C4930", Offset = "0x68C3130", VA = "0x1868C4930")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68C4AF0", Offset = "0x68C32F0", VA = "0x1868C4AF0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void FEPLJPLJBOC([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class HGOLOPPICDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68BC320", Offset = "0x68BAB20", VA = "0x1868BC320")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68BC130", Offset = "0x68BA930", VA = "0x1868BC130")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68BC280", Offset = "0x68BAA80", VA = "0x1868BC280")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x68BC440", Offset = "0x68BAC40", VA = "0x1868BC440")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void PFACJENKPPE([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class DGHFEGOPHDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x68B6790", Offset = "0x68B4F90", VA = "0x1868B6790")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68B65A0", Offset = "0x68B4DA0", VA = "0x1868B65A0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68B66F0", Offset = "0x68B4EF0", VA = "0x1868B66F0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x68B68B0", Offset = "0x68B50B0", VA = "0x1868B68B0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void OFENGDOMOLJ([NoAlias] ushort* CJFGCHOCKHA, [Out] float3 KDJDIEOLMLJ, [Out] float3 JBGJCCLMICK, [In][NoAlias] float3* IDDDOHDGCGG, int JDOGIKEHIEK, int MNEHNMJHPCD);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class AAAIHLNLONP
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x68B3030", Offset = "0x68B1830", VA = "0x1868B3030")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x68B2E40", Offset = "0x68B1640", VA = "0x1868B2E40")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x68B2F90", Offset = "0x68B1790", VA = "0x1868B2F90")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x68B3150", Offset = "0x68B1950", VA = "0x1868B3150")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ushort* CJFGCHOCKHA, [Out] float3 KDJDIEOLMLJ, [Out] float3 JBGJCCLMICK, [In][NoAlias] float3* IDDDOHDGCGG, int JDOGIKEHIEK, int MNEHNMJHPCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void LOIJMEHHFJH([NoAlias] ushort* AKGNPLMIJEO, [In][NoAlias] float3* DFHNAJDBKME, int MNEHNMJHPCD);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class PLMBCGBHDNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68CE5B0", Offset = "0x68CCDB0", VA = "0x1868CE5B0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x68CE3C0", Offset = "0x68CCBC0", VA = "0x1868CE3C0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x68CE510", Offset = "0x68CCD10", VA = "0x1868CE510")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x68CE6D0", Offset = "0x68CCED0", VA = "0x1868CE6D0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ushort* AKGNPLMIJEO, [In][NoAlias] float3* DFHNAJDBKME, int MNEHNMJHPCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void DDMOFBDKOJJ([NoAlias] float3* OBLBBAMPJNN, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class DFGHANNCEBD
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x68B6240", Offset = "0x68B4A40", VA = "0x1868B6240")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x68B6050", Offset = "0x68B4850", VA = "0x1868B6050")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68B61A0", Offset = "0x68B49A0", VA = "0x1868B61A0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68B6360", Offset = "0x68B4B60", VA = "0x1868B6360")]
		public unsafe static void EHHNDHAPNMD([NoAlias] float3* OBLBBAMPJNN, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void MCPHGEDNHNE([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class ADJJGPOLBPA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x68B3650", Offset = "0x68B1E50", VA = "0x1868B3650")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x68B3460", Offset = "0x68B1C60", VA = "0x1868B3460")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68B35B0", Offset = "0x68B1DB0", VA = "0x1868B35B0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68B3770", Offset = "0x68B1F70", VA = "0x1868B3770")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void JMOAFIOFAJC([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class KOOLKHEDKJG
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68C2740", Offset = "0x68C0F40", VA = "0x1868C2740")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x68C2550", Offset = "0x68C0D50", VA = "0x1868C2550")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x68C26A0", Offset = "0x68C0EA0", VA = "0x1868C26A0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68C2860", Offset = "0x68C1060", VA = "0x1868C2860")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void HIHOHIMKALJ([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class IONBNNJLKAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68C0E00", Offset = "0x68BF600", VA = "0x1868C0E00")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68C0C10", Offset = "0x68BF410", VA = "0x1868C0C10")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68C0D60", Offset = "0x68BF560", VA = "0x1868C0D60")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68C0F20", Offset = "0x68BF720", VA = "0x1868C0F20")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void KLEBCHGGACG([NoAlias] ushort* NGDCFGHEFJD, [Out] float2 JKHKDNDKCKI, [Out] float2 KGLCINJPDND, [In][NoAlias] float2* PGFGAEBHHNL, int JDOGIKEHIEK, int MNEHNMJHPCD);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class OJOMLMLPOOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x68C6750", Offset = "0x68C4F50", VA = "0x1868C6750")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68C6560", Offset = "0x68C4D60", VA = "0x1868C6560")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68C66B0", Offset = "0x68C4EB0", VA = "0x1868C66B0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x68C6870", Offset = "0x68C5070", VA = "0x1868C6870")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ushort* NGDCFGHEFJD, [Out] float2 JKHKDNDKCKI, [Out] float2 KGLCINJPDND, [In][NoAlias] float2* PGFGAEBHHNL, int JDOGIKEHIEK, int MNEHNMJHPCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void HOPAAKBAFBO([Out] float2 JNLKKGNCKLJ, ushort LMIBFEPJAOF, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class EBOOIOMNDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x68B9470", Offset = "0x68B7C70", VA = "0x1868B9470")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x68B9280", Offset = "0x68B7A80", VA = "0x1868B9280")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x68B93D0", Offset = "0x68B7BD0", VA = "0x1868B93D0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x68B9590", Offset = "0x68B7D90", VA = "0x1868B9590")]
		public static void EHHNDHAPNMD([Out] float2 JNLKKGNCKLJ, ushort LMIBFEPJAOF, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void KOPJBDOIJLC([NoAlias] float2* NGDCFGHEFJD, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class LHFOEAAABPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x68C32D0", Offset = "0x68C1AD0", VA = "0x1868C32D0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x68C30E0", Offset = "0x68C18E0", VA = "0x1868C30E0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x68C3230", Offset = "0x68C1A30", VA = "0x1868C3230")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x68C33F0", Offset = "0x68C1BF0", VA = "0x1868C33F0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] float2* NGDCFGHEFJD, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void EDFOFGPBFCK([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class BPJKIOCGCMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x68B5C70", Offset = "0x68B4470", VA = "0x1868B5C70")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68B5A80", Offset = "0x68B4280", VA = "0x1868B5A80")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x68B5BD0", Offset = "0x68B43D0", VA = "0x1868B5BD0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x68B5D90", Offset = "0x68B4590", VA = "0x1868B5D90")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void LLIGPLAMPGK([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class FMHPNFFINLE
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x68BB4B0", Offset = "0x68B9CB0", VA = "0x1868BB4B0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x68BB2C0", Offset = "0x68B9AC0", VA = "0x1868BB2C0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x68BB410", Offset = "0x68B9C10", VA = "0x1868BB410")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68BB5D0", Offset = "0x68B9DD0", VA = "0x1868BB5D0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void ENBPOPFEHAN([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class BJGAMGJCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68B55C0", Offset = "0x68B3DC0", VA = "0x1868B55C0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x68B53D0", Offset = "0x68B3BD0", VA = "0x1868B53D0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68B5520", Offset = "0x68B3D20", VA = "0x1868B5520")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68B56E0", Offset = "0x68B3EE0", VA = "0x1868B56E0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void NDPKEJDGDIL([NoAlias] ushort* CBIHFAOOCAJ, [In][NoAlias] float4* DPEPOKLJANC, int JDOGIKEHIEK, int MNEHNMJHPCD);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class KCJOBDLNHDI
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x68C1FF0", Offset = "0x68C07F0", VA = "0x1868C1FF0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x68C1E00", Offset = "0x68C0600", VA = "0x1868C1E00")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x68C1F50", Offset = "0x68C0750", VA = "0x1868C1F50")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68C2110", Offset = "0x68C0910", VA = "0x1868C2110")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ushort* CBIHFAOOCAJ, [In][NoAlias] float4* DPEPOKLJANC, int JDOGIKEHIEK, int MNEHNMJHPCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort JNNMHCBCOFK([In] float4 PHNIIGLDECA);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class ODCMPOMKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x68C6240", Offset = "0x68C4A40", VA = "0x1868C6240")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x68C6050", Offset = "0x68C4850", VA = "0x1868C6050")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x68C61A0", Offset = "0x68C49A0", VA = "0x1868C61A0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x68C6360", Offset = "0x68C4B60", VA = "0x1868C6360")]
		public static ushort EHHNDHAPNMD([In] float4 PHNIIGLDECA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void LFDNKDKJEIC([NoAlias] float4* CBIHFAOOCAJ, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class MBHONLMBJAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68C4480", Offset = "0x68C2C80", VA = "0x1868C4480")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x68C4290", Offset = "0x68C2A90", VA = "0x1868C4290")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68C43E0", Offset = "0x68C2BE0", VA = "0x1868C43E0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68C45A0", Offset = "0x68C2DA0", VA = "0x1868C45A0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] float4* CBIHFAOOCAJ, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void EMCBAPKCHKI([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class AHGCIKAOJAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x68B45B0", Offset = "0x68B2DB0", VA = "0x1868B45B0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68B43C0", Offset = "0x68B2BC0", VA = "0x1868B43C0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68B4510", Offset = "0x68B2D10", VA = "0x1868B4510")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x68B46D0", Offset = "0x68B2ED0", VA = "0x1868B46D0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void EPIJHEMGCGH([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class LBAAMFNEEDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x68C2D10", Offset = "0x68C1510", VA = "0x1868C2D10")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68C2B20", Offset = "0x68C1320", VA = "0x1868C2B20")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68C2C70", Offset = "0x68C1470", VA = "0x1868C2C70")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68C2E30", Offset = "0x68C1630", VA = "0x1868C2E30")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void OAIBJJJHGCO([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class NFCJNGFCCBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x68C5700", Offset = "0x68C3F00", VA = "0x1868C5700")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68C5510", Offset = "0x68C3D10", VA = "0x1868C5510")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x68C5660", Offset = "0x68C3E60", VA = "0x1868C5660")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x68C5820", Offset = "0x68C4020", VA = "0x1868C5820")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void ELKECLLIBHE([Out] float4 KKBKNCNBBJP, ushort LMIBFEPJAOF);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class LOFMGCHMBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x68C3DB0", Offset = "0x68C25B0", VA = "0x1868C3DB0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x68C3BC0", Offset = "0x68C23C0", VA = "0x1868C3BC0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68C3D10", Offset = "0x68C2510", VA = "0x1868C3D10")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x68C3ED0", Offset = "0x68C26D0", VA = "0x1868C3ED0")]
		public static void EHHNDHAPNMD([Out] float4 KKBKNCNBBJP, ushort LMIBFEPJAOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void JKGPPAFPBGC([NoAlias] float4* JAKAKMBGNFL, [NoAlias] byte* PINELLNFFIJ, [Out] int LHHDMPGBKMF, [Out] int DCNPEOCLHCK, [NoAlias] float4* AENPKMOGJPF, int JDOGIKEHIEK, int MNEHNMJHPCD);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class IDDLKDNLMDO
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x68BCEC0", Offset = "0x68BB6C0", VA = "0x1868BCEC0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68BCCD0", Offset = "0x68BB4D0", VA = "0x1868BCCD0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x68BCE20", Offset = "0x68BB620", VA = "0x1868BCE20")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x68BCFE0", Offset = "0x68BB7E0", VA = "0x1868BCFE0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] float4* JAKAKMBGNFL, [NoAlias] byte* PINELLNFFIJ, [Out] int LHHDMPGBKMF, [Out] int DCNPEOCLHCK, [NoAlias] float4* AENPKMOGJPF, int JDOGIKEHIEK, int MNEHNMJHPCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void IEDLJEHONHF([NoAlias] float4* FJHIGIPELNJ, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class JNNAMIDGDOE
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68C1A00", Offset = "0x68C0200", VA = "0x1868C1A00")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x68C1810", Offset = "0x68C0010", VA = "0x1868C1810")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x68C1960", Offset = "0x68C0160", VA = "0x1868C1960")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x68C1B20", Offset = "0x68C0320", VA = "0x1868C1B20")]
		public unsafe static void EHHNDHAPNMD([NoAlias] float4* FJHIGIPELNJ, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void JBOFLOCAKBG([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class GDBPOJPFIJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x68BBA80", Offset = "0x68BA280", VA = "0x1868BBA80")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x68BB890", Offset = "0x68BA090", VA = "0x1868BB890")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x68BB9E0", Offset = "0x68BA1E0", VA = "0x1868BB9E0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x68BBBA0", Offset = "0x68BA3A0", VA = "0x1868BBBA0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void NMNKFALHMIO([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class PFIIKKBBKLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x68CD3C0", Offset = "0x68CBBC0", VA = "0x1868CD3C0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x68CD1D0", Offset = "0x68CB9D0", VA = "0x1868CD1D0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x68CD320", Offset = "0x68CBB20", VA = "0x1868CD320")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x68CD4E0", Offset = "0x68CBCE0", VA = "0x1868CD4E0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void DMNEGIMECPI([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class NDPEEKHPADA
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x68C4F60", Offset = "0x68C3760", VA = "0x1868C4F60")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x68C4D70", Offset = "0x68C3570", VA = "0x1868C4D70")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x68C4EC0", Offset = "0x68C36C0", VA = "0x1868C4EC0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x68C5080", Offset = "0x68C3880", VA = "0x1868C5080")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int KGNOCHKCCNO([NoAlias] byte* CDCMCGKBAPB, [In][NoAlias] int* IKJACJOBEMA, int FFKCEKAIIGA);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class NPBNLIKOGAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x68C5CB0", Offset = "0x68C44B0", VA = "0x1868C5CB0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x68C5AC0", Offset = "0x68C42C0", VA = "0x1868C5AC0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x68C5C10", Offset = "0x68C4410", VA = "0x1868C5C10")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x68C5DD0", Offset = "0x68C45D0", VA = "0x1868C5DD0")]
		public unsafe static int EHHNDHAPNMD([NoAlias] byte* CDCMCGKBAPB, [In][NoAlias] int* IKJACJOBEMA, int FFKCEKAIIGA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void AAKAMKMGFGF([NoAlias] int* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class LHHGOBMCAMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x68C3860", Offset = "0x68C2060", VA = "0x1868C3860")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x68C3670", Offset = "0x68C1E70", VA = "0x1868C3670")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x68C37C0", Offset = "0x68C1FC0", VA = "0x1868C37C0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x68C3980", Offset = "0x68C2180", VA = "0x1868C3980")]
		public unsafe static void EHHNDHAPNMD([NoAlias] int* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void NHMIDGBECJG([NoAlias] ushort* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class JIPEIJDBEBH
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x68C13B0", Offset = "0x68BFBB0", VA = "0x1868C13B0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x68C11C0", Offset = "0x68BF9C0", VA = "0x1868C11C0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x68C1310", Offset = "0x68BFB10", VA = "0x1868C1310")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x68C14D0", Offset = "0x68BFCD0", VA = "0x1868C14D0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] ushort* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void AFOLAKAHLEP([Out] float3 JNLKKGNCKLJ, ushort LMIBFEPJAOF);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class BCCFHMCGIEL
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x68B4F60", Offset = "0x68B3760", VA = "0x1868B4F60")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x68B4D70", Offset = "0x68B3570", VA = "0x1868B4D70")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x68B4EC0", Offset = "0x68B36C0", VA = "0x1868B4EC0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x68B5080", Offset = "0x68B3880", VA = "0x1868B5080")]
		public static void EHHNDHAPNMD([Out] float3 JNLKKGNCKLJ, ushort LMIBFEPJAOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort PDJFJJEBPMD([In] float3 PHNIIGLDECA);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class PNEKAFKJNGC
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x68CEAA0", Offset = "0x68CD2A0", VA = "0x1868CEAA0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x68CE8B0", Offset = "0x68CD0B0", VA = "0x1868CE8B0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x68CEA00", Offset = "0x68CD200", VA = "0x1868CEA00")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x68CEBC0", Offset = "0x68CD3C0", VA = "0x1868CEBC0")]
		public static ushort EHHNDHAPNMD([In] float3 PHNIIGLDECA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int NMHMJGBBGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int MPDAAIPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> BDHHICBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> OENPFFJCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> OMHPGEPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MNKECMGPDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<KAMJLCPKFPI> GAFKCNKDFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> KJFMAOFFIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> KCIMAGJGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 EENLJDBOJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 JBGJCCLMICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 OFGGNGHGMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 KGLCINJPDND;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long EBKPCLOPNKN;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long CBALCGMPNNJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float KOICGGENIGO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool DFEJLLKBHJB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IPOIDOLGAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68CC900", Offset = "0x68CB100", VA = "0x1868CC900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68CB100", Offset = "0x68C9900", VA = "0x1868CB100")]
	public void LDBBLMGLBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68C7B90", Offset = "0x68C6390", VA = "0x1868C7B90")]
	public static PEIPAMFJHOL DLNFHNOLCMJ(Allocator KCJKALFMGMC, ACMLDDOGEBP EIPBOLDONIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68C7D70", Offset = "0x68C6570", VA = "0x1868C7D70")]
	public static PEIPAMFJHOL DLNFHNOLCMJ(Allocator KCJKALFMGMC, NativeArray<float3> IDDDOHDGCGG, NativeArray<float3> DFHNAJDBKME, NativeArray<float2> PGFGAEBHHNL, NativeArray<float4> AENPKMOGJPF, bool DODFGBELADB, NativeArray<float4> LMGJDJFPJCK, NativeArray<int> IKJACJOBEMA, int NMHMJGBBGAD, int IMIFEIIADBI, int MPDAAIPLJHK, int JDOGIKEHIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68C6BA0", Offset = "0x68C53A0", VA = "0x1868C6BA0")]
	public ACMLDDOGEBP AIGBAACBOIK(Allocator KCJKALFMGMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68C7730", Offset = "0x68C5F30", VA = "0x1868C7730")]
	public void CIBNBNKPMKG(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68C6A80", Offset = "0x68C5280", VA = "0x1868C6A80")]
	private void AELGAAHGDPN(Mesh NCHKGMDMAMN, NativeArray<ushort> NAPDFHFIGHC, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68C9270", Offset = "0x68C7A70", VA = "0x1868C9270")]
	public void GEHOMJBODHP(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68CCBF0", Offset = "0x68CB3F0", VA = "0x1868CCBF0")]
	public void PPLJAAHNDOJ(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68CBAF0", Offset = "0x68CA2F0", VA = "0x1868CBAF0")]
	public void MKOLGCPDOBK(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68CB3B0", Offset = "0x68C9BB0", VA = "0x1868CB3B0")]
	public void LFMDAKOEIFA(Mesh NCHKGMDMAMN, ACMLDDOGEBP.NKNGCAILIBP NFAJBIAKHPK, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68CA430", Offset = "0x68C8C30", VA = "0x1868CA430")]
	public long JIINFKCJHJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68C9870", Offset = "0x68C8070", VA = "0x1868C9870")]
	public long GLKDLANLEGN(ACMLDDOGEBP.NKNGCAILIBP NFAJBIAKHPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68CAFD0", Offset = "0x68C97D0", VA = "0x1868CAFD0")]
	private void KLACAKIKHIA(int KOMAPJMJKFA, int MNEHNMJHPCD, Allocator KCJKALFMGMC, bool BBCFFDOIDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68C7830", Offset = "0x68C6030", VA = "0x1868C7830")]
	private void DDCELCEAOKB(NativeArray<float3> CJFGCHOCKHA, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68C7930", Offset = "0x68C6130", VA = "0x1868C7930")]
	[BurstCompile]
	private unsafe static void DDCELCEAOKB([NoAlias] float3* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68CA4C0", Offset = "0x68C8CC0", VA = "0x1868CA4C0")]
	[BurstCompile]
	private unsafe static void JLEGFMMMHHF([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68C98E0", Offset = "0x68C80E0", VA = "0x1868C98E0")]
	[BurstCompile]
	private unsafe static void GMIIJOMNMJN([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68C9960", Offset = "0x68C8160", VA = "0x1868C9960")]
	[BurstCompile]
	private unsafe static void HAHNOEMLMJD([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68C8C90", Offset = "0x68C7490", VA = "0x1868C8C90")]
	private void FPCMCHIMBKD(NativeArray<float3> IDDDOHDGCGG, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68C8D90", Offset = "0x68C7590", VA = "0x1868C8D90")]
	[BurstCompile]
	private unsafe static void FPCMCHIMBKD([NoAlias] ushort* CJFGCHOCKHA, [Out] float3 KDJDIEOLMLJ, [Out] float3 JBGJCCLMICK, [In][NoAlias] float3* IDDDOHDGCGG, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68C9030", Offset = "0x68C7830", VA = "0x1868C9030")]
	private void GBHALHNOICF(NativeArray<float3> DFHNAJDBKME, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68C8E20", Offset = "0x68C7620", VA = "0x1868C8E20")]
	[BurstCompile]
	private unsafe static void GBHALHNOICF([NoAlias] ushort* AKGNPLMIJEO, [In][NoAlias] float3* DFHNAJDBKME, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68C9FE0", Offset = "0x68C87E0", VA = "0x1868C9FE0")]
	private void JCLGCKKFIJH(NativeArray<float3> OBLBBAMPJNN, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68C9F70", Offset = "0x68C8770", VA = "0x1868C9F70")]
	[BurstCompile]
	private unsafe static void JCLGCKKFIJH([NoAlias] float3* OBLBBAMPJNN, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68CA660", Offset = "0x68C8E60", VA = "0x1868CA660")]
	[BurstCompile]
	private unsafe static void KDEDECICFIC([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68CCA20", Offset = "0x68CB220", VA = "0x1868CCA20")]
	[BurstCompile]
	private unsafe static void PIHJHLJNGNH([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68CC9B0", Offset = "0x68CB1B0", VA = "0x1868CC9B0")]
	[BurstCompile]
	private unsafe static void PHOEAPONMCH([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68CB7E0", Offset = "0x68C9FE0", VA = "0x1868CB7E0")]
	private void MFMDGKDEHAE(NativeArray<float2> PGFGAEBHHNL, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68CB8B0", Offset = "0x68CA0B0", VA = "0x1868CB8B0")]
	[BurstCompile]
	private unsafe static void MFMDGKDEHAE([NoAlias] ushort* NGDCFGHEFJD, [Out] float2 JKHKDNDKCKI, [Out] float2 KGLCINJPDND, [In][NoAlias] float2* PGFGAEBHHNL, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68C97F0", Offset = "0x68C7FF0", VA = "0x1868C97F0")]
	[BurstCompile]
	private static void GKNDKMFGCPL([Out] float2 JNLKKGNCKLJ, ushort LMIBFEPJAOF, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68C90F0", Offset = "0x68C78F0", VA = "0x1868C90F0")]
	private void GDHNGDNPEGN(NativeArray<float2> NGDCFGHEFJD, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68C91F0", Offset = "0x68C79F0", VA = "0x1868C91F0")]
	[BurstCompile]
	private unsafe static void GDHNGDNPEGN([NoAlias] float2* NGDCFGHEFJD, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68CC280", Offset = "0x68CAA80", VA = "0x1868CC280")]
	[BurstCompile]
	private unsafe static void NFDKELCLOHD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68C9DD0", Offset = "0x68C85D0", VA = "0x1868C9DD0")]
	[BurstCompile]
	private unsafe static void IMJAFKFGLIN([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68C9D50", Offset = "0x68C8550", VA = "0x1868C9D50")]
	[BurstCompile]
	private unsafe static void IMEBBLOCLBH([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68C82E0", Offset = "0x68C6AE0", VA = "0x1868C82E0")]
	private void DOENGGFJGGC(NativeArray<float4> LMGJDJFPJCK, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68C8260", Offset = "0x68C6A60", VA = "0x1868C8260")]
	[BurstCompile]
	private unsafe static void DOENGGFJGGC([NoAlias] ushort* CBIHFAOOCAJ, [In][NoAlias] float4* DPEPOKLJANC, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68CB5B0", Offset = "0x68C9DB0", VA = "0x1868CB5B0")]
	[BurstCompile]
	private static ushort MAHMKMCGEHA([In] float4 PHNIIGLDECA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68C75A0", Offset = "0x68C5DA0", VA = "0x1868C75A0")]
	private void BDGKIKLKNLF(NativeArray<float4> CBIHFAOOCAJ, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68C7530", Offset = "0x68C5D30", VA = "0x1868C7530")]
	[BurstCompile]
	private unsafe static void BDGKIKLKNLF([NoAlias] float4* CBIHFAOOCAJ, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68CC490", Offset = "0x68CAC90", VA = "0x1868CC490")]
	[BurstCompile]
	private unsafe static void NJAJKIJELGD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68CC940", Offset = "0x68CB140", VA = "0x1868CC940")]
	[BurstCompile]
	private unsafe static void OMMDMFFODOL([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68C76C0", Offset = "0x68C5EC0", VA = "0x1868C76C0")]
	[BurstCompile]
	private unsafe static void CCKNBDABKEJ([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68CCB90", Offset = "0x68CB390", VA = "0x1868CCB90")]
	[BurstCompile]
	private static void PNEBBEHALBJ([Out] float4 KKBKNCNBBJP, ushort LMIBFEPJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68CA8F0", Offset = "0x68C90F0", VA = "0x1868CA8F0")]
	private void KHGDJJCJMLG(Allocator KCJKALFMGMC, NativeArray<float4> AENPKMOGJPF, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68CACD0", Offset = "0x68C94D0", VA = "0x1868CACD0")]
	[BurstCompile]
	private unsafe static void KHGDJJCJMLG([NoAlias] float4* JAKAKMBGNFL, [NoAlias] byte* PINELLNFFIJ, [Out] int LHHDMPGBKMF, [Out] int DCNPEOCLHCK, [NoAlias] float4* AENPKMOGJPF, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68C7200", Offset = "0x68C5A00", VA = "0x1868C7200")]
	private static void AJEKCDFIMNE(NativeArray<float4> FJHIGIPELNJ, NativeArray<KAMJLCPKFPI> AOANMIEDBKF, NativeArray<byte> MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68C7180", Offset = "0x68C5980", VA = "0x1868C7180")]
	[BurstCompile]
	private unsafe static void AJEKCDFIMNE([NoAlias] float4* FJHIGIPELNJ, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68CA870", Offset = "0x68C9070", VA = "0x1868CA870")]
	[BurstCompile]
	private unsafe static void KECLJIKDDGL([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68C86D0", Offset = "0x68C6ED0", VA = "0x1868C86D0")]
	[BurstCompile]
	private unsafe static void EJIGIIMADDM([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68CC300", Offset = "0x68CAB00", VA = "0x1868CC300")]
	[BurstCompile]
	private unsafe static void NFLPOICOBBO([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68C8BB0", Offset = "0x68C73B0", VA = "0x1868C8BB0")]
	private void FHADBLODHCI(Allocator KCJKALFMGMC, NativeArray<int> IKJACJOBEMA, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x68CA120", Offset = "0x68C8920", VA = "0x1868CA120")]
	private static NativeArray<byte> JEPEHGGDEJP(Allocator KCJKALFMGMC, NativeArray<int> IKJACJOBEMA, int FFKCEKAIIGA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x68CA0B0", Offset = "0x68C88B0", VA = "0x1868CA0B0")]
	[BurstCompile]
	private unsafe static int JEPEHGGDEJP([NoAlias] byte* CDCMCGKBAPB, [In][NoAlias] int* IKJACJOBEMA, int FFKCEKAIIGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68C8AE0", Offset = "0x68C72E0", VA = "0x1868C8AE0")]
	private static void FGMHDCEMNOK(NativeArray<int> ODEEEPNDFNO, NativeArray<byte> HIPKKNAPAEE, int MPDAAIPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68C8A70", Offset = "0x68C7270", VA = "0x1868C8A70")]
	[BurstCompile]
	private unsafe static void FGMHDCEMNOK([NoAlias] int* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68CB340", Offset = "0x68C9B40", VA = "0x1868CB340")]
	[BurstCompile]
	private unsafe static void LFEPJIEDIIN([NoAlias] ushort* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68CC8A0", Offset = "0x68CB0A0", VA = "0x1868CC8A0")]
	[BurstCompile]
	private static void OCKCFEMDAEG([Out] float3 JNLKKGNCKLJ, ushort LMIBFEPJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x68CC6A0", Offset = "0x68CAEA0", VA = "0x1868CC6A0")]
	[BurstCompile]
	private static ushort NJAPINIPKLO([In] float3 PHNIIGLDECA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PEIPAMFJHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68B2610", Offset = "0x68B0E10", VA = "0x1868B2610")]
	[BurstCompile]
	public unsafe static void MHEOKOHNGFF([NoAlias] float3* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68CA5A0", Offset = "0x68C8DA0", VA = "0x1868CA5A0")]
	[BurstCompile]
	public unsafe static void JOIBLELCBFK([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68C8610", Offset = "0x68C6E10", VA = "0x1868C8610")]
	[BurstCompile]
	public unsafe static void EHDJGMBEHLB([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68CAF10", Offset = "0x68C9710", VA = "0x1868CAF10")]
	[BurstCompile]
	public unsafe static void KIDGKOMPCEL([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* IDDDOHDGCGG, int NMHMJGBBGAD, [In] float3 EENLJDBOJID, [In] float3 JBGJCCLMICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68B2230", Offset = "0x68B0A30", VA = "0x1868B2230")]
	[BurstCompile]
	public unsafe static void MECIDNAIEOE([NoAlias] ushort* CJFGCHOCKHA, [Out] float3 KDJDIEOLMLJ, [Out] float3 JBGJCCLMICK, [In][NoAlias] float3* IDDDOHDGCGG, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x68B19A0", Offset = "0x68B01A0", VA = "0x1868B19A0")]
	[BurstCompile]
	public unsafe static void EKIKEMGPBPH([NoAlias] ushort* AKGNPLMIJEO, [In][NoAlias] float3* DFHNAJDBKME, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68CC0D0", Offset = "0x68CA8D0", VA = "0x1868CC0D0")]
	[BurstCompile]
	public unsafe static void NCBLOMFFBBN([NoAlias] float3* OBLBBAMPJNN, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68B14B0", Offset = "0x68AFCB0", VA = "0x1868B14B0")]
	[BurstCompile]
	public unsafe static void DAPEBNGLPGD([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68C7310", Offset = "0x68C5B10", VA = "0x1868C7310")]
	[BurstCompile]
	public unsafe static void AKEFLPKAPGC([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68CC380", Offset = "0x68CAB80", VA = "0x1868CC380")]
	[BurstCompile]
	public unsafe static void NIPFJCEDNIN([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* DFHNAJDBKME, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68B1DB0", Offset = "0x68B05B0", VA = "0x1868B1DB0")]
	[BurstCompile]
	public unsafe static void FJPBLAOMHPH([NoAlias] ushort* NGDCFGHEFJD, [Out] float2 JKHKDNDKCKI, [Out] float2 KGLCINJPDND, [In][NoAlias] float2* PGFGAEBHHNL, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68C7670", Offset = "0x68C5E70", VA = "0x1868C7670")]
	[BurstCompile]
	public static void BDMELOEJHMO([Out] float2 JNLKKGNCKLJ, ushort LMIBFEPJAOF, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68C8490", Offset = "0x68C6C90", VA = "0x1868C8490")]
	[BurstCompile]
	public unsafe static void EBOMLHLCLPO([NoAlias] float2* NGDCFGHEFJD, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68C99E0", Offset = "0x68C81E0", VA = "0x1868C99E0")]
	[BurstCompile]
	public unsafe static void HMNABGLBCNH([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68C7430", Offset = "0x68C5C30", VA = "0x1868C7430")]
	[BurstCompile]
	public unsafe static void BBENLADPOGO([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68C8750", Offset = "0x68C6F50", VA = "0x1868C8750")]
	[BurstCompile]
	public unsafe static void EJPEAONBEIP([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [NoAlias] ushort* PGFGAEBHHNL, int NMHMJGBBGAD, [In] float2 OFGGNGHGMLJ, [In] float2 KGLCINJPDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68C9CB0", Offset = "0x68C84B0", VA = "0x1868C9CB0")]
	[BurstCompile]
	public unsafe static void IKIHPOHOMOO([NoAlias] ushort* CBIHFAOOCAJ, [In][NoAlias] float4* DPEPOKLJANC, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68CA540", Offset = "0x68C8D40", VA = "0x1868CA540")]
	[BurstCompile]
	public static ushort JOEOMEMJFDC([In] float4 PHNIIGLDECA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68CA390", Offset = "0x68C8B90", VA = "0x1868CA390")]
	[BurstCompile]
	public unsafe static void JIFKOBNHJFN([NoAlias] float4* CBIHFAOOCAJ, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68B16F0", Offset = "0x68AFEF0", VA = "0x1868B16F0")]
	[BurstCompile]
	public unsafe static void EBLGKDNCJOH([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68C9E50", Offset = "0x68C8650", VA = "0x1868C9E50")]
	[BurstCompile]
	public unsafe static void IPOFKMMFGEO([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68CC170", Offset = "0x68CA970", VA = "0x1868CC170")]
	[BurstCompile]
	public unsafe static void NEPAOFFBDNJ([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] ushort* LMGJDJFPJCK, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68C83D0", Offset = "0x68C6BD0", VA = "0x1868C83D0")]
	[BurstCompile]
	public static void DPDDFKKJBLF([Out] float4 KKBKNCNBBJP, ushort LMIBFEPJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68B1BF0", Offset = "0x68B03F0", VA = "0x1868B1BF0")]
	[BurstCompile]
	public unsafe static void ENLPMJBIFLF([NoAlias] float4* JAKAKMBGNFL, [NoAlias] byte* PINELLNFFIJ, [Out] int LHHDMPGBKMF, [Out] int DCNPEOCLHCK, [NoAlias] float4* AENPKMOGJPF, int JDOGIKEHIEK, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68CB200", Offset = "0x68C9A00", VA = "0x1868CB200")]
	[BurstCompile]
	public unsafe static void LFEJNKGDIGH([NoAlias] float4* FJHIGIPELNJ, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68C9AD0", Offset = "0x68C82D0", VA = "0x1868C9AD0")]
	[BurstCompile]
	public unsafe static void IAENJBMEBPG([NoAlias] ACMLDDOGEBP.MFJGGKECFCJ* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68C79B0", Offset = "0x68C61B0", VA = "0x1868C79B0")]
	[BurstCompile]
	public unsafe static void DJIHCOFHKMB([NoAlias] ACMLDDOGEBP.CMALJDEBDNC* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68CB600", Offset = "0x68C9E00", VA = "0x1868CB600")]
	[BurstCompile]
	public unsafe static void MCJFIBJNFBF([NoAlias] ACMLDDOGEBP.BKGHCMONOIG* CJFGCHOCKHA, [In][NoAlias] KAMJLCPKFPI* AOANMIEDBKF, [In][NoAlias] byte* MIHMNOBMOPC, int NMHMJGBBGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68CCA90", Offset = "0x68CB290", VA = "0x1868CCA90")]
	[BurstCompile]
	public unsafe static int PJIHKPCDGDN([NoAlias] byte* CDCMCGKBAPB, [In][NoAlias] int* IKJACJOBEMA, int FFKCEKAIIGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68CB510", Offset = "0x68C9D10", VA = "0x1868CB510")]
	[BurstCompile]
	public unsafe static void LGIFIIGGFNK([NoAlias] int* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68C8570", Offset = "0x68C6D70", VA = "0x1868C8570")]
	[BurstCompile]
	public unsafe static void EFDOFAGNPMA([NoAlias] ushort* ODEEEPNDFNO, [In][NoAlias] byte* HIPKKNAPAEE, int MPDAAIPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68C8930", Offset = "0x68C7130", VA = "0x1868C8930")]
	[BurstCompile]
	public static void EPPKJMNLKNG([Out] float3 JNLKKGNCKLJ, ushort LMIBFEPJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68B2070", Offset = "0x68B0870", VA = "0x1868B2070")]
	[BurstCompile]
	public static ushort ICOMIDCFJJP([In] float3 PHNIIGLDECA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct LMBLAHBBLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 FHAALGCKALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 MAFNCGJIECE;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GMEHHLLOBBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<LMBLAHBBLGB> KDFENKNGOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> GJPFMDMKGFA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CNNODONBCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GHCEOODJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84CE60", Offset = "0x84B660", VA = "0x18084CE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x68BC070", Offset = "0x68BA870", VA = "0x1868BC070")]
	public GMEHHLLOBBP(int KOMAPJMJKFA, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68BC010", Offset = "0x68BA810", VA = "0x1868BC010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68BBF30", Offset = "0x68BA730", VA = "0x1868BBF30")]
	public void AJBCBEPOLBC(GMEHHLLOBBP JIDHBFMBMCM, int BIDCNIDMPGJ, int JDPLFEPKJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FLFPCEAHJNC
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static GMEHHLLOBBP BBEDAIDKHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<IGHELALFNHK> LNHAJGNBACL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] LMKMEHEKKPO;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool BPOHNKGIPNE;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, GMEHHLLOBBP> DKDCBFJNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, GMEHHLLOBBP> HPHBIAJOOGG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool LPKNEKOBBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x68BA2F0", Offset = "0x68B8AF0", VA = "0x1868BA2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<IGHELALFNHK> ILGMCCKOAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x68B9A50", Offset = "0x68B8250", VA = "0x1868B9A50")]
		get
		{
			return default(NativeList<IGHELALFNHK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static GMEHHLLOBBP HMIKEILNNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x68BA9F0", Offset = "0x68B91F0", VA = "0x1868BA9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x68BAA80", Offset = "0x68B9280", VA = "0x1868BAA80")]
	private static void PJICFICMAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68BA2C0", Offset = "0x68B8AC0", VA = "0x1868BA2C0")]
	public static int HCKKFGHOOAM(bool BPDNOCDNHLN, int GHLLPIHGNMM, bool CCPIACGPEPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68BA3E0", Offset = "0x68B8BE0", VA = "0x1868BA3E0")]
	private static int JDGHCAFODFB(int GHLLPIHGNMM, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68B9EC0", Offset = "0x68B86C0", VA = "0x1868B9EC0")]
	private static int CCGPLCIAAOF(int GHLLPIHGNMM, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68B9D90", Offset = "0x68B8590", VA = "0x1868B9D90")]
	public static int BEJJKKKPHBK(int IBPIKFEDDCD, int GHLLPIHGNMM, int KLHOHCOMGED, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68BA210", Offset = "0x68B8A10", VA = "0x1868BA210")]
	public static int FBPCEKPGCBL(int IBPIKFEDDCD, int GHLLPIHGNMM, int KLHOHCOMGED, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x68B9EB0", Offset = "0x68B86B0", VA = "0x1868B9EB0")]
	public static int BHLMGLFHJEG(int KLHOHCOMGED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x68BA400", Offset = "0x68B8C00", VA = "0x1868BA400")]
	private static int KJHHAKCKEEK(int GHLLPIHGNMM, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x68B9AE0", Offset = "0x68B82E0", VA = "0x1868B9AE0")]
	private static int AEDALFEEKCL(int GHLLPIHGNMM, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x68BA370", Offset = "0x68B8B70", VA = "0x1868BA370")]
	public static int IFOFOIJODML(int IBPIKFEDDCD, int GHLLPIHGNMM, int KLHOHCOMGED, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68B9E20", Offset = "0x68B8620", VA = "0x1868B9E20")]
	public static int BGNEHCNJEKN(int IBPIKFEDDCD, int GHLLPIHGNMM, int KLHOHCOMGED, bool IMLPMODJJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x68BA2A0", Offset = "0x68B8AA0", VA = "0x1868BA2A0")]
	public static int GEPNKIBFOHD(int KLHOHCOMGED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x68BA500", Offset = "0x68B8D00", VA = "0x1868BA500")]
	public static GMEHHLLOBBP NFGLDBJLCPG(int GHLLPIHGNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68B9B00", Offset = "0x68B8300", VA = "0x1868B9B00")]
	private static GMEHHLLOBBP AJBMFNKFIID(int GHLLPIHGNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x68BA410", Offset = "0x68B8C10", VA = "0x1868BA410")]
	public static GMEHHLLOBBP MJNGFPOJLPN(int GHLLPIHGNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x68B9ED0", Offset = "0x68B86D0", VA = "0x1868B9ED0")]
	private static GMEHHLLOBBP DGALCFANIDO(int GHLLPIHGNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x68BA5F0", Offset = "0x68B8DF0", VA = "0x1868BA5F0")]
	public static void OCACGGKKNLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KIBIPDNODLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int NNPMPIMKLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 KFFAGNAAELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion MCPJKILLJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float GFDBFDLGHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float EIMIFMDIHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int OIIHCFBIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int BJDFJONKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int EHBKOJIGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool PNEABGPGOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool DNJHOIFGALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float FEALADHOJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 ODJPPLLKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool EHLOCMCPBKD;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct NDJDHKAFLKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int MHBFELMMAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int FAOFGBNNLHG;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DPFAIAKNLOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<KIBIPDNODLO> HHKLDLNCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<MABNINNFJON> ALIEIJPBIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<IGHELALFNHK> OGKBBPDBLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<NDJDHKAFLKK> FILCCDGHGBA;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x68B9150", Offset = "0x68B7950", VA = "0x1868B9150")]
	public DPFAIAKNLOK(NativeArray<MABNINNFJON> ALIEIJPBIKK, int GGKCGCGFHKJ = 1, Allocator KCJKALFMGMC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x68B9060", Offset = "0x68B7860", VA = "0x1868B9060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct DNNBMOOOKNF : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<LMBLAHBBLGB> PEFJDPLEOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> MGHMENFBHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<IGHELALFNHK> JOILLHOGANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<KIBIPDNODLO> HHKLDLNCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<MABNINNFJON> ALIEIJPBIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<IGHELALFNHK> OGKBBPDBLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<NDJDHKAFLKK> FILCCDGHGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int DNJICAFPIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int CCAINAMDAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 ABCABNMDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion HBFLIKEOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 IKINHPBOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DBBLPKCDMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HBBNCJLCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GGCFFNJMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NDJJFCCGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> LLJFGGKCGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IEFJCEPAIJL;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x68B8BB0", Offset = "0x68B73B0", VA = "0x1868B8BB0")]
	public DNNBMOOOKNF(IJMEDKLNFLB LDIAKFMDLHF, ACMLDDOGEBP FLEJMJGDEBG, float3 JMPGELKIHGG, quaternion JHHIKDOOICL, float LNJLEEDEJMG, int CJLHOFCKPLG = 0, int BBCAPHFBEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x68B8E30", Offset = "0x68B7630", VA = "0x1868B8E30")]
	public DNNBMOOOKNF(DPFAIAKNLOK LDIAKFMDLHF, ACMLDDOGEBP FLEJMJGDEBG, float3 JMPGELKIHGG, quaternion JHHIKDOOICL, float3 LNJLEEDEJMG, int CJLHOFCKPLG = 0, int BBCAPHFBEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x68B8A80", Offset = "0x68B7280", VA = "0x1868B8A80")]
	private float3 OINPFPNJNBG(float3 LCNNFLBPLJF, Matrix4x4 GDKJLHGAMEO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x68B85A0", Offset = "0x68B6DA0", VA = "0x1868B85A0")]
	private float3x3 HKEDJAGAKBI(float3x3 GJDPABBDEGP, float3x3 JDHLKPJHAPB)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x68B6C30", Offset = "0x68B5430", VA = "0x1868B6C30")]
	private float DFIMLGFCIFL(float KEONANJCBKH, float MBMOBOEDIDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x68B6C40", Offset = "0x68B5440", VA = "0x1868B6C40", Slot = "4")]
	public void Execute(int GGPLCIIKAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x68B7DE0", Offset = "0x68B65E0", VA = "0x1868B7DE0")]
	private void FHOPNLGBAHC(int GKCGKMCJLCC, float3 GBKEBGLIOFD, float3 ANAAMNHLGOD, float3 APMGNNPLKKN, float PBKMMDBNFGD, bool GNNDNLEOOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x68B8620", Offset = "0x68B6E20", VA = "0x1868B8620")]
	private void JIPLOIBAOBL(KIBIPDNODLO MCPJONJKHHJ, float3 DBPJNNMJCKO, float3x3 OOJJBHEGACK, float KEONANJCBKH, int ODEDMBGPBKA, int OHNFAFMLNKC, int ELMCKELAKIC, float EDLCBPGGEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x68B7F50", Offset = "0x68B6750", VA = "0x1868B7F50")]
	private void GDOPFCNMCPF(int GKCGKMCJLCC, int ADKNGCFBIEN, KIBIPDNODLO MCPJONJKHHJ, float3 DBPJNNMJCKO, float3x3 OOJJBHEGACK, bool LLAKKJJPMDE, float KEONANJCBKH, int EILBKPFIDAJ, int IPAJDBMELNE, int ELMCKELAKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct EFDFEDOKEIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<JKKNDHBCGEN> AMMOLJDNMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<IGHELALFNHK> JBAEOIIHGII;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x68B9960", Offset = "0x68B8160", VA = "0x1868B9960")]
	public EFDFEDOKEIP(int GGKCGCGFHKJ, Allocator KCJKALFMGMC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x68B98C0", Offset = "0x68B80C0", VA = "0x1868B98C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct IOHKMJHINGI : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum MMPHMPEDDDP
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
	private NativeList<float3> NJEMGJNAHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> FBGICNNCJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> HBBJBOCLOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> CDNKNHPGBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> IBPHILPIOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> JJBBGNCLMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> HGJOCBJFPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> IIFOBAHGJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<IGHELALFNHK> JBLECCJJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<JKKNDHBCGEN> AMMOLJDNMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<IGHELALFNHK> JBAEOIIHGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int DNJICAFPIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int CCAINAMDAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DBBLPKCDMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HBBNCJLCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GGCFFNJMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NDJJFCCGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> LLJFGGKCGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IEFJCEPAIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 IKINHPBOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion HBFLIKEOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 ABCABNMDNCJ;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x68C0A20", Offset = "0x68BF220", VA = "0x1868C0A20")]
	public IOHKMJHINGI(IJMEDKLNFLB LDIAKFMDLHF, ACMLDDOGEBP FLEJMJGDEBG, float3 JMPGELKIHGG, quaternion JHHIKDOOICL, float LNJLEEDEJMG, int CJLHOFCKPLG = 0, int BBCAPHFBEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x68C0840", Offset = "0x68BF040", VA = "0x1868C0840")]
	public IOHKMJHINGI(EFDFEDOKEIP MLKNGAFFKGE, ACMLDDOGEBP FLEJMJGDEBG, float3 JMPGELKIHGG, quaternion JHHIKDOOICL, float3 LNJLEEDEJMG, int CJLHOFCKPLG = 0, int BBCAPHFBEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x68BF430", Offset = "0x68BDC30", VA = "0x1868BF430", Slot = "4")]
	public void Execute(int GGPLCIIKAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x68C0390", Offset = "0x68BEB90", VA = "0x1868C0390")]
	private void FICIFCLNOCC(float4x4 LFAGPHMBIPK, int GGPLCIIKAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x68C07D0", Offset = "0x68BEFD0", VA = "0x1868C07D0")]
	private MMPHMPEDDDP NJAKFOMOPDP(float3 ANAAMNHLGOD)
	{
		return default(MMPHMPEDDDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x68C0740", Offset = "0x68BEF40", VA = "0x1868C0740")]
	private float4 JPIMPJNGPOM(MMPHMPEDDDP OLPILNMFDEG, int JBDLDJOINOF)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x68C0790", Offset = "0x68BEF90", VA = "0x1868C0790")]
	private float2 LJMOKCPCOBG(MMPHMPEDDDP OLPILNMFDEG, float3 GBKEBGLIOFD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct AHDDEHAGNCN
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum DGFKMINGPFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static AHDDEHAGNCN IJLPDDOKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 KIBDPDIBGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 PHONLGLKLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 JAFNMFMLFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public DGFKMINGPFG LBCGEBEPPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 HHLJKPMFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 LOLOBLCNAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CPEGFNCLDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x68B3B30", Offset = "0x68B2330", VA = "0x1868B3B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 HMDCNOODKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x68B3950", Offset = "0x68B2150", VA = "0x1868B3950")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x68B42D0", Offset = "0x68B2AD0", VA = "0x1868B42D0")]
	public AHDDEHAGNCN(float3 GBKEBGLIOFD, quaternion LOMIHBHMPMH, float3 GGKCGCGFHKJ, DGFKMINGPFG HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x68B3DE0", Offset = "0x68B25E0", VA = "0x1868B3DE0")]
	public float OLIKMOCDAOB(float3 DBPJNNMJCKO, float COEGJFPKMLJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x68B3CF0", Offset = "0x68B24F0", VA = "0x1868B3CF0")]
	public bool NCJBIPEMOGE(float3 ANAAMNHLGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x68B3B40", Offset = "0x68B2340", VA = "0x1868B3B40")]
	public void JCPLOCGPJNO(float3 CGLLGIFPMEN, float3x3 GANBEACHEAM, float MHLNONBIHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x68B3A30", Offset = "0x68B2230", VA = "0x1868B3A30")]
	private void CMKDKMHLEPA(float3 BGLKCAHKMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x68B3FE0", Offset = "0x68B27E0", VA = "0x1868B3FE0")]
	public void PMELBKDACKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct PIIFDODBKHG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<AHDDEHAGNCN> MLKNGAFFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> BDHHICBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> KCIMAGJGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LDJGOANABJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<IGHELALFNHK> JBAEOIIHGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int DFEBKFGMLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int JGGBPHGLEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float COEGJFPKMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float FOEIKDJIODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DAIBCBLCFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> KIILMPHPGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> DABDJLLOPKD;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x68CE320", Offset = "0x68CCB20", VA = "0x1868CE320")]
	public PIIFDODBKHG(ACMLDDOGEBP NCHKGMDMAMN, float HKOEMMEDCDE, int JDPLFEPKJAC, int ODEDMBGPBKA, NativeList<AHDDEHAGNCN> MLKNGAFFKGE, NativeArray<int> LDJGOANABJH, NativeList<IGHELALFNHK> JBAEOIIHGII, IGKHGOAJCAJ IDOLOKEINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x68CDBE0", Offset = "0x68CC3E0", VA = "0x1868CDBE0", Slot = "4")]
	public void Execute(int DNFALDNIJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x68CD880", Offset = "0x68CC080", VA = "0x1868CD880")]
	private bool AKKEBBIMNDJ(AHDDEHAGNCN NKCCEIKLOPK, AHDDEHAGNCN ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x68CD940", Offset = "0x68CC140", VA = "0x1868CD940")]
	private bool CEMFNIGGFLB(AHDDEHAGNCN NENJINMAAOK, int NNENHKNCEDE, int LLCGCGJMFKG, int IGLJLCGHPDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IGKHGOAJCAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> GCOBMEOAHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> GICGGPFKCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> KOOGOPDKNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> IDJKKEGEBMC;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x68BD300", Offset = "0x68BBB00", VA = "0x1868BD300")]
	public void KLACAKIKHIA(int KOMAPJMJKFA, int MNEHNMJHPCD, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x68BD2E0", Offset = "0x68BBAE0", VA = "0x1868BD2E0")]
	public static long GHCMNCLPBKO(int KOMAPJMJKFA, int MNEHNMJHPCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x68BD1F0", Offset = "0x68BB9F0", VA = "0x1868BD1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x68BD420", Offset = "0x68BBC20", VA = "0x1868BD420")]
	public void LDBBLMGLBBG(JobHandle IKOGPNHIMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IGKHGOAJCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct AIOKILNMGJM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> BDHHICBCGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> OENPFFJCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> GAFKCNKDFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> MNKECMGPDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> KCIMAGJGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> OMHPGEPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> DFFOPKJJNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> DAIBCBLCFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> KIILMPHPGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int CJLHOFCKPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int BBCAPHFBEFL;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x68B4CF0", Offset = "0x68B34F0", VA = "0x1868B4CF0")]
	public AIOKILNMGJM(ACMLDDOGEBP NCHKGMDMAMN, IGKHGOAJCAJ IDOLOKEINHL, int BBCAPHFBEFL = 0, int CJLHOFCKPLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x68B48B0", Offset = "0x68B30B0", VA = "0x1868B48B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x68B4C90", Offset = "0x68B3490", VA = "0x1868B4C90")]
	private void PPEEEMMBHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class NDCMBCGLNKP
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5A10", Offset = "0x2BD4210", VA = "0x182BD5A10")]
	public static bool FMEDGLHIHGP<T>(NativeArray<T> JAOFFCELONG, int GGKCGCGFHKJ, Allocator KCJKALFMGMC, NativeArrayOptions KBIBKNJKDBF = NativeArrayOptions.ClearMemory, int JJGPBBDCPJF = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5B90", Offset = "0x2BD4390", VA = "0x182BD5B90")]
	public static bool FMEDGLHIHGP<T>(NativeList<T> MAKDKEMHGGE, int GGKCGCGFHKJ, Allocator KCJKALFMGMC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum MEAEHDGGOMD
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
public interface KNGGMHOMCBP
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IFBEFIAIPPD(MEAEHDGGOMD IBPIKFEDDCD);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OFDMPKIFBCI(MEAEHDGGOMD IBPIKFEDDCD);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds GIAEOHIDPCP();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float IOCCHNKLHBP();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMOGBBLEDKN(MEAEHDGGOMD IBPIKFEDDCD, IJMEDKLNFLB BKPNONPPGFK, int INNBLAAIDKO = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class ACMLDDOGEBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum NKNGCAILIBP
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
	public struct FBHBEEFFPNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public NKNGCAILIBP NFAJBIAKHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool JNOIMDEEKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int AKHMBJLKPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] EELDAOEDCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct CCABLBFPJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 GBKEBGLIOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 ANAAMNHLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 APMGNNPLKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 DJPDKIENCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 GAFKCNKDFGD;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] EELDAOEDCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct MFJGGKECFCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 GBKEBGLIOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 ANAAMNHLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 APMGNNPLKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 DJPDKIENCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 GAFKCNKDFGD;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] EELDAOEDCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct KHLFCOKJNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 GBKEBGLIOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 ANAAMNHLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 APMGNNPLKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 DJPDKIENCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint GAFKCNKDFGD;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] EELDAOEDCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct CMALJDEBDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 GBKEBGLIOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint ANAAMNHLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint APMGNNPLKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 DJPDKIENCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 GAFKCNKDFGD;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] EELDAOEDCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct BKGHCMONOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 GBKEBGLIOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint ANAAMNHLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint APMGNNPLKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 DJPDKIENCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 GAFKCNKDFGD;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] EELDAOEDCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int KICGNADDJCE(float PNGIKMLKECD);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class KBJMEGDKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x68D7AD0", Offset = "0x68D62D0", VA = "0x1868D7AD0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x68D78E0", Offset = "0x68D60E0", VA = "0x1868D78E0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x68D7A30", Offset = "0x68D6230", VA = "0x1868D7A30")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x68D7BF0", Offset = "0x68D63F0", VA = "0x1868D7BF0")]
		public static int EHHNDHAPNMD(float PNGIKMLKECD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint MKGBOGLIIFA([In] float4 BLNBBLFAAGC);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class EMIOGJEGJBD
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x68D60F0", Offset = "0x68D48F0", VA = "0x1868D60F0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x68D5F00", Offset = "0x68D4700", VA = "0x1868D5F00")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x68D6050", Offset = "0x68D4850", VA = "0x1868D6050")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x68D6210", Offset = "0x68D4A10", VA = "0x1868D6210")]
		public static uint EHHNDHAPNMD([In] float4 BLNBBLFAAGC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint GLELLGJHBJI([In] float3 BLNBBLFAAGC);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class IIOFBEENHLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x68D7550", Offset = "0x68D5D50", VA = "0x1868D7550")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68D7360", Offset = "0x68D5B60", VA = "0x1868D7360")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x68D74B0", Offset = "0x68D5CB0", VA = "0x1868D74B0")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x68D7670", Offset = "0x68D5E70", VA = "0x1868D7670")]
		public static uint EHHNDHAPNMD([In] float3 BLNBBLFAAGC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void PAGOFOMEIOP([NoAlias] CMALJDEBDNC* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class DAGLANGCJBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x68D5BB0", Offset = "0x68D43B0", VA = "0x1868D5BB0")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x68D59C0", Offset = "0x68D41C0", VA = "0x1868D59C0")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x68D5B10", Offset = "0x68D4310", VA = "0x1868D5B10")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x68D5CD0", Offset = "0x68D44D0", VA = "0x1868D5CD0")]
		public unsafe static void EHHNDHAPNMD([NoAlias] CMALJDEBDNC* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void IDPGJGBCBOL([NoAlias] BKGHCMONOIG* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class BOGJCBGNNFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr FNANNKDLNLC;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr PKKIJDOHPNA;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x68D5320", Offset = "0x68D3B20", VA = "0x1868D5320")]
		[BurstDiscard]
		private static void CKCEFLFNNDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x68D5130", Offset = "0x68D3930", VA = "0x1868D5130")]
		private static IntPtr AEHPODGCFMA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x68D5280", Offset = "0x68D3A80", VA = "0x1868D5280")]
		public static void APEPJDHHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x68D5440", Offset = "0x68D3C40", VA = "0x1868D5440")]
		public unsafe static void EHHNDHAPNMD([NoAlias] BKGHCMONOIG* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int ELFIFGNIPAL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> MBBNFLNGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> NNCGHPJGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> DJEKCAJLFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> FFFFFLHPNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> KLPMNOIILDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> DGJNBEPEBAE;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] BHBELFGOCNO;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool FANACNLOFMO;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static FBHBEEFFPNK[] DPLMIMOJKOF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HACFJPDLFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68D3790", Offset = "0x68D1F90", VA = "0x1868D3790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CNNODONBCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x68D4490", Offset = "0x68D2C90", VA = "0x1868D4490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int GHCEOODJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x68D1430", Offset = "0x68CFC30", VA = "0x1868D1430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IPOIDOLGAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x68D4450", Offset = "0x68D2C50", VA = "0x1868D4450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void PMIEILDEGCG(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE, string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x68D1960", Offset = "0x68D0160", VA = "0x1868D1960", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x68D35A0", Offset = "0x68D1DA0", VA = "0x1868D35A0")]
	public void KLACAKIKHIA(int KOMAPJMJKFA, int MNEHNMJHPCD, Allocator KCJKALFMGMC, bool CANLONBPNON, bool BBCFFDOIDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x68D4340", Offset = "0x68D2B40", VA = "0x1868D4340")]
	public void OECINNJFDMC(int KOMAPJMJKFA, int MNEHNMJHPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x68D4440", Offset = "0x68D2C40", VA = "0x1868D4440", Slot = "6")]
	public bool OKMLAHOBIHP(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x68D0760", Offset = "0x68CEF60", VA = "0x1868D0760")]
	public bool CIBNBNKPMKG(Mesh NCHKGMDMAMN, bool FINBKLOIOHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x68D0C20", Offset = "0x68CF420", VA = "0x1868D0C20")]
	public bool DALEIGAICMC(Mesh NCHKGMDMAMN, ACMLDDOGEBP IIEFCLDOHLB, bool FINBKLOIOHP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x68D1AF0", Offset = "0x68D02F0", VA = "0x1868D1AF0")]
	public void GEHOMJBODHP(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x68CF9A0", Offset = "0x68CE1A0", VA = "0x1868CF9A0")]
	public void AHPPOLCDBAB(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x68D4570", Offset = "0x68D2D70", VA = "0x1868D4570")]
	[BurstCompile]
	public static int PCPHBIHHMEP(float PNGIKMLKECD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x68D4520", Offset = "0x68D2D20", VA = "0x1868D4520")]
	[BurstCompile]
	public static uint PCPHBIHHMEP([In] float4 BLNBBLFAAGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x68D44D0", Offset = "0x68D2CD0", VA = "0x1868D44D0")]
	[BurstCompile]
	public static uint PCPHBIHHMEP([In] float3 BLNBBLFAAGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x68D45C0", Offset = "0x68D2DC0", VA = "0x1868D45C0")]
	public void PPLJAAHNDOJ(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x68D1A70", Offset = "0x68D0270", VA = "0x1868D1A70")]
	[BurstCompile]
	private unsafe static void FOMBJDJFHLF([NoAlias] CMALJDEBDNC* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x68D38C0", Offset = "0x68D20C0", VA = "0x1868D38C0")]
	public void MKOLGCPDOBK(Mesh NCHKGMDMAMN, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x68D43C0", Offset = "0x68D2BC0", VA = "0x1868D43C0")]
	[BurstCompile]
	private unsafe static void OKDFDBHAMKF([NoAlias] BKGHCMONOIG* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x68D37D0", Offset = "0x68D1FD0", VA = "0x1868D37D0")]
	public void LFMDAKOEIFA(Mesh NCHKGMDMAMN, NKNGCAILIBP NFAJBIAKHPK, bool FINBKLOIOHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x68D0420", Offset = "0x68CEC20", VA = "0x1868D0420")]
	public void AJBCBEPOLBC(ACMLDDOGEBP NCHKGMDMAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x68D1470", Offset = "0x68CFC70", VA = "0x1868D1470")]
	public ACMLDDOGEBP DBMPDAIGBHO(Allocator KCJKALFMGMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x68D3410", Offset = "0x68D1C10", VA = "0x1868D3410")]
	public long JIINFKCJHJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x68D3540", Offset = "0x68D1D40", VA = "0x1868D3540")]
	public static long JIINFKCJHJE(int MNJGMDAJBAJ, int HAECDOCFNDF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x68D2C50", Offset = "0x68D1450", VA = "0x1868D2C50")]
	public static long GLKDLANLEGN(int MNJGMDAJBAJ, int HAECDOCFNDF, NKNGCAILIBP NFAJBIAKHPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x68D2B90", Offset = "0x68D1390", VA = "0x1868D2B90")]
	public long GLKDLANLEGN(NKNGCAILIBP NFAJBIAKHPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x68D3340", Offset = "0x68D1B40", VA = "0x1868D3340")]
	public void JBKDEECKHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x68D2CF0", Offset = "0x68D14F0", VA = "0x1868D2CF0")]
	public static void HFNIPEDGBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x68D2540", Offset = "0x68D0D40", VA = "0x1868D2540")]
	public NKNGCAILIBP GLJFBCNIEKK()
	{
		return default(NKNGCAILIBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x68D0690", Offset = "0x68CEE90", VA = "0x1868D0690")]
	public static (int, int) CCIKENNKNLN(Mesh NCHKGMDMAMN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x68D0B40", Offset = "0x68CF340", VA = "0x1868D0B40")]
	public static int DABFMKLNFKN(VertexAttributeDescriptor[] AEAOLAFDKMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x68D33A0", Offset = "0x68D1BA0", VA = "0x1868D33A0")]
	public static long JGHELINOFJL(Mesh NCHKGMDMAMN, int IGHFLDLCFPH, int BKPGLEACJPI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ACMLDDOGEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x68D32A0", Offset = "0x68D1AA0", VA = "0x1868D32A0")]
	[BurstCompile]
	public static int HKGKADLPFJH(float PNGIKMLKECD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x68D3060", Offset = "0x68D1860", VA = "0x1868D3060")]
	[BurstCompile]
	public static uint HKGKADLPFJH([In] float4 BLNBBLFAAGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x68D31F0", Offset = "0x68D19F0", VA = "0x1868D31F0")]
	[BurstCompile]
	public static uint HKGKADLPFJH([In] float3 BLNBBLFAAGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x68D15B0", Offset = "0x68CFDB0", VA = "0x1868D15B0")]
	[BurstCompile]
	public unsafe static void DIAGOHFGLGN([NoAlias] CMALJDEBDNC* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x68D3EF0", Offset = "0x68D26F0", VA = "0x1868D3EF0")]
	[BurstCompile]
	public unsafe static void NIHAJKANBGE([NoAlias] BKGHCMONOIG* CJFGCHOCKHA, int NMHMJGBBGAD, [In][NoAlias] float3* CABOKLKJMPK, [In][NoAlias] float3* OENPFFJCFJD, [In][NoAlias] float4* OMHPGEPCIGG, [In][NoAlias] float2* MNKECMGPDML, [In][NoAlias] float4* GAFKCNKDFGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class HLBLACPOJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x68D7110", Offset = "0x68D5910", VA = "0x1868D7110")]
	public static void OCACGGKKNLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class LGEOJGJCPFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> MBBNFLNGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> NNCGHPJGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> FLPHPEPKEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> PEDHANNIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> BMGLIPCMBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> OAODFMMJFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> PDNEPPHGKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> DGJNBEPEBAE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CNNODONBCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x68D8EA0", Offset = "0x68D76A0", VA = "0x1868D8EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int GHCEOODJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x68D8300", Offset = "0x68D6B00", VA = "0x1868D8300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NADIGONLJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x68D8450", Offset = "0x68D6C50", VA = "0x1868D8450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x68D8EE0", Offset = "0x68D76E0", VA = "0x1868D8EE0")]
	public LGEOJGJCPFC(int KOMAPJMJKFA, int MNEHNMJHPCD, int MJJFIOEAPNB, Allocator KCJKALFMGMC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x68D91B0", Offset = "0x68D79B0", VA = "0x1868D91B0")]
	public LGEOJGJCPFC(Mesh NCHKGMDMAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x68D8340", Offset = "0x68D6B40", VA = "0x1868D8340", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x68D8000", Offset = "0x68D6800", VA = "0x1868D8000")]
	public void AJBCBEPOLBC(LGEOJGJCPFC NCHKGMDMAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x68D8490", Offset = "0x68D6C90", VA = "0x1868D8490")]
	private void JBEDJBEKLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x68D8920", Offset = "0x68D7120", VA = "0x1868D8920")]
	private void LFINDEOMKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IGHELALFNHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int CBMBLHDBGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int CNNODONBCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int PNOOPFPEAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int GHCEOODJMGL;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x13A6F00", Offset = "0x13A5700", VA = "0x1813A6F00")]
	public IGHELALFNHK(int ODEDMBGPBKA, int NMHMJGBBGAD, int JDPLFEPKJAC, int MPDAAIPLJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FINCPPIDEDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<IGHELALFNHK> GJHOFBDEMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<IGHELALFNHK>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9616D0", Offset = "0x95FED0", VA = "0x1809616D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LGEOJGJCPFC LNCDMKOIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x68D6AC0", Offset = "0x68D52C0", VA = "0x1868D6AC0")]
	public FINCPPIDEDD(IEnumerable<LGEOJGJCPFC> PILJPIMHJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x68D6A50", Offset = "0x68D5250", VA = "0x1868D6A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum NOOMKDNGADN
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class FHMNCONDJIL
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> BPNOJJKDIBL;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> NNGLEMJAFJA;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> MBBLKIIHMGC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> HEPNMHGKJMI;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x68D6940", Offset = "0x68D5140", VA = "0x1868D6940")]
	public static void OCACGGKKNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x68D6840", Offset = "0x68D5040", VA = "0x1868D6840")]
	public static NativeArray<float2> IMDBALFHGIK(NativeArray<float2> OFMJGLKGPHN, int HAKPBKJIAMG, NativeArray<float2> GGBDPHPALJL, int AFIPOFPIKJM)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x68D6640", Offset = "0x68D4E40", VA = "0x1868D6640")]
	public static NativeArray<float3> HLEICAIMDEG(NativeArray<float3> OFMJGLKGPHN, int HAKPBKJIAMG, NativeArray<float3> GGBDPHPALJL, int AFIPOFPIKJM)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x68D6740", Offset = "0x68D4F40", VA = "0x1868D6740")]
	public static NativeArray<float4> IGDDOGLDEDP(NativeArray<float4> OFMJGLKGPHN, int HAKPBKJIAMG, NativeArray<float4> GGBDPHPALJL, int AFIPOFPIKJM)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x68D6540", Offset = "0x68D4D40", VA = "0x1868D6540")]
	public static NativeArray<int> CHJFNNDOBJL(NativeArray<int> OFMJGLKGPHN, int HAKPBKJIAMG, NativeArray<int> GGBDPHPALJL, int AFIPOFPIKJM)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A70990", Offset = "0x2A6F190", VA = "0x182A70990")]
	private static void MFNJJJMLNDH<T>(NativeArray<T> JAOFFCELONG, int NAJEHJOJFMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A70B90", Offset = "0x2A6F390", VA = "0x182A70B90")]
	private static void NGCJAAJFLKL<T>(NativeArray<T> OFMJGLKGPHN, int HAKPBKJIAMG, NativeArray<T> GGBDPHPALJL, int AFIPOFPIKJM, NativeArray<T> BCDMAMFOLDE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class NHHKEGDOALD
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum KPEDHPPBDKH
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
	public class GEAEBLDOFEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public PEIPAMFJHOL NCHKGMDMAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int GEFNGEMPMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int ABCFNLJFIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long FMCMCOLIONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long DEJBKDLFANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float FIDFGFEJDNJ;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x68D70C0", Offset = "0x68D58C0", VA = "0x1868D70C0")]
		public GEAEBLDOFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x68D7080", Offset = "0x68D5880", VA = "0x1868D7080")]
		public void LDBBLMGLBBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string PNPDFAEEJPE;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string ELMJEPBGDEH;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker ONGGNLMJEMO;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker OMMDKACCBLI;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker EJANEHGDFMA;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker JPHNNDICDFI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker CFONFFOLHLG;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker GGJGMMEBCGA;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker FGIAMJKDMHK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker KOAGBKBHLHH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker NOMHEKPMDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker IPBPBEGGODP;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker DKGJOODNKLD;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker LCDCCPBDIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<KNGGMHOMCBP> MALBEOPJKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly GCDKEKMPKHA PHBPAHCAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NMHMJGBBGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int MPDAAIPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool ENPKKDFNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool KFFDBPNBPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal KPEDHPPBDKH DAGLKLOEBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool NPMCHMOEHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 GNCDJCPHDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 LNNNDFCEAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float DFKLOFLGIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float JEFCGENEGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int EGJDKIGNJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int KNDGHMPFGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int HBIIBOPGPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int NOIAKNNCHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float CIKKDCBIFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float IBMPACJINPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int LKOHOPKGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long MEAGCNNFPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long DIPPMOGFIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long EADLPNMHNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int JMNKLFPDIKA;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int IJGIBFNDKBN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] CAKDJCPJJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] MBDNHIFDJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] EMFHJDHNHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private ACMLDDOGEBP KEOPLFENAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long ADOOBDGKDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long BBFFNKJBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int LLPPNMIGDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<GEAEBLDOFEB> JHKFDKFFBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float DFBODKJFHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal ACMLDDOGEBP.NKNGCAILIBP DMCHIJBMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool HGOEMDICLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private OPANNDDCLFB DOOCPPBDICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle NDBHBAMNGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> JKHGLBPLIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool PMDHNOAFMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle JNNBLBEBHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private ACMLDDOGEBP NPDDIDMGEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform CIOOHEPECAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private MEAEHDGGOMD POFFIFCCBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long GOJMILNGFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long JPAHNGDCPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long LHKGLEHAFMA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh LNCDMKOIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84A250", Offset = "0x848A50", VA = "0x18084A250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer FLJDIKLNDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int OECBKDDCLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8B20A0", Offset = "0x8B08A0", VA = "0x1808B20A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DELBHFLLNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xBF3E00", Offset = "0xBF2600", VA = "0x180BF3E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int CNNODONBCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x68E3460", Offset = "0x68E1C60", VA = "0x1868E3460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<KNGGMHOMCBP> KKDEPCDHJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void PMIEILDEGCG(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE, string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x68D9650", Offset = "0x68D7E50", VA = "0x1868D9650")]
	public void AJLBIILCPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x68E21F0", Offset = "0x68E09F0", VA = "0x1868E21F0")]
	private void KNHBIGFJOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x68E3850", Offset = "0x68E2050", VA = "0x1868E3850")]
	public NHHKEGDOALD(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x68E27F0", Offset = "0x68E0FF0", VA = "0x1868E27F0")]
	public void LDBBLMGLBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x68E0560", Offset = "0x68DED60", VA = "0x1868E0560")]
	public void IFMMGLEKDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x68DC360", Offset = "0x68DAB60", VA = "0x1868DC360")]
	private void CHAOMABHAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x68E2620", Offset = "0x68E0E20", VA = "0x1868E2620")]
	public void LBIGDMPJGJN(KNGGMHOMCBP IPHPGFIOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x68DE1F0", Offset = "0x68DC9F0", VA = "0x1868DE1F0")]
	public bool FACFPGENNPO(KNGGMHOMCBP IPHPGFIOHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x68DF930", Offset = "0x68DE130", VA = "0x1868DF930")]
	public bool HFKAHFAOINF(KNGGMHOMCBP IPHPGFIOHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x68DD010", Offset = "0x68DB810", VA = "0x1868DD010", Slot = "4")]
	public virtual void EECOMDOKODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x68E2970", Offset = "0x68E1170", VA = "0x1868E2970")]
	public void LPFHFHADNNI(Transform EJFALKKEFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x68E1B00", Offset = "0x68E0300", VA = "0x1868E1B00")]
	private long JCIOBJCBFCC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x68DF790", Offset = "0x68DDF90", VA = "0x1868DF790")]
	private long GOAOPOJLJJM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x68DD0C0", Offset = "0x68DB8C0", VA = "0x1868DD0C0")]
	public bool EPOEELFHMEE(Transform EJFALKKEFHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x68DE290", Offset = "0x68DCA90", VA = "0x1868DE290")]
	public bool FAFOPKCOIED(bool EJMIAAKMEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x68E1BE0", Offset = "0x68E03E0", VA = "0x1868E1BE0")]
	public void JEMMPBDHDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x68DAC40", Offset = "0x68D9440", VA = "0x1868DAC40")]
	public bool BDLJKEMBIDI(float4x4 JHDLHPHDGCE, BatchedMeshRenderer GOBCMLAPOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x68DCDB0", Offset = "0x68DB5B0", VA = "0x1868DCDB0")]
	public void DHNDAAMGFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x68E2BC0", Offset = "0x68E13C0", VA = "0x1868E2BC0")]
	public bool MDJNJBLKKGA(bool EJMIAAKMEGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x68E3450", Offset = "0x68E1C50", VA = "0x1868E3450")]
	public void OHPOOGJPKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x68E2940", Offset = "0x68E1140", VA = "0x1868E2940")]
	public void LPDFPIDCPLC(ACMLDDOGEBP NCHKGMDMAMN, int HPPDKDADHJB, int NPBPOLAICNG, float PJMDEGJEBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x68E2910", Offset = "0x68E1110", VA = "0x1868E2910")]
	public void LGHMFPJMEKB(PEIPAMFJHOL DIDPKJEBAPC, int HPPDKDADHJB, int NPBPOLAICNG, float PJMDEGJEBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x68E1DD0", Offset = "0x68E05D0", VA = "0x1868E1DD0")]
	public (long, long, long) JIINFKCJHJE()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xA2E350", Offset = "0xA2CB50", VA = "0x180A2E350")]
	public long GLIOKFFKNNB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x68DF5F0", Offset = "0x68DDDF0", VA = "0x1868DF5F0")]
	private void FECOKLPIFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x68DA880", Offset = "0x68D9080", VA = "0x1868DA880")]
	public (long, long) AOJGBNLMIOJ(float NINLDODHIMH, float4x4 JHDLHPHDGCE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	public void IHKEJDNJGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x68DC240", Offset = "0x68DAA40", VA = "0x1868DC240")]
	internal void CECBPEOGHKC(KPEDHPPBDKH MDDFPDKFFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x68DF990", Offset = "0x68DE190", VA = "0x1868DF990")]
	private (float, float, float) HOBPGCKFEKE(float KFGJKAFKLAA, float4x4 JHDLHPHDGCE)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x68E1E40", Offset = "0x68E0640", VA = "0x1868E1E40")]
	private (int, int) KLKAPHIBOAN(float KGBKKEJPBBE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x68D9660", Offset = "0x68D7E60", VA = "0x1868D9660")]
	public void AMEAPAMDDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x68DF900", Offset = "0x68DE100", VA = "0x1868DF900")]
	private void HDOGCCOPHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x68E2F40", Offset = "0x68E1740", VA = "0x1868E2F40")]
	private void NAKGLLCHMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x68DC5F0", Offset = "0x68DADF0", VA = "0x1868DC5F0")]
	public long CLPHMJGCAPB(long BHNLGAELPNE, int OKAIKNJKBOP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x68E1200", Offset = "0x68DFA00", VA = "0x1868E1200")]
	private void IMKFLEKFKGM(ACMLDDOGEBP FAEAHFOAAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x68E3120", Offset = "0x68E1920", VA = "0x1868E3120")]
	private void NKENMONJKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x68E05F0", Offset = "0x68DEDF0", VA = "0x1868E05F0")]
	private void IKCPBMKMHOD(ACMLDDOGEBP NCHKGMDMAMN, PEIPAMFJHOL DIDPKJEBAPC, int HPPDKDADHJB, int NPBPOLAICNG, float PJMDEGJEBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct OPANNDDCLFB : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct DOBAFKIMBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int GKCMDMGCKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int LNBFDKMNFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int BILDDKJIGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int GBNBOBJIOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int GBNDPDIKPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int ICFLGKEKDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int GEFNGEMPMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int ABCFNLJFIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float FIDFGFEJDNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct EEGHFDDHOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public DAPPNCDAIFA.CACMNLBJJCD AMDBOFMHCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float HLCBLHMEOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float KDHHAGHKAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float BGGCOCNDMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float DABNFKKEJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float DBKOGKABCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float GKLNIPGAEOO;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct NOIGEOGIDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> MBBNFLNGILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> NNCGHPJGMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> DJEKCAJLFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> FFFFFLHPNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> KLPMNOIILDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> DGJNBEPEBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool DODFGBELADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int CNNODONBCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int GHCEOODJMGL;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x68F00E0", Offset = "0x68EE8E0", VA = "0x1868F00E0")]
		public void KLACAKIKHIA(int KOMAPJMJKFA, int MNEHNMJHPCD, Allocator KCJKALFMGMC, bool BBCFFDOIDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x68EFE90", Offset = "0x68EE690", VA = "0x1868EFE90")]
		public static NOIGEOGIDJJ AGBKIIKOFFF(ACMLDDOGEBP AMBKIFNGGDN)
		{
			return default(NOIGEOGIDJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x68F02C0", Offset = "0x68EEAC0", VA = "0x1868F02C0")]
		public void LDBBLMGLBBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker FFOFCBCFCHM;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker KEGDCCKNOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<DOBAFKIMBPB> BAKENNGGKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NOIGEOGIDJJ JCDAPPMIMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NOIGEOGIDJJ FAEAHFOAAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 IHDJNLEAGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 PNCFGFCNBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private EEGHFDDHOFA GHCHEHLLECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* NNCAJKNAOOK;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	[BurstDiscard]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	[BurstDiscard]
	private static void PMIEILDEGCG(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	[BurstDiscard]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE, string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x68E5B80", Offset = "0x68E4380", VA = "0x1868E5B80")]
	public OPANNDDCLFB([In] List<NHHKEGDOALD.GEAEBLDOFEB> OIJBEOGFJLG, [In] ACMLDDOGEBP LOLDDOMNLAA, [In] NHHKEGDOALD MBDBLDLDKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x68E3C20", Offset = "0x68E2420", VA = "0x1868E3C20", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x68E3C70", Offset = "0x68E2470", VA = "0x1868E3C70")]
	public void GCMEGAMBDJC(List<NHHKEGDOALD.GEAEBLDOFEB> MNBEIHNPMLE, [In] NHHKEGDOALD MBDBLDLDKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x68E3B30", Offset = "0x68E2330", VA = "0x1868E3B30")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool AIMHHBJKPBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x68E3B50", Offset = "0x68E2350", VA = "0x1868E3B50")]
	private PEIPAMFJHOL CPMOBEAHECI(int ABAACFLHMEC, Allocator KCJKALFMGMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x68E4330", Offset = "0x68E2B30", VA = "0x1868E4330")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void JPBLAAAGFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x68E5680", Offset = "0x68E3E80", VA = "0x1868E5680")]
	[IgnoreWarning(1371)]
	private DOBAFKIMBPB LDCACDLFBIO([In] DOBAFKIMBPB OIKAPBADJCP, int FCJLHODMNOH, [In] NativeArray<int> KCIMAGJGHOK, [In] NativeArray<bool> KIILMPHPGHJ, NativeArray<int> HHOMMIEKNFG)
	{
		return default(DOBAFKIMBPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x68E59F0", Offset = "0x68E41F0", VA = "0x1868E59F0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int OIJHBPPHNJO(NativeArray<int> KCIMAGJGHOK, int LEOIHFNNHIE, int JAGIEEPOCAD, int FIFMEHEDNHE)
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
		public static readonly MMJHHDEPGMK log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker GHMLAIDGDAG;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker FKAAHMNKLGH;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker CGAMOEBCHGH;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker BPOGLEOCLEG;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker GAFEBLGPKDE;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker CFONFFOLHLG;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker GPAHANEHKFI;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int MEJBJKPFNLN = 65000;

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
		private Dictionary<Material, List<NHHKEGDOALD>> OLGEMNCFMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<NHHKEGDOALD> PPIDNDLNOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> DKMDLHGFCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool FCEGODPNJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool KBBAEPIPFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int AHPPGEONPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> KGANGCLEFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> GFNNAHNNHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> HMMOANFBKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> IEHDJAFMDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private NHHKEGDOALD PGBKBOLLJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material APPAHINADKA;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int IFJKKNIKHBK = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, KNGGMHOMCBP)> CGICFJBMMIM;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> JBPBGLIFGEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int LPOCHKFDDLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x68EBE40", Offset = "0x68EA640", VA = "0x1868EBE40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		private static void HKIBOFLLJOP(bool GEOJHPFHNEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		private static void HKIBOFLLJOP(bool GEOJHPFHNEE, string CLBGCJICGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x68E87F0", Offset = "0x68E6FF0", VA = "0x1868E87F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x68E68F0", Offset = "0x68E50F0", VA = "0x1868E68F0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x68E6360", Offset = "0x68E4B60", VA = "0x1868E6360")]
		public NHHKEGDOALD AddToBatchedMesh(KNGGMHOMCBP BEEJOPOKEOM, Material CLECAFFDEAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x68EAF50", Offset = "0x68E9750", VA = "0x1868EAF50")]
		public void RemoveFromBatchedMesh(KNGGMHOMCBP NCHKGMDMAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x68E67C0", Offset = "0x68E4FC0", VA = "0x1868E67C0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x68EB740", Offset = "0x68E9F40", VA = "0x1868EB740")]
		public void SetMaterialProperty(int BCCOFCDHGPL, Color NLKAPPNAHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x68EB2F0", Offset = "0x68E9AF0", VA = "0x1868EB2F0")]
		public void SetMaterialProperty(int BCCOFCDHGPL, float IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x68EB510", Offset = "0x68E9D10", VA = "0x1868EB510")]
		public void SetMaterialProperty(int BCCOFCDHGPL, Vector4 BEBBIKFGHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x68EB090", Offset = "0x68E9890", VA = "0x1868EB090")]
		public void SetMaterialProperty(int BCCOFCDHGPL, Matrix4x4 AODGAKEHHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x68E7620", Offset = "0x68E5E20", VA = "0x1868E7620")]
		private void HHNHGDJOBMA(Renderer GEPBJGBCLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x68E7010", Offset = "0x68E5810", VA = "0x1868E7010")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x68E7000", Offset = "0x68E5800", VA = "0x1868E7000")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x68E6AB0", Offset = "0x68E52B0", VA = "0x1868E6AB0")]
		private void FFEBCFGMDAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x68E7C10", Offset = "0x68E6410", VA = "0x1868E7C10")]
		private NHHKEGDOALD LCIFAIMMEAF(KNGGMHOMCBP NCHKGMDMAMN, Material CLECAFFDEAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x68E6460", Offset = "0x68E4C60", VA = "0x1868E6460")]
		private NHHKEGDOALD BKOFMGLGAIN(Material CLECAFFDEAA, int DKILACINBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x68E7EA0", Offset = "0x68E66A0", VA = "0x1868E7EA0")]
		private NHHKEGDOALD LPPOOJCJHEL(Material CLECAFFDEAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1862EE0", Offset = "0x18616E0", VA = "0x181862EE0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x68E82D0", Offset = "0x68E6AD0", VA = "0x1868E82D0")]
		public void MarkDirty(KNGGMHOMCBP NCHKGMDMAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x68E8430", Offset = "0x68E6C30", VA = "0x1868E8430")]
		public (long, long) MemorySizeInBytesForChosenDetail(float NINLDODHIMH)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x68E9FF0", Offset = "0x68E87F0", VA = "0x1868E9FF0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x68E70B0", Offset = "0x68E58B0", VA = "0x1868E70B0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x68E8AE0", Offset = "0x68E72E0", VA = "0x1868E8AE0")]
		public void RebatchOptimally(int OJDDOHNEFFG, int IEFCHCIEHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x68EBBD0", Offset = "0x68EA3D0", VA = "0x1868EBBD0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class NDNHLENKHOI
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct LHMCMGICBFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float PNLPPPCKGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer NMKBFPEJHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public NHHKEGDOALD PNJNNJPPBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long MCJNINCHKKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class PPJOJHCCABO : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8E2F50", Offset = "0x8E1750", VA = "0x1808E2F50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x68F1170", Offset = "0x68EF970", VA = "0x1868F1170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xF8CCE0", Offset = "0xF8B4E0", VA = "0x180F8CCE0")]
		[DebuggerHidden]
		public PPJOJHCCABO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x68F11C0", Offset = "0x68EF9C0", VA = "0x1868F11C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x68F03D0", Offset = "0x68EEBD0", VA = "0x1868F03D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x68F1020", Offset = "0x68EF820", VA = "0x1868F1020")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x68F0380", Offset = "0x68EEB80", VA = "0x1868F0380")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x68F1120", Offset = "0x68EF920", VA = "0x1868F1120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x68F1070", Offset = "0x68EF870", VA = "0x1868F1070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x68F1070", Offset = "0x68EF870", VA = "0x1868F1070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker CFONFFOLHLG;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker HFEDCPIKLBK;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker AJIAHHKAGOH;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker ECOKCPCMDAI;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 AAPPEDPNMPK;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int OCKLOAMFDFD;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int HGFCCKIJMOJ;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int POKFHGNDCFJ;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int JKAJEIIKBJI;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int CGKFOLIKJEE;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int DKKADDNCABJ;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int CDNEPLHEFGC;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int ACOEMBNBFLK;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int CDNJACNPMPI;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int NCBHHHLBPDO;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int HMKAGMPMOKJ;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int MGMKDFKIKJH;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int AFIAPLGFAJH;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int EJIPKIHEOOG;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long DEOIGFDJBDH;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long FPCJDMAJAIH;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int IAJNLGJGDIP;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int AMBKIKCDIEE;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int ANDKKPHHBMA;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long FKCLPLFMBDD;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool MKBAOACAHJB;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> KFFEINHALJG;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<LHMCMGICBFK> BHJIKKAIBKH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool IFLIKMNCFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x68EF710", Offset = "0x68EDF10", VA = "0x1868EF710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void PMIEILDEGCG(bool GEOJHPFHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void HKIBOFLLJOP(bool GEOJHPFHNEE, string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x68EF360", Offset = "0x68EDB60", VA = "0x1868EF360")]
	public static void LMDILLFIIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x68EE6F0", Offset = "0x68ECEF0", VA = "0x1868EE6F0")]
	public static void BELFMEBLBKA(BatchedMeshRenderer KCHKJBJBPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x68EF500", Offset = "0x68EDD00", VA = "0x1868EF500")]
	public static void MGNEEFCJHNK(BatchedMeshRenderer KCHKJBJBPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x68EBE90", Offset = "0x68EA690", VA = "0x1868EBE90")]
	private static (long, long, long) AIDKBAMLLPN(long KNEJFFDFPFJ)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x68EC170", Offset = "0x68EA970", VA = "0x1868EC170")]
	public static void BDLJKEMBIDI(long KNEJFFDFPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x68EE940", Offset = "0x68ED140", VA = "0x1868EE940")]
	public static long CLPHMJGCAPB(long BHNLGAELPNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x68EF0B0", Offset = "0x68ED8B0", VA = "0x1868EF0B0")]
	public static void JHHJFEAFHBO(NHHKEGDOALD PNJNNJPPBCD, BatchedMeshRenderer NMKBFPEJHPD, long MCJNINCHKKI, float PNLPPPCKGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x68EEFB0", Offset = "0x68ED7B0", VA = "0x1868EEFB0")]
	public static void JECJEMJKPFA(NHHKEGDOALD PNJNNJPPBCD, BatchedMeshRenderer NMKBFPEJHPD, long MCJNINCHKKI, float IOCJOJDPMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x68EF250", Offset = "0x68EDA50", VA = "0x1868EF250")]
	public static void JLNJDGHIAOH(NHHKEGDOALD PNJNNJPPBCD, BatchedMeshRenderer NMKBFPEJHPD, long MCJNINCHKKI, float IOCJOJDPMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x68EECD0", Offset = "0x68ED4D0", VA = "0x1868EECD0")]
	public static void ELCCGEMGJFH(NHHKEGDOALD PNJNNJPPBCD, BatchedMeshRenderer NMKBFPEJHPD, long MCJNINCHKKI, float PNLPPPCKGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x68EF7A0", Offset = "0x68EDFA0", VA = "0x1868EF7A0")]
	public static float OMPMPBKDIKE(long BGKIJIPIOFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x68EBFA0", Offset = "0x68EA7A0", VA = "0x1868EBFA0")]
	public static (long, long) AOJGBNLMIOJ(float NINLDODHIMH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x68EF1C0", Offset = "0x68ED9C0", VA = "0x1868EF1C0")]
	[IteratorStateMachine(typeof(PPJOJHCCABO))]
	public static IEnumerable<bool> JJCAFPJOKID(long KJPFNFHMBOB, bool KAMMADMHMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x68EF5A0", Offset = "0x68EDDA0", VA = "0x1868EF5A0")]
	public static void MIGKOMIBCJH(long KJPFNFHMBOB, bool KAMMADMHMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x68EEE70", Offset = "0x68ED670", VA = "0x1868EEE70")]
	public static int HDIFKEOFFID()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class OGBODMBJDIN<KeyType> : NHHKEGDOALD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, KNGGMHOMCBP> EILDMJJJBAL;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4558620", Offset = "0x4556E20", VA = "0x184558620")]
	public OGBODMBJDIN(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x45582C0", Offset = "0x4556AC0", VA = "0x1845582C0")]
	public void LBIGDMPJGJN(KeyType JOEHGGMHBAA, KNGGMHOMCBP IPHPGFIOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4558330", Offset = "0x4556B30", VA = "0x184558330")]
	public bool OCEPINIMACA(KeyType JOEHGGMHBAA, KNGGMHOMCBP CBMOCJLBNDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4558100", Offset = "0x4556900", VA = "0x184558100")]
	public void IDOHOJHEGHD(KeyType JOEHGGMHBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x45580A0", Offset = "0x45568A0", VA = "0x1845580A0", Slot = "4")]
	public override void EECOMDOKODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x68F12E0", Offset = "0x68EFAE0", VA = "0x1868F12E0")]
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
