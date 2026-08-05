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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD090", Offset = "0x7CFC090", VA = "0x187CFD090", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF9550", Offset = "0x7CF8550", VA = "0x187CF9550")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9680", Offset = "0x7CF8680", VA = "0x187CF9680")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7CF94A0", Offset = "0x7CF84A0", VA = "0x187CF94A0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9270", Offset = "0x7CF8270", VA = "0x187CF9270")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE6840", Offset = "0x7CE5840", VA = "0x187CE6840")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6970", Offset = "0x7CE5970", VA = "0x187CE6970")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6790", Offset = "0x7CE5790", VA = "0x187CE6790")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE64E0", Offset = "0x7CE54E0", VA = "0x187CE64E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF61B0", Offset = "0x7CF51B0", VA = "0x187CF61B0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CF62E0", Offset = "0x7CF52E0", VA = "0x187CF62E0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6100", Offset = "0x7CF5100", VA = "0x187CF6100")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5E50", Offset = "0x7CF4E50", VA = "0x187CF5E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF9C40", Offset = "0x7CF8C40", VA = "0x187CF9C40")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9D70", Offset = "0x7CF8D70", VA = "0x187CF9D70")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9B90", Offset = "0x7CF8B90", VA = "0x187CF9B90")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF98E0", Offset = "0x7CF88E0", VA = "0x187CF98E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE8690", Offset = "0x7CE7690", VA = "0x187CE8690")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE87C0", Offset = "0x7CE77C0", VA = "0x187CE87C0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE85E0", Offset = "0x7CE75E0", VA = "0x187CE85E0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8330", Offset = "0x7CE7330", VA = "0x187CE8330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE8D10", Offset = "0x7CE7D10", VA = "0x187CE8D10")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8E40", Offset = "0x7CE7E40", VA = "0x187CE8E40")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8C60", Offset = "0x7CE7C60", VA = "0x187CE8C60")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8920", Offset = "0x7CE7920", VA = "0x187CE8920")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE6DC0", Offset = "0x7CE5DC0", VA = "0x187CE6DC0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6EF0", Offset = "0x7CE5EF0", VA = "0x187CE6EF0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6D10", Offset = "0x7CE5D10", VA = "0x187CE6D10")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6AD0", Offset = "0x7CE5AD0", VA = "0x187CE6AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFE800", Offset = "0x7CFD800", VA = "0x187CFE800")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE930", Offset = "0x7CFD930", VA = "0x187CFE930")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE750", Offset = "0x7CFD750", VA = "0x187CFE750")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE540", Offset = "0x7CFD540", VA = "0x187CFE540")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF6700", Offset = "0x7CF5700", VA = "0x187CF6700")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6830", Offset = "0x7CF5830", VA = "0x187CF6830")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6650", Offset = "0x7CF5650", VA = "0x187CF6650")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6440", Offset = "0x7CF5440", VA = "0x187CF6440")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF7900", Offset = "0x7CF6900", VA = "0x187CF7900")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7A30", Offset = "0x7CF6A30", VA = "0x187CF7A30")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7850", Offset = "0x7CF6850", VA = "0x187CF7850")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7640", Offset = "0x7CF6640", VA = "0x187CF7640")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFE2B0", Offset = "0x7CFD2B0", VA = "0x187CFE2B0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE3E0", Offset = "0x7CFD3E0", VA = "0x187CFE3E0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE200", Offset = "0x7CFD200", VA = "0x187CFE200")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDF00", Offset = "0x7CFCF00", VA = "0x187CFDF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF73B0", Offset = "0x7CF63B0", VA = "0x187CF73B0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF74E0", Offset = "0x7CF64E0", VA = "0x187CF74E0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7300", Offset = "0x7CF6300", VA = "0x187CF7300")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7000", Offset = "0x7CF6000", VA = "0x187CF7000")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFCE00", Offset = "0x7CFBE00", VA = "0x187CFCE00")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CFCF30", Offset = "0x7CFBF30", VA = "0x187CFCF30")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CFCD50", Offset = "0x7CFBD50", VA = "0x187CFCD50")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CFCA20", Offset = "0x7CFBA20", VA = "0x187CFCA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFC790", Offset = "0x7CFB790", VA = "0x187CFC790")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC8C0", Offset = "0x7CFB8C0", VA = "0x187CFC8C0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC6E0", Offset = "0x7CFB6E0", VA = "0x187CFC6E0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC3B0", Offset = "0x7CFB3B0", VA = "0x187CFC3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE7340", Offset = "0x7CE6340", VA = "0x187CE7340")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7470", Offset = "0x7CE6470", VA = "0x187CE7470")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7290", Offset = "0x7CE6290", VA = "0x187CE7290")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7050", Offset = "0x7CE6050", VA = "0x187CE7050")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFD6D0", Offset = "0x7CFC6D0", VA = "0x187CFD6D0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD800", Offset = "0x7CFC800", VA = "0x187CFD800")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD620", Offset = "0x7CFC620", VA = "0x187CFD620")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD3C0", Offset = "0x7CFC3C0", VA = "0x187CFD3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFBA30", Offset = "0x7CFAA30", VA = "0x187CFBA30")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CFBB60", Offset = "0x7CFAB60", VA = "0x187CFBB60")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB980", Offset = "0x7CFA980", VA = "0x187CFB980")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB690", Offset = "0x7CFA690", VA = "0x187CFB690")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D06E70", Offset = "0x7D05E70", VA = "0x187D06E70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7D06FA0", Offset = "0x7D05FA0", VA = "0x187D06FA0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7D06DC0", Offset = "0x7D05DC0", VA = "0x187D06DC0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7D06AA0", Offset = "0x7D05AA0", VA = "0x187D06AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE5BA0", Offset = "0x7CE4BA0", VA = "0x187CE5BA0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5CD0", Offset = "0x7CE4CD0", VA = "0x187CE5CD0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5AF0", Offset = "0x7CE4AF0", VA = "0x187CE5AF0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7CE57D0", Offset = "0x7CE47D0", VA = "0x187CE57D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF49D0", Offset = "0x7CF39D0", VA = "0x187CF49D0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4B00", Offset = "0x7CF3B00", VA = "0x187CF4B00")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4920", Offset = "0x7CF3920", VA = "0x187CF4920")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF46F0", Offset = "0x7CF36F0", VA = "0x187CF46F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D074C0", Offset = "0x7D064C0", VA = "0x187D074C0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7D075F0", Offset = "0x7D065F0", VA = "0x187D075F0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7D07410", Offset = "0x7D06410", VA = "0x187D07410")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D07100", Offset = "0x7D06100", VA = "0x187D07100")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF3C30", Offset = "0x7CF2C30", VA = "0x187CF3C30")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3D60", Offset = "0x7CF2D60", VA = "0x187CF3D60")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3B80", Offset = "0x7CF2B80", VA = "0x187CF3B80")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3860", Offset = "0x7CF2860", VA = "0x187CF3860")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF81B0", Offset = "0x7CF71B0", VA = "0x187CF81B0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7CF82E0", Offset = "0x7CF72E0", VA = "0x187CF82E0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8100", Offset = "0x7CF7100", VA = "0x187CF8100")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7E60", Offset = "0x7CF6E60", VA = "0x187CF7E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFDC70", Offset = "0x7CFCC70", VA = "0x187CFDC70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDDA0", Offset = "0x7CFCDA0", VA = "0x187CFDDA0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDBC0", Offset = "0x7CFCBC0", VA = "0x187CFDBC0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD960", Offset = "0x7CFC960", VA = "0x187CFD960")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFA220", Offset = "0x7CF9220", VA = "0x187CFA220")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA350", Offset = "0x7CF9350", VA = "0x187CFA350")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA170", Offset = "0x7CF9170", VA = "0x187CFA170")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9ED0", Offset = "0x7CF8ED0", VA = "0x187CF9ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF5BC0", Offset = "0x7CF4BC0", VA = "0x187CF5BC0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5CF0", Offset = "0x7CF4CF0", VA = "0x187CF5CF0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5B10", Offset = "0x7CF4B10", VA = "0x187CF5B10")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5900", Offset = "0x7CF4900", VA = "0x187CF5900")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF6D70", Offset = "0x7CF5D70", VA = "0x187CF6D70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6EA0", Offset = "0x7CF5EA0", VA = "0x187CF6EA0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6CC0", Offset = "0x7CF5CC0", VA = "0x187CF6CC0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6990", Offset = "0x7CF5990", VA = "0x187CF6990")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE80A0", Offset = "0x7CE70A0", VA = "0x187CE80A0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CE81D0", Offset = "0x7CE71D0", VA = "0x187CE81D0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7FF0", Offset = "0x7CE6FF0", VA = "0x187CE7FF0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7CC0", Offset = "0x7CE6CC0", VA = "0x187CE7CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF8A00", Offset = "0x7CF7A00", VA = "0x187CF8A00")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8B30", Offset = "0x7CF7B30", VA = "0x187CF8B30")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8950", Offset = "0x7CF7950", VA = "0x187CF8950")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CF85C0", Offset = "0x7CF75C0", VA = "0x187CF85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE93E0", Offset = "0x7CE83E0", VA = "0x187CE93E0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9510", Offset = "0x7CE8510", VA = "0x187CE9510")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9330", Offset = "0x7CE8330", VA = "0x187CE9330")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8FA0", Offset = "0x7CE7FA0", VA = "0x187CE8FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFF8A0", Offset = "0x7CFE8A0", VA = "0x187CFF8A0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF9D0", Offset = "0x7CFE9D0", VA = "0x187CFF9D0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF7F0", Offset = "0x7CFE7F0", VA = "0x187CFF7F0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF550", Offset = "0x7CFE550", VA = "0x187CFF550")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFA7A0", Offset = "0x7CF97A0", VA = "0x187CFA7A0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA8D0", Offset = "0x7CF98D0", VA = "0x187CFA8D0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA6F0", Offset = "0x7CF96F0", VA = "0x187CFA6F0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA4B0", Offset = "0x7CF94B0", VA = "0x187CFA4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE5440", Offset = "0x7CE4440", VA = "0x187CE5440")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5570", Offset = "0x7CE4570", VA = "0x187CE5570")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5390", Offset = "0x7CE4390", VA = "0x187CE5390")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5090", Offset = "0x7CE4090", VA = "0x187CE5090")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFAE90", Offset = "0x7CF9E90", VA = "0x187CFAE90")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7CFAFC0", Offset = "0x7CF9FC0", VA = "0x187CFAFC0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7CFADE0", Offset = "0x7CF9DE0", VA = "0x187CFADE0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7CFAA30", Offset = "0x7CF9A30", VA = "0x187CFAA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF5670", Offset = "0x7CF4670", VA = "0x187CF5670")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7CF57A0", Offset = "0x7CF47A0", VA = "0x187CF57A0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CF55C0", Offset = "0x7CF45C0", VA = "0x187CF55C0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5200", Offset = "0x7CF4200", VA = "0x187CF5200")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFC120", Offset = "0x7CFB120", VA = "0x187CFC120")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC250", Offset = "0x7CFB250", VA = "0x187CFC250")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC070", Offset = "0x7CFB070", VA = "0x187CFC070")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7CFBCC0", Offset = "0x7CFACC0", VA = "0x187CFBCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFED70", Offset = "0x7CFDD70", VA = "0x187CFED70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CFEEA0", Offset = "0x7CFDEA0", VA = "0x187CFEEA0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CFECC0", Offset = "0x7CFDCC0", VA = "0x187CFECC0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CFEA90", Offset = "0x7CFDA90", VA = "0x187CFEA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFB400", Offset = "0x7CFA400", VA = "0x187CFB400")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB530", Offset = "0x7CFA530", VA = "0x187CFB530")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB350", Offset = "0x7CFA350", VA = "0x187CFB350")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CFB120", Offset = "0x7CFA120", VA = "0x187CFB120")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF8FE0", Offset = "0x7CF7FE0", VA = "0x187CF8FE0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9110", Offset = "0x7CF8110", VA = "0x187CF9110")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8F30", Offset = "0x7CF7F30", VA = "0x187CF8F30")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8C90", Offset = "0x7CF7C90", VA = "0x187CF8C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF4F70", Offset = "0x7CF3F70", VA = "0x187CF4F70")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF50A0", Offset = "0x7CF40A0", VA = "0x187CF50A0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4EC0", Offset = "0x7CF3EC0", VA = "0x187CF4EC0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4C60", Offset = "0x7CF3C60", VA = "0x187CF4C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF4460", Offset = "0x7CF3460", VA = "0x187CF4460")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4590", Offset = "0x7CF3590", VA = "0x187CF4590")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF43B0", Offset = "0x7CF33B0", VA = "0x187CF43B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4140", Offset = "0x7CF3140", VA = "0x187CF4140")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFF2C0", Offset = "0x7CFE2C0", VA = "0x187CFF2C0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF3F0", Offset = "0x7CFE3F0", VA = "0x187CFF3F0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF210", Offset = "0x7CFE210", VA = "0x187CFF210")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF000", Offset = "0x7CFE000", VA = "0x187CFF000")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE7880", Offset = "0x7CE6880", VA = "0x187CE7880")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE79B0", Offset = "0x7CE69B0", VA = "0x187CE79B0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE77D0", Offset = "0x7CE67D0", VA = "0x187CE77D0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE75D0", Offset = "0x7CE65D0", VA = "0x187CE75D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF2EB0", Offset = "0x7CF1EB0", VA = "0x187CF2EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GMHDFKBMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1910", Offset = "0x7CF0910", VA = "0x187CF1910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2670", Offset = "0x7CF1670", VA = "0x187CF2670")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CED1E0", Offset = "0x7CEC1E0", VA = "0x187CED1E0")]
	public static DJEOHGJJNMK FLLMCNLHKNL(Allocator NDFENJBGNOB, NativeArray<float3> HEIDAKDKJJN, NativeArray<float3> LAEKEEAOFLB, NativeArray<float2> DHFAOJAKFKM, NativeArray<float4> EEOILEIGJHB, bool CJAMNBEAIGN, NativeArray<float4> PMKPBIIHDMK, NativeArray<int> LPLJFEEALKJ, int NPGNODKKKAD, int KNJFBCCKPAH, int PCGPKCCHANN, int AHOMBPIDMCC)
	{
		return default(DJEOHGJJNMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB260", Offset = "0x7CEA260", VA = "0x187CEB260")]
	public OFNFOCEBPOF CKONIBGAFNP(Allocator NDFENJBGNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB300", Offset = "0x7CEA300", VA = "0x187CEB300")]
	public void CKONIBGAFNP(OFNFOCEBPOF OBOOAPELMPF, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2950", Offset = "0x7CF1950", VA = "0x187CF2950")]
	public void OCKMBDCILHB(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF080", Offset = "0x7CEE080", VA = "0x187CEF080")]
	private void HOPJLJOIFFB(Mesh PEPFHNJFNIL, NativeArray<ushort> BMPFHBCCNDN, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEAA0", Offset = "0x7CEDAA0", VA = "0x187CEEAA0")]
	public void HNKLGDNLPMG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2020", Offset = "0x7CF1020", VA = "0x187CF2020")]
	public void NJLOGFHEPOF(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0360", Offset = "0x7CEF360", VA = "0x187CF0360")]
	public void JNFNGDFFFDD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAB80", Offset = "0x7CE9B80", VA = "0x187CEAB80")]
	public void CFFDNIDHOHG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CED7D0", Offset = "0x7CEC7D0", VA = "0x187CED7D0")]
	public void GFKEJIBGGBD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0020", Offset = "0x7CEF020", VA = "0x187CF0020")]
	public void JIMECJHBEFE(Mesh PEPFHNJFNIL, OFNFOCEBPOF.LEBCKMKDBPC CKHLMMECGLE, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CED710", Offset = "0x7CEC710", VA = "0x187CED710")]
	public long GEBEHCBKDIL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CED100", Offset = "0x7CEC100", VA = "0x187CED100")]
	public long ENNKELIOCBP(OFNFOCEBPOF.LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0B80", Offset = "0x7CEFB80", VA = "0x187CF0B80")]
	private void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB, bool KLNAIMNEAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFC40", Offset = "0x7CEEC40", VA = "0x187CEFC40")]
	private void INACKDOCFDM(NativeArray<float3> KNGCHPLNGDO, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFBC0", Offset = "0x7CEEBC0", VA = "0x187CEFBC0")]
	[BurstCompile]
	private unsafe static void INACKDOCFDM([NoAlias] float3* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF5E0", Offset = "0x7CEE5E0", VA = "0x187CEF5E0")]
	[BurstCompile]
	private unsafe static void IDLANHJKOGF([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA3C0", Offset = "0x7CE93C0", VA = "0x187CEA3C0")]
	[BurstCompile]
	private unsafe static void BGFAENANGCF([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE8F0", Offset = "0x7CED8F0", VA = "0x187CEE8F0")]
	[BurstCompile]
	private unsafe static void HLMMDLHKLCA([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1330", Offset = "0x7CF0330", VA = "0x187CF1330")]
	[BurstCompile]
	private unsafe static void LOGGGJHHHMA([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0CB0", Offset = "0x7CEFCB0", VA = "0x187CF0CB0")]
	[BurstCompile]
	private unsafe static void KNGHMFBEOFF([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF50", Offset = "0x7CEBF50", VA = "0x187CECF50")]
	private void EMPJGAAANAB(NativeArray<float3> HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CED070", Offset = "0x7CEC070", VA = "0x187CED070")]
	[BurstCompile]
	private unsafe static void EMPJGAAANAB([NoAlias] ushort* KNGCHPLNGDO, [Out] float3 KOLNFJMEMBO, [Out] float3 MGAEOBKBLOA, [In][NoAlias] float3* HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF2B0", Offset = "0x7CEE2B0", VA = "0x187CEF2B0")]
	private void IDGCBGAHDBH(NativeArray<float3> LAEKEEAOFLB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF390", Offset = "0x7CEE390", VA = "0x187CEF390")]
	[BurstCompile]
	private unsafe static void IDGCBGAHDBH([NoAlias] ushort* HKJFMLGKOLE, [In][NoAlias] float3* LAEKEEAOFLB, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF660", Offset = "0x7CEE660", VA = "0x187CEF660")]
	private void IDNDCPFMKIJ(NativeArray<float3> HNJEFMCIMOB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF720", Offset = "0x7CEE720", VA = "0x187CEF720")]
	[BurstCompile]
	private unsafe static void IDNDCPFMKIJ([NoAlias] float3* HNJEFMCIMOB, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CEBA30", Offset = "0x7CEAA30", VA = "0x187CEBA30")]
	[BurstCompile]
	private unsafe static void CNCGPGJAJDK([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CF09B0", Offset = "0x7CEF9B0", VA = "0x187CF09B0")]
	[BurstCompile]
	private unsafe static void KCOFNJCDICC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE1E0", Offset = "0x7CED1E0", VA = "0x187CEE1E0")]
	[BurstCompile]
	private unsafe static void GNLHEABEFEP([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA8F0", Offset = "0x7CE98F0", VA = "0x187CEA8F0")]
	[BurstCompile]
	private unsafe static void BOHGOKKFEKA([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE5E0", Offset = "0x7CED5E0", VA = "0x187CEE5E0")]
	[BurstCompile]
	private unsafe static void HJJMKNJMKOJ([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9AA0", Offset = "0x7CE8AA0", VA = "0x187CE9AA0")]
	private void AEBLBDONNEJ(NativeArray<float2> DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9BC0", Offset = "0x7CE8BC0", VA = "0x187CE9BC0")]
	[BurstCompile]
	private unsafe static void AEBLBDONNEJ([NoAlias] uint* DDCFGONKIJI, [Out] float2 MMNICFBIKLM, [Out] float2 KPNAELOMDEE, [In][NoAlias] float2* DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB1E0", Offset = "0x7CEA1E0", VA = "0x187CEB1E0")]
	[BurstCompile]
	private static void CKNBHCNMBPD([Out] float2 AJAKAPDAHBO, uint OBECJEJKMCP, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA960", Offset = "0x7CE9960", VA = "0x187CEA960")]
	private void BPGAOJJINOC(NativeArray<float2> DDCFGONKIJI, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAA80", Offset = "0x7CE9A80", VA = "0x187CEAA80")]
	[BurstCompile]
	private unsafe static void BPGAOJJINOC([NoAlias] float2* DDCFGONKIJI, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CECED0", Offset = "0x7CEBED0", VA = "0x187CECED0")]
	[BurstCompile]
	private unsafe static void ELMAAIBGLDM([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CF12B0", Offset = "0x7CF02B0", VA = "0x187CF12B0")]
	[BurstCompile]
	private unsafe static void LNEBLKFLFFG([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB6C0", Offset = "0x7CEA6C0", VA = "0x187CEB6C0")]
	[BurstCompile]
	private unsafe static void CLNGCPDDJML([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CED690", Offset = "0x7CEC690", VA = "0x187CED690")]
	[BurstCompile]
	private unsafe static void GDNJDNPBJKM([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA020", Offset = "0x7CE9020", VA = "0x187CEA020")]
	[BurstCompile]
	private unsafe static void BBBPPCMILML([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1430", Offset = "0x7CF0430", VA = "0x187CF1430")]
	private void MCFLALHDPGL(NativeArray<float4> PMKPBIIHDMK, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CF13B0", Offset = "0x7CF03B0", VA = "0x187CF13B0")]
	[BurstCompile]
	private unsafe static void MCFLALHDPGL([NoAlias] ushort* JPGCMIDIDOP, [In][NoAlias] float4* CCEEBJLFJFK, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2AE0", Offset = "0x7CF1AE0", VA = "0x187CF2AE0")]
	[BurstCompile]
	private static ushort OKADHLJPEOC([In] float4 LLFBONBFGND)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CF15B0", Offset = "0x7CF05B0", VA = "0x187CF15B0")]
	private void MGBLODILHJB(NativeArray<float4> JPGCMIDIDOP, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1540", Offset = "0x7CF0540", VA = "0x187CF1540")]
	[BurstCompile]
	private unsafe static void MGBLODILHJB([NoAlias] float4* JPGCMIDIDOP, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF970", Offset = "0x7CEE970", VA = "0x187CEF970")]
	[BurstCompile]
	private unsafe static void IIKNEJBFMKB([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE570", Offset = "0x7CED570", VA = "0x187CEE570")]
	[BurstCompile]
	private unsafe static void HIGLCOMKGAE([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE250", Offset = "0x7CED250", VA = "0x187CEE250")]
	[BurstCompile]
	private unsafe static void GPDAPCFMCGC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1DE0", Offset = "0x7CF0DE0", VA = "0x187CF1DE0")]
	[BurstCompile]
	private unsafe static void NEAMMLHKOGP([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CED170", Offset = "0x7CEC170", VA = "0x187CED170")]
	[BurstCompile]
	private unsafe static void FEDKIMEMMFG([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CED630", Offset = "0x7CEC630", VA = "0x187CED630")]
	[BurstCompile]
	private static void FOLJFECKMBD([Out] float4 OBOOAPELMPF, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC150", Offset = "0x7CEB150", VA = "0x187CEC150")]
	private void EAPHBFJALLF(Allocator NDFENJBGNOB, NativeArray<float4> EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC590", Offset = "0x7CEB590", VA = "0x187CEC590")]
	[BurstCompile]
	private unsafe static void EAPHBFJALLF([NoAlias] float4* CNINOIGOJEA, [NoAlias] byte* JJKOJNFOHOC, [Out] int AADEMPPBGIH, [Out] int HOGJPMLHDCP, [NoAlias] float4* EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDDF0", Offset = "0x7CECDF0", VA = "0x187CEDDF0")]
	private static void GHCOJDAIABL(NativeArray<float4> DOBCKFGCGOD, NativeArray<IIBAEONOJDB> GNKPENKMHAG, NativeArray<byte> DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDF20", Offset = "0x7CECF20", VA = "0x187CEDF20")]
	[BurstCompile]
	private unsafe static void GHCOJDAIABL([NoAlias] float4* DOBCKFGCGOD, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9FA0", Offset = "0x7CE8FA0", VA = "0x187CE9FA0")]
	[BurstCompile]
	private unsafe static void APCALNGNPOI([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAB00", Offset = "0x7CE9B00", VA = "0x187CEAB00")]
	[BurstCompile]
	private unsafe static void CCIDHCPHKJL([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9770", Offset = "0x7CE8770", VA = "0x187CE9770")]
	[BurstCompile]
	private unsafe static void AACMFGDKEEA([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CF16A0", Offset = "0x7CF06A0", VA = "0x187CF16A0")]
	[BurstCompile]
	private unsafe static void MIPJKNNCCIE([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CECAA0", Offset = "0x7CEBAA0", VA = "0x187CECAA0")]
	[BurstCompile]
	private unsafe static void EIJCGFPFCLD([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2790", Offset = "0x7CF1790", VA = "0x187CF2790")]
	private void OBINMAJDECA(Allocator NDFENJBGNOB, NativeArray<int> LPLJFEEALKJ, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0F60", Offset = "0x7CEFF60", VA = "0x187CF0F60")]
	private static NativeArray<byte> LJJAKCFGIGD(Allocator NDFENJBGNOB, NativeArray<int> LPLJFEEALKJ, int CHENFJALHID)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1240", Offset = "0x7CF0240", VA = "0x187CF1240")]
	[BurstCompile]
	private unsafe static int LJJAKCFGIGD([NoAlias] byte* AADAHELMBIE, [In][NoAlias] int* LPLJFEEALKJ, int CHENFJALHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA4B0", Offset = "0x7CE94B0", VA = "0x187CEA4B0")]
	private static void BHAKOJOCOLC(NativeArray<int> OFBNPEEKAOM, NativeArray<byte> LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA440", Offset = "0x7CE9440", VA = "0x187CEA440")]
	[BurstCompile]
	private unsafe static void BHAKOJOCOLC([NoAlias] int* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2A70", Offset = "0x7CF1A70", VA = "0x187CF2A70")]
	[BurstCompile]
	private unsafe static void OFCEBDJPHKH([NoAlias] ushort* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1950", Offset = "0x7CF0950", VA = "0x187CF1950")]
	[BurstCompile]
	private static void MOMIIKBIIEJ([Out] float3 AJAKAPDAHBO, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFD60", Offset = "0x7CEED60", VA = "0x187CEFD60")]
	[BurstCompile]
	private static ushort INAGKMKHBOI([In] float3 LLFBONBFGND)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3350", Offset = "0x7CE2350", VA = "0x187CE3350")]
	[BurstCompile]
	public unsafe static void CPAEOCEBILD([NoAlias] float3* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CECE10", Offset = "0x7CEBE10", VA = "0x187CECE10")]
	[BurstCompile]
	public unsafe static void ELIBHODLIMN([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2890", Offset = "0x7CF1890", VA = "0x187CF2890")]
	[BurstCompile]
	public unsafe static void OBKAOFGKHPJ([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0EA0", Offset = "0x7CEFEA0", VA = "0x187CF0EA0")]
	[BurstCompile]
	public unsafe static void LJFJKNGAPBF([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0EA0", Offset = "0x7CEFEA0", VA = "0x187CF0EA0")]
	[BurstCompile]
	public unsafe static void NPDNEGDGNKF([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0A20", Offset = "0x7CEFA20", VA = "0x187CF0A20")]
	[BurstCompile]
	public unsafe static void KGGFEHNLFMP([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* HEIDAKDKJJN, int NPGNODKKKAD, [In] float3 NOOBOGHKKAA, [In] float3 MGAEOBKBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2F70", Offset = "0x7CE1F70", VA = "0x187CE2F70")]
	[BurstCompile]
	public unsafe static void CNHDFAKKEOO([NoAlias] ushort* KNGCHPLNGDO, [Out] float3 KOLNFJMEMBO, [Out] float3 MGAEOBKBLOA, [In][NoAlias] float3* HEIDAKDKJJN, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA5A0", Offset = "0x7CE95A0", VA = "0x187CEA5A0")]
	[BurstCompile]
	public unsafe static void BNJBFLGDJOD([NoAlias] ushort* HKJFMLGKOLE, [In][NoAlias] float3* LAEKEEAOFLB, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE650", Offset = "0x7CED650", VA = "0x187CEE650")]
	[BurstCompile]
	public unsafe static void HLJDMGKOGLL([NoAlias] float3* HNJEFMCIMOB, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1B90", Offset = "0x7CF0B90", VA = "0x187CF1B90")]
	[BurstCompile]
	public unsafe static void NDPJJEBHLMM([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC790", Offset = "0x7CEB790", VA = "0x187CEC790")]
	[BurstCompile]
	public unsafe static void EBIFIKCGCPJ([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2D70", Offset = "0x7CF1D70", VA = "0x187CF2D70")]
	[BurstCompile]
	public unsafe static void PMBLPIEBDHI([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEBDC0", Offset = "0x7CEADC0", VA = "0x187CEBDC0")]
	[BurstCompile]
	public unsafe static void DIBKADMLLGD([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC620", Offset = "0x7CEB620", VA = "0x187CEC620")]
	[BurstCompile]
	public unsafe static void EBDIIFFFKGJ([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* LAEKEEAOFLB, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4260", Offset = "0x7CE3260", VA = "0x187CE4260")]
	[BurstCompile]
	public unsafe static void NJMFAPCMJAE([NoAlias] uint* DDCFGONKIJI, [Out] float2 MMNICFBIKLM, [Out] float2 KPNAELOMDEE, [In][NoAlias] float2* DHFAOJAKFKM, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB1A0", Offset = "0x7CEA1A0", VA = "0x187CEB1A0")]
	[BurstCompile]
	public static void CKJFGEANCPN([Out] float2 AJAKAPDAHBO, uint OBECJEJKMCP, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1F10", Offset = "0x7CF0F10", VA = "0x187CF1F10")]
	[BurstCompile]
	public unsafe static void NHBFAFJCPEL([NoAlias] float2* DDCFGONKIJI, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2EF0", Offset = "0x7CF1EF0", VA = "0x187CF2EF0")]
	[BurstCompile]
	public unsafe static void POEHLEJKDAA([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CEBC80", Offset = "0x7CEAC80", VA = "0x187CEBC80")]
	[BurstCompile]
	public unsafe static void COPBADCNAIC([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CEBF30", Offset = "0x7CEAF30", VA = "0x187CEBF30")]
	[BurstCompile]
	public unsafe static void EAGNHPHMNOC([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE440", Offset = "0x7CED440", VA = "0x187CEE440")]
	[BurstCompile]
	public unsafe static void HHOBPPHHNAO([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE970", Offset = "0x7CED970", VA = "0x187CEE970")]
	[BurstCompile]
	public unsafe static void HLNFFAPGLJM([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [NoAlias] uint* DHFAOJAKFKM, int NPGNODKKKAD, [In] float2 JGNECBNGPKK, [In] float2 KPNAELOMDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE360", Offset = "0x7CED360", VA = "0x187CEE360")]
	[BurstCompile]
	public unsafe static void HFJFMANGLIH([NoAlias] ushort* JPGCMIDIDOP, [In][NoAlias] float4* CCEEBJLFJFK, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFF90", Offset = "0x7CEEF90", VA = "0x187CEFF90")]
	[BurstCompile]
	public static ushort JBJPEOOOKLG([In] float4 LLFBONBFGND)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE97F0", Offset = "0x7CE87F0", VA = "0x187CE97F0")]
	[BurstCompile]
	public unsafe static void AAGAKMNGCMK([NoAlias] float4* JPGCMIDIDOP, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB740", Offset = "0x7CEA740", VA = "0x187CEB740")]
	[BurstCompile]
	public unsafe static void CMFNFHPDBJO([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0D30", Offset = "0x7CEFD30", VA = "0x187CF0D30")]
	[BurstCompile]
	public unsafe static void LDGINEKEBOP([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9E30", Offset = "0x7CE8E30", VA = "0x187CE9E30")]
	[BurstCompile]
	public unsafe static void AIAOKGPABAJ([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC8D0", Offset = "0x7CEB8D0", VA = "0x187CEC8D0")]
	[BurstCompile]
	public unsafe static void EGOALEOOJFD([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE98D0", Offset = "0x7CE88D0", VA = "0x187CE98D0")]
	[BurstCompile]
	public unsafe static void AAGIEHPLOHI([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] ushort* PMKPBIIHDMK, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1E50", Offset = "0x7CF0E50", VA = "0x187CF1E50")]
	[BurstCompile]
	public static void NFIHPLHCIIG([Out] float4 OBOOAPELMPF, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3A10", Offset = "0x7CE2A10", VA = "0x187CE3A10")]
	[BurstCompile]
	public unsafe static void HCKPDINCBHC([NoAlias] float4* CNINOIGOJEA, [NoAlias] byte* JJKOJNFOHOC, [Out] int AADEMPPBGIH, [Out] int HOGJPMLHDCP, [NoAlias] float4* EEOILEIGJHB, int AHOMBPIDMCC, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA0A0", Offset = "0x7CE90A0", VA = "0x187CEA0A0")]
	[BurstCompile]
	public unsafe static void BELKIJAGMNF([NoAlias] float4* DOBCKFGCGOD, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9C50", Offset = "0x7CE8C50", VA = "0x187CE9C50")]
	[BurstCompile]
	public unsafe static void AHGGMEMFEKB([NoAlias] OFNFOCEBPOF.EHEEGMEMPPL* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA1E0", Offset = "0x7CE91E0", VA = "0x187CEA1E0")]
	[BurstCompile]
	public unsafe static void BEMJIAEDOHE([NoAlias] OFNFOCEBPOF.HNAPBBAPNHA* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3030", Offset = "0x7CF2030", VA = "0x187CF3030")]
	[BurstCompile]
	public unsafe static void PONMJCEFOME([NoAlias] OFNFOCEBPOF.EECMHFOGIPB* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2B30", Offset = "0x7CF1B30", VA = "0x187CF2B30")]
	[BurstCompile]
	public unsafe static void OMBOGECNPDC([NoAlias] OFNFOCEBPOF.FBAFEBCICFD* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDFA0", Offset = "0x7CECFA0", VA = "0x187CEDFA0")]
	[BurstCompile]
	public unsafe static void GNCGEJOCPFE([NoAlias] OFNFOCEBPOF.IMGNLKODGID* KNGCHPLNGDO, [In][NoAlias] IIBAEONOJDB* GNKPENKMHAG, [In][NoAlias] byte* DLNCCNODFPD, int NPGNODKKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CECD10", Offset = "0x7CEBD10", VA = "0x187CECD10")]
	[BurstCompile]
	public unsafe static int EJBIGHJPOFM([NoAlias] byte* AADAHELMBIE, [In][NoAlias] int* LPLJFEEALKJ, int CHENFJALHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE2C0", Offset = "0x7CED2C0", VA = "0x187CEE2C0")]
	[BurstCompile]
	public unsafe static void HDDDDGABHIO([NoAlias] int* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA850", Offset = "0x7CE9850", VA = "0x187CEA850")]
	[BurstCompile]
	public unsafe static void BNJKEAINMMD([NoAlias] ushort* OFBNPEEKAOM, [In][NoAlias] byte* LDOAHGDDMKA, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3E70", Offset = "0x7CE2E70", VA = "0x187CE3E70")]
	[BurstCompile]
	public static void NAPABBEOACD([Out] float3 AJAKAPDAHBO, ushort OBECJEJKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2810", Offset = "0x7CE1810", VA = "0x187CE2810")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE6250", Offset = "0x7CE5250", VA = "0x187CE6250")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6380", Offset = "0x7CE5380", VA = "0x187CE6380")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7CE61A0", Offset = "0x7CE51A0", VA = "0x187CE61A0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5F30", Offset = "0x7CE4F30", VA = "0x187CE5F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D11980", Offset = "0x7D10980", VA = "0x187D11980")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7D11AB0", Offset = "0x7D10AB0", VA = "0x187D11AB0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7D118D0", Offset = "0x7D108D0", VA = "0x187D118D0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7D11650", Offset = "0x7D10650", VA = "0x187D11650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D084A0", Offset = "0x7D074A0", VA = "0x187D084A0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7D085D0", Offset = "0x7D075D0", VA = "0x187D085D0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7D083F0", Offset = "0x7D073F0", VA = "0x187D083F0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7D081A0", Offset = "0x7D071A0", VA = "0x187D081A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D20490", Offset = "0x7D1F490", VA = "0x187D20490")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7D205C0", Offset = "0x7D1F5C0", VA = "0x187D205C0")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7D203E0", Offset = "0x7D1F3E0", VA = "0x187D203E0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7D201A0", Offset = "0x7D1F1A0", VA = "0x187D201A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1FF10", Offset = "0x7D1EF10", VA = "0x187D1FF10")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7D20040", Offset = "0x7D1F040", VA = "0x187D20040")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7D1FE60", Offset = "0x7D1EE60", VA = "0x187D1FE60")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7D1FC20", Offset = "0x7D1EC20", VA = "0x187D1FC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1D260", Offset = "0x7D1C260", VA = "0x187D1D260")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D390", Offset = "0x7D1C390", VA = "0x187D1D390")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D1B0", Offset = "0x7D1C1B0", VA = "0x187D1D1B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CDC0", Offset = "0x7D1BDC0", VA = "0x187D1CDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0FD60", Offset = "0x7D0ED60", VA = "0x187D0FD60")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FE90", Offset = "0x7D0EE90", VA = "0x187D0FE90")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FCB0", Offset = "0x7D0ECB0", VA = "0x187D0FCB0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7D0F750", Offset = "0x7D0E750", VA = "0x187D0F750")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D06630", Offset = "0x7D05630", VA = "0x187D06630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D05820", Offset = "0x7D04820", VA = "0x187D05820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D01560", Offset = "0x7D00560", VA = "0x187D01560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GMHDFKBMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D05070", Offset = "0x7D04070", VA = "0x187D05070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D00480", Offset = "0x7CFF480", VA = "0x187D00480")]
	public static MPLLFAPOJAH BDIAGDDMHKC(LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(MPLLFAPOJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D050B0", Offset = "0x7D040B0", VA = "0x187D050B0")]
	public static void MKPMBGIKJHF(MPLLFAPOJAH PLAKJHGAFDC, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D00E50", Offset = "0x7CFFE50", VA = "0x187D00E50", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7D031C0", Offset = "0x7D021C0", VA = "0x187D031C0")]
	public void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB, bool AKCOJAELIJC, bool KLNAIMNEAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D05C60", Offset = "0x7D04C60", VA = "0x187D05C60")]
	public void OKAAKCDEBLF(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D05170", Offset = "0x7D04170", VA = "0x187D05170", Slot = "6")]
	public bool MLJIOPMADIF(Mesh PEPFHNJFNIL, bool DILEIBANLAM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D05860", Offset = "0x7D04860", VA = "0x187D05860")]
	public bool OCKMBDCILHB(Mesh PEPFHNJFNIL, bool DILEIBANLAM, bool JLIOEHLJPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7CFFF80", Offset = "0x7CFEF80", VA = "0x187CFFF80")]
	public bool BBDKPNMDEJL(Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, bool DILEIBANLAM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D02950", Offset = "0x7D01950", VA = "0x187D02950")]
	public bool IHGKLDFPDGN(Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D03980", Offset = "0x7D02980", VA = "0x187D03980")]
	private void KNNNEDHMAEL(Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D04110", Offset = "0x7D03110", VA = "0x187D04110")]
	public void KNNNEDHMAEL(NativeArray<ushort> GAKGLFDFMPF, NativeArray<FBAFEBCICFD> PDIDMHJKDPO, Mesh PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D01E90", Offset = "0x7D00E90", VA = "0x187D01E90")]
	public void HNKLGDNLPMG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D04C60", Offset = "0x7D03C60", VA = "0x187D04C60")]
	[BurstCompile]
	public static int MFFAAIMOOHE(float CEJAAIDLEPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D04BC0", Offset = "0x7D03BC0", VA = "0x187D04BC0")]
	[BurstCompile]
	public static uint MFFAAIMOOHE([In] float4 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D04C10", Offset = "0x7D03C10", VA = "0x187D04C10")]
	[BurstCompile]
	public static uint MFFAAIMOOHE([In] float3 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D05190", Offset = "0x7D04190", VA = "0x187D05190")]
	public void NJLOGFHEPOF(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D028D0", Offset = "0x7D018D0", VA = "0x187D028D0")]
	[BurstCompile]
	private unsafe static void IGHINMCOPPK([NoAlias] HNAPBBAPNHA* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D02B30", Offset = "0x7D01B30", VA = "0x187D02B30")]
	public void JNFNGDFFFDD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D04B40", Offset = "0x7D03B40", VA = "0x187D04B40")]
	[BurstCompile]
	private unsafe static void MAMJNICGAMG([NoAlias] EECMHFOGIPB* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D004D0", Offset = "0x7CFF4D0", VA = "0x187D004D0")]
	public void CFFDNIDHOHG(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D008A0", Offset = "0x7CFF8A0", VA = "0x187D008A0")]
	public void CFFDNIDHOHG(NativeArray<ushort> BMPFHBCCNDN, NativeArray<FBAFEBCICFD> GFKJOIMNDHO, Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D02A20", Offset = "0x7D01A20", VA = "0x187D02A20")]
	[BurstCompile]
	public unsafe static void JABLGOCCCAP([NoAlias] FBAFEBCICFD* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D015A0", Offset = "0x7D005A0", VA = "0x187D015A0")]
	public void GFKEJIBGGBD(Mesh PEPFHNJFNIL, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D010C0", Offset = "0x7D000C0", VA = "0x187D010C0")]
	[BurstCompile]
	private unsafe static void FIFADFIPBAN([NoAlias] IMGNLKODGID* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM, [Out] float3 FINEMDGKOBL, [Out] float3 CBBADNNIJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D02AA0", Offset = "0x7D01AA0", VA = "0x187D02AA0")]
	public void JIMECJHBEFE(Mesh PEPFHNJFNIL, LEBCKMKDBPC CKHLMMECGLE, bool JLIOEHLJPOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D01140", Offset = "0x7D00140", VA = "0x187D01140")]
	public void FMLNAEFDMPJ(OFNFOCEBPOF PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D04760", Offset = "0x7D03760", VA = "0x187D04760")]
	public void LGMCALEKNMI(OFNFOCEBPOF NEKLMLONNIM, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D01410", Offset = "0x7D00410", VA = "0x187D01410")]
	public long GEBEHCBKDIL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D013B0", Offset = "0x7D003B0", VA = "0x187D013B0")]
	public static long GEBEHCBKDIL(int ALGLHJLPILC, int GIKGIGBNIPH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D00F60", Offset = "0x7CFFF60", VA = "0x187D00F60")]
	public static long ENNKELIOCBP(int ALGLHJLPILC, int GIKGIGBNIPH, LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D01000", Offset = "0x7D00000", VA = "0x187D01000")]
	public long ENNKELIOCBP(LEBCKMKDBPC CKHLMMECGLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C50", Offset = "0x7CFFC50", VA = "0x187D00C50")]
	public void CIFIGGJLKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D033B0", Offset = "0x7D023B0", VA = "0x187D033B0")]
	public static void KIIEDBBJNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D05CE0", Offset = "0x7D04CE0", VA = "0x187D05CE0")]
	public LEBCKMKDBPC PBIHAELCOKG()
	{
		return default(LEBCKMKDBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D01CE0", Offset = "0x7D00CE0", VA = "0x187D01CE0")]
	public static (int, int) GJJHDFLFDBO(Mesh PEPFHNJFNIL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D01DB0", Offset = "0x7D00DB0", VA = "0x187D01DB0")]
	public static int GNPNHFMCGFD(VertexAttributeDescriptor[] OBEKDLLJPGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D00DE0", Offset = "0x7CFFDE0", VA = "0x187D00DE0")]
	public static long DANHMPNCGCM(Mesh PEPFHNJFNIL, int OHLODDJOFDB, int DLKBHAIHLJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D00CB0", Offset = "0x7CFFCB0", VA = "0x187D00CB0")]
	public static long DANHMPNCGCM(Mesh PEPFHNJFNIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OFNFOCEBPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7D049F0", Offset = "0x7D039F0", VA = "0x187D049F0")]
	[BurstCompile]
	public static int LIHHOINPOLE(float CEJAAIDLEPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7D04860", Offset = "0x7D03860", VA = "0x187D04860")]
	[BurstCompile]
	public static uint LIHHOINPOLE([In] float4 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7D04A90", Offset = "0x7D03A90", VA = "0x187D04A90")]
	[BurstCompile]
	public static uint LIHHOINPOLE([In] float3 IINHKHEMEHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7D04CB0", Offset = "0x7D03CB0", VA = "0x187D04CB0")]
	[BurstCompile]
	public unsafe static void MHLHECAMCGJ([NoAlias] HNAPBBAPNHA* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7CFFB30", Offset = "0x7CFEB30", VA = "0x187CFFB30")]
	[BurstCompile]
	public unsafe static void AJBAKCLECAI([NoAlias] EECMHFOGIPB* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7D06430", Offset = "0x7D05430", VA = "0x187D06430")]
	[BurstCompile]
	public unsafe static void PIJIEIEIMMD([NoAlias] FBAFEBCICFD* KNGCHPLNGDO, int NPGNODKKKAD, [In][NoAlias] float3* BEEPPLKKJCL, [In][NoAlias] float3* COEAFKGHHAK, [In][NoAlias] float4* IABDNJIKDAN, [In][NoAlias] float2* ADKCNGCNOBC, [In][NoAlias] float4* LGPLODMABGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7D04420", Offset = "0x7D03420", VA = "0x187D04420")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F54B0", Offset = "0x9F44B0", VA = "0x1809F54B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9F54F0", Offset = "0x9F44F0", VA = "0x1809F54F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xC10830", Offset = "0xC0F830", VA = "0x180C10830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xC10840", Offset = "0xC0F840", VA = "0x180C10840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FA00", Offset = "0x7D1EA00", VA = "0x187D1FA00")]
	public OGPFNIIHPFO(int FDKEHLHNLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DFE0", Offset = "0x7D1CFE0", VA = "0x187D1DFE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F5F0", Offset = "0x7D1E5F0", VA = "0x187D1F5F0")]
	public void NNOHEEPCFHD(JobHandle GMNPCPDAADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F7E0", Offset = "0x7D1E7E0", VA = "0x187D1F7E0")]
	public void PHGOCJBDJLN(JDAJOIBJGCG APDBNIMCPID, HGNFDNHGFNE FLMKMEGOIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F490", Offset = "0x7D1E490", VA = "0x187D1F490")]
	public void LICHKICBMDJ(LHLKKDNGDMK APDBNIMCPID, NativeArray<KIKMAHKACEI> HCHKNOLBPGP, int NPGNODKKKAD, int PCGPKCCHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F370", Offset = "0x7D1E370", VA = "0x187D1F370")]
	public JobHandle GIBHBFIGFKC(OFNFOCEBPOF HDOENGOJBKJ, KCFHOMPPIJH JJJNFMILJFE, float3 BFIHAPKNNFO, quaternion FPCGAIHLJMK, float BIHFAHMMCBL, bool HLDCLHOMCIC, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E1C0", Offset = "0x7D1D1C0", VA = "0x187D1E1C0")]
	public JobHandle GIBHBFIGFKC(OFNFOCEBPOF HDOENGOJBKJ, KCFHOMPPIJH JJJNFMILJFE, NativeList<KIEGPPHBLFN.KENJAAMBBKH> AAHJHDLNKPC, float3 BFIHAPKNNFO, quaternion FPCGAIHLJMK, float BIHFAHMMCBL, bool HLDCLHOMCIC, bool KHLAAFDPHLE, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DC60", Offset = "0x7D1CC60", VA = "0x187D1DC60")]
	public static JobHandle DCBLLABKBDH(CJOPLDNPDPH KJIJIHOMHHM, OFNFOCEBPOF HDOENGOJBKJ, NativeArray<int> LELOBBFALIH, JDAJOIBJGCG APDBNIMCPID, JobHandle GMNPCPDAADC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D9B0", Offset = "0x7D1C9B0", VA = "0x187D1D9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BF5230", Offset = "0x5BF4230", VA = "0x185BF5230")]
		public ACJOMKPBFMP(MeshRenderer CCKFDFMBDLN, KONEPKKBNEN.BPAACFHOGHM MEDEJIAPIAI)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7D08120", Offset = "0x7D07120", VA = "0x187D08120")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D14460", Offset = "0x7D13460", VA = "0x187D14460")]
	internal void MCGJMLGDLEM(GameObject GCEIEIMOCNH, KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<ACJOMKPBFMP> ENJOLJLINPM, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7D14CD0", Offset = "0x7D13CD0", VA = "0x187D14CD0")]
	internal void PHAHIMFNJAM(GameObject GCEIEIMOCNH, KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<ACJOMKPBFMP> ENJOLJLINPM, List<LODGroup> FKCEGOEDFMO, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7D12B10", Offset = "0x7D11B10", VA = "0x187D12B10")]
	private MeshRenderer IDIDDMEEIAI(KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, Material CANJBFKPEMF, List<ACJOMKPBFMP> ENJOLJLINPM, bool OFEEHAOIEMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7D11C10", Offset = "0x7D10C10", VA = "0x187D11C10")]
	private List<(List<ACJOMKPBFMP>, float)> GCMMEFOBFLB(KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<LODGroup> FKCEGOEDFMO, Material CANJBFKPEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7D13590", Offset = "0x7D12590", VA = "0x187D13590")]
	private List<List<(List<ACJOMKPBFMP>, float)>> IFPACDBLMEG(KONEPKKBNEN.HCBGFIGAOPH EKGGPPDIPEK, List<LODGroup> FKCEGOEDFMO, Material CANJBFKPEMF, [Out] int OKDJEMEKHEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JNIMLOAOMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D142F0", Offset = "0x7D132F0", VA = "0x187D142F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D16A00", Offset = "0x7D15A00", VA = "0x187D16A00")]
	public static void MDOOIPLBLJB(GameObject GCEIEIMOCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7D15890", Offset = "0x7D14890", VA = "0x187D15890")]
	public void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7D172B0", Offset = "0x7D162B0", VA = "0x187D172B0")]
	public void NIFMMJPCPCL(GameObject GCEIEIMOCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7D16650", Offset = "0x7D15650", VA = "0x187D16650")]
	private bool HELHDCJHMKD(MeshRenderer CCKFDFMBDLN, [Out] MeshFilter HEEKELAELBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7D15670", Offset = "0x7D14670", VA = "0x187D15670")]
	private bool AGIENJEPLDG(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7D167D0", Offset = "0x7D157D0", VA = "0x187D167D0")]
	private void HJEEBHACFLC(GameObject GCEIEIMOCNH, int OHHMJGCBCKD, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7D174F0", Offset = "0x7D164F0", VA = "0x187D174F0")]
	private List<JNIMLOAOMMC.ACJOMKPBFMP> PPAHFHABMDG(int OHHMJGCBCKD, [Out] List<LODGroup> FKCEGOEDFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D160D0", Offset = "0x7D150D0", VA = "0x187D160D0")]
	private List<(int, Material)> DEIABAFGJGP(float MDOIJLBMINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D16020", Offset = "0x7D15020", VA = "0x187D16020")]
	public void AOJNBLCPAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7D16D80", Offset = "0x7D15D80", VA = "0x187D16D80")]
	private bool NHNIIAALMCG(GameObject CEKGANCAJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7D17F10", Offset = "0x7D16F10", VA = "0x187D17F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0FFF0", Offset = "0x7D0EFF0", VA = "0x187D0FFF0")]
		public HCBGFIGAOPH(Bounds HJOECMEGBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7D10160", Offset = "0x7D0F160", VA = "0x187D10160")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D11520", Offset = "0x7D10520", VA = "0x187D11520")]
		private float NDKEHGLBPGB(HCBGFIGAOPH FDJHCIBLFFB, HCBGFIGAOPH CNIMJCCKEDM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D11300", Offset = "0x7D10300", VA = "0x187D11300", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D1BF50", Offset = "0x7D1AF50", VA = "0x187D1BF50")]
	public KONEPKKBNEN(int EJODENHMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A310", Offset = "0x7D19310", VA = "0x187D1A310")]
	private void IGDLCOFAHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F50", Offset = "0x7D17F50", VA = "0x187D18F50")]
	public bool BHLLNIEIMGA(MeshRenderer DPKPFOPKHHF, MeshFilter PPJCNKKDOGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7D18290", Offset = "0x7D17290", VA = "0x187D18290")]
	public bool BHLLNIEIMGA(LODGroup NKOAIGACENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7D19AF0", Offset = "0x7D18AF0", VA = "0x187D19AF0")]
	private bool DGAEJOHLCDJ(MeshRenderer DPKPFOPKHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A930", Offset = "0x7D19930", VA = "0x187D1A930")]
	private int LKHLGCKKNID(MeshRenderer DPKPFOPKHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A8C0", Offset = "0x7D198C0", VA = "0x187D1A8C0")]
	private int KBBHKGBAIBD(LODGroup NKOAIGACENI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A1B0", Offset = "0x7D191B0", VA = "0x187D1A1B0")]
	private int HKKMFDGKHEB(MeshFilter PPJCNKKDOGD, int FPNNGFNMBMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7D19790", Offset = "0x7D18790", VA = "0x187D19790")]
	private int DDDAJOJDAFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7D193E0", Offset = "0x7D183E0", VA = "0x187D193E0")]
	private static HCBGFIGAOPH CFMEGFHKOPA(HCBGFIGAOPH FDJHCIBLFFB, HCBGFIGAOPH CNIMJCCKEDM)
	{
		return default(HCBGFIGAOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7D1BB10", Offset = "0x7D1AB10", VA = "0x187D1BB10")]
	private static float OMHOAJGHPDL(Vector3 JNIBMOMFMLL, Vector3 COJGDIKBGKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7D19C20", Offset = "0x7D18C20", VA = "0x187D19C20")]
	private int ENOFLPGLCPO(int IFGBFFBAKME, HCBGFIGAOPH JMLAFKDDHEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7D19F50", Offset = "0x7D18F50", VA = "0x187D19F50")]
	private void FKPAOPKAGIF(HCBGFIGAOPH JMLAFKDDHEL, int OHHMJGCBCKD, [Out] float GEOHFENLFDH, [Out] float MILCDNNFIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B000", Offset = "0x7D1A000", VA = "0x187D1B000")]
	private void NAMIPDOILIK(HCBGFIGAOPH JMLAFKDDHEL, int PLLDGDDNDJH, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B480", Offset = "0x7D1A480", VA = "0x187D1B480")]
	private float NDKEHGLBPGB(HCBGFIGAOPH FDJHCIBLFFB, HCBGFIGAOPH CNIMJCCKEDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7D1A480", Offset = "0x7D19480", VA = "0x187D1A480")]
	private void IMGBMCOBKJJ(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B6C0", Offset = "0x7D1A6C0", VA = "0x187D1B6C0")]
	private void OBLFHHKPIOI(int LOHCKAAJAJO, int FAJGDEPPNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1AA50", Offset = "0x7D19A50", VA = "0x187D1AA50")]
	private void LOAPBNICCDH(int LOHCKAAJAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7D19B70", Offset = "0x7D18B70", VA = "0x187D19B70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7D20860", Offset = "0x7D1F860", VA = "0x187D20860")]
	public PPAGMPOCDKK(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7D20720", Offset = "0x7D1F720", VA = "0x187D20720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7D20780", Offset = "0x7D1F780", VA = "0x187D20780")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D09FF0", Offset = "0x7D08FF0", VA = "0x187D09FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<HLKPJJDGGOK> LALCNMAENFB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7D09B30", Offset = "0x7D08B30", VA = "0x187D09B30")]
		get
		{
			return default(NativeList<HLKPJJDGGOK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PPAGMPOCDKK JOKKHNAPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7D08C40", Offset = "0x7D07C40", VA = "0x187D08C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7D093A0", Offset = "0x7D083A0", VA = "0x187D093A0")]
	private static void HGMMEBFKNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7D08A90", Offset = "0x7D07A90", VA = "0x187D08A90")]
	public static int AABACNAPLNC(bool FKPHBJJEDHC, int JANHHJILHAO, bool PJCPKAIHNHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7D090F0", Offset = "0x7D080F0", VA = "0x187D090F0")]
	private static int FKJNDPPBNMI(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7D09A30", Offset = "0x7D08A30", VA = "0x187D09A30")]
	private static int JBANMACPJBK(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A070", Offset = "0x7D09070", VA = "0x187D0A070")]
	public static int PEFJMHGLFPA(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7D09F60", Offset = "0x7D08F60", VA = "0x187D09F60")]
	public static int NABMALJFFIG(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7D09A20", Offset = "0x7D08A20", VA = "0x187D09A20")]
	public static int IPENECLKFKG(int NPCDJLLDJOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7D09BD0", Offset = "0x7D08BD0", VA = "0x187D09BD0")]
	private static int LGNFKBCJPJL(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7D09C00", Offset = "0x7D08C00", VA = "0x187D09C00")]
	private static int MAMICGHMAOK(int JANHHJILHAO, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7D099B0", Offset = "0x7D089B0", VA = "0x187D099B0")]
	public static int IACJDBKGHFD(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7D08BB0", Offset = "0x7D07BB0", VA = "0x187D08BB0")]
	public static int CAPEEBNMNJG(int GKGMDAMJCNF, int JANHHJILHAO, int NPCDJLLDJOF, bool LFHBLMMCIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7D09BE0", Offset = "0x7D08BE0", VA = "0x187D09BE0")]
	public static int LIFAGJIOBHK(int NPCDJLLDJOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7D09A40", Offset = "0x7D08A40", VA = "0x187D09A40")]
	public static PPAGMPOCDKK JOBHCKLJIGP(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7D09110", Offset = "0x7D08110", VA = "0x187D09110")]
	private static PPAGMPOCDKK HCAJJNOJMBN(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7D08AC0", Offset = "0x7D07AC0", VA = "0x187D08AC0")]
	public static PPAGMPOCDKK BFABADHCABA(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7D09C20", Offset = "0x7D08C20", VA = "0x187D09C20")]
	private static PPAGMPOCDKK MNBIBHCMHMM(int JANHHJILHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7D08CE0", Offset = "0x7D07CE0", VA = "0x187D08CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0D270", Offset = "0x7D0C270", VA = "0x187D0D270")]
	public FKMOHECEINB(NativeArray<KIKMAHKACEI> IFDPPPNBHEJ, int CFNMLMNHCMF = 1, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D180", Offset = "0x7D0C180", VA = "0x187D0D180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0F4C0", Offset = "0x7D0E4C0", VA = "0x187D0F4C0")]
	public HAFKINHLNCE(OGPFNIIHPFO CGLBPMODFFI, OFNFOCEBPOF EOEDBPGPGOH, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F290", Offset = "0x7D0E290", VA = "0x187D0F290")]
	public HAFKINHLNCE(FKMOHECEINB CGLBPMODFFI, OFNFOCEBPOF EOEDBPGPGOH, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float3 IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F150", Offset = "0x7D0E150", VA = "0x187D0F150")]
	private float3 MCONLNGJOFA(float3 MKCAJAFKDHH, Matrix4x4 LKBMPPNOIOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D3F0", Offset = "0x7D0C3F0", VA = "0x187D0D3F0")]
	private float3x3 DMFNKDAFNOI(float3x3 JALCONLNBJA, float3x3 DJMCMDKONHA)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F140", Offset = "0x7D0E140", VA = "0x187D0F140")]
	private float JMHNFOHCDJE(float HDLKNIPAJGK, float HKIMMIELFOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D9F0", Offset = "0x7D0C9F0", VA = "0x187D0D9F0", Slot = "4")]
	public void Execute(int JDCGPDDDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EFD0", Offset = "0x7D0DFD0", VA = "0x187D0EFD0")]
	private void HGBEBMMHBJE(int NAGECFMHKCN, float3 EPCLGOKLIPO, float3 HPAMHMBDLLL, float3 OFDPNDMFOFN, float PIBKBDEFJIN, bool IJMPJJAJAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EB90", Offset = "0x7D0DB90", VA = "0x187D0EB90")]
	private void FMKFCOIBAHP(LHLKKDNGDMK NIAKGFOFLJM, float3 HNHGJPFCFDL, float3x3 BNLJKPCLJFI, float HDLKNIPAJGK, int PDEKGNANDEB, int NHBCBGLMOEK, int LIIGMANIILP, float LHJOAJGMHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D470", Offset = "0x7D0C470", VA = "0x187D0D470")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D088D0", Offset = "0x7D078D0", VA = "0x187D088D0")]
	public CJOPLDNPDPH(int CFNMLMNHCMF, Allocator NDFENJBGNOB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D08830", Offset = "0x7D07830", VA = "0x187D08830", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0CE70", Offset = "0x7D0BE70", VA = "0x187D0CE70")]
	public FHCEOOEIJBJ(OGPFNIIHPFO CGLBPMODFFI, OFNFOCEBPOF EOEDBPGPGOH, NativeArray<int> AFDIAPKLIIN, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CC60", Offset = "0x7D0BC60", VA = "0x187D0CC60")]
	public FHCEOOEIJBJ(CJOPLDNPDPH APDBNIMCPID, OFNFOCEBPOF EOEDBPGPGOH, NativeArray<int> AFDIAPKLIIN, float3 GKGDHFFAOEC, quaternion AKNHAEBAHIA, float3 IMHICPNBNBF, int NANJPDDHIPF = 0, int PEBJFIBPPOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B8C0", Offset = "0x7D0A8C0", VA = "0x187D0B8C0", Slot = "4")]
	public void Execute(int JDCGPDDDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D0C870", Offset = "0x7D0B870", VA = "0x187D0C870")]
	private void LGKNGLGOHIO(float4x4 PNOMKMDMEID, int JDCGPDDDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B800", Offset = "0x7D0A800", VA = "0x187D0B800")]
	private CGFCFGONJIJ AGGACLAGMCG(float3 HPAMHMBDLLL)
	{
		return default(CGFCFGONJIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B870", Offset = "0x7D0A870", VA = "0x187D0B870")]
	private float4 AKLGOLCHIDL(CGFCFGONJIJ FIFJOOIEEIG, int OHHMJGCBCKD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CC20", Offset = "0x7D0BC20", VA = "0x187D0CC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D10D00", Offset = "0x7D0FD00", VA = "0x187D10D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 OFCFOHFJKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D10A40", Offset = "0x7D0FA40", VA = "0x187D10A40")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D11210", Offset = "0x7D10210", VA = "0x187D11210")]
	public HGNFDNHGFNE(float3 EPCLGOKLIPO, quaternion OOBEGCNALKF, float3 CFNMLMNHCMF, IBEEEDAIOKP MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D10D10", Offset = "0x7D0FD10", VA = "0x187D10D10")]
	public float MLIOFJCKHOC(float3 HNHGJPFCFDL, float MHCEINMANFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D10C10", Offset = "0x7D0FC10", VA = "0x187D10C10")]
	public bool FHFCDEPAPJK(float3 HPAMHMBDLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D10890", Offset = "0x7D0F890", VA = "0x187D10890")]
	public void CBGEOMILEDK(float3 DCHPIGDNFHF, float3x3 OFAKPAGIBDN, float FBEPAIJDGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D10B20", Offset = "0x7D0FB20", VA = "0x187D10B20")]
	private void DOKCLGNKLJE(float3 DJHCIGKJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D10F10", Offset = "0x7D0FF10", VA = "0x187D10F10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D1CD20", Offset = "0x7D1BD20", VA = "0x187D1CD20")]
	public LGIIKECFANG(OFNFOCEBPOF PEPFHNJFNIL, float DNINFCHAJMI, int NGFMNKONPKM, int PDEKGNANDEB, NativeList<HGNFDNHGFNE> APDBNIMCPID, NativeArray<int> KJGCGJFEJCF, NativeList<HLKPJJDGGOK> LEEFHEAECNB, KCFHOMPPIJH JJJNFMILJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C520", Offset = "0x7D1B520", VA = "0x187D1C520", Slot = "4")]
	public void Execute(int KMNFDAIOCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CC60", Offset = "0x7D1BC60", VA = "0x187D1CC60")]
	private bool PPGHOHFFCMH(HGNFDNHGFNE FDJHCIBLFFB, HGNFDNHGFNE CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C290", Offset = "0x7D1B290", VA = "0x187D1C290")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D08A70", Offset = "0x7D07A70", VA = "0x187D08A70")]
	public CJPAMJBNPJC(NativeList<KIEGPPHBLFN.KENJAAMBBKH> AAHJHDLNKPC, NativeArray<int> MMCINHLJGKF, int PEBJFIBPPOJ = 0, int NANJPDDHIPF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D089C0", Offset = "0x7D079C0", VA = "0x187D089C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D18080", Offset = "0x7D17080", VA = "0x187D18080")]
	public void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D17F70", Offset = "0x7D16F70", VA = "0x187D17F70")]
	public static long CIHFDHJPMDB(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D17F90", Offset = "0x7D16F90", VA = "0x187D17F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D181A0", Offset = "0x7D171A0", VA = "0x187D181A0")]
	public void NNOHEEPCFHD(JobHandle GMNPCPDAADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D1D930", Offset = "0x7D1C930", VA = "0x187D1D930")]
	public NKAEONOKLPM(OFNFOCEBPOF PEPFHNJFNIL, KCFHOMPPIJH JJJNFMILJFE, int PEBJFIBPPOJ = 0, int NANJPDDHIPF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D550", Offset = "0x7D1C550", VA = "0x187D1D550", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D4F0", Offset = "0x7D1C4F0", VA = "0x187D1D4F0")]
	private void EHCFKBGMAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class OHMOJFHAKKH
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x39D30C0", Offset = "0x39D20C0", VA = "0x1839D30C0")]
	public static bool GLNJLHBIKLI<T>(NativeArray<T> NBBLCIBNPBK, int CFNMLMNHCMF, Allocator NDFENJBGNOB, NativeArrayOptions BFEGEHMOFBB = NativeArrayOptions.ClearMemory, int FFGKPGJAGLC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x39D3240", Offset = "0x39D2240", VA = "0x1839D3240")]
	public static bool GLNJLHBIKLI<T>(NativeList<T> OLEDHEBBJPH, int CFNMLMNHCMF, Allocator NDFENJBGNOB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x39D3300", Offset = "0x39D2300", VA = "0x1839D3300")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0D3A0", Offset = "0x7D0C3A0", VA = "0x187D0D3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0B140", Offset = "0x7D0A140", VA = "0x187D0B140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BGNONGNFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AC30", Offset = "0x7D09C30", VA = "0x187D0AC30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CDDHBHBHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AC70", Offset = "0x7D09C70", VA = "0x187D0AC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B180", Offset = "0x7D0A180", VA = "0x187D0B180")]
	public EOAHKPEMMBH(int DIGNHEFBOML, int FNBPJBGCLCH, int KAKPOFOFIMJ, Allocator NDFENJBGNOB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B4A0", Offset = "0x7D0A4A0", VA = "0x187D0B4A0")]
	public EOAHKPEMMBH(Mesh PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A270", Offset = "0x7D09270", VA = "0x187D0A270", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A900", Offset = "0x7D09900", VA = "0x187D0A900")]
	public void FMLNAEFDMPJ(EOAHKPEMMBH PEPFHNJFNIL, bool NDFHEDFGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D0ACB0", Offset = "0x7D09CB0", VA = "0x187D0ACB0")]
	private void LFEIDICIOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A390", Offset = "0x7D09390", VA = "0x187D0A390")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F256F0", Offset = "0x1F246F0", VA = "0x181F256F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HLKPJJDGGOK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EOAHKPEMMBH LNGKDJGKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D102E0", Offset = "0x7D0F2E0", VA = "0x187D102E0")]
	public HEFAOEOOFNP(IEnumerable<EOAHKPEMMBH> LHHLMCNOLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D10270", Offset = "0x7D0F270", VA = "0x187D10270", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D32470", Offset = "0x7D31470", VA = "0x187D32470")]
	public static void DMLDIIKDBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D328C0", Offset = "0x7D318C0", VA = "0x187D328C0")]
	public static NativeArray<float2> IIOPPMILMDC(NativeArray<float2> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<float2> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D326A0", Offset = "0x7D316A0", VA = "0x187D326A0")]
	public static NativeArray<float3> ICCJMNAJBGM(NativeArray<float3> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<float3> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D32590", Offset = "0x7D31590", VA = "0x187D32590")]
	public static NativeArray<float4> GIIMAMPFHJI(NativeArray<float4> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<float4> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D327B0", Offset = "0x7D317B0", VA = "0x187D327B0")]
	public static NativeArray<int> IHHKEHMPOKL(NativeArray<int> AMMCHPKGMIO, int LFCHDMPEKLH, NativeArray<int> FCPPEIDFJCI, int OOCBKAJLBEA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x38F74F0", Offset = "0x38F64F0", VA = "0x1838F74F0")]
	private static void HGPKPKKHHGD<T>(NativeArray<T> NBBLCIBNPBK, int EADJNMBLKGB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x38F76F0", Offset = "0x38F66F0", VA = "0x1838F76F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D23FF0", Offset = "0x7D22FF0", VA = "0x187D23FF0")]
	public static uint MMJGNBPOAIL(float IMMJFOGEMML)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D23DE0", Offset = "0x7D22DE0", VA = "0x187D23DE0")]
	public static void JMAKEELBKHN(float4 LGPLODMABGM, float NMIFPOIKKGC, [Out] uint PAAMDIOPIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D23EF0", Offset = "0x7D22EF0", VA = "0x187D23EF0")]
	public static void JMAKEELBKHN(float4 LGPLODMABGM, uint CBNAJPDNLMO, [Out] uint PAAMDIOPIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D23740", Offset = "0x7D22740", VA = "0x187D23740")]
	public static void EIIKHCAGCIC(float3 PEJBFAIMGPM, float3 GGFHJLKGAPJ, float4 NJFMHOCNFOJ, float2 HJOLBLABKBE, float4 LGPLODMABGM, [Out] OFNFOCEBPOF.FBAFEBCICFD LLONNDJOFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D234E0", Offset = "0x7D224E0", VA = "0x187D234E0")]
	public static void EIIKHCAGCIC(float3 PEJBFAIMGPM, float3 GGFHJLKGAPJ, float4 NJFMHOCNFOJ, float2 HJOLBLABKBE, float4 LGPLODMABGM, [Out] OFNFOCEBPOF.IMGNLKODGID LLONNDJOFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D23490", Offset = "0x7D22490", VA = "0x187D23490")]
	public static byte BHJBMAOFJGN(float OHLIHBDBKCE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D23AE0", Offset = "0x7D22AE0", VA = "0x187D23AE0")]
	public static ushort GPHHEDJILJJ(float OHLIHBDBKCE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D23FC0", Offset = "0x7D22FC0", VA = "0x187D23FC0")]
	public static uint KFACFEJOHOC(float OHLIHBDBKCE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D24000", Offset = "0x7D23000", VA = "0x187D24000")]
	public static float2 PFJAKJPNNFA(float2 IINHKHEMEHJ)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D23C90", Offset = "0x7D22C90", VA = "0x187D23C90")]
	public static float2 IIOKDEOCNNN(float3 KLJKHLHNLGP)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D23990", Offset = "0x7D22990", VA = "0x187D23990")]
	public static void EPMHANPBBGG(float3 OHLIHBDBKCE, [Out] float3 KOJNCDLOJGM, [Out] uint3 INJADOKLMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D23B30", Offset = "0x7D22B30", VA = "0x187D23B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void ODFMLCAGHLK(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D37B30", Offset = "0x7D36B30", VA = "0x187D37B30")]
	public static float CDLNNDCENDL(float PIBHOPJHMPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D38120", Offset = "0x7D37120", VA = "0x187D38120")]
	public static long LNBOAKOKHDL(float PIBHOPJHMPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D37C40", Offset = "0x7D36C40", VA = "0x187D37C40")]
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
	public enum EFDIDNEFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		ShapesTreeError,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private struct HFNKKHGAGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public EFDIDNEFLNE MLCOGCMJLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public float DPEJEDCKJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public BatchedMeshRenderer GNGHHGBBENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public OKLBNCJDEJN MDMBKCJOCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public KIEGPPHBLFN MFGCAEHJHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public long CPGPBKMBLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public long CGJDFBAGDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public float CJHIJOLEKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public bool HIPGEMGOHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public bool EJDLPFHEGFC;
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
	private static List<HFNKKHGAGOC> GCHCLDFPPLC;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static HLLMMEMBNDA KJKEHBDEPEM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool EBGPEBAPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E940", Offset = "0x7D2D940", VA = "0x187D2E940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void ODFMLCAGHLK(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON, string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7D31D70", Offset = "0x7D30D70", VA = "0x187D31D70")]
	public static void KHOHAHNIDCC(HLLMMEMBNDA CHMAPGDFMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E1B0", Offset = "0x7D2D1B0", VA = "0x187D2E1B0")]
	public static (long, long, long, int, int) BGLGAFLABFB(long PEALIDAKJHK)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E780", Offset = "0x7D2D780", VA = "0x187D2E780")]
	public static void EBOOPHMGPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F730", Offset = "0x7D2E730", VA = "0x187D2F730")]
	public static void KFJOABALDDM(long PEALIDAKJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EF30", Offset = "0x7D2DF30", VA = "0x187D2EF30")]
	public static void HLFIAJOJEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7D32070", Offset = "0x7D31070", VA = "0x187D32070")]
	public static long PALMNFJKMNN(long EGAJOCMKJMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F180", Offset = "0x7D2E180", VA = "0x187D2F180")]
	public static bool IBEJENGKFKL(long DKPCCCOICNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7D31DE0", Offset = "0x7D30DE0", VA = "0x187D31DE0")]
	public static bool KIAAKBDMJOI(long DKPCCCOICNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F250", Offset = "0x7D2E250", VA = "0x187D2F250")]
	public static float IIADEAEDMOD(long HHEINPINFCI, int NEDAFANGOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E370", Offset = "0x7D2D370", VA = "0x187D2E370")]
	public static (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E990", Offset = "0x7D2D990", VA = "0x187D2E990")]
	public static void GOJGPDGPLCL(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float BGMGMDOKLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F5B0", Offset = "0x7D2E5B0", VA = "0x187D2F5B0")]
	public static void KEPDLMNEFME(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float EJEMMHMJBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7D31EB0", Offset = "0x7D30EB0", VA = "0x187D31EB0")]
	public static void KLKFMBDMNLI(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long CGJDFBAGDGJ, float EJEMMHMJBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EFD0", Offset = "0x7D2DFD0", VA = "0x187D2EFD0")]
	public static void HNGOHKHDFBM(KIEGPPHBLFN MFGCAEHJHKA, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float EJEMMHMJBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EC30", Offset = "0x7D2DC30", VA = "0x187D2EC30")]
	public static void HFJECCHCBKO(EFDIDNEFLNE MLCOGCMJLBB, KIEGPPHBLFN MFGCAEHJHKA, OKLBNCJDEJN MDMBKCJOCLD, BatchedMeshRenderer GNGHHGBBENK, long GOBPKGMJOBF, long CGJDFBAGDGJ, float FLCLOHJLIBD, bool HIPGEMGOHFB, bool EJDLPFHEGFC, float DPEJEDCKJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E800", Offset = "0x7D2D800", VA = "0x187D2E800")]
	public static bool ENMBNGPPIBO(float IGNCNIBEICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E8C0", Offset = "0x7D2D8C0", VA = "0x187D2E8C0")]
	public static void GIEHHKCPPHG(float IGNCNIBEICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EB20", Offset = "0x7D2DB20", VA = "0x187D2EB20")]
	public static bool HEFEMCKNCCN(float IGNCNIBEICE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class OKLBNCJDEJN
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal enum IPMJJNHCILH
	{
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly string PGFLPNJOEPJ;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly string IKNDBHDGGDB;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly ProfilerMarker FNAJPENHMLH;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly ProfilerMarker LCBOJDFKNOD;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static readonly ProfilerMarker DPCGKHCJHLG;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly ProfilerMarker FJOAAEBIDPB;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly ProfilerMarker MICOIJLNCCP;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker ABAEJANLMAB;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker JFPCJBHEKAE;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker MPHJOIFFBFK;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker DGFFFJILGNE;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker DLFAKAPAPPO;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly ProfilerMarker NFFLLLJMBPO;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ProfilerMarker ENNGHFOPOFG;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly ProfilerMarker FFKIDFLCHPP;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly ProfilerMarker MOIFJEBHJCI;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker BDHCHEGNFHJ;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker HFMJMFBNFJF;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker GBKPMIODOKH;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker GCEAIMMJLKK;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker IHBDDLHEBGF;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker HPKIMBECMBA;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker EBGLJMEHBBG;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker KMFPNFNJLDH;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker JPKDJCHJCHJ;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker PAEMPBBKHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	internal readonly List<KIEGPPHBLFN> BCKJDJNALEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal KIEGPPHBLFN AHAFOOKHLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly JMJECAHGFJF JCJFJOJNKFG;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const bool GAPGOHJAAKC = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public bool BILPGNOAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal IPMJJNHCILH DJKDJIIOKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal int DHEHBEBJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	internal int PPKEMHGDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	internal int LGEFBLLCGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	internal int PJGJFPDHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal long JOFBFDNOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal long GMLDMLHBDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	internal long NHOEOPHPELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private OFNFOCEBPOF KOLJDAHJPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private OFNFOCEBPOF GBCONBGDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private OFNFOCEBPOF.LEBCKMKDBPC COJNCIPFOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private bool GBCCGEKFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private int CHOOKLMEMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private ABCMFHEJJCN GJILMBCILAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private float3 DJBCCFDDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private float OJHDMDBMBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private float LIDFPCDMLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private float PIEHDDOAAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private float KDIMKMDPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private float BEDHIPHEFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private float AKEKJELKIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private float3 PDABGDDCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private float MJEOABFFPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private float BFLHELODNEF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal Mesh LNGKDJGKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshFilter PIMGPMNEIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MeshRenderer BGCKPPIPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public List<Material> EOJLILILMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DBDFEINPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7D34680", Offset = "0x7D33680", VA = "0x187D34680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int KJBPKKGOPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xD62EF0", Offset = "0xD61EF0", VA = "0x180D62EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7D36C50", Offset = "0x7D35C50", VA = "0x187D36C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7D34D50", Offset = "0x7D33D50", VA = "0x187D34D50")]
	public void IDCDIEPLCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7D35D00", Offset = "0x7D34D00", VA = "0x187D35D00")]
	public bool LDCHGOPEJAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7D34720", Offset = "0x7D33720", VA = "0x187D34720")]
	private void GJDFODNHJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7D35120", Offset = "0x7D34120", VA = "0x187D35120")]
	private void JJANJBBCDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7D37990", Offset = "0x7D36990", VA = "0x187D37990")]
	public OKLBNCJDEJN(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7D36C80", Offset = "0x7D35C80", VA = "0x187D36C80")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7D33250", Offset = "0x7D32250", VA = "0x187D33250")]
	private void CEHJGLHOEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7D34F10", Offset = "0x7D33F10", VA = "0x187D34F10")]
	private void IOAAMJGJDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7D34E80", Offset = "0x7D33E80", VA = "0x187D34E80")]
	public Mesh IDJNOLAGOHG(MeshFilter HEEKELAELBC, Transform KOOMPFGMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7D32FF0", Offset = "0x7D31FF0", VA = "0x187D32FF0")]
	private void BJEHFPNNCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7D34840", Offset = "0x7D33840", VA = "0x187D34840")]
	public void GKAHHFADIKG(NGPLIHHOGDL CKADCHJDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7D35F60", Offset = "0x7D34F60", VA = "0x187D35F60")]
	public bool LJCLACKMCGP(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7D33BC0", Offset = "0x7D32BC0", VA = "0x187D33BC0")]
	public bool DGAEJOHLCDJ(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7D36B30", Offset = "0x7D35B30", VA = "0x187D36B30", Slot = "4")]
	public virtual void NCJBLPKGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7D340F0", Offset = "0x7D330F0", VA = "0x187D340F0")]
	public void EDHIDPPEGOP(Transform HGJDCEPMKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7D34980", Offset = "0x7D33980", VA = "0x187D34980")]
	public bool HFFKNJPAFNM(Transform HGJDCEPMKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7D332F0", Offset = "0x7D322F0", VA = "0x187D332F0")]
	public bool CFJAKFPLIMB(bool NFBBHICBOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7D33E90", Offset = "0x7D32E90", VA = "0x187D33E90")]
	private void DLJLODJEICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7D35270", Offset = "0x7D34270", VA = "0x187D35270")]
	public bool KFJOABALDDM(float4x4 LGKMMMDABOH, BatchedMeshRenderer FFMJKENGIND, bool GJIIIIPFFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7D329D0", Offset = "0x7D319D0", VA = "0x187D329D0")]
	public bool ACODGKFBDLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7D33E50", Offset = "0x7D32E50", VA = "0x187D33E50")]
	public void DLCLDGNEFOA(OFNFOCEBPOF PEPFHNJFNIL, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7D346A0", Offset = "0x7D336A0", VA = "0x187D346A0")]
	public (long, long, long) GEBEHCBKDIL()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
	public long BHOHLEFECOC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D33AA0", Offset = "0x7D32AA0", VA = "0x187D33AA0")]
	private void CJBIHHKBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7D33830", Offset = "0x7D32830", VA = "0x187D33830")]
	public (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ, float4x4 LGKMMMDABOH)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7D330F0", Offset = "0x7D320F0", VA = "0x187D330F0")]
	internal void BODCAGEIIMC(IPMJJNHCILH FNMJJEKIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D36420", Offset = "0x7D35420", VA = "0x187D36420")]
	internal (float, float, float, float) MGHFPLJMBBH(float FJFDDHAMEMN, float4x4 LGKMMMDABOH)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7D33F10", Offset = "0x7D32F10", VA = "0x187D33F10")]
	public void EBPHGGHMLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7D33C50", Offset = "0x7D32C50", VA = "0x187D33C50")]
	private void DIJNINBJOCB(OFNFOCEBPOF FILHENAJMCB, OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D36B10", Offset = "0x7D35B10", VA = "0x187D36B10")]
	private void MOJMHHDDPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7D32EE0", Offset = "0x7D31EE0", VA = "0x187D32EE0")]
	internal bool AIKMBJDBOND(bool NFBBHICBOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7D343F0", Offset = "0x7D333F0", VA = "0x187D343F0")]
	private void FBMLNMAJAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7D36030", Offset = "0x7D35030", VA = "0x187D36030")]
	private void MELEPHGOLNJ([In] DJEOHGJJNMK FILHENAJMCB, OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH, bool JLIOEHLJPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7D33110", Offset = "0x7D32110", VA = "0x187D33110")]
	private void BPKOIIOOEGI(OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7D331B0", Offset = "0x7D321B0", VA = "0x187D331B0")]
	private void CANENMFBHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7D35E20", Offset = "0x7D34E20", VA = "0x187D35E20")]
	private void LEAOEBJLOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7D36FC0", Offset = "0x7D35FC0", VA = "0x187D36FC0")]
	public long PALMNFJKMNN(long EGAJOCMKJMK, int JOGNGOBMBGL)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KIEGPPHBLFN
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal enum KJKDKCHNEAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public struct KENJAAMBBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int EKBPMBFJFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int FMDPDNGNNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public float GEOHFENLFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public struct IPFDINKKAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public DJEOHGJJNMK PEPFHNJFNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int LCHLGDKJDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int JKIIGAFGOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public long CPDNGBOPBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public long ODHBKBHJMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public float BFCALILILML;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7D24110", Offset = "0x7D23110", VA = "0x187D24110")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7D24140", Offset = "0x7D23140", VA = "0x187D24140")]
		public void NNOHEEPCFHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private static readonly string PGFLPNJOEPJ;

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private static readonly string IKNDBHDGGDB;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private static readonly ProfilerMarker FNAJPENHMLH;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private static readonly ProfilerMarker LCBOJDFKNOD;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private static readonly ProfilerMarker DPCGKHCJHLG;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private static readonly ProfilerMarker FJOAAEBIDPB;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private static readonly ProfilerMarker MICOIJLNCCP;

	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private static readonly ProfilerMarker ABAEJANLMAB;

	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private static readonly ProfilerMarker JFPCJBHEKAE;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly ProfilerMarker MPHJOIFFBFK;

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly ProfilerMarker DGFFFJILGNE;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly ProfilerMarker DLFAKAPAPPO;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly ProfilerMarker NFFLLLJMBPO;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly ProfilerMarker ENNGHFOPOFG;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly ProfilerMarker FFKIDFLCHPP;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly ProfilerMarker MOIFJEBHJCI;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker BDHCHEGNFHJ;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker HFMJMFBNFJF;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker GBKPMIODOKH;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker GCEAIMMJLKK;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker IHBDDLHEBGF;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker HPKIMBECMBA;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker EBGLJMEHBBG;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker KMFPNFNJLDH;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker JPKDJCHJCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker PAEMPBBKHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	internal readonly List<NGPLIHHOGDL> PPBIAJGFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	internal OKLBNCJDEJN COOHKPAHMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly JMJECAHGFJF JCJFJOJNKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	internal int AIPIIJPJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	internal int CLHEPMAODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	internal bool AKMIKPJCPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	internal bool JGKHLJOIEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	internal KJKDKCHNEAG DJEALEBAKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	internal bool DAOGILHBBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	internal float3 PLLIPJINCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal float3 LBJGFMAKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal float ADGLAAPPBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal int AJLPCMCJBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal int DNODFBPLGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal float LDOEAOHAIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal float MACMBEFBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	internal int NJALEADMPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal long DFJAIOFHHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public int MNMDCGFDOJG;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal const int MFHBAMDGDDB = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal float[] NFPHBEFEELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal int[] OALCIJEAPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal long[] BLIKNHIEOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public List<IPFDINKKAHO> GFKMIFKJBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal OFNFOCEBPOF BHEEMNLAGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal long LNBPHLJMFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int HKIGKOFCDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal float CMAEJNPNCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal OFNFOCEBPOF.LEBCKMKDBPC MGIEJFJPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal bool MNKEHMLJCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal JHGLNBKNNFF FPJMMFBBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal JobHandle HEGCFMLHGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal NativeList<KENJAAMBBKH> NNGFLGLIBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal NativeArray<long> FKLALGKOOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal bool ECOBMJBBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal JobHandle CBAKBHOPEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal OFNFOCEBPOF NOILONCKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal KCFHOMPPIJH BHPNPBDDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal NativeList<KENJAAMBBKH> OFLGMNLFJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal Transform EDEIOKDDPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal OEDNPOAFIDC ENPAKIMCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal long OAODDOGCPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal long EOPDNPNNDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal long CFDNAGMOCMG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<NGPLIHHOGDL> EMLDEFIHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CAB0", Offset = "0x7D2BAB0", VA = "0x187D2CAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A9F0", Offset = "0x7D299F0", VA = "0x187D2A9F0")]
	internal void IDCDIEPLCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7D29900", Offset = "0x7D28900", VA = "0x187D29900")]
	internal void GJDFODNHJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2DE90", Offset = "0x7D2CE90", VA = "0x187D2DE90")]
	internal KIEGPPHBLFN(string NFHOBPDKIPM, OKLBNCJDEJN JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CAD0", Offset = "0x7D2BAD0", VA = "0x187D2CAD0")]
	internal void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7D257C0", Offset = "0x7D247C0", VA = "0x187D257C0")]
	internal void BJEHFPNNCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7D29AD0", Offset = "0x7D28AD0", VA = "0x187D29AD0")]
	internal void GKAHHFADIKG(NGPLIHHOGDL CKADCHJDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C2B0", Offset = "0x7D2B2B0", VA = "0x187D2C2B0")]
	internal bool LJCLACKMCGP(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7D28070", Offset = "0x7D27070", VA = "0x187D28070")]
	internal bool DGAEJOHLCDJ(NGPLIHHOGDL CKADCHJDBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CA20", Offset = "0x7D2BA20", VA = "0x187D2CA20", Slot = "4")]
	internal virtual void NCJBLPKGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AA00", Offset = "0x7D29A00", VA = "0x187D2AA00")]
	internal long IFBKDMCPCKM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7D25AD0", Offset = "0x7D24AD0", VA = "0x187D25AD0")]
	internal long CEJNIPGGGEA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7D29D10", Offset = "0x7D28D10", VA = "0x187D29D10")]
	internal bool HFFKNJPAFNM(Transform HGJDCEPMKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7D25BF0", Offset = "0x7D24BF0", VA = "0x187D25BF0")]
	internal (bool, OFNFOCEBPOF) CFJAKFPLIMB(bool NFBBHICBOCM)
	{
		return default((bool, OFNFOCEBPOF));
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7D28100", Offset = "0x7D27100", VA = "0x187D28100")]
	internal void DLJLODJEICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AB40", Offset = "0x7D29B40", VA = "0x187D2AB40")]
	internal bool KFJOABALDDM(float4x4 LGKMMMDABOH, BatchedMeshRenderer FFMJKENGIND, bool GJIIIIPFFAO, bool HCBIKIDPBJH, float LIDFPCDMLKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7D241C0", Offset = "0x7D231C0", VA = "0x187D241C0")]
	public (bool, DJEOHGJJNMK) ACODGKFBDLM()
	{
		return default((bool, DJEOHGJJNMK));
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A970", Offset = "0x7D29970", VA = "0x187D2A970")]
	internal void ICCLDHEADOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7D29690", Offset = "0x7D28690", VA = "0x187D29690")]
	internal bool GAKAILLGOAH(bool NFBBHICBOCM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7D24BA0", Offset = "0x7D23BA0", VA = "0x187D24BA0")]
	internal void AKHNEANJAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7D280D0", Offset = "0x7D270D0", VA = "0x187D280D0")]
	internal void DLCLDGNEFOA(OFNFOCEBPOF PEPFHNJFNIL, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7D27DE0", Offset = "0x7D26DE0", VA = "0x187D27DE0")]
	internal void DFAEJJMBBHF(DJEOHGJJNMK IBOMCMKODKN, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7D26BC0", Offset = "0x7D25BC0", VA = "0x187D26BC0")]
	internal void CJBIHHKBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7D26750", Offset = "0x7D25750", VA = "0x187D26750")]
	internal (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ, float4x4 LGKMMMDABOH)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7D25A50", Offset = "0x7D24A50", VA = "0x187D25A50")]
	internal void BODCAGEIIMC(KJKDKCHNEAG FNMJJEKIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C330", Offset = "0x7D2B330", VA = "0x187D2C330")]
	internal (float, float, float, float) MGHFPLJMBBH(float FJFDDHAMEMN, float4x4 LGKMMMDABOH)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CC20", Offset = "0x7D2BC20", VA = "0x187D2CC20")]
	private float NPAFOMEOIEI(float FJFDDHAMEMN, float4x4 LGKMMMDABOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7D26FB0", Offset = "0x7D25FB0", VA = "0x187D26FB0")]
	private (int, int) COPNLBBCPGH(float KGGOMNHAOBH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7D287A0", Offset = "0x7D277A0", VA = "0x187D287A0")]
	internal static float DOKLMOHCFGO(NGPLIHHOGDL PEPFHNJFNIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7D28850", Offset = "0x7D27850", VA = "0x187D28850")]
	internal void EBPHGGHMLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7D25AA0", Offset = "0x7D24AA0", VA = "0x187D25AA0")]
	internal void CANENMFBHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7D2BF90", Offset = "0x7D2AF90", VA = "0x187D2BF90")]
	internal void LEAOEBJLOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CC80", Offset = "0x7D2BC80", VA = "0x187D2CC80")]
	internal long PALMNFJKMNN(long EGAJOCMKJMK, int JOGNGOBMBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7D24BB0", Offset = "0x7D23BB0", VA = "0x187D24BB0")]
	private void BEFBAHLEKCI(OFNFOCEBPOF HGGCKJDDOHE, NativeList<KENJAAMBBKH> GEKDPOOGDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2D3C0", Offset = "0x7D2C3C0", VA = "0x187D2D3C0")]
	internal void PBOODEFIHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7D24510", Offset = "0x7D23510", VA = "0x187D24510")]
	public static void AHJIOGMHPPJ(NativeList<KENJAAMBBKH> DBLDEKKHPME, OFNFOCEBPOF HGGCKJDDOHE, int BNPNOAKCENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AAB0", Offset = "0x7D29AB0", VA = "0x187D2AAB0")]
	private float IGDICFLEAJN(int DEIGALACOAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7D27470", Offset = "0x7D26470", VA = "0x187D27470")]
	internal void DDJEGJLCHON(OFNFOCEBPOF PEPFHNJFNIL, MCBEKGNCHGM IBOMCMKODKN, int BPCKFHGMDCH, int KFONBKENEBN, float MJLAJINBOCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[BurstCompile]
internal struct BOHDEDACFHI : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal struct KBPLDIILAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int PMHEMKBIHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int JOMACOEKKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int BFNBHKLOKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public float OJFIOHPCCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public float KEPMGPLCLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public float ODENFOCIAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public float LEDOGHHPLJD;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	internal struct FLAFLLPCELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int PMHEMKBIHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int JOMACOEKKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int BFNBHKLOKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int CMCDFHLHMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float OJFIOHPCCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float KEPMGPLCLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public float AIPHGFOAILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public float OMKGIKGKCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public float LEDOGHHPLJD;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct FCPPCFEKBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int FFEADIJLAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int APELBFMPDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float NIONLFLEEAC;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public delegate void LOAGJODGBBN(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI);

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal static class FMCMAPOLKOK
	{
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7D46860", Offset = "0x7D45860", VA = "0x187D46860")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7D46990", Offset = "0x7D45990", VA = "0x187D46990")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7D467B0", Offset = "0x7D457B0", VA = "0x187D467B0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7D465C0", Offset = "0x7D455C0", VA = "0x187D465C0")]
		public static void CIBKKMOJDEC(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public delegate void BLCMBJNILII(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF);

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	internal static class OHHAIAFPJPO
	{
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B350", Offset = "0x7D4A350", VA = "0x187D4B350")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B480", Offset = "0x7D4A480", VA = "0x187D4B480")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B2A0", Offset = "0x7D4A2A0", VA = "0x187D4B2A0")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B0B0", Offset = "0x7D4A0B0", VA = "0x187D4B0B0")]
		public static void CIBKKMOJDEC(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public unsafe delegate void NLPBGHBLPFD(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class POIOBDPFGLN
	{
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B9D0", Offset = "0x7D4A9D0", VA = "0x187D4B9D0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7D4BB00", Offset = "0x7D4AB00", VA = "0x187D4BB00")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B920", Offset = "0x7D4A920", VA = "0x187D4B920")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B5E0", Offset = "0x7D4A5E0", VA = "0x187D4B5E0")]
		public unsafe static void CIBKKMOJDEC(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public float3 DJBCCFDDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public float IGPPPLENBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public float BHDFPDNCIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public float IFPFOIMMOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public DJEMCOGPGPN.MOIMOJMJGIK CFMNIDCDCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public bool IPCDMMKHJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<KBPLDIILAHM>* DAABNPFNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<KBPLDIILAHM>* NADDILLPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FLAFLLPCELD>* CHNHGGPIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<FLAFLLPCELD>* NOOJNILKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public int NFNGHJPKMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public int LJPNLOJEPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public int JINMGHBPDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe float3* PNKEBNMKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* KBHGLKELPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe FCPPCFEKBJB* NOMCIBPFMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7D21C90", Offset = "0x7D20C90", VA = "0x187D21C90")]
	private static float FGGGHOFDHKK([In] BOHDEDACFHI CGEOHHFDFLP, [In] float3 PLHNJIACDML, float LEDOGHHPLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7D232B0", Offset = "0x7D222B0", VA = "0x187D232B0")]
	private static int JNPFOJKAMCK(BOHDEDACFHI CGEOHHFDFLP, [Out] BBKDCNPBHFC HDGKBLEEFBG, [In] BBKDCNPBHFC GEDOHNGAGEA, [In] BBKDCNPBHFC FHONHCNDHIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7D22A40", Offset = "0x7D21A40", VA = "0x187D22A40")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void FNKDBOPAGMF(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7D23430", Offset = "0x7D22430", VA = "0x187D23430")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void KHLKOEFNKOH(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7D21C80", Offset = "0x7D20C80", VA = "0x187D21C80", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7D21D10", Offset = "0x7D20D10", VA = "0x187D21D10")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void FKEJBGGHEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7D21BF0", Offset = "0x7D20BF0", VA = "0x187D21BF0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal unsafe static void EOICMLPMDLF(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7D20B40", Offset = "0x7D1FB40", VA = "0x187D20B40")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void ABOFBAJCHME(BOHDEDACFHI CGEOHHFDFLP, [In] KBPLDIILAHM NLBHOELMMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7D22AA0", Offset = "0x7D21AA0", VA = "0x187D22AA0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void HOACFINEJLM(BOHDEDACFHI CGEOHHFDFLP, [In] FLAFLLPCELD NNPFAAIFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7D214E0", Offset = "0x7D204E0", VA = "0x187D214E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void EMCENIODHGJ(UnsafeList<int>* GDJACPJDNHO, UnsafeList<float3>* AMPCDHGKMDB, [NoAlias] float3* GEPBFFIAHDB, [NoAlias] float4* HFGPGKNIPEF, [NoAlias] float2* MFFPGMGFPAD, [NoAlias] float4* KMFICPLNPAP, UnsafeList<BBKDCNPBHFC>* EFGPMMFFANO, UnsafeList<int>* GJNIFHIHHDK, UnsafeList<float3>* PNKEBNMKJBC, [NoAlias] float3* BMNDDCOKHMN, [NoAlias] float4* JOFJAHOGEMG, [NoAlias] float2* JEOOBFCDPNJ, [NoAlias] float4* CONHJNGNILN, int FNBPJBGCLCH, int DIGNHEFBOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class ABCMFHEJJCN
{
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly ProfilerMarker PNIFHDDONCC;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public const int INKCMKMMMEN = 2;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private const int MOIKFFGJCGM = 1;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private static int OEOHDCDILNI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private static Stack<ABCMFHEJJCN> DIAIIADFCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private OFNFOCEBPOF EACPFMONOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private NativeList<BBKDCNPBHFC> EFGPMMFFANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private NativeList<int> GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private NativeList<BOHDEDACFHI.KBPLDIILAHM> DAABNPFNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private NativeList<BOHDEDACFHI.KBPLDIILAHM> NADDILLPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private NativeList<BOHDEDACFHI.FLAFLLPCELD> CHNHGGPIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private NativeList<BOHDEDACFHI.FLAFLLPCELD> NOOJNILKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private BOHDEDACFHI CGEOHHFDFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private JobHandle GMNPCPDAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private BOHDEDACFHI.FCPPCFEKBJB DPGHBGKGJJF;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private const int JINMGHBPDOH = 65530;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AE90", Offset = "0x7D39E90", VA = "0x187D3AE90")]
	private ABCMFHEJJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A0F0", Offset = "0x7D390F0", VA = "0x187D3A0F0")]
	public void HMOCHDHCPJB(OFNFOCEBPOF KCAJOKAPNNO, float3 FFNEGGILCGD, float IJHICCMOGNJ, float LFNLKNCHBCA, float BKJCNPALMMN, List<KIEGPPHBLFN.KENJAAMBBKH> AMKCGFLMMEA, Allocator BHCMOBHIMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A6C0", Offset = "0x7D396C0", VA = "0x187D3A6C0")]
	public (bool, OFNFOCEBPOF, float) LPOELFGCLHC(List<KIEGPPHBLFN.KENJAAMBBKH> AMKCGFLMMEA, Allocator BHCMOBHIMNL, bool NFBBHICBOCM)
	{
		return default((bool, OFNFOCEBPOF, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A500", Offset = "0x7D39500", VA = "0x187D3A500")]
	public static bool JDFHOJOPABO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A080", Offset = "0x7D39080", VA = "0x187D3A080")]
	public static int GKDFIBGHGBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A560", Offset = "0x7D39560", VA = "0x187D3A560")]
	public static ABCMFHEJJCN KGKKIMABGBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AD00", Offset = "0x7D39D00", VA = "0x187D3AD00")]
	internal static void PAIJEJJJMFM(ABCMFHEJJCN PCPLJGHHMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7D39F10", Offset = "0x7D38F10", VA = "0x187D39F10")]
	public static void EDJCMGEEDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7D39D60", Offset = "0x7D38D60", VA = "0x187D39D60")]
	[FELFDMPPKKE(MGEKOJDDIFB.ExitingPlayMode, 0)]
	public static void DMLDIIKDBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[BurstCompile]
internal struct BBKDCNPBHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public float3 HNHGJPFCFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public int NBLENEGBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public int EGIENMMHOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public int HPMHNIMECMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public float OGHIHEEPHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public float DIOLJKHFBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public int ONNLBAOHLJN;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B030", Offset = "0x7D3A030", VA = "0x187D3B030")]
	public static void FLLMCNLHKNL([Out] BBKDCNPBHFC OBOOAPELMPF, int EIEJGMPBHAI, [In] float3 JGKKPDAOHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B080", Offset = "0x7D3A080", VA = "0x187D3B080")]
	[IgnoreWarning(1371)]
	public static void FLLMCNLHKNL([Out] BBKDCNPBHFC OBOOAPELMPF, [In] BBKDCNPBHFC PPMLHPJGPIJ, [In] BBKDCNPBHFC IFMEGLHJPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[BurstCompile]
internal struct JHGLNBKNNFF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private struct KCBPLANBOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int BCOFGICOGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int KIGCHGNGBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public int PNDNCJCLMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int OMHDOAKHGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int AOHFPEEPFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int HMFKKFNJLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int LCHLGDKJDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int JKIIGAFGOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public float BFCALILILML;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct PDCMGHBBGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public DJEMCOGPGPN.ANDIJIKJCAA ALCPFHEBEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public float GLCINGIJOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public float JBCDBJBMFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public float JDHLPEACKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public float EADBFBOPBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public float CHBCJCPOKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public float BKKLOMILFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public float FNNEJEKAILK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private struct FFBGJKFJEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public NativeArray<float3> HOBJGDJLFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public NativeArray<float3> ADHEBJIOBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NativeArray<float4> LHMIDMPAOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public NativeArray<float4> IDEFIPDMGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public NativeArray<float2> GNBJGLIKPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public NativeArray<int> JHJMFPLBLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public bool CJAMNBEAIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int DCHGDNOGAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int BGNONGNFGEP;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D46320", Offset = "0x7D45320", VA = "0x187D46320")]
		public void KIBJNNMKGPB(int DIGNHEFBOML, int FNBPJBGCLCH, Allocator NDFENJBGNOB, bool KLNAIMNEAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D460D0", Offset = "0x7D450D0", VA = "0x187D460D0")]
		public static FFBGJKFJEMK HACIHALLGJB(OFNFOCEBPOF KIDPOMGFMKB)
		{
			return default(FFBGJKFJEMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D46500", Offset = "0x7D45500", VA = "0x187D46500")]
		public void NNOHEEPCFHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static readonly ProfilerMarker FFIHOLMGEOO;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private static readonly ProfilerMarker AIFECELLHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeArray<KCBPLANBOOB> EIFIPCJALGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private FFBGJKFJEMK JKOBMMKKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private FFBGJKFJEMK HGGCKJDDOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private float3 DIOPGJLMJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private float3 EKNEHFNLAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private PDCMGHBBGDL LNCPHFLFMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* HPHGKKKPONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NativeArray<KIEGPPHBLFN.KENJAAMBBKH> IOFPBEMJMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private NativeList<KIEGPPHBLFN.KENJAAMBBKH> PPNKNFKNDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private NativeArray<int> GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private NativeArray<bool> IGHIIACHBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private NativeArray<int> LMMFKHBJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NativeArray<int> PNBGDJBMJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private NativeArray<float> ODBPBPBMPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<int> CPKLNKJJAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeArray<float> GMEHCDKAEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeArray<int> DIKFIIKMHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NativeArray<int> MBAOFNDAPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NativeArray<float> GBNNMAMGJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NativeArray<float> AGEPAEAIGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private NativeArray<int> OMNLELNDLMA;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D49B80", Offset = "0x7D48B80", VA = "0x187D49B80")]
	public JHGLNBKNNFF([In] List<KIEGPPHBLFN.IPFDINKKAHO> OAODMDLEMGK, NativeList<KIEGPPHBLFN.KENJAAMBBKH> DAPPKLECPGN, [In] OFNFOCEBPOF KKGGOGIEMMO, [In] NativeList<KIEGPPHBLFN.KENJAAMBBKH> GEKDPOOGDIH, [In] NativeArray<long> FKLALGKOOLI, float3 NNIHLHEKIIO, float3 BOKCLNKNBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D476E0", Offset = "0x7D466E0", VA = "0x187D476E0")]
	public static long HEGFHCAGMEP(int DIGNHEFBOML, int FNBPJBGCLCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D46D00", Offset = "0x7D45D00", VA = "0x187D46D00", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D48E40", Offset = "0x7D47E40", VA = "0x187D48E40")]
	public void NFHFMOODOOF(List<KIEGPPHBLFN.IPFDINKKAHO> BIEHBDBDOBB, [In] KIEGPPHBLFN JHHOGAOOKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D49890", Offset = "0x7D48890", VA = "0x187D49890")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool PJICHAKKJIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D498B0", Offset = "0x7D488B0", VA = "0x187D498B0")]
	private DJEOHGJJNMK PKGKNNCNNIO(int BFHMHGDMJOG, Allocator NDFENJBGNOB)
	{
		return default(DJEOHGJJNMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D47700", Offset = "0x7D46700", VA = "0x187D47700")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void KGFLMIFILME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D46D50", Offset = "0x7D45D50", VA = "0x187D46D50")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private float FHLMBKOBNMI(int MKBPNJMCCND, int GCNGLIJDKGH, bool MMNBDACEPAD, bool MHLBDAJDFJP, float IKNHDAMJPCE, float HCHLEGIHMHM, float MHILKPNDBBL, float GBFCDMJJAPN, float PNOOGGBIFCJ, float NNPEHBADGFK, float KNMPOKONKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D473C0", Offset = "0x7D463C0", VA = "0x187D473C0")]
	[IgnoreWarning(1371)]
	private KCBPLANBOOB GBOBBLFADBF([In] KCBPLANBOOB KLPAJCMEKII, int GKPOADKKMDM, [In] NativeArray<int> HKHJDBHLOPP, [In] NativeArray<bool> IGHIIACHBOA, NativeArray<int> LMMFKHBJDIP)
	{
		return default(KCBPLANBOOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D46B20", Offset = "0x7D45B20", VA = "0x187D46B20")]
	public static int EGAKBEKFIHE(NativeArray<int> HKHJDBHLOPP, NativeArray<int> OMNLELNDLMA, int MACBDDAMODJ, int GLEGNJIFIED, int IEDAHFFFKCJ)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct IDJBAEFMABM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public long KFCNBMCPLCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public KDIOIEALNPI HJOECMEGBKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public NGPLIHHOGDL PEPFHNJFNIL;

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7D46AF0", Offset = "0x7D45AF0", VA = "0x187D46AF0")]
			public IDJBAEFMABM(KDIOIEALNPI AGNPHNMIEFB, NGPLIHHOGDL FBMKLBOIHMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private class EJKFCICPPBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public KDIOIEALNPI HJOECMEGBKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public int NPGNODKKKAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public float ADGLAAPPBIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public List<IDJBAEFMABM> LHHLMCNOLOM;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x7D46020", Offset = "0x7D45020", VA = "0x187D46020")]
			public EJKFCICPPBA(KDIOIEALNPI AGNPHNMIEFB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private static readonly ProfilerMarker INKDJLIDIFI;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private static readonly ProfilerMarker IDOFHOPJDIJ;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private static readonly ProfilerMarker EKJPHMHNCLA;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private static readonly ProfilerMarker CDGPAKCOLEL;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly ProfilerMarker BOBDGAKPBBH;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly ProfilerMarker JFPCJBHEKAE;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private static readonly ProfilerMarker CDMBLMKELFA;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		internal const int OAEGIBLMNPI = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		internal static Dictionary<Material, List<Material>> KKCOLCNELLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Dictionary<Material, List<OKLBNCJDEJN>> NJKIHDOIKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		internal List<OKLBNCJDEJN> MAHLGJGPOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private List<MeshRenderer> IFBHHOGBBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private Transform KGPIBDKDEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private bool FADOJKIICHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private bool HJIHOEALKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int OKCGKMIDCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private OKLBNCJDEJN CDNKMLMMDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private Material JNIPHPEILEC;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static bool? BNKAHJNAFHA;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private const int BKFLAPOBIFM = 1024;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static List<IDJBAEFMABM> PDGDBDPGBMC;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IReadOnlyList<MeshRenderer> PIFPEDKKNGF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int APEKNCGIPBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7D44E30", Offset = "0x7D43E30", VA = "0x187D44E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private static bool JJLJKIAHCAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7D40410", Offset = "0x7D3F410", VA = "0x187D40410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		private static void BOBFKAFJECN(bool MGJLPBKKAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		private static void BOBFKAFJECN(bool MGJLPBKKAON, string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		private static void BNPJCHBKEAI(string NFHOBPDKIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EBF0", Offset = "0x7D3DBF0", VA = "0x187D3EBF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D40540", Offset = "0x7D3F540", VA = "0x187D40540")]
		internal bool KAMODMDPNIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D415B0", Offset = "0x7D405B0", VA = "0x187D415B0")]
		private Transform NKPNPPDHCJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D41630", Offset = "0x7D40630", VA = "0x187D41630")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EF80", Offset = "0x7D3DF80", VA = "0x187D3EF80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E9D0", Offset = "0x7D3D9D0", VA = "0x187D3E9D0")]
		public OKLBNCJDEJN AddToBatchedMesh(NGPLIHHOGDL OGGHKIMHDCK, Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D448F0", Offset = "0x7D438F0", VA = "0x187D448F0")]
		public void RemoveFromBatchedMesh(NGPLIHHOGDL PEPFHNJFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D3ED50", Offset = "0x7D3DD50", VA = "0x187D3ED50")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D41530", Offset = "0x7D40530", VA = "0x187D41530")]
		private void NAKOPBNMDAP(Renderer CCKFDFMBDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D403A0", Offset = "0x7D3F3A0", VA = "0x187D403A0")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D40390", Offset = "0x7D3F390", VA = "0x187D40390")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F390", Offset = "0x7D3E390", VA = "0x187D3F390")]
		private void FOEGLMJNFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D40FD0", Offset = "0x7D3FFD0", VA = "0x187D40FD0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D41640", Offset = "0x7D40640", VA = "0x187D41640")]
		private OKLBNCJDEJN PCNHDOEHBKM(NGPLIHHOGDL PEPFHNJFNIL, Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D400B0", Offset = "0x7D3F0B0", VA = "0x187D400B0")]
		private OKLBNCJDEJN IOMHMLGDBJJ(Material CANJBFKPEMF, int GDJHMFCCOAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D405A0", Offset = "0x7D3F5A0", VA = "0x187D405A0")]
		private OKLBNCJDEJN KLFLEEDNCLI(Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D40DD0", Offset = "0x7D3FDD0", VA = "0x187D40DD0")]
		internal float4x4 LHNFKBIAFPH()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F900", Offset = "0x7D3E900", VA = "0x187D3F900")]
		public static List<Material> GenerateVertexFormatVariants(Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x12F3CD0", Offset = "0x12F2CD0", VA = "0x1812F3CD0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D40E70", Offset = "0x7D3FE70", VA = "0x187D40E70")]
		public void MarkDirty(NGPLIHHOGDL PEPFHNJFNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EE80", Offset = "0x7D3DE80", VA = "0x187D3EE80")]
		[Conditional("CHECK_STATE")]
		private void DAJOJALMHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D41150", Offset = "0x7D40150", VA = "0x187D41150")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float PIBHOPJHMPJ)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EC20", Offset = "0x7D3DC20", VA = "0x187D3EC20")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D43750", Offset = "0x7D42750", VA = "0x187D43750")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D3FA20", Offset = "0x7D3EA20", VA = "0x187D3FA20")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D41940", Offset = "0x7D40940", VA = "0x187D41940")]
		public void RebatchOptimally(int KBBHJFBEOEF, int DEJDELGNNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D41860", Offset = "0x7D40860", VA = "0x187D41860")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D44D00", Offset = "0x7D43D00", VA = "0x187D44D00")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class BMMIIAFLHKB
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private struct JLOJHIHMCAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public BatchedMeshRenderer CCKFDFMBDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public OKLBNCJDEJN PEPFHNJFNIL;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x19C6FB0", Offset = "0x19C5FB0", VA = "0x1819C6FB0")]
		public void LJCOBGHNIAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct LGKKMFDCEHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public float EKONEIGCNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public OKLBNCJDEJN CJPKNPBCNMN;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class DAANEGLFNLM : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x111FC50", Offset = "0x111EC50", VA = "0x18111FC50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x7D45EB0", Offset = "0x7D44EB0", VA = "0x187D45EB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x126B660", Offset = "0x126A660", VA = "0x18126B660")]
		[DebuggerHidden]
		public DAANEGLFNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D45F00", Offset = "0x7D44F00", VA = "0x187D45F00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D44ED0", Offset = "0x7D43ED0", VA = "0x187D44ED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D44E80", Offset = "0x7D43E80", VA = "0x187D44E80")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D60", Offset = "0x7D44D60", VA = "0x187D45D60")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D45E60", Offset = "0x7D44E60", VA = "0x187D45E60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D45DB0", Offset = "0x7D44DB0", VA = "0x187D45DB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D45DB0", Offset = "0x7D44DB0", VA = "0x187D45DB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private static readonly ProfilerMarker JFPCJBHEKAE;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly ProfilerMarker FMJJDGKBDBC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private static readonly ProfilerMarker LEHPOCCGDMG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private static readonly ProfilerMarker CNHPMNICAOL;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static float3 NBANKJBDDHN;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static int PEIHKGCKEHP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static int KNOFFNBLKHJ;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static int ANAGCCEFGEM;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static int LGOHPCPJEBN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static int FFMPHJCHCDM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static float JNDLBCDPPFL;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static float PHELMBJFFMP;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static float NAJKMMMBCON;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static float APIGBLFPDAG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static float DKKOKCLNBML;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static float LIEEHNBHFEF;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static float HKNFIMLNAKF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static float PLBFEBJGBOI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static List<BatchedMeshRenderer> NLPDAEJHBCO;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static Stack<OFNFOCEBPOF> JNFABGKGMED;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static Stack<KCFHOMPPIJH> JIBHFCPIFAL;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static LGCPEOGBNJG BJFHMAIIJIJ;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static JLOJHIHMCAC IONLAKIKPAD;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int GOGPJHLIHHL;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void ODFMLCAGHLK(bool MGJLPBKKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void BOBFKAFJECN(bool MGJLPBKKAON, string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B7F0", Offset = "0x7D3A7F0", VA = "0x187D3B7F0")]
	public static void EEBICEODLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D810", Offset = "0x7D3C810", VA = "0x187D3D810")]
	public static void NOBAPAAKCFN(BatchedMeshRenderer FCNPIHMGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CF50", Offset = "0x7D3BF50", VA = "0x187D3CF50")]
	public static void MGFANGEFBPK(BatchedMeshRenderer FCNPIHMGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D080", Offset = "0x7D3C080", VA = "0x187D3D080")]
	public static void MLAMOEJNJKC(NGPLIHHOGDL CKADCHJDBCK, bool IICMENMBKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA50", Offset = "0x7D3BA50", VA = "0x187D3CA50")]
	public static void LMNGDKBCMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BEF0", Offset = "0x7D3AEF0", VA = "0x187D3BEF0")]
	public static void KFJOABALDDM(float PIBHOPJHMPJ, bool CJDIFDICHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B9F0", Offset = "0x7D3A9F0", VA = "0x187D3B9F0")]
	private static void JAHFAHPEGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DBE0", Offset = "0x7D3CBE0", VA = "0x187D3DBE0")]
	public static long PALMNFJKMNN(int JOGNGOBMBGL, long EGAJOCMKJMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B400", Offset = "0x7D3A400", VA = "0x187D3B400")]
	public static (long, long, int) CHGILEAHEJJ(float PIBHOPJHMPJ)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B370", Offset = "0x7D3A370", VA = "0x187D3B370")]
	[IteratorStateMachine(typeof(DAANEGLFNLM))]
	public static IEnumerable<bool> AGPELJBAJBE(long GNHOOPBOHLL, bool JHOMJFLILMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C7B0", Offset = "0x7D3B7B0", VA = "0x187D3C7B0")]
	public static void LKHLBAGODLL(long GNHOOPBOHLL, bool JHOMJFLILMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CDD0", Offset = "0x7D3BDD0", VA = "0x187D3CDD0")]
	public static int LOAOPOGGAJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B870", Offset = "0x7D3A870", VA = "0x187D3B870")]
	internal static OFNFOCEBPOF EPFCBBFNHPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DAA0", Offset = "0x7D3CAA0", VA = "0x187D3DAA0")]
	internal static void PAIJEJJJMFM(OFNFOCEBPOF FPLCOEMPHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D950", Offset = "0x7D3C950", VA = "0x187D3D950")]
	internal static KCFHOMPPIJH OGGCJFCKPJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DB50", Offset = "0x7D3CB50", VA = "0x187D3DB50")]
	internal static void PAIJEJJJMFM(KCFHOMPPIJH JJJNFMILJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B610", Offset = "0x7D3A610", VA = "0x187D3B610")]
	public static void EDJCMGEEDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public class GMHENEKBFCA<KeyType> : OKLBNCJDEJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private readonly Dictionary<KeyType, NGPLIHHOGDL> ILMOCGLICFJ;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4A92EB0", Offset = "0x4A91EB0", VA = "0x184A92EB0")]
	public GMHENEKBFCA(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A92DE0", Offset = "0x4A91DE0", VA = "0x184A92DE0")]
	public void GKAHHFADIKG(KeyType OEHHKNIGGMI, NGPLIHHOGDL CKADCHJDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A92A20", Offset = "0x4A91A20", VA = "0x184A92A20")]
	public bool ABGKOHANAPD(KeyType OEHHKNIGGMI, NGPLIHHOGDL CELABBJHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A92C20", Offset = "0x4A91C20", VA = "0x184A92C20")]
	public void FKIPNLBHINN(KeyType OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A92E50", Offset = "0x4A91E50", VA = "0x184A92E50", Slot = "4")]
	public override void NCJBLPKGOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class MOFAAAHJOFC
{
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly ProfilerCategory EKNIIMOGGJF;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	internal static readonly ProfilerMarker IIADEAEDMOD;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	internal static readonly BEDEOPJHJKF KFJOABALDDM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private static readonly ECIHEKFBODF<float> MGAJBCLDHAG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly ECIHEKFBODF<float> EOMNOFEBLEH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private static readonly ECIHEKFBODF<double> OICLKDOEPMG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly ECIHEKFBODF<double> GGHHICCBCFK;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private static readonly ECIHEKFBODF<double> HFAKCKACPOK;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private static readonly ECIHEKFBODF<int> LAJDFIJOKLM;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly ECIHEKFBODF<int> HAKHFNPKMAK;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly ECIHEKFBODF<int> HCADJNCOMCL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly ECIHEKFBODF<int> BODJLIIAAIL;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly ECIHEKFBODF<int> ALFFMJKMFHF;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly ECIHEKFBODF<long> LKNJBDAJCHH;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly ECIHEKFBODF<long> BNGFPKOOGBG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly ECIHEKFBODF<long> IPHJHEIJEEG;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly ECIHEKFBODF<long> GPFNLGCHKMA;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly ECIHEKFBODF<long> NABBOMOLKIK;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A450", Offset = "0x7D49450", VA = "0x187D4A450")]
	public static void PHBDGACNPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BC60", Offset = "0x7D4AC60", VA = "0x187D4BC60")]
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
