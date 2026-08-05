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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D170", Offset = "0x7D2C370", VA = "0x187D2D170", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class IDLCOLCEJIC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FODGIOKBGBI BNCEKBECEHL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly FODGIOKBGBI IMIJMDMHPOE;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly FODGIOKBGBI DJEMCCDGFOB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly FODGIOKBGBI LIBKMFOGNAC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly FODGIOKBGBI KOAPIGFCFLP;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class AIMLMOOPPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public JFNLGADNLID NFEAHFMGOCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KLACLIDIDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AIMLMOOPPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct JFNLGADNLID
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct FJFDCDPAJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half DJIIOLCDMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort BAFPHHDPDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte ECFCNHMCOMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void KIJDDNFDCJL([NoAlias] float3* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class FHEKGOOEINA
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C9D0", Offset = "0x7D1BBD0", VA = "0x187D1C9D0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CAF0", Offset = "0x7D1BCF0", VA = "0x187D1CAF0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C710", Offset = "0x7D1B910", VA = "0x187D1C710")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C7B0", Offset = "0x7D1B9B0", VA = "0x187D1C7B0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] float3* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void BKHACEBGPKK([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class EFOFHFBJPAC
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AF80", Offset = "0x7D1A180", VA = "0x187D1AF80")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B0A0", Offset = "0x7D1A2A0", VA = "0x187D1B0A0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AC40", Offset = "0x7D19E40", VA = "0x187D1AC40")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D1ACE0", Offset = "0x7D19EE0", VA = "0x187D1ACE0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void EJBPBAPBFDM([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class PHINDPOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7D389E0", Offset = "0x7D37BE0", VA = "0x187D389E0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D38B00", Offset = "0x7D37D00", VA = "0x187D38B00")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D386A0", Offset = "0x7D378A0", VA = "0x187D386A0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D38740", Offset = "0x7D37940", VA = "0x187D38740")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void LGLHIDJENNJ([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class LPHCAGEDOIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CF00", Offset = "0x7D2C100", VA = "0x187D2CF00")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D020", Offset = "0x7D2C220", VA = "0x187D2D020")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CBC0", Offset = "0x7D2BDC0", VA = "0x187D2CBC0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CC60", Offset = "0x7D2BE60", VA = "0x187D2CC60")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void LBKFECIJPOC([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class ODLMHOAKHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F400", Offset = "0x7D2E600", VA = "0x187D2F400")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F520", Offset = "0x7D2E720", VA = "0x187D2F520")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F0C0", Offset = "0x7D2E2C0", VA = "0x187D2F0C0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F160", Offset = "0x7D2E360", VA = "0x187D2F160")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void DGGMOBPMADK([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class DBLMJEOGLOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D19E00", Offset = "0x7D19000", VA = "0x187D19E00")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D19F20", Offset = "0x7D19120", VA = "0x187D19F20")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D19A30", Offset = "0x7D18C30", VA = "0x187D19A30")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D19AD0", Offset = "0x7D18CD0", VA = "0x187D19AD0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void PHDMCDGOPKN([NoAlias] ushort* HFBLFGBFMLB, [Out] float3 OGCMGJCEIJK, [Out] float3 IIJLEOMGNOM, [In][NoAlias] float3* JFCONLOMDBF, int ANNLKNMOFHP, int HGFLJHNNBAG);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class OKEINGAGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FFD0", Offset = "0x7D2F1D0", VA = "0x187D2FFD0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D300F0", Offset = "0x7D2F2F0", VA = "0x187D300F0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FD00", Offset = "0x7D2EF00", VA = "0x187D2FD00")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FDA0", Offset = "0x7D2EFA0", VA = "0x187D2FDA0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] ushort* HFBLFGBFMLB, [Out] float3 OGCMGJCEIJK, [Out] float3 IIJLEOMGNOM, [In][NoAlias] float3* JFCONLOMDBF, int ANNLKNMOFHP, int HGFLJHNNBAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void MOHCIEBJFCN([NoAlias] ushort* IFJGGCFCMCO, [In][NoAlias] float3* DEDFHGIPCCG, int HGFLJHNNBAG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class ABCAJOKCMCG
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D17660", Offset = "0x7D16860", VA = "0x187D17660")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D17780", Offset = "0x7D16980", VA = "0x187D17780")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D173C0", Offset = "0x7D165C0", VA = "0x187D173C0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D17460", Offset = "0x7D16660", VA = "0x187D17460")]
		public unsafe static void ENEDPBAOBKF([NoAlias] ushort* IFJGGCFCMCO, [In][NoAlias] float3* DEDFHGIPCCG, int HGFLJHNNBAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void FNPJOHKOPCF([NoAlias] float3* KMLMHEGGICE, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class JGFKJELOOBA
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A590", Offset = "0x7D29790", VA = "0x187D2A590")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A6B0", Offset = "0x7D298B0", VA = "0x187D2A6B0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A2F0", Offset = "0x7D294F0", VA = "0x187D2A2F0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A390", Offset = "0x7D29590", VA = "0x187D2A390")]
		public unsafe static void ENEDPBAOBKF([NoAlias] float3* KMLMHEGGICE, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void PEDKCCPFHDB([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class OEALCKGGMLD
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F910", Offset = "0x7D2EB10", VA = "0x187D2F910")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FA30", Offset = "0x7D2EC30", VA = "0x187D2FA30")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F670", Offset = "0x7D2E870", VA = "0x187D2F670")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F710", Offset = "0x7D2E910", VA = "0x187D2F710")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void HEIHGHJIICD([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class JHPGODAMAIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AB90", Offset = "0x7D29D90", VA = "0x187D2AB90")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D2ACB0", Offset = "0x7D29EB0", VA = "0x187D2ACB0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A800", Offset = "0x7D29A00", VA = "0x187D2A800")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A8A0", Offset = "0x7D29AA0", VA = "0x187D2A8A0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void NLDAIGMBIDI([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class JNJBJADCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B7C0", Offset = "0x7D2A9C0", VA = "0x187D2B7C0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B8E0", Offset = "0x7D2AAE0", VA = "0x187D2B8E0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B430", Offset = "0x7D2A630", VA = "0x187D2B430")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B4D0", Offset = "0x7D2A6D0", VA = "0x187D2B4D0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void IFFNAHIJLLI([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class NEGEHNJKOAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E4F0", Offset = "0x7D2D6F0", VA = "0x187D2E4F0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E610", Offset = "0x7D2D810", VA = "0x187D2E610")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E130", Offset = "0x7D2D330", VA = "0x187D2E130")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E1D0", Offset = "0x7D2D3D0", VA = "0x187D2E1D0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void HPENPLPIJKI([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class KLNJKMLNDCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C330", Offset = "0x7D2B530", VA = "0x187D2C330")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C450", Offset = "0x7D2B650", VA = "0x187D2C450")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7D2BF70", Offset = "0x7D2B170", VA = "0x187D2BF70")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C010", Offset = "0x7D2B210", VA = "0x187D2C010")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void CALCLPNBBFP([NoAlias] uint* GJEMOMACNFA, [Out] float2 DGNLBDCPLHH, [Out] float2 FFHLABDMDPM, [In][NoAlias] float2* IELKJLAKEBH, int ANNLKNMOFHP, int HGFLJHNNBAG);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class PBJMICJNIDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D30D90", Offset = "0x7D2FF90", VA = "0x187D30D90")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D30EB0", Offset = "0x7D300B0", VA = "0x187D30EB0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7D30AC0", Offset = "0x7D2FCC0", VA = "0x187D30AC0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D30B60", Offset = "0x7D2FD60", VA = "0x187D30B60")]
		public unsafe static void ENEDPBAOBKF([NoAlias] uint* GJEMOMACNFA, [Out] float2 DGNLBDCPLHH, [Out] float2 FFHLABDMDPM, [In][NoAlias] float2* IELKJLAKEBH, int ANNLKNMOFHP, int HGFLJHNNBAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void PGIDHHJPMPM([Out] float2 IJFAELOGEEF, uint DAOKDAMGDCJ, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class JEBNFILLMLD
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D202A0", Offset = "0x7D1F4A0", VA = "0x187D202A0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D203C0", Offset = "0x7D1F5C0", VA = "0x187D203C0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1FFB0", Offset = "0x7D1F1B0", VA = "0x187D1FFB0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D20050", Offset = "0x7D1F250", VA = "0x187D20050")]
		public static void ENEDPBAOBKF([Out] float2 IJFAELOGEEF, uint DAOKDAMGDCJ, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void FGAABNNHBOI([NoAlias] float2* GJEMOMACNFA, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class HCLNCCNEINM
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F5B0", Offset = "0x7D1E7B0", VA = "0x187D1F5B0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F6D0", Offset = "0x7D1E8D0", VA = "0x187D1F6D0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F230", Offset = "0x7D1E430", VA = "0x187D1F230")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F2D0", Offset = "0x7D1E4D0", VA = "0x187D1F2D0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] float2* GJEMOMACNFA, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void HHEBLLPNJFI([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class MHFDHJKOLAN
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D860", Offset = "0x7D2CA60", VA = "0x187D2D860")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D980", Offset = "0x7D2CB80", VA = "0x187D2D980")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D4A0", Offset = "0x7D2C6A0", VA = "0x187D2D4A0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D540", Offset = "0x7D2C740", VA = "0x187D2D540")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void AHGCIJFOLGP([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class FPBAHNIFECP
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DAD0", Offset = "0x7D1CCD0", VA = "0x187D1DAD0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DBF0", Offset = "0x7D1CDF0", VA = "0x187D1DBF0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D710", Offset = "0x7D1C910", VA = "0x187D1D710")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D7B0", Offset = "0x7D1C9B0", VA = "0x187D1D7B0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void EJLAOCPNIFK([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class BDECBFOAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7D187C0", Offset = "0x7D179C0", VA = "0x187D187C0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7D188E0", Offset = "0x7D17AE0", VA = "0x187D188E0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7D18500", Offset = "0x7D17700", VA = "0x187D18500")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7D185A0", Offset = "0x7D177A0", VA = "0x187D185A0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void PLDENFPGPEH([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class LJAKHAJIOLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C950", Offset = "0x7D2BB50", VA = "0x187D2C950")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CA70", Offset = "0x7D2BC70", VA = "0x187D2CA70")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C5A0", Offset = "0x7D2B7A0", VA = "0x187D2C5A0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C640", Offset = "0x7D2B840", VA = "0x187D2C640")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void LIHHCIAOFNL([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class AHKMBOMDCPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7D18290", Offset = "0x7D17490", VA = "0x187D18290")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7D183B0", Offset = "0x7D175B0", VA = "0x187D183B0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D17EE0", Offset = "0x7D170E0", VA = "0x187D17EE0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7D17F80", Offset = "0x7D17180", VA = "0x187D17F80")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void NDHHDBFBJPM([NoAlias] ushort* NHNIKMFNMBE, [In][NoAlias] float4* MHMPOMOAAEL, int ANNLKNMOFHP, int HGFLJHNNBAG);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class PLOFDMPMLJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7D39140", Offset = "0x7D38340", VA = "0x187D39140")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7D39260", Offset = "0x7D38460", VA = "0x187D39260")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7D38E10", Offset = "0x7D38010", VA = "0x187D38E10")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7D38EB0", Offset = "0x7D380B0", VA = "0x187D38EB0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] ushort* NHNIKMFNMBE, [In][NoAlias] float4* MHMPOMOAAEL, int ANNLKNMOFHP, int HGFLJHNNBAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort JEBAHCMDOGH([In] float4 AJMIONOMGNA);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class MOPPKGLHEIC
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7D2DDC0", Offset = "0x7D2CFC0", VA = "0x187D2DDC0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7D2DEE0", Offset = "0x7D2D0E0", VA = "0x187D2DEE0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D2DAD0", Offset = "0x7D2CCD0", VA = "0x187D2DAD0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2DB70", Offset = "0x7D2CD70", VA = "0x187D2DB70")]
		public static ushort ENEDPBAOBKF([In] float4 AJMIONOMGNA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void CIOHNEIJMIA([NoAlias] float4* NHNIKMFNMBE, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class ECBABMAIMKO
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A9D0", Offset = "0x7D19BD0", VA = "0x187D1A9D0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AAF0", Offset = "0x7D19CF0", VA = "0x187D1AAF0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A6A0", Offset = "0x7D198A0", VA = "0x187D1A6A0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A740", Offset = "0x7D19940", VA = "0x187D1A740")]
		public unsafe static void ENEDPBAOBKF([NoAlias] float4* NHNIKMFNMBE, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void GGFACCJNFHN([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class FCMPJLAPOKK
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C4A0", Offset = "0x7D1B6A0", VA = "0x187D1C4A0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C5C0", Offset = "0x7D1B7C0", VA = "0x187D1C5C0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C200", Offset = "0x7D1B400", VA = "0x187D1C200")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C2A0", Offset = "0x7D1B4A0", VA = "0x187D1C2A0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void IGEFKKFNOEP([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class JMLHEEMGEIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B1C0", Offset = "0x7D2A3C0", VA = "0x187D2B1C0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B2E0", Offset = "0x7D2A4E0", VA = "0x187D2B2E0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AE00", Offset = "0x7D2A000", VA = "0x187D2AE00")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AEA0", Offset = "0x7D2A0A0", VA = "0x187D2AEA0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void CFLFOIIDIAH([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class DNGPPBKKGIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A430", Offset = "0x7D19630", VA = "0x187D1A430")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A550", Offset = "0x7D19750", VA = "0x187D1A550")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A070", Offset = "0x7D19270", VA = "0x187D1A070")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A110", Offset = "0x7D19310", VA = "0x187D1A110")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void EDIHPIAKHND([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class PHBMINGAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7D38430", Offset = "0x7D37630", VA = "0x187D38430")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7D38550", Offset = "0x7D37750", VA = "0x187D38550")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7D38000", Offset = "0x7D37200", VA = "0x187D38000")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7D380A0", Offset = "0x7D372A0", VA = "0x187D380A0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void MPEDJMMKNAK([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class ODGNDFNKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EE50", Offset = "0x7D2E050", VA = "0x187D2EE50")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EF70", Offset = "0x7D2E170", VA = "0x187D2EF70")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EA20", Offset = "0x7D2DC20", VA = "0x187D2EA20")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EAC0", Offset = "0x7D2DCC0", VA = "0x187D2EAC0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void CEJNLMEEGOC([Out] float4 IGGKBIDIAJL, ushort DAOKDAMGDCJ);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class FHKDKBGEECL
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CF70", Offset = "0x7D1C170", VA = "0x187D1CF70")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D090", Offset = "0x7D1C290", VA = "0x187D1D090")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CC40", Offset = "0x7D1BE40", VA = "0x187D1CC40")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CCE0", Offset = "0x7D1BEE0", VA = "0x187D1CCE0")]
		public static void ENEDPBAOBKF([Out] float4 IGGKBIDIAJL, ushort DAOKDAMGDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void OBKKIKINBJE([NoAlias] float4* AKMEJGKBKEI, [NoAlias] byte* APHLMGCFLEO, [Out] int MHGJKFBEONL, [Out] int EPONFGEMOHK, [NoAlias] float4* DIPPFNLKAME, int ANNLKNMOFHP, int HGFLJHNNBAG);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class KIKKPFCPPDO
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7D2BD00", Offset = "0x7D2AF00", VA = "0x187D2BD00")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7D2BE20", Offset = "0x7D2B020", VA = "0x187D2BE20")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7D2BA30", Offset = "0x7D2AC30", VA = "0x187D2BA30")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2BAD0", Offset = "0x7D2ACD0", VA = "0x187D2BAD0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] float4* AKMEJGKBKEI, [NoAlias] byte* APHLMGCFLEO, [Out] int MHGJKFBEONL, [Out] int EPONFGEMOHK, [NoAlias] float4* DIPPFNLKAME, int ANNLKNMOFHP, int HGFLJHNNBAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void KHHBAGMEFOB([NoAlias] float4* BCMADAPEPAK, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class DBCNDAJKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D197C0", Offset = "0x7D189C0", VA = "0x187D197C0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7D198E0", Offset = "0x7D18AE0", VA = "0x187D198E0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7D19420", Offset = "0x7D18620", VA = "0x187D19420")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7D194C0", Offset = "0x7D186C0", VA = "0x187D194C0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] float4* BCMADAPEPAK, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void FPCPKIEKJGE([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class OOPPFGPKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7D30850", Offset = "0x7D2FA50", VA = "0x187D30850")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7D30970", Offset = "0x7D2FB70", VA = "0x187D30970")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7D30400", Offset = "0x7D2F600", VA = "0x187D30400")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7D304A0", Offset = "0x7D2F6A0", VA = "0x187D304A0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void NLMIAMOHHJO([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class HBJCIJFNPHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1EFC0", Offset = "0x7D1E1C0", VA = "0x187D1EFC0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F0E0", Offset = "0x7D1E2E0", VA = "0x187D1F0E0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7D1EB60", Offset = "0x7D1DD60", VA = "0x187D1EB60")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7D1EC00", Offset = "0x7D1DE00", VA = "0x187D1EC00")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void FNBJHOHLBIJ([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class GOPAECJGLOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E8F0", Offset = "0x7D1DAF0", VA = "0x187D1E8F0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7D1EA10", Offset = "0x7D1DC10", VA = "0x187D1EA10")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E4A0", Offset = "0x7D1D6A0", VA = "0x187D1E4A0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E540", Offset = "0x7D1D740", VA = "0x187D1E540")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void NHJOIIFPIMD([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class FJOBDABOIGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D4A0", Offset = "0x7D1C6A0", VA = "0x187D1D4A0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D5C0", Offset = "0x7D1C7C0", VA = "0x187D1D5C0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D1E0", Offset = "0x7D1C3E0", VA = "0x187D1D1E0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D280", Offset = "0x7D1C480", VA = "0x187D1D280")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void JIINFMGHOEO([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class FAKIKBEOGGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D1BF90", Offset = "0x7D1B190", VA = "0x187D1BF90")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C0B0", Offset = "0x7D1B2B0", VA = "0x187D1C0B0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1BCD0", Offset = "0x7D1AED0", VA = "0x187D1BCD0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D1BD70", Offset = "0x7D1AF70", VA = "0x187D1BD70")]
		public unsafe static void ENEDPBAOBKF([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int JFHHDDBFBDO([NoAlias] byte* JLCENHAJOHK, [In][NoAlias] int* HAGHMHCNPJN, int NPKCKFLGKPA);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class GJBOOAPNIHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E230", Offset = "0x7D1D430", VA = "0x187D1E230")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E350", Offset = "0x7D1D550", VA = "0x187D1E350")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DF00", Offset = "0x7D1D100", VA = "0x187D1DF00")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DFA0", Offset = "0x7D1D1A0", VA = "0x187D1DFA0")]
		public unsafe static int ENEDPBAOBKF([NoAlias] byte* JLCENHAJOHK, [In][NoAlias] int* HAGHMHCNPJN, int NPKCKFLGKPA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void CALFKONNPGE([NoAlias] int* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class EJDOFBFHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D1BA60", Offset = "0x7D1AC60", VA = "0x187D1BA60")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D1BB80", Offset = "0x7D1AD80", VA = "0x187D1BB80")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B760", Offset = "0x7D1A960", VA = "0x187D1B760")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B800", Offset = "0x7D1AA00", VA = "0x187D1B800")]
		public unsafe static void ENEDPBAOBKF([NoAlias] int* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void ILGOALCLEBO([NoAlias] ushort* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class CNFMEPPIPOL
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D191B0", Offset = "0x7D183B0", VA = "0x187D191B0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D192D0", Offset = "0x7D184D0", VA = "0x187D192D0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D18EB0", Offset = "0x7D180B0", VA = "0x187D18EB0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D18F50", Offset = "0x7D18150", VA = "0x187D18F50")]
		public unsafe static void ENEDPBAOBKF([NoAlias] ushort* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void BMEOOJMKKFN([Out] float3 IJFAELOGEEF, ushort DAOKDAMGDCJ);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class AHEGILGMADJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D17B70", Offset = "0x7D16D70", VA = "0x187D17B70")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D17C90", Offset = "0x7D16E90", VA = "0x187D17C90")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D178D0", Offset = "0x7D16AD0", VA = "0x187D178D0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D17970", Offset = "0x7D16B70", VA = "0x187D17970")]
		public static void ENEDPBAOBKF([Out] float3 IJFAELOGEEF, ushort DAOKDAMGDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort KINLOKOFHCE([In] float3 AJMIONOMGNA);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class HJLLPONDAPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D1FAB0", Offset = "0x7D1ECB0", VA = "0x187D1FAB0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D1FBD0", Offset = "0x7D1EDD0", VA = "0x187D1FBD0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F820", Offset = "0x7D1EA20", VA = "0x187D1F820")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F8C0", Offset = "0x7D1EAC0", VA = "0x187D1F8C0")]
		public static ushort ENEDPBAOBKF([In] float3 AJMIONOMGNA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker BMIALNNBAMG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker EAKNAOBOBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int KLACLIDIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int CPBAFNDHECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> FGCDPHHICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> MJGJOBDPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> LGKDIAIONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> MLHPJFPNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<FJFDCDPAJLM> DEANHPLFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> GHGIDPODJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> LHKGABDCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 AJJMKPIHGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 IIJLEOMGNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 HPLPBHKGFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 FFHLABDMDPM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long ACDKFENKGLF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long FMGDLEMLHMM;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float LFADOOBEFIA;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool MNKDFAAEAEC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D21BB0", Offset = "0x7D20DB0", VA = "0x187D21BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FMMPLPHJOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D27DF0", Offset = "0x7D26FF0", VA = "0x187D27DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D24460", Offset = "0x7D23660", VA = "0x187D24460")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D22C30", Offset = "0x7D21E30", VA = "0x187D22C30")]
	public static JFNLGADNLID EAIFKKLDBGP(Allocator FOPENOLHBOM, NativeArray<float3> JFCONLOMDBF, NativeArray<float3> DEDFHGIPCCG, NativeArray<float2> IELKJLAKEBH, NativeArray<float4> DIPPFNLKAME, bool PJGDBHIDJFJ, NativeArray<float4> NFEAFDKFIDG, NativeArray<int> HAGHMHCNPJN, int KLACLIDIDNP, int OPEJGDNHLGE, int CPBAFNDHECP, int ANNLKNMOFHP)
	{
		return default(JFNLGADNLID);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D250E0", Offset = "0x7D242E0", VA = "0x187D250E0")]
	public PBKMGPOLEJF HMBGFHEPBFK(Allocator FOPENOLHBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D25180", Offset = "0x7D24380", VA = "0x187D25180")]
	public void HMBGFHEPBFK(PBKMGPOLEJF IGGKBIDIAJL, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D221F0", Offset = "0x7D213F0", VA = "0x187D221F0")]
	public void DHCEIMKGIOC(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D28D70", Offset = "0x7D27F70", VA = "0x187D28D70")]
	private void NCCIADGBFJF(Mesh KHKMPBIDLPA, NativeArray<ushort> GMFBAEIKGLI, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D295F0", Offset = "0x7D287F0", VA = "0x187D295F0")]
	public void OFMEEHGNHND(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D25960", Offset = "0x7D24B60", VA = "0x187D25960")]
	public void IEIOPECODKH(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D28FA0", Offset = "0x7D281A0", VA = "0x187D28FA0")]
	public void OEHMFJJHHBO(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D20E90", Offset = "0x7D20090", VA = "0x187D20E90")]
	public void BJKCJDPFIMP(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D26510", Offset = "0x7D25710", VA = "0x187D26510")]
	public void JGGBPJMGMIM(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D22310", Offset = "0x7D21510", VA = "0x187D22310")]
	public void DIJNDKNIIBB(Mesh KHKMPBIDLPA, PBKMGPOLEJF.FPNIDPGNDKH HPCBECKKHGG, bool CJBJHFALDAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D287E0", Offset = "0x7D279E0", VA = "0x187D287E0")]
	public long MJHJDHCCDLB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D28C80", Offset = "0x7D27E80", VA = "0x187D28C80")]
	public long MMBJNEJKCHJ(PBKMGPOLEJF.FPNIDPGNDKH HPCBECKKHGG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D234D0", Offset = "0x7D226D0", VA = "0x187D234D0")]
	private void EPNMOGAJAEC(int MKEEMFLOFJJ, int HGFLJHNNBAG, Allocator FOPENOLHBOM, bool KPOALLNFGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D27FD0", Offset = "0x7D271D0", VA = "0x187D27FD0")]
	private void LJLAAGIHIPE(NativeArray<float3> HFBLFGBFMLB, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D27F50", Offset = "0x7D27150", VA = "0x187D27F50")]
	[BurstCompile]
	private unsafe static void LJLAAGIHIPE([NoAlias] float3* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D22B40", Offset = "0x7D21D40", VA = "0x187D22B40")]
	[BurstCompile]
	private unsafe static void DKCPILEEKFI([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A190", Offset = "0x7D29390", VA = "0x187D2A190")]
	[BurstCompile]
	private unsafe static void PLAHLADFHGL([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D23600", Offset = "0x7D22800", VA = "0x187D23600")]
	[BurstCompile]
	private unsafe static void FAFBNOFEKOP([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D22170", Offset = "0x7D21370", VA = "0x187D22170")]
	[BurstCompile]
	private unsafe static void DCBFFECPMJL([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D26B20", Offset = "0x7D25D20", VA = "0x187D26B20")]
	[BurstCompile]
	private unsafe static void JGICPCKDOOH([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D23FA0", Offset = "0x7D231A0", VA = "0x187D23FA0")]
	private void GCEGNAEAKPJ(NativeArray<float3> JFCONLOMDBF, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D23F10", Offset = "0x7D23110", VA = "0x187D23F10")]
	[BurstCompile]
	private unsafe static void GCEGNAEAKPJ([NoAlias] ushort* HFBLFGBFMLB, [Out] float3 OGCMGJCEIJK, [Out] float3 IIJLEOMGNOM, [In][NoAlias] float3* JFCONLOMDBF, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D24380", Offset = "0x7D23580", VA = "0x187D24380")]
	private void GMLPCMICJMF(NativeArray<float3> DEDFHGIPCCG, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D24140", Offset = "0x7D23340", VA = "0x187D24140")]
	[BurstCompile]
	private unsafe static void GMLPCMICJMF([NoAlias] ushort* IFJGGCFCMCO, [In][NoAlias] float3* DEDFHGIPCCG, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D284E0", Offset = "0x7D276E0", VA = "0x187D284E0")]
	private void MGJMPNIJFDG(NativeArray<float3> KMLMHEGGICE, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D285A0", Offset = "0x7D277A0", VA = "0x187D285A0")]
	[BurstCompile]
	private unsafe static void MGJMPNIJFDG([NoAlias] float3* KMLMHEGGICE, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D279D0", Offset = "0x7D26BD0", VA = "0x187D279D0")]
	[BurstCompile]
	private unsafe static void KJCPBKBFCLO([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D26250", Offset = "0x7D25450", VA = "0x187D26250")]
	[BurstCompile]
	private unsafe static void JCKDKLBDPDI([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D25FB0", Offset = "0x7D251B0", VA = "0x187D25FB0")]
	[BurstCompile]
	private unsafe static void IGCEFAHCMJB([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D24BF0", Offset = "0x7D23DF0", VA = "0x187D24BF0")]
	[BurstCompile]
	private unsafe static void HCOMKGINNFP([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D23C60", Offset = "0x7D22E60", VA = "0x187D23C60")]
	[BurstCompile]
	private unsafe static void FPPNOJCNIKD([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D245E0", Offset = "0x7D237E0", VA = "0x187D245E0")]
	private void GONHJALIFNM(NativeArray<float2> IELKJLAKEBH, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D24700", Offset = "0x7D23900", VA = "0x187D24700")]
	[BurstCompile]
	private unsafe static void GONHJALIFNM([NoAlias] uint* GJEMOMACNFA, [Out] float2 DGNLBDCPLHH, [Out] float2 FFHLABDMDPM, [In][NoAlias] float2* IELKJLAKEBH, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D29D30", Offset = "0x7D28F30", VA = "0x187D29D30")]
	[BurstCompile]
	private static void OJCGHLEBLON([Out] float2 IJFAELOGEEF, uint DAOKDAMGDCJ, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D20BE0", Offset = "0x7D1FDE0", VA = "0x187D20BE0")]
	private void BBMDOKHACDM(NativeArray<float2> GJEMOMACNFA, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D20D00", Offset = "0x7D1FF00", VA = "0x187D20D00")]
	[BurstCompile]
	private unsafe static void BBMDOKHACDM([NoAlias] float2* GJEMOMACNFA, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D20D80", Offset = "0x7D1FF80", VA = "0x187D20D80")]
	[BurstCompile]
	private unsafe static void BDHODHNBDAC([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D23450", Offset = "0x7D22650", VA = "0x187D23450")]
	[BurstCompile]
	private unsafe static void EIPKGLOPMCO([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D262C0", Offset = "0x7D254C0", VA = "0x187D262C0")]
	[BurstCompile]
	private unsafe static void JCNOCDKICFG([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D240C0", Offset = "0x7D232C0", VA = "0x187D240C0")]
	[BurstCompile]
	private unsafe static void GDCNBDDDHEO([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D28CF0", Offset = "0x7D27EF0", VA = "0x187D28CF0")]
	[BurstCompile]
	private unsafe static void NBHJJIDBIBK([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A000", Offset = "0x7D29200", VA = "0x187D2A000")]
	private void PJEGECMINJE(NativeArray<float4> NFEAFDKFIDG, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A110", Offset = "0x7D29310", VA = "0x187D2A110")]
	[BurstCompile]
	private unsafe static void PJEGECMINJE([NoAlias] ushort* NHNIKMFNMBE, [In][NoAlias] float4* MHMPOMOAAEL, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D20B90", Offset = "0x7D1FD90", VA = "0x187D20B90")]
	[BurstCompile]
	private static ushort ANPNFAMBOCN([In] float4 AJMIONOMGNA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D278E0", Offset = "0x7D26AE0", VA = "0x187D278E0")]
	private void KIEGFLNPAFF(NativeArray<float4> NHNIKMFNMBE, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D27870", Offset = "0x7D26A70", VA = "0x187D27870")]
	[BurstCompile]
	private unsafe static void KIEGFLNPAFF([NoAlias] float4* NHNIKMFNMBE, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D23CD0", Offset = "0x7D22ED0", VA = "0x187D23CD0")]
	[BurstCompile]
	private unsafe static void GCBNEPKPAHJ([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D209B0", Offset = "0x7D1FBB0", VA = "0x187D209B0")]
	[BurstCompile]
	private unsafe static void AMHFMFBOFDE([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D27790", Offset = "0x7D26990", VA = "0x187D27790")]
	[BurstCompile]
	private unsafe static void KFHJCMMKBOE([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D280F0", Offset = "0x7D272F0", VA = "0x187D280F0")]
	[BurstCompile]
	private unsafe static void MBPALCAOFPN([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D22BC0", Offset = "0x7D21DC0", VA = "0x187D22BC0")]
	[BurstCompile]
	private unsafe static void EADOCAJKJKI([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D24580", Offset = "0x7D23780", VA = "0x187D24580")]
	[BurstCompile]
	private static void GOGPGINIDPG([Out] float4 IGGKBIDIAJL, ushort DAOKDAMGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D21770", Offset = "0x7D20970", VA = "0x187D21770")]
	private void BPJFLMGKBIB(Allocator FOPENOLHBOM, NativeArray<float4> DIPPFNLKAME, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D216E0", Offset = "0x7D208E0", VA = "0x187D216E0")]
	[BurstCompile]
	private unsafe static void BPJFLMGKBIB([NoAlias] float4* AKMEJGKBKEI, [NoAlias] byte* APHLMGCFLEO, [Out] int MHGJKFBEONL, [Out] int EPONFGEMOHK, [NoAlias] float4* DIPPFNLKAME, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D20880", Offset = "0x7D1FA80", VA = "0x187D20880")]
	private static void ALBBMBDJAPD(NativeArray<float4> BCMADAPEPAK, NativeArray<FJFDCDPAJLM> HEDDMJOGMMB, NativeArray<byte> DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D20800", Offset = "0x7D1FA00", VA = "0x187D20800")]
	[BurstCompile]
	private unsafe static void ALBBMBDJAPD([NoAlias] float4* BCMADAPEPAK, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D21EF0", Offset = "0x7D210F0", VA = "0x187D21EF0")]
	[BurstCompile]
	private unsafe static void CFHBMEPCMME([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D27E30", Offset = "0x7D27030", VA = "0x187D27E30")]
	[BurstCompile]
	private unsafe static void LGKJHLAELLE([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D20610", Offset = "0x7D1F810", VA = "0x187D20610")]
	[BurstCompile]
	private unsafe static void ABGBOMOEGGJ([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D22800", Offset = "0x7D21A00", VA = "0x187D22800")]
	[BurstCompile]
	private unsafe static void DILBGKIKBPF([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D26EF0", Offset = "0x7D260F0", VA = "0x187D26EF0")]
	[BurstCompile]
	private unsafe static void JNMLHJMKIAI([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D25540", Offset = "0x7D24740", VA = "0x187D25540")]
	private void HMMKFFGKIJH(Allocator FOPENOLHBOM, NativeArray<int> HAGHMHCNPJN, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D236F0", Offset = "0x7D228F0", VA = "0x187D236F0")]
	private static NativeArray<byte> FBELEEPJOLN(Allocator FOPENOLHBOM, NativeArray<int> HAGHMHCNPJN, int NPKCKFLGKPA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D23680", Offset = "0x7D22880", VA = "0x187D23680")]
	[BurstCompile]
	private unsafe static int FBELEEPJOLN([NoAlias] byte* JLCENHAJOHK, [In][NoAlias] int* HAGHMHCNPJN, int NPKCKFLGKPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D24B00", Offset = "0x7D23D00", VA = "0x187D24B00")]
	private static void HCKOOKEGLEM(NativeArray<int> FFNDEAEEKGF, NativeArray<byte> IPFAHDBCBAL, int CPBAFNDHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D24A90", Offset = "0x7D23C90", VA = "0x187D24A90")]
	[BurstCompile]
	private unsafe static void HCKOOKEGLEM([NoAlias] int* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D27800", Offset = "0x7D26A00", VA = "0x187D27800")]
	[BurstCompile]
	private unsafe static void KICIFLFFIFM([NoAlias] ushort* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D23220", Offset = "0x7D22420", VA = "0x187D23220")]
	[BurstCompile]
	private static void EHINGPPBEGL([Out] float3 IJFAELOGEEF, ushort DAOKDAMGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D24EC0", Offset = "0x7D240C0", VA = "0x187D24EC0")]
	[BurstCompile]
	private static ushort HLJLGDHCPBD([In] float3 AJMIONOMGNA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D16070", Offset = "0x7D15270", VA = "0x187D16070")]
	[BurstCompile]
	public unsafe static void LHGLOHEEEBF([NoAlias] float3* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D23A60", Offset = "0x7D22C60", VA = "0x187D23A60")]
	[BurstCompile]
	public unsafe static void FLGIKOMAKII([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D26020", Offset = "0x7D25220", VA = "0x187D26020")]
	[BurstCompile]
	public unsafe static void IOJHEPIOMDM([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D220B0", Offset = "0x7D212B0", VA = "0x187D220B0")]
	[BurstCompile]
	public unsafe static void CMHPNHJOLAO([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D220B0", Offset = "0x7D212B0", VA = "0x187D220B0")]
	[BurstCompile]
	public unsafe static void CPOPJNPKMND([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D29BD0", Offset = "0x7D28DD0", VA = "0x187D29BD0")]
	[BurstCompile]
	public unsafe static void OIJPLAPPNNE([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* JFCONLOMDBF, int KLACLIDIDNP, [In] float3 AJJMKPIHGMC, [In] float3 IIJLEOMGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D15C90", Offset = "0x7D14E90", VA = "0x187D15C90")]
	[BurstCompile]
	public unsafe static void KOLLKPHGJEM([NoAlias] ushort* HFBLFGBFMLB, [Out] float3 OGCMGJCEIJK, [Out] float3 IIJLEOMGNOM, [In][NoAlias] float3* JFCONLOMDBF, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D28240", Offset = "0x7D27440", VA = "0x187D28240")]
	[BurstCompile]
	public unsafe static void MGFDLOLILFO([NoAlias] ushort* IFJGGCFCMCO, [In][NoAlias] float3* DEDFHGIPCCG, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D289E0", Offset = "0x7D27BE0", VA = "0x187D289E0")]
	[BurstCompile]
	public unsafe static void MJLFCIMNOCD([NoAlias] float3* KMLMHEGGICE, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D26BA0", Offset = "0x7D25DA0", VA = "0x187D26BA0")]
	[BurstCompile]
	public unsafe static void JKCIIMNPNNG([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D23B20", Offset = "0x7D22D20", VA = "0x187D23B20")]
	[BurstCompile]
	public unsafe static void FPFAPEDDHDG([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D21F70", Offset = "0x7D21170", VA = "0x187D21F70")]
	[BurstCompile]
	public unsafe static void CKEICEBBLOC([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D260E0", Offset = "0x7D252E0", VA = "0x187D260E0")]
	[BurstCompile]
	public unsafe static void IPKFBIBNPPK([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D20690", Offset = "0x7D1F890", VA = "0x187D20690")]
	[BurstCompile]
	public unsafe static void AKIHLJOMDHN([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* DEDFHGIPCCG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D16810", Offset = "0x7D15A10", VA = "0x187D16810")]
	[BurstCompile]
	public unsafe static void NMBGHBPHLLA([NoAlias] uint* GJEMOMACNFA, [Out] float2 DGNLBDCPLHH, [Out] float2 FFHLABDMDPM, [In][NoAlias] float2* IELKJLAKEBH, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D24C60", Offset = "0x7D23E60", VA = "0x187D24C60")]
	[BurstCompile]
	public static void HDFHHLMENAE([Out] float2 IJFAELOGEEF, uint DAOKDAMGDCJ, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D29EF0", Offset = "0x7D290F0", VA = "0x187D29EF0")]
	[BurstCompile]
	public unsafe static void PEEGHPDPKJL([NoAlias] float2* GJEMOMACNFA, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D288A0", Offset = "0x7D27AA0", VA = "0x187D288A0")]
	[BurstCompile]
	public unsafe static void MJKKNGJLFME([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D25640", Offset = "0x7D24840", VA = "0x187D25640")]
	[BurstCompile]
	public unsafe static void HONAOHDNPJO([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D24CA0", Offset = "0x7D23EA0", VA = "0x187D24CA0")]
	[BurstCompile]
	public unsafe static void HKPEOLDKLLE([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D21BF0", Offset = "0x7D20DF0", VA = "0x187D21BF0")]
	[BurstCompile]
	public unsafe static void CBJALKDMECC([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D230F0", Offset = "0x7D222F0", VA = "0x187D230F0")]
	[BurstCompile]
	public unsafe static void EFIFJEJGIHA([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [NoAlias] uint* IELKJLAKEBH, int KLACLIDIDNP, [In] float2 HPLPBHKGFBF, [In] float2 FFHLABDMDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D28160", Offset = "0x7D27360", VA = "0x187D28160")]
	[BurstCompile]
	public unsafe static void MEAODOKHHEN([NoAlias] ushort* NHNIKMFNMBE, [In][NoAlias] float4* MHMPOMOAAEL, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D20E00", Offset = "0x7D20000", VA = "0x187D20E00")]
	[BurstCompile]
	public static ushort BFOBGPHOPCP([In] float4 AJMIONOMGNA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D22A60", Offset = "0x7D21C60", VA = "0x187D22A60")]
	[BurstCompile]
	public unsafe static void DJPEJDACBPH([NoAlias] float4* NHNIKMFNMBE, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D274A0", Offset = "0x7D266A0", VA = "0x187D274A0")]
	[BurstCompile]
	public unsafe static void KBIJNEEOJPF([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D20A20", Offset = "0x7D1FC20", VA = "0x187D20A20")]
	[BurstCompile]
	public unsafe static void AMPGEJJEAHO([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D27150", Offset = "0x7D26350", VA = "0x187D27150")]
	[BurstCompile]
	public unsafe static void JOFGLDINEFD([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7D21D20", Offset = "0x7D20F20", VA = "0x187D21D20")]
	[BurstCompile]
	public unsafe static void CENGGEOKDDB([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D26340", Offset = "0x7D25540", VA = "0x187D26340")]
	[BurstCompile]
	public unsafe static void JFPMEMBFOPG([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] ushort* NFEAFDKFIDG, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D24790", Offset = "0x7D23990", VA = "0x187D24790")]
	[BurstCompile]
	public static void GPMELAKBFML([Out] float4 IGGKBIDIAJL, ushort DAOKDAMGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D15590", Offset = "0x7D14790", VA = "0x187D15590")]
	[BurstCompile]
	public unsafe static void JIJABNHFNFI([NoAlias] float4* AKMEJGKBKEI, [NoAlias] byte* APHLMGCFLEO, [Out] int MHGJKFBEONL, [Out] int EPONFGEMOHK, [NoAlias] float4* DIPPFNLKAME, int ANNLKNMOFHP, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D29DB0", Offset = "0x7D28FB0", VA = "0x187D29DB0")]
	[BurstCompile]
	public unsafe static void OLCJPGFOJHC([NoAlias] float4* BCMADAPEPAK, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D27C10", Offset = "0x7D26E10", VA = "0x187D27C10")]
	[BurstCompile]
	public unsafe static void LEKDHGKMMML([NoAlias] PBKMGPOLEJF.PJMACFLMFHC* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D272C0", Offset = "0x7D264C0", VA = "0x187D272C0")]
	[BurstCompile]
	public unsafe static void KAKOKPJAKDM([NoAlias] PBKMGPOLEJF.GIIMPKGKDJE* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D25780", Offset = "0x7D24980", VA = "0x187D25780")]
	[BurstCompile]
	public unsafe static void HPDCHPBOPFA([NoAlias] PBKMGPOLEJF.NJBCADNBKGI* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D24850", Offset = "0x7D23A50", VA = "0x187D24850")]
	[BurstCompile]
	public unsafe static void HBGEMDEPFPP([NoAlias] PBKMGPOLEJF.OIHBPPIMBHM* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D214A0", Offset = "0x7D206A0", VA = "0x187D214A0")]
	[BurstCompile]
	public unsafe static void BKNHADBMFGJ([NoAlias] PBKMGPOLEJF.CMDIDNBCKFB* HFBLFGBFMLB, [In][NoAlias] FJFDCDPAJLM* HEDDMJOGMMB, [In][NoAlias] byte* DBIIMODHOFI, int KLACLIDIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D26DF0", Offset = "0x7D25FF0", VA = "0x187D26DF0")]
	[BurstCompile]
	public unsafe static int JMJLCFHLDBA([NoAlias] byte* JLCENHAJOHK, [In][NoAlias] int* HAGHMHCNPJN, int NPKCKFLGKPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D27EB0", Offset = "0x7D270B0", VA = "0x187D27EB0")]
	[BurstCompile]
	public unsafe static void LGLHCIIBFML([NoAlias] int* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D239C0", Offset = "0x7D22BC0", VA = "0x187D239C0")]
	[BurstCompile]
	public unsafe static void FHMCGCJKKNP([NoAlias] ushort* FFNDEAEEKGF, [In][NoAlias] byte* IPFAHDBCBAL, int CPBAFNDHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D14D50", Offset = "0x7D13F50", VA = "0x187D14D50")]
	[BurstCompile]
	public static void AAPCFMMMDEE([Out] float3 IJFAELOGEEF, ushort DAOKDAMGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D16AD0", Offset = "0x7D15CD0", VA = "0x187D16AD0")]
	[BurstCompile]
	public static ushort PKBIKDFAHGM([In] float3 AJMIONOMGNA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class PBKMGPOLEJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum FPNIDPGNDKH
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum ELJNAAKPAEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		_,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct NGHHLLHJMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FPNIDPGNDKH HPCBECKKHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool KCIIIFJPOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int FDHPECNGLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct OLNHEPLKKEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 BJHAAAPCKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 PLEIILPBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 AHKONODNLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 BIIKGDFKBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 DEANHPLFMOD;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct PJMACFLMFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 BJHAAAPCKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 PLEIILPBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 AHKONODNLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 BIIKGDFKBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 DEANHPLFMOD;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct GIIMPKGKDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 BJHAAAPCKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint PLEIILPBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint AHKONODNLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 BIIKGDFKBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 DEANHPLFMOD;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct NJBCADNBKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 BJHAAAPCKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint PLEIILPBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint AHKONODNLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 BIIKGDFKBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 DEANHPLFMOD;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct OIHBPPIMBHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 BJHAAAPCKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint HNKJCFDFOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 BIIKGDFKBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint GEDNDBCFLAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint DLAHHMHPADL;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct CMDIDNBCKFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public OEMAGCMFODM.EMCMICFHGLM OEOCKDKJEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint HNKJCFDFOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 BIIKGDFKBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint GEDNDBCFLAB;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] MJIMDPADJCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int APCEKPMEFEN(float CCOLDGJALNH);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class EJCPLMDDPIC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B4F0", Offset = "0x7D1A6F0", VA = "0x187D1B4F0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B610", Offset = "0x7D1A810", VA = "0x187D1B610")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B1F0", Offset = "0x7D1A3F0", VA = "0x187D1B1F0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B290", Offset = "0x7D1A490", VA = "0x187D1B290")]
		public static int ENEDPBAOBKF(float CCOLDGJALNH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint PKCPMJDJPKN([In] float4 KOBHBJCHIOC);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class KHKNMINFDLA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E480", Offset = "0x7D4D680", VA = "0x187D4E480")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E5A0", Offset = "0x7D4D7A0", VA = "0x187D4E5A0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E170", Offset = "0x7D4D370", VA = "0x187D4E170")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E210", Offset = "0x7D4D410", VA = "0x187D4E210")]
		public static uint ENEDPBAOBKF([In] float4 KOBHBJCHIOC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint OIKJJOHJBOC([In] float3 KOBHBJCHIOC);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class DNDLFGOEJFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7D44870", Offset = "0x7D43A70", VA = "0x187D44870")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7D44990", Offset = "0x7D43B90", VA = "0x187D44990")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7D44590", Offset = "0x7D43790", VA = "0x187D44590")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7D44630", Offset = "0x7D43830", VA = "0x187D44630")]
		public static uint ENEDPBAOBKF([In] float3 KOBHBJCHIOC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void ANOPOJOPKDO([NoAlias] GIIMPKGKDJE* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class PEFENONNDHO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7D523E0", Offset = "0x7D515E0", VA = "0x187D523E0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7D52500", Offset = "0x7D51700", VA = "0x187D52500")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7D52110", Offset = "0x7D51310", VA = "0x187D52110")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7D521B0", Offset = "0x7D513B0", VA = "0x187D521B0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] GIIMPKGKDJE* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void INCAKCAPINO([NoAlias] NJBCADNBKGI* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class HHJCAKFIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B820", Offset = "0x7D4AA20", VA = "0x187D4B820")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B940", Offset = "0x7D4AB40", VA = "0x187D4B940")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B550", Offset = "0x7D4A750", VA = "0x187D4B550")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B5F0", Offset = "0x7D4A7F0", VA = "0x187D4B5F0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] NJBCADNBKGI* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void MANECGNBMCO([NoAlias] OIHBPPIMBHM* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class DHNODKDOLFN
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7D44320", Offset = "0x7D43520", VA = "0x187D44320")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D44440", Offset = "0x7D43640", VA = "0x187D44440")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D43EA0", Offset = "0x7D430A0", VA = "0x187D43EA0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7D43F40", Offset = "0x7D43140", VA = "0x187D43F40")]
		public unsafe static void ENEDPBAOBKF([NoAlias] OIHBPPIMBHM* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void GJNGJHOAHLM([NoAlias] CMDIDNBCKFB* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD, [Out] float3 IKJLDNGEFOJ, [Out] float3 EOHHKDFIGEP);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class DHKPHJEAPGH
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D43C30", Offset = "0x7D42E30", VA = "0x187D43C30")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D43D50", Offset = "0x7D42F50", VA = "0x187D43D50")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7D43640", Offset = "0x7D42840", VA = "0x187D43640")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7D436E0", Offset = "0x7D428E0", VA = "0x187D436E0")]
		public unsafe static void ENEDPBAOBKF([NoAlias] CMDIDNBCKFB* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD, [Out] float3 IKJLDNGEFOJ, [Out] float3 EOHHKDFIGEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int GBGBABAJBJM = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> BOCCADBEGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> FNEKBNJAKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> DDDDJPKFPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> HIJKLJKBGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> BOPICDKMMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> KDNNGOEBDMN;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] MIPPIEDKILN;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool OLNKMEPBHPC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static NGHHLLHJMIE[] LCFCDJOIOIJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D31940", Offset = "0x7D30B40", VA = "0x187D31940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D34EF0", Offset = "0x7D340F0", VA = "0x187D34EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DKMEIHDNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D34A30", Offset = "0x7D33C30", VA = "0x187D34A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FMMPLPHJOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D34EB0", Offset = "0x7D340B0", VA = "0x187D34EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D35060", Offset = "0x7D34260", VA = "0x187D35060")]
	public static ELJNAAKPAEB MFKPPHDNOAN(FPNIDPGNDKH HPCBECKKHGG)
	{
		return default(ELJNAAKPAEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D31100", Offset = "0x7D30300", VA = "0x187D31100")]
	public static void BCCJGKAILJB(ELJNAAKPAEB BBLKGCDAEAI, Material OHHEKLKCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D323C0", Offset = "0x7D315C0", VA = "0x187D323C0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7D324D0", Offset = "0x7D316D0", VA = "0x187D324D0")]
	public void EPNMOGAJAEC(int MKEEMFLOFJJ, int HGFLJHNNBAG, Allocator FOPENOLHBOM, bool GPIIBOEPBEG, bool KPOALLNFGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D332A0", Offset = "0x7D324A0", VA = "0x187D332A0")]
	public void HELIJALDGNG(int MKEEMFLOFJJ, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D353C0", Offset = "0x7D345C0", VA = "0x187D353C0", Slot = "6")]
	public bool NCCKEMCLPBB(Mesh KHKMPBIDLPA, bool NAGPDMKPOPK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D31980", Offset = "0x7D30B80", VA = "0x187D31980")]
	public bool DHCEIMKGIOC(Mesh KHKMPBIDLPA, bool NAGPDMKPOPK, bool CJBJHFALDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D32830", Offset = "0x7D31A30", VA = "0x187D32830")]
	public bool FJCPGIAIAKG(Mesh KHKMPBIDLPA, PBKMGPOLEJF KBMMIHLGLBJ, bool NAGPDMKPOPK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D34F30", Offset = "0x7D34130", VA = "0x187D34F30")]
	public bool MALOLDGLPNB(Mesh KHKMPBIDLPA, PBKMGPOLEJF KBMMIHLGLBJ, FPNIDPGNDKH HPCBECKKHGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D370A0", Offset = "0x7D362A0", VA = "0x187D370A0")]
	private void ONCDAKJLFKA(Mesh KHKMPBIDLPA, PBKMGPOLEJF KBMMIHLGLBJ, bool CJBJHFALDAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D36D90", Offset = "0x7D35F90", VA = "0x187D36D90")]
	public void ONCDAKJLFKA(NativeArray<ushort> ALLHFLOIFMP, NativeArray<OIHBPPIMBHM> AMOIJNCDGED, Mesh KHKMPBIDLPA, PBKMGPOLEJF KBMMIHLGLBJ, bool CJBJHFALDAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D36350", Offset = "0x7D35550", VA = "0x187D36350")]
	public void OFMEEHGNHND(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D32740", Offset = "0x7D31940", VA = "0x187D32740")]
	[BurstCompile]
	public static int FHEKIEMPKIF(float CCOLDGJALNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D327E0", Offset = "0x7D319E0", VA = "0x187D327E0")]
	[BurstCompile]
	public static uint FHEKIEMPKIF([In] float4 KOBHBJCHIOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D32790", Offset = "0x7D31990", VA = "0x187D32790")]
	[BurstCompile]
	public static uint FHEKIEMPKIF([In] float3 KOBHBJCHIOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D33520", Offset = "0x7D32720", VA = "0x187D33520")]
	public void IEIOPECODKH(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D31080", Offset = "0x7D30280", VA = "0x187D31080")]
	[BurstCompile]
	private unsafe static void AJHGLBCJAFN([NoAlias] GIIMPKGKDJE* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D35CC0", Offset = "0x7D34EC0", VA = "0x187D35CC0")]
	public void OEHMFJJHHBO(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D33BB0", Offset = "0x7D32DB0", VA = "0x187D33BB0")]
	[BurstCompile]
	private unsafe static void IFKADGJGJOB([NoAlias] NJBCADNBKGI* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D311C0", Offset = "0x7D303C0", VA = "0x187D311C0")]
	public void BJKCJDPFIMP(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D31590", Offset = "0x7D30790", VA = "0x187D31590")]
	public void BJKCJDPFIMP(NativeArray<ushort> GMFBAEIKGLI, NativeArray<OIHBPPIMBHM> JKCDEODAKEN, Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D31000", Offset = "0x7D30200", VA = "0x187D31000")]
	[BurstCompile]
	public unsafe static void AGNNBNMLDDE([NoAlias] OIHBPPIMBHM* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D342F0", Offset = "0x7D334F0", VA = "0x187D342F0")]
	public void JGGBPJMGMIM(Mesh KHKMPBIDLPA, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D326C0", Offset = "0x7D318C0", VA = "0x187D326C0")]
	[BurstCompile]
	private unsafe static void FEOENACIHNM([NoAlias] CMDIDNBCKFB* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD, [Out] float3 IKJLDNGEFOJ, [Out] float3 EOHHKDFIGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D31D80", Offset = "0x7D30F80", VA = "0x187D31D80")]
	public void DIJNDKNIIBB(Mesh KHKMPBIDLPA, FPNIDPGNDKH HPCBECKKHGG, bool CJBJHFALDAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D34080", Offset = "0x7D33280", VA = "0x187D34080")]
	public void JBHHHNKAKMJ(PBKMGPOLEJF KHKMPBIDLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D34DB0", Offset = "0x7D33FB0", VA = "0x187D34DB0")]
	public void KPCMHKKPMHH(PBKMGPOLEJF LJMBANNFBIJ, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D350B0", Offset = "0x7D342B0", VA = "0x187D350B0")]
	public long MJHJDHCCDLB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D35200", Offset = "0x7D34400", VA = "0x187D35200")]
	public static long MJHJDHCCDLB(int LKNCPECMDDC, int FBPIFIDAOCE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D35260", Offset = "0x7D34460", VA = "0x187D35260")]
	public static long MMBJNEJKCHJ(int LKNCPECMDDC, int FBPIFIDAOCE, FPNIDPGNDKH HPCBECKKHGG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D35300", Offset = "0x7D34500", VA = "0x187D35300")]
	public long MMBJNEJKCHJ(FPNIDPGNDKH HPCBECKKHGG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D35000", Offset = "0x7D34200", VA = "0x187D35000")]
	public void MFDJCBLOKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D31E10", Offset = "0x7D31010", VA = "0x187D31E10")]
	public static void DIPCNGHFNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D35580", Offset = "0x7D34780", VA = "0x187D35580")]
	public FPNIDPGNDKH OBLHBMFJLNN()
	{
		return default(FPNIDPGNDKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D330F0", Offset = "0x7D322F0", VA = "0x187D330F0")]
	public static (int, int) GAIEHPPLOLG(Mesh KHKMPBIDLPA)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D331C0", Offset = "0x7D323C0", VA = "0x187D331C0")]
	public static int GJNHLAHLBMM(VertexAttributeDescriptor[] MHGLHMFIBGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D35510", Offset = "0x7D34710", VA = "0x187D35510")]
	public static long NLILBBDLFEO(Mesh KHKMPBIDLPA, int NHCLIIACBKM, int GPMBJDMAEMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D353E0", Offset = "0x7D345E0", VA = "0x187D353E0")]
	public static long NLILBBDLFEO(Mesh KHKMPBIDLPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PBKMGPOLEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7D37830", Offset = "0x7D36A30", VA = "0x187D37830")]
	[BurstCompile]
	public static int OOBEPIKEDHF(float CCOLDGJALNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7D37980", Offset = "0x7D36B80", VA = "0x187D37980")]
	[BurstCompile]
	public static uint OOBEPIKEDHF([In] float4 KOBHBJCHIOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7D378D0", Offset = "0x7D36AD0", VA = "0x187D378D0")]
	[BurstCompile]
	public static uint OOBEPIKEDHF([In] float3 KOBHBJCHIOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7D32D30", Offset = "0x7D31F30", VA = "0x187D32D30")]
	[BurstCompile]
	public unsafe static void FLLEIBBBFFL([NoAlias] GIIMPKGKDJE* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7D33C30", Offset = "0x7D32E30", VA = "0x187D33C30")]
	[BurstCompile]
	public unsafe static void IIHIPIMGGPC([NoAlias] NJBCADNBKGI* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7D33320", Offset = "0x7D32520", VA = "0x187D33320")]
	[BurstCompile]
	public unsafe static void HMGFBMLHLEH([NoAlias] OIHBPPIMBHM* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7D34A70", Offset = "0x7D33C70", VA = "0x187D34A70")]
	[BurstCompile]
	public unsafe static void KIMKFKDHLND([NoAlias] CMDIDNBCKFB* HFBLFGBFMLB, int KLACLIDIDNP, [In][NoAlias] float3* BFDJINHBJLF, [In][NoAlias] float3* MJGJOBDPGLJ, [In][NoAlias] float4* LGKDIAIONON, [In][NoAlias] float2* MLHPJFPNION, [In][NoAlias] float4* DEANHPLFMOD, [Out] float3 IKJLDNGEFOJ, [Out] float3 EOHHKDFIGEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HFHNHFNBKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int FHGGHEBHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 HMGHBHLMNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion JLGGNNKNBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 JMGEGNHOOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int HKJLLEFIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int NLNHPPFMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int JNFNGBEKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float BFACDLAHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 DEJMIACCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool ALJNAFNAPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NHICBHPHDJP BJCBKKJIMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 LNLMGFICDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float MKBEEJJCDPD;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class CCILIPHKBOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static MNAGEFHMLHN LFAPFKKJDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<HFHNHFNBKLD> PPMKGFKHENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<KKJHPMNMBNE> NLEAIMPFOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<PJJEIGHNFBC> AOPAHPCKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<NOFEPGIGNGP> CHEDOHCNBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<KKJHPMNMBNE> PEHBLEEAKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<BDBFFOKPCDC> CFMOHPGKDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<NOFEPGIGNGP>> KADNPKNPPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<ABCEPEAAFGE> HMOAHFBIPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> CLGFCECNLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> OEHDBDLGMBI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<PONELLKLIKB.LEHJOAIBJFO> IDCOEOJMNEH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1B0", Offset = "0x9EE3B0", VA = "0x1809EF1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1C0", Offset = "0x9EE3C0", VA = "0x1809EF1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DKMEIHDNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC1ED30", Offset = "0xC1DF30", VA = "0x180C1ED30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC1ED40", Offset = "0xC1DF40", VA = "0x180C1ED40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7D43420", Offset = "0x7D42620", VA = "0x187D43420")]
	public CCILIPHKBOG(int PAFHOOEMKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7D41690", Offset = "0x7D40890", VA = "0x187D41690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7D41BE0", Offset = "0x7D40DE0", VA = "0x187D41BE0")]
	public void GNJBDGKPLLM(JobHandle EOJDBKLNAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7D41DD0", Offset = "0x7D40FD0", VA = "0x187D41DD0")]
	public void JKNBBMHJGMB(HFHNHFNBKLD DHAOEHNLNON, ABCEPEAAFGE IJHDKFDBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7D432C0", Offset = "0x7D424C0", VA = "0x187D432C0")]
	public void NGKNGGAIEJO(PJJEIGHNFBC DHAOEHNLNON, NativeArray<NOFEPGIGNGP> PGIAAHLGPEA, int KLACLIDIDNP, int CPBAFNDHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7D41FF0", Offset = "0x7D411F0", VA = "0x187D41FF0")]
	public JobHandle MEFDECANJLP(PBKMGPOLEJF AODJMLKEPHF, OIMMFGPJGMB BKEAAGHBHNH, float3 JGBLHIJNABB, quaternion PJNGCMNLENE, float DKFEFBHGKOI, bool MAKFCLLKFFC, int BFALJDKHBOC = 0, int GCGGBEDBKMH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7D42110", Offset = "0x7D41310", VA = "0x187D42110")]
	public JobHandle MEFDECANJLP(PBKMGPOLEJF AODJMLKEPHF, OIMMFGPJGMB BKEAAGHBHNH, NativeList<PONELLKLIKB.LEHJOAIBJFO> FBNNFDBNMBL, float3 JGBLHIJNABB, quaternion PJNGCMNLENE, float DKFEFBHGKOI, bool MAKFCLLKFFC, bool IKMKOBIBJBL, int BFALJDKHBOC = 0, int GCGGBEDBKMH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7D41870", Offset = "0x7D40A70", VA = "0x187D41870")]
	public static JobHandle ELCFONOHDPO(JMNMBHKOODC ANCNJNFACCI, PBKMGPOLEJF AODJMLKEPHF, NativeArray<int> OEHDBDLGMBI, HFHNHFNBKLD DHAOEHNLNON, JobHandle EOJDBKLNAOP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7D413E0", Offset = "0x7D405E0", VA = "0x187D413E0")]
	public static JobHandle AOKCPGFEKFP(FKILFOPFDCP ANCNJNFACCI, PBKMGPOLEJF AODJMLKEPHF, PJJEIGHNFBC DHAOEHNLNON, NativeArray<NOFEPGIGNGP> PGIAAHLGPEA, int KLACLIDIDNP, int CPBAFNDHECP, JobHandle EOJDBKLNAOP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class AEKEDALAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct NFBIIGFCBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer JFBIEOOKIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HDCMLBCHNIK.EIBIAALHFJP DIFNLDIDLDL;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8410", Offset = "0x5BF7610", VA = "0x185BF8410")]
		public NFBIIGFCBCM(MeshRenderer JFBIEOOKIGH, HDCMLBCHNIK.EIBIAALHFJP DIFNLDIDLDL)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7D51D70", Offset = "0x7D50F70", VA = "0x187D51D70")]
		public static NFBIIGFCBCM NEKLFDMHCNA((MeshRenderer, HDCMLBCHNIK.EIBIAALHFJP) KPDPCCJMJOH)
		{
			return default(NFBIIGFCBCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker IOLFNLCNMIF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker LGBFAHDFCCB;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker HBOHAOBCEJD;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker KFDHAJINPMG;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E040", Offset = "0x7D3D240", VA = "0x187D3E040")]
	internal void KJLBHAPHBLA(GameObject IOKCOGIDKOJ, HDCMLBCHNIK.AEPEOLJDADJ MLNIMJBFEGK, List<NFBIIGFCBCM> NBJCMBDDGEE, Material OHHEKLKCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CD10", Offset = "0x7D3BF10", VA = "0x187D3CD10")]
	internal void IAGICFJKCPO(GameObject IOKCOGIDKOJ, HDCMLBCHNIK.AEPEOLJDADJ MLNIMJBFEGK, List<NFBIIGFCBCM> NBJCMBDDGEE, List<LODGroup> JKGHHNEFDHD, Material OHHEKLKCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D590", Offset = "0x7D3C790", VA = "0x187D3D590")]
	private MeshRenderer KIPMOIGACBE(HDCMLBCHNIK.AEPEOLJDADJ MLNIMJBFEGK, Material OHHEKLKCMJA, List<NFBIIGFCBCM> NBJCMBDDGEE, bool CPGNAHHOHCB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BDD0", Offset = "0x7D3AFD0", VA = "0x187D3BDD0")]
	private List<(List<NFBIIGFCBCM>, float)> GGNBDIBHCAH(HDCMLBCHNIK.AEPEOLJDADJ MLNIMJBFEGK, List<LODGroup> JKGHHNEFDHD, Material OHHEKLKCMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E930", Offset = "0x7D3DB30", VA = "0x187D3E930")]
	private List<List<(List<NFBIIGFCBCM>, float)>> OJLGBFKDHLC(HDCMLBCHNIK.AEPEOLJDADJ MLNIMJBFEGK, List<LODGroup> JKGHHNEFDHD, Material OHHEKLKCMJA, [Out] int KNMDAHPFMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AEKEDALAFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BC60", Offset = "0x7D3AE60", VA = "0x187D3BC60")]
	[CompilerGenerated]
	internal static (float, int) BMJNFJCDIMI(List<List<(List<NFBIIGFCBCM> meshList, float lodTransition)>> EGPOCGLIDJO, int[] IJJDEDHLCOA)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LICIAELFPHB
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker JFJNPFBBLFB;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker PEGFEHLAFOK;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker PJEGKHMNFDN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker DDOIHCMOINK;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker KKENJFNJNDC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker KFPEJGGDKPL;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker GOIDCEMMDCH;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly FODGIOKBGBI JNAFDCNKGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private HDCMLBCHNIK JFCILAMNCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private AEKEDALAFGJ HAMKJLAGLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader LFJDHDMKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock OMKCCACPDBL;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E950", Offset = "0x7D4DB50", VA = "0x187D4E950")]
	public static void ECHNJEBNHKO(GameObject IOKCOGIDKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F660", Offset = "0x7D4E860", VA = "0x187D4F660")]
	public void ILLMBOBOELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4ECB0", Offset = "0x7D4DEB0", VA = "0x187D4ECB0")]
	public void EEPCMPMLMLP(GameObject IOKCOGIDKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FE40", Offset = "0x7D4F040", VA = "0x187D4FE40")]
	private bool LAKGCAOPJDL(MeshRenderer JFBIEOOKIGH, [Out] MeshFilter NBMEGGDHHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E6F0", Offset = "0x7D4D8F0", VA = "0x187D4E6F0")]
	private bool ANFMEEDFNPL(int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7D50D60", Offset = "0x7D4FF60", VA = "0x187D50D60")]
	private void PJKAGAHJOGO(GameObject IOKCOGIDKOJ, int NIBICIJAIGM, Material OHHEKLKCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FFC0", Offset = "0x7D4F1C0", VA = "0x187D4FFC0")]
	private List<AEKEDALAFGJ.NFBIIGFCBCM> LKMEMDFHPHC(int NIBICIJAIGM, [Out] List<LODGroup> JKGHHNEFDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D507A0", Offset = "0x7D4F9A0", VA = "0x187D507A0")]
	private List<(int, Material)> MDLNJJIADKO(float LOPJINMKODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D4EF20", Offset = "0x7D4E120", VA = "0x187D4EF20")]
	public void ELPJDBNOPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7D4EFD0", Offset = "0x7D4E1D0", VA = "0x187D4EFD0")]
	private bool IFJINHPANCM(GameObject GNOLFLMODHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7D51280", Offset = "0x7D50480", VA = "0x187D51280")]
	public LICIAELFPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class HDCMLBCHNIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct AEPEOLJDADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 IMCPMFMKKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 BCBBNNPFNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float CHLBGEBHMML;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F900", Offset = "0x7D3EB00", VA = "0x187D3F900")]
		public AEPEOLJDADJ(Bounds FNDKJDJMBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F7F0", Offset = "0x7D3E9F0", VA = "0x187D3F7F0")]
		public AEPEOLJDADJ(float3 IMCPMFMKKOG, float3 BCBBNNPFNAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct FJCEDBCOFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AEPEOLJDADJ JCNMCICJMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int EBHNBMPOMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int EJLPPEECFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float CDLMFOJPAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int MKEEMFLOFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int IGJKCBEPHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int LGGCHGIHGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int EGOOHFEFAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int KGKDJHIJOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool DOMCJLKNDKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct EIBIAALHFJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh GLJCMIIGKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 AGBIGMCLHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int GAJGAFPICBI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct LKNEDDIJJLH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<FJCEDBCOFAE> BJHIMBLJFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> JLALKPGHLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int FAPIINOHJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AEPEOLJDADJ FNDKJDJMBAF;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7D51500", Offset = "0x7D50700", VA = "0x187D51500")]
		private float FPEMHGHDIEK(AEPEOLJDADJ FCKEKMKDGOB, AEPEOLJDADJ PMDPDEMGJJE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D512E0", Offset = "0x7D504E0", VA = "0x187D512E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker OMDDDFLNFEG;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker HOHMJOJIKGJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker PDFBGKKLNAD;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker EPKLBJHMPIK;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker HIECAIGOIJD;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker NIJOLGDOLEP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker DLCCOAOLOKM;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker BMCHDCDPJHA;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker NAOIKFLOEMM;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker OMMLICCLEPL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker MEMNAJDAPPN;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker INPOIILCDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<FJCEDBCOFAE> BJHIMBLJFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> FDCFBELHKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int IFBLBIJDDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> OEGAIMCGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<EIBIAALHFJP> CLIMDEPJMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> JKGHHNEFDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> DAMBAOLBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> CAHNALCBIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader KIFCHDGHPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader LPGGLPGBJJF;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B210", Offset = "0x7D4A410", VA = "0x187D4B210")]
	public HDCMLBCHNIK(int NHHJJPNENCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7D49D30", Offset = "0x7D48F30", VA = "0x187D49D30")]
	private void KKNHBBMKPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7D48AF0", Offset = "0x7D47CF0", VA = "0x187D48AF0")]
	public bool KBLENIIPEGI(MeshRenderer HPAIMANAFLH, MeshFilter HIHFEFELPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7D49000", Offset = "0x7D48200", VA = "0x187D49000")]
	public bool KBLENIIPEGI(LODGroup OHECFEMFPOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7D48160", Offset = "0x7D47360", VA = "0x187D48160")]
	private bool HHAMPMLOBIE(MeshRenderer HPAIMANAFLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AE20", Offset = "0x7D4A020", VA = "0x187D4AE20")]
	private int OIPCIMMGDKD(MeshRenderer HPAIMANAFLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7D47B00", Offset = "0x7D46D00", VA = "0x187D47B00")]
	private int EOAJCHNMPKI(LODGroup OHECFEMFPOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7D48990", Offset = "0x7D47B90", VA = "0x187D48990")]
	private int KBGNLCOEEKM(MeshFilter HIHFEFELPFN, int FHPOHJMOJFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7D481E0", Offset = "0x7D473E0", VA = "0x187D481E0")]
	private int ILPPDOKHHCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7D47660", Offset = "0x7D46860", VA = "0x187D47660")]
	private static AEPEOLJDADJ BHNFPHDJODB(AEPEOLJDADJ FCKEKMKDGOB, AEPEOLJDADJ PMDPDEMGJJE)
	{
		return default(AEPEOLJDADJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7D48570", Offset = "0x7D47770", VA = "0x187D48570")]
	private static float JKMPHKCAOND(Vector3 IMCPMFMKKOG, Vector3 BCBBNNPFNAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7D47DF0", Offset = "0x7D46FF0", VA = "0x187D47DF0")]
	private int FPJNCABPNAL(int GCGICFCBFNH, AEPEOLJDADJ EFIHPNIHGEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7D48700", Offset = "0x7D47900", VA = "0x187D48700")]
	private void JOIBDAGMPOD(AEPEOLJDADJ EFIHPNIHGEM, int NIBICIJAIGM, [Out] float EFKBKGKEPAI, [Out] float PPLGIHPKCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7D47160", Offset = "0x7D46360", VA = "0x187D47160")]
	private void BHICNBOMPHJ(AEPEOLJDADJ EFIHPNIHGEM, int FEGMMOBANPC, Material OHHEKLKCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7D47B70", Offset = "0x7D46D70", VA = "0x187D47B70")]
	private float FPEMHGHDIEK(AEPEOLJDADJ FCKEKMKDGOB, AEPEOLJDADJ PMDPDEMGJJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7D49EA0", Offset = "0x7D490A0", VA = "0x187D49EA0")]
	private void MFLMKMHHNCG(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A990", Offset = "0x7D49B90", VA = "0x187D4A990")]
	private void MJHOEMFKOEH(int AJBLDLELNPJ, int FDMGPGMJMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A360", Offset = "0x7D49560", VA = "0x187D4A360")]
	private void MJGANKJMKKA(int AJBLDLELNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7D47A50", Offset = "0x7D46C50", VA = "0x187D47A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct PCEJPDNCBNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 EKHHHLINNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 INPOALGOLAM;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class HPCAFIEPDBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<PCEJPDNCBNE> NCBDPOPBBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> OFCLDBLKDNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DKMEIHDNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BBD0", Offset = "0x7D4ADD0", VA = "0x187D4BBD0")]
	public HPCAFIEPDBC(int MKEEMFLOFJJ, int HGFLJHNNBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BA90", Offset = "0x7D4AC90", VA = "0x187D4BA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BAF0", Offset = "0x7D4ACF0", VA = "0x187D4BAF0")]
	public void JBHHHNKAKMJ(HPCAFIEPDBC DIABBJKODIG, int GPDHKKPJGFK, int AIGLIPKHKOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class FLBDLDEOOHD
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static HPCAFIEPDBC BBHMOGFDCBK;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<KKJHPMNMBNE> NIHJBNBOJCN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] IOLDODLCDNN;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool OLBKNIGFIBP;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, HPCAFIEPDBC> HMPHBGBKKHJ;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, HPCAFIEPDBC> JODNIALFGIN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool DAKBGEEFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7D45550", Offset = "0x7D44750", VA = "0x187D45550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<KKJHPMNMBNE> KEMCGHKPOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7D45F30", Offset = "0x7D45130", VA = "0x187D45F30")]
		get
		{
			return default(NativeList<KKJHPMNMBNE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static HPCAFIEPDBC HCEPNEICCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7D44D00", Offset = "0x7D43F00", VA = "0x187D44D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7D455D0", Offset = "0x7D447D0", VA = "0x187D455D0")]
	private static void JALABALKCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45140", Offset = "0x7D44340", VA = "0x187D45140")]
	public static int GAGCJLMINOD(bool LABJENGODDO, int PCKEBKKBEDB, bool CDMFBHAKNNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7D463C0", Offset = "0x7D455C0", VA = "0x187D463C0")]
	private static int OOECOFBDNAJ(int PCKEBKKBEDB, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7D454B0", Offset = "0x7D446B0", VA = "0x187D454B0")]
	private static int GCEHDDNGOJF(int PCKEBKKBEDB, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7D454C0", Offset = "0x7D446C0", VA = "0x187D454C0")]
	public static int IDMPAMLMHPE(int ANANLCFKCEG, int PCKEBKKBEDB, int FAODFPPCAJA, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7D450B0", Offset = "0x7D442B0", VA = "0x187D450B0")]
	public static int FAJFKBEFKBB(int ANANLCFKCEG, int PCKEBKKBEDB, int FAODFPPCAJA, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7D44FE0", Offset = "0x7D441E0", VA = "0x187D44FE0")]
	public static int BICAAAINFON(int FAODFPPCAJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7D45010", Offset = "0x7D44210", VA = "0x187D45010")]
	private static int CJMJDOLNKIH(int PCKEBKKBEDB, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7D45F10", Offset = "0x7D45110", VA = "0x187D45F10")]
	private static int LJOPAFOKEEG(int PCKEBKKBEDB, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7D44F70", Offset = "0x7D44170", VA = "0x187D44F70")]
	public static int AONEPEMAJJJ(int ANANLCFKCEG, int PCKEBKKBEDB, int FAODFPPCAJA, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7D45020", Offset = "0x7D44220", VA = "0x187D45020")]
	public static int ECPKLMIPBNB(int ANANLCFKCEG, int PCKEBKKBEDB, int FAODFPPCAJA, bool FPNKCJNCDNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7D44FF0", Offset = "0x7D441F0", VA = "0x187D44FF0")]
	public static int CDNPNHCMHII(int FAODFPPCAJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7D44E80", Offset = "0x7D44080", VA = "0x187D44E80")]
	public static HPCAFIEPDBC ANFAKEPIHDH(int PCKEBKKBEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7D45C80", Offset = "0x7D44E80", VA = "0x187D45C80")]
	private static HPCAFIEPDBC KCEDIFJPNAO(int PCKEBKKBEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7D44D90", Offset = "0x7D43F90", VA = "0x187D44D90")]
	public static HPCAFIEPDBC ACPIELJPFNF(int PCKEBKKBEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45170", Offset = "0x7D44370", VA = "0x187D45170")]
	private static HPCAFIEPDBC GBBEHNNLLEF(int PCKEBKKBEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45FC0", Offset = "0x7D451C0", VA = "0x187D45FC0")]
	public static void NHHAABJGCOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct PJJEIGHNFBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int CAKFAFMNFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 HMGHBHLMNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion JLGGNNKNBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float JMGEGNHOOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float HIGJDAMKHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int HKJLLEFIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int NLNHPPFMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int JNFNGBEKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool GMMMOCIBCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool FOOKLNCPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float BFACDLAHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 DEJMIACCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool HGDNDEDPFFO;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct BDBFFOKPCDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int DDNFDJGMHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int AGKCCCEDMGN;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FKILFOPFDCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<PJJEIGHNFBC> APBOLOHAHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<NOFEPGIGNGP> LJJOCBIDBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<KKJHPMNMBNE> GLOLILBODNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<BDBFFOKPCDC> DCNEDGIHLAE;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7D44BD0", Offset = "0x7D43DD0", VA = "0x187D44BD0")]
	public FKILFOPFDCP(NativeArray<NOFEPGIGNGP> LJJOCBIDBLL, int JAFKPMJIGFL = 1, Allocator FOPENOLHBOM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7D44AE0", Offset = "0x7D43CE0", VA = "0x187D44AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct JNMNFHELJOC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<PCEJPDNCBNE> HBIDKMMOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> DMNOPGGMHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<KKJHPMNMBNE> PAEEHJPGOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<PJJEIGHNFBC> APBOLOHAHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<NOFEPGIGNGP> LJJOCBIDBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<KKJHPMNMBNE> GLOLILBODNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<BDBFFOKPCDC> DCNEDGIHLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int BJBPBFHGLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int IKPJBMAFMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 PLMMAPKDAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion NFKFEFMFOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 NKLIBMBICLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CLFHDPLKNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EBHJIJPCKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> OAEDPHOFCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NJNOPACMBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JAAGDFKCHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FJMAGMCBHDJ;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DCC0", Offset = "0x7D4CEC0", VA = "0x187D4DCC0")]
	public JNMNFHELJOC(CCILIPHKBOG HCLKMHPACPA, PBKMGPOLEJF LCOFGBPDKLF, float3 NOKMJPPHBAO, quaternion LFLEBDKKDBF, float MEGPFAIMDMM, int BFALJDKHBOC = 0, int GCGGBEDBKMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DF40", Offset = "0x7D4D140", VA = "0x187D4DF40")]
	public JNMNFHELJOC(FKILFOPFDCP HCLKMHPACPA, PBKMGPOLEJF LCOFGBPDKLF, float3 NOKMJPPHBAO, quaternion LFLEBDKKDBF, float3 MEGPFAIMDMM, int BFALJDKHBOC = 0, int GCGGBEDBKMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DAF0", Offset = "0x7D4CCF0", VA = "0x187D4DAF0")]
	private float3 HMEBLCFCEDO(float3 OILAFHICCAK, Matrix4x4 DCDKCLJDILL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DC30", Offset = "0x7D4CE30", VA = "0x187D4DC30")]
	private float3x3 IKPCPECDLCH(float3x3 IJLEHKPDBIO, float3x3 LJPHDBAGADK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DCB0", Offset = "0x7D4CEB0", VA = "0x187D4DCB0")]
	private float LOAJIGKPEED(float MMIJFAFPOOH, float AJCCJKDNFFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C510", Offset = "0x7D4B710", VA = "0x187D4C510", Slot = "4")]
	public void Execute(int DLMCFJOIHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BE20", Offset = "0x7D4B020", VA = "0x187D4BE20")]
	private void BMENCJEEIGI(int OLNPHELCJBB, float3 BJHAAAPCKLC, float3 PLEIILPBIGD, float3 AHKONODNLEG, float IHBIKJPLAHJ, bool GIIHJNGININ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D6B0", Offset = "0x7D4C8B0", VA = "0x187D4D6B0")]
	private void GPFMGOIONAH(PJJEIGHNFBC GNKFPDGFBJN, float3 IOHMIDHCEGD, float3x3 GKAAOLAMBLP, float MMIJFAFPOOH, int NFDDBAKDFKM, int EHLBPIMNDNM, int DMDGFFAEKPB, float LJMKALCMHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BF90", Offset = "0x7D4B190", VA = "0x187D4BF90")]
	private void CFIJOKFIKBE(int OLNPHELCJBB, int PGPLHHGGAGK, PJJEIGHNFBC GNKFPDGFBJN, float3 IOHMIDHCEGD, float3x3 GKAAOLAMBLP, bool PFLMJKLJAJM, float MMIJFAFPOOH, int FJJMDJAHOPC, int MOOFIDHECNA, int DMDGFFAEKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct JMNMBHKOODC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<HFHNHFNBKLD> OCAGHPBIIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<KKJHPMNMBNE> JDAELFPIFMI;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BD30", Offset = "0x7D4AF30", VA = "0x187D4BD30")]
	public JMNMBHKOODC(int JAFKPMJIGFL, Allocator FOPENOLHBOM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BC90", Offset = "0x7D4AE90", VA = "0x187D4BC90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct ANAEEAJLOAK : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum APEGJFPANBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[ReadOnly]
	private NativeList<float3> KOEBDPNGLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> KFLBKFPPLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> BKHOMKDNGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> ANOJFCPAFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> OALFCFPAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> BMPFAOGHGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> LHAOHKEDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> DKPLLOJIOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> DHHEOKIBGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<KKJHPMNMBNE> HNLBAPHNMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<HFHNHFNBKLD> OCAGHPBIIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<KKJHPMNMBNE> JDAELFPIFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int BJBPBFHGLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int IKPJBMAFMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CLFHDPLKNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EBHJIJPCKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> OAEDPHOFCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NJNOPACMBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JAAGDFKCHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OEHDBDLGMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FJMAGMCBHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 NKLIBMBICLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion NFKFEFMFOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 PLMMAPKDAFG;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D40ED0", Offset = "0x7D400D0", VA = "0x187D40ED0")]
	public ANAEEAJLOAK(CCILIPHKBOG HCLKMHPACPA, PBKMGPOLEJF LCOFGBPDKLF, NativeArray<int> FIIPJMAABHN, float3 NOKMJPPHBAO, quaternion LFLEBDKKDBF, float MEGPFAIMDMM, int BFALJDKHBOC = 0, int GCGGBEDBKMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D410E0", Offset = "0x7D402E0", VA = "0x187D410E0")]
	public ANAEEAJLOAK(JMNMBHKOODC DHAOEHNLNON, PBKMGPOLEJF LCOFGBPDKLF, NativeArray<int> FIIPJMAABHN, float3 NOKMJPPHBAO, quaternion LFLEBDKKDBF, float3 MEGPFAIMDMM, int BFALJDKHBOC = 0, int GCGGBEDBKMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FB20", Offset = "0x7D3ED20", VA = "0x187D3FB20", Slot = "4")]
	public void Execute(int DLMCFJOIHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D40AD0", Offset = "0x7D3FCD0", VA = "0x187D40AD0")]
	private void INOEBPLAFPB(float4x4 MGGHHODKNNI, int DLMCFJOIHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FA70", Offset = "0x7D3EC70", VA = "0x187D3FA70")]
	private APEGJFPANBO EBIOADCJKOD(float3 PLEIILPBIGD)
	{
		return default(APEGJFPANBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E80", Offset = "0x7D40080", VA = "0x187D40E80")]
	private float4 MGHALDAIANA(APEGJFPANBO GEHLNCLEDDK, int NIBICIJAIGM)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FAE0", Offset = "0x7D3ECE0", VA = "0x187D3FAE0")]
	private float2 EBLKDOCAPIK(APEGJFPANBO GEHLNCLEDDK, float3 BJHAAAPCKLC)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ABCEPEAAFGE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum HFEDJLKJFAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static ABCEPEAAFGE MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 PHGICKGLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 JPIDPNKLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 LDPBGKCICAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public HFEDJLKJFAN AFGCMPJBOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 LLKBDOLJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 NFFKCPHKPPI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D39F00", Offset = "0x7D39100", VA = "0x187D39F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 GCIHHJGOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A3B0", Offset = "0x7D395B0", VA = "0x187D3A3B0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A5E0", Offset = "0x7D397E0", VA = "0x187D3A5E0")]
	public ABCEPEAAFGE(float3 BJHAAAPCKLC, quaternion PANMBKPFLFA, float3 JAFKPMJIGFL, HFEDJLKJFAN EDLOHJEBKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A1B0", Offset = "0x7D393B0", VA = "0x187D3A1B0")]
	public float MCBLJPCGNNA(float3 IOHMIDHCEGD, float BMMJFMIEKEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A490", Offset = "0x7D39690", VA = "0x187D3A490")]
	public bool PHKADMBEJFJ(float3 PLEIILPBIGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A000", Offset = "0x7D39200", VA = "0x187D3A000")]
	public void EDEFNGBEBKJ(float3 FNILMBPHONH, float3x3 NMCLONEBDKH, float LIANHMKFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D39F10", Offset = "0x7D39110", VA = "0x187D39F10")]
	private void DGAPDOIINPF(float3 IBOHKJNFHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D39C70", Offset = "0x7D38E70", VA = "0x187D39C70")]
	public void ABGLMHAEFGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct FMCBGNNIHMD : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<ABCEPEAAFGE> DHAOEHNLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> FGCDPHHICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> LHKGABDCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CLGFCECNLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<KKJHPMNMBNE> JDAELFPIFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int JLOONGJFAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int MAEAJELIHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float BMMJFMIEKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float CDDDAKIGILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IKCPJCHNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GBIHJMEDEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NHDJKIJDIAG;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D46FC0", Offset = "0x7D461C0", VA = "0x187D46FC0")]
	public FMCBGNNIHMD(PBKMGPOLEJF KHKMPBIDLPA, float GIBFLEEBGNK, int AIGLIPKHKOK, int NFDDBAKDFKM, NativeList<ABCEPEAAFGE> DHAOEHNLNON, NativeArray<int> CLGFCECNLAC, NativeList<KKJHPMNMBNE> JDAELFPIFMI, OIMMFGPJGMB BKEAAGHBHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D467C0", Offset = "0x7D459C0", VA = "0x187D467C0", Slot = "4")]
	public void Execute(int GJNOFJMGFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D46F00", Offset = "0x7D46100", VA = "0x187D46F00")]
	private bool HNEIPHCGBML(ABCEPEAAFGE FCKEKMKDGOB, ABCEPEAAFGE PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D46530", Offset = "0x7D45730", VA = "0x187D46530")]
	private bool BEGCJCIBHHE(ABCEPEAAFGE BEJBCBEBEAC, int KLGBJOGPONI, int CHEOOAKPFBC, int EEONCEOAOFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct MCDCLPBOOOJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<PONELLKLIKB.LEHJOAIBJFO> FBNNFDBNMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> KIMPKKAKIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int BFALJDKHBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int GCGGBEDBKMH;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D516E0", Offset = "0x7D508E0", VA = "0x187D516E0")]
	public MCDCLPBOOOJ(NativeList<PONELLKLIKB.LEHJOAIBJFO> FBNNFDBNMBL, NativeArray<int> KIMPKKAKIHC, int GCGGBEDBKMH = 0, int BFALJDKHBOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D51630", Offset = "0x7D50830", VA = "0x187D51630", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class OIMMFGPJGMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> DGHJOGMFIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> NGFGMAAFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> OLCMENKOOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> BELLKCFNMGK;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D51EE0", Offset = "0x7D510E0", VA = "0x187D51EE0")]
	public void EPNMOGAJAEC(int MKEEMFLOFJJ, int HGFLJHNNBAG, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D520F0", Offset = "0x7D512F0", VA = "0x187D520F0")]
	public static long OLAJGOGMBCE(int MKEEMFLOFJJ, int HGFLJHNNBAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D51DF0", Offset = "0x7D50FF0", VA = "0x187D51DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D52000", Offset = "0x7D51200", VA = "0x187D52000")]
	public void GNJBDGKPLLM(JobHandle EOJDBKLNAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OIMMFGPJGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct PLCJILCJJGC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> FGCDPHHICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> MJGJOBDPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> DEANHPLFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> MLHPJFPNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> LHKGABDCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LGKDIAIONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> KFHEGGGJAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> IKCPJCHNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> GBIHJMEDEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int BFALJDKHBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int GCGGBEDBKMH;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A90", Offset = "0x7D51C90", VA = "0x187D52A90")]
	public PLCJILCJJGC(PBKMGPOLEJF KHKMPBIDLPA, OIMMFGPJGMB BKEAAGHBHNH, int GCGGBEDBKMH = 0, int BFALJDKHBOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D526B0", Offset = "0x7D518B0", VA = "0x187D526B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D52650", Offset = "0x7D51850", VA = "0x187D52650")]
	private void CGOKEFFOHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class DIPFILLFFBK
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x366A540", Offset = "0x3669740", VA = "0x18366A540")]
	public static bool BEOINBFOELK<T>(NativeArray<T> CABEAFGDMFF, int JAFKPMJIGFL, Allocator FOPENOLHBOM, NativeArrayOptions KDLGPMFPDII = NativeArrayOptions.ClearMemory, int DOMIMDNLABH = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x366A780", Offset = "0x3669980", VA = "0x18366A780")]
	public static bool BEOINBFOELK<T>(NativeList<T> MEHAOGGFJIO, int JAFKPMJIGFL, Allocator FOPENOLHBOM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x366A840", Offset = "0x3669A40", VA = "0x18366A840")]
	public static bool BEOINBFOELK<T>(NativeQueue<T> AJKLJDHODDP, Allocator FOPENOLHBOM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum NNNLBPFEJKG
{
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Force2,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	AllOfThem
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface IIGOFCLCLJP
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HGHKKLKFJHK(NNNLBPFEJKG ANANLCFKCEG);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LFMHDEIKMAI(NNNLBPFEJKG ANANLCFKCEG);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DEJFKMDCDHJ OOOEDGOLNPL();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float FKKLDLJOGCE();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBLNCBIFKJA(NNNLBPFEJKG ANANLCFKCEG, CCILIPHKBOG NACJJLCOMCL, int DIJAELCBEGJ = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KJKMDOOCPGN(int IPGNCFCHOMG);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class MJPFEDJBLKC
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D51700", Offset = "0x7D50900", VA = "0x187D51700")]
	public static void NHHAABJGCOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class ACEAEPPHAPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> BOCCADBEGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> FNEKBNJAKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> GKFEFJIDMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> BFABCCFPKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> OJAKMPMEHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> LIONBBENACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> JFEGGDICFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> EPODBDFIBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> KDNNGOEBDMN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B5A0", Offset = "0x7D3A7A0", VA = "0x187D3B5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DKMEIHDNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B560", Offset = "0x7D3A760", VA = "0x187D3B560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NFBJBOBGNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A7F0", Offset = "0x7D399F0", VA = "0x187D3A7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B5E0", Offset = "0x7D3A7E0", VA = "0x187D3B5E0")]
	public ACEAEPPHAPA(int MKEEMFLOFJJ, int HGFLJHNNBAG, int EMIBAJLOHFH, Allocator FOPENOLHBOM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B900", Offset = "0x7D3AB00", VA = "0x187D3B900")]
	public ACEAEPPHAPA(Mesh KHKMPBIDLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A6D0", Offset = "0x7D398D0", VA = "0x187D3A6D0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D3ADA0", Offset = "0x7D39FA0", VA = "0x187D3ADA0")]
	public void JBHHHNKAKMJ(ACEAEPPHAPA KHKMPBIDLPA, bool KIKDKHMDNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B0D0", Offset = "0x7D3A2D0", VA = "0x187D3B0D0")]
	private void JHGKOFLMJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A830", Offset = "0x7D39A30", VA = "0x187D3A830")]
	private void HPANJPOBFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct KKJHPMNMBNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int CKADBBPLJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int IIHJCLBFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int CFBCKKJEFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int DKMEIHDNIPO;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F620E0", Offset = "0x1F612E0", VA = "0x181F620E0")]
	public KKJHPMNMBNE(int NFDDBAKDFKM, int KLACLIDIDNP, int AIGLIPKHKOK, int CPBAFNDHECP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class MNAGEFHMLHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<KKJHPMNMBNE> LHAIBCEOEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KKJHPMNMBNE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ACEAEPPHAPA GLJCMIIGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D517C0", Offset = "0x7D509C0", VA = "0x187D517C0")]
	public MNAGEFHMLHN(IEnumerable<ACEAEPPHAPA> CFEMJPGPPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D51750", Offset = "0x7D50950", VA = "0x187D51750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum NHICBHPHDJP
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class IOHAMHHJKJC
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> POILDLDFPPP;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> JFPMAOFFGLC;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> NJHJOHCNAAO;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> PKIPEBBLACI;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D55FB0", Offset = "0x7D551B0", VA = "0x187D55FB0")]
	public static void NHHAABJGCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D55EB0", Offset = "0x7D550B0", VA = "0x187D55EB0")]
	public static NativeArray<float2> MFBNPHEJIBD(NativeArray<float2> LPNCANJFGFE, int HNDHEPNKEOC, NativeArray<float2> GHLECNLOKFP, int LAEOANKHENE)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D55DB0", Offset = "0x7D54FB0", VA = "0x187D55DB0")]
	public static NativeArray<float3> ENABOLAEDBH(NativeArray<float3> LPNCANJFGFE, int HNDHEPNKEOC, NativeArray<float3> GHLECNLOKFP, int LAEOANKHENE)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D560C0", Offset = "0x7D552C0", VA = "0x187D560C0")]
	public static NativeArray<float4> NPCJEGLPBNN(NativeArray<float4> LPNCANJFGFE, int HNDHEPNKEOC, NativeArray<float4> GHLECNLOKFP, int LAEOANKHENE)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D55CB0", Offset = "0x7D54EB0", VA = "0x187D55CB0")]
	public static NativeArray<int> AKFNCCILOFK(NativeArray<int> LPNCANJFGFE, int HNDHEPNKEOC, NativeArray<int> GHLECNLOKFP, int LAEOANKHENE)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3852CB0", Offset = "0x3851EB0", VA = "0x183852CB0")]
	private static void OKEAIHGIDAL<T>(NativeArray<T> CABEAFGDMFF, int JOPOIHICHAC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3852BD0", Offset = "0x3851DD0", VA = "0x183852BD0")]
	private static void CACLGBACNDG<T>(NativeArray<T> LPNCANJFGFE, int HNDHEPNKEOC, NativeArray<T> GHLECNLOKFP, int LAEOANKHENE, NativeArray<T> BKGNDDBHCMI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class OEMAGCMFODM
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct EMCMICFHGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort CCOLDGJALNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort JCBKIOEHCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort OMKCPOJOENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort DCGAHPNBAIP;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D60A70", Offset = "0x7D5FC70", VA = "0x187D60A70")]
	public static uint EAGCAKCPEFJ(float CODIDPLFLJD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D60860", Offset = "0x7D5FA60", VA = "0x187D60860")]
	public static void BPDKKKMHDDE(float4 DEANHPLFMOD, float KKOOGAMDHPA, [Out] uint GEDNDBCFLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D60970", Offset = "0x7D5FB70", VA = "0x187D60970")]
	public static void BPDKKKMHDDE(float4 DEANHPLFMOD, uint CODIDBFLBKL, [Out] uint GEDNDBCFLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D60610", Offset = "0x7D5F810", VA = "0x187D60610")]
	public static void BNBLACGPDLA(float3 MCECJIGEGLJ, float3 FIHPPCIFDIK, float4 MOALPPLHCDM, float2 NHILDLNBJNC, float4 DEANHPLFMOD, [Out] PBKMGPOLEJF.OIHBPPIMBHM IOMPPOKOHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D603B0", Offset = "0x7D5F5B0", VA = "0x187D603B0")]
	public static void BNBLACGPDLA(float3 MCECJIGEGLJ, float3 FIHPPCIFDIK, float4 MOALPPLHCDM, float2 NHILDLNBJNC, float4 DEANHPLFMOD, [Out] PBKMGPOLEJF.CMDIDNBCKFB IOMPPOKOHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D60E00", Offset = "0x7D60000", VA = "0x187D60E00")]
	public static byte PIDCOHBDDEO(float MLCDCHNOCFI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D60A80", Offset = "0x7D5FC80", VA = "0x187D60A80")]
	public static ushort FFMDECCNBBB(float MLCDCHNOCFI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D60A40", Offset = "0x7D5FC40", VA = "0x187D60A40")]
	public static uint DPOEEHLONLO(float MLCDCHNOCFI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D60D80", Offset = "0x7D5FF80", VA = "0x187D60D80")]
	public static float2 NIKEPMKGGEM(float2 KOBHBJCHIOC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D60260", Offset = "0x7D5F460", VA = "0x187D60260")]
	public static float2 BIMPGBKMKMD(float3 EMNFBEIKLFD)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D60C30", Offset = "0x7D5FE30", VA = "0x187D60C30")]
	public static void KNAJKHCLLLP(float3 MLCDCHNOCFI, [Out] float3 OELDENMADEO, [Out] uint3 DCGAHPNBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D60AD0", Offset = "0x7D5FCD0", VA = "0x187D60AD0")]
	public static EMCMICFHGLM FPOAFCMOBOJ(float3 BJHAAAPCKLC)
	{
		return default(EMCMICFHGLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class KGGPAENAGKK
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker FBPCCLPOFCN;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float ADFEJHCALNH;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void HHOMMOLMKNB(bool LPGJGNGIGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D56620", Offset = "0x7D55820", VA = "0x187D56620")]
	public static float LPKGEAHDIGH(float BGPBLOFDFJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D56530", Offset = "0x7D55730", VA = "0x187D56530")]
	public static long BMDLDDDOEIF(float BGPBLOFDFJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D56730", Offset = "0x7D55930", VA = "0x187D56730")]
	public static void PENOPKJHMOO(float BGPBLOFDFJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface JJJOMGMPDHL
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PENOPKJHMOO(float HHJKJDBIOGK);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) CCADKHGOIKP(float HJLBFKFAJPP);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class LNNHJJCJKNB
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum LMCMNDEOIPL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		ShapesTreeError,
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class BMDCCMPLCGD : CELGENENAJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public LMCMNDEOIPL EDLOHJEBKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BatchedMeshRenderer HNJMEGDMPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public OEBOMGFEEJJ NLAIAICEPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PONELLKLIKB NLPCNCAKDMF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float AFKEOEFICMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA60", Offset = "0x10CEC60", VA = "0x1810CFA60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x17604C0", Offset = "0x175F6C0", VA = "0x1817604C0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7D52DD0", Offset = "0x7D51FD0", VA = "0x187D52DD0", Slot = "7")]
		public override void LKPFOCCLOAA([Out] bool PDOMAIGFLAL, [Out] bool PDGCJJGHOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BMDCCMPLCGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int NMKFLIJKGBI;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int DIIAGKDDNMC;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int IAIFCFOJLMN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long JCNOOANMLIJ;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long FBDAALDAKKP;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long DMKCGOOFBFO;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long PLECDIKADGP;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int LKEJMGGMMCN;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float DJEAKFFMDPN;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool OBJBBPHLHLG;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int IIEOMGOPFCG;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int IAALBMOKFEC;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int ICCLBHKPPNI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long DNPECLGMDEP;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int PGFMCBGGBIK;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool FNPGCCPPFLM;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint FHBCADNKBNP;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static OKHLNAAMGMC BJCMEIIBKCA;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> NOPOFNINOLB;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static JJJOMGMPDHL CJCMMMHDFNH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool DDOOCPCPMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7D576D0", Offset = "0x7D568D0", VA = "0x187D576D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void BAIKPKDJIBC(bool LPGJGNGIGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void HHOMMOLMKNB(bool LPGJGNGIGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void BAIKPKDJIBC(bool LPGJGNGIGGC, string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7D58760", Offset = "0x7D57960", VA = "0x187D58760")]
	public static void OIJNBJHJMKH(JJJOMGMPDHL IJPDKCCNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7D57B00", Offset = "0x7D56D00", VA = "0x187D57B00")]
	public static (long, long, long, int, int) EBEEBFFPFHB(long EAKMKHEENFM)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7D58160", Offset = "0x7D57360", VA = "0x187D58160")]
	public static void IKFNKDCEAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7D587D0", Offset = "0x7D579D0", VA = "0x187D587D0")]
	public static void PENOPKJHMOO(long EAKMKHEENFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7D57FE0", Offset = "0x7D571E0", VA = "0x187D57FE0")]
	public static void IJOGJPBKJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7D58390", Offset = "0x7D57590", VA = "0x187D58390")]
	public static long JJIODFEADCP(long BAAAIMNNJKG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7D57F10", Offset = "0x7D57110", VA = "0x187D57F10")]
	public static bool IEMEHNBMCAB(long AONFOODPNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7D57DD0", Offset = "0x7D56FD0", VA = "0x187D57DD0")]
	public static bool FHPGNECEBOE(long AONFOODPNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7D57720", Offset = "0x7D56920", VA = "0x187D57720")]
	public static float DDCBDCCLHFA(long OPINHIGMINN, int HBMMOCHFBON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7D56FE0", Offset = "0x7D561E0", VA = "0x187D56FE0")]
	public static (long, long, int) CCADKHGOIKP(float BGPBLOFDFJB)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7D56CA0", Offset = "0x7D55EA0", VA = "0x187D56CA0")]
	public static void BAJDAGODEFC(PONELLKLIKB NLPCNCAKDMF, BatchedMeshRenderer HNJMEGDMPMB, long IEMPGBDONFA, long GNKNMCJGOBL, float AOJICHCBHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7D58530", Offset = "0x7D57730", VA = "0x187D58530")]
	public static void KNNLCINLJON(PONELLKLIKB NLPCNCAKDMF, BatchedMeshRenderer HNJMEGDMPMB, long IEMPGBDONFA, long GNKNMCJGOBL, float GONIFFKGLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7D581E0", Offset = "0x7D573E0", VA = "0x187D581E0")]
	public static void IMPOCALKADD(PONELLKLIKB NLPCNCAKDMF, BatchedMeshRenderer HNJMEGDMPMB, long GNKNMCJGOBL, float GONIFFKGLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7D56E30", Offset = "0x7D56030", VA = "0x187D56E30")]
	public static void BNCKEOGBFLJ(PONELLKLIKB NLPCNCAKDMF, BatchedMeshRenderer HNJMEGDMPMB, long IEMPGBDONFA, long GNKNMCJGOBL, float GONIFFKGLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7D573E0", Offset = "0x7D565E0", VA = "0x187D573E0")]
	private static void CEJKNEPFGJB(LMCMNDEOIPL EDLOHJEBKFM, PONELLKLIKB NLPCNCAKDMF, OEBOMGFEEJJ NLAIAICEPNN, BatchedMeshRenderer HNJMEGDMPMB, long IEMPGBDONFA, long GNKNMCJGOBL, float CKBKKCDBLHI, bool JBPEPBIIAFN, bool AMLMJDBLCME, float NNIDLNKAMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7D586B0", Offset = "0x7D578B0", VA = "0x187D586B0")]
	public static bool OGALEONHBHB(float LDCCONJMJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7D57EA0", Offset = "0x7D570A0", VA = "0x187D57EA0")]
	public static void GDANJJOCBHP(float LDCCONJMJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7D57CC0", Offset = "0x7D56EC0", VA = "0x187D57CC0")]
	public static bool FDGCAEOBJBM(float LDCCONJMJNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class CELGENENAJI : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum PHHENCJLGHL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		Instant,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		Persistent
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public PHHENCJLGHL MHOKCPJIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public long IIFMJKDAMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long GNKNMCJGOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public float JFDODEEIIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool AMLMJDBLCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool JBPEPBIIAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal uint MKHHKDJKLDN;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float AFKEOEFICMO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void LKPFOCCLOAA([Out] bool PDOMAIGFLAL, [Out] bool PDGCJJGHOND);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7D53230", Offset = "0x7D52430", VA = "0x187D53230", Slot = "4")]
	public int CompareTo(object DBCLNEGBNLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected CELGENENAJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class OKHLNAAMGMC : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private List<CELGENENAJI> KPMKCPMBAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<CELGENENAJI> BDLJMHNPDCL;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7D61430", Offset = "0x7D60630", VA = "0x187D61430")]
	public void OOLDDNFEGEK(CELGENENAJI CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7D612B0", Offset = "0x7D604B0", VA = "0x187D612B0")]
	public void HAGJHGAGGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7D60ED0", Offset = "0x7D600D0", VA = "0x187D60ED0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7D60F60", Offset = "0x7D60160", VA = "0x187D60F60")]
	public void GCHCMKKDJJF(IEnumerable<uint> NOPOFNINOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7D61310", Offset = "0x7D60510", VA = "0x187D61310")]
	private void KKKHDEJPLIG(uint MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7D61500", Offset = "0x7D60700", VA = "0x187D61500", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7D613D0", Offset = "0x7D605D0", VA = "0x187D613D0")]
	public JLKHFPOEKNE MAJHBAEJHEK()
	{
		return default(JLKHFPOEKNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7D615A0", Offset = "0x7D607A0", VA = "0x187D615A0")]
	public OKHLNAAMGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct JLKHFPOEKNE : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<CELGENENAJI> KPMKCPMBAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<CELGENENAJI> BDLJMHNPDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int EAAEMNIJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int DAGFKCLBECE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7D564E0", Offset = "0x7D556E0", VA = "0x187D564E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CELGENENAJI HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7D561C0", Offset = "0x7D553C0", VA = "0x187D561C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7D564F0", Offset = "0x7D556F0", VA = "0x187D564F0")]
	public JLKHFPOEKNE(List<CELGENENAJI> KPMKCPMBAAE, List<CELGENENAJI> BDLJMHNPDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7D56340", Offset = "0x7D55540", VA = "0x187D56340", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7D564D0", Offset = "0x7D556D0", VA = "0x187D564D0", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class OEBOMGFEEJJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum CMEPDJPLPNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly string JHKPFJMFCFO;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string EINGGHPLBBA;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker PFGEOACHOCF;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker IJBKOCHMNGC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker FBPCCLPOFCN;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker HIDBAIIJGDI;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker PEOHFBEDGJP;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker KHIIJJBHDKM;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker OBNJNBHLOGJ;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker JGPOCKHBCMG;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker NEIGDACPEDB;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker GHFOGMHHPDN;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker AJHBOIIHLFN;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker MJKKODFGPBJ;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker NCFKPFCGICJ;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker NKKFOLHJHBJ;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker DEDIEDGLGOD;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker NIIMKDEDHEJ;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker JECFEIJMHJI;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker KAFBKOACAIH;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker KAPGJPBBCKF;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly ProfilerMarker JNPIJJENDJH;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly ProfilerMarker BLFIIEFOKMF;

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static readonly ProfilerMarker AENIECHCCNP;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly ProfilerMarker CGHLJDIFFCE;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly ProfilerMarker LBODMCOIIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal readonly List<PONELLKLIKB> DALHFBAJCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal PONELLKLIKB PKPHOHCMOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly PIJFLCEMDCN FLPKJJBMIGF;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public const bool BDJFPMNFDGG = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public bool FFOEKBALDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal CMEPDJPLPNP OBLNHDEAJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int ALDNNCDNHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal int ELENMNKFEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal int KJHNFFFNPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal int NOBGGANEELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	internal long EDFHBFIKEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal long BFJHGDHLBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal long CNAGLJHCMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private PBKMGPOLEJF MCJMODDIMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private PBKMGPOLEJF ADMEKDDEKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private PBKMGPOLEJF.FPNIDPGNDKH MIFAPPIICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private bool KONIALPPPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int KGEKEBOMJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private KEPAJAODJEK CLCKOLLFCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float3 OIPHAILNCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float BENDABMLKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float AMGJENDLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float NNEBDJKFHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float PHGECHOPPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float JMBLGELCNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float MBDOEFBKJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private float3 IJJDDEBBNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float NNFOGHHEEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private float GBOKGACBPFG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal Mesh GLJCMIIGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MeshFilter GGCAPOIICAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshRenderer AJNMIPFOKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<Material> GAIKHCJMILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int IINGCIMAONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B880", Offset = "0x7D5AA80", VA = "0x187D5B880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ACIJBHJOELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xD863B0", Offset = "0xD855B0", VA = "0x180D863B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7D5DFC0", Offset = "0x7D5D1C0", VA = "0x187D5DFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C250", Offset = "0x7D5B450", VA = "0x187D5C250")]
	public void CMGPCJKIOIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B8A0", Offset = "0x7D5AAA0", VA = "0x187D5B8A0")]
	public bool CIIGDJNDLEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D5CC60", Offset = "0x7D5BE60", VA = "0x187D5CC60")]
	private void HGPKDDNODKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B260", Offset = "0x7D5A460", VA = "0x187D5B260")]
	private void BIJJLFPGFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7D600C0", Offset = "0x7D5F2C0", VA = "0x187D600C0")]
	public OEBOMGFEEJJ(string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C4E0", Offset = "0x7D5B6E0", VA = "0x187D5C4E0")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C380", Offset = "0x7D5B580", VA = "0x187D5C380")]
	private void DIOMICCMGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EAA0", Offset = "0x7D5DCA0", VA = "0x187D5EAA0")]
	private void OMBIHELCHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D5CE30", Offset = "0x7D5C030", VA = "0x187D5CE30")]
	public Mesh IEODBGIGCAB(MeshFilter NBMEGGDHHNH, Transform PMPOHKBNMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7D5E900", Offset = "0x7D5DB00", VA = "0x187D5E900")]
	private void NMIILLDAOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7D5DFF0", Offset = "0x7D5D1F0", VA = "0x187D5DFF0")]
	public void MBHPLCKMKIG(IIGOFCLCLJP OEELNEFFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C820", Offset = "0x7D5BA20", VA = "0x187D5C820")]
	public bool HDGDNEAPKFK(IIGOFCLCLJP OEELNEFFBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7D5CD80", Offset = "0x7D5BF80", VA = "0x187D5CD80")]
	public bool HHAMPMLOBIE(IIGOFCLCLJP OEELNEFFBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B3B0", Offset = "0x7D5A5B0", VA = "0x187D5B3B0", Slot = "4")]
	public virtual void BLMHPCABDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C8F0", Offset = "0x7D5BAF0", VA = "0x187D5C8F0")]
	public void HGNNJIHFODI(Transform CPKLBNLBGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7D5D160", Offset = "0x7D5C360", VA = "0x187D5D160")]
	public bool JFGJKGGPHGB(Transform CPKLBNLBGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7D5BCA0", Offset = "0x7D5AEA0", VA = "0x187D5BCA0")]
	public bool CJBLLGBKLCC(bool MHKHGKJIHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7D5CEC0", Offset = "0x7D5C0C0", VA = "0x187D5CEC0")]
	private void JDGCEFLNCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7D5ED30", Offset = "0x7D5DF30", VA = "0x187D5ED30")]
	public bool PENOPKJHMOO(float4x4 PLCNEOBDJKP, BatchedMeshRenderer KNOJJLGFHIK, bool KOGIBLOJFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5AC30", Offset = "0x7D59E30", VA = "0x187D5AC30")]
	public bool ANDJIHKOGDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7D5DA90", Offset = "0x7D5CC90", VA = "0x187D5DA90")]
	public void JMCJJKGNLME(PBKMGPOLEJF KHKMPBIDLPA, int DJBBKCKEHIG, int BEJNFKNDAMB, float ELHDNIIKHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7D5E170", Offset = "0x7D5D370", VA = "0x187D5E170")]
	public (long, long, long) MJHJDHCCDLB()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
	public long GKCEECDMDDF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B140", Offset = "0x7D5A340", VA = "0x187D5B140")]
	private void BBAHNEDOBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B610", Offset = "0x7D5A810", VA = "0x187D5B610")]
	public (long, long, int) CCADKHGOIKP(float BGPBLOFDFJB, float4x4 PLCNEOBDJKP)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7D5CE10", Offset = "0x7D5C010", VA = "0x187D5CE10")]
	internal void ICHKGAJFHBK(CMEPDJPLPNP BPMKPBKLFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7D5E1F0", Offset = "0x7D5D3F0", VA = "0x187D5E1F0")]
	internal (float, float, float, float) NIEAICJDMKG(float IIJNKFFDNPH, float4x4 PLCNEOBDJKP)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7D5CF40", Offset = "0x7D5C140", VA = "0x187D5CF40")]
	public void JDMGPFIJOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7D5D5B0", Offset = "0x7D5C7B0", VA = "0x187D5D5B0")]
	private void JFKEEFBGFCH(PBKMGPOLEJF HKLMIELIHLH, PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C4C0", Offset = "0x7D5B6C0", VA = "0x187D5C4C0")]
	private void GJLBFJLPNNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7D5DEB0", Offset = "0x7D5D0B0", VA = "0x187D5DEB0")]
	internal bool JPNKLKMNPCG(bool MHKHGKJIHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B9C0", Offset = "0x7D5ABC0", VA = "0x187D5B9C0")]
	private void CIMCJPBMIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7D5DAD0", Offset = "0x7D5CCD0", VA = "0x187D5DAD0")]
	private void JMKNPLONDIE([In] JFNLGADNLID HKLMIELIHLH, PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ, bool CJBJHFALDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EA00", Offset = "0x7D5DC00", VA = "0x187D5EA00")]
	private void NNFHJGFDANP(PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7D5C420", Offset = "0x7D5B620", VA = "0x187D5C420")]
	private void FPGLGLDGEDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B4D0", Offset = "0x7D5A6D0", VA = "0x187D5B4D0")]
	private void BMKFOIOEIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7D5D7B0", Offset = "0x7D5C9B0", VA = "0x187D5D7B0")]
	public long JJIODFEADCP(long BAAAIMNNJKG, int FFJPIAPKCON)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class PONELLKLIKB
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum NJDBPIJIAKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public struct LEHJOAIBJFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int NNAIPNIHBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int HLCHGMIKLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public float EFKBKGKEPAI;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct BHHNCKJNKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public JFNLGADNLID KHKMPBIDLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int OKBMEOHPFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int PGAPNJMENGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public long DBOACOFPEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public long HLKNADADBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public float FKGLFANNJDK;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7D52DA0", Offset = "0x7D51FA0", VA = "0x187D52DA0")]
		public void MNFKMEBPDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7D52D20", Offset = "0x7D51F20", VA = "0x187D52D20")]
		public void GNJBDGKPLLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly string JHKPFJMFCFO;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly string EINGGHPLBBA;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker PFGEOACHOCF;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker IJBKOCHMNGC;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker FBPCCLPOFCN;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker HIDBAIIJGDI;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker PEOHFBEDGJP;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker KHIIJJBHDKM;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker OBNJNBHLOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker JGPOCKHBCMG;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker NEIGDACPEDB;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker GHFOGMHHPDN;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker AJHBOIIHLFN;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker MJKKODFGPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker NCFKPFCGICJ;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker NKKFOLHJHBJ;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker DEDIEDGLGOD;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker NIIMKDEDHEJ;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker JECFEIJMHJI;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker KAFBKOACAIH;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker KAPGJPBBCKF;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker JNPIJJENDJH;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker BLFIIEFOKMF;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker AENIECHCCNP;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker CGHLJDIFFCE;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker LBODMCOIIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal readonly List<IIGOFCLCLJP> PHDEJHGJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal OEBOMGFEEJJ OCBOOBKDOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private readonly PIJFLCEMDCN FLPKJJBMIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal int LAPEIABGNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal int OLAHIGNANHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal bool ANNNJBFCJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal bool AMMFAFDGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal NJDBPIJIAKO FLIGHPLFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal bool KGLPBOFPGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float3 KKJNMONHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal float3 GADBDHKMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal float FNICBBGAPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int JDKLNAEDKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int BPBHBOOAILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal float KKDDDENEHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal float MIIMDGJENEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal int LJENOPPOPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal long JOLELLEKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public int BPDCHLNLJKG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal const int JNAOGPACAMI = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float[] NAJNKDGIEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int[] JCBIFKFKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal long[] IJEEMPEMPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public List<BHHNCKJNKCI> OJGELCHLALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal PBKMGPOLEJF ABPIELOJDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal long GODMIDNPPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal int HENJAHMFBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float IBJFCBLIIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal PBKMGPOLEJF.FPNIDPGNDKH LINDMFMDBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal bool MBLKPFFHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal BCNECJOHDBL FAJJAIPGEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal JobHandle JNMGJFFMFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal NativeList<LEHJOAIBJFO> CNMFALJGGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal NativeArray<long> DKNFDNBALDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal bool GDKGMFMHAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal JobHandle ENNPOACKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal PBKMGPOLEJF LCJBKHIKPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal OIMMFGPJGMB JOAFFJBOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal NativeList<LEHJOAIBJFO> OLLDLKMDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal Transform HINPNMGFDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal NNNLBPFEJKG DPEBDFDLIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal long GBGAMGGOKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal long GJALIKCNOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal long KGPICDCGCJG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<IIGOFCLCLJP> MLNFEADAHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7D690C0", Offset = "0x7D682C0", VA = "0x187D690C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7D63760", Offset = "0x7D62960", VA = "0x187D63760")]
	internal void CMGPCJKIOIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7D65070", Offset = "0x7D64270", VA = "0x187D65070")]
	internal void HGPKDDNODKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7D6BB80", Offset = "0x7D6AD80", VA = "0x187D6BB80")]
	internal PONELLKLIKB(string DGIAFBEDPNJ, OEBOMGFEEJJ NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7D64E20", Offset = "0x7D64020", VA = "0x187D64E20")]
	internal void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7D69B30", Offset = "0x7D68D30", VA = "0x187D69B30")]
	internal void NMIILLDAOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7D690E0", Offset = "0x7D682E0", VA = "0x187D690E0")]
	internal void MBHPLCKMKIG(IIGOFCLCLJP OEELNEFFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7D64F70", Offset = "0x7D64170", VA = "0x187D64F70")]
	internal bool HDGDNEAPKFK(IIGOFCLCLJP OEELNEFFBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7D65230", Offset = "0x7D64430", VA = "0x187D65230")]
	internal bool HHAMPMLOBIE(IIGOFCLCLJP OEELNEFFBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7D62210", Offset = "0x7D61410", VA = "0x187D62210", Slot = "4")]
	internal virtual void BLMHPCABDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7D65380", Offset = "0x7D64580", VA = "0x187D65380")]
	internal long IPJHONBFKLG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7D62A20", Offset = "0x7D61C20", VA = "0x187D62A20")]
	internal long CCKPAGHILIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7D66A90", Offset = "0x7D65C90", VA = "0x187D66A90")]
	internal bool JFGJKGGPHGB(Transform CPKLBNLBGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7D62B30", Offset = "0x7D61D30", VA = "0x187D62B30")]
	internal (bool, PBKMGPOLEJF) CJBLLGBKLCC(bool MHKHGKJIHAL)
	{
		return default((bool, PBKMGPOLEJF));
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7D65430", Offset = "0x7D64630", VA = "0x187D65430")]
	internal void JDGCEFLNCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7D69DC0", Offset = "0x7D68FC0", VA = "0x187D69DC0")]
	internal bool PENOPKJHMOO(float4x4 PLCNEOBDJKP, BatchedMeshRenderer KNOJJLGFHIK, bool KOGIBLOJFPK, bool GAEPGNCMAIC, float AMGJENDLBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7D61660", Offset = "0x7D60860", VA = "0x187D61660")]
	public (bool, JFNLGADNLID) ANDJIHKOGDN()
	{
		return default((bool, JFNLGADNLID));
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7D64FF0", Offset = "0x7D641F0", VA = "0x187D64FF0")]
	internal void HEDOHNKMCAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7D688D0", Offset = "0x7D67AD0", VA = "0x187D688D0")]
	internal bool KFKOGKMOJHL(bool MHKHGKJIHAL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7D690B0", Offset = "0x7D682B0", VA = "0x187D690B0")]
	internal void KKIKJEHCJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7D688A0", Offset = "0x7D67AA0", VA = "0x187D688A0")]
	internal void JMCJJKGNLME(PBKMGPOLEJF KHKMPBIDLPA, int DJBBKCKEHIG, int BEJNFKNDAMB, float ELHDNIIKHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7D64410", Offset = "0x7D63610", VA = "0x187D64410")]
	internal void DLBJAIMPOAN(JFNLGADNLID HFGJBKPEECA, int DJBBKCKEHIG, int BEJNFKNDAMB, float ELHDNIIKHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7D61E20", Offset = "0x7D61020", VA = "0x187D61E20")]
	internal void BBAHNEDOBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7D625C0", Offset = "0x7D617C0", VA = "0x187D625C0")]
	internal (long, long, int) CCADKHGOIKP(float BGPBLOFDFJB, float4x4 PLCNEOBDJKP)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7D65290", Offset = "0x7D64490", VA = "0x187D65290")]
	internal void ICHKGAJFHBK(NJDBPIJIAKO BPMKPBKLFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7D69350", Offset = "0x7D68550", VA = "0x187D69350")]
	internal (float, float, float, float) NIEAICJDMKG(float IIJNKFFDNPH, float4x4 PLCNEOBDJKP)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7D63770", Offset = "0x7D62970", VA = "0x187D63770")]
	private float COCKGHMBMOA(float IIJNKFFDNPH, float4x4 PLCNEOBDJKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7D68C00", Offset = "0x7D67E00", VA = "0x187D68C00")]
	private (int, int) KJKHCBPCKML(float ONFKHFIOOGL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7D652E0", Offset = "0x7D644E0", VA = "0x187D652E0")]
	internal static float IMADIKKBCHM(IIGOFCLCLJP KHKMPBIDLPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7D65B60", Offset = "0x7D64D60", VA = "0x187D65B60")]
	internal void JDMGPFIJOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7D64D60", Offset = "0x7D63F60", VA = "0x187D64D60")]
	internal void FPGLGLDGEDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7D622A0", Offset = "0x7D614A0", VA = "0x187D622A0")]
	internal void BMKFOIOEIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7D68160", Offset = "0x7D67360", VA = "0x187D68160")]
	internal long JJIODFEADCP(long BAAAIMNNJKG, int FFJPIAPKCON)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7D637D0", Offset = "0x7D629D0", VA = "0x187D637D0")]
	private void DDMCPPJOOCJ(PBKMGPOLEJF FGOKGHFFNLL, NativeList<LEHJOAIBJFO> MKPBGIEAPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7D619B0", Offset = "0x7D60BB0", VA = "0x187D619B0")]
	internal void ANLHHKONOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7D64690", Offset = "0x7D63890", VA = "0x187D64690")]
	public static void ECJENNPMFBJ(NativeList<LEHJOAIBJFO> PBPELNJFLFM, PBKMGPOLEJF FGOKGHFFNLL, int ODDFCINGBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7D64D90", Offset = "0x7D63F90", VA = "0x187D64D90")]
	private float GAAILPAABLA(int DACACCCFKMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7D67730", Offset = "0x7D66930", VA = "0x187D67730")]
	internal void JJHDKGMHDDH(PBKMGPOLEJF KHKMPBIDLPA, AIMLMOOPPPL HFGJBKPEECA, int DJBBKCKEHIG, int BEJNFKNDAMB, float ELHDNIIKHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct GMAGJKKKDND : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct LHJMOGGKMBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int KKMGIFDFCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int DMAIGLHFLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int MBLGALMPODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public float CLKMILLJEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float AIMEPLELBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float HGGDFGFJJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float CEMCOGELGDK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct PFPEICPDAEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int KKMGIFDFCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int DMAIGLHFLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int MBLGALMPODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int AFDMJBPAMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float CLKMILLJEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public float AIMEPLELBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public float DHBDOEKHGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public float GKNLNPPGNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public float CEMCOGELGDK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct NPACFGFODBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int BJCPFPKBJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int KDDKOFOFKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public float LNCJBKFBBFM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void FMLEGOGEEEN(GMAGJKKKDND HPBEICBJDKM, [In] LHJMOGGKMBP JOPCIBOJNKJ);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class FJFBIPPDOIB
	{
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CD20", Offset = "0x7D7BF20", VA = "0x187D7CD20")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CE40", Offset = "0x7D7C040", VA = "0x187D7CE40")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CAA0", Offset = "0x7D7BCA0", VA = "0x187D7CAA0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CB40", Offset = "0x7D7BD40", VA = "0x187D7CB40")]
		public static void ENEDPBAOBKF(GMAGJKKKDND HPBEICBJDKM, [In] LHJMOGGKMBP JOPCIBOJNKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void NFMCHFKGBIH(GMAGJKKKDND HPBEICBJDKM, [In] PFPEICPDAEA EDCHDCJCCDL);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class PFACCOOJJMI
	{
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F5A0", Offset = "0x7D7E7A0", VA = "0x187D7F5A0")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F6C0", Offset = "0x7D7E8C0", VA = "0x187D7F6C0")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F320", Offset = "0x7D7E520", VA = "0x187D7F320")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F3C0", Offset = "0x7D7E5C0", VA = "0x187D7F3C0")]
		public static void ENEDPBAOBKF(GMAGJKKKDND HPBEICBJDKM, [In] PFPEICPDAEA EDCHDCJCCDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void FGDGAINMDGD(UnsafeList<int>* FJJHMKFCMFC, UnsafeList<float3>* MGLCOHNOEKO, [NoAlias] float3* KINKAALAKGD, [NoAlias] float4* IDPCNBDKHIN, [NoAlias] float2* NMEJDBHPHCH, [NoAlias] float4* HJMDPDDJPIF, UnsafeList<ALLBGOPEAEB>* GNLGHKBBDHC, UnsafeList<int>* CFGHODHJCML, UnsafeList<float3>* IBMLJJDIKNF, [NoAlias] float3* GLLDBKNBEME, [NoAlias] float4* IKPECKIPHHF, [NoAlias] float2* LLLJJFOAIOK, [NoAlias] float4* DCPKDOFDDLG, int HGFLJHNNBAG, int MKEEMFLOFJJ);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class NCPEFIIOALH
	{
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F000", Offset = "0x7D7E200", VA = "0x187D7F000")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F120", Offset = "0x7D7E320", VA = "0x187D7F120")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D7EC30", Offset = "0x7D7DE30", VA = "0x187D7EC30")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D7ECD0", Offset = "0x7D7DED0", VA = "0x187D7ECD0")]
		public unsafe static void ENEDPBAOBKF(UnsafeList<int>* FJJHMKFCMFC, UnsafeList<float3>* MGLCOHNOEKO, [NoAlias] float3* KINKAALAKGD, [NoAlias] float4* IDPCNBDKHIN, [NoAlias] float2* NMEJDBHPHCH, [NoAlias] float4* HJMDPDDJPIF, UnsafeList<ALLBGOPEAEB>* GNLGHKBBDHC, UnsafeList<int>* CFGHODHJCML, UnsafeList<float3>* IBMLJJDIKNF, [NoAlias] float3* GLLDBKNBEME, [NoAlias] float4* IKPECKIPHHF, [NoAlias] float2* LLLJJFOAIOK, [NoAlias] float4* DCPKDOFDDLG, int HGFLJHNNBAG, int MKEEMFLOFJJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public float3 OIPHAILNCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public float LLAOFFDBKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public float HEOPEHHEKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public float OMDDGOMMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public IOBCCJFAAHB.NENLOFDAMKH BGKHPEKAOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public bool CKODJJBBBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<ALLBGOPEAEB>* GNLGHKBBDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* CFGHODHJCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<LHJMOGGKMBP>* NIAALDNBHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<LHJMOGGKMBP>* KIGFONHCOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<PFPEICPDAEA>* ODPOFIHOGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<PFPEICPDAEA>* PCBFAKEIACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public int EICAAKKFHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public int KKHFFGCJMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public int AAJDAIIINID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* IBMLJJDIKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe int* HBJLCJGFBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe NPACFGFODBK* HEBIEBIPLCB;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7D55B70", Offset = "0x7D54D70", VA = "0x187D55B70")]
	private static float JCAOGJDDLPI([In] GMAGJKKKDND HPBEICBJDKM, [In] float3 KKMBEEKADGC, float CEMCOGELGDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7D53360", Offset = "0x7D52560", VA = "0x187D53360")]
	private static int AEOGPPNIMPA(GMAGJKKKDND HPBEICBJDKM, [Out] ALLBGOPEAEB OLKOGNCOPJO, [In] ALLBGOPEAEB NFEGOFAHKHL, [In] ALLBGOPEAEB PDMHINMGIMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7D55BF0", Offset = "0x7D54DF0", VA = "0x187D55BF0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void NCLGMIILCPF(GMAGJKKKDND HPBEICBJDKM, [In] LHJMOGGKMBP JOPCIBOJNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7D55C50", Offset = "0x7D54E50", VA = "0x187D55C50")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void NPDMPICJPFD(GMAGJKKKDND HPBEICBJDKM, [In] PFPEICPDAEA EDCHDCJCCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7D534E0", Offset = "0x7D526E0", VA = "0x187D534E0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7D534F0", Offset = "0x7D526F0", VA = "0x187D534F0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal void FADKFBHMKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7D55140", Offset = "0x7D54340", VA = "0x187D55140")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void HNEKFDDPJNC(UnsafeList<int>* FJJHMKFCMFC, UnsafeList<float3>* MGLCOHNOEKO, [NoAlias] float3* KINKAALAKGD, [NoAlias] float4* IDPCNBDKHIN, [NoAlias] float2* NMEJDBHPHCH, [NoAlias] float4* HJMDPDDJPIF, UnsafeList<ALLBGOPEAEB>* GNLGHKBBDHC, UnsafeList<int>* CFGHODHJCML, UnsafeList<float3>* IBMLJJDIKNF, [NoAlias] float3* GLLDBKNBEME, [NoAlias] float4* IKPECKIPHHF, [NoAlias] float2* LLLJJFOAIOK, [NoAlias] float4* DCPKDOFDDLG, int HGFLJHNNBAG, int MKEEMFLOFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7D551D0", Offset = "0x7D543D0", VA = "0x187D551D0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void INCFAKMJEHE(GMAGJKKKDND HPBEICBJDKM, [In] LHJMOGGKMBP JOPCIBOJNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7D54930", Offset = "0x7D53B30", VA = "0x187D54930")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void GMMKFIFNDNH(GMAGJKKKDND HPBEICBJDKM, [In] PFPEICPDAEA EDCHDCJCCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7D54220", Offset = "0x7D53420", VA = "0x187D54220")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void GBNGIGLALGJ(UnsafeList<int>* FJJHMKFCMFC, UnsafeList<float3>* MGLCOHNOEKO, [NoAlias] float3* KINKAALAKGD, [NoAlias] float4* IDPCNBDKHIN, [NoAlias] float2* NMEJDBHPHCH, [NoAlias] float4* HJMDPDDJPIF, UnsafeList<ALLBGOPEAEB>* GNLGHKBBDHC, UnsafeList<int>* CFGHODHJCML, UnsafeList<float3>* IBMLJJDIKNF, [NoAlias] float3* GLLDBKNBEME, [NoAlias] float4* IKPECKIPHHF, [NoAlias] float2* LLLJJFOAIOK, [NoAlias] float4* DCPKDOFDDLG, int HGFLJHNNBAG, int MKEEMFLOFJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class KEPAJAODJEK
{
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly ProfilerMarker IFHMEAAEDFA;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public const int CMPGBHDCFKO = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private const int ENGMJGFEPLI = 1;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private static int HHBBINGONCA;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static Stack<KEPAJAODJEK> OEGDPHMKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private PBKMGPOLEJF NOGKABKBGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NativeList<ALLBGOPEAEB> GNLGHKBBDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NativeList<int> CFGHODHJCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private NativeList<GMAGJKKKDND.LHJMOGGKMBP> NIAALDNBHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private NativeList<GMAGJKKKDND.LHJMOGGKMBP> KIGFONHCOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private NativeList<GMAGJKKKDND.PFPEICPDAEA> ODPOFIHOGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeList<GMAGJKKKDND.PFPEICPDAEA> PCBFAKEIACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private GMAGJKKKDND HPBEICBJDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JobHandle EOJDBKLNAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private GMAGJKKKDND.NPACFGFODBK IAJJFJHEHFI;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private const int AAJDAIIINID = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D7EA60", Offset = "0x7D7DC60", VA = "0x187D7EA60")]
	private KEPAJAODJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E240", Offset = "0x7D7D440", VA = "0x187D7E240")]
	public void MDGNNKHIGML(PBKMGPOLEJF ACADIOLNLFG, float3 PFBJLEOFCKO, float LHGNNJNHFKB, float LDFPCOKIFNP, float BEJJAPFGFGN, List<PONELLKLIKB.LEHJOAIBJFO> IBAJOHNMNBD, Allocator JGCLDCIOABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D960", Offset = "0x7D7CB60", VA = "0x187D7D960")]
	public (bool, PBKMGPOLEJF, float) AFPGIHEGNNC(List<PONELLKLIKB.LEHJOAIBJFO> IBAJOHNMNBD, Allocator JGCLDCIOABI, bool MHKHGKJIHAL)
	{
		return default((bool, PBKMGPOLEJF, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E1F0", Offset = "0x7D7D3F0", VA = "0x187D7E1F0")]
	public static bool LHLOMGAJPNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E180", Offset = "0x7D7D380", VA = "0x187D7E180")]
	public static int LFOGDOPNBJF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E820", Offset = "0x7D7DA20", VA = "0x187D7E820")]
	public static KEPAJAODJEK OCINDABOKII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D7DF90", Offset = "0x7D7D190", VA = "0x187D7DF90")]
	internal static void BEDCDMAPMEL(KEPAJAODJEK NHNFAELMKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E020", Offset = "0x7D7D220", VA = "0x187D7E020")]
	public static void ICDGNLCFFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E680", Offset = "0x7D7D880", VA = "0x187D7E680")]
	[MPFAIPJMBCK(GGMCIMEHBME.ExitingPlayMode, 0)]
	public static void NHHAABJGCOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct ALLBGOPEAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public float3 IOHMIDHCEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public int KLKJCPHEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public int GPAGHDPEOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public int IBDLBLMIHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public float JLADLOELIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public float MLFDIFCKHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public int HCIHBGKFDCP;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DDB0", Offset = "0x7D6CFB0", VA = "0x187D6DDB0")]
	public static void EAIFKKLDBGP([Out] ALLBGOPEAEB IGGKBIDIAJL, int EHMDNLKKJHN, [In] float3 HANLKJGFPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DE00", Offset = "0x7D6D000", VA = "0x187D6DE00")]
	[IgnoreWarning(1371)]
	public static void EAIFKKLDBGP([Out] ALLBGOPEAEB IGGKBIDIAJL, [In] ALLBGOPEAEB MGPOHFGJFMJ, [In] ALLBGOPEAEB CAOALFLCMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct BCNECJOHDBL : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct NKELIMHPPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int DBMMDNGONML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int EGGBCJDLPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int GLIAHJFFMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int DGIKOFNKIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int LALCGBAFGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int KCBCGKLGCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int OKBMEOHPFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int PGAPNJMENGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float FKGLFANNJDK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct OFLLKNKFOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public IOBCCJFAAHB.AHKIADEGNFJ FEGCBFONDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public float CAOMLNMNNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public float FKLAMKEIOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public float IDNEGLILKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public float OJGKBLJPCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public float MCHDLFADBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public float EKDKGJGFKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public float HHLPPILIDFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct ABCJJBPKNDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public NativeArray<float3> BOCCADBEGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public NativeArray<float3> FNEKBNJAKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public NativeArray<float4> DDDDJPKFPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeArray<float4> HIJKLJKBGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public NativeArray<float2> BOPICDKMMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public NativeArray<int> KDNNGOEBDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public bool PJGDBHIDJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int IIHJCLBFMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int DKMEIHDNIPO;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DB10", Offset = "0x7D6CD10", VA = "0x187D6DB10")]
		public void EPNMOGAJAEC(int MKEEMFLOFJJ, int HGFLJHNNBAG, Allocator FOPENOLHBOM, bool KPOALLNFGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D8C0", Offset = "0x7D6CAC0", VA = "0x187D6D8C0")]
		public static ABCJJBPKNDF BAAIBPNMFCE(PBKMGPOLEJF JIJCOIBMMGK)
		{
			return default(ABCJJBPKNDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DCF0", Offset = "0x7D6CEF0", VA = "0x187D6DCF0")]
		public void GNJBDGKPLLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly ProfilerMarker AECGFNOCFGI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly ProfilerMarker KFDEHPIOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<NKELIMHPPJG> CFFHFBNLOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private ABCJJBPKNDF LBKGLKGNOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private ABCJJBPKNDF FGOKGHFFNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private float3 JNOOOICCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private float3 LDLFHDOBEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private OFLLKNKFOGP DNGLJOOLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* ACFIBGKBLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<PONELLKLIKB.LEHJOAIBJFO> MHEMANHHNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeList<PONELLKLIKB.LEHJOAIBJFO> MMONIPOLNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> CFGHODHJCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<bool> GBIHJMEDEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<int> JFNIMJGOGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<int> EEJIPNNPKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<float> CFDNAGIOIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NativeArray<int> EDFLDBOOIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private NativeArray<float> BKLICBPOGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<int> GGJPLHKAKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private NativeArray<int> MGBBIONLELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private NativeArray<float> MFOMALBIBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private NativeArray<float> DCJGNLNHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private NativeArray<int> EEBPFIIAKKG;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D71200", Offset = "0x7D70400", VA = "0x187D71200")]
	public BCNECJOHDBL([In] List<PONELLKLIKB.BHHNCKJNKCI> HIIMBDHLBIJ, NativeList<PONELLKLIKB.LEHJOAIBJFO> PBHFGEGJGGA, [In] PBKMGPOLEJF IHGCKIHIOEK, [In] NativeList<PONELLKLIKB.LEHJOAIBJFO> MKPBGIEAPDO, [In] NativeArray<long> DKNFDNBALDF, float3 FCOCJHBEMDC, float3 BDPDOBDICOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E320", Offset = "0x7D6D520", VA = "0x187D6E320")]
	public static long CDOGMIMINHE(int MKEEMFLOFJJ, int HGFLJHNNBAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EE40", Offset = "0x7D6E040", VA = "0x187D6EE40", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E340", Offset = "0x7D6D540", VA = "0x187D6E340")]
	public void CGGMOICLMBP(List<PONELLKLIKB.BHHNCKJNKCI> IGDCMKBPOEB, [In] PONELLKLIKB IMNFBFLLICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EE90", Offset = "0x7D6E090", VA = "0x187D6EE90")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool GGLGMNGNKLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E0F0", Offset = "0x7D6D2F0", VA = "0x187D6E0F0")]
	private JFNLGADNLID CAGHCKIFECN(int HCJAEILBBOE, Allocator FOPENOLHBOM)
	{
		return default(JFNLGADNLID);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EEB0", Offset = "0x7D6E0B0", VA = "0x187D6EEB0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void HENEBDIPILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D70AF0", Offset = "0x7D6FCF0", VA = "0x187D70AF0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float PEIFLFOMAEE(int LEKFBFHACOF, int JMECEBEONNB, bool HOBGJJAGAAN, bool FABPKAGPIIB, float OJKFDPEDJEJ, float MNNOAPCIICA, float EAIFJHCIBJK, float LHNDOBHNKHB, float DJOMNBAMPLF, float AIFNJJPPIAE, float GGNLACJCGFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D705F0", Offset = "0x7D6F7F0", VA = "0x187D705F0")]
	[IgnoreWarning(1371)]
	private NKELIMHPPJG HHKMMLLIMEL([In] NKELIMHPPJG AGDAFHPJADO, int LFMBNIJFJLL, [In] NativeArray<int> LHKGABDCFKK, [In] NativeArray<bool> GBIHJMEDEKJ, NativeArray<int> JFNIMJGOGJA)
	{
		return default(NKELIMHPPJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D70910", Offset = "0x7D6FB10", VA = "0x187D70910")]
	public static int OJGPEMOBKMO(NativeArray<int> LHKGABDCFKK, NativeArray<int> EEBPFIIAKKG, int HJGMJKKGCMA, int DLCJDMCDAOL, int IKLCPJFBKBL)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		private struct MPFLHFONAFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public long CMJCMNFBFCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public DEJFKMDCDHJ FNDKJDJMBAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public IIGOFCLCLJP KHKMPBIDLPA;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EC00", Offset = "0x7D7DE00", VA = "0x187D7EC00")]
			public MPFLHFONAFP(DEJFKMDCDHJ OPLPOMCPAHM, IIGOFCLCLJP KHJCEOACMCB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class NNKOKMPIAFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public DEJFKMDCDHJ FNDKJDJMBAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int KLACLIDIDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public float FNICBBGAPAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public List<MPFLHFONAFP> CFEMJPGPPKM;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F270", Offset = "0x7D7E470", VA = "0x187D7F270")]
			public NNKOKMPIAFO(DEJFKMDCDHJ OPLPOMCPAHM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static readonly ProfilerMarker DONPNMPCNNI;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private static readonly ProfilerMarker MIIAHHEMFEF;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private static readonly ProfilerMarker EJFEKOADHKJ;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private static readonly ProfilerMarker AKNKPOEOLMH;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private static readonly ProfilerMarker PMIFMGBPEMP;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly ProfilerMarker OBNJNBHLOGJ;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker HJMKGPIAPOF;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		internal const int ODACAIJKOIJ = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		internal static Dictionary<Material, List<Material>> NNHABNIPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Dictionary<Material, List<OEBOMGFEEJJ>> BJGKCLJHEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		internal List<OEBOMGFEEJJ> IOBPJPDNHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private List<MeshRenderer> PBFAFLEOMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private Transform BOIECFFPLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool AIDELHJINDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool IOLFAOBEBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int CKBGGLIELJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private OEBOMGFEEJJ GLLEIKBAAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private Material OKENFDFLONE;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static bool? MNBALEIPIPF;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private const int ECCEJOOMLMF = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static List<MPFLHFONAFP> LKGLIGFIJKH;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> ILPLPLAEEPA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int MLMDCFBLPOG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7D78090", Offset = "0x7D77290", VA = "0x187D78090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool JOBMAJBHMBM
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7D72070", Offset = "0x7D71270", VA = "0x187D72070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private static void BAIKPKDJIBC(bool LPGJGNGIGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private static void BAIKPKDJIBC(bool LPGJGNGIGGC, string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private static void ONABLMLMNFN(string DGIAFBEDPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D71CE0", Offset = "0x7D70EE0", VA = "0x187D71CE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D73F70", Offset = "0x7D73170", VA = "0x187D73F70")]
		internal bool INMHEIBMPFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D72190", Offset = "0x7D71390", VA = "0x187D72190")]
		private Transform DOBIHCFEMKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D74AF0", Offset = "0x7D73CF0", VA = "0x187D74AF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D72210", Offset = "0x7D71410", VA = "0x187D72210", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D71AD0", Offset = "0x7D70CD0", VA = "0x187D71AD0")]
		public OEBOMGFEEJJ AddToBatchedMesh(IIGOFCLCLJP CHDLCBDKNBB, Material OHHEKLKCMJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D77B70", Offset = "0x7D76D70", VA = "0x187D77B70")]
		public void RemoveFromBatchedMesh(IIGOFCLCLJP KHKMPBIDLPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D71F40", Offset = "0x7D71140", VA = "0x187D71F40")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D74050", Offset = "0x7D73250", VA = "0x187D74050")]
		private void LLMIAFEHBEH(Renderer JFBIEOOKIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D73FE0", Offset = "0x7D731E0", VA = "0x187D73FE0")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D73FD0", Offset = "0x7D731D0", VA = "0x187D73FD0")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D72620", Offset = "0x7D71820", VA = "0x187D72620")]
		private void EPMAAGHDJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D74230", Offset = "0x7D73430", VA = "0x187D74230")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D74860", Offset = "0x7D73A60", VA = "0x187D74860")]
		private OEBOMGFEEJJ OKPABOFNKFI(IIGOFCLCLJP KHKMPBIDLPA, Material OHHEKLKCMJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D72BE0", Offset = "0x7D71DE0", VA = "0x187D72BE0")]
		private OEBOMGFEEJJ GMPKOFPMOHI(Material OHHEKLKCMJA, int MNFHBLEFMKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D73720", Offset = "0x7D72920", VA = "0x187D73720")]
		private OEBOMGFEEJJ IDOPNDCOCAE(Material OHHEKLKCMJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D747C0", Offset = "0x7D739C0", VA = "0x187D747C0")]
		internal float4x4 NJLHPGBGOEE()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D72F40", Offset = "0x7D72140", VA = "0x187D72F40")]
		public static List<Material> GenerateVertexFormatVariants(Material OHHEKLKCMJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x133D6C0", Offset = "0x133C8C0", VA = "0x18133D6C0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D740D0", Offset = "0x7D732D0", VA = "0x187D740D0")]
		public void MarkDirty(IIGOFCLCLJP KHKMPBIDLPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D71D10", Offset = "0x7D70F10", VA = "0x187D71D10")]
		[Conditional("CHECK_STATE")]
		private void BOPBNLEJENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D743B0", Offset = "0x7D735B0", VA = "0x187D743B0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float BGPBLOFDFJB)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D71E10", Offset = "0x7D71010", VA = "0x187D71E10")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D76A10", Offset = "0x7D75C10", VA = "0x187D76A10")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D73060", Offset = "0x7D72260", VA = "0x187D73060")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D74BD0", Offset = "0x7D73DD0", VA = "0x187D74BD0")]
		public void RebatchOptimally(int KCCMCKIIFKA, int DJACKFHOENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D74B00", Offset = "0x7D73D00", VA = "0x187D74B00")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D77F60", Offset = "0x7D77160", VA = "0x187D77F60")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class DPKIMMPFNLB
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct LPCJGIJCDEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public BatchedMeshRenderer JFBIEOOKIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public OEBOMGFEEJJ KHKMPBIDLPA;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1A13870", Offset = "0x1A12A70", VA = "0x181A13870")]
		public void AFMJLNCBIGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct BEKOCKEDEPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public float OFACDBFHMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public OEBOMGFEEJJ IEINOBOLMAA;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class DNLGODJGHCM : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x113F3B0", Offset = "0x113E5B0", VA = "0x18113F3B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x7D790E0", Offset = "0x7D782E0", VA = "0x187D790E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x12ABCE0", Offset = "0x12AAEE0", VA = "0x1812ABCE0")]
		[DebuggerHidden]
		public DNLGODJGHCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7D79130", Offset = "0x7D78330", VA = "0x187D79130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7D78180", Offset = "0x7D77380", VA = "0x187D78180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7D780E0", Offset = "0x7D772E0", VA = "0x187D780E0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7D78130", Offset = "0x7D77330", VA = "0x187D78130")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7D79090", Offset = "0x7D78290", VA = "0x187D79090", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7D78FE0", Offset = "0x7D781E0", VA = "0x187D78FE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7D78FE0", Offset = "0x7D781E0", VA = "0x187D78FE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private static readonly ProfilerMarker OBNJNBHLOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly ProfilerMarker NBMKJEAAFMN;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly ProfilerMarker AOLIOICEMNN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly ProfilerMarker ODHLHOIOGOM;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float3 CCLNEBGHKJD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static int FHGHEOAMECK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static int JHGAEJHELAD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static int LOHOBEINEDP;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static int PBMIBEGIDEH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int FEMBECFMBGN;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float GAOOOEILJNH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static float GJFOLGFMJAC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static float AAGBNKNJPBE;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static float CMBPNIGCGDI;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static float PGFIJIFLAEH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static float LGAIHKGFEAI;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static float BNPMFDDKIKP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static float OOAMHFOFAAN;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static List<BatchedMeshRenderer> MKNFOLMONIP;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static Stack<PBKMGPOLEJF> FAFCJLLNFGL;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static Stack<OIMMFGPJGMB> LGMEAJJHGBF;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static DNOHAGJNPAP GHBBKLJANGP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static LPCJGIJCDEJ JGAGECHPCMP;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int EBOOBECHDFJ;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void BAIKPKDJIBC(bool LPGJGNGIGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void HHOMMOLMKNB(bool LPGJGNGIGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void BAIKPKDJIBC(bool LPGJGNGIGGC, string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B170", Offset = "0x7D7A370", VA = "0x187D7B170")]
	public static void MNFKMEBPDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ACB0", Offset = "0x7D79EB0", VA = "0x187D7ACB0")]
	public static void JKGGDCLJOLK(BatchedMeshRenderer HKBDDPBCDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B360", Offset = "0x7D7A560", VA = "0x187D7B360")]
	public static void NBJLPABBKJD(BatchedMeshRenderer HKBDDPBCDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D79590", Offset = "0x7D78790", VA = "0x187D79590")]
	public static void GJFOCAIBLLC(IIGOFCLCLJP OEELNEFFBOG, bool CCJLPMNMPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ADF0", Offset = "0x7D79FF0", VA = "0x187D7ADF0")]
	public static void KAFBPPFFGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B950", Offset = "0x7D7AB50", VA = "0x187D7B950")]
	public static void PENOPKJHMOO(float BGPBLOFDFJB, bool JFEMDNFNKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B480", Offset = "0x7D7A680", VA = "0x187D7B480")]
	private static void PDDGNGLFKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A310", Offset = "0x7D79510", VA = "0x187D7A310")]
	public static long JJIODFEADCP(int FFJPIAPKCON, long BAAAIMNNJKG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D79380", Offset = "0x7D78580", VA = "0x187D79380")]
	public static (long, long, int) CCADKHGOIKP(float BGPBLOFDFJB)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A280", Offset = "0x7D79480", VA = "0x187D7A280")]
	[IteratorStateMachine(typeof(DNLGODJGHCM))]
	public static IEnumerable<bool> IHEDDPHLDIF(long POHPMPDOMFC, bool LJEACLMOKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D79DE0", Offset = "0x7D78FE0", VA = "0x187D79DE0")]
	public static void HBEFONICALN(long POHPMPDOMFC, bool LJEACLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B1F0", Offset = "0x7D7A3F0", VA = "0x187D7B1F0")]
	public static int MPKNOKMILOG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C260", Offset = "0x7D7B460", VA = "0x187D7C260")]
	internal static PBKMGPOLEJF PHBOHFNBCPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D792E0", Offset = "0x7D784E0", VA = "0x187D792E0")]
	internal static void BEDCDMAPMEL(PBKMGPOLEJF PIMHJJNGCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C3E0", Offset = "0x7D7B5E0", VA = "0x187D7C3E0")]
	internal static OIMMFGPJGMB POPKKDGFBNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7D79250", Offset = "0x7D78450", VA = "0x187D79250")]
	internal static void BEDCDMAPMEL(OIMMFGPJGMB BKEAAGHBHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A0C0", Offset = "0x7D792C0", VA = "0x187D7A0C0")]
	public static void ICDGNLCFFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class DNDOMDOGFGI<KeyType> : OEBOMGFEEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly Dictionary<KeyType, IIGOFCLCLJP> HABCHIPODBL;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DCC0", Offset = "0x6A2CEC0", VA = "0x186A2DCC0")]
	public DNDOMDOGFGI(string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D9B0", Offset = "0x6A2CBB0", VA = "0x186A2D9B0")]
	public void MBHPLCKMKIG(KeyType AGBHGDFILGO, IIGOFCLCLJP OEELNEFFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D7D0", Offset = "0x6A2C9D0", VA = "0x186A2D7D0")]
	public bool FJOBDCKNCPC(KeyType AGBHGDFILGO, IIGOFCLCLJP IGINMLKOJIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DA20", Offset = "0x6A2CC20", VA = "0x186A2DA20")]
	public void ONNJDBPKODP(KeyType AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D770", Offset = "0x6A2C970", VA = "0x186A2D770", Slot = "4")]
	public override void BLMHPCABDCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class GHBGINFMLHP
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly ProfilerCategory GJEPGIHDMDL;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	internal static readonly ProfilerMarker DDCBDCCLHFA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	internal static readonly AGIHOIBAMMI PENOPKJHMOO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly PLILLHCLCLK<float> MCLOKNADJIN;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly PLILLHCLCLK<float> ALJPMLKJGPI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly PLILLHCLCLK<double> HMJFKPPNBPJ;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly PLILLHCLCLK<double> IKDNKBAOKIF;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly PLILLHCLCLK<double> KAENJJGFEJB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly PLILLHCLCLK<int> DFPNFOEANDF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly PLILLHCLCLK<int> KOFGPHBOGCN;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly PLILLHCLCLK<int> FGLENCMAAPG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly PLILLHCLCLK<int> ODJEKNEELNN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly PLILLHCLCLK<int> FMDJALABAIH;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly PLILLHCLCLK<long> ELIJHOHJJBD;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly PLILLHCLCLK<long> LNOKFNCOJBL;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private static readonly PLILLHCLCLK<long> EKHLGKGGDKM;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly PLILLHCLCLK<long> LHOLNDLHNIC;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private static readonly PLILLHCLCLK<long> GLOBDLHLGOL;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CF90", Offset = "0x7D7C190", VA = "0x187D7CF90")]
	public static void JACPEADGEOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F810", Offset = "0x7D7EA10", VA = "0x187D7F810")]
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
