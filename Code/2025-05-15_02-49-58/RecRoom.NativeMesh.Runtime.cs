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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CC76A0", Offset = "0x7CC5CA0", VA = "0x187CC76A0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BPONDKNPCJL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly JBBHIJHGEPM FOIICFHFICP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly JBBHIJHGEPM FGEAAOCILHA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly JBBHIJHGEPM NFGBNIPEAGE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly JBBHIJHGEPM CHFDHCGPMDO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly JBBHIJHGEPM CAPFCIFKKAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class MCBEKGNCHGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public DJEOHGJJNMK AMDHAEEMHLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NPGNODKKKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MCBEKGNCHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct DJEOHGJJNMK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IIBAEONOJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half AFBCLBMPLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort ODLAHGJHNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte EPELPDGCMGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void JCHIOHHIHCI([NoAlias] float3* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class JKOEOKLLAFK
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3DA0", Offset = "0x7CC23A0", VA = "0x187CC3DA0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3EC0", Offset = "0x7CC24C0", VA = "0x187CC3EC0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3D00", Offset = "0x7CC2300", VA = "0x187CC3D00")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3AE0", Offset = "0x7CC20E0", VA = "0x187CC3AE0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] float3* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void AFAPLAOKPEJ([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class BFCEPEPANAC
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CB14D0", Offset = "0x7CAFAD0", VA = "0x187CB14D0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CB15F0", Offset = "0x7CAFBF0", VA = "0x187CB15F0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1430", Offset = "0x7CAFA30", VA = "0x187CB1430")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1190", Offset = "0x7CAF790", VA = "0x187CB1190")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void PPGMPOCEDEH([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class GGINJFAGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0C00", Offset = "0x7CBF200", VA = "0x187CC0C00")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0D20", Offset = "0x7CBF320", VA = "0x187CC0D20")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0B60", Offset = "0x7CBF160", VA = "0x187CC0B60")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7CC08C0", Offset = "0x7CBEEC0", VA = "0x187CC08C0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void HNCOLKGAPML([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class JPJLNKMMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4450", Offset = "0x7CC2A50", VA = "0x187CC4450")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4570", Offset = "0x7CC2B70", VA = "0x187CC4570")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7CC43B0", Offset = "0x7CC29B0", VA = "0x187CC43B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4110", Offset = "0x7CC2710", VA = "0x187CC4110")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void LFHGLMBFDDK([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class CHNBMJAFIOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB31C0", Offset = "0x7CB17C0", VA = "0x187CB31C0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB32E0", Offset = "0x7CB18E0", VA = "0x187CB32E0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3120", Offset = "0x7CB1720", VA = "0x187CB3120")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2E80", Offset = "0x7CB1480", VA = "0x187CB2E80")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void IMMLFBCIOFJ([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class COAGCGFJHIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3800", Offset = "0x7CB1E00", VA = "0x187CB3800")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3920", Offset = "0x7CB1F20", VA = "0x187CB3920")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3760", Offset = "0x7CB1D60", VA = "0x187CB3760")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3430", Offset = "0x7CB1A30", VA = "0x187CB3430")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void HKBIBPPDOIJ([NoAlias] ushort* KNGCHPLNGDO, [Out] float3 KOLNFJMEMBO, [Out] float3 MGAEOBKBLOA, [In][NoAlias] float3* HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class BKMBOJLIOPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1A10", Offset = "0x7CB0010", VA = "0x187CB1A10")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1B30", Offset = "0x7CB0130", VA = "0x187CB1B30")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1970", Offset = "0x7CAFF70", VA = "0x187CB1970")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1740", Offset = "0x7CAFD40", VA = "0x187CB1740")]
		public unsafe static void CIBKKMOJDEC([NoAlias] ushort* KNGCHPLNGDO, [Out] float3 KOLNFJMEMBO, [Out] float3 MGAEOBKBLOA, [In][NoAlias] float3* HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void DGIJDGDPDMF([NoAlias] ushort* HKJFMLGKOLE, [In][NoAlias] float3* LAEKEEAOFLB, int FNBPJBGCLCH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class NEOGEIAGNIP
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8D30", Offset = "0x7CC7330", VA = "0x187CC8D30")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8E50", Offset = "0x7CC7450", VA = "0x187CC8E50")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8C90", Offset = "0x7CC7290", VA = "0x187CC8C90")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8A90", Offset = "0x7CC7090", VA = "0x187CC8A90")]
		public unsafe static void CIBKKMOJDEC([NoAlias] ushort* HKJFMLGKOLE, [In][NoAlias] float3* LAEKEEAOFLB, int FNBPJBGCLCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void EHNHMAOBFBC([NoAlias] float3* HNJEFMCIMOB, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class GIGGKGPFLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1110", Offset = "0x7CBF710", VA = "0x187CC1110")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1230", Offset = "0x7CBF830", VA = "0x187CC1230")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1070", Offset = "0x7CBF670", VA = "0x187CC1070")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0E70", Offset = "0x7CBF470", VA = "0x187CC0E70")]
		public unsafe static void CIBKKMOJDEC([NoAlias] float3* HNJEFMCIMOB, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void DGCGOMODGJF([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class HJNCBFBALOA
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2250", Offset = "0x7CC0850", VA = "0x187CC2250")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2370", Offset = "0x7CC0970", VA = "0x187CC2370")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC21B0", Offset = "0x7CC07B0", VA = "0x187CC21B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1FB0", Offset = "0x7CC05B0", VA = "0x187CC1FB0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void JDJDEABLHBF([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class MMELEDAKJAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8820", Offset = "0x7CC6E20", VA = "0x187CC8820")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8940", Offset = "0x7CC6F40", VA = "0x187CC8940")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8780", Offset = "0x7CC6D80", VA = "0x187CC8780")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8490", Offset = "0x7CC6A90", VA = "0x187CC8490")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void KOBENDFCOBF([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class HHHJGBKALCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1D40", Offset = "0x7CC0340", VA = "0x187CC1D40")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1E60", Offset = "0x7CC0460", VA = "0x187CC1E60")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1CA0", Offset = "0x7CC02A0", VA = "0x187CC1CA0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC19B0", Offset = "0x7CBFFB0", VA = "0x187CC19B0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void HKOOKDDEBMD([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class LOOCDLOKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7430", Offset = "0x7CC5A30", VA = "0x187CC7430")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7550", Offset = "0x7CC5B50", VA = "0x187CC7550")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7390", Offset = "0x7CC5990", VA = "0x187CC7390")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7070", Offset = "0x7CC5670", VA = "0x187CC7070")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void JLKOHHAJFGF([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class LMNONCDNING
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6E00", Offset = "0x7CC5400", VA = "0x187CC6E00")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6F20", Offset = "0x7CC5520", VA = "0x187CC6F20")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6D60", Offset = "0x7CC5360", VA = "0x187CC6D60")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6A40", Offset = "0x7CC5040", VA = "0x187CC6A40")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void IHIOKHGLAOD([NoAlias] uint* DDCFGONKIJI, [Out] float2 MMNICFBIKLM, [Out] float2 KPNAELOMDEE, [In][NoAlias] float2* DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class BMFDAAKBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1F50", Offset = "0x7CB0550", VA = "0x187CB1F50")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2070", Offset = "0x7CB0670", VA = "0x187CB2070")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1EB0", Offset = "0x7CB04B0", VA = "0x187CB1EB0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1C80", Offset = "0x7CB0280", VA = "0x187CB1C80")]
		public unsafe static void CIBKKMOJDEC([NoAlias] uint* DDCFGONKIJI, [Out] float2 MMNICFBIKLM, [Out] float2 KPNAELOMDEE, [In][NoAlias] float2* DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void JOEICKOODPH([Out] float2 AJAKAPDAHBO, uint OBECJEJKMCP, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class MIHHJPEHMGE
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7CC0", Offset = "0x7CC62C0", VA = "0x187CC7CC0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7DE0", Offset = "0x7CC63E0", VA = "0x187CC7DE0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7C20", Offset = "0x7CC6220", VA = "0x187CC7C20")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC79D0", Offset = "0x7CC5FD0", VA = "0x187CC79D0")]
		public static void CIBKKMOJDEC([Out] float2 AJAKAPDAHBO, uint OBECJEJKMCP, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void FMFNBONFFGJ([NoAlias] float2* DDCFGONKIJI, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class LFNAFMAILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6110", Offset = "0x7CC4710", VA = "0x187CC6110")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6230", Offset = "0x7CC4830", VA = "0x187CC6230")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6070", Offset = "0x7CC4670", VA = "0x187CC6070")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5D90", Offset = "0x7CC4390", VA = "0x187CC5D90")]
		public unsafe static void CIBKKMOJDEC([NoAlias] float2* DDCFGONKIJI, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void ALDBKCILPMA([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class PEOIENEDLHC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CD1240", Offset = "0x7CCF840", VA = "0x187CD1240")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7CD1360", Offset = "0x7CCF960", VA = "0x187CD1360")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7CD11A0", Offset = "0x7CCF7A0", VA = "0x187CD11A0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0E80", Offset = "0x7CCF480", VA = "0x187CD0E80")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void PAPKKPCEOEO([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class BACPLDEGACB
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB08B0", Offset = "0x7CAEEB0", VA = "0x187CB08B0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CB09D0", Offset = "0x7CAEFD0", VA = "0x187CB09D0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0810", Offset = "0x7CAEE10", VA = "0x187CB0810")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7CB04F0", Offset = "0x7CAEAF0", VA = "0x187CB04F0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void PNPALILNMCI([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class FEOGFCIOHPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF500", Offset = "0x7CBDB00", VA = "0x187CBF500")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF620", Offset = "0x7CBDC20", VA = "0x187CBF620")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF460", Offset = "0x7CBDA60", VA = "0x187CBF460")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF240", Offset = "0x7CBD840", VA = "0x187CBF240")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void EPJDNMOGJAH([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class PNDJFLJBLLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD1860", Offset = "0x7CCFE60", VA = "0x187CD1860")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7CD1980", Offset = "0x7CCFF80", VA = "0x187CD1980")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7CD17C0", Offset = "0x7CCFDC0", VA = "0x187CD17C0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7CD14B0", Offset = "0x7CCFAB0", VA = "0x187CD14B0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void OJICPAEPNPJ([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class EPHFBFHMJDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE7E0", Offset = "0x7CBCDE0", VA = "0x187CBE7E0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE900", Offset = "0x7CBCF00", VA = "0x187CBE900")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE740", Offset = "0x7CBCD40", VA = "0x187CBE740")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE430", Offset = "0x7CBCA30", VA = "0x187CBE430")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void POGJEPFOBNK([NoAlias] ushort* JPGCMIDIDOP, [In][NoAlias] float4* CCEEBJLFJFK, int AHOMBPIDMCC, int FNBPJBGCLCH);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class IIPNKDAHENE
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2AB0", Offset = "0x7CC10B0", VA = "0x187CC2AB0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2BD0", Offset = "0x7CC11D0", VA = "0x187CC2BD0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2A10", Offset = "0x7CC1010", VA = "0x187CC2A10")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2780", Offset = "0x7CC0D80", VA = "0x187CC2780")]
		public unsafe static void CIBKKMOJDEC([NoAlias] ushort* JPGCMIDIDOP, [In][NoAlias] float4* CCEEBJLFJFK, int AHOMBPIDMCC, int FNBPJBGCLCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort DBJNKGPGMAG([In] float4 LLFBONBFGND);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class MLENGCOBKPK
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8220", Offset = "0x7CC6820", VA = "0x187CC8220")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8340", Offset = "0x7CC6940", VA = "0x187CC8340")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8180", Offset = "0x7CC6780", VA = "0x187CC8180")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7F30", Offset = "0x7CC6530", VA = "0x187CC7F30")]
		public static ushort CIBKKMOJDEC([In] float4 LLFBONBFGND)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void CPONGILIALH([NoAlias] float4* JPGCMIDIDOP, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class KFCLJJJIGMF
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC49F0", Offset = "0x7CC2FF0", VA = "0x187CC49F0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4B10", Offset = "0x7CC3110", VA = "0x187CC4B10")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4950", Offset = "0x7CC2F50", VA = "0x187CC4950")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7CC46C0", Offset = "0x7CC2CC0", VA = "0x187CC46C0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] float4* JPGCMIDIDOP, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void POHEBLOOALO([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class GENKMAAIMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0650", Offset = "0x7CBEC50", VA = "0x187CC0650")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0770", Offset = "0x7CBED70", VA = "0x187CC0770")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7CC05B0", Offset = "0x7CBEBB0", VA = "0x187CC05B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC03B0", Offset = "0x7CBE9B0", VA = "0x187CC03B0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void BIOLPCCAJLP([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class GKKKGNMJJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1740", Offset = "0x7CBFD40", VA = "0x187CC1740")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1860", Offset = "0x7CBFE60", VA = "0x187CC1860")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CC16A0", Offset = "0x7CBFCA0", VA = "0x187CC16A0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1380", Offset = "0x7CBF980", VA = "0x187CC1380")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void NHNMFPHIAMM([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class CBEANGBLIEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2C10", Offset = "0x7CB1210", VA = "0x187CB2C10")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2D30", Offset = "0x7CB1330", VA = "0x187CB2D30")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2B70", Offset = "0x7CB1170", VA = "0x187CB2B70")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2850", Offset = "0x7CB0E50", VA = "0x187CB2850")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void JDGJGFLKAFD([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class JHJHEDGPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC32D0", Offset = "0x7CC18D0", VA = "0x187CC32D0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7CC33F0", Offset = "0x7CC19F0", VA = "0x187CC33F0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3230", Offset = "0x7CC1830", VA = "0x187CC3230")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2EA0", Offset = "0x7CC14A0", VA = "0x187CC2EA0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void BAALPOIBJGD([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class COLICGDHOMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3EA0", Offset = "0x7CB24A0", VA = "0x187CB3EA0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3FC0", Offset = "0x7CB25C0", VA = "0x187CB3FC0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3E00", Offset = "0x7CB2400", VA = "0x187CB3E00")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3A70", Offset = "0x7CB2070", VA = "0x187CB3A70")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void ABKAEFMFFKK([Out] float4 OBOOAPELMPF, ushort OBECJEJKMCP);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class OCEJNIBJENP
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9D10", Offset = "0x7CC8310", VA = "0x187CC9D10")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9E30", Offset = "0x7CC8430", VA = "0x187CC9E30")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9C70", Offset = "0x7CC8270", VA = "0x187CC9C70")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7CC99E0", Offset = "0x7CC7FE0", VA = "0x187CC99E0")]
		public static void CIBKKMOJDEC([Out] float4 OBOOAPELMPF, ushort OBECJEJKMCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void FDFHFACJGGP([NoAlias] float4* CNINOIGOJEA, [NoAlias] byte* JJKOJNFOHOC, [Out] int AADEMPPBGIH, [Out] int HOGJPMLHDCP, [NoAlias] float4* EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class KGCOFMNPHHH
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4F30", Offset = "0x7CC3530", VA = "0x187CC4F30")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5050", Offset = "0x7CC3650", VA = "0x187CC5050")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4E90", Offset = "0x7CC3490", VA = "0x187CC4E90")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4C60", Offset = "0x7CC3260", VA = "0x187CC4C60")]
		public unsafe static void CIBKKMOJDEC([NoAlias] float4* CNINOIGOJEA, [NoAlias] byte* JJKOJNFOHOC, [Out] int AADEMPPBGIH, [Out] int HOGJPMLHDCP, [NoAlias] float4* EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void CAHLABOHMJC([NoAlias] float4* DOBCKFGCGOD, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class ANLJKAFNBEE
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0180", Offset = "0x7CAE780", VA = "0x187CB0180")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7CB02A0", Offset = "0x7CAE8A0", VA = "0x187CB02A0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7CB00E0", Offset = "0x7CAE6E0", VA = "0x187CB00E0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFDE0", Offset = "0x7CAE3E0", VA = "0x187CAFDE0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] float4* DOBCKFGCGOD, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void DHIDOBAPFCI([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class KPOAALPKGEB
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7CC55F0", Offset = "0x7CC3BF0", VA = "0x187CC55F0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5710", Offset = "0x7CC3D10", VA = "0x187CC5710")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5550", Offset = "0x7CC3B50", VA = "0x187CC5550")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC51A0", Offset = "0x7CC37A0", VA = "0x187CC51A0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void NEMPINJGGAO([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class FKNHHHLJNKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0140", Offset = "0x7CBE740", VA = "0x187CC0140")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0260", Offset = "0x7CBE860", VA = "0x187CC0260")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CC00A0", Offset = "0x7CBE6A0", VA = "0x187CC00A0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFCE0", Offset = "0x7CBE2E0", VA = "0x187CBFCE0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void CKNFONHJOCB([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class LIGHHEIFLDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7CC67D0", Offset = "0x7CC4DD0", VA = "0x187CC67D0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7CC68F0", Offset = "0x7CC4EF0", VA = "0x187CC68F0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6730", Offset = "0x7CC4D30", VA = "0x187CC6730")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6380", Offset = "0x7CC4980", VA = "0x187CC6380")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void NGLNHNJHODC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class NNCAFGDBKKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9260", Offset = "0x7CC7860", VA = "0x187CC9260")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9380", Offset = "0x7CC7980", VA = "0x187CC9380")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC91C0", Offset = "0x7CC77C0", VA = "0x187CC91C0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8FA0", Offset = "0x7CC75A0", VA = "0x187CC8FA0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void LMNODMLBKHI([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class LEIAOGABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5B20", Offset = "0x7CC4120", VA = "0x187CC5B20")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5C40", Offset = "0x7CC4240", VA = "0x187CC5C40")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5A80", Offset = "0x7CC4080", VA = "0x187CC5A80")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5860", Offset = "0x7CC3E60", VA = "0x187CC5860")]
		public unsafe static void CIBKKMOJDEC([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int BDGLJDFEFBD([NoAlias] byte* AADAHELMBIE, [In][NoAlias] int* LPLJFEEALKJ, int CHENFJALHID);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class JJGHKIOODLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3870", Offset = "0x7CC1E70", VA = "0x187CC3870")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3990", Offset = "0x7CC1F90", VA = "0x187CC3990")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CC37D0", Offset = "0x7CC1DD0", VA = "0x187CC37D0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3540", Offset = "0x7CC1B40", VA = "0x187CC3540")]
		public unsafe static int CIBKKMOJDEC([NoAlias] byte* AADAHELMBIE, [In][NoAlias] int* LPLJFEEALKJ, int CHENFJALHID)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void FMCOKIGNKEL([NoAlias] int* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class FKBJCMIMNEE
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFA70", Offset = "0x7CBE070", VA = "0x187CBFA70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB90", Offset = "0x7CBE190", VA = "0x187CBFB90")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF9D0", Offset = "0x7CBDFD0", VA = "0x187CBF9D0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF770", Offset = "0x7CBDD70", VA = "0x187CBF770")]
		public unsafe static void CIBKKMOJDEC([NoAlias] int* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void IHFNLALBGFF([NoAlias] ushort* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class FEEAAEDMCDA
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEFD0", Offset = "0x7CBD5D0", VA = "0x187CBEFD0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF0F0", Offset = "0x7CBD6F0", VA = "0x187CBF0F0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEF30", Offset = "0x7CBD530", VA = "0x187CBEF30")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBECD0", Offset = "0x7CBD2D0", VA = "0x187CBECD0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] ushort* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void DGBIOFGBDLK([Out] float3 AJAKAPDAHBO, ushort OBECJEJKMCP);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class NONGIHCBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9770", Offset = "0x7CC7D70", VA = "0x187CC9770")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC9890", Offset = "0x7CC7E90", VA = "0x187CC9890")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC96D0", Offset = "0x7CC7CD0", VA = "0x187CC96D0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CC94D0", Offset = "0x7CC7AD0", VA = "0x187CC94D0")]
		public static void CIBKKMOJDEC([Out] float3 AJAKAPDAHBO, ushort OBECJEJKMCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort HHJJEJEKCOE([In] float3 LLFBONBFGND);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class BNADMJBKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2450", Offset = "0x7CB0A50", VA = "0x187CB2450")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2570", Offset = "0x7CB0B70", VA = "0x187CB2570")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB23B0", Offset = "0x7CB09B0", VA = "0x187CB23B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB21C0", Offset = "0x7CB07C0", VA = "0x187CB21C0")]
		public static ushort CIBKKMOJDEC([In] float3 LLFBONBFGND)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker DCNNBFINLPA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker ABHHPNIKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int NPGNODKKKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int PCGPKCCHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> JKHPLKICGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> ADKCNGCNOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<IIBAEONOJDB> LGPLODMABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> PGPOJJJBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> HKHJDBHLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 NOOBOGHKKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 MGAEOBKBLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 JGNECBNGPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 KPNAELOMDEE;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long NKOOHKAEAIA;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long LGMPPFHDLKN;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float FNBLNLFPMNI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool OMLNLNIENHD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDAB0", Offset = "0x7CBC0B0", VA = "0x187CBDAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GMHDFKBMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC520", Offset = "0x7CBAB20", VA = "0x187CBC520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD270", Offset = "0x7CBB870", VA = "0x187CBD270")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7C40", Offset = "0x7CB6240", VA = "0x187CB7C40")]
	public static DJEOHGJJNMK FLLMCNLHKNL(Allocator NDFENJBGNOB, NativeArray<float3> HEIDAKDKJJN, NativeArray<float3> LAEKEEAOFLB, NativeArray<float2> DHFAOJAKFKM, NativeArray<float4> EEOILEIGJHB, bool CJAMNBEAIGN, NativeArray<float4> PMKPBIIHDMK, NativeArray<int> LPLJFEEALKJ, int NPGNODKKKAD, int KNJFBCCKPAH, int PCGPKCCHANN, int AHOMBPIDMCC)
	{
		return default(DJEOHGJJNMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5CE0", Offset = "0x7CB42E0", VA = "0x187CB5CE0")]
	public OFNFOCEBPOF CKONIBGAFNP(Allocator NDFENJBGNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5D80", Offset = "0x7CB4380", VA = "0x187CB5D80")]
	public void CKONIBGAFNP(OFNFOCEBPOF OBOOAPELMPF, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD550", Offset = "0x7CBBB50", VA = "0x187CBD550")]
	public void OCKMBDCILHB(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9B40", Offset = "0x7CB8140", VA = "0x187CB9B40")]
	private void HOPJLJOIFFB(Mesh PEPFHNJFNIL, NativeArray<ushort> BMPFHBCCNDN, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9560", Offset = "0x7CB7B60", VA = "0x187CB9560")]
	public void HNKLGDNLPMG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCC20", Offset = "0x7CBB220", VA = "0x187CBCC20")]
	public void NJLOGFHEPOF(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAF90", Offset = "0x7CB9590", VA = "0x187CBAF90")]
	public void JNFNGDFFFDD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5610", Offset = "0x7CB3C10", VA = "0x187CB5610")]
	public void CFFDNIDHOHG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CB82A0", Offset = "0x7CB68A0", VA = "0x187CB82A0")]
	public void GFKEJIBGGBD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAAA0", Offset = "0x7CB90A0", VA = "0x187CBAAA0")]
	public void JIMECJHBEFE(Mesh PEPFHNJFNIL, OFNFOCEBPOF.LEBCKMKDBPC CKHLMMECGLE, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CB81E0", Offset = "0x7CB67E0", VA = "0x187CB81E0")]
	public long GEBEHCBKDIL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7B60", Offset = "0x7CB6160", VA = "0x187CB7B60")]
	public long ENNKELIOCBP(OFNFOCEBPOF.LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB7B0", Offset = "0x7CB9DB0", VA = "0x187CBB7B0")]
	private void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB, bool KLNAIMNEAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA6D0", Offset = "0x7CB8CD0", VA = "0x187CBA6D0")]
	private void INACKDOCFDM(NativeArray<float3> KNGCHPLNGDO, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA650", Offset = "0x7CB8C50", VA = "0x187CBA650")]
	[BurstCompile]
	private unsafe static void INACKDOCFDM([NoAlias] float3* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA090", Offset = "0x7CB8690", VA = "0x187CBA090")]
	[BurstCompile]
	private unsafe static void IDLANHJKOGF([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4E60", Offset = "0x7CB3460", VA = "0x187CB4E60")]
	[BurstCompile]
	private unsafe static void BGFAENANGCF([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB93B0", Offset = "0x7CB79B0", VA = "0x187CB93B0")]
	[BurstCompile]
	private unsafe static void HLMMDLHKLCA([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBF50", Offset = "0x7CBA550", VA = "0x187CBBF50")]
	[BurstCompile]
	private unsafe static void LOGGGJHHHMA([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB8E0", Offset = "0x7CB9EE0", VA = "0x187CBB8E0")]
	[BurstCompile]
	private unsafe static void KNGHMFBEOFF([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CB79B0", Offset = "0x7CB5FB0", VA = "0x187CB79B0")]
	private void EMPJGAAANAB(NativeArray<float3> HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7AD0", Offset = "0x7CB60D0", VA = "0x187CB7AD0")]
	[BurstCompile]
	private unsafe static void EMPJGAAANAB([NoAlias] ushort* KNGCHPLNGDO, [Out] float3 KOLNFJMEMBO, [Out] float3 MGAEOBKBLOA, [In][NoAlias] float3* HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9D70", Offset = "0x7CB8370", VA = "0x187CB9D70")]
	private void IDGCBGAHDBH(NativeArray<float3> LAEKEEAOFLB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9E50", Offset = "0x7CB8450", VA = "0x187CB9E50")]
	[BurstCompile]
	private unsafe static void IDGCBGAHDBH([NoAlias] ushort* HKJFMLGKOLE, [In][NoAlias] float3* LAEKEEAOFLB, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA110", Offset = "0x7CB8710", VA = "0x187CBA110")]
	private void IDNDCPFMKIJ(NativeArray<float3> HNJEFMCIMOB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA1D0", Offset = "0x7CB87D0", VA = "0x187CBA1D0")]
	[BurstCompile]
	private unsafe static void IDNDCPFMKIJ([NoAlias] float3* HNJEFMCIMOB, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CB64B0", Offset = "0x7CB4AB0", VA = "0x187CB64B0")]
	[BurstCompile]
	private unsafe static void CNCGPGJAJDK([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB5E0", Offset = "0x7CB9BE0", VA = "0x187CBB5E0")]
	[BurstCompile]
	private unsafe static void KCOFNJCDICC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8CA0", Offset = "0x7CB72A0", VA = "0x187CB8CA0")]
	[BurstCompile]
	private unsafe static void GNLHEABEFEP([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5380", Offset = "0x7CB3980", VA = "0x187CB5380")]
	[BurstCompile]
	private unsafe static void BOHGOKKFEKA([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB90A0", Offset = "0x7CB76A0", VA = "0x187CB90A0")]
	[BurstCompile]
	private unsafe static void HJJMKNJMKOJ([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4540", Offset = "0x7CB2B40", VA = "0x187CB4540")]
	private void AEBLBDONNEJ(NativeArray<float2> DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4660", Offset = "0x7CB2C60", VA = "0x187CB4660")]
	[BurstCompile]
	private unsafe static void AEBLBDONNEJ([NoAlias] uint* DDCFGONKIJI, [Out] float2 MMNICFBIKLM, [Out] float2 KPNAELOMDEE, [In][NoAlias] float2* DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5C60", Offset = "0x7CB4260", VA = "0x187CB5C60")]
	[BurstCompile]
	private static void CKNBHCNMBPD([Out] float2 AJAKAPDAHBO, uint OBECJEJKMCP, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB53F0", Offset = "0x7CB39F0", VA = "0x187CB53F0")]
	private void BPGAOJJINOC(NativeArray<float2> DDCFGONKIJI, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5510", Offset = "0x7CB3B10", VA = "0x187CB5510")]
	[BurstCompile]
	private unsafe static void BPGAOJJINOC([NoAlias] float2* DDCFGONKIJI, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7930", Offset = "0x7CB5F30", VA = "0x187CB7930")]
	[BurstCompile]
	private unsafe static void ELMAAIBGLDM([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBED0", Offset = "0x7CBA4D0", VA = "0x187CBBED0")]
	[BurstCompile]
	private unsafe static void LNEBLKFLFFG([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6140", Offset = "0x7CB4740", VA = "0x187CB6140")]
	[BurstCompile]
	private unsafe static void CLNGCPDDJML([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8160", Offset = "0x7CB6760", VA = "0x187CB8160")]
	[BurstCompile]
	private unsafe static void GDNJDNPBJKM([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4AC0", Offset = "0x7CB30C0", VA = "0x187CB4AC0")]
	[BurstCompile]
	private unsafe static void BBBPPCMILML([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC050", Offset = "0x7CBA650", VA = "0x187CBC050")]
	private void MCFLALHDPGL(NativeArray<float4> PMKPBIIHDMK, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBFD0", Offset = "0x7CBA5D0", VA = "0x187CBBFD0")]
	[BurstCompile]
	private unsafe static void MCFLALHDPGL([NoAlias] ushort* JPGCMIDIDOP, [In][NoAlias] float4* CCEEBJLFJFK, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD6E0", Offset = "0x7CBBCE0", VA = "0x187CBD6E0")]
	[BurstCompile]
	private static ushort OKADHLJPEOC([In] float4 LLFBONBFGND)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC1D0", Offset = "0x7CBA7D0", VA = "0x187CBC1D0")]
	private void MGBLODILHJB(NativeArray<float4> JPGCMIDIDOP, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC160", Offset = "0x7CBA760", VA = "0x187CBC160")]
	[BurstCompile]
	private unsafe static void MGBLODILHJB([NoAlias] float4* JPGCMIDIDOP, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA410", Offset = "0x7CB8A10", VA = "0x187CBA410")]
	[BurstCompile]
	private unsafe static void IIKNEJBFMKB([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9030", Offset = "0x7CB7630", VA = "0x187CB9030")]
	[BurstCompile]
	private unsafe static void HIGLCOMKGAE([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8D10", Offset = "0x7CB7310", VA = "0x187CB8D10")]
	[BurstCompile]
	private unsafe static void GPDAPCFMCGC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC9E0", Offset = "0x7CBAFE0", VA = "0x187CBC9E0")]
	[BurstCompile]
	private unsafe static void NEAMMLHKOGP([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7BD0", Offset = "0x7CB61D0", VA = "0x187CB7BD0")]
	[BurstCompile]
	private unsafe static void FEDKIMEMMFG([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8100", Offset = "0x7CB6700", VA = "0x187CB8100")]
	[BurstCompile]
	private static void FOLJFECKMBD([Out] float4 OBOOAPELMPF, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6BC0", Offset = "0x7CB51C0", VA = "0x187CB6BC0")]
	private void EAPHBFJALLF(Allocator NDFENJBGNOB, NativeArray<float4> EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7000", Offset = "0x7CB5600", VA = "0x187CB7000")]
	[BurstCompile]
	private unsafe static void EAPHBFJALLF([NoAlias] float4* CNINOIGOJEA, [NoAlias] byte* JJKOJNFOHOC, [Out] int AADEMPPBGIH, [Out] int HOGJPMLHDCP, [NoAlias] float4* EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CB88B0", Offset = "0x7CB6EB0", VA = "0x187CB88B0")]
	private static void GHCOJDAIABL(NativeArray<float4> DOBCKFGCGOD, NativeArray<IIBAEONOJDB> GNKPENKMHAG, NativeArray<byte> DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CB89E0", Offset = "0x7CB6FE0", VA = "0x187CB89E0")]
	[BurstCompile]
	private unsafe static void GHCOJDAIABL([NoAlias] float4* DOBCKFGCGOD, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4A40", Offset = "0x7CB3040", VA = "0x187CB4A40")]
	[BurstCompile]
	private unsafe static void APCALNGNPOI([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5590", Offset = "0x7CB3B90", VA = "0x187CB5590")]
	[BurstCompile]
	private unsafe static void CCIDHCPHKJL([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4210", Offset = "0x7CB2810", VA = "0x187CB4210")]
	[BurstCompile]
	private unsafe static void AACMFGDKEEA([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC2C0", Offset = "0x7CBA8C0", VA = "0x187CBC2C0")]
	[BurstCompile]
	private unsafe static void MIPJKNNCCIE([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7510", Offset = "0x7CB5B10", VA = "0x187CB7510")]
	[BurstCompile]
	private unsafe static void EIJCGFPFCLD([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD390", Offset = "0x7CBB990", VA = "0x187CBD390")]
	private void OBINMAJDECA(Allocator NDFENJBGNOB, NativeArray<int> LPLJFEEALKJ, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBB90", Offset = "0x7CBA190", VA = "0x187CBBB90")]
	private static NativeArray<byte> LJJAKCFGIGD(Allocator NDFENJBGNOB, NativeArray<int> LPLJFEEALKJ, int CHENFJALHID)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBE60", Offset = "0x7CBA460", VA = "0x187CBBE60")]
	[BurstCompile]
	private unsafe static int LJJAKCFGIGD([NoAlias] byte* AADAHELMBIE, [In][NoAlias] int* LPLJFEEALKJ, int CHENFJALHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4F50", Offset = "0x7CB3550", VA = "0x187CB4F50")]
	private static void BHAKOJOCOLC(NativeArray<int> OFBNPEEKAOM, NativeArray<byte> LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4EE0", Offset = "0x7CB34E0", VA = "0x187CB4EE0")]
	[BurstCompile]
	private unsafe static void BHAKOJOCOLC([NoAlias] int* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD670", Offset = "0x7CBBC70", VA = "0x187CBD670")]
	[BurstCompile]
	private unsafe static void OFCEBDJPHKH([NoAlias] ushort* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC560", Offset = "0x7CBAB60", VA = "0x187CBC560")]
	[BurstCompile]
	private static void MOMIIKBIIEJ([Out] float3 AJAKAPDAHBO, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA7F0", Offset = "0x7CB8DF0", VA = "0x187CBA7F0")]
	[BurstCompile]
	private static ushort INAGKMKHBOI([In] float3 LLFBONBFGND)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC6A0", VA = "0x187CAE0A0")]
	[BurstCompile]
	public unsafe static void CPAEOCEBILD([NoAlias] float3* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7870", Offset = "0x7CB5E70", VA = "0x187CB7870")]
	[BurstCompile]
	public unsafe static void ELIBHODLIMN([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD490", Offset = "0x7CBBA90", VA = "0x187CBD490")]
	[BurstCompile]
	public unsafe static void OBKAOFGKHPJ([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBAD0", Offset = "0x7CBA0D0", VA = "0x187CBBAD0")]
	[BurstCompile]
	public unsafe static void LJFJKNGAPBF([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBAD0", Offset = "0x7CBA0D0", VA = "0x187CBBAD0")]
	[BurstCompile]
	public unsafe static void NPDNEGDGNKF([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB650", Offset = "0x7CB9C50", VA = "0x187CBB650")]
	[BurstCompile]
	public unsafe static void KGGFEHNLFMP([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CADCC0", Offset = "0x7CAC2C0", VA = "0x187CADCC0")]
	[BurstCompile]
	public unsafe static void CNHDFAKKEOO([NoAlias] ushort* KNGCHPLNGDO, [Out] float3 KOLNFJMEMBO, [Out] float3 MGAEOBKBLOA, [In][NoAlias] float3* HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5040", Offset = "0x7CB3640", VA = "0x187CB5040")]
	[BurstCompile]
	public unsafe static void BNJBFLGDJOD([NoAlias] ushort* HKJFMLGKOLE, [In][NoAlias] float3* LAEKEEAOFLB, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9110", Offset = "0x7CB7710", VA = "0x187CB9110")]
	[BurstCompile]
	public unsafe static void HLJDMGKOGLL([NoAlias] float3* HNJEFMCIMOB, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC790", Offset = "0x7CBAD90", VA = "0x187CBC790")]
	[BurstCompile]
	public unsafe static void NDPJJEBHLMM([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7200", Offset = "0x7CB5800", VA = "0x187CB7200")]
	[BurstCompile]
	public unsafe static void EBIFIKCGCPJ([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD970", Offset = "0x7CBBF70", VA = "0x187CBD970")]
	[BurstCompile]
	public unsafe static void PMBLPIEBDHI([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6830", Offset = "0x7CB4E30", VA = "0x187CB6830")]
	[BurstCompile]
	public unsafe static void DIBKADMLLGD([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7090", Offset = "0x7CB5690", VA = "0x187CB7090")]
	[BurstCompile]
	public unsafe static void EBDIIFFFKGJ([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEFB0", Offset = "0x7CAD5B0", VA = "0x187CAEFB0")]
	[BurstCompile]
	public unsafe static void NJMFAPCMJAE([NoAlias] uint* DDCFGONKIJI, [Out] float2 MMNICFBIKLM, [Out] float2 KPNAELOMDEE, [In][NoAlias] float2* DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5C20", Offset = "0x7CB4220", VA = "0x187CB5C20")]
	[BurstCompile]
	public static void CKJFGEANCPN([Out] float2 AJAKAPDAHBO, uint OBECJEJKMCP, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCB10", Offset = "0x7CBB110", VA = "0x187CBCB10")]
	[BurstCompile]
	public unsafe static void NHBFAFJCPEL([NoAlias] float2* DDCFGONKIJI, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDAF0", Offset = "0x7CBC0F0", VA = "0x187CBDAF0")]
	[BurstCompile]
	public unsafe static void POEHLEJKDAA([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CB66F0", Offset = "0x7CB4CF0", VA = "0x187CB66F0")]
	[BurstCompile]
	public unsafe static void COPBADCNAIC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CB69A0", Offset = "0x7CB4FA0", VA = "0x187CB69A0")]
	[BurstCompile]
	public unsafe static void EAGNHPHMNOC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8F00", Offset = "0x7CB7500", VA = "0x187CB8F00")]
	[BurstCompile]
	public unsafe static void HHOBPPHHNAO([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9430", Offset = "0x7CB7A30", VA = "0x187CB9430")]
	[BurstCompile]
	public unsafe static void HLNFFAPGLJM([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8E20", Offset = "0x7CB7420", VA = "0x187CB8E20")]
	[BurstCompile]
	public unsafe static void HFJFMANGLIH([NoAlias] ushort* JPGCMIDIDOP, [In][NoAlias] float4* CCEEBJLFJFK, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAA10", Offset = "0x7CB9010", VA = "0x187CBAA10")]
	[BurstCompile]
	public static ushort JBJPEOOOKLG([In] float4 LLFBONBFGND)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4290", Offset = "0x7CB2890", VA = "0x187CB4290")]
	[BurstCompile]
	public unsafe static void AAGAKMNGCMK([NoAlias] float4* JPGCMIDIDOP, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB61C0", Offset = "0x7CB47C0", VA = "0x187CB61C0")]
	[BurstCompile]
	public unsafe static void CMFNFHPDBJO([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB960", Offset = "0x7CB9F60", VA = "0x187CBB960")]
	[BurstCompile]
	public unsafe static void LDGINEKEBOP([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB48D0", Offset = "0x7CB2ED0", VA = "0x187CB48D0")]
	[BurstCompile]
	public unsafe static void AIAOKGPABAJ([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7340", Offset = "0x7CB5940", VA = "0x187CB7340")]
	[BurstCompile]
	public unsafe static void EGOALEOOJFD([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4370", Offset = "0x7CB2970", VA = "0x187CB4370")]
	[BurstCompile]
	public unsafe static void AAGIEHPLOHI([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCA50", Offset = "0x7CBB050", VA = "0x187CBCA50")]
	[BurstCompile]
	public static void NFIHPLHCIIG([Out] float4 OBOOAPELMPF, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE760", Offset = "0x7CACD60", VA = "0x187CAE760")]
	[BurstCompile]
	public unsafe static void HCKPDINCBHC([NoAlias] float4* CNINOIGOJEA, [NoAlias] byte* JJKOJNFOHOC, [Out] int AADEMPPBGIH, [Out] int HOGJPMLHDCP, [NoAlias] float4* EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4B40", Offset = "0x7CB3140", VA = "0x187CB4B40")]
	[BurstCompile]
	public unsafe static void BELKIJAGMNF([NoAlias] float4* DOBCKFGCGOD, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CB46F0", Offset = "0x7CB2CF0", VA = "0x187CB46F0")]
	[BurstCompile]
	public unsafe static void AHGGMEMFEKB([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4C80", Offset = "0x7CB3280", VA = "0x187CB4C80")]
	[BurstCompile]
	public unsafe static void BEMJIAEDOHE([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDC30", Offset = "0x7CBC230", VA = "0x187CBDC30")]
	[BurstCompile]
	public unsafe static void PONMJCEFOME([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD730", Offset = "0x7CBBD30", VA = "0x187CBD730")]
	[BurstCompile]
	public unsafe static void OMBOGECNPDC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8A60", Offset = "0x7CB7060", VA = "0x187CB8A60")]
	[BurstCompile]
	public unsafe static void GNCGEJOCPFE([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7770", Offset = "0x7CB5D70", VA = "0x187CB7770")]
	[BurstCompile]
	public unsafe static int EJBIGHJPOFM([NoAlias] byte* AADAHELMBIE, [In][NoAlias] int* LPLJFEEALKJ, int CHENFJALHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8D80", Offset = "0x7CB7380", VA = "0x187CB8D80")]
	[BurstCompile]
	public unsafe static void HDDDDGABHIO([NoAlias] int* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB52E0", Offset = "0x7CB38E0", VA = "0x187CB52E0")]
	[BurstCompile]
	public unsafe static void BNJKEAINMMD([NoAlias] ushort* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEBC0", Offset = "0x7CAD1C0", VA = "0x187CAEBC0")]
	[BurstCompile]
	public static void NAPABBEOACD([Out] float3 AJAKAPDAHBO, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD570", Offset = "0x7CABB70", VA = "0x187CAD570")]
	[BurstCompile]
	public static ushort BMJOGIDPIKD([In] float3 LLFBONBFGND)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class OFNFOCEBPOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum LEBCKMKDBPC
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
	public enum MPLLFAPOJAH
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
	public struct NDIFCAFABIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LEBCKMKDBPC CKHLMMECGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool GBDANKIHBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int GGKLNJBMGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct EHIJFMCOPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 EPCLGOKLIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 HPAMHMBDLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 OFDPNDMFOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 FMANEDILOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 LGPLODMABGM;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct EHEEGMEMPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 EPCLGOKLIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 HPAMHMBDLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 OFDPNDMFOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 FMANEDILOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 LGPLODMABGM;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct HNAPBBAPNHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 EPCLGOKLIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint HPAMHMBDLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint OFDPNDMFOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 FMANEDILOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 LGPLODMABGM;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct EECMHFOGIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 EPCLGOKLIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint HPAMHMBDLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint OFDPNDMFOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 FMANEDILOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 LGPLODMABGM;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct FBAFEBCICFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 EPCLGOKLIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint COMAADGEOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 FMANEDILOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint PAAMDIOPIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint NGNHNPHIJOK;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct IMGNLKODGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public IGDJGOALOED.LCINGHBPBHP FOBECFHOEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint COMAADGEOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 FMANEDILOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint PAAMDIOPIBE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] HKNADPGHGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int HPEMGGMAHLM(float CEJAAIDLEPA);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class BEEBOCPAGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0F20", Offset = "0x7CAF520", VA = "0x187CB0F20")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1040", Offset = "0x7CAF640", VA = "0x187CB1040")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0E80", Offset = "0x7CAF480", VA = "0x187CB0E80")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0C20", Offset = "0x7CAF220", VA = "0x187CB0C20")]
		public static int CIBKKMOJDEC(float CEJAAIDLEPA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint KMGLLOLCACJ([In] float4 IINHKHEMEHJ);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class JBMGFKCBKFM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBC70", Offset = "0x7CDA270", VA = "0x187CDBC70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBD90", Offset = "0x7CDA390", VA = "0x187CDBD90")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBBD0", Offset = "0x7CDA1D0", VA = "0x187CDBBD0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB960", Offset = "0x7CD9F60", VA = "0x187CDB960")]
		public static uint CIBKKMOJDEC([In] float4 IINHKHEMEHJ)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint LBMDCOJEDDA([In] float3 IINHKHEMEHJ);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class ANBDLDDMDNH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7CD27F0", Offset = "0x7CD0DF0", VA = "0x187CD27F0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2910", Offset = "0x7CD0F10", VA = "0x187CD2910")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2750", Offset = "0x7CD0D50", VA = "0x187CD2750")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2510", Offset = "0x7CD0B10", VA = "0x187CD2510")]
		public static uint CIBKKMOJDEC([In] float3 IINHKHEMEHJ)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void GLFADICMGPC([NoAlias] HNAPBBAPNHA* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class POEKIOPEIPC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAEC0", Offset = "0x7CE94C0", VA = "0x187CEAEC0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAFE0", Offset = "0x7CE95E0", VA = "0x187CEAFE0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAE20", Offset = "0x7CE9420", VA = "0x187CEAE20")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEABF0", Offset = "0x7CE91F0", VA = "0x187CEABF0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] HNAPBBAPNHA* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void CEGPDPLNIBJ([NoAlias] EECMHFOGIPB* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class PLMOGBLEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA980", Offset = "0x7CE8F80", VA = "0x187CEA980")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAAA0", Offset = "0x7CE90A0", VA = "0x187CEAAA0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA8E0", Offset = "0x7CE8EE0", VA = "0x187CEA8E0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA6B0", Offset = "0x7CE8CB0", VA = "0x187CEA6B0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] EECMHFOGIPB* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void OLHJDMAGPOJ([NoAlias] FBAFEBCICFD* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class LKBBGCBDICG
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7D20", Offset = "0x7CE6320", VA = "0x187CE7D20")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7E40", Offset = "0x7CE6440", VA = "0x187CE7E40")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7C80", Offset = "0x7CE6280", VA = "0x187CE7C80")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE78A0", Offset = "0x7CE5EA0", VA = "0x187CE78A0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] FBAFEBCICFD* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void FKKDBBPCLOC([NoAlias] IMGNLKODGID* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM, [Out] float3 FINEMDGKOBL, [Out] float3 CBBADNNIJCC);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class HAMDBEGJILG
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA0A0", Offset = "0x7CD86A0", VA = "0x187CDA0A0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA1C0", Offset = "0x7CD87C0", VA = "0x187CDA1C0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA000", Offset = "0x7CD8600", VA = "0x187CDA000")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7CD9AB0", Offset = "0x7CD80B0", VA = "0x187CD9AB0")]
		public unsafe static void CIBKKMOJDEC([NoAlias] IMGNLKODGID* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM, [Out] float3 FINEMDGKOBL, [Out] float3 CBBADNNIJCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int IALOEILMAKH = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> HOBJGDJLFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> ADHEBJIOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> LHMIDMPAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> IDEFIPDMGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> GNBJGLIKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> JHJMFPLBLBC;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] EFBCOEHBKIG;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool IKFKCLJIJCJ;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static NDIFCAFABIA[] BBBNKJDCFFK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0A50", Offset = "0x7CCF050", VA = "0x187CD0A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFC50", Offset = "0x7CCE250", VA = "0x187CCFC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7CCB9B0", Offset = "0x7CC9FB0", VA = "0x187CCB9B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GMHDFKBMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF4A0", Offset = "0x7CCDAA0", VA = "0x187CCF4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA8D0", Offset = "0x7CC8ED0", VA = "0x187CCA8D0")]
	public static MPLLFAPOJAH BDIAGDDMHKC(LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(MPLLFAPOJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF4E0", Offset = "0x7CCDAE0", VA = "0x187CCF4E0")]
	public static void MKPMBGIKJHF(MPLLFAPOJAH PLAKJHGAFDC, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB2A0", Offset = "0x7CC98A0", VA = "0x187CCB2A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD610", Offset = "0x7CCBC10", VA = "0x187CCD610")]
	public void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB, bool AKCOJAELIJC, bool KLNAIMNEAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0090", Offset = "0x7CCE690", VA = "0x187CD0090")]
	public void OKAAKCDEBLF(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF5A0", Offset = "0x7CCDBA0", VA = "0x187CCF5A0", Slot = "6")]
	public bool MLJIOPMADIF(Mesh PEPFHNJFNIL, bool DILEIBANLAM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFC90", Offset = "0x7CCE290", VA = "0x187CCFC90")]
	public bool OCKMBDCILHB(Mesh PEPFHNJFNIL, bool DILEIBANLAM, bool JLIOEHLJPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA3D0", Offset = "0x7CC89D0", VA = "0x187CCA3D0")]
	public bool BBDKPNMDEJL(Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, bool DILEIBANLAM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCDA0", Offset = "0x7CCB3A0", VA = "0x187CCCDA0")]
	public bool IHGKLDFPDGN(Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDDB0", Offset = "0x7CCC3B0", VA = "0x187CCDDB0")]
	private void KNNNEDHMAEL(Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CCE540", Offset = "0x7CCCB40", VA = "0x187CCE540")]
	public void KNNNEDHMAEL(NativeArray<ushort> GAKGLFDFMPF, NativeArray<FBAFEBCICFD> PDIDMHJKDPO, Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC2E0", Offset = "0x7CCA8E0", VA = "0x187CCC2E0")]
	public void HNKLGDNLPMG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF090", Offset = "0x7CCD690", VA = "0x187CCF090")]
	[BurstCompile]
	public static int MFFAAIMOOHE(float CEJAAIDLEPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CCEFF0", Offset = "0x7CCD5F0", VA = "0x187CCEFF0")]
	[BurstCompile]
	public static uint MFFAAIMOOHE([In] float4 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF040", Offset = "0x7CCD640", VA = "0x187CCF040")]
	[BurstCompile]
	public static uint MFFAAIMOOHE([In] float3 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF5C0", Offset = "0x7CCDBC0", VA = "0x187CCF5C0")]
	public void NJLOGFHEPOF(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCD20", Offset = "0x7CCB320", VA = "0x187CCCD20")]
	[BurstCompile]
	private unsafe static void IGHINMCOPPK([NoAlias] HNAPBBAPNHA* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCF80", Offset = "0x7CCB580", VA = "0x187CCCF80")]
	public void JNFNGDFFFDD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CCEF70", Offset = "0x7CCD570", VA = "0x187CCEF70")]
	[BurstCompile]
	private unsafe static void MAMJNICGAMG([NoAlias] EECMHFOGIPB* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA920", Offset = "0x7CC8F20", VA = "0x187CCA920")]
	public void CFFDNIDHOHG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CCACF0", Offset = "0x7CC92F0", VA = "0x187CCACF0")]
	public void CFFDNIDHOHG(NativeArray<ushort> BMPFHBCCNDN, NativeArray<FBAFEBCICFD> GFKJOIMNDHO, Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCE70", Offset = "0x7CCB470", VA = "0x187CCCE70")]
	[BurstCompile]
	public unsafe static void JABLGOCCCAP([NoAlias] FBAFEBCICFD* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB9F0", Offset = "0x7CC9FF0", VA = "0x187CCB9F0")]
	public void GFKEJIBGGBD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB510", Offset = "0x7CC9B10", VA = "0x187CCB510")]
	[BurstCompile]
	private unsafe static void FIFADFIPBAN([NoAlias] IMGNLKODGID* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM, [Out] float3 FINEMDGKOBL, [Out] float3 CBBADNNIJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCEF0", Offset = "0x7CCB4F0", VA = "0x187CCCEF0")]
	public void JIMECJHBEFE(Mesh PEPFHNJFNIL, LEBCKMKDBPC CKHLMMECGLE, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB590", Offset = "0x7CC9B90", VA = "0x187CCB590")]
	public void FMLNAEFDMPJ(OFNFOCEBPOF PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CCEB90", Offset = "0x7CCD190", VA = "0x187CCEB90")]
	public void LGMCALEKNMI(OFNFOCEBPOF NEKLMLONNIM, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB860", Offset = "0x7CC9E60", VA = "0x187CCB860")]
	public long GEBEHCBKDIL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB800", Offset = "0x7CC9E00", VA = "0x187CCB800")]
	public static long GEBEHCBKDIL(int ALGLHJLPILC, int GIKGIGBNIPH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB3B0", Offset = "0x7CC99B0", VA = "0x187CCB3B0")]
	public static long ENNKELIOCBP(int ALGLHJLPILC, int GIKGIGBNIPH, LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB450", Offset = "0x7CC9A50", VA = "0x187CCB450")]
	public long ENNKELIOCBP(LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB0A0", Offset = "0x7CC96A0", VA = "0x187CCB0A0")]
	public void CIFIGGJLKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD800", Offset = "0x7CCBE00", VA = "0x187CCD800")]
	public static void KIIEDBBJNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0110", Offset = "0x7CCE710", VA = "0x187CD0110")]
	public LEBCKMKDBPC PBIHAELCOKG()
	{
		return default(LEBCKMKDBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC130", Offset = "0x7CCA730", VA = "0x187CCC130")]
	public static (int, int) GJJHDFLFDBO(Mesh PEPFHNJFNIL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC200", Offset = "0x7CCA800", VA = "0x187CCC200")]
	public static int GNPNHFMCGFD(VertexAttributeDescriptor[] OBEKDLLJPGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB230", Offset = "0x7CC9830", VA = "0x187CCB230")]
	public static long DANHMPNCGCM(Mesh PEPFHNJFNIL, int OHLODDJOFDB, int DLKBHAIHLJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB100", Offset = "0x7CC9700", VA = "0x187CCB100")]
	public static long DANHMPNCGCM(Mesh PEPFHNJFNIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OFNFOCEBPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7CCEE20", Offset = "0x7CCD420", VA = "0x187CCEE20")]
	[BurstCompile]
	public static int LIHHOINPOLE(float CEJAAIDLEPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7CCEC90", Offset = "0x7CCD290", VA = "0x187CCEC90")]
	[BurstCompile]
	public static uint LIHHOINPOLE([In] float4 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7CCEEC0", Offset = "0x7CCD4C0", VA = "0x187CCEEC0")]
	[BurstCompile]
	public static uint LIHHOINPOLE([In] float3 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF0E0", Offset = "0x7CCD6E0", VA = "0x187CCF0E0")]
	[BurstCompile]
	public unsafe static void MHLHECAMCGJ([NoAlias] HNAPBBAPNHA* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9F80", Offset = "0x7CC8580", VA = "0x187CC9F80")]
	[BurstCompile]
	public unsafe static void AJBAKCLECAI([NoAlias] EECMHFOGIPB* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0850", Offset = "0x7CCEE50", VA = "0x187CD0850")]
	[BurstCompile]
	public unsafe static void PIJIEIEIMMD([NoAlias] FBAFEBCICFD* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7CCE850", Offset = "0x7CCCE50", VA = "0x187CCE850")]
	[BurstCompile]
	public unsafe static void LDMBCMMPPFA([NoAlias] IMGNLKODGID* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM, [Out] float3 FINEMDGKOBL, [Out] float3 CBBADNNIJCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JDAJOIBJGCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int ECMKHMEBGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 CPJIDEOPNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion HMMELPEPIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 NDGLKGIJNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int FIGDBNMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int JDEHADDKJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float GLOADLJCNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 EHLPPMACBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool DKBGKGLANKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public EGAMEBEHMLC IEDLAHHOCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 GPFNJPHOAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float EKDFGDEKNDN;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class OGPFNIIHPFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static HEFAOEOOFNP EDBDAMIIKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<JDAJOIBJGCG> BDJADGFHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<HLKPJJDGGOK> EPEAPDFFLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<LHLKKDNGDMK> NNIKMMLLLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<KIKMAHKACEI> CCGNGHGOKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<HLKPJJDGGOK> MCIEHPEGNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<CKABIAIDDHB> FGEIMKBDDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<KIKMAHKACEI>> AFHCLPGIBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<HGNFDNHGFNE> AKIHOODFKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> KJGCGJFEJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> LELOBBFALIH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<KIEGPPHBLFN.KENJAAMBBKH> EFOBPCFINGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4A0", Offset = "0x9EDAA0", VA = "0x1809EF4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4E0", Offset = "0x9EDAE0", VA = "0x1809EF4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC16770", Offset = "0xC14D70", VA = "0x180C16770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC16780", Offset = "0xC14D80", VA = "0x180C16780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA490", Offset = "0x7CE8A90", VA = "0x187CEA490")]
	public OGPFNIIHPFO(int FDKEHLHNLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8A70", Offset = "0x7CE7070", VA = "0x187CE8A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA080", Offset = "0x7CE8680", VA = "0x187CEA080")]
	public void NNOHEEPCFHD(JobHandle GMNPCPDAADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA270", Offset = "0x7CE8870", VA = "0x187CEA270")]
	public void PHGOCJBDJLN(JDAJOIBJGCG APDBNIMCPID, HGNFDNHGFNE FLMKMEGOIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9F20", Offset = "0x7CE8520", VA = "0x187CE9F20")]
	public void LICHKICBMDJ(LHLKKDNGDMK APDBNIMCPID, NativeArray<KIKMAHKACEI> HCHKNOLBPGP, int NPGNODKKKAD, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9E00", Offset = "0x7CE8400", VA = "0x187CE9E00")]
	public JobHandle GIBHBFIGFKC(OFNFOCEBPOF HDOENGOJBKJ, KCFHOMPPIJH JJJNFMILJFE, float3 BFIHAPKNNFO, quaternion FPCGAIHLJMK, float BIHFAHMMCBL, bool HLDCLHOMCIC, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8C50", Offset = "0x7CE7250", VA = "0x187CE8C50")]
	public JobHandle GIBHBFIGFKC(OFNFOCEBPOF HDOENGOJBKJ, KCFHOMPPIJH JJJNFMILJFE, NativeList<KIEGPPHBLFN.KENJAAMBBKH> AAHJHDLNKPC, float3 BFIHAPKNNFO, quaternion FPCGAIHLJMK, float BIHFAHMMCBL, bool HLDCLHOMCIC, bool KHLAAFDPHLE, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8700", Offset = "0x7CE6D00", VA = "0x187CE8700")]
	public static JobHandle DCBLLABKBDH(CJOPLDNPDPH KJIJIHOMHHM, OFNFOCEBPOF HDOENGOJBKJ, NativeArray<int> LELOBBFALIH, JDAJOIBJGCG APDBNIMCPID, JobHandle GMNPCPDAADC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8450", Offset = "0x7CE6A50", VA = "0x187CE8450")]
	public static JobHandle BMCAHAOJIBF(FKMOHECEINB KJIJIHOMHHM, OFNFOCEBPOF HDOENGOJBKJ, LHLKKDNGDMK APDBNIMCPID, NativeArray<KIKMAHKACEI> HCHKNOLBPGP, int NPGNODKKKAD, int PCGPKCCHANN, JobHandle GMNPCPDAADC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JNIMLOAOMMC
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct ACJOMKPBFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer CCKFDFMBDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public KONEPKKBNEN.BPAACFHOGHM MEDEJIAPIAI;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF9E0", Offset = "0x5BEDFE0", VA = "0x185BEF9E0")]
		public ACJOMKPBFMP(MeshRenderer CCKFDFMBDLN, KONEPKKBNEN.BPAACFHOGHM MEDEJIAPIAI)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2490", Offset = "0x7CD0A90", VA = "0x187CD2490")]
		public static ACJOMKPBFMP OIFHDJNIHDL((MeshRenderer, KONEPKKBNEN.BPAACFHOGHM) DAPCBFLAHDI)
		{
			return default(ACJOMKPBFMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker MDKLFJOBINO;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker ADIPMEBBAHE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker NFPGAMPENAO;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker BCILGDDCLJN;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE7A0", Offset = "0x7CDCDA0", VA = "0x187CDE7A0")]
	internal void MCGJMLGDLEM(GameObject GCEIEIMOCNH, KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<ACJOMKPBFMP> ENJOLJLINPM, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF090", Offset = "0x7CDD690", VA = "0x187CDF090")]
	internal void PHAHIMFNJAM(GameObject GCEIEIMOCNH, KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<ACJOMKPBFMP> ENJOLJLINPM, List<LODGroup> FKCEGOEDFMO, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCE20", Offset = "0x7CDB420", VA = "0x187CDCE20")]
	private MeshRenderer IDIDDMEEIAI(KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, Material CANJBFKPEMF, List<ACJOMKPBFMP> ENJOLJLINPM, bool OFEEHAOIEMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBEE0", Offset = "0x7CDA4E0", VA = "0x187CDBEE0")]
	private List<(List<ACJOMKPBFMP>, float)> GCMMEFOBFLB(KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<LODGroup> FKCEGOEDFMO, Material CANJBFKPEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD8D0", Offset = "0x7CDBED0", VA = "0x187CDD8D0")]
	private List<List<(List<ACJOMKPBFMP>, float)>> IFPACDBLMEG(KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<LODGroup> FKCEGOEDFMO, Material CANJBFKPEMF, [Out] int OKDJEMEKHEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JNIMLOAOMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE630", Offset = "0x7CDCC30", VA = "0x187CDE630")]
	[CompilerGenerated]
	internal static (float, int) LMCHEKCPKIK(List<List<(List<ACJOMKPBFMP> meshList, float lodTransition)>> JGONFKADFKA, int[] GEDMGIDMHDG)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KBMKMICBMFP
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker IMKJIGPPBGN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker OHKNNPFNJFB;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker LJMKGBIKFHK;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker PBGINCIGJJA;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker HIIGEMGKBAA;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker FJGFFLLNKNL;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker HCDGFMEKCAC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly JBBHIJHGEPM MHHLKMEMHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private KONEPKKBNEN PECILHDMMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JNIMLOAOMMC PBEJOLGEOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader HDOKFJHKKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock OPDJEBIDIEE;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0F80", Offset = "0x7CDF580", VA = "0x187CE0F80")]
	public static void MDOOIPLBLJB(GameObject GCEIEIMOCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFCD0", Offset = "0x7CDE2D0", VA = "0x187CDFCD0")]
	public void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1970", Offset = "0x7CDFF70", VA = "0x187CE1970")]
	public void NIFMMJPCPCL(GameObject GCEIEIMOCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0B20", Offset = "0x7CDF120", VA = "0x187CE0B20")]
	private bool HELHDCJHMKD(MeshRenderer CCKFDFMBDLN, [Out] MeshFilter HEEKELAELBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFA70", Offset = "0x7CDE070", VA = "0x187CDFA70")]
	private bool AGIENJEPLDG(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0CA0", Offset = "0x7CDF2A0", VA = "0x187CE0CA0")]
	private void HJEEBHACFLC(GameObject GCEIEIMOCNH, int OHHMJGCBCKD, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1BE0", Offset = "0x7CE01E0", VA = "0x187CE1BE0")]
	private List<JNIMLOAOMMC.ACJOMKPBFMP> PPAHFHABMDG(int OHHMJGCBCKD, [Out] List<LODGroup> FKCEGOEDFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0560", Offset = "0x7CDEB60", VA = "0x187CE0560")]
	private List<(int, Material)> DEIABAFGJGP(float MDOIJLBMINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7CE04B0", Offset = "0x7CDEAB0", VA = "0x187CE04B0")]
	public void AOJNBLCPAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7CE12E0", Offset = "0x7CDF8E0", VA = "0x187CE12E0")]
	private bool NHNIIAALMCG(GameObject CEKGANCAJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2600", Offset = "0x7CE0C00", VA = "0x187CE2600")]
	public KBMKMICBMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class KONEPKKBNEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct HCBGFIGAOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 JNIBMOMFMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 COJGDIKBGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float PLJNHJPJGDF;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA310", Offset = "0x7CD8910", VA = "0x187CDA310")]
		public HCBGFIGAOPH(Bounds HJOECMEGBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA480", Offset = "0x7CD8A80", VA = "0x187CDA480")]
		public HCBGFIGAOPH(float3 JNIBMOMFMLL, float3 COJGDIKBGKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct BMNNLAFPHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public HCBGFIGAOPH EFNEPLCKMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int HFKHEKDPADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int AHOBMFHOIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float IBKGDHPIBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int DIGNHEFBOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int OIBGODHDOGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int EBAOFDAPDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int ONHOMHCKHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int PKFODDFINIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool OGBPEJIKJEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct BPAACFHOGHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh LNGKDJGKDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 GHCKOOAHILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int ANGGKMLDLJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct HOJJIBNDJAO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<BMNNLAFPHCD> GDEABELPJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> MFNAKEDKNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int JBGNEAFGGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public HCBGFIGAOPH HJOECMEGBKL;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB830", Offset = "0x7CD9E30", VA = "0x187CDB830")]
		private float NDKEHGLBPGB(HCBGFIGAOPH FDJHCIBLFFB, HCBGFIGAOPH CNIMJCCKEDM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB610", Offset = "0x7CD9C10", VA = "0x187CDB610", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker MAIFBEAEJDF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker CGOCLLPBNJI;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker IKMFCEICNHG;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker GHOKHFEBKPE;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker DOHIPFEMIFG;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker PPAAGIHBEBP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker DAHINBAODFK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker DJDPJGMNOJE;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker OJKNAEMKMIM;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker BFFOEDJMLPO;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker ELAIDOKGBBF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker NJGGFGMMCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<BMNNLAFPHCD> GDEABELPJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> MOOKIAOEAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int NFMKMEKNKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> ABENNMOCMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<BPAACFHOGHM> BEDDKLNGGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> FKCEGOEDFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> JHOLLBCECCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> HBFEHKFDNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader AGEOGHNHPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader HAEGBOOMGGJ;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6A30", Offset = "0x7CE5030", VA = "0x187CE6A30")]
	public KONEPKKBNEN(int EJODENHMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4BD0", Offset = "0x7CE31D0", VA = "0x187CE4BD0")]
	private void IGDLCOFAHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE36B0", Offset = "0x7CE1CB0", VA = "0x187CE36B0")]
	public bool BHLLNIEIMGA(MeshRenderer DPKPFOPKHHF, MeshFilter PPJCNKKDOGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2980", Offset = "0x7CE0F80", VA = "0x187CE2980")]
	public bool BHLLNIEIMGA(LODGroup NKOAIGACENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4340", Offset = "0x7CE2940", VA = "0x187CE4340")]
	private bool DGAEJOHLCDJ(MeshRenderer DPKPFOPKHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5270", Offset = "0x7CE3870", VA = "0x187CE5270")]
	private int LKHLGCKKNID(MeshRenderer DPKPFOPKHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5200", Offset = "0x7CE3800", VA = "0x187CE5200")]
	private int KBBHKGBAIBD(LODGroup NKOAIGACENI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4A70", Offset = "0x7CE3070", VA = "0x187CE4A70")]
	private int HKKMFDGKHEB(MeshFilter PPJCNKKDOGD, int FPNNGFNMBMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3FB0", Offset = "0x7CE25B0", VA = "0x187CE3FB0")]
	private int DDDAJOJDAFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3BC0", Offset = "0x7CE21C0", VA = "0x187CE3BC0")]
	private static HCBGFIGAOPH CFMEGFHKOPA(HCBGFIGAOPH FDJHCIBLFFB, HCBGFIGAOPH CNIMJCCKEDM)
	{
		return default(HCBGFIGAOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7CE65D0", Offset = "0x7CE4BD0", VA = "0x187CE65D0")]
	private static float OMHOAJGHPDL(Vector3 JNIBMOMFMLL, Vector3 COJGDIKBGKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4470", Offset = "0x7CE2A70", VA = "0x187CE4470")]
	private int ENOFLPGLCPO(int IFGBFFBAKME, HCBGFIGAOPH JMLAFKDDHEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7CE47E0", Offset = "0x7CE2DE0", VA = "0x187CE47E0")]
	private void FKPAOPKAGIF(HCBGFIGAOPH JMLAFKDDHEL, int OHHMJGCBCKD, [Out] float GEOHFENLFDH, [Out] float MILCDNNFIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7CE59C0", Offset = "0x7CE3FC0", VA = "0x187CE59C0")]
	private void NAMIPDOILIK(HCBGFIGAOPH JMLAFKDDHEL, int PLLDGDDNDJH, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5EC0", Offset = "0x7CE44C0", VA = "0x187CE5EC0")]
	private float NDKEHGLBPGB(HCBGFIGAOPH FDJHCIBLFFB, HCBGFIGAOPH CNIMJCCKEDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4D40", Offset = "0x7CE3340", VA = "0x187CE4D40")]
	private void IMGBMCOBKJJ(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6140", Offset = "0x7CE4740", VA = "0x187CE6140")]
	private void OBLFHHKPIOI(int LOHCKAAJAJO, int FAJGDEPPNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5390", Offset = "0x7CE3990", VA = "0x187CE5390")]
	private void LOAPBNICCDH(int LOHCKAAJAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE43C0", Offset = "0x7CE29C0", VA = "0x187CE43C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct OEBPFEHPECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 PFBGAKLJGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 ENMINAOPOCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class PPAGMPOCDKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<OEBPFEHPECP> NJKHEMPLDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> DNBDKDOMBOP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB270", Offset = "0x7CE9870", VA = "0x187CEB270")]
	public PPAGMPOCDKK(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB130", Offset = "0x7CE9730", VA = "0x187CEB130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB190", Offset = "0x7CE9790", VA = "0x187CEB190")]
	public void FMLNAEFDMPJ(PPAGMPOCDKK OMKIEMGOOAG, int NCAAAOKJHDN, int NGFMNKONPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class EHKLDMPHFJA
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static PPAGMPOCDKK PONKCAJCEBG;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<HLKPJJDGGOK> DBONMCNFMBG;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] DIDBKJJCPGO;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool LEEKNANJEJO;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, PPAGMPOCDKK> PBHIBJDNIGL;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, PPAGMPOCDKK> JAMDICIFHBC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool CJKELDMDGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4390", Offset = "0x7CD2990", VA = "0x187CD4390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<HLKPJJDGGOK> LALCNMAENFB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3EE0", Offset = "0x7CD24E0", VA = "0x187CD3EE0")]
		get
		{
			return default(NativeList<HLKPJJDGGOK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PPAGMPOCDKK JOKKHNAPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2F70", Offset = "0x7CD1570", VA = "0x187CD2F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD36B0", Offset = "0x7CD1CB0", VA = "0x187CD36B0")]
	private static void HGMMEBFKNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2DC0", Offset = "0x7CD13C0", VA = "0x187CD2DC0")]
	public static int AABACNAPLNC(bool FKPHBJJEDHC, int JANHHJILHAO, bool PJCPKAIHNHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3400", Offset = "0x7CD1A00", VA = "0x187CD3400")]
	private static int FKJNDPPBNMI(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3DE0", Offset = "0x7CD23E0", VA = "0x187CD3DE0")]
	private static int JBANMACPJBK(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4410", Offset = "0x7CD2A10", VA = "0x187CD4410")]
	public static int PEFJMHGLFPA(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4300", Offset = "0x7CD2900", VA = "0x187CD4300")]
	public static int NABMALJFFIG(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3DD0", Offset = "0x7CD23D0", VA = "0x187CD3DD0")]
	public static int IPENECLKFKG(int NPCDJLLDJOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3F70", Offset = "0x7CD2570", VA = "0x187CD3F70")]
	private static int LGNFKBCJPJL(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3FA0", Offset = "0x7CD25A0", VA = "0x187CD3FA0")]
	private static int MAMICGHMAOK(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3D60", Offset = "0x7CD2360", VA = "0x187CD3D60")]
	public static int IACJDBKGHFD(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2EE0", Offset = "0x7CD14E0", VA = "0x187CD2EE0")]
	public static int CAPEEBNMNJG(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3F80", Offset = "0x7CD2580", VA = "0x187CD3F80")]
	public static int LIFAGJIOBHK(int NPCDJLLDJOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3DF0", Offset = "0x7CD23F0", VA = "0x187CD3DF0")]
	public static PPAGMPOCDKK JOBHCKLJIGP(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3420", Offset = "0x7CD1A20", VA = "0x187CD3420")]
	private static PPAGMPOCDKK HCAJJNOJMBN(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2DF0", Offset = "0x7CD13F0", VA = "0x187CD2DF0")]
	public static PPAGMPOCDKK BFABADHCABA(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3FC0", Offset = "0x7CD25C0", VA = "0x187CD3FC0")]
	private static PPAGMPOCDKK MNBIBHCMHMM(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3000", Offset = "0x7CD1600", VA = "0x187CD3000")]
	public static void DMLDIIKDBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct LHLKKDNGDMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int DOEDCCEOIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 CPJIDEOPNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion HMMELPEPIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float NDGLKGIJNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float NJHENHFAHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int FNLBLGEDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int FIGDBNMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int JDEHADDKJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool OGHJLNADOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool DFJPGBCGEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float GLOADLJCNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 EHLPPMACBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool LBMDNFABFIG;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct CKABIAIDDHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int DOPBKKBABMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int HJJOOOBJKML;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FKMOHECEINB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<LHLKKDNGDMK> PFHGEKDMDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<KIKMAHKACEI> IFDPPPNBHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<HLKPJJDGGOK> GILNLHFKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<CKABIAIDDHB> NNNPHMLEIJK;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD75E0", Offset = "0x7CD5BE0", VA = "0x187CD75E0")]
	public FKMOHECEINB(NativeArray<KIKMAHKACEI> IFDPPPNBHEJ, int CFNMLMNHCMF = 1, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD74F0", Offset = "0x7CD5AF0", VA = "0x187CD74F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct HAFKINHLNCE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<OEBPFEHPECP> IGEAJIAHOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> KIPNIJAKCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<HLKPJJDGGOK> FLPKGOGIJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<LHLKKDNGDMK> PFHGEKDMDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<KIKMAHKACEI> IFDPPPNBHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<HLKPJJDGGOK> GILNLHFKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<CKABIAIDDHB> NNNPHMLEIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int JNDECMGOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int KCOBPAKBFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 OBAHNCOAMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion OCCNMBMFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 IMDIPBOAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DKNBLCLOBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DELPAHBIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MGMLEJNJKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CNBDMKHMHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> ICANBMPEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DFBBAPNMLCD;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9830", Offset = "0x7CD7E30", VA = "0x187CD9830")]
	public HAFKINHLNCE(OGPFNIIHPFO CGLBPMODFFI, OFNFOCEBPOF EOEDBPGPGOH, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9600", Offset = "0x7CD7C00", VA = "0x187CD9600")]
	public HAFKINHLNCE(FKMOHECEINB CGLBPMODFFI, OFNFOCEBPOF EOEDBPGPGOH, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float3 IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CD94C0", Offset = "0x7CD7AC0", VA = "0x187CD94C0")]
	private float3 MCONLNGJOFA(float3 MKCAJAFKDHH, Matrix4x4 LKBMPPNOIOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7760", Offset = "0x7CD5D60", VA = "0x187CD7760")]
	private float3x3 DMFNKDAFNOI(float3x3 JALCONLNBJA, float3x3 DJMCMDKONHA)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CD94B0", Offset = "0x7CD7AB0", VA = "0x187CD94B0")]
	private float JMHNFOHCDJE(float HDLKNIPAJGK, float HKIMMIELFOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7D60", Offset = "0x7CD6360", VA = "0x187CD7D60", Slot = "4")]
	public void Execute(int JDCGPDDDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9340", Offset = "0x7CD7940", VA = "0x187CD9340")]
	private void HGBEBMMHBJE(int NAGECFMHKCN, float3 EPCLGOKLIPO, float3 HPAMHMBDLLL, float3 OFDPNDMFOFN, float PIBKBDEFJIN, bool IJMPJJAJAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8F00", Offset = "0x7CD7500", VA = "0x187CD8F00")]
	private void FMKFCOIBAHP(LHLKKDNGDMK NIAKGFOFLJM, float3 HNHGJPFCFDL, float3x3 BNLJKPCLJFI, float HDLKNIPAJGK, int PDEKGNANDEB, int NHBCBGLMOEK, int LIIGMANIILP, float LHJOAJGMHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CD77E0", Offset = "0x7CD5DE0", VA = "0x187CD77E0")]
	private void EEIFALLAHND(int NAGECFMHKCN, int GKOBPNMJCKP, LHLKKDNGDMK NIAKGFOFLJM, float3 HNHGJPFCFDL, float3x3 BNLJKPCLJFI, bool OOPNHEBFFKK, float HDLKNIPAJGK, int LOEGFHOICOD, int NIFDDMIBFBE, int LIIGMANIILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct CJOPLDNPDPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<JDAJOIBJGCG> GLNNEPGOAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<HLKPJJDGGOK> LEEFHEAECNB;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2C00", Offset = "0x7CD1200", VA = "0x187CD2C00")]
	public CJOPLDNPDPH(int CFNMLMNHCMF, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2B60", Offset = "0x7CD1160", VA = "0x187CD2B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct FHCEOOEIJBJ : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum CGFCFGONJIJ
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
	private NativeList<float3> CMCMLGGHBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> MJEFGIDAJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> KOLIMJKFMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> KGDFLHDBIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> MGGKECJABDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> KMNAGLOGPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> HPCHDCOONCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> CFFJMEGIFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> IFGCGAIPBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<HLKPJJDGGOK> OANOMFGIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<JDAJOIBJGCG> GLNNEPGOAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<HLKPJJDGGOK> LEEFHEAECNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int JNDECMGOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int KCOBPAKBFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DKNBLCLOBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DELPAHBIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MGMLEJNJKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CNBDMKHMHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> ICANBMPEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LELOBBFALIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DFBBAPNMLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 IMDIPBOAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion OCCNMBMFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 OBAHNCOAMNF;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CD71E0", Offset = "0x7CD57E0", VA = "0x187CD71E0")]
	public FHCEOOEIJBJ(OGPFNIIHPFO CGLBPMODFFI, OFNFOCEBPOF EOEDBPGPGOH, NativeArray<int> AFDIAPKLIIN, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6FE0", Offset = "0x7CD55E0", VA = "0x187CD6FE0")]
	public FHCEOOEIJBJ(CJOPLDNPDPH APDBNIMCPID, OFNFOCEBPOF EOEDBPGPGOH, NativeArray<int> AFDIAPKLIIN, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float3 IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5C40", Offset = "0x7CD4240", VA = "0x187CD5C40", Slot = "4")]
	public void Execute(int JDCGPDDDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6BF0", Offset = "0x7CD51F0", VA = "0x187CD6BF0")]
	private void LGKNGLGOHIO(float4x4 PNOMKMDMEID, int JDCGPDDDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5B80", Offset = "0x7CD4180", VA = "0x187CD5B80")]
	private CGFCFGONJIJ AGGACLAGMCG(float3 HPAMHMBDLLL)
	{
		return default(CGFCFGONJIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5BF0", Offset = "0x7CD41F0", VA = "0x187CD5BF0")]
	private float4 AKLGOLCHIDL(CGFCFGONJIJ FIFJOOIEEIG, int OHHMJGCBCKD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6FA0", Offset = "0x7CD55A0", VA = "0x187CD6FA0")]
	private float2 NOFACCIHIBB(CGFCFGONJIJ FIFJOOIEEIG, float3 EPCLGOKLIPO)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HGNFDNHGFNE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum IBEEEDAIOKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static HGNFDNHGFNE KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 MJJFMHOFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 GMKIGHDIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 EOMGDLMNCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public IBEEEDAIOKP KFIKOGBAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 IHNMKLFBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 IDKAMCGADAM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB020", Offset = "0x7CD9620", VA = "0x187CDB020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 OFCFOHFJKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7CDAD60", Offset = "0x7CD9360", VA = "0x187CDAD60")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB520", Offset = "0x7CD9B20", VA = "0x187CDB520")]
	public HGNFDNHGFNE(float3 EPCLGOKLIPO, quaternion OOBEGCNALKF, float3 CFNMLMNHCMF, IBEEEDAIOKP MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB030", Offset = "0x7CD9630", VA = "0x187CDB030")]
	public float MLIOFJCKHOC(float3 HNHGJPFCFDL, float MHCEINMANFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAF30", Offset = "0x7CD9530", VA = "0x187CDAF30")]
	public bool FHFCDEPAPJK(float3 HPAMHMBDLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CDABB0", Offset = "0x7CD91B0", VA = "0x187CDABB0")]
	public void CBGEOMILEDK(float3 DCHPIGDNFHF, float3x3 OFAKPAGIBDN, float FBEPAIJDGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAE40", Offset = "0x7CD9440", VA = "0x187CDAE40")]
	private void DOKCLGNKLJE(float3 DJHCIGKJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB230", Offset = "0x7CD9830", VA = "0x187CDB230")]
	public void NILOHKOLAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct LGIIKECFANG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<HGNFDNHGFNE> APDBNIMCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> JKHPLKICGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> HKHJDBHLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KJGCGJFEJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<HLKPJJDGGOK> LEEFHEAECNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int GIHCBHDONIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int NMFMBMCICJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float MHCEINMANFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float NPALMFMFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DIFGFOJACKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IGHIIACHBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> PHOKMKANBFJ;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7800", Offset = "0x7CE5E00", VA = "0x187CE7800")]
	public LGIIKECFANG(OFNFOCEBPOF PEPFHNJFNIL, float DNINFCHAJMI, int NGFMNKONPKM, int PDEKGNANDEB, NativeList<HGNFDNHGFNE> APDBNIMCPID, NativeArray<int> KJGCGJFEJCF, NativeList<HLKPJJDGGOK> LEEFHEAECNB, KCFHOMPPIJH JJJNFMILJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7000", Offset = "0x7CE5600", VA = "0x187CE7000", Slot = "4")]
	public void Execute(int KMNFDAIOCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7740", Offset = "0x7CE5D40", VA = "0x187CE7740")]
	private bool PPGHOHFFCMH(HGNFDNHGFNE FDJHCIBLFFB, HGNFDNHGFNE CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6D70", Offset = "0x7CE5370", VA = "0x187CE6D70")]
	private bool CDKDMDOBGAD(HGNFDNHGFNE IAEAOGJCDGG, int ILPJJHLCFBO, int JKKBDCFBJEF, int PFLPIBLLFOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct CJPAMJBNPJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<KIEGPPHBLFN.KENJAAMBBKH> AAHJHDLNKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> MMCINHLJGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int NANJPDDHIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int PEBJFIBPPOJ;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2DA0", Offset = "0x7CD13A0", VA = "0x187CD2DA0")]
	public CJPAMJBNPJC(NativeList<KIEGPPHBLFN.KENJAAMBBKH> AAHJHDLNKPC, NativeArray<int> MMCINHLJGKF, int PEBJFIBPPOJ = 0, int NANJPDDHIPF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2CF0", Offset = "0x7CD12F0", VA = "0x187CD2CF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class KCFHOMPPIJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> CJNFLAMOKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> GGOOGIMDAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> ABCJHGAALDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> KBIJJOIMHJE;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2770", Offset = "0x7CE0D70", VA = "0x187CE2770")]
	public void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2660", Offset = "0x7CE0C60", VA = "0x187CE2660")]
	public static long CIHFDHJPMDB(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2680", Offset = "0x7CE0C80", VA = "0x187CE2680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2890", Offset = "0x7CE0E90", VA = "0x187CE2890")]
	public void NNOHEEPCFHD(JobHandle GMNPCPDAADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KCFHOMPPIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct NKAEONOKLPM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> JKHPLKICGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> LGPLODMABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> ADKCNGCNOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> HKHJDBHLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> JIJJDJPODNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> DIFGFOJACKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> IGHIIACHBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int NANJPDDHIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int PEBJFIBPPOJ;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CE83D0", Offset = "0x7CE69D0", VA = "0x187CE83D0")]
	public NKAEONOKLPM(OFNFOCEBPOF PEPFHNJFNIL, KCFHOMPPIJH JJJNFMILJFE, int PEBJFIBPPOJ = 0, int NANJPDDHIPF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7FF0", Offset = "0x7CE65F0", VA = "0x187CE7FF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7F90", Offset = "0x7CE6590", VA = "0x187CE7F90")]
	private void EHCFKBGMAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class OHMOJFHAKKH
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x39EF950", Offset = "0x39EDF50", VA = "0x1839EF950")]
	public static bool GLNJLHBIKLI<T>(NativeArray<T> NBBLCIBNPBK, int CFNMLMNHCMF, Allocator NDFENJBGNOB, NativeArrayOptions BFEGEHMOFBB = NativeArrayOptions.ClearMemory, int FFGKPGJAGLC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x39EFAD0", Offset = "0x39EE0D0", VA = "0x1839EFAD0")]
	public static bool GLNJLHBIKLI<T>(NativeList<T> OLEDHEBBJPH, int CFNMLMNHCMF, Allocator NDFENJBGNOB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x39EFB90", Offset = "0x39EE190", VA = "0x1839EFB90")]
	public static bool GLNJLHBIKLI<T>(NativeQueue<T> GNDKFGDDNMM, Allocator NDFENJBGNOB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum OEDNPOAFIDC
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
public interface NGPLIHHOGDL
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LPKLAPIICAF(OEDNPOAFIDC GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GGOEFFEMMHB(OEDNPOAFIDC GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDIOIEALNPI DNNHBCPOLFN();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float EBJAGBCCIDO();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FGFLHJBLLGI(int NDPPODJFHJD);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class GOPIJJECFOC
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7710", Offset = "0x7CD5D10", VA = "0x187CD7710")]
	public static void DMLDIIKDBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class EOAHKPEMMBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> HOBJGDJLFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> ADHEBJIOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> CLEFMOAOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> CMOFGFBCGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> FHEDBCABJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> LIDDKEBGJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> DMCOIHNKHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> JEPFFFGHPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> JHJMFPLBLBC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7CD54C0", Offset = "0x7CD3AC0", VA = "0x187CD54C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4FB0", Offset = "0x7CD35B0", VA = "0x187CD4FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CDDHBHBHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4FF0", Offset = "0x7CD35F0", VA = "0x187CD4FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5500", Offset = "0x7CD3B00", VA = "0x187CD5500")]
	public EOAHKPEMMBH(int DIGNHEFBOML, int FNBPJBGCLCH, int KAKPOFOFIMJ, Allocator NDFENJBGNOB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5820", Offset = "0x7CD3E20", VA = "0x187CD5820")]
	public EOAHKPEMMBH(Mesh PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CD45F0", Offset = "0x7CD2BF0", VA = "0x187CD45F0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4C80", Offset = "0x7CD3280", VA = "0x187CD4C80")]
	public void FMLNAEFDMPJ(EOAHKPEMMBH PEPFHNJFNIL, bool NDFHEDFGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5030", Offset = "0x7CD3630", VA = "0x187CD5030")]
	private void LFEIDICIOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4710", Offset = "0x7CD2D10", VA = "0x187CD4710")]
	private void FALFHKKGDMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct HLKPJJDGGOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int FFEGLHMMBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int DCHGDNOGAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int ADNMMNCICIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int BGNONGNFGEP;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F3ADD0", Offset = "0x1F393D0", VA = "0x181F3ADD0")]
	public HLKPJJDGGOK(int PDEKGNANDEB, int NPGNODKKKAD, int NGFMNKONPKM, int PCGPKCCHANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class HEFAOEOOFNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<HLKPJJDGGOK> LIODDEKBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HLKPJJDGGOK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EOAHKPEMMBH LNGKDJGKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA600", Offset = "0x7CD8C00", VA = "0x187CDA600")]
	public HEFAOEOOFNP(IEnumerable<EOAHKPEMMBH> LHHLMCNOLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA590", Offset = "0x7CD8B90", VA = "0x187CDA590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum EGAMEBEHMLC
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class LHCGJJEANFI
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> MGBNHMBNAIC;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> ILGBLMDEPLG;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> IFODDOOGGEG;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> FMEEALIELPM;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDFB0", Offset = "0x7CFC5B0", VA = "0x187CFDFB0")]
	public static void DMLDIIKDBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE3C0", Offset = "0x7CFC9C0", VA = "0x187CFE3C0")]
	public static NativeArray<float2> IIOPPMILMDC(NativeArray<float2> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<float2> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE1C0", Offset = "0x7CFC7C0", VA = "0x187CFE1C0")]
	public static NativeArray<float3> ICCJMNAJBGM(NativeArray<float3> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<float3> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE0C0", Offset = "0x7CFC6C0", VA = "0x187CFE0C0")]
	public static NativeArray<float4> GIIMAMPFHJI(NativeArray<float4> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<float4> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE2C0", Offset = "0x7CFC8C0", VA = "0x187CFE2C0")]
	public static NativeArray<int> IHHKEHMPOKL(NativeArray<int> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<int> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x39158C0", Offset = "0x3913EC0", VA = "0x1839158C0")]
	private static void HGPKPKKHHGD<T>(NativeArray<T> NBBLCIBNPBK, int EADJNMBLKGB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3915AC0", Offset = "0x39140C0", VA = "0x183915AC0")]
	private static void MDAEJMGBOLK<T>(NativeArray<T> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<T> FCPPEIDFJCI, int OOCBKAJLBEA, NativeArray<T> OKINGIIPKLM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class IGDJGOALOED
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct LCINGHBPBHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort CEJAAIDLEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort IMNDAJIDDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort NPJIMIIOHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort INJADOKLMJH;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF620", Offset = "0x7CEDC20", VA = "0x187CEF620")]
	public static uint MMJGNBPOAIL(float IMMJFOGEMML)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF410", Offset = "0x7CEDA10", VA = "0x187CEF410")]
	public static void JMAKEELBKHN(float4 LGPLODMABGM, float NMIFPOIKKGC, [Out] uint PAAMDIOPIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF520", Offset = "0x7CEDB20", VA = "0x187CEF520")]
	public static void JMAKEELBKHN(float4 LGPLODMABGM, uint CBNAJPDNLMO, [Out] uint PAAMDIOPIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CEED70", Offset = "0x7CED370", VA = "0x187CEED70")]
	public static void EIIKHCAGCIC(float3 PEJBFAIMGPM, float3 GGFHJLKGAPJ, float4 NJFMHOCNFOJ, float2 HJOLBLABKBE, float4 LGPLODMABGM, [Out] OFNFOCEBPOF.FBAFEBCICFD LLONNDJOFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEB10", Offset = "0x7CED110", VA = "0x187CEEB10")]
	public static void EIIKHCAGCIC(float3 PEJBFAIMGPM, float3 GGFHJLKGAPJ, float4 NJFMHOCNFOJ, float2 HJOLBLABKBE, float4 LGPLODMABGM, [Out] OFNFOCEBPOF.IMGNLKODGID LLONNDJOFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEAC0", Offset = "0x7CED0C0", VA = "0x187CEEAC0")]
	public static byte BHJBMAOFJGN(float OHLIHBDBKCE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF110", Offset = "0x7CED710", VA = "0x187CEF110")]
	public static ushort GPHHEDJILJJ(float OHLIHBDBKCE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF5F0", Offset = "0x7CEDBF0", VA = "0x187CEF5F0")]
	public static uint KFACFEJOHOC(float OHLIHBDBKCE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF630", Offset = "0x7CEDC30", VA = "0x187CEF630")]
	public static float2 PFJAKJPNNFA(float2 IINHKHEMEHJ)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF2C0", Offset = "0x7CED8C0", VA = "0x187CEF2C0")]
	public static float2 IIOKDEOCNNN(float3 KLJKHLHNLGP)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEFC0", Offset = "0x7CED5C0", VA = "0x187CEEFC0")]
	public static void EPMHANPBBGG(float3 OHLIHBDBKCE, [Out] float3 KOJNCDLOJGM, [Out] uint3 INJADOKLMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF160", Offset = "0x7CED760", VA = "0x187CEF160")]
	public static LCINGHBPBHP IAHDJBCMBBJ(float3 EPCLGOKLIPO)
	{
		return default(LCINGHBPBHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class PDHMGHPIAHL
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker DPCGKHCJHLG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float INMMOIEDEBE;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void ODFMLCAGHLK(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D03AF0", Offset = "0x7D020F0", VA = "0x187D03AF0")]
	public static float CDLNNDCENDL(float PIBHOPJHMPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D040A0", Offset = "0x7D026A0", VA = "0x187D040A0")]
	public static long LNBOAKOKHDL(float PIBHOPJHMPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D03C00", Offset = "0x7D02200", VA = "0x187D03C00")]
	public static void KFJOABALDDM(float PIBHOPJHMPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface HLLMMEMBNDA
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFJOABALDDM(float PMHPPNJMJJN);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) CHGILEAHEJJ(float CNANLLHEMMH);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class KLHEOPKEPNB
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum EFDIDNEFLNE
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
	private class PKAOLOGBKKE : FDEHLHMPJGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public EFDIDNEFLNE MLCOGCMJLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public BatchedMeshRenderer GNGHHGBBENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public OKLBNCJDEJN MDMBKCJOCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public KIEGPPHBLFN MFGCAEHJHKA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override float MHNIDGOLKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCE0", Offset = "0x10BE2E0", VA = "0x1810BFCE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x17465B0", Offset = "0x1744BB0", VA = "0x1817465B0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7D04260", Offset = "0x7D02860", VA = "0x187D04260", Slot = "7")]
		public override void CENANGHIOME([Out] bool NCEFFKFNEKF, [Out] bool LACHMIBFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PKAOLOGBKKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int KDDBBGOLFMN;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int ENIHFLIAGFN;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int ICFAPAGPKEG;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long EDLGCECFPJD;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long PPBHCKLKLDE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long FOCJNGPBPPM;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long FKKMGNEKDBC;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int LJCELHDOFPP;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float OBGOOBJOIAJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool OHBPOJHHAFN;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int HHGBFFDMHNM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int AGNAMLJOEKJ;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int HJGLEKNFNGN;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long GMIEDHLNAJC;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int BFHGADJPGKO;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool NIKGGNFAKGG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static uint MGDKMLBPBAK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static CINPCFHNKEE GCHCLDFPPLC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static List<uint> JCIBHKFHDEM;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static HLLMMEMBNDA KJKEHBDEPEM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool EBGPEBAPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA780", Offset = "0x7CF8D80", VA = "0x187CFA780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void ODFMLCAGHLK(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON, string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD810", Offset = "0x7CFBE10", VA = "0x187CFD810")]
	public static void KHOHAHNIDCC(HLLMMEMBNDA CHMAPGDFMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA020", Offset = "0x7CF8620", VA = "0x187CFA020")]
	public static (long, long, long, int, int) BGLGAFLABFB(long PEALIDAKJHK)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA5E0", Offset = "0x7CF8BE0", VA = "0x187CFA5E0")]
	public static void EBOOPHMGPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7CFB6C0", Offset = "0x7CF9CC0", VA = "0x187CFB6C0")]
	public static void KFJOABALDDM(long PEALIDAKJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAD60", Offset = "0x7CF9360", VA = "0x187CFAD60")]
	public static void HLFIAJOJEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDB00", Offset = "0x7CFC100", VA = "0x187CFDB00")]
	public static long PALMNFJKMNN(long EGAJOCMKJMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7CFB090", Offset = "0x7CF9690", VA = "0x187CFB090")]
	public static bool IBEJENGKFKL(long DKPCCCOICNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD880", Offset = "0x7CFBE80", VA = "0x187CFD880")]
	public static bool KIAAKBDMJOI(long DKPCCCOICNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7CFB160", Offset = "0x7CF9760", VA = "0x187CFB160")]
	public static float IIADEAEDMOD(long HHEINPINFCI, int NEDAFANGOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA1E0", Offset = "0x7CF87E0", VA = "0x187CFA1E0")]
	public static (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA7D0", Offset = "0x7CF8DD0", VA = "0x187CFA7D0")]
	public static void GOJGPDGPLCL(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float BGMGMDOKLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7CFB540", Offset = "0x7CF9B40", VA = "0x187CFB540")]
	public static void KEPDLMNEFME(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float EJEMMHMJBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD950", Offset = "0x7CFBF50", VA = "0x187CFD950")]
	public static void KLKFMBDMNLI(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long CGJDFBAGDGJ, float EJEMMHMJBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAEE0", Offset = "0x7CF94E0", VA = "0x187CFAEE0")]
	public static void HNGOHKHDFBM(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float EJEMMHMJBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAA70", Offset = "0x7CF9070", VA = "0x187CFAA70")]
	private static void HFJECCHCBKO(EFDIDNEFLNE MLCOGCMJLBB, KIEGPPHBLFN MFGCAEHJHKA, OKLBNCJDEJN MDMBKCJOCLD, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float FLCLOHJLIBD, bool HIPGEMGOHFB, bool EJDLPFHEGFC, float DPEJEDCKJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA660", Offset = "0x7CF8C60", VA = "0x187CFA660")]
	public static bool ENMBNGPPIBO(float IGNCNIBEICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA710", Offset = "0x7CF8D10", VA = "0x187CFA710")]
	public static void GIEHHKCPPHG(float IGNCNIBEICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA960", Offset = "0x7CF8F60", VA = "0x187CFA960")]
	public static bool HEFEMCKNCCN(float IGNCNIBEICE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class FDEHLHMPJGG : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum OBLMBOCLCEG : byte
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
	public OBLMBOCLCEG OJBMBMIFMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public long CPGPBKMBLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public long CGJDFBAGDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public float CJHIJOLEKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool EJDLPFHEGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool HIPGEMGOHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal uint HJPLNJNIFLL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract float MHNIDGOLKKJ
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
	public abstract void CENANGHIOME([Out] bool NCEFFKFNEKF, [Out] bool LACHMIBFIEN);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE990", Offset = "0x7CECF90", VA = "0x187CEE990", Slot = "4")]
	public int CompareTo(object BOMDCGFKGKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected FDEHLHMPJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class CINPCFHNKEE : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private List<FDEHLHMPJGG> IKCMEGKIGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private List<FDEHLHMPJGG> EBONJAHAOFO;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE670", Offset = "0x7CECC70", VA = "0x187CEE670")]
	public void IIGLPCDPOEE(FDEHLHMPJGG HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE550", Offset = "0x7CECB50", VA = "0x187CEE550")]
	public void EGGGPIHMFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE740", Offset = "0x7CECD40", VA = "0x187CEE740")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE200", Offset = "0x7CEC800", VA = "0x187CEE200")]
	public void AMELJKOKMEP(IEnumerable<uint> JCIBHKFHDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE5B0", Offset = "0x7CECBB0", VA = "0x187CEE5B0")]
	private void GNAALOCCJEL(uint HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE830", Offset = "0x7CECE30", VA = "0x187CEE830", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE7D0", Offset = "0x7CECDD0", VA = "0x187CEE7D0")]
	public AOCOENCHLCP OMLAPONJPHN()
	{
		return default(AOCOENCHLCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE8D0", Offset = "0x7CECED0", VA = "0x187CEE8D0")]
	public CINPCFHNKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct AOCOENCHLCP : IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private List<FDEHLHMPJGG> IKCMEGKIGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private List<FDEHLHMPJGG> EBONJAHAOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int LEPCGACCHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private int DGJOKAHHPOD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB860", Offset = "0x7CE9E60", VA = "0x187CEB860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FDEHLHMPJGG FFKIBMLIABP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB540", Offset = "0x7CE9B40", VA = "0x187CEB540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB870", Offset = "0x7CE9E70", VA = "0x187CEB870")]
	public AOCOENCHLCP(List<FDEHLHMPJGG> IKCMEGKIGHA, List<FDEHLHMPJGG> EBONJAHAOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB6C0", Offset = "0x7CE9CC0", VA = "0x187CEB6C0", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB850", Offset = "0x7CE9E50", VA = "0x187CEB850", Slot = "6")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class OKLBNCJDEJN
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	internal enum IPMJJNHCILH
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
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly string PGFLPNJOEPJ;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly string IKNDBHDGGDB;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker FNAJPENHMLH;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker LCBOJDFKNOD;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker DPCGKHCJHLG;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker FJOAAEBIDPB;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker MICOIJLNCCP;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker ABAEJANLMAB;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker JFPCJBHEKAE;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker MPHJOIFFBFK;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker DGFFFJILGNE;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker DLFAKAPAPPO;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker NFFLLLJMBPO;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker ENNGHFOPOFG;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker FFKIDFLCHPP;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker MOIFJEBHJCI;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker BDHCHEGNFHJ;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker HFMJMFBNFJF;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker GBKPMIODOKH;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker GCEAIMMJLKK;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly ProfilerMarker IHBDDLHEBGF;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly ProfilerMarker HPKIMBECMBA;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly ProfilerMarker EBGLJMEHBBG;

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static readonly ProfilerMarker KMFPNFNJLDH;

	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private static readonly ProfilerMarker JPKDJCHJCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly ProfilerMarker PAEMPBBKHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal readonly List<KIEGPPHBLFN> BCKJDJNALEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal KIEGPPHBLFN AHAFOOKHLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly JMJECAHGFJF JCJFJOJNKFG;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public const bool GAPGOHJAAKC = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public bool BILPGNOAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	internal IPMJJNHCILH DJKDJIIOKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	internal int DHEHBEBJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	internal int PPKEMHGDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	internal int LGEFBLLCGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	internal int PJGJFPDHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	internal long JOFBFDNOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal long GMLDMLHBDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal long NHOEOPHPELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private OFNFOCEBPOF KOLJDAHJPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private OFNFOCEBPOF GBCONBGDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OFNFOCEBPOF.LEBCKMKDBPC COJNCIPFOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private bool GBCCGEKFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private int CHOOKLMEMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private ABCMFHEJJCN GJILMBCILAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private float3 DJBCCFDDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private float OJHDMDBMBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private float LIDFPCDMLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private float PIEHDDOAAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private float KDIMKMDPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private float BEDHIPHEFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float AKEKJELKIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private float3 PDABGDDCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float MJEOABFFPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private float BFLHELODNEF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal Mesh LNGKDJGKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MeshFilter PIMGPMNEIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MeshRenderer BGCKPPIPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<Material> EOJLILILMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DBDFEINPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7D002E0", Offset = "0x7CFE8E0", VA = "0x187D002E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KJBPKKGOPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7D02C70", Offset = "0x7D01270", VA = "0x187D02C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7D00A70", Offset = "0x7CFF070", VA = "0x187D00A70")]
	public void IDCDIEPLCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7D01D10", Offset = "0x7D00310", VA = "0x187D01D10")]
	public bool LDCHGOPEJAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D00380", Offset = "0x7CFE980", VA = "0x187D00380")]
	private void GJDFODNHJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7D00EC0", Offset = "0x7CFF4C0", VA = "0x187D00EC0")]
	private void JJANJBBCDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7D03950", Offset = "0x7D01F50", VA = "0x187D03950")]
	public OKLBNCJDEJN(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D02CA0", Offset = "0x7D012A0", VA = "0x187D02CA0")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7CFED40", Offset = "0x7CFD340", VA = "0x187CFED40")]
	private void CEHJGLHOEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C30", Offset = "0x7CFF230", VA = "0x187D00C30")]
	private void IOAAMJGJDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D00BA0", Offset = "0x7CFF1A0", VA = "0x187D00BA0")]
	public Mesh IDJNOLAGOHG(MeshFilter HEEKELAELBC, Transform KOOMPFGMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7CFEAE0", Offset = "0x7CFD0E0", VA = "0x187CFEAE0")]
	private void BJEHFPNNCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7D004A0", Offset = "0x7CFEAA0", VA = "0x187D004A0")]
	public void GKAHHFADIKG(NGPLIHHOGDL CKADCHJDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7D01F70", Offset = "0x7D00570", VA = "0x187D01F70")]
	public bool LJCLACKMCGP(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF720", Offset = "0x7CFDD20", VA = "0x187CFF720")]
	public bool DGAEJOHLCDJ(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7D02B50", Offset = "0x7D01150", VA = "0x187D02B50", Slot = "4")]
	public virtual void NCJBLPKGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7CFFC90", Offset = "0x7CFE290", VA = "0x187CFFC90")]
	public void EDHIDPPEGOP(Transform HGJDCEPMKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7D00620", Offset = "0x7CFEC20", VA = "0x187D00620")]
	public bool HFFKNJPAFNM(Transform HGJDCEPMKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7CFEDE0", Offset = "0x7CFD3E0", VA = "0x187CFEDE0")]
	public bool CFJAKFPLIMB(bool NFBBHICBOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF9F0", Offset = "0x7CFDFF0", VA = "0x187CFF9F0")]
	private void DLJLODJEICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7D01010", Offset = "0x7CFF610", VA = "0x187D01010")]
	public bool KFJOABALDDM(float4x4 LGKMMMDABOH, BatchedMeshRenderer FFMJKENGIND, bool GJIIIIPFFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE4C0", Offset = "0x7CFCAC0", VA = "0x187CFE4C0")]
	public bool ACODGKFBDLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF9B0", Offset = "0x7CFDFB0", VA = "0x187CFF9B0")]
	public void DLCLDGNEFOA(OFNFOCEBPOF PEPFHNJFNIL, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7D00300", Offset = "0x7CFE900", VA = "0x187D00300")]
	public (long, long, long) GEBEHCBKDIL()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
	public long BHOHLEFECOC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF600", Offset = "0x7CFDC00", VA = "0x187CFF600")]
	private void CJBIHHKBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF390", Offset = "0x7CFD990", VA = "0x187CFF390")]
	public (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ, float4x4 LGKMMMDABOH)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7CFEBE0", Offset = "0x7CFD1E0", VA = "0x187CFEBE0")]
	internal void BODCAGEIIMC(IPMJJNHCILH FNMJJEKIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7D02420", Offset = "0x7D00A20", VA = "0x187D02420")]
	internal (float, float, float, float) MGHFPLJMBBH(float FJFDDHAMEMN, float4x4 LGKMMMDABOH)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7CFFA70", Offset = "0x7CFE070", VA = "0x187CFFA70")]
	public void EBPHGGHMLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7CFF7B0", Offset = "0x7CFDDB0", VA = "0x187CFF7B0")]
	private void DIJNINBJOCB(OFNFOCEBPOF FILHENAJMCB, OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7D02B30", Offset = "0x7D01130", VA = "0x187D02B30")]
	private void MOJMHHDDPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE9D0", Offset = "0x7CFCFD0", VA = "0x187CFE9D0")]
	internal bool AIKMBJDBOND(bool NFBBHICBOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7D00000", Offset = "0x7CFE600", VA = "0x187D00000")]
	private void FBMLNMAJAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7D02040", Offset = "0x7D00640", VA = "0x187D02040")]
	private void MELEPHGOLNJ([In] DJEOHGJJNMK FILHENAJMCB, OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7CFEC00", Offset = "0x7CFD200", VA = "0x187CFEC00")]
	private void BPKOIIOOEGI(OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7CFECA0", Offset = "0x7CFD2A0", VA = "0x187CFECA0")]
	private void CANENMFBHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7D01E30", Offset = "0x7D00430", VA = "0x187D01E30")]
	private void LEAOEBJLOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7D02FE0", Offset = "0x7D015E0", VA = "0x187D02FE0")]
	public long PALMNFJKMNN(long EGAJOCMKJMK, int JOGNGOBMBGL)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class KIEGPPHBLFN
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum KJKDKCHNEAG
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
	public struct KENJAAMBBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int EKBPMBFJFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int FMDPDNGNNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public float GEOHFENLFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct IPFDINKKAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public DJEOHGJJNMK PEPFHNJFNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int LCHLGDKJDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int JKIIGAFGOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public long CPDNGBOPBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public long ODHBKBHJMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public float BFCALILILML;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF730", Offset = "0x7CEDD30", VA = "0x187CEF730")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7CEF760", Offset = "0x7CEDD60", VA = "0x187CEF760")]
		public void NNOHEEPCFHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly string PGFLPNJOEPJ;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly string IKNDBHDGGDB;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker FNAJPENHMLH;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker LCBOJDFKNOD;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker DPCGKHCJHLG;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker FJOAAEBIDPB;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker MICOIJLNCCP;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker ABAEJANLMAB;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker JFPCJBHEKAE;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker MPHJOIFFBFK;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker DGFFFJILGNE;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker DLFAKAPAPPO;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly ProfilerMarker NFFLLLJMBPO;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly ProfilerMarker ENNGHFOPOFG;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly ProfilerMarker FFKIDFLCHPP;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly ProfilerMarker MOIFJEBHJCI;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly ProfilerMarker BDHCHEGNFHJ;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly ProfilerMarker HFMJMFBNFJF;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly ProfilerMarker GBKPMIODOKH;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly ProfilerMarker GCEAIMMJLKK;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static readonly ProfilerMarker IHBDDLHEBGF;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly ProfilerMarker HPKIMBECMBA;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ProfilerMarker EBGLJMEHBBG;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ProfilerMarker KMFPNFNJLDH;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly ProfilerMarker JPKDJCHJCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly ProfilerMarker PAEMPBBKHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal readonly List<NGPLIHHOGDL> PPBIAJGFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal OKLBNCJDEJN COOHKPAHMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private readonly JMJECAHGFJF JCJFJOJNKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal int AIPIIJPJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	internal int CLHEPMAODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal bool AKMIKPJCPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal bool JGKHLJOIEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal KJKDKCHNEAG DJEALEBAKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal bool DAOGILHBBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	internal float3 PLLIPJINCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal float3 LBJGFMAKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal float ADGLAAPPBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int AJLPCMCJBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal int DNODFBPLGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal float LDOEAOHAIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal float MACMBEFBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal int NJALEADMPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal long DFJAIOFHHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public int MNMDCGFDOJG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal const int MFHBAMDGDDB = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal float[] NFPHBEFEELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal int[] OALCIJEAPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal long[] BLIKNHIEOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public List<IPFDINKKAHO> GFKMIFKJBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal OFNFOCEBPOF BHEEMNLAGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal long LNBPHLJMFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal int HKIGKOFCDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal float CMAEJNPNCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal OFNFOCEBPOF.LEBCKMKDBPC MGIEJFJPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal bool MNKEHMLJCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	internal JHGLNBKNNFF FPJMMFBBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	internal JobHandle HEGCFMLHGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	internal NativeList<KENJAAMBBKH> NNGFLGLIBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	internal NativeArray<long> FKLALGKOOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	internal bool ECOBMJBBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	internal JobHandle CBAKBHOPEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	internal OFNFOCEBPOF NOILONCKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	internal KCFHOMPPIJH BHPNPBDDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	internal NativeList<KENJAAMBBKH> OFLGMNLFJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	internal Transform EDEIOKDDPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	internal OEDNPOAFIDC ENPAKIMCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	internal long OAODDOGCPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal long EOPDNPNNDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	internal long CFDNAGMOCMG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<NGPLIHHOGDL> EMLDEFIHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7CF88F0", Offset = "0x7CF6EF0", VA = "0x187CF88F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6460", Offset = "0x7CF4A60", VA = "0x187CF6460")]
	internal void IDCDIEPLCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5310", Offset = "0x7CF3910", VA = "0x187CF5310")]
	internal void GJDFODNHJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7CF9D00", Offset = "0x7CF8300", VA = "0x187CF9D00")]
	internal KIEGPPHBLFN(string NFHOBPDKIPM, OKLBNCJDEJN JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7CF8910", Offset = "0x7CF6F10", VA = "0x187CF8910")]
	internal void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0E50", Offset = "0x7CEF450", VA = "0x187CF0E50")]
	internal void BJEHFPNNCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7CF54D0", Offset = "0x7CF3AD0", VA = "0x187CF54D0")]
	internal void GKAHHFADIKG(NGPLIHHOGDL CKADCHJDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7CF8000", Offset = "0x7CF6600", VA = "0x187CF8000")]
	internal bool LJCLACKMCGP(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3850", Offset = "0x7CF1E50", VA = "0x187CF3850")]
	internal bool DGAEJOHLCDJ(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7CF8860", Offset = "0x7CF6E60", VA = "0x187CF8860", Slot = "4")]
	internal virtual void NCJBLPKGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6470", Offset = "0x7CF4A70", VA = "0x187CF6470")]
	internal long IFBKDMCPCKM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1160", Offset = "0x7CEF760", VA = "0x187CF1160")]
	internal long CEJNIPGGGEA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5740", Offset = "0x7CF3D40", VA = "0x187CF5740")]
	internal bool HFFKNJPAFNM(Transform HGJDCEPMKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1270", Offset = "0x7CEF870", VA = "0x187CF1270")]
	internal (bool, OFNFOCEBPOF) CFJAKFPLIMB(bool NFBBHICBOCM)
	{
		return default((bool, OFNFOCEBPOF));
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF38E0", Offset = "0x7CF1EE0", VA = "0x187CF38E0")]
	internal void DLJLODJEICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF65B0", Offset = "0x7CF4BB0", VA = "0x187CF65B0")]
	internal bool KFJOABALDDM(float4x4 LGKMMMDABOH, BatchedMeshRenderer FFMJKENGIND, bool GJIIIIPFFAO, bool HCBIKIDPBJH, float LIDFPCDMLKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF7E0", Offset = "0x7CEDDE0", VA = "0x187CEF7E0")]
	public (bool, DJEOHGJJNMK) ACODGKFBDLM()
	{
		return default((bool, DJEOHGJJNMK));
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7CF63E0", Offset = "0x7CF49E0", VA = "0x187CF63E0")]
	internal void ICCLDHEADOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4FE0", Offset = "0x7CF35E0", VA = "0x187CF4FE0")]
	internal bool GAKAILLGOAH(bool NFBBHICBOCM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0200", Offset = "0x7CEE800", VA = "0x187CF0200")]
	internal void AKHNEANJAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7CF38B0", Offset = "0x7CF1EB0", VA = "0x187CF38B0")]
	internal void DLCLDGNEFOA(OFNFOCEBPOF PEPFHNJFNIL, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7CF35D0", Offset = "0x7CF1BD0", VA = "0x187CF35D0")]
	internal void DFAEJJMBBHF(DJEOHGJJNMK IBOMCMKODKN, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2300", Offset = "0x7CF0900", VA = "0x187CF2300")]
	internal void CJBIHHKBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1EA0", Offset = "0x7CF04A0", VA = "0x187CF1EA0")]
	internal (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ, float4x4 LGKMMMDABOH)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7CF10E0", Offset = "0x7CEF6E0", VA = "0x187CF10E0")]
	internal void BODCAGEIIMC(KJKDKCHNEAG FNMJJEKIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7CF8080", Offset = "0x7CF6680", VA = "0x187CF8080")]
	internal (float, float, float, float) MGHFPLJMBBH(float FJFDDHAMEMN, float4x4 LGKMMMDABOH)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF8A60", Offset = "0x7CF7060", VA = "0x187CF8A60")]
	private float NPAFOMEOIEI(float FJFDDHAMEMN, float4x4 LGKMMMDABOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF26F0", Offset = "0x7CF0CF0", VA = "0x187CF26F0")]
	private (int, int) COPNLBBCPGH(float KGGOMNHAOBH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4010", Offset = "0x7CF2610", VA = "0x187CF4010")]
	internal static float DOKLMOHCFGO(NGPLIHHOGDL PEPFHNJFNIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF40B0", Offset = "0x7CF26B0", VA = "0x187CF40B0")]
	internal void EBPHGGHMLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1130", Offset = "0x7CEF730", VA = "0x187CF1130")]
	internal void CANENMFBHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7CE0", Offset = "0x7CF62E0", VA = "0x187CF7CE0")]
	internal void LEAOEBJLOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7CF8AC0", Offset = "0x7CF70C0", VA = "0x187CF8AC0")]
	internal long PALMNFJKMNN(long EGAJOCMKJMK, int JOGNGOBMBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0210", Offset = "0x7CEE810", VA = "0x187CF0210")]
	private void BEFBAHLEKCI(OFNFOCEBPOF HGGCKJDDOHE, NativeList<KENJAAMBBKH> GEKDPOOGDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7CF9200", Offset = "0x7CF7800", VA = "0x187CF9200")]
	internal void PBOODEFIHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFB30", Offset = "0x7CEE130", VA = "0x187CEFB30")]
	public static void AHJIOGMHPPJ(NativeList<KENJAAMBBKH> DBLDEKKHPME, OFNFOCEBPOF HGGCKJDDOHE, int BNPNOAKCENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6520", Offset = "0x7CF4B20", VA = "0x187CF6520")]
	private float IGDICFLEAJN(int DEIGALACOAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2BA0", Offset = "0x7CF11A0", VA = "0x187CF2BA0")]
	internal void DDJEGJLCHON(OFNFOCEBPOF PEPFHNJFNIL, MCBEKGNCHGM IBOMCMKODKN, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BurstCompile]
internal struct BOHDEDACFHI : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal struct KBPLDIILAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int PMHEMKBIHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int JOMACOEKKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int BFNBHKLOKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public float OJFIOHPCCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float KEPMGPLCLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public float ODENFOCIAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public float LEDOGHHPLJD;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	internal struct FLAFLLPCELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int PMHEMKBIHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public int JOMACOEKKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int BFNBHKLOKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int CMCDFHLHMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public float OJFIOHPCCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public float KEPMGPLCLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public float AIPHGFOAILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public float OMKGIKGKCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public float LEDOGHHPLJD;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public struct FCPPCFEKBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int FFEADIJLAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int APELBFMPDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public float NIONLFLEEAC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public delegate void BEBCKLOBGPD(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class NBCDKONKCED
	{
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7D17C00", Offset = "0x7D16200", VA = "0x187D17C00")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7D17D20", Offset = "0x7D16320", VA = "0x187D17D20")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7D17B60", Offset = "0x7D16160", VA = "0x187D17B60")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7D17980", Offset = "0x7D15F80", VA = "0x187D17980")]
		public static void CIBKKMOJDEC(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate void ECKLPFMFLPB(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF);

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	internal static class COAKIGIKOBP
	{
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7D115E0", Offset = "0x7D0FBE0", VA = "0x187D115E0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7D11700", Offset = "0x7D0FD00", VA = "0x187D11700")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7D11540", Offset = "0x7D0FB40", VA = "0x187D11540")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D11360", Offset = "0x7D0F960", VA = "0x187D11360")]
		public static void CIBKKMOJDEC(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public unsafe delegate void NLGFDHEKIOF(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML);

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal static class IDDADCHBJCO
	{
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D13330", Offset = "0x7D11930", VA = "0x187D13330")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D13450", Offset = "0x7D11A50", VA = "0x187D13450")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D13290", Offset = "0x7D11890", VA = "0x187D13290")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D12F60", Offset = "0x7D11560", VA = "0x187D12F60")]
		public unsafe static void CIBKKMOJDEC(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public float3 DJBCCFDDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public float IGPPPLENBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public float BHDFPDNCIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public float IFPFOIMMOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public DJEMCOGPGPN.MOIMOJMJGIK CFMNIDCDCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public bool IPCDMMKHJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<KBPLDIILAHM>* DAABNPFNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<KBPLDIILAHM>* NADDILLPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FLAFLLPCELD>* CHNHGGPIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FLAFLLPCELD>* NOOJNILKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public int NFNGHJPKMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public int LJPNLOJEPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public int JINMGHBPDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe float3* PNKEBNMKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe int* KBHGLKELPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe FCPPCFEKBJB* NOMCIBPFMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7CECA00", Offset = "0x7CEB000", VA = "0x187CECA00")]
	private static float FGGGHOFDHKK([In] BOHDEDACFHI CGEOHHFDFLP, [In] float3 PLHNJIACDML, float LEDOGHHPLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE020", Offset = "0x7CEC620", VA = "0x187CEE020")]
	private static int JNPFOJKAMCK(BOHDEDACFHI CGEOHHFDFLP, [Out] BBKDCNPBHFC HDGKBLEEFBG, [In] BBKDCNPBHFC GEDOHNGAGEA, [In] BBKDCNPBHFC FHONHCNDHIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7CED7B0", Offset = "0x7CEBDB0", VA = "0x187CED7B0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void FNKDBOPAGMF(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE1A0", Offset = "0x7CEC7A0", VA = "0x187CEE1A0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private static void KHLKOEFNKOH(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC9F0", Offset = "0x7CEAFF0", VA = "0x187CEC9F0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7CECA80", Offset = "0x7CEB080", VA = "0x187CECA80")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal void FKEJBGGHEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC960", Offset = "0x7CEAF60", VA = "0x187CEC960")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	internal unsafe static void EOICMLPMDLF(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB8B0", Offset = "0x7CE9EB0", VA = "0x187CEB8B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void ABOFBAJCHME(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7CED810", Offset = "0x7CEBE10", VA = "0x187CED810")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public static void HOACFINEJLM(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC250", Offset = "0x7CEA850", VA = "0x187CEC250")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void EMCENIODHGJ(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class ABCMFHEJJCN
{
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly ProfilerMarker PNIFHDDONCC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public const int INKCMKMMMEN = 2;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private const int MOIKFFGJCGM = 1;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private static int OEOHDCDILNI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static Stack<ABCMFHEJJCN> DIAIIADFCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private OFNFOCEBPOF EACPFMONOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NativeList<BBKDCNPBHFC> EFGPMMFFANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NativeList<int> GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private NativeList<BOHDEDACFHI.KBPLDIILAHM> DAABNPFNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private NativeList<BOHDEDACFHI.KBPLDIILAHM> NADDILLPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private NativeList<BOHDEDACFHI.FLAFLLPCELD> CHNHGGPIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeList<BOHDEDACFHI.FLAFLLPCELD> NOOJNILKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private BOHDEDACFHI CGEOHHFDFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private JobHandle GMNPCPDAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private BOHDEDACFHI.FCPPCFEKBJB DPGHBGKGJJF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private const int JINMGHBPDOH = 65530;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D071E0", Offset = "0x7D057E0", VA = "0x187D071E0")]
	private ABCMFHEJJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D06450", Offset = "0x7D04A50", VA = "0x187D06450")]
	public void HMOCHDHCPJB(OFNFOCEBPOF KCAJOKAPNNO, float3 FFNEGGILCGD, float IJHICCMOGNJ, float LFNLKNCHBCA, float BKJCNPALMMN, List<KIEGPPHBLFN.KENJAAMBBKH> AMKCGFLMMEA, Allocator BHCMOBHIMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D06A40", Offset = "0x7D05040", VA = "0x187D06A40")]
	public (bool, OFNFOCEBPOF, float) LPOELFGCLHC(List<KIEGPPHBLFN.KENJAAMBBKH> AMKCGFLMMEA, Allocator BHCMOBHIMNL, bool NFBBHICBOCM)
	{
		return default((bool, OFNFOCEBPOF, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D06890", Offset = "0x7D04E90", VA = "0x187D06890")]
	public static bool JDFHOJOPABO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D063E0", Offset = "0x7D049E0", VA = "0x187D063E0")]
	public static int GKDFIBGHGBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D068E0", Offset = "0x7D04EE0", VA = "0x187D068E0")]
	public static ABCMFHEJJCN KGKKIMABGBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D07070", Offset = "0x7D05670", VA = "0x187D07070")]
	internal static void PAIJEJJJMFM(ABCMFHEJJCN PCPLJGHHMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D06280", Offset = "0x7D04880", VA = "0x187D06280")]
	public static void EDJCMGEEDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D060E0", Offset = "0x7D046E0", VA = "0x187D060E0")]
	[FELFDMPPKKE(MGEKOJDDIFB.ExitingPlayMode, 0)]
	public static void DMLDIIKDBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BurstCompile]
internal struct BBKDCNPBHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public float3 HNHGJPFCFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public int NBLENEGBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public int EGIENMMHOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public int HPMHNIMECMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public float OGHIHEEPHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public float DIOLJKHFBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public int ONNLBAOHLJN;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D07380", Offset = "0x7D05980", VA = "0x187D07380")]
	public static void FLLMCNLHKNL([Out] BBKDCNPBHFC OBOOAPELMPF, int EIEJGMPBHAI, [In] float3 JGKKPDAOHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D073D0", Offset = "0x7D059D0", VA = "0x187D073D0")]
	[IgnoreWarning(1371)]
	public static void FLLMCNLHKNL([Out] BBKDCNPBHFC OBOOAPELMPF, [In] BBKDCNPBHFC PPMLHPJGPIJ, [In] BBKDCNPBHFC IFMEGLHJPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BurstCompile]
internal struct JHGLNBKNNFF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct KCBPLANBOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int BCOFGICOGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int KIGCHGNGBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int PNDNCJCLMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int OMHDOAKHGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int AOHFPEEPFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int HMFKKFNJLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int LCHLGDKJDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int JKIIGAFGOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public float BFCALILILML;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private struct PDCMGHBBGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public DJEMCOGPGPN.ANDIJIKJCAA ALCPFHEBEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public float GLCINGIJOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public float JBCDBJBMFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public float JDHLPEACKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public float EADBFBOPBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public float CHBCJCPOKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public float BKKLOMILFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public float FNNEJEKAILK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private struct FFBGJKFJEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public NativeArray<float3> HOBJGDJLFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public NativeArray<float3> ADHEBJIOBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public NativeArray<float4> LHMIDMPAOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeArray<float4> IDEFIPDMGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public NativeArray<float2> GNBJGLIKPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public NativeArray<int> JHJMFPLBLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public bool CJAMNBEAIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int DCHGDNOGAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public int BGNONGNFGEP;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D12CC0", Offset = "0x7D112C0", VA = "0x187D12CC0")]
		public void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB, bool KLNAIMNEAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D12A70", Offset = "0x7D11070", VA = "0x187D12A70")]
		public static FFBGJKFJEMK HACIHALLGJB(OFNFOCEBPOF KIDPOMGFMKB)
		{
			return default(FFBGJKFJEMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D12EA0", Offset = "0x7D114A0", VA = "0x187D12EA0")]
		public void NNOHEEPCFHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private static readonly ProfilerMarker FFIHOLMGEOO;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private static readonly ProfilerMarker AIFECELLHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<KCBPLANBOOB> EIFIPCJALGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private FFBGJKFJEMK JKOBMMKKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private FFBGJKFJEMK HGGCKJDDOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private float3 DIOPGJLMJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private float3 EKNEHFNLAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private PDCMGHBBGDL LNCPHFLFMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* HPHGKKKPONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private NativeArray<KIEGPPHBLFN.KENJAAMBBKH> IOFPBEMJMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private NativeList<KIEGPPHBLFN.KENJAAMBBKH> PPNKNFKNDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private NativeArray<int> GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private NativeArray<bool> IGHIIACHBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private NativeArray<int> LMMFKHBJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private NativeArray<int> PNBGDJBMJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private NativeArray<float> ODBPBPBMPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NativeArray<int> CPKLNKJJAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private NativeArray<float> GMEHCDKAEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private NativeArray<int> DIKFIIKMHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private NativeArray<int> MBAOFNDAPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private NativeArray<float> GBNNMAMGJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private NativeArray<float> AGEPAEAIGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private NativeArray<int> OMNLELNDLMA;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D166E0", Offset = "0x7D14CE0", VA = "0x187D166E0")]
	public JHGLNBKNNFF([In] List<KIEGPPHBLFN.IPFDINKKAHO> OAODMDLEMGK, NativeList<KIEGPPHBLFN.KENJAAMBBKH> DAPPKLECPGN, [In] OFNFOCEBPOF KKGGOGIEMMO, [In] NativeList<KIEGPPHBLFN.KENJAAMBBKH> GEKDPOOGDIH, [In] NativeArray<long> FKLALGKOOLI, float3 NNIHLHEKIIO, float3 BOKCLNKNBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D14190", Offset = "0x7D12790", VA = "0x187D14190")]
	public static long HEGFHCAGMEP(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D137B0", Offset = "0x7D11DB0", VA = "0x187D137B0", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D158F0", Offset = "0x7D13EF0", VA = "0x187D158F0")]
	public void NFHFMOODOOF(List<KIEGPPHBLFN.IPFDINKKAHO> BIEHBDBDOBB, [In] KIEGPPHBLFN JHHOGAOOKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D163F0", Offset = "0x7D149F0", VA = "0x187D163F0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool PJICHAKKJIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D16410", Offset = "0x7D14A10", VA = "0x187D16410")]
	private DJEOHGJJNMK PKGKNNCNNIO(int BFHMHGDMJOG, Allocator NDFENJBGNOB)
	{
		return default(DJEOHGJJNMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D141B0", Offset = "0x7D127B0", VA = "0x187D141B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void KGFLMIFILME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D13800", Offset = "0x7D11E00", VA = "0x187D13800")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private float FHLMBKOBNMI(int MKBPNJMCCND, int GCNGLIJDKGH, bool MMNBDACEPAD, bool MHLBDAJDFJP, float IKNHDAMJPCE, float HCHLEGIHMHM, float MHILKPNDBBL, float GBFCDMJJAPN, float PNOOGGBIFCJ, float NNPEHBADGFK, float KNMPOKONKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D13E70", Offset = "0x7D12470", VA = "0x187D13E70")]
	[IgnoreWarning(1371)]
	private KCBPLANBOOB GBOBBLFADBF([In] KCBPLANBOOB KLPAJCMEKII, int GKPOADKKMDM, [In] NativeArray<int> HKHJDBHLOPP, [In] NativeArray<bool> IGHIIACHBOA, NativeArray<int> LMMFKHBJDIP)
	{
		return default(KCBPLANBOOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D135D0", Offset = "0x7D11BD0", VA = "0x187D135D0")]
	public static int EGAKBEKFIHE(NativeArray<int> HKHJDBHLOPP, NativeArray<int> OMNLELNDLMA, int MACBDDAMODJ, int GLEGNJIFIED, int IEDAHFFFKCJ)
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
		private struct IDJBAEFMABM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public long KFCNBMCPLCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public KDIOIEALNPI HJOECMEGBKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public NGPLIHHOGDL PEPFHNJFNIL;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7D135A0", Offset = "0x7D11BA0", VA = "0x187D135A0")]
			public IDJBAEFMABM(KDIOIEALNPI AGNPHNMIEFB, NGPLIHHOGDL FBMKLBOIHMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		private class EJKFCICPPBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public KDIOIEALNPI HJOECMEGBKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public int NPGNODKKKAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public float ADGLAAPPBIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public List<IDJBAEFMABM> LHHLMCNOLOM;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x7D129C0", Offset = "0x7D10FC0", VA = "0x187D129C0")]
			public EJKFCICPPBA(KDIOIEALNPI AGNPHNMIEFB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static readonly ProfilerMarker INKDJLIDIFI;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private static readonly ProfilerMarker IDOFHOPJDIJ;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private static readonly ProfilerMarker EKJPHMHNCLA;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private static readonly ProfilerMarker CDGPAKCOLEL;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private static readonly ProfilerMarker BOBDGAKPBBH;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly ProfilerMarker JFPCJBHEKAE;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker CDMBLMKELFA;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		internal const int OAEGIBLMNPI = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		internal static Dictionary<Material, List<Material>> KKCOLCNELLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Dictionary<Material, List<OKLBNCJDEJN>> NJKIHDOIKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		internal List<OKLBNCJDEJN> MAHLGJGPOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private List<MeshRenderer> IFBHHOGBBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private Transform KGPIBDKDEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool FADOJKIICHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private bool HJIHOEALKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int OKCGKMIDCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private OKLBNCJDEJN CDNKMLMMDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private Material JNIPHPEILEC;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static bool? BNKAHJNAFHA;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private const int BKFLAPOBIFM = 1024;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private static List<IDJBAEFMABM> PDGDBDPGBMC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<MeshRenderer> PIFPEDKKNGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int APEKNCGIPBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7D11310", Offset = "0x7D0F910", VA = "0x187D11310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private static bool JJLJKIAHCAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7D0C880", Offset = "0x7D0AE80", VA = "0x187D0C880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		private static void BOBFKAFJECN(bool MGJLPBKKAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		private static void BOBFKAFJECN(bool MGJLPBKKAON, string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		private static void BNPJCHBKEAI(string NFHOBPDKIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AF60", Offset = "0x7D09560", VA = "0x187D0AF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C9A0", Offset = "0x7D0AFA0", VA = "0x187D0C9A0")]
		internal bool KAMODMDPNIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DA60", Offset = "0x7D0C060", VA = "0x187D0DA60")]
		private Transform NKPNPPDHCJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DAE0", Offset = "0x7D0C0E0", VA = "0x187D0DAE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B2F0", Offset = "0x7D098F0", VA = "0x187D0B2F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AD50", Offset = "0x7D09350", VA = "0x187D0AD50")]
		public OKLBNCJDEJN AddToBatchedMesh(NGPLIHHOGDL OGGHKIMHDCK, Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D10DF0", Offset = "0x7D0F3F0", VA = "0x187D10DF0")]
		public void RemoveFromBatchedMesh(NGPLIHHOGDL PEPFHNJFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B0C0", Offset = "0x7D096C0", VA = "0x187D0B0C0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D9E0", Offset = "0x7D0BFE0", VA = "0x187D0D9E0")]
		private void NAKOPBNMDAP(Renderer CCKFDFMBDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C810", Offset = "0x7D0AE10", VA = "0x187D0C810")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C800", Offset = "0x7D0AE00", VA = "0x187D0C800")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B700", Offset = "0x7D09D00", VA = "0x187D0B700")]
		private void FOEGLMJNFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D450", Offset = "0x7D0BA50", VA = "0x187D0D450")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DAF0", Offset = "0x7D0C0F0", VA = "0x187D0DAF0")]
		private OKLBNCJDEJN PCNHDOEHBKM(NGPLIHHOGDL PEPFHNJFNIL, Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C4A0", Offset = "0x7D0AAA0", VA = "0x187D0C4A0")]
		private OKLBNCJDEJN IOMHMLGDBJJ(Material CANJBFKPEMF, int GDJHMFCCOAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D0CA00", Offset = "0x7D0B000", VA = "0x187D0CA00")]
		private OKLBNCJDEJN KLFLEEDNCLI(Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D250", Offset = "0x7D0B850", VA = "0x187D0D250")]
		internal float4x4 LHNFKBIAFPH()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BCC0", Offset = "0x7D0A2C0", VA = "0x187D0BCC0")]
		public static List<Material> GenerateVertexFormatVariants(Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x132AFB0", Offset = "0x13295B0", VA = "0x18132AFB0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D2F0", Offset = "0x7D0B8F0", VA = "0x187D0D2F0")]
		public void MarkDirty(NGPLIHHOGDL PEPFHNJFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B1F0", Offset = "0x7D097F0", VA = "0x187D0B1F0")]
		[Conditional("CHECK_STATE")]
		private void DAJOJALMHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D5D0", Offset = "0x7D0BBD0", VA = "0x187D0D5D0")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float PIBHOPJHMPJ)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AF90", Offset = "0x7D09590", VA = "0x187D0AF90")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FC90", Offset = "0x7D0E290", VA = "0x187D0FC90")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BDE0", Offset = "0x7D0A3E0", VA = "0x187D0BDE0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DE50", Offset = "0x7D0C450", VA = "0x187D0DE50")]
		public void RebatchOptimally(int KBBHJFBEOEF, int DEJDELGNNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DD80", Offset = "0x7D0C380", VA = "0x187D0DD80")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D111E0", Offset = "0x7D0F7E0", VA = "0x187D111E0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class BMMIIAFLHKB
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct JLOJHIHMCAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public BatchedMeshRenderer CCKFDFMBDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public OKLBNCJDEJN PEPFHNJFNIL;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x19F4C70", Offset = "0x19F3270", VA = "0x1819F4C70")]
		public void LJCOBGHNIAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct LGKKMFDCEHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public float EKONEIGCNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public OKLBNCJDEJN CJPKNPBCNMN;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class DAANEGLFNLM : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x1132F70", Offset = "0x1131570", VA = "0x181132F70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D12850", Offset = "0x7D10E50", VA = "0x187D12850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1285160", Offset = "0x1283760", VA = "0x181285160")]
		[DebuggerHidden]
		public DAANEGLFNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7D128A0", Offset = "0x7D10EA0", VA = "0x187D128A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7D118A0", Offset = "0x7D0FEA0", VA = "0x187D118A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7D11850", Offset = "0x7D0FE50", VA = "0x187D11850")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7D12700", Offset = "0x7D10D00", VA = "0x187D12700")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7D12800", Offset = "0x7D10E00", VA = "0x187D12800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7D12750", Offset = "0x7D10D50", VA = "0x187D12750", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7D12750", Offset = "0x7D10D50", VA = "0x187D12750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private static readonly ProfilerMarker JFPCJBHEKAE;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly ProfilerMarker FMJJDGKBDBC;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly ProfilerMarker LEHPOCCGDMG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly ProfilerMarker CNHPMNICAOL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static float3 NBANKJBDDHN;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static int PEIHKGCKEHP;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static int KNOFFNBLKHJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static int ANAGCCEFGEM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static int LGOHPCPJEBN;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int FFMPHJCHCDM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static float JNDLBCDPPFL;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static float PHELMBJFFMP;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static float NAJKMMMBCON;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static float APIGBLFPDAG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static float DKKOKCLNBML;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static float LIEEHNBHFEF;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static float HKNFIMLNAKF;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static float PLBFEBJGBOI;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static List<BatchedMeshRenderer> NLPDAEJHBCO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private static Stack<OFNFOCEBPOF> JNFABGKGMED;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private static Stack<KCFHOMPPIJH> JIBHFCPIFAL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static LGCPEOGBNJG BJFHMAIIJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static JLOJHIHMCAC IONLAKIKPAD;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static int GOGPJHLIHHL;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void ODFMLCAGHLK(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON, string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D07B20", Offset = "0x7D06120", VA = "0x187D07B20")]
	public static void EEBICEODLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D09C40", Offset = "0x7D08240", VA = "0x187D09C40")]
	public static void NOBAPAAKCFN(BatchedMeshRenderer FCNPIHMGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D092D0", Offset = "0x7D078D0", VA = "0x187D092D0")]
	public static void MGFANGEFBPK(BatchedMeshRenderer FCNPIHMGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D093F0", Offset = "0x7D079F0", VA = "0x187D093F0")]
	public static void MLAMOEJNJKC(NGPLIHHOGDL CKADCHJDBCK, bool IICMENMBKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D08DE0", Offset = "0x7D073E0", VA = "0x187D08DE0")]
	public static void LMNGDKBCMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D081F0", Offset = "0x7D067F0", VA = "0x187D081F0")]
	public static void KFJOABALDDM(float PIBHOPJHMPJ, bool CJDIFDICHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D07D20", Offset = "0x7D06320", VA = "0x187D07D20")]
	private static void JAHFAHPEGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D09FF0", Offset = "0x7D085F0", VA = "0x187D09FF0")]
	public static long PALMNFJKMNN(int JOGNGOBMBGL, long EGAJOCMKJMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D07750", Offset = "0x7D05D50", VA = "0x187D07750")]
	public static (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D076C0", Offset = "0x7D05CC0", VA = "0x187D076C0")]
	[IteratorStateMachine(typeof(DAANEGLFNLM))]
	public static IEnumerable<bool> AGPELJBAJBE(long GNHOOPBOHLL, bool JHOMJFLILMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D08B00", Offset = "0x7D07100", VA = "0x187D08B00")]
	public static void LKHLBAGODLL(long GNHOOPBOHLL, bool JHOMJFLILMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D09160", Offset = "0x7D07760", VA = "0x187D09160")]
	public static int LOAOPOGGAJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D07BA0", Offset = "0x7D061A0", VA = "0x187D07BA0")]
	internal static OFNFOCEBPOF EPFCBBFNHPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D09EC0", Offset = "0x7D084C0", VA = "0x187D09EC0")]
	internal static void PAIJEJJJMFM(OFNFOCEBPOF FPLCOEMPHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D09D80", Offset = "0x7D08380", VA = "0x187D09D80")]
	internal static KCFHOMPPIJH OGGCJFCKPJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7D09F60", Offset = "0x7D08560", VA = "0x187D09F60")]
	internal static void PAIJEJJJMFM(KCFHOMPPIJH JJJNFMILJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7D07960", Offset = "0x7D05F60", VA = "0x187D07960")]
	public static void EDJCMGEEDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class GMHENEKBFCA<KeyType> : OKLBNCJDEJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly Dictionary<KeyType, NGPLIHHOGDL> ILMOCGLICFJ;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF540", Offset = "0x4ACDB40", VA = "0x184ACF540")]
	public GMHENEKBFCA(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF470", Offset = "0x4ACDA70", VA = "0x184ACF470")]
	public void GKAHHFADIKG(KeyType OEHHKNIGGMI, NGPLIHHOGDL CKADCHJDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF0F0", Offset = "0x4ACD6F0", VA = "0x184ACF0F0")]
	public bool ABGKOHANAPD(KeyType OEHHKNIGGMI, NGPLIHHOGDL CELABBJHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF2D0", Offset = "0x4ACD8D0", VA = "0x184ACF2D0")]
	public void FKIPNLBHINN(KeyType OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF4E0", Offset = "0x4ACDAE0", VA = "0x184ACF4E0", Slot = "4")]
	public override void NCJBLPKGOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class MOFAAAHJOFC
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly ProfilerCategory EKNIIMOGGJF;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	internal static readonly ProfilerMarker IIADEAEDMOD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	internal static readonly BEDEOPJHJKF KFJOABALDDM;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly ECIHEKFBODF<float> MGAJBCLDHAG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly ECIHEKFBODF<float> EOMNOFEBLEH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private static readonly ECIHEKFBODF<double> OICLKDOEPMG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private static readonly ECIHEKFBODF<double> GGHHICCBCFK;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly ECIHEKFBODF<double> HFAKCKACPOK;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private static readonly ECIHEKFBODF<int> LAJDFIJOKLM;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private static readonly ECIHEKFBODF<int> HAKHFNPKMAK;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private static readonly ECIHEKFBODF<int> HCADJNCOMCL;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private static readonly ECIHEKFBODF<int> BODJLIIAAIL;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	private static readonly ECIHEKFBODF<int> ALFFMJKMFHF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private static readonly ECIHEKFBODF<long> LKNJBDAJCHH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly ECIHEKFBODF<long> BNGFPKOOGBG;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private static readonly ECIHEKFBODF<long> IPHJHEIJEEG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly ECIHEKFBODF<long> GPFNLGCHKMA;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private static readonly ECIHEKFBODF<long> NABBOMOLKIK;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7D16FB0", Offset = "0x7D155B0", VA = "0x187D16FB0")]
	public static void PHBDGACNPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7D18030", Offset = "0x7D16630", VA = "0x187D18030")]
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
