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
using UnityEngine.Pool;
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85961A0", Offset = "0x8594BA0", VA = "0x1885961A0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class OJPGNEFCODO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly OLFEOKKCIEG COMGPMCIINE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly OLFEOKKCIEG HAJLDOHAELJ;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OLFEOKKCIEG NCPJBBAJIFA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly OLFEOKKCIEG NCAHCLDKADA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly OLFEOKKCIEG HAEEMNDJPCL;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class EGHFPBIKHCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public LDODGKLHIIE HPKKCNLEGJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FIFGJMDPIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EGHFPBIKHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct LDODGKLHIIE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MHAJDNAPBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half LPPENPFCLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort EJBIKALCLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte BOJMJDHJCHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void KPBALJDMFNJ([NoAlias] float3* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class MJNMFJDCHNL
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8597F40", Offset = "0x8596940", VA = "0x188597F40")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8598070", Offset = "0x8596A70", VA = "0x188598070")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8597C60", Offset = "0x8596660", VA = "0x188597C60")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8597D10", Offset = "0x8596710", VA = "0x188597D10")]
		public unsafe static void KDMGDDCNHFD([NoAlias] float3* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void LENADIAONMG([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class OHPLHKBKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x859B420", Offset = "0x8599E20", VA = "0x18859B420")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x859B550", Offset = "0x8599F50", VA = "0x18859B550")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x859B0C0", Offset = "0x8599AC0", VA = "0x18859B0C0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x859B170", Offset = "0x8599B70", VA = "0x18859B170")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void GPIPPMJFMDK([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class PDMBADDJCBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x859CB50", Offset = "0x859B550", VA = "0x18859CB50")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x859CC80", Offset = "0x859B680", VA = "0x18859CC80")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x859C7F0", Offset = "0x859B1F0", VA = "0x18859C7F0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x859C8A0", Offset = "0x859B2A0", VA = "0x18859C8A0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void HLALJLKDHAD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class DJCAIKBGGAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8586170", Offset = "0x8584B70", VA = "0x188586170")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85862A0", Offset = "0x8584CA0", VA = "0x1885862A0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8585E10", Offset = "0x8584810", VA = "0x188585E10")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8585EC0", Offset = "0x85848C0", VA = "0x188585EC0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void EGBIEPMOCBK([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class DPDNGEGLGOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8586DD0", Offset = "0x85857D0", VA = "0x188586DD0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8586F00", Offset = "0x8585900", VA = "0x188586F00")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8586A70", Offset = "0x8585470", VA = "0x188586A70")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8586B20", Offset = "0x8585520", VA = "0x188586B20")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void FBBJBEBMLNC([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class JHKHOGOFDEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x858C9D0", Offset = "0x858B3D0", VA = "0x18858C9D0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x858CB00", Offset = "0x858B500", VA = "0x18858CB00")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x858C5E0", Offset = "0x858AFE0", VA = "0x18858C5E0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x858C690", Offset = "0x858B090", VA = "0x18858C690")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void MBDDIHHJJCF([NoAlias] ushort* KJCHCDAMMMI, [Out] float3 KDMFNIENOEF, [Out] float3 MEDKICHPJJC, [In][NoAlias] float3* BJDOKIDGHIH, int OJLPMHPHFKE, int MIOAPJGCBLG);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class NDOHGGHHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8599E00", Offset = "0x8598800", VA = "0x188599E00")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8599F30", Offset = "0x8598930", VA = "0x188599F30")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8599B10", Offset = "0x8598510", VA = "0x188599B10")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8599BC0", Offset = "0x85985C0", VA = "0x188599BC0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] ushort* KJCHCDAMMMI, [Out] float3 KDMFNIENOEF, [Out] float3 MEDKICHPJJC, [In][NoAlias] float3* BJDOKIDGHIH, int OJLPMHPHFKE, int MIOAPJGCBLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void EGLGFBEKOKP([NoAlias] ushort* PJBHFHPPPML, [In][NoAlias] float3* CLFFINNCAMJ, int MIOAPJGCBLG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class CHGFLDHIPEK
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x857D0E0", Offset = "0x857BAE0", VA = "0x18857D0E0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x857D210", Offset = "0x857BC10", VA = "0x18857D210")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x857CE20", Offset = "0x857B820", VA = "0x18857CE20")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x857CED0", Offset = "0x857B8D0", VA = "0x18857CED0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] ushort* PJBHFHPPPML, [In][NoAlias] float3* CLFFINNCAMJ, int MIOAPJGCBLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void COFLAGHJPLG([NoAlias] float3* DBEJJFBLJKP, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class IJKFCGEOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x858A880", Offset = "0x8589280", VA = "0x18858A880")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x858A9B0", Offset = "0x85893B0", VA = "0x18858A9B0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x858A5C0", Offset = "0x8588FC0", VA = "0x18858A5C0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x858A670", Offset = "0x8589070", VA = "0x18858A670")]
		public unsafe static void KDMGDDCNHFD([NoAlias] float3* DBEJJFBLJKP, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void JEFJEPOEGOG([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class FDBBPGFLAIN
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85882A0", Offset = "0x8586CA0", VA = "0x1885882A0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85883D0", Offset = "0x8586DD0", VA = "0x1885883D0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8587FE0", Offset = "0x85869E0", VA = "0x188587FE0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8588090", Offset = "0x8586A90", VA = "0x188588090")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void ENPNOOFAOCB([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class JDIDAIAKPGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x858C350", Offset = "0x858AD50", VA = "0x18858C350")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x858C480", Offset = "0x858AE80", VA = "0x18858C480")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x858BFA0", Offset = "0x858A9A0", VA = "0x18858BFA0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x858C050", Offset = "0x858AA50", VA = "0x18858C050")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void EFJJGONJIAG([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class FHDOHFOGLAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85888E0", Offset = "0x85872E0", VA = "0x1885888E0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8588A10", Offset = "0x8587410", VA = "0x188588A10")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8588530", Offset = "0x8586F30", VA = "0x188588530")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85885E0", Offset = "0x8586FE0", VA = "0x1885885E0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void CJEPPKOBONM([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class CBNKALNCIIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x857C550", Offset = "0x857AF50", VA = "0x18857C550")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x857C680", Offset = "0x857B080", VA = "0x18857C680")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x857C170", Offset = "0x857AB70", VA = "0x18857C170")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x857C220", Offset = "0x857AC20", VA = "0x18857C220")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void OLDHCMOAFGO([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class APOMKAIDIIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x857AC20", Offset = "0x8579620", VA = "0x18857AC20")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x857AD50", Offset = "0x8579750", VA = "0x18857AD50")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x857A840", Offset = "0x8579240", VA = "0x18857A840")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x857A8F0", Offset = "0x85792F0", VA = "0x18857A8F0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void KPEGFALFAGG([NoAlias] uint* KFPCJJHHFCF, [Out] float2 EGBIKALMIMO, [Out] float2 CMEKBCKEHIJ, [In][NoAlias] float2* FCHDPLFIODM, int OJLPMHPHFKE, int MIOAPJGCBLG);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class EJKCKBEAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8587550", Offset = "0x8585F50", VA = "0x188587550")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8587680", Offset = "0x8586080", VA = "0x188587680")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8587260", Offset = "0x8585C60", VA = "0x188587260")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8587310", Offset = "0x8585D10", VA = "0x188587310")]
		public unsafe static void KDMGDDCNHFD([NoAlias] uint* KFPCJJHHFCF, [Out] float2 EGBIKALMIMO, [Out] float2 CMEKBCKEHIJ, [In][NoAlias] float2* FCHDPLFIODM, int OJLPMHPHFKE, int MIOAPJGCBLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void EODKOOFANDK([Out] float2 CJMJGHIBKCF, uint ENECDDMCBCM, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class HPMOIOLOGCK
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8589620", Offset = "0x8588020", VA = "0x188589620")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8589750", Offset = "0x8588150", VA = "0x188589750")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8589310", Offset = "0x8587D10", VA = "0x188589310")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85893C0", Offset = "0x8587DC0", VA = "0x1885893C0")]
		public static void KDMGDDCNHFD([Out] float2 CJMJGHIBKCF, uint ENECDDMCBCM, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void LCMPKHNNEMN([NoAlias] float2* KFPCJJHHFCF, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class IKGIEOKAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x858AEB0", Offset = "0x85898B0", VA = "0x18858AEB0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x858AFE0", Offset = "0x85899E0", VA = "0x18858AFE0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x858AB10", Offset = "0x8589510", VA = "0x18858AB10")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x858ABC0", Offset = "0x85895C0", VA = "0x18858ABC0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] float2* KFPCJJHHFCF, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void MNMJAEAMJJJ([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class MOPGBICBDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8598C40", Offset = "0x8597640", VA = "0x188598C40")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8598D70", Offset = "0x8597770", VA = "0x188598D70")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8598870", Offset = "0x8597270", VA = "0x188598870")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8598920", Offset = "0x8597320", VA = "0x188598920")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void HNGHKHFGBCN([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class DEIIEEMOIHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8585A80", Offset = "0x8584480", VA = "0x188585A80")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8585BB0", Offset = "0x85845B0", VA = "0x188585BB0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85856B0", Offset = "0x85840B0", VA = "0x1885856B0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8585760", Offset = "0x8584160", VA = "0x188585760")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void KMGPHDJBHDF([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class LNFLBNDFOHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8595D40", Offset = "0x8594740", VA = "0x188595D40")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8595E70", Offset = "0x8594870", VA = "0x188595E70")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8595A60", Offset = "0x8594460", VA = "0x188595A60")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8595B10", Offset = "0x8594510", VA = "0x188595B10")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void GBJAFGCONCI([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class CPFNAKOFIND
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8584E40", Offset = "0x8583840", VA = "0x188584E40")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8584F70", Offset = "0x8583970", VA = "0x188584F70")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8584A80", Offset = "0x8583480", VA = "0x188584A80")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8584B30", Offset = "0x8583530", VA = "0x188584B30")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void MLPICOIGOGG([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class BALKFNMFOEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x857B280", Offset = "0x8579C80", VA = "0x18857B280")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x857B3B0", Offset = "0x8579DB0", VA = "0x18857B3B0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x857AEB0", Offset = "0x85798B0", VA = "0x18857AEB0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x857AF60", Offset = "0x8579960", VA = "0x18857AF60")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void JCLNIGKIODB([NoAlias] ushort* LHEIECHCMPA, [In][NoAlias] float4* PPOOPKFGBNN, int OJLPMHPHFKE, int MIOAPJGCBLG);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class DCFEGDDHJGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8585420", Offset = "0x8583E20", VA = "0x188585420")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8585550", Offset = "0x8583F50", VA = "0x188585550")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x85850D0", Offset = "0x8583AD0", VA = "0x1885850D0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8585180", Offset = "0x8583B80", VA = "0x188585180")]
		public unsafe static void KDMGDDCNHFD([NoAlias] ushort* LHEIECHCMPA, [In][NoAlias] float4* PPOOPKFGBNN, int OJLPMHPHFKE, int MIOAPJGCBLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort HICIEGIHMDC([In] float4 DDANMDHBJOA);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class MDKJPIEEDMF
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8597310", Offset = "0x8595D10", VA = "0x188597310")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8597440", Offset = "0x8595E40", VA = "0x188597440")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8597000", Offset = "0x8595A00", VA = "0x188597000")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85970B0", Offset = "0x8595AB0", VA = "0x1885970B0")]
		public static ushort KDMGDDCNHFD([In] float4 DDANMDHBJOA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void OCDMMJAOHCN([NoAlias] float4* LHEIECHCMPA, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class NHLFBGGOHKK
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x859A5B0", Offset = "0x8598FB0", VA = "0x18859A5B0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x859A6E0", Offset = "0x85990E0", VA = "0x18859A6E0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x859A260", Offset = "0x8598C60", VA = "0x18859A260")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x859A310", Offset = "0x8598D10", VA = "0x18859A310")]
		public unsafe static void KDMGDDCNHFD([NoAlias] float4* LHEIECHCMPA, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void JCAFLIKLBBH([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class LFPMAPPMFBI
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85957D0", Offset = "0x85941D0", VA = "0x1885957D0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8595900", Offset = "0x8594300", VA = "0x188595900")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8595510", Offset = "0x8593F10", VA = "0x188595510")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85955C0", Offset = "0x8593FC0", VA = "0x1885955C0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void OLIAJBMFFBJ([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class DJPAMFDBPKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85867E0", Offset = "0x85851E0", VA = "0x1885867E0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8586910", Offset = "0x8585310", VA = "0x188586910")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8586400", Offset = "0x8584E00", VA = "0x188586400")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x85864B0", Offset = "0x8584EB0", VA = "0x1885864B0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void LFMHKIFICEP([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class JCONOPPMEFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x858BD10", Offset = "0x858A710", VA = "0x18858BD10")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x858BE40", Offset = "0x858A840", VA = "0x18858BE40")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x858B930", Offset = "0x858A330", VA = "0x18858B930")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x858B9E0", Offset = "0x858A3E0", VA = "0x18858B9E0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void NNPBLHLGDAN([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class NBHKIHCAGFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8599880", Offset = "0x8598280", VA = "0x188599880")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x85999B0", Offset = "0x85983B0", VA = "0x1885999B0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8599440", Offset = "0x8597E40", VA = "0x188599440")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85994F0", Offset = "0x8597EF0", VA = "0x1885994F0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void MCEPHNDGAJD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class HPOMGOGACFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8589CF0", Offset = "0x85886F0", VA = "0x188589CF0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8589E20", Offset = "0x8588820", VA = "0x188589E20")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x85898B0", Offset = "0x85882B0", VA = "0x1885898B0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8589960", Offset = "0x8588360", VA = "0x188589960")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void MMJJANKMMDI([Out] float4 GGIKEMCHAAA, ushort ENECDDMCBCM);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class BIFBAOFCOME
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x857BDE0", Offset = "0x857A7E0", VA = "0x18857BDE0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x857BF10", Offset = "0x857A910", VA = "0x18857BF10")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x857BA90", Offset = "0x857A490", VA = "0x18857BA90")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x857BB40", Offset = "0x857A540", VA = "0x18857BB40")]
		public static void KDMGDDCNHFD([Out] float4 GGIKEMCHAAA, ushort ENECDDMCBCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void MMBNJEJKLKH([NoAlias] float4* CJPADBBHKHA, [NoAlias] byte* LCGEOGPMKLP, [Out] int NJFCDPMDPIE, [Out] int LCOIOJFKNIO, [NoAlias] float4* HLFOOJALMKC, [NoAlias] float4* NJEAGEBFPAB, int OJLPMHPHFKE, int MIOAPJGCBLG);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class MDGIHCOCFFC
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8596D70", Offset = "0x8595770", VA = "0x188596D70")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8596EA0", Offset = "0x85958A0", VA = "0x188596EA0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8596A80", Offset = "0x8595480", VA = "0x188596A80")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8596B30", Offset = "0x8595530", VA = "0x188596B30")]
		public unsafe static void KDMGDDCNHFD([NoAlias] float4* CJPADBBHKHA, [NoAlias] byte* LCGEOGPMKLP, [Out] int NJFCDPMDPIE, [Out] int LCOIOJFKNIO, [NoAlias] float4* HLFOOJALMKC, [NoAlias] float4* NJEAGEBFPAB, int OJLPMHPHFKE, int MIOAPJGCBLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void IEHEHEKKKEM([NoAlias] float4* HCAIELOPEDN, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class CEMJPMLFEIM
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x857CB90", Offset = "0x857B590", VA = "0x18857CB90")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x857CCC0", Offset = "0x857B6C0", VA = "0x18857CCC0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x857C7E0", Offset = "0x857B1E0", VA = "0x18857C7E0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x857C890", Offset = "0x857B290", VA = "0x18857C890")]
		public unsafe static void KDMGDDCNHFD([NoAlias] float4* HCAIELOPEDN, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void EOFDJKIKIOJ([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class IPLNNHAAAAD
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x858B5A0", Offset = "0x8589FA0", VA = "0x18858B5A0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x858B6D0", Offset = "0x858A0D0", VA = "0x18858B6D0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x858B140", Offset = "0x8589B40", VA = "0x18858B140")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x858B1F0", Offset = "0x8589BF0", VA = "0x18858B1F0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void AAJPBKMOIJA([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class OADBDIOEFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x859AE30", Offset = "0x8599830", VA = "0x18859AE30")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x859AF60", Offset = "0x8599960", VA = "0x18859AF60")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x859A9C0", Offset = "0x85993C0", VA = "0x18859A9C0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x859AA70", Offset = "0x8599470", VA = "0x18859AA70")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void OPLNOFBAJLL([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class PAFFAMLBCPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x859C560", Offset = "0x859AF60", VA = "0x18859C560")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x859C690", Offset = "0x859B090", VA = "0x18859C690")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x859C100", Offset = "0x859AB00", VA = "0x18859C100")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x859C1B0", Offset = "0x859ABB0", VA = "0x18859C1B0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void NHEMKPGJALC([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class NBGDJGMMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x85991B0", Offset = "0x8597BB0", VA = "0x1885991B0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x85992E0", Offset = "0x8597CE0", VA = "0x1885992E0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8598ED0", Offset = "0x85978D0", VA = "0x188598ED0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8598F80", Offset = "0x8597980", VA = "0x188598F80")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void OIJDLHGMNFC([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class PMOBODMIFGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x859D670", Offset = "0x859C070", VA = "0x18859D670")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x859D7A0", Offset = "0x859C1A0", VA = "0x18859D7A0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x859D390", Offset = "0x859BD90", VA = "0x18859D390")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x859D440", Offset = "0x859BE40", VA = "0x18859D440")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int MGBHJFGHIMK([NoAlias] byte* BONNDIBGKPO, [In][NoAlias] int* NADIIOMGLKP, int JOAIKFBKAIK);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class GCONNNOMHHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8588EC0", Offset = "0x85878C0", VA = "0x188588EC0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8588FF0", Offset = "0x85879F0", VA = "0x188588FF0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8588B70", Offset = "0x8587570", VA = "0x188588B70")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8588C20", Offset = "0x8587620", VA = "0x188588C20")]
		public unsafe static int KDMGDDCNHFD([NoAlias] byte* BONNDIBGKPO, [In][NoAlias] int* NADIIOMGLKP, int JOAIKFBKAIK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void BLHBILIGMNF([NoAlias] int* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class MOHIBEDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x85985E0", Offset = "0x8596FE0", VA = "0x1885985E0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8598710", Offset = "0x8597110", VA = "0x188598710")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x85982D0", Offset = "0x8596CD0", VA = "0x1885982D0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8598380", Offset = "0x8596D80", VA = "0x188598380")]
		public unsafe static void KDMGDDCNHFD([NoAlias] int* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void CFFKGCDOFDB([NoAlias] ushort* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class MBKDAAGIHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x85967F0", Offset = "0x85951F0", VA = "0x1885967F0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8596920", Offset = "0x8595320", VA = "0x188596920")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85964D0", Offset = "0x8594ED0", VA = "0x1885964D0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8596580", Offset = "0x8594F80", VA = "0x188596580")]
		public unsafe static void KDMGDDCNHFD([NoAlias] ushort* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void IGJFECLCNPL([Out] float3 CJMJGHIBKCF, ushort ENECDDMCBCM);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class LEJBGGGFFEF
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8595280", Offset = "0x8593C80", VA = "0x188595280")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85953B0", Offset = "0x8593DB0", VA = "0x1885953B0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8594FC0", Offset = "0x85939C0", VA = "0x188594FC0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8595070", Offset = "0x8593A70", VA = "0x188595070")]
		public static void KDMGDDCNHFD([Out] float3 CJMJGHIBKCF, ushort ENECDDMCBCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort EDANJEMLPNM([In] float3 DDANMDHBJOA);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class IAMKHHMLKMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x858A230", Offset = "0x8588C30", VA = "0x18858A230")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x858A360", Offset = "0x8588D60", VA = "0x18858A360")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8589F80", Offset = "0x8588980", VA = "0x188589F80")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x858A030", Offset = "0x8588A30", VA = "0x18858A030")]
		public static ushort KDMGDDCNHFD([In] float3 DDANMDHBJOA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker OMBDGBKEJCK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker MNCKHDIMHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int FIFGJMDPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int DCDHCGLFMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> JOHBJJKGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> NLBCCENJEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<MHAJDNAPBAI> PMKFPPMHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> AGKJFMNHMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> KOOPKPLDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 ECPLIHBPAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 MEDKICHPJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 DEFMEFMGODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 CMEKBCKEHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long BNLLEBFHAMK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long IDBIAGKGPJA;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float JNENFCENNCI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool IFFLMLKJMDN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x858E9D0", Offset = "0x858D3D0", VA = "0x18858E9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GHMDPDHJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x858EF50", Offset = "0x858D950", VA = "0x18858EF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8594990", Offset = "0x8593390", VA = "0x188594990")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8593710", Offset = "0x8592110", VA = "0x188593710")]
	public static LDODGKLHIIE MLAHKGEEKLJ(Allocator EIOOMONCLID, CIJLFCMKEEG AHLDCAEEGJK)
	{
		return default(LDODGKLHIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85932C0", Offset = "0x8591CC0", VA = "0x1885932C0")]
	public static LDODGKLHIIE MLAHKGEEKLJ(Allocator EIOOMONCLID, NativeArray<float3> BJDOKIDGHIH, NativeArray<float3> CLFFINNCAMJ, NativeArray<float2> FCHDPLFIODM, NativeArray<float4> NJEAGEBFPAB, bool ILNHNJFOLLH, NativeArray<float4> NMIDMGAENAL, NativeArray<int> NADIIOMGLKP, int FIFGJMDPIIE, int LIBHDOFEHHM, int DCDHCGLFMIN, int OJLPMHPHFKE)
	{
		return default(LDODGKLHIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85915B0", Offset = "0x858FFB0", VA = "0x1885915B0")]
	public void IPEKODOHAMA(CIJLFCMKEEG GGIKEMCHAAA, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x858D920", Offset = "0x858C320", VA = "0x18858D920")]
	public long AIAPIPEPLKF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x858EBF0", Offset = "0x858D5F0", VA = "0x18858EBF0")]
	public long CMLAOAMNOMH(CIJLFCMKEEG.CKEAPDDDGNJ JBHFIGLCFLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8592730", Offset = "0x8591130", VA = "0x188592730")]
	private void LKKFJNNBNBF(int NAADNDJPCJF, int MIOAPJGCBLG, Allocator EIOOMONCLID, bool KCLBMNNEJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x858F940", Offset = "0x858E340", VA = "0x18858F940")]
	private void FFFIJPLCAGF(NativeArray<float3> KJCHCDAMMMI, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x858FA60", Offset = "0x858E460", VA = "0x18858FA60")]
	[BurstCompile]
	private unsafe static void FFFIJPLCAGF([NoAlias] float3* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8592D90", Offset = "0x8591790", VA = "0x188592D90")]
	[BurstCompile]
	private unsafe static void MDKPEIHBCOE([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8591D50", Offset = "0x8590750", VA = "0x188591D50")]
	[BurstCompile]
	private unsafe static void KMHPHNLHAKM([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x858E770", Offset = "0x858D170", VA = "0x18858E770")]
	[BurstCompile]
	private unsafe static void BOAGCGPCFFE([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8591CD0", Offset = "0x85906D0", VA = "0x188591CD0")]
	[BurstCompile]
	private unsafe static void KJJMEHOEEBH([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85907A0", Offset = "0x858F1A0", VA = "0x1885907A0")]
	[BurstCompile]
	private unsafe static void HIOGFCMBJCH([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8590EF0", Offset = "0x858F8F0", VA = "0x188590EF0")]
	private void ICMHLHNCHBK(NativeArray<float3> BJDOKIDGHIH, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8590E60", Offset = "0x858F860", VA = "0x188590E60")]
	[BurstCompile]
	private unsafe static void ICMHLHNCHBK([NoAlias] ushort* KJCHCDAMMMI, [Out] float3 KDMFNIENOEF, [Out] float3 MEDKICHPJJC, [In][NoAlias] float3* BJDOKIDGHIH, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8594550", Offset = "0x8592F50", VA = "0x188594550")]
	private void OICMILHDJEE(NativeArray<float3> CLFFINNCAMJ, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8594630", Offset = "0x8593030", VA = "0x188594630")]
	[BurstCompile]
	private unsafe static void OICMILHDJEE([NoAlias] ushort* PJBHFHPPPML, [In][NoAlias] float3* CLFFINNCAMJ, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8592FB0", Offset = "0x85919B0", VA = "0x188592FB0")]
	private void MGOPANHEDFL(NativeArray<float3> DBEJJFBLJKP, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8593070", Offset = "0x8591A70", VA = "0x188593070")]
	[BurstCompile]
	private unsafe static void MGOPANHEDFL([NoAlias] float3* DBEJJFBLJKP, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8590BC0", Offset = "0x858F5C0", VA = "0x188590BC0")]
	[BurstCompile]
	private unsafe static void HOGFGGDBLGO([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8591180", Offset = "0x858FB80", VA = "0x188591180")]
	[BurstCompile]
	private unsafe static void IDFGBFIFHAP([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85911F0", Offset = "0x858FBF0", VA = "0x1885911F0")]
	[BurstCompile]
	private unsafe static void IEGFPDLEEOK([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8594AB0", Offset = "0x85934B0", VA = "0x188594AB0")]
	[BurstCompile]
	private unsafe static void OKHPAHOMJAK([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x858E590", Offset = "0x858CF90", VA = "0x18858E590")]
	[BurstCompile]
	private unsafe static void BKECLLDMAFN([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8594430", Offset = "0x8592E30", VA = "0x188594430")]
	private void OGMLFGGKEMB(NativeArray<float2> FCHDPLFIODM, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85943A0", Offset = "0x8592DA0", VA = "0x1885943A0")]
	[BurstCompile]
	private unsafe static void OGMLFGGKEMB([NoAlias] uint* KFPCJJHHFCF, [Out] float2 EGBIKALMIMO, [Out] float2 CMEKBCKEHIJ, [In][NoAlias] float2* FCHDPLFIODM, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8590720", Offset = "0x858F120", VA = "0x188590720")]
	[BurstCompile]
	private static void HIOGDDHDJCO([Out] float2 CJMJGHIBKCF, uint ENECDDMCBCM, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8592E10", Offset = "0x8591810", VA = "0x188592E10")]
	private void MFPPJMCIGFM(NativeArray<float2> KFPCJJHHFCF, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8592F30", Offset = "0x8591930", VA = "0x188592F30")]
	[BurstCompile]
	private unsafe static void MFPPJMCIGFM([NoAlias] float2* KFPCJJHHFCF, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x858FE60", Offset = "0x858E860", VA = "0x18858FE60")]
	[BurstCompile]
	private unsafe static void GABMKCFGAAE([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8591260", Offset = "0x858FC60", VA = "0x188591260")]
	[BurstCompile]
	private unsafe static void IELPFDHOPHH([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x858EC60", Offset = "0x858D660", VA = "0x18858EC60")]
	[BurstCompile]
	private unsafe static void DDPMDOLFODP([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x858DA20", Offset = "0x858C420", VA = "0x18858DA20")]
	[BurstCompile]
	private unsafe static void BGGHGEJFLAB([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x858F780", Offset = "0x858E180", VA = "0x18858F780")]
	[BurstCompile]
	private unsafe static void FDLAKKOAFBD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8591DD0", Offset = "0x85907D0", VA = "0x188591DD0")]
	private void KOEPMLDEKDL(NativeArray<float4> NMIDMGAENAL, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8591EE0", Offset = "0x85908E0", VA = "0x188591EE0")]
	[BurstCompile]
	private unsafe static void KOEPMLDEKDL([NoAlias] ushort* LHEIECHCMPA, [In][NoAlias] float4* PPOOPKFGBNN, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8590E10", Offset = "0x858F810", VA = "0x188590E10")]
	[BurstCompile]
	private static ushort ICJAPKCPCNB([In] float4 DDANMDHBJOA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8590050", Offset = "0x858EA50", VA = "0x188590050")]
	private void GIIKABMLJHA(NativeArray<float4> LHEIECHCMPA, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8590140", Offset = "0x858EB40", VA = "0x188590140")]
	[BurstCompile]
	private unsafe static void GIIKABMLJHA([NoAlias] float4* LHEIECHCMPA, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85912E0", Offset = "0x858FCE0", VA = "0x1885912E0")]
	[BurstCompile]
	private unsafe static void IKEHBFHLPCL([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8591C60", Offset = "0x8590660", VA = "0x188591C60")]
	[BurstCompile]
	private unsafe static void KEFJNKIHJFA([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x858FDF0", Offset = "0x858E7F0", VA = "0x18858FDF0")]
	[BurstCompile]
	private unsafe static void FOHNNGCNPPD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x858E960", Offset = "0x858D360", VA = "0x18858E960")]
	[BurstCompile]
	private unsafe static void CDOPOJFNMBD([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x858E700", Offset = "0x858D100", VA = "0x18858E700")]
	[BurstCompile]
	private unsafe static void BNOJBPDFPMI([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8591F60", Offset = "0x8590960", VA = "0x188591F60")]
	[BurstCompile]
	private static void KPHKOFHNPJK([Out] float4 GGIKEMCHAAA, ushort ENECDDMCBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x858DF60", Offset = "0x858C960", VA = "0x18858DF60")]
	private void BJGIKPKCBIL(Allocator EIOOMONCLID, NativeArray<float4> NJEAGEBFPAB, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x858E400", Offset = "0x858CE00", VA = "0x18858E400")]
	[BurstCompile]
	private unsafe static void BJGIKPKCBIL([NoAlias] float4* CJPADBBHKHA, [NoAlias] byte* LCGEOGPMKLP, [Out] int NJFCDPMDPIE, [Out] int LCOIOJFKNIO, [NoAlias] float4* HLFOOJALMKC, [NoAlias] float4* NJEAGEBFPAB, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8592040", Offset = "0x8590A40", VA = "0x188592040")]
	private static void LANGMAHHEMG(NativeArray<float4> HCAIELOPEDN, NativeArray<MHAJDNAPBAI> IMKHADPJGME, NativeArray<byte> DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8591FC0", Offset = "0x85909C0", VA = "0x188591FC0")]
	[BurstCompile]
	private unsafe static void LANGMAHHEMG([NoAlias] float4* HCAIELOPEDN, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x858F440", Offset = "0x858DE40", VA = "0x18858F440")]
	[BurstCompile]
	private unsafe static void EBIKPLBOFGG([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8594910", Offset = "0x8593310", VA = "0x188594910")]
	[BurstCompile]
	private unsafe static void OJNJHJNECOD([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8591530", Offset = "0x858FF30", VA = "0x188591530")]
	[BurstCompile]
	private unsafe static void IKMMFDBKBNA([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x858ECE0", Offset = "0x858D6E0", VA = "0x18858ECE0")]
	[BurstCompile]
	private unsafe static void DFFPOLGDICC([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8590270", Offset = "0x858EC70", VA = "0x188590270")]
	[BurstCompile]
	private unsafe static void HEGIFJHNNBD([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x858E490", Offset = "0x858CE90", VA = "0x18858E490")]
	private void BJPKMHCHBEP(Allocator EIOOMONCLID, NativeArray<int> NADIIOMGLKP, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8593A50", Offset = "0x8592450", VA = "0x188593A50")]
	private static NativeArray<byte> MPFMJKNHPNI(Allocator EIOOMONCLID, NativeArray<int> NADIIOMGLKP, int JOAIKFBKAIK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85939E0", Offset = "0x85923E0", VA = "0x1885939E0")]
	[BurstCompile]
	private unsafe static int MPFMJKNHPNI([NoAlias] byte* BONNDIBGKPO, [In][NoAlias] int* NADIIOMGLKP, int JOAIKFBKAIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8590AD0", Offset = "0x858F4D0", VA = "0x188590AD0")]
	private static void HKEBLJAEIAI(NativeArray<int> LABAGMKAHED, NativeArray<byte> OMODBOCOPNJ, int DCDHCGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8590A60", Offset = "0x858F460", VA = "0x188590A60")]
	[BurstCompile]
	private unsafe static void HKEBLJAEIAI([NoAlias] int* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x858D8B0", Offset = "0x858C2B0", VA = "0x18858D8B0")]
	[BurstCompile]
	private unsafe static void ADFAIAFANHA([NoAlias] ushort* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85904E0", Offset = "0x858EEE0", VA = "0x1885904E0")]
	[BurstCompile]
	private static void HHNCDPNBJCO([Out] float3 CJMJGHIBKCF, ushort ENECDDMCBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8592860", Offset = "0x8591260", VA = "0x188592860")]
	[BurstCompile]
	private static ushort LLFPPCHKOOA([In] float3 DDANMDHBJOA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8577CF0", Offset = "0x85766F0", VA = "0x188577CF0")]
	[BurstCompile]
	public unsafe static void LBAINBJBICB([NoAlias] float3* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85901B0", Offset = "0x858EBB0", VA = "0x1885901B0")]
	[BurstCompile]
	public unsafe static void GLHPPGALNJJ([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x858F6C0", Offset = "0x858E0C0", VA = "0x18858F6C0")]
	[BurstCompile]
	public unsafe static void EJJOAILNDNG([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x858F600", Offset = "0x858E000", VA = "0x18858F600")]
	[BurstCompile]
	public unsafe static void EJDPNHOBOBD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x858F600", Offset = "0x858E000", VA = "0x18858F600")]
	[BurstCompile]
	public unsafe static void MODLHNCCKHI([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x858F030", Offset = "0x858DA30", VA = "0x18858F030")]
	[BurstCompile]
	public unsafe static void DPLBMOMLFFM([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* BJDOKIDGHIH, int FIFGJMDPIIE, [In] float3 ECPLIHBPAHM, [In] float3 MEDKICHPJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8578170", Offset = "0x8576B70", VA = "0x188578170")]
	[BurstCompile]
	public unsafe static void MOFJGGEEJNM([NoAlias] ushort* KJCHCDAMMMI, [Out] float3 KDMFNIENOEF, [Out] float3 MEDKICHPJJC, [In][NoAlias] float3* BJDOKIDGHIH, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x858F190", Offset = "0x858DB90", VA = "0x18858F190")]
	[BurstCompile]
	public unsafe static void EBFDIINLCEK([NoAlias] ushort* PJBHFHPPPML, [In][NoAlias] float3* CLFFINNCAMJ, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8594100", Offset = "0x8592B00", VA = "0x188594100")]
	[BurstCompile]
	public unsafe static void NPEPFNCMJIF([NoAlias] float3* DBEJJFBLJKP, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8593E70", Offset = "0x8592870", VA = "0x188593E70")]
	[BurstCompile]
	public unsafe static void NIHPNKDFCLH([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x858FCB0", Offset = "0x858E6B0", VA = "0x18858FCB0")]
	[BurstCompile]
	public unsafe static void FLLJCDGFLHG([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x858D6B0", Offset = "0x858C0B0", VA = "0x18858D6B0")]
	[BurstCompile]
	public unsafe static void AANLKMOJLEC([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8591010", Offset = "0x858FA10", VA = "0x188591010")]
	[BurstCompile]
	public unsafe static void IDCEBIFKKGG([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8594D60", Offset = "0x8593760", VA = "0x188594D60")]
	[BurstCompile]
	public unsafe static void PKLAOBPMMBJ([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* CLFFINNCAMJ, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8578C80", Offset = "0x8577680", VA = "0x188578C80")]
	[BurstCompile]
	public unsafe static void OLFDHEEHAME([NoAlias] uint* KFPCJJHHFCF, [Out] float2 EGBIKALMIMO, [Out] float2 CMEKBCKEHIJ, [In][NoAlias] float2* FCHDPLFIODM, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85940C0", Offset = "0x8592AC0", VA = "0x1885940C0")]
	[BurstCompile]
	public static void NMJHKOKBOIG([Out] float2 CJMJGHIBKCF, uint ENECDDMCBCM, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8591970", Offset = "0x8590370", VA = "0x188591970")]
	[BurstCompile]
	public unsafe static void JGDBEBMCFNJ([NoAlias] float2* KFPCJJHHFCF, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8593D30", Offset = "0x8592730", VA = "0x188593D30")]
	[BurstCompile]
	public unsafe static void NFGJPOHKBAK([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x858F800", Offset = "0x858E200", VA = "0x18858F800")]
	[BurstCompile]
	public unsafe static void FEBPGOFCKFB([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8592A90", Offset = "0x8591490", VA = "0x188592A90")]
	[BurstCompile]
	public unsafe static void LOAOAAEOKDL([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85924D0", Offset = "0x8590ED0", VA = "0x1885924D0")]
	[BurstCompile]
	public unsafe static void LKAMLLALADA([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8592600", Offset = "0x8591000", VA = "0x188592600")]
	[BurstCompile]
	public unsafe static void LKHCMBLFGMA([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [NoAlias] uint* FCHDPLFIODM, int FIFGJMDPIIE, [In] float2 DEFMEFMGODM, [In] float2 CMEKBCKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8592350", Offset = "0x8590D50", VA = "0x188592350")]
	[BurstCompile]
	public unsafe static void LGJOAOJDKCA([NoAlias] ushort* LHEIECHCMPA, [In][NoAlias] float4* PPOOPKFGBNN, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8594880", Offset = "0x8593280", VA = "0x188594880")]
	[BurstCompile]
	public static ushort OIDPJEMAACK([In] float4 DDANMDHBJOA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8592CB0", Offset = "0x85916B0", VA = "0x188592CB0")]
	[BurstCompile]
	public unsafe static void MBCDBNPNOMJ([NoAlias] float4* LHEIECHCMPA, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x858DC70", Offset = "0x858C670", VA = "0x18858DC70")]
	[BurstCompile]
	public unsafe static void BIJMIOEALEP([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x858E7F0", Offset = "0x858D1F0", VA = "0x18858E7F0")]
	[BurstCompile]
	public unsafe static void BOMLPBOEHLI([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x858FEE0", Offset = "0x858E8E0", VA = "0x18858FEE0")]
	[BurstCompile]
	public unsafe static void GEKNCBADKNF([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x858DAA0", Offset = "0x858C4A0", VA = "0x18858DAA0")]
	[BurstCompile]
	public unsafe static void BGPMHAEPOME([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x858FAE0", Offset = "0x858E4E0", VA = "0x18858FAE0")]
	[BurstCompile]
	public unsafe static void FLJFNLBBGCM([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] ushort* NMIDMGAENAL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x858D7F0", Offset = "0x858C1F0", VA = "0x18858D7F0")]
	[BurstCompile]
	public static void ABNBHHFDPEF([Out] float4 GGIKEMCHAAA, ushort ENECDDMCBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8578F40", Offset = "0x8577940", VA = "0x188578F40")]
	[BurstCompile]
	public unsafe static void PCJOLHDFGPK([NoAlias] float4* CJPADBBHKHA, [NoAlias] byte* LCGEOGPMKLP, [Out] int NJFCDPMDPIE, [Out] int LCOIOJFKNIO, [NoAlias] float4* HLFOOJALMKC, [NoAlias] float4* NJEAGEBFPAB, int OJLPMHPHFKE, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x858F4C0", Offset = "0x858DEC0", VA = "0x18858F4C0")]
	[BurstCompile]
	public unsafe static void EGHBGNMDEHM([NoAlias] float4* HCAIELOPEDN, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8591A80", Offset = "0x8590480", VA = "0x188591A80")]
	[BurstCompile]
	public unsafe static void JMPPHHGGDPI([NoAlias] CIJLFCMKEEG.KJJAMDLAIKD* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x858EA10", Offset = "0x858D410", VA = "0x18858EA10")]
	[BurstCompile]
	public unsafe static void CJGFOMEMNMA([NoAlias] CIJLFCMKEEG.NEGAFANINKG* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8592170", Offset = "0x8590B70", VA = "0x188592170")]
	[BurstCompile]
	public unsafe static void LCBNFBLAKLD([NoAlias] CIJLFCMKEEG.LOLMGJGBEKK* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8594B20", Offset = "0x8593520", VA = "0x188594B20")]
	[BurstCompile]
	public unsafe static void OKKEHNPLFKN([NoAlias] CIJLFCMKEEG.NJPIALKCOMO* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8590820", Offset = "0x858F220", VA = "0x188590820")]
	[BurstCompile]
	public unsafe static void HJHBCPBNLMC([NoAlias] CIJLFCMKEEG.EKJNOGMEOKF* KJCHCDAMMMI, [In][NoAlias] MHAJDNAPBAI* IMKHADPJGME, [In][NoAlias] byte* DLEGIHJEKML, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x858E600", Offset = "0x858D000", VA = "0x18858E600")]
	[BurstCompile]
	public unsafe static int BMPFFIJFEON([NoAlias] byte* BONNDIBGKPO, [In][NoAlias] int* NADIIOMGLKP, int JOAIKFBKAIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x858EF90", Offset = "0x858D990", VA = "0x18858EF90")]
	[BurstCompile]
	public unsafe static void DIJPKMACPGM([NoAlias] int* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8592430", Offset = "0x8590E30", VA = "0x188592430")]
	[BurstCompile]
	public unsafe static void LIOPGHGLKNL([NoAlias] ushort* LABAGMKAHED, [In][NoAlias] byte* OMODBOCOPNJ, int DCDHCGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85771B0", Offset = "0x8575BB0", VA = "0x1885771B0")]
	[BurstCompile]
	public static void BAIMMDJOAHG([Out] float3 CJMJGHIBKCF, ushort ENECDDMCBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x85778F0", Offset = "0x85762F0", VA = "0x1885778F0")]
	[BurstCompile]
	public static ushort EBGMINOBFAM([In] float3 DDANMDHBJOA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class CIJLFCMKEEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum CKEAPDDDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum POKDCAJCBNM
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		_,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct PPKEMLOKHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CKEAPDDDGNJ JBHFIGLCFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool CLMNGKKPGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int DPCGFADILOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct GIGHEKNCLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 KFJFDPLEJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float3 BJGHDDIMDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float4 ILIMBEEKFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float2 PKJHELHJOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public float4 PMKFPPMHFPK;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct KJJAMDLAIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public float3 KFJFDPLEJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 BJGHDDIMDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public half4 ILIMBEEKFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float2 PKJHELHJOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public half4 PMKFPPMHFPK;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct NEGAFANINKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float3 KFJFDPLEJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint BJGHDDIMDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public uint ILIMBEEKFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public float2 PKJHELHJOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public half4 PMKFPPMHFPK;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct LOLMGJGBEKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float3 KFJFDPLEJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint BJGHDDIMDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public uint ILIMBEEKFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half2 PKJHELHJOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public half4 PMKFPPMHFPK;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct NJPIALKCOMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float3 KFJFDPLEJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public uint OEHEAENMMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float2 PKJHELHJOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint GMCKNGDLINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public uint GOOKJAPFHOF;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct EKJNOGMEOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AIJOGMHPJGH.IENCEMADAIL NHCIMHLNEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public uint OEHEAENMMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public float2 PKJHELHJOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public uint GMCKNGDLINN;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly VertexAttributeDescriptor[] GJHMNALCNKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public unsafe delegate void DJIFKDDCNDD([NoAlias] KJJAMDLAIKD* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class AMHFCLMKIGE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x857A5B0", Offset = "0x8578FB0", VA = "0x18857A5B0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x857A6E0", Offset = "0x85790E0", VA = "0x18857A6E0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x857A2C0", Offset = "0x8578CC0", VA = "0x18857A2C0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x857A370", Offset = "0x8578D70", VA = "0x18857A370")]
		public unsafe static void KDMGDDCNHFD([NoAlias] KJJAMDLAIKD* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate int DKGDFOFPDAN(float FKPKEFAKAOE);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class PKEEGLGKHOI
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x859D100", Offset = "0x859BB00", VA = "0x18859D100")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x859D230", Offset = "0x859BC30", VA = "0x18859D230")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x859CDE0", Offset = "0x859B7E0", VA = "0x18859CDE0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x859CE90", Offset = "0x859B890", VA = "0x18859CE90")]
		public static int KDMGDDCNHFD(float FKPKEFAKAOE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint CFLOCGALEPD([In] float4 FEBGNHCBECK);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class KMEABKKPCJC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x858D320", Offset = "0x858BD20", VA = "0x18858D320")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x858D450", Offset = "0x858BE50", VA = "0x18858D450")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x858CF30", Offset = "0x858B930", VA = "0x18858CF30")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x858CFE0", Offset = "0x858B9E0", VA = "0x18858CFE0")]
		public static uint KDMGDDCNHFD([In] float4 FEBGNHCBECK)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public delegate uint CALHDAIAPHF([In] float3 FEBGNHCBECK);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class MFOGEOLMKHF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x85978D0", Offset = "0x85962D0", VA = "0x1885978D0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8597A00", Offset = "0x8596400", VA = "0x188597A00")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x85975A0", Offset = "0x8595FA0", VA = "0x1885975A0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8597650", Offset = "0x8596050", VA = "0x188597650")]
		public static uint KDMGDDCNHFD([In] float3 FEBGNHCBECK)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void DGDEBMFCNND([NoAlias] NEGAFANINKG* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class FCHEDGLPIDN
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8587D50", Offset = "0x8586750", VA = "0x188587D50")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8587E80", Offset = "0x8586880", VA = "0x188587E80")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8587A60", Offset = "0x8586460", VA = "0x188587A60")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8587B10", Offset = "0x8586510", VA = "0x188587B10")]
		public unsafe static void KDMGDDCNHFD([NoAlias] NEGAFANINKG* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void GBPIIDGAFBE([NoAlias] LOLMGJGBEKK* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class BFFJBMLFMPP
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x857B800", Offset = "0x857A200", VA = "0x18857B800")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x857B930", Offset = "0x857A330", VA = "0x18857B930")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x857B510", Offset = "0x8579F10", VA = "0x18857B510")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x857B5C0", Offset = "0x8579FC0", VA = "0x18857B5C0")]
		public unsafe static void KDMGDDCNHFD([NoAlias] LOLMGJGBEKK* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void ICCKDDPLLFC([NoAlias] NJPIALKCOMO* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class AELOBKMCGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x857A030", Offset = "0x8578A30", VA = "0x18857A030")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x857A160", Offset = "0x8578B60", VA = "0x18857A160")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8579B90", Offset = "0x8578590", VA = "0x188579B90")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8579C40", Offset = "0x8578640", VA = "0x188579C40")]
		public unsafe static void KDMGDDCNHFD([NoAlias] NJPIALKCOMO* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public unsafe delegate void KECEPPIDAJI([NoAlias] EKJNOGMEOKF* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK, [Out] float3 DFNMNLPDLAN, [Out] float3 DJMDDHPHBFL);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class OIMNIDLHAII
	{
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x859BCC0", Offset = "0x859A6C0", VA = "0x18859BCC0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x859BDF0", Offset = "0x859A7F0", VA = "0x18859BDF0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x859B6B0", Offset = "0x859A0B0", VA = "0x18859B6B0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x859B760", Offset = "0x859A160", VA = "0x18859B760")]
		public unsafe static void KDMGDDCNHFD([NoAlias] EKJNOGMEOKF* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK, [Out] float3 DFNMNLPDLAN, [Out] float3 DJMDDHPHBFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public unsafe delegate void OJIMOKNOECL(int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD);

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class HFMNAIDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x85AB7C0", Offset = "0x85AA1C0", VA = "0x1885AB7C0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x85AB8F0", Offset = "0x85AA2F0", VA = "0x1885AB8F0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x85AB4F0", Offset = "0x85A9EF0", VA = "0x1885AB4F0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x85AB5A0", Offset = "0x85A9FA0", VA = "0x1885AB5A0")]
		public unsafe static void KDMGDDCNHFD(int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public unsafe delegate void PAKPEMLHAIE(int MHADOGLMBLF, int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD);

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	internal static class EBMAGGIDKGG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x85A6290", Offset = "0x85A4C90", VA = "0x1885A6290")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85A63C0", Offset = "0x85A4DC0", VA = "0x1885A63C0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F90", Offset = "0x85A4990", VA = "0x1885A5F90")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x85A6040", Offset = "0x85A4A40", VA = "0x1885A6040")]
		public unsafe static void KDMGDDCNHFD(int MHADOGLMBLF, int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public unsafe delegate void ANBGDELPLKL(int FKCFKPBIEAL, int AKADONFNNKG, int FOMMKGCDPGC, [In][NoAlias] int* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal static class HJEBKOPOJNH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x85ABD50", Offset = "0x85AA750", VA = "0x1885ABD50")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x85ABE80", Offset = "0x85AA880", VA = "0x1885ABE80")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x85ABA50", Offset = "0x85AA450", VA = "0x1885ABA50")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x85ABB00", Offset = "0x85AA500", VA = "0x1885ABB00")]
		public unsafe static void KDMGDDCNHFD(int FKCFKPBIEAL, int AKADONFNNKG, int FOMMKGCDPGC, [In][NoAlias] int* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public unsafe delegate void HPDGNJHDBAK(int FIFGJMDPIIE, [NoAlias] bool* CENHAIKHHGO, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK);

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal static class LNNLPDEPKAB
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x85B3880", Offset = "0x85B2280", VA = "0x1885B3880")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x85B39B0", Offset = "0x85B23B0", VA = "0x1885B39B0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x85B3590", Offset = "0x85B1F90", VA = "0x1885B3590")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x85B3640", Offset = "0x85B2040", VA = "0x1885B3640")]
		public unsafe static void KDMGDDCNHFD(int FIFGJMDPIIE, [NoAlias] bool* CENHAIKHHGO, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int HHGEHCHBKNG = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> HABMNAPGHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> EEDIBMCHMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> KIKJBIMBGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> FGAMINHINPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> LBGFAIHDOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> JCLKFHPHCBF;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] NFHIDDJAPHD;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool EFGOAGIICMN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static PPKEMLOKHLL[] JOPDLEFLJBK;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static VertexAttributeDescriptor[] KOIMEHEBJHM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x857EAE0", Offset = "0x857D4E0", VA = "0x18857EAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x85824C0", Offset = "0x8580EC0", VA = "0x1885824C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EANIOFGDILK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8582A60", Offset = "0x8581460", VA = "0x188582A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GHMDPDHJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x857EFC0", Offset = "0x857D9C0", VA = "0x18857EFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8582A10", Offset = "0x8581410", VA = "0x188582A10")]
	public static POKDCAJCBNM MABPAGCAINJ(CKEAPDDDGNJ JBHFIGLCFLB)
	{
		return default(POKDCAJCBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x857F170", Offset = "0x857DB70", VA = "0x18857F170")]
	public static void DIJHNHCLJBP(POKDCAJCBNM GAHOGHHHFLL, Material PJPBFBIEGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x857F320", Offset = "0x857DD20", VA = "0x18857F320", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x8582730", Offset = "0x8581130", VA = "0x188582730")]
	public void LKKFJNNBNBF(int NAADNDJPCJF, int MIOAPJGCBLG, Allocator EIOOMONCLID, bool BDNKFJKHBHJ, bool KCLBMNNEJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8584590", Offset = "0x8582F90", VA = "0x188584590")]
	public void PPKBCGKBKOM(int NAADNDJPCJF, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8580E30", Offset = "0x857F830", VA = "0x188580E30", Slot = "6")]
	public bool JLEPNEILIDK(Mesh KGGOMLADPBD, bool MEMOPLGJNDJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x8581050", Offset = "0x857FA50", VA = "0x188581050")]
	public bool JMOKBILJAFI(Mesh KGGOMLADPBD, bool MEMOPLGJNDJ, bool IALFAOIDOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8583840", Offset = "0x8582240", VA = "0x188583840")]
	public bool OOPGGEMEHEH(Mesh KGGOMLADPBD, CIJLFCMKEEG FOLEDLNNBDO, bool MEMOPLGJNDJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x857F000", Offset = "0x857DA00", VA = "0x18857F000")]
	public bool DHLFEHEJFDC(Mesh KGGOMLADPBD, CIJLFCMKEEG FOLEDLNNBDO, CKEAPDDDGNJ JBHFIGLCFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8581450", Offset = "0x857FE50", VA = "0x188581450")]
	private void KAHICIGGPPB(Mesh KGGOMLADPBD, CIJLFCMKEEG FOLEDLNNBDO, bool IALFAOIDOAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8581C70", Offset = "0x8580670", VA = "0x188581C70")]
	public void KAHICIGGPPB(NativeArray<ushort> GKMCHDIFIDM, NativeArray<NJPIALKCOMO> JMNILAILGCI, Mesh KGGOMLADPBD, CIJLFCMKEEG FOLEDLNNBDO, bool IALFAOIDOAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x857D520", Offset = "0x857BF20", VA = "0x18857D520")]
	public void AKALNFKOIBI(Mesh KGGOMLADPBD, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8580A50", Offset = "0x857F450", VA = "0x188580A50")]
	[BurstCompile]
	private unsafe static void IJJGAPOCIEF([NoAlias] KJJAMDLAIKD* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8582970", Offset = "0x8581370", VA = "0x188582970")]
	[BurstCompile]
	public static int LOENPJHGNNA(float FKPKEFAKAOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x85829C0", Offset = "0x85813C0", VA = "0x1885829C0")]
	[BurstCompile]
	public static uint LOENPJHGNNA([In] float4 FEBGNHCBECK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8582920", Offset = "0x8581320", VA = "0x188582920")]
	[BurstCompile]
	public static uint LOENPJHGNNA([In] float3 FEBGNHCBECK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x857E3A0", Offset = "0x857CDA0", VA = "0x18857E3A0")]
	public void BINFHPIIGEC(Mesh KGGOMLADPBD, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x857FB20", Offset = "0x857E520", VA = "0x18857FB20")]
	[BurstCompile]
	private unsafe static void FAHBNHGCADO([NoAlias] NEGAFANINKG* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8582AA0", Offset = "0x85814A0", VA = "0x188582AA0")]
	public void MLENMEAJBOM(Mesh KGGOMLADPBD, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x857FBA0", Offset = "0x857E5A0", VA = "0x18857FBA0")]
	[BurstCompile]
	private unsafe static void FKOMHEEPAGH([NoAlias] LOLMGJGBEKK* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8583D40", Offset = "0x8582740", VA = "0x188583D40")]
	public void PGKJLMNMGFN(Mesh KGGOMLADPBD, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8584160", Offset = "0x8582B60", VA = "0x188584160")]
	public void PGKJLMNMGFN(NativeArray<ushort> NNIKLEEHAIB, NativeArray<NJPIALKCOMO> NNLEMDDOHPP, Mesh KGGOMLADPBD, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x85837C0", Offset = "0x85821C0", VA = "0x1885837C0")]
	[BurstCompile]
	public unsafe static void NKOEPHHPNBF([NoAlias] NJPIALKCOMO* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x857DC00", Offset = "0x857C600", VA = "0x18857DC00")]
	public void AKGMMLNIFLH(Mesh KGGOMLADPBD, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8584510", Offset = "0x8582F10", VA = "0x188584510")]
	[BurstCompile]
	private unsafe static void PIKHPMMFOEN([NoAlias] EKJNOGMEOKF* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK, [Out] float3 DFNMNLPDLAN, [Out] float3 DJMDDHPHBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8580040", Offset = "0x857EA40", VA = "0x188580040")]
	public void GPBOANKMLPF(Mesh KGGOMLADPBD, CKEAPDDDGNJ JBHFIGLCFLB, bool IALFAOIDOAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8582000", Offset = "0x8580A00", VA = "0x188582000")]
	[BurstCompile]
	private unsafe static void KGCNLGENHEH(int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8581F80", Offset = "0x8580980", VA = "0x188581F80")]
	[BurstCompile]
	private unsafe static void KGCNLGENHEH(int MHADOGLMBLF, int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x857EC80", Offset = "0x857D680", VA = "0x18857EC80")]
	public void CPDPAOLJONG(CIJLFCMKEEG KGGOMLADPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x857F2A0", Offset = "0x857DCA0", VA = "0x18857F2A0")]
	[BurstCompile]
	private unsafe static void DLJHOBDPEFO(int FKCFKPBIEAL, int AKADONFNNKG, int FOMMKGCDPGC, [In][NoAlias] int* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x857F430", Offset = "0x857DE30", VA = "0x18857F430")]
	public void EDABMKPNMEN(CIJLFCMKEEG PBOCDEMNFLD, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x857D3D0", Offset = "0x857BDD0", VA = "0x18857D3D0")]
	public long AIAPIPEPLKF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x857D370", Offset = "0x857BD70", VA = "0x18857D370")]
	public static long AIAPIPEPLKF(int ECPJPGNBDFN, int PFMGFHDEFKE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x857EBE0", Offset = "0x857D5E0", VA = "0x18857EBE0")]
	public static long CMLAOAMNOMH(int ECPJPGNBDFN, int PFMGFHDEFKE, CKEAPDDDGNJ JBHFIGLCFLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x857EB20", Offset = "0x857D520", VA = "0x18857EB20")]
	public long CMLAOAMNOMH(CKEAPDDDGNJ JBHFIGLCFLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x857EA80", Offset = "0x857D480", VA = "0x18857EA80")]
	public void BJPLEHPLABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x857F530", Offset = "0x857DF30", VA = "0x18857F530")]
	public static void EMGCNMGHBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x85804F0", Offset = "0x857EEF0", VA = "0x1885804F0")]
	public CKEAPDDDGNJ IBGAFBPMCEG()
	{
		return default(CKEAPDDDGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8580AD0", Offset = "0x857F4D0", VA = "0x188580AD0")]
	[BurstCompile]
	private unsafe static void JCMGGELFEKL(int FIFGJMDPIIE, [NoAlias] bool* CENHAIKHHGO, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8583650", Offset = "0x8582050", VA = "0x188583650")]
	public static (int, int) NIJMOMDOOAN(Mesh KGGOMLADPBD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8580410", Offset = "0x857EE10", VA = "0x188580410")]
	public static int HNCEINHAIED(Span<VertexAttributeDescriptor> HMADGDDCDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x85826C0", Offset = "0x85810C0", VA = "0x1885826C0")]
	public static long LHDEJKHLIEM(Mesh KGGOMLADPBD, int NIEFDDJMHKH, int BDCJOFJCMMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8582500", Offset = "0x8580F00", VA = "0x188582500")]
	public static long LHDEJKHLIEM(Mesh KGGOMLADPBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CIJLFCMKEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8576310", Offset = "0x8574D10", VA = "0x188576310")]
	[BurstCompile]
	public unsafe static void EEAMIBOIEAB([NoAlias] KJJAMDLAIKD* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8580B50", Offset = "0x857F550", VA = "0x188580B50")]
	[BurstCompile]
	public static int JIIGGGJLKGI(float FKPKEFAKAOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8580BF0", Offset = "0x857F5F0", VA = "0x188580BF0")]
	[BurstCompile]
	public static uint JIIGGGJLKGI([In] float4 FEBGNHCBECK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8580D80", Offset = "0x857F780", VA = "0x188580D80")]
	[BurstCompile]
	public static uint JIIGGGJLKGI([In] float3 FEBGNHCBECK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x857FC80", Offset = "0x857E680", VA = "0x18857FC80")]
	[BurstCompile]
	public unsafe static void GJAEGPOKOBJ([NoAlias] NEGAFANINKG* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8582070", Offset = "0x8580A70", VA = "0x188582070")]
	[BurstCompile]
	public unsafe static void KLFIBALBONJ([NoAlias] LOLMGJGBEKK* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8580E50", Offset = "0x857F850", VA = "0x188580E50")]
	[BurstCompile]
	public unsafe static void JLFPJMMGMBD([NoAlias] NJPIALKCOMO* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x85800D0", Offset = "0x857EAD0", VA = "0x1885800D0")]
	[BurstCompile]
	public unsafe static void HJELPLJHPBE([NoAlias] EKJNOGMEOKF* KJCHCDAMMMI, int FIFGJMDPIIE, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK, [Out] float3 DFNMNLPDLAN, [Out] float3 DJMDDHPHBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x857FC20", Offset = "0x857E620", VA = "0x18857FC20")]
	[BurstCompile]
	public unsafe static void GGBENKBFKJB(int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x857FC50", Offset = "0x857E650", VA = "0x18857FC50")]
	[BurstCompile]
	public unsafe static void GGBENKBFKJB(int MHADOGLMBLF, int DCDHCGLFMIN, [In][NoAlias] ushort* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x857F250", Offset = "0x857DC50", VA = "0x18857F250")]
	[BurstCompile]
	public unsafe static void DJDNJHKMLKK(int FKCFKPBIEAL, int AKADONFNNKG, int FOMMKGCDPGC, [In][NoAlias] int* GOEEHAIBCFL, [In][NoAlias] int* PBOCDEMNFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8583180", Offset = "0x8581B80", VA = "0x188583180")]
	[BurstCompile]
	public unsafe static void MOGBPNMJBDH(int FIFGJMDPIIE, [NoAlias] bool* CENHAIKHHGO, [In][NoAlias] float3* DIHECIFIECF, [In][NoAlias] float3* DOPNICCPBOJ, [In][NoAlias] float4* KEIDKJECCPH, [In][NoAlias] float2* NLBCCENJEGK, [In][NoAlias] float4* PMKFPPMHFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JEAPDJGGJKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int OHPLKMLPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3 BHJCCDPAJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public quaternion FBLJEPJAHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 PIPPKPFNAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public int OCAHEHKLJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int JCMKCPCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public int LDLDAFFONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float PCMMDIDGJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float3 FAIDHIOFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool OGAEPMGEKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NKIPOMMBBHD NGHEJEDPABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float3 BACGIAPCFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float DBEMNJHHEHM;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class CAKHJMCNAJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static IHEOFMLIHGE NJFNAFIGHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public NativeList<JEAPDJGGJKJ> PPFNLNBHDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NativeList<IEDPBKHCAIA> JDFLKMAFPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NativeList<INLGPKIPFCI> IBDDCHIOMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NativeArray<CMNLAHEDKFC> BOOJNBFDOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NativeList<IEDPBKHCAIA> LDGDKKBJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NativeList<OMENJIJPFFC> AFJEGMIHPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private List<NativeArray<CMNLAHEDKFC>> APFFHJECAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NativeList<NMADFFPCCPM> NBDBHBEAKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private NativeArray<int> GLEGDEFHMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NativeArray<int> BPOJJECDMBN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeList<IJKBHOPHDIE.DBOPNLDFMGN> MONJCGACFDK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xAAC190", Offset = "0xAAAB90", VA = "0x180AAC190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xAAC1B0", Offset = "0xAAABB0", VA = "0x180AAC1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EANIOFGDILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xD94BB0", Offset = "0xD935B0", VA = "0x180D94BB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xD94BC0", Offset = "0xD935C0", VA = "0x180D94BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x85A5550", Offset = "0x85A3F50", VA = "0x1885A5550")]
	public CAKHJMCNAJB(int AEIEMBEDHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x85A36D0", Offset = "0x85A20D0", VA = "0x1885A36D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x85A4FE0", Offset = "0x85A39E0", VA = "0x1885A4FE0")]
	public void OKCDDGFOJCM(JobHandle EDFFJEFOFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x85A34B0", Offset = "0x85A1EB0", VA = "0x1885A34B0")]
	public void BMIPOKOFEKC(JEAPDJGGJKJ BLPDDGCLNPE, NMADFFPCCPM JMCJGBNDGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x85A4EA0", Offset = "0x85A38A0", VA = "0x1885A4EA0")]
	public void OEMEAONJDGE(INLGPKIPFCI BLPDDGCLNPE, NativeArray<CMNLAHEDKFC> OLCFGBPDJOI, int FIFGJMDPIIE, int DCDHCGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x85A3B60", Offset = "0x85A2560", VA = "0x1885A3B60")]
	public JobHandle MIOPEFLJPGI(CIJLFCMKEEG FBAIFLHLGJC, LNEAKODNBNC LABLDKBHFIB, float3 EIEFHDLOPFL, quaternion HJLPFKHBKOK, float ALOALKLPIIC, bool PNBJNIBOMDD, int KLGOEONJFAE = 0, int OMCAFBLJEFL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x85A3C80", Offset = "0x85A2680", VA = "0x1885A3C80")]
	public JobHandle MIOPEFLJPGI(CIJLFCMKEEG FBAIFLHLGJC, LNEAKODNBNC LABLDKBHFIB, NativeList<IJKBHOPHDIE.DBOPNLDFMGN> GJGINOEGPEM, float3 EIEFHDLOPFL, quaternion HJLPFKHBKOK, float ALOALKLPIIC, bool PNBJNIBOMDD, bool NKGIABINHPJ, int KLGOEONJFAE = 0, int OMCAFBLJEFL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x85A51D0", Offset = "0x85A3BD0", VA = "0x1885A51D0")]
	public static JobHandle PEIPKAENEGG(LDOJFKOCFLP NDNGJFNKLFJ, CIJLFCMKEEG FBAIFLHLGJC, NativeArray<int> BPOJJECDMBN, JEAPDJGGJKJ BLPDDGCLNPE, JobHandle EDFFJEFOFGN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x85A38B0", Offset = "0x85A22B0", VA = "0x1885A38B0")]
	public static JobHandle HMDIMALKIIO(DAFNEBACFMA NDNGJFNKLFJ, CIJLFCMKEEG FBAIFLHLGJC, INLGPKIPFCI BLPDDGCLNPE, NativeArray<CMNLAHEDKFC> OLCFGBPDJOI, int FIFGJMDPIIE, int DCDHCGLFMIN, JobHandle EDFFJEFOFGN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GMDMLDLJNOC
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal struct OCPNJHMNGOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public MeshRenderer ALKNEOONPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public HLIADOFEOEE.ENEGDKLPMIK FKEJOKAAPBC;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x56F4840", Offset = "0x56F3240", VA = "0x1856F4840")]
		public OCPNJHMNGOA(MeshRenderer ALKNEOONPNG, HLIADOFEOEE.ENEGDKLPMIK FKEJOKAAPBC)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85B50B0", Offset = "0x85B3AB0", VA = "0x1885B50B0")]
		public static OCPNJHMNGOA HDPJNBPLGPE((MeshRenderer, HLIADOFEOEE.ENEGDKLPMIK) GBHGHMJMBIL)
		{
			return default(OCPNJHMNGOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker MGMOIDJLECC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker LMEDIAPBODB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker IAAJJGHNGFF;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker JDEANNMNMKA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x85A7AB0", Offset = "0x85A64B0", VA = "0x1885A7AB0")]
	internal void MNLDEGAJNOG(GameObject GEHHAHCAOHO, HLIADOFEOEE.CMLLPCPMJCG CEHPEAMDNHA, List<OCPNJHMNGOA> HHHHAPMJLOO, Material PJPBFBIEGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x85A7280", Offset = "0x85A5C80", VA = "0x1885A7280")]
	internal void HJIKNPKJOOO(GameObject GEHHAHCAOHO, HLIADOFEOEE.CMLLPCPMJCG CEHPEAMDNHA, List<OCPNJHMNGOA> HHHHAPMJLOO, List<LODGroup> KEEOMDALOOJ, Material PJPBFBIEGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x85A9370", Offset = "0x85A7D70", VA = "0x1885A9370")]
	private MeshRenderer PIGGBCCEAKC(HLIADOFEOEE.CMLLPCPMJCG CEHPEAMDNHA, Material PJPBFBIEGMK, List<OCPNJHMNGOA> HHHHAPMJLOO, bool PFHNPCLOHHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x85A8320", Offset = "0x85A6D20", VA = "0x1885A8320")]
	private List<(List<OCPNJHMNGOA>, float)> NAFNMKMNFOM(HLIADOFEOEE.CMLLPCPMJCG CEHPEAMDNHA, List<LODGroup> KEEOMDALOOJ, Material PJPBFBIEGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x85A6520", Offset = "0x85A4F20", VA = "0x1885A6520")]
	private List<List<(List<OCPNJHMNGOA>, float)>> DNNJLEOIMGM(HLIADOFEOEE.CMLLPCPMJCG CEHPEAMDNHA, List<LODGroup> KEEOMDALOOJ, Material PJPBFBIEGMK, [Out] int IDGDEPFICPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GMDMLDLJNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x85A9200", Offset = "0x85A7C00", VA = "0x1885A9200")]
	[CompilerGenerated]
	internal static (float, int) PGFAAAJHJNP(List<List<(List<OCPNJHMNGOA> meshList, float lodTransition)>> OBEJKPEGKDE, int[] KCDENKDAADM)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class ANHKHAMILOO
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker JKJBONAEPMO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker PFFPFAAOHFJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker HJGLCFKBIBC;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker JANONLNMIKA;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker KLHHGJDHHIF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker OEKDLBADGBM;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker BIMMDANJPGA;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly OLFEOKKCIEG PBACIMMPJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private HLIADOFEOEE OFMDJHJFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private GMDMLDLJNOC MLHCKIFOBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Shader PGCBLJOGBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private MaterialPropertyBlock MFDPFDCMPDM;

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x85A0C30", Offset = "0x859F630", VA = "0x1885A0C30")]
	public static void LDPOAHEEFAF(GameObject GEHHAHCAOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x859FD40", Offset = "0x859E740", VA = "0x18859FD40")]
	public void GFALNPPLGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x859F350", Offset = "0x859DD50", VA = "0x18859F350")]
	public void CDOMFACHJCO(GameObject GEHHAHCAOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x85A17F0", Offset = "0x85A01F0", VA = "0x1885A17F0")]
	private bool ONFIFBKOJND(MeshRenderer ALKNEOONPNG, [Out] MeshFilter DIBNIOPHKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x85A1520", Offset = "0x859FF20", VA = "0x1885A1520")]
	private bool OHDGIHPBPOM(int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x85A04D0", Offset = "0x859EED0", VA = "0x1885A04D0")]
	private void ICPBGPLNAAN(GameObject GEHHAHCAOHO, int KABGMIEBEFC, Material PJPBFBIEGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x859F590", Offset = "0x859DF90", VA = "0x18859F590")]
	private List<GMDMLDLJNOC.OCPNJHMNGOA> FCDNDGCFIEO(int KABGMIEBEFC, [Out] List<LODGroup> KEEOMDALOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x85A0FB0", Offset = "0x859F9B0", VA = "0x1885A0FB0")]
	private List<(int, Material)> LGCABGEELGJ(float LOAFIGPOGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x85A1740", Offset = "0x85A0140", VA = "0x1885A1740")]
	public void OLMPCAINCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x85A0700", Offset = "0x859F100", VA = "0x1885A0700")]
	private bool INFHCIAPCLL(GameObject FNCBMCHNDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x85A1BD0", Offset = "0x85A05D0", VA = "0x1885A1BD0")]
	public ANHKHAMILOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[BurstCompile]
public class HLIADOFEOEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[BurstCompatible]
	public struct CMLLPCPMJCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public float3 JOEBEKPOHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public float3 EPMJNJEPCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float CCPAILCNBNE;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x85A58B0", Offset = "0x85A42B0", VA = "0x1885A58B0")]
		public CMLLPCPMJCG(Bounds KAKALMLAPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x85A57A0", Offset = "0x85A41A0", VA = "0x1885A57A0")]
		public CMLLPCPMJCG(float3 JOEBEKPOHKM, float3 EPMJNJEPCMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[BurstCompatible]
	public struct DBGAFGLKFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public CMLLPCPMJCG ILEPHGJKNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int MCDDEENLCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int DODDNKANEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float KMFGMPADIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int NAADNDJPCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int BALBKMGMKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int JPDNJJGOMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int KKBHGDCBLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int MKJOJBCKFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool JIIEMDBJPIL;
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public struct ENEGDKLPMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Mesh OLDNMECOABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Matrix4x4 IAGDJHKAAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int PKFGNMNCFOP;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[BurstCompile]
	private struct PJFOBJELKGJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[ReadOnly]
		public NativeArray<DBGAFGLKFDI> EFJLHLAODDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[WriteOnly]
		public NativeArray<float> EDNHDPIMANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int LFJJKGHGDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public CMLLPCPMJCG KAKALMLAPHO;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x85B56E0", Offset = "0x85B40E0", VA = "0x1885B56E0")]
		private float DPHPILGDFGN(CMLLPCPMJCG EICJFDNFOCB, CMLLPCPMJCG MIBIEOGGIAP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x85B5810", Offset = "0x85B4210", VA = "0x1885B5810", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker PKMGJOPFELE;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker PAKLBOCLBDC;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker EDBIJOAHEJM;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly ProfilerMarker GONGBLDIHOM;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker GNGBIHAPNJM;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker MIOACGCBGAJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly ProfilerMarker OAIBBLNKGDG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker OPMBCBGIPDM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker EHHGODFFCFF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker NAAKHPFIHHP;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker JLPKDFIKHKI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ProfilerMarker CBAEEJMCIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public NativeArray<DBGAFGLKFDI> EFJLHLAODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public NativeQueue<int> IBOPLGIJFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public int PABNHIHPJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Dictionary<Material, int> AJCBPCKMFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<ENEGDKLPMIK> LPIDAAEPHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public List<LODGroup> KEEOMDALOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Dictionary<int, MeshRenderer> NEHBMMABEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Queue<int> MFIKPIOBDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Shader EJDBPIGNGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Shader OHMHHCCDAOO;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x85AFCA0", Offset = "0x85AE6A0", VA = "0x1885AFCA0")]
	public HLIADOFEOEE(int ONCAEOGDHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x85AD490", Offset = "0x85ABE90", VA = "0x1885AD490")]
	private void AEGJPPKJNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x85ACCA0", Offset = "0x85AB6A0", VA = "0x1885ACCA0")]
	public bool ABEAKDKAACH(MeshRenderer JIECEBCFPKB, MeshFilter JNEBKPDBBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x85ABFE0", Offset = "0x85AA9E0", VA = "0x1885ABFE0")]
	public bool ABEAKDKAACH(LODGroup NBKHJKJFNII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x85AE7D0", Offset = "0x85AD1D0", VA = "0x1885AE7D0")]
	private bool GMMHHEEELIA(MeshRenderer JIECEBCFPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x85AEC00", Offset = "0x85AD600", VA = "0x1885AEC00")]
	private int JAMPKBFPNEC(MeshRenderer JIECEBCFPKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x85AE020", Offset = "0x85ACA20", VA = "0x1885AE020")]
	private int CMKCMMHIJMK(LODGroup NBKHJKJFNII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x85ADEC0", Offset = "0x85AC8C0", VA = "0x1885ADEC0")]
	private int CGDKFCFEBJF(MeshFilter JNEBKPDBBOO, int KBLLLLMLGLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x85AD130", Offset = "0x85ABB30", VA = "0x1885AD130")]
	private int ADMCFPEEPCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x85AE850", Offset = "0x85AD250", VA = "0x1885AE850")]
	private static CMLLPCPMJCG HOFIPNMCODC(CMLLPCPMJCG EICJFDNFOCB, CMLLPCPMJCG MIBIEOGGIAP)
	{
		return default(CMLLPCPMJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x85AED20", Offset = "0x85AD720", VA = "0x1885AED20")]
	private static float JIPKHKLONKC(Vector3 JOEBEKPOHKM, Vector3 EPMJNJEPCMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x85AF420", Offset = "0x85ADE20", VA = "0x1885AF420")]
	private int LKDPBLPLLKM(int FMCCPKNHMJH, CMLLPCPMJCG PLCMHKLAANN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x85AF750", Offset = "0x85AE150", VA = "0x1885AF750")]
	private void NIENHIDIGBG(CMLLPCPMJCG PLCMHKLAANN, int KABGMIEBEFC, [Out] float JNJIBPBFNFO, [Out] float BLPIGEEPOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x85ADA40", Offset = "0x85AC440", VA = "0x1885ADA40")]
	private void BJGHIELEIGN(CMLLPCPMJCG PLCMHKLAANN, int KPFDPLBPEPB, Material PJPBFBIEGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x85AE4E0", Offset = "0x85ACEE0", VA = "0x1885AE4E0")]
	private float DPHPILGDFGN(CMLLPCPMJCG EICJFDNFOCB, CMLLPCPMJCG MIBIEOGGIAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x85AD600", Offset = "0x85AC000", VA = "0x1885AD600")]
	private void AFAMAEPPKBC(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x85AE090", Offset = "0x85ACA90", VA = "0x1885AE090")]
	private void CNEELCICHFF(int BLAADEDFMDM, int IJBNEOEHKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x85AEE70", Offset = "0x85AD870", VA = "0x1885AEE70")]
	private void KDNNPLGPBHI(int BLAADEDFMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x85AE720", Offset = "0x85AD120", VA = "0x1885AE720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct GGEKKCKOHLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float2 MMNMLIHNLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public float2 PBKLLMHCKDD;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class DDBAJDNCHIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<GGEKKCKOHLD> EJPFOLAFPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> LCFIEFJJBPO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EANIOFGDILK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x85A5D80", Offset = "0x85A4780", VA = "0x1885A5D80")]
	public DDBAJDNCHIA(int NAADNDJPCJF, int MIOAPJGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x85A5D20", Offset = "0x85A4720", VA = "0x1885A5D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x85A5C40", Offset = "0x85A4640", VA = "0x1885A5C40")]
	public void CPDPAOLJONG(DDBAJDNCHIA IJONGALDNAB, int NLNGBLMINIC, int MHADOGLMBLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class ACCCHHKFLLN
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static DDBAJDNCHIA KMINMLEDHMD;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static NativeList<IEDPBKHCAIA> LEANBLJKFBE;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static int[] AOKJAMFODPG;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static bool FNGMDBGKLDP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static Dictionary<int, DDBAJDNCHIA> PCMONKGGCAD;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static Dictionary<int, DDBAJDNCHIA> FIEMNDFOMIO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool CFDNADCIHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x859DC30", Offset = "0x859C630", VA = "0x18859DC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<IEDPBKHCAIA> OBCIBFFHGII
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x859DCB0", Offset = "0x859C6B0", VA = "0x18859DCB0")]
		get
		{
			return default(NativeList<IEDPBKHCAIA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DDBAJDNCHIA KOOPOOMJFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x859E790", Offset = "0x859D190", VA = "0x18859E790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x859EA50", Offset = "0x859D450", VA = "0x18859EA50")]
	private static void OLOEIHHNHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x859E4A0", Offset = "0x859CEA0", VA = "0x18859E4A0")]
	public static int HKDDBCHEELP(bool AHKFEICEABB, int HPCGJIOFKJE, bool EKPKBLAJGDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x859F0D0", Offset = "0x859DAD0", VA = "0x18859F0D0")]
	private static int PFDPCJCDHBB(int HPCGJIOFKJE, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x859E780", Offset = "0x859D180", VA = "0x18859E780")]
	private static int KDBBOJNFBPF(int HPCGJIOFKJE, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x859E8C0", Offset = "0x859D2C0", VA = "0x18859E8C0")]
	public static int LMEHHMEIHAM(int ODNGOEPLNNM, int HPCGJIOFKJE, int MACIHDOHBKD, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x859DB90", Offset = "0x859C590", VA = "0x18859DB90")]
	public static int DLMCLODLGNE(int ODNGOEPLNNM, int HPCGJIOFKJE, int MACIHDOHBKD, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x859E950", Offset = "0x859D350", VA = "0x18859E950")]
	public static int MBKPBKBIGDC(int MACIHDOHBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x859DC20", Offset = "0x859C620", VA = "0x18859DC20")]
	private static int EBLGCCBDOAM(int HPCGJIOFKJE, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x859DB70", Offset = "0x859C570", VA = "0x18859DB70")]
	private static int DICPJPCMAIL(int HPCGJIOFKJE, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x859F060", Offset = "0x859DA60", VA = "0x18859F060")]
	public static int PADEBBLFFJG(int ODNGOEPLNNM, int HPCGJIOFKJE, int MACIHDOHBKD, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x859E830", Offset = "0x859D230", VA = "0x18859E830")]
	public static int KGEIHDFIILG(int ODNGOEPLNNM, int HPCGJIOFKJE, int MACIHDOHBKD, bool GJGPBPCPOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x859E760", Offset = "0x859D160", VA = "0x18859E760")]
	public static int JHJLNLLCFDI(int MACIHDOHBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x859E960", Offset = "0x859D360", VA = "0x18859E960")]
	public static DDBAJDNCHIA NAHLHGHPOMN(int HPCGJIOFKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x859E4D0", Offset = "0x859CED0", VA = "0x18859E4D0")]
	private static DDBAJDNCHIA ILMHBOLGPNI(int HPCGJIOFKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x859DA80", Offset = "0x859C480", VA = "0x18859DA80")]
	public static DDBAJDNCHIA BBELLDJDPOP(int HPCGJIOFKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x859DD50", Offset = "0x859C750", VA = "0x18859DD50")]
	private static DDBAJDNCHIA GDPLMHEGBAF(int HPCGJIOFKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x859E090", Offset = "0x859CA90", VA = "0x18859E090")]
	public static void HDFIMGOGCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct INLGPKIPFCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int INEHLDGBJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public float3 BHJCCDPAJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public quaternion FBLJEPJAHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public float PIPPKPFNAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public float MFPFLJHHHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int OCAHEHKLJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public int JCMKCPCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public int LDLDAFFONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public bool CPGEMIPKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public bool ABFBFKDDMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public float PCMMDIDGJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float3 FAIDHIOFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool ABACAEBGHAC;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct OMENJIJPFFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public int IKNBANBGJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public int PFCBECHAKDF;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct DAFNEBACFMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public NativeList<INLGPKIPFCI> EMKOEBGNAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public NativeArray<CMNLAHEDKFC> KMNJLDAEADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public NativeArray<IEDPBKHCAIA> GBIOKDKNMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public NativeArray<OMENJIJPFFC> FHAADABDEEC;

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x85A5B10", Offset = "0x85A4510", VA = "0x1885A5B10")]
	public DAFNEBACFMA(NativeArray<CMNLAHEDKFC> KMNJLDAEADG, int BCAJFCGHDKI = 1, Allocator EIOOMONCLID = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x85A5A20", Offset = "0x85A4420", VA = "0x1885A5A20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[BurstCompile]
public struct IBCPFBECDBB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private NativeArray<GGEKKCKOHLD> OABIBMMFFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[ReadOnly]
	private NativeArray<int> OPBJPCNNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[ReadOnly]
	private NativeList<IEDPBKHCAIA> MDLBDILMCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[ReadOnly]
	private NativeList<INLGPKIPFCI> EMKOEBGNAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[ReadOnly]
	private NativeArray<CMNLAHEDKFC> KMNJLDAEADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[ReadOnly]
	private NativeArray<IEDPBKHCAIA> GBIOKDKNMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[ReadOnly]
	public NativeArray<OMENJIJPFFC> FHAADABDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	private int HIBGOOKPIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	private int LEAJKHLLOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[ReadOnly]
	private float3 HKNDNBCOPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private quaternion MBMBGDNGCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private float3 GJIONIPJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EPDDAPMLBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JEOLFNOFIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EACGJLDDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CPIIHNMEEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JEHLPDGHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EMFMIFJMLKK;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x85B21F0", Offset = "0x85B0BF0", VA = "0x1885B21F0")]
	public IBCPFBECDBB(CAKHJMCNAJB CMDAIPAAAML, CIJLFCMKEEG PGGDCLHJCGE, float3 ILGFHKAOHEC, quaternion OPPMBIAGBDC, float DKJDGJNPMJE, int KLGOEONJFAE = 0, int OMCAFBLJEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x85B1FC0", Offset = "0x85B09C0", VA = "0x1885B1FC0")]
	public IBCPFBECDBB(DAFNEBACFMA CMDAIPAAAML, CIJLFCMKEEG PGGDCLHJCGE, float3 ILGFHKAOHEC, quaternion OPPMBIAGBDC, float3 DKJDGJNPMJE, int KLGOEONJFAE = 0, int OMCAFBLJEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x85B1C80", Offset = "0x85B0680", VA = "0x1885B1C80")]
	private float3 KNFEDIODHGL(float3 JDLPCGEMBFM, Matrix4x4 DKNJDKJBHCN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x85B1DC0", Offset = "0x85B07C0", VA = "0x1885B1DC0")]
	private float3x3 LOIABKPPJFH(float3x3 CEDLBMANFPK, float3x3 JDIGECNACGG)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x85B1E40", Offset = "0x85B0840", VA = "0x1885B1E40")]
	private float OMEBLKJHIIF(float NIAMAMNMMFM, float OBKGIBGPJNI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x85B0120", Offset = "0x85AEB20", VA = "0x1885B0120", Slot = "4")]
	public void Execute(int HBDKIKFKCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x85B1E50", Offset = "0x85B0850", VA = "0x1885B1E50")]
	private void PLHOEBCLLLH(int DEBGGLJPCIO, float3 KFJFDPLEJOD, float3 BJGHDDIMDNJ, float3 ILIMBEEKFNL, float JBOIDCJHBGG, bool NMMNNKMBNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x85B12C0", Offset = "0x85AFCC0", VA = "0x1885B12C0")]
	private void FDIFIFDDCDA(INLGPKIPFCI PFJGKMEEDOH, float3 FNPMGHGMCGE, float3x3 FLGMEAGNLEE, float NIAMAMNMMFM, int BOFCDOAAHNM, int HIDAHOHFIBH, int POJOLIDHLHD, float CPLMEDPHCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x85B1700", Offset = "0x85B0100", VA = "0x1885B1700")]
	private void IEODDAFONGO(int DEBGGLJPCIO, int AMEDJFICDPI, INLGPKIPFCI PFJGKMEEDOH, float3 FNPMGHGMCGE, float3x3 FLGMEAGNLEE, bool COLFDJPPJOF, float NIAMAMNMMFM, int NCNCJKIPMDA, int KCCEPIPKHIJ, int POJOLIDHLHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct LDOJFKOCFLP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeList<JEAPDJGGJKJ> ILBNDNKJJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeList<IEDPBKHCAIA> JGKDCLEMIIA;

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x85B3180", Offset = "0x85B1B80", VA = "0x1885B3180")]
	public LDOJFKOCFLP(int BCAJFCGHDKI, Allocator EIOOMONCLID = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x85B30E0", Offset = "0x85B1AE0", VA = "0x1885B30E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[BurstCompile]
public struct BKPCMJFHEDC : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private enum JJMMOHHLHEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<float3> APHOPNEPJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private NativeArray<float3> AAGPGCIBCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private NativeList<int> GGCAANMMDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	private NativeArray<int> PINCCKAJEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[ReadOnly]
	private NativeArray<float4> KACABDBGHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[ReadOnly]
	private NativeArray<float4> BPIADKAKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[ReadOnly]
	private NativeArray<float4> GCKKAICGEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[ReadOnly]
	private NativeArray<int> OICOGICMJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[ReadOnly]
	private NativeList<float3> GGMPHFDOKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[ReadOnly]
	private NativeList<IEDPBKHCAIA> MBBLMGAKEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private NativeList<JEAPDJGGJKJ> ILBNDNKJJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private NativeList<IEDPBKHCAIA> JGKDCLEMIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private int HIBGOOKPIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[ReadOnly]
	private int LEAJKHLLOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EPDDAPMLBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JEOLFNOFIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EACGJLDDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CPIIHNMEEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JEHLPDGHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BPOJJECDMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EMFMIFJMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[ReadOnly]
	private float3 GJIONIPJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	private quaternion MBMBGDNGCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	private float3 HKNDNBCOPCB;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x85A3090", Offset = "0x85A1A90", VA = "0x1885A3090")]
	public BKPCMJFHEDC(CAKHJMCNAJB CMDAIPAAAML, CIJLFCMKEEG PGGDCLHJCGE, NativeArray<int> OJOOFCMEPAB, float3 ILGFHKAOHEC, quaternion OPPMBIAGBDC, float DKJDGJNPMJE, int KLGOEONJFAE = 0, int OMCAFBLJEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x85A32A0", Offset = "0x85A1CA0", VA = "0x1885A32A0")]
	public BKPCMJFHEDC(LDOJFKOCFLP BLPDDGCLNPE, CIJLFCMKEEG PGGDCLHJCGE, NativeArray<int> OJOOFCMEPAB, float3 ILGFHKAOHEC, quaternion OPPMBIAGBDC, float3 DKJDGJNPMJE, int KLGOEONJFAE = 0, int OMCAFBLJEFL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x85A20E0", Offset = "0x85A0AE0", VA = "0x1885A20E0", Slot = "4")]
	public void Execute(int HBDKIKFKCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x85A1C80", Offset = "0x85A0680", VA = "0x1885A1C80")]
	private void BAICCALGKNB(float4x4 GOJBIBIEIGL, int HBDKIKFKCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x85A2030", Offset = "0x85A0A30", VA = "0x1885A2030")]
	private JJMMOHHLHEB BMJLEIEODAL(float3 BJGHDDIMDNJ)
	{
		return default(JJMMOHHLHEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x85A1C30", Offset = "0x85A0630", VA = "0x1885A1C30")]
	private float4 AOIOGFACCBK(JJMMOHHLHEB EHNLDKOFPFA, int KABGMIEBEFC)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x85A20A0", Offset = "0x85A0AA0", VA = "0x1885A20A0")]
	private float2 DCAHPDNGMOK(JJMMOHHLHEB EHNLDKOFPFA, float3 KFJFDPLEJOD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct NMADFFPCCPM
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public enum DIAKKDFCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public static NMADFFPCCPM BENGIKOEPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public float3 NGNFCFGNCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public float3x3 OHBEIHCPLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public float3 BFHNMDFMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public DIAKKDFCKPH EMHLKEMKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public float3 GHCKGGGJKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public float3 CBOMOIODDNF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x85B4F40", Offset = "0x85B3940", VA = "0x1885B4F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 IKFPNNKLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x85B4730", Offset = "0x85B3130", VA = "0x1885B4730")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x85B4FC0", Offset = "0x85B39C0", VA = "0x1885B4FC0")]
	public NMADFFPCCPM(float3 KFJFDPLEJOD, quaternion AMHDLJKDJBK, float3 BCAJFCGHDKI, DIAKKDFCKPH DGNODDPLLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x85B4C50", Offset = "0x85B3650", VA = "0x1885B4C50")]
	public float LBLGAHDGFBA(float3 FNPMGHGMCGE, float NKMOAGOHCIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85B4E50", Offset = "0x85B3850", VA = "0x1885B4E50")]
	public bool LIDBBJIMMHG(float3 BJGHDDIMDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x85B4AA0", Offset = "0x85B34A0", VA = "0x1885B4AA0")]
	public void KHHEOKHJDKC(float3 OBGCAEOJFNH, float3x3 LFCCMOCGKHJ, float BPOPPJPNIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x85B4640", Offset = "0x85B3040", VA = "0x1885B4640")]
	private void ANNCNDNANHD(float3 DPIEBKDJHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x85B4810", Offset = "0x85B3210", VA = "0x1885B4810")]
	public void CKBKCEPHDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[BurstCompile]
public struct MKPHBJJPFGM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[ReadOnly]
	private NativeList<NMADFFPCCPM> BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[ReadOnly]
	private NativeList<float3> JOHBJJKGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeList<int> KOOPKPLDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> GLEGDEFHMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private NativeList<IEDPBKHCAIA> JGKDCLEMIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[ReadOnly]
	private int BMIIOEEBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[ReadOnly]
	private int LPNCKFHOGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[ReadOnly]
	private float NKMOAGOHCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[ReadOnly]
	private float EFENBJKCICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> KAADHJLMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JNMJJFMKBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> FJBMIFMHGAP;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x85B45A0", Offset = "0x85B2FA0", VA = "0x1885B45A0")]
	public MKPHBJJPFGM(CIJLFCMKEEG KGGOMLADPBD, float PGAJHCPLHHG, int MHADOGLMBLF, int BOFCDOAAHNM, NativeList<NMADFFPCCPM> BLPDDGCLNPE, NativeArray<int> GLEGDEFHMKL, NativeList<IEDPBKHCAIA> JGKDCLEMIIA, LNEAKODNBNC LABLDKBHFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x85B3B10", Offset = "0x85B2510", VA = "0x1885B3B10", Slot = "4")]
	public void Execute(int PMKHJNHALML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x85B44E0", Offset = "0x85B2EE0", VA = "0x1885B44E0")]
	private bool PDJFIKFFPPP(NMADFFPCCPM EICJFDNFOCB, NMADFFPCCPM MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x85B4250", Offset = "0x85B2C50", VA = "0x1885B4250")]
	private bool MAJJGJFLEJD(NMADFFPCCPM JHDCFCMBFOH, int DGGIOBCJCGM, int OGDHGHGOOKH, int CMCLILHNAPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[BurstCompile]
public struct CCNPGBHBPIF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<int> KKECKBFLBAA;

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1531090", Offset = "0x152FA90", VA = "0x181531090")]
	public CCNPGBHBPIF(NativeArray<int> KKECKBFLBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x85A5770", Offset = "0x85A4170", VA = "0x1885A5770", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[BurstCompile]
public struct JBHNIDAALDO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<IJKBHOPHDIE.DBOPNLDFMGN> GJGINOEGPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[ReadOnly]
	private NativeArray<int> POFBIGKHFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[ReadOnly]
	private int KLGOEONJFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private int OMCAFBLJEFL;

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x85B2B60", Offset = "0x85B1560", VA = "0x1885B2B60")]
	public JBHNIDAALDO(NativeList<IJKBHOPHDIE.DBOPNLDFMGN> GJGINOEGPEM, NativeArray<int> POFBIGKHFMD, int OMCAFBLJEFL = 0, int KLGOEONJFAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x85B2AB0", Offset = "0x85B14B0", VA = "0x1885B2AB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class LNEAKODNBNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<bool> KAIEOHFLBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<int> BHGCLKDFLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<bool> FICKENOBFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<float> FAOKMDDLEGL;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x85B3380", Offset = "0x85B1D80", VA = "0x1885B3380")]
	public void LKKFJNNBNBF(int NAADNDJPCJF, int MIOAPJGCBLG, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x85B3360", Offset = "0x85B1D60", VA = "0x1885B3360")]
	public static long IMLIMKHABAL(int NAADNDJPCJF, int MIOAPJGCBLG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x85B3270", Offset = "0x85B1C70", VA = "0x1885B3270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x85B34A0", Offset = "0x85B1EA0", VA = "0x1885B34A0")]
	public void OKCDDGFOJCM(JobHandle EDFFJEFOFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LNEAKODNBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[BurstCompile]
public struct OOMLEGDAIPC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private NativeList<float3> JOHBJJKGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private NativeArray<float3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private NativeArray<float4> PMKFPPMHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<float2> NLBCCENJEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeList<int> KOOPKPLDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private NativeArray<int> PACCPKIAHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[ReadOnly]
	private NativeArray<bool> KAADHJLMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[ReadOnly]
	private NativeArray<bool> JNMJJFMKBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[ReadOnly]
	private int KLGOEONJFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[ReadOnly]
	private int OMCAFBLJEFL;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x85B5570", Offset = "0x85B3F70", VA = "0x1885B5570")]
	public OOMLEGDAIPC(CIJLFCMKEEG KGGOMLADPBD, LNEAKODNBNC LABLDKBHFIB, int OMCAFBLJEFL = 0, int KLGOEONJFAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x85B5130", Offset = "0x85B3B30", VA = "0x1885B5130", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x85B5510", Offset = "0x85B3F10", VA = "0x1885B5510")]
	private void JAAOGPJMCMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class DEJMHIAJLEN
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF6E0", Offset = "0x3BCE0E0", VA = "0x183BCF6E0")]
	public static bool ANPGPCIJDGG<T>(NativeArray<T> BHEONMJLANC, int BCAJFCGHDKI, Allocator EIOOMONCLID, NativeArrayOptions ALFCEIKBPNG = NativeArrayOptions.ClearMemory, int MDKNDNKJPFF = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF8C0", Offset = "0x3BCE2C0", VA = "0x183BCF8C0")]
	public static bool ANPGPCIJDGG<T>(NativeList<T> GBEHGKLEJFE, int BCAJFCGHDKI, Allocator EIOOMONCLID) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF980", Offset = "0x3BCE380", VA = "0x183BCF980")]
	public static bool ANPGPCIJDGG<T>(NativeQueue<T> LBPHLNLFCPC, Allocator EIOOMONCLID) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public enum OHKEILMIKJL
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Force2,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	AllOfThem
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface EGGKHJMOLHG
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GFNMLHOEIGJ(OHKEILMIKJL ODNGOEPLNNM);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BADKDKIMODJ(OHKEILMIKJL ODNGOEPLNNM);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBHMNJPAKOH GONPAKLMHDD();

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float KIDLNIDIFJE();

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCCHLLHIJGC(OHKEILMIKJL ODNGOEPLNNM, CAKHJMCNAJB HKAFIKHDBOI, int CPMOIFGEIFJ = -1);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FLEBLNMPDBF(int CDNFFIAFJLH);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class DGPDDPKNGPH
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x85A5E40", Offset = "0x85A4840", VA = "0x1885A5E40")]
	public static void HDFIMGOGCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class GNLFIFFJMFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeList<float3> HABMNAPGHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<float3> EEDIBMCHMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> LDNLGGBJJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<float4> NCCCNKGCNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<float4> FFBKJDJDDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<float4> KDFNLKAILKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> JIDMCCOBJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeList<float3> AODBDALOBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeList<int> JCLKFHPHCBF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x85AA840", Offset = "0x85A9240", VA = "0x1885AA840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EANIOFGDILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x85AA880", Offset = "0x85A9280", VA = "0x1885AA880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KPEGCELNGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x85AA8C0", Offset = "0x85A92C0", VA = "0x1885AA8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x85AB1D0", Offset = "0x85A9BD0", VA = "0x1885AB1D0")]
	public GNLFIFFJMFH(int NAADNDJPCJF, int MIOAPJGCBLG, int PLIEFPJNGPG, Allocator EIOOMONCLID = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x85AAE70", Offset = "0x85A9870", VA = "0x1885AAE70")]
	public GNLFIFFJMFH(Mesh KGGOMLADPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x85AA290", Offset = "0x85A8C90", VA = "0x1885AA290", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x85A9F60", Offset = "0x85A8960", VA = "0x1885A9F60")]
	public void CPDPAOLJONG(GNLFIFFJMFH KGGOMLADPBD, bool ANALJEHNAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x85AA3B0", Offset = "0x85A8DB0", VA = "0x1885AA3B0")]
	private void GDKFLANHIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x85AA900", Offset = "0x85A9300", VA = "0x1885AA900")]
	private void OKFIDKLGPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct IEDPBKHCAIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public int CBPHFOPIJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public int BHPFPDOJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public int NLKELMPEKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public int EANIOFGDILK;

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x22E59D0", Offset = "0x22E43D0", VA = "0x1822E59D0")]
	public IEDPBKHCAIA(int BOFCDOAAHNM, int FIFGJMDPIIE, int MHADOGLMBLF, int DCDHCGLFMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class IHEOFMLIHGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<IEDPBKHCAIA> JAFNNADBFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<IEDPBKHCAIA>);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GNLFIFFJMFH OLDNMECOABP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x85B24F0", Offset = "0x85B0EF0", VA = "0x1885B24F0")]
	public IHEOFMLIHGE(IEnumerable<GNLFIFFJMFH> PIHGOJDOLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85B2480", Offset = "0x85B0E80", VA = "0x1885B2480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum NKIPOMMBBHD
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class JFDPHAPICNN
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static NativeArray<float2> LCCLCPENIKM;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static NativeArray<float3> JONIPCGFAMI;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static NativeArray<float4> NNEEGMKCPEH;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static NativeArray<int> PMODKFLDGDM;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x85B2EB0", Offset = "0x85B18B0", VA = "0x1885B2EB0")]
	public static void HDFIMGOGCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x85B2FD0", Offset = "0x85B19D0", VA = "0x1885B2FD0")]
	public static NativeArray<float2> NGJAGOOBOAE(NativeArray<float2> HEGJDIDJNLF, int NNKAEGHNCFH, NativeArray<float2> ONGCGAOJNBK, int ODMOJEHFJPA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x85B2C90", Offset = "0x85B1690", VA = "0x1885B2C90")]
	public static NativeArray<float3> GIKKEFMFIJE(NativeArray<float3> HEGJDIDJNLF, int NNKAEGHNCFH, NativeArray<float3> ONGCGAOJNBK, int ODMOJEHFJPA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x85B2B80", Offset = "0x85B1580", VA = "0x1885B2B80")]
	public static NativeArray<float4> GAGGPJMADDI(NativeArray<float4> HEGJDIDJNLF, int NNKAEGHNCFH, NativeArray<float4> ONGCGAOJNBK, int ODMOJEHFJPA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x85B2DA0", Offset = "0x85B17A0", VA = "0x1885B2DA0")]
	public static NativeArray<int> HBHCHNLJNMG(NativeArray<int> HEGJDIDJNLF, int NNKAEGHNCFH, NativeArray<int> ONGCGAOJNBK, int ODMOJEHFJPA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3E23A60", Offset = "0x3E22460", VA = "0x183E23A60")]
	private static void JNKILMKGJCE<T>(NativeArray<T> BHEONMJLANC, int KINOKAMPOBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3E23C60", Offset = "0x3E22660", VA = "0x183E23C60")]
	private static void LBLJNCLDODM<T>(NativeArray<T> HEGJDIDJNLF, int NNKAEGHNCFH, NativeArray<T> ONGCGAOJNBK, int ODMOJEHFJPA, NativeArray<T> INMKFCBPNHJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[BurstCompile]
public class AIJOGMHPJGH
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public struct IENCEMADAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public ushort FKPKEFAKAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public ushort KEEMKILMOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public ushort JLNCPHFMCKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public ushort DDGCKIGKLFD;
	}

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x85B5B50", Offset = "0x85B4550", VA = "0x1885B5B50")]
	public static uint AGEHINGDKBI(float HKHCKBLEJDJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x85B6630", Offset = "0x85B5030", VA = "0x1885B6630")]
	public static void OLEPJGAPJCC(float4 PMKFPPMHFPK, float NBGDJLLPKMI, [Out] uint GMCKNGDLINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x85B6560", Offset = "0x85B4F60", VA = "0x1885B6560")]
	public static void OLEPJGAPJCC(float4 PMKFPPMHFPK, uint NMMHLBIFAHC, [Out] uint GMCKNGDLINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x85B5F20", Offset = "0x85B4920", VA = "0x1885B5F20")]
	public static void BDKLGNHNGBI(float3 ACGDANFMBHH, float3 ONLIDJEIMDF, float4 AJMNBKEEIKE, float2 OAIMFEAFOFD, float4 PMKFPPMHFPK, [Out] CIJLFCMKEEG.NJPIALKCOMO DODLJHKAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x85B5CC0", Offset = "0x85B46C0", VA = "0x1885B5CC0")]
	public static void BDKLGNHNGBI(float3 ACGDANFMBHH, float3 ONLIDJEIMDF, float4 AJMNBKEEIKE, float2 OAIMFEAFOFD, float4 PMKFPPMHFPK, [Out] CIJLFCMKEEG.EKJNOGMEOKF DODLJHKAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x85B6510", Offset = "0x85B4F10", VA = "0x1885B6510")]
	public static byte OKNPLOHLGAL(float KMAFNKGMDCF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x85B6170", Offset = "0x85B4B70", VA = "0x1885B6170")]
	public static ushort BGIJLCEKCJI(float KMAFNKGMDCF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x85B64E0", Offset = "0x85B4EE0", VA = "0x1885B64E0")]
	public static uint NHKBJEGOFCL(float KMAFNKGMDCF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x85B6460", Offset = "0x85B4E60", VA = "0x1885B6460")]
	public static float2 MLJFOMKNKNN(float2 FEBGNHCBECK)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x85B6310", Offset = "0x85B4D10", VA = "0x1885B6310")]
	public static float2 DACGIKGBDGO(float3 AFDFHFKFCKE)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x85B61C0", Offset = "0x85B4BC0", VA = "0x1885B61C0")]
	public static void BNHNBCJMFAJ(float3 KMAFNKGMDCF, [Out] float3 LJKEIGICLDH, [Out] uint3 DDGCKIGKLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x85B5B60", Offset = "0x85B4560", VA = "0x1885B5B60")]
	public static IENCEMADAIL ALNPKFAGIPM(float3 KFJFDPLEJOD)
	{
		return default(IENCEMADAIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class BAPOIEEOKJK
{
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker JLKGEGFCJIN;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static float EHDGBEPDGHM;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void CAJCLNJOLJN(bool MIFBJDMIIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85B6D80", Offset = "0x85B5780", VA = "0x1885B6D80")]
	public static float GEKOFKHMPFA(float DCNFJDFJKJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x85B67D0", Offset = "0x85B51D0", VA = "0x1885B67D0")]
	public static long BBBAKBPNIBM(float DCNFJDFJKJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x85B68C0", Offset = "0x85B52C0", VA = "0x1885B68C0")]
	public static void BLNBENMDKGE(float DCNFJDFJKJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface CPIMJCAICIF
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLNBENMDKGE(float DDMLJPKDDDN);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) JCGNHPDEAJO(float ELBBDBGPEMD);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class EIHPDEANBJO
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private enum IPEGGCNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		ShapesUploadMesh,
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class NJIEHMGJDEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public IPEGGCNOEFF DGNODDPLLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public BatchedMeshRenderer FGNFCDOAFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public FNHPGGDHEKD HLIAHNHACKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public IJKBHOPHDIE PBFEIAGEHPG;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x85CB8C0", Offset = "0x85CA2C0", VA = "0x1885CB8C0")]
		public void EHJPGICEMNO([Out] bool NLPEMNAIMKP, [Out] bool MEMAEACGJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NJIEHMGJDEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int MGCEGFGBEDC;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static ObjectPool<NJIEHMGJDEA> ENFKIOKNICN;

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x85B82A0", Offset = "0x85B6CA0", VA = "0x1885B82A0")]
	static EIHPDEANBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x85B8030", Offset = "0x85B6A30", VA = "0x1885B8030")]
	private static void NGPPPKIJEDI(object PNNAGAOBHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x85B7D50", Offset = "0x85B6750", VA = "0x1885B7D50")]
	private static void HLDMKOGAGAA([In] DDFPEKKFMJK OJKAKICLELC, [Out] bool NLPEMNAIMKP, [Out] bool MEMAEACGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x85B7BC0", Offset = "0x85B65C0", VA = "0x1885B7BC0")]
	public static void GFFFBEFKHND(IJKBHOPHDIE PBFEIAGEHPG, BatchedMeshRenderer FGNFCDOAFJH, long AEPIAMMPPPJ, long KIDAHGMNKND, float AFKJGEIKIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x85B78B0", Offset = "0x85B62B0", VA = "0x1885B78B0")]
	public static void AOIIBOEKMEN(IJKBHOPHDIE PBFEIAGEHPG, BatchedMeshRenderer FGNFCDOAFJH, long AEPIAMMPPPJ, long KIDAHGMNKND, float NMLIAGDOBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x85B7A40", Offset = "0x85B6440", VA = "0x1885B7A40")]
	public static void CIGDGLGONEN(FNHPGGDHEKD HLIAHNHACKK, BatchedMeshRenderer FGNFCDOAFJH, long KIDAHGMNKND, float NMLIAGDOBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x85B8110", Offset = "0x85B6B10", VA = "0x1885B8110")]
	public static void OEPKGGHHCJO(IJKBHOPHDIE PBFEIAGEHPG, BatchedMeshRenderer FGNFCDOAFJH, long AEPIAMMPPPJ, long KIDAHGMNKND, float NMLIAGDOBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85B7DF0", Offset = "0x85B67F0", VA = "0x1885B7DF0")]
	private static void MCLLKGFAKDG(IPEGGCNOEFF DGNODDPLLPC, IJKBHOPHDIE PBFEIAGEHPG, FNHPGGDHEKD HLIAHNHACKK, BatchedMeshRenderer FGNFCDOAFJH, long AEPIAMMPPPJ, long KIDAHGMNKND, float CHMFDEODFNA, bool AADANJMIAGL, bool CFJHOPLCDKF, float GMCNPLKBPIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class INFIIPNKPHK
{
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker GKBIBBNJOMG;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker ELIIABJLHNJ;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker KIKFOEDMEBD;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly ProfilerMarker CHAEJAOLJOB;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int AONBJBIMHAC;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int HLPGNCALHGJ;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int EBAKCGNKJDH;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static long PANJHOEHBNL;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static long LJAFNAKPBEF;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static long OKPAKGEADNF;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static long FLGFNADCIDJ;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int JKAHEFFIOPK;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static float BMELFGENOCI;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static bool BEJBDPHBEDM;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int CKGPLGPJPJM;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int FCAMMJNNDGC;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int LFFFBJDCFHF;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static long JLNLGGFBPEI;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static int ALIFGPKKIIE;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static bool MFLNPPIADMG;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static uint BOOHNDOBNDG;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static EFIACPIIIAJ PPGMBIANCMG;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static List<uint> JPGBEBANDEN;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static List<(DDFPEKKFMJK.NGIPONHOPJE, DDFPEKKFMJK.CAFLMIAODKN)> KELICHLLAON;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static CPIMJCAICIF KLKECHHMHIK;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static CPIMJCAICIF FPIDGONINFK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool NNACNDBPMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x85C7590", Offset = "0x85C5F90", VA = "0x1885C7590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void KMLGLJAFGML(bool MIFBJDMIIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void CAJCLNJOLJN(bool MIFBJDMIIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void KMLGLJAFGML(bool MIFBJDMIIPC, string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x85CA430", Offset = "0x85C8E30", VA = "0x1885CA430")]
	public static void HCANFGGGOLN(CPIMJCAICIF KEJCKLMOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x85CAE10", Offset = "0x85C9810", VA = "0x1885CAE10")]
	public static void JKEOEOGEOGM(CPIMJCAICIF KEJCKLMOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x85CB1F0", Offset = "0x85C9BF0", VA = "0x1885CB1F0")]
	public static (long, long, long, int, int) NNDHEBLIJMA(long NMIIFNKDJNL)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x85C9FF0", Offset = "0x85C89F0", VA = "0x1885C9FF0")]
	public static void BNDJAAIIAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x85C7920", Offset = "0x85C6320", VA = "0x1885C7920")]
	public static void BLNBENMDKGE(long NMIIFNKDJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x85CA290", Offset = "0x85C8C90", VA = "0x1885CA290")]
	public static void FPFNEBMEFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x85C75E0", Offset = "0x85C5FE0", VA = "0x1885C75E0")]
	public static long AJPPJDPEAAG(long IPCCICDBFAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x85C7850", Offset = "0x85C6250", VA = "0x1885C7850")]
	public static bool BGAGCPPDHFO(long PAHJCIGNICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x85CA1C0", Offset = "0x85C8BC0", VA = "0x1885CA1C0")]
	public static bool DMKGKBIDJBO(long PAHJCIGNICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x85CAE90", Offset = "0x85C9890", VA = "0x1885CAE90")]
	public static float NFOELICFLKP(long CEDLHJCDPHA, int ICIJJFEEEOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x85CA990", Offset = "0x85C9390", VA = "0x1885CA990")]
	public static (long, long, int) JCGNHPDEAJO(float DCNFJDFJKJF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x85CA4B0", Offset = "0x85C8EB0", VA = "0x1885CA4B0")]
	public static void HOJAGHGPCBB(DDFPEKKFMJK OJKAKICLELC, int ADKADGBONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x85CA070", Offset = "0x85C8A70", VA = "0x1885CA070")]
	public static int DDOGICCJALE(DDFPEKKFMJK.NGIPONHOPJE MEJHKIBFDDG, DDFPEKKFMJK.CAFLMIAODKN FINLEBDFGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x85C7790", Offset = "0x85C6190", VA = "0x1885C7790")]
	public static bool AKPKFGLNBMB(float BMGKKCKOGGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x85CA910", Offset = "0x85C9310", VA = "0x1885CA910")]
	public static void IFPHCKFIJKB(float BMGKKCKOGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x85CA800", Offset = "0x85C9200", VA = "0x1885CA800")]
	public static bool IDIOBCEJNDD(float BMGKKCKOGGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum PICJDHCBPNE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Persistent
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct DDFPEKKFMJK : IComparable<DDFPEKKFMJK>, IEquatable<DDFPEKKFMJK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public delegate void NGIPONHOPJE([In] DDFPEKKFMJK OJKAKICLELC, [Out] bool NLPEMNAIMKP, [Out] bool MEMAEACGJIF);

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void CAFLMIAODKN(object PNNAGAOBHKH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public PICJDHCBPNE IGNDDHOIAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public long FGEDHHGMFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public long KIDAHGMNKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public float DLKAGOFPMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public bool CFJHOPLCDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public bool AADANJMIAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public object PNNAGAOBHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal uint NMAIBBDGPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	internal int CNEAEIAMHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal CAFLMIAODKN FINLEBDFGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public float BAJJHIOFCHK;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x85B6F70", Offset = "0x85B5970", VA = "0x1885B6F70", Slot = "4")]
	private int System.IComparable<RecRoom.Core.Creation.Quartermaster.QuartermasterWorkItem>.CompareTo(DDFPEKKFMJK GOCNHGEHNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x85B6F90", Offset = "0x85B5990", VA = "0x1885B6F90", Slot = "5")]
	private bool System.IEquatable<RecRoom.Core.Creation.Quartermaster.QuartermasterWorkItem>.Equals(DDFPEKKFMJK GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class EFIACPIIIAJ
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public struct IHLDBJGFFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private List<DDFPEKKFMJK> NNCPPEOCENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private List<DDFPEKKFMJK> OPAHAAOJKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int PGKAIBKMIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int MOIAAIMDDJH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DDFPEKKFMJK IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x85BD750", Offset = "0x85BC150", VA = "0x1885BD750")]
			get
			{
				return default(DDFPEKKFMJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x85BDA20", Offset = "0x85BC420", VA = "0x1885BDA20")]
		public IHLDBJGFFHN(List<DDFPEKKFMJK> NNCPPEOCENL, List<DDFPEKKFMJK> OPAHAAOJKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x85BD8D0", Offset = "0x85BC2D0", VA = "0x1885BD8D0")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private List<DDFPEKKFMJK> NNCPPEOCENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private List<DDFPEKKFMJK> OPAHAAOJKLF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x85B7260", Offset = "0x85B5C60", VA = "0x1885B7260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x85B7170", Offset = "0x85B5B70", VA = "0x1885B7170")]
	public void HMDNMGBNKIA([In] DDFPEKKFMJK EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x85B72B0", Offset = "0x85B5CB0", VA = "0x1885B72B0")]
	public void JOCNICKKOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x85B7070", Offset = "0x85B5A70", VA = "0x1885B7070")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x85B7310", Offset = "0x85B5D10", VA = "0x1885B7310")]
	public void MBKOIKAPDOI(IEnumerable<uint> JPGBEBANDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x85B6FA0", Offset = "0x85B59A0", VA = "0x1885B6FA0")]
	private static void ABGMDFHIALK(List<DDFPEKKFMJK> GBEHGKLEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x85B76E0", Offset = "0x85B60E0", VA = "0x1885B76E0")]
	private void MCKODPOBNPM(uint NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x85B7110", Offset = "0x85B5B10", VA = "0x1885B7110")]
	public IHLDBJGFFHN FIIFAFDLDFC()
	{
		return default(IHLDBJGFFHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x85B77F0", Offset = "0x85B61F0", VA = "0x1885B77F0")]
	public EFIACPIIIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class FNHPGGDHEKD
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal enum IADMOOPGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		NoMeshRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		Mesh,
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		MeshFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		MeshRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly string DABJOJEOOOE;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly string LFJCEAIDJFE;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly ProfilerMarker KNABINOJMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static readonly ProfilerMarker LJKLINCJKKP;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly ProfilerMarker JLKGEGFCJIN;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly ProfilerMarker HDKAAAEFHBM;

	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private static readonly ProfilerMarker BFAJLJAGNKE;

	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private static readonly ProfilerMarker IFLFCLEECDP;

	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly ProfilerMarker LKMPODPCKIC;

	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private static readonly ProfilerMarker KGAPGBFPGMK;

	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private static readonly ProfilerMarker BAHBLJCODHM;

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly ProfilerMarker GCBKDCBIMKN;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly ProfilerMarker KEIMPJHJMCD;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly ProfilerMarker KNCLFCBCGEG;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ProfilerMarker NGGJJHMJMPO;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly ProfilerMarker GLNEKPDGFJP;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly ProfilerMarker MMJDFACEDDK;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly ProfilerMarker CIGKALIHKMC;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly ProfilerMarker OKJKOKAJBID;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly ProfilerMarker FCBOCNPDPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	internal readonly List<IJKBHOPHDIE> OGNIOHJEAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly HHIPOMEIBHM GKHJAILEPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private int HNCMPAAJOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int LLMHCABNPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private bool KEJGPKMPBAH;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public const bool CLANEGEMNKO = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public bool HKLIPCKILAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	internal IADMOOPGPKI OPBCKAGBHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	internal int DGDFKKPKJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	internal int GNJHMDEIPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	internal int NPFNGMNPEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	internal int GIDIHAIEHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	internal long ILDIDBDNIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	internal long EJPLONOFMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	internal long BEHHKOBKJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private CIJLFCMKEEG KNKHGBCNJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private CIJLFCMKEEG IMAHJLCILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private CIJLFCMKEEG.CKEAPDDDGNJ PHCHIOFLBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private bool AHMNFIGGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private int AFOCOIEDBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private LJEAPLELIOC BCLCGLLDABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private float3 OGGEADLDCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private float IMIFELJNLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float AEIEJOGIJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private float KODBCGINAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float AKBIPEHABGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private float BOPBPGHOIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private float BIMFFGHFEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float3 LMBLEAGBNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private float FLKHINNHKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private float DDPIGALDEOB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal Mesh OLDNMECOABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MeshFilter DDENLNMJHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MeshRenderer EGLDGGLAKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public List<Material> IJCJOBMMLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int PCPMFLDDNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xC57850", Offset = "0xC56250", VA = "0x180C57850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x85BC770", Offset = "0x85BB170", VA = "0x1885BC770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int EANIOFGDILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x85BC990", Offset = "0x85BB390", VA = "0x1885BC990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x85BCCA0", Offset = "0x85BB6A0", VA = "0x1885BCCA0")]
	public void NMFDDEIIDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x85BBBA0", Offset = "0x85BA5A0", VA = "0x1885BBBA0")]
	public bool IJCGECJLNCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x85BBE50", Offset = "0x85BA850", VA = "0x1885BBE50")]
	private void JDGNFBPJMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x85BB1C0", Offset = "0x85B9BC0", VA = "0x1885BB1C0")]
	private void FLPJLAKOMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x85BD630", Offset = "0x85BC030", VA = "0x1885BD630")]
	public FNHPGGDHEKD(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x85BCF70", Offset = "0x85BB970", VA = "0x1885BCF70")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x85BAA70", Offset = "0x85B9470", VA = "0x1885BAA70")]
	private void CBAFIPHMBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x85BBEF0", Offset = "0x85BA8F0", VA = "0x1885BBEF0")]
	private void JDLBODDMBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x85BC4F0", Offset = "0x85BAEF0", VA = "0x1885BC4F0")]
	private void KNPGLKBFHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x85BC2B0", Offset = "0x85BACB0", VA = "0x1885BC2B0")]
	public Mesh KAIDBEJNGLC(MeshFilter DIBNIOPHKMJ, Transform HALOMIKDIAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x85BC590", Offset = "0x85BAF90", VA = "0x1885BC590")]
	public void LCHMMMJOPOE(bool PDGPFKDCAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x85BC320", Offset = "0x85BAD20", VA = "0x1885BC320")]
	private void KEJKIDDMIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x85BAB10", Offset = "0x85B9510", VA = "0x1885BAB10")]
	public void DEJCHAIODNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x85BCD40", Offset = "0x85BB740", VA = "0x1885BCD40")]
	public void ODAIGGCAFEJ(EGGKHJMOLHG JOAPEIIPCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x85BABB0", Offset = "0x85B95B0", VA = "0x1885BABB0")]
	public bool DPKPHKKCHMH(EGGKHJMOLHG JOAPEIIPCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x85BB570", Offset = "0x85B9F70", VA = "0x1885BB570")]
	public bool GMMHHEEELIA(EGGKHJMOLHG JOAPEIIPCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x85BC3E0", Offset = "0x85BADE0", VA = "0x1885BC3E0", Slot = "4")]
	public virtual void KJNOIAHCKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x85BB650", Offset = "0x85BA050", VA = "0x1885BB650")]
	public void HBOMAHJJMEA(Transform HODJCPBCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x85BCA70", Offset = "0x85BB470", VA = "0x1885BCA70")]
	public bool NHJKDBCKPOF(Transform HODJCPBCHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x85B9840", Offset = "0x85B8240", VA = "0x1885B9840")]
	public bool BJMPABGPPLE(bool BONBDMCNPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x85BC100", Offset = "0x85BAB00", VA = "0x1885BC100")]
	private void JFHNMICLPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x85B9A60", Offset = "0x85B8460", VA = "0x1885B9A60")]
	public bool BLNBENMDKGE([In] float4x4 FPHHDIIPPFE, BatchedMeshRenderer DNAEBNOKKKL, bool DGLIPGCNOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x85BB4C0", Offset = "0x85B9EC0", VA = "0x1885BB4C0")]
	public bool FMFPJEDFDNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x85B8A50", Offset = "0x85B7450", VA = "0x1885B8A50")]
	public bool AFKFDADEKNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x85BB0D0", Offset = "0x85B9AD0", VA = "0x1885BB0D0")]
	public void FBAIDLLGJOP(CIJLFCMKEEG KGGOMLADPBD, int GNLDGDDBOED, int OGFDEFABNDC, float PCBHPOJJIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x85B9550", Offset = "0x85B7F50", VA = "0x1885B9550")]
	public (long, long, long) AIAPIPEPLKF()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
	public long JDDCMDKCDHK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x85B87C0", Offset = "0x85B71C0", VA = "0x1885B87C0")]
	private void AFIMGHIIHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x85BBC40", Offset = "0x85BA640", VA = "0x1885BBC40")]
	public (long, long, int) JCGNHPDEAJO(float DCNFJDFJKJF, [In] float4x4 FPHHDIIPPFE)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1004F20", Offset = "0x1003920", VA = "0x181004F20")]
	internal void AGACLJEDFED(IADMOOPGPKI ADENAMOLMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x85BA2C0", Offset = "0x85B8CC0", VA = "0x1885BA2C0")]
	internal (float, float, float, float) BPMJMMLMNON(float GIDMIJDOGMK, [In] float4x4 FPHHDIIPPFE)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x85BC790", Offset = "0x85BB190", VA = "0x1885BC790")]
	private void LOLIDLNIOOK(CIJLFCMKEEG EIBJGPKNIEE, CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG, bool IALFAOIDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x85BC9B0", Offset = "0x85BB3B0", VA = "0x1885BC9B0")]
	private void MJGFAJPJLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x85BC1A0", Offset = "0x85BABA0", VA = "0x1885BC1A0")]
	internal bool JOBMPMFDBDP(bool BONBDMCNPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x85BAD10", Offset = "0x85B9710", VA = "0x1885BAD10")]
	private void EKAOBGBJCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x85BC9D0", Offset = "0x85BB3D0", VA = "0x1885BC9D0")]
	private void MMLECHKDFHG(CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x85BB2E0", Offset = "0x85B9CE0", VA = "0x1885BB2E0")]
	private void FLPLGMBKIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x85B9650", Offset = "0x85B8050", VA = "0x1885B9650")]
	public long AJPPJDPEAAG(long IPCCICDBFAG, int ECAEBJNBFJK)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class IJKBHOPHDIE
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal enum PHHALIKHHAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public struct DBOPNLDFMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int EILINOAEIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int KAHHEMPAJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public float JNJIBPBFNFO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public struct IEBJEAJIKEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public LDODGKLHIIE KGGOMLADPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int HCEAMGDMPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int MHJFAMEKKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public long FLIIDDNGFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public long BGBMFHHEGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float LPIBILNHFLE;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x85D8E40", Offset = "0x85D7840", VA = "0x1885D8E40")]
		public void LHEJPJMHOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x85D8E70", Offset = "0x85D7870", VA = "0x1885D8E70")]
		public void OKCDDGFOJCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly string DABJOJEOOOE;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly string LFJCEAIDJFE;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker KNABINOJMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker MEDNNAGILPP;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker JLKGEGFCJIN;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker ENLOGLMKCBM;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker HDKAAAEFHBM;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker BFAJLJAGNKE;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker IFLFCLEECDP;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker LKMPODPCKIC;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker KGAPGBFPGMK;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker HPCBPOKKPGN;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker BAHBLJCODHM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker PNJFCEIAKHB;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker EHJAEHAKJKM;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker ILADLHOHOFN;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly ProfilerMarker JEFPNOHNJIE;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly ProfilerMarker GCBKDCBIMKN;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static readonly ProfilerMarker KEIMPJHJMCD;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static readonly ProfilerMarker KNCLFCBCGEG;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly ProfilerMarker NGGJJHMJMPO;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static readonly ProfilerMarker GLNEKPDGFJP;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly ProfilerMarker MMJDFACEDDK;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static readonly ProfilerMarker CIGKALIHKMC;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static readonly ProfilerMarker OKJKOKAJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal readonly List<EGGKHJMOLHG> AIBKAFMFLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal FNHPGGDHEKD KMPHIIGOLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private readonly HHIPOMEIBHM GKHJAILEPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int EEBPHOKNDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int IDGHHMDEFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal bool JBHNAINJIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal bool DBANOPHLDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal PHHALIKHHAD CBPCLNBHAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal bool MIDKIIIEABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal float3 HOODLHCNPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal float3 GBEKBEGDJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float PNALIFACFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int ONOLMDOMDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal int DDKBKMCDDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal int DDHLEPJOLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal float CDJNOPHCHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal int NDLNJHPLEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal float CCBADJPMDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float FKJNBJFBLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal int ADNAOJAGGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal long ODDKAIGHOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public int JPOMIFLBAGO;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal const int CFJBPIOJLEJ = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal float[] IJKCGNFIEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal int[] LPDAMHPHPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal long[] LLKPBDFOLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public List<IEBJEAJIKEI> DBMKPOGFHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal CIJLFCMKEEG GMKMHPAGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal long IKBDGHDBKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal int HLKEKCBKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal float NOCLEMGKJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal CIJLFCMKEEG.CKEAPDDDGNJ LFKCGOKPJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal LDODGKLHIIE KLIPILMAKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal int GGBIJEKKNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal float DLNMIJLJEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	internal long PJNHNLHJBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	internal bool MLOLBDMNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	internal AMBCEKODMKE AKLPMJEJDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	internal JobHandle HKNKCDAPNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	internal NativeList<DBOPNLDFMGN> FMHPHBFFODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	internal NativeArray<long> DJOIFOGGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	internal bool KOGLGDLCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	internal JobHandle MCIIINEAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	internal CIJLFCMKEEG JPOJKFGFIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	internal LNEAKODNBNC FBGJFCLJKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	internal NativeList<DBOPNLDFMGN> ELPACCDOCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	internal Transform BGNCKEJJOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	internal OHKEILMIKJL MNNNGAHNEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	internal long GGEOFEBGLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	internal long IPKJFOGEHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	internal long CLJGGEENHKC;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private static bool MLNMHPAKPPK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<EGGKHJMOLHG> DBJMJPPNHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x85C4990", Offset = "0x85C3390", VA = "0x1885C4990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x85C49B0", Offset = "0x85C33B0", VA = "0x1885C49B0")]
	internal void NMFDDEIIDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x85C3430", Offset = "0x85C1E30", VA = "0x1885C3430")]
	internal void JDGNFBPJMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x85C7200", Offset = "0x85C5C00", VA = "0x1885C7200")]
	internal IJKBHOPHDIE(string IELIBBNCJAC, FNHPGGDHEKD AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x85C5590", Offset = "0x85C3F90", VA = "0x1885C5590")]
	internal void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x85C45C0", Offset = "0x85C2FC0", VA = "0x1885C45C0")]
	internal void KEJKIDDMIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x85C2550", Offset = "0x85C0F50", VA = "0x1885C2550")]
	internal void HHNOMFOLCKL(EGGKHJMOLHG JOAPEIIPCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x85C2440", Offset = "0x85C0E40", VA = "0x1885C2440")]
	internal bool FIMLNJOLIPC(EGGKHJMOLHG JOAPEIIPCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x85C23E0", Offset = "0x85C0DE0", VA = "0x1885C23E0")]
	internal bool FHNMBJKOEAK(EGGKHJMOLHG JOAPEIIPCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x85C4910", Offset = "0x85C3310", VA = "0x1885C4910", Slot = "4")]
	internal virtual void KJNOIAHCKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x85BDA60", Offset = "0x85BC460", VA = "0x1885BDA60")]
	public float ABLHBONCJAK(float MJOKNNDAGEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x85C2DA0", Offset = "0x85C17A0", VA = "0x1885C2DA0")]
	public bool IPHJMFFABPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x85C2770", Offset = "0x85C1170", VA = "0x1885C2770")]
	public (LDODGKLHIIE, CIJLFCMKEEG.CKEAPDDDGNJ) HIFELHKGGGJ()
	{
		return default((LDODGKLHIIE, CIJLFCMKEEG.CKEAPDDDGNJ));
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x85C1A60", Offset = "0x85C0460", VA = "0x1885C1A60")]
	internal long COJCCJBKEDD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x85BE320", Offset = "0x85BCD20", VA = "0x1885BE320")]
	internal long AOHCFHGIIHN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x85C49C0", Offset = "0x85C33C0", VA = "0x1885C49C0")]
	internal bool NNKGIPDMCEE(Transform HODJCPBCHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x85BE980", Offset = "0x85BD380", VA = "0x1885BE980")]
	internal bool BJMPABGPPLE(bool BONBDMCNPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x85C41F0", Offset = "0x85C2BF0", VA = "0x1885C41F0")]
	internal void JFHNMICLPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x85BF840", Offset = "0x85BE240", VA = "0x1885BF840")]
	internal bool BLNBENMDKGE([In] float4x4 FPHHDIIPPFE, BatchedMeshRenderer DNAEBNOKKKL, bool DGLIPGCNOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x85BE440", Offset = "0x85BCE40", VA = "0x1885BE440")]
	internal bool BDFBPAJMGEB(bool BONBDMCNPMI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x85C5C30", Offset = "0x85C4630", VA = "0x1885C5C30")]
	internal void PJMOECJFGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x85C21C0", Offset = "0x85C0BC0", VA = "0x1885C21C0")]
	internal void FBAIDLLGJOP(CIJLFCMKEEG KGGOMLADPBD, int GNLDGDDBOED, int OGFDEFABNDC, float PCBHPOJJIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x85BE6F0", Offset = "0x85BD0F0", VA = "0x1885BE6F0")]
	internal void BFKHLHPPKGI(LDODGKLHIIE EJIMNMEKCIK, int GNLDGDDBOED, int OGFDEFABNDC, float PCBHPOJJIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x85BDB50", Offset = "0x85BC550", VA = "0x1885BDB50")]
	internal void AFIMGHIIHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x85C2FA0", Offset = "0x85C19A0", VA = "0x1885C2FA0")]
	internal (long, long, int) JCGNHPDEAJO(float DCNFJDFJKJF, [In] float4x4 FPHHDIIPPFE, float OMNEAJBHDBI)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
	internal void AGACLJEDFED(PHHALIKHHAD ADENAMOLMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x85C1410", Offset = "0x85BFE10", VA = "0x1885C1410")]
	public static (float, float, float, float) BPMJMMLMNON(float3 GHLDDEHKLFN, float3 IBFBLBFMJCH, float GIDMIJDOGMK, [In] float4x4 FPHHDIIPPFE, float OMNEAJBHDBI)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x85C1200", Offset = "0x85BFC00", VA = "0x1885C1200")]
	internal (float, float, float, float) BPMJMMLMNON(float GIDMIJDOGMK, [In] float4x4 FPHHDIIPPFE, float OMNEAJBHDBI)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x85C2190", Offset = "0x85C0B90", VA = "0x1885C2190")]
	private float EPKNKCKOALK(float GIDMIJDOGMK, [In] float4x4 FPHHDIIPPFE, float OMNEAJBHDBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x85C56C0", Offset = "0x85C40C0", VA = "0x1885C56C0")]
	private (int, int, float) PBGPGPOEPGO(float FMPDIGDDJDH)
	{
		return default((int, int, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x85C5C40", Offset = "0x85C4640", VA = "0x1885C5C40")]
	internal static float PNAMAGCGPPC(EGGKHJMOLHG KGGOMLADPBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x85C5CF0", Offset = "0x85C46F0", VA = "0x1885C5CF0")]
	internal void POICNIMOPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x85C24C0", Offset = "0x85C0EC0", VA = "0x1885C24C0")]
	internal void FLPLGMBKIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x85C21F0", Offset = "0x85C0BF0", VA = "0x1885C21F0")]
	internal void FFJLMNNGNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x85BDD40", Offset = "0x85BC740", VA = "0x1885BDD40")]
	internal long AJPPJDPEAAG(long IPCCICDBFAG, int ECAEBJNBFJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x85C3570", Offset = "0x85C1F70", VA = "0x1885C3570")]
	private void JEIPKICNCEG(CIJLFCMKEEG MANGKPCHEOD, NativeList<DBOPNLDFMGN> HBFHGDLMMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x85C1800", Offset = "0x85C0200", VA = "0x1885C1800")]
	internal void CGMDPGMPDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x85C1B10", Offset = "0x85C0510", VA = "0x1885C1B10")]
	public static void ENNKMEACGKL(NativeList<DBOPNLDFMGN> PBLBIHMEEGN, CIJLFCMKEEG MANGKPCHEOD, int ICNMCHCIFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x85C5500", Offset = "0x85C3F00", VA = "0x1885C5500")]
	private float OFKBNGPJBOF(int OLHEPHMJBDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x85C07C0", Offset = "0x85BF1C0", VA = "0x1885C07C0")]
	internal void BNAJKLMGNKH(CIJLFCMKEEG KGGOMLADPBD, EGHFPBIKHCN EJIMNMEKCIK, int GNLDGDDBOED, int OGFDEFABNDC, float PCBHPOJJIGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[BurstCompile]
internal struct JLLAOEDNMFJ : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal struct ENGGFJBNLKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int BHCLOADCPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int JEGPBNAKHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int BLODLAPBMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public float OGHLGECLKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public float PLMIKMFBLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public float LGPIPNKMNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float JLELNIDDLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	internal struct NBMKEMHIBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int BHCLOADCPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int JEGPBNAKHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int BLODLAPBMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int PCMMLNGLHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public float OGHLGECLKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public float PLMIKMFBLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public float ACKLILAJJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public float HIIBJPHDJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public float JLELNIDDLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct HABNIBCOODJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int NOBDGBKOKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public int NNCAFJJHJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public float BHBADMMCFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public delegate void FFPINAJBPJA(JLLAOEDNMFJ NIEJADHBKMD, [In] ENGGFJBNLKE HCGFBBHBICI);

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	internal static class KLJIDIHCDOG
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x85DBF20", Offset = "0x85DA920", VA = "0x1885DBF20")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x85DC050", Offset = "0x85DAA50", VA = "0x1885DC050")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x85DBC80", Offset = "0x85DA680", VA = "0x1885DBC80")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x85DBD30", Offset = "0x85DA730", VA = "0x1885DBD30")]
		public static void KDMGDDCNHFD(JLLAOEDNMFJ NIEJADHBKMD, [In] ENGGFJBNLKE HCGFBBHBICI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public delegate void NFOIOFDHION(JLLAOEDNMFJ NIEJADHBKMD, [In] NBMKEMHIBLP IGNAAKDIJFD);

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal static class AINEDHEODIK
	{
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x85CDBE0", Offset = "0x85CC5E0", VA = "0x1885CDBE0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x85CDD10", Offset = "0x85CC710", VA = "0x1885CDD10")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x85CD940", Offset = "0x85CC340", VA = "0x1885CD940")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x85CD9F0", Offset = "0x85CC3F0", VA = "0x1885CD9F0")]
		public static void KDMGDDCNHFD(JLLAOEDNMFJ NIEJADHBKMD, [In] NBMKEMHIBLP IGNAAKDIJFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public unsafe delegate void HGLOHCEHCHL(UnsafeList<int>* FEKBEHPBPPI, UnsafeList<float3>* BILJIHMBHNB, [NoAlias] float3* JJDCKCFNDFP, [NoAlias] float4* IHJEDKNEKPP, [NoAlias] float2* FNGKAOGBLGL, [NoAlias] float4* OOJLNGEOANA, UnsafeList<ECKOOFNJEOE>* LKFCGBHNCFK, UnsafeList<int>* NOMNBPJEAPJ, UnsafeList<float3>* CJNBEPJCHMF, [NoAlias] float3* NINJGDMBOIJ, [NoAlias] float4* CHBPEIPEJCC, [NoAlias] float2* BHKILBKFOHO, [NoAlias] float4* MLDDBJJCFCA, int MIOAPJGCBLG, int NAADNDJPCJF);

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	internal static class BPDOOPLBBFD
	{
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E60", Offset = "0x85D0860", VA = "0x1885D1E60")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x85D1F90", Offset = "0x85D0990", VA = "0x1885D1F90")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x85D1A70", Offset = "0x85D0470", VA = "0x1885D1A70")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B20", Offset = "0x85D0520", VA = "0x1885D1B20")]
		public unsafe static void KDMGDDCNHFD(UnsafeList<int>* FEKBEHPBPPI, UnsafeList<float3>* BILJIHMBHNB, [NoAlias] float3* JJDCKCFNDFP, [NoAlias] float4* IHJEDKNEKPP, [NoAlias] float2* FNGKAOGBLGL, [NoAlias] float4* OOJLNGEOANA, UnsafeList<ECKOOFNJEOE>* LKFCGBHNCFK, UnsafeList<int>* NOMNBPJEAPJ, UnsafeList<float3>* CJNBEPJCHMF, [NoAlias] float3* NINJGDMBOIJ, [NoAlias] float4* CHBPEIPEJCC, [NoAlias] float2* BHKILBKFOHO, [NoAlias] float4* MLDDBJJCFCA, int MIOAPJGCBLG, int NAADNDJPCJF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public float3 OGGEADLDCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public float AIGIFBGHLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public float HKHCIEKKJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public float OPKMCKJBPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public NCGJEENFMEF.DGAAAKNFAMB EFIBILGJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public bool FJCOJKBJMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ECKOOFNJEOE>* LKFCGBHNCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* NOMNBPJEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ENGGFJBNLKE>* GOAFBCOJMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ENGGFJBNLKE>* MHHBCIFKAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<NBMKEMHIBLP>* DIOFMEMHOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<NBMKEMHIBLP>* HLJGLMJDEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public int ONLJIKHOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public int PCICIEFJBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int BJOJPHJOHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe float3* CJNBEPJCHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* KFFFBICBNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe HABNIBCOODJ* DOFMOFNBENO;

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x85DAE90", Offset = "0x85D9890", VA = "0x1885DAE90")]
	private static float PADIFCLJGBO([In] JLLAOEDNMFJ NIEJADHBKMD, [In] float3 JEIGNJFNGMB, float JLELNIDDLMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x85D93C0", Offset = "0x85D7DC0", VA = "0x1885D93C0")]
	private static int EPBJMGHDNIO(JLLAOEDNMFJ NIEJADHBKMD, [Out] ECKOOFNJEOE DDIGKBBMCJN, [In] ECKOOFNJEOE IKMMHBBMCHI, [In] ECKOOFNJEOE GOFOODFMMIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x85D91A0", Offset = "0x85D7BA0", VA = "0x1885D91A0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void CJHJJLGFNPM(JLLAOEDNMFJ NIEJADHBKMD, [In] ENGGFJBNLKE HCGFBBHBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x85D8EF0", Offset = "0x85D78F0", VA = "0x1885D8EF0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void BCFKNEADACL(JLLAOEDNMFJ NIEJADHBKMD, [In] NBMKEMHIBLP IGNAAKDIJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x85D9540", Offset = "0x85D7F40", VA = "0x1885D9540", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x85DAF10", Offset = "0x85D9910", VA = "0x1885DAF10")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void PHLNALMFIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x85D9110", Offset = "0x85D7B10", VA = "0x1885D9110")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void CBIEALNNOPC(UnsafeList<int>* FEKBEHPBPPI, UnsafeList<float3>* BILJIHMBHNB, [NoAlias] float3* JJDCKCFNDFP, [NoAlias] float4* IHJEDKNEKPP, [NoAlias] float2* FNGKAOGBLGL, [NoAlias] float4* OOJLNGEOANA, UnsafeList<ECKOOFNJEOE>* LKFCGBHNCFK, UnsafeList<int>* NOMNBPJEAPJ, UnsafeList<float3>* CJNBEPJCHMF, [NoAlias] float3* NINJGDMBOIJ, [NoAlias] float4* CHBPEIPEJCC, [NoAlias] float2* BHKILBKFOHO, [NoAlias] float4* MLDDBJJCFCA, int MIOAPJGCBLG, int NAADNDJPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x85D9550", Offset = "0x85D7F50", VA = "0x1885D9550")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void GKHAMBFAGDN(JLLAOEDNMFJ NIEJADHBKMD, [In] ENGGFJBNLKE HCGFBBHBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x85D9F00", Offset = "0x85D8900", VA = "0x1885D9F00")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void HJKCBDKBDKB(JLLAOEDNMFJ NIEJADHBKMD, [In] NBMKEMHIBLP IGNAAKDIJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x85DA780", Offset = "0x85D9180", VA = "0x1885DA780")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void KALCGAMGCNB(UnsafeList<int>* FEKBEHPBPPI, UnsafeList<float3>* BILJIHMBHNB, [NoAlias] float3* JJDCKCFNDFP, [NoAlias] float4* IHJEDKNEKPP, [NoAlias] float2* FNGKAOGBLGL, [NoAlias] float4* OOJLNGEOANA, UnsafeList<ECKOOFNJEOE>* LKFCGBHNCFK, UnsafeList<int>* NOMNBPJEAPJ, UnsafeList<float3>* CJNBEPJCHMF, [NoAlias] float3* NINJGDMBOIJ, [NoAlias] float4* CHBPEIPEJCC, [NoAlias] float2* BHKILBKFOHO, [NoAlias] float4* MLDDBJJCFCA, int MIOAPJGCBLG, int NAADNDJPCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class LJEAPLELIOC
{
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private static readonly ProfilerMarker CBPAKEOKHPB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public const int BLFJBFEPJLI = 2;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private const int APDGMPNAOBN = 1;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private static int AMNGMGPINHG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private static Stack<LJEAPLELIOC> LACMDAGEAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private CIJLFCMKEEG AHLDCAEEGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private NativeList<ECKOOFNJEOE> LKFCGBHNCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NativeList<int> NOMNBPJEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private NativeList<JLLAOEDNMFJ.ENGGFJBNLKE> GOAFBCOJMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeList<JLLAOEDNMFJ.ENGGFJBNLKE> MHHBCIFKAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeList<JLLAOEDNMFJ.NBMKEMHIBLP> DIOFMEMHOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeList<JLLAOEDNMFJ.NBMKEMHIBLP> HLJGLMJDEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private JLLAOEDNMFJ NIEJADHBKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private JobHandle EDFFJEFOFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private JLLAOEDNMFJ.HABNIBCOODJ NIKIHIJGLLP;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private const int BJOJPHJOHDK = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x85DD360", Offset = "0x85DBD60", VA = "0x1885DD360")]
	private LJEAPLELIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x85DCAF0", Offset = "0x85DB4F0", VA = "0x1885DCAF0")]
	public void IICAIBEDLNG(CIJLFCMKEEG OBELCCIFDEG, float3 LAIKLLJAAJA, float GHGEHJBFHPG, float CEHOOMLGJKJ, float IMBFMCEFBIJ, List<IJKBHOPHDIE.DBOPNLDFMGN> DKJOAMADJCI, Allocator OAFNBMEOCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x85DC4B0", Offset = "0x85DAEB0", VA = "0x1885DC4B0")]
	public (bool, CIJLFCMKEEG, float) IAAKCFKOKGG(List<IJKBHOPHDIE.DBOPNLDFMGN> DKJOAMADJCI, Allocator OAFNBMEOCNK, bool BONBDMCNPMI)
	{
		return default((bool, CIJLFCMKEEG, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x85DC270", Offset = "0x85DAC70", VA = "0x1885DC270")]
	public static bool FJIFDMNFNFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x85DC220", Offset = "0x85DAC20", VA = "0x1885DC220")]
	public static int DHAPEPMFCDF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x85DC1B0", Offset = "0x85DABB0", VA = "0x1885DC1B0")]
	public static int BGMEDKMCMDN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x85DD070", Offset = "0x85DBA70", VA = "0x1885DD070")]
	public static LJEAPLELIOC LKAENFMAJHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x85DD1D0", Offset = "0x85DBBD0", VA = "0x1885DD1D0")]
	internal static void OKMNCLNJPKF(LJEAPLELIOC CBKDIMDHFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x85DCF00", Offset = "0x85DB900", VA = "0x1885DCF00")]
	public static void JEPLBCJPLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x85DC300", Offset = "0x85DAD00", VA = "0x1885DC300")]
	[JHMKPHPKHPJ(NPKHJKBGLFH.ExitingPlayMode, 0)]
	public static void HDFIMGOGCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[BurstCompile]
internal struct ECKOOFNJEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public float3 FNPMGHGMCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public int LFHAIJNPOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public int CAFOEBPAAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public int PDFAFEGNOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public float CGFLGCADNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public float HEOPLLOBDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public int ADFBGOFFJHC;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x85D8230", Offset = "0x85D6C30", VA = "0x1885D8230")]
	public static void MLAHKGEEKLJ([Out] ECKOOFNJEOE GGIKEMCHAAA, int HCCHFJLHGME, [In] float3 NADCEFHAHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x85D8280", Offset = "0x85D6C80", VA = "0x1885D8280")]
	[IgnoreWarning(1371)]
	public static void MLAHKGEEKLJ([Out] ECKOOFNJEOE GGIKEMCHAAA, [In] ECKOOFNJEOE KIEBAHDGBCK, [In] ECKOOFNJEOE FBJGDHOGOCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[BurstCompile]
internal struct AMBCEKODMKE : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private struct GGMHPHPDLED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int JAJDNAKFJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int HMJKMMEEJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int NIGGMODEBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int MJNPFHLMIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public int ONALLIDNCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public int HDNBMCNPKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public int HCEAMGDMPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int MHJFAMEKKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public float NBLBHGIGFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private struct DDCCKAICHCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public NCGJEENFMEF.AGMJBDGPLOF BMGKDPJGEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public float MJEDJLONBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public float JOPKKDCFJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public float OAKJPDGKIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public float MKMGBFLMDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public float KPNBNPALBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public float HFHNPFFAGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public float LGPCAKNDBIP;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private struct FKAKBNELHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NativeArray<float3> HABMNAPGHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NativeArray<float3> EEDIBMCHMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public NativeArray<float4> KIKJBIMBGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public NativeArray<float4> FGAMINHINPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public NativeArray<float2> LBGFAIHDOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public NativeArray<int> JCLKFHPHCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public bool ILNHNJFOLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int BHPFPDOJDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int EANIOFGDILK;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x85D89B0", Offset = "0x85D73B0", VA = "0x1885D89B0")]
		public void LKKFJNNBNBF(int NAADNDJPCJF, int MIOAPJGCBLG, Allocator EIOOMONCLID, bool KCLBMNNEJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x85D8570", Offset = "0x85D6F70", VA = "0x1885D8570")]
		public static FKAKBNELHIN LAAIEGNPOMI(CIJLFCMKEEG KGCMICBGABJ)
		{
			return default(FKAKBNELHIN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x449C500", Offset = "0x449AF00", VA = "0x18449C500")]
		private static void ICNMLGMEIHO<T>(NativeArray<T> KGCMICBGABJ, NativeArray<T> MPGFNEFLINC) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x85D8B90", Offset = "0x85D7590", VA = "0x1885D8B90")]
		public void OKCDDGFOJCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public unsafe delegate void NHPFDKAMDJB(int BIHPJACNPEN, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* PBOCDEMNFLD, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* GOEEHAIBCFL, int FIFGJMDPIIE);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	internal static class OOHKDDAEODA
	{
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x85E10D0", Offset = "0x85DFAD0", VA = "0x1885E10D0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x85E1200", Offset = "0x85DFC00", VA = "0x1885E1200")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x85E0DF0", Offset = "0x85DF7F0", VA = "0x1885E0DF0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x85E0EA0", Offset = "0x85DF8A0", VA = "0x1885E0EA0")]
		public unsafe static void KDMGDDCNHFD(int BIHPJACNPEN, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* PBOCDEMNFLD, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* GOEEHAIBCFL, int FIFGJMDPIIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private static readonly ProfilerMarker JHHJOFPIBBJ;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private static readonly ProfilerMarker HJMDBKMJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<GGMHPHPDLED> ADDFDPLFEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private FKAKBNELHIN GBPHPNGOCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private FKAKBNELHIN MANGKPCHEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private float3 HJKHDCHJDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private float3 BPLDPOGLBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private DDCCKAICHCF BLNJFFHOLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* LLGABJNFMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private NativeArray<IJKBHOPHDIE.DBOPNLDFMGN> NDCLHAGCCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private NativeList<IJKBHOPHDIE.DBOPNLDFMGN> BBBKICCDIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private NativeArray<int> NOMNBPJEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private NativeArray<bool> JNMJJFMKBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private NativeArray<int> JBLJIEGJNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private NativeArray<int> MOBKEKHJEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private NativeArray<float> DCECKMBOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private NativeArray<int> NMHJAPLOHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private NativeArray<float> PBOLEEICCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private NativeArray<int> IDGBAMCHADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private NativeArray<int> DFHBIICFBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private NativeArray<float> HNAFBECENNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private NativeArray<float> MHKDLGFJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private NativeArray<int> IAFOOPNKOEO;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x85D1150", Offset = "0x85CFB50", VA = "0x1885D1150")]
	public AMBCEKODMKE([In] List<IJKBHOPHDIE.IEBJEAJIKEI> PNGPKAGPDLC, NativeList<IJKBHOPHDIE.DBOPNLDFMGN> OIFLPLKOGBA, [In] CIJLFCMKEEG NPEJLMDHNHB, [In] NativeList<IJKBHOPHDIE.DBOPNLDFMGN> HBFHGDLMMOA, [In] NativeArray<long> DJOIFOGGBIK, float3 CHJEMLGLEEO, float3 AGGGJNBMIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x85CE870", Offset = "0x85CD270", VA = "0x1885CE870")]
	[BurstCompile]
	private unsafe static void KNAFFACDJGB(int BIHPJACNPEN, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* PBOCDEMNFLD, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* GOEEHAIBCFL, int FIFGJMDPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x85CDE70", Offset = "0x85CC870", VA = "0x1885CDE70")]
	public static long AJLJPLPLJLJ(int NAADNDJPCJF, int MIOAPJGCBLG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x85CDE90", Offset = "0x85CC890", VA = "0x1885CDE90", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x85D0630", Offset = "0x85CF030", VA = "0x1885D0630")]
	public void NMOEEIMJNOI(List<IJKBHOPHDIE.IEBJEAJIKEI> CPBFPKKJCMI, [In] IJKBHOPHDIE PPHAGHJOCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x85D1090", Offset = "0x85CFA90", VA = "0x1885D1090")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private bool PAKAOBEFMGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x85D0220", Offset = "0x85CEC20", VA = "0x1885D0220")]
	private LDODGKLHIIE LAIECBAJDDP(int DJNEIMMMKLA, Allocator EIOOMONCLID)
	{
		return default(LDODGKLHIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x85CEAE0", Offset = "0x85CD4E0", VA = "0x1885CEAE0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void KNIOLGDPPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x85CE200", Offset = "0x85CCC00", VA = "0x1885CE200")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float FGDJAPHKILG(int GGMBIEECKFM, int OPCHDBCLIBN, bool BNMNFBOODNB, bool CKCMMOIHEBF, float IDKAPJBIDLB, float GMGJHLFFBIH, float CGNDCHLKJLA, float MGLBAIMBPLB, float CJEKCLHPDAJ, float KHGCNLJFAIP, float KHPICPLCCGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x85CDEE0", Offset = "0x85CC8E0", VA = "0x1885CDEE0")]
	[IgnoreWarning(1371)]
	private GGMHPHPDLED FCPHKEHFEDI([In] GGMHPHPDLED FFIHIAMFBCH, int EGCNLCCPABB, [In] NativeArray<int> KOOPKPLDCDJ, [In] NativeArray<bool> JNMJJFMKBCH, NativeArray<int> JBLJIEGJNKP)
	{
		return default(GGMHPHPDLED);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x85D0450", Offset = "0x85CEE50", VA = "0x1885D0450")]
	public static int MBKONMAELCO(NativeArray<int> KOOPKPLDCDJ, NativeArray<int> IAFOOPNKOEO, int DFJPAPCPHCM, int LPPCDLIGFDA, int NBLJDFPBAPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x85CBFC0", Offset = "0x85CA9C0", VA = "0x1885CBFC0")]
	[BurstCompile]
	public unsafe static void EKJCMMDDNBD(int BIHPJACNPEN, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* PBOCDEMNFLD, [In][NoAlias] IJKBHOPHDIE.DBOPNLDFMGN* GOEEHAIBCFL, int FIFGJMDPIIE)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		private struct GJGODJCLNDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public long HFCJKPGGDJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public CBHMNJPAKOH KAKALMLAPHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public EGGKHJMOLHG ENDDNPPKCPO;

			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x85D8C50", Offset = "0x85D7650", VA = "0x1885D8C50")]
			public GJGODJCLNDD(CBHMNJPAKOH OHOHBLGCGBL, EGGKHJMOLHG EABBLCBEBIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		private class OOIPICALIPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public CBHMNJPAKOH KAKALMLAPHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public int FIFGJMDPIIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public float PNALIFACFAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public List<GJGODJCLNDD> DCLCADNMNHL;

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x85E1360", Offset = "0x85DFD60", VA = "0x1885E1360")]
			public OOIPICALIPB(CBHMNJPAKOH OHOHBLGCGBL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private static readonly ProfilerMarker IPKBBGCNDOE;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private static readonly ProfilerMarker MKODHKIIHHH;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private static readonly ProfilerMarker EOBNIBEOMJJ;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private static readonly ProfilerMarker BPIEHLKAKFM;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly ProfilerMarker OOHHOBIFEBP;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private static readonly ProfilerMarker IFLFCLEECDP;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static readonly ProfilerMarker LIHIEEECHIG;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		internal const int ENHONJHFOEO = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		internal static Dictionary<Material, List<Material>> CDAFPLMFGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Dictionary<Material, List<FNHPGGDHEKD>> LDHIPMPHPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		internal List<FNHPGGDHEKD> JEHPGBLOPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private List<MeshRenderer> DKOEIBIOOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private Transform OAEEPEDFFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private bool MCHDDKGPIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private bool LMBPNAOFIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private int LEFKKHDEMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private FNHPGGDHEKD CLBKJFGGCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private Material JKKGOJCEBDF;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private static bool? JBLCGIHDEFE;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private const int BBHIDHFPPKG = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private static List<GJGODJCLNDD> AIJBLMNFPNK;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<MeshRenderer> OOBEHIPJBMB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int JBGFMLLNJMA
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x85D81E0", Offset = "0x85D6BE0", VA = "0x1885D81E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private static bool IHEAEINFDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x85D39F0", Offset = "0x85D23F0", VA = "0x1885D39F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private static void KMLGLJAFGML(bool MIFBJDMIIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private static void KMLGLJAFGML(bool MIFBJDMIIPC, string JEBOHIALEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private static void ODBJGCOJKKB(string IELIBBNCJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x85D2570", Offset = "0x85D0F70", VA = "0x1885D2570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x85D2310", Offset = "0x85D0D10", VA = "0x1885D2310")]
		internal bool APDNPCBOANA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x85D3C20", Offset = "0x85D2620", VA = "0x1885D3C20")]
		private Transform LFGKPPMBPOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x85D49E0", Offset = "0x85D33E0", VA = "0x1885D49E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x85D2EA0", Offset = "0x85D18A0", VA = "0x1885D2EA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x85D2370", Offset = "0x85D0D70", VA = "0x1885D2370")]
		public FNHPGGDHEKD AddToBatchedMesh(EGGKHJMOLHG CBPJCDDJNHJ, Material PJPBFBIEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x85D7BA0", Offset = "0x85D65A0", VA = "0x1885D7BA0")]
		public void RemoveFromBatchedMesh(EGGKHJMOLHG KGGOMLADPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x85D26D0", Offset = "0x85D10D0", VA = "0x1885D26D0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x85D3290", Offset = "0x85D1C90", VA = "0x1885D3290")]
		private void EMEFHAAADKL(Renderer ALKNEOONPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x85D3980", Offset = "0x85D2380", VA = "0x1885D3980")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x85D3970", Offset = "0x85D2370", VA = "0x1885D3970")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x85D3CA0", Offset = "0x85D26A0", VA = "0x1885D3CA0")]
		private void MKNMHDNAPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x85D4420", Offset = "0x85D2E20", VA = "0x1885D4420")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x85D20F0", Offset = "0x85D0AF0", VA = "0x1885D20F0")]
		private FNHPGGDHEKD ANEONPEBBLN(EGGKHJMOLHG KGGOMLADPBD, Material PJPBFBIEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x85D49F0", Offset = "0x85D33F0", VA = "0x1885D49F0")]
		private FNHPGGDHEKD PJHMJNCCHAL(Material PJPBFBIEGMK, int DDOBHJKECFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x85D2800", Offset = "0x85D1200", VA = "0x1885D2800")]
		private FNHPGGDHEKD DFCFBLOMBGL(Material PJPBFBIEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x85D4950", Offset = "0x85D3350", VA = "0x1885D4950")]
		internal void NAPAFJLCHEP([Out] float4x4 FPHHDIIPPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x85D3310", Offset = "0x85D1D10", VA = "0x1885D3310")]
		public static List<Material> GenerateVertexFormatVariants(Material PJPBFBIEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x85D7CE0", Offset = "0x85D66E0", VA = "0x1885D7CE0")]
		public static void UpdateMaterialVariants(Material PCABBLKGHFI, Action<Material> CFFEJAMPCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x12B56A0", Offset = "0x12B40A0", VA = "0x1812B56A0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x85D42C0", Offset = "0x85D2CC0", VA = "0x1885D42C0")]
		public void MarkDirty(EGGKHJMOLHG KGGOMLADPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x85D3B20", Offset = "0x85D2520", VA = "0x1885D3B20")]
		[Conditional("CHECK_STATE")]
		private void LBLBOFPMCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x85D4580", Offset = "0x85D2F80", VA = "0x1885D4580")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float DCNFJDFJKJF)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x85D25A0", Offset = "0x85D0FA0", VA = "0x1885D25A0")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x85D68E0", Offset = "0x85D52E0", VA = "0x1885D68E0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x85D3430", Offset = "0x85D1E30", VA = "0x1885D3430")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x85D4DB0", Offset = "0x85D37B0", VA = "0x1885D4DB0")]
		public void RebatchOptimally(int HGKICEPEGCH, int EMBINODJPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x85D4CD0", Offset = "0x85D36D0", VA = "0x1885D4CD0")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x85D80B0", Offset = "0x85D6AB0", VA = "0x1885D80B0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class OCMEOCNMNLC
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private struct IFCGILHGCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public BatchedMeshRenderer ALKNEOONPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public FNHPGGDHEKD KGGOMLADPBD;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1D45BB0", Offset = "0x1D445B0", VA = "0x181D45BB0")]
		public void NKELCENPCLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private struct NEALFMHCBGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public float MNGBKBCIJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public FNHPGGDHEKD JDPNOFACJIH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private sealed class PLGECNDPCNP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x1341D00", Offset = "0x1340700", VA = "0x181341D00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x85E3870", Offset = "0x85E2270", VA = "0x1885E3870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x15CE630", Offset = "0x15CD030", VA = "0x1815CE630")]
		[DebuggerHidden]
		public PLGECNDPCNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x85E38C0", Offset = "0x85E22C0", VA = "0x1885E38C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x85E2460", Offset = "0x85E0E60", VA = "0x1885E2460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x85E2410", Offset = "0x85E0E10", VA = "0x1885E2410")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x85E3720", Offset = "0x85E2120", VA = "0x1885E3720")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x85E3820", Offset = "0x85E2220", VA = "0x1885E3820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x85E3770", Offset = "0x85E2170", VA = "0x1885E3770", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x85E3770", Offset = "0x85E2170", VA = "0x1885E3770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private static readonly ProfilerMarker IFLFCLEECDP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static readonly ProfilerMarker FKNGCHGHPNG;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static readonly ProfilerMarker AEGIPJBFMIA;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static readonly ProfilerMarker FEPILMCGPMF;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static float3 GNOFBGJJKPM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static int MKCNJPNPNDP;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int GLIDDALNDCE;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static int ANNOPAEOEJF;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static int DDCIDAKHOPI;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static int HNHLOCNCMDL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static float LIGHGALLHPF;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static float KHPEJHLNDEP;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static float MKIPCPNAGAN;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static float NAJPHFKJBFK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static float NMLGIEANAFJ;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static float EBHEKPMKEDO;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static float KCNKBNHHOPI;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static float NHNPIBKJCAI;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static List<BatchedMeshRenderer> FLKOBHJJLPK;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private static Stack<CIJLFCMKEEG> ACFBAICAPBH;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private static Stack<LNEAKODNBNC> GBBAKFIOODM;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static ONEMHINNGHH EAIEJMBCLCO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static IFCGILHGCBK OLBLCFFNLAI;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static int ECKLDLJOBEB;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void KMLGLJAFGML(bool MIFBJDMIIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void CAJCLNJOLJN(bool MIFBJDMIIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void KMLGLJAFGML(bool MIFBJDMIIPC, string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x85E0460", Offset = "0x85DEE60", VA = "0x1885E0460")]
	public static void LHEJPJMHOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x85DFCD0", Offset = "0x85DE6D0", VA = "0x1885DFCD0")]
	public static void IBFBLILAKOK(BatchedMeshRenderer FCHLACHKNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x85E0640", Offset = "0x85DF040", VA = "0x1885E0640")]
	public static void NMOPDDHLGCG(BatchedMeshRenderer FCHLACHKNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x85DE100", Offset = "0x85DCB00", VA = "0x1885DE100")]
	public static void BKEHBIDCMEC(EGGKHJMOLHG JOAPEIIPCKI, bool PDGPFKDCAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x85DF7E0", Offset = "0x85DE1E0", VA = "0x1885DF7E0")]
	public static void HIGCFEOKNIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x85DE850", Offset = "0x85DD250", VA = "0x1885DE850")]
	public static void BLNBENMDKGE(float DCNFJDFJKJF, bool HHODMCAHPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x85DF360", Offset = "0x85DDD60", VA = "0x1885DF360")]
	private static void EJDNDNOGLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x85DD5F0", Offset = "0x85DBFF0", VA = "0x1885DD5F0")]
	public static long AJPPJDPEAAG(int ECAEBJNBFJK, long IPCCICDBFAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x85DFDF0", Offset = "0x85DE7F0", VA = "0x1885DFDF0")]
	public static (long, long, int) JCGNHPDEAJO(float DCNFJDFJKJF)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x85DE080", Offset = "0x85DCA80", VA = "0x1885DE080")]
	[IteratorStateMachine(typeof(PLGECNDPCNP))]
	public static IEnumerable<bool> AKBEAABGFIL(long EOKJNCGNKGD, bool DPOFFDDLGMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x85DF100", Offset = "0x85DDB00", VA = "0x1885DF100")]
	public static void EAHDDKDIAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x85E01C0", Offset = "0x85DEBC0", VA = "0x1885E01C0")]
	public static void JINJPJIHIHI(long EOKJNCGNKGD, bool DPOFFDDLGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x85E04C0", Offset = "0x85DEEC0", VA = "0x1885E04C0")]
	public static int NDKEFBGJCGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x85DFB50", Offset = "0x85DE550", VA = "0x1885DFB50")]
	internal static CIJLFCMKEEG HNKFEEPLGMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x85E07D0", Offset = "0x85DF1D0", VA = "0x1885E07D0")]
	internal static void OKMNCLNJPKF(CIJLFCMKEEG FBGHJGMIHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x85E0880", Offset = "0x85DF280", VA = "0x1885E0880")]
	internal static LNEAKODNBNC PCFAONOCHNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x85E0740", Offset = "0x85DF140", VA = "0x1885E0740")]
	internal static void OKMNCLNJPKF(LNEAKODNBNC LABLDKBHFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x85E0000", Offset = "0x85DEA00", VA = "0x1885E0000")]
	public static void JEPLBCJPLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class PFBDIMCADPH<KeyType> : FNHPGGDHEKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly Dictionary<KeyType, EGGKHJMOLHG> PIIIIHBLGIE;

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2C70", Offset = "0x5CA1670", VA = "0x185CA2C70")]
	public PFBDIMCADPH(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2A80", Offset = "0x5CA1480", VA = "0x185CA2A80")]
	public void ODAIGGCAFEJ(KeyType HPFHOBCPNEF, EGGKHJMOLHG JOAPEIIPCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2BA0", Offset = "0x5CA15A0", VA = "0x185CA2BA0")]
	public bool PAOFNKDCDKI(KeyType HPFHOBCPNEF, EGGKHJMOLHG BPNEALIFGIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5CA29D0", Offset = "0x5CA13D0", VA = "0x185CA29D0")]
	public void NMACKDDGPOO(KeyType HPFHOBCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5CA28E0", Offset = "0x5CA12E0", VA = "0x185CA28E0", Slot = "4")]
	public override void KJNOIAHCKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class NNFPNNHMKBL
{
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly ProfilerCategory LLKLFEOCGKH;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	internal static readonly ProfilerMarker NFOELICFLKP;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	internal static readonly MEDPEEKHCLL BLNBENMDKGE;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private static readonly FGANCMFIHOK<float> GOKBOEHBCOE;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private static readonly FGANCMFIHOK<float> FGJDOJBFPOM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	private static readonly FGANCMFIHOK<float> KDLFCAHLKMM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private static readonly FGANCMFIHOK<double> IBLMCGJBDIP;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private static readonly FGANCMFIHOK<double> DACPNAILBML;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private static readonly FGANCMFIHOK<double> HFICHLGKGOE;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private static readonly FGANCMFIHOK<double> NCLOIKCHBAE;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private static readonly FGANCMFIHOK<int> CHPGEOEGKGI;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private static readonly FGANCMFIHOK<int> JOBKDLDIEGJ;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private static readonly FGANCMFIHOK<int> BFLNEMBPCKM;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private static readonly FGANCMFIHOK<int> IKLDNHNJKOL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private static readonly FGANCMFIHOK<int> AFANADIFMGP;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private static readonly FGANCMFIHOK<int> HGCLFMGAHPG;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private static readonly FGANCMFIHOK<int> OAKAFHEPLGD;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private static readonly FGANCMFIHOK<int> JABBMMJOAMC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private static readonly FGANCMFIHOK<long> EGJGAAAPFFG;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private static readonly FGANCMFIHOK<long> MDEAHDHNJJL;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static readonly FGANCMFIHOK<long> NEIOLFKKCHL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly FGANCMFIHOK<long> KBAPAPDMLMI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly FGANCMFIHOK<long> JNCMLDCCDPK;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly FGANCMFIHOK<long> MODANDLFJMH;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x85E1560", Offset = "0x85DFF60", VA = "0x1885E1560")]
	public static void COACEJCJEIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x85E39E0", Offset = "0x85E23E0", VA = "0x1885E39E0")]
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
